<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Reconst_Administ
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
        Me.FreC_TA = New Theriaque.dsTheriaque_Reconst_AdministTableAdapters.FREC_RECONSADMTableAdapter
        Me.DsTheriaque_Reconst_Administ = New Theriaque.dsTheriaque_Reconst_Administ
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.GC5 = New DevExpress.XtraGrid.GridControl
        Me.GV5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFRECCH_FREC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFRECCH_CH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFRECCH_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FRECCH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC6 = New DevExpress.XtraGrid.GridControl
        Me.GV6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFRECSP_FREC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFRECSP_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFRECSP_SP_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FRECSP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.GC3 = New DevExpress.XtraGrid.GridControl
        Me.GV3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFRECSAC_FREC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFRECSAC_SAC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFRECSAC_SAC_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FRECSAC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC4 = New DevExpress.XtraGrid.GridControl
        Me.GV4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFRECPR_FREC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFRECPR_PR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFRECPR_PR_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FRECPR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.GC1 = New DevExpress.XtraGrid.GridControl
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFRECCPH_FREC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFRECCPH_CPH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFRECCPH_CPH_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FRECCPH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC2 = New DevExpress.XtraGrid.GridControl
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFRECCCH_FREC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFRECCCH_CCH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFRECCCH_CCH_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FRECCCH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.GC23 = New DevExpress.XtraGrid.GridControl
        Me.GV23 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFRECTXR_FREC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFRECTXR_TXTRECS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rm_Memo1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Panel34 = New System.Windows.Forms.Panel
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GC21 = New DevExpress.XtraGrid.GridControl
        Me.GV21 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFRECCOR_FREC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFRECCOR_CDF_COMRECS_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFRECCOR_NUM_ORD_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FRECCOR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.GC33 = New DevExpress.XtraGrid.GridControl
        Me.GV33 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFRECTXA_FREC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFRECTXA_TXTADM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rm_Memo2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.GC31 = New DevExpress.XtraGrid.GridControl
        Me.GV31 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFRECCOA_FREC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFRECCOA_CDF_COMADM_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFRECCOA_NUM_ORD_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FRECCOA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.GC32 = New DevExpress.XtraGrid.GridControl
        Me.GV32 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFRECAFS_FREC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFRECAFS_DATE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFRECAFS_CDF_DOCUMENT_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FRECAFS = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFRECAFS_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FRECAFS_SP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GC22 = New DevExpress.XtraGrid.GridControl
        Me.GV22 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFRECVO_FREC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFRECVO_CDF_VO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFRECVO_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FRECVO = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.FreccpH_TA = New Theriaque.dsTheriaque_Reconst_AdministTableAdapters.FRECCPH_FREC_CLPHTableAdapter
        Me.FrecccH_TA = New Theriaque.dsTheriaque_Reconst_AdministTableAdapters.FRECCCH_FREC_CLCHTableAdapter
        Me.FrecsaC_TA = New Theriaque.dsTheriaque_Reconst_AdministTableAdapters.FRECSAC_FREC_SUBACTTableAdapter
        Me.FrecpR_TA = New Theriaque.dsTheriaque_Reconst_AdministTableAdapters.FRECPR_FREC_PRODTableAdapter
        Me.FreccH_TA = New Theriaque.dsTheriaque_Reconst_AdministTableAdapters.FRECCH_RECONSTCHTableAdapter
        Me.FrecsP_TA = New Theriaque.dsTheriaque_Reconst_AdministTableAdapters.FRECSP_RECONST_SPECTableAdapter
        Me.FreccoR_TA = New Theriaque.dsTheriaque_Reconst_AdministTableAdapters.FRECCOR_FREC_COMRECSTableAdapter
        Me.FrecvO_TA = New Theriaque.dsTheriaque_Reconst_AdministTableAdapters.FRECVO_RECONSADM_VOIETableAdapter
        Me.FrectxR_TA = New Theriaque.dsTheriaque_Reconst_AdministTableAdapters.FRECTXR_FREC_TXTRECSTableAdapter
        Me.FreccoA_TA = New Theriaque.dsTheriaque_Reconst_AdministTableAdapters.FRECCOA_FREC_COMADMTableAdapter
        Me.FrecafS_TA = New Theriaque.dsTheriaque_Reconst_AdministTableAdapters.FRECAFS_FREC_AFSSAPSTableAdapter
        Me.FrectxA_TA = New Theriaque.dsTheriaque_Reconst_AdministTableAdapters.FRECTXA_FREC_TXTADMTableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_Reconst_Administ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.GC5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FRECCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FRECSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.GC3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FRECSAC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FRECPR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FRECCPH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FRECCCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel16.SuspendLayout()
        CType(Me.GC23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rm_Memo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel34.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GC21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FRECCOR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.GC33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rm_Memo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.GC31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FRECCOA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.GC32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FRECAFS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FRECAFS_SP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.GC22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FRECVO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(825, 574)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.XtraTabControl1)
        Me.PanMain.Controls.Add(Me.GroupBox1)
        Me.PanMain.Size = New System.Drawing.Size(707, 487)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(825, 87)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(825, 28)
        Me.Label1.Text = "Reconstitution / Administration"
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
        Me.Panel1.Location = New System.Drawing.Point(707, 87)
        Me.Panel1.Size = New System.Drawing.Size(118, 487)
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Reconst_Administ, "FREC_RECONSADM.FREC_DATEMJ", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Size = New System.Drawing.Size(825, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Reconst_Administ, "FREC_RECONSADM.FREC_DATECR", True))
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
        'FreC_TA
        '
        Me.FreC_TA.ClearBeforeFill = True
        '
        'DsTheriaque_Reconst_Administ
        '
        Me.DsTheriaque_Reconst_Administ.DataSetName = "dsTheriaque_Reconst_Administ"
        Me.DsTheriaque_Reconst_Administ.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(707, 42)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Reconst_Administ, "FREC_RECONSADM.FREC_CODE_SQ_PK", True))
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
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Location = New System.Drawing.Point(4, 49)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(700, 438)
        Me.XtraTabControl1.TabIndex = 12
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panel7)
        Me.XtraTabPage1.Controls.Add(Me.Panel6)
        Me.XtraTabPage1.Controls.Add(Me.Panel4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(691, 407)
        Me.XtraTabPage1.Text = "Entités"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.GC5)
        Me.Panel7.Controls.Add(Me.GC6)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 274)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(691, 133)
        Me.Panel7.TabIndex = 25
        '
        'GC5
        '
        Me.GC5.DataMember = "FRECCH_RECONSTCH"
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
        Me.GC5.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FRECCH})
        Me.GC5.Size = New System.Drawing.Size(370, 133)
        Me.GC5.TabIndex = 2
        Me.GC5.Tag = "[EDIT][ADD]"
        Me.GC5.UseEmbeddedNavigator = True
        Me.GC5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV5})
        '
        'GV5
        '
        Me.GV5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFRECCH_FREC_CODE_FK_PK, Me.colFRECCH_CH_CODE_FK_PK, Me.colFRECCH_NUMORD, Me.GridColumn5})
        Me.GV5.GridControl = Me.GC5
        Me.GV5.Name = "GV5"
        Me.GV5.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV5.OptionsView.ShowGroupPanel = False
        '
        'colFRECCH_FREC_CODE_FK_PK
        '
        Me.colFRECCH_FREC_CODE_FK_PK.Caption = "FRECCH_FREC_CODE_FK_PK"
        Me.colFRECCH_FREC_CODE_FK_PK.FieldName = "FRECCH_FREC_CODE_FK_PK"
        Me.colFRECCH_FREC_CODE_FK_PK.Name = "colFRECCH_FREC_CODE_FK_PK"
        '
        'colFRECCH_CH_CODE_FK_PK
        '
        Me.colFRECCH_CH_CODE_FK_PK.Caption = "Code"
        Me.colFRECCH_CH_CODE_FK_PK.FieldName = "FRECCH_CH_CODE_FK_PK"
        Me.colFRECCH_CH_CODE_FK_PK.Name = "colFRECCH_CH_CODE_FK_PK"
        Me.colFRECCH_CH_CODE_FK_PK.Visible = True
        Me.colFRECCH_CH_CODE_FK_PK.VisibleIndex = 0
        Me.colFRECCH_CH_CODE_FK_PK.Width = 50
        '
        'colFRECCH_NUMORD
        '
        Me.colFRECCH_NUMORD.Caption = "N°"
        Me.colFRECCH_NUMORD.FieldName = "FRECCH_NUMORD"
        Me.colFRECCH_NUMORD.Name = "colFRECCH_NUMORD"
        Me.colFRECCH_NUMORD.Visible = True
        Me.colFRECCH_NUMORD.VisibleIndex = 2
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Critère de choix"
        Me.GridColumn5.ColumnEdit = Me.lkup_FRECCH
        Me.GridColumn5.FieldName = "FRECCH_CH_CODE_FK_PK"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 299
        '
        'lkup_FRECCH
        '
        Me.lkup_FRECCH.AutoHeight = False
        Me.lkup_FRECCH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FRECCH.Name = "lkup_FRECCH"
        '
        'GC6
        '
        Me.GC6.DataMember = "FRECSP_RECONST_SPEC"
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
        Me.GC6.Location = New System.Drawing.Point(370, 0)
        Me.GC6.MainView = Me.GV6
        Me.GC6.Name = "GC6"
        Me.GC6.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FRECSP})
        Me.GC6.Size = New System.Drawing.Size(321, 133)
        Me.GC6.TabIndex = 3
        Me.GC6.Tag = "[EDIT][ADD]"
        Me.GC6.UseEmbeddedNavigator = True
        Me.GC6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV6})
        '
        'GV6
        '
        Me.GV6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFRECSP_FREC_CODE_FK_PK, Me.colFRECSP_SP_CODE_FK_PK, Me.colFRECSP_SP_CODE_FK_PK2})
        Me.GV6.GridControl = Me.GC6
        Me.GV6.Name = "GV6"
        Me.GV6.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV6.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV6.OptionsView.ShowGroupPanel = False
        '
        'colFRECSP_FREC_CODE_FK_PK
        '
        Me.colFRECSP_FREC_CODE_FK_PK.Caption = "FRECSP_FREC_CODE_FK_PK"
        Me.colFRECSP_FREC_CODE_FK_PK.FieldName = "FRECSP_FREC_CODE_FK_PK"
        Me.colFRECSP_FREC_CODE_FK_PK.Name = "colFRECSP_FREC_CODE_FK_PK"
        '
        'colFRECSP_SP_CODE_FK_PK
        '
        Me.colFRECSP_SP_CODE_FK_PK.Caption = "Code"
        Me.colFRECSP_SP_CODE_FK_PK.FieldName = "FRECSP_SP_CODE_FK_PK"
        Me.colFRECSP_SP_CODE_FK_PK.Name = "colFRECSP_SP_CODE_FK_PK"
        Me.colFRECSP_SP_CODE_FK_PK.Visible = True
        Me.colFRECSP_SP_CODE_FK_PK.VisibleIndex = 0
        Me.colFRECSP_SP_CODE_FK_PK.Width = 61
        '
        'colFRECSP_SP_CODE_FK_PK2
        '
        Me.colFRECSP_SP_CODE_FK_PK2.Caption = "Spécialités"
        Me.colFRECSP_SP_CODE_FK_PK2.ColumnEdit = Me.lkup_FRECSP
        Me.colFRECSP_SP_CODE_FK_PK2.FieldName = "FRECSP_SP_CODE_FK_PK"
        Me.colFRECSP_SP_CODE_FK_PK2.Name = "colFRECSP_SP_CODE_FK_PK2"
        Me.colFRECSP_SP_CODE_FK_PK2.Visible = True
        Me.colFRECSP_SP_CODE_FK_PK2.VisibleIndex = 1
        Me.colFRECSP_SP_CODE_FK_PK2.Width = 239
        '
        'lkup_FRECSP
        '
        Me.lkup_FRECSP.AutoHeight = False
        Me.lkup_FRECSP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FRECSP.Name = "lkup_FRECSP"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GC3)
        Me.Panel6.Controls.Add(Me.GC4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 137)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(691, 137)
        Me.Panel6.TabIndex = 24
        '
        'GC3
        '
        Me.GC3.DataMember = "FRECSAC_FREC_SUBACT"
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
        Me.GC3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FRECSAC})
        Me.GC3.Size = New System.Drawing.Size(368, 137)
        Me.GC3.TabIndex = 2
        Me.GC3.Tag = "[EDIT][ADD]"
        Me.GC3.UseEmbeddedNavigator = True
        Me.GC3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV3})
        '
        'GV3
        '
        Me.GV3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFRECSAC_FREC_CODE_FK_PK, Me.colFRECSAC_SAC_CODE_FK_PK, Me.colFRECSAC_SAC_CODE_FK_PK2})
        Me.GV3.GridControl = Me.GC3
        Me.GV3.Name = "GV3"
        Me.GV3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV3.OptionsView.ShowGroupPanel = False
        '
        'colFRECSAC_FREC_CODE_FK_PK
        '
        Me.colFRECSAC_FREC_CODE_FK_PK.Caption = "FRECSAC_FREC_CODE_FK_PK"
        Me.colFRECSAC_FREC_CODE_FK_PK.FieldName = "FRECSAC_FREC_CODE_FK_PK"
        Me.colFRECSAC_FREC_CODE_FK_PK.Name = "colFRECSAC_FREC_CODE_FK_PK"
        '
        'colFRECSAC_SAC_CODE_FK_PK
        '
        Me.colFRECSAC_SAC_CODE_FK_PK.Caption = "Code"
        Me.colFRECSAC_SAC_CODE_FK_PK.FieldName = "FRECSAC_SAC_CODE_FK_PK"
        Me.colFRECSAC_SAC_CODE_FK_PK.Name = "colFRECSAC_SAC_CODE_FK_PK"
        Me.colFRECSAC_SAC_CODE_FK_PK.Visible = True
        Me.colFRECSAC_SAC_CODE_FK_PK.VisibleIndex = 0
        Me.colFRECSAC_SAC_CODE_FK_PK.Width = 50
        '
        'colFRECSAC_SAC_CODE_FK_PK2
        '
        Me.colFRECSAC_SAC_CODE_FK_PK2.Caption = "Substance active"
        Me.colFRECSAC_SAC_CODE_FK_PK2.ColumnEdit = Me.lkup_FRECSAC
        Me.colFRECSAC_SAC_CODE_FK_PK2.FieldName = "FRECSAC_SAC_CODE_FK_PK"
        Me.colFRECSAC_SAC_CODE_FK_PK2.Name = "colFRECSAC_SAC_CODE_FK_PK2"
        Me.colFRECSAC_SAC_CODE_FK_PK2.Visible = True
        Me.colFRECSAC_SAC_CODE_FK_PK2.VisibleIndex = 1
        Me.colFRECSAC_SAC_CODE_FK_PK2.Width = 300
        '
        'lkup_FRECSAC
        '
        Me.lkup_FRECSAC.AutoHeight = False
        Me.lkup_FRECSAC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FRECSAC.Name = "lkup_FRECSAC"
        '
        'GC4
        '
        Me.GC4.DataMember = "FRECPR_FREC_PROD"
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
        Me.GC4.Location = New System.Drawing.Point(368, 0)
        Me.GC4.MainView = Me.GV4
        Me.GC4.Name = "GC4"
        Me.GC4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FRECPR})
        Me.GC4.Size = New System.Drawing.Size(323, 137)
        Me.GC4.TabIndex = 3
        Me.GC4.Tag = "[EDIT][ADD]"
        Me.GC4.UseEmbeddedNavigator = True
        Me.GC4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV4})
        '
        'GV4
        '
        Me.GV4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFRECPR_FREC_CODE_FK_PK, Me.colFRECPR_PR_CODE_FK_PK, Me.colFRECPR_PR_CODE_FK_PK2})
        Me.GV4.GridControl = Me.GC4
        Me.GV4.Name = "GV4"
        Me.GV4.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV4.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV4.OptionsView.ShowGroupPanel = False
        '
        'colFRECPR_FREC_CODE_FK_PK
        '
        Me.colFRECPR_FREC_CODE_FK_PK.Caption = "FRECPR_FREC_CODE_FK_PK"
        Me.colFRECPR_FREC_CODE_FK_PK.FieldName = "FRECPR_FREC_CODE_FK_PK"
        Me.colFRECPR_FREC_CODE_FK_PK.Name = "colFRECPR_FREC_CODE_FK_PK"
        '
        'colFRECPR_PR_CODE_FK_PK
        '
        Me.colFRECPR_PR_CODE_FK_PK.Caption = "Code"
        Me.colFRECPR_PR_CODE_FK_PK.FieldName = "FRECPR_PR_CODE_FK_PK"
        Me.colFRECPR_PR_CODE_FK_PK.Name = "colFRECPR_PR_CODE_FK_PK"
        Me.colFRECPR_PR_CODE_FK_PK.Visible = True
        Me.colFRECPR_PR_CODE_FK_PK.VisibleIndex = 0
        Me.colFRECPR_PR_CODE_FK_PK.Width = 50
        '
        'colFRECPR_PR_CODE_FK_PK2
        '
        Me.colFRECPR_PR_CODE_FK_PK2.Caption = "Produit"
        Me.colFRECPR_PR_CODE_FK_PK2.ColumnEdit = Me.lkup_FRECPR
        Me.colFRECPR_PR_CODE_FK_PK2.FieldName = "FRECPR_PR_CODE_FK_PK"
        Me.colFRECPR_PR_CODE_FK_PK2.Name = "colFRECPR_PR_CODE_FK_PK2"
        Me.colFRECPR_PR_CODE_FK_PK2.Visible = True
        Me.colFRECPR_PR_CODE_FK_PK2.VisibleIndex = 1
        Me.colFRECPR_PR_CODE_FK_PK2.Width = 252
        '
        'lkup_FRECPR
        '
        Me.lkup_FRECPR.AutoHeight = False
        Me.lkup_FRECPR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FRECPR.Name = "lkup_FRECPR"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GC1)
        Me.Panel4.Controls.Add(Me.GC2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(691, 137)
        Me.Panel4.TabIndex = 23
        '
        'GC1
        '
        Me.GC1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC1.DataMember = "FRECCPH_FREC_CLPH"
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
        Me.GC1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FRECCPH})
        Me.GC1.Size = New System.Drawing.Size(370, 137)
        Me.GC1.TabIndex = 2
        Me.GC1.Tag = "[EDIT][ADD]"
        Me.GC1.UseEmbeddedNavigator = True
        Me.GC1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFRECCPH_FREC_CODE_FK_PK, Me.colFRECCPH_CPH_CODE_FK_PK, Me.colFRECCPH_CPH_CODE_FK_PK2})
        Me.GV1.GridControl = Me.GC1
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV1.OptionsView.ShowGroupPanel = False
        '
        'colFRECCPH_FREC_CODE_FK_PK
        '
        Me.colFRECCPH_FREC_CODE_FK_PK.Caption = "FRECCPH_FREC_CODE_FK_PK"
        Me.colFRECCPH_FREC_CODE_FK_PK.FieldName = "FRECCPH_FREC_CODE_FK_PK"
        Me.colFRECCPH_FREC_CODE_FK_PK.Name = "colFRECCPH_FREC_CODE_FK_PK"
        '
        'colFRECCPH_CPH_CODE_FK_PK
        '
        Me.colFRECCPH_CPH_CODE_FK_PK.Caption = "Code"
        Me.colFRECCPH_CPH_CODE_FK_PK.FieldName = "FRECCPH_CPH_CODE_FK_PK"
        Me.colFRECCPH_CPH_CODE_FK_PK.Name = "colFRECCPH_CPH_CODE_FK_PK"
        Me.colFRECCPH_CPH_CODE_FK_PK.Visible = True
        Me.colFRECCPH_CPH_CODE_FK_PK.VisibleIndex = 0
        Me.colFRECCPH_CPH_CODE_FK_PK.Width = 50
        '
        'colFRECCPH_CPH_CODE_FK_PK2
        '
        Me.colFRECCPH_CPH_CODE_FK_PK2.Caption = "Classe pharmaco-thérapeutique"
        Me.colFRECCPH_CPH_CODE_FK_PK2.ColumnEdit = Me.lkup_FRECCPH
        Me.colFRECCPH_CPH_CODE_FK_PK2.FieldName = "FRECCPH_CPH_CODE_FK_PK"
        Me.colFRECCPH_CPH_CODE_FK_PK2.Name = "colFRECCPH_CPH_CODE_FK_PK2"
        Me.colFRECCPH_CPH_CODE_FK_PK2.Visible = True
        Me.colFRECCPH_CPH_CODE_FK_PK2.VisibleIndex = 1
        Me.colFRECCPH_CPH_CODE_FK_PK2.Width = 299
        '
        'lkup_FRECCPH
        '
        Me.lkup_FRECCPH.AutoHeight = False
        Me.lkup_FRECCPH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FRECCPH.Name = "lkup_FRECCPH"
        '
        'GC2
        '
        Me.GC2.DataMember = "FRECCCH_FREC_CLCH"
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
        Me.GC2.Location = New System.Drawing.Point(370, 0)
        Me.GC2.MainView = Me.GV2
        Me.GC2.Name = "GC2"
        Me.GC2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FRECCCH})
        Me.GC2.Size = New System.Drawing.Size(321, 137)
        Me.GC2.TabIndex = 3
        Me.GC2.Tag = "[EDIT][ADD]"
        Me.GC2.UseEmbeddedNavigator = True
        Me.GC2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFRECCCH_FREC_CODE_FK_PK, Me.colFRECCCH_CCH_CODE_FK_PK, Me.colFRECCCH_CCH_CODE_FK_PK2})
        Me.GV2.GridControl = Me.GC2
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV2.OptionsView.ShowGroupPanel = False
        '
        'colFRECCCH_FREC_CODE_FK_PK
        '
        Me.colFRECCCH_FREC_CODE_FK_PK.Caption = "FRECCCH_FREC_CODE_FK_PK"
        Me.colFRECCCH_FREC_CODE_FK_PK.FieldName = "FRECCCH_FREC_CODE_FK_PK"
        Me.colFRECCCH_FREC_CODE_FK_PK.Name = "colFRECCCH_FREC_CODE_FK_PK"
        '
        'colFRECCCH_CCH_CODE_FK_PK
        '
        Me.colFRECCCH_CCH_CODE_FK_PK.Caption = "Code"
        Me.colFRECCCH_CCH_CODE_FK_PK.FieldName = "FRECCCH_CCH_CODE_FK_PK"
        Me.colFRECCCH_CCH_CODE_FK_PK.Name = "colFRECCCH_CCH_CODE_FK_PK"
        Me.colFRECCCH_CCH_CODE_FK_PK.Visible = True
        Me.colFRECCCH_CCH_CODE_FK_PK.VisibleIndex = 0
        Me.colFRECCCH_CCH_CODE_FK_PK.Width = 50
        '
        'colFRECCCH_CCH_CODE_FK_PK2
        '
        Me.colFRECCCH_CCH_CODE_FK_PK2.Caption = "Classe chimique"
        Me.colFRECCCH_CCH_CODE_FK_PK2.ColumnEdit = Me.lkup_FRECCCH
        Me.colFRECCCH_CCH_CODE_FK_PK2.FieldName = "FRECCCH_CCH_CODE_FK_PK"
        Me.colFRECCCH_CCH_CODE_FK_PK2.Name = "colFRECCCH_CCH_CODE_FK_PK2"
        Me.colFRECCCH_CCH_CODE_FK_PK2.Visible = True
        Me.colFRECCCH_CCH_CODE_FK_PK2.VisibleIndex = 1
        Me.colFRECCCH_CCH_CODE_FK_PK2.Width = 250
        '
        'lkup_FRECCCH
        '
        Me.lkup_FRECCCH.AutoHeight = False
        Me.lkup_FRECCCH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FRECCCH.Name = "lkup_FRECCCH"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Panel11)
        Me.XtraTabPage2.Controls.Add(Me.Panel2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(691, 407)
        Me.XtraTabPage2.Text = "Mode de Reconstitution"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Panel16)
        Me.Panel11.Controls.Add(Me.Panel34)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(0, 133)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(691, 274)
        Me.Panel11.TabIndex = 49
        Me.Panel11.Tag = ""
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.GC23)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel16.Location = New System.Drawing.Point(0, 24)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(691, 250)
        Me.Panel16.TabIndex = 38
        Me.Panel16.Tag = "[ADD][EDIT]"
        '
        'GC23
        '
        Me.GC23.DataMember = "FRECTXR_FREC_TXTRECS"
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
        Me.GC23.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rm_Memo1})
        Me.GC23.Size = New System.Drawing.Size(691, 250)
        Me.GC23.TabIndex = 6
        Me.GC23.UseEmbeddedNavigator = True
        Me.GC23.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV23})
        '
        'GV23
        '
        Me.GV23.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFRECTXR_FREC_CODE_FK_PK, Me.colFRECTXR_TXTRECS})
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
        Me.GV23.RowHeight = 220
        Me.GV23.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colFRECTXR_FREC_CODE_FK_PK
        '
        Me.colFRECTXR_FREC_CODE_FK_PK.Caption = "FRECTXR_FREC_CODE_FK_PK"
        Me.colFRECTXR_FREC_CODE_FK_PK.FieldName = "FRECTXR_FREC_CODE_FK_PK"
        Me.colFRECTXR_FREC_CODE_FK_PK.Name = "colFRECTXR_FREC_CODE_FK_PK"
        '
        'colFRECTXR_TXTRECS
        '
        Me.colFRECTXR_TXTRECS.Caption = "FRECTXR_TXTRECS"
        Me.colFRECTXR_TXTRECS.ColumnEdit = Me.rm_Memo1
        Me.colFRECTXR_TXTRECS.FieldName = "FRECTXR_TXTRECS"
        Me.colFRECTXR_TXTRECS.Name = "colFRECTXR_TXTRECS"
        Me.colFRECTXR_TXTRECS.Visible = True
        Me.colFRECTXR_TXTRECS.VisibleIndex = 0
        '
        'rm_Memo1
        '
        Me.rm_Memo1.Name = "rm_Memo1"
        '
        'Panel34
        '
        Me.Panel34.Controls.Add(Me.LabelControl13)
        Me.Panel34.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel34.Location = New System.Drawing.Point(0, 0)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(691, 24)
        Me.Panel34.TabIndex = 37
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(2, 8)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl13.TabIndex = 19
        Me.LabelControl13.Text = "Texte"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GC21)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(691, 133)
        Me.Panel2.TabIndex = 26
        '
        'GC21
        '
        Me.GC21.DataMember = "FRECCOR_FREC_COMRECS"
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
        Me.GC21.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FRECCOR})
        Me.GC21.Size = New System.Drawing.Size(691, 133)
        Me.GC21.TabIndex = 3
        Me.GC21.Tag = "[EDIT][ADD]"
        Me.GC21.UseEmbeddedNavigator = True
        Me.GC21.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV21})
        '
        'GV21
        '
        Me.GV21.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFRECCOR_FREC_CODE_FK_PK, Me.colFRECCOR_CDF_COMRECS_FK_PK, Me.colFRECCOR_NUM_ORD_PK, Me.GridColumn7})
        Me.GV21.GridControl = Me.GC21
        Me.GV21.Name = "GV21"
        Me.GV21.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV21.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV21.OptionsView.ShowGroupPanel = False
        Me.GV21.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFRECCOR_NUM_ORD_PK, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFRECCOR_FREC_CODE_FK_PK
        '
        Me.colFRECCOR_FREC_CODE_FK_PK.Caption = "FRECCOR_FREC_CODE_FK_PK"
        Me.colFRECCOR_FREC_CODE_FK_PK.FieldName = "FRECCOR_FREC_CODE_FK_PK"
        Me.colFRECCOR_FREC_CODE_FK_PK.Name = "colFRECCOR_FREC_CODE_FK_PK"
        '
        'colFRECCOR_CDF_COMRECS_FK_PK
        '
        Me.colFRECCOR_CDF_COMRECS_FK_PK.Caption = "Code"
        Me.colFRECCOR_CDF_COMRECS_FK_PK.FieldName = "FRECCOR_CDF_COMRECS_FK_PK"
        Me.colFRECCOR_CDF_COMRECS_FK_PK.Name = "colFRECCOR_CDF_COMRECS_FK_PK"
        Me.colFRECCOR_CDF_COMRECS_FK_PK.Visible = True
        Me.colFRECCOR_CDF_COMRECS_FK_PK.VisibleIndex = 0
        Me.colFRECCOR_CDF_COMRECS_FK_PK.Width = 50
        '
        'colFRECCOR_NUM_ORD_PK
        '
        Me.colFRECCOR_NUM_ORD_PK.Caption = "N°"
        Me.colFRECCOR_NUM_ORD_PK.FieldName = "FRECCOR_NUM_ORD_PK"
        Me.colFRECCOR_NUM_ORD_PK.Name = "colFRECCOR_NUM_ORD_PK"
        Me.colFRECCOR_NUM_ORD_PK.Visible = True
        Me.colFRECCOR_NUM_ORD_PK.VisibleIndex = 2
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Mode de reconstitution/Commentaires"
        Me.GridColumn7.ColumnEdit = Me.lkup_FRECCOR
        Me.GridColumn7.FieldName = "FRECCOR_CDF_COMRECS_FK_PK"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        Me.GridColumn7.Width = 620
        '
        'lkup_FRECCOR
        '
        Me.lkup_FRECCOR.AutoHeight = False
        Me.lkup_FRECCOR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FRECCOR.Name = "lkup_FRECCOR"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.Panel9)
        Me.XtraTabPage3.Controls.Add(Me.Panel5)
        Me.XtraTabPage3.Controls.Add(Me.Panel8)
        Me.XtraTabPage3.Controls.Add(Me.Panel3)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(496, 399)
        Me.XtraTabPage3.Text = "Mode d'administration / Références officielles"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Controls.Add(Me.Panel12)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(0, 202)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(496, 96)
        Me.Panel9.TabIndex = 50
        Me.Panel9.Tag = ""
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.GC33)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(0, 24)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(496, 72)
        Me.Panel10.TabIndex = 38
        Me.Panel10.Tag = "[ADD][EDIT]"
        '
        'GC33
        '
        Me.GC33.DataMember = "FRECTXA_FREC_TXTADM"
        Me.GC33.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC33.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC33.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC33.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC33.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC33.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC33.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC33.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC33.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC33.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC33.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC33.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC33.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC33.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC33.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC33.EmbeddedNavigator.Name = ""
        Me.GC33.EmbeddedNavigator.TextStringFormat = ""
        Me.GC33.Location = New System.Drawing.Point(0, 0)
        Me.GC33.MainView = Me.GV33
        Me.GC33.Name = "GC33"
        Me.GC33.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rm_Memo2})
        Me.GC33.Size = New System.Drawing.Size(496, 72)
        Me.GC33.TabIndex = 7
        Me.GC33.UseEmbeddedNavigator = True
        Me.GC33.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV33})
        '
        'GV33
        '
        Me.GV33.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFRECTXA_FREC_CODE_FK_PK, Me.colFRECTXA_TXTADM})
        Me.GV33.GridControl = Me.GC33
        Me.GV33.GroupFormat = ""
        Me.GV33.GroupPanelText = " "
        Me.GV33.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GV33.Name = "GV33"
        Me.GV33.OptionsCustomization.AllowRowSizing = True
        Me.GV33.OptionsNavigation.AutoFocusNewRow = True
        Me.GV33.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV33.OptionsView.ShowColumnHeaders = False
        Me.GV33.OptionsView.ShowDetailButtons = False
        Me.GV33.OptionsView.ShowGroupPanel = False
        Me.GV33.OptionsView.ShowHorzLines = False
        Me.GV33.OptionsView.ShowIndicator = False
        Me.GV33.RowHeight = 55
        Me.GV33.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colFRECTXA_FREC_CODE_FK_PK
        '
        Me.colFRECTXA_FREC_CODE_FK_PK.Caption = "FRECTXA_FREC_CODE_FK_PK"
        Me.colFRECTXA_FREC_CODE_FK_PK.FieldName = "FRECTXA_FREC_CODE_FK_PK"
        Me.colFRECTXA_FREC_CODE_FK_PK.Name = "colFRECTXA_FREC_CODE_FK_PK"
        '
        'colFRECTXA_TXTADM
        '
        Me.colFRECTXA_TXTADM.Caption = "FRECTXA_TXTADM"
        Me.colFRECTXA_TXTADM.ColumnEdit = Me.rm_Memo2
        Me.colFRECTXA_TXTADM.FieldName = "FRECTXA_TXTADM"
        Me.colFRECTXA_TXTADM.Name = "colFRECTXA_TXTADM"
        Me.colFRECTXA_TXTADM.Visible = True
        Me.colFRECTXA_TXTADM.VisibleIndex = 0
        '
        'rm_Memo2
        '
        Me.rm_Memo2.Name = "rm_Memo2"
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.LabelControl4)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(496, 24)
        Me.Panel12.TabIndex = 37
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(2, 8)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl4.TabIndex = 19
        Me.LabelControl4.Text = "Texte"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GC31)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 101)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(496, 101)
        Me.Panel5.TabIndex = 27
        '
        'GC31
        '
        Me.GC31.DataMember = "FRECCOA_FREC_COMADM"
        Me.GC31.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC31.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC31.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC31.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC31.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC31.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC31.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC31.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC31.EmbeddedNavigator.Name = ""
        Me.GC31.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC31.Location = New System.Drawing.Point(0, 0)
        Me.GC31.MainView = Me.GV31
        Me.GC31.Name = "GC31"
        Me.GC31.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FRECCOA})
        Me.GC31.Size = New System.Drawing.Size(496, 101)
        Me.GC31.TabIndex = 3
        Me.GC31.Tag = "[EDIT][ADD]"
        Me.GC31.UseEmbeddedNavigator = True
        Me.GC31.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV31})
        '
        'GV31
        '
        Me.GV31.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFRECCOA_FREC_CODE_FK_PK, Me.colFRECCOA_CDF_COMADM_FK_PK, Me.colFRECCOA_NUM_ORD_PK, Me.GridColumn9})
        Me.GV31.GridControl = Me.GC31
        Me.GV31.Name = "GV31"
        Me.GV31.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV31.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV31.OptionsView.ShowGroupPanel = False
        Me.GV31.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFRECCOA_NUM_ORD_PK, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFRECCOA_FREC_CODE_FK_PK
        '
        Me.colFRECCOA_FREC_CODE_FK_PK.Caption = "FRECCOA_FREC_CODE_FK_PK"
        Me.colFRECCOA_FREC_CODE_FK_PK.FieldName = "FRECCOA_FREC_CODE_FK_PK"
        Me.colFRECCOA_FREC_CODE_FK_PK.Name = "colFRECCOA_FREC_CODE_FK_PK"
        '
        'colFRECCOA_CDF_COMADM_FK_PK
        '
        Me.colFRECCOA_CDF_COMADM_FK_PK.Caption = "Code"
        Me.colFRECCOA_CDF_COMADM_FK_PK.FieldName = "FRECCOA_CDF_COMADM_FK_PK"
        Me.colFRECCOA_CDF_COMADM_FK_PK.Name = "colFRECCOA_CDF_COMADM_FK_PK"
        Me.colFRECCOA_CDF_COMADM_FK_PK.Visible = True
        Me.colFRECCOA_CDF_COMADM_FK_PK.VisibleIndex = 0
        Me.colFRECCOA_CDF_COMADM_FK_PK.Width = 50
        '
        'colFRECCOA_NUM_ORD_PK
        '
        Me.colFRECCOA_NUM_ORD_PK.Caption = "N°"
        Me.colFRECCOA_NUM_ORD_PK.FieldName = "FRECCOA_NUM_ORD_PK"
        Me.colFRECCOA_NUM_ORD_PK.Name = "colFRECCOA_NUM_ORD_PK"
        Me.colFRECCOA_NUM_ORD_PK.Visible = True
        Me.colFRECCOA_NUM_ORD_PK.VisibleIndex = 2
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Mode d'administration / Commentaires"
        Me.GridColumn9.ColumnEdit = Me.lkup_FRECCOA
        Me.GridColumn9.FieldName = "FRECCOA_CDF_COMADM_FK_PK"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 1
        Me.GridColumn9.Width = 620
        '
        'lkup_FRECCOA
        '
        Me.lkup_FRECCOA.AutoHeight = False
        Me.lkup_FRECCOA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FRECCOA.Name = "lkup_FRECCOA"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.GC32)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 298)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(496, 101)
        Me.Panel8.TabIndex = 28
        '
        'GC32
        '
        Me.GC32.DataMember = "FRECAFS_FREC_AFSSAPS"
        Me.GC32.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC32.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC32.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC32.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC32.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC32.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC32.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC32.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC32.EmbeddedNavigator.Name = ""
        Me.GC32.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC32.Location = New System.Drawing.Point(0, 0)
        Me.GC32.MainView = Me.GV32
        Me.GC32.Name = "GC32"
        Me.GC32.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FRECAFS, Me.lkup_FRECAFS_SP})
        Me.GC32.Size = New System.Drawing.Size(496, 101)
        Me.GC32.TabIndex = 3
        Me.GC32.Tag = "[EDIT][ADD]"
        Me.GC32.UseEmbeddedNavigator = True
        Me.GC32.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV32})
        '
        'GV32
        '
        Me.GV32.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFRECAFS_FREC_CODE_FK_PK, Me.colFRECAFS_DATE_PK, Me.colFRECAFS_CDF_DOCUMENT_FK_PK, Me.colFRECAFS_SP_CODE_FK_PK})
        Me.GV32.GridControl = Me.GC32
        Me.GV32.Name = "GV32"
        Me.GV32.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV32.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV32.OptionsView.ShowGroupPanel = False
        '
        'colFRECAFS_FREC_CODE_FK_PK
        '
        Me.colFRECAFS_FREC_CODE_FK_PK.Caption = "FRECAFS_FREC_CODE_FK_PK"
        Me.colFRECAFS_FREC_CODE_FK_PK.FieldName = "FRECAFS_FREC_CODE_FK_PK"
        Me.colFRECAFS_FREC_CODE_FK_PK.Name = "colFRECAFS_FREC_CODE_FK_PK"
        '
        'colFRECAFS_DATE_PK
        '
        Me.colFRECAFS_DATE_PK.Caption = "Date"
        Me.colFRECAFS_DATE_PK.FieldName = "FRECAFS_DATE_PK"
        Me.colFRECAFS_DATE_PK.Name = "colFRECAFS_DATE_PK"
        Me.colFRECAFS_DATE_PK.Visible = True
        Me.colFRECAFS_DATE_PK.VisibleIndex = 1
        Me.colFRECAFS_DATE_PK.Width = 68
        '
        'colFRECAFS_CDF_DOCUMENT_FK_PK
        '
        Me.colFRECAFS_CDF_DOCUMENT_FK_PK.Caption = "Références officielles"
        Me.colFRECAFS_CDF_DOCUMENT_FK_PK.ColumnEdit = Me.lkup_FRECAFS
        Me.colFRECAFS_CDF_DOCUMENT_FK_PK.FieldName = "FRECAFS_CDF_DOCUMENT_FK_PK"
        Me.colFRECAFS_CDF_DOCUMENT_FK_PK.Name = "colFRECAFS_CDF_DOCUMENT_FK_PK"
        Me.colFRECAFS_CDF_DOCUMENT_FK_PK.Visible = True
        Me.colFRECAFS_CDF_DOCUMENT_FK_PK.VisibleIndex = 0
        Me.colFRECAFS_CDF_DOCUMENT_FK_PK.Width = 198
        '
        'lkup_FRECAFS
        '
        Me.lkup_FRECAFS.AutoHeight = False
        Me.lkup_FRECAFS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FRECAFS.Name = "lkup_FRECAFS"
        '
        'colFRECAFS_SP_CODE_FK_PK
        '
        Me.colFRECAFS_SP_CODE_FK_PK.Caption = "Spécialités"
        Me.colFRECAFS_SP_CODE_FK_PK.ColumnEdit = Me.lkup_FRECAFS_SP
        Me.colFRECAFS_SP_CODE_FK_PK.FieldName = "FRECAFS_SP_CODE_FK_PK"
        Me.colFRECAFS_SP_CODE_FK_PK.Name = "colFRECAFS_SP_CODE_FK_PK"
        Me.colFRECAFS_SP_CODE_FK_PK.Visible = True
        Me.colFRECAFS_SP_CODE_FK_PK.VisibleIndex = 2
        Me.colFRECAFS_SP_CODE_FK_PK.Width = 267
        '
        'lkup_FRECAFS_SP
        '
        Me.lkup_FRECAFS_SP.AutoHeight = False
        Me.lkup_FRECAFS_SP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FRECAFS_SP.Name = "lkup_FRECAFS_SP"
        Me.lkup_FRECAFS_SP.NullText = ""
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GC22)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(496, 101)
        Me.Panel3.TabIndex = 27
        '
        'GC22
        '
        Me.GC22.DataMember = "FRECVO_RECONSADM_VOIE"
        Me.GC22.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.GC22.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FRECVO})
        Me.GC22.Size = New System.Drawing.Size(496, 101)
        Me.GC22.TabIndex = 3
        Me.GC22.Tag = "[EDIT][ADD]"
        Me.GC22.UseEmbeddedNavigator = True
        Me.GC22.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV22})
        '
        'GV22
        '
        Me.GV22.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFRECVO_FREC_CODE_FK_PK, Me.colFRECVO_CDF_VO_CODE_FK_PK, Me.colFRECVO_NUMORD, Me.GridColumn8})
        Me.GV22.GridControl = Me.GC22
        Me.GV22.Name = "GV22"
        Me.GV22.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV22.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV22.OptionsView.ShowGroupPanel = False
        Me.GV22.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFRECVO_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFRECVO_FREC_CODE_FK_PK
        '
        Me.colFRECVO_FREC_CODE_FK_PK.Caption = "FRECVO_FREC_CODE_FK_PK"
        Me.colFRECVO_FREC_CODE_FK_PK.FieldName = "FRECVO_FREC_CODE_FK_PK"
        Me.colFRECVO_FREC_CODE_FK_PK.Name = "colFRECVO_FREC_CODE_FK_PK"
        '
        'colFRECVO_CDF_VO_CODE_FK_PK
        '
        Me.colFRECVO_CDF_VO_CODE_FK_PK.Caption = "Code"
        Me.colFRECVO_CDF_VO_CODE_FK_PK.FieldName = "FRECVO_CDF_VO_CODE_FK_PK"
        Me.colFRECVO_CDF_VO_CODE_FK_PK.Name = "colFRECVO_CDF_VO_CODE_FK_PK"
        Me.colFRECVO_CDF_VO_CODE_FK_PK.Visible = True
        Me.colFRECVO_CDF_VO_CODE_FK_PK.VisibleIndex = 0
        Me.colFRECVO_CDF_VO_CODE_FK_PK.Width = 49
        '
        'colFRECVO_NUMORD
        '
        Me.colFRECVO_NUMORD.Caption = "N°"
        Me.colFRECVO_NUMORD.FieldName = "FRECVO_NUMORD"
        Me.colFRECVO_NUMORD.Name = "colFRECVO_NUMORD"
        Me.colFRECVO_NUMORD.Visible = True
        Me.colFRECVO_NUMORD.VisibleIndex = 2
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Voie d'administration "
        Me.GridColumn8.ColumnEdit = Me.lkup_FRECVO
        Me.GridColumn8.FieldName = "FRECVO_CDF_VO_CODE_FK_PK"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        Me.GridColumn8.Width = 621
        '
        'lkup_FRECVO
        '
        Me.lkup_FRECVO.AutoHeight = False
        Me.lkup_FRECVO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FRECVO.Name = "lkup_FRECVO"
        Me.lkup_FRECVO.NullText = ""
        '
        'FreccpH_TA
        '
        Me.FreccpH_TA.ClearBeforeFill = True
        '
        'FrecccH_TA
        '
        Me.FrecccH_TA.ClearBeforeFill = True
        '
        'FrecsaC_TA
        '
        Me.FrecsaC_TA.ClearBeforeFill = True
        '
        'FrecpR_TA
        '
        Me.FrecpR_TA.ClearBeforeFill = True
        '
        'FreccH_TA
        '
        Me.FreccH_TA.ClearBeforeFill = True
        '
        'FrecsP_TA
        '
        Me.FrecsP_TA.ClearBeforeFill = True
        '
        'FreccoR_TA
        '
        Me.FreccoR_TA.ClearBeforeFill = True
        '
        'FrecvO_TA
        '
        Me.FrecvO_TA.ClearBeforeFill = True
        '
        'FrectxR_TA
        '
        Me.FrectxR_TA.ClearBeforeFill = True
        '
        'FreccoA_TA
        '
        Me.FreccoA_TA.ClearBeforeFill = True
        '
        'FrecafS_TA
        '
        Me.FrecafS_TA.ClearBeforeFill = True
        '
        'FrectxA_TA
        '
        Me.FrectxA_TA.ClearBeforeFill = True
        '
        'Frm_Reconst_Administ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(825, 574)
        Me.Name = "Frm_Reconst_Administ"
        Me.Text = "Reconstitution / Administration"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_Reconst_Administ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.GC5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FRECCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FRECSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.GC3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FRECSAC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FRECPR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FRECCPH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FRECCCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        CType(Me.GC23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rm_Memo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel34.ResumeLayout(False)
        Me.Panel34.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GC21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FRECCOR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        CType(Me.GC33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rm_Memo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.GC31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FRECCOA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        CType(Me.GC32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FRECAFS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FRECAFS_SP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.GC22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FRECVO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FreC_TA As Theriaque.dsTheriaque_Reconst_AdministTableAdapters.FREC_RECONSADMTableAdapter
    Friend WithEvents DsTheriaque_Reconst_Administ As Theriaque.dsTheriaque_Reconst_Administ
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
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
    Friend WithEvents FreccpH_TA As Theriaque.dsTheriaque_Reconst_AdministTableAdapters.FRECCPH_FREC_CLPHTableAdapter
    Friend WithEvents colFRECCPH_FREC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFRECCPH_CPH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFRECCPH_CPH_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FRECCPH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FrecccH_TA As Theriaque.dsTheriaque_Reconst_AdministTableAdapters.FRECCCH_FREC_CLCHTableAdapter
    Friend WithEvents FrecsaC_TA As Theriaque.dsTheriaque_Reconst_AdministTableAdapters.FRECSAC_FREC_SUBACTTableAdapter
    Friend WithEvents colFRECSAC_FREC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFRECSAC_SAC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFRECSAC_SAC_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FRECSAC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFRECCCH_FREC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFRECCCH_CCH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFRECCCH_CCH_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FRECCCH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFRECPR_FREC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFRECPR_PR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFRECPR_PR_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FRECPR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FrecpR_TA As Theriaque.dsTheriaque_Reconst_AdministTableAdapters.FRECPR_FREC_PRODTableAdapter
    Friend WithEvents FreccH_TA As Theriaque.dsTheriaque_Reconst_AdministTableAdapters.FRECCH_RECONSTCHTableAdapter
    Friend WithEvents colFRECCH_FREC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFRECCH_CH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFRECCH_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FRECCH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFRECSP_FREC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFRECSP_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFRECSP_SP_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FRECSP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FrecsP_TA As Theriaque.dsTheriaque_Reconst_AdministTableAdapters.FRECSP_RECONST_SPECTableAdapter
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GC22 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV22 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GC21 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV21 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FreccoR_TA As Theriaque.dsTheriaque_Reconst_AdministTableAdapters.FRECCOR_FREC_COMRECSTableAdapter
    Friend WithEvents colFRECCOR_FREC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFRECCOR_CDF_COMRECS_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFRECCOR_NUM_ORD_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FRECCOR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFRECVO_FREC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFRECVO_CDF_VO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFRECVO_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FRECVO As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FrecvO_TA As Theriaque.dsTheriaque_Reconst_AdministTableAdapters.FRECVO_RECONSADM_VOIETableAdapter
    Friend WithEvents FrectxR_TA As Theriaque.dsTheriaque_Reconst_AdministTableAdapters.FRECTXR_FREC_TXTRECSTableAdapter
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GC31 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV31 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFRECCOA_FREC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFRECCOA_CDF_COMADM_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFRECCOA_NUM_ORD_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FRECCOA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FreccoA_TA As Theriaque.dsTheriaque_Reconst_AdministTableAdapters.FRECCOA_FREC_COMADMTableAdapter
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents GC32 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV32 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFRECAFS_FREC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFRECAFS_DATE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FrecafS_TA As Theriaque.dsTheriaque_Reconst_AdministTableAdapters.FRECAFS_FREC_AFSSAPSTableAdapter
    Friend WithEvents colFRECAFS_CDF_DOCUMENT_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FRECAFS As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFRECAFS_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FRECAFS_SP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FrectxA_TA As Theriaque.dsTheriaque_Reconst_AdministTableAdapters.FRECTXA_FREC_TXTADMTableAdapter
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Panel34 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GC23 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV23 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFRECTXR_FREC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFRECTXR_TXTRECS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rm_Memo1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GC33 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV33 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFRECTXA_FREC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFRECTXA_TXTADM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rm_Memo2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit

End Class
