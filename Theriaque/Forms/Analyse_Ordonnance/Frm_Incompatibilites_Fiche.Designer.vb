<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Incompatibilites_Fiche
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
        Me.FiC_TA = New Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.FIC_INCOMPATIBILITETableAdapter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbOrigine = New DevExpress.XtraEditors.ComboBoxEdit
        Me.DsTheriaque_AnalyseOrdonance2 = New Theriaque.dsTheriaque_AnalyseOrdonance2
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.ComboBoxEdit2 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GC13 = New DevExpress.XtraGrid.GridControl
        Me.GV13 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIC1PR_FIC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIC1PR_PR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IC1PR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC14 = New DevExpress.XtraGrid.GridControl
        Me.GV14 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIC1SP_FIC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIC1SP_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Spécialité1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IC1SP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GC11 = New DevExpress.XtraGrid.GridControl
        Me.GV11 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIC1SAC_FIC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIC1SAC_SAC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IC1SAC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC12 = New DevExpress.XtraGrid.GridControl
        Me.GV12 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIC1SAU_FIC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIC1SAU_SAU_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IC1SAU = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.GC23 = New DevExpress.XtraGrid.GridControl
        Me.GV23 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIC2PR_FIC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIC2PR_PR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IC2PR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC24 = New DevExpress.XtraGrid.GridControl
        Me.GV24 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIC2SP_FIC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIC2SP_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IC2SP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.GC21 = New DevExpress.XtraGrid.GridControl
        Me.GV21 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIC2SAC_FIC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIC2SAC_SAC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IC2SAC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC22 = New DevExpress.XtraGrid.GridControl
        Me.GV22 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIC2SAU_FIC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIC2SAU_SAU_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IC2SAU = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.GC36 = New DevExpress.XtraGrid.GridControl
        Me.GV36 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colICMA_FIC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colICMA_CDF_MAIC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_ICMA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC37 = New DevExpress.XtraGrid.GridControl
        Me.GV37 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colICCO_FIC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colICCO_CDF_COIC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_ICCO = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.GC34 = New DevExpress.XtraGrid.GridControl
        Me.GV34 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colICCT2_FIC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colICCT2_NUMSEQ_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colICCT2_CONCENTRATION2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colICCT2_CDF_UDOSE_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colICCT2_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_ICCT2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC35 = New DevExpress.XtraGrid.GridControl
        Me.GV35 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIC2VE_FIC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIC2VE_CDF_VEIC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IC2VE = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.GC32 = New DevExpress.XtraGrid.GridControl
        Me.GV32 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colICCT1_FIC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colICCT1_NUMSEQ_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colICCT1_CONCENTRATION1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colICCT1_CDF_UDOSE_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colICCT1_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_ICCT1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC33 = New DevExpress.XtraGrid.GridControl
        Me.GV33 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIC1VE_FIC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIC1VE_CDF_VEIC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_IC1VE = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.GC31 = New DevExpress.XtraGrid.GridControl
        Me.GV31 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colICSOL_FIC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colICSOL_CDF_SOLIC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_ICSOL = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.GC43 = New DevExpress.XtraGrid.GridControl
        Me.GV43 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colICTMP_FIC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colICTMP_CDF_TEMP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colICTMP_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_ICTMP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC44 = New DevExpress.XtraGrid.GridControl
        Me.GV44 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colICLUM_FIC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colICLUM_CDF_LUM_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colICLUM_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_ICLUM = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.GC41 = New DevExpress.XtraGrid.GridControl
        Me.GV41 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colICNA_FIC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colICNA_CDF_NAIC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colICNA_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_ICNA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC42 = New DevExpress.XtraGrid.GridControl
        Me.GV42 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colICDUR_FIC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colICDUR_CDF_DUR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colICDUR_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_ICDUR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.IC1SAC_TA = New Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.IC1SAC_TERME1SUBACTTableAdapter
        Me.IC1SAU_TA = New Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.IC1SAU_TERME1SUBAUXTableAdapter
        Me.IC1PR_TA = New Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.IC1PR_TERME1PRODUITTableAdapter
        Me.IC1SP_TA = New Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.IC1SP_TERME1SPECIALITETableAdapter
        Me.IC2PR_TA = New Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.IC2PR_TERME2PRODUITTableAdapter
        Me.IC2SAC_TA = New Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.IC2SAC_TERME2SUBACTTableAdapter
        Me.IC2SAU_TA = New Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.IC2SAU_TERME2SUBAUXTableAdapter
        Me.IC2SP_TA = New Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.IC2SP_TERME2SPECIALITETableAdapter
        Me.IcsoL_TA = New Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.ICSOL_INCOMPATIBILITE_SOLUTIONTableAdapter
        Me.IccT1_TA = New Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.ICCT1_CONCENTRATION1TableAdapter
        Me.IC1VE_TA = New Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.IC1VE_INCOMPATIBILITE_VECTEUR1TableAdapter
        Me.IccT2_TA = New Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.ICCT2_CONCENTRATION2TableAdapter
        Me.IC2VE_TA = New Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.IC2VE_INCOMPATIBILITE_VECTEUR2TableAdapter
        Me.IccO_TA = New Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.ICCO_INCOMPATIBILITE_CONTENANTTableAdapter
        Me.IcmA_TA = New Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.ICMA_INCOMPATIBILITE_MATERIAUTableAdapter
        Me.IcnA_TA = New Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.ICNA_INCOMPATIBILITE_NATURETableAdapter
        Me.IcduR_TA = New Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.ICDUR_INCOMPATIBILITE_DUREETableAdapter
        Me.IcluM_TA = New Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.ICLUM_INCOMPATIBILITE_LUMIERETableAdapter
        Me.IctmP_TA = New Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.ICTMP_INCOMPA_TEMPERATURETableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmbOrigine.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_AnalyseOrdonance2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GC13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IC1PR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IC1SP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.GC11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IC1SAC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IC1SAU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.GC23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IC2PR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IC2SP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.GC21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IC2SAC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IC2SAU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.GC36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_ICMA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_ICCO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.GC34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_ICCT2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IC2VE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.GC32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_ICCT1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IC1VE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.GC31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_ICSOL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel14.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.GC43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_ICTMP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_ICLUM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        CType(Me.GC41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_ICNA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_ICDUR, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Text = "(In)compatibilités - Fiche"
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
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_AnalyseOrdonance2, "FIC_INCOMPATIBILITE.FIC_DATEMJ", True))
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
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_AnalyseOrdonance2, "FIC_INCOMPATIBILITE.FIC_DATECR", True))
        Me.DateEdit2.EditValue = Nothing
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
        'FiC_TA
        '
        Me.FiC_TA.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmbOrigine)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.ComboBoxEdit2)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(652, 65)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cmbOrigine
        '
        Me.cmbOrigine.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_AnalyseOrdonance2, "FIC_INCOMPATIBILITE.FIC_ORIGINE", True))
        Me.cmbOrigine.EditValue = ""
        Me.cmbOrigine.Location = New System.Drawing.Point(373, 12)
        Me.cmbOrigine.Name = "cmbOrigine"
        Me.cmbOrigine.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbOrigine.Properties.Items.AddRange(New Object() {"Trissel", "Extrapolation Trissel", "RCP", "Extrapolation RCP", "Autre source"})
        Me.cmbOrigine.Size = New System.Drawing.Size(173, 20)
        Me.cmbOrigine.TabIndex = 2
        Me.cmbOrigine.Tag = "[EDIT][ADD]"
        '
        'DsTheriaque_AnalyseOrdonance2
        '
        Me.DsTheriaque_AnalyseOrdonance2.DataSetName = "dsTheriaque_AnalyseOrdonance2"
        Me.DsTheriaque_AnalyseOrdonance2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(287, 43)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl5.TabIndex = 3
        Me.LabelControl5.Text = "Comp. / Incomp."
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(333, 15)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl4.TabIndex = 1
        Me.LabelControl4.Text = "Origine"
        '
        'ComboBoxEdit2
        '
        Me.ComboBoxEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_AnalyseOrdonance2, "FIC_INCOMPATIBILITE.FIC_TYPE", True))
        Me.ComboBoxEdit2.EditValue = ""
        Me.ComboBoxEdit2.Location = New System.Drawing.Point(373, 39)
        Me.ComboBoxEdit2.Name = "ComboBoxEdit2"
        Me.ComboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit2.Properties.Items.AddRange(New Object() {"C", "I"})
        Me.ComboBoxEdit2.Size = New System.Drawing.Size(61, 20)
        Me.ComboBoxEdit2.TabIndex = 4
        Me.ComboBoxEdit2.Tag = "[EDIT][ADD]"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(42, 17)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Fiche N°"
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_AnalyseOrdonance2, "FIC_INCOMPATIBILITE.FIC_CODE_SQ_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(88, 13)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(135, 20)
        Me.txtCode.TabIndex = 1
        Me.txtCode.Tag = "[NOEDIT][NOADD]"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Location = New System.Drawing.Point(3, 67)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(656, 420)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panel3)
        Me.XtraTabPage1.Controls.Add(Me.Panel2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(647, 389)
        Me.XtraTabPage1.Text = "Terme1"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GC13)
        Me.Panel3.Controls.Add(Me.GC14)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 172)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(647, 217)
        Me.Panel3.TabIndex = 8
        '
        'GC13
        '
        Me.GC13.DataMember = "IC1PR_TERME1PRODUIT"
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
        Me.GC13.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_IC1PR})
        Me.GC13.Size = New System.Drawing.Size(321, 217)
        Me.GC13.TabIndex = 5
        Me.GC13.Tag = "[EDIT][ADD]"
        Me.GC13.UseEmbeddedNavigator = True
        Me.GC13.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV13})
        '
        'GV13
        '
        Me.GV13.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIC1PR_FIC_CODE_FK_PK, Me.colIC1PR_PR_CODE_FK_PK, Me.GridColumn3})
        Me.GV13.GridControl = Me.GC13
        Me.GV13.Name = "GV13"
        Me.GV13.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV13.OptionsView.ShowGroupPanel = False
        '
        'colIC1PR_FIC_CODE_FK_PK
        '
        Me.colIC1PR_FIC_CODE_FK_PK.Caption = "IC1PR_FIC_CODE_FK_PK"
        Me.colIC1PR_FIC_CODE_FK_PK.FieldName = "IC1PR_FIC_CODE_FK_PK"
        Me.colIC1PR_FIC_CODE_FK_PK.Name = "colIC1PR_FIC_CODE_FK_PK"
        '
        'colIC1PR_PR_CODE_FK_PK
        '
        Me.colIC1PR_PR_CODE_FK_PK.Caption = "Code"
        Me.colIC1PR_PR_CODE_FK_PK.FieldName = "IC1PR_PR_CODE_FK_PK"
        Me.colIC1PR_PR_CODE_FK_PK.Name = "colIC1PR_PR_CODE_FK_PK"
        Me.colIC1PR_PR_CODE_FK_PK.Visible = True
        Me.colIC1PR_PR_CODE_FK_PK.VisibleIndex = 0
        Me.colIC1PR_PR_CODE_FK_PK.Width = 55
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Produit1"
        Me.GridColumn3.ColumnEdit = Me.lkup_IC1PR
        Me.GridColumn3.FieldName = "IC1PR_PR_CODE_FK_PK"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 245
        '
        'lkup_IC1PR
        '
        Me.lkup_IC1PR.AutoHeight = False
        Me.lkup_IC1PR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IC1PR.Name = "lkup_IC1PR"
        '
        'GC14
        '
        Me.GC14.DataMember = "IC1SP_TERME1SPECIALITE"
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
        Me.GC14.Location = New System.Drawing.Point(321, 0)
        Me.GC14.MainView = Me.GV14
        Me.GC14.Name = "GC14"
        Me.GC14.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_IC1SP})
        Me.GC14.Size = New System.Drawing.Size(326, 217)
        Me.GC14.TabIndex = 6
        Me.GC14.Tag = "[EDIT][ADD]"
        Me.GC14.UseEmbeddedNavigator = True
        Me.GC14.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV14})
        '
        'GV14
        '
        Me.GV14.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIC1SP_FIC_CODE_FK_PK, Me.colIC1SP_SP_CODE_FK_PK, Me.Spécialité1})
        Me.GV14.GridControl = Me.GC14
        Me.GV14.Name = "GV14"
        Me.GV14.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV14.OptionsView.ShowGroupPanel = False
        '
        'colIC1SP_FIC_CODE_FK_PK
        '
        Me.colIC1SP_FIC_CODE_FK_PK.Caption = "IC1SP_FIC_CODE_FK_PK"
        Me.colIC1SP_FIC_CODE_FK_PK.FieldName = "IC1SP_FIC_CODE_FK_PK"
        Me.colIC1SP_FIC_CODE_FK_PK.Name = "colIC1SP_FIC_CODE_FK_PK"
        '
        'colIC1SP_SP_CODE_FK_PK
        '
        Me.colIC1SP_SP_CODE_FK_PK.Caption = "Code"
        Me.colIC1SP_SP_CODE_FK_PK.FieldName = "IC1SP_SP_CODE_FK_PK"
        Me.colIC1SP_SP_CODE_FK_PK.Name = "colIC1SP_SP_CODE_FK_PK"
        Me.colIC1SP_SP_CODE_FK_PK.Visible = True
        Me.colIC1SP_SP_CODE_FK_PK.VisibleIndex = 0
        Me.colIC1SP_SP_CODE_FK_PK.Width = 53
        '
        'Spécialité1
        '
        Me.Spécialité1.Caption = "Spécialité1"
        Me.Spécialité1.ColumnEdit = Me.lkup_IC1SP
        Me.Spécialité1.FieldName = "IC1SP_SP_CODE_FK_PK"
        Me.Spécialité1.Name = "Spécialité1"
        Me.Spécialité1.Visible = True
        Me.Spécialité1.VisibleIndex = 1
        Me.Spécialité1.Width = 252
        '
        'lkup_IC1SP
        '
        Me.lkup_IC1SP.AutoHeight = False
        Me.lkup_IC1SP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IC1SP.Name = "lkup_IC1SP"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GC11)
        Me.Panel2.Controls.Add(Me.GC12)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(647, 172)
        Me.Panel2.TabIndex = 7
        '
        'GC11
        '
        Me.GC11.DataMember = "IC1SAC_TERME1SUBACT"
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
        Me.GC11.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_IC1SAC})
        Me.GC11.Size = New System.Drawing.Size(321, 172)
        Me.GC11.TabIndex = 3
        Me.GC11.Tag = "[EDIT][ADD]"
        Me.GC11.UseEmbeddedNavigator = True
        Me.GC11.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV11})
        '
        'GV11
        '
        Me.GV11.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIC1SAC_FIC_CODE_FK_PK, Me.colIC1SAC_SAC_CODE_FK_PK, Me.GridColumn1})
        Me.GV11.GridControl = Me.GC11
        Me.GV11.Name = "GV11"
        Me.GV11.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV11.OptionsView.ShowGroupPanel = False
        '
        'colIC1SAC_FIC_CODE_FK_PK
        '
        Me.colIC1SAC_FIC_CODE_FK_PK.Caption = "IC1SAC_FIC_CODE_FK_PK"
        Me.colIC1SAC_FIC_CODE_FK_PK.FieldName = "IC1SAC_FIC_CODE_FK_PK"
        Me.colIC1SAC_FIC_CODE_FK_PK.Name = "colIC1SAC_FIC_CODE_FK_PK"
        '
        'colIC1SAC_SAC_CODE_FK_PK
        '
        Me.colIC1SAC_SAC_CODE_FK_PK.Caption = "Code"
        Me.colIC1SAC_SAC_CODE_FK_PK.FieldName = "IC1SAC_SAC_CODE_FK_PK"
        Me.colIC1SAC_SAC_CODE_FK_PK.Name = "colIC1SAC_SAC_CODE_FK_PK"
        Me.colIC1SAC_SAC_CODE_FK_PK.Visible = True
        Me.colIC1SAC_SAC_CODE_FK_PK.VisibleIndex = 0
        Me.colIC1SAC_SAC_CODE_FK_PK.Width = 53
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Substance active1"
        Me.GridColumn1.ColumnEdit = Me.lkup_IC1SAC
        Me.GridColumn1.FieldName = "IC1SAC_SAC_CODE_FK_PK"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 247
        '
        'lkup_IC1SAC
        '
        Me.lkup_IC1SAC.AutoHeight = False
        Me.lkup_IC1SAC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IC1SAC.Name = "lkup_IC1SAC"
        Me.lkup_IC1SAC.NullText = ""
        '
        'GC12
        '
        Me.GC12.DataMember = "IC1SAU_TERME1SUBAUX"
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
        Me.GC12.Location = New System.Drawing.Point(321, 0)
        Me.GC12.MainView = Me.GV12
        Me.GC12.Name = "GC12"
        Me.GC12.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_IC1SAU})
        Me.GC12.Size = New System.Drawing.Size(326, 172)
        Me.GC12.TabIndex = 4
        Me.GC12.Tag = "[EDIT][ADD]"
        Me.GC12.UseEmbeddedNavigator = True
        Me.GC12.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV12})
        '
        'GV12
        '
        Me.GV12.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIC1SAU_FIC_CODE_FK_PK, Me.colIC1SAU_SAU_CODE_FK_PK, Me.GridColumn2})
        Me.GV12.GridControl = Me.GC12
        Me.GV12.Name = "GV12"
        Me.GV12.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV12.OptionsView.ShowGroupPanel = False
        '
        'colIC1SAU_FIC_CODE_FK_PK
        '
        Me.colIC1SAU_FIC_CODE_FK_PK.Caption = "IC1SAU_FIC_CODE_FK_PK"
        Me.colIC1SAU_FIC_CODE_FK_PK.FieldName = "IC1SAU_FIC_CODE_FK_PK"
        Me.colIC1SAU_FIC_CODE_FK_PK.Name = "colIC1SAU_FIC_CODE_FK_PK"
        '
        'colIC1SAU_SAU_CODE_FK_PK
        '
        Me.colIC1SAU_SAU_CODE_FK_PK.Caption = "Code"
        Me.colIC1SAU_SAU_CODE_FK_PK.FieldName = "IC1SAU_SAU_CODE_FK_PK"
        Me.colIC1SAU_SAU_CODE_FK_PK.Name = "colIC1SAU_SAU_CODE_FK_PK"
        Me.colIC1SAU_SAU_CODE_FK_PK.Visible = True
        Me.colIC1SAU_SAU_CODE_FK_PK.VisibleIndex = 0
        Me.colIC1SAU_SAU_CODE_FK_PK.Width = 56
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Excipient1"
        Me.GridColumn2.ColumnEdit = Me.lkup_IC1SAU
        Me.GridColumn2.FieldName = "IC1SAU_SAU_CODE_FK_PK"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 249
        '
        'lkup_IC1SAU
        '
        Me.lkup_IC1SAU.AutoHeight = False
        Me.lkup_IC1SAU.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IC1SAU.Name = "lkup_IC1SAU"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Panel5)
        Me.XtraTabPage2.Controls.Add(Me.Panel4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(497, 381)
        Me.XtraTabPage2.Text = "Terme2"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GC23)
        Me.Panel5.Controls.Add(Me.GC24)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 172)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(497, 209)
        Me.Panel5.TabIndex = 9
        '
        'GC23
        '
        Me.GC23.DataMember = "IC2PR_TERME2PRODUIT"
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
        Me.GC23.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_IC2PR})
        Me.GC23.Size = New System.Drawing.Size(171, 209)
        Me.GC23.TabIndex = 5
        Me.GC23.Tag = "[EDIT][ADD]"
        Me.GC23.UseEmbeddedNavigator = True
        Me.GC23.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV23})
        '
        'GV23
        '
        Me.GV23.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIC2PR_FIC_CODE_FK_PK, Me.colIC2PR_PR_CODE_FK_PK, Me.GridColumn6})
        Me.GV23.GridControl = Me.GC23
        Me.GV23.Name = "GV23"
        Me.GV23.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV23.OptionsView.ShowGroupPanel = False
        '
        'colIC2PR_FIC_CODE_FK_PK
        '
        Me.colIC2PR_FIC_CODE_FK_PK.Caption = "IC2PR_FIC_CODE_FK_PK"
        Me.colIC2PR_FIC_CODE_FK_PK.FieldName = "IC2PR_FIC_CODE_FK_PK"
        Me.colIC2PR_FIC_CODE_FK_PK.Name = "colIC2PR_FIC_CODE_FK_PK"
        '
        'colIC2PR_PR_CODE_FK_PK
        '
        Me.colIC2PR_PR_CODE_FK_PK.Caption = "Code"
        Me.colIC2PR_PR_CODE_FK_PK.FieldName = "IC2PR_PR_CODE_FK_PK"
        Me.colIC2PR_PR_CODE_FK_PK.Name = "colIC2PR_PR_CODE_FK_PK"
        Me.colIC2PR_PR_CODE_FK_PK.Visible = True
        Me.colIC2PR_PR_CODE_FK_PK.VisibleIndex = 0
        Me.colIC2PR_PR_CODE_FK_PK.Width = 50
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Produit2"
        Me.GridColumn6.ColumnEdit = Me.lkup_IC2PR
        Me.GridColumn6.FieldName = "IC2PR_PR_CODE_FK_PK"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        Me.GridColumn6.Width = 250
        '
        'lkup_IC2PR
        '
        Me.lkup_IC2PR.AutoHeight = False
        Me.lkup_IC2PR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IC2PR.Name = "lkup_IC2PR"
        '
        'GC24
        '
        Me.GC24.DataMember = "IC2SP_TERME2SPECIALITE"
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
        Me.GC24.Location = New System.Drawing.Point(171, 0)
        Me.GC24.MainView = Me.GV24
        Me.GC24.Name = "GC24"
        Me.GC24.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_IC2SP})
        Me.GC24.Size = New System.Drawing.Size(326, 209)
        Me.GC24.TabIndex = 6
        Me.GC24.Tag = "[EDIT][ADD]"
        Me.GC24.UseEmbeddedNavigator = True
        Me.GC24.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV24})
        '
        'GV24
        '
        Me.GV24.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIC2SP_FIC_CODE_FK_PK, Me.colIC2SP_SP_CODE_FK_PK, Me.GridColumn7})
        Me.GV24.GridControl = Me.GC24
        Me.GV24.Name = "GV24"
        Me.GV24.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV24.OptionsView.ShowGroupPanel = False
        '
        'colIC2SP_FIC_CODE_FK_PK
        '
        Me.colIC2SP_FIC_CODE_FK_PK.Caption = "IC2SP_FIC_CODE_FK_PK"
        Me.colIC2SP_FIC_CODE_FK_PK.FieldName = "IC2SP_FIC_CODE_FK_PK"
        Me.colIC2SP_FIC_CODE_FK_PK.Name = "colIC2SP_FIC_CODE_FK_PK"
        '
        'colIC2SP_SP_CODE_FK_PK
        '
        Me.colIC2SP_SP_CODE_FK_PK.Caption = "Code"
        Me.colIC2SP_SP_CODE_FK_PK.FieldName = "IC2SP_SP_CODE_FK_PK"
        Me.colIC2SP_SP_CODE_FK_PK.Name = "colIC2SP_SP_CODE_FK_PK"
        Me.colIC2SP_SP_CODE_FK_PK.Visible = True
        Me.colIC2SP_SP_CODE_FK_PK.VisibleIndex = 0
        Me.colIC2SP_SP_CODE_FK_PK.Width = 50
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Spécialité2"
        Me.GridColumn7.ColumnEdit = Me.lkup_IC2SP
        Me.GridColumn7.FieldName = "IC2SP_SP_CODE_FK_PK"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        Me.GridColumn7.Width = 255
        '
        'lkup_IC2SP
        '
        Me.lkup_IC2SP.AutoHeight = False
        Me.lkup_IC2SP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IC2SP.Name = "lkup_IC2SP"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GC21)
        Me.Panel4.Controls.Add(Me.GC22)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(497, 172)
        Me.Panel4.TabIndex = 8
        '
        'GC21
        '
        Me.GC21.DataMember = "IC2SAC_TERME2SUBACT"
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
        Me.GC21.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_IC2SAC})
        Me.GC21.Size = New System.Drawing.Size(171, 172)
        Me.GC21.TabIndex = 3
        Me.GC21.Tag = "[EDIT][ADD]"
        Me.GC21.UseEmbeddedNavigator = True
        Me.GC21.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV21})
        '
        'GV21
        '
        Me.GV21.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIC2SAC_FIC_CODE_FK_PK, Me.colIC2SAC_SAC_CODE_FK_PK, Me.GridColumn4})
        Me.GV21.GridControl = Me.GC21
        Me.GV21.Name = "GV21"
        Me.GV21.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV21.OptionsView.ShowGroupPanel = False
        '
        'colIC2SAC_FIC_CODE_FK_PK
        '
        Me.colIC2SAC_FIC_CODE_FK_PK.Caption = "IC2SAC_FIC_CODE_FK_PK"
        Me.colIC2SAC_FIC_CODE_FK_PK.FieldName = "IC2SAC_FIC_CODE_FK_PK"
        Me.colIC2SAC_FIC_CODE_FK_PK.Name = "colIC2SAC_FIC_CODE_FK_PK"
        '
        'colIC2SAC_SAC_CODE_FK_PK
        '
        Me.colIC2SAC_SAC_CODE_FK_PK.Caption = "Code"
        Me.colIC2SAC_SAC_CODE_FK_PK.FieldName = "IC2SAC_SAC_CODE_FK_PK"
        Me.colIC2SAC_SAC_CODE_FK_PK.Name = "colIC2SAC_SAC_CODE_FK_PK"
        Me.colIC2SAC_SAC_CODE_FK_PK.Visible = True
        Me.colIC2SAC_SAC_CODE_FK_PK.VisibleIndex = 0
        Me.colIC2SAC_SAC_CODE_FK_PK.Width = 50
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Substance active2"
        Me.GridColumn4.ColumnEdit = Me.lkup_IC2SAC
        Me.GridColumn4.FieldName = "IC2SAC_SAC_CODE_FK_PK"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 250
        '
        'lkup_IC2SAC
        '
        Me.lkup_IC2SAC.AutoHeight = False
        Me.lkup_IC2SAC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IC2SAC.Name = "lkup_IC2SAC"
        '
        'GC22
        '
        Me.GC22.DataMember = "IC2SAU_TERME2SUBAUX"
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
        Me.GC22.Location = New System.Drawing.Point(171, 0)
        Me.GC22.MainView = Me.GV22
        Me.GC22.Name = "GC22"
        Me.GC22.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_IC2SAU})
        Me.GC22.Size = New System.Drawing.Size(326, 172)
        Me.GC22.TabIndex = 4
        Me.GC22.Tag = "[EDIT][ADD]"
        Me.GC22.UseEmbeddedNavigator = True
        Me.GC22.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV22})
        '
        'GV22
        '
        Me.GV22.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIC2SAU_FIC_CODE_FK_PK, Me.colIC2SAU_SAU_CODE_FK_PK, Me.GridColumn5})
        Me.GV22.GridControl = Me.GC22
        Me.GV22.Name = "GV22"
        Me.GV22.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV22.OptionsView.ShowGroupPanel = False
        '
        'colIC2SAU_FIC_CODE_FK_PK
        '
        Me.colIC2SAU_FIC_CODE_FK_PK.Caption = "IC2SAU_FIC_CODE_FK_PK"
        Me.colIC2SAU_FIC_CODE_FK_PK.FieldName = "IC2SAU_FIC_CODE_FK_PK"
        Me.colIC2SAU_FIC_CODE_FK_PK.Name = "colIC2SAU_FIC_CODE_FK_PK"
        '
        'colIC2SAU_SAU_CODE_FK_PK
        '
        Me.colIC2SAU_SAU_CODE_FK_PK.Caption = "Code"
        Me.colIC2SAU_SAU_CODE_FK_PK.FieldName = "IC2SAU_SAU_CODE_FK_PK"
        Me.colIC2SAU_SAU_CODE_FK_PK.Name = "colIC2SAU_SAU_CODE_FK_PK"
        Me.colIC2SAU_SAU_CODE_FK_PK.Visible = True
        Me.colIC2SAU_SAU_CODE_FK_PK.VisibleIndex = 0
        Me.colIC2SAU_SAU_CODE_FK_PK.Width = 50
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Excipient2"
        Me.GridColumn5.ColumnEdit = Me.lkup_IC2SAU
        Me.GridColumn5.FieldName = "IC2SAU_SAU_CODE_FK_PK"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 255
        '
        'lkup_IC2SAU
        '
        Me.lkup_IC2SAU.AutoHeight = False
        Me.lkup_IC2SAU.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IC2SAU.Name = "lkup_IC2SAU"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.Panel9)
        Me.XtraTabPage3.Controls.Add(Me.Panel7)
        Me.XtraTabPage3.Controls.Add(Me.Panel6)
        Me.XtraTabPage3.Controls.Add(Me.Panel8)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(497, 381)
        Me.XtraTabPage3.Text = "Solution 1/2"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.GC36)
        Me.Panel9.Controls.Add(Me.GC37)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(0, 286)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(497, 95)
        Me.Panel9.TabIndex = 23
        '
        'GC36
        '
        Me.GC36.DataMember = "ICMA_INCOMPATIBILITE_MATERIAU"
        Me.GC36.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC36.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC36.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC36.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC36.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC36.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC36.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC36.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC36.EmbeddedNavigator.Name = ""
        Me.GC36.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC36.Location = New System.Drawing.Point(0, 0)
        Me.GC36.MainView = Me.GV36
        Me.GC36.Name = "GC36"
        Me.GC36.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_ICMA})
        Me.GC36.Size = New System.Drawing.Size(194, 95)
        Me.GC36.TabIndex = 11
        Me.GC36.Tag = "[EDIT][ADD]"
        Me.GC36.UseEmbeddedNavigator = True
        Me.GC36.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV36})
        '
        'GV36
        '
        Me.GV36.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colICMA_FIC_CODE_FK_PK, Me.colICMA_CDF_MAIC_CODE_FK_PK, Me.GridColumn13})
        Me.GV36.GridControl = Me.GC36
        Me.GV36.Name = "GV36"
        Me.GV36.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV36.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV36.OptionsView.ShowGroupPanel = False
        '
        'colICMA_FIC_CODE_FK_PK
        '
        Me.colICMA_FIC_CODE_FK_PK.Caption = "ICMA_FIC_CODE_FK_PK"
        Me.colICMA_FIC_CODE_FK_PK.FieldName = "ICMA_FIC_CODE_FK_PK"
        Me.colICMA_FIC_CODE_FK_PK.Name = "colICMA_FIC_CODE_FK_PK"
        '
        'colICMA_CDF_MAIC_CODE_FK_PK
        '
        Me.colICMA_CDF_MAIC_CODE_FK_PK.Caption = "ICMA_CDF_MAIC_CODE_FK_PK"
        Me.colICMA_CDF_MAIC_CODE_FK_PK.FieldName = "ICMA_CDF_MAIC_CODE_FK_PK"
        Me.colICMA_CDF_MAIC_CODE_FK_PK.Name = "colICMA_CDF_MAIC_CODE_FK_PK"
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Matériau"
        Me.GridColumn13.ColumnEdit = Me.lkup_ICMA
        Me.GridColumn13.FieldName = "ICMA_CDF_MAIC_CODE_FK_PK"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 0
        '
        'lkup_ICMA
        '
        Me.lkup_ICMA.AutoHeight = False
        Me.lkup_ICMA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_ICMA.Name = "lkup_ICMA"
        '
        'GC37
        '
        Me.GC37.DataMember = "ICCO_INCOMPATIBILITE_CONTENANT"
        Me.GC37.Dock = System.Windows.Forms.DockStyle.Right
        Me.GC37.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC37.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC37.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC37.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC37.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC37.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC37.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC37.EmbeddedNavigator.Name = ""
        Me.GC37.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC37.Location = New System.Drawing.Point(194, 0)
        Me.GC37.MainView = Me.GV37
        Me.GC37.Name = "GC37"
        Me.GC37.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_ICCO})
        Me.GC37.Size = New System.Drawing.Size(303, 95)
        Me.GC37.TabIndex = 13
        Me.GC37.Tag = "[EDIT][ADD]"
        Me.GC37.UseEmbeddedNavigator = True
        Me.GC37.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV37})
        '
        'GV37
        '
        Me.GV37.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colICCO_FIC_CODE_FK_PK, Me.colICCO_CDF_COIC_CODE_FK_PK, Me.GridColumn14})
        Me.GV37.GridControl = Me.GC37
        Me.GV37.Name = "GV37"
        Me.GV37.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV37.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV37.OptionsView.ShowGroupPanel = False
        '
        'colICCO_FIC_CODE_FK_PK
        '
        Me.colICCO_FIC_CODE_FK_PK.Caption = "ICCO_FIC_CODE_FK_PK"
        Me.colICCO_FIC_CODE_FK_PK.FieldName = "ICCO_FIC_CODE_FK_PK"
        Me.colICCO_FIC_CODE_FK_PK.Name = "colICCO_FIC_CODE_FK_PK"
        '
        'colICCO_CDF_COIC_CODE_FK_PK
        '
        Me.colICCO_CDF_COIC_CODE_FK_PK.Caption = "ICCO_CDF_COIC_CODE_FK_PK"
        Me.colICCO_CDF_COIC_CODE_FK_PK.FieldName = "ICCO_CDF_COIC_CODE_FK_PK"
        Me.colICCO_CDF_COIC_CODE_FK_PK.Name = "colICCO_CDF_COIC_CODE_FK_PK"
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Contenant"
        Me.GridColumn14.ColumnEdit = Me.lkup_ICCO
        Me.GridColumn14.FieldName = "ICCO_CDF_COIC_CODE_FK_PK"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 0
        '
        'lkup_ICCO
        '
        Me.lkup_ICCO.AutoHeight = False
        Me.lkup_ICCO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_ICCO.Name = "lkup_ICCO"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.GC34)
        Me.Panel7.Controls.Add(Me.GC35)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 187)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(497, 99)
        Me.Panel7.TabIndex = 22
        '
        'GC34
        '
        Me.GC34.DataMember = "ICCT2_CONCENTRATION2"
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
        Me.GC34.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_ICCT2})
        Me.GC34.Size = New System.Drawing.Size(194, 99)
        Me.GC34.TabIndex = 11
        Me.GC34.Tag = "[EDIT][ADD]"
        Me.GC34.UseEmbeddedNavigator = True
        Me.GC34.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV34})
        '
        'GV34
        '
        Me.GV34.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colICCT2_FIC_CODE_FK_PK, Me.colICCT2_NUMSEQ_PK, Me.colICCT2_CONCENTRATION2, Me.colICCT2_CDF_UDOSE_CODE_FK, Me.colICCT2_NUMORD, Me.GridColumn11})
        Me.GV34.GridControl = Me.GC34
        Me.GV34.Name = "GV34"
        Me.GV34.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV34.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV34.OptionsView.ShowGroupPanel = False
        Me.GV34.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colICCT2_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colICCT2_FIC_CODE_FK_PK
        '
        Me.colICCT2_FIC_CODE_FK_PK.Caption = "ICCT2_FIC_CODE_FK_PK"
        Me.colICCT2_FIC_CODE_FK_PK.FieldName = "ICCT2_FIC_CODE_FK_PK"
        Me.colICCT2_FIC_CODE_FK_PK.Name = "colICCT2_FIC_CODE_FK_PK"
        '
        'colICCT2_NUMSEQ_PK
        '
        Me.colICCT2_NUMSEQ_PK.Caption = "ICCT2_NUMSEQ_PK"
        Me.colICCT2_NUMSEQ_PK.FieldName = "ICCT2_NUMSEQ_PK"
        Me.colICCT2_NUMSEQ_PK.Name = "colICCT2_NUMSEQ_PK"
        '
        'colICCT2_CONCENTRATION2
        '
        Me.colICCT2_CONCENTRATION2.Caption = "Valeur"
        Me.colICCT2_CONCENTRATION2.FieldName = "ICCT2_CONCENTRATION2"
        Me.colICCT2_CONCENTRATION2.Name = "colICCT2_CONCENTRATION2"
        Me.colICCT2_CONCENTRATION2.Visible = True
        Me.colICCT2_CONCENTRATION2.VisibleIndex = 0
        Me.colICCT2_CONCENTRATION2.Width = 50
        '
        'colICCT2_CDF_UDOSE_CODE_FK
        '
        Me.colICCT2_CDF_UDOSE_CODE_FK.Caption = "ICCT2_CDF_UDOSE_CODE_FK"
        Me.colICCT2_CDF_UDOSE_CODE_FK.FieldName = "ICCT2_CDF_UDOSE_CODE_FK"
        Me.colICCT2_CDF_UDOSE_CODE_FK.Name = "colICCT2_CDF_UDOSE_CODE_FK"
        '
        'colICCT2_NUMORD
        '
        Me.colICCT2_NUMORD.Caption = "N°"
        Me.colICCT2_NUMORD.FieldName = "ICCT2_NUMORD"
        Me.colICCT2_NUMORD.Name = "colICCT2_NUMORD"
        Me.colICCT2_NUMORD.Visible = True
        Me.colICCT2_NUMORD.VisibleIndex = 2
        Me.colICCT2_NUMORD.Width = 50
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Concentration2"
        Me.GridColumn11.ColumnEdit = Me.lkup_ICCT2
        Me.GridColumn11.FieldName = "ICCT2_CDF_UDOSE_CODE_FK"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 1
        Me.GridColumn11.Width = 221
        '
        'lkup_ICCT2
        '
        Me.lkup_ICCT2.AutoHeight = False
        Me.lkup_ICCT2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_ICCT2.Name = "lkup_ICCT2"
        '
        'GC35
        '
        Me.GC35.DataMember = "IC2VE_INCOMPATIBILITE_VECTEUR2"
        Me.GC35.Dock = System.Windows.Forms.DockStyle.Right
        Me.GC35.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC35.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC35.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC35.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC35.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC35.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC35.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC35.EmbeddedNavigator.Name = ""
        Me.GC35.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC35.Location = New System.Drawing.Point(194, 0)
        Me.GC35.MainView = Me.GV35
        Me.GC35.Name = "GC35"
        Me.GC35.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_IC2VE})
        Me.GC35.Size = New System.Drawing.Size(303, 99)
        Me.GC35.TabIndex = 13
        Me.GC35.Tag = "[EDIT][ADD]"
        Me.GC35.UseEmbeddedNavigator = True
        Me.GC35.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV35})
        '
        'GV35
        '
        Me.GV35.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIC2VE_FIC_CODE_FK_PK, Me.colIC2VE_CDF_VEIC_CODE_FK_PK, Me.GridColumn12})
        Me.GV35.GridControl = Me.GC35
        Me.GV35.Name = "GV35"
        Me.GV35.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV35.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV35.OptionsView.ShowGroupPanel = False
        '
        'colIC2VE_FIC_CODE_FK_PK
        '
        Me.colIC2VE_FIC_CODE_FK_PK.Caption = "IC2VE_FIC_CODE_FK_PK"
        Me.colIC2VE_FIC_CODE_FK_PK.FieldName = "IC2VE_FIC_CODE_FK_PK"
        Me.colIC2VE_FIC_CODE_FK_PK.Name = "colIC2VE_FIC_CODE_FK_PK"
        '
        'colIC2VE_CDF_VEIC_CODE_FK_PK
        '
        Me.colIC2VE_CDF_VEIC_CODE_FK_PK.Caption = "IC2VE_CDF_VEIC_CODE_FK_PK"
        Me.colIC2VE_CDF_VEIC_CODE_FK_PK.FieldName = "IC2VE_CDF_VEIC_CODE_FK_PK"
        Me.colIC2VE_CDF_VEIC_CODE_FK_PK.Name = "colIC2VE_CDF_VEIC_CODE_FK_PK"
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Vecteur2"
        Me.GridColumn12.ColumnEdit = Me.lkup_IC2VE
        Me.GridColumn12.FieldName = "IC2VE_CDF_VEIC_CODE_FK_PK"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 0
        '
        'lkup_IC2VE
        '
        Me.lkup_IC2VE.AutoHeight = False
        Me.lkup_IC2VE.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IC2VE.Name = "lkup_IC2VE"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GC32)
        Me.Panel6.Controls.Add(Me.GC33)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 88)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(497, 99)
        Me.Panel6.TabIndex = 21
        '
        'GC32
        '
        Me.GC32.DataMember = "ICCT1_CONCENTRATION1"
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
        Me.GC32.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_ICCT1})
        Me.GC32.Size = New System.Drawing.Size(194, 99)
        Me.GC32.TabIndex = 2
        Me.GC32.Tag = "[EDIT][ADD]"
        Me.GC32.UseEmbeddedNavigator = True
        Me.GC32.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV32})
        '
        'GV32
        '
        Me.GV32.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colICCT1_FIC_CODE_FK_PK, Me.colICCT1_NUMSEQ_PK, Me.colICCT1_CONCENTRATION1, Me.colICCT1_CDF_UDOSE_CODE_FK, Me.colICCT1_NUMORD, Me.GridColumn9})
        Me.GV32.GridControl = Me.GC32
        Me.GV32.Name = "GV32"
        Me.GV32.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV32.OptionsView.ShowGroupPanel = False
        Me.GV32.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colICCT1_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colICCT1_FIC_CODE_FK_PK
        '
        Me.colICCT1_FIC_CODE_FK_PK.Caption = "ICCT1_FIC_CODE_FK_PK"
        Me.colICCT1_FIC_CODE_FK_PK.FieldName = "ICCT1_FIC_CODE_FK_PK"
        Me.colICCT1_FIC_CODE_FK_PK.Name = "colICCT1_FIC_CODE_FK_PK"
        '
        'colICCT1_NUMSEQ_PK
        '
        Me.colICCT1_NUMSEQ_PK.Caption = "ICCT1_NUMSEQ_PK"
        Me.colICCT1_NUMSEQ_PK.FieldName = "ICCT1_NUMSEQ_PK"
        Me.colICCT1_NUMSEQ_PK.Name = "colICCT1_NUMSEQ_PK"
        '
        'colICCT1_CONCENTRATION1
        '
        Me.colICCT1_CONCENTRATION1.Caption = "Valeur"
        Me.colICCT1_CONCENTRATION1.FieldName = "ICCT1_CONCENTRATION1"
        Me.colICCT1_CONCENTRATION1.Name = "colICCT1_CONCENTRATION1"
        Me.colICCT1_CONCENTRATION1.Visible = True
        Me.colICCT1_CONCENTRATION1.VisibleIndex = 0
        Me.colICCT1_CONCENTRATION1.Width = 50
        '
        'colICCT1_CDF_UDOSE_CODE_FK
        '
        Me.colICCT1_CDF_UDOSE_CODE_FK.Caption = "ICCT1_CDF_UDOSE_CODE_FK"
        Me.colICCT1_CDF_UDOSE_CODE_FK.FieldName = "ICCT1_CDF_UDOSE_CODE_FK"
        Me.colICCT1_CDF_UDOSE_CODE_FK.Name = "colICCT1_CDF_UDOSE_CODE_FK"
        '
        'colICCT1_NUMORD
        '
        Me.colICCT1_NUMORD.Caption = "N°"
        Me.colICCT1_NUMORD.FieldName = "ICCT1_NUMORD"
        Me.colICCT1_NUMORD.Name = "colICCT1_NUMORD"
        Me.colICCT1_NUMORD.Visible = True
        Me.colICCT1_NUMORD.VisibleIndex = 2
        Me.colICCT1_NUMORD.Width = 50
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Concentration1"
        Me.GridColumn9.ColumnEdit = Me.lkup_ICCT1
        Me.GridColumn9.FieldName = "ICCT1_CDF_UDOSE_CODE_FK"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 1
        Me.GridColumn9.Width = 221
        '
        'lkup_ICCT1
        '
        Me.lkup_ICCT1.AutoHeight = False
        Me.lkup_ICCT1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_ICCT1.Name = "lkup_ICCT1"
        '
        'GC33
        '
        Me.GC33.DataMember = "IC1VE_INCOMPATIBILITE_VECTEUR1"
        Me.GC33.Dock = System.Windows.Forms.DockStyle.Right
        Me.GC33.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC33.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC33.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC33.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC33.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC33.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC33.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC33.EmbeddedNavigator.Name = ""
        Me.GC33.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC33.Location = New System.Drawing.Point(194, 0)
        Me.GC33.MainView = Me.GV33
        Me.GC33.Name = "GC33"
        Me.GC33.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_IC1VE})
        Me.GC33.Size = New System.Drawing.Size(303, 99)
        Me.GC33.TabIndex = 3
        Me.GC33.Tag = "[EDIT][ADD]"
        Me.GC33.UseEmbeddedNavigator = True
        Me.GC33.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV33})
        '
        'GV33
        '
        Me.GV33.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIC1VE_FIC_CODE_FK_PK, Me.colIC1VE_CDF_VEIC_CODE_FK_PK, Me.GridColumn10})
        Me.GV33.GridControl = Me.GC33
        Me.GV33.Name = "GV33"
        Me.GV33.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV33.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV33.OptionsView.ShowGroupPanel = False
        '
        'colIC1VE_FIC_CODE_FK_PK
        '
        Me.colIC1VE_FIC_CODE_FK_PK.Caption = "IC1VE_FIC_CODE_FK_PK"
        Me.colIC1VE_FIC_CODE_FK_PK.FieldName = "IC1VE_FIC_CODE_FK_PK"
        Me.colIC1VE_FIC_CODE_FK_PK.Name = "colIC1VE_FIC_CODE_FK_PK"
        '
        'colIC1VE_CDF_VEIC_CODE_FK_PK
        '
        Me.colIC1VE_CDF_VEIC_CODE_FK_PK.Caption = "IC1VE_CDF_VEIC_CODE_FK_PK"
        Me.colIC1VE_CDF_VEIC_CODE_FK_PK.FieldName = "IC1VE_CDF_VEIC_CODE_FK_PK"
        Me.colIC1VE_CDF_VEIC_CODE_FK_PK.Name = "colIC1VE_CDF_VEIC_CODE_FK_PK"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Vecteur1"
        Me.GridColumn10.ColumnEdit = Me.lkup_IC1VE
        Me.GridColumn10.FieldName = "IC1VE_CDF_VEIC_CODE_FK_PK"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 0
        '
        'lkup_IC1VE
        '
        Me.lkup_IC1VE.AutoHeight = False
        Me.lkup_IC1VE.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_IC1VE.Name = "lkup_IC1VE"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.GC31)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(497, 88)
        Me.Panel8.TabIndex = 20
        '
        'GC31
        '
        Me.GC31.DataMember = "ICSOL_INCOMPATIBILITE_SOLUTION"
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
        Me.GC31.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_ICSOL})
        Me.GC31.Size = New System.Drawing.Size(497, 88)
        Me.GC31.TabIndex = 15
        Me.GC31.Tag = "[EDIT][ADD]"
        Me.GC31.UseEmbeddedNavigator = True
        Me.GC31.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV31})
        '
        'GV31
        '
        Me.GV31.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colICSOL_FIC_CODE_FK_PK, Me.colICSOL_CDF_SOLIC_CODE_FK_PK, Me.GridColumn8})
        Me.GV31.GridControl = Me.GC31
        Me.GV31.Name = "GV31"
        Me.GV31.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV31.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV31.OptionsView.ShowGroupPanel = False
        '
        'colICSOL_FIC_CODE_FK_PK
        '
        Me.colICSOL_FIC_CODE_FK_PK.Caption = "ICSOL_FIC_CODE_FK_PK"
        Me.colICSOL_FIC_CODE_FK_PK.FieldName = "ICSOL_FIC_CODE_FK_PK"
        Me.colICSOL_FIC_CODE_FK_PK.Name = "colICSOL_FIC_CODE_FK_PK"
        '
        'colICSOL_CDF_SOLIC_CODE_FK_PK
        '
        Me.colICSOL_CDF_SOLIC_CODE_FK_PK.Caption = "Code"
        Me.colICSOL_CDF_SOLIC_CODE_FK_PK.FieldName = "ICSOL_CDF_SOLIC_CODE_FK_PK"
        Me.colICSOL_CDF_SOLIC_CODE_FK_PK.Name = "colICSOL_CDF_SOLIC_CODE_FK_PK"
        Me.colICSOL_CDF_SOLIC_CODE_FK_PK.Visible = True
        Me.colICSOL_CDF_SOLIC_CODE_FK_PK.VisibleIndex = 0
        Me.colICSOL_CDF_SOLIC_CODE_FK_PK.Width = 50
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Solution"
        Me.GridColumn8.ColumnEdit = Me.lkup_ICSOL
        Me.GridColumn8.FieldName = "ICSOL_CDF_SOLIC_CODE_FK_PK"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        Me.GridColumn8.Width = 576
        '
        'lkup_ICSOL
        '
        Me.lkup_ICSOL.AutoHeight = False
        Me.lkup_ICSOL.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_ICSOL.Name = "lkup_ICSOL"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.Panel12)
        Me.XtraTabPage4.Controls.Add(Me.Panel11)
        Me.XtraTabPage4.Controls.Add(Me.Panel10)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(497, 381)
        Me.XtraTabPage4.Text = "Solution 2/2"
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.Panel14)
        Me.Panel12.Controls.Add(Me.Panel13)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(0, 276)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(497, 105)
        Me.Panel12.TabIndex = 37
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.MemoEdit1)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(0, 24)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(497, 81)
        Me.Panel14.TabIndex = 38
        Me.Panel14.Tag = "[EDIT][ADD]"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_AnalyseOrdonance2, "FIC_INCOMPATIBILITE.FIC_TEXTE", True))
        Me.MemoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoEdit1.Location = New System.Drawing.Point(0, 0)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(497, 81)
        Me.MemoEdit1.TabIndex = 36
        Me.MemoEdit1.Tag = ""
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.LabelControl6)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(497, 24)
        Me.Panel13.TabIndex = 37
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(2, 7)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl6.TabIndex = 19
        Me.LabelControl6.Text = "Texte"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.GC43)
        Me.Panel11.Controls.Add(Me.GC44)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 138)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(497, 138)
        Me.Panel11.TabIndex = 10
        '
        'GC43
        '
        Me.GC43.DataMember = "ICTMP_INCOMPA_TEMPERATURE"
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
        Me.GC43.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_ICTMP})
        Me.GC43.Size = New System.Drawing.Size(171, 138)
        Me.GC43.TabIndex = 5
        Me.GC43.Tag = "[EDIT][ADD]"
        Me.GC43.UseEmbeddedNavigator = True
        Me.GC43.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV43})
        '
        'GV43
        '
        Me.GV43.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colICTMP_FIC_CODE_FK_PK, Me.colICTMP_CDF_TEMP_CODE_FK_PK, Me.colICTMP_NUMORD, Me.GridColumn17})
        Me.GV43.GridControl = Me.GC43
        Me.GV43.Name = "GV43"
        Me.GV43.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV43.OptionsView.ShowGroupPanel = False
        '
        'colICTMP_FIC_CODE_FK_PK
        '
        Me.colICTMP_FIC_CODE_FK_PK.Caption = "ICTMP_FIC_CODE_FK_PK"
        Me.colICTMP_FIC_CODE_FK_PK.FieldName = "ICTMP_FIC_CODE_FK_PK"
        Me.colICTMP_FIC_CODE_FK_PK.Name = "colICTMP_FIC_CODE_FK_PK"
        '
        'colICTMP_CDF_TEMP_CODE_FK_PK
        '
        Me.colICTMP_CDF_TEMP_CODE_FK_PK.Caption = "ICTMP_CDF_TEMP_CODE_FK_PK"
        Me.colICTMP_CDF_TEMP_CODE_FK_PK.FieldName = "ICTMP_CDF_TEMP_CODE_FK_PK"
        Me.colICTMP_CDF_TEMP_CODE_FK_PK.Name = "colICTMP_CDF_TEMP_CODE_FK_PK"
        '
        'colICTMP_NUMORD
        '
        Me.colICTMP_NUMORD.Caption = "ICTMP_NUMORD"
        Me.colICTMP_NUMORD.FieldName = "ICTMP_NUMORD"
        Me.colICTMP_NUMORD.Name = "colICTMP_NUMORD"
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Température"
        Me.GridColumn17.ColumnEdit = Me.lkup_ICTMP
        Me.GridColumn17.FieldName = "ICTMP_CDF_TEMP_CODE_FK_PK"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 0
        '
        'lkup_ICTMP
        '
        Me.lkup_ICTMP.AutoHeight = False
        Me.lkup_ICTMP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_ICTMP.Name = "lkup_ICTMP"
        '
        'GC44
        '
        Me.GC44.DataMember = "ICLUM_INCOMPATIBILITE_LUMIERE"
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
        Me.GC44.Location = New System.Drawing.Point(171, 0)
        Me.GC44.MainView = Me.GV44
        Me.GC44.Name = "GC44"
        Me.GC44.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_ICLUM})
        Me.GC44.Size = New System.Drawing.Size(326, 138)
        Me.GC44.TabIndex = 6
        Me.GC44.Tag = "[EDIT][ADD]"
        Me.GC44.UseEmbeddedNavigator = True
        Me.GC44.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV44})
        '
        'GV44
        '
        Me.GV44.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colICLUM_FIC_CODE_FK_PK, Me.colICLUM_CDF_LUM_CODE_FK_PK, Me.colICLUM_NUMORD, Me.GridColumn18})
        Me.GV44.GridControl = Me.GC44
        Me.GV44.Name = "GV44"
        Me.GV44.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV44.OptionsView.ShowGroupPanel = False
        '
        'colICLUM_FIC_CODE_FK_PK
        '
        Me.colICLUM_FIC_CODE_FK_PK.Caption = "ICLUM_FIC_CODE_FK_PK"
        Me.colICLUM_FIC_CODE_FK_PK.FieldName = "ICLUM_FIC_CODE_FK_PK"
        Me.colICLUM_FIC_CODE_FK_PK.Name = "colICLUM_FIC_CODE_FK_PK"
        '
        'colICLUM_CDF_LUM_CODE_FK_PK
        '
        Me.colICLUM_CDF_LUM_CODE_FK_PK.Caption = "ICLUM_CDF_LUM_CODE_FK_PK"
        Me.colICLUM_CDF_LUM_CODE_FK_PK.FieldName = "ICLUM_CDF_LUM_CODE_FK_PK"
        Me.colICLUM_CDF_LUM_CODE_FK_PK.Name = "colICLUM_CDF_LUM_CODE_FK_PK"
        '
        'colICLUM_NUMORD
        '
        Me.colICLUM_NUMORD.Caption = "ICLUM_NUMORD"
        Me.colICLUM_NUMORD.FieldName = "ICLUM_NUMORD"
        Me.colICLUM_NUMORD.Name = "colICLUM_NUMORD"
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Lumière"
        Me.GridColumn18.ColumnEdit = Me.lkup_ICLUM
        Me.GridColumn18.FieldName = "ICLUM_CDF_LUM_CODE_FK_PK"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 0
        '
        'lkup_ICLUM
        '
        Me.lkup_ICLUM.AutoHeight = False
        Me.lkup_ICLUM.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_ICLUM.Name = "lkup_ICLUM"
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.GC41)
        Me.Panel10.Controls.Add(Me.GC42)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(497, 138)
        Me.Panel10.TabIndex = 9
        '
        'GC41
        '
        Me.GC41.DataMember = "ICNA_INCOMPATIBILITE_NATURE"
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
        Me.GC41.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_ICNA})
        Me.GC41.Size = New System.Drawing.Size(171, 138)
        Me.GC41.TabIndex = 3
        Me.GC41.Tag = "[EDIT][ADD]"
        Me.GC41.UseEmbeddedNavigator = True
        Me.GC41.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV41})
        '
        'GV41
        '
        Me.GV41.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colICNA_FIC_CODE_FK_PK, Me.colICNA_CDF_NAIC_CODE_FK_PK, Me.colICNA_NUMORD, Me.GridColumn15})
        Me.GV41.GridControl = Me.GC41
        Me.GV41.Name = "GV41"
        Me.GV41.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV41.OptionsView.ShowGroupPanel = False
        '
        'colICNA_FIC_CODE_FK_PK
        '
        Me.colICNA_FIC_CODE_FK_PK.Caption = "ICNA_FIC_CODE_FK_PK"
        Me.colICNA_FIC_CODE_FK_PK.FieldName = "ICNA_FIC_CODE_FK_PK"
        Me.colICNA_FIC_CODE_FK_PK.Name = "colICNA_FIC_CODE_FK_PK"
        '
        'colICNA_CDF_NAIC_CODE_FK_PK
        '
        Me.colICNA_CDF_NAIC_CODE_FK_PK.Caption = "ICNA_CDF_NAIC_CODE_FK_PK"
        Me.colICNA_CDF_NAIC_CODE_FK_PK.FieldName = "ICNA_CDF_NAIC_CODE_FK_PK"
        Me.colICNA_CDF_NAIC_CODE_FK_PK.Name = "colICNA_CDF_NAIC_CODE_FK_PK"
        '
        'colICNA_NUMORD
        '
        Me.colICNA_NUMORD.Caption = "ICNA_NUMORD"
        Me.colICNA_NUMORD.FieldName = "ICNA_NUMORD"
        Me.colICNA_NUMORD.Name = "colICNA_NUMORD"
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Nature"
        Me.GridColumn15.ColumnEdit = Me.lkup_ICNA
        Me.GridColumn15.FieldName = "ICNA_CDF_NAIC_CODE_FK_PK"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 0
        '
        'lkup_ICNA
        '
        Me.lkup_ICNA.AutoHeight = False
        Me.lkup_ICNA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_ICNA.Name = "lkup_ICNA"
        Me.lkup_ICNA.NullText = ""
        '
        'GC42
        '
        Me.GC42.DataMember = "ICDUR_INCOMPATIBILITE_DUREE"
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
        Me.GC42.Location = New System.Drawing.Point(171, 0)
        Me.GC42.MainView = Me.GV42
        Me.GC42.Name = "GC42"
        Me.GC42.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_ICDUR})
        Me.GC42.Size = New System.Drawing.Size(326, 138)
        Me.GC42.TabIndex = 4
        Me.GC42.Tag = "[EDIT][ADD]"
        Me.GC42.UseEmbeddedNavigator = True
        Me.GC42.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV42})
        '
        'GV42
        '
        Me.GV42.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colICDUR_FIC_CODE_FK_PK, Me.colICDUR_CDF_DUR_CODE_FK_PK, Me.colICDUR_NUMORD, Me.GridColumn16})
        Me.GV42.GridControl = Me.GC42
        Me.GV42.Name = "GV42"
        Me.GV42.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV42.OptionsView.ShowGroupPanel = False
        '
        'colICDUR_FIC_CODE_FK_PK
        '
        Me.colICDUR_FIC_CODE_FK_PK.Caption = "ICDUR_FIC_CODE_FK_PK"
        Me.colICDUR_FIC_CODE_FK_PK.FieldName = "ICDUR_FIC_CODE_FK_PK"
        Me.colICDUR_FIC_CODE_FK_PK.Name = "colICDUR_FIC_CODE_FK_PK"
        '
        'colICDUR_CDF_DUR_CODE_FK_PK
        '
        Me.colICDUR_CDF_DUR_CODE_FK_PK.Caption = "ICDUR_CDF_DUR_CODE_FK_PK"
        Me.colICDUR_CDF_DUR_CODE_FK_PK.FieldName = "ICDUR_CDF_DUR_CODE_FK_PK"
        Me.colICDUR_CDF_DUR_CODE_FK_PK.Name = "colICDUR_CDF_DUR_CODE_FK_PK"
        '
        'colICDUR_NUMORD
        '
        Me.colICDUR_NUMORD.Caption = "ICDUR_NUMORD"
        Me.colICDUR_NUMORD.FieldName = "ICDUR_NUMORD"
        Me.colICDUR_NUMORD.Name = "colICDUR_NUMORD"
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Durée - délai"
        Me.GridColumn16.ColumnEdit = Me.lkup_ICDUR
        Me.GridColumn16.FieldName = "ICDUR_CDF_DUR_CODE_FK_PK"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 0
        '
        'lkup_ICDUR
        '
        Me.lkup_ICDUR.AutoHeight = False
        Me.lkup_ICDUR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_ICDUR.Name = "lkup_ICDUR"
        '
        'IC1SAC_TA
        '
        Me.IC1SAC_TA.ClearBeforeFill = True
        '
        'IC1SAU_TA
        '
        Me.IC1SAU_TA.ClearBeforeFill = True
        '
        'IC1PR_TA
        '
        Me.IC1PR_TA.ClearBeforeFill = True
        '
        'IC1SP_TA
        '
        Me.IC1SP_TA.ClearBeforeFill = True
        '
        'IC2PR_TA
        '
        Me.IC2PR_TA.ClearBeforeFill = True
        '
        'IC2SAC_TA
        '
        Me.IC2SAC_TA.ClearBeforeFill = True
        '
        'IC2SAU_TA
        '
        Me.IC2SAU_TA.ClearBeforeFill = True
        '
        'IC2SP_TA
        '
        Me.IC2SP_TA.ClearBeforeFill = True
        '
        'IcsoL_TA
        '
        Me.IcsoL_TA.ClearBeforeFill = True
        '
        'IccT1_TA
        '
        Me.IccT1_TA.ClearBeforeFill = True
        '
        'IC1VE_TA
        '
        Me.IC1VE_TA.ClearBeforeFill = True
        '
        'IccT2_TA
        '
        Me.IccT2_TA.ClearBeforeFill = True
        '
        'IC2VE_TA
        '
        Me.IC2VE_TA.ClearBeforeFill = True
        '
        'IccO_TA
        '
        Me.IccO_TA.ClearBeforeFill = True
        '
        'IcmA_TA
        '
        Me.IcmA_TA.ClearBeforeFill = True
        '
        'IcnA_TA
        '
        Me.IcnA_TA.ClearBeforeFill = True
        '
        'IcduR_TA
        '
        Me.IcduR_TA.ClearBeforeFill = True
        '
        'IcluM_TA
        '
        Me.IcluM_TA.ClearBeforeFill = True
        '
        'IctmP_TA
        '
        Me.IctmP_TA.ClearBeforeFill = True
        '
        'Frm_Incompatibilites_Fiche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(780, 574)
        Me.Name = "Frm_Incompatibilites_Fiche"
        Me.Text = "(In)compatibilités - Fiche"
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
        CType(Me.cmbOrigine.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_AnalyseOrdonance2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.GC13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IC1PR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IC1SP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GC11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IC1SAC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IC1SAU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.GC23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IC2PR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IC2SP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.GC21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IC2SAC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IC2SAU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        CType(Me.GC36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_ICMA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_ICCO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        CType(Me.GC34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_ICCT2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IC2VE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.GC32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_ICCT1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IC1VE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        CType(Me.GC31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_ICSOL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        CType(Me.GC43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_ICTMP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_ICLUM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        CType(Me.GC41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_ICNA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_ICDUR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FiC_TA As Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.FIC_INCOMPATIBILITETableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DsTheriaque_AnalyseOrdonance2 As Theriaque.dsTheriaque_AnalyseOrdonance2
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbOrigine As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ComboBoxEdit2 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GC11 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IC1SAC_TA As Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.IC1SAC_TERME1SUBACTTableAdapter
    Friend WithEvents colIC1SAC_FIC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIC1SAC_SAC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IC1SAC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IC1SAU_TA As Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.IC1SAU_TERME1SUBAUXTableAdapter
    Friend WithEvents GC12 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIC1SAU_FIC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIC1SAU_SAU_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IC1SAU As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC13 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IC1PR_TA As Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.IC1PR_TERME1PRODUITTableAdapter
    Friend WithEvents colIC1PR_FIC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIC1PR_PR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IC1PR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC14 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIC1SP_FIC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIC1SP_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IC1SP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents IC1SP_TA As Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.IC1SP_TERME1SPECIALITETableAdapter
    Friend WithEvents Spécialité1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GC23 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV23 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC24 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV24 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GC21 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV21 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC22 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV22 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IC2PR_TA As Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.IC2PR_TERME2PRODUITTableAdapter
    Friend WithEvents IC2SAC_TA As Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.IC2SAC_TERME2SUBACTTableAdapter
    Friend WithEvents IC2SAU_TA As Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.IC2SAU_TERME2SUBAUXTableAdapter
    Friend WithEvents IC2SP_TA As Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.IC2SP_TERME2SPECIALITETableAdapter
    Friend WithEvents colIC2SAC_FIC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIC2SAC_SAC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIC2PR_FIC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIC2PR_PR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IC2PR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colIC2SP_FIC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIC2SP_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IC2SAC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colIC2SAU_FIC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIC2SAU_SAU_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IC2SAU As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IC2SP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents GC31 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV31 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents GC32 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV32 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC33 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV33 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents GC34 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV34 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC35 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV35 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents GC36 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV36 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC37 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV37 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents IcsoL_TA As Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.ICSOL_INCOMPATIBILITE_SOLUTIONTableAdapter
    Friend WithEvents colICSOL_FIC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICSOL_CDF_SOLIC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_ICSOL As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents IccT1_TA As Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.ICCT1_CONCENTRATION1TableAdapter
    Friend WithEvents colICCT1_FIC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICCT1_NUMSEQ_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICCT1_CONCENTRATION1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICCT1_CDF_UDOSE_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICCT1_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_ICCT1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIC1VE_FIC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIC1VE_CDF_VEIC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IC1VE As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents IC1VE_TA As Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.IC1VE_INCOMPATIBILITE_VECTEUR1TableAdapter
    Friend WithEvents colICCT2_FIC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICCT2_NUMSEQ_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICCT2_CONCENTRATION2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICCT2_CDF_UDOSE_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICCT2_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_ICCT2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents IccT2_TA As Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.ICCT2_CONCENTRATION2TableAdapter
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIC2VE_FIC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIC2VE_CDF_VEIC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IC2VE_TA As Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.IC2VE_INCOMPATIBILITE_VECTEUR2TableAdapter
    Friend WithEvents IccO_TA As Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.ICCO_INCOMPATIBILITE_CONTENANTTableAdapter
    Friend WithEvents IcmA_TA As Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.ICMA_INCOMPATIBILITE_MATERIAUTableAdapter
    Friend WithEvents colICMA_FIC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICMA_CDF_MAIC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_ICMA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colICCO_FIC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICCO_CDF_COIC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_ICCO As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IC2VE As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents GC43 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV43 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC44 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV44 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents GC41 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV41 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC42 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV42 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colICNA_FIC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICNA_CDF_NAIC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICNA_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_ICNA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents IcnA_TA As Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.ICNA_INCOMPATIBILITE_NATURETableAdapter
    Friend WithEvents colICDUR_FIC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICDUR_CDF_DUR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICDUR_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_ICDUR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents IcduR_TA As Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.ICDUR_INCOMPATIBILITE_DUREETableAdapter
    Friend WithEvents IcluM_TA As Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.ICLUM_INCOMPATIBILITE_LUMIERETableAdapter
    Friend WithEvents IctmP_TA As Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.ICTMP_INCOMPA_TEMPERATURETableAdapter
    Friend WithEvents colICTMP_FIC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICTMP_CDF_TEMP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICTMP_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_ICTMP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colICLUM_FIC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICLUM_CDF_LUM_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICLUM_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_ICLUM As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel

End Class
