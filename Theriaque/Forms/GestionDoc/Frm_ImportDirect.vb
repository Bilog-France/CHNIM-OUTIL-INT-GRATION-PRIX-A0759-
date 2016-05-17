Imports System.IO

Public Class Frm_ImportDirect

    Private doc As DocumentService.DocumentProvider

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

    Private Sub btFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFermer.Click

        Me.Close()

    End Sub

    Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click

        Dim oFile As System.IO.FileInfo
        Dim Code As String
        Dim Libelle As String
        'Me.DOC_Document_SPECTableAdapter.Fill(Me.DsTheriaqueDocument.DOC_Document_SPEC)
        'Me.DOC_Document_PRESTableAdapter.Fill(Me.DsTheriaqueDocument.DOC_Document_PRES)

        Dim cat As Integer
        If (String.IsNullOrEmpty(Me.lueCategorie.EditValue)) Then
            cat = 0
        Else
            cat = Me.lueCategorie.EditValue
        End If


        Dim nbImport As Integer = 0
        If (Not String.IsNullOrEmpty(beChemin.Text)) Then

            'Import direct des documents dans la spécialité

            Dim max As Integer = Directory.GetFiles(beChemin.Text, "UCD*").Length + Directory.GetFiles(beChemin.Text, "CIP*").Length
            Dim tb As String() = Directory.GetFiles(beChemin.Text, "UCD*")

            pgbarDocument.Properties.Step = 1
            pgbarDocument.Properties.PercentView = True
            pgbarDocument.Properties.Minimum = 0
            pgbarDocument.Properties.Maximum = GetNbFichierValide(beChemin.Text)

            Dim d As New DirectoryInfo(beChemin.Text)
            Dim t As String()
            lstDetails.Items.Clear()
            lblNbImport.Text = "0"

            Dim filter As String = "*.pdf,*.gif,*.jpg,*.bmp,*.png"

            For Each f As FileInfo In d.GetFiles("UCD_*")
                If (filter.ToLower().Contains(f.Extension.ToLower())) Then
                    If FormatValide(f.Name) Then
                        t = f.Name.Split("_")
                        Code = t(1)
                        Libelle = t(2)

                        'DOC_Document_SPECTableAdapter.ImportDocument(Code, Libelle, f.FullName, System.DateTime.Now)

                        oFile = New System.IO.FileInfo(f.FullName)
                        Dim oFileStream As System.IO.FileStream = oFile.OpenRead()
                        Dim lBytes As Long = oFileStream.Length
                        If (lBytes > 0) Then
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
                                .DO_Contenu = fileData
                                .ID_Categorie = cat
                                .DO_Info1 = f.FullName

                                .Save(True)  ' False for update.
                            End With
                            Dim dt As DataTable = doc.GetSPCodeFromSP_CIPUCD(Code)

                            Dim import As Boolean = False
                            For Each dr As DataRow In dt.Rows
                                Code = Integer.Parse(dr("SP_CODE_SQ_PK").ToString())
                                doc.AddDocumentToAssociation(doc.DO_ID, Code, DocumentService.DocumentProvider.TypeDoc.Specialite)
                                import = True
                            Next

                            If (import) Then

                                lstDetails.Items.Add(f.FullName)
                                oFile.MoveTo(f.Directory.FullName & "\\Vu_" & f.Name)
                                pgbarDocument.PerformStep()
                                pgbarDocument.Update()
                                nbImport += 1
                                lblNbImport.Text = nbImport

                            End If

                        End If
                    End If
                End If
            Next

            
            'Import direct des documents dans la présentation
            For Each f As FileInfo In d.GetFiles("CIP_*")
                If (filter.ToLower().Contains(f.Extension.ToLower())) Then
                    If FormatValide(f.Name) Then
                        t = f.Name.Split("_")
                        Code = t(1)
                        Libelle = t(2)

                        oFile = New System.IO.FileInfo(f.FullName)
                        Dim oFileStream As System.IO.FileStream = oFile.OpenRead()
                        Dim lBytes As Long = oFileStream.Length
                        If (lBytes > 0) Then
                            Dim fileData(lBytes - 1) As Byte
                            oFileStream.Read(fileData, 0, lBytes)
                            oFileStream.Close()
                            With doc
                                If Me.txtLibelle.Text.Trim() = Nothing Then
                                    .DO_Label = IO.Path.GetFileName(f.FullName)
                                Else
                                    .DO_Label = Me.txtLibelle.Text
                                End If
                                .DO_Note = Me.meNote.Text
                                .ID_Categorie = cat
                                .DO_Date = Now.Date
                                .DO_DateHeure = Now
                                .DO_extension = IO.Path.GetExtension(f.FullName)
                                .DO_Contenu = fileData
                                .DO_Info1 = f.FullName
                                .Save(True)  ' False for update.
                            End With
                            doc.AddDocumentToAssociation(doc.DO_ID, Code, DocumentService.DocumentProvider.TypeDoc.Presentation)
                            'DOC_Document_PRESTableAdapter.ImportDocument(Code, Libelle, f.FullName, System.DateTime.Now)
                            lstDetails.Items.Add(f.FullName)
                            oFile.MoveTo(f.Directory.FullName & "\\Vu_" & f.Name)
                            pgbarDocument.PerformStep()
                            pgbarDocument.Update()
                            nbImport += 1
                            lblNbImport.Text = nbImport
                        End If
                    End If
                End If
            Next

            'Me.DOC_Document_SPECTableAdapter.Fill(Me.DsTheriaqueDocument.DOC_Document_SPEC)

        Else

            MsgBox("Veuillez sélectionner un chemin")

        End If

    End Sub

    Private Function FormatValide(ByVal fName As String) As Boolean

        Dim t As String()
        t = fName.Split("_")
        If (t.Length >= 3) Then
            'If (IsNumeric(t(1))) Then
            Return True

            'End If
        End If
        Return False

    End Function

    Private Function GetNbFichierValide(ByVal path As String) As Integer

        Dim d As New DirectoryInfo(path)
        Dim max As Integer

        For Each f As FileInfo In d.GetFiles("UCD_*")

            If (FormatValide(f.Name)) Then
                max = max + 1
            End If
        Next

        For Each f As FileInfo In d.GetFiles("CIP_*")

            If (FormatValide(f.Name)) Then
                max = max + 1
            End If
        Next

        Return max

    End Function

    Private Sub Frm_ImportDirect_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim dt As New DataTable
        doc = New DocumentService.DocumentProvider(strConnexion)

        dt = doc.GetAllCategories()
        Me.lueCategorie.Properties.DataSource = dt


    End Sub
End Class