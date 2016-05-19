<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Indication
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
        Me.FiN_TA = New Theriaque.dsTheriaque_IndicationTableAdapters.FIN_FICHEINDICTableAdapter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.DsTheriaque_Indication = New Theriaque.dsTheriaque_Indication
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.GC6 = New DevExpress.XtraGrid.GridControl
        Me.GV6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFINSP_FIN_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFINSP_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FINSP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC5 = New DevExpress.XtraGrid.GridControl
        Me.GV5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFINCH_FIN_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFINCH_CH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFINCH_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FINCH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.GC4 = New DevExpress.XtraGrid.GridControl
        Me.GV4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFINPR_FIN_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFINPR_PR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FINPR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC3 = New DevExpress.XtraGrid.GridControl
        Me.GV3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFINSAC_FIN_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFINSAC_SAC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FINSAC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.GC2 = New DevExpress.XtraGrid.GridControl
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFINCCH_FIN_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFINCCH_CCH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FINCCH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC1 = New DevExpress.XtraGrid.GridControl
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFINCPH_FIN_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFINCPH_CPH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FINCPH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.GC24 = New DevExpress.XtraGrid.GridControl
        Me.GV24 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFINCON_FIN_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFINCON_CDF_COIN_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFINCON_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FINCON = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC25 = New DevExpress.XtraGrid.GridControl
        Me.GV25 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.txtMaladiRareTexte = New DevExpress.XtraEditors.TextEdit
        Me.txtMaladieRareO_N = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GC23 = New DevExpress.XtraGrid.GridControl
        Me.GV23 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC22 = New DevExpress.XtraGrid.GridControl
        Me.GV22 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFINTY_FIN_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFINTY_CDF_TYIN_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFINTY_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FINTY = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lbCodification = New DevExpress.XtraEditors.LabelControl
        Me.lkupCodification = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.lkupFIN_NAIN = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.lkupFIN_NVIN = New DevExpress.XtraEditors.LookUpEdit
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.GC12 = New DevExpress.XtraGrid.GridControl
        Me.GV12 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFINBIB_FIN_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFINBIB_TEXTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpMemo = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.GC30 = New DevExpress.XtraGrid.GridControl
        Me.GV30 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFINAFS_FIN_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFINAFS_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FINAFS_SP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFINAFS_DATE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFINAFS_CDF_DOCUMENT_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FINAFS = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.GC29 = New DevExpress.XtraGrid.GridControl
        Me.GV29 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFINCO_FIN_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFINCO_CDF_COIN_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpCommentaire = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFINCO_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.btADDSMR = New DevExpress.XtraEditors.SimpleButton
        Me.GC28 = New DevExpress.XtraGrid.GridControl
        Me.GV28 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFINET_FIN_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFINET_CDF_ETIN_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpAgent = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFINET_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC27 = New DevExpress.XtraGrid.GridControl
        Me.GV27 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFINSMR_FIN_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFINSMR_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFINSMR_CDF_SMR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpSMR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFINSMR_DATE_SMR_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFINSMR_ATR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.btADDRemb = New DevExpress.XtraEditors.SimpleButton
        Me.GC26 = New DevExpress.XtraGrid.GridControl
        Me.GV26 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFINTSS_FIN_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFINTSS_PRE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpPRE = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFINTSS_DATE_APPLI_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFINTSS_CDF_TSS_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFINTSS_CDF_TSS_CODE_FK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FINTSS = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFINTSS_PRE_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FINTSS_CIP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.FinccH_TA = New Theriaque.dsTheriaque_IndicationTableAdapters.FINCCH_INDCCHTableAdapter
        Me.FincpH_TA = New Theriaque.dsTheriaque_IndicationTableAdapters.FINCPH_INDCPHTableAdapter
        Me.FinpR_TA = New Theriaque.dsTheriaque_IndicationTableAdapters.FINPR_INDPRODTableAdapter
        Me.FinsaC_TA = New Theriaque.dsTheriaque_IndicationTableAdapters.FINSAC_SUBACTableAdapter
        Me.FincH_TA = New Theriaque.dsTheriaque_IndicationTableAdapters.FINCH_INDCHOIXTableAdapter
        Me.FinsP_TA = New Theriaque.dsTheriaque_IndicationTableAdapters.FINSP_INDSPETableAdapter
        Me.FintY_TA = New Theriaque.dsTheriaque_IndicationTableAdapters.FINTY_FINDTYPETableAdapter
        Me.FincoN_TA = New Theriaque.dsTheriaque_IndicationTableAdapters.FINCON_FINDCOMMENT_NATURETableAdapter
        Me.FintsS_TA = New Theriaque.dsTheriaque_IndicationTableAdapters.FINTSS_INDICATION_TAUXSECUTableAdapter
        Me.FinsmR_TA = New Theriaque.dsTheriaque_IndicationTableAdapters.FINSMR_INDIC_SMR_ATRTableAdapter
        Me.FineT_TA = New Theriaque.dsTheriaque_IndicationTableAdapters.FINET_FINDETIOLTableAdapter
        Me.FincO_TA = New Theriaque.dsTheriaque_IndicationTableAdapters.FINCO_FINDCOMMENTTableAdapter
        Me.FinbiB_TA = New Theriaque.dsTheriaque_IndicationTableAdapters.FINBIB_REFERENCE_BIBLIOTableAdapter
        Me.FinafS_TA = New Theriaque.dsTheriaque_IndicationTableAdapters.FINAFS_FIN_AFSSAPSTableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_Indication, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.GC6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FINSP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FINCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.GC4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FINPR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FINSAC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FINCCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FINCPH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.GC24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FINCON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV25, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.txtMaladiRareTexte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaladieRareO_N.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.GC23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FINTY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.lkupCodification.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupFIN_NAIN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupFIN_NVIN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.GC12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FINAFS_SP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FINAFS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpCommentaire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        CType(Me.GC28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpAgent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpSMR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.GC26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpPRE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FINTSS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FINTSS_CIP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(847, 644)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.XtraTabControl1)
        Me.PanMain.Controls.Add(Me.GroupBox1)
        Me.PanMain.Location = New System.Drawing.Point(0, 67)
        Me.PanMain.Size = New System.Drawing.Size(729, 577)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(847, 67)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(847, 28)
        Me.Label1.Text = "Indication"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(305, 35)
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(35, 35)
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(729, 67)
        Me.Panel1.Size = New System.Drawing.Size(118, 577)
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Indication, "FIN_FICHEINDIC.FIN_DATEMJ", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(377, 34)
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Location = New System.Drawing.Point(0, 59)
        Me.GroupBox.Size = New System.Drawing.Size(847, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Indication, "FIN_FICHEINDIC.FIN_DATECR", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(92, 33)
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
        'FiN_TA
        '
        Me.FiN_TA.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(729, 42)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Indication, "FIN_FICHEINDIC.FIN_CODE_SQ_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(92, 13)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(135, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Tag = "[NOEDIT][NOADD]"
        '
        'DsTheriaque_Indication
        '
        Me.DsTheriaque_Indication.DataSetName = "dsTheriaque_Indication"
        Me.DsTheriaque_Indication.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 48)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(726, 529)
        Me.XtraTabControl1.TabIndex = 12
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panel7)
        Me.XtraTabPage1.Controls.Add(Me.Panel6)
        Me.XtraTabPage1.Controls.Add(Me.Panel4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(717, 498)
        Me.XtraTabPage1.Text = "Entités"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.GC6)
        Me.Panel7.Controls.Add(Me.GC5)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 332)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(717, 166)
        Me.Panel7.TabIndex = 25
        '
        'GC6
        '
        Me.GC6.DataMember = "FINSP_INDSPE"
        Me.GC6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC6.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC6.EmbeddedNavigator.Name = ""
        Me.GC6.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC6.Location = New System.Drawing.Point(380, 0)
        Me.GC6.MainView = Me.GV6
        Me.GC6.Name = "GC6"
        Me.GC6.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FINSP})
        Me.GC6.Size = New System.Drawing.Size(337, 166)
        Me.GC6.TabIndex = 3
        Me.GC6.Tag = "[EDIT][ADD]"
        Me.GC6.UseEmbeddedNavigator = True
        Me.GC6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV6})
        '
        'GV6
        '
        Me.GV6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFINSP_FIN_CODE_FK_PK, Me.colFINSP_SP_CODE_FK_PK, Me.GridColumn6})
        Me.GV6.GridControl = Me.GC6
        Me.GV6.Name = "GV6"
        Me.GV6.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV6.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV6.OptionsView.ShowGroupPanel = False
        '
        'colFINSP_FIN_CODE_FK_PK
        '
        Me.colFINSP_FIN_CODE_FK_PK.Caption = "FINSP_FIN_CODE_FK_PK"
        Me.colFINSP_FIN_CODE_FK_PK.FieldName = "FINSP_FIN_CODE_FK_PK"
        Me.colFINSP_FIN_CODE_FK_PK.Name = "colFINSP_FIN_CODE_FK_PK"
        '
        'colFINSP_SP_CODE_FK_PK
        '
        Me.colFINSP_SP_CODE_FK_PK.Caption = "Code"
        Me.colFINSP_SP_CODE_FK_PK.FieldName = "FINSP_SP_CODE_FK_PK"
        Me.colFINSP_SP_CODE_FK_PK.Name = "colFINSP_SP_CODE_FK_PK"
        Me.colFINSP_SP_CODE_FK_PK.Visible = True
        Me.colFINSP_SP_CODE_FK_PK.VisibleIndex = 0
        Me.colFINSP_SP_CODE_FK_PK.Width = 50
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Spécialités"
        Me.GridColumn6.ColumnEdit = Me.rp_FINSP
        Me.GridColumn6.FieldName = "FINSP_SP_CODE_FK_PK"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        Me.GridColumn6.Width = 230
        '
        'rp_FINSP
        '
        Me.rp_FINSP.AutoHeight = False
        Me.rp_FINSP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FINSP.Name = "rp_FINSP"
        '
        'GC5
        '
        Me.GC5.DataMember = "FINCH_INDCHOIX"
        Me.GC5.Dock = System.Windows.Forms.DockStyle.Left
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
        Me.GC5.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FINCH})
        Me.GC5.Size = New System.Drawing.Size(380, 166)
        Me.GC5.TabIndex = 2
        Me.GC5.Tag = "[EDIT][ADD]"
        Me.GC5.UseEmbeddedNavigator = True
        Me.GC5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV5})
        '
        'GV5
        '
        Me.GV5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFINCH_FIN_CODE_FK_PK, Me.colFINCH_CH_CODE_FK_PK, Me.colFINCH_NUMORD, Me.GridColumn5})
        Me.GV5.GridControl = Me.GC5
        Me.GV5.Name = "GV5"
        Me.GV5.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV5.OptionsView.ShowGroupPanel = False
        '
        'colFINCH_FIN_CODE_FK_PK
        '
        Me.colFINCH_FIN_CODE_FK_PK.Caption = "FINCH_FIN_CODE_FK_PK"
        Me.colFINCH_FIN_CODE_FK_PK.FieldName = "FINCH_FIN_CODE_FK_PK"
        Me.colFINCH_FIN_CODE_FK_PK.Name = "colFINCH_FIN_CODE_FK_PK"
        '
        'colFINCH_CH_CODE_FK_PK
        '
        Me.colFINCH_CH_CODE_FK_PK.Caption = "Code"
        Me.colFINCH_CH_CODE_FK_PK.FieldName = "FINCH_CH_CODE_FK_PK"
        Me.colFINCH_CH_CODE_FK_PK.Name = "colFINCH_CH_CODE_FK_PK"
        Me.colFINCH_CH_CODE_FK_PK.Visible = True
        Me.colFINCH_CH_CODE_FK_PK.VisibleIndex = 0
        Me.colFINCH_CH_CODE_FK_PK.Width = 50
        '
        'colFINCH_NUMORD
        '
        Me.colFINCH_NUMORD.Caption = "FINCH_NUMORD"
        Me.colFINCH_NUMORD.FieldName = "FINCH_NUMORD"
        Me.colFINCH_NUMORD.Name = "colFINCH_NUMORD"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Critères de choix"
        Me.GridColumn5.ColumnEdit = Me.rp_FINCH
        Me.GridColumn5.FieldName = "FINCH_CH_CODE_FK_PK"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 326
        '
        'rp_FINCH
        '
        Me.rp_FINCH.AutoHeight = False
        Me.rp_FINCH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FINCH.Name = "rp_FINCH"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GC4)
        Me.Panel6.Controls.Add(Me.GC3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 169)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(717, 163)
        Me.Panel6.TabIndex = 24
        '
        'GC4
        '
        Me.GC4.DataMember = "FINPR_INDPROD"
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
        Me.GC4.Location = New System.Drawing.Point(380, 0)
        Me.GC4.MainView = Me.GV4
        Me.GC4.Name = "GC4"
        Me.GC4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FINPR})
        Me.GC4.Size = New System.Drawing.Size(337, 163)
        Me.GC4.TabIndex = 3
        Me.GC4.Tag = "[EDIT][ADD]"
        Me.GC4.UseEmbeddedNavigator = True
        Me.GC4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV4})
        '
        'GV4
        '
        Me.GV4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFINPR_FIN_CODE_FK_PK, Me.colFINPR_PR_CODE_FK_PK, Me.GridColumn4})
        Me.GV4.GridControl = Me.GC4
        Me.GV4.Name = "GV4"
        Me.GV4.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV4.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV4.OptionsView.ShowGroupPanel = False
        '
        'colFINPR_FIN_CODE_FK_PK
        '
        Me.colFINPR_FIN_CODE_FK_PK.Caption = "FINPR_FIN_CODE_FK_PK"
        Me.colFINPR_FIN_CODE_FK_PK.FieldName = "FINPR_FIN_CODE_FK_PK"
        Me.colFINPR_FIN_CODE_FK_PK.Name = "colFINPR_FIN_CODE_FK_PK"
        '
        'colFINPR_PR_CODE_FK_PK
        '
        Me.colFINPR_PR_CODE_FK_PK.Caption = "Code"
        Me.colFINPR_PR_CODE_FK_PK.FieldName = "FINPR_PR_CODE_FK_PK"
        Me.colFINPR_PR_CODE_FK_PK.Name = "colFINPR_PR_CODE_FK_PK"
        Me.colFINPR_PR_CODE_FK_PK.Visible = True
        Me.colFINPR_PR_CODE_FK_PK.VisibleIndex = 0
        Me.colFINPR_PR_CODE_FK_PK.Width = 50
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Produit"
        Me.GridColumn4.ColumnEdit = Me.rp_FINPR
        Me.GridColumn4.FieldName = "FINPR_PR_CODE_FK_PK"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 232
        '
        'rp_FINPR
        '
        Me.rp_FINPR.AutoHeight = False
        Me.rp_FINPR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FINPR.Name = "rp_FINPR"
        '
        'GC3
        '
        Me.GC3.DataMember = "FINSAC_SUBAC"
        Me.GC3.Dock = System.Windows.Forms.DockStyle.Left
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
        Me.GC3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FINSAC})
        Me.GC3.Size = New System.Drawing.Size(380, 163)
        Me.GC3.TabIndex = 2
        Me.GC3.Tag = "[EDIT][ADD]"
        Me.GC3.UseEmbeddedNavigator = True
        Me.GC3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV3})
        '
        'GV3
        '
        Me.GV3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFINSAC_FIN_CODE_FK_PK, Me.colFINSAC_SAC_CODE_FK_PK, Me.GridColumn3})
        Me.GV3.GridControl = Me.GC3
        Me.GV3.Name = "GV3"
        Me.GV3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV3.OptionsView.ShowGroupPanel = False
        '
        'colFINSAC_FIN_CODE_FK_PK
        '
        Me.colFINSAC_FIN_CODE_FK_PK.Caption = "FINSAC_FIN_CODE_FK_PK"
        Me.colFINSAC_FIN_CODE_FK_PK.FieldName = "FINSAC_FIN_CODE_FK_PK"
        Me.colFINSAC_FIN_CODE_FK_PK.Name = "colFINSAC_FIN_CODE_FK_PK"
        '
        'colFINSAC_SAC_CODE_FK_PK
        '
        Me.colFINSAC_SAC_CODE_FK_PK.Caption = "Code"
        Me.colFINSAC_SAC_CODE_FK_PK.FieldName = "FINSAC_SAC_CODE_FK_PK"
        Me.colFINSAC_SAC_CODE_FK_PK.Name = "colFINSAC_SAC_CODE_FK_PK"
        Me.colFINSAC_SAC_CODE_FK_PK.Visible = True
        Me.colFINSAC_SAC_CODE_FK_PK.VisibleIndex = 0
        Me.colFINSAC_SAC_CODE_FK_PK.Width = 50
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Substance active"
        Me.GridColumn3.ColumnEdit = Me.rp_FINSAC
        Me.GridColumn3.FieldName = "FINSAC_SAC_CODE_FK_PK"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 324
        '
        'rp_FINSAC
        '
        Me.rp_FINSAC.AutoHeight = False
        Me.rp_FINSAC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FINSAC.Name = "rp_FINSAC"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GC2)
        Me.Panel4.Controls.Add(Me.GC1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(717, 169)
        Me.Panel4.TabIndex = 23
        '
        'GC2
        '
        Me.GC2.DataMember = "FINCCH_INDCCH"
        Me.GC2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC2.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC2.EmbeddedNavigator.Name = ""
        Me.GC2.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC2.Location = New System.Drawing.Point(380, 0)
        Me.GC2.MainView = Me.GV2
        Me.GC2.Name = "GC2"
        Me.GC2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FINCCH})
        Me.GC2.Size = New System.Drawing.Size(337, 169)
        Me.GC2.TabIndex = 3
        Me.GC2.Tag = "[EDIT][ADD]"
        Me.GC2.UseEmbeddedNavigator = True
        Me.GC2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFINCCH_FIN_CODE_FK_PK, Me.colFINCCH_CCH_CODE_FK_PK, Me.GridColumn2})
        Me.GV2.GridControl = Me.GC2
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV2.OptionsView.ShowGroupPanel = False
        '
        'colFINCCH_FIN_CODE_FK_PK
        '
        Me.colFINCCH_FIN_CODE_FK_PK.Caption = "FINCCH_FIN_CODE_FK_PK"
        Me.colFINCCH_FIN_CODE_FK_PK.FieldName = "FINCCH_FIN_CODE_FK_PK"
        Me.colFINCCH_FIN_CODE_FK_PK.Name = "colFINCCH_FIN_CODE_FK_PK"
        '
        'colFINCCH_CCH_CODE_FK_PK
        '
        Me.colFINCCH_CCH_CODE_FK_PK.Caption = "Code"
        Me.colFINCCH_CCH_CODE_FK_PK.FieldName = "FINCCH_CCH_CODE_FK_PK"
        Me.colFINCCH_CCH_CODE_FK_PK.Name = "colFINCCH_CCH_CODE_FK_PK"
        Me.colFINCCH_CCH_CODE_FK_PK.Visible = True
        Me.colFINCCH_CCH_CODE_FK_PK.VisibleIndex = 0
        Me.colFINCCH_CCH_CODE_FK_PK.Width = 50
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Classe chimique"
        Me.GridColumn2.ColumnEdit = Me.rp_FINCCH
        Me.GridColumn2.FieldName = "FINCCH_CCH_CODE_FK_PK"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 232
        '
        'rp_FINCCH
        '
        Me.rp_FINCCH.AutoHeight = False
        Me.rp_FINCCH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FINCCH.Name = "rp_FINCCH"
        '
        'GC1
        '
        Me.GC1.DataMember = "FINCPH_INDCPH"
        Me.GC1.Dock = System.Windows.Forms.DockStyle.Left
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
        Me.GC1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FINCPH})
        Me.GC1.Size = New System.Drawing.Size(380, 169)
        Me.GC1.TabIndex = 2
        Me.GC1.Tag = "[EDIT][ADD]"
        Me.GC1.UseEmbeddedNavigator = True
        Me.GC1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFINCPH_FIN_CODE_FK_PK, Me.colFINCPH_CPH_CODE_FK_PK, Me.GridColumn1})
        Me.GV1.GridControl = Me.GC1
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV1.OptionsView.ShowGroupPanel = False
        '
        'colFINCPH_FIN_CODE_FK_PK
        '
        Me.colFINCPH_FIN_CODE_FK_PK.Caption = "FINCPH_FIN_CODE_FK_PK"
        Me.colFINCPH_FIN_CODE_FK_PK.FieldName = "FINCPH_FIN_CODE_FK_PK"
        Me.colFINCPH_FIN_CODE_FK_PK.Name = "colFINCPH_FIN_CODE_FK_PK"
        '
        'colFINCPH_CPH_CODE_FK_PK
        '
        Me.colFINCPH_CPH_CODE_FK_PK.Caption = "Code"
        Me.colFINCPH_CPH_CODE_FK_PK.FieldName = "FINCPH_CPH_CODE_FK_PK"
        Me.colFINCPH_CPH_CODE_FK_PK.Name = "colFINCPH_CPH_CODE_FK_PK"
        Me.colFINCPH_CPH_CODE_FK_PK.Visible = True
        Me.colFINCPH_CPH_CODE_FK_PK.VisibleIndex = 0
        Me.colFINCPH_CPH_CODE_FK_PK.Width = 50
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Classe pharmaco-thérapeutique"
        Me.GridColumn1.ColumnEdit = Me.rp_FINCPH
        Me.GridColumn1.FieldName = "FINCPH_CPH_CODE_FK_PK"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 324
        '
        'rp_FINCPH
        '
        Me.rp_FINCPH.AutoHeight = False
        Me.rp_FINCPH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FINCPH.Name = "rp_FINCPH"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Panel5)
        Me.XtraTabPage2.Controls.Add(Me.Panel9)
        Me.XtraTabPage2.Controls.Add(Me.Panel3)
        Me.XtraTabPage2.Controls.Add(Me.Panel2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(717, 498)
        Me.XtraTabPage2.Text = "Nature d'indication / CIM10"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GC24)
        Me.Panel5.Controls.Add(Me.GC25)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 302)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(717, 144)
        Me.Panel5.TabIndex = 26
        '
        'GC24
        '
        Me.GC24.DataMember = "FINCON_FINDCOMMENT_NATURE"
        Me.GC24.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC24.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC24.EmbeddedNavigator.Name = ""
        Me.GC24.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC24.Location = New System.Drawing.Point(0, 0)
        Me.GC24.MainView = Me.GV24
        Me.GC24.Name = "GC24"
        Me.GC24.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FINCON})
        Me.GC24.Size = New System.Drawing.Size(363, 144)
        Me.GC24.TabIndex = 3
        Me.GC24.Tag = "[EDIT][ADD]"
        Me.GC24.UseEmbeddedNavigator = True
        Me.GC24.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV24})
        '
        'GV24
        '
        Me.GV24.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFINCON_FIN_CODE_FK_PK, Me.colFINCON_CDF_COIN_CODE_FK_PK, Me.colFINCON_NUMORD, Me.GridColumn12})
        Me.GV24.GridControl = Me.GC24
        Me.GV24.Name = "GV24"
        Me.GV24.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV24.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV24.OptionsView.ShowGroupPanel = False
        Me.GV24.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFINCON_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFINCON_FIN_CODE_FK_PK
        '
        Me.colFINCON_FIN_CODE_FK_PK.Caption = "FINCON_FIN_CODE_FK_PK"
        Me.colFINCON_FIN_CODE_FK_PK.FieldName = "FINCON_FIN_CODE_FK_PK"
        Me.colFINCON_FIN_CODE_FK_PK.Name = "colFINCON_FIN_CODE_FK_PK"
        '
        'colFINCON_CDF_COIN_CODE_FK_PK
        '
        Me.colFINCON_CDF_COIN_CODE_FK_PK.Caption = "Code"
        Me.colFINCON_CDF_COIN_CODE_FK_PK.FieldName = "FINCON_CDF_COIN_CODE_FK_PK"
        Me.colFINCON_CDF_COIN_CODE_FK_PK.Name = "colFINCON_CDF_COIN_CODE_FK_PK"
        Me.colFINCON_CDF_COIN_CODE_FK_PK.Visible = True
        Me.colFINCON_CDF_COIN_CODE_FK_PK.VisibleIndex = 0
        Me.colFINCON_CDF_COIN_CODE_FK_PK.Width = 50
        '
        'colFINCON_NUMORD
        '
        Me.colFINCON_NUMORD.Caption = "N°"
        Me.colFINCON_NUMORD.FieldName = "FINCON_NUMORD"
        Me.colFINCON_NUMORD.Name = "colFINCON_NUMORD"
        Me.colFINCON_NUMORD.Visible = True
        Me.colFINCON_NUMORD.VisibleIndex = 2
        Me.colFINCON_NUMORD.Width = 53
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Commentaire nature"
        Me.GridColumn12.ColumnEdit = Me.rp_FINCON
        Me.GridColumn12.FieldName = "FINCON_CDF_COIN_CODE_FK_PK"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 1
        Me.GridColumn12.Width = 248
        '
        'rp_FINCON
        '
        Me.rp_FINCON.AutoHeight = False
        Me.rp_FINCON.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FINCON.Name = "rp_FINCON"
        '
        'GC25
        '
        Me.GC25.Dock = System.Windows.Forms.DockStyle.Right
        Me.GC25.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GC25.EmbeddedNavigator.Name = ""
        Me.GC25.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC25.Location = New System.Drawing.Point(363, 0)
        Me.GC25.MainView = Me.GV25
        Me.GC25.Name = "GC25"
        Me.GC25.Size = New System.Drawing.Size(354, 144)
        Me.GC25.TabIndex = 3
        Me.GC25.Tag = "[EDIT][ADD]"
        Me.GC25.UseEmbeddedNavigator = True
        Me.GC25.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV25})
        '
        'GV25
        '
        Me.GV25.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.GV25.Appearance.Empty.Options.UseBackColor = True
        Me.GV25.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GV25.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV25.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV25.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV25.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV25.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV25.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV25.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV25.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV25.Appearance.Row.Options.UseBackColor = True
        Me.GV25.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV25.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV25.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn8})
        Me.GV25.GridControl = Me.GC25
        Me.GV25.Name = "GV25"
        Me.GV25.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV25.OptionsView.ShowGroupPanel = False
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Code"
        Me.GridColumn7.FieldName = "CIMCDF_CIM_CODE_FK_PK"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        Me.GridColumn7.Width = 50
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "CIM-10 Commentaire"
        Me.GridColumn8.FieldName = "CIM_LIBELLE_COURT"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        Me.GridColumn8.Width = 283
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.txtMaladiRareTexte)
        Me.Panel9.Controls.Add(Me.txtMaladieRareO_N)
        Me.Panel9.Controls.Add(Me.LabelControl6)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 446)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(717, 52)
        Me.Panel9.TabIndex = 29
        '
        'txtMaladiRareTexte
        '
        Me.txtMaladiRareTexte.Location = New System.Drawing.Point(114, 15)
        Me.txtMaladiRareTexte.Name = "txtMaladiRareTexte"
        Me.txtMaladiRareTexte.Size = New System.Drawing.Size(589, 20)
        Me.txtMaladiRareTexte.TabIndex = 33
        Me.txtMaladiRareTexte.Tag = "[NOEDIT][NOADD]"
        '
        'txtMaladieRareO_N
        '
        Me.txtMaladieRareO_N.Location = New System.Drawing.Point(75, 15)
        Me.txtMaladieRareO_N.Name = "txtMaladieRareO_N"
        Me.txtMaladieRareO_N.Size = New System.Drawing.Size(33, 20)
        Me.txtMaladieRareO_N.TabIndex = 32
        Me.txtMaladieRareO_N.Tag = "[NOEDIT][NOADD]"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(10, 18)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl6.TabIndex = 31
        Me.LabelControl6.Text = "Maladie rare"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GC23)
        Me.Panel3.Controls.Add(Me.GC22)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 95)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(717, 207)
        Me.Panel3.TabIndex = 25
        '
        'GC23
        '
        Me.GC23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC23.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GC23.EmbeddedNavigator.Name = ""
        Me.GC23.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC23.Location = New System.Drawing.Point(363, 0)
        Me.GC23.MainView = Me.GV23
        Me.GC23.Name = "GC23"
        Me.GC23.Size = New System.Drawing.Size(354, 207)
        Me.GC23.TabIndex = 3
        Me.GC23.Tag = "[EDIT][ADD]"
        Me.GC23.UseEmbeddedNavigator = True
        Me.GC23.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV23})
        '
        'GV23
        '
        Me.GV23.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.GV23.Appearance.Empty.Options.UseBackColor = True
        Me.GV23.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV23.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV23.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV23.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV23.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV23.Appearance.OddRow.Options.UseBackColor = True
        Me.GV23.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV23.Appearance.Row.Options.UseBackColor = True
        Me.GV23.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn9, Me.GridColumn10})
        Me.GV23.GridControl = Me.GC23
        Me.GV23.Name = "GV23"
        Me.GV23.OptionsBehavior.Editable = False
        Me.GV23.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV23.OptionsView.ShowGroupPanel = False
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Code"
        Me.GridColumn9.FieldName = "CIMCDF_CIM_CODE_FK_PK"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowFocus = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 0
        Me.GridColumn9.Width = 50
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "CIM-10 Nature indication"
        Me.GridColumn10.FieldName = "CIM_LIBELLE_COURT"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowFocus = False
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 1
        Me.GridColumn10.Width = 232
        '
        'GC22
        '
        Me.GC22.DataMember = "FINTY_FINDTYPE"
        Me.GC22.Dock = System.Windows.Forms.DockStyle.Left
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
        Me.GC22.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FINTY})
        Me.GC22.Size = New System.Drawing.Size(363, 207)
        Me.GC22.TabIndex = 3
        Me.GC22.Tag = "[EDIT][ADD]"
        Me.GC22.UseEmbeddedNavigator = True
        Me.GC22.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV22})
        '
        'GV22
        '
        Me.GV22.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFINTY_FIN_CODE_FK_PK, Me.colFINTY_CDF_TYIN_CODE_FK_PK, Me.colFINTY_NUMORD, Me.GridColumn11})
        Me.GV22.GridControl = Me.GC22
        Me.GV22.Name = "GV22"
        Me.GV22.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV22.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV22.OptionsView.ShowGroupPanel = False
        Me.GV22.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFINTY_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFINTY_FIN_CODE_FK_PK
        '
        Me.colFINTY_FIN_CODE_FK_PK.Caption = "FINTY_FIN_CODE_FK_PK"
        Me.colFINTY_FIN_CODE_FK_PK.FieldName = "FINTY_FIN_CODE_FK_PK"
        Me.colFINTY_FIN_CODE_FK_PK.Name = "colFINTY_FIN_CODE_FK_PK"
        '
        'colFINTY_CDF_TYIN_CODE_FK_PK
        '
        Me.colFINTY_CDF_TYIN_CODE_FK_PK.Caption = "Code"
        Me.colFINTY_CDF_TYIN_CODE_FK_PK.FieldName = "FINTY_CDF_TYIN_CODE_FK_PK"
        Me.colFINTY_CDF_TYIN_CODE_FK_PK.Name = "colFINTY_CDF_TYIN_CODE_FK_PK"
        Me.colFINTY_CDF_TYIN_CODE_FK_PK.Visible = True
        Me.colFINTY_CDF_TYIN_CODE_FK_PK.VisibleIndex = 0
        Me.colFINTY_CDF_TYIN_CODE_FK_PK.Width = 50
        '
        'colFINTY_NUMORD
        '
        Me.colFINTY_NUMORD.Caption = "N°"
        Me.colFINTY_NUMORD.FieldName = "FINTY_NUMORD"
        Me.colFINTY_NUMORD.Name = "colFINTY_NUMORD"
        Me.colFINTY_NUMORD.Visible = True
        Me.colFINTY_NUMORD.VisibleIndex = 2
        Me.colFINTY_NUMORD.Width = 49
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Type"
        Me.GridColumn11.ColumnEdit = Me.rp_FINTY
        Me.GridColumn11.FieldName = "FINTY_CDF_TYIN_CODE_FK_PK"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 1
        Me.GridColumn11.Width = 255
        '
        'rp_FINTY
        '
        Me.rp_FINTY.AutoHeight = False
        Me.rp_FINTY.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FINTY.Name = "rp_FINTY"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbCodification)
        Me.Panel2.Controls.Add(Me.lkupCodification)
        Me.Panel2.Controls.Add(Me.LabelControl5)
        Me.Panel2.Controls.Add(Me.lkupFIN_NAIN)
        Me.Panel2.Controls.Add(Me.LabelControl4)
        Me.Panel2.Controls.Add(Me.lkupFIN_NVIN)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(717, 95)
        Me.Panel2.TabIndex = 28
        Me.Panel2.Tag = ""
        '
        'lbCodification
        '
        Me.lbCodification.Location = New System.Drawing.Point(6, 65)
        Me.lbCodification.Name = "lbCodification"
        Me.lbCodification.Size = New System.Drawing.Size(118, 13)
        Me.lbCodification.TabIndex = 32
        Me.lbCodification.Text = "Code groupe d'indication"
        '
        'lkupCodification
        '
        Me.lkupCodification.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkupCodification.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Indication, "FIN_FICHEINDIC.FIN_CDF_T2A_CODE_FK_PK", True))
        Me.lkupCodification.Location = New System.Drawing.Point(130, 62)
        Me.lkupCodification.Name = "lkupCodification"
        Me.lkupCodification.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupCodification.Size = New System.Drawing.Size(573, 20)
        Me.lkupCodification.TabIndex = 31
        Me.lkupCodification.Tag = ""
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(23, 38)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl5.TabIndex = 30
        Me.LabelControl5.Text = "Nature de l'indication"
        '
        'lkupFIN_NAIN
        '
        Me.lkupFIN_NAIN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkupFIN_NAIN.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Indication, "FIN_FICHEINDIC.FIN_CDF_NAIN_CODE_FK_PK", True))
        Me.lkupFIN_NAIN.Location = New System.Drawing.Point(130, 35)
        Me.lkupFIN_NAIN.Name = "lkupFIN_NAIN"
        Me.lkupFIN_NAIN.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupFIN_NAIN.Size = New System.Drawing.Size(571, 20)
        Me.lkupFIN_NAIN.TabIndex = 29
        Me.lkupFIN_NAIN.Tag = ""
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(33, 12)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl4.TabIndex = 28
        Me.LabelControl4.Text = "Niveau d'indication"
        '
        'lkupFIN_NVIN
        '
        Me.lkupFIN_NVIN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkupFIN_NVIN.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Indication, "FIN_FICHEINDIC.FIN_CDF_NVIN_CODE_FK_PK", True))
        Me.lkupFIN_NVIN.Location = New System.Drawing.Point(130, 9)
        Me.lkupFIN_NVIN.Name = "lkupFIN_NVIN"
        Me.lkupFIN_NVIN.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupFIN_NVIN.Size = New System.Drawing.Size(571, 20)
        Me.lkupFIN_NVIN.TabIndex = 27
        Me.lkupFIN_NVIN.Tag = ""
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.Panel12)
        Me.XtraTabPage3.Controls.Add(Me.Panel11)
        Me.XtraTabPage3.Controls.Add(Me.Panel10)
        Me.XtraTabPage3.Controls.Add(Me.Panel8)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(500, 420)
        Me.XtraTabPage3.Text = "Taux de remboursement"
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.GC12)
        Me.Panel12.Controls.Add(Me.LabelControl8)
        Me.Panel12.Controls.Add(Me.GC30)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(0, 374)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(500, 46)
        Me.Panel12.TabIndex = 33
        '
        'GC12
        '
        Me.GC12.DataMember = "FINBIB_REFERENCE_BIBLIO"
        Me.GC12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC12.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC12.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC12.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC12.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC12.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC12.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC12.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC12.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC12.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC12.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC12.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC12.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC12.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC12.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC12.EmbeddedNavigator.Name = ""
        Me.GC12.EmbeddedNavigator.TextStringFormat = ""
        Me.GC12.Location = New System.Drawing.Point(0, 32)
        Me.GC12.MainView = Me.GV12
        Me.GC12.Name = "GC12"
        Me.GC12.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpMemo})
        Me.GC12.Size = New System.Drawing.Size(151, 14)
        Me.GC12.TabIndex = 56
        Me.GC12.UseEmbeddedNavigator = True
        Me.GC12.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV12})
        '
        'GV12
        '
        Me.GV12.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFINBIB_FIN_CODE_FK_PK, Me.colFINBIB_TEXTE})
        Me.GV12.GridControl = Me.GC12
        Me.GV12.GroupFormat = ""
        Me.GV12.GroupPanelText = " "
        Me.GV12.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GV12.Name = "GV12"
        Me.GV12.OptionsCustomization.AllowRowSizing = True
        Me.GV12.OptionsNavigation.AutoFocusNewRow = True
        Me.GV12.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV12.OptionsView.ShowColumnHeaders = False
        Me.GV12.OptionsView.ShowDetailButtons = False
        Me.GV12.OptionsView.ShowGroupPanel = False
        Me.GV12.OptionsView.ShowHorzLines = False
        Me.GV12.OptionsView.ShowIndicator = False
        Me.GV12.RowHeight = 90
        Me.GV12.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colFINBIB_FIN_CODE_FK_PK
        '
        Me.colFINBIB_FIN_CODE_FK_PK.Caption = "FINBIB_FIN_CODE_FK_PK"
        Me.colFINBIB_FIN_CODE_FK_PK.FieldName = "FINBIB_FIN_CODE_FK_PK"
        Me.colFINBIB_FIN_CODE_FK_PK.Name = "colFINBIB_FIN_CODE_FK_PK"
        '
        'colFINBIB_TEXTE
        '
        Me.colFINBIB_TEXTE.Caption = "FINBIB_TEXTE"
        Me.colFINBIB_TEXTE.ColumnEdit = Me.rpMemo
        Me.colFINBIB_TEXTE.FieldName = "FINBIB_TEXTE"
        Me.colFINBIB_TEXTE.Name = "colFINBIB_TEXTE"
        Me.colFINBIB_TEXTE.Visible = True
        Me.colFINBIB_TEXTE.VisibleIndex = 0
        '
        'rpMemo
        '
        Me.rpMemo.Name = "rpMemo"
        '
        'LabelControl8
        '
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl8.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl8.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LabelControl8.Size = New System.Drawing.Size(151, 32)
        Me.LabelControl8.TabIndex = 55
        Me.LabelControl8.Text = "Réf. Bibliographique"
        '
        'GC30
        '
        Me.GC30.DataMember = "FINAFS_FIN_AFSSAPS"
        Me.GC30.Dock = System.Windows.Forms.DockStyle.Right
        Me.GC30.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC30.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC30.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC30.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC30.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC30.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC30.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC30.EmbeddedNavigator.Name = ""
        Me.GC30.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC30.Location = New System.Drawing.Point(151, 0)
        Me.GC30.MainView = Me.GV30
        Me.GC30.Name = "GC30"
        Me.GC30.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FINAFS, Me.rp_FINAFS_SP})
        Me.GC30.Size = New System.Drawing.Size(349, 46)
        Me.GC30.TabIndex = 53
        Me.GC30.Tag = "[EDIT][ADD]"
        Me.GC30.UseEmbeddedNavigator = True
        Me.GC30.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV30})
        '
        'GV30
        '
        Me.GV30.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFINAFS_FIN_CODE_FK_PK, Me.colFINAFS_SP_CODE_FK_PK, Me.colFINAFS_DATE_PK, Me.colFINAFS_CDF_DOCUMENT_FK_PK})
        Me.GV30.GridControl = Me.GC30
        Me.GV30.Name = "GV30"
        Me.GV30.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV30.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV30.OptionsView.ShowGroupPanel = False
        '
        'colFINAFS_FIN_CODE_FK_PK
        '
        Me.colFINAFS_FIN_CODE_FK_PK.Caption = "FINAFS_FIN_CODE_FK_PK"
        Me.colFINAFS_FIN_CODE_FK_PK.FieldName = "FINAFS_FIN_CODE_FK_PK"
        Me.colFINAFS_FIN_CODE_FK_PK.Name = "colFINAFS_FIN_CODE_FK_PK"
        '
        'colFINAFS_SP_CODE_FK_PK
        '
        Me.colFINAFS_SP_CODE_FK_PK.Caption = "Spécialité"
        Me.colFINAFS_SP_CODE_FK_PK.ColumnEdit = Me.rp_FINAFS_SP
        Me.colFINAFS_SP_CODE_FK_PK.FieldName = "FINAFS_SP_CODE_FK_PK"
        Me.colFINAFS_SP_CODE_FK_PK.Name = "colFINAFS_SP_CODE_FK_PK"
        Me.colFINAFS_SP_CODE_FK_PK.Visible = True
        Me.colFINAFS_SP_CODE_FK_PK.VisibleIndex = 2
        '
        'rp_FINAFS_SP
        '
        Me.rp_FINAFS_SP.AutoHeight = False
        Me.rp_FINAFS_SP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FINAFS_SP.Name = "rp_FINAFS_SP"
        Me.rp_FINAFS_SP.NullText = ""
        '
        'colFINAFS_DATE_PK
        '
        Me.colFINAFS_DATE_PK.Caption = "Date"
        Me.colFINAFS_DATE_PK.FieldName = "FINAFS_DATE_PK"
        Me.colFINAFS_DATE_PK.Name = "colFINAFS_DATE_PK"
        Me.colFINAFS_DATE_PK.Visible = True
        Me.colFINAFS_DATE_PK.VisibleIndex = 1
        '
        'colFINAFS_CDF_DOCUMENT_FK_PK
        '
        Me.colFINAFS_CDF_DOCUMENT_FK_PK.Caption = "Références officielles"
        Me.colFINAFS_CDF_DOCUMENT_FK_PK.ColumnEdit = Me.rp_FINAFS
        Me.colFINAFS_CDF_DOCUMENT_FK_PK.FieldName = "FINAFS_CDF_DOCUMENT_FK_PK"
        Me.colFINAFS_CDF_DOCUMENT_FK_PK.Name = "colFINAFS_CDF_DOCUMENT_FK_PK"
        Me.colFINAFS_CDF_DOCUMENT_FK_PK.Visible = True
        Me.colFINAFS_CDF_DOCUMENT_FK_PK.VisibleIndex = 0
        '
        'rp_FINAFS
        '
        Me.rp_FINAFS.AutoHeight = False
        Me.rp_FINAFS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FINAFS.Name = "rp_FINAFS"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.MemoEdit1)
        Me.Panel11.Controls.Add(Me.LabelControl7)
        Me.Panel11.Controls.Add(Me.GC29)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 247)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(500, 127)
        Me.Panel11.TabIndex = 32
        '
        'MemoEdit1
        '
        Me.MemoEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Indication, "FIN_FICHEINDIC.FIN_TEXTE", True))
        Me.MemoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoEdit1.Location = New System.Drawing.Point(368, 30)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(132, 97)
        Me.MemoEdit1.TabIndex = 54
        '
        'LabelControl7
        '
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl7.Location = New System.Drawing.Point(368, 0)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LabelControl7.Size = New System.Drawing.Size(132, 30)
        Me.LabelControl7.TabIndex = 55
        Me.LabelControl7.Text = "Texte"
        '
        'GC29
        '
        Me.GC29.DataMember = "FINCO_FINDCOMMENT"
        Me.GC29.Dock = System.Windows.Forms.DockStyle.Left
        Me.GC29.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC29.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC29.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC29.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC29.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC29.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC29.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC29.EmbeddedNavigator.Name = ""
        Me.GC29.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC29.Location = New System.Drawing.Point(0, 0)
        Me.GC29.MainView = Me.GV29
        Me.GC29.Name = "GC29"
        Me.GC29.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpCommentaire})
        Me.GC29.Size = New System.Drawing.Size(368, 127)
        Me.GC29.TabIndex = 53
        Me.GC29.Tag = "[EDIT][ADD]"
        Me.GC29.UseEmbeddedNavigator = True
        Me.GC29.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV29})
        '
        'GV29
        '
        Me.GV29.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFINCO_FIN_CODE_FK_PK, Me.colFINCO_CDF_COIN_CODE_FK_PK, Me.colFINCO_NUMORD})
        Me.GV29.GridControl = Me.GC29
        Me.GV29.Name = "GV29"
        Me.GV29.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV29.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV29.OptionsView.ShowGroupPanel = False
        '
        'colFINCO_FIN_CODE_FK_PK
        '
        Me.colFINCO_FIN_CODE_FK_PK.Caption = "FINCO_FIN_CODE_FK_PK"
        Me.colFINCO_FIN_CODE_FK_PK.FieldName = "FINCO_FIN_CODE_FK_PK"
        Me.colFINCO_FIN_CODE_FK_PK.Name = "colFINCO_FIN_CODE_FK_PK"
        '
        'colFINCO_CDF_COIN_CODE_FK_PK
        '
        Me.colFINCO_CDF_COIN_CODE_FK_PK.Caption = "Commentaires"
        Me.colFINCO_CDF_COIN_CODE_FK_PK.ColumnEdit = Me.rpCommentaire
        Me.colFINCO_CDF_COIN_CODE_FK_PK.FieldName = "FINCO_CDF_COIN_CODE_FK_PK"
        Me.colFINCO_CDF_COIN_CODE_FK_PK.Name = "colFINCO_CDF_COIN_CODE_FK_PK"
        Me.colFINCO_CDF_COIN_CODE_FK_PK.Visible = True
        Me.colFINCO_CDF_COIN_CODE_FK_PK.VisibleIndex = 0
        Me.colFINCO_CDF_COIN_CODE_FK_PK.Width = 316
        '
        'rpCommentaire
        '
        Me.rpCommentaire.AutoHeight = False
        Me.rpCommentaire.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpCommentaire.Name = "rpCommentaire"
        '
        'colFINCO_NUMORD
        '
        Me.colFINCO_NUMORD.Caption = "N°"
        Me.colFINCO_NUMORD.FieldName = "FINCO_NUMORD"
        Me.colFINCO_NUMORD.Name = "colFINCO_NUMORD"
        Me.colFINCO_NUMORD.Visible = True
        Me.colFINCO_NUMORD.VisibleIndex = 1
        Me.colFINCO_NUMORD.Width = 45
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.btADDSMR)
        Me.Panel10.Controls.Add(Me.GC28)
        Me.Panel10.Controls.Add(Me.GC27)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 120)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(500, 127)
        Me.Panel10.TabIndex = 31
        '
        'btADDSMR
        '
        Me.btADDSMR.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btADDSMR.Location = New System.Drawing.Point(160, 106)
        Me.btADDSMR.Name = "btADDSMR"
        Me.btADDSMR.Size = New System.Drawing.Size(32, 19)
        Me.btADDSMR.TabIndex = 51
        Me.btADDSMR.Tag = "[EDIT][ADD]"
        Me.btADDSMR.Text = "..."
        '
        'GC28
        '
        Me.GC28.DataMember = "FINET_FINDETIOL"
        Me.GC28.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC28.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC28.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC28.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC28.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC28.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC28.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC28.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC28.EmbeddedNavigator.Name = ""
        Me.GC28.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC28.Location = New System.Drawing.Point(368, 0)
        Me.GC28.MainView = Me.GV28
        Me.GC28.Name = "GC28"
        Me.GC28.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpAgent})
        Me.GC28.Size = New System.Drawing.Size(132, 127)
        Me.GC28.TabIndex = 52
        Me.GC28.Tag = "[EDIT][ADD]"
        Me.GC28.UseEmbeddedNavigator = True
        Me.GC28.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV28})
        '
        'GV28
        '
        Me.GV28.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFINET_FIN_CODE_FK_PK, Me.colFINET_CDF_ETIN_CODE_FK_PK, Me.colFINET_NUMORD})
        Me.GV28.GridControl = Me.GC28
        Me.GV28.Name = "GV28"
        Me.GV28.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV28.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV28.OptionsView.ShowGroupPanel = False
        Me.GV28.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFINET_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFINET_FIN_CODE_FK_PK
        '
        Me.colFINET_FIN_CODE_FK_PK.Caption = "FINET_FIN_CODE_FK_PK"
        Me.colFINET_FIN_CODE_FK_PK.FieldName = "FINET_FIN_CODE_FK_PK"
        Me.colFINET_FIN_CODE_FK_PK.Name = "colFINET_FIN_CODE_FK_PK"
        '
        'colFINET_CDF_ETIN_CODE_FK_PK
        '
        Me.colFINET_CDF_ETIN_CODE_FK_PK.Caption = "Agent/Etiologie"
        Me.colFINET_CDF_ETIN_CODE_FK_PK.ColumnEdit = Me.rpAgent
        Me.colFINET_CDF_ETIN_CODE_FK_PK.FieldName = "FINET_CDF_ETIN_CODE_FK_PK"
        Me.colFINET_CDF_ETIN_CODE_FK_PK.Name = "colFINET_CDF_ETIN_CODE_FK_PK"
        Me.colFINET_CDF_ETIN_CODE_FK_PK.Visible = True
        Me.colFINET_CDF_ETIN_CODE_FK_PK.VisibleIndex = 0
        Me.colFINET_CDF_ETIN_CODE_FK_PK.Width = 257
        '
        'rpAgent
        '
        Me.rpAgent.AutoHeight = False
        Me.rpAgent.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpAgent.Name = "rpAgent"
        Me.rpAgent.NullText = ""
        '
        'colFINET_NUMORD
        '
        Me.colFINET_NUMORD.Caption = "N°"
        Me.colFINET_NUMORD.FieldName = "FINET_NUMORD"
        Me.colFINET_NUMORD.Name = "colFINET_NUMORD"
        Me.colFINET_NUMORD.Visible = True
        Me.colFINET_NUMORD.VisibleIndex = 1
        Me.colFINET_NUMORD.Width = 57
        '
        'GC27
        '
        Me.GC27.DataMember = "FINSMR_INDIC_SMR_ATR"
        Me.GC27.Dock = System.Windows.Forms.DockStyle.Left
        Me.GC27.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC27.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC27.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC27.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC27.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC27.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC27.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC27.EmbeddedNavigator.Name = ""
        Me.GC27.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC27.Location = New System.Drawing.Point(0, 0)
        Me.GC27.MainView = Me.GV27
        Me.GC27.Name = "GC27"
        Me.GC27.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpSMR})
        Me.GC27.Size = New System.Drawing.Size(368, 127)
        Me.GC27.TabIndex = 53
        Me.GC27.Tag = "[EDIT][ADD]"
        Me.GC27.UseEmbeddedNavigator = True
        Me.GC27.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV27})
        '
        'GV27
        '
        Me.GV27.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFINSMR_FIN_CODE_FK_PK, Me.colFINSMR_SP_CODE_FK_PK, Me.colFINSMR_CDF_SMR_CODE_FK_PK, Me.colFINSMR_DATE_SMR_PK, Me.colFINSMR_ATR_CODE_FK_PK})
        Me.GV27.GridControl = Me.GC27
        Me.GV27.Name = "GV27"
        Me.GV27.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV27.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV27.OptionsView.ShowGroupPanel = False
        '
        'colFINSMR_FIN_CODE_FK_PK
        '
        Me.colFINSMR_FIN_CODE_FK_PK.Caption = "FINSMR_FIN_CODE_FK_PK"
        Me.colFINSMR_FIN_CODE_FK_PK.FieldName = "FINSMR_FIN_CODE_FK_PK"
        Me.colFINSMR_FIN_CODE_FK_PK.Name = "colFINSMR_FIN_CODE_FK_PK"
        '
        'colFINSMR_SP_CODE_FK_PK
        '
        Me.colFINSMR_SP_CODE_FK_PK.Caption = "Spécialité"
        Me.colFINSMR_SP_CODE_FK_PK.FieldName = "FINSMR_SP_CODE_FK_PK"
        Me.colFINSMR_SP_CODE_FK_PK.Name = "colFINSMR_SP_CODE_FK_PK"
        Me.colFINSMR_SP_CODE_FK_PK.Visible = True
        Me.colFINSMR_SP_CODE_FK_PK.VisibleIndex = 3
        '
        'colFINSMR_CDF_SMR_CODE_FK_PK
        '
        Me.colFINSMR_CDF_SMR_CODE_FK_PK.Caption = "SMR"
        Me.colFINSMR_CDF_SMR_CODE_FK_PK.ColumnEdit = Me.rpSMR
        Me.colFINSMR_CDF_SMR_CODE_FK_PK.FieldName = "FINSMR_CDF_SMR_CODE_FK_PK"
        Me.colFINSMR_CDF_SMR_CODE_FK_PK.Name = "colFINSMR_CDF_SMR_CODE_FK_PK"
        Me.colFINSMR_CDF_SMR_CODE_FK_PK.Visible = True
        Me.colFINSMR_CDF_SMR_CODE_FK_PK.VisibleIndex = 0
        '
        'rpSMR
        '
        Me.rpSMR.AutoHeight = False
        Me.rpSMR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpSMR.Name = "rpSMR"
        '
        'colFINSMR_DATE_SMR_PK
        '
        Me.colFINSMR_DATE_SMR_PK.Caption = "Date"
        Me.colFINSMR_DATE_SMR_PK.FieldName = "FINSMR_DATE_SMR_PK"
        Me.colFINSMR_DATE_SMR_PK.Name = "colFINSMR_DATE_SMR_PK"
        Me.colFINSMR_DATE_SMR_PK.Visible = True
        Me.colFINSMR_DATE_SMR_PK.VisibleIndex = 1
        '
        'colFINSMR_ATR_CODE_FK_PK
        '
        Me.colFINSMR_ATR_CODE_FK_PK.Caption = "Avis"
        Me.colFINSMR_ATR_CODE_FK_PK.FieldName = "FINSMR_ATR_CODE_FK_PK"
        Me.colFINSMR_ATR_CODE_FK_PK.Name = "colFINSMR_ATR_CODE_FK_PK"
        Me.colFINSMR_ATR_CODE_FK_PK.Visible = True
        Me.colFINSMR_ATR_CODE_FK_PK.VisibleIndex = 2
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.btADDRemb)
        Me.Panel8.Controls.Add(Me.GC26)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(500, 120)
        Me.Panel8.TabIndex = 30
        '
        'btADDRemb
        '
        Me.btADDRemb.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btADDRemb.Location = New System.Drawing.Point(160, 100)
        Me.btADDRemb.Name = "btADDRemb"
        Me.btADDRemb.Size = New System.Drawing.Size(32, 19)
        Me.btADDRemb.TabIndex = 51
        Me.btADDRemb.Tag = "[EDIT][ADD]"
        Me.btADDRemb.Text = "..."
        '
        'GC26
        '
        Me.GC26.DataMember = "FINTSS_INDICATION_TAUXSECU"
        Me.GC26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC26.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC26.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC26.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC26.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC26.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC26.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC26.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC26.EmbeddedNavigator.Name = ""
        Me.GC26.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC26.Location = New System.Drawing.Point(0, 0)
        Me.GC26.MainView = Me.GV26
        Me.GC26.Name = "GC26"
        Me.GC26.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FINTSS, Me.rp_FINTSS_CIP, Me.rpPRE})
        Me.GC26.Size = New System.Drawing.Size(500, 120)
        Me.GC26.TabIndex = 3
        Me.GC26.Tag = "[EDIT][ADD]"
        Me.GC26.UseEmbeddedNavigator = True
        Me.GC26.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV26})
        '
        'GV26
        '
        Me.GV26.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFINTSS_FIN_CODE_FK_PK, Me.colFINTSS_PRE_CODE_FK_PK, Me.colFINTSS_DATE_APPLI_PK, Me.colFINTSS_CDF_TSS_CODE_FK, Me.colFINTSS_CDF_TSS_CODE_FK2, Me.colFINTSS_PRE_CODE_FK_PK2, Me.GridColumn13})
        Me.GV26.GridControl = Me.GC26
        Me.GV26.Name = "GV26"
        Me.GV26.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV26.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV26.OptionsView.ShowGroupPanel = False
        '
        'colFINTSS_FIN_CODE_FK_PK
        '
        Me.colFINTSS_FIN_CODE_FK_PK.Caption = "FINTSS_FIN_CODE_FK_PK"
        Me.colFINTSS_FIN_CODE_FK_PK.FieldName = "FINTSS_FIN_CODE_FK_PK"
        Me.colFINTSS_FIN_CODE_FK_PK.Name = "colFINTSS_FIN_CODE_FK_PK"
        '
        'colFINTSS_PRE_CODE_FK_PK
        '
        Me.colFINTSS_PRE_CODE_FK_PK.Caption = "Code SP"
        Me.colFINTSS_PRE_CODE_FK_PK.ColumnEdit = Me.rpPRE
        Me.colFINTSS_PRE_CODE_FK_PK.FieldName = "FINTSS_PRE_CODE_FK_PK"
        Me.colFINTSS_PRE_CODE_FK_PK.Name = "colFINTSS_PRE_CODE_FK_PK"
        Me.colFINTSS_PRE_CODE_FK_PK.OptionsColumn.AllowEdit = False
        Me.colFINTSS_PRE_CODE_FK_PK.Width = 171
        '
        'rpPRE
        '
        Me.rpPRE.AutoHeight = False
        Me.rpPRE.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpPRE.Name = "rpPRE"
        '
        'colFINTSS_DATE_APPLI_PK
        '
        Me.colFINTSS_DATE_APPLI_PK.Caption = "Date"
        Me.colFINTSS_DATE_APPLI_PK.FieldName = "FINTSS_DATE_APPLI_PK"
        Me.colFINTSS_DATE_APPLI_PK.Name = "colFINTSS_DATE_APPLI_PK"
        Me.colFINTSS_DATE_APPLI_PK.OptionsColumn.AllowEdit = False
        Me.colFINTSS_DATE_APPLI_PK.Visible = True
        Me.colFINTSS_DATE_APPLI_PK.VisibleIndex = 3
        Me.colFINTSS_DATE_APPLI_PK.Width = 126
        '
        'colFINTSS_CDF_TSS_CODE_FK
        '
        Me.colFINTSS_CDF_TSS_CODE_FK.Caption = "FINTSS_CDF_TSS_CODE_FK"
        Me.colFINTSS_CDF_TSS_CODE_FK.FieldName = "FINTSS_CDF_TSS_CODE_FK"
        Me.colFINTSS_CDF_TSS_CODE_FK.Name = "colFINTSS_CDF_TSS_CODE_FK"
        '
        'colFINTSS_CDF_TSS_CODE_FK2
        '
        Me.colFINTSS_CDF_TSS_CODE_FK2.Caption = "Taux de remboursement"
        Me.colFINTSS_CDF_TSS_CODE_FK2.ColumnEdit = Me.rp_FINTSS
        Me.colFINTSS_CDF_TSS_CODE_FK2.FieldName = "FINTSS_CDF_TSS_CODE_FK"
        Me.colFINTSS_CDF_TSS_CODE_FK2.Name = "colFINTSS_CDF_TSS_CODE_FK2"
        Me.colFINTSS_CDF_TSS_CODE_FK2.OptionsColumn.AllowEdit = False
        Me.colFINTSS_CDF_TSS_CODE_FK2.Visible = True
        Me.colFINTSS_CDF_TSS_CODE_FK2.VisibleIndex = 2
        Me.colFINTSS_CDF_TSS_CODE_FK2.Width = 215
        '
        'rp_FINTSS
        '
        Me.rp_FINTSS.AutoHeight = False
        Me.rp_FINTSS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FINTSS.Name = "rp_FINTSS"
        '
        'colFINTSS_PRE_CODE_FK_PK2
        '
        Me.colFINTSS_PRE_CODE_FK_PK2.Caption = "Code CIP"
        Me.colFINTSS_PRE_CODE_FK_PK2.FieldName = "FINTSS_PRE_CODE_FK_PK"
        Me.colFINTSS_PRE_CODE_FK_PK2.Name = "colFINTSS_PRE_CODE_FK_PK2"
        Me.colFINTSS_PRE_CODE_FK_PK2.OptionsColumn.AllowEdit = False
        Me.colFINTSS_PRE_CODE_FK_PK2.Visible = True
        Me.colFINTSS_PRE_CODE_FK_PK2.VisibleIndex = 0
        Me.colFINTSS_PRE_CODE_FK_PK2.Width = 77
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Libellé"
        Me.GridColumn13.ColumnEdit = Me.rp_FINTSS_CIP
        Me.GridColumn13.FieldName = "FINTSS_PRE_CODE_FK_PK"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.ReadOnly = True
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 1
        Me.GridColumn13.Width = 278
        '
        'rp_FINTSS_CIP
        '
        Me.rp_FINTSS_CIP.AutoHeight = False
        Me.rp_FINTSS_CIP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FINTSS_CIP.Name = "rp_FINTSS_CIP"
        '
        'FinccH_TA
        '
        Me.FinccH_TA.ClearBeforeFill = True
        '
        'FincpH_TA
        '
        Me.FincpH_TA.ClearBeforeFill = True
        '
        'FinpR_TA
        '
        Me.FinpR_TA.ClearBeforeFill = True
        '
        'FinsaC_TA
        '
        Me.FinsaC_TA.ClearBeforeFill = True
        '
        'FincH_TA
        '
        Me.FincH_TA.ClearBeforeFill = True
        '
        'FinsP_TA
        '
        Me.FinsP_TA.ClearBeforeFill = True
        '
        'FintY_TA
        '
        Me.FintY_TA.ClearBeforeFill = True
        '
        'FincoN_TA
        '
        Me.FincoN_TA.ClearBeforeFill = True
        '
        'FintsS_TA
        '
        Me.FintsS_TA.ClearBeforeFill = True
        '
        'FinsmR_TA
        '
        Me.FinsmR_TA.ClearBeforeFill = True
        '
        'FineT_TA
        '
        Me.FineT_TA.ClearBeforeFill = True
        '
        'FincO_TA
        '
        Me.FincO_TA.ClearBeforeFill = True
        '
        'FinbiB_TA
        '
        Me.FinbiB_TA.ClearBeforeFill = True
        '
        'FinafS_TA
        '
        Me.FinafS_TA.ClearBeforeFill = True
        '
        'Frm_Indication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(847, 644)
        Me.Name = "Frm_Indication"
        Me.Text = "Indication"
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
        CType(Me.DsTheriaque_Indication, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.GC6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FINSP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FINCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.GC4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FINPR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FINSAC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FINCCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FINCPH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.GC24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FINCON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV25, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.txtMaladiRareTexte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaladieRareO_N.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.GC23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FINTY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.lkupCodification.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupFIN_NAIN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupFIN_NVIN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        CType(Me.GC12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FINAFS_SP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FINAFS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpCommentaire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        CType(Me.GC28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpAgent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpSMR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        CType(Me.GC26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpPRE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FINTSS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FINTSS_CIP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FiN_TA As Theriaque.dsTheriaque_IndicationTableAdapters.FIN_FICHEINDICTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DsTheriaque_Indication As Theriaque.dsTheriaque_Indication
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents GC5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC6 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents GC3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GC1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents FinccH_TA As Theriaque.dsTheriaque_IndicationTableAdapters.FINCCH_INDCCHTableAdapter
    Friend WithEvents FincpH_TA As Theriaque.dsTheriaque_IndicationTableAdapters.FINCPH_INDCPHTableAdapter
    Friend WithEvents FinpR_TA As Theriaque.dsTheriaque_IndicationTableAdapters.FINPR_INDPRODTableAdapter
    Friend WithEvents FinsaC_TA As Theriaque.dsTheriaque_IndicationTableAdapters.FINSAC_SUBACTableAdapter
    Friend WithEvents FincH_TA As Theriaque.dsTheriaque_IndicationTableAdapters.FINCH_INDCHOIXTableAdapter
    Friend WithEvents FinsP_TA As Theriaque.dsTheriaque_IndicationTableAdapters.FINSP_INDSPETableAdapter
    Friend WithEvents colFINCPH_FIN_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINCPH_CPH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FINCPH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFINSAC_FIN_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINSAC_SAC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FINSAC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFINPR_FIN_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINPR_PR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FINPR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFINCCH_FIN_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINCCH_CCH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FINCCH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINCH_FIN_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINCH_CH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINCH_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FINCH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFINSP_FIN_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINSP_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FINSP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC22 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV22 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFINTY_FIN_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINTY_CDF_TYIN_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINTY_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FINTY As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FintY_TA As Theriaque.dsTheriaque_IndicationTableAdapters.FINTY_FINDTYPETableAdapter
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GC23 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV23 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GC24 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV24 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC25 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV25 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FincoN_TA As Theriaque.dsTheriaque_IndicationTableAdapters.FINCON_FINDCOMMENT_NATURETableAdapter
    Friend WithEvents colFINCON_FIN_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINCON_CDF_COIN_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINCON_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FINCON As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkupFIN_NVIN As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkupFIN_NAIN As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMaladiRareTexte As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaladieRareO_N As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FintsS_TA As Theriaque.dsTheriaque_IndicationTableAdapters.FINTSS_INDICATION_TAUXSECUTableAdapter
    Friend WithEvents FinsmR_TA As Theriaque.dsTheriaque_IndicationTableAdapters.FINSMR_INDIC_SMR_ATRTableAdapter
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents GC26 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV26 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFINTSS_FIN_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINTSS_PRE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpPRE As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFINTSS_DATE_APPLI_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINTSS_CDF_TSS_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINTSS_CDF_TSS_CODE_FK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FINTSS As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFINTSS_PRE_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FINTSS_CIP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btADDRemb As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents btADDSMR As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GC28 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV28 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rpAgent As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC27 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV27 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rpSMR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFINSMR_FIN_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINSMR_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINSMR_CDF_SMR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINSMR_DATE_SMR_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINSMR_ATR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINET_FIN_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINET_CDF_ETIN_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINET_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FineT_TA As Theriaque.dsTheriaque_IndicationTableAdapters.FINET_FINDETIOLTableAdapter
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents GC29 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV29 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rpCommentaire As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFINCO_FIN_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINCO_CDF_COIN_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINCO_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FincO_TA As Theriaque.dsTheriaque_IndicationTableAdapters.FINCO_FINDCOMMENTTableAdapter
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GC30 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV30 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFINAFS_FIN_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINAFS_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINAFS_DATE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINAFS_CDF_DOCUMENT_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FINAFS As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC12 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFINBIB_FIN_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINBIB_TEXTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpMemo As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents FinbiB_TA As Theriaque.dsTheriaque_IndicationTableAdapters.FINBIB_REFERENCE_BIBLIOTableAdapter
    Friend WithEvents FinafS_TA As Theriaque.dsTheriaque_IndicationTableAdapters.FINAFS_FIN_AFSSAPSTableAdapter
    Friend WithEvents rp_FINAFS_SP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbCodification As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkupCodification As DevExpress.XtraEditors.LookUpEdit

End Class
