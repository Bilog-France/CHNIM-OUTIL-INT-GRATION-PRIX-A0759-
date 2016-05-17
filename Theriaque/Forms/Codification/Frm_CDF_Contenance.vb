Public Class Frm_CDF_Contenance

    ''' <summary>
    ''' Code du type de la codification
    ''' </summary>
    ''' <remarks></remarks>
    Public _Code_CDF As String
    Private Changing As Boolean
    Private CodE As String

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim decVal As Decimal
        Dim symbole As String
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_CDF_CODIF(_Code_CDF)
        f.Text = Me.Text
        f.ShowDialog()
        txtHiddenABRG.Text = " "
        txtValeur.Text = " "
        If f._Code IsNot Nothing Then
            lkupUnite_UCUM.Enabled = True
            CodE = f._Code
            Me.DsTheriaque1.SYCDF_SYNCODIF.Clear()
            Me.DsTheriaque_Nomenclature21.CDF_CODIF.Clear()
            'ClsSP.initValNum(_Code_CDF, f._Code)
            Me.CdF_CODIFTA.FillByCode(Me.DsTheriaque_Nomenclature21.CDF_CODIF, _Code_CDF, f._Code)
            Me.SycdF_SYNCODIFTableAdapter.FillByCode(Me.DsTheriaque1.SYCDF_SYNCODIF, _Code_CDF, f._Code)
            If _Code_CDF = "NA" Or _Code_CDF = "GO" Then
                Dim res As StructResultCode = Code_PereFils(txtCode, "CDF_CODIF", DxErrorProvider, False, " CDF_NUMERO_PK = " & cn.SQLText(_Code_CDF))
                If res._Validation = True Then txtCodePere.Text = res._Code
            End If
            If _Code_CDF = "IY" Or _Code_CDF = "TP" Then
                'Me.CdfpF_LIEN_CDF_PERE_FILSTableAdapter.FillByCode(Me.DsTheriaque1.CDFPF_LIEN_CDF_PERE_FILS, _Code_CDF, f._Code)
                Dim sSql As String
                sSql = "select (CDFPF_CODEF_FK_PK + '_' + CDFPF_NUMEROF_FK_PK) as code, CDFPF_NUMEROP_FK_PK, CDFPF_CODEP_FK_PK, CDFPF_NUMEROF_FK_PK, CDFPF_CODEF_FK_PK, CDFPF_NUMORD FROM theriaque.CDFPF_LIEN_CDF_PERE_FILS"
                sSql &= " WHERE CDFPF_NUMEROP_FK_PK = " & cn.SQLText(_Code_CDF) & " AND CDFPF_CODEP_FK_PK = " & cn.SQLText(f._Code)
                Dim dt As DataTable
                dt = cn.MySelect(sSql)
                GC2.DataSource = dt
            End If
            Me.lkupUnite.Properties.ReadOnly = False
            Try
                txtValeur.Text = Me.CdF_CODIFTA.GetDataByCode(txtNCodif.Text, txtCode.Text)(0).CDF_VAL_NUM.ToString().TrimEnd("0").TrimEnd(",")
            Catch ex As Exception

            End Try

            Me.CdfcdfU_CDFUTableAdapter1.FillByCode(Me.DsTheriaque_Nomenclature21.CDFCDFU_CDFU, Me.txtNCodif.Text, CodE)
            'symbole = strSymbole("19", CodE)

            'cmbSymbole.SelectedText = strCodeSYMBOLE(symbole)
            'Me.lkupUnite_UCUM.EditValue = symbole

            InitLkup(lkupUnitref, CDF_CODIF, strSSQL_CDF_CODIF(txtNCodif.Text), True, False)

            UNITFACTEQ.FillByCode(Me.DsTheriaque_Nomenclature21.UNITFACTEQ_FACTEUR_EQUIVALENCE, txtCode.Text, txtNCodif.Text)
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Sub Ajouter()

        lkupUnite_UCUM.Enabled = True
        Me.DsTheriaque1.SYCDF_SYNCODIF.Clear()
        Me.DsTheriaque_Nomenclature21.CDF_CODIF.Clear()

        Me.DsTheriaque_Nomenclature21.UNITFACTEQ_FACTEUR_EQUIVALENCE.Clear()

        If _Code_CDF = "IY" Or _Code_CDF = "TP" Then
            'Me.DsTheriaque1.CDFPF_LIEN_CDF_PERE_FILS.Clear()
            'GC2.DataSource = Nothing
            For iCount As Integer = 0 To GV2.RowCount - 1
                GV2.DeleteRow(0)
            Next
        End If

        Me.BindingContext(Me.DsTheriaque_Nomenclature21, CDF_CODIF).AddNew()


        If (Not _Code_CDF.ToLower().Equals("tp")) Then
            SetCDF_Codif(_Code_CDF, Me.txtCode, Me.DxErrorProvider, txtCodePere)
            'Else
            '    'txtCode.Properties.MaxLength = 10
            '    Me.txtCode.Properties.ReadOnly = False
        End If

        txtNCodif.Text = _Code_CDF
        InitLkup(lkupUnitref, CDF_CODIF, strSSQL_CDF_CODIF(txtNCodif.Text), True, False)
        txtCodePere.EditValue = DBNull.Value
        CodE = InvalideControl
        txtValeur.Text = ""
        Me.lkupUnite.Properties.ReadOnly = False
        MyBase.Ajouter()

    End Sub

    Public Overrides Sub Valider()

        If (txtCode.ErrorText.Trim().Equals("")) Then
            MyBase.Valider()
            'If _Code_CDF = "TP" Or _Code_CDF = "PA" Then
            '    Dim decVal As Decimal

            '    If (Decimal.TryParse(txtValeur.Text, decVal)) Then
            '        Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).Current("CDF_VAL_NUM") = decVal 'Decimal.Parse(txtValeur.Text)
            '    Else
            '        If (String.IsNullOrEmpty(txtValeur.Text.Trim)) Then
            '            Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).Current("CDF_VAL_NUM") = -1
            '        Else
            '            MsgBox("Le coefficient doit être de type numérique")
            '        End If
            '    End If
            'End If

            If (lkupUnitref.EditValue Is System.DBNull.Value) Then
                MsgBox("Les champs unité de référence et facteur sont obligatoires")
                Exit Sub
            End If

            If (String.IsNullOrEmpty(lkupUnitref.EditValue) Or String.IsNullOrEmpty(txtFacteur.Text)) Then

                MsgBox("Les champs unité de référence et facteur sont obligatoires")
                Exit Sub
            End If


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

            If _Code_CDF = "19" Or _Code_CDF = "21" Or _Code_CDF = "PA" Then
                UpdateUniteUCUM()
            End If

            'Me.BindingContext(Me.DsTheriaque_Nomenclature21, "CDFCDFU_CDFU").EndCurrentEdit()
            'CdfcdfU_CDFUTableAdapter1.Update(Me.DsTheriaque_Nomenclature21.CDFCDFU_CDFU)

            If _Code_CDF = "IY" Then
                'Me.BindingContext(Me.DsTheriaque1, CDFPF_LIEN_CDF_PERE_FILS).EndCurrentEdit()
                'CdfpF_LIEN_CDF_PERE_FILSTableAdapter.Update(Me.DsTheriaque1.CDFPF_LIEN_CDF_PERE_FILS)
                UpdateLiaision()
                InitLkup(rpLiaison, CDF_CODIF, strSSQL_CDF_CODIF(_Code_CDF), True)
            End If

            If _Code_CDF = "TP" Then
                'Me.BindingContext(Me.DsTheriaque1, CDFPF_LIEN_CDF_PERE_FILS).EndCurrentEdit()
                'CdfpF_LIEN_CDF_PERE_FILSTableAdapter.Update(Me.DsTheriaque1.CDFPF_LIEN_CDF_PERE_FILS)
                'InitLkup(rpLiaison, CDF_CODIF, strSSQL_IN_CDF_CODIF("CC", "CS", "NC", "NN", "PT"), True)
                UpdateLiaision()
                Dim strSSQL As String
                strSSQL = "Select (CDF_CODE_PK + '_' + CDF_NUMERO_PK) as code, CDF_NOM as libelle,CDF_CODE_PK as val1, CDF_NUMERO_PK as val2  From THERIAQUE.CDF_CODIF  where CDF_NUMERO_PK in ('CC','CS','NC','NN','PT','GP','PC')"
                InitLkup(rpLiaison, CDF_CODIF, strSSQL, True)
            End If

            If _Code_CDF = "NA" Or _Code_CDF = "GO" Then
                InitLkup(lkupCDF_CODE_PK, CDF_CODIF, strSSQL_CDF_CODIF(_Code_CDF), True, False)
            End If

            UpdateValNum()
            UpdateUniteRef()

        End If

    End Sub


    Public Overrides Sub Annuler()
        MyBase.Annuler()
        'Me.lkupUnite.Enabled = False

        Me.BindingContext(Me.DsTheriaque_Nomenclature21, "CDFCDFU_CDFU").CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature21.CDFCDFU_CDFU.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_Nomenclature21, "UNITFACTEQ_FACTEUR_EQUIVALENCE").CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature21.UNITFACTEQ_FACTEUR_EQUIVALENCE.RejectChanges()


        UNITFACTEQ.FillByCode(Me.DsTheriaque_Nomenclature21.UNITFACTEQ_FACTEUR_EQUIVALENCE, txtCode.Text, txtNCodif.Text)

        Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature21.CDF_CODIF.RejectChanges()

        If (String.IsNullOrEmpty(txtCode.Text)) Then
            lkupUnite_UCUM.Enabled = False
        End If

        'Try
        '    txtValeur.Text = Me.CdF_CODIFTA.GetDataByCode(txtNCodif.Text, txtCode.Text)(0).CDF_VAL_NUM.ToString().TrimEnd("0").TrimEnd(",")
        'Catch ex As Exception

        'End Try

        'If (Not String.IsNullOrEmpty(txtValeur.Text.Trim())) Then
        '    If (Not String.IsNullOrEmpty(txtValeur.Text)) Then
        '        If (Decimal.Round(Decimal.Parse(txtValeur.Text)) = -1) Then
        '            txtValeur.Text = ""
        '        End If
        '    End If
        'End If

        Me.BindingContext(Me.DsTheriaque1, SYCDF_SYNCODIF).CancelCurrentEdit()
        Me.DsTheriaque1.SYCDF_SYNCODIF.RejectChanges()

        If ModeFiche = eMode.Ajout Then
            Me.txtCode.Text = ""
            Me.txtCode.EditValue = DBNull.Value
            Me.DsTheriaque1.SYCDF_SYNCODIF.Clear()
            Me.lkupUnite.Properties.ReadOnly = True
        End If

        If _Code_CDF = "IY" Or _Code_CDF = "TP" Then
            'Me.BindingContext(Me.DsTheriaque1, CDFPF_LIEN_CDF_PERE_FILS).CancelCurrentEdit()
            'Me.DsTheriaque1.CDFPF_LIEN_CDF_PERE_FILS.RejectChanges()
            If ModeFiche = eMode.Ajout Then
                'GC2.DataSource = Nothing
                For iCount As Integer = 0 To GV2.RowCount - 1
                    GV2.DeleteRow(0)
                Next
            Else
                Dim sSql As String
                sSql = "select (CDFPF_CODEF_FK_PK + '_' + CDFPF_NUMEROF_FK_PK) as code, CDFPF_NUMEROP_FK_PK, CDFPF_CODEP_FK_PK, CDFPF_NUMEROF_FK_PK, CDFPF_CODEF_FK_PK, CDFPF_NUMORD FROM theriaque.CDFPF_LIEN_CDF_PERE_FILS"
                sSql &= " WHERE CDFPF_NUMEROP_FK_PK = " & cn.SQLText(_Code_CDF) & " AND CDFPF_CODEP_FK_PK = " & cn.SQLText(CodE)
                Dim dt As DataTable
                dt = cn.MySelect(sSql)
                GC2.DataSource = dt
            End If
        End If
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
            txtValeur.Text = ""
            Dim inti As Integer
            For inti = 0 To DsTheriaque1.SYCDF_SYNCODIF.Rows.Count - 1
                DsTheriaque1.SYCDF_SYNCODIF.Rows(inti).Delete()
            Next

            If _Code_CDF = "IY" Or _Code_CDF = "TP" Then
                'For inti = 0 To DsTheriaque1.CDFPF_LIEN_CDF_PERE_FILS.Rows.Count - 1
                '    DsTheriaque1.CDFPF_LIEN_CDF_PERE_FILS.Rows(inti).Delete()
                'Next
            End If

            Dim delreq As String = " Delete from theriaque.CDFCDFU_CDFU where CDFCDFU_CDF_CODE_FK_PK='" & txtCode.Text & "' and CDFCDFU_CDF_NUMERO_FK_PK= '" & txtNCodif.Text & "'"
            cn.Execute(delreq)

            DsTheriaque_Nomenclature21.CDF_CODIF.Rows(0).Delete()

            Me.SycdF_SYNCODIFTableAdapter.Update(Me.DsTheriaque1)
            If _Code_CDF = "IY" Or _Code_CDF = "TP" Then
                'Me.CdfpF_LIEN_CDF_PERE_FILSTableAdapter.Update(Me.DsTheriaque1)
                Dim sSql As String
                sSql = "DELETE FROM theriaque.CDFPF_LIEN_CDF_PERE_FILS"
                sSql &= " WHERE CDFPF_NUMEROP_FK_PK = " & cn.SQLText(_Code_CDF) & " AND CDFPF_CODEP_FK_PK = " & cn.SQLText(CodE)
                cn.Execute(sSql)
                'GC2.DataSource = Nothing
                For iCount As Integer = 0 To GV2.RowCount - 1
                    GV2.DeleteRow(0)
                Next
            End If


           
            Me.CdF_CODIFTA.Update(Me.DsTheriaque_Nomenclature21)

            txtCodePere.Text = ""
            txtCode.Text = ""
            txtFacteur.Text = ""
            lkupUnitref.EditValue = ""
            lkupUnite.SelectedText = ""

            DsTheriaque_Nomenclature21.CDF_CODIF.Clear()
            Return True
        End If
    End Function

    Private Sub Frm_PharmacoTherapeutiques_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InitVariable()
    End Sub

    Private Sub InitVariable()

        Dim dtR As DataTable
        FirstFocus = txtLibelle
        MasterDataSet = Me.DsTheriaque_Nomenclature21
        MasterTable = CDF_CODIF
        Me.Label1.Text = LibNomenclature(_Code_CDF)

        Dim sSQL As String = "select (CDFPF_CODEF_FK_PK + '_' + CDFPF_NUMEROF_FK_PK) as code, CDFPF_NUMEROP_FK_PK, CDFPF_CODEP_FK_PK, CDFPF_NUMEROF_FK_PK, CDFPF_CODEF_FK_PK, CDFPF_NUMORD FROM theriaque.CDFPF_LIEN_CDF_PERE_FILS WHERE 1 = 2"
        Dim dt As DataTable = cn.MySelect(sSQL)
        Me.GC2.DataSource = dt

        If _Code_CDF = "NA" Or _Code_CDF = "GO" Then
            Me.PanPere.Visible = True
            InitLkup(lkupCDF_CODE_PK, CDF_CODIF, strSSQL_CDF_CODIF(_Code_CDF), True, False)
        End If

        If _Code_CDF = "IY" Then
            XtraTabPage_Liaison.PageVisible = True
            InitLkup(rpLiaison, CDF_CODIF, strSSQL_CDF_CODIF(_Code_CDF), True)
        End If

        If _Code_CDF = "TP" Then
            PanUnite.Visible = True
            XtraTabPage_Liaison.PageVisible = True
            Dim strSSQL As String
            strSSQL = "Select (CDF_CODE_PK + '_' + CDF_NUMERO_PK) as code, CDF_NOM as libelle,CDF_CODE_PK as val1, CDF_NUMERO_PK as val2  From THERIAQUE.CDF_CODIF  where CDF_NUMERO_PK in ('CC','CS','NC','NN','PT','GP','PC')"
            InitLkup(rpLiaison, CDF_CODIF, strSSQL, True)
            InitLkup(lkupUnite, CDF_CODIF, strSSQL_CDF_CODIF("PA"), True)
            Me.lkupUnite.Properties.ReadOnly = True
        End If

        If _Code_CDF = "PA" Then
            PanUnite.Visible = False
            InitLkup(lkupUnite, CDF_CODIF, strSSQL_CDF_CODIF("PA"), True)
            Me.lkupUnite.Properties.ReadOnly = True
        End If

        If _Code_CDF = "07" Then
            panAdrObserv.Visible = True

        End If

        If _Code_CDF = "19" Or _Code_CDF = "21" Or _Code_CDF = "PA" Then
            InitLkup(lkupUnite_UCUM, "CDFUCUM_UCUM", strSSQL_CDFUCUM_SYMBOLE(txtNCodif.Text), True)

            'lkupUnite_UCUM.Properties.DisplayMember = "libelle"

            'lkupUnite_UCUM.Properties.ValueMember = "code"

            'lkupUnite_UCUM.Properties.DataSource = dtSymbole("19")
            PanUniteUCUM.Visible = True
        End If

        Ctl_Off(txtCodePere)
        Ctl_Off(lkupCDF_CODE_PK)
        Ctl_Off(txtNCodif)
    End Sub

    Private Sub UpdateValNum()
        If (String.IsNullOrEmpty(txtValeur.Text.Trim)) Then
            Dim sSql As String
            sSql = " Update theriaque.CDF_CODIF set CDF_VAL_NUM = null where CDF_NUMERO_PK='" & txtNCodif.Text & "' and CDF_CODE_PK='" & txtCode.Text & "'"

            cn.Execute(sSql)
        End If
    End Sub


    Private Sub UpdateUniteRef()

        Dim exist As String = " select null from theriaque.UNITFACTEQ_FACTEUR_EQUIVALENCE "
        exist &= " where UNITFACTEQ_CDF_CODE_FK_PK='" & txtCode.Text & "' and "
        exist &= " UNITFACTEQ_CDF_NUM_FK_PK='" & txtNCodif.Text & "'"

        Dim dt As DataTable = cn.MySelect(exist)

        If dt.Rows.Count = 0 Then
            exist = " INSERT INTO [theriaque].[theriaque].[UNITFACTEQ_FACTEUR_EQUIVALENCE] "
            exist &= " ([UNITFACTEQ_CDF_CODE_FK_PK],[UNITFACTEQ_REF_CDF_CODE_FK_PK] "
            exist &= " ,[UNITFACTEQ_CDF_NUM_FK_PK],[UNITFACTEQ_FACTEQ]) "
            exist &= " VALUES('" & txtCode.Text & "'" & ",'" & lkupUnitref.EditValue & "','" & txtNCodif.Text & "'" & "," & txtFacteur.Text.Replace(",", ".") & ")"

        Else
            exist = " UPDATE [theriaque].[theriaque].[UNITFACTEQ_FACTEUR_EQUIVALENCE] SET "
            exist &= "[UNITFACTEQ_REF_CDF_CODE_FK_PK]='" & lkupUnitref.EditValue & "'"
            exist &= ",[UNITFACTEQ_FACTEQ]=" & txtFacteur.Text.Replace(",", ".")
            exist &= " WHERE [UNITFACTEQ_CDF_CODE_FK_PK]= '" & txtCode.Text & "'"
            exist &= " and [UNITFACTEQ_CDF_NUM_FK_PK] = '" & txtNCodif.Text & "'"
        End If

        cn.Execute(exist)


    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.SetRowCellValue(e.RowHandle, colSYCDF_CDF_CODE_FK, Me.txtCode.Text)
        GV.SetRowCellValue(e.RowHandle, colSYCDF_CDF_NUMERO_FK_PK, _Code_CDF)
        ModeFiche = eMode.Modification
        UpdateStateBouton()
    End Sub

    Private Sub GV2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        GV2.SetRowCellValue(e.RowHandle, colCDFPF_CODEP_FK_PK, Me.txtCode.Text)
        GV2.SetRowCellValue(e.RowHandle, colCDFPF_NUMEROP_FK_PK, _Code_CDF)
        GV2.SetRowCellValue(e.RowHandle, colCDFPF_NUMEROF_FK_PK, _Code_CDF)
        GV2.SetFocusedRowCellValue(colCDFPF_CODEF_FK_PK, "")
        GV2.SetFocusedRowCellValue(colCDFPF_NUMORD, Code_MAx(GV2, colCDFPF_NUMORD))
        ModeFiche = eMode.Modification
        UpdateStateBouton()
    End Sub

    Private Sub txtCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Validated

        If (Not _Code_CDF.ToLower().Equals("tp")) Then
            If Changing Then
                Exit Sub
            End If
            Changing = True
            If ModeFiche <> eMode.StandBy And ModeFiche = eMode.Ajout Then
                SetCDF_Codif(_Code_CDF, Me.txtCode, Me.DxErrorProvider, txtCodePere)
            End If
            Changing = False
        Else
            ValideControl(sender, False)
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

        If Ctrl.Name.ToLower = "txtCode".ToLower Or AllCtrl Then
            If ModeFiche = eMode.Ajout Then
                strSSQL = "  Select * from THERIAQUE.CDF_CODIF where CDF_CODE_PK = " & cn.SQLText(txtCode.Text)
                strSSQL &= " and CDF_NUMERO_PK = " & cn.SQLText(_Code_CDF)
                Dim dt As DataTable = cn.MySelect(strSSQL)
                If dt.Rows.Count > 0 Then
                    Me.DxErrorProvider.SetError(txtCode, StrValeurExist)
                    Return False
                Else
                    Me.DxErrorProvider.SetError(txtCode, "")
                End If
            End If

        End If

        Return True
    End Function

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

    Private Sub txtCodePere_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodePere.EditValueChanged
        If Me.txtCodePere.EditValue IsNot DBNull.Value Then
            lkupCDF_CODE_PK.EditValue = Me.txtCodePere.EditValue
        Else
            lkupCDF_CODE_PK.EditValue = DBNull.Value
        End If
    End Sub

    Private Sub rpLiaison_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles rpLiaison.Validating
        Dim lke As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
        Dim Code As String = lke.EditValue.ToString()
        Dim _code As String() = Code.Split("_")

        Dim codeS As String = ""
        Dim count As Integer = 0
        For i As Integer = 0 To GV2.RowCount - 1
            If (GV2.GetDataRow(i) IsNot Nothing) Then
                codeS = GV2.GetDataRow(i)("code")
                codeS = codeS.Split("_")(0)
                If (codeS.ToLower().Equals(_code(0).ToLower())) Then
                    count += 1
                End If
                If (count > 0) Then
                    e.Cancel = True
                    MsgBox("Vous avez choisi une valeur qui est déja liée")
                    Exit For
                End If
            End If
        Next

        GV2.SetRowCellValue(GV2.FocusedRowHandle, colCDFPF_CODEF_FK_PK, _code(0))
        GV2.SetRowCellValue(GV2.FocusedRowHandle, colCDFPF_NUMEROF_FK_PK, _code(1))

        'rpLiaison.GetDataSourceRowByMultipleKeyValues(rpLiaison.
    End Sub

    Private Sub btAjouter_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAjouter.Click
        If Me.txtCode.Properties.ReadOnly = False Then

            Me.txtCode.Select()
        End If
        txtHiddenABRG.Text = " "
        txtValeur.Text = " "
    End Sub

    Private Sub txtLibelle_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLibelle.Validated
        ValideControl(sender, False)
    End Sub

    Private Sub btADDLiaison_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btADDLiaison.Click
        'If Code IsNot Nothing And Code <> InvalideControl And Code <> Nothing Then
        If _Code_CDF = "TP" Then
            Dim strSSQL As String
            strSSQL = "Select (CDF_CODE_PK + '_' + CDF_NUMERO_PK) as code, CDF_NOM as libelle, CDF_CODE_PK as val1, CDF_NUMERO_PK as val2  From THERIAQUE.CDF_CODIF  where CDF_NUMERO_PK in ('CC','CS','NC','NN','PT','GP','PC')"

            Dim f As New Frm_Dictionnaire
            f._SSQL = strSSQL
            f.colCode.Caption = "Clé unique"
            f.colVal1.Caption = "Code"
            f.colVal2.Caption = "Num CODIF"
            f.ShowDialog()
            If f._Code IsNot Nothing Then
                GV2.AddNewRow()
                GV2.SetFocusedRowCellValue(colCode, f._Code)
                GV2.SetFocusedRowCellValue(colCDFPF_CODEF_FK_PK, f._Collection(1))
                GV2.SetFocusedRowCellValue(colCDFPF_NUMEROF_FK_PK, f._Collection(2))
                GV2.UpdateCurrentRow()
            End If
        End If
    End Sub

    Private Sub UpdateLiaision()
        Dim sSQL As String
        sSQL = "DELETE FROM theriaque.CDFPF_LIEN_CDF_PERE_FILS"
        sSQL &= " WHERE CDFPF_NUMEROP_FK_PK = " & cn.SQLText(_Code_CDF) & " AND CDFPF_CODEP_FK_PK = " & cn.SQLText(Me.txtCode.Text)
        cn.Execute(sSQL)
        For iCount As Integer = 0 To GV2.RowCount - 1
            If GV2.GetRowCellValue(iCount, colCDFPF_CODEP_FK_PK) IsNot Nothing Then


                Dim code As String = ""
                If (GV2.GetRowCellValue(iCount, colCDFPF_CODEF_FK_PK) IsNot Nothing) Then
                    code = GV2.GetRowCellValue(iCount, colCDFPF_CODEF_FK_PK)
                End If

                If (Not String.IsNullOrEmpty(code)) Then
                    sSQL = "INSERT INTO theriaque.CDFPF_LIEN_CDF_PERE_FILS(CDFPF_NUMEROP_FK_PK, CDFPF_CODEP_FK_PK, CDFPF_NUMEROF_FK_PK, CDFPF_CODEF_FK_PK,CDFPF_NUMORD) "
                    sSQL &= "VALUES(" & cn.SQLText(_Code_CDF) & "," & cn.SQLText(GV2.GetRowCellValue(iCount, colCDFPF_CODEP_FK_PK)) & "," & cn.SQLText(GV2.GetRowCellValue(iCount, colCDFPF_NUMEROF_FK_PK)) & "," & cn.SQLText(code) & "," & cn.SQLText(GV2.GetRowCellValue(iCount, colCDFPF_NUMORD)) & ")"
                    Try
                        cn.Execute(sSQL)

                    Catch ex As Exception
                        Dim e As Exception = ex
                    End Try

                End If
            End If
        Next
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

    Private Sub TextEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtValeur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValeur.TextChanged

        btValider.Enabled = True
        btAnnuler.Enabled = True
        btAjouter.Enabled = False
        btChercher.Enabled = False
        btFermer.Enabled = False
        btSupprimer.Enabled = False
        If (txtValeur.Text.Trim().Equals("")) Then
            txtValeur.Text = Nothing
        End If

    End Sub

    Private Sub txtValeur_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValeur.EditValueChanged

    End Sub

    Private Sub txtValeur_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtValeur.Validating

    End Sub

    Private Sub txtValeur_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValeur.Validated

    End Sub


    Private Sub txtLibelle_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLibelle.EnabledChanged



    End Sub

    Private Sub lkupUnite_UCUM_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupUnite_UCUM.EditValueChanged, lkupUnitref.EditValueChanged
        btValider.Enabled = True
        btAnnuler.Enabled = True
        btAjouter.Enabled = False
        btSupprimer.Enabled = False
        btFermer.Enabled = False
        btChercher.Enabled = False
    End Sub

    Private Sub txtFacteur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFacteur.TextChanged
        If (txtFacteur.Text.Trim().Equals("")) Then
            txtFacteur.Text = Nothing
        End If
        btValider.Enabled = True
        btAnnuler.Enabled = True
        btAjouter.Enabled = False
        btSupprimer.Enabled = False
        btFermer.Enabled = False
        btChercher.Enabled = False
    End Sub
End Class
