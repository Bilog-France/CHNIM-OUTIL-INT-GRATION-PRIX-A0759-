''' <summary>
''' Created By [BFE]
''' </summary>
''' <remarks> Monographie - Produit - Fils
''' </remarks>
Public Class Frm_ProduitFils

#Region "Déclaration des variables privées"
    Private CodE As String
#End Region

#Region " Edit Data "

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_PR_PRODUIT
        f.Text = Me.Text
        f.ShowDialog()
        Code = f._Code
        If f._Code IsNot Nothing Then
            Me.PR_TA.FillByCode(Me.DsTheriaque_Produit.PR_PRODUIT, CodE)
            Me.GpR_TA.FillByCode(Me.DsTheriaque_Produit.GPR_PERE_PRODUIT, CodE)
            Me.SypR_TA.FillByCode(Me.DsTheriaque_Produit.SYPR_SYNONYME_PRODUIT, CodE)
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Function ChercherAvance() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_SYPR_SYNONYME_PR
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            Me.PR_TA.FillByCode(Me.DsTheriaque_Produit.PR_PRODUIT, CodE)
            Me.GpR_TA.FillByCode(Me.DsTheriaque_Produit.GPR_PERE_PRODUIT, CodE)
            Me.SypR_TA.FillByCode(Me.DsTheriaque_Produit.SYPR_SYNONYME_PRODUIT, CodE)
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Sub Ajouter()
        ClearTable()
        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        SetCode_MAx(MasterTable, txtCode)
        CodE = InvalideControl
        MyBase.Ajouter()
    End Sub

    Public Overrides Sub Valider()
        MyBase.Valider()
        'Master
        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        PR_TA.Update(Me.DsTheriaque_Produit.PR_PRODUIT)

        Me.BindingContext(Me.MasterDataSet, GPR_PERE_PRODUIT).EndCurrentEdit()
        GpR_TA.Update(Me.DsTheriaque_Produit.GPR_PERE_PRODUIT)

        Me.BindingContext(Me.MasterDataSet, SYPR_SYNONYME_PRODUIT).EndCurrentEdit()
        SypR_TA.Update(Me.DsTheriaque_Produit.SYPR_SYNONYME_PRODUIT)

    End Sub

    Public Overrides Sub Annuler()
        MyBase.Annuler()

        Me.BindingContext(Me.MasterDataSet, GPR_PERE_PRODUIT).CancelCurrentEdit()
        Me.DsTheriaque_Produit.GPR_PERE_PRODUIT.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SYPR_SYNONYME_PRODUIT).CancelCurrentEdit()
        Me.DsTheriaque_Produit.SYPR_SYNONYME_PRODUIT.RejectChanges()

        'Master
        Me.BindingContext(Me.MasterDataSet, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_Produit.PR_PRODUIT.RejectChanges()
    End Sub

    Public Overrides Function Supprimer() As Boolean
        MyBase.Supprimer()
        Dim iCount As Integer

        For iCount = 0 To DsTheriaque_Produit.GPR_PERE_PRODUIT.Rows.Count - 1
            DsTheriaque_Produit.GPR_PERE_PRODUIT.Rows(iCount).Delete()
        Next
        Me.GpR_TA.Update(DsTheriaque_Produit)

        For iCount = 0 To DsTheriaque_Produit.SYPR_SYNONYME_PRODUIT.Rows.Count - 1
            DsTheriaque_Produit.SYPR_SYNONYME_PRODUIT.Rows(iCount).Delete()
        Next
        Me.SypR_TA.Update(DsTheriaque_Produit)
        'Master
        DsTheriaque_Produit.PR_PRODUIT.Rows(0).Delete()
        Me.PR_TA.Update(Me.DsTheriaque_Produit)
        Return True

    End Function

    Private Sub ClearTable()
        OnLoading = True
        Me.DsTheriaque_Produit.GPR_PERE_PRODUIT.Clear()
        Me.DsTheriaque_Produit.SYPR_SYNONYME_PRODUIT.Clear()
        'Master
        Me.DsTheriaque_Produit.PR_PRODUIT.Clear()
        OnLoading = False
    End Sub

#End Region

#Region " Init Data  "

    Private Sub InitDataSource()
        GC.DataSource = DsTheriaque_Produit
        GC.DataMember = SYPR_SYNONYME_PRODUIT
    End Sub

    Public Overrides Sub InitData()
        MyBase.InitData()
        OnLoading = True
        MasterDataSet = Me.DsTheriaque_Produit
        MasterTable = PR_PRODUIT
        Code = InvalideControl
        InitLkup(lkupPR_GPR_CODE_FK, GPR_PERE_PRODUIT, strSSQL_GPR_PERE_PRODUIT, True)
        InitDataSource()
        FirstFocus = txtCode
        OnLoading = False
    End Sub

#End Region

#Region " New Row "

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.SetFocusedRowCellValue(colSYPR_PR_CODE_FK, txtCode.Text)
    End Sub
#End Region

    Private Sub txtLibelle_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLibelle.Validated
        ValideControl(sender, False)
    End Sub

    Private Sub GV_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV.ValidatingEditor
        If e.Value IsNot Nothing And e.Value IsNot DBNull.Value Then
            If FieldExist(SYPR_SYNONYME_PRODUIT, "SYPR_NOM_PK", e.Value, , " SYPR_PR_CODE_FK <> " & cn.SQLText(txtCode.Text)) Then
                e.Valid = False
                e.ErrorText = StrValeurExist
            End If
            If Trim(UCase(txtLibelle.Text)) = Trim(UCase(e.Value)) Then
                e.Valid = False
                e.ErrorText = strLibelle_Synonyme
            End If
            Dim strSSQL As String
            strSSQL = "  SELECT * FROM THERIAQUE.PR_PRODUIT"
            strSSQL &= " WHERE UPPER(PR_NOM) = " & UCase(cn.SQLText(e.Value))
            Dim dt As DataTable = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                e.Valid = False
                e.ErrorText = "Cette valeur existe déjà comme libellé."
            Else
                Me.DxErrorProvider.SetError(txtLibelle, "")
            End If
        End If
    End Sub

    Protected Friend Overrides Function ValideControl(Optional ByRef Ctrl As Control = Nothing, Optional ByVal AllCtrl As Boolean = True) As Boolean
        MyBase.ValideControl(Ctrl)
        If Ctrl.Name.ToLower = "txtLibelle".ToLower Or AllCtrl Then
            Dim strSSQL As String
            strSSQL = "  SELECT * FROM THERIAQUE.PR_PRODUIT WHERE PR_CODE_SQ_PK  <> " & cn.SQLText(txtCode.Text)
            strSSQL &= " AND UPPER(PR_NOM) = " & UCase(cn.SQLText(txtLibelle.Text))
            Dim dt As DataTable = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist)
                Return False
            Else
                Me.DxErrorProvider.SetError(txtLibelle, "")
            End If

            strSSQL = " SELECT * FROM THERIAQUE.SYPR_SYNONYME_PRODUIT WHERE SYPR_PR_CODE_FK <> " & cn.SQLText(txtCode.Text)
            strSSQL &= " AND UPPER(SYPR_NOM_PK) = " & UCase(cn.SQLText(txtLibelle.Text))
            dt = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist & " comme synonyme")
                Return False
            Else
                Me.DxErrorProvider.SetError(txtLibelle, "")
            End If
            For iCount As Integer = 0 To GV.RowCount - 1
                If UCase(GV.GetRowCellValue(iCount, colSYPR_NOM_PK)) = UCase(Me.txtLibelle.Text) Then
                    Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist & " dans la liste des synonymes")
                    Return False
                End If
            Next
        End If
        Return True
    End Function


End Class
