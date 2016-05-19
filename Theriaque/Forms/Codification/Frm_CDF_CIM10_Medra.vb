Public Class Frm_CDF_CIM10_Medra

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
            Me.MedcdF_MEDRA_CODIFTableAdapter.FillByCode(Me.DsTheriaque1.MEDCDF_MEDRA_CODIF, _Code_CDF, f._Code)
            Dim res As StructResultCode = Code_PereFils(txtCode, "CDF_CODIF", DxErrorProvider, False, " CDF_NUMERO_PK = " & cn.SQLText(_Code_CDF))
            If res._Validation = True Then txtCodePere.Text = res._Code
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Sub Ajouter()
        Me.DsTheriaque1.SYCDF_SYNCODIF.Clear()
        Me.DsTheriaque_Nomenclature21.CDF_CODIF.Clear()
        Me.DsTheriaque1.CIMCDF_CIM10_CODIF.Clear()
        Me.DsTheriaque1.MEDCDF_MEDRA_CODIF.Clear()
        Me.BindingContext(Me.DsTheriaque_Nomenclature21, CDF_CODIF).AddNew()
        If _Code_CDF <> "EN" Then
            SetCDF_Codif(_Code_CDF, Me.txtCode, Me.DxErrorProvider, txtCodePere)
        End If
        txtNCodif.Text = _Code_CDF
        txtCodePere.EditValue = DBNull.Value
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

        Me.BindingContext(Me.DsTheriaque1, MEDCDF_MEDRA_CODIF).EndCurrentEdit()
        MedcdF_MEDRA_CODIFTableAdapter.Update(Me.DsTheriaque1.MEDCDF_MEDRA_CODIF)

        InitLkup(lkupCDF_CODE_PK, CDF_CODIF, strSSQL_CDF_CODIF(_Code_CDF), True, False)
    End Sub

    Public Overrides Sub Annuler()
        MyBase.Annuler()
        Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature21.CDF_CODIF.RejectChanges()

        Me.BindingContext(Me.DsTheriaque1, SYCDF_SYNCODIF).CancelCurrentEdit()
        Me.DsTheriaque1.SYCDF_SYNCODIF.RejectChanges()

        Me.BindingContext(Me.DsTheriaque1, CIMCDF_CIM10_CODIF).CancelCurrentEdit()
        Me.DsTheriaque1.CIMCDF_CIM10_CODIF.RejectChanges()

        Me.BindingContext(Me.DsTheriaque1, MEDCDF_MEDRA_CODIF).CancelCurrentEdit()
        Me.DsTheriaque1.MEDCDF_MEDRA_CODIF.RejectChanges()
    End Sub

    Public Overrides Function Supprimer() As Boolean
        MyBase.Supprimer()
        Dim inti As Integer

        For inti = 0 To DsTheriaque1.SYCDF_SYNCODIF.Rows.Count - 1
            DsTheriaque1.SYCDF_SYNCODIF.Rows(inti).Delete()
        Next

        For inti = 0 To DsTheriaque1.CIMCDF_CIM10_CODIF.Rows.Count - 1
            DsTheriaque1.CIMCDF_CIM10_CODIF.Rows(inti).Delete()
        Next

        For inti = 0 To DsTheriaque1.MEDCDF_MEDRA_CODIF.Rows.Count - 1
            DsTheriaque1.MEDCDF_MEDRA_CODIF.Rows(inti).Delete()
        Next

        DsTheriaque_Nomenclature21.CDF_CODIF.Rows(0).Delete()

        Me.SycdF_SYNCODIFTableAdapter.Update(Me.DsTheriaque1)
        Me.CimcdF_CIM10_CODIFTableAdapter.Update(Me.DsTheriaque1)
        Me.CdF_CODIFTA.Update(Me.DsTheriaque_Nomenclature21)

        txtCodePere.EditValue = DBNull.Value
        Return True
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
        InitLkup(rpMedra, MEDRA, strSSQL_Medra, True, True, True)
        InitLkup(lkupCDF_CODE_PK, CDF_CODIF, strSSQL_CDF_CODIF(_Code_CDF), True, False)
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

    Private Sub txtCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Validated
        '[BFE] - 06/07/07
        ' ajout de la condition Me.txtCode.Properties.ReadOnly = False Then
        ' Tick 3251
        If Me.txtCode.Properties.ReadOnly = False Then
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

    Private Sub GV3_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV3.InitNewRow
        GV3.SetRowCellValue(e.RowHandle, colMEDCDF_CDF_CODE_FK_PK, Me.txtCode.Text)
        GV3.SetRowCellValue(e.RowHandle, colMEDCDF_CDF_NUMERO_FK_PK, _Code_CDF)
        ModeFiche = eMode.Modification
        UpdateStateBouton()
    End Sub

#End Region


    Private Sub txtLibelle_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLibelle.Validated
        ValideControl(sender, False)
    End Sub

End Class
