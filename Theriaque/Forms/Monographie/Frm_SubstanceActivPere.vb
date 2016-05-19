Public Class Frm_SubstanceActivPere

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_GSAC_PERE_SUBACT
        f.Text = Me.Text
        f.ShowDialog()
        If f._Code IsNot Nothing Then
            GC.DataSource = Nothing
            Me.DsTheriaque_Nomenclature2.GSAC_PERE_SUBACT.Clear()
            Me.DsTheriaque_Nomenclature2.SAC_SUBACTIVE.Clear()
            Me.GsaC_TA.FillByCode(Me.DsTheriaque_Nomenclature2.GSAC_PERE_SUBACT, f._Code)
            Me.SaC_TA.Fill(Me.DsTheriaque_Nomenclature2.SAC_SUBACTIVE)
            GC.DataSource = cn.MySelect("SELECT * FROM THERIAQUE.SAC_SUBACTIVE where SAC_GSAC_CODE_FK = " & f._Code)
            InitLkup(rpSac, "SAC_SUBACTIVE", strSSQL_SAC_SUBACTIVE & " where SAC_GSAC_CODE_FK is NULL or SAC_GSAC_CODE_FK = " & txtCode.Text, True)
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub DeleteRow(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.Remove Then
            If GV.GetRowCellValue(Me.GV.FocusedRowHandle, Me.colSAC_CODE_SQ_PK) IsNot DBNull.Value Then
                If GV.GetRowCellValue(Me.GV.FocusedRowHandle, Me.colSAC_CODE_SQ_PK) IsNot Nothing Then
                    Dim dv As New DataView
                    Dim Code As Integer = GV.GetRowCellValue(Me.GV.FocusedRowHandle, Me.colSAC_CODE_SQ_PK)
                    dv = Me.DsTheriaque_Nomenclature2.SAC_SUBACTIVE.DefaultView
                    dv.RowFilter = " SAC_CODE_SQ_PK = " & Code
                    dv.Item(0)("SAC_GSAC_CODE_FK") = DBNull.Value
                    dv.RowFilter = ""
                End If
            End If
        End If
    End Sub

    Public Overrides Sub Ajouter()
        GC.DataSource = Nothing
        Me.DsTheriaque_Nomenclature2.GSAC_PERE_SUBACT.Clear()
        Me.DsTheriaque_Nomenclature2.SAC_SUBACTIVE.Clear()
        Me.BindingContext(Me.DsTheriaque_Nomenclature2, GSAC_PERE_SUBACT).AddNew()

        txtCode.Text = Code_MAx(GSAC_PERE_SUBACT, txtCode) + 1

        GC.DataSource = cn.MySelect("SELECT * FROM THERIAQUE.SAC_SUBACTIVE where SAC_GSAC_CODE_FK = " & txtCode.Text)
        If Me.DsTheriaque_Nomenclature2.SAC_SUBACTIVE.Rows.Count = 0 Then
            Me.SaC_TA.Fill(Me.DsTheriaque_Nomenclature2.SAC_SUBACTIVE)
        End If

        MyBase.Ajouter()
    End Sub

    Public Overrides Sub Valider()
        MyBase.Valider()
        Me.BindingContext(Me.DsTheriaque_Nomenclature2, MasterTable).EndCurrentEdit()
        GsaC_TA.Update(Me.DsTheriaque_Nomenclature2.GSAC_PERE_SUBACT)

        Me.BindingContext(Me.DsTheriaque_Nomenclature2, SAC_SUBACTIVE).EndCurrentEdit()
        SaC_TA.Update(Me.DsTheriaque_Nomenclature2.SAC_SUBACTIVE)
        InitLkup(rpSac, "SAC_SUBACTIVE", strSSQL_SAC_SUBACTIVE & " where SAC_GSAC_CODE_FK is NULL or SAC_GSAC_CODE_FK = " & txtCode.Text, True)
    End Sub

    Public Overrides Sub Annuler()
        MyBase.Annuler()

        Me.BindingContext(Me.DsTheriaque_Nomenclature2, SAC_SUBACTIVE).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.SAC_SUBACTIVE.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_Nomenclature2, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.GSAC_PERE_SUBACT.RejectChanges()
        If txtCode.Text <> "" Then
            GC.DataSource = cn.MySelect("SELECT * FROM THERIAQUE.SAC_SUBACTIVE where SAC_GSAC_CODE_FK = " & txtCode.Text)
        End If
    End Sub

    Public Overrides Function Supprimer() As Boolean
        MyBase.Supprimer()

        Dim dv As DataView = Me.DsTheriaque_Nomenclature2.SAC_SUBACTIVE.DefaultView
        dv.RowFilter = " SAC_GSAC_CODE_FK = " & txtCode.Text
        For inti As Integer = 0 To dv.Count - 1
            dv.Item(0)("SAC_GSAC_CODE_FK") = DBNull.Value
        Next
        dv.RowFilter = ""
        Me.BindingContext(Me.DsTheriaque_Nomenclature2, SAC_SUBACTIVE).EndCurrentEdit()
        SaC_TA.Update(Me.DsTheriaque_Nomenclature2.SAC_SUBACTIVE)

        DsTheriaque_Nomenclature2.GSAC_PERE_SUBACT.Rows(0).Delete()
        Me.GsaC_TA.Update(Me.DsTheriaque_Nomenclature2)
        Me.GC.DataSource = Nothing

        Return True
    End Function

    Private Sub Frm_PharmacoTherapeutiques_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InitVariable()
        AddHandler GC.EmbeddedNavigator.ButtonClick, AddressOf DeleteRow
    End Sub

    Private Sub InitVariable()
        FirstFocus = txtLibelle
        MasterDataSet = Me.DsTheriaque_Nomenclature2
        MasterTable = GSAC_PERE_SUBACT

        InitLkup(rpSac, "SAC_SUBACTIVE", strSSQL_SAC_SUBACTIVE & " where SAC_GSAC_CODE_FK is NULL", True)
    End Sub

    Protected Friend Overrides Function ValideControl(Optional ByRef Ctrl As Control = Nothing, Optional ByVal AllCtrl As Boolean = True) As Boolean
        MyBase.ValideControl(Ctrl)
        If Ctrl.Name.ToLower = "txtLibelle".ToLower Or AllCtrl Then
            Dim strSSQL As String
            strSSQL = "  SELECT * FROM THERIAQUE.GSAC_PERE_SUBACT WHERE GSAC_CODE_SQ_PK <> " & cn.SQLText(txtCode.Text)
            strSSQL &= " AND UPPER(GSAC_NOM) = " & UCase(cn.SQLText(txtLibelle.Text))
            Dim dt As DataTable = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist)
                Return False
            Else
                Me.DxErrorProvider.SetError(txtLibelle, "")
            End If
        End If
        If Ctrl.Name.ToLower = "btValider".ToLower Or AllCtrl Then
            Dim iCount As Integer
            iCount = GV.RowCount
            If iCount < 3 Then
                Process_Message(strPere_Fils, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub GV_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV.FocusedRowChanged
        If GV.GetRowCellValue(Me.GV.FocusedRowHandle, Me.colSAC_CODE_SQ_PK) IsNot DBNull.Value Then
            If GV.GetRowCellValue(Me.GV.FocusedRowHandle, Me.colSAC_CODE_SQ_PK) IsNot Nothing Then
                Me.colSAC_NOM.OptionsColumn.AllowFocus = False
                Me.colSAC_CODE_SQ_PK.OptionsColumn.AllowFocus = False
            Else
                Me.colSAC_NOM.OptionsColumn.AllowFocus = True
                Me.colSAC_CODE_SQ_PK.OptionsColumn.AllowFocus = True
            End If
        Else
            Me.colSAC_NOM.OptionsColumn.AllowFocus = True
            Me.colSAC_CODE_SQ_PK.OptionsColumn.AllowFocus = True
        End If
    End Sub

    Private Sub GV_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        If GV.GetRowCellValue(Me.GV.FocusedRowHandle, Me.colSAC_CODE_SQ_PK) IsNot DBNull.Value Then
            If GV.GetRowCellValue(Me.GV.FocusedRowHandle, Me.colSAC_CODE_SQ_PK) IsNot Nothing Then
                Dim dv As New DataView
                Dim Code As Integer = GV.GetRowCellValue(Me.GV.FocusedRowHandle, Me.colSAC_CODE_SQ_PK)
                For inti As Integer = 0 To GV.RowCount - 1
                    If GV.GetRowCellValue(inti, "SAC_CODE_SQ_PK") = Code Then
                        e.Valid = False
                        e.ErrorText = StrValeurExist
                        Exit Sub
                    End If
                Next
                dv = Me.DsTheriaque_Nomenclature2.SAC_SUBACTIVE.DefaultView
                dv.RowFilter = " SAC_CODE_SQ_PK = " & Code
                If dv.Count > 0 Then
                    dv.Item(0)("SAC_GSAC_CODE_FK") = txtCode.Text
                End If
                dv.RowFilter = ""
            End If
        End If
    End Sub
    Private Sub txtLibelle_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLibelle.Validated
        ValideControl(sender, False)
    End Sub
End Class
