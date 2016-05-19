<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_IncompatibiliteMultiCriteres
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkSP2 = New System.Windows.Forms.CheckBox
        Me.chkSP1 = New System.Windows.Forms.CheckBox
        Me.chkPR1 = New System.Windows.Forms.CheckBox
        Me.chkPR2 = New System.Windows.Forms.CheckBox
        Me.chkSAU1 = New System.Windows.Forms.CheckBox
        Me.chkSAU2 = New System.Windows.Forms.CheckBox
        Me.chkSUBAC2 = New System.Windows.Forms.CheckBox
        Me.chkSUBAC1 = New System.Windows.Forms.CheckBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.chkLUM = New System.Windows.Forms.CheckBox
        Me.chkCONT = New System.Windows.Forms.CheckBox
        Me.chkTEMP = New System.Windows.Forms.CheckBox
        Me.chkNAT = New System.Windows.Forms.CheckBox
        Me.chkDUR = New System.Windows.Forms.CheckBox
        Me.chkV2 = New System.Windows.Forms.CheckBox
        Me.chkMAT = New System.Windows.Forms.CheckBox
        Me.chkSOL = New System.Windows.Forms.CheckBox
        Me.chkV1 = New System.Windows.Forms.CheckBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btNotcheckedALL = New DevExpress.XtraEditors.SimpleButton
        Me.btcheckedALL = New DevExpress.XtraEditors.SimpleButton
        Me.btAnnuler = New DevExpress.XtraEditors.SimpleButton
        Me.btOk = New DevExpress.XtraEditors.SimpleButton
        Me.labTitre = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkSP = New System.Windows.Forms.CheckBox
        Me.chkPR = New System.Windows.Forms.CheckBox
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.BackColor = System.Drawing.Color.White
        Me.GroupControl1.AppearanceCaption.BackColor2 = System.Drawing.Color.White
        Me.GroupControl1.AppearanceCaption.BorderColor = System.Drawing.Color.White
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseBackColor = True
        Me.GroupControl1.AppearanceCaption.Options.UseBorderColor = True
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.GroupBox1)
        Me.GroupControl1.Controls.Add(Me.GroupBox2)
        Me.GroupControl1.Controls.Add(Me.GroupBox4)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 25)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(464, 442)
        Me.GroupControl1.TabIndex = 32
        Me.GroupControl1.Text = "Choisir les critères de recherche:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkSP1)
        Me.GroupBox2.Controls.Add(Me.chkPR1)
        Me.GroupBox2.Controls.Add(Me.chkSAU1)
        Me.GroupBox2.Controls.Add(Me.chkSUBAC1)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(433, 81)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Terme1"
        '
        'chkSP2
        '
        Me.chkSP2.AutoSize = True
        Me.chkSP2.Location = New System.Drawing.Point(264, 55)
        Me.chkSP2.Name = "chkSP2"
        Me.chkSP2.Size = New System.Drawing.Size(98, 17)
        Me.chkSP2.TabIndex = 18
        Me.chkSP2.Text = "Par spécialité 2"
        Me.chkSP2.UseVisualStyleBackColor = True
        '
        'chkSP1
        '
        Me.chkSP1.AutoSize = True
        Me.chkSP1.Location = New System.Drawing.Point(264, 57)
        Me.chkSP1.Name = "chkSP1"
        Me.chkSP1.Size = New System.Drawing.Size(98, 17)
        Me.chkSP1.TabIndex = 16
        Me.chkSP1.Text = "Par spécialité 1"
        Me.chkSP1.UseVisualStyleBackColor = True
        '
        'chkPR1
        '
        Me.chkPR1.AutoSize = True
        Me.chkPR1.Location = New System.Drawing.Point(264, 22)
        Me.chkPR1.Name = "chkPR1"
        Me.chkPR1.Size = New System.Drawing.Size(88, 17)
        Me.chkPR1.TabIndex = 15
        Me.chkPR1.Text = "Par produit 1"
        Me.chkPR1.UseVisualStyleBackColor = True
        '
        'chkPR2
        '
        Me.chkPR2.AutoSize = True
        Me.chkPR2.Location = New System.Drawing.Point(264, 20)
        Me.chkPR2.Name = "chkPR2"
        Me.chkPR2.Size = New System.Drawing.Size(88, 17)
        Me.chkPR2.TabIndex = 14
        Me.chkPR2.Text = "Par produit 2"
        Me.chkPR2.UseVisualStyleBackColor = True
        '
        'chkSAU1
        '
        Me.chkSAU1.AutoSize = True
        Me.chkSAU1.Location = New System.Drawing.Point(6, 53)
        Me.chkSAU1.Name = "chkSAU1"
        Me.chkSAU1.Size = New System.Drawing.Size(97, 17)
        Me.chkSAU1.TabIndex = 6
        Me.chkSAU1.Text = "Par excipient 1"
        Me.chkSAU1.UseVisualStyleBackColor = True
        '
        'chkSAU2
        '
        Me.chkSAU2.AutoSize = True
        Me.chkSAU2.Location = New System.Drawing.Point(6, 51)
        Me.chkSAU2.Name = "chkSAU2"
        Me.chkSAU2.Size = New System.Drawing.Size(97, 17)
        Me.chkSAU2.TabIndex = 5
        Me.chkSAU2.Text = "Par excipient 2"
        Me.chkSAU2.UseVisualStyleBackColor = True
        '
        'chkSUBAC2
        '
        Me.chkSUBAC2.AutoSize = True
        Me.chkSUBAC2.Location = New System.Drawing.Point(6, 20)
        Me.chkSUBAC2.Name = "chkSUBAC2"
        Me.chkSUBAC2.Size = New System.Drawing.Size(135, 17)
        Me.chkSUBAC2.TabIndex = 1
        Me.chkSUBAC2.Text = "Par substance active 2"
        Me.chkSUBAC2.UseVisualStyleBackColor = True
        '
        'chkSUBAC1
        '
        Me.chkSUBAC1.AutoSize = True
        Me.chkSUBAC1.Location = New System.Drawing.Point(6, 22)
        Me.chkSUBAC1.Name = "chkSUBAC1"
        Me.chkSUBAC1.Size = New System.Drawing.Size(135, 17)
        Me.chkSUBAC1.TabIndex = 0
        Me.chkSUBAC1.Text = "Par substance active 1"
        Me.chkSUBAC1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkLUM)
        Me.GroupBox4.Controls.Add(Me.chkCONT)
        Me.GroupBox4.Controls.Add(Me.chkTEMP)
        Me.GroupBox4.Controls.Add(Me.chkNAT)
        Me.GroupBox4.Controls.Add(Me.chkDUR)
        Me.GroupBox4.Controls.Add(Me.chkV2)
        Me.GroupBox4.Controls.Add(Me.chkMAT)
        Me.GroupBox4.Controls.Add(Me.chkSOL)
        Me.GroupBox4.Controls.Add(Me.chkV1)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(4, 233)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(432, 169)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        '
        'chkLUM
        '
        Me.chkLUM.AutoSize = True
        Me.chkLUM.Location = New System.Drawing.Point(269, 106)
        Me.chkLUM.Name = "chkLUM"
        Me.chkLUM.Size = New System.Drawing.Size(79, 17)
        Me.chkLUM.TabIndex = 15
        Me.chkLUM.Text = "Par lumière"
        Me.chkLUM.UseVisualStyleBackColor = True
        '
        'chkCONT
        '
        Me.chkCONT.AutoSize = True
        Me.chkCONT.Location = New System.Drawing.Point(9, 134)
        Me.chkCONT.Name = "chkCONT"
        Me.chkCONT.Size = New System.Drawing.Size(94, 17)
        Me.chkCONT.TabIndex = 14
        Me.chkCONT.Text = "Par contenant"
        Me.chkCONT.UseVisualStyleBackColor = True
        '
        'chkTEMP
        '
        Me.chkTEMP.AutoSize = True
        Me.chkTEMP.Location = New System.Drawing.Point(269, 78)
        Me.chkTEMP.Name = "chkTEMP"
        Me.chkTEMP.Size = New System.Drawing.Size(105, 17)
        Me.chkTEMP.TabIndex = 13
        Me.chkTEMP.Text = "Par température"
        Me.chkTEMP.UseVisualStyleBackColor = True
        '
        'chkNAT
        '
        Me.chkNAT.AutoSize = True
        Me.chkNAT.Location = New System.Drawing.Point(269, 22)
        Me.chkNAT.Name = "chkNAT"
        Me.chkNAT.Size = New System.Drawing.Size(77, 17)
        Me.chkNAT.TabIndex = 12
        Me.chkNAT.Text = "Par nature"
        Me.chkNAT.UseVisualStyleBackColor = True
        '
        'chkDUR
        '
        Me.chkDUR.AutoSize = True
        Me.chkDUR.Location = New System.Drawing.Point(269, 50)
        Me.chkDUR.Name = "chkDUR"
        Me.chkDUR.Size = New System.Drawing.Size(105, 17)
        Me.chkDUR.TabIndex = 11
        Me.chkDUR.Text = "Par durée - délai"
        Me.chkDUR.UseVisualStyleBackColor = True
        '
        'chkV2
        '
        Me.chkV2.AutoSize = True
        Me.chkV2.Location = New System.Drawing.Point(10, 78)
        Me.chkV2.Name = "chkV2"
        Me.chkV2.Size = New System.Drawing.Size(91, 17)
        Me.chkV2.TabIndex = 10
        Me.chkV2.Text = "Par vecteur 2"
        Me.chkV2.UseVisualStyleBackColor = True
        '
        'chkMAT
        '
        Me.chkMAT.AutoSize = True
        Me.chkMAT.Location = New System.Drawing.Point(10, 106)
        Me.chkMAT.Name = "chkMAT"
        Me.chkMAT.Size = New System.Drawing.Size(87, 17)
        Me.chkMAT.TabIndex = 9
        Me.chkMAT.Text = "Par matériau"
        Me.chkMAT.UseVisualStyleBackColor = True
        '
        'chkSOL
        '
        Me.chkSOL.AutoSize = True
        Me.chkSOL.Location = New System.Drawing.Point(10, 22)
        Me.chkSOL.Name = "chkSOL"
        Me.chkSOL.Size = New System.Drawing.Size(82, 17)
        Me.chkSOL.TabIndex = 8
        Me.chkSOL.Text = "Par solution"
        Me.chkSOL.UseVisualStyleBackColor = True
        '
        'chkV1
        '
        Me.chkV1.AutoSize = True
        Me.chkV1.Location = New System.Drawing.Point(10, 50)
        Me.chkV1.Name = "chkV1"
        Me.chkV1.Size = New System.Drawing.Size(91, 17)
        Me.chkV1.TabIndex = 7
        Me.chkV1.Text = "Par vecteur 1"
        Me.chkV1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btNotcheckedALL)
        Me.Panel1.Controls.Add(Me.btcheckedALL)
        Me.Panel1.Controls.Add(Me.btAnnuler)
        Me.Panel1.Controls.Add(Me.btOk)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 467)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(464, 48)
        Me.Panel1.TabIndex = 31
        '
        'btNotcheckedALL
        '
        Me.btNotcheckedALL.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btNotcheckedALL.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btNotcheckedALL.Appearance.Options.UseBackColor = True
        Me.btNotcheckedALL.Appearance.Options.UseBorderColor = True
        Me.btNotcheckedALL.Appearance.Options.UseFont = True
        Me.btNotcheckedALL.Appearance.Options.UseForeColor = True
        Me.btNotcheckedALL.Appearance.Options.UseImage = True
        Me.btNotcheckedALL.Appearance.Options.UseTextOptions = True
        Me.btNotcheckedALL.Location = New System.Drawing.Point(3, 24)
        Me.btNotcheckedALL.Name = "btNotcheckedALL"
        Me.btNotcheckedALL.Size = New System.Drawing.Size(130, 21)
        Me.btNotcheckedALL.TabIndex = 9
        Me.btNotcheckedALL.Text = "&Désélectionner tout"
        '
        'btcheckedALL
        '
        Me.btcheckedALL.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btcheckedALL.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btcheckedALL.Appearance.Options.UseBackColor = True
        Me.btcheckedALL.Appearance.Options.UseBorderColor = True
        Me.btcheckedALL.Appearance.Options.UseFont = True
        Me.btcheckedALL.Appearance.Options.UseForeColor = True
        Me.btcheckedALL.Appearance.Options.UseImage = True
        Me.btcheckedALL.Appearance.Options.UseTextOptions = True
        Me.btcheckedALL.Location = New System.Drawing.Point(3, 2)
        Me.btcheckedALL.Name = "btcheckedALL"
        Me.btcheckedALL.Size = New System.Drawing.Size(130, 21)
        Me.btcheckedALL.TabIndex = 8
        Me.btcheckedALL.Text = "&Sélectionner tout"
        '
        'btAnnuler
        '
        Me.btAnnuler.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btAnnuler.Location = New System.Drawing.Point(372, 3)
        Me.btAnnuler.Name = "btAnnuler"
        Me.btAnnuler.Size = New System.Drawing.Size(87, 36)
        Me.btAnnuler.TabIndex = 1
        Me.btAnnuler.Text = "&Annuler"
        Me.btAnnuler.ToolTip = "Annuler la déclinaison"
        '
        'btOk
        '
        Me.btOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btOk.Location = New System.Drawing.Point(279, 3)
        Me.btOk.Name = "btOk"
        Me.btOk.Size = New System.Drawing.Size(87, 36)
        Me.btOk.TabIndex = 1
        Me.btOk.Text = "&Ok"
        '
        'labTitre
        '
        Me.labTitre.BackColor = System.Drawing.Color.LightSlateGray
        Me.labTitre.Dock = System.Windows.Forms.DockStyle.Top
        Me.labTitre.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTitre.ForeColor = System.Drawing.SystemColors.Window
        Me.labTitre.Location = New System.Drawing.Point(0, 0)
        Me.labTitre.Name = "labTitre"
        Me.labTitre.Size = New System.Drawing.Size(464, 25)
        Me.labTitre.TabIndex = 30
        Me.labTitre.Text = "Incompatibilités"
        Me.labTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkSP2)
        Me.GroupBox1.Controls.Add(Me.chkSP)
        Me.GroupBox1.Controls.Add(Me.chkPR)
        Me.GroupBox1.Controls.Add(Me.chkSUBAC2)
        Me.GroupBox1.Controls.Add(Me.chkPR2)
        Me.GroupBox1.Controls.Add(Me.chkSAU2)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(433, 82)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Terme2"
        '
        'chkSP
        '
        Me.chkSP.AutoSize = True
        Me.chkSP.Location = New System.Drawing.Point(478, 18)
        Me.chkSP.Name = "chkSP"
        Me.chkSP.Size = New System.Drawing.Size(89, 17)
        Me.chkSP.TabIndex = 4
        Me.chkSP.Text = "Par spécialité"
        Me.chkSP.UseVisualStyleBackColor = True
        '
        'chkPR
        '
        Me.chkPR.AutoSize = True
        Me.chkPR.Location = New System.Drawing.Point(478, 52)
        Me.chkPR.Name = "chkPR"
        Me.chkPR.Size = New System.Drawing.Size(79, 17)
        Me.chkPR.TabIndex = 2
        Me.chkPR.Text = "Par produit"
        Me.chkPR.UseVisualStyleBackColor = True
        '
        'Frm_IncompatibiliteMultiCriteres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 515)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.labTitre)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_IncompatibiliteMultiCriteres"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recherche multicritères"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkSP2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSP1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkPR1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkPR2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSAU1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSAU2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSUBAC2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSUBAC1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkTEMP As System.Windows.Forms.CheckBox
    Friend WithEvents chkNAT As System.Windows.Forms.CheckBox
    Friend WithEvents chkDUR As System.Windows.Forms.CheckBox
    Friend WithEvents chkV2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkMAT As System.Windows.Forms.CheckBox
    Friend WithEvents chkSOL As System.Windows.Forms.CheckBox
    Friend WithEvents chkV1 As System.Windows.Forms.CheckBox
    Protected Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Protected Friend WithEvents btNotcheckedALL As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btcheckedALL As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btAnnuler As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btOk As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents labTitre As System.Windows.Forms.Label
    Friend WithEvents chkLUM As System.Windows.Forms.CheckBox
    Friend WithEvents chkCONT As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkSP As System.Windows.Forms.CheckBox
    Friend WithEvents chkPR As System.Windows.Forms.CheckBox
End Class
