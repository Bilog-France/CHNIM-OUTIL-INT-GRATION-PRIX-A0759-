Public Class Frm_SauFilsMultiCriteres 
    Public _bCCH As Boolean = False
    Public _bNVEC As Boolean = False
    Public _bSAU As Boolean = False
    Public _Validate As Boolean = False
    Private Sub Frm_SauFilsMultiCriteres_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click
        Me._bCCH = Me.chkCCH.Checked
        Me._bNVEC = Me.chknVEC.Checked
        Me._bSAU = Me.chkSAU.Checked
        Me._Validate = True
        Me.Close()
    End Sub
    Private Sub btAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAnnuler.Click
        Me._Validate = False
        Me.Close()
    End Sub

    Private Sub btcheckedALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcheckedALL.Click
        Me.chkCCH.Checked = True
        Me.chknVEC.Checked = True
        Me.chkSAU.Checked = True
    End Sub

    Private Sub btNotcheckedALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNotcheckedALL.Click
        Me.chkCCH.Checked = False
        Me.chknVEC.Checked = False
        Me.chkSAU.Checked = False
    End Sub
End Class