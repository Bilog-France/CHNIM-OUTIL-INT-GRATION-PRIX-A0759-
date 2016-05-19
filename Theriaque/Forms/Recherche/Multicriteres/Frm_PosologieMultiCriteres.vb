Public Class Frm_PosologieMultiCriteres 

    Public _bCPH As Boolean = False
    Public _bCCH As Boolean = False
    Public _bPR As Boolean = False
    Public _bSP As Boolean = False
    Public _bSAC As Boolean = False
    Public _bCC As Boolean = False
    Public _bVA As Boolean = False
    Public _bTERR As Boolean = False
    Public _bNIV As Boolean = False
    Public _bNAT As Boolean = False
    Public _bCOMNAT As Boolean = False
    Public _bNATDOSE As Boolean = False
    Public _bCOMTERR As Boolean = False
    Public _bUP As Boolean = False
    Public _bFREQMIN As Boolean = False
    Public _bFREQMAX As Boolean = False
    Public _bCOMFREQ As Boolean = False
    Public _bUTMIN As Boolean = False
    Public _bUTMAX As Boolean = False
    Public _bCOMDUREE As Boolean = False
    Public _bCOMADAP As Boolean = False
    Public _bCOMSURV As Boolean = False
    Public _bCOMAUTRE As Boolean = False
    Public _Validate As Boolean = False

    Private Sub Frm_PosologieMultiCriteres_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAnnuler.Click
        Me._Validate = False
        Me.Close()
    End Sub

    Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click

        Me._bCCH = Me.chkCCH.Checked
        Me._bCPH = Me.chkCPH.Checked
        Me._bPR = Me.chkPR.Checked
        Me._bSP = Me.chkSP.Checked
        Me._bSAC = Me.chkSAC.Checked
        Me._bCC = Me.chkCC.Checked
        Me._bVA = Me.chkVA.Checked
        Me._bTERR = Me.chkTERR.Checked
        Me._bNIV = Me.chkNIV.Checked
        Me._bNAT = Me.chkNAT.Checked
        Me._bCOMNAT = Me.chkCOMNAT.Checked
        Me._bNATDOSE = Me.chkNATDOSE.Checked
        Me._bCOMTERR = Me.chkCOMTERR.Checked
        Me._bUP = Me.chkUP.Checked
        Me._bFREQMIN = Me.chkFREQMIN.Checked
        Me._bFREQMAX = Me.chkFREQMAX.Checked
        Me._bCOMFREQ = Me.chkCOMFREQ.Checked
        Me._bUTMIN = Me.chkUTMIN.Checked
        Me._bUTMAX = Me.chkUTMAX.Checked
        Me._bCOMDUREE = Me.chkCOMDUREE.Checked
        Me._bCOMADAP = Me.chkCOMADAP.Checked
        Me._bCOMSURV = Me.chkCOMSURV.Checked
        Me._bCOMAUTRE = Me.chkCOMAUTRE.Checked

        Me._Validate = True
        Me.Close()
    End Sub

    Private Sub btcheckedALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcheckedALL.Click
        Me.chkCCH.Checked = True
        Me.chkCPH.Checked = True
        Me.chkPR.Checked = True
        Me.chkSP.Checked = True
        Me.chkSAC.Checked = True
        Me.chkCC.Checked = True
        Me.chkVA.Checked = True
        Me.chkTERR.Checked = True
        Me.chkNIV.Checked = True
        Me.chkNAT.Checked = True
        Me.chkCOMNAT.Checked = True
        Me.chkNATDOSE.Checked = True
        Me.chkCOMTERR.Checked = True
        Me.chkUP.Checked = True
        Me.chkFREQMIN.Checked = True
        Me.chkFREQMAX.Checked = True
        Me.chkCOMFREQ.Checked = True
        Me.chkUTMIN.Checked = True
        Me.chkUTMAX.Checked = True
        Me.chkCOMDUREE.Checked = True
        Me.chkCOMADAP.Checked = True
        Me.chkCOMSURV.Checked = True
        Me.chkCOMAUTRE.Checked = True
    End Sub

    Private Sub btNotcheckedALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNotcheckedALL.Click
        Me.chkCCH.Checked = False
        Me.chkCPH.Checked = False
        Me.chkPR.Checked = False
        Me.chkSP.Checked = False
        Me.chkSAC.Checked = False
        Me.chkCC.Checked = False
        Me.chkVA.Checked = False
        Me.chkTERR.Checked = False
        Me.chkNIV.Checked = False
        Me.chkNAT.Checked = False
        Me.chkCOMNAT.Checked = False
        Me.chkNATDOSE.Checked = False
        Me.chkCOMTERR.Checked = False
        Me.chkUP.Checked = False
        Me.chkFREQMIN.Checked = False
        Me.chkFREQMAX.Checked = False
        Me.chkCOMFREQ.Checked = False
        Me.chkUTMIN.Checked = False
        Me.chkUTMAX.Checked = False
        Me.chkCOMDUREE.Checked = False
        Me.chkCOMADAP.Checked = False
        Me.chkCOMSURV.Checked = False
        Me.chkCOMAUTRE.Checked = False
    End Sub
End Class