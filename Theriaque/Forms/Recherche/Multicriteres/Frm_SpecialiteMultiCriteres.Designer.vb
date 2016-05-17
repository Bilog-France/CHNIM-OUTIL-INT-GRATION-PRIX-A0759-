<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SpecialiteMultiCriteres
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkTENEUREQUIV = New System.Windows.Forms.CheckBox
        Me.chkTENEUR = New System.Windows.Forms.CheckBox
        Me.chkTENEURUNITE = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkSUBAU = New System.Windows.Forms.CheckBox
        Me.chkSUBAUUNITE = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkPRES = New System.Windows.Forms.CheckBox
        Me.chkLIST = New System.Windows.Forms.CheckBox
        Me.chkATC = New System.Windows.Forms.CheckBox
        Me.chkCC = New System.Windows.Forms.CheckBox
        Me.chkCGESTION = New System.Windows.Forms.CheckBox
        Me.chkCPH = New System.Windows.Forms.CheckBox
        Me.chkEPH = New System.Windows.Forms.CheckBox
        Me.chkCOMP = New System.Windows.Forms.CheckBox
        Me.chkCIS = New System.Windows.Forms.CheckBox
        Me.chkLABOEXP = New System.Windows.Forms.CheckBox
        Me.chkCOMPFORM = New System.Windows.Forms.CheckBox
        Me.chkPR = New System.Windows.Forms.CheckBox
        Me.chkSTLABO = New System.Windows.Forms.CheckBox
        Me.chkVA = New System.Windows.Forms.CheckBox
        Me.chkFPH = New System.Windows.Forms.CheckBox
        Me.chkLABO = New System.Windows.Forms.CheckBox
        Me.chkSP = New System.Windows.Forms.CheckBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.chkSUBAC = New System.Windows.Forms.CheckBox
        Me.chkSUBACUNITE = New System.Windows.Forms.CheckBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btNotcheckedALL = New DevExpress.XtraEditors.SimpleButton
        Me.btcheckedALL = New DevExpress.XtraEditors.SimpleButton
        Me.btAnnuler = New DevExpress.XtraEditors.SimpleButton
        Me.btOk = New DevExpress.XtraEditors.SimpleButton
        Me.labTitre = New System.Windows.Forms.Label
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
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
        Me.GroupControl1.Controls.Add(Me.GroupBox3)
        Me.GroupControl1.Controls.Add(Me.GroupBox1)
        Me.GroupControl1.Controls.Add(Me.GroupBox2)
        Me.GroupControl1.Controls.Add(Me.GroupBox4)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 25)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(653, 587)
        Me.GroupControl1.TabIndex = 26
        Me.GroupControl1.Text = "Choisir les critères de recherche:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkTENEUREQUIV)
        Me.GroupBox3.Controls.Add(Me.chkTENEUR)
        Me.GroupBox3.Controls.Add(Me.chkTENEURUNITE)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(5, 446)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(636, 115)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Teneur"
        '
        'chkTENEUREQUIV
        '
        Me.chkTENEUREQUIV.AutoSize = True
        Me.chkTENEUREQUIV.Location = New System.Drawing.Point(10, 78)
        Me.chkTENEUREQUIV.Name = "chkTENEUREQUIV"
        Me.chkTENEUREQUIV.Size = New System.Drawing.Size(95, 17)
        Me.chkTENEUREQUIV.TabIndex = 9
        Me.chkTENEUREQUIV.Text = "Par équivalent"
        Me.chkTENEUREQUIV.UseVisualStyleBackColor = True
        '
        'chkTENEUR
        '
        Me.chkTENEUR.AutoSize = True
        Me.chkTENEUR.Location = New System.Drawing.Point(10, 22)
        Me.chkTENEUR.Name = "chkTENEUR"
        Me.chkTENEUR.Size = New System.Drawing.Size(77, 17)
        Me.chkTENEUR.TabIndex = 8
        Me.chkTENEUR.Text = "Par teneur"
        Me.chkTENEUR.UseVisualStyleBackColor = True
        '
        'chkTENEURUNITE
        '
        Me.chkTENEURUNITE.AutoSize = True
        Me.chkTENEURUNITE.Location = New System.Drawing.Point(10, 50)
        Me.chkTENEURUNITE.Name = "chkTENEURUNITE"
        Me.chkTENEURUNITE.Size = New System.Drawing.Size(122, 17)
        Me.chkTENEURUNITE.TabIndex = 7
        Me.chkTENEURUNITE.Text = "Par unité de dosage"
        Me.chkTENEURUNITE.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkSUBAU)
        Me.GroupBox1.Controls.Add(Me.chkSUBAUUNITE)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 355)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(636, 74)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Excipient"
        '
        'chkSUBAU
        '
        Me.chkSUBAU.AutoSize = True
        Me.chkSUBAU.Location = New System.Drawing.Point(10, 22)
        Me.chkSUBAU.Name = "chkSUBAU"
        Me.chkSUBAU.Size = New System.Drawing.Size(88, 17)
        Me.chkSUBAU.TabIndex = 8
        Me.chkSUBAU.Text = "Par excipient"
        Me.chkSUBAU.UseVisualStyleBackColor = True
        '
        'chkSUBAUUNITE
        '
        Me.chkSUBAUUNITE.AutoSize = True
        Me.chkSUBAUUNITE.Location = New System.Drawing.Point(10, 47)
        Me.chkSUBAUUNITE.Name = "chkSUBAUUNITE"
        Me.chkSUBAUUNITE.Size = New System.Drawing.Size(122, 17)
        Me.chkSUBAUUNITE.TabIndex = 7
        Me.chkSUBAUUNITE.Text = "Par unité de dosage"
        Me.chkSUBAUUNITE.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkPRES)
        Me.GroupBox2.Controls.Add(Me.chkLIST)
        Me.GroupBox2.Controls.Add(Me.chkATC)
        Me.GroupBox2.Controls.Add(Me.chkCC)
        Me.GroupBox2.Controls.Add(Me.chkCGESTION)
        Me.GroupBox2.Controls.Add(Me.chkCPH)
        Me.GroupBox2.Controls.Add(Me.chkEPH)
        Me.GroupBox2.Controls.Add(Me.chkCOMP)
        Me.GroupBox2.Controls.Add(Me.chkCIS)
        Me.GroupBox2.Controls.Add(Me.chkLABOEXP)
        Me.GroupBox2.Controls.Add(Me.chkCOMPFORM)
        Me.GroupBox2.Controls.Add(Me.chkPR)
        Me.GroupBox2.Controls.Add(Me.chkSTLABO)
        Me.GroupBox2.Controls.Add(Me.chkVA)
        Me.GroupBox2.Controls.Add(Me.chkFPH)
        Me.GroupBox2.Controls.Add(Me.chkLABO)
        Me.GroupBox2.Controls.Add(Me.chkSP)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(637, 209)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'chkPRES
        '
        Me.chkPRES.AutoSize = True
        Me.chkPRES.Location = New System.Drawing.Point(270, 177)
        Me.chkPRES.Name = "chkPRES"
        Me.chkPRES.Size = New System.Drawing.Size(160, 17)
        Me.chkPRES.TabIndex = 23
        Me.chkPRES.Text = "Par prescription / délivrance"
        Me.chkPRES.UseVisualStyleBackColor = True
        '
        'chkLIST
        '
        Me.chkLIST.AutoSize = True
        Me.chkLIST.Location = New System.Drawing.Point(8, 177)
        Me.chkLIST.Name = "chkLIST"
        Me.chkLIST.Size = New System.Drawing.Size(64, 17)
        Me.chkLIST.TabIndex = 22
        Me.chkLIST.Text = "Par liste"
        Me.chkLIST.UseVisualStyleBackColor = True
        '
        'chkATC
        '
        Me.chkATC.AutoSize = True
        Me.chkATC.Location = New System.Drawing.Point(465, 108)
        Me.chkATC.Name = "chkATC"
        Me.chkATC.Size = New System.Drawing.Size(65, 17)
        Me.chkATC.TabIndex = 21
        Me.chkATC.Text = "Par ATC"
        Me.chkATC.UseVisualStyleBackColor = True
        '
        'chkCC
        '
        Me.chkCC.AutoSize = True
        Me.chkCC.Location = New System.Drawing.Point(465, 142)
        Me.chkCC.Name = "chkCC"
        Me.chkCC.Size = New System.Drawing.Size(119, 17)
        Me.chkCC.TabIndex = 20
        Me.chkCC.Text = "Par critère de choix"
        Me.chkCC.UseVisualStyleBackColor = True
        '
        'chkCGESTION
        '
        Me.chkCGESTION.AutoSize = True
        Me.chkCGESTION.Location = New System.Drawing.Point(270, 142)
        Me.chkCGESTION.Name = "chkCGESTION"
        Me.chkCGESTION.Size = New System.Drawing.Size(112, 17)
        Me.chkCGESTION.TabIndex = 19
        Me.chkCGESTION.Text = "Par classe gestion"
        Me.chkCGESTION.UseVisualStyleBackColor = True
        '
        'chkCPH
        '
        Me.chkCPH.AutoSize = True
        Me.chkCPH.Location = New System.Drawing.Point(270, 108)
        Me.chkCPH.Name = "chkCPH"
        Me.chkCPH.Size = New System.Drawing.Size(164, 17)
        Me.chkCPH.TabIndex = 18
        Me.chkCPH.Text = "Par pharmaco-thérapeutique"
        Me.chkCPH.UseVisualStyleBackColor = True
        '
        'chkEPH
        '
        Me.chkEPH.AutoSize = True
        Me.chkEPH.Location = New System.Drawing.Point(11, 142)
        Me.chkEPH.Name = "chkEPH"
        Me.chkEPH.Size = New System.Drawing.Size(81, 17)
        Me.chkEPH.TabIndex = 17
        Me.chkEPH.Text = "Par Ephmra"
        Me.chkEPH.UseVisualStyleBackColor = True
        '
        'chkCOMP
        '
        Me.chkCOMP.AutoSize = True
        Me.chkCOMP.Location = New System.Drawing.Point(11, 108)
        Me.chkCOMP.Name = "chkCOMP"
        Me.chkCOMP.Size = New System.Drawing.Size(101, 17)
        Me.chkCOMP.TabIndex = 16
        Me.chkCOMP.Text = "Par composition"
        Me.chkCOMP.UseVisualStyleBackColor = True
        '
        'chkCIS
        '
        Me.chkCIS.AutoSize = True
        Me.chkCIS.Location = New System.Drawing.Point(11, 73)
        Me.chkCIS.Name = "chkCIS"
        Me.chkCIS.Size = New System.Drawing.Size(209, 17)
        Me.chkCIS.TabIndex = 15
        Me.chkCIS.Text = "Par code identifiant de spécialité (CIS)"
        Me.chkCIS.UseVisualStyleBackColor = True
        '
        'chkLABOEXP
        '
        Me.chkLABOEXP.AutoSize = True
        Me.chkLABOEXP.Location = New System.Drawing.Point(270, 73)
        Me.chkLABOEXP.Name = "chkLABOEXP"
        Me.chkLABOEXP.Size = New System.Drawing.Size(148, 17)
        Me.chkLABOEXP.TabIndex = 14
        Me.chkLABOEXP.Text = "Par laboratoire exploitant"
        Me.chkLABOEXP.UseVisualStyleBackColor = True
        '
        'chkCOMPFORM
        '
        Me.chkCOMPFORM.AutoSize = True
        Me.chkCOMPFORM.Location = New System.Drawing.Point(464, 73)
        Me.chkCOMPFORM.Name = "chkCOMPFORM"
        Me.chkCOMPFORM.Size = New System.Drawing.Size(148, 17)
        Me.chkCOMPFORM.TabIndex = 10
        Me.chkCOMPFORM.Text = "Par complément de forme"
        Me.chkCOMPFORM.UseVisualStyleBackColor = True
        '
        'chkPR
        '
        Me.chkPR.AutoSize = True
        Me.chkPR.Location = New System.Drawing.Point(11, 42)
        Me.chkPR.Name = "chkPR"
        Me.chkPR.Size = New System.Drawing.Size(108, 17)
        Me.chkPR.TabIndex = 6
        Me.chkPR.Text = "Par libellé produit"
        Me.chkPR.UseVisualStyleBackColor = True
        '
        'chkSTLABO
        '
        Me.chkSTLABO.AutoSize = True
        Me.chkSTLABO.Location = New System.Drawing.Point(270, 42)
        Me.chkSTLABO.Name = "chkSTLABO"
        Me.chkSTLABO.Size = New System.Drawing.Size(129, 17)
        Me.chkSTLABO.TabIndex = 5
        Me.chkSTLABO.Text = "Par statut laboratoire"
        Me.chkSTLABO.UseVisualStyleBackColor = True
        '
        'chkVA
        '
        Me.chkVA.AutoSize = True
        Me.chkVA.Location = New System.Drawing.Point(464, 11)
        Me.chkVA.Name = "chkVA"
        Me.chkVA.Size = New System.Drawing.Size(143, 17)
        Me.chkVA.TabIndex = 4
        Me.chkVA.Text = "Par voie d’administration"
        Me.chkVA.UseVisualStyleBackColor = True
        '
        'chkFPH
        '
        Me.chkFPH.AutoSize = True
        Me.chkFPH.Location = New System.Drawing.Point(464, 42)
        Me.chkFPH.Name = "chkFPH"
        Me.chkFPH.Size = New System.Drawing.Size(153, 17)
        Me.chkFPH.TabIndex = 2
        Me.chkFPH.Text = "Par forme pharmaceutique"
        Me.chkFPH.UseVisualStyleBackColor = True
        '
        'chkLABO
        '
        Me.chkLABO.AutoSize = True
        Me.chkLABO.Location = New System.Drawing.Point(270, 11)
        Me.chkLABO.Name = "chkLABO"
        Me.chkLABO.Size = New System.Drawing.Size(100, 17)
        Me.chkLABO.TabIndex = 1
        Me.chkLABO.Text = "Par laboratoire "
        Me.chkLABO.UseVisualStyleBackColor = True
        '
        'chkSP
        '
        Me.chkSP.AutoSize = True
        Me.chkSP.Location = New System.Drawing.Point(11, 11)
        Me.chkSP.Name = "chkSP"
        Me.chkSP.Size = New System.Drawing.Size(118, 17)
        Me.chkSP.TabIndex = 0
        Me.chkSP.Text = "Par libellé spécialité"
        Me.chkSP.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkSUBAC)
        Me.GroupBox4.Controls.Add(Me.chkSUBACUNITE)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(5, 264)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(636, 74)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Substance active"
        '
        'chkSUBAC
        '
        Me.chkSUBAC.AutoSize = True
        Me.chkSUBAC.Location = New System.Drawing.Point(10, 22)
        Me.chkSUBAC.Name = "chkSUBAC"
        Me.chkSUBAC.Size = New System.Drawing.Size(126, 17)
        Me.chkSUBAC.TabIndex = 8
        Me.chkSUBAC.Text = "Par substance active"
        Me.chkSUBAC.UseVisualStyleBackColor = True
        '
        'chkSUBACUNITE
        '
        Me.chkSUBACUNITE.AutoSize = True
        Me.chkSUBACUNITE.Location = New System.Drawing.Point(10, 47)
        Me.chkSUBACUNITE.Name = "chkSUBACUNITE"
        Me.chkSUBACUNITE.Size = New System.Drawing.Size(122, 17)
        Me.chkSUBACUNITE.TabIndex = 7
        Me.chkSUBACUNITE.Text = "Par unité de dosage"
        Me.chkSUBACUNITE.UseVisualStyleBackColor = True
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
        Me.Panel1.Location = New System.Drawing.Point(0, 612)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(653, 48)
        Me.Panel1.TabIndex = 25
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
        Me.btAnnuler.Location = New System.Drawing.Point(561, 3)
        Me.btAnnuler.Name = "btAnnuler"
        Me.btAnnuler.Size = New System.Drawing.Size(87, 36)
        Me.btAnnuler.TabIndex = 1
        Me.btAnnuler.Text = "&Annuler"
        Me.btAnnuler.ToolTip = "Annuler la déclinaison"
        '
        'btOk
        '
        Me.btOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btOk.Location = New System.Drawing.Point(468, 3)
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
        Me.labTitre.Size = New System.Drawing.Size(653, 25)
        Me.labTitre.TabIndex = 24
        Me.labTitre.Text = "Spécialité"
        Me.labTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_SpecialiteMultiCriteres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 660)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.labTitre)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_SpecialiteMultiCriteres"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recherche multicritères"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCIS As System.Windows.Forms.CheckBox
    Friend WithEvents chkLABOEXP As System.Windows.Forms.CheckBox
    Friend WithEvents chkPR As System.Windows.Forms.CheckBox
    Friend WithEvents chkSTLABO As System.Windows.Forms.CheckBox
    Friend WithEvents chkVA As System.Windows.Forms.CheckBox
    Friend WithEvents chkFPH As System.Windows.Forms.CheckBox
    Friend WithEvents chkLABO As System.Windows.Forms.CheckBox
    Friend WithEvents chkSP As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkSUBAC As System.Windows.Forms.CheckBox
    Friend WithEvents chkSUBACUNITE As System.Windows.Forms.CheckBox
    Friend WithEvents chkCOMPFORM As System.Windows.Forms.CheckBox
    Protected Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Protected Friend WithEvents btNotcheckedALL As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btcheckedALL As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btAnnuler As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btOk As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents labTitre As System.Windows.Forms.Label
    Friend WithEvents chkPRES As System.Windows.Forms.CheckBox
    Friend WithEvents chkLIST As System.Windows.Forms.CheckBox
    Friend WithEvents chkATC As System.Windows.Forms.CheckBox
    Friend WithEvents chkCC As System.Windows.Forms.CheckBox
    Friend WithEvents chkCGESTION As System.Windows.Forms.CheckBox
    Friend WithEvents chkCPH As System.Windows.Forms.CheckBox
    Friend WithEvents chkEPH As System.Windows.Forms.CheckBox
    Friend WithEvents chkCOMP As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkTENEUR As System.Windows.Forms.CheckBox
    Friend WithEvents chkTENEURUNITE As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkSUBAU As System.Windows.Forms.CheckBox
    Friend WithEvents chkSUBAUUNITE As System.Windows.Forms.CheckBox
    Friend WithEvents chkTENEUREQUIV As System.Windows.Forms.CheckBox
End Class
