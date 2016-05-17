Public Class Frm_CDF_CIM10_CISP

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
            'ClsSP.initValNum(_Code_CDF, f._Code)
            Me.CdF_CODIFTA.FillByCode(Me.DsTheriaque_Nomenclature21.CDF_CODIF, _Code_CDF, f._Code)
            Me.SycdF_SYNCODIFTableAdapter.FillByCode(Me.DsTheriaque1.SYCDF_SYNCODIF, _Code_CDF, f._Code)
            Me.CimcdF_CIM10_CODIFTableAdapter.FillByCode(Me.DsTheriaque1.CIMCDF_CIM10_CODIF, _Code_CDF, f._Code)
            Me.CispcdF_CISP_CODIFTableAdapter.FillByCode(Me.DsTheriaque1.CISPCDF_CISP_CODIF, _Code_CDF, f._Code)

            If _Code_CDF = "CS" Then
                Dim res As StructResultCode = Code_PereFils(txtCode, "CDF_CODIF", DxErrorProvider, False, " CDF_NUMERO_PK = " & cn.SQLText(_Code_CDF))
                If res._Validation = True Then txtCodePere.Text = res._Code

                Dim strSSQL As String = ""
                strSSQL = "SELECT CDF_NUMERO_PK, CDF_CODE_PK, CDF_NOM, CDF_DATECR, CDF_DATEMJ FROM THERIAQUE.CDF_CODIF"
                strSSQL &= " where CDF_NUMERO_PK = " & cn.SQLText(_Code_CDF) & " and CDF_CODE_PK like " & cn.SQLText(f._Code & "_")
                GC3.DataSource = cn.MySelect(strSSQL)
            Else
                PanPere.Visible = False
                GBFils.Visible = False
            End If

            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Sub Ajouter()
        Me.DsTheriaque1.SYCDF_SYNCODIF.Clear()
        Me.DsTheriaque_Nomenclature21.CDF_CODIF.Clear()
        Me.DsTheriaque1.CIMCDF_CIM10_CODIF.Clear()
        Me.GC3.DataSource = Nothing
        Me.DsTheriaque1.CISPCDF_CISP_CODIF.Clear()
        Me.BindingContext(Me.DsTheriaque_Nomenclature21, CDF_CODIF).AddNew()
        If _Code_CDF = "CS" Then
            SetCDF_Codif(_Code_CDF, Me.txtCode, Me.DxErrorProvider, txtCodePere)
            txtCodePere.EditValue = DBNull.Value
        Else
            SetCDF_Codif(_Code_CDF, Me.txtCode, Me.DxErrorProvider)
        End If
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

        Me.BindingContext(Me.DsTheriaque1, "SYCDF_SYNCODIF").EndCurrentEdit()
        SycdF_SYNCODIFTableAdapter.Update(Me.DsTheriaque1.SYCDF_SYNCODIF)

        Me.BindingContext(Me.DsTheriaque1, "CIMCDF_CIM10_CODIF").EndCurrentEdit()
        CimcdF_CIM10_CODIFTableAdapter.Update(Me.DsTheriaque1.CIMCDF_CIM10_CODIF)

        Me.BindingContext(Me.DsTheriaque1, "CispcdF_CISP_CODIF").EndCurrentEdit()
        CispcdF_CISP_CODIFTableAdapter.Update(Me.DsTheriaque1.CISPCDF_CISP_CODIF)

        InitLkup(lkupCDF_CODE_PK, CDF_CODIF, strSSQL_CDF_CODIF(_Code_CDF), False, False, True)

    End Sub

    Public Overrides Sub Annuler()
        MyBase.Annuler()
        Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature21.CDF_CODIF.RejectChanges()

        Me.BindingContext(Me.DsTheriaque1, SYCDF_SYNCODIF).CancelCurrentEdit()
        Me.DsTheriaque1.SYCDF_SYNCODIF.RejectChanges()

        Me.BindingContext(Me.DsTheriaque1, CIMCDF_CIM10_CODIF).CancelCurrentEdit()
        Me.DsTheriaque1.CIMCDF_CIM10_CODIF.RejectChanges()

        Me.BindingContext(Me.DsTheriaque1, CISPCDF_CISP_CODIF).CancelCurrentEdit()
        Me.DsTheriaque1.CISPCDF_CISP_CODIF.RejectChanges()
    End Sub

    Public Overrides Function Supprimer() As Boolean
        MyBase.Supprimer()
        If TestUsedCodif(_Code_CDF, Me.txtCode.Text) Then
            Process_Message(strIMP_SUPPRIMER, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        ElseIf CODIFUsedInTerrainPere(Me.txtCode.Text) Then
            Process_Message(strIMP_SUPPRIMER_TP, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Dim inti As Integer

            For inti = 0 To DsTheriaque1.SYCDF_SYNCODIF.Rows.Count - 1
                DsTheriaque1.SYCDF_SYNCODIF.Rows(inti).Delete()
            Next

            For inti = 0 To DsTheriaque1.CIMCDF_CIM10_CODIF.Rows.Count - 1
                DsTheriaque1.CIMCDF_CIM10_CODIF.Rows(inti).Delete()
            Next

            For inti = 0 To DsTheriaque1.CISPCDF_CISP_CODIF.Rows.Count - 1
                DsTheriaque1.CISPCDF_CISP_CODIF.Rows(inti).Delete()
            Next

            GC3.DataSource = Nothing

            Me.SycdF_SYNCODIFTableAdapter.Update(Me.DsTheriaque1)
            Me.CimcdF_CIM10_CODIFTableAdapter.Update(Me.DsTheriaque1)
            Me.CispcdF_CISP_CODIFTableAdapter.Update(Me.DsTheriaque1)

            DsTheriaque_Nomenclature21.CDF_CODIF.Rows(0).Delete()
            Me.CdF_CODIFTA.Update(Me.DsTheriaque_Nomenclature21)

            If _Code_CDF = "CS" Then
                txtCodePere.EditValue = DBNull.Value
            End If
            Me.DsTheriaque_Nomenclature21.CDF_CODIF.Clear()
            Return True
        End If
    End Function

    Private Sub Frm_PharmacoTherapeutiques_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InitVariable()
    End Sub

    Private Sub InitVariable()
        FirstFocus = txtCode
        MasterDataSet = Me.DsTheriaque_Nomenclature21
        MasterTable = CDF_CODIF
        Me.Label1.Text = LibNomenclature(_Code_CDF)
        InitLkup(rpCIM10, CIM10, strSSQL_CIM10, True, True, True)
        InitLkup(rpCISP, CIM10, strSSQL_CISP_CLASSIF_INTER_SOINS, True, True, True)
        InitLkup(lkupCDF_CODE_PK, CDF_CODIF, strSSQL_CDF_CODIF(_Code_CDF), False, False, True)
        If _Code_CDF = "CS" Then
            Me.PanPere.Visible = True
        Else
            Me.PanPere.Visible = False
            GBFils.Dock = DockStyle.None
            GBFils.Visible = False
            GBSyn.Text = ""
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
        If _Code_CDF = "CS" Then
            If Me.txtCodePere.EditValue IsNot DBNull.Value Then
                lkupCDF_CODE_PK.EditValue = Me.txtCodePere.EditValue
            Else
                lkupCDF_CODE_PK.EditValue = DBNull.Value
            End If
        End If
    End Sub

#Region " GV2       "

    Private Sub GV2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        GV2.SetRowCellValue(e.RowHandle, colCIMCDF_CDF_CODE_FK_PK, Me.txtCode.Text)
        GV2.SetRowCellValue(e.RowHandle, colCIMCDF_CDF_NUMERO_FK_PK, _Code_CDF)
        ModeFiche = eMode.Modification
        UpdateStateBouton()
    End Sub


    'Private Sub GV2_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV2.ValidatingEditor
    'If e.Value IsNot Nothing Then
    '    Dim strSSQL As String = ""

    '    strSSQL = "Select * from THERIAQUE.SYCDF_SYNCODIF where SYCDF_NOM_PK = " & cn.SQLText(e.Value)
    '    strSSQL &= " and SYCDF_CDF_NUMERO_FK_PK <> " & cn.SQLText(GV.GetRowCellValue(GV.FocusedRowHandle, Me.colSYCDF_CDF_NUMERO_FK_PK))
    '    strSSQL &= " and SYCDF_CDF_CODE_FK <> " & cn.SQLText(GV.GetRowCellValue(GV.FocusedRowHandle, Me.colSYCDF_CDF_CODE_FK))

    '    Dim dt As DataTable = cn.MySelect(strSSQL)

    '    If dt.Rows.Count > 0 Then
    '        e.Valid = False
    '        e.ErrorText = StrValeurExist
    '    End If
    'End If
    'End Sub

#End Region

    Private Sub txtLibelle_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLibelle.Validated
        ValideControl(sender, False)
    End Sub

    Private Sub GV4_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV4.InitNewRow
        GV4.SetRowCellValue(e.RowHandle, colCISPCDF_CDF_CODE_FK_PK, Me.txtCode.Text)
        GV4.SetRowCellValue(e.RowHandle, colCISPCDF_CDF_NUMERO_FK_PK, _Code_CDF)
        ModeFiche = eMode.Modification
        UpdateStateBouton()
    End Sub

    Private Sub txtNCodif_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNCodif.EditValueChanged

    End Sub

    Private Sub txtLibelle_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLibelle.EditValueChanged

    End Sub

    Private Sub DateEdit2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateEdit2.EditValueChanged

    End Sub

    Private Sub DateEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateEdit1.EditValueChanged

    End Sub
End Class
