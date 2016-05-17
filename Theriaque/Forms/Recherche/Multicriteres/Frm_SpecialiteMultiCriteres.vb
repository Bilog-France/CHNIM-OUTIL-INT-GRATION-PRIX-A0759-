Public Class Frm_SpecialiteMultiCriteres 
    Public _bSP As Boolean = False
    Public _bPR As Boolean = False
    Public _bCIS As Boolean = False
    Public _bCOMP As Boolean = False
    Public _bEPH As Boolean = False
    Public _bLIST As Boolean = False
    Public _bLABO As Boolean = False
    Public _bSTLABO As Boolean = False
    Public _bLABOEXP As Boolean = False
    Public _bCPH As Boolean = False
    Public _bCGESTION As Boolean = False
    Public _bPRES As Boolean = False
    Public _bVA As Boolean = False
    Public _bFPH As Boolean = False
    Public _bCOMPFORM As Boolean = False
    Public _bATC As Boolean = False
    Public _bCC As Boolean = False
    Public _bSUBAC As Boolean = False
    Public _bSUBACUNITE As Boolean = False
    Public _bSUBAU As Boolean = False
    Public _bSUBAUUNITE As Boolean = False
    Public _bTENEUR As Boolean = False
    Public _bTENEURUNITE As Boolean = False
    Public _bTENEUREQUIV As Boolean = False
    Public _Validate As Boolean = False
    Private Sub Frm_SpecialiteMultiCriteres_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click
        Me._bSP = Me.chkSP.Checked
        Me._bPR = Me.chkPR.Checked
        Me._bCIS = Me.chkCIS.Checked
        Me._bCOMP = Me.chkCOMP.Checked
        Me._bEPH = Me.chkEPH.Checked
        Me._bLIST = Me.chkLIST.Checked
        Me._bLABO = Me.chkLABO.Checked
        Me._bSTLABO = Me.chkSTLABO.Checked
        Me._bLABOEXP = Me.chkLABOEXP.Checked
        Me._bCPH = Me.chkCPH.Checked
        Me._bCGESTION = Me.chkCGESTION.Checked
        Me._bPRES = Me.chkPRES.Checked
        Me._bVA = Me.chkVA.Checked
        Me._bFPH = Me.chkFPH.Checked
        Me._bCOMPFORM = Me.chkCOMPFORM.Checked
        Me._bATC = Me.chkATC.Checked
        Me._bCC = Me.chkCC.Checked
        Me._bSUBAC = Me.chkSUBAC.Checked
        Me._bSUBACUNITE = Me.chkSUBACUNITE.Checked
        Me._bSUBAU = Me.chkSUBAU.Checked
        Me._bSUBAUUNITE = Me.chkSUBAUUNITE.Checked
        Me._bTENEUR = Me.chkTENEUR.Checked
        Me._bTENEURUNITE = Me.chkTENEURUNITE.Checked
        Me._bTENEUREQUIV = Me.chkTENEUREQUIV.Checked
        Me._Validate = True
        Me.Close()
    End Sub

    Private Sub btAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAnnuler.Click
        Me._Validate = False
        Me.Close()
    End Sub

    Private Sub btcheckedALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcheckedALL.Click
        Me.chkSP.Checked = True
        Me.chkPR.Checked = True
        Me.chkCIS.Checked = True
        Me.chkCOMP.Checked = True
        Me.chkEPH.Checked = True
        Me.chkLIST.Checked = True
        Me.chkLABO.Checked = True
        Me.chkSTLABO.Checked = True
        Me.chkLABOEXP.Checked = True
        Me.chkCPH.Checked = True
        Me.chkCGESTION.Checked = True
        Me.chkPRES.Checked = True
        Me.chkVA.Checked = True
        Me.chkFPH.Checked = True
        Me.chkCOMPFORM.Checked = True
        Me.chkATC.Checked = True
        Me.chkCC.Checked = True
        Me.chkSUBAC.Checked = True
        Me.chkSUBACUNITE.Checked = True
        Me.chkSUBAU.Checked = True
        Me.chkSUBAUUNITE.Checked = True
        Me.chkTENEUR.Checked = True
        Me.chkTENEURUNITE.Checked = True
        Me.chkTENEUREQUIV.Checked = True
    End Sub

    Private Sub btNotcheckedALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNotcheckedALL.Click
        Me.chkSP.Checked = False
        Me.chkPR.Checked = False
        Me.chkCIS.Checked = False
        Me.chkCOMP.Checked = False
        Me.chkEPH.Checked = False
        Me.chkLIST.Checked = False
        Me.chkLABO.Checked = False
        Me.chkSTLABO.Checked = False
        Me.chkLABOEXP.Checked = False
        Me.chkCPH.Checked = False
        Me.chkCGESTION.Checked = False
        Me.chkPRES.Checked = False
        Me.chkVA.Checked = False
        Me.chkFPH.Checked = False
        Me.chkCOMPFORM.Checked = False
        Me.chkATC.Checked = False
        Me.chkCC.Checked = False
        Me.chkSUBAC.Checked = False
        Me.chkSUBACUNITE.Checked = False
        Me.chkSUBAU.Checked = False
        Me.chkSUBAUUNITE.Checked = False
        Me.chkTENEUR.Checked = False
        Me.chkTENEURUNITE.Checked = False
        Me.chkTENEUREQUIV.Checked = False
    End Sub
End Class