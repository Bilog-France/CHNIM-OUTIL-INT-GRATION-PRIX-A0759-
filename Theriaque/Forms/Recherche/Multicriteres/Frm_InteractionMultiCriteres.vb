Public Class Frm_InteractionMultiCriteres 
    Public _bCPH1 As Boolean = False
    Public _bCCH1 As Boolean = False
    Public _bCOM1 As Boolean = False
    Public _bSUBAC1 As Boolean = False
    Public _bSAU1 As Boolean = False
    Public _bPR1 As Boolean = False
    Public _bSP1 As Boolean = False
    Public _bCPH2 As Boolean = False
    Public _bCCH2 As Boolean = False
    Public _bCOM2 As Boolean = False
    Public _bSUBAC2 As Boolean = False
    Public _bSAU2 As Boolean = False
    Public _bPR2 As Boolean = False
    Public _bSP2 As Boolean = False
    Public _bV1 As Boolean = False
    Public _bD1 As Boolean = False
    Public _bV2 As Boolean = False
    Public _bD2 As Boolean = False
    Public _bNIVVALD As Boolean = False
    Public _bNIVINTER As Boolean = False
    Public _bTYPEINTER As Boolean = False
    Public _bSENSINTER As Boolean = False
    Public _bTERR As Boolean = False
    Public _bCOMTERR As Boolean = False
    Public _bCC As Boolean = False
    Public _bREF As Boolean = False
    Public _Validate As Boolean = False
    Private Sub Frm_InteractionMultiCriteres_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click
        Me._bCPH1 = Me.chkCPH1.Checked
        Me._bCCH1 = Me.chkCCH1.Checked
        Me._bCOM1 = Me.chkCOM1.Checked
        Me._bSUBAC1 = Me.chkSUBAC1.Checked
        Me._bSAU1 = Me.chkSAU1.Checked
        Me._bPR1 = Me.chkPR1.Checked
        Me._bSP1 = Me.chkSP1.Checked
        Me._bCPH2 = Me.chkCPH2.Checked
        Me._bCCH2 = Me.chkCCH2.Checked
        Me._bCOM2 = Me.chkCOM2.Checked
        Me._bSUBAC2 = Me.chkSUBAC2.Checked
        Me._bSAU2 = Me.chkSAU2.Checked
        Me._bPR2 = Me.chkPR2.Checked
        Me._bSP2 = Me.chkSP2.Checked
        Me._bV1 = Me.chkV1.Checked
        Me._bD1 = Me.chkD1.Checked
        Me._bV2 = Me.chkV2.Checked
        Me._bD2 = Me.chkD2.Checked
        Me._bNIVVALD = Me.chkNIVVALD.Checked
        Me._bNIVINTER = Me.chkNIVINTER.Checked
        Me._bTYPEINTER = Me.chkTYPEINTER.Checked
        Me._bSENSINTER = Me.chkSENSINTER.Checked
        Me._bTERR = Me.chkTERR.Checked
        Me._bCOMTERR = Me.chkCOMTERR.Checked
        Me._bCC = Me.chkCC.Checked
        Me._bREF = Me.chkREF.Checked

        Me._Validate = True
        Me.Close()
    End Sub

    Private Sub btAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAnnuler.Click
        Me._Validate = False
        Me.Close()
    End Sub

    Private Sub btcheckedALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcheckedALL.Click
        Me.chkCPH1.Checked = True
        Me.chkCCH1.Checked = True
        Me.chkCOM1.Checked = True
        Me.chkSUBAC1.Checked = True
        Me.chkSAU1.Checked = True
        Me.chkPR1.Checked = True
        Me.chkSP1.Checked = True
        Me.chkCPH2.Checked = True
        Me.chkCCH2.Checked = True
        Me.chkCOM2.Checked = True
        Me.chkSUBAC2.Checked = True
        Me.chkSAU2.Checked = True
        Me.chkPR2.Checked = True
        Me.chkSP2.Checked = True
        Me.chkV1.Checked = True
        Me.chkD1.Checked = True
        Me.chkV2.Checked = True
        Me.chkD2.Checked = True
        Me.chkNIVVALD.Checked = True
        Me.chkNIVINTER.Checked = True
        Me.chkTYPEINTER.Checked = True
        Me.chkSENSINTER.Checked = True
        Me.chkTERR.Checked = True
        Me.chkCOMTERR.Checked = True
        Me.chkCC.Checked = True
        Me.chkREF.Checked = True
    End Sub

    Private Sub btNotcheckedALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNotcheckedALL.Click
        Me.chkCPH1.Checked = False
        Me.chkCCH1.Checked = False
        Me.chkCOM1.Checked = False
        Me.chkSUBAC1.Checked = False
        Me.chkSAU1.Checked = False
        Me.chkPR1.Checked = False
        Me.chkSP1.Checked = False
        Me.chkCPH2.Checked = False
        Me.chkCCH2.Checked = False
        Me.chkCOM2.Checked = False
        Me.chkSUBAC2.Checked = False
        Me.chkSAU2.Checked = False
        Me.chkPR2.Checked = False
        Me.chkSP2.Checked = False
        Me.chkV1.Checked = False
        Me.chkD1.Checked = False
        Me.chkV2.Checked = False
        Me.chkD2.Checked = False
        Me.chkNIVVALD.Checked = False
        Me.chkNIVINTER.Checked = False
        Me.chkTYPEINTER.Checked = False
        Me.chkSENSINTER.Checked = False
        Me.chkTERR.Checked = False
        Me.chkCOMTERR.Checked = False
        Me.chkCC.Checked = False
        Me.chkREF.Checked = False
    End Sub
End Class