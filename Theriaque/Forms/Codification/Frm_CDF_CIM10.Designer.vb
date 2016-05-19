<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_CDF_CIM10
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
        Me.PanPere = New System.Windows.Forms.Panel
        Me.lkupCDF_CODE_PK = New DevExpress.XtraEditors.LookUpEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCodePere = New DevExpress.XtraEditors.TextEdit
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
        Me.txtLibelle = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GC2 = New DevExpress.XtraGrid.GridControl
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCIMCDF_CIM_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpCIM10 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colCIMCDF_CDF_NUMERO_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCIMCDF_CDF_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCIMCDF_CIM_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CdF_CODIFTableAdapter = New Theriaque.dsTheriaqueTableAdapters.CDF_CODIFTableAdapter
        Me.SycdF_SYNCODIFTableAdapter = New Theriaque.dsTheriaqueTableAdapters.SYCDF_SYNCODIFTableAdapter
        Me.CimcdF_CIM10_CODIFTableAdapter = New Theriaque.dsTheriaqueTableAdapters.CIMCDF_CIM10_CODIFTableAdapter
        Me.CdF_CODIFTA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.CDF_CODIFTableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanPere.SuspendLayout()
        CType(Me.lkupCDF_CODE_PK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodePere.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNCodif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_Nomenclature21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpCIM10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.GroupBox2)
        Me.PanMain.Controls.Add(Me.PanPere)
        Me.PanMain.Controls.Add(Me.Label2)
        Me.PanMain.Controls.Add(Me.Label3)
        Me.PanMain.Controls.Add(Me.txtNCodif)
        Me.PanMain.Controls.Add(Me.txtCode)
        Me.PanMain.Controls.Add(Me.GroupBox1)
        Me.PanMain.Controls.Add(Me.Label6)
        Me.PanMain.Controls.Add(Me.txtLibelle)
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
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDF_CODIF.CDF_DATEMJ", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDF_CODIF.CDF_DATECR", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        '
        'PanPere
        '
        Me.PanPere.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanPere.Controls.Add(Me.lkupCDF_CODE_PK)
        Me.PanPere.Controls.Add(Me.Label4)
        Me.PanPere.Controls.Add(Me.Label5)
        Me.PanPere.Controls.Add(Me.txtCodePere)
        Me.PanPere.Location = New System.Drawing.Point(12, 52)
        Me.PanPere.Name = "PanPere"
        Me.PanPere.Size = New System.Drawing.Size(492, 26)
        Me.PanPere.TabIndex = 30
        Me.PanPere.Visible = False
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
        Me.lkupCDF_CODE_PK.Size = New System.Drawing.Size(253, 20)
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
        Me.Label2.Location = New System.Drawing.Point(40, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "N° Codif"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNCodif
        '
        Me.txtNCodif.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDF_CODIF.CDF_NUMERO_PK", True))
        Me.txtNCodif.Location = New System.Drawing.Point(92, 28)
        Me.txtNCodif.Name = "txtNCodif"
        Me.txtNCodif.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.txtNCodif.Properties.Appearance.Options.UseBackColor = True
        Me.txtNCodif.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNCodif.Properties.ReadOnly = True
        Me.txtNCodif.Size = New System.Drawing.Size(100, 20)
        Me.txtNCodif.TabIndex = 28
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GC)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(505, 193)
        Me.GroupBox1.TabIndex = 25
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
        Me.GC.Size = New System.Drawing.Size(488, 165)
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
        'txtLibelle
        '
        Me.txtLibelle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLibelle.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDF_CODIF.CDF_NOM", True))
        Me.txtLibelle.Location = New System.Drawing.Point(92, 106)
        Me.txtLibelle.Name = "txtLibelle"
        Me.txtLibelle.Size = New System.Drawing.Size(402, 20)
        Me.txtLibelle.TabIndex = 24
        Me.txtLibelle.Tag = "[EDIT][ADD]"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Libellé"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDF_CODIF.CDF_CODE_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(92, 80)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 23
        Me.txtCode.Tag = "[NOEDIT][ADD]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Code"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.GC2)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 332)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(506, 144)
        Me.GroupBox2.TabIndex = 31
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
        Me.GC2.Size = New System.Drawing.Size(489, 116)
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
        Me.rpCIM10.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
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
        'CdF_CODIFTA
        '
        Me.CdF_CODIFTA.ClearBeforeFill = True
        '
        'FRM_CDF_CIM10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(630, 566)
        Me.Name = "FRM_CDF_CIM10"
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
        Me.PanPere.ResumeLayout(False)
        Me.PanPere.PerformLayout()
        CType(Me.lkupCDF_CODE_PK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodePere.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNCodif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_Nomenclature21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpCIM10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanPere As System.Windows.Forms.Panel
    Friend WithEvents lkupCDF_CODE_PK As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodePere As DevExpress.XtraEditors.TextEdit
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GC2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsTheriaque1 As Theriaque.dsTheriaque
    Friend WithEvents CdF_CODIFTableAdapter As Theriaque.dsTheriaqueTableAdapters.CDF_CODIFTableAdapter
    Friend WithEvents SycdF_SYNCODIFTableAdapter As Theriaque.dsTheriaqueTableAdapters.SYCDF_SYNCODIFTableAdapter
    Friend WithEvents CimcdF_CIM10_CODIFTableAdapter As Theriaque.dsTheriaqueTableAdapters.CIMCDF_CIM10_CODIFTableAdapter
    Friend WithEvents colCIMCDF_CIM_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIMCDF_CDF_NUMERO_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIMCDF_CDF_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpCIM10 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colCIMCDF_CIM_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DsTheriaque_Nomenclature21 As Theriaque.dsTheriaque_Nomenclature2
    Friend WithEvents CdF_CODIFTA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.CDF_CODIFTableAdapter

End Class
