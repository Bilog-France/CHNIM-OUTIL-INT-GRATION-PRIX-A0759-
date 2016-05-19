Public Class Frm_EffetsIndesirablesMultiCriteres 
    Public _bCCH As Boolean = False
    Public _bCPH As Boolean = False
    Public _bPR As Boolean = False
    Public _bSAC As Boolean = False
    Public _bSAU As Boolean = False
    Public _bSP As Boolean = False
    Public _bCC As Boolean = False
    Public _bOC As Boolean = False
    Public _bDTNC As Boolean = False
    Public _bDTNP As Boolean = False
    Public _bDTNCOM As Boolean = False
    Public _bDTTF As Boolean = False
    Public _bDTACIRC As Boolean = False
    Public _bDTMS As Boolean = False
    Public _bDTCCOM As Boolean = False
    Public _bCSNC As Boolean = False
    Public _bCSNP As Boolean = False
    Public _bCSNCOM As Boolean = False
    Public _bCSCCOM As Boolean = False
    Public _Validate As Boolean = False
    Private Sub Frm_EffetsIndesirablesMultiCriteres_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click
        Me._bCCH = Me.chkCCH.Checked
        Me._bCPH = Me.chkCPH.Checked
        Me._bPR = Me.chkPR.Checked
        Me._bSAC = Me.chkSAC.Checked
        Me._bSAU = Me.chkSAU.Checked
        Me._bSP = Me.chkSP.Checked
        Me._bCC = Me.chkCC.Checked
        Me._bOC = Me.chkOC.Checked
        Me._bDTNC = Me.chkDTNC.Checked
        Me._bDTNP = Me.chkDTNP.Checked
        Me._bDTNCOM = Me.chkDTNCOM.Checked
        Me._bDTTF = Me.chkDTTF.Checked
        Me._bDTACIRC = Me.chkDTACIRC.Checked
        Me._bDTMS = Me.chkDTMS.Checked
        Me._bDTCCOM = Me.chkDTCCOM.Checked
        Me._bCSNC = Me.chkCSNC.Checked
        Me._bCSNP = Me.chkCSNP.Checked
        Me._bCSNCOM = Me.chkCSNCOM.Checked
        Me._bCSCCOM = Me.chkCSCCOM.Checked
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
        Me.chkPR.Checked = True
        Me.chkSAC.Checked = True
        Me.chkSAU.Checked = True
        Me.chkSP.Checked = True
        Me.chkCC.Checked = True
        Me.chkOC.Checked = True
        Me.chkDTNC.Checked = True
        Me.chkDTNP.Checked = True
        Me.chkDTNCOM.Checked = True
        Me.chkDTTF.Checked = True
        Me.chkDTACIRC.Checked = True
        Me.chkDTMS.Checked = True
        Me.chkDTCCOM.Checked = True
        Me.chkCSNC.Checked = True
        Me.chkCSNP.Checked = True
        Me.chkCSNCOM.Checked = True
        Me.chkCSCCOM.Checked = True
    End Sub

    Private Sub btNotcheckedALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNotcheckedALL.Click
        Me.chkCCH.Checked = False
        Me.chkCPH.Checked = False
        Me.chkPR.Checked = False
        Me.chkSAC.Checked = False
        Me.chkSAU.Checked = False
        Me.chkSP.Checked = False
        Me.chkCC.Checked = False
        Me.chkOC.Checked = False
        Me.chkDTNC.Checked = False
        Me.chkDTNP.Checked = False
        Me.chkDTNCOM.Checked = False
        Me.chkDTTF.Checked = False
        Me.chkDTACIRC.Checked = False
        Me.chkDTMS.Checked = False
        Me.chkDTCCOM.Checked = False
        Me.chkCSNC.Checked = False
        Me.chkCSNP.Checked = False
        Me.chkCSNCOM.Checked = False
        Me.chkCSCCOM.Checked = False
    End Sub
End Class