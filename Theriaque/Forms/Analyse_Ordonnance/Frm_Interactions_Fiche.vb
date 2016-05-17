''' <summary>
''' Created By [BFE]
''' </summary>
''' <remarks> Analyse d'ordonnance - Fiche
''' </remarks>

Public Class Frm_Interactions_Fiche

#Region "Déclaration des variables privées"
    Private CodE As Integer
    Public _Code As Integer = Nothing ' charger la fiche depuis l'extérieur
    Private bModeDuplication As Boolean = False

#End Region

#Region " Edit Data  "

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_FIT_FICHEINTERAC
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            Open_Fiche(CodE)
            bModeDuplication = False
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Function Chercheravance() As Boolean
        MyBase.ChercherAvance()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_FIT_FICHEINTERAC_SPECIALITE()
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            OnLoading = True
            EmptyDataTable()
            Me.FiT_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FIT_FICHEINTERAC, f._Code)
            Me.IT1CPH_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT1CPH_TERME1CLPHARMTHER, f._Code)
            Me.IT1CCH_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT1CCH_TERME1CLCHIM, f._Code)
            Me.IT1CC_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT1CC_TERM1COMCLASSE, f._Code)
            Me.IT1SAC_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT1SAC_TERME1SUBACTIVE, f._Code)
            Me.IT1SAU_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT1SAU_TERME1SUBAUX, f._Code)
            Me.IT1PR_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT1PR_TERME1PRODUIT, f._Code)
            Me.IT1SP_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT1SP_TERME1SPECIALITE, f._Code)
            'Terme2
            Me.IT2CPH_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT2CPH_TERME2CLPHARMTHER, f._Code)
            Me.IT2CCH_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT2CCH_TERME2CLCHIM, f._Code)
            Me.IT2CC_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT2CC_TERM2COMCLASSE, f._Code)
            Me.IT2SAC_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT2SAC_TERME2SUBACTIVE, f._Code)
            Me.IT2SAU_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT2SAU_TERME2SUBAUX, f._Code)
            Me.IT2PR_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT2PR_TERME2PRODUIT, f._Code)
            Me.IT2SP_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT2SP_TERME2SPECIALITE, f._Code)
            'Charger les tables qui font réferences à la table master
            Me.FitnA_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITNA_INTERACTION_NATURE, f._Code)
            Me.FitroF_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITROF_REF_OFFICIELLE, f._Code)
            Me.FitsE_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITSE_INTERACTION_SENS, f._Code)
            Me.FittY_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITTY_TYPEINTERACTION, f._Code)
            Me.FitvA_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITVA_NIVEAU_VALIDATION, f._Code)
            Me.FitvD1_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITVD1_INTERACTION_VOIE_DOSE, f._Code)
            Me.FitvD2_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITVD2_INTERACTION_VOIE_DOSE, f._Code)
            Me.FitteR_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITTER_TERRAINFAVORISANT, f._Code)
            Me.FitcH_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITCH_CRITERECHOIX, f._Code)
            Me.FitcT_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITCT_COMMENTAIRE_TERRAIN, f._Code)

            bModeDuplication = False
            OnLoading = False
            Return True
        Else
            Return False
        End If
    End Function

    'Peut être à supprimer cette fonction
    Public Overrides Function SpecialiteCommune() As Boolean
        MyBase.SpecialiteCommune()
        Dim f As New Frm_Recherche
        Dim strSSQL_SpecialiteCommune As String
        strSSQL_SpecialiteCommune = " SELECT IT1SP_FIT_CODE_FK_PK as code,  SP_NOM as libelle FROM THERIAQUE.IT2SP_TERME2SPECIALITE as IT1, THERIAQUE.IT1SP_TERME1SPECIALITE as IT2, THERIAQUE.SP_SPECIALITE as SP"
        strSSQL_SpecialiteCommune &= " WHERE IT2SP_SP_CODE_FK_PK = IT1SP_SP_CODE_FK_PK"
        strSSQL_SpecialiteCommune &= " AND IT2SP_FIT_CODE_FK_PK = IT1SP_FIT_CODE_FK_PK"
        strSSQL_SpecialiteCommune &= " AND IT1SP_SP_CODE_FK_PK = SP.SP_CODE_SQ_PK"
        f._SSQL = strSSQL_SpecialiteCommune
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            OnLoading = True
            EmptyDataTable()
            Me.FiT_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FIT_FICHEINTERAC, f._Code)
            Me.IT1CPH_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT1CPH_TERME1CLPHARMTHER, f._Code)
            Me.IT1CCH_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT1CCH_TERME1CLCHIM, f._Code)
            Me.IT1CC_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT1CC_TERM1COMCLASSE, f._Code)
            Me.IT1SAC_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT1SAC_TERME1SUBACTIVE, f._Code)
            Me.IT1SAU_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT1SAU_TERME1SUBAUX, f._Code)
            Me.IT1PR_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT1PR_TERME1PRODUIT, f._Code)
            Me.IT1SP_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT1SP_TERME1SPECIALITE, f._Code)
            'Terme2
            Me.IT2CPH_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT2CPH_TERME2CLPHARMTHER, f._Code)
            Me.IT2CCH_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT2CCH_TERME2CLCHIM, f._Code)
            Me.IT2CC_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT2CC_TERM2COMCLASSE, f._Code)
            Me.IT2SAC_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT2SAC_TERME2SUBACTIVE, f._Code)
            Me.IT2SAU_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT2SAU_TERME2SUBAUX, f._Code)
            Me.IT2PR_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT2PR_TERME2PRODUIT, f._Code)
            Me.IT2SP_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT2SP_TERME2SPECIALITE, f._Code)
            'Charger les tables qui font réferences à la table master
            Me.FitnA_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITNA_INTERACTION_NATURE, f._Code)
            Me.FitroF_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITROF_REF_OFFICIELLE, f._Code)
            Me.FitsE_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITSE_INTERACTION_SENS, f._Code)
            Me.FittY_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITTY_TYPEINTERACTION, f._Code)
            Me.FitvA_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITVA_NIVEAU_VALIDATION, f._Code)
            Me.FitvD1_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITVD1_INTERACTION_VOIE_DOSE, f._Code)
            Me.FitvD2_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITVD2_INTERACTION_VOIE_DOSE, f._Code)
            Me.FitteR_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITTER_TERRAINFAVORISANT, f._Code)
            Me.FitcH_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITCH_CRITERECHOIX, f._Code)
            Me.FitcT_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITCT_COMMENTAIRE_TERRAIN, f._Code)

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
        Dim sCodeCPH1 As String = ""
        Dim sCodeCCH1 As String = ""
        Dim sCodeCOM1 As String = ""
        Dim sCodeSUBAC1 As String = ""
        Dim sCodeSAU1 As String = ""
        Dim sCodePR1 As String = ""
        Dim sCodeSP1 As String = ""
        Dim sCodeCPH2 As String = ""
        Dim sCodeCCH2 As String = ""
        Dim sCodeCOM2 As String = ""
        Dim sCodeSUBAC2 As String = ""
        Dim sCodeSAU2 As String = ""
        Dim sCodePR2 As String = ""
        Dim sCodeSP2 As String = ""
        Dim sCodeV1 As String = ""
        Dim sCodeD1 As String = ""
        Dim sCodeV2 As String = ""
        Dim sCodeD2 As String = ""
        Dim sCodeNIVVALD As String = ""
        Dim sCodeNIVINTER As String = ""
        Dim sCodeTYPEINTER As String = ""
        Dim sCodeSENSINTER As String = ""
        Dim sCodeTERR As String = ""
        Dim sCodeCOMTERR As String = ""
        Dim sCodeCC As String = ""
        Dim sCodeREF As String = ""
        
        Dim f As New Frm_InteractionMultiCriteres
        f.ShowDialog()
        If f._Validate Then
            If f._bCPH1 Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CPH_CLASSEPHARMTHER
                fDICO.Text = "Classes pharmaco-thérapeutique 1"
                fDICO.ShowDialog()
                sCodeCPH1 = fDICO._Code
            End If
            If f._bCCH1 Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CCH_CLASSECHIMIQUE
                fDICO.Text = "Classes chimiques 1"
                fDICO.ShowDialog()
                sCodeCCH1 = fDICO._Code
            End If
            If f._bCOM1 Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("IC")
                fDICO.Text = "Commentaires classe 1"
                fDICO.ShowDialog()
                sCodeCOM1 = fDICO._Code
            End If
            If f._bSUBAC1 Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SAC_SUBACTIVE
                fDICO.Text = "Substances actives 1"
                fDICO.ShowDialog()
                sCodeSUBAC1 = fDICO._Code
            End If
            If f._bSAU1 Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SAU_SUBAUXILIAIRE
                fDICO.Text = "Excipients 1"
                fDICO.ShowDialog()
                sCodeSAU1 = fDICO._Code
            End If
            If f._bPR1 Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_PR_PRODUIT
                fDICO.Text = "Produits 1"
                fDICO.ShowDialog()
                sCodePR1 = fDICO._Code
            End If
            If f._bSP1 Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SP_SPECIALITE
                fDICO.Text = "Spécialités 1"
                fDICO.ShowDialog()
                sCodeSP1 = fDICO._Code
            End If
            If f._bCPH2 Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CPH_CLASSEPHARMTHER
                fDICO.Text = "Classes pharmaco-thérapeutique 2"
                fDICO.ShowDialog()
                sCodeCPH2 = fDICO._Code
            End If
            If f._bCCH2 Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CCH_CLASSECHIMIQUE
                fDICO.Text = "Classes chimiques 2"
                fDICO.ShowDialog()
                sCodeCCH2 = fDICO._Code
            End If
            If f._bCOM2 Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("IC")
                fDICO.Text = "Commentaires classe 2"
                fDICO.ShowDialog()
                sCodeCOM2 = fDICO._Code
            End If
            If f._bSUBAC2 Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SAC_SUBACTIVE
                fDICO.Text = "Substances actives 2"
                fDICO.ShowDialog()
                sCodeSUBAC2 = fDICO._Code
            End If
            If f._bSAU2 Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SAU_SUBAUXILIAIRE
                fDICO.Text = "Excipients 2"
                fDICO.ShowDialog()
                sCodeSAU2 = fDICO._Code
            End If
            If f._bPR2 Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_PR_PRODUIT
                fDICO.Text = "Produits 2"
                fDICO.ShowDialog()
                sCodePR2 = fDICO._Code
            End If
            If f._bSP2 Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SP_SPECIALITE
                fDICO.Text = "Spécialités 2"
                fDICO.ShowDialog()
                sCodeSP2 = fDICO._Code
            End If
            If f._bV1 Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("18")
                fDICO.Text = "Voies 1"
                fDICO.ShowDialog()
                sCodeV1 = fDICO._Code
            End If
            If f._bD1 Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("PP")
                fDICO.Text = "Doses 1"
                fDICO.ShowDialog()
                sCodeD1 = fDICO._Code
            End If
            If f._bV2 Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("18")
                fDICO.Text = "Voies 2"
                fDICO.ShowDialog()
                sCodeV2 = fDICO._Code
            End If
            If f._bD2 Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("PP")
                fDICO.Text = "Doses 2"
                fDICO.ShowDialog()
                sCodeD2 = fDICO._Code
            End If
            If f._bNIVVALD Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("IV")
                fDICO.Text = "Niveaux de validation"
                fDICO.ShowDialog()
                sCodeNIVVALD = fDICO._Code
            End If
            If f._bNIVINTER Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("IN")
                fDICO.Text = "Niveaux de l'interaction"
                fDICO.ShowDialog()
                sCodeNIVINTER = fDICO._Code
            End If
            If f._bTYPEINTER Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("IY")
                fDICO.Text = "Types de l'interaction"
                fDICO.ShowDialog()
                sCodeTYPEINTER = fDICO._Code
            End If
            If f._bSENSINTER Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("IS")
                fDICO.Text = "Sens de l'interaction"
                fDICO.ShowDialog()
                sCodeSENSINTER = fDICO._Code
            End If
            If f._bTERR Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("CS")
                fDICO.Text = "Terrains favorisants"
                fDICO.ShowDialog()
                sCodeTERR = fDICO._Code
            End If
            If f._bCOMTERR Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("CC")
                fDICO.Text = "Commentaires terrain"
                fDICO.ShowDialog()
                sCodeCOMTERR = fDICO._Code
            End If
            If f._bCC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CH_CHOIX
                fDICO.Text = "Critères de choix"
                fDICO.ShowDialog()
                sCodeCC = fDICO._Code
            End If
            If f._bREF Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("25")
                fDICO.Text = "Références officielles"
                fDICO.ShowDialog()
                sCodeREF = fDICO._Code
            End If
            Dim fResultat As New Frm_Recherche
            Dim sSQL As String = ""
            sSQL &= " Select FIT_CODE_SQ_PK as code, '' as libelle From THERIAQUE.FIT_FICHEINTERAC"
            If sCodeCPH1 <> "" Then
                sSQL &= " WHERE FIT_CODE_SQ_PK IN (SELECT IT1CPH_FIT_CODE_FK_PK FROM THERIAQUE.IT1CPH_TERME1CLPHARMTHER WHERE IT1CPH_CPH_CODE_FK_PK = " & cn.SQLText(sCodeCPH1) & ")"
            End If
            If sCodeCCH1 <> "" Then
                If sCodeCPH1 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIT_CODE_SQ_PK IN (SELECT IT1CCH_FIT_CODE_FK_PK FROM THERIAQUE.IT1CCH_TERME1CLCHIM WHERE IT1CCH_CCH_CODE_FK_PK = " & cn.SQLText(sCodeCCH1) & ")"
            End If
            If sCodeCOM1 <> "" Then
                If sCodeCPH1 <> "" Or sCodeCCH1 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIT_CODE_SQ_PK IN (SELECT IT1CC_FIT_CODE_FK_PK FROM THERIAQUE.IT1CC_TERM1COMCLASSE WHERE IT1CC_CDF_CC_CODE_FK_PK = " & cn.SQLText(sCodeCOM1) & ")"
            End If
            If sCodeSUBAC1 <> "" Then
                If sCodeCPH1 <> "" Or sCodeCCH1 <> "" Or sCodeCOM1 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIT_CODE_SQ_PK IN (SELECT IT1SAC_FIT_CODE_FK_PK FROM THERIAQUE.IT1SAC_TERME1SUBACTIVE WHERE IT1SAC_SAC_CODE_FK_PK = " & cn.SQLText(sCodeSUBAC1) & ")"
            End If
            If sCodeSAU1 <> "" Then
                If sCodeCPH1 <> "" Or sCodeCCH1 <> "" Or sCodeCOM1 <> "" Or sCodeSUBAC1 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIT_CODE_SQ_PK IN (SELECT IT1SAU_FIT_CODE_FK_PK FROM THERIAQUE.IT1SAU_TERME1SUBAUX WHERE IT1SAU_SAU_CODE_FK_PK = " & cn.SQLText(sCodeSAU1) & ")"
            End If
            If sCodePR1 <> "" Then
                If sCodeCPH1 <> "" Or sCodeCCH1 <> "" Or sCodeCOM1 <> "" Or sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIT_CODE_SQ_PK IN (SELECT IT1PR_FIT_CODE_FK_PK FROM THERIAQUE.IT1PR_TERME1PRODUIT WHERE IT1PR_PR_CODE_FK_PK = " & cn.SQLText(sCodePR1) & ")"
            End If
            If sCodeSP1 <> "" Then
                If sCodeCPH1 <> "" Or sCodeCCH1 <> "" Or sCodeCOM1 <> "" Or sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIT_CODE_SQ_PK IN (SELECT IT1SP_FIT_CODE_FK_PK FROM THERIAQUE.IT1SP_TERME1SPECIALITE WHERE IT1SP_SP_CODE_FK_PK = " & cn.SQLText(sCodeSP1) & ")"
            End If
            If sCodeCPH2 <> "" Then
                If sCodeCPH1 <> "" Or sCodeCCH1 <> "" Or sCodeCOM1 <> "" Or sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIT_CODE_SQ_PK IN (SELECT IT2CPH_FIT_CODE_FK_PK FROM THERIAQUE.IT2CPH_TERME2CLPHARMTHER WHERE IT2CPH_CPH_CODE_FK_PK = " & cn.SQLText(sCodeCPH2) & ")"
            End If
            If sCodeCCH2 <> "" Then
                If sCodeCPH1 <> "" Or sCodeCCH1 <> "" Or sCodeCOM1 <> "" Or sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeCPH2 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIT_CODE_SQ_PK IN (SELECT IT2CCH_FIT_CODE_FK_PK FROM THERIAQUE.IT2CCH_TERME2CLCHIM WHERE IT2CCH_CCH_CODE_FK_PK = " & cn.SQLText(sCodeCCH2) & ")"
            End If
            If sCodeCOM2 <> "" Then
                If sCodeCPH1 <> "" Or sCodeCCH1 <> "" Or sCodeCOM1 <> "" Or sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeCPH2 <> "" Or sCodeCCH2 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIT_CODE_SQ_PK IN (SELECT IT2CC_FIT_CODE_FK_PK FROM THERIAQUE.IT2CC_TERM2COMCLASSE WHERE IT2CC_CDF_CC_CODE_FK_PK = " & cn.SQLText(sCodeCOM2) & ")"
            End If
            If sCodeSUBAC2 <> "" Then
                If sCodeCPH1 <> "" Or sCodeCCH1 <> "" Or sCodeCOM1 <> "" Or sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeCPH2 <> "" Or sCodeCCH2 <> "" Or sCodeCOM2 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIT_CODE_SQ_PK IN (SELECT IT2SAC_FIT_CODE_FK_PK FROM THERIAQUE.IT2SAC_TERME2SUBACTIVE WHERE IT2SAC_SAC_CODE_FK_PK = " & cn.SQLText(sCodeSUBAC2) & ")"
            End If
            If sCodeSAU2 <> "" Then
                If sCodeCPH1 <> "" Or sCodeCCH1 <> "" Or sCodeCOM1 <> "" Or sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeCPH2 <> "" Or sCodeCCH2 <> "" Or sCodeCOM2 <> "" Or sCodeSUBAC2 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIT_CODE_SQ_PK IN (SELECT IT2SAU_FIT_CODE_FK_PK FROM THERIAQUE.IT2SAU_TERME2SUBAUX WHERE IT2SAU_SAU_CODE_FK_PK = " & cn.SQLText(sCodeSAU2) & ")"
            End If
            If sCodePR2 <> "" Then
                If sCodeCPH1 <> "" Or sCodeCCH1 <> "" Or sCodeCOM1 <> "" Or sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeCPH2 <> "" Or sCodeCCH2 <> "" Or sCodeCOM2 <> "" Or sCodeSUBAC2 <> "" Or sCodeSAU2 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIT_CODE_SQ_PK IN (SELECT IT2PR_FIT_CODE_FK_PK FROM THERIAQUE.IT2PR_TERME2PRODUIT WHERE IT2PR_PR_CODE_FK_PK = " & cn.SQLText(sCodePR2) & ")"
            End If
            If sCodeSP2 <> "" Then
                If sCodeCPH1 <> "" Or sCodeCCH1 <> "" Or sCodeCOM1 <> "" Or sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeCPH2 <> "" Or sCodeCCH2 <> "" Or sCodeCOM2 <> "" Or sCodeSUBAC2 <> "" Or sCodeSAU2 <> "" Or sCodePR2 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIT_CODE_SQ_PK IN (SELECT IT2SP_FIT_CODE_FK_PK FROM THERIAQUE.IT2SP_TERME2SPECIALITE WHERE IT2SP_SP_CODE_FK_PK = " & cn.SQLText(sCodeSP2) & ")"
            End If
            If sCodeV1 <> "" Then
                If sCodeCPH1 <> "" Or sCodeCCH1 <> "" Or sCodeCOM1 <> "" Or sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeCPH2 <> "" Or sCodeCCH2 <> "" Or sCodeCOM2 <> "" Or sCodeSUBAC2 <> "" Or sCodeSAU2 <> "" Or sCodePR2 <> "" Or sCodeSP2 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIT_CODE_SQ_PK IN (SELECT FITVD1_FIT_CODE_FK_PK FROM THERIAQUE.FITVD1_INTERACTION_VOIE_DOSE WHERE FITVD1_CDF_VO_CODE1_FK = " & cn.SQLText(sCodeV1) & ")"
            End If
            If sCodeD1 <> "" Then
                If sCodeCPH1 <> "" Or sCodeCCH1 <> "" Or sCodeCOM1 <> "" Or sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeCPH2 <> "" Or sCodeCCH2 <> "" Or sCodeCOM2 <> "" Or sCodeSUBAC2 <> "" Or sCodeSAU2 <> "" Or sCodePR2 <> "" Or sCodeSP2 <> "" Or sCodeV1 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIT_CODE_SQ_PK IN (SELECT FITVD1_FIT_CODE_FK_PK FROM THERIAQUE.FITVD1_INTERACTION_VOIE_DOSE WHERE FITVD1_CDF_PP_CODE1_FK = " & cn.SQLText(sCodeD1) & ")"
            End If
            If sCodeV2 <> "" Then
                If sCodeCPH1 <> "" Or sCodeCCH1 <> "" Or sCodeCOM1 <> "" Or sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeCPH2 <> "" Or sCodeCCH2 <> "" Or sCodeCOM2 <> "" Or sCodeSUBAC2 <> "" Or sCodeSAU2 <> "" Or sCodePR2 <> "" Or sCodeSP2 <> "" Or sCodeV1 <> "" Or sCodeD1 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIT_CODE_SQ_PK IN (SELECT FITVD2_FIT_CODE_FK_PK FROM THERIAQUE.FITVD2_INTERACTION_VOIE_DOSE WHERE FITVD2_CDF_VO_CODE2_FK = " & cn.SQLText(sCodeV2) & ")"
            End If
            If sCodeD2 <> "" Then
                If sCodeCPH1 <> "" Or sCodeCCH1 <> "" Or sCodeCOM1 <> "" Or sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeCPH2 <> "" Or sCodeCCH2 <> "" Or sCodeCOM2 <> "" Or sCodeSUBAC2 <> "" Or sCodeSAU2 <> "" Or sCodePR2 <> "" Or sCodeSP2 <> "" Or sCodeV1 <> "" Or sCodeD1 <> "" Or sCodeV2 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIT_CODE_SQ_PK IN (SELECT FITVD2_FIT_CODE_FK_PK FROM THERIAQUE.FITVD2_INTERACTION_VOIE_DOSE WHERE FITVD2_CDF_PP_CODE2_FK = " & cn.SQLText(sCodeD2) & ")"
            End If
            If sCodeNIVVALD <> "" Then
                If sCodeCPH1 <> "" Or sCodeCCH1 <> "" Or sCodeCOM1 <> "" Or sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeCPH2 <> "" Or sCodeCCH2 <> "" Or sCodeCOM2 <> "" Or sCodeSUBAC2 <> "" Or sCodeSAU2 <> "" Or sCodePR2 <> "" Or sCodeSP2 <> "" Or sCodeV1 <> "" Or sCodeD1 <> "" Or sCodeV2 <> "" Or sCodeD2 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIT_CODE_SQ_PK IN (SELECT FITVA_FIT_CODE_FK_PK FROM THERIAQUE.FITVA_NIVEAU_VALIDATION WHERE FITVA_CDF_VAIT_CODE_FK_PK = " & cn.SQLText(sCodeNIVVALD) & ")"
            End If
            If sCodeNIVINTER <> "" Then
                If sCodeCPH1 <> "" Or sCodeCCH1 <> "" Or sCodeCOM1 <> "" Or sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeCPH2 <> "" Or sCodeCCH2 <> "" Or sCodeCOM2 <> "" Or sCodeSUBAC2 <> "" Or sCodeSAU2 <> "" Or sCodePR2 <> "" Or sCodeSP2 <> "" Or sCodeV1 <> "" Or sCodeD1 <> "" Or sCodeV2 <> "" Or sCodeD2 <> "" Or sCodeNIVVALD <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIT_CODE_SQ_PK IN (SELECT FITNA_FIT_CODE_FK_PK FROM THERIAQUE.FITNA_INTERACTION_NATURE WHERE FITNA_CDF_NAIT_CODE_FK_PK = " & cn.SQLText(sCodeNIVINTER) & ")"
            End If
            If sCodeTYPEINTER <> "" Then
                If sCodeCPH1 <> "" Or sCodeCCH1 <> "" Or sCodeCOM1 <> "" Or sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeCPH2 <> "" Or sCodeCCH2 <> "" Or sCodeCOM2 <> "" Or sCodeSUBAC2 <> "" Or sCodeSAU2 <> "" Or sCodePR2 <> "" Or sCodeSP2 <> "" Or sCodeV1 <> "" Or sCodeD1 <> "" Or sCodeV2 <> "" Or sCodeD2 <> "" Or sCodeNIVVALD <> "" Or sCodeNIVINTER <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIT_CODE_SQ_PK IN (SELECT FITTY_FIT_CODE_FK_PK FROM THERIAQUE.FITTY_TYPEINTERACTION WHERE FITTY_CDF_TYPE_CODE_FK_PK = " & cn.SQLText(sCodeTYPEINTER) & ")"
            End If
            If sCodeSENSINTER <> "" Then
                If sCodeCPH1 <> "" Or sCodeCCH1 <> "" Or sCodeCOM1 <> "" Or sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeCPH2 <> "" Or sCodeCCH2 <> "" Or sCodeCOM2 <> "" Or sCodeSUBAC2 <> "" Or sCodeSAU2 <> "" Or sCodePR2 <> "" Or sCodeSP2 <> "" Or sCodeV1 <> "" Or sCodeD1 <> "" Or sCodeV2 <> "" Or sCodeD2 <> "" Or sCodeNIVVALD <> "" Or sCodeNIVINTER <> "" Or sCodeTYPEINTER <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIT_CODE_SQ_PK IN (SELECT FITSE_FIT_CODE_FK_PK FROM THERIAQUE.FITSE_INTERACTION_SENS WHERE FITSE_CDF_SEIT_CODE_FK_PK = " & cn.SQLText(sCodeSENSINTER) & ")"
            End If
            If sCodeTERR <> "" Then
                If sCodeCPH1 <> "" Or sCodeCCH1 <> "" Or sCodeCOM1 <> "" Or sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeCPH2 <> "" Or sCodeCCH2 <> "" Or sCodeCOM2 <> "" Or sCodeSUBAC2 <> "" Or sCodeSAU2 <> "" Or sCodePR2 <> "" Or sCodeSP2 <> "" Or sCodeV1 <> "" Or sCodeD1 <> "" Or sCodeV2 <> "" Or sCodeD2 <> "" Or sCodeNIVVALD <> "" Or sCodeNIVINTER <> "" Or sCodeTYPEINTER <> "" Or sCodeSENSINTER <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIT_CODE_SQ_PK IN (SELECT FITTER_FIT_CODE_FK_PK FROM THERIAQUE.FITTER_TERRAINFAVORISANT WHERE FITTER_CDF_TER_CODE_FK_PK = " & cn.SQLText(sCodeTERR) & ")"
            End If
            If sCodeCOMTERR <> "" Then
                If sCodeCPH1 <> "" Or sCodeCCH1 <> "" Or sCodeCOM1 <> "" Or sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeCPH2 <> "" Or sCodeCCH2 <> "" Or sCodeCOM2 <> "" Or sCodeSUBAC2 <> "" Or sCodeSAU2 <> "" Or sCodePR2 <> "" Or sCodeSP2 <> "" Or sCodeV1 <> "" Or sCodeD1 <> "" Or sCodeV2 <> "" Or sCodeD2 <> "" Or sCodeNIVVALD <> "" Or sCodeNIVINTER <> "" Or sCodeTYPEINTER <> "" Or sCodeSENSINTER <> "" Or sCodeTERR <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIT_CODE_SQ_PK IN (SELECT FITCT_FIT_CODE_FK_PK FROM THERIAQUE.FITCT_COMMENTAIRE_TERRAIN WHERE FITCT_CDF_CT_CODE_FK_PK = " & cn.SQLText(sCodeCOMTERR) & ")"
            End If
            If sCodeCC <> "" Then
                If sCodeCPH1 <> "" Or sCodeCCH1 <> "" Or sCodeCOM1 <> "" Or sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeCPH2 <> "" Or sCodeCCH2 <> "" Or sCodeCOM2 <> "" Or sCodeSUBAC2 <> "" Or sCodeSAU2 <> "" Or sCodePR2 <> "" Or sCodeSP2 <> "" Or sCodeV1 <> "" Or sCodeD1 <> "" Or sCodeV2 <> "" Or sCodeD2 <> "" Or sCodeNIVVALD <> "" Or sCodeNIVINTER <> "" Or sCodeTYPEINTER <> "" Or sCodeSENSINTER <> "" Or sCodeTERR <> "" Or sCodeCOMTERR <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIT_CODE_SQ_PK IN (SELECT FITCH_FIT_CODE_FK_PK FROM THERIAQUE.FITCH_CRITERECHOIX WHERE FITCH_CH_CODE_FK_PK = " & cn.SQLText(sCodeCC) & ")"
            End If
            If sCodeREF <> "" Then
                If sCodeCPH1 <> "" Or sCodeCCH1 <> "" Or sCodeCOM1 <> "" Or sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeCPH2 <> "" Or sCodeCCH2 <> "" Or sCodeCOM2 <> "" Or sCodeSUBAC2 <> "" Or sCodeSAU2 <> "" Or sCodePR2 <> "" Or sCodeSP2 <> "" Or sCodeV1 <> "" Or sCodeD1 <> "" Or sCodeV2 <> "" Or sCodeD2 <> "" Or sCodeNIVVALD <> "" Or sCodeNIVINTER <> "" Or sCodeTYPEINTER <> "" Or sCodeSENSINTER <> "" Or sCodeTERR <> "" Or sCodeCOMTERR <> "" Or sCodeCC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIT_CODE_SQ_PK IN (SELECT FITROF_FIT_CODE_FK_PK FROM THERIAQUE.FITROF_REF_OFFICIELLE WHERE FITROF_CDF_DOC_CODE_FK_PK = " & cn.SQLText(sCodeREF) & ")"
            End If

            sSQL &= " ORDER BY FIT_CODE_SQ_PK"

            fResultat._SSQL = sSQL
            fResultat.Text = Me.Text
            fResultat.ShowDialog()
            CodE = fResultat._Code
            If fResultat._Code IsNot Nothing Then
                Open_Fiche(fResultat._Code)
                bModeDuplication = False
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
        CodE = InvalidCode
        MyBase.Ajouter()
        bModeDuplication = False
        XtraTabControl1.SelectedTabPageIndex = 0
    End Sub

    Public Overrides Function supprimer() As Boolean
        MyBase.Supprimer()
        Dim iCount As Integer
        For iCount = 0 To DsTheriaque_AnalyseOrdonance.IT1CPH_TERME1CLPHARMTHER.Rows.Count - 1
            DsTheriaque_AnalyseOrdonance.IT1CPH_TERME1CLPHARMTHER.Rows(iCount).Delete()
        Next
        Me.IT1CPH_TA.Update(DsTheriaque_AnalyseOrdonance)

        For iCount = 0 To DsTheriaque_AnalyseOrdonance.IT1CCH_TERME1CLCHIM.Rows.Count - 1
            DsTheriaque_AnalyseOrdonance.IT1CCH_TERME1CLCHIM.Rows(iCount).Delete()
        Next
        Me.IT1CCH_TA.Update(DsTheriaque_AnalyseOrdonance)

        For iCount = 0 To DsTheriaque_AnalyseOrdonance.IT1CC_TERM1COMCLASSE.Rows.Count - 1
            DsTheriaque_AnalyseOrdonance.IT1CC_TERM1COMCLASSE.Rows(iCount).Delete()
        Next
        Me.IT1CC_TA.Update(DsTheriaque_AnalyseOrdonance)

        For iCount = 0 To DsTheriaque_AnalyseOrdonance.IT1SAC_TERME1SUBACTIVE.Rows.Count - 1
            DsTheriaque_AnalyseOrdonance.IT1SAC_TERME1SUBACTIVE.Rows(iCount).Delete()
        Next
        Me.IT1SAC_TA.Update(DsTheriaque_AnalyseOrdonance)

        For iCount = 0 To DsTheriaque_AnalyseOrdonance.IT1SAU_TERME1SUBAUX.Rows.Count - 1
            DsTheriaque_AnalyseOrdonance.IT1SAU_TERME1SUBAUX.Rows(iCount).Delete()
        Next
        Me.IT1SAU_TA.Update(DsTheriaque_AnalyseOrdonance)

        For iCount = 0 To DsTheriaque_AnalyseOrdonance.IT1PR_TERME1PRODUIT.Rows.Count - 1
            DsTheriaque_AnalyseOrdonance.IT1PR_TERME1PRODUIT.Rows(iCount).Delete()
        Next
        Me.IT1PR_TA.Update(DsTheriaque_AnalyseOrdonance)

        For iCount = 0 To DsTheriaque_AnalyseOrdonance.IT1SP_TERME1SPECIALITE.Rows.Count - 1
            DsTheriaque_AnalyseOrdonance.IT1SP_TERME1SPECIALITE.Rows(iCount).Delete()
        Next
        Me.IT1SP_TA.Update(DsTheriaque_AnalyseOrdonance)

        'Terme2
        For iCount = 0 To DsTheriaque_AnalyseOrdonance.IT2CPH_TERME2CLPHARMTHER.Rows.Count - 1
            DsTheriaque_AnalyseOrdonance.IT2CPH_TERME2CLPHARMTHER.Rows(iCount).Delete()
        Next
        Me.IT2CPH_TA.Update(DsTheriaque_AnalyseOrdonance)

        For iCount = 0 To DsTheriaque_AnalyseOrdonance.IT2CCH_TERME2CLCHIM.Rows.Count - 1
            DsTheriaque_AnalyseOrdonance.IT2CCH_TERME2CLCHIM.Rows(iCount).Delete()
        Next
        Me.IT2CCH_TA.Update(DsTheriaque_AnalyseOrdonance)

        For iCount = 0 To DsTheriaque_AnalyseOrdonance.IT2CC_TERM2COMCLASSE.Rows.Count - 1
            DsTheriaque_AnalyseOrdonance.IT2CC_TERM2COMCLASSE.Rows(iCount).Delete()
        Next
        Me.IT2CC_TA.Update(DsTheriaque_AnalyseOrdonance)

        For iCount = 0 To DsTheriaque_AnalyseOrdonance.IT2SAC_TERME2SUBACTIVE.Rows.Count - 1
            DsTheriaque_AnalyseOrdonance.IT2SAC_TERME2SUBACTIVE.Rows(iCount).Delete()
        Next
        Me.IT2SAC_TA.Update(DsTheriaque_AnalyseOrdonance)

        For iCount = 0 To DsTheriaque_AnalyseOrdonance.IT2SAU_TERME2SUBAUX.Rows.Count - 1
            DsTheriaque_AnalyseOrdonance.IT2SAU_TERME2SUBAUX.Rows(iCount).Delete()
        Next
        Me.IT2SAU_TA.Update(DsTheriaque_AnalyseOrdonance)

        For iCount = 0 To DsTheriaque_AnalyseOrdonance.IT2PR_TERME2PRODUIT.Rows.Count - 1
            DsTheriaque_AnalyseOrdonance.IT2PR_TERME2PRODUIT.Rows(iCount).Delete()
        Next
        Me.IT2PR_TA.Update(DsTheriaque_AnalyseOrdonance)

        For iCount = 0 To DsTheriaque_AnalyseOrdonance.IT2SP_TERME2SPECIALITE.Rows.Count - 1
            DsTheriaque_AnalyseOrdonance.IT2SP_TERME2SPECIALITE.Rows(iCount).Delete()
        Next
        Me.IT2SP_TA.Update(DsTheriaque_AnalyseOrdonance)

        'Vider les tables qui font réferences à la table master
        For iCount = 0 To DsTheriaque_AnalyseOrdonance.FITNA_INTERACTION_NATURE.Rows.Count - 1
            DsTheriaque_AnalyseOrdonance.FITNA_INTERACTION_NATURE.Rows(iCount).Delete()
        Next
        Me.FitnA_TA.Update(DsTheriaque_AnalyseOrdonance)

        For iCount = 0 To DsTheriaque_AnalyseOrdonance.FITROF_REF_OFFICIELLE.Rows.Count - 1
            DsTheriaque_AnalyseOrdonance.FITROF_REF_OFFICIELLE.Rows(iCount).Delete()
        Next
        Me.FitroF_TA.Update(DsTheriaque_AnalyseOrdonance)

        For iCount = 0 To DsTheriaque_AnalyseOrdonance.FITSE_INTERACTION_SENS.Rows.Count - 1
            DsTheriaque_AnalyseOrdonance.FITSE_INTERACTION_SENS.Rows(iCount).Delete()
        Next
        Me.FitsE_TA.Update(DsTheriaque_AnalyseOrdonance)

        For iCount = 0 To DsTheriaque_AnalyseOrdonance.FITTY_TYPEINTERACTION.Rows.Count - 1
            DsTheriaque_AnalyseOrdonance.FITTY_TYPEINTERACTION.Rows(iCount).Delete()
        Next
        Me.FittY_TA.Update(DsTheriaque_AnalyseOrdonance)

        For iCount = 0 To DsTheriaque_AnalyseOrdonance.FITVA_NIVEAU_VALIDATION.Rows.Count - 1
            DsTheriaque_AnalyseOrdonance.FITVA_NIVEAU_VALIDATION.Rows(iCount).Delete()
        Next
        Me.FitvA_TA.Update(DsTheriaque_AnalyseOrdonance)

        For iCount = 0 To DsTheriaque_AnalyseOrdonance.FITVD1_INTERACTION_VOIE_DOSE.Rows.Count - 1
            DsTheriaque_AnalyseOrdonance.FITVD1_INTERACTION_VOIE_DOSE.Rows(iCount).Delete()
        Next
        Me.FitvD1_TA.Update(DsTheriaque_AnalyseOrdonance)

        For iCount = 0 To DsTheriaque_AnalyseOrdonance.FITVD2_INTERACTION_VOIE_DOSE.Rows.Count - 1
            DsTheriaque_AnalyseOrdonance.FITVD2_INTERACTION_VOIE_DOSE.Rows(iCount).Delete()
        Next
        Me.FitvD2_TA.Update(DsTheriaque_AnalyseOrdonance)

        For iCount = 0 To DsTheriaque_AnalyseOrdonance.FITTER_TERRAINFAVORISANT.Rows.Count - 1
            DsTheriaque_AnalyseOrdonance.FITTER_TERRAINFAVORISANT.Rows(iCount).Delete()
        Next
        Me.FitteR_TA.Update(DsTheriaque_AnalyseOrdonance)

        For iCount = 0 To DsTheriaque_AnalyseOrdonance.FITCH_CRITERECHOIX.Rows.Count - 1
            DsTheriaque_AnalyseOrdonance.FITCH_CRITERECHOIX.Rows(iCount).Delete()
        Next
        Me.FitcH_TA.Update(DsTheriaque_AnalyseOrdonance)

        For iCount = 0 To DsTheriaque_AnalyseOrdonance.FITCT_COMMENTAIRE_TERRAIN.Rows.Count - 1
            DsTheriaque_AnalyseOrdonance.FITCT_COMMENTAIRE_TERRAIN.Rows(iCount).Delete()
        Next
        Me.FitcT_TA.Update(DsTheriaque_AnalyseOrdonance)


        DsTheriaque_AnalyseOrdonance.FIT_FICHEINTERAC.Rows(0).Delete()
        Me.FiT_TA.Update(Me.MasterDataSet)

        bModeDuplication = False
        Return True
    End Function

    Public Overrides Sub valider()

        'If (GV7.GetDataRow(0) Is Nothing Or GV72.GetDataRow(0) Is Nothing) Then
        '    MsgBox("Vous devez au moins remplir au moins une spécialité Terme1 et une spécialité Terme2")
        'Else
        Dim InteractionSimilaires As String = ValiderFicheSimilaire()
        Dim bValid As Boolean = True
        If (Not String.IsNullOrEmpty(InteractionSimilaires)) Then
            bValid = False
            If Process_Message("Les fiches (" & InteractionSimilaires.Substring(0, InteractionSimilaires.Length - 1) & ") sont similaires, vous voulez valider ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question).BtResult = MsgBoxResult.Yes Then
                bValid = True
            End If
        End If

        If (bValid) Then

            MyBase.Valider()

            Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
            FiT_TA.Update(Me.DsTheriaque_AnalyseOrdonance.FIT_FICHEINTERAC)

            Me.BindingContext(Me.MasterDataSet, IT1CPH_TERME1CLPHARMTHER).EndCurrentEdit()
            IT1CPH_TA.Update(Me.DsTheriaque_AnalyseOrdonance.IT1CPH_TERME1CLPHARMTHER)

            Me.BindingContext(Me.MasterDataSet, IT1CCH_TERME1CLCHIM).EndCurrentEdit()
            IT1CCH_TA.Update(Me.DsTheriaque_AnalyseOrdonance.IT1CCH_TERME1CLCHIM)

            Me.BindingContext(Me.MasterDataSet, IT1CC_TERM1COMCLASSE).EndCurrentEdit()
            IT1CC_TA.Update(Me.DsTheriaque_AnalyseOrdonance.IT1CC_TERM1COMCLASSE)

            Me.BindingContext(Me.MasterDataSet, IT1SAC_TERME1SUBACTIVE).EndCurrentEdit()
            IT1SAC_TA.Update(Me.DsTheriaque_AnalyseOrdonance.IT1SAC_TERME1SUBACTIVE)

            Me.BindingContext(Me.MasterDataSet, IT1SAU_TERME1SUBAUX).EndCurrentEdit()
            IT1SAU_TA.Update(Me.DsTheriaque_AnalyseOrdonance.IT1SAU_TERME1SUBAUX)

            Me.BindingContext(Me.MasterDataSet, IT1PR_TERME1PRODUIT).EndCurrentEdit()
            IT1PR_TA.Update(Me.DsTheriaque_AnalyseOrdonance.IT1PR_TERME1PRODUIT)

            Me.BindingContext(Me.MasterDataSet, IT1SP_TERME1SPECIALITE).EndCurrentEdit()
            IT1SP_TA.Update(Me.DsTheriaque_AnalyseOrdonance.IT1SP_TERME1SPECIALITE)

            'Terme2
            Me.BindingContext(Me.MasterDataSet, IT2CPH_TERME2CLPHARMTHER).EndCurrentEdit()
            IT2CPH_TA.Update(Me.DsTheriaque_AnalyseOrdonance.IT2CPH_TERME2CLPHARMTHER)

            Me.BindingContext(Me.MasterDataSet, IT2CCH_TERME2CLCHIM).EndCurrentEdit()
            IT2CCH_TA.Update(Me.DsTheriaque_AnalyseOrdonance.IT2CCH_TERME2CLCHIM)

            Me.BindingContext(Me.MasterDataSet, IT2CC_TERM2COMCLASSE).EndCurrentEdit()
            IT2CC_TA.Update(Me.DsTheriaque_AnalyseOrdonance.IT2CC_TERM2COMCLASSE)

            Me.BindingContext(Me.MasterDataSet, IT2SAC_TERME2SUBACTIVE).EndCurrentEdit()
            IT2SAC_TA.Update(Me.DsTheriaque_AnalyseOrdonance.IT2SAC_TERME2SUBACTIVE)

            Me.BindingContext(Me.MasterDataSet, IT2SAU_TERME2SUBAUX).EndCurrentEdit()
            IT2SAU_TA.Update(Me.DsTheriaque_AnalyseOrdonance.IT2SAU_TERME2SUBAUX)

            Me.BindingContext(Me.MasterDataSet, IT2PR_TERME2PRODUIT).EndCurrentEdit()
            IT2PR_TA.Update(Me.DsTheriaque_AnalyseOrdonance.IT2PR_TERME2PRODUIT)

            Me.BindingContext(Me.MasterDataSet, IT2SP_TERME2SPECIALITE).EndCurrentEdit()
            IT2SP_TA.Update(Me.DsTheriaque_AnalyseOrdonance.IT2SP_TERME2SPECIALITE)

            Me.BindingContext(Me.MasterDataSet, FITVD1_INTERACTION_VOIE_DOSE).EndCurrentEdit()
            FitvD1_TA.Update(Me.DsTheriaque_AnalyseOrdonance.FITVD1_INTERACTION_VOIE_DOSE)

            Me.BindingContext(Me.MasterDataSet, FITVD2_INTERACTION_VOIE_DOSE).EndCurrentEdit()
            FitvD2_TA.Update(Me.DsTheriaque_AnalyseOrdonance.FITVD2_INTERACTION_VOIE_DOSE)

            Me.BindingContext(Me.MasterDataSet, FITVA_NIVEAU_VALIDATION).EndCurrentEdit()
            FitvA_TA.Update(Me.DsTheriaque_AnalyseOrdonance.FITVA_NIVEAU_VALIDATION)

            Me.BindingContext(Me.MasterDataSet, FITNA_INTERACTION_NATURE).EndCurrentEdit()
            FitnA_TA.Update(Me.DsTheriaque_AnalyseOrdonance.FITNA_INTERACTION_NATURE)

            Me.BindingContext(Me.MasterDataSet, FITTY_TYPEINTERACTION).EndCurrentEdit()
            FittY_TA.Update(Me.DsTheriaque_AnalyseOrdonance.FITTY_TYPEINTERACTION)

            Me.BindingContext(Me.MasterDataSet, FITSE_INTERACTION_SENS).EndCurrentEdit()
            FitsE_TA.Update(Me.DsTheriaque_AnalyseOrdonance.FITSE_INTERACTION_SENS)

            Me.BindingContext(Me.MasterDataSet, FITTER_TERRAINFAVORISANT).EndCurrentEdit()
            FitteR_TA.Update(Me.DsTheriaque_AnalyseOrdonance.FITTER_TERRAINFAVORISANT)

            Me.BindingContext(Me.MasterDataSet, FITCT_COMMENTAIRE_TERRAIN).EndCurrentEdit()
            FitcT_TA.Update(Me.DsTheriaque_AnalyseOrdonance.FITCT_COMMENTAIRE_TERRAIN)

            Me.BindingContext(Me.MasterDataSet, FIT_FICHEINTERAC).EndCurrentEdit()
            FiT_TA.Update(Me.DsTheriaque_AnalyseOrdonance.FIT_FICHEINTERAC)

            Me.BindingContext(Me.MasterDataSet, FITCH_CRITERECHOIX).EndCurrentEdit()
            FitcH_TA.Update(Me.DsTheriaque_AnalyseOrdonance.FITCH_CRITERECHOIX)

            Me.BindingContext(Me.MasterDataSet, FITROF_REF_OFFICIELLE).EndCurrentEdit()
            FitroF_TA.Update(Me.DsTheriaque_AnalyseOrdonance.FITROF_REF_OFFICIELLE)

            bModeDuplication = False

            'End If

        End If


    End Sub


    Private Function ValiderFicheSimilaire() As String

        ' Construire la liste des spécialités terme1 
        Dim SpecIdTerm1 As New List(Of Integer)
        For i As Integer = 0 To GV7.RowCount - 1
            Try
                SpecIdTerm1.Add(Integer.Parse(GV7.GetDataRow(i).Item("IT1SP_SP_CODE_FK_PK").ToString()))
            Catch ex As Exception

            End Try
        Next
        SpecIdTerm1.Sort()

        ' Construire la liste des spécialités terme2 
        Dim SpecIdTerm2 As New List(Of Integer)
        For i As Integer = 0 To GV72.RowCount - 1
            Try
                SpecIdTerm2.Add(Integer.Parse(GV72.GetDataRow(i).Item("IT2SP_SP_CODE_FK_PK").ToString()))
            Catch ex As Exception

            End Try
        Next
        SpecIdTerm2.Sort()

        Dim dt As DataTable = GetInteractionSimilaire()
        Dim dr As DataRow
        Dim dtTerm1 As New DataTable
        Dim dtTerm2 As New DataTable

        Dim InteractionCode As Integer
        Dim InteractionsSimilaires As String = ""
        For Each dr In dt.Rows
            InteractionCode = Integer.Parse(dr.Item("FITVA_FIT_CODE_FK_PK").ToString())
            'Specialité terme1
            dtTerm1 = GetInteractionSpeciality(InteractionCode, 1)
            'Specialité terme2
            dtTerm2 = GetInteractionSpeciality(InteractionCode, 2)

            Dim similaire As Boolean = True

            If ((dtTerm1.Rows.Count = SpecIdTerm1.Count) And (dtTerm2.Rows.Count = SpecIdTerm2.Count)) Or ((dtTerm1.Rows.Count = SpecIdTerm2.Count) And (dtTerm2.Rows.Count = SpecIdTerm1.Count)) Then
                Dim i As Integer
                For i = 0 To dtTerm1.Rows.Count - 1
                    If (Integer.Parse(dtTerm1.Rows(i).Item(0).ToString()) <> Integer.Parse(SpecIdTerm1(i).ToString())) Then
                        similaire = False
                        Exit For
                    End If
                Next

                If (similaire) Then
                    For i = 0 To dtTerm2.Rows.Count - 1
                        If (Integer.Parse(dtTerm2.Rows(i).Item(0).ToString()) <> Integer.Parse(SpecIdTerm2(i).ToString())) Then
                            similaire = False
                            Exit For
                        End If
                    Next
                End If

                If (Not similaire) Then
                    similaire = True
                    For i = 0 To dtTerm1.Rows.Count - 1
                        If (Integer.Parse(dtTerm1.Rows(i).Item(0).ToString()) <> Integer.Parse(SpecIdTerm2(i).ToString())) Then
                            similaire = False
                            Exit For
                        End If
                    Next

                    If (similaire) Then
                        For i = 0 To dtTerm2.Rows.Count - 1
                            If (Integer.Parse(dtTerm2.Rows(i).Item(0).ToString()) <> Integer.Parse(SpecIdTerm1(i).ToString())) Then

                                similaire = False
                                Exit For
                            End If
                        Next
                    End If

                End If


            Else
                similaire = False
            End If
            If similaire Then
                InteractionsSimilaires += InteractionCode.ToString() + ","
            End If
        Next

        Return InteractionsSimilaires

    End Function

    Public Overrides Sub annuler()
        OnLoading = True
        MyBase.Annuler()

        Me.BindingContext(Me.DsTheriaque_AnalyseOrdonance, IT1CPH_TERME1CLPHARMTHER).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance.IT1CPH_TERME1CLPHARMTHER.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_AnalyseOrdonance, IT1CCH_TERME1CLCHIM).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance.IT1CCH_TERME1CLCHIM.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_AnalyseOrdonance, IT1CC_TERM1COMCLASSE).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance.IT1CC_TERM1COMCLASSE.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_AnalyseOrdonance, IT1SAC_TERME1SUBACTIVE).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance.IT1SAC_TERME1SUBACTIVE.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_AnalyseOrdonance, IT1SAU_TERME1SUBAUX).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance.IT1SAU_TERME1SUBAUX.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_AnalyseOrdonance, IT1PR_TERME1PRODUIT).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance.IT1PR_TERME1PRODUIT.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_AnalyseOrdonance, IT1SP_TERME1SPECIALITE).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance.IT1SP_TERME1SPECIALITE.RejectChanges()

        'Terme2
        Me.BindingContext(Me.DsTheriaque_AnalyseOrdonance, IT2CPH_TERME2CLPHARMTHER).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance.IT2CPH_TERME2CLPHARMTHER.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_AnalyseOrdonance, IT2CCH_TERME2CLCHIM).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance.IT2CCH_TERME2CLCHIM.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_AnalyseOrdonance, IT2CC_TERM2COMCLASSE).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance.IT2CC_TERM2COMCLASSE.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_AnalyseOrdonance, IT2SAC_TERME2SUBACTIVE).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance.IT2SAC_TERME2SUBACTIVE.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_AnalyseOrdonance, IT2SAU_TERME2SUBAUX).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance.IT2SAU_TERME2SUBAUX.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_AnalyseOrdonance, IT2PR_TERME2PRODUIT).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance.IT2PR_TERME2PRODUIT.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_AnalyseOrdonance, IT2SP_TERME2SPECIALITE).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance.IT2SP_TERME2SPECIALITE.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_AnalyseOrdonance, FITVD1_INTERACTION_VOIE_DOSE).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance.FITVD1_INTERACTION_VOIE_DOSE.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_AnalyseOrdonance, FITVD2_INTERACTION_VOIE_DOSE).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance.FITVD2_INTERACTION_VOIE_DOSE.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_AnalyseOrdonance, FITVA_NIVEAU_VALIDATION).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance.FITVA_NIVEAU_VALIDATION.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_AnalyseOrdonance, FITNA_INTERACTION_NATURE).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance.FITNA_INTERACTION_NATURE.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_AnalyseOrdonance, FITTY_TYPEINTERACTION).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance.FITTY_TYPEINTERACTION.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_AnalyseOrdonance, FITSE_INTERACTION_SENS).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance.FITSE_INTERACTION_SENS.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_AnalyseOrdonance, FITTER_TERRAINFAVORISANT).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance.FITTER_TERRAINFAVORISANT.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_AnalyseOrdonance, FITCT_COMMENTAIRE_TERRAIN).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance.FITCT_COMMENTAIRE_TERRAIN.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance.FIT_FICHEINTERAC.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_AnalyseOrdonance, FITCH_CRITERECHOIX).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance.FITCH_CRITERECHOIX.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_AnalyseOrdonance, FITROF_REF_OFFICIELLE).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance.FITROF_REF_OFFICIELLE.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance.FIT_FICHEINTERAC.RejectChanges()

        If bModeDuplication Then EmptyDataTable()
        bModeDuplication = False
        OnLoading = False
    End Sub

    Private Sub EmptyDataTable()
        Me.DsTheriaque_AnalyseOrdonance.FIT_FICHEINTERAC.Clear()
        Me.DsTheriaque_AnalyseOrdonance.IT1CPH_TERME1CLPHARMTHER.Clear()
        Me.DsTheriaque_AnalyseOrdonance.IT1CCH_TERME1CLCHIM.Clear()
        Me.DsTheriaque_AnalyseOrdonance.IT1CC_TERM1COMCLASSE.Clear()
        Me.DsTheriaque_AnalyseOrdonance.IT1SAC_TERME1SUBACTIVE.Clear()
        Me.DsTheriaque_AnalyseOrdonance.IT1SAU_TERME1SUBAUX.Clear()
        Me.DsTheriaque_AnalyseOrdonance.IT1PR_TERME1PRODUIT.Clear()
        Me.DsTheriaque_AnalyseOrdonance.IT1SP_TERME1SPECIALITE.Clear()
        'Terme2
        Me.DsTheriaque_AnalyseOrdonance.IT2CPH_TERME2CLPHARMTHER.Clear()
        Me.DsTheriaque_AnalyseOrdonance.IT2CCH_TERME2CLCHIM.Clear()
        Me.DsTheriaque_AnalyseOrdonance.IT2CC_TERM2COMCLASSE.Clear()
        Me.DsTheriaque_AnalyseOrdonance.IT2SAC_TERME2SUBACTIVE.Clear()
        Me.DsTheriaque_AnalyseOrdonance.IT2SAU_TERME2SUBAUX.Clear()
        Me.DsTheriaque_AnalyseOrdonance.IT2PR_TERME2PRODUIT.Clear()
        Me.DsTheriaque_AnalyseOrdonance.IT2SP_TERME2SPECIALITE.Clear()

        Me.DsTheriaque_AnalyseOrdonance.FITVD1_INTERACTION_VOIE_DOSE.Clear()
        Me.DsTheriaque_AnalyseOrdonance.FITVD2_INTERACTION_VOIE_DOSE.Clear()
        Me.DsTheriaque_AnalyseOrdonance.FITVA_NIVEAU_VALIDATION.Clear()
        Me.DsTheriaque_AnalyseOrdonance.FITNA_INTERACTION_NATURE.Clear()
        Me.DsTheriaque_AnalyseOrdonance.FITTY_TYPEINTERACTION.Clear()
        Me.DsTheriaque_AnalyseOrdonance.FITSE_INTERACTION_SENS.Clear()
        Me.DsTheriaque_AnalyseOrdonance.FITTER_TERRAINFAVORISANT.Clear()
        Me.DsTheriaque_AnalyseOrdonance.FITCT_COMMENTAIRE_TERRAIN.Clear()
        Me.DsTheriaque_AnalyseOrdonance.FIT_FICHEINTERAC.Clear()
        Me.DsTheriaque_AnalyseOrdonance.FITCH_CRITERECHOIX.Clear()
        Me.DsTheriaque_AnalyseOrdonance.FITROF_REF_OFFICIELLE.Clear()

    End Sub

    ''' <summary>
    ''' Proçédure: Duplication des données à partir d'une autre fiche
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub Dupliquer()

        'Sauvegarde des données à duplquer

        'Onglet1
        Dim dt1 As New DataTable
        dt1 = DsTheriaque_AnalyseOrdonance.IT1CPH_TERME1CLPHARMTHER.Copy

        Dim dt2 As New DataTable
        dt2 = DsTheriaque_AnalyseOrdonance.IT1CCH_TERME1CLCHIM.Copy

        Dim dt3 As New DataTable
        dt3 = DsTheriaque_AnalyseOrdonance.IT1CC_TERM1COMCLASSE.Copy

        Dim dt4 As New DataTable
        dt4 = DsTheriaque_AnalyseOrdonance.IT1SAC_TERME1SUBACTIVE.Copy

        Dim dt5 As New DataTable
        dt5 = DsTheriaque_AnalyseOrdonance.IT1SAU_TERME1SUBAUX.Copy

        Dim dt6 As New DataTable
        dt6 = DsTheriaque_AnalyseOrdonance.IT1PR_TERME1PRODUIT.Copy

        Dim dt7 As New DataTable
        dt7 = DsTheriaque_AnalyseOrdonance.IT1SP_TERME1SPECIALITE.Copy

        'Onglet2
        Dim dt12 As New DataTable
        dt12 = DsTheriaque_AnalyseOrdonance.IT2CPH_TERME2CLPHARMTHER.Copy

        Dim dt22 As New DataTable
        dt22 = DsTheriaque_AnalyseOrdonance.IT2CCH_TERME2CLCHIM.Copy

        Dim dt32 As New DataTable
        dt32 = DsTheriaque_AnalyseOrdonance.IT2CC_TERM2COMCLASSE.Copy

        Dim dt42 As New DataTable
        dt42 = DsTheriaque_AnalyseOrdonance.IT2SAC_TERME2SUBACTIVE.Copy

        Dim dt52 As New DataTable
        dt52 = DsTheriaque_AnalyseOrdonance.IT2SAU_TERME2SUBAUX.Copy

        Dim dt62 As New DataTable
        dt62 = DsTheriaque_AnalyseOrdonance.IT2PR_TERME2PRODUIT.Copy

        Dim dt72 As New DataTable
        dt72 = DsTheriaque_AnalyseOrdonance.IT2SP_TERME2SPECIALITE.Copy

        'Onglet3
        Dim dt13 As New DataTable
        dt13 = DsTheriaque_AnalyseOrdonance.FITVD1_INTERACTION_VOIE_DOSE.Copy

        Dim dt33 As New DataTable
        dt33 = DsTheriaque_AnalyseOrdonance.FITVD2_INTERACTION_VOIE_DOSE.Copy

        'Onglet4
        Dim dt14 As New DataTable
        dt14 = DsTheriaque_AnalyseOrdonance.FITVA_NIVEAU_VALIDATION.Copy

        Dim dt24 As New DataTable
        dt24 = DsTheriaque_AnalyseOrdonance.FITNA_INTERACTION_NATURE.Copy

        Dim dt34 As New DataTable
        dt34 = DsTheriaque_AnalyseOrdonance.FITTY_TYPEINTERACTION.Copy

        Dim dt44 As New DataTable
        dt44 = DsTheriaque_AnalyseOrdonance.FITSE_INTERACTION_SENS.Copy

        Dim dt54 As New DataTable
        dt54 = DsTheriaque_AnalyseOrdonance.FITTER_TERRAINFAVORISANT.Copy

        Dim dt64 As New DataTable
        dt64 = DsTheriaque_AnalyseOrdonance.FITCT_COMMENTAIRE_TERRAIN.Copy

        Dim sText As String = MemoEdit1.Text

        'Onglet5
        Dim dt16 As New DataTable
        dt16 = DsTheriaque_AnalyseOrdonance.FITROF_REF_OFFICIELLE.Copy

        'Vider les contrôles
        EmptyDataTable()

        'Construction de la nouvelle fiche avec les données de la fiche de base
        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        SetCode_MAx(MasterTable, txtCode)
        CodE = InvalidCode
        Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"

        Dim drTemp As DataRow
        For iCount As Integer = 0 To dt1.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance.Tables("IT1CPH_TERME1CLPHARMTHER").NewRow()
            drTemp.ItemArray = dt1.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance.Tables("IT1CPH_TERME1CLPHARMTHER").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt2.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance.Tables("IT1CCH_TERME1CLCHIM").NewRow()
            drTemp.ItemArray = dt2.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance.Tables("IT1CCH_TERME1CLCHIM").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt3.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance.Tables("IT1CC_TERM1COMCLASSE").NewRow()
            drTemp.ItemArray = dt3.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance.Tables("IT1CC_TERM1COMCLASSE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt4.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance.Tables("IT1SAC_TERME1SUBACTIVE").NewRow()
            drTemp.ItemArray = dt4.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance.Tables("IT1SAC_TERME1SUBACTIVE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt5.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance.Tables("IT1SAU_TERME1SUBAUX").NewRow()
            drTemp.ItemArray = dt5.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance.Tables("IT1SAU_TERME1SUBAUX").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt6.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance.Tables("IT1PR_TERME1PRODUIT").NewRow()
            drTemp.ItemArray = dt6.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance.Tables("IT1PR_TERME1PRODUIT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt7.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance.Tables("IT1SP_TERME1SPECIALITE").NewRow()
            drTemp.ItemArray = dt7.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance.Tables("IT1SP_TERME1SPECIALITE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt12.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance.Tables("IT2CPH_TERME2CLPHARMTHER").NewRow()
            drTemp.ItemArray = dt12.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance.Tables("IT2CPH_TERME2CLPHARMTHER").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt22.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance.Tables("IT2CCH_TERME2CLCHIM").NewRow()
            drTemp.ItemArray = dt22.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance.Tables("IT2CCH_TERME2CLCHIM").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt32.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance.Tables("IT2CC_TERM2COMCLASSE").NewRow()
            drTemp.ItemArray = dt32.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance.Tables("IT2CC_TERM2COMCLASSE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt42.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance.Tables("IT2SAC_TERME2SUBACTIVE").NewRow()
            drTemp.ItemArray = dt42.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance.Tables("IT2SAC_TERME2SUBACTIVE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt52.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance.Tables("IT2SAU_TERME2SUBAUX").NewRow()
            drTemp.ItemArray = dt52.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance.Tables("IT2SAU_TERME2SUBAUX").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt62.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance.Tables("IT2PR_TERME2PRODUIT").NewRow()
            drTemp.ItemArray = dt62.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance.Tables("IT2PR_TERME2PRODUIT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt72.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance.Tables("IT2SP_TERME2SPECIALITE").NewRow()
            drTemp.ItemArray = dt72.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance.Tables("IT2SP_TERME2SPECIALITE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt13.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance.Tables("FITVD1_INTERACTION_VOIE_DOSE").NewRow()
            drTemp.ItemArray = dt13.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance.Tables("FITVD1_INTERACTION_VOIE_DOSE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt33.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance.Tables("FITVD2_INTERACTION_VOIE_DOSE").NewRow()
            drTemp.ItemArray = dt33.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance.Tables("FITVD2_INTERACTION_VOIE_DOSE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt14.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance.Tables("FITVA_NIVEAU_VALIDATION").NewRow()
            drTemp.ItemArray = dt14.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance.Tables("FITVA_NIVEAU_VALIDATION").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt24.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance.Tables("FITNA_INTERACTION_NATURE").NewRow()
            drTemp.ItemArray = dt24.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance.Tables("FITNA_INTERACTION_NATURE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt34.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance.Tables("FITTY_TYPEINTERACTION").NewRow()
            drTemp.ItemArray = dt34.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance.Tables("FITTY_TYPEINTERACTION").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt44.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance.Tables("FITSE_INTERACTION_SENS").NewRow()
            drTemp.ItemArray = dt44.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance.Tables("FITSE_INTERACTION_SENS").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt54.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance.Tables("FITTER_TERRAINFAVORISANT").NewRow()
            drTemp.ItemArray = dt54.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance.Tables("FITTER_TERRAINFAVORISANT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt64.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance.Tables("FITCT_COMMENTAIRE_TERRAIN").NewRow()
            drTemp.ItemArray = dt64.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance.Tables("FITCT_COMMENTAIRE_TERRAIN").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt16.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance.Tables("FITROF_REF_OFFICIELLE").NewRow()
            drTemp.ItemArray = dt16.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance.Tables("FITROF_REF_OFFICIELLE").Rows.Add(drTemp)
        Next

        MemoEdit1.Text = sText
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
            GV1.SetRowCellValue(iCount, colIT1CPH_FIT_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV2
        For iCount As Integer = 0 To GV2.RowCount - 1
            GV2.SetRowCellValue(iCount, colIT1CCH_FIT_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV3
        For iCount As Integer = 0 To GV3.RowCount - 1
            GV3.SetRowCellValue(iCount, colIT1CC_FIT_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV4
        For iCount As Integer = 0 To GV4.RowCount - 1
            GV4.SetRowCellValue(iCount, colIT1SAC_FIT_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV5
        For iCount As Integer = 0 To GV5.RowCount - 1
            GV5.SetRowCellValue(iCount, colIT1SAU_FIT_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV6
        For iCount As Integer = 0 To GV6.RowCount - 1
            GV6.SetRowCellValue(iCount, colIT1PR_FIT_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV7
        For iCount As Integer = 0 To GV7.RowCount - 1
            GV7.SetRowCellValue(iCount, colIT1SP_FIT_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV12
        For iCount As Integer = 0 To GV12.RowCount - 1
            GV12.SetRowCellValue(iCount, colIT2CPH_FIT_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV22
        For iCount As Integer = 0 To GV22.RowCount - 1
            GV22.SetRowCellValue(iCount, colIT2CCH_FIT_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV32
        For iCount As Integer = 0 To GV32.RowCount - 1
            GV32.SetRowCellValue(iCount, colIT2CC_FIT_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV42
        For iCount As Integer = 0 To GV42.RowCount - 1
            GV42.SetRowCellValue(iCount, colIT2SAC_FIT_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV52
        For iCount As Integer = 0 To GV52.RowCount - 1
            GV52.SetRowCellValue(iCount, colIT2SAU_FIT_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV62
        For iCount As Integer = 0 To GV62.RowCount - 1
            GV62.SetRowCellValue(iCount, colIT2PR_FIT_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV72
        For iCount As Integer = 0 To GV72.RowCount - 1
            GV72.SetRowCellValue(iCount, colIT2SP_FIT_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV13
        For iCount As Integer = 0 To GV13.RowCount - 1
            GV13.SetRowCellValue(iCount, colFITVD1_FIT_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV33
        For iCount As Integer = 0 To GV33.RowCount - 1
            GV33.SetRowCellValue(iCount, colFITVD2_FIT_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV14
        For iCount As Integer = 0 To GV14.RowCount - 1
            GV14.SetRowCellValue(iCount, colFITVA_FIT_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV24
        For iCount As Integer = 0 To GV24.RowCount - 1
            GV24.SetRowCellValue(iCount, colFITNA_FIT_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV34
        For iCount As Integer = 0 To GV34.RowCount - 1
            GV34.SetRowCellValue(iCount, colFITTY_FIT_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV44
        For iCount As Integer = 0 To GV44.RowCount - 1
            GV44.SetRowCellValue(iCount, colFITSE_FIT_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV54
        For iCount As Integer = 0 To GV54.RowCount - 1
            GV54.SetRowCellValue(iCount, colFITTER_FIT_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV64
        For iCount As Integer = 0 To GV64.RowCount - 1
            GV64.SetRowCellValue(iCount, colFITCT_FIT_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV16
        For iCount As Integer = 0 To GV16.RowCount - 1
            GV16.SetRowCellValue(iCount, colFITROF_FIT_CODE_FK_PK, Me.txtCode.Text)
        Next
    End Sub
#End Region

#Region " Init Data  "

    Private Sub InitDataSource()
        GC1.DataSource = DsTheriaque_AnalyseOrdonance
        GC1.DataMember = IT1CPH_TERME1CLPHARMTHER

        GC2.DataSource = DsTheriaque_AnalyseOrdonance
        GC2.DataMember = IT1CCH_TERME1CLCHIM

        GC3.DataSource = DsTheriaque_AnalyseOrdonance
        GC3.DataMember = IT1CC_TERM1COMCLASSE

        GC4.DataSource = DsTheriaque_AnalyseOrdonance
        GC4.DataMember = IT1SAC_TERME1SUBACTIVE

        GC5.DataSource = DsTheriaque_AnalyseOrdonance
        GC5.DataMember = IT1SAU_TERME1SUBAUX

        GC6.DataSource = DsTheriaque_AnalyseOrdonance
        GC6.DataMember = IT1PR_TERME1PRODUIT

        GC7.DataSource = DsTheriaque_AnalyseOrdonance
        GC7.DataMember = IT1SP_TERME1SPECIALITE

        'Terme2
        GC12.DataSource = DsTheriaque_AnalyseOrdonance
        GC12.DataMember = IT2CPH_TERME2CLPHARMTHER

        GC22.DataSource = DsTheriaque_AnalyseOrdonance
        GC22.DataMember = IT2CCH_TERME2CLCHIM

        GC32.DataSource = DsTheriaque_AnalyseOrdonance
        GC32.DataMember = IT2CC_TERM2COMCLASSE

        GC42.DataSource = DsTheriaque_AnalyseOrdonance
        GC42.DataMember = IT2SAC_TERME2SUBACTIVE

        GC52.DataSource = DsTheriaque_AnalyseOrdonance
        GC52.DataMember = IT2SAU_TERME2SUBAUX

        GC62.DataSource = DsTheriaque_AnalyseOrdonance
        GC62.DataMember = IT2PR_TERME2PRODUIT

        GC72.DataSource = DsTheriaque_AnalyseOrdonance
        GC72.DataMember = IT2SP_TERME2SPECIALITE

        GC13.DataSource = DsTheriaque_AnalyseOrdonance
        GC13.DataMember = FITVD1_INTERACTION_VOIE_DOSE

        GC33.DataSource = DsTheriaque_AnalyseOrdonance
        GC33.DataMember = FITVD2_INTERACTION_VOIE_DOSE

        GC14.DataSource = DsTheriaque_AnalyseOrdonance
        GC14.DataMember = FITVA_NIVEAU_VALIDATION

        GC24.DataSource = DsTheriaque_AnalyseOrdonance
        GC24.DataMember = FITNA_INTERACTION_NATURE

        GC34.DataSource = DsTheriaque_AnalyseOrdonance
        GC34.DataMember = FITTY_TYPEINTERACTION

        GC44.DataSource = DsTheriaque_AnalyseOrdonance
        GC44.DataMember = FITSE_INTERACTION_SENS

        GC54.DataSource = DsTheriaque_AnalyseOrdonance
        GC54.DataMember = FITTER_TERRAINFAVORISANT

        GC64.DataSource = DsTheriaque_AnalyseOrdonance
        GC64.DataMember = FITCT_COMMENTAIRE_TERRAIN

        GC25.DataSource = DsTheriaque_AnalyseOrdonance
        GC25.DataMember = FITCH_CRITERECHOIX

        GC16.DataSource = DsTheriaque_AnalyseOrdonance
        GC16.DataMember = FITROF_REF_OFFICIELLE

    End Sub

    Public Overrides Sub InitData()
        MyBase.InitData()
        Declinaison_Global = True
        OnLoading = True
        MasterDataSet = Me.DsTheriaque_AnalyseOrdonance
        MasterTable = FIT_FICHEINTERAC
        CodE = InvalidCode

        Dim List5 As New System.Collections.Generic.List(Of StructGVTable)
        List5.Add(New StructGVTable("GC1", eDeclinaison.CPH, colIT1CPH_CPH_CODE_FK_PK2))
        List5.Add(New StructGVTable("GC2", eDeclinaison.CCH, colIT1CCH_CCH_CODE_FK_PK2))
        List5.Add(New StructGVTable("GC4", eDeclinaison.SAC, colIT1_TERM1SAC))
        List5.Add(New StructGVTable("GC7", eDeclinaison.SP, colIT1SP_SP_CODE_FK_PK2))
        Dim dec5 As New ClsDeclinaison(eDeclinaison.CPH, List5)
        InitLkup(Me.lkup_IT1CPH, CPH_CLASSEPHARMTHER, strSSQL_CPH_CLASSEPHARMTHER, True, , , , , , dec5)

        Dim List6 As New System.Collections.Generic.List(Of StructGVTable)
        List6.Add(New StructGVTable("GC1", eDeclinaison.CPH, colIT1CPH_CPH_CODE_FK_PK2))
        List6.Add(New StructGVTable("GC2", eDeclinaison.CCH, colIT1CCH_CCH_CODE_FK_PK2))
        List6.Add(New StructGVTable("GC4", eDeclinaison.SAC, colIT1_TERM1SAC))
        List6.Add(New StructGVTable("GC5", eDeclinaison.SAU, colIT1_IT1SAU))
        List6.Add(New StructGVTable("GC7", eDeclinaison.SP, colIT1SP_SP_CODE_FK_PK2))
        Dim dec6 As New ClsDeclinaison(eDeclinaison.CCH, List6)
        InitLkup(Me.lkup_IT1CCH, CCH_CLASSECHIMIQUE, strSSQL_CCH_CLASSECHIMIQUE, True, , , , , , dec6)

        InitLkup(Me.lkup_IT1CC, IT1CC_TERM1COMCLASSE, strSSQL_CDF_CODIF("IC"), True)

        Dim List As New System.Collections.Generic.List(Of StructGVTable)
        List.Add(New StructGVTable("GC4", eDeclinaison.SAC, colIT1_TERM1SAC))
        List.Add(New StructGVTable("GC7", eDeclinaison.SP, colIT1SP_SP_CODE_FK_PK2))
        Dim dec As New ClsDeclinaison(eDeclinaison.SAC, List)
        InitLkup(Me.lkup_IT1SAC, IT1SAC_TERME1SUBACTIVE, strSSQL_SAC_SUBACTIVE, True, , , , , , dec)

        Dim List3 As New System.Collections.Generic.List(Of StructGVTable)
        List3.Add(New StructGVTable("GC5", eDeclinaison.SAU, colIT1_IT1SAU))
        List3.Add(New StructGVTable("GC7", eDeclinaison.SP, colIT1SP_SP_CODE_FK_PK2))
        Dim dec3 As New ClsDeclinaison(eDeclinaison.SAU, List3)
        InitLkup(Me.lkup_IT1SAU, IT1SAU_TERME1SUBAUX, strSSQL_SAU_SUBAUXILIAIRE, True, , , , , , dec3)

        Dim List11 As New System.Collections.Generic.List(Of StructGVTable)
        List11.Add(New StructGVTable("GC6", eDeclinaison.PR, colIT1PR_PR_CODE_FK_PK2))
        List11.Add(New StructGVTable("GC7", eDeclinaison.SP, colIT1SP_SP_CODE_FK_PK2))
        Dim dec11 As New ClsDeclinaison(eDeclinaison.PR, List11)
        InitLkup(Me.lkup_IT1PR, PR_PRODUIT, strSSQL_PR_PRODUIT, True, , , , , , dec11)

        InitLkup(Me.lkup_IT1SP, IT1SP_TERME1SPECIALITE, strSSQL_SP_SPECIALITE, True)

        'Terme2
        Dim List7 As New System.Collections.Generic.List(Of StructGVTable)
        List7.Add(New StructGVTable("GC12", eDeclinaison.CPH, colIT1CPH_CPH_CODE_FK_PK2_2))
        List7.Add(New StructGVTable("GC22", eDeclinaison.CCH, colIT1CCH_CCH_CODE_FK_PK2_2))
        List7.Add(New StructGVTable("GC42", eDeclinaison.SAC, colIT2SAC_SAC_CODE_FK_PK2))
        List7.Add(New StructGVTable("GC72", eDeclinaison.SP, colIT2SP_SP_CODE_FK_PK2))
        Dim dec7 As New ClsDeclinaison(eDeclinaison.CPH, List7)
        InitLkup(Me.lkup_IT2CPH, CPH_CLASSEPHARMTHER, strSSQL_CPH_CLASSEPHARMTHER, True, , , , , , dec7)

        Dim List8 As New System.Collections.Generic.List(Of StructGVTable)
        List8.Add(New StructGVTable("GC12", eDeclinaison.CPH, colIT1CPH_CPH_CODE_FK_PK2_2))
        List8.Add(New StructGVTable("GC22", eDeclinaison.CCH, colIT1CCH_CCH_CODE_FK_PK2_2))
        List8.Add(New StructGVTable("GC42", eDeclinaison.SAC, colIT2SAC_SAC_CODE_FK_PK2))
        List8.Add(New StructGVTable("GC72", eDeclinaison.SP, colIT2SP_SP_CODE_FK_PK2))
        Dim dec8 As New ClsDeclinaison(eDeclinaison.CCH, List8)
        InitLkup(Me.lkup_IT2CCH, CCH_CLASSECHIMIQUE, strSSQL_CCH_CLASSECHIMIQUE, True, , , , , , dec8)

        InitLkup(Me.lkup_IT2CC, IT2CC_TERM2COMCLASSE, strSSQL_CDF_CODIF("IC"), True)

        Dim List2 As New System.Collections.Generic.List(Of StructGVTable)
        List2.Add(New StructGVTable("GC42", eDeclinaison.SAC, colIT2SAC_SAC_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC72", eDeclinaison.SP, colIT2SP_SP_CODE_FK_PK2))
        Dim Dec2 As New ClsDeclinaison(eDeclinaison.SAC, List2)
        InitLkup(Me.lkup_IT2SAC, IT2SAC_TERME2SUBACTIVE, strSSQL_SAC_SUBACTIVE, True, , , , , , Dec2)

        Dim List9 As New System.Collections.Generic.List(Of StructGVTable)
        List9.Add(New StructGVTable("GC52", eDeclinaison.SAU, colIT2SAU))
        List9.Add(New StructGVTable("GC72", eDeclinaison.SP, colIT2SP_SP_CODE_FK_PK2))
        Dim dec9 As New ClsDeclinaison(eDeclinaison.SAU, List9)
        InitLkup(Me.lkup_IT2SAU, IT2SAU_TERME2SUBAUX, strSSQL_SAU_SUBAUXILIAIRE, True, , , , , , dec9)

        InitLkup(Me.lkup_IT2PR, PR_PRODUIT, strSSQL_PR_PRODUIT, True)
        InitLkup(Me.lkup_IT2SP, IT2SP_TERME2SPECIALITE, strSSQL_SP_SPECIALITE, True)

        InitLkup(Me.lkup_FITVD1, CDF_CODIF, strSSQL_CDF_CODIF("18"), True)
        InitLkup(Me.lkup2_FITVD1, CDF_CODIF, strSSQL_CDF_CODIF("PP"), True)
        InitLkup(Me.lkup_FITVD2, CDF_CODIF, strSSQL_CDF_CODIF("18"), True)
        InitLkup(Me.lkup2_FITVD2, CDF_CODIF, strSSQL_CDF_CODIF("PP"), True)
        InitLkup(Me.lkup_FITVA, CDF_CODIF, strSSQL_CDF_CODIF("IV"), True)
        InitLkup(Me.lkup_FITNA, CDF_CODIF, strSSQL_CDF_CODIF("IN"), True)
        InitLkup(Me.lkup_FITTY, CDF_CODIF, strSSQL_CDF_CODIF("IY"), True)
        InitLkup(Me.lkup_FITSE, CDF_CODIF, strSSQL_CDF_CODIF("IS"), True)
        InitLkup(Me.lkup_FITTER, CDF_CODIF, strSSQL_CDF_CODIF_NIVEAU("CS"), True)
        InitLkup(Me.lkup_FITCT, CDF_CODIF, strSSQL_CDF_CODIF("CC"), True)
        InitLkup(Me.lkup_FITCH, CH_CHOIX, strSSQL_CH_CHOIX, True)
        InitLkup(Me.lkup_FITROF, CDF_CODIF, strSSQL_CDF_CODIF("25"), True)
        InitDataSource()
        FirstFocus = GC1

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

#End Region

#Region " New Row "

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub GV1_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV1.InitNewRow
        If OnLoading Then Exit Sub
        GV1.SetFocusedRowCellValue(colIT1CPH_FIT_CODE_FK_PK, txtCode.Text)
        Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"
    End Sub

    Private Sub GV2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        If OnLoading Then Exit Sub
        GV2.SetFocusedRowCellValue(colIT1CCH_FIT_CODE_FK_PK, txtCode.Text)
        Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"
    End Sub

    Private Sub GV3_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV3.InitNewRow
        If OnLoading Then Exit Sub
        GV3.SetFocusedRowCellValue(colIT1CC_FIT_CODE_FK_PK, txtCode.Text)
        Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"
        GV3.SetFocusedRowCellValue(colIT1CC_NUMORD, Code_MAx(GV3, colIT1CC_NUMORD))
    End Sub

    Private Sub GV4_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV4.InitNewRow
        If OnLoading Then Exit Sub
        GV4.SetFocusedRowCellValue(colIT1SAC_FIT_CODE_FK_PK, txtCode.Text)
        Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"
    End Sub

    Private Sub GV5_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV5.InitNewRow
        GV5.SetFocusedRowCellValue(colIT1SAU_FIT_CODE_FK_PK, txtCode.Text)
        Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"
    End Sub

    Private Sub GV6_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV6.InitNewRow
        GV6.SetFocusedRowCellValue(colIT1PR_FIT_CODE_FK_PK, txtCode.Text)
        Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"
    End Sub

    Private Sub GV7_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV7.InitNewRow
        GV7.SetFocusedRowCellValue(colIT1SP_FIT_CODE_FK_PK, txtCode.Text)
        Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"
    End Sub

    Private Sub GV12_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV12.InitNewRow
        GV12.SetFocusedRowCellValue(colIT2CPH_FIT_CODE_FK_PK, txtCode.Text)
        Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"
    End Sub

    Private Sub GV22_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV22.InitNewRow
        GV22.SetFocusedRowCellValue(colIT2CCH_FIT_CODE_FK_PK, txtCode.Text)
        Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"
    End Sub

    Private Sub GV32_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV32.InitNewRow
        If OnLoading Then Exit Sub
        GV32.SetFocusedRowCellValue(colIT2CC_FIT_CODE_FK_PK, txtCode.Text)
        Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"
        GV32.SetFocusedRowCellValue(colIT2CC_NUMORD, Code_MAx(GV32, colIT2CC_NUMORD))
    End Sub

    Private Sub GV42_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV42.InitNewRow
        If OnLoading Then Exit Sub
        GV42.SetFocusedRowCellValue(colIT2SAC_FIT_CODE_FK_PK, txtCode.Text)
        Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"
    End Sub

    Private Sub GV52_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV52.InitNewRow
        GV52.SetFocusedRowCellValue(colIT2SAU_FIT_CODE_FK_PK, txtCode.Text)
        Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"
    End Sub

    Private Sub GV62_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV62.InitNewRow
        GV62.SetFocusedRowCellValue(colIT2PR_FIT_CODE_FK_PK, txtCode.Text)
        Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"
    End Sub

    Private Sub GV72_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV72.InitNewRow
        GV72.SetFocusedRowCellValue(colIT2SP_FIT_CODE_FK_PK, txtCode.Text)
        Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"
    End Sub

    Private Sub GV13_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV13.InitNewRow
        GV13.SetFocusedRowCellValue(colFITVD1_FIT_CODE_FK_PK, txtCode.Text)
        GV13.SetFocusedRowCellValue(colFITVD1_NUMORD, Code_MAx(GV13, colFITVD1_NUMORD))
        GV13.SetFocusedRowCellValue(colFITVD1_NUMSEQ_PK, Code_MAx(GV13, colFITVD1_NUMSEQ_PK))
        Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"
    End Sub


    Private Sub GV33_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV33.InitNewRow
        GV33.SetFocusedRowCellValue(colFITVD2_FIT_CODE_FK_PK, txtCode.Text)
        GV33.SetFocusedRowCellValue(colFITVD2_NUMORD, Code_MAx(GV33, colFITVD2_NUMORD))
        GV33.SetFocusedRowCellValue(colFITVD2_NUMSEQ_PK, Code_MAx(GV33, colFITVD2_NUMSEQ_PK))
        Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"
    End Sub

    Private Sub GV14_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV14.InitNewRow
        GV14.SetFocusedRowCellValue(colFITVA_FIT_CODE_FK_PK, txtCode.Text)
        GV14.SetFocusedRowCellValue(colFITVA_NUMORD, Code_MAx(GV14, colFITVA_NUMORD))
        Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"
    End Sub

    Private Sub GV24_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV24.InitNewRow
        GV24.SetFocusedRowCellValue(colFITNA_FIT_CODE_FK_PK, txtCode.Text)
        GV24.SetFocusedRowCellValue(colFITNA_NUMORD, Code_MAx(GV24, colFITNA_NUMORD))
        Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"
    End Sub

    Private Sub GV34_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV34.InitNewRow
        GV34.SetFocusedRowCellValue(colFITTY_FIT_CODE_FK_PK, txtCode.Text)
        GV34.SetFocusedRowCellValue(colFITTY_NUMORD, Code_MAx(GV34, colFITTY_NUMORD))
        Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"
    End Sub

    Private Sub GV44_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV44.InitNewRow
        GV44.SetFocusedRowCellValue(colFITSE_FIT_CODE_FK_PK, txtCode.Text)
        GV44.SetFocusedRowCellValue(colFITSE_NUMORD, Code_MAx(GV44, colFITSE_NUMORD))
        Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"
    End Sub

    Private Sub GV54_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV54.InitNewRow
        GV54.SetFocusedRowCellValue(colFITTER_FIT_CODE_FK_PK, txtCode.Text)
        'Dim iMax As Integer
        'iMax = Code_MAx(FITTER_TERRAINFAVORISANT, "FITTER_NUMORD") + 1
        'Me.BindingContext(DsTheriaque_AnalyseOrdonance, FITTER_TERRAINFAVORISANT).Current("FITTER_NUMORD") = Convert.ToString(iMax)
        GV54.SetFocusedRowCellValue(colFITTER_NUMORD, Code_MAx(GV54, colFITTER_NUMORD))
        Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"
    End Sub

    Private Sub GV64_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV64.InitNewRow
        GV64.SetFocusedRowCellValue(colFITCT_FIT_CODE_FK_PK, txtCode.Text)
        GV64.SetFocusedRowCellValue(colFITCT_NUMORD, Code_MAx(GV64, colFITCT_NUMORD))
        Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"
    End Sub

    Private Sub GV25_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV25.InitNewRow
        GV25.SetFocusedRowCellValue(colFITCH_FIT_CODE_FK_PK, txtCode.Text)
        Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"
    End Sub

    Private Sub GV16_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV16.InitNewRow
        GV16.SetFocusedRowCellValue(colFITROF_FIT_CODE_FK_PK, txtCode.Text)
        Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"

    End Sub
#End Region

#Region " Panel resize "

    Private Sub Panel5_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel5.Resize
        GC1.Width = Panel5.Width / 2
        GC2.Width = Panel5.Width / 2
    End Sub

    Private Sub Panel6_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel6.Resize
        GC3.Width = Panel6.Width / 2
        GC4.Width = Panel6.Width / 2
    End Sub

    Private Sub Panel7_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel7.Resize
        GC5.Width = Panel7.Width / 2
        GC6.Width = Panel7.Width / 2
    End Sub

    Private Sub Panel9_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel9.Resize
        GC12.Width = Panel9.Width / 2
        GC22.Width = Panel9.Width / 2
    End Sub

    Private Sub Panel10_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel10.Resize
        GC32.Width = Panel10.Width / 2
        GC42.Width = Panel10.Width / 2
    End Sub

    Private Sub Panel11_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel11.Resize
        GC52.Width = Panel11.Width / 2
        GC62.Width = Panel11.Width / 2
    End Sub

    Private Sub Panel2_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel2.Resize
        GC14.Width = Panel2.Width / 2
        GC24.Width = Panel2.Width / 2
    End Sub

    Private Sub Panel3_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.Resize
        GC34.Width = Panel3.Width / 2
        GC44.Width = Panel3.Width / 2
    End Sub

    Private Sub Panel4_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel4.Resize
        GC54.Width = Panel4.Width / 2
        GC64.Width = Panel4.Width / 2
    End Sub

    Private Sub XtraTabControl1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraTabControl1.Resize
        Panel5.Height = XtraTabControl1.Height / 4
        Panel6.Height = XtraTabControl1.Height / 4
        Panel7.Height = XtraTabControl1.Height / 4
        Panel8.Height = XtraTabControl1.Height / 4

        Panel9.Height = XtraTabControl1.Height / 4
        Panel10.Height = XtraTabControl1.Height / 4
        Panel11.Height = XtraTabControl1.Height / 4
        Panel12.Height = XtraTabControl1.Height / 4

        GC13.Height = XtraTabControl1.Height / 2
        GC33.Height = XtraTabControl1.Height / 2

        Panel2.Height = XtraTabControl1.Height / 4
        Panel3.Height = XtraTabControl1.Height / 4
        Panel4.Height = XtraTabControl1.Height / 4
        Panel13.Height = XtraTabControl1.Height / 4

        GC25.Height = XtraTabControl1.Height / 2
        GC16.Height = XtraTabControl1.Height / 2
    End Sub

#End Region

    Private Sub Open_Fiche(ByVal CodE1 As Integer)
        OnLoading = True
        CodE = _Code
        EmptyDataTable()
        Me.FiT_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FIT_FICHEINTERAC, CodE1)
        Me.IT1CPH_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT1CPH_TERME1CLPHARMTHER, CodE1)
        Me.IT1CCH_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT1CCH_TERME1CLCHIM, CodE1)
        Me.IT1CC_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT1CC_TERM1COMCLASSE, CodE1)
        Me.IT1SAC_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT1SAC_TERME1SUBACTIVE, CodE1)
        Me.IT1SAU_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT1SAU_TERME1SUBAUX, CodE1)
        Me.IT1PR_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT1PR_TERME1PRODUIT, CodE1)
        Me.IT1SP_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT1SP_TERME1SPECIALITE, CodE1)
        'Terme2
        Me.IT2CPH_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT2CPH_TERME2CLPHARMTHER, CodE1)
        Me.IT2CCH_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT2CCH_TERME2CLCHIM, CodE1)
        Me.IT2CC_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT2CC_TERM2COMCLASSE, CodE1)
        Me.IT2SAC_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT2SAC_TERME2SUBACTIVE, CodE1)
        Me.IT2SAU_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT2SAU_TERME2SUBAUX, CodE1)
        Me.IT2PR_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT2PR_TERME2PRODUIT, CodE1)
        Me.IT2SP_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.IT2SP_TERME2SPECIALITE, CodE1)
        'Charger les tables qui font réferences à la table master
        Me.FitnA_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITNA_INTERACTION_NATURE, CodE1)
        Me.FitroF_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITROF_REF_OFFICIELLE, CodE1)
        Me.FitsE_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITSE_INTERACTION_SENS, CodE1)
        Me.FittY_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITTY_TYPEINTERACTION, CodE1)
        Me.FitvA_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITVA_NIVEAU_VALIDATION, CodE1)
        Me.FitvD1_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITVD1_INTERACTION_VOIE_DOSE, CodE1)
        Me.FitvD2_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITVD2_INTERACTION_VOIE_DOSE, CodE1)
        Me.FitteR_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITTER_TERRAINFAVORISANT, CodE1)
        Me.FitcH_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITCH_CRITERECHOIX, CodE1)
        Me.FitcT_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance.FITCT_COMMENTAIRE_TERRAIN, CodE1)
        OnLoading = False
    End Sub

#Region " Validating Editor "

    Private Sub GV54_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV54.ValidatingEditor
        If GV54.FocusedColumn Is colFITTER_NUMORD Then
            If FieldExist(GV54, colFITTER_NUMORD, e.Value) Then
                e.ErrorText = "Le numéro doit être unique."
                e.Value = Nothing
                e.Valid = False
            End If
        End If
    End Sub
    Private Sub GV14_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV14.ValidatingEditor
        If GV14.FocusedColumn Is colFITVA_NUMORD Then
            If FieldExist(GV14, colFITVA_NUMORD, e.Value) Then
                e.ErrorText = "Le numéro doit être unique."
                e.Value = Nothing
                e.Valid = False
            End If
        End If
    End Sub
    Private Sub GV24_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV24.ValidatingEditor
        If GV24.FocusedColumn Is colFITNA_NUMORD Then
            If FieldExist(GV24, colFITNA_NUMORD, e.Value) Then
                e.ErrorText = "Le numéro doit être unique."
                e.Value = Nothing
                e.Valid = False
            End If
        End If
    End Sub
    Private Sub GV34_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV34.ValidatingEditor
        If GV34.FocusedColumn Is colFITTY_NUMORD Then
            If FieldExist(GV34, colFITTY_NUMORD, e.Value) Then
                e.ErrorText = "Le numéro doit être unique."
                e.Value = Nothing
                e.Valid = False
            End If
        End If
    End Sub
    Private Sub GV44_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV44.ValidatingEditor
        If GV44.FocusedColumn Is colFITSE_NUMORD Then
            If FieldExist(GV44, colFITSE_NUMORD, e.Value) Then
                e.ErrorText = "Le numéro doit être unique."
                e.Value = Nothing
                e.Valid = False
            End If
        End If
    End Sub
    Private Sub GV64_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV64.ValidatingEditor
        If GV64.FocusedColumn Is colFITCT_NUMORD Then
            If FieldExist(GV64, colFITCT_NUMORD, e.Value) Then
                e.ErrorText = "Le numéro doit être unique."
                e.Value = Nothing
                e.Valid = False
            End If
        End If
    End Sub
    Private Sub GV3_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV3.ValidatingEditor
        If GV3.FocusedColumn Is colIT1CC_NUMORD Then
            If FieldExist(GV3, colIT1CC_NUMORD, e.Value) Then
                e.ErrorText = "Le numéro doit être unique."
                e.Value = Nothing
                e.Valid = False
            End If
        End If
    End Sub
    Private Sub GV32_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV32.ValidatingEditor
        If GV32.FocusedColumn Is colIT2CC_NUMORD Then
            If FieldExist(GV32, colIT2CC_NUMORD, e.Value) Then
                e.ErrorText = "Le numéro doit être unique."
                e.Value = Nothing
                e.Valid = False
            End If
        End If
    End Sub

#End Region
    Private Sub GV13_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV13.ValidateRow
        If e.Row IsNot Nothing Then
            If Not Me.GV13.GetFocusedRowCellValue(colFITVD1_DOSE1) Is DBNull.Value Then
                If e.Row.row.Item(2) Is DBNull.Value Then
                    e.ErrorText = "Saisie obligatoire de la voie"
                    e.Valid = False
                    Exit Sub
                Else
                    e.ErrorText = ""
                    e.Valid = True
                End If
                If e.Row.row.Item(3) Is DBNull.Value And Not e.Row.row.Item(4) Is DBNull.Value Then
                    e.ErrorText = "Saisie obligatoire de l'unité"
                    e.Valid = False
                    Exit Sub
                Else
                    e.ErrorText = ""
                    e.Valid = True
                End If
            End If
            If Not Me.GV13.GetFocusedRowCellValue(colUnite) Is DBNull.Value Then
                If e.Row.row.Item(2) Is DBNull.Value Then
                    e.ErrorText = "Saisie obligatoire de la voie"
                    e.Valid = False
                    Exit Sub
                Else
                    e.ErrorText = ""
                    e.Valid = True
                End If
                If e.Row.row.Item(4) Is DBNull.Value And Not e.Row.row.Item(3) Is DBNull.Value Then
                    e.ErrorText = "Saisie obligatoire de la dose"
                    e.Valid = False
                    Exit Sub
                Else
                    e.ErrorText = ""
                    e.Valid = True
                End If
            End If
            If Not Me.GV13.GetFocusedRowCellValue(colFITVD1_QUALIFICATIF_DOSE1) Is DBNull.Value Then
                If e.Row.row.Item(2) Is DBNull.Value Then
                    e.ErrorText = "Saisie obligatoire de la voie"
                    e.Valid = False
                    Exit Sub
                Else
                    e.ErrorText = ""
                    e.Valid = True
                End If
            End If
        End If
    End Sub
    Private Sub GV33_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV33.ValidateRow
        If e.Row IsNot Nothing Then
            If Not Me.GV13.GetFocusedRowCellValue(colFITVD2_DOSE2) Is DBNull.Value Then
                If e.Row.row.Item(2) Is DBNull.Value Then
                    e.ErrorText = "Saisie obligatoire de la voie"
                    e.Valid = False
                    Exit Sub
                Else
                    e.ErrorText = ""
                    e.Valid = True
                End If
                If e.Row.row.Item(3) Is DBNull.Value And Not e.Row.row.Item(4) Is DBNull.Value Then
                    e.ErrorText = "Saisie obligatoire de l'unité"
                    e.Valid = False
                    Exit Sub
                Else
                    e.ErrorText = ""
                    e.Valid = True
                End If
            End If
            If Not Me.GV13.GetFocusedRowCellValue(colUnite2) Is DBNull.Value Then
                If e.Row.row.Item(2) Is DBNull.Value Then
                    e.ErrorText = "Saisie obligatoire de la voie"
                    e.Valid = False
                    Exit Sub
                Else
                    e.ErrorText = ""
                    e.Valid = True
                End If
                If e.Row.row.Item(4) Is DBNull.Value And Not e.Row.row.Item(3) Is DBNull.Value Then
                    e.ErrorText = "Saisie obligatoire de la dose"
                    e.Valid = False
                    Exit Sub
                Else
                    e.ErrorText = ""
                    e.Valid = True
                End If
            End If
            If Not Me.GV13.GetFocusedRowCellValue(colFITVD2_QUALIFICATIF_DOSE2) Is DBNull.Value Then
                If e.Row.row.Item(2) Is DBNull.Value Then
                    e.ErrorText = "Saisie obligatoire de la voie"
                    e.Valid = False
                    Exit Sub
                Else
                    e.ErrorText = ""
                    e.Valid = True
                End If
            End If
        End If
    End Sub
End Class
