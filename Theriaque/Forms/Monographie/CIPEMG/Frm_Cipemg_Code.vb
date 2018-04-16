''' <summary>
''' Created By [BFE]
''' </summary>
''' <remarks> Monographie - Cipemg - Code </remarks>
Public Class Frm_Cipemg_Code

#Region " Déclaration des variables privées "
    Private CodE As String
    Public _Code As Integer = Nothing ' charger la fiche depuis l'extérieur
    Private Tab_lkup1 As Boolean = False
    Private Tab_TA1 As Boolean = False
    Private Tab_lkup2 As Boolean = False
    Private Tab_TA2 As Boolean = False
    Private bModeDuplication As Boolean = False
#End Region

#Region " Edit Data  "

    ''' <summary>
    ''' Fonction: Recherche par code et retour des données de la fiche
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks>Fonction surchargée</remarks>
    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_FCPM_FICHECIPEMG
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            XtraTabControl1.SelectedTabPageIndex = 0
            OnLoading = True
            EmptyDataTable()
            Me.FcpM_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPM_FICHECIPEMG, f._Code)
            'BindOrigine()

            cmbOrigine.Text = Me.BindingContext(Me.MasterDataSet, MasterTable).Current("FCPM_ORIGINE")


            'Onglet Entités
            Me.FcpmcpH_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMCPH_CIPEMG_CLPH, f._Code)
            Me.FcpmccH_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMCCH_CIPEMG_CLCH, f._Code)
            Me.FcpmsaC_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMSAC_CIPEMG_SUBAC, f._Code)
            Me.FcpmsaU_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMSAU_CIPEMG_SUBAU, f._Code)
            Me.FcpmpR_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMPR_CIPEMG_PROD, f._Code)
            Me.FcpmcH_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMCH_CIPEMGCH, f._Code)
            Me.FcpmsP_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMSP_CIPEMG_SPE, f._Code)
            Tab_TA1 = False
            Tab_TA2 = False
            bModeDuplication = False
            OnLoading = False
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Fonction: Recherche par code et spécialité et retour des données de la fiche
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks>Fonction surchargée</remarks>
    Public Overrides Function ChercherAvance() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_FCPM_FICHECIPEMG_SPECIALITE()
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            XtraTabControl1.SelectedTabPageIndex = 0
            OnLoading = True
            EmptyDataTable()
            Me.FcpM_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPM_FICHECIPEMG, f._Code)
            'BindOrigine()
            'Onglet Entités
            Me.FcpmcpH_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMCPH_CIPEMG_CLPH, f._Code)
            Me.FcpmccH_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMCCH_CIPEMG_CLCH, f._Code)
            Me.FcpmsaC_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMSAC_CIPEMG_SUBAC, f._Code)
            Me.FcpmsaU_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMSAU_CIPEMG_SUBAU, f._Code)
            Me.FcpmpR_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMPR_CIPEMG_PROD, f._Code)
            Me.FcpmcH_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMCH_CIPEMGCH, f._Code)
            Me.FcpmsP_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMSP_CIPEMG_SPE, f._Code)
            Tab_TA2 = False
            Tab_TA1 = False

            OnLoading = False
            bModeDuplication = False
            Return True
        Else
            Return False
        End If
    End Function


    ''' <summary>
    ''' Fonction: Recherche multicritères
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks>Fonction surchargée</remarks>
    Public Overrides Function ChercherMultiCriteres() As Boolean
        MyBase.ChercherMultiCriteres()
        Dim sCodeCPH As String = ""
        Dim sCodeCCH As String = ""
        Dim sCodePR As String = ""
        Dim sCodeSAC As String = ""
        Dim sCodeSAU As String = ""
        Dim sCodeSP As String = ""
        Dim sCodeCC As String = ""
        Dim sCodeTERR As String = ""
        Dim sCodeCOM As String = ""
        Dim sCodeNIV As String = ""
        Dim sCodeCOMAUTRE As String = ""
        Dim f As New Frm_CipemgCodeMultiCriteres
        f.ShowDialog()
        If f._Validate Then
            If f._bCPH Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CPH_CLASSEPHARMTHER
                fDICO.Text = "Classes pharmaco-thérapeutique"
                fDICO.ShowDialog()
                sCodeCPH = fDICO._Code
            End If
            If f._bCCH Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CCH_CLASSECHIMIQUE
                fDICO.Text = "Classes chimiques"
                fDICO.ShowDialog()
                sCodeCCH = fDICO._Code
            End If
            If f._bPR Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_PR_PRODUIT
                fDICO.Text = "Produits"
                fDICO.ShowDialog()
                sCodePR = fDICO._Code
            End If
            If f._bSAC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SAC_SUBACTIVE
                fDICO.Text = "Substances actives"
                fDICO.ShowDialog()
                sCodeSAC = fDICO._Code
            End If
            If f._bSAU Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SAU_SUBAUXILIAIRE
                fDICO.Text = "Excipients"
                fDICO.ShowDialog()
                sCodeSAU = fDICO._Code
            End If
            If f._bSP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SP_SPECIALITE
                fDICO.Text = "Spécialités"
                fDICO.ShowDialog()
                sCodeSP = fDICO._Code
            End If
            If f._bCC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CH_CHOIX
                fDICO.Text = "Critères de choix"
                fDICO.ShowDialog()
                sCodeCC = fDICO._Code
            End If
            If f._bTERR Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("CS")
                fDICO.Text = "Terrain"
                fDICO.ShowDialog()
                sCodeTERR = fDICO._Code
            End If
            If f._bCOM Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("CC", " and substring(CDF_CODE_PK, 1, 1) IN('A', 'B', 'D', 'G', 'J', 'H', 'E', 'L', 'T')")
                fDICO.Text = "Commentaires"
                fDICO.ShowDialog()
                sCodeCOM = fDICO._Code
            End If
            If f._bNIV Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("CC", " and substring(CDF_CODE_PK, 1, 1) =  'X'")
                fDICO.Text = "Niveaux"
                fDICO.ShowDialog()
                sCodeNIV = fDICO._Code
            End If
            If f._bCOMAUTRE Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("CC", " and substring(CDF_CODE_PK, 1, 1) NOT IN('A', 'D', 'H', 'E', 'L', 'T', 'X', 'B', 'J', 'G')")
                fDICO.Text = "Commentaires autres"
                fDICO.ShowDialog()
                sCodeCOMAUTRE = fDICO._Code
            End If

            Dim fResultat As New Frm_Recherche
            Dim sSQL As String = ""
            sSQL &= " Select FCPM_CODE_SQ_PK as code, '' as libelle From THERIAQUE.FCPM_FICHECIPEMG"
            If sCodeCPH <> "" Then
                sSQL &= " WHERE FCPM_CODE_SQ_PK IN (SELECT FCPMCPH_FCPM_CODE_FK_PK FROM THERIAQUE.FCPMCPH_CIPEMG_CLPH WHERE FCPMCPH_CPH_CODE_FK_PK = " & cn.SQLText(sCodeCPH) & ")"
            End If
            If sCodeCCH <> "" Then
                If sCodeCPH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FCPM_CODE_SQ_PK IN (SELECT FCPMCCH_FCPM_CODE_FK_PK FROM THERIAQUE.FCPMCCH_CIPEMG_CLCH WHERE FCPMCCH_CCH_CODE_FK_PK = " & cn.SQLText(sCodeCCH) & ")"
            End If
            If sCodeSAC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FCPM_CODE_SQ_PK IN (SELECT FCPMSAC_FCPM_CODE_FK_PK FROM THERIAQUE.FCPMSAC_CIPEMG_SUBAC WHERE FCPMSAC_SAC_CODE_FK_PK = " & cn.SQLText(sCodeSAC) & ")"
            End If
            If sCodeSAU <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FCPM_CODE_SQ_PK IN (SELECT FCPMSAU_FCPM_CODE_FK_PK FROM THERIAQUE.FCPMSAU_CIPEMG_SUBAU WHERE FCPMSAU_SAU_CODE_FK_PK = " & cn.SQLText(sCodeSAU) & ")"
            End If
            If sCodePR <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FCPM_CODE_SQ_PK IN (SELECT FCPMPR_FCPM_CODE_FK_PK FROM THERIAQUE.FCPMPR_CIPEMG_PROD WHERE FCPMPR_PR_CODE_FK_PK = " & cn.SQLText(sCodePR) & ")"
            End If
            If sCodeSP <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FCPM_CODE_SQ_PK IN (SELECT FCPMSP_FCPM_CODE_FK_PK FROM THERIAQUE.FCPMSP_CIPEMG_SPE WHERE FCPMSP_SP_CODE_FK_PK = " & cn.SQLText(sCodeSP) & ")"
            End If
            If sCodeCC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FCPM_CODE_SQ_PK IN (SELECT FCPMCH_FCPM_CODE_FK_PK FROM THERIAQUE.FCPMCH_CIPEMGCH WHERE FCPMCH_CH_CODE_FK_PK = " & cn.SQLText(sCodeCC) & ")"
            End If
            If sCodeTERR <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FCPM_CODE_SQ_PK IN (SELECT FCPMTER_FCPM_CODE_FK_PK FROM THERIAQUE.FCPMTER_FCPM_TERRAIN WHERE FCPMTER_CDF_TER_CODE_FK_PK = " & cn.SQLText(sCodeTERR) & ")"
            End If
            If sCodeCOM <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeTERR <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FCPM_CODE_SQ_PK IN (SELECT TERCOM_FCPM_CODE_FK_PK FROM THERIAQUE.TERCOM_TERRAIN_COMMENTAIRE WHERE TERCOM_CDF_COM_CODE_FK_PK = " & cn.SQLText(sCodeCOM) & ")"
            End If
            If sCodeNIV <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeTERR <> "" Or sCodeCOM <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FCPM_CODE_SQ_PK IN (SELECT NIVCOM_FCPM_CODE_FK_PK FROM THERIAQUE.NIVCOM_NIVEAU_COMMENTAIRE WHERE NIVCOM_CDF_COM_CODE_FK_PK = " & cn.SQLText(sCodeNIV) & ")"
            End If
            If sCodeCOMAUTRE <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeTERR <> "" Or sCodeCOM <> "" Or sCodeNIV <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FCPM_CODE_SQ_PK IN (SELECT AUTCOM_FCPM_CODE_FK_PK FROM THERIAQUE.AUTCOM_AUTRE_COMMENTAIRE WHERE AUTCOM_CDF_COM_CODE_FK_PK = " & cn.SQLText(sCodeCOMAUTRE) & ")"
            End If
            sSQL &= " ORDER BY FCPM_CODE_SQ_PK"

            fResultat._SSQL = sSQL
            fResultat.Text = Me.Text
            fResultat.ShowDialog()
            CodE = fResultat._Code
            If fResultat._Code IsNot Nothing Then
                XtraTabControl1.SelectedTabPageIndex = 0
                OnLoading = True
                EmptyDataTable()
                Me.FcpM_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPM_FICHECIPEMG, fResultat._Code)
                'BindOrigine()
                'Onglet Entités
                Me.FcpmcpH_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMCPH_CIPEMG_CLPH, fResultat._Code)
                Me.FcpmccH_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMCCH_CIPEMG_CLCH, fResultat._Code)
                Me.FcpmsaC_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMSAC_CIPEMG_SUBAC, fResultat._Code)
                Me.FcpmsaU_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMSAU_CIPEMG_SUBAU, fResultat._Code)
                Me.FcpmpR_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMPR_CIPEMG_PROD, fResultat._Code)
                Me.FcpmcH_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMCH_CIPEMGCH, fResultat._Code)
                Me.FcpmsP_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMSP_CIPEMG_SPE, fResultat._Code)
                Tab_TA1 = False
                Tab_TA2 = False
                bModeDuplication = False
                OnLoading = False
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
    ''' <summary>
    ''' Proçédure: Ajout d'un enregistrement
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub Ajouter()
        EmptyDataTable()
        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        SetCode_MAx(MasterTable, txtCode)
        CodE = InvalideControl
        MyBase.Ajouter()
        bModeDuplication = False
        cmbOrigine.Text = ""
        RG.Text = "C"
        XtraTabControl1.SelectedTabPageIndex = 0
    End Sub

    ''' <summary>
    ''' Fonction: Suppression d'un enregistrement
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks>Fonction surchargée</remarks>
    Public Overrides Function supprimer() As Boolean
        If Tab_TA1 And Tab_TA2 Then
            MyBase.Supprimer()
            Dim iCount As Integer
            'Onglet Entités
            For iCount = 0 To DsTheriaque_Cipemg_Code.FCPMCPH_CIPEMG_CLPH.Rows.Count - 1
                DsTheriaque_Cipemg_Code.FCPMCPH_CIPEMG_CLPH.Rows(iCount).Delete()
            Next
            Me.FcpmcpH_TA.Update(DsTheriaque_Cipemg_Code)

            For iCount = 0 To DsTheriaque_Cipemg_Code.FCPMCCH_CIPEMG_CLCH.Rows.Count - 1
                DsTheriaque_Cipemg_Code.FCPMCCH_CIPEMG_CLCH.Rows(iCount).Delete()
            Next
            Me.FcpmccH_TA.Update(DsTheriaque_Cipemg_Code)

            For iCount = 0 To DsTheriaque_Cipemg_Code.FCPMSAC_CIPEMG_SUBAC.Rows.Count - 1
                DsTheriaque_Cipemg_Code.FCPMSAC_CIPEMG_SUBAC.Rows(iCount).Delete()
            Next
            Me.FcpmsaC_TA.Update(DsTheriaque_Cipemg_Code)

            For iCount = 0 To DsTheriaque_Cipemg_Code.FCPMSAU_CIPEMG_SUBAU.Rows.Count - 1
                DsTheriaque_Cipemg_Code.FCPMSAU_CIPEMG_SUBAU.Rows(iCount).Delete()
            Next
            Me.FcpmsaU_TA.Update(DsTheriaque_Cipemg_Code)

            For iCount = 0 To DsTheriaque_Cipemg_Code.FCPMPR_CIPEMG_PROD.Rows.Count - 1
                DsTheriaque_Cipemg_Code.FCPMPR_CIPEMG_PROD.Rows(iCount).Delete()
            Next
            Me.FcpmpR_TA.Update(DsTheriaque_Cipemg_Code)

            For iCount = 0 To DsTheriaque_Cipemg_Code.FCPMCH_CIPEMGCH.Rows.Count - 1
                DsTheriaque_Cipemg_Code.FCPMCH_CIPEMGCH.Rows(iCount).Delete()
            Next
            Me.FcpmcH_TA.Update(DsTheriaque_Cipemg_Code)

            For iCount = 0 To DsTheriaque_Cipemg_Code.FCPMSP_CIPEMG_SPE.Rows.Count - 1
                DsTheriaque_Cipemg_Code.FCPMSP_CIPEMG_SPE.Rows(iCount).Delete()
            Next
            Me.FcpmsP_TA.Update(DsTheriaque_Cipemg_Code)

            'Onglet Nature

            For iCount = 0 To DsTheriaque_Cipemg_Code.TERCOM_TERRAIN_COMMENTAIRE.Rows.Count - 1
                DsTheriaque_Cipemg_Code.TERCOM_TERRAIN_COMMENTAIRE.Rows(iCount).Delete()
            Next
            Me.TercoM_TA.Update(DsTheriaque_Cipemg_Code)

            For iCount = 0 To DsTheriaque_Cipemg_Code.NIVCOM_NIVEAU_COMMENTAIRE.Rows.Count - 1
                DsTheriaque_Cipemg_Code.NIVCOM_NIVEAU_COMMENTAIRE.Rows(iCount).Delete()
            Next
            Me.NivcoM_TA.Update(DsTheriaque_Cipemg_Code)

            For iCount = 0 To DsTheriaque_Cipemg_Code.AUTCOM_AUTRE_COMMENTAIRE.Rows.Count - 1
                DsTheriaque_Cipemg_Code.AUTCOM_AUTRE_COMMENTAIRE.Rows(iCount).Delete()
            Next
            Me.AutcoM_TA.Update(DsTheriaque_Cipemg_Code)

            For iCount = 0 To DsTheriaque_Cipemg_Code.FCPMTX_FICHECIPEMG_TEXTE.Rows.Count - 1
                DsTheriaque_Cipemg_Code.FCPMTX_FICHECIPEMG_TEXTE.Rows(iCount).Delete()
            Next
            Me.FcpmtX_TA.Update(DsTheriaque_Cipemg_Code)

            For iCount = 0 To DsTheriaque_Cipemg_Code.FCPMTER_FCPM_TERRAIN.Rows.Count - 1
                DsTheriaque_Cipemg_Code.FCPMTER_FCPM_TERRAIN.Rows(iCount).Delete()
            Next
            Me.FcpmteR_TA.Update(DsTheriaque_Cipemg_Code)

            'Onglet Références officielles
            For iCount = 0 To DsTheriaque_Cipemg_Code.FCPMAFS_CIPEMG_AFSSAPS.Rows.Count - 1
                DsTheriaque_Cipemg_Code.FCPMAFS_CIPEMG_AFSSAPS.Rows(iCount).Delete()
            Next
            Me.FcpmafS_TA.Update(DsTheriaque_Cipemg_Code)

            ' Master
            DsTheriaque_Cipemg_Code.FCPM_FICHECIPEMG.Rows(0).Delete()
            Me.FcpM_TA.Update(Me.MasterDataSet)
            cmbOrigine.Text = ""

            bModeDuplication = False
            Return True
        Else
            Process_Message(strChargementOnglet, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Function

    ''' <summary>
    ''' Proçédure: Validation d'un enregistrement
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub valider()
        MyBase.Valider()

        'DateEdit1.EditValue = Now.Date
        'DateEdit1.DateTime = Now.Date

        If (cmbOrigine.SelectedItem.Equals("RCP")) Then
            Me.BindingContext(Me.MasterDataSet, MasterTable).Current("FCPM_ORIGINE") = "R"
        End If
        If (cmbOrigine.SelectedItem.Equals("Autre")) Then
            Me.BindingContext(Me.MasterDataSet, MasterTable).Current("FCPM_ORIGINE") = "A"
        End If

        'Me.BindingContext(Me.MasterDataSet, MasterTable).Current("FCPM_DATECR") = Now.Date
        'Me.BindingContext(Me.MasterDataSet, MasterTable).Current("FCPM_DATEMJ") = Now.Date

        Try
            Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        Catch ex As Exception
            Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        End Try

        FcpM_TA.Update(Me.DsTheriaque_Cipemg_Code.FCPM_FICHECIPEMG)
        'BindOrigine()
        'Onglet Entités

        Me.BindingContext(Me.MasterDataSet, FCPMCPH_CIPEMG_CLPH).EndCurrentEdit()
        FcpmcpH_TA.Update(Me.DsTheriaque_Cipemg_Code.FCPMCPH_CIPEMG_CLPH)

        Me.BindingContext(Me.MasterDataSet, FCPMCCH_CIPEMG_CLCH).EndCurrentEdit()
        FcpmccH_TA.Update(Me.DsTheriaque_Cipemg_Code.FCPMCCH_CIPEMG_CLCH)

        Me.BindingContext(Me.MasterDataSet, FCPMSAC_CIPEMG_SUBAC).EndCurrentEdit()
        FcpmsaC_TA.Update(Me.DsTheriaque_Cipemg_Code.FCPMSAC_CIPEMG_SUBAC)

        Me.BindingContext(Me.MasterDataSet, FCPMSAU_CIPEMG_SUBAU).EndCurrentEdit()
        FcpmsaU_TA.Update(Me.DsTheriaque_Cipemg_Code.FCPMSAU_CIPEMG_SUBAU)

        Me.BindingContext(Me.MasterDataSet, FCPMPR_CIPEMG_PROD).EndCurrentEdit()
        FcpmpR_TA.Update(Me.DsTheriaque_Cipemg_Code.FCPMPR_CIPEMG_PROD)

        Me.BindingContext(Me.MasterDataSet, FCPMCH_CIPEMGCH).EndCurrentEdit()
        FcpmcH_TA.Update(Me.DsTheriaque_Cipemg_Code.FCPMCH_CIPEMGCH)

        Me.BindingContext(Me.MasterDataSet, FCPMSP_CIPEMG_SPE).EndCurrentEdit()
        FcpmsP_TA.Update(Me.DsTheriaque_Cipemg_Code.FCPMSP_CIPEMG_SPE)

        'Onglet Nature
        Me.BindingContext(Me.MasterDataSet, FCPMTER_FCPM_TERRAIN).EndCurrentEdit()
        FcpmteR_TA.Update(Me.DsTheriaque_Cipemg_Code.FCPMTER_FCPM_TERRAIN)

        Me.BindingContext(Me.MasterDataSet, TERCOM_TERRAIN_COMMENTAIRE).EndCurrentEdit()
        TercoM_TA.Update(Me.DsTheriaque_Cipemg_Code.TERCOM_TERRAIN_COMMENTAIRE)

        Me.BindingContext(Me.MasterDataSet, NIVCOM_NIVEAU_COMMENTAIRE).EndCurrentEdit()
        NivcoM_TA.Update(Me.DsTheriaque_Cipemg_Code.NIVCOM_NIVEAU_COMMENTAIRE)

        Me.BindingContext(Me.MasterDataSet, AUTCOM_AUTRE_COMMENTAIRE).EndCurrentEdit()
        AutcoM_TA.Update(Me.DsTheriaque_Cipemg_Code.AUTCOM_AUTRE_COMMENTAIRE)

        Me.BindingContext(Me.MasterDataSet, FCPMTX_FICHECIPEMG_TEXTE).EndCurrentEdit()
        FcpmtX_TA.Update(Me.DsTheriaque_Cipemg_Code.FCPMTX_FICHECIPEMG_TEXTE)

        'Onglet Références officielles
        Me.BindingContext(Me.MasterDataSet, FCPMAFS_CIPEMG_AFSSAPS).EndCurrentEdit()
        FcpmafS_TA.Update(Me.DsTheriaque_Cipemg_Code.FCPMAFS_CIPEMG_AFSSAPS)

        bModeDuplication = False
        'Tab_TA1 = True
        'Tab_TA2 = True
    End Sub

    ''' <summary>
    ''' Proçédure: Annulation d'un enregistrement
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub annuler()
        OnLoading = True
        MyBase.Annuler()
        'Onglet Entités
        Me.BindingContext(DsTheriaque_Cipemg_Code, FCPMCPH_CIPEMG_CLPH).CancelCurrentEdit()
        Me.DsTheriaque_Cipemg_Code.FCPMCPH_CIPEMG_CLPH.RejectChanges()

        Me.BindingContext(DsTheriaque_Cipemg_Code, FCPMCCH_CIPEMG_CLCH).CancelCurrentEdit()
        Me.DsTheriaque_Cipemg_Code.FCPMCCH_CIPEMG_CLCH.RejectChanges()

        Me.BindingContext(DsTheriaque_Cipemg_Code, FCPMSAC_CIPEMG_SUBAC).CancelCurrentEdit()
        Me.DsTheriaque_Cipemg_Code.FCPMSAC_CIPEMG_SUBAC.RejectChanges()

        Me.BindingContext(DsTheriaque_Cipemg_Code, FCPMSAU_CIPEMG_SUBAU).CancelCurrentEdit()
        Me.DsTheriaque_Cipemg_Code.FCPMSAU_CIPEMG_SUBAU.RejectChanges()

        Me.BindingContext(DsTheriaque_Cipemg_Code, FCPMPR_CIPEMG_PROD).CancelCurrentEdit()
        Me.DsTheriaque_Cipemg_Code.FCPMPR_CIPEMG_PROD.RejectChanges()

        Me.BindingContext(DsTheriaque_Cipemg_Code, FCPMCH_CIPEMGCH).CancelCurrentEdit()
        Me.DsTheriaque_Cipemg_Code.FCPMCH_CIPEMGCH.RejectChanges()

        Me.BindingContext(DsTheriaque_Cipemg_Code, FCPMSP_CIPEMG_SPE).CancelCurrentEdit()
        Me.DsTheriaque_Cipemg_Code.FCPMSP_CIPEMG_SPE.RejectChanges()

        'Onglet Nature
        Me.BindingContext(DsTheriaque_Cipemg_Code, FCPMTER_FCPM_TERRAIN).CancelCurrentEdit()
        Me.DsTheriaque_Cipemg_Code.FCPMTER_FCPM_TERRAIN.RejectChanges()

        Me.BindingContext(DsTheriaque_Cipemg_Code, TERCOM_TERRAIN_COMMENTAIRE).CancelCurrentEdit()
        Me.DsTheriaque_Cipemg_Code.TERCOM_TERRAIN_COMMENTAIRE.RejectChanges()

        Me.BindingContext(DsTheriaque_Cipemg_Code, NIVCOM_NIVEAU_COMMENTAIRE).CancelCurrentEdit()
        Me.DsTheriaque_Cipemg_Code.NIVCOM_NIVEAU_COMMENTAIRE.RejectChanges()

        Me.BindingContext(DsTheriaque_Cipemg_Code, AUTCOM_AUTRE_COMMENTAIRE).CancelCurrentEdit()
        Me.DsTheriaque_Cipemg_Code.AUTCOM_AUTRE_COMMENTAIRE.RejectChanges()

        Me.BindingContext(DsTheriaque_Cipemg_Code, FCPMTX_FICHECIPEMG_TEXTE).CancelCurrentEdit()
        Me.DsTheriaque_Cipemg_Code.FCPMTX_FICHECIPEMG_TEXTE.RejectChanges()

        'Onglet Références officielles
        Me.BindingContext(DsTheriaque_Cipemg_Code, FCPMAFS_CIPEMG_AFSSAPS).CancelCurrentEdit()
        Me.DsTheriaque_Cipemg_Code.FCPMAFS_CIPEMG_AFSSAPS.RejectChanges()

        'Master
        Me.BindingContext(Me.MasterDataSet, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_Cipemg_Code.FCPM_FICHECIPEMG.RejectChanges()


        Try
            cmbOrigine.Text = Me.BindingContext(Me.MasterDataSet, MasterTable).Current("FCPM_ORIGINE")
        Catch ex As Exception

        End Try

        'BindOrigine()
        If bModeDuplication Then EmptyDataTable()
        bModeDuplication = False
        OnLoading = False
    End Sub

    ''' <summary>
    ''' Proçédure: Vider tous les dataset
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Private Sub EmptyDataTable()
        'OnLoading = True
        'Master
        Me.DsTheriaque_Cipemg_Code.FCPM_FICHECIPEMG.Clear()
        'Onglet Entités
        Me.DsTheriaque_Cipemg_Code.FCPMCPH_CIPEMG_CLPH.Clear()
        Me.DsTheriaque_Cipemg_Code.FCPMCCH_CIPEMG_CLCH.Clear()
        Me.DsTheriaque_Cipemg_Code.FCPMSAC_CIPEMG_SUBAC.Clear()
        Me.DsTheriaque_Cipemg_Code.FCPMSAU_CIPEMG_SUBAU.Clear()
        Me.DsTheriaque_Cipemg_Code.FCPMPR_CIPEMG_PROD.Clear()
        Me.DsTheriaque_Cipemg_Code.FCPMCH_CIPEMGCH.Clear()
        Me.DsTheriaque_Cipemg_Code.FCPMSP_CIPEMG_SPE.Clear()

        'Onglet Nature
        Me.DsTheriaque_Cipemg_Code.TERCOM_TERRAIN_COMMENTAIRE.Clear()
        Me.DsTheriaque_Cipemg_Code.NIVCOM_NIVEAU_COMMENTAIRE.Clear()
        Me.DsTheriaque_Cipemg_Code.AUTCOM_AUTRE_COMMENTAIRE.Clear()
        Me.DsTheriaque_Cipemg_Code.FCPMTX_FICHECIPEMG_TEXTE.Clear()

        'Onglet Références officielles
        Me.DsTheriaque_Cipemg_Code.FCPMAFS_CIPEMG_AFSSAPS.Clear()

        'Onglet2
        Me.DsTheriaque_Cipemg_Code.FCPMTER_FCPM_TERRAIN.Clear()

        For intCount As Integer = 0 To GV22.RowCount - 1   ' Vider la grille
            GV22.DeleteRow(0)
        Next
        For intCount As Integer = 0 To GV24.RowCount - 1   ' Vider la grille
            GV24.DeleteRow(0)
        Next

    End Sub

    ''' <summary>
    ''' Proçédure: Duplication des données à partir d'une autre fiche
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub Dupliquer()

        If Not Tab_TA1 And CodE <> InvalideControl And CodE <> Nothing Then LoadTab_1()
        If Not Tab_TA2 And CodE <> InvalideControl And CodE <> Nothing Then LoadTab_2()

        'Sauvegarde des données à duplquer

        'Onglet entités
        Dim dt1 As New DataTable
        dt1 = DsTheriaque_Cipemg_Code.FCPMCPH_CIPEMG_CLPH.Copy

        Dim dt2 As New DataTable
        dt2 = DsTheriaque_Cipemg_Code.FCPMCCH_CIPEMG_CLCH.Copy

        Dim dt3 As New DataTable
        dt3 = DsTheriaque_Cipemg_Code.FCPMSAC_CIPEMG_SUBAC.Copy

        Dim dt4 As New DataTable
        dt4 = DsTheriaque_Cipemg_Code.FCPMSAU_CIPEMG_SUBAU.Copy

        Dim dt5 As New DataTable
        dt5 = DsTheriaque_Cipemg_Code.FCPMPR_CIPEMG_PROD.Copy

        Dim dt6 As New DataTable
        dt6 = DsTheriaque_Cipemg_Code.FCPMCH_CIPEMGCH.Copy

        Dim dt7 As New DataTable
        dt7 = DsTheriaque_Cipemg_Code.FCPMSP_CIPEMG_SPE.Copy

        'Onglet RefOff/Commentaires
        Dim dt21 As New DataTable
        dt21 = DsTheriaque_Cipemg_Code.FCPMTER_FCPM_TERRAIN.Copy


        Dim dt23 As New DataTable
        dt23 = DsTheriaque_Cipemg_Code.TERCOM_TERRAIN_COMMENTAIRE.Copy

        Dim dt25 As New DataTable
        dt25 = DsTheriaque_Cipemg_Code.NIVCOM_NIVEAU_COMMENTAIRE.Copy

        Dim dt26 As New DataTable
        dt26 = DsTheriaque_Cipemg_Code.AUTCOM_AUTRE_COMMENTAIRE.Copy

        Dim dt27 As New DataTable
        dt27 = DsTheriaque_Cipemg_Code.FCPMTX_FICHECIPEMG_TEXTE.Copy

        Dim dt31 As New DataTable
        dt31 = DsTheriaque_Cipemg_Code.FCPMAFS_CIPEMG_AFSSAPS.Copy

        Dim item As Object = cmbOrigine.SelectedItem


        'Vider les contrôles
        EmptyDataTable()

        'Construction de la nouvelle fiche avec les données de la fiche de base
        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        SetCode_MAx(MasterTable, txtCode)
        CodE = InvalideControl
        RG.Text = "C"

        'cmbOrigine.Text = item
        cmbOrigine.SelectedItem = item


        'BindOrigine()

        'Terrain
        'Pour les relations Master-Detail
        For iCount As Integer = 0 To dt21.Rows.Count - 1
            dt21.Rows(iCount)("FCPMTER_FCPM_CODE_FK_PK") = Me.txtCode.Text
        Next

        For iCount As Integer = 0 To dt23.Rows.Count - 1
            dt23.Rows(iCount)("TERCOM_FCPM_CODE_FK_PK") = Me.txtCode.Text
        Next

        For iCount As Integer = 0 To dt25.Rows.Count - 1
            dt25.Rows(iCount)("NIVCOM_FCPM_CODE_FK_PK") = Me.txtCode.Text
        Next

        For iCount As Integer = 0 To dt26.Rows.Count - 1
            dt26.Rows(iCount)("AUTCOM_FCPM_CODE_FK_PK") = Me.txtCode.Text
        Next

        For iCount As Integer = 0 To dt27.Rows.Count - 1
            dt27.Rows(iCount)("FCPMTX_FCPM_CODE_FK_PK") = Me.txtCode.Text
        Next

        Dim drTemp As DataRow
        For iCount As Integer = 0 To dt1.Rows.Count - 1
            drTemp = DsTheriaque_Cipemg_Code.Tables("FCPMCPH_CIPEMG_CLPH").NewRow()
            drTemp.ItemArray = dt1.Rows(iCount).ItemArray
            DsTheriaque_Cipemg_Code.Tables("FCPMCPH_CIPEMG_CLPH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt2.Rows.Count - 1
            drTemp = DsTheriaque_Cipemg_Code.Tables("FCPMCCH_CIPEMG_CLCH").NewRow()
            drTemp.ItemArray = dt2.Rows(iCount).ItemArray
            DsTheriaque_Cipemg_Code.Tables("FCPMCCH_CIPEMG_CLCH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt3.Rows.Count - 1
            drTemp = DsTheriaque_Cipemg_Code.Tables("FCPMSAC_CIPEMG_SUBAC").NewRow()
            drTemp.ItemArray = dt3.Rows(iCount).ItemArray
            DsTheriaque_Cipemg_Code.Tables("FCPMSAC_CIPEMG_SUBAC").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt4.Rows.Count - 1
            drTemp = DsTheriaque_Cipemg_Code.Tables("FCPMSAU_CIPEMG_SUBAU").NewRow()
            drTemp.ItemArray = dt4.Rows(iCount).ItemArray
            DsTheriaque_Cipemg_Code.Tables("FCPMSAU_CIPEMG_SUBAU").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt5.Rows.Count - 1
            drTemp = DsTheriaque_Cipemg_Code.Tables("FCPMPR_CIPEMG_PROD").NewRow()
            drTemp.ItemArray = dt5.Rows(iCount).ItemArray
            DsTheriaque_Cipemg_Code.Tables("FCPMPR_CIPEMG_PROD").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt6.Rows.Count - 1
            drTemp = DsTheriaque_Cipemg_Code.Tables("FCPMCH_CIPEMGCH").NewRow()
            drTemp.ItemArray = dt6.Rows(iCount).ItemArray
            DsTheriaque_Cipemg_Code.Tables("FCPMCH_CIPEMGCH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt7.Rows.Count - 1
            drTemp = DsTheriaque_Cipemg_Code.Tables("FCPMSP_CIPEMG_SPE").NewRow()
            drTemp.ItemArray = dt7.Rows(iCount).ItemArray
            DsTheriaque_Cipemg_Code.Tables("FCPMSP_CIPEMG_SPE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt21.Rows.Count - 1
            drTemp = DsTheriaque_Cipemg_Code.Tables("FCPMTER_FCPM_TERRAIN").NewRow()
            drTemp.ItemArray = dt21.Rows(iCount).ItemArray
            DsTheriaque_Cipemg_Code.Tables("FCPMTER_FCPM_TERRAIN").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt23.Rows.Count - 1
            drTemp = DsTheriaque_Cipemg_Code.Tables("TERCOM_TERRAIN_COMMENTAIRE").NewRow()
            drTemp.ItemArray = dt23.Rows(iCount).ItemArray
            DsTheriaque_Cipemg_Code.Tables("TERCOM_TERRAIN_COMMENTAIRE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt27.Rows.Count - 1
            drTemp = DsTheriaque_Cipemg_Code.Tables("FCPMTX_FICHECIPEMG_TEXTE").NewRow()
            drTemp.ItemArray = dt27.Rows(iCount).ItemArray
            DsTheriaque_Cipemg_Code.Tables("FCPMTX_FICHECIPEMG_TEXTE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt25.Rows.Count - 1
            drTemp = DsTheriaque_Cipemg_Code.Tables("NIVCOM_NIVEAU_COMMENTAIRE").NewRow()
            drTemp.ItemArray = dt25.Rows(iCount).ItemArray
            DsTheriaque_Cipemg_Code.Tables("NIVCOM_NIVEAU_COMMENTAIRE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt26.Rows.Count - 1
            drTemp = DsTheriaque_Cipemg_Code.Tables("AUTCOM_AUTRE_COMMENTAIRE").NewRow()
            drTemp.ItemArray = dt26.Rows(iCount).ItemArray
            DsTheriaque_Cipemg_Code.Tables("AUTCOM_AUTRE_COMMENTAIRE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt31.Rows.Count - 1
            drTemp = DsTheriaque_Cipemg_Code.Tables("FCPMAFS_CIPEMG_AFSSAPS").NewRow()
            drTemp.ItemArray = dt31.Rows(iCount).ItemArray
            DsTheriaque_Cipemg_Code.Tables("FCPMAFS_CIPEMG_AFSSAPS").Rows.Add(drTemp)
        Next

        ModifierCode()
        bModeDuplication = True
        MyBase.Dupliquer()
        XtraTabControl1.SelectedTabPageIndex = 0
    End Sub

    ''' <summary>
    ''' Proçédure: Modifier code Master de la fiche
    ''' </summary>
    Private Sub ModifierCode()
        'GV1
        For iCount As Integer = 0 To GV1.RowCount - 1
            GV1.SetRowCellValue(iCount, colFCPMCPH_FCPM_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV2
        For iCount As Integer = 0 To GV2.RowCount - 1
            GV2.SetRowCellValue(iCount, colFCPMCCH_FCPM_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV3
        For iCount As Integer = 0 To GV3.RowCount - 1
            GV3.SetRowCellValue(iCount, colFCPMSAC_FCPM_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV4
        For iCount As Integer = 0 To GV4.RowCount - 1
            GV4.SetRowCellValue(iCount, colFCPMSAU_FCPM_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV5
        For iCount As Integer = 0 To GV5.RowCount - 1
            GV5.SetRowCellValue(iCount, colFCPMPR_FCPM_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV6
        For iCount As Integer = 0 To GV6.RowCount - 1
            GV6.SetRowCellValue(iCount, colFCPMCH_FCPM_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV7
        For iCount As Integer = 0 To GV7.RowCount - 1
            GV7.SetRowCellValue(iCount, colFCPMSP_FCPM_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV21
        For iCount As Integer = 0 To GV21.RowCount - 1
            GV21.SetRowCellValue(iCount, colFCPMTER_FCPM_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV23
        For iCount As Integer = 0 To GV23.RowCount - 1
            GV23.SetRowCellValue(iCount, colTERCOM_FCPM_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV25
        For iCount As Integer = 0 To GV25.RowCount - 1
            GV25.SetRowCellValue(iCount, colNIVCOM_FCPM_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV26
        For iCount As Integer = 0 To GV26.RowCount - 1
            GV26.SetRowCellValue(iCount, colAUTCOM_FCPM_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV27
        For iCount As Integer = 0 To GV27.RowCount - 1
            GV27.SetRowCellValue(iCount, colFCPMTX_FCPM_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV31
        For iCount As Integer = 0 To GV31.RowCount - 1
            GV31.SetRowCellValue(iCount, colFCPMAFS_FCPM_CODE_FK_PK, Me.txtCode.Text)
        Next
    End Sub


    ''' <summary>
    ''' Fonction: Validation des contrôles
    ''' </summary>
    ''' <param name="Ctrl">un contrôle</param>
    ''' <param name="AllCtrl">tous les contôles</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Protected Friend Overrides Function ValideControl(Optional ByRef Ctrl As Control = Nothing, Optional ByVal AllCtrl As Boolean = True) As Boolean
        Dim strSSQL As String = ""
        MyBase.ValideControl(Ctrl)
        For iCount As Integer = 0 To GV31.RowCount - 1
            If Not FieldExistRO(GV7, colFCPMSP_SP_CODE_FK_PK, GV31.GetRowCellValue(iCount, colFCPMAFS_SP_CODE_FK_PK)) Then
                GV31.FocusedRowHandle = iCount
                GV31.SetColumnError(colFCPMAFS_SP_CODE_FK_PK, "La spécialité doit être présente dans la fiche.")
                XtraTabControl1.SelectedTabPageIndex = 2
                Exit Function
            Else
                GV31.SetColumnError(colFCPMAFS_SP_CODE_FK_PK, "")
            End If
        Next

        Return True
    End Function
#End Region

#Region " Init Data  "
    ''' <summary>
    ''' Proçédure: Alimentation des sources des gridcontrols
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitDataSource()
        'Onglet Entités
        GC1.DataSource = DsTheriaque_Cipemg_Code
        GC1.DataMember = FCPMCPH_CIPEMG_CLPH

        GC2.DataSource = DsTheriaque_Cipemg_Code
        GC2.DataMember = FCPMCCH_CIPEMG_CLCH

        GC3.DataSource = DsTheriaque_Cipemg_Code
        GC3.DataMember = FCPMSAC_CIPEMG_SUBAC

        GC4.DataSource = DsTheriaque_Cipemg_Code
        GC4.DataMember = FCPMSAU_CIPEMG_SUBAU

        GC5.DataSource = DsTheriaque_Cipemg_Code
        GC5.DataMember = FCPMPR_CIPEMG_PROD

        GC6.DataSource = DsTheriaque_Cipemg_Code
        GC6.DataMember = FCPMCH_CIPEMGCH

        GC7.DataSource = DsTheriaque_Cipemg_Code
        GC7.DataMember = FCPMSP_CIPEMG_SPE

        'Onglet Nature
        GC21.DataSource = DsTheriaque_Cipemg_Code
        GC21.DataMember = FCPMTER_FCPM_TERRAIN

        GC23.DataSource = DsTheriaque_Cipemg_Code
        GC23.DataMember = "FCPMTER_FCPM_TERRAIN.FK_TERCOM_FCPMTER"

        GC25.DataSource = DsTheriaque_Cipemg_Code
        GC25.DataMember = "FCPMTER_FCPM_TERRAIN.FK_NIVCOM_FCPMTER"


        GC26.DataSource = DsTheriaque_Cipemg_Code
        GC26.DataMember = "FCPMTER_FCPM_TERRAIN.FK_AUTCOM_FCPMTER"

        GC27.DataSource = DsTheriaque_Cipemg_Code
        GC27.DataMember = "FCPMTER_FCPM_TERRAIN.FK_FCPMTX_FCPMTER"

        'Onglet Références officielles
        GC31.DataSource = DsTheriaque_Cipemg_Code
        GC31.DataMember = FCPMAFS_CIPEMG_AFSSAPS

    End Sub

    ''' <summary>
    ''' Proçédure: Initialisation des données
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub InitData()
        Declinaison_Global = True
        MyBase.InitData()
        OnLoading = True
        MasterDataSet = Me.DsTheriaque_Cipemg_Code
        MasterTable = FCPM_FICHECIPEMG
        CodE = InvalideControl

        'Déclinaison classe CPH
        Dim List1 As New System.Collections.Generic.List(Of StructGVTable)
        List1.Add(New StructGVTable("GC1", eDeclinaison.CPH, colFCPMCPH_CPH_CODE_FK_PK))
        List1.Add(New StructGVTable("GC2", eDeclinaison.CCH, colFCPMCCH_CCH_CODE_FK_PK))
        List1.Add(New StructGVTable("GC3", eDeclinaison.SAC, colFCPMSAC_SAC_CODE_FK_PK))
        List1.Add(New StructGVTable("GC7", eDeclinaison.SP, colFCPMSP_SP_CODE_FK_PK))
        Dim DecCPH As New ClsDeclinaison(eDeclinaison.CPH, List1)
        InitLkup(Me.rp_FCPMCPH, FCPMCPH_CIPEMG_CLPH, strSSQL_CPH_CLASSEPHARMTHER_NIVEAU, True, , , , , , DecCPH)

        'Déclinaison classe CCH
        Dim List2 As New System.Collections.Generic.List(Of StructGVTable)
        List2.Add(New StructGVTable("GC1", eDeclinaison.CPH, colFCPMCPH_CPH_CODE_FK_PK))
        List2.Add(New StructGVTable("GC2", eDeclinaison.CCH, colFCPMCCH_CCH_CODE_FK_PK))
        List2.Add(New StructGVTable("GC3", eDeclinaison.SAC, colFCPMSAC_SAC_CODE_FK_PK))
        List2.Add(New StructGVTable("GC7", eDeclinaison.SP, colFCPMSP_SP_CODE_FK_PK))
        Dim DecCCH As New ClsDeclinaison(eDeclinaison.CCH, List2)
        InitLkup(Me.rp_FCPMCCH, FCPMCCH_CIPEMG_CLCH, strSSQL_CCH_CLASSECHIMIQUE_NIVEAU, True, , , , , , DecCCH)

        'Déclinaison SUBAC
        Dim List3 As New System.Collections.Generic.List(Of StructGVTable)
        List3.Add(New StructGVTable("GC3", eDeclinaison.SAC, colFCPMSAC_SAC_CODE_FK_PK))
        List3.Add(New StructGVTable("GC4", eDeclinaison.SAU, colFCPMSAU_SAU_CODE_FK_PK))
        List3.Add(New StructGVTable("GC7", eDeclinaison.SP, colFCPMSP_SP_CODE_FK_PK))
        Dim DecSUBAC As New ClsDeclinaison(eDeclinaison.SAC, List3)
        InitLkup(Me.rp_FCPMSAC, FCPMSAC_CIPEMG_SUBAC, strSSQL_SAC_SUBACTIVE, True, , , , , , DecSUBAC)

        'Déclinaison SAU
        Dim List4 As New System.Collections.Generic.List(Of StructGVTable)
        List4.Add(New StructGVTable("GC4", eDeclinaison.SAU, colFCPMSAU_SAU_CODE_FK_PK))
        List4.Add(New StructGVTable("GC7", eDeclinaison.SP, colFCPMSP_SP_CODE_FK_PK))
        Dim DecSAU As New ClsDeclinaison(eDeclinaison.SAU, List4)
        InitLkup(Me.rp_FCPMSAU, FCPMSAU_CIPEMG_SUBAU, strSSQL_SAU_SUBAUXILIAIRE, True, , , , , , DecSAU)

        'Déclinaison PRODUIT
        Dim List5 As New System.Collections.Generic.List(Of StructGVTable)
        List5.Add(New StructGVTable("GC5", eDeclinaison.PR, colFCPMPR_PR_CODE_FK_PK))
        List5.Add(New StructGVTable("GC7", eDeclinaison.SP, colFCPMSP_SP_CODE_FK_PK))
        Dim DecPR As New ClsDeclinaison(eDeclinaison.PR, List5)
        InitLkup(Me.rp_FCPMPR, FCPMPR_CIPEMG_PROD, strSSQL_PR_PRODUIT, True, , , , , , DecPR)

        InitLkup(Me.rp_FCPMSP, FCPMSP_CIPEMG_SPE, strSSQL_SP_SPECIALITE, True)
        InitLkup(Me.rp_FCPMCH, FCPMCH_CIPEMGCH, strSSQL_CH_CHOIX, True)

        Dim query As String = " select distinct 'A1' as code, 'En Cours' as libelle from  theriaque.CDF_CODIF "
        query &= " union select distinct 'A2' as code, 'En cours et ATCD perso' as libelle from  theriaque.CDF_CODIF"
        query &= " union select distinct 'A3' as code, 'ATCD Perso' as libelle from  theriaque.CDF_CODIF"
        query &= " union select distinct 'A4' as code, 'ATCD Familial' as libelle from  theriaque.CDF_CODIF"
        query &= " union select distinct 'A5' as code, 'En cours Tierce Personne' as libelle from  theriaque.CDF_CODIF"

        InitLkup(lkupATCD, CDF_CODIF, query, True)

        InitDataSource()
        FirstFocus = txtCode
        RG.SelectedIndex = 0
        XTabPage_Terrain.Text = "Contre-indication"
        'Filtre
        colFCPMTER_NATURE_CIPEMG_PK.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("FCPMTER_NATURE_CIPEMG_PK = " & cn.SQLText(RG.Text))
        colNIVCOM_NATURE_CIPEMG_FK_PK.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("NIVCOM_NATURE_CIPEMG_FK_PK = " & cn.SQLText(RG.Text))
        colTERCOM_NATURE_CIPEMG_FK_PK.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("TERCOM_NATURE_CIPEMG_FK_PK = " & cn.SQLText(RG.Text))
        colAUTCOM_NATURE_CIPEMG_FK_PK.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("AUTCOM_NATURE_CIPEMG_FK_PK = " & cn.SQLText(RG.Text))
        colFCPMTX_NATURECIPEMG_FK_PK.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("FCPMTX_NATURECIPEMG_FK_PK = " & cn.SQLText(RG.Text))


        If _Code <> Nothing Then
            Load_On(Me)
            Open_Fiche(_Code)
            ModeFiche = eMode.Consultation
            UpdateStateBouton()
            Initcomponent()
            Load_Off(Me)
        End If
        OnLoading = False
    End Sub

    ''' <summary>
    ''' Proçédure: Ouverture d'une fiche de l'extèrieur
    ''' </summary>
    ''' <param name="CodE1">Code de la fiche</param>
    ''' <remarks></remarks>
    Private Sub Open_Fiche(ByVal CodE1 As Integer)
        OnLoading = True
        CodE = _Code
        XtraTabControl1.SelectedTabPageIndex = 0
        EmptyDataTable()
        Me.FcpM_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPM_FICHECIPEMG, CodE1)

        cmbOrigine.Text = Me.BindingContext(Me.MasterDataSet, MasterTable).Current("FCPM_ORIGINE")


        'Onglet Entités
        Me.FcpmcpH_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMCPH_CIPEMG_CLPH, CodE1)
        Me.FcpmccH_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMCCH_CIPEMG_CLCH, CodE1)
        Me.FcpmsaC_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMSAC_CIPEMG_SUBAC, CodE1)
        Me.FcpmsaU_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMSAU_CIPEMG_SUBAU, CodE1)
        Me.FcpmpR_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMPR_CIPEMG_PROD, CodE1)
        Me.FcpmcH_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMCH_CIPEMGCH, CodE1)
        Me.FcpmsP_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMSP_CIPEMG_SPE, CodE1)
        Tab_TA1 = False
        Tab_TA2 = False
        OnLoading = False
    End Sub
#End Region

#Region " Chargement par onglet "
    ''' <summary>
    ''' Proçédure: Chargement du premier onglet
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadTab_1()
        Load_On(Me)
        OnLoading = True
        If Not Tab_lkup1 Then
            InitLkup(Me.rp_FCPMTER, FCPMTER_FCPM_TERRAIN, strSSQL_CDF_CODIF_NIVEAU("CS"), True)
            InitLkup(Me.rp_TERCOM, TERCOM_TERRAIN_COMMENTAIRE, strSSQL_CDF_CODIF("CC", " and substring(CDF_CODE_PK, 1, 1) IN('A', 'B', 'D', 'G', 'J', 'H', 'E', 'L', 'T')"), True)
            InitLkup(Me.rp_NIVCOM, NIVCOM_NIVEAU_COMMENTAIRE, strSSQL_CDF_CODIF("CC", " and substring(CDF_CODE_PK, 1, 1) =  'X'"), True)
            InitLkup(Me.rp_AUTCOM, AUTCOM_AUTRE_COMMENTAIRE, strSSQL_CDF_CODIF("CC", " and substring(CDF_CODE_PK, 1, 1) NOT IN('A', 'D', 'H', 'E', 'L', 'T', 'X', 'B', 'J', 'G')"), True)

        End If
        Tab_lkup1 = True
        If CodE <> InvalideControl And CodE <> Nothing Then
            Me.FcpmteR_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMTER_FCPM_TERRAIN, CodE)
            Me.TercoM_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.TERCOM_TERRAIN_COMMENTAIRE, CodE)
            Me.NivcoM_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.NIVCOM_NIVEAU_COMMENTAIRE, CodE)
            Me.AutcoM_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.AUTCOM_AUTRE_COMMENTAIRE, CodE)
            Me.FcpmtX_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMTX_FICHECIPEMG_TEXTE, CodE)
            Tab_TA1 = True
        End If

        OnLoading = False
        Load_Off(Me)
    End Sub

    ''' <summary>
    ''' Proçédure: Chargement du deuxiéme onglet
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadTab_2()
        'Onglet Réferences officielles
        Load_On(Me)
        OnLoading = True
        If CodE <> InvalideControl And CodE <> Nothing Then
            Dim strSSQL_SP_REF As String
            strSSQL_SP_REF = " SELECT SP_CODE_SQ_PK as code, SP_NOM as libelle FROM THERIAQUE.FCPMSP_CIPEMG_SPE, THERIAQUE.SP_SPECIALITE"
            strSSQL_SP_REF &= " WHERE FCPMSP_FCPM_CODE_FK_PK = " & CodE
            strSSQL_SP_REF &= " AND SP_CODE_SQ_PK = FCPMSP_SP_CODE_FK_PK"
            InitLkup(Me.rp_FCPMAFS_SP, FCPMAFS_CIPEMG_AFSSAPS, strSSQL_SP_REF, True)
            For iCount As Integer = 0 To GV31.RowCount
                If GV31.GetRowCellDisplayText(iCount, "FCPMAFS_SP_CODE_FK_PK") = "" And GV31.GetRowCellDisplayText(iCount, "FCPMAFS_FCPM_CODE_FK_PK") <> "" Then
                    GV31.DeleteRow(iCount)
                    iCount = iCount - 1
                End If
            Next
        End If
        If Not Tab_lkup2 Then
            InitLkup(Me.rp_FCPMAFS, FCPMAFS_CIPEMG_AFSSAPS, strSSQL_CDF_CODIF("25"), True)
            Tab_lkup2 = True
        End If
        If Not Tab_TA2 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.FcpmafS_TA.FillByCode(Me.DsTheriaque_Cipemg_Code.FCPMAFS_CIPEMG_AFSSAPS, CodE)
            Tab_TA2 = True
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub

    ''' <summary>
    ''' Evénement: Sélection d'onglet
    ''' </summary>
    ''' <param name="sender">XtraTabControl1</param>
    ''' <param name="e">SelectedPageChanged</param>
    ''' <remarks></remarks>
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPageIndex = 1 Then
            LoadTab_1()
            Exit Sub
        End If
        If XtraTabControl1.SelectedTabPageIndex = 2 Then
            LoadTab_2()
            Exit Sub
        End If
    End Sub
#End Region

#Region " New Row "
    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV1</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV1_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV1.InitNewRow
        If OnLoading Then Exit Sub
        GV1.SetFocusedRowCellValue(colFCPMCPH_FCPM_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV2</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        If OnLoading Then Exit Sub
        GV2.SetFocusedRowCellValue(colFCPMCCH_FCPM_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV3</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV3_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV3.InitNewRow
        If OnLoading Then Exit Sub
        GV3.SetFocusedRowCellValue(colFCPMSAC_FCPM_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV4</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV4_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV4.InitNewRow
        If OnLoading Then Exit Sub
        GV4.SetFocusedRowCellValue(colFCPMSAU_FCPM_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV5</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV5_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV5.InitNewRow
        If OnLoading Then Exit Sub
        GV5.SetFocusedRowCellValue(colFCPMPR_FCPM_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV6</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV6_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV6.InitNewRow
        If OnLoading Then Exit Sub
        GV6.SetFocusedRowCellValue(colFCPMCH_FCPM_CODE_FK_PK, txtCode.Text)
        GV6.SetFocusedRowCellValue(colFCPMCH_NUMORD, Code_MAx(GV6, colFCPMCH_NUMORD))
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV7</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV7_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV7.InitNewRow
        If OnLoading Then Exit Sub
        GV7.SetFocusedRowCellValue(colFCPMSP_FCPM_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV21</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV21_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV21.InitNewRow
        If OnLoading Then Exit Sub
        If txtCode.Text <> "" Then
            GV21.SetFocusedRowCellValue(colFCPMTER_FCPM_CODE_FK_PK, txtCode.Text)
            GV21.SetFocusedRowCellValue(colFCPMTER_NUMORD, Code_MAx(GV21, colFCPMTER_NUMORD))
            GV21.SetFocusedRowCellValue(colFCPMTER_NUMSEQ_PK, Code_MAx(GV21, colFCPMTER_NUMSEQ_PK))
            GV21.SetFocusedRowCellValue(colFCPMTER_NATURE_CIPEMG_PK, RG.Text)
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV31</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV31_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV31.InitNewRow
        GV31.SetFocusedRowCellValue(colFCPMAFS_FCPM_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV23</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV23_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV23.InitNewRow
        If OnLoading Then Exit Sub
        GV23.SetFocusedRowCellValue(colTERCOM_NUMSEQ, Code_MAx(GV23, colTERCOM_NUMSEQ))
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV25</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV25_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV25.InitNewRow
        If OnLoading Then Exit Sub
        GV25.SetFocusedRowCellValue(colNIVCOM_NUMSEQ, Code_MAx(GV25, colNIVCOM_NUMSEQ))
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV26</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV26_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV26.InitNewRow
        If OnLoading Then Exit Sub
        GV26.SetFocusedRowCellValue(colAUTCOM_NUMSEQ, Code_MAx(GV26, colAUTCOM_NUMSEQ))
    End Sub
#End Region

#Region " Panel "

    ''' <summary>
    ''' Evénement: Redimensionnement du panel
    ''' </summary>
    ''' <param name="sender">Panel4</param>
    ''' <param name="e">Resize</param>
    ''' <remarks></remarks>
    Private Sub Panel4_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel4.Resize
        GC1.Width = Panel4.Width / 2
        GC2.Width = Panel4.Width / 2
    End Sub

    ''' <summary>
    ''' Evénement: Redimensionnement du panel
    ''' </summary>
    ''' <param name="sender">Panel6</param>
    ''' <param name="e">Resize</param>
    ''' <remarks></remarks>
    Private Sub Panel6_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel6.Resize
        GC3.Width = Panel6.Width / 2
        GC4.Width = Panel6.Width / 2
    End Sub

    ''' <summary>
    ''' Evénement: Redimensionnement du panel
    ''' </summary>
    ''' <param name="sender">Panel7</param>
    ''' <param name="e">Resize</param>
    ''' <remarks></remarks>
    Private Sub Panel7_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel7.Resize
        GC5.Width = Panel7.Width / 2
        GC6.Width = Panel7.Width / 2
    End Sub

    ''' <summary>
    ''' Evénement: Redimensionnement du panel
    ''' </summary>
    ''' <param name="sender">Panel9</param>
    ''' <param name="e">Resize</param>
    ''' <remarks></remarks>
    Private Sub Panel9_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel9.Resize
        GC22.Width = Panel9.Width / 2
        GC23.Width = Panel9.Width / 2
    End Sub

    ''' <summary>
    ''' Evénement: Redimensionnement du panel
    ''' </summary>
    ''' <param name="sender">Panel10</param>
    ''' <param name="e">Resize</param>
    ''' <remarks></remarks>
    Private Sub Panel10_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel10.Resize
        GC24.Width = Panel10.Width / 2
        Panel18.Width = Panel10.Width / 2
    End Sub

    ''' <summary>
    ''' Evénement: Redimensionnement d'onglet
    ''' </summary>
    ''' <param name="sender">XtraTabControl1</param>
    ''' <param name="e">Resize</param>
    ''' <remarks></remarks>
    Private Sub XtraTabControl1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraTabControl1.Resize
        Panel4.Height = XtraTabControl1.Height / 4
        Panel6.Height = XtraTabControl1.Height / 4
        Panel7.Height = XtraTabControl1.Height / 4
        Panel8.Height = XtraTabControl1.Height / 4

        Panel2.Height = XtraTabControl1.Height / 5
        Panel9.Height = XtraTabControl1.Height / 5
        Panel10.Height = XtraTabControl1.Height / 5
        Panel11.Height = XtraTabControl1.Height / 5
        Panel27.Height = XtraTabControl1.Height / 5
    End Sub
#End Region

#Region " Autres événements "

    ''' <summary>
    ''' Sélection d'une case du radio group 
    ''' </summary>
    ''' <param name="sender">RG</param>
    ''' <param name="e">SelectedIndexChanged</param>
    ''' <remarks></remarks>
    Private Sub RG_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RG.SelectedIndexChanged
        If RG.Text = "C" Then
            XTabPage_Terrain.Text = "Contre-indication"
        ElseIf RG.Text = "P" Then
            XTabPage_Terrain.Text = "Précaution d'emploi et mise en garde"
        ElseIf RG.Text = "N" Then
            XTabPage_Terrain.Text = "Non contre-indication"
        ElseIf RG.Text = "I" Then
            XTabPage_Terrain.Text = "Non indication"
        End If
        XTabPage_Terrain.PageVisible = True
        'Filtre
        colFCPMTER_NATURE_CIPEMG_PK.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("FCPMTER_NATURE_CIPEMG_PK = " & cn.SQLText(RG.Text))
        colNIVCOM_NATURE_CIPEMG_FK_PK.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("NIVCOM_NATURE_CIPEMG_FK_PK = " & cn.SQLText(RG.Text))
        colTERCOM_NATURE_CIPEMG_FK_PK.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("TERCOM_NATURE_CIPEMG_FK_PK = " & cn.SQLText(RG.Text))
        colAUTCOM_NATURE_CIPEMG_FK_PK.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("AUTCOM_NATURE_CIPEMG_FK_PK = " & cn.SQLText(RG.Text))
        colFCPMTX_NATURECIPEMG_FK_PK.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("FCPMTX_NATURECIPEMG_FK_PK = " & cn.SQLText(RG.Text))
    End Sub

    ''' <summary>
    ''' Changement du focus
    ''' </summary>
    ''' <param name="sender">GV23</param>
    ''' <param name="e">FocusedRowChanged</param>
    ''' <remarks></remarks>
    Private Sub GV23_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV23.FocusedRowChanged
        If OnLoading Then Exit Sub
        If GV23.GetFocusedRowCellValue(colTERCOM_CDF_TER_CODE_FK_PK) IsNot DBNull.Value Then
            Load_On(Me)
            OnLoading = True
            Dim strSSQL_CDF_CIM As String
            strSSQL_CDF_CIM = " SELECT DISTINCT CIM_CODE_PK, CIM_LIBELLE_COURT   "
            strSSQL_CDF_CIM &= " FROM THERIAQUE.CIMCDF_CIM10_CODIF, THERIAQUE.CIM10 "
            strSSQL_CDF_CIM &= " WHERE CIMCDF_CDF_NUMERO_FK_PK = 'CC' "
            strSSQL_CDF_CIM &= " AND CIMCDF_CDF_CODE_FK_PK = " & cn.SQLText(GV23.GetFocusedRowCellValue(colTERCOM_CDF_COM_CODE_FK_PK))
            strSSQL_CDF_CIM &= " AND CIMCDF_CIM_CODE_FK_PK = CIM_CODE_PK"
            GC24.DataSource = cn.MySelect(strSSQL_CDF_CIM)
            Load_Off(Me)
            OnLoading = False
        End If

    End Sub

    ''' <summary>
    ''' Changement du focus
    ''' </summary>
    ''' <param name="sender">GV21</param>
    ''' <param name="e">FocusedRowChanged</param>
    ''' <remarks></remarks>
    Private Sub GV21_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV21.FocusedRowChanged
        If OnLoading Then Exit Sub
        If GV21.GetFocusedRowCellValue(colFCPMTER_CDF_TER_CODE_FK_PK) IsNot DBNull.Value Then
            Load_On(Me)
            OnLoading = True
            Dim strSSQL_CDF_CIM As String
            strSSQL_CDF_CIM = " SELECT DISTINCT CIM_CODE_PK, CIM_LIBELLE_COURT   "
            strSSQL_CDF_CIM &= " FROM THERIAQUE.CIMCDF_CIM10_CODIF, THERIAQUE.CIM10 "
            strSSQL_CDF_CIM &= " WHERE CIMCDF_CDF_NUMERO_FK_PK = 'CS' "
            strSSQL_CDF_CIM &= " AND CIMCDF_CDF_CODE_FK_PK = " & cn.SQLText(GV21.GetFocusedRowCellValue(colFCPMTER_CDF_TER_CODE_FK_PK))
            strSSQL_CDF_CIM &= " AND CIMCDF_CIM_CODE_FK_PK = CIM_CODE_PK"
            GC22.DataSource = cn.MySelect(strSSQL_CDF_CIM)

            Load_Off(Me)
            OnLoading = False
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Changement du nombre de lignes
    ''' </summary>
    ''' <param name="sender">GV</param>
    ''' <param name="e">RowCountChanged</param>
    ''' <remarks></remarks>
    Private Sub GV_RowCountChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV27.RowCountChanged
        If sender.RowCount >= 1 Then
            sender.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
            sender.GridControl.EmbeddedNavigator.Buttons.Append.Enabled = False
        Else
            sender.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            sender.GridControl.EmbeddedNavigator.Buttons.Append.Enabled = False
        End If
    End Sub

#End Region

#Region " Validating Editor "

    ''' <summary>
    ''' Evénement: Validation de l'édition
    ''' </summary>
    ''' <param name="sender">GV21</param>
    ''' <param name="e">ValidatingEditor</param>
    ''' <remarks></remarks>
    Private Sub GV21_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV21.ValidatingEditor
        If GV21.FocusedColumn Is colFCPMTER_NUMORD Then
            If FieldExist(GV21, colFCPMTER_NUMORD, e.Value) Then
                e.ErrorText = "Le numéro doit être unique."
                e.Value = Nothing
                e.Valid = False
            End If
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Validation de l'édition
    ''' </summary>
    ''' <param name="sender">GV23</param>
    ''' <param name="e">ValidatingEditor</param>
    ''' <remarks></remarks>
    Private Sub GV23_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV23.ValidatingEditor
        If GV23.FocusedColumn Is colTERCOM_NUMSEQ Then
            If FieldExist(GV23, colTERCOM_NUMSEQ, e.Value) Then
                e.ErrorText = "Le numéro doit être unique."
                e.Value = Nothing
                e.Valid = False
            End If
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Validation de l'édition
    ''' </summary>
    ''' <param name="sender">GV25</param>
    ''' <param name="e">ValidatingEditor</param>
    ''' <remarks></remarks>
    Private Sub GV25_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV25.ValidatingEditor
        If GV25.FocusedColumn Is colNIVCOM_NUMSEQ Then
            If FieldExist(GV25, colNIVCOM_NUMSEQ, e.Value) Then
                e.ErrorText = "Le numéro doit être unique."
                e.Value = Nothing
                e.Valid = False
            End If
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Validation de l'édition
    ''' </summary>
    ''' <param name="sender">GV26</param>
    ''' <param name="e">ValidatingEditor</param>
    ''' <remarks></remarks>
    Private Sub GV26_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV26.ValidatingEditor
        If GV26.FocusedColumn Is colAUTCOM_NUMSEQ Then
            If FieldExist(GV26, colAUTCOM_NUMSEQ, e.Value) Then
                e.ErrorText = "Le numéro doit être unique."
                e.Value = Nothing
                e.Valid = False
            End If
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Validation de l'édition
    ''' </summary>
    ''' <param name="sender">GV6</param>
    ''' <param name="e">ValidatingEditor</param>
    ''' <remarks></remarks>
    Private Sub GV6_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV6.ValidatingEditor
        If GV6.FocusedColumn Is colFCPMCH_NUMORD Then
            If FieldExist(GV6, colFCPMCH_NUMORD, e.Value) Then
                e.ErrorText = "Le numéro doit être unique."
                e.Value = Nothing
                e.Valid = False
            End If
        End If
    End Sub

#End Region


    Private Sub GV27_CalcRowHeight(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs) Handles GV27.CalcRowHeight
        e.RowHeight = sender.GridControl.Height
    End Sub

    Private Sub GV27_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV27.InitNewRow
        If OnLoading Then Exit Sub
        Me.GV27.SetFocusedRowCellValue(Me.colFCPMTX_FCPM_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub ComboBoxEdit2_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If (cmbOrigine.SelectedText.Equals("R")) Then
        '    cmbOrigine.SelectedText = "RCP(R)"
        'Else
        '    cmbOrigine.SelectedText = "Autre(A)"
        'End If
    End Sub

    Private Sub cmbOrigine_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOrigine.TextChanged

        BindOrigine()
        btValider.Enabled = True
        btAnnuler.Enabled = True
        btAjouter.Enabled = False
        btChercher.Enabled = False
        btFermer.Enabled = False
        btSupprimer.Enabled = False
        btDupliquer.Enabled = False
        btn_RechMulti.Enabled = False
        btAdvancedSearch.Enabled = False

    End Sub

    Private Sub cmbOrigine_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOrigine.Validated


    End Sub

    Private Sub BindOrigine()

        If (Not String.IsNullOrEmpty(cmbOrigine.SelectedItem)) Then
            'If (Me.BindingContext(Me.MasterDataSet, MasterTable).Current("FCPM_ORIGINE").Equals("R")) Then
            If (cmbOrigine.SelectedItem.Equals("R")) Then
                cmbOrigine.SelectedItem = "RCP"
            End If
            If (cmbOrigine.SelectedItem.Equals("A")) Then
                cmbOrigine.SelectedItem = "Autre"
            End If
        End If

    End Sub

    Private Sub Frm_Cipemg_Code_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
