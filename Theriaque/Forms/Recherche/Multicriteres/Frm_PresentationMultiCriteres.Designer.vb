<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PresentationMultiCriteres
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
        Me.chkCOMDISP = New System.Windows.Forms.CheckBox
        Me.chkLIEUDISP = New System.Windows.Forms.CheckBox
        Me.chkCONDCONS = New System.Windows.Forms.CheckBox
        Me.chkST = New System.Windows.Forms.CheckBox
        Me.chkSTCOMP = New System.Windows.Forms.CheckBox
        Me.chkSTREMB = New System.Windows.Forms.CheckBox
        Me.chkPREHOS = New System.Windows.Forms.CheckBox
        Me.chkTAUXHOP = New System.Windows.Forms.CheckBox
        Me.chkCCOMP = New System.Windows.Forms.CheckBox
        Me.chkCEMB = New System.Windows.Forms.CheckBox
        Me.chkTAUXVILLE = New System.Windows.Forms.CheckBox
        Me.chkPRUNIT = New System.Windows.Forms.CheckBox
        Me.chkMAT = New System.Windows.Forms.CheckBox
        Me.chkCONT = New System.Windows.Forms.CheckBox
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
        Me.GroupControl1.Controls.Add(Me.chkCOMDISP)
        Me.GroupControl1.Controls.Add(Me.chkLIEUDISP)
        Me.GroupControl1.Controls.Add(Me.chkCONDCONS)
        Me.GroupControl1.Controls.Add(Me.chkST)
        Me.GroupControl1.Controls.Add(Me.chkSTCOMP)
        Me.GroupControl1.Controls.Add(Me.chkSTREMB)
        Me.GroupControl1.Controls.Add(Me.chkPREHOS)
        Me.GroupControl1.Controls.Add(Me.chkTAUXHOP)
        Me.GroupControl1.Controls.Add(Me.chkCCOMP)
        Me.GroupControl1.Controls.Add(Me.chkCEMB)
        Me.GroupControl1.Controls.Add(Me.chkTAUXVILLE)
        Me.GroupControl1.Controls.Add(Me.chkPRUNIT)
        Me.GroupControl1.Controls.Add(Me.chkMAT)
        Me.GroupControl1.Controls.Add(Me.chkCONT)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 25)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(498, 327)
        Me.GroupControl1.TabIndex = 20
        Me.GroupControl1.Text = "Choisir les critères de recherche:"
        '
        'chkCOMDISP
        '
        Me.chkCOMDISP.AutoSize = True
        Me.chkCOMDISP.Location = New System.Drawing.Point(294, 253)
        Me.chkCOMDISP.Name = "chkCOMDISP"
        Me.chkCOMDISP.Size = New System.Drawing.Size(169, 17)
        Me.chkCOMDISP.TabIndex = 15
        Me.chkCOMDISP.Text = "Par commentaire dispensation"
        Me.chkCOMDISP.UseVisualStyleBackColor = True
        '
        'chkLIEUDISP
        '
        Me.chkLIEUDISP.AutoSize = True
        Me.chkLIEUDISP.Location = New System.Drawing.Point(294, 219)
        Me.chkLIEUDISP.Name = "chkLIEUDISP"
        Me.chkLIEUDISP.Size = New System.Drawing.Size(139, 17)
        Me.chkLIEUDISP.TabIndex = 14
        Me.chkLIEUDISP.Text = "Par lieu de dispensation"
        Me.chkLIEUDISP.UseVisualStyleBackColor = True
        '
        'chkCONDCONS
        '
        Me.chkCONDCONS.AutoSize = True
        Me.chkCONDCONS.Location = New System.Drawing.Point(294, 185)
        Me.chkCONDCONS.Name = "chkCONDCONS"
        Me.chkCONDCONS.Size = New System.Drawing.Size(168, 17)
        Me.chkCONDCONS.TabIndex = 13
        Me.chkCONDCONS.Text = "Par condition de conservation"
        Me.chkCONDCONS.UseVisualStyleBackColor = True
        '
        'chkST
        '
        Me.chkST.AutoSize = True
        Me.chkST.Location = New System.Drawing.Point(294, 83)
        Me.chkST.Name = "chkST"
        Me.chkST.Size = New System.Drawing.Size(74, 17)
        Me.chkST.TabIndex = 12
        Me.chkST.Text = "Par statut"
        Me.chkST.UseVisualStyleBackColor = True
        '
        'chkSTCOMP
        '
        Me.chkSTCOMP.AutoSize = True
        Me.chkSTCOMP.Location = New System.Drawing.Point(294, 117)
        Me.chkSTCOMP.Name = "chkSTCOMP"
        Me.chkSTCOMP.Size = New System.Drawing.Size(152, 17)
        Me.chkSTCOMP.TabIndex = 11
        Me.chkSTCOMP.Text = "Par statut complémentaire"
        Me.chkSTCOMP.UseVisualStyleBackColor = True
        '
        'chkSTREMB
        '
        Me.chkSTREMB.AutoSize = True
        Me.chkSTREMB.Location = New System.Drawing.Point(294, 151)
        Me.chkSTREMB.Name = "chkSTREMB"
        Me.chkSTREMB.Size = New System.Drawing.Size(167, 17)
        Me.chkSTREMB.TabIndex = 10
        Me.chkSTREMB.Text = "Par statut de remboursement"
        Me.chkSTREMB.UseVisualStyleBackColor = True
        '
        'chkPREHOS
        '
        Me.chkPREHOS.AutoSize = True
        Me.chkPREHOS.Location = New System.Drawing.Point(294, 49)
        Me.chkPREHOS.Name = "chkPREHOS"
        Me.chkPREHOS.Size = New System.Drawing.Size(164, 17)
        Me.chkPREHOS.TabIndex = 9
        Me.chkPREHOS.Text = "Par présentation hospitalière"
        Me.chkPREHOS.UseVisualStyleBackColor = True
        '
        'chkTAUXHOP
        '
        Me.chkTAUXHOP.AutoSize = True
        Me.chkTAUXHOP.Location = New System.Drawing.Point(25, 253)
        Me.chkTAUXHOP.Name = "chkTAUXHOP"
        Me.chkTAUXHOP.Size = New System.Drawing.Size(142, 17)
        Me.chkTAUXHOP.TabIndex = 7
        Me.chkTAUXHOP.Text = "Par taux Rbst SS hôpital"
        Me.chkTAUXHOP.UseVisualStyleBackColor = True
        '
        'chkCCOMP
        '
        Me.chkCCOMP.AutoSize = True
        Me.chkCCOMP.Location = New System.Drawing.Point(25, 117)
        Me.chkCCOMP.Name = "chkCCOMP"
        Me.chkCCOMP.Size = New System.Drawing.Size(135, 17)
        Me.chkCCOMP.TabIndex = 6
        Me.chkCCOMP.Text = "Par caract complément"
        Me.chkCCOMP.UseVisualStyleBackColor = True
        '
        'chkCEMB
        '
        Me.chkCEMB.AutoSize = True
        Me.chkCEMB.Location = New System.Drawing.Point(25, 151)
        Me.chkCEMB.Name = "chkCEMB"
        Me.chkCEMB.Size = New System.Drawing.Size(126, 17)
        Me.chkCEMB.TabIndex = 5
        Me.chkCEMB.Text = "Par caract emballage"
        Me.chkCEMB.UseVisualStyleBackColor = True
        '
        'chkTAUXVILLE
        '
        Me.chkTAUXVILLE.AutoSize = True
        Me.chkTAUXVILLE.Location = New System.Drawing.Point(25, 219)
        Me.chkTAUXVILLE.Name = "chkTAUXVILLE"
        Me.chkTAUXVILLE.Size = New System.Drawing.Size(128, 17)
        Me.chkTAUXVILLE.TabIndex = 4
        Me.chkTAUXVILLE.Text = "Par taux Rbst SS ville"
        Me.chkTAUXVILLE.UseVisualStyleBackColor = True
        '
        'chkPRUNIT
        '
        Me.chkPRUNIT.AutoSize = True
        Me.chkPRUNIT.Location = New System.Drawing.Point(25, 185)
        Me.chkPRUNIT.Name = "chkPRUNIT"
        Me.chkPRUNIT.Size = New System.Drawing.Size(145, 17)
        Me.chkPRUNIT.TabIndex = 2
        Me.chkPRUNIT.Text = "Par présentation unitaire"
        Me.chkPRUNIT.UseVisualStyleBackColor = True
        '
        'chkMAT
        '
        Me.chkMAT.AutoSize = True
        Me.chkMAT.Location = New System.Drawing.Point(25, 83)
        Me.chkMAT.Name = "chkMAT"
        Me.chkMAT.Size = New System.Drawing.Size(87, 17)
        Me.chkMAT.TabIndex = 1
        Me.chkMAT.Text = "Par matériau"
        Me.chkMAT.UseVisualStyleBackColor = True
        '
        'chkCONT
        '
        Me.chkCONT.AutoSize = True
        Me.chkCONT.Location = New System.Drawing.Point(25, 49)
        Me.chkCONT.Name = "chkCONT"
        Me.chkCONT.Size = New System.Drawing.Size(94, 17)
        Me.chkCONT.TabIndex = 0
        Me.chkCONT.Text = "Par contenant"
        Me.chkCONT.UseVisualStyleBackColor = True
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
        Me.Panel1.TabIndex = 19
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
        Me.labTitre.TabIndex = 18
        Me.labTitre.Text = "Présentation"
        Me.labTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_PresentationMultiCriteres
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
        Me.Name = "Frm_PresentationMultiCriteres"
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
    Friend WithEvents chkST As System.Windows.Forms.CheckBox
    Friend WithEvents chkSTCOMP As System.Windows.Forms.CheckBox
    Friend WithEvents chkSTREMB As System.Windows.Forms.CheckBox
    Friend WithEvents chkPREHOS As System.Windows.Forms.CheckBox
    Friend WithEvents chkTAUXHOP As System.Windows.Forms.CheckBox
    Friend WithEvents chkCCOMP As System.Windows.Forms.CheckBox
    Friend WithEvents chkCEMB As System.Windows.Forms.CheckBox
    Friend WithEvents chkTAUXVILLE As System.Windows.Forms.CheckBox
    Friend WithEvents chkPRUNIT As System.Windows.Forms.CheckBox
    Friend WithEvents chkMAT As System.Windows.Forms.CheckBox
    Friend WithEvents chkCONT As System.Windows.Forms.CheckBox
    Protected Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Protected Friend WithEvents btNotcheckedALL As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btcheckedALL As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btAnnuler As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btOk As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents labTitre As System.Windows.Forms.Label
    Friend WithEvents chkCOMDISP As System.Windows.Forms.CheckBox
    Friend WithEvents chkLIEUDISP As System.Windows.Forms.CheckBox
    Friend WithEvents chkCONDCONS As System.Windows.Forms.CheckBox
End Class
