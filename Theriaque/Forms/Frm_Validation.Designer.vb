<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Validation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Validation))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.btFermer = New DevExpress.XtraEditors.SimpleButton
        Me.btValider = New DevExpress.XtraEditors.SimpleButton
        Me.RG = New DevExpress.XtraEditors.RadioGroup
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.RG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(589, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Validation"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.btFermer)
        Me.GroupControl1.Controls.Add(Me.btValider)
        Me.GroupControl1.Controls.Add(Me.RG)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 115)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(589, 184)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Valider ce soir"
        '
        'btFermer
        '
        Me.btFermer.Image = CType(resources.GetObject("btFermer.Image"), System.Drawing.Image)
        Me.btFermer.Location = New System.Drawing.Point(290, 146)
        Me.btFermer.Name = "btFermer"
        Me.btFermer.Size = New System.Drawing.Size(87, 27)
        ToolTipItem1.Text = "F7: Annuler les modifications"
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btFermer.SuperTip = SuperToolTip1
        Me.btFermer.TabIndex = 4
        Me.btFermer.Text = "&Fermer"
        '
        'btValider
        '
        Me.btValider.Image = CType(resources.GetObject("btValider.Image"), System.Drawing.Image)
        Me.btValider.Location = New System.Drawing.Point(182, 146)
        Me.btValider.Name = "btValider"
        Me.btValider.Size = New System.Drawing.Size(87, 27)
        ToolTipItem2.Text = "F10: Valider la saisie"
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.btValider.SuperTip = SuperToolTip2
        Me.btValider.TabIndex = 3
        Me.btValider.Text = "&Ok"
        '
        'RG
        '
        Me.RG.Dock = System.Windows.Forms.DockStyle.Top
        Me.RG.Location = New System.Drawing.Point(2, 26)
        Me.RG.Name = "RG"
        Me.RG.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Oui", "Oui"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Non", "Non")})
        Me.RG.Size = New System.Drawing.Size(585, 76)
        Me.RG.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 42)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(589, 73)
        Me.PanelControl1.TabIndex = 3
        Me.PanelControl1.Text = "PanelControl1"
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(585, 58)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(585, 11)
        Me.Label3.TabIndex = 3
        '
        'Frm_Validation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(589, 299)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MinimizeBox = False
        Me.Name = "Frm_Validation"
        Me.Text = "Validation"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.RG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents RG As DevExpress.XtraEditors.RadioGroup
    Protected Friend WithEvents btValider As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btFermer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
