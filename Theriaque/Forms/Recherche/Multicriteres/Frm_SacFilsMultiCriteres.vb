Public Class Frm_SacFilsMultiCriteres 
    Public _bCCH As Boolean = False
    Public _bCPH As Boolean = False
    Public _bATC As Boolean = False
    Public _bSAC As Boolean = False
    Public _bCodeRef As Boolean = False
    Public _bLibRef As Boolean = False
    Public _bTypeRef As Boolean = False
    Public _bCodeCAS As Boolean = False
    Public _Validate As Boolean = False
    Private Sub Frm_SacFilsMultiCriteres_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click
        Me._bCCH = Me.chkCCH.Checked
        Me._bCPH = Me.chkCPH.Checked
        Me._bSAC = Me.chkSAC.Checked
        Me._bATC = Me.chkATC.Checked
        Me._bCodeRef = Me.chkCodeRef.Checked
        Me._bLibRef = Me.ChkLibRef.Checked
        Me._bTypeRef = Me.ChkTypeRef.Checked
        Me._bCodeCAS = Me.chkCodeCAS.Checked
        Me._Validate = True
        Me.Close()
    End Sub
    Private Sub btAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAnnuler.Click
        Me._Validate = False
        Me.Close()
    End Sub

    Private Sub btcheckedALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcheckedALL.Click
        Me.chkCCH.Checked = True
        Me.chkCPH.Checked = True
        Me.chkSAC.Checked = True
        Me.chkATC.Checked = True
        Me.chkCodeRef.Checked = True
        Me.ChkLibRef.Checked = True
        Me.ChkTypeRef.Checked = True
        Me.chkCodeCAS.Checked = True
    End Sub

    Private Sub btNotcheckedALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNotcheckedALL.Click
        Me.chkCCH.Checked = False
        Me.chkCPH.Checked = False
        Me.chkSAC.Checked = False
        Me.chkATC.Checked = False
        Me.chkCodeRef.Checked = False
        Me.ChkLibRef.Checked = False
        Me.ChkTypeRef.Checked = False
        Me.chkCodeCAS.Checked = False
    End Sub
End Class