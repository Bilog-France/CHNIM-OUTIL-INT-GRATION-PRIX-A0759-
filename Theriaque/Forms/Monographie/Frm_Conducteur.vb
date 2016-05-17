''' <summary>
''' Created By [BFE]
''' </summary>
''' <remarks> Monographie - Conducteur </remarks>
Public Class Frm_Conducteur

#Region " Déclaration des variables privées "
    Private CodE As String
    Public _Code As Integer = Nothing ' charger la fiche depuis l'extérieur
    Private Tab_lkup1 As Boolean = False
    Private Tab_TA1 As Boolean = False
    Private bModeDuplication As Boolean = False
#End Region

#Region " Edit Data  "

    ''' <summary>
    ''' Fonction: Recherche et retour des données de la fiche
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks>Fonction surchargée</remarks>
    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_FCO_CONDUCTEUR_SPECIALITE()
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then

            XtraTabControl1.SelectedTabPageIndex = 0
            OnLoading = True
            EmptyDataTable()
            InitDataSource()
            Me.FCO_TA.FillByCode(Me.DsTheriaque_Conducteur.FCO_CONDUCTEUR, f._Code)
            'Onglet Entités
            Me.FcocpH_TA.FillByCode(Me.DsTheriaque_Conducteur.FCOCPH_FCO_CLPH, f._Code)
            Me.FcoccH_TA.FillByCode(Me.DsTheriaque_Conducteur.FCOCCH_FCO_CLCH, f._Code)
            Me.FcosaC_TA.FillByCode(Me.DsTheriaque_Conducteur.FCOSAC_FCO_SUBACT, f._Code)
            Me.FcosaU_TA.FillByCode(Me.DsTheriaque_Conducteur.FCOSAU_FCO_SUBAUX, f._Code)
            Me.FcopR_TA.FillByCode(Me.DsTheriaque_Conducteur.FCOPR_FCO_PROD, f._Code)
            Me.FcosP_TA.FillByCode(Me.DsTheriaque_Conducteur.FCOSP_CONDUCTEUR_SPEC, f._Code)
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
        Dim sCodeCOM As String = ""
        Dim sCodePR As String = ""
        Dim sCodeREC As String = ""
        Dim sCodeSAC As String = ""
        Dim sCodeSAU As String = ""
        Dim sCodeSP As String = ""
        Dim f As New Frm_ConducteurMultiCriteres
        f.ShowDialog()
        If f._Validate Then
            If f._bCCH Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CCH_CLASSECHIMIQUE
                fDICO.Text = "Classes chimiques"
                fDICO.ShowDialog()
                sCodeCCH = fDICO._Code
            End If
            If f._bCPH Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CPH_CLASSEPHARMTHER
                fDICO.Text = "Classes pharmaco-thérapeutique"
                fDICO.ShowDialog()
                sCodeCPH = fDICO._Code
            End If
            If f._bREC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("CC", " and substring(CDF_CODE_PK, 1,1) = 'X'")
                fDICO.Text = "Recommandations"
                fDICO.ShowDialog()
                sCodeREC = fDICO._Code
            End If
            If f._bCOM Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("CC", " and substring(CDF_CODE_PK, 1,1) not in ('A', 'D', 'E', 'H', 'L', 'T' ,'X','B','F','G','J')")
                fDICO.Text = "Commentaires autres"
                fDICO.ShowDialog()
                sCodeCOM = fDICO._Code
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
            Dim fResultat As New Frm_Recherche
            Dim sSQL As String = ""
            sSQL &= " select FCO_CODE_SQ_PK as code, '' as libelle from THERIAQUE.FCO_CONDUCTEUR  "
            If sCodeCPH <> "" Then
                sSQL &= " WHERE FCO_CODE_SQ_PK IN (SELECT FCOCPH_FCO_CODE_FK_PK FROM THERIAQUE.FCOCPH_FCO_CLPH WHERE FCOCPH_CPH_CODE_FK_PK = " & cn.SQLText(sCodeCPH) & ")"
            End If
            If sCodeCCH <> "" Then
                If sCodeCPH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FCO_CODE_SQ_PK IN (SELECT FCOCCH_FCO_CODE_FK_PK FROM THERIAQUE.FCOCCH_FCO_CLCH WHERE FCOCCH_CCH_CODE_FK_PK = " & cn.SQLText(sCodeCCH) & ")"
            End If
            If sCodeREC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FCO_CODE_SQ_PK IN (SELECT FCOREC_FCO_CODE_FK_PK FROM THERIAQUE.FCOREC_FCO_REC WHERE FCOREC_CDF_REC_CODE_FK_PK = " & cn.SQLText(sCodeREC) & ")"
            End If
            If sCodeSAC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeREC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FCO_CODE_SQ_PK IN (SELECT FCOSAC_FCO_CODE_FK_PK FROM THERIAQUE.FCOSAC_FCO_SUBACT WHERE FCOSAC_SAC_CODE_FK_PK = " & cn.SQLText(sCodeSAC) & ")"
            End If
            If sCodeSAU <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeREC <> "" Or sCodeSAC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FCO_CODE_SQ_PK IN (SELECT FCOSAU_FCO_CODE_FK_PK FROM THERIAQUE.FCOSAU_FCO_SUBAUX WHERE FCOSAU_SAU_CODE_FK_PK = " & cn.SQLText(sCodeSAU) & ")"
            End If
            If sCodePR <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeREC <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FCO_CODE_SQ_PK IN (SELECT FCOPR_FCO_CODE_FK_PK FROM THERIAQUE.FCOPR_FCO_PROD WHERE FCOPR_PR_CODE_FK_PK = " & cn.SQLText(sCodePR) & ")"
            End If
            If sCodeSP <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeREC <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FCO_CODE_SQ_PK IN (SELECT FCOSP_FCO_CODE_FK_PK FROM THERIAQUE.FCOSP_CONDUCTEUR_SPEC WHERE FCOSP_SP_CODE_FK_PK = " & cn.SQLText(sCodeSP) & ")"
            End If
            If sCodeCOM <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeREC <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FCO_CODE_SQ_PK IN (SELECT FCOCOM_FCO_CODE_FK_PK FROM THERIAQUE.FCOCOM_FCO_COM WHERE FCOCOM_CDF_COM_CODE_FK_PK = " & cn.SQLText(sCodeCOM) & ")"
            End If
            sSQL &= " ORDER BY FCO_CODE_SQ_PK"

            fResultat._SSQL = sSQL
            fResultat.Text = Me.Text
            fResultat.ShowDialog()
            CodE = fResultat._Code
            If fResultat._Code IsNot Nothing Then

                XtraTabControl1.SelectedTabPageIndex = 0
                OnLoading = True
                EmptyDataTable()
                InitDataSource()
                Me.FCO_TA.FillByCode(Me.DsTheriaque_Conducteur.FCO_CONDUCTEUR, fResultat._Code)
                'Onglet Entités
                Me.FcocpH_TA.FillByCode(Me.DsTheriaque_Conducteur.FCOCPH_FCO_CLPH, fResultat._Code)
                Me.FcoccH_TA.FillByCode(Me.DsTheriaque_Conducteur.FCOCCH_FCO_CLCH, fResultat._Code)
                Me.FcosaC_TA.FillByCode(Me.DsTheriaque_Conducteur.FCOSAC_FCO_SUBACT, fResultat._Code)
                Me.FcosaU_TA.FillByCode(Me.DsTheriaque_Conducteur.FCOSAU_FCO_SUBAUX, fResultat._Code)
                Me.FcopR_TA.FillByCode(Me.DsTheriaque_Conducteur.FCOPR_FCO_PROD, fResultat._Code)
                Me.FcosP_TA.FillByCode(Me.DsTheriaque_Conducteur.FCOSP_CONDUCTEUR_SPEC, fResultat._Code)
                Tab_TA1 = False
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
        bModeDuplication = False
        MyBase.Ajouter()
        XtraTabControl1.SelectedTabPageIndex = 0
    End Sub

    ''' <summary>
    ''' Fonction: Suppression d'un enregistrement
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks>Fonction surchargée</remarks>
    Public Overrides Function supprimer() As Boolean
        If Tab_TA1 Then
            MyBase.Supprimer()
            Dim iCount As Integer
            'Onglet Entités
            For iCount = 0 To DsTheriaque_Conducteur.FCOCPH_FCO_CLPH.Rows.Count - 1
                DsTheriaque_Conducteur.FCOCPH_FCO_CLPH.Rows(iCount).Delete()
            Next
            Me.FcocpH_TA.Update(DsTheriaque_Conducteur)

            For iCount = 0 To DsTheriaque_Conducteur.FCOCCH_FCO_CLCH.Rows.Count - 1
                DsTheriaque_Conducteur.FCOCCH_FCO_CLCH.Rows(iCount).Delete()
            Next
            Me.FcoccH_TA.Update(DsTheriaque_Conducteur)

            For iCount = 0 To DsTheriaque_Conducteur.FCOSAC_FCO_SUBACT.Rows.Count - 1
                DsTheriaque_Conducteur.FCOSAC_FCO_SUBACT.Rows(iCount).Delete()
            Next
            Me.FcosaC_TA.Update(DsTheriaque_Conducteur)

            For iCount = 0 To DsTheriaque_Conducteur.FCOSAU_FCO_SUBAUX.Rows.Count - 1
                DsTheriaque_Conducteur.FCOSAU_FCO_SUBAUX.Rows(iCount).Delete()
            Next
            Me.FcosaU_TA.Update(DsTheriaque_Conducteur)

            For iCount = 0 To DsTheriaque_Conducteur.FCOPR_FCO_PROD.Rows.Count - 1
                DsTheriaque_Conducteur.FCOPR_FCO_PROD.Rows(iCount).Delete()
            Next
            Me.FcopR_TA.Update(DsTheriaque_Conducteur)

            For iCount = 0 To DsTheriaque_Conducteur.FCOSP_CONDUCTEUR_SPEC.Rows.Count - 1
                DsTheriaque_Conducteur.FCOSP_CONDUCTEUR_SPEC.Rows(iCount).Delete()
            Next
            Me.FcosP_TA.Update(DsTheriaque_Conducteur)

            'Onglet Conducteur véhicule / Utilisateur machine

            For iCount = 0 To DsTheriaque_Conducteur.FCOREC_FCO_REC.Rows.Count - 1
                DsTheriaque_Conducteur.FCOREC_FCO_REC.Rows(iCount).Delete()
            Next
            Me.FcoreC_TA.Update(DsTheriaque_Conducteur)

            For iCount = 0 To DsTheriaque_Conducteur.FCOCOM_FCO_COM.Rows.Count - 1
                DsTheriaque_Conducteur.FCOCOM_FCO_COM.Rows(iCount).Delete()
            Next
            Me.FcocoM_TA.Update(DsTheriaque_Conducteur)

            For iCount = 0 To DsTheriaque_Conducteur.FCOAFS_FCO_AFSSAPS.Rows.Count - 1
                DsTheriaque_Conducteur.FCOAFS_FCO_AFSSAPS.Rows(iCount).Delete()
            Next
            Me.FcoafS_TA.Update(DsTheriaque_Conducteur)

            ' Master
            DsTheriaque_Conducteur.FCO_CONDUCTEUR.Rows(0).Delete()
            Me.FCO_TA.Update(Me.MasterDataSet)

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
        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        FCO_TA.Update(Me.DsTheriaque_Conducteur.FCO_CONDUCTEUR)
        'Onglet Entités
        Me.BindingContext(Me.MasterDataSet, FCOCPH_FCO_CLPH).EndCurrentEdit()
        FcocpH_TA.Update(Me.DsTheriaque_Conducteur.FCOCPH_FCO_CLPH)

        Me.BindingContext(Me.MasterDataSet, FCOCCH_FCO_CLCH).EndCurrentEdit()
        FcoccH_TA.Update(Me.DsTheriaque_Conducteur.FCOCCH_FCO_CLCH)

        Me.BindingContext(Me.MasterDataSet, FCOSAC_FCO_SUBACT).EndCurrentEdit()
        FcosaC_TA.Update(Me.DsTheriaque_Conducteur.FCOSAC_FCO_SUBACT)

        Me.BindingContext(Me.MasterDataSet, FCOSAU_FCO_SUBAUX).EndCurrentEdit()
        FcosaU_TA.Update(Me.DsTheriaque_Conducteur.FCOSAU_FCO_SUBAUX)

        Me.BindingContext(Me.MasterDataSet, FCOSP_CONDUCTEUR_SPEC).EndCurrentEdit()
        FcosP_TA.Update(Me.DsTheriaque_Conducteur.FCOSP_CONDUCTEUR_SPEC)

        Me.BindingContext(Me.MasterDataSet, FCOPR_FCO_PROD).EndCurrentEdit()
        FcopR_TA.Update(Me.DsTheriaque_Conducteur.FCOPR_FCO_PROD)

        'Onglet Conducteur véhicule / Utilisateur machine
        Me.BindingContext(Me.MasterDataSet, FCOREC_FCO_REC).EndCurrentEdit()
        FcoreC_TA.Update(Me.DsTheriaque_Conducteur.FCOREC_FCO_REC)

        Me.BindingContext(Me.MasterDataSet, FCOAFS_FCO_AFSSAPS).EndCurrentEdit()
        FcoafS_TA.Update(Me.DsTheriaque_Conducteur.FCOAFS_FCO_AFSSAPS)

        Me.BindingContext(Me.MasterDataSet, FCOCOM_FCO_COM).EndCurrentEdit()
        FcocoM_TA.Update(Me.DsTheriaque_Conducteur.FCOCOM_FCO_COM)

        bModeDuplication = False
        'Tab_TA1 = True

    End Sub

    ''' <summary>
    ''' Proçédure: Annulation d'un enregistrement
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub annuler()
        OnLoading = True
        MyBase.Annuler()
        'Onglet Entités
        Me.BindingContext(DsTheriaque_Conducteur, FCOCPH_FCO_CLPH).CancelCurrentEdit()
        Me.DsTheriaque_Conducteur.FCOCPH_FCO_CLPH.RejectChanges()

        Me.BindingContext(DsTheriaque_Conducteur, FCOCCH_FCO_CLCH).CancelCurrentEdit()
        Me.DsTheriaque_Conducteur.FCOCCH_FCO_CLCH.RejectChanges()

        Me.BindingContext(DsTheriaque_Conducteur, FCOSAC_FCO_SUBACT).CancelCurrentEdit()
        Me.DsTheriaque_Conducteur.FCOSAC_FCO_SUBACT.RejectChanges()

        Me.BindingContext(DsTheriaque_Conducteur, FCOSAU_FCO_SUBAUX).CancelCurrentEdit()
        Me.DsTheriaque_Conducteur.FCOSAU_FCO_SUBAUX.RejectChanges()

        Me.BindingContext(DsTheriaque_Conducteur, FCOSP_CONDUCTEUR_SPEC).CancelCurrentEdit()
        Me.DsTheriaque_Conducteur.FCOSP_CONDUCTEUR_SPEC.RejectChanges()

        Me.BindingContext(DsTheriaque_Conducteur, FCOPR_FCO_PROD).CancelCurrentEdit()
        Me.DsTheriaque_Conducteur.FCOPR_FCO_PROD.RejectChanges()

        'Onglet Conducteur véhicule / Utilisateur machine
        Me.BindingContext(DsTheriaque_Conducteur, FCOREC_FCO_REC).CancelCurrentEdit()
        Me.DsTheriaque_Conducteur.FCOREC_FCO_REC.RejectChanges()

        Me.BindingContext(DsTheriaque_Conducteur, FCOCOM_FCO_COM).CancelCurrentEdit()
        Me.DsTheriaque_Conducteur.FCOCOM_FCO_COM.RejectChanges()

        Me.BindingContext(DsTheriaque_Conducteur, FCOAFS_FCO_AFSSAPS).CancelCurrentEdit()
        Me.DsTheriaque_Conducteur.FCOAFS_FCO_AFSSAPS.RejectChanges()

        'Master
        Me.BindingContext(Me.MasterDataSet, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_Conducteur.FCO_CONDUCTEUR.RejectChanges()

        If bModeDuplication Then EmptyDataTable()

        bModeDuplication = False
        OnLoading = False
    End Sub

    ''' <summary>
    ''' Proçédure: Duplication des données à partir d'une autre fiche
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub Dupliquer()

        If Not Tab_TA1 And CodE <> InvalideControl And CodE <> Nothing Then LoadTab_1()

        Dim dt1 As New DataTable
        dt1 = DsTheriaque_Conducteur.FCOCPH_FCO_CLPH.Copy

        Dim dt2 As New DataTable
        dt2 = DsTheriaque_Conducteur.FCOCCH_FCO_CLCH.Copy

        Dim dt3 As New DataTable
        dt3 = DsTheriaque_Conducteur.FCOSAC_FCO_SUBACT.Copy

        Dim dt4 As New DataTable
        dt4 = DsTheriaque_Conducteur.FCOSAU_FCO_SUBAUX.Copy

        Dim dt5 As New DataTable
        dt5 = DsTheriaque_Conducteur.FCOPR_FCO_PROD.Copy

        Dim dt6 As New DataTable
        dt6 = DsTheriaque_Conducteur.FCOSP_CONDUCTEUR_SPEC.Copy

        Dim dt21 As New DataTable
        dt21 = DsTheriaque_Conducteur.FCOREC_FCO_REC.Copy

        Dim dt22 As New DataTable
        dt22 = DsTheriaque_Conducteur.FCOCOM_FCO_COM.Copy

        Dim dt23 As New DataTable
        dt23 = DsTheriaque_Conducteur.FCOAFS_FCO_AFSSAPS.Copy

        Dim sText As String = MemoEdit3.Text

        EmptyDataTable()

        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        SetCode_MAx(MasterTable, txtCode)
        CodE = InvalideControl

        Dim drTemp As DataRow
        For iCount As Integer = 0 To dt1.Rows.Count - 1
            'DsTheriaque_Conducteur.Tables("FCOCPH_FCO_CLPH").ImportRow(dt1.Rows(iCount))
            drTemp = DsTheriaque_Conducteur.Tables("FCOCPH_FCO_CLPH").NewRow()
            drTemp.ItemArray = dt1.Rows(iCount).ItemArray
            DsTheriaque_Conducteur.Tables("FCOCPH_FCO_CLPH").Rows.Add(drTemp)
        Next


        For iCount As Integer = 0 To dt2.Rows.Count - 1
            'DsTheriaque_Conducteur.Tables("FCOCCH_FCO_CLCH").ImportRow(dt2.Rows(iCount))
            drTemp = DsTheriaque_Conducteur.Tables("FCOCCH_FCO_CLCH").NewRow()
            drTemp.ItemArray = dt2.Rows(iCount).ItemArray
            DsTheriaque_Conducteur.Tables("FCOCCH_FCO_CLCH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt3.Rows.Count - 1
            'DsTheriaque_Conducteur.Tables("FCOSAC_FCO_SUBACT").ImportRow(dt3.Rows(iCount))
            drTemp = DsTheriaque_Conducteur.Tables("FCOSAC_FCO_SUBACT").NewRow()
            drTemp.ItemArray = dt3.Rows(iCount).ItemArray
            DsTheriaque_Conducteur.Tables("FCOSAC_FCO_SUBACT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt4.Rows.Count - 1
            'DsTheriaque_Conducteur.Tables("FCOSAU_FCO_SUBAUX").ImportRow(dt4.Rows(iCount))
            drTemp = DsTheriaque_Conducteur.Tables("FCOSAU_FCO_SUBAUX").NewRow()
            drTemp.ItemArray = dt4.Rows(iCount).ItemArray
            DsTheriaque_Conducteur.Tables("FCOSAU_FCO_SUBAUX").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt5.Rows.Count - 1
            'DsTheriaque_Conducteur.Tables("FCOPR_FCO_PROD").ImportRow(dt5.Rows(iCount))
            drTemp = DsTheriaque_Conducteur.Tables("FCOPR_FCO_PROD").NewRow()
            drTemp.ItemArray = dt5.Rows(iCount).ItemArray
            DsTheriaque_Conducteur.Tables("FCOPR_FCO_PROD").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt6.Rows.Count - 1
            'DsTheriaque_Conducteur.Tables("FCOSP_CONDUCTEUR_SPEC").ImportRow(dt6.Rows(iCount))
            drTemp = DsTheriaque_Conducteur.Tables("FCOSP_CONDUCTEUR_SPEC").NewRow()
            drTemp.ItemArray = dt6.Rows(iCount).ItemArray
            DsTheriaque_Conducteur.Tables("FCOSP_CONDUCTEUR_SPEC").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt21.Rows.Count - 1
            'DsTheriaque_Conducteur.Tables("FCOREC_FCO_REC").ImportRow(dt21.Rows(iCount))
            drTemp = DsTheriaque_Conducteur.Tables("FCOREC_FCO_REC").NewRow()
            drTemp.ItemArray = dt21.Rows(iCount).ItemArray
            DsTheriaque_Conducteur.Tables("FCOREC_FCO_REC").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt22.Rows.Count - 1
            'DsTheriaque_Conducteur.Tables("FCOCOM_FCO_COM").ImportRow(dt22.Rows(iCount))
            drTemp = DsTheriaque_Conducteur.Tables("FCOCOM_FCO_COM").NewRow()
            drTemp.ItemArray = dt22.Rows(iCount).ItemArray
            DsTheriaque_Conducteur.Tables("FCOCOM_FCO_COM").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt23.Rows.Count - 1
            'DsTheriaque_Conducteur.Tables("FCOAFS_FCO_AFSSAPS").ImportRow(dt23.Rows(iCount))
            drTemp = DsTheriaque_Conducteur.Tables("FCOAFS_FCO_AFSSAPS").NewRow()
            drTemp.ItemArray = dt23.Rows(iCount).ItemArray
            DsTheriaque_Conducteur.Tables("FCOAFS_FCO_AFSSAPS").Rows.Add(drTemp)
        Next

        MemoEdit3.Text = sText

        ModifierCode()
        bModeDuplication = True
        MyBase.Dupliquer()
        XtraTabControl1.SelectedTabPageIndex = 0
    End Sub

    ''' <summary>
    ''' Proçédure: Vider tous les dataset
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Private Sub EmptyDataTable()
        'Master
        Me.DsTheriaque_Conducteur.FCO_CONDUCTEUR.Clear()
        'Onglet Entités
        Me.DsTheriaque_Conducteur.FCOCPH_FCO_CLPH.Clear()
        Me.DsTheriaque_Conducteur.FCOCCH_FCO_CLCH.Clear()
        Me.DsTheriaque_Conducteur.FCOSAC_FCO_SUBACT.Clear()
        Me.DsTheriaque_Conducteur.FCOSAU_FCO_SUBAUX.Clear()
        Me.DsTheriaque_Conducteur.FCOPR_FCO_PROD.Clear()
        Me.DsTheriaque_Conducteur.FCOSP_CONDUCTEUR_SPEC.Clear()

        'Onglet Conducteur véhicule / Utilisateur machine
        Me.DsTheriaque_Conducteur.FCOREC_FCO_REC.Clear()
        Me.DsTheriaque_Conducteur.FCOCOM_FCO_COM.Clear()
        Me.DsTheriaque_Conducteur.FCOAFS_FCO_AFSSAPS.Clear()
    End Sub


    ''' <summary>
    ''' Proçédure: Modifier code Master de la fiche
    ''' </summary>
    Private Sub ModifierCode()
        'GV1
        For iCount As Integer = 0 To GV1.RowCount - 1
            GV1.SetRowCellValue(iCount, colFCOCPH_FCO_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV2
        For iCount As Integer = 0 To GV2.RowCount - 1
            GV2.SetRowCellValue(iCount, colFCOCCH_FCO_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV3
        For iCount As Integer = 0 To GV3.RowCount - 1
            GV3.SetRowCellValue(iCount, colFCOSAC_FCO_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV4
        For iCount As Integer = 0 To GV4.RowCount - 1
            GV4.SetRowCellValue(iCount, colFCOSAU_FCO_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV5
        For iCount As Integer = 0 To GV5.RowCount - 1
            GV5.SetRowCellValue(iCount, colFCOPR_FCO_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV6
        For iCount As Integer = 0 To GV6.RowCount - 1
            GV6.SetRowCellValue(iCount, colFCOSP_FCO_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV21
        For iCount As Integer = 0 To GV21.RowCount - 1
            GV21.SetRowCellValue(iCount, colFCOREC_FCO_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV22
        For iCount As Integer = 0 To GV22.RowCount - 1
            GV22.SetRowCellValue(iCount, colFCOCOM_FCO_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV23
        For iCount As Integer = 0 To GV23.RowCount - 1
            GV23.SetRowCellValue(iCount, colFCOAFS_FCO_CODE_FK_PK, Me.txtCode.Text)
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
            If Not FieldExistRO(GV6, colFCOSP_SP_CODE_FK_PK, GV23.GetRowCellValue(iCount, colFCOAFS_SP_CODE_FK_PK)) Then
                GV23.FocusedRowHandle = iCount
                GV23.SetColumnError(colFCOAFS_SP_CODE_FK_PK, "La spécialité doit être présente dans la fiche.")
                XtraTabControl1.SelectedTabPageIndex = 1
                Exit Function
            Else
                GV23.SetColumnError(colFCOAFS_SP_CODE_FK_PK, "")
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
        GC1.DataSource = DsTheriaque_Conducteur
        GC1.DataMember = FCOCPH_FCO_CLPH

        GC2.DataSource = DsTheriaque_Conducteur
        GC2.DataMember = FCOCCH_FCO_CLCH

        GC3.DataSource = DsTheriaque_Conducteur
        GC3.DataMember = FCOSAC_FCO_SUBACT

        GC4.DataSource = DsTheriaque_Conducteur
        GC4.DataMember = FCOSAU_FCO_SUBAUX

        GC5.DataSource = DsTheriaque_Conducteur
        GC5.DataMember = FCOPR_FCO_PROD

        GC6.DataSource = DsTheriaque_Conducteur
        GC6.DataMember = FCOSP_CONDUCTEUR_SPEC

        'Onglet Conducteur véhicule / Utilisateur machine
        GC21.DataSource = DsTheriaque_Conducteur
        GC21.DataMember = FCOREC_FCO_REC

        GC22.DataSource = DsTheriaque_Conducteur
        GC22.DataMember = FCOCOM_FCO_COM

        GC23.DataSource = DsTheriaque_Conducteur
        GC23.DataMember = FCOAFS_FCO_AFSSAPS

    End Sub

    ''' <summary>
    ''' Proçédure: Initialisation des données
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub InitData()
        MyBase.InitData()
        Declinaison_Global = True
        OnLoading = True
        MasterDataSet = Me.DsTheriaque_Conducteur
        MasterTable = FCO_CONDUCTEUR
        CodE = InvalideControl

        'Déclinaison classe CPH
        Dim List1 As New System.Collections.Generic.List(Of StructGVTable)
        List1.Add(New StructGVTable("GC1", eDeclinaison.CPH, colFCOCPH_CPH_CODE_FK_PK2))
        List1.Add(New StructGVTable("GC2", eDeclinaison.CCH, colFCOCCH_CCH_CODE_FK_PK2))
        List1.Add(New StructGVTable("GC3", eDeclinaison.SAC, colFCOSAC_SAC_CODE_FK_PK2))
        List1.Add(New StructGVTable("GC6", eDeclinaison.SP, colFCOSP_SP_CODE_FK_PK2))
        Dim DecCPH As New ClsDeclinaison(eDeclinaison.CPH, List1)
        InitLkup(Me.Lkup_FCOCPH, FCOCPH_FCO_CLPH, strSSQL_CPH_CLASSEPHARMTHER_NIVEAU, True, , , , , , DecCPH)

        'Déclinaison classe CCH
        Dim List2 As New System.Collections.Generic.List(Of StructGVTable)
        List2.Add(New StructGVTable("GC1", eDeclinaison.CPH, colFCOCPH_CPH_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC2", eDeclinaison.CCH, colFCOCCH_CCH_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC3", eDeclinaison.SAC, colFCOSAC_SAC_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC6", eDeclinaison.SP, colFCOSP_SP_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC4", eDeclinaison.SAU, colFCOSAU_SAU_CODE_FK_PK2))
        Dim DecCCH As New ClsDeclinaison(eDeclinaison.CCH, List2)
        InitLkup(Me.lkup_FCOCCH, FCOCCH_FCO_CLCH, strSSQL_CCH_CLASSECHIMIQUE_NIVEAU, True, , , , , , DecCCH)

        'Déclinaison SUBAC
        Dim List3 As New System.Collections.Generic.List(Of StructGVTable)
        List3.Add(New StructGVTable("GC3", eDeclinaison.SAC, colFCOSAC_SAC_CODE_FK_PK2))
        List3.Add(New StructGVTable("GC6", eDeclinaison.SP, colFCOSP_SP_CODE_FK_PK2))
        Dim DecSUBAC As New ClsDeclinaison(eDeclinaison.SAC, List3)
        InitLkup(Me.lkup_FCOSAC, FCOSAC_FCO_SUBACT, strSSQL_SAC_SUBACTIVE, True, , , , , , DecSUBAC)

        'Déclinaison SAU
        Dim List4 As New System.Collections.Generic.List(Of StructGVTable)
        List4.Add(New StructGVTable("GC4", eDeclinaison.SAU, colFCOSAU_SAU_CODE_FK_PK2))
        List4.Add(New StructGVTable("GC6", eDeclinaison.SP, colFCOSP_SP_CODE_FK_PK2))
        Dim DecSAU As New ClsDeclinaison(eDeclinaison.SAU, List4)
        InitLkup(Me.lkup_FCOSAU, FCOSAU_FCO_SUBAUX, strSSQL_SAU_SUBAUXILIAIRE, True, , , , , , DecSAU)

        'Déclinaison PRODUIT
        Dim List5 As New System.Collections.Generic.List(Of StructGVTable)
        List5.Add(New StructGVTable("GC5", eDeclinaison.PR, colFCOPR_PR_CODE_FK_PK2))
        List5.Add(New StructGVTable("GC6", eDeclinaison.SP, colFCOSP_SP_CODE_FK_PK2))
        Dim DecPR As New ClsDeclinaison(eDeclinaison.PR, List5)
        InitLkup(Me.lkup_FCOPR, FCOPR_FCO_PROD, strSSQL_PR_PRODUIT, True, , , , , , DecPR)

        InitLkup(Me.lkup_FCOSP, FCOSP_CONDUCTEUR_SPEC, strSSQL_SP_SPECIALITE, True)
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
        Me.FCO_TA.FillByCode(Me.DsTheriaque_Conducteur.FCO_CONDUCTEUR, CodE1)
        'Onglet Entités
        Me.FcocpH_TA.FillByCode(Me.DsTheriaque_Conducteur.FCOCPH_FCO_CLPH, CodE1)
        Me.FcoccH_TA.FillByCode(Me.DsTheriaque_Conducteur.FCOCCH_FCO_CLCH, CodE1)
        Me.FcosaC_TA.FillByCode(Me.DsTheriaque_Conducteur.FCOSAC_FCO_SUBACT, CodE1)
        Me.FcosaU_TA.FillByCode(Me.DsTheriaque_Conducteur.FCOSAU_FCO_SUBAUX, CodE1)
        Me.FcopR_TA.FillByCode(Me.DsTheriaque_Conducteur.FCOPR_FCO_PROD, CodE1)
        Me.FcosP_TA.FillByCode(Me.DsTheriaque_Conducteur.FCOSP_CONDUCTEUR_SPEC, CodE1)

        Tab_TA1 = False
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
        If CodE <> InvalideControl And CodE <> Nothing Then
            Dim strSSQL_SP_REF As String
            strSSQL_SP_REF = " SELECT SP_CODE_SQ_PK as code, SP_NOM as libelle FROM THERIAQUE.FCOSP_CONDUCTEUR_SPEC, THERIAQUE.SP_SPECIALITE"
            strSSQL_SP_REF &= " WHERE FCOSP_FCO_CODE_FK_PK = " & CodE
            strSSQL_SP_REF &= " AND SP_CODE_SQ_PK = FCOSP_SP_CODE_FK_PK"
            InitLkup(Me.lkup_SPAFS, FCOAFS_FCO_AFSSAPS, strSSQL_SP_REF, True)
            For iCount As Integer = 0 To GV23.RowCount
                If GV23.GetRowCellDisplayText(iCount, "FCOAFS_SP_CODE_FK_PK") = "" And GV23.GetRowCellDisplayText(iCount, "FCOAFS_FCO_CODE_FK_PK") <> "" Then
                    GV23.DeleteRow(iCount)
                    iCount = iCount - 1
                End If
            Next
        End If
        If Not Tab_lkup1 Then
            InitLkup(Me.lkup_FCOREC, FCOREC_FCO_REC, strSSQL_CDF_CODIF("CC", " and substring(CDF_CODE_PK, 1,1) = 'X'"), True)
            InitLkup(Me.lkup_FCOCOM, FCOCOM_FCO_COM, strSSQL_CDF_CODIF("CC", " and substring(CDF_CODE_PK, 1,1) not in ('A', 'D', 'E', 'H', 'L', 'T' ,'X','B','F','G','J')"), True)
            InitLkup(Me.lkup_FCOAFS, FCOAFS_FCO_AFSSAPS, strSSQL_CDF_CODIF("25"), True)
            Tab_lkup1 = True
        End If

        If Not Tab_TA1 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.FcoreC_TA.FillByCode(Me.DsTheriaque_Conducteur.FCOREC_FCO_REC, CodE)
            Me.FcocoM_TA.FillByCode(Me.DsTheriaque_Conducteur.FCOCOM_FCO_COM, CodE)
            Me.FcoafS_TA.FillByCode(Me.DsTheriaque_Conducteur.FCOAFS_FCO_AFSSAPS, CodE)
            Me.FCO_TA.FillByCode(Me.DsTheriaque_Conducteur.FCO_CONDUCTEUR, CodE)
            Tab_TA1 = True
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
        GV1.SetFocusedRowCellValue(colFCOCPH_FCO_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV2</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        If OnLoading Then Exit Sub
        GV2.SetFocusedRowCellValue(colFCOCCH_FCO_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV3</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV3_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV3.InitNewRow
        If OnLoading Then Exit Sub
        GV3.SetFocusedRowCellValue(colFCOSAC_FCO_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV4</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV4_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV4.InitNewRow
        If OnLoading Then Exit Sub
        GV4.SetFocusedRowCellValue(colFCOSAU_FCO_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV5</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV5_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV5.InitNewRow
        If OnLoading Then Exit Sub
        GV5.SetFocusedRowCellValue(colFCOPR_FCO_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV6</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV6_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV6.InitNewRow
        If OnLoading Then Exit Sub
        GV6.SetFocusedRowCellValue(colFCOSP_FCO_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV21</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV21_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV21.InitNewRow
        If OnLoading Then Exit Sub
        GV21.SetFocusedRowCellValue(colFCOREC_FCO_CODE_FK_PK, txtCode.Text)
        GV21.SetFocusedRowCellValue(colFCOREC_NUMORD, Code_MAx(GV21, colFCOREC_NUMORD))
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV22</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV22_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV22.InitNewRow
        If OnLoading Then Exit Sub
        GV22.SetFocusedRowCellValue(colFCOCOM_FCO_CODE_FK_PK, txtCode.Text)
        GV22.SetFocusedRowCellValue(colFCOCOM_NUMORD, Code_MAx(GV22, colFCOCOM_NUMORD))
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV23</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV23_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV23.InitNewRow
        If OnLoading Then Exit Sub
        GV23.SetFocusedRowCellValue(colFCOAFS_FCO_CODE_FK_PK, txtCode.Text)
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
    ''' Evénement: Redimensionnement d'onglet
    ''' </summary>
    ''' <param name="sender">XtraTabControl1</param>
    ''' <param name="e">Resize</param>
    ''' <remarks></remarks>
    Private Sub XtraTabControl1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraTabControl1.Resize
        Panel4.Height = XtraTabControl1.Height / 3
        Panel6.Height = XtraTabControl1.Height / 3
        Panel7.Height = XtraTabControl1.Height / 3

        Panel8.Height = XtraTabControl1.Height / 4
        Panel2.Height = XtraTabControl1.Height / 4
        Panel3.Height = XtraTabControl1.Height / 4
        Panel5.Height = XtraTabControl1.Height / 4
    End Sub

#End Region

End Class
