<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SubstanceActivFils
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_SubstanceActivFils))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtTypeRef = New DevExpress.XtraEditors.TextEdit
        Me.DsTheriaque_Nomenclature2 = New Theriaque.dsTheriaque_Nomenclature2
        Me.lbTypeRef = New System.Windows.Forms.Label
        Me.txtLibRef = New DevExpress.XtraEditors.TextEdit
        Me.lbLibRef = New System.Windows.Forms.Label
        Me.txtCodeRef = New DevExpress.XtraEditors.TextEdit
        Me.lbCodeRef = New System.Windows.Forms.Label
        Me.PanPere = New System.Windows.Forms.Panel
        Me.lkupSAC_GSAC_CODE_FK = New DevExpress.XtraEditors.LookUpEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCodePere = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLibelle = New DevExpress.XtraEditors.TextEdit
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GC3 = New DevExpress.XtraGrid.GridControl
        Me.GV3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSACCAS_CAS_CODE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSACCAS_SAC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GC4 = New DevExpress.XtraGrid.GridControl
        Me.GV4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colADSAC_NOM_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colADSAC_SAC_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.txtSAC_SAU_CODE_FK = New DevExpress.XtraEditors.TextEdit
        Me.cmbExcipient = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lkupSAC_CDF_ORN_CODE_FK = New DevExpress.XtraEditors.LookUpEdit
        Me.DateDisponible = New DevExpress.XtraEditors.DateEdit
        Me.cmbDisponible = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtLibAnglais = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PanelSyno = New System.Windows.Forms.Panel
        Me.PanelL = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSYFSAC_NOM_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSYFSAC_SAC_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PanelR = New System.Windows.Forms.Panel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.GC2 = New DevExpress.XtraGrid.GridControl
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSYASAC_NOM_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSYASAC_SAC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.PanClasse = New System.Windows.Forms.Panel
        Me.GC7 = New DevExpress.XtraGrid.GridControl
        Me.GV7 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSACCATC_CATC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpATC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSACCATC_SAC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSACCATC_CATC_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC6 = New DevExpress.XtraGrid.GridControl
        Me.GV6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSACCPH_SAC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSACCPH_CPH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpCPH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSACCPH_CPH_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC5 = New DevExpress.XtraGrid.GridControl
        Me.GV5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSACCCH_SAC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSACCCH_CCH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpCCH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSACCCH_CCH_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SaC_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.SAC_SUBACTIVETableAdapter
        Me.GsaC_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.GSAC_PERE_SUBACTTableAdapter
        Me.SyfsaC_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.SYFSAC_SYNONYMEFR_SUBACTTableAdapter
        Me.SyasaC_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.SYASAC_SYNONYMEANGLAIS_SACTableAdapter
        Me.SaccaS_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.SACCAS_SUBACT_CASTableAdapter
        Me.AdsaC_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.ADSAC_AUTRE_DENOMINATION_SUBACTableAdapter
        Me.SacccH_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.SACCCH_SUBACT_CLASSECHTableAdapter
        Me.SaccpH_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.SACCPH_SUBACT_CLASSEPHTableAdapter
        Me.SaccatC_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.SACCATC_SUBACT_CLASSEATCTableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtTypeRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_Nomenclature2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodeRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanPere.SuspendLayout()
        CType(Me.lkupSAC_GSAC_CODE_FK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodePere.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GC3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.GC4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.txtSAC_SAU_CODE_FK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbExcipient.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupSAC_CDF_ORN_CODE_FK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateDisponible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDisponible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibAnglais.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSyno.SuspendLayout()
        Me.PanelL.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelR.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.PanClasse.SuspendLayout()
        CType(Me.GC7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpATC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpCPH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpCCH, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Text = "Substance active fils"
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
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "SAC_SUBACTIVE.SAC_DATEMJ", True))
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
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "SAC_SUBACTIVE.SAC_DATECR", True))
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTypeRef)
        Me.GroupBox1.Controls.Add(Me.lbTypeRef)
        Me.GroupBox1.Controls.Add(Me.txtLibRef)
        Me.GroupBox1.Controls.Add(Me.lbLibRef)
        Me.GroupBox1.Controls.Add(Me.txtCodeRef)
        Me.GroupBox1.Controls.Add(Me.lbCodeRef)
        Me.GroupBox1.Controls.Add(Me.PanPere)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtLibelle)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(639, 117)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtTypeRef
        '
        Me.txtTypeRef.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "SAC_SUBACTIVE.SAC_TYPE_REF", True))
        Me.txtTypeRef.Location = New System.Drawing.Point(92, 91)
        Me.txtTypeRef.Name = "txtTypeRef"
        Me.txtTypeRef.Size = New System.Drawing.Size(100, 20)
        Me.txtTypeRef.TabIndex = 43
        Me.txtTypeRef.Tag = "[EDIT][ADD]"
        '
        'DsTheriaque_Nomenclature2
        '
        Me.DsTheriaque_Nomenclature2.DataSetName = "dsTheriaque_Nomenclature2"
        Me.DsTheriaque_Nomenclature2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbTypeRef
        '
        Me.lbTypeRef.AutoSize = True
        Me.lbTypeRef.Location = New System.Drawing.Point(6, 94)
        Me.lbTypeRef.Name = "lbTypeRef"
        Me.lbTypeRef.Size = New System.Drawing.Size(85, 13)
        Me.lbTypeRef.TabIndex = 42
        Me.lbTypeRef.Text = "Type Référentiel"
        Me.lbTypeRef.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLibRef
        '
        Me.txtLibRef.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLibRef.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "SAC_SUBACTIVE.SAC_LIBELLE_REF", True))
        Me.txtLibRef.Location = New System.Drawing.Point(295, 64)
        Me.txtLibRef.Name = "txtLibRef"
        Me.txtLibRef.Size = New System.Drawing.Size(253, 20)
        Me.txtLibRef.TabIndex = 41
        Me.txtLibRef.Tag = "[EDIT][ADD]"
        '
        'lbLibRef
        '
        Me.lbLibRef.AutoSize = True
        Me.lbLibRef.Location = New System.Drawing.Point(198, 68)
        Me.lbLibRef.Name = "lbLibRef"
        Me.lbLibRef.Size = New System.Drawing.Size(91, 13)
        Me.lbLibRef.TabIndex = 40
        Me.lbLibRef.Text = "Libellé Référentiel"
        Me.lbLibRef.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodeRef
        '
        Me.txtCodeRef.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "SAC_SUBACTIVE.SAC_CODE_REF", True))
        Me.txtCodeRef.Location = New System.Drawing.Point(92, 64)
        Me.txtCodeRef.Name = "txtCodeRef"
        Me.txtCodeRef.Size = New System.Drawing.Size(100, 20)
        Me.txtCodeRef.TabIndex = 39
        Me.txtCodeRef.Tag = "[EDIT][ADD]"
        '
        'lbCodeRef
        '
        Me.lbCodeRef.AutoSize = True
        Me.lbCodeRef.Location = New System.Drawing.Point(3, 68)
        Me.lbCodeRef.Name = "lbCodeRef"
        Me.lbCodeRef.Size = New System.Drawing.Size(86, 13)
        Me.lbCodeRef.TabIndex = 38
        Me.lbCodeRef.Text = "Code Référentiel"
        Me.lbCodeRef.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PanPere
        '
        Me.PanPere.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanPere.Controls.Add(Me.lkupSAC_GSAC_CODE_FK)
        Me.PanPere.Controls.Add(Me.Label4)
        Me.PanPere.Controls.Add(Me.Label5)
        Me.PanPere.Controls.Add(Me.txtCodePere)
        Me.PanPere.Location = New System.Drawing.Point(12, 11)
        Me.PanPere.Name = "PanPere"
        Me.PanPere.Size = New System.Drawing.Size(568, 29)
        Me.PanPere.TabIndex = 37
        '
        'lkupSAC_GSAC_CODE_FK
        '
        Me.lkupSAC_GSAC_CODE_FK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkupSAC_GSAC_CODE_FK.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "SAC_SUBACTIVE.SAC_GSAC_CODE_FK", True))
        Me.lkupSAC_GSAC_CODE_FK.Location = New System.Drawing.Point(283, 4)
        Me.lkupSAC_GSAC_CODE_FK.Name = "lkupSAC_GSAC_CODE_FK"
        Me.lkupSAC_GSAC_CODE_FK.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.lkupSAC_GSAC_CODE_FK.Properties.Appearance.Options.UseBackColor = True
        Me.lkupSAC_GSAC_CODE_FK.Properties.NullText = ""
        Me.lkupSAC_GSAC_CODE_FK.Properties.ReadOnly = True
        Me.lkupSAC_GSAC_CODE_FK.Size = New System.Drawing.Size(253, 20)
        Me.lkupSAC_GSAC_CODE_FK.TabIndex = 20
        Me.lkupSAC_GSAC_CODE_FK.TabStop = False
        Me.lkupSAC_GSAC_CODE_FK.Tag = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Code père"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(186, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Libellé"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodePere
        '
        Me.txtCodePere.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "SAC_SUBACTIVE.SAC_GSAC_CODE_FK", True))
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
        Me.Label3.Location = New System.Drawing.Point(54, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Code"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "SAC_SUBACTIVE.SAC_CODE_SQ_PK", True))
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
        Me.Label6.Location = New System.Drawing.Point(198, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Libellé"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLibelle
        '
        Me.txtLibelle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLibelle.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "SAC_SUBACTIVE.SAC_NOM", True))
        Me.txtLibelle.Location = New System.Drawing.Point(295, 41)
        Me.txtLibelle.Name = "txtLibelle"
        Me.txtLibelle.Size = New System.Drawing.Size(253, 20)
        Me.txtLibelle.TabIndex = 32
        Me.txtLibelle.Tag = "[EDIT][ADD]"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 117)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(639, 376)
        Me.XtraTabControl1.TabIndex = 42
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        Me.XtraTabControl1.Tag = "[EDIT][NOADD]"
        Me.XtraTabControl1.Text = "Classe CIM10"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panel2)
        Me.XtraTabPage1.Controls.Add(Me.Panel5)
        Me.XtraTabPage1.Controls.Add(Me.PanelSyno)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(630, 345)
        Me.XtraTabPage1.Text = "Autres dénominations"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 170)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(630, 119)
        Me.Panel2.TabIndex = 5
        Me.Panel2.Tag = "[EDIT][NOADD]"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(323, 119)
        Me.Panel3.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GC3)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox4.Size = New System.Drawing.Size(323, 119)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Tag = ""
        '
        'GC3
        '
        Me.GC3.DataMember = "SACCAS_SUBACT_CAS"
        Me.GC3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC3.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC3.EmbeddedNavigator.Name = ""
        Me.GC3.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC3.Location = New System.Drawing.Point(3, 16)
        Me.GC3.MainView = Me.GV3
        Me.GC3.Name = "GC3"
        Me.GC3.Size = New System.Drawing.Size(317, 100)
        Me.GC3.TabIndex = 27
        Me.GC3.Tag = ""
        Me.GC3.UseEmbeddedNavigator = True
        Me.GC3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV3})
        '
        'GV3
        '
        Me.GV3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSACCAS_CAS_CODE_PK, Me.colSACCAS_SAC_CODE_FK_PK})
        Me.GV3.GridControl = Me.GC3
        Me.GV3.Name = "GV3"
        Me.GV3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV3.OptionsView.ShowGroupPanel = False
        '
        'colSACCAS_CAS_CODE_PK
        '
        Me.colSACCAS_CAS_CODE_PK.Caption = "Code CAS"
        Me.colSACCAS_CAS_CODE_PK.FieldName = "SACCAS_CAS_CODE_PK"
        Me.colSACCAS_CAS_CODE_PK.Name = "colSACCAS_CAS_CODE_PK"
        Me.colSACCAS_CAS_CODE_PK.Visible = True
        Me.colSACCAS_CAS_CODE_PK.VisibleIndex = 0
        '
        'colSACCAS_SAC_CODE_FK_PK
        '
        Me.colSACCAS_SAC_CODE_FK_PK.Caption = "SACCAS_SAC_CODE_FK_PK"
        Me.colSACCAS_SAC_CODE_FK_PK.FieldName = "SACCAS_SAC_CODE_FK_PK"
        Me.colSACCAS_SAC_CODE_FK_PK.Name = "colSACCAS_SAC_CODE_FK_PK"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GroupBox5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(323, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(307, 119)
        Me.Panel4.TabIndex = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GC4)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox5.Size = New System.Drawing.Size(307, 119)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Tag = ""
        '
        'GC4
        '
        Me.GC4.DataMember = "ADSAC_AUTRE_DENOMINATION_SUBAC"
        Me.GC4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC4.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC4.EmbeddedNavigator.Name = ""
        Me.GC4.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC4.Location = New System.Drawing.Point(3, 16)
        Me.GC4.MainView = Me.GV4
        Me.GC4.Name = "GC4"
        Me.GC4.Size = New System.Drawing.Size(301, 100)
        Me.GC4.TabIndex = 0
        Me.GC4.Tag = ""
        Me.GC4.UseEmbeddedNavigator = True
        Me.GC4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV4})
        '
        'GV4
        '
        Me.GV4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colADSAC_NOM_PK, Me.colADSAC_SAC_CODE_FK})
        Me.GV4.GridControl = Me.GC4
        Me.GV4.Name = "GV4"
        Me.GV4.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV4.OptionsView.ShowGroupPanel = False
        '
        'colADSAC_NOM_PK
        '
        Me.colADSAC_NOM_PK.Caption = "Autres dénominations"
        Me.colADSAC_NOM_PK.FieldName = "ADSAC_NOM_PK"
        Me.colADSAC_NOM_PK.Name = "colADSAC_NOM_PK"
        Me.colADSAC_NOM_PK.Visible = True
        Me.colADSAC_NOM_PK.VisibleIndex = 0
        '
        'colADSAC_SAC_CODE_FK
        '
        Me.colADSAC_SAC_CODE_FK.Caption = "ADSAC_SAC_CODE_FK"
        Me.colADSAC_SAC_CODE_FK.FieldName = "ADSAC_SAC_CODE_FK"
        Me.colADSAC_SAC_CODE_FK.Name = "colADSAC_SAC_CODE_FK"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtSAC_SAU_CODE_FK)
        Me.Panel5.Controls.Add(Me.cmbExcipient)
        Me.Panel5.Controls.Add(Me.lkupSAC_CDF_ORN_CODE_FK)
        Me.Panel5.Controls.Add(Me.DateDisponible)
        Me.Panel5.Controls.Add(Me.cmbDisponible)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.txtLibAnglais)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 289)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(630, 56)
        Me.Panel5.TabIndex = 6
        '
        'txtSAC_SAU_CODE_FK
        '
        Me.txtSAC_SAU_CODE_FK.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "SAC_SUBACTIVE.SAC_SAU_CODE_FK", True))
        Me.txtSAC_SAU_CODE_FK.Location = New System.Drawing.Point(198, 7)
        Me.txtSAC_SAU_CODE_FK.Name = "txtSAC_SAU_CODE_FK"
        Me.txtSAC_SAU_CODE_FK.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSAC_SAU_CODE_FK.Size = New System.Drawing.Size(100, 20)
        Me.txtSAC_SAU_CODE_FK.TabIndex = 42
        Me.txtSAC_SAU_CODE_FK.Tag = "[NOEDIT][NOADD]"
        '
        'cmbExcipient
        '
        Me.cmbExcipient.EditValue = "N"
        Me.cmbExcipient.Location = New System.Drawing.Point(136, 7)
        Me.cmbExcipient.Name = "cmbExcipient"
        Me.cmbExcipient.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbExcipient.Properties.Items.AddRange(New Object() {"O", "N"})
        Me.cmbExcipient.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbExcipient.Size = New System.Drawing.Size(53, 20)
        Me.cmbExcipient.TabIndex = 41
        '
        'lkupSAC_CDF_ORN_CODE_FK
        '
        Me.lkupSAC_CDF_ORN_CODE_FK.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "SAC_SUBACTIVE.SAC_CDF_ORN_CODE_FK", True))
        Me.lkupSAC_CDF_ORN_CODE_FK.Location = New System.Drawing.Point(137, 32)
        Me.lkupSAC_CDF_ORN_CODE_FK.Name = "lkupSAC_CDF_ORN_CODE_FK"
        Me.lkupSAC_CDF_ORN_CODE_FK.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupSAC_CDF_ORN_CODE_FK.Size = New System.Drawing.Size(161, 20)
        Me.lkupSAC_CDF_ORN_CODE_FK.TabIndex = 40
        '
        'DateDisponible
        '
        Me.DateDisponible.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "SAC_SUBACTIVE.SAC_DATECOMMER", True))
        Me.DateDisponible.EditValue = Nothing
        Me.DateDisponible.Location = New System.Drawing.Point(479, 32)
        Me.DateDisponible.Name = "DateDisponible"
        Me.DateDisponible.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateDisponible.Size = New System.Drawing.Size(145, 20)
        Me.DateDisponible.TabIndex = 39
        '
        'cmbDisponible
        '
        Me.cmbDisponible.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "SAC_SUBACTIVE.SAC_ETAT_COMMER", True))
        Me.cmbDisponible.Location = New System.Drawing.Point(420, 32)
        Me.cmbDisponible.Name = "cmbDisponible"
        Me.cmbDisponible.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDisponible.Properties.Items.AddRange(New Object() {"D", "NC", "S"})
        Me.cmbDisponible.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbDisponible.Size = New System.Drawing.Size(53, 20)
        Me.cmbDisponible.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(309, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Disponible (D/NC/S)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(341, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Libellé anglais"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLibAnglais
        '
        Me.txtLibAnglais.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "SAC_SUBACTIVE.SAC_NOMA", True))
        Me.txtLibAnglais.Location = New System.Drawing.Point(420, 7)
        Me.txtLibAnglais.Name = "txtLibAnglais"
        Me.txtLibAnglais.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLibAnglais.Size = New System.Drawing.Size(204, 20)
        Me.txtLibAnglais.TabIndex = 34
        Me.txtLibAnglais.Tag = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Origine du nom substance"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Excipient (O/N)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PanelSyno
        '
        Me.PanelSyno.Controls.Add(Me.PanelL)
        Me.PanelSyno.Controls.Add(Me.PanelR)
        Me.PanelSyno.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSyno.Location = New System.Drawing.Point(0, 0)
        Me.PanelSyno.Name = "PanelSyno"
        Me.PanelSyno.Size = New System.Drawing.Size(630, 170)
        Me.PanelSyno.TabIndex = 4
        Me.PanelSyno.Tag = "[EDIT][NOADD]"
        '
        'PanelL
        '
        Me.PanelL.Controls.Add(Me.GroupBox2)
        Me.PanelL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelL.Location = New System.Drawing.Point(0, 0)
        Me.PanelL.Name = "PanelL"
        Me.PanelL.Size = New System.Drawing.Size(323, 170)
        Me.PanelL.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GC)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(323, 170)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = ""
        Me.GroupBox2.Text = "Synonymes français"
        '
        'GC
        '
        Me.GC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC.DataMember = "SYFSAC_SYNONYMEFR_SUBACT"
        Me.GC.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC.EmbeddedNavigator.Name = ""
        Me.GC.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC.Location = New System.Drawing.Point(6, 19)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.Size = New System.Drawing.Size(308, 145)
        Me.GC.TabIndex = 27
        Me.GC.UseEmbeddedNavigator = True
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSYFSAC_NOM_PK, Me.colSYFSAC_SAC_CODE_FK})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'colSYFSAC_NOM_PK
        '
        Me.colSYFSAC_NOM_PK.Caption = "Libellé"
        Me.colSYFSAC_NOM_PK.FieldName = "SYFSAC_NOM_PK"
        Me.colSYFSAC_NOM_PK.Name = "colSYFSAC_NOM_PK"
        Me.colSYFSAC_NOM_PK.Visible = True
        Me.colSYFSAC_NOM_PK.VisibleIndex = 0
        '
        'colSYFSAC_SAC_CODE_FK
        '
        Me.colSYFSAC_SAC_CODE_FK.Caption = "SYFSAC_SAC_CODE_FK"
        Me.colSYFSAC_SAC_CODE_FK.FieldName = "SYFSAC_SAC_CODE_FK"
        Me.colSYFSAC_SAC_CODE_FK.Name = "colSYFSAC_SAC_CODE_FK"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(6, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 20)
        Me.PictureBox3.TabIndex = 26
        Me.PictureBox3.TabStop = False
        '
        'PanelR
        '
        Me.PanelR.Controls.Add(Me.GroupBox3)
        Me.PanelR.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelR.Location = New System.Drawing.Point(323, 0)
        Me.PanelR.Name = "PanelR"
        Me.PanelR.Size = New System.Drawing.Size(307, 170)
        Me.PanelR.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox4)
        Me.GroupBox3.Controls.Add(Me.GC2)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox3.Size = New System.Drawing.Size(307, 170)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Tag = ""
        Me.GroupBox3.Text = "Synonymes anglais"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(6, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(25, 20)
        Me.PictureBox4.TabIndex = 28
        Me.PictureBox4.TabStop = False
        '
        'GC2
        '
        Me.GC2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC2.DataMember = "SYASAC_SYNONYMEANGLAIS_SAC"
        Me.GC2.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC2.EmbeddedNavigator.Name = ""
        Me.GC2.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC2.Location = New System.Drawing.Point(10, 19)
        Me.GC2.MainView = Me.GV2
        Me.GC2.Name = "GC2"
        Me.GC2.Size = New System.Drawing.Size(291, 145)
        Me.GC2.TabIndex = 0
        Me.GC2.Tag = ""
        Me.GC2.UseEmbeddedNavigator = True
        Me.GC2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSYASAC_NOM_PK, Me.colSYASAC_SAC_CODE_FK_PK})
        Me.GV2.GridControl = Me.GC2
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV2.OptionsView.ShowGroupPanel = False
        '
        'colSYASAC_NOM_PK
        '
        Me.colSYASAC_NOM_PK.Caption = "Libellé"
        Me.colSYASAC_NOM_PK.FieldName = "SYASAC_NOM_PK"
        Me.colSYASAC_NOM_PK.Name = "colSYASAC_NOM_PK"
        Me.colSYASAC_NOM_PK.Visible = True
        Me.colSYASAC_NOM_PK.VisibleIndex = 0
        '
        'colSYASAC_SAC_CODE_FK_PK
        '
        Me.colSYASAC_SAC_CODE_FK_PK.Caption = "SYASAC_SAC_CODE_FK_PK"
        Me.colSYASAC_SAC_CODE_FK_PK.FieldName = "SYASAC_SAC_CODE_FK_PK"
        Me.colSYASAC_SAC_CODE_FK_PK.Name = "colSYASAC_SAC_CODE_FK_PK"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.PanClasse)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(503, 331)
        Me.XtraTabPage2.Text = "Classe"
        '
        'PanClasse
        '
        Me.PanClasse.Controls.Add(Me.GC7)
        Me.PanClasse.Controls.Add(Me.GC6)
        Me.PanClasse.Controls.Add(Me.GC5)
        Me.PanClasse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanClasse.Location = New System.Drawing.Point(0, 0)
        Me.PanClasse.Name = "PanClasse"
        Me.PanClasse.Size = New System.Drawing.Size(503, 331)
        Me.PanClasse.TabIndex = 0
        '
        'GC7
        '
        Me.GC7.DataMember = "SACCATC_SUBACT_CLASSEATC"
        Me.GC7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC7.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC7.EmbeddedNavigator.Name = ""
        Me.GC7.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC7.Location = New System.Drawing.Point(0, 265)
        Me.GC7.MainView = Me.GV7
        Me.GC7.Name = "GC7"
        Me.GC7.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpATC})
        Me.GC7.Size = New System.Drawing.Size(503, 66)
        Me.GC7.TabIndex = 30
        Me.GC7.Tag = ""
        Me.GC7.UseEmbeddedNavigator = True
        Me.GC7.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV7})
        '
        'GV7
        '
        Me.GV7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSACCATC_CATC_CODE_FK_PK, Me.colSACCATC_SAC_CODE_FK_PK, Me.colSACCATC_CATC_CODE_FK_PK2})
        Me.GV7.GridControl = Me.GC7
        Me.GV7.Name = "GV7"
        Me.GV7.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV7.OptionsView.ShowGroupPanel = False
        '
        'colSACCATC_CATC_CODE_FK_PK
        '
        Me.colSACCATC_CATC_CODE_FK_PK.Caption = "Classes ATC"
        Me.colSACCATC_CATC_CODE_FK_PK.ColumnEdit = Me.rpATC
        Me.colSACCATC_CATC_CODE_FK_PK.FieldName = "SACCATC_CATC_CODE_FK_PK"
        Me.colSACCATC_CATC_CODE_FK_PK.Name = "colSACCATC_CATC_CODE_FK_PK"
        Me.colSACCATC_CATC_CODE_FK_PK.Visible = True
        Me.colSACCATC_CATC_CODE_FK_PK.VisibleIndex = 1
        Me.colSACCATC_CATC_CODE_FK_PK.Width = 538
        '
        'rpATC
        '
        Me.rpATC.AutoHeight = False
        Me.rpATC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpATC.Name = "rpATC"
        '
        'colSACCATC_SAC_CODE_FK_PK
        '
        Me.colSACCATC_SAC_CODE_FK_PK.Caption = "SACCATC_SAC_CODE_FK_PK"
        Me.colSACCATC_SAC_CODE_FK_PK.FieldName = "SACCATC_SAC_CODE_FK_PK"
        Me.colSACCATC_SAC_CODE_FK_PK.Name = "colSACCATC_SAC_CODE_FK_PK"
        '
        'colSACCATC_CATC_CODE_FK_PK2
        '
        Me.colSACCATC_CATC_CODE_FK_PK2.Caption = "Code"
        Me.colSACCATC_CATC_CODE_FK_PK2.FieldName = "SACCATC_CATC_CODE_FK_PK"
        Me.colSACCATC_CATC_CODE_FK_PK2.Name = "colSACCATC_CATC_CODE_FK_PK2"
        Me.colSACCATC_CATC_CODE_FK_PK2.Visible = True
        Me.colSACCATC_CATC_CODE_FK_PK2.VisibleIndex = 0
        Me.colSACCATC_CATC_CODE_FK_PK2.Width = 71
        '
        'GC6
        '
        Me.GC6.DataMember = "SACCPH_SUBACT_CLASSEPH"
        Me.GC6.Dock = System.Windows.Forms.DockStyle.Top
        Me.GC6.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC6.EmbeddedNavigator.Name = ""
        Me.GC6.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC6.Location = New System.Drawing.Point(0, 133)
        Me.GC6.MainView = Me.GV6
        Me.GC6.Name = "GC6"
        Me.GC6.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpCPH})
        Me.GC6.Size = New System.Drawing.Size(503, 132)
        Me.GC6.TabIndex = 29
        Me.GC6.Tag = ""
        Me.GC6.UseEmbeddedNavigator = True
        Me.GC6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV6})
        '
        'GV6
        '
        Me.GV6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSACCPH_SAC_CODE_FK_PK, Me.colSACCPH_CPH_CODE_FK_PK, Me.colSACCPH_CPH_CODE_FK_PK2})
        Me.GV6.GridControl = Me.GC6
        Me.GV6.Name = "GV6"
        Me.GV6.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV6.OptionsView.ShowGroupPanel = False
        '
        'colSACCPH_SAC_CODE_FK_PK
        '
        Me.colSACCPH_SAC_CODE_FK_PK.Caption = "SACCPH_SAC_CODE_FK_PK"
        Me.colSACCPH_SAC_CODE_FK_PK.FieldName = "SACCPH_SAC_CODE_FK_PK"
        Me.colSACCPH_SAC_CODE_FK_PK.Name = "colSACCPH_SAC_CODE_FK_PK"
        '
        'colSACCPH_CPH_CODE_FK_PK
        '
        Me.colSACCPH_CPH_CODE_FK_PK.Caption = "Classes pharmacothérapeutiques"
        Me.colSACCPH_CPH_CODE_FK_PK.ColumnEdit = Me.rpCPH
        Me.colSACCPH_CPH_CODE_FK_PK.FieldName = "SACCPH_CPH_CODE_FK_PK"
        Me.colSACCPH_CPH_CODE_FK_PK.Name = "colSACCPH_CPH_CODE_FK_PK"
        Me.colSACCPH_CPH_CODE_FK_PK.Visible = True
        Me.colSACCPH_CPH_CODE_FK_PK.VisibleIndex = 1
        Me.colSACCPH_CPH_CODE_FK_PK.Width = 537
        '
        'rpCPH
        '
        Me.rpCPH.AutoHeight = False
        Me.rpCPH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpCPH.Name = "rpCPH"
        '
        'colSACCPH_CPH_CODE_FK_PK2
        '
        Me.colSACCPH_CPH_CODE_FK_PK2.Caption = "Code"
        Me.colSACCPH_CPH_CODE_FK_PK2.FieldName = "SACCPH_CPH_CODE_FK_PK"
        Me.colSACCPH_CPH_CODE_FK_PK2.Name = "colSACCPH_CPH_CODE_FK_PK2"
        Me.colSACCPH_CPH_CODE_FK_PK2.Visible = True
        Me.colSACCPH_CPH_CODE_FK_PK2.VisibleIndex = 0
        Me.colSACCPH_CPH_CODE_FK_PK2.Width = 72
        '
        'GC5
        '
        Me.GC5.DataMember = "SACCCH_SUBACT_CLASSECH"
        Me.GC5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GC5.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC5.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC5.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC5.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC5.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC5.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC5.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC5.EmbeddedNavigator.Name = ""
        Me.GC5.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC5.Location = New System.Drawing.Point(0, 0)
        Me.GC5.MainView = Me.GV5
        Me.GC5.Name = "GC5"
        Me.GC5.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpCCH})
        Me.GC5.Size = New System.Drawing.Size(503, 133)
        Me.GC5.TabIndex = 28
        Me.GC5.Tag = ""
        Me.GC5.UseEmbeddedNavigator = True
        Me.GC5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV5})
        '
        'GV5
        '
        Me.GV5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSACCCH_SAC_CODE_FK_PK, Me.colSACCCH_CCH_CODE_FK_PK, Me.colSACCCH_CCH_CODE_FK_PK2})
        Me.GV5.GridControl = Me.GC5
        Me.GV5.Name = "GV5"
        Me.GV5.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV5.OptionsView.ShowGroupPanel = False
        '
        'colSACCCH_SAC_CODE_FK_PK
        '
        Me.colSACCCH_SAC_CODE_FK_PK.Caption = "SACCCH_SAC_CODE_FK_PK"
        Me.colSACCCH_SAC_CODE_FK_PK.FieldName = "SACCCH_SAC_CODE_FK_PK"
        Me.colSACCCH_SAC_CODE_FK_PK.Name = "colSACCCH_SAC_CODE_FK_PK"
        '
        'colSACCCH_CCH_CODE_FK_PK
        '
        Me.colSACCCH_CCH_CODE_FK_PK.Caption = "Classes chimique"
        Me.colSACCCH_CCH_CODE_FK_PK.ColumnEdit = Me.rpCCH
        Me.colSACCCH_CCH_CODE_FK_PK.FieldName = "SACCCH_CCH_CODE_FK_PK"
        Me.colSACCCH_CCH_CODE_FK_PK.Name = "colSACCCH_CCH_CODE_FK_PK"
        Me.colSACCCH_CCH_CODE_FK_PK.Visible = True
        Me.colSACCCH_CCH_CODE_FK_PK.VisibleIndex = 1
        Me.colSACCCH_CCH_CODE_FK_PK.Width = 535
        '
        'rpCCH
        '
        Me.rpCCH.AutoHeight = False
        Me.rpCCH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpCCH.Name = "rpCCH"
        '
        'colSACCCH_CCH_CODE_FK_PK2
        '
        Me.colSACCCH_CCH_CODE_FK_PK2.Caption = "Code"
        Me.colSACCCH_CCH_CODE_FK_PK2.FieldName = "SACCCH_CCH_CODE_FK_PK"
        Me.colSACCCH_CCH_CODE_FK_PK2.Name = "colSACCCH_CCH_CODE_FK_PK2"
        Me.colSACCCH_CCH_CODE_FK_PK2.Visible = True
        Me.colSACCCH_CCH_CODE_FK_PK2.VisibleIndex = 0
        Me.colSACCCH_CCH_CODE_FK_PK2.Width = 74
        '
        'SaC_TA
        '
        Me.SaC_TA.ClearBeforeFill = True
        '
        'GsaC_TA
        '
        Me.GsaC_TA.ClearBeforeFill = True
        '
        'SyfsaC_TA
        '
        Me.SyfsaC_TA.ClearBeforeFill = True
        '
        'SyasaC_TA
        '
        Me.SyasaC_TA.ClearBeforeFill = True
        '
        'SaccaS_TA
        '
        Me.SaccaS_TA.ClearBeforeFill = True
        '
        'AdsaC_TA
        '
        Me.AdsaC_TA.ClearBeforeFill = True
        '
        'SacccH_TA
        '
        Me.SacccH_TA.ClearBeforeFill = True
        '
        'SaccpH_TA
        '
        Me.SaccpH_TA.ClearBeforeFill = True
        '
        'SaccatC_TA
        '
        Me.SaccatC_TA.ClearBeforeFill = True
        '
        'Frm_SubstanceActivFils
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(757, 580)
        Me.Name = "Frm_SubstanceActivFils"
        Me.Text = " "
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtTypeRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_Nomenclature2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodeRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanPere.ResumeLayout(False)
        Me.PanPere.PerformLayout()
        CType(Me.lkupSAC_GSAC_CODE_FK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodePere.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.GC3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.GC4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.txtSAC_SAU_CODE_FK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbExcipient.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupSAC_CDF_ORN_CODE_FK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateDisponible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDisponible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibAnglais.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSyno.ResumeLayout(False)
        Me.PanelL.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelR.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.PanClasse.ResumeLayout(False)
        CType(Me.GC7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpATC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpCPH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpCCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PanPere As System.Windows.Forms.Panel
    Friend WithEvents lkupSAC_GSAC_CODE_FK As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodePere As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLibelle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelSyno As System.Windows.Forms.Panel
    Friend WithEvents PanelR As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents GC2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelL As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents DsTheriaque_Nomenclature2 As Theriaque.dsTheriaque_Nomenclature2
    Friend WithEvents SaC_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.SAC_SUBACTIVETableAdapter
    Friend WithEvents GsaC_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.GSAC_PERE_SUBACTTableAdapter
    Friend WithEvents SyfsaC_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.SYFSAC_SYNONYMEFR_SUBACTTableAdapter
    Friend WithEvents SyasaC_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.SYASAC_SYNONYMEANGLAIS_SACTableAdapter
    Friend WithEvents colSYFSAC_NOM_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSYFSAC_SAC_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSYASAC_NOM_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSYASAC_SAC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GC4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SaccaS_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.SACCAS_SUBACT_CASTableAdapter
    Friend WithEvents GC3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSACCAS_CAS_CODE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSACCAS_SAC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AdsaC_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.ADSAC_AUTRE_DENOMINATION_SUBACTableAdapter
    Friend WithEvents colADSAC_NOM_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADSAC_SAC_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtLibAnglais As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DateDisponible As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbDisponible As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lkupSAC_CDF_ORN_CODE_FK As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PanClasse As System.Windows.Forms.Panel
    Friend WithEvents GC5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmbExcipient As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GC7 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC6 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSACCATC_CATC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSACCATC_SAC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSACCPH_SAC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSACCPH_CPH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSACCCH_SAC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSACCCH_CCH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SacccH_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.SACCCH_SUBACT_CLASSECHTableAdapter
    Friend WithEvents SaccpH_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.SACCPH_SUBACT_CLASSEPHTableAdapter
    Friend WithEvents SaccatC_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.SACCATC_SUBACT_CLASSEATCTableAdapter
    Friend WithEvents rpATC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rpCPH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rpCCH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtSAC_SAU_CODE_FK As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colSACCATC_CATC_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSACCPH_CPH_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSACCCH_CCH_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCodeRef As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbCodeRef As System.Windows.Forms.Label
    Friend WithEvents txtLibRef As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbLibRef As System.Windows.Forms.Label
    Friend WithEvents txtTypeRef As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbTypeRef As System.Windows.Forms.Label

End Class
