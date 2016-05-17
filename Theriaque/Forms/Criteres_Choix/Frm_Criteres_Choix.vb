Imports System.io

''' <summary>
''' Created By [BFE]
''' </summary>
''' <remarks> Critères de choix - Critères de choix 
''' </remarks>
''' 

Public Class Frm_Criteres_Choix

#Region "Déclaration des variables privées"
    Private CodE As String
    Public _Code As Integer = Nothing ' charger la fiche depuis l'extérieur
    Dim doc As DocumentService.DocumentProvider
#End Region

#Region " Edit Data "

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_CH_CHOIX
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            OnLoading = True
            EmptyDataTable()
            Me.CH_TA.FillByCode(Me.DsTheriaque_CriteresChoix.CH_CHOIX, f._Code)
            Me.ChtiT_TA.FillByCode(Me.DsTheriaque_CriteresChoix.CHTIT_CH_TITRE2, f._Code)
            Me.SPCH_TA.FillByCode(Me.DsTheriaque_CriteresChoix.SPCH_SPECIALITE_CHOIX, f._Code) '.FillByCode(Me.DsTheriaque_CriteresChoix.SPCH_SPECIALITE_CHOIX, f._Code)
            Me.CHSAC.FillByCode(Me.DsTheriaque_CriteresChoix.CHSAC_CHOIX_SUBACTIVE, f._Code)
            Me.CHCPH.FillByCode(Me.DsTheriaque_CriteresChoix.CHCPH_CHOIX_CLASSEPHARMTHER, f._Code)
            Me.CHCCH.FillByCode(Me.DsTheriaque_CriteresChoix.CHCCH_CHOIX_CLASSECHIMIQUE, f._Code)
            Me.CHSAU.FillByCode(Me.DsTheriaque_CriteresChoix.CHSAU_CHOIX_SUBAUXILIAIRE, f._Code)
            Me.CHPR.FillByCode(Me.DsTheriaque_CriteresChoix.CHPR_CHOIX_PRODUIT, f._Code)
            Me.CHCATC.FillByCode(Me.DsTheriaque_CriteresChoix.CHCATC_CHOIX_CLASSEATC, f._Code)


            Dim aDoc As New ArrayList
            doc = New DocumentService.DocumentProvider(cn.sConnexion)
            doc.cn = New SqlClient.SqlConnection(cn.sConnexion)
            aDoc = doc.GetDocsByTypeDoc(CodE, DocumentService.DocumentProvider.TypeDoc.CritChoix)
            If aDoc.Count > 0 Then
                doc = aDoc(0)
                'Affichage des propriétés.
                Me.txtLibelle.Text = doc.DO_Label
                Me.meNote.Text = doc.DO_Note
                Me.lueCategorie.EditValue = CType(doc.ID_Categorie, Short)
            Else
                Me.txtLibelle.Text = ""
                Me.meNote.Text = ""
                Me.lueCategorie.EditValue = Nothing
            End If

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
        Me.SPCH_TA.FillByCode(Me.DsTheriaque_CriteresChoix.SPCH_SPECIALITE_CHOIX, -1)
        txtLibelle.Text = ""
        bePath.Text = ""
        meNote.Text = ""
        doc = New DocumentService.DocumentProvider(cn.sConnexion)
        MyBase.Ajouter()

    End Sub

    Public Overrides Function supprimer() As Boolean
        MyBase.Supprimer()

        Dim iCount As Integer

        For iCount = 0 To DsTheriaque_CriteresChoix.CHTIT_CH_TITRE2.Rows.Count - 1
            DsTheriaque_CriteresChoix.CHTIT_CH_TITRE2.Rows(iCount).Delete()
        Next
        Me.ChtiT_TA.Update(DsTheriaque_CriteresChoix)



        For iCount = 0 To DsTheriaque_CriteresChoix.SPCH_SPECIALITE_CHOIX.Rows.Count - 1
            DsTheriaque_CriteresChoix.SPCH_SPECIALITE_CHOIX.Rows(iCount).Delete()
        Next
        Me.SPCH_TA.Update(DsTheriaque_CriteresChoix)

        For iCount = 0 To DsTheriaque_CriteresChoix.CHSAC_CHOIX_SUBACTIVE.Rows.Count - 1
            DsTheriaque_CriteresChoix.CHSAC_CHOIX_SUBACTIVE.Rows(iCount).Delete()
        Next
        Me.CHSAC.Update(DsTheriaque_CriteresChoix)

        For iCount = 0 To DsTheriaque_CriteresChoix.CHCPH_CHOIX_CLASSEPHARMTHER.Rows.Count - 1
            DsTheriaque_CriteresChoix.CHCPH_CHOIX_CLASSEPHARMTHER.Rows(iCount).Delete()
        Next
        Me.CHCPH.Update(DsTheriaque_CriteresChoix)

        For iCount = 0 To DsTheriaque_CriteresChoix.CHCCH_CHOIX_CLASSECHIMIQUE.Rows.Count - 1
            DsTheriaque_CriteresChoix.CHCCH_CHOIX_CLASSECHIMIQUE.Rows(iCount).Delete()
        Next
        Me.CHCCH.Update(DsTheriaque_CriteresChoix)

        For iCount = 0 To DsTheriaque_CriteresChoix.CHSAU_CHOIX_SUBAUXILIAIRE.Rows.Count - 1
            DsTheriaque_CriteresChoix.CHSAU_CHOIX_SUBAUXILIAIRE.Rows(iCount).Delete()
        Next
        Me.CHSAU.Update(DsTheriaque_CriteresChoix)

        For iCount = 0 To DsTheriaque_CriteresChoix.CHPR_CHOIX_PRODUIT.Rows.Count - 1
            DsTheriaque_CriteresChoix.CHPR_CHOIX_PRODUIT.Rows(iCount).Delete()
        Next
        Me.CHPR.Update(DsTheriaque_CriteresChoix)

        For iCount = 0 To DsTheriaque_CriteresChoix.CHCATC_CHOIX_CLASSEATC.Rows.Count - 1
            DsTheriaque_CriteresChoix.CHCATC_CHOIX_CLASSEATC.Rows(iCount).Delete()
        Next
        Me.CHCATC.Update(DsTheriaque_CriteresChoix)

        ' Master
        DsTheriaque_CriteresChoix.CH_CHOIX.Rows(0).Delete()
        Me.CH_TA.Update(Me.MasterDataSet)

        Return True
    End Function

    Public Overrides Sub valider()
        MyBase.Valider()
        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        CH_TA.Update(Me.DsTheriaque_CriteresChoix.CH_CHOIX)

        Me.BindingContext(Me.MasterDataSet, CHTIT_CH_TITRE2).EndCurrentEdit()
        ChtiT_TA.Update(Me.DsTheriaque_CriteresChoix.CHTIT_CH_TITRE2)

        Me.BindingContext(Me.MasterDataSet, SPCH_SPECIALITE_CHOIX).EndCurrentEdit()
        SPCH_TA.Update(Me.DsTheriaque_CriteresChoix.SPCH_SPECIALITE_CHOIX)

        Me.BindingContext(Me.MasterDataSet, CHSAC_CHOIX_SUBACTIVE).EndCurrentEdit()
        CHSAC.Update(Me.DsTheriaque_CriteresChoix.CHSAC_CHOIX_SUBACTIVE)

        Me.BindingContext(Me.MasterDataSet, CHCPH_CHOIX_CLASSEPHARMTHER).EndCurrentEdit()
        CHCPH.Update(Me.DsTheriaque_CriteresChoix.CHCPH_CHOIX_CLASSEPHARMTHER)

        Me.BindingContext(Me.MasterDataSet, CHCCH_CHOIX_CLASSECHIMIQUE).EndCurrentEdit()
        CHCCH.Update(Me.DsTheriaque_CriteresChoix.CHCCH_CHOIX_CLASSECHIMIQUE)

        Me.BindingContext(Me.MasterDataSet, CHSAU_CHOIX_SUBAUXILIAIRE).EndCurrentEdit()
        CHSAU.Update(Me.DsTheriaque_CriteresChoix.CHSAU_CHOIX_SUBAUXILIAIRE)

        Me.BindingContext(Me.MasterDataSet, CHPR_CHOIX_PRODUIT).EndCurrentEdit()
        CHPR.Update(Me.DsTheriaque_CriteresChoix.CHPR_CHOIX_PRODUIT)

        Me.BindingContext(Me.MasterDataSet, CHCATC_CHOIX_CLASSEATC).EndCurrentEdit()
        CHCATC.Update(Me.DsTheriaque_CriteresChoix.CHCATC_CHOIX_CLASSEATC)


    End Sub

    Public Overrides Sub annuler()
        OnLoading = True
        MyBase.Annuler()
        Me.BindingContext(DsTheriaque_CriteresChoix, CHTIT_CH_TITRE2).CancelCurrentEdit()
        Me.DsTheriaque_CriteresChoix.CHTIT_CH_TITRE2.RejectChanges()

        'Master
        Me.BindingContext(Me.MasterDataSet, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_CriteresChoix.CH_CHOIX.RejectChanges()

        OnLoading = False
    End Sub

    Private Sub EmptyDataTable()
        'Master
        Me.DsTheriaque_CriteresChoix.CH_CHOIX.Clear()
        Me.DsTheriaque_CriteresChoix.CHTIT_CH_TITRE2.Clear()
    End Sub

#End Region

#Region " Init Data  "

    Private Sub InitDataSource()
        GC11.DataSource = DsTheriaque_CriteresChoix
        GC11.DataMember = CHTIT_CH_TITRE2

        GC15.DataSource = DsTheriaque_CriteresChoix
        GC15.DataMember = SPCH_SPECIALITE_CHOIX

        GC_D1.DataSource = DsTheriaque_CriteresChoix
        GC_D1.DataMember = CHCPH_CHOIX_CLASSEPHARMTHER

        GC_D2.DataSource = DsTheriaque_CriteresChoix
        GC_D2.DataMember = CHCCH_CHOIX_CLASSECHIMIQUE

       
        GC_D4.DataSource = DsTheriaque_CriteresChoix
        GC_D4.DataMember = CHSAC_CHOIX_SUBACTIVE

        GC_D5.DataSource = DsTheriaque_CriteresChoix
        GC_D5.DataMember = CHSAU_CHOIX_SUBAUXILIAIRE

        GC_D6.DataSource = DsTheriaque_CriteresChoix
        GC_D6.DataMember = CHPR_CHOIX_PRODUIT

        GC8.DataSource = DsTheriaque_CriteresChoix
        GC8.DataMember = CHCATC_CHOIX_CLASSEATC

    End Sub

    Public Overrides Sub InitData()
        MyBase.InitData()
        OnLoading = True
        Declinaison_Global = True
        MasterDataSet = Me.DsTheriaque_CriteresChoix
        MasterTable = CH_CHOIX
        CodE = InvalideControl

        'Déclinaison

        InitDeclinaison()

        Dim List1 As New System.Collections.Generic.List(Of StructGVTable)
        List1.Add(New StructGVTable("GC15", eDeclinaison.SP, colSPCH_SP_CODE_FK_PK))
        Dim DecSP As New ClsDeclinaison(eDeclinaison.SP, List1)


        InitLkup(Me.lkup_CHTIT, CHTIT_CH_TITRE2, strSSQL_CDF_CODIF("30"), True)
        InitLkup(Me.lkup_SPCH, SPCH_SPECIALITE_CHOIX, strSSQL_SP_SPECIALITE, True, , , , , , DecSP)

        InitDataSource()
        FirstFocus = txtCode
        If _Code <> Nothing Then
            Load_On(Me)
            Open_Fiche(_Code)
            ModeFiche = eMode.Consultation
            UpdateStateBouton()
            Initcomponent()

            Dim aDoc As New ArrayList
            doc = New DocumentService.DocumentProvider(cn.sConnexion)
            doc.cn = New SqlClient.SqlConnection(cn.sConnexion)
            aDoc = doc.GetDocsByTypeDoc(_Code, DocumentService.DocumentProvider.TypeDoc.CritChoix)
            If aDoc.Count > 0 Then
                doc = aDoc(0)
                'Affichage des propriétés.
                Me.txtLibelle.Text = doc.DO_Label
                Me.meNote.Text = doc.DO_Note
                Me.lueCategorie.EditValue = CType(doc.ID_Categorie, Short)
            Else
                Me.txtLibelle.Text = ""
                Me.meNote.Text = ""
                Me.lueCategorie.EditValue = Nothing
            End If

            Load_Off(Me)
        End If
        OnLoading = False

        doc = New DocumentService.DocumentProvider(cn.sConnexion)

        Dim dt As New DataTable
        dt = doc.GetAllCategories()
        Me.lueCategorie.Properties.DataSource = dt


    End Sub

    Private Sub InitDeclinaison()

        Dim List5 As New System.Collections.Generic.List(Of StructGVTable)
        List5.Add(New StructGVTable("GC_D1", eDeclinaison.CPH, colCHCPH_CPH_CODE_PK_FK2))
        List5.Add(New StructGVTable("GC_D2", eDeclinaison.CCH, colCHCCH_CCH_CODE_PK_FK2))
        List5.Add(New StructGVTable("GC_D4", eDeclinaison.SAC, colCHSAC_SAC_CODE_SQ_PK_FK2))
        List5.Add(New StructGVTable("GC15", eDeclinaison.SP, colSPCH_SP_CODE_FK_PK2))
        Dim dec5 As New ClsDeclinaison(eDeclinaison.CPH, List5)
        InitLkup(Me.lkup_CHCPH, CPH_CLASSEPHARMTHER, strSSQL_CPH_CLASSEPHARMTHER, True, , , , , , dec5)

        Dim List6 As New System.Collections.Generic.List(Of StructGVTable)
        List6.Add(New StructGVTable("GC_D1", eDeclinaison.CPH, colCHCPH_CPH_CODE_PK_FK2))
        List6.Add(New StructGVTable("GC_D2", eDeclinaison.CCH, colCHCCH_CCH_CODE_PK_FK2))
        List6.Add(New StructGVTable("GC_D4", eDeclinaison.SAC, colCHSAC_SAC_CODE_SQ_PK_FK2))
        List6.Add(New StructGVTable("GC_D5", eDeclinaison.SAU, colCHSAU_SAU_CODE_SQ_PK_FK2))
        List6.Add(New StructGVTable("GC15", eDeclinaison.SP, colSPCH_SP_CODE_FK_PK2))
        Dim dec6 As New ClsDeclinaison(eDeclinaison.CCH, List6)
        InitLkup(Me.lkup_CHCCH, CCH_CLASSECHIMIQUE, strSSQL_CCH_CLASSECHIMIQUE, True, , , , , , dec6)

        Dim List As New System.Collections.Generic.List(Of StructGVTable)
        List.Add(New StructGVTable("GC_D4", eDeclinaison.SAC, colCHSAC_SAC_CODE_SQ_PK_FK2))
        List.Add(New StructGVTable("GC15", eDeclinaison.SP, colSPCH_SP_CODE_FK_PK2))
        Dim dec As New ClsDeclinaison(eDeclinaison.SAC, List)
        InitLkup(Me.lkup_CHSAC, IT1SAC_TERME1SUBACTIVE, strSSQL_SAC_SUBACTIVE, True, , , , , , dec)

        Dim List3 As New System.Collections.Generic.List(Of StructGVTable)
        List3.Add(New StructGVTable("GC_D5", eDeclinaison.SAU, colCHSAU_SAU_CODE_SQ_PK_FK2))
        List3.Add(New StructGVTable("GC15", eDeclinaison.SP, colSPCH_SP_CODE_FK_PK2))
        Dim dec3 As New ClsDeclinaison(eDeclinaison.SAU, List3)
        InitLkup(Me.lkup_CHSAU, IT1SAU_TERME1SUBAUX, strSSQL_SAU_SUBAUXILIAIRE, True, , , , , , dec3)

        Dim List11 As New System.Collections.Generic.List(Of StructGVTable)
        List11.Add(New StructGVTable("GC_D6", eDeclinaison.PR, colCHPR_PR_CODE_SQ_PK_FK2))
        List11.Add(New StructGVTable("GC15", eDeclinaison.SP, colSPCH_SP_CODE_FK_PK2))
        Dim dec11 As New ClsDeclinaison(eDeclinaison.PR, List11)
        InitLkup(Me.lkup_CHPR, PR_PRODUIT, strSSQL_PR_PRODUIT, True, , , , , , dec11)

        Dim List12 As New System.Collections.Generic.List(Of StructGVTable)
        List12.Add(New StructGVTable("GC8", eDeclinaison.ATC, colCHCATC_CATC_CODE_PK_FK2))
        List12.Add(New StructGVTable("GC15", eDeclinaison.SP, colSPCH_SP_CODE_FK_PK2))
        Dim dec12 As New ClsDeclinaison(eDeclinaison.ATC, List12)
        InitLkup(Me.lkup_CHCATC, CATC_CLASSEATC, strSSQL_CATC_CLASSEATC, True, , , , , , dec12)


        'InitLkup(lkup_CATC, CATC_CLASSEATC, strSSQL_CATC_CLASSEATC, True, False, True, True)

        InitLkup(Me.lkup_IT1SP, IT1SP_TERME1SPECIALITE, strSSQL_SP_SPECIALITE, True)

        
    End Sub

    Private Sub GV11_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV11.InitNewRow
        If OnLoading Then Exit Sub
        GV11.SetFocusedRowCellValue(colCHTIT_CH_CODE_FK_PK, txtCode.Text)
        GV11.SetFocusedRowCellValue(colCHTIT_NUMORD, Code_MAx(GV11, colCHTIT_NUMORD))
    End Sub

#End Region

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Ctrl"></param>
    ''' <param name="AllCtrl"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Friend Overrides Function ValideControl(Optional ByRef Ctrl As Control = Nothing, Optional ByVal AllCtrl As Boolean = True) As Boolean
        Dim strSSQL As String = ""
        MyBase.ValideControl(Ctrl)

        If Me.GV11.RowCount = 0 Then
            Process_Message("Il faut saisir une valeur dans Titre 2", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            If GV11.GetRowCellValue(0, colCHTIT_CDF_TIT_CODE_FK_PK2) = Nothing Then
                Process_Message("Il faut saisir une valeur dans Titre 2", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub Open_Fiche(ByVal CodE1 As Integer)
        OnLoading = True
        CodE = _Code
        EmptyDataTable()
        Me.CH_TA.FillByCode(Me.DsTheriaque_CriteresChoix.CH_CHOIX, CodE1)
        Me.ChtiT_TA.FillByCode(Me.DsTheriaque_CriteresChoix.CHTIT_CH_TITRE2, CodE1)
        Me.SPCH_TA.FillByCode(Me.DsTheriaque_CriteresChoix.SPCH_SPECIALITE_CHOIX, CodE1)
        Me.CHSAC.FillByCode(Me.DsTheriaque_CriteresChoix.CHSAC_CHOIX_SUBACTIVE, CodE1)
        Me.CHCPH.FillByCode(Me.DsTheriaque_CriteresChoix.CHCPH_CHOIX_CLASSEPHARMTHER, CodE1)
        Me.CHCCH.FillByCode(Me.DsTheriaque_CriteresChoix.CHCCH_CHOIX_CLASSECHIMIQUE, CodE1)
        Me.CHSAU.FillByCode(Me.DsTheriaque_CriteresChoix.CHSAU_CHOIX_SUBAUXILIAIRE, CodE1)
        OnLoading = False
    End Sub


#Region "Document "

    Private Sub bePath_ButtonClick(ByVal sender As System.Object, ByVal eg As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles bePath.ButtonClick

        Select Case eg.Button.Tag
            Case "explorer"
                Using Ofd As New OpenFileDialog
                    Ofd.Filter = "Fichier PDF| *.pdf| Fichiers Images | *.gif;*.jpg; *.bmp; *.png"
                    If Ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                        ' Display the selected folder if the user clicked on the OK button.
                        bePath.Text = Ofd.FileName
                        btnImporter.Enabled = True
                    End If
                End Using
            Case "effacer"
                bePath.Text = ""
        End Select

    End Sub

    Private Sub SaveDocument(ByVal path As String)

        Dim oFile As System.IO.FileInfo
        oFile = New System.IO.FileInfo(path)
        Dim oFileStream As System.IO.FileStream = oFile.OpenRead()
        Dim lBytes As Long = oFileStream.Length
        If (lBytes > 0) Then
            Dim fileData(lBytes - 1) As Byte
            oFileStream.Read(fileData, 0, lBytes)
            oFileStream.Close()
            Dim isNew As Boolean = True
            If doc.DO_Contenu IsNot Nothing Then
                isNew = False
            End If
            With doc
                .DO_Date = Now.Date
                .DO_DateHeure = Now
                .DO_extension = IO.Path.GetExtension(path)
                .DO_Label = IO.Path.GetFileName(path)
                .DO_Contenu = fileData

                If (Not String.IsNullOrEmpty(Me.lueCategorie.EditValue)) Then
                    If Me.lueCategorie.EditValue IsNot DBNull.Value Then ' And Me.lueCategorie.EditValue <> "" Then
                        If Me.lueCategorie.EditValue <> 0 Then doc.ID_Categorie = Me.lueCategorie.EditValue
                    End If
                End If
                .DO_Info1 = path
                .DO_Note = Me.meNote.Text
                .Save(isNew)  ' False for update.
            End With
        End If

    End Sub

    Private Sub btnImporter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImporter.Click

        If (Not String.IsNullOrEmpty(txtCode.Text)) Then
            'importer
            If (Not String.IsNullOrEmpty(bePath.Text)) Then
                If (doc.ExistCRT(txtCode.Text)) Then
                    Dim isNew As Boolean = True

                    If doc.DO_Contenu IsNot Nothing Then
                        isNew = False
                    End If

                    SaveDocument(bePath.Text)

                    If (isNew) Then
                        CodE = Integer.Parse(txtCode.Text)
                        doc.AddDocumentToAssociation(doc.DO_ID, CodE, DocumentService.DocumentProvider.TypeDoc.CritChoix)
                    End If

                    Me.txtLibelle.Text = doc.DO_Label
                    Me.meNote.Text = doc.DO_Note
                    Me.lueCategorie.EditValue = CType(doc.ID_Categorie, Short)
                    MsgBox("Document importé avec succès")
                End If
            Else
                MsgBox("Veuillez sélectionner un chemin")
            End If
        Else
            MsgBox("Veuillez charger un critère de choix")
        End If

    End Sub

    Private Sub bSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSupprimer.Click

        If (Not String.IsNullOrEmpty(txtLibelle.Text)) Then
            If (IsNumeric(txtCode.Text)) Then
                doc.cn.ConnectionString = cn.sConnexion
                doc.DeleteFromAssociation(doc.DO_ID, txtCode.Text, DocumentService.DocumentProvider.TypeDoc.CritChoix)
                Me.txtLibelle.Text = ""
                Me.meNote.Text = ""
                Me.lueCategorie.EditValue = Nothing
                doc = New DocumentService.DocumentProvider(cn.sConnexion)
            End If
        Else
            MsgBox("Aucun document importé")
        End If

    End Sub

    Private Sub btAperçu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAperçu.Click

        If (Not String.IsNullOrEmpty(txtLibelle.Text)) Then
            If doc IsNot Nothing Then
                '            doc = Me.gvDocuments.GetRow(gvDocuments.FocusedRowHandle)
                Dim f As New FrmApercu
                f.doc = doc
                f.ShowDialog()
            Else
                MsgBox("Veuillez sélectionner un document")
            End If
        Else
            MsgBox("Aucun document importé")
        End If

    End Sub

    Private Sub gvDocuments_BeforeLeaveRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowAllowEventArgs)
        SaveDoc()
    End Sub


    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        SaveDoc()
    End Sub

    Private Sub SaveDoc()
        doc.DO_Label = Me.txtLibelle.Text
        doc.DO_Note = Me.meNote.Text
        doc.cn = New SqlClient.SqlConnection(cn.sConnexion)

        If Me.lueCategorie.EditValue IsNot DBNull.Value Then ' And Me.lueCategorie.EditValue <> "" Then
            doc.ID_Categorie = Me.lueCategorie.EditValue
        End If
        doc.Save(False)
    End Sub

    Private Sub cmdAnnuler_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAnnuler.Click

        'Affichage des propriétés.
        Me.txtLibelle.Text = doc.DO_Label
        Me.meNote.Text = doc.DO_Note
        Me.lueCategorie.EditValue = CType(doc.ID_Categorie, Short)

    End Sub
#End Region



    Private Sub GV15_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV15.InitNewRow

        If OnLoading Then Exit Sub
        GV15.SetFocusedRowCellValue(colSPCH_CH_CODE_FK_PK, txtCode.Text)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GC11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GC11.Click

    End Sub

    Private Sub GC15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GC15.Click

    End Sub

    Private Sub GV_D1_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV_D1.InitNewRow

        If OnLoading Then Exit Sub
        GV_D1.SetFocusedRowCellValue(colCHCPH_CH_CODE_SQ_PK_FK, txtCode.Text)
        'Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"

    End Sub

    Private Sub GV_D2_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV_D2.InitNewRow

        If OnLoading Then Exit Sub
        GV_D2.SetFocusedRowCellValue(colCHCCH_CH_CODE_SQ_PK_FK, txtCode.Text)
        'Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"


    End Sub

   

    Private Sub GV_D4_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV_D4.InitNewRow

        If OnLoading Then Exit Sub
        GV_D4.SetFocusedRowCellValue(colCHSAC_CH_CODE_SQ_PK_FK, txtCode.Text)
        'Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"

    End Sub

    Private Sub GV_D5_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV_D5.InitNewRow

        GV_D5.SetFocusedRowCellValue(colCHSAU_CH_CODE_SQ_PK_FK, txtCode.Text)
        'Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"

    End Sub

    Private Sub GV_D6_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV_D6.InitNewRow

        GV_D6.SetFocusedRowCellValue(colCHPR_CH_CODE_SQ_PK_FK, txtCode.Text)
        'Me.BindingContext(DsTheriaque_AnalyseOrdonance, FIT_FICHEINTERAC).Current("FIT_ORIGINE") = "D"

    End Sub

  

    Private Sub GV8_InitNewRow_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV8.InitNewRow
        GV8.SetFocusedRowCellValue(colCHCATC_CH_CODE_SQ_PK_FK, txtCode.Text)
    End Sub
End Class
