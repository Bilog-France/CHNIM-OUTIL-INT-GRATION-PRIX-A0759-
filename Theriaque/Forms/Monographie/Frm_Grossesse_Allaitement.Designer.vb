<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Grossesse_Allaitement
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
        Me.FgA_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGA_FICHEGRALTableAdapter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.DsTheriaque_Grossesse_Allaitement = New Theriaque.dsTheriaque_Grossesse_Allaitement
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.GC5 = New DevExpress.XtraGrid.GridControl
        Me.GV5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGAPR_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGAPR_PR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FGAPR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC6 = New DevExpress.XtraGrid.GridControl
        Me.GV6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGASP_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGASP_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FGASP_FGA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.GC3 = New DevExpress.XtraGrid.GridControl
        Me.GV3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGASAC_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGASAC_SAC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FGASAC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC4 = New DevExpress.XtraGrid.GridControl
        Me.GV4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGASAU_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGASAU_SAU_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FGASAU = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.GC2 = New DevExpress.XtraGrid.GridControl
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGACCH_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGACCH_CCH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FGACCH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC1 = New DevExpress.XtraGrid.GridControl
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGACPH_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGACPH_CPH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FGACPH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.Panel27 = New System.Windows.Forms.Panel
        Me.GC13 = New DevExpress.XtraGrid.GridControl
        Me.GV13 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGATX1_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGATX1_TEXTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rm_Memo1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Panel28 = New System.Windows.Forms.Panel
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GC14 = New DevExpress.XtraGrid.GridControl
        Me.GV14 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGARIA_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGARIA_CDF_RI_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FGARIA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFGARIA_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GC12 = New DevExpress.XtraGrid.GridControl
        Me.GV12 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGACFA_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGACFA_CDF_CF_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FGACFA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFGACFA_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.GC11 = New DevExpress.XtraGrid.GridControl
        Me.GV11 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGAOA_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGAOA_CDF_OBS_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FGAOA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFGAOA_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.GC25 = New DevExpress.XtraGrid.GridControl
        Me.GV25 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGATX3_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGATX3_TEXTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rm_Memo2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.GC24 = New DevExpress.XtraGrid.GridControl
        Me.GV24 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGARIH_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGARIH_CDF_RI_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FGARIH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFGARIH_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.GC23 = New DevExpress.XtraGrid.GridControl
        Me.GV23 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGACFH_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGACFH_CDF_CF_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FGACFH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFGACFH_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.GC22 = New DevExpress.XtraGrid.GridControl
        Me.GV22 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGAOH_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGAOH_CDF_OBS_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FGAOH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFGAOH_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.GC21 = New DevExpress.XtraGrid.GridControl
        Me.GV21 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGAPC_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGAPC_CDF_PC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FGAPC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFGAPC_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage7 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel17 = New System.Windows.Forms.Panel
        Me.Panel18 = New System.Windows.Forms.Panel
        Me.GC32 = New DevExpress.XtraGrid.GridControl
        Me.GV32 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGATX7_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGATX7_TEXTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rm_Memo3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Panel19 = New System.Windows.Forms.Panel
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.GC31 = New DevExpress.XtraGrid.GridControl
        Me.GV31 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGARIG_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGARIG_NUMSEQ_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGARIG_CDF_RI_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FGARIG_CDF_RI = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFGARIG_CDF_TC_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FGARIG_CDF_TC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFGARIG_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel24 = New System.Windows.Forms.Panel
        Me.Panel26 = New System.Windows.Forms.Panel
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup
        Me.Panel25 = New System.Windows.Forms.Panel
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabPage8 = New DevExpress.XtraTab.XtraTabPage
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel33 = New System.Windows.Forms.Panel
        Me.GC45 = New DevExpress.XtraGrid.GridControl
        Me.GV45 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGAAFS_FGA_CODE_FK_PK1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGAAFS_SP_CODE_FK_PK1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FGAAFS1_SP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFGAAFS_DATE_PK1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGAAFS_TYPEGRAL_PK1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGAAFS_CDF_DOCUMENT_FK_PK1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FGAAFS1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel21 = New System.Windows.Forms.Panel
        Me.Panel22 = New System.Windows.Forms.Panel
        Me.GC42 = New DevExpress.XtraGrid.GridControl
        Me.GV42 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGATX4_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGATX4_TEXTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rm_Memo4 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Panel23 = New System.Windows.Forms.Panel
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.Panel20 = New System.Windows.Forms.Panel
        Me.GC41 = New DevExpress.XtraGrid.GridControl
        Me.GV41 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGACF_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGACF_CDF_CAT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FGACF = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFGACF_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel29 = New System.Windows.Forms.Panel
        Me.GC43 = New DevExpress.XtraGrid.GridControl
        Me.GV43 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGACN_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGACN_CDF_CAT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FGACN = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFGACN_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel30 = New System.Windows.Forms.Panel
        Me.Panel31 = New System.Windows.Forms.Panel
        Me.GC44 = New DevExpress.XtraGrid.GridControl
        Me.GV44 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGATX5_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGATX5_TEXTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rm_Memo5 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Panel32 = New System.Windows.Forms.Panel
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.Panel38 = New System.Windows.Forms.Panel
        Me.Panel39 = New System.Windows.Forms.Panel
        Me.GC54 = New DevExpress.XtraGrid.GridControl
        Me.GV54 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGATX10_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGATX10_TEXTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rm_Memo7 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Panel40 = New System.Windows.Forms.Panel
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.Panel41 = New System.Windows.Forms.Panel
        Me.GC53 = New DevExpress.XtraGrid.GridControl
        Me.GV53 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGACFAP_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGACFAP_CDF_CAT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FGACFAP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFGACFAP_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.Panel35 = New System.Windows.Forms.Panel
        Me.Panel36 = New System.Windows.Forms.Panel
        Me.GC52 = New DevExpress.XtraGrid.GridControl
        Me.GV52 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGATX9_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGATX9_TEXTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rm_Memo6 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Panel37 = New System.Windows.Forms.Panel
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.Panel34 = New System.Windows.Forms.Panel
        Me.GC51 = New DevExpress.XtraGrid.GridControl
        Me.GV51 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGARIFAP_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGARIFAP_CDF_RI_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FGARIFAP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFGARIFAP_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
        Me.XtraTabControl3 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage9 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.Panel43 = New System.Windows.Forms.Panel
        Me.Panel44 = New System.Windows.Forms.Panel
        Me.GC63 = New DevExpress.XtraGrid.GridControl
        Me.GV63 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGATX2_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGATX2_TEXTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rm_Memo8 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Panel45 = New System.Windows.Forms.Panel
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl
        Me.Panel42 = New System.Windows.Forms.Panel
        Me.GC61 = New DevExpress.XtraGrid.GridControl
        Me.GV61 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGAON_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGAON_CDF_OBS_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FGAON = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFGAON_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC62 = New DevExpress.XtraGrid.GridControl
        Me.GV62 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGACFN_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGACFN_CDF_CF_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FGACFN = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFGACFN_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.lkupFGA_CDF = New DevExpress.XtraEditors.LookUpEdit
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.ComboBoxEdit4 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.ComboBoxEdit3 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.ComboBoxEdit2 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabPage11 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel47 = New System.Windows.Forms.Panel
        Me.Panel48 = New System.Windows.Forms.Panel
        Me.GC72 = New DevExpress.XtraGrid.GridControl
        Me.GV72 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGATX8_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGATX8_TEXTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rm_Memo9 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Panel49 = New System.Windows.Forms.Panel
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl
        Me.Panel46 = New System.Windows.Forms.Panel
        Me.GC71 = New DevExpress.XtraGrid.GridControl
        Me.GV71 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGARIL_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGARIL_CDF_RI_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FGARIL = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFGARIL_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage12 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel55 = New System.Windows.Forms.Panel
        Me.Panel51 = New System.Windows.Forms.Panel
        Me.GC82 = New DevExpress.XtraGrid.GridControl
        Me.GV82 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGAAFS_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGAAFS_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FGAAFS_SP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFGAAFS_DATE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGAAFS_TYPEGRAL_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGAAFS_CDF_DOCUMENT_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FGAAFS = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel52 = New System.Windows.Forms.Panel
        Me.Panel53 = New System.Windows.Forms.Panel
        Me.GC83 = New DevExpress.XtraGrid.GridControl
        Me.GV83 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGATX6_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGATX6_TEXTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rm_Memo10 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Panel54 = New System.Windows.Forms.Panel
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl
        Me.Panel50 = New System.Windows.Forms.Panel
        Me.GC81 = New DevExpress.XtraGrid.GridControl
        Me.GV81 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFGACA_FGA_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFGACA_CDF_CAT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FGACA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFGACA_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FGAFICHEGRALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FgaccH_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGACCH_GRALCLCHTableAdapter
        Me.FgacpH_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGACPH_GRALCLPHTableAdapter
        Me.FgasaC_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGASAC_GRALSUBACTableAdapter
        Me.FgasaU_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGASAU_GRALSUBAUTableAdapter
        Me.FgapR_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGAPR_GRALPRODTableAdapter
        Me.FgasP_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGASP_GRALSPETableAdapter
        Me.FgacfA_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGACFA_CIRCONSTFAVORIS_ANIMALETableAdapter
        Me.FgaoA_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGAOA_OBSERVATION_ANIMALETableAdapter
        Me.FgariA_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGARIA_RISQUE_ANIMALETableAdapter
        Me.FgatX1_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGATX1_FGA_TXOBSERVANITableAdapter
        Me.FgacfH_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGACFH_CIRCONSTFAVORIS_HUMAINETableAdapter
        Me.FgaoH_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGAOH_OBSERVATION_HUMAINETableAdapter
        Me.FgapC_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGAPC_PERIODECRITIQUE_FGRALTableAdapter
        Me.FgariH_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGARIH_RISQUE_HUMAINETableAdapter
        Me.FgatX3_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGATX3_FGA_TXOBSERVHUMTableAdapter
        Me.FgariG_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGARIG_RISQUE_GROSSESSETableAdapter
        Me.FgatX7_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGATX7_FGA_TXRECOMMANDATTableAdapter
        Me.FgacF_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGACF_CATFEMMEENCEINTETableAdapter
        Me.FgacN_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGACN_CATNOUVEAUNETableAdapter
        Me.FgatX4_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGATX4_FGA_TXCONDATENIRCFTableAdapter
        Me.FgatX5_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGATX5_FGA_TXCONDATENIRCNTableAdapter
        Me.FgacfaP_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGACFAP_CATFEMMEENAGETableAdapter
        Me.FgarifaP_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGARIFAP_RISQUEFEMMEENAGETableAdapter
        Me.FgatX10_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGATX10_FGA_TXRECOMMANDATTableAdapter
        Me.FgatX9_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGATX9_FGA_TXRECOMMANDATTableAdapter
        Me.FgacfN_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGACFN_CIRCONSFAVORIS_NOUVEAUNTableAdapter
        Me.FgaoN_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGAON_OBSERVATION_NOUVEAUNETableAdapter
        Me.FgatX2_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGATX2_FGA_TXOBSERVNOUVNETableAdapter
        Me.FgariL_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGARIL_RISQUE_ALLAITEMENTTableAdapter
        Me.FgatX8_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGATX8_FGA_TXRECOMMANDATTableAdapter
        Me.FgaafS_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGAAFS_FGA_AFSSAPSTableAdapter
        Me.FgacA_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGACA_CATALLAITEMENTTableAdapter
        Me.FgatX6_TA = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGATX6_FGA_TXCONDATENIRCATableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_Grossesse_Allaitement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.GC5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FGAPR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FGASP_FGA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.GC3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FGASAC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FGASAU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FGACCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FGACPH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage5.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel27.SuspendLayout()
        CType(Me.GC13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rm_Memo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel28.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GC14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FGARIA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.GC12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FGACFA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.GC11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FGAOA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage6.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel14.SuspendLayout()
        CType(Me.GC25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rm_Memo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel15.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.GC24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FGARIH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        CType(Me.GC23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FGACFH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.GC22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FGAOH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.GC21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FGAPC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage7.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel18.SuspendLayout()
        CType(Me.GC32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rm_Memo3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel19.SuspendLayout()
        Me.Panel16.SuspendLayout()
        CType(Me.GC31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FGARIG_CDF_RI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FGARIG_CDF_TC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel24.SuspendLayout()
        Me.Panel26.SuspendLayout()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel25.SuspendLayout()
        Me.XtraTabPage8.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel33.SuspendLayout()
        CType(Me.GC45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FGAAFS1_SP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FGAAFS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.Panel22.SuspendLayout()
        CType(Me.GC42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rm_Memo4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel23.SuspendLayout()
        Me.Panel20.SuspendLayout()
        CType(Me.GC41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FGACF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel29.SuspendLayout()
        CType(Me.GC43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FGACN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel30.SuspendLayout()
        Me.Panel31.SuspendLayout()
        CType(Me.GC44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rm_Memo5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel32.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.Panel38.SuspendLayout()
        Me.Panel39.SuspendLayout()
        CType(Me.GC54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rm_Memo7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel40.SuspendLayout()
        Me.Panel41.SuspendLayout()
        CType(Me.GC53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FGACFAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.Panel35.SuspendLayout()
        Me.Panel36.SuspendLayout()
        CType(Me.GC52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rm_Memo6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel37.SuspendLayout()
        Me.Panel34.SuspendLayout()
        CType(Me.GC51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FGARIFAP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.XtraTabControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl3.SuspendLayout()
        Me.XtraTabPage9.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        Me.Panel43.SuspendLayout()
        Me.Panel44.SuspendLayout()
        CType(Me.GC63, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV63, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rm_Memo8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel45.SuspendLayout()
        Me.Panel42.SuspendLayout()
        CType(Me.GC61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FGAON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC62, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV62, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FGACFN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.lkupFGA_CDF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage11.SuspendLayout()
        Me.Panel47.SuspendLayout()
        Me.Panel48.SuspendLayout()
        CType(Me.GC72, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV72, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rm_Memo9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel49.SuspendLayout()
        Me.Panel46.SuspendLayout()
        CType(Me.GC71, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV71, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FGARIL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage12.SuspendLayout()
        Me.Panel55.SuspendLayout()
        Me.Panel51.SuspendLayout()
        CType(Me.GC82, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV82, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FGAAFS_SP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FGAAFS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel52.SuspendLayout()
        Me.Panel53.SuspendLayout()
        CType(Me.GC83, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV83, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rm_Memo10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel54.SuspendLayout()
        Me.Panel50.SuspendLayout()
        CType(Me.GC81, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV81, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FGACA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FGAFICHEGRALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(913, 640)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.XtraTabControl1)
        Me.PanMain.Controls.Add(Me.GroupBox1)
        Me.PanMain.Location = New System.Drawing.Point(0, 72)
        Me.PanMain.Size = New System.Drawing.Size(795, 568)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(913, 72)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(913, 28)
        Me.Label1.Text = "Grossesse - Allaitement"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(305, 40)
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(35, 40)
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(795, 72)
        Me.Panel1.Size = New System.Drawing.Size(118, 568)
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Grossesse_Allaitement, "FGA_FICHEGRAL.FGA_DATEMJ", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(377, 39)
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Location = New System.Drawing.Point(0, 64)
        Me.GroupBox.Size = New System.Drawing.Size(913, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Grossesse_Allaitement, "FGA_FICHEGRAL.FGA_DATECR", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(92, 38)
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
        'FgA_TA
        '
        Me.FgA_TA.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(795, 42)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Grossesse_Allaitement, "FGA_FICHEGRAL.FGA_CODE_SQ_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(92, 13)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(135, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Tag = "[NOEDIT][NOADD]"
        '
        'DsTheriaque_Grossesse_Allaitement
        '
        Me.DsTheriaque_Grossesse_Allaitement.DataSetName = "dsTheriaque_Grossesse_Allaitement"
        Me.DsTheriaque_Grossesse_Allaitement.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(46, 16)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Fiche N°"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 42)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(795, 526)
        Me.XtraTabControl1.TabIndex = 8
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panel7)
        Me.XtraTabPage1.Controls.Add(Me.Panel6)
        Me.XtraTabPage1.Controls.Add(Me.Panel4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(786, 495)
        Me.XtraTabPage1.Text = "Entités"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.GC5)
        Me.Panel7.Controls.Add(Me.GC6)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 274)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(786, 221)
        Me.Panel7.TabIndex = 25
        '
        'GC5
        '
        Me.GC5.DataMember = "FGAPR_GRALPROD"
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
        Me.GC5.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FGAPR})
        Me.GC5.Size = New System.Drawing.Size(427, 221)
        Me.GC5.TabIndex = 2
        Me.GC5.Tag = "[EDIT][ADD]"
        Me.GC5.UseEmbeddedNavigator = True
        Me.GC5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV5})
        '
        'GV5
        '
        Me.GV5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGAPR_FGA_CODE_FK_PK, Me.colFGAPR_PR_CODE_FK_PK, Me.GridColumn5})
        Me.GV5.GridControl = Me.GC5
        Me.GV5.Name = "GV5"
        Me.GV5.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV5.OptionsView.ShowGroupPanel = False
        '
        'colFGAPR_FGA_CODE_FK_PK
        '
        Me.colFGAPR_FGA_CODE_FK_PK.Caption = "FGAPR_FGA_CODE_FK_PK"
        Me.colFGAPR_FGA_CODE_FK_PK.FieldName = "FGAPR_FGA_CODE_FK_PK"
        Me.colFGAPR_FGA_CODE_FK_PK.Name = "colFGAPR_FGA_CODE_FK_PK"
        '
        'colFGAPR_PR_CODE_FK_PK
        '
        Me.colFGAPR_PR_CODE_FK_PK.Caption = "Code"
        Me.colFGAPR_PR_CODE_FK_PK.FieldName = "FGAPR_PR_CODE_FK_PK"
        Me.colFGAPR_PR_CODE_FK_PK.Name = "colFGAPR_PR_CODE_FK_PK"
        Me.colFGAPR_PR_CODE_FK_PK.Visible = True
        Me.colFGAPR_PR_CODE_FK_PK.VisibleIndex = 0
        Me.colFGAPR_PR_CODE_FK_PK.Width = 50
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Produit"
        Me.GridColumn5.ColumnEdit = Me.rp_FGAPR
        Me.GridColumn5.FieldName = "FGAPR_PR_CODE_FK_PK"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 352
        '
        'rp_FGAPR
        '
        Me.rp_FGAPR.AutoHeight = False
        Me.rp_FGAPR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FGAPR.Name = "rp_FGAPR"
        '
        'GC6
        '
        Me.GC6.DataMember = "FGASP_GRALSPE"
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
        Me.GC6.Location = New System.Drawing.Point(427, 0)
        Me.GC6.MainView = Me.GV6
        Me.GC6.Name = "GC6"
        Me.GC6.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FGASP_FGA})
        Me.GC6.Size = New System.Drawing.Size(359, 221)
        Me.GC6.TabIndex = 3
        Me.GC6.Tag = "[EDIT][ADD]"
        Me.GC6.UseEmbeddedNavigator = True
        Me.GC6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV6})
        '
        'GV6
        '
        Me.GV6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGASP_FGA_CODE_FK_PK, Me.colFGASP_SP_CODE_FK_PK, Me.GridColumn6})
        Me.GV6.GridControl = Me.GC6
        Me.GV6.Name = "GV6"
        Me.GV6.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV6.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV6.OptionsView.ShowGroupPanel = False
        '
        'colFGASP_FGA_CODE_FK_PK
        '
        Me.colFGASP_FGA_CODE_FK_PK.Caption = "FGASP_FGA_CODE_FK_PK"
        Me.colFGASP_FGA_CODE_FK_PK.FieldName = "FGASP_FGA_CODE_FK_PK"
        Me.colFGASP_FGA_CODE_FK_PK.Name = "colFGASP_FGA_CODE_FK_PK"
        '
        'colFGASP_SP_CODE_FK_PK
        '
        Me.colFGASP_SP_CODE_FK_PK.Caption = "Code"
        Me.colFGASP_SP_CODE_FK_PK.FieldName = "FGASP_SP_CODE_FK_PK"
        Me.colFGASP_SP_CODE_FK_PK.Name = "colFGASP_SP_CODE_FK_PK"
        Me.colFGASP_SP_CODE_FK_PK.Visible = True
        Me.colFGASP_SP_CODE_FK_PK.VisibleIndex = 0
        Me.colFGASP_SP_CODE_FK_PK.Width = 50
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Spécialités"
        Me.GridColumn6.ColumnEdit = Me.rp_FGASP_FGA
        Me.GridColumn6.FieldName = "FGASP_SP_CODE_FK_PK"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        Me.GridColumn6.Width = 230
        '
        'rp_FGASP_FGA
        '
        Me.rp_FGASP_FGA.AutoHeight = False
        Me.rp_FGASP_FGA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FGASP_FGA.Name = "rp_FGASP_FGA"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GC3)
        Me.Panel6.Controls.Add(Me.GC4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 137)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(786, 137)
        Me.Panel6.TabIndex = 24
        '
        'GC3
        '
        Me.GC3.DataMember = "FGASAC_GRALSUBAC"
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
        Me.GC3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FGASAC})
        Me.GC3.Size = New System.Drawing.Size(427, 137)
        Me.GC3.TabIndex = 2
        Me.GC3.Tag = "[EDIT][ADD]"
        Me.GC3.UseEmbeddedNavigator = True
        Me.GC3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV3})
        '
        'GV3
        '
        Me.GV3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGASAC_FGA_CODE_FK_PK, Me.colFGASAC_SAC_CODE_FK_PK, Me.GridColumn3})
        Me.GV3.GridControl = Me.GC3
        Me.GV3.Name = "GV3"
        Me.GV3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV3.OptionsView.ShowGroupPanel = False
        '
        'colFGASAC_FGA_CODE_FK_PK
        '
        Me.colFGASAC_FGA_CODE_FK_PK.Caption = "FGASAC_FGA_CODE_FK_PK"
        Me.colFGASAC_FGA_CODE_FK_PK.FieldName = "FGASAC_FGA_CODE_FK_PK"
        Me.colFGASAC_FGA_CODE_FK_PK.Name = "colFGASAC_FGA_CODE_FK_PK"
        '
        'colFGASAC_SAC_CODE_FK_PK
        '
        Me.colFGASAC_SAC_CODE_FK_PK.Caption = "Code"
        Me.colFGASAC_SAC_CODE_FK_PK.FieldName = "FGASAC_SAC_CODE_FK_PK"
        Me.colFGASAC_SAC_CODE_FK_PK.Name = "colFGASAC_SAC_CODE_FK_PK"
        Me.colFGASAC_SAC_CODE_FK_PK.Visible = True
        Me.colFGASAC_SAC_CODE_FK_PK.VisibleIndex = 0
        Me.colFGASAC_SAC_CODE_FK_PK.Width = 50
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Substance active"
        Me.GridColumn3.ColumnEdit = Me.rp_FGASAC
        Me.GridColumn3.FieldName = "FGASAC_SAC_CODE_FK_PK"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 352
        '
        'rp_FGASAC
        '
        Me.rp_FGASAC.AutoHeight = False
        Me.rp_FGASAC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FGASAC.Name = "rp_FGASAC"
        '
        'GC4
        '
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
        Me.GC4.Location = New System.Drawing.Point(427, 0)
        Me.GC4.MainView = Me.GV4
        Me.GC4.Name = "GC4"
        Me.GC4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FGASAU})
        Me.GC4.Size = New System.Drawing.Size(359, 137)
        Me.GC4.TabIndex = 3
        Me.GC4.Tag = "[EDIT][ADD]"
        Me.GC4.UseEmbeddedNavigator = True
        Me.GC4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV4})
        '
        'GV4
        '
        Me.GV4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGASAU_FGA_CODE_FK_PK, Me.colFGASAU_SAU_CODE_FK_PK, Me.GridColumn4})
        Me.GV4.GridControl = Me.GC4
        Me.GV4.Name = "GV4"
        Me.GV4.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV4.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV4.OptionsView.ShowGroupPanel = False
        '
        'colFGASAU_FGA_CODE_FK_PK
        '
        Me.colFGASAU_FGA_CODE_FK_PK.Caption = "FGASAU_FGA_CODE_FK_PK"
        Me.colFGASAU_FGA_CODE_FK_PK.FieldName = "FGASAU_FGA_CODE_FK_PK"
        Me.colFGASAU_FGA_CODE_FK_PK.Name = "colFGASAU_FGA_CODE_FK_PK"
        '
        'colFGASAU_SAU_CODE_FK_PK
        '
        Me.colFGASAU_SAU_CODE_FK_PK.Caption = "Code"
        Me.colFGASAU_SAU_CODE_FK_PK.FieldName = "FGASAU_SAU_CODE_FK_PK"
        Me.colFGASAU_SAU_CODE_FK_PK.Name = "colFGASAU_SAU_CODE_FK_PK"
        Me.colFGASAU_SAU_CODE_FK_PK.Visible = True
        Me.colFGASAU_SAU_CODE_FK_PK.VisibleIndex = 0
        Me.colFGASAU_SAU_CODE_FK_PK.Width = 50
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Excipient"
        Me.GridColumn4.ColumnEdit = Me.rp_FGASAU
        Me.GridColumn4.FieldName = "FGASAU_SAU_CODE_FK_PK"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 232
        '
        'rp_FGASAU
        '
        Me.rp_FGASAU.AutoHeight = False
        Me.rp_FGASAU.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FGASAU.Name = "rp_FGASAU"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GC2)
        Me.Panel4.Controls.Add(Me.GC1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(786, 137)
        Me.Panel4.TabIndex = 23
        '
        'GC2
        '
        Me.GC2.DataMember = "FGACCH_GRALCLCH"
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
        Me.GC2.Location = New System.Drawing.Point(423, 0)
        Me.GC2.MainView = Me.GV2
        Me.GC2.Name = "GC2"
        Me.GC2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FGACCH})
        Me.GC2.Size = New System.Drawing.Size(363, 137)
        Me.GC2.TabIndex = 3
        Me.GC2.Tag = "[EDIT][ADD]"
        Me.GC2.UseEmbeddedNavigator = True
        Me.GC2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGACCH_FGA_CODE_FK_PK, Me.colFGACCH_CCH_CODE_FK_PK, Me.GridColumn2})
        Me.GV2.GridControl = Me.GC2
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV2.OptionsView.ShowGroupPanel = False
        '
        'colFGACCH_FGA_CODE_FK_PK
        '
        Me.colFGACCH_FGA_CODE_FK_PK.Caption = "FGACCH_FGA_CODE_FK_PK"
        Me.colFGACCH_FGA_CODE_FK_PK.FieldName = "FGACCH_FGA_CODE_FK_PK"
        Me.colFGACCH_FGA_CODE_FK_PK.Name = "colFGACCH_FGA_CODE_FK_PK"
        '
        'colFGACCH_CCH_CODE_FK_PK
        '
        Me.colFGACCH_CCH_CODE_FK_PK.Caption = "Code"
        Me.colFGACCH_CCH_CODE_FK_PK.FieldName = "FGACCH_CCH_CODE_FK_PK"
        Me.colFGACCH_CCH_CODE_FK_PK.Name = "colFGACCH_CCH_CODE_FK_PK"
        Me.colFGACCH_CCH_CODE_FK_PK.Visible = True
        Me.colFGACCH_CCH_CODE_FK_PK.VisibleIndex = 0
        Me.colFGACCH_CCH_CODE_FK_PK.Width = 50
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Classe chimique"
        Me.GridColumn2.ColumnEdit = Me.rp_FGACCH
        Me.GridColumn2.FieldName = "FGACCH_CCH_CODE_FK_PK"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 232
        '
        'rp_FGACCH
        '
        Me.rp_FGACCH.AutoHeight = False
        Me.rp_FGACCH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FGACCH.Name = "rp_FGACCH"
        '
        'GC1
        '
        Me.GC1.DataMember = "FGACPH_GRALCLPH"
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
        Me.GC1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FGACPH})
        Me.GC1.Size = New System.Drawing.Size(423, 137)
        Me.GC1.TabIndex = 2
        Me.GC1.Tag = "[EDIT][ADD]"
        Me.GC1.UseEmbeddedNavigator = True
        Me.GC1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGACPH_FGA_CODE_FK_PK, Me.colFGACPH_CPH_CODE_FK_PK, Me.GridColumn1})
        Me.GV1.GridControl = Me.GC1
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV1.OptionsView.ShowGroupPanel = False
        '
        'colFGACPH_FGA_CODE_FK_PK
        '
        Me.colFGACPH_FGA_CODE_FK_PK.Caption = "FGACPH_FGA_CODE_FK_PK"
        Me.colFGACPH_FGA_CODE_FK_PK.FieldName = "FGACPH_FGA_CODE_FK_PK"
        Me.colFGACPH_FGA_CODE_FK_PK.Name = "colFGACPH_FGA_CODE_FK_PK"
        '
        'colFGACPH_CPH_CODE_FK_PK
        '
        Me.colFGACPH_CPH_CODE_FK_PK.Caption = "Code"
        Me.colFGACPH_CPH_CODE_FK_PK.FieldName = "FGACPH_CPH_CODE_FK_PK"
        Me.colFGACPH_CPH_CODE_FK_PK.Name = "colFGACPH_CPH_CODE_FK_PK"
        Me.colFGACPH_CPH_CODE_FK_PK.Visible = True
        Me.colFGACPH_CPH_CODE_FK_PK.VisibleIndex = 0
        Me.colFGACPH_CPH_CODE_FK_PK.Width = 58
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Classe pharmaco-thérapeutique"
        Me.GridColumn1.ColumnEdit = Me.rp_FGACPH
        Me.GridColumn1.FieldName = "FGACPH_CPH_CODE_FK_PK"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 344
        '
        'rp_FGACPH
        '
        Me.rp_FGACPH.AutoHeight = False
        Me.rp_FGACPH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FGACPH.Name = "rp_FGACPH"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.XtraTabControl2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(503, 421)
        Me.XtraTabPage2.Tag = ""
        Me.XtraTabPage2.Text = "Grossesse"
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl2.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage5
        Me.XtraTabControl2.Size = New System.Drawing.Size(503, 421)
        Me.XtraTabControl2.TabIndex = 0
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage5, Me.XtraTabPage6, Me.XtraTabPage7, Me.XtraTabPage8})
        Me.XtraTabControl2.Tag = ""
        Me.XtraTabControl2.Text = "XtraTabControl2"
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.Panel12)
        Me.XtraTabPage5.Controls.Add(Me.Panel3)
        Me.XtraTabPage5.Controls.Add(Me.Panel2)
        Me.XtraTabPage5.Controls.Add(Me.Panel8)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(494, 390)
        Me.XtraTabPage5.Text = "Données expérimentales "
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.Panel27)
        Me.Panel12.Controls.Add(Me.Panel28)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(0, 321)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(494, 69)
        Me.Panel12.TabIndex = 44
        Me.Panel12.Tag = ""
        '
        'Panel27
        '
        Me.Panel27.Controls.Add(Me.GC13)
        Me.Panel27.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel27.Location = New System.Drawing.Point(0, 24)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(494, 45)
        Me.Panel27.TabIndex = 38
        Me.Panel27.Tag = "[ADD][EDIT]"
        '
        'GC13
        '
        Me.GC13.DataMember = "FGATX1_FGA_TXOBSERVANI"
        Me.GC13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC13.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC13.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC13.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC13.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC13.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC13.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC13.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC13.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC13.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC13.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC13.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC13.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC13.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC13.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC13.EmbeddedNavigator.Name = ""
        Me.GC13.EmbeddedNavigator.TextStringFormat = ""
        Me.GC13.Location = New System.Drawing.Point(0, 0)
        Me.GC13.MainView = Me.GV13
        Me.GC13.Name = "GC13"
        Me.GC13.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rm_Memo1})
        Me.GC13.Size = New System.Drawing.Size(494, 45)
        Me.GC13.TabIndex = 5
        Me.GC13.UseEmbeddedNavigator = True
        Me.GC13.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV13})
        '
        'GV13
        '
        Me.GV13.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGATX1_FGA_CODE_FK_PK, Me.colFGATX1_TEXTE})
        Me.GV13.GridControl = Me.GC13
        Me.GV13.GroupFormat = ""
        Me.GV13.GroupPanelText = " "
        Me.GV13.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GV13.Name = "GV13"
        Me.GV13.OptionsCustomization.AllowRowSizing = True
        Me.GV13.OptionsNavigation.AutoFocusNewRow = True
        Me.GV13.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV13.OptionsView.ShowColumnHeaders = False
        Me.GV13.OptionsView.ShowDetailButtons = False
        Me.GV13.OptionsView.ShowGroupPanel = False
        Me.GV13.OptionsView.ShowHorzLines = False
        Me.GV13.OptionsView.ShowIndicator = False
        Me.GV13.RowHeight = 95
        Me.GV13.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colFGATX1_FGA_CODE_FK_PK
        '
        Me.colFGATX1_FGA_CODE_FK_PK.Caption = "FGATX1_FGA_CODE_FK_PK"
        Me.colFGATX1_FGA_CODE_FK_PK.FieldName = "FGATX1_FGA_CODE_FK_PK"
        Me.colFGATX1_FGA_CODE_FK_PK.Name = "colFGATX1_FGA_CODE_FK_PK"
        '
        'colFGATX1_TEXTE
        '
        Me.colFGATX1_TEXTE.Caption = "FGATX1_TEXTE"
        Me.colFGATX1_TEXTE.ColumnEdit = Me.rm_Memo1
        Me.colFGATX1_TEXTE.FieldName = "FGATX1_TEXTE"
        Me.colFGATX1_TEXTE.Name = "colFGATX1_TEXTE"
        Me.colFGATX1_TEXTE.Visible = True
        Me.colFGATX1_TEXTE.VisibleIndex = 0
        '
        'rm_Memo1
        '
        Me.rm_Memo1.Name = "rm_Memo1"
        '
        'Panel28
        '
        Me.Panel28.Controls.Add(Me.LabelControl7)
        Me.Panel28.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel28.Location = New System.Drawing.Point(0, 0)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(494, 24)
        Me.Panel28.TabIndex = 37
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(4, 8)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl7.TabIndex = 19
        Me.LabelControl7.Text = "Texte"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GC14)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 214)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(494, 107)
        Me.Panel3.TabIndex = 43
        '
        'GC14
        '
        Me.GC14.DataMember = "FGARIA_RISQUE_ANIMALE"
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
        Me.GC14.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FGARIA})
        Me.GC14.Size = New System.Drawing.Size(494, 107)
        Me.GC14.TabIndex = 2
        Me.GC14.Tag = "[EDIT][ADD]"
        Me.GC14.UseEmbeddedNavigator = True
        Me.GC14.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV14})
        '
        'GV14
        '
        Me.GV14.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGARIA_FGA_CODE_FK_PK, Me.colFGARIA_CDF_RI_CODE_FK_PK, Me.colFGARIA_NUMORD})
        Me.GV14.GridControl = Me.GC14
        Me.GV14.Name = "GV14"
        Me.GV14.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV14.OptionsView.ShowGroupPanel = False
        Me.GV14.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFGARIA_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFGARIA_FGA_CODE_FK_PK
        '
        Me.colFGARIA_FGA_CODE_FK_PK.Caption = "FGARIA_FGA_CODE_FK_PK"
        Me.colFGARIA_FGA_CODE_FK_PK.FieldName = "FGARIA_FGA_CODE_FK_PK"
        Me.colFGARIA_FGA_CODE_FK_PK.Name = "colFGARIA_FGA_CODE_FK_PK"
        '
        'colFGARIA_CDF_RI_CODE_FK_PK
        '
        Me.colFGARIA_CDF_RI_CODE_FK_PK.Caption = "Risque / Animal"
        Me.colFGARIA_CDF_RI_CODE_FK_PK.ColumnEdit = Me.rp_FGARIA
        Me.colFGARIA_CDF_RI_CODE_FK_PK.FieldName = "FGARIA_CDF_RI_CODE_FK_PK"
        Me.colFGARIA_CDF_RI_CODE_FK_PK.Name = "colFGARIA_CDF_RI_CODE_FK_PK"
        Me.colFGARIA_CDF_RI_CODE_FK_PK.Visible = True
        Me.colFGARIA_CDF_RI_CODE_FK_PK.VisibleIndex = 0
        Me.colFGARIA_CDF_RI_CODE_FK_PK.Width = 702
        '
        'rp_FGARIA
        '
        Me.rp_FGARIA.AutoHeight = False
        Me.rp_FGARIA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FGARIA.Name = "rp_FGARIA"
        '
        'colFGARIA_NUMORD
        '
        Me.colFGARIA_NUMORD.Caption = "N°"
        Me.colFGARIA_NUMORD.FieldName = "FGARIA_NUMORD"
        Me.colFGARIA_NUMORD.Name = "colFGARIA_NUMORD"
        Me.colFGARIA_NUMORD.Visible = True
        Me.colFGARIA_NUMORD.VisibleIndex = 1
        Me.colFGARIA_NUMORD.Width = 50
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GC12)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 107)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(494, 107)
        Me.Panel2.TabIndex = 26
        '
        'GC12
        '
        Me.GC12.DataMember = "FGACFA_CIRCONSTFAVORIS_ANIMALE"
        Me.GC12.Dock = System.Windows.Forms.DockStyle.Top
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
        Me.GC12.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FGACFA})
        Me.GC12.Size = New System.Drawing.Size(494, 102)
        Me.GC12.TabIndex = 2
        Me.GC12.Tag = "[EDIT][ADD]"
        Me.GC12.UseEmbeddedNavigator = True
        Me.GC12.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV12})
        '
        'GV12
        '
        Me.GV12.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGACFA_FGA_CODE_FK_PK, Me.colFGACFA_CDF_CF_CODE_FK_PK, Me.colFGACFA_NUMORD})
        Me.GV12.GridControl = Me.GC12
        Me.GV12.Name = "GV12"
        Me.GV12.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV12.OptionsView.ShowGroupPanel = False
        Me.GV12.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFGACFA_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFGACFA_FGA_CODE_FK_PK
        '
        Me.colFGACFA_FGA_CODE_FK_PK.Caption = "FGACFA_FGA_CODE_FK_PK"
        Me.colFGACFA_FGA_CODE_FK_PK.FieldName = "FGACFA_FGA_CODE_FK_PK"
        Me.colFGACFA_FGA_CODE_FK_PK.Name = "colFGACFA_FGA_CODE_FK_PK"
        '
        'colFGACFA_CDF_CF_CODE_FK_PK
        '
        Me.colFGACFA_CDF_CF_CODE_FK_PK.Caption = "Circonstances favorisantes"
        Me.colFGACFA_CDF_CF_CODE_FK_PK.ColumnEdit = Me.rp_FGACFA
        Me.colFGACFA_CDF_CF_CODE_FK_PK.FieldName = "FGACFA_CDF_CF_CODE_FK_PK"
        Me.colFGACFA_CDF_CF_CODE_FK_PK.Name = "colFGACFA_CDF_CF_CODE_FK_PK"
        Me.colFGACFA_CDF_CF_CODE_FK_PK.Visible = True
        Me.colFGACFA_CDF_CF_CODE_FK_PK.VisibleIndex = 0
        Me.colFGACFA_CDF_CF_CODE_FK_PK.Width = 702
        '
        'rp_FGACFA
        '
        Me.rp_FGACFA.AutoHeight = False
        Me.rp_FGACFA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FGACFA.Name = "rp_FGACFA"
        '
        'colFGACFA_NUMORD
        '
        Me.colFGACFA_NUMORD.Caption = "N°"
        Me.colFGACFA_NUMORD.FieldName = "FGACFA_NUMORD"
        Me.colFGACFA_NUMORD.Name = "colFGACFA_NUMORD"
        Me.colFGACFA_NUMORD.Visible = True
        Me.colFGACFA_NUMORD.VisibleIndex = 1
        Me.colFGACFA_NUMORD.Width = 50
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.GC11)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(494, 107)
        Me.Panel8.TabIndex = 25
        '
        'GC11
        '
        Me.GC11.DataMember = "FGAOA_OBSERVATION_ANIMALE"
        Me.GC11.Dock = System.Windows.Forms.DockStyle.Top
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
        Me.GC11.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FGAOA})
        Me.GC11.Size = New System.Drawing.Size(494, 102)
        Me.GC11.TabIndex = 2
        Me.GC11.Tag = "[EDIT][ADD]"
        Me.GC11.UseEmbeddedNavigator = True
        Me.GC11.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV11})
        '
        'GV11
        '
        Me.GV11.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGAOA_FGA_CODE_FK_PK, Me.colFGAOA_CDF_OBS_CODE_FK_PK, Me.colFGAOA_NUMORD})
        Me.GV11.GridControl = Me.GC11
        Me.GV11.Name = "GV11"
        Me.GV11.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV11.OptionsView.ShowGroupPanel = False
        Me.GV11.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFGAOA_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFGAOA_FGA_CODE_FK_PK
        '
        Me.colFGAOA_FGA_CODE_FK_PK.Caption = "FGAOA_FGA_CODE_FK_PK"
        Me.colFGAOA_FGA_CODE_FK_PK.FieldName = "FGAOA_FGA_CODE_FK_PK"
        Me.colFGAOA_FGA_CODE_FK_PK.Name = "colFGAOA_FGA_CODE_FK_PK"
        '
        'colFGAOA_CDF_OBS_CODE_FK_PK
        '
        Me.colFGAOA_CDF_OBS_CODE_FK_PK.Caption = "Observation / Espèce Animale"
        Me.colFGAOA_CDF_OBS_CODE_FK_PK.ColumnEdit = Me.rp_FGAOA
        Me.colFGAOA_CDF_OBS_CODE_FK_PK.FieldName = "FGAOA_CDF_OBS_CODE_FK_PK"
        Me.colFGAOA_CDF_OBS_CODE_FK_PK.Name = "colFGAOA_CDF_OBS_CODE_FK_PK"
        Me.colFGAOA_CDF_OBS_CODE_FK_PK.Visible = True
        Me.colFGAOA_CDF_OBS_CODE_FK_PK.VisibleIndex = 0
        Me.colFGAOA_CDF_OBS_CODE_FK_PK.Width = 702
        '
        'rp_FGAOA
        '
        Me.rp_FGAOA.AutoHeight = False
        Me.rp_FGAOA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FGAOA.Name = "rp_FGAOA"
        '
        'colFGAOA_NUMORD
        '
        Me.colFGAOA_NUMORD.Caption = "N°"
        Me.colFGAOA_NUMORD.FieldName = "FGAOA_NUMORD"
        Me.colFGAOA_NUMORD.Name = "colFGAOA_NUMORD"
        Me.colFGAOA_NUMORD.Visible = True
        Me.colFGAOA_NUMORD.VisibleIndex = 1
        Me.colFGAOA_NUMORD.Width = 50
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Controls.Add(Me.Panel13)
        Me.XtraTabPage6.Controls.Add(Me.Panel11)
        Me.XtraTabPage6.Controls.Add(Me.Panel10)
        Me.XtraTabPage6.Controls.Add(Me.Panel9)
        Me.XtraTabPage6.Controls.Add(Me.Panel5)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(494, 390)
        Me.XtraTabPage6.Tag = ""
        Me.XtraTabPage6.Text = "Données cliniques"
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.Panel14)
        Me.Panel13.Controls.Add(Me.Panel15)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.Location = New System.Drawing.Point(0, 353)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(494, 37)
        Me.Panel13.TabIndex = 45
        Me.Panel13.Tag = ""
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.GC25)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(0, 24)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(494, 13)
        Me.Panel14.TabIndex = 38
        Me.Panel14.Tag = "[ADD][EDIT]"
        '
        'GC25
        '
        Me.GC25.DataMember = "FGATX3_FGA_TXOBSERVHUM"
        Me.GC25.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC25.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC25.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC25.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC25.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC25.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC25.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC25.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC25.EmbeddedNavigator.Name = ""
        Me.GC25.EmbeddedNavigator.TextStringFormat = ""
        Me.GC25.Location = New System.Drawing.Point(0, 0)
        Me.GC25.MainView = Me.GV25
        Me.GC25.Name = "GC25"
        Me.GC25.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rm_Memo2})
        Me.GC25.Size = New System.Drawing.Size(494, 13)
        Me.GC25.TabIndex = 5
        Me.GC25.UseEmbeddedNavigator = True
        Me.GC25.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV25})
        '
        'GV25
        '
        Me.GV25.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGATX3_FGA_CODE_FK_PK, Me.colFGATX3_TEXTE})
        Me.GV25.GridControl = Me.GC25
        Me.GV25.GroupFormat = ""
        Me.GV25.GroupPanelText = " "
        Me.GV25.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GV25.Name = "GV25"
        Me.GV25.OptionsCustomization.AllowRowSizing = True
        Me.GV25.OptionsNavigation.AutoFocusNewRow = True
        Me.GV25.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV25.OptionsView.ShowColumnHeaders = False
        Me.GV25.OptionsView.ShowDetailButtons = False
        Me.GV25.OptionsView.ShowGroupPanel = False
        Me.GV25.OptionsView.ShowHorzLines = False
        Me.GV25.OptionsView.ShowIndicator = False
        Me.GV25.RowHeight = 61
        Me.GV25.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colFGATX3_FGA_CODE_FK_PK
        '
        Me.colFGATX3_FGA_CODE_FK_PK.Caption = "FGATX3_FGA_CODE_FK_PK"
        Me.colFGATX3_FGA_CODE_FK_PK.FieldName = "FGATX3_FGA_CODE_FK_PK"
        Me.colFGATX3_FGA_CODE_FK_PK.Name = "colFGATX3_FGA_CODE_FK_PK"
        '
        'colFGATX3_TEXTE
        '
        Me.colFGATX3_TEXTE.Caption = "FGATX3_TEXTE"
        Me.colFGATX3_TEXTE.ColumnEdit = Me.rm_Memo2
        Me.colFGATX3_TEXTE.FieldName = "FGATX3_TEXTE"
        Me.colFGATX3_TEXTE.Name = "colFGATX3_TEXTE"
        Me.colFGATX3_TEXTE.Visible = True
        Me.colFGATX3_TEXTE.VisibleIndex = 0
        '
        'rm_Memo2
        '
        Me.rm_Memo2.Name = "rm_Memo2"
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.LabelControl4)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(494, 24)
        Me.Panel15.TabIndex = 37
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(4, 8)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl4.TabIndex = 19
        Me.LabelControl4.Text = "Texte"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.GC24)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 264)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(494, 89)
        Me.Panel11.TabIndex = 29
        '
        'GC24
        '
        Me.GC24.DataMember = "FGARIH_RISQUE_HUMAINE"
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
        Me.GC24.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FGARIH})
        Me.GC24.Size = New System.Drawing.Size(494, 89)
        Me.GC24.TabIndex = 2
        Me.GC24.Tag = "[EDIT][ADD]"
        Me.GC24.UseEmbeddedNavigator = True
        Me.GC24.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV24})
        '
        'GV24
        '
        Me.GV24.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGARIH_FGA_CODE_FK_PK, Me.colFGARIH_CDF_RI_CODE_FK_PK, Me.colFGARIH_NUMORD})
        Me.GV24.GridControl = Me.GC24
        Me.GV24.Name = "GV24"
        Me.GV24.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV24.OptionsView.ShowGroupPanel = False
        Me.GV24.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFGARIH_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFGARIH_FGA_CODE_FK_PK
        '
        Me.colFGARIH_FGA_CODE_FK_PK.Caption = "FGARIH_FGA_CODE_FK_PK"
        Me.colFGARIH_FGA_CODE_FK_PK.FieldName = "FGARIH_FGA_CODE_FK_PK"
        Me.colFGARIH_FGA_CODE_FK_PK.Name = "colFGARIH_FGA_CODE_FK_PK"
        '
        'colFGARIH_CDF_RI_CODE_FK_PK
        '
        Me.colFGARIH_CDF_RI_CODE_FK_PK.Caption = "Risque / Homme"
        Me.colFGARIH_CDF_RI_CODE_FK_PK.ColumnEdit = Me.rp_FGARIH
        Me.colFGARIH_CDF_RI_CODE_FK_PK.FieldName = "FGARIH_CDF_RI_CODE_FK_PK"
        Me.colFGARIH_CDF_RI_CODE_FK_PK.Name = "colFGARIH_CDF_RI_CODE_FK_PK"
        Me.colFGARIH_CDF_RI_CODE_FK_PK.Visible = True
        Me.colFGARIH_CDF_RI_CODE_FK_PK.VisibleIndex = 0
        Me.colFGARIH_CDF_RI_CODE_FK_PK.Width = 686
        '
        'rp_FGARIH
        '
        Me.rp_FGARIH.AutoHeight = False
        Me.rp_FGARIH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FGARIH.Name = "rp_FGARIH"
        '
        'colFGARIH_NUMORD
        '
        Me.colFGARIH_NUMORD.Caption = "N°"
        Me.colFGARIH_NUMORD.FieldName = "FGARIH_NUMORD"
        Me.colFGARIH_NUMORD.Name = "colFGARIH_NUMORD"
        Me.colFGARIH_NUMORD.Visible = True
        Me.colFGARIH_NUMORD.VisibleIndex = 1
        Me.colFGARIH_NUMORD.Width = 50
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.GC23)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 177)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(494, 87)
        Me.Panel10.TabIndex = 28
        '
        'GC23
        '
        Me.GC23.DataMember = "FGACFH_CIRCONSTFAVORIS_HUMAINE"
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
        Me.GC23.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FGACFH})
        Me.GC23.Size = New System.Drawing.Size(494, 87)
        Me.GC23.TabIndex = 2
        Me.GC23.Tag = "[EDIT][ADD]"
        Me.GC23.UseEmbeddedNavigator = True
        Me.GC23.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV23})
        '
        'GV23
        '
        Me.GV23.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGACFH_FGA_CODE_FK_PK, Me.colFGACFH_CDF_CF_CODE_FK_PK, Me.colFGACFH_NUMORD})
        Me.GV23.GridControl = Me.GC23
        Me.GV23.Name = "GV23"
        Me.GV23.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV23.OptionsView.ShowGroupPanel = False
        Me.GV23.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFGACFH_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFGACFH_FGA_CODE_FK_PK
        '
        Me.colFGACFH_FGA_CODE_FK_PK.Caption = "FGACFH_FGA_CODE_FK_PK"
        Me.colFGACFH_FGA_CODE_FK_PK.FieldName = "FGACFH_FGA_CODE_FK_PK"
        Me.colFGACFH_FGA_CODE_FK_PK.Name = "colFGACFH_FGA_CODE_FK_PK"
        '
        'colFGACFH_CDF_CF_CODE_FK_PK
        '
        Me.colFGACFH_CDF_CF_CODE_FK_PK.Caption = "Circonstances favorisantes"
        Me.colFGACFH_CDF_CF_CODE_FK_PK.ColumnEdit = Me.rp_FGACFH
        Me.colFGACFH_CDF_CF_CODE_FK_PK.FieldName = "FGACFH_CDF_CF_CODE_FK_PK"
        Me.colFGACFH_CDF_CF_CODE_FK_PK.Name = "colFGACFH_CDF_CF_CODE_FK_PK"
        Me.colFGACFH_CDF_CF_CODE_FK_PK.Visible = True
        Me.colFGACFH_CDF_CF_CODE_FK_PK.VisibleIndex = 0
        Me.colFGACFH_CDF_CF_CODE_FK_PK.Width = 702
        '
        'rp_FGACFH
        '
        Me.rp_FGACFH.AutoHeight = False
        Me.rp_FGACFH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FGACFH.Name = "rp_FGACFH"
        '
        'colFGACFH_NUMORD
        '
        Me.colFGACFH_NUMORD.Caption = "N°"
        Me.colFGACFH_NUMORD.FieldName = "FGACFH_NUMORD"
        Me.colFGACFH_NUMORD.Name = "colFGACFH_NUMORD"
        Me.colFGACFH_NUMORD.Visible = True
        Me.colFGACFH_NUMORD.VisibleIndex = 1
        Me.colFGACFH_NUMORD.Width = 50
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.GC22)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 89)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(494, 88)
        Me.Panel9.TabIndex = 27
        '
        'GC22
        '
        Me.GC22.DataMember = "FGAOH_OBSERVATION_HUMAINE"
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
        Me.GC22.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FGAOH})
        Me.GC22.Size = New System.Drawing.Size(494, 88)
        Me.GC22.TabIndex = 2
        Me.GC22.Tag = "[EDIT][ADD]"
        Me.GC22.UseEmbeddedNavigator = True
        Me.GC22.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV22})
        '
        'GV22
        '
        Me.GV22.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGAOH_FGA_CODE_FK_PK, Me.colFGAOH_CDF_OBS_CODE_FK_PK, Me.colFGAOH_NUMORD})
        Me.GV22.GridControl = Me.GC22
        Me.GV22.Name = "GV22"
        Me.GV22.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV22.OptionsView.ShowGroupPanel = False
        Me.GV22.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFGAOH_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFGAOH_FGA_CODE_FK_PK
        '
        Me.colFGAOH_FGA_CODE_FK_PK.Caption = "FGAOH_FGA_CODE_FK_PK"
        Me.colFGAOH_FGA_CODE_FK_PK.FieldName = "FGAOH_FGA_CODE_FK_PK"
        Me.colFGAOH_FGA_CODE_FK_PK.Name = "colFGAOH_FGA_CODE_FK_PK"
        '
        'colFGAOH_CDF_OBS_CODE_FK_PK
        '
        Me.colFGAOH_CDF_OBS_CODE_FK_PK.Caption = "Observation / Espèce humaine"
        Me.colFGAOH_CDF_OBS_CODE_FK_PK.ColumnEdit = Me.rp_FGAOH
        Me.colFGAOH_CDF_OBS_CODE_FK_PK.FieldName = "FGAOH_CDF_OBS_CODE_FK_PK"
        Me.colFGAOH_CDF_OBS_CODE_FK_PK.Name = "colFGAOH_CDF_OBS_CODE_FK_PK"
        Me.colFGAOH_CDF_OBS_CODE_FK_PK.Visible = True
        Me.colFGAOH_CDF_OBS_CODE_FK_PK.VisibleIndex = 0
        Me.colFGAOH_CDF_OBS_CODE_FK_PK.Width = 702
        '
        'rp_FGAOH
        '
        Me.rp_FGAOH.AutoHeight = False
        Me.rp_FGAOH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FGAOH.Name = "rp_FGAOH"
        '
        'colFGAOH_NUMORD
        '
        Me.colFGAOH_NUMORD.Caption = "N°"
        Me.colFGAOH_NUMORD.FieldName = "FGAOH_NUMORD"
        Me.colFGAOH_NUMORD.Name = "colFGAOH_NUMORD"
        Me.colFGAOH_NUMORD.Visible = True
        Me.colFGAOH_NUMORD.VisibleIndex = 1
        Me.colFGAOH_NUMORD.Width = 50
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GC21)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(494, 89)
        Me.Panel5.TabIndex = 26
        '
        'GC21
        '
        Me.GC21.DataMember = "FGAPC_PERIODECRITIQUE_FGRAL"
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
        Me.GC21.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FGAPC})
        Me.GC21.Size = New System.Drawing.Size(494, 89)
        Me.GC21.TabIndex = 2
        Me.GC21.Tag = "[EDIT][ADD]"
        Me.GC21.UseEmbeddedNavigator = True
        Me.GC21.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV21})
        '
        'GV21
        '
        Me.GV21.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGAPC_FGA_CODE_FK_PK, Me.colFGAPC_CDF_PC_CODE_FK_PK, Me.colFGAPC_NUMORD})
        Me.GV21.GridControl = Me.GC21
        Me.GV21.Name = "GV21"
        Me.GV21.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV21.OptionsView.ShowGroupPanel = False
        Me.GV21.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFGAPC_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFGAPC_FGA_CODE_FK_PK
        '
        Me.colFGAPC_FGA_CODE_FK_PK.Caption = "FGAPC_FGA_CODE_FK_PK"
        Me.colFGAPC_FGA_CODE_FK_PK.FieldName = "FGAPC_FGA_CODE_FK_PK"
        Me.colFGAPC_FGA_CODE_FK_PK.Name = "colFGAPC_FGA_CODE_FK_PK"
        '
        'colFGAPC_CDF_PC_CODE_FK_PK
        '
        Me.colFGAPC_CDF_PC_CODE_FK_PK.Caption = "Période critique"
        Me.colFGAPC_CDF_PC_CODE_FK_PK.ColumnEdit = Me.rp_FGAPC
        Me.colFGAPC_CDF_PC_CODE_FK_PK.FieldName = "FGAPC_CDF_PC_CODE_FK_PK"
        Me.colFGAPC_CDF_PC_CODE_FK_PK.Name = "colFGAPC_CDF_PC_CODE_FK_PK"
        Me.colFGAPC_CDF_PC_CODE_FK_PK.Visible = True
        Me.colFGAPC_CDF_PC_CODE_FK_PK.VisibleIndex = 0
        Me.colFGAPC_CDF_PC_CODE_FK_PK.Width = 702
        '
        'rp_FGAPC
        '
        Me.rp_FGAPC.AutoHeight = False
        Me.rp_FGAPC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FGAPC.Name = "rp_FGAPC"
        '
        'colFGAPC_NUMORD
        '
        Me.colFGAPC_NUMORD.Caption = "N°"
        Me.colFGAPC_NUMORD.FieldName = "FGAPC_NUMORD"
        Me.colFGAPC_NUMORD.Name = "colFGAPC_NUMORD"
        Me.colFGAPC_NUMORD.Visible = True
        Me.colFGAPC_NUMORD.VisibleIndex = 1
        Me.colFGAPC_NUMORD.Width = 50
        '
        'XtraTabPage7
        '
        Me.XtraTabPage7.Controls.Add(Me.Panel17)
        Me.XtraTabPage7.Controls.Add(Me.Panel16)
        Me.XtraTabPage7.Controls.Add(Me.Panel24)
        Me.XtraTabPage7.Name = "XtraTabPage7"
        Me.XtraTabPage7.Size = New System.Drawing.Size(494, 390)
        Me.XtraTabPage7.Tag = ""
        Me.XtraTabPage7.Text = "Recommandations"
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.Panel18)
        Me.Panel17.Controls.Add(Me.Panel19)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel17.Location = New System.Drawing.Point(0, 219)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(494, 171)
        Me.Panel17.TabIndex = 45
        Me.Panel17.Tag = ""
        '
        'Panel18
        '
        Me.Panel18.Controls.Add(Me.GC32)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel18.Location = New System.Drawing.Point(0, 24)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(494, 147)
        Me.Panel18.TabIndex = 38
        Me.Panel18.Tag = "[ADD][EDIT]"
        '
        'GC32
        '
        Me.GC32.DataMember = "FGATX7_FGA_TXRECOMMANDAT"
        Me.GC32.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC32.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC32.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC32.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC32.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC32.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC32.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC32.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC32.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC32.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC32.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC32.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC32.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC32.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC32.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC32.EmbeddedNavigator.Name = ""
        Me.GC32.EmbeddedNavigator.TextStringFormat = ""
        Me.GC32.Location = New System.Drawing.Point(0, 0)
        Me.GC32.MainView = Me.GV32
        Me.GC32.Name = "GC32"
        Me.GC32.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rm_Memo3})
        Me.GC32.Size = New System.Drawing.Size(494, 147)
        Me.GC32.TabIndex = 5
        Me.GC32.UseEmbeddedNavigator = True
        Me.GC32.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV32})
        '
        'GV32
        '
        Me.GV32.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGATX7_FGA_CODE_FK_PK, Me.colFGATX7_TEXTE})
        Me.GV32.GridControl = Me.GC32
        Me.GV32.GroupFormat = ""
        Me.GV32.GroupPanelText = " "
        Me.GV32.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GV32.Name = "GV32"
        Me.GV32.OptionsCustomization.AllowRowSizing = True
        Me.GV32.OptionsNavigation.AutoFocusNewRow = True
        Me.GV32.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV32.OptionsView.ShowColumnHeaders = False
        Me.GV32.OptionsView.ShowDetailButtons = False
        Me.GV32.OptionsView.ShowGroupPanel = False
        Me.GV32.OptionsView.ShowHorzLines = False
        Me.GV32.OptionsView.ShowIndicator = False
        Me.GV32.RowHeight = 195
        Me.GV32.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colFGATX7_FGA_CODE_FK_PK
        '
        Me.colFGATX7_FGA_CODE_FK_PK.Caption = "FGATX7_FGA_CODE_FK_PK"
        Me.colFGATX7_FGA_CODE_FK_PK.FieldName = "FGATX7_FGA_CODE_FK_PK"
        Me.colFGATX7_FGA_CODE_FK_PK.Name = "colFGATX7_FGA_CODE_FK_PK"
        '
        'colFGATX7_TEXTE
        '
        Me.colFGATX7_TEXTE.Caption = "FGATX7_TEXTE"
        Me.colFGATX7_TEXTE.ColumnEdit = Me.rm_Memo3
        Me.colFGATX7_TEXTE.FieldName = "FGATX7_TEXTE"
        Me.colFGATX7_TEXTE.Name = "colFGATX7_TEXTE"
        Me.colFGATX7_TEXTE.Visible = True
        Me.colFGATX7_TEXTE.VisibleIndex = 0
        '
        'rm_Memo3
        '
        Me.rm_Memo3.Name = "rm_Memo3"
        '
        'Panel19
        '
        Me.Panel19.Controls.Add(Me.LabelControl6)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel19.Location = New System.Drawing.Point(0, 0)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(494, 24)
        Me.Panel19.TabIndex = 37
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(4, 8)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl6.TabIndex = 19
        Me.LabelControl6.Text = "Texte"
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.GC31)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel16.Location = New System.Drawing.Point(0, 60)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(494, 159)
        Me.Panel16.TabIndex = 40
        '
        'GC31
        '
        Me.GC31.DataMember = "FGARIG_RISQUE_GROSSESSE"
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
        Me.GC31.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FGARIG_CDF_RI, Me.rp_FGARIG_CDF_TC})
        Me.GC31.Size = New System.Drawing.Size(494, 159)
        Me.GC31.TabIndex = 2
        Me.GC31.Tag = "[EDIT][ADD]"
        Me.GC31.UseEmbeddedNavigator = True
        Me.GC31.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV31})
        '
        'GV31
        '
        Me.GV31.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGARIG_FGA_CODE_FK_PK, Me.colFGARIG_NUMSEQ_PK, Me.colFGARIG_CDF_RI_CODE_FK, Me.colFGARIG_CDF_TC_CODE_FK, Me.colFGARIG_NUMORD})
        Me.GV31.GridControl = Me.GC31
        Me.GV31.Name = "GV31"
        Me.GV31.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV31.OptionsView.ShowGroupPanel = False
        Me.GV31.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFGARIG_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFGARIG_FGA_CODE_FK_PK
        '
        Me.colFGARIG_FGA_CODE_FK_PK.Caption = "FGARIG_FGA_CODE_FK_PK"
        Me.colFGARIG_FGA_CODE_FK_PK.FieldName = "FGARIG_FGA_CODE_FK_PK"
        Me.colFGARIG_FGA_CODE_FK_PK.Name = "colFGARIG_FGA_CODE_FK_PK"
        '
        'colFGARIG_NUMSEQ_PK
        '
        Me.colFGARIG_NUMSEQ_PK.Caption = "FGARIG_NUMSEQ_PK"
        Me.colFGARIG_NUMSEQ_PK.FieldName = "FGARIG_NUMSEQ_PK"
        Me.colFGARIG_NUMSEQ_PK.Name = "colFGARIG_NUMSEQ_PK"
        '
        'colFGARIG_CDF_RI_CODE_FK
        '
        Me.colFGARIG_CDF_RI_CODE_FK.Caption = "N° - Recommandations"
        Me.colFGARIG_CDF_RI_CODE_FK.ColumnEdit = Me.rp_FGARIG_CDF_RI
        Me.colFGARIG_CDF_RI_CODE_FK.FieldName = "FGARIG_CDF_RI_CODE_FK"
        Me.colFGARIG_CDF_RI_CODE_FK.Name = "colFGARIG_CDF_RI_CODE_FK"
        Me.colFGARIG_CDF_RI_CODE_FK.Visible = True
        Me.colFGARIG_CDF_RI_CODE_FK.VisibleIndex = 0
        Me.colFGARIG_CDF_RI_CODE_FK.Width = 349
        '
        'rp_FGARIG_CDF_RI
        '
        Me.rp_FGARIG_CDF_RI.AutoHeight = False
        Me.rp_FGARIG_CDF_RI.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FGARIG_CDF_RI.Name = "rp_FGARIG_CDF_RI"
        '
        'colFGARIG_CDF_TC_CODE_FK
        '
        Me.colFGARIG_CDF_TC_CODE_FK.Caption = "Périodes concernées"
        Me.colFGARIG_CDF_TC_CODE_FK.ColumnEdit = Me.rp_FGARIG_CDF_TC
        Me.colFGARIG_CDF_TC_CODE_FK.FieldName = "FGARIG_CDF_TC_CODE_FK"
        Me.colFGARIG_CDF_TC_CODE_FK.Name = "colFGARIG_CDF_TC_CODE_FK"
        Me.colFGARIG_CDF_TC_CODE_FK.Visible = True
        Me.colFGARIG_CDF_TC_CODE_FK.VisibleIndex = 1
        Me.colFGARIG_CDF_TC_CODE_FK.Width = 353
        '
        'rp_FGARIG_CDF_TC
        '
        Me.rp_FGARIG_CDF_TC.AutoHeight = False
        Me.rp_FGARIG_CDF_TC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FGARIG_CDF_TC.Name = "rp_FGARIG_CDF_TC"
        '
        'colFGARIG_NUMORD
        '
        Me.colFGARIG_NUMORD.Caption = "N°"
        Me.colFGARIG_NUMORD.FieldName = "FGARIG_NUMORD"
        Me.colFGARIG_NUMORD.Name = "colFGARIG_NUMORD"
        Me.colFGARIG_NUMORD.Visible = True
        Me.colFGARIG_NUMORD.VisibleIndex = 2
        Me.colFGARIG_NUMORD.Width = 50
        '
        'Panel24
        '
        Me.Panel24.Controls.Add(Me.Panel26)
        Me.Panel24.Controls.Add(Me.Panel25)
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel24.Location = New System.Drawing.Point(0, 0)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(494, 60)
        Me.Panel24.TabIndex = 39
        Me.Panel24.Tag = ""
        '
        'Panel26
        '
        Me.Panel26.Controls.Add(Me.RadioGroup1)
        Me.Panel26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel26.Location = New System.Drawing.Point(0, 21)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(494, 39)
        Me.Panel26.TabIndex = 3
        Me.Panel26.Tag = "[EDIT][ADD]"
        '
        'RadioGroup1
        '
        Me.RadioGroup1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Grossesse_Allaitement, "FGA_FICHEGRAL.FGA_TYPEEFFET", True))
        Me.RadioGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioGroup1.EditValue = 1
        Me.RadioGroup1.Location = New System.Drawing.Point(0, 0)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("1", "Classe"), New DevExpress.XtraEditors.Controls.RadioGroupItem("2", "Spécialités"), New DevExpress.XtraEditors.Controls.RadioGroupItem("3", "Substance active"), New DevExpress.XtraEditors.Controls.RadioGroupItem("4", "Excipients")})
        Me.RadioGroup1.Size = New System.Drawing.Size(494, 39)
        Me.RadioGroup1.TabIndex = 0
        Me.RadioGroup1.Tag = "[EDIT][ADD]"
        '
        'Panel25
        '
        Me.Panel25.Controls.Add(Me.LabelControl5)
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel25.Location = New System.Drawing.Point(0, 0)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(494, 21)
        Me.Panel25.TabIndex = 2
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(4, 7)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl5.TabIndex = 1
        Me.LabelControl5.Text = "Effets"
        '
        'XtraTabPage8
        '
        Me.XtraTabPage8.Controls.Add(Me.TableLayoutPanel3)
        Me.XtraTabPage8.Name = "XtraTabPage8"
        Me.XtraTabPage8.Size = New System.Drawing.Size(494, 390)
        Me.XtraTabPage8.Text = "Conduite à tenir"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel33, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(494, 390)
        Me.TableLayoutPanel3.TabIndex = 53
        '
        'Panel33
        '
        Me.Panel33.Controls.Add(Me.GC45)
        Me.Panel33.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel33.Location = New System.Drawing.Point(3, 262)
        Me.Panel33.Name = "Panel33"
        Me.Panel33.Size = New System.Drawing.Size(488, 125)
        Me.Panel33.TabIndex = 49
        '
        'GC45
        '
        Me.GC45.DataMember = "FGAAFS_FGA_AFSSAPS"
        Me.GC45.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC45.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC45.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC45.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC45.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC45.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC45.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC45.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC45.EmbeddedNavigator.Name = ""
        Me.GC45.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC45.Location = New System.Drawing.Point(0, 0)
        Me.GC45.MainView = Me.GV45
        Me.GC45.Name = "GC45"
        Me.GC45.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FGAAFS1, Me.rp_FGAAFS1_SP})
        Me.GC45.Size = New System.Drawing.Size(488, 125)
        Me.GC45.TabIndex = 2
        Me.GC45.Tag = "[EDIT][ADD]"
        Me.GC45.UseEmbeddedNavigator = True
        Me.GC45.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV45})
        '
        'GV45
        '
        Me.GV45.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGAAFS_FGA_CODE_FK_PK1, Me.colFGAAFS_SP_CODE_FK_PK1, Me.colFGAAFS_DATE_PK1, Me.colFGAAFS_TYPEGRAL_PK1, Me.colFGAAFS_CDF_DOCUMENT_FK_PK1})
        Me.GV45.GridControl = Me.GC45
        Me.GV45.Name = "GV45"
        Me.GV45.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV45.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV45.OptionsView.ShowGroupPanel = False
        '
        'colFGAAFS_FGA_CODE_FK_PK1
        '
        Me.colFGAAFS_FGA_CODE_FK_PK1.Caption = "FGAAFS_FGA_CODE_FK_PK"
        Me.colFGAAFS_FGA_CODE_FK_PK1.FieldName = "FGAAFS_FGA_CODE_FK_PK"
        Me.colFGAAFS_FGA_CODE_FK_PK1.Name = "colFGAAFS_FGA_CODE_FK_PK1"
        '
        'colFGAAFS_SP_CODE_FK_PK1
        '
        Me.colFGAAFS_SP_CODE_FK_PK1.Caption = "Spécialités"
        Me.colFGAAFS_SP_CODE_FK_PK1.ColumnEdit = Me.rp_FGAAFS1_SP
        Me.colFGAAFS_SP_CODE_FK_PK1.FieldName = "FGAAFS_SP_CODE_FK_PK"
        Me.colFGAAFS_SP_CODE_FK_PK1.Name = "colFGAAFS_SP_CODE_FK_PK1"
        Me.colFGAAFS_SP_CODE_FK_PK1.Visible = True
        Me.colFGAAFS_SP_CODE_FK_PK1.VisibleIndex = 2
        Me.colFGAAFS_SP_CODE_FK_PK1.Width = 295
        '
        'rp_FGAAFS1_SP
        '
        Me.rp_FGAAFS1_SP.AutoHeight = False
        Me.rp_FGAAFS1_SP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FGAAFS1_SP.Name = "rp_FGAAFS1_SP"
        Me.rp_FGAAFS1_SP.NullText = ""
        '
        'colFGAAFS_DATE_PK1
        '
        Me.colFGAAFS_DATE_PK1.Caption = "Date"
        Me.colFGAAFS_DATE_PK1.FieldName = "FGAAFS_DATE_PK"
        Me.colFGAAFS_DATE_PK1.Name = "colFGAAFS_DATE_PK1"
        Me.colFGAAFS_DATE_PK1.Visible = True
        Me.colFGAAFS_DATE_PK1.VisibleIndex = 1
        Me.colFGAAFS_DATE_PK1.Width = 69
        '
        'colFGAAFS_TYPEGRAL_PK1
        '
        Me.colFGAAFS_TYPEGRAL_PK1.Caption = "FGAAFS_TYPEGRAL_PK"
        Me.colFGAAFS_TYPEGRAL_PK1.FieldName = "FGAAFS_TYPEGRAL_PK"
        Me.colFGAAFS_TYPEGRAL_PK1.Name = "colFGAAFS_TYPEGRAL_PK1"
        '
        'colFGAAFS_CDF_DOCUMENT_FK_PK1
        '
        Me.colFGAAFS_CDF_DOCUMENT_FK_PK1.Caption = "Références officielles"
        Me.colFGAAFS_CDF_DOCUMENT_FK_PK1.ColumnEdit = Me.rp_FGAAFS1
        Me.colFGAAFS_CDF_DOCUMENT_FK_PK1.FieldName = "FGAAFS_CDF_DOCUMENT_FK_PK"
        Me.colFGAAFS_CDF_DOCUMENT_FK_PK1.Name = "colFGAAFS_CDF_DOCUMENT_FK_PK1"
        Me.colFGAAFS_CDF_DOCUMENT_FK_PK1.Visible = True
        Me.colFGAAFS_CDF_DOCUMENT_FK_PK1.VisibleIndex = 0
        Me.colFGAAFS_CDF_DOCUMENT_FK_PK1.Width = 298
        '
        'rp_FGAAFS1
        '
        Me.rp_FGAAFS1.AutoHeight = False
        Me.rp_FGAAFS1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FGAAFS1.Name = "rp_FGAAFS1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel21, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel20, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(488, 123)
        Me.TableLayoutPanel1.TabIndex = 51
        '
        'Panel21
        '
        Me.Panel21.Controls.Add(Me.Panel22)
        Me.Panel21.Controls.Add(Me.Panel23)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel21.Location = New System.Drawing.Point(247, 3)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(238, 117)
        Me.Panel21.TabIndex = 46
        Me.Panel21.Tag = ""
        '
        'Panel22
        '
        Me.Panel22.Controls.Add(Me.GC42)
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel22.Location = New System.Drawing.Point(0, 24)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(238, 93)
        Me.Panel22.TabIndex = 38
        Me.Panel22.Tag = "[ADD][EDIT]"
        '
        'GC42
        '
        Me.GC42.DataMember = "FGATX4_FGA_TXCONDATENIRCF"
        Me.GC42.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC42.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC42.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC42.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC42.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC42.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC42.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC42.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC42.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC42.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC42.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC42.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC42.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC42.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC42.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC42.EmbeddedNavigator.Name = ""
        Me.GC42.EmbeddedNavigator.TextStringFormat = ""
        Me.GC42.Location = New System.Drawing.Point(0, 0)
        Me.GC42.MainView = Me.GV42
        Me.GC42.Name = "GC42"
        Me.GC42.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rm_Memo4})
        Me.GC42.Size = New System.Drawing.Size(238, 93)
        Me.GC42.TabIndex = 5
        Me.GC42.UseEmbeddedNavigator = True
        Me.GC42.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV42})
        '
        'GV42
        '
        Me.GV42.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGATX4_FGA_CODE_FK_PK, Me.colFGATX4_TEXTE})
        Me.GV42.GridControl = Me.GC42
        Me.GV42.GroupFormat = ""
        Me.GV42.GroupPanelText = " "
        Me.GV42.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GV42.Name = "GV42"
        Me.GV42.OptionsCustomization.AllowRowSizing = True
        Me.GV42.OptionsNavigation.AutoFocusNewRow = True
        Me.GV42.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV42.OptionsView.ShowColumnHeaders = False
        Me.GV42.OptionsView.ShowDetailButtons = False
        Me.GV42.OptionsView.ShowGroupPanel = False
        Me.GV42.OptionsView.ShowHorzLines = False
        Me.GV42.OptionsView.ShowIndicator = False
        Me.GV42.RowHeight = 90
        Me.GV42.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colFGATX4_FGA_CODE_FK_PK
        '
        Me.colFGATX4_FGA_CODE_FK_PK.Caption = "FGATX4_FGA_CODE_FK_PK"
        Me.colFGATX4_FGA_CODE_FK_PK.FieldName = "FGATX4_FGA_CODE_FK_PK"
        Me.colFGATX4_FGA_CODE_FK_PK.Name = "colFGATX4_FGA_CODE_FK_PK"
        '
        'colFGATX4_TEXTE
        '
        Me.colFGATX4_TEXTE.Caption = "FGATX4_TEXTE"
        Me.colFGATX4_TEXTE.ColumnEdit = Me.rm_Memo4
        Me.colFGATX4_TEXTE.FieldName = "FGATX4_TEXTE"
        Me.colFGATX4_TEXTE.Name = "colFGATX4_TEXTE"
        Me.colFGATX4_TEXTE.Visible = True
        Me.colFGATX4_TEXTE.VisibleIndex = 0
        '
        'rm_Memo4
        '
        Me.rm_Memo4.Name = "rm_Memo4"
        '
        'Panel23
        '
        Me.Panel23.Controls.Add(Me.LabelControl8)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel23.Location = New System.Drawing.Point(0, 0)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(238, 24)
        Me.Panel23.TabIndex = 37
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(4, 8)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl8.TabIndex = 19
        Me.LabelControl8.Text = "Texte"
        '
        'Panel20
        '
        Me.Panel20.Controls.Add(Me.GC41)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel20.Location = New System.Drawing.Point(3, 3)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(238, 117)
        Me.Panel20.TabIndex = 41
        '
        'GC41
        '
        Me.GC41.DataMember = "FGACF_CATFEMMEENCEINTE"
        Me.GC41.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.GC41.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FGACF})
        Me.GC41.Size = New System.Drawing.Size(238, 117)
        Me.GC41.TabIndex = 2
        Me.GC41.Tag = "[EDIT][ADD]"
        Me.GC41.UseEmbeddedNavigator = True
        Me.GC41.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV41})
        '
        'GV41
        '
        Me.GV41.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGACF_FGA_CODE_FK_PK, Me.colFGACF_CDF_CAT_CODE_FK_PK, Me.colFGACF_NUMORD})
        Me.GV41.GridControl = Me.GC41
        Me.GV41.Name = "GV41"
        Me.GV41.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV41.OptionsView.ShowGroupPanel = False
        Me.GV41.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFGACF_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFGACF_FGA_CODE_FK_PK
        '
        Me.colFGACF_FGA_CODE_FK_PK.Caption = "FGACF_FGA_CODE_FK_PK"
        Me.colFGACF_FGA_CODE_FK_PK.FieldName = "FGACF_FGA_CODE_FK_PK"
        Me.colFGACF_FGA_CODE_FK_PK.Name = "colFGACF_FGA_CODE_FK_PK"
        '
        'colFGACF_CDF_CAT_CODE_FK_PK
        '
        Me.colFGACF_CDF_CAT_CODE_FK_PK.Caption = "Chez la femme enceinte "
        Me.colFGACF_CDF_CAT_CODE_FK_PK.ColumnEdit = Me.rp_FGACF
        Me.colFGACF_CDF_CAT_CODE_FK_PK.FieldName = "FGACF_CDF_CAT_CODE_FK_PK"
        Me.colFGACF_CDF_CAT_CODE_FK_PK.Name = "colFGACF_CDF_CAT_CODE_FK_PK"
        Me.colFGACF_CDF_CAT_CODE_FK_PK.Visible = True
        Me.colFGACF_CDF_CAT_CODE_FK_PK.VisibleIndex = 0
        Me.colFGACF_CDF_CAT_CODE_FK_PK.Width = 306
        '
        'rp_FGACF
        '
        Me.rp_FGACF.AutoHeight = False
        Me.rp_FGACF.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FGACF.Name = "rp_FGACF"
        '
        'colFGACF_NUMORD
        '
        Me.colFGACF_NUMORD.Caption = "N°"
        Me.colFGACF_NUMORD.FieldName = "FGACF_NUMORD"
        Me.colFGACF_NUMORD.Name = "colFGACF_NUMORD"
        Me.colFGACF_NUMORD.Visible = True
        Me.colFGACF_NUMORD.VisibleIndex = 1
        Me.colFGACF_NUMORD.Width = 52
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel29, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel30, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 132)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(488, 124)
        Me.TableLayoutPanel2.TabIndex = 52
        '
        'Panel29
        '
        Me.Panel29.Controls.Add(Me.GC43)
        Me.Panel29.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel29.Location = New System.Drawing.Point(3, 3)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(238, 118)
        Me.Panel29.TabIndex = 47
        '
        'GC43
        '
        Me.GC43.DataMember = "FGACN_CATNOUVEAUNE"
        Me.GC43.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC43.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC43.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC43.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC43.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC43.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC43.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC43.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC43.EmbeddedNavigator.Name = ""
        Me.GC43.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC43.Location = New System.Drawing.Point(0, 0)
        Me.GC43.MainView = Me.GV43
        Me.GC43.Name = "GC43"
        Me.GC43.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FGACN})
        Me.GC43.Size = New System.Drawing.Size(238, 118)
        Me.GC43.TabIndex = 2
        Me.GC43.Tag = "[EDIT][ADD]"
        Me.GC43.UseEmbeddedNavigator = True
        Me.GC43.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV43})
        '
        'GV43
        '
        Me.GV43.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGACN_FGA_CODE_FK_PK, Me.colFGACN_CDF_CAT_CODE_FK_PK, Me.colFGACN_NUMORD})
        Me.GV43.GridControl = Me.GC43
        Me.GV43.Name = "GV43"
        Me.GV43.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV43.OptionsView.ShowGroupPanel = False
        Me.GV43.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFGACN_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFGACN_FGA_CODE_FK_PK
        '
        Me.colFGACN_FGA_CODE_FK_PK.Caption = "FGACN_FGA_CODE_FK_PK"
        Me.colFGACN_FGA_CODE_FK_PK.FieldName = "FGACN_FGA_CODE_FK_PK"
        Me.colFGACN_FGA_CODE_FK_PK.Name = "colFGACN_FGA_CODE_FK_PK"
        '
        'colFGACN_CDF_CAT_CODE_FK_PK
        '
        Me.colFGACN_CDF_CAT_CODE_FK_PK.Caption = "Chez le nouveau- né"
        Me.colFGACN_CDF_CAT_CODE_FK_PK.ColumnEdit = Me.rp_FGACN
        Me.colFGACN_CDF_CAT_CODE_FK_PK.FieldName = "FGACN_CDF_CAT_CODE_FK_PK"
        Me.colFGACN_CDF_CAT_CODE_FK_PK.Name = "colFGACN_CDF_CAT_CODE_FK_PK"
        Me.colFGACN_CDF_CAT_CODE_FK_PK.Visible = True
        Me.colFGACN_CDF_CAT_CODE_FK_PK.VisibleIndex = 0
        Me.colFGACN_CDF_CAT_CODE_FK_PK.Width = 309
        '
        'rp_FGACN
        '
        Me.rp_FGACN.AutoHeight = False
        Me.rp_FGACN.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FGACN.Name = "rp_FGACN"
        '
        'colFGACN_NUMORD
        '
        Me.colFGACN_NUMORD.Caption = "N°"
        Me.colFGACN_NUMORD.FieldName = "FGACN_NUMORD"
        Me.colFGACN_NUMORD.Name = "colFGACN_NUMORD"
        Me.colFGACN_NUMORD.Visible = True
        Me.colFGACN_NUMORD.VisibleIndex = 1
        Me.colFGACN_NUMORD.Width = 49
        '
        'Panel30
        '
        Me.Panel30.Controls.Add(Me.Panel31)
        Me.Panel30.Controls.Add(Me.Panel32)
        Me.Panel30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel30.Location = New System.Drawing.Point(247, 3)
        Me.Panel30.Name = "Panel30"
        Me.Panel30.Size = New System.Drawing.Size(238, 118)
        Me.Panel30.TabIndex = 48
        Me.Panel30.Tag = ""
        '
        'Panel31
        '
        Me.Panel31.Controls.Add(Me.GC44)
        Me.Panel31.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel31.Location = New System.Drawing.Point(0, 24)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(238, 94)
        Me.Panel31.TabIndex = 38
        Me.Panel31.Tag = "[ADD][EDIT]"
        '
        'GC44
        '
        Me.GC44.DataMember = "FGATX5_FGA_TXCONDATENIRCN"
        Me.GC44.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC44.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC44.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC44.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC44.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC44.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC44.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC44.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC44.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC44.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC44.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC44.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC44.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC44.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC44.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC44.EmbeddedNavigator.Name = ""
        Me.GC44.EmbeddedNavigator.TextStringFormat = ""
        Me.GC44.Location = New System.Drawing.Point(0, 0)
        Me.GC44.MainView = Me.GV44
        Me.GC44.Name = "GC44"
        Me.GC44.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rm_Memo5})
        Me.GC44.Size = New System.Drawing.Size(238, 94)
        Me.GC44.TabIndex = 5
        Me.GC44.UseEmbeddedNavigator = True
        Me.GC44.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV44})
        '
        'GV44
        '
        Me.GV44.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGATX5_FGA_CODE_FK_PK, Me.colFGATX5_TEXTE})
        Me.GV44.GridControl = Me.GC44
        Me.GV44.GroupFormat = ""
        Me.GV44.GroupPanelText = " "
        Me.GV44.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GV44.Name = "GV44"
        Me.GV44.OptionsCustomization.AllowRowSizing = True
        Me.GV44.OptionsNavigation.AutoFocusNewRow = True
        Me.GV44.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV44.OptionsView.ShowColumnHeaders = False
        Me.GV44.OptionsView.ShowDetailButtons = False
        Me.GV44.OptionsView.ShowGroupPanel = False
        Me.GV44.OptionsView.ShowHorzLines = False
        Me.GV44.OptionsView.ShowIndicator = False
        Me.GV44.RowHeight = 95
        Me.GV44.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colFGATX5_FGA_CODE_FK_PK
        '
        Me.colFGATX5_FGA_CODE_FK_PK.Caption = "FGATX5_FGA_CODE_FK_PK"
        Me.colFGATX5_FGA_CODE_FK_PK.FieldName = "FGATX5_FGA_CODE_FK_PK"
        Me.colFGATX5_FGA_CODE_FK_PK.Name = "colFGATX5_FGA_CODE_FK_PK"
        '
        'colFGATX5_TEXTE
        '
        Me.colFGATX5_TEXTE.Caption = "FGATX5_TEXTE"
        Me.colFGATX5_TEXTE.ColumnEdit = Me.rm_Memo5
        Me.colFGATX5_TEXTE.FieldName = "FGATX5_TEXTE"
        Me.colFGATX5_TEXTE.Name = "colFGATX5_TEXTE"
        Me.colFGATX5_TEXTE.Visible = True
        Me.colFGATX5_TEXTE.VisibleIndex = 0
        '
        'rm_Memo5
        '
        Me.rm_Memo5.Name = "rm_Memo5"
        '
        'Panel32
        '
        Me.Panel32.Controls.Add(Me.LabelControl9)
        Me.Panel32.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel32.Location = New System.Drawing.Point(0, 0)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(238, 24)
        Me.Panel32.TabIndex = 37
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(4, 8)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl9.TabIndex = 19
        Me.LabelControl9.Text = "Texte"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.GroupControl1)
        Me.XtraTabPage3.Controls.Add(Me.GroupControl2)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(503, 421)
        Me.XtraTabPage3.Text = "Femme en âge de procréer"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.Panel38)
        Me.GroupControl1.Controls.Add(Me.Panel41)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 236)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(503, 259)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.Text = "Conduite à tenir"
        '
        'Panel38
        '
        Me.Panel38.Controls.Add(Me.Panel39)
        Me.Panel38.Controls.Add(Me.Panel40)
        Me.Panel38.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel38.Location = New System.Drawing.Point(2, 117)
        Me.Panel38.Name = "Panel38"
        Me.Panel38.Size = New System.Drawing.Size(499, 140)
        Me.Panel38.TabIndex = 47
        Me.Panel38.Tag = ""
        '
        'Panel39
        '
        Me.Panel39.Controls.Add(Me.GC54)
        Me.Panel39.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel39.Location = New System.Drawing.Point(0, 24)
        Me.Panel39.Name = "Panel39"
        Me.Panel39.Size = New System.Drawing.Size(499, 116)
        Me.Panel39.TabIndex = 38
        Me.Panel39.Tag = "[ADD][EDIT]"
        '
        'GC54
        '
        Me.GC54.DataMember = "FGATX10_FGA_TXRECOMMANDAT"
        Me.GC54.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC54.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC54.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC54.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC54.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC54.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC54.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC54.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC54.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC54.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC54.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC54.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC54.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC54.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC54.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC54.EmbeddedNavigator.Name = ""
        Me.GC54.EmbeddedNavigator.TextStringFormat = ""
        Me.GC54.Location = New System.Drawing.Point(0, 0)
        Me.GC54.MainView = Me.GV54
        Me.GC54.Name = "GC54"
        Me.GC54.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rm_Memo7})
        Me.GC54.Size = New System.Drawing.Size(499, 116)
        Me.GC54.TabIndex = 5
        Me.GC54.UseEmbeddedNavigator = True
        Me.GC54.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV54})
        '
        'GV54
        '
        Me.GV54.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGATX10_FGA_CODE_FK_PK, Me.colFGATX10_TEXTE})
        Me.GV54.GridControl = Me.GC54
        Me.GV54.GroupFormat = ""
        Me.GV54.GroupPanelText = " "
        Me.GV54.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GV54.Name = "GV54"
        Me.GV54.OptionsCustomization.AllowRowSizing = True
        Me.GV54.OptionsNavigation.AutoFocusNewRow = True
        Me.GV54.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV54.OptionsView.ShowColumnHeaders = False
        Me.GV54.OptionsView.ShowDetailButtons = False
        Me.GV54.OptionsView.ShowGroupPanel = False
        Me.GV54.OptionsView.ShowHorzLines = False
        Me.GV54.OptionsView.ShowIndicator = False
        Me.GV54.RowHeight = 90
        Me.GV54.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colFGATX10_FGA_CODE_FK_PK
        '
        Me.colFGATX10_FGA_CODE_FK_PK.Caption = "FGATX10_FGA_CODE_FK_PK"
        Me.colFGATX10_FGA_CODE_FK_PK.FieldName = "FGATX10_FGA_CODE_FK_PK"
        Me.colFGATX10_FGA_CODE_FK_PK.Name = "colFGATX10_FGA_CODE_FK_PK"
        '
        'colFGATX10_TEXTE
        '
        Me.colFGATX10_TEXTE.Caption = "FGATX10_TEXTE"
        Me.colFGATX10_TEXTE.ColumnEdit = Me.rm_Memo7
        Me.colFGATX10_TEXTE.FieldName = "FGATX10_TEXTE"
        Me.colFGATX10_TEXTE.Name = "colFGATX10_TEXTE"
        Me.colFGATX10_TEXTE.Visible = True
        Me.colFGATX10_TEXTE.VisibleIndex = 0
        '
        'rm_Memo7
        '
        Me.rm_Memo7.Name = "rm_Memo7"
        '
        'Panel40
        '
        Me.Panel40.Controls.Add(Me.LabelControl11)
        Me.Panel40.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel40.Location = New System.Drawing.Point(0, 0)
        Me.Panel40.Name = "Panel40"
        Me.Panel40.Size = New System.Drawing.Size(499, 24)
        Me.Panel40.TabIndex = 37
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(4, 8)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl11.TabIndex = 19
        Me.LabelControl11.Text = "Texte"
        '
        'Panel41
        '
        Me.Panel41.Controls.Add(Me.GC53)
        Me.Panel41.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel41.Location = New System.Drawing.Point(2, 21)
        Me.Panel41.Name = "Panel41"
        Me.Panel41.Size = New System.Drawing.Size(499, 96)
        Me.Panel41.TabIndex = 41
        '
        'GC53
        '
        Me.GC53.DataMember = "FGACFAP_CATFEMMEENAGE"
        Me.GC53.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC53.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC53.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC53.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC53.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC53.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC53.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC53.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC53.EmbeddedNavigator.Name = ""
        Me.GC53.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC53.Location = New System.Drawing.Point(0, 0)
        Me.GC53.MainView = Me.GV53
        Me.GC53.Name = "GC53"
        Me.GC53.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FGACFAP})
        Me.GC53.Size = New System.Drawing.Size(499, 96)
        Me.GC53.TabIndex = 2
        Me.GC53.Tag = "[EDIT][ADD]"
        Me.GC53.UseEmbeddedNavigator = True
        Me.GC53.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV53})
        '
        'GV53
        '
        Me.GV53.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGACFAP_FGA_CODE_FK_PK, Me.colFGACFAP_CDF_CAT_CODE_FK_PK, Me.colFGACFAP_NUMORD})
        Me.GV53.GridControl = Me.GC53
        Me.GV53.Name = "GV53"
        Me.GV53.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV53.OptionsView.ShowGroupPanel = False
        Me.GV53.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFGACFAP_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFGACFAP_FGA_CODE_FK_PK
        '
        Me.colFGACFAP_FGA_CODE_FK_PK.Caption = "FGACFAP_FGA_CODE_FK_PK"
        Me.colFGACFAP_FGA_CODE_FK_PK.FieldName = "FGACFAP_FGA_CODE_FK_PK"
        Me.colFGACFAP_FGA_CODE_FK_PK.Name = "colFGACFAP_FGA_CODE_FK_PK"
        '
        'colFGACFAP_CDF_CAT_CODE_FK_PK
        '
        Me.colFGACFAP_CDF_CAT_CODE_FK_PK.Caption = "Conduite à tenir"
        Me.colFGACFAP_CDF_CAT_CODE_FK_PK.ColumnEdit = Me.rp_FGACFAP
        Me.colFGACFAP_CDF_CAT_CODE_FK_PK.FieldName = "FGACFAP_CDF_CAT_CODE_FK_PK"
        Me.colFGACFAP_CDF_CAT_CODE_FK_PK.Name = "colFGACFAP_CDF_CAT_CODE_FK_PK"
        Me.colFGACFAP_CDF_CAT_CODE_FK_PK.Visible = True
        Me.colFGACFAP_CDF_CAT_CODE_FK_PK.VisibleIndex = 0
        Me.colFGACFAP_CDF_CAT_CODE_FK_PK.Width = 707
        '
        'rp_FGACFAP
        '
        Me.rp_FGACFAP.AutoHeight = False
        Me.rp_FGACFAP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FGACFAP.Name = "rp_FGACFAP"
        '
        'colFGACFAP_NUMORD
        '
        Me.colFGACFAP_NUMORD.Caption = "N°"
        Me.colFGACFAP_NUMORD.FieldName = "FGACFAP_NUMORD"
        Me.colFGACFAP_NUMORD.Name = "colFGACFAP_NUMORD"
        Me.colFGACFAP_NUMORD.Visible = True
        Me.colFGACFAP_NUMORD.VisibleIndex = 1
        Me.colFGACFAP_NUMORD.Width = 50
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.Panel35)
        Me.GroupControl2.Controls.Add(Me.Panel34)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(503, 236)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Recommandations"
        '
        'Panel35
        '
        Me.Panel35.Controls.Add(Me.Panel36)
        Me.Panel35.Controls.Add(Me.Panel37)
        Me.Panel35.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel35.Location = New System.Drawing.Point(2, 117)
        Me.Panel35.Name = "Panel35"
        Me.Panel35.Size = New System.Drawing.Size(499, 117)
        Me.Panel35.TabIndex = 47
        Me.Panel35.Tag = ""
        '
        'Panel36
        '
        Me.Panel36.Controls.Add(Me.GC52)
        Me.Panel36.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel36.Location = New System.Drawing.Point(0, 24)
        Me.Panel36.Name = "Panel36"
        Me.Panel36.Size = New System.Drawing.Size(499, 93)
        Me.Panel36.TabIndex = 38
        Me.Panel36.Tag = "[ADD][EDIT]"
        '
        'GC52
        '
        Me.GC52.DataMember = "FGATX9_FGA_TXRECOMMANDAT"
        Me.GC52.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC52.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC52.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC52.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC52.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC52.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC52.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC52.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC52.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC52.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC52.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC52.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC52.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC52.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC52.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC52.EmbeddedNavigator.Name = ""
        Me.GC52.EmbeddedNavigator.TextStringFormat = ""
        Me.GC52.Location = New System.Drawing.Point(0, 0)
        Me.GC52.MainView = Me.GV52
        Me.GC52.Name = "GC52"
        Me.GC52.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rm_Memo6})
        Me.GC52.Size = New System.Drawing.Size(499, 93)
        Me.GC52.TabIndex = 5
        Me.GC52.UseEmbeddedNavigator = True
        Me.GC52.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV52})
        '
        'GV52
        '
        Me.GV52.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGATX9_FGA_CODE_FK_PK, Me.colFGATX9_TEXTE})
        Me.GV52.GridControl = Me.GC52
        Me.GV52.GroupFormat = ""
        Me.GV52.GroupPanelText = " "
        Me.GV52.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GV52.Name = "GV52"
        Me.GV52.OptionsCustomization.AllowRowSizing = True
        Me.GV52.OptionsNavigation.AutoFocusNewRow = True
        Me.GV52.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV52.OptionsView.ShowColumnHeaders = False
        Me.GV52.OptionsView.ShowDetailButtons = False
        Me.GV52.OptionsView.ShowGroupPanel = False
        Me.GV52.OptionsView.ShowHorzLines = False
        Me.GV52.OptionsView.ShowIndicator = False
        Me.GV52.RowHeight = 67
        Me.GV52.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colFGATX9_FGA_CODE_FK_PK
        '
        Me.colFGATX9_FGA_CODE_FK_PK.Caption = "FGATX9_FGA_CODE_FK_PK"
        Me.colFGATX9_FGA_CODE_FK_PK.FieldName = "FGATX9_FGA_CODE_FK_PK"
        Me.colFGATX9_FGA_CODE_FK_PK.Name = "colFGATX9_FGA_CODE_FK_PK"
        '
        'colFGATX9_TEXTE
        '
        Me.colFGATX9_TEXTE.Caption = "FGATX9_TEXTE"
        Me.colFGATX9_TEXTE.ColumnEdit = Me.rm_Memo6
        Me.colFGATX9_TEXTE.FieldName = "FGATX9_TEXTE"
        Me.colFGATX9_TEXTE.Name = "colFGATX9_TEXTE"
        Me.colFGATX9_TEXTE.Visible = True
        Me.colFGATX9_TEXTE.VisibleIndex = 0
        '
        'rm_Memo6
        '
        Me.rm_Memo6.Name = "rm_Memo6"
        '
        'Panel37
        '
        Me.Panel37.Controls.Add(Me.LabelControl10)
        Me.Panel37.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel37.Location = New System.Drawing.Point(0, 0)
        Me.Panel37.Name = "Panel37"
        Me.Panel37.Size = New System.Drawing.Size(499, 24)
        Me.Panel37.TabIndex = 37
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(4, 8)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Texte"
        '
        'Panel34
        '
        Me.Panel34.Controls.Add(Me.GC51)
        Me.Panel34.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel34.Location = New System.Drawing.Point(2, 21)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(499, 96)
        Me.Panel34.TabIndex = 41
        '
        'GC51
        '
        Me.GC51.DataMember = "FGARIFAP_RISQUEFEMMEENAGE"
        Me.GC51.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.GC51.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FGARIFAP})
        Me.GC51.Size = New System.Drawing.Size(499, 96)
        Me.GC51.TabIndex = 2
        Me.GC51.Tag = "[EDIT][ADD]"
        Me.GC51.UseEmbeddedNavigator = True
        Me.GC51.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV51})
        '
        'GV51
        '
        Me.GV51.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGARIFAP_FGA_CODE_FK_PK, Me.colFGARIFAP_CDF_RI_CODE_FK_PK, Me.colFGARIFAP_NUMORD})
        Me.GV51.GridControl = Me.GC51
        Me.GV51.Name = "GV51"
        Me.GV51.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV51.OptionsView.ShowGroupPanel = False
        Me.GV51.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFGARIFAP_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFGARIFAP_FGA_CODE_FK_PK
        '
        Me.colFGARIFAP_FGA_CODE_FK_PK.Caption = "FGARIFAP_FGA_CODE_FK_PK"
        Me.colFGARIFAP_FGA_CODE_FK_PK.FieldName = "FGARIFAP_FGA_CODE_FK_PK"
        Me.colFGARIFAP_FGA_CODE_FK_PK.Name = "colFGARIFAP_FGA_CODE_FK_PK"
        '
        'colFGARIFAP_CDF_RI_CODE_FK_PK
        '
        Me.colFGARIFAP_CDF_RI_CODE_FK_PK.Caption = "Recommandations"
        Me.colFGARIFAP_CDF_RI_CODE_FK_PK.ColumnEdit = Me.rp_FGARIFAP
        Me.colFGARIFAP_CDF_RI_CODE_FK_PK.FieldName = "FGARIFAP_CDF_RI_CODE_FK_PK"
        Me.colFGARIFAP_CDF_RI_CODE_FK_PK.Name = "colFGARIFAP_CDF_RI_CODE_FK_PK"
        Me.colFGARIFAP_CDF_RI_CODE_FK_PK.Visible = True
        Me.colFGARIFAP_CDF_RI_CODE_FK_PK.VisibleIndex = 0
        Me.colFGARIFAP_CDF_RI_CODE_FK_PK.Width = 707
        '
        'rp_FGARIFAP
        '
        Me.rp_FGARIFAP.AutoHeight = False
        Me.rp_FGARIFAP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FGARIFAP.Name = "rp_FGARIFAP"
        '
        'colFGARIFAP_NUMORD
        '
        Me.colFGARIFAP_NUMORD.Caption = "N°"
        Me.colFGARIFAP_NUMORD.FieldName = "FGARIFAP_NUMORD"
        Me.colFGARIFAP_NUMORD.Name = "colFGARIFAP_NUMORD"
        Me.colFGARIFAP_NUMORD.Visible = True
        Me.colFGARIFAP_NUMORD.VisibleIndex = 1
        Me.colFGARIFAP_NUMORD.Width = 50
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.XtraTabControl3)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(503, 421)
        Me.XtraTabPage4.Text = "Allaitement"
        '
        'XtraTabControl3
        '
        Me.XtraTabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl3.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl3.Name = "XtraTabControl3"
        Me.XtraTabControl3.SelectedTabPage = Me.XtraTabPage9
        Me.XtraTabControl3.Size = New System.Drawing.Size(503, 421)
        Me.XtraTabControl3.TabIndex = 1
        Me.XtraTabControl3.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage9, Me.XtraTabPage11, Me.XtraTabPage12})
        Me.XtraTabControl3.Text = "XtraTabControl3"
        '
        'XtraTabPage9
        '
        Me.XtraTabPage9.Controls.Add(Me.GroupControl4)
        Me.XtraTabPage9.Controls.Add(Me.GroupControl3)
        Me.XtraTabPage9.Name = "XtraTabPage9"
        Me.XtraTabPage9.Size = New System.Drawing.Size(494, 390)
        Me.XtraTabPage9.Text = "Passage dans le lait maternel / Observations"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.Panel43)
        Me.GroupControl4.Controls.Add(Me.Panel42)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(0, 139)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(494, 251)
        Me.GroupControl4.TabIndex = 32
        Me.GroupControl4.Text = "Observations chez le nouveau-né"
        '
        'Panel43
        '
        Me.Panel43.Controls.Add(Me.Panel44)
        Me.Panel43.Controls.Add(Me.Panel45)
        Me.Panel43.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel43.Location = New System.Drawing.Point(2, 157)
        Me.Panel43.Name = "Panel43"
        Me.Panel43.Size = New System.Drawing.Size(490, 92)
        Me.Panel43.TabIndex = 48
        Me.Panel43.Tag = ""
        '
        'Panel44
        '
        Me.Panel44.Controls.Add(Me.GC63)
        Me.Panel44.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel44.Location = New System.Drawing.Point(0, 24)
        Me.Panel44.Name = "Panel44"
        Me.Panel44.Size = New System.Drawing.Size(490, 68)
        Me.Panel44.TabIndex = 38
        Me.Panel44.Tag = "[ADD][EDIT]"
        '
        'GC63
        '
        Me.GC63.DataMember = "FGATX2_FGA_TXOBSERVNOUVNE"
        Me.GC63.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC63.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC63.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC63.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC63.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC63.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC63.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC63.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC63.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC63.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC63.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC63.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC63.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC63.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC63.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC63.EmbeddedNavigator.Name = ""
        Me.GC63.EmbeddedNavigator.TextStringFormat = ""
        Me.GC63.Location = New System.Drawing.Point(0, 0)
        Me.GC63.MainView = Me.GV63
        Me.GC63.Name = "GC63"
        Me.GC63.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rm_Memo8})
        Me.GC63.Size = New System.Drawing.Size(490, 68)
        Me.GC63.TabIndex = 5
        Me.GC63.UseEmbeddedNavigator = True
        Me.GC63.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV63})
        '
        'GV63
        '
        Me.GV63.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGATX2_FGA_CODE_FK_PK, Me.colFGATX2_TEXTE})
        Me.GV63.GridControl = Me.GC63
        Me.GV63.GroupFormat = ""
        Me.GV63.GroupPanelText = " "
        Me.GV63.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GV63.Name = "GV63"
        Me.GV63.OptionsCustomization.AllowRowSizing = True
        Me.GV63.OptionsNavigation.AutoFocusNewRow = True
        Me.GV63.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV63.OptionsView.ShowColumnHeaders = False
        Me.GV63.OptionsView.ShowDetailButtons = False
        Me.GV63.OptionsView.ShowGroupPanel = False
        Me.GV63.OptionsView.ShowHorzLines = False
        Me.GV63.OptionsView.ShowIndicator = False
        Me.GV63.RowHeight = 115
        Me.GV63.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colFGATX2_FGA_CODE_FK_PK
        '
        Me.colFGATX2_FGA_CODE_FK_PK.Caption = "FGATX2_FGA_CODE_FK_PK"
        Me.colFGATX2_FGA_CODE_FK_PK.FieldName = "FGATX2_FGA_CODE_FK_PK"
        Me.colFGATX2_FGA_CODE_FK_PK.Name = "colFGATX2_FGA_CODE_FK_PK"
        '
        'colFGATX2_TEXTE
        '
        Me.colFGATX2_TEXTE.Caption = "FGATX2_TEXTE"
        Me.colFGATX2_TEXTE.ColumnEdit = Me.rm_Memo8
        Me.colFGATX2_TEXTE.FieldName = "FGATX2_TEXTE"
        Me.colFGATX2_TEXTE.Name = "colFGATX2_TEXTE"
        Me.colFGATX2_TEXTE.Visible = True
        Me.colFGATX2_TEXTE.VisibleIndex = 0
        '
        'rm_Memo8
        '
        Me.rm_Memo8.Name = "rm_Memo8"
        '
        'Panel45
        '
        Me.Panel45.Controls.Add(Me.LabelControl22)
        Me.Panel45.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel45.Location = New System.Drawing.Point(0, 0)
        Me.Panel45.Name = "Panel45"
        Me.Panel45.Size = New System.Drawing.Size(490, 24)
        Me.Panel45.TabIndex = 37
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(4, 8)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl22.TabIndex = 19
        Me.LabelControl22.Text = "Texte"
        '
        'Panel42
        '
        Me.Panel42.Controls.Add(Me.GC61)
        Me.Panel42.Controls.Add(Me.GC62)
        Me.Panel42.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel42.Location = New System.Drawing.Point(2, 20)
        Me.Panel42.Name = "Panel42"
        Me.Panel42.Size = New System.Drawing.Size(490, 137)
        Me.Panel42.TabIndex = 24
        '
        'GC61
        '
        Me.GC61.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC61.DataMember = "FGAON_OBSERVATION_NOUVEAUNE"
        Me.GC61.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC61.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC61.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC61.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC61.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC61.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC61.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC61.EmbeddedNavigator.Name = ""
        Me.GC61.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC61.Location = New System.Drawing.Point(0, 0)
        Me.GC61.MainView = Me.GV61
        Me.GC61.Name = "GC61"
        Me.GC61.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FGAON})
        Me.GC61.Size = New System.Drawing.Size(187, 137)
        Me.GC61.TabIndex = 2
        Me.GC61.Tag = "[EDIT][ADD]"
        Me.GC61.UseEmbeddedNavigator = True
        Me.GC61.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV61})
        '
        'GV61
        '
        Me.GV61.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGAON_FGA_CODE_FK_PK, Me.colFGAON_CDF_OBS_CODE_FK_PK, Me.colFGAON_NUMORD})
        Me.GV61.GridControl = Me.GC61
        Me.GV61.Name = "GV61"
        Me.GV61.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV61.OptionsView.ShowGroupPanel = False
        Me.GV61.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFGAON_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFGAON_FGA_CODE_FK_PK
        '
        Me.colFGAON_FGA_CODE_FK_PK.Caption = "FGAON_FGA_CODE_FK_PK"
        Me.colFGAON_FGA_CODE_FK_PK.FieldName = "FGAON_FGA_CODE_FK_PK"
        Me.colFGAON_FGA_CODE_FK_PK.Name = "colFGAON_FGA_CODE_FK_PK"
        '
        'colFGAON_CDF_OBS_CODE_FK_PK
        '
        Me.colFGAON_CDF_OBS_CODE_FK_PK.Caption = "Observations"
        Me.colFGAON_CDF_OBS_CODE_FK_PK.ColumnEdit = Me.rp_FGAON
        Me.colFGAON_CDF_OBS_CODE_FK_PK.FieldName = "FGAON_CDF_OBS_CODE_FK_PK"
        Me.colFGAON_CDF_OBS_CODE_FK_PK.Name = "colFGAON_CDF_OBS_CODE_FK_PK"
        Me.colFGAON_CDF_OBS_CODE_FK_PK.Visible = True
        Me.colFGAON_CDF_OBS_CODE_FK_PK.VisibleIndex = 0
        Me.colFGAON_CDF_OBS_CODE_FK_PK.Width = 395
        '
        'rp_FGAON
        '
        Me.rp_FGAON.AutoHeight = False
        Me.rp_FGAON.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FGAON.Name = "rp_FGAON"
        '
        'colFGAON_NUMORD
        '
        Me.colFGAON_NUMORD.Caption = "N°"
        Me.colFGAON_NUMORD.FieldName = "FGAON_NUMORD"
        Me.colFGAON_NUMORD.Name = "colFGAON_NUMORD"
        Me.colFGAON_NUMORD.Visible = True
        Me.colFGAON_NUMORD.VisibleIndex = 1
        Me.colFGAON_NUMORD.Width = 50
        '
        'GC62
        '
        Me.GC62.DataMember = "FGACFN_CIRCONSFAVORIS_NOUVEAUN"
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
        Me.GC62.Location = New System.Drawing.Point(185, 0)
        Me.GC62.MainView = Me.GV62
        Me.GC62.Name = "GC62"
        Me.GC62.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FGACFN})
        Me.GC62.Size = New System.Drawing.Size(305, 137)
        Me.GC62.TabIndex = 3
        Me.GC62.Tag = "[EDIT][ADD]"
        Me.GC62.UseEmbeddedNavigator = True
        Me.GC62.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV62})
        '
        'GV62
        '
        Me.GV62.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGACFN_FGA_CODE_FK_PK, Me.colFGACFN_CDF_CF_CODE_FK_PK, Me.colFGACFN_NUMORD})
        Me.GV62.GridControl = Me.GC62
        Me.GV62.Name = "GV62"
        Me.GV62.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV62.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV62.OptionsView.ShowGroupPanel = False
        Me.GV62.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFGACFN_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFGACFN_FGA_CODE_FK_PK
        '
        Me.colFGACFN_FGA_CODE_FK_PK.Caption = "FGACFN_FGA_CODE_FK_PK"
        Me.colFGACFN_FGA_CODE_FK_PK.FieldName = "FGACFN_FGA_CODE_FK_PK"
        Me.colFGACFN_FGA_CODE_FK_PK.Name = "colFGACFN_FGA_CODE_FK_PK"
        '
        'colFGACFN_CDF_CF_CODE_FK_PK
        '
        Me.colFGACFN_CDF_CF_CODE_FK_PK.Caption = "Circonstances favorisantes"
        Me.colFGACFN_CDF_CF_CODE_FK_PK.ColumnEdit = Me.rp_FGACFN
        Me.colFGACFN_CDF_CF_CODE_FK_PK.FieldName = "FGACFN_CDF_CF_CODE_FK_PK"
        Me.colFGACFN_CDF_CF_CODE_FK_PK.Name = "colFGACFN_CDF_CF_CODE_FK_PK"
        Me.colFGACFN_CDF_CF_CODE_FK_PK.Visible = True
        Me.colFGACFN_CDF_CF_CODE_FK_PK.VisibleIndex = 0
        Me.colFGACFN_CDF_CF_CODE_FK_PK.Width = 234
        '
        'rp_FGACFN
        '
        Me.rp_FGACFN.AutoHeight = False
        Me.rp_FGACFN.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FGACFN.Name = "rp_FGACFN"
        '
        'colFGACFN_NUMORD
        '
        Me.colFGACFN_NUMORD.Caption = "N°"
        Me.colFGACFN_NUMORD.FieldName = "FGACFN_NUMORD"
        Me.colFGACFN_NUMORD.Name = "colFGACFN_NUMORD"
        Me.colFGACFN_NUMORD.Visible = True
        Me.colFGACFN_NUMORD.VisibleIndex = 1
        Me.colFGACFN_NUMORD.Width = 50
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.lkupFGA_CDF)
        Me.GroupControl3.Controls.Add(Me.TextEdit5)
        Me.GroupControl3.Controls.Add(Me.LabelControl20)
        Me.GroupControl3.Controls.Add(Me.TextEdit6)
        Me.GroupControl3.Controls.Add(Me.LabelControl21)
        Me.GroupControl3.Controls.Add(Me.ComboBoxEdit4)
        Me.GroupControl3.Controls.Add(Me.LabelControl19)
        Me.GroupControl3.Controls.Add(Me.TextEdit3)
        Me.GroupControl3.Controls.Add(Me.LabelControl17)
        Me.GroupControl3.Controls.Add(Me.TextEdit4)
        Me.GroupControl3.Controls.Add(Me.LabelControl18)
        Me.GroupControl3.Controls.Add(Me.ComboBoxEdit3)
        Me.GroupControl3.Controls.Add(Me.LabelControl16)
        Me.GroupControl3.Controls.Add(Me.TextEdit2)
        Me.GroupControl3.Controls.Add(Me.LabelControl15)
        Me.GroupControl3.Controls.Add(Me.TextEdit1)
        Me.GroupControl3.Controls.Add(Me.LabelControl14)
        Me.GroupControl3.Controls.Add(Me.ComboBoxEdit2)
        Me.GroupControl3.Controls.Add(Me.LabelControl13)
        Me.GroupControl3.Controls.Add(Me.ComboBoxEdit1)
        Me.GroupControl3.Controls.Add(Me.LabelControl12)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl3.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(494, 139)
        Me.GroupControl3.TabIndex = 31
        Me.GroupControl3.Tag = "[EDIT][ADD]"
        Me.GroupControl3.Text = "Passage dans le lait maternel"
        '
        'lkupFGA_CDF
        '
        Me.lkupFGA_CDF.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Grossesse_Allaitement, "FGA_FICHEGRAL.FGA_CDF_UC_CODE_FK", True))
        Me.lkupFGA_CDF.Location = New System.Drawing.Point(523, 111)
        Me.lkupFGA_CDF.Name = "lkupFGA_CDF"
        Me.lkupFGA_CDF.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupFGA_CDF.Properties.ReadOnly = True
        Me.lkupFGA_CDF.Size = New System.Drawing.Size(151, 20)
        Me.lkupFGA_CDF.TabIndex = 30
        Me.lkupFGA_CDF.Tag = ""
        '
        'TextEdit5
        '
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Grossesse_Allaitement, "FGA_FICHEGRAL.FGA_CONCENTRATION_MAXI", True))
        Me.TextEdit5.Location = New System.Drawing.Point(444, 111)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Properties.ReadOnly = True
        Me.TextEdit5.Size = New System.Drawing.Size(46, 20)
        Me.TextEdit5.TabIndex = 24
        Me.TextEdit5.Tag = ""
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(411, 114)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl20.TabIndex = 25
        Me.LabelControl20.Text = "- Max"
        '
        'TextEdit6
        '
        Me.TextEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Grossesse_Allaitement, "FGA_FICHEGRAL.FGA_CONCENTRATION_MINI", True))
        Me.TextEdit6.Location = New System.Drawing.Point(348, 111)
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Properties.ReadOnly = True
        Me.TextEdit6.Size = New System.Drawing.Size(46, 20)
        Me.TextEdit6.TabIndex = 22
        Me.TextEdit6.Tag = ""
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(319, 114)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl21.TabIndex = 23
        Me.LabelControl21.Text = "- Min"
        '
        'ComboBoxEdit4
        '
        Me.ComboBoxEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Grossesse_Allaitement, "FGA_FICHEGRAL.FGA_CONCENTRATION", True))
        Me.ComboBoxEdit4.EditValue = ""
        Me.ComboBoxEdit4.Location = New System.Drawing.Point(255, 111)
        Me.ComboBoxEdit4.Name = "ComboBoxEdit4"
        Me.ComboBoxEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit4.Properties.Items.AddRange(New Object() {"O", "N", "P"})
        Me.ComboBoxEdit4.Size = New System.Drawing.Size(43, 20)
        Me.ComboBoxEdit4.TabIndex = 21
        Me.ComboBoxEdit4.Tag = "[EDIT][ADD]"
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(61, 114)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(160, 13)
        Me.LabelControl19.TabIndex = 20
        Me.LabelControl19.Text = "Concentration dans 100 ml de lait"
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Grossesse_Allaitement, "FGA_FICHEGRAL.FGA_PLASMALAIT_MAXI", True))
        Me.TextEdit3.Location = New System.Drawing.Point(444, 82)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.ReadOnly = True
        Me.TextEdit3.Size = New System.Drawing.Size(46, 20)
        Me.TextEdit3.TabIndex = 18
        Me.TextEdit3.Tag = ""
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(411, 84)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl17.TabIndex = 19
        Me.LabelControl17.Text = "- Max"
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Grossesse_Allaitement, "FGA_FICHEGRAL.FGA_PLASMALAIT_MINI", True))
        Me.TextEdit4.Location = New System.Drawing.Point(348, 82)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.ReadOnly = True
        Me.TextEdit4.Size = New System.Drawing.Size(46, 20)
        Me.TextEdit4.TabIndex = 16
        Me.TextEdit4.Tag = ""
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(319, 84)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl18.TabIndex = 17
        Me.LabelControl18.Text = "- Min"
        '
        'ComboBoxEdit3
        '
        Me.ComboBoxEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Grossesse_Allaitement, "FGA_FICHEGRAL.FGA_PLASMALAIT", True))
        Me.ComboBoxEdit3.EditValue = ""
        Me.ComboBoxEdit3.Location = New System.Drawing.Point(255, 82)
        Me.ComboBoxEdit3.Name = "ComboBoxEdit3"
        Me.ComboBoxEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit3.Properties.Items.AddRange(New Object() {"O", "N", "P"})
        Me.ComboBoxEdit3.Size = New System.Drawing.Size(43, 20)
        Me.ComboBoxEdit3.TabIndex = 15
        Me.ComboBoxEdit3.Tag = "[EDIT][ADD]"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(8, 84)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(213, 13)
        Me.LabelControl16.TabIndex = 14
        Me.LabelControl16.Text = "Rapport concentration lait / plasma maternel"
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Grossesse_Allaitement, "FGA_FICHEGRAL.FGA_FIXATIONPROTEIQUE_MAXI", True))
        Me.TextEdit2.Location = New System.Drawing.Point(444, 52)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Size = New System.Drawing.Size(46, 20)
        Me.TextEdit2.TabIndex = 12
        Me.TextEdit2.Tag = ""
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(411, 55)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl15.TabIndex = 13
        Me.LabelControl15.Text = "- Max"
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Grossesse_Allaitement, "FGA_FICHEGRAL.FGA_FIXATIONPROTEIQUE_MINI", True))
        Me.TextEdit1.Location = New System.Drawing.Point(348, 52)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(46, 20)
        Me.TextEdit1.TabIndex = 10
        Me.TextEdit1.Tag = ""
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(319, 55)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl14.TabIndex = 11
        Me.LabelControl14.Text = "- Min"
        '
        'ComboBoxEdit2
        '
        Me.ComboBoxEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Grossesse_Allaitement, "FGA_FICHEGRAL.FGA_FIXATIONPROTEIQUE", True))
        Me.ComboBoxEdit2.EditValue = ""
        Me.ComboBoxEdit2.Location = New System.Drawing.Point(255, 52)
        Me.ComboBoxEdit2.Name = "ComboBoxEdit2"
        Me.ComboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit2.Properties.Items.AddRange(New Object() {"O", "N", "P"})
        Me.ComboBoxEdit2.Size = New System.Drawing.Size(43, 20)
        Me.ComboBoxEdit2.TabIndex = 9
        Me.ComboBoxEdit2.Tag = "[EDIT][ADD]"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(109, 55)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(112, 13)
        Me.LabelControl13.TabIndex = 8
        Me.LabelControl13.Text = "Fixation protéïque (%) "
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Grossesse_Allaitement, "FGA_FICHEGRAL.FGA_PASSAGELAIT", True))
        Me.ComboBoxEdit1.EditValue = ""
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(255, 24)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"O", "N", "P"})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(43, 20)
        Me.ComboBoxEdit1.TabIndex = 7
        Me.ComboBoxEdit1.Tag = "[EDIT][ADD]"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(87, 30)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(134, 13)
        Me.LabelControl12.TabIndex = 6
        Me.LabelControl12.Text = "Passage dans le lait (O/N/P)"
        '
        'XtraTabPage11
        '
        Me.XtraTabPage11.Controls.Add(Me.Panel47)
        Me.XtraTabPage11.Controls.Add(Me.Panel46)
        Me.XtraTabPage11.Name = "XtraTabPage11"
        Me.XtraTabPage11.Size = New System.Drawing.Size(494, 390)
        Me.XtraTabPage11.Text = "Recommandations"
        '
        'Panel47
        '
        Me.Panel47.Controls.Add(Me.Panel48)
        Me.Panel47.Controls.Add(Me.Panel49)
        Me.Panel47.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel47.Location = New System.Drawing.Point(0, 124)
        Me.Panel47.Name = "Panel47"
        Me.Panel47.Size = New System.Drawing.Size(494, 266)
        Me.Panel47.TabIndex = 49
        Me.Panel47.Tag = ""
        '
        'Panel48
        '
        Me.Panel48.Controls.Add(Me.GC72)
        Me.Panel48.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel48.Location = New System.Drawing.Point(0, 24)
        Me.Panel48.Name = "Panel48"
        Me.Panel48.Size = New System.Drawing.Size(494, 242)
        Me.Panel48.TabIndex = 38
        Me.Panel48.Tag = "[ADD][EDIT]"
        '
        'GC72
        '
        Me.GC72.DataMember = "FGATX8_FGA_TXRECOMMANDAT"
        Me.GC72.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC72.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC72.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC72.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC72.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC72.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC72.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC72.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC72.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC72.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC72.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC72.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC72.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC72.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC72.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC72.EmbeddedNavigator.Name = ""
        Me.GC72.EmbeddedNavigator.TextStringFormat = ""
        Me.GC72.Location = New System.Drawing.Point(0, 0)
        Me.GC72.MainView = Me.GV72
        Me.GC72.Name = "GC72"
        Me.GC72.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rm_Memo9})
        Me.GC72.Size = New System.Drawing.Size(494, 242)
        Me.GC72.TabIndex = 5
        Me.GC72.UseEmbeddedNavigator = True
        Me.GC72.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV72})
        '
        'GV72
        '
        Me.GV72.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGATX8_FGA_CODE_FK_PK, Me.colFGATX8_TEXTE})
        Me.GV72.GridControl = Me.GC72
        Me.GV72.GroupFormat = ""
        Me.GV72.GroupPanelText = " "
        Me.GV72.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GV72.Name = "GV72"
        Me.GV72.OptionsCustomization.AllowRowSizing = True
        Me.GV72.OptionsNavigation.AutoFocusNewRow = True
        Me.GV72.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV72.OptionsView.ShowColumnHeaders = False
        Me.GV72.OptionsView.ShowDetailButtons = False
        Me.GV72.OptionsView.ShowGroupPanel = False
        Me.GV72.OptionsView.ShowHorzLines = False
        Me.GV72.OptionsView.ShowIndicator = False
        Me.GV72.RowHeight = 290
        Me.GV72.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colFGATX8_FGA_CODE_FK_PK
        '
        Me.colFGATX8_FGA_CODE_FK_PK.Caption = "FGATX8_FGA_CODE_FK_PK"
        Me.colFGATX8_FGA_CODE_FK_PK.FieldName = "FGATX8_FGA_CODE_FK_PK"
        Me.colFGATX8_FGA_CODE_FK_PK.Name = "colFGATX8_FGA_CODE_FK_PK"
        '
        'colFGATX8_TEXTE
        '
        Me.colFGATX8_TEXTE.Caption = "FGATX8_TEXTE"
        Me.colFGATX8_TEXTE.ColumnEdit = Me.rm_Memo9
        Me.colFGATX8_TEXTE.FieldName = "FGATX8_TEXTE"
        Me.colFGATX8_TEXTE.Name = "colFGATX8_TEXTE"
        Me.colFGATX8_TEXTE.Visible = True
        Me.colFGATX8_TEXTE.VisibleIndex = 0
        '
        'rm_Memo9
        '
        Me.rm_Memo9.Name = "rm_Memo9"
        '
        'Panel49
        '
        Me.Panel49.Controls.Add(Me.LabelControl23)
        Me.Panel49.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel49.Location = New System.Drawing.Point(0, 0)
        Me.Panel49.Name = "Panel49"
        Me.Panel49.Size = New System.Drawing.Size(494, 24)
        Me.Panel49.TabIndex = 37
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(4, 8)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl23.TabIndex = 19
        Me.LabelControl23.Text = "Texte"
        '
        'Panel46
        '
        Me.Panel46.Controls.Add(Me.GC71)
        Me.Panel46.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel46.Location = New System.Drawing.Point(0, 0)
        Me.Panel46.Name = "Panel46"
        Me.Panel46.Size = New System.Drawing.Size(494, 124)
        Me.Panel46.TabIndex = 42
        '
        'GC71
        '
        Me.GC71.DataMember = "FGARIL_RISQUE_ALLAITEMENT"
        Me.GC71.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC71.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC71.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC71.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC71.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC71.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC71.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC71.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC71.EmbeddedNavigator.Name = ""
        Me.GC71.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC71.Location = New System.Drawing.Point(0, 0)
        Me.GC71.MainView = Me.GV71
        Me.GC71.Name = "GC71"
        Me.GC71.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FGARIL})
        Me.GC71.Size = New System.Drawing.Size(494, 124)
        Me.GC71.TabIndex = 2
        Me.GC71.Tag = "[EDIT][ADD]"
        Me.GC71.UseEmbeddedNavigator = True
        Me.GC71.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV71})
        '
        'GV71
        '
        Me.GV71.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGARIL_FGA_CODE_FK_PK, Me.colFGARIL_CDF_RI_CODE_FK_PK, Me.colFGARIL_NUMORD})
        Me.GV71.GridControl = Me.GC71
        Me.GV71.Name = "GV71"
        Me.GV71.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV71.OptionsView.ShowGroupPanel = False
        Me.GV71.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFGARIL_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFGARIL_FGA_CODE_FK_PK
        '
        Me.colFGARIL_FGA_CODE_FK_PK.Caption = "FGARIL_FGA_CODE_FK_PK"
        Me.colFGARIL_FGA_CODE_FK_PK.FieldName = "FGARIL_FGA_CODE_FK_PK"
        Me.colFGARIL_FGA_CODE_FK_PK.Name = "colFGARIL_FGA_CODE_FK_PK"
        '
        'colFGARIL_CDF_RI_CODE_FK_PK
        '
        Me.colFGARIL_CDF_RI_CODE_FK_PK.Caption = "Recommandations"
        Me.colFGARIL_CDF_RI_CODE_FK_PK.ColumnEdit = Me.rp_FGARIL
        Me.colFGARIL_CDF_RI_CODE_FK_PK.FieldName = "FGARIL_CDF_RI_CODE_FK_PK"
        Me.colFGARIL_CDF_RI_CODE_FK_PK.Name = "colFGARIL_CDF_RI_CODE_FK_PK"
        Me.colFGARIL_CDF_RI_CODE_FK_PK.Visible = True
        Me.colFGARIL_CDF_RI_CODE_FK_PK.VisibleIndex = 0
        Me.colFGARIL_CDF_RI_CODE_FK_PK.Width = 702
        '
        'rp_FGARIL
        '
        Me.rp_FGARIL.AutoHeight = False
        Me.rp_FGARIL.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FGARIL.Name = "rp_FGARIL"
        '
        'colFGARIL_NUMORD
        '
        Me.colFGARIL_NUMORD.Caption = "N°"
        Me.colFGARIL_NUMORD.FieldName = "FGARIL_NUMORD"
        Me.colFGARIL_NUMORD.Name = "colFGARIL_NUMORD"
        Me.colFGARIL_NUMORD.Visible = True
        Me.colFGARIL_NUMORD.VisibleIndex = 1
        Me.colFGARIL_NUMORD.Width = 50
        '
        'XtraTabPage12
        '
        Me.XtraTabPage12.Controls.Add(Me.Panel55)
        Me.XtraTabPage12.Controls.Add(Me.Panel52)
        Me.XtraTabPage12.Controls.Add(Me.Panel50)
        Me.XtraTabPage12.Name = "XtraTabPage12"
        Me.XtraTabPage12.Size = New System.Drawing.Size(494, 390)
        Me.XtraTabPage12.Text = "Conduite à tenir"
        '
        'Panel55
        '
        Me.Panel55.Controls.Add(Me.Panel51)
        Me.Panel55.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel55.Location = New System.Drawing.Point(0, 270)
        Me.Panel55.Name = "Panel55"
        Me.Panel55.Size = New System.Drawing.Size(494, 120)
        Me.Panel55.TabIndex = 51
        '
        'Panel51
        '
        Me.Panel51.Controls.Add(Me.GC82)
        Me.Panel51.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel51.Location = New System.Drawing.Point(0, 0)
        Me.Panel51.Name = "Panel51"
        Me.Panel51.Size = New System.Drawing.Size(494, 120)
        Me.Panel51.TabIndex = 44
        '
        'GC82
        '
        Me.GC82.DataMember = "FGAAFS_FGA_AFSSAPS"
        Me.GC82.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC82.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC82.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC82.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC82.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC82.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC82.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC82.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC82.EmbeddedNavigator.Name = ""
        Me.GC82.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC82.Location = New System.Drawing.Point(0, 0)
        Me.GC82.MainView = Me.GV82
        Me.GC82.Name = "GC82"
        Me.GC82.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FGAAFS, Me.rp_FGAAFS_SP})
        Me.GC82.Size = New System.Drawing.Size(494, 120)
        Me.GC82.TabIndex = 2
        Me.GC82.Tag = "[EDIT][ADD]"
        Me.GC82.UseEmbeddedNavigator = True
        Me.GC82.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV82})
        '
        'GV82
        '
        Me.GV82.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGAAFS_FGA_CODE_FK_PK, Me.colFGAAFS_SP_CODE_FK_PK, Me.colFGAAFS_DATE_PK, Me.colFGAAFS_TYPEGRAL_PK, Me.colFGAAFS_CDF_DOCUMENT_FK_PK})
        Me.GV82.GridControl = Me.GC82
        Me.GV82.Name = "GV82"
        Me.GV82.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV82.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV82.OptionsView.ShowGroupPanel = False
        '
        'colFGAAFS_FGA_CODE_FK_PK
        '
        Me.colFGAAFS_FGA_CODE_FK_PK.Caption = "FGAAFS_FGA_CODE_FK_PK"
        Me.colFGAAFS_FGA_CODE_FK_PK.FieldName = "FGAAFS_FGA_CODE_FK_PK"
        Me.colFGAAFS_FGA_CODE_FK_PK.Name = "colFGAAFS_FGA_CODE_FK_PK"
        '
        'colFGAAFS_SP_CODE_FK_PK
        '
        Me.colFGAAFS_SP_CODE_FK_PK.Caption = "Spécialités"
        Me.colFGAAFS_SP_CODE_FK_PK.ColumnEdit = Me.rp_FGAAFS_SP
        Me.colFGAAFS_SP_CODE_FK_PK.FieldName = "FGAAFS_SP_CODE_FK_PK"
        Me.colFGAAFS_SP_CODE_FK_PK.Name = "colFGAAFS_SP_CODE_FK_PK"
        Me.colFGAAFS_SP_CODE_FK_PK.Visible = True
        Me.colFGAAFS_SP_CODE_FK_PK.VisibleIndex = 2
        Me.colFGAAFS_SP_CODE_FK_PK.Width = 329
        '
        'rp_FGAAFS_SP
        '
        Me.rp_FGAAFS_SP.AutoHeight = False
        Me.rp_FGAAFS_SP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FGAAFS_SP.Name = "rp_FGAAFS_SP"
        Me.rp_FGAAFS_SP.NullText = ""
        '
        'colFGAAFS_DATE_PK
        '
        Me.colFGAAFS_DATE_PK.Caption = "Date"
        Me.colFGAAFS_DATE_PK.FieldName = "FGAAFS_DATE_PK"
        Me.colFGAAFS_DATE_PK.Name = "colFGAAFS_DATE_PK"
        Me.colFGAAFS_DATE_PK.Visible = True
        Me.colFGAAFS_DATE_PK.VisibleIndex = 1
        Me.colFGAAFS_DATE_PK.Width = 87
        '
        'colFGAAFS_TYPEGRAL_PK
        '
        Me.colFGAAFS_TYPEGRAL_PK.Caption = "FGAAFS_TYPEGRAL_PK"
        Me.colFGAAFS_TYPEGRAL_PK.FieldName = "FGAAFS_TYPEGRAL_PK"
        Me.colFGAAFS_TYPEGRAL_PK.Name = "colFGAAFS_TYPEGRAL_PK"
        '
        'colFGAAFS_CDF_DOCUMENT_FK_PK
        '
        Me.colFGAAFS_CDF_DOCUMENT_FK_PK.Caption = "Références officielles"
        Me.colFGAAFS_CDF_DOCUMENT_FK_PK.ColumnEdit = Me.rp_FGAAFS
        Me.colFGAAFS_CDF_DOCUMENT_FK_PK.FieldName = "FGAAFS_CDF_DOCUMENT_FK_PK"
        Me.colFGAAFS_CDF_DOCUMENT_FK_PK.Name = "colFGAAFS_CDF_DOCUMENT_FK_PK"
        Me.colFGAAFS_CDF_DOCUMENT_FK_PK.Visible = True
        Me.colFGAAFS_CDF_DOCUMENT_FK_PK.VisibleIndex = 0
        Me.colFGAAFS_CDF_DOCUMENT_FK_PK.Width = 340
        '
        'rp_FGAAFS
        '
        Me.rp_FGAAFS.AutoHeight = False
        Me.rp_FGAAFS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FGAAFS.Name = "rp_FGAAFS"
        '
        'Panel52
        '
        Me.Panel52.Controls.Add(Me.Panel53)
        Me.Panel52.Controls.Add(Me.Panel54)
        Me.Panel52.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel52.Location = New System.Drawing.Point(0, 124)
        Me.Panel52.Name = "Panel52"
        Me.Panel52.Size = New System.Drawing.Size(494, 146)
        Me.Panel52.TabIndex = 50
        Me.Panel52.Tag = ""
        '
        'Panel53
        '
        Me.Panel53.Controls.Add(Me.GC83)
        Me.Panel53.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel53.Location = New System.Drawing.Point(0, 24)
        Me.Panel53.Name = "Panel53"
        Me.Panel53.Size = New System.Drawing.Size(494, 118)
        Me.Panel53.TabIndex = 38
        Me.Panel53.Tag = "[ADD][EDIT]"
        '
        'GC83
        '
        Me.GC83.DataMember = "FGATX6_FGA_TXCONDATENIRCA"
        Me.GC83.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC83.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC83.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC83.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC83.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC83.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC83.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC83.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC83.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC83.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC83.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC83.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC83.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC83.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC83.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC83.EmbeddedNavigator.Name = ""
        Me.GC83.EmbeddedNavigator.TextStringFormat = ""
        Me.GC83.Location = New System.Drawing.Point(0, 0)
        Me.GC83.MainView = Me.GV83
        Me.GC83.Name = "GC83"
        Me.GC83.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rm_Memo10})
        Me.GC83.Size = New System.Drawing.Size(494, 118)
        Me.GC83.TabIndex = 5
        Me.GC83.UseEmbeddedNavigator = True
        Me.GC83.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV83})
        '
        'GV83
        '
        Me.GV83.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGATX6_FGA_CODE_FK_PK, Me.colFGATX6_TEXTE})
        Me.GV83.GridControl = Me.GC83
        Me.GV83.GroupFormat = ""
        Me.GV83.GroupPanelText = " "
        Me.GV83.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GV83.Name = "GV83"
        Me.GV83.OptionsCustomization.AllowRowSizing = True
        Me.GV83.OptionsNavigation.AutoFocusNewRow = True
        Me.GV83.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV83.OptionsView.ShowColumnHeaders = False
        Me.GV83.OptionsView.ShowDetailButtons = False
        Me.GV83.OptionsView.ShowGroupPanel = False
        Me.GV83.OptionsView.ShowHorzLines = False
        Me.GV83.OptionsView.ShowIndicator = False
        Me.GV83.RowHeight = 92
        Me.GV83.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colFGATX6_FGA_CODE_FK_PK
        '
        Me.colFGATX6_FGA_CODE_FK_PK.Caption = "FGATX6_FGA_CODE_FK_PK"
        Me.colFGATX6_FGA_CODE_FK_PK.FieldName = "FGATX6_FGA_CODE_FK_PK"
        Me.colFGATX6_FGA_CODE_FK_PK.Name = "colFGATX6_FGA_CODE_FK_PK"
        '
        'colFGATX6_TEXTE
        '
        Me.colFGATX6_TEXTE.Caption = "FGATX6_TEXTE"
        Me.colFGATX6_TEXTE.ColumnEdit = Me.rm_Memo10
        Me.colFGATX6_TEXTE.FieldName = "FGATX6_TEXTE"
        Me.colFGATX6_TEXTE.Name = "colFGATX6_TEXTE"
        Me.colFGATX6_TEXTE.Visible = True
        Me.colFGATX6_TEXTE.VisibleIndex = 0
        '
        'rm_Memo10
        '
        Me.rm_Memo10.Name = "rm_Memo10"
        '
        'Panel54
        '
        Me.Panel54.Controls.Add(Me.LabelControl24)
        Me.Panel54.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel54.Location = New System.Drawing.Point(0, 0)
        Me.Panel54.Name = "Panel54"
        Me.Panel54.Size = New System.Drawing.Size(494, 24)
        Me.Panel54.TabIndex = 37
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(4, 8)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl24.TabIndex = 19
        Me.LabelControl24.Text = "Texte"
        '
        'Panel50
        '
        Me.Panel50.Controls.Add(Me.GC81)
        Me.Panel50.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel50.Location = New System.Drawing.Point(0, 0)
        Me.Panel50.Name = "Panel50"
        Me.Panel50.Size = New System.Drawing.Size(494, 124)
        Me.Panel50.TabIndex = 43
        '
        'GC81
        '
        Me.GC81.DataMember = "FGACA_CATALLAITEMENT"
        Me.GC81.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC81.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC81.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC81.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC81.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC81.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC81.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC81.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC81.EmbeddedNavigator.Name = ""
        Me.GC81.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC81.Location = New System.Drawing.Point(0, 0)
        Me.GC81.MainView = Me.GV81
        Me.GC81.Name = "GC81"
        Me.GC81.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FGACA})
        Me.GC81.Size = New System.Drawing.Size(494, 124)
        Me.GC81.TabIndex = 2
        Me.GC81.Tag = "[EDIT][ADD]"
        Me.GC81.UseEmbeddedNavigator = True
        Me.GC81.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV81})
        '
        'GV81
        '
        Me.GV81.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFGACA_FGA_CODE_FK_PK, Me.colFGACA_CDF_CAT_CODE_FK_PK, Me.colFGACA_NUMORD})
        Me.GV81.GridControl = Me.GC81
        Me.GV81.Name = "GV81"
        Me.GV81.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV81.OptionsView.ShowGroupPanel = False
        Me.GV81.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFGACA_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFGACA_FGA_CODE_FK_PK
        '
        Me.colFGACA_FGA_CODE_FK_PK.Caption = "FGACA_FGA_CODE_FK_PK"
        Me.colFGACA_FGA_CODE_FK_PK.FieldName = "FGACA_FGA_CODE_FK_PK"
        Me.colFGACA_FGA_CODE_FK_PK.Name = "colFGACA_FGA_CODE_FK_PK"
        '
        'colFGACA_CDF_CAT_CODE_FK_PK
        '
        Me.colFGACA_CDF_CAT_CODE_FK_PK.Caption = "Conduite à tenir"
        Me.colFGACA_CDF_CAT_CODE_FK_PK.ColumnEdit = Me.rp_FGACA
        Me.colFGACA_CDF_CAT_CODE_FK_PK.FieldName = "FGACA_CDF_CAT_CODE_FK_PK"
        Me.colFGACA_CDF_CAT_CODE_FK_PK.Name = "colFGACA_CDF_CAT_CODE_FK_PK"
        Me.colFGACA_CDF_CAT_CODE_FK_PK.Visible = True
        Me.colFGACA_CDF_CAT_CODE_FK_PK.VisibleIndex = 0
        Me.colFGACA_CDF_CAT_CODE_FK_PK.Width = 702
        '
        'rp_FGACA
        '
        Me.rp_FGACA.AutoHeight = False
        Me.rp_FGACA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FGACA.Name = "rp_FGACA"
        '
        'colFGACA_NUMORD
        '
        Me.colFGACA_NUMORD.Caption = "N°"
        Me.colFGACA_NUMORD.FieldName = "FGACA_NUMORD"
        Me.colFGACA_NUMORD.Name = "colFGACA_NUMORD"
        Me.colFGACA_NUMORD.Visible = True
        Me.colFGACA_NUMORD.VisibleIndex = 1
        Me.colFGACA_NUMORD.Width = 50
        '
        'FGAFICHEGRALBindingSource
        '
        Me.FGAFICHEGRALBindingSource.DataMember = "FGA_FICHEGRAL"
        Me.FGAFICHEGRALBindingSource.DataSource = Me.DsTheriaque_Grossesse_Allaitement
        '
        'FgaccH_TA
        '
        Me.FgaccH_TA.ClearBeforeFill = True
        '
        'FgacpH_TA
        '
        Me.FgacpH_TA.ClearBeforeFill = True
        '
        'FgasaC_TA
        '
        Me.FgasaC_TA.ClearBeforeFill = True
        '
        'FgasaU_TA
        '
        Me.FgasaU_TA.ClearBeforeFill = True
        '
        'FgapR_TA
        '
        Me.FgapR_TA.ClearBeforeFill = True
        '
        'FgasP_TA
        '
        Me.FgasP_TA.ClearBeforeFill = True
        '
        'FgacfA_TA
        '
        Me.FgacfA_TA.ClearBeforeFill = True
        '
        'FgaoA_TA
        '
        Me.FgaoA_TA.ClearBeforeFill = True
        '
        'FgariA_TA
        '
        Me.FgariA_TA.ClearBeforeFill = True
        '
        'FgatX1_TA
        '
        Me.FgatX1_TA.ClearBeforeFill = True
        '
        'FgacfH_TA
        '
        Me.FgacfH_TA.ClearBeforeFill = True
        '
        'FgaoH_TA
        '
        Me.FgaoH_TA.ClearBeforeFill = True
        '
        'FgapC_TA
        '
        Me.FgapC_TA.ClearBeforeFill = True
        '
        'FgariH_TA
        '
        Me.FgariH_TA.ClearBeforeFill = True
        '
        'FgatX3_TA
        '
        Me.FgatX3_TA.ClearBeforeFill = True
        '
        'FgariG_TA
        '
        Me.FgariG_TA.ClearBeforeFill = True
        '
        'FgatX7_TA
        '
        Me.FgatX7_TA.ClearBeforeFill = True
        '
        'FgacF_TA
        '
        Me.FgacF_TA.ClearBeforeFill = True
        '
        'FgacN_TA
        '
        Me.FgacN_TA.ClearBeforeFill = True
        '
        'FgatX4_TA
        '
        Me.FgatX4_TA.ClearBeforeFill = True
        '
        'FgatX5_TA
        '
        Me.FgatX5_TA.ClearBeforeFill = True
        '
        'FgacfaP_TA
        '
        Me.FgacfaP_TA.ClearBeforeFill = True
        '
        'FgarifaP_TA
        '
        Me.FgarifaP_TA.ClearBeforeFill = True
        '
        'FgatX10_TA
        '
        Me.FgatX10_TA.ClearBeforeFill = True
        '
        'FgatX9_TA
        '
        Me.FgatX9_TA.ClearBeforeFill = True
        '
        'FgacfN_TA
        '
        Me.FgacfN_TA.ClearBeforeFill = True
        '
        'FgaoN_TA
        '
        Me.FgaoN_TA.ClearBeforeFill = True
        '
        'FgatX2_TA
        '
        Me.FgatX2_TA.ClearBeforeFill = True
        '
        'FgariL_TA
        '
        Me.FgariL_TA.ClearBeforeFill = True
        '
        'FgatX8_TA
        '
        Me.FgatX8_TA.ClearBeforeFill = True
        '
        'FgaafS_TA
        '
        Me.FgaafS_TA.ClearBeforeFill = True
        '
        'FgacA_TA
        '
        Me.FgacA_TA.ClearBeforeFill = True
        '
        'FgatX6_TA
        '
        Me.FgatX6_TA.ClearBeforeFill = True
        '
        'Frm_Grossesse_Allaitement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(913, 640)
        Me.Name = "Frm_Grossesse_Allaitement"
        Me.Text = "Grossesse - Allaitement"
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
        CType(Me.DsTheriaque_Grossesse_Allaitement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.GC5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FGAPR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FGASP_FGA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.GC3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FGASAC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FGASAU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FGACCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FGACPH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage5.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel27.ResumeLayout(False)
        CType(Me.GC13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rm_Memo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel28.ResumeLayout(False)
        Me.Panel28.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.GC14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FGARIA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GC12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FGACFA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        CType(Me.GC11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FGAOA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage6.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        CType(Me.GC25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rm_Memo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        CType(Me.GC24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FGARIH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        CType(Me.GC23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FGACFH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        CType(Me.GC22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FGAOH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.GC21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FGAPC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage7.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        CType(Me.GC32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rm_Memo3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        CType(Me.GC31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FGARIG_CDF_RI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FGARIG_CDF_TC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel24.ResumeLayout(False)
        Me.Panel26.ResumeLayout(False)
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel25.ResumeLayout(False)
        Me.Panel25.PerformLayout()
        Me.XtraTabPage8.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel33.ResumeLayout(False)
        CType(Me.GC45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FGAAFS1_SP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FGAAFS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel21.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        CType(Me.GC42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rm_Memo4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel23.ResumeLayout(False)
        Me.Panel23.PerformLayout()
        Me.Panel20.ResumeLayout(False)
        CType(Me.GC41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FGACF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel29.ResumeLayout(False)
        CType(Me.GC43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FGACN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel30.ResumeLayout(False)
        Me.Panel31.ResumeLayout(False)
        CType(Me.GC44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rm_Memo5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel32.ResumeLayout(False)
        Me.Panel32.PerformLayout()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.Panel38.ResumeLayout(False)
        Me.Panel39.ResumeLayout(False)
        CType(Me.GC54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rm_Memo7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel40.ResumeLayout(False)
        Me.Panel40.PerformLayout()
        Me.Panel41.ResumeLayout(False)
        CType(Me.GC53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FGACFAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.Panel35.ResumeLayout(False)
        Me.Panel36.ResumeLayout(False)
        CType(Me.GC52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rm_Memo6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel37.ResumeLayout(False)
        Me.Panel37.PerformLayout()
        Me.Panel34.ResumeLayout(False)
        CType(Me.GC51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FGARIFAP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.XtraTabControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl3.ResumeLayout(False)
        Me.XtraTabPage9.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.Panel43.ResumeLayout(False)
        Me.Panel44.ResumeLayout(False)
        CType(Me.GC63, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV63, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rm_Memo8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel45.ResumeLayout(False)
        Me.Panel45.PerformLayout()
        Me.Panel42.ResumeLayout(False)
        CType(Me.GC61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FGAON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC62, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV62, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FGACFN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.lkupFGA_CDF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage11.ResumeLayout(False)
        Me.Panel47.ResumeLayout(False)
        Me.Panel48.ResumeLayout(False)
        CType(Me.GC72, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV72, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rm_Memo9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel49.ResumeLayout(False)
        Me.Panel49.PerformLayout()
        Me.Panel46.ResumeLayout(False)
        CType(Me.GC71, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV71, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FGARIL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage12.ResumeLayout(False)
        Me.Panel55.ResumeLayout(False)
        Me.Panel51.ResumeLayout(False)
        CType(Me.GC82, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV82, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FGAAFS_SP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FGAAFS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel52.ResumeLayout(False)
        Me.Panel53.ResumeLayout(False)
        CType(Me.GC83, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV83, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rm_Memo10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel54.ResumeLayout(False)
        Me.Panel54.PerformLayout()
        Me.Panel50.ResumeLayout(False)
        CType(Me.GC81, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV81, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FGACA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FGAFICHEGRALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FgA_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGA_FICHEGRALTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DsTheriaque_Grossesse_Allaitement As Theriaque.dsTheriaque_Grossesse_Allaitement
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
    Friend WithEvents colFGACPH_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGACPH_CPH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FGACPH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FgaccH_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGACCH_GRALCLCHTableAdapter
    Friend WithEvents FgacpH_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGACPH_GRALCLPHTableAdapter
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGACCH_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGACCH_CCH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FGACCH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FgasaC_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGASAC_GRALSUBACTableAdapter
    Friend WithEvents FgasaU_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGASAU_GRALSUBAUTableAdapter
    Friend WithEvents FgapR_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGAPR_GRALPRODTableAdapter
    Friend WithEvents FgasP_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGASP_GRALSPETableAdapter
    Friend WithEvents colFGAPR_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGAPR_PR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FGAPR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFGASAC_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGASAC_SAC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FGASAC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFGASAU_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGASAU_SAU_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FGASAU As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFGASP_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGASP_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FGASP_FGA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage7 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage8 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GC12 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents GC11 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GC14 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FgacfA_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGACFA_CIRCONSTFAVORIS_ANIMALETableAdapter
    Friend WithEvents FgaoA_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGAOA_OBSERVATION_ANIMALETableAdapter
    Friend WithEvents colFGACFA_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGACFA_CDF_CF_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FGACFA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFGACFA_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGAOA_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGAOA_CDF_OBS_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FGAOA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFGAOA_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel27 As System.Windows.Forms.Panel
    Friend WithEvents GC13 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel28 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents FgariA_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGARIA_RISQUE_ANIMALETableAdapter
    Friend WithEvents colFGARIA_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGARIA_CDF_RI_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FGARIA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFGARIA_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FgatX1_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGATX1_FGA_TXOBSERVANITableAdapter
    Friend WithEvents colFGATX1_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGATX1_TEXTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rm_Memo1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GC21 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV21 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFGAPC_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGAPC_CDF_PC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FGAPC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFGAPC_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FgacfH_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGACFH_CIRCONSTFAVORIS_HUMAINETableAdapter
    Friend WithEvents FgaoH_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGAOH_OBSERVATION_HUMAINETableAdapter
    Friend WithEvents FgapC_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGAPC_PERIODECRITIQUE_FGRALTableAdapter
    Friend WithEvents FgariH_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGARIH_RISQUE_HUMAINETableAdapter
    Friend WithEvents FgatX3_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGATX3_FGA_TXOBSERVHUMTableAdapter
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents GC22 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV22 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFGAOH_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGAOH_CDF_OBS_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FGAOH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFGAOH_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents GC23 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV23 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFGACFH_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGACFH_CDF_CF_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FGACFH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFGACFH_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents GC24 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV24 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFGARIH_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGARIH_CDF_RI_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FGARIH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFGARIH_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents GC25 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV25 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFGATX3_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGATX3_TEXTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rm_Memo2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents Panel24 As System.Windows.Forms.Panel
    Friend WithEvents Panel26 As System.Windows.Forms.Panel
    Friend WithEvents Panel25 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents GC31 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV31 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFGARIG_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGARIG_NUMSEQ_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGARIG_CDF_RI_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGARIG_CDF_TC_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGARIG_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FgariG_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGARIG_RISQUE_GROSSESSETableAdapter
    Friend WithEvents rp_FGARIG_CDF_RI As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rp_FGARIG_CDF_TC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FgatX7_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGATX7_FGA_TXRECOMMANDATTableAdapter
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents GC32 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV32 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFGATX7_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGATX7_TEXTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rm_Memo3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents GC41 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV41 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFGACF_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGACF_CDF_CAT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGACF_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FGACF As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FgacF_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGACF_CATFEMMEENCEINTETableAdapter
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents Panel22 As System.Windows.Forms.Panel
    Friend WithEvents GC42 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV42 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel23 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel30 As System.Windows.Forms.Panel
    Friend WithEvents Panel31 As System.Windows.Forms.Panel
    Friend WithEvents GC44 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV44 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel32 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel29 As System.Windows.Forms.Panel
    Friend WithEvents GC43 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV43 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFGATX4_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGATX4_TEXTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rm_Memo4 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colFGACN_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGACN_CDF_CAT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGACN_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FgacN_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGACN_CATNOUVEAUNETableAdapter
    Friend WithEvents FgatX4_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGATX4_FGA_TXCONDATENIRCFTableAdapter
    Friend WithEvents FgatX5_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGATX5_FGA_TXCONDATENIRCNTableAdapter
    Friend WithEvents colFGATX5_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGATX5_TEXTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FGACN As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rm_Memo5 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Panel38 As System.Windows.Forms.Panel
    Friend WithEvents Panel39 As System.Windows.Forms.Panel
    Friend WithEvents GC54 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV54 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel40 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel41 As System.Windows.Forms.Panel
    Friend WithEvents GC53 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV53 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel35 As System.Windows.Forms.Panel
    Friend WithEvents Panel36 As System.Windows.Forms.Panel
    Friend WithEvents GC52 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV52 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel37 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel34 As System.Windows.Forms.Panel
    Friend WithEvents GC51 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV51 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FgacfaP_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGACFAP_CATFEMMEENAGETableAdapter
    Friend WithEvents FgarifaP_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGARIFAP_RISQUEFEMMEENAGETableAdapter
    Friend WithEvents FgatX10_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGATX10_FGA_TXRECOMMANDATTableAdapter
    Friend WithEvents FgatX9_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGATX9_FGA_TXRECOMMANDATTableAdapter
    Friend WithEvents colFGARIFAP_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGARIFAP_CDF_RI_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGARIFAP_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FGARIFAP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFGATX10_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGATX10_TEXTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGACFAP_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGACFAP_CDF_CAT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FGACFAP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFGACFAP_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGATX9_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGATX9_TEXTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rm_Memo6 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents rm_Memo7 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents XtraTabControl3 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage9 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage11 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage12 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBoxEdit2 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBoxEdit3 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBoxEdit4 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkupFGA_CDF As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Panel43 As System.Windows.Forms.Panel
    Friend WithEvents Panel44 As System.Windows.Forms.Panel
    Friend WithEvents GC63 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV63 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel45 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel42 As System.Windows.Forms.Panel
    Friend WithEvents GC61 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV61 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC62 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV62 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFGAON_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGAON_CDF_OBS_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FGAON As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFGAON_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FgacfN_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGACFN_CIRCONSFAVORIS_NOUVEAUNTableAdapter
    Friend WithEvents FgaoN_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGAON_OBSERVATION_NOUVEAUNETableAdapter
    Friend WithEvents FgatX2_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGATX2_FGA_TXOBSERVNOUVNETableAdapter
    Friend WithEvents colFGACFN_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGACFN_CDF_CF_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FGACFN As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFGACFN_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel47 As System.Windows.Forms.Panel
    Friend WithEvents Panel48 As System.Windows.Forms.Panel
    Friend WithEvents GC72 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV72 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel49 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel46 As System.Windows.Forms.Panel
    Friend WithEvents GC71 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV71 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FgariL_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGARIL_RISQUE_ALLAITEMENTTableAdapter
    Friend WithEvents FgatX8_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGATX8_FGA_TXRECOMMANDATTableAdapter
    Friend WithEvents colFGARIL_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGARIL_CDF_RI_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FGARIL As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFGARIL_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGATX2_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGATX2_TEXTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rm_Memo8 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colFGATX8_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGATX8_TEXTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rm_Memo9 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents Panel52 As System.Windows.Forms.Panel
    Friend WithEvents Panel53 As System.Windows.Forms.Panel
    Friend WithEvents GC83 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV83 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel54 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel51 As System.Windows.Forms.Panel
    Friend WithEvents GC82 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV82 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel50 As System.Windows.Forms.Panel
    Friend WithEvents GC81 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV81 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFGACA_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGACA_CDF_CAT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FGACA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFGACA_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FgaafS_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGAAFS_FGA_AFSSAPSTableAdapter
    Friend WithEvents FgacA_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGACA_CATALLAITEMENTTableAdapter
    Friend WithEvents FgatX6_TA As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGATX6_FGA_TXCONDATENIRCATableAdapter
    Friend WithEvents colFGATX6_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGATX6_TEXTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rm_Memo10 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colFGAAFS_FGA_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGAAFS_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGAAFS_DATE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGAAFS_TYPEGRAL_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FGAAFS As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rp_FGAAFS_SP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFGAAFS_CDF_DOCUMENT_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel33 As System.Windows.Forms.Panel
    Friend WithEvents GC45 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV45 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFGAAFS_FGA_CODE_FK_PK1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGAAFS_SP_CODE_FK_PK1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FGAAFS1_SP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFGAAFS_DATE_PK1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGAAFS_TYPEGRAL_PK1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGAAFS_CDF_DOCUMENT_FK_PK1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FGAAFS1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents FGAFICHEGRALBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Panel55 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel

End Class
