<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Fiche_Infotherapeutique
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
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GC15 = New DevExpress.XtraGrid.GridControl
        Me.GV15 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSPFTH_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPFTH_FTH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPFTH_SP_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_SPFTH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.lkup_SPCH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit
        Me.DsTheriaque_CriteresChoix = New Theriaque.dsTheriaque_CriteresChoix
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.DateEdit3 = New DevExpress.XtraEditors.DateEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.Panel23 = New System.Windows.Forms.Panel
        Me.GC_DCL6 = New DevExpress.XtraGrid.GridControl
        Me.GV_DCL6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFTHPR_FTH_CODE_SQ_PK_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFTHPR_PR_CODE_SQ_PK_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFTHPR_PR_CODE_SQ_PK_FK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FTHPR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel24 = New System.Windows.Forms.Panel
        Me.GC_DCL5 = New DevExpress.XtraGrid.GridControl
        Me.GV_DCL5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFTHSAU_FTH_CODE_SQ_PK_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFTHSAU_SAU_CODE_SQ_PK_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFTHSAU_SAU_CODE_SQ_PK_FK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FTHSAU = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.GC_DCL4 = New DevExpress.XtraGrid.GridControl
        Me.GV_DCL4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFTHSAC_FTH_CODE_SQ_PK_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFTHSAC_SAC_CODE_SQ_PK_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFTHSAC_SAC_CODE_SQ_PK_FK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FTHSAC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.GC_DCL8 = New DevExpress.XtraGrid.GridControl
        Me.GV_DCL8 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFTHCATC_FTH_CODE_SQ_PK_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFTHCATC_CATC_CODE_PK_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFTHCATC_CATC_CODE_PK_FK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FTHCATC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemLookUpEdit9 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.GC_DCL2 = New DevExpress.XtraGrid.GridControl
        Me.GV_DCL2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFTHCCH_FTH_CODE_SQ_PK_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFTHCCH_CCH_CODE_PK_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFTHCCH_CCH_CODE_PK_FK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FTHCCH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.GC_DCL1 = New DevExpress.XtraGrid.GridControl
        Me.GV_DCL1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFTHCPH_FTH_CODE_SQ_PK_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFTHCPH_CPH_CODE_PK_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFTHCPH_CPH_CODE_PK_FK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FTHCPH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.FtH_TA = New Theriaque.dsTheriaque_CriteresChoixTableAdapters.FTH_FICHEINFOTHERAPEUTIQUETableAdapter
        Me.SPFTH_TA = New Theriaque.dsTheriaque_CriteresChoixTableAdapters.SPFTH_SPEC_INFOTHERAPEUTIQUETableAdapter
        Me.Panel22 = New System.Windows.Forms.Panel
        Me.GC8 = New DevExpress.XtraGrid.GridControl
        Me.GV8 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCATC_CODE_PK_D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCATC_CODE_PK2_D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_ATC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colCATC_NOMF_D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCATC_NOMA_D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCATC_DATECR_D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel19 = New System.Windows.Forms.Panel
        Me.Panel20 = New System.Windows.Forms.Panel
        Me.Panel21 = New System.Windows.Forms.Panel
        Me.colIT1PR_FIT_CODE_FK_PK_D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT1PR_PR_CODE_FK_PK_D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT1PR_PR_CODE_FK_PK2_D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IT1PR_D = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colIT1SAU_FIT_CODE_FK_PK_D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT1SAU_SAU_CODE_FK_PK_D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT1_IT1SAU_D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IT1SAU_D = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.Panel17 = New System.Windows.Forms.Panel
        Me.Panel18 = New System.Windows.Forms.Panel
        Me.colIT1SAC_SAC_CODE_FK_PK_D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT1SAC_FIT_CODE_FK_PK_D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT1_TERM1SAC_D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IT1SAC_D = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colIT1CC_FIT_CODE_FK_PK_D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4_D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IT1CC_D = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colIT1CC_NUMORD_D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.colIT1CCH_FIT_CODE_FK_PK_D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT1CCH_CCH_CODE_FK_PK_D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT1CCH_CCH_CODE_FK_PK2_D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IT1CCH_D = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colIT1CPH_FIT_CODE_FK_PK_D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT1CPH_CPH_CODE_FK_PK_D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT1CPH_CPH_CODE_FK_PK2_D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IT1CPH_D = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.DsTheriaque_AnalyseOrdonance = New Theriaque.dsTheriaque_AnalyseOrdonance
        Me.DsTheriaque1 = New Theriaque.dsTheriaque
        Me.FTHCPH = New Theriaque.dsTheriaque_CriteresChoixTableAdapters.FTHCPH_FIT_CLASSEPHARMTHERTableAdapter
        Me.FTHCCH = New Theriaque.dsTheriaque_CriteresChoixTableAdapters.FTHCCH_FIT_CLASSECHIMIQUETableAdapter
        Me.FTHSAC = New Theriaque.dsTheriaque_CriteresChoixTableAdapters.FTHSAC_FIT_SUBACTIVETableAdapter
        Me.FTHSAU = New Theriaque.dsTheriaque_CriteresChoixTableAdapters.FTHSAU_FIT_SUBAUXILIAIRETableAdapter
        Me.IC1SAC_TERME1SUBACTTableAdapter1 = New Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.IC1SAC_TERME1SUBACTTableAdapter
        Me.FTHPR = New Theriaque.dsTheriaque_CriteresChoixTableAdapters.FTHPR_FIT_PRODUITTableAdapter
        Me.FTHCATC = New Theriaque.dsTheriaque_CriteresChoixTableAdapters.FTHCATC_FIT_CLASSEATCTableAdapter
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
        Me.Panel12.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GC15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_SPFTH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_SPCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_CriteresChoix, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel23.SuspendLayout()
        CType(Me.GC_DCL6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_DCL6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FTHPR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel24.SuspendLayout()
        CType(Me.GC_DCL5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_DCL5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FTHSAU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.GC_DCL4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_DCL4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FTHSAC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.GC_DCL8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_DCL8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FTHCATC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.GC_DCL2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_DCL2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FTHCCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.GC_DCL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_DCL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FTHCPH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel22.SuspendLayout()
        CType(Me.GC8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_ATC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel19.SuspendLayout()
        CType(Me.lkup_IT1PR_D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IT1SAU_D, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel16.SuspendLayout()
        CType(Me.lkup_IT1SAC_D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IT1CC_D, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.lkup_IT1CCH_D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IT1CPH_D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_AnalyseOrdonance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(808, 584)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.XtraTabControl1)
        Me.PanMain.Size = New System.Drawing.Size(690, 497)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(808, 87)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(808, 28)
        Me.Label1.Text = "Fiche d'information thérapeutique"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(690, 87)
        Me.Panel1.Size = New System.Drawing.Size(118, 497)
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit1.Visible = False
        '
        'GroupBox
        '
        Me.GroupBox.Size = New System.Drawing.Size(808, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit2.Visible = False
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 3)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(686, 491)
        Me.XtraTabControl1.TabIndex = 38
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2, Me.XtraTabPage1})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panel12)
        Me.XtraTabPage1.Controls.Add(Me.GroupBox1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(677, 460)
        Me.XtraTabPage1.Text = "Fiche"
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.Panel2)
        Me.Panel12.Controls.Add(Me.Panel14)
        Me.Panel12.Controls.Add(Me.Panel13)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(0, 104)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(677, 356)
        Me.Panel12.TabIndex = 39
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GC15)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 228)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(677, 128)
        Me.Panel2.TabIndex = 39
        '
        'GC15
        '
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
        Me.GC15.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_SPCH, Me.lkup_SPFTH, Me.RepositoryItemComboBox1})
        Me.GC15.Size = New System.Drawing.Size(677, 128)
        Me.GC15.TabIndex = 4
        Me.GC15.Tag = "[EDIT][ADD]"
        Me.GC15.UseEmbeddedNavigator = True
        Me.GC15.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV15})
        '
        'GV15
        '
        Me.GV15.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSPFTH_SP_CODE_FK_PK, Me.colSPFTH_FTH_CODE_FK_PK, Me.colSPFTH_SP_CODE_FK_PK2})
        Me.GV15.GridControl = Me.GC15
        Me.GV15.Name = "GV15"
        Me.GV15.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV15.OptionsView.ShowGroupPanel = False
        '
        'colSPFTH_SP_CODE_FK_PK
        '
        Me.colSPFTH_SP_CODE_FK_PK.Caption = "Code"
        Me.colSPFTH_SP_CODE_FK_PK.FieldName = "SPFTH_SP_CODE_FK_PK"
        Me.colSPFTH_SP_CODE_FK_PK.Name = "colSPFTH_SP_CODE_FK_PK"
        Me.colSPFTH_SP_CODE_FK_PK.Visible = True
        Me.colSPFTH_SP_CODE_FK_PK.VisibleIndex = 0
        Me.colSPFTH_SP_CODE_FK_PK.Width = 50
        '
        'colSPFTH_FTH_CODE_FK_PK
        '
        Me.colSPFTH_FTH_CODE_FK_PK.Caption = "SPFTH_FTH_CODE_FK_PK"
        Me.colSPFTH_FTH_CODE_FK_PK.FieldName = "SPFTH_FTH_CODE_FK_PK"
        Me.colSPFTH_FTH_CODE_FK_PK.Name = "colSPFTH_FTH_CODE_FK_PK"
        '
        'colSPFTH_SP_CODE_FK_PK2
        '
        Me.colSPFTH_SP_CODE_FK_PK2.Caption = "Spécialité"
        Me.colSPFTH_SP_CODE_FK_PK2.ColumnEdit = Me.lkup_SPFTH
        Me.colSPFTH_SP_CODE_FK_PK2.FieldName = "SPFTH_SP_CODE_FK_PK"
        Me.colSPFTH_SP_CODE_FK_PK2.Name = "colSPFTH_SP_CODE_FK_PK2"
        Me.colSPFTH_SP_CODE_FK_PK2.Visible = True
        Me.colSPFTH_SP_CODE_FK_PK2.VisibleIndex = 1
        Me.colSPFTH_SP_CODE_FK_PK2.Width = 585
        '
        'lkup_SPFTH
        '
        Me.lkup_SPFTH.AutoHeight = False
        Me.lkup_SPFTH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_SPFTH.Name = "lkup_SPFTH"
        '
        'lkup_SPCH
        '
        Me.lkup_SPCH.AutoHeight = False
        Me.lkup_SPCH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_SPCH.Name = "lkup_SPCH"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.MemoEdit1)
        Me.Panel14.Location = New System.Drawing.Point(0, 24)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(499, 200)
        Me.Panel14.TabIndex = 38
        Me.Panel14.Tag = "[EDIT][ADD]"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_CriteresChoix, "FTH_FICHEINFOTHERAPEUTIQUE.FTH_TEXTE", True))
        Me.MemoEdit1.Location = New System.Drawing.Point(0, 0)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(499, 200)
        Me.MemoEdit1.TabIndex = 36
        Me.MemoEdit1.Tag = ""
        '
        'DsTheriaque_CriteresChoix
        '
        Me.DsTheriaque_CriteresChoix.DataSetName = "dsTheriaque_CriteresChoix"
        Me.DsTheriaque_CriteresChoix.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.LabelControl6)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(677, 24)
        Me.Panel13.TabIndex = 37
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(3, 7)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl6.TabIndex = 19
        Me.LabelControl6.Text = "Texte"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.TextEdit2)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.DateEdit3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(677, 104)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_CriteresChoix, "FTH_FICHEINFOTHERAPEUTIQUE.FTH_CODE_SQ_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(87, 16)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(139, 20)
        Me.txtCode.TabIndex = 16
        Me.txtCode.Tag = "[NOEDIT][NOADD]"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(59, 70)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl5.TabIndex = 19
        Me.LabelControl5.Text = "Titre"
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_CriteresChoix, "FTH_FICHEINFOTHERAPEUTIQUE.FTH_TITRE", True))
        Me.TextEdit2.Location = New System.Drawing.Point(87, 67)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(254, 20)
        Me.TextEdit2.TabIndex = 20
        Me.TextEdit2.Tag = "[ADD][EDIT]"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(27, 45)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl4.TabIndex = 18
        Me.LabelControl4.Text = "Date du JO"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(41, 19)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl3.TabIndex = 17
        Me.LabelControl3.Text = "Fiche N°"
        '
        'DateEdit3
        '
        Me.DateEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_CriteresChoix, "FTH_FICHEINFOTHERAPEUTIQUE.FTH_DATE_JO", True))
        Me.DateEdit3.EditValue = Nothing
        Me.DateEdit3.Location = New System.Drawing.Point(87, 42)
        Me.DateEdit3.Name = "DateEdit3"
        Me.DateEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit3.Size = New System.Drawing.Size(139, 20)
        Me.DateEdit3.TabIndex = 21
        Me.DateEdit3.Tag = "[ADD][EDIT]"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Panel10)
        Me.XtraTabPage2.Controls.Add(Me.Panel7)
        Me.XtraTabPage2.Controls.Add(Me.Panel3)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(499, 442)
        Me.XtraTabPage2.Text = "Déclinaison"
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Panel23)
        Me.Panel10.Controls.Add(Me.Panel24)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 307)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(499, 142)
        Me.Panel10.TabIndex = 3
        '
        'Panel23
        '
        Me.Panel23.Controls.Add(Me.GC_DCL6)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel23.Location = New System.Drawing.Point(158, 0)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(341, 142)
        Me.Panel23.TabIndex = 1
        '
        'GC_DCL6
        '
        Me.GC_DCL6.DataMember = "IT1PR_TERME1PRODUIT"
        Me.GC_DCL6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC_DCL6.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC_DCL6.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC_DCL6.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC_DCL6.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC_DCL6.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC_DCL6.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC_DCL6.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC_DCL6.EmbeddedNavigator.Name = ""
        Me.GC_DCL6.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC_DCL6.Location = New System.Drawing.Point(0, 0)
        Me.GC_DCL6.MainView = Me.GV_DCL6
        Me.GC_DCL6.Name = "GC_DCL6"
        Me.GC_DCL6.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FTHPR})
        Me.GC_DCL6.Size = New System.Drawing.Size(341, 142)
        Me.GC_DCL6.TabIndex = 14
        Me.GC_DCL6.Tag = "[EDIT][ADD]"
        Me.GC_DCL6.UseEmbeddedNavigator = True
        Me.GC_DCL6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_DCL6})
        '
        'GV_DCL6
        '
        Me.GV_DCL6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFTHPR_FTH_CODE_SQ_PK_FK, Me.colFTHPR_PR_CODE_SQ_PK_FK, Me.colFTHPR_PR_CODE_SQ_PK_FK2})
        Me.GV_DCL6.GridControl = Me.GC_DCL6
        Me.GV_DCL6.Name = "GV_DCL6"
        Me.GV_DCL6.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV_DCL6.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV_DCL6.OptionsView.ShowGroupPanel = False
        '
        'colFTHPR_FTH_CODE_SQ_PK_FK
        '
        Me.colFTHPR_FTH_CODE_SQ_PK_FK.Caption = "IT1PR_FIT_CODE_FK_PK"
        Me.colFTHPR_FTH_CODE_SQ_PK_FK.FieldName = "FTHPR_FTH_CODE_SQ_PK_FK"
        Me.colFTHPR_FTH_CODE_SQ_PK_FK.Name = "colFTHPR_FTH_CODE_SQ_PK_FK"
        '
        'colFTHPR_PR_CODE_SQ_PK_FK
        '
        Me.colFTHPR_PR_CODE_SQ_PK_FK.Caption = "Code"
        Me.colFTHPR_PR_CODE_SQ_PK_FK.FieldName = "FTHPR_PR_CODE_SQ_PK_FK"
        Me.colFTHPR_PR_CODE_SQ_PK_FK.Name = "colFTHPR_PR_CODE_SQ_PK_FK"
        Me.colFTHPR_PR_CODE_SQ_PK_FK.Visible = True
        Me.colFTHPR_PR_CODE_SQ_PK_FK.VisibleIndex = 0
        Me.colFTHPR_PR_CODE_SQ_PK_FK.Width = 50
        '
        'colFTHPR_PR_CODE_SQ_PK_FK2
        '
        Me.colFTHPR_PR_CODE_SQ_PK_FK2.Caption = "Produit1"
        Me.colFTHPR_PR_CODE_SQ_PK_FK2.ColumnEdit = Me.lkup_FTHPR
        Me.colFTHPR_PR_CODE_SQ_PK_FK2.FieldName = "FTHPR_PR_CODE_SQ_PK_FK"
        Me.colFTHPR_PR_CODE_SQ_PK_FK2.Name = "colFTHPR_PR_CODE_SQ_PK_FK2"
        Me.colFTHPR_PR_CODE_SQ_PK_FK2.Visible = True
        Me.colFTHPR_PR_CODE_SQ_PK_FK2.VisibleIndex = 1
        Me.colFTHPR_PR_CODE_SQ_PK_FK2.Width = 232
        '
        'lkup_FTHPR
        '
        Me.lkup_FTHPR.AutoHeight = False
        Me.lkup_FTHPR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FTHPR.Name = "lkup_FTHPR"
        '
        'Panel24
        '
        Me.Panel24.Controls.Add(Me.GC_DCL5)
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel24.Location = New System.Drawing.Point(0, 0)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(336, 142)
        Me.Panel24.TabIndex = 0
        '
        'GC_DCL5
        '
        Me.GC_DCL5.DataMember = "IT1SAU_TERME1SUBAUX"
        Me.GC_DCL5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC_DCL5.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC_DCL5.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC_DCL5.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC_DCL5.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC_DCL5.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC_DCL5.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC_DCL5.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC_DCL5.EmbeddedNavigator.Name = ""
        Me.GC_DCL5.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC_DCL5.Location = New System.Drawing.Point(0, 0)
        Me.GC_DCL5.MainView = Me.GV_DCL5
        Me.GC_DCL5.Name = "GC_DCL5"
        Me.GC_DCL5.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FTHSAU})
        Me.GC_DCL5.Size = New System.Drawing.Size(336, 142)
        Me.GC_DCL5.TabIndex = 12
        Me.GC_DCL5.Tag = "[EDIT][ADD]"
        Me.GC_DCL5.UseEmbeddedNavigator = True
        Me.GC_DCL5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_DCL5})
        '
        'GV_DCL5
        '
        Me.GV_DCL5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFTHSAU_FTH_CODE_SQ_PK_FK, Me.colFTHSAU_SAU_CODE_SQ_PK_FK, Me.colFTHSAU_SAU_CODE_SQ_PK_FK2})
        Me.GV_DCL5.GridControl = Me.GC_DCL5
        Me.GV_DCL5.Name = "GV_DCL5"
        Me.GV_DCL5.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV_DCL5.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV_DCL5.OptionsView.ShowGroupPanel = False
        '
        'colFTHSAU_FTH_CODE_SQ_PK_FK
        '
        Me.colFTHSAU_FTH_CODE_SQ_PK_FK.FieldName = "FTHSAU_FTH_CODE_SQ_PK_FK"
        Me.colFTHSAU_FTH_CODE_SQ_PK_FK.Name = "colFTHSAU_FTH_CODE_SQ_PK_FK"
        '
        'colFTHSAU_SAU_CODE_SQ_PK_FK
        '
        Me.colFTHSAU_SAU_CODE_SQ_PK_FK.Caption = "Code"
        Me.colFTHSAU_SAU_CODE_SQ_PK_FK.FieldName = "FTHSAU_SAU_CODE_SQ_PK_FK"
        Me.colFTHSAU_SAU_CODE_SQ_PK_FK.Name = "colFTHSAU_SAU_CODE_SQ_PK_FK"
        Me.colFTHSAU_SAU_CODE_SQ_PK_FK.Visible = True
        Me.colFTHSAU_SAU_CODE_SQ_PK_FK.VisibleIndex = 0
        Me.colFTHSAU_SAU_CODE_SQ_PK_FK.Width = 50
        '
        'colFTHSAU_SAU_CODE_SQ_PK_FK2
        '
        Me.colFTHSAU_SAU_CODE_SQ_PK_FK2.Caption = "Excipient1"
        Me.colFTHSAU_SAU_CODE_SQ_PK_FK2.ColumnEdit = Me.lkup_FTHSAU
        Me.colFTHSAU_SAU_CODE_SQ_PK_FK2.FieldName = "FTHSAU_SAU_CODE_SQ_PK_FK"
        Me.colFTHSAU_SAU_CODE_SQ_PK_FK2.Name = "colFTHSAU_SAU_CODE_SQ_PK_FK2"
        Me.colFTHSAU_SAU_CODE_SQ_PK_FK2.Visible = True
        Me.colFTHSAU_SAU_CODE_SQ_PK_FK2.VisibleIndex = 1
        Me.colFTHSAU_SAU_CODE_SQ_PK_FK2.Width = 275
        '
        'lkup_FTHSAU
        '
        Me.lkup_FTHSAU.AutoHeight = False
        Me.lkup_FTHSAU.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FTHSAU.Name = "lkup_FTHSAU"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 148)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(499, 159)
        Me.Panel7.TabIndex = 2
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.GC_DCL4)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(158, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(341, 159)
        Me.Panel8.TabIndex = 1
        '
        'GC_DCL4
        '
        Me.GC_DCL4.DataMember = "IT1SAC_TERME1SUBACTIVE"
        Me.GC_DCL4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC_DCL4.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC_DCL4.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC_DCL4.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC_DCL4.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC_DCL4.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC_DCL4.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC_DCL4.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC_DCL4.EmbeddedNavigator.Name = ""
        Me.GC_DCL4.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC_DCL4.Location = New System.Drawing.Point(0, 0)
        Me.GC_DCL4.MainView = Me.GV_DCL4
        Me.GC_DCL4.Name = "GC_DCL4"
        Me.GC_DCL4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FTHSAC})
        Me.GC_DCL4.Size = New System.Drawing.Size(341, 159)
        Me.GC_DCL4.TabIndex = 10
        Me.GC_DCL4.Tag = "[EDIT][ADD]"
        Me.GC_DCL4.UseEmbeddedNavigator = True
        Me.GC_DCL4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_DCL4})
        '
        'GV_DCL4
        '
        Me.GV_DCL4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFTHSAC_FTH_CODE_SQ_PK_FK, Me.colFTHSAC_SAC_CODE_SQ_PK_FK, Me.colFTHSAC_SAC_CODE_SQ_PK_FK2})
        Me.GV_DCL4.GridControl = Me.GC_DCL4
        Me.GV_DCL4.Name = "GV_DCL4"
        Me.GV_DCL4.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV_DCL4.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV_DCL4.OptionsView.ShowGroupPanel = False
        '
        'colFTHSAC_FTH_CODE_SQ_PK_FK
        '
        Me.colFTHSAC_FTH_CODE_SQ_PK_FK.Caption = "Code"
        Me.colFTHSAC_FTH_CODE_SQ_PK_FK.FieldName = "FTHSAC_FTH_CODE_SQ_PK_FK"
        Me.colFTHSAC_FTH_CODE_SQ_PK_FK.Name = "colFTHSAC_FTH_CODE_SQ_PK_FK"
        Me.colFTHSAC_FTH_CODE_SQ_PK_FK.Visible = True
        Me.colFTHSAC_FTH_CODE_SQ_PK_FK.VisibleIndex = 0
        Me.colFTHSAC_FTH_CODE_SQ_PK_FK.Width = 50
        '
        'colFTHSAC_SAC_CODE_SQ_PK_FK
        '
        Me.colFTHSAC_SAC_CODE_SQ_PK_FK.Caption = "IT1SAC_FIT_CODE_FK_PK"
        Me.colFTHSAC_SAC_CODE_SQ_PK_FK.FieldName = "FTHSAC_SAC_CODE_SQ_PK_FK"
        Me.colFTHSAC_SAC_CODE_SQ_PK_FK.Name = "colFTHSAC_SAC_CODE_SQ_PK_FK"
        '
        'colFTHSAC_SAC_CODE_SQ_PK_FK2
        '
        Me.colFTHSAC_SAC_CODE_SQ_PK_FK2.Caption = "Substance active1"
        Me.colFTHSAC_SAC_CODE_SQ_PK_FK2.ColumnEdit = Me.lkup_FTHSAC
        Me.colFTHSAC_SAC_CODE_SQ_PK_FK2.FieldName = "FTHSAC_SAC_CODE_SQ_PK_FK"
        Me.colFTHSAC_SAC_CODE_SQ_PK_FK2.Name = "colFTHSAC_SAC_CODE_SQ_PK_FK2"
        Me.colFTHSAC_SAC_CODE_SQ_PK_FK2.Visible = True
        Me.colFTHSAC_SAC_CODE_SQ_PK_FK2.VisibleIndex = 1
        Me.colFTHSAC_SAC_CODE_SQ_PK_FK2.Width = 232
        '
        'lkup_FTHSAC
        '
        Me.lkup_FTHSAC.AutoHeight = False
        Me.lkup_FTHSAC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FTHSAC.Name = "lkup_FTHSAC"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.GC_DCL8)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(336, 159)
        Me.Panel9.TabIndex = 0
        '
        'GC_DCL8
        '
        Me.GC_DCL8.DataMember = "IT1CC_TERM1COMCLASSE"
        Me.GC_DCL8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC_DCL8.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC_DCL8.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC_DCL8.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC_DCL8.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC_DCL8.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC_DCL8.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC_DCL8.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC_DCL8.EmbeddedNavigator.Name = ""
        Me.GC_DCL8.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC_DCL8.Location = New System.Drawing.Point(0, 0)
        Me.GC_DCL8.MainView = Me.GV_DCL8
        Me.GC_DCL8.Name = "GC_DCL8"
        Me.GC_DCL8.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit9, Me.lkup_FTHCATC})
        Me.GC_DCL8.Size = New System.Drawing.Size(336, 159)
        Me.GC_DCL8.TabIndex = 14
        Me.GC_DCL8.Tag = "[EDIT][ADD]"
        Me.GC_DCL8.UseEmbeddedNavigator = True
        Me.GC_DCL8.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_DCL8})
        '
        'GV_DCL8
        '
        Me.GV_DCL8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFTHCATC_FTH_CODE_SQ_PK_FK, Me.colFTHCATC_CATC_CODE_PK_FK, Me.colFTHCATC_CATC_CODE_PK_FK2})
        Me.GV_DCL8.GridControl = Me.GC_DCL8
        Me.GV_DCL8.Name = "GV_DCL8"
        Me.GV_DCL8.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV_DCL8.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV_DCL8.OptionsView.ShowGroupPanel = False
        '
        'colFTHCATC_FTH_CODE_SQ_PK_FK
        '
        Me.colFTHCATC_FTH_CODE_SQ_PK_FK.FieldName = "FTHCATC_FTH_CODE_SQ_PK_FK"
        Me.colFTHCATC_FTH_CODE_SQ_PK_FK.Name = "colFTHCATC_FTH_CODE_SQ_PK_FK"
        Me.colFTHCATC_FTH_CODE_SQ_PK_FK.Width = 50
        '
        'colFTHCATC_CATC_CODE_PK_FK
        '
        Me.colFTHCATC_CATC_CODE_PK_FK.Caption = "Code"
        Me.colFTHCATC_CATC_CODE_PK_FK.FieldName = "FTHCATC_CATC_CODE_PK_FK"
        Me.colFTHCATC_CATC_CODE_PK_FK.Name = "colFTHCATC_CATC_CODE_PK_FK"
        Me.colFTHCATC_CATC_CODE_PK_FK.Visible = True
        Me.colFTHCATC_CATC_CODE_PK_FK.VisibleIndex = 1
        '
        'colFTHCATC_CATC_CODE_PK_FK2
        '
        Me.colFTHCATC_CATC_CODE_PK_FK2.Caption = "Classe ATC"
        Me.colFTHCATC_CATC_CODE_PK_FK2.ColumnEdit = Me.lkup_FTHCATC
        Me.colFTHCATC_CATC_CODE_PK_FK2.FieldName = "FTHCATC_CATC_CODE_PK_FK"
        Me.colFTHCATC_CATC_CODE_PK_FK2.Name = "colFTHCATC_CATC_CODE_PK_FK2"
        Me.colFTHCATC_CATC_CODE_PK_FK2.Visible = True
        Me.colFTHCATC_CATC_CODE_PK_FK2.VisibleIndex = 0
        Me.colFTHCATC_CATC_CODE_PK_FK2.Width = 265
        '
        'lkup_FTHCATC
        '
        Me.lkup_FTHCATC.AutoHeight = False
        Me.lkup_FTHCATC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FTHCATC.Name = "lkup_FTHCATC"
        '
        'RepositoryItemLookUpEdit9
        '
        Me.RepositoryItemLookUpEdit9.AutoHeight = False
        Me.RepositoryItemLookUpEdit9.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit9.Name = "RepositoryItemLookUpEdit9"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(499, 148)
        Me.Panel3.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GC_DCL2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(158, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(341, 148)
        Me.Panel5.TabIndex = 1
        '
        'GC_DCL2
        '
        Me.GC_DCL2.DataMember = "IT1CCH_TERME1CLCHIM"
        Me.GC_DCL2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC_DCL2.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC_DCL2.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC_DCL2.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC_DCL2.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC_DCL2.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC_DCL2.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC_DCL2.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC_DCL2.EmbeddedNavigator.Name = ""
        Me.GC_DCL2.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC_DCL2.Location = New System.Drawing.Point(0, 0)
        Me.GC_DCL2.MainView = Me.GV_DCL2
        Me.GC_DCL2.Name = "GC_DCL2"
        Me.GC_DCL2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FTHCCH})
        Me.GC_DCL2.Size = New System.Drawing.Size(341, 148)
        Me.GC_DCL2.TabIndex = 4
        Me.GC_DCL2.Tag = "[EDIT][ADD]"
        Me.GC_DCL2.UseEmbeddedNavigator = True
        Me.GC_DCL2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_DCL2})
        '
        'GV_DCL2
        '
        Me.GV_DCL2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFTHCCH_FTH_CODE_SQ_PK_FK, Me.colFTHCCH_CCH_CODE_PK_FK, Me.colFTHCCH_CCH_CODE_PK_FK2})
        Me.GV_DCL2.GridControl = Me.GC_DCL2
        Me.GV_DCL2.Name = "GV_DCL2"
        Me.GV_DCL2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV_DCL2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV_DCL2.OptionsView.ShowGroupPanel = False
        '
        'colFTHCCH_FTH_CODE_SQ_PK_FK
        '
        Me.colFTHCCH_FTH_CODE_SQ_PK_FK.Caption = "IT1CCH_FIT_CODE_FK_PK"
        Me.colFTHCCH_FTH_CODE_SQ_PK_FK.FieldName = "FTHCCH_FTH_CODE_SQ_PK_FK"
        Me.colFTHCCH_FTH_CODE_SQ_PK_FK.Name = "colFTHCCH_FTH_CODE_SQ_PK_FK"
        '
        'colFTHCCH_CCH_CODE_PK_FK
        '
        Me.colFTHCCH_CCH_CODE_PK_FK.Caption = "Code"
        Me.colFTHCCH_CCH_CODE_PK_FK.FieldName = "FTHCCH_CCH_CODE_PK_FK"
        Me.colFTHCCH_CCH_CODE_PK_FK.Name = "colFTHCCH_CCH_CODE_PK_FK"
        Me.colFTHCCH_CCH_CODE_PK_FK.Visible = True
        Me.colFTHCCH_CCH_CODE_PK_FK.VisibleIndex = 0
        Me.colFTHCCH_CCH_CODE_PK_FK.Width = 50
        '
        'colFTHCCH_CCH_CODE_PK_FK2
        '
        Me.colFTHCCH_CCH_CODE_PK_FK2.Caption = "Classe chimique1"
        Me.colFTHCCH_CCH_CODE_PK_FK2.ColumnEdit = Me.lkup_FTHCCH
        Me.colFTHCCH_CCH_CODE_PK_FK2.FieldName = "FTHCCH_CCH_CODE_PK_FK"
        Me.colFTHCCH_CCH_CODE_PK_FK2.Name = "colFTHCCH_CCH_CODE_PK_FK2"
        Me.colFTHCCH_CCH_CODE_PK_FK2.Visible = True
        Me.colFTHCCH_CCH_CODE_PK_FK2.VisibleIndex = 1
        Me.colFTHCCH_CCH_CODE_PK_FK2.Width = 232
        '
        'lkup_FTHCCH
        '
        Me.lkup_FTHCCH.AutoHeight = False
        Me.lkup_FTHCCH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FTHCCH.Name = "lkup_FTHCCH"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GC_DCL1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(336, 148)
        Me.Panel6.TabIndex = 0
        '
        'GC_DCL1
        '
        Me.GC_DCL1.DataMember = "IT1CPH_TERME1CLPHARMTHER"
        Me.GC_DCL1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC_DCL1.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC_DCL1.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC_DCL1.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC_DCL1.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC_DCL1.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC_DCL1.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC_DCL1.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC_DCL1.EmbeddedNavigator.Name = ""
        Me.GC_DCL1.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC_DCL1.Location = New System.Drawing.Point(0, 0)
        Me.GC_DCL1.MainView = Me.GV_DCL1
        Me.GC_DCL1.Name = "GC_DCL1"
        Me.GC_DCL1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FTHCPH})
        Me.GC_DCL1.Size = New System.Drawing.Size(336, 148)
        Me.GC_DCL1.TabIndex = 4
        Me.GC_DCL1.Tag = "[EDIT][ADD]"
        Me.GC_DCL1.UseEmbeddedNavigator = True
        Me.GC_DCL1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_DCL1})
        '
        'GV_DCL1
        '
        Me.GV_DCL1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFTHCPH_FTH_CODE_SQ_PK_FK, Me.colFTHCPH_CPH_CODE_PK_FK, Me.colFTHCPH_CPH_CODE_PK_FK2})
        Me.GV_DCL1.GridControl = Me.GC_DCL1
        Me.GV_DCL1.Name = "GV_DCL1"
        Me.GV_DCL1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV_DCL1.OptionsView.ShowGroupPanel = False
        '
        'colFTHCPH_FTH_CODE_SQ_PK_FK
        '
        Me.colFTHCPH_FTH_CODE_SQ_PK_FK.Caption = "IT1CPH_FIT_CODE_FK_PK"
        Me.colFTHCPH_FTH_CODE_SQ_PK_FK.FieldName = "FTHCPH_FTH_CODE_SQ_PK_FK"
        Me.colFTHCPH_FTH_CODE_SQ_PK_FK.Name = "colFTHCPH_FTH_CODE_SQ_PK_FK"
        '
        'colFTHCPH_CPH_CODE_PK_FK
        '
        Me.colFTHCPH_CPH_CODE_PK_FK.Caption = "Code"
        Me.colFTHCPH_CPH_CODE_PK_FK.FieldName = "FTHCPH_CPH_CODE_PK_FK"
        Me.colFTHCPH_CPH_CODE_PK_FK.Name = "colFTHCPH_CPH_CODE_PK_FK"
        Me.colFTHCPH_CPH_CODE_PK_FK.Tag = ""
        Me.colFTHCPH_CPH_CODE_PK_FK.Visible = True
        Me.colFTHCPH_CPH_CODE_PK_FK.VisibleIndex = 0
        Me.colFTHCPH_CPH_CODE_PK_FK.Width = 50
        '
        'colFTHCPH_CPH_CODE_PK_FK2
        '
        Me.colFTHCPH_CPH_CODE_PK_FK2.Caption = "Classe pharmaco thérapeutique1"
        Me.colFTHCPH_CPH_CODE_PK_FK2.ColumnEdit = Me.lkup_FTHCPH
        Me.colFTHCPH_CPH_CODE_PK_FK2.FieldName = "FTHCPH_CPH_CODE_PK_FK"
        Me.colFTHCPH_CPH_CODE_PK_FK2.Name = "colFTHCPH_CPH_CODE_PK_FK2"
        Me.colFTHCPH_CPH_CODE_PK_FK2.Visible = True
        Me.colFTHCPH_CPH_CODE_PK_FK2.VisibleIndex = 1
        Me.colFTHCPH_CPH_CODE_PK_FK2.Width = 275
        '
        'lkup_FTHCPH
        '
        Me.lkup_FTHCPH.AutoHeight = False
        Me.lkup_FTHCPH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FTHCPH.Name = "lkup_FTHCPH"
        '
        'FtH_TA
        '
        Me.FtH_TA.ClearBeforeFill = True
        '
        'SPFTH_TA
        '
        Me.SPFTH_TA.ClearBeforeFill = True
        '
        'Panel22
        '
        Me.Panel22.Controls.Add(Me.GC8)
        Me.Panel22.Location = New System.Drawing.Point(3, 324)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(680, 138)
        Me.Panel22.TabIndex = 3
        '
        'GC8
        '
        Me.GC8.DataMember = "IT1CC_TERM1COMCLASSE"
        Me.GC8.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC8.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC8.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC8.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC8.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC8.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC8.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC8.EmbeddedNavigator.Name = ""
        Me.GC8.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC8.Location = New System.Drawing.Point(329, 8)
        Me.GC8.MainView = Me.GV8
        Me.GC8.Name = "GC8"
        Me.GC8.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.lkup_ATC})
        Me.GC8.Size = New System.Drawing.Size(343, 127)
        Me.GC8.TabIndex = 14
        Me.GC8.Tag = "[EDIT][ADD]"
        Me.GC8.UseEmbeddedNavigator = True
        Me.GC8.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV8})
        '
        'GV8
        '
        Me.GV8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCATC_CODE_PK_D, Me.colCATC_CODE_PK2_D, Me.colCATC_NOMF_D, Me.colCATC_NOMA_D, Me.colCATC_DATECR_D})
        Me.GV8.GridControl = Me.GC8
        Me.GV8.Name = "GV8"
        Me.GV8.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV8.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV8.OptionsView.ShowGroupPanel = False
        '
        'colCATC_CODE_PK_D
        '
        Me.colCATC_CODE_PK_D.Caption = "Code"
        Me.colCATC_CODE_PK_D.FieldName = "CATC_CODE_PK"
        Me.colCATC_CODE_PK_D.Name = "colCATC_CODE_PK_D"
        Me.colCATC_CODE_PK_D.Visible = True
        Me.colCATC_CODE_PK_D.VisibleIndex = 0
        '
        'colCATC_CODE_PK2_D
        '
        Me.colCATC_CODE_PK2_D.Caption = "Classe ATC"
        Me.colCATC_CODE_PK2_D.ColumnEdit = Me.lkup_ATC
        Me.colCATC_CODE_PK2_D.FieldName = "CATC_CODE_PK"
        Me.colCATC_CODE_PK2_D.Name = "colCATC_CODE_PK2_D"
        Me.colCATC_CODE_PK2_D.Visible = True
        Me.colCATC_CODE_PK2_D.VisibleIndex = 1
        '
        'lkup_ATC
        '
        Me.lkup_ATC.AutoHeight = False
        Me.lkup_ATC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_ATC.Name = "lkup_ATC"
        '
        'colCATC_NOMF_D
        '
        Me.colCATC_NOMF_D.Caption = "GridColumn1"
        Me.colCATC_NOMF_D.FieldName = "CATC_NOMF"
        Me.colCATC_NOMF_D.Name = "colCATC_NOMF_D"
        '
        'colCATC_NOMA_D
        '
        Me.colCATC_NOMA_D.Caption = "GridColumn1"
        Me.colCATC_NOMA_D.FieldName = "CATC_NOMA"
        Me.colCATC_NOMA_D.Name = "colCATC_NOMA_D"
        '
        'colCATC_DATECR_D
        '
        Me.colCATC_DATECR_D.Caption = "GridColumn1"
        Me.colCATC_DATECR_D.FieldName = "CATC_DATECR"
        Me.colCATC_DATECR_D.Name = "colCATC_DATECR_D"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'Panel19
        '
        Me.Panel19.Controls.Add(Me.Panel20)
        Me.Panel19.Controls.Add(Me.Panel21)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel19.Location = New System.Drawing.Point(0, 212)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(683, 106)
        Me.Panel19.TabIndex = 2
        '
        'Panel20
        '
        Me.Panel20.Location = New System.Drawing.Point(0, 0)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(200, 100)
        Me.Panel20.TabIndex = 0
        '
        'Panel21
        '
        Me.Panel21.Location = New System.Drawing.Point(0, 0)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(200, 100)
        Me.Panel21.TabIndex = 1
        '
        'colIT1PR_FIT_CODE_FK_PK_D
        '
        Me.colIT1PR_FIT_CODE_FK_PK_D.Caption = "IT1PR_FIT_CODE_FK_PK"
        Me.colIT1PR_FIT_CODE_FK_PK_D.FieldName = "IT1PR_FIT_CODE_FK_PK"
        Me.colIT1PR_FIT_CODE_FK_PK_D.Name = "colIT1PR_FIT_CODE_FK_PK_D"
        '
        'colIT1PR_PR_CODE_FK_PK_D
        '
        Me.colIT1PR_PR_CODE_FK_PK_D.Caption = "Code"
        Me.colIT1PR_PR_CODE_FK_PK_D.FieldName = "IT1PR_PR_CODE_FK_PK"
        Me.colIT1PR_PR_CODE_FK_PK_D.Name = "colIT1PR_PR_CODE_FK_PK_D"
        Me.colIT1PR_PR_CODE_FK_PK_D.Visible = True
        Me.colIT1PR_PR_CODE_FK_PK_D.VisibleIndex = 0
        Me.colIT1PR_PR_CODE_FK_PK_D.Width = 50
        '
        'colIT1PR_PR_CODE_FK_PK2_D
        '
        Me.colIT1PR_PR_CODE_FK_PK2_D.Caption = "Produit1"
        Me.colIT1PR_PR_CODE_FK_PK2_D.ColumnEdit = Me.lkup_IT1PR_D
        Me.colIT1PR_PR_CODE_FK_PK2_D.FieldName = "IT1PR_PR_CODE_FK_PK"
        Me.colIT1PR_PR_CODE_FK_PK2_D.Name = "colIT1PR_PR_CODE_FK_PK2_D"
        Me.colIT1PR_PR_CODE_FK_PK2_D.Visible = True
        Me.colIT1PR_PR_CODE_FK_PK2_D.VisibleIndex = 1
        Me.colIT1PR_PR_CODE_FK_PK2_D.Width = 232
        '
        'lkup_IT1PR_D
        '
        Me.lkup_IT1PR_D.AutoHeight = False
        Me.lkup_IT1PR_D.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IT1PR_D.Name = "lkup_IT1PR_D"
        '
        'colIT1SAU_FIT_CODE_FK_PK_D
        '
        Me.colIT1SAU_FIT_CODE_FK_PK_D.Caption = "IT1SAU_FIT_CODE_FK_PK"
        Me.colIT1SAU_FIT_CODE_FK_PK_D.FieldName = "IT1SAU_FIT_CODE_FK_PK"
        Me.colIT1SAU_FIT_CODE_FK_PK_D.Name = "colIT1SAU_FIT_CODE_FK_PK_D"
        '
        'colIT1SAU_SAU_CODE_FK_PK_D
        '
        Me.colIT1SAU_SAU_CODE_FK_PK_D.Caption = "Code"
        Me.colIT1SAU_SAU_CODE_FK_PK_D.FieldName = "IT1SAU_SAU_CODE_FK_PK"
        Me.colIT1SAU_SAU_CODE_FK_PK_D.Name = "colIT1SAU_SAU_CODE_FK_PK_D"
        Me.colIT1SAU_SAU_CODE_FK_PK_D.Visible = True
        Me.colIT1SAU_SAU_CODE_FK_PK_D.VisibleIndex = 0
        Me.colIT1SAU_SAU_CODE_FK_PK_D.Width = 50
        '
        'colIT1_IT1SAU_D
        '
        Me.colIT1_IT1SAU_D.Caption = "Excipient1"
        Me.colIT1_IT1SAU_D.ColumnEdit = Me.lkup_IT1SAU_D
        Me.colIT1_IT1SAU_D.FieldName = "IT1SAU_SAU_CODE_FK_PK"
        Me.colIT1_IT1SAU_D.Name = "colIT1_IT1SAU_D"
        Me.colIT1_IT1SAU_D.Visible = True
        Me.colIT1_IT1SAU_D.VisibleIndex = 1
        Me.colIT1_IT1SAU_D.Width = 275
        '
        'lkup_IT1SAU_D
        '
        Me.lkup_IT1SAU_D.AutoHeight = False
        Me.lkup_IT1SAU_D.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IT1SAU_D.Name = "lkup_IT1SAU_D"
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.Panel17)
        Me.Panel16.Controls.Add(Me.Panel18)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel16.Location = New System.Drawing.Point(0, 106)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(683, 106)
        Me.Panel16.TabIndex = 1
        '
        'Panel17
        '
        Me.Panel17.Location = New System.Drawing.Point(0, 0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(200, 100)
        Me.Panel17.TabIndex = 0
        '
        'Panel18
        '
        Me.Panel18.Location = New System.Drawing.Point(0, 0)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(200, 100)
        Me.Panel18.TabIndex = 1
        '
        'colIT1SAC_SAC_CODE_FK_PK_D
        '
        Me.colIT1SAC_SAC_CODE_FK_PK_D.Caption = "Code"
        Me.colIT1SAC_SAC_CODE_FK_PK_D.FieldName = "IT1SAC_SAC_CODE_FK_PK"
        Me.colIT1SAC_SAC_CODE_FK_PK_D.Name = "colIT1SAC_SAC_CODE_FK_PK_D"
        Me.colIT1SAC_SAC_CODE_FK_PK_D.Visible = True
        Me.colIT1SAC_SAC_CODE_FK_PK_D.VisibleIndex = 0
        Me.colIT1SAC_SAC_CODE_FK_PK_D.Width = 50
        '
        'colIT1SAC_FIT_CODE_FK_PK_D
        '
        Me.colIT1SAC_FIT_CODE_FK_PK_D.Caption = "IT1SAC_FIT_CODE_FK_PK"
        Me.colIT1SAC_FIT_CODE_FK_PK_D.FieldName = "IT1SAC_FIT_CODE_FK_PK"
        Me.colIT1SAC_FIT_CODE_FK_PK_D.Name = "colIT1SAC_FIT_CODE_FK_PK_D"
        '
        'colIT1_TERM1SAC_D
        '
        Me.colIT1_TERM1SAC_D.Caption = "Substance active1"
        Me.colIT1_TERM1SAC_D.ColumnEdit = Me.lkup_IT1SAC_D
        Me.colIT1_TERM1SAC_D.FieldName = "IT1SAC_SAC_CODE_FK_PK"
        Me.colIT1_TERM1SAC_D.Name = "colIT1_TERM1SAC_D"
        Me.colIT1_TERM1SAC_D.Visible = True
        Me.colIT1_TERM1SAC_D.VisibleIndex = 1
        Me.colIT1_TERM1SAC_D.Width = 232
        '
        'lkup_IT1SAC_D
        '
        Me.lkup_IT1SAC_D.AutoHeight = False
        Me.lkup_IT1SAC_D.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IT1SAC_D.Name = "lkup_IT1SAC_D"
        '
        'colIT1CC_FIT_CODE_FK_PK_D
        '
        Me.colIT1CC_FIT_CODE_FK_PK_D.Caption = "GridColumn3"
        Me.colIT1CC_FIT_CODE_FK_PK_D.FieldName = "IT1CC_FIT_CODE_FK_PK"
        Me.colIT1CC_FIT_CODE_FK_PK_D.Name = "colIT1CC_FIT_CODE_FK_PK_D"
        '
        'GridColumn4_D
        '
        Me.GridColumn4_D.Caption = "Commentaire classe1"
        Me.GridColumn4_D.ColumnEdit = Me.lkup_IT1CC_D
        Me.GridColumn4_D.FieldName = "IT1CC_CDF_CC_CODE_FK_PK"
        Me.GridColumn4_D.Name = "GridColumn4_D"
        Me.GridColumn4_D.Visible = True
        Me.GridColumn4_D.VisibleIndex = 0
        Me.GridColumn4_D.Width = 162
        '
        'lkup_IT1CC_D
        '
        Me.lkup_IT1CC_D.AutoHeight = False
        Me.lkup_IT1CC_D.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IT1CC_D.Name = "lkup_IT1CC_D"
        '
        'colIT1CC_NUMORD_D
        '
        Me.colIT1CC_NUMORD_D.Caption = "N°"
        Me.colIT1CC_NUMORD_D.FieldName = "IT1CC_NUMORD"
        Me.colIT1CC_NUMORD_D.Name = "colIT1CC_NUMORD_D"
        Me.colIT1CC_NUMORD_D.Visible = True
        Me.colIT1CC_NUMORD_D.VisibleIndex = 1
        Me.colIT1CC_NUMORD_D.Width = 50
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel15)
        Me.Panel4.Controls.Add(Me.Panel11)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(683, 106)
        Me.Panel4.TabIndex = 0
        '
        'Panel15
        '
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(200, 100)
        Me.Panel15.TabIndex = 0
        '
        'Panel11
        '
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(200, 100)
        Me.Panel11.TabIndex = 1
        '
        'colIT1CCH_FIT_CODE_FK_PK_D
        '
        Me.colIT1CCH_FIT_CODE_FK_PK_D.Caption = "IT1CCH_FIT_CODE_FK_PK"
        Me.colIT1CCH_FIT_CODE_FK_PK_D.FieldName = "IT1CCH_FIT_CODE_FK_PK"
        Me.colIT1CCH_FIT_CODE_FK_PK_D.Name = "colIT1CCH_FIT_CODE_FK_PK_D"
        '
        'colIT1CCH_CCH_CODE_FK_PK_D
        '
        Me.colIT1CCH_CCH_CODE_FK_PK_D.Caption = "Code"
        Me.colIT1CCH_CCH_CODE_FK_PK_D.FieldName = "IT1CCH_CCH_CODE_FK_PK"
        Me.colIT1CCH_CCH_CODE_FK_PK_D.Name = "colIT1CCH_CCH_CODE_FK_PK_D"
        Me.colIT1CCH_CCH_CODE_FK_PK_D.Visible = True
        Me.colIT1CCH_CCH_CODE_FK_PK_D.VisibleIndex = 0
        Me.colIT1CCH_CCH_CODE_FK_PK_D.Width = 50
        '
        'colIT1CCH_CCH_CODE_FK_PK2_D
        '
        Me.colIT1CCH_CCH_CODE_FK_PK2_D.Caption = "Classe chimique1"
        Me.colIT1CCH_CCH_CODE_FK_PK2_D.ColumnEdit = Me.lkup_IT1CCH_D
        Me.colIT1CCH_CCH_CODE_FK_PK2_D.FieldName = "IT1CCH_CCH_CODE_FK_PK"
        Me.colIT1CCH_CCH_CODE_FK_PK2_D.Name = "colIT1CCH_CCH_CODE_FK_PK2_D"
        Me.colIT1CCH_CCH_CODE_FK_PK2_D.Visible = True
        Me.colIT1CCH_CCH_CODE_FK_PK2_D.VisibleIndex = 1
        Me.colIT1CCH_CCH_CODE_FK_PK2_D.Width = 232
        '
        'lkup_IT1CCH_D
        '
        Me.lkup_IT1CCH_D.AutoHeight = False
        Me.lkup_IT1CCH_D.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IT1CCH_D.Name = "lkup_IT1CCH_D"
        '
        'colIT1CPH_FIT_CODE_FK_PK_D
        '
        Me.colIT1CPH_FIT_CODE_FK_PK_D.Caption = "IT1CPH_FIT_CODE_FK_PK"
        Me.colIT1CPH_FIT_CODE_FK_PK_D.FieldName = "IT1CPH_FIT_CODE_FK_PK"
        Me.colIT1CPH_FIT_CODE_FK_PK_D.Name = "colIT1CPH_FIT_CODE_FK_PK_D"
        '
        'colIT1CPH_CPH_CODE_FK_PK_D
        '
        Me.colIT1CPH_CPH_CODE_FK_PK_D.Caption = "Code"
        Me.colIT1CPH_CPH_CODE_FK_PK_D.FieldName = "IT1CPH_CPH_CODE_FK_PK"
        Me.colIT1CPH_CPH_CODE_FK_PK_D.Name = "colIT1CPH_CPH_CODE_FK_PK_D"
        Me.colIT1CPH_CPH_CODE_FK_PK_D.Tag = ""
        Me.colIT1CPH_CPH_CODE_FK_PK_D.Visible = True
        Me.colIT1CPH_CPH_CODE_FK_PK_D.VisibleIndex = 0
        Me.colIT1CPH_CPH_CODE_FK_PK_D.Width = 50
        '
        'colIT1CPH_CPH_CODE_FK_PK2_D
        '
        Me.colIT1CPH_CPH_CODE_FK_PK2_D.Caption = "Classe pharmaco thérapeutique1"
        Me.colIT1CPH_CPH_CODE_FK_PK2_D.ColumnEdit = Me.lkup_IT1CPH_D
        Me.colIT1CPH_CPH_CODE_FK_PK2_D.FieldName = "IT1CPH_CPH_CODE_FK_PK"
        Me.colIT1CPH_CPH_CODE_FK_PK2_D.Name = "colIT1CPH_CPH_CODE_FK_PK2_D"
        Me.colIT1CPH_CPH_CODE_FK_PK2_D.Visible = True
        Me.colIT1CPH_CPH_CODE_FK_PK2_D.VisibleIndex = 1
        Me.colIT1CPH_CPH_CODE_FK_PK2_D.Width = 275
        '
        'lkup_IT1CPH_D
        '
        Me.lkup_IT1CPH_D.AutoHeight = False
        Me.lkup_IT1CPH_D.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IT1CPH_D.Name = "lkup_IT1CPH_D"
        '
        'DsTheriaque_AnalyseOrdonance
        '
        Me.DsTheriaque_AnalyseOrdonance.DataSetName = "dsTheriaque_AnalyseOrdonance"
        Me.DsTheriaque_AnalyseOrdonance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsTheriaque1
        '
        Me.DsTheriaque1.DataSetName = "dsTheriaque"
        Me.DsTheriaque1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FTHCPH
        '
        Me.FTHCPH.ClearBeforeFill = True
        '
        'FTHCCH
        '
        Me.FTHCCH.ClearBeforeFill = True
        '
        'FTHSAC
        '
        Me.FTHSAC.ClearBeforeFill = True
        '
        'FTHSAU
        '
        Me.FTHSAU.ClearBeforeFill = True
        '
        'IC1SAC_TERME1SUBACTTableAdapter1
        '
        Me.IC1SAC_TERME1SUBACTTableAdapter1.ClearBeforeFill = True
        '
        'FTHPR
        '
        Me.FTHPR.ClearBeforeFill = True
        '
        'FTHCATC
        '
        Me.FTHCATC.ClearBeforeFill = True
        '
        'Frm_Fiche_Infotherapeutique
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(808, 584)
        Me.Name = "Frm_Fiche_Infotherapeutique"
        Me.Text = "Fiche d'information thérapeutique"
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
        Me.Panel12.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.GC15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_SPFTH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_SPCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_CriteresChoix, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel23.ResumeLayout(False)
        CType(Me.GC_DCL6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_DCL6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FTHPR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel24.ResumeLayout(False)
        CType(Me.GC_DCL5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_DCL5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FTHSAU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.GC_DCL4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_DCL4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FTHSAC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        CType(Me.GC_DCL8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_DCL8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FTHCATC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.GC_DCL2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_DCL2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FTHCCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.GC_DCL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_DCL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FTHCPH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel22.ResumeLayout(False)
        CType(Me.GC8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_ATC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel19.ResumeLayout(False)
        CType(Me.lkup_IT1PR_D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IT1SAU_D, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel16.ResumeLayout(False)
        CType(Me.lkup_IT1SAC_D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IT1CC_D, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.lkup_IT1CCH_D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IT1CPH_D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_AnalyseOrdonance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit3 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents FtH_TA As Theriaque.dsTheriaque_CriteresChoixTableAdapters.FTH_FICHEINFOTHERAPEUTIQUETableAdapter
    Friend WithEvents DsTheriaque_CriteresChoix As Theriaque.dsTheriaque_CriteresChoix
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GC15 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV15 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSPFTH_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPFTH_FTH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPFTH_SP_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_SPCH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lkup_SPFTH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents SPFTH_TA As Theriaque.dsTheriaque_CriteresChoixTableAdapters.SPFTH_SPEC_INFOTHERAPEUTIQUETableAdapter
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel22 As System.Windows.Forms.Panel
    Friend WithEvents GC8 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCATC_CODE_PK_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCATC_CODE_PK2_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_ATC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colCATC_NOMF_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCATC_NOMA_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCATC_DATECR_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents Panel20 As System.Windows.Forms.Panel

    Friend WithEvents colIT1PR_FIT_CODE_FK_PK_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1PR_PR_CODE_FK_PK_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1PR_PR_CODE_FK_PK2_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IT1PR_D As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel21 As System.Windows.Forms.Panel

    Friend WithEvents colIT1SAU_FIT_CODE_FK_PK_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1SAU_SAU_CODE_FK_PK_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1_IT1SAU_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IT1SAU_D As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Panel17 As System.Windows.Forms.Panel

    Friend WithEvents colIT1SAC_SAC_CODE_FK_PK_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1SAC_FIT_CODE_FK_PK_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1_TERM1SAC_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IT1SAC_D As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel18 As System.Windows.Forms.Panel

    Friend WithEvents colIT1CC_FIT_CODE_FK_PK_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IT1CC_D As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colIT1CC_NUMORD_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel

    Friend WithEvents colIT1CCH_FIT_CODE_FK_PK_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1CCH_CCH_CODE_FK_PK_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1CCH_CCH_CODE_FK_PK2_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IT1CCH_D As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel11 As System.Windows.Forms.Panel

    Friend WithEvents colIT1CPH_FIT_CODE_FK_PK_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1CPH_CPH_CODE_FK_PK_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1CPH_CPH_CODE_FK_PK2_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IT1CPH_D As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GC_DCL2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_DCL2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFTHCCH_FTH_CODE_SQ_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFTHCCH_CCH_CODE_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFTHCCH_CCH_CODE_PK_FK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FTHCCH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents GC_DCL4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_DCL4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFTHSAC_FTH_CODE_SQ_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFTHSAC_SAC_CODE_SQ_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFTHSAC_SAC_CODE_SQ_PK_FK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FTHSAC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel23 As System.Windows.Forms.Panel
    Friend WithEvents GC_DCL6 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_DCL6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFTHPR_FTH_CODE_SQ_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFTHPR_PR_CODE_SQ_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFTHPR_PR_CODE_SQ_PK_FK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FTHPR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel24 As System.Windows.Forms.Panel
    Friend WithEvents GC_DCL5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_DCL5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFTHSAU_FTH_CODE_SQ_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFTHSAU_SAU_CODE_SQ_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFTHSAU_SAU_CODE_SQ_PK_FK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FTHSAU As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC_DCL8 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_DCL8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFTHCATC_FTH_CODE_SQ_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFTHCATC_CATC_CODE_PK_FK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FTHCATC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit9 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DsTheriaque_AnalyseOrdonance As Theriaque.dsTheriaque_AnalyseOrdonance
    Friend WithEvents DsTheriaque1 As Theriaque.dsTheriaque
    Friend WithEvents GC_DCL1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_DCL1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFTHCPH_FTH_CODE_SQ_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFTHCPH_CPH_CODE_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFTHCPH_CPH_CODE_PK_FK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FTHCPH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FTHCPH As Theriaque.dsTheriaque_CriteresChoixTableAdapters.FTHCPH_FIT_CLASSEPHARMTHERTableAdapter
    Friend WithEvents FTHCCH As Theriaque.dsTheriaque_CriteresChoixTableAdapters.FTHCCH_FIT_CLASSECHIMIQUETableAdapter
    Friend WithEvents FTHSAC As Theriaque.dsTheriaque_CriteresChoixTableAdapters.FTHSAC_FIT_SUBACTIVETableAdapter
    Friend WithEvents FTHSAU As Theriaque.dsTheriaque_CriteresChoixTableAdapters.FTHSAU_FIT_SUBAUXILIAIRETableAdapter
    Friend WithEvents IC1SAC_TERME1SUBACTTableAdapter1 As Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.IC1SAC_TERME1SUBACTTableAdapter
    Friend WithEvents FTHPR As Theriaque.dsTheriaque_CriteresChoixTableAdapters.FTHPR_FIT_PRODUITTableAdapter
    Friend WithEvents colFTHCATC_CATC_CODE_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FTHCATC As Theriaque.dsTheriaque_CriteresChoixTableAdapters.FTHCATC_FIT_CLASSEATCTableAdapter

End Class
