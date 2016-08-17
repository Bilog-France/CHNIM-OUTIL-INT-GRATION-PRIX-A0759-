''' <summary>
''' Created By [BFE]
''' </summary>
''' <remarks>Monographie - CIPEMG_TEXTE</remarks>
Public Class Frm_Cipemg_Texte

#Region "Déclaration des variables privées"
    Private CodE As String
    Public _Code As Integer = Nothing ' charger la fiche depuis l'extérieur
    Private Tab_lkup1 As Boolean = False
    Private Tab_TA1 As Boolean = False
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
        f._SSQL = strSSQL_FCPT_FICHECIPEMG_SPECIALITE()
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            XtraTabControl1.SelectedTabPageIndex = 0
            OnLoading = True
            EmptyDataTable()
            Me.FcpT_TA.FillByCode(Me.DsTheriaque_Cipemg_Texte.FCPT_FICHECIPEMG, f._Code)
            'Onglet Entités
            Me.FcptcpH_TA.FillByCode(Me.DsTheriaque_Cipemg_Texte.FCPTCPH_CIPEMG_CLPH, f._Code)
            Me.FcptccH_TA.FillByCode(Me.DsTheriaque_Cipemg_Texte.FCPTCCH_CIPEMG_CLCH, f._Code)
            Me.FcptsaC_TA.FillByCode(Me.DsTheriaque_Cipemg_Texte.FCPTSAC_CIPEMG_SUBAC, f._Code)
            Me.FcptsaU_TA.FillByCode(Me.DsTheriaque_Cipemg_Texte.FCPTSAU_CIPEMG_SUBAU, f._Code)
            Me.FcptpR_TA.FillByCode(Me.DsTheriaque_Cipemg_Texte.FCPTPR_CIPEMG_PROD, f._Code)
            Me.FcptsP_TA.FillByCode(Me.DsTheriaque_Cipemg_Texte.FCPTSP_CIPEMG_SPE, f._Code)

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
        Dim sCodePR As String = ""
        Dim sCodeSAC As String = ""
        Dim sCodeSAU As String = ""
        Dim sCodeSP As String = ""
        Dim f As New Frm_CipemgTxtMultiCriteres
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
            Dim fResultat As New Frm_Recherche
            Dim sSQL As String = ""
            sSQL &= " Select FCPT_CODE_SQ_PK as code, '' as libelle From THERIAQUE.FCPT_FICHECIPEMG"
            If sCodeCPH <> "" Then
                sSQL &= " WHERE FCPT_CODE_SQ_PK IN (SELECT FCPTCPH_FCPT_CODE_FK_PK FROM THERIAQUE.FCPTCPH_CIPEMG_CLPH WHERE FCPTCPH_CPH_CODE_FK_PK = " & cn.SQLText(sCodeCPH) & ")"
            End If
            If sCodeCCH <> "" Then
                If sCodeCPH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FCPT_CODE_SQ_PK IN (SELECT FCPTCCH_FCPT_CODE_FK_PK FROM THERIAQUE.FCPTCCH_CIPEMG_CLCH WHERE FCPTCCH_CCH_CODE_FK_PK = " & cn.SQLText(sCodeCCH) & ")"
            End If
            If sCodeSAC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FCPT_CODE_SQ_PK IN (SELECT FCPTSAC_FCPT_CODE_FK_PK FROM THERIAQUE.FCPTSAC_CIPEMG_SUBAC WHERE FCPTSAC_SAC_CODE_FK_PK = " & cn.SQLText(sCodeSAC) & ")"
            End If
            If sCodeSAU <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FCPT_CODE_SQ_PK IN (SELECT FCPTSAU_FCPT_CODE_FK_PK FROM THERIAQUE.FCPTSAU_CIPEMG_SUBAU WHERE FCPTSAU_SAU_CODE_FK_PK = " & cn.SQLText(sCodeSAU) & ")"
            End If
            If sCodePR <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FCPT_CODE_SQ_PK IN (SELECT FCPTPR_FCPT_CODE_FK_PK FROM THERIAQUE.FCPTPR_CIPEMG_PROD WHERE FCPTPR_PR_CODE_FK_PK = " & cn.SQLText(sCodePR) & ")"
            End If
            If sCodeSP <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FCPT_CODE_SQ_PK IN (SELECT FCPTSP_FCPT_CODE_FK_PK FROM THERIAQUE.FCPTSP_CIPEMG_SPE WHERE FCPTSP_SP_CODE_FK_PK = " & cn.SQLText(sCodeSP) & ")"
            End If
            sSQL &= " ORDER BY FCPT_CODE_SQ_PK"

            fResultat._SSQL = sSQL
            fResultat.Text = Me.Text
            fResultat.ShowDialog()
            CodE = fResultat._Code
            If fResultat._Code IsNot Nothing Then
                XtraTabControl1.SelectedTabPageIndex = 0
                OnLoading = True
                EmptyDataTable()
                Me.FcpT_TA.FillByCode(Me.DsTheriaque_Cipemg_Texte.FCPT_FICHECIPEMG, fResultat._Code)
                'Onglet Entités
                Me.FcptcpH_TA.FillByCode(Me.DsTheriaque_Cipemg_Texte.FCPTCPH_CIPEMG_CLPH, fResultat._Code)
                Me.FcptccH_TA.FillByCode(Me.DsTheriaque_Cipemg_Texte.FCPTCCH_CIPEMG_CLCH, fResultat._Code)
                Me.FcptsaC_TA.FillByCode(Me.DsTheriaque_Cipemg_Texte.FCPTSAC_CIPEMG_SUBAC, fResultat._Code)
                Me.FcptsaU_TA.FillByCode(Me.DsTheriaque_Cipemg_Texte.FCPTSAU_CIPEMG_SUBAU, fResultat._Code)
                Me.FcptpR_TA.FillByCode(Me.DsTheriaque_Cipemg_Texte.FCPTPR_CIPEMG_PROD, fResultat._Code)
                Me.FcptsP_TA.FillByCode(Me.DsTheriaque_Cipemg_Texte.FCPTSP_CIPEMG_SPE, fResultat._Code)

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
        If Tab_TA1 Then
            MyBase.Supprimer()
            Dim iCount As Integer
            'Onglet Entités
            For iCount = 0 To DsTheriaque_Cipemg_Texte.FCPTCPH_CIPEMG_CLPH.Rows.Count - 1
                DsTheriaque_Cipemg_Texte.FCPTCPH_CIPEMG_CLPH.Rows(iCount).Delete()
            Next
            Me.FcptcpH_TA.Update(DsTheriaque_Cipemg_Texte)

            For iCount = 0 To DsTheriaque_Cipemg_Texte.FCPTCCH_CIPEMG_CLCH.Rows.Count - 1
                DsTheriaque_Cipemg_Texte.FCPTCCH_CIPEMG_CLCH.Rows(iCount).Delete()
            Next
            Me.FcptccH_TA.Update(DsTheriaque_Cipemg_Texte)

            For iCount = 0 To DsTheriaque_Cipemg_Texte.FCPTSAC_CIPEMG_SUBAC.Rows.Count - 1
                DsTheriaque_Cipemg_Texte.FCPTSAC_CIPEMG_SUBAC.Rows(iCount).Delete()
            Next
            Me.FcptsaC_TA.Update(DsTheriaque_Cipemg_Texte)

            For iCount = 0 To DsTheriaque_Cipemg_Texte.FCPTSAU_CIPEMG_SUBAU.Rows.Count - 1
                DsTheriaque_Cipemg_Texte.FCPTSAU_CIPEMG_SUBAU.Rows(iCount).Delete()
            Next
            Me.FcptsaU_TA.Update(DsTheriaque_Cipemg_Texte)

            For iCount = 0 To DsTheriaque_Cipemg_Texte.FCPTPR_CIPEMG_PROD.Rows.Count - 1
                DsTheriaque_Cipemg_Texte.FCPTPR_CIPEMG_PROD.Rows(iCount).Delete()
            Next
            Me.FcptpR_TA.Update(DsTheriaque_Cipemg_Texte)

            For iCount = 0 To DsTheriaque_Cipemg_Texte.FCPTSP_CIPEMG_SPE.Rows.Count - 1
                DsTheriaque_Cipemg_Texte.FCPTSP_CIPEMG_SPE.Rows(iCount).Delete()
            Next
            Me.FcptsP_TA.Update(DsTheriaque_Cipemg_Texte)

            'Onglet Références officielles
            For iCount = 0 To DsTheriaque_Cipemg_Texte.FCPTAFS_CIPEMG_AFSSAPS.Rows.Count - 1
                DsTheriaque_Cipemg_Texte.FCPTAFS_CIPEMG_AFSSAPS.Rows(iCount).Delete()
            Next
            Me.FcptafS_TA.Update(DsTheriaque_Cipemg_Texte)

            For iCount = 0 To DsTheriaque_Cipemg_Texte.FCPTTX1_CIPEMG_TXCI.Rows.Count - 1
                DsTheriaque_Cipemg_Texte.FCPTTX1_CIPEMG_TXCI.Rows(iCount).Delete()
            Next
            Me.FcpttX1_TA.Update(DsTheriaque_Cipemg_Texte)

            For iCount = 0 To DsTheriaque_Cipemg_Texte.FCPTTX2_CIPEMG_TXPEMG.Rows.Count - 1
                DsTheriaque_Cipemg_Texte.FCPTTX2_CIPEMG_TXPEMG.Rows(iCount).Delete()
            Next
            Me.FcpttX2_TA.Update(DsTheriaque_Cipemg_Texte)

            ' Master
            DsTheriaque_Cipemg_Texte.FCPT_FICHECIPEMG.Rows(0).Delete()
            Me.FcpT_TA.Update(Me.MasterDataSet)

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
        FcpT_TA.Update(Me.DsTheriaque_Cipemg_Texte.FCPT_FICHECIPEMG)

        'Onglet Entités
        Me.BindingContext(Me.MasterDataSet, FCPTCPH_CIPEMG_CLPH).EndCurrentEdit()
        FcptcpH_TA.Update(Me.DsTheriaque_Cipemg_Texte.FCPTCPH_CIPEMG_CLPH)

        Me.BindingContext(Me.MasterDataSet, FCPTCCH_CIPEMG_CLCH).EndCurrentEdit()
        FcptccH_TA.Update(Me.DsTheriaque_Cipemg_Texte.FCPTCCH_CIPEMG_CLCH)

        Me.BindingContext(Me.MasterDataSet, FCPTSAC_CIPEMG_SUBAC).EndCurrentEdit()
        FcptsaC_TA.Update(Me.DsTheriaque_Cipemg_Texte.FCPTSAC_CIPEMG_SUBAC)

        Me.BindingContext(Me.MasterDataSet, FCPTSAU_CIPEMG_SUBAU).EndCurrentEdit()
        FcptsaU_TA.Update(Me.DsTheriaque_Cipemg_Texte.FCPTSAU_CIPEMG_SUBAU)

        Me.BindingContext(Me.MasterDataSet, FCPTPR_CIPEMG_PROD).EndCurrentEdit()
        FcptpR_TA.Update(Me.DsTheriaque_Cipemg_Texte.FCPTPR_CIPEMG_PROD)

        Me.BindingContext(Me.MasterDataSet, FCPTSP_CIPEMG_SPE).EndCurrentEdit()
        FcptsP_TA.Update(Me.DsTheriaque_Cipemg_Texte.FCPTSP_CIPEMG_SPE)

        'Onglet Références officielles
        Me.BindingContext(Me.MasterDataSet, FCPTAFS_CIPEMG_AFSSAPS).EndCurrentEdit()
        FcptafS_TA.Update(Me.DsTheriaque_Cipemg_Texte.FCPTAFS_CIPEMG_AFSSAPS)

        Me.BindingContext(Me.MasterDataSet, FCPTTX1_CIPEMG_TXCI).EndCurrentEdit()
        FcpttX1_TA.Update(Me.DsTheriaque_Cipemg_Texte.FCPTTX1_CIPEMG_TXCI)

        Me.BindingContext(Me.MasterDataSet, FCPTTX2_CIPEMG_TXPEMG).EndCurrentEdit()
        FcpttX2_TA.Update(Me.DsTheriaque_Cipemg_Texte.FCPTTX2_CIPEMG_TXPEMG)

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
        Me.BindingContext(DsTheriaque_Cipemg_Texte, FCPTCPH_CIPEMG_CLPH).CancelCurrentEdit()
        Me.DsTheriaque_Cipemg_Texte.FCPTCPH_CIPEMG_CLPH.RejectChanges()

        Me.BindingContext(DsTheriaque_Cipemg_Texte, FCPTCCH_CIPEMG_CLCH).CancelCurrentEdit()
        Me.DsTheriaque_Cipemg_Texte.FCPTCCH_CIPEMG_CLCH.RejectChanges()

        Me.BindingContext(DsTheriaque_Cipemg_Texte, FCPTSAC_CIPEMG_SUBAC).CancelCurrentEdit()
        Me.DsTheriaque_Cipemg_Texte.FCPTSAC_CIPEMG_SUBAC.RejectChanges()

        Me.BindingContext(DsTheriaque_Cipemg_Texte, FCPTSAU_CIPEMG_SUBAU).CancelCurrentEdit()
        Me.DsTheriaque_Cipemg_Texte.FCPTSAU_CIPEMG_SUBAU.RejectChanges()

        Me.BindingContext(DsTheriaque_Cipemg_Texte, FCPTPR_CIPEMG_PROD).CancelCurrentEdit()
        Me.DsTheriaque_Cipemg_Texte.FCPTPR_CIPEMG_PROD.RejectChanges()

        Me.BindingContext(DsTheriaque_Cipemg_Texte, FCPTSP_CIPEMG_SPE).CancelCurrentEdit()
        Me.DsTheriaque_Cipemg_Texte.FCPTSP_CIPEMG_SPE.RejectChanges()

        'Onglet Références officielles
        Me.BindingContext(DsTheriaque_Cipemg_Texte, FCPTAFS_CIPEMG_AFSSAPS).CancelCurrentEdit()
        Me.DsTheriaque_Cipemg_Texte.FCPTAFS_CIPEMG_AFSSAPS.RejectChanges()

        Me.BindingContext(DsTheriaque_Cipemg_Texte, FCPTTX1_CIPEMG_TXCI).CancelCurrentEdit()
        Me.DsTheriaque_Cipemg_Texte.FCPTTX1_CIPEMG_TXCI.RejectChanges()

        Me.BindingContext(DsTheriaque_Cipemg_Texte, FCPTTX2_CIPEMG_TXPEMG).CancelCurrentEdit()
        Me.DsTheriaque_Cipemg_Texte.FCPTTX2_CIPEMG_TXPEMG.RejectChanges()
        'Master
        Me.BindingContext(Me.MasterDataSet, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_Cipemg_Texte.FCPT_FICHECIPEMG.RejectChanges()

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
        Me.DsTheriaque_Cipemg_Texte.FCPT_FICHECIPEMG.Clear()
        'Onglet Entités
        Me.DsTheriaque_Cipemg_Texte.FCPTCPH_CIPEMG_CLPH.Clear()
        Me.DsTheriaque_Cipemg_Texte.FCPTCCH_CIPEMG_CLCH.Clear()
        Me.DsTheriaque_Cipemg_Texte.FCPTSAC_CIPEMG_SUBAC.Clear()
        Me.DsTheriaque_Cipemg_Texte.FCPTSAU_CIPEMG_SUBAU.Clear()
        Me.DsTheriaque_Cipemg_Texte.FCPTPR_CIPEMG_PROD.Clear()
        Me.DsTheriaque_Cipemg_Texte.FCPTSP_CIPEMG_SPE.Clear()

        'Onglet Références officielles
        Me.DsTheriaque_Cipemg_Texte.FCPTAFS_CIPEMG_AFSSAPS.Clear()
        Me.DsTheriaque_Cipemg_Texte.FCPTTX1_CIPEMG_TXCI.Clear()
        Me.DsTheriaque_Cipemg_Texte.FCPTTX2_CIPEMG_TXPEMG.Clear()

    End Sub

    ''' <summary>
    ''' Proçédure: Duplication des données à partir d'une autre fiche
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub Dupliquer()

        If Not Tab_TA1 And CodE <> InvalideControl And CodE <> Nothing Then LoadTab_1()

        'Sauvegarde des données à duplquer

        'Onglet entités
        Dim dt1 As New DataTable
        dt1 = DsTheriaque_Cipemg_Texte.FCPTCPH_CIPEMG_CLPH.Copy

        Dim dt2 As New DataTable
        dt2 = DsTheriaque_Cipemg_Texte.FCPTCCH_CIPEMG_CLCH.Copy

        Dim dt3 As New DataTable
        dt3 = DsTheriaque_Cipemg_Texte.FCPTSAC_CIPEMG_SUBAC.Copy

        Dim dt4 As New DataTable
        dt4 = DsTheriaque_Cipemg_Texte.FCPTSAU_CIPEMG_SUBAU.Copy

        Dim dt5 As New DataTable
        dt5 = DsTheriaque_Cipemg_Texte.FCPTPR_CIPEMG_PROD.Copy

        Dim dt6 As New DataTable
        dt6 = DsTheriaque_Cipemg_Texte.FCPTSP_CIPEMG_SPE.Copy

        'Onglet RefOff/Commentaires
        Dim dt21 As New DataTable
        dt21 = DsTheriaque_Cipemg_Texte.FCPTAFS_CIPEMG_AFSSAPS.Copy

        Dim dt22 As New DataTable
        dt22 = DsTheriaque_Cipemg_Texte.FCPTTX1_CIPEMG_TXCI.Copy

        Dim dt23 As New DataTable
        dt23 = DsTheriaque_Cipemg_Texte.FCPTTX2_CIPEMG_TXPEMG.Copy

        'Vider les contrôles
        EmptyDataTable()

        'Construction de la nouvelle fiche avec les données de la fiche de base
        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        SetCode_MAx(MasterTable, txtCode)
        CodE = InvalideControl

        Dim drTemp As DataRow
        For iCount As Integer = 0 To dt1.Rows.Count - 1
            drTemp = DsTheriaque_Cipemg_Texte.Tables("FCPTCPH_CIPEMG_CLPH").NewRow()
            drTemp.ItemArray = dt1.Rows(iCount).ItemArray
            DsTheriaque_Cipemg_Texte.Tables("FCPTCPH_CIPEMG_CLPH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt2.Rows.Count - 1
            drTemp = DsTheriaque_Cipemg_Texte.Tables("FCPTCCH_CIPEMG_CLCH").NewRow()
            drTemp.ItemArray = dt2.Rows(iCount).ItemArray
            DsTheriaque_Cipemg_Texte.Tables("FCPTCCH_CIPEMG_CLCH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt3.Rows.Count - 1
            drTemp = DsTheriaque_Cipemg_Texte.Tables("FCPTSAC_CIPEMG_SUBAC").NewRow()
            drTemp.ItemArray = dt3.Rows(iCount).ItemArray
            DsTheriaque_Cipemg_Texte.Tables("FCPTSAC_CIPEMG_SUBAC").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt4.Rows.Count - 1
            drTemp = DsTheriaque_Cipemg_Texte.Tables("FCPTSAU_CIPEMG_SUBAU").NewRow()
            drTemp.ItemArray = dt4.Rows(iCount).ItemArray
            DsTheriaque_Cipemg_Texte.Tables("FCPTSAU_CIPEMG_SUBAU").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt5.Rows.Count - 1
            drTemp = DsTheriaque_Cipemg_Texte.Tables("FCPTPR_CIPEMG_PROD").NewRow()
            drTemp.ItemArray = dt5.Rows(iCount).ItemArray
            DsTheriaque_Cipemg_Texte.Tables("FCPTPR_CIPEMG_PROD").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt6.Rows.Count - 1
            drTemp = DsTheriaque_Cipemg_Texte.Tables("FCPTSP_CIPEMG_SPE").NewRow()
            drTemp.ItemArray = dt6.Rows(iCount).ItemArray
            DsTheriaque_Cipemg_Texte.Tables("FCPTSP_CIPEMG_SPE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt21.Rows.Count - 1
            drTemp = DsTheriaque_Cipemg_Texte.Tables("FCPTAFS_CIPEMG_AFSSAPS").NewRow()
            drTemp.ItemArray = dt21.Rows(iCount).ItemArray
            DsTheriaque_Cipemg_Texte.Tables("FCPTAFS_CIPEMG_AFSSAPS").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt22.Rows.Count - 1
            drTemp = DsTheriaque_Cipemg_Texte.Tables("FCPTTX1_CIPEMG_TXCI").NewRow()
            drTemp.ItemArray = dt22.Rows(iCount).ItemArray
            DsTheriaque_Cipemg_Texte.Tables("FCPTTX1_CIPEMG_TXCI").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt23.Rows.Count - 1
            drTemp = DsTheriaque_Cipemg_Texte.Tables("FCPTTX2_CIPEMG_TXPEMG").NewRow()
            drTemp.ItemArray = dt23.Rows(iCount).ItemArray
            DsTheriaque_Cipemg_Texte.Tables("FCPTTX2_CIPEMG_TXPEMG").Rows.Add(drTemp)
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
            GV1.SetRowCellValue(iCount, colFCPTCPH_FCPT_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV2
        For iCount As Integer = 0 To GV2.RowCount - 1
            GV2.SetRowCellValue(iCount, colFCPTCCH_FCPT_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV3
        For iCount As Integer = 0 To GV3.RowCount - 1
            GV3.SetRowCellValue(iCount, colFCPTSAC_FCPT_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV4
        For iCount As Integer = 0 To GV4.RowCount - 1
            GV4.SetRowCellValue(iCount, colFCPTSAU_FCPT_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV5
        For iCount As Integer = 0 To GV5.RowCount - 1
            GV5.SetRowCellValue(iCount, colFCPTPR_FCPT_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV6
        For iCount As Integer = 0 To GV6.RowCount - 1
            GV6.SetRowCellValue(iCount, colFCPTSP_FCPT_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV21
        For iCount As Integer = 0 To GV21.RowCount - 1
            GV21.SetRowCellValue(iCount, colFCPTAFS_FCPT_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV22
        For iCount As Integer = 0 To GV22.RowCount - 1
            GV22.SetRowCellValue(iCount, colFCPTTX1_FCPT_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV23
        For iCount As Integer = 0 To GV23.RowCount - 1
            GV23.SetRowCellValue(iCount, colFCPTTX2_FCPT_CODE_FK_PK, Me.txtCode.Text)
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
        For iCount As Integer = 0 To GV21.RowCount - 1
            If Not FieldExistRO(GV6, colFCPTSP_SP_CODE_FK_PK, GV21.GetRowCellValue(iCount, colFCPTAFS_SP_CODE_FK_PK)) Then
                GV21.FocusedRowHandle = iCount
                GV21.SetColumnError(colFCPTAFS_SP_CODE_FK_PK, "La spécialité doit être présente dans la fiche.")
                XtraTabControl1.SelectedTabPageIndex = 1
                Exit Function
            Else
                GV21.SetColumnError(colFCPTAFS_SP_CODE_FK_PK, "")
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
        GC1.DataSource = DsTheriaque_Cipemg_Texte
        GC1.DataMember = FCPTCPH_CIPEMG_CLPH

        GC2.DataSource = DsTheriaque_Cipemg_Texte
        GC2.DataMember = FCPTCCH_CIPEMG_CLCH

        GC3.DataSource = DsTheriaque_Cipemg_Texte
        GC3.DataMember = FCPTSAC_CIPEMG_SUBAC

        GC4.DataSource = DsTheriaque_Cipemg_Texte
        GC4.DataMember = FCPTSAU_CIPEMG_SUBAU

        GC5.DataSource = DsTheriaque_Cipemg_Texte
        GC5.DataMember = FCPTPR_CIPEMG_PROD

        GC6.DataSource = DsTheriaque_Cipemg_Texte
        GC6.DataMember = FCPTSP_CIPEMG_SPE

        'Onglet Références officielles
        GC21.DataSource = DsTheriaque_Cipemg_Texte
        GC21.DataMember = FCPTAFS_CIPEMG_AFSSAPS

        GC22.DataSource = DsTheriaque_Cipemg_Texte
        GC22.DataMember = FCPTTX1_CIPEMG_TXCI

        GC23.DataSource = DsTheriaque_Cipemg_Texte
        GC23.DataMember = FCPTTX2_CIPEMG_TXPEMG
    End Sub

    ''' <summary>
    ''' Proçédure: Initialisation des données
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub InitData()
        MyBase.InitData()
        Declinaison_Global = True
        OnLoading = True
        MasterDataSet = Me.DsTheriaque_Cipemg_Texte
        MasterTable = FCPT_FICHECIPEMG
        CodE = InvalideControl

        'Déclinaison classe CPH
        Dim List1 As New System.Collections.Generic.List(Of StructGVTable)
        List1.Add(New StructGVTable("GC1", eDeclinaison.CPH, colFCPTCPH_CPH_CODE_FK_PK2))
        List1.Add(New StructGVTable("GC2", eDeclinaison.CCH, colFCPTCCH_CCH_CODE_FK_PK2))
        List1.Add(New StructGVTable("GC3", eDeclinaison.SAC, colFCPTSAC_SAC_CODE_FK_PK2))
        List1.Add(New StructGVTable("GC6", eDeclinaison.SP, colFCPTSP_SP_CODE_FK_PK2))
        Dim DecCPH As New ClsDeclinaison(eDeclinaison.CPH, List1)
        InitLkup(Me.lkup_FCPTCPH, FCPTCPH_CIPEMG_CLPH, strSSQL_CPH_CLASSEPHARMTHER_NIVEAU, True, , , , , , DecCPH)

        'Déclinaison classe CCH
        Dim List2 As New System.Collections.Generic.List(Of StructGVTable)
        List2.Add(New StructGVTable("GC1", eDeclinaison.CPH, colFCPTCPH_CPH_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC2", eDeclinaison.CCH, colFCPTCCH_CCH_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC3", eDeclinaison.SAC, colFCPTSAC_SAC_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC6", eDeclinaison.SP, colFCPTSP_SP_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC4", eDeclinaison.SAU, colFCPTSAU_SAU_CODE_FK_PK2))
        Dim DecCCH As New ClsDeclinaison(eDeclinaison.CCH, List2)
        InitLkup(Me.lkup_FCPTCCH, FCPTCCH_CIPEMG_CLCH, strSSQL_CCH_CLASSECHIMIQUE_NIVEAU, True, , , , , , DecCCH)


        'Déclinaison SUBAC
        Dim List3 As New System.Collections.Generic.List(Of StructGVTable)
        List3.Add(New StructGVTable("GC2", eDeclinaison.CCH, colFCPTCCH_CCH_CODE_FK_PK2))
        List3.Add(New StructGVTable("GC3", eDeclinaison.SAC, colFCPTSAC_SAC_CODE_FK_PK2))
        List3.Add(New StructGVTable("GC6", eDeclinaison.SP, colFCPTSP_SP_CODE_FK_PK2))
        Dim DecSUBAC As New ClsDeclinaison(eDeclinaison.SAC, List3)
        InitLkup(Me.lkup_FCPTSAC, FCPTSAC_CIPEMG_SUBAC, strSSQL_SAC_SUBACTIVE, True, , , , , , DecSUBAC)

        'Déclinaison SAU
        Dim List4 As New System.Collections.Generic.List(Of StructGVTable)
        List4.Add(New StructGVTable("GC4", eDeclinaison.SAU, colFCPTSAU_SAU_CODE_FK_PK2))
        List4.Add(New StructGVTable("GC6", eDeclinaison.SP, colFCPTSP_SP_CODE_FK_PK2))
        Dim DecSAU As New ClsDeclinaison(eDeclinaison.SAU, List4)
        InitLkup(Me.lkup_FCPTSAU, FCPTSAU_CIPEMG_SUBAU, strSSQL_SAU_SUBAUXILIAIRE, True, , , , , , DecSAU)

        'Déclinaison PRODUIT
        Dim List5 As New System.Collections.Generic.List(Of StructGVTable)
        List5.Add(New StructGVTable("GC5", eDeclinaison.PR, colFCPTPR_PR_CODE_FK_PK2))
        List5.Add(New StructGVTable("GC6", eDeclinaison.SP, colFCPTSP_SP_CODE_FK_PK2))
        Dim DecPR As New ClsDeclinaison(eDeclinaison.PR, List5)
        InitLkup(Me.lkup_FCPTPR, FCPTPR_CIPEMG_PROD, strSSQL_PR_PRODUIT, True, , , , , , DecPR)

        InitLkup(Me.lkup_FCPTSP, FCPTSP_CIPEMG_SPE, strSSQL_SP_SPECIALITE, True)
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
        Me.FcpT_TA.FillByCode(Me.DsTheriaque_Cipemg_Texte.FCPT_FICHECIPEMG, CodE1)
        'Onglet Entités
        Me.FcptcpH_TA.FillByCode(Me.DsTheriaque_Cipemg_Texte.FCPTCPH_CIPEMG_CLPH, CodE1)
        Me.FcptccH_TA.FillByCode(Me.DsTheriaque_Cipemg_Texte.FCPTCCH_CIPEMG_CLCH, CodE1)
        Me.FcptsaC_TA.FillByCode(Me.DsTheriaque_Cipemg_Texte.FCPTSAC_CIPEMG_SUBAC, CodE1)
        Me.FcptsaU_TA.FillByCode(Me.DsTheriaque_Cipemg_Texte.FCPTSAU_CIPEMG_SUBAU, CodE1)
        Me.FcptpR_TA.FillByCode(Me.DsTheriaque_Cipemg_Texte.FCPTPR_CIPEMG_PROD, CodE1)
        Me.FcptsP_TA.FillByCode(Me.DsTheriaque_Cipemg_Texte.FCPTSP_CIPEMG_SPE, CodE1)

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
            strSSQL_SP_REF = " SELECT SP_CODE_SQ_PK as code, SP_NOM as libelle FROM THERIAQUE.FCPTSP_CIPEMG_SPE, THERIAQUE.SP_SPECIALITE"
            strSSQL_SP_REF &= " WHERE FCPTSP_FCPT_CODE_FK_PK = " & CodE
            strSSQL_SP_REF &= " AND SP_CODE_SQ_PK = FCPTSP_SP_CODE_FK_PK"
            InitLkup(Me.lkup_FCPTAFS_SP, FCPTAFS_CIPEMG_AFSSAPS, strSSQL_SP_REF, True)
            For iCount As Integer = 0 To GV21.RowCount
                If GV21.GetRowCellDisplayText(iCount, "FCPTAFS_SP_CODE_FK_PK") = "" And GV21.GetRowCellDisplayText(iCount, "FCPTAFS_FCPT_CODE_FK_PK") <> "" Then
                    GV21.DeleteRow(iCount)
                    iCount = iCount - 1
                End If
            Next
        End If
        If Not Tab_lkup1 Then
            InitLkup(Me.lkup_FCPTAFS, FCPTAFS_CIPEMG_AFSSAPS, strSSQL_CDF_CODIF("25"), True)
            Tab_lkup1 = True
        End If

        If Not Tab_TA1 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.FcptafS_TA.FillByCode(Me.DsTheriaque_Cipemg_Texte.FCPTAFS_CIPEMG_AFSSAPS, CodE)
            Me.FcpttX1_TA.FillByCode(Me.DsTheriaque_Cipemg_Texte.FCPTTX1_CIPEMG_TXCI, CodE)
            Me.FcpttX2_TA.FillByCode(Me.DsTheriaque_Cipemg_Texte.FCPTTX2_CIPEMG_TXPEMG, CodE)
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
        GV1.SetFocusedRowCellValue(colFCPTCPH_FCPT_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV2</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        If OnLoading Then Exit Sub
        GV2.SetFocusedRowCellValue(colFCPTCCH_FCPT_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV3</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV3_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV3.InitNewRow
        If OnLoading Then Exit Sub
        GV3.SetFocusedRowCellValue(colFCPTSAC_FCPT_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV4</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV4_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV4.InitNewRow
        If OnLoading Then Exit Sub
        GV4.SetFocusedRowCellValue(colFCPTSAU_FCPT_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV5</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV5_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV5.InitNewRow
        If OnLoading Then Exit Sub
        GV5.SetFocusedRowCellValue(colFCPTPR_FCPT_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV6</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV6_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV6.InitNewRow
        If OnLoading Then Exit Sub
        GV6.SetFocusedRowCellValue(colFCPTSP_FCPT_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV21</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV21_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV21.InitNewRow
        If OnLoading Then Exit Sub
        GV21.SetFocusedRowCellValue(colFCPTAFS_FCPT_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV22</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV22_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV22.InitNewRow
        Me.GV22.SetFocusedRowCellValue(Me.colFCPTTX1_FCPT_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV23</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV23_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV23.InitNewRow
        Me.GV23.SetFocusedRowCellValue(Me.colFCPTTX2_FCPT_CODE_FK_PK, txtCode.Text)
    End Sub
#End Region

#Region " Panel Resize "
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

        Panel35.Height = XtraTabControl1.Height / 3
        Panel11.Height = XtraTabControl1.Height / 3
        Panel2.Height = XtraTabControl1.Height / 3
    End Sub
#End Region

#Region " Autres événements "
    ''' <summary>
    ''' Evénement: Changement du nombre de lignes
    ''' </summary>
    ''' <param name="sender">GV</param>
    ''' <param name="e">RowCountChanged</param>
    ''' <remarks></remarks>
    Private Sub GV_RowCountChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV22.RowCountChanged, GV23.RowCountChanged
        If sender.RowCount >= 1 Then
            sender.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
            sender.GridControl.EmbeddedNavigator.Buttons.Append.Enabled = False
        Else
            sender.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            sender.GridControl.EmbeddedNavigator.Buttons.Append.Enabled = False
        End If
    End Sub
#End Region

    Private Sub GV_CalcRowHeight(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs) Handles GV22.CalcRowHeight, GV23.CalcRowHeight
        e.RowHeight = sender.GridControl.Height
    End Sub
End Class
