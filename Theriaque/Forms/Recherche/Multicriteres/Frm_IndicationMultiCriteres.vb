Public Class Frm_IndicationMultiCriteres
    Public _bCPH As Boolean = False
    Public _bCCH As Boolean = False
    Public _bPR As Boolean = False
    Public _bSP As Boolean = False
    Public _bSAC As Boolean = False
    Public _bCC As Boolean = False
    Public _bNIV As Boolean = False
    Public _bNAT As Boolean = False
    Public _bCOMNAT As Boolean = False
    Public _bAGETIO As Boolean = False
    Public _bCOM As Boolean = False
    Public _Validate As Boolean = False

    Private Sub Frm_IndicationMultiCriteres_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click
        Me._bCCH = Me.chkCCH.Checked
        Me._bCPH = Me.chkCPH.Checked
        Me._bPR = Me.chkPR.Checked
        Me._bSP = Me.chkSP.Checked
        Me._bSAC = Me.chkSAC.Checked
        Me._bCC = Me.chkCC.Checked
        Me._bNIV = Me.chkNIV.Checked
        Me._bNAT = Me.chkNAT.Checked
        Me._bCOMNAT = Me.chkCOMNAT.Checked
        Me._bAGETIO = Me.chkAGETIO.Checked
        Me._bCOM = Me.chkCOM.Checked
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
        Me.chkSP.Checked = True
        Me.chkSAC.Checked = True
        Me.chkCC.Checked = True
        Me.chkNIV.Checked = True
        Me.chkNAT.Checked = True
        Me.chkCOMNAT.Checked = True
        Me.chkAGETIO.Checked = True
        Me.chkCOM.Checked = True
    End Sub

    Private Sub btNotcheckedALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNotcheckedALL.Click
        Me.chkCCH.Checked = False
        Me.chkCPH.Checked = False
        Me.chkPR.Checked = False
        Me.chkSP.Checked = False
        Me.chkSAC.Checked = False
        Me.chkCC.Checked = False
        Me.chkNIV.Checked = False
        Me.chkNAT.Checked = False
        Me.chkCOMNAT.Checked = False
        Me.chkAGETIO.Checked = False
        Me.chkCOM.Checked = False
    End Sub
End Class