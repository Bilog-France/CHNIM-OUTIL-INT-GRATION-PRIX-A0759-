Public Class FrmApercu

    Public doc As DocumentService.DocumentProvider

    Private Sub FrmApercu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.WebBrowser1.Navigate(doc.Doc2file())

    End Sub

End Class