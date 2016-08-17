<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CDF_IVO
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
        Me.components = New System.ComponentModel.Container
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNCodif = New DevExpress.XtraEditors.TextEdit
        Me.DsTheriaque_Nomenclature21 = New Theriaque.dsTheriaque_Nomenclature2
        Me.DsTheriaque1 = New Theriaque.dsTheriaque
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSYCDF_NOM_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSYCDF_CDF_NUMERO_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSYCDF_CDF_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtIDVO_CDF_NUMERO_FK_PK = New DevExpress.XtraEditors.TextEdit
        Me.txtIDVO_CDF_CODE_FK_PK = New DevExpress.XtraEditors.TextEdit
        Me.txtLibelle = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GC2 = New DevExpress.XtraGrid.GridControl
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCDFNP_NUMERO_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCDFNP_CDF_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCDFNP_REF_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkupCDF25 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colCDFNP_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label4 = New System.Windows.Forms.Label
        Me.CdF_CODIFTableAdapter = New Theriaque.dsTheriaqueTableAdapters.CDF_CODIFTableAdapter
        Me.SycdF_SYNCODIFTableAdapter = New Theriaque.dsTheriaqueTableAdapters.SYCDF_SYNCODIFTableAdapter
        Me.IdvO_IDENT_VOIETableAdapter = New Theriaque.dsTheriaqueTableAdapters.IDVO_IDENT_VOIETableAdapter
        Me.CdfnP_CODIFTableAdapter = New Theriaque.dsTheriaqueTableAdapters.CDFNP_CODIFTableAdapter
        Me.CdF_CODIFTableAdapterSourceOffc = New Theriaque.dsTheriaqueTableAdapters.CDF_CODIFTableAdapter
        Me.lbValCoef = New System.Windows.Forms.Label
        Me.txtValCoefficient = New DevExpress.XtraEditors.TextEdit
        Me.CDFCODIFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtNomAbrege = New DevExpress.XtraEditors.TextEdit
        Me.lbNomABRG = New System.Windows.Forms.Label
        Me.CdF_CODIFTA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.CDF_CODIFTableAdapter
        Me.txtIdentification = New DevExpress.XtraEditors.TextEdit
        Me.lblCategorie = New System.Windows.Forms.Label
        Me.lkupCatégorie = New DevExpress.XtraEditors.LookUpEdit
        Me.CatvO_CATEGORIEVOIETableAdapter1 = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.CATVO_CATEGORIEVOIETableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNCodif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_Nomenclature21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIDVO_CDF_NUMERO_FK_PK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIDVO_CDF_CODE_FK_PK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupCDF25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValCoefficient.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CDFCODIFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomAbrege.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdentification.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupCatégorie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(625, 545)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.lkupCatégorie)
        Me.PanMain.Controls.Add(Me.lblCategorie)
        Me.PanMain.Controls.Add(Me.txtIdentification)
        Me.PanMain.Controls.Add(Me.txtNomAbrege)
        Me.PanMain.Controls.Add(Me.lbNomABRG)
        Me.PanMain.Controls.Add(Me.txtValCoefficient)
        Me.PanMain.Controls.Add(Me.lbValCoef)
        Me.PanMain.Controls.Add(Me.Label4)
        Me.PanMain.Controls.Add(Me.GroupBox2)
        Me.PanMain.Controls.Add(Me.Label2)
        Me.PanMain.Controls.Add(Me.txtNCodif)
        Me.PanMain.Controls.Add(Me.GroupBox1)
        Me.PanMain.Controls.Add(Me.txtLibelle)
        Me.PanMain.Controls.Add(Me.Label6)
        Me.PanMain.Controls.Add(Me.txtCode)
        Me.PanMain.Controls.Add(Me.Label3)
        Me.PanMain.Size = New System.Drawing.Size(507, 458)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(625, 87)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(625, 28)
        Me.Label1.Text = ""
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
        Me.LabelControl1.Location = New System.Drawing.Point(45, 46)
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(507, 87)
        Me.Panel1.Size = New System.Drawing.Size(118, 458)
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
        Me.GroupBox.Size = New System.Drawing.Size(625, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDF_CODIF.CDF_DATECR", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(101, 44)
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "N° Codif"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNCodif
        '
        Me.txtNCodif.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDF_CODIF.CDF_NUMERO_PK", True))
        Me.txtNCodif.Location = New System.Drawing.Point(101, 13)
        Me.txtNCodif.Name = "txtNCodif"
        Me.txtNCodif.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.txtNCodif.Properties.Appearance.Options.UseBackColor = True
        Me.txtNCodif.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNCodif.Properties.ReadOnly = True
        Me.txtNCodif.Size = New System.Drawing.Size(100, 20)
        Me.txtNCodif.TabIndex = 23
        Me.txtNCodif.TabStop = False
        Me.txtNCodif.Tag = ""
        '
        'DsTheriaque_Nomenclature21
        '
        Me.DsTheriaque_Nomenclature21.DataSetName = "dsTheriaque_Nomenclature2"
        Me.DsTheriaque_Nomenclature21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsTheriaque1
        '
        Me.DsTheriaque1.DataSetName = "("
        Me.DsTheriaque1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GC)
        Me.GroupBox1.Controls.Add(Me.txtIDVO_CDF_NUMERO_FK_PK)
        Me.GroupBox1.Controls.Add(Me.txtIDVO_CDF_CODE_FK_PK)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(497, 148)
        Me.GroupBox1.TabIndex = 20
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
        Me.GC.Size = New System.Drawing.Size(478, 120)
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
        'txtIDVO_CDF_NUMERO_FK_PK
        '
        Me.txtIDVO_CDF_NUMERO_FK_PK.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "IDVO_IDENT_VOIE.IDVO_CDF_NUMERO_FK_PK", True))
        Me.txtIDVO_CDF_NUMERO_FK_PK.Location = New System.Drawing.Point(191, 60)
        Me.txtIDVO_CDF_NUMERO_FK_PK.Name = "txtIDVO_CDF_NUMERO_FK_PK"
        Me.txtIDVO_CDF_NUMERO_FK_PK.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIDVO_CDF_NUMERO_FK_PK.Size = New System.Drawing.Size(10, 20)
        Me.txtIDVO_CDF_NUMERO_FK_PK.TabIndex = 18
        Me.txtIDVO_CDF_NUMERO_FK_PK.TabStop = False
        Me.txtIDVO_CDF_NUMERO_FK_PK.Tag = ""
        '
        'txtIDVO_CDF_CODE_FK_PK
        '
        Me.txtIDVO_CDF_CODE_FK_PK.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "IDVO_IDENT_VOIE.IDVO_CDF_CODE_FK_PK", True))
        Me.txtIDVO_CDF_CODE_FK_PK.Location = New System.Drawing.Point(207, 60)
        Me.txtIDVO_CDF_CODE_FK_PK.Name = "txtIDVO_CDF_CODE_FK_PK"
        Me.txtIDVO_CDF_CODE_FK_PK.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIDVO_CDF_CODE_FK_PK.Size = New System.Drawing.Size(10, 20)
        Me.txtIDVO_CDF_CODE_FK_PK.TabIndex = 18
        Me.txtIDVO_CDF_CODE_FK_PK.TabStop = False
        Me.txtIDVO_CDF_CODE_FK_PK.Tag = ""
        '
        'txtLibelle
        '
        Me.txtLibelle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLibelle.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDF_CODIF.CDF_NOM", True))
        Me.txtLibelle.Location = New System.Drawing.Point(101, 64)
        Me.txtLibelle.Name = "txtLibelle"
        Me.txtLibelle.Size = New System.Drawing.Size(397, 20)
        Me.txtLibelle.TabIndex = 19
        Me.txtLibelle.Tag = "[EDIT][ADD]"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Libellé"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDF_CODIF.CDF_CODE_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(101, 39)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 18
        Me.txtCode.Tag = "[NOEDIT]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Code"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.GC2)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 295)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(498, 137)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = "[NOADD][EDIT]"
        Me.GroupBox2.Text = "Source officielle"
        '
        'GC2
        '
        Me.GC2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC2.DataMember = "CDFNP_CODIF"
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
        Me.GC2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkupCDF25})
        Me.GC2.Size = New System.Drawing.Size(481, 86)
        Me.GC2.TabIndex = 0
        Me.GC2.UseEmbeddedNavigator = True
        Me.GC2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCDFNP_NUMERO_FK_PK, Me.colCDFNP_CDF_CODE_FK_PK, Me.colCDFNP_REF_CODE_FK_PK, Me.colCDFNP_NUMORD})
        Me.GV2.GridControl = Me.GC2
        Me.GV2.GroupPanelText = " "
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV2.OptionsView.ShowGroupPanel = False
        '
        'colCDFNP_NUMERO_FK_PK
        '
        Me.colCDFNP_NUMERO_FK_PK.Caption = "CDFNP_NUMERO_FK_PK"
        Me.colCDFNP_NUMERO_FK_PK.FieldName = "CDFNP_NUMERO_FK_PK"
        Me.colCDFNP_NUMERO_FK_PK.Name = "colCDFNP_NUMERO_FK_PK"
        '
        'colCDFNP_CDF_CODE_FK_PK
        '
        Me.colCDFNP_CDF_CODE_FK_PK.Caption = "CDFNP_CDF_CODE_FK_PK"
        Me.colCDFNP_CDF_CODE_FK_PK.FieldName = "CDFNP_CDF_CODE_FK_PK"
        Me.colCDFNP_CDF_CODE_FK_PK.Name = "colCDFNP_CDF_CODE_FK_PK"
        '
        'colCDFNP_REF_CODE_FK_PK
        '
        Me.colCDFNP_REF_CODE_FK_PK.Caption = "Libellé"
        Me.colCDFNP_REF_CODE_FK_PK.ColumnEdit = Me.lkupCDF25
        Me.colCDFNP_REF_CODE_FK_PK.FieldName = "CDFNP_REF_CODE_FK_PK"
        Me.colCDFNP_REF_CODE_FK_PK.Name = "colCDFNP_REF_CODE_FK_PK"
        Me.colCDFNP_REF_CODE_FK_PK.Visible = True
        Me.colCDFNP_REF_CODE_FK_PK.VisibleIndex = 0
        '
        'lkupCDF25
        '
        Me.lkupCDF25.AutoHeight = False
        Me.lkupCDF25.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupCDF25.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CDF_NOM", "Libellé", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.lkupCDF25.DisplayMember = "CDF_NOM"
        Me.lkupCDF25.DropDownRows = 10
        Me.lkupCDF25.Name = "lkupCDF25"
        Me.lkupCDF25.NullText = ""
        Me.lkupCDF25.PopupWidth = 300
        Me.lkupCDF25.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.lkupCDF25.ValueMember = "CDF_CODE_PK"
        '
        'colCDFNP_NUMORD
        '
        Me.colCDFNP_NUMORD.Caption = "CDFNP_NUMORD"
        Me.colCDFNP_NUMORD.FieldName = "CDFNP_NUMORD"
        Me.colCDFNP_NUMORD.Name = "colCDFNP_NUMORD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Identification"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CdF_CODIFTableAdapter
        '
        Me.CdF_CODIFTableAdapter.ClearBeforeFill = True
        '
        'SycdF_SYNCODIFTableAdapter
        '
        Me.SycdF_SYNCODIFTableAdapter.ClearBeforeFill = True
        '
        'IdvO_IDENT_VOIETableAdapter
        '
        Me.IdvO_IDENT_VOIETableAdapter.ClearBeforeFill = True
        '
        'CdfnP_CODIFTableAdapter
        '
        Me.CdfnP_CODIFTableAdapter.ClearBeforeFill = True
        '
        'CdF_CODIFTableAdapterSourceOffc
        '
        Me.CdF_CODIFTableAdapterSourceOffc.ClearBeforeFill = True
        '
        'lbValCoef
        '
        Me.lbValCoef.AutoSize = True
        Me.lbValCoef.Location = New System.Drawing.Point(4, 93)
        Me.lbValCoef.Name = "lbValCoef"
        Me.lbValCoef.Size = New System.Drawing.Size(92, 13)
        Me.lbValCoef.TabIndex = 25
        Me.lbValCoef.Text = "Valeur/Coefficient"
        Me.lbValCoef.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtValCoefficient
        '
        Me.txtValCoefficient.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDF_CODIF.CDF_VAL_NUM", True))
        Me.txtValCoefficient.Location = New System.Drawing.Point(101, 90)
        Me.txtValCoefficient.Name = "txtValCoefficient"
        Me.txtValCoefficient.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtValCoefficient.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValCoefficient.Size = New System.Drawing.Size(100, 20)
        Me.txtValCoefficient.TabIndex = 19
        Me.txtValCoefficient.Tag = "[EDIT][ADD]"
        '
        'CDFCODIFBindingSource
        '
        Me.CDFCODIFBindingSource.DataMember = "CDF_CODIF"
        Me.CDFCODIFBindingSource.DataSource = Me.DsTheriaque_Nomenclature21
        '
        'txtNomAbrege
        '
        Me.txtNomAbrege.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDF_CODIF.CDF_NOMABRG", True))
        Me.txtNomAbrege.Location = New System.Drawing.Point(101, 90)
        Me.txtNomAbrege.Name = "txtNomAbrege"
        Me.txtNomAbrege.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtNomAbrege.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomAbrege.Size = New System.Drawing.Size(100, 20)
        Me.txtNomAbrege.TabIndex = 28
        Me.txtNomAbrege.Tag = "[EDIT][ADD]"
        '
        'lbNomABRG
        '
        Me.lbNomABRG.AutoSize = True
        Me.lbNomABRG.Location = New System.Drawing.Point(26, 92)
        Me.lbNomABRG.Name = "lbNomABRG"
        Me.lbNomABRG.Size = New System.Drawing.Size(65, 13)
        Me.lbNomABRG.TabIndex = 29
        Me.lbNomABRG.Text = "Nom abrégé"
        Me.lbNomABRG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CdF_CODIFTA
        '
        Me.CdF_CODIFTA.ClearBeforeFill = True
        '
        'txtIdentification
        '
        Me.txtIdentification.Location = New System.Drawing.Point(101, 115)
        Me.txtIdentification.Name = "txtIdentification"
        Me.txtIdentification.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtIdentification.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdentification.Size = New System.Drawing.Size(135, 20)
        Me.txtIdentification.TabIndex = 30
        Me.txtIdentification.Tag = "[EDIT][ADD]"
        '
        'lblCategorie
        '
        Me.lblCategorie.AutoSize = True
        Me.lblCategorie.Location = New System.Drawing.Point(258, 94)
        Me.lblCategorie.Name = "lblCategorie"
        Me.lblCategorie.Size = New System.Drawing.Size(52, 13)
        Me.lblCategorie.TabIndex = 31
        Me.lblCategorie.Text = "Catégorie"
        Me.lblCategorie.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCategorie.Visible = False
        '
        'lkupCatégorie
        '
        Me.lkupCatégorie.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CATVO_CATEGORIEVOIE.CATVO_CDF_CAT_CODE_FK_PK", True))
        Me.lkupCatégorie.Enabled = False
        Me.lkupCatégorie.Location = New System.Drawing.Point(316, 91)
        Me.lkupCatégorie.Name = "lkupCatégorie"
        Me.lkupCatégorie.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupCatégorie.Properties.DisplayMember = "code"
        Me.lkupCatégorie.Size = New System.Drawing.Size(182, 20)
        Me.lkupCatégorie.TabIndex = 32
        Me.lkupCatégorie.Tag = ""
        Me.lkupCatégorie.Visible = False
        '
        'CatvO_CATEGORIEVOIETableAdapter1
        '
        Me.CatvO_CATEGORIEVOIETableAdapter1.ClearBeforeFill = True
        '
        'Frm_CDF_IVO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(625, 545)
        Me.Name = "Frm_CDF_IVO"
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
        CType(Me.txtNCodif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_Nomenclature21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIDVO_CDF_NUMERO_FK_PK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIDVO_CDF_CODE_FK_PK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupCDF25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValCoefficient.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CDFCODIFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomAbrege.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdentification.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupCatégorie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNCodif As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSYCDF_NOM_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSYCDF_CDF_NUMERO_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSYCDF_CDF_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtLibelle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GC2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsTheriaque1 As Theriaque.dsTheriaque
    Friend WithEvents CdF_CODIFTableAdapter As Theriaque.dsTheriaqueTableAdapters.CDF_CODIFTableAdapter
    Friend WithEvents SycdF_SYNCODIFTableAdapter As Theriaque.dsTheriaqueTableAdapters.SYCDF_SYNCODIFTableAdapter
    Friend WithEvents IdvO_IDENT_VOIETableAdapter As Theriaque.dsTheriaqueTableAdapters.IDVO_IDENT_VOIETableAdapter
    Friend WithEvents CdfnP_CODIFTableAdapter As Theriaque.dsTheriaqueTableAdapters.CDFNP_CODIFTableAdapter
    Friend WithEvents txtIDVO_CDF_NUMERO_FK_PK As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIDVO_CDF_CODE_FK_PK As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colCDFNP_NUMERO_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCDFNP_CDF_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCDFNP_REF_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCDFNP_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkupCDF25 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents CdF_CODIFTableAdapterSourceOffc As Theriaque.dsTheriaqueTableAdapters.CDF_CODIFTableAdapter
    Friend WithEvents txtValCoefficient As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbValCoef As System.Windows.Forms.Label
    Friend WithEvents txtNomAbrege As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbNomABRG As System.Windows.Forms.Label
    Friend WithEvents CdF_CODIFTA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.CDF_CODIFTableAdapter
    Friend WithEvents DsTheriaque_Nomenclature21 As Theriaque.dsTheriaque_Nomenclature2
    Friend WithEvents CDFCODIFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtIdentification As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCategorie As System.Windows.Forms.Label
    Friend WithEvents lkupCatégorie As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CatvO_CATEGORIEVOIETableAdapter1 As Theriaque.dsTheriaque_Nomenclature2TableAdapters.CATVO_CATEGORIEVOIETableAdapter

End Class
