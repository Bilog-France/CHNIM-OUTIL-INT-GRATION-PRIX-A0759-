<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Cipemg_Texte
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
        Me.FcpT_TA = New Theriaque.dsTheriaque_Cipemg_TexteTableAdapters.FCPT_FICHECIPEMGTableAdapter
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.GC5 = New DevExpress.XtraGrid.GridControl
        Me.GV5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCPTPR_FCPT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPTPR_PR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPTPR_PR_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FCPTPR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC6 = New DevExpress.XtraGrid.GridControl
        Me.GV6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCPTSP_FCPT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPTSP_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPTSP_SP_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FCPTSP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.GC3 = New DevExpress.XtraGrid.GridControl
        Me.GV3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCPTSAC_FCPT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPTSAC_SAC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPTSAC_SAC_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FCPTSAC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC4 = New DevExpress.XtraGrid.GridControl
        Me.GV4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCPTSAU_FCPT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPTSAU_SAU_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPTSAU_SAU_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FCPTSAU = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.GC1 = New DevExpress.XtraGrid.GridControl
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCPTCPH_FCPT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPTCPH_CPH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPTCPH_CPH_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FCPTCPH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC2 = New DevExpress.XtraGrid.GridControl
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCPTCCH_FCPT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPTCCH_CCH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPTCCH_CCH_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FCPTCCH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.GC23 = New DevExpress.XtraGrid.GridControl
        Me.GV23 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCPTTX2_FCPT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPTTX2_TXTPEMG = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rm_Memo2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Panel34 = New System.Windows.Forms.Panel
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.Panel35 = New System.Windows.Forms.Panel
        Me.Panel36 = New System.Windows.Forms.Panel
        Me.GC22 = New DevExpress.XtraGrid.GridControl
        Me.GV22 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCPTTX1_FCPT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPTTX1_TXTCI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rm_Memo1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Panel37 = New System.Windows.Forms.Panel
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GC21 = New DevExpress.XtraGrid.GridControl
        Me.GV21 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCPTAFS_FCPT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPTAFS_DATE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPTAFS_CDF_DOCUMENT_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FCPTAFS = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFCPTAFS_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FCPTAFS_SP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.DsTheriaque_Cipemg_Texte = New Theriaque.dsTheriaque_Cipemg_Texte
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.FcptcpH_TA = New Theriaque.dsTheriaque_Cipemg_TexteTableAdapters.FCPTCPH_CIPEMG_CLPHTableAdapter
        Me.FcptccH_TA = New Theriaque.dsTheriaque_Cipemg_TexteTableAdapters.FCPTCCH_CIPEMG_CLCHTableAdapter
        Me.FcptsaC_TA = New Theriaque.dsTheriaque_Cipemg_TexteTableAdapters.FCPTSAC_CIPEMG_SUBACTableAdapter
        Me.FcptpR_TA = New Theriaque.dsTheriaque_Cipemg_TexteTableAdapters.FCPTPR_CIPEMG_PRODTableAdapter
        Me.FcptsaU_TA = New Theriaque.dsTheriaque_Cipemg_TexteTableAdapters.FCPTSAU_CIPEMG_SUBAUTableAdapter
        Me.FcptsP_TA = New Theriaque.dsTheriaque_Cipemg_TexteTableAdapters.FCPTSP_CIPEMG_SPETableAdapter
        Me.FcpttX1_TA = New Theriaque.dsTheriaque_Cipemg_TexteTableAdapters.FCPTTX1_CIPEMG_TXCITableAdapter
        Me.FcpttX2_TA = New Theriaque.dsTheriaque_Cipemg_TexteTableAdapters.FCPTTX2_CIPEMG_TXPEMGTableAdapter
        Me.FcptafS_TA = New Theriaque.dsTheriaque_Cipemg_TexteTableAdapters.FCPTAFS_CIPEMG_AFSSAPSTableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.GC5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FCPTPR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FCPTSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.GC3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FCPTSAC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FCPTSAU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FCPTCPH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FCPTCCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel16.SuspendLayout()
        CType(Me.GC23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rm_Memo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel34.SuspendLayout()
        Me.Panel35.SuspendLayout()
        Me.Panel36.SuspendLayout()
        CType(Me.GC22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rm_Memo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel37.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GC21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FCPTAFS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FCPTAFS_SP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_Cipemg_Texte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(780, 574)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.GroupBox1)
        Me.PanMain.Controls.Add(Me.XtraTabControl1)
        Me.PanMain.Size = New System.Drawing.Size(662, 487)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(780, 87)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(780, 28)
        Me.Label1.Text = "Cipemg - Fiche texte"
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
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Cipemg_Texte, "FCPT_FICHECIPEMG.FCPT_DATEMJ", True))
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
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Cipemg_Texte, "FCPT_FICHECIPEMG.FCPT_DATECR", True))
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
        'FcpT_TA
        '
        Me.FcpT_TA.ClearBeforeFill = True
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Location = New System.Drawing.Point(3, 46)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(655, 438)
        Me.XtraTabControl1.TabIndex = 1
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
        Me.Panel7.TabIndex = 25
        '
        'GC5
        '
        Me.GC5.DataMember = "FCPTPR_CIPEMG_PROD"
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
        Me.GC5.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FCPTPR})
        Me.GC5.Size = New System.Drawing.Size(345, 133)
        Me.GC5.TabIndex = 2
        Me.GC5.Tag = "[EDIT][ADD]"
        Me.GC5.UseEmbeddedNavigator = True
        Me.GC5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV5})
        '
        'GV5
        '
        Me.GV5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCPTPR_FCPT_CODE_FK_PK, Me.colFCPTPR_PR_CODE_FK_PK, Me.colFCPTPR_PR_CODE_FK_PK2})
        Me.GV5.GridControl = Me.GC5
        Me.GV5.Name = "GV5"
        Me.GV5.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV5.OptionsView.ShowGroupPanel = False
        '
        'colFCPTPR_FCPT_CODE_FK_PK
        '
        Me.colFCPTPR_FCPT_CODE_FK_PK.Caption = "FCPTPR_FCPT_CODE_FK_PK"
        Me.colFCPTPR_FCPT_CODE_FK_PK.FieldName = "FCPTPR_FCPT_CODE_FK_PK"
        Me.colFCPTPR_FCPT_CODE_FK_PK.Name = "colFCPTPR_FCPT_CODE_FK_PK"
        '
        'colFCPTPR_PR_CODE_FK_PK
        '
        Me.colFCPTPR_PR_CODE_FK_PK.Caption = "Code"
        Me.colFCPTPR_PR_CODE_FK_PK.FieldName = "FCPTPR_PR_CODE_FK_PK"
        Me.colFCPTPR_PR_CODE_FK_PK.Name = "colFCPTPR_PR_CODE_FK_PK"
        Me.colFCPTPR_PR_CODE_FK_PK.Visible = True
        Me.colFCPTPR_PR_CODE_FK_PK.VisibleIndex = 0
        Me.colFCPTPR_PR_CODE_FK_PK.Width = 50
        '
        'colFCPTPR_PR_CODE_FK_PK2
        '
        Me.colFCPTPR_PR_CODE_FK_PK2.Caption = "Produit"
        Me.colFCPTPR_PR_CODE_FK_PK2.ColumnEdit = Me.lkup_FCPTPR
        Me.colFCPTPR_PR_CODE_FK_PK2.FieldName = "FCPTPR_PR_CODE_FK_PK"
        Me.colFCPTPR_PR_CODE_FK_PK2.Name = "colFCPTPR_PR_CODE_FK_PK2"
        Me.colFCPTPR_PR_CODE_FK_PK2.Visible = True
        Me.colFCPTPR_PR_CODE_FK_PK2.VisibleIndex = 1
        Me.colFCPTPR_PR_CODE_FK_PK2.Width = 274
        '
        'lkup_FCPTPR
        '
        Me.lkup_FCPTPR.AutoHeight = False
        Me.lkup_FCPTPR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FCPTPR.Name = "lkup_FCPTPR"
        '
        'GC6
        '
        Me.GC6.DataMember = "FCPTSP_CIPEMG_SPE"
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
        Me.GC6.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FCPTSP})
        Me.GC6.Size = New System.Drawing.Size(301, 133)
        Me.GC6.TabIndex = 3
        Me.GC6.Tag = "[EDIT][ADD]"
        Me.GC6.UseEmbeddedNavigator = True
        Me.GC6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV6})
        '
        'GV6
        '
        Me.GV6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCPTSP_FCPT_CODE_FK_PK, Me.colFCPTSP_SP_CODE_FK_PK, Me.colFCPTSP_SP_CODE_FK_PK2})
        Me.GV6.GridControl = Me.GC6
        Me.GV6.Name = "GV6"
        Me.GV6.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV6.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV6.OptionsView.ShowGroupPanel = False
        '
        'colFCPTSP_FCPT_CODE_FK_PK
        '
        Me.colFCPTSP_FCPT_CODE_FK_PK.Caption = "FCPTSP_FCPT_CODE_FK_PK"
        Me.colFCPTSP_FCPT_CODE_FK_PK.FieldName = "FCPTSP_FCPT_CODE_FK_PK"
        Me.colFCPTSP_FCPT_CODE_FK_PK.Name = "colFCPTSP_FCPT_CODE_FK_PK"
        '
        'colFCPTSP_SP_CODE_FK_PK
        '
        Me.colFCPTSP_SP_CODE_FK_PK.Caption = "Code"
        Me.colFCPTSP_SP_CODE_FK_PK.FieldName = "FCPTSP_SP_CODE_FK_PK"
        Me.colFCPTSP_SP_CODE_FK_PK.Name = "colFCPTSP_SP_CODE_FK_PK"
        Me.colFCPTSP_SP_CODE_FK_PK.Visible = True
        Me.colFCPTSP_SP_CODE_FK_PK.VisibleIndex = 0
        Me.colFCPTSP_SP_CODE_FK_PK.Width = 50
        '
        'colFCPTSP_SP_CODE_FK_PK2
        '
        Me.colFCPTSP_SP_CODE_FK_PK2.Caption = "Spécialités"
        Me.colFCPTSP_SP_CODE_FK_PK2.ColumnEdit = Me.lkup_FCPTSP
        Me.colFCPTSP_SP_CODE_FK_PK2.FieldName = "FCPTSP_SP_CODE_FK_PK"
        Me.colFCPTSP_SP_CODE_FK_PK2.Name = "colFCPTSP_SP_CODE_FK_PK2"
        Me.colFCPTSP_SP_CODE_FK_PK2.Visible = True
        Me.colFCPTSP_SP_CODE_FK_PK2.VisibleIndex = 1
        Me.colFCPTSP_SP_CODE_FK_PK2.Width = 230
        '
        'lkup_FCPTSP
        '
        Me.lkup_FCPTSP.AutoHeight = False
        Me.lkup_FCPTSP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FCPTSP.Name = "lkup_FCPTSP"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GC3)
        Me.Panel6.Controls.Add(Me.GC4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 137)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(646, 137)
        Me.Panel6.TabIndex = 24
        '
        'GC3
        '
        Me.GC3.DataMember = "FCPTSAC_CIPEMG_SUBAC"
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
        Me.GC3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FCPTSAC})
        Me.GC3.Size = New System.Drawing.Size(343, 137)
        Me.GC3.TabIndex = 2
        Me.GC3.Tag = "[EDIT][ADD]"
        Me.GC3.UseEmbeddedNavigator = True
        Me.GC3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV3})
        '
        'GV3
        '
        Me.GV3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCPTSAC_FCPT_CODE_FK_PK, Me.colFCPTSAC_SAC_CODE_FK_PK, Me.colFCPTSAC_SAC_CODE_FK_PK2})
        Me.GV3.GridControl = Me.GC3
        Me.GV3.Name = "GV3"
        Me.GV3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV3.OptionsView.ShowGroupPanel = False
        '
        'colFCPTSAC_FCPT_CODE_FK_PK
        '
        Me.colFCPTSAC_FCPT_CODE_FK_PK.Caption = "FCPTSAC_FCPT_CODE_FK_PK"
        Me.colFCPTSAC_FCPT_CODE_FK_PK.FieldName = "FCPTSAC_FCPT_CODE_FK_PK"
        Me.colFCPTSAC_FCPT_CODE_FK_PK.Name = "colFCPTSAC_FCPT_CODE_FK_PK"
        '
        'colFCPTSAC_SAC_CODE_FK_PK
        '
        Me.colFCPTSAC_SAC_CODE_FK_PK.Caption = "Code"
        Me.colFCPTSAC_SAC_CODE_FK_PK.FieldName = "FCPTSAC_SAC_CODE_FK_PK"
        Me.colFCPTSAC_SAC_CODE_FK_PK.Name = "colFCPTSAC_SAC_CODE_FK_PK"
        Me.colFCPTSAC_SAC_CODE_FK_PK.Visible = True
        Me.colFCPTSAC_SAC_CODE_FK_PK.VisibleIndex = 0
        Me.colFCPTSAC_SAC_CODE_FK_PK.Width = 54
        '
        'colFCPTSAC_SAC_CODE_FK_PK2
        '
        Me.colFCPTSAC_SAC_CODE_FK_PK2.Caption = "Substance active"
        Me.colFCPTSAC_SAC_CODE_FK_PK2.ColumnEdit = Me.lkup_FCPTSAC
        Me.colFCPTSAC_SAC_CODE_FK_PK2.FieldName = "FCPTSAC_SAC_CODE_FK_PK"
        Me.colFCPTSAC_SAC_CODE_FK_PK2.Name = "colFCPTSAC_SAC_CODE_FK_PK2"
        Me.colFCPTSAC_SAC_CODE_FK_PK2.Visible = True
        Me.colFCPTSAC_SAC_CODE_FK_PK2.VisibleIndex = 1
        Me.colFCPTSAC_SAC_CODE_FK_PK2.Width = 271
        '
        'lkup_FCPTSAC
        '
        Me.lkup_FCPTSAC.AutoHeight = False
        Me.lkup_FCPTSAC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FCPTSAC.Name = "lkup_FCPTSAC"
        '
        'GC4
        '
        Me.GC4.DataMember = "FCPTSAU_CIPEMG_SUBAU"
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
        Me.GC4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FCPTSAU})
        Me.GC4.Size = New System.Drawing.Size(303, 137)
        Me.GC4.TabIndex = 3
        Me.GC4.Tag = "[EDIT][ADD]"
        Me.GC4.UseEmbeddedNavigator = True
        Me.GC4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV4})
        '
        'GV4
        '
        Me.GV4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCPTSAU_FCPT_CODE_FK_PK, Me.colFCPTSAU_SAU_CODE_FK_PK, Me.colFCPTSAU_SAU_CODE_FK_PK2})
        Me.GV4.GridControl = Me.GC4
        Me.GV4.Name = "GV4"
        Me.GV4.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV4.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV4.OptionsView.ShowGroupPanel = False
        '
        'colFCPTSAU_FCPT_CODE_FK_PK
        '
        Me.colFCPTSAU_FCPT_CODE_FK_PK.Caption = "FCPTSAU_FCPT_CODE_FK_PK"
        Me.colFCPTSAU_FCPT_CODE_FK_PK.FieldName = "FCPTSAU_FCPT_CODE_FK_PK"
        Me.colFCPTSAU_FCPT_CODE_FK_PK.Name = "colFCPTSAU_FCPT_CODE_FK_PK"
        '
        'colFCPTSAU_SAU_CODE_FK_PK
        '
        Me.colFCPTSAU_SAU_CODE_FK_PK.Caption = "Code"
        Me.colFCPTSAU_SAU_CODE_FK_PK.FieldName = "FCPTSAU_SAU_CODE_FK_PK"
        Me.colFCPTSAU_SAU_CODE_FK_PK.Name = "colFCPTSAU_SAU_CODE_FK_PK"
        Me.colFCPTSAU_SAU_CODE_FK_PK.Visible = True
        Me.colFCPTSAU_SAU_CODE_FK_PK.VisibleIndex = 0
        Me.colFCPTSAU_SAU_CODE_FK_PK.Width = 50
        '
        'colFCPTSAU_SAU_CODE_FK_PK2
        '
        Me.colFCPTSAU_SAU_CODE_FK_PK2.Caption = "Excipient"
        Me.colFCPTSAU_SAU_CODE_FK_PK2.ColumnEdit = Me.lkup_FCPTSAU
        Me.colFCPTSAU_SAU_CODE_FK_PK2.FieldName = "FCPTSAU_SAU_CODE_FK_PK"
        Me.colFCPTSAU_SAU_CODE_FK_PK2.Name = "colFCPTSAU_SAU_CODE_FK_PK2"
        Me.colFCPTSAU_SAU_CODE_FK_PK2.Visible = True
        Me.colFCPTSAU_SAU_CODE_FK_PK2.VisibleIndex = 1
        Me.colFCPTSAU_SAU_CODE_FK_PK2.Width = 232
        '
        'lkup_FCPTSAU
        '
        Me.lkup_FCPTSAU.AutoHeight = False
        Me.lkup_FCPTSAU.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FCPTSAU.Name = "lkup_FCPTSAU"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GC1)
        Me.Panel4.Controls.Add(Me.GC2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(646, 137)
        Me.Panel4.TabIndex = 23
        '
        'GC1
        '
        Me.GC1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC1.DataMember = "FCPTCPH_CIPEMG_CLPH"
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
        Me.GC1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FCPTCPH})
        Me.GC1.Size = New System.Drawing.Size(343, 137)
        Me.GC1.TabIndex = 2
        Me.GC1.Tag = "[EDIT][ADD]"
        Me.GC1.UseEmbeddedNavigator = True
        Me.GC1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCPTCPH_FCPT_CODE_FK_PK, Me.colFCPTCPH_CPH_CODE_FK_PK, Me.colFCPTCPH_CPH_CODE_FK_PK2})
        Me.GV1.GridControl = Me.GC1
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV1.OptionsView.ShowGroupPanel = False
        '
        'colFCPTCPH_FCPT_CODE_FK_PK
        '
        Me.colFCPTCPH_FCPT_CODE_FK_PK.Caption = "FCPTCPH_FCPT_CODE_FK_PK"
        Me.colFCPTCPH_FCPT_CODE_FK_PK.FieldName = "FCPTCPH_FCPT_CODE_FK_PK"
        Me.colFCPTCPH_FCPT_CODE_FK_PK.Name = "colFCPTCPH_FCPT_CODE_FK_PK"
        '
        'colFCPTCPH_CPH_CODE_FK_PK
        '
        Me.colFCPTCPH_CPH_CODE_FK_PK.Caption = "Code"
        Me.colFCPTCPH_CPH_CODE_FK_PK.FieldName = "FCPTCPH_CPH_CODE_FK_PK"
        Me.colFCPTCPH_CPH_CODE_FK_PK.Name = "colFCPTCPH_CPH_CODE_FK_PK"
        Me.colFCPTCPH_CPH_CODE_FK_PK.Visible = True
        Me.colFCPTCPH_CPH_CODE_FK_PK.VisibleIndex = 0
        Me.colFCPTCPH_CPH_CODE_FK_PK.Width = 50
        '
        'colFCPTCPH_CPH_CODE_FK_PK2
        '
        Me.colFCPTCPH_CPH_CODE_FK_PK2.Caption = "Classe pharmaco-thérapeutique"
        Me.colFCPTCPH_CPH_CODE_FK_PK2.ColumnEdit = Me.lkup_FCPTCPH
        Me.colFCPTCPH_CPH_CODE_FK_PK2.FieldName = "FCPTCPH_CPH_CODE_FK_PK"
        Me.colFCPTCPH_CPH_CODE_FK_PK2.Name = "colFCPTCPH_CPH_CODE_FK_PK2"
        Me.colFCPTCPH_CPH_CODE_FK_PK2.Visible = True
        Me.colFCPTCPH_CPH_CODE_FK_PK2.VisibleIndex = 1
        Me.colFCPTCPH_CPH_CODE_FK_PK2.Width = 272
        '
        'lkup_FCPTCPH
        '
        Me.lkup_FCPTCPH.AutoHeight = False
        Me.lkup_FCPTCPH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FCPTCPH.Name = "lkup_FCPTCPH"
        '
        'GC2
        '
        Me.GC2.DataMember = "FCPTCCH_CIPEMG_CLCH"
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
        Me.GC2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FCPTCCH})
        Me.GC2.Size = New System.Drawing.Size(303, 137)
        Me.GC2.TabIndex = 3
        Me.GC2.Tag = "[EDIT][ADD]"
        Me.GC2.UseEmbeddedNavigator = True
        Me.GC2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCPTCCH_FCPT_CODE_FK_PK, Me.colFCPTCCH_CCH_CODE_FK_PK, Me.colFCPTCCH_CCH_CODE_FK_PK2})
        Me.GV2.GridControl = Me.GC2
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV2.OptionsView.ShowGroupPanel = False
        '
        'colFCPTCCH_FCPT_CODE_FK_PK
        '
        Me.colFCPTCCH_FCPT_CODE_FK_PK.Caption = "FCPTCCH_FCPT_CODE_FK_PK"
        Me.colFCPTCCH_FCPT_CODE_FK_PK.FieldName = "FCPTCCH_FCPT_CODE_FK_PK"
        Me.colFCPTCCH_FCPT_CODE_FK_PK.Name = "colFCPTCCH_FCPT_CODE_FK_PK"
        '
        'colFCPTCCH_CCH_CODE_FK_PK
        '
        Me.colFCPTCCH_CCH_CODE_FK_PK.Caption = "Code"
        Me.colFCPTCCH_CCH_CODE_FK_PK.FieldName = "FCPTCCH_CCH_CODE_FK_PK"
        Me.colFCPTCCH_CCH_CODE_FK_PK.Name = "colFCPTCCH_CCH_CODE_FK_PK"
        Me.colFCPTCCH_CCH_CODE_FK_PK.Visible = True
        Me.colFCPTCCH_CCH_CODE_FK_PK.VisibleIndex = 0
        Me.colFCPTCCH_CCH_CODE_FK_PK.Width = 50
        '
        'colFCPTCCH_CCH_CODE_FK_PK2
        '
        Me.colFCPTCCH_CCH_CODE_FK_PK2.Caption = "Classe chimique"
        Me.colFCPTCCH_CCH_CODE_FK_PK2.ColumnEdit = Me.lkup_FCPTCCH
        Me.colFCPTCCH_CCH_CODE_FK_PK2.FieldName = "FCPTCCH_CCH_CODE_FK_PK"
        Me.colFCPTCCH_CCH_CODE_FK_PK2.Name = "colFCPTCCH_CCH_CODE_FK_PK2"
        Me.colFCPTCCH_CCH_CODE_FK_PK2.Visible = True
        Me.colFCPTCCH_CCH_CODE_FK_PK2.VisibleIndex = 1
        Me.colFCPTCCH_CCH_CODE_FK_PK2.Width = 232
        '
        'lkup_FCPTCCH
        '
        Me.lkup_FCPTCCH.AutoHeight = False
        Me.lkup_FCPTCCH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FCPTCCH.Name = "lkup_FCPTCCH"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Panel11)
        Me.XtraTabPage2.Controls.Add(Me.Panel35)
        Me.XtraTabPage2.Controls.Add(Me.Panel2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(496, 399)
        Me.XtraTabPage2.Text = "Références officielles / Texte"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Panel16)
        Me.Panel11.Controls.Add(Me.Panel34)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(0, 257)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(496, 142)
        Me.Panel11.TabIndex = 48
        Me.Panel11.Tag = ""
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.GC23)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel16.Location = New System.Drawing.Point(0, 24)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(496, 118)
        Me.Panel16.TabIndex = 38
        Me.Panel16.Tag = "[ADD][EDIT]"
        '
        'GC23
        '
        Me.GC23.DataMember = "FCPTTX2_CIPEMG_TXPEMG"
        Me.GC23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC23.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC23.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC23.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC23.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC23.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC23.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC23.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC23.EmbeddedNavigator.Name = ""
        Me.GC23.EmbeddedNavigator.TextStringFormat = ""
        Me.GC23.Location = New System.Drawing.Point(0, 0)
        Me.GC23.MainView = Me.GV23
        Me.GC23.Name = "GC23"
        Me.GC23.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rm_Memo2})
        Me.GC23.Size = New System.Drawing.Size(496, 118)
        Me.GC23.TabIndex = 4
        Me.GC23.UseEmbeddedNavigator = True
        Me.GC23.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV23})
        '
        'GV23
        '
        Me.GV23.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCPTTX2_FCPT_CODE_FK_PK, Me.colFCPTTX2_TXTPEMG})
        Me.GV23.GridControl = Me.GC23
        Me.GV23.GroupFormat = ""
        Me.GV23.GroupPanelText = " "
        Me.GV23.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GV23.Name = "GV23"
        Me.GV23.OptionsCustomization.AllowRowSizing = True
        Me.GV23.OptionsNavigation.AutoFocusNewRow = True
        Me.GV23.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV23.OptionsView.ShowColumnHeaders = False
        Me.GV23.OptionsView.ShowDetailButtons = False
        Me.GV23.OptionsView.ShowGroupPanel = False
        Me.GV23.OptionsView.ShowHorzLines = False
        Me.GV23.OptionsView.ShowIndicator = False
        Me.GV23.RowHeight = 101
        Me.GV23.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colFCPTTX2_FCPT_CODE_FK_PK
        '
        Me.colFCPTTX2_FCPT_CODE_FK_PK.Caption = "FCPTTX2_FCPT_CODE_FK_PK"
        Me.colFCPTTX2_FCPT_CODE_FK_PK.FieldName = "FCPTTX2_FCPT_CODE_FK_PK"
        Me.colFCPTTX2_FCPT_CODE_FK_PK.Name = "colFCPTTX2_FCPT_CODE_FK_PK"
        '
        'colFCPTTX2_TXTPEMG
        '
        Me.colFCPTTX2_TXTPEMG.Caption = "FCPTTX2_TXTPEMG"
        Me.colFCPTTX2_TXTPEMG.ColumnEdit = Me.rm_Memo2
        Me.colFCPTTX2_TXTPEMG.FieldName = "FCPTTX2_TXTPEMG"
        Me.colFCPTTX2_TXTPEMG.Name = "colFCPTTX2_TXTPEMG"
        Me.colFCPTTX2_TXTPEMG.Visible = True
        Me.colFCPTTX2_TXTPEMG.VisibleIndex = 0
        '
        'rm_Memo2
        '
        Me.rm_Memo2.Name = "rm_Memo2"
        '
        'Panel34
        '
        Me.Panel34.Controls.Add(Me.LabelControl13)
        Me.Panel34.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel34.Location = New System.Drawing.Point(0, 0)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(496, 24)
        Me.Panel34.TabIndex = 37
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(2, 8)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(223, 13)
        Me.LabelControl13.TabIndex = 19
        Me.LabelControl13.Text = "Précautions d'emploi et Mises en garde / Texte"
        '
        'Panel35
        '
        Me.Panel35.Controls.Add(Me.Panel36)
        Me.Panel35.Controls.Add(Me.Panel37)
        Me.Panel35.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel35.Location = New System.Drawing.Point(0, 143)
        Me.Panel35.Name = "Panel35"
        Me.Panel35.Size = New System.Drawing.Size(496, 114)
        Me.Panel35.TabIndex = 47
        Me.Panel35.Tag = ""
        '
        'Panel36
        '
        Me.Panel36.Controls.Add(Me.GC22)
        Me.Panel36.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel36.Location = New System.Drawing.Point(0, 24)
        Me.Panel36.Name = "Panel36"
        Me.Panel36.Size = New System.Drawing.Size(496, 90)
        Me.Panel36.TabIndex = 38
        Me.Panel36.Tag = "[ADD][EDIT]"
        '
        'GC22
        '
        Me.GC22.DataMember = "FCPTTX1_CIPEMG_TXCI"
        Me.GC22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC22.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC22.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC22.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC22.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC22.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC22.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC22.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC22.EmbeddedNavigator.Name = ""
        Me.GC22.EmbeddedNavigator.TextStringFormat = ""
        Me.GC22.Location = New System.Drawing.Point(0, 0)
        Me.GC22.MainView = Me.GV22
        Me.GC22.Name = "GC22"
        Me.GC22.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rm_Memo1})
        Me.GC22.Size = New System.Drawing.Size(496, 90)
        Me.GC22.TabIndex = 4
        Me.GC22.UseEmbeddedNavigator = True
        Me.GC22.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV22})
        '
        'GV22
        '
        Me.GV22.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCPTTX1_FCPT_CODE_FK_PK, Me.colFCPTTX1_TXTCI})
        Me.GV22.GridControl = Me.GC22
        Me.GV22.GroupFormat = ""
        Me.GV22.GroupPanelText = " "
        Me.GV22.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GV22.Name = "GV22"
        Me.GV22.OptionsCustomization.AllowRowSizing = True
        Me.GV22.OptionsNavigation.AutoFocusNewRow = True
        Me.GV22.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV22.OptionsView.ShowColumnHeaders = False
        Me.GV22.OptionsView.ShowDetailButtons = False
        Me.GV22.OptionsView.ShowGroupPanel = False
        Me.GV22.OptionsView.ShowHorzLines = False
        Me.GV22.OptionsView.ShowIndicator = False
        Me.GV22.RowHeight = 65
        Me.GV22.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colFCPTTX1_FCPT_CODE_FK_PK
        '
        Me.colFCPTTX1_FCPT_CODE_FK_PK.Caption = "FCPTTX1_FCPT_CODE_FK_PK"
        Me.colFCPTTX1_FCPT_CODE_FK_PK.FieldName = "FCPTTX1_FCPT_CODE_FK_PK"
        Me.colFCPTTX1_FCPT_CODE_FK_PK.Name = "colFCPTTX1_FCPT_CODE_FK_PK"
        '
        'colFCPTTX1_TXTCI
        '
        Me.colFCPTTX1_TXTCI.Caption = "FCPTTX1_TXTCI"
        Me.colFCPTTX1_TXTCI.ColumnEdit = Me.rm_Memo1
        Me.colFCPTTX1_TXTCI.FieldName = "FCPTTX1_TXTCI"
        Me.colFCPTTX1_TXTCI.Name = "colFCPTTX1_TXTCI"
        Me.colFCPTTX1_TXTCI.Visible = True
        Me.colFCPTTX1_TXTCI.VisibleIndex = 0
        '
        'rm_Memo1
        '
        Me.rm_Memo1.Name = "rm_Memo1"
        '
        'Panel37
        '
        Me.Panel37.Controls.Add(Me.LabelControl15)
        Me.Panel37.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel37.Location = New System.Drawing.Point(0, 0)
        Me.Panel37.Name = "Panel37"
        Me.Panel37.Size = New System.Drawing.Size(496, 24)
        Me.Panel37.TabIndex = 37
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(2, 8)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(119, 13)
        Me.LabelControl15.TabIndex = 19
        Me.LabelControl15.Text = "Contre indication / Texte"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GC21)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(496, 143)
        Me.Panel2.TabIndex = 25
        '
        'GC21
        '
        Me.GC21.DataMember = "FCPTAFS_CIPEMG_AFSSAPS"
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
        Me.GC21.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FCPTAFS, Me.lkup_FCPTAFS_SP})
        Me.GC21.Size = New System.Drawing.Size(496, 143)
        Me.GC21.TabIndex = 2
        Me.GC21.Tag = "[EDIT][ADD]"
        Me.GC21.UseEmbeddedNavigator = True
        Me.GC21.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV21})
        '
        'GV21
        '
        Me.GV21.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCPTAFS_FCPT_CODE_FK_PK, Me.colFCPTAFS_DATE_PK, Me.colFCPTAFS_CDF_DOCUMENT_FK_PK, Me.colFCPTAFS_SP_CODE_FK_PK})
        Me.GV21.GridControl = Me.GC21
        Me.GV21.Name = "GV21"
        Me.GV21.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV21.OptionsView.ShowGroupPanel = False
        '
        'colFCPTAFS_FCPT_CODE_FK_PK
        '
        Me.colFCPTAFS_FCPT_CODE_FK_PK.Caption = "FCPTAFS_FCPT_CODE_FK_PK"
        Me.colFCPTAFS_FCPT_CODE_FK_PK.FieldName = "FCPTAFS_FCPT_CODE_FK_PK"
        Me.colFCPTAFS_FCPT_CODE_FK_PK.Name = "colFCPTAFS_FCPT_CODE_FK_PK"
        '
        'colFCPTAFS_DATE_PK
        '
        Me.colFCPTAFS_DATE_PK.Caption = "Date"
        Me.colFCPTAFS_DATE_PK.FieldName = "FCPTAFS_DATE_PK"
        Me.colFCPTAFS_DATE_PK.Name = "colFCPTAFS_DATE_PK"
        Me.colFCPTAFS_DATE_PK.Visible = True
        Me.colFCPTAFS_DATE_PK.VisibleIndex = 1
        Me.colFCPTAFS_DATE_PK.Width = 72
        '
        'colFCPTAFS_CDF_DOCUMENT_FK_PK
        '
        Me.colFCPTAFS_CDF_DOCUMENT_FK_PK.Caption = "Références officielles"
        Me.colFCPTAFS_CDF_DOCUMENT_FK_PK.ColumnEdit = Me.lkup_FCPTAFS
        Me.colFCPTAFS_CDF_DOCUMENT_FK_PK.FieldName = "FCPTAFS_CDF_DOCUMENT_FK_PK"
        Me.colFCPTAFS_CDF_DOCUMENT_FK_PK.Name = "colFCPTAFS_CDF_DOCUMENT_FK_PK"
        Me.colFCPTAFS_CDF_DOCUMENT_FK_PK.Visible = True
        Me.colFCPTAFS_CDF_DOCUMENT_FK_PK.VisibleIndex = 0
        Me.colFCPTAFS_CDF_DOCUMENT_FK_PK.Width = 206
        '
        'lkup_FCPTAFS
        '
        Me.lkup_FCPTAFS.AutoHeight = False
        Me.lkup_FCPTAFS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FCPTAFS.Name = "lkup_FCPTAFS"
        '
        'colFCPTAFS_SP_CODE_FK_PK
        '
        Me.colFCPTAFS_SP_CODE_FK_PK.Caption = "Spécialités"
        Me.colFCPTAFS_SP_CODE_FK_PK.ColumnEdit = Me.lkup_FCPTAFS_SP
        Me.colFCPTAFS_SP_CODE_FK_PK.FieldName = "FCPTAFS_SP_CODE_FK_PK"
        Me.colFCPTAFS_SP_CODE_FK_PK.Name = "colFCPTAFS_SP_CODE_FK_PK"
        Me.colFCPTAFS_SP_CODE_FK_PK.Visible = True
        Me.colFCPTAFS_SP_CODE_FK_PK.VisibleIndex = 2
        Me.colFCPTAFS_SP_CODE_FK_PK.Width = 210
        '
        'lkup_FCPTAFS_SP
        '
        Me.lkup_FCPTAFS_SP.AutoHeight = False
        Me.lkup_FCPTAFS_SP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FCPTAFS_SP.Name = "lkup_FCPTAFS_SP"
        Me.lkup_FCPTAFS_SP.NullText = ""
        '
        'DsTheriaque_Cipemg_Texte
        '
        Me.DsTheriaque_Cipemg_Texte.DataSetName = "dsTheriaque_Cipemg_Texte"
        Me.DsTheriaque_Cipemg_Texte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(662, 42)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Cipemg_Texte, "FCPT_FICHECIPEMG.FCPT_CODE_SQ_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(88, 13)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(135, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Tag = "[NOEDIT][NOADD]"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(42, 17)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Fiche N°"
        '
        'FcptcpH_TA
        '
        Me.FcptcpH_TA.ClearBeforeFill = True
        '
        'FcptccH_TA
        '
        Me.FcptccH_TA.ClearBeforeFill = True
        '
        'FcptsaC_TA
        '
        Me.FcptsaC_TA.ClearBeforeFill = True
        '
        'FcptpR_TA
        '
        Me.FcptpR_TA.ClearBeforeFill = True
        '
        'FcptsaU_TA
        '
        Me.FcptsaU_TA.ClearBeforeFill = True
        '
        'FcptsP_TA
        '
        Me.FcptsP_TA.ClearBeforeFill = True
        '
        'FcpttX1_TA
        '
        Me.FcpttX1_TA.ClearBeforeFill = True
        '
        'FcpttX2_TA
        '
        Me.FcpttX2_TA.ClearBeforeFill = True
        '
        'FcptafS_TA
        '
        Me.FcptafS_TA.ClearBeforeFill = True
        '
        'Frm_Cipemg_Texte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(780, 574)
        Me.Name = "Frm_Cipemg_Texte"
        Me.Text = "Cipemg - Fiche texte"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.GC5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FCPTPR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FCPTSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.GC3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FCPTSAC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FCPTSAU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FCPTCPH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FCPTCCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        CType(Me.GC23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rm_Memo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel34.ResumeLayout(False)
        Me.Panel34.PerformLayout()
        Me.Panel35.ResumeLayout(False)
        Me.Panel36.ResumeLayout(False)
        CType(Me.GC22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rm_Memo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel37.ResumeLayout(False)
        Me.Panel37.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GC21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FCPTAFS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FCPTAFS_SP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_Cipemg_Texte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FcpT_TA As Theriaque.dsTheriaque_Cipemg_TexteTableAdapters.FCPT_FICHECIPEMGTableAdapter
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GC21 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV21 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DsTheriaque_Cipemg_Texte As Theriaque.dsTheriaque_Cipemg_Texte
    Friend WithEvents colFCPTCPH_FCPT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPTCPH_CPH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FcptcpH_TA As Theriaque.dsTheriaque_Cipemg_TexteTableAdapters.FCPTCPH_CIPEMG_CLPHTableAdapter
    Friend WithEvents colFCPTCPH_CPH_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FCPTCPH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFCPTCCH_FCPT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPTCCH_CCH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPTCCH_CCH_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FCPTCCH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FcptccH_TA As Theriaque.dsTheriaque_Cipemg_TexteTableAdapters.FCPTCCH_CIPEMG_CLCHTableAdapter
    Friend WithEvents FcptsaC_TA As Theriaque.dsTheriaque_Cipemg_TexteTableAdapters.FCPTSAC_CIPEMG_SUBACTableAdapter
    Friend WithEvents colFCPTSAC_FCPT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPTSAC_SAC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPTSAC_SAC_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FCPTSAC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFCPTPR_FCPT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPTPR_PR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPTPR_PR_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FCPTPR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFCPTSAU_FCPT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPTSAU_SAU_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPTSAU_SAU_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FCPTSAU As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FcptpR_TA As Theriaque.dsTheriaque_Cipemg_TexteTableAdapters.FCPTPR_CIPEMG_PRODTableAdapter
    Friend WithEvents FcptsaU_TA As Theriaque.dsTheriaque_Cipemg_TexteTableAdapters.FCPTSAU_CIPEMG_SUBAUTableAdapter
    Friend WithEvents colFCPTSP_FCPT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPTSP_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPTSP_SP_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FCPTSP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FcptsP_TA As Theriaque.dsTheriaque_Cipemg_TexteTableAdapters.FCPTSP_CIPEMG_SPETableAdapter
    Friend WithEvents FcpttX1_TA As Theriaque.dsTheriaque_Cipemg_TexteTableAdapters.FCPTTX1_CIPEMG_TXCITableAdapter
    Friend WithEvents FcpttX2_TA As Theriaque.dsTheriaque_Cipemg_TexteTableAdapters.FCPTTX2_CIPEMG_TXPEMGTableAdapter
    Friend WithEvents FcptafS_TA As Theriaque.dsTheriaque_Cipemg_TexteTableAdapters.FCPTAFS_CIPEMG_AFSSAPSTableAdapter
    Friend WithEvents colFCPTAFS_FCPT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPTAFS_DATE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPTAFS_CDF_DOCUMENT_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FCPTAFS As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFCPTAFS_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FCPTAFS_SP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel35 As System.Windows.Forms.Panel
    Friend WithEvents Panel36 As System.Windows.Forms.Panel
    Friend WithEvents Panel37 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Panel34 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GC23 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV23 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC22 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV22 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFCPTTX1_FCPT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPTTX1_TXTCI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rm_Memo1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colFCPTTX2_FCPT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPTTX2_TXTPEMG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rm_Memo2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit

End Class
