Public Class Frm_CDF_CIM10_Orphanet

    ''' <summary>
    ''' Code du type de la codification
    ''' </summary>
    ''' <remarks> NN </remarks>
    Public _Code_CDF As String

#Region " Edit Data "

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_CDF_CODIF(_Code_CDF)
        f.Text = Me.Text
        f.ShowDialog()
        If f._Code IsNot Nothing Then
            'ClsSP.initValNum(_Code_CDF, f._Code)
            Me.CdF_CODIFTA.FillByCode(Me.DsTheriaque_Nomenclature21.CDF_CODIF, _Code_CDF, f._Code)
            Me.SycdF_SYNCODIFTableAdapter.FillByCode(Me.DsTheriaque1.SYCDF_SYNCODIF, _Code_CDF, f._Code)
            Me.CimcdF_CIM10_CODIFTableAdapter.FillByCode(Me.DsTheriaque1.CIMCDF_CIM10_CODIF, _Code_CDF, f._Code)
            Me.NaiN_NATURE_INDICATIONTableAdapter.FillByCode(Me.DsTheriaque1.NAIN_NATURE_INDICATION, f._Code)
            Me.CdfnP_CODIFTableAdapter.FillByCodeOrphanet(Me.DsTheriaque1.CDFNP_CODIF, "NP", f._Code)

            Dim res As StructResultCode = Code_PereFils(txtCode, "CDF_CODIF", DxErrorProvider, False, " CDF_NUMERO_PK = " & cn.SQLText(_Code_CDF))
            If res._Validation = True Then txtCodePere.Text = res._Code
            txtCode.Tag = "[NOEDIT]"
            AddMaladie_Orphanet()
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Sub Ajouter()
        Me.DsTheriaque1.SYCDF_SYNCODIF.Clear()
        Me.DsTheriaque_Nomenclature21.CDF_CODIF.Clear()
        Me.DsTheriaque1.CIMCDF_CIM10_CODIF.Clear()
        Me.DsTheriaque1.NAIN_NATURE_INDICATION.Clear()
        Me.DsTheriaque1.CDFNP_CODIF.Clear()
        Me.BindingContext(Me.DsTheriaque_Nomenclature21, CDF_CODIF).AddNew()
        ModeFiche = eMode.Ajout
        SetCDF_Codif(_Code_CDF, Me.txtCode, Me.DxErrorProvider, txtCodePere)
        txtCode.Tag = "[EDIT]"
        txtNCodif.Text = _Code_CDF
        If _Code_CDF = "NN" Then
            txtCodePere.EditValue = DBNull.Value
        End If
        MyBase.Ajouter()
    End Sub

    Public Overrides Sub Valider()
        MyBase.Valider()

        If (String.IsNullOrEmpty(Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).Current("CDF_UNIT_NUM").ToString())) Then
            Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).Current("CDF_UNIT_NUM") = ""
        End If

        If (String.IsNullOrEmpty(Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).Current("CDF_NOMABRG").ToString())) Then
            Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).Current("CDF_NOMABRG") = ""
        End If

        If (String.IsNullOrEmpty(Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).Current("CDF_TEXTE").ToString())) Then
            Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).Current("CDF_TEXTE") = ""
        End If

        Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).EndCurrentEdit()
        CdF_CODIFTA.Update(Me.DsTheriaque_Nomenclature21.CDF_CODIF)

        Me.BindingContext(Me.DsTheriaque1, SYCDF_SYNCODIF).EndCurrentEdit()
        SycdF_SYNCODIFTableAdapter.Update(Me.DsTheriaque1.SYCDF_SYNCODIF)

        Me.BindingContext(Me.DsTheriaque1, CIMCDF_CIM10_CODIF).EndCurrentEdit()
        CimcdF_CIM10_CODIFTableAdapter.Update(Me.DsTheriaque1.CIMCDF_CIM10_CODIF)

        Me.BindingContext(Me.DsTheriaque1, NAIN_NATURE_INDICATION).EndCurrentEdit()
        NaiN_NATURE_INDICATIONTableAdapter.Update(Me.DsTheriaque1.NAIN_NATURE_INDICATION)

        Me.BindingContext(Me.DsTheriaque1, CDFNP_CODIF).EndCurrentEdit()
        CdfnP_CODIFTableAdapter.Update(Me.DsTheriaque1.CDFNP_CODIF)

        InitLkup(lkupCDF_CODE_PK, CDF_CODIF, strSSQL_CDF_CODIF(_Code_CDF), True, False)
        AddMaladie_Orphanet()
    End Sub

    Public Overrides Sub Annuler()
        MyBase.Annuler()
        Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature21.CDF_CODIF.RejectChanges()

        Me.BindingContext(Me.DsTheriaque1, SYCDF_SYNCODIF).CancelCurrentEdit()
        Me.DsTheriaque1.SYCDF_SYNCODIF.RejectChanges()

        Me.BindingContext(Me.DsTheriaque1, CIMCDF_CIM10_CODIF).CancelCurrentEdit()
        Me.DsTheriaque1.CIMCDF_CIM10_CODIF.RejectChanges()

        Me.BindingContext(Me.DsTheriaque1, CDFNP_CODIF).CancelCurrentEdit()
        Me.DsTheriaque1.CDFNP_CODIF.RejectChanges()
        txtCode.Tag = "[NOEDIT]"
    End Sub

    Public Overrides Function Supprimer() As Boolean
        MyBase.Supprimer()
        If TestUsedCodif(_Code_CDF, Me.txtCode.Text) Then
            Process_Message(strIMP_SUPPRIMER, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Dim inti As Integer

            For inti = 0 To DsTheriaque1.SYCDF_SYNCODIF.Rows.Count - 1
                DsTheriaque1.SYCDF_SYNCODIF.Rows(inti).Delete()
            Next

            For inti = 0 To DsTheriaque1.CIMCDF_CIM10_CODIF.Rows.Count - 1
                DsTheriaque1.CIMCDF_CIM10_CODIF.Rows(inti).Delete()
            Next

            For inti = 0 To DsTheriaque1.NAIN_NATURE_INDICATION.Rows.Count - 1
                DsTheriaque1.NAIN_NATURE_INDICATION.Rows(inti).Delete()
            Next

            For inti = 0 To DsTheriaque1.CDFNP_CODIF.Rows.Count - 1
                DsTheriaque1.CDFNP_CODIF.Rows(inti).Delete()
            Next

            DsTheriaque_Nomenclature21.CDF_CODIF.Rows(0).Delete()

            Me.SycdF_SYNCODIFTableAdapter.Update(Me.DsTheriaque1)
            Me.CimcdF_CIM10_CODIFTableAdapter.Update(Me.DsTheriaque1)
            Me.NaiN_NATURE_INDICATIONTableAdapter.Update(Me.DsTheriaque1)
            Me.CdfnP_CODIFTableAdapter.Update(Me.DsTheriaque1)
            Me.CdF_CODIFTA.Update(Me.DsTheriaque_Nomenclature21)

            txtCodePere.EditValue = DBNull.Value
            Return True
        End If
    End Function

    Private Sub Frm_PharmacoTherapeutiques_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InitVariable()
    End Sub

    Private Sub AddMaladie_Orphanet()
        If Me.DsTheriaque1.NAIN_NATURE_INDICATION.Count = 0 Then
            Me.BindingContext(Me.DsTheriaque1, NAIN_NATURE_INDICATION).AddNew()
            Me.BindingContext(Me.DsTheriaque1, NAIN_NATURE_INDICATION).Current("NAIN_CODE_PK") = txtCode.Text
        End If
    End Sub

    Private Sub InitVariable()
        FirstFocus = txtCode
        MasterDataSet = Me.DsTheriaque1
        MasterTable = CDF_CODIF
        Me.Label1.Text = LibNomenclature(_Code_CDF)
        InitLkup(rpCIM10, CIM10, strSSQL_CIM10, True, True, True, , True)
        Me.PanPere.Visible = True
        InitLkup(lkupCDF_CODE_PK, CDF_CODIF, strSSQL_CDF_CODIF(_Code_CDF), True, False)
        If _Code_CDF = "NN" Then
            InitLkup(rpNaturePrincipale, CDF_CODIF, strSSQL_CDF_CODIF("NP"), True, True)
        End If
    End Sub

#End Region

#Region " GV        "

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.SetRowCellValue(e.RowHandle, colSYCDF_CDF_CODE_FK, Me.txtCode.Text)
        GV.SetRowCellValue(e.RowHandle, colSYCDF_CDF_NUMERO_FK_PK, _Code_CDF)
        ModeFiche = eMode.Modification
        UpdateStateBouton()
    End Sub

    Private Sub GV_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV.ValidatingEditor
        If e.Value IsNot Nothing Then
            Dim strSSQL As String = ""

            strSSQL = "Select * from THERIAQUE.SYCDF_SYNCODIF where SYCDF_NOM_PK = " & cn.SQLText(e.Value)
            strSSQL &= " and SYCDF_CDF_NUMERO_FK_PK= " & cn.SQLText(GV.GetRowCellValue(GV.FocusedRowHandle, Me.colSYCDF_CDF_NUMERO_FK_PK))
            strSSQL &= " and SYCDF_CDF_CODE_FK <> " & cn.SQLText(GV.GetRowCellValue(GV.FocusedRowHandle, Me.colSYCDF_CDF_CODE_FK))

            Dim dt As DataTable = cn.MySelect(strSSQL)

            If dt.Rows.Count > 0 Then
                e.Valid = False
                e.ErrorText = StrValeurExist
            End If
            '---------------------------------
            '---------------------------------
            strSSQL = "  Select * from THERIAQUE.CDF_CODIF where "
            strSSQL &= " UPPER(CDF_NOM) = " & UCase(cn.SQLText(e.Value)) & " and CDF_NUMERO_PK = " & cn.SQLText(_Code_CDF)
            Dim dt2 As DataTable = cn.MySelect(strSSQL)
            If dt2.Rows.Count > 0 Then
                e.Valid = False
                e.ErrorText = StrValeurExist
            End If
            If UCase(e.Value) = UCase(txtLibelle.Text) Then
                e.Valid = False
                e.ErrorText = StrValeurExist
            End If
        End If
    End Sub

#End Region

    Private Sub txtCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Validated
        If ModeFiche = eMode.Ajout Then
            SetCDF_Codif(_Code_CDF, Me.txtCode, Me.DxErrorProvider, txtCodePere)
        End If
    End Sub

    Protected Friend Overrides Function ValideControl(Optional ByRef Ctrl As Control = Nothing, Optional ByVal AllCtrl As Boolean = True) As Boolean
        Dim strSSQL As String = ""
        MyBase.ValideControl(Ctrl)
        If Ctrl.Name.ToLower = "txtLibelle".ToLower Or AllCtrl Then
            If ModeFiche = eMode.Ajout Or ModeFiche = eMode.Modification Then
                strSSQL = "  Select * from THERIAQUE.CDF_CODIF where CDF_CODE_PK <> " & cn.SQLText(txtCode.Text)
                strSSQL &= " and UPPER(CDF_NOM) = " & cn.SQLText(UCase(txtLibelle.Text)) & " and CDF_NUMERO_PK = " & cn.SQLText(_Code_CDF)
                Dim dt As DataTable = cn.MySelect(strSSQL)
                If dt.Rows.Count > 0 Then
                    Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist)
                    Return False
                Else
                    Me.DxErrorProvider.SetError(txtLibelle, "")
                End If
            End If
            ''----------------------------------------------
            '' Test sur les synonymes
            ''----------------------------------------------
            ''----------------------------------------------
            strSSQL = " Select * from THERIAQUE.SYCDF_SYNCODIF where UPPER(SYCDF_NOM_PK) = " & cn.SQLText(UCase(txtLibelle.Text))
            strSSQL &= " and SYCDF_CDF_NUMERO_FK_PK = " & cn.SQLText(_Code_CDF)
            Dim dt1 As DataTable = cn.MySelect(strSSQL)
            If dt1.Rows.Count > 0 Then
                Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist)
                Return False
            End If
            For inti As Integer = 0 To Me.GV.RowCount - 1
                If GV.GetRowCellValue(inti, colSYCDF_NOM_PK) = txtLibelle.Text Then
                    Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist)
                    Return False
                End If
            Next
        End If
        Return True
    End Function

    Private Sub txtCodePere_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodePere.EditValueChanged
        If Me.txtCodePere.EditValue IsNot DBNull.Value Then
            lkupCDF_CODE_PK.EditValue = Me.txtCodePere.EditValue
        Else
            lkupCDF_CODE_PK.EditValue = DBNull.Value
        End If
    End Sub

#Region " GV2       "
    Private Sub GV2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        GV2.SetRowCellValue(e.RowHandle, colCIMCDF_CDF_CODE_FK_PK, Me.txtCode.Text)
        GV2.SetRowCellValue(e.RowHandle, colCIMCDF_CDF_NUMERO_FK_PK, _Code_CDF)
        ModeFiche = eMode.Modification
        UpdateStateBouton()
    End Sub

#End Region

    Private Sub txtLibelle_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLibelle.Validated
        ValideControl(sender, False)
    End Sub

    Private Sub GV3_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV3.InitNewRow
        If _Code_CDF = "NN" Then
            GV3.SetRowCellValue(e.RowHandle, colCDFNP_NUMERO_FK_PK, "NP")
            'GV3.SetRowCellValue(e.RowHandle, colCDFNP_CDF_CODE_FK_PK, _Code_CDF)
            GV3.SetRowCellValue(e.RowHandle, colCDFNP_REF_CODE_FK_PK, txtCode.Text)
            ModeFiche = eMode.Modification
            UpdateStateBouton()
        End If
    End Sub

    Private Sub ComboBoxEdit1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEdit1.SelectedIndexChanged

    End Sub

    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCode.TextChanged
        If (ModeFiche <> eMode.Ajout) Then
            ModeFiche = eMode.Modification
            UpdateStateBouton()
        End If
    End Sub

    Private Sub txtLibelle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLibelle.TextChanged
        If (ModeFiche <> eMode.Ajout) Then
            ModeFiche = eMode.Modification
            UpdateStateBouton()
        End If
    End Sub
End Class
