<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Posologie_Min_Max1
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
        Me.SUBACT = New Theriaque.dsTheriaque_Pos_Min_MaxTableAdapters.FPOMMSAC_POSOMINMAX_SUBACTTableAdapter
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.GC11 = New DevExpress.XtraGrid.GridControl
        Me.GV11 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCHTIT_CH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCHTIT_CDF_TIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcdfcodif = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lstcodif = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colNumeroP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_CHTIT = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.DsTheriaque_Pos_Min_Max1 = New Theriaque.dsTheriaque_Pos_Min_Max
        Me.TERPER = New Theriaque.dsTheriaque_Pos_Min_MaxTableAdapters.FPOMMTP_POSOMINMAX_TERPERTableAdapter
        Me.xtraDocument = New DevExpress.XtraTab.XtraTabControl
        Me.xtraDeclinaison = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFPOMM_CODE_SQ_PK4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPOMMSP_FPOMM_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPOMMSP_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lstSPE = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel19 = New System.Windows.Forms.Panel
        Me.GC_D5 = New DevExpress.XtraGrid.GridControl
        Me.GV_D5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFPOMM_CODE_SQ_PK3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPOPR_FPO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPOPR_PR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_CHSAU = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel21 = New System.Windows.Forms.Panel
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFPOMM_CODE_SQ_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPOSAC_FPO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPOSAC_SAC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lstSubact = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.Panel17 = New System.Windows.Forms.Panel
        Me.GC_D4 = New DevExpress.XtraGrid.GridControl
        Me.GV_D4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCHSAC_CH_CODE_SQ_PK_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCHSAC_SAC_CODE_SQ_PK_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCHSAC_SAC_CODE_SQ_PK_FK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_CHSAC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel18 = New System.Windows.Forms.Panel
        Me.GC8 = New DevExpress.XtraGrid.GridControl
        Me.GV8 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCHCATC_CH_CODE_SQ_PK_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCHCATC_CATC_CODE_PK_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCHCATC_CATC_CODE_PK_FK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_CHCATC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.GC_D2 = New DevExpress.XtraGrid.GridControl
        Me.GV_D2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFPOMM_CODE_SQ_PK1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPOMMCCH_FPOMM_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPOMMCCH_CCH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_CHCCH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.GC_D1 = New DevExpress.XtraGrid.GridControl
        Me.GV_D1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodePere = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFPOMMCPH_CPH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clphlst = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colinvisible1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.xtpCritere = New DevExpress.XtraTab.XtraTabPage
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUnite = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lstunite = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lstanthropo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colCDFCodeInvisible = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCDFNumInvisible = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.lkupUnitMax = New DevExpress.XtraEditors.LookUpEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.lkupUnitMin = New DevExpress.XtraEditors.LookUpEdit
        Me.txtIntervalMax = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtIntervalMin = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.lkupUnite = New DevExpress.XtraEditors.LookUpEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDose = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtNumCDF = New DevExpress.XtraEditors.TextEdit
        Me.txtCodeCDF = New DevExpress.XtraEditors.TextEdit
        Me.FPODCMDOSECUMULMAXBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.Panel3 = New System.Windows.Forms.Panel
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
        Me.DOSES = New Theriaque.dsTheriaque_Pos_Min_MaxTableAdapters.FPOMMDO_POSOMINMAX_DOSESTableAdapter
        Me.POSOLOGIE_MIN_MAX = New Theriaque.dsTheriaque_Pos_Min_MaxTableAdapters.FPOMM_POSOLOGIE_MIN_MAXTableAdapter
        Me.CDF_CODIF = New Theriaque.dsTheriaque_Pos_Min_MaxTableAdapters.CDF_CODIFTableAdapter
        Me.SPE = New Theriaque.dsTheriaque_Pos_Min_MaxTableAdapters.FPOMMSP_POSOMINMAX_SPETableAdapter
        Me.PROD = New Theriaque.dsTheriaque_Pos_Min_MaxTableAdapters.FPOMMPR_POSOMINMAX_PRODTableAdapter
        Me.CLCH = New Theriaque.dsTheriaque_Pos_Min_MaxTableAdapters.FPOMMCCH_POSOMINMAX_CLCHTableAdapter
        Me.CLPH = New Theriaque.dsTheriaque_Pos_Min_MaxTableAdapters.FPOMMCPH_POSOMINMAX_CLPHTableAdapter
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.txtFicheNum = New DevExpress.XtraEditors.TextEdit
        Me.FPOMMDO = New Theriaque.dsTheriaque_Pos_Min_MaxTableAdapters.FPOMMDO_POSOMINMAX_DOSESTableAdapter
        Me.FPOMMI = New Theriaque.dsTheriaque_Pos_Min_MaxTableAdapters.FPOMMI_INTERVALLE_MIN_MAXTableAdapter
        Me.FPODCM = New Theriaque.dsTheriaque_Pos_Min_MaxTableAdapters.FPODCM_DOSE_CUMUL_MAXTableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.GC11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstcodif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_CHTIT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_Pos_Min_Max1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtraDocument, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtraDocument.SuspendLayout()
        Me.xtraDeclinaison.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstSPE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel19.SuspendLayout()
        CType(Me.GC_D5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_D5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_CHSAU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel21.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstSubact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel16.SuspendLayout()
        Me.Panel17.SuspendLayout()
        CType(Me.GC_D4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_D4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_CHSAC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel18.SuspendLayout()
        CType(Me.GC8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_CHCATC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel15.SuspendLayout()
        CType(Me.GC_D2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_D2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_CHCCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        CType(Me.GC_D1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_D1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clphlst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpCritere.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.XtraTabPage6.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstunite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstanthropo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.lkupUnitMax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupUnitMin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIntervalMax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIntervalMin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.lkupUnite.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDose.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumCDF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodeCDF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FPODCMDOSECUMULMAXBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel3.SuspendLayout()
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IT1CPH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_IT1CCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFicheNum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(810, 574)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.txtFicheNum)
        Me.PanMain.Controls.Add(Me.LabelControl10)
        Me.PanMain.Controls.Add(Me.xtraDocument)
        Me.PanMain.Location = New System.Drawing.Point(0, 75)
        Me.PanMain.Size = New System.Drawing.Size(692, 499)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(810, 75)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(810, 28)
        Me.Label1.Text = "Posologies minimales/maximales"
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
        Me.Panel1.Location = New System.Drawing.Point(692, 75)
        Me.Panel1.Size = New System.Drawing.Size(118, 499)
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Pos_Min_Max1, "FPOMM_POSOLOGIE_MIN_MAX.FPOMM_DATEMJ ", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Location = New System.Drawing.Point(0, 67)
        Me.GroupBox.Size = New System.Drawing.Size(810, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Pos_Min_Max1, "FPOMM_POSOLOGIE_MIN_MAX.FPOMM_DATECR", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        '
        'btAdvancedSearch
        '
        Me.btAdvancedSearch.Visible = True
        '
        'SUBACT
        '
        Me.SUBACT.ClearBeforeFill = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GC11)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(2, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(499, 426)
        Me.Panel5.TabIndex = 19
        '
        'GC11
        '
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
        Me.GC11.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_CHTIT, Me.lstcodif})
        Me.GC11.Size = New System.Drawing.Size(499, 426)
        Me.GC11.TabIndex = 2
        Me.GC11.Tag = "[EDIT][ADD]"
        Me.GC11.UseEmbeddedNavigator = True
        Me.GC11.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV11})
        '
        'GV11
        '
        Me.GV11.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCHTIT_CH_CODE_FK_PK, Me.colCHTIT_CDF_TIT_CODE_FK_PK, Me.colcdfcodif, Me.colNumeroP})
        Me.GV11.GridControl = Me.GC11
        Me.GV11.Name = "GV11"
        Me.GV11.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV11.OptionsView.ShowGroupPanel = False
        '
        'colCHTIT_CH_CODE_FK_PK
        '
        Me.colCHTIT_CH_CODE_FK_PK.Caption = "CHTIT_CH_CODE_FK_PK"
        Me.colCHTIT_CH_CODE_FK_PK.FieldName = "FPOMMTP_FPOMM_CODE_FK_PK"
        Me.colCHTIT_CH_CODE_FK_PK.Name = "colCHTIT_CH_CODE_FK_PK"
        '
        'colCHTIT_CDF_TIT_CODE_FK_PK
        '
        Me.colCHTIT_CDF_TIT_CODE_FK_PK.Caption = "Code"
        Me.colCHTIT_CDF_TIT_CODE_FK_PK.FieldName = "FPOMMTP_CODEP_FK_PK"
        Me.colCHTIT_CDF_TIT_CODE_FK_PK.Name = "colCHTIT_CDF_TIT_CODE_FK_PK"
        Me.colCHTIT_CDF_TIT_CODE_FK_PK.Visible = True
        Me.colCHTIT_CDF_TIT_CODE_FK_PK.VisibleIndex = 0
        Me.colCHTIT_CDF_TIT_CODE_FK_PK.Width = 50
        '
        'colcdfcodif
        '
        Me.colcdfcodif.Caption = "Libellé"
        Me.colcdfcodif.ColumnEdit = Me.lstcodif
        Me.colcdfcodif.FieldName = "FPOMMTP_CODEP_FK_PK"
        Me.colcdfcodif.Name = "colcdfcodif"
        Me.colcdfcodif.Visible = True
        Me.colcdfcodif.VisibleIndex = 1
        Me.colcdfcodif.Width = 531
        '
        'lstcodif
        '
        Me.lstcodif.AutoHeight = False
        Me.lstcodif.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstcodif.Name = "lstcodif"
        Me.lstcodif.NullText = ""
        '
        'colNumeroP
        '
        Me.colNumeroP.Caption = "FPOMMTP_NUMEROP_FK_PK"
        Me.colNumeroP.FieldName = "FPOMMTP_NUMEROP_FK_PK"
        Me.colNumeroP.Name = "colNumeroP"
        '
        'lkup_CHTIT
        '
        Me.lkup_CHTIT.AutoHeight = False
        Me.lkup_CHTIT.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_CHTIT.Name = "lkup_CHTIT"
        '
        'DsTheriaque_Pos_Min_Max1
        '
        Me.DsTheriaque_Pos_Min_Max1.DataSetName = "dsTheriaque_Pos_Min_Max"
        Me.DsTheriaque_Pos_Min_Max1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TERPER
        '
        Me.TERPER.ClearBeforeFill = True
        '
        'xtraDocument
        '
        Me.xtraDocument.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xtraDocument.Location = New System.Drawing.Point(0, 38)
        Me.xtraDocument.Name = "xtraDocument"
        Me.xtraDocument.SelectedTabPage = Me.xtraDeclinaison
        Me.xtraDocument.Size = New System.Drawing.Size(692, 461)
        Me.xtraDocument.TabIndex = 8
        Me.xtraDocument.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraDeclinaison, Me.xtpCritere, Me.XtraTabPage6, Me.XtraTabPage1, Me.XtraTabPage2})
        Me.xtraDocument.Text = "Document"
        '
        'xtraDeclinaison
        '
        Me.xtraDeclinaison.Controls.Add(Me.GridControl3)
        Me.xtraDeclinaison.Controls.Add(Me.Panel19)
        Me.xtraDeclinaison.Controls.Add(Me.Panel16)
        Me.xtraDeclinaison.Controls.Add(Me.Panel4)
        Me.xtraDeclinaison.Name = "xtraDeclinaison"
        Me.xtraDeclinaison.Size = New System.Drawing.Size(683, 430)
        Me.xtraDeclinaison.Text = "Entités"
        '
        'GridControl3
        '
        Me.GridControl3.DataMember = "FPOMMSP_POSOMINMAX_SPE"
        Me.GridControl3.DataSource = Me.DsTheriaque_Pos_Min_Max1
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridControl3.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GridControl3.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GridControl3.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GridControl3.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GridControl3.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GridControl3.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GridControl3.EmbeddedNavigator.Name = ""
        Me.GridControl3.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GridControl3.Location = New System.Drawing.Point(0, 296)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lstSPE})
        Me.GridControl3.Size = New System.Drawing.Size(683, 134)
        Me.GridControl3.TabIndex = 13
        Me.GridControl3.Tag = "[EDIT][ADD]"
        Me.GridControl3.UseEmbeddedNavigator = True
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFPOMM_CODE_SQ_PK4, Me.colFPOMMSP_FPOMM_CODE_FK_PK, Me.colFPOMMSP_SP_CODE_FK_PK})
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView3.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colFPOMM_CODE_SQ_PK4
        '
        Me.colFPOMM_CODE_SQ_PK4.Caption = "FPOMMSP_FPOMM_CODE_FK_PK"
        Me.colFPOMM_CODE_SQ_PK4.FieldName = "FPOMMSP_FPOMM_CODE_FK_PK"
        Me.colFPOMM_CODE_SQ_PK4.Name = "colFPOMM_CODE_SQ_PK4"
        '
        'colFPOMMSP_FPOMM_CODE_FK_PK
        '
        Me.colFPOMMSP_FPOMM_CODE_FK_PK.Caption = "Code"
        Me.colFPOMMSP_FPOMM_CODE_FK_PK.FieldName = "FPOMMSP_SP_CODE_FK_PK"
        Me.colFPOMMSP_FPOMM_CODE_FK_PK.Name = "colFPOMMSP_FPOMM_CODE_FK_PK"
        Me.colFPOMMSP_FPOMM_CODE_FK_PK.Visible = True
        Me.colFPOMMSP_FPOMM_CODE_FK_PK.VisibleIndex = 0
        Me.colFPOMMSP_FPOMM_CODE_FK_PK.Width = 50
        '
        'colFPOMMSP_SP_CODE_FK_PK
        '
        Me.colFPOMMSP_SP_CODE_FK_PK.Caption = "Spécialité"
        Me.colFPOMMSP_SP_CODE_FK_PK.ColumnEdit = Me.lstSPE
        Me.colFPOMMSP_SP_CODE_FK_PK.FieldName = "FPOMMSP_SP_CODE_FK_PK"
        Me.colFPOMMSP_SP_CODE_FK_PK.Name = "colFPOMMSP_SP_CODE_FK_PK"
        Me.colFPOMMSP_SP_CODE_FK_PK.Visible = True
        Me.colFPOMMSP_SP_CODE_FK_PK.VisibleIndex = 1
        Me.colFPOMMSP_SP_CODE_FK_PK.Width = 275
        '
        'lstSPE
        '
        Me.lstSPE.AutoHeight = False
        Me.lstSPE.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstSPE.Name = "lstSPE"
        Me.lstSPE.NullText = ""
        '
        'Panel19
        '
        Me.Panel19.Controls.Add(Me.GC_D5)
        Me.Panel19.Controls.Add(Me.Panel21)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel19.Location = New System.Drawing.Point(0, 143)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(683, 153)
        Me.Panel19.TabIndex = 2
        '
        'GC_D5
        '
        Me.GC_D5.DataMember = "FPOMMPR_POSOMINMAX_PROD"
        Me.GC_D5.DataSource = Me.DsTheriaque_Pos_Min_Max1
        Me.GC_D5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC_D5.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC_D5.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC_D5.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC_D5.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC_D5.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC_D5.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC_D5.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC_D5.EmbeddedNavigator.Name = ""
        Me.GC_D5.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC_D5.Location = New System.Drawing.Point(343, 0)
        Me.GC_D5.MainView = Me.GV_D5
        Me.GC_D5.Name = "GC_D5"
        Me.GC_D5.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_CHSAU})
        Me.GC_D5.Size = New System.Drawing.Size(340, 153)
        Me.GC_D5.TabIndex = 12
        Me.GC_D5.Tag = "[EDIT][ADD]"
        Me.GC_D5.UseEmbeddedNavigator = True
        Me.GC_D5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_D5})
        '
        'GV_D5
        '
        Me.GV_D5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFPOMM_CODE_SQ_PK3, Me.colFPOPR_FPO_CODE_FK_PK, Me.colFPOPR_PR_CODE_FK_PK})
        Me.GV_D5.GridControl = Me.GC_D5
        Me.GV_D5.Name = "GV_D5"
        Me.GV_D5.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV_D5.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV_D5.OptionsView.ShowGroupPanel = False
        '
        'colFPOMM_CODE_SQ_PK3
        '
        Me.colFPOMM_CODE_SQ_PK3.Caption = "IT1SAU_FIT_CODE_FK_PK"
        Me.colFPOMM_CODE_SQ_PK3.FieldName = "FPOMMPR_FPOMM_CODE_FK_PK"
        Me.colFPOMM_CODE_SQ_PK3.Name = "colFPOMM_CODE_SQ_PK3"
        '
        'colFPOPR_FPO_CODE_FK_PK
        '
        Me.colFPOPR_FPO_CODE_FK_PK.Caption = "Code"
        Me.colFPOPR_FPO_CODE_FK_PK.FieldName = "FPOMMPR_PR_CODE_FK_PK"
        Me.colFPOPR_FPO_CODE_FK_PK.Name = "colFPOPR_FPO_CODE_FK_PK"
        Me.colFPOPR_FPO_CODE_FK_PK.Visible = True
        Me.colFPOPR_FPO_CODE_FK_PK.VisibleIndex = 0
        Me.colFPOPR_FPO_CODE_FK_PK.Width = 50
        '
        'colFPOPR_PR_CODE_FK_PK
        '
        Me.colFPOPR_PR_CODE_FK_PK.Caption = "Produit"
        Me.colFPOPR_PR_CODE_FK_PK.ColumnEdit = Me.lkup_CHSAU
        Me.colFPOPR_PR_CODE_FK_PK.FieldName = "FPOMMPR_PR_CODE_FK_PK"
        Me.colFPOPR_PR_CODE_FK_PK.Name = "colFPOPR_PR_CODE_FK_PK"
        Me.colFPOPR_PR_CODE_FK_PK.Visible = True
        Me.colFPOPR_PR_CODE_FK_PK.VisibleIndex = 1
        Me.colFPOPR_PR_CODE_FK_PK.Width = 275
        '
        'lkup_CHSAU
        '
        Me.lkup_CHSAU.AutoHeight = False
        Me.lkup_CHSAU.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_CHSAU.Name = "lkup_CHSAU"
        Me.lkup_CHSAU.NullText = ""
        '
        'Panel21
        '
        Me.Panel21.Controls.Add(Me.GridControl2)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel21.Location = New System.Drawing.Point(0, 0)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(343, 153)
        Me.Panel21.TabIndex = 0
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "FPOMMSAC_POSOMINMAX_SUBACT"
        Me.GridControl2.DataSource = Me.DsTheriaque_Pos_Min_Max1
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridControl2.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GridControl2.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GridControl2.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GridControl2.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GridControl2.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GridControl2.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lstSubact})
        Me.GridControl2.Size = New System.Drawing.Size(343, 153)
        Me.GridControl2.TabIndex = 13
        Me.GridControl2.Tag = "[EDIT][ADD]"
        Me.GridControl2.UseEmbeddedNavigator = True
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFPOMM_CODE_SQ_PK2, Me.colFPOSAC_FPO_CODE_FK_PK, Me.colFPOSAC_SAC_CODE_FK_PK})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colFPOMM_CODE_SQ_PK2
        '
        Me.colFPOMM_CODE_SQ_PK2.Caption = " FPOMMSAC_FPOMM_CODE_FK_PK"
        Me.colFPOMM_CODE_SQ_PK2.FieldName = "FPOMMSAC_FPOMM_CODE_FK_PK"
        Me.colFPOMM_CODE_SQ_PK2.Name = "colFPOMM_CODE_SQ_PK2"
        '
        'colFPOSAC_FPO_CODE_FK_PK
        '
        Me.colFPOSAC_FPO_CODE_FK_PK.Caption = "Code"
        Me.colFPOSAC_FPO_CODE_FK_PK.FieldName = "FPOMMSAC_SAC_CODE_FK_PK "
        Me.colFPOSAC_FPO_CODE_FK_PK.Name = "colFPOSAC_FPO_CODE_FK_PK"
        Me.colFPOSAC_FPO_CODE_FK_PK.Visible = True
        Me.colFPOSAC_FPO_CODE_FK_PK.VisibleIndex = 0
        Me.colFPOSAC_FPO_CODE_FK_PK.Width = 50
        '
        'colFPOSAC_SAC_CODE_FK_PK
        '
        Me.colFPOSAC_SAC_CODE_FK_PK.Caption = "Substance active"
        Me.colFPOSAC_SAC_CODE_FK_PK.ColumnEdit = Me.lstSubact
        Me.colFPOSAC_SAC_CODE_FK_PK.FieldName = "FPOMMSAC_SAC_CODE_FK_PK "
        Me.colFPOSAC_SAC_CODE_FK_PK.Name = "colFPOSAC_SAC_CODE_FK_PK"
        Me.colFPOSAC_SAC_CODE_FK_PK.Visible = True
        Me.colFPOSAC_SAC_CODE_FK_PK.VisibleIndex = 1
        Me.colFPOSAC_SAC_CODE_FK_PK.Width = 275
        '
        'lstSubact
        '
        Me.lstSubact.AutoHeight = False
        Me.lstSubact.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstSubact.Name = "lstSubact"
        Me.lstSubact.NullText = ""
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.Panel17)
        Me.Panel16.Controls.Add(Me.Panel18)
        Me.Panel16.Location = New System.Drawing.Point(0, 143)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(683, 149)
        Me.Panel16.TabIndex = 1
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.GC_D4)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel17.Location = New System.Drawing.Point(342, 0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(341, 149)
        Me.Panel17.TabIndex = 1
        '
        'GC_D4
        '
        Me.GC_D4.DataMember = "IT1SAC_TERME1SUBACTIVE"
        Me.GC_D4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC_D4.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC_D4.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC_D4.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC_D4.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC_D4.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC_D4.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC_D4.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC_D4.EmbeddedNavigator.Name = ""
        Me.GC_D4.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC_D4.Location = New System.Drawing.Point(0, 0)
        Me.GC_D4.MainView = Me.GV_D4
        Me.GC_D4.Name = "GC_D4"
        Me.GC_D4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_CHSAC})
        Me.GC_D4.Size = New System.Drawing.Size(341, 149)
        Me.GC_D4.TabIndex = 10
        Me.GC_D4.Tag = "[EDIT][ADD]"
        Me.GC_D4.UseEmbeddedNavigator = True
        Me.GC_D4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_D4})
        '
        'GV_D4
        '
        Me.GV_D4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCHSAC_CH_CODE_SQ_PK_FK, Me.colCHSAC_SAC_CODE_SQ_PK_FK, Me.colCHSAC_SAC_CODE_SQ_PK_FK2})
        Me.GV_D4.GridControl = Me.GC_D4
        Me.GV_D4.Name = "GV_D4"
        Me.GV_D4.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV_D4.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV_D4.OptionsView.ShowGroupPanel = False
        '
        'colCHSAC_CH_CODE_SQ_PK_FK
        '
        Me.colCHSAC_CH_CODE_SQ_PK_FK.Caption = "Code"
        Me.colCHSAC_CH_CODE_SQ_PK_FK.FieldName = "CHSAC_CH_CODE_SQ_PK_FK"
        Me.colCHSAC_CH_CODE_SQ_PK_FK.Name = "colCHSAC_CH_CODE_SQ_PK_FK"
        Me.colCHSAC_CH_CODE_SQ_PK_FK.Visible = True
        Me.colCHSAC_CH_CODE_SQ_PK_FK.VisibleIndex = 0
        Me.colCHSAC_CH_CODE_SQ_PK_FK.Width = 50
        '
        'colCHSAC_SAC_CODE_SQ_PK_FK
        '
        Me.colCHSAC_SAC_CODE_SQ_PK_FK.Caption = "IT1SAC_FIT_CODE_FK_PK"
        Me.colCHSAC_SAC_CODE_SQ_PK_FK.FieldName = "CHSAC_SAC_CODE_SQ_PK_FK"
        Me.colCHSAC_SAC_CODE_SQ_PK_FK.Name = "colCHSAC_SAC_CODE_SQ_PK_FK"
        '
        'colCHSAC_SAC_CODE_SQ_PK_FK2
        '
        Me.colCHSAC_SAC_CODE_SQ_PK_FK2.Caption = "Produit"
        Me.colCHSAC_SAC_CODE_SQ_PK_FK2.ColumnEdit = Me.lkup_CHSAC
        Me.colCHSAC_SAC_CODE_SQ_PK_FK2.FieldName = "CHSAC_SAC_CODE_SQ_PK_FK"
        Me.colCHSAC_SAC_CODE_SQ_PK_FK2.Name = "colCHSAC_SAC_CODE_SQ_PK_FK2"
        Me.colCHSAC_SAC_CODE_SQ_PK_FK2.Visible = True
        Me.colCHSAC_SAC_CODE_SQ_PK_FK2.VisibleIndex = 1
        Me.colCHSAC_SAC_CODE_SQ_PK_FK2.Width = 232
        '
        'lkup_CHSAC
        '
        Me.lkup_CHSAC.AutoHeight = False
        Me.lkup_CHSAC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_CHSAC.Name = "lkup_CHSAC"
        '
        'Panel18
        '
        Me.Panel18.Controls.Add(Me.GC8)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel18.Location = New System.Drawing.Point(0, 0)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(343, 149)
        Me.Panel18.TabIndex = 0
        '
        'GC8
        '
        Me.GC8.DataMember = "IT1CC_TERM1COMCLASSE"
        Me.GC8.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.GC8.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.lkup_CHCATC})
        Me.GC8.Size = New System.Drawing.Size(343, 149)
        Me.GC8.TabIndex = 14
        Me.GC8.Tag = "[EDIT][ADD]"
        Me.GC8.UseEmbeddedNavigator = True
        Me.GC8.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV8})
        '
        'GV8
        '
        Me.GV8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCHCATC_CH_CODE_SQ_PK_FK, Me.colCHCATC_CATC_CODE_PK_FK, Me.colCHCATC_CATC_CODE_PK_FK2})
        Me.GV8.GridControl = Me.GC8
        Me.GV8.Name = "GV8"
        Me.GV8.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV8.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV8.OptionsView.ShowGroupPanel = False
        '
        'colCHCATC_CH_CODE_SQ_PK_FK
        '
        Me.colCHCATC_CH_CODE_SQ_PK_FK.Caption = "Code"
        Me.colCHCATC_CH_CODE_SQ_PK_FK.FieldName = "CHCATC_CH_CODE_SQ_PK_FK"
        Me.colCHCATC_CH_CODE_SQ_PK_FK.Name = "colCHCATC_CH_CODE_SQ_PK_FK"
        Me.colCHCATC_CH_CODE_SQ_PK_FK.Visible = True
        Me.colCHCATC_CH_CODE_SQ_PK_FK.VisibleIndex = 0
        Me.colCHCATC_CH_CODE_SQ_PK_FK.Width = 50
        '
        'colCHCATC_CATC_CODE_PK_FK
        '
        Me.colCHCATC_CATC_CODE_PK_FK.Caption = "GridColumn1"
        Me.colCHCATC_CATC_CODE_PK_FK.FieldName = "CHCATC_CATC_CODE_PK_FK"
        Me.colCHCATC_CATC_CODE_PK_FK.Name = "colCHCATC_CATC_CODE_PK_FK"
        '
        'colCHCATC_CATC_CODE_PK_FK2
        '
        Me.colCHCATC_CATC_CODE_PK_FK2.Caption = "Substance active"
        Me.colCHCATC_CATC_CODE_PK_FK2.ColumnEdit = Me.lkup_CHCATC
        Me.colCHCATC_CATC_CODE_PK_FK2.FieldName = "CHCATC_CATC_CODE_PK_FK"
        Me.colCHCATC_CATC_CODE_PK_FK2.Name = "colCHCATC_CATC_CODE_PK_FK2"
        Me.colCHCATC_CATC_CODE_PK_FK2.Visible = True
        Me.colCHCATC_CATC_CODE_PK_FK2.VisibleIndex = 1
        Me.colCHCATC_CATC_CODE_PK_FK2.Width = 272
        '
        'lkup_CHCATC
        '
        Me.lkup_CHCATC.AutoHeight = False
        Me.lkup_CHCATC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_CHCATC.Name = "lkup_CHCATC"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel15)
        Me.Panel4.Controls.Add(Me.Panel11)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(683, 143)
        Me.Panel4.TabIndex = 0
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.GC_D2)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel15.Location = New System.Drawing.Point(342, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(341, 143)
        Me.Panel15.TabIndex = 1
        '
        'GC_D2
        '
        Me.GC_D2.DataMember = "FPOMMCCH_POSOMINMAX_CLCH"
        Me.GC_D2.DataSource = Me.DsTheriaque_Pos_Min_Max1
        Me.GC_D2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC_D2.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC_D2.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC_D2.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC_D2.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC_D2.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC_D2.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC_D2.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC_D2.EmbeddedNavigator.Name = ""
        Me.GC_D2.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC_D2.Location = New System.Drawing.Point(0, 0)
        Me.GC_D2.MainView = Me.GV_D2
        Me.GC_D2.Name = "GC_D2"
        Me.GC_D2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_CHCCH})
        Me.GC_D2.Size = New System.Drawing.Size(341, 143)
        Me.GC_D2.TabIndex = 4
        Me.GC_D2.Tag = "[EDIT][ADD]"
        Me.GC_D2.UseEmbeddedNavigator = True
        Me.GC_D2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_D2})
        '
        'GV_D2
        '
        Me.GV_D2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFPOMM_CODE_SQ_PK1, Me.colFPOMMCCH_FPOMM_CODE_FK_PK, Me.colFPOMMCCH_CCH_CODE_FK_PK})
        Me.GV_D2.GridControl = Me.GC_D2
        Me.GV_D2.Name = "GV_D2"
        Me.GV_D2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV_D2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV_D2.OptionsView.ShowGroupPanel = False
        '
        'colFPOMM_CODE_SQ_PK1
        '
        Me.colFPOMM_CODE_SQ_PK1.Caption = "FPOMMCCH_FPOMM_CODE_FK_PK"
        Me.colFPOMM_CODE_SQ_PK1.FieldName = "FPOMMCCH_FPOMM_CODE_FK_PK"
        Me.colFPOMM_CODE_SQ_PK1.Name = "colFPOMM_CODE_SQ_PK1"
        '
        'colFPOMMCCH_FPOMM_CODE_FK_PK
        '
        Me.colFPOMMCCH_FPOMM_CODE_FK_PK.Caption = "Code"
        Me.colFPOMMCCH_FPOMM_CODE_FK_PK.FieldName = "FPOMMCCH_CCH_CODE_FK_PK"
        Me.colFPOMMCCH_FPOMM_CODE_FK_PK.Name = "colFPOMMCCH_FPOMM_CODE_FK_PK"
        Me.colFPOMMCCH_FPOMM_CODE_FK_PK.Visible = True
        Me.colFPOMMCCH_FPOMM_CODE_FK_PK.VisibleIndex = 0
        Me.colFPOMMCCH_FPOMM_CODE_FK_PK.Width = 50
        '
        'colFPOMMCCH_CCH_CODE_FK_PK
        '
        Me.colFPOMMCCH_CCH_CODE_FK_PK.Caption = "Classe chimique"
        Me.colFPOMMCCH_CCH_CODE_FK_PK.ColumnEdit = Me.lkup_CHCCH
        Me.colFPOMMCCH_CCH_CODE_FK_PK.FieldName = "FPOMMCCH_CCH_CODE_FK_PK"
        Me.colFPOMMCCH_CCH_CODE_FK_PK.Name = "colFPOMMCCH_CCH_CODE_FK_PK"
        Me.colFPOMMCCH_CCH_CODE_FK_PK.Visible = True
        Me.colFPOMMCCH_CCH_CODE_FK_PK.VisibleIndex = 1
        Me.colFPOMMCCH_CCH_CODE_FK_PK.Width = 232
        '
        'lkup_CHCCH
        '
        Me.lkup_CHCCH.AutoHeight = False
        Me.lkup_CHCCH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_CHCCH.Name = "lkup_CHCCH"
        Me.lkup_CHCCH.NullText = ""
        '
        'Panel11
        '
        Me.Panel11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel11.Controls.Add(Me.GC_D1)
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(343, 143)
        Me.Panel11.TabIndex = 0
        '
        'GC_D1
        '
        Me.GC_D1.DataMember = "FPOMMCPH_POSOMINMAX_CLPH"
        Me.GC_D1.DataSource = Me.DsTheriaque_Pos_Min_Max1
        Me.GC_D1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC_D1.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC_D1.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC_D1.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC_D1.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC_D1.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC_D1.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC_D1.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC_D1.EmbeddedNavigator.Name = ""
        Me.GC_D1.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC_D1.Location = New System.Drawing.Point(0, 0)
        Me.GC_D1.MainView = Me.GV_D1
        Me.GC_D1.Name = "GC_D1"
        Me.GC_D1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.clphlst})
        Me.GC_D1.Size = New System.Drawing.Size(343, 143)
        Me.GC_D1.TabIndex = 3
        Me.GC_D1.Tag = "[EDIT][ADD]"
        Me.GC_D1.UseEmbeddedNavigator = True
        Me.GC_D1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_D1})
        '
        'GV_D1
        '
        Me.GV_D1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodePere, Me.colFPOMMCPH_CPH_CODE_FK_PK, Me.colinvisible1})
        Me.GV_D1.GridControl = Me.GC_D1
        Me.GV_D1.Name = "GV_D1"
        Me.GV_D1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV_D1.OptionsView.ShowGroupPanel = False
        '
        'colCodePere
        '
        Me.colCodePere.Caption = "Code"
        Me.colCodePere.FieldName = "FPOMMCPH_CPH_CODE_FK_PK"
        Me.colCodePere.Name = "colCodePere"
        Me.colCodePere.OptionsColumn.ReadOnly = True
        Me.colCodePere.Tag = ""
        Me.colCodePere.Visible = True
        Me.colCodePere.VisibleIndex = 0
        Me.colCodePere.Width = 50
        '
        'colFPOMMCPH_CPH_CODE_FK_PK
        '
        Me.colFPOMMCPH_CPH_CODE_FK_PK.Caption = "Classe pharmaco thérapeutique"
        Me.colFPOMMCPH_CPH_CODE_FK_PK.ColumnEdit = Me.clphlst
        Me.colFPOMMCPH_CPH_CODE_FK_PK.FieldName = "FPOMMCPH_CPH_CODE_FK_PK"
        Me.colFPOMMCPH_CPH_CODE_FK_PK.Name = "colFPOMMCPH_CPH_CODE_FK_PK"
        Me.colFPOMMCPH_CPH_CODE_FK_PK.Visible = True
        Me.colFPOMMCPH_CPH_CODE_FK_PK.VisibleIndex = 1
        Me.colFPOMMCPH_CPH_CODE_FK_PK.Width = 275
        '
        'clphlst
        '
        Me.clphlst.AutoHeight = False
        Me.clphlst.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.clphlst.Name = "clphlst"
        Me.clphlst.NullText = ""
        '
        'colinvisible1
        '
        Me.colinvisible1.Caption = "FPOMMCPH_FPO_CODE_FK_PK"
        Me.colinvisible1.FieldName = "FPOMMCPH_FPO_CODE_FK_PK"
        Me.colinvisible1.Name = "colinvisible1"
        '
        'xtpCritere
        '
        Me.xtpCritere.Controls.Add(Me.PanelControl3)
        Me.xtpCritere.Name = "xtpCritere"
        Me.xtpCritere.Size = New System.Drawing.Size(503, 430)
        Me.xtpCritere.TabStop = True
        Me.xtpCritere.Tag = "[ADD][EDIT]"
        Me.xtpCritere.Text = "Terrains pères physio-pathologiques"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.Panel5)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(503, 430)
        Me.PanelControl3.TabIndex = 9
        Me.PanelControl3.Text = "PanelControl3"
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Controls.Add(Me.PanelControl2)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(683, 430)
        Me.XtraTabPage6.Text = "Posologie Min/Max"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.PanelControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(683, 430)
        Me.PanelControl2.TabIndex = 8
        Me.PanelControl2.Text = "PanelControl2"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Panel2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(679, 426)
        Me.PanelControl1.TabIndex = 10
        Me.PanelControl1.Text = "PanelControl1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GridControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(675, 422)
        Me.Panel2.TabIndex = 19
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Buttons.Edit.Enabled = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2, Me.lstunite, Me.lstanthropo})
        Me.GridControl1.Size = New System.Drawing.Size(675, 422)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.Tag = "[EDIT][ADD]"
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.colUnite, Me.GridColumn9, Me.colCDFCodeInvisible, Me.colCDFNumInvisible})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "FPOMMDO_FPOMM_CODE_FK_PK"
        Me.GridColumn1.FieldName = "FPOMMDO_FPOMM_CODE_FK_PK"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "N°"
        Me.GridColumn2.FieldName = "FPOMMDO_NUM_SEQ"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 113
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Dose P min"
        Me.GridColumn3.FieldName = "FPOMMDO_DP_MIN"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 86
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Dose P max"
        Me.GridColumn5.FieldName = "FPOMMDO_DP_MAX"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 2
        Me.GridColumn5.Width = 74
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Dose J min"
        Me.GridColumn6.FieldName = "FPOMMDO_DJ_MIN"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        Me.GridColumn6.Width = 74
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Dose J max"
        Me.GridColumn7.FieldName = "FPOMMDO_DJ_MAX"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 4
        Me.GridColumn7.Width = 74
        '
        'colUnite
        '
        Me.colUnite.Caption = "Unité"
        Me.colUnite.ColumnEdit = Me.lstunite
        Me.colUnite.FieldName = "temp"
        Me.colUnite.Name = "colUnite"
        Me.colUnite.Visible = True
        Me.colUnite.VisibleIndex = 5
        Me.colUnite.Width = 74
        '
        'lstunite
        '
        Me.lstunite.AutoHeight = False
        Me.lstunite.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstunite.MaxLength = 20
        Me.lstunite.Name = "lstunite"
        Me.lstunite.NullText = ""
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Donnée anthropo"
        Me.GridColumn9.ColumnEdit = Me.lstanthropo
        Me.GridColumn9.FieldName = "FPOMMDO_DONANTH_CDF_CODE_FK"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 6
        Me.GridColumn9.Width = 69
        '
        'lstanthropo
        '
        Me.lstanthropo.AutoHeight = False
        Me.lstanthropo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstanthropo.Name = "lstanthropo"
        Me.lstanthropo.NullText = ""
        '
        'colCDFCodeInvisible
        '
        Me.colCDFCodeInvisible.Caption = "FPOMMDO_UNIT_CDF_CODE_FK"
        Me.colCDFCodeInvisible.FieldName = "FPOMMDO_UNIT_CDF_CODE_FK"
        Me.colCDFCodeInvisible.Name = "colCDFCodeInvisible"
        '
        'colCDFNumInvisible
        '
        Me.colCDFNumInvisible.Caption = "FPOMMDO_UNITE_CDF_NUM_FK"
        Me.colCDFNumInvisible.FieldName = "FPOMMDO_UNITE_CDF_NUM_FK"
        Me.colCDFNumInvisible.Name = "colCDFNumInvisible"
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.lkupUnitMax)
        Me.XtraTabPage1.Controls.Add(Me.Label2)
        Me.XtraTabPage1.Controls.Add(Me.lkupUnitMin)
        Me.XtraTabPage1.Controls.Add(Me.txtIntervalMax)
        Me.XtraTabPage1.Controls.Add(Me.Label7)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage1.Controls.Add(Me.txtIntervalMin)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(683, 430)
        Me.XtraTabPage1.Text = "Intervalles min max"
        '
        'lkupUnitMax
        '
        Me.lkupUnitMax.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Pos_Min_Max1, "FPOMMI_INTERVALLE_MIN_MAX.FPOMMI_UNIT_MAX", True))
        Me.lkupUnitMax.Location = New System.Drawing.Point(121, 100)
        Me.lkupUnitMax.Name = "lkupUnitMax"
        Me.lkupUnitMax.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupUnitMax.Properties.NullText = ""
        Me.lkupUnitMax.Size = New System.Drawing.Size(135, 20)
        Me.lkupUnitMax.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Unité"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lkupUnitMin
        '
        Me.lkupUnitMin.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Pos_Min_Max1, "FPOMMI_INTERVALLE_MIN_MAX.FPOMMI_UNIT_MIN", True))
        Me.lkupUnitMin.Location = New System.Drawing.Point(121, 42)
        Me.lkupUnitMin.Name = "lkupUnitMin"
        Me.lkupUnitMin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupUnitMin.Properties.NullText = ""
        Me.lkupUnitMin.Size = New System.Drawing.Size(135, 20)
        Me.lkupUnitMin.TabIndex = 47
        '
        'txtIntervalMax
        '
        Me.txtIntervalMax.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Pos_Min_Max1, "FPOMMI_INTERVALLE_MIN_MAX.FPOMMI_INT_MAX", True))
        Me.txtIntervalMax.Location = New System.Drawing.Point(121, 70)
        Me.txtIntervalMax.Name = "txtIntervalMax"
        Me.txtIntervalMax.Size = New System.Drawing.Size(135, 20)
        Me.txtIntervalMax.TabIndex = 10
        Me.txtIntervalMax.Tag = "[ADD][EDIT]"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(83, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Unité"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(28, 74)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl4.TabIndex = 9
        Me.LabelControl4.Text = "Intervalle maximal"
        '
        'txtIntervalMin
        '
        Me.txtIntervalMin.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Pos_Min_Max1, "FPOMMI_INTERVALLE_MIN_MAX.FPOMMI_INT_MIN", True))
        Me.txtIntervalMin.Location = New System.Drawing.Point(121, 12)
        Me.txtIntervalMin.Name = "txtIntervalMin"
        Me.txtIntervalMin.Size = New System.Drawing.Size(135, 20)
        Me.txtIntervalMin.TabIndex = 10
        Me.txtIntervalMin.Tag = "[ADD][EDIT]"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(32, 16)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl3.TabIndex = 9
        Me.LabelControl3.Text = "Intervalle minimal"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.lkupUnite)
        Me.XtraTabPage2.Controls.Add(Me.Label3)
        Me.XtraTabPage2.Controls.Add(Me.txtDose)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage2.Controls.Add(Me.txtNumCDF)
        Me.XtraTabPage2.Controls.Add(Me.txtCodeCDF)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(503, 430)
        Me.XtraTabPage2.Text = "Dose cumulative maximale"
        '
        'lkupUnite
        '
        Me.lkupUnite.Location = New System.Drawing.Point(65, 47)
        Me.lkupUnite.Name = "lkupUnite"
        Me.lkupUnite.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupUnite.Properties.NullText = ""
        Me.lkupUnite.Size = New System.Drawing.Size(135, 20)
        Me.lkupUnite.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Unité"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDose
        '
        Me.txtDose.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Pos_Min_Max1, "FPODCM_DOSE_CUMUL_MAX.FPODCM_DCM", True))
        Me.txtDose.Location = New System.Drawing.Point(65, 17)
        Me.txtDose.Name = "txtDose"
        Me.txtDose.Size = New System.Drawing.Size(135, 20)
        Me.txtDose.TabIndex = 49
        Me.txtDose.Tag = "[ADD][EDIT]"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(31, 22)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl5.TabIndex = 48
        Me.LabelControl5.Text = "Dose"
        '
        'txtNumCDF
        '
        Me.txtNumCDF.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Pos_Min_Max1, "FPODCM_DOSE_CUMUL_MAX.FPODCM_UNIT_CDF_NUM_FK", True))
        Me.txtNumCDF.Location = New System.Drawing.Point(289, 436)
        Me.txtNumCDF.Name = "txtNumCDF"
        Me.txtNumCDF.Size = New System.Drawing.Size(135, 20)
        Me.txtNumCDF.TabIndex = 49
        Me.txtNumCDF.Tag = "[ADD][EDIT]"
        '
        'txtCodeCDF
        '
        Me.txtCodeCDF.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Pos_Min_Max1, "FPODCM_DOSE_CUMUL_MAX.FPODCM_UNIT", True))
        Me.txtCodeCDF.Location = New System.Drawing.Point(430, 436)
        Me.txtCodeCDF.Name = "txtCodeCDF"
        Me.txtCodeCDF.Size = New System.Drawing.Size(135, 20)
        Me.txtCodeCDF.TabIndex = 49
        Me.txtCodeCDF.Tag = "[ADD][EDIT]"
        '
        'FPODCMDOSECUMULMAXBindingSource
        '
        Me.FPODCMDOSECUMULMAXBindingSource.DataMember = "FPODCM_DOSE_CUMUL_MAX"
        Me.FPODCMDOSECUMULMAXBindingSource.DataSource = Me.DsTheriaque_Pos_Min_Max1
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
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GC1)
        Me.Panel3.Controls.Add(Me.GC2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(649, 115)
        Me.Panel3.TabIndex = 16
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
        'DOSES
        '
        Me.DOSES.ClearBeforeFill = True
        '
        'POSOLOGIE_MIN_MAX
        '
        Me.POSOLOGIE_MIN_MAX.ClearBeforeFill = True
        '
        'CDF_CODIF
        '
        Me.CDF_CODIF.ClearBeforeFill = True
        '
        'SPE
        '
        Me.SPE.ClearBeforeFill = True
        '
        'PROD
        '
        Me.PROD.ClearBeforeFill = True
        '
        'CLCH
        '
        Me.CLCH.ClearBeforeFill = True
        '
        'CLPH
        '
        Me.CLPH.ClearBeforeFill = True
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(35, 8)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl10.TabIndex = 9
        Me.LabelControl10.Text = "Fiche"
        '
        'txtFicheNum
        '
        Me.txtFicheNum.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Pos_Min_Max1, "FPOMM_POSOLOGIE_MIN_MAX.FPOMM_CODE_SQ_PK", True))
        Me.txtFicheNum.Enabled = False
        Me.txtFicheNum.Location = New System.Drawing.Point(92, 6)
        Me.txtFicheNum.Name = "txtFicheNum"
        Me.txtFicheNum.Size = New System.Drawing.Size(135, 20)
        Me.txtFicheNum.TabIndex = 10
        '
        'FPOMMDO
        '
        Me.FPOMMDO.ClearBeforeFill = True
        '
        'FPOMMI
        '
        Me.FPOMMI.ClearBeforeFill = True
        '
        'FPODCM
        '
        Me.FPODCM.ClearBeforeFill = True
        '
        'Frm_Posologie_Min_Max1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(810, 574)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "Frm_Posologie_Min_Max1"
        Me.Text = "Posologies minimales/maximales"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanMain.PerformLayout()
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.GC11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstcodif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_CHTIT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_Pos_Min_Max1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtraDocument, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtraDocument.ResumeLayout(False)
        Me.xtraDeclinaison.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstSPE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel19.ResumeLayout(False)
        CType(Me.GC_D5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_D5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_CHSAU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel21.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstSubact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel16.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        CType(Me.GC_D4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_D4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_CHSAC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel18.ResumeLayout(False)
        CType(Me.GC8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_CHCATC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        CType(Me.GC_D2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_D2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_CHCCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        CType(Me.GC_D1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_D1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clphlst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpCritere.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.XtraTabPage6.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstunite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstanthropo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.lkupUnitMax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupUnitMin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIntervalMax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIntervalMin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.lkupUnite.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDose.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumCDF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodeCDF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FPODCMDOSECUMULMAXBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.Panel3.ResumeLayout(False)
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IT1CPH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_IT1CCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFicheNum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SUBACT As Theriaque.dsTheriaque_Pos_Min_MaxTableAdapters.FPOMMSAC_POSOMINMAX_SUBACTTableAdapter
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GC11 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCHTIT_CH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCHTIT_CDF_TIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcdfcodif As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_CHTIT As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TERPER As Theriaque.dsTheriaque_Pos_Min_MaxTableAdapters.FPOMMTP_POSOMINMAX_TERPERTableAdapter
    Friend WithEvents xtraDocument As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpCritere As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents xtraDeclinaison As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents GC7 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIT1SP_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1SP_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1SP_SP_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IT1SP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents GC5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIT1SAU_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1SAU_SAU_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1_IT1SAU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IT1SAU As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC6 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIT1PR_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1PR_PR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1PR_PR_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IT1PR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents GC3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIT1CC_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IT1CC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colIT1CC_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GC4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIT1SAC_SAC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1SAC_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1_TERM1SAC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IT1SAC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GC1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIT1CPH_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1CPH_CPH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1CPH_CPH_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IT1CPH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIT1CCH_FIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1CCH_CCH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIT1CCH_CCH_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_IT1CCH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents GC_D2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_D2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFPOMM_CODE_SQ_PK1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPOMMCCH_FPOMM_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPOMMCCH_CCH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_CHCCH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC_D4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_D4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCHSAC_CH_CODE_SQ_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCHSAC_SAC_CODE_SQ_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCHSAC_SAC_CODE_SQ_PK_FK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_CHSAC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC_D5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_D5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFPOMM_CODE_SQ_PK3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPOPR_FPO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPOPR_PR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_CHSAU As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC_D1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_D1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodePere As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPOMMCPH_CPH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clphlst As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC8 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCHCATC_CH_CODE_SQ_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCHCATC_CATC_CODE_PK_FK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_CHCATC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DOSES As Theriaque.dsTheriaque_Pos_Min_MaxTableAdapters.FPOMMDO_POSOMINMAX_DOSESTableAdapter
    Friend WithEvents POSOLOGIE_MIN_MAX As Theriaque.dsTheriaque_Pos_Min_MaxTableAdapters.FPOMM_POSOLOGIE_MIN_MAXTableAdapter
    Friend WithEvents CDF_CODIF As Theriaque.dsTheriaque_Pos_Min_MaxTableAdapters.CDF_CODIFTableAdapter
    Friend WithEvents SPE As Theriaque.dsTheriaque_Pos_Min_MaxTableAdapters.FPOMMSP_POSOMINMAX_SPETableAdapter
    Friend WithEvents PROD As Theriaque.dsTheriaque_Pos_Min_MaxTableAdapters.FPOMMPR_POSOMINMAX_PRODTableAdapter
    Friend WithEvents CLCH As Theriaque.dsTheriaque_Pos_Min_MaxTableAdapters.FPOMMCCH_POSOMINMAX_CLCHTableAdapter
    Friend WithEvents CLPH As Theriaque.dsTheriaque_Pos_Min_MaxTableAdapters.FPOMMCPH_POSOMINMAX_CLPHTableAdapter
    Friend WithEvents colCHCATC_CATC_CODE_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtFicheNum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnite As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFPOMM_CODE_SQ_PK4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPOMMSP_FPOMM_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPOMMSP_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lstSPE As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFPOMM_CODE_SQ_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPOSAC_FPO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFPOSAC_SAC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lstSubact As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DsTheriaque_Pos_Min_Max1 As Theriaque.dsTheriaque_Pos_Min_Max
    Friend WithEvents colinvisible1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lstcodif As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colNumeroP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lstunite As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lstanthropo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FPOMMDO As Theriaque.dsTheriaque_Pos_Min_MaxTableAdapters.FPOMMDO_POSOMINMAX_DOSESTableAdapter
    Friend WithEvents colCDFCodeInvisible As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCDFNumInvisible As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtIntervalMin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkupUnitMax As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lkupUnitMin As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtIntervalMax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents FPOMMI As Theriaque.dsTheriaque_Pos_Min_MaxTableAdapters.FPOMMI_INTERVALLE_MIN_MAXTableAdapter
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lkupUnite As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDose As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents FPODCM As Theriaque.dsTheriaque_Pos_Min_MaxTableAdapters.FPODCM_DOSE_CUMUL_MAXTableAdapter
    Friend WithEvents txtNumCDF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodeCDF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FPODCMDOSECUMULMAXBindingSource As System.Windows.Forms.BindingSource


End Class
