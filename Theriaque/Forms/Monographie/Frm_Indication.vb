''' <summary>
''' Created By [BFE]
''' </summary>
''' <remarks> Monographie - Indication
''' </remarks>
''' 

Public Class Frm_Indication

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

#Region " Edit Data  "

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_FIN_FICHEINDIC
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            XtraTabControl1.SelectedTabPageIndex = 0
            OnLoading = True
            EmptyDataTable()
            Me.FiN_TA.FillByCode(Me.DsTheriaque_Indication.FIN_FICHEINDIC, f._Code)
            'Onglet Entités
            Me.FincpH_TA.FillByCode(Me.DsTheriaque_Indication.FINCPH_INDCPH, f._Code)
            Me.FinccH_TA.FillByCode(Me.DsTheriaque_Indication.FINCCH_INDCCH, f._Code)
            Me.FinsaC_TA.FillByCode(Me.DsTheriaque_Indication.FINSAC_SUBAC, f._Code)
            Me.FinpR_TA.FillByCode(Me.DsTheriaque_Indication.FINPR_INDPROD, f._Code)
            Me.FincH_TA.FillByCode(Me.DsTheriaque_Indication.FINCH_INDCHOIX, f._Code)
            Me.FinsP_TA.FillByCode(Me.DsTheriaque_Indication.FINSP_INDSPE, f._Code)
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
    Public Overrides Function ChercherAvance() As Boolean
        MyBase.ChercherAvance()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_FIN_FICHEINDIC_SPECIALITE()
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            XtraTabControl1.SelectedTabPageIndex = 0
            OnLoading = True
            EmptyDataTable()
            Me.FiN_TA.FillByCode(Me.DsTheriaque_Indication.FIN_FICHEINDIC, f._Code)
            'Onglet Entités
            Me.FincpH_TA.FillByCode(Me.DsTheriaque_Indication.FINCPH_INDCPH, f._Code)
            Me.FinccH_TA.FillByCode(Me.DsTheriaque_Indication.FINCCH_INDCCH, f._Code)
            Me.FinsaC_TA.FillByCode(Me.DsTheriaque_Indication.FINSAC_SUBAC, f._Code)
            Me.FinpR_TA.FillByCode(Me.DsTheriaque_Indication.FINPR_INDPROD, f._Code)
            Me.FincH_TA.FillByCode(Me.DsTheriaque_Indication.FINCH_INDCHOIX, f._Code)
            Me.FinsP_TA.FillByCode(Me.DsTheriaque_Indication.FINSP_INDSPE, f._Code)
            Tab_TA1 = False
            Tab_TA2 = False
            Tab_TA3 = False
            Tab_TA4 = False
            Tab_TA5 = False
            Tab_TA6 = False
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
        Dim sCodeSP As String = ""
        Dim sCodeCOM As String = ""
        Dim sCodeCC As String = ""
        Dim sCodeNIV As String = ""
        Dim sCodeNAT As String = ""
        Dim sCodeCOMNAT As String = ""
        Dim sCodeAGETIO As String = ""
        Dim f As New Frm_IndicationMultiCriteres
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
            If f._bSP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SP_SPECIALITE
                fDICO.Text = "Spécialités"
                fDICO.ShowDialog()
                sCodeSP = fDICO._Code
            End If
            If f._bCOM Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("NC", "and substring(CDF_CODE_PK,1,1) not in ('A','B','F','P') ")
                fDICO.Text = "Commentaires"
                fDICO.ShowDialog()
                sCodeCOM = fDICO._Code
            End If
            If f._bCC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CH_CHOIX
                fDICO.Text = "Critères de choix"
                fDICO.ShowDialog()
                sCodeCC = fDICO._Code
            End If
            If f._bNIV Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("NV")
                fDICO.Text = "Niveaux d'indication"
                fDICO.ShowDialog()
                sCodeNIV = fDICO._Code
            End If
            If f._bNAT Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("NN")
                fDICO.Text = "Natures d'indication"
                fDICO.ShowDialog()
                sCodeNAT = fDICO._Code
            End If
            If f._bCOMNAT Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("NC", "and substring(CDF_CODE_PK,1,1) IN ('A','B','F','P') ")
                fDICO.Text = "Commentaires nature"
                fDICO.ShowDialog()
                sCodeCOMNAT = fDICO._Code
            End If
            If f._bAGETIO Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF_NIVEAU("NA")
                fDICO.Text = "Agent/Etiologie"
                fDICO.ShowDialog()
                sCodeAGETIO = fDICO._Code
            End If
            
            Dim fResultat As New Frm_Recherche
            Dim sSQL As String = ""
            sSQL &= " SELECT FIN_CODE_SQ_PK AS code, '' AS libelle FROM THERIAQUE.FIN_FICHEINDIC  "
            If sCodeCPH <> "" Then
                sSQL &= " WHERE FIN_CODE_SQ_PK IN (SELECT FINCPH_FIN_CODE_FK_PK FROM THERIAQUE.FINCPH_INDCPH WHERE FINCPH_CPH_CODE_FK_PK = " & cn.SQLText(sCodeCPH) & ")"
            End If
            If sCodeCCH <> "" Then
                If sCodeCPH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIN_CODE_SQ_PK IN (SELECT FINCCH_FIN_CODE_FK_PK FROM THERIAQUE.FINCCH_INDCCH WHERE FINCCH_CCH_CODE_FK_PK = " & cn.SQLText(sCodeCCH) & ")"
            End If
            If sCodeSAC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIN_CODE_SQ_PK IN (SELECT FINSAC_FIN_CODE_FK_PK FROM THERIAQUE.FINSAC_SUBAC WHERE FINSAC_SAC_CODE_FK_PK = " & cn.SQLText(sCodeSAC) & ")"
            End If
            If sCodePR <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIN_CODE_SQ_PK IN (SELECT FINPR_FIN_CODE_FK_PK FROM THERIAQUE.FINPR_INDPROD WHERE FINPR_PR_CODE_FK_PK = " & cn.SQLText(sCodePR) & ")"
            End If
            If sCodeSP <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIN_CODE_SQ_PK IN (SELECT FINSP_FIN_CODE_FK_PK FROM THERIAQUE.FINSP_INDSPE WHERE FINSP_SP_CODE_FK_PK = " & cn.SQLText(sCodeSP) & ")"
            End If
            If sCodeCOM <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Or sCodeSP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIN_CODE_SQ_PK IN (SELECT FINCO_FIN_CODE_FK_PK FROM THERIAQUE.FINCO_FINDCOMMENT WHERE FINCO_CDF_COIN_CODE_FK_PK = " & cn.SQLText(sCodeCOM) & ")"
            End If
            If sCodeCC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCOM <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIN_CODE_SQ_PK IN (SELECT FINCH_FIN_CODE_FK_PK FROM THERIAQUE.FINCH_INDCHOIX WHERE FINCH_CH_CODE_FK_PK = " & cn.SQLText(sCodeCC) & ")"
            End If
            If sCodeNIV <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCOM <> "" Or sCodeCC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIN_CODE_SQ_PK IN (SELECT FIN_CODE_SQ_PK FROM THERIAQUE.FIN_FICHEINDIC WHERE FIN_CDF_NVIN_CODE_FK_PK = " & cn.SQLText(sCodeNIV) & ")"
            End If
            If sCodeNAT <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCOM <> "" Or sCodeCC <> "" Or sCodeNIV <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIN_CODE_SQ_PK IN (SELECT FIN_CODE_SQ_PK FROM THERIAQUE.FIN_FICHEINDIC WHERE FIN_CDF_NAIN_CODE_FK_PK = " & cn.SQLText(sCodeNAT) & ")"
            End If
            If sCodeCOMNAT <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCOM <> "" Or sCodeCC <> "" Or sCodeNIV <> "" Or sCodeNAT <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIN_CODE_SQ_PK IN (SELECT FINCON_FIN_CODE_FK_PK FROM THERIAQUE.FINCON_FINDCOMMENT_NATURE WHERE FINCON_CDF_COIN_CODE_FK_PK = " & cn.SQLText(sCodeCOMNAT) & ")"
            End If
            If sCodeAGETIO <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCOM <> "" Or sCodeCC <> "" Or sCodeNIV <> "" Or sCodeNAT <> "" Or sCodeCOMNAT <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIN_CODE_SQ_PK IN (SELECT FINET_FIN_CODE_FK_PK FROM THERIAQUE.FINET_FINDETIOL WHERE FINET_CDF_ETIN_CODE_FK_PK = " & cn.SQLText(sCodeAGETIO) & ")"
            End If
            sSQL &= " ORDER BY FIN_CODE_SQ_PK"

            fResultat._SSQL = sSQL
            fResultat.Text = Me.Text
            fResultat.ShowDialog()
            CodE = fResultat._Code
            If fResultat._Code IsNot Nothing Then
                XtraTabControl1.SelectedTabPageIndex = 0
                OnLoading = True
                EmptyDataTable()
                Me.FiN_TA.FillByCode(Me.DsTheriaque_Indication.FIN_FICHEINDIC, fResultat._Code)
                'Onglet Entités
                Me.FincpH_TA.FillByCode(Me.DsTheriaque_Indication.FINCPH_INDCPH, fResultat._Code)
                Me.FinccH_TA.FillByCode(Me.DsTheriaque_Indication.FINCCH_INDCCH, fResultat._Code)
                Me.FinsaC_TA.FillByCode(Me.DsTheriaque_Indication.FINSAC_SUBAC, fResultat._Code)
                Me.FinpR_TA.FillByCode(Me.DsTheriaque_Indication.FINPR_INDPROD, fResultat._Code)
                Me.FincH_TA.FillByCode(Me.DsTheriaque_Indication.FINCH_INDCHOIX, fResultat._Code)
                Me.FinsP_TA.FillByCode(Me.DsTheriaque_Indication.FINSP_INDSPE, fResultat._Code)
                Tab_TA1 = False
                Tab_TA2 = False
                Tab_TA3 = False
                Tab_TA4 = False
                Tab_TA5 = False
                Tab_TA6 = False
                OnLoading = False
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
        XtraTabControl1.SelectedTabPageIndex = 0
    End Sub
    Public Overrides Function supprimer() As Boolean
        If NAIN_USED() Then
            Process_Message(strIndic_Existe, MsgBoxStyle.OkOnly, MsgBoxStyle.Exclamation)
            Exit Function
        End If
        MyBase.Supprimer()
        Dim iCount As Integer
        If Tab_TA1 Then
            'Onglet Entités
            For iCount = 0 To DsTheriaque_Indication.FINAFS_FIN_AFSSAPS.Rows.Count - 1
                DsTheriaque_Indication.FINAFS_FIN_AFSSAPS.Rows(iCount).Delete()
            Next
            Me.FinafS_TA.Update(DsTheriaque_Indication)

            For iCount = 0 To DsTheriaque_Indication.FINBIB_REFERENCE_BIBLIO.Rows.Count - 1
                DsTheriaque_Indication.FINBIB_REFERENCE_BIBLIO.Rows(iCount).Delete()
            Next
            Me.FinbiB_TA.Update(DsTheriaque_Indication)

            For iCount = 0 To DsTheriaque_Indication.FINCO_FINDCOMMENT.Rows.Count - 1
                DsTheriaque_Indication.FINCO_FINDCOMMENT.Rows(iCount).Delete()
            Next
            Me.FincO_TA.Update(DsTheriaque_Indication)

            For iCount = 0 To DsTheriaque_Indication.FINET_FINDETIOL.Rows.Count - 1
                DsTheriaque_Indication.FINET_FINDETIOL.Rows(iCount).Delete()
            Next
            Me.FineT_TA.Update(DsTheriaque_Indication)

            For iCount = 0 To DsTheriaque_Indication.FINSMR_INDIC_SMR_ATR.Rows.Count - 1
                DsTheriaque_Indication.FINSMR_INDIC_SMR_ATR.Rows(iCount).Delete()
            Next
            Me.FinsmR_TA.Update(DsTheriaque_Indication)

            For iCount = 0 To DsTheriaque_Indication.FINCPH_INDCPH.Rows.Count - 1
                DsTheriaque_Indication.FINCPH_INDCPH.Rows(iCount).Delete()
            Next
            Me.FincpH_TA.Update(DsTheriaque_Indication)

            For iCount = 0 To DsTheriaque_Indication.FINCCH_INDCCH.Rows.Count - 1
                DsTheriaque_Indication.FINCCH_INDCCH.Rows(iCount).Delete()
            Next
            Me.FinccH_TA.Update(DsTheriaque_Indication)

            For iCount = 0 To DsTheriaque_Indication.FINSAC_SUBAC.Rows.Count - 1
                DsTheriaque_Indication.FINSAC_SUBAC.Rows(iCount).Delete()
            Next
            Me.FinsaC_TA.Update(DsTheriaque_Indication)

            For iCount = 0 To DsTheriaque_Indication.FINCH_INDCHOIX.Rows.Count - 1
                DsTheriaque_Indication.FINCH_INDCHOIX.Rows(iCount).Delete()
            Next
            Me.FincH_TA.Update(DsTheriaque_Indication)

            For iCount = 0 To DsTheriaque_Indication.FINPR_INDPROD.Rows.Count - 1
                DsTheriaque_Indication.FINPR_INDPROD.Rows(iCount).Delete()
            Next
            Me.FinpR_TA.Update(DsTheriaque_Indication)

            For iCount = 0 To DsTheriaque_Indication.FINSP_INDSPE.Rows.Count - 1
                DsTheriaque_Indication.FINSP_INDSPE.Rows(iCount).Delete()
            Next
            Me.FinsP_TA.Update(DsTheriaque_Indication)
            'Onglet 2
            For iCount = 0 To DsTheriaque_Indication.FINTY_FINDTYPE.Rows.Count - 1
                DsTheriaque_Indication.FINTY_FINDTYPE.Rows(iCount).Delete()
            Next
            Me.FintY_TA.Update(DsTheriaque_Indication)

            For iCount = 0 To DsTheriaque_Indication.FINCON_FINDCOMMENT_NATURE.Rows.Count - 1
                DsTheriaque_Indication.FINCON_FINDCOMMENT_NATURE.Rows(iCount).Delete()
            Next
            Me.FincoN_TA.Update(DsTheriaque_Indication)

            For iCount = 0 To DsTheriaque_Indication.FINTSS_INDICATION_TAUXSECU.Rows.Count - 1
                DsTheriaque_Indication.FINTSS_INDICATION_TAUXSECU.Rows(iCount).Delete()
            Next
            Me.FintsS_TA.Update(DsTheriaque_Indication)

            ' Master
            DsTheriaque_Indication.FIN_FICHEINDIC.Rows(0).Delete()
            Me.FiN_TA.Update(Me.MasterDataSet)

            bModeDuplication = False
            Return True
        Else
            Process_Message(strChargementOnglet, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

    End Function
    Public Overrides Sub valider()
        MyBase.Valider()
        'If (lkupCodification.SelectedText.Trim().Equals("")) Then
        '    Me.BindingContext(Me.MasterDataSet, MasterTable).Current("FIN_CDF_T2A_CODE_FK_PK") = ""
        'End If
        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        FiN_TA.Update(Me.DsTheriaque_Indication.FIN_FICHEINDIC)
        'Onglet Entités
        Me.BindingContext(Me.MasterDataSet, FINCPH_INDCPH).EndCurrentEdit()
        FincpH_TA.Update(Me.DsTheriaque_Indication.FINCPH_INDCPH)

        Me.BindingContext(Me.MasterDataSet, FINCCH_INDCCH).EndCurrentEdit()
        FinccH_TA.Update(Me.DsTheriaque_Indication.FINCCH_INDCCH)

        Me.BindingContext(Me.MasterDataSet, FINSAC_SUBAC).EndCurrentEdit()
        FinsaC_TA.Update(Me.DsTheriaque_Indication.FINSAC_SUBAC)

        Me.BindingContext(Me.MasterDataSet, FINCH_INDCHOIX).EndCurrentEdit()
        FincH_TA.Update(Me.DsTheriaque_Indication.FINCH_INDCHOIX)

        Me.BindingContext(Me.MasterDataSet, FINPR_INDPROD).EndCurrentEdit()
        FinpR_TA.Update(Me.DsTheriaque_Indication.FINPR_INDPROD)

        Me.BindingContext(Me.MasterDataSet, FINSP_INDSPE).EndCurrentEdit()
        FinsP_TA.Update(Me.DsTheriaque_Indication.FINSP_INDSPE)

        'Onglet2
        Me.BindingContext(Me.MasterDataSet, FINTY_FINDTYPE).EndCurrentEdit()
        FintY_TA.Update(Me.DsTheriaque_Indication.FINTY_FINDTYPE)

        Me.BindingContext(Me.MasterDataSet, FINTSS_INDICATION_TAUXSECU).EndCurrentEdit()
        FintsS_TA.Update(Me.DsTheriaque_Indication.FINTSS_INDICATION_TAUXSECU)

        Me.BindingContext(Me.MasterDataSet, FINCON_FINDCOMMENT_NATURE).EndCurrentEdit()
        FincoN_TA.Update(Me.DsTheriaque_Indication.FINCON_FINDCOMMENT_NATURE)

        Me.BindingContext(Me.MasterDataSet, FINSMR_INDIC_SMR_ATR).EndCurrentEdit()
        FinsmR_TA.Update(Me.DsTheriaque_Indication.FINSMR_INDIC_SMR_ATR)

        Me.BindingContext(Me.MasterDataSet, FINET_FINDETIOL).EndCurrentEdit()
        FineT_TA.Update(Me.DsTheriaque_Indication.FINET_FINDETIOL)

        Me.BindingContext(Me.MasterDataSet, FINCO_FINDCOMMENT).EndCurrentEdit()
        FincO_TA.Update(Me.DsTheriaque_Indication.FINCO_FINDCOMMENT)

        Me.BindingContext(Me.MasterDataSet, FINBIB_REFERENCE_BIBLIO).EndCurrentEdit()
        FinbiB_TA.Update(Me.DsTheriaque_Indication.FINBIB_REFERENCE_BIBLIO)

        Me.BindingContext(Me.MasterDataSet, FINAFS_FIN_AFSSAPS).EndCurrentEdit()
        FinafS_TA.Update(Me.DsTheriaque_Indication.FINAFS_FIN_AFSSAPS)

        UpdateCIP13()

        bModeDuplication = False
        'Tab_TA1 = True
    End Sub
    Public Overrides Sub annuler()
        OnLoading = True
        MyBase.Annuler()
        'Onglet Entités

        Me.BindingContext(DsTheriaque_Indication, FINAFS_FIN_AFSSAPS).CancelCurrentEdit()
        Me.DsTheriaque_Indication.FINAFS_FIN_AFSSAPS.RejectChanges()

        Me.BindingContext(DsTheriaque_Indication, FINBIB_REFERENCE_BIBLIO).CancelCurrentEdit()
        Me.DsTheriaque_Indication.FINBIB_REFERENCE_BIBLIO.RejectChanges()

        Me.BindingContext(DsTheriaque_Indication, FINCO_FINDCOMMENT).CancelCurrentEdit()
        Me.DsTheriaque_Indication.FINCO_FINDCOMMENT.RejectChanges()

        Me.BindingContext(DsTheriaque_Indication, FINET_FINDETIOL).CancelCurrentEdit()
        Me.DsTheriaque_Indication.FINET_FINDETIOL.RejectChanges()

        Me.BindingContext(DsTheriaque_Indication, FINSMR_INDIC_SMR_ATR).CancelCurrentEdit()
        Me.DsTheriaque_Indication.FINSMR_INDIC_SMR_ATR.RejectChanges()

        Me.BindingContext(DsTheriaque_Indication, FINCPH_INDCPH).CancelCurrentEdit()
        Me.DsTheriaque_Indication.FINCPH_INDCPH.RejectChanges()

        Me.BindingContext(DsTheriaque_Indication, FINCCH_INDCCH).CancelCurrentEdit()
        Me.DsTheriaque_Indication.FINCCH_INDCCH.RejectChanges()

        Me.BindingContext(DsTheriaque_Indication, FINSAC_SUBAC).CancelCurrentEdit()
        Me.DsTheriaque_Indication.FINSAC_SUBAC.RejectChanges()

        Me.BindingContext(DsTheriaque_Indication, FINCH_INDCHOIX).CancelCurrentEdit()
        Me.DsTheriaque_Indication.FINCH_INDCHOIX.RejectChanges()

        Me.BindingContext(DsTheriaque_Indication, FINPR_INDPROD).CancelCurrentEdit()
        Me.DsTheriaque_Indication.FINPR_INDPROD.RejectChanges()

        Me.BindingContext(DsTheriaque_Indication, FINSP_INDSPE).CancelCurrentEdit()
        Me.DsTheriaque_Indication.FINSP_INDSPE.RejectChanges()

        'Onglet 2
        Me.BindingContext(DsTheriaque_Indication, FINTY_FINDTYPE).CancelCurrentEdit()
        Me.DsTheriaque_Indication.FINTY_FINDTYPE.RejectChanges()

        Me.BindingContext(DsTheriaque_Indication, FINCON_FINDCOMMENT_NATURE).CancelCurrentEdit()
        Me.DsTheriaque_Indication.FINCON_FINDCOMMENT_NATURE.RejectChanges()

        Me.BindingContext(DsTheriaque_Indication, FINTSS_INDICATION_TAUXSECU).CancelCurrentEdit()
        Me.DsTheriaque_Indication.FINTSS_INDICATION_TAUXSECU.RejectChanges()

        'Master
        Me.BindingContext(Me.MasterDataSet, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_Indication.FIN_FICHEINDIC.RejectChanges()

        If bModeDuplication Then EmptyDataTable()
        bModeDuplication = False
        OnLoading = False
    End Sub
    Private Sub EmptyDataTable()
        Me.DsTheriaque_Indication.FIN_FICHEINDIC.Clear()
        'Onglet Entités
        Me.DsTheriaque_Indication.FINCPH_INDCPH.Clear()
        Me.DsTheriaque_Indication.FINCCH_INDCCH.Clear()
        Me.DsTheriaque_Indication.FINSAC_SUBAC.Clear()
        Me.DsTheriaque_Indication.FINCH_INDCHOIX.Clear()
        Me.DsTheriaque_Indication.FINPR_INDPROD.Clear()
        Me.DsTheriaque_Indication.FINSP_INDSPE.Clear()

        'Onglet 2
        Me.DsTheriaque_Indication.FINTY_FINDTYPE.Clear()
        Me.DsTheriaque_Indication.FINCON_FINDCOMMENT_NATURE.Clear()
        Me.DsTheriaque_Indication.FINTSS_INDICATION_TAUXSECU.Clear()
        Me.DsTheriaque_Indication.FINSMR_INDIC_SMR_ATR.Clear()
        Me.DsTheriaque_Indication.FINET_FINDETIOL.Clear()
        Me.DsTheriaque_Indication.FINCO_FINDCOMMENT.Clear()
        Me.DsTheriaque_Indication.FINBIB_REFERENCE_BIBLIO.Clear()
        Me.DsTheriaque_Indication.FINAFS_FIN_AFSSAPS.Clear()
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
        dt1 = DsTheriaque_Indication.FINCPH_INDCPH.Copy

        Dim dt2 As New DataTable
        dt2 = DsTheriaque_Indication.FINCCH_INDCCH.Copy

        Dim dt3 As New DataTable
        dt3 = DsTheriaque_Indication.FINSAC_SUBAC.Copy

        Dim dt4 As New DataTable
        dt4 = DsTheriaque_Indication.FINPR_INDPROD.Copy

        Dim dt5 As New DataTable
        dt5 = DsTheriaque_Indication.FINCH_INDCHOIX.Copy

        Dim dt6 As New DataTable
        dt6 = DsTheriaque_Indication.FINSP_INDSPE.Copy

        'Onglet2
        Dim sLkupNiveauIndicCode As String = Me.BindingContext(DsTheriaque_Indication, FIN_FICHEINDIC).Current("FIN_CDF_NVIN_CODE_FK_PK").ToString
        Dim sLkupNatureIndicCode As String = Me.BindingContext(DsTheriaque_Indication, FIN_FICHEINDIC).Current("FIN_CDF_NAIN_CODE_FK_PK").ToString

        Dim dt22 As New DataTable
        dt22 = DsTheriaque_Indication.FINTY_FINDTYPE.Copy

        Dim dt24 As New DataTable
        dt24 = DsTheriaque_Indication.FINCON_FINDCOMMENT_NATURE.Copy

        'Onglet2
        Dim dt26 As New DataTable
        dt26 = DsTheriaque_Indication.FINTSS_INDICATION_TAUXSECU.Copy

        Dim dt28 As New DataTable
        dt28 = DsTheriaque_Indication.FINET_FINDETIOL.Copy

        Dim dt29 As New DataTable
        dt29 = DsTheriaque_Indication.FINCO_FINDCOMMENT.Copy

        Dim dt30 As New DataTable
        dt30 = DsTheriaque_Indication.FINAFS_FIN_AFSSAPS.Copy

        Dim sText As String = MemoEdit1.Text

        'Vider les contrôles
        EmptyDataTable()

        'Construction de la nouvelle fiche avec les données de la fiche de base
        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        SetCode_MAx(MasterTable, txtCode)
        CodE = InvalideControl

        Dim drTemp As DataRow
        For iCount As Integer = 0 To dt1.Rows.Count - 1
            drTemp = DsTheriaque_Indication.Tables("FINCPH_INDCPH").NewRow()
            drTemp.ItemArray = dt1.Rows(iCount).ItemArray
            DsTheriaque_Indication.Tables("FINCPH_INDCPH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt2.Rows.Count - 1
            drTemp = DsTheriaque_Indication.Tables("FINCCH_INDCCH").NewRow()
            drTemp.ItemArray = dt2.Rows(iCount).ItemArray
            DsTheriaque_Indication.Tables("FINCCH_INDCCH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt3.Rows.Count - 1
            drTemp = DsTheriaque_Indication.Tables("FINSAC_SUBAC").NewRow()
            drTemp.ItemArray = dt3.Rows(iCount).ItemArray
            DsTheriaque_Indication.Tables("FINSAC_SUBAC").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt4.Rows.Count - 1
            drTemp = DsTheriaque_Indication.Tables("FINPR_INDPROD").NewRow()
            drTemp.ItemArray = dt4.Rows(iCount).ItemArray
            DsTheriaque_Indication.Tables("FINPR_INDPROD").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt5.Rows.Count - 1
            drTemp = DsTheriaque_Indication.Tables("FINCH_INDCHOIX").NewRow()
            drTemp.ItemArray = dt5.Rows(iCount).ItemArray
            DsTheriaque_Indication.Tables("FINCH_INDCHOIX").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt6.Rows.Count - 1
            drTemp = DsTheriaque_Indication.Tables("FINSP_INDSPE").NewRow()
            drTemp.ItemArray = dt6.Rows(iCount).ItemArray
            DsTheriaque_Indication.Tables("FINSP_INDSPE").Rows.Add(drTemp)
        Next


        For iCount As Integer = 0 To dt22.Rows.Count - 1
            drTemp = DsTheriaque_Indication.Tables("FINTY_FINDTYPE").NewRow()
            drTemp.ItemArray = dt22.Rows(iCount).ItemArray
            DsTheriaque_Indication.Tables("FINTY_FINDTYPE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt24.Rows.Count - 1
            drTemp = DsTheriaque_Indication.Tables("FINCON_FINDCOMMENT_NATURE").NewRow()
            drTemp.ItemArray = dt24.Rows(iCount).ItemArray
            DsTheriaque_Indication.Tables("FINCON_FINDCOMMENT_NATURE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt26.Rows.Count - 1
            drTemp = DsTheriaque_Indication.Tables("FINTSS_INDICATION_TAUXSECU").NewRow()
            drTemp.ItemArray = dt26.Rows(iCount).ItemArray
            DsTheriaque_Indication.Tables("FINTSS_INDICATION_TAUXSECU").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt28.Rows.Count - 1
            drTemp = DsTheriaque_Indication.Tables("FINET_FINDETIOL").NewRow()
            drTemp.ItemArray = dt28.Rows(iCount).ItemArray
            DsTheriaque_Indication.Tables("FINET_FINDETIOL").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt29.Rows.Count - 1
            drTemp = DsTheriaque_Indication.Tables("FINCO_FINDCOMMENT").NewRow()
            drTemp.ItemArray = dt29.Rows(iCount).ItemArray
            DsTheriaque_Indication.Tables("FINCO_FINDCOMMENT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt30.Rows.Count - 1
            drTemp = DsTheriaque_Indication.Tables("FINAFS_FIN_AFSSAPS").NewRow()
            drTemp.ItemArray = dt30.Rows(iCount).ItemArray
            DsTheriaque_Indication.Tables("FINAFS_FIN_AFSSAPS").Rows.Add(drTemp)
        Next

        If sLkupNiveauIndicCode <> "" Then Me.BindingContext(DsTheriaque_Indication, FIN_FICHEINDIC).Current("FIN_CDF_NVIN_CODE_FK_PK") = sLkupNiveauIndicCode
        If sLkupNatureIndicCode <> "" Then Me.BindingContext(DsTheriaque_Indication, FIN_FICHEINDIC).Current("FIN_CDF_NAIN_CODE_FK_PK") = sLkupNatureIndicCode

        MemoEdit1.Text = sText

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
            GV1.SetRowCellValue(iCount, colFINCPH_FIN_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV2
        For iCount As Integer = 0 To GV2.RowCount - 1
            GV2.SetRowCellValue(iCount, colFINCCH_FIN_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV3
        For iCount As Integer = 0 To GV3.RowCount - 1
            GV3.SetRowCellValue(iCount, colFINSAC_FIN_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV4
        For iCount As Integer = 0 To GV4.RowCount - 1
            GV4.SetRowCellValue(iCount, colFINPR_FIN_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV5
        For iCount As Integer = 0 To GV5.RowCount - 1
            GV5.SetRowCellValue(iCount, colFINCH_FIN_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV6
        For iCount As Integer = 0 To GV6.RowCount - 1
            GV6.SetRowCellValue(iCount, colFINSP_FIN_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV22
        For iCount As Integer = 0 To GV22.RowCount - 1
            GV22.SetRowCellValue(iCount, colFINTY_FIN_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV24
        For iCount As Integer = 0 To GV24.RowCount - 1
            GV24.SetRowCellValue(iCount, colFINCON_FIN_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV26
        For iCount As Integer = 0 To GV26.RowCount - 1
            GV26.SetRowCellValue(iCount, colFINTSS_FIN_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV28
        For iCount As Integer = 0 To GV28.RowCount - 1
            GV28.SetRowCellValue(iCount, colFINET_FIN_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV29
        For iCount As Integer = 0 To GV29.RowCount - 1
            GV29.SetRowCellValue(iCount, colFINCO_FIN_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV30
        For iCount As Integer = 0 To GV30.RowCount - 1
            GV30.SetRowCellValue(iCount, colFINAFS_FIN_CODE_FK_PK, Me.txtCode.Text)
        Next
    End Sub
    Protected Friend Overrides Function ValideControl(Optional ByRef Ctrl As Control = Nothing, Optional ByVal AllCtrl As Boolean = True) As Boolean
        MyBase.ValideControl(Ctrl)
        For iCount As Integer = 0 To GV30.RowCount - 1
            If Not FieldExistRO(GV6, colFINSP_SP_CODE_FK_PK, GV30.GetRowCellValue(iCount, colFINAFS_SP_CODE_FK_PK)) Then
                GV30.FocusedRowHandle = iCount
                GV30.SetColumnError(colFINAFS_SP_CODE_FK_PK, "La spécialité doit être présente dans la fiche.")
                XtraTabControl1.SelectedTabPageIndex = 2
                Exit Function
            Else
                GV30.SetColumnError(colFINAFS_SP_CODE_FK_PK, "")
            End If
        Next

        Return True
    End Function

    'Private Function Test_Indication_Used() As Boolean
    '    Dim dt As DataTable = cn.MySelect("SELECT * FROM THERIAQUE.FPOUT_FPOSO_UTILTH WHERE FPOUT_CDF_UTPO_CODE_FK_PK = " & cn.SQLText(lkupFIN_NAIN.EditValue))
    '    If dt.Rows.Count > 0 Then
    '        Return True
    '    End If
    ' End Function
#End Region

#Region " Init Data  "

    Private Sub InitDataSource()
        'Onglet Entités
        GC1.DataSource = DsTheriaque_Indication
        GC1.DataMember = FINCPH_INDCPH

        GC2.DataSource = DsTheriaque_Indication
        GC2.DataMember = FINCCH_INDCCH

        GC3.DataSource = DsTheriaque_Indication
        GC3.DataMember = FINSAC_SUBAC

        GC4.DataSource = DsTheriaque_Indication
        GC4.DataMember = FINPR_INDPROD

        GC5.DataSource = DsTheriaque_Indication
        GC5.DataMember = FINCH_INDCHOIX

        GC6.DataSource = DsTheriaque_Indication
        GC6.DataMember = FINSP_INDSPE

        'Onglet2

        GC22.DataSource = DsTheriaque_Indication
        GC22.DataMember = FINTY_FINDTYPE

        GC24.DataSource = DsTheriaque_Indication
        GC24.DataMember = FINCON_FINDCOMMENT_NATURE

        GC26.DataSource = DsTheriaque_Indication
        GC26.DataMember = FINTSS_INDICATION_TAUXSECU

        GC27.DataSource = DsTheriaque_Indication
        GC27.DataMember = FINSMR_INDIC_SMR_ATR


        GC28.DataSource = DsTheriaque_Indication
        GC28.DataMember = FINET_FINDETIOL

        GC29.DataSource = DsTheriaque_Indication
        GC29.DataMember = FINCO_FINDCOMMENT

        GC12.DataSource = DsTheriaque_Indication
        GC12.DataMember = FINBIB_REFERENCE_BIBLIO

        GC30.DataSource = DsTheriaque_Indication
        GC30.DataMember = FINAFS_FIN_AFSSAPS

    End Sub
    Public Overrides Sub InitData()
        MyBase.InitData()
        OnLoading = True
        Declinaison_Global = True
        MasterDataSet = Me.DsTheriaque_Indication
        MasterTable = FIN_FICHEINDIC
        CodE = InvalideControl

        'Déclinaison classe CPH
        Dim List1 As New System.Collections.Generic.List(Of StructGVTable)
        List1.Add(New StructGVTable("GC1", eDeclinaison.CPH, colFINCPH_CPH_CODE_FK_PK))
        List1.Add(New StructGVTable("GC2", eDeclinaison.CCH, colFINCCH_CCH_CODE_FK_PK))
        List1.Add(New StructGVTable("GC3", eDeclinaison.SAC, colFINSAC_SAC_CODE_FK_PK))
        List1.Add(New StructGVTable("GC6", eDeclinaison.SP, colFINSP_SP_CODE_FK_PK))
        Dim DecCPH As New ClsDeclinaison(eDeclinaison.CPH, List1)
        InitLkup(Me.rp_FINCPH, FINCPH_INDCPH, strSSQL_CPH_CLASSEPHARMTHER_NIVEAU, True, , , , , , DecCPH)

        'Déclinaison classe CCH
        Dim List2 As New System.Collections.Generic.List(Of StructGVTable)
        List2.Add(New StructGVTable("GC1", eDeclinaison.CPH, colFINCPH_CPH_CODE_FK_PK))
        List2.Add(New StructGVTable("GC2", eDeclinaison.CCH, colFINCCH_CCH_CODE_FK_PK))
        List2.Add(New StructGVTable("GC3", eDeclinaison.SAC, colFINSAC_SAC_CODE_FK_PK))
        List2.Add(New StructGVTable("GC6", eDeclinaison.SP, colFINSP_SP_CODE_FK_PK))
        Dim DecCCH As New ClsDeclinaison(eDeclinaison.CCH, List2)
        InitLkup(Me.rp_FINCCH, FINCCH_INDCCH, strSSQL_CCH_CLASSECHIMIQUE_NIVEAU, True, , , , , , DecCCH)

        'Déclinaison SUBAC
        Dim List3 As New System.Collections.Generic.List(Of StructGVTable)
        List3.Add(New StructGVTable("GC3", eDeclinaison.SAC, colFINSAC_SAC_CODE_FK_PK))
        List3.Add(New StructGVTable("GC6", eDeclinaison.SP, colFINSP_SP_CODE_FK_PK))
        Dim DecSUBAC As New ClsDeclinaison(eDeclinaison.SAC, List3)
        InitLkup(Me.rp_FINSAC, FINSAC_SUBAC, strSSQL_SAC_SUBACTIVE, True, , , , , , DecSUBAC)

        'Déclinaison PRODUIT
        Dim List5 As New System.Collections.Generic.List(Of StructGVTable)
        List5.Add(New StructGVTable("GC4", eDeclinaison.PR, colFINPR_PR_CODE_FK_PK))
        List5.Add(New StructGVTable("GC6", eDeclinaison.SP, colFINSP_SP_CODE_FK_PK))
        Dim DecPR As New ClsDeclinaison(eDeclinaison.PR, List5)

        InitLkup(Me.rp_FINPR, FINPR_INDPROD, strSSQL_PR_PRODUIT, True, , , , , , DecPR)
        InitLkup(Me.rp_FINSP, FINSP_INDSPE, strSSQL_SP_SPECIALITE, True)
        InitLkup(Me.rp_FINCH, FINCH_INDCHOIX, strSSQL_CH_CHOIX, True)

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
        Me.FiN_TA.FillByCode(Me.DsTheriaque_Indication.FIN_FICHEINDIC, CodE1)
        'Onglet Entités
        Me.FincpH_TA.FillByCode(Me.DsTheriaque_Indication.FINCPH_INDCPH, CodE1)
        Me.FinccH_TA.FillByCode(Me.DsTheriaque_Indication.FINCCH_INDCCH, CodE1)
        Me.FinsaC_TA.FillByCode(Me.DsTheriaque_Indication.FINSAC_SUBAC, CodE1)
        Me.FinpR_TA.FillByCode(Me.DsTheriaque_Indication.FINPR_INDPROD, CodE1)
        Me.FincH_TA.FillByCode(Me.DsTheriaque_Indication.FINCH_INDCHOIX, CodE1)
        Me.FinsP_TA.FillByCode(Me.DsTheriaque_Indication.FINSP_INDSPE, CodE1)
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

    Private Sub LoadTab_1()
        Load_On(Me)
        OnLoading = True
        If Not Tab_lkup1 Then
            InitLkup(Me.lkupFIN_NVIN, FIN_FICHEINDIC, strSSQL_CDF_CODIF("NV"), True)
            InitLkup(Me.lkupFIN_NAIN, FIN_FICHEINDIC, strSSQL_CDF_CODIF_NIVEAU("NN"), True)
            InitLkup(Me.rp_FINTY, FINTY_FINDTYPE, strSSQL_CDF_CODIF("NY"), True)
            InitLkup(Me.rp_FINCON, FINCON_FINDCOMMENT_NATURE, strSSQL_CDF_CODIF("NC", "and substring(CDF_CODE_PK,1,1) IN ('A','B','F','P') "), True)
            InitLkup(rpPRE, PRE_PRESENTATION, "select PRE_CODE_PK as code, PRE_SP_CODE_FK as libelle from THERIAQUE.PRE_PRESENTATION ", True)
            InitLkup(Me.lkupCodification, FIN_FICHEINDIC, strSSQL_CDF_CODIF("NT"), True)
            Tab_lkup1 = True
        End If
        If Not Tab_TA1 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.FiN_TA.FillByCode(Me.DsTheriaque_Indication.FIN_FICHEINDIC, CodE)
            Me.FintY_TA.FillByCode(Me.DsTheriaque_Indication.FINTY_FINDTYPE, CodE)
            Me.FincoN_TA.FillByCode(Me.DsTheriaque_Indication.FINCON_FINDCOMMENT_NATURE, CodE)
            Me.FintsS_TA.FillByCode(Me.DsTheriaque_Indication.FINTSS_INDICATION_TAUXSECU, CodE)
            GV24_ValidateRow(Nothing, Nothing)
            Tab_TA1 = True
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub
    Private Sub LoadTab_2()
        Load_On(Me)
        OnLoading = True
        If CodE <> InvalideControl And CodE <> Nothing Then
            Dim strSSQL_PRE_CIP As String
            'strSSQL_PRE_CIP = " SELECT PRE_CODE_PK as code, SP_NOM as libelle, CDF_NOM  as val1, PRETSS_DATE_APPLI_PK  as val2, PRETSS_CDF_TSS_CODE_FK_PK val3 FROM THERIAQUE.PRE_PRESENTATION"
            'strSSQL_PRE_CIP &= " Left outer join THERIAQUE.SP_SPECIALITE"
            'strSSQL_PRE_CIP &= " on  PRE_SP_CODE_FK = SP_CODE_SQ_PK"
            'strSSQL_PRE_CIP &= " left outer join THERIAQUE.PRETSS_PRESENTATION_TAUX "
            'strSSQL_PRE_CIP &= " on PRETSS_PRE_CODE_FK_PK  = PRE_CODE_PK "
            'strSSQL_PRE_CIP &= " left outer join THERIAQUE.CDF_CODIF"
            'strSSQL_PRE_CIP &= " on CDF_CODE_PK = PRETSS_CDF_TSS_CODE_FK_PK AND CDF_NUMERO_PK = '17'"
            'strSSQL_PRE_CIP &= " WHERE PRE_SP_CODE_FK IN (SELECT FINSP_SP_CODE_FK_PK FROM THERIAQUE.FINSP_INDSPE"
            'strSSQL_PRE_CIP &= " WHERE FINSP_FIN_CODE_FK_PK = " & CodE & ")"
            'InitLkup(Me.rp_FINTSS_CIP, FINTSS_INDICATION_TAUXSECU, strSSQL_PRE_CIP, True)

            strSSQL_PRE_CIP = " SELECT PRE_CODE_PK as code, SP_NOM as libelle FROM THERIAQUE.PRE_PRESENTATION"
            strSSQL_PRE_CIP &= " Left outer join THERIAQUE.SP_SPECIALITE"
            strSSQL_PRE_CIP &= " on  PRE_SP_CODE_FK = SP_CODE_SQ_PK"
            strSSQL_PRE_CIP &= " left outer join THERIAQUE.PRETSS_PRESENTATION_TAUX "
            strSSQL_PRE_CIP &= " on PRETSS_PRE_CODE_FK_PK  = PRE_CODE_PK "
            strSSQL_PRE_CIP &= " left outer join THERIAQUE.CDF_CODIF"
            strSSQL_PRE_CIP &= " on CDF_CODE_PK = PRETSS_CDF_TSS_CODE_FK_PK AND CDF_NUMERO_PK = '17'"
            strSSQL_PRE_CIP &= " WHERE PRE_SP_CODE_FK IN (SELECT FINSP_SP_CODE_FK_PK FROM THERIAQUE.FINSP_INDSPE"
            strSSQL_PRE_CIP &= " WHERE FINSP_FIN_CODE_FK_PK = " & CodE & ")"
            InitLkup(Me.rp_FINTSS_CIP, FINTSS_INDICATION_TAUXSECU, strSSQL_PRE_CIP, True)

            Dim strSSQL_SP_REF As String
            strSSQL_SP_REF = " SELECT SP_CODE_SQ_PK as code, SP_NOM as libelle FROM THERIAQUE.FINSP_INDSPE, THERIAQUE.SP_SPECIALITE"
            strSSQL_SP_REF &= " WHERE FINSP_FIN_CODE_FK_PK = " & CodE
            strSSQL_SP_REF &= " AND SP_CODE_SQ_PK = FINSP_SP_CODE_FK_PK"
            InitLkup(Me.rp_FINAFS_SP, FINAFS_FIN_AFSSAPS, strSSQL_SP_REF, True)
            For iCount As Integer = 0 To GV30.RowCount
                If GV30.GetRowCellDisplayText(iCount, "FINAFS_SP_CODE_FK_PK") = "" And GV30.GetRowCellDisplayText(iCount, "FINAFS_FIN_CODE_FK_PK") <> "" Then
                    GV30.DeleteRow(iCount)
                    iCount = iCount - 1
                End If
            Next
        End If
        If Not Tab_lkup2 Then
            InitLkup(rpPRE, PRE_PRESENTATION, "select PRE_CODE_PK as code, PRE_SP_CODE_FK as libelle from THERIAQUE.PRE_PRESENTATION ", True)
            InitLkup(Me.rp_FINTSS, FINTSS_INDICATION_TAUXSECU, strSSQL_CDF_CODIF("17"), True)
            InitLkup(Me.rpSMR, CDF_CODIF, strSSQL_CDF_CODIF("27"), True)
            InitLkup(Me.rpAgent, CDF_CODIF, strSSQL_CDF_CODIF_NIVEAU("NA"), True)
            InitLkup(Me.rpCommentaire, CDF_CODIF, strSSQL_CDF_CODIF("NC", "and substring(CDF_CODE_PK,1,1) not in ('A','B','F','P') "), True)
            InitLkup(Me.rp_FINAFS, FINAFS_FIN_AFSSAPS, strSSQL_CDF_CODIF("25"), True)
            Tab_lkup2 = True
        End If
        If Not Tab_TA2 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.FintsS_TA.FillByCode(Me.DsTheriaque_Indication.FINTSS_INDICATION_TAUXSECU, CodE)
            Me.FinsmR_TA.FillByCode(Me.DsTheriaque_Indication.FINSMR_INDIC_SMR_ATR, CodE)
            Me.FineT_TA.FillByCode(Me.DsTheriaque_Indication.FINET_FINDETIOL, CodE)
            Me.FincO_TA.FillByCode(Me.DsTheriaque_Indication.FINCO_FINDCOMMENT, CodE)
            Me.FinafS_TA.FillByCode(Me.DsTheriaque_Indication.FINAFS_FIN_AFSSAPS, CodE)
            Me.FinbiB_TA.FillByCode(Me.DsTheriaque_Indication.FINBIB_REFERENCE_BIBLIO, CodE)
            Tab_TA2 = True
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
    End Sub
    Private Sub Frm_Indication_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        GC27.Width = Me.XtraTabPage3.Width / 2
        GC29.Width = Me.XtraTabPage3.Width / 2
        GC30.Width = Me.XtraTabPage3.Width / 2

        GC24.Width = Me.XtraTabPage2.Width / 2
        GC22.Width = Me.XtraTabPage2.Width / 2
        Panel3.Height = (Me.XtraTabPage2.Height - Panel2.Height - Panel9.Height) / 2
    End Sub

#End Region

#Region " New Rows "

    Private Sub GV1_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV1.InitNewRow
        If OnLoading Then Exit Sub
        GV1.SetFocusedRowCellValue(colFINCPH_FIN_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        If OnLoading Then Exit Sub
        GV2.SetFocusedRowCellValue(colFINCCH_FIN_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV3_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV3.InitNewRow
        If OnLoading Then Exit Sub
        GV3.SetFocusedRowCellValue(colFINSAC_FIN_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV4_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV4.InitNewRow
        If OnLoading Then Exit Sub
        GV4.SetFocusedRowCellValue(colFINPR_FIN_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV5_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV5.InitNewRow
        If OnLoading Then Exit Sub
        GV5.SetFocusedRowCellValue(colFINCH_FIN_CODE_FK_PK, txtCode.Text)
        GV5.SetFocusedRowCellValue(colFINCH_NUMORD, Code_MAx(GV5, colFINCH_NUMORD))
    End Sub
    Private Sub GV6_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV6.InitNewRow
        If OnLoading Then Exit Sub
        GV6.SetFocusedRowCellValue(colFINSP_FIN_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV22_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV22.InitNewRow
        If OnLoading Then Exit Sub
        GV22.SetFocusedRowCellValue(colFINTY_FIN_CODE_FK_PK, txtCode.Text)
        GV22.SetFocusedRowCellValue(colFINTY_NUMORD, Code_MAx(GV22, colFINTY_NUMORD))
    End Sub
    Private Sub GV24_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV24.InitNewRow
        If OnLoading Then Exit Sub
        GV24.SetFocusedRowCellValue(colFINCON_FIN_CODE_FK_PK, txtCode.Text)
        GV24.SetFocusedRowCellValue(colFINCON_NUMORD, Code_MAx(GV24, colFINCON_NUMORD))
    End Sub
    Private Sub GV26_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV26.InitNewRow
        If OnLoading Then Exit Sub
        GV26.SetFocusedRowCellValue(colFINTSS_FIN_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV27_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV27.InitNewRow
        GV27.SetFocusedRowCellValue(colFINSMR_FIN_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV28_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV28.InitNewRow
        GV28.SetFocusedRowCellValue(colFINET_FIN_CODE_FK_PK, txtCode.Text)
        GV28.SetFocusedRowCellValue(colFINET_NUMORD, Code_MAx(GV28, colFINET_NUMORD))
    End Sub
    Private Sub GV29_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV29.InitNewRow
        GV29.SetFocusedRowCellValue(colFINCO_FIN_CODE_FK_PK, txtCode.Text)
        GV29.SetFocusedRowCellValue(colFINCO_NUMORD, Code_MAx(GV29, colFINCO_NUMORD))
    End Sub
    Private Sub GV12_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV12.InitNewRow
        GV12.SetFocusedRowCellValue(colFINBIB_FIN_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV30_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV30.InitNewRow
        GV30.SetFocusedRowCellValue(colFINAFS_FIN_CODE_FK_PK, txtCode.Text)
    End Sub

#End Region

#Region " GV "

    Private Sub GV24_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV24.ValidateRow
        If OnLoading Then
            For iCount As Integer = 0 To GV25.RowCount
                GV25.DeleteRow(iCount)
            Next
        End If
        Dim strSSQL_CDF_CIM As String
        If GetCodeFromCollection(GetCodeFromGV(GV24, colFINCON_CDF_COIN_CODE_FK_PK)) Is Nothing Then Exit Sub
        If GetCodeFromCollection(GetCodeFromGV(GV24, colFINCON_CDF_COIN_CODE_FK_PK)) = "" Then Exit Sub
        strSSQL_CDF_CIM = " SELECT DISTINCT CIMCDF_CIM_CODE_FK_PK, CIM_LIBELLE_COURT  "
        strSSQL_CDF_CIM &= " FROM THERIAQUE.CIMCDF_CIM10_CODIF , THERIAQUE.CIM10 "
        strSSQL_CDF_CIM &= " WHERE CIMCDF_CDF_NUMERO_FK_PK = 'NC' "
        strSSQL_CDF_CIM &= " AND CIMCDF_CDF_CODE_FK_PK in " & GetCodeFromCollectionString(GetCodeFromGV(GV24, colFINCON_CDF_COIN_CODE_FK_PK))
        strSSQL_CDF_CIM &= " AND CIMCDF_CIM_CODE_FK_PK = CIM_CODE_PK"
        GC25.DataSource = cn.MySelect(strSSQL_CDF_CIM)
    End Sub
    Private Sub GV26_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs)
        If GV26.FocusedColumn Is colFINTSS_PRE_CODE_FK_PK2 Then
            GV26.SetFocusedRowCellValue(colFINTSS_PRE_CODE_FK_PK, ClsPRE.Code_SP_(GV26.GetFocusedRowCellValue(colFINTSS_PRE_CODE_FK_PK2)))
        End If
    End Sub
    Private Sub GV12_RowCountChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV12.RowCountChanged
        If GV12.RowCount >= 1 Then
            GV12.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
            Me.GC12.EmbeddedNavigator.Buttons.Append.Enabled = False
        Else
            GV12.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            Me.GC12.EmbeddedNavigator.Buttons.Append.Enabled = True
        End If
    End Sub
    Private Sub GV24_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV24.ValidatingEditor
        If GV24.FocusedColumn Is colFINCON_NUMORD Then
            If FieldExist(GV24, colFINCON_NUMORD, e.Value) Then
                e.ErrorText = "Le numéro doit être unique."
                e.Value = Nothing
                e.Valid = False
            End If
        End If
    End Sub

#End Region

#Region " Panel Resize  "

    Private Sub XtraTabControl1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraTabControl1.Resize
        Panel4.Height = XtraTabControl1.Height / 3
        Panel6.Height = XtraTabControl1.Height / 3
        Panel7.Height = XtraTabControl1.Height / 3
    End Sub
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
    Private Sub Panel3_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.Resize
        GC22.Width = Panel3.Width / 2
        GC23.Width = Panel3.Width / 2
    End Sub
    Private Sub Panel5_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel5.Resize
        GC24.Width = Panel5.Width / 2
        GC25.Width = Panel5.Width / 2
    End Sub


#End Region

#Region " Bouton "

    Private Sub lkupFIN_NAIN_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupFIN_NAIN.EditValueChanged
        If lkupFIN_NAIN.EditValue IsNot DBNull.Value Then
            txtMaladiRareTexte.Text = ""
            txtMaladieRareO_N.Text = ""
            '---------------------------------------
            '--------------------------------------- 
            Dim dt As New DataTable
            dt = cn.MySelect("Select NAIN_MALADIE_RARE, NAIN_TEXTE  from THERIAQUE.NAIN_NATURE_INDICATION, THERIAQUE.CDF_CODIF where  CDF_CODE_PK = NAIN_CODE_PK and  CDF_NUMERO_PK = 'NN' and NAIN_CODE_PK = " & cn.SQLText(lkupFIN_NAIN.EditValue))
            If dt.Rows.Count > 0 Then
                If dt.Rows(0)("NAIN_MALADIE_RARE") IsNot DBNull.Value Then
                    txtMaladieRareO_N.Text = dt.Rows(0)("NAIN_MALADIE_RARE")
                End If
                If dt.Rows(0)("NAIN_TEXTE") IsNot DBNull.Value Then
                    txtMaladiRareTexte.Text = dt.Rows(0)("NAIN_TEXTE")
                End If
            End If
            '---------------------------------------
            '---------------------------------------
            Dim strSSQL_CDF_CIM As String
            strSSQL_CDF_CIM = " SELECT DISTINCT CIMCDF_CIM_CODE_FK_PK, CIM_LIBELLE_COURT  "
            strSSQL_CDF_CIM &= " FROM THERIAQUE.CIMCDF_CIM10_CODIF , THERIAQUE.CIM10 "
            strSSQL_CDF_CIM &= " WHERE CIMCDF_CDF_NUMERO_FK_PK = 'NN' "
            strSSQL_CDF_CIM &= " AND CIMCDF_CDF_CODE_FK_PK = " & cn.SQLText(lkupFIN_NAIN.EditValue)
            strSSQL_CDF_CIM &= " AND CIMCDF_CIM_CODE_FK_PK = CIM_CODE_PK"
            GC23.DataSource = cn.MySelect(strSSQL_CDF_CIM)
            '---------------------------------------
            '---------------------------------------
        End If
    End Sub
    Private Sub btADDRemb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btADDRemb.Click
        If CodE IsNot Nothing And CodE <> InvalideControl And CodE <> Nothing Then
            Dim strSSQL_PRE_CIP As String
            strSSQL_PRE_CIP = " SELECT PRE_CODE_PK as code, SP_NOM as libelle, CDF_NOM  as val1, PRETSS_DATE_APPLI_PK  as val2, PRETSS_CDF_TSS_CODE_FK_PK as val3 FROM THERIAQUE.PRE_PRESENTATION"
            strSSQL_PRE_CIP &= " Left outer join THERIAQUE.SP_SPECIALITE"
            strSSQL_PRE_CIP &= " on  PRE_SP_CODE_FK = SP_CODE_SQ_PK"
            strSSQL_PRE_CIP &= " left outer join THERIAQUE.PRETSS_PRESENTATION_TAUX "
            strSSQL_PRE_CIP &= " on PRETSS_PRE_CODE_FK_PK  = PRE_CODE_PK "
            strSSQL_PRE_CIP &= " left outer join THERIAQUE.CDF_CODIF"
            strSSQL_PRE_CIP &= " on CDF_CODE_PK = PRETSS_CDF_TSS_CODE_FK_PK"
            strSSQL_PRE_CIP &= " WHERE PRE_SP_CODE_FK IN (SELECT FINSP_SP_CODE_FK_PK FROM THERIAQUE.FINSP_INDSPE"
            strSSQL_PRE_CIP &= " WHERE FINSP_FIN_CODE_FK_PK = " & CodE & ")"
            strSSQL_PRE_CIP &= " AND CDF_NUMERO_PK = '17'"
            strSSQL_PRE_CIP &= " UNION "
            strSSQL_PRE_CIP &= " SELECT PRE_CODE_PK as code, SP_NOM as libelle, CDF_NOM  as val1, PRETSSH_DATE_APPLI_PK  as val2, PRETSSH_CDF_TSS_CODE_FK_PK as val3 FROM THERIAQUE.PRE_PRESENTATION"
            strSSQL_PRE_CIP &= " Left outer join THERIAQUE.SP_SPECIALITE"
            strSSQL_PRE_CIP &= " on  PRE_SP_CODE_FK = SP_CODE_SQ_PK"
            strSSQL_PRE_CIP &= " left outer join THERIAQUE.PRETSSH_PRE_TAUX_HOP "
            strSSQL_PRE_CIP &= " on PRETSSH_PRE_CODE_FK_PK  = PRE_CODE_PK "
            strSSQL_PRE_CIP &= " left outer join THERIAQUE.CDF_CODIF"
            strSSQL_PRE_CIP &= " on CDF_CODE_PK = PRETSSH_CDF_TSS_CODE_FK_PK"
            strSSQL_PRE_CIP &= " WHERE PRE_SP_CODE_FK IN (SELECT FINSP_SP_CODE_FK_PK FROM THERIAQUE.FINSP_INDSPE"
            strSSQL_PRE_CIP &= " WHERE FINSP_FIN_CODE_FK_PK = " & CodE & ")"
            strSSQL_PRE_CIP &= " AND CDF_NUMERO_PK = '17'"
            Dim f As New Frm_Dictionnaire
            f._SSQL = strSSQL_PRE_CIP

            f.colVal1.Caption = "Taux de remboursement"
            f.colVal2.Caption = "Date"
            f.ShowDialog()
            If f._Code IsNot Nothing Then
                GV26.AddNewRow()
                GV26.SetFocusedRowCellValue(colFINTSS_PRE_CODE_FK_PK2, f._Code)
                GV26.SetFocusedRowCellValue(colFINTSS_CDF_TSS_CODE_FK2, f._Collection(3))
                If f._Collection(2) = "" Then
                    GV26.SetFocusedRowCellValue(colFINTSS_DATE_APPLI_PK, Now.Date)
                Else
                    GV26.SetFocusedRowCellValue(colFINTSS_DATE_APPLI_PK, f._Collection(2))
                End If
                GV26.SetFocusedRowCellValue(colFINTSS_PRE_CODE_FK_PK, f._Code)
            End If
        End If
    End Sub
    Private Sub btADDSMR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btADDSMR.Click
        Dim strSSQL_SMR As String
        strSSQL_SMR = " Select distinct "
        strSSQL_SMR &= " SPSMR_CDF_SMR_CODE_FK_PK as code ,  "
        strSSQL_SMR &= " CDF_NOM as libelle ,"
        strSSQL_SMR &= " SPSMR_DATE as val2, "
        strSSQL_SMR &= " SPSMR_SP_CODE_FK_PK as val3, "
        strSSQL_SMR &= " SPATR_ATR_CODE_FK_PK as val1 ,"
        strSSQL_SMR &= " SP_NOM as val4 "
        strSSQL_SMR &= " From THERIAQUE.SPSMR_SERVICE_MEDICAL_RENDU, "
        strSSQL_SMR &= " THERIAQUE.CDF_CODIF,"
        strSSQL_SMR &= " THERIAQUE.SP_SPECIALITE ,"
        strSSQL_SMR &= " THERIAQUE.FINSP_INDSPE,"
        strSSQL_SMR &= " THERIAQUE.SPATR_SPEC_AVISTRANSPARENCE, THERIAQUE.ATR_AVISCOMMISSIONTRANSPARENCE"
        strSSQL_SMR &= " where "
        strSSQL_SMR &= " SPSMR_SP_CODE_FK_PK =SP_CODE_SQ_PK  and "
        strSSQL_SMR &= " CDF_CODE_PK = SPSMR_CDF_SMR_CODE_FK_PK and "
        strSSQL_SMR &= " CDF_NUMERO_PK = '27'"
        strSSQL_SMR &= " and FINSP_SP_CODE_FK_PK = SPSMR_SP_CODE_FK_PK"
        strSSQL_SMR &= " and SPATR_SP_CODE_FK_PK = SPSMR_SP_CODE_FK_PK"
        strSSQL_SMR &= " and FINSP_FIN_CODE_FK_PK = " & txtCode.Text
        'strSSQL_SMR &= " AND SPATR_ATR_CODE_FK_PK IN (SELECT ATRSMR_ATR_CODE_FK_PK FROM THERIAQUE.ATRSMR_AVISCOMTRANS_SMR)"
        strSSQL_SMR &= " AND SPATR_SP_CODE_FK_PK IN(SELECT SPATR_SP_CODE_FK_PK FROM THERIAQUE.SPATR_SPEC_AVISTRANSPARENCE)"
        strSSQL_SMR &= " AND SPATR_ATR_CODE_FK_PK = ATR_CODE_SQ_PK AND SPSMR_DATE = ATR_DATE_REDACTION"


        Dim f As New Frm_Dictionnaire
        f._SSQL = strSSQL_SMR
        f.colVal1.Caption = "Avis"
        f.colVal2.Caption = "Date"
        f.colVal3.Caption = "Code spécialité"
        f.colVal4.Caption = "Spécialité"
        f.ShowDialog()
        If f._Code IsNot Nothing Then
            GV27.AddNewRow()
            GV27.SetFocusedRowCellValue(colFINSMR_SP_CODE_FK_PK, f._Collection(3))
            GV27.SetFocusedRowCellValue(colFINSMR_CDF_SMR_CODE_FK_PK, f._Code)
            GV27.SetFocusedRowCellValue(colFINSMR_DATE_SMR_PK, f._Collection(2))
            GV27.SetFocusedRowCellValue(colFINSMR_ATR_CODE_FK_PK, f._Collection(1))
        End If
        Try
            Me.BindingContext(Me.MasterDataSet, "FINSMR_INDIC_SMR_ATR").EndCurrentEdit()
        Catch ex As Exception
            Process_Message("Cette ligne est déjà présente !", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
        End Try

    End Sub

#End Region


    Private Sub lkupFIN_NAIN_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles lkupFIN_NAIN.EditValueChanging
        If e.OldValue Is DBNull.Value Then Exit Sub
        If e.OldValue = Nothing Then Exit Sub

        If e.NewValue Is DBNull.Value Then Exit Sub
        If e.NewValue = Nothing Then Exit Sub

        If NAIN_USED() Then
            e.Cancel = NAIN_USED()
            lkupFIN_NAIN.EditValue = e.OldValue
        Else
        End If
    End Sub

    Private Function NAIN_USED() As Boolean
        If OnLoading Then
            Exit Function
        End If
        Dim strNAIN As String
        If Me.BindingContext(Me.MasterDataSet, MasterTable).Current("FIN_CDF_NAIN_CODE_FK_PK") IsNot DBNull.Value Then
            strNAIN = Me.BindingContext(Me.MasterDataSet, MasterTable).Current("FIN_CDF_NAIN_CODE_FK_PK")
            Dim strSSQL As String = "Select * from THERIAQUE.FPOUT_FPOSO_UTILTH where FPOUT_CDF_UTPO_CODE_FK_PK = " & cn.SQLText(strNAIN)
            If cn.MySelect(strSSQL).Rows.Count > 0 Then
                If GetCodeFromCollection(GetCodeFromGV(GV6, colFINSP_SP_CODE_FK_PK)) <> "" Then

                    'strSSQL = " SELECT * FROM THERIAQUE.FIN_FICHEINDIC "
                    'strSSQL &= " WHERE FIN_CODE_SQ_PK = " & CodE
                    'strSSQL &= " AND FIN_CDF_NAIN_CODE_FK_PK IN (SELECT FPOUT_CDF_UTPO_CODE_FK_PK FROM THERIAQUE.FPOUT_FPOSO_UTILTH)"

                    strSSQL = "SELECT FPOSP_SP_CODE_FK_PK, FPOSP_FPO_CODE_FK_PK FROM THERIAQUE.FPOSP_POSO_SPE"
                    strSSQL &= " WHERE FPOSP_FPO_CODE_FK_PK in (SELECT FPOUT_FPO_CODE_FK_PK FROM THERIAQUE.FPOUT_FPOSO_UTILTH WHERE FPOUT_CDF_UTPO_CODE_FK_PK =" & cn.SQLText(strNAIN) & ")"
                    strSSQL &= " AND FPOSP_SP_CODE_FK_PK in (SELECT FINSP_SP_CODE_FK_PK FROM THERIAQUE.FINSP_INDSPE"
                    strSSQL &= " WHERE FINSP_FIN_CODE_FK_PK = " & Me.txtCode.Text & ")"
                    If cn.MySelect(strSSQL).Rows.Count > 0 Then
                        Me.DxErrorProvider.SetError(lkupFIN_NAIN, "Cette valeur est déjà utilisé dans la fiche posologie")
                        Return True
                    Else
                        Me.DxErrorProvider.SetError(lkupFIN_NAIN, "")
                        Return False
                    End If
                Else
                    Me.DxErrorProvider.SetError(lkupFIN_NAIN, "")
                    Return False
                End If
            Else
                Me.DxErrorProvider.SetError(lkupFIN_NAIN, "")
                Return False
            End If
        End If
    End Function

    Private Sub GV_CalcRowHeight(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs) Handles GV12.CalcRowHeight
        e.RowHeight = sender.GridControl.Height
    End Sub

    Private Sub UpdateCIP13()

        'COCONT_COMPO_CONTENANT
        Dim req As String
     

        req = "Update [Theriaque].[FINTSS_INDICATION_TAUXSECU] set FINTSS_CIP13 = ("
        req += "select t2.PRE_EAN_REF from [theriaque].[PRE_PRESENTATION] t2 where t2.PRE_CODE_PK = FINTSS_PRE_CODE_FK_PK) "
        req += " where FINTSS_FIN_CODE_FK_PK=" & txtCode.Text


        cn.Execute(req)

    End Sub

End Class
