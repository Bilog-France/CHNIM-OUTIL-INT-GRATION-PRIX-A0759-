''' <summary>
''' Created By [BFE]
''' </summary>
''' <remarks> Monographie - Excipient - Père
''' </remarks>
Public Class Frm_ExcipientPere

#Region " Edit Data "

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_GSAU_PERE_SUBAUX
        f.Text = Me.Text
        f.ShowDialog()
        If f._Code IsNot Nothing Then
            GC.DataSource = Nothing
            Me.DsTheriaque_Excipient.GSAU_PERE_SUBAUX.Clear()
            Me.DsTheriaque_Excipient.SAU_SUBAUXILIAIRE.Clear()
            Me.GSAU_TA.FillByCode(Me.DsTheriaque_Excipient.GSAU_PERE_SUBAUX, f._Code)
            Me.SaU_TA.Fill(Me.DsTheriaque_Excipient.SAU_SUBAUXILIAIRE)
            GC.DataSource = cn.MySelect("SELECT * FROM THERIAQUE.SAU_SUBAUXILIAIRE WHERE SAU_GSAU_CODE_FK = " & f._Code)
            InitLkup(rpSau, "SAU_SUBAUXILIAIRE", strSSQL_SAU_SUBAUXILIAIRE & " WHERE SAU_GSAU_CODE_FK IS NULL OR SAU_GSAU_CODE_FK = " & txtCode.Text, True)
            Return True
        Else
            Return False
        End If
    End Function
    Public Overrides Sub Ajouter()
        GC.DataSource = Nothing
        Me.DsTheriaque_Excipient.GSAU_PERE_SUBAUX.Clear()
        Me.DsTheriaque_Excipient.SAU_SUBAUXILIAIRE.Clear()
        Me.BindingContext(Me.DsTheriaque_Excipient, GSAU_PERE_SUBAUX).AddNew()
        txtCode.Text = Code_MAx(GSAU_PERE_SUBAUX, txtCode) + 1

        GC.DataSource = cn.MySelect("SELECT * FROM THERIAQUE.SAU_SUBAUXILIAIRE WHERE SAU_GSAU_CODE_FK = " & txtCode.Text)
        InitLkup(rpSau, "SAU_SUBAUXILIAIRE", strSSQL_SAU_SUBAUXILIAIRE & " WHERE SAU_GSAU_CODE_FK IS NULL", True)
        If Me.DsTheriaque_Excipient.SAU_SUBAUXILIAIRE.Rows.Count = 0 Then
            Me.SaU_TA.Fill(Me.DsTheriaque_Excipient.SAU_SUBAUXILIAIRE)
        End If

        MyBase.Ajouter()
    End Sub
    Public Overrides Sub Valider()
        MyBase.Valider()
        Me.BindingContext(Me.DsTheriaque_Excipient, MasterTable).EndCurrentEdit()
        GSAU_TA.Update(Me.DsTheriaque_Excipient.GSAU_PERE_SUBAUX)

        Me.BindingContext(Me.DsTheriaque_Excipient, SAU_SUBAUXILIAIRE).EndCurrentEdit()
        SaU_TA.Update(Me.DsTheriaque_Excipient.SAU_SUBAUXILIAIRE)

        InitLkup(rpSau, "SAU_SUBAUXILIAIRE", strSSQL_SAU_SUBAUXILIAIRE & " WHERE SAU_GSAU_CODE_FK IS NULL OR SAU_GSAU_CODE_FK = " & txtCode.Text, True)
    End Sub
    Public Overrides Sub Annuler()
        MyBase.Annuler()

        Me.BindingContext(Me.DsTheriaque_Excipient, SAU_SUBAUXILIAIRE).CancelCurrentEdit()
        Me.DsTheriaque_Excipient.SAU_SUBAUXILIAIRE.RejectChanges()
        Me.BindingContext(Me.DsTheriaque_Excipient, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_Excipient.GSAU_PERE_SUBAUX.RejectChanges()
        If txtCode.Text <> "" Then
            GC.DataSource = cn.MySelect("SELECT * FROM THERIAQUE.SAU_SUBAUXILIAIRE WHERE SAU_GSAU_CODE_FK = " & txtCode.Text)
        End If
    End Sub
    Public Overrides Function Supprimer() As Boolean
        MyBase.Supprimer()

        Dim dv As DataView = Me.DsTheriaque_Excipient.SAU_SUBAUXILIAIRE.DefaultView
        dv.RowFilter = " SAU_GSAU_CODE_FK = " & txtCode.Text
        For inti As Integer = 0 To dv.Count - 1
            dv.Item(0)("SAU_GSAU_CODE_FK") = DBNull.Value
        Next
        dv.RowFilter = ""
        Me.BindingContext(Me.DsTheriaque_Excipient, SAU_SUBAUXILIAIRE).EndCurrentEdit()
        SaU_TA.Update(Me.DsTheriaque_Excipient.SAU_SUBAUXILIAIRE)

        DsTheriaque_Excipient.GSAU_PERE_SUBAUX.Rows(0).Delete()
        Me.GSAU_TA.Update(Me.DsTheriaque_Excipient)
        Me.GC.DataSource = Nothing

        Return True
    End Function
    Protected Friend Overrides Function ValideControl(Optional ByRef Ctrl As Control = Nothing, Optional ByVal AllCtrl As Boolean = True) As Boolean
        MyBase.ValideControl(Ctrl)
        Dim iCount As Integer
        iCount = GV.RowCount
        If iCount < 3 Then
            Process_Message(strPere_Fils, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If
        Return True
    End Function

#End Region
#Region " Init Data  "

    Private Sub Frm_ExcipientPere_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InitVariable()
        AddHandler GC.EmbeddedNavigator.ButtonClick, AddressOf DeleteRow
    End Sub
    Private Sub InitVariable()
        FirstFocus = txtLibelle
        MasterDataSet = Me.DsTheriaque_Excipient
        MasterTable = GSAU_PERE_SUBAUX
        InitLkup(rpSau, "SAU_SUBAUXILIAIRE", strSSQL_SAU_SUBAUXILIAIRE & " WHERE SAU_GSAU_CODE_FK IS NULL", True)
    End Sub

#End Region
#Region " GV "

    Public Sub DeleteRow(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.Remove Then
            If GV.GetRowCellValue(Me.GV.FocusedRowHandle, Me.colSAU_CODE_SQ_PK) IsNot DBNull.Value Then
                If GV.GetRowCellValue(Me.GV.FocusedRowHandle, Me.colSAU_CODE_SQ_PK) IsNot Nothing Then
                    Dim dv As New DataView
                    Dim Code As Integer = GV.GetRowCellValue(Me.GV.FocusedRowHandle, Me.colSAU_CODE_SQ_PK)
                    dv = Me.DsTheriaque_Excipient.SAU_SUBAUXILIAIRE.DefaultView
                    dv.RowFilter = " SAU_CODE_SQ_PK = " & Code
                    dv.Item(0)("SAU_GSAU_CODE_FK") = DBNull.Value
                    dv.RowFilter = ""
                End If
            End If
        End If
    End Sub
    Private Sub GV_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV.FocusedRowChanged
        If GV.GetRowCellValue(Me.GV.FocusedRowHandle, Me.colSAU_CODE_SQ_PK) IsNot DBNull.Value Then
            If GV.GetRowCellValue(Me.GV.FocusedRowHandle, Me.colSAU_CODE_SQ_PK) IsNot Nothing Then
                Me.colSAU_NOM.OptionsColumn.AllowFocus = False
                Me.colSAU_CODE_SQ_PK.OptionsColumn.AllowFocus = False
            Else
                Me.colSAU_NOM.OptionsColumn.AllowFocus = True
                Me.colSAU_CODE_SQ_PK.OptionsColumn.AllowFocus = True
            End If
        Else
            Me.colSAU_NOM.OptionsColumn.AllowFocus = True
            Me.colSAU_CODE_SQ_PK.OptionsColumn.AllowFocus = True
        End If
    End Sub
    Private Sub GV_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        If GV.GetRowCellValue(Me.GV.FocusedRowHandle, Me.colSAU_CODE_SQ_PK) IsNot DBNull.Value Then
            If GV.GetRowCellValue(Me.GV.FocusedRowHandle, Me.colSAU_CODE_SQ_PK) IsNot Nothing Then
                Dim dv As New DataView
                Dim Code As Integer = GV.GetRowCellValue(Me.GV.FocusedRowHandle, Me.colSAU_CODE_SQ_PK)
                For inti As Integer = 0 To GV.RowCount - 1
                    If GV.GetRowCellValue(inti, "SAU_CODE_SQ_PK") = Code Then
                        e.Valid = False
                        e.ErrorText = StrValeurExist
                        Exit Sub
                    End If
                Next
                dv = Me.DsTheriaque_Excipient.SAU_SUBAUXILIAIRE.DefaultView
                dv.RowFilter = " SAU_CODE_SQ_PK = " & Code
                If dv.Count > 0 Then
                    dv.Item(0)("SAU_GSAU_CODE_FK") = txtCode.Text
                End If
                dv.RowFilter = ""
            End If
        End If
    End Sub

#End Region

    Private Sub txtLibelle_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLibelle.Validated
        Dim strSSQL As String
        strSSQL = "  SELECT * FROM THERIAQUE.GSAU_PERE_SUBAUX WHERE GSAU_CODE_SQ_PK <> " & cn.SQLText(txtCode.Text)
        strSSQL &= " AND UPPER(GSAU_NOM) = " & UCase(cn.SQLText(txtLibelle.Text))
        Dim dt As DataTable = cn.MySelect(strSSQL)
        If dt.Rows.Count > 0 Then
            Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist)
        Else
            Me.DxErrorProvider.SetError(txtLibelle, "")
        End If
    End Sub
End Class
