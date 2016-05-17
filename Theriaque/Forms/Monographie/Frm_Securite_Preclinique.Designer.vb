<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Securite_Preclinique
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
        Me.FprcL_TA = New Theriaque.dsTheriaque_SecuritePrecliniqueTableAdapters.FPRCL_SECPRECLINTableAdapter
        Me.DsTheriaque_SecuritePreclinique = New Theriaque.dsTheriaque_SecuritePreclinique
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GC15 = New DevExpress.XtraGrid.GridControl
        Me.GV15 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFPRCLPR_FPRCL_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPRCLPR_PR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FPRCLPR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC16 = New DevExpress.XtraGrid.GridControl
        Me.GV16 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFPRCLSP_FPRCL_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPRCLSP_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FPRCLSP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GC13 = New DevExpress.XtraGrid.GridControl
        Me.GV13 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFPRCLSAC_FPRCL_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPRCLSAC_SAC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FPRCLSAC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC14 = New DevExpress.XtraGrid.GridControl
        Me.GV14 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFPRCLSAU_FPRCL_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPRCLSAU_SAU_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FPRCLSAU = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.GC11 = New DevExpress.XtraGrid.GridControl
        Me.GV11 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFPRCLCPH_FPRCL_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPRCLCPH_CPH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FPRCLCPH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC12 = New DevExpress.XtraGrid.GridControl
        Me.GV12 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFPRCLCCH_FPRCL_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPRCLCCH_CCH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FPRCLCCH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.MemoEdit3 = New DevExpress.XtraEditors.MemoEdit
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.GC23 = New DevExpress.XtraGrid.GridControl
        Me.GV23 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFPRCLAFS_FPRCL_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPRCLAFS_DATE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPRCLAFS_CDF_DOCUMENT_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FPRCLAFS = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFPRCLAFS_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FPRCL_SP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.FprclccH_TA = New Theriaque.dsTheriaque_SecuritePrecliniqueTableAdapters.FPRCLCCH_FPRCL_CLCHTableAdapter
        Me.FprclcpH_TA = New Theriaque.dsTheriaque_SecuritePrecliniqueTableAdapters.FPRCLCPH_FPRCL_CLPHTableAdapter
        Me.FprclpR_TA = New Theriaque.dsTheriaque_SecuritePrecliniqueTableAdapters.FPRCLPR_FPRCL_PRODTableAdapter
        Me.FprclsaC_TA = New Theriaque.dsTheriaque_SecuritePrecliniqueTableAdapters.FPRCLSAC_FPRCL_SUBACTTableAdapter
        Me.FprclsaU_TA = New Theriaque.dsTheriaque_SecuritePrecliniqueTableAdapters.FPRCLSAU_FPRCL_SUBAUXTableAdapter
        Me.FprclsP_TA = New Theriaque.dsTheriaque_SecuritePrecliniqueTableAdapters.FPRCLSP_SECPRECLIN_SPECTableAdapter
        Me.FprclafS_TA = New Theriaque.dsTheriaque_SecuritePrecliniqueTableAdapters.FPRCLAFS_FPRCL_AFSSAPSTableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_SecuritePreclinique, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GC15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FPRCLPR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FPRCLSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.GC13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FPRCLSAC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FPRCLSAU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.GC11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FPRCLCPH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FPRCLCCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.MemoEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.GC23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FPRCLAFS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FPRCL_SP, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Text = "Sécurité préclinique"
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
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_SecuritePreclinique, "FPRCL_SECPRECLIN.FPRCL_DATEMJ", True))
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
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_SecuritePreclinique, "FPRCL_SECPRECLIN.FPRCL_DATECR", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        '
        'btDupliquer
        '
        Me.btDupliquer.Visible = True
        '
        'btn_RechMulti
        '
        Me.btn_RechMulti.Visible = True
        '
        'FprcL_TA
        '
        Me.FprcL_TA.ClearBeforeFill = True
        '
        'DsTheriaque_SecuritePreclinique
        '
        Me.DsTheriaque_SecuritePreclinique.DataSetName = "dsTheriaque_SecuritePreclinique"
        Me.DsTheriaque_SecuritePreclinique.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(662, 42)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_SecuritePreclinique, "FPRCL_SECPRECLIN.FPRCL_CODE_SQ_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(92, 13)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(135, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Tag = "[NOEDIT][NOADD]"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(46, 17)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Fiche N°"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Location = New System.Drawing.Point(1, 48)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(658, 436)
        Me.XtraTabControl1.TabIndex = 9
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
        Me.GC15.DataMember = "FPRCLPR_FPRCL_PROD"
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
        Me.GC15.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FPRCLPR})
        Me.GC15.Size = New System.Drawing.Size(346, 131)
        Me.GC15.TabIndex = 2
        Me.GC15.Tag = "[EDIT][ADD]"
        Me.GC15.UseEmbeddedNavigator = True
        Me.GC15.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV15})
        '
        'GV15
        '
        Me.GV15.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFPRCLPR_FPRCL_CODE_FK_PK, Me.colFPRCLPR_PR_CODE_FK_PK, Me.GridColumn5})
        Me.GV15.GridControl = Me.GC15
        Me.GV15.Name = "GV15"
        Me.GV15.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV15.OptionsView.ShowGroupPanel = False
        '
        'colFPRCLPR_FPRCL_CODE_FK_PK
        '
        Me.colFPRCLPR_FPRCL_CODE_FK_PK.Caption = "FPRCLPR_FPRCL_CODE_FK_PK"
        Me.colFPRCLPR_FPRCL_CODE_FK_PK.FieldName = "FPRCLPR_FPRCL_CODE_FK_PK"
        Me.colFPRCLPR_FPRCL_CODE_FK_PK.Name = "colFPRCLPR_FPRCL_CODE_FK_PK"
        '
        'colFPRCLPR_PR_CODE_FK_PK
        '
        Me.colFPRCLPR_PR_CODE_FK_PK.Caption = "Code"
        Me.colFPRCLPR_PR_CODE_FK_PK.FieldName = "FPRCLPR_PR_CODE_FK_PK"
        Me.colFPRCLPR_PR_CODE_FK_PK.Name = "colFPRCLPR_PR_CODE_FK_PK"
        Me.colFPRCLPR_PR_CODE_FK_PK.Visible = True
        Me.colFPRCLPR_PR_CODE_FK_PK.VisibleIndex = 0
        Me.colFPRCLPR_PR_CODE_FK_PK.Width = 50
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Produit"
        Me.GridColumn5.ColumnEdit = Me.rp_FPRCLPR
        Me.GridColumn5.FieldName = "FPRCLPR_PR_CODE_FK_PK"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 275
        '
        'rp_FPRCLPR
        '
        Me.rp_FPRCLPR.AutoHeight = False
        Me.rp_FPRCLPR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FPRCLPR.Name = "rp_FPRCLPR"
        '
        'GC16
        '
        Me.GC16.DataMember = "FPRCLSP_SECPRECLIN_SPEC"
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
        Me.GC16.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FPRCLSP})
        Me.GC16.Size = New System.Drawing.Size(303, 131)
        Me.GC16.TabIndex = 3
        Me.GC16.Tag = "[EDIT][ADD]"
        Me.GC16.UseEmbeddedNavigator = True
        Me.GC16.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV16})
        '
        'GV16
        '
        Me.GV16.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFPRCLSP_FPRCL_CODE_FK_PK, Me.colFPRCLSP_SP_CODE_FK_PK, Me.GridColumn6})
        Me.GV16.GridControl = Me.GC16
        Me.GV16.Name = "GV16"
        Me.GV16.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV16.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV16.OptionsView.ShowGroupPanel = False
        '
        'colFPRCLSP_FPRCL_CODE_FK_PK
        '
        Me.colFPRCLSP_FPRCL_CODE_FK_PK.Caption = "FPRCLSP_FPRCL_CODE_FK_PK"
        Me.colFPRCLSP_FPRCL_CODE_FK_PK.FieldName = "FPRCLSP_FPRCL_CODE_FK_PK"
        Me.colFPRCLSP_FPRCL_CODE_FK_PK.Name = "colFPRCLSP_FPRCL_CODE_FK_PK"
        '
        'colFPRCLSP_SP_CODE_FK_PK
        '
        Me.colFPRCLSP_SP_CODE_FK_PK.Caption = "Code"
        Me.colFPRCLSP_SP_CODE_FK_PK.FieldName = "FPRCLSP_SP_CODE_FK_PK"
        Me.colFPRCLSP_SP_CODE_FK_PK.Name = "colFPRCLSP_SP_CODE_FK_PK"
        Me.colFPRCLSP_SP_CODE_FK_PK.Visible = True
        Me.colFPRCLSP_SP_CODE_FK_PK.VisibleIndex = 0
        Me.colFPRCLSP_SP_CODE_FK_PK.Width = 50
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Spécialités"
        Me.GridColumn6.ColumnEdit = Me.rp_FPRCLSP
        Me.GridColumn6.FieldName = "FPRCLSP_SP_CODE_FK_PK"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        Me.GridColumn6.Width = 232
        '
        'rp_FPRCLSP
        '
        Me.rp_FPRCLSP.AutoHeight = False
        Me.rp_FPRCLSP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FPRCLSP.Name = "rp_FPRCLSP"
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
        Me.GC13.DataMember = "FPRCLSAC_FPRCL_SUBACT"
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
        Me.GC13.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FPRCLSAC})
        Me.GC13.Size = New System.Drawing.Size(346, 137)
        Me.GC13.TabIndex = 2
        Me.GC13.Tag = "[EDIT][ADD]"
        Me.GC13.UseEmbeddedNavigator = True
        Me.GC13.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV13})
        '
        'GV13
        '
        Me.GV13.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFPRCLSAC_FPRCL_CODE_FK_PK, Me.colFPRCLSAC_SAC_CODE_FK_PK, Me.GridColumn3})
        Me.GV13.GridControl = Me.GC13
        Me.GV13.Name = "GV13"
        Me.GV13.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV13.OptionsView.ShowGroupPanel = False
        '
        'colFPRCLSAC_FPRCL_CODE_FK_PK
        '
        Me.colFPRCLSAC_FPRCL_CODE_FK_PK.Caption = "FPRCLSAC_FPRCL_CODE_FK_PK"
        Me.colFPRCLSAC_FPRCL_CODE_FK_PK.FieldName = "FPRCLSAC_FPRCL_CODE_FK_PK"
        Me.colFPRCLSAC_FPRCL_CODE_FK_PK.Name = "colFPRCLSAC_FPRCL_CODE_FK_PK"
        '
        'colFPRCLSAC_SAC_CODE_FK_PK
        '
        Me.colFPRCLSAC_SAC_CODE_FK_PK.Caption = "Code"
        Me.colFPRCLSAC_SAC_CODE_FK_PK.FieldName = "FPRCLSAC_SAC_CODE_FK_PK"
        Me.colFPRCLSAC_SAC_CODE_FK_PK.Name = "colFPRCLSAC_SAC_CODE_FK_PK"
        Me.colFPRCLSAC_SAC_CODE_FK_PK.Visible = True
        Me.colFPRCLSAC_SAC_CODE_FK_PK.VisibleIndex = 0
        Me.colFPRCLSAC_SAC_CODE_FK_PK.Width = 50
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Substance active"
        Me.GridColumn3.ColumnEdit = Me.rp_FPRCLSAC
        Me.GridColumn3.FieldName = "FPRCLSAC_SAC_CODE_FK_PK"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 275
        '
        'rp_FPRCLSAC
        '
        Me.rp_FPRCLSAC.AutoHeight = False
        Me.rp_FPRCLSAC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FPRCLSAC.Name = "rp_FPRCLSAC"
        '
        'GC14
        '
        Me.GC14.DataMember = "FPRCLSAU_FPRCL_SUBAUX"
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
        Me.GC14.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FPRCLSAU})
        Me.GC14.Size = New System.Drawing.Size(303, 137)
        Me.GC14.TabIndex = 3
        Me.GC14.Tag = "[EDIT][ADD]"
        Me.GC14.UseEmbeddedNavigator = True
        Me.GC14.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV14})
        '
        'GV14
        '
        Me.GV14.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFPRCLSAU_FPRCL_CODE_FK_PK, Me.colFPRCLSAU_SAU_CODE_FK_PK, Me.GridColumn4})
        Me.GV14.GridControl = Me.GC14
        Me.GV14.Name = "GV14"
        Me.GV14.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV14.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV14.OptionsView.ShowGroupPanel = False
        '
        'colFPRCLSAU_FPRCL_CODE_FK_PK
        '
        Me.colFPRCLSAU_FPRCL_CODE_FK_PK.Caption = "FPRCLSAU_FPRCL_CODE_FK_PK"
        Me.colFPRCLSAU_FPRCL_CODE_FK_PK.FieldName = "FPRCLSAU_FPRCL_CODE_FK_PK"
        Me.colFPRCLSAU_FPRCL_CODE_FK_PK.Name = "colFPRCLSAU_FPRCL_CODE_FK_PK"
        '
        'colFPRCLSAU_SAU_CODE_FK_PK
        '
        Me.colFPRCLSAU_SAU_CODE_FK_PK.Caption = "Code"
        Me.colFPRCLSAU_SAU_CODE_FK_PK.FieldName = "FPRCLSAU_SAU_CODE_FK_PK"
        Me.colFPRCLSAU_SAU_CODE_FK_PK.Name = "colFPRCLSAU_SAU_CODE_FK_PK"
        Me.colFPRCLSAU_SAU_CODE_FK_PK.Visible = True
        Me.colFPRCLSAU_SAU_CODE_FK_PK.VisibleIndex = 0
        Me.colFPRCLSAU_SAU_CODE_FK_PK.Width = 50
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Excipient"
        Me.GridColumn4.ColumnEdit = Me.rp_FPRCLSAU
        Me.GridColumn4.FieldName = "FPRCLSAU_SAU_CODE_FK_PK"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 232
        '
        'rp_FPRCLSAU
        '
        Me.rp_FPRCLSAU.AutoHeight = False
        Me.rp_FPRCLSAU.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FPRCLSAU.Name = "rp_FPRCLSAU"
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
        Me.GC11.DataMember = "FPRCLCPH_FPRCL_CLPH"
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
        Me.GC11.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FPRCLCPH})
        Me.GC11.Size = New System.Drawing.Size(346, 137)
        Me.GC11.TabIndex = 2
        Me.GC11.Tag = "[EDIT][ADD]"
        Me.GC11.UseEmbeddedNavigator = True
        Me.GC11.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV11})
        '
        'GV11
        '
        Me.GV11.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFPRCLCPH_FPRCL_CODE_FK_PK, Me.colFPRCLCPH_CPH_CODE_FK_PK, Me.GridColumn1})
        Me.GV11.GridControl = Me.GC11
        Me.GV11.Name = "GV11"
        Me.GV11.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV11.OptionsView.ShowGroupPanel = False
        '
        'colFPRCLCPH_FPRCL_CODE_FK_PK
        '
        Me.colFPRCLCPH_FPRCL_CODE_FK_PK.Caption = "FPRCLCPH_FPRCL_CODE_FK_PK"
        Me.colFPRCLCPH_FPRCL_CODE_FK_PK.FieldName = "FPRCLCPH_FPRCL_CODE_FK_PK"
        Me.colFPRCLCPH_FPRCL_CODE_FK_PK.Name = "colFPRCLCPH_FPRCL_CODE_FK_PK"
        '
        'colFPRCLCPH_CPH_CODE_FK_PK
        '
        Me.colFPRCLCPH_CPH_CODE_FK_PK.Caption = "Code"
        Me.colFPRCLCPH_CPH_CODE_FK_PK.FieldName = "FPRCLCPH_CPH_CODE_FK_PK"
        Me.colFPRCLCPH_CPH_CODE_FK_PK.Name = "colFPRCLCPH_CPH_CODE_FK_PK"
        Me.colFPRCLCPH_CPH_CODE_FK_PK.Visible = True
        Me.colFPRCLCPH_CPH_CODE_FK_PK.VisibleIndex = 0
        Me.colFPRCLCPH_CPH_CODE_FK_PK.Width = 50
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Classe pharmaco thérapeutique"
        Me.GridColumn1.ColumnEdit = Me.rp_FPRCLCPH
        Me.GridColumn1.FieldName = "FPRCLCPH_CPH_CODE_FK_PK"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 275
        '
        'rp_FPRCLCPH
        '
        Me.rp_FPRCLCPH.AutoHeight = False
        Me.rp_FPRCLCPH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FPRCLCPH.Name = "rp_FPRCLCPH"
        '
        'GC12
        '
        Me.GC12.DataMember = "FPRCLCCH_FPRCL_CLCH"
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
        Me.GC12.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FPRCLCCH})
        Me.GC12.Size = New System.Drawing.Size(303, 137)
        Me.GC12.TabIndex = 3
        Me.GC12.Tag = "[EDIT][ADD]"
        Me.GC12.UseEmbeddedNavigator = True
        Me.GC12.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV12})
        '
        'GV12
        '
        Me.GV12.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFPRCLCCH_FPRCL_CODE_FK_PK, Me.colFPRCLCCH_CCH_CODE_FK_PK, Me.GridColumn2})
        Me.GV12.GridControl = Me.GC12
        Me.GV12.Name = "GV12"
        Me.GV12.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV12.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV12.OptionsView.ShowGroupPanel = False
        '
        'colFPRCLCCH_FPRCL_CODE_FK_PK
        '
        Me.colFPRCLCCH_FPRCL_CODE_FK_PK.Caption = "FPRCLCCH_FPRCL_CODE_FK_PK"
        Me.colFPRCLCCH_FPRCL_CODE_FK_PK.FieldName = "FPRCLCCH_FPRCL_CODE_FK_PK"
        Me.colFPRCLCCH_FPRCL_CODE_FK_PK.Name = "colFPRCLCCH_FPRCL_CODE_FK_PK"
        '
        'colFPRCLCCH_CCH_CODE_FK_PK
        '
        Me.colFPRCLCCH_CCH_CODE_FK_PK.Caption = "Code"
        Me.colFPRCLCCH_CCH_CODE_FK_PK.FieldName = "FPRCLCCH_CCH_CODE_FK_PK"
        Me.colFPRCLCCH_CCH_CODE_FK_PK.Name = "colFPRCLCCH_CCH_CODE_FK_PK"
        Me.colFPRCLCCH_CCH_CODE_FK_PK.Visible = True
        Me.colFPRCLCCH_CCH_CODE_FK_PK.VisibleIndex = 0
        Me.colFPRCLCCH_CCH_CODE_FK_PK.Width = 50
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Classe chimique"
        Me.GridColumn2.ColumnEdit = Me.rp_FPRCLCCH
        Me.GridColumn2.FieldName = "FPRCLCCH_CCH_CODE_FK_PK"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 232
        '
        'rp_FPRCLCCH
        '
        Me.rp_FPRCLCCH.AutoHeight = False
        Me.rp_FPRCLCCH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FPRCLCCH.Name = "rp_FPRCLCCH"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Panel6)
        Me.XtraTabPage2.Controls.Add(Me.Panel7)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(649, 405)
        Me.XtraTabPage2.Text = "Réf.officielles / Texte"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel10)
        Me.Panel6.Controls.Add(Me.Panel11)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 114)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(649, 291)
        Me.Panel6.TabIndex = 40
        Me.Panel6.Tag = ""
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.MemoEdit3)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(0, 24)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(649, 267)
        Me.Panel10.TabIndex = 38
        Me.Panel10.Tag = "[ADD][EDIT]"
        '
        'MemoEdit3
        '
        Me.MemoEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_SecuritePreclinique, "FPRCL_SECPRECLIN.FPRCL_TXT", True))
        Me.MemoEdit3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoEdit3.Location = New System.Drawing.Point(0, 0)
        Me.MemoEdit3.Name = "MemoEdit3"
        Me.MemoEdit3.Size = New System.Drawing.Size(649, 267)
        Me.MemoEdit3.TabIndex = 36
        Me.MemoEdit3.Tag = ""
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.LabelControl7)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(649, 24)
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
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(649, 114)
        Me.Panel7.TabIndex = 25
        '
        'GC23
        '
        Me.GC23.DataMember = "FPRCLAFS_FPRCL_AFSSAPS"
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
        Me.GC23.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FPRCLAFS, Me.rp_FPRCL_SP})
        Me.GC23.Size = New System.Drawing.Size(649, 114)
        Me.GC23.TabIndex = 22
        Me.GC23.Tag = "[EDIT][ADD]"
        Me.GC23.UseEmbeddedNavigator = True
        Me.GC23.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV23})
        '
        'GV23
        '
        Me.GV23.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFPRCLAFS_FPRCL_CODE_FK_PK, Me.colFPRCLAFS_DATE_PK, Me.colFPRCLAFS_CDF_DOCUMENT_FK_PK, Me.colFPRCLAFS_SP_CODE_FK_PK})
        Me.GV23.GridControl = Me.GC23
        Me.GV23.Name = "GV23"
        Me.GV23.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV23.OptionsView.ShowGroupPanel = False
        '
        'colFPRCLAFS_FPRCL_CODE_FK_PK
        '
        Me.colFPRCLAFS_FPRCL_CODE_FK_PK.Caption = "FPRCLAFS_FPRCL_CODE_FK_PK"
        Me.colFPRCLAFS_FPRCL_CODE_FK_PK.FieldName = "FPRCLAFS_FPRCL_CODE_FK_PK"
        Me.colFPRCLAFS_FPRCL_CODE_FK_PK.Name = "colFPRCLAFS_FPRCL_CODE_FK_PK"
        '
        'colFPRCLAFS_DATE_PK
        '
        Me.colFPRCLAFS_DATE_PK.Caption = "Date"
        Me.colFPRCLAFS_DATE_PK.FieldName = "FPRCLAFS_DATE_PK"
        Me.colFPRCLAFS_DATE_PK.Name = "colFPRCLAFS_DATE_PK"
        Me.colFPRCLAFS_DATE_PK.Visible = True
        Me.colFPRCLAFS_DATE_PK.VisibleIndex = 1
        Me.colFPRCLAFS_DATE_PK.Width = 77
        '
        'colFPRCLAFS_CDF_DOCUMENT_FK_PK
        '
        Me.colFPRCLAFS_CDF_DOCUMENT_FK_PK.Caption = "Références officielles"
        Me.colFPRCLAFS_CDF_DOCUMENT_FK_PK.ColumnEdit = Me.rp_FPRCLAFS
        Me.colFPRCLAFS_CDF_DOCUMENT_FK_PK.FieldName = "FPRCLAFS_CDF_DOCUMENT_FK_PK"
        Me.colFPRCLAFS_CDF_DOCUMENT_FK_PK.Name = "colFPRCLAFS_CDF_DOCUMENT_FK_PK"
        Me.colFPRCLAFS_CDF_DOCUMENT_FK_PK.Visible = True
        Me.colFPRCLAFS_CDF_DOCUMENT_FK_PK.VisibleIndex = 0
        Me.colFPRCLAFS_CDF_DOCUMENT_FK_PK.Width = 218
        '
        'rp_FPRCLAFS
        '
        Me.rp_FPRCLAFS.AutoHeight = False
        Me.rp_FPRCLAFS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FPRCLAFS.Name = "rp_FPRCLAFS"
        '
        'colFPRCLAFS_SP_CODE_FK_PK
        '
        Me.colFPRCLAFS_SP_CODE_FK_PK.Caption = "Spécialités"
        Me.colFPRCLAFS_SP_CODE_FK_PK.ColumnEdit = Me.rp_FPRCL_SP
        Me.colFPRCLAFS_SP_CODE_FK_PK.FieldName = "FPRCLAFS_SP_CODE_FK_PK"
        Me.colFPRCLAFS_SP_CODE_FK_PK.Name = "colFPRCLAFS_SP_CODE_FK_PK"
        Me.colFPRCLAFS_SP_CODE_FK_PK.Visible = True
        Me.colFPRCLAFS_SP_CODE_FK_PK.VisibleIndex = 2
        Me.colFPRCLAFS_SP_CODE_FK_PK.Width = 233
        '
        'rp_FPRCL_SP
        '
        Me.rp_FPRCL_SP.AutoHeight = False
        Me.rp_FPRCL_SP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FPRCL_SP.Name = "rp_FPRCL_SP"
        Me.rp_FPRCL_SP.NullText = ""
        '
        'FprclccH_TA
        '
        Me.FprclccH_TA.ClearBeforeFill = True
        '
        'FprclcpH_TA
        '
        Me.FprclcpH_TA.ClearBeforeFill = True
        '
        'FprclpR_TA
        '
        Me.FprclpR_TA.ClearBeforeFill = True
        '
        'FprclsaC_TA
        '
        Me.FprclsaC_TA.ClearBeforeFill = True
        '
        'FprclsaU_TA
        '
        Me.FprclsaU_TA.ClearBeforeFill = True
        '
        'FprclsP_TA
        '
        Me.FprclsP_TA.ClearBeforeFill = True
        '
        'FprclafS_TA
        '
        Me.FprclafS_TA.ClearBeforeFill = True
        '
        'Frm_Securite_Preclinique
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(780, 574)
        Me.Name = "Frm_Securite_Preclinique"
        Me.Text = "Sécurité préclinique"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_SecuritePreclinique, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.GC15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FPRCLPR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FPRCLSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GC13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FPRCLSAC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FPRCLSAU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.GC11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FPRCLCPH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FPRCLCCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        CType(Me.MemoEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        CType(Me.GC23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FPRCLAFS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FPRCL_SP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FprcL_TA As Theriaque.dsTheriaque_SecuritePrecliniqueTableAdapters.FPRCL_SECPRECLINTableAdapter
    Friend WithEvents DsTheriaque_SecuritePreclinique As Theriaque.dsTheriaque_SecuritePreclinique
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GC15 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV15 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC16 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV16 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GC13 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC14 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GC11 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC12 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents MemoEdit3 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents GC23 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV23 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FprclccH_TA As Theriaque.dsTheriaque_SecuritePrecliniqueTableAdapters.FPRCLCCH_FPRCL_CLCHTableAdapter
    Friend WithEvents FprclcpH_TA As Theriaque.dsTheriaque_SecuritePrecliniqueTableAdapters.FPRCLCPH_FPRCL_CLPHTableAdapter
    Friend WithEvents FprclpR_TA As Theriaque.dsTheriaque_SecuritePrecliniqueTableAdapters.FPRCLPR_FPRCL_PRODTableAdapter
    Friend WithEvents FprclsaC_TA As Theriaque.dsTheriaque_SecuritePrecliniqueTableAdapters.FPRCLSAC_FPRCL_SUBACTTableAdapter
    Friend WithEvents FprclsaU_TA As Theriaque.dsTheriaque_SecuritePrecliniqueTableAdapters.FPRCLSAU_FPRCL_SUBAUXTableAdapter
    Friend WithEvents FprclsP_TA As Theriaque.dsTheriaque_SecuritePrecliniqueTableAdapters.FPRCLSP_SECPRECLIN_SPECTableAdapter
    Friend WithEvents FprclafS_TA As Theriaque.dsTheriaque_SecuritePrecliniqueTableAdapters.FPRCLAFS_FPRCL_AFSSAPSTableAdapter
    Friend WithEvents colFPRCLCPH_FPRCL_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPRCLCPH_CPH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FPRCLCPH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFPRCLSAC_FPRCL_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPRCLSAC_SAC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FPRCLSAC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFPRCLSAU_FPRCL_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPRCLSAU_SAU_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FPRCLSAU As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFPRCLCCH_FPRCL_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPRCLCCH_CCH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FPRCLCCH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFPRCLPR_FPRCL_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPRCLPR_PR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FPRCLPR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFPRCLSP_FPRCL_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPRCLSP_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FPRCLSP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFPRCLAFS_FPRCL_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPRCLAFS_DATE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPRCLAFS_CDF_DOCUMENT_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FPRCLAFS As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFPRCLAFS_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FPRCL_SP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

End Class
