''' <summary>
''' Created By [BFE]
''' </summary>
''' <remarks> Monographie - Interaction RCP
''' </remarks>
Public Class Frm_InteractionsRCP

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
        f._SSQL = strSSQL_FIRCP_INTERACTIONRCP_SPECIALITE()
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            XtraTabControl1.SelectedTabPageIndex = 0
            OnLoading = True
            EmptyDataTable()
            Me.FircP_TA.FillByCode(Me.DsTheriaque_InteractionRCP.FIRCP_INTERACTIONRCP, f._Code)
            'Onglet Entités
            Me.FircpcpH_TA.FillByCode(Me.DsTheriaque_InteractionRCP.FIRCPCPH_FIRCP_CLPH, f._Code)
            Me.FircpccH_TA.FillByCode(Me.DsTheriaque_InteractionRCP.FIRCPCCH_FIRCP_CLCH, f._Code)
            Me.FircpsaC_TA.FillByCode(Me.DsTheriaque_InteractionRCP.FIRCPSAC_FIRCP_SUBACT, f._Code)
            Me.FircpsaU_TA.FillByCode(Me.DsTheriaque_InteractionRCP.FIRCPSAU_FIRCP_SUBAUX, f._Code)
            Me.FircppR_TA.FillByCode(Me.DsTheriaque_InteractionRCP.FIRCPPR_FIRCP_PROD, f._Code)
            Me.FircpsP_TA.FillByCode(Me.DsTheriaque_InteractionRCP.FIRCPSP_INTERACTRCP_SPEC, f._Code)

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
        Dim f As New Frm_InteractionRCPMultiCriteres
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
            If f._bCOM Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("HC")
                fDICO.Text = "Commentaires"
                fDICO.ShowDialog()
                sCodeCOM = fDICO._Code
            End If

            Dim fResultat As New Frm_Recherche
            Dim sSQL As String = ""
            sSQL &= " Select FIRCP_CODE_SQ_PK as code, '' as libelle From THERIAQUE.FIRCP_INTERACTIONRCP"
            If sCodeCPH <> "" Then
                sSQL &= " WHERE FIRCP_CODE_SQ_PK IN (SELECT FIRCPCPH_FIRCP_CODE_FK_PK FROM THERIAQUE.FIRCPCPH_FIRCP_CLPH WHERE FIRCPCPH_CPH_CODE_FK_PK = " & cn.SQLText(sCodeCPH) & ")"
            End If
            If sCodeCCH <> "" Then
                If sCodeCPH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIRCP_CODE_SQ_PK IN (SELECT FIRCPCCH_FIRCP_CODE_FK_PK FROM THERIAQUE.FIRCPCCH_FIRCP_CLCH WHERE FIRCPCCH_CCH_CODE_FK_PK = " & cn.SQLText(sCodeCCH) & ")"
            End If
            If sCodeSAC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIRCP_CODE_SQ_PK IN (SELECT FIRCPSAC_FIRCP_CODE_FK_PK FROM THERIAQUE.FIRCPSAC_FIRCP_SUBACT WHERE FIRCPSAC_SAC_CODE_FK_PK = " & cn.SQLText(sCodeSAC) & ")"
            End If
            If sCodeSAU <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIRCP_CODE_SQ_PK IN (SELECT FIRCPSAU_FIRCP_CODE_FK_PK FROM THERIAQUE.FIRCPSAU_FIRCP_SUBAUX WHERE FIRCPSAU_SAU_CODE_FK_PK = " & cn.SQLText(sCodeSAU) & ")"
            End If
            If sCodePR <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIRCP_CODE_SQ_PK IN (SELECT FIRCPPR_FIRCP_CODE_FK_PK FROM THERIAQUE.FIRCPPR_FIRCP_PROD WHERE FIRCPPR_PR_CODE_FK_PK = " & cn.SQLText(sCodePR) & ")"
            End If
            If sCodeSP <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIRCP_CODE_SQ_PK IN (SELECT FIRCPSP_FIRCP_CODE_FK_PK FROM THERIAQUE.FIRCPSP_INTERACTRCP_SPEC WHERE FIRCPSP_SP_CODE_FK_PK = " & cn.SQLText(sCodeSP) & ")"
            End If
            If sCodeCOM <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FIRCP_CODE_SQ_PK IN (SELECT FIRCPCOM_FIRCP_CODE_FK_PK FROM THERIAQUE.FIRCPCOM_FIRCP_COM WHERE FIRCPCOM_CDF_COM_CODE_FK_PK = " & cn.SQLText(sCodeCOM) & ")"
            End If
            sSQL &= " ORDER BY FIRCP_CODE_SQ_PK"

            fResultat._SSQL = sSQL
            fResultat.Text = Me.Text
            fResultat.ShowDialog()
            CodE = fResultat._Code
            If fResultat._Code IsNot Nothing Then
                XtraTabControl1.SelectedTabPageIndex = 0
                OnLoading = True
                EmptyDataTable()
                Me.FircP_TA.FillByCode(Me.DsTheriaque_InteractionRCP.FIRCP_INTERACTIONRCP, fResultat._Code)
                'Onglet Entités
                Me.FircpcpH_TA.FillByCode(Me.DsTheriaque_InteractionRCP.FIRCPCPH_FIRCP_CLPH, fResultat._Code)
                Me.FircpccH_TA.FillByCode(Me.DsTheriaque_InteractionRCP.FIRCPCCH_FIRCP_CLCH, fResultat._Code)
                Me.FircpsaC_TA.FillByCode(Me.DsTheriaque_InteractionRCP.FIRCPSAC_FIRCP_SUBACT, fResultat._Code)
                Me.FircpsaU_TA.FillByCode(Me.DsTheriaque_InteractionRCP.FIRCPSAU_FIRCP_SUBAUX, fResultat._Code)
                Me.FircppR_TA.FillByCode(Me.DsTheriaque_InteractionRCP.FIRCPPR_FIRCP_PROD, fResultat._Code)
                Me.FircpsP_TA.FillByCode(Me.DsTheriaque_InteractionRCP.FIRCPSP_INTERACTRCP_SPEC, fResultat._Code)

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
            For iCount = 0 To DsTheriaque_InteractionRCP.FIRCPCPH_FIRCP_CLPH.Rows.Count - 1
                DsTheriaque_InteractionRCP.FIRCPCPH_FIRCP_CLPH.Rows(iCount).Delete()
            Next
            Me.FircpcpH_TA.Update(DsTheriaque_InteractionRCP)

            For iCount = 0 To DsTheriaque_InteractionRCP.FIRCPCCH_FIRCP_CLCH.Rows.Count - 1
                DsTheriaque_InteractionRCP.FIRCPCCH_FIRCP_CLCH.Rows(iCount).Delete()
            Next
            Me.FircpccH_TA.Update(DsTheriaque_InteractionRCP)

            For iCount = 0 To DsTheriaque_InteractionRCP.FIRCPSAC_FIRCP_SUBACT.Rows.Count - 1
                DsTheriaque_InteractionRCP.FIRCPSAC_FIRCP_SUBACT.Rows(iCount).Delete()
            Next
            Me.FircpsaC_TA.Update(DsTheriaque_InteractionRCP)

            For iCount = 0 To DsTheriaque_InteractionRCP.FIRCPSAU_FIRCP_SUBAUX.Rows.Count - 1
                DsTheriaque_InteractionRCP.FIRCPSAU_FIRCP_SUBAUX.Rows(iCount).Delete()
            Next
            Me.FircpsaU_TA.Update(DsTheriaque_InteractionRCP)

            For iCount = 0 To DsTheriaque_InteractionRCP.FIRCPPR_FIRCP_PROD.Rows.Count - 1
                DsTheriaque_InteractionRCP.FIRCPPR_FIRCP_PROD.Rows(iCount).Delete()
            Next
            Me.FircppR_TA.Update(DsTheriaque_InteractionRCP)

            For iCount = 0 To DsTheriaque_InteractionRCP.FIRCPSP_INTERACTRCP_SPEC.Rows.Count - 1
                DsTheriaque_InteractionRCP.FIRCPSP_INTERACTRCP_SPEC.Rows(iCount).Delete()
            Next
            Me.FircpsP_TA.Update(DsTheriaque_InteractionRCP)

            'Onglet Réferences officielles
            For iCount = 0 To DsTheriaque_InteractionRCP.FIRCPCOM_FIRCP_COM.Rows.Count - 1
                DsTheriaque_InteractionRCP.FIRCPCOM_FIRCP_COM.Rows(iCount).Delete()
            Next
            Me.FircpcoM_TA.Update(DsTheriaque_InteractionRCP)

            For iCount = 0 To DsTheriaque_InteractionRCP.FIRCPAFS_FIRCP_AFSSAPS.Rows.Count - 1
                DsTheriaque_InteractionRCP.FIRCPAFS_FIRCP_AFSSAPS.Rows(iCount).Delete()
            Next
            Me.FircpafS_TA.Update(DsTheriaque_InteractionRCP)

            ' Master
            DsTheriaque_InteractionRCP.FIRCP_INTERACTIONRCP.Rows(0).Delete()
            Me.FircP_TA.Update(Me.MasterDataSet)

            bModeDuplication = False
            Return True
        Else
            Process_Message(strChargementOnglet, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Function
    Public Overrides Sub valider()
        MyBase.Valider()
        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        FircP_TA.Update(Me.DsTheriaque_InteractionRCP.FIRCP_INTERACTIONRCP)
        'Onglet Entités
        Me.BindingContext(Me.MasterDataSet, FIRCPCPH_FIRCP_CLPH).EndCurrentEdit()
        FircpcpH_TA.Update(Me.DsTheriaque_InteractionRCP.FIRCPCPH_FIRCP_CLPH)

        Me.BindingContext(Me.MasterDataSet, FIRCPCCH_FIRCP_CLCH).EndCurrentEdit()
        FircpccH_TA.Update(Me.DsTheriaque_InteractionRCP.FIRCPCCH_FIRCP_CLCH)

        Me.BindingContext(Me.MasterDataSet, FIRCPSAC_FIRCP_SUBACT).EndCurrentEdit()
        FircpsaC_TA.Update(Me.DsTheriaque_InteractionRCP.FIRCPSAC_FIRCP_SUBACT)

        Me.BindingContext(Me.MasterDataSet, FIRCPSAU_FIRCP_SUBAUX).EndCurrentEdit()
        FircpsaU_TA.Update(Me.DsTheriaque_InteractionRCP.FIRCPSAU_FIRCP_SUBAUX)

        Me.BindingContext(Me.MasterDataSet, FIRCPPR_FIRCP_PROD).EndCurrentEdit()
        FircppR_TA.Update(Me.DsTheriaque_InteractionRCP.FIRCPPR_FIRCP_PROD)

        Me.BindingContext(Me.MasterDataSet, FIRCPSP_INTERACTRCP_SPEC).EndCurrentEdit()
        FircpsP_TA.Update(Me.DsTheriaque_InteractionRCP.FIRCPSP_INTERACTRCP_SPEC)

        'Onglet(Réf.officielles / commentaires)
        Me.BindingContext(Me.MasterDataSet, FIRCPCOM_FIRCP_COM).EndCurrentEdit()
        FircpcoM_TA.Update(Me.DsTheriaque_InteractionRCP.FIRCPCOM_FIRCP_COM)

        Me.BindingContext(Me.MasterDataSet, FIRCPAFS_FIRCP_AFSSAPS).EndCurrentEdit()
        FircpafS_TA.Update(Me.DsTheriaque_InteractionRCP.FIRCPAFS_FIRCP_AFSSAPS)

        bModeDuplication = False
        'Tab_TA1 = True
    End Sub
    Public Overrides Sub annuler()
        OnLoading = True
        MyBase.Annuler()
        'Onglet Entités
        Me.BindingContext(DsTheriaque_InteractionRCP, FIRCPCPH_FIRCP_CLPH).CancelCurrentEdit()
        Me.DsTheriaque_InteractionRCP.FIRCPCPH_FIRCP_CLPH.RejectChanges()

        Me.BindingContext(DsTheriaque_InteractionRCP, FIRCPCCH_FIRCP_CLCH).CancelCurrentEdit()
        Me.DsTheriaque_InteractionRCP.FIRCPCCH_FIRCP_CLCH.RejectChanges()

        Me.BindingContext(DsTheriaque_InteractionRCP, FIRCPSAC_FIRCP_SUBACT).CancelCurrentEdit()
        Me.DsTheriaque_InteractionRCP.FIRCPSAC_FIRCP_SUBACT.RejectChanges()

        Me.BindingContext(DsTheriaque_InteractionRCP, FIRCPSAU_FIRCP_SUBAUX).CancelCurrentEdit()
        Me.DsTheriaque_InteractionRCP.FIRCPSAU_FIRCP_SUBAUX.RejectChanges()

        Me.BindingContext(DsTheriaque_InteractionRCP, FIRCPPR_FIRCP_PROD).CancelCurrentEdit()
        Me.DsTheriaque_InteractionRCP.FIRCPPR_FIRCP_PROD.RejectChanges()

        Me.BindingContext(DsTheriaque_InteractionRCP, FIRCPSP_INTERACTRCP_SPEC).CancelCurrentEdit()
        Me.DsTheriaque_InteractionRCP.FIRCPSP_INTERACTRCP_SPEC.RejectChanges()

        'Onglet(Réf.officielles / commentaires)
        Me.BindingContext(DsTheriaque_InteractionRCP, FIRCPCOM_FIRCP_COM).CancelCurrentEdit()
        Me.DsTheriaque_InteractionRCP.FIRCPCOM_FIRCP_COM.RejectChanges()

        Me.BindingContext(DsTheriaque_InteractionRCP, FIRCPAFS_FIRCP_AFSSAPS).CancelCurrentEdit()
        Me.DsTheriaque_InteractionRCP.FIRCPAFS_FIRCP_AFSSAPS.RejectChanges()

        'Master
        Me.BindingContext(Me.MasterDataSet, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_InteractionRCP.FIRCP_INTERACTIONRCP.RejectChanges()

        If bModeDuplication Then EmptyDataTable()
        bModeDuplication = False
        OnLoading = False
    End Sub
    Private Sub EmptyDataTable()
        'Master
        Me.DsTheriaque_InteractionRCP.FIRCP_INTERACTIONRCP.Clear()
        'Onglet Entités
        Me.DsTheriaque_InteractionRCP.FIRCPCPH_FIRCP_CLPH.Clear()
        Me.DsTheriaque_InteractionRCP.FIRCPCCH_FIRCP_CLCH.Clear()
        Me.DsTheriaque_InteractionRCP.FIRCPSAC_FIRCP_SUBACT.Clear()
        Me.DsTheriaque_InteractionRCP.FIRCPSAU_FIRCP_SUBAUX.Clear()
        Me.DsTheriaque_InteractionRCP.FIRCPPR_FIRCP_PROD.Clear()
        Me.DsTheriaque_InteractionRCP.FIRCPSP_INTERACTRCP_SPEC.Clear()

        'Onglet Réf.officielles / commentaires
        Me.DsTheriaque_InteractionRCP.FIRCPCOM_FIRCP_COM.Clear()
        Me.DsTheriaque_InteractionRCP.FIRCPAFS_FIRCP_AFSSAPS.Clear()

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
        dt1 = DsTheriaque_InteractionRCP.FIRCPCPH_FIRCP_CLPH.Copy

        Dim dt2 As New DataTable
        dt2 = DsTheriaque_InteractionRCP.FIRCPCCH_FIRCP_CLCH.Copy

        Dim dt3 As New DataTable
        dt3 = DsTheriaque_InteractionRCP.FIRCPSAC_FIRCP_SUBACT.Copy

        Dim dt4 As New DataTable
        dt4 = DsTheriaque_InteractionRCP.FIRCPSAU_FIRCP_SUBAUX.Copy

        Dim dt5 As New DataTable
        dt5 = DsTheriaque_InteractionRCP.FIRCPPR_FIRCP_PROD.Copy

        Dim dt6 As New DataTable
        dt6 = DsTheriaque_InteractionRCP.FIRCPSP_INTERACTRCP_SPEC.Copy

        'Onglet RefOff/Commentaires
        Dim dt21 As New DataTable
        dt21 = DsTheriaque_InteractionRCP.FIRCPCOM_FIRCP_COM.Copy

        Dim dt22 As New DataTable
        dt22 = DsTheriaque_InteractionRCP.FIRCPAFS_FIRCP_AFSSAPS.Copy

        Dim sText As String = MemoEdit3.Text

        'Vider les contrôles
        EmptyDataTable()

        'Construction de la nouvelle fiche avec les données de la fiche de base
        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        SetCode_MAx(MasterTable, txtCode)
        CodE = InvalideControl


        Dim drTemp As DataRow
        For iCount As Integer = 0 To dt1.Rows.Count - 1
            drTemp = DsTheriaque_InteractionRCP.Tables("FIRCPCPH_FIRCP_CLPH").NewRow()
            drTemp.ItemArray = dt1.Rows(iCount).ItemArray
            DsTheriaque_InteractionRCP.Tables("FIRCPCPH_FIRCP_CLPH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt2.Rows.Count - 1
            drTemp = DsTheriaque_InteractionRCP.Tables("FIRCPCCH_FIRCP_CLCH").NewRow()
            drTemp.ItemArray = dt2.Rows(iCount).ItemArray
            DsTheriaque_InteractionRCP.Tables("FIRCPCCH_FIRCP_CLCH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt3.Rows.Count - 1
            drTemp = DsTheriaque_InteractionRCP.Tables("FIRCPSAC_FIRCP_SUBACT").NewRow()
            drTemp.ItemArray = dt3.Rows(iCount).ItemArray
            DsTheriaque_InteractionRCP.Tables("FIRCPSAC_FIRCP_SUBACT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt4.Rows.Count - 1
            drTemp = DsTheriaque_InteractionRCP.Tables("FIRCPSAU_FIRCP_SUBAUX").NewRow()
            drTemp.ItemArray = dt4.Rows(iCount).ItemArray
            DsTheriaque_InteractionRCP.Tables("FIRCPSAU_FIRCP_SUBAUX").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt5.Rows.Count - 1
            drTemp = DsTheriaque_InteractionRCP.Tables("FIRCPPR_FIRCP_PROD").NewRow()
            drTemp.ItemArray = dt5.Rows(iCount).ItemArray
            DsTheriaque_InteractionRCP.Tables("FIRCPPR_FIRCP_PROD").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt6.Rows.Count - 1
            drTemp = DsTheriaque_InteractionRCP.Tables("FIRCPSP_INTERACTRCP_SPEC").NewRow()
            drTemp.ItemArray = dt6.Rows(iCount).ItemArray
            DsTheriaque_InteractionRCP.Tables("FIRCPSP_INTERACTRCP_SPEC").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt21.Rows.Count - 1
            drTemp = DsTheriaque_InteractionRCP.Tables("FIRCPCOM_FIRCP_COM").NewRow()
            drTemp.ItemArray = dt21.Rows(iCount).ItemArray
            DsTheriaque_InteractionRCP.Tables("FIRCPCOM_FIRCP_COM").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt22.Rows.Count - 1
            drTemp = DsTheriaque_InteractionRCP.Tables("FIRCPAFS_FIRCP_AFSSAPS").NewRow()
            drTemp.ItemArray = dt22.Rows(iCount).ItemArray
            DsTheriaque_InteractionRCP.Tables("FIRCPAFS_FIRCP_AFSSAPS").Rows.Add(drTemp)
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
        'GV1
        For iCount As Integer = 0 To GV1.RowCount - 1
            GV1.SetRowCellValue(iCount, colFIRCPCPH_FIRCP_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV2
        For iCount As Integer = 0 To GV2.RowCount - 1
            GV2.SetRowCellValue(iCount, colFIRCPCCH_FIRCP_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV3
        For iCount As Integer = 0 To GV3.RowCount - 1
            GV3.SetRowCellValue(iCount, colFIRCPSAC_FIRCP_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV4
        For iCount As Integer = 0 To GV4.RowCount - 1
            GV4.SetRowCellValue(iCount, colFIRCPSAU_FIRCP_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV5
        For iCount As Integer = 0 To GV5.RowCount - 1
            GV5.SetRowCellValue(iCount, colFIRCPPR_FIRCP_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV6
        For iCount As Integer = 0 To GV6.RowCount - 1
            GV6.SetRowCellValue(iCount, colFIRCPSP_FIRCP_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV21
        For iCount As Integer = 0 To GV21.RowCount - 1
            GV21.SetRowCellValue(iCount, colFIRCPCOM_FIRCP_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV22
        For iCount As Integer = 0 To GV22.RowCount - 1
            GV22.SetRowCellValue(iCount, colFIRCPAFS_FIRCP_CODE_FK_PK, Me.txtCode.Text)
        Next
    End Sub

    Protected Friend Overrides Function ValideControl(Optional ByRef Ctrl As Control = Nothing, Optional ByVal AllCtrl As Boolean = True) As Boolean
        Dim strSSQL As String = ""
        MyBase.ValideControl(Ctrl)
        For iCount As Integer = 0 To GV22.RowCount - 1
            If Not FieldExistRO(GV6, colFIRCPSP_SP_CODE_FK_PK, GV22.GetRowCellValue(iCount, colFIRCPAFS_SP_CODE_FK_PK)) Then
                GV22.FocusedRowHandle = iCount
                GV22.SetColumnError(colFIRCPAFS_SP_CODE_FK_PK, "La spécialité doit être présente dans la fiche.")
                XtraTabControl1.SelectedTabPageIndex = 1
                Exit Function
            Else
                GV22.SetColumnError(colFIRCPAFS_SP_CODE_FK_PK, "")
            End If
        Next

        Return True
    End Function

#End Region

#Region " Init Data  "

    Private Sub InitDataSource()
        'Onglet Entités
        GC1.DataSource = DsTheriaque_InteractionRCP
        GC1.DataMember = FIRCPCPH_FIRCP_CLPH

        GC2.DataSource = DsTheriaque_InteractionRCP
        GC2.DataMember = FIRCPCCH_FIRCP_CLCH

        GC3.DataSource = DsTheriaque_InteractionRCP
        GC3.DataMember = FIRCPSAC_FIRCP_SUBACT

        GC4.DataSource = DsTheriaque_InteractionRCP
        GC4.DataMember = FIRCPSAU_FIRCP_SUBAUX

        GC5.DataSource = DsTheriaque_InteractionRCP
        GC5.DataMember = FIRCPPR_FIRCP_PROD

        GC6.DataSource = DsTheriaque_InteractionRCP
        GC6.DataMember = FIRCPSP_INTERACTRCP_SPEC

        'Onglet(Réf.officielles / commentaires)
        GC21.DataSource = DsTheriaque_InteractionRCP
        GC21.DataMember = FIRCPCOM_FIRCP_COM

        GC22.DataSource = DsTheriaque_InteractionRCP
        GC22.DataMember = FIRCPAFS_FIRCP_AFSSAPS

    End Sub
    Public Overrides Sub InitData()
        MyBase.InitData()
        OnLoading = True
        Declinaison_Global = True
        MasterDataSet = Me.DsTheriaque_InteractionRCP
        MasterTable = FIRCP_INTERACTIONRCP
        CodE = InvalideControl

        'Déclinaison classe CPH
        Dim List1 As New System.Collections.Generic.List(Of StructGVTable)
        List1.Add(New StructGVTable("GC1", eDeclinaison.CPH, colFIRCPCPH_CPH_CODE_FK_PK2))
        List1.Add(New StructGVTable("GC2", eDeclinaison.CCH, colFIRCPCCH_CCH_CODE_FK_PK2))
        List1.Add(New StructGVTable("GC3", eDeclinaison.SAC, colFIRCPSAC_SAC_CODE_FK_PK2))
        List1.Add(New StructGVTable("GC6", eDeclinaison.SP, colFIRCPSP_SP_CODE_FK_PK2))
        Dim DecCPH As New ClsDeclinaison(eDeclinaison.CPH, List1)
        InitLkup(Me.lkup_FIRCPCPH, FIRCPCPH_FIRCP_CLPH, strSSQL_CPH_CLASSEPHARMTHER_NIVEAU, True, , , , , , DecCPH)

        'Déclinaison classe CCH
        Dim List2 As New System.Collections.Generic.List(Of StructGVTable)
        List2.Add(New StructGVTable("GC1", eDeclinaison.CPH, colFIRCPCPH_CPH_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC2", eDeclinaison.CCH, colFIRCPCCH_CCH_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC3", eDeclinaison.SAC, colFIRCPSAC_SAC_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC4", eDeclinaison.SAU, colFIRCPSAU_SAU_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC6", eDeclinaison.SP, colFIRCPSP_SP_CODE_FK_PK2))
        Dim DecCCH As New ClsDeclinaison(eDeclinaison.CCH, List2)
        InitLkup(Me.lkup_FIRCPCCH, FIRCPCCH_FIRCP_CLCH, strSSQL_CCH_CLASSECHIMIQUE_NIVEAU, True, , , , , , DecCCH)

        'Déclinaison SUBAC
        Dim List3 As New System.Collections.Generic.List(Of StructGVTable)
        List3.Add(New StructGVTable("GC3", eDeclinaison.SAC, colFIRCPSAC_SAC_CODE_FK_PK2))
        List3.Add(New StructGVTable("GC6", eDeclinaison.SP, colFIRCPSP_SP_CODE_FK_PK2))
        Dim DecSUBAC As New ClsDeclinaison(eDeclinaison.SAC, List3)
        InitLkup(Me.lkup_FIRCPSAC, FIRCPSAC_FIRCP_SUBACT, strSSQL_SAC_SUBACTIVE, True, , , , , , DecSUBAC)

        'Déclinaison SAU
        Dim List4 As New System.Collections.Generic.List(Of StructGVTable)
        List4.Add(New StructGVTable("GC4", eDeclinaison.SAU, colFIRCPSAU_SAU_CODE_FK_PK2))
        List4.Add(New StructGVTable("GC6", eDeclinaison.SP, colFIRCPSP_SP_CODE_FK_PK2))
        Dim DecSAU As New ClsDeclinaison(eDeclinaison.SAU, List4)
        InitLkup(Me.lkup_FIRCPSAU, FIRCPSAU_FIRCP_SUBAUX, strSSQL_SAU_SUBAUXILIAIRE, True, , , , , , DecSAU)

        'Déclinaison PRODUIT
        Dim List5 As New System.Collections.Generic.List(Of StructGVTable)
        List5.Add(New StructGVTable("GC5", eDeclinaison.PR, colFIRCPPR_PR_CODE_FK_PK2))
        List5.Add(New StructGVTable("GC6", eDeclinaison.SP, colFIRCPSP_SP_CODE_FK_PK2))
        Dim DecPR As New ClsDeclinaison(eDeclinaison.PR, List5)
        InitLkup(Me.lkup_FIRCPPR, FIRCPPR_FIRCP_PROD, strSSQL_PR_PRODUIT, True, , , , , , DecPR)

        InitLkup(Me.lkup_FIRCPSP, FIRCPSP_INTERACTRCP_SPEC, strSSQL_SP_SPECIALITE, True)

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
        Me.FircP_TA.FillByCode(Me.DsTheriaque_InteractionRCP.FIRCP_INTERACTIONRCP, CodE1)
        'Onglet Entités
        Me.FircpcpH_TA.FillByCode(Me.DsTheriaque_InteractionRCP.FIRCPCPH_FIRCP_CLPH, CodE1)
        Me.FircpccH_TA.FillByCode(Me.DsTheriaque_InteractionRCP.FIRCPCCH_FIRCP_CLCH, CodE1)
        Me.FircpsaC_TA.FillByCode(Me.DsTheriaque_InteractionRCP.FIRCPSAC_FIRCP_SUBACT, CodE1)
        Me.FircpsaU_TA.FillByCode(Me.DsTheriaque_InteractionRCP.FIRCPSAU_FIRCP_SUBAUX, CodE1)
        Me.FircppR_TA.FillByCode(Me.DsTheriaque_InteractionRCP.FIRCPPR_FIRCP_PROD, CodE1)
        Me.FircpsP_TA.FillByCode(Me.DsTheriaque_InteractionRCP.FIRCPSP_INTERACTRCP_SPEC, CodE1)

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
            strSSQL_SP_REF = " SELECT SP_CODE_SQ_PK as code, SP_NOM as libelle FROM THERIAQUE.FIRCPSP_INTERACTRCP_SPEC, THERIAQUE.SP_SPECIALITE"
            strSSQL_SP_REF &= " WHERE FIRCPSP_FIRCP_CODE_FK_PK = " & CodE
            strSSQL_SP_REF &= " AND SP_CODE_SQ_PK = FIRCPSP_SP_CODE_FK_PK"
            InitLkup(Me.lkup_AFS, FIRCPAFS_FIRCP_AFSSAPS, strSSQL_SP_REF, True)
            For iCount As Integer = 0 To GV22.RowCount
                If GV22.GetRowCellDisplayText(iCount, "FIRCPAFS_SP_CODE_FK_PK") = "" And GV22.GetRowCellDisplayText(iCount, "FIRCPAFS_FIRCP_CODE_FK_PK") <> "" Then
                    GV22.DeleteRow(iCount)
                    iCount = iCount - 1
                End If
            Next
        End If
        If Not Tab_lkup1 Then
            InitLkup(Me.Lkup_FIRCPCOM, FIRCPCOM_FIRCP_COM, strSSQL_CDF_CODIF("HC"), True)
            InitLkup(Me.lkup_FIRCPAFS, FIRCPAFS_FIRCP_AFSSAPS, strSSQL_CDF_CODIF("25"), True)
            Tab_lkup1 = True
        End If

        If Not Tab_TA1 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.FircpcoM_TA.FillByCode(Me.DsTheriaque_InteractionRCP.FIRCPCOM_FIRCP_COM, CodE)
            Me.FircpafS_TA.FillByCode(Me.DsTheriaque_InteractionRCP.FIRCPAFS_FIRCP_AFSSAPS, CodE)
            Me.FircP_TA.FillByCode(Me.DsTheriaque_InteractionRCP.FIRCP_INTERACTIONRCP, CodE)
            Tab_TA1 = True
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub
#End Region

#Region " New Row "

    Private Sub GV1_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV1.InitNewRow
        If OnLoading Then Exit Sub
        GV1.SetFocusedRowCellValue(colFIRCPCPH_FIRCP_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        If OnLoading Then Exit Sub
        GV2.SetFocusedRowCellValue(colFIRCPCCH_FIRCP_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV3_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV3.InitNewRow
        If OnLoading Then Exit Sub
        GV3.SetFocusedRowCellValue(colFIRCPSAC_FIRCP_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV4_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV4.InitNewRow
        If OnLoading Then Exit Sub
        GV4.SetFocusedRowCellValue(colFIRCPSAU_FIRCP_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV5_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV5.InitNewRow
        If OnLoading Then Exit Sub
        GV5.SetFocusedRowCellValue(colFIRCPPR_FIRCP_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV6_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV6.InitNewRow
        If OnLoading Then Exit Sub
        GV6.SetFocusedRowCellValue(colFIRCPSP_FIRCP_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV21_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV21.InitNewRow
        If OnLoading Then Exit Sub
        GV21.SetFocusedRowCellValue(colFIRCPCOM_FIRCP_CODE_FK_PK, txtCode.Text)
        GV21.SetFocusedRowCellValue(colFIRCPCOM_NUMORD, Code_MAx(GV21, colFIRCPCOM_NUMORD))
    End Sub
    Private Sub GV22_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV22.InitNewRow
        If OnLoading Then Exit Sub
        GV22.SetFocusedRowCellValue(colFIRCPAFS_FIRCP_CODE_FK_PK, txtCode.Text)
    End Sub

#End Region

#Region " Pannel  "

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
    Private Sub XtraTabControl1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraTabControl1.Resize
        Panel4.Height = XtraTabControl1.Height / 3
        Panel6.Height = XtraTabControl1.Height / 3
        Panel7.Height = XtraTabControl1.Height / 3

        Panel8.Height = XtraTabControl1.Height / 3
        Panel9.Height = XtraTabControl1.Height / 3
        Panel10.Height = XtraTabControl1.Height / 3
    End Sub
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPageIndex = 1 Then
            LoadTab_1()
            Exit Sub
        End If
    End Sub
#End Region

End Class
