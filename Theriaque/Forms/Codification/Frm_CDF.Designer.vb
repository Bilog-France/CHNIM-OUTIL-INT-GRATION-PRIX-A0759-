<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CDF
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
        Me.DsTheriaque1 = New Theriaque.dsTheriaque
        Me.txtLibelle = New DevExpress.XtraEditors.TextEdit
        Me.DsTheriaque_Nomenclature21 = New Theriaque.dsTheriaque_Nomenclature2
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.CdF_CODIFTableAdapter = New Theriaque.dsTheriaqueTableAdapters.CDF_CODIFTableAdapter
        Me.SycdF_SYNCODIFTableAdapter = New Theriaque.dsTheriaqueTableAdapters.SYCDF_SYNCODIFTableAdapter
        Me.txtNCodif = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.lkupCDF_CODE_PK = New DevExpress.XtraEditors.LookUpEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCodePere = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.PanPere = New System.Windows.Forms.Panel
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSYCDF_NOM_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSYCDF_CDF_NUMERO_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSYCDF_CDF_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtHiddenABRG = New DevExpress.XtraEditors.TextEdit
        Me.XtraTabPage_Liaison = New DevExpress.XtraTab.XtraTabPage
        Me.btADDLiaison = New DevExpress.XtraEditors.SimpleButton
        Me.GC2 = New DevExpress.XtraGrid.GridControl
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCDFPF_NUMEROP_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCDFPF_CODEP_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCDFPF_NUMEROF_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCDFPF_CODEF_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCDFPF_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCDFPF_CODEF_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpLiaison = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CdfpF_LIEN_CDF_PERE_FILS_2TableAdapter = New Theriaque.dsTheriaqueTableAdapters.CDFPF_LIEN_CDF_PERE_FILS_2TableAdapter
        Me.CdfpF_LIEN_CDF_PERE_FILSTableAdapter = New Theriaque.dsTheriaqueTableAdapters.CDFPF_LIEN_CDF_PERE_FILSTableAdapter
        Me.PanUnite = New System.Windows.Forms.Panel
        Me.lkupUnite = New DevExpress.XtraEditors.LookUpEdit
        Me.txtValeur = New DevExpress.XtraEditors.TextEdit
        Me.lbValeur = New System.Windows.Forms.Label
        Me.lbUnite = New System.Windows.Forms.Label
        Me.panAdrObserv = New System.Windows.Forms.Panel
        Me.txtAdrObserv = New DevExpress.XtraEditors.MemoEdit
        Me.lbAdresseObsv = New System.Windows.Forms.Label
        Me.CDFCODIFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CDFCODIFBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CdF_CODIFTA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.CDF_CODIFTableAdapter
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.PanUniteUCUM = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.lkupUnite_UCUM = New DevExpress.XtraEditors.LookUpEdit
        Me.CDFCDFUCDFUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CdfcdfU_CDFUTableAdapter1 = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.CDFCDFU_CDFUTableAdapter
        Me.lblDureeMaxPresc = New System.Windows.Forms.Label
        Me.txtDuree = New DevExpress.XtraEditors.TextEdit
        Me.panDureeMaxPresc = New System.Windows.Forms.Panel
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_Nomenclature21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNCodif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupCDF_CODE_PK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodePere.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanPere.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHiddenABRG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage_Liaison.SuspendLayout()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpLiaison, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanUnite.SuspendLayout()
        CType(Me.lkupUnite.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValeur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panAdrObserv.SuspendLayout()
        CType(Me.txtAdrObserv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CDFCODIFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CDFCODIFBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanUniteUCUM.SuspendLayout()
        CType(Me.lkupUnite_UCUM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CDFCDFUCDFUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDuree.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panDureeMaxPresc.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(636, 471)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.panDureeMaxPresc)
        Me.PanMain.Controls.Add(Me.PanUniteUCUM)
        Me.PanMain.Controls.Add(Me.Panel2)
        Me.PanMain.Controls.Add(Me.PanUnite)
        Me.PanMain.Controls.Add(Me.PanPere)
        Me.PanMain.Controls.Add(Me.Label2)
        Me.PanMain.Controls.Add(Me.txtNCodif)
        Me.PanMain.Controls.Add(Me.txtLibelle)
        Me.PanMain.Controls.Add(Me.Label6)
        Me.PanMain.Controls.Add(Me.txtCode)
        Me.PanMain.Controls.Add(Me.Label3)
        Me.PanMain.Size = New System.Drawing.Size(518, 384)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(636, 87)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(636, 28)
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
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(518, 87)
        Me.Panel1.Size = New System.Drawing.Size(118, 384)
        '
        'btAjouter
        '
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
        Me.GroupBox.Size = New System.Drawing.Size(636, 8)
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
        'txtLibelle
        '
        Me.txtLibelle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLibelle.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDF_CODIF.CDF_NOM", True))
        Me.txtLibelle.Location = New System.Drawing.Point(92, 100)
        Me.txtLibelle.Name = "txtLibelle"
        Me.txtLibelle.Size = New System.Drawing.Size(413, 20)
        Me.txtLibelle.TabIndex = 2
        Me.txtLibelle.Tag = "[EDIT][ADD]"
        '
        'DsTheriaque_Nomenclature21
        '
        Me.DsTheriaque_Nomenclature21.DataSetName = "dsTheriaque_Nomenclature2"
        Me.DsTheriaque_Nomenclature21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Libellé"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDF_CODIF.CDF_CODE_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(92, 76)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Tag = "[NOEDIT][ADD]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Code"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CdF_CODIFTableAdapter
        '
        Me.CdF_CODIFTableAdapter.ClearBeforeFill = True
        '
        'SycdF_SYNCODIFTableAdapter
        '
        Me.SycdF_SYNCODIFTableAdapter.ClearBeforeFill = True
        '
        'txtNCodif
        '
        Me.txtNCodif.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDF_CODIF.CDF_NUMERO_PK", True))
        Me.txtNCodif.Location = New System.Drawing.Point(92, 22)
        Me.txtNCodif.Name = "txtNCodif"
        Me.txtNCodif.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.txtNCodif.Properties.Appearance.Options.UseBackColor = True
        Me.txtNCodif.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNCodif.Properties.ReadOnly = True
        Me.txtNCodif.Size = New System.Drawing.Size(100, 20)
        Me.txtNCodif.TabIndex = 15
        Me.txtNCodif.TabStop = False
        Me.txtNCodif.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "N° Codif"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lkupCDF_CODE_PK
        '
        Me.lkupCDF_CODE_PK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkupCDF_CODE_PK.Enabled = False
        Me.lkupCDF_CODE_PK.Location = New System.Drawing.Point(229, 4)
        Me.lkupCDF_CODE_PK.Name = "lkupCDF_CODE_PK"
        Me.lkupCDF_CODE_PK.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.lkupCDF_CODE_PK.Properties.Appearance.Options.UseBackColor = True
        Me.lkupCDF_CODE_PK.Properties.NullText = ""
        Me.lkupCDF_CODE_PK.Properties.ReadOnly = True
        Me.lkupCDF_CODE_PK.Size = New System.Drawing.Size(264, 20)
        Me.lkupCDF_CODE_PK.TabIndex = 20
        Me.lkupCDF_CODE_PK.TabStop = False
        Me.lkupCDF_CODE_PK.Tag = ""
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
        'PanPere
        '
        Me.PanPere.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanPere.Controls.Add(Me.lkupCDF_CODE_PK)
        Me.PanPere.Controls.Add(Me.Label4)
        Me.PanPere.Controls.Add(Me.Label5)
        Me.PanPere.Controls.Add(Me.txtCodePere)
        Me.PanPere.Location = New System.Drawing.Point(12, 46)
        Me.PanPere.Name = "PanPere"
        Me.PanPere.Size = New System.Drawing.Size(503, 26)
        Me.PanPere.TabIndex = 22
        Me.PanPere.Visible = False
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(8, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(494, 120)
        Me.XtraTabControl1.TabIndex = 23
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage_Liaison})
        Me.XtraTabControl1.Tag = "[EDIT][ADD]"
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GC)
        Me.XtraTabPage1.Controls.Add(Me.txtHiddenABRG)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(485, 89)
        Me.XtraTabPage1.Tag = "[EDIT][NOADD]"
        Me.XtraTabPage1.Text = "Synonymes"
        '
        'GC
        '
        Me.GC.DataMember = "SYCDF_SYNCODIF"
        Me.GC.DataSource = Me.DsTheriaque1
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.GC.Location = New System.Drawing.Point(0, 0)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.Size = New System.Drawing.Size(485, 89)
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
        'txtHiddenABRG
        '
        Me.txtHiddenABRG.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CDF_CODIF.CDF_NOMABRG", True))
        Me.txtHiddenABRG.EditValue = ""
        Me.txtHiddenABRG.Location = New System.Drawing.Point(188, 136)
        Me.txtHiddenABRG.Name = "txtHiddenABRG"
        Me.txtHiddenABRG.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtHiddenABRG.Size = New System.Drawing.Size(100, 20)
        Me.txtHiddenABRG.TabIndex = 25
        Me.txtHiddenABRG.Tag = "[NOEDIT][ADD]"
        '
        'XtraTabPage_Liaison
        '
        Me.XtraTabPage_Liaison.Controls.Add(Me.btADDLiaison)
        Me.XtraTabPage_Liaison.Controls.Add(Me.GC2)
        Me.XtraTabPage_Liaison.Name = "XtraTabPage_Liaison"
        Me.XtraTabPage_Liaison.PageVisible = False
        Me.XtraTabPage_Liaison.Size = New System.Drawing.Size(485, 89)
        Me.XtraTabPage_Liaison.Text = "Liaisons"
        '
        'btADDLiaison
        '
        Me.btADDLiaison.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btADDLiaison.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btADDLiaison.Location = New System.Drawing.Point(161, -9745)
        Me.btADDLiaison.Name = "btADDLiaison"
        Me.btADDLiaison.Size = New System.Drawing.Size(63, 20)
        Me.btADDLiaison.TabIndex = 52
        Me.btADDLiaison.Tag = "[EDIT][ADD]"
        Me.btADDLiaison.Text = "..."
        '
        'GC2
        '
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
        Me.GC2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpLiaison})
        Me.GC2.Size = New System.Drawing.Size(485, 89)
        Me.GC2.TabIndex = 1
        Me.GC2.UseEmbeddedNavigator = True
        Me.GC2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCDFPF_NUMEROP_FK_PK, Me.colCDFPF_CODEP_FK_PK, Me.colCDFPF_NUMEROF_FK_PK, Me.colCDFPF_CODEF_FK_PK, Me.colCDFPF_NUMORD, Me.colCDFPF_CODEF_FK_PK2, Me.colCode})
        Me.GV2.GridControl = Me.GC2
        Me.GV2.GroupPanelText = " "
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV2.OptionsView.ShowGroupPanel = False
        '
        'colCDFPF_NUMEROP_FK_PK
        '
        Me.colCDFPF_NUMEROP_FK_PK.Caption = "CDFPF_NUMEROP_FK_PK"
        Me.colCDFPF_NUMEROP_FK_PK.FieldName = "CDFPF_NUMEROP_FK_PK"
        Me.colCDFPF_NUMEROP_FK_PK.Name = "colCDFPF_NUMEROP_FK_PK"
        Me.colCDFPF_NUMEROP_FK_PK.OptionsColumn.ReadOnly = True
        '
        'colCDFPF_CODEP_FK_PK
        '
        Me.colCDFPF_CODEP_FK_PK.Caption = "CDFPF_CODEP_FK_PK"
        Me.colCDFPF_CODEP_FK_PK.FieldName = "CDFPF_CODEP_FK_PK"
        Me.colCDFPF_CODEP_FK_PK.Name = "colCDFPF_CODEP_FK_PK"
        Me.colCDFPF_CODEP_FK_PK.OptionsColumn.ReadOnly = True
        '
        'colCDFPF_NUMEROF_FK_PK
        '
        Me.colCDFPF_NUMEROF_FK_PK.Caption = "CDFPF_NUMEROF_FK_PK"
        Me.colCDFPF_NUMEROF_FK_PK.FieldName = "CDFPF_NUMEROF_FK_PK"
        Me.colCDFPF_NUMEROF_FK_PK.Name = "colCDFPF_NUMEROF_FK_PK"
        Me.colCDFPF_NUMEROF_FK_PK.OptionsColumn.ReadOnly = True
        '
        'colCDFPF_CODEF_FK_PK
        '
        Me.colCDFPF_CODEF_FK_PK.Caption = "Code"
        Me.colCDFPF_CODEF_FK_PK.FieldName = "CDFPF_CODEF_FK_PK"
        Me.colCDFPF_CODEF_FK_PK.Name = "colCDFPF_CODEF_FK_PK"
        Me.colCDFPF_CODEF_FK_PK.OptionsColumn.ReadOnly = True
        Me.colCDFPF_CODEF_FK_PK.Visible = True
        Me.colCDFPF_CODEF_FK_PK.VisibleIndex = 0
        Me.colCDFPF_CODEF_FK_PK.Width = 93
        '
        'colCDFPF_NUMORD
        '
        Me.colCDFPF_NUMORD.Caption = "CDFPF_NUMORD"
        Me.colCDFPF_NUMORD.FieldName = "CDFPF_NUMORD"
        Me.colCDFPF_NUMORD.Name = "colCDFPF_NUMORD"
        Me.colCDFPF_NUMORD.OptionsColumn.ReadOnly = True
        '
        'colCDFPF_CODEF_FK_PK2
        '
        Me.colCDFPF_CODEF_FK_PK2.Caption = "Libellé"
        Me.colCDFPF_CODEF_FK_PK2.ColumnEdit = Me.rpLiaison
        Me.colCDFPF_CODEF_FK_PK2.FieldName = "code"
        Me.colCDFPF_CODEF_FK_PK2.Name = "colCDFPF_CODEF_FK_PK2"
        Me.colCDFPF_CODEF_FK_PK2.Visible = True
        Me.colCDFPF_CODEF_FK_PK2.VisibleIndex = 1
        Me.colCDFPF_CODEF_FK_PK2.Width = 368
        '
        'rpLiaison
        '
        Me.rpLiaison.AutoHeight = False
        Me.rpLiaison.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpLiaison.Name = "rpLiaison"
        Me.rpLiaison.NullText = ""
        '
        'colCode
        '
        Me.colCode.Caption = "Clé unique"
        Me.colCode.FieldName = "code"
        Me.colCode.Name = "colCode"
        Me.colCode.OptionsColumn.ReadOnly = True
        '
        'CdfpF_LIEN_CDF_PERE_FILS_2TableAdapter
        '
        Me.CdfpF_LIEN_CDF_PERE_FILS_2TableAdapter.ClearBeforeFill = True
        '
        'CdfpF_LIEN_CDF_PERE_FILSTableAdapter
        '
        Me.CdfpF_LIEN_CDF_PERE_FILSTableAdapter.ClearBeforeFill = True
        '
        'PanUnite
        '
        Me.PanUnite.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanUnite.Controls.Add(Me.lkupUnite)
        Me.PanUnite.Controls.Add(Me.txtValeur)
        Me.PanUnite.Controls.Add(Me.lbValeur)
        Me.PanUnite.Controls.Add(Me.lbUnite)
        Me.PanUnite.Location = New System.Drawing.Point(12, 126)
        Me.PanUnite.Name = "PanUnite"
        Me.PanUnite.Size = New System.Drawing.Size(503, 26)
        Me.PanUnite.TabIndex = 24
        Me.PanUnite.Visible = False
        '
        'lkupUnite
        '
        Me.lkupUnite.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDF_CODIF.CDF_UNIT_NUM", True))
        Me.lkupUnite.Location = New System.Drawing.Point(232, 3)
        Me.lkupUnite.Name = "lkupUnite"
        Me.lkupUnite.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupUnite.Size = New System.Drawing.Size(274, 20)
        Me.lkupUnite.TabIndex = 27
        Me.lkupUnite.Tag = ""
        '
        'txtValeur
        '
        Me.txtValeur.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDF_CODIF.CDF_VAL_NUM", True))
        Me.txtValeur.Location = New System.Drawing.Point(80, 3)
        Me.txtValeur.Name = "txtValeur"
        Me.txtValeur.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValeur.Size = New System.Drawing.Size(100, 20)
        Me.txtValeur.TabIndex = 22
        Me.txtValeur.Tag = "[EDIT][ADD]"
        '
        'lbValeur
        '
        Me.lbValeur.AutoSize = True
        Me.lbValeur.Location = New System.Drawing.Point(18, 7)
        Me.lbValeur.Name = "lbValeur"
        Me.lbValeur.Size = New System.Drawing.Size(37, 13)
        Me.lbValeur.TabIndex = 18
        Me.lbValeur.Text = "Valeur"
        Me.lbValeur.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbUnite
        '
        Me.lbUnite.AutoSize = True
        Me.lbUnite.Location = New System.Drawing.Point(194, 7)
        Me.lbUnite.Name = "lbUnite"
        Me.lbUnite.Size = New System.Drawing.Size(32, 13)
        Me.lbUnite.TabIndex = 21
        Me.lbUnite.Text = "Unité"
        Me.lbUnite.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'panAdrObserv
        '
        Me.panAdrObserv.Controls.Add(Me.txtAdrObserv)
        Me.panAdrObserv.Controls.Add(Me.lbAdresseObsv)
        Me.panAdrObserv.Location = New System.Drawing.Point(12, 6)
        Me.panAdrObserv.Name = "panAdrObserv"
        Me.panAdrObserv.Size = New System.Drawing.Size(518, 81)
        Me.panAdrObserv.TabIndex = 26
        Me.panAdrObserv.Visible = False
        '
        'txtAdrObserv
        '
        Me.txtAdrObserv.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDF_CODIF.CDF_TEXTE", True))
        Me.txtAdrObserv.Location = New System.Drawing.Point(9, 13)
        Me.txtAdrObserv.Name = "txtAdrObserv"
        Me.txtAdrObserv.Size = New System.Drawing.Size(494, 65)
        Me.txtAdrObserv.TabIndex = 19
        Me.txtAdrObserv.Tag = "[EDIT][ADD]"
        '
        'lbAdresseObsv
        '
        Me.lbAdresseObsv.AutoSize = True
        Me.lbAdresseObsv.Location = New System.Drawing.Point(6, -2)
        Me.lbAdresseObsv.Name = "lbAdresseObsv"
        Me.lbAdresseObsv.Size = New System.Drawing.Size(120, 13)
        Me.lbAdresseObsv.TabIndex = 18
        Me.lbAdresseObsv.Text = "Adresse et observations"
        Me.lbAdresseObsv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CDFCODIFBindingSource
        '
        Me.CDFCODIFBindingSource.DataMember = "CDF_CODIF"
        Me.CDFCODIFBindingSource.DataSource = Me.DsTheriaque1
        '
        'CDFCODIFBindingSource1
        '
        Me.CDFCODIFBindingSource1.DataMember = "CDF_CODIF"
        Me.CDFCODIFBindingSource1.DataSource = Me.DsTheriaque1
        '
        'CdF_CODIFTA
        '
        Me.CdF_CODIFTA.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 174)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(518, 210)
        Me.Panel2.TabIndex = 27
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.panAdrObserv)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 120)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(518, 90)
        Me.Panel4.TabIndex = 29
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.XtraTabControl1)
        Me.Panel3.Location = New System.Drawing.Point(12, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(506, 126)
        Me.Panel3.TabIndex = 28
        '
        'PanUniteUCUM
        '
        Me.PanUniteUCUM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanUniteUCUM.Controls.Add(Me.Label8)
        Me.PanUniteUCUM.Controls.Add(Me.lkupUnite_UCUM)
        Me.PanUniteUCUM.Location = New System.Drawing.Point(28, 125)
        Me.PanUniteUCUM.Name = "PanUniteUCUM"
        Me.PanUniteUCUM.Size = New System.Drawing.Size(222, 26)
        Me.PanUniteUCUM.TabIndex = 28
        Me.PanUniteUCUM.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Unité UCUM"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lkupUnite_UCUM
        '
        Me.lkupUnite_UCUM.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CDFCDFUCDFUBindingSource, "CDFCDFU_CDFUCUM_CODE_FK_PK", True))
        Me.lkupUnite_UCUM.Enabled = False
        Me.lkupUnite_UCUM.Location = New System.Drawing.Point(81, 4)
        Me.lkupUnite_UCUM.Name = "lkupUnite_UCUM"
        Me.lkupUnite_UCUM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupUnite_UCUM.Size = New System.Drawing.Size(138, 20)
        Me.lkupUnite_UCUM.TabIndex = 29
        Me.lkupUnite_UCUM.Tag = ""
        '
        'CDFCDFUCDFUBindingSource
        '
        Me.CDFCDFUCDFUBindingSource.DataMember = "CDFCDFU_CDFU"
        Me.CDFCDFUCDFUBindingSource.DataSource = Me.DsTheriaque_Nomenclature21
        '
        'CdfcdfU_CDFUTableAdapter1
        '
        Me.CdfcdfU_CDFUTableAdapter1.ClearBeforeFill = True
        '
        'lblDureeMaxPresc
        '
        Me.lblDureeMaxPresc.AutoSize = True
        Me.lblDureeMaxPresc.Location = New System.Drawing.Point(4, 8)
        Me.lblDureeMaxPresc.Name = "lblDureeMaxPresc"
        Me.lblDureeMaxPresc.Size = New System.Drawing.Size(146, 13)
        Me.lblDureeMaxPresc.TabIndex = 18
        Me.lblDureeMaxPresc.Text = "Durée max prescription (jours)"
        Me.lblDureeMaxPresc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDuree
        '
        Me.txtDuree.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature21, "CDF_CODIF.CDF_VAL_NUM", True))
        Me.txtDuree.Location = New System.Drawing.Point(164, 4)
        Me.txtDuree.Name = "txtDuree"
        Me.txtDuree.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDuree.Size = New System.Drawing.Size(105, 20)
        Me.txtDuree.TabIndex = 22
        Me.txtDuree.Tag = "[EDIT][ADD]"
        '
        'panDureeMaxPresc
        '
        Me.panDureeMaxPresc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panDureeMaxPresc.Controls.Add(Me.txtDuree)
        Me.panDureeMaxPresc.Controls.Add(Me.lblDureeMaxPresc)
        Me.panDureeMaxPresc.Location = New System.Drawing.Point(29, 123)
        Me.panDureeMaxPresc.Name = "panDureeMaxPresc"
        Me.panDureeMaxPresc.Size = New System.Drawing.Size(345, 26)
        Me.panDureeMaxPresc.TabIndex = 28
        Me.panDureeMaxPresc.Visible = False
        '
        'Frm_CDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(636, 471)
        Me.Name = "Frm_CDF"
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
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_Nomenclature21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNCodif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupCDF_CODE_PK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodePere.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanPere.ResumeLayout(False)
        Me.PanPere.PerformLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHiddenABRG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage_Liaison.ResumeLayout(False)
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpLiaison, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanUnite.ResumeLayout(False)
        Me.PanUnite.PerformLayout()
        CType(Me.lkupUnite.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValeur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panAdrObserv.ResumeLayout(False)
        Me.panAdrObserv.PerformLayout()
        CType(Me.txtAdrObserv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CDFCODIFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CDFCODIFBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.PanUniteUCUM.ResumeLayout(False)
        Me.PanUniteUCUM.PerformLayout()
        CType(Me.lkupUnite_UCUM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CDFCDFUCDFUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDuree.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panDureeMaxPresc.ResumeLayout(False)
        Me.panDureeMaxPresc.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtLibelle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CdF_CODIFTableAdapter As Theriaque.dsTheriaqueTableAdapters.CDF_CODIFTableAdapter
    Friend WithEvents DsTheriaque1 As Theriaque.dsTheriaque
    Friend WithEvents SycdF_SYNCODIFTableAdapter As Theriaque.dsTheriaqueTableAdapters.SYCDF_SYNCODIFTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNCodif As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lkupCDF_CODE_PK As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodePere As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PanPere As System.Windows.Forms.Panel
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage_Liaison As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSYCDF_NOM_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSYCDF_CDF_NUMERO_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSYCDF_CDF_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GC2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCDFPF_NUMEROP_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCDFPF_CODEP_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCDFPF_NUMEROF_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCDFPF_CODEF_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCDFPF_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CdfpF_LIEN_CDF_PERE_FILS_2TableAdapter As Theriaque.dsTheriaqueTableAdapters.CDFPF_LIEN_CDF_PERE_FILS_2TableAdapter
    Friend WithEvents CdfpF_LIEN_CDF_PERE_FILSTableAdapter As Theriaque.dsTheriaqueTableAdapters.CDFPF_LIEN_CDF_PERE_FILSTableAdapter
    Friend WithEvents colCDFPF_CODEF_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpLiaison As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btADDLiaison As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanUnite As System.Windows.Forms.Panel
    Friend WithEvents lbValeur As System.Windows.Forms.Label
    Friend WithEvents lbUnite As System.Windows.Forms.Label
    Friend WithEvents txtValeur As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtHiddenABRG As DevExpress.XtraEditors.TextEdit
    Friend WithEvents panAdrObserv As System.Windows.Forms.Panel
    Friend WithEvents lbAdresseObsv As System.Windows.Forms.Label
    Friend WithEvents CDFCODIFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtAdrObserv As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents CDFCODIFBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents lkupUnite As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DsTheriaque_Nomenclature21 As Theriaque.dsTheriaque_Nomenclature2
    Friend WithEvents CdF_CODIFTA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.CDF_CODIFTableAdapter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PanUniteUCUM As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lkupUnite_UCUM As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CDFCDFUCDFUBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CdfcdfU_CDFUTableAdapter1 As Theriaque.dsTheriaque_Nomenclature2TableAdapters.CDFCDFU_CDFUTableAdapter
    Friend WithEvents txtDuree As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDureeMaxPresc As System.Windows.Forms.Label
    Friend WithEvents panDureeMaxPresc As System.Windows.Forms.Panel

End Class
