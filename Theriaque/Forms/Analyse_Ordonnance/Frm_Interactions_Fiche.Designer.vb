<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Interactions_Fiche
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
        Me.FiT_TA = New Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.FIT_FICHEINTERACTableAdapter
        Me.IT1CC_TA = New Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT1CC_TERM1COMCLASSETableAdapter
        Me.IT1CCH_TA = New Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT1CCH_TERME1CLCHIMTableAdapter
        Me.IT1CPH_TA = New Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT1CPH_TERME1CLPHARMTHERTableAdapter
        Me.DsTheriaque_AnalyseOrdonance = New Theriaque.dsTheriaque_AnalyseOrdonance
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.GC1 = New DevExpress.XtraGrid.GridControl
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIT1CPH_FIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT1CPH_CPH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT1CPH_CPH_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IT1CPH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC2 = New DevExpress.XtraGrid.GridControl
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIT1CCH_FIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT1CCH_CCH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT1CCH_CCH_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IT1CCH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.Terme1 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.GC7 = New DevExpress.XtraGrid.GridControl
        Me.GV7 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIT1SP_FIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT1SP_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT1SP_SP_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IT1SP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.GC5 = New DevExpress.XtraGrid.GridControl
        Me.GV5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIT1SAU_FIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT1SAU_SAU_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT1_IT1SAU = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IT1SAU = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC6 = New DevExpress.XtraGrid.GridControl
        Me.GV6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIT1PR_FIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT1PR_PR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT1PR_PR_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IT1PR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.GC3 = New DevExpress.XtraGrid.GridControl
        Me.GV3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIT1CC_FIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IT1CC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colIT1CC_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC4 = New DevExpress.XtraGrid.GridControl
        Me.GV4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIT1SAC_SAC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT1SAC_FIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT1_TERM1SAC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IT1SAC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Terme2 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.GC72 = New DevExpress.XtraGrid.GridControl
        Me.GV72 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIT2SP_FIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT2SP_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT2SP_SP_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IT2SP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.GC52 = New DevExpress.XtraGrid.GridControl
        Me.GV52 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIT2SAU_FIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT2SAU_SAU_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT2SAU = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IT2SAU = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC62 = New DevExpress.XtraGrid.GridControl
        Me.GV62 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIT2PR_FIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT2PR_PR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IT2PR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.GC32 = New DevExpress.XtraGrid.GridControl
        Me.GV32 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIT2CC_FIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT2CC_CDF_CC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IT2CC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colIT2CC_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC42 = New DevExpress.XtraGrid.GridControl
        Me.GV42 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIT2SAC_FIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT2SAC_SAC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT2SAC_SAC_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IT2SAC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.GC12 = New DevExpress.XtraGrid.GridControl
        Me.GV12 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIT2CPH_FIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT2CPH_CPH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT1CPH_CPH_CODE_FK_PK2_2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IT2CPH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC22 = New DevExpress.XtraGrid.GridControl
        Me.GV22 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIT2CCH_FIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT2CCH_CCH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIT1CCH_CCH_CODE_FK_PK2_2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IT2CCH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Voie_dose = New DevExpress.XtraTab.XtraTabPage
        Me.GC33 = New DevExpress.XtraGrid.GridControl
        Me.GV33 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFITVD2_FIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFITVD2_NUMSEQ_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFITVD2_CDF_VO_CODE2_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFITVD2_CDF_PP_CODE2_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFITVD2_DOSE2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFITVD2_QUALIFICATIF_DOSE2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.comboteneur_Qualificatif2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.colFITVD2_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FITVD2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colUnite2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup2_FITVD2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC13 = New DevExpress.XtraGrid.GridControl
        Me.GV13 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFITVD1_FIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFITVD1_NUMSEQ_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFITVD1_CDF_VO_CODE1_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFITVD1_CDF_PP_CODE1_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFITVD1_DOSE1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFITVD1_QUALIFICATIF_DOSE1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.comboteneur_Qualificatif = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.colFITVD1_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FITVD1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colUnite = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup2_FITVD1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Interaction = New DevExpress.XtraTab.XtraTabPage
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.GC54 = New DevExpress.XtraGrid.GridControl
        Me.GV54 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFITTER_FIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFITTER_CDF_TER_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFITTER_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FITTER = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC64 = New DevExpress.XtraGrid.GridControl
        Me.GV64 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFITCT_FIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFITCT_CDF_CT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFITCT_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FITCT = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GC34 = New DevExpress.XtraGrid.GridControl
        Me.GV34 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFITTY_FIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFITTY_CDF_TYPE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFITTY_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FITTY = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC44 = New DevExpress.XtraGrid.GridControl
        Me.GV44 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFITSE_FIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFITSE_CDF_SEIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFITSE_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FITSE = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GC14 = New DevExpress.XtraGrid.GridControl
        Me.GV14 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFITVA_FIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFITVA_CDF_VAIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFITVA_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FITVA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC24 = New DevExpress.XtraGrid.GridControl
        Me.GV24 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFITNA_FIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFITNA_CDF_NAIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFITNA_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FITNA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.TabPageCriteres_choix = New DevExpress.XtraTab.XtraTabPage
        Me.GC16 = New DevExpress.XtraGrid.GridControl
        Me.GV16 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFITROF_FIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFITROF_CDF_DOC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFITROF_NUM_DOC_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFITROF_DATE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FITROF = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC25 = New DevExpress.XtraGrid.GridControl
        Me.GV25 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFITCH_FIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFITCH_CH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFITCH_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FITCH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.IT1SAC_TA = New Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT1SAC_TERME1SUBACTIVETableAdapter
        Me.IT1SAU_TA = New Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT1SAU_TERME1SUBAUXTableAdapter
        Me.IT1PR_TA = New Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT1PR_TERME1PRODUITTableAdapter
        Me.IT1SP_TA = New Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT1SP_TERME1SPECIALITETableAdapter
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.IT2CPH_TA = New Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT2CPH_TERME2CLPHARMTHERTableAdapter
        Me.IT2CCH_TA = New Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT2CCH_TERME2CLCHIMTableAdapter
        Me.IT2CC_TA = New Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT2CC_TERM2COMCLASSETableAdapter
        Me.IT2SAC_TA = New Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT2SAC_TERME2SUBACTIVETableAdapter
        Me.IT2SAU_TA = New Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT2SAU_TERME2SUBAUXTableAdapter
        Me.IT2PR_TA = New Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT2PR_TERME2PRODUITTableAdapter
        Me.IT2SP_TA = New Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT2SP_TERME2SPECIALITETableAdapter
        Me.FitnA_TA = New Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.FITNA_INTERACTION_NATURETableAdapter
        Me.FitroF_TA = New Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.FITROF_REF_OFFICIELLETableAdapter
        Me.FitsE_TA = New Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.FITSE_INTERACTION_SENSTableAdapter
        Me.FittY_TA = New Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.FITTY_TYPEINTERACTIONTableAdapter
        Me.FitvA_TA = New Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.FITVA_NIVEAU_VALIDATIONTableAdapter
        Me.FitvD1_TA = New Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.FITVD1_INTERACTION_VOIE_DOSETableAdapter
        Me.FitvD2_TA = New Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.FITVD2_INTERACTION_VOIE_DOSETableAdapter
        Me.FitteR_TA = New Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.FITTER_TERRAINFAVORISANTTableAdapter
        Me.FitcH_TA = New Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.FITCH_CRITERECHOIXTableAdapter
        Me.FitcT_TA = New Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.FITCT_COMMENTAIRE_TERRAINTableAdapter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_AnalyseOrdonance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IT1CPH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IT1CCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.Terme1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.GC7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IT1SP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.GC5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IT1SAU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IT1PR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.GC3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IT1CC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IT1SAC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Terme2.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.GC72, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV72, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IT2SP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        CType(Me.GC52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IT2SAU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC62, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV62, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IT2PR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        CType(Me.GC32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IT2CC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IT2SAC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.GC12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IT2CPH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IT2CCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Voie_dose.SuspendLayout()
        CType(Me.GC33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboteneur_Qualificatif2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FITVD2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup2_FITVD2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboteneur_Qualificatif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FITVD1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup2_FITVD1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Interaction.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel14.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel15.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.GC54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FITTER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC64, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV64, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FITCT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.GC34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FITTY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FITSE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.GC14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FITVA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FITNA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageCriteres_choix.SuspendLayout()
        CType(Me.GC16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FITROF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FITCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.Label1.Text = "Interactions - Fiche"
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
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_AnalyseOrdonance, "FIT_FICHEINTERAC.FIT_DATEMJ", True))
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
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_AnalyseOrdonance, "FIT_FICHEINTERAC.FIT_DATECR", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        '
        'btAdvancedSearch
        '
        Me.btAdvancedSearch.Visible = True
        '
        'btn_specialiteCommune
        '
        Me.btn_specialiteCommune.Visible = True
        '
        'btDupliquer
        '
        Me.btDupliquer.Visible = True
        '
        'btn_RechMulti
        '
        Me.btn_RechMulti.Visible = True
        '
        'FiT_TA
        '
        Me.FiT_TA.ClearBeforeFill = True
        '
        'IT1CC_TA
        '
        Me.IT1CC_TA.ClearBeforeFill = True
        '
        'IT1CCH_TA
        '
        Me.IT1CCH_TA.ClearBeforeFill = True
        '
        'IT1CPH_TA
        '
        Me.IT1CPH_TA.ClearBeforeFill = True
        '
        'DsTheriaque_AnalyseOrdonance
        '
        Me.DsTheriaque_AnalyseOrdonance.DataSetName = "dsTheriaque_AnalyseOrdonance"
        Me.DsTheriaque_AnalyseOrdonance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_AnalyseOrdonance, "FIT_FICHEINTERAC.FIT_CODE_SQ_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(86, 9)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(135, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Tag = "[NOEDIT][NOADD]"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(40, 14)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Fiche N°"
        '
        'GC1
        '
        Me.GC1.DataMember = "IT1CPH_TERME1CLPHARMTHER"
        Me.GC1.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.GC1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_IT1CPH})
        Me.GC1.Size = New System.Drawing.Size(346, 115)
        Me.GC1.TabIndex = 2
        Me.GC1.Tag = "[EDIT][ADD]"
        Me.GC1.UseEmbeddedNavigator = True
        Me.GC1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIT1CPH_FIT_CODE_FK_PK, Me.colIT1CPH_CPH_CODE_FK_PK, Me.colIT1CPH_CPH_CODE_FK_PK2})
        Me.GV1.GridControl = Me.GC1
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV1.OptionsView.ShowGroupPanel = False
        '
        'colIT1CPH_FIT_CODE_FK_PK
        '
        Me.colIT1CPH_FIT_CODE_FK_PK.Caption = "IT1CPH_FIT_CODE_FK_PK"
        Me.colIT1CPH_FIT_CODE_FK_PK.FieldName = "IT1CPH_FIT_CODE_FK_PK"
        Me.colIT1CPH_FIT_CODE_FK_PK.Name = "colIT1CPH_FIT_CODE_FK_PK"
        '
        'colIT1CPH_CPH_CODE_FK_PK
        '
        Me.colIT1CPH_CPH_CODE_FK_PK.Caption = "Code"
        Me.colIT1CPH_CPH_CODE_FK_PK.FieldName = "IT1CPH_CPH_CODE_FK_PK"
        Me.colIT1CPH_CPH_CODE_FK_PK.Name = "colIT1CPH_CPH_CODE_FK_PK"
        Me.colIT1CPH_CPH_CODE_FK_PK.Tag = ""
        Me.colIT1CPH_CPH_CODE_FK_PK.Visible = True
        Me.colIT1CPH_CPH_CODE_FK_PK.VisibleIndex = 0
        Me.colIT1CPH_CPH_CODE_FK_PK.Width = 50
        '
        'colIT1CPH_CPH_CODE_FK_PK2
        '
        Me.colIT1CPH_CPH_CODE_FK_PK2.Caption = "Classe pharmaco thérapeutique1"
        Me.colIT1CPH_CPH_CODE_FK_PK2.ColumnEdit = Me.lkup_IT1CPH
        Me.colIT1CPH_CPH_CODE_FK_PK2.FieldName = "IT1CPH_CPH_CODE_FK_PK"
        Me.colIT1CPH_CPH_CODE_FK_PK2.Name = "colIT1CPH_CPH_CODE_FK_PK2"
        Me.colIT1CPH_CPH_CODE_FK_PK2.Visible = True
        Me.colIT1CPH_CPH_CODE_FK_PK2.VisibleIndex = 1
        Me.colIT1CPH_CPH_CODE_FK_PK2.Width = 275
        '
        'lkup_IT1CPH
        '
        Me.lkup_IT1CPH.AutoHeight = False
        Me.lkup_IT1CPH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IT1CPH.Name = "lkup_IT1CPH"
        '
        'GC2
        '
        Me.GC2.DataMember = "IT1CCH_TERME1CLCHIM"
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
        Me.GC2.Location = New System.Drawing.Point(346, 0)
        Me.GC2.MainView = Me.GV2
        Me.GC2.Name = "GC2"
        Me.GC2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_IT1CCH})
        Me.GC2.Size = New System.Drawing.Size(303, 115)
        Me.GC2.TabIndex = 3
        Me.GC2.Tag = "[EDIT][ADD]"
        Me.GC2.UseEmbeddedNavigator = True
        Me.GC2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIT1CCH_FIT_CODE_FK_PK, Me.colIT1CCH_CCH_CODE_FK_PK, Me.colIT1CCH_CCH_CODE_FK_PK2})
        Me.GV2.GridControl = Me.GC2
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV2.OptionsView.ShowGroupPanel = False
        '
        'colIT1CCH_FIT_CODE_FK_PK
        '
        Me.colIT1CCH_FIT_CODE_FK_PK.Caption = "IT1CCH_FIT_CODE_FK_PK"
        Me.colIT1CCH_FIT_CODE_FK_PK.FieldName = "IT1CCH_FIT_CODE_FK_PK"
        Me.colIT1CCH_FIT_CODE_FK_PK.Name = "colIT1CCH_FIT_CODE_FK_PK"
        '
        'colIT1CCH_CCH_CODE_FK_PK
        '
        Me.colIT1CCH_CCH_CODE_FK_PK.Caption = "Code"
        Me.colIT1CCH_CCH_CODE_FK_PK.FieldName = "IT1CCH_CCH_CODE_FK_PK"
        Me.colIT1CCH_CCH_CODE_FK_PK.Name = "colIT1CCH_CCH_CODE_FK_PK"
        Me.colIT1CCH_CCH_CODE_FK_PK.Visible = True
        Me.colIT1CCH_CCH_CODE_FK_PK.VisibleIndex = 0
        Me.colIT1CCH_CCH_CODE_FK_PK.Width = 50
        '
        'colIT1CCH_CCH_CODE_FK_PK2
        '
        Me.colIT1CCH_CCH_CODE_FK_PK2.Caption = "Classe chimique1"
        Me.colIT1CCH_CCH_CODE_FK_PK2.ColumnEdit = Me.lkup_IT1CCH
        Me.colIT1CCH_CCH_CODE_FK_PK2.FieldName = "IT1CCH_CCH_CODE_FK_PK"
        Me.colIT1CCH_CCH_CODE_FK_PK2.Name = "colIT1CCH_CCH_CODE_FK_PK2"
        Me.colIT1CCH_CCH_CODE_FK_PK2.Visible = True
        Me.colIT1CCH_CCH_CODE_FK_PK2.VisibleIndex = 1
        Me.colIT1CCH_CCH_CODE_FK_PK2.Width = 232
        '
        'lkup_IT1CCH
        '
        Me.lkup_IT1CCH.AutoHeight = False
        Me.lkup_IT1CCH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IT1CCH.Name = "lkup_IT1CCH"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Location = New System.Drawing.Point(6, 39)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.Terme1
        Me.XtraTabControl1.Size = New System.Drawing.Size(658, 448)
        Me.XtraTabControl1.TabIndex = 4
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.Terme1, Me.Terme2, Me.Voie_dose, Me.Interaction, Me.TabPageCriteres_choix})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'Terme1
        '
        Me.Terme1.Controls.Add(Me.Panel8)
        Me.Terme1.Controls.Add(Me.Panel7)
        Me.Terme1.Controls.Add(Me.Panel6)
        Me.Terme1.Controls.Add(Me.Panel5)
        Me.Terme1.Name = "Terme1"
        Me.Terme1.Size = New System.Drawing.Size(649, 417)
        Me.Terme1.Text = "Terme1"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.GC7)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 320)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(649, 97)
        Me.Panel8.TabIndex = 19
        '
        'GC7
        '
        Me.GC7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC7.DataMember = "IT1SP_TERME1SPECIALITE"
        Me.GC7.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC7.EmbeddedNavigator.Name = ""
        Me.GC7.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC7.Location = New System.Drawing.Point(0, 0)
        Me.GC7.MainView = Me.GV7
        Me.GC7.Name = "GC7"
        Me.GC7.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_IT1SP})
        Me.GC7.Size = New System.Drawing.Size(649, 97)
        Me.GC7.TabIndex = 15
        Me.GC7.Tag = "[EDIT][ADD]"
        Me.GC7.UseEmbeddedNavigator = True
        Me.GC7.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV7})
        '
        'GV7
        '
        Me.GV7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIT1SP_FIT_CODE_FK_PK, Me.colIT1SP_SP_CODE_FK_PK, Me.colIT1SP_SP_CODE_FK_PK2})
        Me.GV7.GridControl = Me.GC7
        Me.GV7.Name = "GV7"
        Me.GV7.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV7.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV7.OptionsView.ShowGroupPanel = False
        '
        'colIT1SP_FIT_CODE_FK_PK
        '
        Me.colIT1SP_FIT_CODE_FK_PK.Caption = "IT1SP_FIT_CODE_FK_PK"
        Me.colIT1SP_FIT_CODE_FK_PK.FieldName = "IT1SP_FIT_CODE_FK_PK"
        Me.colIT1SP_FIT_CODE_FK_PK.Name = "colIT1SP_FIT_CODE_FK_PK"
        '
        'colIT1SP_SP_CODE_FK_PK
        '
        Me.colIT1SP_SP_CODE_FK_PK.Caption = "Code"
        Me.colIT1SP_SP_CODE_FK_PK.FieldName = "IT1SP_SP_CODE_FK_PK"
        Me.colIT1SP_SP_CODE_FK_PK.Name = "colIT1SP_SP_CODE_FK_PK"
        Me.colIT1SP_SP_CODE_FK_PK.Visible = True
        Me.colIT1SP_SP_CODE_FK_PK.VisibleIndex = 0
        Me.colIT1SP_SP_CODE_FK_PK.Width = 50
        '
        'colIT1SP_SP_CODE_FK_PK2
        '
        Me.colIT1SP_SP_CODE_FK_PK2.Caption = "Spécialité1"
        Me.colIT1SP_SP_CODE_FK_PK2.ColumnEdit = Me.lkup_IT1SP
        Me.colIT1SP_SP_CODE_FK_PK2.FieldName = "IT1SP_SP_CODE_FK_PK"
        Me.colIT1SP_SP_CODE_FK_PK2.Name = "colIT1SP_SP_CODE_FK_PK2"
        Me.colIT1SP_SP_CODE_FK_PK2.Visible = True
        Me.colIT1SP_SP_CODE_FK_PK2.VisibleIndex = 1
        Me.colIT1SP_SP_CODE_FK_PK2.Width = 578
        '
        'lkup_IT1SP
        '
        Me.lkup_IT1SP.AutoHeight = False
        Me.lkup_IT1SP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IT1SP.Name = "lkup_IT1SP"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.GC5)
        Me.Panel7.Controls.Add(Me.GC6)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 223)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(649, 97)
        Me.Panel7.TabIndex = 18
        '
        'GC5
        '
        Me.GC5.DataMember = "IT1SAU_TERME1SUBAUX"
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
        Me.GC5.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_IT1SAU})
        Me.GC5.Size = New System.Drawing.Size(346, 97)
        Me.GC5.TabIndex = 11
        Me.GC5.Tag = "[EDIT][ADD]"
        Me.GC5.UseEmbeddedNavigator = True
        Me.GC5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV5})
        '
        'GV5
        '
        Me.GV5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIT1SAU_FIT_CODE_FK_PK, Me.colIT1SAU_SAU_CODE_FK_PK, Me.colIT1_IT1SAU})
        Me.GV5.GridControl = Me.GC5
        Me.GV5.Name = "GV5"
        Me.GV5.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV5.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV5.OptionsView.ShowGroupPanel = False
        '
        'colIT1SAU_FIT_CODE_FK_PK
        '
        Me.colIT1SAU_FIT_CODE_FK_PK.Caption = "IT1SAU_FIT_CODE_FK_PK"
        Me.colIT1SAU_FIT_CODE_FK_PK.FieldName = "IT1SAU_FIT_CODE_FK_PK"
        Me.colIT1SAU_FIT_CODE_FK_PK.Name = "colIT1SAU_FIT_CODE_FK_PK"
        '
        'colIT1SAU_SAU_CODE_FK_PK
        '
        Me.colIT1SAU_SAU_CODE_FK_PK.Caption = "Code"
        Me.colIT1SAU_SAU_CODE_FK_PK.FieldName = "IT1SAU_SAU_CODE_FK_PK"
        Me.colIT1SAU_SAU_CODE_FK_PK.Name = "colIT1SAU_SAU_CODE_FK_PK"
        Me.colIT1SAU_SAU_CODE_FK_PK.Visible = True
        Me.colIT1SAU_SAU_CODE_FK_PK.VisibleIndex = 0
        Me.colIT1SAU_SAU_CODE_FK_PK.Width = 50
        '
        'colIT1_IT1SAU
        '
        Me.colIT1_IT1SAU.Caption = "Excipient1"
        Me.colIT1_IT1SAU.ColumnEdit = Me.lkup_IT1SAU
        Me.colIT1_IT1SAU.FieldName = "IT1SAU_SAU_CODE_FK_PK"
        Me.colIT1_IT1SAU.Name = "colIT1_IT1SAU"
        Me.colIT1_IT1SAU.Visible = True
        Me.colIT1_IT1SAU.VisibleIndex = 1
        Me.colIT1_IT1SAU.Width = 275
        '
        'lkup_IT1SAU
        '
        Me.lkup_IT1SAU.AutoHeight = False
        Me.lkup_IT1SAU.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IT1SAU.Name = "lkup_IT1SAU"
        '
        'GC6
        '
        Me.GC6.DataMember = "IT1PR_TERME1PRODUIT"
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
        Me.GC6.Location = New System.Drawing.Point(346, 0)
        Me.GC6.MainView = Me.GV6
        Me.GC6.Name = "GC6"
        Me.GC6.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_IT1PR})
        Me.GC6.Size = New System.Drawing.Size(303, 97)
        Me.GC6.TabIndex = 13
        Me.GC6.Tag = "[EDIT][ADD]"
        Me.GC6.UseEmbeddedNavigator = True
        Me.GC6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV6})
        '
        'GV6
        '
        Me.GV6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIT1PR_FIT_CODE_FK_PK, Me.colIT1PR_PR_CODE_FK_PK, Me.colIT1PR_PR_CODE_FK_PK2})
        Me.GV6.GridControl = Me.GC6
        Me.GV6.Name = "GV6"
        Me.GV6.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV6.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV6.OptionsView.ShowGroupPanel = False
        '
        'colIT1PR_FIT_CODE_FK_PK
        '
        Me.colIT1PR_FIT_CODE_FK_PK.Caption = "IT1PR_FIT_CODE_FK_PK"
        Me.colIT1PR_FIT_CODE_FK_PK.FieldName = "IT1PR_FIT_CODE_FK_PK"
        Me.colIT1PR_FIT_CODE_FK_PK.Name = "colIT1PR_FIT_CODE_FK_PK"
        '
        'colIT1PR_PR_CODE_FK_PK
        '
        Me.colIT1PR_PR_CODE_FK_PK.Caption = "Code"
        Me.colIT1PR_PR_CODE_FK_PK.FieldName = "IT1PR_PR_CODE_FK_PK"
        Me.colIT1PR_PR_CODE_FK_PK.Name = "colIT1PR_PR_CODE_FK_PK"
        Me.colIT1PR_PR_CODE_FK_PK.Visible = True
        Me.colIT1PR_PR_CODE_FK_PK.VisibleIndex = 0
        Me.colIT1PR_PR_CODE_FK_PK.Width = 50
        '
        'colIT1PR_PR_CODE_FK_PK2
        '
        Me.colIT1PR_PR_CODE_FK_PK2.Caption = "Produit1"
        Me.colIT1PR_PR_CODE_FK_PK2.ColumnEdit = Me.lkup_IT1PR
        Me.colIT1PR_PR_CODE_FK_PK2.FieldName = "IT1PR_PR_CODE_FK_PK"
        Me.colIT1PR_PR_CODE_FK_PK2.Name = "colIT1PR_PR_CODE_FK_PK2"
        Me.colIT1PR_PR_CODE_FK_PK2.Visible = True
        Me.colIT1PR_PR_CODE_FK_PK2.VisibleIndex = 1
        Me.colIT1PR_PR_CODE_FK_PK2.Width = 232
        '
        'lkup_IT1PR
        '
        Me.lkup_IT1PR.AutoHeight = False
        Me.lkup_IT1PR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IT1PR.Name = "lkup_IT1PR"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GC3)
        Me.Panel6.Controls.Add(Me.GC4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 115)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(649, 108)
        Me.Panel6.TabIndex = 17
        '
        'GC3
        '
        Me.GC3.DataMember = "IT1CC_TERM1COMCLASSE"
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
        Me.GC3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_IT1CC})
        Me.GC3.Size = New System.Drawing.Size(346, 108)
        Me.GC3.TabIndex = 7
        Me.GC3.Tag = "[EDIT][ADD]"
        Me.GC3.UseEmbeddedNavigator = True
        Me.GC3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV3})
        '
        'GV3
        '
        Me.GV3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIT1CC_FIT_CODE_FK_PK, Me.GridColumn4, Me.colIT1CC_NUMORD})
        Me.GV3.GridControl = Me.GC3
        Me.GV3.Name = "GV3"
        Me.GV3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV3.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV3.OptionsView.ShowGroupPanel = False
        Me.GV3.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colIT1CC_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colIT1CC_FIT_CODE_FK_PK
        '
        Me.colIT1CC_FIT_CODE_FK_PK.Caption = "GridColumn3"
        Me.colIT1CC_FIT_CODE_FK_PK.FieldName = "IT1CC_FIT_CODE_FK_PK"
        Me.colIT1CC_FIT_CODE_FK_PK.Name = "colIT1CC_FIT_CODE_FK_PK"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Commentaire classe1"
        Me.GridColumn4.ColumnEdit = Me.lkup_IT1CC
        Me.GridColumn4.FieldName = "IT1CC_CDF_CC_CODE_FK_PK"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 162
        '
        'lkup_IT1CC
        '
        Me.lkup_IT1CC.AutoHeight = False
        Me.lkup_IT1CC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IT1CC.Name = "lkup_IT1CC"
        '
        'colIT1CC_NUMORD
        '
        Me.colIT1CC_NUMORD.Caption = "N°"
        Me.colIT1CC_NUMORD.FieldName = "IT1CC_NUMORD"
        Me.colIT1CC_NUMORD.Name = "colIT1CC_NUMORD"
        Me.colIT1CC_NUMORD.Visible = True
        Me.colIT1CC_NUMORD.VisibleIndex = 1
        Me.colIT1CC_NUMORD.Width = 50
        '
        'GC4
        '
        Me.GC4.DataMember = "IT1SAC_TERME1SUBACTIVE"
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
        Me.GC4.Location = New System.Drawing.Point(346, 0)
        Me.GC4.MainView = Me.GV4
        Me.GC4.Name = "GC4"
        Me.GC4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_IT1SAC})
        Me.GC4.Size = New System.Drawing.Size(303, 108)
        Me.GC4.TabIndex = 9
        Me.GC4.Tag = "[EDIT][ADD]"
        Me.GC4.UseEmbeddedNavigator = True
        Me.GC4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV4})
        '
        'GV4
        '
        Me.GV4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIT1SAC_SAC_CODE_FK_PK, Me.colIT1SAC_FIT_CODE_FK_PK, Me.colIT1_TERM1SAC})
        Me.GV4.GridControl = Me.GC4
        Me.GV4.Name = "GV4"
        Me.GV4.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV4.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV4.OptionsView.ShowGroupPanel = False
        '
        'colIT1SAC_SAC_CODE_FK_PK
        '
        Me.colIT1SAC_SAC_CODE_FK_PK.Caption = "Code"
        Me.colIT1SAC_SAC_CODE_FK_PK.FieldName = "IT1SAC_SAC_CODE_FK_PK"
        Me.colIT1SAC_SAC_CODE_FK_PK.Name = "colIT1SAC_SAC_CODE_FK_PK"
        Me.colIT1SAC_SAC_CODE_FK_PK.Visible = True
        Me.colIT1SAC_SAC_CODE_FK_PK.VisibleIndex = 0
        Me.colIT1SAC_SAC_CODE_FK_PK.Width = 50
        '
        'colIT1SAC_FIT_CODE_FK_PK
        '
        Me.colIT1SAC_FIT_CODE_FK_PK.Caption = "IT1SAC_FIT_CODE_FK_PK"
        Me.colIT1SAC_FIT_CODE_FK_PK.FieldName = "IT1SAC_FIT_CODE_FK_PK"
        Me.colIT1SAC_FIT_CODE_FK_PK.Name = "colIT1SAC_FIT_CODE_FK_PK"
        '
        'colIT1_TERM1SAC
        '
        Me.colIT1_TERM1SAC.Caption = "Substance active1"
        Me.colIT1_TERM1SAC.ColumnEdit = Me.lkup_IT1SAC
        Me.colIT1_TERM1SAC.FieldName = "IT1SAC_SAC_CODE_FK_PK"
        Me.colIT1_TERM1SAC.Name = "colIT1_TERM1SAC"
        Me.colIT1_TERM1SAC.Visible = True
        Me.colIT1_TERM1SAC.VisibleIndex = 1
        Me.colIT1_TERM1SAC.Width = 232
        '
        'lkup_IT1SAC
        '
        Me.lkup_IT1SAC.AutoHeight = False
        Me.lkup_IT1SAC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IT1SAC.Name = "lkup_IT1SAC"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GC1)
        Me.Panel5.Controls.Add(Me.GC2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(649, 115)
        Me.Panel5.TabIndex = 16
        '
        'Terme2
        '
        Me.Terme2.Controls.Add(Me.Panel12)
        Me.Terme2.Controls.Add(Me.Panel11)
        Me.Terme2.Controls.Add(Me.Panel10)
        Me.Terme2.Controls.Add(Me.Panel9)
        Me.Terme2.Name = "Terme2"
        Me.Terme2.Size = New System.Drawing.Size(649, 417)
        Me.Terme2.Text = "Terme2"
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.GC72)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(0, 320)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(649, 97)
        Me.Panel12.TabIndex = 21
        '
        'GC72
        '
        Me.GC72.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC72.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC72.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC72.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC72.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC72.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC72.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC72.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC72.EmbeddedNavigator.Name = ""
        Me.GC72.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC72.Location = New System.Drawing.Point(0, 0)
        Me.GC72.MainView = Me.GV72
        Me.GC72.Name = "GC72"
        Me.GC72.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_IT2SP})
        Me.GC72.Size = New System.Drawing.Size(649, 97)
        Me.GC72.TabIndex = 17
        Me.GC72.Tag = "[EDIT][ADD]"
        Me.GC72.UseEmbeddedNavigator = True
        Me.GC72.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV72})
        '
        'GV72
        '
        Me.GV72.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIT2SP_FIT_CODE_FK_PK, Me.colIT2SP_SP_CODE_FK_PK, Me.colIT2SP_SP_CODE_FK_PK2})
        Me.GV72.GridControl = Me.GC72
        Me.GV72.Name = "GV72"
        Me.GV72.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV72.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV72.OptionsView.ShowGroupPanel = False
        '
        'colIT2SP_FIT_CODE_FK_PK
        '
        Me.colIT2SP_FIT_CODE_FK_PK.Caption = "IT2SP_FIT_CODE_FK_PK"
        Me.colIT2SP_FIT_CODE_FK_PK.FieldName = "IT2SP_FIT_CODE_FK_PK"
        Me.colIT2SP_FIT_CODE_FK_PK.Name = "colIT2SP_FIT_CODE_FK_PK"
        '
        'colIT2SP_SP_CODE_FK_PK
        '
        Me.colIT2SP_SP_CODE_FK_PK.Caption = "Code"
        Me.colIT2SP_SP_CODE_FK_PK.FieldName = "IT2SP_SP_CODE_FK_PK"
        Me.colIT2SP_SP_CODE_FK_PK.Name = "colIT2SP_SP_CODE_FK_PK"
        Me.colIT2SP_SP_CODE_FK_PK.Visible = True
        Me.colIT2SP_SP_CODE_FK_PK.VisibleIndex = 0
        Me.colIT2SP_SP_CODE_FK_PK.Width = 50
        '
        'colIT2SP_SP_CODE_FK_PK2
        '
        Me.colIT2SP_SP_CODE_FK_PK2.Caption = "Spécialité2"
        Me.colIT2SP_SP_CODE_FK_PK2.ColumnEdit = Me.lkup_IT2SP
        Me.colIT2SP_SP_CODE_FK_PK2.FieldName = "IT2SP_SP_CODE_FK_PK"
        Me.colIT2SP_SP_CODE_FK_PK2.Name = "colIT2SP_SP_CODE_FK_PK2"
        Me.colIT2SP_SP_CODE_FK_PK2.Visible = True
        Me.colIT2SP_SP_CODE_FK_PK2.VisibleIndex = 1
        Me.colIT2SP_SP_CODE_FK_PK2.Width = 578
        '
        'lkup_IT2SP
        '
        Me.lkup_IT2SP.AutoHeight = False
        Me.lkup_IT2SP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IT2SP.Name = "lkup_IT2SP"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.GC52)
        Me.Panel11.Controls.Add(Me.GC62)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 223)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(649, 97)
        Me.Panel11.TabIndex = 20
        '
        'GC52
        '
        Me.GC52.DataMember = "IT2SAU_TERME2SUBAUX"
        Me.GC52.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC52.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC52.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC52.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC52.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC52.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC52.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC52.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC52.EmbeddedNavigator.Name = ""
        Me.GC52.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC52.Location = New System.Drawing.Point(0, 0)
        Me.GC52.MainView = Me.GV52
        Me.GC52.Name = "GC52"
        Me.GC52.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_IT2SAU})
        Me.GC52.Size = New System.Drawing.Size(346, 97)
        Me.GC52.TabIndex = 13
        Me.GC52.Tag = "[EDIT][ADD]"
        Me.GC52.UseEmbeddedNavigator = True
        Me.GC52.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV52})
        '
        'GV52
        '
        Me.GV52.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIT2SAU_FIT_CODE_FK_PK, Me.colIT2SAU_SAU_CODE_FK_PK, Me.colIT2SAU})
        Me.GV52.GridControl = Me.GC52
        Me.GV52.Name = "GV52"
        Me.GV52.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV52.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV52.OptionsView.ShowGroupPanel = False
        '
        'colIT2SAU_FIT_CODE_FK_PK
        '
        Me.colIT2SAU_FIT_CODE_FK_PK.Caption = "IT2SAU_FIT_CODE_FK_PK"
        Me.colIT2SAU_FIT_CODE_FK_PK.FieldName = "IT2SAU_FIT_CODE_FK_PK"
        Me.colIT2SAU_FIT_CODE_FK_PK.Name = "colIT2SAU_FIT_CODE_FK_PK"
        '
        'colIT2SAU_SAU_CODE_FK_PK
        '
        Me.colIT2SAU_SAU_CODE_FK_PK.Caption = "Code"
        Me.colIT2SAU_SAU_CODE_FK_PK.FieldName = "IT2SAU_SAU_CODE_FK_PK"
        Me.colIT2SAU_SAU_CODE_FK_PK.Name = "colIT2SAU_SAU_CODE_FK_PK"
        Me.colIT2SAU_SAU_CODE_FK_PK.Visible = True
        Me.colIT2SAU_SAU_CODE_FK_PK.VisibleIndex = 0
        Me.colIT2SAU_SAU_CODE_FK_PK.Width = 50
        '
        'colIT2SAU
        '
        Me.colIT2SAU.Caption = "Excipient2"
        Me.colIT2SAU.ColumnEdit = Me.lkup_IT2SAU
        Me.colIT2SAU.FieldName = "IT2SAU_SAU_CODE_FK_PK"
        Me.colIT2SAU.Name = "colIT2SAU"
        Me.colIT2SAU.Visible = True
        Me.colIT2SAU.VisibleIndex = 1
        Me.colIT2SAU.Width = 275
        '
        'lkup_IT2SAU
        '
        Me.lkup_IT2SAU.AutoHeight = False
        Me.lkup_IT2SAU.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IT2SAU.Name = "lkup_IT2SAU"
        '
        'GC62
        '
        Me.GC62.DataMember = "IT2PR_TERME2PRODUIT"
        Me.GC62.Dock = System.Windows.Forms.DockStyle.Right
        Me.GC62.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC62.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC62.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC62.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC62.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC62.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC62.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC62.EmbeddedNavigator.Name = ""
        Me.GC62.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC62.Location = New System.Drawing.Point(346, 0)
        Me.GC62.MainView = Me.GV62
        Me.GC62.Name = "GC62"
        Me.GC62.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_IT2PR})
        Me.GC62.Size = New System.Drawing.Size(303, 97)
        Me.GC62.TabIndex = 15
        Me.GC62.Tag = "[EDIT][ADD]"
        Me.GC62.UseEmbeddedNavigator = True
        Me.GC62.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV62})
        '
        'GV62
        '
        Me.GV62.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIT2PR_FIT_CODE_FK_PK, Me.colIT2PR_PR_CODE_FK_PK, Me.GridColumn14})
        Me.GV62.GridControl = Me.GC62
        Me.GV62.Name = "GV62"
        Me.GV62.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV62.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV62.OptionsView.ShowGroupPanel = False
        '
        'colIT2PR_FIT_CODE_FK_PK
        '
        Me.colIT2PR_FIT_CODE_FK_PK.Caption = "IT2PR_FIT_CODE_FK_PK"
        Me.colIT2PR_FIT_CODE_FK_PK.FieldName = "IT2PR_FIT_CODE_FK_PK"
        Me.colIT2PR_FIT_CODE_FK_PK.Name = "colIT2PR_FIT_CODE_FK_PK"
        '
        'colIT2PR_PR_CODE_FK_PK
        '
        Me.colIT2PR_PR_CODE_FK_PK.Caption = "Code"
        Me.colIT2PR_PR_CODE_FK_PK.FieldName = "IT2PR_PR_CODE_FK_PK"
        Me.colIT2PR_PR_CODE_FK_PK.Name = "colIT2PR_PR_CODE_FK_PK"
        Me.colIT2PR_PR_CODE_FK_PK.Visible = True
        Me.colIT2PR_PR_CODE_FK_PK.VisibleIndex = 0
        Me.colIT2PR_PR_CODE_FK_PK.Width = 50
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Produit2"
        Me.GridColumn14.ColumnEdit = Me.lkup_IT2PR
        Me.GridColumn14.FieldName = "IT2PR_PR_CODE_FK_PK"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 1
        Me.GridColumn14.Width = 232
        '
        'lkup_IT2PR
        '
        Me.lkup_IT2PR.AutoHeight = False
        Me.lkup_IT2PR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IT2PR.Name = "lkup_IT2PR"
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.GC32)
        Me.Panel10.Controls.Add(Me.GC42)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 115)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(649, 108)
        Me.Panel10.TabIndex = 19
        '
        'GC32
        '
        Me.GC32.DataMember = "IT2CC_TERM2COMCLASSE"
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
        Me.GC32.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_IT2CC})
        Me.GC32.Size = New System.Drawing.Size(346, 108)
        Me.GC32.TabIndex = 9
        Me.GC32.Tag = "[EDIT][ADD]"
        Me.GC32.UseEmbeddedNavigator = True
        Me.GC32.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV32})
        '
        'GV32
        '
        Me.GV32.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIT2CC_FIT_CODE_FK_PK, Me.colIT2CC_CDF_CC_CODE_FK_PK, Me.colIT2CC_NUMORD})
        Me.GV32.GridControl = Me.GC32
        Me.GV32.Name = "GV32"
        Me.GV32.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV32.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV32.OptionsView.ShowGroupPanel = False
        Me.GV32.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colIT2CC_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colIT2CC_FIT_CODE_FK_PK
        '
        Me.colIT2CC_FIT_CODE_FK_PK.Caption = "IT2CC_FIT_CODE_FK_PK"
        Me.colIT2CC_FIT_CODE_FK_PK.FieldName = "IT2CC_FIT_CODE_FK_PK"
        Me.colIT2CC_FIT_CODE_FK_PK.Name = "colIT2CC_FIT_CODE_FK_PK"
        '
        'colIT2CC_CDF_CC_CODE_FK_PK
        '
        Me.colIT2CC_CDF_CC_CODE_FK_PK.Caption = "Commentaire classe2"
        Me.colIT2CC_CDF_CC_CODE_FK_PK.ColumnEdit = Me.lkup_IT2CC
        Me.colIT2CC_CDF_CC_CODE_FK_PK.FieldName = "IT2CC_CDF_CC_CODE_FK_PK"
        Me.colIT2CC_CDF_CC_CODE_FK_PK.Name = "colIT2CC_CDF_CC_CODE_FK_PK"
        Me.colIT2CC_CDF_CC_CODE_FK_PK.Visible = True
        Me.colIT2CC_CDF_CC_CODE_FK_PK.VisibleIndex = 0
        Me.colIT2CC_CDF_CC_CODE_FK_PK.Width = 162
        '
        'lkup_IT2CC
        '
        Me.lkup_IT2CC.AutoHeight = False
        Me.lkup_IT2CC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IT2CC.Name = "lkup_IT2CC"
        '
        'colIT2CC_NUMORD
        '
        Me.colIT2CC_NUMORD.Caption = "N°"
        Me.colIT2CC_NUMORD.FieldName = "IT2CC_NUMORD"
        Me.colIT2CC_NUMORD.Name = "colIT2CC_NUMORD"
        Me.colIT2CC_NUMORD.Visible = True
        Me.colIT2CC_NUMORD.VisibleIndex = 1
        Me.colIT2CC_NUMORD.Width = 50
        '
        'GC42
        '
        Me.GC42.DataMember = "IT2SAC_TERME2SUBACTIVE"
        Me.GC42.Dock = System.Windows.Forms.DockStyle.Right
        Me.GC42.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC42.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC42.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC42.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC42.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC42.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC42.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC42.EmbeddedNavigator.Name = ""
        Me.GC42.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC42.Location = New System.Drawing.Point(346, 0)
        Me.GC42.MainView = Me.GV42
        Me.GC42.Name = "GC42"
        Me.GC42.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_IT2SAC})
        Me.GC42.Size = New System.Drawing.Size(303, 108)
        Me.GC42.TabIndex = 11
        Me.GC42.Tag = "[EDIT][ADD]"
        Me.GC42.UseEmbeddedNavigator = True
        Me.GC42.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV42})
        '
        'GV42
        '
        Me.GV42.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIT2SAC_FIT_CODE_FK_PK, Me.colIT2SAC_SAC_CODE_FK_PK, Me.colIT2SAC_SAC_CODE_FK_PK2})
        Me.GV42.GridControl = Me.GC42
        Me.GV42.Name = "GV42"
        Me.GV42.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV42.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV42.OptionsView.ShowGroupPanel = False
        '
        'colIT2SAC_FIT_CODE_FK_PK
        '
        Me.colIT2SAC_FIT_CODE_FK_PK.Caption = "IT2SAC_FIT_CODE_FK_PK"
        Me.colIT2SAC_FIT_CODE_FK_PK.FieldName = "IT2SAC_FIT_CODE_FK_PK"
        Me.colIT2SAC_FIT_CODE_FK_PK.Name = "colIT2SAC_FIT_CODE_FK_PK"
        '
        'colIT2SAC_SAC_CODE_FK_PK
        '
        Me.colIT2SAC_SAC_CODE_FK_PK.Caption = "Code"
        Me.colIT2SAC_SAC_CODE_FK_PK.FieldName = "IT2SAC_SAC_CODE_FK_PK"
        Me.colIT2SAC_SAC_CODE_FK_PK.Name = "colIT2SAC_SAC_CODE_FK_PK"
        Me.colIT2SAC_SAC_CODE_FK_PK.Visible = True
        Me.colIT2SAC_SAC_CODE_FK_PK.VisibleIndex = 0
        Me.colIT2SAC_SAC_CODE_FK_PK.Width = 50
        '
        'colIT2SAC_SAC_CODE_FK_PK2
        '
        Me.colIT2SAC_SAC_CODE_FK_PK2.Caption = "Substance active2"
        Me.colIT2SAC_SAC_CODE_FK_PK2.ColumnEdit = Me.lkup_IT2SAC
        Me.colIT2SAC_SAC_CODE_FK_PK2.FieldName = "IT2SAC_SAC_CODE_FK_PK"
        Me.colIT2SAC_SAC_CODE_FK_PK2.Name = "colIT2SAC_SAC_CODE_FK_PK2"
        Me.colIT2SAC_SAC_CODE_FK_PK2.Visible = True
        Me.colIT2SAC_SAC_CODE_FK_PK2.VisibleIndex = 1
        Me.colIT2SAC_SAC_CODE_FK_PK2.Width = 232
        '
        'lkup_IT2SAC
        '
        Me.lkup_IT2SAC.AutoHeight = False
        Me.lkup_IT2SAC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IT2SAC.Name = "lkup_IT2SAC"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.GC12)
        Me.Panel9.Controls.Add(Me.GC22)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(649, 115)
        Me.Panel9.TabIndex = 18
        '
        'GC12
        '
        Me.GC12.DataMember = "IT2CPH_TERME2CLPHARMTHER"
        Me.GC12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC12.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC12.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC12.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC12.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC12.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC12.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC12.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC12.EmbeddedNavigator.Name = ""
        Me.GC12.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC12.Location = New System.Drawing.Point(0, 0)
        Me.GC12.MainView = Me.GV12
        Me.GC12.Name = "GC12"
        Me.GC12.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_IT2CPH})
        Me.GC12.Size = New System.Drawing.Size(346, 115)
        Me.GC12.TabIndex = 3
        Me.GC12.Tag = "[EDIT][ADD]"
        Me.GC12.UseEmbeddedNavigator = True
        Me.GC12.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV12})
        '
        'GV12
        '
        Me.GV12.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIT2CPH_FIT_CODE_FK_PK, Me.colIT2CPH_CPH_CODE_FK_PK, Me.colIT1CPH_CPH_CODE_FK_PK2_2})
        Me.GV12.GridControl = Me.GC12
        Me.GV12.Name = "GV12"
        Me.GV12.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV12.OptionsView.ShowGroupPanel = False
        '
        'colIT2CPH_FIT_CODE_FK_PK
        '
        Me.colIT2CPH_FIT_CODE_FK_PK.Caption = "IT2CPH_FIT_CODE_FK_PK"
        Me.colIT2CPH_FIT_CODE_FK_PK.FieldName = "IT2CPH_FIT_CODE_FK_PK"
        Me.colIT2CPH_FIT_CODE_FK_PK.Name = "colIT2CPH_FIT_CODE_FK_PK"
        '
        'colIT2CPH_CPH_CODE_FK_PK
        '
        Me.colIT2CPH_CPH_CODE_FK_PK.Caption = "Code"
        Me.colIT2CPH_CPH_CODE_FK_PK.FieldName = "IT2CPH_CPH_CODE_FK_PK"
        Me.colIT2CPH_CPH_CODE_FK_PK.Name = "colIT2CPH_CPH_CODE_FK_PK"
        Me.colIT2CPH_CPH_CODE_FK_PK.Visible = True
        Me.colIT2CPH_CPH_CODE_FK_PK.VisibleIndex = 0
        Me.colIT2CPH_CPH_CODE_FK_PK.Width = 50
        '
        'colIT1CPH_CPH_CODE_FK_PK2_2
        '
        Me.colIT1CPH_CPH_CODE_FK_PK2_2.Caption = "Classe pharmaco thérapeutique2"
        Me.colIT1CPH_CPH_CODE_FK_PK2_2.ColumnEdit = Me.lkup_IT2CPH
        Me.colIT1CPH_CPH_CODE_FK_PK2_2.FieldName = "IT2CPH_CPH_CODE_FK_PK"
        Me.colIT1CPH_CPH_CODE_FK_PK2_2.Name = "colIT1CPH_CPH_CODE_FK_PK2_2"
        Me.colIT1CPH_CPH_CODE_FK_PK2_2.Visible = True
        Me.colIT1CPH_CPH_CODE_FK_PK2_2.VisibleIndex = 1
        Me.colIT1CPH_CPH_CODE_FK_PK2_2.Width = 275
        '
        'lkup_IT2CPH
        '
        Me.lkup_IT2CPH.AutoHeight = False
        Me.lkup_IT2CPH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IT2CPH.Name = "lkup_IT2CPH"
        '
        'GC22
        '
        Me.GC22.DataMember = "IT2CCH_TERME2CLCHIM"
        Me.GC22.Dock = System.Windows.Forms.DockStyle.Right
        Me.GC22.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC22.EmbeddedNavigator.Name = ""
        Me.GC22.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC22.Location = New System.Drawing.Point(346, 0)
        Me.GC22.MainView = Me.GV22
        Me.GC22.Name = "GC22"
        Me.GC22.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_IT2CCH})
        Me.GC22.Size = New System.Drawing.Size(303, 115)
        Me.GC22.TabIndex = 7
        Me.GC22.Tag = "[EDIT][ADD]"
        Me.GC22.UseEmbeddedNavigator = True
        Me.GC22.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV22})
        '
        'GV22
        '
        Me.GV22.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIT2CCH_FIT_CODE_FK_PK, Me.colIT2CCH_CCH_CODE_FK_PK, Me.colIT1CCH_CCH_CODE_FK_PK2_2})
        Me.GV22.GridControl = Me.GC22
        Me.GV22.Name = "GV22"
        Me.GV22.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV22.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV22.OptionsView.ShowGroupPanel = False
        '
        'colIT2CCH_FIT_CODE_FK_PK
        '
        Me.colIT2CCH_FIT_CODE_FK_PK.Caption = "IT2CCH_FIT_CODE_FK_PK"
        Me.colIT2CCH_FIT_CODE_FK_PK.FieldName = "IT2CCH_FIT_CODE_FK_PK"
        Me.colIT2CCH_FIT_CODE_FK_PK.Name = "colIT2CCH_FIT_CODE_FK_PK"
        '
        'colIT2CCH_CCH_CODE_FK_PK
        '
        Me.colIT2CCH_CCH_CODE_FK_PK.Caption = "Code"
        Me.colIT2CCH_CCH_CODE_FK_PK.FieldName = "IT2CCH_CCH_CODE_FK_PK"
        Me.colIT2CCH_CCH_CODE_FK_PK.Name = "colIT2CCH_CCH_CODE_FK_PK"
        Me.colIT2CCH_CCH_CODE_FK_PK.Visible = True
        Me.colIT2CCH_CCH_CODE_FK_PK.VisibleIndex = 0
        Me.colIT2CCH_CCH_CODE_FK_PK.Width = 50
        '
        'colIT1CCH_CCH_CODE_FK_PK2_2
        '
        Me.colIT1CCH_CCH_CODE_FK_PK2_2.Caption = "Classe chimique2"
        Me.colIT1CCH_CCH_CODE_FK_PK2_2.ColumnEdit = Me.lkup_IT2CCH
        Me.colIT1CCH_CCH_CODE_FK_PK2_2.FieldName = "IT2CCH_CCH_CODE_FK_PK"
        Me.colIT1CCH_CCH_CODE_FK_PK2_2.Name = "colIT1CCH_CCH_CODE_FK_PK2_2"
        Me.colIT1CCH_CCH_CODE_FK_PK2_2.Visible = True
        Me.colIT1CCH_CCH_CODE_FK_PK2_2.VisibleIndex = 1
        Me.colIT1CCH_CCH_CODE_FK_PK2_2.Width = 232
        '
        'lkup_IT2CCH
        '
        Me.lkup_IT2CCH.AutoHeight = False
        Me.lkup_IT2CCH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IT2CCH.Name = "lkup_IT2CCH"
        '
        'Voie_dose
        '
        Me.Voie_dose.Controls.Add(Me.GC33)
        Me.Voie_dose.Controls.Add(Me.GC13)
        Me.Voie_dose.Name = "Voie_dose"
        Me.Voie_dose.Size = New System.Drawing.Size(649, 417)
        Me.Voie_dose.Text = "Voie d'administration / dose"
        '
        'GC33
        '
        Me.GC33.DataMember = "FITVD2_INTERACTION_VOIE_DOSE"
        Me.GC33.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC33.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC33.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC33.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC33.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC33.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC33.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC33.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC33.EmbeddedNavigator.Name = ""
        Me.GC33.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC33.Location = New System.Drawing.Point(0, 195)
        Me.GC33.MainView = Me.GV33
        Me.GC33.Name = "GC33"
        Me.GC33.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FITVD2, Me.lkup2_FITVD2, Me.comboteneur_Qualificatif2})
        Me.GC33.Size = New System.Drawing.Size(649, 222)
        Me.GC33.TabIndex = 11
        Me.GC33.Tag = "[EDIT][ADD]"
        Me.GC33.UseEmbeddedNavigator = True
        Me.GC33.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV33})
        '
        'GV33
        '
        Me.GV33.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFITVD2_FIT_CODE_FK_PK, Me.colFITVD2_NUMSEQ_PK, Me.colFITVD2_CDF_VO_CODE2_FK, Me.colFITVD2_CDF_PP_CODE2_FK, Me.colFITVD2_DOSE2, Me.colFITVD2_QUALIFICATIF_DOSE2, Me.colFITVD2_NUMORD, Me.GridColumn18, Me.colUnite2})
        Me.GV33.GridControl = Me.GC33
        Me.GV33.Name = "GV33"
        Me.GV33.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV33.OptionsView.ShowGroupPanel = False
        '
        'colFITVD2_FIT_CODE_FK_PK
        '
        Me.colFITVD2_FIT_CODE_FK_PK.Caption = "FITVD2_FIT_CODE_FK_PK"
        Me.colFITVD2_FIT_CODE_FK_PK.FieldName = "FITVD2_FIT_CODE_FK_PK"
        Me.colFITVD2_FIT_CODE_FK_PK.Name = "colFITVD2_FIT_CODE_FK_PK"
        '
        'colFITVD2_NUMSEQ_PK
        '
        Me.colFITVD2_NUMSEQ_PK.Caption = "FITVD2_NUMSEQ_PK"
        Me.colFITVD2_NUMSEQ_PK.FieldName = "FITVD2_NUMSEQ_PK"
        Me.colFITVD2_NUMSEQ_PK.Name = "colFITVD2_NUMSEQ_PK"
        '
        'colFITVD2_CDF_VO_CODE2_FK
        '
        Me.colFITVD2_CDF_VO_CODE2_FK.Caption = "Code"
        Me.colFITVD2_CDF_VO_CODE2_FK.FieldName = "FITVD2_CDF_VO_CODE2_FK"
        Me.colFITVD2_CDF_VO_CODE2_FK.Name = "colFITVD2_CDF_VO_CODE2_FK"
        Me.colFITVD2_CDF_VO_CODE2_FK.Visible = True
        Me.colFITVD2_CDF_VO_CODE2_FK.VisibleIndex = 0
        Me.colFITVD2_CDF_VO_CODE2_FK.Width = 50
        '
        'colFITVD2_CDF_PP_CODE2_FK
        '
        Me.colFITVD2_CDF_PP_CODE2_FK.Caption = "FITVD2_CDF_PP_CODE2_FK"
        Me.colFITVD2_CDF_PP_CODE2_FK.FieldName = "FITVD2_CDF_PP_CODE2_FK"
        Me.colFITVD2_CDF_PP_CODE2_FK.Name = "colFITVD2_CDF_PP_CODE2_FK"
        '
        'colFITVD2_DOSE2
        '
        Me.colFITVD2_DOSE2.Caption = "Dose2"
        Me.colFITVD2_DOSE2.FieldName = "FITVD2_DOSE2"
        Me.colFITVD2_DOSE2.Name = "colFITVD2_DOSE2"
        Me.colFITVD2_DOSE2.Visible = True
        Me.colFITVD2_DOSE2.VisibleIndex = 3
        Me.colFITVD2_DOSE2.Width = 70
        '
        'colFITVD2_QUALIFICATIF_DOSE2
        '
        Me.colFITVD2_QUALIFICATIF_DOSE2.Caption = "Qualificatif"
        Me.colFITVD2_QUALIFICATIF_DOSE2.ColumnEdit = Me.comboteneur_Qualificatif2
        Me.colFITVD2_QUALIFICATIF_DOSE2.FieldName = "FITVD2_QUALIFICATIF_DOSE2"
        Me.colFITVD2_QUALIFICATIF_DOSE2.Name = "colFITVD2_QUALIFICATIF_DOSE2"
        Me.colFITVD2_QUALIFICATIF_DOSE2.Visible = True
        Me.colFITVD2_QUALIFICATIF_DOSE2.VisibleIndex = 2
        Me.colFITVD2_QUALIFICATIF_DOSE2.Width = 77
        '
        'comboteneur_Qualificatif2
        '
        Me.comboteneur_Qualificatif2.AutoHeight = False
        Me.comboteneur_Qualificatif2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.comboteneur_Qualificatif2.Items.AddRange(New Object() {"<", ">", "<=", ">=", "QSP", "CURATIVE", "PREVENTIVE"})
        Me.comboteneur_Qualificatif2.Name = "comboteneur_Qualificatif2"
        '
        'colFITVD2_NUMORD
        '
        Me.colFITVD2_NUMORD.Caption = "FITVD2_NUMORD"
        Me.colFITVD2_NUMORD.FieldName = "FITVD2_NUMORD"
        Me.colFITVD2_NUMORD.Name = "colFITVD2_NUMORD"
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Voie2"
        Me.GridColumn18.ColumnEdit = Me.lkup_FITVD2
        Me.GridColumn18.FieldName = "FITVD2_CDF_VO_CODE2_FK"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 1
        Me.GridColumn18.Width = 182
        '
        'lkup_FITVD2
        '
        Me.lkup_FITVD2.AutoHeight = False
        Me.lkup_FITVD2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FITVD2.Name = "lkup_FITVD2"
        '
        'colUnite2
        '
        Me.colUnite2.Caption = "Unité"
        Me.colUnite2.ColumnEdit = Me.lkup2_FITVD2
        Me.colUnite2.FieldName = "FITVD2_CDF_PP_CODE2_FK"
        Me.colUnite2.Name = "colUnite2"
        Me.colUnite2.Visible = True
        Me.colUnite2.VisibleIndex = 4
        Me.colUnite2.Width = 249
        '
        'lkup2_FITVD2
        '
        Me.lkup2_FITVD2.AutoHeight = False
        Me.lkup2_FITVD2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup2_FITVD2.Name = "lkup2_FITVD2"
        '
        'GC13
        '
        Me.GC13.DataMember = "FITVD1_INTERACTION_VOIE_DOSE"
        Me.GC13.Dock = System.Windows.Forms.DockStyle.Top
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
        Me.GC13.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FITVD1, Me.lkup2_FITVD1, Me.comboteneur_Qualificatif})
        Me.GC13.Size = New System.Drawing.Size(649, 195)
        Me.GC13.TabIndex = 7
        Me.GC13.Tag = "[EDIT][ADD]"
        Me.GC13.UseEmbeddedNavigator = True
        Me.GC13.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV13})
        '
        'GV13
        '
        Me.GV13.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFITVD1_FIT_CODE_FK_PK, Me.colFITVD1_NUMSEQ_PK, Me.colFITVD1_CDF_VO_CODE1_FK, Me.colFITVD1_CDF_PP_CODE1_FK, Me.colFITVD1_DOSE1, Me.colFITVD1_QUALIFICATIF_DOSE1, Me.colFITVD1_NUMORD, Me.GridColumn16, Me.colUnite})
        Me.GV13.GridControl = Me.GC13
        Me.GV13.Name = "GV13"
        Me.GV13.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV13.OptionsView.ShowGroupPanel = False
        '
        'colFITVD1_FIT_CODE_FK_PK
        '
        Me.colFITVD1_FIT_CODE_FK_PK.Caption = "FITVD1_FIT_CODE_FK_PK"
        Me.colFITVD1_FIT_CODE_FK_PK.FieldName = "FITVD1_FIT_CODE_FK_PK"
        Me.colFITVD1_FIT_CODE_FK_PK.Name = "colFITVD1_FIT_CODE_FK_PK"
        '
        'colFITVD1_NUMSEQ_PK
        '
        Me.colFITVD1_NUMSEQ_PK.Caption = "colFITVD1_NUMSEQ_PK"
        Me.colFITVD1_NUMSEQ_PK.FieldName = "FITVD1_NUMSEQ_PK"
        Me.colFITVD1_NUMSEQ_PK.Name = "colFITVD1_NUMSEQ_PK"
        '
        'colFITVD1_CDF_VO_CODE1_FK
        '
        Me.colFITVD1_CDF_VO_CODE1_FK.Caption = "Code"
        Me.colFITVD1_CDF_VO_CODE1_FK.FieldName = "FITVD1_CDF_VO_CODE1_FK"
        Me.colFITVD1_CDF_VO_CODE1_FK.Name = "colFITVD1_CDF_VO_CODE1_FK"
        Me.colFITVD1_CDF_VO_CODE1_FK.Visible = True
        Me.colFITVD1_CDF_VO_CODE1_FK.VisibleIndex = 0
        Me.colFITVD1_CDF_VO_CODE1_FK.Width = 50
        '
        'colFITVD1_CDF_PP_CODE1_FK
        '
        Me.colFITVD1_CDF_PP_CODE1_FK.Caption = "FITVD1_CDF_PP_CODE1_FK"
        Me.colFITVD1_CDF_PP_CODE1_FK.FieldName = "FITVD1_CDF_PP_CODE1_FK"
        Me.colFITVD1_CDF_PP_CODE1_FK.Name = "colFITVD1_CDF_PP_CODE1_FK"
        '
        'colFITVD1_DOSE1
        '
        Me.colFITVD1_DOSE1.Caption = "Dose1"
        Me.colFITVD1_DOSE1.FieldName = "FITVD1_DOSE1"
        Me.colFITVD1_DOSE1.Name = "colFITVD1_DOSE1"
        Me.colFITVD1_DOSE1.Visible = True
        Me.colFITVD1_DOSE1.VisibleIndex = 3
        Me.colFITVD1_DOSE1.Width = 70
        '
        'colFITVD1_QUALIFICATIF_DOSE1
        '
        Me.colFITVD1_QUALIFICATIF_DOSE1.Caption = "Qualificatif"
        Me.colFITVD1_QUALIFICATIF_DOSE1.ColumnEdit = Me.comboteneur_Qualificatif
        Me.colFITVD1_QUALIFICATIF_DOSE1.FieldName = "FITVD1_QUALIFICATIF_DOSE1"
        Me.colFITVD1_QUALIFICATIF_DOSE1.Name = "colFITVD1_QUALIFICATIF_DOSE1"
        Me.colFITVD1_QUALIFICATIF_DOSE1.Visible = True
        Me.colFITVD1_QUALIFICATIF_DOSE1.VisibleIndex = 2
        Me.colFITVD1_QUALIFICATIF_DOSE1.Width = 77
        '
        'comboteneur_Qualificatif
        '
        Me.comboteneur_Qualificatif.AutoHeight = False
        Me.comboteneur_Qualificatif.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.comboteneur_Qualificatif.Items.AddRange(New Object() {"<", ">", "<=", ">=", "QSP", "CURATIVE", "PREVENTIVE"})
        Me.comboteneur_Qualificatif.Name = "comboteneur_Qualificatif"
        '
        'colFITVD1_NUMORD
        '
        Me.colFITVD1_NUMORD.Caption = "FITVD1_NUMORD"
        Me.colFITVD1_NUMORD.FieldName = "FITVD1_NUMORD"
        Me.colFITVD1_NUMORD.Name = "colFITVD1_NUMORD"
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Voie1"
        Me.GridColumn16.ColumnEdit = Me.lkup_FITVD1
        Me.GridColumn16.FieldName = "FITVD1_CDF_VO_CODE1_FK"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 1
        Me.GridColumn16.Width = 182
        '
        'lkup_FITVD1
        '
        Me.lkup_FITVD1.AutoHeight = False
        Me.lkup_FITVD1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FITVD1.Name = "lkup_FITVD1"
        '
        'colUnite
        '
        Me.colUnite.Caption = "Unité"
        Me.colUnite.ColumnEdit = Me.lkup2_FITVD1
        Me.colUnite.FieldName = "FITVD1_CDF_PP_CODE1_FK"
        Me.colUnite.Name = "colUnite"
        Me.colUnite.Visible = True
        Me.colUnite.VisibleIndex = 4
        Me.colUnite.Width = 249
        '
        'lkup2_FITVD1
        '
        Me.lkup2_FITVD1.AutoHeight = False
        Me.lkup2_FITVD1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup2_FITVD1.Name = "lkup2_FITVD1"
        '
        'Interaction
        '
        Me.Interaction.Controls.Add(Me.Panel13)
        Me.Interaction.Controls.Add(Me.Panel4)
        Me.Interaction.Controls.Add(Me.Panel3)
        Me.Interaction.Controls.Add(Me.Panel2)
        Me.Interaction.Name = "Interaction"
        Me.Interaction.Size = New System.Drawing.Size(649, 417)
        Me.Interaction.Text = "Intéraction"
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.Panel14)
        Me.Panel13.Controls.Add(Me.Panel15)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.Location = New System.Drawing.Point(0, 302)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(649, 115)
        Me.Panel13.TabIndex = 38
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.MemoEdit1)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(0, 24)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(649, 91)
        Me.Panel14.TabIndex = 38
        Me.Panel14.Tag = "[EDIT][ADD]"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_AnalyseOrdonance, "FIT_FICHEINTERAC.FIT_TEXTE", True))
        Me.MemoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoEdit1.Location = New System.Drawing.Point(0, 0)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(649, 91)
        Me.MemoEdit1.TabIndex = 36
        Me.MemoEdit1.Tag = ""
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.LabelControl6)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(649, 24)
        Me.Panel15.TabIndex = 37
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(2, 7)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl6.TabIndex = 19
        Me.LabelControl6.Text = "Texte"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GC54)
        Me.Panel4.Controls.Add(Me.GC64)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 207)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(649, 95)
        Me.Panel4.TabIndex = 21
        '
        'GC54
        '
        Me.GC54.DataMember = "FITTER_TERRAINFAVORISANT"
        Me.GC54.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC54.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC54.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC54.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC54.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC54.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC54.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC54.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC54.EmbeddedNavigator.Name = ""
        Me.GC54.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC54.Location = New System.Drawing.Point(0, 0)
        Me.GC54.MainView = Me.GV54
        Me.GC54.Name = "GC54"
        Me.GC54.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FITTER})
        Me.GC54.Size = New System.Drawing.Size(339, 95)
        Me.GC54.TabIndex = 13
        Me.GC54.Tag = "[EDIT][ADD]"
        Me.GC54.UseEmbeddedNavigator = True
        Me.GC54.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV54})
        '
        'GV54
        '
        Me.GV54.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFITTER_FIT_CODE_FK_PK, Me.colFITTER_CDF_TER_CODE_FK_PK, Me.colFITTER_NUMORD, Me.GridColumn24})
        Me.GV54.GridControl = Me.GC54
        Me.GV54.Name = "GV54"
        Me.GV54.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV54.OptionsView.ShowGroupPanel = False
        Me.GV54.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFITTER_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFITTER_FIT_CODE_FK_PK
        '
        Me.colFITTER_FIT_CODE_FK_PK.Caption = "FITTER_FIT_CODE_FK_PK"
        Me.colFITTER_FIT_CODE_FK_PK.FieldName = "FITTER_FIT_CODE_FK_PK"
        Me.colFITTER_FIT_CODE_FK_PK.Name = "colFITTER_FIT_CODE_FK_PK"
        '
        'colFITTER_CDF_TER_CODE_FK_PK
        '
        Me.colFITTER_CDF_TER_CODE_FK_PK.Caption = "FITTER_CDF_TER_CODE_FK_PK"
        Me.colFITTER_CDF_TER_CODE_FK_PK.FieldName = "FITTER_CDF_TER_CODE_FK_PK"
        Me.colFITTER_CDF_TER_CODE_FK_PK.Name = "colFITTER_CDF_TER_CODE_FK_PK"
        '
        'colFITTER_NUMORD
        '
        Me.colFITTER_NUMORD.Caption = "N°"
        Me.colFITTER_NUMORD.FieldName = "FITTER_NUMORD"
        Me.colFITTER_NUMORD.Name = "colFITTER_NUMORD"
        Me.colFITTER_NUMORD.Visible = True
        Me.colFITTER_NUMORD.VisibleIndex = 1
        Me.colFITTER_NUMORD.Width = 50
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "Terrain favorisant"
        Me.GridColumn24.ColumnEdit = Me.lkup_FITTER
        Me.GridColumn24.FieldName = "FITTER_CDF_TER_CODE_FK_PK"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 0
        Me.GridColumn24.Width = 159
        '
        'lkup_FITTER
        '
        Me.lkup_FITTER.AutoHeight = False
        Me.lkup_FITTER.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FITTER.Name = "lkup_FITTER"
        '
        'GC64
        '
        Me.GC64.DataMember = "FITCT_COMMENTAIRE_TERRAIN"
        Me.GC64.Dock = System.Windows.Forms.DockStyle.Right
        Me.GC64.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC64.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC64.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC64.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC64.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC64.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC64.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC64.EmbeddedNavigator.Name = ""
        Me.GC64.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC64.Location = New System.Drawing.Point(339, 0)
        Me.GC64.MainView = Me.GV64
        Me.GC64.Name = "GC64"
        Me.GC64.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FITCT})
        Me.GC64.Size = New System.Drawing.Size(310, 95)
        Me.GC64.TabIndex = 14
        Me.GC64.Tag = "[EDIT][ADD]"
        Me.GC64.UseEmbeddedNavigator = True
        Me.GC64.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV64})
        '
        'GV64
        '
        Me.GV64.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFITCT_FIT_CODE_FK_PK, Me.colFITCT_CDF_CT_CODE_FK_PK, Me.colFITCT_NUMORD, Me.GridColumn25})
        Me.GV64.GridControl = Me.GC64
        Me.GV64.Name = "GV64"
        Me.GV64.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV64.OptionsView.ShowGroupPanel = False
        Me.GV64.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFITCT_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFITCT_FIT_CODE_FK_PK
        '
        Me.colFITCT_FIT_CODE_FK_PK.Caption = "FITCT_FIT_CODE_FK_PK"
        Me.colFITCT_FIT_CODE_FK_PK.FieldName = "FITCT_FIT_CODE_FK_PK"
        Me.colFITCT_FIT_CODE_FK_PK.Name = "colFITCT_FIT_CODE_FK_PK"
        '
        'colFITCT_CDF_CT_CODE_FK_PK
        '
        Me.colFITCT_CDF_CT_CODE_FK_PK.Caption = "FITCT_CDF_CT_CODE_FK_PK"
        Me.colFITCT_CDF_CT_CODE_FK_PK.FieldName = "FITCT_CDF_CT_CODE_FK_PK"
        Me.colFITCT_CDF_CT_CODE_FK_PK.Name = "colFITCT_CDF_CT_CODE_FK_PK"
        '
        'colFITCT_NUMORD
        '
        Me.colFITCT_NUMORD.Caption = "N°"
        Me.colFITCT_NUMORD.FieldName = "FITCT_NUMORD"
        Me.colFITCT_NUMORD.Name = "colFITCT_NUMORD"
        Me.colFITCT_NUMORD.Visible = True
        Me.colFITCT_NUMORD.VisibleIndex = 1
        Me.colFITCT_NUMORD.Width = 50
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "Commentaire terrain"
        Me.GridColumn25.ColumnEdit = Me.lkup_FITCT
        Me.GridColumn25.FieldName = "FITCT_CDF_CT_CODE_FK_PK"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 0
        Me.GridColumn25.Width = 144
        '
        'lkup_FITCT
        '
        Me.lkup_FITCT.AutoHeight = False
        Me.lkup_FITCT.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FITCT.Name = "lkup_FITCT"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GC34)
        Me.Panel3.Controls.Add(Me.GC44)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 107)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(649, 100)
        Me.Panel3.TabIndex = 20
        '
        'GC34
        '
        Me.GC34.DataMember = "FITTY_TYPEINTERACTION"
        Me.GC34.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC34.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC34.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC34.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC34.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC34.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC34.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC34.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC34.EmbeddedNavigator.Name = ""
        Me.GC34.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC34.Location = New System.Drawing.Point(0, 0)
        Me.GC34.MainView = Me.GV34
        Me.GC34.Name = "GC34"
        Me.GC34.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FITTY})
        Me.GC34.Size = New System.Drawing.Size(339, 100)
        Me.GC34.TabIndex = 9
        Me.GC34.Tag = "[EDIT][ADD]"
        Me.GC34.UseEmbeddedNavigator = True
        Me.GC34.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV34})
        '
        'GV34
        '
        Me.GV34.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFITTY_FIT_CODE_FK_PK, Me.colFITTY_CDF_TYPE_CODE_FK_PK, Me.colFITTY_NUMORD, Me.GridColumn22})
        Me.GV34.GridControl = Me.GC34
        Me.GV34.Name = "GV34"
        Me.GV34.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV34.OptionsView.ShowGroupPanel = False
        Me.GV34.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFITTY_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFITTY_FIT_CODE_FK_PK
        '
        Me.colFITTY_FIT_CODE_FK_PK.Caption = "FITTY_FIT_CODE_FK_PK"
        Me.colFITTY_FIT_CODE_FK_PK.FieldName = "FITTY_FIT_CODE_FK_PK"
        Me.colFITTY_FIT_CODE_FK_PK.Name = "colFITTY_FIT_CODE_FK_PK"
        '
        'colFITTY_CDF_TYPE_CODE_FK_PK
        '
        Me.colFITTY_CDF_TYPE_CODE_FK_PK.Caption = "FITTY_CDF_TYPE_CODE_FK_PK"
        Me.colFITTY_CDF_TYPE_CODE_FK_PK.FieldName = "FITTY_CDF_TYPE_CODE_FK_PK"
        Me.colFITTY_CDF_TYPE_CODE_FK_PK.Name = "colFITTY_CDF_TYPE_CODE_FK_PK"
        '
        'colFITTY_NUMORD
        '
        Me.colFITTY_NUMORD.Caption = "N°"
        Me.colFITTY_NUMORD.FieldName = "FITTY_NUMORD"
        Me.colFITTY_NUMORD.Name = "colFITTY_NUMORD"
        Me.colFITTY_NUMORD.Visible = True
        Me.colFITTY_NUMORD.VisibleIndex = 1
        Me.colFITTY_NUMORD.Width = 50
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Type de l'intéraction"
        Me.GridColumn22.ColumnEdit = Me.lkup_FITTY
        Me.GridColumn22.FieldName = "FITTY_CDF_TYPE_CODE_FK_PK"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 0
        Me.GridColumn22.Width = 159
        '
        'lkup_FITTY
        '
        Me.lkup_FITTY.AutoHeight = False
        Me.lkup_FITTY.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FITTY.Name = "lkup_FITTY"
        '
        'GC44
        '
        Me.GC44.DataMember = "FITSE_INTERACTION_SENS"
        Me.GC44.Dock = System.Windows.Forms.DockStyle.Right
        Me.GC44.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC44.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC44.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC44.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC44.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC44.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC44.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC44.EmbeddedNavigator.Name = ""
        Me.GC44.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC44.Location = New System.Drawing.Point(339, 0)
        Me.GC44.MainView = Me.GV44
        Me.GC44.Name = "GC44"
        Me.GC44.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FITSE})
        Me.GC44.Size = New System.Drawing.Size(310, 100)
        Me.GC44.TabIndex = 10
        Me.GC44.Tag = "[EDIT][ADD]"
        Me.GC44.UseEmbeddedNavigator = True
        Me.GC44.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV44})
        '
        'GV44
        '
        Me.GV44.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFITSE_FIT_CODE_FK_PK, Me.colFITSE_CDF_SEIT_CODE_FK_PK, Me.colFITSE_NUMORD, Me.GridColumn23})
        Me.GV44.GridControl = Me.GC44
        Me.GV44.Name = "GV44"
        Me.GV44.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV44.OptionsView.ShowGroupPanel = False
        Me.GV44.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFITSE_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFITSE_FIT_CODE_FK_PK
        '
        Me.colFITSE_FIT_CODE_FK_PK.Caption = "FITSE_FIT_CODE_FK_PK"
        Me.colFITSE_FIT_CODE_FK_PK.FieldName = "FITSE_FIT_CODE_FK_PK"
        Me.colFITSE_FIT_CODE_FK_PK.Name = "colFITSE_FIT_CODE_FK_PK"
        '
        'colFITSE_CDF_SEIT_CODE_FK_PK
        '
        Me.colFITSE_CDF_SEIT_CODE_FK_PK.Caption = "FITSE_CDF_SEIT_CODE_FK_PK"
        Me.colFITSE_CDF_SEIT_CODE_FK_PK.FieldName = "FITSE_CDF_SEIT_CODE_FK_PK"
        Me.colFITSE_CDF_SEIT_CODE_FK_PK.Name = "colFITSE_CDF_SEIT_CODE_FK_PK"
        '
        'colFITSE_NUMORD
        '
        Me.colFITSE_NUMORD.Caption = "N°"
        Me.colFITSE_NUMORD.FieldName = "FITSE_NUMORD"
        Me.colFITSE_NUMORD.Name = "colFITSE_NUMORD"
        Me.colFITSE_NUMORD.Visible = True
        Me.colFITSE_NUMORD.VisibleIndex = 1
        Me.colFITSE_NUMORD.Width = 50
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "Sens de l'intéraction"
        Me.GridColumn23.ColumnEdit = Me.lkup_FITSE
        Me.GridColumn23.FieldName = "FITSE_CDF_SEIT_CODE_FK_PK"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 0
        Me.GridColumn23.Width = 144
        '
        'lkup_FITSE
        '
        Me.lkup_FITSE.AutoHeight = False
        Me.lkup_FITSE.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FITSE.Name = "lkup_FITSE"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GC14)
        Me.Panel2.Controls.Add(Me.GC24)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(649, 107)
        Me.Panel2.TabIndex = 19
        '
        'GC14
        '
        Me.GC14.DataMember = "FITVA_NIVEAU_VALIDATION"
        Me.GC14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC14.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC14.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC14.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC14.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC14.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC14.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC14.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC14.EmbeddedNavigator.Name = ""
        Me.GC14.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC14.Location = New System.Drawing.Point(0, 0)
        Me.GC14.MainView = Me.GV14
        Me.GC14.Name = "GC14"
        Me.GC14.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FITVA})
        Me.GC14.Size = New System.Drawing.Size(339, 107)
        Me.GC14.TabIndex = 3
        Me.GC14.Tag = "[EDIT][ADD]"
        Me.GC14.UseEmbeddedNavigator = True
        Me.GC14.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV14})
        '
        'GV14
        '
        Me.GV14.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFITVA_FIT_CODE_FK_PK, Me.colFITVA_CDF_VAIT_CODE_FK_PK, Me.colFITVA_NUMORD, Me.GridColumn20})
        Me.GV14.GridControl = Me.GC14
        Me.GV14.Name = "GV14"
        Me.GV14.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV14.OptionsView.ShowGroupPanel = False
        Me.GV14.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn20, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFITVA_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFITVA_FIT_CODE_FK_PK
        '
        Me.colFITVA_FIT_CODE_FK_PK.Caption = "FITVA_FIT_CODE_FK_PK"
        Me.colFITVA_FIT_CODE_FK_PK.FieldName = "FITVA_FIT_CODE_FK_PK"
        Me.colFITVA_FIT_CODE_FK_PK.Name = "colFITVA_FIT_CODE_FK_PK"
        '
        'colFITVA_CDF_VAIT_CODE_FK_PK
        '
        Me.colFITVA_CDF_VAIT_CODE_FK_PK.Caption = "FITVA_CDF_VAIT_CODE_FK_PK"
        Me.colFITVA_CDF_VAIT_CODE_FK_PK.FieldName = "FITVA_CDF_VAIT_CODE_FK_PK"
        Me.colFITVA_CDF_VAIT_CODE_FK_PK.Name = "colFITVA_CDF_VAIT_CODE_FK_PK"
        '
        'colFITVA_NUMORD
        '
        Me.colFITVA_NUMORD.Caption = "N°"
        Me.colFITVA_NUMORD.FieldName = "FITVA_NUMORD"
        Me.colFITVA_NUMORD.Name = "colFITVA_NUMORD"
        Me.colFITVA_NUMORD.Visible = True
        Me.colFITVA_NUMORD.VisibleIndex = 1
        Me.colFITVA_NUMORD.Width = 50
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Niveau de validation"
        Me.GridColumn20.ColumnEdit = Me.lkup_FITVA
        Me.GridColumn20.FieldName = "FITVA_CDF_VAIT_CODE_FK_PK"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 0
        Me.GridColumn20.Width = 159
        '
        'lkup_FITVA
        '
        Me.lkup_FITVA.AutoHeight = False
        Me.lkup_FITVA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FITVA.Name = "lkup_FITVA"
        '
        'GC24
        '
        Me.GC24.DataMember = "FITNA_INTERACTION_NATURE"
        Me.GC24.Dock = System.Windows.Forms.DockStyle.Right
        Me.GC24.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC24.EmbeddedNavigator.Name = ""
        Me.GC24.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC24.Location = New System.Drawing.Point(339, 0)
        Me.GC24.MainView = Me.GV24
        Me.GC24.Name = "GC24"
        Me.GC24.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FITNA})
        Me.GC24.Size = New System.Drawing.Size(310, 107)
        Me.GC24.TabIndex = 7
        Me.GC24.Tag = "[EDIT][ADD]"
        Me.GC24.UseEmbeddedNavigator = True
        Me.GC24.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV24})
        '
        'GV24
        '
        Me.GV24.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFITNA_FIT_CODE_FK_PK, Me.colFITNA_CDF_NAIT_CODE_FK_PK, Me.colFITNA_NUMORD, Me.GridColumn21})
        Me.GV24.GridControl = Me.GC24
        Me.GV24.Name = "GV24"
        Me.GV24.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV24.OptionsView.ShowGroupPanel = False
        Me.GV24.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFITNA_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFITNA_FIT_CODE_FK_PK
        '
        Me.colFITNA_FIT_CODE_FK_PK.Caption = "FITNA_FIT_CODE_FK_PK"
        Me.colFITNA_FIT_CODE_FK_PK.FieldName = "FITNA_FIT_CODE_FK_PK"
        Me.colFITNA_FIT_CODE_FK_PK.Name = "colFITNA_FIT_CODE_FK_PK"
        '
        'colFITNA_CDF_NAIT_CODE_FK_PK
        '
        Me.colFITNA_CDF_NAIT_CODE_FK_PK.Caption = "FITNA_CDF_NAIT_CODE_FK_PK"
        Me.colFITNA_CDF_NAIT_CODE_FK_PK.FieldName = "FITNA_CDF_NAIT_CODE_FK_PK"
        Me.colFITNA_CDF_NAIT_CODE_FK_PK.Name = "colFITNA_CDF_NAIT_CODE_FK_PK"
        '
        'colFITNA_NUMORD
        '
        Me.colFITNA_NUMORD.Caption = "N°"
        Me.colFITNA_NUMORD.FieldName = "FITNA_NUMORD"
        Me.colFITNA_NUMORD.Name = "colFITNA_NUMORD"
        Me.colFITNA_NUMORD.Visible = True
        Me.colFITNA_NUMORD.VisibleIndex = 1
        Me.colFITNA_NUMORD.Width = 50
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Niveau de l'intéraction"
        Me.GridColumn21.ColumnEdit = Me.lkup_FITNA
        Me.GridColumn21.FieldName = "FITNA_CDF_NAIT_CODE_FK_PK"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 0
        Me.GridColumn21.Width = 144
        '
        'lkup_FITNA
        '
        Me.lkup_FITNA.AutoHeight = False
        Me.lkup_FITNA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FITNA.Name = "lkup_FITNA"
        '
        'TabPageCriteres_choix
        '
        Me.TabPageCriteres_choix.Controls.Add(Me.GC16)
        Me.TabPageCriteres_choix.Controls.Add(Me.GC25)
        Me.TabPageCriteres_choix.Name = "TabPageCriteres_choix"
        Me.TabPageCriteres_choix.Size = New System.Drawing.Size(649, 417)
        Me.TabPageCriteres_choix.Text = "Critères de choix / Réf.officielles"
        '
        'GC16
        '
        Me.GC16.DataMember = "FITROF_REF_OFFICIELLE"
        Me.GC16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC16.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC16.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC16.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC16.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC16.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC16.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC16.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC16.EmbeddedNavigator.Name = ""
        Me.GC16.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC16.Location = New System.Drawing.Point(0, 201)
        Me.GC16.MainView = Me.GV16
        Me.GC16.Name = "GC16"
        Me.GC16.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FITROF})
        Me.GC16.Size = New System.Drawing.Size(649, 216)
        Me.GC16.TabIndex = 6
        Me.GC16.Tag = "[EDIT][ADD]"
        Me.GC16.UseEmbeddedNavigator = True
        Me.GC16.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV16})
        '
        'GV16
        '
        Me.GV16.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFITROF_FIT_CODE_FK_PK, Me.colFITROF_CDF_DOC_CODE_FK_PK, Me.colFITROF_NUM_DOC_PK, Me.colFITROF_DATE_PK, Me.GridColumn32})
        Me.GV16.GridControl = Me.GC16
        Me.GV16.Name = "GV16"
        Me.GV16.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV16.OptionsView.ShowGroupPanel = False
        '
        'colFITROF_FIT_CODE_FK_PK
        '
        Me.colFITROF_FIT_CODE_FK_PK.Caption = "colFITROF_FIT_CODE_FK_PK"
        Me.colFITROF_FIT_CODE_FK_PK.FieldName = "FITROF_FIT_CODE_FK_PK"
        Me.colFITROF_FIT_CODE_FK_PK.Name = "colFITROF_FIT_CODE_FK_PK"
        '
        'colFITROF_CDF_DOC_CODE_FK_PK
        '
        Me.colFITROF_CDF_DOC_CODE_FK_PK.Caption = "Code"
        Me.colFITROF_CDF_DOC_CODE_FK_PK.FieldName = "FITROF_CDF_DOC_CODE_FK_PK"
        Me.colFITROF_CDF_DOC_CODE_FK_PK.Name = "colFITROF_CDF_DOC_CODE_FK_PK"
        Me.colFITROF_CDF_DOC_CODE_FK_PK.Visible = True
        Me.colFITROF_CDF_DOC_CODE_FK_PK.VisibleIndex = 0
        Me.colFITROF_CDF_DOC_CODE_FK_PK.Width = 50
        '
        'colFITROF_NUM_DOC_PK
        '
        Me.colFITROF_NUM_DOC_PK.Caption = "N° document"
        Me.colFITROF_NUM_DOC_PK.FieldName = "FITROF_NUM_DOC_PK"
        Me.colFITROF_NUM_DOC_PK.Name = "colFITROF_NUM_DOC_PK"
        Me.colFITROF_NUM_DOC_PK.Visible = True
        Me.colFITROF_NUM_DOC_PK.VisibleIndex = 1
        Me.colFITROF_NUM_DOC_PK.Width = 85
        '
        'colFITROF_DATE_PK
        '
        Me.colFITROF_DATE_PK.Caption = "Date"
        Me.colFITROF_DATE_PK.FieldName = "FITROF_DATE_PK"
        Me.colFITROF_DATE_PK.Name = "colFITROF_DATE_PK"
        Me.colFITROF_DATE_PK.Visible = True
        Me.colFITROF_DATE_PK.VisibleIndex = 2
        Me.colFITROF_DATE_PK.Width = 83
        '
        'GridColumn32
        '
        Me.GridColumn32.Caption = "Réfèrences officielles"
        Me.GridColumn32.ColumnEdit = Me.lkup_FITROF
        Me.GridColumn32.FieldName = "FITROF_CDF_DOC_CODE_FK_PK"
        Me.GridColumn32.Name = "GridColumn32"
        Me.GridColumn32.Visible = True
        Me.GridColumn32.VisibleIndex = 3
        Me.GridColumn32.Width = 410
        '
        'lkup_FITROF
        '
        Me.lkup_FITROF.AutoHeight = False
        Me.lkup_FITROF.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FITROF.Name = "lkup_FITROF"
        '
        'GC25
        '
        Me.GC25.DataMember = "FITCH_CRITERECHOIX"
        Me.GC25.Dock = System.Windows.Forms.DockStyle.Top
        Me.GC25.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC25.EmbeddedNavigator.Name = ""
        Me.GC25.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC25.Location = New System.Drawing.Point(0, 0)
        Me.GC25.MainView = Me.GV25
        Me.GC25.Name = "GC25"
        Me.GC25.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FITCH})
        Me.GC25.Size = New System.Drawing.Size(649, 201)
        Me.GC25.TabIndex = 4
        Me.GC25.Tag = "[EDIT][ADD]"
        Me.GC25.UseEmbeddedNavigator = True
        Me.GC25.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV25})
        '
        'GV25
        '
        Me.GV25.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFITCH_FIT_CODE_FK_PK, Me.colFITCH_CH_CODE_FK_PK, Me.colFITCH_NUMORD, Me.GridColumn26})
        Me.GV25.GridControl = Me.GC25
        Me.GV25.Name = "GV25"
        Me.GV25.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV25.OptionsView.ShowGroupPanel = False
        '
        'colFITCH_FIT_CODE_FK_PK
        '
        Me.colFITCH_FIT_CODE_FK_PK.Caption = "FITCH_FIT_CODE_FK_PK"
        Me.colFITCH_FIT_CODE_FK_PK.FieldName = "FITCH_FIT_CODE_FK_PK"
        Me.colFITCH_FIT_CODE_FK_PK.Name = "colFITCH_FIT_CODE_FK_PK"
        '
        'colFITCH_CH_CODE_FK_PK
        '
        Me.colFITCH_CH_CODE_FK_PK.Caption = "Code"
        Me.colFITCH_CH_CODE_FK_PK.FieldName = "FITCH_CH_CODE_FK_PK"
        Me.colFITCH_CH_CODE_FK_PK.Name = "colFITCH_CH_CODE_FK_PK"
        Me.colFITCH_CH_CODE_FK_PK.Visible = True
        Me.colFITCH_CH_CODE_FK_PK.VisibleIndex = 0
        Me.colFITCH_CH_CODE_FK_PK.Width = 50
        '
        'colFITCH_NUMORD
        '
        Me.colFITCH_NUMORD.Caption = "FITCH_NUMORD"
        Me.colFITCH_NUMORD.ColumnEdit = Me.lkup_FITCH
        Me.colFITCH_NUMORD.FieldName = "FITCH_CH_CODE_FK_PK"
        Me.colFITCH_NUMORD.Name = "colFITCH_NUMORD"
        '
        'lkup_FITCH
        '
        Me.lkup_FITCH.AutoHeight = False
        Me.lkup_FITCH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FITCH.Name = "lkup_FITCH"
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "Critères de choix"
        Me.GridColumn26.ColumnEdit = Me.lkup_FITCH
        Me.GridColumn26.FieldName = "FITCH_CH_CODE_FK_PK"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 1
        Me.GridColumn26.Width = 578
        '
        'IT1SAC_TA
        '
        Me.IT1SAC_TA.ClearBeforeFill = True
        '
        'IT1SAU_TA
        '
        Me.IT1SAU_TA.ClearBeforeFill = True
        '
        'IT1PR_TA
        '
        Me.IT1PR_TA.ClearBeforeFill = True
        '
        'IT1SP_TA
        '
        Me.IT1SP_TA.ClearBeforeFill = True
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn8, Me.GridColumn9})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "IT1CPH_FIT_CODE_FK_PK"
        Me.GridColumn7.FieldName = "IT1CPH_FIT_CODE_FK_PK"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Code"
        Me.GridColumn8.FieldName = "IT1CPH_CPH_CODE_FK_PK"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 0
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Libellé"
        Me.GridColumn9.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.GridColumn9.FieldName = "IT1CPH_CPH_CODE_FK_PK"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 1
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'IT2CPH_TA
        '
        Me.IT2CPH_TA.ClearBeforeFill = True
        '
        'IT2CCH_TA
        '
        Me.IT2CCH_TA.ClearBeforeFill = True
        '
        'IT2CC_TA
        '
        Me.IT2CC_TA.ClearBeforeFill = True
        '
        'IT2SAC_TA
        '
        Me.IT2SAC_TA.ClearBeforeFill = True
        '
        'IT2SAU_TA
        '
        Me.IT2SAU_TA.ClearBeforeFill = True
        '
        'IT2PR_TA
        '
        Me.IT2PR_TA.ClearBeforeFill = True
        '
        'IT2SP_TA
        '
        Me.IT2SP_TA.ClearBeforeFill = True
        '
        'FitnA_TA
        '
        Me.FitnA_TA.ClearBeforeFill = True
        '
        'FitroF_TA
        '
        Me.FitroF_TA.ClearBeforeFill = True
        '
        'FitsE_TA
        '
        Me.FitsE_TA.ClearBeforeFill = True
        '
        'FittY_TA
        '
        Me.FittY_TA.ClearBeforeFill = True
        '
        'FitvA_TA
        '
        Me.FitvA_TA.ClearBeforeFill = True
        '
        'FitvD1_TA
        '
        Me.FitvD1_TA.ClearBeforeFill = True
        '
        'FitvD2_TA
        '
        Me.FitvD2_TA.ClearBeforeFill = True
        '
        'FitteR_TA
        '
        Me.FitteR_TA.ClearBeforeFill = True
        '
        'FitcH_TA
        '
        Me.FitcH_TA.ClearBeforeFill = True
        '
        'FitcT_TA
        '
        Me.FitcT_TA.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(650, 33)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Frm_Interactions_Fiche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(780, 574)
        Me.Name = "Frm_Interactions_Fiche"
        Me.Text = "Interactions - Fiche"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_AnalyseOrdonance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IT1CPH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IT1CCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.Terme1.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.GC7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IT1SP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        CType(Me.GC5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IT1SAU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IT1PR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.GC3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IT1CC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IT1SAC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Terme2.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        CType(Me.GC72, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV72, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IT2SP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        CType(Me.GC52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IT2SAU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC62, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV62, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IT2PR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        CType(Me.GC32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IT2CC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IT2SAC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        CType(Me.GC12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IT2CPH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IT2CCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Voie_dose.ResumeLayout(False)
        CType(Me.GC33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboteneur_Qualificatif2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FITVD2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup2_FITVD2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboteneur_Qualificatif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FITVD1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup2_FITVD1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Interaction.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.GC54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FITTER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC64, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV64, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FITCT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.GC34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FITTY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FITSE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GC14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FITVA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FITNA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageCriteres_choix.ResumeLayout(False)
        CType(Me.GC16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FITROF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FITCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FiT_TA As Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.FIT_FICHEINTERACTableAdapter
    Friend WithEvents IT1CC_TA As Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT1CC_TERM1COMCLASSETableAdapter
    Friend WithEvents IT1CCH_TA As Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT1CCH_TERME1CLCHIMTableAdapter
    Friend WithEvents IT1CPH_TA As Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT1CPH_TERME1CLPHARMTHERTableAdapter
    Friend WithEvents DsTheriaque_AnalyseOrdonance As Theriaque.dsTheriaque_AnalyseOrdonance
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GC1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GC2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents Terme1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIT1CPH_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1CPH_CPH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIT1CCH_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1CCH_CCH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Terme2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents colIT1CPH_CPH_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IT1CPH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colIT1CCH_CCH_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IT1CCH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIT1CC_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IT1CC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colIT1CC_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GC4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IT1SAC_TA As Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT1SAC_TERME1SUBACTIVETableAdapter
    Friend WithEvents colIT1SAC_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1SAC_SAC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1_TERM1SAC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IT1SAC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IT1SAU_TA As Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT1SAU_TERME1SUBAUXTableAdapter
    Friend WithEvents colIT1SAU_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1SAU_SAU_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IT1SAU As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colIT1_IT1SAU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GC6 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIT1PR_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1PR_PR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IT1PR_TA As Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT1PR_TERME1PRODUITTableAdapter
    Friend WithEvents colIT1PR_PR_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IT1PR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC7 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IT1SP_TA As Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT1SP_TERME1SPECIALITETableAdapter
    Friend WithEvents colIT1SP_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1SP_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1SP_SP_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IT1SP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC12 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents IT2CPH_TA As Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT2CPH_TERME2CLPHARMTHERTableAdapter
    Friend WithEvents colIT2CPH_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT2CPH_CPH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1CPH_CPH_CODE_FK_PK2_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IT2CPH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC22 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV22 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IT2CCH_TA As Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT2CCH_TERME2CLCHIMTableAdapter
    Friend WithEvents colIT2CCH_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT2CCH_CCH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1CCH_CCH_CODE_FK_PK2_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IT2CCH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC32 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV32 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIT2CC_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT2CC_CDF_CC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT2CC_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IT2CC_TA As Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT2CC_TERM2COMCLASSETableAdapter
    Friend WithEvents lkup_IT2CC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC42 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV42 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IT2SAC_TA As Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT2SAC_TERME2SUBACTIVETableAdapter
    Friend WithEvents colIT2SAC_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT2SAC_SAC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT2SAC_SAC_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IT2SAC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC52 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV52 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIT2SAU_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT2SAU_SAU_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT2SAU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IT2SAU As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents IT2SAU_TA As Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT2SAU_TERME2SUBAUXTableAdapter
    Friend WithEvents GC62 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV62 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIT2PR_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT2PR_PR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IT2PR_TA As Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT2PR_TERME2PRODUITTableAdapter
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IT2PR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC72 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV72 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IT2SP_TA As Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.IT2SP_TERME2SPECIALITETableAdapter
    Friend WithEvents colIT2SP_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT2SP_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT2SP_SP_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IT2SP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FitnA_TA As Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.FITNA_INTERACTION_NATURETableAdapter
    Friend WithEvents FitroF_TA As Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.FITROF_REF_OFFICIELLETableAdapter
    Friend WithEvents FitsE_TA As Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.FITSE_INTERACTION_SENSTableAdapter
    Friend WithEvents FittY_TA As Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.FITTY_TYPEINTERACTIONTableAdapter
    Friend WithEvents FitvA_TA As Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.FITVA_NIVEAU_VALIDATIONTableAdapter
    Friend WithEvents FitvD1_TA As Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.FITVD1_INTERACTION_VOIE_DOSETableAdapter
    Friend WithEvents FitvD2_TA As Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.FITVD2_INTERACTION_VOIE_DOSETableAdapter
    Friend WithEvents FitteR_TA As Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.FITTER_TERRAINFAVORISANTTableAdapter
    Friend WithEvents FitcH_TA As Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.FITCH_CRITERECHOIXTableAdapter
    Friend WithEvents FitcT_TA As Theriaque.dsTheriaque_AnalyseOrdonanceTableAdapters.FITCT_COMMENTAIRE_TERRAINTableAdapter
    Friend WithEvents Voie_dose As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GC13 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFITVD1_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITVD1_NUMSEQ_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITVD1_CDF_VO_CODE1_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITVD1_CDF_PP_CODE1_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITVD1_DOSE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITVD1_QUALIFICATIF_DOSE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITVD1_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FITVD1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GC33 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV33 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFITVD2_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITVD2_NUMSEQ_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITVD2_CDF_VO_CODE2_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITVD2_CDF_PP_CODE2_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITVD2_DOSE2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITVD2_QUALIFICATIF_DOSE2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITVD2_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FITVD2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Interaction As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GC14 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC44 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV44 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC34 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV34 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC24 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV24 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC64 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV64 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC54 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV54 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabPageCriteres_choix As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GC25 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV25 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFITVA_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITVA_CDF_VAIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITVA_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FITVA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFITNA_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITNA_CDF_NAIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITNA_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FITNA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFITTY_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITTY_CDF_TYPE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITTY_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FITTY As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFITSE_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITSE_CDF_SEIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITSE_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FITSE As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFITTER_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITTER_CDF_TER_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITTER_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FITTER As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFITCT_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITCT_CDF_CT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITCT_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FITCT As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITCH_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITCH_CH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITCH_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FITCH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnite As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup2_FITVD1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colUnite2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup2_FITVD2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC16 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV16 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFITROF_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITROF_CDF_DOC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITROF_NUM_DOC_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFITROF_DATE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FITROF As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents comboteneur_Qualificatif As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents comboteneur_Qualificatif2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl

End Class
