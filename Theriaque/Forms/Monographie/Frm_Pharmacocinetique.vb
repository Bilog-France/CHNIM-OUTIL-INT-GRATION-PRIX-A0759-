''' <summary>
''' Created By [BFE]
''' </summary>
''' <remarks> Monographie - Pharmacocinetique
''' </remarks>
Public Class Frm_Pharmacocinetique

#Region "Déclaration des variables privées"
    Private CodE As String
    Public _Code As Integer = Nothing ' charger la fiche depuis l'extérieur
    Private Tab_lkup1 As Boolean = False
    Private Tab_TA1 As Boolean = False
    Private bModeDuplication As Boolean = False
#End Region

#Region " Edit Data  "

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_FPHCO_PHARMACOCINETIQUE2
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            XtraTabControl1.SelectedTabPageIndex = 0
            OnLoading = True
            EmptyDataTable()
            Me.FphcO_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCO_PHARMACOCINETIQUE, f._Code)

            'Onglet Entités
            Me.FphcocpH_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCOCPH_FPHCO_CLPH, f._Code)
            Me.FphcoccH_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCOCCH_FPHCO_CLCH, f._Code)
            Me.FphcosaC_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCOSAC_FPHCO_SUBACT, f._Code)
            Me.FphcosaU_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCOSAU_FPHCO_SUBAUX, f._Code)
            Me.FphcopR_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCOPR_FPHCO_PROD, f._Code)
            Me.FphcosP_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCOSP_PHARMACOCIN_SPEC, f._Code)

            Tab_TA1 = False
            bModeDuplication = False
            OnLoading = False
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Function Chercheravance() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_FPHCO_PHARMACOCINETIQUE_SP()
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            XtraTabControl1.SelectedTabPageIndex = 0
            OnLoading = True
            EmptyDataTable()
            Me.FphcO_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCO_PHARMACOCINETIQUE, f._Code)

            'Onglet Entités
            Me.FphcocpH_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCOCPH_FPHCO_CLPH, f._Code)
            Me.FphcoccH_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCOCCH_FPHCO_CLCH, f._Code)
            Me.FphcosaC_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCOSAC_FPHCO_SUBACT, f._Code)
            Me.FphcosaU_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCOSAU_FPHCO_SUBAUX, f._Code)
            Me.FphcopR_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCOPR_FPHCO_PROD, f._Code)
            Me.FphcosP_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCOSP_PHARMACOCIN_SPEC, f._Code)

            Tab_TA1 = False
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
        Dim sCodeCOM As String = ""
        Dim sCodePR As String = ""
        Dim sCodeSAC As String = ""
        Dim sCodeSAU As String = ""
        Dim sCodeSP As String = ""
        Dim f As New Frm_PharmacocinetiqueMultiCriteres
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
            If f._bCOM Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("PK")
                fDICO.Text = "Commentaires"
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
            sSQL &= " Select FPHCO_CODE_SQ_PK as code, '' as libelle From THERIAQUE.FPHCO_PHARMACOCINETIQUE"
            If sCodeCPH <> "" Then
                sSQL &= " WHERE FPHCO_CODE_SQ_PK IN (SELECT FPHCOCPH_FPHCO_CODE_FK_PK FROM THERIAQUE.FPHCOCPH_FPHCO_CLPH WHERE FPHCOCPH_CPH_CODE_FK_PK = " & cn.SQLText(sCodeCPH) & ")"
            End If
            If sCodeCCH <> "" Then
                If sCodeCPH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPHCO_CODE_SQ_PK IN (SELECT FPHCOCCH_FPHCO_CODE_FK_PK FROM THERIAQUE.FPHCOCCH_FPHCO_CLCH WHERE FPHCOCCH_CCH_CODE_FK_PK = " & cn.SQLText(sCodeCCH) & ")"
            End If
            If sCodeSAC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPHCO_CODE_SQ_PK IN (SELECT FPHCOSAC_FPHCO_CODE_FK_PK FROM THERIAQUE.FPHCOSAC_FPHCO_SUBACT WHERE FPHCOSAC_SAC_CODE_FK_PK = " & cn.SQLText(sCodeSAC) & ")"
            End If
            If sCodeSAU <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPHCO_CODE_SQ_PK IN (SELECT FPHCOSAU_FPHCO_CODE_FK_PK FROM THERIAQUE.FPHCOSAU_FPHCO_SUBAUX WHERE FPHCOSAU_SAU_CODE_FK_PK = " & cn.SQLText(sCodeSAU) & ")"
            End If
            If sCodePR <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPHCO_CODE_SQ_PK IN (SELECT FPHCOPR_FPHCO_CODE_FK_PK FROM THERIAQUE.FPHCOPR_FPHCO_PROD WHERE FPHCOPR_PR_CODE_FK_PK = " & cn.SQLText(sCodePR) & ")"
            End If
            If sCodeSP <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPHCO_CODE_SQ_PK IN (SELECT FPHCOSP_FPHCO_CODE_FK_PK FROM THERIAQUE.FPHCOSP_PHARMACOCIN_SPEC WHERE FPHCOSP_SP_CODE_FK_PK = " & cn.SQLText(sCodeSP) & ")"
            End If
            If sCodeCOM <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPHCO_CODE_SQ_PK IN (SELECT FPHCOCOM_FPHCO_CODE_FK_PK FROM THERIAQUE.FPHCOCOM_FPHCO_COM WHERE FPHCOCOM_CDF_COM_CODE_FK_PK = " & cn.SQLText(sCodeCOM) & ")"
            End If
            sSQL &= " ORDER BY FPHCO_CODE_SQ_PK"

            fResultat._SSQL = sSQL
            fResultat.Text = Me.Text
            fResultat.ShowDialog()
            CodE = fResultat._Code
            If fResultat._Code IsNot Nothing Then
                XtraTabControl1.SelectedTabPageIndex = 0
                OnLoading = True
                EmptyDataTable()
                Me.FphcO_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCO_PHARMACOCINETIQUE, fResultat._Code)

                'Onglet Entités
                Me.FphcocpH_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCOCPH_FPHCO_CLPH, fResultat._Code)
                Me.FphcoccH_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCOCCH_FPHCO_CLCH, fResultat._Code)
                Me.FphcosaC_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCOSAC_FPHCO_SUBACT, fResultat._Code)
                Me.FphcosaU_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCOSAU_FPHCO_SUBAUX, fResultat._Code)
                Me.FphcopR_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCOPR_FPHCO_PROD, fResultat._Code)
                Me.FphcosP_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCOSP_PHARMACOCIN_SPEC, fResultat._Code)

                Tab_TA1 = False
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
        MyBase.Supprimer()
        Dim iCount As Integer
        If Tab_TA1 Then

            'Onglet Entités
            For iCount = 0 To DsTheriaque_Pharmacocinetique.FPHCOCPH_FPHCO_CLPH.Rows.Count - 1
                DsTheriaque_Pharmacocinetique.FPHCOCPH_FPHCO_CLPH.Rows(iCount).Delete()
            Next
            Me.FphcocpH_TA.Update(DsTheriaque_Pharmacocinetique)

            For iCount = 0 To DsTheriaque_Pharmacocinetique.FPHCOCCH_FPHCO_CLCH.Rows.Count - 1
                DsTheriaque_Pharmacocinetique.FPHCOCCH_FPHCO_CLCH.Rows(iCount).Delete()
            Next
            Me.FphcoccH_TA.Update(DsTheriaque_Pharmacocinetique)

            For iCount = 0 To DsTheriaque_Pharmacocinetique.FPHCOSAC_FPHCO_SUBACT.Rows.Count - 1
                DsTheriaque_Pharmacocinetique.FPHCOSAC_FPHCO_SUBACT.Rows(iCount).Delete()
            Next
            Me.FphcosaC_TA.Update(DsTheriaque_Pharmacocinetique)

            For iCount = 0 To DsTheriaque_Pharmacocinetique.FPHCOSAU_FPHCO_SUBAUX.Rows.Count - 1
                DsTheriaque_Pharmacocinetique.FPHCOSAU_FPHCO_SUBAUX.Rows(iCount).Delete()
            Next
            Me.FphcosaU_TA.Update(DsTheriaque_Pharmacocinetique)

            For iCount = 0 To DsTheriaque_Pharmacocinetique.FPHCOPR_FPHCO_PROD.Rows.Count - 1
                DsTheriaque_Pharmacocinetique.FPHCOPR_FPHCO_PROD.Rows(iCount).Delete()
            Next
            Me.FphcopR_TA.Update(DsTheriaque_Pharmacocinetique)

            For iCount = 0 To DsTheriaque_Pharmacocinetique.FPHCOCOM_FPHCO_COM.Rows.Count - 1
                DsTheriaque_Pharmacocinetique.FPHCOCOM_FPHCO_COM.Rows(iCount).Delete()
            Next
            Me.FphcocoM_TA.Update(DsTheriaque_Pharmacocinetique)

            For iCount = 0 To DsTheriaque_Pharmacocinetique.FPHCOSP_PHARMACOCIN_SPEC.Rows.Count - 1
                DsTheriaque_Pharmacocinetique.FPHCOSP_PHARMACOCIN_SPEC.Rows(iCount).Delete()
            Next
            Me.FphcosP_TA.Update(DsTheriaque_Pharmacocinetique)

            For iCount = 0 To DsTheriaque_Pharmacocinetique.FPHCOAFS_FPHCO_AFSSAPS.Rows.Count - 1
                DsTheriaque_Pharmacocinetique.FPHCOAFS_FPHCO_AFSSAPS.Rows(iCount).Delete()
            Next
            Me.FphcoafS_TA.Update(DsTheriaque_Pharmacocinetique)

            ' Master
            DsTheriaque_Pharmacocinetique.FPHCO_PHARMACOCINETIQUE.Rows(0).Delete()
            Me.FphcO_TA.Update(Me.MasterDataSet)

            bModeDuplication = False
            Return True
        Else
            Process_Message(strChargementOnglet, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Function

    Public Overrides Sub valider()
        MyBase.Valider()
        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        FphcO_TA.Update(Me.DsTheriaque_Pharmacocinetique.FPHCO_PHARMACOCINETIQUE)
        'Onglet Entités
        Me.BindingContext(Me.MasterDataSet, FPHCOCPH_FPHCO_CLPH).EndCurrentEdit()
        FphcocpH_TA.Update(Me.DsTheriaque_Pharmacocinetique.FPHCOCPH_FPHCO_CLPH)

        Me.BindingContext(Me.MasterDataSet, FPHCOCCH_FPHCO_CLCH).EndCurrentEdit()
        FphcoccH_TA.Update(Me.DsTheriaque_Pharmacocinetique.FPHCOCCH_FPHCO_CLCH)

        Me.BindingContext(Me.MasterDataSet, FPHCOSAC_FPHCO_SUBACT).EndCurrentEdit()
        FphcosaC_TA.Update(Me.DsTheriaque_Pharmacocinetique.FPHCOSAC_FPHCO_SUBACT)

        Me.BindingContext(Me.MasterDataSet, FPHCOSAU_FPHCO_SUBAUX).EndCurrentEdit()
        FphcosaU_TA.Update(Me.DsTheriaque_Pharmacocinetique.FPHCOSAU_FPHCO_SUBAUX)

        Me.BindingContext(Me.MasterDataSet, FPHCOPR_FPHCO_PROD).EndCurrentEdit()
        FphcopR_TA.Update(Me.DsTheriaque_Pharmacocinetique.FPHCOPR_FPHCO_PROD)

        Me.BindingContext(Me.MasterDataSet, FPHCOCOM_FPHCO_COM).EndCurrentEdit()
        FphcocoM_TA.Update(Me.DsTheriaque_Pharmacocinetique.FPHCOCOM_FPHCO_COM)

        Me.BindingContext(Me.MasterDataSet, FPHCOSP_PHARMACOCIN_SPEC).EndCurrentEdit()
        FphcosP_TA.Update(Me.DsTheriaque_Pharmacocinetique.FPHCOSP_PHARMACOCIN_SPEC)

        Me.BindingContext(Me.MasterDataSet, FPHCOAFS_FPHCO_AFSSAPS).EndCurrentEdit()
        FphcoafS_TA.Update(Me.DsTheriaque_Pharmacocinetique.FPHCOAFS_FPHCO_AFSSAPS)

        bModeDuplication = False
        'Tab_TA1 = True
    End Sub
    Public Overrides Sub annuler()
        OnLoading = True
        MyBase.Annuler()
        'Onglet Entités
        Me.BindingContext(DsTheriaque_Pharmacocinetique, FPHCOCPH_FPHCO_CLPH).CancelCurrentEdit()
        Me.DsTheriaque_Pharmacocinetique.FPHCOCPH_FPHCO_CLPH.RejectChanges()

        Me.BindingContext(DsTheriaque_Pharmacocinetique, FPHCOCCH_FPHCO_CLCH).CancelCurrentEdit()
        Me.DsTheriaque_Pharmacocinetique.FPHCOCCH_FPHCO_CLCH.RejectChanges()

        Me.BindingContext(DsTheriaque_Pharmacocinetique, FPHCOSAC_FPHCO_SUBACT).CancelCurrentEdit()
        Me.DsTheriaque_Pharmacocinetique.FPHCOSAC_FPHCO_SUBACT.RejectChanges()

        Me.BindingContext(DsTheriaque_Pharmacocinetique, FPHCOSAU_FPHCO_SUBAUX).CancelCurrentEdit()
        Me.DsTheriaque_Pharmacocinetique.FPHCOSAU_FPHCO_SUBAUX.RejectChanges()

        Me.BindingContext(DsTheriaque_Pharmacocinetique, FPHCOPR_FPHCO_PROD).CancelCurrentEdit()
        Me.DsTheriaque_Pharmacocinetique.FPHCOPR_FPHCO_PROD.RejectChanges()

        Me.BindingContext(DsTheriaque_Pharmacocinetique, FPHCOCOM_FPHCO_COM).CancelCurrentEdit()
        Me.DsTheriaque_Pharmacocinetique.FPHCOCOM_FPHCO_COM.RejectChanges()

        Me.BindingContext(DsTheriaque_Pharmacocinetique, FPHCOSP_PHARMACOCIN_SPEC).CancelCurrentEdit()
        Me.DsTheriaque_Pharmacocinetique.FPHCOSP_PHARMACOCIN_SPEC.RejectChanges()

        Me.BindingContext(DsTheriaque_Pharmacocinetique, FPHCOAFS_FPHCO_AFSSAPS).CancelCurrentEdit()
        Me.DsTheriaque_Pharmacocinetique.FPHCOAFS_FPHCO_AFSSAPS.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_Pharmacocinetique.FPHCO_PHARMACOCINETIQUE.RejectChanges()

        If bModeDuplication Then EmptyDataTable()
        bModeDuplication = False
        OnLoading = False
    End Sub
    Private Sub EmptyDataTable()
        Me.DsTheriaque_Pharmacocinetique.FPHCO_PHARMACOCINETIQUE.Clear()
        'Onglet Entités
        Me.DsTheriaque_Pharmacocinetique.FPHCOCPH_FPHCO_CLPH.Clear()
        Me.DsTheriaque_Pharmacocinetique.FPHCOCCH_FPHCO_CLCH.Clear()
        Me.DsTheriaque_Pharmacocinetique.FPHCOSAC_FPHCO_SUBACT.Clear()
        Me.DsTheriaque_Pharmacocinetique.FPHCOSAU_FPHCO_SUBAUX.Clear()
        Me.DsTheriaque_Pharmacocinetique.FPHCOPR_FPHCO_PROD.Clear()
        Me.DsTheriaque_Pharmacocinetique.FPHCOCOM_FPHCO_COM.Clear()
        Me.DsTheriaque_Pharmacocinetique.FPHCOSP_PHARMACOCIN_SPEC.Clear()
        Me.DsTheriaque_Pharmacocinetique.FPHCOAFS_FPHCO_AFSSAPS.Clear()
    End Sub
    ''' <summary>
    ''' Proçédure: Duplication des données à partir d'une autre fiche
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub Dupliquer()

        If Not Tab_TA1 And CodE <> InvalideControl And CodE <> Nothing Then LoadTab_1()

        'Sauvegarde des données à duplquer

        'Onglet entités
        Dim dt11 As New DataTable
        dt11 = DsTheriaque_Pharmacocinetique.FPHCOCPH_FPHCO_CLPH.Copy

        Dim dt12 As New DataTable
        dt12 = DsTheriaque_Pharmacocinetique.FPHCOCCH_FPHCO_CLCH.Copy

        Dim dt13 As New DataTable
        dt13 = DsTheriaque_Pharmacocinetique.FPHCOSAC_FPHCO_SUBACT.Copy

        Dim dt14 As New DataTable
        dt14 = DsTheriaque_Pharmacocinetique.FPHCOSAU_FPHCO_SUBAUX.Copy

        Dim dt15 As New DataTable
        dt15 = DsTheriaque_Pharmacocinetique.FPHCOPR_FPHCO_PROD.Copy

        Dim dt16 As New DataTable
        dt16 = DsTheriaque_Pharmacocinetique.FPHCOSP_PHARMACOCIN_SPEC.Copy

        'Onglet RefOff/Commentaires
        Dim dt21 As New DataTable
        dt21 = DsTheriaque_Pharmacocinetique.FPHCOCOM_FPHCO_COM.Copy

        Dim dt22 As New DataTable
        dt22 = DsTheriaque_Pharmacocinetique.FPHCOAFS_FPHCO_AFSSAPS.Copy



        Dim sText As String = MemoEdit3.Text

        'Vider les contrôles
        EmptyDataTable()

        'Construction de la nouvelle fiche avec les données de la fiche de base
        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        SetCode_MAx(MasterTable, txtCode)
        CodE = InvalideControl


        Dim drTemp As DataRow
        For iCount As Integer = 0 To dt11.Rows.Count - 1
            drTemp = DsTheriaque_Pharmacocinetique.Tables("FPHCOCPH_FPHCO_CLPH").NewRow()
            drTemp.ItemArray = dt11.Rows(iCount).ItemArray
            DsTheriaque_Pharmacocinetique.Tables("FPHCOCPH_FPHCO_CLPH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt12.Rows.Count - 1
            drTemp = DsTheriaque_Pharmacocinetique.Tables("FPHCOCCH_FPHCO_CLCH").NewRow()
            drTemp.ItemArray = dt12.Rows(iCount).ItemArray
            DsTheriaque_Pharmacocinetique.Tables("FPHCOCCH_FPHCO_CLCH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt13.Rows.Count - 1
            drTemp = DsTheriaque_Pharmacocinetique.Tables("FPHCOSAC_FPHCO_SUBACT").NewRow()
            drTemp.ItemArray = dt13.Rows(iCount).ItemArray
            DsTheriaque_Pharmacocinetique.Tables("FPHCOSAC_FPHCO_SUBACT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt14.Rows.Count - 1
            drTemp = DsTheriaque_Pharmacocinetique.Tables("FPHCOSAU_FPHCO_SUBAUX").NewRow()
            drTemp.ItemArray = dt14.Rows(iCount).ItemArray
            DsTheriaque_Pharmacocinetique.Tables("FPHCOSAU_FPHCO_SUBAUX").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt15.Rows.Count - 1
            drTemp = DsTheriaque_Pharmacocinetique.Tables("FPHCOPR_FPHCO_PROD").NewRow()
            drTemp.ItemArray = dt15.Rows(iCount).ItemArray
            DsTheriaque_Pharmacocinetique.Tables("FPHCOPR_FPHCO_PROD").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt16.Rows.Count - 1
            drTemp = DsTheriaque_Pharmacocinetique.Tables("FPHCOSP_PHARMACOCIN_SPEC").NewRow()
            drTemp.ItemArray = dt16.Rows(iCount).ItemArray
            DsTheriaque_Pharmacocinetique.Tables("FPHCOSP_PHARMACOCIN_SPEC").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt21.Rows.Count - 1
            drTemp = DsTheriaque_Pharmacocinetique.Tables("FPHCOCOM_FPHCO_COM").NewRow()
            drTemp.ItemArray = dt21.Rows(iCount).ItemArray
            DsTheriaque_Pharmacocinetique.Tables("FPHCOCOM_FPHCO_COM").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt22.Rows.Count - 1
            drTemp = DsTheriaque_Pharmacocinetique.Tables("FPHCOAFS_FPHCO_AFSSAPS").NewRow()
            drTemp.ItemArray = dt22.Rows(iCount).ItemArray
            DsTheriaque_Pharmacocinetique.Tables("FPHCOAFS_FPHCO_AFSSAPS").Rows.Add(drTemp)
        Next

        MemoEdit3.Text = sText

        ModifierCode()
        bModeDuplication = True
        MyBase.Dupliquer()
        XtraTabControl1.SelectedTabPageIndex = 0
    End Sub

    ''' <summary>
    ''' Proçédure: Modifier code Master de la fiche
    ''' </summary>
    Private Sub ModifierCode()
        'GV11
        For iCount As Integer = 0 To GV11.RowCount - 1
            GV11.SetRowCellValue(iCount, colFPHCOCPH_FPHCO_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV12
        For iCount As Integer = 0 To GV12.RowCount - 1
            GV12.SetRowCellValue(iCount, colFPHCOCCH_FPHCO_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV13
        For iCount As Integer = 0 To GV13.RowCount - 1
            GV13.SetRowCellValue(iCount, colFPHCOSAC_FPHCO_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV14
        For iCount As Integer = 0 To GV14.RowCount - 1
            GV14.SetRowCellValue(iCount, colFPHCOSAU_FPHCO_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV15
        For iCount As Integer = 0 To GV15.RowCount - 1
            GV15.SetRowCellValue(iCount, colFPHCOPR_FPHCO_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV16
        For iCount As Integer = 0 To GV16.RowCount - 1
            GV16.SetRowCellValue(iCount, colFPHCOSP_FPHCO_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV21
        For iCount As Integer = 0 To GV21.RowCount - 1
            GV21.SetRowCellValue(iCount, colFPHCOCOM_FPHCO_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV22
        For iCount As Integer = 0 To GV23.RowCount - 1
            GV23.SetRowCellValue(iCount, colFPHCOAFS_FPHCO_CODE_FK_PK, Me.txtCode.Text)
        Next
    End Sub

    Protected Friend Overrides Function ValideControl(Optional ByRef Ctrl As Control = Nothing, Optional ByVal AllCtrl As Boolean = True) As Boolean
        Dim strSSQL As String = ""
        MyBase.ValideControl(Ctrl)
        For iCount As Integer = 0 To GV23.RowCount - 1
            If Not FieldExistRO(GV16, colFPHCOSP_SP_CODE_FK_PK, GV23.GetRowCellValue(iCount, colFPHCOAFS_SP_CODE_FK_PK)) Then
                GV23.FocusedRowHandle = iCount
                GV23.SetColumnError(colFPHCOAFS_SP_CODE_FK_PK, "La spécialité doit être présente dans la fiche.")
                XtraTabControl1.SelectedTabPageIndex = 1
                Exit Function
            Else
                GV23.SetColumnError(colFPHCOAFS_SP_CODE_FK_PK, "")
            End If
        Next

        Return True
    End Function

#End Region

#Region " Init Data  "

    Private Sub InitDataSource()
        'Onglet Entités
        GC11.DataSource = DsTheriaque_Pharmacocinetique
        GC11.DataMember = FPHCOCPH_FPHCO_CLPH

        GC12.DataSource = DsTheriaque_Pharmacocinetique
        GC12.DataMember = FPHCOCCH_FPHCO_CLCH

        GC13.DataSource = DsTheriaque_Pharmacocinetique
        GC13.DataMember = FPHCOSAC_FPHCO_SUBACT

        GC14.DataSource = DsTheriaque_Pharmacocinetique
        GC14.DataMember = FPHCOSAU_FPHCO_SUBAUX

        GC15.DataSource = DsTheriaque_Pharmacocinetique
        GC15.DataMember = FPHCOPR_FPHCO_PROD

        GC16.DataSource = DsTheriaque_Pharmacocinetique
        GC16.DataMember = FPHCOSP_PHARMACOCIN_SPEC

        GC21.DataSource = DsTheriaque_Pharmacocinetique
        GC21.DataMember = FPHCOCOM_FPHCO_COM

        GC23.DataSource = DsTheriaque_Pharmacocinetique
        GC23.DataMember = FPHCOAFS_FPHCO_AFSSAPS

    End Sub

    Public Overrides Sub InitData()
        MyBase.InitData()
        OnLoading = True
        Declinaison_Global = True
        MasterDataSet = Me.DsTheriaque_Pharmacocinetique
        MasterTable = FPHCO_PHARMACOCINETIQUE
        CodE = InvalideControl

        'Déclinaison classe CPH
        Dim List1 As New System.Collections.Generic.List(Of StructGVTable)
        List1.Add(New StructGVTable("GC11", eDeclinaison.CPH, colFPHCOCPH_CPH_CODE_FK_PK2))
        List1.Add(New StructGVTable("GC12", eDeclinaison.CCH, colFPHCOCCH_CCH_CODE_FK_PK2))
        List1.Add(New StructGVTable("GC13", eDeclinaison.SAC, colFPHCOSAC_SAC_CODE_FK_PK2))
        List1.Add(New StructGVTable("GC16", eDeclinaison.SP, colFPHCOSP_SP_CODE_FK_PK2))
        Dim DecCPH As New ClsDeclinaison(eDeclinaison.CPH, List1)
        InitLkup(Me.lkup_FPHCOCPH, FPHCOCPH_FPHCO_CLPH, strSSQL_CPH_CLASSEPHARMTHER_NIVEAU, True, , , , , , DecCPH)

        'Déclinaison classe CCH
        Dim List2 As New System.Collections.Generic.List(Of StructGVTable)
        List2.Add(New StructGVTable("GC11", eDeclinaison.CPH, colFPHCOCPH_CPH_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC12", eDeclinaison.CCH, colFPHCOCCH_CCH_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC13", eDeclinaison.SAC, colFPHCOSAC_SAC_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC16", eDeclinaison.SP, colFPHCOSP_SP_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC14", eDeclinaison.SAU, colFPHCOSAU_SAU_CODE_FK_PK2))
        Dim DecCCH As New ClsDeclinaison(eDeclinaison.CCH, List2)
        InitLkup(Me.lkup_FPHCOCCH, FPHCOCCH_FPHCO_CLCH, strSSQL_CCH_CLASSECHIMIQUE_NIVEAU, True, , , , , , DecCCH)

        'Déclinaison SUBAC
        Dim List3 As New System.Collections.Generic.List(Of StructGVTable)
        List3.Add(New StructGVTable("GC13", eDeclinaison.SAC, colFPHCOSAC_SAC_CODE_FK_PK2))
        List3.Add(New StructGVTable("GC16", eDeclinaison.SP, colFPHCOSP_SP_CODE_FK_PK2))
        Dim DecSUBAC As New ClsDeclinaison(eDeclinaison.SAC, List3)
        InitLkup(Me.lkup_FPHCOSAC, FPHCOSAC_FPHCO_SUBACT, strSSQL_SAC_SUBACTIVE, True, , , , , , DecSUBAC)

        'Déclinaison SAU
        Dim List4 As New System.Collections.Generic.List(Of StructGVTable)
        List4.Add(New StructGVTable("GC14", eDeclinaison.SAU, colFPHCOSAU_SAU_CODE_FK_PK2))
        List4.Add(New StructGVTable("GC16", eDeclinaison.SP, colFPHCOSP_SP_CODE_FK_PK2))
        Dim DecSAU As New ClsDeclinaison(eDeclinaison.SAU, List4)
        InitLkup(Me.lkup_FPHCOSAU, FPHCOSAU_FPHCO_SUBAUX, strSSQL_SAU_SUBAUXILIAIRE, True, , , , , , DecSAU)

        'Déclinaison PRODUIT
        Dim List5 As New System.Collections.Generic.List(Of StructGVTable)
        List5.Add(New StructGVTable("GC15", eDeclinaison.PR, colFPHCOPR_PR_CODE_FK_PK2))
        List5.Add(New StructGVTable("GC16", eDeclinaison.SP, colFPHCOSP_SP_CODE_FK_PK2))
        Dim DecPR As New ClsDeclinaison(eDeclinaison.PR, List5)
        InitLkup(Me.lkup_FPHCOPR, FPHCOPR_FPHCO_PROD, strSSQL_PR_PRODUIT, True, , , , , , DecPR)

        InitLkup(Me.lkup_FPHCOSP, FPHCOSP_PHARMACOCIN_SPEC, strSSQL_SP_SPECIALITE, True)

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
        Me.FphcO_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCO_PHARMACOCINETIQUE, CodE1)

        'Onglet Entités
        Me.FphcocpH_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCOCPH_FPHCO_CLPH, CodE1)
        Me.FphcoccH_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCOCCH_FPHCO_CLCH, CodE1)
        Me.FphcosaC_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCOSAC_FPHCO_SUBACT, CodE1)
        Me.FphcosaU_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCOSAU_FPHCO_SUBAUX, CodE1)
        Me.FphcopR_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCOPR_FPHCO_PROD, CodE1)
        Me.FphcosP_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCOSP_PHARMACOCIN_SPEC, CodE1)

        Tab_TA1 = False
        OnLoading = False
    End Sub

#End Region

#Region " Chargement par onglet "
    Private Sub LoadTab_1()
        Load_On(Me)
        OnLoading = True
        If CodE <> InvalideControl And CodE <> Nothing Then
            Dim strSSQL_SP_REF As String
            strSSQL_SP_REF = " SELECT SP_CODE_SQ_PK as code, SP_NOM as libelle FROM THERIAQUE.FPHCOSP_PHARMACOCIN_SPEC, THERIAQUE.SP_SPECIALITE"
            strSSQL_SP_REF &= " WHERE FPHCOSP_FPHCO_CODE_FK_PK = " & CodE
            strSSQL_SP_REF &= " AND SP_CODE_SQ_PK = FPHCOSP_SP_CODE_FK_PK"
            InitLkup(Me.lkup_AFS, FPHCO_PHARMACOCINETIQUE, strSSQL_SP_REF, True)
            For iCount As Integer = 0 To GV23.RowCount
                If GV23.GetRowCellDisplayText(iCount, "FPHCOAFS_SP_CODE_FK_PK") = "" And GV23.GetRowCellDisplayText(iCount, "FPHCOAFS_FPHCO_CODE_FK_PK") <> "" Then
                    GV23.DeleteRow(iCount)
                    iCount = iCount - 1
                End If
            Next
        End If
        If Not Tab_lkup1 Then
            InitLkup(Me.lkup_FPHCOCOM, FPHCOCOM_FPHCO_COM, strSSQL_CDF_CODIF("PK"), True)
            InitLkup(Me.lkup_FPHCOAFS, FPHCOAFS_FPHCO_AFSSAPS, strSSQL_CDF_CODIF("25"), True)
            Tab_lkup1 = True
        End If

        If Not Tab_TA1 And CodE <> InvalideControl And CodE <> Nothing Then
            'Onglet Réf.officielles
            Me.FphcocoM_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCOCOM_FPHCO_COM, CodE)
            Me.FphcO_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCO_PHARMACOCINETIQUE, CodE)
            Me.FphcoafS_TA.FillByCode(Me.DsTheriaque_Pharmacocinetique.FPHCOAFS_FPHCO_AFSSAPS, CodE)
            Tab_TA1 = True
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub
#End Region

#Region " NewRow     "

    Private Sub GV11_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV11.InitNewRow
        If OnLoading Then Exit Sub
        GV11.SetFocusedRowCellValue(colFPHCOCPH_FPHCO_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV12_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV12.InitNewRow
        If OnLoading Then Exit Sub
        GV12.SetFocusedRowCellValue(colFPHCOCCH_FPHCO_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV13_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV13.InitNewRow
        If OnLoading Then Exit Sub
        GV13.SetFocusedRowCellValue(colFPHCOSAC_FPHCO_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV14_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV14.InitNewRow
        If OnLoading Then Exit Sub
        GV14.SetFocusedRowCellValue(colFPHCOSAU_FPHCO_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV15_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV15.InitNewRow
        If OnLoading Then Exit Sub
        GV15.SetFocusedRowCellValue(colFPHCOPR_FPHCO_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV21_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV21.InitNewRow
        If OnLoading Then Exit Sub
        GV21.SetFocusedRowCellValue(colFPHCOCOM_FPHCO_CODE_FK_PK, txtCode.Text)
        GV21.SetFocusedRowCellValue(colFPHCOCOM_NUMORD, Code_MAx(GV21, colFPHCOCOM_NUMORD))
    End Sub
    Private Sub GV16_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV16.InitNewRow
        If OnLoading Then Exit Sub
        GV16.SetFocusedRowCellValue(colFPHCOSP_FPHCO_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV23_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV23.InitNewRow
        If OnLoading Then Exit Sub
        GV23.SetFocusedRowCellValue(colFPHCOAFS_FPHCO_CODE_FK_PK, txtCode.Text)
    End Sub

#End Region

#Region " Panel Resize  "

    Private Sub Panel5_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel5.Resize
        GC11.Width = Panel5.Width / 2
        GC12.Width = Panel5.Width / 2
    End Sub
    Private Sub Panel2_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel2.Resize
        GC13.Width = Panel2.Width / 2
        GC14.Width = Panel2.Width / 2
    End Sub
    Private Sub Panel3_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.Resize
        GC15.Width = Panel3.Width / 2
        GC16.Width = Panel3.Width / 2
    End Sub
    Private Sub XtraTabControl1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraTabControl1.Resize
        Panel2.Height = XtraTabControl1.Height / 3
        Panel3.Height = XtraTabControl1.Height / 3
        Panel5.Height = XtraTabControl1.Height / 3

        Panel6.Height = XtraTabControl1.Height / 3
        Panel7.Height = XtraTabControl1.Height / 3
        Panel4.Height = XtraTabControl1.Height / 3
    End Sub
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPageIndex = 1 Then
            LoadTab_1()
            Exit Sub
        End If
    End Sub

#End Region

End Class

