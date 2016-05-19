<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_GrosseRequete
    Inherits Theriaque.Frm_Formulaire

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_GrosseRequete))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ProgressBar = New System.Windows.Forms.ProgressBar
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.DsTheriaque_GrosseRequete = New Theriaque.dsTheriaque_GrosseRequete
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.lkupEphemra = New DevExpress.XtraEditors.LookUpEdit
        Me.lkupEphemra2 = New DevExpress.XtraEditors.LookUpEdit
        Me.Label30 = New System.Windows.Forms.Label
        Me.lkupDDD = New DevExpress.XtraEditors.LookUpEdit
        Me.Label28 = New System.Windows.Forms.Label
        Me.lkupDDD1 = New DevExpress.XtraEditors.LookUpEdit
        Me.txtDDD_Dosage = New DevExpress.XtraEditors.TextEdit
        Me.lkupATC = New DevExpress.XtraEditors.LookUpEdit
        Me.lkupATC2 = New DevExpress.XtraEditors.LookUpEdit
        Me.Label27 = New System.Windows.Forms.Label
        Me.TxtNumSP = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtLibelleLong = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtLibelleCourt = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtCIS = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtUCD = New DevExpress.XtraEditors.TextEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.PrE_TA = New Theriaque.dsTheriaque_GrosseRequeteTableAdapters.PRE_PRESENTATIONTableAdapter
        Me.SP_TA = New Theriaque.dsTheriaque_GrosseRequeteTableAdapters.SP_SPECIALITETableAdapter
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.GC7 = New DevExpress.XtraGrid.GridControl
        Me.GV7 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPRETSS_PRE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRETSS_CDF_TSS_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpTauxRBS = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colPRETSS_NUMSEQ = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRETSS_DATE_APPLI_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRETSS_DATE_APPLIQUEE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRETSS_TEXTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.DeditApplication = New DevExpress.XtraEditors.DateEdit
        Me.DeditRadiation = New DevExpress.XtraEditors.DateEdit
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DateEdit4 = New DevExpress.XtraEditors.DateEdit
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DeditSupp = New DevExpress.XtraEditors.DateEdit
        Me.Label20 = New System.Windows.Forms.Label
        Me.DeditdispoDepuis = New DevExpress.XtraEditors.DateEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmbEtatComercial = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtEAN = New DevExpress.XtraEditors.TextEdit
        Me.SpddD_TA = New Theriaque.dsTheriaque_GrosseRequeteTableAdapters.SPDDD_DOSE_USUELLE_JOURTableAdapter
        Me.PretsS_TA = New Theriaque.dsTheriaque_GrosseRequeteTableAdapters.PRETSS_PRESENTATION_TAUXTableAdapter
        Me.btn_Extraire = New DevExpress.XtraEditors.SimpleButton
        Me.SFDialogEnregistrer = New System.Windows.Forms.SaveFileDialog
        Me.btn_ExtraireTout = New DevExpress.XtraEditors.SimpleButton
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_GrosseRequete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.lkupEphemra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupEphemra2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupDDD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupDDD1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDDD_Dosage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupATC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupATC2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNumSP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtLibelleLong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtLibelleCourt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCIS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUCD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.GC7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpTauxRBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DeditApplication.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeditRadiation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DateEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DeditSupp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeditdispoDepuis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbEtatComercial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEAN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(776, 674)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.Panel2)
        Me.PanMain.Controls.Add(Me.GroupBox2)
        Me.PanMain.Location = New System.Drawing.Point(0, 36)
        Me.PanMain.Size = New System.Drawing.Size(658, 638)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(776, 36)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(776, 28)
        Me.Label1.Text = "Requête multicritères"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_ExtraireTout)
        Me.Panel1.Controls.Add(Me.btn_Extraire)
        Me.Panel1.Location = New System.Drawing.Point(658, 36)
        Me.Panel1.Size = New System.Drawing.Size(118, 638)
        Me.Panel1.Controls.SetChildIndex(Me.btDupliquer, 0)
        Me.Panel1.Controls.SetChildIndex(Me.btn_specialiteCommune, 0)
        Me.Panel1.Controls.SetChildIndex(Me.btn_Extraire, 0)
        Me.Panel1.Controls.SetChildIndex(Me.btChercher, 0)
        Me.Panel1.Controls.SetChildIndex(Me.btAdvancedSearch, 0)
        Me.Panel1.Controls.SetChildIndex(Me.btFermer, 0)
        Me.Panel1.Controls.SetChildIndex(Me.btAjouter, 0)
        Me.Panel1.Controls.SetChildIndex(Me.btSupprimer, 0)
        Me.Panel1.Controls.SetChildIndex(Me.btValider, 0)
        Me.Panel1.Controls.SetChildIndex(Me.btAnnuler, 0)
        Me.Panel1.Controls.SetChildIndex(Me.btn_ExtraireTout, 0)
        '
        'btAjouter
        '
        Me.btAjouter.Location = New System.Drawing.Point(3, 290)
        Me.btAjouter.Visible = False
        '
        'btChercher
        '
        Me.btChercher.Location = New System.Drawing.Point(4, 40)
        '
        'btAnnuler
        '
        Me.btAnnuler.Location = New System.Drawing.Point(4, 389)
        Me.btAnnuler.Visible = False
        '
        'btValider
        '
        Me.btValider.Location = New System.Drawing.Point(3, 356)
        Me.btValider.Visible = False
        '
        'btSupprimer
        '
        Me.btSupprimer.Location = New System.Drawing.Point(3, 323)
        Me.btSupprimer.Visible = False
        '
        'btFermer
        '
        Me.btFermer.Location = New System.Drawing.Point(4, 73)
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit1.Visible = False
        '
        'GroupBox
        '
        Me.GroupBox.Location = New System.Drawing.Point(0, 28)
        Me.GroupBox.Size = New System.Drawing.Size(776, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit2.Visible = False
        '
        'btAdvancedSearch
        '
        Me.btAdvancedSearch.Location = New System.Drawing.Point(3, 449)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ProgressBar)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtCode)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(658, 40)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(203, 12)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(450, 19)
        Me.ProgressBar.TabIndex = 21
        Me.ProgressBar.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "N° CIP"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_GrosseRequete, "PRE_PRESENTATION.PRE_CODE_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(51, 11)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Size = New System.Drawing.Size(119, 20)
        Me.txtCode.TabIndex = 18
        Me.txtCode.Tag = "[NOEDIT][NOADD]"
        '
        'DsTheriaque_GrosseRequete
        '
        Me.DsTheriaque_GrosseRequete.DataSetName = "dsTheriaque_GrosseRequete"
        Me.DsTheriaque_GrosseRequete.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl1.Controls.Add(Me.lkupEphemra)
        Me.GroupControl1.Controls.Add(Me.lkupEphemra2)
        Me.GroupControl1.Controls.Add(Me.Label30)
        Me.GroupControl1.Controls.Add(Me.lkupDDD)
        Me.GroupControl1.Controls.Add(Me.Label28)
        Me.GroupControl1.Controls.Add(Me.lkupDDD1)
        Me.GroupControl1.Controls.Add(Me.txtDDD_Dosage)
        Me.GroupControl1.Controls.Add(Me.lkupATC)
        Me.GroupControl1.Controls.Add(Me.lkupATC2)
        Me.GroupControl1.Controls.Add(Me.Label27)
        Me.GroupControl1.Controls.Add(Me.TxtNumSP)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.TxtLibelleLong)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.TxtLibelleCourt)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.TxtCIS)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.txtUCD)
        Me.GroupControl1.Controls.Add(Me.Label11)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(3, 16)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(652, 225)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Spécialité"
        '
        'lkupEphemra
        '
        Me.lkupEphemra.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_GrosseRequete, "SP_SPECIALITE.SP_CEPH_CODE_FK", True))
        Me.lkupEphemra.Location = New System.Drawing.Point(90, 191)
        Me.lkupEphemra.Name = "lkupEphemra"
        Me.lkupEphemra.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupEphemra.Properties.NullText = ""
        Me.lkupEphemra.Properties.ReadOnly = True
        Me.lkupEphemra.Size = New System.Drawing.Size(78, 20)
        Me.lkupEphemra.TabIndex = 48
        '
        'lkupEphemra2
        '
        Me.lkupEphemra2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_GrosseRequete, "SP_SPECIALITE.SP_CEPH_CODE_FK", True))
        Me.lkupEphemra2.Location = New System.Drawing.Point(172, 192)
        Me.lkupEphemra2.Name = "lkupEphemra2"
        Me.lkupEphemra2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupEphemra2.Properties.NullText = ""
        Me.lkupEphemra2.Properties.ReadOnly = True
        Me.lkupEphemra2.Size = New System.Drawing.Size(450, 20)
        Me.lkupEphemra2.TabIndex = 49
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(29, 195)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(49, 13)
        Me.Label30.TabIndex = 50
        Me.Label30.Text = "Ephemra"
        '
        'lkupDDD
        '
        Me.lkupDDD.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_GrosseRequete, "SPDDD_DOSE_USUELLE_JOUR.SPDDD_ATCDDD_CDF_VO_CODE_FK_PK", True))
        Me.lkupDDD.Location = New System.Drawing.Point(89, 166)
        Me.lkupDDD.Name = "lkupDDD"
        Me.lkupDDD.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupDDD.Properties.NullText = ""
        Me.lkupDDD.Properties.ReadOnly = True
        Me.lkupDDD.Size = New System.Drawing.Size(345, 20)
        Me.lkupDDD.TabIndex = 44
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(45, 170)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(31, 13)
        Me.Label28.TabIndex = 47
        Me.Label28.Text = "DDD"
        '
        'lkupDDD1
        '
        Me.lkupDDD1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_GrosseRequete, "SPDDD_DOSE_USUELLE_JOUR.SPDDD_ATCDDD_CDF_UD_CODE_FK_PK", True))
        Me.lkupDDD1.Location = New System.Drawing.Point(523, 166)
        Me.lkupDDD1.Name = "lkupDDD1"
        Me.lkupDDD1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupDDD1.Properties.NullText = ""
        Me.lkupDDD1.Properties.ReadOnly = True
        Me.lkupDDD1.Size = New System.Drawing.Size(97, 20)
        Me.lkupDDD1.TabIndex = 46
        '
        'txtDDD_Dosage
        '
        Me.txtDDD_Dosage.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_GrosseRequete, "SPDDD_DOSE_USUELLE_JOUR.SPDDD_ATCDDD_DOSAGE_PK", True))
        Me.txtDDD_Dosage.Location = New System.Drawing.Point(445, 166)
        Me.txtDDD_Dosage.Name = "txtDDD_Dosage"
        Me.txtDDD_Dosage.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtDDD_Dosage.Properties.Appearance.Options.UseBackColor = True
        Me.txtDDD_Dosage.Properties.ReadOnly = True
        Me.txtDDD_Dosage.Size = New System.Drawing.Size(72, 20)
        Me.txtDDD_Dosage.TabIndex = 45
        '
        'lkupATC
        '
        Me.lkupATC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_GrosseRequete, "SP_SPECIALITE.SP_CATC_CODE_FK", True))
        Me.lkupATC.Location = New System.Drawing.Point(89, 133)
        Me.lkupATC.Name = "lkupATC"
        Me.lkupATC.Properties.NullText = ""
        Me.lkupATC.Properties.ReadOnly = True
        Me.lkupATC.Size = New System.Drawing.Size(77, 20)
        Me.lkupATC.TabIndex = 41
        '
        'lkupATC2
        '
        Me.lkupATC2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_GrosseRequete, "SP_SPECIALITE.SP_CATC_CODE_FK", True))
        Me.lkupATC2.Location = New System.Drawing.Point(172, 133)
        Me.lkupATC2.Name = "lkupATC2"
        Me.lkupATC2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupATC2.Properties.NullText = ""
        Me.lkupATC2.Properties.ReadOnly = True
        Me.lkupATC2.Size = New System.Drawing.Size(448, 20)
        Me.lkupATC2.TabIndex = 42
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(48, 137)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(28, 13)
        Me.Label27.TabIndex = 43
        Me.Label27.Text = "ATC"
        '
        'TxtNumSP
        '
        Me.TxtNumSP.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_GrosseRequete, "SP_SPECIALITE.SP_CODE_SQ_PK", True))
        Me.TxtNumSP.Location = New System.Drawing.Point(487, 31)
        Me.TxtNumSP.Name = "TxtNumSP"
        Me.TxtNumSP.Properties.ReadOnly = True
        Me.TxtNumSP.Size = New System.Drawing.Size(131, 20)
        Me.TxtNumSP.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(401, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Numéro interne"
        '
        'TxtLibelleLong
        '
        Me.TxtLibelleLong.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtLibelleLong.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_GrosseRequete, "SP_SPECIALITE.SP_NOMLONG", True))
        Me.TxtLibelleLong.Location = New System.Drawing.Point(90, 100)
        Me.TxtLibelleLong.Name = "TxtLibelleLong"
        Me.TxtLibelleLong.Properties.ReadOnly = True
        Me.TxtLibelleLong.Size = New System.Drawing.Size(530, 20)
        Me.TxtLibelleLong.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Libellé long"
        '
        'TxtLibelleCourt
        '
        Me.TxtLibelleCourt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtLibelleCourt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_GrosseRequete, "SP_SPECIALITE.SP_NOM", True))
        Me.TxtLibelleCourt.Location = New System.Drawing.Point(89, 66)
        Me.TxtLibelleCourt.Name = "TxtLibelleCourt"
        Me.TxtLibelleCourt.Properties.ReadOnly = True
        Me.TxtLibelleCourt.Size = New System.Drawing.Size(531, 20)
        Me.TxtLibelleCourt.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Libellé court"
        '
        'TxtCIS
        '
        Me.TxtCIS.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_GrosseRequete, "SP_SPECIALITE.SP_NL", True))
        Me.TxtCIS.Location = New System.Drawing.Point(259, 31)
        Me.TxtCIS.Name = "TxtCIS"
        Me.TxtCIS.Properties.ReadOnly = True
        Me.TxtCIS.Size = New System.Drawing.Size(125, 20)
        Me.TxtCIS.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(222, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "CIS"
        '
        'txtUCD
        '
        Me.txtUCD.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_GrosseRequete, "SP_SPECIALITE.SP_CIPUCD", True))
        Me.txtUCD.Location = New System.Drawing.Point(89, 31)
        Me.txtUCD.Name = "txtUCD"
        Me.txtUCD.Properties.ReadOnly = True
        Me.txtUCD.Size = New System.Drawing.Size(121, 20)
        Me.txtUCD.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(52, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "UCD"
        '
        'PrE_TA
        '
        Me.PrE_TA.ClearBeforeFill = True
        '
        'SP_TA
        '
        Me.SP_TA.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(658, 598)
        Me.Panel2.TabIndex = 3
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupControl2)
        Me.GroupBox5.Controls.Add(Me.GroupControl1)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(658, 598)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.Appearance.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl2.Controls.Add(Me.Panel4)
        Me.GroupControl2.Controls.Add(Me.Panel3)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(3, 241)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(652, 354)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Présentation"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GC7)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(2, 268)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(648, 84)
        Me.Panel4.TabIndex = 11
        '
        'GC7
        '
        Me.GC7.DataMember = "PRETSS_PRESENTATION_TAUX"
        Me.GC7.DataSource = Me.DsTheriaque_GrosseRequete
        Me.GC7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC7.EmbeddedNavigator.Buttons.Append.Enabled = False
        Me.GC7.EmbeddedNavigator.Buttons.CancelEdit.Enabled = False
        Me.GC7.EmbeddedNavigator.Buttons.Edit.Enabled = False
        Me.GC7.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.EndEdit.Enabled = False
        Me.GC7.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC7.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC7.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC7.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC7.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC7.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC7.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.Remove.Enabled = False
        Me.GC7.EmbeddedNavigator.Name = ""
        Me.GC7.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC7.Location = New System.Drawing.Point(0, 0)
        Me.GC7.MainView = Me.GV7
        Me.GC7.Name = "GC7"
        Me.GC7.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpTauxRBS})
        Me.GC7.Size = New System.Drawing.Size(648, 84)
        Me.GC7.TabIndex = 7
        Me.GC7.UseEmbeddedNavigator = True
        Me.GC7.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV7})
        '
        'GV7
        '
        Me.GV7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPRETSS_PRE_CODE_FK_PK, Me.colPRETSS_CDF_TSS_CODE_FK_PK, Me.colPRETSS_NUMSEQ, Me.colPRETSS_DATE_APPLI_PK, Me.colPRETSS_DATE_APPLIQUEE, Me.colPRETSS_TEXTE})
        Me.GV7.GridControl = Me.GC7
        Me.GV7.GroupPanelText = " "
        Me.GV7.Name = "GV7"
        Me.GV7.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV7.OptionsView.ShowGroupPanel = False
        '
        'colPRETSS_PRE_CODE_FK_PK
        '
        Me.colPRETSS_PRE_CODE_FK_PK.Caption = "PRETSS_PRE_CODE_FK_PK"
        Me.colPRETSS_PRE_CODE_FK_PK.FieldName = "PRETSS_PRE_CODE_FK_PK"
        Me.colPRETSS_PRE_CODE_FK_PK.Name = "colPRETSS_PRE_CODE_FK_PK"
        Me.colPRETSS_PRE_CODE_FK_PK.OptionsColumn.ReadOnly = True
        '
        'colPRETSS_CDF_TSS_CODE_FK_PK
        '
        Me.colPRETSS_CDF_TSS_CODE_FK_PK.Caption = "Taux de remboursement"
        Me.colPRETSS_CDF_TSS_CODE_FK_PK.ColumnEdit = Me.rpTauxRBS
        Me.colPRETSS_CDF_TSS_CODE_FK_PK.FieldName = "PRETSS_CDF_TSS_CODE_FK_PK"
        Me.colPRETSS_CDF_TSS_CODE_FK_PK.Name = "colPRETSS_CDF_TSS_CODE_FK_PK"
        Me.colPRETSS_CDF_TSS_CODE_FK_PK.OptionsColumn.ReadOnly = True
        Me.colPRETSS_CDF_TSS_CODE_FK_PK.Visible = True
        Me.colPRETSS_CDF_TSS_CODE_FK_PK.VisibleIndex = 0
        '
        'rpTauxRBS
        '
        Me.rpTauxRBS.AutoHeight = False
        Me.rpTauxRBS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpTauxRBS.Name = "rpTauxRBS"
        Me.rpTauxRBS.NullText = ""
        '
        'colPRETSS_NUMSEQ
        '
        Me.colPRETSS_NUMSEQ.Caption = "PRETSS_NUMSEQ"
        Me.colPRETSS_NUMSEQ.FieldName = "PRETSS_NUMSEQ"
        Me.colPRETSS_NUMSEQ.Name = "colPRETSS_NUMSEQ"
        Me.colPRETSS_NUMSEQ.OptionsColumn.ReadOnly = True
        '
        'colPRETSS_DATE_APPLI_PK
        '
        Me.colPRETSS_DATE_APPLI_PK.Caption = "Dernière date JO"
        Me.colPRETSS_DATE_APPLI_PK.FieldName = "PRETSS_DATE_APPLI_PK"
        Me.colPRETSS_DATE_APPLI_PK.Name = "colPRETSS_DATE_APPLI_PK"
        Me.colPRETSS_DATE_APPLI_PK.OptionsColumn.ReadOnly = True
        Me.colPRETSS_DATE_APPLI_PK.Visible = True
        Me.colPRETSS_DATE_APPLI_PK.VisibleIndex = 1
        '
        'colPRETSS_DATE_APPLIQUEE
        '
        Me.colPRETSS_DATE_APPLIQUEE.Caption = "Dernière date applic"
        Me.colPRETSS_DATE_APPLIQUEE.FieldName = "PRETSS_DATE_APPLIQUEE"
        Me.colPRETSS_DATE_APPLIQUEE.Name = "colPRETSS_DATE_APPLIQUEE"
        Me.colPRETSS_DATE_APPLIQUEE.OptionsColumn.ReadOnly = True
        Me.colPRETSS_DATE_APPLIQUEE.Visible = True
        Me.colPRETSS_DATE_APPLIQUEE.VisibleIndex = 2
        '
        'colPRETSS_TEXTE
        '
        Me.colPRETSS_TEXTE.Caption = "PRETSS_TEXTE"
        Me.colPRETSS_TEXTE.FieldName = "PRETSS_TEXTE"
        Me.colPRETSS_TEXTE.Name = "colPRETSS_TEXTE"
        Me.colPRETSS_TEXTE.OptionsColumn.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox4)
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.TextEdit5)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txtEAN)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(2, 20)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(648, 248)
        Me.Panel3.TabIndex = 10
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.DeditApplication)
        Me.GroupBox4.Controls.Add(Me.DeditRadiation)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Location = New System.Drawing.Point(4, 183)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(637, 61)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Radiation collectivité"
        '
        'DeditApplication
        '
        Me.DeditApplication.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_GrosseRequete, "PRE_PRESENTATION.PRE_DATE_APPLIFINCOLL", True))
        Me.DeditApplication.EditValue = Nothing
        Me.DeditApplication.Location = New System.Drawing.Point(401, 22)
        Me.DeditApplication.Name = "DeditApplication"
        Me.DeditApplication.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DeditApplication.Properties.ReadOnly = True
        Me.DeditApplication.Size = New System.Drawing.Size(129, 20)
        Me.DeditApplication.TabIndex = 18
        '
        'DeditRadiation
        '
        Me.DeditRadiation.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_GrosseRequete, "PRE_PRESENTATION.PRE_DATEFINCOLL", True))
        Me.DeditRadiation.EditValue = Nothing
        Me.DeditRadiation.Location = New System.Drawing.Point(123, 21)
        Me.DeditRadiation.Name = "DeditRadiation"
        Me.DeditRadiation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DeditRadiation.Properties.ReadOnly = True
        Me.DeditRadiation.Size = New System.Drawing.Size(129, 20)
        Me.DeditRadiation.TabIndex = 17
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(303, 25)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(92, 13)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "Date d'application"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(71, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 13)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Date JO"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.DateEdit4)
        Me.GroupBox3.Controls.Add(Me.ComboBoxEdit1)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 119)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(638, 58)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Agrément collectivité"
        '
        'DateEdit4
        '
        Me.DateEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_GrosseRequete, "PRE_PRESENTATION.PRE_DATEJOCOLL", True))
        Me.DateEdit4.EditValue = Nothing
        Me.DateEdit4.Location = New System.Drawing.Point(402, 21)
        Me.DateEdit4.Name = "DateEdit4"
        Me.DateEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit4.Properties.ReadOnly = True
        Me.DateEdit4.Size = New System.Drawing.Size(129, 20)
        Me.DateEdit4.TabIndex = 18
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_GrosseRequete, "PRE_PRESENTATION.PRE_AGRCOLL", True))
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(123, 21)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "O", "N"})
        Me.ComboBoxEdit1.Properties.ReadOnly = True
        Me.ComboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(129, 20)
        Me.ComboBoxEdit1.TabIndex = 17
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(368, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Date"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 13)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Agrément  (O/N/E)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DeditSupp)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.DeditdispoDepuis)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cmbEtatComercial)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 76)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Commercialisation"
        '
        'DeditSupp
        '
        Me.DeditSupp.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_GrosseRequete, "PRE_PRESENTATION.PRE_DATESUP", True))
        Me.DeditSupp.EditValue = Nothing
        Me.DeditSupp.Location = New System.Drawing.Point(402, 45)
        Me.DeditSupp.Name = "DeditSupp"
        Me.DeditSupp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DeditSupp.Properties.ReadOnly = True
        Me.DeditSupp.Size = New System.Drawing.Size(127, 20)
        Me.DeditSupp.TabIndex = 28
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(280, 49)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(116, 13)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = "Date arrête commercial"
        '
        'DeditdispoDepuis
        '
        Me.DeditdispoDepuis.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_GrosseRequete, "PRE_PRESENTATION.PRE_DATECOMMER", True))
        Me.DeditdispoDepuis.EditValue = Nothing
        Me.DeditdispoDepuis.Location = New System.Drawing.Point(130, 45)
        Me.DeditdispoDepuis.Name = "DeditdispoDepuis"
        Me.DeditdispoDepuis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DeditdispoDepuis.Properties.ReadOnly = True
        Me.DeditdispoDepuis.Size = New System.Drawing.Size(127, 20)
        Me.DeditdispoDepuis.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Date commerciale"
        '
        'cmbEtatComercial
        '
        Me.cmbEtatComercial.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_GrosseRequete, "PRE_PRESENTATION.PRE_ETAT_COMMER", True))
        Me.cmbEtatComercial.Location = New System.Drawing.Point(130, 20)
        Me.cmbEtatComercial.Name = "cmbEtatComercial"
        Me.cmbEtatComercial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbEtatComercial.Properties.Items.AddRange(New Object() {"D", "S", "NC"})
        Me.cmbEtatComercial.Properties.ReadOnly = True
        Me.cmbEtatComercial.Size = New System.Drawing.Size(127, 20)
        Me.cmbEtatComercial.TabIndex = 26
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(33, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 13)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Etat commercial"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(247, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Tag = "[ADD][EDIT]"
        Me.Label8.Text = "Libellé"
        '
        'TextEdit5
        '
        Me.TextEdit5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_GrosseRequete, "PRE_PRESENTATION.PRE_ADMIN", True))
        Me.TextEdit5.Location = New System.Drawing.Point(297, 7)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Properties.ReadOnly = True
        Me.TextEdit5.Size = New System.Drawing.Size(325, 20)
        Me.TextEdit5.TabIndex = 4
        Me.TextEdit5.Tag = "[ADD][EDIT]"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Tag = "[ADD][EDIT]"
        Me.Label7.Text = "EAN"
        '
        'txtEAN
        '
        Me.txtEAN.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_GrosseRequete, "PRE_PRESENTATION.PRE_EAN_REF", True))
        Me.txtEAN.Location = New System.Drawing.Point(89, 7)
        Me.txtEAN.Name = "txtEAN"
        Me.txtEAN.Properties.ReadOnly = True
        Me.txtEAN.Size = New System.Drawing.Size(121, 20)
        Me.txtEAN.TabIndex = 2
        Me.txtEAN.Tag = "[ADD][EDIT]"
        '
        'SpddD_TA
        '
        Me.SpddD_TA.ClearBeforeFill = True
        '
        'PretsS_TA
        '
        Me.PretsS_TA.ClearBeforeFill = True
        '
        'btn_Extraire
        '
        Me.btn_Extraire.Enabled = False
        Me.btn_Extraire.Image = CType(resources.GetObject("btn_Extraire.Image"), System.Drawing.Image)
        Me.btn_Extraire.Location = New System.Drawing.Point(2, 125)
        Me.btn_Extraire.Name = "btn_Extraire"
        Me.btn_Extraire.Size = New System.Drawing.Size(112, 36)
        Me.btn_Extraire.TabIndex = 6
        Me.btn_Extraire.Text = "Extraire"
        '
        'btn_ExtraireTout
        '
        Me.btn_ExtraireTout.Image = CType(resources.GetObject("btn_ExtraireTout.Image"), System.Drawing.Image)
        Me.btn_ExtraireTout.Location = New System.Drawing.Point(3, 173)
        Me.btn_ExtraireTout.Name = "btn_ExtraireTout"
        Me.btn_ExtraireTout.Size = New System.Drawing.Size(112, 36)
        Me.btn_ExtraireTout.TabIndex = 7
        Me.btn_ExtraireTout.Text = "Extraire tout"
        '
        'Frm_GrosseRequete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(776, 674)
        Me.Name = "Frm_GrosseRequete"
        Me.Text = "Requête multicritères"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_GrosseRequete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.lkupEphemra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupEphemra2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupDDD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupDDD1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDDD_Dosage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupATC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupATC2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNumSP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtLibelleLong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtLibelleCourt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCIS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUCD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.GC7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpTauxRBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DeditApplication.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeditRadiation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DateEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DeditSupp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeditdispoDepuis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbEtatComercial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEAN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DsTheriaque_GrosseRequete As Theriaque.dsTheriaque_GrosseRequete
    Friend WithEvents PrE_TA As Theriaque.dsTheriaque_GrosseRequeteTableAdapters.PRE_PRESENTATIONTableAdapter
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SP_TA As Theriaque.dsTheriaque_GrosseRequeteTableAdapters.SP_SPECIALITETableAdapter
    Friend WithEvents txtUCD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtCIS As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtLibelleCourt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNumSP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtLibelleLong As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lkupATC As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkupATC2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lkupDDD As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lkupDDD1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDDD_Dosage As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SpddD_TA As Theriaque.dsTheriaque_GrosseRequeteTableAdapters.SPDDD_DOSE_USUELLE_JOURTableAdapter
    Friend WithEvents lkupEphemra As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkupEphemra2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEAN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DeditSupp As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents DeditdispoDepuis As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbEtatComercial As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents PretsS_TA As Theriaque.dsTheriaque_GrosseRequeteTableAdapters.PRETSS_PRESENTATION_TAUXTableAdapter
    Friend WithEvents GC7 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPRETSS_PRE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRETSS_CDF_TSS_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRETSS_NUMSEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRETSS_DATE_APPLI_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRETSS_DATE_APPLIQUEE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRETSS_TEXTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpTauxRBS As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DateEdit4 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DeditApplication As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DeditRadiation As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Extraire As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SFDialogEnregistrer As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btn_ExtraireTout As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar

End Class
