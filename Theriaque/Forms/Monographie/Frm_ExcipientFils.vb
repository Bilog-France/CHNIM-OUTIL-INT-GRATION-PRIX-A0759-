''' <summary>
''' Created By [BFE]
''' </summary>
''' <remarks> Monographie - Excipient - Fils</remarks>
Public Class Frm_ExcipientFils

#Region "Déclaration des variables privées"
    Private CodE As String
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
        f._SSQL = strSSQL_SAU_SUBAUXILIAIRE
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            XtraTabControl1.SelectedTabPageIndex = 0
            Me.SaU_TA.FillByCode(Me.DsTheriaque_Excipient.SAU_SUBAUXILIAIRE, CodE)
            Me.SysaU_TA.FillByCode(Me.DsTheriaque_Excipient.SYSAU_SYNONYME_SAU, CodE)
            Me.SauafS_TA.FillByCode(Me.DsTheriaque_Excipient.SAUAFS_SAU_AFS, CodE)
            Me.AdsaU_TA.FillByCode(Me.DsTheriaque_Excipient.ADSAU_AUTRE_DENOMINATION_SUBAU, CodE)
            Me.SauccH_TA.FillByCode(Me.DsTheriaque_Excipient.SAUCCH_SUBAUX_CLASSECH, CodE)
            Me.SaucaS_TA.FillByCode(Me.DsTheriaque_Excipient.SAUCAS_SAU_CAS, CodE)
            Me.SaunaV_TA.FillByCode(Me.DsTheriaque_Excipient.SAUNAV_SUBAUX_NATURE_VECT, CodE)
            TestSUBACT()
            Tab_TA1 = False

            bModeDuplication = False
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
        f._SSQL = strSSQL_SYSAU_SYNONYME_SUBAU & " UNION " & strSSQL_ADSAU_AUTRE_DENOMINATION_SUBAU
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            XtraTabControl1.SelectedTabPageIndex = 0
            Me.SaU_TA.FillByCode(Me.DsTheriaque_Excipient.SAU_SUBAUXILIAIRE, CodE)
            Me.SysaU_TA.FillByCode(Me.DsTheriaque_Excipient.SYSAU_SYNONYME_SAU, CodE)
            Me.SauafS_TA.FillByCode(Me.DsTheriaque_Excipient.SAUAFS_SAU_AFS, CodE)
            Me.AdsaU_TA.FillByCode(Me.DsTheriaque_Excipient.ADSAU_AUTRE_DENOMINATION_SUBAU, CodE)
            Me.SauccH_TA.FillByCode(Me.DsTheriaque_Excipient.SAUCCH_SUBAUX_CLASSECH, CodE)
            Me.SaucaS_TA.FillByCode(Me.DsTheriaque_Excipient.SAUCAS_SAU_CAS, CodE)
            Me.SaunaV_TA.FillByCode(Me.DsTheriaque_Excipient.SAUNAV_SUBAUX_NATURE_VECT, CodE)
            TestSUBACT()
            Tab_TA1 = False

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
        Dim sCodeCCH As String = ""
        Dim sCodeSAU As String = ""
        Dim sCodeNVEC As String = ""
        Dim f As New Frm_SauFilsMultiCriteres
        f.ShowDialog()
        If f._Validate Then
            If f._bCCH Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CCH_CLASSECHIMIQUE
                fDICO.Text = "Classes chimiques"
                fDICO.ShowDialog()
                sCodeCCH = fDICO._Code
            End If
            If f._bSAU Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("10")
                fDICO.Text = "Fonctions excipient"
                fDICO.ShowDialog()
                sCodeSAU = fDICO._Code
            End If
            If f._bNVEC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("28")
                fDICO.Text = "Natures vecteur"
                fDICO.ShowDialog()
                sCodeNVEC = fDICO._Code
            End If
            Dim fResultat As New Frm_Recherche
            Dim sSQL As String = ""
            sSQL &= " SELECT SAU_CODE_SQ_PK AS code, SAU_NOM AS libelle FROM THERIAQUE.SAU_SUBAUXILIAIRE "
            If sCodeCCH <> "" Then
                sSQL &= " WHERE SAU_CODE_SQ_PK IN (SELECT SAUCCH_SAU_CODE_FK_PK FROM THERIAQUE.SAUCCH_SUBAUX_CLASSECH WHERE SAUCCH_CCH_CODE_FK_PK = " & cn.SQLText(sCodeCCH) & ")"
            End If
            If sCodeSAU <> "" Then
                If sCodeCCH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SAU_CODE_SQ_PK IN (SELECT SAUNAT_SAU_CODE_FK_PK FROM THERIAQUE.SAUNAT_SUBAUX_NATURE WHERE SAUNAT_CDF_NASAU_CODE_FK_PK = " & cn.SQLText(sCodeSAU) & ")"
            End If
            If sCodeNVEC <> "" Then
                If sCodeSAU <> "" Or sCodeCCH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SAU_CODE_SQ_PK IN (SELECT SAUNAV_SAU_CODE_FK_PK FROM THERIAQUE.SAUNAV_SUBAUX_NATURE_VECT WHERE SAUNAV_CDF_NAV_CODE_FK_PK = " & cn.SQLText(sCodeNVEC) & ")"
            End If
            sSQL &= " ORDER BY SAU_CODE_SQ_PK"

            fResultat._SSQL = sSQL
            fResultat.Text = Me.Text
            fResultat.ShowDialog()
            CodE = fResultat._Code
            If fResultat._Code IsNot Nothing Then
                XtraTabControl1.SelectedTabPageIndex = 0
                Me.SaU_TA.FillByCode(Me.DsTheriaque_Excipient.SAU_SUBAUXILIAIRE, fResultat._Code)
                Me.SysaU_TA.FillByCode(Me.DsTheriaque_Excipient.SYSAU_SYNONYME_SAU, fResultat._Code)
                Me.SauafS_TA.FillByCode(Me.DsTheriaque_Excipient.SAUAFS_SAU_AFS, fResultat._Code)
                Me.AdsaU_TA.FillByCode(Me.DsTheriaque_Excipient.ADSAU_AUTRE_DENOMINATION_SUBAU, fResultat._Code)
                Me.SauccH_TA.FillByCode(Me.DsTheriaque_Excipient.SAUCCH_SUBAUX_CLASSECH, fResultat._Code)
                Me.SaucaS_TA.FillByCode(Me.DsTheriaque_Excipient.SAUCAS_SAU_CAS, fResultat._Code)
                Me.SaunaV_TA.FillByCode(Me.DsTheriaque_Excipient.SAUNAV_SUBAUX_NATURE_VECT, fResultat._Code)
                TestSUBACT()
                Tab_TA1 = False
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
        ClearTable()
        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        SetCode_MAx(MasterTable, txtCode)
        CodE = InvalideControl
        MyBase.Ajouter()
        bModeDuplication = False
        XtraTabControl1.SelectedTabPageIndex = 0
    End Sub

    ''' <summary>
    ''' Proçédure: Validation d'un enregistrement
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub Valider()
        MyBase.Valider()
        'Master
        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        SaU_TA.Update(Me.DsTheriaque_Excipient.SAU_SUBAUXILIAIRE)
        'Onglet Excipient 1/2
        Me.BindingContext(Me.MasterDataSet, SYSAU_SYNONYME_SAU).EndCurrentEdit()
        SysaU_TA.Update(Me.DsTheriaque_Excipient.SYSAU_SYNONYME_SAU)

        Me.BindingContext(Me.MasterDataSet, SAUAFS_SAU_AFS).EndCurrentEdit()
        SauafS_TA.Update(Me.DsTheriaque_Excipient.SAUAFS_SAU_AFS)

        Me.BindingContext(Me.MasterDataSet, ADSAU_AUTRE_DENOMINATION_SUBAU).EndCurrentEdit()
        AdsaU_TA.Update(Me.DsTheriaque_Excipient.ADSAU_AUTRE_DENOMINATION_SUBAU)

        Me.BindingContext(Me.MasterDataSet, SAUCCH_SUBAUX_CLASSECH).EndCurrentEdit()
        SauccH_TA.Update(Me.DsTheriaque_Excipient.SAUCCH_SUBAUX_CLASSECH)

        Me.BindingContext(Me.MasterDataSet, SAUCAS_SAU_CAS).EndCurrentEdit()
        SaucaS_TA.Update(Me.DsTheriaque_Excipient.SAUCAS_SAU_CAS)

        Me.BindingContext(Me.MasterDataSet, SAUNAV_SUBAUX_NATURE_VECT).EndCurrentEdit()
        SaunaV_TA.Update(Me.DsTheriaque_Excipient.SAUNAV_SUBAUX_NATURE_VECT)

        'Onglet Excipient 2/2
        Me.BindingContext(Me.MasterDataSet, SAUNAT_SUBAUX_NATURE).EndCurrentEdit()
        SaunaT_TA.Update(Me.DsTheriaque_Excipient.SAUNAT_SUBAUX_NATURE)

        Me.BindingContext(Me.MasterDataSet, SAUVO_SUBAUXVOIE_SUBAUX).EndCurrentEdit()
        SauvO_TA.Update(Me.DsTheriaque_Excipient.SAUVO_SUBAUXVOIE_SUBAUX)

        'Tab_TA1 = True
        bModeDuplication = False

    End Sub

    ''' <summary>
    ''' Proçédure: Annulation d'un enregistrement
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub Annuler()
        MyBase.Annuler()

        'Onglet Excipient 1/2
        Me.BindingContext(Me.MasterDataSet, SYSAU_SYNONYME_SAU).CancelCurrentEdit()
        Me.DsTheriaque_Excipient.SYSAU_SYNONYME_SAU.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SAUAFS_SAU_AFS).CancelCurrentEdit()
        Me.DsTheriaque_Excipient.SAUAFS_SAU_AFS.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, ADSAU_AUTRE_DENOMINATION_SUBAU).CancelCurrentEdit()
        Me.DsTheriaque_Excipient.ADSAU_AUTRE_DENOMINATION_SUBAU.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SAUCCH_SUBAUX_CLASSECH).CancelCurrentEdit()
        Me.DsTheriaque_Excipient.SAUCCH_SUBAUX_CLASSECH.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SAUCAS_SAU_CAS).CancelCurrentEdit()
        Me.DsTheriaque_Excipient.SAUCAS_SAU_CAS.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SAUNAV_SUBAUX_NATURE_VECT).CancelCurrentEdit()
        Me.DsTheriaque_Excipient.SAUNAV_SUBAUX_NATURE_VECT.RejectChanges()

        'Onglet Excipient 2/2
        Me.BindingContext(Me.MasterDataSet, SAUNAT_SUBAUX_NATURE).CancelCurrentEdit()
        Me.DsTheriaque_Excipient.SAUNAT_SUBAUX_NATURE.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SAUVO_SUBAUXVOIE_SUBAUX).CancelCurrentEdit()
        Me.DsTheriaque_Excipient.SAUVO_SUBAUXVOIE_SUBAUX.RejectChanges()

        'Master
        Me.BindingContext(Me.MasterDataSet, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_Excipient.SAU_SUBAUXILIAIRE.RejectChanges()

        If bModeDuplication Then ClearTable()
        bModeDuplication = False
    End Sub

    ''' <summary>
    ''' Fonction: Suppression d'un enregistrement
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks>Fonction surchargée</remarks>
    Public Overrides Function Supprimer() As Boolean
        MyBase.Supprimer()
        Dim iCount As Integer
        If Tab_TA1 Then
            'Onglet Excipient 1/2
            For iCount = 0 To DsTheriaque_Excipient.SYSAU_SYNONYME_SAU.Rows.Count - 1
                DsTheriaque_Excipient.SYSAU_SYNONYME_SAU.Rows(iCount).Delete()
            Next
            Me.SysaU_TA.Update(DsTheriaque_Excipient)

            For iCount = 0 To DsTheriaque_Excipient.SAUAFS_SAU_AFS.Rows.Count - 1
                DsTheriaque_Excipient.SAUAFS_SAU_AFS.Rows(iCount).Delete()
            Next
            Me.SauafS_TA.Update(DsTheriaque_Excipient)

            For iCount = 0 To DsTheriaque_Excipient.ADSAU_AUTRE_DENOMINATION_SUBAU.Rows.Count - 1
                DsTheriaque_Excipient.ADSAU_AUTRE_DENOMINATION_SUBAU.Rows(iCount).Delete()
            Next
            Me.AdsaU_TA.Update(DsTheriaque_Excipient)

            For iCount = 0 To DsTheriaque_Excipient.SAUCCH_SUBAUX_CLASSECH.Rows.Count - 1
                DsTheriaque_Excipient.SAUCCH_SUBAUX_CLASSECH.Rows(iCount).Delete()
            Next
            Me.SauccH_TA.Update(DsTheriaque_Excipient)

            For iCount = 0 To DsTheriaque_Excipient.SAUCAS_SAU_CAS.Rows.Count - 1
                DsTheriaque_Excipient.SAUCAS_SAU_CAS.Rows(iCount).Delete()
            Next
            Me.SaucaS_TA.Update(DsTheriaque_Excipient)

            For iCount = 0 To DsTheriaque_Excipient.SAUNAV_SUBAUX_NATURE_VECT.Rows.Count - 1
                DsTheriaque_Excipient.SAUNAV_SUBAUX_NATURE_VECT.Rows(iCount).Delete()
            Next
            Me.SaunaV_TA.Update(DsTheriaque_Excipient)

            'Onglet Excipient 2/2
            For iCount = 0 To DsTheriaque_Excipient.SAUNAT_SUBAUX_NATURE.Rows.Count - 1
                DsTheriaque_Excipient.SAUNAT_SUBAUX_NATURE.Rows(iCount).Delete()
            Next
            Me.SaunaT_TA.Update(DsTheriaque_Excipient)

            For iCount = 0 To DsTheriaque_Excipient.SAUVO_SUBAUXVOIE_SUBAUX.Rows.Count - 1
                DsTheriaque_Excipient.SAUVO_SUBAUXVOIE_SUBAUX.Rows(iCount).Delete()
            Next
            Me.SauvO_TA.Update(DsTheriaque_Excipient)

            'Master
            DsTheriaque_Excipient.SAU_SUBAUXILIAIRE.Rows(0).Delete()
            Me.SaU_TA.Update(Me.DsTheriaque_Excipient)

            bModeDuplication = False
            Return True
        Else
            Process_Message(strChargementOnglet, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Function

    ''' <summary>
    ''' Proçédure: Vider tous les dataset
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Private Sub ClearTable()
        OnLoading = True
        'Onglet Excipient 1/2
        Me.DsTheriaque_Excipient.SYSAU_SYNONYME_SAU.Clear()
        Me.DsTheriaque_Excipient.SAUAFS_SAU_AFS.Clear()
        Me.DsTheriaque_Excipient.ADSAU_AUTRE_DENOMINATION_SUBAU.Clear()
        Me.DsTheriaque_Excipient.SAUCCH_SUBAUX_CLASSECH.Clear()
        Me.DsTheriaque_Excipient.SAUCAS_SAU_CAS.Clear()
        Me.DsTheriaque_Excipient.SAUNAV_SUBAUX_NATURE_VECT.Clear()
        'Onglet Excipient 2/2
        Me.DsTheriaque_Excipient.SAUNAT_SUBAUX_NATURE.Clear()
        Me.DsTheriaque_Excipient.SAUVO_SUBAUXVOIE_SUBAUX.Clear()
        'Master
        Me.DsTheriaque_Excipient.SAU_SUBAUXILIAIRE.Clear()
        OnLoading = False
    End Sub

    ''' <summary>
    ''' Proçédure: Duplication des données à partir d'une autre fiche
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub Dupliquer()

        If Not Tab_TA1 And CodE <> InvalideControl And CodE <> Nothing Then LoadTab_1()

        Dim sCodePere As String = Me.BindingContext(DsTheriaque_Excipient, SAU_SUBAUXILIAIRE).Current("SAU_GSAU_CODE_FK").ToString
        Dim sEffetNotoire As String = Me.BindingContext(DsTheriaque_Excipient, SAU_SUBAUXILIAIRE).Current("SAU_EFFETNOTOIRE").ToString
        Dim sReference As String = Me.BindingContext(DsTheriaque_Excipient, SAU_SUBAUXILIAIRE).Current("SAU_CDF_DOC_CODE_FK").ToString
        Dim sDateReference As String = Me.BindingContext(DsTheriaque_Excipient, SAU_SUBAUXILIAIRE).Current("SAU_DOC_DATE").ToString

        Dim dt14 As New DataTable
        dt14 = DsTheriaque_Excipient.SAUCCH_SUBAUX_CLASSECH.Copy

        Dim dt21 As New DataTable
        dt21 = DsTheriaque_Excipient.SAUNAT_SUBAUX_NATURE.Copy

        Dim dt22 As New DataTable
        dt22 = DsTheriaque_Excipient.SAUVO_SUBAUXVOIE_SUBAUX.Copy

        Dim sText As String = MemoEdit3.Text

        ClearTable()

        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        SetCode_MAx(MasterTable, txtCode)
        CodE = InvalideControl

        Dim drTemp As DataRow
        For iCount As Integer = 0 To dt14.Rows.Count - 1
            drTemp = DsTheriaque_Excipient.Tables("SAUCCH_SUBAUX_CLASSECH").NewRow()
            drTemp.ItemArray = dt14.Rows(iCount).ItemArray
            DsTheriaque_Excipient.Tables("SAUCCH_SUBAUX_CLASSECH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt21.Rows.Count - 1
            drTemp = DsTheriaque_Excipient.Tables("SAUNAT_SUBAUX_NATURE").NewRow()
            drTemp.ItemArray = dt21.Rows(iCount).ItemArray
            DsTheriaque_Excipient.Tables("SAUNAT_SUBAUX_NATURE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt22.Rows.Count - 1
            drTemp = DsTheriaque_Excipient.Tables("SAUVO_SUBAUXVOIE_SUBAUX").NewRow()
            drTemp.ItemArray = dt22.Rows(iCount).ItemArray
            DsTheriaque_Excipient.Tables("SAUVO_SUBAUXVOIE_SUBAUX").Rows.Add(drTemp)
        Next

        If sCodePere <> "" Then Me.BindingContext(DsTheriaque_Excipient, SAU_SUBAUXILIAIRE).Current("SAU_GSAU_CODE_FK") = sCodePere
        If sEffetNotoire <> "" Then Me.BindingContext(DsTheriaque_Excipient, SAU_SUBAUXILIAIRE).Current("SAU_EFFETNOTOIRE") = sEffetNotoire
        If sReference <> "" Then Me.BindingContext(DsTheriaque_Excipient, SAU_SUBAUXILIAIRE).Current("SAU_CDF_DOC_CODE_FK") = sReference
        If sDateReference <> "" Then Me.BindingContext(DsTheriaque_Excipient, SAU_SUBAUXILIAIRE).Current("SAU_DOC_DATE") = sDateReference

        
        MemoEdit3.Text = sText

        ModifierCode()
        bModeDuplication = True
        MyBase.Dupliquer()
        'Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        XtraTabControl1.SelectedTabPageIndex = 0
    End Sub

    ''' <summary>
    ''' Proçédure: Modifier code Master de la fiche
    ''' </summary>
    Private Sub ModifierCode()
        'GV14
        For iCount As Integer = 0 To GV14.RowCount - 1
            GV14.SetRowCellValue(iCount, colSAUCCH_SAU_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV21
        For iCount As Integer = 0 To GV21.RowCount - 1
            GV21.SetRowCellValue(iCount, colSAUNAT_SAU_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV22
        For iCount As Integer = 0 To GV22.RowCount - 1
            GV22.SetRowCellValue(iCount, colSAUVO_SAU_CODE_FK_PK, Me.txtCode.Text)
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
        MyBase.ValideControl(Ctrl)
        If Ctrl.Name.ToLower = "txtLibelle".ToLower Or AllCtrl Then
            If txtLibelle.Text = "" Then
                Me.DxErrorProvider.SetError(txtLibelle, strLibelle)
                Return False
            Else
                Me.DxErrorProvider.SetError(txtLibelle, "")
            End If
        End If
        If Ctrl.Name.ToLower = "Date_REF".ToLower Or AllCtrl Then
            Dim iCount As Integer
            iCount = GV22.RowCount
            If iCount > 1 Then
                'If Date_REF.Text = "" Then
                If Me.BindingContext(DsTheriaque_Excipient, SAU_SUBAUXILIAIRE).Current("SAU_DOC_DATE") Is DBNull.Value Then
                    Me.DxErrorProvider.SetError(Date_REF, strDate)
                    Return False
                Else
                    Me.DxErrorProvider.SetError(Date_REF, "")
                End If
                'If lkup_REF.Text = "" Then
                If Me.BindingContext(DsTheriaque_Excipient, SAU_SUBAUXILIAIRE).Current("SAU_CDF_DOC_CODE_FK") Is DBNull.Value Then
                    Me.DxErrorProvider.SetError(lkup_REF, strReference)
                    Return False
                Else
                    Me.DxErrorProvider.SetError(lkup_REF, "")
                End If

            Else
                Me.DxErrorProvider.SetError(Date_REF, "")
                Me.DxErrorProvider.SetError(lkup_REF, "")
            End If
        End If
        Dim strSSQL As String
        If Ctrl.Name.ToLower = "txtLibelle".ToLower Or AllCtrl Then
            strSSQL = "  SELECT * FROM THERIAQUE.SAU_SUBAUXILIAIRE WHERE SAU_CODE_SQ_PK <> " & cn.SQLText(txtCode.Text)
            strSSQL &= " AND UPPER(SAU_NOM) = " & UCase(cn.SQLText(txtLibelle.Text))
            Dim dt As DataTable = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist)
                Return False
            Else
                Me.DxErrorProvider.SetError(txtLibelle, "")
            End If
            strSSQL = "  SELECT * FROM THERIAQUE.SYSAU_SYNONYME_SAU WHERE SYSAU_SAU_CODE_FK <> " & cn.SQLText(txtCode.Text)
            strSSQL &= " AND UPPER(SYSAU_NOM_PK) = " & UCase(cn.SQLText(txtLibelle.Text))
            dt = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist & " comme synonyme")
                Return False
            Else
                Me.DxErrorProvider.SetError(txtLibelle, "")
            End If

            strSSQL = "  SELECT * FROM THERIAQUE.ADSAU_AUTRE_DENOMINATION_SUBAU WHERE ADSAU_SAU_CODE_FK <> " & cn.SQLText(txtCode.Text)
            strSSQL &= " AND UPPER(ADSAU_NOM_PK) = " & UCase(cn.SQLText(txtLibelle.Text))
            dt = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist & " comme autres dénominations")
                Return False
            Else
                Me.DxErrorProvider.SetError(txtLibelle, "")
            End If

            Me.DxErrorProvider.SetError(txtLibelle, "")
            For iCount As Integer = 0 To GV11.RowCount - 1
                If UCase(GV11.GetRowCellValue(iCount, colSYSAU_NOM_PK)) = UCase(Me.txtLibelle.Text) Then
                    Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist & " dans la liste des synonymes")
                    Return False
                End If
            Next
            For iCount As Integer = 0 To GV13.RowCount - 1
                If UCase(GV13.GetRowCellValue(iCount, colADSAU_NOM_PK)) = UCase(Me.txtLibelle.Text) Then
                    Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist & " dans la liste des autres dénominations")
                    Return False
                End If
            Next
        End If
        Return True
    End Function

#End Region

#Region " Init Data  "

    ''' <summary>
    ''' Proçédure: Alimentation des sources des gridcontrols
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitDataSource()
        'Onglet Excipient 1/2
        GC11.DataSource = DsTheriaque_Excipient
        GC11.DataMember = SYSAU_SYNONYME_SAU

        GC12.DataSource = DsTheriaque_Excipient
        GC12.DataMember = SAUAFS_SAU_AFS

        GC13.DataSource = DsTheriaque_Excipient
        GC13.DataMember = ADSAU_AUTRE_DENOMINATION_SUBAU

        GC14.DataSource = DsTheriaque_Excipient
        GC14.DataMember = SAUCCH_SUBAUX_CLASSECH

        GC15.DataSource = DsTheriaque_Excipient
        GC15.DataMember = SAUCAS_SAU_CAS

        GC16.DataSource = DsTheriaque_Excipient
        GC16.DataMember = SAUNAV_SUBAUX_NATURE_VECT

        'Onglet Excipient 2/2
        GC21.DataSource = DsTheriaque_Excipient
        GC21.DataMember = SAUNAT_SUBAUX_NATURE

        GC22.DataSource = DsTheriaque_Excipient
        GC22.DataMember = SAUVO_SUBAUXVOIE_SUBAUX
    End Sub

    ''' <summary>
    ''' Proçédure: Initialisation des données
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub InitData()
        MyBase.InitData()
        OnLoading = True
        MasterDataSet = Me.DsTheriaque_Excipient
        MasterTable = SAU_SUBAUXILIAIRE
        CodE = InvalideControl
        InitLkup(lkupSAU_GSAU_CODE_FK, GSAU_PERE_SUBAUX, strSSQL_GSAU_PERE_SUBAUX, True)
        InitLkup(Me.lkup_SAUAFS, SAUAFS_SAU_AFS, strSSQL_CDF_CODIF("25"), True)
        InitLkup(Me.lkup_SAUNAV, SAUNAV_SUBAUX_NATURE_VECT, strSSQL_CDF_CODIF("28"), True)

        'Dictionnaire saisi dernier niveau
        InitLkup(Me.lkup_SAUCCH, SAUCCH_SUBAUX_CLASSECH, strSSQL_CCH_CLASSECHIMIQUE_NIVEAU, True)

        InitDataSource()
        FirstFocus = txtCode
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
            InitLkup(Me.lkup_SAUNAT, SAUNAT_SUBAUX_NATURE, strSSQL_CDF_CODIF("10"), True)
            InitLkup(Me.lkup_SAUVO, SAUVO_SUBAUXVOIE_SUBAUX, strSSQL_CDF_CODIF("18"), True)
            InitLkup(Me.lkup_REF, SAU_SUBAUXILIAIRE, strSSQL_CDF_CODIF("25"), True)
            Tab_lkup1 = True
        End If

        If Not Tab_TA1 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.SaunaT_TA.FillByCode(Me.DsTheriaque_Excipient.SAUNAT_SUBAUX_NATURE, CodE)
            Me.SauvO_TA.FillByCode(Me.DsTheriaque_Excipient.SAUVO_SUBAUXVOIE_SUBAUX, CodE)
            Tab_TA1 = True
            If Not cmbDisponible.SelectedItem Is DBNull.Value Then
                If cmbDisponible.SelectedItem = "NC" Then
                    DateDisponible.Text = ""
                    DateDisponible.Enabled = False
                Else
                    DateDisponible.Enabled = True
                End If
            End If
        End If
        'Test SUB ACTIVE 
        If txtLibelle.Text <> "" Then
            Dim dt As New DataTable
            dt = cn.MySelect("Select SAC_CODE_SQ_PK From THERIAQUE.SAC_SUBACTIVE where SAC_NOM =  " & cn.SQLText(txtLibelle.Text))
            If dt IsNot Nothing Then
                If dt.Rows.Count > 0 Then
                    txtSAU_SAC_CODE_FK.Text = Convert.ToString(dt.Rows(0)(0))
                    cmbSubac.Text = "O"
                Else
                    OnLoading = True
                    cmbSubac.Text = "N"
                    OnLoading = False
                End If
            Else
                OnLoading = True
                cmbSubac.Text = "N"
                OnLoading = False
            End If
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
    ''' <param name="sender">GV11</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV11_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV11.InitNewRow
        GV11.SetFocusedRowCellValue(colSYSAU_SAU_CODE_FK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV12</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV12_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV12.InitNewRow
        GV12.SetFocusedRowCellValue(colSAUAFS_SAU_CODE_FK_PK, txtCode.Text)
        GV12.SetFocusedRowCellValue(colSAUAFS_NUMORD, Code_MAx(GV12, colSAUAFS_NUMORD))
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV13</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV13_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV13.InitNewRow
        GV13.SetFocusedRowCellValue(colADSAU_SAU_CODE_FK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV14</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV14_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV14.InitNewRow
        GV14.SetFocusedRowCellValue(colSAUCCH_SAU_CODE_FK_PK, txtCode.Text)
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV15</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV15_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV15.InitNewRow
        GV15.SetFocusedRowCellValue(colSAUCAS_SAU_CODE_FK_PK, txtCode.Text)
        GV15.SetFocusedRowCellValue(colSAUCAS_NUMORD, Code_MAx(GV15, colSAUCAS_NUMORD))
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV16</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV16_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV16.InitNewRow
        GV16.SetFocusedRowCellValue(colSAUNAV_SAU_CODE_FK_PK, txtCode.Text)
        GV16.SetFocusedRowCellValue(colSAUNAV_NUMORD, Code_MAx(GV16, colSAUNAV_NUMORD))
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV21</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV21_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV21.InitNewRow
        GV21.SetFocusedRowCellValue(colSAUNAT_SAU_CODE_FK_PK, txtCode.Text)
        GV21.SetFocusedRowCellValue(colSAUNAT_NUMORD, Code_MAx(GV21, colSAUNAT_NUMORD))
    End Sub

    ''' <summary>
    ''' Evénement: Ajout d'une nouvelle ligne
    ''' </summary>
    ''' <param name="sender">GV22</param>
    ''' <param name="e">InitNewRow</param>
    ''' <remarks></remarks>
    Private Sub GV22_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV22.InitNewRow
        GV22.SetFocusedRowCellValue(colSAUVO_SAU_CODE_FK_PK, txtCode.Text)
        GV22.SetFocusedRowCellValue(colSAUVO_NUMORD, Code_MAx(GV22, colSAUVO_NUMORD))
        If GV22.GetFocusedRowCellValue("colSAUVO_DOSESEUIL") Is Nothing Then
            GV22.SetFocusedRowCellValue(colSAUVO_DOSESEUIL, "N")
        End If
    End Sub

#End Region

#Region " Panel "

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
    ''' Evénement: Redimensionnement d'onglet
    ''' </summary>
    ''' <param name="sender">XtraTabControl1</param>
    ''' <param name="e">Resize</param>
    ''' <remarks></remarks>
    Private Sub XtraTabControl1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraTabControl1.Resize
        Panel2.Height = XtraTabControl1.Height / 3
        Panel3.Height = XtraTabControl1.Height / 3
        Panel5.Height = XtraTabControl1.Height / 3

        Panel4.Height = XtraTabControl1.Height / 5
        Panel6.Height = XtraTabControl1.Height / 5
    End Sub

#End Region

#Region " Validating "

    ''' <summary>
    ''' Evénement: Validation d'une ligne
    ''' </summary>
    ''' <param name="sender">GV15</param>
    ''' <param name="e">ValidateRow</param>
    ''' <remarks></remarks>
    Private Sub GV15_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV15.ValidateRow
        If Not Code_CAS(Me.GV15.GetFocusedRowCellValue(colSAUCAS_CAS_CODE_PK), GC15, Me.DxErrorProvider) Then
            e.Valid = False
            e.ErrorText = strCodeCas
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Validation d'une ligne
    ''' </summary>
    ''' <param name="sender">GV22</param>
    ''' <param name="e">ValidateRow</param>
    ''' <remarks></remarks>
    Private Sub GV22_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV22.ValidateRow
        If e.Row.isnew Then
            If e.Row IsNot Nothing Then
                If Not Me.GV22.GetFocusedRowCellValue(ColVoie) Is DBNull.Value Then
                    If e.Row.row.Item(2) Is DBNull.Value Then
                        e.ErrorText = strDose
                        e.Valid = False
                    Else
                        e.ErrorText = ""
                        e.Valid = True
                    End If
                End If
            End If
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Validation de la saisie
    ''' </summary>
    ''' <param name="sender">txtLibelle</param>
    ''' <param name="e">Validated</param>
    ''' <remarks></remarks>    
    Private Sub txtLibelle_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLibelle.Validated
        ValideControl(sender, False)
    End Sub

    ''' <summary>
    ''' Evénement: Validation de la saisie
    ''' </summary>
    ''' <param name="sender">Date_REF</param>
    ''' <param name="e">Validated</param>
    ''' <remarks></remarks>    
    Private Sub Date_REF_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Date_REF.Validated
        ValideControl(sender, False)
    End Sub

    ''' <summary>
    ''' Evénement: Validation de la saisie
    ''' </summary>
    ''' <param name="sender">lkup_REF</param>
    ''' <param name="e">Validated</param>
    ''' <remarks></remarks>    
    Private Sub lkup_REF_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkup_REF.Validated
        ValideControl(sender, False)
    End Sub

    ''' <summary>
    ''' Evénement: Validation de l'édition
    ''' </summary>
    ''' <param name="sender">GV11</param>
    ''' <param name="e">ValidatingEditor</param>
    ''' <remarks></remarks>    
    Private Sub GV11_ValidatingEditor(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV11.ValidatingEditor
        If e.Value IsNot Nothing And e.Value IsNot DBNull.Value Then
            If FieldExist(SYSAU_SYNONYME_SAU, "SYSAU_NOM_PK", e.Value, , " SYSAU_SAU_CODE_FK <> " & cn.SQLText(txtCode.Text)) Then
                e.Valid = False
                e.ErrorText = StrValeurExist
            End If
            If Trim(UCase(txtLibelle.Text)) = Trim(UCase(e.Value)) Then
                e.Valid = False
                e.ErrorText = strLibelle_Synonyme
            End If
            Dim strSSQL As String
            strSSQL = "  SELECT * FROM THERIAQUE.SAU_SUBAUXILIAIRE"
            strSSQL &= " WHERE UPPER(SAU_NOM) = " & UCase(cn.SQLText(e.Value))
            Dim dt As DataTable = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                e.Valid = False
                e.ErrorText = "Cette valeur existe déjà comme libellé."
            Else
                Me.DxErrorProvider.SetError(txtLibelle, "")
            End If
            For iCount As Integer = 0 To GV13.RowCount - 1
                If UCase(GV13.GetRowCellValue(iCount, colADSAU_NOM_PK)) = UCase(e.Value) Then
                    e.Valid = False
                    e.ErrorText = "Cette valeur existe déjà comme dénomination."
                End If
            Next
            If FieldExist(ADSAU_AUTRE_DENOMINATION_SUBAU, "ADSAU_NOM_PK", e.Value, , " ADSAU_SAU_CODE_FK <> " & cn.SQLText(txtCode.Text)) Then
                e.Valid = False
                e.ErrorText = "Cette valeur existe déjà comme dénomination."
            End If
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Validation de l'édition
    ''' </summary>
    ''' <param name="sender">GV13</param>
    ''' <param name="e">ValidatingEditor</param>
    ''' <remarks></remarks>   
    Private Sub GV13_ValidatingEditor(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV13.ValidatingEditor
        If e.Value IsNot Nothing And e.Value IsNot DBNull.Value Then
            If FieldExist(ADSAU_AUTRE_DENOMINATION_SUBAU, "ADSAU_NOM_PK", e.Value, , " ADSAU_SAU_CODE_FK <> " & cn.SQLText(txtCode.Text)) Then
                e.Valid = False
                e.ErrorText = StrValeurExist
            End If
            If Trim(UCase(txtLibelle.Text)) = Trim(UCase(e.Value)) Then
                e.Valid = False
                e.ErrorText = strLibelle_AutresDenominations
            End If
            Dim strSSQL As String
            strSSQL = "  SELECT * FROM THERIAQUE.SAU_SUBAUXILIAIRE"
            strSSQL &= " WHERE SAU_NOM = " & cn.SQLText(e.Value)
            Dim dt As DataTable = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                e.Valid = False
                e.ErrorText = "Cette valeur existe déjà comme libellé."
            Else
                Me.DxErrorProvider.SetError(txtLibelle, "")
            End If
            For iCount As Integer = 0 To GV11.RowCount - 1
                If UCase(GV11.GetRowCellValue(iCount, colSYSAU_NOM_PK)) = UCase(e.Value) Then
                    e.Valid = False
                    e.ErrorText = "Cette valeur existe déjà comme synonyme."
                End If
            Next
            strSSQL = "  SELECT * FROM THERIAQUE.SYSAU_SYNONYME_SAU WHERE SYSAU_SAU_CODE_FK <> " & cn.SQLText(txtCode.Text)
            strSSQL &= " AND UPPER(SYSAU_NOM_PK) = " & UCase(cn.SQLText(e.Value))
            dt = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                e.Valid = False
                e.ErrorText = StrValeurExist & " comme synonyme"
            Else
                Me.DxErrorProvider.SetError(txtLibelle, "")
            End If
        End If
    End Sub

#End Region

#Region " Autres événements "

    ''' <summary>
    ''' Evénement: Sélection du combobox
    ''' </summary>
    ''' <param name="sender">cmbSubac</param>
    ''' <param name="e">SelectedIndexChanged</param>
    ''' <remarks></remarks>
    Private Sub cmbSubac_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSubac.SelectedIndexChanged
        If Not OnLoading Then
            If cmbSubac.Text = "O" Then
                Dim dt As New DataTable
                dt = cn.MySelect("Select SAC_CODE_SQ_PK From THERIAQUE.SAC_SUBACTIVE where SAC_NOM =  " & cn.SQLText(txtLibelle.Text))
                If dt IsNot Nothing Then
                    If dt.Rows.Count > 0 Then
                        txtSAU_SAC_CODE_FK.Text = dt.Rows(0)(0)
                    Else
                        OnLoading = True
                        cmbSubac.Text = "N"
                        OnLoading = False
                    End If
                Else
                    OnLoading = True
                    cmbSubac.Text = "N"
                    OnLoading = False
                End If
            Else
                cmbSubac.Text = "N"
            End If
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Sélection du combobox
    ''' </summary>
    ''' <param name="sender">cmbDisponible</param>
    ''' <param name="e">SelectedIndexChanged</param>
    ''' <remarks></remarks>
    Private Sub cmbDisponible_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDisponible.SelectedIndexChanged
        If Not cmbDisponible.SelectedItem Is DBNull.Value Then
            If cmbDisponible.SelectedItem = "NC" Then
                DateDisponible.Text = ""
                DateDisponible.Enabled = False
            Else
                DateDisponible.Enabled = True
            End If
        End If
    End Sub

#End Region

    ''' <summary>
    ''' Proçédure: Test sur la substance active
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub TestSUBACT()
        Load_On(Me)
        Dim dt As New DataTable
        dt = cn.MySelect("Select SAC_CODE_SQ_PK FROM THERIAQUE.SAC_SUBACTIVE where SAC_NOM =  " & cn.SQLText(txtLibelle.Text))
        If dt.Rows.Count > 0 Then
            If txtSAU_SAC_CODE_FK.Text = Convert.ToString(dt.Rows(0)(0)) Then
                OnLoading = True
                cmbSubac.Text = "O"
                OnLoading = False
            Else
                OnLoading = True
                cmbSubac.Text = "N"
                OnLoading = False
            End If
        Else
            OnLoading = True
            cmbSubac.Text = "N"
            OnLoading = False
        End If
        Load_Off(Me)
    End Sub
End Class
