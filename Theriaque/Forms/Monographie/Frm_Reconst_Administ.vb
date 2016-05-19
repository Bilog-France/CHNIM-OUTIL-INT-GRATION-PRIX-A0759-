''' <summary>
''' Created By [BFE]
''' </summary>
''' <remarks> Monographie - Reconst / Administ
''' </remarks>
Public Class Frm_Reconst_Administ

#Region "Déclaration des variables privées"
    Private CodE As String
    Public _Code As Integer = Nothing ' charger la fiche depuis l'extérieur
    Private Tab_lkup1 As Boolean = False
    Private Tab_TA1 As Boolean = False
    Private Tab_lkup2 As Boolean = False
    Private Tab_TA2 As Boolean = False
    Private bModeDuplication As Boolean = False
#End Region

#Region " Edit Data "

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_FREC_RECONSADM_SPECIALITE()
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then

            XtraTabControl1.SelectedTabPageIndex = 0
            OnLoading = True
            EmptyDataTable()
            Me.FreC_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FREC_RECONSADM, f._Code)
            'Onglet Entités
            Me.FreccpH_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FRECCPH_FREC_CLPH, f._Code)
            Me.FrecccH_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FRECCCH_FREC_CLCH, f._Code)
            Me.FrecsaC_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FRECSAC_FREC_SUBACT, f._Code)
            Me.FrecpR_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FRECPR_FREC_PROD, f._Code)
            Me.FreccH_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FRECCH_RECONSTCH, f._Code)
            Me.FrecsP_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FRECSP_RECONST_SPEC, f._Code)

            Tab_TA1 = False
            Tab_TA2 = False

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
        Dim sCodeSP As String = ""
        Dim sCodeCC As String = ""
        Dim sCodeRC As String = ""
        Dim f As New Frm_ReconstAdminMultiCriteres
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
                fDICO._SSQL = strSSQL_CDF_CODIF("RC", " and substring(CDF_CODE_PK, 1, 1) IN('L','M', 'N', 'O', 'P', 'Q', 'S', 'T', 'U', 'V', 'W', 'X', 'Y')")
                fDICO.Text = "Modes d'administration / Commentaires"
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
            If f._bRC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("RC", " and Substring(CDF_CODE_PK, 1, 1) IN('A','B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'R', 'X')")
                fDICO.Text = "Modes de reconstitution / Commentaires"
                fDICO.ShowDialog()
                sCodeRC = fDICO._Code
            End If

            Dim fResultat As New Frm_Recherche
            Dim sSQL As String = ""
            sSQL &= " Select FREC_CODE_SQ_PK as code, '' as libelle From THERIAQUE.FREC_RECONSADM"
            If sCodeCPH <> "" Then
                sSQL &= " WHERE FREC_CODE_SQ_PK IN (SELECT FRECCPH_FREC_CODE_FK_PK FROM THERIAQUE.FRECCPH_FREC_CLPH WHERE FRECCPH_CPH_CODE_FK_PK = " & cn.SQLText(sCodeCPH) & ")"
            End If
            If sCodeCCH <> "" Then
                If sCodeCPH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FREC_CODE_SQ_PK IN (SELECT FRECCCH_FREC_CODE_FK_PK FROM THERIAQUE.FRECCCH_FREC_CLCH WHERE FRECCCH_CCH_CODE_FK_PK = " & cn.SQLText(sCodeCCH) & ")"
            End If
            If sCodeSAC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FREC_CODE_SQ_PK IN (SELECT FRECSAC_FREC_CODE_FK_PK FROM THERIAQUE.FRECSAC_FREC_SUBACT WHERE FRECSAC_SAC_CODE_FK_PK = " & cn.SQLText(sCodeSAC) & ")"
            End If
            If sCodePR <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FREC_CODE_SQ_PK IN (SELECT FRECPR_FREC_CODE_FK_PK FROM THERIAQUE.FRECPR_FREC_PROD WHERE FRECPR_PR_CODE_FK_PK = " & cn.SQLText(sCodePR) & ")"
            End If
            If sCodeSP <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FREC_CODE_SQ_PK IN (SELECT FRECSP_FREC_CODE_FK_PK FROM THERIAQUE.FRECSP_RECONST_SPEC WHERE FRECSP_SP_CODE_FK_PK = " & cn.SQLText(sCodeSP) & ")"
            End If
            If sCodeCOM <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Or sCodeSP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FREC_CODE_SQ_PK IN (SELECT FRECCOA_FREC_CODE_FK_PK FROM THERIAQUE.FRECCOA_FREC_COMADM WHERE FRECCOA_CDF_COMADM_FK_PK = " & cn.SQLText(sCodeCOM) & ")"
            End If
            If sCodeCC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCOM <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FREC_CODE_SQ_PK IN (SELECT FRECCH_FREC_CODE_FK_PK FROM THERIAQUE.FRECCH_RECONSTCH WHERE FRECCH_CH_CODE_FK_PK = " & cn.SQLText(sCodeCC) & ")"
            End If
            If sCodeRC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FREC_CODE_SQ_PK IN (SELECT FRECCOR_FREC_CODE_FK_PK FROM THERIAQUE.FRECCOR_FREC_COMRECS WHERE FRECCOR_CDF_COMRECS_FK_PK = " & cn.SQLText(sCodeRC) & ")"
            End If
            sSQL &= " ORDER BY FREC_CODE_SQ_PK"

            fResultat._SSQL = sSQL
            fResultat.Text = Me.Text
            fResultat.ShowDialog()
            CodE = fResultat._Code
            If fResultat._Code IsNot Nothing Then
                XtraTabControl1.SelectedTabPageIndex = 0
                OnLoading = True
                EmptyDataTable()
                Me.FreC_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FREC_RECONSADM, fResultat._Code)
                'Onglet Entités
                Me.FreccpH_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FRECCPH_FREC_CLPH, fResultat._Code)
                Me.FrecccH_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FRECCCH_FREC_CLCH, fResultat._Code)
                Me.FrecsaC_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FRECSAC_FREC_SUBACT, fResultat._Code)
                Me.FrecpR_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FRECPR_FREC_PROD, fResultat._Code)
                Me.FreccH_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FRECCH_RECONSTCH, fResultat._Code)
                Me.FrecsP_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FRECSP_RECONST_SPEC, fResultat._Code)

                Tab_TA1 = False
                Tab_TA2 = False

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
        Me.lkup_FRECVO.DataSource = Nothing
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
        If Tab_TA1 And Tab_TA2 Then
            'Onglet Entités
            For iCount = 0 To DsTheriaque_Reconst_Administ.FRECCPH_FREC_CLPH.Rows.Count - 1
                DsTheriaque_Reconst_Administ.FRECCPH_FREC_CLPH.Rows(iCount).Delete()
            Next
            Me.FreccpH_TA.Update(DsTheriaque_Reconst_Administ)

            For iCount = 0 To DsTheriaque_Reconst_Administ.FRECCCH_FREC_CLCH.Rows.Count - 1
                DsTheriaque_Reconst_Administ.FRECCCH_FREC_CLCH.Rows(iCount).Delete()
            Next
            Me.FrecccH_TA.Update(DsTheriaque_Reconst_Administ)

            For iCount = 0 To DsTheriaque_Reconst_Administ.FRECSAC_FREC_SUBACT.Rows.Count - 1
                DsTheriaque_Reconst_Administ.FRECSAC_FREC_SUBACT.Rows(iCount).Delete()
            Next
            Me.FrecsaC_TA.Update(DsTheriaque_Reconst_Administ)

            For iCount = 0 To DsTheriaque_Reconst_Administ.FRECPR_FREC_PROD.Rows.Count - 1
                DsTheriaque_Reconst_Administ.FRECPR_FREC_PROD.Rows(iCount).Delete()
            Next
            Me.FrecpR_TA.Update(DsTheriaque_Reconst_Administ)

            For iCount = 0 To DsTheriaque_Reconst_Administ.FRECCH_RECONSTCH.Rows.Count - 1
                DsTheriaque_Reconst_Administ.FRECCH_RECONSTCH.Rows(iCount).Delete()
            Next
            Me.FreccH_TA.Update(DsTheriaque_Reconst_Administ)

            For iCount = 0 To DsTheriaque_Reconst_Administ.FRECSP_RECONST_SPEC.Rows.Count - 1
                DsTheriaque_Reconst_Administ.FRECSP_RECONST_SPEC.Rows(iCount).Delete()
            Next
            Me.FrecsP_TA.Update(DsTheriaque_Reconst_Administ)

            ' Mode de Reconstitution / Administration

            For iCount = 0 To DsTheriaque_Reconst_Administ.FRECCOR_FREC_COMRECS.Rows.Count - 1
                DsTheriaque_Reconst_Administ.FRECCOR_FREC_COMRECS.Rows(iCount).Delete()
            Next
            Me.FreccoR_TA.Update(DsTheriaque_Reconst_Administ)

            For iCount = 0 To DsTheriaque_Reconst_Administ.FRECVO_RECONSADM_VOIE.Rows.Count - 1
                DsTheriaque_Reconst_Administ.FRECVO_RECONSADM_VOIE.Rows(iCount).Delete()
            Next
            Me.FrecvO_TA.Update(DsTheriaque_Reconst_Administ)

            For iCount = 0 To DsTheriaque_Reconst_Administ.FRECTXR_FREC_TXTRECS.Rows.Count - 1
                DsTheriaque_Reconst_Administ.FRECTXR_FREC_TXTRECS.Rows(iCount).Delete()
            Next
            Me.FrectxR_TA.Update(DsTheriaque_Reconst_Administ)

            ' Références officielles / Commentaires
            For iCount = 0 To DsTheriaque_Reconst_Administ.FRECCOA_FREC_COMADM.Rows.Count - 1
                DsTheriaque_Reconst_Administ.FRECCOA_FREC_COMADM.Rows(iCount).Delete()
            Next
            Me.FreccoA_TA.Update(DsTheriaque_Reconst_Administ)

            For iCount = 0 To DsTheriaque_Reconst_Administ.FRECAFS_FREC_AFSSAPS.Rows.Count - 1
                DsTheriaque_Reconst_Administ.FRECAFS_FREC_AFSSAPS.Rows(iCount).Delete()
            Next
            Me.FrecafS_TA.Update(DsTheriaque_Reconst_Administ)

            For iCount = 0 To DsTheriaque_Reconst_Administ.FRECTXA_FREC_TXTADM.Rows.Count - 1
                DsTheriaque_Reconst_Administ.FRECTXA_FREC_TXTADM.Rows(iCount).Delete()
            Next
            Me.FrectxA_TA.Update(DsTheriaque_Reconst_Administ)

            ' Master
            DsTheriaque_Reconst_Administ.FREC_RECONSADM.Rows(0).Delete()
            Me.FreC_TA.Update(Me.MasterDataSet)

            bModeDuplication = False
            Return True
        Else
            Process_Message(strChargementOnglet, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Function
    Public Overrides Sub valider()
        MyBase.Valider()
        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        FreC_TA.Update(Me.DsTheriaque_Reconst_Administ.FREC_RECONSADM)
        'Onglet Entités
        Me.BindingContext(Me.MasterDataSet, FRECCPH_FREC_CLPH).EndCurrentEdit()
        FreccpH_TA.Update(Me.DsTheriaque_Reconst_Administ.FRECCPH_FREC_CLPH)

        Me.BindingContext(Me.MasterDataSet, FRECCCH_FREC_CLCH).EndCurrentEdit()
        FrecccH_TA.Update(Me.DsTheriaque_Reconst_Administ.FRECCCH_FREC_CLCH)

        Me.BindingContext(Me.MasterDataSet, FRECSAC_FREC_SUBACT).EndCurrentEdit()
        FrecsaC_TA.Update(Me.DsTheriaque_Reconst_Administ.FRECSAC_FREC_SUBACT)

        Me.BindingContext(Me.MasterDataSet, FRECPR_FREC_PROD).EndCurrentEdit()
        FrecpR_TA.Update(Me.DsTheriaque_Reconst_Administ.FRECPR_FREC_PROD)

        Me.BindingContext(Me.MasterDataSet, FRECCH_RECONSTCH).EndCurrentEdit()
        FreccH_TA.Update(Me.DsTheriaque_Reconst_Administ.FRECCH_RECONSTCH)

        Me.BindingContext(Me.MasterDataSet, FRECSP_RECONST_SPEC).EndCurrentEdit()
        FrecsP_TA.Update(Me.DsTheriaque_Reconst_Administ.FRECSP_RECONST_SPEC)

        ' Mode de Reconstitution / Administration

        Me.BindingContext(Me.MasterDataSet, FRECCOR_FREC_COMRECS).EndCurrentEdit()
        FreccoR_TA.Update(Me.DsTheriaque_Reconst_Administ.FRECCOR_FREC_COMRECS)

        Me.BindingContext(Me.MasterDataSet, FRECVO_RECONSADM_VOIE).EndCurrentEdit()
        FrecvO_TA.Update(Me.DsTheriaque_Reconst_Administ.FRECVO_RECONSADM_VOIE)

        Me.BindingContext(Me.MasterDataSet, FRECTXR_FREC_TXTRECS).EndCurrentEdit()
        FrectxR_TA.Update(Me.DsTheriaque_Reconst_Administ.FRECTXR_FREC_TXTRECS)

        ' Références officielles / Commentaires
        Me.BindingContext(Me.MasterDataSet, FRECCOA_FREC_COMADM).EndCurrentEdit()
        FreccoA_TA.Update(Me.DsTheriaque_Reconst_Administ.FRECCOA_FREC_COMADM)

        Me.BindingContext(Me.MasterDataSet, FRECAFS_FREC_AFSSAPS).EndCurrentEdit()
        FrecafS_TA.Update(Me.DsTheriaque_Reconst_Administ.FRECAFS_FREC_AFSSAPS)

        Me.BindingContext(Me.MasterDataSet, FRECTXA_FREC_TXTADM).EndCurrentEdit()
        FrectxA_TA.Update(Me.DsTheriaque_Reconst_Administ.FRECTXA_FREC_TXTADM)

        bModeDuplication = False
        'Tab_TA1 = True
        'Tab_TA2 = True
    End Sub
    Public Overrides Sub annuler()
        OnLoading = True
        MyBase.Annuler()
        'Onglet Entités
        Me.BindingContext(DsTheriaque_Reconst_Administ, FRECCPH_FREC_CLPH).CancelCurrentEdit()
        Me.DsTheriaque_Reconst_Administ.FRECCPH_FREC_CLPH.RejectChanges()

        Me.BindingContext(DsTheriaque_Reconst_Administ, FRECCCH_FREC_CLCH).CancelCurrentEdit()
        Me.DsTheriaque_Reconst_Administ.FRECCCH_FREC_CLCH.RejectChanges()

        Me.BindingContext(DsTheriaque_Reconst_Administ, FRECSAC_FREC_SUBACT).CancelCurrentEdit()
        Me.DsTheriaque_Reconst_Administ.FRECSAC_FREC_SUBACT.RejectChanges()

        Me.BindingContext(DsTheriaque_Reconst_Administ, FRECPR_FREC_PROD).CancelCurrentEdit()
        Me.DsTheriaque_Reconst_Administ.FRECPR_FREC_PROD.RejectChanges()

        Me.BindingContext(DsTheriaque_Reconst_Administ, FRECCH_RECONSTCH).CancelCurrentEdit()
        Me.DsTheriaque_Reconst_Administ.FRECCH_RECONSTCH.RejectChanges()

        Me.BindingContext(DsTheriaque_Reconst_Administ, FRECSP_RECONST_SPEC).CancelCurrentEdit()
        Me.DsTheriaque_Reconst_Administ.FRECSP_RECONST_SPEC.RejectChanges()

        ' Mode de Reconstitution / Administration

        Me.BindingContext(DsTheriaque_Reconst_Administ, FRECCOR_FREC_COMRECS).CancelCurrentEdit()
        Me.DsTheriaque_Reconst_Administ.FRECCOR_FREC_COMRECS.RejectChanges()

        Me.BindingContext(DsTheriaque_Reconst_Administ, FRECVO_RECONSADM_VOIE).CancelCurrentEdit()
        Me.DsTheriaque_Reconst_Administ.FRECVO_RECONSADM_VOIE.RejectChanges()

        Me.BindingContext(DsTheriaque_Reconst_Administ, FRECTXR_FREC_TXTRECS).CancelCurrentEdit()
        Me.DsTheriaque_Reconst_Administ.FRECTXR_FREC_TXTRECS.RejectChanges()

        ' Références officielles / Commentaires
        Me.BindingContext(DsTheriaque_Reconst_Administ, FRECCOA_FREC_COMADM).CancelCurrentEdit()
        Me.DsTheriaque_Reconst_Administ.FRECCOA_FREC_COMADM.RejectChanges()

        Me.BindingContext(DsTheriaque_Reconst_Administ, FRECAFS_FREC_AFSSAPS).CancelCurrentEdit()
        Me.DsTheriaque_Reconst_Administ.FRECAFS_FREC_AFSSAPS.RejectChanges()

        Me.BindingContext(DsTheriaque_Reconst_Administ, FRECTXA_FREC_TXTADM).CancelCurrentEdit()
        Me.DsTheriaque_Reconst_Administ.FRECTXA_FREC_TXTADM.RejectChanges()

        'Master
        Me.BindingContext(Me.MasterDataSet, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_Reconst_Administ.FREC_RECONSADM.RejectChanges()

        If bModeDuplication Then EmptyDataTable()
        bModeDuplication = False
        OnLoading = False
    End Sub
    Private Sub EmptyDataTable()
        'Master
        Me.DsTheriaque_Reconst_Administ.FREC_RECONSADM.Clear()
        'Onglet Entités
        Me.DsTheriaque_Reconst_Administ.FRECCPH_FREC_CLPH.Clear()
        Me.DsTheriaque_Reconst_Administ.FRECCCH_FREC_CLCH.Clear()
        Me.DsTheriaque_Reconst_Administ.FRECSAC_FREC_SUBACT.Clear()
        Me.DsTheriaque_Reconst_Administ.FRECPR_FREC_PROD.Clear()
        Me.DsTheriaque_Reconst_Administ.FRECCH_RECONSTCH.Clear()
        Me.DsTheriaque_Reconst_Administ.FRECSP_RECONST_SPEC.Clear()

        ' Mode de Reconstitution / Administration
        Me.DsTheriaque_Reconst_Administ.FRECCOR_FREC_COMRECS.Clear()
        Me.DsTheriaque_Reconst_Administ.FRECVO_RECONSADM_VOIE.Clear()
        Me.DsTheriaque_Reconst_Administ.FRECTXR_FREC_TXTRECS.Clear()

        ' Références officielles / Commentaires
        Me.DsTheriaque_Reconst_Administ.FRECCOA_FREC_COMADM.Clear()
        Me.DsTheriaque_Reconst_Administ.FRECAFS_FREC_AFSSAPS.Clear()
        Me.DsTheriaque_Reconst_Administ.FRECTXA_FREC_TXTADM.Clear()
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
        dt1 = DsTheriaque_Reconst_Administ.FRECCPH_FREC_CLPH.Copy

        Dim dt2 As New DataTable
        dt2 = DsTheriaque_Reconst_Administ.FRECCCH_FREC_CLCH.Copy

        Dim dt3 As New DataTable
        dt3 = DsTheriaque_Reconst_Administ.FRECSAC_FREC_SUBACT.Copy

        Dim dt4 As New DataTable
        dt4 = DsTheriaque_Reconst_Administ.FRECPR_FREC_PROD.Copy

        Dim dt5 As New DataTable
        dt5 = DsTheriaque_Reconst_Administ.FRECCH_RECONSTCH.Copy

        Dim dt6 As New DataTable
        dt6 = DsTheriaque_Reconst_Administ.FRECSP_RECONST_SPEC.Copy

        'Mode de reconstitution
        Dim dt21 As New DataTable
        dt21 = DsTheriaque_Reconst_Administ.FRECCOR_FREC_COMRECS.Copy

        Dim dt23 As New DataTable
        dt23 = DsTheriaque_Reconst_Administ.FRECTXR_FREC_TXTRECS.Copy

        'Mode d'administration
        Dim dt22 As New DataTable
        dt22 = DsTheriaque_Reconst_Administ.FRECVO_RECONSADM_VOIE.Copy

        Dim dt31 As New DataTable
        dt31 = DsTheriaque_Reconst_Administ.FRECCOA_FREC_COMADM.Copy

        Dim dt32 As New DataTable
        dt32 = DsTheriaque_Reconst_Administ.FRECAFS_FREC_AFSSAPS.Copy

        Dim dt33 As New DataTable
        dt33 = DsTheriaque_Reconst_Administ.FRECTXA_FREC_TXTADM.Copy


        'Vider les contrôles
        EmptyDataTable()

        'Construction de la nouvelle fiche avec les données de la fiche de base
        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        SetCode_MAx(MasterTable, txtCode)
        CodE = InvalideControl

        Dim drTemp As DataRow
        For iCount As Integer = 0 To dt1.Rows.Count - 1
            drTemp = DsTheriaque_Reconst_Administ.Tables("FRECCPH_FREC_CLPH").NewRow()
            drTemp.ItemArray = dt1.Rows(iCount).ItemArray
            DsTheriaque_Reconst_Administ.Tables("FRECCPH_FREC_CLPH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt2.Rows.Count - 1
            drTemp = DsTheriaque_Reconst_Administ.Tables("FRECCCH_FREC_CLCH").NewRow()
            drTemp.ItemArray = dt2.Rows(iCount).ItemArray
            DsTheriaque_Reconst_Administ.Tables("FRECCCH_FREC_CLCH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt3.Rows.Count - 1
            drTemp = DsTheriaque_Reconst_Administ.Tables("FRECSAC_FREC_SUBACT").NewRow()
            drTemp.ItemArray = dt3.Rows(iCount).ItemArray
            DsTheriaque_Reconst_Administ.Tables("FRECSAC_FREC_SUBACT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt4.Rows.Count - 1
            drTemp = DsTheriaque_Reconst_Administ.Tables("FRECPR_FREC_PROD").NewRow()
            drTemp.ItemArray = dt4.Rows(iCount).ItemArray
            DsTheriaque_Reconst_Administ.Tables("FRECPR_FREC_PROD").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt5.Rows.Count - 1
            drTemp = DsTheriaque_Reconst_Administ.Tables("FRECCH_RECONSTCH").NewRow()
            drTemp.ItemArray = dt5.Rows(iCount).ItemArray
            DsTheriaque_Reconst_Administ.Tables("FRECCH_RECONSTCH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt6.Rows.Count - 1
            drTemp = DsTheriaque_Reconst_Administ.Tables("FRECSP_RECONST_SPEC").NewRow()
            drTemp.ItemArray = dt6.Rows(iCount).ItemArray
            DsTheriaque_Reconst_Administ.Tables("FRECSP_RECONST_SPEC").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt21.Rows.Count - 1
            drTemp = DsTheriaque_Reconst_Administ.Tables("FRECCOR_FREC_COMRECS").NewRow()
            drTemp.ItemArray = dt21.Rows(iCount).ItemArray
            DsTheriaque_Reconst_Administ.Tables("FRECCOR_FREC_COMRECS").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt22.Rows.Count - 1
            drTemp = DsTheriaque_Reconst_Administ.Tables("FRECVO_RECONSADM_VOIE").NewRow()
            drTemp.ItemArray = dt22.Rows(iCount).ItemArray
            DsTheriaque_Reconst_Administ.Tables("FRECVO_RECONSADM_VOIE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt23.Rows.Count - 1
            drTemp = DsTheriaque_Reconst_Administ.Tables("FRECTXR_FREC_TXTRECS").NewRow()
            drTemp.ItemArray = dt23.Rows(iCount).ItemArray
            DsTheriaque_Reconst_Administ.Tables("FRECTXR_FREC_TXTRECS").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt31.Rows.Count - 1
            drTemp = DsTheriaque_Reconst_Administ.Tables("FRECCOA_FREC_COMADM").NewRow()
            drTemp.ItemArray = dt31.Rows(iCount).ItemArray
            DsTheriaque_Reconst_Administ.Tables("FRECCOA_FREC_COMADM").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt32.Rows.Count - 1
            drTemp = DsTheriaque_Reconst_Administ.Tables("FRECAFS_FREC_AFSSAPS").NewRow()
            drTemp.ItemArray = dt32.Rows(iCount).ItemArray
            DsTheriaque_Reconst_Administ.Tables("FRECAFS_FREC_AFSSAPS").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt33.Rows.Count - 1
            drTemp = DsTheriaque_Reconst_Administ.Tables("FRECTXA_FREC_TXTADM").NewRow()
            drTemp.ItemArray = dt33.Rows(iCount).ItemArray
            DsTheriaque_Reconst_Administ.Tables("FRECTXA_FREC_TXTADM").Rows.Add(drTemp)
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
            GV1.SetRowCellValue(iCount, colFRECCPH_FREC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV2
        For iCount As Integer = 0 To GV2.RowCount - 1
            GV2.SetRowCellValue(iCount, colFRECCCH_FREC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV3
        For iCount As Integer = 0 To GV3.RowCount - 1
            GV3.SetRowCellValue(iCount, colFRECSAC_FREC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV4
        For iCount As Integer = 0 To GV4.RowCount - 1
            GV4.SetRowCellValue(iCount, colFRECPR_FREC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV5
        For iCount As Integer = 0 To GV5.RowCount - 1
            GV5.SetRowCellValue(iCount, colFRECCH_FREC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV6
        For iCount As Integer = 0 To GV6.RowCount - 1
            GV6.SetRowCellValue(iCount, colFRECSP_FREC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV21
        For iCount As Integer = 0 To GV21.RowCount - 1
            GV21.SetRowCellValue(iCount, colFRECCOR_FREC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV22
        For iCount As Integer = 0 To GV22.RowCount - 1
            GV22.SetRowCellValue(iCount, colFRECVO_FREC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV23
        For iCount As Integer = 0 To GV23.RowCount - 1
            GV23.SetRowCellValue(iCount, colFRECTXR_FREC_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV31
        For iCount As Integer = 0 To GV31.RowCount - 1
            GV31.SetRowCellValue(iCount, colFRECCOA_FREC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV32
        For iCount As Integer = 0 To GV32.RowCount - 1
            GV32.SetRowCellValue(iCount, colFRECAFS_FREC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV33
        For iCount As Integer = 0 To GV33.RowCount - 1
            GV33.SetRowCellValue(iCount, colFRECTXA_FREC_CODE_FK_PK, Me.txtCode.Text)
        Next
    End Sub
    Protected Friend Overrides Function ValideControl(Optional ByRef Ctrl As Control = Nothing, Optional ByVal AllCtrl As Boolean = True) As Boolean
        Dim strSSQL As String = ""
        MyBase.ValideControl(Ctrl)
        If Not Tab_TA2 And CodE <> InvalideControl Then
            Me.FrecvO_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FRECVO_RECONSADM_VOIE, CodE)
        End If
        Dim iCount As Integer
        For iCount = 0 To GV32.RowCount - 1
            If Not FieldExistRO(GV6, colFRECSP_SP_CODE_FK_PK, GV32.GetRowCellValue(iCount, colFRECAFS_SP_CODE_FK_PK)) Then
                GV32.FocusedRowHandle = iCount
                GV32.SetColumnError(colFRECAFS_SP_CODE_FK_PK, "La spécialité doit être présente dans la fiche.")
                XtraTabControl1.SelectedTabPageIndex = 2
                Exit Function
            Else
                GV32.SetColumnError(colFRECAFS_SP_CODE_FK_PK, "")
            End If
        Next
        iCount = GV6.RowCount
        If iCount < 2 Then
            Process_Message("La spécialité est obligatoire.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            XtraTabControl1.SelectedTabPageIndex = 0
            GV6.Focus()
            Exit Function
        End If
        iCount = GV22.RowCount
        If iCount < 2 Then
            Process_Message("La voie d'administration est obligatoire.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            XtraTabControl1.SelectedTabPageIndex = 2
            GV22.Focus()
            Exit Function
        End If
        Dim sSQL As String = ""
        Dim dt As DataTable
        If GV6.GetRowCellValue(0, colFRECSP_SP_CODE_FK_PK2) IsNot Nothing And GV6.GetRowCellValue(0, colFRECSP_SP_CODE_FK_PK2) IsNot DBNull.Value Then
            sSQL &= "SELECT T.SPVO_CDF_VO_CODE_FK_PK FROM THERIAQUE.SPVO_SPECIALITE_VOIE  T "
        End If
        For iCount2 As Integer = 0 To GV6.RowCount - 1
            If GV6.GetRowCellValue(iCount2, colFRECSP_SP_CODE_FK_PK2) IsNot Nothing And GV6.GetRowCellValue(iCount2, colFRECSP_SP_CODE_FK_PK2) IsNot DBNull.Value Then
                'If iCount2 = 0 Then
                '    sSQL &= " SELECT SPVO_CDF_VO_CODE_FK_PK FROM THERIAQUE.SPVO_SPECIALITE_VOIE  WHERE SPVO_SP_CODE_FK_PK = " & cn.SQLText(GV6.GetRowCellValue(iCount2, colFRECSP_SP_CODE_FK_PK2))
                'Else
                '    sSQL &= " INTERSECT"
                '    sSQL &= " SELECT SPVO_CDF_VO_CODE_FK_PK FROM THERIAQUE.SPVO_SPECIALITE_VOIE  WHERE SPVO_SP_CODE_FK_PK = " & cn.SQLText(GV6.GetRowCellValue(iCount2, colFRECSP_SP_CODE_FK_PK2))
                'End If
                sSQL &= "JOIN "
                sSQL &= "THERIAQUE.SPVO_SPECIALITE_VOIE T" & iCount2 & " on T" & iCount2 & ".SPVO_CDF_VO_CODE_FK_PK = T.SPVO_CDF_VO_CODE_FK_PK "
            End If
        Next

        If GV6.GetRowCellValue(0, colFRECSP_SP_CODE_FK_PK2) IsNot Nothing And GV6.GetRowCellValue(0, colFRECSP_SP_CODE_FK_PK2) IsNot DBNull.Value Then
            sSQL &= "WHERE T.SPVO_SP_CODE_FK_PK = " & cn.SQLText(GV6.GetRowCellValue(0, colFRECSP_SP_CODE_FK_PK2))
        End If
        For iCount2 As Integer = 0 To GV6.RowCount - 1
            If GV6.GetRowCellValue(iCount2, colFRECSP_SP_CODE_FK_PK2) IsNot Nothing And GV6.GetRowCellValue(iCount2, colFRECSP_SP_CODE_FK_PK2) IsNot DBNull.Value Then
                sSQL &= " AND T" & iCount2 & ".SPVO_SP_CODE_FK_PK = " & cn.SQLText(GV6.GetRowCellValue(iCount2, colFRECSP_SP_CODE_FK_PK2))
            End If
        Next

        dt = cn.MySelectWithTimeOut(sSQL)

        For iCount2 As Integer = 0 To GV22.RowCount - 1
            Dim bExist As Boolean = False
            If GV22.GetRowCellValue(iCount2, colFRECVO_CDF_VO_CODE_FK_PK) IsNot Nothing And GV22.GetRowCellValue(iCount2, colFRECVO_CDF_VO_CODE_FK_PK) IsNot DBNull.Value Then
                For iCountRows As Integer = 0 To dt.Rows.Count - 1
                    If GV22.GetRowCellValue(iCount2, colFRECVO_CDF_VO_CODE_FK_PK) = dt.Rows(iCountRows)(0) Then
                        bExist = True
                    End If
                Next
                If Not bExist Then
                    Process_Message("Il faut avoir des spécialités ayant les mêmes voies d'administration.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    XtraTabControl1.SelectedTabPageIndex = 0
                    GV6.Focus()
                    Exit Function
                End If
            End If
        Next
        If dt.Rows.Count = 0 Then
            Process_Message("Il faut avoir des spécialités ayant les mêmes voies d'administration.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            XtraTabControl1.SelectedTabPageIndex = 0
            GV6.Focus()
            Exit Function
        End If
        Return True
    End Function

#End Region

#Region " Init Data  "

    Private Sub InitDataSource()
        'Onglet Entités
        GC1.DataSource = DsTheriaque_Reconst_Administ
        GC1.DataMember = FRECCPH_FREC_CLPH

        GC2.DataSource = DsTheriaque_Reconst_Administ
        GC2.DataMember = FRECCCH_FREC_CLCH

        GC3.DataSource = DsTheriaque_Reconst_Administ
        GC3.DataMember = FRECSAC_FREC_SUBACT

        GC4.DataSource = DsTheriaque_Reconst_Administ
        GC4.DataMember = FRECPR_FREC_PROD

        GC5.DataSource = DsTheriaque_Reconst_Administ
        GC5.DataMember = FRECCH_RECONSTCH

        GC6.DataSource = DsTheriaque_Reconst_Administ
        GC6.DataMember = FRECSP_RECONST_SPEC

        ' Mode de Reconstitution / Administration
        GC21.DataSource = DsTheriaque_Reconst_Administ
        GC21.DataMember = FRECCOR_FREC_COMRECS

        GC22.DataSource = DsTheriaque_Reconst_Administ
        GC22.DataMember = FRECVO_RECONSADM_VOIE

        GC23.DataSource = DsTheriaque_Reconst_Administ
        GC23.DataMember = FRECTXR_FREC_TXTRECS

        ' Références officielles / Commentaires
        GC31.DataSource = DsTheriaque_Reconst_Administ
        GC31.DataMember = FRECCOA_FREC_COMADM

        GC32.DataSource = DsTheriaque_Reconst_Administ
        GC32.DataMember = FRECAFS_FREC_AFSSAPS

        GC33.DataSource = DsTheriaque_Reconst_Administ
        GC33.DataMember = FRECTXA_FREC_TXTADM

    End Sub
    Public Overrides Sub InitData()
        MyBase.InitData()
        Declinaison_Global = True
        OnLoading = True
        MasterDataSet = Me.DsTheriaque_Reconst_Administ
        MasterTable = FREC_RECONSADM
        CodE = InvalideControl

        'Déclinaison classe CPH
        Dim List1 As New System.Collections.Generic.List(Of StructGVTable)
        List1.Add(New StructGVTable("GC1", eDeclinaison.CPH, colFRECCPH_CPH_CODE_FK_PK2))
        List1.Add(New StructGVTable("GC2", eDeclinaison.CCH, colFRECCCH_CCH_CODE_FK_PK2))
        List1.Add(New StructGVTable("GC3", eDeclinaison.SAC, colFRECSAC_SAC_CODE_FK_PK2))
        List1.Add(New StructGVTable("GC6", eDeclinaison.SP, colFRECSP_SP_CODE_FK_PK2))
        Dim DecCPH As New ClsDeclinaison(eDeclinaison.CPH, List1)
        InitLkup(Me.lkup_FRECCPH, FRECCPH_FREC_CLPH, strSSQL_CPH_CLASSEPHARMTHER_NIVEAU, True, , , , , , DecCPH)

        'Déclinaison classe CCH
        Dim List2 As New System.Collections.Generic.List(Of StructGVTable)
        List2.Add(New StructGVTable("GC1", eDeclinaison.CPH, colFRECCPH_CPH_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC2", eDeclinaison.CCH, colFRECCCH_CCH_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC3", eDeclinaison.SAC, colFRECSAC_SAC_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC6", eDeclinaison.SP, colFRECSP_SP_CODE_FK_PK2))
        Dim DecCCH As New ClsDeclinaison(eDeclinaison.CCH, List2)
        InitLkup(Me.lkup_FRECCCH, FRECCCH_FREC_CLCH, strSSQL_CCH_CLASSECHIMIQUE_NIVEAU, True, , , , , , DecCCH)

        'Déclinaison SUBAC
        Dim List3 As New System.Collections.Generic.List(Of StructGVTable)
        List3.Add(New StructGVTable("GC3", eDeclinaison.SAC, colFRECSAC_SAC_CODE_FK_PK2))
        List3.Add(New StructGVTable("GC6", eDeclinaison.SP, colFRECSP_SP_CODE_FK_PK2))
        Dim DecSUBAC As New ClsDeclinaison(eDeclinaison.SAC, List3)
        InitLkup(Me.lkup_FRECSAC, FRECSAC_FREC_SUBACT, strSSQL_SAC_SUBACTIVE, True, , , , , , DecSUBAC)

        'Déclinaison PRODUIT
        Dim List5 As New System.Collections.Generic.List(Of StructGVTable)
        List5.Add(New StructGVTable("GC4", eDeclinaison.PR, colFRECPR_PR_CODE_FK_PK2))
        List5.Add(New StructGVTable("GC6", eDeclinaison.SP, colFRECSP_SP_CODE_FK_PK2))
        Dim DecPR As New ClsDeclinaison(eDeclinaison.PR, List5)
        InitLkup(Me.lkup_FRECPR, FRECPR_FREC_PROD, strSSQL_PR_PRODUIT, True, , , , , , DecPR)


        InitLkup(Me.lkup_FRECCH, FRECCH_RECONSTCH, strSSQL_CH_CHOIX, True)
        InitLkup(Me.lkup_FRECSP, FRECSP_RECONST_SPEC, strSSQL_SP_SPECIALITE, True)
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
        Me.FreC_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FREC_RECONSADM, CodE1)
        'Onglet Entités
        Me.FreccpH_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FRECCPH_FREC_CLPH, CodE1)
        Me.FrecccH_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FRECCCH_FREC_CLCH, CodE1)
        Me.FrecsaC_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FRECSAC_FREC_SUBACT, CodE1)
        Me.FrecpR_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FRECPR_FREC_PROD, CodE1)
        Me.FreccH_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FRECCH_RECONSTCH, CodE1)
        Me.FrecsP_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FRECSP_RECONST_SPEC, CodE1)

        Tab_TA1 = False
        Tab_TA2 = False

        OnLoading = False
    End Sub

#End Region

#Region " Chargement par onglet "

    Private Sub LoadTab_1()
        Load_On(Me)
        OnLoading = True
        If Not Tab_lkup1 Then
            InitLkup(Me.lkup_FRECCOR, FRECCOR_FREC_COMRECS, strSSQL_CDF_CODIF("RC", " and Substring(CDF_CODE_PK, 1, 1) IN('A','B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'R', 'X')"), True)
            Tab_lkup1 = True
        End If
        If Not Tab_TA1 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.FreccoR_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FRECCOR_FREC_COMRECS, CodE)
            Me.FrectxR_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FRECTXR_FREC_TXTRECS, CodE)
            Tab_TA1 = True
        End If
        '-------------------------------------------------------
        '-------------------------------------------------------
        OnLoading = False
        Load_Off(Me)
    End Sub
    Private Sub LoadTab_2()
        Load_On(Me)
        OnLoading = True
        If CodE <> InvalideControl And CodE <> Nothing Then
            Dim strSSQL_SP_REF As String
            strSSQL_SP_REF = " SELECT SP_CODE_SQ_PK as code, SP_NOM as libelle FROM THERIAQUE.FRECSP_RECONST_SPEC, THERIAQUE.SP_SPECIALITE"
            strSSQL_SP_REF &= " WHERE FRECSP_FREC_CODE_FK_PK = " & CodE
            strSSQL_SP_REF &= " AND SP_CODE_SQ_PK = FRECSP_SP_CODE_FK_PK"
            InitLkup(Me.lkup_FRECAFS_SP, FRECAFS_FREC_AFSSAPS, strSSQL_SP_REF, True)
            For iCount As Integer = 0 To GV32.RowCount
                If GV32.GetRowCellDisplayText(iCount, "FRECAFS_SP_CODE_FK_PK") = "" And GV32.GetRowCellDisplayText(iCount, "FRECAFS_FREC_CODE_FK_PK") <> "" Then
                    GV32.DeleteRow(iCount)
                    iCount = iCount - 1
                End If
            Next
        End If
        If Not Tab_lkup2 Then
            InitLkup(Me.lkup_FRECCOA, FRECCOA_FREC_COMADM, strSSQL_CDF_CODIF("RC", " and substring(CDF_CODE_PK, 1, 1) IN('L','M', 'N', 'O', 'P', 'Q', 'S', 'T', 'U', 'V', 'W', 'X', 'Y')"), True)
            InitLkup(Me.lkup_FRECAFS, FRECAFS_FREC_AFSSAPS, strSSQL_CDF_CODIF("25"), True)
            Tab_lkup2 = True
        End If
        If Not Tab_TA2 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.FrecvO_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FRECVO_RECONSADM_VOIE, CodE)
            Me.FreccoA_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FRECCOA_FREC_COMADM, CodE)
            Me.FrectxA_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FRECTXA_FREC_TXTADM, CodE)
            Me.FrecafS_TA.FillByCode(Me.DsTheriaque_Reconst_Administ.FRECAFS_FREC_AFSSAPS, CodE)
            Tab_TA2 = True
        End If
        '-------------------------------------------------------
        '-------------------------------------------------------
        'Mise à jour du lookup selon la liste des SP
        If Me.lkup_FRECVO.Name <> "" Then
            Dim str_SSQL_Temp As String = ""
            Dim strList As String = ""
            Dim col As New Collection
            col = GetCodeFromGV(GV6, colFRECSP_SP_CODE_FK_PK2)
            strList = GetCodeFromCollection(col)
            str_SSQL_Temp &= " and CDF_CODE_PK  <> '62'"
            If strList <> "" Then
                str_SSQL_Temp &= " and CDF_CODE_PK in"
                str_SSQL_Temp &= " ("
                str_SSQL_Temp &= " SELECT SPVO_CDF_VO_CODE_FK_PK FROM THERIAQUE.SPVO_SPECIALITE_VOIE "
                str_SSQL_Temp &= " WHERE SPVO_SP_CODE_FK_PK in " & strList
                str_SSQL_Temp &= " GROUP BY SPVO_CDF_VO_CODE_FK_PK )"
                'str_SSQL_Temp &= " HAVING COUNT(SPVO_CDF_VO_CODE_FK_PK)  = " & col.Count & ")"
                InitLkup(Me.lkup_FRECVO, FRECVO_RECONSADM_VOIE, strSSQL_CDF_CODIF("18", str_SSQL_Temp), True)
            End If
            For iCount As Integer = 0 To GV22.RowCount
                If GV22.GetRowCellDisplayText(iCount, "FRECVO_CDF_VO_CODE_FK_PK") = "" And GV22.GetRowCellDisplayText(iCount, "FRECVO_FREC_CODE_FK_PK") <> "" Then
                    GV22.DeleteRow(iCount)
                    iCount = iCount - 1
                End If
            Next
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

#End Region

#Region " New Row "

    Private Sub GV1_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV1.InitNewRow
        If OnLoading Then Exit Sub
        GV1.SetFocusedRowCellValue(colFRECCPH_FREC_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        If OnLoading Then Exit Sub
        GV2.SetFocusedRowCellValue(colFRECCCH_FREC_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV3_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV3.InitNewRow
        If OnLoading Then Exit Sub
        GV3.SetFocusedRowCellValue(colFRECSAC_FREC_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV4_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV4.InitNewRow
        If OnLoading Then Exit Sub
        GV4.SetFocusedRowCellValue(colFRECPR_FREC_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV5_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV5.InitNewRow
        If OnLoading Then Exit Sub
        GV5.SetFocusedRowCellValue(colFRECCH_FREC_CODE_FK_PK, txtCode.Text)
        GV5.SetFocusedRowCellValue(colFRECCH_NUMORD, Code_MAx(GV5, colFRECCH_NUMORD))
    End Sub
    Private Sub GV6_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV6.InitNewRow
        If OnLoading Then Exit Sub
        GV6.SetFocusedRowCellValue(colFRECSP_FREC_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV21_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV21.InitNewRow
        GV21.SetFocusedRowCellValue(colFRECCOR_FREC_CODE_FK_PK, txtCode.Text)
        GV21.SetFocusedRowCellValue(colFRECCOR_NUM_ORD_PK, Code_MAx(GV21, colFRECCOR_NUM_ORD_PK))
    End Sub
    Private Sub GV22_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV22.InitNewRow
        GV22.SetFocusedRowCellValue(colFRECVO_FREC_CODE_FK_PK, txtCode.Text)
        GV22.SetFocusedRowCellValue(colFRECVO_NUMORD, Code_MAx(GV22, colFRECVO_NUMORD))
    End Sub
    Private Sub GV31_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV31.InitNewRow
        GV31.SetFocusedRowCellValue(colFRECCOA_FREC_CODE_FK_PK, txtCode.Text)
        GV31.SetFocusedRowCellValue(colFRECCOA_NUM_ORD_PK, Code_MAx(GV31, colFRECCOA_NUM_ORD_PK))
    End Sub
    Private Sub GV32_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV32.InitNewRow
        GV32.SetFocusedRowCellValue(colFRECAFS_FREC_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV23_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV23.InitNewRow
        Me.GV23.SetFocusedRowCellValue(Me.colFRECTXR_FREC_CODE_FK_PK, txtCode.Text)
        'If GV23.RowCount >= 0 Then
        '    GV23.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
        'End If
    End Sub
    Private Sub GV33_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV33.InitNewRow
        Me.GV33.SetFocusedRowCellValue(Me.colFRECTXA_FREC_CODE_FK_PK, txtCode.Text)
        'If GV33.RowCount >= 0 Then
        '    GV33.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
        'End If
    End Sub

#End Region

#Region " Panel Resize "

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

        Panel2.Height = XtraTabControl1.Height / 2
        Panel11.Height = XtraTabControl1.Height / 2

        Panel5.Height = XtraTabControl1.Height / 4
        Panel8.Height = XtraTabControl1.Height / 4
        Panel9.Height = XtraTabControl1.Height / 4
        Panel3.Height = XtraTabControl1.Height / 4

    End Sub

#End Region

    Private Sub GV_RowCountChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV23.RowCountChanged, GV33.RowCountChanged
        If sender.RowCount >= 1 Then
            sender.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
            sender.GridControl.EmbeddedNavigator.Buttons.Append.Enabled = False
        Else
            sender.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            sender.GridControl.EmbeddedNavigator.Buttons.Append.Enabled = False
        End If
    End Sub


    Private Sub GV_CalcRowHeight(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs) Handles GV23.CalcRowHeight, GV33.CalcRowHeight
        e.RowHeight = sender.GridControl.Height
    End Sub
End Class
