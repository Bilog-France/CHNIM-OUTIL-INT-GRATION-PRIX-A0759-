Public Class Frm_GrossAllaitementMultiCriteres 

    Public _bCCH As Boolean = False
    Public _bCPH As Boolean = False
    Public _bPR As Boolean = False
    Public _bSAC As Boolean = False
    Public _bSAU As Boolean = False
    Public _bSP As Boolean = False
    Public _bGrdeCIRFAVO As Boolean = False
    Public _bRISANIMAL As Boolean = False
    Public _bFEMENCE As Boolean = False
    Public _bNOUVNE As Boolean = False
    Public _bGrrecREC As Boolean = False
    Public _bPERCONC As Boolean = False
    Public _bPERCRI As Boolean = False
    Public _bOBSESPEC As Boolean = False
    Public _bGrdcCIRFAVO As Boolean = False
    Public _bRISHOMME As Boolean = False
    Public _bFEMCONDTENIR As Boolean = False
    Public _bFemapREC As Boolean = False
    Public _bAllOBSER As Boolean = False
    Public _bAllocnCIRFAVO As Boolean = False
    Public _bAllREC As Boolean = False
    Public _bALLCONDTENIR As Boolean = False
    Public _Validate As Boolean = False

    Private Sub Frm_GrossAllaitementMultiCriteres_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
        Me._bGrdeCIRFAVO = Me.chkGrdeCIRFAVO.Checked
        Me._bRISANIMAL = Me.chkRISANIMAL.Checked
        Me._bFEMENCE = Me.chkFEMENCE.Checked
        Me._bNOUVNE = Me.chkNOUVNE.Checked
        Me._bGrrecREC = Me.chkGrrecREC.Checked
        Me._bPERCONC = Me.chkPERCONC.Checked
        Me._bPERCRI = Me.chkPERCRI.Checked
        Me._bOBSESPEC = Me.chkOBSESPEC.Checked
        Me._bGrdcCIRFAVO = Me.chkGrdcCIRFAVO.Checked
        Me._bRISHOMME = Me.chkRISHOMME.Checked
        Me._bFEMCONDTENIR = Me.chkFEMCONDTENIR.Checked
        Me._bFemapREC = Me.chkFemapREC.Checked
        Me._bAllOBSER = Me.chkAllOBSER.Checked
        Me._bAllocnCIRFAVO = Me.chkAllocnCIRFAVO.Checked
        Me._bAllREC = Me.chkAllREC.Checked
        Me._bALLCONDTENIR = Me.chkALLCONDTENIR.Checked

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
        Me.chkGrdeCIRFAVO.Checked = True
        Me.chkRISANIMAL.Checked = True
        Me.chkFEMENCE.Checked = True
        Me.chkNOUVNE.Checked = True
        Me.chkGrrecREC.Checked = True
        Me.chkPERCONC.Checked = True
        Me.chkPERCRI.Checked = True
        Me.chkOBSESPEC.Checked = True
        Me.chkGrdcCIRFAVO.Checked = True
        Me.chkRISHOMME.Checked = True
        Me.chkFEMCONDTENIR.Checked = True
        Me.chkFemapREC.Checked = True
        Me.chkAllOBSER.Checked = True
        Me.chkAllocnCIRFAVO.Checked = True
        Me.chkAllREC.Checked = True
        Me.chkALLCONDTENIR.Checked = True
    End Sub

    Private Sub btNotcheckedALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNotcheckedALL.Click
        Me.chkCCH.Checked = False
        Me.chkCPH.Checked = False
        Me.chkPR.Checked = False
        Me.chkSAC.Checked = False
        Me.chkSAU.Checked = False
        Me.chkSP.Checked = False
        Me.chkGrdeCIRFAVO.Checked = False
        Me.chkRISANIMAL.Checked = False
        Me.chkFEMENCE.Checked = False
        Me.chkNOUVNE.Checked = False
        Me.chkGrrecREC.Checked = False
        Me.chkPERCONC.Checked = False
        Me.chkPERCRI.Checked = False
        Me.chkOBSESPEC.Checked = False
        Me.chkGrdcCIRFAVO.Checked = False
        Me.chkRISHOMME.Checked = False
        Me.chkFEMCONDTENIR.Checked = False
        Me.chkFemapREC.Checked = False
        Me.chkAllOBSER.Checked = False
        Me.chkAllocnCIRFAVO.Checked = False
        Me.chkAllREC.Checked = False
        Me.chkALLCONDTENIR.Checked = False
    End Sub
End Class