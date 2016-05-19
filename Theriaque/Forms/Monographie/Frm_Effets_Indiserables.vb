''' <summary>
''' Created By [BFE]
''' </summary>
''' <remarks> Monographie - Effets indésirables </remarks>
Public Class Frm_Effets_Indiserables

#Region "Déclaration des variables privées"
    Private CodE As String
    Public _Code As Integer = Nothing ' charger la fiche depuis l'extérieur
    Private Tab_lkup1 As Boolean = False
    Private Tab_TA1 As Boolean = False
    Private Tab_lkup2 As Boolean = False
    Private Tab_TA2 As Boolean = False
    Private Tab_lkup3 As Boolean = False
    Private Tab_TA3 As Boolean = False
    Private Tab_lkup4 As Boolean = False
    Private Tab_TA4 As Boolean = False
    Private Tab_lkup5 As Boolean = False
    Private Tab_TA5 As Boolean = False
    Private Tab_lkup6 As Boolean = False
    Private Tab_TA6 As Boolean = False
    Private bModeDuplication As Boolean = False
#End Region

#Region " Edit Data "

    ''' <summary>
    ''' Fonction: Recherche et retour des données de la fiche
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks>Fonction surchargée</remarks>
    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_FEI_FICHEEFFIND
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then

            XtraTabControl1.SelectedTabPageIndex = 0
            OnLoading = True
            EmptyDataTable()
            Me.FeI_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEI_FICHEEFFIND, f._Code)

            'Onglet Entités
            Me.FeicpH_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEICPH_EFFINDCLPH, f._Code)
            Me.FeiccH_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEICCH_EFFINDCLCH, f._Code)
            Me.FeisaC_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEISAC_EFFINDSUBAC, f._Code)
            Me.FeisaU_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEISAU_EFFINDSUBAU, f._Code)
            Me.FeipR_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEIPR_EFFINDPROD, f._Code)
            Me.FeisP_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEISP_EFFINDSPE, f._Code)

            GC42.DataSource = DsTheriaque_Effets_Indesirables
            GC42.DataMember = FEIAFS_EFFETIND_AFSSAPS

            GC62.DataSource = DsTheriaque_Effets_Indesirables
            GC62.DataMember = FEIAFS_EFFETIND_AFSSAPS

            Tab_TA1 = False
            Tab_TA2 = False
            Tab_TA3 = False
            Tab_TA4 = False
            Tab_TA5 = False
            Tab_TA6 = False

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
        f._SSQL = strSSQL_FEI_FICHEEFFIND_SPECIALITE()
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then

            XtraTabControl1.SelectedTabPageIndex = 0
            OnLoading = True
            EmptyDataTable()
            Me.FeI_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEI_FICHEEFFIND, f._Code)

            'Onglet Entités
            Me.FeicpH_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEICPH_EFFINDCLPH, f._Code)
            Me.FeiccH_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEICCH_EFFINDCLCH, f._Code)
            Me.FeisaC_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEISAC_EFFINDSUBAC, f._Code)
            Me.FeisaU_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEISAU_EFFINDSUBAU, f._Code)
            Me.FeipR_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEIPR_EFFINDPROD, f._Code)
            Me.FeisP_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEISP_EFFINDSPE, f._Code)

            Tab_TA1 = False
            Tab_TA2 = False
            Tab_TA3 = False
            Tab_TA4 = False
            Tab_TA5 = False
            Tab_TA6 = False

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
        Dim sCodeCC As String = ""
        Dim sCodeOC As String = ""
        Dim sCodeDTNC As String = ""
        Dim sCodeDTNP As String = ""
        Dim sCodeDTNCOM As String = ""
        Dim sCodeDTTF As String = ""
        Dim sCodeDTACIRC As String = ""
        Dim sCodeDTMS As String = ""
        Dim sCodeDTCCOM As String = ""
        Dim sCodeCSNC As String = ""
        Dim sCodeCSNP As String = ""
        Dim sCodeCSNCOM As String = ""
        Dim sCodeCSCCOM As String = ""
        
        Dim f As New Frm_EffetsIndesirablesMultiCriteres
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
            If f._bOC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("EC", " and substring(CDF_CODE_PK, 1, 1) =  'A'")
                fDICO.Text = "Organes cibles"
                fDICO.ShowDialog()
                sCodeOC = fDICO._Code
            End If
            If f._bDTNC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("EN", " and substring(CDF_CODE_PK, 1, 1) <>  'Q'")
                fDICO.Text = "A dose thérapeutique - Nature de l'effet indésirale - Nature EI clinique"
                fDICO.ShowDialog()
                sCodeDTNC = fDICO._Code
            End If
            If f._bDTNP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("EN", " and substring(CDF_CODE_PK, 1, 1) =  'Q'")
                fDICO.Text = "A dose thérapeutique - Nature de l'effet indésirale - Nature EI paraclinique"
                fDICO.ShowDialog()
                sCodeDTNP = fDICO._Code
            End If
            If f._bDTNCOM Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("EC", " and substring(CDF_CODE_PK, 1, 1) =  'B'")
                fDICO.Text = "A dose thérapeutique - Nature de l'effet indésirale - Commentaires"
                fDICO.ShowDialog()
                sCodeDTNCOM = fDICO._Code
            End If
            If f._bDTTF Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("CS")
                fDICO.Text = "A dose thérapeutique - Circonstances de survenue - Terrains favorisants"
                fDICO.ShowDialog()
                sCodeDTTF = fDICO._Code
            End If
            If f._bDTACIRC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("EC", " and substring(CDF_CODE_PK, 1, 1) =  'C'")
                fDICO.Text = "A dose thérapeutique - Circonstances de survenue - Autres circonstances favorisantes"
                fDICO.ShowDialog()
                sCodeDTACIRC = fDICO._Code
            End If
            If f._bDTMS Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("EC", " and substring(CDF_CODE_PK, 1, 1) =  'D'")
                fDICO.Text = "A dose thérapeutique - Circonstances de survenue - Moment de survenue"
                fDICO.ShowDialog()
                sCodeDTMS = fDICO._Code
            End If
            If f._bDTCCOM Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("EC", " and substring(CDF_CODE_PK, 1, 1) =  'E'")
                fDICO.Text = "A dose thérapeutique - Circonstances de survenue - Commentaires"
                fDICO.ShowDialog()
                sCodeDTCCOM = fDICO._Code
            End If
            If f._bCSNC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("EN", " and substring(CDF_CODE_PK, 1, 1) <>  'Q'")
                fDICO.Text = "En cas de surdosage - Nature de l'effet indésirable - Nature EI clinique"
                fDICO.ShowDialog()
                sCodeCSNC = fDICO._Code
            End If
            If f._bCSNP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("EN", " and substring(CDF_CODE_PK, 1, 1) =  'Q'")
                fDICO.Text = "En cas de surdosage - Nature de l'effet indésirable - Nature EI paraclinique"
                fDICO.ShowDialog()
                sCodeCSNP = fDICO._Code
            End If
            If f._bCSNCOM Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("EC", " and substring(CDF_CODE_PK, 1, 1) =  'B'")
                fDICO.Text = "En cas de surdosage - Nature de l'effet indésirable - Commentaires"
                fDICO.ShowDialog()
                sCodeCSNCOM = fDICO._Code
            End If
            If f._bCSCCOM Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("EC", " and substring(CDF_CODE_PK, 1, 1) = 'E'")
                fDICO.Text = "En cas de surdosage - conduite à tenir - Commentaires"
                fDICO.ShowDialog()
                sCodeCSCCOM = fDICO._Code
            End If


            Dim fResultat As New Frm_Recherche
            Dim sSQL As String = ""
            sSQL &= " Select FEI_CODE_SQ_PK as code, '' as libelle From THERIAQUE.FEI_FICHEEFFIND"
            If sCodeCPH <> "" Then
                sSQL &= " WHERE FEI_CODE_SQ_PK IN (SELECT FEICPH_FEI_CODE_FK_PK FROM THERIAQUE.FEICPH_EFFINDCLPH WHERE FEICPH_CPH_CODE_FK_PK = " & cn.SQLText(sCodeCPH) & ")"
            End If
            If sCodeCCH <> "" Then
                If sCodeCPH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FEI_CODE_SQ_PK IN (SELECT FEICCH_FEI_CODE_FK_PK FROM THERIAQUE.FEICCH_EFFINDCLCH WHERE FEICCH_CCH_CODE_FK_PK = " & cn.SQLText(sCodeCCH) & ")"
            End If
            If sCodeSAC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FEI_CODE_SQ_PK IN (SELECT FEISAC_FEI_CODE_FK_PK FROM THERIAQUE.FEISAC_EFFINDSUBAC WHERE FEISAC_SAC_CODE_FK_PK = " & cn.SQLText(sCodeSAC) & ")"
            End If
            If sCodeSAU <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FEI_CODE_SQ_PK IN (SELECT FEISAU_FEI_CODE_FK_PK FROM THERIAQUE.FEISAU_EFFINDSUBAU WHERE FEISAU_SAU_CODE_FK_PK = " & cn.SQLText(sCodeSAU) & ")"
            End If
            If sCodePR <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FEI_CODE_SQ_PK IN (SELECT FEIPR_FEI_CODE_FK_PK FROM THERIAQUE.FEIPR_EFFINDPROD WHERE FEIPR_PR_CODE_FK_PK = " & cn.SQLText(sCodePR) & ")"
            End If
            If sCodeSP <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FEI_CODE_SQ_PK IN (SELECT FEISP_FEI_CODE_FK_PK FROM THERIAQUE.FEISP_EFFINDSPE WHERE FEISP_SP_CODE_FK_PK = " & cn.SQLText(sCodeSP) & ")"
            End If
            If sCodeCC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FEI_CODE_SQ_PK IN (SELECT FEICH_FEI_CODE_FK_PK FROM THERIAQUE.FEICH_EFFETIND_CH WHERE FEICH_CH_CODE_FK_PK = " & cn.SQLText(sCodeCC) & ")"
            End If
            If sCodeOC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FEI_CODE_SQ_PK IN (SELECT FEIDT_FEI_CODE_FK_PK FROM THERIAQUE.FEIDT_COMMENT_DOSETH WHERE FEIDT_CDF_COEI_CODE_FK_PK = " & cn.SQLText(sCodeOC) & ")"
            End If
            If sCodeDTNC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeOC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FEI_CODE_SQ_PK IN (SELECT FEINACT_FEI_CODE_FK_PK FROM THERIAQUE.FEINACT_NATURETHER_EICLIN WHERE FEINACT_CDF_NAEI_CODE_FK_PK = " & cn.SQLText(sCodeDTNC) & ")"
            End If
            If sCodeDTNP <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeOC <> "" Or sCodeDTNC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FEI_CODE_SQ_PK IN (SELECT FEINAPT_FEI_CODE_FK_PK FROM THERIAQUE.FEINAPT_NATURTHER_EIPARACLIN WHERE FEINAPT_CDF_NAEI_CODE_FK_PK = " & cn.SQLText(sCodeDTNP) & ")"
            End If
            If sCodeDTNCOM <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeOC <> "" Or sCodeDTNC <> "" Or sCodeDTNP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FEI_CODE_SQ_PK IN (SELECT FEINA_FEI_CODE_FK_PK FROM THERIAQUE.FEINA_COMMENT_NATUREDOSETH WHERE FEINA_CDF_COEI_CODE_FK_PK = " & cn.SQLText(sCodeDTNCOM) & ")"
            End If
            If sCodeDTTF <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeOC <> "" Or sCodeDTNC <> "" Or sCodeDTNP <> "" Or sCodeDTNCOM <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FEI_CODE_SQ_PK IN (SELECT FEITER_FEI_CODE_FK_PK FROM THERIAQUE.FEITER_TERRAINFAVORISANT WHERE FEITER_CDF_TER_CODE_FK_PK = " & cn.SQLText(sCodeDTTF) & ")"
            End If
            If sCodeDTACIRC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeOC <> "" Or sCodeDTNC <> "" Or sCodeDTNP <> "" Or sCodeDTNCOM <> "" Or sCodeDTTF <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FEI_CODE_SQ_PK IN (SELECT FEICF_FEI_CODE_FK_PK FROM THERIAQUE.FEICF_COMMENT_CIRCONSTFAVORIS WHERE FEICF_CDF_COEI_CODE_FK_PK = " & cn.SQLText(sCodeDTACIRC) & ")"
            End If
            If sCodeDTMS <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeOC <> "" Or sCodeDTNC <> "" Or sCodeDTNP <> "" Or sCodeDTNCOM <> "" Or sCodeDTTF <> "" Or sCodeDTACIRC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FEI_CODE_SQ_PK IN (SELECT FEIMS_FEI_CODE_FK_PK FROM THERIAQUE.FEIMS_COMMENT_MOMENTSURV WHERE FEIMS_CDF_COEI_CODE_FK_PK = " & cn.SQLText(sCodeDTMS) & ")"
            End If
            If sCodeDTCCOM <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeOC <> "" Or sCodeDTNC <> "" Or sCodeDTNP <> "" Or sCodeDTNCOM <> "" Or sCodeDTTF <> "" Or sCodeDTACIRC <> "" Or sCodeDTMS <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FEI_CODE_SQ_PK IN (SELECT FEICT_FEI_CODE_FK_PK FROM THERIAQUE.FEICT_COMMENT_CATDOSETH WHERE FEICT_CDF_COEI_CODE_FK_PK = " & cn.SQLText(sCodeDTCCOM) & ")"
            End If
            If sCodeCSNC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeOC <> "" Or sCodeDTNC <> "" Or sCodeDTNP <> "" Or sCodeDTNCOM <> "" Or sCodeDTTF <> "" Or sCodeDTACIRC <> "" Or sCodeDTMS <> "" Or sCodeDTCCOM <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FEI_CODE_SQ_PK IN (SELECT FEINACS_FEI_CODE_FK_PK FROM THERIAQUE.FEINACS_NATURSURDOS_EICLIN WHERE FEINACS_CDF_NAEI_CODE_FK_PK = " & cn.SQLText(sCodeCSNC) & ")"
            End If
            If sCodeCSNP <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeOC <> "" Or sCodeDTNC <> "" Or sCodeDTNP <> "" Or sCodeDTNCOM <> "" Or sCodeDTTF <> "" Or sCodeDTACIRC <> "" Or sCodeDTMS <> "" Or sCodeDTCCOM <> "" Or sCodeCSNC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FEI_CODE_SQ_PK IN (SELECT FEINAPS_FEI_CODE_FK_PK FROM THERIAQUE.FEINAPS_NATURSURDOS_EIPARACLIN WHERE FEINAPS_CDF_NAEI_CODE_FK_PK = " & cn.SQLText(sCodeCSNP) & ")"
            End If
            If sCodeCSNCOM <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeOC <> "" Or sCodeDTNC <> "" Or sCodeDTNP <> "" Or sCodeDTNCOM <> "" Or sCodeDTTF <> "" Or sCodeDTACIRC <> "" Or sCodeDTMS <> "" Or sCodeDTCCOM <> "" Or sCodeCSNC <> "" Or sCodeCSNP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FEI_CODE_SQ_PK IN (SELECT FEINAS_FEI_CODE_FK_PK FROM THERIAQUE.FEINAS_COMMENT_NATURESURDOSAG WHERE FEINAS_CDF_COEI_CODE_FK_PK = " & cn.SQLText(sCodeCSNCOM) & ")"
            End If
            If sCodeCSCCOM <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeOC <> "" Or sCodeDTNC <> "" Or sCodeDTNP <> "" Or sCodeDTNCOM <> "" Or sCodeDTTF <> "" Or sCodeDTACIRC <> "" Or sCodeDTMS <> "" Or sCodeDTCCOM <> "" Or sCodeCSNC <> "" Or sCodeCSNP <> "" Or sCodeCSNCOM <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FEI_CODE_SQ_PK IN (SELECT FEICTS_FEI_CODE_FK_PK FROM THERIAQUE.FEICTS_COMMENT_CATSURDOS WHERE FEICTS_CDF_COEI_CODE_FK_PK = " & cn.SQLText(sCodeCSCCOM) & ")"
            End If
            
            sSQL &= " ORDER BY FEI_CODE_SQ_PK"

            fResultat._SSQL = sSQL
            fResultat.Text = Me.Text
            fResultat.ShowDialog()
            CodE = fResultat._Code
            If fResultat._Code IsNot Nothing Then
                XtraTabControl1.SelectedTabPageIndex = 0
                OnLoading = True
                EmptyDataTable()
                Me.FeI_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEI_FICHEEFFIND, fResultat._Code)

                'Onglet Entités
                Me.FeicpH_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEICPH_EFFINDCLPH, fResultat._Code)
                Me.FeiccH_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEICCH_EFFINDCLCH, fResultat._Code)
                Me.FeisaC_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEISAC_EFFINDSUBAC, fResultat._Code)
                Me.FeisaU_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEISAU_EFFINDSUBAU, fResultat._Code)
                Me.FeipR_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEIPR_EFFINDPROD, fResultat._Code)
                Me.FeisP_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEISP_EFFINDSPE, fResultat._Code)

                GC42.DataSource = DsTheriaque_Effets_Indesirables
                GC42.DataMember = FEIAFS_EFFETIND_AFSSAPS

                GC62.DataSource = DsTheriaque_Effets_Indesirables
                GC62.DataMember = FEIAFS_EFFETIND_AFSSAPS

                Tab_TA1 = False
                Tab_TA2 = False
                Tab_TA3 = False
                Tab_TA4 = False
                Tab_TA5 = False
                Tab_TA6 = False

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
        ComboBoxEdit1.SelectedItem = "O"
        ComboBoxEdit2.SelectedItem = "O"
        ComboBoxEdit3.SelectedText = "1"
        XTabPage_ECSUR1.PageEnabled = False
        XTabPage_ECSUR2.PageEnabled = False
        MyBase.Ajouter()
        bModeDuplication = False
        XtraTabControl1.SelectedTabPageIndex = 0
    End Sub

    ''' <summary>
    ''' Fonction: Suppression d'un enregistrement
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks>Fonction surchargée</remarks>
    Public Overrides Function supprimer() As Boolean
        MyBase.Supprimer()
        Dim iCount As Integer
        If Tab_TA1 Then
            If (ComboBoxEdit2.SelectedItem = "O") Then
                If Tab_TA3 And Tab_TA4 Then
                    'Onglet Entités
                    For iCount = 0 To DsTheriaque_Effets_Indesirables.FEICPH_EFFINDCLPH.Rows.Count - 1
                        DsTheriaque_Effets_Indesirables.FEICPH_EFFINDCLPH.Rows(iCount).Delete()
                    Next
                    Me.FeicpH_TA.Update(DsTheriaque_Effets_Indesirables)

                    For iCount = 0 To DsTheriaque_Effets_Indesirables.FEICCH_EFFINDCLCH.Rows.Count - 1
                        DsTheriaque_Effets_Indesirables.FEICCH_EFFINDCLCH.Rows(iCount).Delete()
                    Next
                    Me.FeiccH_TA.Update(DsTheriaque_Effets_Indesirables)

                    For iCount = 0 To DsTheriaque_Effets_Indesirables.FEISAC_EFFINDSUBAC.Rows.Count - 1
                        DsTheriaque_Effets_Indesirables.FEISAC_EFFINDSUBAC.Rows(iCount).Delete()
                    Next
                    Me.FeisaC_TA.Update(DsTheriaque_Effets_Indesirables)

                    For iCount = 0 To DsTheriaque_Effets_Indesirables.FEISAU_EFFINDSUBAU.Rows.Count - 1
                        DsTheriaque_Effets_Indesirables.FEISAU_EFFINDSUBAU.Rows(iCount).Delete()
                    Next
                    Me.FeisaU_TA.Update(DsTheriaque_Effets_Indesirables)

                    For iCount = 0 To DsTheriaque_Effets_Indesirables.FEIPR_EFFINDPROD.Rows.Count - 1
                        DsTheriaque_Effets_Indesirables.FEIPR_EFFINDPROD.Rows(iCount).Delete()
                    Next
                    Me.FeipR_TA.Update(DsTheriaque_Effets_Indesirables)

                    For iCount = 0 To DsTheriaque_Effets_Indesirables.FEISP_EFFINDSPE.Rows.Count - 1
                        DsTheriaque_Effets_Indesirables.FEISP_EFFINDSPE.Rows(iCount).Delete()
                    Next
                    Me.FeisP_TA.Update(DsTheriaque_Effets_Indesirables)
                    'Onglet Effet
                    For iCount = 0 To DsTheriaque_Effets_Indesirables.FEICH_EFFETIND_CH.Rows.Count - 1
                        DsTheriaque_Effets_Indesirables.FEICH_EFFETIND_CH.Rows(iCount).Delete()
                    Next
                    Me.FeicH_TA.Update(DsTheriaque_Effets_Indesirables)

                    For iCount = 0 To DsTheriaque_Effets_Indesirables.FEIDT_COMMENT_DOSETH.Rows.Count - 1
                        DsTheriaque_Effets_Indesirables.FEIDT_COMMENT_DOSETH.Rows(iCount).Delete()
                    Next
                    Me.FeidT_TA.Update(DsTheriaque_Effets_Indesirables)

                    For iCount = 0 To DsTheriaque_Effets_Indesirables.FEITX1_EI_TXDOSETHER.Rows.Count - 1
                        DsTheriaque_Effets_Indesirables.FEITX1_EI_TXDOSETHER.Rows(iCount).Delete()
                    Next
                    Me.FeitX1_TA.Update(DsTheriaque_Effets_Indesirables)
                    Supprimer_DoseThe()
                    bModeDuplication = False
                    ' Master
                    DsTheriaque_Effets_Indesirables.FEI_FICHEEFFIND.Rows(0).Delete()
                    Me.FeI_TA.Update(Me.MasterDataSet)
                Else
                    Process_Message(strChargementOnglet, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If Tab_TA5 And Tab_TA6 Then
                    'Onglet Entités
                    For iCount = 0 To DsTheriaque_Effets_Indesirables.FEICPH_EFFINDCLPH.Rows.Count - 1
                        DsTheriaque_Effets_Indesirables.FEICPH_EFFINDCLPH.Rows(iCount).Delete()
                    Next
                    Me.FeicpH_TA.Update(DsTheriaque_Effets_Indesirables)

                    For iCount = 0 To DsTheriaque_Effets_Indesirables.FEICCH_EFFINDCLCH.Rows.Count - 1
                        DsTheriaque_Effets_Indesirables.FEICCH_EFFINDCLCH.Rows(iCount).Delete()
                    Next
                    Me.FeiccH_TA.Update(DsTheriaque_Effets_Indesirables)

                    For iCount = 0 To DsTheriaque_Effets_Indesirables.FEISAC_EFFINDSUBAC.Rows.Count - 1
                        DsTheriaque_Effets_Indesirables.FEISAC_EFFINDSUBAC.Rows(iCount).Delete()
                    Next
                    Me.FeisaC_TA.Update(DsTheriaque_Effets_Indesirables)

                    For iCount = 0 To DsTheriaque_Effets_Indesirables.FEISAU_EFFINDSUBAU.Rows.Count - 1
                        DsTheriaque_Effets_Indesirables.FEISAU_EFFINDSUBAU.Rows(iCount).Delete()
                    Next
                    Me.FeisaU_TA.Update(DsTheriaque_Effets_Indesirables)

                    For iCount = 0 To DsTheriaque_Effets_Indesirables.FEIPR_EFFINDPROD.Rows.Count - 1
                        DsTheriaque_Effets_Indesirables.FEIPR_EFFINDPROD.Rows(iCount).Delete()
                    Next
                    Me.FeipR_TA.Update(DsTheriaque_Effets_Indesirables)

                    For iCount = 0 To DsTheriaque_Effets_Indesirables.FEISP_EFFINDSPE.Rows.Count - 1
                        DsTheriaque_Effets_Indesirables.FEISP_EFFINDSPE.Rows(iCount).Delete()
                    Next
                    Me.FeisP_TA.Update(DsTheriaque_Effets_Indesirables)
                    'Onglet Effet
                    For iCount = 0 To DsTheriaque_Effets_Indesirables.FEICH_EFFETIND_CH.Rows.Count - 1
                        DsTheriaque_Effets_Indesirables.FEICH_EFFETIND_CH.Rows(iCount).Delete()
                    Next
                    Me.FeicH_TA.Update(DsTheriaque_Effets_Indesirables)

                    For iCount = 0 To DsTheriaque_Effets_Indesirables.FEIDT_COMMENT_DOSETH.Rows.Count - 1
                        DsTheriaque_Effets_Indesirables.FEIDT_COMMENT_DOSETH.Rows(iCount).Delete()
                    Next
                    Me.FeidT_TA.Update(DsTheriaque_Effets_Indesirables)

                    For iCount = 0 To DsTheriaque_Effets_Indesirables.FEITX1_EI_TXDOSETHER.Rows.Count - 1
                        DsTheriaque_Effets_Indesirables.FEITX1_EI_TXDOSETHER.Rows(iCount).Delete()
                    Next
                    Me.FeitX1_TA.Update(DsTheriaque_Effets_Indesirables)
                    Supprimer_EncasSurdosage()
                    bModeDuplication = False
                    ' Master
                    DsTheriaque_Effets_Indesirables.FEI_FICHEEFFIND.Rows(0).Delete()
                    Me.FeI_TA.Update(Me.MasterDataSet)
                Else
                    Process_Message(strChargementOnglet, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            Process_Message(strChargementOnglet, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Return True
    End Function

    ''' <summary>
    ''' Fonction: Suppression d'un enregistrement de la partie dose thérapeutique
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Supprimer_DoseThe()
        Dim iCount As Integer
        If Not Tab_TA3 Then
            LoadTab_3()
        End If
        If Not Tab_TA4 Then
            LoadTab_4()
        End If
        'Onglet A dose thérapeutique1
        For iCount = 0 To DsTheriaque_Effets_Indesirables.FEINACT_NATURETHER_EICLIN.Rows.Count - 1
            DsTheriaque_Effets_Indesirables.FEINACT_NATURETHER_EICLIN.Rows(iCount).Delete()
        Next
        Me.FeinacT_TA.Update(DsTheriaque_Effets_Indesirables)

        For iCount = 0 To DsTheriaque_Effets_Indesirables.FEINAPT_NATURTHER_EIPARACLIN.Rows.Count - 1
            DsTheriaque_Effets_Indesirables.FEINAPT_NATURTHER_EIPARACLIN.Rows(iCount).Delete()
        Next
        Me.FeinapT_TA.Update(DsTheriaque_Effets_Indesirables)

        For iCount = 0 To DsTheriaque_Effets_Indesirables.FEINA_COMMENT_NATUREDOSETH.Rows.Count - 1
            DsTheriaque_Effets_Indesirables.FEINA_COMMENT_NATUREDOSETH.Rows(iCount).Delete()
        Next
        Me.FeinA_TA.Update(DsTheriaque_Effets_Indesirables)

        For iCount = 0 To DsTheriaque_Effets_Indesirables.FEITX2_EI_TXNATDOSETHER.Rows.Count - 1
            DsTheriaque_Effets_Indesirables.FEITX2_EI_TXNATDOSETHER.Rows(iCount).Delete()
        Next
        Me.FeitX2_TA.Update(DsTheriaque_Effets_Indesirables)

        'Onglet A dose thérapeutique2
        For iCount = 0 To DsTheriaque_Effets_Indesirables.FEITER_TERRAINFAVORISANT.Rows.Count - 1
            DsTheriaque_Effets_Indesirables.FEITER_TERRAINFAVORISANT.Rows(iCount).Delete()
        Next
        Me.FeiteR_TA.Update(DsTheriaque_Effets_Indesirables)

        For iCount = 0 To DsTheriaque_Effets_Indesirables.FEICF_COMMENT_CIRCONSTFAVORIS.Rows.Count - 1
            DsTheriaque_Effets_Indesirables.FEICF_COMMENT_CIRCONSTFAVORIS.Rows(iCount).Delete()
        Next
        Me.FeicF_TA.Update(DsTheriaque_Effets_Indesirables)

        For iCount = 0 To DsTheriaque_Effets_Indesirables.FEIMS_COMMENT_MOMENTSURV.Rows.Count - 1
            DsTheriaque_Effets_Indesirables.FEIMS_COMMENT_MOMENTSURV.Rows(iCount).Delete()
        Next
        Me.FeimS_TA.Update(DsTheriaque_Effets_Indesirables)

        For iCount = 0 To DsTheriaque_Effets_Indesirables.FEITX4_EI_TXFREQUENCE.Rows.Count - 1
            DsTheriaque_Effets_Indesirables.FEITX4_EI_TXFREQUENCE.Rows(iCount).Delete()
        Next
        Me.FeitX4_TA.Update(DsTheriaque_Effets_Indesirables)

        'Onglet A dose thérapeutique3
        For iCount = 0 To DsTheriaque_Effets_Indesirables.FEICT_COMMENT_CATDOSETH.Rows.Count - 1
            DsTheriaque_Effets_Indesirables.FEICT_COMMENT_CATDOSETH.Rows(iCount).Delete()
        Next
        Me.FeicT_TA.Update(DsTheriaque_Effets_Indesirables)

        'For iCount = 0 To DsTheriaque_Effets_Indesirables.FEIAFS_EFFETIND_AFSSAPS.Rows.Count - 1
        '    DsTheriaque_Effets_Indesirables.FEIAFS_EFFETIND_AFSSAPS.Rows(iCount).Delete()
        'Next
        'Me.FeiafS_TA.Update(DsTheriaque_Effets_Indesirables)
        GC42.DataSource = Nothing


        For iCount = 0 To DsTheriaque_Effets_Indesirables.FEITX7_EI_TXCONDDOSETHER.Rows.Count - 1
            DsTheriaque_Effets_Indesirables.FEITX7_EI_TXCONDDOSETHER.Rows(iCount).Delete()
        Next
        Me.FeitX7_TA.Update(DsTheriaque_Effets_Indesirables)

        For iCount = 0 To DsTheriaque_Effets_Indesirables.FEITX5_EI_TXSURVENUE.Rows.Count - 1
            DsTheriaque_Effets_Indesirables.FEITX5_EI_TXSURVENUE.Rows(iCount).Delete()
        Next
        Me.FeitX5_TA.Update(DsTheriaque_Effets_Indesirables)
    End Sub

    ''' <summary>
    ''' Fonction: Suppression d'un enregistrement de la partie dose en cas de surdosage
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Supprimer_EncasSurdosage()
        Dim iCount As Integer
        If Not Tab_TA6 Then
            LoadTab_6()
        End If
        'Onglet en cas de surdosage1
        For iCount = 0 To DsTheriaque_Effets_Indesirables.FEINACS_NATURSURDOS_EICLIN.Rows.Count - 1
            DsTheriaque_Effets_Indesirables.FEINACS_NATURSURDOS_EICLIN.Rows(iCount).Delete()
        Next
        Me.FeinacS_TA.Update(DsTheriaque_Effets_Indesirables)

        For iCount = 0 To DsTheriaque_Effets_Indesirables.FEINAPS_NATURSURDOS_EIPARACLIN.Rows.Count - 1
            DsTheriaque_Effets_Indesirables.FEINAPS_NATURSURDOS_EIPARACLIN.Rows(iCount).Delete()
        Next
        Me.FeinapS_TA.Update(DsTheriaque_Effets_Indesirables)

        For iCount = 0 To DsTheriaque_Effets_Indesirables.FEINAS_COMMENT_NATURESURDOSAG.Rows.Count - 1
            DsTheriaque_Effets_Indesirables.FEINAS_COMMENT_NATURESURDOSAG.Rows(iCount).Delete()
        Next
        Me.FeinaS_TA.Update(DsTheriaque_Effets_Indesirables)

        For iCount = 0 To DsTheriaque_Effets_Indesirables.FEITX3_EI_TXNATSURDOS.Rows.Count - 1
            DsTheriaque_Effets_Indesirables.FEITX3_EI_TXNATSURDOS.Rows(iCount).Delete()
        Next
        Me.FeitX3_TA.Update(DsTheriaque_Effets_Indesirables)

        'Onglet en cas de surdosage2
        For iCount = 0 To DsTheriaque_Effets_Indesirables.FEICTS_COMMENT_CATSURDOS.Rows.Count - 1
            DsTheriaque_Effets_Indesirables.FEICTS_COMMENT_CATSURDOS.Rows(iCount).Delete()
        Next
        Me.FeictS_TA.Update(DsTheriaque_Effets_Indesirables)

        For iCount = 0 To DsTheriaque_Effets_Indesirables.FEITX6_EI_TXCONDSURDOS.Rows.Count - 1
            DsTheriaque_Effets_Indesirables.FEITX6_EI_TXCONDSURDOS.Rows(iCount).Delete()
        Next
        Me.FeitX6_TA.Update(DsTheriaque_Effets_Indesirables)

        GC62.DataSource = Nothing

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
        Dim blnIsValid As Boolean
        blnIsValid = True
        Dim iCount1 As Integer
        Dim iCount2 As Integer
        Dim iCount3 As Integer
        Dim iCount4 As Integer
        Dim iCount5 As Integer
        Dim iCount6 As Integer
        If (ComboBoxEdit2.SelectedItem = "O") Then
            Dim iIndex As Integer
            iIndex = Me.RadioGroup1.SelectedIndex
            If iIndex = 0 Then
                iCount1 = GV1.RowCount
                iCount2 = GV2.RowCount
                If iCount1 < 2 And iCount2 < 2 Then
                    Process_Message(strClasse, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    XtraTabControl1.SelectedTabPageIndex = 0
                    blnIsValid = False
                    GV1.Focus()
                    GV2.Focus()
                    Exit Function
                End If
            End If
            'If iIndex = 1 Then
            '    iCount1 = GV3.RowCount
            '    If iCount1 < 2 Then
            '        Process_Message(strSubac, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '        XtraTabControl1.SelectedTabPageIndex = 0
            '        blnIsValid = False
            '        GV3.Focus()
            '        Exit Function
            '    End If
            'End If
            If iIndex = 2 Then
                iCount1 = GV4.RowCount
                If iCount1 < 2 Then
                    Process_Message(strExcipient, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    XtraTabControl1.SelectedTabPageIndex = 0
                    blnIsValid = False
                    GV4.Focus()
                    Exit Function
                End If
            End If
        End If
        iCount1 = GV1.RowCount
        iCount2 = GV2.RowCount
        iCount3 = GV3.RowCount
        iCount4 = GV4.RowCount
        iCount5 = GV5.RowCount
        iCount6 = GV6.RowCount
        If iCount1 < 2 And iCount2 < 2 And iCount3 < 2 And iCount4 < 2 And iCount5 < 2 And iCount6 < 2 Then
            Process_Message(strInfo_Obligatoire, MessageBoxButtons.OK, MessageBoxIcon.Information)
            XtraTabControl1.SelectedTabPageIndex = 0
            blnIsValid = False
            GV1.Focus()
            Exit Function
        Else
            If (ComboBoxEdit2.SelectedItem = "O") Then
                iCount1 = GV11.RowCount
                iCount2 = GV12.RowCount
                If iCount1 < 2 And iCount2 < 2 Then
                    Process_Message(strInfo_Obligatoire2, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    XtraTabControl1.SelectedTabPageIndex = 2
                    blnIsValid = False
                    GV11.Focus()
                    Exit Function
                End If
            End If
        End If
        If (ComboBoxEdit2.SelectedItem = "O") Then
            For iCount1 = 0 To GV42.RowCount - 1
                If Not FieldExistRO(GV6, colFEISP_SP_CODE_FK_PK, GV42.GetRowCellValue(iCount1, colFEIAFS_SP_CODE_FK_PK)) Then
                    GV42.FocusedRowHandle = iCount1
                    GV42.SetColumnError(colFEIAFS_SP_CODE_FK_PK, "La spécialité doit être présente dans la fiche.")
                    XtraTabControl1.SelectedTabPageIndex = 4
                    Exit Function
                Else
                    GV42.SetColumnError(colFEIAFS_SP_CODE_FK_PK, "")
                End If
            Next
        Else
            For iCount1 = 0 To GV62.RowCount - 1
                If Not FieldExistRO(GV6, colFEISP_SP_CODE_FK_PK, GV62.GetRowCellValue(iCount1, colFEIAFS_SP_CODE_FK_PK1)) Then
                    GV62.FocusedRowHandle = iCount1
                    GV62.SetColumnError(colFEIAFS_SP_CODE_FK_PK1, "La spécialité doit être présente dans la fiche.")
                    XtraTabControl1.SelectedTabPageIndex = 6
                    Exit Function
                Else
                    GV62.SetColumnError(colFEIAFS_SP_CODE_FK_PK, "")
                End If
            Next
        End If
        If (ComboBoxEdit2.SelectedItem = "O") Then
            If Not Process_Message("Vous êtes sur le point de valider la partie 'A dose thérapeutique' et perdre toutes les données de la partie 'En cas de surdosage'.Voulez-vous continuez ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question).BtResult = MsgBoxResult.Yes Then
                Exit Function
            End If
        Else
            If Not Process_Message("Vous êtes sur le point de valider la partie 'En cas de surdosage' et perdre toutes les données de la partie 'A dose thérapeutique'.Voulez-vous continuez ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question).BtResult = MsgBoxResult.Yes Then
                Exit Function
            End If
        End If

        Return True
    End Function

    ''' <summary>
    ''' Proçédure: Validation d'un enregistrement
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub valider()
        MyBase.Valider()

        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        FeI_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEI_FICHEEFFIND)
        'Onglet Entités
        Me.BindingContext(Me.MasterDataSet, FEICPH_EFFINDCLPH).EndCurrentEdit()
        FeicpH_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEICPH_EFFINDCLPH)

        Me.BindingContext(Me.MasterDataSet, FEICCH_EFFINDCLCH).EndCurrentEdit()
        FeiccH_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEICCH_EFFINDCLCH)

        Me.BindingContext(Me.MasterDataSet, FEISAC_EFFINDSUBAC).EndCurrentEdit()
        FeisaC_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEISAC_EFFINDSUBAC)

        Me.BindingContext(Me.MasterDataSet, FEISAU_EFFINDSUBAU).EndCurrentEdit()
        FeisaU_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEISAU_EFFINDSUBAU)

        Me.BindingContext(Me.MasterDataSet, FEIPR_EFFINDPROD).EndCurrentEdit()
        FeipR_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEIPR_EFFINDPROD)

        Me.BindingContext(Me.MasterDataSet, FEISP_EFFINDSPE).EndCurrentEdit()
        FeisP_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEISP_EFFINDSPE)

        'Onglet Effet
        Me.BindingContext(Me.MasterDataSet, FEICH_EFFETIND_CH).EndCurrentEdit()
        FeicH_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEICH_EFFETIND_CH)

        Me.BindingContext(Me.MasterDataSet, FEIDT_COMMENT_DOSETH).EndCurrentEdit()
        FeidT_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEIDT_COMMENT_DOSETH)

        Me.BindingContext(Me.MasterDataSet, FEITX1_EI_TXDOSETHER).EndCurrentEdit()
        FeitX1_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEITX1_EI_TXDOSETHER)

        If (ComboBoxEdit2.SelectedItem = "O") Then

            'Onglet A dose thérapeutique1
            Me.BindingContext(Me.MasterDataSet, FEINACT_NATURETHER_EICLIN).EndCurrentEdit()
            FeinacT_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEINACT_NATURETHER_EICLIN)

            Me.BindingContext(Me.MasterDataSet, FEINAPT_NATURTHER_EIPARACLIN).EndCurrentEdit()
            FeinapT_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEINAPT_NATURTHER_EIPARACLIN)

            Me.BindingContext(Me.MasterDataSet, FEINA_COMMENT_NATUREDOSETH).EndCurrentEdit()
            FeinA_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEINA_COMMENT_NATUREDOSETH)

            Me.BindingContext(Me.MasterDataSet, FEITX2_EI_TXNATDOSETHER).EndCurrentEdit()
            FeitX2_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEITX2_EI_TXNATDOSETHER)

            'Onglet A dose thérapeutique2
            Me.BindingContext(Me.MasterDataSet, FEITER_TERRAINFAVORISANT).EndCurrentEdit()
            FeiteR_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEITER_TERRAINFAVORISANT)

            Me.BindingContext(Me.MasterDataSet, FEICF_COMMENT_CIRCONSTFAVORIS).EndCurrentEdit()
            FeicF_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEICF_COMMENT_CIRCONSTFAVORIS)

            Me.BindingContext(Me.MasterDataSet, FEIMS_COMMENT_MOMENTSURV).EndCurrentEdit()
            FeimS_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEIMS_COMMENT_MOMENTSURV)

            Me.BindingContext(Me.MasterDataSet, FEITX4_EI_TXFREQUENCE).EndCurrentEdit()
            FeitX4_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEITX4_EI_TXFREQUENCE)

            'Onglet A dose thérapeutique3
            Me.BindingContext(Me.MasterDataSet, FEICT_COMMENT_CATDOSETH).EndCurrentEdit()
            FeicT_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEICT_COMMENT_CATDOSETH)

            Me.BindingContext(Me.MasterDataSet, FEIAFS_EFFETIND_AFSSAPS).EndCurrentEdit()
            FeiafS_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEIAFS_EFFETIND_AFSSAPS)

            Me.BindingContext(Me.MasterDataSet, FEITX7_EI_TXCONDDOSETHER).EndCurrentEdit()
            FeitX7_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEITX7_EI_TXCONDDOSETHER)

            Me.BindingContext(Me.MasterDataSet, FEITX5_EI_TXSURVENUE).EndCurrentEdit()
            FeitX5_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEITX5_EI_TXSURVENUE)

            Supprimer_EncasSurdosage()
        Else
            'Onglet en cas de surdosage1
            Me.BindingContext(Me.MasterDataSet, FEINACS_NATURSURDOS_EICLIN).EndCurrentEdit()
            FeinacS_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEINACS_NATURSURDOS_EICLIN)

            Me.BindingContext(Me.MasterDataSet, FEINAPS_NATURSURDOS_EIPARACLIN).EndCurrentEdit()
            FeinapS_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEINAPS_NATURSURDOS_EIPARACLIN)

            Me.BindingContext(Me.MasterDataSet, FEINAS_COMMENT_NATURESURDOSAG).EndCurrentEdit()
            FeinaS_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEINAS_COMMENT_NATURESURDOSAG)

            Me.BindingContext(Me.MasterDataSet, FEITX3_EI_TXNATSURDOS).EndCurrentEdit()
            FeitX3_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEITX3_EI_TXNATSURDOS)

            'Onglet en cas de surdosage2
            Me.BindingContext(Me.MasterDataSet, FEICTS_COMMENT_CATSURDOS).EndCurrentEdit()
            FeictS_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEICTS_COMMENT_CATSURDOS)

            Me.BindingContext(Me.MasterDataSet, FEITX6_EI_TXCONDSURDOS).EndCurrentEdit()
            FeitX6_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEITX6_EI_TXCONDSURDOS)

            Me.BindingContext(Me.MasterDataSet, FEIAFS_EFFETIND_AFSSAPS).EndCurrentEdit()
            FeiafS_TA.Update(Me.DsTheriaque_Effets_Indesirables.FEIAFS_EFFETIND_AFSSAPS)

            Supprimer_DoseThe()
        End If
        bModeDuplication = False
        'Tab_TA1 = True
        'Tab_TA2 = True
        'Tab_TA3 = True
        'Tab_TA4 = True
        'Tab_TA5 = True
        'Tab_TA6 = True
    End Sub

    ''' <summary>
    ''' Proçédure: Annulation d'un enregistrement
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub annuler()

        XTabPage_ECSUR1.PageEnabled = True
        XTabPage_ECSUR2.PageEnabled = True
        XTabPage_ADTh1.PageEnabled = True
        XTabPage_ADTh2.PageEnabled = True
        XTabPage_ADTh3.PageEnabled = True
        OnLoading = True
        MyBase.Annuler()
        'Onglet Entités
        Me.BindingContext(DsTheriaque_Effets_Indesirables, FEICPH_EFFINDCLPH).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEICPH_EFFINDCLPH.RejectChanges()

        Me.BindingContext(DsTheriaque_Effets_Indesirables, FEICCH_EFFINDCLCH).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEICCH_EFFINDCLCH.RejectChanges()

        Me.BindingContext(DsTheriaque_Effets_Indesirables, FEISAC_EFFINDSUBAC).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEISAC_EFFINDSUBAC.RejectChanges()

        Me.BindingContext(DsTheriaque_Effets_Indesirables, FEISAU_EFFINDSUBAU).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEISAU_EFFINDSUBAU.RejectChanges()

        Me.BindingContext(DsTheriaque_Effets_Indesirables, FEIPR_EFFINDPROD).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEIPR_EFFINDPROD.RejectChanges()

        Me.BindingContext(DsTheriaque_Effets_Indesirables, FEISP_EFFINDSPE).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEISP_EFFINDSPE.RejectChanges()

        'Onglet Effet
        Me.BindingContext(DsTheriaque_Effets_Indesirables, FEICH_EFFETIND_CH).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEICH_EFFETIND_CH.RejectChanges()

        Me.BindingContext(DsTheriaque_Effets_Indesirables, FEIDT_COMMENT_DOSETH).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEIDT_COMMENT_DOSETH.RejectChanges()

        Me.BindingContext(DsTheriaque_Effets_Indesirables, FEITX1_EI_TXDOSETHER).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEITX1_EI_TXDOSETHER.RejectChanges()

        'Onglet A dose thérapeutique1
        Me.BindingContext(DsTheriaque_Effets_Indesirables, FEINACT_NATURETHER_EICLIN).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEINACT_NATURETHER_EICLIN.RejectChanges()

        Me.BindingContext(DsTheriaque_Effets_Indesirables, FEINAPT_NATURTHER_EIPARACLIN).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEINAPT_NATURTHER_EIPARACLIN.RejectChanges()

        Me.BindingContext(DsTheriaque_Effets_Indesirables, FEINA_COMMENT_NATUREDOSETH).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEINA_COMMENT_NATUREDOSETH.RejectChanges()

        Me.BindingContext(DsTheriaque_Effets_Indesirables, FEITX2_EI_TXNATDOSETHER).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEITX2_EI_TXNATDOSETHER.RejectChanges()

        'Onglet A dose thérapeutique2
        Me.BindingContext(DsTheriaque_Effets_Indesirables, FEITER_TERRAINFAVORISANT).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEITER_TERRAINFAVORISANT.RejectChanges()

        Me.BindingContext(DsTheriaque_Effets_Indesirables, FEICF_COMMENT_CIRCONSTFAVORIS).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEICF_COMMENT_CIRCONSTFAVORIS.RejectChanges()

        Me.BindingContext(DsTheriaque_Effets_Indesirables, FEIMS_COMMENT_MOMENTSURV).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEIMS_COMMENT_MOMENTSURV.RejectChanges()

        Me.BindingContext(DsTheriaque_Effets_Indesirables, FEITX4_EI_TXFREQUENCE).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEITX4_EI_TXFREQUENCE.RejectChanges()

        'Onglet A dose thérapeutique3
        Me.BindingContext(DsTheriaque_Effets_Indesirables, FEICT_COMMENT_CATDOSETH).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEICT_COMMENT_CATDOSETH.RejectChanges()

        Me.BindingContext(DsTheriaque_Effets_Indesirables, FEIAFS_EFFETIND_AFSSAPS).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEIAFS_EFFETIND_AFSSAPS.RejectChanges()

        Me.BindingContext(DsTheriaque_Effets_Indesirables, FEITX7_EI_TXCONDDOSETHER).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEITX7_EI_TXCONDDOSETHER.RejectChanges()

        Me.BindingContext(DsTheriaque_Effets_Indesirables, FEITX5_EI_TXSURVENUE).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEITX5_EI_TXSURVENUE.RejectChanges()

        'Onglet en cas de surdosage1
        Me.BindingContext(DsTheriaque_Effets_Indesirables, FEINACS_NATURSURDOS_EICLIN).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEINACS_NATURSURDOS_EICLIN.RejectChanges()

        Me.BindingContext(DsTheriaque_Effets_Indesirables, FEINAPS_NATURSURDOS_EIPARACLIN).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEINAPS_NATURSURDOS_EIPARACLIN.RejectChanges()

        Me.BindingContext(DsTheriaque_Effets_Indesirables, FEINAS_COMMENT_NATURESURDOSAG).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEINAS_COMMENT_NATURESURDOSAG.RejectChanges()

        Me.BindingContext(DsTheriaque_Effets_Indesirables, FEITX3_EI_TXNATSURDOS).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEITX3_EI_TXNATSURDOS.RejectChanges()

        'Onglet en cas de surdosage2
        Me.BindingContext(DsTheriaque_Effets_Indesirables, FEICTS_COMMENT_CATSURDOS).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEICTS_COMMENT_CATSURDOS.RejectChanges()

        Me.BindingContext(DsTheriaque_Effets_Indesirables, FEITX6_EI_TXCONDSURDOS).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEITX6_EI_TXCONDSURDOS.RejectChanges()

        'Master
        Me.BindingContext(Me.MasterDataSet, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_Effets_Indesirables.FEI_FICHEEFFIND.RejectChanges()

        If bModeDuplication Then EmptyDataTable()
        bModeDuplication = False
        OnLoading = False
    End Sub

    ''' <summary>
    ''' Proçédure: Vider tous les dataset
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Private Sub EmptyDataTable()
        'Master
        Me.DsTheriaque_Effets_Indesirables.FEI_FICHEEFFIND.Clear()
        'Onglet Entités
        Me.DsTheriaque_Effets_Indesirables.FEICPH_EFFINDCLPH.Clear()
        Me.DsTheriaque_Effets_Indesirables.FEICCH_EFFINDCLCH.Clear()
        Me.DsTheriaque_Effets_Indesirables.FEISAC_EFFINDSUBAC.Clear()
        Me.DsTheriaque_Effets_Indesirables.FEISAU_EFFINDSUBAU.Clear()
        Me.DsTheriaque_Effets_Indesirables.FEIPR_EFFINDPROD.Clear()
        Me.DsTheriaque_Effets_Indesirables.FEISP_EFFINDSPE.Clear()

        'Onglet Effet
        Me.DsTheriaque_Effets_Indesirables.FEICH_EFFETIND_CH.Clear()
        Me.DsTheriaque_Effets_Indesirables.FEIDT_COMMENT_DOSETH.Clear()
        Me.DsTheriaque_Effets_Indesirables.FEITX1_EI_TXDOSETHER.Clear()

        'Onglet A dose thérapeutique1
        Me.DsTheriaque_Effets_Indesirables.FEINACT_NATURETHER_EICLIN.Clear()
        Me.DsTheriaque_Effets_Indesirables.FEINAPT_NATURTHER_EIPARACLIN.Clear()
        Me.DsTheriaque_Effets_Indesirables.FEINA_COMMENT_NATUREDOSETH.Clear()
        Me.DsTheriaque_Effets_Indesirables.FEITX2_EI_TXNATDOSETHER.Clear()

        'Onglet A dose thérapeutique2
        Me.DsTheriaque_Effets_Indesirables.FEITER_TERRAINFAVORISANT.Clear()
        Me.DsTheriaque_Effets_Indesirables.FEICF_COMMENT_CIRCONSTFAVORIS.Clear()
        Me.DsTheriaque_Effets_Indesirables.FEIMS_COMMENT_MOMENTSURV.Clear()
        Me.DsTheriaque_Effets_Indesirables.FEITX4_EI_TXFREQUENCE.Clear()

        'Onglet A dose thérapeutique3
        Me.DsTheriaque_Effets_Indesirables.FEICT_COMMENT_CATDOSETH.Clear()
        Me.DsTheriaque_Effets_Indesirables.FEIAFS_EFFETIND_AFSSAPS.Clear()
        Me.DsTheriaque_Effets_Indesirables.FEITX7_EI_TXCONDDOSETHER.Clear()
        Me.DsTheriaque_Effets_Indesirables.FEITX5_EI_TXSURVENUE.Clear()

        'Onglet en cas de surdosage1
        Me.DsTheriaque_Effets_Indesirables.FEINACS_NATURSURDOS_EICLIN.Clear()
        Me.DsTheriaque_Effets_Indesirables.FEINAPS_NATURSURDOS_EIPARACLIN.Clear()
        Me.DsTheriaque_Effets_Indesirables.FEINAS_COMMENT_NATURESURDOSAG.Clear()
        Me.DsTheriaque_Effets_Indesirables.FEITX3_EI_TXNATSURDOS.Clear()

        'Onglet en cas de surdosage2
        Me.DsTheriaque_Effets_Indesirables.FEICTS_COMMENT_CATSURDOS.Clear()
        Me.DsTheriaque_Effets_Indesirables.FEITX6_EI_TXCONDSURDOS.Clear()
    End Sub

    ''' <summary>
    ''' Proçédure: Duplication des données à partir d'une autre fiche
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub Dupliquer()

        If Not Tab_TA1 And CodE <> InvalideControl And CodE <> Nothing Then LoadTab_1()
        If Not Tab_TA2 And CodE <> InvalideControl And CodE <> Nothing Then LoadTab_2()
        If Not Tab_TA3 And CodE <> InvalideControl And CodE <> Nothing Then LoadTab_3()
        If Not Tab_TA4 And CodE <> InvalideControl And CodE <> Nothing Then LoadTab_4()
        If Not Tab_TA5 And CodE <> InvalideControl And CodE <> Nothing Then LoadTab_5()
        If Not Tab_TA6 And CodE <> InvalideControl And CodE <> Nothing Then LoadTab_6()

        'Sauvegarde des données à duplquer

        'Onglet entités
        Dim dt1 As New DataTable
        dt1 = DsTheriaque_Effets_Indesirables.FEICPH_EFFINDCLPH.Copy

        Dim dt2 As New DataTable
        dt2 = DsTheriaque_Effets_Indesirables.FEICCH_EFFINDCLCH.Copy

        Dim dt3 As New DataTable
        dt3 = DsTheriaque_Effets_Indesirables.FEISAC_EFFINDSUBAC.Copy

        Dim dt4 As New DataTable
        dt4 = DsTheriaque_Effets_Indesirables.FEISAU_EFFINDSUBAU.Copy

        Dim dt5 As New DataTable
        dt5 = DsTheriaque_Effets_Indesirables.FEIPR_EFFINDPROD.Copy

        Dim dt6 As New DataTable
        dt6 = DsTheriaque_Effets_Indesirables.FEISP_EFFINDSPE.Copy

        Dim sContinuer As String = Me.BindingContext(DsTheriaque_Effets_Indesirables, FEI_FICHEEFFIND).Current("FEI_EFFETIND").ToString
        Dim sAccesDTH As String = Me.BindingContext(DsTheriaque_Effets_Indesirables, FEI_FICHEEFFIND).Current("FEI_DOSETH").ToString


        'Onglet2
        Dim dt22 As New DataTable
        dt22 = DsTheriaque_Effets_Indesirables.FEIDT_COMMENT_DOSETH.Copy

        Dim dt23 As New DataTable
        dt23 = DsTheriaque_Effets_Indesirables.FEITX1_EI_TXDOSETHER.Copy

        'Onglet3
        Dim dt11 As New DataTable
        dt11 = DsTheriaque_Effets_Indesirables.FEINACT_NATURETHER_EICLIN.Copy

        Dim dt12 As New DataTable
        dt12 = DsTheriaque_Effets_Indesirables.FEINAPT_NATURTHER_EIPARACLIN.Copy

        Dim dt13 As New DataTable
        dt13 = DsTheriaque_Effets_Indesirables.FEINA_COMMENT_NATUREDOSETH.Copy

        Dim dt14 As New DataTable
        dt14 = DsTheriaque_Effets_Indesirables.FEITX2_EI_TXNATDOSETHER.Copy

        'Onglet 4
        Dim dt31 As New DataTable
        dt31 = DsTheriaque_Effets_Indesirables.FEITER_TERRAINFAVORISANT.Copy

        Dim dt32 As New DataTable
        dt32 = DsTheriaque_Effets_Indesirables.FEICF_COMMENT_CIRCONSTFAVORIS.Copy

        Dim dt33 As New DataTable
        dt33 = DsTheriaque_Effets_Indesirables.FEIMS_COMMENT_MOMENTSURV.Copy

        Dim dt34 As New DataTable
        dt34 = DsTheriaque_Effets_Indesirables.FEITX4_EI_TXFREQUENCE.Copy

        'Onglet5
        Dim dt41 As New DataTable
        dt41 = DsTheriaque_Effets_Indesirables.FEICT_COMMENT_CATDOSETH.Copy

        Dim dt42 As New DataTable
        dt42 = DsTheriaque_Effets_Indesirables.FEIAFS_EFFETIND_AFSSAPS.Copy

        Dim dt43 As New DataTable
        dt43 = DsTheriaque_Effets_Indesirables.FEITX7_EI_TXCONDDOSETHER.Copy

        Dim dt44 As New DataTable
        dt44 = DsTheriaque_Effets_Indesirables.FEITX5_EI_TXSURVENUE.Copy

        'Onglet6
        Dim dt51 As New DataTable
        dt51 = DsTheriaque_Effets_Indesirables.FEINACS_NATURSURDOS_EICLIN.Copy

        Dim dt52 As New DataTable
        dt52 = DsTheriaque_Effets_Indesirables.FEINAPS_NATURSURDOS_EIPARACLIN.Copy

        Dim dt53 As New DataTable
        dt53 = DsTheriaque_Effets_Indesirables.FEINAS_COMMENT_NATURESURDOSAG.Copy

        Dim dt54 As New DataTable
        dt54 = DsTheriaque_Effets_Indesirables.FEITX3_EI_TXNATSURDOS.Copy

        'Onglet7
        Dim dt61 As New DataTable
        dt61 = DsTheriaque_Effets_Indesirables.FEICTS_COMMENT_CATSURDOS.Copy

        Dim dt62 As New DataTable
        dt62 = DsTheriaque_Effets_Indesirables.FEIAFS_EFFETIND_AFSSAPS.Copy

        Dim dt63 As New DataTable
        dt63 = DsTheriaque_Effets_Indesirables.FEITX6_EI_TXCONDSURDOS.Copy

        Dim sMode As String = ComboBoxEdit2.SelectedItem
        'Vider les contrôles
        EmptyDataTable()

        'Construction de la nouvelle fiche avec les données de la fiche de base
        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        SetCode_MAx(MasterTable, txtCode)
        CodE = InvalideControl


        Dim drTemp As DataRow
        For iCount As Integer = 0 To dt1.Rows.Count - 1
            drTemp = DsTheriaque_Effets_Indesirables.Tables("FEICPH_EFFINDCLPH").NewRow()
            drTemp.ItemArray = dt1.Rows(iCount).ItemArray
            DsTheriaque_Effets_Indesirables.Tables("FEICPH_EFFINDCLPH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt2.Rows.Count - 1
            drTemp = DsTheriaque_Effets_Indesirables.Tables("FEICCH_EFFINDCLCH").NewRow()
            drTemp.ItemArray = dt2.Rows(iCount).ItemArray
            DsTheriaque_Effets_Indesirables.Tables("FEICCH_EFFINDCLCH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt3.Rows.Count - 1
            drTemp = DsTheriaque_Effets_Indesirables.Tables("FEISAC_EFFINDSUBAC").NewRow()
            drTemp.ItemArray = dt3.Rows(iCount).ItemArray
            DsTheriaque_Effets_Indesirables.Tables("FEISAC_EFFINDSUBAC").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt4.Rows.Count - 1
            drTemp = DsTheriaque_Effets_Indesirables.Tables("FEISAU_EFFINDSUBAU").NewRow()
            drTemp.ItemArray = dt4.Rows(iCount).ItemArray
            DsTheriaque_Effets_Indesirables.Tables("FEISAU_EFFINDSUBAU").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt5.Rows.Count - 1
            drTemp = DsTheriaque_Effets_Indesirables.Tables("FEIPR_EFFINDPROD").NewRow()
            drTemp.ItemArray = dt5.Rows(iCount).ItemArray
            DsTheriaque_Effets_Indesirables.Tables("FEIPR_EFFINDPROD").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt6.Rows.Count - 1
            drTemp = DsTheriaque_Effets_Indesirables.Tables("FEISP_EFFINDSPE").NewRow()
            drTemp.ItemArray = dt6.Rows(iCount).ItemArray
            DsTheriaque_Effets_Indesirables.Tables("FEISP_EFFINDSPE").Rows.Add(drTemp)
        Next

        If sContinuer <> "" Then Me.BindingContext(DsTheriaque_Effets_Indesirables, FEI_FICHEEFFIND).Current("FEI_EFFETIND") = sContinuer
        If sAccesDTH <> "" Then Me.BindingContext(DsTheriaque_Effets_Indesirables, FEI_FICHEEFFIND).Current("FEI_DOSETH") = sAccesDTH

        For iCount As Integer = 0 To dt22.Rows.Count - 1
            drTemp = DsTheriaque_Effets_Indesirables.Tables("FEIDT_COMMENT_DOSETH").NewRow()
            drTemp.ItemArray = dt22.Rows(iCount).ItemArray
            DsTheriaque_Effets_Indesirables.Tables("FEIDT_COMMENT_DOSETH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt23.Rows.Count - 1
            drTemp = DsTheriaque_Effets_Indesirables.Tables("FEITX1_EI_TXDOSETHER").NewRow()
            drTemp.ItemArray = dt23.Rows(iCount).ItemArray
            DsTheriaque_Effets_Indesirables.Tables("FEITX1_EI_TXDOSETHER").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt11.Rows.Count - 1
            drTemp = DsTheriaque_Effets_Indesirables.Tables("FEINACT_NATURETHER_EICLIN").NewRow()
            drTemp.ItemArray = dt11.Rows(iCount).ItemArray
            DsTheriaque_Effets_Indesirables.Tables("FEINACT_NATURETHER_EICLIN").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt12.Rows.Count - 1
            drTemp = DsTheriaque_Effets_Indesirables.Tables("FEINAPT_NATURTHER_EIPARACLIN").NewRow()
            drTemp.ItemArray = dt12.Rows(iCount).ItemArray
            DsTheriaque_Effets_Indesirables.Tables("FEINAPT_NATURTHER_EIPARACLIN").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt13.Rows.Count - 1
            drTemp = DsTheriaque_Effets_Indesirables.Tables("FEINA_COMMENT_NATUREDOSETH").NewRow()
            drTemp.ItemArray = dt13.Rows(iCount).ItemArray
            DsTheriaque_Effets_Indesirables.Tables("FEINA_COMMENT_NATUREDOSETH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt14.Rows.Count - 1
            drTemp = DsTheriaque_Effets_Indesirables.Tables("FEITX2_EI_TXNATDOSETHER").NewRow()
            drTemp.ItemArray = dt14.Rows(iCount).ItemArray
            DsTheriaque_Effets_Indesirables.Tables("FEITX2_EI_TXNATDOSETHER").Rows.Add(drTemp)
        Next


        For iCount As Integer = 0 To dt31.Rows.Count - 1
            drTemp = DsTheriaque_Effets_Indesirables.Tables("FEITER_TERRAINFAVORISANT").NewRow()
            drTemp.ItemArray = dt31.Rows(iCount).ItemArray
            DsTheriaque_Effets_Indesirables.Tables("FEITER_TERRAINFAVORISANT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt32.Rows.Count - 1
            drTemp = DsTheriaque_Effets_Indesirables.Tables("FEICF_COMMENT_CIRCONSTFAVORIS").NewRow()
            drTemp.ItemArray = dt32.Rows(iCount).ItemArray
            DsTheriaque_Effets_Indesirables.Tables("FEICF_COMMENT_CIRCONSTFAVORIS").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt33.Rows.Count - 1
            drTemp = DsTheriaque_Effets_Indesirables.Tables("FEIMS_COMMENT_MOMENTSURV").NewRow()
            drTemp.ItemArray = dt33.Rows(iCount).ItemArray
            DsTheriaque_Effets_Indesirables.Tables("FEIMS_COMMENT_MOMENTSURV").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt34.Rows.Count - 1
            drTemp = DsTheriaque_Effets_Indesirables.Tables("FEITX4_EI_TXFREQUENCE").NewRow()
            drTemp.ItemArray = dt34.Rows(iCount).ItemArray
            DsTheriaque_Effets_Indesirables.Tables("FEITX4_EI_TXFREQUENCE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt41.Rows.Count - 1
            drTemp = DsTheriaque_Effets_Indesirables.Tables("FEICT_COMMENT_CATDOSETH").NewRow()
            drTemp.ItemArray = dt41.Rows(iCount).ItemArray
            DsTheriaque_Effets_Indesirables.Tables("FEICT_COMMENT_CATDOSETH").Rows.Add(drTemp)
        Next

        If sMode = "O" Then
            For iCount As Integer = 0 To dt42.Rows.Count - 1
                drTemp = DsTheriaque_Effets_Indesirables.Tables("FEIAFS_EFFETIND_AFSSAPS").NewRow()
                dt42.Rows(iCount).Item("FEIAFS_FEI_CODE_FK_PK") = txtCode.Text

                drTemp.ItemArray = dt42.Rows(iCount).ItemArray
                DsTheriaque_Effets_Indesirables.Tables("FEIAFS_EFFETIND_AFSSAPS").Rows.Add(drTemp)
            Next
        Else
            For iCount As Integer = 0 To dt62.Rows.Count - 1
                drTemp = DsTheriaque_Effets_Indesirables.Tables("FEIAFS_EFFETIND_AFSSAPS").NewRow()
                drTemp.ItemArray = dt62.Rows(iCount).ItemArray
                DsTheriaque_Effets_Indesirables.Tables("FEIAFS_EFFETIND_AFSSAPS").Rows.Add(drTemp)
            Next
        End If
        

        For iCount As Integer = 0 To dt43.Rows.Count - 1
            drTemp = DsTheriaque_Effets_Indesirables.Tables("FEITX7_EI_TXCONDDOSETHER").NewRow()
            drTemp.ItemArray = dt43.Rows(iCount).ItemArray
            DsTheriaque_Effets_Indesirables.Tables("FEITX7_EI_TXCONDDOSETHER").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt44.Rows.Count - 1
            drTemp = DsTheriaque_Effets_Indesirables.Tables("FEITX5_EI_TXSURVENUE").NewRow()
            drTemp.ItemArray = dt44.Rows(iCount).ItemArray
            DsTheriaque_Effets_Indesirables.Tables("FEITX5_EI_TXSURVENUE").Rows.Add(drTemp)
        Next
        
        For iCount As Integer = 0 To dt51.Rows.Count - 1
            drTemp = DsTheriaque_Effets_Indesirables.Tables("FEINACS_NATURSURDOS_EICLIN").NewRow()
            drTemp.ItemArray = dt51.Rows(iCount).ItemArray
            DsTheriaque_Effets_Indesirables.Tables("FEINACS_NATURSURDOS_EICLIN").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt52.Rows.Count - 1
            drTemp = DsTheriaque_Effets_Indesirables.Tables("FEINAPS_NATURSURDOS_EIPARACLIN").NewRow()
            drTemp.ItemArray = dt52.Rows(iCount).ItemArray
            DsTheriaque_Effets_Indesirables.Tables("FEINAPS_NATURSURDOS_EIPARACLIN").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt53.Rows.Count - 1
            drTemp = DsTheriaque_Effets_Indesirables.Tables("FEINAS_COMMENT_NATURESURDOSAG").NewRow()
            drTemp.ItemArray = dt53.Rows(iCount).ItemArray
            DsTheriaque_Effets_Indesirables.Tables("FEINAS_COMMENT_NATURESURDOSAG").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt54.Rows.Count - 1
            drTemp = DsTheriaque_Effets_Indesirables.Tables("FEITX3_EI_TXNATSURDOS").NewRow()
            drTemp.ItemArray = dt54.Rows(iCount).ItemArray
            DsTheriaque_Effets_Indesirables.Tables("FEITX3_EI_TXNATSURDOS").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt61.Rows.Count - 1
            drTemp = DsTheriaque_Effets_Indesirables.Tables("FEICTS_COMMENT_CATSURDOS").NewRow()
            drTemp.ItemArray = dt61.Rows(iCount).ItemArray
            DsTheriaque_Effets_Indesirables.Tables("FEICTS_COMMENT_CATSURDOS").Rows.Add(drTemp)
        Next


        For iCount As Integer = 0 To dt63.Rows.Count - 1
            drTemp = DsTheriaque_Effets_Indesirables.Tables("FEITX6_EI_TXCONDSURDOS").NewRow()
            drTemp.ItemArray = dt63.Rows(iCount).ItemArray
            DsTheriaque_Effets_Indesirables.Tables("FEITX6_EI_TXCONDSURDOS").Rows.Add(drTemp)
        Next

        ModifierCode()
        bModeDuplication = True
        MyBase.Dupliquer()
        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        XtraTabControl1.SelectedTabPageIndex = 0
    End Sub

    ''' <summary>
    ''' Proçédure: Modifier code Master de la fiche
    ''' </summary>
    Private Sub ModifierCode()
        'GV1
        For iCount As Integer = 0 To GV1.RowCount - 1
            GV1.SetRowCellValue(iCount, colFEICPH_FEI_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV2
        For iCount As Integer = 0 To GV2.RowCount - 1
            GV2.SetRowCellValue(iCount, colFEICCH_FEI_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV3
        For iCount As Integer = 0 To GV3.RowCount - 1
            GV3.SetRowCellValue(iCount, colFEISAC_FEI_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV4
        For iCount As Integer = 0 To GV4.RowCount - 1
            GV4.SetRowCellValue(iCount, colFEISAU_FEI_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV5
        For iCount As Integer = 0 To GV5.RowCount - 1
            GV5.SetRowCellValue(iCount, colFEIPR_FEI_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV6
        For iCount As Integer = 0 To GV6.RowCount - 1
            GV6.SetRowCellValue(iCount, colFEISP_FEI_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV22
        For iCount As Integer = 0 To GV22.RowCount - 1
            GV22.SetRowCellValue(iCount, colFEIDT_FEI_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV23
        For iCount As Integer = 0 To GV23.RowCount - 1
            GV23.SetRowCellValue(iCount, colFEITX1_FEI_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV11
        For iCount As Integer = 0 To GV11.RowCount - 1
            GV11.SetRowCellValue(iCount, colFEINACT_FEI_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV12
        For iCount As Integer = 0 To GV12.RowCount - 1
            GV12.SetRowCellValue(iCount, colFEINAPT_FEI_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV13
        For iCount As Integer = 0 To GV13.RowCount - 1
            GV13.SetRowCellValue(iCount, colFEINA_FEI_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV14
        For iCount As Integer = 0 To GV14.RowCount - 1
            GV14.SetRowCellValue(iCount, colFEITX2_FEI_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV31
        For iCount As Integer = 0 To GV31.RowCount - 1
            GV31.SetRowCellValue(iCount, colFEITER_FEI_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV32
        For iCount As Integer = 0 To GV32.RowCount - 1
            GV32.SetRowCellValue(iCount, colFEICF_FEI_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV33
        For iCount As Integer = 0 To GV33.RowCount - 1
            GV33.SetRowCellValue(iCount, colFEIMS_FEI_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV34
        For iCount As Integer = 0 To GV34.RowCount - 1
            GV34.SetRowCellValue(iCount, colFEITX4_FEI_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV41
        For iCount As Integer = 0 To GV41.RowCount - 1
            GV41.SetRowCellValue(iCount, colFEICT_FEI_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV42
        For iCount As Integer = 0 To GV42.RowCount - 1
            GV42.SetRowCellValue(iCount, colFEIAFS_FEI_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV62
        For iCount As Integer = 0 To GV62.RowCount - 1
            GV62.SetRowCellValue(iCount, colFEIAFS_FEI_CODE_FK_PK1, Me.txtCode.Text)
        Next

        'GV43
        For iCount As Integer = 0 To GV43.RowCount - 1
            GV43.SetRowCellValue(iCount, colFEITX7_FEI_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV44
        For iCount As Integer = 0 To GV44.RowCount - 1
            GV44.SetRowCellValue(iCount, colFEITX5_FEI_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV51
        For iCount As Integer = 0 To GV51.RowCount - 1
            GV51.SetRowCellValue(iCount, colFEINACS_FEI_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV52
        For iCount As Integer = 0 To GV52.RowCount - 1
            GV52.SetRowCellValue(iCount, colFEINAPS_FEI_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV53
        For iCount As Integer = 0 To GV53.RowCount - 1
            GV53.SetRowCellValue(iCount, colFEINAS_FEI_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV54
        For iCount As Integer = 0 To GV54.RowCount - 1
            GV54.SetRowCellValue(iCount, colFEITX3_FEI_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV61
        For iCount As Integer = 0 To GV61.RowCount - 1
            GV61.SetRowCellValue(iCount, colFEICTS_FEI_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV63
        For iCount As Integer = 0 To GV63.RowCount - 1
            GV63.SetRowCellValue(iCount, colFEITX6_FEI_CODE_FK_PK, Me.txtCode.Text)
        Next
    End Sub

#End Region

#Region " Init Data  "

    ''' <summary>
    ''' Proçédure: Alimentation des sources des gridcontrols
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitDataSource()
        'Onglet Entités
        GC1.DataSource = DsTheriaque_Effets_Indesirables
        GC1.DataMember = FEICPH_EFFINDCLPH

        GC2.DataSource = DsTheriaque_Effets_Indesirables
        GC2.DataMember = FEICCH_EFFINDCLCH

        GC3.DataSource = DsTheriaque_Effets_Indesirables
        GC3.DataMember = FEISAC_EFFINDSUBAC

        GC4.DataSource = DsTheriaque_Effets_Indesirables
        GC4.DataMember = FEISAU_EFFINDSUBAU

        GC5.DataSource = DsTheriaque_Effets_Indesirables
        GC5.DataMember = FEIPR_EFFINDPROD

        GC6.DataSource = DsTheriaque_Effets_Indesirables
        GC6.DataMember = FEISP_EFFINDSPE

        'Onglet Effet
        GC21.DataSource = DsTheriaque_Effets_Indesirables
        GC21.DataMember = FEICH_EFFETIND_CH

        GC22.DataSource = DsTheriaque_Effets_Indesirables
        GC22.DataMember = FEIDT_COMMENT_DOSETH

        GC23.DataSource = DsTheriaque_Effets_Indesirables
        GC23.DataMember = FEITX1_EI_TXDOSETHER

        'Onglet A dose thérapeutique1
        GC11.DataSource = DsTheriaque_Effets_Indesirables
        GC11.DataMember = FEINACT_NATURETHER_EICLIN

        GC12.DataSource = DsTheriaque_Effets_Indesirables
        GC12.DataMember = FEINAPT_NATURTHER_EIPARACLIN

        GC13.DataSource = DsTheriaque_Effets_Indesirables
        GC13.DataMember = FEINA_COMMENT_NATUREDOSETH

        GC14.DataSource = DsTheriaque_Effets_Indesirables
        GC14.DataMember = FEITX2_EI_TXNATDOSETHER

        'Onglet A dose thérapeutique2
        GC31.DataSource = DsTheriaque_Effets_Indesirables
        GC31.DataMember = FEITER_TERRAINFAVORISANT

        GC32.DataSource = DsTheriaque_Effets_Indesirables
        GC32.DataMember = FEICF_COMMENT_CIRCONSTFAVORIS

        GC33.DataSource = DsTheriaque_Effets_Indesirables
        GC33.DataMember = FEIMS_COMMENT_MOMENTSURV

        GC34.DataSource = DsTheriaque_Effets_Indesirables
        GC34.DataMember = FEITX4_EI_TXFREQUENCE

        'Onglet A dose thérapeutique3
        GC41.DataSource = DsTheriaque_Effets_Indesirables
        GC41.DataMember = FEICT_COMMENT_CATDOSETH

        GC42.DataSource = DsTheriaque_Effets_Indesirables
        GC42.DataMember = FEIAFS_EFFETIND_AFSSAPS

        GC43.DataSource = DsTheriaque_Effets_Indesirables
        GC43.DataMember = FEITX7_EI_TXCONDDOSETHER

        GC44.DataSource = DsTheriaque_Effets_Indesirables
        GC44.DataMember = FEITX5_EI_TXSURVENUE

        'Onglet En cas de surdosage1
        GC51.DataSource = DsTheriaque_Effets_Indesirables
        GC51.DataMember = FEINACS_NATURSURDOS_EICLIN

        GC52.DataSource = DsTheriaque_Effets_Indesirables
        GC52.DataMember = FEINAPS_NATURSURDOS_EIPARACLIN

        GC53.DataSource = DsTheriaque_Effets_Indesirables
        GC53.DataMember = FEINAS_COMMENT_NATURESURDOSAG

        GC54.DataSource = DsTheriaque_Effets_Indesirables
        GC54.DataMember = FEITX3_EI_TXNATSURDOS

        'Onglet En cas de surdosage2

        GC61.DataSource = DsTheriaque_Effets_Indesirables
        GC61.DataMember = FEICTS_COMMENT_CATSURDOS

        GC62.DataSource = DsTheriaque_Effets_Indesirables
        GC62.DataMember = FEIAFS_EFFETIND_AFSSAPS

        GC63.DataSource = DsTheriaque_Effets_Indesirables
        GC63.DataMember = FEITX6_EI_TXCONDSURDOS

    End Sub

    ''' <summary>
    ''' Proçédure: Initialisation des données
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub InitData()
        MyBase.InitData()
        Declinaison_Global = True
        OnLoading = True
        MasterDataSet = Me.DsTheriaque_Effets_Indesirables
        MasterTable = FEI_FICHEEFFIND
        CodE = InvalideControl
        'Déclinaison classe CPH
        Dim List1 As New System.Collections.Generic.List(Of StructGVTable)
        List1.Add(New StructGVTable("GC1", eDeclinaison.CPH, colFEICPH_CPH_CODE_FK_PK2))
        List1.Add(New StructGVTable("GC2", eDeclinaison.CCH, colFEICCH_CCH_CODE_FK_PK2))
        List1.Add(New StructGVTable("GC3", eDeclinaison.SAC, colFEISAC_SAC_CODE_FK_PK2))
        List1.Add(New StructGVTable("GC6", eDeclinaison.SP, colFEISP_SP_CODE_FK_PK2))
        Dim DecCPH As New ClsDeclinaison(eDeclinaison.CPH, List1)
        InitLkup(Me.lkup_FEICPH, FEICPH_EFFINDCLPH, strSSQL_CPH_CLASSEPHARMTHER_NIVEAU, True, , , , , , DecCPH)

        'Déclinaison classe CCH
        Dim List2 As New System.Collections.Generic.List(Of StructGVTable)
        List2.Add(New StructGVTable("GC1", eDeclinaison.CPH, colFEICPH_CPH_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC2", eDeclinaison.CCH, colFEICCH_CCH_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC3", eDeclinaison.SAC, colFEISAC_SAC_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC6", eDeclinaison.SP, colFEISP_SP_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC4", eDeclinaison.SAU, colFEISAU_SAU_CODE_FK_PK2))
        Dim DecCCH As New ClsDeclinaison(eDeclinaison.CCH, List2)
        InitLkup(Me.lkup_FEICCH, FEICCH_EFFINDCLCH, strSSQL_CCH_CLASSECHIMIQUE_NIVEAU, True, , , , , , DecCCH)

        'Déclinaison SUBAC
        Dim List3 As New System.Collections.Generic.List(Of StructGVTable)
        List3.Add(New StructGVTable("GC3", eDeclinaison.SAC, colFEISAC_SAC_CODE_FK_PK2))
        List3.Add(New StructGVTable("GC6", eDeclinaison.SP, colFEISP_SP_CODE_FK_PK2))
        Dim DecSUBAC As New ClsDeclinaison(eDeclinaison.SAC, List3)
        InitLkup(Me.lkup_FEISAC, FEISAC_EFFINDSUBAC, strSSQL_SAC_SUBACTIVE, True, , , , , , DecSUBAC)

        'Déclinaison SAU
        Dim List4 As New System.Collections.Generic.List(Of StructGVTable)
        List4.Add(New StructGVTable("GC4", eDeclinaison.SAU, colFEISAU_SAU_CODE_FK_PK2))
        List4.Add(New StructGVTable("GC6", eDeclinaison.SP, colFEISP_SP_CODE_FK_PK2))
        Dim DecSAU As New ClsDeclinaison(eDeclinaison.SAU, List4)
        InitLkup(Me.lkup_FEISAU, FEISAU_EFFINDSUBAU, strSSQL_SAU_SUBAUXILIAIRE, True, , , , , , DecSAU)

        'Déclinaison PRODUIT
        Dim List5 As New System.Collections.Generic.List(Of StructGVTable)
        List5.Add(New StructGVTable("GC5", eDeclinaison.PR, colFEIPR_PR_CODE_FK_PK2))
        List5.Add(New StructGVTable("GC6", eDeclinaison.SP, colFEISP_SP_CODE_FK_PK2))
        Dim DecPR As New ClsDeclinaison(eDeclinaison.PR, List5)
        InitLkup(Me.lkup_FEIPR, FEIPR_EFFINDPROD, strSSQL_PR_PRODUIT, True, , , , , , DecPR)

        InitLkup(Me.lkup_FEISP, FEIPR_EFFINDPROD, strSSQL_SP_SPECIALITE, True)
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

    ''' <summary>
    ''' Proçédure: Ouverture d'une fiche de l'extèrieur
    ''' </summary>
    ''' <param name="CodE1">Code de la fiche</param>
    ''' <remarks></remarks>
    Private Sub Open_Fiche(ByVal CodE1 As Integer)
        OnLoading = True
        CodE = _Code
        EmptyDataTable()
        Me.FeI_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEI_FICHEEFFIND, CodE1)

        'Onglet Entités
        Me.FeicpH_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEICPH_EFFINDCLPH, CodE1)
        Me.FeiccH_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEICCH_EFFINDCLCH, CodE1)
        Me.FeisaC_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEISAC_EFFINDSUBAC, CodE1)
        Me.FeisaU_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEISAU_EFFINDSUBAU, CodE1)
        Me.FeipR_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEIPR_EFFINDPROD, CodE1)
        Me.FeisP_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEISP_EFFINDSPE, CodE1)

        Tab_TA1 = False
        Tab_TA2 = False
        Tab_TA3 = False
        Tab_TA4 = False
        Tab_TA5 = False
        Tab_TA6 = False
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
            InitLkup(Me.lkup_FEICH, FEICH_EFFETIND_CH, strSSQL_CH_CHOIX, True)
            InitLkup(Me.lkup_FEIDT, FEIDT_COMMENT_DOSETH, strSSQL_CDF_CODIF("EC", " and substring(CDF_CODE_PK, 1, 1) =  'A'"), True)
            Tab_lkup1 = True
        End If
        If Not Tab_TA1 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.FeicH_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEICH_EFFETIND_CH, CodE)
            Me.FeidT_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEIDT_COMMENT_DOSETH, CodE)
            Me.FeitX1_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEITX1_EI_TXDOSETHER, CodE)
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
        Load_On(Me)
        OnLoading = True
        If Not Tab_lkup2 Then
            InitLkup(Me.lkup_FEINACT, FEINACT_NATURETHER_EICLIN, strSSQL_CDF_CODIF_NIVEAU("EN", " and substring(CDF_CODE_PK, 1, 1) <>  'Q'"), True)
            InitLkup(Me.lkup_FEINAPT, FEINAPT_NATURTHER_EIPARACLIN, strSSQL_CDF_CODIF_NIVEAU("EN", " and substring(CDF_CODE_PK, 1, 1) =  'Q'"), True)
            InitLkup(Me.lkup_FEINA, FEINA_COMMENT_NATUREDOSETH, strSSQL_CDF_CODIF("EC", " and substring(CDF_CODE_PK, 1, 1) =  'B'"), True)
            Tab_lkup2 = True
        End If
        If Not Tab_TA2 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.FeinacT_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEINACT_NATURETHER_EICLIN, CodE)
            Me.FeinapT_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEINAPT_NATURTHER_EIPARACLIN, CodE)
            Me.FeinA_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEINA_COMMENT_NATUREDOSETH, CodE)
            Me.FeitX2_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEITX2_EI_TXNATDOSETHER, CodE)
            Tab_TA2 = True
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub

    ''' <summary>
    ''' Proçédure: Chargement du troisiéme onglet
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadTab_3()
        Load_On(Me)
        OnLoading = True
        If Not Tab_lkup3 Then
            InitLkup(Me.lkup_FEITER, FEITER_TERRAINFAVORISANT, strSSQL_CDF_CODIF_NIVEAU("CS"), True)
            InitLkup(Me.lkup_FEICF, FEICF_COMMENT_CIRCONSTFAVORIS, strSSQL_CDF_CODIF("EC", " and substring(CDF_CODE_PK, 1, 1) =  'C'"), True)
            InitLkup(Me.lkup_FEIMS, FEIMS_COMMENT_MOMENTSURV, strSSQL_CDF_CODIF("EC", " and substring(CDF_CODE_PK, 1, 1) =  'D'"), True)
            Tab_lkup3 = True
        End If
        If Not Tab_TA3 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.FeiteR_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEITER_TERRAINFAVORISANT, CodE)
            Me.FeicF_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEICF_COMMENT_CIRCONSTFAVORIS, CodE)
            Me.FeimS_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEIMS_COMMENT_MOMENTSURV, CodE)
            Me.FeitX4_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEITX4_EI_TXFREQUENCE, CodE)
            Tab_TA3 = True
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub

    ''' <summary>
    ''' Proçédure: Chargement du quatriéme onglet
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadTab_4()
        Load_On(Me)
        OnLoading = True

        If CodE <> InvalideControl And CodE <> Nothing Then
            Dim strSSQL_SP_REF As String
            strSSQL_SP_REF = " SELECT SP_CODE_SQ_PK as code, SP_NOM as libelle FROM THERIAQUE.FEISP_EFFINDSPE, THERIAQUE.SP_SPECIALITE"
            strSSQL_SP_REF &= " WHERE FEISP_FEI_CODE_FK_PK = " & CodE
            strSSQL_SP_REF &= " AND SP_CODE_SQ_PK = FEISP_SP_CODE_FK_PK"
            InitLkup(Me.lkup_FEIAFS_SP, FEIAFS_EFFETIND_AFSSAPS, strSSQL_SP_REF, True)
            For iCount As Integer = 0 To GV42.RowCount
                If GV42.GetRowCellDisplayText(iCount, "FEIAFS_SP_CODE_FK_PK") = "" And GV42.GetRowCellDisplayText(iCount, "FEIAFS_FEI_CODE_FK_PK") <> "" Then
                    GV42.DeleteRow(iCount)
                    iCount = iCount - 1
                End If
            Next
        End If

        If Not Tab_lkup4 Then
            InitLkup(Me.Lkup_FEICT, FEICT_COMMENT_CATDOSETH, strSSQL_CDF_CODIF("EC", " and substring(CDF_CODE_PK, 1, 1) =  'E'"), True)
            InitLkup(Me.lkup_FEIAFS, FEIAFS_EFFETIND_AFSSAPS, strSSQL_CDF_CODIF("25"), True)
            Tab_lkup4 = True
        End If
        If Not Tab_TA4 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.FeicT_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEICT_COMMENT_CATDOSETH, CodE)
            Me.FeiafS_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEIAFS_EFFETIND_AFSSAPS, CodE)
            Me.FeitX7_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEITX7_EI_TXCONDDOSETHER, CodE)
            Me.FeitX5_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEITX5_EI_TXSURVENUE, CodE)
            'Filtre
            colFEIAFS_TYPEDOSE_THSURD_PK.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("FEIAFS_TYPEDOSE_THSURD_PK = 'T'")
            Tab_TA4 = True
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub

    ''' <summary>
    ''' Proçédure: Chargement du cinquiéme onglet
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadTab_5()
        Load_On(Me)
        OnLoading = True
        If Not Tab_lkup5 Then
            InitLkup(Me.lkup_FEINACS, FEINACS_NATURSURDOS_EICLIN, strSSQL_CDF_CODIF_NIVEAU("EN", " and substring(CDF_CODE_PK, 1, 1) <>  'Q'"), True)
            InitLkup(Me.lkup_FEINAPS, FEINAPS_NATURSURDOS_EIPARACLIN, strSSQL_CDF_CODIF_NIVEAU("EN", " and substring(CDF_CODE_PK, 1, 1) =  'Q'"), True)
            InitLkup(Me.lkup_FEINAS, FEINAS_COMMENT_NATURESURDOSAG, strSSQL_CDF_CODIF("EC", " and substring(CDF_CODE_PK, 1, 1) =  'B'"), True)
            Tab_lkup5 = True
        End If
        If Not Tab_TA5 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.FeinacS_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEINACS_NATURSURDOS_EICLIN, CodE)
            Me.FeinapS_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEINAPS_NATURSURDOS_EIPARACLIN, CodE)
            Me.FeinaS_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEINAS_COMMENT_NATURESURDOSAG, CodE)
            Me.FeitX3_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEITX3_EI_TXNATSURDOS, CodE)
            Tab_TA5 = True
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub

    ''' <summary>
    ''' Proçédure: Chargement du sixiéme onglet
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadTab_6()
        Load_On(Me)
        OnLoading = True
        If CodE <> InvalideControl And CodE <> Nothing Then
            Dim strSSQL_SP_REF As String
            strSSQL_SP_REF = " SELECT SP_CODE_SQ_PK as code, SP_NOM as libelle FROM THERIAQUE.FEISP_EFFINDSPE, THERIAQUE.SP_SPECIALITE"
            strSSQL_SP_REF &= " WHERE FEISP_FEI_CODE_FK_PK = " & CodE
            strSSQL_SP_REF &= " AND SP_CODE_SQ_PK = FEISP_SP_CODE_FK_PK"
            InitLkup(Me.lkup_FEIAFS1_Sp, FEIAFS_EFFETIND_AFSSAPS, strSSQL_SP_REF, True)
            For iCount As Integer = 0 To GV62.RowCount
                If GV62.GetRowCellDisplayText(iCount, "FEIAFS_SP_CODE_FK_PK") = "" And GV62.GetRowCellDisplayText(iCount, "FEIAFS_FEI_CODE_FK_PK") <> "" Then
                    GV62.DeleteRow(iCount)
                    iCount = iCount - 1
                End If
            Next
        End If
        If Not Tab_lkup6 Then
            InitLkup(Me.lkup_FEICTS, FEICTS_COMMENT_CATSURDOS, strSSQL_CDF_CODIF("EC", " and substring(CDF_CODE_PK, 1, 1) = 'E'"), True)
            InitLkup(Me.lkup_FEIAFS1, FEIAFS_EFFETIND_AFSSAPS, strSSQL_CDF_CODIF("25"), True)
            Tab_lkup6 = True
        End If
        If Not Tab_TA6 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.FeictS_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEICTS_COMMENT_CATSURDOS, CodE)
            Me.FeiafS_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEIAFS_EFFETIND_AFSSAPS, CodE)
            Me.FeitX6_TA.FillByCode(Me.DsTheriaque_Effets_Indesirables.FEITX6_EI_TXCONDSURDOS, CodE)
            'Filtre
            colFEIAFS_TYPEDOSE_THSURD_PK1.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("FEIAFS_TYPEDOSE_THSURD_PK = 'S'")
            Tab_TA6 = True
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
        If XtraTabControl1.SelectedTabPageIndex = 3 Then
            LoadTab_3()
            Exit Sub
        End If
        If XtraTabControl1.SelectedTabPageIndex = 4 Then
            LoadTab_4()
            Exit Sub
        End If
        If XtraTabControl1.SelectedTabPageIndex = 5 Then
            LoadTab_5()
            Exit Sub
        End If
        If XtraTabControl1.SelectedTabPageIndex = 6 Then
            LoadTab_6()
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
        GV1.SetFocusedRowCellValue(colFEICPH_FEI_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV2</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        If OnLoading Then Exit Sub
        GV2.SetFocusedRowCellValue(colFEICCH_FEI_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV3</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV3_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV3.InitNewRow
        If OnLoading Then Exit Sub
        GV3.SetFocusedRowCellValue(colFEISAC_FEI_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV4</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV4_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV4.InitNewRow
        If OnLoading Then Exit Sub
        GV4.SetFocusedRowCellValue(colFEISAU_FEI_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV5</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV5_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV5.InitNewRow
        If OnLoading Then Exit Sub
        GV5.SetFocusedRowCellValue(colFEIPR_FEI_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV6</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV6_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV6.InitNewRow
        If OnLoading Then Exit Sub
        GV6.SetFocusedRowCellValue(colFEISP_FEI_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV21</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV21_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV21.InitNewRow
        If OnLoading Then Exit Sub
        GV21.SetFocusedRowCellValue(colFEICH_FEI_CODE_FK_PK, txtCode.Text)
        GV21.SetFocusedRowCellValue(colFEICH_NUMORD, Code_MAx(GV21, colFEICH_NUMORD))
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV22</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV22_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV22.InitNewRow
        If OnLoading Then Exit Sub
        GV22.SetFocusedRowCellValue(colFEIDT_FEI_CODE_FK_PK, txtCode.Text)
        GV22.SetFocusedRowCellValue(colFEIDT_NUMORD, Code_MAx(GV22, colFEIDT_NUMORD))
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV11</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV11_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV11.InitNewRow
        If OnLoading Then Exit Sub
        GV11.SetFocusedRowCellValue(colFEINACT_FEI_CODE_FK_PK, txtCode.Text)
        GV11.SetFocusedRowCellValue(colFEINACT_NUMORD, Code_MAx(GV11, colFEINACT_NUMORD))
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV12</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV12_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV12.InitNewRow
        If OnLoading Then Exit Sub
        GV12.SetFocusedRowCellValue(colFEINAPT_FEI_CODE_FK_PK, txtCode.Text)
        GV12.SetFocusedRowCellValue(colFEINAPT_NUMORD, Code_MAx(GV12, colFEINAPT_NUMORD))
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV13</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV13_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV13.InitNewRow
        If OnLoading Then Exit Sub
        GV13.SetFocusedRowCellValue(colFEINA_FEI_CODE_FK_PK, txtCode.Text)
        GV13.SetFocusedRowCellValue(colFEINA_NUMORD, Code_MAx(GV13, colFEINA_NUMORD))
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV31</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV31_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV31.InitNewRow
        If OnLoading Then Exit Sub
        GV31.SetFocusedRowCellValue(colFEITER_FEI_CODE_FK_PK, txtCode.Text)
        GV31.SetFocusedRowCellValue(colFEITER_NUMORD, Code_MAx(GV31, colFEITER_NUMORD))
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV32</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV32_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV32.InitNewRow
        If OnLoading Then Exit Sub
        GV32.SetFocusedRowCellValue(colFEICF_FEI_CODE_FK_PK, txtCode.Text)
        GV32.SetFocusedRowCellValue(colFEICF_NUMORD, Code_MAx(GV32, colFEICF_NUMORD))
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV33</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV33_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV33.InitNewRow
        If OnLoading Then Exit Sub
        GV33.SetFocusedRowCellValue(colFEIMS_FEI_CODE_FK_PK, txtCode.Text)
        GV33.SetFocusedRowCellValue(colFEIMS_NUMORD, Code_MAx(GV33, colFEIMS_NUMORD))
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV41</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV41_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV41.InitNewRow
        If OnLoading Then Exit Sub
        GV41.SetFocusedRowCellValue(colFEICT_FEI_CODE_FK_PK, txtCode.Text)
        GV41.SetFocusedRowCellValue(colFEICT_NUMORD, Code_MAx(GV41, colFEICT_NUMORD))
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV42</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV42_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV42.InitNewRow
        If OnLoading Then Exit Sub
        If ComboBoxEdit2.SelectedItem = "O" Then
            GV42.SetFocusedRowCellValue(colFEIAFS_FEI_CODE_FK_PK, txtCode.Text)
            GV42.SetFocusedRowCellValue(colFEIAFS_TYPEDOSE_THSURD_PK, "T")
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV51</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV51_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV51.InitNewRow
        If OnLoading Then Exit Sub
        GV51.SetFocusedRowCellValue(colFEINACS_FEI_CODE_FK_PK, txtCode.Text)
        GV51.SetFocusedRowCellValue(colFEINACS_NUMORD, Code_MAx(GV51, colFEINACS_NUMORD))
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV52</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV52_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV52.InitNewRow
        If OnLoading Then Exit Sub
        GV52.SetFocusedRowCellValue(colFEINAPS_FEI_CODE_FK_PK, txtCode.Text)
        GV52.SetFocusedRowCellValue(colFEINAPS_NUMORD, Code_MAx(GV52, colFEINAPS_NUMORD))
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV53</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV53_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV53.InitNewRow
        If OnLoading Then Exit Sub
        GV53.SetFocusedRowCellValue(colFEINAS_FEI_CODE_FK_PK, txtCode.Text)
        GV53.SetFocusedRowCellValue(colFEINAS_NUMORD, Code_MAx(GV53, colFEINAS_NUMORD))
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV61</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV61_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV61.InitNewRow
        If OnLoading Then Exit Sub
        GV61.SetFocusedRowCellValue(colFEICTS_FEI_CODE_FK_PK, txtCode.Text)
        GV61.SetFocusedRowCellValue(colFEICTS_NUMORD, Code_MAx(GV61, colFEICTS_NUMORD))
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV62</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV62_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV62.InitNewRow
        If OnLoading Then Exit Sub
        If ComboBoxEdit2.SelectedItem = "N" Then
            GV62.SetFocusedRowCellValue(colFEIAFS_FEI_CODE_FK_PK1, txtCode.Text)
            GV62.SetFocusedRowCellValue(colFEIAFS_TYPEDOSE_THSURD_PK1, "S")
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV23</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV23_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV23.InitNewRow
        Me.GV23.SetFocusedRowCellValue(Me.colFEITX1_FEI_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV14</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV14_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV14.InitNewRow
        Me.GV14.SetFocusedRowCellValue(Me.colFEITX2_FEI_CODE_FK_PK, txtCode.Text)
        'If GV14.RowCount >= 0 Then
        '    GV14.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
        'End If
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV34</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV34_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV34.InitNewRow
        Me.GV34.SetFocusedRowCellValue(Me.colFEITX4_FEI_CODE_FK_PK, txtCode.Text)
        'If GV34.RowCount >= 0 Then
        '    GV34.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
        'End If
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV43</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV43_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV43.InitNewRow
        Me.GV43.SetFocusedRowCellValue(Me.colFEITX7_FEI_CODE_FK_PK, txtCode.Text)
        'If GV43.RowCount >= 0 Then
        '    GV43.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
        'End If
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV44</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV44_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV44.InitNewRow
        Me.GV44.SetFocusedRowCellValue(Me.colFEITX5_FEI_CODE_FK_PK, txtCode.Text)
        'If GV44.RowCount >= 0 Then
        '    GV44.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
        'End If
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV54</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV54_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV54.InitNewRow
        Me.GV54.SetFocusedRowCellValue(Me.colFEITX3_FEI_CODE_FK_PK, txtCode.Text)
        'If GV54.RowCount >= 0 Then
        '    GV54.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
        'End If
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV63</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV63_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV63.InitNewRow
        Me.GV63.SetFocusedRowCellValue(Me.colFEITX6_FEI_CODE_FK_PK, txtCode.Text)
        'If GV63.RowCount >= 0 Then
        '    GV63.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
        'End If
    End Sub

#End Region

#Region " panel Resize "

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
    ''' <param name="sender">Panel5</param>
    ''' <param name="e">Resize</param>
    ''' <remarks></remarks>
    Private Sub Panel5_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel5.Resize
        GC11.Width = Panel5.Width / 2
        GC12.Width = Panel5.Width / 2
    End Sub

    ''' <summary>
    ''' Evénement: Redimensionnement du panel
    ''' </summary>
    ''' <param name="sender">Panel13</param>
    ''' <param name="e">Resize</param>
    ''' <remarks></remarks>
    Private Sub Panel13_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel13.Resize
        GC31.Width = Panel13.Width / 2
        GC32.Width = Panel13.Width / 2
    End Sub

    ''' <summary>
    ''' Evénement: Redimensionnement du panel
    ''' </summary>
    ''' <param name="sender">Panel8</param>
    ''' <param name="e">Resize</param>
    ''' <remarks></remarks>
    Private Sub Panel18_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel18.Resize
        GC51.Width = Panel18.Width / 2
        GC52.Width = Panel18.Width / 2
    End Sub

    ''' <summary>
    ''' Evénement: Redimensionnement d'onglet
    ''' </summary>
    ''' <param name="sender">XtraTabControl1</param>
    ''' <param name="e">Resize</param>
    ''' <remarks></remarks>
    Private Sub XtraTabControl1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraTabControl1.Resize
        Panel4.Height = XtraTabControl1.Height / 3
        Panel6.Height = XtraTabControl1.Height / 3
        Panel7.Height = XtraTabControl1.Height / 3

        Panel13.Height = GroupControl4.Height / 2
        Panel14.Height = GroupControl4.Height / 2

        Panel35.Height = XtraTabControl1.Height / 4
        Panel42.Height = XtraTabControl1.Height / 4
        Panel43.Height = XtraTabControl1.Height / 4
        Panel44.Height = XtraTabControl1.Height / 6

        Panel2.Height = XtraTabControl1.Height / 3
        Panel3.Height = XtraTabControl1.Height / 3
        'Panel24.Height = XtraTabControl1.Height / 4
        Panel12.Height = XtraTabControl1.Height / 3

        Panel5.Height = GroupControl1.Height / 3
        Panel8.Height = GroupControl1.Height / 3
        Panel9.Height = GroupControl1.Height / 3

        Panel18.Height = GroupControl5.Height / 3
        Panel19.Height = GroupControl5.Height / 3
        Panel20.Height = GroupControl5.Height / 3

        Panel21.Height = GroupControl6.Height / 3
        Panel22.Height = GroupControl6.Height / 3
        Panel23.Height = GroupControl6.Height / 3

        GroupControl2.Height = XtraTabControl1.Height / 2
        GroupControl4.Height = XtraTabControl1.Height / 2
    End Sub


#End Region

#Region " Autres événements "

    ''' <summary>
    ''' Evénement: Changement de la sélection du combo
    ''' </summary>
    ''' <param name="sender">ComboBoxEdit2</param>
    ''' <param name="e">SelectedIndexChanged</param>
    ''' <remarks></remarks>
    Private Sub ComboBoxEdit2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEdit2.SelectedIndexChanged
        If (ComboBoxEdit2.SelectedItem = "O") Then
            XTabPage_ECSUR1.PageEnabled = False
            XTabPage_ECSUR2.PageEnabled = False
            XTabPage_ADTh1.PageEnabled = True
            XTabPage_ADTh2.PageEnabled = True
            XTabPage_ADTh3.PageEnabled = True
            XtraTabControl1.SelectedTabPageIndex = 2
            LoadTab_2()
        ElseIf (ComboBoxEdit2.SelectedItem = "N") Then
            XTabPage_ADTh1.PageEnabled = False
            XTabPage_ADTh2.PageEnabled = False
            XTabPage_ADTh3.PageEnabled = False
            XTabPage_ECSUR1.PageEnabled = True
            XTabPage_ECSUR2.PageEnabled = True
            XtraTabControl1.SelectedTabPageIndex = 5
            LoadTab_5()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Changement du nombre de lignes
    ''' </summary>
    ''' <param name="sender">GV</param>
    ''' <param name="e">RowCountChanged</param>
    ''' <remarks></remarks>
    Private Sub GV_RowCountChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV23.RowCountChanged, GV14.RowCountChanged, GV34.RowCountChanged, GV43.RowCountChanged, GV44.RowCountChanged, GV54.RowCountChanged, GV63.RowCountChanged
        If sender.RowCount >= 1 Then
            sender.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
            sender.GridControl.EmbeddedNavigator.Buttons.Append.Enabled = False
        Else
            sender.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            sender.GridControl.EmbeddedNavigator.Buttons.Append.Enabled = False
        End If
    End Sub

#End Region

    Private Sub GV_CalcRowHeight(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs) Handles GV23.CalcRowHeight, GV14.CalcRowHeight, GV63.CalcRowHeight, GV54.CalcRowHeight, GV44.CalcRowHeight, GV43.CalcRowHeight, GV34.CalcRowHeight
        e.RowHeight = sender.GridControl.Height
    End Sub

End Class
