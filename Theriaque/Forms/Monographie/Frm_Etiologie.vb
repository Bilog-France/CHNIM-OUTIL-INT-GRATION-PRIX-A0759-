''' <summary>
''' Created By [BFE]
''' </summary>
''' <remarks> Monographie - Etiologie </remarks>
Public Class Frm_Etiologie

#Region "Déclaration des variables privées"
    Private CodE As String
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
    Private bModeDuplication As Boolean = False
#End Region

#Region "Déclaration des variables public"
    Public _Code As Integer = Nothing ' charger la fiche depuis l'extérieur
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
        f._SSQL = strSSQL_FET_FICHEETIOLOGIE_SPECIALITE()
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            XtraTabControl1.SelectedTabPageIndex = 0
            OnLoading = True
            EmptyDataTable()
            Me.FeT_TA.FillByCode(Me.DsTheriaque_Etiologie.FET_FICHEETIOLOGIE, f._Code)
            If (Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CMIHS") IsNot System.DBNull.Value) Then
                TextEdit1.Text = Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CMIHS")
            End If

            If (Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CMIIS") IsNot System.DBNull.Value) Then
                TextEdit2.Text = Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CMIIS")
            Else
                TextEdit5.Text = ""
            End If

            If (Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CMIMS") IsNot System.DBNull.Value) Then
                TextEdit4.Text = Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CMIMS")
            Else
                TextEdit5.Text = ""
            End If

            If (Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CMIRE") IsNot System.DBNull.Value) Then
                TextEdit5.Text = Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CMIRE")
            Else
                TextEdit5.Text = ""
            End If

                  'Onglet 1
            Me.FetcpH_TA.FillByCode(Me.DsTheriaque_Etiologie.FETCPH_ETIOCPH, f._Code)
            Me.FetccH_TA.FillByCode(Me.DsTheriaque_Etiologie.FETCCH_ETIOCCH, f._Code)
            Me.FetpR_TA.FillByCode(Me.DsTheriaque_Etiologie.FETPR_ETIOPROD, f._Code)
            Me.FetsaC_TA.FillByCode(Me.DsTheriaque_Etiologie.FETSAC_ETIOSUBAC, f._Code)
            Me.FetsP_TA.FillByCode(Me.DsTheriaque_Etiologie.FETSP_ETIOSPE, f._Code)
            Me.FettxtI_TA.FillByCode(Me.DsTheriaque_Etiologie.FETTXTI_TEXTINTRO_CMI, f._Code)
            Tab_TA1 = False
            Tab_TA2 = False
            Tab_TA3 = False
            Tab_TA4 = False
            Tab_TA5 = False
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
        Dim sCodeEHS As String = ""
        Dim sCodeEIS As String = ""
        Dim sCodeEMS As String = ""
        Dim sCodeER As String = ""
        Dim sCodePR As String = ""
        Dim sCodeSP As String = ""
        Dim sCodeSAC As String = ""
        Dim f As New Frm_EtiologieMultiCriteres
        f.ShowDialog()
        If f._Validate Then
            If f._bEHS Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("NA")
                fDICO.Text = "Espèces habituellement sensibles"
                fDICO.ShowDialog()
                sCodeEHS = fDICO._Code
            End If
            If f._bEIS Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("NA")
                fDICO.Text = "Espèces inconstament sensibles"
                fDICO.ShowDialog()
                sCodeEIS = fDICO._Code
            End If
            If f._bEMS Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("NA")
                fDICO.Text = "Espèces modérement sensibles"
                fDICO.ShowDialog()
                sCodeEMS = fDICO._Code
            End If
            If f._bER Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("NA")
                fDICO.Text = "Espèces résistantes"
                fDICO.ShowDialog()
                sCodeER = fDICO._Code
            End If
            If f._bPR Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_PR_PRODUIT
                fDICO.Text = "Produits"
                fDICO.ShowDialog()
                sCodePR = fDICO._Code
            End If
            If f._bSP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SP_SPECIALITE
                fDICO.Text = "Spécialités"
                fDICO.ShowDialog()
                sCodeSP = fDICO._Code
            End If
            If f._bSAC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SAC_SUBACTIVE
                fDICO.Text = "Substances actives"
                fDICO.ShowDialog()
                sCodeSAC = fDICO._Code
            End If
            Dim fResultat As New Frm_Recherche
            Dim sSQL As String = ""

            sSQL &= " select FET_CODE_SQ_PK as code, '' as libelle from THERIAQUE.FET_FICHEETIOLOGIE "
            If sCodeEHS <> "" Then
                sSQL &= " WHERE FET_CODE_SQ_PK IN (SELECT FETHS_FET_CODE_FK_PK FROM THERIAQUE.FETHS_ETIOLOGIE_HABITU_SENSIB WHERE FETHS_CDF_ETIN_CODE_FK_PK = " & cn.SQLText(sCodeEHS) & ")"
            End If
            If sCodeEIS <> "" Then
                If sCodeEHS <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FET_CODE_SQ_PK IN (SELECT FETIS_FET_CODE_FK_PK FROM THERIAQUE.FETIS_ETIOLOGIE_INCONST_SENSIB WHERE FETIS_CDF_ETIN_CODE_FK_PK = " & cn.SQLText(sCodeEIS) & ")"
            End If
            If sCodeEMS <> "" Then
                If sCodeEHS <> "" Or sCodeEIS <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FET_CODE_SQ_PK IN (SELECT FETMS_FET_CODE_FK_PK FROM THERIAQUE.FETMS_ETIOLOGIE_MODEREM_SENSIB WHERE FETMS_CDF_ETIN_CODE_FK_PK = " & cn.SQLText(sCodeEMS) & ")"
            End If
            If sCodeER <> "" Then
                If sCodeEHS <> "" Or sCodeEIS <> "" Or sCodeEMS <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FET_CODE_SQ_PK IN (SELECT FETRE_FET_CODE_FK_PK FROM THERIAQUE.FETRE_ETIOLOGIE_RESISTANTES WHERE FETRE_CDF_ETIN_CODE_FK_PK = " & cn.SQLText(sCodeER) & ")"
            End If
            If sCodePR <> "" Then
                If sCodeEHS <> "" Or sCodeEIS <> "" Or sCodeEMS <> "" Or sCodeER <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FET_CODE_SQ_PK IN (SELECT FETPR_FET_CODE_FK_PK FROM THERIAQUE.FETPR_ETIOPROD WHERE FETPR_PR_CODE_FK_PK = " & cn.SQLText(sCodePR) & ")"
            End If
            If sCodeSP <> "" Then
                If sCodeEHS <> "" Or sCodeEIS <> "" Or sCodeEMS <> "" Or sCodeER <> "" Or sCodePR <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FET_CODE_SQ_PK IN (SELECT FETSP_FET_CODE_FK_PK FROM THERIAQUE.FETSP_ETIOSPE WHERE FETSP_SP_CODE_FK_PK = " & cn.SQLText(sCodeSP) & ")"
            End If
            If sCodeSAC <> "" Then
                If sCodeEHS <> "" Or sCodeEIS <> "" Or sCodeEMS <> "" Or sCodeER <> "" Or sCodePR <> "" Or sCodeSP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FET_CODE_SQ_PK IN (SELECT FETSAC_FET_CODE_FK_PK FROM THERIAQUE.FETSAC_ETIOSUBAC WHERE FETSAC_SAC_CODE_FK_PK = " & cn.SQLText(sCodeSAC) & ")"
            End If

            sSQL &= " ORDER BY FET_CODE_SQ_PK"

            fResultat._SSQL = sSQL
            fResultat.Text = Me.Text
            fResultat.ShowDialog()
            CodE = fResultat._Code
            If fResultat._Code IsNot Nothing Then

                XtraTabControl1.SelectedTabPageIndex = 0
                OnLoading = True
                EmptyDataTable()
                Me.FeT_TA.FillByCode(Me.DsTheriaque_Etiologie.FET_FICHEETIOLOGIE, fResultat._Code)
                'Onglet 1
                Me.FetcpH_TA.FillByCode(Me.DsTheriaque_Etiologie.FETCPH_ETIOCPH, fResultat._Code)
                Me.FetccH_TA.FillByCode(Me.DsTheriaque_Etiologie.FETCCH_ETIOCCH, fResultat._Code)
                Me.FetpR_TA.FillByCode(Me.DsTheriaque_Etiologie.FETPR_ETIOPROD, fResultat._Code)
                Me.FetsaC_TA.FillByCode(Me.DsTheriaque_Etiologie.FETSAC_ETIOSUBAC, fResultat._Code)
                Me.FetsP_TA.FillByCode(Me.DsTheriaque_Etiologie.FETSP_ETIOSPE, fResultat._Code)
                Me.FettxtI_TA.FillByCode(Me.DsTheriaque_Etiologie.FETTXTI_TEXTINTRO_CMI, fResultat._Code)
                Tab_TA1 = False
                Tab_TA2 = False
                Tab_TA3 = False
                Tab_TA4 = False
                Tab_TA5 = False
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
        If Tab_TA1 And Tab_TA2 And Tab_TA3 And Tab_TA4 And Tab_TA5 Then
            'Onglet Entités
            For iCount = 0 To DsTheriaque_Etiologie.FETCPH_ETIOCPH.Rows.Count - 1
                DsTheriaque_Etiologie.FETCPH_ETIOCPH.Rows(iCount).Delete()
            Next
            Me.FetcpH_TA.Update(DsTheriaque_Etiologie)

            For iCount = 0 To DsTheriaque_Etiologie.FETCCH_ETIOCCH.Rows.Count - 1
                DsTheriaque_Etiologie.FETCCH_ETIOCCH.Rows(iCount).Delete()
            Next
            Me.FetccH_TA.Update(DsTheriaque_Etiologie)

            For iCount = 0 To DsTheriaque_Etiologie.FETSP_ETIOSPE.Rows.Count - 1
                DsTheriaque_Etiologie.FETSP_ETIOSPE.Rows(iCount).Delete()
            Next
            Me.FetsP_TA.Update(DsTheriaque_Etiologie)

            For iCount = 0 To DsTheriaque_Etiologie.FETPR_ETIOPROD.Rows.Count - 1
                DsTheriaque_Etiologie.FETPR_ETIOPROD.Rows(iCount).Delete()
            Next
            Me.FetpR_TA.Update(DsTheriaque_Etiologie)

            For iCount = 0 To DsTheriaque_Etiologie.FETSAC_ETIOSUBAC.Rows.Count - 1
                DsTheriaque_Etiologie.FETSAC_ETIOSUBAC.Rows(iCount).Delete()
            Next
            Me.FetsaC_TA.Update(DsTheriaque_Etiologie)

            For iCount = 0 To DsTheriaque_Etiologie.FETTXTI_TEXTINTRO_CMI.Rows.Count - 1
                DsTheriaque_Etiologie.FETTXTI_TEXTINTRO_CMI.Rows(iCount).Delete()
            Next
            Me.FettxtI_TA.Update(DsTheriaque_Etiologie)

            'Onglet Espèces habituellement sensibles
            For iCount = 0 To DsTheriaque_Etiologie.FETHS_ETIOLOGIE_HABITU_SENSIB.Rows.Count - 1
                DsTheriaque_Etiologie.FETHS_ETIOLOGIE_HABITU_SENSIB.Rows(iCount).Delete()
            Next
            Me.FethS_TA.Update(DsTheriaque_Etiologie)

            For iCount = 0 To DsTheriaque_Etiologie.FETCHS_COMMENT_HABITU_SENSIBLE.Rows.Count - 1
                DsTheriaque_Etiologie.FETCHS_COMMENT_HABITU_SENSIBLE.Rows(iCount).Delete()
            Next
            Me.FetchS_Ta.Update(DsTheriaque_Etiologie)

            For iCount = 0 To DsTheriaque_Etiologie.FETTX1_ET_TXHS.Rows.Count - 1
                DsTheriaque_Etiologie.FETTX1_ET_TXHS.Rows(iCount).Delete()
            Next
            Me.FettxtI_TA.Update(DsTheriaque_Etiologie)

            'Onglet Espèces inconstament sensibles
            For iCount = 0 To DsTheriaque_Etiologie.FETIS_ETIOLOGIE_INCONST_SENSIB.Rows.Count - 1
                DsTheriaque_Etiologie.FETIS_ETIOLOGIE_INCONST_SENSIB.Rows(iCount).Delete()
            Next
            Me.FetiS_TA.Update(DsTheriaque_Etiologie)

            For iCount = 0 To DsTheriaque_Etiologie.FETCIS_COMMENT_INCONS_SENSIBLE.Rows.Count - 1
                DsTheriaque_Etiologie.FETCIS_COMMENT_INCONS_SENSIBLE.Rows(iCount).Delete()
            Next
            Me.FetciS_Ta.Update(DsTheriaque_Etiologie)

            For iCount = 0 To DsTheriaque_Etiologie.FETTX2_ET_TXIS.Rows.Count - 1
                DsTheriaque_Etiologie.FETTX2_ET_TXIS.Rows(iCount).Delete()
            Next
            Me.FettX2_TA.Update(DsTheriaque_Etiologie)

            'Onglet Espèces modérement sensibles
            For iCount = 0 To DsTheriaque_Etiologie.FETMS_ETIOLOGIE_MODEREM_SENSIB.Rows.Count - 1
                DsTheriaque_Etiologie.FETMS_ETIOLOGIE_MODEREM_SENSIB.Rows(iCount).Delete()
            Next
            Me.FetmS_TA.Update(DsTheriaque_Etiologie)

            For iCount = 0 To DsTheriaque_Etiologie.FETCMS_COMMENT_MODERE_SENSIBLE.Rows.Count - 1
                DsTheriaque_Etiologie.FETCMS_COMMENT_MODERE_SENSIBLE.Rows(iCount).Delete()
            Next
            Me.FetcmS_TA.Update(DsTheriaque_Etiologie)

            For iCount = 0 To DsTheriaque_Etiologie.FETTX3_ET_TXMS.Rows.Count - 1
                DsTheriaque_Etiologie.FETTX3_ET_TXMS.Rows(iCount).Delete()
            Next
            Me.FettX3_TA.Update(DsTheriaque_Etiologie)

            'Onglet Espèces résistantes
            For iCount = 0 To DsTheriaque_Etiologie.FETRE_ETIOLOGIE_RESISTANTES.Rows.Count - 1
                DsTheriaque_Etiologie.FETRE_ETIOLOGIE_RESISTANTES.Rows(iCount).Delete()
            Next
            Me.FetrE_TA.Update(DsTheriaque_Etiologie)

            For iCount = 0 To DsTheriaque_Etiologie.FETCRE_COMMENT_RESISTANTE.Rows.Count - 1
                DsTheriaque_Etiologie.FETCRE_COMMENT_RESISTANTE.Rows(iCount).Delete()
            Next
            Me.FetcrE_TA.Update(DsTheriaque_Etiologie)

            For iCount = 0 To DsTheriaque_Etiologie.FETTX4_ET_TXRE.Rows.Count - 1
                DsTheriaque_Etiologie.FETTX4_ET_TXRE.Rows(iCount).Delete()
            Next
            Me.FettX4_TA.Update(DsTheriaque_Etiologie)

            'Onglet Références officielles
            For iCount = 0 To DsTheriaque_Etiologie.FETAFS_FET_AFSSAPS.Rows.Count - 1
                DsTheriaque_Etiologie.FETAFS_FET_AFSSAPS.Rows(iCount).Delete()
            Next
            Me.FetafS_TA.Update(DsTheriaque_Etiologie)

            ' Master
            DsTheriaque_Etiologie.FET_FICHEETIOLOGIE.Rows(0).Delete()
            Me.FeT_TA.Update(Me.MasterDataSet)
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
        Dim d As Decimal
        If Not String.IsNullOrEmpty(TextEdit1.Text) Then
            If Decimal.TryParse(TextEdit1.Text, d) Then
                Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CMIHS") = d
            Else
                MsgBox("Le CMI doit etre décimal")
            End If
        Else
            Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CMIHS") = System.DBNull.Value
        End If

        If Not String.IsNullOrEmpty(TextEdit2.Text) Then
            If Decimal.TryParse(TextEdit2.Text, d) Then
                Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CMIIS") = d
            Else
                MsgBox("Le CMI doit etre décimal")
            End If
        Else
            Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CMIIS") = System.DBNull.Value
        End If

        If Not String.IsNullOrEmpty(TextEdit4.Text) Then
            If Decimal.TryParse(TextEdit4.Text, d) Then
                Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CMIMS") = d
            Else
                MsgBox("Le CMI doit etre décimal")
            End If
        Else
            Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CMIMS") = System.DBNull.Value
        End If

        If Not String.IsNullOrEmpty(TextEdit4.Text) Then
            If Decimal.TryParse(TextEdit4.Text, d) Then
                Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CMIMS") = d
            Else
                MsgBox("Le CMI doit etre décimal")
            End If
        Else
            Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CMIMS") = System.DBNull.Value
        End If

        If Not String.IsNullOrEmpty(TextEdit5.Text) Then
            If Decimal.TryParse(TextEdit5.Text, d) Then
                Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CMIRE") = d
            Else
                MsgBox("Le CMI doit etre décimal")
            End If
        Else
            Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CMIRE") = System.DBNull.Value
        End If

        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        FeT_TA.Update(Me.DsTheriaque_Etiologie.FET_FICHEETIOLOGIE)
        'Onglet entités
        Me.BindingContext(Me.MasterDataSet, FETCPH_ETIOCPH).EndCurrentEdit()
        FetcpH_TA.Update(Me.DsTheriaque_Etiologie.FETCPH_ETIOCPH)

        Me.BindingContext(Me.MasterDataSet, FETCCH_ETIOCCH).EndCurrentEdit()
        FetccH_TA.Update(Me.DsTheriaque_Etiologie.FETCCH_ETIOCCH)

        Me.BindingContext(Me.MasterDataSet, FETPR_ETIOPROD).EndCurrentEdit()
        FetpR_TA.Update(Me.DsTheriaque_Etiologie.FETPR_ETIOPROD)

        Me.BindingContext(Me.MasterDataSet, FETSAC_ETIOSUBAC).EndCurrentEdit()
        FetsaC_TA.Update(Me.DsTheriaque_Etiologie.FETSAC_ETIOSUBAC)

        Me.BindingContext(Me.MasterDataSet, FETSP_ETIOSPE).EndCurrentEdit()
        FetsP_TA.Update(Me.DsTheriaque_Etiologie.FETSP_ETIOSPE)

        Me.BindingContext(Me.MasterDataSet, FETTXTI_TEXTINTRO_CMI).EndCurrentEdit()
        FettxtI_TA.Update(Me.DsTheriaque_Etiologie.FETTXTI_TEXTINTRO_CMI)

        'Onglet Espèces habituellement sensibles
        Me.BindingContext(Me.MasterDataSet, FETHS_ETIOLOGIE_HABITU_SENSIB).EndCurrentEdit()
        FethS_TA.Update(Me.DsTheriaque_Etiologie.FETHS_ETIOLOGIE_HABITU_SENSIB)

        Me.BindingContext(Me.MasterDataSet, FETCHS_COMMENT_HABITU_SENSIBLE).EndCurrentEdit()
        FetchS_Ta.Update(Me.DsTheriaque_Etiologie.FETCHS_COMMENT_HABITU_SENSIBLE)

        Me.BindingContext(Me.MasterDataSet, FETTX1_ET_TXHS).EndCurrentEdit()
        FettX1_TA.Update(Me.DsTheriaque_Etiologie.FETTX1_ET_TXHS)

        'Onglet Espèces inconstament sensibles
        Me.BindingContext(Me.MasterDataSet, FETIS_ETIOLOGIE_INCONST_SENSIB).EndCurrentEdit()
        FetiS_TA.Update(Me.DsTheriaque_Etiologie.FETIS_ETIOLOGIE_INCONST_SENSIB)

        Me.BindingContext(Me.MasterDataSet, FETCIS_COMMENT_INCONS_SENSIBLE).EndCurrentEdit()
        FetciS_Ta.Update(Me.DsTheriaque_Etiologie.FETCIS_COMMENT_INCONS_SENSIBLE)

        Me.BindingContext(Me.MasterDataSet, FETTX2_ET_TXIS).EndCurrentEdit()
        FettX2_TA.Update(Me.DsTheriaque_Etiologie.FETTX2_ET_TXIS)

        'Onglet Espèces modérement sensibles
        Me.BindingContext(Me.MasterDataSet, FETMS_ETIOLOGIE_MODEREM_SENSIB).EndCurrentEdit()
        FetmS_TA.Update(Me.DsTheriaque_Etiologie.FETMS_ETIOLOGIE_MODEREM_SENSIB)

        Me.BindingContext(Me.MasterDataSet, FETCMS_COMMENT_MODERE_SENSIBLE).EndCurrentEdit()
        FetcmS_TA.Update(Me.DsTheriaque_Etiologie.FETCMS_COMMENT_MODERE_SENSIBLE)

        Me.BindingContext(Me.MasterDataSet, FETTX3_ET_TXMS).EndCurrentEdit()
        FettX3_TA.Update(Me.DsTheriaque_Etiologie.FETTX3_ET_TXMS)

        'Onglet Espèces résistantes
        Me.BindingContext(Me.MasterDataSet, FETRE_ETIOLOGIE_RESISTANTES).EndCurrentEdit()
        FetrE_TA.Update(Me.DsTheriaque_Etiologie.FETRE_ETIOLOGIE_RESISTANTES)

        Me.BindingContext(Me.MasterDataSet, FETCRE_COMMENT_RESISTANTE).EndCurrentEdit()
        FetcrE_TA.Update(Me.DsTheriaque_Etiologie.FETCRE_COMMENT_RESISTANTE)

        Me.BindingContext(Me.MasterDataSet, FETTX4_ET_TXRE).EndCurrentEdit()
        FettX4_TA.Update(Me.DsTheriaque_Etiologie.FETTX4_ET_TXRE)

        'Onglet Références officielles
        Me.BindingContext(Me.MasterDataSet, FETAFS_FET_AFSSAPS).EndCurrentEdit()
        FetafS_TA.Update(Me.DsTheriaque_Etiologie.FETAFS_FET_AFSSAPS)

        bModeDuplication = False
    End Sub

    ''' <summary>
    ''' Proçédure: Annulation d'un enregistrement
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub annuler()
        OnLoading = True
        MyBase.Annuler()
        Me.BindingContext(Me.MasterDataSet, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_Etiologie.FET_FICHEETIOLOGIE.RejectChanges()
        'Onglet entités
        Me.BindingContext(DsTheriaque_Etiologie, FETCPH_ETIOCPH).CancelCurrentEdit()
        Me.DsTheriaque_Etiologie.FETCPH_ETIOCPH.RejectChanges()

        Me.BindingContext(DsTheriaque_Etiologie, FETCCH_ETIOCCH).CancelCurrentEdit()
        Me.DsTheriaque_Etiologie.FETCCH_ETIOCCH.RejectChanges()

        Me.BindingContext(DsTheriaque_Etiologie, FETSP_ETIOSPE).CancelCurrentEdit()
        Me.DsTheriaque_Etiologie.FETSP_ETIOSPE.RejectChanges()

        Me.BindingContext(DsTheriaque_Etiologie, FETSAC_ETIOSUBAC).CancelCurrentEdit()
        Me.DsTheriaque_Etiologie.FETSAC_ETIOSUBAC.RejectChanges()

        Me.BindingContext(DsTheriaque_Etiologie, FETPR_ETIOPROD).CancelCurrentEdit()
        Me.DsTheriaque_Etiologie.FETPR_ETIOPROD.RejectChanges()

        Me.BindingContext(DsTheriaque_Etiologie, FETTXTI_TEXTINTRO_CMI).CancelCurrentEdit()
        Me.DsTheriaque_Etiologie.FETTXTI_TEXTINTRO_CMI.RejectChanges()

        'Onglet Espèces habituellement sensibles
        Me.BindingContext(DsTheriaque_Etiologie, FETHS_ETIOLOGIE_HABITU_SENSIB).CancelCurrentEdit()
        Me.DsTheriaque_Etiologie.FETHS_ETIOLOGIE_HABITU_SENSIB.RejectChanges()

        Me.BindingContext(DsTheriaque_Etiologie, FETCHS_COMMENT_HABITU_SENSIBLE).CancelCurrentEdit()
        Me.DsTheriaque_Etiologie.FETCHS_COMMENT_HABITU_SENSIBLE.RejectChanges()

        Me.BindingContext(DsTheriaque_Etiologie, FETTX1_ET_TXHS).CancelCurrentEdit()
        Me.DsTheriaque_Etiologie.FETTX1_ET_TXHS.RejectChanges()

        'Onglet Espèces inconstament sensibles
        Me.BindingContext(DsTheriaque_Etiologie, FETIS_ETIOLOGIE_INCONST_SENSIB).CancelCurrentEdit()
        Me.DsTheriaque_Etiologie.FETIS_ETIOLOGIE_INCONST_SENSIB.RejectChanges()

        Me.BindingContext(DsTheriaque_Etiologie, FETCIS_COMMENT_INCONS_SENSIBLE).CancelCurrentEdit()
        Me.DsTheriaque_Etiologie.FETCIS_COMMENT_INCONS_SENSIBLE.RejectChanges()

        Me.BindingContext(DsTheriaque_Etiologie, FETTX2_ET_TXIS).CancelCurrentEdit()
        Me.DsTheriaque_Etiologie.FETTX2_ET_TXIS.RejectChanges()

        'Onglet Espèces modérement sensibles
        Me.BindingContext(DsTheriaque_Etiologie, FETMS_ETIOLOGIE_MODEREM_SENSIB).CancelCurrentEdit()
        Me.DsTheriaque_Etiologie.FETMS_ETIOLOGIE_MODEREM_SENSIB.RejectChanges()

        Me.BindingContext(DsTheriaque_Etiologie, FETCMS_COMMENT_MODERE_SENSIBLE).CancelCurrentEdit()
        Me.DsTheriaque_Etiologie.FETCMS_COMMENT_MODERE_SENSIBLE.RejectChanges()

        Me.BindingContext(DsTheriaque_Etiologie, FETTX3_ET_TXMS).CancelCurrentEdit()
        Me.DsTheriaque_Etiologie.FETTX3_ET_TXMS.RejectChanges()

        'Onglet Espèces résistantes
        Me.BindingContext(DsTheriaque_Etiologie, FETRE_ETIOLOGIE_RESISTANTES).CancelCurrentEdit()
        Me.DsTheriaque_Etiologie.FETRE_ETIOLOGIE_RESISTANTES.RejectChanges()

        Me.BindingContext(DsTheriaque_Etiologie, FETCRE_COMMENT_RESISTANTE).CancelCurrentEdit()
        Me.DsTheriaque_Etiologie.FETCRE_COMMENT_RESISTANTE.RejectChanges()

        Me.BindingContext(DsTheriaque_Etiologie, FETTX4_ET_TXRE).CancelCurrentEdit()
        Me.DsTheriaque_Etiologie.FETTX4_ET_TXRE.RejectChanges()

        'Onglet Références officielles
        Me.BindingContext(DsTheriaque_Etiologie, FETAFS_FET_AFSSAPS).CancelCurrentEdit()
        Me.DsTheriaque_Etiologie.FETAFS_FET_AFSSAPS.RejectChanges()

        If bModeDuplication Then EmptyDataTable()
        bModeDuplication = False

        OnLoading = False
    End Sub


    ''' <summary>
    ''' Proçédure: Vider tous les dataset
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Private Sub EmptyDataTable()
        Me.DsTheriaque_Etiologie.FET_FICHEETIOLOGIE.Clear()
        'Onglet entités
        Me.DsTheriaque_Etiologie.FETCPH_ETIOCPH.Clear()
        Me.DsTheriaque_Etiologie.FETCCH_ETIOCCH.Clear()
        Me.DsTheriaque_Etiologie.FETSP_ETIOSPE.Clear()
        Me.DsTheriaque_Etiologie.FETSAC_ETIOSUBAC.Clear()
        Me.DsTheriaque_Etiologie.FETPR_ETIOPROD.Clear()
        Me.DsTheriaque_Etiologie.FETTXTI_TEXTINTRO_CMI.Clear()

        'Onglet Espèces habituellement sensibles
        Me.DsTheriaque_Etiologie.FETHS_ETIOLOGIE_HABITU_SENSIB.Clear()
        Me.DsTheriaque_Etiologie.FETCHS_COMMENT_HABITU_SENSIBLE.Clear()
        Me.DsTheriaque_Etiologie.FETTX1_ET_TXHS.Clear()

        'Onglet Espèces inconstament sensibles
        Me.DsTheriaque_Etiologie.FETIS_ETIOLOGIE_INCONST_SENSIB.Clear()
        Me.DsTheriaque_Etiologie.FETCIS_COMMENT_INCONS_SENSIBLE.Clear()
        Me.DsTheriaque_Etiologie.FETTX2_ET_TXIS.Clear()

        'Onglet Espèces modérement sensibles
        Me.DsTheriaque_Etiologie.FETMS_ETIOLOGIE_MODEREM_SENSIB.Clear()
        Me.DsTheriaque_Etiologie.FETCMS_COMMENT_MODERE_SENSIBLE.Clear()
        Me.DsTheriaque_Etiologie.FETTX3_ET_TXMS.Clear()

        'Onglet Espèces résistantes
        Me.DsTheriaque_Etiologie.FETRE_ETIOLOGIE_RESISTANTES.Clear()
        Me.DsTheriaque_Etiologie.FETCRE_COMMENT_RESISTANTE.Clear()
        Me.DsTheriaque_Etiologie.FETTX4_ET_TXRE.Clear()

        'Onglet Références officielles
        Me.DsTheriaque_Etiologie.FETAFS_FET_AFSSAPS.Clear()
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

        'Sauvegarde des données à duplquer

        'Onglet entités
        Dim dt11 As New DataTable
        dt11 = DsTheriaque_Etiologie.FETCPH_ETIOCPH.Copy

        Dim dt12 As New DataTable
        dt12 = DsTheriaque_Etiologie.FETCCH_ETIOCCH.Copy

        Dim dt13 As New DataTable
        dt13 = DsTheriaque_Etiologie.FETSAC_ETIOSUBAC.Copy

        Dim dt14 As New DataTable
        dt14 = DsTheriaque_Etiologie.FETPR_ETIOPROD.Copy

        Dim dt15 As New DataTable
        dt15 = DsTheriaque_Etiologie.FETSP_ETIOSPE.Copy

        Dim dt16 As New DataTable
        dt16 = DsTheriaque_Etiologie.FETTXTI_TEXTINTRO_CMI.Copy

        'Onglet Espèces habituellement sensibles
        Dim dt21 As New DataTable
        dt21 = DsTheriaque_Etiologie.FETHS_ETIOLOGIE_HABITU_SENSIB.Copy

        Dim dt22 As New DataTable
        dt22 = DsTheriaque_Etiologie.FETCHS_COMMENT_HABITU_SENSIBLE.Copy

        Dim dt23 As New DataTable
        dt23 = DsTheriaque_Etiologie.FETTX1_ET_TXHS.Copy

        Dim sText1 As String = Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CMIHS").ToString
        Dim sLkupCode1 As String = Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CDF_UDHS_CODE_FK").ToString


        'Onglet Espèces inconstament sensibles
        Dim dt31 As New DataTable
        dt31 = DsTheriaque_Etiologie.FETIS_ETIOLOGIE_INCONST_SENSIB.Copy

        Dim dt32 As New DataTable
        dt32 = DsTheriaque_Etiologie.FETCIS_COMMENT_INCONS_SENSIBLE.Copy

        Dim dt33 As New DataTable
        dt33 = DsTheriaque_Etiologie.FETTX2_ET_TXIS.Copy

        Dim sText2 As String = Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CMIIS").ToString
        Dim sLkupCode2 As String = Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CDF_UDIS_CODE_FK").ToString

        'Onglet Espèces modérement sensibles
        Dim dt41 As New DataTable
        dt41 = DsTheriaque_Etiologie.FETMS_ETIOLOGIE_MODEREM_SENSIB.Copy

        Dim dt42 As New DataTable
        dt42 = DsTheriaque_Etiologie.FETCMS_COMMENT_MODERE_SENSIBLE.Copy

        Dim dt43 As New DataTable
        dt43 = DsTheriaque_Etiologie.FETTX3_ET_TXMS.Copy

        Dim sText3 As String = Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CMIMS").ToString
        Dim sLkupCode3 As String = Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CDF_UDMS_CODE_FK").ToString


        'Onglet Espèces résistantes
        Dim dt51 As New DataTable
        dt51 = DsTheriaque_Etiologie.FETRE_ETIOLOGIE_RESISTANTES.Copy

        Dim dt52 As New DataTable
        dt52 = DsTheriaque_Etiologie.FETCRE_COMMENT_RESISTANTE.Copy

        Dim dt53 As New DataTable
        dt53 = DsTheriaque_Etiologie.FETTX4_ET_TXRE.Copy

        Dim dt54 As New DataTable
        dt54 = DsTheriaque_Etiologie.FETAFS_FET_AFSSAPS.Copy


        Dim sText4 As String = Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CMIRE").ToString
        Dim sLkupCode4 As String = Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CDF_UDRE_CODE_FK").ToString


        'Vider les contrôles
        EmptyDataTable()

        'Construction de la nouvelle fiche avec les données de la fiche de base
        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        SetCode_MAx(MasterTable, txtCode)
        CodE = InvalideControl

        ''Pour les textes gridview
        'If dt23.Rows.Count > 0 Then dt23.Rows(0)("FETTX1_FET_CODE_FK_PK") = Me.txtCode.Text
        'If dt33.Rows.Count > 0 Then dt33.Rows(0)("FETTX2_FET_CODE_FK_PK") = Me.txtCode.Text
        'If dt43.Rows.Count > 0 Then dt43.Rows(0)("FETTX3_FET_CODE_FK_PK") = Me.txtCode.Text
        'If dt53.Rows.Count > 0 Then dt53.Rows(0)("FETTX4_FET_CODE_FK_PK") = Me.txtCode.Text

        Dim drTemp As DataRow
        For iCount As Integer = 0 To dt11.Rows.Count - 1
            drTemp = DsTheriaque_Etiologie.Tables("FETCPH_ETIOCPH").NewRow()
            drTemp.ItemArray = dt11.Rows(iCount).ItemArray
            DsTheriaque_Etiologie.Tables("FETCPH_ETIOCPH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt12.Rows.Count - 1
            drTemp = DsTheriaque_Etiologie.Tables("FETCCH_ETIOCCH").NewRow()
            drTemp.ItemArray = dt12.Rows(iCount).ItemArray
            DsTheriaque_Etiologie.Tables("FETCCH_ETIOCCH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt13.Rows.Count - 1
            drTemp = DsTheriaque_Etiologie.Tables("FETSAC_ETIOSUBAC").NewRow()
            drTemp.ItemArray = dt13.Rows(iCount).ItemArray
            DsTheriaque_Etiologie.Tables("FETSAC_ETIOSUBAC").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt14.Rows.Count - 1
            drTemp = DsTheriaque_Etiologie.Tables("FETPR_ETIOPROD").NewRow()
            drTemp.ItemArray = dt14.Rows(iCount).ItemArray
            DsTheriaque_Etiologie.Tables("FETPR_ETIOPROD").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt15.Rows.Count - 1
            drTemp = DsTheriaque_Etiologie.Tables("FETSP_ETIOSPE").NewRow()
            drTemp.ItemArray = dt15.Rows(iCount).ItemArray
            DsTheriaque_Etiologie.Tables("FETSP_ETIOSPE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt16.Rows.Count - 1
            drTemp = DsTheriaque_Etiologie.Tables("FETTXTI_TEXTINTRO_CMI").NewRow()
            drTemp.ItemArray = dt16.Rows(iCount).ItemArray
            DsTheriaque_Etiologie.Tables("FETTXTI_TEXTINTRO_CMI").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt21.Rows.Count - 1
            drTemp = DsTheriaque_Etiologie.Tables("FETHS_ETIOLOGIE_HABITU_SENSIB").NewRow()
            drTemp.ItemArray = dt21.Rows(iCount).ItemArray
            DsTheriaque_Etiologie.Tables("FETHS_ETIOLOGIE_HABITU_SENSIB").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt22.Rows.Count - 1
            drTemp = DsTheriaque_Etiologie.Tables("FETCHS_COMMENT_HABITU_SENSIBLE").NewRow()
            drTemp.ItemArray = dt22.Rows(iCount).ItemArray
            DsTheriaque_Etiologie.Tables("FETCHS_COMMENT_HABITU_SENSIBLE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt23.Rows.Count - 1
            drTemp = DsTheriaque_Etiologie.Tables("FETTX1_ET_TXHS").NewRow()
            drTemp.ItemArray = dt23.Rows(iCount).ItemArray
            DsTheriaque_Etiologie.Tables("FETTX1_ET_TXHS").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt31.Rows.Count - 1
            drTemp = DsTheriaque_Etiologie.Tables("FETIS_ETIOLOGIE_INCONST_SENSIB").NewRow()
            drTemp.ItemArray = dt31.Rows(iCount).ItemArray
            DsTheriaque_Etiologie.Tables("FETIS_ETIOLOGIE_INCONST_SENSIB").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt32.Rows.Count - 1
            drTemp = DsTheriaque_Etiologie.Tables("FETCIS_COMMENT_INCONS_SENSIBLE").NewRow()
            drTemp.ItemArray = dt32.Rows(iCount).ItemArray
            DsTheriaque_Etiologie.Tables("FETCIS_COMMENT_INCONS_SENSIBLE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt33.Rows.Count - 1
            drTemp = DsTheriaque_Etiologie.Tables("FETTX2_ET_TXIS").NewRow()
            drTemp.ItemArray = dt33.Rows(iCount).ItemArray
            DsTheriaque_Etiologie.Tables("FETTX2_ET_TXIS").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt41.Rows.Count - 1
            drTemp = DsTheriaque_Etiologie.Tables("FETMS_ETIOLOGIE_MODEREM_SENSIB").NewRow()
            drTemp.ItemArray = dt41.Rows(iCount).ItemArray
            DsTheriaque_Etiologie.Tables("FETMS_ETIOLOGIE_MODEREM_SENSIB").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt42.Rows.Count - 1
            drTemp = DsTheriaque_Etiologie.Tables("FETCMS_COMMENT_MODERE_SENSIBLE").NewRow()
            drTemp.ItemArray = dt42.Rows(iCount).ItemArray
            DsTheriaque_Etiologie.Tables("FETCMS_COMMENT_MODERE_SENSIBLE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt43.Rows.Count - 1
            drTemp = DsTheriaque_Etiologie.Tables("FETTX3_ET_TXMS").NewRow()
            drTemp.ItemArray = dt43.Rows(iCount).ItemArray
            DsTheriaque_Etiologie.Tables("FETTX3_ET_TXMS").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt51.Rows.Count - 1
            drTemp = DsTheriaque_Etiologie.Tables("FETRE_ETIOLOGIE_RESISTANTES").NewRow()
            drTemp.ItemArray = dt51.Rows(iCount).ItemArray
            DsTheriaque_Etiologie.Tables("FETRE_ETIOLOGIE_RESISTANTES").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt52.Rows.Count - 1
            drTemp = DsTheriaque_Etiologie.Tables("FETCRE_COMMENT_RESISTANTE").NewRow()
            drTemp.ItemArray = dt52.Rows(iCount).ItemArray
            DsTheriaque_Etiologie.Tables("FETCRE_COMMENT_RESISTANTE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt54.Rows.Count - 1
            drTemp = DsTheriaque_Etiologie.Tables("FETAFS_FET_AFSSAPS").NewRow()
            drTemp.ItemArray = dt54.Rows(iCount).ItemArray
            DsTheriaque_Etiologie.Tables("FETAFS_FET_AFSSAPS").Rows.Add(drTemp)
        Next



        If sText1 <> "" Then Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CMIHS") = sText1
        If sLkupCode1 <> "" Then Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CDF_UDHS_CODE_FK") = sLkupCode1

        If sText2 <> "" Then Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CMIIS") = sText2
        If sLkupCode2 <> "" Then Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CDF_UDIS_CODE_FK") = sLkupCode2

        If sText3 <> "" Then Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CMIMS") = sText3
        If sLkupCode3 <> "" Then Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CDF_UDMS_CODE_FK") = sLkupCode3

        If sText4 <> "" Then Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CMIRE") = sText4
        If sLkupCode4 <> "" Then Me.BindingContext(DsTheriaque_Etiologie, FET_FICHEETIOLOGIE).Current("FET_CDF_UDRE_CODE_FK") = sLkupCode4

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
            GV11.SetRowCellValue(iCount, colFETCPH_FET_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV12
        For iCount As Integer = 0 To GV12.RowCount - 1
            GV12.SetRowCellValue(iCount, colFETCCH_FET_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV13
        For iCount As Integer = 0 To GV13.RowCount - 1
            GV13.SetRowCellValue(iCount, colFETSAC_FET_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV14
        For iCount As Integer = 0 To GV14.RowCount - 1
            GV14.SetRowCellValue(iCount, colFETPR_FET_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV15
        For iCount As Integer = 0 To GV15.RowCount - 1
            GV15.SetRowCellValue(iCount, colFETSP_FET_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV16
        For iCount As Integer = 0 To GV16.RowCount - 1
            GV16.SetRowCellValue(iCount, colFETTXTI_FET_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV21
        For iCount As Integer = 0 To GV21.RowCount - 1
            GV21.SetRowCellValue(iCount, colFETHS_FET_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV22
        For iCount As Integer = 0 To GV22.RowCount - 1
            GV22.SetRowCellValue(iCount, colFETCHS_FET_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV23
        For iCount As Integer = 0 To GV23.RowCount - 1
            GV23.SetRowCellValue(iCount, colFETTX1_FET_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV31
        For iCount As Integer = 0 To GV31.RowCount - 1
            GV31.SetRowCellValue(iCount, colFETIS_FET_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV32
        For iCount As Integer = 0 To GV32.RowCount - 1
            GV32.SetRowCellValue(iCount, colFETCIS_FET_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV33
        For iCount As Integer = 0 To GV33.RowCount - 1
            GV33.SetRowCellValue(iCount, colFETTX2_FET_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV41
        For iCount As Integer = 0 To GV41.RowCount - 1
            GV41.SetRowCellValue(iCount, colFETMS_FET_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV42
        For iCount As Integer = 0 To GV42.RowCount - 1
            GV42.SetRowCellValue(iCount, colFETCMS_FET_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV43
        For iCount As Integer = 0 To GV43.RowCount - 1
            GV43.SetRowCellValue(iCount, colFETTX3_FET_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV51
        For iCount As Integer = 0 To GV51.RowCount - 1
            GV51.SetRowCellValue(iCount, colFETRE_FET_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV52
        For iCount As Integer = 0 To GV52.RowCount - 1
            GV52.SetRowCellValue(iCount, colFETCRE_FET_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV53
        For iCount As Integer = 0 To GV53.RowCount - 1
            GV53.SetRowCellValue(iCount, colFETTX4_FET_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV
        For iCount As Integer = 0 To GV.RowCount - 1
            GV.SetRowCellValue(iCount, colFETAFS_FET_CODE_FK_PK, Me.txtCode.Text)
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
        For iCount As Integer = 0 To GV23.RowCount - 1
            If Not FieldExistRO(GV15, colFETSP_SP_CODE_FK_PK, GV.GetRowCellValue(iCount, colFETAFS_SP_CODE_FK_PK)) Then
                GV.FocusedRowHandle = iCount
                GV.SetColumnError(colFETAFS_SP_CODE_FK_PK, "La spécialité doit être présente dans la fiche.")
                XtraTabControl1.SelectedTabPageIndex = 1
                Exit Function
            Else
                GV.SetColumnError(colFETAFS_SP_CODE_FK_PK, "")
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
        GC11.DataSource = DsTheriaque_Etiologie
        GC11.DataMember = FETCPH_ETIOCPH

        GC12.DataSource = DsTheriaque_Etiologie
        GC12.DataMember = FETCCH_ETIOCCH

        GC13.DataSource = DsTheriaque_Etiologie
        GC13.DataMember = FETSAC_ETIOSUBAC

        GC14.DataSource = DsTheriaque_Etiologie
        GC14.DataMember = FETPR_ETIOPROD

        GC15.DataSource = DsTheriaque_Etiologie
        GC15.DataMember = FETSP_ETIOSPE

        GC16.DataSource = DsTheriaque_Etiologie
        GC16.DataMember = FETTXTI_TEXTINTRO_CMI

        'Onglet Espèces habituellement sensibles

        GC21.DataSource = DsTheriaque_Etiologie
        GC21.DataMember = FETHS_ETIOLOGIE_HABITU_SENSIB

        GC22.DataSource = DsTheriaque_Etiologie
        GC22.DataMember = FETCHS_COMMENT_HABITU_SENSIBLE

        GC23.DataSource = DsTheriaque_Etiologie
        GC23.DataMember = FETTX1_ET_TXHS

        'Onglet Espèces inconstament sensibles
        GC31.DataSource = DsTheriaque_Etiologie
        GC31.DataMember = FETIS_ETIOLOGIE_INCONST_SENSIB

        GC32.DataSource = DsTheriaque_Etiologie
        GC32.DataMember = FETCIS_COMMENT_INCONS_SENSIBLE

        GC33.DataSource = DsTheriaque_Etiologie
        GC33.DataMember = FETTX2_ET_TXIS

        'Onglet Espèces modérement sensibles
        GC41.DataSource = DsTheriaque_Etiologie
        GC41.DataMember = FETMS_ETIOLOGIE_MODEREM_SENSIB

        GC42.DataSource = DsTheriaque_Etiologie
        GC42.DataMember = FETCMS_COMMENT_MODERE_SENSIBLE

        GC43.DataSource = DsTheriaque_Etiologie
        GC43.DataMember = FETTX3_ET_TXMS

        'Onglet Espèces résistantes
        GC51.DataSource = DsTheriaque_Etiologie
        GC51.DataMember = FETRE_ETIOLOGIE_RESISTANTES

        GC52.DataSource = DsTheriaque_Etiologie
        GC52.DataMember = FETCRE_COMMENT_RESISTANTE

        GC53.DataSource = DsTheriaque_Etiologie
        GC53.DataMember = FETTX4_ET_TXRE

        'Onglet Références officielles
        GC.DataSource = DsTheriaque_Etiologie
        GC.DataMember = FETAFS_FET_AFSSAPS

    End Sub

    ''' <summary>
    ''' Proçédure: Initialisation des données
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub InitData()
        MyBase.InitData()
        Declinaison_Global = True
        OnLoading = True
        MasterDataSet = Me.DsTheriaque_Etiologie
        MasterTable = FET_FICHEETIOLOGIE
        CodE = InvalideControl

        'Déclinaison classe CPH
        Dim List1 As New System.Collections.Generic.List(Of StructGVTable)
        List1.Add(New StructGVTable("GC11", eDeclinaison.CPH, colFETCPH_CPH_CODE_FK_PK2))
        List1.Add(New StructGVTable("GC12", eDeclinaison.CCH, colFETCCH_CCH_CODE_FK_PK2))
        List1.Add(New StructGVTable("GC13", eDeclinaison.SAC, colFETSAC_SAC_CODE_FK_PK2))
        List1.Add(New StructGVTable("GC15", eDeclinaison.SP, colFETSP_SP_CODE_FK_PK2))
        Dim DecCPH As New ClsDeclinaison(eDeclinaison.CPH, List1)
        InitLkup(Me.lkup_FETCPH, FETCPH_ETIOCPH, strSSQL_CPH_CLASSEPHARMTHER_NIVEAU, True, , , , , , DecCPH)

        'Déclinaison classe CCH
        InitLkup(Me.lkup_FETCCH, FETCCH_ETIOCCH, strSSQL_CCH_CLASSECHIMIQUE_NIVEAU, True, , , , , , DecCPH)

        'Déclinaison SUBAC
        Dim List2 As New System.Collections.Generic.List(Of StructGVTable)
        List2.Add(New StructGVTable("GC13", eDeclinaison.SAC, colFETSAC_SAC_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC15", eDeclinaison.SP, colFETSP_SP_CODE_FK_PK2))
        Dim DecSUBAC As New ClsDeclinaison(eDeclinaison.SAC, List2)
        InitLkup(Me.lkup_FETSAC, FETSAC_ETIOSUBAC, strSSQL_SAC_SUBACTIVE, True, , , , , , DecSUBAC)

        'Déclinaison PRODUIT
        Dim List3 As New System.Collections.Generic.List(Of StructGVTable)
        List3.Add(New StructGVTable("GC14", eDeclinaison.PR, colFETPR_PR_CODE_FK_PK2))
        List3.Add(New StructGVTable("GC15", eDeclinaison.SP, colFETSP_SP_CODE_FK_PK2))
        Dim DecPR As New ClsDeclinaison(eDeclinaison.PR, List3)
        InitLkup(Me.lkup_FETPR, FETPR_ETIOPROD, strSSQL_PR_PRODUIT, True, , , , , , DecPR)

        InitLkup(Me.lkup_FETSP, FETSP_ETIOSPE, strSSQL_SP_SPECIALITE, True)
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
        Me.FeT_TA.FillByCode(Me.DsTheriaque_Etiologie.FET_FICHEETIOLOGIE, CodE1)
        'Onglet 1
        Me.FetcpH_TA.FillByCode(Me.DsTheriaque_Etiologie.FETCPH_ETIOCPH, CodE1)
        Me.FetccH_TA.FillByCode(Me.DsTheriaque_Etiologie.FETCCH_ETIOCCH, CodE1)
        Me.FetpR_TA.FillByCode(Me.DsTheriaque_Etiologie.FETPR_ETIOPROD, CodE1)
        Me.FetsaC_TA.FillByCode(Me.DsTheriaque_Etiologie.FETSAC_ETIOSUBAC, CodE1)
        Me.FetsP_TA.FillByCode(Me.DsTheriaque_Etiologie.FETSP_ETIOSPE, CodE1)
        Me.FettxtI_TA.FillByCode(Me.DsTheriaque_Etiologie.FETTXTI_TEXTINTRO_CMI, CodE1)
        Tab_TA1 = False
        Tab_TA2 = False
        Tab_TA3 = False
        Tab_TA4 = False
        Tab_TA5 = False
        OnLoading = False
    End Sub

#End Region

#Region " Chargement par onglet "

    ''' <summary>
    ''' Proçédure: Chargement du premier onglet
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadTab_1()
        'Onglet Espèces habituellement sensibles
        Load_On(Me)
        OnLoading = True
        If Not Tab_lkup1 Then
            InitLkup(Me.lkup_FETHS, FETHS_ETIOLOGIE_HABITU_SENSIB, strSSQL_CDF_CODIF_NIVEAU("NA"), True)
            InitLkup(Me.LookUp_FET, CDF_CODIF, strSSQL_CDF_CODIF("19"), True)
            InitLkup(Me.lkup_FETCHS, CDF_CODIF, strSSQL_CDF_CODIF("NC", " and substring(CDF_CODE_PK, 1, 1) =  'E'"), True)
            Tab_lkup1 = True
        End If
        If Not Tab_TA1 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.FethS_TA.FillByCode(Me.DsTheriaque_Etiologie.FETHS_ETIOLOGIE_HABITU_SENSIB, CodE)
            Me.FetchS_Ta.FillByCode(Me.DsTheriaque_Etiologie.FETCHS_COMMENT_HABITU_SENSIBLE, CodE)
            Me.FettX1_TA.FillByCode(Me.DsTheriaque_Etiologie.FETTX1_ET_TXHS, CodE)
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
        'Onglet Espèces inconstament sensibles
        Load_On(Me)
        OnLoading = True
        If Not Tab_lkup2 Then
            InitLkup(Me.lkup_FETIS, FETIS_ETIOLOGIE_INCONST_SENSIB, strSSQL_CDF_CODIF_NIVEAU("NA"), True)
            InitLkup(Me.lkup_FETCIS, FETCIS_COMMENT_INCONS_SENSIBLE, strSSQL_CDF_CODIF("NC", " and substring(CDF_CODE_PK, 1, 1) =  'E'"), True)
            InitLkup(Me.LookUp_FETCIS, CDF_CODIF, strSSQL_CDF_CODIF("19"), True)

            Tab_lkup2 = True
        End If
        If Not Tab_TA2 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.FetiS_TA.FillByCode(Me.DsTheriaque_Etiologie.FETIS_ETIOLOGIE_INCONST_SENSIB, CodE)
            Me.FetciS_Ta.FillByCode(Me.DsTheriaque_Etiologie.FETCIS_COMMENT_INCONS_SENSIBLE, CodE)
            Me.FettX2_TA.FillByCode(Me.DsTheriaque_Etiologie.FETTX2_ET_TXIS, CodE)
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
        'Onglet Espèces modérement sensibles
        Load_On(Me)
        OnLoading = True
        If Not Tab_lkup3 Then
            InitLkup(Me.lkup_FETMS, FETMS_ETIOLOGIE_MODEREM_SENSIB, strSSQL_CDF_CODIF_NIVEAU("NA"), True)
            InitLkup(Me.lkup_FETCMS, FETCMS_COMMENT_MODERE_SENSIBLE, strSSQL_CDF_CODIF("NC", " and substring(CDF_CODE_PK, 1, 1) =  'E'"), True)
            InitLkup(Me.LookUp_FETCMS, CDF_CODIF, strSSQL_CDF_CODIF("19"), True)
            Tab_lkup3 = True
        End If
        If Not Tab_TA3 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.FetmS_TA.FillByCode(Me.DsTheriaque_Etiologie.FETMS_ETIOLOGIE_MODEREM_SENSIB, CodE)
            Me.FetcmS_TA.FillByCode(Me.DsTheriaque_Etiologie.FETCMS_COMMENT_MODERE_SENSIBLE, CodE)
            Me.FettX3_TA.FillByCode(Me.DsTheriaque_Etiologie.FETTX3_ET_TXMS, CodE)
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
        'Onglet Espèces modérement résistantes
        Load_On(Me)
        OnLoading = True
        If Not Tab_lkup4 Then
            InitLkup(Me.lkup_FETRE, FETRE_ETIOLOGIE_RESISTANTES, strSSQL_CDF_CODIF_NIVEAU("NA"), True)
            InitLkup(Me.lkup_FETCRE, FETCRE_COMMENT_RESISTANTE, strSSQL_CDF_CODIF("NC", " and substring(CDF_CODE_PK, 1, 1) =  'E'"), True)
            InitLkup(Me.LookUp_FETRE, CDF_CODIF, strSSQL_CDF_CODIF("19"), True)
            Tab_lkup4 = True
        End If
        If Not Tab_TA4 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.FetrE_TA.FillByCode(Me.DsTheriaque_Etiologie.FETRE_ETIOLOGIE_RESISTANTES, CodE)
            Me.FetcrE_TA.FillByCode(Me.DsTheriaque_Etiologie.FETCRE_COMMENT_RESISTANTE, CodE)
            Me.FettX4_TA.FillByCode(Me.DsTheriaque_Etiologie.FETTX4_ET_TXRE, CodE)
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
        'Onglet Références officielles
        Load_On(Me)
        OnLoading = True
        If CodE <> InvalideControl And CodE <> Nothing Then
            Dim strSSQL_SP_REF As String
            strSSQL_SP_REF = " SELECT SP_CODE_SQ_PK as code, SP_NOM as libelle FROM THERIAQUE.FETSP_ETIOSPE, THERIAQUE.SP_SPECIALITE"
            strSSQL_SP_REF &= " WHERE FETSP_FET_CODE_FK_PK = " & CodE
            strSSQL_SP_REF &= " AND SP_CODE_SQ_PK = FETSP_SP_CODE_FK_PK"
            InitLkup(Me.lkup_SPAFS, FETAFS_FET_AFSSAPS, strSSQL_SP_REF, True)
            For iCount As Integer = 0 To GV.RowCount
                If GV.GetRowCellDisplayText(iCount, "FETAFS_SP_CODE_FK_PK") = "" And GV.GetRowCellDisplayText(iCount, "FETAFS_FET_CODE_FK_PK") <> "" Then
                    GV.DeleteRow(iCount)
                    iCount = iCount - 1
                End If
            Next
        End If
        If Not Tab_lkup5 Then
            InitLkup(Me.lkup_FETAFS, FETAFS_FET_AFSSAPS, strSSQL_CDF_CODIF("25"), True)
            Tab_lkup5 = True
        End If
        If Not Tab_TA5 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.FetafS_TA.FillByCode(Me.DsTheriaque_Etiologie.FETAFS_FET_AFSSAPS, CodE)
            Tab_TA5 = True
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
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
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
    End Sub

#End Region

#Region " New Row "
    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV11</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV11_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV11.InitNewRow
        If OnLoading Then Exit Sub
        GV11.SetFocusedRowCellValue(colFETCPH_FET_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV12</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV12_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV12.InitNewRow
        If OnLoading Then Exit Sub
        GV12.SetFocusedRowCellValue(colFETCCH_FET_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV13</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV13_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV13.InitNewRow
        If OnLoading Then Exit Sub
        GV13.SetFocusedRowCellValue(colFETSAC_FET_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV14</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV14_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV14.InitNewRow
        If OnLoading Then Exit Sub
        GV14.SetFocusedRowCellValue(colFETPR_FET_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV15</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV15_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV15.InitNewRow
        If OnLoading Then Exit Sub
        GV15.SetFocusedRowCellValue(colFETSP_FET_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV16</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV16_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV16.InitNewRow
        If OnLoading Then Exit Sub
        GV16.SetFocusedRowCellValue(colFETTXTI_FET_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV21</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV21_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV21.InitNewRow
        If OnLoading Then Exit Sub
        GV21.SetFocusedRowCellValue(colFETHS_FET_CODE_FK_PK, txtCode.Text)

    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV22</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV22_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV22.InitNewRow
        If OnLoading Then Exit Sub
        GV22.SetFocusedRowCellValue(colFETCHS_FET_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV31</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV31_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV31.InitNewRow
        If OnLoading Then Exit Sub
        GV31.SetFocusedRowCellValue(colFETIS_FET_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV32</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV32_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV32.InitNewRow
        If OnLoading Then Exit Sub
        GV32.SetFocusedRowCellValue(colFETCIS_FET_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV41</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV41_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV41.InitNewRow
        If OnLoading Then Exit Sub
        GV41.SetFocusedRowCellValue(colFETMS_FET_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV42</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV42_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV42.InitNewRow
        If OnLoading Then Exit Sub
        GV42.SetFocusedRowCellValue(colFETCMS_FET_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV51</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV51_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV51.InitNewRow
        If OnLoading Then Exit Sub
        GV51.SetFocusedRowCellValue(colFETRE_FET_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV52</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV52_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV52.InitNewRow
        If OnLoading Then Exit Sub
        GV52.SetFocusedRowCellValue(colFETCRE_FET_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        If OnLoading Then Exit Sub
        GV.SetFocusedRowCellValue(colFETAFS_FET_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV23</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV23_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV23.InitNewRow
        If OnLoading Then Exit Sub
        Me.GV23.SetFocusedRowCellValue(Me.colFETTX1_FET_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV33</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV33_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV33.InitNewRow
        Me.GV33.SetFocusedRowCellValue(Me.colFETTX2_FET_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV43</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV43_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV43.InitNewRow
        Me.GV43.SetFocusedRowCellValue(Me.colFETTX3_FET_CODE_FK_PK, txtCode.Text)
        'If GV43.RowCount >= 0 Then
        '    GV43.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
        'End If
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV53</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV53_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV53.InitNewRow
        Me.GV53.SetFocusedRowCellValue(Me.colFETTX4_FET_CODE_FK_PK, txtCode.Text)
    End Sub

#End Region

#Region " Validating "

    ''' <summary>
    ''' Evénement: Validation de la saisie
    ''' </summary>
    ''' <param name="sender">TextEdit1</param>
    ''' <param name="e">Validated</param>
    ''' <remarks></remarks>
    Private Sub TextEdit1_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit1.Validated

       
        If ModeFiche = eMode.Ajout Or ModeFiche = eMode.Duplication Then
            If TextEdit1.Text <> "" And LookUp_FET.Text = "" Then
                LookUp_FET.ItemIndex = 0
            End If
            If TextEdit1.Text <> "" Then
                If Convert.ToInt32(TextEdit1.Text) < 1 Then
                    Me.DxErrorProvider.SetError(TextEdit1, "La concentration minimale inhibitrice doit être >= 1 !")
                End If
            End If
            If LookUp_FET.Text <> "" And TextEdit1.Text <> "" Then
                If Convert.ToInt32(TextEdit1.Text) > 0 Then
                    Me.DxErrorProvider.SetError(TextEdit1, "")
                End If
            End If

        End If
    End Sub

    ''' <summary>
    ''' Evénement: Validation de la saisie
    ''' </summary>
    ''' <param name="sender">LookUp_FET</param>
    ''' <param name="e">Validated</param>
    ''' <remarks></remarks>
    Private Sub LookUp_FET_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LookUp_FET.Validated
        If LookUp_FET.Text <> "" And TextEdit1.Text <> "" Then
            Me.DxErrorProvider.SetError(LookUp_FET, "")
        End If
        If TextEdit1.Text = "" Then
            Me.DxErrorProvider.SetError(TextEdit1, "Veuillez saisir une concentration minimale inhibitrice !")
        End If

    End Sub

    ''' <summary>
    ''' Evénement: Validation de la saisie
    ''' </summary>
    ''' <param name="sender">TextEdit2</param>
    ''' <param name="e">Validated</param>
    ''' <remarks></remarks>
    Private Sub TextEdit2_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit2.Validated
        If ModeFiche = eMode.Ajout Or ModeFiche = eMode.Duplication Then
            If TextEdit2.Text <> "" And LookUp_FETCIS.Text = "" Then
                LookUp_FETCIS.ItemIndex = 0
            End If
            If TextEdit2.Text <> "" Then
                If Convert.ToInt32(TextEdit2.Text) < 1 Then
                    Me.DxErrorProvider.SetError(TextEdit2, "La concentration minimale inhibitrice doit être >= 1 !")
                End If
            End If
            If LookUp_FETCIS.Text <> "" And TextEdit2.Text <> "" Then
                If Convert.ToInt32(TextEdit2.Text) > 0 Then
                    Me.DxErrorProvider.SetError(TextEdit2, "")
                End If
            End If

        End If
    End Sub

    ''' <summary>
    ''' Evénement: Validation de la saisie
    ''' </summary>
    ''' <param name="sender">LookUp_FETCIS</param>
    ''' <param name="e">Validated</param>
    ''' <remarks></remarks>
    Private Sub LookUp_FETCIS_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LookUp_FETCIS.Validated
        If LookUp_FETCIS.Text <> "" And TextEdit2.Text <> "" Then
            Me.DxErrorProvider.SetError(LookUp_FETCIS, "")
        End If
        If TextEdit2.Text = "" Then
            Me.DxErrorProvider.SetError(TextEdit2, "Veuillez saisir une concentration minimale inhibitrice !")
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Validation de la saisie
    ''' </summary>
    ''' <param name="sender">TextEdit4</param>
    ''' <param name="e">Validated</param>
    ''' <remarks></remarks>
    Private Sub TextEdit4_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit4.Validated
        If ModeFiche = eMode.Ajout Or ModeFiche = eMode.Duplication Then
            If TextEdit4.Text <> "" And LookUp_FETCMS.Text = "" Then
                LookUp_FETCMS.ItemIndex = 0
            End If
            If TextEdit4.Text <> "" Then
                If Convert.ToInt32(TextEdit4.Text) < 1 Then
                    Me.DxErrorProvider.SetError(TextEdit4, "La concentration minimale inhibitrice doit être >= 1 !")
                End If
            End If
            If LookUp_FETCMS.Text <> "" And TextEdit4.Text <> "" Then
                If Convert.ToInt32(TextEdit4.Text) > 0 Then
                    Me.DxErrorProvider.SetError(TextEdit4, "")
                End If
            End If

        End If
    End Sub

    ''' <summary>
    ''' Evénement: Validation de la saisie
    ''' </summary>
    ''' <param name="sender">LookUp_FETCMS</param>
    ''' <param name="e">Validated</param>
    ''' <remarks></remarks>
    Private Sub LookUp_FETCMS_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LookUp_FETCMS.Validated
        If LookUp_FETCMS.Text <> "" And TextEdit4.Text <> "" Then
            Me.DxErrorProvider.SetError(LookUp_FETCMS, "")
        End If
        If TextEdit4.Text = "" Then
            Me.DxErrorProvider.SetError(TextEdit4, "Veuillez saisir une concentration minimale inhibitrice !")
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Validation de la saisie
    ''' </summary>
    ''' <param name="sender">TextEdit5</param>
    ''' <param name="e">Validated</param>
    ''' <remarks></remarks>
    Private Sub TextEdit5_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit5.Validated
        If ModeFiche = eMode.Ajout Or ModeFiche = eMode.Duplication Then
            If TextEdit5.Text <> "" And LookUp_FETRE.Text = "" Then
                LookUp_FETRE.ItemIndex = 0
            End If
            If TextEdit5.Text <> "" Then
                If Convert.ToInt32(TextEdit5.Text) < 1 Then
                    Me.DxErrorProvider.SetError(TextEdit5, "La concentration minimale inhibitrice doit être >= 1 !")
                End If
            End If
            If LookUp_FETRE.Text <> "" And TextEdit5.Text <> "" Then
                If Convert.ToInt32(TextEdit5.Text) > 0 Then
                    Me.DxErrorProvider.SetError(TextEdit5, "")
                End If
            End If

        End If
    End Sub

    ''' <summary>
    ''' Evénement: Validation de la saisie
    ''' </summary>
    ''' <param name="sender">LookUp_FETRE</param>
    ''' <param name="e">Validated</param>
    ''' <remarks></remarks>
    Private Sub LookUp_FETRE_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LookUp_FETRE.Validated
        If LookUp_FETRE.Text <> "" And TextEdit5.Text <> "" Then
            Me.DxErrorProvider.SetError(LookUp_FETRE, "")
        End If
        If TextEdit5.Text = "" Then
            Me.DxErrorProvider.SetError(TextEdit5, "Veuillez saisir une concentration minimale inhibitrice !")
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Validation d'une ligne
    ''' </summary>
    ''' <param name="sender">GV21</param>
    ''' <param name="e">ValidateRow</param>
    ''' <remarks></remarks>
    Private Sub GV21_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV21.ValidateRow
        For iCount As Integer = 0 To GV31.RowCount - 1
            If GV31.GetRowCellValue(iCount, colFETIS_CDF_ETIN_CODE_FK_PK2) = GV21.GetFocusedRowCellValue(colFETHS_CDF_ETIN_CODE_FK_PK2) Then
                e.ErrorText = "Espèce doit être diffèrent des espéces inconstamment sensibles !"
                e.Valid = False
            End If
        Next
        For iCount As Integer = 0 To GV41.RowCount - 1
            If GV41.GetRowCellValue(iCount, colFETMS_CDF_ETIN_CODE_FK_PK2) = GV21.GetFocusedRowCellValue(colFETHS_CDF_ETIN_CODE_FK_PK2) Then
                e.ErrorText = "Espèce doit être diffèrent des espéces modérement sensibles !"
                e.Valid = False
            End If
        Next
    End Sub

    ''' <summary>
    ''' Evénement: Validation d'une ligne
    ''' </summary>
    ''' <param name="sender">GV31</param>
    ''' <param name="e">ValidateRow</param>
    ''' <remarks></remarks>
    Private Sub GV31_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV31.ValidateRow
        For iCount As Integer = 0 To GV21.RowCount - 1
            If GV21.GetRowCellValue(iCount, colFETHS_CDF_ETIN_CODE_FK_PK2) = GV31.GetFocusedRowCellValue(colFETIS_CDF_ETIN_CODE_FK_PK2) Then
                e.ErrorText = "Espèce doit être diffèrent des espéces habituellemnt sensibles !"
                e.Valid = False
            End If
        Next
        For iCount As Integer = 0 To GV41.RowCount - 1
            If GV41.GetRowCellValue(iCount, colFETMS_CDF_ETIN_CODE_FK_PK2) = GV31.GetFocusedRowCellValue(colFETIS_CDF_ETIN_CODE_FK_PK2) Then
                e.ErrorText = "Espèce doit être diffèrent des espéces modérement sensibles !"
                e.Valid = False
            End If
        Next
    End Sub

    ''' <summary>
    ''' Evénement: Validation d'une ligne
    ''' </summary>
    ''' <param name="sender">GV41</param>
    ''' <param name="e">ValidateRow</param>
    ''' <remarks></remarks>
    Private Sub GV41_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV41.ValidateRow
        For iCount As Integer = 0 To GV21.RowCount - 1
            If GV21.GetRowCellValue(iCount, colFETHS_CDF_ETIN_CODE_FK_PK2) = GV41.GetFocusedRowCellValue(colFETMS_CDF_ETIN_CODE_FK_PK2) Then
                e.ErrorText = "Espèce doit être diffèrent des espéces habituellemnt sensibles !"
                e.Valid = False
            End If
        Next
        For iCount As Integer = 0 To GV31.RowCount - 1
            If GV31.GetRowCellValue(iCount, colFETIS_CDF_ETIN_CODE_FK_PK2) = GV41.GetFocusedRowCellValue(colFETMS_CDF_ETIN_CODE_FK_PK2) Then
                e.ErrorText = "Espèce doit être diffèrent des espéces modérement sensibles !"
                e.Valid = False
            End If
        Next
    End Sub

#End Region

#Region " Panel "

    ''' <summary>
    ''' Evénement: Redimensionnement du panel
    ''' </summary>
    ''' <param name="sender">Panel2</param>
    ''' <param name="e">Resize</param>
    ''' <remarks></remarks>
    Private Sub Panel2_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel2.Resize
        GC13.Width = Panel2.Width / 2
        GC14.Width = Panel2.Width / 2
    End Sub

    ''' <summary>
    ''' Evénement: Redimensionnement du panel
    ''' </summary>
    ''' <param name="sender">Panel3</param>
    ''' <param name="e">Resize</param>
    ''' <remarks></remarks>
    Private Sub Panel3_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.Resize
        GC15.Width = Panel3.Width / 2
        GC16.Width = Panel3.Width / 2
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
    ''' Evénement: Redimensionnement d'onglet
    ''' </summary>
    ''' <param name="sender">XtraTabControl1</param>
    ''' <param name="e">Resize</param>
    ''' <remarks></remarks>
    Private Sub XtraTabControl1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraTabControl1.Resize
        Panel2.Height = XtraTabControl1.Height / 3
        Panel3.Height = XtraTabControl1.Height / 3
        Panel5.Height = XtraTabControl1.Height / 3
    End Sub

#End Region

#Region " Autres événements "

    ''' <summary>
    ''' Evénement: Changement du nombre de lignes
    ''' </summary>
    ''' <param name="sender">GV</param>
    ''' <param name="e">RowCountChanged</param>
    ''' <remarks></remarks>
    Private Sub GV_RowCountChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV23.RowCountChanged, GV33.RowCountChanged, GV43.RowCountChanged, GV53.RowCountChanged
        If sender.RowCount >= 1 Then
            sender.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
            sender.GridControl.EmbeddedNavigator.Buttons.Append.Enabled = False
        Else
            sender.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            sender.GridControl.EmbeddedNavigator.Buttons.Append.Enabled = False
        End If
    End Sub

#End Region

    Private Sub GV_CalcRowHeight(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs) Handles GV23.CalcRowHeight, GV53.CalcRowHeight, GV43.CalcRowHeight, GV33.CalcRowHeight

        e.RowHeight = sender.GridControl.Height
    End Sub

    Private Sub TextEdit1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit1.TextChanged
        EnableButtons(False)
    End Sub

    Private Sub EnableButtons(ByVal value As Boolean)

        btAjouter.Enabled = value
        btSupprimer.Enabled = value
        btDupliquer.Enabled = value
        btChercher.Enabled = value
        btAdvancedSearch.Enabled = value
        btn_RechMulti.Enabled = value
        btValider.Enabled = Not value
        btAnnuler.Enabled = Not value

    End Sub

    Private Sub TextEdit2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit2.TextChanged
        EnableButtons(False)
    End Sub

    Private Sub TextEdit4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit4.TextChanged
        EnableButtons(False)
    End Sub

    Private Sub TextEdit5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit5.TextChanged
        EnableButtons(False)
    End Sub
End Class

