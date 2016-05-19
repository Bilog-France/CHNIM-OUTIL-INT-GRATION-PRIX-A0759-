Imports System.IO


Public Class Frm_Import_Selection

    Private dt As DataTable
    Private doc As DocumentService.DocumentProvider

    Private Sub btFermer_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btFermer.ItemClick

        Me.Close()

    End Sub

    Private Sub btChercher_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btChercher.ItemClick

        Dim f As New Frm_PreSelection
        f._Validate = False
        f.ShowDialog()

        If (f._Validate) Then
            If (Not f.bAnnuler) Then

                If ((f.NewSrch) Or (gvSpecPres.RowCount = 0)) Then
                    dt = f.dtResultat
                    dt.Columns(0).ColumnName = "CodeSP"
                    dt.Columns(1).ColumnName = "Libelle"
                Else
                    dt.Columns(0).ColumnName = "CodeSP"
                    dt.Columns(1).ColumnName = "Libelle"
                    f.dtResultat.Columns(0).ColumnName = "CodeSP"
                    f.dtResultat.Columns(1).ColumnName = "Libelle"
                    dt.Merge(f.dtResultat)
                End If

                If Not dt.Columns.Contains("Check") Then
                    dt.Columns.Add("Check", System.Type.GetType("System.Int32"))
                End If

                Me.gcSpecPres.DataSource = dt

            End If
        End If

    End Sub

    Private Sub Frm_Import_Selection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dt = New DataTable()
        doc = New DocumentService.DocumentProvider(strConnexion)
        dt = doc.GetAllCategories()
        Me.lueCategorie.Properties.DataSource = dt

    End Sub


    Private Sub btImporter_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btImporter.ItemClick

        Me.beChemin.Select()
        If Not String.IsNullOrEmpty(beChemin.Text) Then
            If (IsChecked()) Then
                ImporterDocuments()
            Else
                MsgBox("Veuillez sélectionner au moins une spécialité ou présentation")
            End If
        Else
            MsgBox("Veuillez sélectionner un chemin")
        End If

    End Sub

    Private Sub ImporterDocuments()

        Dim dr As DataRowView
        Dim codeSP As String
        Dim TypeSP As String
        Dim oFile As System.IO.FileInfo
        Dim d As New DirectoryInfo(beChemin.Text)


        Dim tPdfFiles As FileInfo() = d.GetFiles()
        Dim s As String = tPdfFiles.Length
        lstDetails.Items.Clear()
        Dim nbimport As Integer
        pgBarDocument.Properties.Step = 1
        pgBarDocument.Properties.PercentView = True
        pgBarDocument.Properties.Minimum = 0
        pgBarDocument.Properties.Maximum = tPdfFiles.Length


        Dim filter As String = "*.pdf,*.gif,*.jpg,*.bmp,*.png"
        For Each f As FileInfo In tPdfFiles

            If (filter.ToLower().Contains(f.Extension.ToLower())) Then

                oFile = New System.IO.FileInfo(f.FullName)
                Dim oFileStream As System.IO.FileStream = oFile.OpenRead()
                Dim lBytes As Long = oFileStream.Length
                If (lBytes > 0) Then
                    lstDetails.Items.Add(f.FullName)
                    nbimport += 1
                    lblNbImport.Text = nbimport
                    Dim fileData(lBytes - 1) As Byte
                    oFileStream.Read(fileData, 0, lBytes)
                    oFileStream.Close()
                    With doc
                        .DO_Date = Now.Date
                        .DO_DateHeure = Now
                        .DO_extension = IO.Path.GetExtension(f.FullName)
                        If Me.txtLibelle.Text.Trim() = Nothing Then
                            .DO_Label = IO.Path.GetFileName(f.FullName)
                        Else
                            .DO_Label = Me.txtLibelle.Text
                        End If
                        .DO_Note = Me.meNote.Text
                        If (Not String.IsNullOrEmpty(Me.lueCategorie.EditValue)) Then
                            .ID_Categorie = Me.lueCategorie.EditValue
                        End If
                        .DO_Contenu = fileData
                        .DO_Info1 = f.FullName
                        .Save(True)  ' False for update.
                    End With

                    For i As Integer = 0 To gvSpecPres.RowCount - 1
                        dr = gvSpecPres.GetRow(i)
                        If (Not String.IsNullOrEmpty(dr.Row.ItemArray(3).ToString())) Then
                            If (Integer.Parse(dr.Row.ItemArray(3).ToString()) = 1) Then
                                codeSP = dr.Row.ItemArray(0).ToString()
                                TypeSP = dr.Row.ItemArray(2).ToString()
                                If (TypeSP.Equals("UCD")) Then
                                    doc.AddDocumentToAssociation(doc.DO_ID, codeSP, DocumentService.DocumentProvider.TypeDoc.Specialite)
                                Else
                                    doc.AddDocumentToAssociation(doc.DO_ID, codeSP, DocumentService.DocumentProvider.TypeDoc.Presentation)
                                End If
                            End If
                        End If
                    Next
                End If

                pgBarDocument.PerformStep()
                pgBarDocument.Update()
            End If
        Next

    End Sub


    Private Function IsChecked() As Boolean

        Dim dr As DataRowView

        For i As Integer = 0 To gvSpecPres.RowCount - 1
            dr = gvSpecPres.GetRow(i)

            If (Not String.IsNullOrEmpty(dr.Row.ItemArray(3).ToString())) Then
                Dim s As String = gvSpecPres.GetRowCellValue(i, "Check")
                If (Integer.Parse(dr.Row.ItemArray(3).ToString()) = 1) Then

                    Return True
                End If
            End If
        Next
        Return False

    End Function


    Private Sub beChemin_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beChemin.ButtonClick

        Select Case e.Button.Tag
            Case "explorer"
                Dim FolderBrowserDialog1 As New FolderBrowserDialog
                If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    ' Display the selected folder if the user clicked on the OK button.
                    beChemin.Text = FolderBrowserDialog1.SelectedPath
                End If
            Case "effacer"
                beChemin.Text = ""
        End Select

    End Sub



    Private Sub lstDetails_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstDetails.SelectedIndexChanged

    End Sub

    Private Sub PanelControl5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PanelControl5.Paint

    End Sub

    Private Sub btTout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTout.Click

        For inti As Integer = 0 To Me.gvSpecPres.RowCount - 1
            gvSpecPres.SetRowCellValue(inti, Me.ColCheckbox, 1)
        Next

    End Sub

    Private Sub btNone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNone.Click

        For inti As Integer = 0 To Me.gvSpecPres.RowCount - 1
            gvSpecPres.SetRowCellValue(inti, Me.ColCheckbox, 0)
        Next

    End Sub

End Class