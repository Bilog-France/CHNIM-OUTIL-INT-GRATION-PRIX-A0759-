Public Class UcApercu

    Public doc As DocumentService.DocumentProvider
    Public index As Integer

    Private Sub UcApercu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Sub UpdateApercu()

        
        If (Not doc Is Nothing) Then
            Me.WebBrowser1.Navigate(doc.Doc2file(, doc.DO_extension))
        End If
       

    End Sub

    Private Sub BarbtOuvrirFiche_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarbtOuvrirFiche.ItemClick

        Dim f As New Frm_Doc_SP
        doc.cn = New SqlClient.SqlConnection(cn.sConnexion)
        f.doc = doc
        f.ShowDialog()

    End Sub

    Public Event ImDeleting()
    Private Sub barBtSupprimer_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barBtSupprimer.ItemClick

        If MessageBox.Show("Vous voulez vraiement supprimer ce document", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim fin As Boolean = False
            If (index = 0) Then

                fin = True
            End If
            If (doc IsNot Nothing) Then
                doc.Delete(doc.DO_ID)
                RaiseEvent ImDeleting()
            End If
            If (fin) Then
                Me.WebBrowser1.Stop()
            End If
        End If

    End Sub

    Private Sub BarBtImprimer_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtImprimer.ItemClick

        WebBrowser1.Print()

    End Sub

    Private Sub btnExport_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
        WebBrowser1.ShowSaveAsDialog()
    End Sub

    Private Sub BarBtRemplacer_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtRemplacer.ItemClick

        Using fod As New OpenFileDialog
            fod.Filter = "*.pdf|*.pdf|*.gif|*.jpg|*.bmp|*.png"

            If fod.ShowDialog = Windows.Forms.DialogResult.OK Then

                SaveDocument(fod.FileName)

            End If

        End Using

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
            With doc
                .DO_Date = Now.Date
                .DO_DateHeure = Now
                .DO_extension = IO.Path.GetExtension(path)
                .DO_Label = IO.Path.GetFileName(path)
                .DO_Contenu = fileData
                .ID_Categorie = 0
                .DO_Info1 = path
                .Save(False)  ' False for update.
            End With
            UpdateApercu()
            Me.Parent.Refresh()
        End If

    End Sub

End Class
