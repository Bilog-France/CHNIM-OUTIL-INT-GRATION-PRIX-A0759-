<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_InteractionsRCP
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
        Me.FircP_TA = New Theriaque.dsTheriaque_InteractionRCPTableAdapters.FIRCP_INTERACTIONRCPTableAdapter
        Me.DsTheriaque_InteractionRCP = New Theriaque.dsTheriaque_InteractionRCP
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.GC5 = New DevExpress.XtraGrid.GridControl
        Me.GV5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFIRCPPR_FIRCP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIRCPPR_PR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIRCPPR_PR_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FIRCPPR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC6 = New DevExpress.XtraGrid.GridControl
        Me.GV6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFIRCPSP_FIRCP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIRCPSP_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIRCPSP_SP_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FIRCPSP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.GC4 = New DevExpress.XtraGrid.GridControl
        Me.GV4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFIRCPSAU_FIRCP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIRCPSAU_SAU_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIRCPSAU_SAU_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FIRCPSAU = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC3 = New DevExpress.XtraGrid.GridControl
        Me.GV3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFIRCPSAC_FIRCP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIRCPSAC_SAC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIRCPSAC_SAC_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FIRCPSAC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.GC1 = New DevExpress.XtraGrid.GridControl
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFIRCPCPH_FIRCP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIRCPCPH_CPH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIRCPCPH_CPH_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FIRCPCPH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC2 = New DevExpress.XtraGrid.GridControl
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFIRCPCCH_FIRCP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIRCPCCH_CCH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIRCPCCH_CCH_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FIRCPCCH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.MemoEdit3 = New DevExpress.XtraEditors.MemoEdit
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.GC22 = New DevExpress.XtraGrid.GridControl
        Me.GV22 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFIRCPAFS_FIRCP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIRCPAFS_DATE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIRCPAFS_CDF_DOCUMENT_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FIRCPAFS = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFIRCPAFS_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_AFS = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.GC21 = New DevExpress.XtraGrid.GridControl
        Me.GV21 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFIRCPCOM_FIRCP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIRCPCOM_CDF_COM_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIRCPCOM_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Lkup_FIRCPCOM = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GC15 = New DevExpress.XtraGrid.GridControl
        Me.GV15 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFPHCOPR_FPHCO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPHCOPR_PR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FPHCOPR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC16 = New DevExpress.XtraGrid.GridControl
        Me.GV16 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFPHCOSP_FPHCO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPHCOSP_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FPHCOSP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GC13 = New DevExpress.XtraGrid.GridControl
        Me.GV13 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFPHCOSAC_FPHCO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPHCOSAC_SAC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FPHCOSAC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC14 = New DevExpress.XtraGrid.GridControl
        Me.GV14 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFPHCOSAU_FPHCO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPHCOSAU_SAU_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FPHCOSAU = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.GC11 = New DevExpress.XtraGrid.GridControl
        Me.GV11 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFPHCOCPH_FPHCO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPHCOCPH_CPH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FPHCOCPH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC12 = New DevExpress.XtraGrid.GridControl
        Me.GV12 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFPHCOCCH_FPHCO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPHCOCCH_CCH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FPHCOCCH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.FircpcpH_TA = New Theriaque.dsTheriaque_InteractionRCPTableAdapters.FIRCPCPH_FIRCP_CLPHTableAdapter
        Me.FircpccH_TA = New Theriaque.dsTheriaque_InteractionRCPTableAdapters.FIRCPCCH_FIRCP_CLCHTableAdapter
        Me.FircpsaC_TA = New Theriaque.dsTheriaque_InteractionRCPTableAdapters.FIRCPSAC_FIRCP_SUBACTTableAdapter
        Me.FircpsaU_TA = New Theriaque.dsTheriaque_InteractionRCPTableAdapters.FIRCPSAU_FIRCP_SUBAUXTableAdapter
        Me.FircppR_TA = New Theriaque.dsTheriaque_InteractionRCPTableAdapters.FIRCPPR_FIRCP_PRODTableAdapter
        Me.FircpsP_TA = New Theriaque.dsTheriaque_InteractionRCPTableAdapters.FIRCPSP_INTERACTRCP_SPECTableAdapter
        Me.FircpcoM_TA = New Theriaque.dsTheriaque_InteractionRCPTableAdapters.FIRCPCOM_FIRCP_COMTableAdapter
        Me.FircpafS_TA = New Theriaque.dsTheriaque_InteractionRCPTableAdapters.FIRCPAFS_FIRCP_AFSSAPSTableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_InteractionRCP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.GC5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FIRCPPR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FIRCPSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.GC4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FIRCPSAU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FIRCPSAC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FIRCPCPH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FIRCPCCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.MemoEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.GC22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FIRCPAFS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_AFS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.GC21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lkup_FIRCPCOM, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Text = "Interactions RCP"
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
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_InteractionRCP, "FIRCP_INTERACTIONRCP.FIRCP_DATEMJ", True))
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
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_InteractionRCP, "FIRCP_INTERACTIONRCP.FIRCP_DATECR", True))
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
        'FircP_TA
        '
        Me.FircP_TA.ClearBeforeFill = True
        '
        'DsTheriaque_InteractionRCP
        '
        Me.DsTheriaque_InteractionRCP.DataSetName = "dsTheriaque_InteractionRCP"
        Me.DsTheriaque_InteractionRCP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_InteractionRCP, "FIRCP_INTERACTIONRCP.FIRCP_CODE_SQ_PK", True))
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
        Me.XtraTabControl1.Location = New System.Drawing.Point(3, 48)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(655, 438)
        Me.XtraTabControl1.TabIndex = 9
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panel7)
        Me.XtraTabPage1.Controls.Add(Me.Panel6)
        Me.XtraTabPage1.Controls.Add(Me.Panel4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(646, 407)
        Me.XtraTabPage1.Text = "Entités"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.GC5)
        Me.Panel7.Controls.Add(Me.GC6)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 274)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(646, 133)
        Me.Panel7.TabIndex = 21
        '
        'GC5
        '
        Me.GC5.DataMember = "FIRCPPR_FIRCP_PROD"
        Me.GC5.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.GC5.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FIRCPPR})
        Me.GC5.Size = New System.Drawing.Size(345, 133)
        Me.GC5.TabIndex = 2
        Me.GC5.Tag = "[EDIT][ADD]"
        Me.GC5.UseEmbeddedNavigator = True
        Me.GC5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV5})
        '
        'GV5
        '
        Me.GV5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFIRCPPR_FIRCP_CODE_FK_PK, Me.colFIRCPPR_PR_CODE_FK_PK, Me.colFIRCPPR_PR_CODE_FK_PK2})
        Me.GV5.GridControl = Me.GC5
        Me.GV5.Name = "GV5"
        Me.GV5.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV5.OptionsView.ShowGroupPanel = False
        '
        'colFIRCPPR_FIRCP_CODE_FK_PK
        '
        Me.colFIRCPPR_FIRCP_CODE_FK_PK.Caption = "FIRCPPR_FIRCP_CODE_FK_PK"
        Me.colFIRCPPR_FIRCP_CODE_FK_PK.FieldName = "FIRCPPR_FIRCP_CODE_FK_PK"
        Me.colFIRCPPR_FIRCP_CODE_FK_PK.Name = "colFIRCPPR_FIRCP_CODE_FK_PK"
        '
        'colFIRCPPR_PR_CODE_FK_PK
        '
        Me.colFIRCPPR_PR_CODE_FK_PK.Caption = "Code"
        Me.colFIRCPPR_PR_CODE_FK_PK.FieldName = "FIRCPPR_PR_CODE_FK_PK"
        Me.colFIRCPPR_PR_CODE_FK_PK.Name = "colFIRCPPR_PR_CODE_FK_PK"
        Me.colFIRCPPR_PR_CODE_FK_PK.Visible = True
        Me.colFIRCPPR_PR_CODE_FK_PK.VisibleIndex = 0
        Me.colFIRCPPR_PR_CODE_FK_PK.Width = 50
        '
        'colFIRCPPR_PR_CODE_FK_PK2
        '
        Me.colFIRCPPR_PR_CODE_FK_PK2.Caption = "Produit"
        Me.colFIRCPPR_PR_CODE_FK_PK2.ColumnEdit = Me.lkup_FIRCPPR
        Me.colFIRCPPR_PR_CODE_FK_PK2.FieldName = "FIRCPPR_PR_CODE_FK_PK"
        Me.colFIRCPPR_PR_CODE_FK_PK2.Name = "colFIRCPPR_PR_CODE_FK_PK2"
        Me.colFIRCPPR_PR_CODE_FK_PK2.Visible = True
        Me.colFIRCPPR_PR_CODE_FK_PK2.VisibleIndex = 1
        Me.colFIRCPPR_PR_CODE_FK_PK2.Width = 274
        '
        'lkup_FIRCPPR
        '
        Me.lkup_FIRCPPR.AutoHeight = False
        Me.lkup_FIRCPPR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FIRCPPR.Name = "lkup_FIRCPPR"
        '
        'GC6
        '
        Me.GC6.DataMember = "FIRCPSP_INTERACTRCP_SPEC"
        Me.GC6.Dock = System.Windows.Forms.DockStyle.Right
        Me.GC6.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC6.EmbeddedNavigator.Name = ""
        Me.GC6.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC6.Location = New System.Drawing.Point(345, 0)
        Me.GC6.MainView = Me.GV6
        Me.GC6.Name = "GC6"
        Me.GC6.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FIRCPSP})
        Me.GC6.Size = New System.Drawing.Size(301, 133)
        Me.GC6.TabIndex = 3
        Me.GC6.Tag = "[EDIT][ADD]"
        Me.GC6.UseEmbeddedNavigator = True
        Me.GC6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV6})
        '
        'GV6
        '
        Me.GV6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFIRCPSP_FIRCP_CODE_FK_PK, Me.colFIRCPSP_SP_CODE_FK_PK, Me.colFIRCPSP_SP_CODE_FK_PK2})
        Me.GV6.GridControl = Me.GC6
        Me.GV6.Name = "GV6"
        Me.GV6.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV6.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV6.OptionsView.ShowGroupPanel = False
        '
        'colFIRCPSP_FIRCP_CODE_FK_PK
        '
        Me.colFIRCPSP_FIRCP_CODE_FK_PK.Caption = "FIRCPSP_FIRCP_CODE_FK_PK"
        Me.colFIRCPSP_FIRCP_CODE_FK_PK.FieldName = "FIRCPSP_FIRCP_CODE_FK_PK"
        Me.colFIRCPSP_FIRCP_CODE_FK_PK.Name = "colFIRCPSP_FIRCP_CODE_FK_PK"
        '
        'colFIRCPSP_SP_CODE_FK_PK
        '
        Me.colFIRCPSP_SP_CODE_FK_PK.Caption = "Code"
        Me.colFIRCPSP_SP_CODE_FK_PK.FieldName = "FIRCPSP_SP_CODE_FK_PK"
        Me.colFIRCPSP_SP_CODE_FK_PK.Name = "colFIRCPSP_SP_CODE_FK_PK"
        Me.colFIRCPSP_SP_CODE_FK_PK.Visible = True
        Me.colFIRCPSP_SP_CODE_FK_PK.VisibleIndex = 0
        Me.colFIRCPSP_SP_CODE_FK_PK.Width = 50
        '
        'colFIRCPSP_SP_CODE_FK_PK2
        '
        Me.colFIRCPSP_SP_CODE_FK_PK2.Caption = "Spécialités"
        Me.colFIRCPSP_SP_CODE_FK_PK2.ColumnEdit = Me.lkup_FIRCPSP
        Me.colFIRCPSP_SP_CODE_FK_PK2.FieldName = "FIRCPSP_SP_CODE_FK_PK"
        Me.colFIRCPSP_SP_CODE_FK_PK2.Name = "colFIRCPSP_SP_CODE_FK_PK2"
        Me.colFIRCPSP_SP_CODE_FK_PK2.Visible = True
        Me.colFIRCPSP_SP_CODE_FK_PK2.VisibleIndex = 1
        Me.colFIRCPSP_SP_CODE_FK_PK2.Width = 226
        '
        'lkup_FIRCPSP
        '
        Me.lkup_FIRCPSP.AutoHeight = False
        Me.lkup_FIRCPSP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FIRCPSP.Name = "lkup_FIRCPSP"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GC4)
        Me.Panel6.Controls.Add(Me.GC3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 137)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(646, 137)
        Me.Panel6.TabIndex = 20
        '
        'GC4
        '
        Me.GC4.DataMember = "FIRCPSAU_FIRCP_SUBAUX"
        Me.GC4.Dock = System.Windows.Forms.DockStyle.Right
        Me.GC4.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC4.EmbeddedNavigator.Name = ""
        Me.GC4.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC4.Location = New System.Drawing.Point(343, 0)
        Me.GC4.MainView = Me.GV4
        Me.GC4.Name = "GC4"
        Me.GC4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FIRCPSAU})
        Me.GC4.Size = New System.Drawing.Size(303, 137)
        Me.GC4.TabIndex = 3
        Me.GC4.Tag = "[EDIT][ADD]"
        Me.GC4.UseEmbeddedNavigator = True
        Me.GC4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV4})
        '
        'GV4
        '
        Me.GV4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFIRCPSAU_FIRCP_CODE_FK_PK, Me.colFIRCPSAU_SAU_CODE_FK_PK, Me.colFIRCPSAU_SAU_CODE_FK_PK2})
        Me.GV4.GridControl = Me.GC4
        Me.GV4.Name = "GV4"
        Me.GV4.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV4.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV4.OptionsView.ShowGroupPanel = False
        '
        'colFIRCPSAU_FIRCP_CODE_FK_PK
        '
        Me.colFIRCPSAU_FIRCP_CODE_FK_PK.Caption = "FIRCPSAU_FIRCP_CODE_FK_PK"
        Me.colFIRCPSAU_FIRCP_CODE_FK_PK.FieldName = "FIRCPSAU_FIRCP_CODE_FK_PK"
        Me.colFIRCPSAU_FIRCP_CODE_FK_PK.Name = "colFIRCPSAU_FIRCP_CODE_FK_PK"
        '
        'colFIRCPSAU_SAU_CODE_FK_PK
        '
        Me.colFIRCPSAU_SAU_CODE_FK_PK.Caption = "Code"
        Me.colFIRCPSAU_SAU_CODE_FK_PK.FieldName = "FIRCPSAU_SAU_CODE_FK_PK"
        Me.colFIRCPSAU_SAU_CODE_FK_PK.Name = "colFIRCPSAU_SAU_CODE_FK_PK"
        Me.colFIRCPSAU_SAU_CODE_FK_PK.Visible = True
        Me.colFIRCPSAU_SAU_CODE_FK_PK.VisibleIndex = 0
        Me.colFIRCPSAU_SAU_CODE_FK_PK.Width = 50
        '
        'colFIRCPSAU_SAU_CODE_FK_PK2
        '
        Me.colFIRCPSAU_SAU_CODE_FK_PK2.Caption = "Excipient"
        Me.colFIRCPSAU_SAU_CODE_FK_PK2.ColumnEdit = Me.lkup_FIRCPSAU
        Me.colFIRCPSAU_SAU_CODE_FK_PK2.FieldName = "FIRCPSAU_SAU_CODE_FK_PK"
        Me.colFIRCPSAU_SAU_CODE_FK_PK2.Name = "colFIRCPSAU_SAU_CODE_FK_PK2"
        Me.colFIRCPSAU_SAU_CODE_FK_PK2.Visible = True
        Me.colFIRCPSAU_SAU_CODE_FK_PK2.VisibleIndex = 1
        Me.colFIRCPSAU_SAU_CODE_FK_PK2.Width = 232
        '
        'lkup_FIRCPSAU
        '
        Me.lkup_FIRCPSAU.AutoHeight = False
        Me.lkup_FIRCPSAU.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FIRCPSAU.Name = "lkup_FIRCPSAU"
        '
        'GC3
        '
        Me.GC3.DataMember = "FIRCPSAC_FIRCP_SUBACT"
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
        Me.GC3.Location = New System.Drawing.Point(0, 0)
        Me.GC3.MainView = Me.GV3
        Me.GC3.Name = "GC3"
        Me.GC3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FIRCPSAC})
        Me.GC3.Size = New System.Drawing.Size(646, 137)
        Me.GC3.TabIndex = 2
        Me.GC3.Tag = "[EDIT][ADD]"
        Me.GC3.UseEmbeddedNavigator = True
        Me.GC3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV3})
        '
        'GV3
        '
        Me.GV3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFIRCPSAC_FIRCP_CODE_FK_PK, Me.colFIRCPSAC_SAC_CODE_FK_PK, Me.colFIRCPSAC_SAC_CODE_FK_PK2})
        Me.GV3.GridControl = Me.GC3
        Me.GV3.Name = "GV3"
        Me.GV3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV3.OptionsView.ShowGroupPanel = False
        '
        'colFIRCPSAC_FIRCP_CODE_FK_PK
        '
        Me.colFIRCPSAC_FIRCP_CODE_FK_PK.Caption = "FIRCPSAC_FIRCP_CODE_FK_PK"
        Me.colFIRCPSAC_FIRCP_CODE_FK_PK.FieldName = "FIRCPSAC_FIRCP_CODE_FK_PK"
        Me.colFIRCPSAC_FIRCP_CODE_FK_PK.Name = "colFIRCPSAC_FIRCP_CODE_FK_PK"
        '
        'colFIRCPSAC_SAC_CODE_FK_PK
        '
        Me.colFIRCPSAC_SAC_CODE_FK_PK.Caption = "Code"
        Me.colFIRCPSAC_SAC_CODE_FK_PK.FieldName = "FIRCPSAC_SAC_CODE_FK_PK"
        Me.colFIRCPSAC_SAC_CODE_FK_PK.Name = "colFIRCPSAC_SAC_CODE_FK_PK"
        Me.colFIRCPSAC_SAC_CODE_FK_PK.Visible = True
        Me.colFIRCPSAC_SAC_CODE_FK_PK.VisibleIndex = 0
        Me.colFIRCPSAC_SAC_CODE_FK_PK.Width = 52
        '
        'colFIRCPSAC_SAC_CODE_FK_PK2
        '
        Me.colFIRCPSAC_SAC_CODE_FK_PK2.Caption = "Substance active"
        Me.colFIRCPSAC_SAC_CODE_FK_PK2.ColumnEdit = Me.lkup_FIRCPSAC
        Me.colFIRCPSAC_SAC_CODE_FK_PK2.FieldName = "FIRCPSAC_SAC_CODE_FK_PK"
        Me.colFIRCPSAC_SAC_CODE_FK_PK2.Name = "colFIRCPSAC_SAC_CODE_FK_PK2"
        Me.colFIRCPSAC_SAC_CODE_FK_PK2.Visible = True
        Me.colFIRCPSAC_SAC_CODE_FK_PK2.VisibleIndex = 1
        Me.colFIRCPSAC_SAC_CODE_FK_PK2.Width = 557
        '
        'lkup_FIRCPSAC
        '
        Me.lkup_FIRCPSAC.AutoHeight = False
        Me.lkup_FIRCPSAC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FIRCPSAC.Name = "lkup_FIRCPSAC"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GC1)
        Me.Panel4.Controls.Add(Me.GC2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(646, 137)
        Me.Panel4.TabIndex = 22
        '
        'GC1
        '
        Me.GC1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC1.DataMember = "FIRCPCPH_FIRCP_CLPH"
        Me.GC1.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC1.EmbeddedNavigator.Name = ""
        Me.GC1.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC1.Location = New System.Drawing.Point(0, 0)
        Me.GC1.MainView = Me.GV1
        Me.GC1.Name = "GC1"
        Me.GC1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FIRCPCPH})
        Me.GC1.Size = New System.Drawing.Size(343, 137)
        Me.GC1.TabIndex = 2
        Me.GC1.Tag = "[EDIT][ADD]"
        Me.GC1.UseEmbeddedNavigator = True
        Me.GC1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFIRCPCPH_FIRCP_CODE_FK_PK, Me.colFIRCPCPH_CPH_CODE_FK_PK, Me.colFIRCPCPH_CPH_CODE_FK_PK2})
        Me.GV1.GridControl = Me.GC1
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV1.OptionsView.ShowGroupPanel = False
        '
        'colFIRCPCPH_FIRCP_CODE_FK_PK
        '
        Me.colFIRCPCPH_FIRCP_CODE_FK_PK.Caption = "FIRCPCPH_FIRCP_CODE_FK_PK"
        Me.colFIRCPCPH_FIRCP_CODE_FK_PK.FieldName = "FIRCPCPH_FIRCP_CODE_FK_PK"
        Me.colFIRCPCPH_FIRCP_CODE_FK_PK.Name = "colFIRCPCPH_FIRCP_CODE_FK_PK"
        '
        'colFIRCPCPH_CPH_CODE_FK_PK
        '
        Me.colFIRCPCPH_CPH_CODE_FK_PK.Caption = "Code"
        Me.colFIRCPCPH_CPH_CODE_FK_PK.FieldName = "FIRCPCPH_CPH_CODE_FK_PK"
        Me.colFIRCPCPH_CPH_CODE_FK_PK.Name = "colFIRCPCPH_CPH_CODE_FK_PK"
        Me.colFIRCPCPH_CPH_CODE_FK_PK.Visible = True
        Me.colFIRCPCPH_CPH_CODE_FK_PK.VisibleIndex = 0
        Me.colFIRCPCPH_CPH_CODE_FK_PK.Width = 50
        '
        'colFIRCPCPH_CPH_CODE_FK_PK2
        '
        Me.colFIRCPCPH_CPH_CODE_FK_PK2.Caption = "Classe pharmaco-thérapeutique"
        Me.colFIRCPCPH_CPH_CODE_FK_PK2.ColumnEdit = Me.lkup_FIRCPCPH
        Me.colFIRCPCPH_CPH_CODE_FK_PK2.FieldName = "FIRCPCPH_CPH_CODE_FK_PK"
        Me.colFIRCPCPH_CPH_CODE_FK_PK2.Name = "colFIRCPCPH_CPH_CODE_FK_PK2"
        Me.colFIRCPCPH_CPH_CODE_FK_PK2.Visible = True
        Me.colFIRCPCPH_CPH_CODE_FK_PK2.VisibleIndex = 1
        Me.colFIRCPCPH_CPH_CODE_FK_PK2.Width = 272
        '
        'lkup_FIRCPCPH
        '
        Me.lkup_FIRCPCPH.AutoHeight = False
        Me.lkup_FIRCPCPH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FIRCPCPH.Name = "lkup_FIRCPCPH"
        '
        'GC2
        '
        Me.GC2.DataMember = "FIRCPCCH_FIRCP_CLCH"
        Me.GC2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GC2.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC2.EmbeddedNavigator.Name = ""
        Me.GC2.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC2.Location = New System.Drawing.Point(343, 0)
        Me.GC2.MainView = Me.GV2
        Me.GC2.Name = "GC2"
        Me.GC2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FIRCPCCH})
        Me.GC2.Size = New System.Drawing.Size(303, 137)
        Me.GC2.TabIndex = 3
        Me.GC2.Tag = "[EDIT][ADD]"
        Me.GC2.UseEmbeddedNavigator = True
        Me.GC2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFIRCPCCH_FIRCP_CODE_FK_PK, Me.colFIRCPCCH_CCH_CODE_FK_PK, Me.colFIRCPCCH_CCH_CODE_FK_PK2})
        Me.GV2.GridControl = Me.GC2
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV2.OptionsView.ShowGroupPanel = False
        '
        'colFIRCPCCH_FIRCP_CODE_FK_PK
        '
        Me.colFIRCPCCH_FIRCP_CODE_FK_PK.Caption = "FIRCPCCH_FIRCP_CODE_FK_PK"
        Me.colFIRCPCCH_FIRCP_CODE_FK_PK.FieldName = "FIRCPCCH_FIRCP_CODE_FK_PK"
        Me.colFIRCPCCH_FIRCP_CODE_FK_PK.Name = "colFIRCPCCH_FIRCP_CODE_FK_PK"
        '
        'colFIRCPCCH_CCH_CODE_FK_PK
        '
        Me.colFIRCPCCH_CCH_CODE_FK_PK.Caption = "Code"
        Me.colFIRCPCCH_CCH_CODE_FK_PK.FieldName = "FIRCPCCH_CCH_CODE_FK_PK"
        Me.colFIRCPCCH_CCH_CODE_FK_PK.Name = "colFIRCPCCH_CCH_CODE_FK_PK"
        Me.colFIRCPCCH_CCH_CODE_FK_PK.Visible = True
        Me.colFIRCPCCH_CCH_CODE_FK_PK.VisibleIndex = 0
        Me.colFIRCPCCH_CCH_CODE_FK_PK.Width = 50
        '
        'colFIRCPCCH_CCH_CODE_FK_PK2
        '
        Me.colFIRCPCCH_CCH_CODE_FK_PK2.Caption = "Classe chimique"
        Me.colFIRCPCCH_CCH_CODE_FK_PK2.ColumnEdit = Me.lkup_FIRCPCCH
        Me.colFIRCPCCH_CCH_CODE_FK_PK2.FieldName = "FIRCPCCH_CCH_CODE_FK_PK"
        Me.colFIRCPCCH_CCH_CODE_FK_PK2.Name = "colFIRCPCCH_CCH_CODE_FK_PK2"
        Me.colFIRCPCCH_CCH_CODE_FK_PK2.Visible = True
        Me.colFIRCPCCH_CCH_CODE_FK_PK2.VisibleIndex = 1
        Me.colFIRCPCCH_CCH_CODE_FK_PK2.Width = 227
        '
        'lkup_FIRCPCCH
        '
        Me.lkup_FIRCPCCH.AutoHeight = False
        Me.lkup_FIRCPCCH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FIRCPCCH.Name = "lkup_FIRCPCCH"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Panel10)
        Me.XtraTabPage2.Controls.Add(Me.Panel9)
        Me.XtraTabPage2.Controls.Add(Me.Panel8)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(646, 407)
        Me.XtraTabPage2.Text = "Réf.officielles / Commentaires"
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Controls.Add(Me.Panel12)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(0, 274)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(646, 133)
        Me.Panel10.TabIndex = 41
        Me.Panel10.Tag = ""
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.MemoEdit3)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(0, 24)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(646, 109)
        Me.Panel11.TabIndex = 38
        Me.Panel11.Tag = "[ADD][EDIT]"
        '
        'MemoEdit3
        '
        Me.MemoEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_InteractionRCP, "FIRCP_INTERACTIONRCP.FIRCP_TXT", True))
        Me.MemoEdit3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoEdit3.Location = New System.Drawing.Point(0, 0)
        Me.MemoEdit3.Name = "MemoEdit3"
        Me.MemoEdit3.Size = New System.Drawing.Size(646, 109)
        Me.MemoEdit3.TabIndex = 36
        Me.MemoEdit3.Tag = ""
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.LabelControl7)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(646, 24)
        Me.Panel12.TabIndex = 37
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(2, 8)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl7.TabIndex = 19
        Me.LabelControl7.Text = "Texte"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.GC22)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 137)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(646, 137)
        Me.Panel9.TabIndex = 31
        '
        'GC22
        '
        Me.GC22.DataMember = "FIRCPAFS_FIRCP_AFSSAPS"
        Me.GC22.Dock = System.Windows.Forms.DockStyle.Top
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
        Me.GC22.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FIRCPAFS, Me.lkup_AFS})
        Me.GC22.Size = New System.Drawing.Size(646, 137)
        Me.GC22.TabIndex = 2
        Me.GC22.Tag = "[EDIT][ADD]"
        Me.GC22.UseEmbeddedNavigator = True
        Me.GC22.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV22})
        '
        'GV22
        '
        Me.GV22.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFIRCPAFS_FIRCP_CODE_FK_PK, Me.colFIRCPAFS_DATE_PK, Me.colFIRCPAFS_CDF_DOCUMENT_FK_PK, Me.colFIRCPAFS_SP_CODE_FK_PK})
        Me.GV22.GridControl = Me.GC22
        Me.GV22.Name = "GV22"
        Me.GV22.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV22.OptionsView.ShowGroupPanel = False
        '
        'colFIRCPAFS_FIRCP_CODE_FK_PK
        '
        Me.colFIRCPAFS_FIRCP_CODE_FK_PK.Caption = "FIRCPAFS_FIRCP_CODE_FK_PK"
        Me.colFIRCPAFS_FIRCP_CODE_FK_PK.FieldName = "FIRCPAFS_FIRCP_CODE_FK_PK"
        Me.colFIRCPAFS_FIRCP_CODE_FK_PK.Name = "colFIRCPAFS_FIRCP_CODE_FK_PK"
        '
        'colFIRCPAFS_DATE_PK
        '
        Me.colFIRCPAFS_DATE_PK.Caption = "Date"
        Me.colFIRCPAFS_DATE_PK.FieldName = "FIRCPAFS_DATE_PK"
        Me.colFIRCPAFS_DATE_PK.Name = "colFIRCPAFS_DATE_PK"
        Me.colFIRCPAFS_DATE_PK.Visible = True
        Me.colFIRCPAFS_DATE_PK.VisibleIndex = 1
        Me.colFIRCPAFS_DATE_PK.Width = 70
        '
        'colFIRCPAFS_CDF_DOCUMENT_FK_PK
        '
        Me.colFIRCPAFS_CDF_DOCUMENT_FK_PK.Caption = "Références officielles"
        Me.colFIRCPAFS_CDF_DOCUMENT_FK_PK.ColumnEdit = Me.lkup_FIRCPAFS
        Me.colFIRCPAFS_CDF_DOCUMENT_FK_PK.FieldName = "FIRCPAFS_CDF_DOCUMENT_FK_PK"
        Me.colFIRCPAFS_CDF_DOCUMENT_FK_PK.Name = "colFIRCPAFS_CDF_DOCUMENT_FK_PK"
        Me.colFIRCPAFS_CDF_DOCUMENT_FK_PK.Visible = True
        Me.colFIRCPAFS_CDF_DOCUMENT_FK_PK.VisibleIndex = 0
        Me.colFIRCPAFS_CDF_DOCUMENT_FK_PK.Width = 204
        '
        'lkup_FIRCPAFS
        '
        Me.lkup_FIRCPAFS.AutoHeight = False
        Me.lkup_FIRCPAFS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FIRCPAFS.Name = "lkup_FIRCPAFS"
        '
        'colFIRCPAFS_SP_CODE_FK_PK
        '
        Me.colFIRCPAFS_SP_CODE_FK_PK.Caption = "Spécialités"
        Me.colFIRCPAFS_SP_CODE_FK_PK.ColumnEdit = Me.lkup_AFS
        Me.colFIRCPAFS_SP_CODE_FK_PK.FieldName = "FIRCPAFS_SP_CODE_FK_PK"
        Me.colFIRCPAFS_SP_CODE_FK_PK.Name = "colFIRCPAFS_SP_CODE_FK_PK"
        Me.colFIRCPAFS_SP_CODE_FK_PK.Visible = True
        Me.colFIRCPAFS_SP_CODE_FK_PK.VisibleIndex = 2
        Me.colFIRCPAFS_SP_CODE_FK_PK.Width = 211
        '
        'lkup_AFS
        '
        Me.lkup_AFS.AutoHeight = False
        Me.lkup_AFS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_AFS.Name = "lkup_AFS"
        Me.lkup_AFS.NullText = ""
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.GC21)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(646, 137)
        Me.Panel8.TabIndex = 23
        '
        'GC21
        '
        Me.GC21.DataMember = "FIRCPCOM_FIRCP_COM"
        Me.GC21.Dock = System.Windows.Forms.DockStyle.Top
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
        Me.GC21.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Lkup_FIRCPCOM})
        Me.GC21.Size = New System.Drawing.Size(646, 137)
        Me.GC21.TabIndex = 2
        Me.GC21.Tag = "[EDIT][ADD]"
        Me.GC21.UseEmbeddedNavigator = True
        Me.GC21.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV21})
        '
        'GV21
        '
        Me.GV21.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFIRCPCOM_FIRCP_CODE_FK_PK, Me.colFIRCPCOM_CDF_COM_CODE_FK_PK, Me.colFIRCPCOM_NUMORD, Me.GridColumn13})
        Me.GV21.GridControl = Me.GC21
        Me.GV21.Name = "GV21"
        Me.GV21.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV21.OptionsView.ShowGroupPanel = False
        Me.GV21.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFIRCPCOM_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFIRCPCOM_FIRCP_CODE_FK_PK
        '
        Me.colFIRCPCOM_FIRCP_CODE_FK_PK.Caption = "FIRCPCOM_FIRCP_CODE_FK_PK"
        Me.colFIRCPCOM_FIRCP_CODE_FK_PK.FieldName = "FIRCPCOM_FIRCP_CODE_FK_PK"
        Me.colFIRCPCOM_FIRCP_CODE_FK_PK.Name = "colFIRCPCOM_FIRCP_CODE_FK_PK"
        '
        'colFIRCPCOM_CDF_COM_CODE_FK_PK
        '
        Me.colFIRCPCOM_CDF_COM_CODE_FK_PK.Caption = "Code"
        Me.colFIRCPCOM_CDF_COM_CODE_FK_PK.FieldName = "FIRCPCOM_CDF_COM_CODE_FK_PK"
        Me.colFIRCPCOM_CDF_COM_CODE_FK_PK.Name = "colFIRCPCOM_CDF_COM_CODE_FK_PK"
        Me.colFIRCPCOM_CDF_COM_CODE_FK_PK.Visible = True
        Me.colFIRCPCOM_CDF_COM_CODE_FK_PK.VisibleIndex = 0
        Me.colFIRCPCOM_CDF_COM_CODE_FK_PK.Width = 44
        '
        'colFIRCPCOM_NUMORD
        '
        Me.colFIRCPCOM_NUMORD.Caption = "N°"
        Me.colFIRCPCOM_NUMORD.FieldName = "FIRCPCOM_NUMORD"
        Me.colFIRCPCOM_NUMORD.Name = "colFIRCPCOM_NUMORD"
        Me.colFIRCPCOM_NUMORD.Visible = True
        Me.colFIRCPCOM_NUMORD.VisibleIndex = 2
        Me.colFIRCPCOM_NUMORD.Width = 50
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Commentaires"
        Me.GridColumn13.ColumnEdit = Me.Lkup_FIRCPCOM
        Me.GridColumn13.FieldName = "FIRCPCOM_CDF_COM_CODE_FK_PK"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 1
        Me.GridColumn13.Width = 513
        '
        'Lkup_FIRCPCOM
        '
        Me.Lkup_FIRCPCOM.AutoHeight = False
        Me.Lkup_FIRCPCOM.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lkup_FIRCPCOM.Name = "Lkup_FIRCPCOM"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.GC15)
        Me.Panel3.Controls.Add(Me.GC16)
        Me.Panel3.Location = New System.Drawing.Point(0, 274)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(649, 137)
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
        Me.GC15.Size = New System.Drawing.Size(346, 137)
        Me.GC15.TabIndex = 2
        Me.GC15.Tag = "[EDIT][ADD]"
        Me.GC15.UseEmbeddedNavigator = True
        Me.GC15.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV15})
        '
        'GV15
        '
        Me.GV15.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFPHCOPR_FPHCO_CODE_FK_PK, Me.colFPHCOPR_PR_CODE_FK_PK, Me.GridColumn5})
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
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Produit"
        Me.GridColumn5.ColumnEdit = Me.lkup_FPHCOPR
        Me.GridColumn5.FieldName = "FPHCOPR_PR_CODE_FK_PK"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 250
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
        Me.GC16.Size = New System.Drawing.Size(303, 137)
        Me.GC16.TabIndex = 3
        Me.GC16.Tag = "[EDIT][ADD]"
        Me.GC16.UseEmbeddedNavigator = True
        Me.GC16.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV16})
        '
        'GV16
        '
        Me.GV16.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFPHCOSP_FPHCO_CODE_FK_PK, Me.colFPHCOSP_SP_CODE_FK_PK, Me.GridColumn6})
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
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Spécialités"
        Me.GridColumn6.ColumnEdit = Me.lkup_FPHCOSP
        Me.GridColumn6.FieldName = "FPHCOSP_SP_CODE_FK_PK"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        Me.GridColumn6.Width = 207
        '
        'lkup_FPHCOSP
        '
        Me.lkup_FPHCOSP.AutoHeight = False
        Me.lkup_FPHCOSP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FPHCOSP.Name = "lkup_FPHCOSP"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.GC13)
        Me.Panel2.Controls.Add(Me.GC14)
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
        Me.GV13.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFPHCOSAC_FPHCO_CODE_FK_PK, Me.colFPHCOSAC_SAC_CODE_FK_PK, Me.GridColumn3})
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
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Substance active"
        Me.GridColumn3.ColumnEdit = Me.lkup_FPHCOSAC
        Me.GridColumn3.FieldName = "FPHCOSAC_SAC_CODE_FK_PK"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 250
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
        Me.GV14.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFPHCOSAU_FPHCO_CODE_FK_PK, Me.colFPHCOSAU_SAU_CODE_FK_PK, Me.GridColumn4})
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
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Excipient"
        Me.GridColumn4.ColumnEdit = Me.lkup_FPHCOSAU
        Me.GridColumn4.FieldName = "FPHCOSAU_SAU_CODE_FK_PK"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 207
        '
        'lkup_FPHCOSAU
        '
        Me.lkup_FPHCOSAU.AutoHeight = False
        Me.lkup_FPHCOSAU.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FPHCOSAU.Name = "lkup_FPHCOSAU"
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.Controls.Add(Me.GC11)
        Me.Panel5.Controls.Add(Me.GC12)
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
        Me.GV11.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFPHCOCPH_FPHCO_CODE_FK_PK, Me.colFPHCOCPH_CPH_CODE_FK_PK, Me.GridColumn1})
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
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Classe pharmaco-thérapeutique"
        Me.GridColumn1.ColumnEdit = Me.lkup_FPHCOCPH
        Me.GridColumn1.FieldName = "FPHCOCPH_CPH_CODE_FK_PK"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 250
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
        Me.GV12.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFPHCOCCH_FPHCO_CODE_FK_PK, Me.colFPHCOCCH_CCH_CODE_FK_PK, Me.GridColumn2})
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
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Classe chimique"
        Me.GridColumn2.ColumnEdit = Me.lkup_FPHCOCCH
        Me.GridColumn2.FieldName = "FPHCOCCH_CCH_CODE_FK_PK"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 207
        '
        'lkup_FPHCOCCH
        '
        Me.lkup_FPHCOCCH.AutoHeight = False
        Me.lkup_FPHCOCCH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FPHCOCCH.Name = "lkup_FPHCOCCH"
        '
        'FircpcpH_TA
        '
        Me.FircpcpH_TA.ClearBeforeFill = True
        '
        'FircpccH_TA
        '
        Me.FircpccH_TA.ClearBeforeFill = True
        '
        'FircpsaC_TA
        '
        Me.FircpsaC_TA.ClearBeforeFill = True
        '
        'FircpsaU_TA
        '
        Me.FircpsaU_TA.ClearBeforeFill = True
        '
        'FircppR_TA
        '
        Me.FircppR_TA.ClearBeforeFill = True
        '
        'FircpsP_TA
        '
        Me.FircpsP_TA.ClearBeforeFill = True
        '
        'FircpcoM_TA
        '
        Me.FircpcoM_TA.ClearBeforeFill = True
        '
        'FircpafS_TA
        '
        Me.FircpafS_TA.ClearBeforeFill = True
        '
        'Frm_InteractionsRCP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(780, 574)
        Me.Name = "Frm_InteractionsRCP"
        Me.Text = "Interactions RCP"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_InteractionRCP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.GC5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FIRCPPR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FIRCPSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.GC4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FIRCPSAU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FIRCPSAC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FIRCPCPH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FIRCPCCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        CType(Me.MemoEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        CType(Me.GC22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FIRCPAFS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_AFS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        CType(Me.GC21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lkup_FIRCPCOM, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FircP_TA As Theriaque.dsTheriaque_InteractionRCPTableAdapters.FIRCP_INTERACTIONRCPTableAdapter
    Friend WithEvents DsTheriaque_InteractionRCP As Theriaque.dsTheriaque_InteractionRCP
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GC15 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV15 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFPHCOPR_FPHCO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPHCOPR_PR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FPHCOPR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC16 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV16 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFPHCOSP_FPHCO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPHCOSP_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FPHCOSP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GC13 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFPHCOSAC_FPHCO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPHCOSAC_SAC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FPHCOSAC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC14 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFPHCOSAU_FPHCO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPHCOSAU_SAU_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FPHCOSAU As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GC11 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFPHCOCPH_FPHCO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPHCOCPH_CPH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FPHCOCPH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC12 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFPHCOCCH_FPHCO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPHCOCCH_CCH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FPHCOCCH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents GC3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents GC5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC6 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GC1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFIRCPCPH_FIRCP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRCPCPH_CPH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRCPCPH_CPH_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FIRCPCPH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FircpcpH_TA As Theriaque.dsTheriaque_InteractionRCPTableAdapters.FIRCPCPH_FIRCP_CLPHTableAdapter
    Friend WithEvents colFIRCPCCH_FIRCP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRCPCCH_CCH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRCPCCH_CCH_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FIRCPCCH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFIRCPSAC_FIRCP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRCPSAC_SAC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FircpccH_TA As Theriaque.dsTheriaque_InteractionRCPTableAdapters.FIRCPCCH_FIRCP_CLCHTableAdapter
    Friend WithEvents FircpsaC_TA As Theriaque.dsTheriaque_InteractionRCPTableAdapters.FIRCPSAC_FIRCP_SUBACTTableAdapter
    Friend WithEvents colFIRCPSAC_SAC_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FIRCPSAC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FircpsaU_TA As Theriaque.dsTheriaque_InteractionRCPTableAdapters.FIRCPSAU_FIRCP_SUBAUXTableAdapter
    Friend WithEvents colFIRCPSAU_FIRCP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRCPSAU_SAU_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRCPSAU_SAU_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FIRCPSAU As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFIRCPPR_FIRCP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRCPPR_PR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FIRCPPR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FircppR_TA As Theriaque.dsTheriaque_InteractionRCPTableAdapters.FIRCPPR_FIRCP_PRODTableAdapter
    Friend WithEvents FircpsP_TA As Theriaque.dsTheriaque_InteractionRCPTableAdapters.FIRCPSP_INTERACTRCP_SPECTableAdapter
    Friend WithEvents colFIRCPPR_PR_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRCPSP_FIRCP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRCPSP_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRCPSP_SP_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FIRCPSP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents GC21 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV21 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents GC22 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV22 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FircpcoM_TA As Theriaque.dsTheriaque_InteractionRCPTableAdapters.FIRCPCOM_FIRCP_COMTableAdapter
    Friend WithEvents colFIRCPCOM_FIRCP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRCPCOM_CDF_COM_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRCPCOM_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Lkup_FIRCPCOM As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFIRCPAFS_FIRCP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRCPAFS_DATE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FircpafS_TA As Theriaque.dsTheriaque_InteractionRCPTableAdapters.FIRCPAFS_FIRCP_AFSSAPSTableAdapter
    Friend WithEvents colFIRCPAFS_CDF_DOCUMENT_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FIRCPAFS As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lkup_AFS As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFIRCPAFS_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents MemoEdit3 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl

End Class
