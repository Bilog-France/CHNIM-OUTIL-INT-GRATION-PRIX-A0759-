<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CDF_CIM10_CISP
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
        Me.CimcdF_CIM10_CODIFTableAdapter = New Theriaque.dsTheriaqueTableAdapters.CIMCDF_CIM10_CODIFTableAdapter
        Me.SycdF_SYNCODIFTableAdapter = New Theriaque.dsTheriaqueTableAdapters.SYCDF_SYNCODIFTableAdapter
        Me.CdF_CODIFTableAdapter = New Theriaque.dsTheriaqueTableAdapters.CDF_CODIFTableAdapter
        Me.DsTheriaque1 = New Theriaque.dsTheriaque
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GC2 = New DevExpress.XtraGrid.GridControl
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCIMCDF_CIM_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpCIM10 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colCIMCDF_CDF_NUMERO_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCIMCDF_CDF_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCIMCDF_CIM_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanPere = New System.Windows.Forms.Panel
        Me.lkupCDF_CODE_PK = New DevExpress.XtraEditors.LookUpEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCodePere = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNCodif = New DevExpress.XtraEditors.TextEdit
        Me.DsTheriaque_Nomenclature21 = New Theriaque.dsTheriaque_Nomenclature2
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.GBSyn = New System.Windows.Forms.GroupBox
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSYCDF_NOM_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSYCDF_CDF_NUMERO_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSYCDF_CDF_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLibelle = New DevExpress.XtraEditors.TextEdit
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GBFils = New System.Windows.Forms.GroupBox
        Me.GC3 = New DevExpress.XtraGrid.GridControl
        Me.GV3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCDF_CODE_PKfils = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCDF_NOMFils = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GC4 = New DevExpress.XtraGrid.GridControl
        Me.GV4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCISPCDF_CISP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpCISP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colCISPCDF_CDF_NUMERO_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCISPCDF_CDF_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCISPCDF_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCISPCDF_CISP_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CispcdF_CISP_CODIFTableAdapter = New Theriaque.dsTheriaqueTableAdapters.CISPCDF_CISP_CODIFTableAdapter
        Me.CiM10TableAdapterFils = New Theriaque.dsTheriaqueTableAdapters.CIM10_2TableAdapter
        Me.CdF_CODIFTableAdapterFils = New Theriaque.dsTheriaqueTableAdapters.CDF_CODIFTableAdapter
        Me.CdF_CODIFTA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.CDF_CODIFTableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpCIM10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanPere.SuspendLayout()
        CType(Me.lkupCDF_CODE_PK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodePere.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNCodif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_Nomenclature21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBSyn.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.GBFils.SuspendLayout()
        CType(Me.GC3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GC4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpCISP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(663, 604)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.XtraTabControl1)
        Me.PanMain.Controls.Add(Me.PanPere)
        Me.PanMain.Controls.Add(Me.Label2)
        Me.PanMain.Controls.Add(Me.Label3)
        Me.PanMain.Controls.Add(Me.txtNCodif)
        Me.PanMain.Controls.Add(Me.txtCode)
        Me.PanMain.Controls.Add(Me.Label6)
        Me.PanMain.Controls.Add(Me.txtLibelle)
        Me.PanMain.Size = New System.Drawing.Size(545, 517)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(663, 87)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(663, 28)
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
        Me.Panel1.Location = New System.Drawing.Point(545, 87)
        Me.Panel1.Size = New System.Drawing.Size(118, 517)
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDF_CODIF.CDF_DATEMJ", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Size = New System.Drawing.Size(663, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDF_CODIF.CDF_DATECR", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        '
        'CimcdF_CIM10_CODIFTableAdapter
        '
        Me.CimcdF_CIM10_CODIFTableAdapter.ClearBeforeFill = True
        '
        'SycdF_SYNCODIFTableAdapter
        '
        Me.SycdF_SYNCODIFTableAdapter.ClearBeforeFill = True
        '
        'CdF_CODIFTableAdapter
        '
        Me.CdF_CODIFTableAdapter.ClearBeforeFill = True
        '
        'DsTheriaque1
        '
        Me.DsTheriaque1.DataSetName = "dsTheriaque"
        Me.DsTheriaque1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GC2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(497, 166)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = "[NOADD][EDIT]"
        Me.GroupBox2.Text = "Classe CIM10"
        '
        'GC2
        '
        Me.GC2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC2.DataMember = "CIMCDF_CIM10_CODIF"
        Me.GC2.DataSource = Me.DsTheriaque1
        Me.GC2.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC2.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC2.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC2.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC2.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC2.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC2.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC2.EmbeddedNavigator.Name = ""
        Me.GC2.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC2.Location = New System.Drawing.Point(8, 18)
        Me.GC2.MainView = Me.GV2
        Me.GC2.Name = "GC2"
        Me.GC2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpCIM10})
        Me.GC2.Size = New System.Drawing.Size(480, 138)
        Me.GC2.TabIndex = 0
        Me.GC2.UseEmbeddedNavigator = True
        Me.GC2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCIMCDF_CIM_CODE_FK_PK, Me.colCIMCDF_CDF_NUMERO_FK_PK, Me.colCIMCDF_CDF_CODE_FK_PK, Me.colCIMCDF_CIM_CODE_FK_PK2})
        Me.GV2.GridControl = Me.GC2
        Me.GV2.GroupPanelText = " "
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV2.OptionsView.ShowGroupPanel = False
        '
        'colCIMCDF_CIM_CODE_FK_PK
        '
        Me.colCIMCDF_CIM_CODE_FK_PK.Caption = "Libellé"
        Me.colCIMCDF_CIM_CODE_FK_PK.ColumnEdit = Me.rpCIM10
        Me.colCIMCDF_CIM_CODE_FK_PK.FieldName = "CIMCDF_CIM_CODE_FK_PK"
        Me.colCIMCDF_CIM_CODE_FK_PK.Name = "colCIMCDF_CIM_CODE_FK_PK"
        Me.colCIMCDF_CIM_CODE_FK_PK.Visible = True
        Me.colCIMCDF_CIM_CODE_FK_PK.VisibleIndex = 1
        Me.colCIMCDF_CIM_CODE_FK_PK.Width = 365
        '
        'rpCIM10
        '
        Me.rpCIM10.AutoHeight = False
        Me.rpCIM10.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpCIM10.Name = "rpCIM10"
        Me.rpCIM10.NullText = ""
        '
        'colCIMCDF_CDF_NUMERO_FK_PK
        '
        Me.colCIMCDF_CDF_NUMERO_FK_PK.Caption = "CIMCDF_CDF_NUMERO_FK_PK"
        Me.colCIMCDF_CDF_NUMERO_FK_PK.FieldName = "CIMCDF_CDF_NUMERO_FK_PK"
        Me.colCIMCDF_CDF_NUMERO_FK_PK.Name = "colCIMCDF_CDF_NUMERO_FK_PK"
        '
        'colCIMCDF_CDF_CODE_FK_PK
        '
        Me.colCIMCDF_CDF_CODE_FK_PK.Caption = "CIMCDF_CDF_CODE_FK_PK"
        Me.colCIMCDF_CDF_CODE_FK_PK.FieldName = "CIMCDF_CDF_CODE_FK_PK"
        Me.colCIMCDF_CDF_CODE_FK_PK.Name = "colCIMCDF_CDF_CODE_FK_PK"
        '
        'colCIMCDF_CIM_CODE_FK_PK2
        '
        Me.colCIMCDF_CIM_CODE_FK_PK2.Caption = "Code"
        Me.colCIMCDF_CIM_CODE_FK_PK2.FieldName = "CIMCDF_CIM_CODE_FK_PK"
        Me.colCIMCDF_CIM_CODE_FK_PK2.Name = "colCIMCDF_CIM_CODE_FK_PK2"
        Me.colCIMCDF_CIM_CODE_FK_PK2.Visible = True
        Me.colCIMCDF_CIM_CODE_FK_PK2.VisibleIndex = 0
        Me.colCIMCDF_CIM_CODE_FK_PK2.Width = 86
        '
        'PanPere
        '
        Me.PanPere.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanPere.Controls.Add(Me.lkupCDF_CODE_PK)
        Me.PanPere.Controls.Add(Me.Label4)
        Me.PanPere.Controls.Add(Me.Label5)
        Me.PanPere.Controls.Add(Me.txtCodePere)
        Me.PanPere.Location = New System.Drawing.Point(12, 49)
        Me.PanPere.Name = "PanPere"
        Me.PanPere.Size = New System.Drawing.Size(525, 26)
        Me.PanPere.TabIndex = 39
        '
        'lkupCDF_CODE_PK
        '
        Me.lkupCDF_CODE_PK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkupCDF_CODE_PK.Location = New System.Drawing.Point(229, 4)
        Me.lkupCDF_CODE_PK.Name = "lkupCDF_CODE_PK"
        Me.lkupCDF_CODE_PK.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.lkupCDF_CODE_PK.Properties.Appearance.Options.UseBackColor = True
        Me.lkupCDF_CODE_PK.Properties.NullText = ""
        Me.lkupCDF_CODE_PK.Properties.ReadOnly = True
        Me.lkupCDF_CODE_PK.Size = New System.Drawing.Size(286, 20)
        Me.lkupCDF_CODE_PK.TabIndex = 20
        Me.lkupCDF_CODE_PK.TabStop = False
        Me.lkupCDF_CODE_PK.Tag = ""
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "N° Codif"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Code"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNCodif
        '
        Me.txtNCodif.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDF_CODIF.CDF_NUMERO_PK", True))
        Me.txtNCodif.Location = New System.Drawing.Point(92, 25)
        Me.txtNCodif.Name = "txtNCodif"
        Me.txtNCodif.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.txtNCodif.Properties.Appearance.Options.UseBackColor = True
        Me.txtNCodif.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNCodif.Properties.ReadOnly = True
        Me.txtNCodif.Size = New System.Drawing.Size(100, 20)
        Me.txtNCodif.TabIndex = 37
        Me.txtNCodif.TabStop = False
        Me.txtNCodif.Tag = ""
        '
        'DsTheriaque_Nomenclature21
        '
        Me.DsTheriaque_Nomenclature21.DataSetName = "dsTheriaque_Nomenclature2"
        Me.DsTheriaque_Nomenclature21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDF_CODIF.CDF_CODE_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(92, 77)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 32
        Me.txtCode.Tag = "[NOEDIT][ADD]"
        '
        'GBSyn
        '
        Me.GBSyn.Controls.Add(Me.GC)
        Me.GBSyn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GBSyn.Location = New System.Drawing.Point(0, 0)
        Me.GBSyn.Name = "GBSyn"
        Me.GBSyn.Size = New System.Drawing.Size(530, 182)
        Me.GBSyn.TabIndex = 34
        Me.GBSyn.TabStop = False
        Me.GBSyn.Tag = "[NOADD][EDIT]"
        Me.GBSyn.Text = "Synonymes"
        '
        'GC
        '
        Me.GC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC.DataMember = "SYCDF_SYNCODIF"
        Me.GC.DataSource = Me.DsTheriaque1
        Me.GC.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC.EmbeddedNavigator.Name = ""
        Me.GC.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC.Location = New System.Drawing.Point(8, 18)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.Size = New System.Drawing.Size(513, 155)
        Me.GC.TabIndex = 0
        Me.GC.UseEmbeddedNavigator = True
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSYCDF_NOM_PK, Me.colSYCDF_CDF_NUMERO_FK_PK, Me.colSYCDF_CDF_CODE_FK})
        Me.GV.GridControl = Me.GC
        Me.GV.GroupPanelText = " "
        Me.GV.Name = "GV"
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'colSYCDF_NOM_PK
        '
        Me.colSYCDF_NOM_PK.Caption = "Libellé"
        Me.colSYCDF_NOM_PK.FieldName = "SYCDF_NOM_PK"
        Me.colSYCDF_NOM_PK.Name = "colSYCDF_NOM_PK"
        Me.colSYCDF_NOM_PK.Visible = True
        Me.colSYCDF_NOM_PK.VisibleIndex = 0
        '
        'colSYCDF_CDF_NUMERO_FK_PK
        '
        Me.colSYCDF_CDF_NUMERO_FK_PK.Caption = "SYCDF_CDF_NUMERO_FK_PK"
        Me.colSYCDF_CDF_NUMERO_FK_PK.FieldName = "SYCDF_CDF_NUMERO_FK_PK"
        Me.colSYCDF_CDF_NUMERO_FK_PK.Name = "colSYCDF_CDF_NUMERO_FK_PK"
        '
        'colSYCDF_CDF_CODE_FK
        '
        Me.colSYCDF_CDF_CODE_FK.Caption = "SYCDF_CDF_CODE_FK"
        Me.colSYCDF_CDF_CODE_FK.FieldName = "SYCDF_CDF_CODE_FK"
        Me.colSYCDF_CDF_CODE_FK.Name = "colSYCDF_CDF_CODE_FK"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Libellé"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLibelle
        '
        Me.txtLibelle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLibelle.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDF_CODIF.CDF_NOM", True))
        Me.txtLibelle.Location = New System.Drawing.Point(92, 103)
        Me.txtLibelle.Name = "txtLibelle"
        Me.txtLibelle.Size = New System.Drawing.Size(435, 20)
        Me.txtLibelle.TabIndex = 33
        Me.txtLibelle.Tag = "[EDIT][ADD]"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(6, 139)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(539, 378)
        Me.XtraTabControl1.TabIndex = 41
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GBSyn)
        Me.XtraTabPage1.Controls.Add(Me.GBFils)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(530, 347)
        Me.XtraTabPage1.Text = "Synonymes / Fils"
        '
        'GBFils
        '
        Me.GBFils.Controls.Add(Me.GC3)
        Me.GBFils.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GBFils.Location = New System.Drawing.Point(0, 182)
        Me.GBFils.Name = "GBFils"
        Me.GBFils.Size = New System.Drawing.Size(530, 165)
        Me.GBFils.TabIndex = 35
        Me.GBFils.TabStop = False
        Me.GBFils.Tag = "[NOADD][EDIT]"
        Me.GBFils.Text = "Fils"
        '
        'GC3
        '
        Me.GC3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC3.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC3.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC3.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC3.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC3.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC3.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC3.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC3.EmbeddedNavigator.Name = ""
        Me.GC3.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC3.Location = New System.Drawing.Point(8, 18)
        Me.GC3.MainView = Me.GV3
        Me.GC3.Name = "GC3"
        Me.GC3.Size = New System.Drawing.Size(513, 137)
        Me.GC3.TabIndex = 0
        Me.GC3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV3})
        '
        'GV3
        '
        Me.GV3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCDF_CODE_PKfils, Me.colCDF_NOMFils})
        Me.GV3.GridControl = Me.GC3
        Me.GV3.GroupPanelText = " "
        Me.GV3.Name = "GV3"
        Me.GV3.OptionsView.ShowGroupPanel = False
        '
        'colCDF_CODE_PKfils
        '
        Me.colCDF_CODE_PKfils.Caption = "Code"
        Me.colCDF_CODE_PKfils.FieldName = "CDF_CODE_PK"
        Me.colCDF_CODE_PKfils.Name = "colCDF_CODE_PKfils"
        Me.colCDF_CODE_PKfils.OptionsColumn.AllowEdit = False
        Me.colCDF_CODE_PKfils.OptionsColumn.AllowFocus = False
        Me.colCDF_CODE_PKfils.OptionsColumn.ReadOnly = True
        Me.colCDF_CODE_PKfils.Visible = True
        Me.colCDF_CODE_PKfils.VisibleIndex = 0
        Me.colCDF_CODE_PKfils.Width = 98
        '
        'colCDF_NOMFils
        '
        Me.colCDF_NOMFils.Caption = "Libellé"
        Me.colCDF_NOMFils.FieldName = "CDF_NOM"
        Me.colCDF_NOMFils.Name = "colCDF_NOMFils"
        Me.colCDF_NOMFils.OptionsColumn.AllowEdit = False
        Me.colCDF_NOMFils.OptionsColumn.AllowFocus = False
        Me.colCDF_NOMFils.OptionsColumn.ReadOnly = True
        Me.colCDF_NOMFils.Visible = True
        Me.colCDF_NOMFils.VisibleIndex = 1
        Me.colCDF_NOMFils.Width = 365
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GroupBox4)
        Me.XtraTabPage2.Controls.Add(Me.GroupBox2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(497, 309)
        Me.XtraTabPage2.Text = "CIM10 / CISP"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GC4)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(0, 166)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(497, 143)
        Me.GroupBox4.TabIndex = 41
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Tag = "[NOADD][EDIT]"
        Me.GroupBox4.Text = "Classe CISP"
        '
        'GC4
        '
        Me.GC4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC4.DataMember = "CISPCDF_CISP_CODIF"
        Me.GC4.DataSource = Me.DsTheriaque1
        Me.GC4.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC4.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC4.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC4.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC4.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC4.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC4.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC4.EmbeddedNavigator.Name = ""
        Me.GC4.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC4.Location = New System.Drawing.Point(8, 18)
        Me.GC4.MainView = Me.GV4
        Me.GC4.Name = "GC4"
        Me.GC4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpCISP})
        Me.GC4.Size = New System.Drawing.Size(480, 115)
        Me.GC4.TabIndex = 0
        Me.GC4.UseEmbeddedNavigator = True
        Me.GC4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV4})
        '
        'GV4
        '
        Me.GV4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCISPCDF_CISP_CODE_FK_PK, Me.colCISPCDF_CDF_NUMERO_FK_PK, Me.colCISPCDF_CDF_CODE_FK_PK, Me.colCISPCDF_NUMORD, Me.colCISPCDF_CISP_CODE_FK_PK2})
        Me.GV4.GridControl = Me.GC4
        Me.GV4.GroupPanelText = " "
        Me.GV4.Name = "GV4"
        Me.GV4.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV4.OptionsView.ShowGroupPanel = False
        '
        'colCISPCDF_CISP_CODE_FK_PK
        '
        Me.colCISPCDF_CISP_CODE_FK_PK.Caption = "Libellé"
        Me.colCISPCDF_CISP_CODE_FK_PK.ColumnEdit = Me.rpCISP
        Me.colCISPCDF_CISP_CODE_FK_PK.FieldName = "CISPCDF_CISP_CODE_FK_PK"
        Me.colCISPCDF_CISP_CODE_FK_PK.Name = "colCISPCDF_CISP_CODE_FK_PK"
        Me.colCISPCDF_CISP_CODE_FK_PK.Visible = True
        Me.colCISPCDF_CISP_CODE_FK_PK.VisibleIndex = 1
        Me.colCISPCDF_CISP_CODE_FK_PK.Width = 380
        '
        'rpCISP
        '
        Me.rpCISP.AutoHeight = False
        Me.rpCISP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpCISP.Name = "rpCISP"
        Me.rpCISP.NullText = ""
        '
        'colCISPCDF_CDF_NUMERO_FK_PK
        '
        Me.colCISPCDF_CDF_NUMERO_FK_PK.Caption = "CISPCDF_CDF_NUMERO_FK_PK"
        Me.colCISPCDF_CDF_NUMERO_FK_PK.FieldName = "CISPCDF_CDF_NUMERO_FK_PK"
        Me.colCISPCDF_CDF_NUMERO_FK_PK.Name = "colCISPCDF_CDF_NUMERO_FK_PK"
        '
        'colCISPCDF_CDF_CODE_FK_PK
        '
        Me.colCISPCDF_CDF_CODE_FK_PK.Caption = "CISPCDF_CDF_CODE_FK_PK"
        Me.colCISPCDF_CDF_CODE_FK_PK.ColumnEdit = Me.rpCISP
        Me.colCISPCDF_CDF_CODE_FK_PK.FieldName = "CISPCDF_CDF_CODE_FK_PK"
        Me.colCISPCDF_CDF_CODE_FK_PK.Name = "colCISPCDF_CDF_CODE_FK_PK"
        Me.colCISPCDF_CDF_CODE_FK_PK.Width = 375
        '
        'colCISPCDF_NUMORD
        '
        Me.colCISPCDF_NUMORD.Caption = "CISPCDF_NUMORD"
        Me.colCISPCDF_NUMORD.FieldName = "CISPCDF_NUMORD"
        Me.colCISPCDF_NUMORD.Name = "colCISPCDF_NUMORD"
        '
        'colCISPCDF_CISP_CODE_FK_PK2
        '
        Me.colCISPCDF_CISP_CODE_FK_PK2.Caption = "Code"
        Me.colCISPCDF_CISP_CODE_FK_PK2.FieldName = "CISPCDF_CISP_CODE_FK_PK"
        Me.colCISPCDF_CISP_CODE_FK_PK2.Name = "colCISPCDF_CISP_CODE_FK_PK2"
        Me.colCISPCDF_CISP_CODE_FK_PK2.Visible = True
        Me.colCISPCDF_CISP_CODE_FK_PK2.VisibleIndex = 0
        Me.colCISPCDF_CISP_CODE_FK_PK2.Width = 88
        '
        'CispcdF_CISP_CODIFTableAdapter
        '
        Me.CispcdF_CISP_CODIFTableAdapter.ClearBeforeFill = True
        '
        'CiM10TableAdapterFils
        '
        Me.CiM10TableAdapterFils.ClearBeforeFill = True
        '
        'CdF_CODIFTableAdapterFils
        '
        Me.CdF_CODIFTableAdapterFils.ClearBeforeFill = True
        '
        'CdF_CODIFTA
        '
        Me.CdF_CODIFTA.ClearBeforeFill = True
        '
        'Frm_CDF_CIM10_CISP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(663, 604)
        Me.Name = "Frm_CDF_CIM10_CISP"
        Me.Text = "Mise à jour des codifications"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanMain.PerformLayout()
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpCIM10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanPere.ResumeLayout(False)
        Me.PanPere.PerformLayout()
        CType(Me.lkupCDF_CODE_PK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodePere.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNCodif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_Nomenclature21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBSyn.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.GBFils.ResumeLayout(False)
        CType(Me.GC3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.GC4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpCISP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CimcdF_CIM10_CODIFTableAdapter As Theriaque.dsTheriaqueTableAdapters.CIMCDF_CIM10_CODIFTableAdapter
    Friend WithEvents SycdF_SYNCODIFTableAdapter As Theriaque.dsTheriaqueTableAdapters.SYCDF_SYNCODIFTableAdapter
    Friend WithEvents CdF_CODIFTableAdapter As Theriaque.dsTheriaqueTableAdapters.CDF_CODIFTableAdapter
    Friend WithEvents DsTheriaque1 As Theriaque.dsTheriaque
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GC2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCIMCDF_CIM_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpCIM10 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colCIMCDF_CDF_NUMERO_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIMCDF_CDF_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIMCDF_CIM_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanPere As System.Windows.Forms.Panel
    Friend WithEvents lkupCDF_CODE_PK As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodePere As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNCodif As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GBSyn As System.Windows.Forms.GroupBox
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSYCDF_NOM_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSYCDF_CDF_NUMERO_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSYCDF_CDF_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLibelle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GBFils As System.Windows.Forms.GroupBox
    Friend WithEvents GC3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GC4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CispcdF_CISP_CODIFTableAdapter As Theriaque.dsTheriaqueTableAdapters.CISPCDF_CISP_CODIFTableAdapter
    Friend WithEvents colCISPCDF_CISP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCISPCDF_CDF_NUMERO_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCISPCDF_CDF_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCISPCDF_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCISPCDF_CISP_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpCISP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents CiM10TableAdapterFils As Theriaque.dsTheriaqueTableAdapters.CIM10_2TableAdapter
    Friend WithEvents CdF_CODIFTableAdapterFils As Theriaque.dsTheriaqueTableAdapters.CDF_CODIFTableAdapter
    Friend WithEvents colCDF_CODE_PKfils As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCDF_NOMFils As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DsTheriaque_Nomenclature21 As Theriaque.dsTheriaque_Nomenclature2
    Friend WithEvents CdF_CODIFTA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.CDF_CODIFTableAdapter

End Class
