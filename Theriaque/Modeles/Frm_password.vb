Imports System.Xml

Public Class Frm_password

    Public _Ok As Boolean = False
    Public _SaveUser As Boolean = False

    Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click
        cn.CnInfo.User = txtUser.Text
        cn.CnInfo.Password = txtPass.Text
        _Ok = True
        _SaveUser = chkSave.Checked
        Me.Close()
    End Sub

    Private Sub btAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAnnuler.Click
        Me.Close()
    End Sub

    Private Sub Frm_password_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LabelServer.Text = ConInfo.Server
        Me.Text &= ConInfo.Server
        If txtUser.Text <> "" Then
            txtPass.Select()
        End If
    End Sub

End Class
