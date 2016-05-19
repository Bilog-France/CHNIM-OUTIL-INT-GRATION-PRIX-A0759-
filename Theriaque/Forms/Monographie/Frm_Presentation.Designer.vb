<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Presentation
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
        Me.PanMain3 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.lkupSP2 = New DevExpress.XtraEditors.LookUpEdit
        Me.DsTheriaque_Nomenclature2 = New Theriaque.dsTheriaque_Nomenclature2
        Me.lkupSP = New DevExpress.XtraEditors.LookUpEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.GC5 = New DevExpress.XtraGrid.GridControl
        Me.GV5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPRECAR_PRE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRECAR_COCONT_NUM_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRECAR_CDF_CODE_CACDT_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpCrtCmpl = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colPRECAR_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC4 = New DevExpress.XtraGrid.GridControl
        Me.GV4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPREMAT_PRE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPREMAT_COCONT_NUM_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPREMAT_CDF_MACDT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpMat = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colPREMAT_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.GC3 = New DevExpress.XtraGrid.GridControl
        Me.GV3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPRECONT_PRE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRECONT_COCONT_NUM_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRECONT_NBCONTENANT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpTexte = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colPRECONT_CDF_COCDT_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpNBCont = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colPRECONT_NBCONTENANT_REEL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRECONT_NBCONTENANCE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRECONT_CDF_COCE_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpContenuReel = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colPRECONT_VOLCONTENANT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRECONT_CDF_VOLCONT_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpContPossible = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPREDISP_PRE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPREDISP_NUMSEQ_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPREDISP_SAC_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpSubACT = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colPREDISP_UNITEDISP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPREDISP_CDF_UD_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpUnite = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC1 = New DevExpress.XtraGrid.GridControl
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPREUCD_PRE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPREUCD_CDF_COMUCD_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpCommentaire = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colPREUCD_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC2 = New DevExpress.XtraGrid.GridControl
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCOCONT_PRE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOCONT_NUM_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOCONT_CDF_GAL_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkupCont = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colCOCONT_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit
        Me.lkupUCD = New DevExpress.XtraEditors.LookUpEdit
        Me.lkupPrise = New DevExpress.XtraEditors.LookUpEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtNBPrise = New DevExpress.XtraEditors.TextEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.PanMain4 = New System.Windows.Forms.Panel
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.GC20 = New DevExpress.XtraGrid.GridControl
        Me.GV20 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColPRECPSS_PRE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCDF_NOM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpCDF_CODIF = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.btPrix = New DevExpress.XtraEditors.SimpleButton
        Me.lkupPresentationUnitaire = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GC8 = New DevExpress.XtraGrid.GridControl
        Me.GV8 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPRETSSH_PRE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRETSSH_CDF_TSS_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpTauxSociale = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colPRETSSH_NUMSEQ = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRETSSH_DATE_APPLI_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRETSSH_DATE_APPLIQUEE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRETSSH_TEXTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RpMemoEditHop = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.GC7 = New DevExpress.XtraGrid.GridControl
        Me.GV7 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPRETSS_PRE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRETSS_CDF_TSS_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpTauxRBS = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colPRETSS_NUMSEQ = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRETSS_DATE_APPLI_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRETSS_DATE_APPLIQUEE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRETSS_TEXTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RpMemoEditVille = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Label12 = New System.Windows.Forms.Label
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit
        Me.GC6 = New DevExpress.XtraGrid.GridControl
        Me.GV6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPRECEMB_PRE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRECEMB_CDF_CAREMB_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpCractEmb = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colPRECEMB_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.PanMain5 = New System.Windows.Forms.Panel
        Me.MemoEdit3 = New DevExpress.XtraEditors.MemoEdit
        Me.MemoEdit2 = New DevExpress.XtraEditors.MemoEdit
        Me.GC11 = New DevExpress.XtraGrid.GridControl
        Me.GV11 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPRESTR_PRE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRESTR_CDF_STR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpStatutR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colPRESTR_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label21 = New System.Windows.Forms.Label
        Me.GC10 = New DevExpress.XtraGrid.GridControl
        Me.GV10 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPRESTC_PRE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRESTC_CDF_STCOMP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpStatutC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colPRESTC_CODE_IDENT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRESTC_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC9 = New DevExpress.XtraGrid.GridControl
        Me.GV9 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPRESTP_PRE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRESTP_CDF_STP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpStatut = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colPRESTP_DATE_AFSSAPS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRESTP_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DeditSupp = New DevExpress.XtraEditors.DateEdit
        Me.Label20 = New System.Windows.Forms.Label
        Me.DeditdispoDepuis = New DevExpress.XtraEditors.DateEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmbEtatComercial = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lkPresHop = New DevExpress.XtraEditors.LookUpEdit
        Me.DeditApplication = New DevExpress.XtraEditors.DateEdit
        Me.DeditRadiation = New DevExpress.XtraEditors.DateEdit
        Me.DateEdit4 = New DevExpress.XtraEditors.DateEdit
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.GC15 = New DevExpress.XtraGrid.GridControl
        Me.GV15 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPRECSVTX_PRE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRECSVTX_TEXTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpMemoCons = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Label23 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GC14 = New DevExpress.XtraGrid.GridControl
        Me.GV14 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPERCS_NUM_CODE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPERCS_PRE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPERCS_CDF_CSV_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpCondition = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colPERCS_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC13 = New DevExpress.XtraGrid.GridControl
        Me.GV13 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPREPER_NUM_CODE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPREPER_PRE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPREPER_CDF_UT_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpDureeConsv = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colPREPER_DUREE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC12 = New DevExpress.XtraGrid.GridControl
        Me.GV12 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPRESTRTX_PRE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRESTRTX_TEXTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpMemo = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Label22 = New System.Windows.Forms.Label
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage
        Me.pan5 = New System.Windows.Forms.Panel
        Me.lkup_Liste = New DevExpress.XtraEditors.LookUpEdit
        Me.Pan_Lieu_Commentaire = New System.Windows.Forms.Panel
        Me.GC17 = New DevExpress.XtraGrid.GridControl
        Me.GV17 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPREDICO_PRE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPREDICO_CDF_COM_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpComDispo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colPREDICO_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC16 = New DevExpress.XtraGrid.GridControl
        Me.GV16 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPREDILI_PRE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPREDILI_CDF_LIEU_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpPredili = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colPREDILI_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btADDSMR = New DevExpress.XtraEditors.SimpleButton
        Me.GC19 = New DevExpress.XtraGrid.GridControl
        Me.GV19 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPRESMR_PRE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRESMR_CDF_SMR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpSMR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colPRESMR_DATE_SMR_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRESMR_ATR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkupEPH2 = New DevExpress.XtraEditors.LookUpEdit
        Me.lkupEPH = New DevExpress.XtraEditors.LookUpEdit
        Me.Label27 = New System.Windows.Forms.Label
        Me.lkupATC2 = New DevExpress.XtraEditors.LookUpEdit
        Me.lkupATC = New DevExpress.XtraEditors.LookUpEdit
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.GC18 = New DevExpress.XtraGrid.GridControl
        Me.GV18 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPREDITX_PRE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPREDITX_TEXTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Label25 = New System.Windows.Forms.Label
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.Label24 = New System.Windows.Forms.Label
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.gcDocuments = New DevExpress.XtraGrid.GridControl
        Me.gvDocuments = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRE_CODE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLibelle1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colChemin1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDateInsertion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.bSupprimer = New DevExpress.XtraEditors.SimpleButton
        Me.btnPartager = New DevExpress.XtraEditors.SimpleButton
        Me.btAperçu = New DevExpress.XtraEditors.SimpleButton
        Me.btnImporter = New DevExpress.XtraEditors.SimpleButton
        Me.gcPropDoc = New DevExpress.XtraEditors.GroupControl
        Me.cmdAnnuler = New DevExpress.XtraEditors.SimpleButton
        Me.cmdOK = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.meNote = New DevExpress.XtraEditors.MemoEdit
        Me.lueCategorie = New DevExpress.XtraEditors.LookUpEdit
        Me.txtLibelle = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.bePath = New DevExpress.XtraEditors.ButtonEdit
        Me.DateEdit3 = New DevExpress.XtraEditors.DateEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtEAN = New DevExpress.XtraEditors.TextEdit
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.PredisP_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.PREDISP_PRE_DISPENSATIONTableAdapter
        Me.PrE_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRE_PRESENTATIONTableAdapter
        Me.SP_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.SP_SPECIALITETableAdapter
        Me.PreucD_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.PREUCD_COMMENT_DOSEUCDTableAdapter
        Me.CoconT_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.COCONT_COMPO_CONTENANTTableAdapter
        Me.PreconT_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRECONT_PRE_CONTENANTTableAdapter
        Me.PremaT_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.PREMAT_PRE_MATERIAUTableAdapter
        Me.PrecaR_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRECAR_PRESENTATION_CARACTCOMPTableAdapter
        Me.PrecemB_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRECEMB_PRE_CAREMBALLAGETableAdapter
        Me.PretsS_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRETSS_PRESENTATION_TAUXTableAdapter
        Me.ForprE_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.FORPRE_FORFAIT_PRETableAdapter
        Me.PriprE_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRIPRE_PRIX_PRESENTATIONTableAdapter
        Me.PretssH_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRETSSH_PRE_TAUX_HOPTableAdapter
        Me.PrestP_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRESTP_PRE_STPTableAdapter
        Me.PrestC_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRESTC_STATUTCOMP_PRESENTTableAdapter
        Me.PrestR_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRESTR_STATUT_REMBOURSTTableAdapter
        Me.PrestrtX_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRESTRTX_TEXTE_STAT_REMBOURSTTableAdapter
        Me.PrepeR_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.PREPER_PRESENTATION_PERIO_CSVTableAdapter
        Me.PercS_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.PERCS_PERIODE_COND_CSVTableAdapter
        Me.PrecsvtX_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRECSVTX_TEXTE_CONSERVTableAdapter
        Me.PredilI_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.PREDILI_LIEU_DISPENSATTableAdapter
        Me.PredicO_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.PREDICO_COMMENT_DISPENSATTableAdapter
        Me.PreditX_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.PREDITX_TEXTE_DISPENSATTableAdapter
        Me.PresmR_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRESMR_PRE_SMR_ATRTableAdapter
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.BtSupprim = New DevExpress.XtraEditors.SimpleButton
        Me.btPartager = New DevExpress.XtraEditors.SimpleButton
        Me.btApercu = New DevExpress.XtraEditors.SimpleButton
        Me.btImporter = New DevExpress.XtraEditors.SimpleButton
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.colLibelle = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colChemin = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.beChemin = New DevExpress.XtraEditors.ButtonEdit
        Me.Precpss_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRECPSSTableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanMain3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.lkupSP2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_Nomenclature2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupSP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.GC5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpCrtCmpl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpMat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.GC3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpTexte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpNBCont, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpContenuReel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpContPossible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpSubACT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpUnite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpCommentaire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupCont, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupUCD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupPrise.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNBPrise.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.PanMain4.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.GC20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpCDF_CODIF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupPresentationUnitaire.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.GC8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpTauxSociale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpMemoEditHop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpTauxRBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpMemoEditVille, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpCractEmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        Me.PanMain5.SuspendLayout()
        CType(Me.MemoEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpStatutR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpStatutC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpStatut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeditSupp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeditdispoDepuis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbEtatComercial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkPresHop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeditApplication.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeditRadiation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.GC15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpMemoCons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.GC14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpCondition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpDureeConsv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage5.SuspendLayout()
        Me.pan5.SuspendLayout()
        CType(Me.lkup_Liste.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pan_Lieu_Commentaire.SuspendLayout()
        CType(Me.GC17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpComDispo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpPredili, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpSMR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupEPH2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupEPH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupATC2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupATC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage6.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.gcDocuments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDocuments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.gcPropDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcPropDoc.SuspendLayout()
        CType(Me.meNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCategorie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.bePath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEAN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel16.SuspendLayout()
        CType(Me.beChemin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(914, 624)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.PanMain3)
        Me.PanMain.Location = New System.Drawing.Point(0, 64)
        Me.PanMain.Size = New System.Drawing.Size(796, 560)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(914, 64)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(914, 28)
        Me.Label1.Text = "Présentation"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(303, 35)
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(33, 34)
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(796, 64)
        Me.Panel1.Size = New System.Drawing.Size(118, 560)
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_DATEMJ", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(375, 32)
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Location = New System.Drawing.Point(0, 56)
        Me.GroupBox.Size = New System.Drawing.Size(914, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_DATECR", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(90, 32)
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
        'PanMain3
        '
        Me.PanMain3.Controls.Add(Me.Panel5)
        Me.PanMain3.Controls.Add(Me.XtraTabControl1)
        Me.PanMain3.Controls.Add(Me.DateEdit3)
        Me.PanMain3.Controls.Add(Me.Label5)
        Me.PanMain3.Controls.Add(Me.Label3)
        Me.PanMain3.Controls.Add(Me.Label2)
        Me.PanMain3.Controls.Add(Me.txtEAN)
        Me.PanMain3.Controls.Add(Me.txtCode)
        Me.PanMain3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMain3.Location = New System.Drawing.Point(0, 0)
        Me.PanMain3.Name = "PanMain3"
        Me.PanMain3.Size = New System.Drawing.Size(796, 560)
        Me.PanMain3.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lkupSP2)
        Me.Panel5.Controls.Add(Me.lkupSP)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Location = New System.Drawing.Point(8, 26)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(701, 28)
        Me.Panel5.TabIndex = 3
        Me.Panel5.Tag = "[ADD][EDIT]"
        '
        'lkupSP2
        '
        Me.lkupSP2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_SP_CODE_FK", True))
        Me.lkupSP2.Location = New System.Drawing.Point(82, 2)
        Me.lkupSP2.Name = "lkupSP2"
        Me.lkupSP2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupSP2.Size = New System.Drawing.Size(79, 20)
        Me.lkupSP2.TabIndex = 0
        Me.lkupSP2.Tag = ""
        '
        'DsTheriaque_Nomenclature2
        '
        Me.DsTheriaque_Nomenclature2.DataSetName = "dsTheriaque_Nomenclature2"
        Me.DsTheriaque_Nomenclature2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lkupSP
        '
        Me.lkupSP.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_SP_CODE_FK", True))
        Me.lkupSP.Location = New System.Drawing.Point(167, 2)
        Me.lkupSP.Name = "lkupSP"
        Me.lkupSP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupSP.Size = New System.Drawing.Size(523, 20)
        Me.lkupSP.TabIndex = 1
        Me.lkupSP.Tag = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Tag = "[ADD][EDIT]"
        Me.Label4.Text = "Spécialité"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(7, 54)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(786, 506)
        Me.XtraTabControl1.TabIndex = 4
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5, Me.XtraTabPage6})
        Me.XtraTabControl1.Text = "Document"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panel6)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(777, 475)
        Me.XtraTabPage1.Tag = "[ADD][EDIT]"
        Me.XtraTabPage1.Text = "Conditionnement"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel6.Controls.Add(Me.Panel4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(777, 475)
        Me.Panel6.TabIndex = 11
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel8, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GC2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 93)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(777, 382)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.GC5, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.GC4, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 288)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.Padding = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(771, 91)
        Me.TableLayoutPanel3.TabIndex = 12
        '
        'GC5
        '
        Me.GC5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC5.DataMember = "COCONT_COMPO_CONTENANT.FK2_PRECAR_PRESENT_CARACTCOMP"
        Me.GC5.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC5.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC5.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC5.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC5.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC5.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC5.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC5.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC5.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC5.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC5.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC5.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC5.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC5.EmbeddedNavigator.Name = ""
        Me.GC5.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC5.Location = New System.Drawing.Point(388, 5)
        Me.GC5.MainView = Me.GV5
        Me.GC5.Name = "GC5"
        Me.GC5.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpCrtCmpl})
        Me.GC5.Size = New System.Drawing.Size(378, 81)
        Me.GC5.TabIndex = 10
        Me.GC5.UseEmbeddedNavigator = True
        Me.GC5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV5})
        '
        'GV5
        '
        Me.GV5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPRECAR_PRE_CODE_FK_PK, Me.colPRECAR_COCONT_NUM_FK_PK, Me.colPRECAR_CDF_CODE_CACDT_FK_PK, Me.colPRECAR_NUMORD})
        Me.GV5.GridControl = Me.GC5
        Me.GV5.GroupPanelText = " "
        Me.GV5.Name = "GV5"
        Me.GV5.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV5.OptionsView.ShowGroupPanel = False
        Me.GV5.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPRECAR_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colPRECAR_PRE_CODE_FK_PK
        '
        Me.colPRECAR_PRE_CODE_FK_PK.Caption = "PRECAR_PRE_CODE_FK_PK"
        Me.colPRECAR_PRE_CODE_FK_PK.FieldName = "PRECAR_PRE_CODE_FK_PK"
        Me.colPRECAR_PRE_CODE_FK_PK.Name = "colPRECAR_PRE_CODE_FK_PK"
        '
        'colPRECAR_COCONT_NUM_FK_PK
        '
        Me.colPRECAR_COCONT_NUM_FK_PK.Caption = "PRECAR_COCONT_NUM_FK_PK"
        Me.colPRECAR_COCONT_NUM_FK_PK.FieldName = "PRECAR_COCONT_NUM_FK_PK"
        Me.colPRECAR_COCONT_NUM_FK_PK.Name = "colPRECAR_COCONT_NUM_FK_PK"
        '
        'colPRECAR_CDF_CODE_CACDT_FK_PK
        '
        Me.colPRECAR_CDF_CODE_CACDT_FK_PK.Caption = "Caract complément"
        Me.colPRECAR_CDF_CODE_CACDT_FK_PK.ColumnEdit = Me.rpCrtCmpl
        Me.colPRECAR_CDF_CODE_CACDT_FK_PK.FieldName = "PRECAR_CDF_CODE_CACDT_FK_PK"
        Me.colPRECAR_CDF_CODE_CACDT_FK_PK.Name = "colPRECAR_CDF_CODE_CACDT_FK_PK"
        Me.colPRECAR_CDF_CODE_CACDT_FK_PK.Visible = True
        Me.colPRECAR_CDF_CODE_CACDT_FK_PK.VisibleIndex = 0
        Me.colPRECAR_CDF_CODE_CACDT_FK_PK.Width = 262
        '
        'rpCrtCmpl
        '
        Me.rpCrtCmpl.AutoHeight = False
        Me.rpCrtCmpl.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpCrtCmpl.Name = "rpCrtCmpl"
        Me.rpCrtCmpl.NullText = ""
        '
        'colPRECAR_NUMORD
        '
        Me.colPRECAR_NUMORD.Caption = "N°"
        Me.colPRECAR_NUMORD.FieldName = "PRECAR_NUMORD"
        Me.colPRECAR_NUMORD.Name = "colPRECAR_NUMORD"
        Me.colPRECAR_NUMORD.Visible = True
        Me.colPRECAR_NUMORD.VisibleIndex = 1
        Me.colPRECAR_NUMORD.Width = 57
        '
        'GC4
        '
        Me.GC4.DataMember = "COCONT_COMPO_CONTENANT.FK2_PREMAT_PRE_MATERIAU"
        Me.GC4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC4.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC4.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC4.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC4.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC4.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC4.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC4.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC4.EmbeddedNavigator.Name = ""
        Me.GC4.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC4.Location = New System.Drawing.Point(5, 5)
        Me.GC4.MainView = Me.GV4
        Me.GC4.Name = "GC4"
        Me.GC4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpMat})
        Me.GC4.Size = New System.Drawing.Size(377, 81)
        Me.GC4.TabIndex = 9
        Me.GC4.UseEmbeddedNavigator = True
        Me.GC4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV4})
        '
        'GV4
        '
        Me.GV4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPREMAT_PRE_CODE_FK_PK, Me.colPREMAT_COCONT_NUM_FK_PK, Me.colPREMAT_CDF_MACDT_CODE_FK_PK, Me.colPREMAT_NUMORD})
        Me.GV4.GridControl = Me.GC4
        Me.GV4.GroupPanelText = " "
        Me.GV4.Name = "GV4"
        Me.GV4.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV4.OptionsView.ShowGroupPanel = False
        Me.GV4.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPREMAT_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colPREMAT_PRE_CODE_FK_PK
        '
        Me.colPREMAT_PRE_CODE_FK_PK.Caption = "PREMAT_PRE_CODE_FK_PK"
        Me.colPREMAT_PRE_CODE_FK_PK.FieldName = "PREMAT_PRE_CODE_FK_PK"
        Me.colPREMAT_PRE_CODE_FK_PK.Name = "colPREMAT_PRE_CODE_FK_PK"
        '
        'colPREMAT_COCONT_NUM_FK_PK
        '
        Me.colPREMAT_COCONT_NUM_FK_PK.Caption = "PREMAT_COCONT_NUM_FK_PK"
        Me.colPREMAT_COCONT_NUM_FK_PK.FieldName = "PREMAT_COCONT_NUM_FK_PK"
        Me.colPREMAT_COCONT_NUM_FK_PK.Name = "colPREMAT_COCONT_NUM_FK_PK"
        '
        'colPREMAT_CDF_MACDT_CODE_FK_PK
        '
        Me.colPREMAT_CDF_MACDT_CODE_FK_PK.Caption = "Matériau"
        Me.colPREMAT_CDF_MACDT_CODE_FK_PK.ColumnEdit = Me.rpMat
        Me.colPREMAT_CDF_MACDT_CODE_FK_PK.FieldName = "PREMAT_CDF_MACDT_CODE_FK_PK"
        Me.colPREMAT_CDF_MACDT_CODE_FK_PK.Name = "colPREMAT_CDF_MACDT_CODE_FK_PK"
        Me.colPREMAT_CDF_MACDT_CODE_FK_PK.Visible = True
        Me.colPREMAT_CDF_MACDT_CODE_FK_PK.VisibleIndex = 0
        Me.colPREMAT_CDF_MACDT_CODE_FK_PK.Width = 245
        '
        'rpMat
        '
        Me.rpMat.AutoHeight = False
        Me.rpMat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpMat.Name = "rpMat"
        Me.rpMat.NullText = ""
        '
        'colPREMAT_NUMORD
        '
        Me.colPREMAT_NUMORD.Caption = "N°"
        Me.colPREMAT_NUMORD.FieldName = "PREMAT_NUMORD"
        Me.colPREMAT_NUMORD.Name = "colPREMAT_NUMORD"
        Me.colPREMAT_NUMORD.Visible = True
        Me.colPREMAT_NUMORD.VisibleIndex = 1
        Me.colPREMAT_NUMORD.Width = 33
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel8.Controls.Add(Me.GC3)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(3, 193)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel8.Size = New System.Drawing.Size(771, 89)
        Me.Panel8.TabIndex = 12
        '
        'GC3
        '
        Me.GC3.DataMember = "COCONT_COMPO_CONTENANT.FK2_PRECONT_PRE_CONTENANT"
        Me.GC3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC3.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC3.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC3.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC3.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC3.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC3.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC3.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC3.EmbeddedNavigator.Name = ""
        Me.GC3.EmbeddedNavigator.TextStringFormat = ""
        Me.GC3.Location = New System.Drawing.Point(3, 3)
        Me.GC3.MainView = Me.GV3
        Me.GC3.Name = "GC3"
        Me.GC3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpNBCont, Me.rpContenuReel, Me.rpContPossible, Me.rpTexte})
        Me.GC3.Size = New System.Drawing.Size(765, 83)
        Me.GC3.TabIndex = 8
        Me.GC3.UseEmbeddedNavigator = True
        Me.GC3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV3})
        '
        'GV3
        '
        Me.GV3.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV3.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV3.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV3.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV3.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV3.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV3.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV3.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV3.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV3.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GV3.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV3.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV3.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV3.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV3.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV3.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV3.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GV3.Appearance.Empty.Options.UseBackColor = True
        Me.GV3.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV3.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV3.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV3.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV3.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV3.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV3.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV3.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV3.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV3.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV3.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV3.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV3.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV3.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GV3.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV3.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV3.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GV3.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV3.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV3.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV3.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV3.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV3.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GV3.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV3.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV3.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV3.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV3.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV3.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV3.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV3.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV3.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV3.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV3.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV3.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV3.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV3.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GV3.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV3.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV3.Appearance.GroupButton.Options.UseForeColor = True
        Me.GV3.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV3.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV3.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV3.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV3.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV3.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV3.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV3.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV3.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV3.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV3.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV3.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV3.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GV3.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV3.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV3.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV3.Appearance.GroupRow.Options.UseFont = True
        Me.GV3.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV3.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV3.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV3.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV3.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV3.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV3.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV3.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV3.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV3.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV3.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV3.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV3.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV3.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV3.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV3.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GV3.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV3.Appearance.OddRow.Options.UseBackColor = True
        Me.GV3.Appearance.OddRow.Options.UseForeColor = True
        Me.GV3.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV3.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV3.Appearance.Preview.Options.UseBackColor = True
        Me.GV3.Appearance.Preview.Options.UseForeColor = True
        Me.GV3.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GV3.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV3.Appearance.Row.Options.UseBackColor = True
        Me.GV3.Appearance.Row.Options.UseForeColor = True
        Me.GV3.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GV3.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV3.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GV3.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GV3.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV3.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV3.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV3.Appearance.VertLine.Options.UseBackColor = True
        Me.GV3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPRECONT_PRE_CODE_FK_PK, Me.colPRECONT_COCONT_NUM_FK_PK, Me.colPRECONT_NBCONTENANT, Me.colPRECONT_CDF_COCDT_CODE_FK, Me.colPRECONT_NBCONTENANT_REEL, Me.colPRECONT_NBCONTENANCE, Me.colPRECONT_CDF_COCE_CODE_FK, Me.colPRECONT_VOLCONTENANT, Me.colPRECONT_CDF_VOLCONT_CODE_FK})
        Me.GV3.GridControl = Me.GC3
        Me.GV3.GroupPanelText = " "
        Me.GV3.Name = "GV3"
        Me.GV3.OptionsView.EnableAppearanceEvenRow = True
        Me.GV3.OptionsView.EnableAppearanceOddRow = True
        Me.GV3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV3.OptionsView.RowAutoHeight = True
        Me.GV3.OptionsView.ShowDetailButtons = False
        Me.GV3.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV3.OptionsView.ShowGroupPanel = False
        Me.GV3.OptionsView.ShowHorzLines = False
        Me.GV3.OptionsView.ShowIndicator = False
        Me.GV3.OptionsView.ShowPreviewLines = False
        Me.GV3.OptionsView.ShowVertLines = False
        Me.GV3.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        '
        'colPRECONT_PRE_CODE_FK_PK
        '
        Me.colPRECONT_PRE_CODE_FK_PK.Caption = "PRECONT_PRE_CODE_FK_PK"
        Me.colPRECONT_PRE_CODE_FK_PK.FieldName = "PRECONT_PRE_CODE_FK_PK"
        Me.colPRECONT_PRE_CODE_FK_PK.Name = "colPRECONT_PRE_CODE_FK_PK"
        '
        'colPRECONT_COCONT_NUM_FK_PK
        '
        Me.colPRECONT_COCONT_NUM_FK_PK.Caption = "PRECONT_COCONT_NUM_FK_PK"
        Me.colPRECONT_COCONT_NUM_FK_PK.FieldName = "PRECONT_COCONT_NUM_FK_PK"
        Me.colPRECONT_COCONT_NUM_FK_PK.Name = "colPRECONT_COCONT_NUM_FK_PK"
        '
        'colPRECONT_NBCONTENANT
        '
        Me.colPRECONT_NBCONTENANT.Caption = "Nb de contenant"
        Me.colPRECONT_NBCONTENANT.ColumnEdit = Me.rpTexte
        Me.colPRECONT_NBCONTENANT.FieldName = "PRECONT_NBCONTENANT"
        Me.colPRECONT_NBCONTENANT.Name = "colPRECONT_NBCONTENANT"
        Me.colPRECONT_NBCONTENANT.Visible = True
        Me.colPRECONT_NBCONTENANT.VisibleIndex = 0
        Me.colPRECONT_NBCONTENANT.Width = 80
        '
        'rpTexte
        '
        Me.rpTexte.AutoHeight = False
        Me.rpTexte.MaxLength = 4
        Me.rpTexte.Name = "rpTexte"
        '
        'colPRECONT_CDF_COCDT_CODE_FK
        '
        Me.colPRECONT_CDF_COCDT_CODE_FK.Caption = "Libellé"
        Me.colPRECONT_CDF_COCDT_CODE_FK.ColumnEdit = Me.rpNBCont
        Me.colPRECONT_CDF_COCDT_CODE_FK.FieldName = "PRECONT_CDF_COCDT_CODE_FK"
        Me.colPRECONT_CDF_COCDT_CODE_FK.Name = "colPRECONT_CDF_COCDT_CODE_FK"
        Me.colPRECONT_CDF_COCDT_CODE_FK.Visible = True
        Me.colPRECONT_CDF_COCDT_CODE_FK.VisibleIndex = 1
        Me.colPRECONT_CDF_COCDT_CODE_FK.Width = 111
        '
        'rpNBCont
        '
        Me.rpNBCont.AutoHeight = False
        Me.rpNBCont.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpNBCont.Name = "rpNBCont"
        Me.rpNBCont.NullText = ""
        '
        'colPRECONT_NBCONTENANT_REEL
        '
        Me.colPRECONT_NBCONTENANT_REEL.Caption = "PRECONT_NBCONTENANT_REEL"
        Me.colPRECONT_NBCONTENANT_REEL.FieldName = "PRECONT_NBCONTENANT_REEL"
        Me.colPRECONT_NBCONTENANT_REEL.Name = "colPRECONT_NBCONTENANT_REEL"
        '
        'colPRECONT_NBCONTENANCE
        '
        Me.colPRECONT_NBCONTENANCE.Caption = "NB"
        Me.colPRECONT_NBCONTENANCE.FieldName = "PRECONT_NBCONTENANCE"
        Me.colPRECONT_NBCONTENANCE.Name = "colPRECONT_NBCONTENANCE"
        Me.colPRECONT_NBCONTENANCE.Visible = True
        Me.colPRECONT_NBCONTENANCE.VisibleIndex = 2
        Me.colPRECONT_NBCONTENANCE.Width = 58
        '
        'colPRECONT_CDF_COCE_CODE_FK
        '
        Me.colPRECONT_CDF_COCE_CODE_FK.Caption = "Contenu réel"
        Me.colPRECONT_CDF_COCE_CODE_FK.ColumnEdit = Me.rpContenuReel
        Me.colPRECONT_CDF_COCE_CODE_FK.FieldName = "PRECONT_CDF_COCE_CODE_FK"
        Me.colPRECONT_CDF_COCE_CODE_FK.Name = "colPRECONT_CDF_COCE_CODE_FK"
        Me.colPRECONT_CDF_COCE_CODE_FK.Visible = True
        Me.colPRECONT_CDF_COCE_CODE_FK.VisibleIndex = 3
        Me.colPRECONT_CDF_COCE_CODE_FK.Width = 127
        '
        'rpContenuReel
        '
        Me.rpContenuReel.AutoHeight = False
        Me.rpContenuReel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpContenuReel.Name = "rpContenuReel"
        '
        'colPRECONT_VOLCONTENANT
        '
        Me.colPRECONT_VOLCONTENANT.Caption = "NB"
        Me.colPRECONT_VOLCONTENANT.FieldName = "PRECONT_VOLCONTENANT"
        Me.colPRECONT_VOLCONTENANT.Name = "colPRECONT_VOLCONTENANT"
        Me.colPRECONT_VOLCONTENANT.Visible = True
        Me.colPRECONT_VOLCONTENANT.VisibleIndex = 4
        Me.colPRECONT_VOLCONTENANT.Width = 62
        '
        'colPRECONT_CDF_VOLCONT_CODE_FK
        '
        Me.colPRECONT_CDF_VOLCONT_CODE_FK.Caption = "Contenu possible"
        Me.colPRECONT_CDF_VOLCONT_CODE_FK.ColumnEdit = Me.rpContPossible
        Me.colPRECONT_CDF_VOLCONT_CODE_FK.FieldName = "PRECONT_CDF_VOLCONT_CODE_FK"
        Me.colPRECONT_CDF_VOLCONT_CODE_FK.Name = "colPRECONT_CDF_VOLCONT_CODE_FK"
        Me.colPRECONT_CDF_VOLCONT_CODE_FK.Visible = True
        Me.colPRECONT_CDF_VOLCONT_CODE_FK.VisibleIndex = 5
        Me.colPRECONT_CDF_VOLCONT_CODE_FK.Width = 202
        '
        'rpContPossible
        '
        Me.rpContPossible.AutoHeight = False
        Me.rpContPossible.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpContPossible.Name = "rpContPossible"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GC, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GC1, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.Padding = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(771, 89)
        Me.TableLayoutPanel2.TabIndex = 12
        '
        'GC
        '
        Me.GC.DataMember = "PREDISP_PRE_DISPENSATION"
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC.EmbeddedNavigator.Name = ""
        Me.GC.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC.Location = New System.Drawing.Point(5, 5)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpUnite, Me.rpSubACT})
        Me.GC.Size = New System.Drawing.Size(377, 79)
        Me.GC.TabIndex = 5
        Me.GC.UseEmbeddedNavigator = True
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPREDISP_PRE_CODE_FK_PK, Me.colPREDISP_NUMSEQ_PK, Me.colPREDISP_SAC_CODE_FK, Me.colPREDISP_UNITEDISP, Me.colPREDISP_CDF_UD_CODE_FK})
        Me.GV.GridControl = Me.GC
        Me.GV.GroupPanelText = " "
        Me.GV.Name = "GV"
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV.OptionsView.ShowGroupPanel = False
        Me.GV.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPREDISP_NUMSEQ_PK, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colPREDISP_PRE_CODE_FK_PK
        '
        Me.colPREDISP_PRE_CODE_FK_PK.Caption = "PREDISP_PRE_CODE_FK_PK"
        Me.colPREDISP_PRE_CODE_FK_PK.FieldName = "PREDISP_PRE_CODE_FK_PK"
        Me.colPREDISP_PRE_CODE_FK_PK.Name = "colPREDISP_PRE_CODE_FK_PK"
        '
        'colPREDISP_NUMSEQ_PK
        '
        Me.colPREDISP_NUMSEQ_PK.Caption = "N°"
        Me.colPREDISP_NUMSEQ_PK.FieldName = "PREDISP_NUMSEQ_PK"
        Me.colPREDISP_NUMSEQ_PK.Name = "colPREDISP_NUMSEQ_PK"
        Me.colPREDISP_NUMSEQ_PK.Visible = True
        Me.colPREDISP_NUMSEQ_PK.VisibleIndex = 3
        Me.colPREDISP_NUMSEQ_PK.Width = 51
        '
        'colPREDISP_SAC_CODE_FK
        '
        Me.colPREDISP_SAC_CODE_FK.Caption = "Dose totale UCD : Substance active"
        Me.colPREDISP_SAC_CODE_FK.ColumnEdit = Me.rpSubACT
        Me.colPREDISP_SAC_CODE_FK.FieldName = "PREDISP_SAC_CODE_FK"
        Me.colPREDISP_SAC_CODE_FK.Name = "colPREDISP_SAC_CODE_FK"
        Me.colPREDISP_SAC_CODE_FK.Visible = True
        Me.colPREDISP_SAC_CODE_FK.VisibleIndex = 0
        Me.colPREDISP_SAC_CODE_FK.Width = 168
        '
        'rpSubACT
        '
        Me.rpSubACT.AutoHeight = False
        Me.rpSubACT.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpSubACT.Name = "rpSubACT"
        Me.rpSubACT.NullText = ""
        '
        'colPREDISP_UNITEDISP
        '
        Me.colPREDISP_UNITEDISP.Caption = "Valeur"
        Me.colPREDISP_UNITEDISP.FieldName = "PREDISP_UNITEDISP"
        Me.colPREDISP_UNITEDISP.Name = "colPREDISP_UNITEDISP"
        Me.colPREDISP_UNITEDISP.Visible = True
        Me.colPREDISP_UNITEDISP.VisibleIndex = 1
        Me.colPREDISP_UNITEDISP.Width = 55
        '
        'colPREDISP_CDF_UD_CODE_FK
        '
        Me.colPREDISP_CDF_UD_CODE_FK.Caption = "Unité"
        Me.colPREDISP_CDF_UD_CODE_FK.ColumnEdit = Me.rpUnite
        Me.colPREDISP_CDF_UD_CODE_FK.FieldName = "PREDISP_CDF_UD_CODE_FK"
        Me.colPREDISP_CDF_UD_CODE_FK.Name = "colPREDISP_CDF_UD_CODE_FK"
        Me.colPREDISP_CDF_UD_CODE_FK.Visible = True
        Me.colPREDISP_CDF_UD_CODE_FK.VisibleIndex = 2
        Me.colPREDISP_CDF_UD_CODE_FK.Width = 58
        '
        'rpUnite
        '
        Me.rpUnite.AutoHeight = False
        Me.rpUnite.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpUnite.Name = "rpUnite"
        '
        'GC1
        '
        Me.GC1.DataMember = "PREUCD_COMMENT_DOSEUCD"
        Me.GC1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC1.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC1.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC1.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC1.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC1.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC1.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC1.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC1.EmbeddedNavigator.Name = ""
        Me.GC1.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC1.Location = New System.Drawing.Point(388, 5)
        Me.GC1.MainView = Me.GV1
        Me.GC1.Name = "GC1"
        Me.GC1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpCommentaire})
        Me.GC1.Size = New System.Drawing.Size(378, 79)
        Me.GC1.TabIndex = 6
        Me.GC1.UseEmbeddedNavigator = True
        Me.GC1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPREUCD_PRE_CODE_FK_PK, Me.colPREUCD_CDF_COMUCD_CODE_FK_PK, Me.colPREUCD_NUMORD})
        Me.GV1.GridControl = Me.GC1
        Me.GV1.GroupPanelText = " "
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV1.OptionsView.ShowGroupPanel = False
        Me.GV1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPREUCD_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colPREUCD_PRE_CODE_FK_PK
        '
        Me.colPREUCD_PRE_CODE_FK_PK.Caption = "PREUCD_PRE_CODE_FK_PK"
        Me.colPREUCD_PRE_CODE_FK_PK.FieldName = "PREUCD_PRE_CODE_FK_PK"
        Me.colPREUCD_PRE_CODE_FK_PK.Name = "colPREUCD_PRE_CODE_FK_PK"
        '
        'colPREUCD_CDF_COMUCD_CODE_FK_PK
        '
        Me.colPREUCD_CDF_COMUCD_CODE_FK_PK.Caption = "Commentaire dose tot UCD"
        Me.colPREUCD_CDF_COMUCD_CODE_FK_PK.ColumnEdit = Me.rpCommentaire
        Me.colPREUCD_CDF_COMUCD_CODE_FK_PK.FieldName = "PREUCD_CDF_COMUCD_CODE_FK_PK"
        Me.colPREUCD_CDF_COMUCD_CODE_FK_PK.Name = "colPREUCD_CDF_COMUCD_CODE_FK_PK"
        Me.colPREUCD_CDF_COMUCD_CODE_FK_PK.Visible = True
        Me.colPREUCD_CDF_COMUCD_CODE_FK_PK.VisibleIndex = 0
        Me.colPREUCD_CDF_COMUCD_CODE_FK_PK.Width = 224
        '
        'rpCommentaire
        '
        Me.rpCommentaire.AutoHeight = False
        Me.rpCommentaire.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpCommentaire.Name = "rpCommentaire"
        Me.rpCommentaire.NullText = ""
        '
        'colPREUCD_NUMORD
        '
        Me.colPREUCD_NUMORD.Caption = "N°"
        Me.colPREUCD_NUMORD.FieldName = "PREUCD_NUMORD"
        Me.colPREUCD_NUMORD.Name = "colPREUCD_NUMORD"
        Me.colPREUCD_NUMORD.Visible = True
        Me.colPREUCD_NUMORD.VisibleIndex = 1
        Me.colPREUCD_NUMORD.Width = 44
        '
        'GC2
        '
        Me.GC2.DataMember = "COCONT_COMPO_CONTENANT"
        Me.GC2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC2.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC2.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC2.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC2.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC2.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC2.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC2.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC2.EmbeddedNavigator.Name = ""
        Me.GC2.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC2.Location = New System.Drawing.Point(3, 98)
        Me.GC2.MainView = Me.GV2
        Me.GC2.Name = "GC2"
        Me.GC2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkupCont})
        Me.GC2.Size = New System.Drawing.Size(771, 89)
        Me.GC2.TabIndex = 7
        Me.GC2.UseEmbeddedNavigator = True
        Me.GC2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCOCONT_PRE_CODE_FK_PK, Me.colCOCONT_NUM_PK, Me.colCOCONT_CDF_GAL_CODE_FK, Me.colCOCONT_NUMORD})
        Me.GV2.GridControl = Me.GC2
        Me.GV2.GroupPanelText = " "
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsDetail.EnableMasterViewMode = False
        Me.GV2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV2.OptionsView.ShowGroupPanel = False
        Me.GV2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCOCONT_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colCOCONT_PRE_CODE_FK_PK
        '
        Me.colCOCONT_PRE_CODE_FK_PK.Caption = "COCONT_PRE_CODE_FK_PK"
        Me.colCOCONT_PRE_CODE_FK_PK.FieldName = "COCONT_PRE_CODE_FK_PK"
        Me.colCOCONT_PRE_CODE_FK_PK.Name = "colCOCONT_PRE_CODE_FK_PK"
        '
        'colCOCONT_NUM_PK
        '
        Me.colCOCONT_NUM_PK.Caption = "Contenant n°"
        Me.colCOCONT_NUM_PK.FieldName = "COCONT_NUM_PK"
        Me.colCOCONT_NUM_PK.Name = "colCOCONT_NUM_PK"
        Me.colCOCONT_NUM_PK.OptionsColumn.AllowFocus = False
        Me.colCOCONT_NUM_PK.Visible = True
        Me.colCOCONT_NUM_PK.VisibleIndex = 0
        Me.colCOCONT_NUM_PK.Width = 94
        '
        'colCOCONT_CDF_GAL_CODE_FK
        '
        Me.colCOCONT_CDF_GAL_CODE_FK.Caption = "Galénique"
        Me.colCOCONT_CDF_GAL_CODE_FK.ColumnEdit = Me.lkupCont
        Me.colCOCONT_CDF_GAL_CODE_FK.FieldName = "COCONT_CDF_GAL_CODE_FK"
        Me.colCOCONT_CDF_GAL_CODE_FK.Name = "colCOCONT_CDF_GAL_CODE_FK"
        Me.colCOCONT_CDF_GAL_CODE_FK.Visible = True
        Me.colCOCONT_CDF_GAL_CODE_FK.VisibleIndex = 1
        Me.colCOCONT_CDF_GAL_CODE_FK.Width = 481
        '
        'lkupCont
        '
        Me.lkupCont.AutoHeight = False
        Me.lkupCont.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupCont.Name = "lkupCont"
        '
        'colCOCONT_NUMORD
        '
        Me.colCOCONT_NUMORD.Caption = "N°"
        Me.colCOCONT_NUMORD.FieldName = "COCONT_NUMORD"
        Me.colCOCONT_NUMORD.Name = "colCOCONT_NUMORD"
        Me.colCOCONT_NUMORD.Visible = True
        Me.colCOCONT_NUMORD.VisibleIndex = 2
        Me.colCOCONT_NUMORD.Width = 84
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.TextEdit4)
        Me.Panel4.Controls.Add(Me.lkupUCD)
        Me.Panel4.Controls.Add(Me.lkupPrise)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.txtNBPrise)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(777, 93)
        Me.Panel4.TabIndex = 12
        '
        'TextEdit4
        '
        Me.TextEdit4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_LIB_CEPS", True))
        Me.TextEdit4.EditValue = ""
        Me.TextEdit4.Location = New System.Drawing.Point(81, 11)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Size = New System.Drawing.Size(680, 20)
        Me.TextEdit4.TabIndex = 0
        Me.TextEdit4.Tag = ""
        '
        'lkupUCD
        '
        Me.lkupUCD.Location = New System.Drawing.Point(81, 62)
        Me.lkupUCD.Name = "lkupUCD"
        Me.lkupUCD.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupUCD.Size = New System.Drawing.Size(451, 20)
        Me.lkupUCD.TabIndex = 4
        Me.lkupUCD.Tag = ""
        '
        'lkupPrise
        '
        Me.lkupPrise.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkupPrise.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_CDF_UP_CODE_FK", True))
        Me.lkupPrise.Location = New System.Drawing.Point(276, 37)
        Me.lkupPrise.Name = "lkupPrise"
        Me.lkupPrise.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupPrise.Properties.NullText = ""
        Me.lkupPrise.Size = New System.Drawing.Size(485, 20)
        Me.lkupPrise.TabIndex = 2
        Me.lkupPrise.Tag = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Libellé CEPS"
        '
        'txtNBPrise
        '
        Me.txtNBPrise.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_NBUNITE", True))
        Me.txtNBPrise.Location = New System.Drawing.Point(81, 37)
        Me.txtNBPrise.Name = "txtNBPrise"
        Me.txtNBPrise.Size = New System.Drawing.Size(63, 20)
        Me.txtNBPrise.TabIndex = 1
        Me.txtNBPrise.Tag = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Nature UCD"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(198, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Unité de prise"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Nb de prise "
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.PanMain4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(493, 417)
        Me.XtraTabPage2.Text = "Taux de remboursement"
        '
        'PanMain4
        '
        Me.PanMain4.Controls.Add(Me.Panel11)
        Me.PanMain4.Controls.Add(Me.btPrix)
        Me.PanMain4.Controls.Add(Me.lkupPresentationUnitaire)
        Me.PanMain4.Controls.Add(Me.Panel3)
        Me.PanMain4.Controls.Add(Me.Label12)
        Me.PanMain4.Controls.Add(Me.TextEdit7)
        Me.PanMain4.Controls.Add(Me.Label11)
        Me.PanMain4.Controls.Add(Me.LabelControl3)
        Me.PanMain4.Controls.Add(Me.MemoEdit1)
        Me.PanMain4.Controls.Add(Me.GC6)
        Me.PanMain4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMain4.Location = New System.Drawing.Point(0, 0)
        Me.PanMain4.Name = "PanMain4"
        Me.PanMain4.Size = New System.Drawing.Size(493, 417)
        Me.PanMain4.TabIndex = 0
        Me.PanMain4.Tag = "[ADD][EDIT]"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.GC20)
        Me.Panel11.Location = New System.Drawing.Point(390, 187)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(329, 86)
        Me.Panel11.TabIndex = 18
        '
        'GC20
        '
        Me.GC20.DataMember = "PRECPSS"
        Me.GC20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC20.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC20.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC20.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC20.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC20.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC20.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC20.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC20.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC20.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC20.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC20.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC20.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC20.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC20.EmbeddedNavigator.Name = ""
        Me.GC20.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC20.Location = New System.Drawing.Point(0, 0)
        Me.GC20.MainView = Me.GV20
        Me.GC20.Name = "GC20"
        Me.GC20.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemImageComboBox1, Me.rpCDF_CODIF, Me.RepositoryItemLookUpEdit3})
        Me.GC20.Size = New System.Drawing.Size(329, 86)
        Me.GC20.TabIndex = 6
        Me.GC20.UseEmbeddedNavigator = True
        Me.GC20.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV20})
        '
        'GV20
        '
        Me.GV20.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColPRECPSS_PRE_CODE_FK_PK, Me.colCDF_NOM})
        Me.GV20.GridControl = Me.GC20
        Me.GV20.GroupPanelText = " "
        Me.GV20.Name = "GV20"
        Me.GV20.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV20.OptionsView.ShowGroupPanel = False
        '
        'ColPRECPSS_PRE_CODE_FK_PK
        '
        Me.ColPRECPSS_PRE_CODE_FK_PK.Caption = "ColPRECPSS_PRE_CODE_FK_PK"
        Me.ColPRECPSS_PRE_CODE_FK_PK.FieldName = "PRECPSS_PRE_CODE_FK_PK"
        Me.ColPRECPSS_PRE_CODE_FK_PK.Name = "ColPRECPSS_PRE_CODE_FK_PK"
        '
        'colCDF_NOM
        '
        Me.colCDF_NOM.Caption = "code nature prestation sécurité sociale"
        Me.colCDF_NOM.ColumnEdit = Me.rpCDF_CODIF
        Me.colCDF_NOM.FieldName = "PRECPSS_CDF_CPSS_CODE_FK_PK"
        Me.colCDF_NOM.Name = "colCDF_NOM"
        Me.colCDF_NOM.Visible = True
        Me.colCDF_NOM.VisibleIndex = 0
        '
        'rpCDF_CODIF
        '
        Me.rpCDF_CODIF.AutoHeight = False
        Me.rpCDF_CODIF.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpCDF_CODIF.Name = "rpCDF_CODIF"
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'RepositoryItemImageComboBox1
        '
        Me.RepositoryItemImageComboBox1.AutoHeight = False
        Me.RepositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        '
        'btPrix
        '
        Me.btPrix.Location = New System.Drawing.Point(312, 187)
        Me.btPrix.Name = "btPrix"
        Me.btPrix.Size = New System.Drawing.Size(71, 46)
        Me.btPrix.TabIndex = 4
        Me.btPrix.Text = "Prix"
        '
        'lkupPresentationUnitaire
        '
        Me.lkupPresentationUnitaire.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_CDF_PU_CODE_FK", True))
        Me.lkupPresentationUnitaire.Location = New System.Drawing.Point(110, 213)
        Me.lkupPresentationUnitaire.Name = "lkupPresentationUnitaire"
        Me.lkupPresentationUnitaire.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupPresentationUnitaire.Size = New System.Drawing.Size(196, 20)
        Me.lkupPresentationUnitaire.TabIndex = 3
        Me.lkupPresentationUnitaire.Tag = "[ADD][EDIT]"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.GC8)
        Me.Panel3.Controls.Add(Me.GC7)
        Me.Panel3.Location = New System.Drawing.Point(8, 279)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(482, 132)
        Me.Panel3.TabIndex = 17
        '
        'GC8
        '
        Me.GC8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC8.DataMember = "PRETSSH_PRE_TAUX_HOP"
        Me.GC8.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC8.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC8.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC8.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC8.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC8.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC8.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC8.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC8.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC8.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC8.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC8.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC8.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC8.EmbeddedNavigator.Name = ""
        Me.GC8.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC8.Location = New System.Drawing.Point(2, 101)
        Me.GC8.MainView = Me.GV8
        Me.GC8.Name = "GC8"
        Me.GC8.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpTauxSociale, Me.RpMemoEditHop})
        Me.GC8.Size = New System.Drawing.Size(475, 79)
        Me.GC8.TabIndex = 6
        Me.GC8.UseEmbeddedNavigator = True
        Me.GC8.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV8})
        '
        'GV8
        '
        Me.GV8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPRETSSH_PRE_CODE_FK_PK, Me.colPRETSSH_CDF_TSS_CODE_FK_PK, Me.colPRETSSH_NUMSEQ, Me.colPRETSSH_DATE_APPLI_PK, Me.colPRETSSH_DATE_APPLIQUEE, Me.colPRETSSH_TEXTE})
        Me.GV8.GridControl = Me.GC8
        Me.GV8.GroupPanelText = " "
        Me.GV8.Name = "GV8"
        Me.GV8.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV8.OptionsView.ShowGroupPanel = False
        Me.GV8.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPRETSSH_NUMSEQ, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colPRETSSH_PRE_CODE_FK_PK
        '
        Me.colPRETSSH_PRE_CODE_FK_PK.Caption = "PRETSSH_PRE_CODE_FK_PK"
        Me.colPRETSSH_PRE_CODE_FK_PK.FieldName = "PRETSSH_PRE_CODE_FK_PK"
        Me.colPRETSSH_PRE_CODE_FK_PK.Name = "colPRETSSH_PRE_CODE_FK_PK"
        '
        'colPRETSSH_CDF_TSS_CODE_FK_PK
        '
        Me.colPRETSSH_CDF_TSS_CODE_FK_PK.Caption = "Taux Rbst SS hôpital : Taux sécurité sociale"
        Me.colPRETSSH_CDF_TSS_CODE_FK_PK.ColumnEdit = Me.rpTauxSociale
        Me.colPRETSSH_CDF_TSS_CODE_FK_PK.FieldName = "PRETSSH_CDF_TSS_CODE_FK_PK"
        Me.colPRETSSH_CDF_TSS_CODE_FK_PK.Name = "colPRETSSH_CDF_TSS_CODE_FK_PK"
        Me.colPRETSSH_CDF_TSS_CODE_FK_PK.Visible = True
        Me.colPRETSSH_CDF_TSS_CODE_FK_PK.VisibleIndex = 0
        Me.colPRETSSH_CDF_TSS_CODE_FK_PK.Width = 204
        '
        'rpTauxSociale
        '
        Me.rpTauxSociale.AutoHeight = False
        Me.rpTauxSociale.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpTauxSociale.Name = "rpTauxSociale"
        '
        'colPRETSSH_NUMSEQ
        '
        Me.colPRETSSH_NUMSEQ.Caption = "N°"
        Me.colPRETSSH_NUMSEQ.FieldName = "PRETSSH_NUMSEQ"
        Me.colPRETSSH_NUMSEQ.Name = "colPRETSSH_NUMSEQ"
        Me.colPRETSSH_NUMSEQ.Visible = True
        Me.colPRETSSH_NUMSEQ.VisibleIndex = 4
        Me.colPRETSSH_NUMSEQ.Width = 52
        '
        'colPRETSSH_DATE_APPLI_PK
        '
        Me.colPRETSSH_DATE_APPLI_PK.Caption = "Parution JO"
        Me.colPRETSSH_DATE_APPLI_PK.FieldName = "PRETSSH_DATE_APPLI_PK"
        Me.colPRETSSH_DATE_APPLI_PK.Name = "colPRETSSH_DATE_APPLI_PK"
        Me.colPRETSSH_DATE_APPLI_PK.Visible = True
        Me.colPRETSSH_DATE_APPLI_PK.VisibleIndex = 1
        Me.colPRETSSH_DATE_APPLI_PK.Width = 105
        '
        'colPRETSSH_DATE_APPLIQUEE
        '
        Me.colPRETSSH_DATE_APPLIQUEE.Caption = "Appli."
        Me.colPRETSSH_DATE_APPLIQUEE.FieldName = "PRETSSH_DATE_APPLIQUEE"
        Me.colPRETSSH_DATE_APPLIQUEE.Name = "colPRETSSH_DATE_APPLIQUEE"
        Me.colPRETSSH_DATE_APPLIQUEE.Visible = True
        Me.colPRETSSH_DATE_APPLIQUEE.VisibleIndex = 2
        Me.colPRETSSH_DATE_APPLIQUEE.Width = 104
        '
        'colPRETSSH_TEXTE
        '
        Me.colPRETSSH_TEXTE.Caption = "Texte"
        Me.colPRETSSH_TEXTE.ColumnEdit = Me.RpMemoEditHop
        Me.colPRETSSH_TEXTE.FieldName = "PRETSSH_TEXTE"
        Me.colPRETSSH_TEXTE.Name = "colPRETSSH_TEXTE"
        Me.colPRETSSH_TEXTE.Visible = True
        Me.colPRETSSH_TEXTE.VisibleIndex = 3
        Me.colPRETSSH_TEXTE.Width = 187
        '
        'RpMemoEditHop
        '
        Me.RpMemoEditHop.Name = "RpMemoEditHop"
        '
        'GC7
        '
        Me.GC7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC7.DataMember = "PRETSS_PRESENTATION_TAUX"
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
        Me.GC7.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC7.Location = New System.Drawing.Point(2, 7)
        Me.GC7.MainView = Me.GV7
        Me.GC7.Name = "GC7"
        Me.GC7.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpTauxRBS, Me.RpMemoEditVille})
        Me.GC7.Size = New System.Drawing.Size(475, 88)
        Me.GC7.TabIndex = 5
        Me.GC7.UseEmbeddedNavigator = True
        Me.GC7.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV7})
        '
        'GV7
        '
        Me.GV7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPRETSS_PRE_CODE_FK_PK, Me.colPRETSS_CDF_TSS_CODE_FK_PK, Me.colPRETSS_NUMSEQ, Me.colPRETSS_DATE_APPLI_PK, Me.colPRETSS_DATE_APPLIQUEE, Me.colPRETSS_TEXTE})
        Me.GV7.GridControl = Me.GC7
        Me.GV7.GroupPanelText = " "
        Me.GV7.Name = "GV7"
        Me.GV7.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV7.OptionsView.ShowGroupPanel = False
        Me.GV7.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPRETSS_NUMSEQ, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colPRETSS_PRE_CODE_FK_PK
        '
        Me.colPRETSS_PRE_CODE_FK_PK.Caption = "PRETSS_PRE_CODE_FK_PK"
        Me.colPRETSS_PRE_CODE_FK_PK.FieldName = "PRETSS_PRE_CODE_FK_PK"
        Me.colPRETSS_PRE_CODE_FK_PK.Name = "colPRETSS_PRE_CODE_FK_PK"
        Me.colPRETSS_PRE_CODE_FK_PK.Width = 100
        '
        'colPRETSS_CDF_TSS_CODE_FK_PK
        '
        Me.colPRETSS_CDF_TSS_CODE_FK_PK.Caption = "Taux Rbst SS ville : Taux sécurité sociale"
        Me.colPRETSS_CDF_TSS_CODE_FK_PK.ColumnEdit = Me.rpTauxRBS
        Me.colPRETSS_CDF_TSS_CODE_FK_PK.FieldName = "PRETSS_CDF_TSS_CODE_FK_PK"
        Me.colPRETSS_CDF_TSS_CODE_FK_PK.Name = "colPRETSS_CDF_TSS_CODE_FK_PK"
        Me.colPRETSS_CDF_TSS_CODE_FK_PK.Visible = True
        Me.colPRETSS_CDF_TSS_CODE_FK_PK.VisibleIndex = 0
        Me.colPRETSS_CDF_TSS_CODE_FK_PK.Width = 188
        '
        'rpTauxRBS
        '
        Me.rpTauxRBS.AutoHeight = False
        Me.rpTauxRBS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpTauxRBS.Name = "rpTauxRBS"
        '
        'colPRETSS_NUMSEQ
        '
        Me.colPRETSS_NUMSEQ.Caption = "N°"
        Me.colPRETSS_NUMSEQ.FieldName = "PRETSS_NUMSEQ"
        Me.colPRETSS_NUMSEQ.Name = "colPRETSS_NUMSEQ"
        Me.colPRETSS_NUMSEQ.Visible = True
        Me.colPRETSS_NUMSEQ.VisibleIndex = 4
        Me.colPRETSS_NUMSEQ.Width = 42
        '
        'colPRETSS_DATE_APPLI_PK
        '
        Me.colPRETSS_DATE_APPLI_PK.Caption = "Parution JO"
        Me.colPRETSS_DATE_APPLI_PK.FieldName = "PRETSS_DATE_APPLI_PK"
        Me.colPRETSS_DATE_APPLI_PK.Name = "colPRETSS_DATE_APPLI_PK"
        Me.colPRETSS_DATE_APPLI_PK.Visible = True
        Me.colPRETSS_DATE_APPLI_PK.VisibleIndex = 1
        Me.colPRETSS_DATE_APPLI_PK.Width = 101
        '
        'colPRETSS_DATE_APPLIQUEE
        '
        Me.colPRETSS_DATE_APPLIQUEE.Caption = "Appli."
        Me.colPRETSS_DATE_APPLIQUEE.FieldName = "PRETSS_DATE_APPLIQUEE"
        Me.colPRETSS_DATE_APPLIQUEE.Name = "colPRETSS_DATE_APPLIQUEE"
        Me.colPRETSS_DATE_APPLIQUEE.Visible = True
        Me.colPRETSS_DATE_APPLIQUEE.VisibleIndex = 2
        Me.colPRETSS_DATE_APPLIQUEE.Width = 101
        '
        'colPRETSS_TEXTE
        '
        Me.colPRETSS_TEXTE.Caption = "Texte"
        Me.colPRETSS_TEXTE.ColumnEdit = Me.RpMemoEditVille
        Me.colPRETSS_TEXTE.FieldName = "PRETSS_TEXTE"
        Me.colPRETSS_TEXTE.Name = "colPRETSS_TEXTE"
        Me.colPRETSS_TEXTE.Visible = True
        Me.colPRETSS_TEXTE.VisibleIndex = 3
        Me.colPRETSS_TEXTE.Width = 169
        '
        'RpMemoEditVille
        '
        Me.RpMemoEditVille.Name = "RpMemoEditVille"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 216)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Présentation unitaire"
        '
        'TextEdit7
        '
        Me.TextEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_ADMIN", True))
        Me.TextEdit7.Location = New System.Drawing.Point(110, 187)
        Me.TextEdit7.Name = "TextEdit7"
        Me.TextEdit7.Size = New System.Drawing.Size(196, 20)
        Me.TextEdit7.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 190)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Présentation admin"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(8, 101)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "Texte caract compl"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MemoEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_CACDT_TEXTE", True))
        Me.MemoEdit1.Location = New System.Drawing.Point(3, 120)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Properties.MaxLength = 255
        Me.MemoEdit1.Size = New System.Drawing.Size(482, 61)
        Me.MemoEdit1.TabIndex = 1
        '
        'GC6
        '
        Me.GC6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC6.DataMember = "PRECEMB_PRE_CAREMBALLAGE"
        Me.GC6.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC6.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC6.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC6.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC6.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC6.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC6.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC6.EmbeddedNavigator.Name = ""
        Me.GC6.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC6.Location = New System.Drawing.Point(3, 7)
        Me.GC6.MainView = Me.GV6
        Me.GC6.Name = "GC6"
        Me.GC6.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpCractEmb})
        Me.GC6.Size = New System.Drawing.Size(485, 88)
        Me.GC6.TabIndex = 0
        Me.GC6.UseEmbeddedNavigator = True
        Me.GC6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV6})
        '
        'GV6
        '
        Me.GV6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPRECEMB_PRE_CODE_FK_PK, Me.colPRECEMB_CDF_CAREMB_CODE_FK_PK, Me.colPRECEMB_NUMORD})
        Me.GV6.GridControl = Me.GC6
        Me.GV6.GroupPanelText = " "
        Me.GV6.Name = "GV6"
        Me.GV6.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV6.OptionsView.ShowGroupPanel = False
        Me.GV6.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPRECEMB_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colPRECEMB_PRE_CODE_FK_PK
        '
        Me.colPRECEMB_PRE_CODE_FK_PK.Caption = "PRECEMB_PRE_CODE_FK_PK"
        Me.colPRECEMB_PRE_CODE_FK_PK.FieldName = "PRECEMB_PRE_CODE_FK_PK"
        Me.colPRECEMB_PRE_CODE_FK_PK.Name = "colPRECEMB_PRE_CODE_FK_PK"
        Me.colPRECEMB_PRE_CODE_FK_PK.Width = 180
        '
        'colPRECEMB_CDF_CAREMB_CODE_FK_PK
        '
        Me.colPRECEMB_CDF_CAREMB_CODE_FK_PK.Caption = "Caract emballage"
        Me.colPRECEMB_CDF_CAREMB_CODE_FK_PK.ColumnEdit = Me.rpCractEmb
        Me.colPRECEMB_CDF_CAREMB_CODE_FK_PK.FieldName = "PRECEMB_CDF_CAREMB_CODE_FK_PK"
        Me.colPRECEMB_CDF_CAREMB_CODE_FK_PK.Name = "colPRECEMB_CDF_CAREMB_CODE_FK_PK"
        Me.colPRECEMB_CDF_CAREMB_CODE_FK_PK.Visible = True
        Me.colPRECEMB_CDF_CAREMB_CODE_FK_PK.VisibleIndex = 0
        Me.colPRECEMB_CDF_CAREMB_CODE_FK_PK.Width = 432
        '
        'rpCractEmb
        '
        Me.rpCractEmb.AutoHeight = False
        Me.rpCractEmb.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpCractEmb.Name = "rpCractEmb"
        '
        'colPRECEMB_NUMORD
        '
        Me.colPRECEMB_NUMORD.Caption = "N°"
        Me.colPRECEMB_NUMORD.FieldName = "PRECEMB_NUMORD"
        Me.colPRECEMB_NUMORD.Name = "colPRECEMB_NUMORD"
        Me.colPRECEMB_NUMORD.Visible = True
        Me.colPRECEMB_NUMORD.VisibleIndex = 1
        Me.colPRECEMB_NUMORD.Width = 53
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.PanMain5)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(493, 417)
        Me.XtraTabPage3.Text = "Statut"
        '
        'PanMain5
        '
        Me.PanMain5.Controls.Add(Me.MemoEdit3)
        Me.PanMain5.Controls.Add(Me.MemoEdit2)
        Me.PanMain5.Controls.Add(Me.GC11)
        Me.PanMain5.Controls.Add(Me.Label21)
        Me.PanMain5.Controls.Add(Me.GC10)
        Me.PanMain5.Controls.Add(Me.GC9)
        Me.PanMain5.Controls.Add(Me.DeditSupp)
        Me.PanMain5.Controls.Add(Me.Label20)
        Me.PanMain5.Controls.Add(Me.DeditdispoDepuis)
        Me.PanMain5.Controls.Add(Me.Label10)
        Me.PanMain5.Controls.Add(Me.cmbEtatComercial)
        Me.PanMain5.Controls.Add(Me.lkPresHop)
        Me.PanMain5.Controls.Add(Me.DeditApplication)
        Me.PanMain5.Controls.Add(Me.DeditRadiation)
        Me.PanMain5.Controls.Add(Me.DateEdit4)
        Me.PanMain5.Controls.Add(Me.ComboBoxEdit1)
        Me.PanMain5.Controls.Add(Me.Label18)
        Me.PanMain5.Controls.Add(Me.Label19)
        Me.PanMain5.Controls.Add(Me.Label15)
        Me.PanMain5.Controls.Add(Me.Label17)
        Me.PanMain5.Controls.Add(Me.Label14)
        Me.PanMain5.Controls.Add(Me.Label16)
        Me.PanMain5.Controls.Add(Me.Label13)
        Me.PanMain5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMain5.Location = New System.Drawing.Point(0, 0)
        Me.PanMain5.Name = "PanMain5"
        Me.PanMain5.Size = New System.Drawing.Size(493, 417)
        Me.PanMain5.TabIndex = 0
        Me.PanMain5.Tag = "[ADD][EDIT]"
        '
        'MemoEdit3
        '
        Me.MemoEdit3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MemoEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_TSS_TEXTE", True))
        Me.MemoEdit3.Location = New System.Drawing.Point(176, 7)
        Me.MemoEdit3.Name = "MemoEdit3"
        Me.MemoEdit3.Size = New System.Drawing.Size(302, 81)
        Me.MemoEdit3.TabIndex = 0
        '
        'MemoEdit2
        '
        Me.MemoEdit2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MemoEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_PARTSTATUT", True))
        Me.MemoEdit2.Location = New System.Drawing.Point(7, 338)
        Me.MemoEdit2.Name = "MemoEdit2"
        Me.MemoEdit2.Size = New System.Drawing.Size(333, 70)
        Me.MemoEdit2.TabIndex = 11
        '
        'GC11
        '
        Me.GC11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC11.DataMember = "PRESTR_STATUT_REMBOURST"
        Me.GC11.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC11.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC11.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC11.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC11.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC11.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC11.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC11.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC11.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC11.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC11.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC11.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC11.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC11.EmbeddedNavigator.Name = ""
        Me.GC11.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC11.Location = New System.Drawing.Point(355, 323)
        Me.GC11.MainView = Me.GV11
        Me.GC11.Name = "GC11"
        Me.GC11.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpStatutR})
        Me.GC11.Size = New System.Drawing.Size(132, 88)
        Me.GC11.TabIndex = 12
        Me.GC11.UseEmbeddedNavigator = True
        Me.GC11.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV11})
        '
        'GV11
        '
        Me.GV11.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPRESTR_PRE_CODE_FK_PK, Me.colPRESTR_CDF_STR_CODE_FK_PK, Me.colPRESTR_NUMORD})
        Me.GV11.GridControl = Me.GC11
        Me.GV11.GroupPanelText = " "
        Me.GV11.Name = "GV11"
        Me.GV11.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV11.OptionsView.ShowGroupPanel = False
        Me.GV11.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPRESTR_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colPRESTR_PRE_CODE_FK_PK
        '
        Me.colPRESTR_PRE_CODE_FK_PK.Caption = "PRESTR_PRE_CODE_FK_PK"
        Me.colPRESTR_PRE_CODE_FK_PK.FieldName = "PRESTR_PRE_CODE_FK_PK"
        Me.colPRESTR_PRE_CODE_FK_PK.Name = "colPRESTR_PRE_CODE_FK_PK"
        '
        'colPRESTR_CDF_STR_CODE_FK_PK
        '
        Me.colPRESTR_CDF_STR_CODE_FK_PK.Caption = "Statut de remboursement"
        Me.colPRESTR_CDF_STR_CODE_FK_PK.ColumnEdit = Me.rpStatutR
        Me.colPRESTR_CDF_STR_CODE_FK_PK.FieldName = "PRESTR_CDF_STR_CODE_FK_PK"
        Me.colPRESTR_CDF_STR_CODE_FK_PK.Name = "colPRESTR_CDF_STR_CODE_FK_PK"
        Me.colPRESTR_CDF_STR_CODE_FK_PK.Visible = True
        Me.colPRESTR_CDF_STR_CODE_FK_PK.VisibleIndex = 0
        Me.colPRESTR_CDF_STR_CODE_FK_PK.Width = 253
        '
        'rpStatutR
        '
        Me.rpStatutR.AutoHeight = False
        Me.rpStatutR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpStatutR.Name = "rpStatutR"
        '
        'colPRESTR_NUMORD
        '
        Me.colPRESTR_NUMORD.Caption = "N°"
        Me.colPRESTR_NUMORD.FieldName = "PRESTR_NUMORD"
        Me.colPRESTR_NUMORD.Name = "colPRESTR_NUMORD"
        Me.colPRESTR_NUMORD.Visible = True
        Me.colPRESTR_NUMORD.VisibleIndex = 1
        Me.colPRESTR_NUMORD.Width = 59
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(4, 323)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(91, 13)
        Me.Label21.TabIndex = 30
        Me.Label21.Text = "Particularité statut"
        '
        'GC10
        '
        Me.GC10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC10.DataMember = "PRESTC_STATUTCOMP_PRESENT"
        Me.GC10.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC10.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC10.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC10.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC10.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC10.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC10.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC10.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC10.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC10.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC10.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC10.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC10.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC10.EmbeddedNavigator.Name = ""
        Me.GC10.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC10.Location = New System.Drawing.Point(355, 198)
        Me.GC10.MainView = Me.GV10
        Me.GC10.Name = "GC10"
        Me.GC10.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpStatutC})
        Me.GC10.Size = New System.Drawing.Size(132, 111)
        Me.GC10.TabIndex = 10
        Me.GC10.UseEmbeddedNavigator = True
        Me.GC10.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV10})
        '
        'GV10
        '
        Me.GV10.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPRESTC_PRE_CODE_FK_PK, Me.colPRESTC_CDF_STCOMP_CODE_FK_PK, Me.colPRESTC_CODE_IDENT, Me.colPRESTC_NUMORD})
        Me.GV10.GridControl = Me.GC10
        Me.GV10.GroupPanelText = " "
        Me.GV10.Name = "GV10"
        Me.GV10.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV10.OptionsView.ShowGroupPanel = False
        Me.GV10.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPRESTC_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colPRESTC_PRE_CODE_FK_PK
        '
        Me.colPRESTC_PRE_CODE_FK_PK.Caption = "PRESTC_PRE_CODE_FK_PK"
        Me.colPRESTC_PRE_CODE_FK_PK.FieldName = "PRESTC_PRE_CODE_FK_PK"
        Me.colPRESTC_PRE_CODE_FK_PK.Name = "colPRESTC_PRE_CODE_FK_PK"
        '
        'colPRESTC_CDF_STCOMP_CODE_FK_PK
        '
        Me.colPRESTC_CDF_STCOMP_CODE_FK_PK.Caption = "Statut complémentaire"
        Me.colPRESTC_CDF_STCOMP_CODE_FK_PK.ColumnEdit = Me.rpStatutC
        Me.colPRESTC_CDF_STCOMP_CODE_FK_PK.FieldName = "PRESTC_CDF_STCOMP_CODE_FK_PK"
        Me.colPRESTC_CDF_STCOMP_CODE_FK_PK.Name = "colPRESTC_CDF_STCOMP_CODE_FK_PK"
        Me.colPRESTC_CDF_STCOMP_CODE_FK_PK.Visible = True
        Me.colPRESTC_CDF_STCOMP_CODE_FK_PK.VisibleIndex = 0
        Me.colPRESTC_CDF_STCOMP_CODE_FK_PK.Width = 163
        '
        'rpStatutC
        '
        Me.rpStatutC.AutoHeight = False
        Me.rpStatutC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpStatutC.Name = "rpStatutC"
        '
        'colPRESTC_CODE_IDENT
        '
        Me.colPRESTC_CODE_IDENT.Caption = "Code"
        Me.colPRESTC_CODE_IDENT.FieldName = "PRESTC_CODE_IDENT"
        Me.colPRESTC_CODE_IDENT.Name = "colPRESTC_CODE_IDENT"
        Me.colPRESTC_CODE_IDENT.Visible = True
        Me.colPRESTC_CODE_IDENT.VisibleIndex = 1
        Me.colPRESTC_CODE_IDENT.Width = 100
        '
        'colPRESTC_NUMORD
        '
        Me.colPRESTC_NUMORD.Caption = "N°"
        Me.colPRESTC_NUMORD.FieldName = "PRESTC_NUMORD"
        Me.colPRESTC_NUMORD.Name = "colPRESTC_NUMORD"
        Me.colPRESTC_NUMORD.Visible = True
        Me.colPRESTC_NUMORD.VisibleIndex = 2
        Me.colPRESTC_NUMORD.Width = 49
        '
        'GC9
        '
        Me.GC9.DataMember = "PRESTP_PRE_STP"
        Me.GC9.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC9.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC9.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC9.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC9.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC9.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC9.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC9.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC9.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC9.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC9.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC9.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC9.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC9.EmbeddedNavigator.Name = ""
        Me.GC9.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC9.Location = New System.Drawing.Point(7, 198)
        Me.GC9.MainView = Me.GV9
        Me.GC9.Name = "GC9"
        Me.GC9.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpStatut})
        Me.GC9.Size = New System.Drawing.Size(336, 111)
        Me.GC9.TabIndex = 9
        Me.GC9.UseEmbeddedNavigator = True
        Me.GC9.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV9})
        '
        'GV9
        '
        Me.GV9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPRESTP_PRE_CODE_FK_PK, Me.colPRESTP_CDF_STP_CODE_FK_PK, Me.colPRESTP_DATE_AFSSAPS, Me.colPRESTP_NUMORD})
        Me.GV9.GridControl = Me.GC9
        Me.GV9.GroupPanelText = " "
        Me.GV9.Name = "GV9"
        Me.GV9.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV9.OptionsView.ShowGroupPanel = False
        Me.GV9.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPRESTP_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colPRESTP_PRE_CODE_FK_PK
        '
        Me.colPRESTP_PRE_CODE_FK_PK.Caption = "PRESTP_PRE_CODE_FK_PK"
        Me.colPRESTP_PRE_CODE_FK_PK.FieldName = "PRESTP_PRE_CODE_FK_PK"
        Me.colPRESTP_PRE_CODE_FK_PK.Name = "colPRESTP_PRE_CODE_FK_PK"
        '
        'colPRESTP_CDF_STP_CODE_FK_PK
        '
        Me.colPRESTP_CDF_STP_CODE_FK_PK.Caption = "Statut"
        Me.colPRESTP_CDF_STP_CODE_FK_PK.ColumnEdit = Me.rpStatut
        Me.colPRESTP_CDF_STP_CODE_FK_PK.FieldName = "PRESTP_CDF_STP_CODE_FK_PK"
        Me.colPRESTP_CDF_STP_CODE_FK_PK.Name = "colPRESTP_CDF_STP_CODE_FK_PK"
        Me.colPRESTP_CDF_STP_CODE_FK_PK.Visible = True
        Me.colPRESTP_CDF_STP_CODE_FK_PK.VisibleIndex = 0
        Me.colPRESTP_CDF_STP_CODE_FK_PK.Width = 203
        '
        'rpStatut
        '
        Me.rpStatut.AutoHeight = False
        Me.rpStatut.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpStatut.Name = "rpStatut"
        '
        'colPRESTP_DATE_AFSSAPS
        '
        Me.colPRESTP_DATE_AFSSAPS.Caption = "Date"
        Me.colPRESTP_DATE_AFSSAPS.FieldName = "PRESTP_DATE_AFSSAPS"
        Me.colPRESTP_DATE_AFSSAPS.Name = "colPRESTP_DATE_AFSSAPS"
        Me.colPRESTP_DATE_AFSSAPS.Visible = True
        Me.colPRESTP_DATE_AFSSAPS.VisibleIndex = 1
        Me.colPRESTP_DATE_AFSSAPS.Width = 76
        '
        'colPRESTP_NUMORD
        '
        Me.colPRESTP_NUMORD.Caption = "N°"
        Me.colPRESTP_NUMORD.FieldName = "PRESTP_NUMORD"
        Me.colPRESTP_NUMORD.Name = "colPRESTP_NUMORD"
        Me.colPRESTP_NUMORD.Visible = True
        Me.colPRESTP_NUMORD.VisibleIndex = 2
        Me.colPRESTP_NUMORD.Width = 33
        '
        'DeditSupp
        '
        Me.DeditSupp.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_DATESUP", True))
        Me.DeditSupp.EditValue = Nothing
        Me.DeditSupp.Location = New System.Drawing.Point(552, 172)
        Me.DeditSupp.Name = "DeditSupp"
        Me.DeditSupp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DeditSupp.Size = New System.Drawing.Size(127, 20)
        Me.DeditSupp.TabIndex = 8
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(480, 175)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 13)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Supprimé en"
        '
        'DeditdispoDepuis
        '
        Me.DeditdispoDepuis.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_DATECOMMER", True))
        Me.DeditdispoDepuis.EditValue = Nothing
        Me.DeditdispoDepuis.Location = New System.Drawing.Point(552, 146)
        Me.DeditdispoDepuis.Name = "DeditdispoDepuis"
        Me.DeditdispoDepuis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DeditdispoDepuis.Size = New System.Drawing.Size(127, 20)
        Me.DeditdispoDepuis.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(473, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Dispo. Depuis"
        '
        'cmbEtatComercial
        '
        Me.cmbEtatComercial.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_ETAT_COMMER", True))
        Me.cmbEtatComercial.Location = New System.Drawing.Point(552, 120)
        Me.cmbEtatComercial.Name = "cmbEtatComercial"
        Me.cmbEtatComercial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbEtatComercial.Properties.Items.AddRange(New Object() {"D", "S", "NC"})
        Me.cmbEtatComercial.Size = New System.Drawing.Size(127, 20)
        Me.cmbEtatComercial.TabIndex = 6
        '
        'lkPresHop
        '
        Me.lkPresHop.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_CDF_RH_CODE_FK", True))
        Me.lkPresHop.Location = New System.Drawing.Point(552, 94)
        Me.lkPresHop.Name = "lkPresHop"
        Me.lkPresHop.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkPresHop.Size = New System.Drawing.Size(127, 20)
        Me.lkPresHop.TabIndex = 5
        Me.lkPresHop.Tag = ""
        '
        'DeditApplication
        '
        Me.DeditApplication.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_DATE_APPLIFINCOLL", True))
        Me.DeditApplication.EditValue = Nothing
        Me.DeditApplication.Location = New System.Drawing.Point(176, 172)
        Me.DeditApplication.Name = "DeditApplication"
        Me.DeditApplication.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DeditApplication.Size = New System.Drawing.Size(129, 20)
        Me.DeditApplication.TabIndex = 4
        '
        'DeditRadiation
        '
        Me.DeditRadiation.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_DATEFINCOLL", True))
        Me.DeditRadiation.EditValue = Nothing
        Me.DeditRadiation.Location = New System.Drawing.Point(176, 145)
        Me.DeditRadiation.Name = "DeditRadiation"
        Me.DeditRadiation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DeditRadiation.Size = New System.Drawing.Size(129, 20)
        Me.DeditRadiation.TabIndex = 3
        '
        'DateEdit4
        '
        Me.DateEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_DATEJOCOLL", True))
        Me.DateEdit4.EditValue = Nothing
        Me.DateEdit4.Location = New System.Drawing.Point(176, 119)
        Me.DateEdit4.Name = "DateEdit4"
        Me.DateEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit4.Size = New System.Drawing.Size(129, 20)
        Me.DateEdit4.TabIndex = 2
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_AGRCOLL", True))
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(176, 94)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "O", "N"})
        Me.ComboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(129, 20)
        Me.ComboBoxEdit1.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(424, 97)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(122, 13)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Présentation hospitalière"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(446, 123)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 13)
        Me.Label19.TabIndex = 16
        Me.Label19.Text = "Etat de commercial."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(38, 123)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(134, 13)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Agrément collectivités date"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(113, 175)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 13)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Application"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(41, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(131, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Agrément collect. (O/N/E)"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(20, 148)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(152, 13)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Dates radiation collectivités JO"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(48, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(124, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Texte taux sécu. Sociale"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.Panel7)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(493, 417)
        Me.XtraTabPage4.Tag = "[ADD][EDIT]"
        Me.XtraTabPage4.Text = "Conservation"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.GC15)
        Me.Panel7.Controls.Add(Me.Label23)
        Me.Panel7.Controls.Add(Me.Panel2)
        Me.Panel7.Controls.Add(Me.GC13)
        Me.Panel7.Controls.Add(Me.GC12)
        Me.Panel7.Controls.Add(Me.Label22)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(493, 417)
        Me.Panel7.TabIndex = 39
        '
        'GC15
        '
        Me.GC15.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC15.DataMember = "PRECSVTX_TEXTE_CONSERV"
        Me.GC15.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC15.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC15.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC15.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC15.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC15.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC15.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC15.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC15.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC15.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC15.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC15.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC15.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC15.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC15.EmbeddedNavigator.Name = ""
        Me.GC15.EmbeddedNavigator.TextStringFormat = ""
        Me.GC15.Location = New System.Drawing.Point(6, 368)
        Me.GC15.MainView = Me.GV15
        Me.GC15.Name = "GC15"
        Me.GC15.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpMemoCons})
        Me.GC15.Size = New System.Drawing.Size(477, 49)
        Me.GC15.TabIndex = 3
        Me.GC15.UseEmbeddedNavigator = True
        Me.GC15.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV15})
        '
        'GV15
        '
        Me.GV15.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPRECSVTX_PRE_CODE_FK_PK, Me.colPRECSVTX_TEXTE})
        Me.GV15.GridControl = Me.GC15
        Me.GV15.GroupFormat = ""
        Me.GV15.GroupPanelText = " "
        Me.GV15.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GV15.Name = "GV15"
        Me.GV15.OptionsCustomization.AllowRowSizing = True
        Me.GV15.OptionsNavigation.AutoFocusNewRow = True
        Me.GV15.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV15.OptionsView.ShowColumnHeaders = False
        Me.GV15.OptionsView.ShowDetailButtons = False
        Me.GV15.OptionsView.ShowGroupPanel = False
        Me.GV15.OptionsView.ShowHorzLines = False
        Me.GV15.OptionsView.ShowIndicator = False
        Me.GV15.RowHeight = 42
        Me.GV15.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colPRECSVTX_PRE_CODE_FK_PK
        '
        Me.colPRECSVTX_PRE_CODE_FK_PK.Caption = "PRECSVTX_PRE_CODE_FK_PK"
        Me.colPRECSVTX_PRE_CODE_FK_PK.FieldName = "PRECSVTX_PRE_CODE_FK_PK"
        Me.colPRECSVTX_PRE_CODE_FK_PK.Name = "colPRECSVTX_PRE_CODE_FK_PK"
        '
        'colPRECSVTX_TEXTE
        '
        Me.colPRECSVTX_TEXTE.Caption = "PRECSVTX_TEXTE"
        Me.colPRECSVTX_TEXTE.ColumnEdit = Me.rpMemoCons
        Me.colPRECSVTX_TEXTE.FieldName = "PRECSVTX_TEXTE"
        Me.colPRECSVTX_TEXTE.Name = "colPRECSVTX_TEXTE"
        Me.colPRECSVTX_TEXTE.Visible = True
        Me.colPRECSVTX_TEXTE.VisibleIndex = 0
        '
        'rpMemoCons
        '
        Me.rpMemoCons.Name = "rpMemoCons"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(4, 350)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(113, 13)
        Me.Label23.TabIndex = 38
        Me.Label23.Text = "Texte de conservation"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.GC14)
        Me.Panel2.Location = New System.Drawing.Point(3, 231)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(487, 116)
        Me.Panel2.TabIndex = 37
        '
        'GC14
        '
        Me.GC14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC14.DataMember = "PREPER_PRESENTATION_PERIO_CSV.FK_PREPER_PRESENTATION_PERIO_CSV_PERCS_PERIODE_COND" & _
            "_CSV"
        Me.GC14.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC14.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC14.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC14.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC14.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC14.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC14.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC14.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC14.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC14.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC14.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC14.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC14.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC14.EmbeddedNavigator.Name = ""
        Me.GC14.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC14.Location = New System.Drawing.Point(3, 7)
        Me.GC14.MainView = Me.GV14
        Me.GC14.Name = "GC14"
        Me.GC14.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpCondition})
        Me.GC14.Size = New System.Drawing.Size(477, 100)
        Me.GC14.TabIndex = 2
        Me.GC14.UseEmbeddedNavigator = True
        Me.GC14.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV14})
        '
        'GV14
        '
        Me.GV14.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPERCS_NUM_CODE_PK, Me.colPERCS_PRE_CODE_FK_PK, Me.colPERCS_CDF_CSV_CODE_FK_PK, Me.colPERCS_NUMORD})
        Me.GV14.GridControl = Me.GC14
        Me.GV14.GroupPanelText = " "
        Me.GV14.Name = "GV14"
        Me.GV14.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV14.OptionsView.ShowGroupPanel = False
        Me.GV14.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPERCS_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colPERCS_NUM_CODE_PK
        '
        Me.colPERCS_NUM_CODE_PK.Caption = "PERCS_NUM_CODE_PK"
        Me.colPERCS_NUM_CODE_PK.FieldName = "PERCS_NUM_CODE_PK"
        Me.colPERCS_NUM_CODE_PK.Name = "colPERCS_NUM_CODE_PK"
        '
        'colPERCS_PRE_CODE_FK_PK
        '
        Me.colPERCS_PRE_CODE_FK_PK.Caption = "PERCS_PRE_CODE_FK_PK"
        Me.colPERCS_PRE_CODE_FK_PK.FieldName = "PERCS_PRE_CODE_FK_PK"
        Me.colPERCS_PRE_CODE_FK_PK.Name = "colPERCS_PRE_CODE_FK_PK"
        '
        'colPERCS_CDF_CSV_CODE_FK_PK
        '
        Me.colPERCS_CDF_CSV_CODE_FK_PK.Caption = "Condition de conservation"
        Me.colPERCS_CDF_CSV_CODE_FK_PK.ColumnEdit = Me.rpCondition
        Me.colPERCS_CDF_CSV_CODE_FK_PK.FieldName = "PERCS_CDF_CSV_CODE_FK_PK"
        Me.colPERCS_CDF_CSV_CODE_FK_PK.Name = "colPERCS_CDF_CSV_CODE_FK_PK"
        Me.colPERCS_CDF_CSV_CODE_FK_PK.Visible = True
        Me.colPERCS_CDF_CSV_CODE_FK_PK.VisibleIndex = 0
        Me.colPERCS_CDF_CSV_CODE_FK_PK.Width = 604
        '
        'rpCondition
        '
        Me.rpCondition.AutoHeight = False
        Me.rpCondition.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpCondition.Name = "rpCondition"
        '
        'colPERCS_NUMORD
        '
        Me.colPERCS_NUMORD.Caption = "N°"
        Me.colPERCS_NUMORD.FieldName = "PERCS_NUMORD"
        Me.colPERCS_NUMORD.Name = "colPERCS_NUMORD"
        Me.colPERCS_NUMORD.Visible = True
        Me.colPERCS_NUMORD.VisibleIndex = 1
        Me.colPERCS_NUMORD.Width = 59
        '
        'GC13
        '
        Me.GC13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC13.DataMember = "PREPER_PRESENTATION_PERIO_CSV"
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
        Me.GC13.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC13.Location = New System.Drawing.Point(6, 126)
        Me.GC13.MainView = Me.GV13
        Me.GC13.Name = "GC13"
        Me.GC13.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpDureeConsv})
        Me.GC13.Size = New System.Drawing.Size(477, 99)
        Me.GC13.TabIndex = 1
        Me.GC13.UseEmbeddedNavigator = True
        Me.GC13.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV13})
        '
        'GV13
        '
        Me.GV13.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPREPER_NUM_CODE_PK, Me.colPREPER_PRE_CODE_FK_PK, Me.colPREPER_CDF_UT_CODE_FK, Me.colPREPER_DUREE})
        Me.GV13.GridControl = Me.GC13
        Me.GV13.GroupPanelText = " "
        Me.GV13.Name = "GV13"
        Me.GV13.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV13.OptionsView.ShowDetailButtons = False
        Me.GV13.OptionsView.ShowGroupPanel = False
        '
        'colPREPER_NUM_CODE_PK
        '
        Me.colPREPER_NUM_CODE_PK.Caption = "Code"
        Me.colPREPER_NUM_CODE_PK.FieldName = "PREPER_NUM_CODE_PK"
        Me.colPREPER_NUM_CODE_PK.Name = "colPREPER_NUM_CODE_PK"
        Me.colPREPER_NUM_CODE_PK.Visible = True
        Me.colPREPER_NUM_CODE_PK.VisibleIndex = 0
        Me.colPREPER_NUM_CODE_PK.Width = 65
        '
        'colPREPER_PRE_CODE_FK_PK
        '
        Me.colPREPER_PRE_CODE_FK_PK.Caption = "PREPER_PRE_CODE_FK_PK"
        Me.colPREPER_PRE_CODE_FK_PK.FieldName = "PREPER_PRE_CODE_FK_PK"
        Me.colPREPER_PRE_CODE_FK_PK.Name = "colPREPER_PRE_CODE_FK_PK"
        Me.colPREPER_PRE_CODE_FK_PK.Width = 220
        '
        'colPREPER_CDF_UT_CODE_FK
        '
        Me.colPREPER_CDF_UT_CODE_FK.Caption = "Conservation : Durée de conservation"
        Me.colPREPER_CDF_UT_CODE_FK.ColumnEdit = Me.rpDureeConsv
        Me.colPREPER_CDF_UT_CODE_FK.FieldName = "PREPER_CDF_UT_CODE_FK"
        Me.colPREPER_CDF_UT_CODE_FK.Name = "colPREPER_CDF_UT_CODE_FK"
        Me.colPREPER_CDF_UT_CODE_FK.Visible = True
        Me.colPREPER_CDF_UT_CODE_FK.VisibleIndex = 1
        Me.colPREPER_CDF_UT_CODE_FK.Width = 480
        '
        'rpDureeConsv
        '
        Me.rpDureeConsv.AutoHeight = False
        Me.rpDureeConsv.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpDureeConsv.Name = "rpDureeConsv"
        '
        'colPREPER_DUREE
        '
        Me.colPREPER_DUREE.Caption = "Durée"
        Me.colPREPER_DUREE.FieldName = "PREPER_DUREE"
        Me.colPREPER_DUREE.Name = "colPREPER_DUREE"
        Me.colPREPER_DUREE.Visible = True
        Me.colPREPER_DUREE.VisibleIndex = 2
        Me.colPREPER_DUREE.Width = 167
        '
        'GC12
        '
        Me.GC12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC12.DataMember = "PRESTRTX_TEXTE_STAT_REMBOURST"
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
        Me.GC12.Location = New System.Drawing.Point(6, 20)
        Me.GC12.MainView = Me.GV12
        Me.GC12.Name = "GC12"
        Me.GC12.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpMemo})
        Me.GC12.Size = New System.Drawing.Size(477, 100)
        Me.GC12.TabIndex = 0
        Me.GC12.UseEmbeddedNavigator = True
        Me.GC12.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV12})
        '
        'GV12
        '
        Me.GV12.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPRESTRTX_PRE_CODE_FK_PK, Me.colPRESTRTX_TEXTE})
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
        Me.GV12.RowHeight = 73
        Me.GV12.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colPRESTRTX_PRE_CODE_FK_PK
        '
        Me.colPRESTRTX_PRE_CODE_FK_PK.Caption = "PRESTRTX_PRE_CODE_FK_PK"
        Me.colPRESTRTX_PRE_CODE_FK_PK.FieldName = "PRESTRTX_PRE_CODE_FK_PK"
        Me.colPRESTRTX_PRE_CODE_FK_PK.Name = "colPRESTRTX_PRE_CODE_FK_PK"
        '
        'colPRESTRTX_TEXTE
        '
        Me.colPRESTRTX_TEXTE.Caption = "PRESTRTX_TEXTE"
        Me.colPRESTRTX_TEXTE.ColumnEdit = Me.rpMemo
        Me.colPRESTRTX_TEXTE.FieldName = "PRESTRTX_TEXTE"
        Me.colPRESTRTX_TEXTE.Name = "colPRESTRTX_TEXTE"
        Me.colPRESTRTX_TEXTE.Visible = True
        Me.colPRESTRTX_TEXTE.VisibleIndex = 0
        '
        'rpMemo
        '
        Me.rpMemo.Name = "rpMemo"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(3, 4)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(124, 13)
        Me.Label22.TabIndex = 33
        Me.Label22.Text = "Texte de remboursement"
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.pan5)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(493, 417)
        Me.XtraTabPage5.Text = "Dispensation"
        '
        'pan5
        '
        Me.pan5.Controls.Add(Me.lkup_Liste)
        Me.pan5.Controls.Add(Me.Pan_Lieu_Commentaire)
        Me.pan5.Controls.Add(Me.btADDSMR)
        Me.pan5.Controls.Add(Me.GC19)
        Me.pan5.Controls.Add(Me.lkupEPH2)
        Me.pan5.Controls.Add(Me.lkupEPH)
        Me.pan5.Controls.Add(Me.Label27)
        Me.pan5.Controls.Add(Me.lkupATC2)
        Me.pan5.Controls.Add(Me.lkupATC)
        Me.pan5.Controls.Add(Me.Label28)
        Me.pan5.Controls.Add(Me.Label26)
        Me.pan5.Controls.Add(Me.GC18)
        Me.pan5.Controls.Add(Me.Label25)
        Me.pan5.Controls.Add(Me.TextEdit1)
        Me.pan5.Controls.Add(Me.Label24)
        Me.pan5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pan5.Location = New System.Drawing.Point(0, 0)
        Me.pan5.Name = "pan5"
        Me.pan5.Size = New System.Drawing.Size(493, 417)
        Me.pan5.TabIndex = 0
        '
        'lkup_Liste
        '
        Me.lkup_Liste.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkup_Liste.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_CDF_LI_CODE_FK", True))
        Me.lkup_Liste.Location = New System.Drawing.Point(114, 248)
        Me.lkup_Liste.Name = "lkup_Liste"
        Me.lkup_Liste.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_Liste.Size = New System.Drawing.Size(368, 20)
        Me.lkup_Liste.TabIndex = 52
        Me.lkup_Liste.Tag = "[NOADD][NOEDIT]"
        '
        'Pan_Lieu_Commentaire
        '
        Me.Pan_Lieu_Commentaire.Controls.Add(Me.GC17)
        Me.Pan_Lieu_Commentaire.Controls.Add(Me.GC16)
        Me.Pan_Lieu_Commentaire.Location = New System.Drawing.Point(12, 30)
        Me.Pan_Lieu_Commentaire.Name = "Pan_Lieu_Commentaire"
        Me.Pan_Lieu_Commentaire.Size = New System.Drawing.Size(671, 118)
        Me.Pan_Lieu_Commentaire.TabIndex = 51
        '
        'GC17
        '
        Me.GC17.DataMember = "PREDICO_COMMENT_DISPENSAT"
        Me.GC17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC17.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC17.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC17.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC17.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC17.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC17.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC17.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC17.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC17.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC17.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC17.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC17.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC17.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC17.EmbeddedNavigator.Name = ""
        Me.GC17.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC17.Location = New System.Drawing.Point(353, 0)
        Me.GC17.MainView = Me.GV17
        Me.GC17.Name = "GC17"
        Me.GC17.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpComDispo})
        Me.GC17.Size = New System.Drawing.Size(318, 118)
        Me.GC17.TabIndex = 2
        Me.GC17.UseEmbeddedNavigator = True
        Me.GC17.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV17})
        '
        'GV17
        '
        Me.GV17.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPREDICO_PRE_CODE_FK_PK, Me.colPREDICO_CDF_COM_CODE_FK_PK, Me.colPREDICO_NUMORD})
        Me.GV17.GridControl = Me.GC17
        Me.GV17.GroupPanelText = " "
        Me.GV17.Name = "GV17"
        Me.GV17.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV17.OptionsView.ShowDetailButtons = False
        Me.GV17.OptionsView.ShowGroupPanel = False
        Me.GV17.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPREDICO_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colPREDICO_PRE_CODE_FK_PK
        '
        Me.colPREDICO_PRE_CODE_FK_PK.Caption = "PREDICO_PRE_CODE_FK_PK"
        Me.colPREDICO_PRE_CODE_FK_PK.FieldName = "PREDICO_PRE_CODE_FK_PK"
        Me.colPREDICO_PRE_CODE_FK_PK.Name = "colPREDICO_PRE_CODE_FK_PK"
        '
        'colPREDICO_CDF_COM_CODE_FK_PK
        '
        Me.colPREDICO_CDF_COM_CODE_FK_PK.Caption = "Commentaires dispensation"
        Me.colPREDICO_CDF_COM_CODE_FK_PK.ColumnEdit = Me.rpComDispo
        Me.colPREDICO_CDF_COM_CODE_FK_PK.FieldName = "PREDICO_CDF_COM_CODE_FK_PK"
        Me.colPREDICO_CDF_COM_CODE_FK_PK.Name = "colPREDICO_CDF_COM_CODE_FK_PK"
        Me.colPREDICO_CDF_COM_CODE_FK_PK.Visible = True
        Me.colPREDICO_CDF_COM_CODE_FK_PK.VisibleIndex = 0
        Me.colPREDICO_CDF_COM_CODE_FK_PK.Width = 276
        '
        'rpComDispo
        '
        Me.rpComDispo.AutoHeight = False
        Me.rpComDispo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpComDispo.Name = "rpComDispo"
        '
        'colPREDICO_NUMORD
        '
        Me.colPREDICO_NUMORD.Caption = "N°"
        Me.colPREDICO_NUMORD.FieldName = "PREDICO_NUMORD"
        Me.colPREDICO_NUMORD.Name = "colPREDICO_NUMORD"
        Me.colPREDICO_NUMORD.Visible = True
        Me.colPREDICO_NUMORD.VisibleIndex = 1
        Me.colPREDICO_NUMORD.Width = 49
        '
        'GC16
        '
        Me.GC16.DataMember = "PREDILI_LIEU_DISPENSAT"
        Me.GC16.Dock = System.Windows.Forms.DockStyle.Left
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
        Me.GC16.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC16.Location = New System.Drawing.Point(0, 0)
        Me.GC16.MainView = Me.GV16
        Me.GC16.Name = "GC16"
        Me.GC16.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpPredili})
        Me.GC16.Size = New System.Drawing.Size(353, 118)
        Me.GC16.TabIndex = 1
        Me.GC16.UseEmbeddedNavigator = True
        Me.GC16.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV16})
        '
        'GV16
        '
        Me.GV16.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPREDILI_PRE_CODE_FK_PK, Me.colPREDILI_CDF_LIEU_CODE_FK_PK, Me.colPREDILI_NUMORD})
        Me.GV16.GridControl = Me.GC16
        Me.GV16.GroupPanelText = " "
        Me.GV16.Name = "GV16"
        Me.GV16.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV16.OptionsView.ShowDetailButtons = False
        Me.GV16.OptionsView.ShowGroupPanel = False
        Me.GV16.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPREDILI_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colPREDILI_PRE_CODE_FK_PK
        '
        Me.colPREDILI_PRE_CODE_FK_PK.Caption = "PREDILI_PRE_CODE_FK_PK"
        Me.colPREDILI_PRE_CODE_FK_PK.FieldName = "PREDILI_PRE_CODE_FK_PK"
        Me.colPREDILI_PRE_CODE_FK_PK.Name = "colPREDILI_PRE_CODE_FK_PK"
        '
        'colPREDILI_CDF_LIEU_CODE_FK_PK
        '
        Me.colPREDILI_CDF_LIEU_CODE_FK_PK.Caption = "Lieu de dispensation"
        Me.colPREDILI_CDF_LIEU_CODE_FK_PK.ColumnEdit = Me.rpPredili
        Me.colPREDILI_CDF_LIEU_CODE_FK_PK.FieldName = "PREDILI_CDF_LIEU_CODE_FK_PK"
        Me.colPREDILI_CDF_LIEU_CODE_FK_PK.Name = "colPREDILI_CDF_LIEU_CODE_FK_PK"
        Me.colPREDILI_CDF_LIEU_CODE_FK_PK.Visible = True
        Me.colPREDILI_CDF_LIEU_CODE_FK_PK.VisibleIndex = 0
        Me.colPREDILI_CDF_LIEU_CODE_FK_PK.Width = 282
        '
        'rpPredili
        '
        Me.rpPredili.AutoHeight = False
        Me.rpPredili.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpPredili.Name = "rpPredili"
        '
        'colPREDILI_NUMORD
        '
        Me.colPREDILI_NUMORD.Caption = "N°"
        Me.colPREDILI_NUMORD.FieldName = "PREDILI_NUMORD"
        Me.colPREDILI_NUMORD.Name = "colPREDILI_NUMORD"
        Me.colPREDILI_NUMORD.Visible = True
        Me.colPREDILI_NUMORD.VisibleIndex = 1
        Me.colPREDILI_NUMORD.Width = 38
        '
        'btADDSMR
        '
        Me.btADDSMR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btADDSMR.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btADDSMR.Location = New System.Drawing.Point(181, 389)
        Me.btADDSMR.Name = "btADDSMR"
        Me.btADDSMR.Size = New System.Drawing.Size(54, 20)
        Me.btADDSMR.TabIndex = 50
        Me.btADDSMR.Text = "..."
        '
        'GC19
        '
        Me.GC19.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC19.DataMember = "PRESMR_PRE_SMR_ATR"
        Me.GC19.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC19.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC19.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC19.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC19.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC19.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC19.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC19.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC19.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC19.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC19.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC19.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC19.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC19.EmbeddedNavigator.Name = ""
        Me.GC19.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC19.Location = New System.Drawing.Point(12, 324)
        Me.GC19.MainView = Me.GV19
        Me.GC19.Name = "GC19"
        Me.GC19.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpSMR})
        Me.GC19.Size = New System.Drawing.Size(471, 90)
        Me.GC19.TabIndex = 9
        Me.GC19.Tag = "[ADD][EDIT]"
        Me.GC19.UseEmbeddedNavigator = True
        Me.GC19.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV19})
        '
        'GV19
        '
        Me.GV19.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPRESMR_PRE_CODE_FK_PK, Me.colPRESMR_CDF_SMR_CODE_FK_PK, Me.colPRESMR_DATE_SMR_PK, Me.colPRESMR_ATR_CODE_FK_PK})
        Me.GV19.GridControl = Me.GC19
        Me.GV19.GroupPanelText = " "
        Me.GV19.Name = "GV19"
        Me.GV19.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV19.OptionsView.ShowDetailButtons = False
        Me.GV19.OptionsView.ShowGroupPanel = False
        '
        'colPRESMR_PRE_CODE_FK_PK
        '
        Me.colPRESMR_PRE_CODE_FK_PK.Caption = "PRESMR_PRE_CODE_FK_PK"
        Me.colPRESMR_PRE_CODE_FK_PK.FieldName = "PRESMR_PRE_CODE_FK_PK"
        Me.colPRESMR_PRE_CODE_FK_PK.Name = "colPRESMR_PRE_CODE_FK_PK"
        '
        'colPRESMR_CDF_SMR_CODE_FK_PK
        '
        Me.colPRESMR_CDF_SMR_CODE_FK_PK.Caption = "SMR"
        Me.colPRESMR_CDF_SMR_CODE_FK_PK.ColumnEdit = Me.rpSMR
        Me.colPRESMR_CDF_SMR_CODE_FK_PK.FieldName = "PRESMR_CDF_SMR_CODE_FK_PK"
        Me.colPRESMR_CDF_SMR_CODE_FK_PK.Name = "colPRESMR_CDF_SMR_CODE_FK_PK"
        Me.colPRESMR_CDF_SMR_CODE_FK_PK.Visible = True
        Me.colPRESMR_CDF_SMR_CODE_FK_PK.VisibleIndex = 0
        Me.colPRESMR_CDF_SMR_CODE_FK_PK.Width = 392
        '
        'rpSMR
        '
        Me.rpSMR.AutoHeight = False
        Me.rpSMR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpSMR.Name = "rpSMR"
        '
        'colPRESMR_DATE_SMR_PK
        '
        Me.colPRESMR_DATE_SMR_PK.Caption = "Date"
        Me.colPRESMR_DATE_SMR_PK.FieldName = "PRESMR_DATE_SMR_PK"
        Me.colPRESMR_DATE_SMR_PK.Name = "colPRESMR_DATE_SMR_PK"
        Me.colPRESMR_DATE_SMR_PK.Visible = True
        Me.colPRESMR_DATE_SMR_PK.VisibleIndex = 1
        Me.colPRESMR_DATE_SMR_PK.Width = 128
        '
        'colPRESMR_ATR_CODE_FK_PK
        '
        Me.colPRESMR_ATR_CODE_FK_PK.Caption = "Avis commission Trans."
        Me.colPRESMR_ATR_CODE_FK_PK.FieldName = "PRESMR_ATR_CODE_FK_PK"
        Me.colPRESMR_ATR_CODE_FK_PK.Name = "colPRESMR_ATR_CODE_FK_PK"
        Me.colPRESMR_ATR_CODE_FK_PK.Visible = True
        Me.colPRESMR_ATR_CODE_FK_PK.VisibleIndex = 2
        Me.colPRESMR_ATR_CODE_FK_PK.Width = 131
        '
        'lkupEPH2
        '
        Me.lkupEPH2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_CEPH_CODE_FK", True))
        Me.lkupEPH2.Location = New System.Drawing.Point(114, 299)
        Me.lkupEPH2.Name = "lkupEPH2"
        Me.lkupEPH2.Size = New System.Drawing.Size(76, 20)
        Me.lkupEPH2.TabIndex = 7
        Me.lkupEPH2.Tag = "[NOADD][NOEDIT]"
        '
        'lkupEPH
        '
        Me.lkupEPH.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkupEPH.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_CEPH_CODE_FK", True))
        Me.lkupEPH.Location = New System.Drawing.Point(196, 300)
        Me.lkupEPH.Name = "lkupEPH"
        Me.lkupEPH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupEPH.Size = New System.Drawing.Size(287, 20)
        Me.lkupEPH.TabIndex = 8
        Me.lkupEPH.Tag = "[NOADD][NOEDIT]"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(29, 302)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(77, 13)
        Me.Label27.TabIndex = 49
        Me.Label27.Text = "Classe Ephmra"
        '
        'lkupATC2
        '
        Me.lkupATC2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_CATC_CODE_FK", True))
        Me.lkupATC2.Location = New System.Drawing.Point(114, 273)
        Me.lkupATC2.Name = "lkupATC2"
        Me.lkupATC2.Size = New System.Drawing.Size(76, 20)
        Me.lkupATC2.TabIndex = 5
        Me.lkupATC2.Tag = "[NOADD][NOEDIT]"
        '
        'lkupATC
        '
        Me.lkupATC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkupATC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_CATC_CODE_FK", True))
        Me.lkupATC.Location = New System.Drawing.Point(196, 274)
        Me.lkupATC.Name = "lkupATC"
        Me.lkupATC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupATC.Size = New System.Drawing.Size(287, 20)
        Me.lkupATC.TabIndex = 6
        Me.lkupATC.Tag = "[NOADD][NOEDIT]"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(46, 278)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(62, 13)
        Me.Label28.TabIndex = 45
        Me.Label28.Text = "Classe ATC"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(77, 252)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(29, 13)
        Me.Label26.TabIndex = 43
        Me.Label26.Text = "Liste"
        '
        'GC18
        '
        Me.GC18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC18.DataMember = "PREDITX_TEXTE_DISPENSAT"
        Me.GC18.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC18.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC18.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC18.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC18.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC18.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC18.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC18.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC18.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC18.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC18.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC18.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC18.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC18.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC18.EmbeddedNavigator.Name = ""
        Me.GC18.EmbeddedNavigator.TextStringFormat = ""
        Me.GC18.Location = New System.Drawing.Point(12, 175)
        Me.GC18.MainView = Me.GV18
        Me.GC18.Name = "GC18"
        Me.GC18.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1})
        Me.GC18.Size = New System.Drawing.Size(471, 67)
        Me.GC18.TabIndex = 3
        Me.GC18.UseEmbeddedNavigator = True
        Me.GC18.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV18})
        '
        'GV18
        '
        Me.GV18.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPREDITX_PRE_CODE_FK_PK, Me.colPREDITX_TEXTE})
        Me.GV18.GridControl = Me.GC18
        Me.GV18.GroupFormat = ""
        Me.GV18.GroupPanelText = " "
        Me.GV18.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GV18.Name = "GV18"
        Me.GV18.OptionsCustomization.AllowRowSizing = True
        Me.GV18.OptionsNavigation.AutoFocusNewRow = True
        Me.GV18.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV18.OptionsView.ShowColumnHeaders = False
        Me.GV18.OptionsView.ShowDetailButtons = False
        Me.GV18.OptionsView.ShowGroupPanel = False
        Me.GV18.OptionsView.ShowHorzLines = False
        Me.GV18.OptionsView.ShowIndicator = False
        Me.GV18.RowHeight = 42
        Me.GV18.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colPREDITX_PRE_CODE_FK_PK
        '
        Me.colPREDITX_PRE_CODE_FK_PK.Caption = "PREDITX_PRE_CODE_FK_PK"
        Me.colPREDITX_PRE_CODE_FK_PK.FieldName = "PREDITX_PRE_CODE_FK_PK"
        Me.colPREDITX_PRE_CODE_FK_PK.Name = "colPREDITX_PRE_CODE_FK_PK"
        '
        'colPREDITX_TEXTE
        '
        Me.colPREDITX_TEXTE.Caption = "PREDITX_TEXTE"
        Me.colPREDITX_TEXTE.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colPREDITX_TEXTE.FieldName = "PREDITX_TEXTE"
        Me.colPREDITX_TEXTE.Name = "colPREDITX_TEXTE"
        Me.colPREDITX_TEXTE.Visible = True
        Me.colPREDITX_TEXTE.VisibleIndex = 0
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(10, 159)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(111, 13)
        Me.Label25.TabIndex = 40
        Me.Label25.Text = "Texte de dispensation"
        '
        'TextEdit1
        '
        Me.TextEdit1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_CONSAPOUV", True))
        Me.TextEdit1.Location = New System.Drawing.Point(181, 4)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(302, 20)
        Me.TextEdit1.TabIndex = 0
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(12, 8)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(163, 13)
        Me.Label24.TabIndex = 18
        Me.Label24.Text = "Après reconstitution ou ouverture"
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Controls.Add(Me.PanelControl2)
        Me.XtraTabPage6.Controls.Add(Me.gcPropDoc)
        Me.XtraTabPage6.Controls.Add(Me.PanelControl1)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(493, 417)
        Me.XtraTabPage6.Text = "Document"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Panel10)
        Me.PanelControl2.Controls.Add(Me.Panel9)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 31)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(493, 300)
        Me.PanelControl2.TabIndex = 8
        Me.PanelControl2.Text = "PanelControl2"
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.gcDocuments)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(2, 2)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(402, 296)
        Me.Panel10.TabIndex = 6
        '
        'gcDocuments
        '
        Me.gcDocuments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcDocuments.EmbeddedNavigator.Name = ""
        Me.gcDocuments.Location = New System.Drawing.Point(0, 0)
        Me.gcDocuments.MainView = Me.gvDocuments
        Me.gcDocuments.Name = "gcDocuments"
        Me.gcDocuments.Size = New System.Drawing.Size(402, 296)
        Me.gcDocuments.TabIndex = 3
        Me.gcDocuments.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDocuments})
        '
        'gvDocuments
        '
        Me.gvDocuments.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId1, Me.colPRE_CODE_PK, Me.colLibelle1, Me.colChemin1, Me.colDateInsertion})
        Me.gvDocuments.GridControl = Me.gcDocuments
        Me.gvDocuments.Name = "gvDocuments"
        '
        'colId1
        '
        Me.colId1.Caption = "Id"
        Me.colId1.FieldName = "DO_ID"
        Me.colId1.Name = "colId1"
        Me.colId1.OptionsColumn.ReadOnly = True
        '
        'colPRE_CODE_PK
        '
        Me.colPRE_CODE_PK.Caption = "PRE_CODE_PK"
        Me.colPRE_CODE_PK.FieldName = "PRE_CODE_PK"
        Me.colPRE_CODE_PK.Name = "colPRE_CODE_PK"
        '
        'colLibelle1
        '
        Me.colLibelle1.Caption = "Libelle"
        Me.colLibelle1.FieldName = "DO_Label"
        Me.colLibelle1.Name = "colLibelle1"
        Me.colLibelle1.Visible = True
        Me.colLibelle1.VisibleIndex = 0
        '
        'colChemin1
        '
        Me.colChemin1.Caption = "Chemin"
        Me.colChemin1.FieldName = "DO_Info1"
        Me.colChemin1.Name = "colChemin1"
        Me.colChemin1.Visible = True
        Me.colChemin1.VisibleIndex = 1
        '
        'colDateInsertion
        '
        Me.colDateInsertion.Caption = "DateInsertion"
        Me.colDateInsertion.FieldName = "DateInsertion"
        Me.colDateInsertion.Name = "colDateInsertion"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.bSupprimer)
        Me.Panel9.Controls.Add(Me.btnPartager)
        Me.Panel9.Controls.Add(Me.btAperçu)
        Me.Panel9.Controls.Add(Me.btnImporter)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(404, 2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(87, 296)
        Me.Panel9.TabIndex = 5
        '
        'bSupprimer
        '
        Me.bSupprimer.Location = New System.Drawing.Point(6, 133)
        Me.bSupprimer.Name = "bSupprimer"
        Me.bSupprimer.Size = New System.Drawing.Size(75, 23)
        Me.bSupprimer.TabIndex = 3
        Me.bSupprimer.Text = "Supprimer"
        '
        'btnPartager
        '
        Me.btnPartager.Location = New System.Drawing.Point(6, 88)
        Me.btnPartager.Name = "btnPartager"
        Me.btnPartager.Size = New System.Drawing.Size(75, 23)
        Me.btnPartager.TabIndex = 2
        Me.btnPartager.Text = "Partager"
        '
        'btAperçu
        '
        Me.btAperçu.Location = New System.Drawing.Point(6, 46)
        Me.btAperçu.Name = "btAperçu"
        Me.btAperçu.Size = New System.Drawing.Size(75, 23)
        Me.btAperçu.TabIndex = 1
        Me.btAperçu.Text = "Aperçu"
        '
        'btnImporter
        '
        Me.btnImporter.Enabled = False
        Me.btnImporter.Location = New System.Drawing.Point(6, 4)
        Me.btnImporter.Name = "btnImporter"
        Me.btnImporter.Size = New System.Drawing.Size(75, 23)
        Me.btnImporter.TabIndex = 0
        Me.btnImporter.Text = "Importer"
        '
        'gcPropDoc
        '
        Me.gcPropDoc.Controls.Add(Me.cmdAnnuler)
        Me.gcPropDoc.Controls.Add(Me.cmdOK)
        Me.gcPropDoc.Controls.Add(Me.LabelControl4)
        Me.gcPropDoc.Controls.Add(Me.LabelControl5)
        Me.gcPropDoc.Controls.Add(Me.meNote)
        Me.gcPropDoc.Controls.Add(Me.lueCategorie)
        Me.gcPropDoc.Controls.Add(Me.txtLibelle)
        Me.gcPropDoc.Controls.Add(Me.LabelControl6)
        Me.gcPropDoc.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gcPropDoc.Location = New System.Drawing.Point(0, 331)
        Me.gcPropDoc.Name = "gcPropDoc"
        Me.gcPropDoc.Size = New System.Drawing.Size(493, 86)
        Me.gcPropDoc.TabIndex = 9
        Me.gcPropDoc.Text = "Propriété document"
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
        'txtLibelle
        '
        Me.txtLibelle.Location = New System.Drawing.Point(49, 23)
        Me.txtLibelle.Name = "txtLibelle"
        Me.txtLibelle.Size = New System.Drawing.Size(246, 20)
        Me.txtLibelle.TabIndex = 1
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(5, 23)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "Libellé"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.bePath)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(493, 31)
        Me.PanelControl1.TabIndex = 7
        Me.PanelControl1.Text = "PanelControl1"
        '
        'bePath
        '
        Me.bePath.Location = New System.Drawing.Point(5, 5)
        Me.bePath.Name = "bePath"
        Me.bePath.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton("explorer", DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis), New DevExpress.XtraEditors.Controls.EditorButton("effacer", DevExpress.XtraEditors.Controls.ButtonPredefines.Minus)})
        Me.bePath.Size = New System.Drawing.Size(654, 20)
        Me.bePath.TabIndex = 4
        '
        'DateEdit3
        '
        Me.DateEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_DATEJOCIP", True))
        Me.DateEdit3.EditValue = Nothing
        Me.DateEdit3.Location = New System.Drawing.Point(598, 5)
        Me.DateEdit3.Name = "DateEdit3"
        Me.DateEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit3.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit3.TabIndex = 2
        Me.DateEdit3.Tag = "[ADD][EDIT]"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(490, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Tag = "[ADD][EDIT]"
        Me.Label5.Text = "Date d’octroi de JO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(276, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Tag = "[ADD][EDIT]"
        Me.Label3.Text = "Code EAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Tag = "[ADD][EDIT]"
        Me.Label2.Text = "N° CIP"
        '
        'txtEAN
        '
        Me.txtEAN.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_EAN_REF", True))
        Me.txtEAN.Location = New System.Drawing.Point(339, 4)
        Me.txtEAN.Name = "txtEAN"
        Me.txtEAN.Size = New System.Drawing.Size(119, 20)
        Me.txtEAN.TabIndex = 1
        Me.txtEAN.Tag = "[ADD][EDIT]"
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "PRE_PRESENTATION.PRE_CODE_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(90, 3)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Properties.MaxLength = 7
        Me.txtCode.Size = New System.Drawing.Size(135, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Tag = "[ADD][NOEDIT]"
        '
        'PredisP_TA
        '
        Me.PredisP_TA.ClearBeforeFill = True
        '
        'PrE_TA
        '
        Me.PrE_TA.ClearBeforeFill = True
        '
        'SP_TA
        '
        Me.SP_TA.ClearBeforeFill = True
        '
        'PreucD_TA
        '
        Me.PreucD_TA.ClearBeforeFill = True
        '
        'CoconT_TA
        '
        Me.CoconT_TA.ClearBeforeFill = True
        '
        'PreconT_TA
        '
        Me.PreconT_TA.ClearBeforeFill = True
        '
        'PremaT_TA
        '
        Me.PremaT_TA.ClearBeforeFill = True
        '
        'PrecaR_TA
        '
        Me.PrecaR_TA.ClearBeforeFill = True
        '
        'PrecemB_TA
        '
        Me.PrecemB_TA.ClearBeforeFill = True
        '
        'PretsS_TA
        '
        Me.PretsS_TA.ClearBeforeFill = True
        '
        'ForprE_TA
        '
        Me.ForprE_TA.ClearBeforeFill = True
        '
        'PriprE_TA
        '
        Me.PriprE_TA.ClearBeforeFill = True
        '
        'PretssH_TA
        '
        Me.PretssH_TA.ClearBeforeFill = True
        '
        'PrestP_TA
        '
        Me.PrestP_TA.ClearBeforeFill = True
        '
        'PrestC_TA
        '
        Me.PrestC_TA.ClearBeforeFill = True
        '
        'PrestR_TA
        '
        Me.PrestR_TA.ClearBeforeFill = True
        '
        'PrestrtX_TA
        '
        Me.PrestrtX_TA.ClearBeforeFill = True
        '
        'PrepeR_TA
        '
        Me.PrepeR_TA.ClearBeforeFill = True
        '
        'PercS_TA
        '
        Me.PercS_TA.ClearBeforeFill = True
        '
        'PrecsvtX_TA
        '
        Me.PrecsvtX_TA.ClearBeforeFill = True
        '
        'PredilI_TA
        '
        Me.PredilI_TA.ClearBeforeFill = True
        '
        'PredicO_TA
        '
        Me.PredicO_TA.ClearBeforeFill = True
        '
        'PreditX_TA
        '
        Me.PreditX_TA.ClearBeforeFill = True
        '
        'PresmR_TA
        '
        Me.PresmR_TA.ClearBeforeFill = True
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.BtSupprim)
        Me.Panel16.Controls.Add(Me.btPartager)
        Me.Panel16.Controls.Add(Me.btApercu)
        Me.Panel16.Controls.Add(Me.btImporter)
        Me.Panel16.Location = New System.Drawing.Point(549, 35)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(108, 374)
        Me.Panel16.TabIndex = 2
        '
        'BtSupprim
        '
        Me.BtSupprim.Location = New System.Drawing.Point(21, 162)
        Me.BtSupprim.Name = "BtSupprim"
        Me.BtSupprim.Size = New System.Drawing.Size(75, 23)
        Me.BtSupprim.TabIndex = 3
        Me.BtSupprim.Text = "Supprimer"
        '
        'btPartager
        '
        Me.btPartager.Location = New System.Drawing.Point(21, 117)
        Me.btPartager.Name = "btPartager"
        Me.btPartager.Size = New System.Drawing.Size(75, 23)
        Me.btPartager.TabIndex = 2
        Me.btPartager.Text = "Partager"
        '
        'btApercu
        '
        Me.btApercu.Location = New System.Drawing.Point(21, 75)
        Me.btApercu.Name = "btApercu"
        Me.btApercu.Size = New System.Drawing.Size(75, 23)
        Me.btApercu.TabIndex = 1
        Me.btApercu.Text = "Aperçu"
        '
        'btImporter
        '
        Me.btImporter.Enabled = False
        Me.btImporter.Location = New System.Drawing.Point(21, 33)
        Me.btImporter.Name = "btImporter"
        Me.btImporter.Size = New System.Drawing.Size(75, 23)
        Me.btImporter.TabIndex = 0
        Me.btImporter.Text = "Importer"
        '
        'Panel15
        '
        Me.Panel15.Location = New System.Drawing.Point(3, 35)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(540, 377)
        Me.Panel15.TabIndex = 1
        '
        'colLibelle
        '
        Me.colLibelle.Caption = "Libellé"
        Me.colLibelle.FieldName = "Libelle"
        Me.colLibelle.Name = "colLibelle"
        Me.colLibelle.OptionsColumn.AllowEdit = False
        Me.colLibelle.Visible = True
        Me.colLibelle.VisibleIndex = 0
        '
        'colChemin
        '
        Me.colChemin.Caption = "Chemin"
        Me.colChemin.FieldName = "Chemin"
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
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        '
        'beChemin
        '
        Me.beChemin.Location = New System.Drawing.Point(3, 9)
        Me.beChemin.Name = "beChemin"
        Me.beChemin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton("explorer", DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis), New DevExpress.XtraEditors.Controls.EditorButton("effacer", DevExpress.XtraEditors.Controls.ButtonPredefines.Minus)})
        Me.beChemin.Size = New System.Drawing.Size(654, 20)
        Me.beChemin.TabIndex = 0
        '
        'Precpss_TA
        '
        Me.Precpss_TA.ClearBeforeFill = True
        '
        'Frm_Presentation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(914, 624)
        Me.Name = "Frm_Presentation"
        Me.Text = "Présentation"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanMain3.ResumeLayout(False)
        Me.PanMain3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.lkupSP2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_Nomenclature2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupSP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.GC5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpCrtCmpl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpMat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        CType(Me.GC3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpTexte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpNBCont, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpContenuReel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpContPossible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpSubACT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpUnite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpCommentaire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupCont, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupUCD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupPrise.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNBPrise.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.PanMain4.ResumeLayout(False)
        Me.PanMain4.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        CType(Me.GC20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpCDF_CODIF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupPresentationUnitaire.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.GC8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpTauxSociale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpMemoEditHop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpTauxRBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpMemoEditVille, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpCractEmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.PanMain5.ResumeLayout(False)
        Me.PanMain5.PerformLayout()
        CType(Me.MemoEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpStatutR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpStatutC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpStatut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeditSupp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeditdispoDepuis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbEtatComercial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkPresHop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeditApplication.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeditRadiation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.GC15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpMemoCons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GC14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpCondition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpDureeConsv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpMemo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage5.ResumeLayout(False)
        Me.pan5.ResumeLayout(False)
        Me.pan5.PerformLayout()
        CType(Me.lkup_Liste.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pan_Lieu_Commentaire.ResumeLayout(False)
        CType(Me.GC17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpComDispo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpPredili, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpSMR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupEPH2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupEPH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupATC2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupATC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage6.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        CType(Me.gcDocuments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDocuments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        CType(Me.gcPropDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcPropDoc.ResumeLayout(False)
        Me.gcPropDoc.PerformLayout()
        CType(Me.meNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCategorie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.bePath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEAN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel16.ResumeLayout(False)
        CType(Me.beChemin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanMain3 As System.Windows.Forms.Panel
    Friend WithEvents DateEdit3 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lkupSP As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEAN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNBPrise As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lkupPrise As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanMain4 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GC6 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btPrix As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GC8 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC7 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanMain5 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DsTheriaque_Nomenclature2 As Theriaque.dsTheriaque_Nomenclature2
    Friend WithEvents PredisP_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.PREDISP_PRE_DISPENSATIONTableAdapter
    Friend WithEvents PrE_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRE_PRESENTATIONTableAdapter
    Friend WithEvents SP_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.SP_SPECIALITETableAdapter
    Friend WithEvents lkupUCD As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkupSP2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents colPREDISP_PRE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREDISP_NUMSEQ_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREDISP_SAC_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREDISP_UNITEDISP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREDISP_CDF_UD_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpUnite As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rpSubACT As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PreucD_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.PREUCD_COMMENT_DOSEUCDTableAdapter
    Friend WithEvents colPREUCD_PRE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREUCD_CDF_COMUCD_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpCommentaire As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colPREUCD_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CoconT_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.COCONT_COMPO_CONTENANTTableAdapter
    Friend WithEvents colCOCONT_PRE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOCONT_NUM_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOCONT_CDF_GAL_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOCONT_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PreconT_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRECONT_PRE_CONTENANTTableAdapter
    Friend WithEvents colPRECONT_PRE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRECONT_COCONT_NUM_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRECONT_NBCONTENANT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRECONT_CDF_COCDT_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRECONT_NBCONTENANT_REEL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRECONT_NBCONTENANCE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRECONT_CDF_COCE_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRECONT_VOLCONTENANT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRECONT_CDF_VOLCONT_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpNBCont As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rpContenuReel As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rpContPossible As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colPREMAT_PRE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREMAT_COCONT_NUM_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREMAT_CDF_MACDT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREMAT_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PremaT_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.PREMAT_PRE_MATERIAUTableAdapter
    Friend WithEvents rpMat As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colPRECAR_PRE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRECAR_COCONT_NUM_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRECAR_CDF_CODE_CACDT_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRECAR_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpCrtCmpl As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PrecaR_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRECAR_PRESENTATION_CARACTCOMPTableAdapter
    Friend WithEvents lkupCont As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PrecemB_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRECEMB_PRE_CAREMBALLAGETableAdapter
    Friend WithEvents colPRECEMB_PRE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRECEMB_CDF_CAREMB_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRECEMB_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpCractEmb As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lkupPresentationUnitaire As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PretsS_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRETSS_PRESENTATION_TAUXTableAdapter
    Friend WithEvents rpTauxRBS As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colPRETSS_PRE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRETSS_CDF_TSS_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRETSS_NUMSEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRETSS_DATE_APPLI_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRETSS_DATE_APPLIQUEE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRETSS_TEXTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ForprE_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.FORPRE_FORFAIT_PRETableAdapter
    Friend WithEvents PriprE_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRIPRE_PRIX_PRESENTATIONTableAdapter
    Friend WithEvents colPRETSSH_PRE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRETSSH_CDF_TSS_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRETSSH_NUMSEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRETSSH_DATE_APPLI_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRETSSH_DATE_APPLIQUEE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRETSSH_TEXTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PretssH_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRETSSH_PRE_TAUX_HOPTableAdapter
    Friend WithEvents rpTauxSociale As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lkPresHop As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DeditApplication As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DeditRadiation As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit4 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DeditSupp As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents DeditdispoDepuis As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbEtatComercial As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GC9 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPRESTP_PRE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRESTP_CDF_STP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRESTP_DATE_AFSSAPS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRESTP_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrestP_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRESTP_PRE_STPTableAdapter
    Friend WithEvents rpStatut As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PrestC_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRESTC_STATUTCOMP_PRESENTTableAdapter
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GC10 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPRESTC_PRE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRESTC_CDF_STCOMP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpStatutC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colPRESTC_CODE_IDENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRESTC_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GC11 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rpStatutR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colPRESTR_PRE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRESTR_CDF_STR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRESTR_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrestR_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRESTR_STATUT_REMBOURSTTableAdapter
    Friend WithEvents MemoEdit2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GC12 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents rpMemo As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents PrestrtX_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRESTRTX_TEXTE_STAT_REMBOURSTTableAdapter
    Friend WithEvents colPRESTRTX_PRE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRESTRTX_TEXTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GC14 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPERCS_NUM_CODE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPERCS_PRE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPERCS_CDF_CSV_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPERCS_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpCondition As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC13 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPREPER_NUM_CODE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREPER_PRE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREPER_CDF_UT_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREPER_DUREE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpDureeConsv As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PrepeR_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.PREPER_PRESENTATION_PERIO_CSVTableAdapter
    Friend WithEvents PercS_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.PERCS_PERIODE_COND_CSVTableAdapter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GC15 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV15 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rpMemoCons As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents colPRECSVTX_PRE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRECSVTX_TEXTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrecsvtX_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRECSVTX_TEXTE_CONSERVTableAdapter
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pan5 As System.Windows.Forms.Panel
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents PredilI_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.PREDILI_LIEU_DISPENSATTableAdapter
    Friend WithEvents GC16 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV16 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rpPredili As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colPREDILI_PRE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREDILI_CDF_LIEU_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREDILI_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GC17 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV17 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPREDICO_PRE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREDICO_CDF_COM_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREDICO_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpComDispo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PredicO_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.PREDICO_COMMENT_DISPENSATTableAdapter
    Friend WithEvents GC18 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV18 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lkupATC As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents colPREDITX_PRE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREDITX_TEXTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PreditX_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.PREDITX_TEXTE_DISPENSATTableAdapter
    Friend WithEvents lkupATC2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkupEPH2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkupEPH As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents GC19 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV19 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rpSMR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colPRESMR_PRE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRESMR_CDF_SMR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRESMR_DATE_SMR_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRESMR_ATR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PresmR_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRESMR_PRE_SMR_ATRTableAdapter
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btADDSMR As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Pan_Lieu_Commentaire As System.Windows.Forms.Panel
    Friend WithEvents rpTexte As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents MemoEdit3 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lkup_Liste As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents BtSupprim As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btPartager As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btApercu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btImporter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel15 As System.Windows.Forms.Panel

    Friend WithEvents colLibelle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChemin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents beChemin As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents bSupprimer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPartager As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btAperçu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImporter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bePath As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents gcDocuments As DevExpress.XtraGrid.GridControl
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents gvDocuments As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRE_CODE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLibelle1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChemin1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateInsertion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcPropDoc As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents meNote As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lueCategorie As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtLibelle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAnnuler As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RpMemoEditVille As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RpMemoEditHop As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents GC20 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV20 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ColPRECPSS_PRE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCDF_NOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpCDF_CODIF As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Precpss_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRECPSSTableAdapter

End Class
