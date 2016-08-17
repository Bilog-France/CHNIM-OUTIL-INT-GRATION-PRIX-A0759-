Public Class Frm_CDF_IVO

    ''' <summary>
    ''' </summary>
    ''' <remarks></remarks>
    Public _Code_CDF As String
    Public _Code_Acces As String
    Private Shared codeIDVO As String

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()

        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_CDF_CODIF(_Code_CDF)
        f.Text = Me.Text
        f.ShowDialog()
        If f._Code IsNot Nothing Then
            lkupCatégorie.Enabled = True
            Me.CdF_CODIFTA.FillByCode(Me.DsTheriaque_Nomenclature21.CDF_CODIF, _Code_CDF, f._Code)
            Me.SycdF_SYNCODIFTableAdapter.FillByCode(Me.DsTheriaque1.SYCDF_SYNCODIF, _Code_CDF, f._Code)
            Me.CdfnP_CODIFTableAdapter.FillByCode(Me.DsTheriaque1.CDFNP_CODIF, _Code_CDF, f._Code)
            Me.IdvO_IDENT_VOIETableAdapter.FillByCode(Me.DsTheriaque1.IDVO_IDENT_VOIE, _Code_CDF, f._Code)
            If (Me.DsTheriaque1.IDVO_IDENT_VOIE.Rows.Count <> 0) Then
                txtIdentification.Text = Me.DsTheriaque1.IDVO_IDENT_VOIE.Rows(0).Item("IDVO_CODE_VOIE")
            Else
                txtIdentification.Text = ""
            End If

            txtValCoefficient.Enabled = True
            txtValCoefficient.BackColor = Color.White
            txtValCoefficient.TabStop = False
            txtValCoefficient.Properties.ReadOnly = False

            txtLibelle.Enabled = True
            txtLibelle.BackColor = Color.White
            txtLibelle.TabStop = False
            txtLibelle.Properties.ReadOnly = False

            'txtIDVO_CODE_VOIE.Enabled = True
            'txtIDVO_CODE_VOIE.BackColor = Color.White
            'txtIDVO_CODE_VOIE.TabStop = False
            'txtIDVO_CODE_VOIE.Properties.ReadOnly = False

            txtIdentification.Enabled = True
            txtIdentification.BackColor = Color.White
            txtIdentification.TabStop = False
            txtIdentification.Properties.ReadOnly = False

            txtNomAbrege.Enabled = True
            txtNomAbrege.BackColor = Color.White
            txtNomAbrege.TabStop = False
            txtNomAbrege.Properties.ReadOnly = False

            Try
                txtValCoefficient.Text = Me.CdF_CODIFTableAdapter.GetDataByCode(txtIDVO_CDF_NUMERO_FK_PK.Text, txtIDVO_CDF_CODE_FK_PK.Text)(0).CDF_VAL_NUM.ToString().TrimEnd("0").TrimEnd(",")
            Catch ex As Exception

            End Try
            CatvO_CATEGORIEVOIETableAdapter1.FillByCode(DsTheriaque_Nomenclature21.CATVO_CATEGORIEVOIE, txtCode.Text)
        End If

    End Function

    Private Sub ADD_Identification()
        If Me.DsTheriaque1.IDVO_IDENT_VOIE.Rows.Count = 0 Then
            Me.BindingContext(Me.DsTheriaque1, IDVO_IDENT_VOIE).AddNew()
            txtIDVO_CDF_CODE_FK_PK.Text = txtCode.Text
            txtIDVO_CDF_NUMERO_FK_PK.Text = _Code_CDF
            Me.txtIdentification.Text = ""
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Ajouter()
        MyBase.Ajouter()
        Me.lkupCatégorie.Enabled = True
        Me.DsTheriaque1.SYCDF_SYNCODIF.Clear()
        Me.DsTheriaque1.CDFNP_CODIF.Clear()
        Me.DsTheriaque1.IDVO_IDENT_VOIE.Clear()
        Me.DsTheriaque_Nomenclature21.CDF_CODIF.Clear()

        Me.BindingContext(Me.DsTheriaque_Nomenclature21, CDF_CODIF).AddNew()
        Me.BindingContext(Me.DsTheriaque_Nomenclature21, CDF_CODIF).Current("CDF_DATECR") = Now.Date
        Me.BindingContext(Me.DsTheriaque_Nomenclature21, CDF_CODIF).Current("CDF_UNIT_NUM") = ""
        Me.BindingContext(Me.DsTheriaque_Nomenclature21, CDF_CODIF).Current("CDF_TEXTE") = ""
        txtValCoefficient.Text = ""
        txtNCodif.Text = _Code_CDF
        SetCDF_Codif(_Code_CDF, Me.txtCode, Me.DxErrorProvider)

        ADD_Identification()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Valider()
        MyBase.Valider()
        Dim isvalid As Boolean = True
        Dim decVal As Decimal

        'If (Decimal.TryParse(txtValCoefficient.Text, decVal)) Then
        '    Me.BindingContext(Me.DsTheriaque1, MasterTable).Current("CDF_VAL_NUM") = decVal 'Decimal.Parse(txtValCoefficient.Text)
        'Else
        '    If (String.IsNullOrEmpty(txtValCoefficient.Text)) Then
        '        Me.BindingContext(Me.DsTheriaque1, MasterTable).Current("CDF_VAL_NUM") = -1
        '    Else
        '        isvalid = False
        '        MsgBox("Le coefficient doit être de type numérique")
        '    End If
        'End If

        'If isvalid Then
        Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).Current("CDF_DATEMJ") = Now.Date
        If (String.IsNullOrEmpty(Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).Current("CDF_NOMABRG").ToString())) Then
            Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).Current("CDF_NOMABRG") = ""
        End If

        Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).EndCurrentEdit()
        CdF_CODIFTA.Update(Me.DsTheriaque_Nomenclature21.CDF_CODIF)

        Me.BindingContext(Me.DsTheriaque1, "SYCDF_SYNCODIF").EndCurrentEdit()
        SycdF_SYNCODIFTableAdapter.Update(Me.DsTheriaque1.SYCDF_SYNCODIF)

        Me.BindingContext(Me.DsTheriaque1, "CDFNP_CODIF").EndCurrentEdit()
        CdfnP_CODIFTableAdapter.Update(Me.DsTheriaque1.CDFNP_CODIF)
        If Me.BindingContext(Me.DsTheriaque1, "IDVO_IDENT_VOIE").Count = 0 Then
            If (Not String.IsNullOrEmpty(txtIdentification.Text)) Then
                Me.BindingContext(Me.DsTheriaque1, "IDVO_IDENT_VOIE").AddNew()
                Me.BindingContext(Me.DsTheriaque1, "IDVO_IDENT_VOIE").Current("IDVO_CDF_NUMERO_FK_PK") = txtNCodif.Text
                Me.BindingContext(Me.DsTheriaque1, "IDVO_IDENT_VOIE").Current("IDVO_CDF_CODE_FK_PK") = txtCode.Text
            End If

        End If
        If Me.BindingContext(Me.DsTheriaque1, "IDVO_IDENT_VOIE").Count <> 0 Then
            Me.BindingContext(Me.DsTheriaque1, "IDVO_IDENT_VOIE").Current("IDVO_CODE_VOIE") = txtIdentification.Text
            Me.BindingContext(Me.DsTheriaque1, "IDVO_IDENT_VOIE").EndCurrentEdit()
        End If
        IdvO_IDENT_VOIETableAdapter.Update(Me.DsTheriaque1.IDVO_IDENT_VOIE)

        If _Code_CDF = "18" Then
            UpdateCategorie()
        End If

        'End If

        'UpdateValNum()

    End Sub


    Private Sub UpdateCategorie()

        Dim sSQL As String

        sSQL = " DELETE FROM [theriaque].[CATVO_CATEGORIEVOIE] where CATVO_CDF_VO_CODE_FK_PK=" & cn.SQLText(txtCode.Text)
        cn.Execute(sSQL)

        If (Not String.IsNullOrEmpty(lkupCatégorie.EditValue)) Then
            If (lkupCatégorie.EditValue <> 0) Then
                sSQL = " INSERT INTO [theriaque].[CATVO_CATEGORIEVOIE]([CATVO_CDF_CAT_CODE_FK_PK],[CATVO_CDF_VO_CODE_FK_PK]) "
                sSQL &= " VALUES(" & cn.SQLText(lkupCatégorie.EditValue) & "," & cn.SQLText(txtCode.Text) & ")"
                cn.Execute(sSQL)
            End If
        End If

    End Sub

    Private Sub UpdateValNum()
        If (String.IsNullOrEmpty(txtValCoefficient.Text.Trim)) Then
            Dim sSql As String
            sSql = " Update theriaque.CDF_CODIF set CDF_VAL_NUM = null where CDF_NUMERO_PK='" & txtNCodif.Text & "' and CDF_CODE_PK='" & txtCode.Text & "'"

            cn.Execute(sSql)
        End If
    End Sub

    Public Overrides Sub annuler()
        MyBase.Annuler()
        Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature21.CDF_CODIF.RejectChanges()
        Try
            txtValCoefficient.Text = Me.CdF_CODIFTableAdapter.GetDataByCode(txtIDVO_CDF_NUMERO_FK_PK.Text, txtIDVO_CDF_CODE_FK_PK.Text)(0).CDF_VAL_NUM.ToString().TrimEnd("0").TrimEnd(",")
        Catch ex As Exception

        End Try

        If (Not String.IsNullOrEmpty(txtValCoefficient.Text)) Then
            If (Not String.IsNullOrEmpty(txtValCoefficient.Text)) Then
                If (Decimal.Round(Decimal.Parse(txtValCoefficient.Text)) = -1) Then
                    txtValCoefficient.Text = ""
                End If
            End If
        End If

        If (String.IsNullOrEmpty(txtCode.Text)) Then
            lkupCatégorie.Enabled = False
        End If

        Me.BindingContext(Me.DsTheriaque1, SYCDF_SYNCODIF).CancelCurrentEdit()
        Me.DsTheriaque1.SYCDF_SYNCODIF.RejectChanges()
        Me.BindingContext(Me.DsTheriaque1, CDFNP_CODIF).CancelCurrentEdit()
        Me.DsTheriaque1.CDFNP_CODIF.RejectChanges()
        Me.BindingContext(Me.DsTheriaque1, IDVO_IDENT_VOIE).CancelCurrentEdit()
        Me.DsTheriaque1.IDVO_IDENT_VOIE.RejectChanges()
        If Me.BindingContext(Me.DsTheriaque1, "IDVO_IDENT_VOIE").Count <> 0 Then
            txtIdentification.Text = Me.BindingContext(Me.DsTheriaque1, IDVO_IDENT_VOIE).Current("IDVO_CODE_VOIE")
        Else
            txtIdentification.Text = ""
        End If
    End Sub

    Public Overrides Function Supprimer() As Boolean

        MyBase.Supprimer()
        Dim inti As Integer

        For inti = 0 To DsTheriaque1.CDFNP_CODIF.Rows.Count - 1
            DsTheriaque1.CDFNP_CODIF.Rows(inti).Delete()
        Next
        txtValCoefficient.Text = ""
        Me.CdfnP_CODIFTableAdapter.Update(Me.DsTheriaque1)

        For inti = 0 To DsTheriaque1.SYCDF_SYNCODIF.Rows.Count - 1
            DsTheriaque1.SYCDF_SYNCODIF.Rows(inti).Delete()
        Next
        Me.SycdF_SYNCODIFTableAdapter.Update(Me.DsTheriaque1)

        If DsTheriaque1.IDVO_IDENT_VOIE.Rows.Count > 0 Then
            DsTheriaque1.IDVO_IDENT_VOIE.Rows(0).Delete()
            Me.IdvO_IDENT_VOIETableAdapter.Update(Me.DsTheriaque1)
        End If


        For inti = 0 To DsTheriaque_Nomenclature21.CDF_CODIF.Rows.Count - 1
            DsTheriaque_Nomenclature21.CDF_CODIF.Rows(0).Delete()
        Next
        Me.CdF_CODIFTA.Update(Me.DsTheriaque_Nomenclature21)

        txtIdentification.Text = ""

        Return True

    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Frm_PharmacoTherapeutiques_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InitVariable()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitVariable()

        FirstFocus = txtLibelle
        MasterDataSet = Me.DsTheriaque1
        MasterTable = CDF_CODIF
        Me.Label1.Text = LibNomenclature(_Code_CDF)
        InitLkup(lkupCDF25, CDF_CODIF, strSSQL_CDF_CODIF("25"), True, True, True)

        If _Code_CDF = "18" Then
            InitLkup(lkupCatégorie, "CDF_CODIF", strSSQL_CDF_CODIF2("33"), True)
            lblCategorie.Visible = True
            lkupCatégorie.Visible = True
        End If

        'Me.lkupCDF25.DataSource = CdF_CODIFTableAdapterSourceOffc.GetDataByNumero("25")

        Select Case _Code_Acces
            Case "A"
                lbValCoef.Visible = True
                txtValCoefficient.Visible = True
                lbNomABRG.Visible = False
                txtNomAbrege.Visible = False
                txtNomAbrege.Text = " A"
                btValider.Enabled = False
                btAnnuler.Enabled = False
                btAjouter.Enabled = True
                btChercher.Enabled = True
                btFermer.Enabled = True
                btSupprimer.Enabled = False
            Case Else
                lbValCoef.Visible = False
                txtValCoefficient.Visible = False
                lbNomABRG.Visible = True
                txtNomAbrege.Visible = True
        End Select

    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.SetRowCellValue(e.RowHandle, colSYCDF_CDF_CODE_FK, Me.txtCode.Text)
        GV.SetRowCellValue(e.RowHandle, colSYCDF_CDF_NUMERO_FK_PK, _Code_CDF)
        ModeFiche = eMode.Modification
        UpdateStateBouton()
    End Sub

    Private Sub GV2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        GV2.SetRowCellValue(e.RowHandle, colCDFNP_CDF_CODE_FK_PK, Me.txtCode.Text)
        GV2.SetRowCellValue(e.RowHandle, colCDFNP_NUMERO_FK_PK, _Code_CDF)
        ModeFiche = eMode.Modification
        UpdateStateBouton()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Validated, txtIDVO_CDF_NUMERO_FK_PK.Validated, txtIDVO_CDF_CODE_FK_PK.Validated
        ValideControl(sender, False)
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Ctrl"></param>
    ''' <param name="AllCtrl"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
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

        If Ctrl.Name.ToLower = "txtIDVO_CODE_VOIE".ToLower Or AllCtrl Then
            txtIDVO_CDF_CODE_FK_PK.Text = txtCode.Text
            txtIDVO_CDF_NUMERO_FK_PK.Text = _Code_CDF
        End If

        Return True
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
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

    Private Sub txtLibelle_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLibelle.Validated
        ValideControl(sender, False)
    End Sub

    Private Sub txtValCoefficient_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValCoefficient.TextChanged
        btValider.Enabled = True
        btAnnuler.Enabled = True
        btAjouter.Enabled = False
        btChercher.Enabled = False
        btFermer.Enabled = False
        btSupprimer.Enabled = False

        If (txtValCoefficient.Text.Trim().Equals("")) Then
            txtValCoefficient.Text = Nothing
        End If
    End Sub

    Private Sub txtNomAbrege_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomAbrege.EditValueChanged

    End Sub

    Private Sub txtIDVO_CODE_VOIE_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtIDVO_CODE_VOIE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btValider.Enabled = True
        btAnnuler.Enabled = True
        btAjouter.Enabled = False
        btChercher.Enabled = False
        btFermer.Enabled = False
        btSupprimer.Enabled = False
        'If (CTYPE(txtIDVO_CODE_VOIE,)) Then
        'codeIDVO
    End Sub

    Private Sub txtNomAbrege_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomAbrege.TextChanged
        btValider.Enabled = True
        btAnnuler.Enabled = True
        btAjouter.Enabled = False
        btChercher.Enabled = False
        btFermer.Enabled = False
        btSupprimer.Enabled = False
    End Sub

    Private Sub txtLibelle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLibelle.TextChanged
        btValider.Enabled = True
        btAnnuler.Enabled = True
        btAjouter.Enabled = False
        btChercher.Enabled = False
        btFermer.Enabled = False
        btSupprimer.Enabled = False
    End Sub

    Private Sub txtNCodif_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNCodif.EditValueChanged

    End Sub

   
    Private Sub txtIdentification_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdentification.TextChanged
        btValider.Enabled = True
        btAnnuler.Enabled = True
        btAjouter.Enabled = False
        btChercher.Enabled = False
        btFermer.Enabled = False
        btSupprimer.Enabled = False
    End Sub

    Private Sub lkupCatégorie_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupCatégorie.EditValueChanged
        btValider.Enabled = True
        btAnnuler.Enabled = True
        btAjouter.Enabled = False
        btSupprimer.Enabled = False
        btFermer.Enabled = False
        btChercher.Enabled = False
    End Sub

End Class
