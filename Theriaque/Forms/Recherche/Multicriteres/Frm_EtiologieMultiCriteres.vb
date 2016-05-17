Public Class Frm_EtiologieMultiCriteres 
    Public _bEHS As Boolean = False
    Public _bEIS As Boolean = False
    Public _bEMS As Boolean = False
    Public _bER As Boolean = False
    Public _bPR As Boolean = False
    Public _bSP As Boolean = False
    Public _bSAC As Boolean = False
    Public _Validate As Boolean = False
    Private Sub Frm_EtiologieMultiCriteres_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click
        Me._bEHS = Me.chkEHS.Checked
        Me._bEIS = Me.chkEIS.Checked
        Me._bEMS = Me.chkEMS.Checked
        Me._bER = Me.chkER.Checked
        Me._bPR = Me.chkPR.Checked
        Me._bSP = Me.chkSP.Checked
        Me._bSAC = Me.chkSAC.Checked
        Me._Validate = True
        Me.Close()
    End Sub

    Private Sub btAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAnnuler.Click
        Me._Validate = False
        Me.Close()
    End Sub

    Private Sub btcheckedALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcheckedALL.Click
        Me.chkEHS.Checked = True
        Me.chkEIS.Checked = True
        Me.chkEMS.Checked = True
        Me.chkER.Checked = True
        Me.chkPR.Checked = True
        Me.chkSP.Checked = True
        Me.chkSAC.Checked = True
    End Sub

    Private Sub btNotcheckedALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNotcheckedALL.Click
        Me.chkEHS.Checked = False
        Me.chkEIS.Checked = False
        Me.chkEMS.Checked = False
        Me.chkER.Checked = False
        Me.chkPR.Checked = False
        Me.chkSP.Checked = False
        Me.chkSAC.Checked = False
    End Sub
End Class