Public Class Frm_ConducteurMultiCriteres
    Public _bCCH As Boolean = False
    Public _bCOM As Boolean = False
    Public _bCPH As Boolean = False
    Public _bPR As Boolean = False
    Public _bREC As Boolean = False
    Public _bSAC As Boolean = False
    Public _bSAU As Boolean = False
    Public _bSP As Boolean = False
    Public _Validate As Boolean = False

    Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click
        Me._bCCH = Me.chkCCH.Checked
        Me._bCOM = Me.chkCOM.Checked
        Me._bCPH = Me.chkCPH.Checked
        Me._bPR = Me.chkPR.Checked
        Me._bREC = Me.chkREC.Checked
        Me._bSAC = Me.chkSAC.Checked
        Me._bSAU = Me.chkSAU.Checked
        Me._bSP = Me.chkSP.Checked
        Me._Validate = True
        Me.Close()
    End Sub

    Private Sub btAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAnnuler.Click
        Me._Validate = False
        Me.Close()
    End Sub

    Private Sub Frm_ConducteurMultiCriteres_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btcheckedALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcheckedALL.Click
        Me.chkCCH.Checked = True
        Me.chkCOM.Checked = True
        Me.chkCPH.Checked = True
        Me.chkPR.Checked = True
        Me.chkREC.Checked = True
        Me.chkSAC.Checked = True
        Me.chkSAU.Checked = True
        Me.chkSP.Checked = True
    End Sub

    Private Sub btNotcheckedALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNotcheckedALL.Click
        Me.chkCCH.Checked = False
        Me.chkCOM.Checked = False
        Me.chkCPH.Checked = False
        Me.chkPR.Checked = False
        Me.chkREC.Checked = False
        Me.chkSAC.Checked = False
        Me.chkSAU.Checked = False
        Me.chkSP.Checked = False
    End Sub

    
End Class