Public Class Frm_CDF_PP

    ''' <summary>
    ''' Code du type de la codification
    ''' </summary>
    ''' <remarks></remarks>
    Public _Code_CDF As String

#Region " Edit Data "

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_CDF_CODIF(_Code_CDF)
        f.Text = Me.Text
        f.ShowDialog()
        If f._Code IsNot Nothing Then
            lkupUnite_UCUM.Enabled = True
            'ClsSP.initValNum(_Code_CDF, f._Code)
            Me.CdF_CODIFTA.FillByCode(Me.DsTheriaque_Nomenclature21.CDF_CODIF, _Code_CDF, f._Code)
            Me.SycdF_SYNCODIFTableAdapter.FillByCode(Me.DsTheriaque1.SYCDF_SYNCODIF, _Code_CDF, f._Code)
            Me.CdfiuP_INFO_UNITE_PRISETableAdapter.FillByCode(Me.DsTheriaque1.CDFIUP_INFO_UNITE_PRISE, f._Code, _Code_CDF)
            'AddCDFIUP_INFO_UNITE_PRISE()
            If Me.DsTheriaque1.CDFIUP_INFO_UNITE_PRISE.Rows.Count = 0 Then
                Me.BindingContext(Me.DsTheriaque1, CDFIUP_INFO_UNITE_PRISE).AddNew()
            End If
            txtCode.Tag = "[NOEDIT]"
            Me.CdfcdfU_CDFUTableAdapter1.FillByCode(Me.DsTheriaque_Nomenclature21.CDFCDFU_CDFU, Me.txtNCodif.Text, f._Code)

            Return True
        Else
            Return False
        End If

        
    End Function

    Public Overrides Sub Ajouter()

        Me.DsTheriaque1.SYCDF_SYNCODIF.Clear()
        Me.DsTheriaque_Nomenclature21.CDF_CODIF.Clear()
        Me.DsTheriaque1.CIMCDF_CIM10_CODIF.Clear()
        Me.DsTheriaque1.CDFIUP_INFO_UNITE_PRISE.Clear()
        lkupUnite_UCUM.Enabled = True
        Me.BindingContext(Me.DsTheriaque_Nomenclature21, CDF_CODIF).AddNew()
        AddCDFIUP_INFO_UNITE_PRISE()

        SetCDF_Codif(_Code_CDF, Me.txtCode, Me.DxErrorProvider)
        txtCode.Tag = "[EDIT]"
        txtNCodif.Text = _Code_CDF
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
        If Me.BindingContext(Me.DsTheriaque1, CDFIUP_INFO_UNITE_PRISE).Count = 0 Then
            Me.BindingContext(Me.DsTheriaque1, CDFIUP_INFO_UNITE_PRISE).AddNew()
        End If
        Me.BindingContext(Me.DsTheriaque1, CDFIUP_INFO_UNITE_PRISE).Current("CDFIUP_NUMERO_PK") = txtNCodif.Text
        Me.BindingContext(Me.DsTheriaque1, CDFIUP_INFO_UNITE_PRISE).Current("CDFIUP_CODE_PK") = txtCode.Text
        Me.BindingContext(Me.DsTheriaque1, CDFIUP_INFO_UNITE_PRISE).EndCurrentEdit()

        CdfiuP_INFO_UNITE_PRISETableAdapter.Update(Me.DsTheriaque1.CDFIUP_INFO_UNITE_PRISE)

        UpdateUniteUCUM()

    End Sub

    Private Sub UpdateUniteUCUM()

        Dim sSQL As String

        sSQL = "DELETE FROM theriaque.CDFCDFU_CDFU where CDFCDFU_CDF_NUMERO_FK_PK=" & cn.SQLText(txtNCodif.Text)
        sSQL &= " and CDFCDFU_CDF_CODE_FK_PK=" & cn.SQLText(txtCode.Text)
        cn.Execute(sSQL)

        If (Not String.IsNullOrEmpty(lkupUnite_UCUM.EditValue)) And lkupUnite_UCUM.EditValue <> 0 Then
            sSQL = " INSERT INTO [theriaque].[theriaque].[CDFCDFU_CDFU]([CDFCDFU_CDFUCUM_CODE_FK_PK],[CDFCDFU_CDF_NUMERO_FK_PK],[CDFCDFU_CDF_CODE_FK_PK]) "
            sSQL &= " VALUES(" & lkupUnite_UCUM.EditValue & "," & cn.SQLText(txtNCodif.Text) & "," & cn.SQLText(txtCode.Text) & ")"
            cn.Execute(sSQL)
        End If

    End Sub

    Public Overrides Sub Annuler()
        MyBase.Annuler()
        Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature21.CDF_CODIF.RejectChanges()

        Me.BindingContext(Me.DsTheriaque1, SYCDF_SYNCODIF).CancelCurrentEdit()
        Me.DsTheriaque1.SYCDF_SYNCODIF.RejectChanges()

        Me.BindingContext(Me.DsTheriaque1, CDFIUP_INFO_UNITE_PRISE).CancelCurrentEdit()
        Me.DsTheriaque1.CDFIUP_INFO_UNITE_PRISE.RejectChanges()
        txtCode.Tag = "[NOEDIT]"
        AddCDFIUP_INFO_UNITE_PRISE()
        If (String.IsNullOrEmpty(txtCode.Text)) Then
            lkupUnite_UCUM.Enabled = False
        End If
    End Sub

    Public Overrides Function Supprimer() As Boolean
        MyBase.Supprimer()
        Dim inti As Integer

        For inti = 0 To DsTheriaque1.SYCDF_SYNCODIF.Rows.Count - 1
            DsTheriaque1.SYCDF_SYNCODIF.Rows(inti).Delete()
        Next
        Me.SycdF_SYNCODIFTableAdapter.Update(Me.DsTheriaque1)

        For inti = 0 To DsTheriaque1.CDFIUP_INFO_UNITE_PRISE.Rows.Count - 1
            DsTheriaque1.CDFIUP_INFO_UNITE_PRISE.Rows(inti).Delete()
        Next
        Me.CdfiuP_INFO_UNITE_PRISETableAdapter.Update(Me.DsTheriaque1)

        DsTheriaque_Nomenclature21.CDF_CODIF.Rows(0).Delete()
        Me.CdF_CODIFTA.Update(Me.DsTheriaque_Nomenclature21)

        Return True
    End Function

    Private Sub Frm_PharmacoTherapeutiques_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InitVariable()
    End Sub

    Private Sub AddCDFIUP_INFO_UNITE_PRISE()
        If Me.DsTheriaque1.CDFIUP_INFO_UNITE_PRISE.Rows.Count = 0 Then
            If Me.DsTheriaque_Nomenclature21.CDF_CODIF.Rows.Count = 0 Then
                Me.BindingContext(Me.DsTheriaque1, CDFIUP_INFO_UNITE_PRISE).AddNew()
            End If
        Else
            'Aprés recherche
            If txtCDFIUP_COEFDUR_CDF_NUM_FK.Text <> "" Then
                lkupCDFIUP_COEFDUR_CDF_NUM_FK.Properties.GetDataSourceRowIndex("num", txtCDFIUP_COEFDUR_CDF_NUM_FK.Text)
            End If
        End If
    End Sub

    Private Sub InitVariable()
        FirstFocus = txtCode
        MasterDataSet = Me.DsTheriaque1
        MasterTable = CDF_CODIF
        Me.Label1.Text = LibNomenclature(_Code_CDF)
        InitLkupCDF(lkupCDFIUP_DONANTH_CDF_CODE_FK, CDF_CODIF, strSSQL_CDF_CODIF("PA"), True, True, True)
        'InitLkupCDF(lkupCDFIUP_COEFVOL_CDF_CODE_FK, CDF_CODIF, strSSQL_CDF_CODIF("20"), True, True, True)

        Dim strSSQL As String = ""
        strSSQL &= " Select CDF_CODE_PK as code, CAST(CDFTE_COEFFICIENT AS varchar) as libelle, CDF_NUMERO_PK as num, 'Indice' as indice  "
        strSSQL &= " From THERIAQUE.CDF_CODIF, THERIAQUE.CDFTE_TABLE_EQUIVALENCE "
        strSSQL &= " where CDF_NUMERO_PK in ('PU','PF','','','') "
        strSSQL &= " AND CDF_CODE_PK = CDFTE_CODE_PK "
        strSSQL &= " AND CDFTE_COEFFICIENT IS NOT NULL "
        InitLkupCDF(lkupCDFIUP_COEFDUR_CDF_NUM_FK, CDF_CODIF, strSSQL, True, True, True)

        strSSQL = " Select CDF_CODE_PK as code, CDFTE_COEFFICIENT as libelle, CDF_NUMERO_PK as num   "
        strSSQL &= " From THERIAQUE.CDF_CODIF, THERIAQUE.CDFTE_TABLE_EQUIVALENCE "
        strSSQL &= " where CDF_NUMERO_PK in ('20','','','','') "
        strSSQL &= " AND CDF_CODE_PK = CDFTE_CODE_PK "
        strSSQL &= " AND CDFTE_COEFFICIENT IS NOT NULL "
        InitLkupCDF(lkupCDFIUP_COEFVOL_CDF_CODE_FK, CDF_CODIF, strSSQL, True, True, True)
        InitLkup(lkupUnite_UCUM, "CDFUCUM_UCUM", strSSQL_CDFUCUM_SYMBOLE(txtNCodif.Text), True)
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

            strSSQL = "Select * from THERIAQUE.SYCDF_SYNCODIF where UPPER(SYCDF_NOM_PK) = " & UCase(cn.SQLText(e.Value))
            strSSQL &= " and SYCDF_CDF_NUMERO_FK_PK = " & cn.SQLText(GV.GetRowCellValue(GV.FocusedRowHandle, Me.colSYCDF_CDF_NUMERO_FK_PK))
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

#Region " Validation txt + Edit "

    Private Sub txtCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Validated, txtCDFIUP_COEFDUR_CDF_NUM_FK.Validated
        If ModeFiche = eMode.Ajout Then
            SetCDF_Codif(_Code_CDF, Me.txtCode, Me.DxErrorProvider)
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

    Private Sub txtLibelle_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLibelle.Validated
        ValideControl(sender, False)
    End Sub

    Private Sub lkupCDFIUP_COEFDUR_CDF_NUM_FK_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupCDFIUP_COEFDUR_CDF_NUM_FK.EditValueChanged
        Dim strNum As String
        strNum = lkupCDFIUP_COEFDUR_CDF_NUM_FK.Properties.GetDataSourceValue("num", lkupCDFIUP_COEFDUR_CDF_NUM_FK.ItemIndex)
        txtCDFIUP_COEFDUR_CDF_NUM_FK.Text = strNum
    End Sub

#End Region

    Private Sub txtLibelle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLibelle.TextChanged
        ModeFiche = eMode.Modification
        UpdateStateBouton()
    End Sub

    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCode.TextChanged
        ModeFiche = eMode.Modification
        UpdateStateBouton()
    End Sub

    Private Sub lkupUnite_UCUM_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupUnite_UCUM.EditValueChanged
        btValider.Enabled = True
        btAnnuler.Enabled = True
        btAjouter.Enabled = False
        btSupprimer.Enabled = False
        btFermer.Enabled = False
        btChercher.Enabled = False
    End Sub
End Class
