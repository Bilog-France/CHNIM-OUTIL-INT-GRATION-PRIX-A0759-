''' <summary>
''' Created By [BFE]
''' </summary>
''' <remarks> Analyse d'ordonnance - (In)compatibilités - Fiche
''' </remarks>
Public Class Frm_Incompatibilites_Fiche

#Region "Déclaration des variables privées"
    Private CodE As String
    Private Tab_lkup1 As Boolean = False
    Private Tab_TA1 As Boolean = False
    Private Tab_lkup2 As Boolean = False
    Private Tab_TA2 As Boolean = False
    Private Tab_lkup3 As Boolean = False
    Private Tab_TA3 As Boolean = False
    Public _Code As Integer = Nothing ' charger la fiche depuis l'extérieur
    Private bModeDuplication As Boolean = False
#End Region

#Region " Edit Data  "

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_FIC_INCOMPATIBILITE
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
        f._SSQL = strSSQL_FIC_INCOMPATIBILITE_SPECIALITE()
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            XtraTabControl1.SelectedTabPageIndex = 0
            OnLoading = True
            EmptyDataTable()
            Me.FiC_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance2.FIC_INCOMPATIBILITE, f._Code)
            'Onglet Terme 1
            Me.IC1SAC_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance2.IC1SAC_TERME1SUBACT, f._Code)
            Me.IC1SAU_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance2.IC1SAU_TERME1SUBAUX, f._Code)
            Me.IC1PR_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance2.IC1PR_TERME1PRODUIT, f._Code)
            Me.IC1SP_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance2.IC1SP_TERME1SPECIALITE, f._Code)

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
        Dim sCodeSUBAC1 As String = ""
        Dim sCodeSAU1 As String = ""
        Dim sCodePR1 As String = ""
        Dim sCodeSP1 As String = ""
        Dim sCodeSUBAC2 As String = ""
        Dim sCodeSAU2 As String = ""
        Dim sCodePR2 As String = ""
        Dim sCodeSP2 As String = ""
        Dim sCodeSOL As String = ""
        Dim sCodeV1 As String = ""
        Dim sCodeV2 As String = ""
        Dim sCodeMAT As String = ""
        Dim sCodeCONT As String = ""
        Dim sCodeNAT As String = ""
        Dim sCodeDUR As String = ""
        Dim sCodeTEMP As String = ""
        Dim sCodeLUM As String = ""
        
        Dim f As New Frm_IncompatibiliteMultiCriteres
        f.ShowDialog()
        If f._Validate Then
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
            If f._bSOL Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("MS")
                fDICO.Text = "Solutions"
                fDICO.ShowDialog()
                sCodeSOL = fDICO._Code
            End If
            If f._bV1 Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("MV")
                fDICO.Text = "Vecteurs 1"
                fDICO.ShowDialog()
                sCodeV1 = fDICO._Code
            End If
            If f._bV2 Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("MV")
                fDICO.Text = "Vecteurs 2"
                fDICO.ShowDialog()
                sCodeV2 = fDICO._Code
            End If
            If f._bMAT Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("09")
                fDICO.Text = "Matériaux"
                fDICO.ShowDialog()
                sCodeMAT = fDICO._Code
            End If
            If f._bCONT Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("04")
                fDICO.Text = "Contenants"
                fDICO.ShowDialog()
                sCodeCONT = fDICO._Code
            End If
            If f._bNAT Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("MN", " and substring(CDF_CODE_PK, 1, 1) <> 'I'")
                fDICO.Text = "Natures"
                fDICO.ShowDialog()
                sCodeNAT = fDICO._Code
            End If
            If f._bDUR Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("MD")
                fDICO.Text = "Durées - délais"
                fDICO.ShowDialog()
                sCodeDUR = fDICO._Code
            End If
            If f._bTEMP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("MT")
                fDICO.Text = "Températures"
                fDICO.ShowDialog()
                sCodeTEMP = fDICO._Code
            End If
            If f._bLUM Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("ML")
                fDICO.Text = "Lumières"
                fDICO.ShowDialog()
                sCodeLUM = fDICO._Code
            End If
            
            Dim fResultat As New Frm_Recherche
            Dim sSQL As String = ""
            sSQL &= " Select FIC_CODE_SQ_PK as code, '' as libelle From THERIAQUE.FIC_INCOMPATIBILITE"
            If sCodeSUBAC1 <> "" Then
                sSQL &= " WHERE FIC_CODE_SQ_PK IN (SELECT IC1SAC_FIC_CODE_FK_PK FROM THERIAQUE.IC1SAC_TERME1SUBACT WHERE IC1SAC_SAC_CODE_FK_PK = " & cn.SQLText(sCodeSUBAC1) & ")"
            End If
            If sCodeSAU1 <> "" Then
                If sCodeSUBAC1 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIC_CODE_SQ_PK IN (SELECT IC1SAU_FIC_CODE_FK_PK FROM THERIAQUE.IC1SAU_TERME1SUBAUX WHERE IC1SAU_SAU_CODE_FK_PK = " & cn.SQLText(sCodeSAU1) & ")"
            End If
            If sCodePR1 <> "" Then
                If sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIC_CODE_SQ_PK IN (SELECT IC1PR_FIC_CODE_FK_PK FROM THERIAQUE.IC1PR_TERME1PRODUIT WHERE IC1PR_PR_CODE_FK_PK = " & cn.SQLText(sCodePR1) & ")"
            End If
            If sCodeSP1 <> "" Then
                If sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIC_CODE_SQ_PK IN (SELECT IC1SP_FIC_CODE_FK_PK FROM THERIAQUE.IC1SP_TERME1SPECIALITE WHERE IC1SP_SP_CODE_FK_PK = " & cn.SQLText(sCodeSP1) & ")"
            End If
            If sCodeSUBAC2 <> "" Then
                If sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIC_CODE_SQ_PK IN (SELECT IC2SAC_FIC_CODE_FK_PK FROM THERIAQUE.IC2SAC_TERME2SUBACT WHERE IC2SAC_SAC_CODE_FK_PK = " & cn.SQLText(sCodeSUBAC2) & ")"
            End If
            If sCodeSAU2 <> "" Then
                If sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeSUBAC2 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIC_CODE_SQ_PK IN (SELECT IC2SAU_FIC_CODE_FK_PK FROM THERIAQUE.IC2SAU_TERME2SUBAUX WHERE IC2SAU_SAU_CODE_FK_PK = " & cn.SQLText(sCodeSAU2) & ")"
            End If
            If sCodePR2 <> "" Then
                If sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeSUBAC2 <> "" Or sCodeSAU2 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIC_CODE_SQ_PK IN (SELECT IC2PR_FIC_CODE_FK_PK FROM THERIAQUE.IC2PR_TERME2PRODUIT WHERE IC2PR_PR_CODE_FK_PK = " & cn.SQLText(sCodePR2) & ")"
            End If
            If sCodeSP2 <> "" Then
                If sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeSUBAC2 <> "" Or sCodeSAU2 <> "" Or sCodePR2 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIC_CODE_SQ_PK IN (SELECT IC2SP_FIC_CODE_FK_PK FROM THERIAQUE.IC2SP_TERME2SPECIALITE WHERE IC2SP_SP_CODE_FK_PK = " & cn.SQLText(sCodeSP2) & ")"
            End If
            If sCodeSOL <> "" Then
                If sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeSUBAC2 <> "" Or sCodeSAU2 <> "" Or sCodePR2 <> "" Or sCodeSP2 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIC_CODE_SQ_PK IN (SELECT ICSOL_FIC_CODE_FK_PK FROM THERIAQUE.ICSOL_INCOMPATIBILITE_SOLUTION WHERE ICSOL_CDF_SOLIC_CODE_FK_PK = " & cn.SQLText(sCodeSOL) & ")"
            End If
            If sCodeV1 <> "" Then
                If sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeSUBAC2 <> "" Or sCodeSAU2 <> "" Or sCodePR2 <> "" Or sCodeSP2 <> "" Or sCodeSOL <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIC_CODE_SQ_PK IN (SELECT IC1VE_FIC_CODE_FK_PK FROM THERIAQUE.IC1VE_INCOMPATIBILITE_VECTEUR1 WHERE IC1VE_CDF_VEIC_CODE_FK_PK = " & cn.SQLText(sCodeV1) & ")"
            End If
            If sCodeV2 <> "" Then
                If sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeSUBAC2 <> "" Or sCodeSAU2 <> "" Or sCodePR2 <> "" Or sCodeSP2 <> "" Or sCodeSOL <> "" Or sCodeV1 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIC_CODE_SQ_PK IN (SELECT IC2VE_FIC_CODE_FK_PK FROM THERIAQUE.IC2VE_INCOMPATIBILITE_VECTEUR2 WHERE IC2VE_CDF_VEIC_CODE_FK_PK = " & cn.SQLText(sCodeV2) & ")"
            End If
            If sCodeMAT <> "" Then
                If sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeSUBAC2 <> "" Or sCodeSAU2 <> "" Or sCodePR2 <> "" Or sCodeSP2 <> "" Or sCodeSOL <> "" Or sCodeV1 <> "" Or sCodeV2 <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIC_CODE_SQ_PK IN (SELECT ICMA_FIC_CODE_FK_PK FROM THERIAQUE.ICMA_INCOMPATIBILITE_MATERIAU WHERE ICMA_CDF_MAIC_CODE_FK_PK = " & cn.SQLText(sCodeMAT) & ")"
            End If
            If sCodeCONT <> "" Then
                If sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeSUBAC2 <> "" Or sCodeSAU2 <> "" Or sCodePR2 <> "" Or sCodeSP2 <> "" Or sCodeSOL <> "" Or sCodeV1 <> "" Or sCodeV2 <> "" Or sCodeMAT <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIC_CODE_SQ_PK IN (SELECT ICCO_FIC_CODE_FK_PK FROM THERIAQUE.ICCO_INCOMPATIBILITE_CONTENANT WHERE ICCO_CDF_COIC_CODE_FK_PK = " & cn.SQLText(sCodeCONT) & ")"
            End If
            If sCodeNAT <> "" Then
                If sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeSUBAC2 <> "" Or sCodeSAU2 <> "" Or sCodePR2 <> "" Or sCodeSP2 <> "" Or sCodeSOL <> "" Or sCodeV1 <> "" Or sCodeV2 <> "" Or sCodeMAT <> "" Or sCodeCONT <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIC_CODE_SQ_PK IN (SELECT ICNA_FIC_CODE_FK_PK FROM THERIAQUE.ICNA_INCOMPATIBILITE_NATURE WHERE ICNA_CDF_NAIC_CODE_FK_PK = " & cn.SQLText(sCodeNAT) & ")"
            End If
            If sCodeDUR <> "" Then
                If sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeSUBAC2 <> "" Or sCodeSAU2 <> "" Or sCodePR2 <> "" Or sCodeSP2 <> "" Or sCodeSOL <> "" Or sCodeV1 <> "" Or sCodeV2 <> "" Or sCodeMAT <> "" Or sCodeCONT <> "" Or sCodeNAT <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIC_CODE_SQ_PK IN (SELECT ICDUR_FIC_CODE_FK_PK FROM THERIAQUE.ICDUR_INCOMPATIBILITE_DUREE WHERE ICDUR_CDF_DUR_CODE_FK_PK = " & cn.SQLText(sCodeDUR) & ")"
            End If
            If sCodeTEMP <> "" Then
                If sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeSUBAC2 <> "" Or sCodeSAU2 <> "" Or sCodePR2 <> "" Or sCodeSP2 <> "" Or sCodeSOL <> "" Or sCodeV1 <> "" Or sCodeV2 <> "" Or sCodeMAT <> "" Or sCodeCONT <> "" Or sCodeNAT <> "" Or sCodeDUR <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIC_CODE_SQ_PK IN (SELECT ICTMP_FIC_CODE_FK_PK FROM THERIAQUE.ICTMP_INCOMPA_TEMPERATURE WHERE ICTMP_CDF_TEMP_CODE_FK_PK = " & cn.SQLText(sCodeTEMP) & ")"
            End If
            If sCodeLUM <> "" Then
                If sCodeSUBAC1 <> "" Or sCodeSAU1 <> "" Or sCodePR1 <> "" Or sCodeSP1 <> "" Or sCodeSUBAC2 <> "" Or sCodeSAU2 <> "" Or sCodePR2 <> "" Or sCodeSP2 <> "" Or sCodeSOL <> "" Or sCodeV1 <> "" Or sCodeV2 <> "" Or sCodeMAT <> "" Or sCodeCONT <> "" Or sCodeNAT <> "" Or sCodeDUR <> "" Or sCodeTEMP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIC_CODE_SQ_PK IN (SELECT ICLUM_FIC_CODE_FK_PK FROM THERIAQUE.ICLUM_INCOMPATIBILITE_LUMIERE WHERE ICLUM_CDF_LUM_CODE_FK_PK = " & cn.SQLText(sCodeLUM) & ")"
            End If

            sSQL &= " ORDER BY FIC_CODE_SQ_PK"

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
        CodE = InvalideControl
        MyBase.Ajouter()
        bModeDuplication = False
        cmbOrigine.SelectedItem = "Trissel"
        XtraTabControl1.SelectedTabPageIndex = 0
    End Sub

    Protected Friend Overrides Function ValideControl(Optional ByRef Ctrl As Control = Nothing, Optional ByVal AllCtrl As Boolean = True) As Boolean
        Dim strSSQL As String = ""
        MyBase.ValideControl(Ctrl)
        If ComboBoxEdit2.SelectedItem Is DBNull.Value Then
            DxErrorProvider.SetError(ComboBoxEdit2, "Saisie obligatoire.")
            Return False
        Else
            DxErrorProvider.SetError(ComboBoxEdit2, "")
        End If
        Return True
    End Function

    Public Overrides Function supprimer() As Boolean
        MyBase.Supprimer()
        If Tab_TA1 And Tab_TA2 And Tab_TA3 Then
            Dim iCount As Integer
            'Onglet Terme1
            For iCount = 0 To DsTheriaque_AnalyseOrdonance2.IC1SAU_TERME1SUBAUX.Rows.Count - 1
                DsTheriaque_AnalyseOrdonance2.IC1SAU_TERME1SUBAUX.Rows(iCount).Delete()
            Next
            Me.IC1SAU_TA.Update(DsTheriaque_AnalyseOrdonance2)

            For iCount = 0 To DsTheriaque_AnalyseOrdonance2.IC1SAC_TERME1SUBACT.Rows.Count - 1
                DsTheriaque_AnalyseOrdonance2.IC1SAC_TERME1SUBACT.Rows(iCount).Delete()
            Next
            Me.IC1SAC_TA.Update(DsTheriaque_AnalyseOrdonance2)

            For iCount = 0 To DsTheriaque_AnalyseOrdonance2.IC1PR_TERME1PRODUIT.Rows.Count - 1
                DsTheriaque_AnalyseOrdonance2.IC1PR_TERME1PRODUIT.Rows(iCount).Delete()
            Next
            Me.IC1PR_TA.Update(DsTheriaque_AnalyseOrdonance2)

            For iCount = 0 To DsTheriaque_AnalyseOrdonance2.IC1SP_TERME1SPECIALITE.Rows.Count - 1
                DsTheriaque_AnalyseOrdonance2.IC1SP_TERME1SPECIALITE.Rows(iCount).Delete()
            Next
            Me.IC1SP_TA.Update(DsTheriaque_AnalyseOrdonance2)

            'Onglet Terme2
            For iCount = 0 To DsTheriaque_AnalyseOrdonance2.IC2SAU_TERME2SUBAUX.Rows.Count - 1
                DsTheriaque_AnalyseOrdonance2.IC2SAU_TERME2SUBAUX.Rows(iCount).Delete()
            Next
            Me.IC2SAU_TA.Update(DsTheriaque_AnalyseOrdonance2)

            For iCount = 0 To DsTheriaque_AnalyseOrdonance2.IC2SAC_TERME2SUBACT.Rows.Count - 1
                DsTheriaque_AnalyseOrdonance2.IC2SAC_TERME2SUBACT.Rows(iCount).Delete()
            Next
            Me.IC2SAC_TA.Update(DsTheriaque_AnalyseOrdonance2)

            For iCount = 0 To DsTheriaque_AnalyseOrdonance2.IC2PR_TERME2PRODUIT.Rows.Count - 1
                DsTheriaque_AnalyseOrdonance2.IC2PR_TERME2PRODUIT.Rows(iCount).Delete()
            Next
            Me.IC2PR_TA.Update(DsTheriaque_AnalyseOrdonance2)

            For iCount = 0 To DsTheriaque_AnalyseOrdonance2.IC2SP_TERME2SPECIALITE.Rows.Count - 1
                DsTheriaque_AnalyseOrdonance2.IC2SP_TERME2SPECIALITE.Rows(iCount).Delete()
            Next
            Me.IC2SP_TA.Update(DsTheriaque_AnalyseOrdonance2)

            'Onglet Solution1/2
            For iCount = 0 To DsTheriaque_AnalyseOrdonance2.ICSOL_INCOMPATIBILITE_SOLUTION.Rows.Count - 1
                DsTheriaque_AnalyseOrdonance2.ICSOL_INCOMPATIBILITE_SOLUTION.Rows(iCount).Delete()
            Next
            Me.IcsoL_TA.Update(DsTheriaque_AnalyseOrdonance2)

            For iCount = 0 To DsTheriaque_AnalyseOrdonance2.ICCT1_CONCENTRATION1.Rows.Count - 1
                DsTheriaque_AnalyseOrdonance2.ICCT1_CONCENTRATION1.Rows(iCount).Delete()
            Next
            Me.IccT1_TA.Update(DsTheriaque_AnalyseOrdonance2)

            For iCount = 0 To DsTheriaque_AnalyseOrdonance2.IC1VE_INCOMPATIBILITE_VECTEUR1.Rows.Count - 1
                DsTheriaque_AnalyseOrdonance2.IC1VE_INCOMPATIBILITE_VECTEUR1.Rows(iCount).Delete()
            Next
            Me.IC1VE_TA.Update(DsTheriaque_AnalyseOrdonance2)

            For iCount = 0 To DsTheriaque_AnalyseOrdonance2.ICCT2_CONCENTRATION2.Rows.Count - 1
                DsTheriaque_AnalyseOrdonance2.ICCT2_CONCENTRATION2.Rows(iCount).Delete()
            Next
            Me.IccT2_TA.Update(DsTheriaque_AnalyseOrdonance2)

            For iCount = 0 To DsTheriaque_AnalyseOrdonance2.IC2VE_INCOMPATIBILITE_VECTEUR2.Rows.Count - 1
                DsTheriaque_AnalyseOrdonance2.IC2VE_INCOMPATIBILITE_VECTEUR2.Rows(iCount).Delete()
            Next
            Me.IC2VE_TA.Update(DsTheriaque_AnalyseOrdonance2)

            For iCount = 0 To DsTheriaque_AnalyseOrdonance2.ICCO_INCOMPATIBILITE_CONTENANT.Rows.Count - 1
                DsTheriaque_AnalyseOrdonance2.ICCO_INCOMPATIBILITE_CONTENANT.Rows(iCount).Delete()
            Next
            Me.IccO_TA.Update(DsTheriaque_AnalyseOrdonance2)

            For iCount = 0 To DsTheriaque_AnalyseOrdonance2.ICMA_INCOMPATIBILITE_MATERIAU.Rows.Count - 1
                DsTheriaque_AnalyseOrdonance2.ICMA_INCOMPATIBILITE_MATERIAU.Rows(iCount).Delete()
            Next
            Me.IcmA_TA.Update(DsTheriaque_AnalyseOrdonance2)

            'Onglet Solution2/2
            For iCount = 0 To DsTheriaque_AnalyseOrdonance2.ICNA_INCOMPATIBILITE_NATURE.Rows.Count - 1
                DsTheriaque_AnalyseOrdonance2.ICNA_INCOMPATIBILITE_NATURE.Rows(iCount).Delete()
            Next
            Me.IcnA_TA.Update(DsTheriaque_AnalyseOrdonance2)

            For iCount = 0 To DsTheriaque_AnalyseOrdonance2.ICDUR_INCOMPATIBILITE_DUREE.Rows.Count - 1
                DsTheriaque_AnalyseOrdonance2.ICDUR_INCOMPATIBILITE_DUREE.Rows(iCount).Delete()
            Next
            Me.IcduR_TA.Update(DsTheriaque_AnalyseOrdonance2)

            For iCount = 0 To DsTheriaque_AnalyseOrdonance2.ICLUM_INCOMPATIBILITE_LUMIERE.Rows.Count - 1
                DsTheriaque_AnalyseOrdonance2.ICLUM_INCOMPATIBILITE_LUMIERE.Rows(iCount).Delete()
            Next
            Me.IcluM_TA.Update(DsTheriaque_AnalyseOrdonance2)

            For iCount = 0 To DsTheriaque_AnalyseOrdonance2.ICTMP_INCOMPA_TEMPERATURE.Rows.Count - 1
                DsTheriaque_AnalyseOrdonance2.ICTMP_INCOMPA_TEMPERATURE.Rows(iCount).Delete()
            Next
            Me.IctmP_TA.Update(DsTheriaque_AnalyseOrdonance2)

            ' Master
            DsTheriaque_AnalyseOrdonance2.FIC_INCOMPATIBILITE.Rows(0).Delete()
            Me.FiC_TA.Update(Me.MasterDataSet)

            bModeDuplication = False
            Return True
        Else
            Process_Message(strChargementOnglet, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Function

    Public Overrides Sub valider()
        MyBase.Valider()

        If (cmbOrigine.SelectedItem.Equals("Trissel")) Then
            Me.BindingContext(Me.MasterDataSet, MasterTable).Current("FIC_ORIGINE") = "D"
        End If
        If (cmbOrigine.SelectedItem.Equals("Extrapolation Trissel")) Then
            Me.BindingContext(Me.MasterDataSet, MasterTable).Current("FIC_ORIGINE") = "E"
        End If
        If (cmbOrigine.SelectedItem.Equals("RCP")) Then
            Me.BindingContext(Me.MasterDataSet, MasterTable).Current("FIC_ORIGINE") = "R"
        End If
        If (cmbOrigine.SelectedItem.Equals("Extrapolation RCP")) Then
            Me.BindingContext(Me.MasterDataSet, MasterTable).Current("FIC_ORIGINE") = "X"
        End If
        If (cmbOrigine.SelectedItem.Equals("Autre source")) Then
            Me.BindingContext(Me.MasterDataSet, MasterTable).Current("FIC_ORIGINE") = "A"
        End If

        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        FiC_TA.Update(Me.DsTheriaque_AnalyseOrdonance2.FIC_INCOMPATIBILITE)
        'Onglet Terme1
        Me.BindingContext(Me.MasterDataSet, IC1SAC_TERME1SUBACT).EndCurrentEdit()
        IC1SAC_TA.Update(Me.DsTheriaque_AnalyseOrdonance2.IC1SAC_TERME1SUBACT)

        Me.BindingContext(Me.MasterDataSet, IC1SAU_TERME1SUBAUX).EndCurrentEdit()
        IC1SAU_TA.Update(Me.DsTheriaque_AnalyseOrdonance2.IC1SAU_TERME1SUBAUX)

        Me.BindingContext(Me.MasterDataSet, IC1PR_TERME1PRODUIT).EndCurrentEdit()
        IC1PR_TA.Update(Me.DsTheriaque_AnalyseOrdonance2.IC1PR_TERME1PRODUIT)

        Me.BindingContext(Me.MasterDataSet, IC1SP_TERME1SPECIALITE).EndCurrentEdit()
        IC1SP_TA.Update(Me.DsTheriaque_AnalyseOrdonance2.IC1SP_TERME1SPECIALITE)

        'Onglet Terme2
        Me.BindingContext(Me.MasterDataSet, IC2SAC_TERME2SUBACT).EndCurrentEdit()
        IC2SAC_TA.Update(Me.DsTheriaque_AnalyseOrdonance2.IC2SAC_TERME2SUBACT)

        Me.BindingContext(Me.MasterDataSet, IC2SAU_TERME2SUBAUX).EndCurrentEdit()
        IC2SAU_TA.Update(Me.DsTheriaque_AnalyseOrdonance2.IC2SAU_TERME2SUBAUX)

        Me.BindingContext(Me.MasterDataSet, IC2PR_TERME2PRODUIT).EndCurrentEdit()
        IC2PR_TA.Update(Me.DsTheriaque_AnalyseOrdonance2.IC2PR_TERME2PRODUIT)

        Me.BindingContext(Me.MasterDataSet, IC2SP_TERME2SPECIALITE).EndCurrentEdit()
        IC2SP_TA.Update(Me.DsTheriaque_AnalyseOrdonance2.IC2SP_TERME2SPECIALITE)

        'Onglet Solution1/2
        Me.BindingContext(Me.MasterDataSet, ICSOL_INCOMPATIBILITE_SOLUTION).EndCurrentEdit()
        IcsoL_TA.Update(Me.DsTheriaque_AnalyseOrdonance2.ICSOL_INCOMPATIBILITE_SOLUTION)

        Me.BindingContext(Me.MasterDataSet, ICCT1_CONCENTRATION1).EndCurrentEdit()
        IccT1_TA.Update(Me.DsTheriaque_AnalyseOrdonance2.ICCT1_CONCENTRATION1)

        Me.BindingContext(Me.MasterDataSet, IC1VE_INCOMPATIBILITE_VECTEUR1).EndCurrentEdit()
        IC1VE_TA.Update(Me.DsTheriaque_AnalyseOrdonance2.IC1VE_INCOMPATIBILITE_VECTEUR1)

        Me.BindingContext(Me.MasterDataSet, ICCT2_CONCENTRATION2).EndCurrentEdit()
        IccT2_TA.Update(Me.DsTheriaque_AnalyseOrdonance2.ICCT2_CONCENTRATION2)

        Me.BindingContext(Me.MasterDataSet, IC2VE_INCOMPATIBILITE_VECTEUR2).EndCurrentEdit()
        IC2VE_TA.Update(Me.DsTheriaque_AnalyseOrdonance2.IC2VE_INCOMPATIBILITE_VECTEUR2)

        Me.BindingContext(Me.MasterDataSet, ICCO_INCOMPATIBILITE_CONTENANT).EndCurrentEdit()
        IccO_TA.Update(Me.DsTheriaque_AnalyseOrdonance2.ICCO_INCOMPATIBILITE_CONTENANT)

        Me.BindingContext(Me.MasterDataSet, ICMA_INCOMPATIBILITE_MATERIAU).EndCurrentEdit()
        IcmA_TA.Update(Me.DsTheriaque_AnalyseOrdonance2.ICMA_INCOMPATIBILITE_MATERIAU)

        'Onglet Solution2/2
        Me.BindingContext(Me.MasterDataSet, ICNA_INCOMPATIBILITE_NATURE).EndCurrentEdit()
        IcnA_TA.Update(Me.DsTheriaque_AnalyseOrdonance2.ICNA_INCOMPATIBILITE_NATURE)

        Me.BindingContext(Me.MasterDataSet, ICDUR_INCOMPATIBILITE_DUREE).EndCurrentEdit()
        IcduR_TA.Update(Me.DsTheriaque_AnalyseOrdonance2.ICDUR_INCOMPATIBILITE_DUREE)

        Me.BindingContext(Me.MasterDataSet, ICLUM_INCOMPATIBILITE_LUMIERE).EndCurrentEdit()
        IcluM_TA.Update(Me.DsTheriaque_AnalyseOrdonance2.ICLUM_INCOMPATIBILITE_LUMIERE)

        Me.BindingContext(Me.MasterDataSet, ICTMP_INCOMPA_TEMPERATURE).EndCurrentEdit()
        IctmP_TA.Update(Me.DsTheriaque_AnalyseOrdonance2.ICTMP_INCOMPA_TEMPERATURE)

        Me.BindingContext(Me.MasterDataSet, ICTMP_INCOMPA_TEMPERATURE).EndCurrentEdit()
        IctmP_TA.Update(Me.DsTheriaque_AnalyseOrdonance2.ICTMP_INCOMPA_TEMPERATURE)

        bModeDuplication = False
    End Sub

    Public Overrides Sub annuler()
        OnLoading = True
        MyBase.Annuler()
        'Onglet Terme 1
        Me.BindingContext(DsTheriaque_AnalyseOrdonance2, IC1SAC_TERME1SUBACT).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance2.IC1SAC_TERME1SUBACT.RejectChanges()

        Me.BindingContext(DsTheriaque_AnalyseOrdonance2, IC1SAU_TERME1SUBAUX).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance2.IC1SAU_TERME1SUBAUX.RejectChanges()

        Me.BindingContext(DsTheriaque_AnalyseOrdonance2, IC1PR_TERME1PRODUIT).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance2.IC1PR_TERME1PRODUIT.RejectChanges()

        Me.BindingContext(DsTheriaque_AnalyseOrdonance2, IC1SP_TERME1SPECIALITE).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance2.IC1SP_TERME1SPECIALITE.RejectChanges()

        'Onglet Terme 2
        Me.BindingContext(DsTheriaque_AnalyseOrdonance2, IC2SAC_TERME2SUBACT).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance2.IC2SAC_TERME2SUBACT.RejectChanges()

        Me.BindingContext(DsTheriaque_AnalyseOrdonance2, IC2SAU_TERME2SUBAUX).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance2.IC2SAU_TERME2SUBAUX.RejectChanges()

        Me.BindingContext(DsTheriaque_AnalyseOrdonance2, IC2PR_TERME2PRODUIT).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance2.IC2PR_TERME2PRODUIT.RejectChanges()

        Me.BindingContext(DsTheriaque_AnalyseOrdonance2, IC2SP_TERME2SPECIALITE).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance2.IC2SP_TERME2SPECIALITE.RejectChanges()

        'Onglet Solution1/2
        Me.BindingContext(DsTheriaque_AnalyseOrdonance2, ICSOL_INCOMPATIBILITE_SOLUTION).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance2.ICSOL_INCOMPATIBILITE_SOLUTION.RejectChanges()

        Me.BindingContext(DsTheriaque_AnalyseOrdonance2, ICCT1_CONCENTRATION1).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance2.ICCT1_CONCENTRATION1.RejectChanges()

        Me.BindingContext(DsTheriaque_AnalyseOrdonance2, IC1VE_INCOMPATIBILITE_VECTEUR1).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance2.IC1VE_INCOMPATIBILITE_VECTEUR1.RejectChanges()

        Me.BindingContext(DsTheriaque_AnalyseOrdonance2, ICCT2_CONCENTRATION2).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance2.ICCT2_CONCENTRATION2.RejectChanges()

        Me.BindingContext(DsTheriaque_AnalyseOrdonance2, IC2VE_INCOMPATIBILITE_VECTEUR2).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance2.IC2VE_INCOMPATIBILITE_VECTEUR2.RejectChanges()

        Me.BindingContext(DsTheriaque_AnalyseOrdonance2, ICCO_INCOMPATIBILITE_CONTENANT).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance2.ICCO_INCOMPATIBILITE_CONTENANT.RejectChanges()

        Me.BindingContext(DsTheriaque_AnalyseOrdonance2, ICMA_INCOMPATIBILITE_MATERIAU).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance2.ICMA_INCOMPATIBILITE_MATERIAU.RejectChanges()

        'Onglet Solution2/2
        Me.BindingContext(DsTheriaque_AnalyseOrdonance2, ICNA_INCOMPATIBILITE_NATURE).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance2.ICNA_INCOMPATIBILITE_NATURE.RejectChanges()

        Me.BindingContext(DsTheriaque_AnalyseOrdonance2, ICDUR_INCOMPATIBILITE_DUREE).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance2.ICDUR_INCOMPATIBILITE_DUREE.RejectChanges()

        Me.BindingContext(DsTheriaque_AnalyseOrdonance2, ICLUM_INCOMPATIBILITE_LUMIERE).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance2.ICLUM_INCOMPATIBILITE_LUMIERE.RejectChanges()

        Me.BindingContext(DsTheriaque_AnalyseOrdonance2, ICTMP_INCOMPA_TEMPERATURE).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance2.ICTMP_INCOMPA_TEMPERATURE.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_AnalyseOrdonance2.FIC_INCOMPATIBILITE.RejectChanges()

        If bModeDuplication Then EmptyDataTable()
        bModeDuplication = False
        OnLoading = False
    End Sub

    Private Sub EmptyDataTable()
        Me.DsTheriaque_AnalyseOrdonance2.FIC_INCOMPATIBILITE.Clear()
        'Onglet Terme1
        Me.DsTheriaque_AnalyseOrdonance2.IC1SAC_TERME1SUBACT.Clear()
        Me.DsTheriaque_AnalyseOrdonance2.IC1SAU_TERME1SUBAUX.Clear()
        Me.DsTheriaque_AnalyseOrdonance2.IC1PR_TERME1PRODUIT.Clear()
        Me.DsTheriaque_AnalyseOrdonance2.IC1SP_TERME1SPECIALITE.Clear()

        'Onglet Terme2
        Me.DsTheriaque_AnalyseOrdonance2.IC2SAC_TERME2SUBACT.Clear()
        Me.DsTheriaque_AnalyseOrdonance2.IC2SAU_TERME2SUBAUX.Clear()
        Me.DsTheriaque_AnalyseOrdonance2.IC2PR_TERME2PRODUIT.Clear()
        Me.DsTheriaque_AnalyseOrdonance2.IC2SP_TERME2SPECIALITE.Clear()

        'Onglet Solution1/2
        Me.DsTheriaque_AnalyseOrdonance2.ICSOL_INCOMPATIBILITE_SOLUTION.Clear()
        Me.DsTheriaque_AnalyseOrdonance2.ICCT1_CONCENTRATION1.Clear()
        Me.DsTheriaque_AnalyseOrdonance2.IC1VE_INCOMPATIBILITE_VECTEUR1.Clear()
        Me.DsTheriaque_AnalyseOrdonance2.ICCT2_CONCENTRATION2.Clear()
        Me.DsTheriaque_AnalyseOrdonance2.IC2VE_INCOMPATIBILITE_VECTEUR2.Clear()
        Me.DsTheriaque_AnalyseOrdonance2.ICCO_INCOMPATIBILITE_CONTENANT.Clear()
        Me.DsTheriaque_AnalyseOrdonance2.ICMA_INCOMPATIBILITE_MATERIAU.Clear()

        'Onglet Solution2/2
        Me.DsTheriaque_AnalyseOrdonance2.ICNA_INCOMPATIBILITE_NATURE.Clear()
        Me.DsTheriaque_AnalyseOrdonance2.ICLUM_INCOMPATIBILITE_LUMIERE.Clear()
        Me.DsTheriaque_AnalyseOrdonance2.ICDUR_INCOMPATIBILITE_DUREE.Clear()
        Me.DsTheriaque_AnalyseOrdonance2.ICTMP_INCOMPA_TEMPERATURE.Clear()
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

        'Onglet1
        Dim sDecExtrapole As String = Me.BindingContext(DsTheriaque_AnalyseOrdonance2, FIC_INCOMPATIBILITE).Current("FIC_ORIGINE").ToString
        Dim sCompIncomp As String = Me.BindingContext(DsTheriaque_AnalyseOrdonance2, FIC_INCOMPATIBILITE).Current("FIC_TYPE").ToString

        Dim dt11 As New DataTable
        dt11 = DsTheriaque_AnalyseOrdonance2.IC1SAC_TERME1SUBACT.Copy

        Dim dt12 As New DataTable
        dt12 = DsTheriaque_AnalyseOrdonance2.IC1SAU_TERME1SUBAUX.Copy

        Dim dt13 As New DataTable
        dt13 = DsTheriaque_AnalyseOrdonance2.IC1PR_TERME1PRODUIT.Copy

        Dim dt14 As New DataTable
        dt14 = DsTheriaque_AnalyseOrdonance2.IC1SP_TERME1SPECIALITE.Copy


        'Onglet2
        Dim dt21 As New DataTable
        dt21 = DsTheriaque_AnalyseOrdonance2.IC2SAC_TERME2SUBACT.Copy

        Dim dt22 As New DataTable
        dt22 = DsTheriaque_AnalyseOrdonance2.IC2SAU_TERME2SUBAUX.Copy

        Dim dt23 As New DataTable
        dt23 = DsTheriaque_AnalyseOrdonance2.IC2PR_TERME2PRODUIT.Copy

        Dim dt24 As New DataTable
        dt24 = DsTheriaque_AnalyseOrdonance2.IC2SP_TERME2SPECIALITE.Copy

        'Onglet3
        Dim dt31 As New DataTable
        dt31 = DsTheriaque_AnalyseOrdonance2.ICSOL_INCOMPATIBILITE_SOLUTION.Copy

        Dim dt32 As New DataTable
        dt32 = DsTheriaque_AnalyseOrdonance2.ICCT1_CONCENTRATION1.Copy

        Dim dt33 As New DataTable
        dt33 = DsTheriaque_AnalyseOrdonance2.IC1VE_INCOMPATIBILITE_VECTEUR1.Copy

        Dim dt34 As New DataTable
        dt34 = DsTheriaque_AnalyseOrdonance2.ICCT2_CONCENTRATION2.Copy

        Dim dt35 As New DataTable
        dt35 = DsTheriaque_AnalyseOrdonance2.IC2VE_INCOMPATIBILITE_VECTEUR2.Copy

        Dim dt36 As New DataTable
        dt36 = DsTheriaque_AnalyseOrdonance2.ICMA_INCOMPATIBILITE_MATERIAU.Copy

        Dim dt37 As New DataTable
        dt37 = DsTheriaque_AnalyseOrdonance2.ICCO_INCOMPATIBILITE_CONTENANT.Copy

        'Onglet4
        Dim dt41 As New DataTable
        dt41 = DsTheriaque_AnalyseOrdonance2.ICNA_INCOMPATIBILITE_NATURE.Copy

        Dim dt42 As New DataTable
        dt42 = DsTheriaque_AnalyseOrdonance2.ICDUR_INCOMPATIBILITE_DUREE.Copy

        Dim dt43 As New DataTable
        dt43 = DsTheriaque_AnalyseOrdonance2.ICTMP_INCOMPA_TEMPERATURE.Copy

        Dim dt44 As New DataTable
        dt44 = DsTheriaque_AnalyseOrdonance2.ICLUM_INCOMPATIBILITE_LUMIERE.Copy

        Dim sText As String = MemoEdit1.Text

        'Vider les contrôles
        EmptyDataTable()

        'Construction de la nouvelle fiche avec les données de la fiche de base
        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        SetCode_MAx(MasterTable, txtCode)
        CodE = InvalideControl

        Dim drTemp As DataRow
        For iCount As Integer = 0 To dt11.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance2.Tables("IC1SAC_TERME1SUBACT").NewRow()
            drTemp.ItemArray = dt11.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance2.Tables("IC1SAC_TERME1SUBACT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt12.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance2.Tables("IC1SAU_TERME1SUBAUX").NewRow()
            drTemp.ItemArray = dt12.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance2.Tables("IC1SAU_TERME1SUBAUX").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt13.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance2.Tables("IC1PR_TERME1PRODUIT").NewRow()
            drTemp.ItemArray = dt13.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance2.Tables("IC1PR_TERME1PRODUIT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt14.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance2.Tables("IC1SP_TERME1SPECIALITE").NewRow()
            drTemp.ItemArray = dt14.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance2.Tables("IC1SP_TERME1SPECIALITE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt21.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance2.Tables("IC2SAC_TERME2SUBACT").NewRow()
            drTemp.ItemArray = dt21.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance2.Tables("IC2SAC_TERME2SUBACT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt22.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance2.Tables("IC2SAU_TERME2SUBAUX").NewRow()
            drTemp.ItemArray = dt22.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance2.Tables("IC2SAU_TERME2SUBAUX").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt23.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance2.Tables("IC2PR_TERME2PRODUIT").NewRow()
            drTemp.ItemArray = dt23.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance2.Tables("IC2PR_TERME2PRODUIT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt24.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance2.Tables("IC2SP_TERME2SPECIALITE").NewRow()
            drTemp.ItemArray = dt24.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance2.Tables("IC2SP_TERME2SPECIALITE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt31.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance2.Tables("ICSOL_INCOMPATIBILITE_SOLUTION").NewRow()
            drTemp.ItemArray = dt31.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance2.Tables("ICSOL_INCOMPATIBILITE_SOLUTION").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt32.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance2.Tables("ICCT1_CONCENTRATION1").NewRow()
            drTemp.ItemArray = dt32.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance2.Tables("ICCT1_CONCENTRATION1").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt33.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance2.Tables("IC1VE_INCOMPATIBILITE_VECTEUR1").NewRow()
            drTemp.ItemArray = dt33.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance2.Tables("IC1VE_INCOMPATIBILITE_VECTEUR1").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt34.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance2.Tables("ICCT2_CONCENTRATION2").NewRow()
            drTemp.ItemArray = dt34.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance2.Tables("ICCT2_CONCENTRATION2").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt35.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance2.Tables("IC2VE_INCOMPATIBILITE_VECTEUR2").NewRow()
            drTemp.ItemArray = dt35.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance2.Tables("IC2VE_INCOMPATIBILITE_VECTEUR2").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt36.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance2.Tables("ICMA_INCOMPATIBILITE_MATERIAU").NewRow()
            drTemp.ItemArray = dt36.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance2.Tables("ICMA_INCOMPATIBILITE_MATERIAU").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt37.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance2.Tables("ICCO_INCOMPATIBILITE_CONTENANT").NewRow()
            drTemp.ItemArray = dt37.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance2.Tables("ICCO_INCOMPATIBILITE_CONTENANT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt41.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance2.Tables("ICNA_INCOMPATIBILITE_NATURE").NewRow()
            drTemp.ItemArray = dt41.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance2.Tables("ICNA_INCOMPATIBILITE_NATURE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt42.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance2.Tables("ICDUR_INCOMPATIBILITE_DUREE").NewRow()
            drTemp.ItemArray = dt42.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance2.Tables("ICDUR_INCOMPATIBILITE_DUREE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt43.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance2.Tables("ICTMP_INCOMPA_TEMPERATURE").NewRow()
            drTemp.ItemArray = dt43.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance2.Tables("ICTMP_INCOMPA_TEMPERATURE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt44.Rows.Count - 1
            drTemp = DsTheriaque_AnalyseOrdonance2.Tables("ICLUM_INCOMPATIBILITE_LUMIERE").NewRow()
            drTemp.ItemArray = dt44.Rows(iCount).ItemArray
            DsTheriaque_AnalyseOrdonance2.Tables("ICLUM_INCOMPATIBILITE_LUMIERE").Rows.Add(drTemp)
        Next

        MemoEdit1.Text = sText

        If sDecExtrapole <> "" Then Me.BindingContext(DsTheriaque_AnalyseOrdonance2, FIC_INCOMPATIBILITE).Current("FIC_ORIGINE") = sDecExtrapole
        If sCompIncomp <> "" Then Me.BindingContext(DsTheriaque_AnalyseOrdonance2, FIC_INCOMPATIBILITE).Current("FIC_TYPE") = sCompIncomp

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
        'GV11
        For iCount As Integer = 0 To GV11.RowCount - 1
            GV11.SetRowCellValue(iCount, colIC1SAC_FIC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV12
        For iCount As Integer = 0 To GV12.RowCount - 1
            GV12.SetRowCellValue(iCount, colIC1SAU_FIC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV13
        For iCount As Integer = 0 To GV13.RowCount - 1
            GV13.SetRowCellValue(iCount, colIC1PR_FIC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV14
        For iCount As Integer = 0 To GV14.RowCount - 1
            GV14.SetRowCellValue(iCount, colIC1SP_FIC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV21
        For iCount As Integer = 0 To GV21.RowCount - 1
            GV21.SetRowCellValue(iCount, colIC2SAC_FIC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV22
        For iCount As Integer = 0 To GV22.RowCount - 1
            GV22.SetRowCellValue(iCount, colIC2SAU_FIC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV23
        For iCount As Integer = 0 To GV23.RowCount - 1
            GV23.SetRowCellValue(iCount, colIC2PR_FIC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV24
        For iCount As Integer = 0 To GV24.RowCount - 1
            GV24.SetRowCellValue(iCount, colIC2SP_FIC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV31
        For iCount As Integer = 0 To GV31.RowCount - 1
            GV31.SetRowCellValue(iCount, colICSOL_FIC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV32
        For iCount As Integer = 0 To GV32.RowCount - 1
            GV32.SetRowCellValue(iCount, colICCT1_FIC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV33
        For iCount As Integer = 0 To GV33.RowCount - 1
            GV33.SetRowCellValue(iCount, colIC1VE_FIC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV34
        For iCount As Integer = 0 To GV34.RowCount - 1
            GV34.SetRowCellValue(iCount, colICCT2_FIC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV35
        For iCount As Integer = 0 To GV35.RowCount - 1
            GV35.SetRowCellValue(iCount, colIC2VE_FIC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV36
        For iCount As Integer = 0 To GV36.RowCount - 1
            GV36.SetRowCellValue(iCount, colICMA_FIC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV37
        For iCount As Integer = 0 To GV37.RowCount - 1
            GV37.SetRowCellValue(iCount, colICCO_FIC_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV41
        For iCount As Integer = 0 To GV41.RowCount - 1
            GV41.SetRowCellValue(iCount, colICNA_FIC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV42
        For iCount As Integer = 0 To GV42.RowCount - 1
            GV42.SetRowCellValue(iCount, colICDUR_FIC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV43
        For iCount As Integer = 0 To GV43.RowCount - 1
            GV43.SetRowCellValue(iCount, colICTMP_FIC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV44
        For iCount As Integer = 0 To GV44.RowCount - 1
            GV44.SetRowCellValue(iCount, colICLUM_FIC_CODE_FK_PK, Me.txtCode.Text)
        Next
    End Sub

#End Region

#Region " Init Data  "

    Private Sub InitDataSource()
        'Onglet Terme1
        GC11.DataSource = DsTheriaque_AnalyseOrdonance2
        GC11.DataMember = IC1SAC_TERME1SUBACT
        GC12.DataSource = DsTheriaque_AnalyseOrdonance2
        GC12.DataMember = IC1SAU_TERME1SUBAUX
        GC13.DataSource = DsTheriaque_AnalyseOrdonance2
        GC13.DataMember = IC1PR_TERME1PRODUIT
        GC14.DataSource = DsTheriaque_AnalyseOrdonance2
        GC14.DataMember = IC1SP_TERME1SPECIALITE

        'Onglet Terme2
        GC21.DataSource = DsTheriaque_AnalyseOrdonance2
        GC21.DataMember = IC2SAC_TERME2SUBACT
        GC22.DataSource = DsTheriaque_AnalyseOrdonance2
        GC22.DataMember = IC2SAU_TERME2SUBAUX
        GC23.DataSource = DsTheriaque_AnalyseOrdonance2
        GC23.DataMember = IC2PR_TERME2PRODUIT
        GC24.DataSource = DsTheriaque_AnalyseOrdonance2
        GC24.DataMember = IC2SP_TERME2SPECIALITE

        'Onglet Solution1/2
        GC31.DataSource = DsTheriaque_AnalyseOrdonance2
        GC31.DataMember = ICSOL_INCOMPATIBILITE_SOLUTION
        GC32.DataSource = DsTheriaque_AnalyseOrdonance2
        GC32.DataMember = ICCT1_CONCENTRATION1
        GC33.DataSource = DsTheriaque_AnalyseOrdonance2
        GC33.DataMember = IC1VE_INCOMPATIBILITE_VECTEUR1
        GC34.DataSource = DsTheriaque_AnalyseOrdonance2
        GC34.DataMember = ICCT2_CONCENTRATION2
        GC35.DataSource = DsTheriaque_AnalyseOrdonance2
        GC35.DataMember = IC2VE_INCOMPATIBILITE_VECTEUR2
        GC36.DataSource = DsTheriaque_AnalyseOrdonance2
        GC36.DataMember = ICMA_INCOMPATIBILITE_MATERIAU
        GC37.DataSource = DsTheriaque_AnalyseOrdonance2
        GC37.DataMember = ICCO_INCOMPATIBILITE_CONTENANT

        'Onglet Solution 2/2
        GC41.DataSource = DsTheriaque_AnalyseOrdonance2
        GC41.DataMember = ICNA_INCOMPATIBILITE_NATURE
        GC42.DataSource = DsTheriaque_AnalyseOrdonance2
        GC42.DataMember = ICDUR_INCOMPATIBILITE_DUREE
        GC43.DataSource = DsTheriaque_AnalyseOrdonance2
        GC43.DataMember = ICTMP_INCOMPA_TEMPERATURE
        GC44.DataSource = DsTheriaque_AnalyseOrdonance2
        GC44.DataMember = ICLUM_INCOMPATIBILITE_LUMIERE
    End Sub

    Public Overrides Sub InitData()
        MyBase.InitData()
        Declinaison_Global = True
        OnLoading = True
        MasterDataSet = Me.DsTheriaque_AnalyseOrdonance2
        MasterTable = FIC_INCOMPATIBILITE
        CodE = InvalideControl

        Dim List1 As New System.Collections.Generic.List(Of StructGVTable)
        List1.Add(New StructGVTable("GC11", eDeclinaison.SAC, colIC1SAC_SAC_CODE_FK_PK))
        List1.Add(New StructGVTable("GC14", eDeclinaison.SP, colIC1SP_SP_CODE_FK_PK))
        Dim decSUBAC As New ClsDeclinaison(eDeclinaison.SAC, List1)
        InitLkup(Me.lkup_IC1SAC, IC1SAC_TERME1SUBACT, strSSQL_SAC_SUBACTIVE, True, , , , , , decSUBAC)

        Dim List2 As New System.Collections.Generic.List(Of StructGVTable)
        List2.Add(New StructGVTable("GC12", eDeclinaison.SAU, colIC1SAU_SAU_CODE_FK_PK))
        List2.Add(New StructGVTable("GC14", eDeclinaison.SP, colIC1SP_SP_CODE_FK_PK))
        Dim DecSAU As New ClsDeclinaison(eDeclinaison.SAU, List2)
        InitLkup(Me.lkup_IC1SAU, IC1SAU_TERME1SUBAUX, strSSQL_SAU_SUBAUXILIAIRE, True, , , , , , DecSAU)

        Dim List3 As New System.Collections.Generic.List(Of StructGVTable)
        List3.Add(New StructGVTable("GC13", eDeclinaison.PR, colIC1PR_PR_CODE_FK_PK))
        List3.Add(New StructGVTable("GC14", eDeclinaison.SP, colIC1SP_SP_CODE_FK_PK))
        Dim DecPR As New ClsDeclinaison(eDeclinaison.PR, List3)
        InitLkup(Me.lkup_IC1PR, IC1PR_TERME1PRODUIT, strSSQL_PR_PRODUIT, True, , , , , , DecPR)


        InitLkup(Me.lkup_IC1SP, IC1SP_TERME1SPECIALITE, strSSQL_SP_SPECIALITE, True)
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

#End Region

#Region " Chargement par onglet "
    Private Sub LoadTab_1()
        Load_On(Me)
        OnLoading = True
        If Not Tab_lkup1 Then

            Dim List1 As New System.Collections.Generic.List(Of StructGVTable)
            List1.Add(New StructGVTable("GC21", eDeclinaison.SAC, colIC2SAC_SAC_CODE_FK_PK))
            List1.Add(New StructGVTable("GC24", eDeclinaison.SP, colIC2SP_SP_CODE_FK_PK))
            Dim decSUBAC As New ClsDeclinaison(eDeclinaison.SAC, List1)
            InitLkup(Me.lkup_IC2SAC, IC2SAC_TERME2SUBACT, strSSQL_SAC_SUBACTIVE, True, , , , , , decSUBAC)

            Dim List2 As New System.Collections.Generic.List(Of StructGVTable)
            List2.Add(New StructGVTable("GC22", eDeclinaison.SAU, colIC2SAU_SAU_CODE_FK_PK))
            List2.Add(New StructGVTable("GC24", eDeclinaison.SP, colIC2SP_SP_CODE_FK_PK))
            Dim DecSAU As New ClsDeclinaison(eDeclinaison.SAU, List2)
            InitLkup(Me.lkup_IC2SAU, IC2SAU_TERME2SUBAUX, strSSQL_SAU_SUBAUXILIAIRE, True, , , , , , DecSAU)

            Dim List3 As New System.Collections.Generic.List(Of StructGVTable)
            List3.Add(New StructGVTable("GC23", eDeclinaison.PR, colIC2PR_PR_CODE_FK_PK))
            List3.Add(New StructGVTable("GC24", eDeclinaison.SP, colIC2SP_SP_CODE_FK_PK))
            Dim DecPR As New ClsDeclinaison(eDeclinaison.PR, List3)
            InitLkup(Me.lkup_IC2PR, IC2PR_TERME2PRODUIT, strSSQL_PR_PRODUIT, True, , , , , , DecPR)

            InitLkup(Me.lkup_IC2SP, IC2SP_TERME2SPECIALITE, strSSQL_SP_SPECIALITE, True)
            Tab_lkup1 = True
        End If

        If Not Tab_TA1 And CodE <> InvalideControl And CodE <> Nothing Then
            'Onglet Terme 2
            Me.IC2SAC_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance2.IC2SAC_TERME2SUBACT, CodE)
            Me.IC2SAU_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance2.IC2SAU_TERME2SUBAUX, CodE)
            Me.IC2PR_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance2.IC2PR_TERME2PRODUIT, CodE)
            Me.IC2SP_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance2.IC2SP_TERME2SPECIALITE, CodE)
            Tab_TA1 = True
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub

    Private Sub LoadTab_2()
        Load_On(Me)
        OnLoading = True
        If Not Tab_lkup2 Then
            InitLkup(Me.lkup_ICSOL, ICSOL_INCOMPATIBILITE_SOLUTION, strSSQL_CDF_CODIF("MS"), True)
            InitLkup(Me.lkup_ICCT1, ICCT1_CONCENTRATION1, strSSQL_CDF_CODIF("19"), True)
            InitLkup(Me.lkup_IC1VE, IC1VE_INCOMPATIBILITE_VECTEUR1, strSSQL_CDF_CODIF("MV"), True)
            InitLkup(Me.lkup_ICCT2, ICCT2_CONCENTRATION2, strSSQL_CDF_CODIF("19"), True)
            InitLkup(Me.lkup_IC2VE, IC2VE_INCOMPATIBILITE_VECTEUR2, strSSQL_CDF_CODIF("MV"), True)
            InitLkup(Me.lkup_ICMA, ICMA_INCOMPATIBILITE_MATERIAU, strSSQL_CDF_CODIF("09"), True)
            InitLkup(Me.lkup_ICCO, ICCO_INCOMPATIBILITE_CONTENANT, strSSQL_CDF_CODIF("04"), True)
            Tab_lkup2 = True
        End If

        If Not Tab_TA2 And CodE <> InvalideControl And CodE <> Nothing Then
            'Onglet Solution 1/2
            Me.IcsoL_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance2.ICSOL_INCOMPATIBILITE_SOLUTION, CodE)
            Me.IccT1_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance2.ICCT1_CONCENTRATION1, CodE)
            Me.IC1VE_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance2.IC1VE_INCOMPATIBILITE_VECTEUR1, CodE)
            Me.IccT2_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance2.ICCT2_CONCENTRATION2, CodE)
            Me.IC2VE_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance2.IC2VE_INCOMPATIBILITE_VECTEUR2, CodE)
            Me.IcmA_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance2.ICMA_INCOMPATIBILITE_MATERIAU, CodE)
            Me.IccO_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance2.ICCO_INCOMPATIBILITE_CONTENANT, CodE)
            Tab_TA2 = True
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub
    Private Sub LoadTab_3()
        Load_On(Me)
        OnLoading = True
        GC41.Enabled = True
        If ComboBoxEdit2.SelectedIndex = 0 Then
            InitLkup(Me.lkup_ICNA, ICNA_INCOMPATIBILITE_NATURE, strSSQL_CDF_CODIF("MN", " and substring(CDF_CODE_PK, 1, 1) <> 'I'"), True)
        ElseIf ComboBoxEdit2.SelectedIndex = 1 Then
            InitLkup(Me.lkup_ICNA, ICNA_INCOMPATIBILITE_NATURE, strSSQL_CDF_CODIF("MN", " and substring(CDF_CODE_PK, 1, 1) IN ('I', 'X')"), True)
        Else
            GC41.Enabled = False
        End If
        If Not Tab_lkup3 Then
            InitLkup(Me.lkup_ICDUR, ICDUR_INCOMPATIBILITE_DUREE, strSSQL_CDF_CODIF("MD"), True)
            InitLkup(Me.lkup_ICTMP, ICTMP_INCOMPA_TEMPERATURE, strSSQL_CDF_CODIF("MT"), True)
            InitLkup(Me.lkup_ICLUM, ICLUM_INCOMPATIBILITE_LUMIERE, strSSQL_CDF_CODIF("ML"), True)
            Tab_lkup3 = True
        End If

        If Not Tab_TA3 And CodE <> InvalideControl And CodE <> Nothing Then
            'Onglet Solution 2/2
            Me.IcnA_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance2.ICNA_INCOMPATIBILITE_NATURE, CodE)
            Me.IcduR_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance2.ICDUR_INCOMPATIBILITE_DUREE, CodE)
            Me.IctmP_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance2.ICTMP_INCOMPA_TEMPERATURE, CodE)
            Me.IcluM_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance2.ICLUM_INCOMPATIBILITE_LUMIERE, CodE)
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

#Region " Init New Rows "

    Private Sub GV11_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV11.InitNewRow
        If OnLoading Then Exit Sub
        GV11.SetFocusedRowCellValue(colIC1SAC_FIC_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV12_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV12.InitNewRow
        If OnLoading Then Exit Sub
        GV12.SetFocusedRowCellValue(colIC1SAU_FIC_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV13_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV13.InitNewRow
        If OnLoading Then Exit Sub
        GV13.SetFocusedRowCellValue(colIC1PR_FIC_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV14_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV14.InitNewRow
        If OnLoading Then Exit Sub
        GV14.SetFocusedRowCellValue(colIC1SP_FIC_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV21_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV21.InitNewRow
        If OnLoading Then Exit Sub
        GV21.SetFocusedRowCellValue(colIC2SAC_FIC_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV22_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV22.InitNewRow
        If OnLoading Then Exit Sub
        GV22.SetFocusedRowCellValue(colIC2SAU_FIC_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV24_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV24.InitNewRow
        If OnLoading Then Exit Sub
        GV24.SetFocusedRowCellValue(colIC2SP_FIC_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV23_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV23.InitNewRow
        If OnLoading Then Exit Sub
        GV23.SetFocusedRowCellValue(colIC2PR_FIC_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV31_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV31.InitNewRow
        If OnLoading Then Exit Sub
        GV31.SetFocusedRowCellValue(colICSOL_FIC_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV32_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV32.InitNewRow
        If OnLoading Then Exit Sub
        GV32.SetFocusedRowCellValue(colICCT1_FIC_CODE_FK_PK, txtCode.Text)
        GV32.SetFocusedRowCellValue(colICCT1_NUMORD, Code_MAx(GV32, colICCT1_NUMORD))
        GV32.SetFocusedRowCellValue(colICCT1_NUMSEQ_PK, Code_MAx(GV32, colICCT1_NUMSEQ_PK))
    End Sub

    Private Sub GV33_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV33.InitNewRow
        If OnLoading Then Exit Sub
        GV33.SetFocusedRowCellValue(colIC1VE_FIC_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV34_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV34.InitNewRow
        If OnLoading Then Exit Sub
        GV34.SetFocusedRowCellValue(colICCT2_FIC_CODE_FK_PK, txtCode.Text)
        GV34.SetFocusedRowCellValue(colICCT2_NUMORD, Code_MAx(GV34, colICCT2_NUMORD))
        GV34.SetFocusedRowCellValue(colICCT2_NUMSEQ_PK, Code_MAx(GV34, colICCT2_NUMSEQ_PK))
    End Sub

    Private Sub GV35_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV35.InitNewRow
        If OnLoading Then Exit Sub
        GV35.SetFocusedRowCellValue(colIC2VE_FIC_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV36_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV36.InitNewRow
        If OnLoading Then Exit Sub
        GV36.SetFocusedRowCellValue(colICMA_FIC_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV37_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV37.InitNewRow
        If OnLoading Then Exit Sub
        GV37.SetFocusedRowCellValue(colICCO_FIC_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV41_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV41.InitNewRow
        If OnLoading Then Exit Sub
        GV41.SetFocusedRowCellValue(colICNA_FIC_CODE_FK_PK, txtCode.Text)
        GV41.SetFocusedRowCellValue(colICNA_NUMORD, Code_MAx(GV41, colICNA_NUMORD))
    End Sub

    Private Sub GV42_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV42.InitNewRow
        If OnLoading Then Exit Sub
        GV42.SetFocusedRowCellValue(colICDUR_FIC_CODE_FK_PK, txtCode.Text)
        GV42.SetFocusedRowCellValue(colICDUR_NUMORD, Code_MAx(GV42, colICDUR_NUMORD))
    End Sub

    Private Sub GV43_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV43.InitNewRow
        If OnLoading Then Exit Sub
        GV43.SetFocusedRowCellValue(colICTMP_FIC_CODE_FK_PK, txtCode.Text)
        GV43.SetFocusedRowCellValue(colICTMP_NUMORD, Code_MAx(GV43, colICTMP_NUMORD))
    End Sub

    Private Sub GV44_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV44.InitNewRow
        If OnLoading Then Exit Sub
        GV44.SetFocusedRowCellValue(colICLUM_FIC_CODE_FK_PK, txtCode.Text)
        GV44.SetFocusedRowCellValue(colICLUM_NUMORD, Code_MAx(GV44, colICLUM_NUMORD))
    End Sub

#End Region

#Region " Pannel Resize "

    Private Sub Panel2_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel2.Resize
        GC11.Width = Panel2.Width / 2
        GC12.Width = Panel2.Width / 2
    End Sub

    Private Sub Panel3_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.Resize
        GC13.Width = Panel3.Width / 2
        GC14.Width = Panel3.Width / 2
    End Sub

    Private Sub Panel4_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel4.Resize
        GC21.Width = Panel4.Width / 2
        GC22.Width = Panel4.Width / 2
    End Sub

    Private Sub Panel5_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel5.Resize
        GC23.Width = Panel5.Width / 2
        GC24.Width = Panel5.Width / 2
    End Sub

    Private Sub Panel6_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel6.Resize
        GC32.Width = Panel6.Width / 2
        GC33.Width = Panel6.Width / 2
    End Sub

    Private Sub Panel7_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel7.Resize
        GC34.Width = Panel7.Width / 2
        GC35.Width = Panel7.Width / 2
    End Sub

    Private Sub Panel9_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel9.Resize
        GC36.Width = Panel9.Width / 2
        GC37.Width = Panel9.Width / 2
    End Sub

    Private Sub Panel10_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel10.Resize
        GC41.Width = Panel10.Width / 2
        GC42.Width = Panel10.Width / 2
    End Sub

    Private Sub Panel11_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel11.Resize
        GC43.Width = Panel11.Width / 2
        GC44.Width = Panel11.Width / 2
    End Sub

    Private Sub XtraTabControl1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraTabControl1.Resize
        Panel2.Height = XtraTabControl1.Height / 2
        Panel3.Height = XtraTabControl1.Height / 2

        Panel4.Height = XtraTabControl1.Height / 2
        Panel5.Height = XtraTabControl1.Height / 2

        Panel6.Height = XtraTabControl1.Height / 4
        Panel7.Height = XtraTabControl1.Height / 4
        Panel8.Height = XtraTabControl1.Height / 4
        Panel9.Height = XtraTabControl1.Height / 4

        Panel10.Height = XtraTabControl1.Height / 3
        Panel11.Height = XtraTabControl1.Height / 3
        Panel12.Height = XtraTabControl1.Height / 3
    End Sub

#End Region

    Private Sub Open_Fiche(ByVal CodE1 As Integer)
        XtraTabControl1.SelectedTabPageIndex = 0
        OnLoading = True
        If _Code <> Nothing Then CodE = _Code
        EmptyDataTable()
        Me.FiC_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance2.FIC_INCOMPATIBILITE, CodE1)
        'Onglet Terme 1
        Me.IC1SAC_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance2.IC1SAC_TERME1SUBACT, CodE1)
        Me.IC1SAU_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance2.IC1SAU_TERME1SUBAUX, CodE1)
        Me.IC1PR_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance2.IC1PR_TERME1PRODUIT, CodE1)
        Me.IC1SP_TA.FillByCode(Me.DsTheriaque_AnalyseOrdonance2.IC1SP_TERME1SPECIALITE, CodE1)

        Tab_TA1 = False
        Tab_TA2 = False
        Tab_TA3 = False
        bModeDuplication = False
        OnLoading = False
    End Sub

    Private Sub ComboBoxEdit2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEdit2.SelectedIndexChanged
        LoadTab_3()
    End Sub

    Private Sub ComboBoxEdit1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BindOrigine()

        If (Not String.IsNullOrEmpty(cmbOrigine.SelectedItem)) Then
            'If (Me.BindingContext(Me.MasterDataSet, MasterTable).Current("FCPM_ORIGINE").Equals("R")) Then
            If (cmbOrigine.SelectedItem.Equals("D")) Then
                cmbOrigine.SelectedItem = "Trissel"
            End If
            If (cmbOrigine.SelectedItem.Equals("E")) Then
                cmbOrigine.SelectedItem = "Extrapolation Trissel"
            End If
            If (cmbOrigine.SelectedItem.Equals("R")) Then
                cmbOrigine.SelectedItem = "RCP"
            End If
            If (cmbOrigine.SelectedItem.Equals("X")) Then
                cmbOrigine.SelectedItem = "Extrapolation RCP"
            End If
            If (cmbOrigine.SelectedItem.Equals("A")) Then
                cmbOrigine.SelectedItem = "Autre source"
            End If
        End If
    End Sub

    Private Sub cmbOrigine_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOrigine.TextChanged
        BindOrigine()
    End Sub
End Class
