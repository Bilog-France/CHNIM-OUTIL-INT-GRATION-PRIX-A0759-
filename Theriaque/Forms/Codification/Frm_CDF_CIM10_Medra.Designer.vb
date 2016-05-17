<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CDF_CIM10_Medra
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
        Me.DsTheriaque1 = New Theriaque.dsTheriaque
        Me.CdF_CODIFTableAdapter = New Theriaque.dsTheriaqueTableAdapters.CDF_CODIFTableAdapter
        Me.SycdF_SYNCODIFTableAdapter = New Theriaque.dsTheriaqueTableAdapters.SYCDF_SYNCODIFTableAdapter
        Me.CimcdF_CIM10_CODIFTableAdapter = New Theriaque.dsTheriaqueTableAdapters.CIMCDF_CIM10_CODIFTableAdapter
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSYCDF_NOM_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSYCDF_CDF_NUMERO_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSYCDF_CDF_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLibelle = New DevExpress.XtraEditors.TextEdit
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GC2 = New DevExpress.XtraGrid.GridControl
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCIMCDF_CIM_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpCIM10 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colCIMCDF_CDF_NUMERO_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCIMCDF_CDF_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCIMCDF_CIM_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GC3 = New DevExpress.XtraGrid.GridControl
        Me.GV3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colMEDCDF_MED_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpMedra = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colMEDCDF_CDF_NUMERO_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMEDCDF_CDF_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMEDCDF_MED_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MedcdF_MEDRA_CODIFTableAdapter = New Theriaque.dsTheriaqueTableAdapters.MEDCDF_MEDRA_CODIFTableAdapter
        Me.CdF_CODIFTA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.CDF_CODIFTableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanPere.SuspendLayout()
        CType(Me.lkupCDF_CODE_PK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodePere.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNCodif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_Nomenclature21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpCIM10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GC3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpMedra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(647, 566)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.GroupBox1)
        Me.PanMain.Controls.Add(Me.XtraTabControl1)
        Me.PanMain.Controls.Add(Me.PanPere)
        Me.PanMain.Controls.Add(Me.Label2)
        Me.PanMain.Controls.Add(Me.Label3)
        Me.PanMain.Controls.Add(Me.txtNCodif)
        Me.PanMain.Controls.Add(Me.txtCode)
        Me.PanMain.Controls.Add(Me.Label6)
        Me.PanMain.Controls.Add(Me.txtLibelle)
        Me.PanMain.Size = New System.Drawing.Size(529, 479)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(647, 87)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(647, 28)
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
        Me.Panel1.Location = New System.Drawing.Point(529, 87)
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
        Me.GroupBox.Size = New System.Drawing.Size(647, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDF_CODIF.CDF_DATECR", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        '
        'DsTheriaque1
        '
        Me.DsTheriaque1.DataSetName = "dsTheriaque"
        Me.DsTheriaque1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CdF_CODIFTableAdapter
        '
        Me.CdF_CODIFTableAdapter.ClearBeforeFill = True
        '
        'SycdF_SYNCODIFTableAdapter
        '
        Me.SycdF_SYNCODIFTableAdapter.ClearBeforeFill = True
        '
        'CimcdF_CIM10_CODIFTableAdapter
        '
        Me.CimcdF_CIM10_CODIFTableAdapter.ClearBeforeFill = True
        '
        'PanPere
        '
        Me.PanPere.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanPere.Controls.Add(Me.lkupCDF_CODE_PK)
        Me.PanPere.Controls.Add(Me.Label4)
        Me.PanPere.Controls.Add(Me.Label5)
        Me.PanPere.Controls.Add(Me.txtCodePere)
        Me.PanPere.Location = New System.Drawing.Point(12, 30)
        Me.PanPere.Name = "PanPere"
        Me.PanPere.Size = New System.Drawing.Size(509, 26)
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
        Me.lkupCDF_CODE_PK.Size = New System.Drawing.Size(270, 20)
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
        Me.Label2.Location = New System.Drawing.Point(40, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "N° Codif"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Code"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNCodif
        '
        Me.txtNCodif.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDF_CODIF.CDF_NUMERO_PK", True))
        Me.txtNCodif.Location = New System.Drawing.Point(92, 6)
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
        Me.txtCode.Location = New System.Drawing.Point(92, 58)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 32
        Me.txtCode.Tag = "[NOEDIT][ADD]"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GC)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(509, 167)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = "[NOADD][EDIT]"
        Me.GroupBox1.Text = "Synonymes"
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
        Me.GC.Size = New System.Drawing.Size(495, 139)
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
        Me.Label6.Location = New System.Drawing.Point(49, 87)
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
        Me.txtLibelle.Location = New System.Drawing.Point(92, 84)
        Me.txtLibelle.Name = "txtLibelle"
        Me.txtLibelle.Size = New System.Drawing.Size(419, 20)
        Me.txtLibelle.TabIndex = 33
        Me.txtLibelle.Tag = "[EDIT][ADD]"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(10, 283)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(511, 193)
        Me.XtraTabControl1.TabIndex = 41
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        Me.XtraTabControl1.Tag = "[EDIT][NOADD]"
        Me.XtraTabControl1.Text = "Classe CIM10"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GC2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(502, 162)
        Me.XtraTabPage1.Text = "Classe CIM10"
        '
        'GC2
        '
        Me.GC2.DataMember = "CIMCDF_CIM10_CODIF"
        Me.GC2.DataSource = Me.DsTheriaque1
        Me.GC2.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.GC2.Location = New System.Drawing.Point(0, 0)
        Me.GC2.MainView = Me.GV2
        Me.GC2.Name = "GC2"
        Me.GC2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpCIM10})
        Me.GC2.Size = New System.Drawing.Size(502, 162)
        Me.GC2.TabIndex = 41
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
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GC3)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(485, 162)
        Me.XtraTabPage2.Text = "Classe MEDRA"
        '
        'GC3
        '
        Me.GC3.DataMember = "MEDCDF_MEDRA_CODIF"
        Me.GC3.DataSource = Me.DsTheriaque1
        Me.GC3.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.GC3.Location = New System.Drawing.Point(0, 0)
        Me.GC3.MainView = Me.GV3
        Me.GC3.Name = "GC3"
        Me.GC3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpMedra})
        Me.GC3.Size = New System.Drawing.Size(485, 162)
        Me.GC3.TabIndex = 42
        Me.GC3.UseEmbeddedNavigator = True
        Me.GC3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV3})
        '
        'GV3
        '
        Me.GV3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMEDCDF_MED_CODE_FK_PK, Me.colMEDCDF_CDF_NUMERO_FK_PK, Me.colMEDCDF_CDF_CODE_FK_PK, Me.colMEDCDF_MED_CODE_FK_PK2})
        Me.GV3.GridControl = Me.GC3
        Me.GV3.GroupPanelText = " "
        Me.GV3.Name = "GV3"
        Me.GV3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV3.OptionsView.ShowGroupPanel = False
        '
        'colMEDCDF_MED_CODE_FK_PK
        '
        Me.colMEDCDF_MED_CODE_FK_PK.Caption = "Libellé"
        Me.colMEDCDF_MED_CODE_FK_PK.ColumnEdit = Me.rpMedra
        Me.colMEDCDF_MED_CODE_FK_PK.FieldName = "MEDCDF_MED_CODE_FK_PK"
        Me.colMEDCDF_MED_CODE_FK_PK.Name = "colMEDCDF_MED_CODE_FK_PK"
        Me.colMEDCDF_MED_CODE_FK_PK.Visible = True
        Me.colMEDCDF_MED_CODE_FK_PK.VisibleIndex = 1
        Me.colMEDCDF_MED_CODE_FK_PK.Width = 390
        '
        'rpMedra
        '
        Me.rpMedra.AutoHeight = False
        Me.rpMedra.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpMedra.Name = "rpMedra"
        Me.rpMedra.NullText = ""
        '
        'colMEDCDF_CDF_NUMERO_FK_PK
        '
        Me.colMEDCDF_CDF_NUMERO_FK_PK.Caption = "MEDCDF_CDF_NUMERO_FK_PK"
        Me.colMEDCDF_CDF_NUMERO_FK_PK.FieldName = "MEDCDF_CDF_NUMERO_FK_PK"
        Me.colMEDCDF_CDF_NUMERO_FK_PK.Name = "colMEDCDF_CDF_NUMERO_FK_PK"
        '
        'colMEDCDF_CDF_CODE_FK_PK
        '
        Me.colMEDCDF_CDF_CODE_FK_PK.Caption = "MEDCDF_CDF_CODE_FK_PK"
        Me.colMEDCDF_CDF_CODE_FK_PK.FieldName = "MEDCDF_CDF_CODE_FK_PK"
        Me.colMEDCDF_CDF_CODE_FK_PK.Name = "colMEDCDF_CDF_CODE_FK_PK"
        '
        'colMEDCDF_MED_CODE_FK_PK2
        '
        Me.colMEDCDF_MED_CODE_FK_PK2.Caption = "Code"
        Me.colMEDCDF_MED_CODE_FK_PK2.FieldName = "MEDCDF_MED_CODE_FK_PK"
        Me.colMEDCDF_MED_CODE_FK_PK2.Name = "colMEDCDF_MED_CODE_FK_PK2"
        Me.colMEDCDF_MED_CODE_FK_PK2.Visible = True
        Me.colMEDCDF_MED_CODE_FK_PK2.VisibleIndex = 0
        Me.colMEDCDF_MED_CODE_FK_PK2.Width = 91
        '
        'MedcdF_MEDRA_CODIFTableAdapter
        '
        Me.MedcdF_MEDRA_CODIFTableAdapter.ClearBeforeFill = True
        '
        'CdF_CODIFTA
        '
        Me.CdF_CODIFTA.ClearBeforeFill = True
        '
        'Frm_CDF_CIM10_Medra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(647, 566)
        Me.Name = "Frm_CDF_CIM10_Medra"
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
        Me.PanPere.ResumeLayout(False)
        Me.PanPere.PerformLayout()
        CType(Me.lkupCDF_CODE_PK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodePere.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNCodif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_Nomenclature21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpCIM10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GC3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpMedra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DsTheriaque1 As Theriaque.dsTheriaque
    Friend WithEvents CdF_CODIFTableAdapter As Theriaque.dsTheriaqueTableAdapters.CDF_CODIFTableAdapter
    Friend WithEvents SycdF_SYNCODIFTableAdapter As Theriaque.dsTheriaqueTableAdapters.SYCDF_SYNCODIFTableAdapter
    Friend WithEvents CimcdF_CIM10_CODIFTableAdapter As Theriaque.dsTheriaqueTableAdapters.CIMCDF_CIM10_CODIFTableAdapter
    Friend WithEvents PanPere As System.Windows.Forms.Panel
    Friend WithEvents lkupCDF_CODE_PK As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodePere As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNCodif As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSYCDF_NOM_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSYCDF_CDF_NUMERO_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSYCDF_CDF_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GC2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCIMCDF_CIM_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpCIM10 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colCIMCDF_CDF_NUMERO_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIMCDF_CDF_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIMCDF_CIM_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GC3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rpMedra As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents MedcdF_MEDRA_CODIFTableAdapter As Theriaque.dsTheriaqueTableAdapters.MEDCDF_MEDRA_CODIFTableAdapter
    Friend WithEvents colMEDCDF_MED_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMEDCDF_CDF_NUMERO_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMEDCDF_CDF_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMEDCDF_MED_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Protected Friend WithEvents txtLibelle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DsTheriaque_Nomenclature21 As Theriaque.dsTheriaque_Nomenclature2
    Friend WithEvents CdF_CODIFTA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.CDF_CODIFTableAdapter

End Class
