<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CDF_PP
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNCodif = New DevExpress.XtraEditors.TextEdit
        Me.DsTheriaque_Nomenclature21 = New Theriaque.dsTheriaque_Nomenclature2
        Me.DsTheriaque1 = New Theriaque.dsTheriaque
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSYCDF_NOM_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSYCDF_CDF_NUMERO_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSYCDF_CDF_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLibelle = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.CdF_CODIFTableAdapter = New Theriaque.dsTheriaqueTableAdapters.CDF_CODIFTableAdapter
        Me.SycdF_SYNCODIFTableAdapter = New Theriaque.dsTheriaqueTableAdapters.SYCDF_SYNCODIFTableAdapter
        Me.CdfiuP_INFO_UNITE_PRISETableAdapter = New Theriaque.dsTheriaqueTableAdapters.CDFIUP_INFO_UNITE_PRISETableAdapter
        Me.lkupCDFIUP_COEFVOL_CDF_CODE_FK = New DevExpress.XtraEditors.LookUpEdit
        Me.lkupCDFIUP_COEFDUR_CDF_NUM_FK = New DevExpress.XtraEditors.LookUpEdit
        Me.lkupCDFIUP_DONANTH_CDF_CODE_FK = New DevExpress.XtraEditors.LookUpEdit
        Me.txtCDFIUP_COEFDUR_CDF_NUM_FK = New DevExpress.XtraEditors.TextEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.CdF_CODIFTA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.CDF_CODIFTableAdapter
        Me.lkupUnite_UCUM = New DevExpress.XtraEditors.LookUpEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.CdfcdfU_CDFUTableAdapter1 = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.CDFCDFU_CDFUTableAdapter
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
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupCDFIUP_COEFVOL_CDF_CODE_FK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupCDFIUP_COEFDUR_CDF_NUM_FK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupCDFIUP_DONANTH_CDF_CODE_FK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCDFIUP_COEFDUR_CDF_NUM_FK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.lkupUnite_UCUM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(625, 532)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.lkupUnite_UCUM)
        Me.PanMain.Controls.Add(Me.Label8)
        Me.PanMain.Controls.Add(Me.LabelControl4)
        Me.PanMain.Controls.Add(Me.LabelControl7)
        Me.PanMain.Controls.Add(Me.LabelControl6)
        Me.PanMain.Controls.Add(Me.LabelControl5)
        Me.PanMain.Controls.Add(Me.Panel2)
        Me.PanMain.Controls.Add(Me.ComboBoxEdit1)
        Me.PanMain.Controls.Add(Me.LabelControl3)
        Me.PanMain.Controls.Add(Me.Label2)
        Me.PanMain.Controls.Add(Me.Label3)
        Me.PanMain.Controls.Add(Me.txtNCodif)
        Me.PanMain.Controls.Add(Me.txtCode)
        Me.PanMain.Controls.Add(Me.GroupBox1)
        Me.PanMain.Controls.Add(Me.Label6)
        Me.PanMain.Controls.Add(Me.txtLibelle)
        Me.PanMain.Size = New System.Drawing.Size(507, 445)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(625, 87)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(625, 28)
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
        Me.Panel1.Location = New System.Drawing.Point(507, 87)
        Me.Panel1.Size = New System.Drawing.Size(118, 445)
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
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "N° Codif"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Code"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNCodif
        '
        Me.txtNCodif.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDF_CODIF.CDF_NUMERO_PK", True))
        Me.txtNCodif.Location = New System.Drawing.Point(127, 13)
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
        'DsTheriaque1
        '
        Me.DsTheriaque1.DataSetName = "dsTheriaque"
        Me.DsTheriaque1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDF_CODIF.CDF_CODE_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(127, 39)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Tag = "[NOEDIT][ADD]"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GC)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 228)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 214)
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
        Me.GC.Size = New System.Drawing.Size(484, 186)
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
        Me.Label6.Location = New System.Drawing.Point(79, 68)
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
        Me.txtLibelle.Location = New System.Drawing.Point(127, 65)
        Me.txtLibelle.Name = "txtLibelle"
        Me.txtLibelle.Size = New System.Drawing.Size(360, 20)
        Me.txtLibelle.TabIndex = 1
        Me.txtLibelle.Tag = "[EDIT][ADD]"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(46, 119)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl3.TabIndex = 39
        Me.LabelControl3.Text = "Applicable O/N"
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CDFIUP_INFO_UNITE_PRISE.CDFIUP_APPLICABLE", True))
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(127, 116)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"O", "N"})
        Me.ComboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(100, 20)
        Me.ComboBoxEdit1.TabIndex = 2
        Me.ComboBoxEdit1.Tag = "[EDIT][ADD]"
        '
        'CdF_CODIFTableAdapter
        '
        Me.CdF_CODIFTableAdapter.ClearBeforeFill = True
        '
        'SycdF_SYNCODIFTableAdapter
        '
        Me.SycdF_SYNCODIFTableAdapter.ClearBeforeFill = True
        '
        'CdfiuP_INFO_UNITE_PRISETableAdapter
        '
        Me.CdfiuP_INFO_UNITE_PRISETableAdapter.ClearBeforeFill = True
        '
        'lkupCDFIUP_COEFVOL_CDF_CODE_FK
        '
        Me.lkupCDFIUP_COEFVOL_CDF_CODE_FK.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CDFIUP_INFO_UNITE_PRISE.CDFIUP_COEFVOL_CDF_CODE_FK", True))
        Me.lkupCDFIUP_COEFVOL_CDF_CODE_FK.Location = New System.Drawing.Point(8, 56)
        Me.lkupCDFIUP_COEFVOL_CDF_CODE_FK.Name = "lkupCDFIUP_COEFVOL_CDF_CODE_FK"
        Me.lkupCDFIUP_COEFVOL_CDF_CODE_FK.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupCDFIUP_COEFVOL_CDF_CODE_FK.Properties.NullText = ""
        Me.lkupCDFIUP_COEFVOL_CDF_CODE_FK.Size = New System.Drawing.Size(220, 20)
        Me.lkupCDFIUP_COEFVOL_CDF_CODE_FK.TabIndex = 5
        Me.lkupCDFIUP_COEFVOL_CDF_CODE_FK.Tag = ""
        '
        'lkupCDFIUP_COEFDUR_CDF_NUM_FK
        '
        Me.lkupCDFIUP_COEFDUR_CDF_NUM_FK.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CDFIUP_INFO_UNITE_PRISE.CDFIUP_COEFDUR_CDF_CODE_FK", True))
        Me.lkupCDFIUP_COEFDUR_CDF_NUM_FK.Location = New System.Drawing.Point(8, 30)
        Me.lkupCDFIUP_COEFDUR_CDF_NUM_FK.Name = "lkupCDFIUP_COEFDUR_CDF_NUM_FK"
        Me.lkupCDFIUP_COEFDUR_CDF_NUM_FK.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupCDFIUP_COEFDUR_CDF_NUM_FK.Properties.NullText = ""
        Me.lkupCDFIUP_COEFDUR_CDF_NUM_FK.Size = New System.Drawing.Size(220, 20)
        Me.lkupCDFIUP_COEFDUR_CDF_NUM_FK.TabIndex = 5
        Me.lkupCDFIUP_COEFDUR_CDF_NUM_FK.Tag = ""
        '
        'lkupCDFIUP_DONANTH_CDF_CODE_FK
        '
        Me.lkupCDFIUP_DONANTH_CDF_CODE_FK.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CDFIUP_INFO_UNITE_PRISE.CDFIUP_DONANTH_CDF_CODE_FK", True))
        Me.lkupCDFIUP_DONANTH_CDF_CODE_FK.Location = New System.Drawing.Point(8, 3)
        Me.lkupCDFIUP_DONANTH_CDF_CODE_FK.Name = "lkupCDFIUP_DONANTH_CDF_CODE_FK"
        Me.lkupCDFIUP_DONANTH_CDF_CODE_FK.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupCDFIUP_DONANTH_CDF_CODE_FK.Properties.NullText = ""
        Me.lkupCDFIUP_DONANTH_CDF_CODE_FK.Size = New System.Drawing.Size(220, 20)
        Me.lkupCDFIUP_DONANTH_CDF_CODE_FK.TabIndex = 5
        Me.lkupCDFIUP_DONANTH_CDF_CODE_FK.Tag = ""
        '
        'txtCDFIUP_COEFDUR_CDF_NUM_FK
        '
        Me.txtCDFIUP_COEFDUR_CDF_NUM_FK.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CDFIUP_INFO_UNITE_PRISE.CDFIUP_COEFDUR_CDF_NUM_FK", True))
        Me.txtCDFIUP_COEFDUR_CDF_NUM_FK.Location = New System.Drawing.Point(229, 30)
        Me.txtCDFIUP_COEFDUR_CDF_NUM_FK.Name = "txtCDFIUP_COEFDUR_CDF_NUM_FK"
        Me.txtCDFIUP_COEFDUR_CDF_NUM_FK.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCDFIUP_COEFDUR_CDF_NUM_FK.Properties.ReadOnly = True
        Me.txtCDFIUP_COEFDUR_CDF_NUM_FK.Size = New System.Drawing.Size(26, 20)
        Me.txtCDFIUP_COEFDUR_CDF_NUM_FK.TabIndex = 0
        Me.txtCDFIUP_COEFDUR_CDF_NUM_FK.Tag = "[NOEDIT]"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lkupCDFIUP_DONANTH_CDF_CODE_FK)
        Me.Panel2.Controls.Add(Me.lkupCDFIUP_COEFDUR_CDF_NUM_FK)
        Me.Panel2.Controls.Add(Me.lkupCDFIUP_COEFVOL_CDF_CODE_FK)
        Me.Panel2.Controls.Add(Me.txtCDFIUP_COEFDUR_CDF_NUM_FK)
        Me.Panel2.Location = New System.Drawing.Point(119, 142)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(269, 82)
        Me.Panel2.TabIndex = 40
        Me.Panel2.Tag = "[ADD][EDIT]"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(79, 142)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl4.TabIndex = 43
        Me.LabelControl4.Text = "Donnée"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(12, 202)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl7.TabIndex = 44
        Me.LabelControl7.Text = "Coefficient de volume"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(18, 177)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(98, 13)
        Me.LabelControl6.TabIndex = 41
        Me.LabelControl6.Text = "Coefficient de durée"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(27, 152)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl5.TabIndex = 42
        Me.LabelControl5.Text = " anthropométrique"
        '
        'CdF_CODIFTA
        '
        Me.CdF_CODIFTA.ClearBeforeFill = True
        '
        'lkupUnite_UCUM
        '
        Me.lkupUnite_UCUM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkupUnite_UCUM.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDFCDFU_CDFU.CDFCDFU_CDFUCUM_CODE_FK_PK", True))
        Me.lkupUnite_UCUM.Enabled = False
        Me.lkupUnite_UCUM.Location = New System.Drawing.Point(127, 91)
        Me.lkupUnite_UCUM.Name = "lkupUnite_UCUM"
        Me.lkupUnite_UCUM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupUnite_UCUM.Properties.NullText = ""
        Me.lkupUnite_UCUM.Size = New System.Drawing.Size(156, 20)
        Me.lkupUnite_UCUM.TabIndex = 46
        Me.lkupUnite_UCUM.Tag = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(51, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Unité UCUM"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CdfcdfU_CDFUTableAdapter1
        '
        Me.CdfcdfU_CDFUTableAdapter1.ClearBeforeFill = True
        '
        'Frm_CDF_PP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(625, 532)
        Me.Name = "Frm_CDF_PP"
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
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupCDFIUP_COEFVOL_CDF_CODE_FK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupCDFIUP_COEFDUR_CDF_NUM_FK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupCDFIUP_DONANTH_CDF_CODE_FK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCDFIUP_COEFDUR_CDF_NUM_FK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.lkupUnite_UCUM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents txtLibelle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents DsTheriaque1 As Theriaque.dsTheriaque
    Friend WithEvents CdF_CODIFTableAdapter As Theriaque.dsTheriaqueTableAdapters.CDF_CODIFTableAdapter
    Friend WithEvents SycdF_SYNCODIFTableAdapter As Theriaque.dsTheriaqueTableAdapters.SYCDF_SYNCODIFTableAdapter
    Friend WithEvents CdfiuP_INFO_UNITE_PRISETableAdapter As Theriaque.dsTheriaqueTableAdapters.CDFIUP_INFO_UNITE_PRISETableAdapter
    Friend WithEvents lkupCDFIUP_COEFVOL_CDF_CODE_FK As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkupCDFIUP_COEFDUR_CDF_NUM_FK As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkupCDFIUP_DONANTH_CDF_CODE_FK As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtCDFIUP_COEFDUR_CDF_NUM_FK As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DsTheriaque_Nomenclature21 As Theriaque.dsTheriaque_Nomenclature2
    Friend WithEvents CdF_CODIFTA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.CDF_CODIFTableAdapter
    Friend WithEvents lkupUnite_UCUM As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CdfcdfU_CDFUTableAdapter1 As Theriaque.dsTheriaque_Nomenclature2TableAdapters.CDFCDFU_CDFUTableAdapter

End Class
