Public Class Frm_CDF_TEQ1
    ''' <summary>
    ''' Code du type de la codification
    ''' </summary>
    ''' <remarks></remarks>
    ''' 

    Public _Code_CDF As String

    Shared _mode As String = ""

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_CDF_CODIF(_Code_CDF)
        f.Text = Me.Text
        Me.DsTheriaque1.CDFTE_TABLE_EQUIVALENCE.Clear()
        f.ShowDialog()
        If f._Code IsNot Nothing Then
            lkupUnite_UCUM.Enabled = True
            'ClsSP.initValNum(_Code_CDF, f._Code)

            Me.CdF_CODIFTA.FillByCode(Me.DsTheriaque_Nomenclature21.CDF_CODIF, _Code_CDF, f._Code)
            Me.SycdF_SYNCODIFTableAdapter.FillByCode(Me.DsTheriaque1.SYCDF_SYNCODIF, _Code_CDF, f._Code)
            Me.CdftE_TABLE_EQUIVALENCETableAdapter.FillByCode(Me.DsTheriaque1.CDFTE_TABLE_EQUIVALENCE, _Code_CDF, f._Code)
            'Add_CDFTE_TABLE_EQUIVALENCE()
            txtCode.Tag = "[NOEDIT][ADD]"

            Me.CdfcdfU_CDFUTableAdapter1.FillByCode(Me.DsTheriaque_Nomenclature21.CDFCDFU_CDFU, Me.txtNCodif.Text, f._Code)

            Return True

        Else
            Return False
        End If
    End Function

    Public Overrides Sub Ajouter()

        lkupUnite_UCUM.Enabled = True
        Me.DsTheriaque1.SYCDF_SYNCODIF.Clear()
        Me.DsTheriaque1.CDFTE_TABLE_EQUIVALENCE.Clear()
        Me.DsTheriaque_Nomenclature21.CDF_CODIF.Clear()
        Me.BindingContext(Me.DsTheriaque_Nomenclature21, CDF_CODIF).AddNew()
        Me.BindingContext(Me.DsTheriaque_Nomenclature21, CDF_CODIF).Current("CDF_DATECR") = Now.Date
        SetCDF_Codif(_Code_CDF, Me.txtCode, Me.DxErrorProvider)


        'Me.BindingContext(Me.DsTheriaque1, CDFTE_TABLE_EQUIVALENCE).AddNew()


        txtNCodif.Text = _Code_CDF
        'Add_CDFTE_TABLE_EQUIVALENCE()
        Me.cmbCDFTE_APPLICABLE.Text = ""
        'Me.calcCDFTE_COEFFICIENT.Text = ""
        Me.CalcEdit_COEFFICIENT.Text = ""
        MyBase.Ajouter()
    End Sub

    Private Sub Add_CDFTE_TABLE_EQUIVALENCE()

        'Me.DsTheriaque1.CDFTE_TABLE_EQUIVALENCE.Rows.Clear()
        If Me.DsTheriaque1.CDFTE_TABLE_EQUIVALENCE.Rows.Count = 0 Then

            'If (Not _mode.Equals("A")) Then
            'Me.BindingContext(Me.DsTheriaque1, CDFTE_TABLE_EQUIVALENCE).AddNew()
            'End If

            If Me.BindingContext(Me.DsTheriaque1, CDFTE_TABLE_EQUIVALENCE).Count = 0 Then
                Me.BindingContext(Me.DsTheriaque1, CDFTE_TABLE_EQUIVALENCE).AddNew()
            End If

            Me.BindingContext(Me.DsTheriaque1, CDFTE_TABLE_EQUIVALENCE).Current("CDFTE_NUMERO_PK") = Me.txtNCodif.Text
            Me.BindingContext(Me.DsTheriaque1, CDFTE_TABLE_EQUIVALENCE).Current("CDFTE_CODE_PK") = Me.txtCode.Text

            'Me.BindingContext(Me.DsTheriaque1, CDFTE_TABLE_EQUIVALENCE).Current("CDFTE_APPLICABLE") = Me.cmbCDFTE_APPLICABLE.Text
            'Me.BindingContext(Me.DsTheriaque1, CDFTE_TABLE_EQUIVALENCE).Current("CDFTE_COEFFICIENT") = Decimal.Parse(CalcEdit_COEFFICIENT.Text)

            'Me.BindingContext(Me.DsTheriaque1, CDFTE_TABLE_EQUIVALENCE).EndCurrentEdit()
            'CdftE_TABLE_EQUIVALENCETableAdapter.Update(Me.DsTheriaque1.CDFTE_TABLE_EQUIVALENCE)
            ''Me.CdftE_TABLE_EQUIVALENCETableAdapter.FillByCode(Me.DsTheriaque1.CDFTE_TABLE_EQUIVALENCE, _Code_CDF, Me.txtCode.Text)

        End If

    End Sub

    Private Sub UpdateCDFTE()

        Dim queryExist As String = " select null from theriaque.CDFTE_TABLE_EQUIVALENCE where CDFTE_NUMERO_PK = '" & Me.txtNCodif.Text & "' and CDFTE_CODE_PK = '" & Me.txtCode.Text & "'"
        Dim query As String = ""

        Dim applicable As String = "null"
        If (Not String.IsNullOrEmpty(cmbCDFTE_APPLICABLE.Text)) Then
            applicable = cmbCDFTE_APPLICABLE.Text
        End If

        If (Not HasRows(queryExist)) Then

            query = " INSERT INTO theriaque.CDFTE_TABLE_EQUIVALENCE "
            query &= "([CDFTE_NUMERO_PK],[CDFTE_CODE_PK],[CDFTE_APPLICABLE],[CDFTE_COEFFICIENT]) VALUES "
            If (Not applicable.Equals("null")) Then
                query &= " ('" & Me.txtNCodif.Text & "','" & Me.txtCode.Text & "','" & applicable & "'," & CalcEdit_COEFFICIENT.Text.Replace(",", ".") & ")"
            Else
                query &= " ('" & Me.txtNCodif.Text & "','" & Me.txtCode.Text & "',null," & CalcEdit_COEFFICIENT.Text.Replace(",", ".") & ")"
            End If

        Else

            query = " Update theriaque.CDFTE_TABLE_EQUIVALENCE SET "
            If (Not applicable.Equals("null")) Then
                query &= " CDFTE_APPLICABLE = '" & applicable & "',"
            Else
                query &= " CDFTE_APPLICABLE = null,"
            End If

            If (Not String.IsNullOrEmpty(CalcEdit_COEFFICIENT.Text)) Then
                query &= " CDFTE_COEFFICIENT = " & CalcEdit_COEFFICIENT.Text.Replace(",", ".")
            Else
                query = query.Replace(",", "")
            End If

            query &= " Where CDFTE_NUMERO_PK ='" & Me.txtNCodif.Text & "' and CDFTE_CODE_PK ='" & Me.txtCode.Text & "'"

        End If

        cn.Execute(query)

    End Sub

    Private Function HasRows(ByVal sSQL As String) As Boolean

        Dim dt As DataTable = cn.MySelect(sSQL)
        Return (dt.Rows.Count > 0)

    End Function


    Public Overrides Sub Valider()

        MyBase.Valider()
        Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).Current("CDF_DATEMJ") = Now.Date
        Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).Current("CDF_NOMABRG") = ""

        If (String.IsNullOrEmpty(Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).Current("CDF_UNIT_NUM").ToString())) Then
            Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).Current("CDF_UNIT_NUM") = ""
        End If

        If (String.IsNullOrEmpty(Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).Current("CDF_TEXTE").ToString())) Then
            Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).Current("CDF_TEXTE") = ""
        End If

        Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).EndCurrentEdit()
        Me.CdF_CODIFTA.Update(Me.DsTheriaque_Nomenclature21.CDF_CODIF)

        Me.BindingContext(Me.DsTheriaque1, "SYCDF_SYNCODIF").EndCurrentEdit()
        SycdF_SYNCODIFTableAdapter.Update(Me.DsTheriaque1.SYCDF_SYNCODIF)

        'Add_CDFTE_TABLE_EQUIVALENCE()
        UpdateCDFTE()

        UpdateUniteUCUM()

        'Me.BindingContext(Me.DsTheriaque1, "CDFTE_TABLE_EQUIVALENCE").EndCurrentEdit()
        'CdftE_TABLE_EQUIVALENCETableAdapter.Update(Me.DsTheriaque1.CDFTE_TABLE_EQUIVALENCE)

    End Sub


    Private Sub UpdateUniteUCUM()

        Dim sSQL As String

        sSQL = "DELETE FROM theriaque.CDFCDFU_CDFU where CDFCDFU_CDF_NUMERO_FK_PK=" & cn.SQLText(txtNCodif.Text)
        sSQL &= " and CDFCDFU_CDF_CODE_FK_PK=" & cn.SQLText(txtCode.Text)
        cn.Execute(sSQL)

        If lkupUnite_UCUM.EditValue IsNot System.DBNull.Value Then

            If (Not String.IsNullOrEmpty(lkupUnite_UCUM.EditValue)) And lkupUnite_UCUM.EditValue <> 0 Then
                sSQL = " INSERT INTO [theriaque].[theriaque].[CDFCDFU_CDFU]([CDFCDFU_CDFUCUM_CODE_FK_PK],[CDFCDFU_CDF_NUMERO_FK_PK],[CDFCDFU_CDF_CODE_FK_PK]) "
                sSQL &= " VALUES(" & lkupUnite_UCUM.EditValue & "," & cn.SQLText(txtNCodif.Text) & "," & cn.SQLText(txtCode.Text) & ")"
                cn.Execute(sSQL)
            End If

        End If

    End Sub

    Public Overrides Sub Annuler()
        MyBase.Annuler()
        Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature21.CDF_CODIF.RejectChanges()

        Me.BindingContext(Me.DsTheriaque1, SYCDF_SYNCODIF).CancelCurrentEdit()
        Me.DsTheriaque1.SYCDF_SYNCODIF.RejectChanges()

        Me.BindingContext(Me.DsTheriaque1, CDFTE_TABLE_EQUIVALENCE).CancelCurrentEdit()
        Me.DsTheriaque1.CDFTE_TABLE_EQUIVALENCE.RejectChanges()

        If (String.IsNullOrEmpty(txtCode.Text)) Then
            lkupUnite_UCUM.Enabled = False
        End If
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
            Me.SycdF_SYNCODIFTableAdapter.Update(Me.DsTheriaque1)

            If DsTheriaque1.CDFTE_TABLE_EQUIVALENCE.Rows.Count > 0 Then
                DsTheriaque1.CDFTE_TABLE_EQUIVALENCE.Rows(0).Delete()
                Me.CdftE_TABLE_EQUIVALENCETableAdapter.Update(Me.DsTheriaque1)
            End If

            DsTheriaque_Nomenclature21.CDF_CODIF.Rows(0).Delete()
            Me.CdF_CODIFTA.Update(Me.DsTheriaque_Nomenclature21)

            Return True
        End If
    End Function

    Private Sub Frm_PharmacoTherapeutiques_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InitVariable()
    End Sub

    Private Sub InitVariable()
        FirstFocus = txtLibelle
        MasterDataSet = Me.DsTheriaque_Nomenclature21
        MasterTable = CDF_CODIF
        Me.Label1.Text = LibNomenclature(_Code_CDF)
        InitLkup(lkupUnite_UCUM, "CDFUCUM_UCUM", strSSQL_CDFUCUM_SYMBOLE(txtNCodif.Text), True)
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.SetRowCellValue(e.RowHandle, colSYCDF_CDF_CODE_FK, Me.txtCode.Text)
        GV.SetRowCellValue(e.RowHandle, colSYCDF_CDF_NUMERO_FK_PK, _Code_CDF)
        ModeFiche = eMode.Modification
        UpdateStateBouton()
    End Sub

    Private Sub txtCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Validated
        If _Code_CDF = "PF" Or _Code_CDF = "PU" Then
            If txtCode.Properties.ReadOnly = False Then
                SetCDF_Codif(_Code_CDF, Me.txtCode, Me.DxErrorProvider)
            End If
            'Me.BindingContext(Me.DsTheriaque1, MasterTable).Current("CDFTE_CODE_PK") = Me.txtCode.Text
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

    Private Sub GV_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV.ValidatingEditor
        If e.Value IsNot Nothing Then
            Dim strSSQL As String = ""

            strSSQL = "Select * from THERIAQUE.SYCDF_SYNCODIF where UPPER(SYCDF_NOM_PK) = " & UCase(cn.SQLText(e.Value))
            strSSQL &= " and SYCDF_CDF_NUMERO_FK_PK = " & cn.SQLText(GV.GetRowCellValue(GV.FocusedRowHandle, Me.colSYCDF_CDF_NUMERO_FK_PK))
            strSSQL &= " and SYCDF_CDF_CODE_FK <> " & cn.SQLText(GV.GetRowCellValue(GV.FocusedRowHandle, Me.colSYCDF_CDF_CODE_FK))

            Dim dt As DataTable = cn.MySelect(strSSQL)

            If dt.Rows.Count > 0 Or Trim(e.Value) = Trim(Me.txtLibelle.Text) Then
                e.Valid = False
                e.ErrorText = StrValeurExist
            End If

            If FieldExistCS(GV, colSYCDF_NOM_PK, e.Value) Then
                e.ErrorText = StrValeurExist
                e.Valid = False
            End If

            strSSQL = "  SELECT * FROM THERIAQUE.CDF_CODIF "
            strSSQL &= " WHERE UPPER(CDF_NOM) = " & UCase(cn.SQLText(e.Value)) & " and CDF_NUMERO_PK = " & cn.SQLText(_Code_CDF)
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

    Private Sub btAjouter_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAjouter.Click
        If _Code_CDF = "PF" Or _Code_CDF = "PU" Then
            txtCode.Select()
        End If
    End Sub

    Private Sub cmbCDFTE_APPLICABLE_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCDFTE_APPLICABLE.EditValueChanged
        ModeFiche = eMode.Modification
        UpdateStateBouton()
    End Sub

    Private Sub CalcEdit_COEFFICIENT_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcEdit_COEFFICIENT.EditValueChanged
        ModeFiche = eMode.Modification
        UpdateStateBouton()
    End Sub

    Private Sub GV_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
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
