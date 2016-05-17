<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ExcipientFils
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
        Me.SaU_TA = New Theriaque.dsTheriaque_ExcipientTableAdapters.SAU_SUBAUXILIAIRETableAdapter
        Me.DsTheriaque_Excipient = New Theriaque.dsTheriaque_Excipient
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PanPere = New System.Windows.Forms.Panel
        Me.lkupSAU_GSAU_CODE_FK = New DevExpress.XtraEditors.LookUpEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCodePere = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLibelle = New DevExpress.XtraEditors.TextEdit
        Me.GsaU_TA = New Theriaque.dsTheriaque_ExcipientTableAdapters.GSAU_PERE_SUBAUXTableAdapter
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GC15 = New DevExpress.XtraGrid.GridControl
        Me.GV15 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSAUCAS_SAU_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAUCAS_CAS_CODE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAUCAS_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC16 = New DevExpress.XtraGrid.GridControl
        Me.GV16 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSAUNAV_SAU_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAUNAV_CDF_NAV_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAUNAV_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_SAUNAV = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GC13 = New DevExpress.XtraGrid.GridControl
        Me.GV13 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colADSAU_NOM_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colADSAU_SAU_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC14 = New DevExpress.XtraGrid.GridControl
        Me.GV14 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSAUCCH_SAU_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAUCCH_CCH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_SAUCCH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.GC11 = New DevExpress.XtraGrid.GridControl
        Me.GV11 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSYSAU_NOM_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSYSAU_SAU_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC12 = New DevExpress.XtraGrid.GridControl
        Me.GV12 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSAUAFS_SAU_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAUAFS_CDF_DOCUMENT_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAUAFS_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_SAUAFS = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.MemoEdit3 = New DevExpress.XtraEditors.MemoEdit
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.lkup_REF = New DevExpress.XtraEditors.LookUpEdit
        Me.Date_REF = New DevExpress.XtraEditors.DateEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.DateDisponible = New DevExpress.XtraEditors.DateEdit
        Me.cmbDisponible = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtSAU_SAC_CODE_FK = New DevExpress.XtraEditors.TextEdit
        Me.cmbSubac = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.GC22 = New DevExpress.XtraGrid.GridControl
        Me.GV22 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSAUVO_SAU_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAUVO_CDF_VOIE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAUVO_DOSESEUIL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rcmb_SAUVO = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.colSAUVO_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColVoie = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_SAUVO = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.GC21 = New DevExpress.XtraGrid.GridControl
        Me.GV21 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSAUNAT_SAU_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAUNAT_CDF_NASAU_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAUNAT_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_SAUNAT = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.SysaU_TA = New Theriaque.dsTheriaque_ExcipientTableAdapters.SYSAU_SYNONYME_SAUTableAdapter
        Me.SauafS_TA = New Theriaque.dsTheriaque_ExcipientTableAdapters.SAUAFS_SAU_AFSTableAdapter
        Me.AdsaU_TA = New Theriaque.dsTheriaque_ExcipientTableAdapters.ADSAU_AUTRE_DENOMINATION_SUBAUTableAdapter
        Me.SauccH_TA = New Theriaque.dsTheriaque_ExcipientTableAdapters.SAUCCH_SUBAUX_CLASSECHTableAdapter
        Me.SaucaS_TA = New Theriaque.dsTheriaque_ExcipientTableAdapters.SAUCAS_SAU_CASTableAdapter
        Me.SaunaV_TA = New Theriaque.dsTheriaque_ExcipientTableAdapters.SAUNAV_SUBAUX_NATURE_VECTTableAdapter
        Me.SaunaT_TA = New Theriaque.dsTheriaque_ExcipientTableAdapters.SAUNAT_SUBAUX_NATURETableAdapter
        Me.SauvO_TA = New Theriaque.dsTheriaque_ExcipientTableAdapters.SAUVO_SUBAUXVOIE_SUBAUXTableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_Excipient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.PanPere.SuspendLayout()
        CType(Me.lkupSAU_GSAU_CODE_FK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodePere.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GC15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_SAUNAV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.GC13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_SAUCCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.GC11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_SAUAFS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.MemoEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.lkup_REF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_REF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateDisponible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDisponible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSAU_SAC_CODE_FK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSubac.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.GC22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rcmb_SAUVO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_SAUVO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.GC21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_SAUNAT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(757, 580)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.XtraTabControl1)
        Me.PanMain.Controls.Add(Me.GroupBox1)
        Me.PanMain.Size = New System.Drawing.Size(639, 493)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(757, 87)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(757, 28)
        Me.Label1.Text = "Excipient - Fils"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(639, 87)
        Me.Panel1.Size = New System.Drawing.Size(118, 493)
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Excipient, "SAU_SUBAUXILIAIRE.SAU_DATEMJ", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Size = New System.Drawing.Size(757, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Excipient, "SAU_SUBAUXILIAIRE.SAU_DATECR", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        '
        'btAdvancedSearch
        '
        Me.btAdvancedSearch.Visible = True
        '
        'btDupliquer
        '
        Me.btDupliquer.Visible = True
        '
        'btn_RechMulti
        '
        Me.btn_RechMulti.Visible = True
        '
        'SaU_TA
        '
        Me.SaU_TA.ClearBeforeFill = True
        '
        'DsTheriaque_Excipient
        '
        Me.DsTheriaque_Excipient.DataSetName = "dsTheriaque_Excipient"
        Me.DsTheriaque_Excipient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PanPere)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtLibelle)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(639, 66)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'PanPere
        '
        Me.PanPere.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanPere.Controls.Add(Me.lkupSAU_GSAU_CODE_FK)
        Me.PanPere.Controls.Add(Me.Label4)
        Me.PanPere.Controls.Add(Me.Label5)
        Me.PanPere.Controls.Add(Me.txtCodePere)
        Me.PanPere.Location = New System.Drawing.Point(12, 11)
        Me.PanPere.Name = "PanPere"
        Me.PanPere.Size = New System.Drawing.Size(492, 26)
        Me.PanPere.TabIndex = 37
        '
        'lkupSAU_GSAU_CODE_FK
        '
        Me.lkupSAU_GSAU_CODE_FK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkupSAU_GSAU_CODE_FK.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Excipient, "SAU_SUBAUXILIAIRE.SAU_GSAU_CODE_FK", True))
        Me.lkupSAU_GSAU_CODE_FK.Location = New System.Drawing.Point(229, 4)
        Me.lkupSAU_GSAU_CODE_FK.Name = "lkupSAU_GSAU_CODE_FK"
        Me.lkupSAU_GSAU_CODE_FK.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.lkupSAU_GSAU_CODE_FK.Properties.Appearance.Options.UseBackColor = True
        Me.lkupSAU_GSAU_CODE_FK.Properties.NullText = ""
        Me.lkupSAU_GSAU_CODE_FK.Properties.ReadOnly = True
        Me.lkupSAU_GSAU_CODE_FK.Size = New System.Drawing.Size(253, 20)
        Me.lkupSAU_GSAU_CODE_FK.TabIndex = 20
        Me.lkupSAU_GSAU_CODE_FK.TabStop = False
        Me.lkupSAU_GSAU_CODE_FK.Tag = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(18, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Code père"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(186, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Libellé"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodePere
        '
        Me.txtCodePere.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Excipient, "SAU_SUBAUXILIAIRE.SAU_GSAU_CODE_FK", True))
        Me.txtCodePere.Location = New System.Drawing.Point(80, 3)
        Me.txtCodePere.Name = "txtCodePere"
        Me.txtCodePere.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.txtCodePere.Properties.Appearance.Options.UseBackColor = True
        Me.txtCodePere.Properties.ReadOnly = True
        Me.txtCodePere.Size = New System.Drawing.Size(100, 20)
        Me.txtCodePere.TabIndex = 19
        Me.txtCodePere.TabStop = False
        Me.txtCodePere.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Fiche N°"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Excipient, "SAU_SUBAUXILIAIRE.SAU_CODE_SQ_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(92, 39)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 31
        Me.txtCode.Tag = "[NOEDIT][NOADD]"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(198, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Libellé"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLibelle
        '
        Me.txtLibelle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLibelle.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Excipient, "SAU_SUBAUXILIAIRE.SAU_NOM", True))
        Me.txtLibelle.Location = New System.Drawing.Point(241, 41)
        Me.txtLibelle.Name = "txtLibelle"
        Me.txtLibelle.Size = New System.Drawing.Size(253, 20)
        Me.txtLibelle.TabIndex = 32
        Me.txtLibelle.Tag = "[EDIT][ADD]"
        '
        'GsaU_TA
        '
        Me.GsaU_TA.ClearBeforeFill = True
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Location = New System.Drawing.Point(3, 72)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(633, 418)
        Me.XtraTabControl1.TabIndex = 2
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panel3)
        Me.XtraTabPage1.Controls.Add(Me.Panel2)
        Me.XtraTabPage1.Controls.Add(Me.Panel5)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(624, 387)
        Me.XtraTabPage1.Text = "Excipient 1/2"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GC15)
        Me.Panel3.Controls.Add(Me.GC16)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 252)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(624, 135)
        Me.Panel3.TabIndex = 20
        '
        'GC15
        '
        Me.GC15.DataMember = "SAUCAS_SAU_CAS"
        Me.GC15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC15.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC15.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC15.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC15.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC15.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC15.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC15.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC15.EmbeddedNavigator.Name = ""
        Me.GC15.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC15.Location = New System.Drawing.Point(0, 0)
        Me.GC15.MainView = Me.GV15
        Me.GC15.Name = "GC15"
        Me.GC15.Size = New System.Drawing.Size(321, 135)
        Me.GC15.TabIndex = 2
        Me.GC15.Tag = "[EDIT][ADD]"
        Me.GC15.UseEmbeddedNavigator = True
        Me.GC15.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV15})
        '
        'GV15
        '
        Me.GV15.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSAUCAS_SAU_CODE_FK_PK, Me.colSAUCAS_CAS_CODE_PK, Me.colSAUCAS_NUMORD})
        Me.GV15.GridControl = Me.GC15
        Me.GV15.Name = "GV15"
        Me.GV15.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV15.OptionsView.ShowGroupPanel = False
        Me.GV15.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSAUCAS_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colSAUCAS_SAU_CODE_FK_PK
        '
        Me.colSAUCAS_SAU_CODE_FK_PK.Caption = "SAUCAS_SAU_CODE_FK_PK"
        Me.colSAUCAS_SAU_CODE_FK_PK.FieldName = "SAUCAS_SAU_CODE_FK_PK"
        Me.colSAUCAS_SAU_CODE_FK_PK.Name = "colSAUCAS_SAU_CODE_FK_PK"
        '
        'colSAUCAS_CAS_CODE_PK
        '
        Me.colSAUCAS_CAS_CODE_PK.Caption = "Code CAS"
        Me.colSAUCAS_CAS_CODE_PK.FieldName = "SAUCAS_CAS_CODE_PK"
        Me.colSAUCAS_CAS_CODE_PK.Name = "colSAUCAS_CAS_CODE_PK"
        Me.colSAUCAS_CAS_CODE_PK.Visible = True
        Me.colSAUCAS_CAS_CODE_PK.VisibleIndex = 0
        Me.colSAUCAS_CAS_CODE_PK.Width = 243
        '
        'colSAUCAS_NUMORD
        '
        Me.colSAUCAS_NUMORD.Caption = "N°"
        Me.colSAUCAS_NUMORD.FieldName = "SAUCAS_NUMORD"
        Me.colSAUCAS_NUMORD.Name = "colSAUCAS_NUMORD"
        Me.colSAUCAS_NUMORD.Visible = True
        Me.colSAUCAS_NUMORD.VisibleIndex = 1
        Me.colSAUCAS_NUMORD.Width = 50
        '
        'GC16
        '
        Me.GC16.DataMember = "SAUNAV_SUBAUX_NATURE_VECT"
        Me.GC16.Dock = System.Windows.Forms.DockStyle.Right
        Me.GC16.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC16.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC16.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC16.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC16.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC16.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC16.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC16.EmbeddedNavigator.Name = ""
        Me.GC16.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC16.Location = New System.Drawing.Point(321, 0)
        Me.GC16.MainView = Me.GV16
        Me.GC16.Name = "GC16"
        Me.GC16.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_SAUNAV})
        Me.GC16.Size = New System.Drawing.Size(303, 135)
        Me.GC16.TabIndex = 3
        Me.GC16.Tag = "[EDIT][ADD]"
        Me.GC16.UseEmbeddedNavigator = True
        Me.GC16.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV16})
        '
        'GV16
        '
        Me.GV16.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSAUNAV_SAU_CODE_FK_PK, Me.colSAUNAV_CDF_NAV_CODE_FK_PK, Me.colSAUNAV_NUMORD, Me.GridColumn3})
        Me.GV16.GridControl = Me.GC16
        Me.GV16.Name = "GV16"
        Me.GV16.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV16.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV16.OptionsView.ShowGroupPanel = False
        Me.GV16.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSAUNAV_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colSAUNAV_SAU_CODE_FK_PK
        '
        Me.colSAUNAV_SAU_CODE_FK_PK.Caption = "SAUNAV_SAU_CODE_FK_PK"
        Me.colSAUNAV_SAU_CODE_FK_PK.FieldName = "SAUNAV_SAU_CODE_FK_PK"
        Me.colSAUNAV_SAU_CODE_FK_PK.Name = "colSAUNAV_SAU_CODE_FK_PK"
        '
        'colSAUNAV_CDF_NAV_CODE_FK_PK
        '
        Me.colSAUNAV_CDF_NAV_CODE_FK_PK.Caption = "Code"
        Me.colSAUNAV_CDF_NAV_CODE_FK_PK.FieldName = "SAUNAV_CDF_NAV_CODE_FK_PK"
        Me.colSAUNAV_CDF_NAV_CODE_FK_PK.Name = "colSAUNAV_CDF_NAV_CODE_FK_PK"
        Me.colSAUNAV_CDF_NAV_CODE_FK_PK.Visible = True
        Me.colSAUNAV_CDF_NAV_CODE_FK_PK.VisibleIndex = 0
        Me.colSAUNAV_CDF_NAV_CODE_FK_PK.Width = 50
        '
        'colSAUNAV_NUMORD
        '
        Me.colSAUNAV_NUMORD.Caption = "N°"
        Me.colSAUNAV_NUMORD.FieldName = "SAUNAV_NUMORD"
        Me.colSAUNAV_NUMORD.Name = "colSAUNAV_NUMORD"
        Me.colSAUNAV_NUMORD.Visible = True
        Me.colSAUNAV_NUMORD.VisibleIndex = 2
        Me.colSAUNAV_NUMORD.Width = 50
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Nature vecteur"
        Me.GridColumn3.ColumnEdit = Me.lkup_SAUNAV
        Me.GridColumn3.FieldName = "SAUNAV_CDF_NAV_CODE_FK_PK"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 183
        '
        'lkup_SAUNAV
        '
        Me.lkup_SAUNAV.AutoHeight = False
        Me.lkup_SAUNAV.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_SAUNAV.Name = "lkup_SAUNAV"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GC13)
        Me.Panel2.Controls.Add(Me.GC14)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 126)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(624, 126)
        Me.Panel2.TabIndex = 19
        '
        'GC13
        '
        Me.GC13.DataMember = "ADSAU_AUTRE_DENOMINATION_SUBAU"
        Me.GC13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC13.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC13.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC13.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC13.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC13.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC13.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC13.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC13.EmbeddedNavigator.Name = ""
        Me.GC13.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC13.Location = New System.Drawing.Point(0, 0)
        Me.GC13.MainView = Me.GV13
        Me.GC13.Name = "GC13"
        Me.GC13.Size = New System.Drawing.Size(321, 126)
        Me.GC13.TabIndex = 2
        Me.GC13.Tag = "[EDIT][ADD]"
        Me.GC13.UseEmbeddedNavigator = True
        Me.GC13.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV13})
        '
        'GV13
        '
        Me.GV13.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colADSAU_NOM_PK, Me.colADSAU_SAU_CODE_FK})
        Me.GV13.GridControl = Me.GC13
        Me.GV13.Name = "GV13"
        Me.GV13.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV13.OptionsView.ShowGroupPanel = False
        '
        'colADSAU_NOM_PK
        '
        Me.colADSAU_NOM_PK.Caption = "Autres dénominations"
        Me.colADSAU_NOM_PK.FieldName = "ADSAU_NOM_PK"
        Me.colADSAU_NOM_PK.Name = "colADSAU_NOM_PK"
        Me.colADSAU_NOM_PK.Visible = True
        Me.colADSAU_NOM_PK.VisibleIndex = 0
        Me.colADSAU_NOM_PK.Width = 250
        '
        'colADSAU_SAU_CODE_FK
        '
        Me.colADSAU_SAU_CODE_FK.Caption = "ADSAU_SAU_CODE_FK"
        Me.colADSAU_SAU_CODE_FK.FieldName = "ADSAU_SAU_CODE_FK"
        Me.colADSAU_SAU_CODE_FK.Name = "colADSAU_SAU_CODE_FK"
        Me.colADSAU_SAU_CODE_FK.Width = 50
        '
        'GC14
        '
        Me.GC14.DataMember = "SAUCCH_SUBAUX_CLASSECH"
        Me.GC14.Dock = System.Windows.Forms.DockStyle.Right
        Me.GC14.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC14.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC14.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC14.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC14.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC14.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC14.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC14.EmbeddedNavigator.Name = ""
        Me.GC14.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC14.Location = New System.Drawing.Point(321, 0)
        Me.GC14.MainView = Me.GV14
        Me.GC14.Name = "GC14"
        Me.GC14.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_SAUCCH})
        Me.GC14.Size = New System.Drawing.Size(303, 126)
        Me.GC14.TabIndex = 3
        Me.GC14.Tag = "[EDIT][ADD]"
        Me.GC14.UseEmbeddedNavigator = True
        Me.GC14.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV14})
        '
        'GV14
        '
        Me.GV14.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSAUCCH_SAU_CODE_FK_PK, Me.colSAUCCH_CCH_CODE_FK_PK, Me.GridColumn2})
        Me.GV14.GridControl = Me.GC14
        Me.GV14.Name = "GV14"
        Me.GV14.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV14.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV14.OptionsView.ShowGroupPanel = False
        '
        'colSAUCCH_SAU_CODE_FK_PK
        '
        Me.colSAUCCH_SAU_CODE_FK_PK.Caption = "SAUCCH_SAU_CODE_FK_PK"
        Me.colSAUCCH_SAU_CODE_FK_PK.FieldName = "SAUCCH_SAU_CODE_FK_PK"
        Me.colSAUCCH_SAU_CODE_FK_PK.Name = "colSAUCCH_SAU_CODE_FK_PK"
        '
        'colSAUCCH_CCH_CODE_FK_PK
        '
        Me.colSAUCCH_CCH_CODE_FK_PK.Caption = "Code"
        Me.colSAUCCH_CCH_CODE_FK_PK.FieldName = "SAUCCH_CCH_CODE_FK_PK"
        Me.colSAUCCH_CCH_CODE_FK_PK.Name = "colSAUCCH_CCH_CODE_FK_PK"
        Me.colSAUCCH_CCH_CODE_FK_PK.Visible = True
        Me.colSAUCCH_CCH_CODE_FK_PK.VisibleIndex = 0
        Me.colSAUCCH_CCH_CODE_FK_PK.Width = 50
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Classe chimique"
        Me.GridColumn2.ColumnEdit = Me.lkup_SAUCCH
        Me.GridColumn2.FieldName = "SAUCCH_CCH_CODE_FK_PK"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 232
        '
        'lkup_SAUCCH
        '
        Me.lkup_SAUCCH.AutoHeight = False
        Me.lkup_SAUCCH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_SAUCCH.Name = "lkup_SAUCCH"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GC11)
        Me.Panel5.Controls.Add(Me.GC12)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(624, 126)
        Me.Panel5.TabIndex = 18
        '
        'GC11
        '
        Me.GC11.DataMember = "SYSAU_SYNONYME_SAU"
        Me.GC11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC11.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC11.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC11.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC11.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC11.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC11.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC11.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC11.EmbeddedNavigator.Name = ""
        Me.GC11.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC11.Location = New System.Drawing.Point(0, 0)
        Me.GC11.MainView = Me.GV11
        Me.GC11.Name = "GC11"
        Me.GC11.Size = New System.Drawing.Size(321, 126)
        Me.GC11.TabIndex = 2
        Me.GC11.Tag = "[EDIT][ADD]"
        Me.GC11.UseEmbeddedNavigator = True
        Me.GC11.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV11})
        '
        'GV11
        '
        Me.GV11.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSYSAU_NOM_PK, Me.colSYSAU_SAU_CODE_FK})
        Me.GV11.GridControl = Me.GC11
        Me.GV11.Name = "GV11"
        Me.GV11.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV11.OptionsView.ShowGroupPanel = False
        '
        'colSYSAU_NOM_PK
        '
        Me.colSYSAU_NOM_PK.Caption = "Synonymes"
        Me.colSYSAU_NOM_PK.FieldName = "SYSAU_NOM_PK"
        Me.colSYSAU_NOM_PK.Name = "colSYSAU_NOM_PK"
        Me.colSYSAU_NOM_PK.Visible = True
        Me.colSYSAU_NOM_PK.VisibleIndex = 0
        Me.colSYSAU_NOM_PK.Width = 250
        '
        'colSYSAU_SAU_CODE_FK
        '
        Me.colSYSAU_SAU_CODE_FK.Caption = "SYSAU_SAU_CODE_FK"
        Me.colSYSAU_SAU_CODE_FK.FieldName = "SYSAU_SAU_CODE_FK"
        Me.colSYSAU_SAU_CODE_FK.Name = "colSYSAU_SAU_CODE_FK"
        Me.colSYSAU_SAU_CODE_FK.Width = 50
        '
        'GC12
        '
        Me.GC12.DataMember = "SAUAFS_SAU_AFS"
        Me.GC12.Dock = System.Windows.Forms.DockStyle.Right
        Me.GC12.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC12.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC12.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC12.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC12.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC12.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC12.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC12.EmbeddedNavigator.Name = ""
        Me.GC12.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC12.Location = New System.Drawing.Point(321, 0)
        Me.GC12.MainView = Me.GV12
        Me.GC12.Name = "GC12"
        Me.GC12.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_SAUAFS})
        Me.GC12.Size = New System.Drawing.Size(303, 126)
        Me.GC12.TabIndex = 3
        Me.GC12.Tag = "[EDIT][ADD]"
        Me.GC12.UseEmbeddedNavigator = True
        Me.GC12.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV12})
        '
        'GV12
        '
        Me.GV12.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSAUAFS_SAU_CODE_FK_PK, Me.colSAUAFS_CDF_DOCUMENT_FK_PK, Me.colSAUAFS_NUMORD, Me.GridColumn1})
        Me.GV12.GridControl = Me.GC12
        Me.GV12.Name = "GV12"
        Me.GV12.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV12.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV12.OptionsView.ShowGroupPanel = False
        Me.GV12.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSAUAFS_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colSAUAFS_SAU_CODE_FK_PK
        '
        Me.colSAUAFS_SAU_CODE_FK_PK.Caption = "SAUAFS_SAU_CODE_FK_PK"
        Me.colSAUAFS_SAU_CODE_FK_PK.FieldName = "SAUAFS_SAU_CODE_FK_PK"
        Me.colSAUAFS_SAU_CODE_FK_PK.Name = "colSAUAFS_SAU_CODE_FK_PK"
        Me.colSAUAFS_SAU_CODE_FK_PK.Width = 50
        '
        'colSAUAFS_CDF_DOCUMENT_FK_PK
        '
        Me.colSAUAFS_CDF_DOCUMENT_FK_PK.Caption = "Code"
        Me.colSAUAFS_CDF_DOCUMENT_FK_PK.FieldName = "SAUAFS_CDF_DOCUMENT_FK_PK"
        Me.colSAUAFS_CDF_DOCUMENT_FK_PK.Name = "colSAUAFS_CDF_DOCUMENT_FK_PK"
        Me.colSAUAFS_CDF_DOCUMENT_FK_PK.Visible = True
        Me.colSAUAFS_CDF_DOCUMENT_FK_PK.VisibleIndex = 0
        Me.colSAUAFS_CDF_DOCUMENT_FK_PK.Width = 39
        '
        'colSAUAFS_NUMORD
        '
        Me.colSAUAFS_NUMORD.Caption = "N°"
        Me.colSAUAFS_NUMORD.FieldName = "SAUAFS_NUMORD"
        Me.colSAUAFS_NUMORD.Name = "colSAUAFS_NUMORD"
        Me.colSAUAFS_NUMORD.Visible = True
        Me.colSAUAFS_NUMORD.VisibleIndex = 2
        Me.colSAUAFS_NUMORD.Width = 50
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Références"
        Me.GridColumn1.ColumnEdit = Me.lkup_SAUAFS
        Me.GridColumn1.FieldName = "SAUAFS_CDF_DOCUMENT_FK_PK"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 183
        '
        'lkup_SAUAFS
        '
        Me.lkup_SAUAFS.AutoHeight = False
        Me.lkup_SAUAFS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_SAUAFS.Name = "lkup_SAUAFS"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Panel8)
        Me.XtraTabPage2.Controls.Add(Me.Panel7)
        Me.XtraTabPage2.Controls.Add(Me.Panel6)
        Me.XtraTabPage2.Controls.Add(Me.Panel4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(624, 387)
        Me.XtraTabPage2.Text = "Excipient 2/2"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Panel10)
        Me.Panel8.Controls.Add(Me.Panel11)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 300)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(624, 87)
        Me.Panel8.TabIndex = 41
        Me.Panel8.Tag = ""
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.MemoEdit3)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(0, 23)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(624, 64)
        Me.Panel10.TabIndex = 38
        Me.Panel10.Tag = "[ADD][EDIT]"
        '
        'MemoEdit3
        '
        Me.MemoEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Excipient, "SAU_SUBAUXILIAIRE.SAU_TEXTE", True))
        Me.MemoEdit3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoEdit3.Location = New System.Drawing.Point(0, 0)
        Me.MemoEdit3.Name = "MemoEdit3"
        Me.MemoEdit3.Size = New System.Drawing.Size(624, 64)
        Me.MemoEdit3.TabIndex = 36
        Me.MemoEdit3.Tag = ""
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.LabelControl7)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(624, 23)
        Me.Panel11.TabIndex = 37
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(2, 4)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl7.TabIndex = 19
        Me.LabelControl7.Text = "Texte"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.lkup_REF)
        Me.Panel7.Controls.Add(Me.Date_REF)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Controls.Add(Me.ComboBoxEdit1)
        Me.Panel7.Controls.Add(Me.DateDisponible)
        Me.Panel7.Controls.Add(Me.cmbDisponible)
        Me.Panel7.Controls.Add(Me.Label9)
        Me.Panel7.Controls.Add(Me.txtSAU_SAC_CODE_FK)
        Me.Panel7.Controls.Add(Me.cmbSubac)
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 172)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(624, 128)
        Me.Panel7.TabIndex = 22
        '
        'lkup_REF
        '
        Me.lkup_REF.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Excipient, "SAU_SUBAUXILIAIRE.SAU_CDF_DOC_CODE_FK", True))
        Me.lkup_REF.Location = New System.Drawing.Point(130, 91)
        Me.lkup_REF.Name = "lkup_REF"
        Me.lkup_REF.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_REF.Size = New System.Drawing.Size(208, 20)
        Me.lkup_REF.TabIndex = 53
        '
        'Date_REF
        '
        Me.Date_REF.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Excipient, "SAU_SUBAUXILIAIRE.SAU_DOC_DATE", True))
        Me.Date_REF.EditValue = Nothing
        Me.Date_REF.Location = New System.Drawing.Point(344, 91)
        Me.Date_REF.Name = "Date_REF"
        Me.Date_REF.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_REF.Size = New System.Drawing.Size(145, 20)
        Me.Date_REF.TabIndex = 52
        Me.Date_REF.Tag = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(60, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Références"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "A effet notoire (O/N)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Excipient, "SAU_SUBAUXILIAIRE.SAU_EFFETNOTOIRE", True))
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(130, 64)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"O", "N"})
        Me.ComboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(53, 20)
        Me.ComboBoxEdit1.TabIndex = 48
        '
        'DateDisponible
        '
        Me.DateDisponible.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Excipient, "SAU_SUBAUXILIAIRE.SAU_DATECOMMER", True))
        Me.DateDisponible.EditValue = Nothing
        Me.DateDisponible.Location = New System.Drawing.Point(193, 39)
        Me.DateDisponible.Name = "DateDisponible"
        Me.DateDisponible.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateDisponible.Size = New System.Drawing.Size(145, 20)
        Me.DateDisponible.TabIndex = 47
        Me.DateDisponible.Tag = ""
        '
        'cmbDisponible
        '
        Me.cmbDisponible.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Excipient, "SAU_SUBAUXILIAIRE.SAU_ETAT_COMMER", True))
        Me.cmbDisponible.Location = New System.Drawing.Point(130, 37)
        Me.cmbDisponible.Name = "cmbDisponible"
        Me.cmbDisponible.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDisponible.Properties.Items.AddRange(New Object() {"D", "S", "NC"})
        Me.cmbDisponible.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbDisponible.Size = New System.Drawing.Size(53, 20)
        Me.cmbDisponible.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 13)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Disponible (D/NC/S)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSAU_SAC_CODE_FK
        '
        Me.txtSAU_SAC_CODE_FK.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Excipient, "SAU_SUBAUXILIAIRE.SAU_SAC_CODE_FK", True))
        Me.txtSAU_SAC_CODE_FK.Location = New System.Drawing.Point(193, 10)
        Me.txtSAU_SAC_CODE_FK.Name = "txtSAU_SAC_CODE_FK"
        Me.txtSAU_SAC_CODE_FK.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSAU_SAC_CODE_FK.Size = New System.Drawing.Size(58, 20)
        Me.txtSAU_SAC_CODE_FK.TabIndex = 44
        Me.txtSAU_SAC_CODE_FK.Tag = "[NOEDIT][NOADD]"
        '
        'cmbSubac
        '
        Me.cmbSubac.EditValue = "N"
        Me.cmbSubac.Location = New System.Drawing.Point(130, 10)
        Me.cmbSubac.Name = "cmbSubac"
        Me.cmbSubac.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSubac.Properties.Items.AddRange(New Object() {"O", "N"})
        Me.cmbSubac.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbSubac.Size = New System.Drawing.Size(53, 20)
        Me.cmbSubac.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Substance active (O/N)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GC22)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 83)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(624, 89)
        Me.Panel6.TabIndex = 21
        '
        'GC22
        '
        Me.GC22.DataMember = "SAUVO_SUBAUXVOIE_SUBAUX"
        Me.GC22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC22.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC22.EmbeddedNavigator.Name = ""
        Me.GC22.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC22.Location = New System.Drawing.Point(0, 0)
        Me.GC22.MainView = Me.GV22
        Me.GC22.Name = "GC22"
        Me.GC22.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_SAUVO, Me.rcmb_SAUVO})
        Me.GC22.Size = New System.Drawing.Size(624, 89)
        Me.GC22.TabIndex = 20
        Me.GC22.Tag = "[EDIT][ADD]"
        Me.GC22.UseEmbeddedNavigator = True
        Me.GC22.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV22})
        '
        'GV22
        '
        Me.GV22.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSAUVO_SAU_CODE_FK_PK, Me.colSAUVO_CDF_VOIE_CODE_FK_PK, Me.colSAUVO_DOSESEUIL, Me.colSAUVO_NUMORD, Me.ColVoie})
        Me.GV22.GridControl = Me.GC22
        Me.GV22.Name = "GV22"
        Me.GV22.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV22.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV22.OptionsView.ShowGroupPanel = False
        Me.GV22.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSAUVO_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colSAUVO_SAU_CODE_FK_PK
        '
        Me.colSAUVO_SAU_CODE_FK_PK.Caption = "SAUVO_SAU_CODE_FK_PK"
        Me.colSAUVO_SAU_CODE_FK_PK.FieldName = "SAUVO_SAU_CODE_FK_PK"
        Me.colSAUVO_SAU_CODE_FK_PK.Name = "colSAUVO_SAU_CODE_FK_PK"
        '
        'colSAUVO_CDF_VOIE_CODE_FK_PK
        '
        Me.colSAUVO_CDF_VOIE_CODE_FK_PK.Caption = "SAUVO_CDF_VOIE_CODE_FK_PK"
        Me.colSAUVO_CDF_VOIE_CODE_FK_PK.FieldName = "SAUVO_CDF_VOIE_CODE_FK_PK"
        Me.colSAUVO_CDF_VOIE_CODE_FK_PK.Name = "colSAUVO_CDF_VOIE_CODE_FK_PK"
        '
        'colSAUVO_DOSESEUIL
        '
        Me.colSAUVO_DOSESEUIL.Caption = "Dose seuil (O/N)"
        Me.colSAUVO_DOSESEUIL.ColumnEdit = Me.rcmb_SAUVO
        Me.colSAUVO_DOSESEUIL.FieldName = "SAUVO_DOSESEUIL"
        Me.colSAUVO_DOSESEUIL.Name = "colSAUVO_DOSESEUIL"
        Me.colSAUVO_DOSESEUIL.Visible = True
        Me.colSAUVO_DOSESEUIL.VisibleIndex = 0
        Me.colSAUVO_DOSESEUIL.Width = 97
        '
        'rcmb_SAUVO
        '
        Me.rcmb_SAUVO.AutoHeight = False
        Me.rcmb_SAUVO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rcmb_SAUVO.Items.AddRange(New Object() {"O", "N"})
        Me.rcmb_SAUVO.Name = "rcmb_SAUVO"
        '
        'colSAUVO_NUMORD
        '
        Me.colSAUVO_NUMORD.Caption = "N°"
        Me.colSAUVO_NUMORD.FieldName = "SAUVO_NUMORD"
        Me.colSAUVO_NUMORD.Name = "colSAUVO_NUMORD"
        Me.colSAUVO_NUMORD.Visible = True
        Me.colSAUVO_NUMORD.VisibleIndex = 2
        Me.colSAUVO_NUMORD.Width = 50
        '
        'ColVoie
        '
        Me.ColVoie.Caption = "Voie"
        Me.ColVoie.ColumnEdit = Me.lkup_SAUVO
        Me.ColVoie.FieldName = "SAUVO_CDF_VOIE_CODE_FK_PK"
        Me.ColVoie.Name = "ColVoie"
        Me.ColVoie.Visible = True
        Me.ColVoie.VisibleIndex = 1
        Me.ColVoie.Width = 438
        '
        'lkup_SAUVO
        '
        Me.lkup_SAUVO.AutoHeight = False
        Me.lkup_SAUVO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_SAUVO.Name = "lkup_SAUVO"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GC21)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(624, 83)
        Me.Panel4.TabIndex = 19
        '
        'GC21
        '
        Me.GC21.DataMember = "SAUNAT_SUBAUX_NATURE"
        Me.GC21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC21.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC21.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC21.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC21.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC21.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC21.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC21.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC21.EmbeddedNavigator.Name = ""
        Me.GC21.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC21.Location = New System.Drawing.Point(0, 0)
        Me.GC21.MainView = Me.GV21
        Me.GC21.Name = "GC21"
        Me.GC21.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_SAUNAT})
        Me.GC21.Size = New System.Drawing.Size(624, 83)
        Me.GC21.TabIndex = 2
        Me.GC21.Tag = "[EDIT][ADD]"
        Me.GC21.UseEmbeddedNavigator = True
        Me.GC21.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV21})
        '
        'GV21
        '
        Me.GV21.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSAUNAT_SAU_CODE_FK_PK, Me.colSAUNAT_CDF_NASAU_CODE_FK_PK, Me.colSAUNAT_NUMORD, Me.GridColumn4})
        Me.GV21.GridControl = Me.GC21
        Me.GV21.Name = "GV21"
        Me.GV21.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV21.OptionsView.ShowGroupPanel = False
        Me.GV21.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSAUNAT_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colSAUNAT_SAU_CODE_FK_PK
        '
        Me.colSAUNAT_SAU_CODE_FK_PK.Caption = "SAUNAT_SAU_CODE_FK_PK"
        Me.colSAUNAT_SAU_CODE_FK_PK.FieldName = "SAUNAT_SAU_CODE_FK_PK"
        Me.colSAUNAT_SAU_CODE_FK_PK.Name = "colSAUNAT_SAU_CODE_FK_PK"
        '
        'colSAUNAT_CDF_NASAU_CODE_FK_PK
        '
        Me.colSAUNAT_CDF_NASAU_CODE_FK_PK.Caption = "Code"
        Me.colSAUNAT_CDF_NASAU_CODE_FK_PK.FieldName = "SAUNAT_CDF_NASAU_CODE_FK_PK"
        Me.colSAUNAT_CDF_NASAU_CODE_FK_PK.Name = "colSAUNAT_CDF_NASAU_CODE_FK_PK"
        Me.colSAUNAT_CDF_NASAU_CODE_FK_PK.Visible = True
        Me.colSAUNAT_CDF_NASAU_CODE_FK_PK.VisibleIndex = 0
        Me.colSAUNAT_CDF_NASAU_CODE_FK_PK.Width = 50
        '
        'colSAUNAT_NUMORD
        '
        Me.colSAUNAT_NUMORD.Caption = "N°"
        Me.colSAUNAT_NUMORD.FieldName = "SAUNAT_NUMORD"
        Me.colSAUNAT_NUMORD.Name = "colSAUNAT_NUMORD"
        Me.colSAUNAT_NUMORD.Visible = True
        Me.colSAUNAT_NUMORD.VisibleIndex = 2
        Me.colSAUNAT_NUMORD.Width = 50
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Fonction excipient"
        Me.GridColumn4.ColumnEdit = Me.lkup_SAUNAT
        Me.GridColumn4.FieldName = "SAUNAT_CDF_NASAU_CODE_FK_PK"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 478
        '
        'lkup_SAUNAT
        '
        Me.lkup_SAUNAT.AutoHeight = False
        Me.lkup_SAUNAT.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_SAUNAT.Name = "lkup_SAUNAT"
        '
        'SysaU_TA
        '
        Me.SysaU_TA.ClearBeforeFill = True
        '
        'SauafS_TA
        '
        Me.SauafS_TA.ClearBeforeFill = True
        '
        'AdsaU_TA
        '
        Me.AdsaU_TA.ClearBeforeFill = True
        '
        'SauccH_TA
        '
        Me.SauccH_TA.ClearBeforeFill = True
        '
        'SaucaS_TA
        '
        Me.SaucaS_TA.ClearBeforeFill = True
        '
        'SaunaV_TA
        '
        Me.SaunaV_TA.ClearBeforeFill = True
        '
        'SaunaT_TA
        '
        Me.SaunaT_TA.ClearBeforeFill = True
        '
        'SauvO_TA
        '
        Me.SauvO_TA.ClearBeforeFill = True
        '
        'Frm_ExcipientFils
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(757, 580)
        Me.Name = "Frm_ExcipientFils"
        Me.Text = "Excipient - Fils"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_Excipient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanPere.ResumeLayout(False)
        Me.PanPere.PerformLayout()
        CType(Me.lkupSAU_GSAU_CODE_FK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodePere.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.GC15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_SAUNAV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GC13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_SAUCCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.GC11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_SAUAFS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        CType(Me.MemoEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.lkup_REF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_REF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateDisponible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDisponible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSAU_SAC_CODE_FK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSubac.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.GC22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rcmb_SAUVO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_SAUVO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.GC21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_SAUNAT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DsTheriaque_Excipient As Theriaque.dsTheriaque_Excipient
    Friend WithEvents SaU_TA As Theriaque.dsTheriaque_ExcipientTableAdapters.SAU_SUBAUXILIAIRETableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PanPere As System.Windows.Forms.Panel
    Friend WithEvents lkupSAU_GSAU_CODE_FK As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodePere As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLibelle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GsaU_TA As Theriaque.dsTheriaque_ExcipientTableAdapters.GSAU_PERE_SUBAUXTableAdapter
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GC11 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC12 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GC13 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC14 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSYSAU_NOM_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSYSAU_SAU_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SysaU_TA As Theriaque.dsTheriaque_ExcipientTableAdapters.SYSAU_SYNONYME_SAUTableAdapter
    Friend WithEvents SauafS_TA As Theriaque.dsTheriaque_ExcipientTableAdapters.SAUAFS_SAU_AFSTableAdapter
    Friend WithEvents colSAUAFS_SAU_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAUAFS_CDF_DOCUMENT_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAUAFS_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_SAUAFS As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colADSAU_NOM_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADSAU_SAU_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AdsaU_TA As Theriaque.dsTheriaque_ExcipientTableAdapters.ADSAU_AUTRE_DENOMINATION_SUBAUTableAdapter
    Friend WithEvents SauccH_TA As Theriaque.dsTheriaque_ExcipientTableAdapters.SAUCCH_SUBAUX_CLASSECHTableAdapter
    Friend WithEvents colSAUCCH_SAU_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAUCCH_CCH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_SAUCCH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GC15 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV15 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC16 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV16 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSAUCAS_SAU_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAUCAS_CAS_CODE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAUCAS_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaucaS_TA As Theriaque.dsTheriaque_ExcipientTableAdapters.SAUCAS_SAU_CASTableAdapter
    Friend WithEvents colSAUNAV_SAU_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAUNAV_CDF_NAV_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAUNAV_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_SAUNAV As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SaunaV_TA As Theriaque.dsTheriaque_ExcipientTableAdapters.SAUNAV_SUBAUX_NATURE_VECTTableAdapter
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GC21 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV21 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSAUNAT_SAU_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAUNAT_CDF_NASAU_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAUNAT_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_SAUNAT As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SaunaT_TA As Theriaque.dsTheriaque_ExcipientTableAdapters.SAUNAT_SUBAUX_NATURETableAdapter
    Friend WithEvents SauvO_TA As Theriaque.dsTheriaque_ExcipientTableAdapters.SAUVO_SUBAUXVOIE_SUBAUXTableAdapter
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents GC22 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV22 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSAUVO_SAU_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAUVO_CDF_VOIE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAUVO_DOSESEUIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rcmb_SAUVO As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colSAUVO_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColVoie As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_SAUVO As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents cmbSubac As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSAU_SAC_CODE_FK As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DateDisponible As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbDisponible As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Date_REF As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents MemoEdit3 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkup_REF As DevExpress.XtraEditors.LookUpEdit

End Class
