Public Class Frm_PresentationMultiCriteres
    Public _bCONT As Boolean = False
    Public _bMAT As Boolean = False
    Public _bCCOMP As Boolean = False
    Public _bCEMB As Boolean = False
    Public _bPRUNIT As Boolean = False
    Public _bTAUXVILLE As Boolean = False
    Public _bTAUXHOP As Boolean = False
    Public _bPREHOS As Boolean = False
    Public _bST As Boolean = False
    Public _bSTCOMP As Boolean = False
    Public _bSTREMB As Boolean = False
    Public _bCONDCONS As Boolean = False
    Public _bLIEUDISP As Boolean = False
    Public _bCOMDISP As Boolean = False
    Public _Validate As Boolean = False
    Private Sub Frm_PresentationMultiCriteres_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click
        Me._bCONT = Me.chkCONT.Checked
        Me._bMAT = Me.chkMAT.Checked
        Me._bCCOMP = Me.chkCCOMP.Checked
        Me._bCEMB = Me.chkCEMB.Checked
        Me._bPRUNIT = Me.chkPRUNIT.Checked
        Me._bTAUXVILLE = Me.chkTAUXVILLE.Checked
        Me._bTAUXHOP = Me.chkTAUXHOP.Checked
        Me._bPREHOS = Me.chkPREHOS.Checked
        Me._bST = Me.chkST.Checked
        Me._bSTCOMP = Me.chkSTCOMP.Checked
        Me._bSTREMB = Me.chkSTREMB.Checked
        Me._bCONDCONS = Me.chkCONDCONS.Checked
        Me._bLIEUDISP = Me.chkLIEUDISP.Checked
        Me._bCOMDISP = Me.chkCOMDISP.Checked
        Me._Validate = True
        Me.Close()
    End Sub

    Private Sub btAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAnnuler.Click
        Me._Validate = False
        Me.Close()
    End Sub

    Private Sub btcheckedALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcheckedALL.Click
        Me.chkCONT.Checked = True
        Me.chkMAT.Checked = True
        Me.chkCCOMP.Checked = True
        Me.chkCEMB.Checked = True
        Me.chkPRUNIT.Checked = True
        Me.chkTAUXVILLE.Checked = True
        Me.chkTAUXHOP.Checked = True
        Me.chkPREHOS.Checked = True
        Me.chkST.Checked = True
        Me.chkSTCOMP.Checked = True
        Me.chkSTREMB.Checked = True
        Me.chkCONDCONS.Checked = True
        Me.chkLIEUDISP.Checked = True
        Me.chkCOMDISP.Checked = True
    End Sub

    Private Sub btNotcheckedALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNotcheckedALL.Click
        Me.chkCONT.Checked = False
        Me.chkMAT.Checked = False
        Me.chkCCOMP.Checked = False
        Me.chkCEMB.Checked = False
        Me.chkPRUNIT.Checked = False
        Me.chkTAUXVILLE.Checked = False
        Me.chkTAUXHOP.Checked = False
        Me.chkPREHOS.Checked = False
        Me.chkST.Checked = False
        Me.chkSTCOMP.Checked = False
        Me.chkSTREMB.Checked = False
        Me.chkCONDCONS.Checked = False
        Me.chkLIEUDISP.Checked = False
        Me.chkCOMDISP.Checked = False
    End Sub
End Class