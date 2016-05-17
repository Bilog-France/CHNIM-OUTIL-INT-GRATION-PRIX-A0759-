<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Pharmacocinetique
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.DsTheriaque_Pharmacocinetique = New Theriaque.dsTheriaque_Pharmacocinetique
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.FphcO_TA = New Theriaque.dsTheriaque_PharmacocinetiqueTableAdapters.FPHCO_PHARMACOCINETIQUETableAdapter
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GC15 = New DevExpress.XtraGrid.GridControl
        Me.GV15 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFPHCOPR_FPHCO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPHCOPR_PR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPHCOPR_PR_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FPHCOPR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC16 = New DevExpress.XtraGrid.GridControl
        Me.GV16 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFPHCOSP_FPHCO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPHCOSP_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPHCOSP_SP_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FPHCOSP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GC13 = New DevExpress.XtraGrid.GridControl
        Me.GV13 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFPHCOSAC_FPHCO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPHCOSAC_SAC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPHCOSAC_SAC_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FPHCOSAC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC14 = New DevExpress.XtraGrid.GridControl
        Me.GV14 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFPHCOSAU_FPHCO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPHCOSAU_SAU_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPHCOSAU_SAU_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FPHCOSAU = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.GC11 = New DevExpress.XtraGrid.GridControl
        Me.GV11 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFPHCOCPH_FPHCO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPHCOCPH_CPH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPHCOCPH_CPH_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FPHCOCPH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC12 = New DevExpress.XtraGrid.GridControl
        Me.GV12 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFPHCOCCH_FPHCO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPHCOCCH_CCH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPHCOCCH_CCH_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FPHCOCCH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.MemoEdit3 = New DevExpress.XtraEditors.MemoEdit
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.GC23 = New DevExpress.XtraGrid.GridControl
        Me.GV23 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFPHCOAFS_FPHCO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPHCOAFS_DATE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPHCOAFS_CDF_DOCUMENT_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FPHCOAFS = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFPHCOAFS_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_AFS = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.GC21 = New DevExpress.XtraGrid.GridControl
        Me.GV21 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFPHCOCOM_FPHCO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPHCOCOM_CDF_COM_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPHCOCOM_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FPHCOCOM = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.FphcocpH_TA = New Theriaque.dsTheriaque_PharmacocinetiqueTableAdapters.FPHCOCPH_FPHCO_CLPHTableAdapter
        Me.FphcoccH_TA = New Theriaque.dsTheriaque_PharmacocinetiqueTableAdapters.FPHCOCCH_FPHCO_CLCHTableAdapter
        Me.FphcosaC_TA = New Theriaque.dsTheriaque_PharmacocinetiqueTableAdapters.FPHCOSAC_FPHCO_SUBACTTableAdapter
        Me.FphcosaU_TA = New Theriaque.dsTheriaque_PharmacocinetiqueTableAdapters.FPHCOSAU_FPHCO_SUBAUXTableAdapter
        Me.FphcopR_TA = New Theriaque.dsTheriaque_PharmacocinetiqueTableAdapters.FPHCOPR_FPHCO_PRODTableAdapter
        Me.FphcosP_TA = New Theriaque.dsTheriaque_PharmacocinetiqueTableAdapters.FPHCOSP_PHARMACOCIN_SPECTableAdapter
        Me.FphcocoM_TA = New Theriaque.dsTheriaque_PharmacocinetiqueTableAdapters.FPHCOCOM_FPHCO_COMTableAdapter
        Me.FphcoafS_TA = New Theriaque.dsTheriaque_PharmacocinetiqueTableAdapters.FPHCOAFS_FPHCO_AFSSAPSTableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_Pharmacocinetique, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GC15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FPHCOPR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FPHCOSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.GC13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FPHCOSAC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FPHCOSAU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.GC11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FPHCOCPH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FPHCOCCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.MemoEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.GC23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FPHCOAFS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_AFS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.GC21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FPHCOCOM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(780, 574)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.XtraTabControl1)
        Me.PanMain.Controls.Add(Me.GroupBox1)
        Me.PanMain.Size = New System.Drawing.Size(662, 487)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(780, 87)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(780, 28)
        Me.Label1.Text = "Pharmacocinétique"
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
        Me.Panel1.Location = New System.Drawing.Point(662, 87)
        Me.Panel1.Size = New System.Drawing.Size(118, 487)
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Pharmacocinetique, "FPHCO_PHARMACOCINETIQUE.FPHCO_DATEMJ", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Size = New System.Drawing.Size(780, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Pharmacocinetique, "FPHCO_PHARMACOCINETIQUE.FPHCO_DATECR", True))
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
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(662, 42)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Pharmacocinetique, "FPHCO_PHARMACOCINETIQUE.FPHCO_CODE_SQ_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(88, 13)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(135, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Tag = "[NOEDIT][NOADD]"
        '
        'DsTheriaque_Pharmacocinetique
        '
        Me.DsTheriaque_Pharmacocinetique.DataSetName = "dsTheriaque_Pharmacocinetique"
        Me.DsTheriaque_Pharmacocinetique.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(42, 17)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Fiche N°"
        '
        'FphcO_TA
        '
        Me.FphcO_TA.ClearBeforeFill = True
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Location = New System.Drawing.Point(3, 48)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(658, 436)
        Me.XtraTabControl1.TabIndex = 8
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panel3)
        Me.XtraTabPage1.Controls.Add(Me.Panel2)
        Me.XtraTabPage1.Controls.Add(Me.Panel5)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(649, 405)
        Me.XtraTabPage1.Text = "Entités"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GC15)
        Me.Panel3.Controls.Add(Me.GC16)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 274)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(649, 131)
        Me.Panel3.TabIndex = 20
        '
        'GC15
        '
        Me.GC15.DataMember = "FPHCOPR_FPHCO_PROD"
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
        Me.GC15.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FPHCOPR})
        Me.GC15.Size = New System.Drawing.Size(346, 131)
        Me.GC15.TabIndex = 2
        Me.GC15.Tag = "[EDIT][ADD]"
        Me.GC15.UseEmbeddedNavigator = True
        Me.GC15.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV15})
        '
        'GV15
        '
        Me.GV15.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFPHCOPR_FPHCO_CODE_FK_PK, Me.colFPHCOPR_PR_CODE_FK_PK, Me.colFPHCOPR_PR_CODE_FK_PK2})
        Me.GV15.GridControl = Me.GC15
        Me.GV15.Name = "GV15"
        Me.GV15.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV15.OptionsView.ShowGroupPanel = False
        '
        'colFPHCOPR_FPHCO_CODE_FK_PK
        '
        Me.colFPHCOPR_FPHCO_CODE_FK_PK.Caption = "FPHCOPR_FPHCO_CODE_FK_PK"
        Me.colFPHCOPR_FPHCO_CODE_FK_PK.FieldName = "FPHCOPR_FPHCO_CODE_FK_PK"
        Me.colFPHCOPR_FPHCO_CODE_FK_PK.Name = "colFPHCOPR_FPHCO_CODE_FK_PK"
        '
        'colFPHCOPR_PR_CODE_FK_PK
        '
        Me.colFPHCOPR_PR_CODE_FK_PK.Caption = "Code"
        Me.colFPHCOPR_PR_CODE_FK_PK.FieldName = "FPHCOPR_PR_CODE_FK_PK"
        Me.colFPHCOPR_PR_CODE_FK_PK.Name = "colFPHCOPR_PR_CODE_FK_PK"
        Me.colFPHCOPR_PR_CODE_FK_PK.Visible = True
        Me.colFPHCOPR_PR_CODE_FK_PK.VisibleIndex = 0
        Me.colFPHCOPR_PR_CODE_FK_PK.Width = 50
        '
        'colFPHCOPR_PR_CODE_FK_PK2
        '
        Me.colFPHCOPR_PR_CODE_FK_PK2.Caption = "Produit"
        Me.colFPHCOPR_PR_CODE_FK_PK2.ColumnEdit = Me.lkup_FPHCOPR
        Me.colFPHCOPR_PR_CODE_FK_PK2.FieldName = "FPHCOPR_PR_CODE_FK_PK"
        Me.colFPHCOPR_PR_CODE_FK_PK2.Name = "colFPHCOPR_PR_CODE_FK_PK2"
        Me.colFPHCOPR_PR_CODE_FK_PK2.Visible = True
        Me.colFPHCOPR_PR_CODE_FK_PK2.VisibleIndex = 1
        Me.colFPHCOPR_PR_CODE_FK_PK2.Width = 275
        '
        'lkup_FPHCOPR
        '
        Me.lkup_FPHCOPR.AutoHeight = False
        Me.lkup_FPHCOPR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FPHCOPR.Name = "lkup_FPHCOPR"
        '
        'GC16
        '
        Me.GC16.DataMember = "FPHCOSP_PHARMACOCIN_SPEC"
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
        Me.GC16.Location = New System.Drawing.Point(346, 0)
        Me.GC16.MainView = Me.GV16
        Me.GC16.Name = "GC16"
        Me.GC16.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FPHCOSP})
        Me.GC16.Size = New System.Drawing.Size(303, 131)
        Me.GC16.TabIndex = 3
        Me.GC16.Tag = "[EDIT][ADD]"
        Me.GC16.UseEmbeddedNavigator = True
        Me.GC16.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV16})
        '
        'GV16
        '
        Me.GV16.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFPHCOSP_FPHCO_CODE_FK_PK, Me.colFPHCOSP_SP_CODE_FK_PK, Me.colFPHCOSP_SP_CODE_FK_PK2})
        Me.GV16.GridControl = Me.GC16
        Me.GV16.Name = "GV16"
        Me.GV16.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV16.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV16.OptionsView.ShowGroupPanel = False
        '
        'colFPHCOSP_FPHCO_CODE_FK_PK
        '
        Me.colFPHCOSP_FPHCO_CODE_FK_PK.Caption = "FPHCOSP_FPHCO_CODE_FK_PK"
        Me.colFPHCOSP_FPHCO_CODE_FK_PK.FieldName = "FPHCOSP_FPHCO_CODE_FK_PK"
        Me.colFPHCOSP_FPHCO_CODE_FK_PK.Name = "colFPHCOSP_FPHCO_CODE_FK_PK"
        '
        'colFPHCOSP_SP_CODE_FK_PK
        '
        Me.colFPHCOSP_SP_CODE_FK_PK.Caption = "Code"
        Me.colFPHCOSP_SP_CODE_FK_PK.FieldName = "FPHCOSP_SP_CODE_FK_PK"
        Me.colFPHCOSP_SP_CODE_FK_PK.Name = "colFPHCOSP_SP_CODE_FK_PK"
        Me.colFPHCOSP_SP_CODE_FK_PK.Visible = True
        Me.colFPHCOSP_SP_CODE_FK_PK.VisibleIndex = 0
        Me.colFPHCOSP_SP_CODE_FK_PK.Width = 50
        '
        'colFPHCOSP_SP_CODE_FK_PK2
        '
        Me.colFPHCOSP_SP_CODE_FK_PK2.Caption = "Spécialités"
        Me.colFPHCOSP_SP_CODE_FK_PK2.ColumnEdit = Me.lkup_FPHCOSP
        Me.colFPHCOSP_SP_CODE_FK_PK2.FieldName = "FPHCOSP_SP_CODE_FK_PK"
        Me.colFPHCOSP_SP_CODE_FK_PK2.Name = "colFPHCOSP_SP_CODE_FK_PK2"
        Me.colFPHCOSP_SP_CODE_FK_PK2.Visible = True
        Me.colFPHCOSP_SP_CODE_FK_PK2.VisibleIndex = 1
        Me.colFPHCOSP_SP_CODE_FK_PK2.Width = 232
        '
        'lkup_FPHCOSP
        '
        Me.lkup_FPHCOSP.AutoHeight = False
        Me.lkup_FPHCOSP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FPHCOSP.Name = "lkup_FPHCOSP"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GC13)
        Me.Panel2.Controls.Add(Me.GC14)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 137)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(649, 137)
        Me.Panel2.TabIndex = 19
        '
        'GC13
        '
        Me.GC13.DataMember = "FPHCOSAC_FPHCO_SUBACT"
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
        Me.GC13.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FPHCOSAC})
        Me.GC13.Size = New System.Drawing.Size(346, 137)
        Me.GC13.TabIndex = 2
        Me.GC13.Tag = "[EDIT][ADD]"
        Me.GC13.UseEmbeddedNavigator = True
        Me.GC13.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV13})
        '
        'GV13
        '
        Me.GV13.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFPHCOSAC_FPHCO_CODE_FK_PK, Me.colFPHCOSAC_SAC_CODE_FK_PK, Me.colFPHCOSAC_SAC_CODE_FK_PK2})
        Me.GV13.GridControl = Me.GC13
        Me.GV13.Name = "GV13"
        Me.GV13.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV13.OptionsView.ShowGroupPanel = False
        '
        'colFPHCOSAC_FPHCO_CODE_FK_PK
        '
        Me.colFPHCOSAC_FPHCO_CODE_FK_PK.Caption = "FPHCOSAC_FPHCO_CODE_FK_PK"
        Me.colFPHCOSAC_FPHCO_CODE_FK_PK.FieldName = "FPHCOSAC_FPHCO_CODE_FK_PK"
        Me.colFPHCOSAC_FPHCO_CODE_FK_PK.Name = "colFPHCOSAC_FPHCO_CODE_FK_PK"
        '
        'colFPHCOSAC_SAC_CODE_FK_PK
        '
        Me.colFPHCOSAC_SAC_CODE_FK_PK.Caption = "Code"
        Me.colFPHCOSAC_SAC_CODE_FK_PK.FieldName = "FPHCOSAC_SAC_CODE_FK_PK"
        Me.colFPHCOSAC_SAC_CODE_FK_PK.Name = "colFPHCOSAC_SAC_CODE_FK_PK"
        Me.colFPHCOSAC_SAC_CODE_FK_PK.Visible = True
        Me.colFPHCOSAC_SAC_CODE_FK_PK.VisibleIndex = 0
        Me.colFPHCOSAC_SAC_CODE_FK_PK.Width = 50
        '
        'colFPHCOSAC_SAC_CODE_FK_PK2
        '
        Me.colFPHCOSAC_SAC_CODE_FK_PK2.Caption = "Substance active"
        Me.colFPHCOSAC_SAC_CODE_FK_PK2.ColumnEdit = Me.lkup_FPHCOSAC
        Me.colFPHCOSAC_SAC_CODE_FK_PK2.FieldName = "FPHCOSAC_SAC_CODE_FK_PK"
        Me.colFPHCOSAC_SAC_CODE_FK_PK2.Name = "colFPHCOSAC_SAC_CODE_FK_PK2"
        Me.colFPHCOSAC_SAC_CODE_FK_PK2.Visible = True
        Me.colFPHCOSAC_SAC_CODE_FK_PK2.VisibleIndex = 1
        Me.colFPHCOSAC_SAC_CODE_FK_PK2.Width = 275
        '
        'lkup_FPHCOSAC
        '
        Me.lkup_FPHCOSAC.AutoHeight = False
        Me.lkup_FPHCOSAC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FPHCOSAC.Name = "lkup_FPHCOSAC"
        '
        'GC14
        '
        Me.GC14.DataMember = "FPHCOSAU_FPHCO_SUBAUX"
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
        Me.GC14.Location = New System.Drawing.Point(346, 0)
        Me.GC14.MainView = Me.GV14
        Me.GC14.Name = "GC14"
        Me.GC14.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FPHCOSAU})
        Me.GC14.Size = New System.Drawing.Size(303, 137)
        Me.GC14.TabIndex = 3
        Me.GC14.Tag = "[EDIT][ADD]"
        Me.GC14.UseEmbeddedNavigator = True
        Me.GC14.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV14})
        '
        'GV14
        '
        Me.GV14.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFPHCOSAU_FPHCO_CODE_FK_PK, Me.colFPHCOSAU_SAU_CODE_FK_PK, Me.colFPHCOSAU_SAU_CODE_FK_PK2})
        Me.GV14.GridControl = Me.GC14
        Me.GV14.Name = "GV14"
        Me.GV14.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV14.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV14.OptionsView.ShowGroupPanel = False
        '
        'colFPHCOSAU_FPHCO_CODE_FK_PK
        '
        Me.colFPHCOSAU_FPHCO_CODE_FK_PK.Caption = "FPHCOSAU_FPHCO_CODE_FK_PK"
        Me.colFPHCOSAU_FPHCO_CODE_FK_PK.FieldName = "FPHCOSAU_FPHCO_CODE_FK_PK"
        Me.colFPHCOSAU_FPHCO_CODE_FK_PK.Name = "colFPHCOSAU_FPHCO_CODE_FK_PK"
        '
        'colFPHCOSAU_SAU_CODE_FK_PK
        '
        Me.colFPHCOSAU_SAU_CODE_FK_PK.Caption = "Code"
        Me.colFPHCOSAU_SAU_CODE_FK_PK.FieldName = "FPHCOSAU_SAU_CODE_FK_PK"
        Me.colFPHCOSAU_SAU_CODE_FK_PK.Name = "colFPHCOSAU_SAU_CODE_FK_PK"
        Me.colFPHCOSAU_SAU_CODE_FK_PK.Visible = True
        Me.colFPHCOSAU_SAU_CODE_FK_PK.VisibleIndex = 0
        Me.colFPHCOSAU_SAU_CODE_FK_PK.Width = 50
        '
        'colFPHCOSAU_SAU_CODE_FK_PK2
        '
        Me.colFPHCOSAU_SAU_CODE_FK_PK2.Caption = "Excipient"
        Me.colFPHCOSAU_SAU_CODE_FK_PK2.ColumnEdit = Me.lkup_FPHCOSAU
        Me.colFPHCOSAU_SAU_CODE_FK_PK2.FieldName = "FPHCOSAU_SAU_CODE_FK_PK"
        Me.colFPHCOSAU_SAU_CODE_FK_PK2.Name = "colFPHCOSAU_SAU_CODE_FK_PK2"
        Me.colFPHCOSAU_SAU_CODE_FK_PK2.Visible = True
        Me.colFPHCOSAU_SAU_CODE_FK_PK2.VisibleIndex = 1
        Me.colFPHCOSAU_SAU_CODE_FK_PK2.Width = 232
        '
        'lkup_FPHCOSAU
        '
        Me.lkup_FPHCOSAU.AutoHeight = False
        Me.lkup_FPHCOSAU.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FPHCOSAU.Name = "lkup_FPHCOSAU"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GC11)
        Me.Panel5.Controls.Add(Me.GC12)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(649, 137)
        Me.Panel5.TabIndex = 18
        '
        'GC11
        '
        Me.GC11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC11.DataMember = "FPHCOCPH_FPHCO_CLPH"
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
        Me.GC11.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FPHCOCPH})
        Me.GC11.Size = New System.Drawing.Size(346, 137)
        Me.GC11.TabIndex = 2
        Me.GC11.Tag = "[EDIT][ADD]"
        Me.GC11.UseEmbeddedNavigator = True
        Me.GC11.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV11})
        '
        'GV11
        '
        Me.GV11.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFPHCOCPH_FPHCO_CODE_FK_PK, Me.colFPHCOCPH_CPH_CODE_FK_PK, Me.colFPHCOCPH_CPH_CODE_FK_PK2})
        Me.GV11.GridControl = Me.GC11
        Me.GV11.Name = "GV11"
        Me.GV11.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV11.OptionsView.ShowGroupPanel = False
        '
        'colFPHCOCPH_FPHCO_CODE_FK_PK
        '
        Me.colFPHCOCPH_FPHCO_CODE_FK_PK.Caption = "FPHCOCPH_FPHCO_CODE_FK_PK"
        Me.colFPHCOCPH_FPHCO_CODE_FK_PK.FieldName = "FPHCOCPH_FPHCO_CODE_FK_PK"
        Me.colFPHCOCPH_FPHCO_CODE_FK_PK.Name = "colFPHCOCPH_FPHCO_CODE_FK_PK"
        '
        'colFPHCOCPH_CPH_CODE_FK_PK
        '
        Me.colFPHCOCPH_CPH_CODE_FK_PK.Caption = "Code"
        Me.colFPHCOCPH_CPH_CODE_FK_PK.FieldName = "FPHCOCPH_CPH_CODE_FK_PK"
        Me.colFPHCOCPH_CPH_CODE_FK_PK.Name = "colFPHCOCPH_CPH_CODE_FK_PK"
        Me.colFPHCOCPH_CPH_CODE_FK_PK.Visible = True
        Me.colFPHCOCPH_CPH_CODE_FK_PK.VisibleIndex = 0
        Me.colFPHCOCPH_CPH_CODE_FK_PK.Width = 50
        '
        'colFPHCOCPH_CPH_CODE_FK_PK2
        '
        Me.colFPHCOCPH_CPH_CODE_FK_PK2.Caption = "Classe pharmaco-thérapeutique"
        Me.colFPHCOCPH_CPH_CODE_FK_PK2.ColumnEdit = Me.lkup_FPHCOCPH
        Me.colFPHCOCPH_CPH_CODE_FK_PK2.FieldName = "FPHCOCPH_CPH_CODE_FK_PK"
        Me.colFPHCOCPH_CPH_CODE_FK_PK2.Name = "colFPHCOCPH_CPH_CODE_FK_PK2"
        Me.colFPHCOCPH_CPH_CODE_FK_PK2.Visible = True
        Me.colFPHCOCPH_CPH_CODE_FK_PK2.VisibleIndex = 1
        Me.colFPHCOCPH_CPH_CODE_FK_PK2.Width = 275
        '
        'lkup_FPHCOCPH
        '
        Me.lkup_FPHCOCPH.AutoHeight = False
        Me.lkup_FPHCOCPH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FPHCOCPH.Name = "lkup_FPHCOCPH"
        '
        'GC12
        '
        Me.GC12.DataMember = "FPHCOCCH_FPHCO_CLCH"
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
        Me.GC12.Location = New System.Drawing.Point(346, 0)
        Me.GC12.MainView = Me.GV12
        Me.GC12.Name = "GC12"
        Me.GC12.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FPHCOCCH})
        Me.GC12.Size = New System.Drawing.Size(303, 137)
        Me.GC12.TabIndex = 3
        Me.GC12.Tag = "[EDIT][ADD]"
        Me.GC12.UseEmbeddedNavigator = True
        Me.GC12.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV12})
        '
        'GV12
        '
        Me.GV12.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFPHCOCCH_FPHCO_CODE_FK_PK, Me.colFPHCOCCH_CCH_CODE_FK_PK, Me.colFPHCOCCH_CCH_CODE_FK_PK2})
        Me.GV12.GridControl = Me.GC12
        Me.GV12.Name = "GV12"
        Me.GV12.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV12.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV12.OptionsView.ShowGroupPanel = False
        '
        'colFPHCOCCH_FPHCO_CODE_FK_PK
        '
        Me.colFPHCOCCH_FPHCO_CODE_FK_PK.Caption = "FPHCOCCH_FPHCO_CODE_FK_PK"
        Me.colFPHCOCCH_FPHCO_CODE_FK_PK.FieldName = "FPHCOCCH_FPHCO_CODE_FK_PK"
        Me.colFPHCOCCH_FPHCO_CODE_FK_PK.Name = "colFPHCOCCH_FPHCO_CODE_FK_PK"
        '
        'colFPHCOCCH_CCH_CODE_FK_PK
        '
        Me.colFPHCOCCH_CCH_CODE_FK_PK.Caption = "Code"
        Me.colFPHCOCCH_CCH_CODE_FK_PK.FieldName = "FPHCOCCH_CCH_CODE_FK_PK"
        Me.colFPHCOCCH_CCH_CODE_FK_PK.Name = "colFPHCOCCH_CCH_CODE_FK_PK"
        Me.colFPHCOCCH_CCH_CODE_FK_PK.Visible = True
        Me.colFPHCOCCH_CCH_CODE_FK_PK.VisibleIndex = 0
        Me.colFPHCOCCH_CCH_CODE_FK_PK.Width = 50
        '
        'colFPHCOCCH_CCH_CODE_FK_PK2
        '
        Me.colFPHCOCCH_CCH_CODE_FK_PK2.Caption = "Classe chimique"
        Me.colFPHCOCCH_CCH_CODE_FK_PK2.ColumnEdit = Me.lkup_FPHCOCCH
        Me.colFPHCOCCH_CCH_CODE_FK_PK2.FieldName = "FPHCOCCH_CCH_CODE_FK_PK"
        Me.colFPHCOCCH_CCH_CODE_FK_PK2.Name = "colFPHCOCCH_CCH_CODE_FK_PK2"
        Me.colFPHCOCCH_CCH_CODE_FK_PK2.Visible = True
        Me.colFPHCOCCH_CCH_CODE_FK_PK2.VisibleIndex = 1
        Me.colFPHCOCCH_CCH_CODE_FK_PK2.Width = 232
        '
        'lkup_FPHCOCCH
        '
        Me.lkup_FPHCOCCH.AutoHeight = False
        Me.lkup_FPHCOCCH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FPHCOCCH.Name = "lkup_FPHCOCCH"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Panel6)
        Me.XtraTabPage2.Controls.Add(Me.Panel7)
        Me.XtraTabPage2.Controls.Add(Me.Panel4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(499, 397)
        Me.XtraTabPage2.Text = "Réf.officielles / Commentaires"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel10)
        Me.Panel6.Controls.Add(Me.Panel11)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 226)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(499, 171)
        Me.Panel6.TabIndex = 40
        Me.Panel6.Tag = ""
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.MemoEdit3)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(0, 24)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(499, 147)
        Me.Panel10.TabIndex = 38
        Me.Panel10.Tag = "[ADD][EDIT]"
        '
        'MemoEdit3
        '
        Me.MemoEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Pharmacocinetique, "FPHCO_PHARMACOCINETIQUE.FPHCO_TXT", True))
        Me.MemoEdit3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoEdit3.Location = New System.Drawing.Point(0, 0)
        Me.MemoEdit3.Name = "MemoEdit3"
        Me.MemoEdit3.Size = New System.Drawing.Size(499, 147)
        Me.MemoEdit3.TabIndex = 36
        Me.MemoEdit3.Tag = ""
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.LabelControl7)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(499, 24)
        Me.Panel11.TabIndex = 37
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(2, 8)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl7.TabIndex = 19
        Me.LabelControl7.Text = "Texte"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.GC23)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 112)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(499, 114)
        Me.Panel7.TabIndex = 25
        '
        'GC23
        '
        Me.GC23.DataMember = "FPHCOAFS_FPHCO_AFSSAPS"
        Me.GC23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC23.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC23.EmbeddedNavigator.Name = ""
        Me.GC23.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC23.Location = New System.Drawing.Point(0, 0)
        Me.GC23.MainView = Me.GV23
        Me.GC23.Name = "GC23"
        Me.GC23.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FPHCOAFS, Me.lkup_AFS})
        Me.GC23.Size = New System.Drawing.Size(499, 114)
        Me.GC23.TabIndex = 22
        Me.GC23.Tag = "[EDIT][ADD]"
        Me.GC23.UseEmbeddedNavigator = True
        Me.GC23.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV23})
        '
        'GV23
        '
        Me.GV23.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFPHCOAFS_FPHCO_CODE_FK_PK, Me.colFPHCOAFS_DATE_PK, Me.colFPHCOAFS_CDF_DOCUMENT_FK_PK, Me.colFPHCOAFS_SP_CODE_FK_PK})
        Me.GV23.GridControl = Me.GC23
        Me.GV23.Name = "GV23"
        Me.GV23.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV23.OptionsView.ShowGroupPanel = False
        '
        'colFPHCOAFS_FPHCO_CODE_FK_PK
        '
        Me.colFPHCOAFS_FPHCO_CODE_FK_PK.Caption = "FPHCOAFS_FPHCO_CODE_FK_PK"
        Me.colFPHCOAFS_FPHCO_CODE_FK_PK.FieldName = "FPHCOAFS_FPHCO_CODE_FK_PK"
        Me.colFPHCOAFS_FPHCO_CODE_FK_PK.Name = "colFPHCOAFS_FPHCO_CODE_FK_PK"
        '
        'colFPHCOAFS_DATE_PK
        '
        Me.colFPHCOAFS_DATE_PK.Caption = "Date"
        Me.colFPHCOAFS_DATE_PK.FieldName = "FPHCOAFS_DATE_PK"
        Me.colFPHCOAFS_DATE_PK.Name = "colFPHCOAFS_DATE_PK"
        Me.colFPHCOAFS_DATE_PK.Visible = True
        Me.colFPHCOAFS_DATE_PK.VisibleIndex = 1
        Me.colFPHCOAFS_DATE_PK.Width = 85
        '
        'colFPHCOAFS_CDF_DOCUMENT_FK_PK
        '
        Me.colFPHCOAFS_CDF_DOCUMENT_FK_PK.Caption = "Références officielles"
        Me.colFPHCOAFS_CDF_DOCUMENT_FK_PK.ColumnEdit = Me.lkup_FPHCOAFS
        Me.colFPHCOAFS_CDF_DOCUMENT_FK_PK.FieldName = "FPHCOAFS_CDF_DOCUMENT_FK_PK"
        Me.colFPHCOAFS_CDF_DOCUMENT_FK_PK.Name = "colFPHCOAFS_CDF_DOCUMENT_FK_PK"
        Me.colFPHCOAFS_CDF_DOCUMENT_FK_PK.Visible = True
        Me.colFPHCOAFS_CDF_DOCUMENT_FK_PK.VisibleIndex = 0
        Me.colFPHCOAFS_CDF_DOCUMENT_FK_PK.Width = 184
        '
        'lkup_FPHCOAFS
        '
        Me.lkup_FPHCOAFS.AutoHeight = False
        Me.lkup_FPHCOAFS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FPHCOAFS.Name = "lkup_FPHCOAFS"
        '
        'colFPHCOAFS_SP_CODE_FK_PK
        '
        Me.colFPHCOAFS_SP_CODE_FK_PK.Caption = "Spécialités"
        Me.colFPHCOAFS_SP_CODE_FK_PK.ColumnEdit = Me.lkup_AFS
        Me.colFPHCOAFS_SP_CODE_FK_PK.FieldName = "FPHCOAFS_SP_CODE_FK_PK"
        Me.colFPHCOAFS_SP_CODE_FK_PK.Name = "colFPHCOAFS_SP_CODE_FK_PK"
        Me.colFPHCOAFS_SP_CODE_FK_PK.Visible = True
        Me.colFPHCOAFS_SP_CODE_FK_PK.VisibleIndex = 2
        Me.colFPHCOAFS_SP_CODE_FK_PK.Width = 213
        '
        'lkup_AFS
        '
        Me.lkup_AFS.AutoHeight = False
        Me.lkup_AFS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_AFS.Name = "lkup_AFS"
        Me.lkup_AFS.NullText = ""
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GC21)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(499, 112)
        Me.Panel4.TabIndex = 23
        '
        'GC21
        '
        Me.GC21.DataMember = "FPHCOCOM_FPHCO_COM"
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
        Me.GC21.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FPHCOCOM})
        Me.GC21.Size = New System.Drawing.Size(499, 112)
        Me.GC21.TabIndex = 3
        Me.GC21.Tag = "[EDIT][ADD]"
        Me.GC21.UseEmbeddedNavigator = True
        Me.GC21.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV21})
        '
        'GV21
        '
        Me.GV21.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFPHCOCOM_FPHCO_CODE_FK_PK, Me.colFPHCOCOM_CDF_COM_CODE_FK_PK, Me.colFPHCOCOM_NUMORD, Me.GridColumn7})
        Me.GV21.GridControl = Me.GC21
        Me.GV21.Name = "GV21"
        Me.GV21.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV21.OptionsView.ShowGroupPanel = False
        Me.GV21.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFPHCOCOM_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFPHCOCOM_FPHCO_CODE_FK_PK
        '
        Me.colFPHCOCOM_FPHCO_CODE_FK_PK.Caption = "FPHCOCOM_FPHCO_CODE_FK_PK"
        Me.colFPHCOCOM_FPHCO_CODE_FK_PK.FieldName = "FPHCOCOM_FPHCO_CODE_FK_PK"
        Me.colFPHCOCOM_FPHCO_CODE_FK_PK.Name = "colFPHCOCOM_FPHCO_CODE_FK_PK"
        '
        'colFPHCOCOM_CDF_COM_CODE_FK_PK
        '
        Me.colFPHCOCOM_CDF_COM_CODE_FK_PK.Caption = "Code"
        Me.colFPHCOCOM_CDF_COM_CODE_FK_PK.FieldName = "FPHCOCOM_CDF_COM_CODE_FK_PK"
        Me.colFPHCOCOM_CDF_COM_CODE_FK_PK.Name = "colFPHCOCOM_CDF_COM_CODE_FK_PK"
        Me.colFPHCOCOM_CDF_COM_CODE_FK_PK.Visible = True
        Me.colFPHCOCOM_CDF_COM_CODE_FK_PK.VisibleIndex = 0
        Me.colFPHCOCOM_CDF_COM_CODE_FK_PK.Width = 44
        '
        'colFPHCOCOM_NUMORD
        '
        Me.colFPHCOCOM_NUMORD.Caption = "N°"
        Me.colFPHCOCOM_NUMORD.FieldName = "FPHCOCOM_NUMORD"
        Me.colFPHCOCOM_NUMORD.Name = "colFPHCOCOM_NUMORD"
        Me.colFPHCOCOM_NUMORD.Visible = True
        Me.colFPHCOCOM_NUMORD.VisibleIndex = 2
        Me.colFPHCOCOM_NUMORD.Width = 50
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Commentaires"
        Me.GridColumn7.ColumnEdit = Me.lkup_FPHCOCOM
        Me.GridColumn7.FieldName = "FPHCOCOM_CDF_COM_CODE_FK_PK"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        Me.GridColumn7.Width = 516
        '
        'lkup_FPHCOCOM
        '
        Me.lkup_FPHCOCOM.AutoHeight = False
        Me.lkup_FPHCOCOM.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FPHCOCOM.Name = "lkup_FPHCOCOM"
        '
        'FphcocpH_TA
        '
        Me.FphcocpH_TA.ClearBeforeFill = True
        '
        'FphcoccH_TA
        '
        Me.FphcoccH_TA.ClearBeforeFill = True
        '
        'FphcosaC_TA
        '
        Me.FphcosaC_TA.ClearBeforeFill = True
        '
        'FphcosaU_TA
        '
        Me.FphcosaU_TA.ClearBeforeFill = True
        '
        'FphcopR_TA
        '
        Me.FphcopR_TA.ClearBeforeFill = True
        '
        'FphcosP_TA
        '
        Me.FphcosP_TA.ClearBeforeFill = True
        '
        'FphcocoM_TA
        '
        Me.FphcocoM_TA.ClearBeforeFill = True
        '
        'FphcoafS_TA
        '
        Me.FphcoafS_TA.ClearBeforeFill = True
        '
        'Frm_Pharmacocinetique
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(780, 574)
        Me.Name = "Frm_Pharmacocinetique"
        Me.Text = "Pharmacocinétique"
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
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_Pharmacocinetique, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.GC15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FPHCOPR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FPHCOSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GC13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FPHCOSAC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FPHCOSAU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.GC11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FPHCOCPH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FPHCOCCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        CType(Me.MemoEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        CType(Me.GC23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FPHCOAFS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_AFS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.GC21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FPHCOCOM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents FphcO_TA As Theriaque.dsTheriaque_PharmacocinetiqueTableAdapters.FPHCO_PHARMACOCINETIQUETableAdapter
    Friend WithEvents DsTheriaque_Pharmacocinetique As Theriaque.dsTheriaque_Pharmacocinetique
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
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GC15 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV15 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC16 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV16 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FphcocpH_TA As Theriaque.dsTheriaque_PharmacocinetiqueTableAdapters.FPHCOCPH_FPHCO_CLPHTableAdapter
    Friend WithEvents colFPHCOCPH_FPHCO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPHCOCPH_CPH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPHCOCPH_CPH_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FPHCOCPH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FphcoccH_TA As Theriaque.dsTheriaque_PharmacocinetiqueTableAdapters.FPHCOCCH_FPHCO_CLCHTableAdapter
    Friend WithEvents colFPHCOCCH_FPHCO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPHCOCCH_CCH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPHCOCCH_CCH_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FPHCOCCH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FphcosaC_TA As Theriaque.dsTheriaque_PharmacocinetiqueTableAdapters.FPHCOSAC_FPHCO_SUBACTTableAdapter
    Friend WithEvents colFPHCOSAC_FPHCO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPHCOSAC_SAC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPHCOSAC_SAC_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FPHCOSAC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFPHCOSAU_FPHCO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPHCOSAU_SAU_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FPHCOSAU As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FphcosaU_TA As Theriaque.dsTheriaque_PharmacocinetiqueTableAdapters.FPHCOSAU_FPHCO_SUBAUXTableAdapter
    Friend WithEvents colFPHCOSAU_SAU_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPHCOPR_FPHCO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPHCOPR_PR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPHCOPR_PR_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FPHCOPR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FphcopR_TA As Theriaque.dsTheriaque_PharmacocinetiqueTableAdapters.FPHCOPR_FPHCO_PRODTableAdapter
    Friend WithEvents colFPHCOSP_FPHCO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPHCOSP_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FphcosP_TA As Theriaque.dsTheriaque_PharmacocinetiqueTableAdapters.FPHCOSP_PHARMACOCIN_SPECTableAdapter
    Friend WithEvents colFPHCOSP_SP_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GC21 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV21 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC23 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV23 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFPHCOCOM_FPHCO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPHCOCOM_CDF_COM_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPHCOCOM_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FPHCOCOM As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FphcocoM_TA As Theriaque.dsTheriaque_PharmacocinetiqueTableAdapters.FPHCOCOM_FPHCO_COMTableAdapter
    Friend WithEvents lkup_FPHCOSP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFPHCOAFS_FPHCO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPHCOAFS_DATE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FphcoafS_TA As Theriaque.dsTheriaque_PharmacocinetiqueTableAdapters.FPHCOAFS_FPHCO_AFSSAPSTableAdapter
    Friend WithEvents colFPHCOAFS_CDF_DOCUMENT_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FPHCOAFS As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFPHCOAFS_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_AFS As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents MemoEdit3 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl

End Class
