<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Specialite
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
        Me.CH_MonVirt = New DevExpress.XtraEditors.CheckEdit
        Me.DsTheriaque_Nomenclature1 = New Theriaque.dsTheriaque_Nomenclature1
        Me.lkupMedVirt = New DevExpress.XtraEditors.LookUpEdit
        Me.txtLibelle = New DevExpress.XtraEditors.TextEdit
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.txtUCD13 = New DevExpress.XtraEditors.TextEdit
        Me.Label14 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.GC2 = New DevExpress.XtraGrid.GridControl
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSPLAB_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPLAB_CDF_LAB_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpLabo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC3 = New DevExpress.XtraGrid.GridControl
        Me.GV3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSPLABEX_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPLABEX_CDF_LAB_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpLabX = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSPLABEX_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkupListe = New DevExpress.XtraEditors.LookUpEdit
        Me.Label41 = New System.Windows.Forms.Label
        Me.lkupProduitCode = New DevExpress.XtraEditors.LookUpEdit
        Me.lkupStLab = New DevExpress.XtraEditors.LookUpEdit
        Me.lkupProduit = New DevExpress.XtraEditors.LookUpEdit
        Me.GC1 = New DevExpress.XtraGrid.GridControl
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSYSP_NOM_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSYSP_SP_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtNom = New DevExpress.XtraEditors.TextEdit
        Me.txtUCD = New DevExpress.XtraEditors.TextEdit
        Me.txtCIS = New DevExpress.XtraEditors.TextEdit
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel27 = New System.Windows.Forms.Panel
        Me.GC7 = New DevExpress.XtraGrid.GridControl
        Me.GV7 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSPFOTX_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPFOTX_TEXTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rm_MemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Panel28 = New System.Windows.Forms.Panel
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.GC6 = New DevExpress.XtraGrid.GridControl
        Me.GV6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSPFOCPI_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPFOCPI_CDF_FO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPFOCPI_SPFO_NUMSEQ_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPFOCPI_CDF_CPI_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpInfo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSPFOCPI_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.GC5 = New DevExpress.XtraGrid.GridControl
        Me.GV5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSPFOCFO_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPFOCFO_CDF_FO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPFOCFO_SPFO_NUMSEQ_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPFOCFO_CDF_CFO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpCompl = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSPFOCFO_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.GC4 = New DevExpress.XtraGrid.GridControl
        Me.GV4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSPFO_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPFO_CDF_FO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpFormePh = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSPFO_NUMSEQ_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPFO_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC8 = New DevExpress.XtraGrid.GridControl
        Me.GV8 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSPVO_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPVO_CDF_VO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpVoie = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSPVO_NUMSEQ = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel
        Me.GC11 = New DevExpress.XtraGrid.GridControl
        Me.GV11 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCOSAC_SAC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpSubActive = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colCOSAC_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOSAC_DOSAGE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpComboSub = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.colCOSAC_UNITEDOSAGE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpUnite = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colCOSAC_COMPO_NUM_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOSAC_SAC_BASE_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOSAC_DOSAGE_BASE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOSAC_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC10 = New DevExpress.XtraGrid.GridControl
        Me.GV10 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCOSAU_SAU_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpExcipient = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colCOSAU_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOSAU_DOSAGE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOSAU_UNITEDOSAGE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpUnite2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colCOSAU_COMPO_NUM_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOSAU_GREF_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOSAU_GREF_DATECR_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOSAU_GREF_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOSAU_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOSAU_SAU_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpNotoire = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC12 = New DevExpress.XtraGrid.GridControl
        Me.GV12 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCOTEN_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOTEN_CDF_TEN_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpTeneur = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colCOTEN_QUALIFICATIF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.comboTeneur = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.colCOTEN_DOSAGE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOTEN_CDF_UD_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpUnite3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colCOTEN_DOSAGE_EQUIV = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOTEN_CDF_UD_EQUIV_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpUnite4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colCOTEN_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC9 = New DevExpress.XtraGrid.GridControl
        Me.GV9 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCOMPO_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOMPO_NUM_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOMPO_CDF_GAL_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpComposition = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.TextEdit15 = New DevExpress.XtraEditors.TextEdit
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel
        Me.GC13 = New DevExpress.XtraGrid.GridControl
        Me.GV13 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSPCPH_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPCPH_CPH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpClasseEphmra = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSPCPH_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPCPH_CPH_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpClasseEphmra2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.Label25 = New System.Windows.Forms.Label
        Me.GC25 = New DevExpress.XtraGrid.GridControl
        Me.GV25 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSPADM_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPADM_LIBELLE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpSPADMLIBELLE = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.GC24 = New DevExpress.XtraGrid.GridControl
        Me.GV24 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSPTEN_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPTEN_LIBELLE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpSPTENLIBELLE = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.PanDDD = New System.Windows.Forms.Panel
        Me.btDDD = New DevExpress.XtraEditors.SimpleButton
        Me.GCDDD = New DevExpress.XtraGrid.GridControl
        Me.GVDDD = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSPDDD_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPDDD_ATCDDD_CATC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPDDD_ATCDDD_CDF_VO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkupDDD = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSPDDD_ATCDDD_DOSAGE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPDDD_ATCDDD_CDF_UD_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkupDDD1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSPDDD_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkupATC = New DevExpress.XtraEditors.LookUpEdit
        Me.lkupEphemra = New DevExpress.XtraEditors.LookUpEdit
        Me.lkupATC2 = New DevExpress.XtraEditors.LookUpEdit
        Me.lkupEphemra2 = New DevExpress.XtraEditors.LookUpEdit
        Me.TextEdit21 = New DevExpress.XtraEditors.TextEdit
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.lkupGestion = New DevExpress.XtraEditors.LookUpEdit
        Me.Label31 = New System.Windows.Forms.Label
        Me.lkupGestion2 = New DevExpress.XtraEditors.LookUpEdit
        Me.Label32 = New System.Windows.Forms.Label
        Me.TxtEdit_APHP = New DevExpress.XtraEditors.TextEdit
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel
        Me.GC19 = New DevExpress.XtraGrid.GridControl
        Me.GV19 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSPSMR_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPSMR_CDF_SMR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpSMR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSPSMR_NUM_ORD_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPSMR_DATE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC18 = New DevExpress.XtraGrid.GridControl
        Me.GV18 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSPATR_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPATR_ATR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpAvisCom = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSPATR_ATR_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpAvisCom2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC17 = New DevExpress.XtraGrid.GridControl
        Me.GV17 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSPFTR_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPFTR_FTR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpTransparence = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.SPFTR_FTR_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpTransparence2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC14 = New DevExpress.XtraGrid.GridControl
        Me.GV14 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSPCH_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPCH_CH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpChoix = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSPCH_CH_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC15 = New DevExpress.XtraGrid.GridControl
        Me.GV15 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colSPRMO_RMO_CODE_FK_PK = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.rpRMO2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSPRMO_RMO_CODE_FK_PK2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.rpRMO = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSPRMO_SP_CODE_FK_PK = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colSPRMO_CLRMO_CODE_FK_PK = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.rpCLRMO_CLASSE_RMO2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSPRMO_CLRMO_CODE_FK_PK2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.rpCLRMO_CLASSE_RMO = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSPRMO_CLRMO_CODE_FK_PK3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.rpCLRMO_CLASSE_RMO3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView12 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GC16 = New DevExpress.XtraGrid.GridControl
        Me.GV16 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSPFTH_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPFTH_FTH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpInfoth = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSPFTH_FTH_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpInfoth2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.GC21 = New DevExpress.XtraGrid.GridControl
        Me.GV21 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPRIUCD_UCD_CODE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRIUCD_CODE_LISTE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpPrix = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colPRIUCD_DATE_APPLI_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRIUCD_PFHT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRIUCD_PTTC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRIUCD_Valide = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Label43 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label42 = New System.Windows.Forms.Label
        Me.MemoEdit2 = New DevExpress.XtraEditors.MemoEdit
        Me.GC20 = New DevExpress.XtraGrid.GridControl
        Me.GV20 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSPCPD_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPCPD_CDF_STP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpPresDev = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSPCPD_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPCPD_CDF_STP_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpPresDev2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XtraTabPage7 = New DevExpress.XtraTab.XtraTabPage
        Me.GC23 = New DevExpress.XtraGrid.GridControl
        Me.GV23 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPRE_CODE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC22 = New DevExpress.XtraGrid.GridControl
        Me.DsTheriaque_Ref = New Theriaque.dsTheriaque_Ref
        Me.GV22 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSPAFS_RUBCDF_NUMERO_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpRUB = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSPAFS_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPAFS_DATE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPAFS_CDF_CODE_DOC_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpRef = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSPAFS_DATE_REVIS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage8 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.btADDRemb = New DevExpress.XtraEditors.SimpleButton
        Me.GC31 = New DevExpress.XtraGrid.GridControl
        Me.GV31 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSPURL_CODE_SP_PK_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPURL_CODE_URL_PK_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Rp_TypeURL = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSPURL_ADRESSE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabPage9 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel19 = New System.Windows.Forms.Panel
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.gcDocument = New DevExpress.XtraGrid.GridControl
        Me.gvDocument = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colLibelle = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colChemin = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel20 = New System.Windows.Forms.Panel
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.BtSupprim = New DevExpress.XtraEditors.SimpleButton
        Me.btPartager = New DevExpress.XtraEditors.SimpleButton
        Me.btApercu = New DevExpress.XtraEditors.SimpleButton
        Me.btImporter = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.cmdAnnuler = New DevExpress.XtraEditors.SimpleButton
        Me.cmdOK = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.meNote = New DevExpress.XtraEditors.MemoEdit
        Me.lueCategorie = New DevExpress.XtraEditors.LookUpEdit
        Me.txtLibelle2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.beChemin = New DevExpress.XtraEditors.ButtonEdit
        Me.DsTheriaqueURL = New Theriaque.dsTheriaqueURL
        Me.DsTheriaque_Recap = New Theriaque.dsTheriaque_Recap
        Me.SP_TA = New Theriaque.dsTheriaque_Nomenclature1TableAdapters.SP_SPECIALITETableAdapter
        Me.SYSP_TA = New Theriaque.dsTheriaque_Nomenclature1TableAdapters.SYSP_SYNONYME_SPECIALITETableAdapter
        Me.SplaB_TA = New Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPLAB_SPECIALITE_LABOTableAdapter
        Me.SplabeX_TA = New Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPLABEX_SPE_LABO_EXPLOITANTTableAdapter
        Me.SpvO_TA = New Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPVO_SPECIALITE_VOIETableAdapter
        Me.SpfO_TA = New Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPFO_SPECIALITE_FORMETableAdapter
        Me.SpfocfO_TA = New Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPFOCFO_SPE_FORME_COMPFORMETableAdapter
        Me.SpfocpI_TA = New Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPFOCPI_SPE_FORME_COMPINFOTableAdapter
        Me.CosaC_TA = New Theriaque.dsTheriaque_Nomenclature1TableAdapters.COSAC_COMPO_SUBACTTableAdapter
        Me.CosaU_TA = New Theriaque.dsTheriaque_Nomenclature1TableAdapters.COSAU_COMPO_SUBAUXTableAdapter
        Me.CompO_TA = New Theriaque.dsTheriaque_Nomenclature1TableAdapters.COMPO_COMPOSITIONTableAdapter
        Me.CoteN_TA = New Theriaque.dsTheriaque_Nomenclature1TableAdapters.COTEN_COMPO_TENEURTableAdapter
        Me.SpadM_TA = New Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPADM_SPECIALITE_MODEADMTableAdapter
        Me.SpcpH_TA = New Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPCPH_SPECIALITE_CLASSEPHTableAdapter
        Me.SpddD_TA = New Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPDDD_DOSE_USUELLE_JOURTableAdapter
        Me.SpcH_TA = New Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPCH_SPECIALITE_CHOIXTableAdapter
        Me.SprmO_TA = New Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPRMO_SPECIALITE_RMOTableAdapter
        Me.SpftH_TA = New Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPFTH_SPEC_INFOTHERAPEUTIQUETableAdapter
        Me.SpftR_TA = New Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPFTR_SPECIALITE_TRANSPARENCETableAdapter
        Me.SpatR_TA = New Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPATR_SPEC_AVISTRANSPARENCETableAdapter
        Me.SpsmR_TA = New Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPSMR_SERVICE_MEDICAL_RENDUTableAdapter
        Me.PriucD_TA = New Theriaque.dsTheriaque_Nomenclature1TableAdapters.PRIUCD_PRIX_UCDTableAdapter
        Me.SpfotX_TA = New Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPFOTX_SPE_FORME_TEXTETableAdapter
        Me.SpteN_TA = New Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPTEN_SPECIALITE_TENEURTableAdapter
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SpafS_TA = New Theriaque.dsTheriaque_RefTableAdapters.SPAFS_SPECIALITE_AFSSAPSTableAdapter
        Me.SpcpD_TA = New Theriaque.dsTheriaque_RecapTableAdapters.SPCPD_SPE_CDT_PRESCRTableAdapter
        Me.SpurL_TA = New Theriaque.dsTheriaqueURLTableAdapters.SPURL_SPECIALITE_ADRESSETableAdapter
        Me.IcduR_INCOMPATIBILITE_DUREETableAdapter1 = New Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.ICDUR_INCOMPATIBILITE_DUREETableAdapter
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.ButtonEdit1 = New DevExpress.XtraEditors.ButtonEdit
        Me.Panel17 = New System.Windows.Forms.Panel
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton
        Me.Panel18 = New System.Windows.Forms.Panel
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CH_MonVirt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_Nomenclature1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupMedVirt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.txtUCD13.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpLabo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpLabX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupListe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupProduitCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupStLab.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupProduit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUCD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCIS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel27.SuspendLayout()
        CType(Me.GC7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rm_MemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel28.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.GC6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        CType(Me.GC5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpCompl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        CType(Me.GC4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpFormePh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpVoie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.GC11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpSubActive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpComboSub, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpUnite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpExcipient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpUnite2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpNotoire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpTeneur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboTeneur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpUnite3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpUnite4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpComposition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.TextEdit15.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.GC13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpClasseEphmra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpClasseEphmra2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.GC25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpSPADMLIBELLE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.GC24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpSPTENLIBELLE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.PanDDD.SuspendLayout()
        CType(Me.GCDDD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDDD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupDDD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupDDD1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupATC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupEphemra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupATC2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupEphemra2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit21.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.lkupGestion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupGestion2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEdit_APHP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage5.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        CType(Me.GC19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpSMR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpAvisCom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpAvisCom2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpTransparence, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpTransparence2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpChoix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpRMO2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpRMO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpCLRMO_CLASSE_RMO2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpCLRMO_CLASSE_RMO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpCLRMO_CLASSE_RMO3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpInfoth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpInfoth2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage6.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.GC21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpPrix, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpPresDev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpPresDev2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage7.SuspendLayout()
        CType(Me.GC23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_Ref, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpRUB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpRef, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage8.SuspendLayout()
        Me.Panel14.SuspendLayout()
        CType(Me.GC31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rp_TypeURL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.XtraTabPage9.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel15.SuspendLayout()
        CType(Me.gcDocument, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDocument, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel16.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.meNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCategorie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibelle2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.beChemin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaqueURL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_Recap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.ButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel17.SuspendLayout()
        Me.Panel18.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(831, 573)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.XtraTabControl1)
        Me.PanMain.Controls.Add(Me.GroupBox1)
        Me.PanMain.Location = New System.Drawing.Point(0, 59)
        Me.PanMain.Size = New System.Drawing.Size(713, 514)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(831, 59)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(831, 28)
        Me.Label1.Text = "Spécialité"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(298, 33)
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(28, 33)
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(713, 59)
        Me.Panel1.Size = New System.Drawing.Size(118, 514)
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature1, "SP_SPECIALITE.SP_DATEMJ", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(370, 32)
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit1.TabIndex = 1
        '
        'GroupBox
        '
        Me.GroupBox.Location = New System.Drawing.Point(0, 51)
        Me.GroupBox.Size = New System.Drawing.Size(831, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature1, "SP_SPECIALITE.SP_DATECR", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(85, 31)
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit2.TabIndex = 0
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
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.CH_MonVirt)
        Me.GroupBox1.Controls.Add(Me.lkupMedVirt)
        Me.GroupBox1.Controls.Add(Me.txtLibelle)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.TextEdit1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(703, 58)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CH_MonVirt
        '
        Me.CH_MonVirt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature1, "SP_SPECIALITE.SP_MONO_VIRTUELLE", True))
        Me.CH_MonVirt.Location = New System.Drawing.Point(617, 11)
        Me.CH_MonVirt.Name = "CH_MonVirt"
        Me.CH_MonVirt.Properties.Caption = "Mono virt."
        Me.CH_MonVirt.Size = New System.Drawing.Size(81, 19)
        Me.CH_MonVirt.TabIndex = 6
        Me.CH_MonVirt.Tag = "[EDIT]"
        '
        'DsTheriaque_Nomenclature1
        '
        Me.DsTheriaque_Nomenclature1.DataSetName = "dsTheriaque_Nomenclature1"
        Me.DsTheriaque_Nomenclature1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lkupMedVirt
        '
        Me.lkupMedVirt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature1, "SP_SPECIALITE.SP_GSP_CODE_FK", True))
        Me.lkupMedVirt.Location = New System.Drawing.Point(223, 9)
        Me.lkupMedVirt.Name = "lkupMedVirt"
        Me.lkupMedVirt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupMedVirt.Properties.NullText = ""
        Me.lkupMedVirt.Size = New System.Drawing.Size(366, 20)
        Me.lkupMedVirt.TabIndex = 3
        Me.lkupMedVirt.Tag = "[NOEDIT][NOADD]"
        '
        'txtLibelle
        '
        Me.txtLibelle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLibelle.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature1, "SP_SPECIALITE.SP_NOM", True))
        Me.txtLibelle.Location = New System.Drawing.Point(223, 32)
        Me.txtLibelle.Name = "txtLibelle"
        Me.txtLibelle.Size = New System.Drawing.Size(327, 20)
        Me.txtLibelle.TabIndex = 5
        Me.txtLibelle.Tag = "[ADD][EDIT]"
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature1, "SP_SPECIALITE.SP_CODE_SQ_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(81, 32)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(84, 20)
        Me.txtCode.TabIndex = 4
        Me.txtCode.Tag = "[ADD][NOEDIT]"
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature1, "SP_SPECIALITE.SP_GSP_CODE_FK", True))
        Me.TextEdit1.Location = New System.Drawing.Point(81, 9)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(84, 20)
        Me.TextEdit1.TabIndex = 2
        Me.TextEdit1.Tag = "[NOADD][NOEDIT]"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(180, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Libellé"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(180, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Libellé"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Méd virt."
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Location = New System.Drawing.Point(4, 71)
        Me.XtraTabControl1.MultiLine = DevExpress.Utils.DefaultBoolean.[False]
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.[False]
        Me.XtraTabControl1.ShowToolTips = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Size = New System.Drawing.Size(704, 440)
        Me.XtraTabControl1.TabIndex = 6
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5, Me.XtraTabPage6, Me.XtraTabPage7, Me.XtraTabPage8, Me.XtraTabPage9})
        Me.XtraTabControl1.Text = "Spécialité"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.txtUCD13)
        Me.XtraTabPage1.Controls.Add(Me.Label14)
        Me.XtraTabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.XtraTabPage1.Controls.Add(Me.lkupListe)
        Me.XtraTabPage1.Controls.Add(Me.Label41)
        Me.XtraTabPage1.Controls.Add(Me.lkupProduitCode)
        Me.XtraTabPage1.Controls.Add(Me.lkupStLab)
        Me.XtraTabPage1.Controls.Add(Me.lkupProduit)
        Me.XtraTabPage1.Controls.Add(Me.GC1)
        Me.XtraTabPage1.Controls.Add(Me.txtNom)
        Me.XtraTabPage1.Controls.Add(Me.txtUCD)
        Me.XtraTabPage1.Controls.Add(Me.txtCIS)
        Me.XtraTabPage1.Controls.Add(Me.Label12)
        Me.XtraTabPage1.Controls.Add(Me.Label10)
        Me.XtraTabPage1.Controls.Add(Me.Label11)
        Me.XtraTabPage1.Controls.Add(Me.Label9)
        Me.XtraTabPage1.Controls.Add(Me.Label8)
        Me.XtraTabPage1.Controls.Add(Me.TextEdit5)
        Me.XtraTabPage1.Controls.Add(Me.Label6)
        Me.XtraTabPage1.Controls.Add(Me.Label7)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(695, 409)
        Me.XtraTabPage1.Tag = "[EDIT][ADD]"
        Me.XtraTabPage1.Text = "Identité"
        '
        'txtUCD13
        '
        Me.txtUCD13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUCD13.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature1, "SP_SPECIALITE.SP_CIPUCD13", True))
        Me.txtUCD13.Location = New System.Drawing.Point(118, 206)
        Me.txtUCD13.Name = "txtUCD13"
        Me.txtUCD13.Size = New System.Drawing.Size(201, 20)
        Me.txtUCD13.TabIndex = 48
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(46, 210)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "Code UCD13"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GC2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GC3, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 288)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(695, 121)
        Me.TableLayoutPanel1.TabIndex = 46
        '
        'GC2
        '
        Me.GC2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC2.DataMember = "SPLAB_SPECIALITE_LABO"
        Me.GC2.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC2.EmbeddedNavigator.Name = ""
        Me.GC2.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC2.Location = New System.Drawing.Point(3, 3)
        Me.GC2.MainView = Me.GV2
        Me.GC2.Name = "GC2"
        Me.GC2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpLabo})
        Me.GC2.Size = New System.Drawing.Size(341, 115)
        Me.GC2.TabIndex = 28
        Me.GC2.UseEmbeddedNavigator = True
        Me.GC2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSPLAB_SP_CODE_FK_PK, Me.colSPLAB_CDF_LAB_CODE_FK_PK})
        Me.GV2.GridControl = Me.GC2
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV2.OptionsView.ShowGroupPanel = False
        '
        'colSPLAB_SP_CODE_FK_PK
        '
        Me.colSPLAB_SP_CODE_FK_PK.Caption = "SPLAB_SP_CODE_FK_PK"
        Me.colSPLAB_SP_CODE_FK_PK.FieldName = "SPLAB_SP_CODE_FK_PK"
        Me.colSPLAB_SP_CODE_FK_PK.Name = "colSPLAB_SP_CODE_FK_PK"
        '
        'colSPLAB_CDF_LAB_CODE_FK_PK
        '
        Me.colSPLAB_CDF_LAB_CODE_FK_PK.Caption = "Laboratoire"
        Me.colSPLAB_CDF_LAB_CODE_FK_PK.ColumnEdit = Me.rpLabo
        Me.colSPLAB_CDF_LAB_CODE_FK_PK.FieldName = "SPLAB_CDF_LAB_CODE_FK_PK"
        Me.colSPLAB_CDF_LAB_CODE_FK_PK.Name = "colSPLAB_CDF_LAB_CODE_FK_PK"
        Me.colSPLAB_CDF_LAB_CODE_FK_PK.Visible = True
        Me.colSPLAB_CDF_LAB_CODE_FK_PK.VisibleIndex = 0
        '
        'rpLabo
        '
        Me.rpLabo.AutoHeight = False
        Me.rpLabo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpLabo.Name = "rpLabo"
        '
        'GC3
        '
        Me.GC3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC3.DataMember = "SPLABEX_SPE_LABO_EXPLOITANT"
        Me.GC3.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC3.EmbeddedNavigator.Name = ""
        Me.GC3.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC3.Location = New System.Drawing.Point(350, 3)
        Me.GC3.MainView = Me.GV3
        Me.GC3.Name = "GC3"
        Me.GC3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpLabX})
        Me.GC3.Size = New System.Drawing.Size(342, 115)
        Me.GC3.TabIndex = 29
        Me.GC3.UseEmbeddedNavigator = True
        Me.GC3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV3})
        '
        'GV3
        '
        Me.GV3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSPLABEX_SP_CODE_FK_PK, Me.colSPLABEX_CDF_LAB_CODE_FK_PK, Me.colSPLABEX_NUMORD})
        Me.GV3.GridControl = Me.GC3
        Me.GV3.Name = "GV3"
        Me.GV3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV3.OptionsView.ShowGroupPanel = False
        Me.GV3.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSPLABEX_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colSPLABEX_SP_CODE_FK_PK
        '
        Me.colSPLABEX_SP_CODE_FK_PK.Caption = "SPLABEX_SP_CODE_FK_PK"
        Me.colSPLABEX_SP_CODE_FK_PK.FieldName = "SPLABEX_SP_CODE_FK_PK"
        Me.colSPLABEX_SP_CODE_FK_PK.Name = "colSPLABEX_SP_CODE_FK_PK"
        '
        'colSPLABEX_CDF_LAB_CODE_FK_PK
        '
        Me.colSPLABEX_CDF_LAB_CODE_FK_PK.Caption = "Laboratoire exploitant"
        Me.colSPLABEX_CDF_LAB_CODE_FK_PK.ColumnEdit = Me.rpLabX
        Me.colSPLABEX_CDF_LAB_CODE_FK_PK.FieldName = "SPLABEX_CDF_LAB_CODE_FK_PK"
        Me.colSPLABEX_CDF_LAB_CODE_FK_PK.Name = "colSPLABEX_CDF_LAB_CODE_FK_PK"
        Me.colSPLABEX_CDF_LAB_CODE_FK_PK.Visible = True
        Me.colSPLABEX_CDF_LAB_CODE_FK_PK.VisibleIndex = 0
        Me.colSPLABEX_CDF_LAB_CODE_FK_PK.Width = 236
        '
        'rpLabX
        '
        Me.rpLabX.AutoHeight = False
        Me.rpLabX.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpLabX.Name = "rpLabX"
        '
        'colSPLABEX_NUMORD
        '
        Me.colSPLABEX_NUMORD.Caption = "N°"
        Me.colSPLABEX_NUMORD.FieldName = "SPLABEX_NUMORD"
        Me.colSPLABEX_NUMORD.Name = "colSPLABEX_NUMORD"
        Me.colSPLABEX_NUMORD.Visible = True
        Me.colSPLABEX_NUMORD.VisibleIndex = 1
        Me.colSPLABEX_NUMORD.Width = 38
        '
        'lkupListe
        '
        Me.lkupListe.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkupListe.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature1, "SP_SPECIALITE.SP_CDF_LI_CODE_FK", True))
        Me.lkupListe.Location = New System.Drawing.Point(118, 232)
        Me.lkupListe.Name = "lkupListe"
        Me.lkupListe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupListe.Size = New System.Drawing.Size(556, 20)
        Me.lkupListe.TabIndex = 7
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(86, 236)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(29, 13)
        Me.Label41.TabIndex = 45
        Me.Label41.Text = "Liste"
        '
        'lkupProduitCode
        '
        Me.lkupProduitCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature1, "SP_SPECIALITE.SP_PR_CODE_FK", True))
        Me.lkupProduitCode.Location = New System.Drawing.Point(118, 152)
        Me.lkupProduitCode.Name = "lkupProduitCode"
        Me.lkupProduitCode.Size = New System.Drawing.Size(78, 20)
        Me.lkupProduitCode.TabIndex = 3
        '
        'lkupStLab
        '
        Me.lkupStLab.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkupStLab.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature1, "SP_SPECIALITE.SP_CDF_SLAB_CODE_FK", True))
        Me.lkupStLab.Location = New System.Drawing.Point(118, 257)
        Me.lkupStLab.Name = "lkupStLab"
        Me.lkupStLab.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupStLab.Size = New System.Drawing.Size(317, 20)
        Me.lkupStLab.TabIndex = 8
        '
        'lkupProduit
        '
        Me.lkupProduit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkupProduit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature1, "SP_SPECIALITE.SP_PR_CODE_FK", True))
        Me.lkupProduit.Location = New System.Drawing.Point(202, 152)
        Me.lkupProduit.Name = "lkupProduit"
        Me.lkupProduit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.lkupProduit.Size = New System.Drawing.Size(472, 20)
        Me.lkupProduit.TabIndex = 4
        '
        'GC1
        '
        Me.GC1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC1.DataMember = "SYSP_SYNONYME_SPECIALITE"
        Me.GC1.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC1.EmbeddedNavigator.Name = ""
        Me.GC1.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC1.Location = New System.Drawing.Point(118, 60)
        Me.GC1.MainView = Me.GV1
        Me.GC1.Name = "GC1"
        Me.GC1.Size = New System.Drawing.Size(556, 84)
        Me.GC1.TabIndex = 2
        Me.GC1.UseEmbeddedNavigator = True
        Me.GC1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSYSP_NOM_PK, Me.colSYSP_SP_CODE_FK})
        Me.GV1.GridControl = Me.GC1
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV1.OptionsView.ShowGroupPanel = False
        '
        'colSYSP_NOM_PK
        '
        Me.colSYSP_NOM_PK.Caption = "Libellé"
        Me.colSYSP_NOM_PK.FieldName = "SYSP_NOM_PK"
        Me.colSYSP_NOM_PK.Name = "colSYSP_NOM_PK"
        Me.colSYSP_NOM_PK.Visible = True
        Me.colSYSP_NOM_PK.VisibleIndex = 0
        '
        'colSYSP_SP_CODE_FK
        '
        Me.colSYSP_SP_CODE_FK.Caption = "SYSP_SP_CODE_FK"
        Me.colSYSP_SP_CODE_FK.FieldName = "SYSP_SP_CODE_FK"
        Me.colSYSP_SP_CODE_FK.Name = "colSYSP_SP_CODE_FK"
        '
        'txtNom
        '
        Me.txtNom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNom.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature1, "SP_SPECIALITE.SP_NOMLONG", True))
        Me.txtNom.Location = New System.Drawing.Point(118, 8)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(556, 20)
        Me.txtNom.TabIndex = 0
        '
        'txtUCD
        '
        Me.txtUCD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUCD.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature1, "SP_SPECIALITE.SP_CIPUCD", True))
        Me.txtUCD.Location = New System.Drawing.Point(391, 177)
        Me.txtUCD.Name = "txtUCD"
        Me.txtUCD.Size = New System.Drawing.Size(283, 20)
        Me.txtUCD.TabIndex = 6
        '
        'txtCIS
        '
        Me.txtCIS.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature1, "SP_SPECIALITE.SP_NL", True))
        Me.txtCIS.Location = New System.Drawing.Point(118, 178)
        Me.txtCIS.Name = "txtCIS"
        Me.txtCIS.Properties.MaxLength = 11
        Me.txtCIS.Size = New System.Drawing.Size(186, 20)
        Me.txtCIS.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(28, 260)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Statut laboratoire"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(75, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Produit"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(327, 181)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Code UCD7"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Code identifiant spec"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(54, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Synonymes"
        '
        'TextEdit5
        '
        Me.TextEdit5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature1, "SP_SPECIALITE.SP_NOMCOMP", True))
        Me.TextEdit5.Location = New System.Drawing.Point(118, 34)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Size = New System.Drawing.Size(556, 20)
        Me.TextEdit5.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Complément du nom"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Libellé Complet"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Panel5)
        Me.XtraTabPage2.Controls.Add(Me.GroupBox4)
        Me.XtraTabPage2.Controls.Add(Me.Panel10)
        Me.XtraTabPage2.Controls.Add(Me.GC8)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(494, 402)
        Me.XtraTabPage2.Tag = "[EDIT]"
        Me.XtraTabPage2.Text = "Voie / forme"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel27)
        Me.Panel5.Controls.Add(Me.Panel28)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 355)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(494, 47)
        Me.Panel5.TabIndex = 43
        Me.Panel5.Tag = ""
        '
        'Panel27
        '
        Me.Panel27.Controls.Add(Me.GC7)
        Me.Panel27.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel27.Location = New System.Drawing.Point(0, 24)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(494, 23)
        Me.Panel27.TabIndex = 38
        Me.Panel27.Tag = "[ADD][EDIT]"
        '
        'GC7
        '
        Me.GC7.DataMember = "SPFOTX_SPE_FORME_TEXTE"
        Me.GC7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC7.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC7.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC7.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC7.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC7.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC7.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC7.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC7.EmbeddedNavigator.Name = ""
        Me.GC7.EmbeddedNavigator.TextStringFormat = ""
        Me.GC7.Location = New System.Drawing.Point(0, 0)
        Me.GC7.MainView = Me.GV7
        Me.GC7.Name = "GC7"
        Me.GC7.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rm_MemoEdit1})
        Me.GC7.Size = New System.Drawing.Size(494, 23)
        Me.GC7.TabIndex = 5
        Me.GC7.UseEmbeddedNavigator = True
        Me.GC7.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV7})
        '
        'GV7
        '
        Me.GV7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSPFOTX_SP_CODE_FK_PK, Me.colSPFOTX_TEXTE})
        Me.GV7.GridControl = Me.GC7
        Me.GV7.GroupFormat = ""
        Me.GV7.GroupPanelText = " "
        Me.GV7.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GV7.Name = "GV7"
        Me.GV7.OptionsCustomization.AllowRowSizing = True
        Me.GV7.OptionsNavigation.AutoFocusNewRow = True
        Me.GV7.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV7.OptionsView.ShowColumnHeaders = False
        Me.GV7.OptionsView.ShowDetailButtons = False
        Me.GV7.OptionsView.ShowGroupPanel = False
        Me.GV7.OptionsView.ShowHorzLines = False
        Me.GV7.OptionsView.ShowIndicator = False
        Me.GV7.RowHeight = 70
        Me.GV7.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colSPFOTX_SP_CODE_FK_PK
        '
        Me.colSPFOTX_SP_CODE_FK_PK.Caption = "SPFOTX_SP_CODE_FK_PK"
        Me.colSPFOTX_SP_CODE_FK_PK.FieldName = "SPFOTX_SP_CODE_FK_PK"
        Me.colSPFOTX_SP_CODE_FK_PK.Name = "colSPFOTX_SP_CODE_FK_PK"
        '
        'colSPFOTX_TEXTE
        '
        Me.colSPFOTX_TEXTE.Caption = "SPFOTX_TEXTE"
        Me.colSPFOTX_TEXTE.ColumnEdit = Me.rm_MemoEdit1
        Me.colSPFOTX_TEXTE.FieldName = "SPFOTX_TEXTE"
        Me.colSPFOTX_TEXTE.Name = "colSPFOTX_TEXTE"
        Me.colSPFOTX_TEXTE.Visible = True
        Me.colSPFOTX_TEXTE.VisibleIndex = 0
        '
        'rm_MemoEdit1
        '
        Me.rm_MemoEdit1.Name = "rm_MemoEdit1"
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
        Me.LabelControl7.Size = New System.Drawing.Size(139, 13)
        Me.LabelControl7.TabIndex = 19
        Me.LabelControl7.Text = "Texte forme pharmaceutique"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.Panel12)
        Me.GroupBox4.Controls.Add(Me.Panel11)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(0, 219)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(494, 136)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.GC6)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(311, 16)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(180, 117)
        Me.Panel12.TabIndex = 0
        '
        'GC6
        '
        Me.GC6.DataMember = "SPFO_SPECIALITE_FORME.FK_SPFO_SPECIALITE_FORME_SPFOCPI_SPE_FORME_COMPINFO"
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
        Me.GC6.Location = New System.Drawing.Point(0, 0)
        Me.GC6.MainView = Me.GV6
        Me.GC6.Name = "GC6"
        Me.GC6.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpInfo})
        Me.GC6.Size = New System.Drawing.Size(180, 117)
        Me.GC6.TabIndex = 1
        Me.GC6.UseEmbeddedNavigator = True
        Me.GC6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV6})
        '
        'GV6
        '
        Me.GV6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSPFOCPI_SP_CODE_FK_PK, Me.colSPFOCPI_CDF_FO_CODE_FK_PK, Me.colSPFOCPI_SPFO_NUMSEQ_FK_PK, Me.colSPFOCPI_CDF_CPI_CODE_FK_PK, Me.colSPFOCPI_NUMORD})
        Me.GV6.GridControl = Me.GC6
        Me.GV6.Name = "GV6"
        Me.GV6.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV6.OptionsView.ShowGroupPanel = False
        Me.GV6.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSPFOCPI_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colSPFOCPI_SP_CODE_FK_PK
        '
        Me.colSPFOCPI_SP_CODE_FK_PK.Caption = "SPFOCPI_SP_CODE_FK_PK"
        Me.colSPFOCPI_SP_CODE_FK_PK.FieldName = "SPFOCPI_SP_CODE_FK_PK"
        Me.colSPFOCPI_SP_CODE_FK_PK.Name = "colSPFOCPI_SP_CODE_FK_PK"
        '
        'colSPFOCPI_CDF_FO_CODE_FK_PK
        '
        Me.colSPFOCPI_CDF_FO_CODE_FK_PK.Caption = "SPFOCPI_CDF_FO_CODE_FK_PK"
        Me.colSPFOCPI_CDF_FO_CODE_FK_PK.FieldName = "SPFOCPI_CDF_FO_CODE_FK_PK"
        Me.colSPFOCPI_CDF_FO_CODE_FK_PK.Name = "colSPFOCPI_CDF_FO_CODE_FK_PK"
        '
        'colSPFOCPI_SPFO_NUMSEQ_FK_PK
        '
        Me.colSPFOCPI_SPFO_NUMSEQ_FK_PK.Caption = "SPFOCPI_SPFO_NUMSEQ_FK_PK"
        Me.colSPFOCPI_SPFO_NUMSEQ_FK_PK.FieldName = "SPFOCPI_SPFO_NUMSEQ_FK_PK"
        Me.colSPFOCPI_SPFO_NUMSEQ_FK_PK.Name = "colSPFOCPI_SPFO_NUMSEQ_FK_PK"
        '
        'colSPFOCPI_CDF_CPI_CODE_FK_PK
        '
        Me.colSPFOCPI_CDF_CPI_CODE_FK_PK.Caption = "Info complémentaire"
        Me.colSPFOCPI_CDF_CPI_CODE_FK_PK.ColumnEdit = Me.rpInfo
        Me.colSPFOCPI_CDF_CPI_CODE_FK_PK.FieldName = "SPFOCPI_CDF_CPI_CODE_FK_PK"
        Me.colSPFOCPI_CDF_CPI_CODE_FK_PK.Name = "colSPFOCPI_CDF_CPI_CODE_FK_PK"
        Me.colSPFOCPI_CDF_CPI_CODE_FK_PK.Visible = True
        Me.colSPFOCPI_CDF_CPI_CODE_FK_PK.VisibleIndex = 0
        Me.colSPFOCPI_CDF_CPI_CODE_FK_PK.Width = 223
        '
        'rpInfo
        '
        Me.rpInfo.AutoHeight = False
        Me.rpInfo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpInfo.Name = "rpInfo"
        Me.rpInfo.NullText = ""
        '
        'colSPFOCPI_NUMORD
        '
        Me.colSPFOCPI_NUMORD.Caption = "N°"
        Me.colSPFOCPI_NUMORD.FieldName = "SPFOCPI_NUMORD"
        Me.colSPFOCPI_NUMORD.Name = "colSPFOCPI_NUMORD"
        Me.colSPFOCPI_NUMORD.Visible = True
        Me.colSPFOCPI_NUMORD.VisibleIndex = 1
        Me.colSPFOCPI_NUMORD.Width = 50
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.GC5)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(3, 16)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(308, 117)
        Me.Panel11.TabIndex = 0
        '
        'GC5
        '
        Me.GC5.DataMember = "SPFO_SPECIALITE_FORME.FK_SPFO_SPECIALITE_FORME_SPFOCFO_SPE_FORME_COMPFORME"
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
        Me.GC5.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpCompl})
        Me.GC5.Size = New System.Drawing.Size(308, 117)
        Me.GC5.TabIndex = 0
        Me.GC5.UseEmbeddedNavigator = True
        Me.GC5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV5})
        '
        'GV5
        '
        Me.GV5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSPFOCFO_SP_CODE_FK_PK, Me.colSPFOCFO_CDF_FO_CODE_FK_PK, Me.colSPFOCFO_SPFO_NUMSEQ_FK_PK, Me.colSPFOCFO_CDF_CFO_CODE_FK_PK, Me.colSPFOCFO_NUMORD})
        Me.GV5.GridControl = Me.GC5
        Me.GV5.Name = "GV5"
        Me.GV5.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV5.OptionsView.ShowGroupPanel = False
        Me.GV5.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSPFOCFO_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colSPFOCFO_SP_CODE_FK_PK
        '
        Me.colSPFOCFO_SP_CODE_FK_PK.Caption = "SPFOCFO_SP_CODE_FK_PK"
        Me.colSPFOCFO_SP_CODE_FK_PK.FieldName = "SPFOCFO_SP_CODE_FK_PK"
        Me.colSPFOCFO_SP_CODE_FK_PK.Name = "colSPFOCFO_SP_CODE_FK_PK"
        '
        'colSPFOCFO_CDF_FO_CODE_FK_PK
        '
        Me.colSPFOCFO_CDF_FO_CODE_FK_PK.Caption = "SPFOCFO_CDF_FO_CODE_FK_PK"
        Me.colSPFOCFO_CDF_FO_CODE_FK_PK.FieldName = "SPFOCFO_CDF_FO_CODE_FK_PK"
        Me.colSPFOCFO_CDF_FO_CODE_FK_PK.Name = "colSPFOCFO_CDF_FO_CODE_FK_PK"
        '
        'colSPFOCFO_SPFO_NUMSEQ_FK_PK
        '
        Me.colSPFOCFO_SPFO_NUMSEQ_FK_PK.Caption = "SPFOCFO_SPFO_NUMSEQ_FK_PK"
        Me.colSPFOCFO_SPFO_NUMSEQ_FK_PK.FieldName = "SPFOCFO_SPFO_NUMSEQ_FK_PK"
        Me.colSPFOCFO_SPFO_NUMSEQ_FK_PK.Name = "colSPFOCFO_SPFO_NUMSEQ_FK_PK"
        '
        'colSPFOCFO_CDF_CFO_CODE_FK_PK
        '
        Me.colSPFOCFO_CDF_CFO_CODE_FK_PK.Caption = "Complément de forme"
        Me.colSPFOCFO_CDF_CFO_CODE_FK_PK.ColumnEdit = Me.rpCompl
        Me.colSPFOCFO_CDF_CFO_CODE_FK_PK.FieldName = "SPFOCFO_CDF_CFO_CODE_FK_PK"
        Me.colSPFOCFO_CDF_CFO_CODE_FK_PK.Name = "colSPFOCFO_CDF_CFO_CODE_FK_PK"
        Me.colSPFOCFO_CDF_CFO_CODE_FK_PK.Visible = True
        Me.colSPFOCFO_CDF_CFO_CODE_FK_PK.VisibleIndex = 0
        Me.colSPFOCFO_CDF_CFO_CODE_FK_PK.Width = 143
        '
        'rpCompl
        '
        Me.rpCompl.AutoHeight = False
        Me.rpCompl.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpCompl.Name = "rpCompl"
        Me.rpCompl.NullText = ""
        '
        'colSPFOCFO_NUMORD
        '
        Me.colSPFOCFO_NUMORD.Caption = "N°"
        Me.colSPFOCFO_NUMORD.FieldName = "SPFOCFO_NUMORD"
        Me.colSPFOCFO_NUMORD.Name = "colSPFOCFO_NUMORD"
        Me.colSPFOCFO_NUMORD.Visible = True
        Me.colSPFOCFO_NUMORD.VisibleIndex = 1
        Me.colSPFOCFO_NUMORD.Width = 50
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.GC4)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 108)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(494, 111)
        Me.Panel10.TabIndex = 31
        '
        'GC4
        '
        Me.GC4.DataMember = "SPFO_SPECIALITE_FORME"
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
        Me.GC4.Location = New System.Drawing.Point(0, 0)
        Me.GC4.MainView = Me.GV4
        Me.GC4.Name = "GC4"
        Me.GC4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpFormePh})
        Me.GC4.Size = New System.Drawing.Size(494, 111)
        Me.GC4.TabIndex = 2
        Me.GC4.UseEmbeddedNavigator = True
        Me.GC4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV4})
        '
        'GV4
        '
        Me.GV4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSPFO_SP_CODE_FK_PK, Me.colSPFO_CDF_FO_CODE_FK_PK, Me.colSPFO_NUMSEQ_PK, Me.colSPFO_NUMORD})
        Me.GV4.CustomizationFormBounds = New System.Drawing.Rectangle(463, 385, 208, 172)
        Me.GV4.GridControl = Me.GC4
        Me.GV4.Name = "GV4"
        Me.GV4.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV4.OptionsView.ShowDetailButtons = False
        Me.GV4.OptionsView.ShowGroupPanel = False
        Me.GV4.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSPFO_NUMSEQ_PK, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSPFO_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colSPFO_SP_CODE_FK_PK
        '
        Me.colSPFO_SP_CODE_FK_PK.Caption = "SPFO_SP_CODE_FK_PK"
        Me.colSPFO_SP_CODE_FK_PK.FieldName = "SPFO_SP_CODE_FK_PK"
        Me.colSPFO_SP_CODE_FK_PK.Name = "colSPFO_SP_CODE_FK_PK"
        Me.colSPFO_SP_CODE_FK_PK.Width = 142
        '
        'colSPFO_CDF_FO_CODE_FK_PK
        '
        Me.colSPFO_CDF_FO_CODE_FK_PK.Caption = "Forme pharmaceutique"
        Me.colSPFO_CDF_FO_CODE_FK_PK.ColumnEdit = Me.rpFormePh
        Me.colSPFO_CDF_FO_CODE_FK_PK.FieldName = "SPFO_CDF_FO_CODE_FK_PK"
        Me.colSPFO_CDF_FO_CODE_FK_PK.Name = "colSPFO_CDF_FO_CODE_FK_PK"
        Me.colSPFO_CDF_FO_CODE_FK_PK.Visible = True
        Me.colSPFO_CDF_FO_CODE_FK_PK.VisibleIndex = 0
        Me.colSPFO_CDF_FO_CODE_FK_PK.Width = 416
        '
        'rpFormePh
        '
        Me.rpFormePh.AutoHeight = False
        Me.rpFormePh.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpFormePh.Name = "rpFormePh"
        Me.rpFormePh.NullText = ""
        '
        'colSPFO_NUMSEQ_PK
        '
        Me.colSPFO_NUMSEQ_PK.Caption = "colSPFO_NUMSEQ_PK"
        Me.colSPFO_NUMSEQ_PK.FieldName = "SPFO_NUMSEQ_PK"
        Me.colSPFO_NUMSEQ_PK.Name = "colSPFO_NUMSEQ_PK"
        Me.colSPFO_NUMSEQ_PK.Width = 50
        '
        'colSPFO_NUMORD
        '
        Me.colSPFO_NUMORD.Caption = "N°"
        Me.colSPFO_NUMORD.FieldName = "SPFO_NUMORD"
        Me.colSPFO_NUMORD.Name = "colSPFO_NUMORD"
        Me.colSPFO_NUMORD.Visible = True
        Me.colSPFO_NUMORD.VisibleIndex = 1
        Me.colSPFO_NUMORD.Width = 53
        '
        'GC8
        '
        Me.GC8.DataMember = "SPVO_SPECIALITE_VOIE"
        Me.GC8.Dock = System.Windows.Forms.DockStyle.Top
        Me.GC8.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC8.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC8.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC8.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC8.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC8.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC8.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC8.EmbeddedNavigator.Name = ""
        Me.GC8.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC8.Location = New System.Drawing.Point(0, 0)
        Me.GC8.MainView = Me.GV8
        Me.GC8.Name = "GC8"
        Me.GC8.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpVoie})
        Me.GC8.Size = New System.Drawing.Size(494, 108)
        Me.GC8.TabIndex = 0
        Me.GC8.Tag = "[ADD]"
        Me.GC8.UseEmbeddedNavigator = True
        Me.GC8.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV8})
        '
        'GV8
        '
        Me.GV8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSPVO_SP_CODE_FK_PK, Me.colSPVO_CDF_VO_CODE_FK_PK, Me.colSPVO_NUMSEQ})
        Me.GV8.GridControl = Me.GC8
        Me.GV8.Name = "GV8"
        Me.GV8.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV8.OptionsView.ShowGroupPanel = False
        Me.GV8.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSPVO_NUMSEQ, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colSPVO_SP_CODE_FK_PK
        '
        Me.colSPVO_SP_CODE_FK_PK.Caption = "SPVO_SP_CODE_FK_PK"
        Me.colSPVO_SP_CODE_FK_PK.FieldName = "SPVO_SP_CODE_FK_PK"
        Me.colSPVO_SP_CODE_FK_PK.Name = "colSPVO_SP_CODE_FK_PK"
        Me.colSPVO_SP_CODE_FK_PK.Width = 184
        '
        'colSPVO_CDF_VO_CODE_FK_PK
        '
        Me.colSPVO_CDF_VO_CODE_FK_PK.Caption = "Voie d’administration"
        Me.colSPVO_CDF_VO_CODE_FK_PK.ColumnEdit = Me.rpVoie
        Me.colSPVO_CDF_VO_CODE_FK_PK.FieldName = "SPVO_CDF_VO_CODE_FK_PK"
        Me.colSPVO_CDF_VO_CODE_FK_PK.Name = "colSPVO_CDF_VO_CODE_FK_PK"
        Me.colSPVO_CDF_VO_CODE_FK_PK.Visible = True
        Me.colSPVO_CDF_VO_CODE_FK_PK.VisibleIndex = 0
        Me.colSPVO_CDF_VO_CODE_FK_PK.Width = 533
        '
        'rpVoie
        '
        Me.rpVoie.AutoHeight = False
        Me.rpVoie.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpVoie.Name = "rpVoie"
        Me.rpVoie.NullText = ""
        '
        'colSPVO_NUMSEQ
        '
        Me.colSPVO_NUMSEQ.Caption = "N°"
        Me.colSPVO_NUMSEQ.FieldName = "SPVO_NUMSEQ"
        Me.colSPVO_NUMSEQ.Name = "colSPVO_NUMSEQ"
        Me.colSPVO_NUMSEQ.Visible = True
        Me.colSPVO_NUMSEQ.VisibleIndex = 1
        Me.colSPVO_NUMSEQ.Width = 50
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.TableLayoutPanel5)
        Me.XtraTabPage3.Controls.Add(Me.Panel3)
        Me.XtraTabPage3.Controls.Add(Me.Label22)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(494, 402)
        Me.XtraTabPage3.Tag = "[EDIT][ADD]"
        Me.XtraTabPage3.Text = "Composition"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Panel8, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.GC12, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.GC9, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 3
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(494, 374)
        Me.TableLayoutPanel5.TabIndex = 37
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel8.Controls.Add(Me.TableLayoutPanel6)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(3, 89)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel8.Size = New System.Drawing.Size(488, 195)
        Me.Panel8.TabIndex = 36
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.GC11, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.GC10, 0, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(484, 191)
        Me.TableLayoutPanel6.TabIndex = 2
        '
        'GC11
        '
        Me.GC11.DataMember = "COMPO_COMPOSITION.FK3_COSAC_COMPO_SUBACT"
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
        Me.GC11.Location = New System.Drawing.Point(3, 3)
        Me.GC11.MainView = Me.GV11
        Me.GC11.Name = "GC11"
        Me.GC11.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpSubActive, Me.rpUnite, Me.rpComboSub})
        Me.GC11.Size = New System.Drawing.Size(478, 89)
        Me.GC11.TabIndex = 0
        Me.GC11.UseEmbeddedNavigator = True
        Me.GC11.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV11})
        '
        'GV11
        '
        Me.GV11.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCOSAC_SAC_CODE_FK_PK, Me.colCOSAC_SP_CODE_FK_PK, Me.colCOSAC_DOSAGE, Me.colCOSAC_UNITEDOSAGE, Me.colCOSAC_COMPO_NUM_PK, Me.colCOSAC_SAC_BASE_CODE_FK, Me.colCOSAC_DOSAGE_BASE, Me.colCOSAC_NUMORD})
        Me.GV11.GridControl = Me.GC11
        Me.GV11.Name = "GV11"
        Me.GV11.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV11.OptionsView.ShowGroupPanel = False
        Me.GV11.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCOSAC_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colCOSAC_SAC_CODE_FK_PK
        '
        Me.colCOSAC_SAC_CODE_FK_PK.Caption = "Substance active"
        Me.colCOSAC_SAC_CODE_FK_PK.ColumnEdit = Me.rpSubActive
        Me.colCOSAC_SAC_CODE_FK_PK.FieldName = "COSAC_SAC_CODE_FK_PK"
        Me.colCOSAC_SAC_CODE_FK_PK.Name = "colCOSAC_SAC_CODE_FK_PK"
        Me.colCOSAC_SAC_CODE_FK_PK.Visible = True
        Me.colCOSAC_SAC_CODE_FK_PK.VisibleIndex = 0
        Me.colCOSAC_SAC_CODE_FK_PK.Width = 104
        '
        'rpSubActive
        '
        Me.rpSubActive.AutoHeight = False
        Me.rpSubActive.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpSubActive.Name = "rpSubActive"
        '
        'colCOSAC_SP_CODE_FK_PK
        '
        Me.colCOSAC_SP_CODE_FK_PK.Caption = "COSAC_SP_CODE_FK_PK"
        Me.colCOSAC_SP_CODE_FK_PK.FieldName = "COSAC_SP_CODE_FK_PK"
        Me.colCOSAC_SP_CODE_FK_PK.Name = "colCOSAC_SP_CODE_FK_PK"
        '
        'colCOSAC_DOSAGE
        '
        Me.colCOSAC_DOSAGE.Caption = "Dosage"
        Me.colCOSAC_DOSAGE.ColumnEdit = Me.rpComboSub
        Me.colCOSAC_DOSAGE.FieldName = "COSAC_DOSAGE"
        Me.colCOSAC_DOSAGE.Name = "colCOSAC_DOSAGE"
        Me.colCOSAC_DOSAGE.Visible = True
        Me.colCOSAC_DOSAGE.VisibleIndex = 1
        '
        'rpComboSub
        '
        Me.rpComboSub.AutoHeight = False
        Me.rpComboSub.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpComboSub.Items.AddRange(New Object() {"NON RENSEIGNE"})
        Me.rpComboSub.Name = "rpComboSub"
        '
        'colCOSAC_UNITEDOSAGE
        '
        Me.colCOSAC_UNITEDOSAGE.Caption = "Unité"
        Me.colCOSAC_UNITEDOSAGE.ColumnEdit = Me.rpUnite
        Me.colCOSAC_UNITEDOSAGE.FieldName = "COSAC_UNITEDOSAGE"
        Me.colCOSAC_UNITEDOSAGE.Name = "colCOSAC_UNITEDOSAGE"
        Me.colCOSAC_UNITEDOSAGE.Visible = True
        Me.colCOSAC_UNITEDOSAGE.VisibleIndex = 2
        Me.colCOSAC_UNITEDOSAGE.Width = 77
        '
        'rpUnite
        '
        Me.rpUnite.AutoHeight = False
        Me.rpUnite.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpUnite.Name = "rpUnite"
        '
        'colCOSAC_COMPO_NUM_PK
        '
        Me.colCOSAC_COMPO_NUM_PK.Caption = "COSAC_COMPO_NUM_PK"
        Me.colCOSAC_COMPO_NUM_PK.FieldName = "COSAC_COMPO_NUM_PK"
        Me.colCOSAC_COMPO_NUM_PK.Name = "colCOSAC_COMPO_NUM_PK"
        '
        'colCOSAC_SAC_BASE_CODE_FK
        '
        Me.colCOSAC_SAC_BASE_CODE_FK.Caption = "Base"
        Me.colCOSAC_SAC_BASE_CODE_FK.ColumnEdit = Me.rpSubActive
        Me.colCOSAC_SAC_BASE_CODE_FK.FieldName = "COSAC_SAC_BASE_CODE_FK"
        Me.colCOSAC_SAC_BASE_CODE_FK.Name = "colCOSAC_SAC_BASE_CODE_FK"
        Me.colCOSAC_SAC_BASE_CODE_FK.Visible = True
        Me.colCOSAC_SAC_BASE_CODE_FK.VisibleIndex = 3
        Me.colCOSAC_SAC_BASE_CODE_FK.Width = 130
        '
        'colCOSAC_DOSAGE_BASE
        '
        Me.colCOSAC_DOSAGE_BASE.Caption = "Dosage"
        Me.colCOSAC_DOSAGE_BASE.FieldName = "COSAC_DOSAGE_BASE"
        Me.colCOSAC_DOSAGE_BASE.Name = "colCOSAC_DOSAGE_BASE"
        Me.colCOSAC_DOSAGE_BASE.Visible = True
        Me.colCOSAC_DOSAGE_BASE.VisibleIndex = 4
        Me.colCOSAC_DOSAGE_BASE.Width = 146
        '
        'colCOSAC_NUMORD
        '
        Me.colCOSAC_NUMORD.Caption = "N°"
        Me.colCOSAC_NUMORD.FieldName = "COSAC_NUMORD"
        Me.colCOSAC_NUMORD.Name = "colCOSAC_NUMORD"
        Me.colCOSAC_NUMORD.Visible = True
        Me.colCOSAC_NUMORD.VisibleIndex = 5
        Me.colCOSAC_NUMORD.Width = 46
        '
        'GC10
        '
        Me.GC10.DataMember = "COMPO_COMPOSITION.FK3_COSAU_COMPO_SUBAUX"
        Me.GC10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC10.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC10.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC10.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC10.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC10.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC10.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC10.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC10.EmbeddedNavigator.Name = ""
        Me.GC10.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC10.Location = New System.Drawing.Point(3, 98)
        Me.GC10.MainView = Me.GV10
        Me.GC10.Name = "GC10"
        Me.GC10.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpExcipient, Me.rpUnite2, Me.rpNotoire})
        Me.GC10.Size = New System.Drawing.Size(478, 90)
        Me.GC10.TabIndex = 1
        Me.GC10.UseEmbeddedNavigator = True
        Me.GC10.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV10})
        '
        'GV10
        '
        Me.GV10.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCOSAU_SAU_CODE_FK_PK, Me.colCOSAU_SP_CODE_FK_PK, Me.colCOSAU_DOSAGE, Me.colCOSAU_UNITEDOSAGE, Me.colCOSAU_COMPO_NUM_PK, Me.colCOSAU_GREF_CODE_FK, Me.colCOSAU_GREF_DATECR_FK, Me.colCOSAU_GREF_NUMORD, Me.colCOSAU_NUMORD, Me.colCOSAU_SAU_CODE_FK_PK2})
        Me.GV10.GridControl = Me.GC10
        Me.GV10.Name = "GV10"
        Me.GV10.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV10.OptionsView.ShowGroupPanel = False
        Me.GV10.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCOSAU_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colCOSAU_SAU_CODE_FK_PK
        '
        Me.colCOSAU_SAU_CODE_FK_PK.Caption = "Excipient"
        Me.colCOSAU_SAU_CODE_FK_PK.ColumnEdit = Me.rpExcipient
        Me.colCOSAU_SAU_CODE_FK_PK.FieldName = "COSAU_SAU_CODE_FK_PK"
        Me.colCOSAU_SAU_CODE_FK_PK.Name = "colCOSAU_SAU_CODE_FK_PK"
        Me.colCOSAU_SAU_CODE_FK_PK.Visible = True
        Me.colCOSAU_SAU_CODE_FK_PK.VisibleIndex = 0
        Me.colCOSAU_SAU_CODE_FK_PK.Width = 159
        '
        'rpExcipient
        '
        Me.rpExcipient.AutoHeight = False
        Me.rpExcipient.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpExcipient.Name = "rpExcipient"
        Me.rpExcipient.NullText = ""
        '
        'colCOSAU_SP_CODE_FK_PK
        '
        Me.colCOSAU_SP_CODE_FK_PK.Caption = "COSAU_SP_CODE_FK_PK"
        Me.colCOSAU_SP_CODE_FK_PK.FieldName = "COSAU_SP_CODE_FK_PK"
        Me.colCOSAU_SP_CODE_FK_PK.Name = "colCOSAU_SP_CODE_FK_PK"
        '
        'colCOSAU_DOSAGE
        '
        Me.colCOSAU_DOSAGE.Caption = "Dosage"
        Me.colCOSAU_DOSAGE.FieldName = "COSAU_DOSAGE"
        Me.colCOSAU_DOSAGE.Name = "colCOSAU_DOSAGE"
        Me.colCOSAU_DOSAGE.Visible = True
        Me.colCOSAU_DOSAGE.VisibleIndex = 1
        Me.colCOSAU_DOSAGE.Width = 126
        '
        'colCOSAU_UNITEDOSAGE
        '
        Me.colCOSAU_UNITEDOSAGE.Caption = "Unité"
        Me.colCOSAU_UNITEDOSAGE.ColumnEdit = Me.rpUnite2
        Me.colCOSAU_UNITEDOSAGE.FieldName = "COSAU_UNITEDOSAGE"
        Me.colCOSAU_UNITEDOSAGE.Name = "colCOSAU_UNITEDOSAGE"
        Me.colCOSAU_UNITEDOSAGE.Visible = True
        Me.colCOSAU_UNITEDOSAGE.VisibleIndex = 2
        Me.colCOSAU_UNITEDOSAGE.Width = 89
        '
        'rpUnite2
        '
        Me.rpUnite2.AutoHeight = False
        Me.rpUnite2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpUnite2.Name = "rpUnite2"
        Me.rpUnite2.NullText = ""
        '
        'colCOSAU_COMPO_NUM_PK
        '
        Me.colCOSAU_COMPO_NUM_PK.Caption = "COSAU_COMPO_NUM_PK"
        Me.colCOSAU_COMPO_NUM_PK.FieldName = "COSAU_COMPO_NUM_PK"
        Me.colCOSAU_COMPO_NUM_PK.Name = "colCOSAU_COMPO_NUM_PK"
        Me.colCOSAU_COMPO_NUM_PK.Width = 62
        '
        'colCOSAU_GREF_CODE_FK
        '
        Me.colCOSAU_GREF_CODE_FK.Caption = "COSAU_GREF_CODE_FK"
        Me.colCOSAU_GREF_CODE_FK.FieldName = "COSAU_GREF_CODE_FK"
        Me.colCOSAU_GREF_CODE_FK.Name = "colCOSAU_GREF_CODE_FK"
        Me.colCOSAU_GREF_CODE_FK.Width = 62
        '
        'colCOSAU_GREF_DATECR_FK
        '
        Me.colCOSAU_GREF_DATECR_FK.Caption = "COSAU_GREF_DATECR_FK"
        Me.colCOSAU_GREF_DATECR_FK.FieldName = "COSAU_GREF_DATECR_FK"
        Me.colCOSAU_GREF_DATECR_FK.Name = "colCOSAU_GREF_DATECR_FK"
        Me.colCOSAU_GREF_DATECR_FK.Width = 62
        '
        'colCOSAU_GREF_NUMORD
        '
        Me.colCOSAU_GREF_NUMORD.Caption = "COSAU_GREF_NUMORD"
        Me.colCOSAU_GREF_NUMORD.FieldName = "COSAU_GREF_NUMORD"
        Me.colCOSAU_GREF_NUMORD.Name = "colCOSAU_GREF_NUMORD"
        Me.colCOSAU_GREF_NUMORD.Width = 62
        '
        'colCOSAU_NUMORD
        '
        Me.colCOSAU_NUMORD.Caption = "N°"
        Me.colCOSAU_NUMORD.FieldName = "COSAU_NUMORD"
        Me.colCOSAU_NUMORD.Name = "colCOSAU_NUMORD"
        Me.colCOSAU_NUMORD.Visible = True
        Me.colCOSAU_NUMORD.VisibleIndex = 4
        Me.colCOSAU_NUMORD.Width = 46
        '
        'colCOSAU_SAU_CODE_FK_PK2
        '
        Me.colCOSAU_SAU_CODE_FK_PK2.Caption = "Effet notoire"
        Me.colCOSAU_SAU_CODE_FK_PK2.ColumnEdit = Me.rpNotoire
        Me.colCOSAU_SAU_CODE_FK_PK2.FieldName = "COSAU_SAU_CODE_FK_PK"
        Me.colCOSAU_SAU_CODE_FK_PK2.Name = "colCOSAU_SAU_CODE_FK_PK2"
        Me.colCOSAU_SAU_CODE_FK_PK2.OptionsColumn.ReadOnly = True
        Me.colCOSAU_SAU_CODE_FK_PK2.Visible = True
        Me.colCOSAU_SAU_CODE_FK_PK2.VisibleIndex = 3
        Me.colCOSAU_SAU_CODE_FK_PK2.Width = 157
        '
        'rpNotoire
        '
        Me.rpNotoire.AutoHeight = False
        Me.rpNotoire.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpNotoire.Name = "rpNotoire"
        Me.rpNotoire.NullText = ""
        '
        'GC12
        '
        Me.GC12.DataMember = "COTEN_COMPO_TENEUR"
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
        Me.GC12.Location = New System.Drawing.Point(3, 290)
        Me.GC12.MainView = Me.GV12
        Me.GC12.Name = "GC12"
        Me.GC12.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpTeneur, Me.rpUnite3, Me.rpUnite4, Me.comboTeneur})
        Me.GC12.Size = New System.Drawing.Size(488, 81)
        Me.GC12.TabIndex = 2
        Me.GC12.UseEmbeddedNavigator = True
        Me.GC12.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV12})
        '
        'GV12
        '
        Me.GV12.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCOTEN_SP_CODE_FK_PK, Me.colCOTEN_CDF_TEN_CODE_FK_PK, Me.colCOTEN_QUALIFICATIF, Me.colCOTEN_DOSAGE, Me.colCOTEN_CDF_UD_CODE_FK, Me.colCOTEN_DOSAGE_EQUIV, Me.colCOTEN_CDF_UD_EQUIV_CODE_FK, Me.colCOTEN_NUMORD})
        Me.GV12.GridControl = Me.GC12
        Me.GV12.Name = "GV12"
        Me.GV12.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV12.OptionsView.ShowGroupPanel = False
        Me.GV12.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCOTEN_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colCOTEN_SP_CODE_FK_PK
        '
        Me.colCOTEN_SP_CODE_FK_PK.Caption = "COTEN_SP_CODE_FK_PK"
        Me.colCOTEN_SP_CODE_FK_PK.FieldName = "COTEN_SP_CODE_FK_PK"
        Me.colCOTEN_SP_CODE_FK_PK.Name = "colCOTEN_SP_CODE_FK_PK"
        '
        'colCOTEN_CDF_TEN_CODE_FK_PK
        '
        Me.colCOTEN_CDF_TEN_CODE_FK_PK.Caption = "Teneur"
        Me.colCOTEN_CDF_TEN_CODE_FK_PK.ColumnEdit = Me.rpTeneur
        Me.colCOTEN_CDF_TEN_CODE_FK_PK.FieldName = "COTEN_CDF_TEN_CODE_FK_PK"
        Me.colCOTEN_CDF_TEN_CODE_FK_PK.Name = "colCOTEN_CDF_TEN_CODE_FK_PK"
        Me.colCOTEN_CDF_TEN_CODE_FK_PK.Visible = True
        Me.colCOTEN_CDF_TEN_CODE_FK_PK.VisibleIndex = 0
        Me.colCOTEN_CDF_TEN_CODE_FK_PK.Width = 170
        '
        'rpTeneur
        '
        Me.rpTeneur.AutoHeight = False
        Me.rpTeneur.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpTeneur.Name = "rpTeneur"
        '
        'colCOTEN_QUALIFICATIF
        '
        Me.colCOTEN_QUALIFICATIF.Caption = "Qualif."
        Me.colCOTEN_QUALIFICATIF.ColumnEdit = Me.comboTeneur
        Me.colCOTEN_QUALIFICATIF.FieldName = "COTEN_QUALIFICATIF"
        Me.colCOTEN_QUALIFICATIF.Name = "colCOTEN_QUALIFICATIF"
        Me.colCOTEN_QUALIFICATIF.Visible = True
        Me.colCOTEN_QUALIFICATIF.VisibleIndex = 1
        Me.colCOTEN_QUALIFICATIF.Width = 69
        '
        'comboTeneur
        '
        Me.comboTeneur.AutoHeight = False
        Me.comboTeneur.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.comboTeneur.Items.AddRange(New Object() {"<", ">", "<=", ">=", "QSP"})
        Me.comboTeneur.Name = "comboTeneur"
        '
        'colCOTEN_DOSAGE
        '
        Me.colCOTEN_DOSAGE.Caption = "Dosage"
        Me.colCOTEN_DOSAGE.FieldName = "COTEN_DOSAGE"
        Me.colCOTEN_DOSAGE.Name = "colCOTEN_DOSAGE"
        Me.colCOTEN_DOSAGE.Visible = True
        Me.colCOTEN_DOSAGE.VisibleIndex = 2
        Me.colCOTEN_DOSAGE.Width = 68
        '
        'colCOTEN_CDF_UD_CODE_FK
        '
        Me.colCOTEN_CDF_UD_CODE_FK.Caption = "Unité"
        Me.colCOTEN_CDF_UD_CODE_FK.ColumnEdit = Me.rpUnite3
        Me.colCOTEN_CDF_UD_CODE_FK.FieldName = "COTEN_CDF_UD_CODE_FK"
        Me.colCOTEN_CDF_UD_CODE_FK.Name = "colCOTEN_CDF_UD_CODE_FK"
        Me.colCOTEN_CDF_UD_CODE_FK.Visible = True
        Me.colCOTEN_CDF_UD_CODE_FK.VisibleIndex = 3
        Me.colCOTEN_CDF_UD_CODE_FK.Width = 69
        '
        'rpUnite3
        '
        Me.rpUnite3.AutoHeight = False
        Me.rpUnite3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpUnite3.Name = "rpUnite3"
        '
        'colCOTEN_DOSAGE_EQUIV
        '
        Me.colCOTEN_DOSAGE_EQUIV.Caption = "Dosage"
        Me.colCOTEN_DOSAGE_EQUIV.FieldName = "COTEN_DOSAGE_EQUIV"
        Me.colCOTEN_DOSAGE_EQUIV.Name = "colCOTEN_DOSAGE_EQUIV"
        Me.colCOTEN_DOSAGE_EQUIV.Visible = True
        Me.colCOTEN_DOSAGE_EQUIV.VisibleIndex = 4
        Me.colCOTEN_DOSAGE_EQUIV.Width = 68
        '
        'colCOTEN_CDF_UD_EQUIV_CODE_FK
        '
        Me.colCOTEN_CDF_UD_EQUIV_CODE_FK.Caption = "Equivalent"
        Me.colCOTEN_CDF_UD_EQUIV_CODE_FK.ColumnEdit = Me.rpUnite4
        Me.colCOTEN_CDF_UD_EQUIV_CODE_FK.FieldName = "COTEN_CDF_UD_EQUIV_CODE_FK"
        Me.colCOTEN_CDF_UD_EQUIV_CODE_FK.Name = "colCOTEN_CDF_UD_EQUIV_CODE_FK"
        Me.colCOTEN_CDF_UD_EQUIV_CODE_FK.Visible = True
        Me.colCOTEN_CDF_UD_EQUIV_CODE_FK.VisibleIndex = 5
        Me.colCOTEN_CDF_UD_EQUIV_CODE_FK.Width = 87
        '
        'rpUnite4
        '
        Me.rpUnite4.AutoHeight = False
        Me.rpUnite4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpUnite4.Name = "rpUnite4"
        '
        'colCOTEN_NUMORD
        '
        Me.colCOTEN_NUMORD.Caption = "N°"
        Me.colCOTEN_NUMORD.FieldName = "COTEN_NUMORD"
        Me.colCOTEN_NUMORD.Name = "colCOTEN_NUMORD"
        Me.colCOTEN_NUMORD.Visible = True
        Me.colCOTEN_NUMORD.VisibleIndex = 6
        Me.colCOTEN_NUMORD.Width = 46
        '
        'GC9
        '
        Me.GC9.DataMember = "COMPO_COMPOSITION"
        Me.GC9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC9.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC9.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC9.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC9.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC9.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC9.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC9.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC9.EmbeddedNavigator.Name = ""
        Me.GC9.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC9.Location = New System.Drawing.Point(3, 3)
        Me.GC9.MainView = Me.GV9
        Me.GC9.Name = "GC9"
        Me.GC9.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpComposition})
        Me.GC9.Size = New System.Drawing.Size(488, 80)
        Me.GC9.TabIndex = 0
        Me.GC9.UseEmbeddedNavigator = True
        Me.GC9.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV9})
        '
        'GV9
        '
        Me.GV9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCOMPO_SP_CODE_FK_PK, Me.colCOMPO_NUM_PK, Me.colCOMPO_CDF_GAL_CODE_FK})
        Me.GV9.GridControl = Me.GC9
        Me.GV9.Name = "GV9"
        Me.GV9.OptionsDetail.ShowDetailTabs = False
        Me.GV9.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV9.OptionsView.ShowDetailButtons = False
        Me.GV9.OptionsView.ShowGroupPanel = False
        '
        'colCOMPO_SP_CODE_FK_PK
        '
        Me.colCOMPO_SP_CODE_FK_PK.Caption = "COMPO_SP_CODE_FK_PK"
        Me.colCOMPO_SP_CODE_FK_PK.FieldName = "COMPO_SP_CODE_FK_PK"
        Me.colCOMPO_SP_CODE_FK_PK.Name = "colCOMPO_SP_CODE_FK_PK"
        Me.colCOMPO_SP_CODE_FK_PK.Width = 104
        '
        'colCOMPO_NUM_PK
        '
        Me.colCOMPO_NUM_PK.Caption = "Composition N°"
        Me.colCOMPO_NUM_PK.FieldName = "COMPO_NUM_PK"
        Me.colCOMPO_NUM_PK.Name = "colCOMPO_NUM_PK"
        Me.colCOMPO_NUM_PK.OptionsColumn.AllowFocus = False
        Me.colCOMPO_NUM_PK.OptionsColumn.ReadOnly = True
        Me.colCOMPO_NUM_PK.Visible = True
        Me.colCOMPO_NUM_PK.VisibleIndex = 0
        Me.colCOMPO_NUM_PK.Width = 92
        '
        'colCOMPO_CDF_GAL_CODE_FK
        '
        Me.colCOMPO_CDF_GAL_CODE_FK.Caption = "Libellé composition"
        Me.colCOMPO_CDF_GAL_CODE_FK.ColumnEdit = Me.rpComposition
        Me.colCOMPO_CDF_GAL_CODE_FK.FieldName = "COMPO_CDF_GAL_CODE_FK"
        Me.colCOMPO_CDF_GAL_CODE_FK.Name = "colCOMPO_CDF_GAL_CODE_FK"
        Me.colCOMPO_CDF_GAL_CODE_FK.Visible = True
        Me.colCOMPO_CDF_GAL_CODE_FK.VisibleIndex = 1
        Me.colCOMPO_CDF_GAL_CODE_FK.Width = 493
        '
        'rpComposition
        '
        Me.rpComposition.AutoHeight = False
        Me.rpComposition.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpComposition.Name = "rpComposition"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TextEdit15)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 374)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(494, 28)
        Me.Panel3.TabIndex = 36
        '
        'TextEdit15
        '
        Me.TextEdit15.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature1, "SP_SPECIALITE.SP_PH", True))
        Me.TextEdit15.Location = New System.Drawing.Point(33, 3)
        Me.TextEdit15.Name = "TextEdit15"
        Me.TextEdit15.Size = New System.Drawing.Size(85, 20)
        Me.TextEdit15.TabIndex = 4
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(5, 6)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(22, 13)
        Me.Label24.TabIndex = 35
        Me.Label24.Text = "PH"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(559, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(0, 13)
        Me.Label22.TabIndex = 35
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.TableLayoutPanel7)
        Me.XtraTabPage4.Controls.Add(Me.GroupBox3)
        Me.XtraTabPage4.Controls.Add(Me.Panel9)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(494, 402)
        Me.XtraTabPage4.Tag = "[EDIT][ADD]"
        Me.XtraTabPage4.Text = "Classes"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.GC13, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.Panel13, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(494, 154)
        Me.TableLayoutPanel7.TabIndex = 44
        '
        'GC13
        '
        Me.GC13.DataMember = "SPCPH_SPECIALITE_CLASSEPH"
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
        Me.GC13.Location = New System.Drawing.Point(3, 80)
        Me.GC13.MainView = Me.GV13
        Me.GC13.Name = "GC13"
        Me.GC13.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpClasseEphmra, Me.rpClasseEphmra2})
        Me.GC13.Size = New System.Drawing.Size(488, 71)
        Me.GC13.TabIndex = 1
        Me.GC13.UseEmbeddedNavigator = True
        Me.GC13.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV13})
        '
        'GV13
        '
        Me.GV13.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSPCPH_SP_CODE_FK_PK, Me.colSPCPH_CPH_CODE_FK_PK, Me.colSPCPH_NUMORD, Me.colSPCPH_CPH_CODE_FK_PK2})
        Me.GV13.GridControl = Me.GC13
        Me.GV13.Name = "GV13"
        Me.GV13.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV13.OptionsView.ShowGroupPanel = False
        Me.GV13.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSPCPH_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colSPCPH_SP_CODE_FK_PK
        '
        Me.colSPCPH_SP_CODE_FK_PK.Caption = "SPCPH_SP_CODE_FK_PK"
        Me.colSPCPH_SP_CODE_FK_PK.FieldName = "SPCPH_SP_CODE_FK_PK"
        Me.colSPCPH_SP_CODE_FK_PK.Name = "colSPCPH_SP_CODE_FK_PK"
        '
        'colSPCPH_CPH_CODE_FK_PK
        '
        Me.colSPCPH_CPH_CODE_FK_PK.Caption = "Pharmaco-thérapeutique"
        Me.colSPCPH_CPH_CODE_FK_PK.ColumnEdit = Me.rpClasseEphmra
        Me.colSPCPH_CPH_CODE_FK_PK.FieldName = "SPCPH_CPH_CODE_FK_PK"
        Me.colSPCPH_CPH_CODE_FK_PK.Name = "colSPCPH_CPH_CODE_FK_PK"
        Me.colSPCPH_CPH_CODE_FK_PK.Visible = True
        Me.colSPCPH_CPH_CODE_FK_PK.VisibleIndex = 1
        Me.colSPCPH_CPH_CODE_FK_PK.Width = 515
        '
        'rpClasseEphmra
        '
        Me.rpClasseEphmra.AutoHeight = False
        Me.rpClasseEphmra.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpClasseEphmra.Name = "rpClasseEphmra"
        '
        'colSPCPH_NUMORD
        '
        Me.colSPCPH_NUMORD.Caption = "N°"
        Me.colSPCPH_NUMORD.FieldName = "SPCPH_NUMORD"
        Me.colSPCPH_NUMORD.Name = "colSPCPH_NUMORD"
        Me.colSPCPH_NUMORD.Visible = True
        Me.colSPCPH_NUMORD.VisibleIndex = 2
        '
        'colSPCPH_CPH_CODE_FK_PK2
        '
        Me.colSPCPH_CPH_CODE_FK_PK2.Caption = "Code"
        Me.colSPCPH_CPH_CODE_FK_PK2.ColumnEdit = Me.rpClasseEphmra2
        Me.colSPCPH_CPH_CODE_FK_PK2.FieldName = "SPCPH_CPH_CODE_FK_PK"
        Me.colSPCPH_CPH_CODE_FK_PK2.Name = "colSPCPH_CPH_CODE_FK_PK2"
        Me.colSPCPH_CPH_CODE_FK_PK2.Visible = True
        Me.colSPCPH_CPH_CODE_FK_PK2.VisibleIndex = 0
        Me.colSPCPH_CPH_CODE_FK_PK2.Width = 85
        '
        'rpClasseEphmra2
        '
        Me.rpClasseEphmra2.AutoHeight = False
        Me.rpClasseEphmra2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpClasseEphmra2.Name = "rpClasseEphmra2"
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.Location = New System.Drawing.Point(3, 3)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(488, 71)
        Me.Panel13.TabIndex = 42
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(488, 71)
        Me.TableLayoutPanel2.TabIndex = 44
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label25, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.GC25, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(247, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(238, 65)
        Me.TableLayoutPanel3.TabIndex = 44
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(3, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(206, 13)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Texte sur propriétés pharmacodynamiques"
        '
        'GC25
        '
        Me.GC25.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC25.DataMember = "SPADM_SPECIALITE_MODEADM"
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
        Me.GC25.Location = New System.Drawing.Point(3, 23)
        Me.GC25.MainView = Me.GV25
        Me.GC25.Name = "GC25"
        Me.GC25.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpSPADMLIBELLE})
        Me.GC25.Size = New System.Drawing.Size(232, 100)
        Me.GC25.TabIndex = 44
        Me.GC25.UseEmbeddedNavigator = True
        Me.GC25.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV25})
        '
        'GV25
        '
        Me.GV25.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSPADM_SP_CODE_FK_PK, Me.colSPADM_LIBELLE})
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
        Me.GV25.RowHeight = 82
        Me.GV25.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colSPADM_SP_CODE_FK_PK
        '
        Me.colSPADM_SP_CODE_FK_PK.Caption = "SPADM_SP_CODE_FK_PK"
        Me.colSPADM_SP_CODE_FK_PK.FieldName = "SPADM_SP_CODE_FK_PK"
        Me.colSPADM_SP_CODE_FK_PK.Name = "colSPADM_SP_CODE_FK_PK"
        '
        'colSPADM_LIBELLE
        '
        Me.colSPADM_LIBELLE.Caption = "SPADM_LIBELLE"
        Me.colSPADM_LIBELLE.ColumnEdit = Me.rpSPADMLIBELLE
        Me.colSPADM_LIBELLE.FieldName = "SPADM_LIBELLE"
        Me.colSPADM_LIBELLE.Name = "colSPADM_LIBELLE"
        Me.colSPADM_LIBELLE.Visible = True
        Me.colSPADM_LIBELLE.VisibleIndex = 0
        '
        'rpSPADMLIBELLE
        '
        Me.rpSPADMLIBELLE.Name = "rpSPADMLIBELLE"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.GC24, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(238, 65)
        Me.TableLayoutPanel4.TabIndex = 45
        '
        'GC24
        '
        Me.GC24.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC24.DataMember = "SPTEN_SPECIALITE_TENEUR"
        Me.GC24.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC24.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC24.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC24.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC24.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC24.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC24.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC24.EmbeddedNavigator.Name = ""
        Me.GC24.EmbeddedNavigator.TextStringFormat = ""
        Me.GC24.Location = New System.Drawing.Point(3, 23)
        Me.GC24.MainView = Me.GV24
        Me.GC24.Name = "GC24"
        Me.GC24.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpSPTENLIBELLE})
        Me.GC24.Size = New System.Drawing.Size(232, 39)
        Me.GC24.TabIndex = 43
        Me.GC24.UseEmbeddedNavigator = True
        Me.GC24.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV24})
        '
        'GV24
        '
        Me.GV24.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSPTEN_SP_CODE_FK_PK, Me.colSPTEN_LIBELLE})
        Me.GV24.GridControl = Me.GC24
        Me.GV24.GroupFormat = ""
        Me.GV24.GroupPanelText = " "
        Me.GV24.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GV24.Name = "GV24"
        Me.GV24.OptionsNavigation.AutoFocusNewRow = True
        Me.GV24.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV24.OptionsView.ShowColumnHeaders = False
        Me.GV24.OptionsView.ShowDetailButtons = False
        Me.GV24.OptionsView.ShowGroupPanel = False
        Me.GV24.OptionsView.ShowHorzLines = False
        Me.GV24.OptionsView.ShowIndicator = False
        Me.GV24.RowHeight = 85
        Me.GV24.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colSPTEN_SP_CODE_FK_PK
        '
        Me.colSPTEN_SP_CODE_FK_PK.Caption = "SPTEN_SP_CODE_FK_PK"
        Me.colSPTEN_SP_CODE_FK_PK.FieldName = "SPTEN_SP_CODE_FK_PK"
        Me.colSPTEN_SP_CODE_FK_PK.Name = "colSPTEN_SP_CODE_FK_PK"
        '
        'colSPTEN_LIBELLE
        '
        Me.colSPTEN_LIBELLE.Caption = "SPTEN_LIBELLE"
        Me.colSPTEN_LIBELLE.ColumnEdit = Me.rpSPTENLIBELLE
        Me.colSPTEN_LIBELLE.FieldName = "SPTEN_LIBELLE"
        Me.colSPTEN_LIBELLE.Name = "colSPTEN_LIBELLE"
        Me.colSPTEN_LIBELLE.Visible = True
        Me.colSPTEN_LIBELLE.VisibleIndex = 0
        '
        'rpSPTENLIBELLE
        '
        Me.rpSPTENLIBELLE.Name = "rpSPTENLIBELLE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Info composition "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.PanDDD)
        Me.GroupBox3.Controls.Add(Me.lkupATC)
        Me.GroupBox3.Controls.Add(Me.lkupEphemra)
        Me.GroupBox3.Controls.Add(Me.lkupATC2)
        Me.GroupBox3.Controls.Add(Me.lkupEphemra2)
        Me.GroupBox3.Controls.Add(Me.TextEdit21)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Location = New System.Drawing.Point(0, 154)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(494, 194)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(22, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 13)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "DDD"
        '
        'PanDDD
        '
        Me.PanDDD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanDDD.Controls.Add(Me.btDDD)
        Me.PanDDD.Controls.Add(Me.GCDDD)
        Me.PanDDD.Location = New System.Drawing.Point(54, 39)
        Me.PanDDD.Name = "PanDDD"
        Me.PanDDD.Size = New System.Drawing.Size(421, 93)
        Me.PanDDD.TabIndex = 48
        Me.PanDDD.Tag = "[NOADD][EDIT]"
        '
        'btDDD
        '
        Me.btDDD.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btDDD.Location = New System.Drawing.Point(161, 75)
        Me.btDDD.Name = "btDDD"
        Me.btDDD.Size = New System.Drawing.Size(34, 15)
        Me.btDDD.TabIndex = 5
        Me.btDDD.Text = "+"
        '
        'GCDDD
        '
        Me.GCDDD.DataMember = "SPDDD_DOSE_USUELLE_JOUR"
        Me.GCDDD.DataSource = Me.DsTheriaque_Nomenclature1
        Me.GCDDD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCDDD.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GCDDD.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GCDDD.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GCDDD.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GCDDD.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GCDDD.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GCDDD.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GCDDD.EmbeddedNavigator.Name = ""
        Me.GCDDD.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GCDDD.Location = New System.Drawing.Point(0, 0)
        Me.GCDDD.MainView = Me.GVDDD
        Me.GCDDD.Name = "GCDDD"
        Me.GCDDD.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkupDDD, Me.lkupDDD1})
        Me.GCDDD.Size = New System.Drawing.Size(421, 93)
        Me.GCDDD.TabIndex = 1
        Me.GCDDD.Tag = "[ADD]"
        Me.GCDDD.UseEmbeddedNavigator = True
        Me.GCDDD.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDDD})
        '
        'GVDDD
        '
        Me.GVDDD.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSPDDD_SP_CODE_FK_PK, Me.colSPDDD_ATCDDD_CATC_CODE_FK_PK, Me.colSPDDD_ATCDDD_CDF_VO_CODE_FK_PK, Me.colSPDDD_ATCDDD_DOSAGE_PK, Me.colSPDDD_ATCDDD_CDF_UD_CODE_FK_PK, Me.colSPDDD_NUMORD})
        Me.GVDDD.GridControl = Me.GCDDD
        Me.GVDDD.Name = "GVDDD"
        Me.GVDDD.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GVDDD.OptionsView.ShowGroupPanel = False
        '
        'colSPDDD_SP_CODE_FK_PK
        '
        Me.colSPDDD_SP_CODE_FK_PK.Caption = "SPDDD_SP_CODE_FK_PK"
        Me.colSPDDD_SP_CODE_FK_PK.FieldName = "SPDDD_SP_CODE_FK_PK"
        Me.colSPDDD_SP_CODE_FK_PK.Name = "colSPDDD_SP_CODE_FK_PK"
        '
        'colSPDDD_ATCDDD_CATC_CODE_FK_PK
        '
        Me.colSPDDD_ATCDDD_CATC_CODE_FK_PK.Caption = "SPDDD_ATCDDD_CATC_CODE_FK_PK"
        Me.colSPDDD_ATCDDD_CATC_CODE_FK_PK.FieldName = "SPDDD_ATCDDD_CATC_CODE_FK_PK"
        Me.colSPDDD_ATCDDD_CATC_CODE_FK_PK.Name = "colSPDDD_ATCDDD_CATC_CODE_FK_PK"
        '
        'colSPDDD_ATCDDD_CDF_VO_CODE_FK_PK
        '
        Me.colSPDDD_ATCDDD_CDF_VO_CODE_FK_PK.Caption = "Voie"
        Me.colSPDDD_ATCDDD_CDF_VO_CODE_FK_PK.ColumnEdit = Me.lkupDDD
        Me.colSPDDD_ATCDDD_CDF_VO_CODE_FK_PK.FieldName = "SPDDD_ATCDDD_CDF_VO_CODE_FK_PK"
        Me.colSPDDD_ATCDDD_CDF_VO_CODE_FK_PK.Name = "colSPDDD_ATCDDD_CDF_VO_CODE_FK_PK"
        Me.colSPDDD_ATCDDD_CDF_VO_CODE_FK_PK.OptionsColumn.ReadOnly = True
        Me.colSPDDD_ATCDDD_CDF_VO_CODE_FK_PK.Visible = True
        Me.colSPDDD_ATCDDD_CDF_VO_CODE_FK_PK.VisibleIndex = 0
        '
        'lkupDDD
        '
        Me.lkupDDD.AutoHeight = False
        Me.lkupDDD.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupDDD.Name = "lkupDDD"
        '
        'colSPDDD_ATCDDD_DOSAGE_PK
        '
        Me.colSPDDD_ATCDDD_DOSAGE_PK.Caption = "Dosage"
        Me.colSPDDD_ATCDDD_DOSAGE_PK.FieldName = "SPDDD_ATCDDD_DOSAGE_PK"
        Me.colSPDDD_ATCDDD_DOSAGE_PK.Name = "colSPDDD_ATCDDD_DOSAGE_PK"
        Me.colSPDDD_ATCDDD_DOSAGE_PK.OptionsColumn.ReadOnly = True
        Me.colSPDDD_ATCDDD_DOSAGE_PK.Visible = True
        Me.colSPDDD_ATCDDD_DOSAGE_PK.VisibleIndex = 1
        '
        'colSPDDD_ATCDDD_CDF_UD_CODE_FK_PK
        '
        Me.colSPDDD_ATCDDD_CDF_UD_CODE_FK_PK.Caption = "Unité"
        Me.colSPDDD_ATCDDD_CDF_UD_CODE_FK_PK.ColumnEdit = Me.lkupDDD1
        Me.colSPDDD_ATCDDD_CDF_UD_CODE_FK_PK.FieldName = "SPDDD_ATCDDD_CDF_UD_CODE_FK_PK"
        Me.colSPDDD_ATCDDD_CDF_UD_CODE_FK_PK.Name = "colSPDDD_ATCDDD_CDF_UD_CODE_FK_PK"
        Me.colSPDDD_ATCDDD_CDF_UD_CODE_FK_PK.OptionsColumn.ReadOnly = True
        Me.colSPDDD_ATCDDD_CDF_UD_CODE_FK_PK.Visible = True
        Me.colSPDDD_ATCDDD_CDF_UD_CODE_FK_PK.VisibleIndex = 2
        '
        'lkupDDD1
        '
        Me.lkupDDD1.AutoHeight = False
        Me.lkupDDD1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupDDD1.Name = "lkupDDD1"
        '
        'colSPDDD_NUMORD
        '
        Me.colSPDDD_NUMORD.Caption = "SPDDD_NUMORD"
        Me.colSPDDD_NUMORD.FieldName = "SPDDD_NUMORD"
        Me.colSPDDD_NUMORD.Name = "colSPDDD_NUMORD"
        '
        'lkupATC
        '
        Me.lkupATC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature1, "SP_SPECIALITE.SP_CATC_CODE_FK", True))
        Me.lkupATC.Location = New System.Drawing.Point(54, 13)
        Me.lkupATC.Name = "lkupATC"
        Me.lkupATC.Size = New System.Drawing.Size(77, 20)
        Me.lkupATC.TabIndex = 0
        '
        'lkupEphemra
        '
        Me.lkupEphemra.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature1, "SP_SPECIALITE.SP_CEPH_CODE_FK", True))
        Me.lkupEphemra.Location = New System.Drawing.Point(54, 167)
        Me.lkupEphemra.Name = "lkupEphemra"
        Me.lkupEphemra.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupEphemra.Size = New System.Drawing.Size(78, 20)
        Me.lkupEphemra.TabIndex = 7
        '
        'lkupATC2
        '
        Me.lkupATC2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkupATC2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature1, "SP_SPECIALITE.SP_CATC_CODE_FK", True))
        Me.lkupATC2.Location = New System.Drawing.Point(137, 13)
        Me.lkupATC2.Name = "lkupATC2"
        Me.lkupATC2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupATC2.Size = New System.Drawing.Size(338, 20)
        Me.lkupATC2.TabIndex = 1
        '
        'lkupEphemra2
        '
        Me.lkupEphemra2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkupEphemra2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature1, "SP_SPECIALITE.SP_CEPH_CODE_FK", True))
        Me.lkupEphemra2.Location = New System.Drawing.Point(137, 167)
        Me.lkupEphemra2.Name = "lkupEphemra2"
        Me.lkupEphemra2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupEphemra2.Size = New System.Drawing.Size(338, 20)
        Me.lkupEphemra2.TabIndex = 8
        '
        'TextEdit21
        '
        Me.TextEdit21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextEdit21.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature1, "SP_SPECIALITE.SP_ATC_DDD_TEXTE", True))
        Me.TextEdit21.Location = New System.Drawing.Point(54, 141)
        Me.TextEdit21.Name = "TextEdit21"
        Me.TextEdit21.Size = New System.Drawing.Size(421, 20)
        Me.TextEdit21.TabIndex = 6
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(16, 144)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(34, 13)
        Me.Label29.TabIndex = 40
        Me.Label29.Text = "Texte"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(22, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(28, 13)
        Me.Label27.TabIndex = 40
        Me.Label27.Text = "ATC"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(1, 170)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(49, 13)
        Me.Label30.TabIndex = 40
        Me.Label30.Text = "Ephemra"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.lkupGestion)
        Me.Panel9.Controls.Add(Me.Label31)
        Me.Panel9.Controls.Add(Me.lkupGestion2)
        Me.Panel9.Controls.Add(Me.Label32)
        Me.Panel9.Controls.Add(Me.TxtEdit_APHP)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 348)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(494, 54)
        Me.Panel9.TabIndex = 43
        '
        'lkupGestion
        '
        Me.lkupGestion.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature1, "SP_SPECIALITE.SP_CGE_CODE_FK", True))
        Me.lkupGestion.Location = New System.Drawing.Point(65, 3)
        Me.lkupGestion.Name = "lkupGestion"
        Me.lkupGestion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupGestion.Size = New System.Drawing.Size(109, 20)
        Me.lkupGestion.TabIndex = 3
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(13, 7)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(43, 13)
        Me.Label31.TabIndex = 40
        Me.Label31.Text = "Gestion"
        '
        'lkupGestion2
        '
        Me.lkupGestion2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature1, "SP_SPECIALITE.SP_CGE_CODE_FK", True))
        Me.lkupGestion2.Location = New System.Drawing.Point(180, 4)
        Me.lkupGestion2.Name = "lkupGestion2"
        Me.lkupGestion2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupGestion2.Size = New System.Drawing.Size(421, 20)
        Me.lkupGestion2.TabIndex = 4
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(0, 33)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(64, 13)
        Me.Label32.TabIndex = 40
        Me.Label32.Text = "Code APHP"
        '
        'TxtEdit_APHP
        '
        Me.TxtEdit_APHP.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature1, "SP_SPECIALITE.SP_APHP", True))
        Me.TxtEdit_APHP.Location = New System.Drawing.Point(65, 29)
        Me.TxtEdit_APHP.Name = "TxtEdit_APHP"
        Me.TxtEdit_APHP.Size = New System.Drawing.Size(109, 20)
        Me.TxtEdit_APHP.TabIndex = 5
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.TableLayoutPanel8)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(494, 402)
        Me.XtraTabPage5.Tag = "[EDIT][ADD]"
        Me.XtraTabPage5.Text = "Textes annexes"
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.GC19, 1, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.GC18, 1, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.GC17, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.GC14, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.GC15, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.GC16, 0, 2)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 3
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(494, 402)
        Me.TableLayoutPanel8.TabIndex = 2
        '
        'GC19
        '
        Me.GC19.DataMember = "SPSMR_SERVICE_MEDICAL_RENDU"
        Me.GC19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC19.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC19.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC19.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC19.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC19.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC19.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC19.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC19.EmbeddedNavigator.Name = ""
        Me.GC19.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC19.Location = New System.Drawing.Point(250, 271)
        Me.GC19.MainView = Me.GV19
        Me.GC19.Name = "GC19"
        Me.GC19.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpSMR})
        Me.GC19.Size = New System.Drawing.Size(241, 128)
        Me.GC19.TabIndex = 2
        Me.GC19.Tag = ""
        Me.GC19.UseEmbeddedNavigator = True
        Me.GC19.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV19})
        '
        'GV19
        '
        Me.GV19.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSPSMR_SP_CODE_FK_PK, Me.colSPSMR_CDF_SMR_CODE_FK_PK, Me.colSPSMR_NUM_ORD_PK, Me.colSPSMR_DATE})
        Me.GV19.GridControl = Me.GC19
        Me.GV19.Name = "GV19"
        Me.GV19.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV19.OptionsView.ShowGroupPanel = False
        Me.GV19.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSPSMR_DATE, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colSPSMR_SP_CODE_FK_PK
        '
        Me.colSPSMR_SP_CODE_FK_PK.Caption = "SPSMR_SP_CODE_FK_PK"
        Me.colSPSMR_SP_CODE_FK_PK.FieldName = "SPSMR_SP_CODE_FK_PK"
        Me.colSPSMR_SP_CODE_FK_PK.Name = "colSPSMR_SP_CODE_FK_PK"
        '
        'colSPSMR_CDF_SMR_CODE_FK_PK
        '
        Me.colSPSMR_CDF_SMR_CODE_FK_PK.Caption = "SMR"
        Me.colSPSMR_CDF_SMR_CODE_FK_PK.ColumnEdit = Me.rpSMR
        Me.colSPSMR_CDF_SMR_CODE_FK_PK.FieldName = "SPSMR_CDF_SMR_CODE_FK_PK"
        Me.colSPSMR_CDF_SMR_CODE_FK_PK.Name = "colSPSMR_CDF_SMR_CODE_FK_PK"
        Me.colSPSMR_CDF_SMR_CODE_FK_PK.Visible = True
        Me.colSPSMR_CDF_SMR_CODE_FK_PK.VisibleIndex = 0
        Me.colSPSMR_CDF_SMR_CODE_FK_PK.Width = 136
        '
        'rpSMR
        '
        Me.rpSMR.AutoHeight = False
        Me.rpSMR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpSMR.Name = "rpSMR"
        Me.rpSMR.NullText = ""
        '
        'colSPSMR_NUM_ORD_PK
        '
        Me.colSPSMR_NUM_ORD_PK.Caption = "N°"
        Me.colSPSMR_NUM_ORD_PK.FieldName = "SPSMR_NUM_ORD_PK"
        Me.colSPSMR_NUM_ORD_PK.Name = "colSPSMR_NUM_ORD_PK"
        Me.colSPSMR_NUM_ORD_PK.Visible = True
        Me.colSPSMR_NUM_ORD_PK.VisibleIndex = 2
        Me.colSPSMR_NUM_ORD_PK.Width = 46
        '
        'colSPSMR_DATE
        '
        Me.colSPSMR_DATE.Caption = "Date"
        Me.colSPSMR_DATE.FieldName = "SPSMR_DATE"
        Me.colSPSMR_DATE.Name = "colSPSMR_DATE"
        Me.colSPSMR_DATE.OptionsColumn.ReadOnly = True
        Me.colSPSMR_DATE.Visible = True
        Me.colSPSMR_DATE.VisibleIndex = 1
        Me.colSPSMR_DATE.Width = 102
        '
        'GC18
        '
        Me.GC18.DataMember = "SPATR_SPEC_AVISTRANSPARENCE"
        Me.GC18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC18.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC18.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC18.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC18.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC18.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC18.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC18.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC18.EmbeddedNavigator.Name = ""
        Me.GC18.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC18.Location = New System.Drawing.Point(250, 137)
        Me.GC18.MainView = Me.GV18
        Me.GC18.Name = "GC18"
        Me.GC18.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpAvisCom, Me.rpAvisCom2})
        Me.GC18.Size = New System.Drawing.Size(241, 128)
        Me.GC18.TabIndex = 1
        Me.GC18.UseEmbeddedNavigator = True
        Me.GC18.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV18})
        '
        'GV18
        '
        Me.GV18.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSPATR_SP_CODE_FK_PK, Me.colSPATR_ATR_CODE_FK_PK, Me.colSPATR_ATR_CODE_FK_PK2})
        Me.GV18.GridControl = Me.GC18
        Me.GV18.Name = "GV18"
        Me.GV18.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV18.OptionsView.ShowGroupPanel = False
        '
        'colSPATR_SP_CODE_FK_PK
        '
        Me.colSPATR_SP_CODE_FK_PK.Caption = "SPATR_SP_CODE_FK_PK"
        Me.colSPATR_SP_CODE_FK_PK.FieldName = "SPATR_SP_CODE_FK_PK"
        Me.colSPATR_SP_CODE_FK_PK.Name = "colSPATR_SP_CODE_FK_PK"
        '
        'colSPATR_ATR_CODE_FK_PK
        '
        Me.colSPATR_ATR_CODE_FK_PK.Caption = "Avis commission trans.  "
        Me.colSPATR_ATR_CODE_FK_PK.ColumnEdit = Me.rpAvisCom
        Me.colSPATR_ATR_CODE_FK_PK.FieldName = "SPATR_ATR_CODE_FK_PK"
        Me.colSPATR_ATR_CODE_FK_PK.Name = "colSPATR_ATR_CODE_FK_PK"
        Me.colSPATR_ATR_CODE_FK_PK.Visible = True
        Me.colSPATR_ATR_CODE_FK_PK.VisibleIndex = 1
        Me.colSPATR_ATR_CODE_FK_PK.Width = 210
        '
        'rpAvisCom
        '
        Me.rpAvisCom.AutoHeight = False
        Me.rpAvisCom.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpAvisCom.Name = "rpAvisCom"
        '
        'colSPATR_ATR_CODE_FK_PK2
        '
        Me.colSPATR_ATR_CODE_FK_PK2.Caption = "Code"
        Me.colSPATR_ATR_CODE_FK_PK2.ColumnEdit = Me.rpAvisCom2
        Me.colSPATR_ATR_CODE_FK_PK2.FieldName = "SPATR_ATR_CODE_FK_PK"
        Me.colSPATR_ATR_CODE_FK_PK2.Name = "colSPATR_ATR_CODE_FK_PK2"
        Me.colSPATR_ATR_CODE_FK_PK2.Visible = True
        Me.colSPATR_ATR_CODE_FK_PK2.VisibleIndex = 0
        Me.colSPATR_ATR_CODE_FK_PK2.Width = 58
        '
        'rpAvisCom2
        '
        Me.rpAvisCom2.AutoHeight = False
        Me.rpAvisCom2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpAvisCom2.Name = "rpAvisCom2"
        '
        'GC17
        '
        Me.GC17.DataMember = "SPFTR_SPECIALITE_TRANSPARENCE"
        Me.GC17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC17.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC17.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC17.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC17.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC17.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC17.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC17.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC17.EmbeddedNavigator.Name = ""
        Me.GC17.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC17.Location = New System.Drawing.Point(250, 3)
        Me.GC17.MainView = Me.GV17
        Me.GC17.Name = "GC17"
        Me.GC17.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpTransparence, Me.rpTransparence2})
        Me.GC17.Size = New System.Drawing.Size(241, 128)
        Me.GC17.TabIndex = 0
        Me.GC17.UseEmbeddedNavigator = True
        Me.GC17.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV17})
        '
        'GV17
        '
        Me.GV17.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSPFTR_SP_CODE_FK_PK, Me.colSPFTR_FTR_CODE_FK_PK, Me.SPFTR_FTR_CODE_FK_PK2})
        Me.GV17.GridControl = Me.GC17
        Me.GV17.Name = "GV17"
        Me.GV17.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV17.OptionsView.ShowGroupPanel = False
        '
        'colSPFTR_SP_CODE_FK_PK
        '
        Me.colSPFTR_SP_CODE_FK_PK.Caption = "SPFTR_SP_CODE_FK_PK"
        Me.colSPFTR_SP_CODE_FK_PK.FieldName = "SPFTR_SP_CODE_FK_PK"
        Me.colSPFTR_SP_CODE_FK_PK.Name = "colSPFTR_SP_CODE_FK_PK"
        '
        'colSPFTR_FTR_CODE_FK_PK
        '
        Me.colSPFTR_FTR_CODE_FK_PK.Caption = "Fiche transparence"
        Me.colSPFTR_FTR_CODE_FK_PK.ColumnEdit = Me.rpTransparence
        Me.colSPFTR_FTR_CODE_FK_PK.FieldName = "SPFTR_FTR_CODE_FK_PK"
        Me.colSPFTR_FTR_CODE_FK_PK.Name = "colSPFTR_FTR_CODE_FK_PK"
        Me.colSPFTR_FTR_CODE_FK_PK.Visible = True
        Me.colSPFTR_FTR_CODE_FK_PK.VisibleIndex = 0
        Me.colSPFTR_FTR_CODE_FK_PK.Width = 206
        '
        'rpTransparence
        '
        Me.rpTransparence.AutoHeight = False
        Me.rpTransparence.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpTransparence.Name = "rpTransparence"
        '
        'SPFTR_FTR_CODE_FK_PK2
        '
        Me.SPFTR_FTR_CODE_FK_PK2.Caption = "Code"
        Me.SPFTR_FTR_CODE_FK_PK2.ColumnEdit = Me.rpTransparence2
        Me.SPFTR_FTR_CODE_FK_PK2.FieldName = "SPFTR_FTR_CODE_FK_PK"
        Me.SPFTR_FTR_CODE_FK_PK2.Name = "SPFTR_FTR_CODE_FK_PK2"
        Me.SPFTR_FTR_CODE_FK_PK2.Visible = True
        Me.SPFTR_FTR_CODE_FK_PK2.VisibleIndex = 1
        Me.SPFTR_FTR_CODE_FK_PK2.Width = 62
        '
        'rpTransparence2
        '
        Me.rpTransparence2.AutoHeight = False
        Me.rpTransparence2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpTransparence2.Name = "rpTransparence2"
        '
        'GC14
        '
        Me.GC14.DataMember = "SPCH_SPECIALITE_CHOIX"
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
        Me.GC14.Location = New System.Drawing.Point(3, 3)
        Me.GC14.MainView = Me.GV14
        Me.GC14.Name = "GC14"
        Me.GC14.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpChoix})
        Me.GC14.Size = New System.Drawing.Size(241, 128)
        Me.GC14.TabIndex = 0
        Me.GC14.UseEmbeddedNavigator = True
        Me.GC14.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV14})
        '
        'GV14
        '
        Me.GV14.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSPCH_SP_CODE_FK_PK, Me.colSPCH_CH_CODE_FK_PK, Me.colSPCH_CH_CODE_FK_PK2})
        Me.GV14.GridControl = Me.GC14
        Me.GV14.Name = "GV14"
        Me.GV14.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV14.OptionsView.ShowGroupPanel = False
        '
        'colSPCH_SP_CODE_FK_PK
        '
        Me.colSPCH_SP_CODE_FK_PK.Caption = "SPCH_SP_CODE_FK_PK"
        Me.colSPCH_SP_CODE_FK_PK.FieldName = "SPCH_SP_CODE_FK_PK"
        Me.colSPCH_SP_CODE_FK_PK.Name = "colSPCH_SP_CODE_FK_PK"
        '
        'colSPCH_CH_CODE_FK_PK
        '
        Me.colSPCH_CH_CODE_FK_PK.Caption = "Critère de choix"
        Me.colSPCH_CH_CODE_FK_PK.ColumnEdit = Me.rpChoix
        Me.colSPCH_CH_CODE_FK_PK.FieldName = "SPCH_CH_CODE_FK_PK"
        Me.colSPCH_CH_CODE_FK_PK.Name = "colSPCH_CH_CODE_FK_PK"
        Me.colSPCH_CH_CODE_FK_PK.Visible = True
        Me.colSPCH_CH_CODE_FK_PK.VisibleIndex = 1
        Me.colSPCH_CH_CODE_FK_PK.Width = 232
        '
        'rpChoix
        '
        Me.rpChoix.AutoHeight = False
        Me.rpChoix.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpChoix.Name = "rpChoix"
        '
        'colSPCH_CH_CODE_FK_PK2
        '
        Me.colSPCH_CH_CODE_FK_PK2.Caption = "Code"
        Me.colSPCH_CH_CODE_FK_PK2.FieldName = "SPCH_CH_CODE_FK_PK"
        Me.colSPCH_CH_CODE_FK_PK2.Name = "colSPCH_CH_CODE_FK_PK2"
        Me.colSPCH_CH_CODE_FK_PK2.Visible = True
        Me.colSPCH_CH_CODE_FK_PK2.VisibleIndex = 0
        Me.colSPCH_CH_CODE_FK_PK2.Width = 51
        '
        'GC15
        '
        Me.GC15.DataMember = "SPRMO_SPECIALITE_RMO"
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
        Me.GC15.Location = New System.Drawing.Point(3, 137)
        Me.GC15.MainView = Me.GV15
        Me.GC15.Name = "GC15"
        Me.GC15.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpRMO, Me.rpRMO2, Me.rpCLRMO_CLASSE_RMO, Me.rpCLRMO_CLASSE_RMO2, Me.rpCLRMO_CLASSE_RMO3})
        Me.GC15.Size = New System.Drawing.Size(241, 128)
        Me.GC15.TabIndex = 1
        Me.GC15.UseEmbeddedNavigator = True
        Me.GC15.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV15, Me.GridView12})
        '
        'GV15
        '
        Me.GV15.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.GV15.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colSPRMO_SP_CODE_FK_PK, Me.colSPRMO_RMO_CODE_FK_PK, Me.colSPRMO_CLRMO_CODE_FK_PK, Me.colSPRMO_RMO_CODE_FK_PK2, Me.colSPRMO_CLRMO_CODE_FK_PK2, Me.colSPRMO_CLRMO_CODE_FK_PK3})
        Me.GV15.GridControl = Me.GC15
        Me.GV15.Name = "GV15"
        Me.GV15.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV15.OptionsView.ShowBands = False
        Me.GV15.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "gridBand1"
        Me.GridBand1.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand2})
        Me.GridBand1.MinWidth = 20
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.OptionsBand.ShowCaption = False
        Me.GridBand1.Width = 275
        '
        'GridBand2
        '
        Me.GridBand2.Caption = "gridBand2"
        Me.GridBand2.Columns.Add(Me.colSPRMO_RMO_CODE_FK_PK)
        Me.GridBand2.Columns.Add(Me.colSPRMO_RMO_CODE_FK_PK2)
        Me.GridBand2.Columns.Add(Me.colSPRMO_SP_CODE_FK_PK)
        Me.GridBand2.Columns.Add(Me.colSPRMO_CLRMO_CODE_FK_PK)
        Me.GridBand2.Columns.Add(Me.colSPRMO_CLRMO_CODE_FK_PK2)
        Me.GridBand2.Columns.Add(Me.colSPRMO_CLRMO_CODE_FK_PK3)
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.Width = 275
        '
        'colSPRMO_RMO_CODE_FK_PK
        '
        Me.colSPRMO_RMO_CODE_FK_PK.Caption = "Code"
        Me.colSPRMO_RMO_CODE_FK_PK.ColumnEdit = Me.rpRMO2
        Me.colSPRMO_RMO_CODE_FK_PK.FieldName = "SPRMO_RMO_CODE_FK_PK"
        Me.colSPRMO_RMO_CODE_FK_PK.Name = "colSPRMO_RMO_CODE_FK_PK"
        Me.colSPRMO_RMO_CODE_FK_PK.Visible = True
        Me.colSPRMO_RMO_CODE_FK_PK.Width = 45
        '
        'rpRMO2
        '
        Me.rpRMO2.AutoHeight = False
        Me.rpRMO2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpRMO2.Name = "rpRMO2"
        '
        'colSPRMO_RMO_CODE_FK_PK2
        '
        Me.colSPRMO_RMO_CODE_FK_PK2.Caption = "Réf.Méd.Opp.Libellé"
        Me.colSPRMO_RMO_CODE_FK_PK2.ColumnEdit = Me.rpRMO
        Me.colSPRMO_RMO_CODE_FK_PK2.FieldName = "SPRMO_RMO_CODE_FK_PK"
        Me.colSPRMO_RMO_CODE_FK_PK2.Name = "colSPRMO_RMO_CODE_FK_PK2"
        Me.colSPRMO_RMO_CODE_FK_PK2.Visible = True
        Me.colSPRMO_RMO_CODE_FK_PK2.Width = 230
        '
        'rpRMO
        '
        Me.rpRMO.AutoHeight = False
        Me.rpRMO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpRMO.Name = "rpRMO"
        '
        'colSPRMO_SP_CODE_FK_PK
        '
        Me.colSPRMO_SP_CODE_FK_PK.Caption = "SPRMO_SP_CODE_FK_PK"
        Me.colSPRMO_SP_CODE_FK_PK.FieldName = "SPRMO_SP_CODE_FK_PK"
        Me.colSPRMO_SP_CODE_FK_PK.Name = "colSPRMO_SP_CODE_FK_PK"
        '
        'colSPRMO_CLRMO_CODE_FK_PK
        '
        Me.colSPRMO_CLRMO_CODE_FK_PK.Caption = "Code"
        Me.colSPRMO_CLRMO_CODE_FK_PK.ColumnEdit = Me.rpCLRMO_CLASSE_RMO2
        Me.colSPRMO_CLRMO_CODE_FK_PK.FieldName = "SPRMO_CLRMO_CODE_FK_PK"
        Me.colSPRMO_CLRMO_CODE_FK_PK.Name = "colSPRMO_CLRMO_CODE_FK_PK"
        Me.colSPRMO_CLRMO_CODE_FK_PK.OptionsColumn.AllowFocus = False
        Me.colSPRMO_CLRMO_CODE_FK_PK.RowIndex = 1
        Me.colSPRMO_CLRMO_CODE_FK_PK.Visible = True
        Me.colSPRMO_CLRMO_CODE_FK_PK.Width = 53
        '
        'rpCLRMO_CLASSE_RMO2
        '
        Me.rpCLRMO_CLASSE_RMO2.AutoHeight = False
        Me.rpCLRMO_CLASSE_RMO2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpCLRMO_CLASSE_RMO2.Name = "rpCLRMO_CLASSE_RMO2"
        '
        'colSPRMO_CLRMO_CODE_FK_PK2
        '
        Me.colSPRMO_CLRMO_CODE_FK_PK2.Caption = "Classe"
        Me.colSPRMO_CLRMO_CODE_FK_PK2.ColumnEdit = Me.rpCLRMO_CLASSE_RMO
        Me.colSPRMO_CLRMO_CODE_FK_PK2.FieldName = "SPRMO_CLRMO_CODE_FK_PK"
        Me.colSPRMO_CLRMO_CODE_FK_PK2.Name = "colSPRMO_CLRMO_CODE_FK_PK2"
        Me.colSPRMO_CLRMO_CODE_FK_PK2.OptionsColumn.AllowEdit = False
        Me.colSPRMO_CLRMO_CODE_FK_PK2.OptionsColumn.AllowFocus = False
        Me.colSPRMO_CLRMO_CODE_FK_PK2.RowIndex = 1
        Me.colSPRMO_CLRMO_CODE_FK_PK2.Visible = True
        Me.colSPRMO_CLRMO_CODE_FK_PK2.Width = 175
        '
        'rpCLRMO_CLASSE_RMO
        '
        Me.rpCLRMO_CLASSE_RMO.AutoHeight = False
        Me.rpCLRMO_CLASSE_RMO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpCLRMO_CLASSE_RMO.Name = "rpCLRMO_CLASSE_RMO"
        Me.rpCLRMO_CLASSE_RMO.NullText = "-"
        '
        'colSPRMO_CLRMO_CODE_FK_PK3
        '
        Me.colSPRMO_CLRMO_CODE_FK_PK3.ColumnEdit = Me.rpCLRMO_CLASSE_RMO3
        Me.colSPRMO_CLRMO_CODE_FK_PK3.FieldName = "SPRMO_CLRMO_CODE_FK_PK"
        Me.colSPRMO_CLRMO_CODE_FK_PK3.Name = "colSPRMO_CLRMO_CODE_FK_PK3"
        Me.colSPRMO_CLRMO_CODE_FK_PK3.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.colSPRMO_CLRMO_CODE_FK_PK3.OptionsColumn.AllowMove = False
        Me.colSPRMO_CLRMO_CODE_FK_PK3.OptionsColumn.AllowSize = False
        Me.colSPRMO_CLRMO_CODE_FK_PK3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colSPRMO_CLRMO_CODE_FK_PK3.OptionsColumn.ShowCaption = False
        Me.colSPRMO_CLRMO_CODE_FK_PK3.RowIndex = 1
        Me.colSPRMO_CLRMO_CODE_FK_PK3.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.colSPRMO_CLRMO_CODE_FK_PK3.Visible = True
        Me.colSPRMO_CLRMO_CODE_FK_PK3.Width = 26
        '
        'rpCLRMO_CLASSE_RMO3
        '
        Me.rpCLRMO_CLASSE_RMO3.AutoHeight = False
        Me.rpCLRMO_CLASSE_RMO3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpCLRMO_CLASSE_RMO3.Name = "rpCLRMO_CLASSE_RMO3"
        Me.rpCLRMO_CLASSE_RMO3.NullText = " "
        '
        'GridView12
        '
        Me.GridView12.GridControl = Me.GC15
        Me.GridView12.Name = "GridView12"
        Me.GridView12.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView12.OptionsView.ShowGroupPanel = False
        '
        'GC16
        '
        Me.GC16.DataMember = "SPFTH_SPEC_INFOTHERAPEUTIQUE"
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
        Me.GC16.Location = New System.Drawing.Point(3, 271)
        Me.GC16.MainView = Me.GV16
        Me.GC16.Name = "GC16"
        Me.GC16.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpInfoth, Me.rpInfoth2})
        Me.GC16.Size = New System.Drawing.Size(241, 128)
        Me.GC16.TabIndex = 2
        Me.GC16.UseEmbeddedNavigator = True
        Me.GC16.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV16})
        '
        'GV16
        '
        Me.GV16.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSPFTH_SP_CODE_FK_PK, Me.colSPFTH_FTH_CODE_FK_PK, Me.colSPFTH_FTH_CODE_FK_PK2})
        Me.GV16.GridControl = Me.GC16
        Me.GV16.Name = "GV16"
        Me.GV16.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV16.OptionsView.ShowGroupPanel = False
        '
        'colSPFTH_SP_CODE_FK_PK
        '
        Me.colSPFTH_SP_CODE_FK_PK.Caption = "SPFTH_SP_CODE_FK_PK"
        Me.colSPFTH_SP_CODE_FK_PK.FieldName = "SPFTH_SP_CODE_FK_PK"
        Me.colSPFTH_SP_CODE_FK_PK.Name = "colSPFTH_SP_CODE_FK_PK"
        '
        'colSPFTH_FTH_CODE_FK_PK
        '
        Me.colSPFTH_FTH_CODE_FK_PK.Caption = "Fiche d’info. Thérapeut. "
        Me.colSPFTH_FTH_CODE_FK_PK.ColumnEdit = Me.rpInfoth
        Me.colSPFTH_FTH_CODE_FK_PK.FieldName = "SPFTH_FTH_CODE_FK_PK"
        Me.colSPFTH_FTH_CODE_FK_PK.Name = "colSPFTH_FTH_CODE_FK_PK"
        Me.colSPFTH_FTH_CODE_FK_PK.Visible = True
        Me.colSPFTH_FTH_CODE_FK_PK.VisibleIndex = 1
        Me.colSPFTH_FTH_CODE_FK_PK.Width = 219
        '
        'rpInfoth
        '
        Me.rpInfoth.AutoHeight = False
        Me.rpInfoth.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpInfoth.Name = "rpInfoth"
        '
        'colSPFTH_FTH_CODE_FK_PK2
        '
        Me.colSPFTH_FTH_CODE_FK_PK2.Caption = "Code"
        Me.colSPFTH_FTH_CODE_FK_PK2.ColumnEdit = Me.rpInfoth2
        Me.colSPFTH_FTH_CODE_FK_PK2.FieldName = "SPFTH_FTH_CODE_FK_PK"
        Me.colSPFTH_FTH_CODE_FK_PK2.Name = "colSPFTH_FTH_CODE_FK_PK2"
        Me.colSPFTH_FTH_CODE_FK_PK2.Visible = True
        Me.colSPFTH_FTH_CODE_FK_PK2.VisibleIndex = 0
        Me.colSPFTH_FTH_CODE_FK_PK2.Width = 64
        '
        'rpInfoth2
        '
        Me.rpInfoth2.AutoHeight = False
        Me.rpInfoth2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpInfoth2.Name = "rpInfoth2"
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Controls.Add(Me.Panel6)
        Me.XtraTabPage6.Controls.Add(Me.Panel2)
        Me.XtraTabPage6.Controls.Add(Me.GC20)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(494, 402)
        Me.XtraTabPage6.Tag = "[EDIT][ADD]"
        Me.XtraTabPage6.Text = "Prescription/Delivrance"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GC21)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 268)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(494, 134)
        Me.Panel6.TabIndex = 34
        '
        'GC21
        '
        Me.GC21.DataMember = "PRIUCD_PRIX_UCD"
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
        Me.GC21.Location = New System.Drawing.Point(0, 24)
        Me.GC21.MainView = Me.GV21
        Me.GC21.Name = "GC21"
        Me.GC21.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpPrix})
        Me.GC21.Size = New System.Drawing.Size(494, 110)
        Me.GC21.TabIndex = 2
        Me.GC21.UseEmbeddedNavigator = True
        Me.GC21.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV21})
        '
        'GV21
        '
        Me.GV21.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPRIUCD_UCD_CODE_PK, Me.colPRIUCD_CODE_LISTE_PK, Me.colPRIUCD_DATE_APPLI_PK, Me.colPRIUCD_PFHT, Me.colPRIUCD_PTTC, Me.colPRIUCD_Valide})
        Me.GV21.GridControl = Me.GC21
        Me.GV21.Name = "GV21"
        Me.GV21.OptionsView.ShowGroupPanel = False
        '
        'colPRIUCD_UCD_CODE_PK
        '
        Me.colPRIUCD_UCD_CODE_PK.Caption = "PRIUCD_UCD_CODE_PK"
        Me.colPRIUCD_UCD_CODE_PK.FieldName = "PRIUCD_UCD_CODE_PK"
        Me.colPRIUCD_UCD_CODE_PK.Name = "colPRIUCD_UCD_CODE_PK"
        '
        'colPRIUCD_CODE_LISTE_PK
        '
        Me.colPRIUCD_CODE_LISTE_PK.Caption = "Code Liste"
        Me.colPRIUCD_CODE_LISTE_PK.ColumnEdit = Me.rpPrix
        Me.colPRIUCD_CODE_LISTE_PK.FieldName = "PRIUCD_CODE_LISTE_PK"
        Me.colPRIUCD_CODE_LISTE_PK.Name = "colPRIUCD_CODE_LISTE_PK"
        Me.colPRIUCD_CODE_LISTE_PK.Visible = True
        Me.colPRIUCD_CODE_LISTE_PK.VisibleIndex = 0
        '
        'rpPrix
        '
        Me.rpPrix.AutoHeight = False
        Me.rpPrix.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpPrix.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("value", "Code", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("display", "Libellé", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.rpPrix.DisplayMember = "display"
        Me.rpPrix.Name = "rpPrix"
        Me.rpPrix.NullText = ""
        Me.rpPrix.ValueMember = "value"
        '
        'colPRIUCD_DATE_APPLI_PK
        '
        Me.colPRIUCD_DATE_APPLI_PK.Caption = "Date application JO"
        Me.colPRIUCD_DATE_APPLI_PK.FieldName = "PRIUCD_DATE_APPLI_PK"
        Me.colPRIUCD_DATE_APPLI_PK.Name = "colPRIUCD_DATE_APPLI_PK"
        Me.colPRIUCD_DATE_APPLI_PK.Visible = True
        Me.colPRIUCD_DATE_APPLI_PK.VisibleIndex = 3
        '
        'colPRIUCD_PFHT
        '
        Me.colPRIUCD_PFHT.Caption = "Prix HT"
        Me.colPRIUCD_PFHT.FieldName = "PRIUCD_PFHT"
        Me.colPRIUCD_PFHT.Name = "colPRIUCD_PFHT"
        Me.colPRIUCD_PFHT.Visible = True
        Me.colPRIUCD_PFHT.VisibleIndex = 2
        '
        'colPRIUCD_PTTC
        '
        Me.colPRIUCD_PTTC.Caption = "Prix TTC"
        Me.colPRIUCD_PTTC.FieldName = "PRIUCD_PTTC"
        Me.colPRIUCD_PTTC.Name = "colPRIUCD_PTTC"
        Me.colPRIUCD_PTTC.Visible = True
        Me.colPRIUCD_PTTC.VisibleIndex = 1
        '
        'colPRIUCD_Valide
        '
        Me.colPRIUCD_Valide.Caption = "Valide"
        Me.colPRIUCD_Valide.FieldName = "PRIUCD_Valide"
        Me.colPRIUCD_Valide.Name = "colPRIUCD_Valide"
        Me.colPRIUCD_Valide.Visible = True
        Me.colPRIUCD_Valide.VisibleIndex = 4
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label43)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(494, 24)
        Me.Panel7.TabIndex = 33
        '
        'Label43
        '
        Me.Label43.Location = New System.Drawing.Point(3, 3)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(127, 21)
        Me.Label43.TabIndex = 32
        Me.Label43.Text = "Prix à l'hôpital / UCD"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.MemoEdit2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 124)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(494, 144)
        Me.Panel2.TabIndex = 33
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label42)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(494, 25)
        Me.Panel4.TabIndex = 7
        '
        'Label42
        '
        Me.Label42.Location = New System.Drawing.Point(3, 3)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(51, 19)
        Me.Label42.TabIndex = 6
        Me.Label42.Text = "Texte"
        '
        'MemoEdit2
        '
        Me.MemoEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature1, "SP_SPECIALITE.SP_CDT_PRESCR_TEXTE", True))
        Me.MemoEdit2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MemoEdit2.Location = New System.Drawing.Point(0, 25)
        Me.MemoEdit2.Name = "MemoEdit2"
        Me.MemoEdit2.Size = New System.Drawing.Size(494, 119)
        Me.MemoEdit2.TabIndex = 1
        '
        'GC20
        '
        Me.GC20.DataMember = "SPCPD_SPE_CDT_PRESCR"
        Me.GC20.Dock = System.Windows.Forms.DockStyle.Top
        Me.GC20.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC20.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC20.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC20.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC20.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC20.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC20.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC20.EmbeddedNavigator.Name = ""
        Me.GC20.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC20.Location = New System.Drawing.Point(0, 0)
        Me.GC20.MainView = Me.GV20
        Me.GC20.Name = "GC20"
        Me.GC20.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpPresDev, Me.rpPresDev2})
        Me.GC20.Size = New System.Drawing.Size(494, 124)
        Me.GC20.TabIndex = 0
        Me.GC20.UseEmbeddedNavigator = True
        Me.GC20.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV20})
        '
        'GV20
        '
        Me.GV20.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSPCPD_SP_CODE_FK_PK, Me.colSPCPD_CDF_STP_CODE_FK_PK, Me.colSPCPD_NUMORD, Me.colSPCPD_CDF_STP_CODE_FK_PK2})
        Me.GV20.GridControl = Me.GC20
        Me.GV20.Name = "GV20"
        Me.GV20.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV20.OptionsView.ShowGroupPanel = False
        Me.GV20.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSPCPD_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colSPCPD_SP_CODE_FK_PK
        '
        Me.colSPCPD_SP_CODE_FK_PK.Caption = "SPCPD_SP_CODE_FK_PK"
        Me.colSPCPD_SP_CODE_FK_PK.FieldName = "SPCPD_SP_CODE_FK_PK"
        Me.colSPCPD_SP_CODE_FK_PK.Name = "colSPCPD_SP_CODE_FK_PK"
        '
        'colSPCPD_CDF_STP_CODE_FK_PK
        '
        Me.colSPCPD_CDF_STP_CODE_FK_PK.Caption = "Prescription / délivrance"
        Me.colSPCPD_CDF_STP_CODE_FK_PK.ColumnEdit = Me.rpPresDev
        Me.colSPCPD_CDF_STP_CODE_FK_PK.FieldName = "SPCPD_CDF_STP_CODE_FK_PK"
        Me.colSPCPD_CDF_STP_CODE_FK_PK.Name = "colSPCPD_CDF_STP_CODE_FK_PK"
        Me.colSPCPD_CDF_STP_CODE_FK_PK.Visible = True
        Me.colSPCPD_CDF_STP_CODE_FK_PK.VisibleIndex = 1
        Me.colSPCPD_CDF_STP_CODE_FK_PK.Width = 442
        '
        'rpPresDev
        '
        Me.rpPresDev.AutoHeight = False
        Me.rpPresDev.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpPresDev.Name = "rpPresDev"
        '
        'colSPCPD_NUMORD
        '
        Me.colSPCPD_NUMORD.Caption = "N°"
        Me.colSPCPD_NUMORD.FieldName = "SPCPD_NUMORD"
        Me.colSPCPD_NUMORD.Name = "colSPCPD_NUMORD"
        Me.colSPCPD_NUMORD.Visible = True
        Me.colSPCPD_NUMORD.VisibleIndex = 2
        Me.colSPCPD_NUMORD.Width = 51
        '
        'colSPCPD_CDF_STP_CODE_FK_PK2
        '
        Me.colSPCPD_CDF_STP_CODE_FK_PK2.Caption = "Code"
        Me.colSPCPD_CDF_STP_CODE_FK_PK2.ColumnEdit = Me.rpPresDev2
        Me.colSPCPD_CDF_STP_CODE_FK_PK2.FieldName = "SPCPD_CDF_STP_CODE_FK_PK"
        Me.colSPCPD_CDF_STP_CODE_FK_PK2.Name = "colSPCPD_CDF_STP_CODE_FK_PK2"
        Me.colSPCPD_CDF_STP_CODE_FK_PK2.Visible = True
        Me.colSPCPD_CDF_STP_CODE_FK_PK2.VisibleIndex = 0
        Me.colSPCPD_CDF_STP_CODE_FK_PK2.Width = 91
        '
        'rpPresDev2
        '
        Me.rpPresDev2.AutoHeight = False
        Me.rpPresDev2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpPresDev2.Name = "rpPresDev2"
        '
        'XtraTabPage7
        '
        Me.XtraTabPage7.Controls.Add(Me.GC23)
        Me.XtraTabPage7.Controls.Add(Me.GC22)
        Me.XtraTabPage7.Name = "XtraTabPage7"
        Me.XtraTabPage7.Size = New System.Drawing.Size(494, 402)
        Me.XtraTabPage7.Text = "Références officielles"
        '
        'GC23
        '
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
        Me.GC23.Location = New System.Drawing.Point(0, 239)
        Me.GC23.MainView = Me.GV23
        Me.GC23.Name = "GC23"
        Me.GC23.Size = New System.Drawing.Size(494, 163)
        Me.GC23.TabIndex = 1
        Me.GC23.Tag = ""
        Me.GC23.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV23})
        '
        'GV23
        '
        Me.GV23.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPRE_CODE_PK})
        Me.GV23.GridControl = Me.GC23
        Me.GV23.Name = "GV23"
        Me.GV23.OptionsView.ShowGroupPanel = False
        '
        'colPRE_CODE_PK
        '
        Me.colPRE_CODE_PK.Caption = "CIP"
        Me.colPRE_CODE_PK.FieldName = "PRE_CODE_PK"
        Me.colPRE_CODE_PK.Name = "colPRE_CODE_PK"
        Me.colPRE_CODE_PK.OptionsColumn.ReadOnly = True
        Me.colPRE_CODE_PK.Visible = True
        Me.colPRE_CODE_PK.VisibleIndex = 0
        '
        'GC22
        '
        Me.GC22.DataMember = "SPAFS_SPECIALITE_AFSSAPS"
        Me.GC22.DataSource = Me.DsTheriaque_Ref
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
        Me.GC22.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpRUB, Me.rpRef})
        Me.GC22.Size = New System.Drawing.Size(494, 239)
        Me.GC22.TabIndex = 0
        Me.GC22.UseEmbeddedNavigator = True
        Me.GC22.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV22})
        '
        'DsTheriaque_Ref
        '
        Me.DsTheriaque_Ref.DataSetName = "dsTheriaque_Ref"
        Me.DsTheriaque_Ref.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GV22
        '
        Me.GV22.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSPAFS_RUBCDF_NUMERO_PK, Me.colSPAFS_SP_CODE_FK_PK, Me.colSPAFS_DATE_PK, Me.colSPAFS_CDF_CODE_DOC_FK_PK, Me.colSPAFS_DATE_REVIS})
        Me.GV22.GridControl = Me.GC22
        Me.GV22.Name = "GV22"
        Me.GV22.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV22.OptionsView.ShowGroupPanel = False
        '
        'colSPAFS_RUBCDF_NUMERO_PK
        '
        Me.colSPAFS_RUBCDF_NUMERO_PK.Caption = "Rubrique"
        Me.colSPAFS_RUBCDF_NUMERO_PK.ColumnEdit = Me.rpRUB
        Me.colSPAFS_RUBCDF_NUMERO_PK.FieldName = "SPAFS_RUBCDF_NUMERO_PK"
        Me.colSPAFS_RUBCDF_NUMERO_PK.Name = "colSPAFS_RUBCDF_NUMERO_PK"
        Me.colSPAFS_RUBCDF_NUMERO_PK.Visible = True
        Me.colSPAFS_RUBCDF_NUMERO_PK.VisibleIndex = 2
        Me.colSPAFS_RUBCDF_NUMERO_PK.Width = 174
        '
        'rpRUB
        '
        Me.rpRUB.AutoHeight = False
        Me.rpRUB.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpRUB.Name = "rpRUB"
        '
        'colSPAFS_SP_CODE_FK_PK
        '
        Me.colSPAFS_SP_CODE_FK_PK.Caption = "SPAFS_SP_CODE_FK_PK"
        Me.colSPAFS_SP_CODE_FK_PK.FieldName = "SPAFS_SP_CODE_FK_PK"
        Me.colSPAFS_SP_CODE_FK_PK.Name = "colSPAFS_SP_CODE_FK_PK"
        '
        'colSPAFS_DATE_PK
        '
        Me.colSPAFS_DATE_PK.Caption = "Date"
        Me.colSPAFS_DATE_PK.FieldName = "SPAFS_DATE_PK"
        Me.colSPAFS_DATE_PK.Name = "colSPAFS_DATE_PK"
        Me.colSPAFS_DATE_PK.Visible = True
        Me.colSPAFS_DATE_PK.VisibleIndex = 1
        '
        'colSPAFS_CDF_CODE_DOC_FK_PK
        '
        Me.colSPAFS_CDF_CODE_DOC_FK_PK.Caption = "Références officielles"
        Me.colSPAFS_CDF_CODE_DOC_FK_PK.ColumnEdit = Me.rpRef
        Me.colSPAFS_CDF_CODE_DOC_FK_PK.FieldName = "SPAFS_CDF_CODE_DOC_FK_PK"
        Me.colSPAFS_CDF_CODE_DOC_FK_PK.Name = "colSPAFS_CDF_CODE_DOC_FK_PK"
        Me.colSPAFS_CDF_CODE_DOC_FK_PK.Visible = True
        Me.colSPAFS_CDF_CODE_DOC_FK_PK.VisibleIndex = 0
        Me.colSPAFS_CDF_CODE_DOC_FK_PK.Width = 257
        '
        'rpRef
        '
        Me.rpRef.AutoHeight = False
        Me.rpRef.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpRef.Name = "rpRef"
        Me.rpRef.NullText = ""
        '
        'colSPAFS_DATE_REVIS
        '
        Me.colSPAFS_DATE_REVIS.Caption = "Date de révision"
        Me.colSPAFS_DATE_REVIS.FieldName = "SPAFS_DATE_REVIS"
        Me.colSPAFS_DATE_REVIS.Name = "colSPAFS_DATE_REVIS"
        Me.colSPAFS_DATE_REVIS.Visible = True
        Me.colSPAFS_DATE_REVIS.VisibleIndex = 3
        '
        'XtraTabPage8
        '
        Me.XtraTabPage8.Controls.Add(Me.Panel14)
        Me.XtraTabPage8.Controls.Add(Me.PanelControl1)
        Me.XtraTabPage8.Name = "XtraTabPage8"
        Me.XtraTabPage8.Size = New System.Drawing.Size(494, 402)
        Me.XtraTabPage8.Text = "Url"
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.btADDRemb)
        Me.Panel14.Controls.Add(Me.GC31)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(494, 338)
        Me.Panel14.TabIndex = 2
        '
        'btADDRemb
        '
        Me.btADDRemb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btADDRemb.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btADDRemb.Location = New System.Drawing.Point(160, 318)
        Me.btADDRemb.Name = "btADDRemb"
        Me.btADDRemb.Size = New System.Drawing.Size(46, 19)
        Me.btADDRemb.TabIndex = 52
        Me.btADDRemb.Tag = "[EDIT][ADD]"
        Me.btADDRemb.Text = "..."
        '
        'GC31
        '
        Me.GC31.DataMember = "SPURL_SPECIALITE_ADRESSE"
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
        Me.GC31.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Rp_TypeURL})
        Me.GC31.Size = New System.Drawing.Size(494, 338)
        Me.GC31.TabIndex = 1
        Me.GC31.UseEmbeddedNavigator = True
        Me.GC31.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV31})
        '
        'GV31
        '
        Me.GV31.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSPURL_CODE_SP_PK_FK, Me.colSPURL_CODE_URL_PK_FK, Me.colSPURL_ADRESSE})
        Me.GV31.GridControl = Me.GC31
        Me.GV31.Name = "GV31"
        Me.GV31.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV31.OptionsView.ShowGroupPanel = False
        '
        'colSPURL_CODE_SP_PK_FK
        '
        Me.colSPURL_CODE_SP_PK_FK.Caption = "SPURL_CODE_SP_PK_FK"
        Me.colSPURL_CODE_SP_PK_FK.FieldName = "SPURL_CODE_SP_PK_FK"
        Me.colSPURL_CODE_SP_PK_FK.Name = "colSPURL_CODE_SP_PK_FK"
        '
        'colSPURL_CODE_URL_PK_FK
        '
        Me.colSPURL_CODE_URL_PK_FK.Caption = "TypeUrl"
        Me.colSPURL_CODE_URL_PK_FK.ColumnEdit = Me.Rp_TypeURL
        Me.colSPURL_CODE_URL_PK_FK.FieldName = "SPURL_CODE_URL_PK_FK"
        Me.colSPURL_CODE_URL_PK_FK.Name = "colSPURL_CODE_URL_PK_FK"
        Me.colSPURL_CODE_URL_PK_FK.OptionsColumn.ReadOnly = True
        Me.colSPURL_CODE_URL_PK_FK.Visible = True
        Me.colSPURL_CODE_URL_PK_FK.VisibleIndex = 0
        Me.colSPURL_CODE_URL_PK_FK.Width = 188
        '
        'Rp_TypeURL
        '
        Me.Rp_TypeURL.AutoHeight = False
        Me.Rp_TypeURL.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Rp_TypeURL.Name = "Rp_TypeURL"
        '
        'colSPURL_ADRESSE
        '
        Me.colSPURL_ADRESSE.Caption = "URL"
        Me.colSPURL_ADRESSE.FieldName = "SPURL_ADRESSE"
        Me.colSPURL_ADRESSE.Name = "colSPURL_ADRESSE"
        Me.colSPURL_ADRESSE.Visible = True
        Me.colSPURL_ADRESSE.VisibleIndex = 1
        Me.colSPURL_ADRESSE.Width = 525
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 338)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(494, 64)
        Me.PanelControl1.TabIndex = 4
        Me.PanelControl1.Text = "PanelControl1"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.SimpleButton1.Location = New System.Drawing.Point(357, 21)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(24, 27)
        Me.SimpleButton1.TabIndex = 6
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(5, 26)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(346, 16)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Pour modifier et ajouter des nouveaux types d'Url  cliquez ici"
        '
        'XtraTabPage9
        '
        Me.XtraTabPage9.Controls.Add(Me.Panel19)
        Me.XtraTabPage9.Controls.Add(Me.GroupControl1)
        Me.XtraTabPage9.Controls.Add(Me.PanelControl2)
        Me.XtraTabPage9.Name = "XtraTabPage9"
        Me.XtraTabPage9.Size = New System.Drawing.Size(494, 402)
        Me.XtraTabPage9.Text = "Document"
        '
        'Panel19
        '
        Me.Panel19.Controls.Add(Me.Panel15)
        Me.Panel19.Controls.Add(Me.Panel16)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel19.Location = New System.Drawing.Point(0, 31)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(494, 285)
        Me.Panel19.TabIndex = 9
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.gcDocument)
        Me.Panel15.Controls.Add(Me.Panel20)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(406, 285)
        Me.Panel15.TabIndex = 1
        '
        'gcDocument
        '
        Me.gcDocument.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcDocument.EmbeddedNavigator.Name = ""
        Me.gcDocument.Location = New System.Drawing.Point(0, 0)
        Me.gcDocument.MainView = Me.gvDocument
        Me.gcDocument.Name = "gcDocument"
        Me.gcDocument.Size = New System.Drawing.Size(406, 285)
        Me.gcDocument.TabIndex = 0
        Me.gcDocument.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDocument})
        '
        'gvDocument
        '
        Me.gvDocument.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLibelle, Me.colChemin, Me.colSp, Me.colId})
        Me.gvDocument.GridControl = Me.gcDocument
        Me.gvDocument.Name = "gvDocument"
        '
        'colLibelle
        '
        Me.colLibelle.Caption = "Libellé"
        Me.colLibelle.FieldName = "DO_Label"
        Me.colLibelle.Name = "colLibelle"
        Me.colLibelle.OptionsColumn.AllowEdit = False
        Me.colLibelle.Visible = True
        Me.colLibelle.VisibleIndex = 0
        '
        'colChemin
        '
        Me.colChemin.Caption = "Chemin"
        Me.colChemin.FieldName = "DO_Info1"
        Me.colChemin.Name = "colChemin"
        Me.colChemin.OptionsColumn.AllowEdit = False
        Me.colChemin.Visible = True
        Me.colChemin.VisibleIndex = 1
        '
        'colSp
        '
        Me.colSp.Caption = "Spécialité"
        Me.colSp.FieldName = "SP_CODE_SQ_PK"
        Me.colSp.Name = "colSp"
        '
        'colId
        '
        Me.colId.Caption = "Id"
        Me.colId.FieldName = "DO_ID"
        Me.colId.Name = "colId"
        '
        'Panel20
        '
        Me.Panel20.Location = New System.Drawing.Point(432, 100)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(108, 374)
        Me.Panel20.TabIndex = 10
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.BtSupprim)
        Me.Panel16.Controls.Add(Me.btPartager)
        Me.Panel16.Controls.Add(Me.btApercu)
        Me.Panel16.Controls.Add(Me.btImporter)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel16.Location = New System.Drawing.Point(406, 0)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(88, 285)
        Me.Panel16.TabIndex = 2
        '
        'BtSupprim
        '
        Me.BtSupprim.Location = New System.Drawing.Point(6, 135)
        Me.BtSupprim.Name = "BtSupprim"
        Me.BtSupprim.Size = New System.Drawing.Size(75, 23)
        Me.BtSupprim.TabIndex = 3
        Me.BtSupprim.Text = "Supprimer"
        '
        'btPartager
        '
        Me.btPartager.Location = New System.Drawing.Point(6, 90)
        Me.btPartager.Name = "btPartager"
        Me.btPartager.Size = New System.Drawing.Size(75, 23)
        Me.btPartager.TabIndex = 2
        Me.btPartager.Text = "Partager"
        '
        'btApercu
        '
        Me.btApercu.Location = New System.Drawing.Point(6, 48)
        Me.btApercu.Name = "btApercu"
        Me.btApercu.Size = New System.Drawing.Size(75, 23)
        Me.btApercu.TabIndex = 1
        Me.btApercu.Text = "Aperçu"
        '
        'btImporter
        '
        Me.btImporter.Enabled = False
        Me.btImporter.Location = New System.Drawing.Point(6, 6)
        Me.btImporter.Name = "btImporter"
        Me.btImporter.Size = New System.Drawing.Size(75, 23)
        Me.btImporter.TabIndex = 0
        Me.btImporter.Text = "Importer"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.cmdAnnuler)
        Me.GroupControl1.Controls.Add(Me.cmdOK)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.meNote)
        Me.GroupControl1.Controls.Add(Me.lueCategorie)
        Me.GroupControl1.Controls.Add(Me.txtLibelle2)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl1.Location = New System.Drawing.Point(0, 316)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(494, 86)
        Me.GroupControl1.TabIndex = 10
        Me.GroupControl1.Text = "Propriété document"
        '
        'cmdAnnuler
        '
        Me.cmdAnnuler.Location = New System.Drawing.Point(605, 56)
        Me.cmdAnnuler.Name = "cmdAnnuler"
        Me.cmdAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnnuler.TabIndex = 8
        Me.cmdAnnuler.Text = "Annu&le"
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(605, 27)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 7
        Me.cmdOK.Text = "&Ok"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(5, 52)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl4.TabIndex = 5
        Me.LabelControl4.Text = "Note"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(307, 27)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Catégorie"
        '
        'meNote
        '
        Me.meNote.Location = New System.Drawing.Point(49, 49)
        Me.meNote.Name = "meNote"
        Me.meNote.Size = New System.Drawing.Size(535, 30)
        Me.meNote.TabIndex = 3
        '
        'lueCategorie
        '
        Me.lueCategorie.EditValue = ""
        Me.lueCategorie.Location = New System.Drawing.Point(365, 23)
        Me.lueCategorie.Name = "lueCategorie"
        Me.lueCategorie.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCategorie.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Libelle", "Name1", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_CATEGORIE", "Name2", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.lueCategorie.Properties.DisplayMember = "Libelle"
        Me.lueCategorie.Properties.NullText = ""
        Me.lueCategorie.Properties.ShowHeader = False
        Me.lueCategorie.Properties.ValueMember = "ID_CATEGORIE"
        Me.lueCategorie.Size = New System.Drawing.Size(219, 20)
        Me.lueCategorie.TabIndex = 2
        '
        'txtLibelle2
        '
        Me.txtLibelle2.Location = New System.Drawing.Point(49, 23)
        Me.txtLibelle2.Name = "txtLibelle2"
        Me.txtLibelle2.Size = New System.Drawing.Size(246, 20)
        Me.txtLibelle2.TabIndex = 1
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(5, 23)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "Libellé"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.beChemin)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(494, 31)
        Me.PanelControl2.TabIndex = 8
        Me.PanelControl2.Text = "PanelControl2"
        '
        'beChemin
        '
        Me.beChemin.Location = New System.Drawing.Point(11, 5)
        Me.beChemin.Name = "beChemin"
        Me.beChemin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton("explorer", DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis), New DevExpress.XtraEditors.Controls.EditorButton("effacer", DevExpress.XtraEditors.Controls.ButtonPredefines.Minus)})
        Me.beChemin.Size = New System.Drawing.Size(654, 20)
        Me.beChemin.TabIndex = 0
        '
        'DsTheriaqueURL
        '
        Me.DsTheriaqueURL.DataSetName = "dsTheriaqueURL"
        Me.DsTheriaqueURL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsTheriaque_Recap
        '
        Me.DsTheriaque_Recap.DataSetName = "dsTheriaque_Recap"
        Me.DsTheriaque_Recap.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_TA
        '
        Me.SP_TA.ClearBeforeFill = True
        '
        'SYSP_TA
        '
        Me.SYSP_TA.ClearBeforeFill = True
        '
        'SplaB_TA
        '
        Me.SplaB_TA.ClearBeforeFill = True
        '
        'SplabeX_TA
        '
        Me.SplabeX_TA.ClearBeforeFill = True
        '
        'SpvO_TA
        '
        Me.SpvO_TA.ClearBeforeFill = True
        '
        'SpfO_TA
        '
        Me.SpfO_TA.ClearBeforeFill = True
        '
        'SpfocfO_TA
        '
        Me.SpfocfO_TA.ClearBeforeFill = True
        '
        'SpfocpI_TA
        '
        Me.SpfocpI_TA.ClearBeforeFill = True
        '
        'CosaC_TA
        '
        Me.CosaC_TA.ClearBeforeFill = True
        '
        'CosaU_TA
        '
        Me.CosaU_TA.ClearBeforeFill = True
        '
        'CompO_TA
        '
        Me.CompO_TA.ClearBeforeFill = True
        '
        'CoteN_TA
        '
        Me.CoteN_TA.ClearBeforeFill = True
        '
        'SpadM_TA
        '
        Me.SpadM_TA.ClearBeforeFill = True
        '
        'SpcpH_TA
        '
        Me.SpcpH_TA.ClearBeforeFill = True
        '
        'SpddD_TA
        '
        Me.SpddD_TA.ClearBeforeFill = True
        '
        'SpcH_TA
        '
        Me.SpcH_TA.ClearBeforeFill = True
        '
        'SprmO_TA
        '
        Me.SprmO_TA.ClearBeforeFill = True
        '
        'SpftH_TA
        '
        Me.SpftH_TA.ClearBeforeFill = True
        '
        'SpftR_TA
        '
        Me.SpftR_TA.ClearBeforeFill = True
        '
        'SpatR_TA
        '
        Me.SpatR_TA.ClearBeforeFill = True
        '
        'SpsmR_TA
        '
        Me.SpsmR_TA.ClearBeforeFill = True
        '
        'PriucD_TA
        '
        Me.PriucD_TA.ClearBeforeFill = True
        '
        'SpfotX_TA
        '
        Me.SpfotX_TA.ClearBeforeFill = True
        '
        'SpteN_TA
        '
        Me.SpteN_TA.ClearBeforeFill = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Name = "GridColumn1"
        '
        'SpafS_TA
        '
        Me.SpafS_TA.ClearBeforeFill = True
        '
        'SpcpD_TA
        '
        Me.SpcpD_TA.ClearBeforeFill = True
        '
        'SpurL_TA
        '
        Me.SpurL_TA.ClearBeforeFill = True
        '
        'IcduR_INCOMPATIBILITE_DUREETableAdapter1
        '
        Me.IcduR_INCOMPATIBILITE_DUREETableAdapter1.ClearBeforeFill = True
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.ButtonEdit1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(660, 31)
        Me.PanelControl3.TabIndex = 8
        Me.PanelControl3.Text = "PanelControl2"
        '
        'ButtonEdit1
        '
        Me.ButtonEdit1.Location = New System.Drawing.Point(5, 7)
        Me.ButtonEdit1.Name = "ButtonEdit1"
        Me.ButtonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton("explorer", DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis), New DevExpress.XtraEditors.Controls.EditorButton("effacer", DevExpress.XtraEditors.Controls.ButtonPredefines.Minus)})
        Me.ButtonEdit1.Size = New System.Drawing.Size(654, 20)
        Me.ButtonEdit1.TabIndex = 0
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.SimpleButton2)
        Me.Panel17.Controls.Add(Me.SimpleButton3)
        Me.Panel17.Controls.Add(Me.SimpleButton4)
        Me.Panel17.Controls.Add(Me.SimpleButton5)
        Me.Panel17.Location = New System.Drawing.Point(549, 60)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(108, 374)
        Me.Panel17.TabIndex = 2
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(21, 162)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "Supprimer"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(21, 117)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton3.TabIndex = 2
        Me.SimpleButton3.Text = "Partager"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Location = New System.Drawing.Point(21, 75)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton4.TabIndex = 1
        Me.SimpleButton4.Text = "Aperçu"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Enabled = False
        Me.SimpleButton5.Location = New System.Drawing.Point(21, 33)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton5.TabIndex = 0
        Me.SimpleButton5.Text = "Importer"
        '
        'Panel18
        '
        Me.Panel18.Controls.Add(Me.GridControl1)
        Me.Panel18.Location = New System.Drawing.Point(3, 35)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(540, 377)
        Me.Panel18.TabIndex = 1
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(540, 377)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Libellé"
        Me.GridColumn2.FieldName = "DO_Label"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Chemin"
        Me.GridColumn3.FieldName = "DO_Info1"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Spécialité"
        Me.GridColumn4.FieldName = "SP_CODE_SQ_PK"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Id"
        Me.GridColumn5.FieldName = "DO_ID"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'Frm_Specialite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(831, 573)
        Me.Name = "Frm_Specialite"
        Me.Text = "Spécialité"
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
        CType(Me.CH_MonVirt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_Nomenclature1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupMedVirt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.txtUCD13.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpLabo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpLabX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupListe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupProduitCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupStLab.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupProduit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUCD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCIS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel27.ResumeLayout(False)
        CType(Me.GC7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rm_MemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel28.ResumeLayout(False)
        Me.Panel28.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        CType(Me.GC6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        CType(Me.GC5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpCompl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        CType(Me.GC4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpFormePh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpVoie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        CType(Me.GC11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpSubActive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpComboSub, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpUnite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpExcipient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpUnite2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpNotoire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpTeneur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboTeneur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpUnite3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpUnite4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpComposition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.TextEdit15.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        CType(Me.GC13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpClasseEphmra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpClasseEphmra2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.GC25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpSPADMLIBELLE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.GC24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpSPTENLIBELLE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.PanDDD.ResumeLayout(False)
        CType(Me.GCDDD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDDD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupDDD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupDDD1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupATC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupEphemra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupATC2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupEphemra2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit21.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.lkupGestion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupGestion2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEdit_APHP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage5.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        CType(Me.GC19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpSMR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpAvisCom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpAvisCom2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpTransparence, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpTransparence2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpChoix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpRMO2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpRMO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpCLRMO_CLASSE_RMO2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpCLRMO_CLASSE_RMO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpCLRMO_CLASSE_RMO3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpInfoth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpInfoth2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage6.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.GC21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpPrix, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpPresDev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpPresDev2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage7.ResumeLayout(False)
        CType(Me.GC23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_Ref, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpRUB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpRef, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage8.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        CType(Me.GC31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rp_TypeURL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.XtraTabPage9.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        CType(Me.gcDocument, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDocument, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel16.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.meNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCategorie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibelle2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.beChemin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaqueURL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_Recap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.ButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel17.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLibelle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtNom As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtUCD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCIS As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GC2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GC8 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GC6 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GC12 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GC10 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC11 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TextEdit15 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents GC13 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TextEdit21 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtEdit_APHP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents GC15 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC14 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC19 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV19 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC18 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV18 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC17 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV17 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC16 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV16 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents MemoEdit2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GC20 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV20 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents GC21 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV21 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents XtraTabPage7 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GC23 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GC22 As DevExpress.XtraGrid.GridControl
    Friend WithEvents DsTheriaque_Nomenclature1 As Theriaque.dsTheriaque_Nomenclature1
    Friend WithEvents SP_TA As Theriaque.dsTheriaque_Nomenclature1TableAdapters.SP_SPECIALITETableAdapter
    Friend WithEvents GC1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lkupProduit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkupStLab As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lkupEphemra As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkupEphemra2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkupATC As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkupATC2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkupGestion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkupGestion2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkupMedVirt As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkupProduitCode As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SYSP_TA As Theriaque.dsTheriaque_Nomenclature1TableAdapters.SYSP_SYNONYME_SPECIALITETableAdapter
    Friend WithEvents colSYSP_NOM_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSYSP_SP_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplaB_TA As Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPLAB_SPECIALITE_LABOTableAdapter
    Friend WithEvents colSPLAB_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPLAB_CDF_LAB_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpLabo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SplabeX_TA As Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPLABEX_SPE_LABO_EXPLOITANTTableAdapter
    Friend WithEvents colSPLABEX_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPLABEX_CDF_LAB_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpLabX As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colSPLABEX_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SpvO_TA As Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPVO_SPECIALITE_VOIETableAdapter
    Friend WithEvents colSPVO_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPVO_CDF_VO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPVO_NUMSEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpVoie As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SpfO_TA As Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPFO_SPECIALITE_FORMETableAdapter
    Friend WithEvents colSPFO_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPFO_CDF_FO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPFO_NUMSEQ_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPFO_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpFormePh As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents SpfocfO_TA As Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPFOCFO_SPE_FORME_COMPFORMETableAdapter
    Friend WithEvents SpfocpI_TA As Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPFOCPI_SPE_FORME_COMPINFOTableAdapter
    Friend WithEvents colSPFOCPI_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPFOCPI_CDF_FO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPFOCPI_SPFO_NUMSEQ_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPFOCPI_CDF_CPI_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPFOCPI_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpInfo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC9 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCOMPO_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOMPO_NUM_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOMPO_CDF_GAL_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CosaC_TA As Theriaque.dsTheriaque_Nomenclature1TableAdapters.COSAC_COMPO_SUBACTTableAdapter
    Friend WithEvents CosaU_TA As Theriaque.dsTheriaque_Nomenclature1TableAdapters.COSAU_COMPO_SUBAUXTableAdapter
    Friend WithEvents colCOSAU_SAU_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAU_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAU_DOSAGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAU_UNITEDOSAGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAU_COMPO_NUM_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAU_GREF_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAU_GREF_DATECR_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAU_GREF_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAU_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAC_SAC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAC_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAC_DOSAGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAC_UNITEDOSAGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAC_COMPO_NUM_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAC_SAC_BASE_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAC_DOSAGE_BASE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAC_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpSubActive As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rpUnite As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rpExcipient As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rpUnite2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colCOSAU_SAU_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CompO_TA As Theriaque.dsTheriaque_Nomenclature1TableAdapters.COMPO_COMPOSITIONTableAdapter
    Friend WithEvents CoteN_TA As Theriaque.dsTheriaque_Nomenclature1TableAdapters.COTEN_COMPO_TENEURTableAdapter
    Friend WithEvents SpadM_TA As Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPADM_SPECIALITE_MODEADMTableAdapter
    Friend WithEvents colSPCPH_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPCPH_CPH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPCPH_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SpcpH_TA As Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPCPH_SPECIALITE_CLASSEPHTableAdapter
    Friend WithEvents colSPCPH_CPH_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpClasseEphmra As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GV5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSPFOCFO_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPFOCFO_CDF_FO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPFOCFO_SPFO_NUMSEQ_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPFOCFO_CDF_CFO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPFOCFO_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpCompl As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rpClasseEphmra2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SpddD_TA As Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPDDD_DOSE_USUELLE_JOURTableAdapter
    Friend WithEvents btDDD As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanDDD As System.Windows.Forms.Panel
    Friend WithEvents colSPCH_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPCH_CH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpChoix As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SpcH_TA As Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPCH_SPECIALITE_CHOIXTableAdapter
    Friend WithEvents GV15 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colSPRMO_CLRMO_CODE_FK_PK As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSPRMO_RMO_CODE_FK_PK As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSPRMO_SP_CODE_FK_PK As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents rpRMO As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colSPRMO_RMO_CODE_FK_PK2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSPRMO_CLRMO_CODE_FK_PK2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents rpRMO2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SprmO_TA As Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPRMO_SPECIALITE_RMOTableAdapter
    Friend WithEvents rpCLRMO_CLASSE_RMO2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rpCLRMO_CLASSE_RMO As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colSPFTH_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPFTH_FTH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SpftH_TA As Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPFTH_SPEC_INFOTHERAPEUTIQUETableAdapter
    Friend WithEvents SpftR_TA As Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPFTR_SPECIALITE_TRANSPARENCETableAdapter
    Friend WithEvents rpInfoth As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colSPFTH_FTH_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpInfoth2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colSPFTR_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPFTR_FTR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SPFTR_FTR_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpTransparence As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rpTransparence2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colSPSMR_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPSMR_CDF_SMR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPSMR_NUM_ORD_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPSMR_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpSMR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colSPATR_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPATR_ATR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpAvisCom As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rpAvisCom2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colSPATR_ATR_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SpatR_TA As Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPATR_SPEC_AVISTRANSPARENCETableAdapter
    Friend WithEvents SpsmR_TA As Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPSMR_SERVICE_MEDICAL_RENDUTableAdapter
    Friend WithEvents colSPCPD_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPCPD_CDF_STP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPCPD_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPCPD_CDF_STP_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpPresDev As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rpPresDev2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colPRIUCD_UCD_CODE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRIUCD_CODE_LISTE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRIUCD_DATE_APPLI_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRIUCD_PFHT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRIUCD_PTTC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpPrix As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PriucD_TA As Theriaque.dsTheriaque_Nomenclature1TableAdapters.PRIUCD_PRIX_UCDTableAdapter
    Friend WithEvents GV23 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV22 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lkupListe As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents SpfotX_TA As Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPFOTX_SPE_FORME_TEXTETableAdapter
    Friend WithEvents rpComposition As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rpComboSub As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents GV12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCOTEN_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOTEN_CDF_TEN_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOTEN_QUALIFICATIF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOTEN_DOSAGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOTEN_CDF_UD_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOTEN_DOSAGE_EQUIV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOTEN_CDF_UD_EQUIV_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOTEN_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpTeneur As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rpUnite3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rpUnite4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents comboTeneur As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents SpteN_TA As Theriaque.dsTheriaque_Nomenclature1TableAdapters.SPTEN_SPECIALITE_TENEURTableAdapter
    Friend WithEvents colPRE_CODE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPCH_CH_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents DsTheriaque_Ref As Theriaque.dsTheriaque_Ref
    Friend WithEvents colSPAFS_RUBCDF_NUMERO_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPAFS_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPAFS_DATE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPAFS_CDF_CODE_DOC_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPAFS_DATE_REVIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SpafS_TA As Theriaque.dsTheriaque_RefTableAdapters.SPAFS_SPECIALITE_AFSSAPSTableAdapter
    Friend WithEvents rpRUB As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rpRef As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rpNotoire As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DsTheriaque_Recap As Theriaque.dsTheriaque_Recap
    Friend WithEvents SpcpD_TA As Theriaque.dsTheriaque_RecapTableAdapters.SPCPD_SPE_CDT_PRESCRTableAdapter
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GC24 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV24 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rpSPTENLIBELLE As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents colSPTEN_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPTEN_LIBELLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GC25 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV25 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rpSPADMLIBELLE As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colSPADM_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPADM_LIBELLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents colSPRMO_CLRMO_CODE_FK_PK3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents rpCLRMO_CLASSE_RMO3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel27 As System.Windows.Forms.Panel
    Friend WithEvents GC7 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel28 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colSPFOTX_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPFOTX_TEXTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rm_MemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents XtraTabPage8 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents DsTheriaqueURL As Theriaque.dsTheriaqueURL
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CH_MonVirt As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtUCD13 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents colPRIUCD_Valide As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SpurL_TA As Theriaque.dsTheriaqueURLTableAdapters.SPURL_SPECIALITE_ADRESSETableAdapter
    Friend WithEvents GC31 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV31 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSPURL_CODE_SP_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPURL_CODE_URL_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rp_TypeURL As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colSPURL_ADRESSE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btADDRemb As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCDDD As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVDDD As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSPDDD_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPDDD_ATCDDD_CATC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPDDD_ATCDDD_CDF_VO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPDDD_ATCDDD_DOSAGE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPDDD_ATCDDD_CDF_UD_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPDDD_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkupDDD As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lkupDDD1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents XtraTabPage9 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents beChemin As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents BtSupprim As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btPartager As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btApercu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btImporter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcDocument As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDocument As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colLibelle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChemin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IcduR_INCOMPATIBILITE_DUREETableAdapter1 As Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.ICDUR_INCOMPATIBILITE_DUREETableAdapter
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ButtonEdit1 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmdAnnuler As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents meNote As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lueCategorie As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtLibelle2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl



End Class
