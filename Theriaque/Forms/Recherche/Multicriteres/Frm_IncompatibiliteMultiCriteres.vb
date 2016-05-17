Public Class Frm_IncompatibiliteMultiCriteres 
    Public _bSUBAC1 As Boolean = False
    Public _bSAU1 As Boolean = False
    Public _bPR1 As Boolean = False
    Public _bSP1 As Boolean = False
    Public _bSUBAC2 As Boolean = False
    Public _bSAU2 As Boolean = False
    Public _bPR2 As Boolean = False
    Public _bSP2 As Boolean = False
    Public _bSOL As Boolean = False
    Public _bV1 As Boolean = False
    Public _bV2 As Boolean = False
    Public _bMAT As Boolean = False
    Public _bCONT As Boolean = False
    Public _bNAT As Boolean = False
    Public _bDUR As Boolean = False
    Public _bTEMP As Boolean = False
    Public _bLUM As Boolean = False
    Public _Validate As Boolean = False
    Private Sub Frm_IncompatibiliteMultiCriteres_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click
        Me._bSUBAC1 = Me.chkSUBAC1.Checked
        Me._bSAU1 = Me.chkSAU1.Checked
        Me._bPR1 = Me.chkPR1.Checked
        Me._bSP1 = Me.chkSP1.Checked
        Me._bSUBAC2 = Me.chkSUBAC2.Checked
        Me._bSAU2 = Me.chkSAU2.Checked
        Me._bPR2 = Me.chkPR2.Checked
        Me._bSP2 = Me.chkSP2.Checked
        Me._bSOL = Me.chkSOL.Checked
        Me._bV1 = Me.chkV1.Checked
        Me._bV2 = Me.chkV2.Checked
        Me._bMAT = Me.chkMAT.Checked
        Me._bCONT = Me.chkCONT.Checked
        Me._bNAT = Me.chkNAT.Checked
        Me._bDUR = Me.chkDUR.Checked
        Me._bTEMP = Me.chkTEMP.Checked
        Me._bLUM = Me.chkLUM.Checked

        Me._Validate = True
        Me.Close()
    End Sub

    Private Sub btAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAnnuler.Click
        Me._Validate = False
        Me.Close()
    End Sub

    Private Sub btcheckedALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcheckedALL.Click
        Me.chkSUBAC1.Checked = True
        Me.chkSAU1.Checked = True
        Me.chkPR1.Checked = True
        Me.chkSP1.Checked = True
        Me.chkSUBAC2.Checked = True
        Me.chkSAU2.Checked = True
        Me.chkPR2.Checked = True
        Me.chkSP2.Checked = True
        Me.chkSOL.Checked = True
        Me.chkV1.Checked = True
        Me.chkV2.Checked = True
        Me.chkMAT.Checked = True
        Me.chkCONT.Checked = True
        Me.chkNAT.Checked = True
        Me.chkDUR.Checked = True
        Me.chkTEMP.Checked = True
        Me.chkLUM.Checked = True
    End Sub

    Private Sub btNotcheckedALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNotcheckedALL.Click
        Me.chkSUBAC1.Checked = False
        Me.chkSAU1.Checked = False
        Me.chkPR1.Checked = False
        Me.chkSP1.Checked = False
        Me.chkSUBAC2.Checked = False
        Me.chkSAU2.Checked = False
        Me.chkPR2.Checked = False
        Me.chkSP2.Checked = False
        Me.chkSOL.Checked = False
        Me.chkV1.Checked = False
        Me.chkV2.Checked = False
        Me.chkMAT.Checked = False
        Me.chkCONT.Checked = False
        Me.chkNAT.Checked = False
        Me.chkDUR.Checked = False
        Me.chkTEMP.Checked = False
        Me.chkLUM.Checked = False
    End Sub
End Class