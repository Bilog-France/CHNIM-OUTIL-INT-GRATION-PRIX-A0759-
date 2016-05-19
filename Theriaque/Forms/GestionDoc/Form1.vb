Public Class Form1
    Private doc As DocumentService.DocumentProvider
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        doc = New DocumentService.DocumentProvider(cn.sConnexion)
        Dim dt As New DataTable
        dt = doc.GetAllCategories()
        Me.lueCategorie.Properties.DataSource = dt
        Me.lueCategorie.DataBindings.Add("EditValue", dt, "ID_Categorie")
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.lueCategorie.EditValue = CInt(Me.txtLibelle.Text)
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        MsgBox(Me.lueCategorie.EditValue)
    End Sub
End Class