<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Formulaire
    Inherits Theriaque.Frm_CNHIM

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        ClearMemory()
        MyBase.Dispose(disposing)
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Formulaire))
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim SuperToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim SuperToolTip6 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim SuperToolTip7 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim SuperToolTip8 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipItem6 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim SuperToolTip9 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim SuperToolTip10 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipItem7 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Me.Pan = New System.Windows.Forms.Panel
        Me.PanMain = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_RechMulti = New DevExpress.XtraEditors.SimpleButton
        Me.btDupliquer = New DevExpress.XtraEditors.SimpleButton
        Me.btn_specialiteCommune = New DevExpress.XtraEditors.SimpleButton
        Me.btAnnuler = New DevExpress.XtraEditors.SimpleButton
        Me.btValider = New DevExpress.XtraEditors.SimpleButton
        Me.btSupprimer = New DevExpress.XtraEditors.SimpleButton
        Me.btAjouter = New DevExpress.XtraEditors.SimpleButton
        Me.btFermer = New DevExpress.XtraEditors.SimpleButton
        Me.btAdvancedSearch = New DevExpress.XtraEditors.SimpleButton
        Me.btChercher = New DevExpress.XtraEditors.SimpleButton
        Me.PanTop = New System.Windows.Forms.Panel
        Me.PictureWarning = New DevExpress.XtraEditors.PictureEdit
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.GroupBox = New System.Windows.Forms.GroupBox
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.DxErrorProvider = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Pan.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanTop.SuspendLayout()
        CType(Me.PictureWarning.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Controls.Add(Me.PanMain)
        Me.Pan.Controls.Add(Me.Panel1)
        Me.Pan.Controls.Add(Me.PanTop)
        Me.Pan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pan.Location = New System.Drawing.Point(0, 0)
        Me.Pan.Name = "Pan"
        Me.Pan.Size = New System.Drawing.Size(630, 566)
        Me.Pan.TabIndex = 0
        '
        'PanMain
        '
        Me.PanMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMain.Location = New System.Drawing.Point(0, 87)
        Me.PanMain.Name = "PanMain"
        Me.PanMain.Size = New System.Drawing.Size(512, 479)
        Me.PanMain.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_RechMulti)
        Me.Panel1.Controls.Add(Me.btDupliquer)
        Me.Panel1.Controls.Add(Me.btn_specialiteCommune)
        Me.Panel1.Controls.Add(Me.btAnnuler)
        Me.Panel1.Controls.Add(Me.btValider)
        Me.Panel1.Controls.Add(Me.btSupprimer)
        Me.Panel1.Controls.Add(Me.btAjouter)
        Me.Panel1.Controls.Add(Me.btFermer)
        Me.Panel1.Controls.Add(Me.btAdvancedSearch)
        Me.Panel1.Controls.Add(Me.btChercher)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(512, 87)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(118, 479)
        Me.Panel1.TabIndex = 1
        '
        'btn_RechMulti
        '
        Me.btn_RechMulti.Location = New System.Drawing.Point(2, 320)
        Me.btn_RechMulti.Name = "btn_RechMulti"
        Me.btn_RechMulti.Size = New System.Drawing.Size(112, 30)
        ToolTipTitleItem1.Text = "Recherche avancée"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        Me.btn_RechMulti.SuperTip = SuperToolTip1
        Me.btn_RechMulti.TabIndex = 8
        Me.btn_RechMulti.Text = "R. &Multicritères"
        Me.btn_RechMulti.ToolTip = "Recherche multicritères"
        Me.btn_RechMulti.ToolTipTitle = "Recherche multicritères"
        Me.btn_RechMulti.Visible = False
        '
        'btDupliquer
        '
        Me.btDupliquer.Image = CType(resources.GetObject("btDupliquer.Image"), System.Drawing.Image)
        Me.btDupliquer.Location = New System.Drawing.Point(3, 70)
        Me.btDupliquer.Name = "btDupliquer"
        Me.btDupliquer.Size = New System.Drawing.Size(111, 27)
        ToolTipItem1.Text = "F12: Dupliquer une fiche"
        SuperToolTip2.Items.Add(ToolTipItem1)
        Me.btDupliquer.SuperTip = SuperToolTip2
        Me.btDupliquer.TabIndex = 7
        Me.btDupliquer.Text = "&Dupliquer"
        Me.btDupliquer.Visible = False
        '
        'btn_specialiteCommune
        '
        Me.btn_specialiteCommune.Location = New System.Drawing.Point(3, 390)
        Me.btn_specialiteCommune.Name = "btn_specialiteCommune"
        Me.btn_specialiteCommune.Size = New System.Drawing.Size(112, 30)
        ToolTipTitleItem2.Text = "Recherche avancée"
        SuperToolTip3.Items.Add(ToolTipTitleItem2)
        Me.btn_specialiteCommune.SuperTip = SuperToolTip3
        Me.btn_specialiteCommune.TabIndex = 6
        Me.btn_specialiteCommune.Text = "&Spécialités communes"
        Me.btn_specialiteCommune.ToolTip = "&Spécialités communes"
        Me.btn_specialiteCommune.ToolTipTitle = "&Recherche avancée"
        Me.btn_specialiteCommune.Visible = False
        '
        'btAnnuler
        '
        Me.btAnnuler.Image = CType(resources.GetObject("btAnnuler.Image"), System.Drawing.Image)
        Me.btAnnuler.Location = New System.Drawing.Point(3, 141)
        Me.btAnnuler.Name = "btAnnuler"
        Me.btAnnuler.Size = New System.Drawing.Size(111, 27)
        ToolTipItem2.Text = "F7: Annuler les modifications"
        SuperToolTip4.Items.Add(ToolTipItem2)
        Me.btAnnuler.SuperTip = SuperToolTip4
        Me.btAnnuler.TabIndex = 3
        Me.btAnnuler.Text = "A&nnuler"
        '
        'btValider
        '
        Me.btValider.Image = CType(resources.GetObject("btValider.Image"), System.Drawing.Image)
        Me.btValider.Location = New System.Drawing.Point(3, 108)
        Me.btValider.Name = "btValider"
        Me.btValider.Size = New System.Drawing.Size(111, 27)
        ToolTipItem3.Text = "F10: Valider la saisie"
        SuperToolTip5.Items.Add(ToolTipItem3)
        Me.btValider.SuperTip = SuperToolTip5
        Me.btValider.TabIndex = 2
        Me.btValider.Text = "&Valider"
        '
        'btSupprimer
        '
        Me.btSupprimer.Image = CType(resources.GetObject("btSupprimer.Image"), System.Drawing.Image)
        Me.btSupprimer.Location = New System.Drawing.Point(3, 38)
        Me.btSupprimer.Name = "btSupprimer"
        Me.btSupprimer.Size = New System.Drawing.Size(111, 27)
        ToolTipItem4.Text = "F11: Supprimer la fiche en cours"
        SuperToolTip6.Items.Add(ToolTipItem4)
        Me.btSupprimer.SuperTip = SuperToolTip6
        Me.btSupprimer.TabIndex = 1
        Me.btSupprimer.Text = "&Supprimer"
        '
        'btAjouter
        '
        Me.btAjouter.Image = CType(resources.GetObject("btAjouter.Image"), System.Drawing.Image)
        Me.btAjouter.Location = New System.Drawing.Point(3, 6)
        Me.btAjouter.Name = "btAjouter"
        Me.btAjouter.Size = New System.Drawing.Size(111, 27)
        ToolTipItem5.Text = "F6 : Ajouter une fiche"
        SuperToolTip7.Items.Add(ToolTipItem5)
        Me.btAjouter.SuperTip = SuperToolTip7
        Me.btAjouter.TabIndex = 0
        Me.btAjouter.Text = "&Ajouter"
        '
        'btFermer
        '
        Me.btFermer.Image = CType(resources.GetObject("btFermer.Image"), System.Drawing.Image)
        Me.btFermer.Location = New System.Drawing.Point(3, 228)
        Me.btFermer.Name = "btFermer"
        Me.btFermer.Size = New System.Drawing.Size(111, 27)
        ToolTipItem6.Text = "F3: Fermer la fiche sans validation"
        SuperToolTip8.Items.Add(ToolTipItem6)
        Me.btFermer.SuperTip = SuperToolTip8
        Me.btFermer.TabIndex = 5
        Me.btFermer.Text = "&Fermer"
        '
        'btAdvancedSearch
        '
        Me.btAdvancedSearch.Image = CType(resources.GetObject("btAdvancedSearch.Image"), System.Drawing.Image)
        Me.btAdvancedSearch.Location = New System.Drawing.Point(2, 276)
        Me.btAdvancedSearch.Name = "btAdvancedSearch"
        Me.btAdvancedSearch.Size = New System.Drawing.Size(112, 30)
        ToolTipTitleItem3.Text = "Recherche avancée"
        SuperToolTip9.Items.Add(ToolTipTitleItem3)
        Me.btAdvancedSearch.SuperTip = SuperToolTip9
        Me.btAdvancedSearch.TabIndex = 4
        Me.btAdvancedSearch.Text = "&Recherche"
        Me.btAdvancedSearch.ToolTip = "&Recherche avancée"
        Me.btAdvancedSearch.ToolTipTitle = "&Recherche avancée"
        Me.btAdvancedSearch.Visible = False
        '
        'btChercher
        '
        Me.btChercher.Image = CType(resources.GetObject("btChercher.Image"), System.Drawing.Image)
        Me.btChercher.Location = New System.Drawing.Point(3, 193)
        Me.btChercher.Name = "btChercher"
        Me.btChercher.Size = New System.Drawing.Size(111, 27)
        ToolTipItem7.Text = "Shift + F8: Chercher dans le dictionnaire"
        SuperToolTip10.Items.Add(ToolTipItem7)
        Me.btChercher.SuperTip = SuperToolTip10
        Me.btChercher.TabIndex = 4
        Me.btChercher.Text = "&Chercher"
        '
        'PanTop
        '
        Me.PanTop.Controls.Add(Me.PictureWarning)
        Me.PanTop.Controls.Add(Me.DateEdit2)
        Me.PanTop.Controls.Add(Me.DateEdit1)
        Me.PanTop.Controls.Add(Me.GroupBox)
        Me.PanTop.Controls.Add(Me.LabelControl2)
        Me.PanTop.Controls.Add(Me.LabelControl1)
        Me.PanTop.Controls.Add(Me.Label1)
        Me.PanTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanTop.Location = New System.Drawing.Point(0, 0)
        Me.PanTop.Name = "PanTop"
        Me.PanTop.Size = New System.Drawing.Size(630, 87)
        Me.PanTop.TabIndex = 0
        '
        'PictureWarning
        '
        Me.PictureWarning.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureWarning.EditValue = CType(resources.GetObject("PictureWarning.EditValue"), Object)
        Me.PictureWarning.Location = New System.Drawing.Point(600, 1)
        Me.PictureWarning.Name = "PictureWarning"
        Me.PictureWarning.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.PictureWarning.Properties.Appearance.Options.UseBackColor = True
        Me.PictureWarning.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureWarning.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureWarning.Size = New System.Drawing.Size(26, 26)
        Me.PictureWarning.TabIndex = 8
        Me.PictureWarning.ToolTip = "L'application est connectée à la base production"
        Me.PictureWarning.Visible = False
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(92, 44)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit2.Properties.ReadOnly = True
        Me.DateEdit2.Size = New System.Drawing.Size(135, 20)
        Me.DateEdit2.TabIndex = 7
        Me.DateEdit2.TabStop = False
        Me.DateEdit2.Tag = "[NOEDIT][NOADD]"
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(377, 45)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit1.Properties.ReadOnly = True
        Me.DateEdit1.Size = New System.Drawing.Size(135, 20)
        Me.DateEdit1.TabIndex = 7
        Me.DateEdit1.TabStop = False
        Me.DateEdit1.Tag = "[NOEDIT][NOADD]"
        '
        'GroupBox
        '
        Me.GroupBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox.Location = New System.Drawing.Point(0, 79)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(630, 8)
        Me.GroupBox.TabIndex = 6
        Me.GroupBox.TabStop = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(305, 46)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(66, 16)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Modifiée le"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(35, 46)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(43, 16)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Créé le"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(630, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Titre de la fiche"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "168.bmp")
        '
        'DxErrorProvider
        '
        Me.DxErrorProvider.ContainerControl = Me
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'Frm_Formulaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(630, 566)
        Me.Controls.Add(Me.Pan)
        Me.Name = "Frm_Formulaire"
        Me.Text = "Thériaque"
        Me.Pan.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        CType(Me.PictureWarning.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Protected Friend WithEvents Pan As System.Windows.Forms.Panel
    Protected Friend WithEvents PanMain As System.Windows.Forms.Panel
    Protected Friend WithEvents PanTop As System.Windows.Forms.Panel
    Protected Friend WithEvents Label1 As System.Windows.Forms.Label
    Protected Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Protected Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Protected Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Protected Friend WithEvents btAjouter As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btChercher As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btAnnuler As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btValider As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btSupprimer As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btFermer As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Protected Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Protected Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Protected Friend WithEvents DxErrorProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Protected Friend WithEvents btAdvancedSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureWarning As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Protected Friend WithEvents btn_specialiteCommune As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btDupliquer As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btn_RechMulti As DevExpress.XtraEditors.SimpleButton

End Class
