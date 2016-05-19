Public Module ModFormulaire

    Public Sub Ctl_On(ByRef ctl As Control)
        If (TypeOf ctl Is DevExpress.XtraEditors.TextEdit) Or (TypeOf ctl Is DevExpress.XtraEditors.TextBoxMaskBox) Or (TypeOf ctl Is DevExpress.XtraEditors.LookUpEdit) Then
            ctl.Enabled = True
            ctl.BackColor = Color.White
            ctl.TabStop = True
            CType(ctl, DevExpress.XtraEditors.TextEdit).Properties.ReadOnly = False
        End If
        If (TypeOf ctl Is DevExpress.XtraGrid.GridControl) Or (TypeOf ctl Is Windows.Forms.GroupBox) Or (TypeOf ctl Is Windows.Forms.Panel) Then
            ctl.Enabled = True
            ctl.TabStop = True
        End If
        If (TypeOf ctl Is DevExpress.XtraEditors.CheckEdit) Then
            ctl.Enabled = True
            ctl.TabStop = True
            CType(ctl, DevExpress.XtraEditors.CheckEdit).Properties.ReadOnly = False
        End If
    End Sub

    Public Sub Ctl_Off(ByRef ctl As Control)
        If (TypeOf ctl Is DevExpress.XtraEditors.TextEdit) Or (TypeOf ctl Is DevExpress.XtraEditors.TextBoxMaskBox) Or (TypeOf ctl Is DevExpress.XtraEditors.LookUpEdit) Then
            ctl.Enabled = True
            ctl.BackColor = Color.Gainsboro
            ctl.TabStop = False
            CType(ctl, DevExpress.XtraEditors.TextEdit).Properties.ReadOnly = True
        End If
        If (TypeOf ctl Is DevExpress.XtraGrid.GridControl) Or (TypeOf ctl Is Windows.Forms.GroupBox) Or (TypeOf ctl Is Windows.Forms.Panel) Then
            ctl.Enabled = False
            ctl.TabStop = False
        End If
        If (TypeOf ctl Is DevExpress.XtraEditors.CheckEdit) Then
            ctl.Enabled = True
            ctl.TabStop = False
            CType(ctl, DevExpress.XtraEditors.CheckEdit).Properties.ReadOnly = True
        End If
    End Sub

    Public Sub Load_On(ByVal f As Form)
        f.Cursor = Cursors.WaitCursor
    End Sub

    Public Sub Load_Off(ByVal f As Form)
        f.Cursor = Cursors.Default
    End Sub

End Module
