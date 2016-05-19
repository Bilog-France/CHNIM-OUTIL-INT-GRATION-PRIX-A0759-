<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SacFilsMultiCriteres
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btNotcheckedALL = New DevExpress.XtraEditors.SimpleButton
        Me.btcheckedALL = New DevExpress.XtraEditors.SimpleButton
        Me.btAnnuler = New DevExpress.XtraEditors.SimpleButton
        Me.btOk = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.chkATC = New System.Windows.Forms.CheckBox
        Me.chkSAC = New System.Windows.Forms.CheckBox
        Me.chkCCH = New System.Windows.Forms.CheckBox
        Me.chkCPH = New System.Windows.Forms.CheckBox
        Me.labTitre = New System.Windows.Forms.Label
        Me.ChkTypeRef = New System.Windows.Forms.CheckBox
        Me.chkCodeCAS = New System.Windows.Forms.CheckBox
        Me.ChkLibRef = New System.Windows.Forms.CheckBox
        Me.chkCodeRef = New System.Windows.Forms.CheckBox
        Me.Panel1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(0, 252)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(453, 48)
        Me.Panel1.TabIndex = 7
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
        Me.btNotcheckedALL.Location = New System.Drawing.Point(4, 24)
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
        Me.btcheckedALL.Location = New System.Drawing.Point(4, 2)
        Me.btcheckedALL.Name = "btcheckedALL"
        Me.btcheckedALL.Size = New System.Drawing.Size(130, 21)
        Me.btcheckedALL.TabIndex = 8
        Me.btcheckedALL.Text = "&Sélectionner tout"
        '
        'btAnnuler
        '
        Me.btAnnuler.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btAnnuler.Location = New System.Drawing.Point(361, 3)
        Me.btAnnuler.Name = "btAnnuler"
        Me.btAnnuler.Size = New System.Drawing.Size(87, 36)
        Me.btAnnuler.TabIndex = 1
        Me.btAnnuler.Text = "&Annuler"
        Me.btAnnuler.ToolTip = "Annuler la déclinaison"
        '
        'btOk
        '
        Me.btOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btOk.Location = New System.Drawing.Point(268, 3)
        Me.btOk.Name = "btOk"
        Me.btOk.Size = New System.Drawing.Size(87, 36)
        Me.btOk.TabIndex = 1
        Me.btOk.Text = "&Ok"
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
        Me.GroupControl1.Controls.Add(Me.ChkTypeRef)
        Me.GroupControl1.Controls.Add(Me.chkCodeCAS)
        Me.GroupControl1.Controls.Add(Me.ChkLibRef)
        Me.GroupControl1.Controls.Add(Me.chkCodeRef)
        Me.GroupControl1.Controls.Add(Me.chkATC)
        Me.GroupControl1.Controls.Add(Me.chkSAC)
        Me.GroupControl1.Controls.Add(Me.chkCCH)
        Me.GroupControl1.Controls.Add(Me.chkCPH)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 25)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(453, 275)
        Me.GroupControl1.TabIndex = 5
        Me.GroupControl1.Text = "Choisir les critères de recherche:"
        '
        'chkATC
        '
        Me.chkATC.AutoSize = True
        Me.chkATC.Location = New System.Drawing.Point(25, 117)
        Me.chkATC.Name = "chkATC"
        Me.chkATC.Size = New System.Drawing.Size(97, 17)
        Me.chkATC.TabIndex = 6
        Me.chkATC.Text = "Par classe ATC"
        Me.chkATC.UseVisualStyleBackColor = True
        '
        'chkSAC
        '
        Me.chkSAC.AutoSize = True
        Me.chkSAC.Location = New System.Drawing.Point(25, 151)
        Me.chkSAC.Name = "chkSAC"
        Me.chkSAC.Size = New System.Drawing.Size(167, 17)
        Me.chkSAC.TabIndex = 5
        Me.chkSAC.Text = "Par origine du nom substance"
        Me.chkSAC.UseVisualStyleBackColor = True
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
        'labTitre
        '
        Me.labTitre.BackColor = System.Drawing.Color.LightSlateGray
        Me.labTitre.Dock = System.Windows.Forms.DockStyle.Top
        Me.labTitre.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTitre.ForeColor = System.Drawing.SystemColors.Window
        Me.labTitre.Location = New System.Drawing.Point(0, 0)
        Me.labTitre.Name = "labTitre"
        Me.labTitre.Size = New System.Drawing.Size(453, 25)
        Me.labTitre.TabIndex = 6
        Me.labTitre.Text = "Substance active - Fils"
        Me.labTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkTypeRef
        '
        Me.ChkTypeRef.AutoSize = True
        Me.ChkTypeRef.Location = New System.Drawing.Point(289, 117)
        Me.ChkTypeRef.Name = "ChkTypeRef"
        Me.ChkTypeRef.Size = New System.Drawing.Size(106, 17)
        Me.ChkTypeRef.TabIndex = 10
        Me.ChkTypeRef.Text = "Type Référentiel"
        Me.ChkTypeRef.UseVisualStyleBackColor = True
        '
        'chkCodeCAS
        '
        Me.chkCodeCAS.AutoSize = True
        Me.chkCodeCAS.Location = New System.Drawing.Point(289, 151)
        Me.chkCodeCAS.Name = "chkCodeCAS"
        Me.chkCodeCAS.Size = New System.Drawing.Size(74, 17)
        Me.chkCodeCAS.TabIndex = 9
        Me.chkCodeCAS.Text = "Code CAS"
        Me.chkCodeCAS.UseVisualStyleBackColor = True
        '
        'ChkLibRef
        '
        Me.ChkLibRef.AutoSize = True
        Me.ChkLibRef.Location = New System.Drawing.Point(289, 83)
        Me.ChkLibRef.Name = "ChkLibRef"
        Me.ChkLibRef.Size = New System.Drawing.Size(111, 17)
        Me.ChkLibRef.TabIndex = 8
        Me.ChkLibRef.Text = "Libellé Référentiel"
        Me.ChkLibRef.UseVisualStyleBackColor = True
        '
        'chkCodeRef
        '
        Me.chkCodeRef.AutoSize = True
        Me.chkCodeRef.Location = New System.Drawing.Point(289, 49)
        Me.chkCodeRef.Name = "chkCodeRef"
        Me.chkCodeRef.Size = New System.Drawing.Size(107, 17)
        Me.chkCodeRef.TabIndex = 7
        Me.chkCodeRef.Text = "Code Référentiel"
        Me.chkCodeRef.UseVisualStyleBackColor = True
        '
        'Frm_SacFilsMultiCriteres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 300)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.labTitre)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_SacFilsMultiCriteres"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recherche multicritères"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Protected Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Protected Friend WithEvents btAnnuler As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkATC As System.Windows.Forms.CheckBox
    Friend WithEvents chkSAC As System.Windows.Forms.CheckBox
    Friend WithEvents chkCCH As System.Windows.Forms.CheckBox
    Friend WithEvents chkCPH As System.Windows.Forms.CheckBox
    Protected Friend WithEvents labTitre As System.Windows.Forms.Label
    Protected Friend WithEvents btNotcheckedALL As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btcheckedALL As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ChkTypeRef As System.Windows.Forms.CheckBox
    Friend WithEvents chkCodeCAS As System.Windows.Forms.CheckBox
    Friend WithEvents ChkLibRef As System.Windows.Forms.CheckBox
    Friend WithEvents chkCodeRef As System.Windows.Forms.CheckBox
End Class
