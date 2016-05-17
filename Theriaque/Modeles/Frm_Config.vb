Imports System.Xml

Public Class Frm_Config
    Private XMLStruct As New XmlDocument

    Private Sub Frm_Config_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim root As XmlNode
        'XMLStruct.Load("app.config")
        'root = XMLStruct.DocumentElement
        txtServeur.Text = cn.CnInfo.Server  'root.Item("connexion").Item("server").InnerText
        txtDB.Text = cn.CnInfo.DateBase 'root.'Item("connexion").Item("database").InnerText
    End Sub

    Private Sub btAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAnnuler.Click
        Me.Close()
    End Sub

    Private Sub btValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btValider.Click

        cn.CnInfo.Server = txtServeur.Text
        cn.CnInfo.DateBase = txtDB.Text
        'XMLStruct.ChildNodes(0).ChildNodes(0).ChildNodes(0).InnerText = txtServeur.Text
        'XMLStruct.ChildNodes(0).ChildNodes(0).ChildNodes(1).InnerText = txtDB.Text
        'XMLStruct.Save("app.config")
        Me.Close()

    End Sub

    Private Sub txtServeur_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtServeur.SelectedIndexChanged

    End Sub
End Class
