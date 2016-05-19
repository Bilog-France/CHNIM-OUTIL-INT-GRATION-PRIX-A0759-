Public Class Frm_Declinaison
    Public _Ok As Boolean = False

    Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click
        _Ok = True
        Me.Close()
    End Sub

    Private Sub btAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAnnuler.Click
        _Ok = False
        Me.Close()
    End Sub
End Class
