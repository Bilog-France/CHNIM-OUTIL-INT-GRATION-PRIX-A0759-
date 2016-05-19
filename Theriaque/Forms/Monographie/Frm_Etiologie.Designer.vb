<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Etiologie
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
        Me.FeT_TA = New Theriaque.dsTheriaque_EtiologieTableAdapters.FET_FICHEETIOLOGIETableAdapter
        Me.DsTheriaque_Etiologie = New Theriaque.dsTheriaque_Etiologie
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GC16 = New DevExpress.XtraGrid.GridControl
        Me.GV16 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFETTXTI_FET_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETTXTI_TXT_INTRO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.GC15 = New DevExpress.XtraGrid.GridControl
        Me.GV15 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFETSP_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETSP_FET_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETSP_SP_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FETSP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GC13 = New DevExpress.XtraGrid.GridControl
        Me.GV13 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFETSAC_SAC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETSAC_FET_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETSAC_SAC_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FETSAC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC14 = New DevExpress.XtraGrid.GridControl
        Me.GV14 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFETPR_PR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETPR_FET_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETPR_PR_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FETPR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.GC11 = New DevExpress.XtraGrid.GridControl
        Me.GV11 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFETCPH_CPH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETCPH_FET_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETCPH_CPH_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FETCPH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC12 = New DevExpress.XtraGrid.GridControl
        Me.GV12 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFETCCH_CCH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETCCH_FET_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETCCH_CCH_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FETCCH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.GC23 = New DevExpress.XtraGrid.GridControl
        Me.GV23 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFETTX1_FET_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETTX1_TEXTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_Memo1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.LookUp_FET = New DevExpress.XtraEditors.LookUpEdit
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.GC22 = New DevExpress.XtraGrid.GridControl
        Me.GV22 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFETCHS_FET_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETCHS_CDF_COIN_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FETCHS = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC21 = New DevExpress.XtraGrid.GridControl
        Me.GV21 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFETHS_FET_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETHS_CDF_ETIN_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETHS_POURCENTAGE_RESISTANCE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETHS_CDF_ETIN_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FETHS = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.GC33 = New DevExpress.XtraGrid.GridControl
        Me.GV33 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFETTX2_FET_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETTX2_TEXTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rm_Memo2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.LookUp_FETCIS = New DevExpress.XtraEditors.LookUpEdit
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.GC32 = New DevExpress.XtraGrid.GridControl
        Me.GV32 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFETCIS_FET_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETCIS_CDF_COIN_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FETCIS = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC31 = New DevExpress.XtraGrid.GridControl
        Me.GV31 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFETIS_FET_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETIS_CDF_ETIN_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETIS_POURCENTAGE_RESISTANCE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETIS_CDF_ETIN_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FETIS = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.GC43 = New DevExpress.XtraGrid.GridControl
        Me.GV43 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFETTX3_FET_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETTX3_TEXTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rm_Memo3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.Panel17 = New System.Windows.Forms.Panel
        Me.LookUp_FETCMS = New DevExpress.XtraEditors.LookUpEdit
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.GC42 = New DevExpress.XtraGrid.GridControl
        Me.GV42 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFETCMS_FET_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETCMS_CDF_COIN_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FETCMS = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC41 = New DevExpress.XtraGrid.GridControl
        Me.GV41 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFETMS_FET_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETMS_CDF_ETIN_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETMS_POURCENTAGE_RESISTANCE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETMS_CDF_ETIN_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FETMS = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel19 = New System.Windows.Forms.Panel
        Me.GC53 = New DevExpress.XtraGrid.GridControl
        Me.GV53 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFETTX4_FET_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETTX4_TEXTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rm_Memo4 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Panel20 = New System.Windows.Forms.Panel
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.Panel18 = New System.Windows.Forms.Panel
        Me.LookUp_FETRE = New DevExpress.XtraEditors.LookUpEdit
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.GC52 = New DevExpress.XtraGrid.GridControl
        Me.GV52 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFETCRE_FET_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETCRE_CDF_COIN_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FETCRE = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC51 = New DevExpress.XtraGrid.GridControl
        Me.GV51 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFETRE_FET_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETRE_CDF_ETIN_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETRE_POURCENTAGE_RESISTANCE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FETRE = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFETAFS_FET_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETAFS_DATE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFETAFS_CDF_DOCUMENT_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FETAFS = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFETAFS_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_SPAFS = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.FetcpH_TA = New Theriaque.dsTheriaque_EtiologieTableAdapters.FETCPH_ETIOCPHTableAdapter
        Me.FetccH_TA = New Theriaque.dsTheriaque_EtiologieTableAdapters.FETCCH_ETIOCCHTableAdapter
        Me.FetsaC_TA = New Theriaque.dsTheriaque_EtiologieTableAdapters.FETSAC_ETIOSUBACTableAdapter
        Me.FetpR_TA = New Theriaque.dsTheriaque_EtiologieTableAdapters.FETPR_ETIOPRODTableAdapter
        Me.FetsP_TA = New Theriaque.dsTheriaque_EtiologieTableAdapters.FETSP_ETIOSPETableAdapter
        Me.FettxtI_TA = New Theriaque.dsTheriaque_EtiologieTableAdapters.FETTXTI_TEXTINTRO_CMITableAdapter
        Me.FethS_TA = New Theriaque.dsTheriaque_EtiologieTableAdapters.FETHS_ETIOLOGIE_HABITU_SENSIBTableAdapter
        Me.FetchS_Ta = New Theriaque.dsTheriaque_EtiologieTableAdapters.FETCHS_COMMENT_HABITU_SENSIBLETableAdapter
        Me.FettX1_TA = New Theriaque.dsTheriaque_EtiologieTableAdapters.FETTX1_ET_TXHSTableAdapter
        Me.FetiS_TA = New Theriaque.dsTheriaque_EtiologieTableAdapters.FETIS_ETIOLOGIE_INCONST_SENSIBTableAdapter
        Me.FetciS_Ta = New Theriaque.dsTheriaque_EtiologieTableAdapters.FETCIS_COMMENT_INCONS_SENSIBLETableAdapter
        Me.FettX2_TA = New Theriaque.dsTheriaque_EtiologieTableAdapters.FETTX2_ET_TXISTableAdapter
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.FetmS_TA = New Theriaque.dsTheriaque_EtiologieTableAdapters.FETMS_ETIOLOGIE_MODEREM_SENSIBTableAdapter
        Me.FetcmS_TA = New Theriaque.dsTheriaque_EtiologieTableAdapters.FETCMS_COMMENT_MODERE_SENSIBLETableAdapter
        Me.FettX3_TA = New Theriaque.dsTheriaque_EtiologieTableAdapters.FETTX3_ET_TXMSTableAdapter
        Me.FetrE_TA = New Theriaque.dsTheriaque_EtiologieTableAdapters.FETRE_ETIOLOGIE_RESISTANTESTableAdapter
        Me.FetcrE_TA = New Theriaque.dsTheriaque_EtiologieTableAdapters.FETCRE_COMMENT_RESISTANTETableAdapter
        Me.FettX4_TA = New Theriaque.dsTheriaque_EtiologieTableAdapters.FETTX4_ET_TXRETableAdapter
        Me.FetafS_TA = New Theriaque.dsTheriaque_EtiologieTableAdapters.FETAFS_FET_AFSSAPSTableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_Etiologie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GC16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FETSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.GC13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FETSAC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FETPR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.GC11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FETCPH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FETCCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage1.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel14.SuspendLayout()
        CType(Me.GC23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_Memo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.LookUp_FET.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FETCHS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FETHS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.GC33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rm_Memo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.LookUp_FETCIS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FETCIS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FETIS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel15.SuspendLayout()
        CType(Me.GC43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rm_Memo3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel16.SuspendLayout()
        Me.Panel17.SuspendLayout()
        CType(Me.LookUp_FETCMS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FETCMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FETMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel19.SuspendLayout()
        CType(Me.GC53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rm_Memo4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel20.SuspendLayout()
        Me.Panel18.SuspendLayout()
        CType(Me.LookUp_FETRE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FETCRE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FETRE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage6.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FETAFS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_SPAFS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Text = "Etiologie"
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
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Etiologie, "FET_FICHEETIOLOGIE.FET_DATEMJ", True))
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
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Etiologie, "FET_FICHEETIOLOGIE.FET_DATECR", True))
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
        'FeT_TA
        '
        Me.FeT_TA.ClearBeforeFill = True
        '
        'DsTheriaque_Etiologie
        '
        Me.DsTheriaque_Etiologie.DataSetName = "dsTheriaque_Etiologie"
        Me.DsTheriaque_Etiologie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(655, 42)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Etiologie, "FET_FICHEETIOLOGIE.FET_CODE_SQ_PK", True))
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
        Me.XtraTabControl1.Location = New System.Drawing.Point(4, 54)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage2
        Me.XtraTabControl1.Size = New System.Drawing.Size(652, 430)
        Me.XtraTabControl1.TabIndex = 7
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2, Me.XtraTabPage1, Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5, Me.XtraTabPage6})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Panel3)
        Me.XtraTabPage2.Controls.Add(Me.Panel2)
        Me.XtraTabPage2.Controls.Add(Me.Panel5)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(643, 399)
        Me.XtraTabPage2.Tag = "[EDIT][ADD]"
        Me.XtraTabPage2.Text = "Entités"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GC16)
        Me.Panel3.Controls.Add(Me.GC15)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 264)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(643, 135)
        Me.Panel3.TabIndex = 19
        '
        'GC16
        '
        Me.GC16.DataMember = "FETTXTI_TEXTINTRO_CMI"
        Me.GC16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC16.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC16.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC16.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC16.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC16.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC16.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC16.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC16.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC16.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC16.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC16.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC16.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC16.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC16.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC16.EmbeddedNavigator.Name = ""
        Me.GC16.EmbeddedNavigator.TextStringFormat = ""
        Me.GC16.Location = New System.Drawing.Point(340, 0)
        Me.GC16.MainView = Me.GV16
        Me.GC16.Name = "GC16"
        Me.GC16.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1})
        Me.GC16.Size = New System.Drawing.Size(303, 135)
        Me.GC16.TabIndex = 4
        Me.GC16.UseEmbeddedNavigator = True
        Me.GC16.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV16})
        '
        'GV16
        '
        Me.GV16.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFETTXTI_FET_CODE_FK_PK, Me.colFETTXTI_TXT_INTRO})
        Me.GV16.GridControl = Me.GC16
        Me.GV16.GroupFormat = ""
        Me.GV16.GroupPanelText = " "
        Me.GV16.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GV16.Name = "GV16"
        Me.GV16.OptionsCustomization.AllowRowSizing = True
        Me.GV16.OptionsNavigation.AutoFocusNewRow = True
        Me.GV16.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV16.OptionsView.RowAutoHeight = True
        Me.GV16.OptionsView.ShowColumnHeaders = False
        Me.GV16.OptionsView.ShowDetailButtons = False
        Me.GV16.OptionsView.ShowGroupPanel = False
        Me.GV16.OptionsView.ShowHorzLines = False
        Me.GV16.OptionsView.ShowIndicator = False
        Me.GV16.RowHeight = 110
        Me.GV16.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colFETTXTI_FET_CODE_FK_PK
        '
        Me.colFETTXTI_FET_CODE_FK_PK.Caption = "FETTXTI_FET_CODE_FK_PK"
        Me.colFETTXTI_FET_CODE_FK_PK.FieldName = "FETTXTI_FET_CODE_FK_PK"
        Me.colFETTXTI_FET_CODE_FK_PK.Name = "colFETTXTI_FET_CODE_FK_PK"
        '
        'colFETTXTI_TXT_INTRO
        '
        Me.colFETTXTI_TXT_INTRO.Caption = "FETTXTI_TXT_INTRO"
        Me.colFETTXTI_TXT_INTRO.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colFETTXTI_TXT_INTRO.FieldName = "FETTXTI_TXT_INTRO"
        Me.colFETTXTI_TXT_INTRO.Name = "colFETTXTI_TXT_INTRO"
        Me.colFETTXTI_TXT_INTRO.Visible = True
        Me.colFETTXTI_TXT_INTRO.VisibleIndex = 0
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'GC15
        '
        Me.GC15.DataMember = "FETSP_ETIOSPE"
        Me.GC15.Dock = System.Windows.Forms.DockStyle.Left
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
        Me.GC15.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FETSP})
        Me.GC15.Size = New System.Drawing.Size(340, 135)
        Me.GC15.TabIndex = 2
        Me.GC15.Tag = "[EDIT][ADD]"
        Me.GC15.UseEmbeddedNavigator = True
        Me.GC15.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV15})
        '
        'GV15
        '
        Me.GV15.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFETSP_SP_CODE_FK_PK, Me.colFETSP_FET_CODE_FK_PK, Me.colFETSP_SP_CODE_FK_PK2})
        Me.GV15.GridControl = Me.GC15
        Me.GV15.Name = "GV15"
        Me.GV15.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV15.OptionsView.ShowGroupPanel = False
        '
        'colFETSP_SP_CODE_FK_PK
        '
        Me.colFETSP_SP_CODE_FK_PK.Caption = "Code"
        Me.colFETSP_SP_CODE_FK_PK.FieldName = "FETSP_SP_CODE_FK_PK"
        Me.colFETSP_SP_CODE_FK_PK.Name = "colFETSP_SP_CODE_FK_PK"
        Me.colFETSP_SP_CODE_FK_PK.Visible = True
        Me.colFETSP_SP_CODE_FK_PK.VisibleIndex = 0
        Me.colFETSP_SP_CODE_FK_PK.Width = 50
        '
        'colFETSP_FET_CODE_FK_PK
        '
        Me.colFETSP_FET_CODE_FK_PK.Caption = "FETSP_FET_CODE_FK_PK"
        Me.colFETSP_FET_CODE_FK_PK.FieldName = "FETSP_FET_CODE_FK_PK"
        Me.colFETSP_FET_CODE_FK_PK.Name = "colFETSP_FET_CODE_FK_PK"
        '
        'colFETSP_SP_CODE_FK_PK2
        '
        Me.colFETSP_SP_CODE_FK_PK2.Caption = "Spécialités"
        Me.colFETSP_SP_CODE_FK_PK2.ColumnEdit = Me.lkup_FETSP
        Me.colFETSP_SP_CODE_FK_PK2.FieldName = "FETSP_SP_CODE_FK_PK"
        Me.colFETSP_SP_CODE_FK_PK2.Name = "colFETSP_SP_CODE_FK_PK2"
        Me.colFETSP_SP_CODE_FK_PK2.Visible = True
        Me.colFETSP_SP_CODE_FK_PK2.VisibleIndex = 1
        Me.colFETSP_SP_CODE_FK_PK2.Width = 269
        '
        'lkup_FETSP
        '
        Me.lkup_FETSP.AutoHeight = False
        Me.lkup_FETSP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FETSP.Name = "lkup_FETSP"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GC13)
        Me.Panel2.Controls.Add(Me.GC14)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 132)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(643, 132)
        Me.Panel2.TabIndex = 18
        '
        'GC13
        '
        Me.GC13.DataMember = "FETSAC_ETIOSUBAC"
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
        Me.GC13.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FETSAC})
        Me.GC13.Size = New System.Drawing.Size(340, 132)
        Me.GC13.TabIndex = 2
        Me.GC13.Tag = "[EDIT][ADD]"
        Me.GC13.UseEmbeddedNavigator = True
        Me.GC13.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV13})
        '
        'GV13
        '
        Me.GV13.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFETSAC_SAC_CODE_FK_PK, Me.colFETSAC_FET_CODE_FK_PK, Me.colFETSAC_SAC_CODE_FK_PK2})
        Me.GV13.GridControl = Me.GC13
        Me.GV13.Name = "GV13"
        Me.GV13.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV13.OptionsView.ShowGroupPanel = False
        '
        'colFETSAC_SAC_CODE_FK_PK
        '
        Me.colFETSAC_SAC_CODE_FK_PK.Caption = "Code"
        Me.colFETSAC_SAC_CODE_FK_PK.FieldName = "FETSAC_SAC_CODE_FK_PK"
        Me.colFETSAC_SAC_CODE_FK_PK.Name = "colFETSAC_SAC_CODE_FK_PK"
        Me.colFETSAC_SAC_CODE_FK_PK.Visible = True
        Me.colFETSAC_SAC_CODE_FK_PK.VisibleIndex = 0
        Me.colFETSAC_SAC_CODE_FK_PK.Width = 50
        '
        'colFETSAC_FET_CODE_FK_PK
        '
        Me.colFETSAC_FET_CODE_FK_PK.Caption = "FETSAC_FET_CODE_FK_PK"
        Me.colFETSAC_FET_CODE_FK_PK.FieldName = "FETSAC_FET_CODE_FK_PK"
        Me.colFETSAC_FET_CODE_FK_PK.Name = "colFETSAC_FET_CODE_FK_PK"
        '
        'colFETSAC_SAC_CODE_FK_PK2
        '
        Me.colFETSAC_SAC_CODE_FK_PK2.Caption = "Substance active"
        Me.colFETSAC_SAC_CODE_FK_PK2.ColumnEdit = Me.lkup_FETSAC
        Me.colFETSAC_SAC_CODE_FK_PK2.FieldName = "FETSAC_SAC_CODE_FK_PK"
        Me.colFETSAC_SAC_CODE_FK_PK2.Name = "colFETSAC_SAC_CODE_FK_PK2"
        Me.colFETSAC_SAC_CODE_FK_PK2.Visible = True
        Me.colFETSAC_SAC_CODE_FK_PK2.VisibleIndex = 1
        Me.colFETSAC_SAC_CODE_FK_PK2.Width = 269
        '
        'lkup_FETSAC
        '
        Me.lkup_FETSAC.AutoHeight = False
        Me.lkup_FETSAC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FETSAC.Name = "lkup_FETSAC"
        '
        'GC14
        '
        Me.GC14.DataMember = "FETPR_ETIOPROD"
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
        Me.GC14.Location = New System.Drawing.Point(340, 0)
        Me.GC14.MainView = Me.GV14
        Me.GC14.Name = "GC14"
        Me.GC14.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FETPR})
        Me.GC14.Size = New System.Drawing.Size(303, 132)
        Me.GC14.TabIndex = 3
        Me.GC14.Tag = "[EDIT][ADD]"
        Me.GC14.UseEmbeddedNavigator = True
        Me.GC14.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV14})
        '
        'GV14
        '
        Me.GV14.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFETPR_PR_CODE_FK_PK, Me.colFETPR_FET_CODE_FK_PK, Me.colFETPR_PR_CODE_FK_PK2})
        Me.GV14.GridControl = Me.GC14
        Me.GV14.Name = "GV14"
        Me.GV14.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV14.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV14.OptionsView.ShowGroupPanel = False
        '
        'colFETPR_PR_CODE_FK_PK
        '
        Me.colFETPR_PR_CODE_FK_PK.Caption = "Code"
        Me.colFETPR_PR_CODE_FK_PK.FieldName = "FETPR_PR_CODE_FK_PK"
        Me.colFETPR_PR_CODE_FK_PK.Name = "colFETPR_PR_CODE_FK_PK"
        Me.colFETPR_PR_CODE_FK_PK.Visible = True
        Me.colFETPR_PR_CODE_FK_PK.VisibleIndex = 0
        Me.colFETPR_PR_CODE_FK_PK.Width = 50
        '
        'colFETPR_FET_CODE_FK_PK
        '
        Me.colFETPR_FET_CODE_FK_PK.Caption = "FETPR_FET_CODE_FK_PK"
        Me.colFETPR_FET_CODE_FK_PK.FieldName = "FETPR_FET_CODE_FK_PK"
        Me.colFETPR_FET_CODE_FK_PK.Name = "colFETPR_FET_CODE_FK_PK"
        '
        'colFETPR_PR_CODE_FK_PK2
        '
        Me.colFETPR_PR_CODE_FK_PK2.Caption = "Produit"
        Me.colFETPR_PR_CODE_FK_PK2.ColumnEdit = Me.lkup_FETPR
        Me.colFETPR_PR_CODE_FK_PK2.FieldName = "FETPR_PR_CODE_FK_PK"
        Me.colFETPR_PR_CODE_FK_PK2.Name = "colFETPR_PR_CODE_FK_PK2"
        Me.colFETPR_PR_CODE_FK_PK2.Visible = True
        Me.colFETPR_PR_CODE_FK_PK2.VisibleIndex = 1
        Me.colFETPR_PR_CODE_FK_PK2.Width = 232
        '
        'lkup_FETPR
        '
        Me.lkup_FETPR.AutoHeight = False
        Me.lkup_FETPR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FETPR.Name = "lkup_FETPR"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GC11)
        Me.Panel5.Controls.Add(Me.GC12)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(643, 132)
        Me.Panel5.TabIndex = 17
        '
        'GC11
        '
        Me.GC11.DataMember = "FETCPH_ETIOCPH"
        Me.GC11.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.GC11.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FETCPH})
        Me.GC11.Size = New System.Drawing.Size(340, 132)
        Me.GC11.TabIndex = 2
        Me.GC11.Tag = "[EDIT][ADD]"
        Me.GC11.UseEmbeddedNavigator = True
        Me.GC11.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV11})
        '
        'GV11
        '
        Me.GV11.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFETCPH_CPH_CODE_FK_PK, Me.colFETCPH_FET_CODE_FK_PK, Me.colFETCPH_CPH_CODE_FK_PK2})
        Me.GV11.GridControl = Me.GC11
        Me.GV11.Name = "GV11"
        Me.GV11.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV11.OptionsView.ShowGroupPanel = False
        '
        'colFETCPH_CPH_CODE_FK_PK
        '
        Me.colFETCPH_CPH_CODE_FK_PK.Caption = "Code"
        Me.colFETCPH_CPH_CODE_FK_PK.FieldName = "FETCPH_CPH_CODE_FK_PK"
        Me.colFETCPH_CPH_CODE_FK_PK.Name = "colFETCPH_CPH_CODE_FK_PK"
        Me.colFETCPH_CPH_CODE_FK_PK.Visible = True
        Me.colFETCPH_CPH_CODE_FK_PK.VisibleIndex = 0
        Me.colFETCPH_CPH_CODE_FK_PK.Width = 50
        '
        'colFETCPH_FET_CODE_FK_PK
        '
        Me.colFETCPH_FET_CODE_FK_PK.Caption = "colFETCPH_FET_CODE_FK_PK"
        Me.colFETCPH_FET_CODE_FK_PK.FieldName = "FETCPH_FET_CODE_FK_PK"
        Me.colFETCPH_FET_CODE_FK_PK.Name = "colFETCPH_FET_CODE_FK_PK"
        Me.colFETCPH_FET_CODE_FK_PK.Width = 59
        '
        'colFETCPH_CPH_CODE_FK_PK2
        '
        Me.colFETCPH_CPH_CODE_FK_PK2.Caption = "Classe pharmaco thérapeutique"
        Me.colFETCPH_CPH_CODE_FK_PK2.ColumnEdit = Me.lkup_FETCPH
        Me.colFETCPH_CPH_CODE_FK_PK2.FieldName = "FETCPH_CPH_CODE_FK_PK"
        Me.colFETCPH_CPH_CODE_FK_PK2.Name = "colFETCPH_CPH_CODE_FK_PK2"
        Me.colFETCPH_CPH_CODE_FK_PK2.Visible = True
        Me.colFETCPH_CPH_CODE_FK_PK2.VisibleIndex = 1
        Me.colFETCPH_CPH_CODE_FK_PK2.Width = 269
        '
        'lkup_FETCPH
        '
        Me.lkup_FETCPH.AutoHeight = False
        Me.lkup_FETCPH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FETCPH.Name = "lkup_FETCPH"
        '
        'GC12
        '
        Me.GC12.DataMember = "FETCCH_ETIOCCH"
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
        Me.GC12.Location = New System.Drawing.Point(340, 0)
        Me.GC12.MainView = Me.GV12
        Me.GC12.Name = "GC12"
        Me.GC12.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FETCCH})
        Me.GC12.Size = New System.Drawing.Size(303, 132)
        Me.GC12.TabIndex = 3
        Me.GC12.Tag = "[EDIT][ADD]"
        Me.GC12.UseEmbeddedNavigator = True
        Me.GC12.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV12})
        '
        'GV12
        '
        Me.GV12.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFETCCH_CCH_CODE_FK_PK, Me.colFETCCH_FET_CODE_FK_PK, Me.colFETCCH_CCH_CODE_FK_PK2})
        Me.GV12.GridControl = Me.GC12
        Me.GV12.Name = "GV12"
        Me.GV12.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV12.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV12.OptionsView.ShowGroupPanel = False
        '
        'colFETCCH_CCH_CODE_FK_PK
        '
        Me.colFETCCH_CCH_CODE_FK_PK.Caption = "Code"
        Me.colFETCCH_CCH_CODE_FK_PK.FieldName = "FETCCH_CCH_CODE_FK_PK"
        Me.colFETCCH_CCH_CODE_FK_PK.Name = "colFETCCH_CCH_CODE_FK_PK"
        Me.colFETCCH_CCH_CODE_FK_PK.Visible = True
        Me.colFETCCH_CCH_CODE_FK_PK.VisibleIndex = 0
        Me.colFETCCH_CCH_CODE_FK_PK.Width = 50
        '
        'colFETCCH_FET_CODE_FK_PK
        '
        Me.colFETCCH_FET_CODE_FK_PK.Caption = "colFETCCH_FET_CODE_FK_PK"
        Me.colFETCCH_FET_CODE_FK_PK.FieldName = "FETCCH_FET_CODE_FK_PK"
        Me.colFETCCH_FET_CODE_FK_PK.Name = "colFETCCH_FET_CODE_FK_PK"
        '
        'colFETCCH_CCH_CODE_FK_PK2
        '
        Me.colFETCCH_CCH_CODE_FK_PK2.Caption = "Classe chimique"
        Me.colFETCCH_CCH_CODE_FK_PK2.ColumnEdit = Me.lkup_FETCCH
        Me.colFETCCH_CCH_CODE_FK_PK2.FieldName = "FETCCH_CCH_CODE_FK_PK"
        Me.colFETCCH_CCH_CODE_FK_PK2.Name = "colFETCCH_CCH_CODE_FK_PK2"
        Me.colFETCCH_CCH_CODE_FK_PK2.Visible = True
        Me.colFETCCH_CCH_CODE_FK_PK2.VisibleIndex = 1
        Me.colFETCCH_CCH_CODE_FK_PK2.Width = 232
        '
        'lkup_FETCCH
        '
        Me.lkup_FETCCH.AutoHeight = False
        Me.lkup_FETCCH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FETCCH.Name = "lkup_FETCCH"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panel12)
        Me.XtraTabPage1.Controls.Add(Me.Panel8)
        Me.XtraTabPage1.Controls.Add(Me.GC22)
        Me.XtraTabPage1.Controls.Add(Me.GC21)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(643, 399)
        Me.XtraTabPage1.Tag = "[EDIT][ADD]"
        Me.XtraTabPage1.Text = "Esp habituellement sensibles"
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.Panel14)
        Me.Panel12.Controls.Add(Me.Panel13)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(0, 275)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(643, 124)
        Me.Panel12.TabIndex = 38
        Me.Panel12.Tag = ""
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.GC23)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(0, 24)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(643, 100)
        Me.Panel14.TabIndex = 38
        Me.Panel14.Tag = "[ADD][EDIT]"
        '
        'GC23
        '
        Me.GC23.DataMember = "FETTX1_ET_TXHS"
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
        Me.GC23.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_Memo1})
        Me.GC23.Size = New System.Drawing.Size(643, 97)
        Me.GC23.TabIndex = 3
        Me.GC23.UseEmbeddedNavigator = True
        Me.GC23.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV23})
        '
        'GV23
        '
        Me.GV23.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFETTX1_FET_CODE_FK_PK, Me.colFETTX1_TEXTE})
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
        Me.GV23.RowHeight = 75
        Me.GV23.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colFETTX1_FET_CODE_FK_PK
        '
        Me.colFETTX1_FET_CODE_FK_PK.Caption = "FETTX1_FET_CODE_FK_PK"
        Me.colFETTX1_FET_CODE_FK_PK.FieldName = "FETTX1_FET_CODE_FK_PK"
        Me.colFETTX1_FET_CODE_FK_PK.Name = "colFETTX1_FET_CODE_FK_PK"
        '
        'colFETTX1_TEXTE
        '
        Me.colFETTX1_TEXTE.Caption = "FETTX1_TEXTE"
        Me.colFETTX1_TEXTE.ColumnEdit = Me.rp_Memo1
        Me.colFETTX1_TEXTE.FieldName = "FETTX1_TEXTE"
        Me.colFETTX1_TEXTE.Name = "colFETTX1_TEXTE"
        Me.colFETTX1_TEXTE.Visible = True
        Me.colFETTX1_TEXTE.VisibleIndex = 0
        '
        'rp_Memo1
        '
        Me.rp_Memo1.Name = "rp_Memo1"
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.LabelControl6)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(643, 24)
        Me.Panel13.TabIndex = 37
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(2, 8)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl6.TabIndex = 19
        Me.LabelControl6.Text = "Texte"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.LookUp_FET)
        Me.Panel8.Controls.Add(Me.TextEdit1)
        Me.Panel8.Controls.Add(Me.LabelControl4)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 240)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(643, 35)
        Me.Panel8.TabIndex = 39
        '
        'LookUp_FET
        '
        Me.LookUp_FET.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Etiologie, "FET_FICHEETIOLOGIE.FET_CDF_UDHS_CODE_FK", True))
        Me.LookUp_FET.Location = New System.Drawing.Point(119, 7)
        Me.LookUp_FET.Name = "LookUp_FET"
        Me.LookUp_FET.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUp_FET.Size = New System.Drawing.Size(148, 20)
        Me.LookUp_FET.TabIndex = 7
        Me.LookUp_FET.Tag = ""
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Etiologie, "FET_FICHEETIOLOGIE.FET_CMIHS", True))
        Me.TextEdit1.Location = New System.Drawing.Point(67, 7)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(46, 20)
        Me.TextEdit1.TabIndex = 4
        Me.TextEdit1.Tag = "[EDIT][ADD]"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(2, 11)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl4.TabIndex = 5
        Me.LabelControl4.Text = "CMI = ou <"
        '
        'GC22
        '
        Me.GC22.DataMember = "FETCHS_COMMENT_HABITU_SENSIBLE"
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
        Me.GC22.Location = New System.Drawing.Point(0, 114)
        Me.GC22.MainView = Me.GV22
        Me.GC22.Name = "GC22"
        Me.GC22.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FETCHS})
        Me.GC22.Size = New System.Drawing.Size(643, 126)
        Me.GC22.TabIndex = 8
        Me.GC22.Tag = "[EDIT][ADD]"
        Me.GC22.UseEmbeddedNavigator = True
        Me.GC22.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV22})
        '
        'GV22
        '
        Me.GV22.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFETCHS_FET_CODE_FK_PK, Me.colFETCHS_CDF_COIN_CODE_FK_PK, Me.GridColumn8})
        Me.GV22.GridControl = Me.GC22
        Me.GV22.Name = "GV22"
        Me.GV22.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV22.OptionsView.ShowGroupPanel = False
        '
        'colFETCHS_FET_CODE_FK_PK
        '
        Me.colFETCHS_FET_CODE_FK_PK.Caption = "FETCHS_FET_CODE_FK_PK"
        Me.colFETCHS_FET_CODE_FK_PK.FieldName = "FETCHS_FET_CODE_FK_PK"
        Me.colFETCHS_FET_CODE_FK_PK.Name = "colFETCHS_FET_CODE_FK_PK"
        '
        'colFETCHS_CDF_COIN_CODE_FK_PK
        '
        Me.colFETCHS_CDF_COIN_CODE_FK_PK.Caption = "Code"
        Me.colFETCHS_CDF_COIN_CODE_FK_PK.FieldName = "FETCHS_CDF_COIN_CODE_FK_PK"
        Me.colFETCHS_CDF_COIN_CODE_FK_PK.Name = "colFETCHS_CDF_COIN_CODE_FK_PK"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Commentaires"
        Me.GridColumn8.ColumnEdit = Me.lkup_FETCHS
        Me.GridColumn8.FieldName = "FETCHS_CDF_COIN_CODE_FK_PK"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 0
        '
        'lkup_FETCHS
        '
        Me.lkup_FETCHS.AutoHeight = False
        Me.lkup_FETCHS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FETCHS.Name = "lkup_FETCHS"
        '
        'GC21
        '
        Me.GC21.DataMember = "FETHS_ETIOLOGIE_HABITU_SENSIB"
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
        Me.GC21.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FETHS})
        Me.GC21.Size = New System.Drawing.Size(643, 114)
        Me.GC21.TabIndex = 3
        Me.GC21.Tag = "[EDIT][ADD]"
        Me.GC21.UseEmbeddedNavigator = True
        Me.GC21.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV21})
        '
        'GV21
        '
        Me.GV21.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFETHS_FET_CODE_FK_PK, Me.colFETHS_CDF_ETIN_CODE_FK_PK, Me.colFETHS_POURCENTAGE_RESISTANCE, Me.colFETHS_CDF_ETIN_CODE_FK_PK2})
        Me.GV21.GridControl = Me.GC21
        Me.GV21.Name = "GV21"
        Me.GV21.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV21.OptionsView.ShowGroupPanel = False
        '
        'colFETHS_FET_CODE_FK_PK
        '
        Me.colFETHS_FET_CODE_FK_PK.Caption = "FETHS_FET_CODE_FK_PK"
        Me.colFETHS_FET_CODE_FK_PK.FieldName = "FETHS_FET_CODE_FK_PK"
        Me.colFETHS_FET_CODE_FK_PK.Name = "colFETHS_FET_CODE_FK_PK"
        '
        'colFETHS_CDF_ETIN_CODE_FK_PK
        '
        Me.colFETHS_CDF_ETIN_CODE_FK_PK.Caption = "Code"
        Me.colFETHS_CDF_ETIN_CODE_FK_PK.FieldName = "FETHS_CDF_ETIN_CODE_FK_PK"
        Me.colFETHS_CDF_ETIN_CODE_FK_PK.Name = "colFETHS_CDF_ETIN_CODE_FK_PK"
        Me.colFETHS_CDF_ETIN_CODE_FK_PK.Visible = True
        Me.colFETHS_CDF_ETIN_CODE_FK_PK.VisibleIndex = 0
        Me.colFETHS_CDF_ETIN_CODE_FK_PK.Width = 50
        '
        'colFETHS_POURCENTAGE_RESISTANCE
        '
        Me.colFETHS_POURCENTAGE_RESISTANCE.Caption = "% Resist"
        Me.colFETHS_POURCENTAGE_RESISTANCE.FieldName = "FETHS_POURCENTAGE_RESISTANCE"
        Me.colFETHS_POURCENTAGE_RESISTANCE.Name = "colFETHS_POURCENTAGE_RESISTANCE"
        Me.colFETHS_POURCENTAGE_RESISTANCE.Visible = True
        Me.colFETHS_POURCENTAGE_RESISTANCE.VisibleIndex = 2
        '
        'colFETHS_CDF_ETIN_CODE_FK_PK2
        '
        Me.colFETHS_CDF_ETIN_CODE_FK_PK2.Caption = "Agent / Etiologie"
        Me.colFETHS_CDF_ETIN_CODE_FK_PK2.ColumnEdit = Me.lkup_FETHS
        Me.colFETHS_CDF_ETIN_CODE_FK_PK2.FieldName = "FETHS_CDF_ETIN_CODE_FK_PK"
        Me.colFETHS_CDF_ETIN_CODE_FK_PK2.Name = "colFETHS_CDF_ETIN_CODE_FK_PK2"
        Me.colFETHS_CDF_ETIN_CODE_FK_PK2.Visible = True
        Me.colFETHS_CDF_ETIN_CODE_FK_PK2.VisibleIndex = 1
        Me.colFETHS_CDF_ETIN_CODE_FK_PK2.Width = 498
        '
        'lkup_FETHS
        '
        Me.lkup_FETHS.AutoHeight = False
        Me.lkup_FETHS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FETHS.Name = "lkup_FETHS"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.Panel4)
        Me.XtraTabPage3.Controls.Add(Me.Panel9)
        Me.XtraTabPage3.Controls.Add(Me.GC32)
        Me.XtraTabPage3.Controls.Add(Me.GC31)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(493, 391)
        Me.XtraTabPage3.Tag = "[EDIT][ADD]"
        Me.XtraTabPage3.Text = "Esp inconstament sensibles"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel10)
        Me.Panel4.Controls.Add(Me.Panel11)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 275)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(493, 116)
        Me.Panel4.TabIndex = 39
        Me.Panel4.Tag = ""
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.GC33)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(0, 24)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(493, 92)
        Me.Panel10.TabIndex = 38
        Me.Panel10.Tag = "[ADD][EDIT]"
        '
        'GC33
        '
        Me.GC33.DataMember = "FETTX2_ET_TXIS"
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
        Me.GC33.Size = New System.Drawing.Size(493, 92)
        Me.GC33.TabIndex = 4
        Me.GC33.UseEmbeddedNavigator = True
        Me.GC33.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV33})
        '
        'GV33
        '
        Me.GV33.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFETTX2_FET_CODE_FK_PK, Me.colFETTX2_TEXTE})
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
        Me.GV33.RowHeight = 75
        Me.GV33.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colFETTX2_FET_CODE_FK_PK
        '
        Me.colFETTX2_FET_CODE_FK_PK.Caption = "FETTX2_FET_CODE_FK_PK"
        Me.colFETTX2_FET_CODE_FK_PK.FieldName = "FETTX2_FET_CODE_FK_PK"
        Me.colFETTX2_FET_CODE_FK_PK.Name = "colFETTX2_FET_CODE_FK_PK"
        '
        'colFETTX2_TEXTE
        '
        Me.colFETTX2_TEXTE.Caption = "FETTX2_TEXTE"
        Me.colFETTX2_TEXTE.ColumnEdit = Me.rm_Memo2
        Me.colFETTX2_TEXTE.FieldName = "FETTX2_TEXTE"
        Me.colFETTX2_TEXTE.Name = "colFETTX2_TEXTE"
        Me.colFETTX2_TEXTE.Visible = True
        Me.colFETTX2_TEXTE.VisibleIndex = 0
        '
        'rm_Memo2
        '
        Me.rm_Memo2.Name = "rm_Memo2"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.LabelControl7)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(493, 24)
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
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.LookUp_FETCIS)
        Me.Panel9.Controls.Add(Me.TextEdit2)
        Me.Panel9.Controls.Add(Me.LabelControl5)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 240)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(493, 35)
        Me.Panel9.TabIndex = 38
        '
        'LookUp_FETCIS
        '
        Me.LookUp_FETCIS.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Etiologie, "FET_FICHEETIOLOGIE.FET_CDF_UDIS_CODE_FK", True))
        Me.LookUp_FETCIS.Location = New System.Drawing.Point(85, 7)
        Me.LookUp_FETCIS.Name = "LookUp_FETCIS"
        Me.LookUp_FETCIS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUp_FETCIS.Size = New System.Drawing.Size(148, 20)
        Me.LookUp_FETCIS.TabIndex = 13
        Me.LookUp_FETCIS.Tag = ""
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Etiologie, "FET_FICHEETIOLOGIE.FET_CMIIS", True))
        Me.TextEdit2.Location = New System.Drawing.Point(33, 7)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(46, 20)
        Me.TextEdit2.TabIndex = 11
        Me.TextEdit2.Tag = "[EDIT][ADD]"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(3, 11)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl5.TabIndex = 12
        Me.LabelControl5.Text = "CMI"
        '
        'GC32
        '
        Me.GC32.DataMember = "FETCIS_COMMENT_INCONS_SENSIBLE"
        Me.GC32.Dock = System.Windows.Forms.DockStyle.Top
        Me.GC32.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC32.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC32.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC32.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC32.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC32.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC32.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC32.EmbeddedNavigator.Name = ""
        Me.GC32.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC32.Location = New System.Drawing.Point(0, 114)
        Me.GC32.MainView = Me.GV32
        Me.GC32.Name = "GC32"
        Me.GC32.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FETCIS})
        Me.GC32.Size = New System.Drawing.Size(493, 126)
        Me.GC32.TabIndex = 10
        Me.GC32.Tag = "[EDIT][ADD]"
        Me.GC32.UseEmbeddedNavigator = True
        Me.GC32.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV32})
        '
        'GV32
        '
        Me.GV32.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFETCIS_FET_CODE_FK_PK, Me.colFETCIS_CDF_COIN_CODE_FK_PK, Me.GridColumn10})
        Me.GV32.GridControl = Me.GC32
        Me.GV32.Name = "GV32"
        Me.GV32.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV32.OptionsView.ShowGroupPanel = False
        '
        'colFETCIS_FET_CODE_FK_PK
        '
        Me.colFETCIS_FET_CODE_FK_PK.Caption = "FETCIS_FET_CODE_FK_PK"
        Me.colFETCIS_FET_CODE_FK_PK.FieldName = "FETCIS_FET_CODE_FK_PK"
        Me.colFETCIS_FET_CODE_FK_PK.Name = "colFETCIS_FET_CODE_FK_PK"
        '
        'colFETCIS_CDF_COIN_CODE_FK_PK
        '
        Me.colFETCIS_CDF_COIN_CODE_FK_PK.Caption = "FETCIS_CDF_COIN_CODE_FK_PK"
        Me.colFETCIS_CDF_COIN_CODE_FK_PK.FieldName = "FETCIS_CDF_COIN_CODE_FK_PK"
        Me.colFETCIS_CDF_COIN_CODE_FK_PK.Name = "colFETCIS_CDF_COIN_CODE_FK_PK"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Commentaires"
        Me.GridColumn10.ColumnEdit = Me.lkup_FETCIS
        Me.GridColumn10.FieldName = "FETCIS_CDF_COIN_CODE_FK_PK"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 0
        '
        'lkup_FETCIS
        '
        Me.lkup_FETCIS.AutoHeight = False
        Me.lkup_FETCIS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FETCIS.Name = "lkup_FETCIS"
        '
        'GC31
        '
        Me.GC31.DataMember = "FETIS_ETIOLOGIE_INCONST_SENSIB"
        Me.GC31.Dock = System.Windows.Forms.DockStyle.Top
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
        Me.GC31.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FETIS})
        Me.GC31.Size = New System.Drawing.Size(493, 114)
        Me.GC31.TabIndex = 9
        Me.GC31.Tag = "[EDIT][ADD]"
        Me.GC31.UseEmbeddedNavigator = True
        Me.GC31.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV31})
        '
        'GV31
        '
        Me.GV31.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFETIS_FET_CODE_FK_PK, Me.colFETIS_CDF_ETIN_CODE_FK_PK, Me.colFETIS_POURCENTAGE_RESISTANCE, Me.colFETIS_CDF_ETIN_CODE_FK_PK2})
        Me.GV31.GridControl = Me.GC31
        Me.GV31.Name = "GV31"
        Me.GV31.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV31.OptionsView.ShowGroupPanel = False
        '
        'colFETIS_FET_CODE_FK_PK
        '
        Me.colFETIS_FET_CODE_FK_PK.Caption = "FETIS_FET_CODE_FK_PK"
        Me.colFETIS_FET_CODE_FK_PK.FieldName = "FETIS_FET_CODE_FK_PK"
        Me.colFETIS_FET_CODE_FK_PK.Name = "colFETIS_FET_CODE_FK_PK"
        '
        'colFETIS_CDF_ETIN_CODE_FK_PK
        '
        Me.colFETIS_CDF_ETIN_CODE_FK_PK.Caption = "Code"
        Me.colFETIS_CDF_ETIN_CODE_FK_PK.FieldName = "FETIS_CDF_ETIN_CODE_FK_PK"
        Me.colFETIS_CDF_ETIN_CODE_FK_PK.Name = "colFETIS_CDF_ETIN_CODE_FK_PK"
        Me.colFETIS_CDF_ETIN_CODE_FK_PK.Visible = True
        Me.colFETIS_CDF_ETIN_CODE_FK_PK.VisibleIndex = 0
        Me.colFETIS_CDF_ETIN_CODE_FK_PK.Width = 50
        '
        'colFETIS_POURCENTAGE_RESISTANCE
        '
        Me.colFETIS_POURCENTAGE_RESISTANCE.Caption = "% Resist"
        Me.colFETIS_POURCENTAGE_RESISTANCE.FieldName = "FETIS_POURCENTAGE_RESISTANCE"
        Me.colFETIS_POURCENTAGE_RESISTANCE.Name = "colFETIS_POURCENTAGE_RESISTANCE"
        Me.colFETIS_POURCENTAGE_RESISTANCE.Visible = True
        Me.colFETIS_POURCENTAGE_RESISTANCE.VisibleIndex = 2
        '
        'colFETIS_CDF_ETIN_CODE_FK_PK2
        '
        Me.colFETIS_CDF_ETIN_CODE_FK_PK2.Caption = "Agent / Etiologie"
        Me.colFETIS_CDF_ETIN_CODE_FK_PK2.ColumnEdit = Me.lkup_FETIS
        Me.colFETIS_CDF_ETIN_CODE_FK_PK2.FieldName = "FETIS_CDF_ETIN_CODE_FK_PK"
        Me.colFETIS_CDF_ETIN_CODE_FK_PK2.Name = "colFETIS_CDF_ETIN_CODE_FK_PK2"
        Me.colFETIS_CDF_ETIN_CODE_FK_PK2.Visible = True
        Me.colFETIS_CDF_ETIN_CODE_FK_PK2.VisibleIndex = 1
        Me.colFETIS_CDF_ETIN_CODE_FK_PK2.Width = 498
        '
        'lkup_FETIS
        '
        Me.lkup_FETIS.AutoHeight = False
        Me.lkup_FETIS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FETIS.Name = "lkup_FETIS"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.Panel6)
        Me.XtraTabPage4.Controls.Add(Me.Panel17)
        Me.XtraTabPage4.Controls.Add(Me.GC42)
        Me.XtraTabPage4.Controls.Add(Me.GC41)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(493, 391)
        Me.XtraTabPage4.Tag = "[EDIT][ADD]"
        Me.XtraTabPage4.Text = "Esp modérement sensibles"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel15)
        Me.Panel6.Controls.Add(Me.Panel16)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 275)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(493, 116)
        Me.Panel6.TabIndex = 40
        Me.Panel6.Tag = ""
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.GC43)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel15.Location = New System.Drawing.Point(0, 24)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(493, 92)
        Me.Panel15.TabIndex = 38
        Me.Panel15.Tag = "[ADD][EDIT]"
        '
        'GC43
        '
        Me.GC43.DataMember = "FETTX3_ET_TXMS"
        Me.GC43.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC43.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC43.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC43.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC43.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC43.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC43.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC43.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC43.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC43.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC43.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC43.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC43.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC43.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC43.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC43.EmbeddedNavigator.Name = ""
        Me.GC43.EmbeddedNavigator.TextStringFormat = ""
        Me.GC43.Location = New System.Drawing.Point(0, 0)
        Me.GC43.MainView = Me.GV43
        Me.GC43.Name = "GC43"
        Me.GC43.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rm_Memo3})
        Me.GC43.Size = New System.Drawing.Size(493, 92)
        Me.GC43.TabIndex = 5
        Me.GC43.UseEmbeddedNavigator = True
        Me.GC43.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV43})
        '
        'GV43
        '
        Me.GV43.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFETTX3_FET_CODE_FK_PK, Me.colFETTX3_TEXTE})
        Me.GV43.GridControl = Me.GC43
        Me.GV43.GroupFormat = ""
        Me.GV43.GroupPanelText = " "
        Me.GV43.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GV43.Name = "GV43"
        Me.GV43.OptionsCustomization.AllowRowSizing = True
        Me.GV43.OptionsNavigation.AutoFocusNewRow = True
        Me.GV43.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV43.OptionsView.ShowColumnHeaders = False
        Me.GV43.OptionsView.ShowDetailButtons = False
        Me.GV43.OptionsView.ShowGroupPanel = False
        Me.GV43.OptionsView.ShowHorzLines = False
        Me.GV43.OptionsView.ShowIndicator = False
        Me.GV43.RowHeight = 75
        Me.GV43.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colFETTX3_FET_CODE_FK_PK
        '
        Me.colFETTX3_FET_CODE_FK_PK.Caption = "FETTX3_FET_CODE_FK_PK"
        Me.colFETTX3_FET_CODE_FK_PK.FieldName = "FETTX3_FET_CODE_FK_PK"
        Me.colFETTX3_FET_CODE_FK_PK.Name = "colFETTX3_FET_CODE_FK_PK"
        '
        'colFETTX3_TEXTE
        '
        Me.colFETTX3_TEXTE.Caption = "FETTX3_TEXTE"
        Me.colFETTX3_TEXTE.ColumnEdit = Me.rm_Memo3
        Me.colFETTX3_TEXTE.FieldName = "FETTX3_TEXTE"
        Me.colFETTX3_TEXTE.Name = "colFETTX3_TEXTE"
        Me.colFETTX3_TEXTE.Visible = True
        Me.colFETTX3_TEXTE.VisibleIndex = 0
        '
        'rm_Memo3
        '
        Me.rm_Memo3.Name = "rm_Memo3"
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.LabelControl11)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel16.Location = New System.Drawing.Point(0, 0)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(493, 24)
        Me.Panel16.TabIndex = 37
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(2, 8)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl11.TabIndex = 19
        Me.LabelControl11.Text = "Texte"
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.LookUp_FETCMS)
        Me.Panel17.Controls.Add(Me.TextEdit4)
        Me.Panel17.Controls.Add(Me.LabelControl10)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel17.Location = New System.Drawing.Point(0, 240)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(493, 35)
        Me.Panel17.TabIndex = 41
        '
        'LookUp_FETCMS
        '
        Me.LookUp_FETCMS.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Etiologie, "FET_FICHEETIOLOGIE.FET_CDF_UDMS_CODE_FK", True))
        Me.LookUp_FETCMS.Location = New System.Drawing.Point(85, 7)
        Me.LookUp_FETCMS.Name = "LookUp_FETCMS"
        Me.LookUp_FETCMS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUp_FETCMS.Size = New System.Drawing.Size(148, 20)
        Me.LookUp_FETCMS.TabIndex = 16
        Me.LookUp_FETCMS.Tag = ""
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Etiologie, "FET_FICHEETIOLOGIE.FET_CMIMS", True))
        Me.TextEdit4.Location = New System.Drawing.Point(33, 7)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Size = New System.Drawing.Size(46, 20)
        Me.TextEdit4.TabIndex = 14
        Me.TextEdit4.Tag = "[EDIT][ADD]"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(3, 11)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl10.TabIndex = 15
        Me.LabelControl10.Text = "CMI"
        '
        'GC42
        '
        Me.GC42.DataMember = "FETCMS_COMMENT_MODERE_SENSIBLE"
        Me.GC42.Dock = System.Windows.Forms.DockStyle.Top
        Me.GC42.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC42.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC42.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC42.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC42.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC42.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC42.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC42.EmbeddedNavigator.Name = ""
        Me.GC42.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC42.Location = New System.Drawing.Point(0, 114)
        Me.GC42.MainView = Me.GV42
        Me.GC42.Name = "GC42"
        Me.GC42.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FETCMS})
        Me.GC42.Size = New System.Drawing.Size(493, 126)
        Me.GC42.TabIndex = 11
        Me.GC42.Tag = "[EDIT][ADD]"
        Me.GC42.UseEmbeddedNavigator = True
        Me.GC42.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV42})
        '
        'GV42
        '
        Me.GV42.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFETCMS_FET_CODE_FK_PK, Me.colFETCMS_CDF_COIN_CODE_FK_PK, Me.GridColumn21})
        Me.GV42.GridControl = Me.GC42
        Me.GV42.Name = "GV42"
        Me.GV42.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV42.OptionsView.ShowGroupPanel = False
        '
        'colFETCMS_FET_CODE_FK_PK
        '
        Me.colFETCMS_FET_CODE_FK_PK.Caption = "FETCMS_FET_CODE_FK_PK"
        Me.colFETCMS_FET_CODE_FK_PK.FieldName = "FETCMS_FET_CODE_FK_PK"
        Me.colFETCMS_FET_CODE_FK_PK.Name = "colFETCMS_FET_CODE_FK_PK"
        '
        'colFETCMS_CDF_COIN_CODE_FK_PK
        '
        Me.colFETCMS_CDF_COIN_CODE_FK_PK.Caption = "FETCMS_CDF_COIN_CODE_FK_PK"
        Me.colFETCMS_CDF_COIN_CODE_FK_PK.FieldName = "FETCMS_CDF_COIN_CODE_FK_PK"
        Me.colFETCMS_CDF_COIN_CODE_FK_PK.Name = "colFETCMS_CDF_COIN_CODE_FK_PK"
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Commentaires"
        Me.GridColumn21.ColumnEdit = Me.lkup_FETCMS
        Me.GridColumn21.FieldName = "FETCMS_CDF_COIN_CODE_FK_PK"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 0
        '
        'lkup_FETCMS
        '
        Me.lkup_FETCMS.AutoHeight = False
        Me.lkup_FETCMS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FETCMS.Name = "lkup_FETCMS"
        '
        'GC41
        '
        Me.GC41.DataMember = "FETMS_ETIOLOGIE_MODEREM_SENSIB"
        Me.GC41.Dock = System.Windows.Forms.DockStyle.Top
        Me.GC41.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC41.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC41.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC41.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC41.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC41.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC41.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC41.EmbeddedNavigator.Name = ""
        Me.GC41.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC41.Location = New System.Drawing.Point(0, 0)
        Me.GC41.MainView = Me.GV41
        Me.GC41.Name = "GC41"
        Me.GC41.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FETMS})
        Me.GC41.Size = New System.Drawing.Size(493, 114)
        Me.GC41.TabIndex = 10
        Me.GC41.Tag = "[EDIT][ADD]"
        Me.GC41.UseEmbeddedNavigator = True
        Me.GC41.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV41})
        '
        'GV41
        '
        Me.GV41.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFETMS_FET_CODE_FK_PK, Me.colFETMS_CDF_ETIN_CODE_FK_PK, Me.colFETMS_POURCENTAGE_RESISTANCE, Me.colFETMS_CDF_ETIN_CODE_FK_PK2})
        Me.GV41.GridControl = Me.GC41
        Me.GV41.Name = "GV41"
        Me.GV41.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV41.OptionsView.ShowGroupPanel = False
        '
        'colFETMS_FET_CODE_FK_PK
        '
        Me.colFETMS_FET_CODE_FK_PK.Caption = "FETMS_FET_CODE_FK_PK"
        Me.colFETMS_FET_CODE_FK_PK.FieldName = "FETMS_FET_CODE_FK_PK"
        Me.colFETMS_FET_CODE_FK_PK.Name = "colFETMS_FET_CODE_FK_PK"
        '
        'colFETMS_CDF_ETIN_CODE_FK_PK
        '
        Me.colFETMS_CDF_ETIN_CODE_FK_PK.Caption = "Code"
        Me.colFETMS_CDF_ETIN_CODE_FK_PK.FieldName = "FETMS_CDF_ETIN_CODE_FK_PK"
        Me.colFETMS_CDF_ETIN_CODE_FK_PK.Name = "colFETMS_CDF_ETIN_CODE_FK_PK"
        Me.colFETMS_CDF_ETIN_CODE_FK_PK.Visible = True
        Me.colFETMS_CDF_ETIN_CODE_FK_PK.VisibleIndex = 0
        Me.colFETMS_CDF_ETIN_CODE_FK_PK.Width = 50
        '
        'colFETMS_POURCENTAGE_RESISTANCE
        '
        Me.colFETMS_POURCENTAGE_RESISTANCE.Caption = "% Resist"
        Me.colFETMS_POURCENTAGE_RESISTANCE.FieldName = "FETMS_POURCENTAGE_RESISTANCE"
        Me.colFETMS_POURCENTAGE_RESISTANCE.Name = "colFETMS_POURCENTAGE_RESISTANCE"
        Me.colFETMS_POURCENTAGE_RESISTANCE.Visible = True
        Me.colFETMS_POURCENTAGE_RESISTANCE.VisibleIndex = 2
        '
        'colFETMS_CDF_ETIN_CODE_FK_PK2
        '
        Me.colFETMS_CDF_ETIN_CODE_FK_PK2.Caption = "Agent / Etiologie"
        Me.colFETMS_CDF_ETIN_CODE_FK_PK2.ColumnEdit = Me.lkup_FETMS
        Me.colFETMS_CDF_ETIN_CODE_FK_PK2.FieldName = "FETMS_CDF_ETIN_CODE_FK_PK"
        Me.colFETMS_CDF_ETIN_CODE_FK_PK2.Name = "colFETMS_CDF_ETIN_CODE_FK_PK2"
        Me.colFETMS_CDF_ETIN_CODE_FK_PK2.Visible = True
        Me.colFETMS_CDF_ETIN_CODE_FK_PK2.VisibleIndex = 1
        Me.colFETMS_CDF_ETIN_CODE_FK_PK2.Width = 498
        '
        'lkup_FETMS
        '
        Me.lkup_FETMS.AutoHeight = False
        Me.lkup_FETMS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FETMS.Name = "lkup_FETMS"
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.Panel7)
        Me.XtraTabPage5.Controls.Add(Me.Panel18)
        Me.XtraTabPage5.Controls.Add(Me.GC52)
        Me.XtraTabPage5.Controls.Add(Me.GC51)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(493, 391)
        Me.XtraTabPage5.Tag = "[EDIT][ADD]"
        Me.XtraTabPage5.Text = "Esp résistantes"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Panel19)
        Me.Panel7.Controls.Add(Me.Panel20)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 274)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(493, 117)
        Me.Panel7.TabIndex = 41
        Me.Panel7.Tag = ""
        '
        'Panel19
        '
        Me.Panel19.Controls.Add(Me.GC53)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel19.Location = New System.Drawing.Point(0, 24)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(493, 93)
        Me.Panel19.TabIndex = 38
        Me.Panel19.Tag = "[ADD][EDIT]"
        '
        'GC53
        '
        Me.GC53.DataMember = "FETTX4_ET_TXRE"
        Me.GC53.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC53.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC53.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC53.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC53.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC53.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC53.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC53.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC53.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC53.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC53.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC53.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC53.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC53.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC53.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC53.EmbeddedNavigator.Name = ""
        Me.GC53.EmbeddedNavigator.TextStringFormat = ""
        Me.GC53.Location = New System.Drawing.Point(0, 0)
        Me.GC53.MainView = Me.GV53
        Me.GC53.Name = "GC53"
        Me.GC53.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rm_Memo4})
        Me.GC53.Size = New System.Drawing.Size(493, 93)
        Me.GC53.TabIndex = 6
        Me.GC53.UseEmbeddedNavigator = True
        Me.GC53.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV53})
        '
        'GV53
        '
        Me.GV53.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFETTX4_FET_CODE_FK_PK, Me.colFETTX4_TEXTE})
        Me.GV53.GridControl = Me.GC53
        Me.GV53.GroupFormat = ""
        Me.GV53.GroupPanelText = " "
        Me.GV53.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GV53.Name = "GV53"
        Me.GV53.OptionsCustomization.AllowRowSizing = True
        Me.GV53.OptionsNavigation.AutoFocusNewRow = True
        Me.GV53.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV53.OptionsView.ShowColumnHeaders = False
        Me.GV53.OptionsView.ShowDetailButtons = False
        Me.GV53.OptionsView.ShowGroupPanel = False
        Me.GV53.OptionsView.ShowHorzLines = False
        Me.GV53.OptionsView.ShowIndicator = False
        Me.GV53.RowHeight = 77
        Me.GV53.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colFETTX4_FET_CODE_FK_PK
        '
        Me.colFETTX4_FET_CODE_FK_PK.Caption = "FETTX4_FET_CODE_FK_PK"
        Me.colFETTX4_FET_CODE_FK_PK.FieldName = "FETTX4_FET_CODE_FK_PK"
        Me.colFETTX4_FET_CODE_FK_PK.Name = "colFETTX4_FET_CODE_FK_PK"
        '
        'colFETTX4_TEXTE
        '
        Me.colFETTX4_TEXTE.Caption = "FETTX4_TEXTE"
        Me.colFETTX4_TEXTE.ColumnEdit = Me.rm_Memo4
        Me.colFETTX4_TEXTE.FieldName = "FETTX4_TEXTE"
        Me.colFETTX4_TEXTE.Name = "colFETTX4_TEXTE"
        Me.colFETTX4_TEXTE.Visible = True
        Me.colFETTX4_TEXTE.VisibleIndex = 0
        '
        'rm_Memo4
        '
        Me.rm_Memo4.Name = "rm_Memo4"
        '
        'Panel20
        '
        Me.Panel20.Controls.Add(Me.LabelControl13)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel20.Location = New System.Drawing.Point(0, 0)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(493, 24)
        Me.Panel20.TabIndex = 37
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(2, 8)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl13.TabIndex = 19
        Me.LabelControl13.Text = "Texte"
        '
        'Panel18
        '
        Me.Panel18.Controls.Add(Me.LookUp_FETRE)
        Me.Panel18.Controls.Add(Me.TextEdit5)
        Me.Panel18.Controls.Add(Me.LabelControl12)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel18.Location = New System.Drawing.Point(0, 240)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(493, 34)
        Me.Panel18.TabIndex = 40
        '
        'LookUp_FETRE
        '
        Me.LookUp_FETRE.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Etiologie, "FET_FICHEETIOLOGIE.FET_CDF_UDRE_CODE_FK", True))
        Me.LookUp_FETRE.Location = New System.Drawing.Point(90, 6)
        Me.LookUp_FETRE.Name = "LookUp_FETRE"
        Me.LookUp_FETRE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUp_FETRE.Size = New System.Drawing.Size(148, 20)
        Me.LookUp_FETRE.TabIndex = 19
        Me.LookUp_FETRE.Tag = ""
        '
        'TextEdit5
        '
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Etiologie, "FET_FICHEETIOLOGIE.FET_CMIRE", True))
        Me.TextEdit5.Location = New System.Drawing.Point(38, 6)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Size = New System.Drawing.Size(46, 20)
        Me.TextEdit5.TabIndex = 17
        Me.TextEdit5.Tag = "[EDIT][ADD]"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(3, 10)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl12.TabIndex = 18
        Me.LabelControl12.Text = "CMI >"
        '
        'GC52
        '
        Me.GC52.DataMember = "FETCRE_COMMENT_RESISTANTE"
        Me.GC52.Dock = System.Windows.Forms.DockStyle.Top
        Me.GC52.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC52.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC52.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC52.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC52.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC52.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC52.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC52.EmbeddedNavigator.Name = ""
        Me.GC52.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC52.Location = New System.Drawing.Point(0, 114)
        Me.GC52.MainView = Me.GV52
        Me.GC52.Name = "GC52"
        Me.GC52.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FETCRE})
        Me.GC52.Size = New System.Drawing.Size(493, 126)
        Me.GC52.TabIndex = 12
        Me.GC52.Tag = "[EDIT][ADD]"
        Me.GC52.UseEmbeddedNavigator = True
        Me.GC52.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV52})
        '
        'GV52
        '
        Me.GV52.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFETCRE_FET_CODE_FK_PK, Me.colFETCRE_CDF_COIN_CODE_FK_PK, Me.GridColumn23})
        Me.GV52.GridControl = Me.GC52
        Me.GV52.Name = "GV52"
        Me.GV52.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV52.OptionsView.ShowGroupPanel = False
        '
        'colFETCRE_FET_CODE_FK_PK
        '
        Me.colFETCRE_FET_CODE_FK_PK.Caption = "FETCRE_FET_CODE_FK_PK"
        Me.colFETCRE_FET_CODE_FK_PK.FieldName = "FETCRE_FET_CODE_FK_PK"
        Me.colFETCRE_FET_CODE_FK_PK.Name = "colFETCRE_FET_CODE_FK_PK"
        '
        'colFETCRE_CDF_COIN_CODE_FK_PK
        '
        Me.colFETCRE_CDF_COIN_CODE_FK_PK.Caption = "FETCRE_CDF_COIN_CODE_FK_PK"
        Me.colFETCRE_CDF_COIN_CODE_FK_PK.FieldName = "FETCRE_CDF_COIN_CODE_FK_PK"
        Me.colFETCRE_CDF_COIN_CODE_FK_PK.Name = "colFETCRE_CDF_COIN_CODE_FK_PK"
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "Commentaires"
        Me.GridColumn23.ColumnEdit = Me.lkup_FETCRE
        Me.GridColumn23.FieldName = "FETCRE_CDF_COIN_CODE_FK_PK"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 0
        '
        'lkup_FETCRE
        '
        Me.lkup_FETCRE.AutoHeight = False
        Me.lkup_FETCRE.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FETCRE.Name = "lkup_FETCRE"
        '
        'GC51
        '
        Me.GC51.DataMember = "FETRE_ETIOLOGIE_RESISTANTES"
        Me.GC51.Dock = System.Windows.Forms.DockStyle.Top
        Me.GC51.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC51.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC51.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC51.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC51.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC51.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC51.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC51.EmbeddedNavigator.Name = ""
        Me.GC51.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC51.Location = New System.Drawing.Point(0, 0)
        Me.GC51.MainView = Me.GV51
        Me.GC51.Name = "GC51"
        Me.GC51.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FETRE})
        Me.GC51.Size = New System.Drawing.Size(493, 114)
        Me.GC51.TabIndex = 11
        Me.GC51.Tag = "[EDIT][ADD]"
        Me.GC51.UseEmbeddedNavigator = True
        Me.GC51.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV51})
        '
        'GV51
        '
        Me.GV51.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFETRE_FET_CODE_FK_PK, Me.colFETRE_CDF_ETIN_CODE_FK_PK, Me.colFETRE_POURCENTAGE_RESISTANCE, Me.GridColumn22})
        Me.GV51.GridControl = Me.GC51
        Me.GV51.Name = "GV51"
        Me.GV51.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV51.OptionsView.ShowGroupPanel = False
        '
        'colFETRE_FET_CODE_FK_PK
        '
        Me.colFETRE_FET_CODE_FK_PK.Caption = "FETRE_FET_CODE_FK_PK"
        Me.colFETRE_FET_CODE_FK_PK.FieldName = "FETRE_FET_CODE_FK_PK"
        Me.colFETRE_FET_CODE_FK_PK.Name = "colFETRE_FET_CODE_FK_PK"
        '
        'colFETRE_CDF_ETIN_CODE_FK_PK
        '
        Me.colFETRE_CDF_ETIN_CODE_FK_PK.Caption = "Code"
        Me.colFETRE_CDF_ETIN_CODE_FK_PK.FieldName = "FETRE_CDF_ETIN_CODE_FK_PK"
        Me.colFETRE_CDF_ETIN_CODE_FK_PK.Name = "colFETRE_CDF_ETIN_CODE_FK_PK"
        Me.colFETRE_CDF_ETIN_CODE_FK_PK.Visible = True
        Me.colFETRE_CDF_ETIN_CODE_FK_PK.VisibleIndex = 0
        Me.colFETRE_CDF_ETIN_CODE_FK_PK.Width = 50
        '
        'colFETRE_POURCENTAGE_RESISTANCE
        '
        Me.colFETRE_POURCENTAGE_RESISTANCE.Caption = "% Resist"
        Me.colFETRE_POURCENTAGE_RESISTANCE.FieldName = "FETRE_POURCENTAGE_RESISTANCE"
        Me.colFETRE_POURCENTAGE_RESISTANCE.Name = "colFETRE_POURCENTAGE_RESISTANCE"
        Me.colFETRE_POURCENTAGE_RESISTANCE.Visible = True
        Me.colFETRE_POURCENTAGE_RESISTANCE.VisibleIndex = 2
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Agent / Etiologie"
        Me.GridColumn22.ColumnEdit = Me.lkup_FETRE
        Me.GridColumn22.FieldName = "FETRE_CDF_ETIN_CODE_FK_PK"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 1
        Me.GridColumn22.Width = 498
        '
        'lkup_FETRE
        '
        Me.lkup_FETRE.AutoHeight = False
        Me.lkup_FETRE.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FETRE.Name = "lkup_FETRE"
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Controls.Add(Me.GC)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(493, 391)
        Me.XtraTabPage6.Tag = "[EDIT][ADD]"
        Me.XtraTabPage6.Text = "Réf.off"
        '
        'GC
        '
        Me.GC.DataMember = "FETAFS_FET_AFSSAPS"
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC.EmbeddedNavigator.Name = ""
        Me.GC.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC.Location = New System.Drawing.Point(0, 0)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FETAFS, Me.lkup_SPAFS})
        Me.GC.Size = New System.Drawing.Size(493, 391)
        Me.GC.TabIndex = 11
        Me.GC.Tag = "[EDIT][ADD]"
        Me.GC.UseEmbeddedNavigator = True
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFETAFS_FET_CODE_FK_PK, Me.colFETAFS_DATE_PK, Me.colFETAFS_CDF_DOCUMENT_FK_PK, Me.colFETAFS_SP_CODE_FK_PK})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'colFETAFS_FET_CODE_FK_PK
        '
        Me.colFETAFS_FET_CODE_FK_PK.Caption = "FETAFS_FET_CODE_FK_PK"
        Me.colFETAFS_FET_CODE_FK_PK.FieldName = "FETAFS_FET_CODE_FK_PK"
        Me.colFETAFS_FET_CODE_FK_PK.Name = "colFETAFS_FET_CODE_FK_PK"
        '
        'colFETAFS_DATE_PK
        '
        Me.colFETAFS_DATE_PK.Caption = "Date"
        Me.colFETAFS_DATE_PK.FieldName = "FETAFS_DATE_PK"
        Me.colFETAFS_DATE_PK.Name = "colFETAFS_DATE_PK"
        Me.colFETAFS_DATE_PK.Visible = True
        Me.colFETAFS_DATE_PK.VisibleIndex = 1
        Me.colFETAFS_DATE_PK.Width = 68
        '
        'colFETAFS_CDF_DOCUMENT_FK_PK
        '
        Me.colFETAFS_CDF_DOCUMENT_FK_PK.Caption = "Références officielles"
        Me.colFETAFS_CDF_DOCUMENT_FK_PK.ColumnEdit = Me.lkup_FETAFS
        Me.colFETAFS_CDF_DOCUMENT_FK_PK.FieldName = "FETAFS_CDF_DOCUMENT_FK_PK"
        Me.colFETAFS_CDF_DOCUMENT_FK_PK.Name = "colFETAFS_CDF_DOCUMENT_FK_PK"
        Me.colFETAFS_CDF_DOCUMENT_FK_PK.Visible = True
        Me.colFETAFS_CDF_DOCUMENT_FK_PK.VisibleIndex = 0
        Me.colFETAFS_CDF_DOCUMENT_FK_PK.Width = 184
        '
        'lkup_FETAFS
        '
        Me.lkup_FETAFS.AutoHeight = False
        Me.lkup_FETAFS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FETAFS.Name = "lkup_FETAFS"
        '
        'colFETAFS_SP_CODE_FK_PK
        '
        Me.colFETAFS_SP_CODE_FK_PK.Caption = "Spécialité"
        Me.colFETAFS_SP_CODE_FK_PK.ColumnEdit = Me.lkup_SPAFS
        Me.colFETAFS_SP_CODE_FK_PK.FieldName = "FETAFS_SP_CODE_FK_PK"
        Me.colFETAFS_SP_CODE_FK_PK.Name = "colFETAFS_SP_CODE_FK_PK"
        Me.colFETAFS_SP_CODE_FK_PK.Visible = True
        Me.colFETAFS_SP_CODE_FK_PK.VisibleIndex = 2
        Me.colFETAFS_SP_CODE_FK_PK.Width = 233
        '
        'lkup_SPAFS
        '
        Me.lkup_SPAFS.AutoHeight = False
        Me.lkup_SPAFS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_SPAFS.Name = "lkup_SPAFS"
        Me.lkup_SPAFS.NullText = ""
        '
        'FetcpH_TA
        '
        Me.FetcpH_TA.ClearBeforeFill = True
        '
        'FetccH_TA
        '
        Me.FetccH_TA.ClearBeforeFill = True
        '
        'FetsaC_TA
        '
        Me.FetsaC_TA.ClearBeforeFill = True
        '
        'FetpR_TA
        '
        Me.FetpR_TA.ClearBeforeFill = True
        '
        'FetsP_TA
        '
        Me.FetsP_TA.ClearBeforeFill = True
        '
        'FettxtI_TA
        '
        Me.FettxtI_TA.ClearBeforeFill = True
        '
        'FethS_TA
        '
        Me.FethS_TA.ClearBeforeFill = True
        '
        'FetchS_Ta
        '
        Me.FetchS_Ta.ClearBeforeFill = True
        '
        'FettX1_TA
        '
        Me.FettX1_TA.ClearBeforeFill = True
        '
        'FetiS_TA
        '
        Me.FetiS_TA.ClearBeforeFill = True
        '
        'FetciS_Ta
        '
        Me.FetciS_Ta.ClearBeforeFill = True
        '
        'FettX2_TA
        '
        Me.FettX2_TA.ClearBeforeFill = True
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(1, 290)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl8.TabIndex = 23
        Me.LabelControl8.Text = "Texte"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "FETTX2_ET_TXIS"
        Me.GridControl1.DataSource = Me.DsTheriaque_Etiologie
        Me.GridControl1.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GridControl1.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GridControl1.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GridControl1.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.EmbeddedNavigator.TextStringFormat = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 309)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(646, 90)
        Me.GridControl1.TabIndex = 22
        Me.GridControl1.Tag = "[EDIT][ADD]"
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn11, Me.GridColumn12})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = ""
        Me.GridView1.GroupPanelText = " "
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowRowSizing = True
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowColumnHeaders = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowHorzLines = False
        Me.GridView1.OptionsView.ShowIndicator = False
        Me.GridView1.RowHeight = 36
        Me.GridView1.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "FETTX2_FET_CODE_FK_PK"
        Me.GridColumn11.FieldName = "FETTX2_FET_CODE_FK_PK"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "FETTX2_TEXTE"
        Me.GridColumn12.FieldName = "FETTX2_TEXTE"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 0
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.Location = New System.Drawing.Point(91, 265)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Size = New System.Drawing.Size(55, 20)
        Me.LookUpEdit1.TabIndex = 13
        Me.LookUpEdit1.Tag = "[EDIT][ADD]"
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Etiologie, "FET_FICHEETIOLOGIE.FET_CMIIS", True))
        Me.TextEdit3.Location = New System.Drawing.Point(39, 265)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(46, 20)
        Me.TextEdit3.TabIndex = 11
        Me.TextEdit3.Tag = "[EDIT][ADD]"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(5, 269)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl9.TabIndex = 12
        Me.LabelControl9.Text = "CMI"
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "FETCIS_COMMENT_INCONS_SENSIBLE"
        Me.GridControl2.DataSource = Me.DsTheriaque_Etiologie
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridControl2.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridControl2.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GridControl2.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GridControl2.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GridControl2.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GridControl2.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GridControl2.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GridControl2.Location = New System.Drawing.Point(0, 114)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.GridControl2.Size = New System.Drawing.Size(646, 126)
        Me.GridControl2.TabIndex = 10
        Me.GridControl2.Tag = "[EDIT][ADD]"
        Me.GridControl2.UseEmbeddedNavigator = True
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn13, Me.GridColumn14, Me.GridColumn15})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "FETCIS_FET_CODE_FK_PK"
        Me.GridColumn13.FieldName = "FETCIS_FET_CODE_FK_PK"
        Me.GridColumn13.Name = "GridColumn13"
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "FETCIS_CDF_COIN_CODE_FK_PK"
        Me.GridColumn14.FieldName = "FETCIS_CDF_COIN_CODE_FK_PK"
        Me.GridColumn14.Name = "GridColumn14"
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Commentaire"
        Me.GridColumn15.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.GridColumn15.FieldName = "FETCIS_CDF_COIN_CODE_FK_PK"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 0
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'GridControl3
        '
        Me.GridControl3.DataMember = "FETIS_ETIOLOGIE_INCONST_SENSIB"
        Me.GridControl3.DataSource = Me.DsTheriaque_Etiologie
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridControl3.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridControl3.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GridControl3.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GridControl3.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GridControl3.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GridControl3.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GridControl3.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GridControl3.EmbeddedNavigator.Name = ""
        Me.GridControl3.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GridControl3.Location = New System.Drawing.Point(0, 0)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2})
        Me.GridControl3.Size = New System.Drawing.Size(646, 114)
        Me.GridControl3.TabIndex = 9
        Me.GridControl3.Tag = "[EDIT][ADD]"
        Me.GridControl3.UseEmbeddedNavigator = True
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19})
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "FETIS_FET_CODE_FK_PK"
        Me.GridColumn16.FieldName = "FETIS_FET_CODE_FK_PK"
        Me.GridColumn16.Name = "GridColumn16"
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Code"
        Me.GridColumn17.FieldName = "FETIS_CDF_ETIN_CODE_FK_PK"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 0
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "% Resist"
        Me.GridColumn18.FieldName = "FETIS_POURCENTAGE_RESISTANCE"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 1
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Agent/Etiologie"
        Me.GridColumn19.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.GridColumn19.FieldName = "FETIS_CDF_ETIN_CODE_FK_PK"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 2
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        '
        'FetmS_TA
        '
        Me.FetmS_TA.ClearBeforeFill = True
        '
        'FetcmS_TA
        '
        Me.FetcmS_TA.ClearBeforeFill = True
        '
        'FettX3_TA
        '
        Me.FettX3_TA.ClearBeforeFill = True
        '
        'FetrE_TA
        '
        Me.FetrE_TA.ClearBeforeFill = True
        '
        'FetcrE_TA
        '
        Me.FetcrE_TA.ClearBeforeFill = True
        '
        'FettX4_TA
        '
        Me.FettX4_TA.ClearBeforeFill = True
        '
        'FetafS_TA
        '
        Me.FetafS_TA.ClearBeforeFill = True
        '
        'Frm_Etiologie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(780, 574)
        Me.Name = "Frm_Etiologie"
        Me.Text = "Etiologie"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_Etiologie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.GC16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FETSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GC13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FETSAC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FETPR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.GC11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FETCPH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FETCCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage1.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        CType(Me.GC23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_Memo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.LookUp_FET.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FETCHS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FETHS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        CType(Me.GC33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rm_Memo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.LookUp_FETCIS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FETCIS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FETIS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        CType(Me.GC43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rm_Memo3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        CType(Me.LookUp_FETCMS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FETCMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FETMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        CType(Me.GC53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rm_Memo4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel20.ResumeLayout(False)
        Me.Panel20.PerformLayout()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        CType(Me.LookUp_FETRE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FETCRE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FETRE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage6.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FETAFS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_SPAFS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FeT_TA As Theriaque.dsTheriaque_EtiologieTableAdapters.FET_FICHEETIOLOGIETableAdapter
    Friend WithEvents DsTheriaque_Etiologie As Theriaque.dsTheriaque_Etiologie
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GC15 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV15 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents FetcpH_TA As Theriaque.dsTheriaque_EtiologieTableAdapters.FETCPH_ETIOCPHTableAdapter
    Friend WithEvents colFETCPH_CPH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETCPH_FET_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETCPH_CPH_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FETCPH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFETCCH_CCH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETCCH_FET_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETCCH_CCH_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FETCCH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FetccH_TA As Theriaque.dsTheriaque_EtiologieTableAdapters.FETCCH_ETIOCCHTableAdapter
    Friend WithEvents FetsaC_TA As Theriaque.dsTheriaque_EtiologieTableAdapters.FETSAC_ETIOSUBACTableAdapter
    Friend WithEvents colFETSAC_SAC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETSAC_FET_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETSAC_SAC_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FETSAC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FetpR_TA As Theriaque.dsTheriaque_EtiologieTableAdapters.FETPR_ETIOPRODTableAdapter
    Friend WithEvents colFETPR_PR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETPR_FET_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETPR_PR_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FETPR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFETSP_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETSP_FET_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETSP_SP_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FETSP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FetsP_TA As Theriaque.dsTheriaque_EtiologieTableAdapters.FETSP_ETIOSPETableAdapter
    Friend WithEvents FettxtI_TA As Theriaque.dsTheriaque_EtiologieTableAdapters.FETTXTI_TEXTINTRO_CMITableAdapter
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GC21 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV21 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFETHS_FET_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETHS_CDF_ETIN_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETHS_POURCENTAGE_RESISTANCE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FETHS As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FethS_TA As Theriaque.dsTheriaque_EtiologieTableAdapters.FETHS_ETIOLOGIE_HABITU_SENSIBTableAdapter
    Friend WithEvents colFETHS_CDF_ETIN_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LookUp_FET As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents FetchS_Ta As Theriaque.dsTheriaque_EtiologieTableAdapters.FETCHS_COMMENT_HABITU_SENSIBLETableAdapter
    Friend WithEvents GC22 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV22 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFETCHS_FET_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETCHS_CDF_COIN_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FETCHS As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FettX1_TA As Theriaque.dsTheriaque_EtiologieTableAdapters.FETTX1_ET_TXHSTableAdapter
    Friend WithEvents GC32 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV32 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC31 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV31 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FetiS_TA As Theriaque.dsTheriaque_EtiologieTableAdapters.FETIS_ETIOLOGIE_INCONST_SENSIBTableAdapter
    Friend WithEvents colFETIS_FET_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETIS_CDF_ETIN_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETIS_POURCENTAGE_RESISTANCE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETIS_CDF_ETIN_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FETIS As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FetciS_Ta As Theriaque.dsTheriaque_EtiologieTableAdapters.FETCIS_COMMENT_INCONS_SENSIBLETableAdapter
    Friend WithEvents colFETCIS_FET_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETCIS_CDF_COIN_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FETCIS As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookUp_FETCIS As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents FettX2_TA As Theriaque.dsTheriaque_EtiologieTableAdapters.FETTX2_ET_TXISTableAdapter
    Friend WithEvents GC42 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV42 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC41 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV41 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFETMS_FET_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETMS_CDF_ETIN_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETMS_POURCENTAGE_RESISTANCE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETMS_CDF_ETIN_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FETMS As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FetmS_TA As Theriaque.dsTheriaque_EtiologieTableAdapters.FETMS_ETIOLOGIE_MODEREM_SENSIBTableAdapter
    Friend WithEvents FetcmS_TA As Theriaque.dsTheriaque_EtiologieTableAdapters.FETCMS_COMMENT_MODERE_SENSIBLETableAdapter
    Friend WithEvents colFETCMS_FET_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETCMS_CDF_COIN_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FETCMS As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookUp_FETCMS As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents FettX3_TA As Theriaque.dsTheriaque_EtiologieTableAdapters.FETTX3_ET_TXMSTableAdapter
    Friend WithEvents GC52 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV52 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC51 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV51 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFETRE_FET_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETRE_CDF_ETIN_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETRE_POURCENTAGE_RESISTANCE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FETRE As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FetrE_TA As Theriaque.dsTheriaque_EtiologieTableAdapters.FETRE_ETIOLOGIE_RESISTANTESTableAdapter
    Friend WithEvents FetcrE_TA As Theriaque.dsTheriaque_EtiologieTableAdapters.FETCRE_COMMENT_RESISTANTETableAdapter
    Friend WithEvents colFETCRE_FET_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETCRE_CDF_COIN_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FETCRE As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookUp_FETRE As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents FettX4_TA As Theriaque.dsTheriaque_EtiologieTableAdapters.FETTX4_ET_TXRETableAdapter
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFETAFS_FET_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETAFS_DATE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FetafS_TA As Theriaque.dsTheriaque_EtiologieTableAdapters.FETAFS_FET_AFSSAPSTableAdapter
    Friend WithEvents lkup_FETAFS As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFETAFS_CDF_DOCUMENT_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETAFS_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_SPAFS As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents GC23 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV23 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFETTX1_FET_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETTX1_TEXTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_Memo1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GC33 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV33 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFETTX2_FET_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETTX2_TEXTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rm_Memo2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GC43 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV43 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFETTX3_FET_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETTX3_TEXTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rm_Memo3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GC53 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV53 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFETTX4_FET_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETTX4_TEXTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rm_Memo4 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GC16 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV16 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colFETTXTI_FET_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFETTXTI_TXT_INTRO As DevExpress.XtraGrid.Columns.GridColumn

End Class
