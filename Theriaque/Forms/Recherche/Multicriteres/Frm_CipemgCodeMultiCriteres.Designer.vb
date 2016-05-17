<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CipemgCodeMultiCriteres
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
        Me.chkCOM = New System.Windows.Forms.CheckBox
        Me.chkNIV = New System.Windows.Forms.CheckBox
        Me.chkCOMAUTRE = New System.Windows.Forms.CheckBox
        Me.chkTERR = New System.Windows.Forms.CheckBox
        Me.chkCC = New System.Windows.Forms.CheckBox
        Me.chkSAC = New System.Windows.Forms.CheckBox
        Me.chkSAU = New System.Windows.Forms.CheckBox
        Me.chkSP = New System.Windows.Forms.CheckBox
        Me.chkPR = New System.Windows.Forms.CheckBox
        Me.chkCCH = New System.Windows.Forms.CheckBox
        Me.chkCPH = New System.Windows.Forms.CheckBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btNotcheckedALL = New DevExpress.XtraEditors.SimpleButton
        Me.btcheckedALL = New DevExpress.XtraEditors.SimpleButton
        Me.btAnnuler = New DevExpress.XtraEditors.SimpleButton
        Me.btOk = New DevExpress.XtraEditors.SimpleButton
        Me.labTitre = New System.Windows.Forms.Label
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.GroupControl1.Controls.Add(Me.chkCOM)
        Me.GroupControl1.Controls.Add(Me.chkNIV)
        Me.GroupControl1.Controls.Add(Me.chkCOMAUTRE)
        Me.GroupControl1.Controls.Add(Me.chkTERR)
        Me.GroupControl1.Controls.Add(Me.chkCC)
        Me.GroupControl1.Controls.Add(Me.chkSAC)
        Me.GroupControl1.Controls.Add(Me.chkSAU)
        Me.GroupControl1.Controls.Add(Me.chkSP)
        Me.GroupControl1.Controls.Add(Me.chkPR)
        Me.GroupControl1.Controls.Add(Me.chkCCH)
        Me.GroupControl1.Controls.Add(Me.chkCPH)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 25)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(498, 327)
        Me.GroupControl1.TabIndex = 17
        Me.GroupControl1.Text = "Choisir les critères de recherche:"
        '
        'chkCOM
        '
        Me.chkCOM.AutoSize = True
        Me.chkCOM.Location = New System.Drawing.Point(294, 83)
        Me.chkCOM.Name = "chkCOM"
        Me.chkCOM.Size = New System.Drawing.Size(106, 17)
        Me.chkCOM.TabIndex = 12
        Me.chkCOM.Text = "Par commentaire"
        Me.chkCOM.UseVisualStyleBackColor = True
        '
        'chkNIV
        '
        Me.chkNIV.AutoSize = True
        Me.chkNIV.Location = New System.Drawing.Point(294, 117)
        Me.chkNIV.Name = "chkNIV"
        Me.chkNIV.Size = New System.Drawing.Size(77, 17)
        Me.chkNIV.TabIndex = 11
        Me.chkNIV.Text = "Par niveau"
        Me.chkNIV.UseVisualStyleBackColor = True
        '
        'chkCOMAUTRE
        '
        Me.chkCOMAUTRE.AutoSize = True
        Me.chkCOMAUTRE.Location = New System.Drawing.Point(294, 151)
        Me.chkCOMAUTRE.Name = "chkCOMAUTRE"
        Me.chkCOMAUTRE.Size = New System.Drawing.Size(135, 17)
        Me.chkCOMAUTRE.TabIndex = 10
        Me.chkCOMAUTRE.Text = "Par commentaire autre"
        Me.chkCOMAUTRE.UseVisualStyleBackColor = True
        '
        'chkTERR
        '
        Me.chkTERR.AutoSize = True
        Me.chkTERR.Location = New System.Drawing.Point(294, 49)
        Me.chkTERR.Name = "chkTERR"
        Me.chkTERR.Size = New System.Drawing.Size(77, 17)
        Me.chkTERR.TabIndex = 9
        Me.chkTERR.Text = "Par terrain"
        Me.chkTERR.UseVisualStyleBackColor = True
        '
        'chkCC
        '
        Me.chkCC.AutoSize = True
        Me.chkCC.Location = New System.Drawing.Point(25, 253)
        Me.chkCC.Name = "chkCC"
        Me.chkCC.Size = New System.Drawing.Size(119, 17)
        Me.chkCC.TabIndex = 7
        Me.chkCC.Text = "Par critère de choix"
        Me.chkCC.UseVisualStyleBackColor = True
        '
        'chkSAC
        '
        Me.chkSAC.AutoSize = True
        Me.chkSAC.Location = New System.Drawing.Point(25, 117)
        Me.chkSAC.Name = "chkSAC"
        Me.chkSAC.Size = New System.Drawing.Size(126, 17)
        Me.chkSAC.TabIndex = 6
        Me.chkSAC.Text = "Par substance active"
        Me.chkSAC.UseVisualStyleBackColor = True
        '
        'chkSAU
        '
        Me.chkSAU.AutoSize = True
        Me.chkSAU.Location = New System.Drawing.Point(25, 151)
        Me.chkSAU.Name = "chkSAU"
        Me.chkSAU.Size = New System.Drawing.Size(88, 17)
        Me.chkSAU.TabIndex = 5
        Me.chkSAU.Text = "Par excipient"
        Me.chkSAU.UseVisualStyleBackColor = True
        '
        'chkSP
        '
        Me.chkSP.AutoSize = True
        Me.chkSP.Location = New System.Drawing.Point(25, 219)
        Me.chkSP.Name = "chkSP"
        Me.chkSP.Size = New System.Drawing.Size(89, 17)
        Me.chkSP.TabIndex = 4
        Me.chkSP.Text = "Par spécialité"
        Me.chkSP.UseVisualStyleBackColor = True
        '
        'chkPR
        '
        Me.chkPR.AutoSize = True
        Me.chkPR.Location = New System.Drawing.Point(25, 185)
        Me.chkPR.Name = "chkPR"
        Me.chkPR.Size = New System.Drawing.Size(79, 17)
        Me.chkPR.TabIndex = 2
        Me.chkPR.Text = "Par produit"
        Me.chkPR.UseVisualStyleBackColor = True
        '
        'chkCCH
        '
        Me.chkCCH.AutoSize = True
        Me.chkCCH.Location = New System.Drawing.Point(25, 83)
        Me.chkCCH.Name = "chkCCH"
        Me.chkCCH.Size = New System.Drawing.Size(118, 17)
        Me.chkCCH.TabIndex = 1
        Me.chkCCH.Text = "Par classe chimique"
        Me.chkCCH.UseVisualStyleBackColor = True
        '
        'chkCPH
        '
        Me.chkCPH.AutoSize = True
        Me.chkCPH.Location = New System.Drawing.Point(25, 49)
        Me.chkCPH.Name = "chkCPH"
        Me.chkCPH.Size = New System.Drawing.Size(196, 17)
        Me.chkCPH.TabIndex = 0
        Me.chkCPH.Text = "Par classe pharmaco-thérapeutique"
        Me.chkCPH.UseVisualStyleBackColor = True
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
        Me.Panel1.Location = New System.Drawing.Point(0, 352)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(498, 48)
        Me.Panel1.TabIndex = 16
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
        Me.btAnnuler.Location = New System.Drawing.Point(406, 3)
        Me.btAnnuler.Name = "btAnnuler"
        Me.btAnnuler.Size = New System.Drawing.Size(87, 36)
        Me.btAnnuler.TabIndex = 1
        Me.btAnnuler.Text = "&Annuler"
        Me.btAnnuler.ToolTip = "Annuler la déclinaison"
        '
        'btOk
        '
        Me.btOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btOk.Location = New System.Drawing.Point(313, 3)
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
        Me.labTitre.Size = New System.Drawing.Size(498, 25)
        Me.labTitre.TabIndex = 15
        Me.labTitre.Text = "Cipemg Code"
        Me.labTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_CipemgCodeMultiCriteres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 400)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.labTitre)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_CipemgCodeMultiCriteres"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recherche multicritères"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkSAC As System.Windows.Forms.CheckBox
    Friend WithEvents chkSAU As System.Windows.Forms.CheckBox
    Friend WithEvents chkSP As System.Windows.Forms.CheckBox
    Friend WithEvents chkPR As System.Windows.Forms.CheckBox
    Friend WithEvents chkCCH As System.Windows.Forms.CheckBox
    Friend WithEvents chkCPH As System.Windows.Forms.CheckBox
    Protected Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Protected Friend WithEvents btNotcheckedALL As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btcheckedALL As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btAnnuler As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btOk As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents labTitre As System.Windows.Forms.Label
    Friend WithEvents chkCOM As System.Windows.Forms.CheckBox
    Friend WithEvents chkNIV As System.Windows.Forms.CheckBox
    Friend WithEvents chkCOMAUTRE As System.Windows.Forms.CheckBox
    Friend WithEvents chkTERR As System.Windows.Forms.CheckBox
    Friend WithEvents chkCC As System.Windows.Forms.CheckBox
End Class
