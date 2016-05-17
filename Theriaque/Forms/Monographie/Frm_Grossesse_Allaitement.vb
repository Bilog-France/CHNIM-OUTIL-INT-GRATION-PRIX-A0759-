''' <summary>
''' Created By [BFE]
''' </summary>
''' <remarks> Monographie - Grossesse - Allaitement 
''' </remarks>
Public Class Frm_Grossesse_Allaitement

#Region " Déclaration des variables privées "
    Private CodE As String
    Public _Code As Integer = Nothing ' charger la fiche depuis l'extérieur
    Private Tab_lkup1 As Boolean = False
    Private Tab_TA1 As Boolean = False
    Private Tab_lkup2 As Boolean = False
    Private Tab_TA2 As Boolean = False
    Private Tab_lkup3 As Boolean = False
    Private Tab_TA3 As Boolean = False
    Private RefOff As String = ""
    Private bModeDuplication As Boolean = False
#End Region

#Region " Edit Data  "

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_FGA_FICHEGRAL
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            XtraTabControl1.SelectedTabPageIndex = 0
            OnLoading = True
            EmptyDataTable()
            Me.FgA_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGA_FICHEGRAL, f._Code)

            'Onglet Entités
            Me.FgacpH_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGACPH_GRALCLPH, f._Code)
            Me.FgaccH_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGACCH_GRALCLCH, f._Code)
            Me.FgasaU_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGASAU_GRALSUBAU, f._Code)
            Me.FgasaC_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGASAC_GRALSUBAC, f._Code)
            Me.FgapR_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGAPR_GRALPROD, f._Code)
            Me.FgasP_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGASP_GRALSPE, f._Code)

            Tab_TA1 = False
            Tab_TA2 = False
            Tab_TA3 = False

            bModeDuplication = False
            OnLoading = False
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Function ChercherAvance() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_FGA_FICHEGRAL_SP()
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            XtraTabControl1.SelectedTabPageIndex = 0
            OnLoading = True
            EmptyDataTable()
            Me.FgA_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGA_FICHEGRAL, f._Code)

            'Onglet Entités
            Me.FgacpH_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGACPH_GRALCLPH, f._Code)
            Me.FgaccH_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGACCH_GRALCLCH, f._Code)
            Me.FgasaU_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGASAU_GRALSUBAU, f._Code)
            Me.FgasaC_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGASAC_GRALSUBAC, f._Code)
            Me.FgapR_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGAPR_GRALPROD, f._Code)
            Me.FgasP_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGASP_GRALSPE, f._Code)

            Tab_TA1 = False
            Tab_TA2 = False
            Tab_TA3 = False

            bModeDuplication = False
            OnLoading = False
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
        Dim sCodeGrdeCIRFAVO As String = ""
        Dim sCodeRISANIMAL As String = ""
        Dim sCodeFEMENCE As String = ""
        Dim sCodeNOUVNE As String = ""
        Dim sCodeGrrecREC As String = ""
        Dim sCodePERCONC As String = ""
        Dim sCodePERCRI As String = ""
        Dim sCodeOBSESPEC As String = ""
        Dim sCodeGrdcCIRFAVO As String = ""
        Dim sCodeRISHOMME As String = ""
        Dim sCodeFEMCONDTENIR As String = ""
        Dim sCodeFemapREC As String = ""
        Dim sCodeAllOBSER As String = ""
        Dim sCodeAllocnCIRFAVO As String = ""
        Dim sCodeAllREC As String = ""
        Dim sCodeALLCONDTENIR As String = ""

        Dim f As New Frm_GrossAllaitementMultiCriteres
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
            If f._bGrdeCIRFAVO Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("GC")
                fDICO.Text = "G - Données expérimentales - Circonstances favorisantes"
                fDICO.ShowDialog()
                sCodeGrdeCIRFAVO = fDICO._Code
            End If
            If f._bRISANIMAL Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("GR", " and substring(CDF_CODE_PK, 1, 1) =  'E'")
                fDICO.Text = "G - Données expérimentales - Risque / Animal"
                fDICO.ShowDialog()
                sCodeRISANIMAL = fDICO._Code
            End If
            If f._bFEMENCE Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("GC")
                fDICO.Text = "G - Conduite à tenir - Chez la femme enceinte"
                fDICO.ShowDialog()
                sCodeFEMENCE = fDICO._Code
            End If
            If f._bNOUVNE Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("GT")
                fDICO.Text = "G - Conduite à tenir - Chez le nouveau- né"
                fDICO.ShowDialog()
                sCodeNOUVNE = fDICO._Code
            End If
            If f._bGrrecREC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("GR", " and substring(CDF_CODE_PK, 1, 1) IN('R','C', 'P', 'Z')")
                fDICO.Text = "G - N° Recommandations"
                fDICO.ShowDialog()
                sCodeGrrecREC = fDICO._Code
            End If
            If f._bPERCONC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("GP")
                fDICO.Text = "G - Périodes concernées"
                fDICO.ShowDialog()
                sCodePERCONC = fDICO._Code
            End If
            If f._bPERCRI Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("GP")
                fDICO.Text = "G - Données cliniques - Période critique"
                fDICO.ShowDialog()
                sCodePERCRI = fDICO._Code
            End If
            If f._bOBSESPEC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("GO")
                fDICO.Text = "G - Données cliniques - Observation / Espèce humaine"
                fDICO.ShowDialog()
                sCodeOBSESPEC = fDICO._Code
            End If
            If f._bGrdcCIRFAVO Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("GC")
                fDICO.Text = "G - Données cliniques - Circonstances favorisantes"
                fDICO.ShowDialog()
                sCodeGrdcCIRFAVO = fDICO._Code
            End If
            If f._bRISHOMME Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("GR", " and substring(CDF_CODE_PK, 1, 1) =  'H'")
                fDICO.Text = "G - Données cliniques - Risque / Homme"
                fDICO.ShowDialog()
                sCodeRISHOMME = fDICO._Code
            End If
            If f._bFEMCONDTENIR Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("GT")
                fDICO.Text = "Femme en âge de procréer - Conduite à tenir"
                fDICO.ShowDialog()
                sCodeFEMCONDTENIR = fDICO._Code
            End If
            If f._bFemapREC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("GR", " and substring(CDF_CODE_PK, 1, 1) IN('R','C', 'P', 'Z')")
                fDICO.Text = "Femme en âge de procréer - Recommandations"
                fDICO.ShowDialog()
                sCodeFemapREC = fDICO._Code
            End If
            If f._bAllOBSER Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("GO")
                fDICO.Text = "Allaitement - Observations chez le nouveau-né"
                fDICO.ShowDialog()
                sCodeAllOBSER = fDICO._Code
            End If
            If f._bAllocnCIRFAVO Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("GC")
                fDICO.Text = "Allaitement - Circonstances favorisantes"
                fDICO.ShowDialog()
                sCodeAllocnCIRFAVO = fDICO._Code
            End If
            If f._bAllREC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("GR", " and substring(CDF_CODE_PK, 1, 1) IN('R','C', 'P', 'Z')")
                fDICO.Text = "Allaitement - Recommandations"
                fDICO.ShowDialog()
                sCodeAllREC = fDICO._Code
            End If
            If f._bALLCONDTENIR Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("GT")
                fDICO.Text = "Allaitement - Conduite à tenir"
                fDICO.ShowDialog()
                sCodeALLCONDTENIR = fDICO._Code
            End If
            

            Dim fResultat As New Frm_Recherche
            Dim sSQL As String = ""
            sSQL &= " Select FGA_CODE_SQ_PK as code, '' as libelle From THERIAQUE.FGA_FICHEGRAL"
            If sCodeCPH <> "" Then
                sSQL &= " WHERE FGA_CODE_SQ_PK IN (SELECT FGACPH_FGA_CODE_FK_PK FROM THERIAQUE.FGACPH_GRALCLPH WHERE FGACPH_CPH_CODE_FK_PK = " & cn.SQLText(sCodeCPH) & ")"
            End If
            If sCodeCCH <> "" Then
                If sCodeCPH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FGA_CODE_SQ_PK IN (SELECT FGACCH_FGA_CODE_FK_PK FROM THERIAQUE.FGACCH_GRALCLCH WHERE FGACCH_CCH_CODE_FK_PK = " & cn.SQLText(sCodeCCH) & ")"
            End If
            If sCodeSAC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FGA_CODE_SQ_PK IN (SELECT FGASAC_FGA_CODE_FK_PK FROM THERIAQUE.FGASAC_GRALSUBAC WHERE FGASAC_SAC_CODE_FK_PK = " & cn.SQLText(sCodeSAC) & ")"
            End If
            If sCodeSAU <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FGA_CODE_SQ_PK IN (SELECT FGASAU_FGA_CODE_FK_PK FROM THERIAQUE.FGASAU_GRALSUBAU WHERE FGASAU_SAU_CODE_FK_PK = " & cn.SQLText(sCodeSAU) & ")"
            End If
            If sCodePR <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FGA_CODE_SQ_PK IN (SELECT FGAPR_FGA_CODE_FK_PK FROM THERIAQUE.FGAPR_GRALPROD WHERE FGAPR_PR_CODE_FK_PK = " & cn.SQLText(sCodePR) & ")"
            End If
            If sCodeSP <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FGA_CODE_SQ_PK IN (SELECT FGASP_FGA_CODE_FK_PK FROM THERIAQUE.FGASP_GRALSPE WHERE FGASP_SP_CODE_FK_PK = " & cn.SQLText(sCodeSP) & ")"
            End If
            If sCodeGrdeCIRFAVO <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FGA_CODE_SQ_PK IN (SELECT FGACFA_FGA_CODE_FK_PK FROM THERIAQUE.FGACFA_CIRCONSTFAVORIS_ANIMALE WHERE FGACFA_CDF_CF_CODE_FK_PK = " & cn.SQLText(sCodeGrdeCIRFAVO) & ")"
            End If
            If sCodeRISANIMAL <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeGrdeCIRFAVO <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FGA_CODE_SQ_PK IN (SELECT FGARIA_FGA_CODE_FK_PK FROM THERIAQUE.FGARIA_RISQUE_ANIMALE WHERE FGARIA_CDF_RI_CODE_FK_PK = " & cn.SQLText(sCodeRISANIMAL) & ")"
            End If
            If sCodeFEMENCE <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeGrdeCIRFAVO <> "" Or sCodeRISANIMAL <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FGA_CODE_SQ_PK IN (SELECT FGACF_FGA_CODE_FK_PK FROM THERIAQUE.FGACF_CATFEMMEENCEINTE WHERE FGACF_CDF_CAT_CODE_FK_PK = " & cn.SQLText(sCodeFEMENCE) & ")"
            End If
            If sCodeNOUVNE <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeGrdeCIRFAVO <> "" Or sCodeRISANIMAL <> "" Or sCodeFEMENCE <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FGA_CODE_SQ_PK IN (SELECT FGACN_FGA_CODE_FK_PK FROM THERIAQUE.FGACN_CATNOUVEAUNE WHERE FGACN_CDF_CAT_CODE_FK_PK = " & cn.SQLText(sCodeNOUVNE) & ")"
            End If
            If sCodeGrrecREC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeGrdeCIRFAVO <> "" Or sCodeRISANIMAL <> "" Or sCodeFEMENCE <> "" Or sCodeNOUVNE <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FGA_CODE_SQ_PK IN (SELECT FGARIG_FGA_CODE_FK_PK FROM THERIAQUE.FGARIG_RISQUE_GROSSESSE WHERE FGARIG_CDF_RI_CODE_FK = " & cn.SQLText(sCodeGrrecREC) & ")"
            End If
            If sCodePERCONC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeGrdeCIRFAVO <> "" Or sCodeRISANIMAL <> "" Or sCodeFEMENCE <> "" Or sCodeNOUVNE <> "" Or sCodeGrrecREC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FGA_CODE_SQ_PK IN (SELECT FGARIG_FGA_CODE_FK_PK FROM THERIAQUE.FGARIG_RISQUE_GROSSESSE WHERE FGARIG_CDF_TC_CODE_FK = " & cn.SQLText(sCodePERCONC) & ")"
            End If
            If sCodePERCRI <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeGrdeCIRFAVO <> "" Or sCodeRISANIMAL <> "" Or sCodeFEMENCE <> "" Or sCodeNOUVNE <> "" Or sCodeGrrecREC <> "" Or sCodePERCONC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FGA_CODE_SQ_PK IN (SELECT FGAPC_FGA_CODE_FK_PK FROM THERIAQUE.FGAPC_PERIODECRITIQUE_FGRAL WHERE FGAPC_CDF_PC_CODE_FK_PK = " & cn.SQLText(sCodePERCRI) & ")"
            End If
            If sCodeOBSESPEC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeGrdeCIRFAVO <> "" Or sCodeRISANIMAL <> "" Or sCodeFEMENCE <> "" Or sCodeNOUVNE <> "" Or sCodeGrrecREC <> "" Or sCodePERCONC <> "" Or sCodePERCRI <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FGA_CODE_SQ_PK IN (SELECT FGAOH_FGA_CODE_FK_PK FROM THERIAQUE.FGAOH_OBSERVATION_HUMAINE WHERE FGAOH_CDF_OBS_CODE_FK_PK = " & cn.SQLText(sCodeOBSESPEC) & ")"
            End If
            If sCodeGrdcCIRFAVO <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeGrdeCIRFAVO <> "" Or sCodeRISANIMAL <> "" Or sCodeFEMENCE <> "" Or sCodeNOUVNE <> "" Or sCodeGrrecREC <> "" Or sCodePERCONC <> "" Or sCodePERCRI <> "" Or sCodeOBSESPEC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FGA_CODE_SQ_PK IN (SELECT FGACFH_FGA_CODE_FK_PK FROM THERIAQUE.FGACFH_CIRCONSTFAVORIS_HUMAINE WHERE FGACFH_CDF_CF_CODE_FK_PK = " & cn.SQLText(sCodeGrdcCIRFAVO) & ")"
            End If
            If sCodeRISHOMME <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeGrdeCIRFAVO <> "" Or sCodeRISANIMAL <> "" Or sCodeFEMENCE <> "" Or sCodeNOUVNE <> "" Or sCodeGrrecREC <> "" Or sCodePERCONC <> "" Or sCodePERCRI <> "" Or sCodeOBSESPEC <> "" Or sCodeGrdcCIRFAVO <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FGA_CODE_SQ_PK IN (SELECT FGARIH_FGA_CODE_FK_PK FROM THERIAQUE.FGARIH_RISQUE_HUMAINE WHERE FGARIH_CDF_RI_CODE_FK_PK = " & cn.SQLText(sCodeRISHOMME) & ")"
            End If
            If sCodeFEMCONDTENIR <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeGrdeCIRFAVO <> "" Or sCodeRISANIMAL <> "" Or sCodeFEMENCE <> "" Or sCodeNOUVNE <> "" Or sCodeGrrecREC <> "" Or sCodePERCONC <> "" Or sCodePERCRI <> "" Or sCodeOBSESPEC <> "" Or sCodeGrdcCIRFAVO <> "" Or sCodeRISHOMME <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FGA_CODE_SQ_PK IN (SELECT FGACFAP_FGA_CODE_FK_PK FROM THERIAQUE.FGACFAP_CATFEMMEENAGE WHERE FGACFAP_CDF_CAT_CODE_FK_PK = " & cn.SQLText(sCodeFEMCONDTENIR) & ")"
            End If
            If sCodeFemapREC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeGrdeCIRFAVO <> "" Or sCodeRISANIMAL <> "" Or sCodeFEMENCE <> "" Or sCodeNOUVNE <> "" Or sCodeGrrecREC <> "" Or sCodePERCONC <> "" Or sCodePERCRI <> "" Or sCodeOBSESPEC <> "" Or sCodeGrdcCIRFAVO <> "" Or sCodeRISHOMME <> "" Or sCodeFEMCONDTENIR <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FGA_CODE_SQ_PK IN (SELECT FGARIFAP_FGA_CODE_FK_PK FROM THERIAQUE.FGARIFAP_RISQUEFEMMEENAGE WHERE FGARIFAP_CDF_RI_CODE_FK_PK = " & cn.SQLText(sCodeFemapREC) & ")"
            End If
            If sCodeAllOBSER <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeGrdeCIRFAVO <> "" Or sCodeRISANIMAL <> "" Or sCodeFEMENCE <> "" Or sCodeNOUVNE <> "" Or sCodeGrrecREC <> "" Or sCodePERCONC <> "" Or sCodePERCRI <> "" Or sCodeOBSESPEC <> "" Or sCodeGrdcCIRFAVO <> "" Or sCodeRISHOMME <> "" Or sCodeFEMCONDTENIR <> "" Or sCodeFemapREC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FGA_CODE_SQ_PK IN (SELECT FGAON_FGA_CODE_FK_PK FROM THERIAQUE.FGAON_OBSERVATION_NOUVEAUNE WHERE FGAON_CDF_OBS_CODE_FK_PK = " & cn.SQLText(sCodeAllOBSER) & ")"
            End If
            If sCodeAllocnCIRFAVO <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeGrdeCIRFAVO <> "" Or sCodeRISANIMAL <> "" Or sCodeFEMENCE <> "" Or sCodeNOUVNE <> "" Or sCodeGrrecREC <> "" Or sCodePERCONC <> "" Or sCodePERCRI <> "" Or sCodeOBSESPEC <> "" Or sCodeGrdcCIRFAVO <> "" Or sCodeRISHOMME <> "" Or sCodeFEMCONDTENIR <> "" Or sCodeFemapREC <> "" Or sCodeAllOBSER <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FGA_CODE_SQ_PK IN (SELECT FGACFN_FGA_CODE_FK_PK FROM THERIAQUE.FGACFN_CIRCONSFAVORIS_NOUVEAUN WHERE FGACFN_CDF_CF_CODE_FK_PK = " & cn.SQLText(sCodeAllocnCIRFAVO) & ")"
            End If
            If sCodeAllREC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeGrdeCIRFAVO <> "" Or sCodeRISANIMAL <> "" Or sCodeFEMENCE <> "" Or sCodeNOUVNE <> "" Or sCodeGrrecREC <> "" Or sCodePERCONC <> "" Or sCodePERCRI <> "" Or sCodeOBSESPEC <> "" Or sCodeGrdcCIRFAVO <> "" Or sCodeRISHOMME <> "" Or sCodeFEMCONDTENIR <> "" Or sCodeFemapREC <> "" Or sCodeAllOBSER <> "" Or sCodeAllocnCIRFAVO <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FGA_CODE_SQ_PK IN (SELECT FGARIL_FGA_CODE_FK_PK FROM THERIAQUE.FGARIL_RISQUE_ALLAITEMENT WHERE FGARIL_CDF_RI_CODE_FK_PK = " & cn.SQLText(sCodeAllREC) & ")"
            End If
            If sCodeALLCONDTENIR <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeGrdeCIRFAVO <> "" Or sCodeRISANIMAL <> "" Or sCodeFEMENCE <> "" Or sCodeNOUVNE <> "" Or sCodeGrrecREC <> "" Or sCodePERCONC <> "" Or sCodePERCRI <> "" Or sCodeOBSESPEC <> "" Or sCodeGrdcCIRFAVO <> "" Or sCodeRISHOMME <> "" Or sCodeFEMCONDTENIR <> "" Or sCodeFemapREC <> "" Or sCodeAllOBSER <> "" Or sCodeAllocnCIRFAVO <> "" Or sCodeAllREC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FGA_CODE_SQ_PK IN (SELECT FGACA_FGA_CODE_FK_PK FROM THERIAQUE.FGACA_CATALLAITEMENT WHERE FGACA_CDF_CAT_CODE_FK_PK = " & cn.SQLText(sCodeALLCONDTENIR) & ")"
            End If

            sSQL &= " ORDER BY FGA_CODE_SQ_PK"

            fResultat._SSQL = sSQL
            fResultat.Text = Me.Text
            fResultat.ShowDialog()
            CodE = fResultat._Code
            If fResultat._Code IsNot Nothing Then
                XtraTabControl1.SelectedTabPageIndex = 0
                OnLoading = True
                EmptyDataTable()
                Me.FgA_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGA_FICHEGRAL, fResultat._Code)

                'Onglet Entités
                Me.FgacpH_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGACPH_GRALCLPH, fResultat._Code)
                Me.FgaccH_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGACCH_GRALCLCH, fResultat._Code)
                Me.FgasaU_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGASAU_GRALSUBAU, fResultat._Code)
                Me.FgasaC_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGASAC_GRALSUBAC, fResultat._Code)
                Me.FgapR_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGAPR_GRALPROD, fResultat._Code)
                Me.FgasP_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGASP_GRALSPE, fResultat._Code)

                Tab_TA1 = False
                Tab_TA2 = False
                Tab_TA3 = False

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

    Public Overrides Sub Ajouter()
        EmptyDataTable()
        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        SetCode_MAx(MasterTable, txtCode)
        CodE = InvalideControl
        MyBase.Ajouter()

        bModeDuplication = False
        XtraTabControl1.SelectedTabPageIndex = 0
    End Sub
    Public Overrides Function supprimer() As Boolean
        If Tab_TA1 And Tab_TA2 And Tab_TA3 Then
            MyBase.Supprimer()
            Dim iCount As Integer
            'Onglet Entités
            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGACPH_GRALCLPH.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGACPH_GRALCLPH.Rows(iCount).Delete()
            Next
            Me.FgacpH_TA.Update(DsTheriaque_Grossesse_Allaitement)

            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGACCH_GRALCLCH.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGACCH_GRALCLCH.Rows(iCount).Delete()
            Next
            Me.FgaccH_TA.Update(DsTheriaque_Grossesse_Allaitement)

            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGASAC_GRALSUBAC.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGASAC_GRALSUBAC.Rows(iCount).Delete()
            Next
            Me.FgasaC_TA.Update(DsTheriaque_Grossesse_Allaitement)

            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGASAU_GRALSUBAU.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGASAU_GRALSUBAU.Rows(iCount).Delete()
            Next
            Me.FgasaU_TA.Update(DsTheriaque_Grossesse_Allaitement)

            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGAPR_GRALPROD.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGAPR_GRALPROD.Rows(iCount).Delete()
            Next
            Me.FgapR_TA.Update(DsTheriaque_Grossesse_Allaitement)

            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGASP_GRALSPE.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGASP_GRALSPE.Rows(iCount).Delete()
            Next
            Me.FgasP_TA.Update(DsTheriaque_Grossesse_Allaitement)

            'Onglet Grossesse - Données expérimentales
            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGAOA_OBSERVATION_ANIMALE.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGAOA_OBSERVATION_ANIMALE.Rows(iCount).Delete()
            Next
            Me.FgaoA_TA.Update(DsTheriaque_Grossesse_Allaitement)

            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGACFA_CIRCONSTFAVORIS_ANIMALE.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGACFA_CIRCONSTFAVORIS_ANIMALE.Rows(iCount).Delete()
            Next
            Me.FgacfA_TA.Update(DsTheriaque_Grossesse_Allaitement)

            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGATX1_FGA_TXOBSERVANI.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGATX1_FGA_TXOBSERVANI.Rows(iCount).Delete()
            Next
            Me.FgatX1_TA.Update(DsTheriaque_Grossesse_Allaitement)

            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGARIA_RISQUE_ANIMALE.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGARIA_RISQUE_ANIMALE.Rows(iCount).Delete()
            Next
            Me.FgariA_TA.Update(DsTheriaque_Grossesse_Allaitement)

            'Onglet Grossesse - Données clinique
            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGAPC_PERIODECRITIQUE_FGRAL.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGAPC_PERIODECRITIQUE_FGRAL.Rows(iCount).Delete()
            Next
            Me.FgapC_TA.Update(DsTheriaque_Grossesse_Allaitement)

            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGAOH_OBSERVATION_HUMAINE.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGAOH_OBSERVATION_HUMAINE.Rows(iCount).Delete()
            Next
            Me.FgaoH_TA.Update(DsTheriaque_Grossesse_Allaitement)

            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGACFH_CIRCONSTFAVORIS_HUMAINE.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGACFH_CIRCONSTFAVORIS_HUMAINE.Rows(iCount).Delete()
            Next
            Me.FgacfH_TA.Update(DsTheriaque_Grossesse_Allaitement)

            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGARIH_RISQUE_HUMAINE.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGARIH_RISQUE_HUMAINE.Rows(iCount).Delete()
            Next
            Me.FgariH_TA.Update(DsTheriaque_Grossesse_Allaitement)

            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGATX3_FGA_TXOBSERVHUM.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGATX3_FGA_TXOBSERVHUM.Rows(iCount).Delete()
            Next
            Me.FgatX3_TA.Update(DsTheriaque_Grossesse_Allaitement)

            'Onglet Grossesse - Recommandations
            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGARIG_RISQUE_GROSSESSE.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGARIG_RISQUE_GROSSESSE.Rows(iCount).Delete()
            Next
            Me.FgariG_TA.Update(DsTheriaque_Grossesse_Allaitement)

            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGATX7_FGA_TXRECOMMANDAT.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGATX7_FGA_TXRECOMMANDAT.Rows(iCount).Delete()
            Next
            Me.FgatX7_TA.Update(DsTheriaque_Grossesse_Allaitement)

            'Onglet Grossesse - Conduite à tenir
            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGACF_CATFEMMEENCEINTE.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGACF_CATFEMMEENCEINTE.Rows(iCount).Delete()
            Next
            Me.FgacF_TA.Update(DsTheriaque_Grossesse_Allaitement)

            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGATX4_FGA_TXCONDATENIRCF.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGATX4_FGA_TXCONDATENIRCF.Rows(iCount).Delete()
            Next
            Me.FgatX4_TA.Update(DsTheriaque_Grossesse_Allaitement)

            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGACN_CATNOUVEAUNE.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGACN_CATNOUVEAUNE.Rows(iCount).Delete()
            Next
            Me.FgacN_TA.Update(DsTheriaque_Grossesse_Allaitement)

            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGATX5_FGA_TXCONDATENIRCN.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGATX5_FGA_TXCONDATENIRCN.Rows(iCount).Delete()
            Next
            Me.FgatX5_TA.Update(DsTheriaque_Grossesse_Allaitement)

            'Onglet Femme en âge de procréer
            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGARIFAP_RISQUEFEMMEENAGE.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGARIFAP_RISQUEFEMMEENAGE.Rows(iCount).Delete()
            Next
            Me.FgarifaP_TA.Update(DsTheriaque_Grossesse_Allaitement)

            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGATX9_FGA_TXRECOMMANDAT.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGATX9_FGA_TXRECOMMANDAT.Rows(iCount).Delete()
            Next
            Me.FgatX9_TA.Update(DsTheriaque_Grossesse_Allaitement)

            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGACFAP_CATFEMMEENAGE.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGACFAP_CATFEMMEENAGE.Rows(iCount).Delete()
            Next
            Me.FgacfaP_TA.Update(DsTheriaque_Grossesse_Allaitement)

            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGATX10_FGA_TXRECOMMANDAT.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGATX10_FGA_TXRECOMMANDAT.Rows(iCount).Delete()
            Next
            Me.FgatX10_TA.Update(DsTheriaque_Grossesse_Allaitement)

            'Onglet Allaitement
            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGAON_OBSERVATION_NOUVEAUNE.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGAON_OBSERVATION_NOUVEAUNE.Rows(iCount).Delete()
            Next
            Me.FgaoN_TA.Update(DsTheriaque_Grossesse_Allaitement)

            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGACFN_CIRCONSFAVORIS_NOUVEAUN.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGACFN_CIRCONSFAVORIS_NOUVEAUN.Rows(iCount).Delete()
            Next
            Me.FgacfN_TA.Update(DsTheriaque_Grossesse_Allaitement)

            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGATX2_FGA_TXOBSERVNOUVNE.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGATX2_FGA_TXOBSERVNOUVNE.Rows(iCount).Delete()
            Next
            Me.FgatX2_TA.Update(DsTheriaque_Grossesse_Allaitement)

            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGARIL_RISQUE_ALLAITEMENT.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGARIL_RISQUE_ALLAITEMENT.Rows(iCount).Delete()
            Next
            Me.FgariL_TA.Update(DsTheriaque_Grossesse_Allaitement)

            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGATX8_FGA_TXRECOMMANDAT.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGATX8_FGA_TXRECOMMANDAT.Rows(iCount).Delete()
            Next
            Me.FgatX8_TA.Update(DsTheriaque_Grossesse_Allaitement)

            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGACA_CATALLAITEMENT.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGACA_CATALLAITEMENT.Rows(iCount).Delete()
            Next
            Me.FgacA_TA.Update(DsTheriaque_Grossesse_Allaitement)

            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGATX6_FGA_TXCONDATENIRCA.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGATX6_FGA_TXCONDATENIRCA.Rows(iCount).Delete()
            Next
            Me.FgatX6_TA.Update(DsTheriaque_Grossesse_Allaitement)

            'Références officielles 
            For iCount = 0 To DsTheriaque_Grossesse_Allaitement.FGAAFS_FGA_AFSSAPS.Rows.Count - 1
                DsTheriaque_Grossesse_Allaitement.FGAAFS_FGA_AFSSAPS.Rows(iCount).Delete()
            Next
            Me.FgaafS_TA.Update(DsTheriaque_Grossesse_Allaitement)

            ' Master
            DsTheriaque_Grossesse_Allaitement.FGA_FICHEGRAL.Rows(0).Delete()
            Me.FgA_TA.Update(Me.MasterDataSet)

            bModeDuplication = False
            Return True
        Else
            Process_Message(strChargementOnglet, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Function
    Public Overrides Sub valider()
        MyBase.Valider()
        'Master
        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        FgA_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGA_FICHEGRAL)
        'Onglet Entités
        Me.BindingContext(Me.MasterDataSet, FGACPH_GRALCLPH).EndCurrentEdit()
        FgacpH_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGACPH_GRALCLPH)

        Me.BindingContext(Me.MasterDataSet, FGACCH_GRALCLCH).EndCurrentEdit()
        FgaccH_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGACCH_GRALCLCH)

        Me.BindingContext(Me.MasterDataSet, FGASAC_GRALSUBAC).EndCurrentEdit()
        FgasaC_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGASAC_GRALSUBAC)

        Me.BindingContext(Me.MasterDataSet, FGASAU_GRALSUBAU).EndCurrentEdit()
        FgasaU_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGASAU_GRALSUBAU)

        Me.BindingContext(Me.MasterDataSet, FGAPR_GRALPROD).EndCurrentEdit()
        FgapR_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGAPR_GRALPROD)

        Me.BindingContext(Me.MasterDataSet, FGASP_GRALSPE).EndCurrentEdit()
        FgasP_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGASP_GRALSPE)

        'Onglet Grossesse - Données expérimentales
        Me.BindingContext(Me.MasterDataSet, FGAOA_OBSERVATION_ANIMALE).EndCurrentEdit()
        FgaoA_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGAOA_OBSERVATION_ANIMALE)

        Me.BindingContext(Me.MasterDataSet, FGACFA_CIRCONSTFAVORIS_ANIMALE).EndCurrentEdit()
        FgacfA_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGACFA_CIRCONSTFAVORIS_ANIMALE)

        Me.BindingContext(Me.MasterDataSet, FGATX1_FGA_TXOBSERVANI).EndCurrentEdit()
        FgatX1_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGATX1_FGA_TXOBSERVANI)

        Me.BindingContext(Me.MasterDataSet, FGARIA_RISQUE_ANIMALE).EndCurrentEdit()
        FgariA_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGARIA_RISQUE_ANIMALE)

        'Onglet Grossesse - Données clinique
        Me.BindingContext(Me.MasterDataSet, FGAPC_PERIODECRITIQUE_FGRAL).EndCurrentEdit()
        FgapC_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGAPC_PERIODECRITIQUE_FGRAL)

        Me.BindingContext(Me.MasterDataSet, FGAOH_OBSERVATION_HUMAINE).EndCurrentEdit()
        FgaoH_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGAOH_OBSERVATION_HUMAINE)

        Me.BindingContext(Me.MasterDataSet, FGACFH_CIRCONSTFAVORIS_HUMAINE).EndCurrentEdit()
        FgacfH_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGACFH_CIRCONSTFAVORIS_HUMAINE)

        Me.BindingContext(Me.MasterDataSet, FGARIH_RISQUE_HUMAINE).EndCurrentEdit()
        FgariH_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGARIH_RISQUE_HUMAINE)

        Me.BindingContext(Me.MasterDataSet, FGATX3_FGA_TXOBSERVHUM).EndCurrentEdit()
        FgatX3_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGATX3_FGA_TXOBSERVHUM)

        'Onglet Grossesse - Recommandations
        Me.BindingContext(Me.MasterDataSet, FGARIG_RISQUE_GROSSESSE).EndCurrentEdit()
        FgariG_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGARIG_RISQUE_GROSSESSE)

        Me.BindingContext(Me.MasterDataSet, FGATX7_FGA_TXRECOMMANDAT).EndCurrentEdit()
        FgatX7_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGATX7_FGA_TXRECOMMANDAT)

        'Onglet Grossesse - Conduite à tenir
        Me.BindingContext(Me.MasterDataSet, FGACF_CATFEMMEENCEINTE).EndCurrentEdit()
        FgacF_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGACF_CATFEMMEENCEINTE)

        Me.BindingContext(Me.MasterDataSet, FGATX4_FGA_TXCONDATENIRCF).EndCurrentEdit()
        FgatX4_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGATX4_FGA_TXCONDATENIRCF)

        Me.BindingContext(Me.MasterDataSet, FGACN_CATNOUVEAUNE).EndCurrentEdit()
        FgacN_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGACN_CATNOUVEAUNE)

        Me.BindingContext(Me.MasterDataSet, FGATX5_FGA_TXCONDATENIRCN).EndCurrentEdit()
        FgatX5_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGATX5_FGA_TXCONDATENIRCN)

        'Onglet Femme en âge de procréer
        Me.BindingContext(Me.MasterDataSet, FGARIFAP_RISQUEFEMMEENAGE).EndCurrentEdit()
        FgarifaP_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGARIFAP_RISQUEFEMMEENAGE)

        Me.BindingContext(Me.MasterDataSet, FGATX9_FGA_TXRECOMMANDAT).EndCurrentEdit()
        FgatX9_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGATX9_FGA_TXRECOMMANDAT)

        Me.BindingContext(Me.MasterDataSet, FGACFAP_CATFEMMEENAGE).EndCurrentEdit()
        FgacfaP_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGACFAP_CATFEMMEENAGE)

        Me.BindingContext(Me.MasterDataSet, FGATX10_FGA_TXRECOMMANDAT).EndCurrentEdit()
        FgatX10_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGATX10_FGA_TXRECOMMANDAT)

        'Onglet Allaitement
        Me.BindingContext(Me.MasterDataSet, FGAON_OBSERVATION_NOUVEAUNE).EndCurrentEdit()
        FgaoN_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGAON_OBSERVATION_NOUVEAUNE)

        Me.BindingContext(Me.MasterDataSet, FGACFN_CIRCONSFAVORIS_NOUVEAUN).EndCurrentEdit()
        FgacfN_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGACFN_CIRCONSFAVORIS_NOUVEAUN)

        Me.BindingContext(Me.MasterDataSet, FGATX2_FGA_TXOBSERVNOUVNE).EndCurrentEdit()
        FgatX2_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGATX2_FGA_TXOBSERVNOUVNE)

        Me.BindingContext(Me.MasterDataSet, FGARIL_RISQUE_ALLAITEMENT).EndCurrentEdit()
        FgariL_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGARIL_RISQUE_ALLAITEMENT)

        Me.BindingContext(Me.MasterDataSet, FGATX8_FGA_TXRECOMMANDAT).EndCurrentEdit()
        FgatX8_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGATX8_FGA_TXRECOMMANDAT)

        Me.BindingContext(Me.MasterDataSet, FGACA_CATALLAITEMENT).EndCurrentEdit()
        FgacA_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGACA_CATALLAITEMENT)

        Me.BindingContext(Me.MasterDataSet, FGATX6_FGA_TXCONDATENIRCA).EndCurrentEdit()
        FgatX6_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGATX6_FGA_TXCONDATENIRCA)

        'Références officielles 
        Me.BindingContext(Me.MasterDataSet, FGAAFS_FGA_AFSSAPS).EndCurrentEdit()
        FgaafS_TA.Update(Me.DsTheriaque_Grossesse_Allaitement.FGAAFS_FGA_AFSSAPS)

        bModeDuplication = False
        'Tab_TA1 = True
        'Tab_TA2 = True
        'Tab_TA3 = True
    End Sub
    Public Overrides Sub annuler()
        OnLoading = True
        MyBase.Annuler()
        'Onglet Entités
        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGACPH_GRALCLPH).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGACPH_GRALCLPH.RejectChanges()

        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGACCH_GRALCLCH).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGACCH_GRALCLCH.RejectChanges()

        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGASAU_GRALSUBAU).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGASAU_GRALSUBAU.RejectChanges()

        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGASAC_GRALSUBAC).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGASAC_GRALSUBAC.RejectChanges()

        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGAPR_GRALPROD).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGAPR_GRALPROD.RejectChanges()

        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGASP_GRALSPE).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGASP_GRALSPE.RejectChanges()

        'Onglet Grossesse - Données expérimentales
        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGAOA_OBSERVATION_ANIMALE).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGAOA_OBSERVATION_ANIMALE.RejectChanges()

        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGACFA_CIRCONSTFAVORIS_ANIMALE).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGACFA_CIRCONSTFAVORIS_ANIMALE.RejectChanges()

        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGATX1_FGA_TXOBSERVANI).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGATX1_FGA_TXOBSERVANI.RejectChanges()

        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGARIA_RISQUE_ANIMALE).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGARIA_RISQUE_ANIMALE.RejectChanges()

        'Onglet Grossesse - Données clinique
        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGAPC_PERIODECRITIQUE_FGRAL).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGAPC_PERIODECRITIQUE_FGRAL.RejectChanges()

        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGAOH_OBSERVATION_HUMAINE).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGAOH_OBSERVATION_HUMAINE.RejectChanges()

        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGACFH_CIRCONSTFAVORIS_HUMAINE).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGACFH_CIRCONSTFAVORIS_HUMAINE.RejectChanges()

        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGARIH_RISQUE_HUMAINE).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGARIH_RISQUE_HUMAINE.RejectChanges()

        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGATX3_FGA_TXOBSERVHUM).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGATX3_FGA_TXOBSERVHUM.RejectChanges()

        'Onglet Grossesse - Recommandations
        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGARIG_RISQUE_GROSSESSE).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGARIG_RISQUE_GROSSESSE.RejectChanges()

        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGATX7_FGA_TXRECOMMANDAT).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGATX7_FGA_TXRECOMMANDAT.RejectChanges()

        'Onglet Grossesse - Conduite à tenir
        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGACF_CATFEMMEENCEINTE).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGACF_CATFEMMEENCEINTE.RejectChanges()

        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGACN_CATNOUVEAUNE).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGACN_CATNOUVEAUNE.RejectChanges()

        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGATX4_FGA_TXCONDATENIRCF).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGATX4_FGA_TXCONDATENIRCF.RejectChanges()

        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGATX5_FGA_TXCONDATENIRCN).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGATX5_FGA_TXCONDATENIRCN.RejectChanges()

        'Onglet Femme en âge de procréer
        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGARIFAP_RISQUEFEMMEENAGE).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGARIFAP_RISQUEFEMMEENAGE.RejectChanges()

        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGATX9_FGA_TXRECOMMANDAT).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGATX9_FGA_TXRECOMMANDAT.RejectChanges()

        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGACFAP_CATFEMMEENAGE).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGACFAP_CATFEMMEENAGE.RejectChanges()

        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGATX10_FGA_TXRECOMMANDAT).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGATX10_FGA_TXRECOMMANDAT.RejectChanges()

        'Onglet Allaitement
        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGAON_OBSERVATION_NOUVEAUNE).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGAON_OBSERVATION_NOUVEAUNE.RejectChanges()

        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGACFN_CIRCONSFAVORIS_NOUVEAUN).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGACFN_CIRCONSFAVORIS_NOUVEAUN.RejectChanges()

        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGATX2_FGA_TXOBSERVNOUVNE).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGATX2_FGA_TXOBSERVNOUVNE.RejectChanges()

        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGARIL_RISQUE_ALLAITEMENT).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGARIL_RISQUE_ALLAITEMENT.RejectChanges()

        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGATX8_FGA_TXRECOMMANDAT).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGATX8_FGA_TXRECOMMANDAT.RejectChanges()

        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGACA_CATALLAITEMENT).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGACA_CATALLAITEMENT.RejectChanges()

        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGATX6_FGA_TXCONDATENIRCA).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGATX6_FGA_TXCONDATENIRCA.RejectChanges()

        'Références officielles 
        Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGAAFS_FGA_AFSSAPS).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGAAFS_FGA_AFSSAPS.RejectChanges()

        'Master
        Me.BindingContext(Me.MasterDataSet, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_Grossesse_Allaitement.FGA_FICHEGRAL.RejectChanges()

        If bModeDuplication Then EmptyDataTable()
        bModeDuplication = False
        OnLoading = False
    End Sub
    Private Sub EmptyDataTable()
        'Master
        Me.DsTheriaque_Grossesse_Allaitement.FGA_FICHEGRAL.Clear()
        'Onglet Entités
        Me.DsTheriaque_Grossesse_Allaitement.FGACPH_GRALCLPH.Clear()
        Me.DsTheriaque_Grossesse_Allaitement.FGACCH_GRALCLCH.Clear()
        Me.DsTheriaque_Grossesse_Allaitement.FGASAU_GRALSUBAU.Clear()
        Me.DsTheriaque_Grossesse_Allaitement.FGASAC_GRALSUBAC.Clear()
        Me.DsTheriaque_Grossesse_Allaitement.FGAPR_GRALPROD.Clear()
        Me.DsTheriaque_Grossesse_Allaitement.FGASP_GRALSPE.Clear()
        'Onglet Grossesse - Données expérimentales
        Me.DsTheriaque_Grossesse_Allaitement.FGAOA_OBSERVATION_ANIMALE.Clear()
        Me.DsTheriaque_Grossesse_Allaitement.FGACFA_CIRCONSTFAVORIS_ANIMALE.Clear()
        Me.DsTheriaque_Grossesse_Allaitement.FGATX1_FGA_TXOBSERVANI.Clear()
        Me.DsTheriaque_Grossesse_Allaitement.FGARIA_RISQUE_ANIMALE.Clear()
        'Onglet Grossesse - Données clinique
        Me.DsTheriaque_Grossesse_Allaitement.FGAPC_PERIODECRITIQUE_FGRAL.Clear()
        Me.DsTheriaque_Grossesse_Allaitement.FGAOH_OBSERVATION_HUMAINE.Clear()
        Me.DsTheriaque_Grossesse_Allaitement.FGACFH_CIRCONSTFAVORIS_HUMAINE.Clear()
        Me.DsTheriaque_Grossesse_Allaitement.FGARIH_RISQUE_HUMAINE.Clear()
        Me.DsTheriaque_Grossesse_Allaitement.FGATX3_FGA_TXOBSERVHUM.Clear()
        'Onglet Grossesse - Recommandations
        Me.DsTheriaque_Grossesse_Allaitement.FGARIG_RISQUE_GROSSESSE.Clear()
        Me.DsTheriaque_Grossesse_Allaitement.FGATX7_FGA_TXRECOMMANDAT.Clear()
        'Onglet Grossesse - Conduite à tenir
        Me.DsTheriaque_Grossesse_Allaitement.FGACF_CATFEMMEENCEINTE.Clear()
        Me.DsTheriaque_Grossesse_Allaitement.FGATX4_FGA_TXCONDATENIRCF.Clear()
        Me.DsTheriaque_Grossesse_Allaitement.FGACN_CATNOUVEAUNE.Clear()
        Me.DsTheriaque_Grossesse_Allaitement.FGATX5_FGA_TXCONDATENIRCN.Clear()
        'Onglet Femme en âge de procréer
        Me.DsTheriaque_Grossesse_Allaitement.FGARIFAP_RISQUEFEMMEENAGE.Clear()
        Me.DsTheriaque_Grossesse_Allaitement.FGATX9_FGA_TXRECOMMANDAT.Clear()
        Me.DsTheriaque_Grossesse_Allaitement.FGACFAP_CATFEMMEENAGE.Clear()
        Me.DsTheriaque_Grossesse_Allaitement.FGATX10_FGA_TXRECOMMANDAT.Clear()

        'Onglet Allaitement
        Me.DsTheriaque_Grossesse_Allaitement.FGAON_OBSERVATION_NOUVEAUNE.Clear()
        Me.DsTheriaque_Grossesse_Allaitement.FGACFN_CIRCONSFAVORIS_NOUVEAUN.Clear()
        Me.DsTheriaque_Grossesse_Allaitement.FGATX2_FGA_TXOBSERVNOUVNE.Clear()
        Me.DsTheriaque_Grossesse_Allaitement.FGARIL_RISQUE_ALLAITEMENT.Clear()
        Me.DsTheriaque_Grossesse_Allaitement.FGATX8_FGA_TXRECOMMANDAT.Clear()
        Me.DsTheriaque_Grossesse_Allaitement.FGACA_CATALLAITEMENT.Clear()
        Me.DsTheriaque_Grossesse_Allaitement.FGATX6_FGA_TXCONDATENIRCA.Clear()

        'Références officielles 
        Me.DsTheriaque_Grossesse_Allaitement.FGAAFS_FGA_AFSSAPS.Clear()

    End Sub

    ''' <summary>
    ''' Proçédure: Duplication des données à partir d'une autre fiche
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub Dupliquer()

        If Not Tab_TA1 And CodE <> InvalideControl And CodE <> Nothing Then LoadTab_1()
        If Not Tab_TA2 And CodE <> InvalideControl And CodE <> Nothing Then LoadTab_2()
        If Not Tab_TA3 And CodE <> InvalideControl And CodE <> Nothing Then LoadTab_3()

        'Sauvegarde des données à duplquer

        'Onglet entités
        Dim dt1 As New DataTable
        dt1 = DsTheriaque_Grossesse_Allaitement.FGACPH_GRALCLPH.Copy

        Dim dt2 As New DataTable
        dt2 = DsTheriaque_Grossesse_Allaitement.FGACCH_GRALCLCH.Copy

        Dim dt3 As New DataTable
        dt3 = DsTheriaque_Grossesse_Allaitement.FGASAC_GRALSUBAC.Copy

        Dim dt4 As New DataTable
        dt4 = DsTheriaque_Grossesse_Allaitement.FGASAU_GRALSUBAU.Copy

        Dim dt5 As New DataTable
        dt5 = DsTheriaque_Grossesse_Allaitement.FGAPR_GRALPROD.Copy

        Dim dt6 As New DataTable
        dt6 = DsTheriaque_Grossesse_Allaitement.FGASP_GRALSPE.Copy

        'Onglet2
        Dim dt11 As New DataTable
        dt11 = DsTheriaque_Grossesse_Allaitement.FGAOA_OBSERVATION_ANIMALE.Copy

        Dim dt12 As New DataTable
        dt12 = DsTheriaque_Grossesse_Allaitement.FGACFA_CIRCONSTFAVORIS_ANIMALE.Copy

        Dim dt13 As New DataTable
        dt13 = DsTheriaque_Grossesse_Allaitement.FGATX1_FGA_TXOBSERVANI.Copy

        Dim dt14 As New DataTable
        dt14 = DsTheriaque_Grossesse_Allaitement.FGARIA_RISQUE_ANIMALE.Copy

        Dim dt21 As New DataTable
        dt21 = DsTheriaque_Grossesse_Allaitement.FGAPC_PERIODECRITIQUE_FGRAL.Copy

        Dim dt22 As New DataTable
        dt22 = DsTheriaque_Grossesse_Allaitement.FGAOH_OBSERVATION_HUMAINE.Copy

        Dim dt23 As New DataTable
        dt23 = DsTheriaque_Grossesse_Allaitement.FGACFH_CIRCONSTFAVORIS_HUMAINE.Copy

        Dim dt24 As New DataTable
        dt24 = DsTheriaque_Grossesse_Allaitement.FGARIH_RISQUE_HUMAINE.Copy

        Dim dt25 As New DataTable
        dt25 = DsTheriaque_Grossesse_Allaitement.FGATX3_FGA_TXOBSERVHUM.Copy

        Dim sRG_Effet As String = RadioGroup1.Text

        Dim dt31 As New DataTable
        dt31 = DsTheriaque_Grossesse_Allaitement.FGARIG_RISQUE_GROSSESSE.Copy

        Dim dt32 As New DataTable
        dt32 = DsTheriaque_Grossesse_Allaitement.FGATX7_FGA_TXRECOMMANDAT.Copy

        Dim dt41 As New DataTable
        dt41 = DsTheriaque_Grossesse_Allaitement.FGACF_CATFEMMEENCEINTE.Copy

        Dim dt42 As New DataTable
        dt42 = DsTheriaque_Grossesse_Allaitement.FGATX4_FGA_TXCONDATENIRCF.Copy

        Dim dt43 As New DataTable
        dt43 = DsTheriaque_Grossesse_Allaitement.FGACN_CATNOUVEAUNE.Copy

        Dim dt44 As New DataTable
        dt44 = DsTheriaque_Grossesse_Allaitement.FGATX5_FGA_TXCONDATENIRCN.Copy

        Dim dt45 As New DataTable
        dt45 = DsTheriaque_Grossesse_Allaitement.FGAAFS_FGA_AFSSAPS.Copy

        'Onglet3
        Dim dt51 As New DataTable
        dt51 = DsTheriaque_Grossesse_Allaitement.FGARIFAP_RISQUEFEMMEENAGE.Copy

        Dim dt52 As New DataTable
        dt52 = DsTheriaque_Grossesse_Allaitement.FGATX9_FGA_TXRECOMMANDAT.Copy

        Dim dt53 As New DataTable
        dt53 = DsTheriaque_Grossesse_Allaitement.FGACFAP_CATFEMMEENAGE.Copy

        Dim dt54 As New DataTable
        dt54 = DsTheriaque_Grossesse_Allaitement.FGATX10_FGA_TXRECOMMANDAT.Copy

        'Onglet4
        Dim sPassageLait As String = Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGA_FICHEGRAL).Current("FGA_PASSAGELAIT").ToString
        Dim sFixationPro As String = Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGA_FICHEGRAL).Current("FGA_FIXATIONPROTEIQUE").ToString
        Dim objTextMinFixationPro As Object = Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGA_FICHEGRAL).Current("FGA_FIXATIONPROTEIQUE_MINI")
        Dim objTextMaxFixationPro As Object = Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGA_FICHEGRAL).Current("FGA_FIXATIONPROTEIQUE_MAXI")
        Dim sPlasmaLait As String = Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGA_FICHEGRAL).Current("FGA_PLASMALAIT").ToString
        Dim objTextMinPlasmaLait As Object = Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGA_FICHEGRAL).Current("FGA_PLASMALAIT_MINI")
        Dim objTextMaxPlasmaLait As Object = Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGA_FICHEGRAL).Current("FGA_PLASMALAIT_MAXI")
        Dim sConcentration As String = Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGA_FICHEGRAL).Current("FGA_CONCENTRATION").ToString
        Dim objTextMinConcentration As Object = Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGA_FICHEGRAL).Current("FGA_CONCENTRATION_MINI")
        Dim objTextMaxConcentration As Object = Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGA_FICHEGRAL).Current("FGA_CONCENTRATION_MAXI")
        Dim sLkupCDF As String = Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGA_FICHEGRAL).Current("FGA_CDF_UC_CODE_FK").ToString

        Dim dt61 As New DataTable
        dt61 = DsTheriaque_Grossesse_Allaitement.FGAON_OBSERVATION_NOUVEAUNE.Copy

        Dim dt62 As New DataTable
        dt62 = DsTheriaque_Grossesse_Allaitement.FGACFN_CIRCONSFAVORIS_NOUVEAUN.Copy

        Dim dt63 As New DataTable
        dt63 = DsTheriaque_Grossesse_Allaitement.FGATX2_FGA_TXOBSERVNOUVNE.Copy

        Dim dt71 As New DataTable
        dt71 = DsTheriaque_Grossesse_Allaitement.FGARIL_RISQUE_ALLAITEMENT.Copy

        Dim dt72 As New DataTable
        dt72 = DsTheriaque_Grossesse_Allaitement.FGATX8_FGA_TXRECOMMANDAT.Copy

        Dim dt81 As New DataTable
        dt81 = DsTheriaque_Grossesse_Allaitement.FGACA_CATALLAITEMENT.Copy

        'Dim dt82 As New DataTable
        'dt82 = DsTheriaque_Grossesse_Allaitement.FGAAFS_FGA_AFSSAPS.Copy

        Dim dt83 As New DataTable
        dt83 = DsTheriaque_Grossesse_Allaitement.FGATX6_FGA_TXCONDATENIRCA.Copy


        'Vider les contrôles
        EmptyDataTable()

        'Construction de la nouvelle fiche avec les données de la fiche de base
        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        SetCode_MAx(MasterTable, txtCode)
        CodE = InvalideControl


        Dim drTemp As DataRow
        For iCount As Integer = 0 To dt1.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGACPH_GRALCLPH").NewRow()
            drTemp.ItemArray = dt1.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGACPH_GRALCLPH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt2.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGACCH_GRALCLCH").NewRow()
            drTemp.ItemArray = dt2.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGACCH_GRALCLCH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt3.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGASAC_GRALSUBAC").NewRow()
            drTemp.ItemArray = dt3.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGASAC_GRALSUBAC").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt4.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGASAU_GRALSUBAU").NewRow()
            drTemp.ItemArray = dt4.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGASAU_GRALSUBAU").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt5.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGAPR_GRALPROD").NewRow()
            drTemp.ItemArray = dt5.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGAPR_GRALPROD").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt6.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGASP_GRALSPE").NewRow()
            drTemp.ItemArray = dt6.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGASP_GRALSPE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt11.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGAOA_OBSERVATION_ANIMALE").NewRow()
            drTemp.ItemArray = dt11.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGAOA_OBSERVATION_ANIMALE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt12.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGACFA_CIRCONSTFAVORIS_ANIMALE").NewRow()
            drTemp.ItemArray = dt12.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGACFA_CIRCONSTFAVORIS_ANIMALE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt13.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGATX1_FGA_TXOBSERVANI").NewRow()
            drTemp.ItemArray = dt13.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGATX1_FGA_TXOBSERVANI").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt14.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGARIA_RISQUE_ANIMALE").NewRow()
            drTemp.ItemArray = dt14.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGARIA_RISQUE_ANIMALE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt21.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGAPC_PERIODECRITIQUE_FGRAL").NewRow()
            drTemp.ItemArray = dt21.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGAPC_PERIODECRITIQUE_FGRAL").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt22.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGAOH_OBSERVATION_HUMAINE").NewRow()
            drTemp.ItemArray = dt22.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGAOH_OBSERVATION_HUMAINE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt23.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGACFH_CIRCONSTFAVORIS_HUMAINE").NewRow()
            drTemp.ItemArray = dt23.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGACFH_CIRCONSTFAVORIS_HUMAINE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt24.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGARIH_RISQUE_HUMAINE").NewRow()
            drTemp.ItemArray = dt24.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGARIH_RISQUE_HUMAINE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt25.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGATX3_FGA_TXOBSERVHUM").NewRow()
            drTemp.ItemArray = dt25.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGATX3_FGA_TXOBSERVHUM").Rows.Add(drTemp)
        Next

        If sRG_Effet <> "" Then RadioGroup1.SelectedIndex = sRG_Effet - 1

        For iCount As Integer = 0 To dt31.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGARIG_RISQUE_GROSSESSE").NewRow()
            drTemp.ItemArray = dt31.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGARIG_RISQUE_GROSSESSE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt32.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGATX7_FGA_TXRECOMMANDAT").NewRow()
            drTemp.ItemArray = dt32.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGATX7_FGA_TXRECOMMANDAT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt41.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGACF_CATFEMMEENCEINTE").NewRow()
            drTemp.ItemArray = dt41.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGACF_CATFEMMEENCEINTE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt42.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGATX4_FGA_TXCONDATENIRCF").NewRow()
            drTemp.ItemArray = dt42.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGATX4_FGA_TXCONDATENIRCF").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt43.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGACN_CATNOUVEAUNE").NewRow()
            drTemp.ItemArray = dt43.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGACN_CATNOUVEAUNE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt44.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGATX5_FGA_TXCONDATENIRCN").NewRow()
            drTemp.ItemArray = dt44.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGATX5_FGA_TXCONDATENIRCN").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt45.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGAAFS_FGA_AFSSAPS").NewRow()
            drTemp.ItemArray = dt45.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGAAFS_FGA_AFSSAPS").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt51.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGARIFAP_RISQUEFEMMEENAGE").NewRow()
            drTemp.ItemArray = dt51.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGARIFAP_RISQUEFEMMEENAGE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt52.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGATX9_FGA_TXRECOMMANDAT").NewRow()
            drTemp.ItemArray = dt52.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGATX9_FGA_TXRECOMMANDAT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt53.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGACFAP_CATFEMMEENAGE").NewRow()
            drTemp.ItemArray = dt53.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGACFAP_CATFEMMEENAGE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt54.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGATX10_FGA_TXRECOMMANDAT").NewRow()
            drTemp.ItemArray = dt54.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGATX10_FGA_TXRECOMMANDAT").Rows.Add(drTemp)
        Next

        'Onglet4
        If sPassageLait <> "" Then Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGA_FICHEGRAL).Current("FGA_PASSAGELAIT") = sPassageLait
        If sFixationPro <> "" Then Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGA_FICHEGRAL).Current("FGA_FIXATIONPROTEIQUE") = sFixationPro
        If objTextMinFixationPro IsNot DBNull.Value And objTextMinFixationPro IsNot Nothing Then Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGA_FICHEGRAL).Current("FGA_FIXATIONPROTEIQUE_MINI") = objTextMinFixationPro
        If objTextMaxFixationPro IsNot DBNull.Value And objTextMaxFixationPro IsNot Nothing Then Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGA_FICHEGRAL).Current("FGA_FIXATIONPROTEIQUE_MAXI") = objTextMaxFixationPro
        If sPlasmaLait <> "" Then Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGA_FICHEGRAL).Current("FGA_PLASMALAIT") = sPlasmaLait
        If objTextMinPlasmaLait IsNot DBNull.Value And objTextMinPlasmaLait IsNot Nothing Then Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGA_FICHEGRAL).Current("FGA_PLASMALAIT_MINI") = objTextMinPlasmaLait
        If objTextMaxPlasmaLait IsNot DBNull.Value And objTextMaxPlasmaLait IsNot Nothing Then Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGA_FICHEGRAL).Current("FGA_PLASMALAIT_MAXI") = objTextMaxPlasmaLait
        If sConcentration <> "" Then Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGA_FICHEGRAL).Current("FGA_CONCENTRATION") = sConcentration
        If objTextMinConcentration IsNot DBNull.Value And objTextMinConcentration IsNot Nothing Then Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGA_FICHEGRAL).Current("FGA_CONCENTRATION_MINI") = objTextMinConcentration
        If objTextMaxConcentration IsNot DBNull.Value And objTextMaxConcentration IsNot Nothing Then Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGA_FICHEGRAL).Current("FGA_CONCENTRATION_MAXI") = objTextMaxConcentration
        If sLkupCDF <> "" Then Me.BindingContext(DsTheriaque_Grossesse_Allaitement, FGA_FICHEGRAL).Current("FGA_CDF_UC_CODE_FK") = sLkupCDF


        For iCount As Integer = 0 To dt61.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGAON_OBSERVATION_NOUVEAUNE").NewRow()
            drTemp.ItemArray = dt61.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGAON_OBSERVATION_NOUVEAUNE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt62.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGACFN_CIRCONSFAVORIS_NOUVEAUN").NewRow()
            drTemp.ItemArray = dt62.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGACFN_CIRCONSFAVORIS_NOUVEAUN").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt63.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGATX2_FGA_TXOBSERVNOUVNE").NewRow()
            drTemp.ItemArray = dt63.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGATX2_FGA_TXOBSERVNOUVNE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt71.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGARIL_RISQUE_ALLAITEMENT").NewRow()
            drTemp.ItemArray = dt71.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGARIL_RISQUE_ALLAITEMENT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt72.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGATX8_FGA_TXRECOMMANDAT").NewRow()
            drTemp.ItemArray = dt72.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGATX8_FGA_TXRECOMMANDAT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt81.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGACA_CATALLAITEMENT").NewRow()
            drTemp.ItemArray = dt81.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGACA_CATALLAITEMENT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt83.Rows.Count - 1
            drTemp = DsTheriaque_Grossesse_Allaitement.Tables("FGATX6_FGA_TXCONDATENIRCA").NewRow()
            drTemp.ItemArray = dt83.Rows(iCount).ItemArray
            DsTheriaque_Grossesse_Allaitement.Tables("FGATX6_FGA_TXCONDATENIRCA").Rows.Add(drTemp)
        Next

        ModifierCode()
        bModeDuplication = True
        MyBase.Dupliquer()
        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        ComboBoxEdit2_SelectedIndexChanged(Nothing, Nothing)
        ComboBoxEdit3_SelectedIndexChanged(Nothing, Nothing)
        ComboBoxEdit4_SelectedIndexChanged(Nothing, Nothing)
        XtraTabControl1.SelectedTabPageIndex = 0
    End Sub

    ''' <summary>
    ''' Proçédure: Modifier code Master de la fiche
    ''' </summary>
    Private Sub ModifierCode()
        'GV1
        For iCount As Integer = 0 To GV1.RowCount - 1
            GV1.SetRowCellValue(iCount, colFGACPH_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV2
        For iCount As Integer = 0 To GV2.RowCount - 1
            GV2.SetRowCellValue(iCount, colFGACCH_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV3
        For iCount As Integer = 0 To GV3.RowCount - 1
            GV3.SetRowCellValue(iCount, colFGASAC_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV4
        For iCount As Integer = 0 To GV4.RowCount - 1
            GV4.SetRowCellValue(iCount, colFGASAU_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV5
        For iCount As Integer = 0 To GV5.RowCount - 1
            GV5.SetRowCellValue(iCount, colFGAPR_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV6
        For iCount As Integer = 0 To GV6.RowCount - 1
            GV6.SetRowCellValue(iCount, colFGASP_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV11
        For iCount As Integer = 0 To GV11.RowCount - 1
            GV11.SetRowCellValue(iCount, colFGAOA_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV12
        For iCount As Integer = 0 To GV12.RowCount - 1
            GV12.SetRowCellValue(iCount, colFGACFA_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV13
        For iCount As Integer = 0 To GV13.RowCount - 1
            GV13.SetRowCellValue(iCount, colFGATX1_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV14
        For iCount As Integer = 0 To GV14.RowCount - 1
            GV14.SetRowCellValue(iCount, colFGARIA_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV21
        For iCount As Integer = 0 To GV21.RowCount - 1
            GV21.SetRowCellValue(iCount, colFGAPC_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV22
        For iCount As Integer = 0 To GV22.RowCount - 1
            GV22.SetRowCellValue(iCount, colFGAOH_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV23
        For iCount As Integer = 0 To GV23.RowCount - 1
            GV23.SetRowCellValue(iCount, colFGACFH_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV24
        For iCount As Integer = 0 To GV24.RowCount - 1
            GV24.SetRowCellValue(iCount, colFGARIH_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV25
        For iCount As Integer = 0 To GV25.RowCount - 1
            GV25.SetRowCellValue(iCount, colFGATX3_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV31
        For iCount As Integer = 0 To GV31.RowCount - 1
            GV31.SetRowCellValue(iCount, colFGARIG_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV32
        For iCount As Integer = 0 To GV32.RowCount - 1
            GV32.SetRowCellValue(iCount, colFGATX7_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV41
        For iCount As Integer = 0 To GV41.RowCount - 1
            GV41.SetRowCellValue(iCount, colFGACF_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV42
        For iCount As Integer = 0 To GV42.RowCount - 1
            GV42.SetRowCellValue(iCount, colFGATX4_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV43
        For iCount As Integer = 0 To GV43.RowCount - 1
            GV43.SetRowCellValue(iCount, colFGACN_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV44
        For iCount As Integer = 0 To GV44.RowCount - 1
            GV44.SetRowCellValue(iCount, colFGATX5_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV45
        For iCount As Integer = 0 To GV45.RowCount - 1
            GV45.SetRowCellValue(iCount, colFGAAFS_FGA_CODE_FK_PK1, Me.txtCode.Text)
        Next
        'GV51
        For iCount As Integer = 0 To GV51.RowCount - 1
            GV51.SetRowCellValue(iCount, colFGARIFAP_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV52
        For iCount As Integer = 0 To GV52.RowCount - 1
            GV52.SetRowCellValue(iCount, colFGATX9_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV53
        For iCount As Integer = 0 To GV53.RowCount - 1
            GV53.SetRowCellValue(iCount, colFGACFAP_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV54
        For iCount As Integer = 0 To GV54.RowCount - 1
            GV54.SetRowCellValue(iCount, colFGATX10_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV61
        For iCount As Integer = 0 To GV61.RowCount - 1
            GV61.SetRowCellValue(iCount, colFGAON_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV62
        For iCount As Integer = 0 To GV62.RowCount - 1
            GV62.SetRowCellValue(iCount, colFGACFN_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV63
        For iCount As Integer = 0 To GV63.RowCount - 1
            GV63.SetRowCellValue(iCount, colFGATX2_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV71
        For iCount As Integer = 0 To GV71.RowCount - 1
            GV71.SetRowCellValue(iCount, colFGARIL_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV72
        For iCount As Integer = 0 To GV72.RowCount - 1
            GV72.SetRowCellValue(iCount, colFGATX8_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV81
        For iCount As Integer = 0 To GV81.RowCount - 1
            GV81.SetRowCellValue(iCount, colFGACA_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV82
        For iCount As Integer = 0 To GV82.RowCount - 1
            GV82.SetRowCellValue(iCount, colFGAAFS_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV83
        For iCount As Integer = 0 To GV83.RowCount - 1
            GV83.SetRowCellValue(iCount, colFGATX6_FGA_CODE_FK_PK, Me.txtCode.Text)
        Next
    End Sub

#End Region

#Region " Init Data  "

    Private Sub InitDataSource()
        'Onglet Entités
        GC1.DataSource = DsTheriaque_Grossesse_Allaitement
        GC1.DataMember = FGACPH_GRALCLPH

        GC2.DataSource = DsTheriaque_Grossesse_Allaitement
        GC2.DataMember = FGACCH_GRALCLCH

        GC3.DataSource = DsTheriaque_Grossesse_Allaitement
        GC3.DataMember = FGASAC_GRALSUBAC

        GC4.DataSource = DsTheriaque_Grossesse_Allaitement
        GC4.DataMember = FGASAU_GRALSUBAU

        GC5.DataSource = DsTheriaque_Grossesse_Allaitement
        GC5.DataMember = FGAPR_GRALPROD

        GC6.DataSource = DsTheriaque_Grossesse_Allaitement
        GC6.DataMember = FGASP_GRALSPE

        'Onglet Grossesse - Données expérimentales
        GC11.DataSource = DsTheriaque_Grossesse_Allaitement
        GC11.DataMember = FGAOA_OBSERVATION_ANIMALE

        GC12.DataSource = DsTheriaque_Grossesse_Allaitement
        GC12.DataMember = FGACFA_CIRCONSTFAVORIS_ANIMALE

        GC13.DataSource = DsTheriaque_Grossesse_Allaitement
        GC13.DataMember = FGATX1_FGA_TXOBSERVANI

        GC14.DataSource = DsTheriaque_Grossesse_Allaitement
        GC14.DataMember = FGARIA_RISQUE_ANIMALE

        'Onglet Grossesse - Données clinique
        GC21.DataSource = DsTheriaque_Grossesse_Allaitement
        GC21.DataMember = FGAPC_PERIODECRITIQUE_FGRAL

        GC22.DataSource = DsTheriaque_Grossesse_Allaitement
        GC22.DataMember = FGAOH_OBSERVATION_HUMAINE

        GC23.DataSource = DsTheriaque_Grossesse_Allaitement
        GC23.DataMember = FGACFH_CIRCONSTFAVORIS_HUMAINE

        GC24.DataSource = DsTheriaque_Grossesse_Allaitement
        GC24.DataMember = FGARIH_RISQUE_HUMAINE

        GC25.DataSource = DsTheriaque_Grossesse_Allaitement
        GC25.DataMember = FGATX3_FGA_TXOBSERVHUM
        'Onglet Grossesse - Recommandations
        GC31.DataSource = DsTheriaque_Grossesse_Allaitement
        GC31.DataMember = FGARIG_RISQUE_GROSSESSE

        GC32.DataSource = DsTheriaque_Grossesse_Allaitement
        GC32.DataMember = FGATX7_FGA_TXRECOMMANDAT

        'Onglet Grossesse - Conduite à tenir
        GC41.DataSource = DsTheriaque_Grossesse_Allaitement
        GC41.DataMember = FGACF_CATFEMMEENCEINTE

        GC42.DataSource = DsTheriaque_Grossesse_Allaitement
        GC42.DataMember = FGATX4_FGA_TXCONDATENIRCF

        GC43.DataSource = DsTheriaque_Grossesse_Allaitement
        GC43.DataMember = FGACN_CATNOUVEAUNE

        GC44.DataSource = DsTheriaque_Grossesse_Allaitement
        GC44.DataMember = FGATX5_FGA_TXCONDATENIRCN

        GC45.DataSource = DsTheriaque_Grossesse_Allaitement
        GC45.DataMember = FGAAFS_FGA_AFSSAPS

        'Onglet Femme en âge de procréer
        GC51.DataSource = DsTheriaque_Grossesse_Allaitement
        GC51.DataMember = FGARIFAP_RISQUEFEMMEENAGE

        GC52.DataSource = DsTheriaque_Grossesse_Allaitement
        GC52.DataMember = FGATX9_FGA_TXRECOMMANDAT

        GC53.DataSource = DsTheriaque_Grossesse_Allaitement
        GC53.DataMember = FGACFAP_CATFEMMEENAGE

        GC54.DataSource = DsTheriaque_Grossesse_Allaitement
        GC54.DataMember = FGATX10_FGA_TXRECOMMANDAT

        'Onglet Allaitement
        GC61.DataSource = DsTheriaque_Grossesse_Allaitement
        GC61.DataMember = FGAON_OBSERVATION_NOUVEAUNE

        GC62.DataSource = DsTheriaque_Grossesse_Allaitement
        GC62.DataMember = FGACFN_CIRCONSFAVORIS_NOUVEAUN

        GC63.DataSource = DsTheriaque_Grossesse_Allaitement
        GC63.DataMember = FGATX2_FGA_TXOBSERVNOUVNE

        GC71.DataSource = DsTheriaque_Grossesse_Allaitement
        GC71.DataMember = FGARIL_RISQUE_ALLAITEMENT

        GC72.DataSource = DsTheriaque_Grossesse_Allaitement
        GC72.DataMember = FGATX8_FGA_TXRECOMMANDAT

        GC81.DataSource = DsTheriaque_Grossesse_Allaitement
        GC81.DataMember = FGACA_CATALLAITEMENT

        GC82.DataSource = DsTheriaque_Grossesse_Allaitement
        GC82.DataMember = FGAAFS_FGA_AFSSAPS

        GC83.DataSource = DsTheriaque_Grossesse_Allaitement
        GC83.DataMember = FGATX6_FGA_TXCONDATENIRCA

    End Sub
    Public Overrides Sub InitData()
        MyBase.InitData()
        OnLoading = True
        Declinaison_Global = True
        MasterDataSet = Me.DsTheriaque_Grossesse_Allaitement
        MasterTable = FGA_FICHEGRAL
        CodE = InvalideControl

        'Déclinaison classe CPH
        Dim List1 As New System.Collections.Generic.List(Of StructGVTable)
        List1.Add(New StructGVTable("GC1", eDeclinaison.CPH, colFGACPH_CPH_CODE_FK_PK))
        List1.Add(New StructGVTable("GC2", eDeclinaison.CCH, colFGACCH_CCH_CODE_FK_PK))
        List1.Add(New StructGVTable("GC3", eDeclinaison.SAC, colFGASAC_SAC_CODE_FK_PK))
        List1.Add(New StructGVTable("GC6", eDeclinaison.SP, colFGASP_SP_CODE_FK_PK))
        Dim DecCPH As New ClsDeclinaison(eDeclinaison.CPH, List1)
        InitLkup(Me.rp_FGACPH, FGACPH_GRALCLPH, strSSQL_CPH_CLASSEPHARMTHER_NIVEAU, True, , , , , , DecCPH)

        'Déclinaison classe CCH
        Dim List2 As New System.Collections.Generic.List(Of StructGVTable)
        List2.Add(New StructGVTable("GC1", eDeclinaison.CPH, colFGACPH_CPH_CODE_FK_PK))
        List2.Add(New StructGVTable("GC2", eDeclinaison.CCH, colFGACCH_CCH_CODE_FK_PK))
        List2.Add(New StructGVTable("GC3", eDeclinaison.SAC, colFGASAC_SAC_CODE_FK_PK))
        List2.Add(New StructGVTable("GC6", eDeclinaison.SP, colFGASP_SP_CODE_FK_PK))
        List2.Add(New StructGVTable("GC4", eDeclinaison.SAU, colFGASAU_SAU_CODE_FK_PK))
        Dim DecCCH As New ClsDeclinaison(eDeclinaison.CCH, List2)
        InitLkup(Me.rp_FGACCH, FGACCH_GRALCLCH, strSSQL_CCH_CLASSECHIMIQUE_NIVEAU, True, , , , , , DecCCH)

        'Déclinaison SUBAC
        Dim List3 As New System.Collections.Generic.List(Of StructGVTable)
        List3.Add(New StructGVTable("GC3", eDeclinaison.SAC, colFGASAC_SAC_CODE_FK_PK))
        List3.Add(New StructGVTable("GC6", eDeclinaison.SP, colFGASP_SP_CODE_FK_PK))
        Dim DecSUBAC As New ClsDeclinaison(eDeclinaison.SAC, List3)
        InitLkup(Me.rp_FGASAC, FGASAC_GRALSUBAC, strSSQL_SAC_SUBACTIVE, True, , , , , , DecSUBAC)

        'Déclinaison SAU
        Dim List4 As New System.Collections.Generic.List(Of StructGVTable)
        List4.Add(New StructGVTable("GC4", eDeclinaison.SAU, colFGASAU_SAU_CODE_FK_PK))
        List4.Add(New StructGVTable("GC6", eDeclinaison.SP, colFGASP_SP_CODE_FK_PK))
        Dim DecSAU As New ClsDeclinaison(eDeclinaison.SAU, List4)
        InitLkup(Me.rp_FGASAU, FGASAU_GRALSUBAU, strSSQL_SAU_SUBAUXILIAIRE, True, , , , , , DecSAU)

        'Déclinaison PRODUIT
        Dim List5 As New System.Collections.Generic.List(Of StructGVTable)
        List5.Add(New StructGVTable("GC5", eDeclinaison.PR, colFGAPR_PR_CODE_FK_PK))
        List5.Add(New StructGVTable("GC6", eDeclinaison.SP, colFGASP_SP_CODE_FK_PK))
        Dim DecPR As New ClsDeclinaison(eDeclinaison.PR, List5)
        InitLkup(Me.rp_FGAPR, FGAPR_GRALPROD, strSSQL_PR_PRODUIT, True, , , , , , DecPR)

        InitLkup(Me.rp_FGASP_FGA, FGASP_GRALSPE, strSSQL_SP_SPECIALITE, True)
        InitDataSource()
        FirstFocus = txtCode
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
    Private Sub Open_Fiche(ByVal CodE1 As Integer)
        OnLoading = True
        CodE = _Code
        EmptyDataTable()
        Me.FgA_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGA_FICHEGRAL, CodE1)

        'Onglet Entités
        Me.FgacpH_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGACPH_GRALCLPH, CodE1)
        Me.FgaccH_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGACCH_GRALCLCH, CodE1)
        Me.FgasaU_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGASAU_GRALSUBAU, CodE1)
        Me.FgasaC_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGASAC_GRALSUBAC, CodE1)
        Me.FgapR_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGAPR_GRALPROD, CodE1)
        Me.FgasP_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGASP_GRALSPE, CodE1)

        Tab_TA1 = False
        Tab_TA2 = False
        Tab_TA3 = False

        OnLoading = False
    End Sub

#End Region

#Region " Chargement par onglet "

    Private Sub LoadTab_1()
        Load_On(Me)
        OnLoading = True
        If CodE <> InvalideControl And CodE <> Nothing Then
            Dim strSSQL_SP_REF As String
            strSSQL_SP_REF = " SELECT SP_CODE_SQ_PK as code, SP_NOM as libelle FROM THERIAQUE.FGASP_GRALSPE, THERIAQUE.SP_SPECIALITE"
            strSSQL_SP_REF &= " WHERE FGASP_FGA_CODE_FK_PK = " & CodE
            strSSQL_SP_REF &= " AND SP_CODE_SQ_PK = FGASP_SP_CODE_FK_PK"
            InitLkup(Me.rp_FGAAFS1_SP, FGAAFS_FGA_AFSSAPS, strSSQL_SP_REF, True)
            For iCount As Integer = 0 To GV45.RowCount
                If GV45.GetRowCellDisplayText(iCount, "FGAAFS_SP_CODE_FK_PK") = "" And GV45.GetRowCellDisplayText(iCount, "FGAAFS_FGA_CODE_FK_PK") <> "" Then
                    GV45.DeleteRow(iCount)
                    iCount = iCount - 1
                End If
            Next
        End If
        If Not Tab_lkup1 Then
            InitLkup(Me.rp_FGAOA, FGAOA_OBSERVATION_ANIMALE, strSSQL_CDF_CODIF_NIVEAU("GO"), True)
            InitLkup(Me.rp_FGACFA, FGACFA_CIRCONSTFAVORIS_ANIMALE, strSSQL_CDF_CODIF("GC"), True)
            InitLkup(Me.rp_FGARIA, FGARIA_RISQUE_ANIMALE, strSSQL_CDF_CODIF("GR", " and substring(CDF_CODE_PK, 1, 1) =  'E'"), True)
            'Onglet Grossesse - Données clinique
            InitLkup(Me.rp_FGAPC, FGAPC_PERIODECRITIQUE_FGRAL, strSSQL_CDF_CODIF("GP"), True)
            InitLkup(Me.rp_FGAOH, FGAOH_OBSERVATION_HUMAINE, strSSQL_CDF_CODIF_NIVEAU("GO"), True)
            InitLkup(Me.rp_FGACFH, FGACFH_CIRCONSTFAVORIS_HUMAINE, strSSQL_CDF_CODIF("GC"), True)
            InitLkup(Me.rp_FGARIH, FGARIH_RISQUE_HUMAINE, strSSQL_CDF_CODIF("GR", " and substring(CDF_CODE_PK, 1, 1) =  'H'"), True)
            'Onglet Grossesse - Recommandations
            InitLkup(Me.rp_FGARIG_CDF_TC, FGARIG_RISQUE_GROSSESSE, strSSQL_CDF_CODIF("GP"), True)
            InitLkup(Me.rp_FGARIG_CDF_RI, FGARIG_RISQUE_GROSSESSE, strSSQL_CDF_CODIF("GR", " and substring(CDF_CODE_PK, 1, 1) IN('R','C', 'P', 'Z')"), True)

            'Onglet Grossesse - Conduite à tenir
            InitLkup(Me.rp_FGACF, FGACF_CATFEMMEENCEINTE, strSSQL_CDF_CODIF("GT"), True)
            InitLkup(Me.rp_FGACN, FGACN_CATNOUVEAUNE, strSSQL_CDF_CODIF("GT"), True)
            InitLkup(Me.rp_FGAAFS1, FGAAFS_FGA_AFSSAPS, strSSQL_CDF_CODIF("25"), True)

            Tab_lkup1 = True
        End If
        If Not Tab_TA1 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.FgaoA_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGAOA_OBSERVATION_ANIMALE, CodE)
            Me.FgacfA_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGACFA_CIRCONSTFAVORIS_ANIMALE, CodE)
            Me.FgatX1_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGATX1_FGA_TXOBSERVANI, CodE)
            Me.FgariA_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGARIA_RISQUE_ANIMALE, CodE)
            'Onglet Grossesse - Données clinique
            Me.FgapC_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGAPC_PERIODECRITIQUE_FGRAL, CodE)
            Me.FgaoH_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGAOH_OBSERVATION_HUMAINE, CodE)
            Me.FgacfH_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGACFH_CIRCONSTFAVORIS_HUMAINE, CodE)
            Me.FgariH_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGARIH_RISQUE_HUMAINE, CodE)
            Me.FgatX3_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGATX3_FGA_TXOBSERVHUM, CodE)
            'Onglet Grossesse - Recommandations
            Me.FgariG_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGARIG_RISQUE_GROSSESSE, CodE)
            Me.FgatX7_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGATX7_FGA_TXRECOMMANDAT, CodE)

            'Onglet Grossesse - Conduite à tenir
            Me.FgacF_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGACF_CATFEMMEENCEINTE, CodE)
            Me.FgatX4_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGATX4_FGA_TXCONDATENIRCF, CodE)
            Me.FgacN_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGACN_CATNOUVEAUNE, CodE)
            Me.FgatX5_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGATX5_FGA_TXCONDATENIRCN, CodE)
            Me.FgaafS_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGAAFS_FGA_AFSSAPS, CodE)
            'Filtre
            colFGAAFS_TYPEGRAL_PK1.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("FGAAFS_TYPEGRAL_PK = 'G'")


            Tab_TA1 = True
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub
    Private Sub LoadTab_2()
        'Onglet Femme en âge de procréer
        Load_On(Me)
        OnLoading = True
        If Not Tab_lkup2 Then
            InitLkup(Me.rp_FGARIFAP, FGARIFAP_RISQUEFEMMEENAGE, strSSQL_CDF_CODIF("GR", " and substring(CDF_CODE_PK, 1, 1) IN('R','C', 'P', 'Z')"), True)
            InitLkup(Me.rp_FGACFAP, FGACFAP_CATFEMMEENAGE, strSSQL_CDF_CODIF("GT"), True)
            Tab_lkup2 = True
        End If
        If Not Tab_TA2 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.FgarifaP_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGARIFAP_RISQUEFEMMEENAGE, CodE)
            Me.FgacfaP_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGACFAP_CATFEMMEENAGE, CodE)
            Me.FgatX9_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGATX9_FGA_TXRECOMMANDAT, CodE)
            Me.FgatX10_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGATX10_FGA_TXRECOMMANDAT, CodE)
            Tab_TA2 = True
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub
    Private Sub LoadTab_3()
        'Onglet Allaitement
        Load_On(Me)
        OnLoading = True
        If CodE <> InvalideControl And CodE <> Nothing Then
            Dim strSSQL_SP_REF As String
            strSSQL_SP_REF = " SELECT SP_CODE_SQ_PK as code, SP_NOM as libelle FROM THERIAQUE.FGASP_GRALSPE, THERIAQUE.SP_SPECIALITE"
            strSSQL_SP_REF &= " WHERE FGASP_FGA_CODE_FK_PK = " & CodE
            strSSQL_SP_REF &= " AND SP_CODE_SQ_PK = FGASP_SP_CODE_FK_PK"
            InitLkup(Me.rp_FGAAFS_SP, FGAAFS_FGA_AFSSAPS, strSSQL_SP_REF, True)
            For iCount As Integer = 0 To GV82.RowCount
                If GV82.GetRowCellDisplayText(iCount, "FGAAFS_SP_CODE_FK_PK") = "" And GV82.GetRowCellDisplayText(iCount, "FGAAFS_FGA_CODE_FK_PK") <> "" Then
                    GV82.DeleteRow(iCount)
                    iCount = iCount - 1
                End If
            Next
        End If
        If Not Tab_lkup3 Then
            InitLkup(Me.lkupFGA_CDF, FGA_FICHEGRAL, strSSQL_CDF_CODIF("19"), True)
            InitLkup(Me.rp_FGAON, FGAON_OBSERVATION_NOUVEAUNE, strSSQL_CDF_CODIF_NIVEAU("GO"), True)
            InitLkup(Me.rp_FGACFN, FGACFN_CIRCONSFAVORIS_NOUVEAUN, strSSQL_CDF_CODIF("GC"), True)
            InitLkup(Me.rp_FGARIL, FGARIL_RISQUE_ALLAITEMENT, strSSQL_CDF_CODIF("GR", " and substring(CDF_CODE_PK, 1, 1) IN('R','C', 'P', 'Z')"), True)
            InitLkup(Me.rp_FGACA, FGACA_CATALLAITEMENT, strSSQL_CDF_CODIF("GT"), True)
            InitLkup(Me.rp_FGAAFS, FGAAFS_FGA_AFSSAPS, strSSQL_CDF_CODIF("25"), True)
            Tab_lkup3 = True
        End If
        If Not Tab_TA3 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.FgA_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGA_FICHEGRAL, CodE)
            Me.FgaoN_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGAON_OBSERVATION_NOUVEAUNE, CodE)
            Me.FgacfN_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGACFN_CIRCONSFAVORIS_NOUVEAUN, CodE)
            Me.FgatX2_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGATX2_FGA_TXOBSERVNOUVNE, CodE)
            Me.FgariL_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGARIL_RISQUE_ALLAITEMENT, CodE)
            Me.FgatX8_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGATX8_FGA_TXRECOMMANDAT, CodE)
            Me.FgacA_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGACA_CATALLAITEMENT, CodE)
            Me.FgatX6_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGATX6_FGA_TXCONDATENIRCA, CodE)
            Me.FgaafS_TA.FillByCode(Me.DsTheriaque_Grossesse_Allaitement.FGAAFS_FGA_AFSSAPS, CodE)
            'Filtre
            colFGAAFS_TYPEGRAL_PK.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("FGAAFS_TYPEGRAL_PK = 'A'")
            Tab_TA3 = True
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPageIndex = 1 Then
            LoadTab_1()
            Exit Sub
        End If
        If XtraTabControl1.SelectedTabPageIndex = 2 Then
            LoadTab_2()
            Exit Sub
        End If
        If XtraTabControl1.SelectedTabPageIndex = 3 Then
            LoadTab_3()
            Exit Sub
        End If
    End Sub

#End Region

#Region " New Row    "

    Private Sub GV1_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV1.InitNewRow
        If OnLoading Then Exit Sub
        GV1.SetFocusedRowCellValue(colFGACPH_FGA_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        If OnLoading Then Exit Sub
        GV2.SetFocusedRowCellValue(colFGACCH_FGA_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV3_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV3.InitNewRow
        If OnLoading Then Exit Sub
        GV3.SetFocusedRowCellValue(colFGASAC_FGA_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV4_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV4.InitNewRow
        If OnLoading Then Exit Sub
        GV4.SetFocusedRowCellValue(colFGASAU_FGA_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV5_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV5.InitNewRow
        If OnLoading Then Exit Sub
        GV5.SetFocusedRowCellValue(colFGAPR_FGA_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV6_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV6.InitNewRow
        If OnLoading Then Exit Sub
        GV6.SetFocusedRowCellValue(colFGASP_FGA_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV11_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV11.InitNewRow
        If OnLoading Then Exit Sub
        GV11.SetFocusedRowCellValue(colFGAOA_FGA_CODE_FK_PK, txtCode.Text)
        GV11.SetFocusedRowCellValue(colFGAOA_NUMORD, Code_MAx(GV11, colFGAOA_NUMORD))
    End Sub
    Private Sub GV12_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV12.InitNewRow
        If OnLoading Then Exit Sub
        GV12.SetFocusedRowCellValue(colFGACFA_FGA_CODE_FK_PK, txtCode.Text)
        GV12.SetFocusedRowCellValue(colFGACFA_NUMORD, Code_MAx(GV12, colFGACFA_NUMORD))
    End Sub
    Private Sub GV13_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV13.InitNewRow
        If OnLoading Then Exit Sub
        GV13.SetFocusedRowCellValue(colFGATX1_FGA_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV14_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV14.InitNewRow
        If OnLoading Then Exit Sub
        GV14.SetFocusedRowCellValue(colFGARIA_FGA_CODE_FK_PK, txtCode.Text)
        GV14.SetFocusedRowCellValue(colFGARIA_NUMORD, Code_MAx(GV14, colFGARIA_NUMORD))
    End Sub
    Private Sub GV21_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV21.InitNewRow
        If OnLoading Then Exit Sub
        GV21.SetFocusedRowCellValue(colFGAPC_FGA_CODE_FK_PK, txtCode.Text)
        GV21.SetFocusedRowCellValue(colFGAPC_NUMORD, Code_MAx(GV21, colFGAPC_NUMORD))
    End Sub
    Private Sub GV22_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV22.InitNewRow
        If OnLoading Then Exit Sub
        GV22.SetFocusedRowCellValue(colFGAOH_FGA_CODE_FK_PK, txtCode.Text)
        GV22.SetFocusedRowCellValue(colFGAOH_NUMORD, Code_MAx(GV22, colFGAOH_NUMORD))
    End Sub
    Private Sub GV23_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV23.InitNewRow
        If OnLoading Then Exit Sub
        GV23.SetFocusedRowCellValue(colFGACFH_FGA_CODE_FK_PK, txtCode.Text)
        GV23.SetFocusedRowCellValue(colFGACFH_NUMORD, Code_MAx(GV23, colFGACFH_NUMORD))
    End Sub
    Private Sub GV24_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV24.InitNewRow
        If OnLoading Then Exit Sub
        GV24.SetFocusedRowCellValue(colFGARIH_FGA_CODE_FK_PK, txtCode.Text)
        GV24.SetFocusedRowCellValue(colFGARIH_NUMORD, Code_MAx(GV24, colFGARIH_NUMORD))
    End Sub
    Private Sub GV25_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV25.InitNewRow
        If OnLoading Then Exit Sub
        GV25.SetFocusedRowCellValue(colFGATX3_FGA_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV31_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV31.InitNewRow
        If OnLoading Then Exit Sub
        GV31.SetFocusedRowCellValue(colFGARIG_FGA_CODE_FK_PK, txtCode.Text)
        GV31.SetFocusedRowCellValue(colFGARIG_NUMORD, Code_MAx(GV31, colFGARIG_NUMORD))
        GV31.SetFocusedRowCellValue(colFGARIG_NUMSEQ_PK, Code_MAx(GV31, colFGARIG_NUMSEQ_PK))
    End Sub
    Private Sub GV32_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV32.InitNewRow
        If OnLoading Then Exit Sub
        GV32.SetFocusedRowCellValue(colFGATX7_FGA_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV41_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV41.InitNewRow
        If OnLoading Then Exit Sub
        GV41.SetFocusedRowCellValue(colFGACF_FGA_CODE_FK_PK, txtCode.Text)
        GV41.SetFocusedRowCellValue(colFGACF_NUMORD, Code_MAx(GV41, colFGACF_NUMORD))
    End Sub
    Private Sub GV43_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV43.InitNewRow
        If OnLoading Then Exit Sub
        GV43.SetFocusedRowCellValue(colFGACN_FGA_CODE_FK_PK, txtCode.Text)
        GV43.SetFocusedRowCellValue(colFGACN_NUMORD, Code_MAx(GV43, colFGACN_NUMORD))
    End Sub
    Private Sub GV44_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV44.InitNewRow
        If OnLoading Then Exit Sub
        GV44.SetFocusedRowCellValue(colFGATX5_FGA_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV42_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV42.InitNewRow
        If OnLoading Then Exit Sub
        GV42.SetFocusedRowCellValue(colFGATX4_FGA_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV51_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV51.InitNewRow
        If OnLoading Then Exit Sub
        GV51.SetFocusedRowCellValue(colFGARIFAP_FGA_CODE_FK_PK, txtCode.Text)
        GV51.SetFocusedRowCellValue(colFGARIFAP_NUMORD, Code_MAx(GV51, colFGARIFAP_NUMORD))
    End Sub
    Private Sub GV53_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV53.InitNewRow
        If OnLoading Then Exit Sub
        GV53.SetFocusedRowCellValue(colFGACFAP_FGA_CODE_FK_PK, txtCode.Text)
        GV53.SetFocusedRowCellValue(colFGACFAP_NUMORD, Code_MAx(GV53, colFGACFAP_NUMORD))
    End Sub
    Private Sub GV52_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV52.InitNewRow
        If OnLoading Then Exit Sub
        GV52.SetFocusedRowCellValue(colFGATX9_FGA_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV54_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV54.InitNewRow
        If OnLoading Then Exit Sub
        GV54.SetFocusedRowCellValue(colFGATX10_FGA_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV61_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV61.InitNewRow
        If OnLoading Then Exit Sub
        GV61.SetFocusedRowCellValue(colFGAON_FGA_CODE_FK_PK, txtCode.Text)
        GV61.SetFocusedRowCellValue(colFGAON_NUMORD, Code_MAx(GV61, colFGAON_NUMORD))
    End Sub
    Private Sub GV62_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV62.InitNewRow
        If OnLoading Then Exit Sub
        GV62.SetFocusedRowCellValue(colFGACFN_FGA_CODE_FK_PK, txtCode.Text)
        GV62.SetFocusedRowCellValue(colFGACFN_NUMORD, Code_MAx(GV62, colFGACFN_NUMORD))
    End Sub
    Private Sub GV63_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV63.InitNewRow
        If OnLoading Then Exit Sub
        GV63.SetFocusedRowCellValue(colFGATX2_FGA_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV71_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV71.InitNewRow
        If OnLoading Then Exit Sub
        GV71.SetFocusedRowCellValue(colFGARIL_FGA_CODE_FK_PK, txtCode.Text)
        GV71.SetFocusedRowCellValue(colFGARIL_NUMORD, Code_MAx(GV71, colFGARIL_NUMORD))
    End Sub
    Private Sub GV72_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV72.InitNewRow
        If OnLoading Then Exit Sub
        GV72.SetFocusedRowCellValue(colFGATX8_FGA_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV81_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV81.InitNewRow
        If OnLoading Then Exit Sub
        GV81.SetFocusedRowCellValue(colFGACA_FGA_CODE_FK_PK, txtCode.Text)
        GV81.SetFocusedRowCellValue(colFGACA_NUMORD, Code_MAx(GV81, colFGACA_NUMORD))
    End Sub
    Private Sub GV83_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV83.InitNewRow
        If OnLoading Then Exit Sub
        GV83.SetFocusedRowCellValue(colFGATX6_FGA_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV_RowCountChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV13.RowCountChanged, GV25.RowCountChanged, GV32.RowCountChanged, GV42.RowCountChanged, GV44.RowCountChanged, GV52.RowCountChanged, GV54.RowCountChanged, GV63.RowCountChanged, GV72.RowCountChanged, GV83.RowCountChanged
        If sender.RowCount >= 1 Then
            sender.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
            sender.GridControl.EmbeddedNavigator.Buttons.Append.Enabled = False
        Else
            sender.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            sender.GridControl.EmbeddedNavigator.Buttons.Append.Enabled = False
        End If
    End Sub
   

#End Region

#Region " Panel "

    Private Sub Panel4_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel4.Resize
        GC1.Width = Panel4.Width / 2
        GC2.Width = Panel4.Width / 2
    End Sub
    Private Sub Panel6_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel6.Resize
        GC3.Width = Panel6.Width / 2
        GC4.Width = Panel6.Width / 2
    End Sub
    Private Sub Panel7_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel7.Resize
        GC5.Width = Panel7.Width / 2
        GC6.Width = Panel7.Width / 2
    End Sub
    Private Sub Panel42_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel42.Resize
        GC61.Width = Panel42.Width / 2
        GC62.Width = Panel42.Width / 2
    End Sub
    Private Sub XtraTabControl1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraTabControl1.Resize
        Panel4.Height = XtraTabControl1.Height / 3
        Panel6.Height = XtraTabControl1.Height / 3
        Panel7.Height = XtraTabControl1.Height / 3

        GroupControl1.Height = XtraTabControl1.Height / 2
        GroupControl2.Height = XtraTabControl1.Height / 2
    End Sub
    Private Sub XtraTabControl2_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraTabControl2.Resize
        'Panel21.Height = 2 * Panel20.Height
        'Panel30.Height = 2 * Panel29.Height

    End Sub

#End Region

#Region " Validated Texte "

    Private Sub TextEdit1_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit1.Validated
        ValideControl(sender, False)
    End Sub
    Private Sub TextEdit2_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit2.Validated
        ValideControl(sender, False)
    End Sub
    Private Sub TextEdit4_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit4.Validated
        ValideControl(sender, False)
    End Sub
    Private Sub TextEdit3_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit3.Validated
        ValideControl(sender, False)
    End Sub
    Private Sub TextEdit6_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit6.Validated
        ValideControl(sender, False)
    End Sub
    Private Sub TextEdit5_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit5.Validated
        ValideControl(sender, False)
    End Sub
    Private Sub lkupFGA_CDF_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupFGA_CDF.Validated
        ValideControl(sender, False)
    End Sub

#End Region

    Protected Friend Overrides Function ValideControl(Optional ByRef Ctrl As Control = Nothing, Optional ByVal AllCtrl As Boolean = True) As Boolean
        MyBase.ValideControl(Ctrl)
        If Ctrl.Name.ToLower = "TextEdit1".ToLower Or AllCtrl Then
            If TextEdit1.Text <> "" Then
                If Convert.ToDecimal(TextEdit1.Text) > 100 Then
                    Me.DxErrorProvider.SetError(TextEdit1, "La valeur maximale est 100 !")
                    Exit Function
                Else
                    Me.DxErrorProvider.SetError(TextEdit1, "")
                End If
                If Convert.ToDecimal(TextEdit1.Text) < 0 Then
                    Me.DxErrorProvider.SetError(TextEdit1, "Veuillez saisir une valeur > 0 !")
                    Exit Function
                ElseIf Convert.ToDecimal(TextEdit1.Text) <= 100 Then
                    Me.DxErrorProvider.SetError(TextEdit1, "")
                End If
            End If
        End If
        If Ctrl.Name.ToLower = "TextEdit2".ToLower Or AllCtrl Then
            If TextEdit2.Text <> "" Then
                If Convert.ToDecimal(TextEdit2.Text) > 100 Then
                    Me.DxErrorProvider.SetError(TextEdit2, "La valeur maximale est 100 !")
                    Exit Function
                Else
                    Me.DxErrorProvider.SetError(TextEdit2, "")
                End If
                If Convert.ToDecimal(TextEdit2.Text) < 0 Then
                    Me.DxErrorProvider.SetError(TextEdit2, "Veuillez saisir une valeur > 0 !")
                    Exit Function
                ElseIf Convert.ToDecimal(TextEdit2.Text) <= 100 Then
                    Me.DxErrorProvider.SetError(TextEdit2, "")
                End If
            End If
        End If
        If Ctrl.Name.ToLower = "TextEdit4".ToLower Or AllCtrl Then
            If TextEdit4.Text <> "" Then
                If Convert.ToDecimal(TextEdit4.Text) > 100 Then
                    Me.DxErrorProvider.SetError(TextEdit4, "La valeur maximale est 100 !")
                    Exit Function
                Else
                    Me.DxErrorProvider.SetError(TextEdit4, "")
                End If
                If Convert.ToDecimal(TextEdit4.Text) < 0 Then
                    Me.DxErrorProvider.SetError(TextEdit4, "Veuillez saisir une valeur > 0 !")
                    Exit Function
                ElseIf Convert.ToDecimal(TextEdit4.Text) <= 100 Then
                    Me.DxErrorProvider.SetError(TextEdit4, "")
                End If
            End If
        End If
        If Ctrl.Name.ToLower = "TextEdit3".ToLower Or AllCtrl Then
            If TextEdit3.Text <> "" Then
                If Convert.ToDecimal(TextEdit3.Text) > 100 Then
                    Me.DxErrorProvider.SetError(TextEdit3, "La valeur maximale est 100 !")
                    Exit Function
                Else
                    Me.DxErrorProvider.SetError(TextEdit3, "")
                End If
                If Convert.ToDecimal(TextEdit3.Text) < 0 Then
                    Me.DxErrorProvider.SetError(TextEdit3, "Veuillez saisir une valeur > 0 !")
                    Exit Function
                ElseIf Convert.ToDecimal(TextEdit3.Text) <= 100 Then
                    Me.DxErrorProvider.SetError(TextEdit3, "")
                End If
            End If
        End If
        If Ctrl.Name.ToLower = "TextEdit6".ToLower Or AllCtrl Then
            If TextEdit6.Text <> "" Then
                If Convert.ToDecimal(TextEdit6.Text) > 100 Then
                    Me.DxErrorProvider.SetError(TextEdit6, "La valeur maximale est 100 !")
                    Exit Function
                Else
                    Me.DxErrorProvider.SetError(TextEdit6, "")
                End If
                If Convert.ToDecimal(TextEdit6.Text) < 0 Then
                    Me.DxErrorProvider.SetError(TextEdit6, "Veuillez saisir une valeur > 0 !")
                    Exit Function
                ElseIf Convert.ToDecimal(TextEdit6.Text) <= 100 Then
                    Me.DxErrorProvider.SetError(TextEdit6, "")
                End If
                If ComboBoxEdit4.SelectedText = "O" Then
                    If lkupFGA_CDF.Text = "" Then
                        Me.DxErrorProvider.SetError(lkupFGA_CDF, "Veuillez choisir une unité !")
                        Exit Function
                    Else
                        Me.DxErrorProvider.SetError(lkupFGA_CDF, "")
                    End If
                End If
            Else
                If lkupFGA_CDF.EditValue IsNot DBNull.Value Then

                    If TextEdit5.Text = "" And lkupFGA_CDF.Text <> "" Then
                        Me.DxErrorProvider.SetError(lkupFGA_CDF, "L'unité ne correspond à aucune valeur min ou max !")
                        Exit Function
                    End If
                    If TextEdit5.Text <> "" And lkupFGA_CDF.Text = "" Then
                        Me.DxErrorProvider.SetError(lkupFGA_CDF, "Veuillez choisir une unité !")
                        Exit Function
                    End If
                End If
            End If
        End If
        If Ctrl.Name.ToLower = "TextEdit5".ToLower Or AllCtrl Then
            If TextEdit5.Text <> "" Then
                If Convert.ToDecimal(TextEdit5.Text) > 100 Then
                    Me.DxErrorProvider.SetError(TextEdit5, "La valeur maximale est 100 !")
                    Exit Function
                Else
                    Me.DxErrorProvider.SetError(TextEdit5, "")
                End If
                If Convert.ToDecimal(TextEdit5.Text) < 0 Then
                    Me.DxErrorProvider.SetError(TextEdit5, "Veuillez saisir une valeur > 0 !")
                    Exit Function
                ElseIf Convert.ToDecimal(TextEdit5.Text) <= 100 Then
                    Me.DxErrorProvider.SetError(TextEdit5, "")
                End If
                If ComboBoxEdit4.SelectedText = "O" Then
                    If lkupFGA_CDF.Text = "" Then
                        Me.DxErrorProvider.SetError(lkupFGA_CDF, "Veuillez choisir une unité !")
                        Exit Function
                    Else
                        Me.DxErrorProvider.SetError(lkupFGA_CDF, "")
                    End If
                End If
            Else
                If lkupFGA_CDF.EditValue IsNot DBNull.Value Then
                    If TextEdit6.Text = "" And lkupFGA_CDF.Text <> "" Then
                        Me.DxErrorProvider.SetError(lkupFGA_CDF, "L'unité ne correspond à aucune valeur min ou max !")
                        Exit Function
                    End If
                    If TextEdit6.Text <> "" And lkupFGA_CDF.Text = "" Then
                        Me.DxErrorProvider.SetError(lkupFGA_CDF, "Veuillez choisir une unité !")
                        Exit Function
                    End If
                End If
                End If
        End If
        If Ctrl.Name.ToLower = "lkupFGA_CDF".ToLower Or AllCtrl Then
            If lkupFGA_CDF.EditValue IsNot DBNull.Value Then
                If lkupFGA_CDF.Text <> "" Then
                    If TextEdit5.Text <> "" Or TextEdit6.Text <> "" Then
                        Me.DxErrorProvider.SetError(lkupFGA_CDF, "")
                    Else
                        Me.DxErrorProvider.SetError(lkupFGA_CDF, "L'unité ne correspond à aucune valeur min ou max !")
                        Exit Function
                    End If
                Else
                    If TextEdit5.Text <> "" Or TextEdit6.Text <> "" Then
                        Me.DxErrorProvider.SetError(lkupFGA_CDF, "Veuillez choisir une unité !")
                        Exit Function
                    End If
                End If
            End If
        End If
        Dim iCount1, iCount2, iCount3, iCount4, iCount5, iCount6, iIndex As Integer
        iCount1 = GV1.RowCount
        iCount2 = GV2.RowCount
        iCount3 = GV3.RowCount
        iCount4 = GV4.RowCount
        iCount5 = GV5.RowCount
        iCount6 = GV6.RowCount

        iIndex = Me.RadioGroup1.SelectedIndex
        If iIndex = 0 Then
            If iCount1 < 2 And iCount2 < 2 Then
                Process_Message(strClasse, MessageBoxButtons.OK, MessageBoxIcon.Information)
                XtraTabControl1.SelectedTabPageIndex = 0
                GV1.Focus()
                GV2.Focus()
                Exit Function
            End If
        End If
        If iIndex = 1 Then
            If iCount6 < 2 Then
                Process_Message(strSpecialite, MessageBoxButtons.OK, MessageBoxIcon.Information)
                XtraTabControl1.SelectedTabPageIndex = 0
                GV6.Focus()
                Exit Function
            End If
        End If
        If iIndex = 2 Then
            If iCount3 < 2 Then
                Process_Message(strSubac, MessageBoxButtons.OK, MessageBoxIcon.Information)
                XtraTabControl1.SelectedTabPageIndex = 0
                GV4.Focus()
                Exit Function
            End If
        End If
        If iIndex = 3 Then
            If iCount4 < 2 Then
                Process_Message(strExcipient, MessageBoxButtons.OK, MessageBoxIcon.Information)
                XtraTabControl1.SelectedTabPageIndex = 0
                GV4.Focus()
                Exit Function
            End If
        End If
        If iCount1 < 2 And iCount2 < 2 And iCount3 < 2 And iCount4 < 2 And iCount5 < 2 And iCount6 < 2 Then
            Process_Message(strInfo_Obligatoire, MessageBoxButtons.OK, MessageBoxIcon.Information)
            XtraTabControl1.SelectedTabPageIndex = 0
            GV1.Focus()
            Exit Function
        End If

        For iCount As Integer = 0 To GV45.RowCount - 1
            If Not FieldExistRO(GV6, colFGASP_SP_CODE_FK_PK, GV45.GetRowCellValue(iCount, colFGAAFS_SP_CODE_FK_PK1)) Then
                GV45.FocusedRowHandle = iCount
                GV45.SetColumnError(colFGAAFS_SP_CODE_FK_PK1, "La spécialité doit être présente dans la fiche.")
                XtraTabControl1.SelectedTabPageIndex = 1
                XtraTabControl2.SelectedTabPageIndex = 3
                Exit Function
            Else
                GV45.SetColumnError(colFGAAFS_SP_CODE_FK_PK1, "")
            End If
        Next
        For iCount As Integer = 0 To GV82.RowCount - 1
            If Not FieldExistRO(GV6, colFGASP_SP_CODE_FK_PK, GV82.GetRowCellValue(iCount, colFGAAFS_SP_CODE_FK_PK)) Then
                GV82.FocusedRowHandle = iCount
                GV82.SetColumnError(colFGAAFS_SP_CODE_FK_PK, "La spécialité doit être présente dans la fiche.")
                XtraTabControl1.SelectedTabPageIndex = 3
                XtraTabControl3.SelectedTabPageIndex = 2
                Exit Function
            Else
                GV82.SetColumnError(colFGAAFS_SP_CODE_FK_PK, "")
            End If
        Next
        Return True
    End Function

#Region " ComboBoxEdit Index Changed "

    Private Sub ComboBoxEdit2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEdit2.SelectedIndexChanged
        If ComboBoxEdit2.SelectedItem IsNot DBNull.Value And ComboBoxEdit2.SelectedItem IsNot Nothing Then
            If ComboBoxEdit2.SelectedItem = "O" Then
                TextEdit1.Properties.ReadOnly = False
                TextEdit2.Properties.ReadOnly = False
            Else
                TextEdit1.Properties.ReadOnly = True
                TextEdit1.EditValue = DBNull.Value
                Me.DxErrorProvider.SetError(TextEdit1, "")
                TextEdit2.Properties.ReadOnly = True
                TextEdit2.EditValue = DBNull.Value
                Me.DxErrorProvider.SetError(TextEdit2, "")
            End If
        End If
    End Sub
    Private Sub ComboBoxEdit3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEdit3.SelectedIndexChanged
        If ComboBoxEdit3.SelectedItem IsNot DBNull.Value And ComboBoxEdit3.SelectedItem IsNot Nothing Then
            If ComboBoxEdit3.SelectedItem = "O" Then
                TextEdit3.Properties.ReadOnly = False
                TextEdit4.Properties.ReadOnly = False
            Else
                TextEdit3.Properties.ReadOnly = True
                TextEdit3.EditValue = DBNull.Value
                Me.DxErrorProvider.SetError(TextEdit3, "")
                TextEdit4.Properties.ReadOnly = True
                TextEdit4.EditValue = DBNull.Value
                Me.DxErrorProvider.SetError(TextEdit4, "")
            End If
        End If
    End Sub
    Private Sub ComboBoxEdit4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEdit4.SelectedIndexChanged
        If ComboBoxEdit4.SelectedItem IsNot DBNull.Value And ComboBoxEdit4.SelectedItem IsNot Nothing Then
            If ComboBoxEdit4.SelectedItem = "O" Then
                TextEdit5.Properties.ReadOnly = False
                TextEdit6.Properties.ReadOnly = False
                lkupFGA_CDF.Properties.ReadOnly = False
            Else
                TextEdit5.Properties.ReadOnly = True
                TextEdit5.EditValue = DBNull.Value
                Me.DxErrorProvider.SetError(TextEdit5, "")
                TextEdit6.Properties.ReadOnly = True
                TextEdit6.EditValue = DBNull.Value
                Me.DxErrorProvider.SetError(TextEdit6, "")
                lkupFGA_CDF.Properties.ReadOnly = True
                Me.DxErrorProvider.SetError(lkupFGA_CDF, "")
            End If
        End If
    End Sub

#End Region

    Private Sub GV45_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV45.InitNewRow
        If OnLoading Then Exit Sub
        If RefOff <> "G" Then Exit Sub
        GV45.SetFocusedRowCellValue(colFGAAFS_FGA_CODE_FK_PK, txtCode.Text)
        GV45.SetFocusedRowCellValue(colFGAAFS_TYPEGRAL_PK, "G")
    End Sub

    Private Sub GV82_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV82.InitNewRow
        If OnLoading Then Exit Sub
        If RefOff <> "A" Then Exit Sub
        GV82.SetFocusedRowCellValue(colFGAAFS_FGA_CODE_FK_PK, txtCode.Text)
        GV82.SetFocusedRowCellValue(colFGAAFS_TYPEGRAL_PK, "A")
    End Sub

    Private Sub GC45_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles GC45.Enter
        RefOff = "G"
    End Sub

    Private Sub GC82_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles GC82.Enter
        RefOff = "A"
    End Sub

    Private Sub GV_CalcRowHeight(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs) Handles GV13.CalcRowHeight, GV63.CalcRowHeight, GV54.CalcRowHeight, GV52.CalcRowHeight, GV44.CalcRowHeight, GV42.CalcRowHeight, GV32.CalcRowHeight, GV25.CalcRowHeight
        e.RowHeight = sender.GridControl.Height
    End Sub
End Class
