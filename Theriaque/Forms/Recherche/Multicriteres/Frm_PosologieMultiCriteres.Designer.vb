<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PosologieMultiCriteres
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
        Me.chkVA = New System.Windows.Forms.CheckBox
        Me.chkTERR = New System.Windows.Forms.CheckBox
        Me.chkNIV = New System.Windows.Forms.CheckBox
        Me.chkNAT = New System.Windows.Forms.CheckBox
        Me.chkCOMNAT = New System.Windows.Forms.CheckBox
        Me.chkNATDOSE = New System.Windows.Forms.CheckBox
        Me.chkCOMAUTRE = New System.Windows.Forms.CheckBox
        Me.chkCOMSURV = New System.Windows.Forms.CheckBox
        Me.chkCOMADAP = New System.Windows.Forms.CheckBox
        Me.chkCOMDUREE = New System.Windows.Forms.CheckBox
        Me.chkUTMAX = New System.Windows.Forms.CheckBox
        Me.chkCOMTERR = New System.Windows.Forms.CheckBox
        Me.chkUP = New System.Windows.Forms.CheckBox
        Me.chkFREQMIN = New System.Windows.Forms.CheckBox
        Me.chkFREQMAX = New System.Windows.Forms.CheckBox
        Me.chkCOMFREQ = New System.Windows.Forms.CheckBox
        Me.chkUTMIN = New System.Windows.Forms.CheckBox
        Me.chkCC = New System.Windows.Forms.CheckBox
        Me.chkSP = New System.Windows.Forms.CheckBox
        Me.chkSAC = New System.Windows.Forms.CheckBox
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
        Me.GroupControl1.Controls.Add(Me.chkVA)
        Me.GroupControl1.Controls.Add(Me.chkTERR)
        Me.GroupControl1.Controls.Add(Me.chkNIV)
        Me.GroupControl1.Controls.Add(Me.chkNAT)
        Me.GroupControl1.Controls.Add(Me.chkCOMNAT)
        Me.GroupControl1.Controls.Add(Me.chkNATDOSE)
        Me.GroupControl1.Controls.Add(Me.chkCOMAUTRE)
        Me.GroupControl1.Controls.Add(Me.chkCOMSURV)
        Me.GroupControl1.Controls.Add(Me.chkCOMADAP)
        Me.GroupControl1.Controls.Add(Me.chkCOMDUREE)
        Me.GroupControl1.Controls.Add(Me.chkUTMAX)
        Me.GroupControl1.Controls.Add(Me.chkCOMTERR)
        Me.GroupControl1.Controls.Add(Me.chkUP)
        Me.GroupControl1.Controls.Add(Me.chkFREQMIN)
        Me.GroupControl1.Controls.Add(Me.chkFREQMAX)
        Me.GroupControl1.Controls.Add(Me.chkCOMFREQ)
        Me.GroupControl1.Controls.Add(Me.chkUTMIN)
        Me.GroupControl1.Controls.Add(Me.chkCC)
        Me.GroupControl1.Controls.Add(Me.chkSP)
        Me.GroupControl1.Controls.Add(Me.chkSAC)
        Me.GroupControl1.Controls.Add(Me.chkPR)
        Me.GroupControl1.Controls.Add(Me.chkCCH)
        Me.GroupControl1.Controls.Add(Me.chkCPH)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 25)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(534, 482)
        Me.GroupControl1.TabIndex = 17
        Me.GroupControl1.Text = "Choisir les crit�res de recherche:"
        '
        'chkVA
        '
        Me.chkVA.AutoSize = True
        Me.chkVA.Location = New System.Drawing.Point(26, 243)
        Me.chkVA.Name = "chkVA"
        Me.chkVA.Size = New System.Drawing.Size(148, 17)
        Me.chkVA.TabIndex = 27
        Me.chkVA.Text = "Par voies d'administration"
        Me.chkVA.UseVisualStyleBackColor = True
        '
        'chkTERR
        '
        Me.chkTERR.AutoSize = True
        Me.chkTERR.Location = New System.Drawing.Point(26, 276)
        Me.chkTERR.Name = "chkTERR"
        Me.chkTERR.Size = New System.Drawing.Size(77, 17)
        Me.chkTERR.TabIndex = 26
        Me.chkTERR.Text = "Par terrain"
        Me.chkTERR.UseVisualStyleBackColor = True
        '
        'chkNIV
        '
        Me.chkNIV.AutoSize = True
        Me.chkNIV.Location = New System.Drawing.Point(26, 309)
        Me.chkNIV.Name = "chkNIV"
        Me.chkNIV.Size = New System.Drawing.Size(133, 17)
        Me.chkNIV.TabIndex = 25
        Me.chkNIV.Text = "Par niveau d'indication"
        Me.chkNIV.UseVisualStyleBackColor = True
        '
        'chkNAT
        '
        Me.chkNAT.AutoSize = True
        Me.chkNAT.Location = New System.Drawing.Point(26, 342)
        Me.chkNAT.Name = "chkNAT"
        Me.chkNAT.Size = New System.Drawing.Size(188, 17)
        Me.chkNAT.TabIndex = 24
        Me.chkNAT.Text = "Par nature indication s�lectionn�e"
        Me.chkNAT.UseVisualStyleBackColor = True
        '
        'chkCOMNAT
        '
        Me.chkCOMNAT.AutoSize = True
        Me.chkCOMNAT.Location = New System.Drawing.Point(26, 375)
        Me.chkCOMNAT.Name = "chkCOMNAT"
        Me.chkCOMNAT.Size = New System.Drawing.Size(189, 17)
        Me.chkCOMNAT.TabIndex = 23
        Me.chkCOMNAT.Text = "Par commentaire nature indication"
        Me.chkCOMNAT.UseVisualStyleBackColor = True
        '
        'chkNATDOSE
        '
        Me.chkNATDOSE.AutoSize = True
        Me.chkNATDOSE.Location = New System.Drawing.Point(26, 408)
        Me.chkNATDOSE.Name = "chkNATDOSE"
        Me.chkNATDOSE.Size = New System.Drawing.Size(118, 17)
        Me.chkNATDOSE.TabIndex = 22
        Me.chkNATDOSE.Text = "Par nature de dose"
        Me.chkNATDOSE.UseVisualStyleBackColor = True
        '
        'chkCOMAUTRE
        '
        Me.chkCOMAUTRE.AutoSize = True
        Me.chkCOMAUTRE.Location = New System.Drawing.Point(333, 375)
        Me.chkCOMAUTRE.Name = "chkCOMAUTRE"
        Me.chkCOMAUTRE.Size = New System.Drawing.Size(135, 17)
        Me.chkCOMAUTRE.TabIndex = 21
        Me.chkCOMAUTRE.Text = "Par commenatire autre"
        Me.chkCOMAUTRE.UseVisualStyleBackColor = True
        '
        'chkCOMSURV
        '
        Me.chkCOMSURV.AutoSize = True
        Me.chkCOMSURV.Location = New System.Drawing.Point(333, 342)
        Me.chkCOMSURV.Name = "chkCOMSURV"
        Me.chkCOMSURV.Size = New System.Drawing.Size(165, 17)
        Me.chkCOMSURV.TabIndex = 20
        Me.chkCOMSURV.Text = "Par commentaire surveillance"
        Me.chkCOMSURV.UseVisualStyleBackColor = True
        '
        'chkCOMADAP
        '
        Me.chkCOMADAP.AutoSize = True
        Me.chkCOMADAP.Location = New System.Drawing.Point(333, 309)
        Me.chkCOMADAP.Name = "chkCOMADAP"
        Me.chkCOMADAP.Size = New System.Drawing.Size(161, 17)
        Me.chkCOMADAP.TabIndex = 19
        Me.chkCOMADAP.Text = "Par commentaire adaptation"
        Me.chkCOMADAP.UseVisualStyleBackColor = True
        '
        'chkCOMDUREE
        '
        Me.chkCOMDUREE.AutoSize = True
        Me.chkCOMDUREE.Location = New System.Drawing.Point(333, 276)
        Me.chkCOMDUREE.Name = "chkCOMDUREE"
        Me.chkCOMDUREE.Size = New System.Drawing.Size(137, 17)
        Me.chkCOMDUREE.TabIndex = 18
        Me.chkCOMDUREE.Text = "Par commentaire dur�e"
        Me.chkCOMDUREE.UseVisualStyleBackColor = True
        '
        'chkUTMAX
        '
        Me.chkUTMAX.AutoSize = True
        Me.chkUTMAX.Location = New System.Drawing.Point(333, 243)
        Me.chkUTMAX.Name = "chkUTMAX"
        Me.chkUTMAX.Size = New System.Drawing.Size(131, 17)
        Me.chkUTMAX.TabIndex = 17
        Me.chkUTMAX.Text = "Par unit� temps - max"
        Me.chkUTMAX.UseVisualStyleBackColor = True
        '
        'chkCOMTERR
        '
        Me.chkCOMTERR.AutoSize = True
        Me.chkCOMTERR.Location = New System.Drawing.Point(333, 45)
        Me.chkCOMTERR.Name = "chkCOMTERR"
        Me.chkCOMTERR.Size = New System.Drawing.Size(141, 17)
        Me.chkCOMTERR.TabIndex = 16
        Me.chkCOMTERR.Text = "Par commentaire terrain"
        Me.chkCOMTERR.UseVisualStyleBackColor = True
        '
        'chkUP
        '
        Me.chkUP.AutoSize = True
        Me.chkUP.Location = New System.Drawing.Point(333, 78)
        Me.chkUP.Name = "chkUP"
        Me.chkUP.Size = New System.Drawing.Size(110, 17)
        Me.chkUP.TabIndex = 15
        Me.chkUP.Text = "Par unit� de prise"
        Me.chkUP.UseVisualStyleBackColor = True
        '
        'chkFREQMIN
        '
        Me.chkFREQMIN.AutoSize = True
        Me.chkFREQMIN.Location = New System.Drawing.Point(333, 111)
        Me.chkFREQMIN.Name = "chkFREQMIN"
        Me.chkFREQMIN.Size = New System.Drawing.Size(119, 17)
        Me.chkFREQMIN.TabIndex = 14
        Me.chkFREQMIN.Text = "Par code fr�q - mini"
        Me.chkFREQMIN.UseVisualStyleBackColor = True
        '
        'chkFREQMAX
        '
        Me.chkFREQMAX.AutoSize = True
        Me.chkFREQMAX.Location = New System.Drawing.Point(333, 144)
        Me.chkFREQMAX.Name = "chkFREQMAX"
        Me.chkFREQMAX.Size = New System.Drawing.Size(123, 17)
        Me.chkFREQMAX.TabIndex = 13
        Me.chkFREQMAX.Text = "Par code fr�q - maxi"
        Me.chkFREQMAX.UseVisualStyleBackColor = True
        '
        'chkCOMFREQ
        '
        Me.chkCOMFREQ.AutoSize = True
        Me.chkCOMFREQ.Location = New System.Drawing.Point(333, 177)
        Me.chkCOMFREQ.Name = "chkCOMFREQ"
        Me.chkCOMFREQ.Size = New System.Drawing.Size(129, 17)
        Me.chkCOMFREQ.TabIndex = 12
        Me.chkCOMFREQ.Text = "Par commentaire fr�q"
        Me.chkCOMFREQ.UseVisualStyleBackColor = True
        '
        'chkUTMIN
        '
        Me.chkUTMIN.AutoSize = True
        Me.chkUTMIN.Location = New System.Drawing.Point(333, 210)
        Me.chkUTMIN.Name = "chkUTMIN"
        Me.chkUTMIN.Size = New System.Drawing.Size(127, 17)
        Me.chkUTMIN.TabIndex = 11
        Me.chkUTMIN.Text = "Par unit� temps - min"
        Me.chkUTMIN.UseVisualStyleBackColor = True
        '
        'chkCC
        '
        Me.chkCC.AutoSize = True
        Me.chkCC.Location = New System.Drawing.Point(26, 177)
        Me.chkCC.Name = "chkCC"
        Me.chkCC.Size = New System.Drawing.Size(124, 17)
        Me.chkCC.TabIndex = 10
        Me.chkCC.Text = "Par crit�res de choix"
        Me.chkCC.UseVisualStyleBackColor = True
        '
        'chkSP
        '
        Me.chkSP.AutoSize = True
        Me.chkSP.Location = New System.Drawing.Point(26, 210)
        Me.chkSP.Name = "chkSP"
        Me.chkSP.Size = New System.Drawing.Size(89, 17)
        Me.chkSP.TabIndex = 4
        Me.chkSP.Text = "Par sp�cialit�"
        Me.chkSP.UseVisualStyleBackColor = True
        '
        'chkSAC
        '
        Me.chkSAC.AutoSize = True
        Me.chkSAC.Location = New System.Drawing.Point(26, 111)
        Me.chkSAC.Name = "chkSAC"
        Me.chkSAC.Size = New System.Drawing.Size(126, 17)
        Me.chkSAC.TabIndex = 3
        Me.chkSAC.Text = "Par substance active"
        Me.chkSAC.UseVisualStyleBackColor = True
        '
        'chkPR
        '
        Me.chkPR.AutoSize = True
        Me.chkPR.Location = New System.Drawing.Point(26, 144)
        Me.chkPR.Name = "chkPR"
        Me.chkPR.Size = New System.Drawing.Size(79, 17)
        Me.chkPR.TabIndex = 2
        Me.chkPR.Text = "Par produit"
        Me.chkPR.UseVisualStyleBackColor = True
        '
        'chkCCH
        '
        Me.chkCCH.AutoSize = True
        Me.chkCCH.Location = New System.Drawing.Point(26, 78)
        Me.chkCCH.Name = "chkCCH"
        Me.chkCCH.Size = New System.Drawing.Size(118, 17)
        Me.chkCCH.TabIndex = 1
        Me.chkCCH.Text = "Par classe chimique"
        Me.chkCCH.UseVisualStyleBackColor = True
        '
        'chkCPH
        '
        Me.chkCPH.AutoSize = True
        Me.chkCPH.Location = New System.Drawing.Point(26, 45)
        Me.chkCPH.Name = "chkCPH"
        Me.chkCPH.Size = New System.Drawing.Size(196, 17)
        Me.chkCPH.TabIndex = 0
        Me.chkCPH.Text = "Par classe pharmaco-th�rapeutique"
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
        Me.Panel1.Location = New System.Drawing.Point(0, 507)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(534, 48)
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
        Me.btNotcheckedALL.Location = New System.Drawing.Point(4, 24)
        Me.btNotcheckedALL.Name = "btNotcheckedALL"
        Me.btNotcheckedALL.Size = New System.Drawing.Size(130, 21)
        Me.btNotcheckedALL.TabIndex = 9
        Me.btNotcheckedALL.Text = "&D�s�lectionner tout"
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
        Me.btcheckedALL.Text = "&S�lectionner tout"
        '
        'btAnnuler
        '
        Me.btAnnuler.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btAnnuler.Location = New System.Drawing.Point(442, 3)
        Me.btAnnuler.Name = "btAnnuler"
        Me.btAnnuler.Size = New System.Drawing.Size(87, 36)
        Me.btAnnuler.TabIndex = 1
        Me.btAnnuler.Text = "&Annuler"
        Me.btAnnuler.ToolTip = "Annuler la d�clinaison"
        '
        'btOk
        '
        Me.btOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btOk.Location = New System.Drawing.Point(349, 3)
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
        Me.labTitre.Size = New System.Drawing.Size(534, 25)
        Me.labTitre.TabIndex = 15
        Me.labTitre.Text = "Posologie"
        Me.labTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_PosologieMultiCriteres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 555)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.labTitre)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_PosologieMultiCriteres"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recherche multicrit�res"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkVA As System.Windows.Forms.CheckBox
    Friend WithEvents chkTERR As System.Windows.Forms.CheckBox
    Friend WithEvents chkNIV As System.Windows.Forms.CheckBox
    Friend WithEvents chkNAT As System.Windows.Forms.CheckBox
    Friend WithEvents chkCOMNAT As System.Windows.Forms.CheckBox
    Friend WithEvents chkNATDOSE As System.Windows.Forms.CheckBox
    Friend WithEvents chkCOMAUTRE As System.Windows.Forms.CheckBox
    Friend WithEvents chkCOMSURV As System.Windows.Forms.CheckBox
    Friend WithEvents chkCOMADAP As System.Windows.Forms.CheckBox
    Friend WithEvents chkCOMDUREE As System.Windows.Forms.CheckBox
    Friend WithEvents chkUTMAX As System.Windows.Forms.CheckBox
    Friend WithEvents chkCOMTERR As System.Windows.Forms.CheckBox
    Friend WithEvents chkUP As System.Windows.Forms.CheckBox
    Friend WithEvents chkFREQMIN As System.Windows.Forms.CheckBox
    Friend WithEvents chkFREQMAX As System.Windows.Forms.CheckBox
    Friend WithEvents chkCOMFREQ As System.Windows.Forms.CheckBox
    Friend WithEvents chkUTMIN As System.Windows.Forms.CheckBox
    Friend WithEvents chkCC As System.Windows.Forms.CheckBox
    Friend WithEvents chkSP As System.Windows.Forms.CheckBox
    Friend WithEvents chkSAC As System.Windows.Forms.CheckBox
    Friend WithEvents chkPR As System.Windows.Forms.CheckBox
    Friend WithEvents chkCCH As System.Windows.Forms.CheckBox
    Friend WithEvents chkCPH As System.Windows.Forms.CheckBox
    Protected Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Protected Friend WithEvents btAnnuler As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btOk As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents labTitre As System.Windows.Forms.Label
    Protected Friend WithEvents btNotcheckedALL As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btcheckedALL As DevExpress.XtraEditors.SimpleButton
End Class
