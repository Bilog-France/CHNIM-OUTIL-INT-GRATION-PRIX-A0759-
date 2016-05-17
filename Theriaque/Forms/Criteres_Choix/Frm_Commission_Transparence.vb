''' <summary>
''' Created By [BFE]
''' </summary>
''' <remarks> Critéres de choix - Commission de la transparence 
''' </remarks>
Public Class Frm_Commission_Transparence

#Region "Déclaration des variables privées"
    Private CodE As String
    Public _Code As Integer = Nothing ' charger la fiche depuis l'extérieur
    Dim doc As DocumentService.DocumentProvider
#End Region

#Region " Edit Data  "

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_ATR_AVISCOMMISSIONTRANSPARENCE
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            OnLoading = True
            EmptyDataTable()
            Me.AtR_TA.FillByCode(Me.DsTheriaque_CriteresChoix.ATR_AVISCOMMISSIONTRANSPARENCE, f._Code)
            Me.AtrasmR_TA.FillByCode(Me.DsTheriaque_CriteresChoix.ATRASMR_AVISCOMTRANS_ASMR, f._Code)
            Me.AtrsmR_TA.FillByCode(Me.DsTheriaque_CriteresChoix.ATRSMR_AVISCOMTRANS_SMR, f._Code)
            Me.AtrsaC_TA.FillByCode(Me.DsTheriaque_CriteresChoix.ATRSAC_AVISCOMTRANS_SUBACTIVE, f._Code)
            Me.AtrpR_TA.FillByCode(Me.DsTheriaque_CriteresChoix.ATRPR_AVISCOMTRANS_PRODUIT, f._Code)
            Me.SpatR_TA.FillByCode(Me.DsTheriaque_CriteresChoix.SPATR_SPEC_AVISTRANSPARENCE, f._Code)

            Dim aDoc As New ArrayList
            doc = New DocumentService.DocumentProvider(cn.sConnexion)
            doc.cn = New SqlClient.SqlConnection(cn.sConnexion)
            aDoc = doc.GetDocsByTypeDoc(CodE, DocumentService.DocumentProvider.TypeDoc.CommiTrans)
            If aDoc.Count > 0 Then
                doc = aDoc(0)
                'Affichage des propriétés.
                Me.txtLibelle.Text = doc.DO_Label
                Me.meNote.Text = doc.DO_Note
                Me.lueCategorie.EditValue = CType(doc.ID_Categorie, Short)
            Else
                bePath.Text = ""
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
        MyBase.Ajouter()
        txtLibelle.Text = ""
        bePath.Text = ""
        Me.lueCategorie.EditValue = Nothing
        Me.meNote.Text = ""


    End Sub

    Public Overrides Function supprimer() As Boolean
        MyBase.Supprimer()
        Dim iCount As Integer

        For iCount = 0 To DsTheriaque_CriteresChoix.ATRASMR_AVISCOMTRANS_ASMR.Rows.Count - 1
            DsTheriaque_CriteresChoix.ATRASMR_AVISCOMTRANS_ASMR.Rows(iCount).Delete()
        Next
        Me.AtrasmR_TA.Update(DsTheriaque_CriteresChoix)

        For iCount = 0 To DsTheriaque_CriteresChoix.ATRSMR_AVISCOMTRANS_SMR.Rows.Count - 1
            DsTheriaque_CriteresChoix.ATRSMR_AVISCOMTRANS_SMR.Rows(iCount).Delete()
        Next
        Me.AtrsmR_TA.Update(DsTheriaque_CriteresChoix)

        For iCount = 0 To DsTheriaque_CriteresChoix.ATRSAC_AVISCOMTRANS_SUBACTIVE.Rows.Count - 1
            DsTheriaque_CriteresChoix.ATRSAC_AVISCOMTRANS_SUBACTIVE.Rows(iCount).Delete()
        Next
        Me.AtrsaC_TA.Update(DsTheriaque_CriteresChoix)

        For iCount = 0 To DsTheriaque_CriteresChoix.ATRPR_AVISCOMTRANS_PRODUIT.Rows.Count - 1
            DsTheriaque_CriteresChoix.ATRPR_AVISCOMTRANS_PRODUIT.Rows(iCount).Delete()
        Next
        Me.AtrpR_TA.Update(DsTheriaque_CriteresChoix)

        For iCount = 0 To DsTheriaque_CriteresChoix.SPATR_SPEC_AVISTRANSPARENCE.Rows.Count - 1
            DsTheriaque_CriteresChoix.SPATR_SPEC_AVISTRANSPARENCE.Rows(iCount).Delete()
        Next
        Me.SpatR_TA.Update(DsTheriaque_CriteresChoix)

        ' Master
        DsTheriaque_CriteresChoix.ATR_AVISCOMMISSIONTRANSPARENCE.Rows(0).Delete()
        Me.AtR_TA.Update(Me.MasterDataSet)
        bePath.Text = ""
        txtLibelle.Text = ""
        Me.lueCategorie.EditValue = Nothing
        Me.meNote.Text = ""

        Return True
    End Function

    Public Overrides Sub valider()
        MyBase.Valider()
        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        AtR_TA.Update(Me.DsTheriaque_CriteresChoix.ATR_AVISCOMMISSIONTRANSPARENCE)

        Me.BindingContext(Me.MasterDataSet, ATRASMR_AVISCOMTRANS_ASMR).EndCurrentEdit()
        AtrasmR_TA.Update(Me.DsTheriaque_CriteresChoix.ATRASMR_AVISCOMTRANS_ASMR)

        Me.BindingContext(Me.MasterDataSet, ATRSMR_AVISCOMTRANS_SMR).EndCurrentEdit()
        AtrsmR_TA.Update(Me.DsTheriaque_CriteresChoix.ATRSMR_AVISCOMTRANS_SMR)

        Me.BindingContext(Me.MasterDataSet, ATRSAC_AVISCOMTRANS_SUBACTIVE).EndCurrentEdit()
        AtrsaC_TA.Update(Me.DsTheriaque_CriteresChoix.ATRSAC_AVISCOMTRANS_SUBACTIVE)

        Me.BindingContext(Me.MasterDataSet, ATRPR_AVISCOMTRANS_PRODUIT).EndCurrentEdit()
        AtrpR_TA.Update(Me.DsTheriaque_CriteresChoix.ATRPR_AVISCOMTRANS_PRODUIT)

        Me.BindingContext(Me.MasterDataSet, SPATR_SPEC_AVISTRANSPARENCE).EndCurrentEdit()
        SpatR_TA.Update(Me.DsTheriaque_CriteresChoix.SPATR_SPEC_AVISTRANSPARENCE)

        Dim strSSQL2 As String
        For inti As Integer = 0 To GV12.RowCount - 1
            If GV12.GetRowCellValue(inti, colATRSMR_CDF_SMR_CODE_FK_PK2) <> Nothing Then
                For intj As Integer = 0 To GV15.RowCount - 1
                    If GV15.GetRowCellValue(intj, colSPATR_SP_CODE_FK_PK2) <> Nothing Then
                        Dim dt As DataTable = cn.MySelect("select * from THERIAQUE.SPSMR_SERVICE_MEDICAL_RENDU where SPSMR_SP_CODE_FK_PK = " & GV15.GetRowCellValue(intj, colSPATR_SP_CODE_FK_PK2) & " and SPSMR_CDF_SMR_CODE_FK_PK = " & cn.SQLText(GV12.GetRowCellValue(inti, colATRSMR_CDF_SMR_CODE_FK_PK2)))
                        'If dt.Rows.Count = 0 Then
                            Dim dt2 As DataTable = cn.MySelect("SELECT MAX(SPSMR_NUM_ORD_PK) FROM THERIAQUE.SPSMR_SERVICE_MEDICAL_RENDU WHERE SPSMR_SP_CODE_FK_PK = " & GV15.GetRowCellValue(intj, colSPATR_SP_CODE_FK_PK2))
                            Dim Max As Integer
                            Max = 1
                            If dt2.Rows.Count > 0 Then
                                If dt2.Rows(0)(0) IsNot DBNull.Value Then
                                    Max = dt2.Rows(0)(0) + 1
                                End If
                        End If
                        Dim sSql As String = "select * from THERIAQUE.SPSMR_SERVICE_MEDICAL_RENDU where SPSMR_SP_CODE_FK_PK = " & GV15.GetRowCellValue(intj, colSPATR_SP_CODE_FK_PK2) & " and SPSMR_CDF_SMR_CODE_FK_PK = " & cn.SQLText(GV12.GetRowCellValue(inti, colATRSMR_CDF_SMR_CODE_FK_PK2)) & " and SPSMR_DATE = " & cn.SQLDate(DateEdit3.DateTime)
                        Dim dtRowExist As DataTable = cn.MySelect(sSql)
                        If dtRowExist.Rows.Count = 0 Then
                            strSSQL2 = " Insert into THERIAQUE.SPSMR_SERVICE_MEDICAL_RENDU Values(" & GV15.GetRowCellValue(intj, colSPATR_SP_CODE_FK_PK2) & ", '" & GV12.GetRowCellValue(inti, colATRSMR_CDF_SMR_CODE_FK_PK2) & "'," & Max & "," & cn.SQLDate(DateEdit3.DateTime) & ")"
                            cn.Execute(strSSQL2)
                        End If
                        'End If
                    End If
                Next
            End If
        Next
    End Sub

    Public Overrides Sub annuler()
        OnLoading = True
        MyBase.Annuler()

        Me.BindingContext(DsTheriaque_CriteresChoix, ATRASMR_AVISCOMTRANS_ASMR).CancelCurrentEdit()
        Me.DsTheriaque_CriteresChoix.ATRASMR_AVISCOMTRANS_ASMR.RejectChanges()

        Me.BindingContext(DsTheriaque_CriteresChoix, ATRSMR_AVISCOMTRANS_SMR).CancelCurrentEdit()
        Me.DsTheriaque_CriteresChoix.ATRSMR_AVISCOMTRANS_SMR.RejectChanges()

        Me.BindingContext(DsTheriaque_CriteresChoix, ATRSAC_AVISCOMTRANS_SUBACTIVE).CancelCurrentEdit()
        Me.DsTheriaque_CriteresChoix.ATRSAC_AVISCOMTRANS_SUBACTIVE.RejectChanges()

        Me.BindingContext(DsTheriaque_CriteresChoix, ATRPR_AVISCOMTRANS_PRODUIT).CancelCurrentEdit()
        Me.DsTheriaque_CriteresChoix.ATRPR_AVISCOMTRANS_PRODUIT.RejectChanges()

        Me.BindingContext(DsTheriaque_CriteresChoix, SPATR_SPEC_AVISTRANSPARENCE).CancelCurrentEdit()
        Me.DsTheriaque_CriteresChoix.SPATR_SPEC_AVISTRANSPARENCE.RejectChanges()

        'Master
        Me.BindingContext(Me.MasterDataSet, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_CriteresChoix.ATR_AVISCOMMISSIONTRANSPARENCE.RejectChanges()

        OnLoading = False
    End Sub

    Private Sub EmptyDataTable()
        'Master
        Me.DsTheriaque_CriteresChoix.ATR_AVISCOMMISSIONTRANSPARENCE.Clear()

        Me.DsTheriaque_CriteresChoix.ATRASMR_AVISCOMTRANS_ASMR.Clear()
        Me.DsTheriaque_CriteresChoix.ATRSMR_AVISCOMTRANS_SMR.Clear()
        Me.DsTheriaque_CriteresChoix.ATRSAC_AVISCOMTRANS_SUBACTIVE.Clear()
        Me.DsTheriaque_CriteresChoix.ATRPR_AVISCOMTRANS_PRODUIT.Clear()
        Me.DsTheriaque_CriteresChoix.SPATR_SPEC_AVISTRANSPARENCE.Clear()
    End Sub

#End Region

#Region " Init Data  "

    Private Sub InitDataSource()
        GC11.DataSource = DsTheriaque_CriteresChoix
        GC11.DataMember = ATRASMR_AVISCOMTRANS_ASMR

        GC12.DataSource = DsTheriaque_CriteresChoix
        GC12.DataMember = ATRSMR_AVISCOMTRANS_SMR

        GC13.DataSource = DsTheriaque_CriteresChoix
        GC13.DataMember = ATRSAC_AVISCOMTRANS_SUBACTIVE

        GC14.DataSource = DsTheriaque_CriteresChoix
        GC14.DataMember = ATRPR_AVISCOMTRANS_PRODUIT

        GC15.DataSource = DsTheriaque_CriteresChoix
        GC15.DataMember = SPATR_SPEC_AVISTRANSPARENCE
    End Sub

    Public Overrides Sub InitData()
        MyBase.InitData()
        OnLoading = True
        MasterDataSet = Me.DsTheriaque_CriteresChoix
        MasterTable = ATR_AVISCOMMISSIONTRANSPARENCE
        CodE = InvalideControl

        'Déclinaison SUBAC
        Dim List3 As New System.Collections.Generic.List(Of StructGVTable)
        List3.Add(New StructGVTable("GC13", eDeclinaison.SAC, colATRSAC_SAC_CODE_FK_PK2))
        List3.Add(New StructGVTable("GC15", eDeclinaison.SP, colSPATR_SP_CODE_FK_PK2))
        Dim DecSUBAC As New ClsDeclinaison(eDeclinaison.SAC, List3)
        InitLkup(Me.lkup_ATRSAC, ATRSAC_AVISCOMTRANS_SUBACTIVE, strSSQL_SAC_SUBACTIVE, True, , , , , , DecSUBAC)

        'Déclinaison PRODUIT
        Dim List5 As New System.Collections.Generic.List(Of StructGVTable)
        List5.Add(New StructGVTable("GC14", eDeclinaison.PR, colATRPR_PR_CODE_FK_PK2))
        List5.Add(New StructGVTable("GC15", eDeclinaison.SP, colSPATR_SP_CODE_FK_PK2))
        Dim DecPR As New ClsDeclinaison(eDeclinaison.SP, List5)

        InitLkup(Me.lkup_ATRPR, ATRPR_AVISCOMTRANS_PRODUIT, strSSQL_PR_PRODUIT, True, , , , , , DecPR)

        InitLkup(Me.lkup_ATRASMR, ATRASMR_AVISCOMTRANS_ASMR, strSSQL_CDF_CODIF("23"), True)
        InitLkup(Me.lkup_ATRSMR, ATRSMR_AVISCOMTRANS_SMR, strSSQL_CDF_CODIF("27"), True)

        InitLkup(Me.lkup_SPATR, SPATR_SPEC_AVISTRANSPARENCE, strSSQL_SP_SPECIALITE, True)

        InitDataSource()
        FirstFocus = txtCode
        If _Code <> Nothing Then
            Load_On(Me)
            Open_Fiche(_Code)
            Dim aDoc As New ArrayList
            doc = New DocumentService.DocumentProvider(cn.sConnexion)
            doc.cn = New SqlClient.SqlConnection(cn.sConnexion)
            aDoc = doc.GetDocsByTypeDoc(_Code, DocumentService.DocumentProvider.TypeDoc.CommiTrans)
            If aDoc.Count > 0 Then
                doc = aDoc(0)
                'Affichage des propriétés.
                Me.txtLibelle.Text = doc.DO_Label
                Me.meNote.Text = doc.DO_Note
                Me.lueCategorie.EditValue = CType(doc.ID_Categorie, Short)
            Else
                bePath.Text = ""
                Me.txtLibelle.Text = ""
                Me.meNote.Text = ""
                Me.lueCategorie.EditValue = Nothing
            End If

            ModeFiche = eMode.Consultation
            UpdateStateBouton()
            Initcomponent()
            Load_Off(Me)
        End If
        OnLoading = False

        doc = New DocumentService.DocumentProvider(cn.sConnexion)

        Dim dt As New DataTable
        dt = doc.GetAllCategories()
        Me.lueCategorie.Properties.DataSource = dt
    End Sub

#End Region

    Private Sub Open_Fiche(ByVal CodE1 As Integer)
        OnLoading = True
        CodE = _Code
        EmptyDataTable()
        Me.AtR_TA.FillByCode(Me.DsTheriaque_CriteresChoix.ATR_AVISCOMMISSIONTRANSPARENCE, CodE1)
        Me.AtrasmR_TA.FillByCode(Me.DsTheriaque_CriteresChoix.ATRASMR_AVISCOMTRANS_ASMR, CodE1)
        Me.AtrsmR_TA.FillByCode(Me.DsTheriaque_CriteresChoix.ATRSMR_AVISCOMTRANS_SMR, CodE1)
        Me.AtrsaC_TA.FillByCode(Me.DsTheriaque_CriteresChoix.ATRSAC_AVISCOMTRANS_SUBACTIVE, CodE1)
        Me.AtrpR_TA.FillByCode(Me.DsTheriaque_CriteresChoix.ATRPR_AVISCOMTRANS_PRODUIT, CodE1)
        Me.SpatR_TA.FillByCode(Me.DsTheriaque_CriteresChoix.SPATR_SPEC_AVISTRANSPARENCE, CodE1)
        OnLoading = False
    End Sub

#Region " New Row "
    Private Sub GV11_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV11.InitNewRow
        If OnLoading Then Exit Sub
        GV11.SetFocusedRowCellValue(colATRASMR_ATR_CODE_FK_PK, txtCode.Text)
        GV11.SetFocusedRowCellValue(colATRASMR_NUMORD, Code_MAx(GV11, colATRASMR_NUMORD))
    End Sub

    Private Sub GV12_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV12.InitNewRow
        If OnLoading Then Exit Sub
        GV12.SetFocusedRowCellValue(colATRSMR_ATR_CODE_FK_PK, txtCode.Text)
        GV12.SetFocusedRowCellValue(colATRSMR_NUMORD, Code_MAx(GV12, colATRSMR_NUMORD))
    End Sub

    Private Sub GV13_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV13.InitNewRow
        If OnLoading Then Exit Sub
        GV13.SetFocusedRowCellValue(colATRSAC_ATR_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV14_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV14.InitNewRow
        If OnLoading Then Exit Sub
        GV14.SetFocusedRowCellValue(colATRPR_ATR_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV15_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV15.InitNewRow
        If OnLoading Then Exit Sub
        GV15.SetFocusedRowCellValue(colSPATR_ATR_CODE_FK_PK, txtCode.Text)
    End Sub

#End Region

#Region " Panel Resize "

    Private Sub Panel5_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel5.Resize
        GC11.Width = Panel5.Width / 2
        GC12.Width = Panel5.Width / 2
    End Sub

    Private Sub Panel2_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel2.Resize
        GC13.Width = Panel2.Width / 2
        GC14.Width = Panel2.Width / 2
    End Sub

    Private Sub Panel4_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel4.Resize
        Panel2.Height = Panel4.Height / 3
        Panel3.Height = Panel4.Height / 3
        Panel5.Height = Panel4.Height / 3
    End Sub
#End Region


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
                If Me.lueCategorie.EditValue IsNot DBNull.Value Then ' And Me.lueCategorie.EditValue <> "" Then
                    If Me.lueCategorie.Text <> "" Then doc.ID_Categorie = Me.lueCategorie.EditValue
                End If
                .DO_Info1 = path
                .DO_Note = Me.meNote.Text
                .cn = New SqlClient.SqlConnection(cn.sConnexion)
                .Save(isNew)  ' False for update.
            End With
        End If

    End Sub

    Private Sub btnImporter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImporter.Click

        If (Not String.IsNullOrEmpty(txtCode.Text)) Then
            'importer
            If (Not String.IsNullOrEmpty(bePath.Text)) Then
                If (doc.ExistATR(txtCode.Text)) Then
                    SaveDocument(bePath.Text)
                    doc.AddDocumentToAssociation(doc.DO_ID, txtCode.Text, DocumentService.DocumentProvider.TypeDoc.CommiTrans)
                    Me.txtLibelle.Text = doc.DO_Label
                    Me.meNote.Text = doc.DO_Note
                    Me.lueCategorie.EditValue = CType(doc.ID_Categorie, Short)

                    MsgBox("Document importé avec succès")
                End If
            Else
                MsgBox("Veuillez sélectionner un chemin")
            End If
        Else
            MsgBox("Veuillez charger une commission de transparence")
        End If

    End Sub

    Private Sub bSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSupprimer.Click
        If (Not String.IsNullOrEmpty(txtLibelle.Text)) Then
            If (IsNumeric(txtCode.Text)) Then
                doc.cn.ConnectionString = cn.sConnexion
                doc.DeleteFromAssociation(doc.DO_ID, txtCode.Text, DocumentService.DocumentProvider.TypeDoc.CommiTrans)
                bePath.Text = ""
                Me.txtLibelle.Text = ""
                Me.meNote.Text = ""
                Me.lueCategorie.EditValue = Nothing
                bePath.Text = ""
                Me.txtLibelle.Text = ""
                Me.meNote.Text = ""
                Me.lueCategorie.EditValue = Nothing

            End If
        Else
            MsgBox("Aucun document importé")
        End If

    End Sub

    Private Sub btAperçu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAperçu.Click

        If doc IsNot Nothing And Not String.IsNullOrEmpty(txtLibelle.Text) Then
            'doc = Me.gvDocuments.GetRow(gvDocuments.FocusedRowHandle)
            Dim f As New FrmApercu
            f.doc = doc
            f.ShowDialog()
        Else
            MsgBox("Veuillez importer un document")
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
        If (Not String.IsNullOrEmpty(Me.lueCategorie.EditValue)) Then
            If Me.lueCategorie.EditValue IsNot DBNull.Value Then ' And Me.lueCategorie.EditValue <> "" Then
                doc.ID_Categorie = Me.lueCategorie.EditValue
            End If
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

   
End Class
