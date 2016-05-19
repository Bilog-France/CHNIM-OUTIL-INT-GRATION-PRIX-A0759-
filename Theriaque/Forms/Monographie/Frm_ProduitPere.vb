''' <summary>
''' Created By [BFE]
''' </summary>
''' <remarks> Monographie - Produit - Père
''' </remarks>
Public Class Frm_ProduitPere

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_GPR_PERE_PRODUIT
        f.Text = Me.Text
        f.ShowDialog()
        If f._Code IsNot Nothing Then
            GC.DataSource = Nothing
            Me.DsTheriaque_Produit.GPR_PERE_PRODUIT.Clear()
            Me.DsTheriaque_Produit.PR_PRODUIT.Clear()
            Me.GpR_TA.FillByCode(Me.DsTheriaque_Produit.GPR_PERE_PRODUIT, f._Code)
            Me.PR_TA.Fill(Me.DsTheriaque_Produit.PR_PRODUIT)
            GC.DataSource = cn.MySelect("SELECT * FROM THERIAQUE.PR_PRODUIT WHERE PR_GPR_CODE_FK = " & f._Code)
            InitLkup(rpPR, "PR_PRODUIT", strSSQL_PR_PRODUIT & " WHERE PR_GPR_CODE_FK IS NULL OR PR_GPR_CODE_FK = " & txtCode.Text, True)
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub DeleteRow(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.Remove Then
            If GV.GetRowCellValue(Me.GV.FocusedRowHandle, Me.colPR_CODE_SQ_PK) IsNot DBNull.Value Then
                If GV.GetRowCellValue(Me.GV.FocusedRowHandle, Me.colPR_CODE_SQ_PK) IsNot Nothing Then
                    Dim dv As New DataView
                    Dim Code As Integer = GV.GetRowCellValue(Me.GV.FocusedRowHandle, Me.colPR_CODE_SQ_PK)
                    dv = Me.DsTheriaque_Produit.PR_PRODUIT.DefaultView
                    dv.RowFilter = " PR_CODE_SQ_PK = " & Code
                    dv.Item(0)("PR_GPR_CODE_FK") = DBNull.Value
                    dv.RowFilter = ""
                End If
            End If
        End If
    End Sub

    Public Overrides Sub Ajouter()
        GC.DataSource = Nothing
        Me.DsTheriaque_Produit.GPR_PERE_PRODUIT.Clear()
        Me.DsTheriaque_Produit.PR_PRODUIT.Clear()
        Me.BindingContext(Me.DsTheriaque_Produit, GPR_PERE_PRODUIT).AddNew()
        txtCode.Text = Code_MAx(GPR_PERE_PRODUIT, txtCode) + 1
        GC.DataSource = cn.MySelect("SELECT * FROM THERIAQUE.PR_PRODUIT WHERE PR_GPR_CODE_FK = " & txtCode.Text)
        InitLkup(rpPR, "PR_PRODUIT", strSSQL_PR_PRODUIT & " WHERE PR_GPR_CODE_FK IS NULL", True)
        If Me.DsTheriaque_Produit.PR_PRODUIT.Rows.Count = 0 Then
            Me.PR_TA.Fill(Me.DsTheriaque_Produit.PR_PRODUIT)
        End If

        MyBase.Ajouter()
    End Sub

    Public Overrides Sub Valider()
        MyBase.Valider()
        Me.BindingContext(Me.DsTheriaque_Produit, MasterTable).EndCurrentEdit()
        GpR_TA.Update(Me.DsTheriaque_Produit.GPR_PERE_PRODUIT)

        Me.BindingContext(Me.DsTheriaque_Produit, PR_PRODUIT).EndCurrentEdit()
        PR_TA.Update(Me.DsTheriaque_Produit.PR_PRODUIT)
        InitLkup(rpPR, "PR_PRODUIT", strSSQL_PR_PRODUIT & " WHERE PR_GPR_CODE_FK IS NULL OR PR_GPR_CODE_FK = " & txtCode.Text, True)
    End Sub

    Public Overrides Sub Annuler()
        MyBase.Annuler()
        Me.BindingContext(Me.DsTheriaque_Produit, PR_PRODUIT).CancelCurrentEdit()
        Me.DsTheriaque_Produit.PR_PRODUIT.RejectChanges()
        Me.BindingContext(Me.DsTheriaque_Produit, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_Produit.GPR_PERE_PRODUIT.RejectChanges()
        If txtCode.Text <> "" Then
            GC.DataSource = cn.MySelect("SELECT * FROM THERIAQUE.PR_PRODUIT WHERE PR_GPR_CODE_FK = " & txtCode.Text)
        End If
    End Sub

    Public Overrides Function Supprimer() As Boolean
        MyBase.Supprimer()

        Dim dv As DataView = Me.DsTheriaque_Produit.PR_PRODUIT.DefaultView
        dv.RowFilter = " PR_GPR_CODE_FK = " & txtCode.Text
        For inti As Integer = 0 To dv.Count - 1
            dv.Item(0)("PR_GPR_CODE_FK") = DBNull.Value
        Next
        dv.RowFilter = ""
        Me.BindingContext(Me.DsTheriaque_Produit, PR_PRODUIT).EndCurrentEdit()
        PR_TA.Update(Me.DsTheriaque_Produit.PR_PRODUIT)

        DsTheriaque_Produit.GPR_PERE_PRODUIT.Rows(0).Delete()
        Me.GpR_TA.Update(Me.DsTheriaque_Produit)
        Me.GC.DataSource = Nothing

        Return True
    End Function

    Private Sub Frm_ProduitPere_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InitVariable()
        AddHandler GC.EmbeddedNavigator.ButtonClick, AddressOf DeleteRow
    End Sub

    Private Sub InitVariable()
        FirstFocus = txtLibelle
        MasterDataSet = Me.DsTheriaque_Produit
        MasterTable = GPR_PERE_PRODUIT
        InitLkup(rpPR, "PR_PRODUIT", strSSQL_PR_PRODUIT & " WHERE PR_GPR_CODE_FK IS NULL", True)
    End Sub

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

    Private Sub GV_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV.FocusedRowChanged
        If GV.GetRowCellValue(Me.GV.FocusedRowHandle, Me.colPR_CODE_SQ_PK) IsNot DBNull.Value Then
            If GV.GetRowCellValue(Me.GV.FocusedRowHandle, Me.colPR_CODE_SQ_PK) IsNot Nothing Then
                Me.colPR_NOM.OptionsColumn.AllowFocus = False
                Me.colPR_CODE_SQ_PK.OptionsColumn.AllowFocus = False
            Else
                Me.colPR_NOM.OptionsColumn.AllowFocus = True
                Me.colPR_CODE_SQ_PK.OptionsColumn.AllowFocus = True
            End If
        Else
            Me.colPR_NOM.OptionsColumn.AllowFocus = True
            Me.colPR_CODE_SQ_PK.OptionsColumn.AllowFocus = True
        End If
    End Sub

    Private Sub GV_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        If GV.GetRowCellValue(Me.GV.FocusedRowHandle, Me.colPR_CODE_SQ_PK) IsNot DBNull.Value Then
            If GV.GetRowCellValue(Me.GV.FocusedRowHandle, Me.colPR_CODE_SQ_PK) IsNot Nothing Then
                Dim dv As New DataView
                Dim Code As Integer = GV.GetRowCellValue(Me.GV.FocusedRowHandle, Me.colPR_CODE_SQ_PK)
                For inti As Integer = 0 To GV.RowCount - 1
                    If GV.GetRowCellValue(inti, "PR_CODE_SQ_PK") = Code Then
                        e.Valid = False
                        e.ErrorText = StrValeurExist
                        Exit Sub
                    End If
                Next
                dv = Me.DsTheriaque_Produit.PR_PRODUIT.DefaultView
                dv.RowFilter = " PR_CODE_SQ_PK = " & Code
                If dv.Count > 0 Then
                    dv.Item(0)("PR_GPR_CODE_FK") = txtCode.Text
                End If
                dv.RowFilter = ""
            End If
        End If
    End Sub

    Private Sub txtLibelle_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLibelle.Validated
        Dim strSSQL As String
        strSSQL = "  SELECT * FROM THERIAQUE.GPR_PERE_PRODUIT WHERE GPR_CODE_SQ_PK <> " & cn.SQLText(txtCode.Text)
        strSSQL &= " AND UPPER(GPR_NOM) = " & UCase(cn.SQLText(txtLibelle.Text))
        Dim dt As DataTable = cn.MySelect(strSSQL)
        If dt.Rows.Count > 0 Then
            Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist)
        Else
            Me.DxErrorProvider.SetError(txtLibelle, "")
        End If
    End Sub
End Class
