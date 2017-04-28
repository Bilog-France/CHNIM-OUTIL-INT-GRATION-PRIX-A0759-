<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Declinaison
    Inherits Theriaque.Frm_CNHIM

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btOk = New DevExpress.XtraEditors.SimpleButton
        Me.btAnnuler = New DevExpress.XtraEditors.SimpleButton
        Me.rgChoix = New DevExpress.XtraEditors.RadioGroup
        Me.GroupBox2.SuspendLayout()
        CType(Me.rgChoix.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btOk)
        Me.GroupBox2.Controls.Add(Me.btAnnuler)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 82)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(176, 45)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btOk
        '
        Me.btOk.Location = New System.Drawing.Point(45, 9)
        Me.btOk.Name = "btOk"
        Me.btOk.Size = New System.Drawing.Size(59, 30)
        Me.btOk.TabIndex = 1
        Me.btOk.Text = "Ok"
        '
        'btAnnuler
        '
        Me.btAnnuler.Location = New System.Drawing.Point(108, 9)
        Me.btAnnuler.Name = "btAnnuler"
        Me.btAnnuler.Size = New System.Drawing.Size(59, 30)
        Me.btAnnuler.TabIndex = 0
        Me.btAnnuler.Text = "Annuler"
        '
        'rgChoix
        '
        Me.rgChoix.Location = New System.Drawing.Point(3, 1)
        Me.rgChoix.Name = "rgChoix"
        Me.rgChoix.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Substance active "), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Excipient")})
        Me.rgChoix.Size = New System.Drawing.Size(176, 82)
        Me.rgChoix.TabIndex = 1
        '
        'Frm_Declinaison
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(182, 127)
        Me.ControlBox = False
        Me.Controls.Add(Me.rgChoix)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Frm_Declinaison"
        Me.Text = "Déclinaison"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.rgChoix.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btAnnuler As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rgChoix As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents btOk As DevExpress.XtraEditors.SimpleButton

End Class
