''' <summary>
''' Created By [BFE]
''' </summary>
''' <remarks> Critéres de choix - Fiche d'information thérapeutique 
''' </remarks>
Public Class Frm_Fiche_Infotherapeutique

#Region "Déclaration des variables privées"
    Private CodE As String
    Public _Code As Integer = Nothing ' charger la fiche depuis l'extérieur
#End Region

#Region " Edit Data "

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_FTH_FICHEINFOTHERAPEUTIQUE
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            OnLoading = True
            EmptyDataTable()
            Me.FtH_TA.FillByCode(Me.DsTheriaque_CriteresChoix.FTH_FICHEINFOTHERAPEUTIQUE, f._Code)
            Me.SPFTH_TA.FillByCode(Me.DsTheriaque_CriteresChoix.SPFTH_SPEC_INFOTHERAPEUTIQUE, f._Code)
            Me.FTHCPH.FillByCode(Me.DsTheriaque_CriteresChoix.FTHCPH_FIT_CLASSEPHARMTHER, f._Code)
            Me.FTHCCH.FillByCode(Me.DsTheriaque_CriteresChoix.FTHCCH_FIT_CLASSECHIMIQUE, f._Code)
            Me.FTHSAC.FillByCode(Me.DsTheriaque_CriteresChoix.FTHSAC_FIT_SUBACTIVE, f._Code)
            Me.FTHSAU.FillByCode(Me.DsTheriaque_CriteresChoix.FTHSAU_FIT_SUBAUXILIAIRE, f._Code)
            Me.FTHPR.FillByCode(Me.DsTheriaque_CriteresChoix.FTHPR_FIT_PRODUIT, f._Code)
            Me.FTHCATC.FillByCode(Me.DsTheriaque_CriteresChoix.FTHCATC_FIT_CLASSEATC, f._Code)
            OnLoading = False
            Return True
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
    End Sub

    Public Overrides Function supprimer() As Boolean
        MyBase.Supprimer()

        Dim iCount As Integer
        For iCount = 0 To DsTheriaque_CriteresChoix.SPFTH_SPEC_INFOTHERAPEUTIQUE.Rows.Count - 1
            DsTheriaque_CriteresChoix.SPATR_SPEC_AVISTRANSPARENCE.Rows(iCount).Delete()
        Next
        Me.SPFTH_TA.Update(DsTheriaque_CriteresChoix)

        For iCount = 0 To DsTheriaque_CriteresChoix.FTHCPH_FIT_CLASSEPHARMTHER.Rows.Count - 1
            DsTheriaque_CriteresChoix.FTHCPH_FIT_CLASSEPHARMTHER.Rows(iCount).Delete()
        Next
        Me.FTHCPH.Update(DsTheriaque_CriteresChoix)

        For iCount = 0 To DsTheriaque_CriteresChoix.FTHCCH_FIT_CLASSECHIMIQUE.Rows.Count - 1
            DsTheriaque_CriteresChoix.FTHCCH_FIT_CLASSECHIMIQUE.Rows(iCount).Delete()
        Next
        Me.FTHCCH.Update(DsTheriaque_CriteresChoix)

        For iCount = 0 To DsTheriaque_CriteresChoix.FTHSAC_FIT_SUBACTIVE.Rows.Count - 1
            DsTheriaque_CriteresChoix.FTHSAC_FIT_SUBACTIVE.Rows(iCount).Delete()
        Next
        Me.FTHSAC.Update(DsTheriaque_CriteresChoix)

        For iCount = 0 To DsTheriaque_CriteresChoix.FTHSAU_FIT_SUBAUXILIAIRE.Rows.Count - 1
            DsTheriaque_CriteresChoix.FTHSAU_FIT_SUBAUXILIAIRE.Rows(iCount).Delete()
        Next
        Me.FTHSAU.Update(DsTheriaque_CriteresChoix)

        For iCount = 0 To DsTheriaque_CriteresChoix.FTHCATC_FIT_CLASSEATC.Rows.Count - 1
            DsTheriaque_CriteresChoix.FTHCATC_FIT_CLASSEATC.Rows(iCount).Delete()
        Next
        Me.FTHCATC.Update(DsTheriaque_CriteresChoix)

        ' Master
        DsTheriaque_CriteresChoix.FTH_FICHEINFOTHERAPEUTIQUE.Rows(0).Delete()
        Me.FtH_TA.Update(Me.MasterDataSet)
        Return True
    End Function

    Public Overrides Sub valider()

        MyBase.Valider()
        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        FtH_TA.Update(Me.DsTheriaque_CriteresChoix.FTH_FICHEINFOTHERAPEUTIQUE)

        Me.BindingContext(Me.MasterDataSet, SPFTH_SPEC_INFOTHERAPEUTIQUE).EndCurrentEdit()
        SPFTH_TA.Update(Me.DsTheriaque_CriteresChoix.SPFTH_SPEC_INFOTHERAPEUTIQUE)

        Me.BindingContext(Me.MasterDataSet, FTHCPH_FIT_CLASSEPHARMTHER).EndCurrentEdit()
        FTHCPH.Update(Me.DsTheriaque_CriteresChoix.FTHCPH_FIT_CLASSEPHARMTHER)

        Me.BindingContext(Me.MasterDataSet, FTHCCH_FIT_CLASSECHIMIQUE).EndCurrentEdit()
        FTHCCH.Update(Me.DsTheriaque_CriteresChoix.FTHCCH_FIT_CLASSECHIMIQUE)

        Me.BindingContext(Me.MasterDataSet, FTHSAC_FIT_SUBACTIVE).EndCurrentEdit()
        FTHSAC.Update(Me.DsTheriaque_CriteresChoix.FTHSAC_FIT_SUBACTIVE)

        Me.BindingContext(Me.MasterDataSet, FTHSAU_FIT_SUBAUXILIAIRE).EndCurrentEdit()
        FTHSAU.Update(Me.DsTheriaque_CriteresChoix.FTHSAU_FIT_SUBAUXILIAIRE)

        Me.BindingContext(Me.MasterDataSet, FTHPR_FIT_PRODUIT).EndCurrentEdit()
        FTHPR.Update(Me.DsTheriaque_CriteresChoix.FTHPR_FIT_PRODUIT)

        Me.BindingContext(Me.MasterDataSet, FTHCATC_FIT_CLASSEATC).EndCurrentEdit()
        FTHCATC.Update(Me.DsTheriaque_CriteresChoix.FTHCATC_FIT_CLASSEATC)

    End Sub

    Public Overrides Sub annuler()
        OnLoading = True
        MyBase.Annuler()

        'Master
        Me.BindingContext(Me.MasterDataSet, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_CriteresChoix.FTH_FICHEINFOTHERAPEUTIQUE.RejectChanges()

        OnLoading = False
    End Sub

    Private Sub EmptyDataTable()
        'Master
        Me.DsTheriaque_CriteresChoix.FTH_FICHEINFOTHERAPEUTIQUE.Clear()
    End Sub

#End Region

#Region " Init Data  "

    Public Overrides Sub InitData()
        MyBase.InitData()
        OnLoading = True
        Declinaison_Global = True
        MasterDataSet = Me.DsTheriaque_CriteresChoix
        MasterTable = FTH_FICHEINFOTHERAPEUTIQUE
        CodE = InvalideControl

        InitDeclinaison()

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
        'Déclinaison
        Dim List1 As New System.Collections.Generic.List(Of StructGVTable)
        List1.Add(New StructGVTable("GC15", eDeclinaison.SP, colSPFTH_SP_CODE_FK_PK))
        Dim DecSP As New ClsDeclinaison(eDeclinaison.SP, List1)

        InitLkup(Me.lkup_SPFTH, SPFTH_SPEC_INFOTHERAPEUTIQUE, strSSQL_SP_SPECIALITE, True, , , , , , DecSP)
        

        InitDataSource()

    End Sub


    Private Sub InitDataSource()

        GC15.DataSource = DsTheriaque_CriteresChoix
        GC15.DataMember = SPFTH_SPEC_INFOTHERAPEUTIQUE

        GC_DCL1.DataSource = DsTheriaque_CriteresChoix
        GC_DCL1.DataMember = FTHCPH_FIT_CLASSEPHARMTHER

        GC_DCL2.DataSource = DsTheriaque_CriteresChoix
        GC_DCL2.DataMember = FTHCCH_FIT_CLASSECHIMIQUE

        GC_DCL4.DataSource = DsTheriaque_CriteresChoix
        GC_DCL4.DataMember = FTHSAC_FIT_SUBACTIVE

        GC_DCL5.DataSource = DsTheriaque_CriteresChoix
        GC_DCL5.DataMember = FTHSAU_FIT_SUBAUXILIAIRE

        GC_DCL6.DataSource = DsTheriaque_CriteresChoix
        GC_DCL6.DataMember = FTHPR_FIT_PRODUIT

        GC_DCL8.DataSource = DsTheriaque_CriteresChoix
        GC_DCL8.DataMember = FTHCATC_FIT_CLASSEATC


    End Sub

    Private Sub InitDeclinaison()

        Dim List5 As New System.Collections.Generic.List(Of StructGVTable)
        List5.Add(New StructGVTable("GC_DCL1", eDeclinaison.CPH, colFTHCPH_CPH_CODE_PK_FK2))
        List5.Add(New StructGVTable("GC_DCL2", eDeclinaison.CCH, colFTHCCH_CCH_CODE_PK_FK2))
        List5.Add(New StructGVTable("GC_DCL4", eDeclinaison.SAC, colFTHSAC_SAC_CODE_SQ_PK_FK2))
        List5.Add(New StructGVTable("GC15", eDeclinaison.SP, colSPFTH_SP_CODE_FK_PK2))
        Dim dec5 As New ClsDeclinaison(eDeclinaison.CPH, List5)
        InitLkup(Me.lkup_FTHCPH, CPH_CLASSEPHARMTHER, strSSQL_CPH_CLASSEPHARMTHER, True, , , , , , dec5)

        Dim List6 As New System.Collections.Generic.List(Of StructGVTable)
        List6.Add(New StructGVTable("GC_DCL1", eDeclinaison.CPH, colFTHCPH_CPH_CODE_PK_FK2))
        List6.Add(New StructGVTable("GC_DCL2", eDeclinaison.CCH, colFTHCCH_CCH_CODE_PK_FK2))
        List6.Add(New StructGVTable("GC_DCL4", eDeclinaison.SAC, colFTHSAC_SAC_CODE_SQ_PK_FK2))
        List6.Add(New StructGVTable("GC_DCL5", eDeclinaison.SAU, colFTHSAU_SAU_CODE_SQ_PK_FK2))
        List6.Add(New StructGVTable("GC15", eDeclinaison.SP, colSPFTH_SP_CODE_FK_PK2))
        Dim dec6 As New ClsDeclinaison(eDeclinaison.CCH, List6)
        InitLkup(Me.lkup_FTHCCH, CCH_CLASSECHIMIQUE, strSSQL_CCH_CLASSECHIMIQUE, True, , , , , , dec6)
        Dim List As New System.Collections.Generic.List(Of StructGVTable)
        List.Add(New StructGVTable("GC_DCL4", eDeclinaison.SAC, colFTHSAC_SAC_CODE_SQ_PK_FK2))
        List.Add(New StructGVTable("GC15", eDeclinaison.SP, colSPFTH_SP_CODE_FK_PK2))
        Dim dec As New ClsDeclinaison(eDeclinaison.SAC, List)
        InitLkup(Me.lkup_FTHSAC, IT1SAC_TERME1SUBACTIVE, strSSQL_SAC_SUBACTIVE, True, , , , , , dec)

        Dim List3 As New System.Collections.Generic.List(Of StructGVTable)
        List3.Add(New StructGVTable("GC_DCL5", eDeclinaison.SAU, colFTHSAU_SAU_CODE_SQ_PK_FK2))
        List3.Add(New StructGVTable("GC15", eDeclinaison.SP, colSPFTH_SP_CODE_FK_PK2))
        Dim dec3 As New ClsDeclinaison(eDeclinaison.SAU, List3)
        InitLkup(Me.lkup_FTHSAU, IT1SAU_TERME1SUBAUX, strSSQL_SAU_SUBAUXILIAIRE, True, , , , , , dec3)

        Dim List11 As New System.Collections.Generic.List(Of StructGVTable)
        List11.Add(New StructGVTable("GC_DCL6", eDeclinaison.PR, colFTHPR_PR_CODE_SQ_PK_FK2))
        List11.Add(New StructGVTable("GC15", eDeclinaison.SP, colSPFTH_SP_CODE_FK_PK2))
        Dim dec11 As New ClsDeclinaison(eDeclinaison.PR, List11)
        InitLkup(Me.lkup_FTHPR, PR_PRODUIT, strSSQL_PR_PRODUIT, True, , , , , , dec11)

        'Dim List12 As New System.Collections.Generic.List(Of StructGVTable)
        'List12.Add(New StructGVTable("GC_DCL8", eDeclinaison.ATC, colCATC_CODE_PK2_DCL))
        'List12.Add(New StructGVTable("GC15", eDeclinaison.SP, colSPFTH_SP_CODE_FK_PK2))
        'Dim dec12 As New ClsDeclinaison(eDeclinaison.ATC, List12)
        'InitLkup(Me.lkup_ATC_DCL, CATC_CLASSEATC, strSSQL_CATC_CLASSEATC, True, , , , , , dec12)

        Dim List12 As New System.Collections.Generic.List(Of StructGVTable)
        List12.Add(New StructGVTable("GC_DCL8", eDeclinaison.ATC, colFTHCATC_CATC_CODE_PK_FK2))
        List12.Add(New StructGVTable("GC15", eDeclinaison.SP, colSPFTH_SP_CODE_FK_PK2))
        Dim dec12 As New ClsDeclinaison(eDeclinaison.ATC, List12)
        InitLkup(Me.lkup_FTHCATC, CATC_CLASSEATC, strSSQL_CATC_CLASSEATC, True, , , , , , dec12)

        'InitLkup(lkup_CATC, CATC_CLASSEATC, strSSQL_CATC_CLASSEATC, True, False, True, True)

        InitLkup(lkup_SPFTH, IT1SP_TERME1SPECIALITE, strSSQL_SP_SPECIALITE, True)


    End Sub


#End Region
    Private Sub Open_Fiche(ByVal CodE1 As Integer)
        OnLoading = True
        CodE = _Code
        EmptyDataTable()
        Me.FtH_TA.FillByCode(Me.DsTheriaque_CriteresChoix.FTH_FICHEINFOTHERAPEUTIQUE, CodE1)
        Me.SPFTH_TA.FillByCode(Me.DsTheriaque_CriteresChoix.SPFTH_SPEC_INFOTHERAPEUTIQUE, CodE1)
        Me.FTHCPH.FillByCode(Me.DsTheriaque_CriteresChoix.FTHCPH_FIT_CLASSEPHARMTHER, CodE1)
        Me.FTHCCH.FillByCode(Me.DsTheriaque_CriteresChoix.FTHCCH_FIT_CLASSECHIMIQUE, CodE1)
        Me.FTHSAC.FillByCode(Me.DsTheriaque_CriteresChoix.FTHSAC_FIT_SUBACTIVE, CodE1)
        Me.FTHSAU.FillByCode(Me.DsTheriaque_CriteresChoix.FTHSAU_FIT_SUBAUXILIAIRE, CodE1)
        Me.FTHPR.FillByCode(Me.DsTheriaque_CriteresChoix.FTHPR_FIT_PRODUIT, CodE1)
        Me.FTHCATC.FillByCode(Me.DsTheriaque_CriteresChoix.FTHCATC_FIT_CLASSEATC, CodE1)
        OnLoading = False
    End Sub

    Private Sub GV15_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV15.InitNewRow
        If OnLoading Then Exit Sub
        GV15.SetFocusedRowCellValue(colSPFTH_FTH_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub MemoEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemoEdit1.EditValueChanged

    End Sub

    Private Sub GV_DCL1_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV_DCL1.InitNewRow

        If OnLoading Then Exit Sub
        GV_DCL1.SetFocusedRowCellValue(colFTHCPH_FTH_CODE_SQ_PK_FK, txtCode.Text)

    End Sub

    Private Sub GV_DCL2_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV_DCL2.InitNewRow

        If OnLoading Then Exit Sub
        GV_DCL2.SetFocusedRowCellValue(colFTHCCH_FTH_CODE_SQ_PK_FK, txtCode.Text)

    End Sub


    Private Sub GV_DCL4_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV_DCL4.InitNewRow

        If OnLoading Then Exit Sub
        GV_DCL4.SetFocusedRowCellValue(colFTHSAC_FTH_CODE_SQ_PK_FK, txtCode.Text)

    End Sub

    Private Sub GV_DCL5_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV_DCL5.InitNewRow

        GV_DCL5.SetFocusedRowCellValue(colFTHSAU_FTH_CODE_SQ_PK_FK, txtCode.Text)

    End Sub

    Private Sub GV_DCL6_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV_DCL6.InitNewRow

        GV_DCL6.SetFocusedRowCellValue(colFTHPR_FTH_CODE_SQ_PK_FK, txtCode.Text)

    End Sub

    Private Sub GV_DCL8_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV_DCL8.InitNewRow

        GV_DCL8.SetFocusedRowCellValue(colFTHCATC_FTH_CODE_SQ_PK_FK, txtCode.Text)
       

    End Sub

    Private Sub GC_DCL8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GC_DCL8.Click

    End Sub
End Class
