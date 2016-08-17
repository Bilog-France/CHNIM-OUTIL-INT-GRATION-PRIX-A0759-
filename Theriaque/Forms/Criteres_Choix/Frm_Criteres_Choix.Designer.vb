<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Criteres_Choix
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
        Me.CH_TA = New Theriaque.dsTheriaque_CriteresChoixTableAdapters.CH_CHOIXTableAdapter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DateEdit3 = New DevExpress.XtraEditors.DateEdit
        Me.DsTheriaque_CriteresChoix = New Theriaque.dsTheriaque_CriteresChoix
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.GC11 = New DevExpress.XtraGrid.GridControl
        Me.GV11 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCHTIT_CH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCHTIT_CDF_TIT_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCHTIT_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCHTIT_CDF_TIT_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_CHTIT = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ChtiT_TA = New Theriaque.dsTheriaque_CriteresChoixTableAdapters.CHTIT_CH_TITRE2TableAdapter
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GC15 = New DevExpress.XtraGrid.GridControl
        Me.GV15 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSPCH_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPCH_CH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPCH_SP_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_SPCH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.xtraDocument = New DevExpress.XtraTab.XtraTabControl
        Me.xtpCritere = New DevExpress.XtraTab.XtraTabPage
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.xtraDeclinaison = New DevExpress.XtraTab.XtraTabPage
        Me.Panel19 = New System.Windows.Forms.Panel
        Me.Panel20 = New System.Windows.Forms.Panel
        Me.GC_D6 = New DevExpress.XtraGrid.GridControl
        Me.GV_D6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCHPR_CH_CODE_SQ_PK_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCHPR_PR_CODE_SQ_PK_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCHPR_PR_CODE_SQ_PK_FK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_CHPR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel21 = New System.Windows.Forms.Panel
        Me.GC_D5 = New DevExpress.XtraGrid.GridControl
        Me.GV_D5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCHSAU_CH_CODE_SQ_PK_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCHSAU_SAU_CODE_SQ_PK_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCHSAU_SAU_CODE_SQ_PK_FK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_CHSAU = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
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
        Me.colCHCCH_CH_CODE_SQ_PK_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCHCCH_CCH_CODE_PK_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCHCCH_CCH_CODE_PK_FK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_CHCCH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.GC_D1 = New DevExpress.XtraGrid.GridControl
        Me.GV_D1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCHCPH_CH_CODE_SQ_PK_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCHCPH_CPH_CODE_PK_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCHCPH_CPH_CODE_PK_FK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_CHCPH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.gcPropDoc = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.meNote = New DevExpress.XtraEditors.MemoEdit
        Me.lueCategorie = New DevExpress.XtraEditors.LookUpEdit
        Me.txtLibelle = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.cmdAnnuler = New DevExpress.XtraEditors.SimpleButton
        Me.bSupprimer = New DevExpress.XtraEditors.SimpleButton
        Me.cmdOK = New DevExpress.XtraEditors.SimpleButton
        Me.btAperçu = New DevExpress.XtraEditors.SimpleButton
        Me.btnImporter = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.bePath = New DevExpress.XtraEditors.ButtonEdit
        Me.SPCH_TA = New Theriaque.dsTheriaque_CriteresChoixTableAdapters.SPCH_SPECIALITE_CHOIXTableAdapter
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
        Me.DsTheriaque_AnalyseOrdonance = New Theriaque.dsTheriaque_AnalyseOrdonance
        Me.DsTheriaque1 = New Theriaque.dsTheriaque
        Me.CHSAC = New Theriaque.dsTheriaque_CriteresChoixTableAdapters.CHSAC_CHOIX_SUBACTIVETableAdapter
        Me.CHCPH = New Theriaque.dsTheriaque_CriteresChoixTableAdapters.CHCPH_CHOIX_CLASSEPHARMTHERTableAdapter
        Me.CHCCH = New Theriaque.dsTheriaque_CriteresChoixTableAdapters.CHCCH_CHOIX_CLASSECHIMIQUETableAdapter
        Me.CHSAU = New Theriaque.dsTheriaque_CriteresChoixTableAdapters.CHSAU_CHOIX_SUBAUXILIAIRETableAdapter
        Me.FgariL_RISQUE_ALLAITEMENTTableAdapter1 = New Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGARIL_RISQUE_ALLAITEMENTTableAdapter
        Me.CHPR = New Theriaque.dsTheriaque_CriteresChoixTableAdapters.CHPR_CHOIX_PRODUITTableAdapter
        Me.CHCATC = New Theriaque.dsTheriaque_CriteresChoixTableAdapters.CHCATC_CHOIX_CLASSEATCTableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_CriteresChoix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.GC11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_CHTIT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GC15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_SPCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        CType(Me.xtraDocument, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtraDocument.SuspendLayout()
        Me.xtpCritere.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.xtraDeclinaison.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel20.SuspendLayout()
        CType(Me.GC_D6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_D6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_CHPR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel21.SuspendLayout()
        CType(Me.GC_D5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_D5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_CHSAU, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.lkup_CHCPH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage6.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.gcPropDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcPropDoc.SuspendLayout()
        CType(Me.meNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCategorie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.bePath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.DsTheriaque_AnalyseOrdonance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(810, 574)
        '
        'PanMain
        '
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
        Me.Label1.Text = "Critères de choix"
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
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_CriteresChoix, "CH_CHOIX.CH_DATEMJ", True))
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
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_CriteresChoix, "CH_CHOIX.CH_DATECR", True))
        Me.DateEdit2.EditValue = New Date(2012, 5, 31, 0, 0, 0, 0)
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        '
        'CH_TA
        '
        Me.CH_TA.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateEdit3)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.TextEdit2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(679, 92)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'DateEdit3
        '
        Me.DateEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_CriteresChoix, "CH_CHOIX.CH_DATE", True))
        Me.DateEdit3.EditValue = Nothing
        Me.DateEdit3.Location = New System.Drawing.Point(88, 65)
        Me.DateEdit3.Name = "DateEdit3"
        Me.DateEdit3.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.DateEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit3.Size = New System.Drawing.Size(139, 20)
        Me.DateEdit3.TabIndex = 17
        Me.DateEdit3.Tag = "[ADD][EDIT]"
        '
        'DsTheriaque_CriteresChoix
        '
        Me.DsTheriaque_CriteresChoix.DataSetName = "dsTheriaque_CriteresChoix"
        Me.DsTheriaque_CriteresChoix.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(59, 69)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl4.TabIndex = 16
        Me.LabelControl4.Text = "Date"
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_CriteresChoix, "CH_CHOIX.CH_CODE_SQ_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(88, 13)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtCode.Properties.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(139, 20)
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
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(54, 43)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl5.TabIndex = 13
        Me.LabelControl5.Text = "Titre1"
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_CriteresChoix, "CH_CHOIX.CH_TITRE1", True))
        Me.TextEdit2.Location = New System.Drawing.Point(88, 39)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TextEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit2.Size = New System.Drawing.Size(292, 20)
        Me.TextEdit2.TabIndex = 14
        Me.TextEdit2.Tag = "[ADD][EDIT]"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GC11)
        Me.Panel5.Location = New System.Drawing.Point(2, 94)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(679, 151)
        Me.Panel5.TabIndex = 19
        '
        'GC11
        '
        Me.GC11.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC11.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC11.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC11.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC11.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC11.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC11.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC11.EmbeddedNavigator.Name = ""
        Me.GC11.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC11.Location = New System.Drawing.Point(-2, 0)
        Me.GC11.MainView = Me.GV11
        Me.GC11.Name = "GC11"
        Me.GC11.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_CHTIT})
        Me.GC11.Size = New System.Drawing.Size(681, 150)
        Me.GC11.TabIndex = 2
        Me.GC11.Tag = "[EDIT][ADD]"
        Me.GC11.UseEmbeddedNavigator = True
        Me.GC11.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV11})
        '
        'GV11
        '
        Me.GV11.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCHTIT_CH_CODE_FK_PK, Me.colCHTIT_CDF_TIT_CODE_FK_PK, Me.colCHTIT_NUMORD, Me.colCHTIT_CDF_TIT_CODE_FK_PK2})
        Me.GV11.GridControl = Me.GC11
        Me.GV11.Name = "GV11"
        Me.GV11.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV11.OptionsView.ShowGroupPanel = False
        '
        'colCHTIT_CH_CODE_FK_PK
        '
        Me.colCHTIT_CH_CODE_FK_PK.Caption = "CHTIT_CH_CODE_FK_PK"
        Me.colCHTIT_CH_CODE_FK_PK.FieldName = "CHTIT_CH_CODE_FK_PK"
        Me.colCHTIT_CH_CODE_FK_PK.Name = "colCHTIT_CH_CODE_FK_PK"
        '
        'colCHTIT_CDF_TIT_CODE_FK_PK
        '
        Me.colCHTIT_CDF_TIT_CODE_FK_PK.Caption = "Code"
        Me.colCHTIT_CDF_TIT_CODE_FK_PK.FieldName = "CHTIT_CDF_TIT_CODE_FK_PK"
        Me.colCHTIT_CDF_TIT_CODE_FK_PK.Name = "colCHTIT_CDF_TIT_CODE_FK_PK"
        Me.colCHTIT_CDF_TIT_CODE_FK_PK.Visible = True
        Me.colCHTIT_CDF_TIT_CODE_FK_PK.VisibleIndex = 0
        Me.colCHTIT_CDF_TIT_CODE_FK_PK.Width = 50
        '
        'colCHTIT_NUMORD
        '
        Me.colCHTIT_NUMORD.Caption = "N°"
        Me.colCHTIT_NUMORD.FieldName = "CHTIT_NUMORD"
        Me.colCHTIT_NUMORD.Name = "colCHTIT_NUMORD"
        Me.colCHTIT_NUMORD.Visible = True
        Me.colCHTIT_NUMORD.VisibleIndex = 2
        Me.colCHTIT_NUMORD.Width = 50
        '
        'colCHTIT_CDF_TIT_CODE_FK_PK2
        '
        Me.colCHTIT_CDF_TIT_CODE_FK_PK2.Caption = "Titre2"
        Me.colCHTIT_CDF_TIT_CODE_FK_PK2.ColumnEdit = Me.lkup_CHTIT
        Me.colCHTIT_CDF_TIT_CODE_FK_PK2.FieldName = "CHTIT_CDF_TIT_CODE_FK_PK"
        Me.colCHTIT_CDF_TIT_CODE_FK_PK2.Name = "colCHTIT_CDF_TIT_CODE_FK_PK2"
        Me.colCHTIT_CDF_TIT_CODE_FK_PK2.Visible = True
        Me.colCHTIT_CDF_TIT_CODE_FK_PK2.VisibleIndex = 1
        Me.colCHTIT_CDF_TIT_CODE_FK_PK2.Width = 529
        '
        'lkup_CHTIT
        '
        Me.lkup_CHTIT.AutoHeight = False
        Me.lkup_CHTIT.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_CHTIT.Name = "lkup_CHTIT"
        '
        'ChtiT_TA
        '
        Me.ChtiT_TA.ClearBeforeFill = True
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.Panel2)
        Me.Panel12.Controls.Add(Me.Panel14)
        Me.Panel12.Controls.Add(Me.Panel13)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(2, 242)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(679, 224)
        Me.Panel12.TabIndex = 38
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GC15)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 111)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(679, 113)
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
        Me.GC15.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_SPCH})
        Me.GC15.Size = New System.Drawing.Size(679, 113)
        Me.GC15.TabIndex = 3
        Me.GC15.Tag = "[EDIT][ADD]"
        Me.GC15.UseEmbeddedNavigator = True
        Me.GC15.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV15})
        '
        'GV15
        '
        Me.GV15.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSPCH_SP_CODE_FK_PK, Me.colSPCH_CH_CODE_FK_PK, Me.colSPCH_SP_CODE_FK_PK2})
        Me.GV15.GridControl = Me.GC15
        Me.GV15.Name = "GV15"
        Me.GV15.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV15.OptionsView.ShowGroupPanel = False
        '
        'colSPCH_SP_CODE_FK_PK
        '
        Me.colSPCH_SP_CODE_FK_PK.Caption = "Code"
        Me.colSPCH_SP_CODE_FK_PK.FieldName = "SPCH_SP_CODE_FK_PK"
        Me.colSPCH_SP_CODE_FK_PK.Name = "colSPCH_SP_CODE_FK_PK"
        Me.colSPCH_SP_CODE_FK_PK.Visible = True
        Me.colSPCH_SP_CODE_FK_PK.VisibleIndex = 0
        Me.colSPCH_SP_CODE_FK_PK.Width = 50
        '
        'colSPCH_CH_CODE_FK_PK
        '
        Me.colSPCH_CH_CODE_FK_PK.Caption = "SPCH_CH_CODE_FK_PK"
        Me.colSPCH_CH_CODE_FK_PK.FieldName = "SPCH_CH_CODE_FK_PK"
        Me.colSPCH_CH_CODE_FK_PK.Name = "colSPCH_CH_CODE_FK_PK"
        '
        'colSPCH_SP_CODE_FK_PK2
        '
        Me.colSPCH_SP_CODE_FK_PK2.Caption = "Spécialité "
        Me.colSPCH_SP_CODE_FK_PK2.ColumnEdit = Me.lkup_SPCH
        Me.colSPCH_SP_CODE_FK_PK2.FieldName = "SPCH_SP_CODE_FK_PK"
        Me.colSPCH_SP_CODE_FK_PK2.Name = "colSPCH_SP_CODE_FK_PK2"
        Me.colSPCH_SP_CODE_FK_PK2.Visible = True
        Me.colSPCH_SP_CODE_FK_PK2.VisibleIndex = 1
        Me.colSPCH_SP_CODE_FK_PK2.Width = 585
        '
        'lkup_SPCH
        '
        Me.lkup_SPCH.AutoHeight = False
        Me.lkup_SPCH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_SPCH.Name = "lkup_SPCH"
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.MemoEdit1)
        Me.Panel14.Location = New System.Drawing.Point(0, 26)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(679, 75)
        Me.Panel14.TabIndex = 38
        Me.Panel14.TabStop = True
        Me.Panel14.Tag = "[EDIT][ADD]"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_CriteresChoix, "CH_CHOIX.CH_TEXTE", True))
        Me.MemoEdit1.Location = New System.Drawing.Point(0, 1)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(679, 73)
        Me.MemoEdit1.TabIndex = 36
        Me.MemoEdit1.Tag = ""
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.LabelControl6)
        Me.Panel13.Location = New System.Drawing.Point(0, 3)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(679, 20)
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
        'xtraDocument
        '
        Me.xtraDocument.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtraDocument.Location = New System.Drawing.Point(0, 0)
        Me.xtraDocument.Name = "xtraDocument"
        Me.xtraDocument.SelectedTabPage = Me.xtpCritere
        Me.xtraDocument.Size = New System.Drawing.Size(692, 499)
        Me.xtraDocument.TabIndex = 8
        Me.xtraDocument.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraDeclinaison, Me.xtpCritere, Me.XtraTabPage6})
        Me.xtraDocument.Text = "Document"
        '
        'xtpCritere
        '
        Me.xtpCritere.Controls.Add(Me.PanelControl3)
        Me.xtpCritere.Name = "xtpCritere"
        Me.xtpCritere.Size = New System.Drawing.Size(683, 468)
        Me.xtpCritere.TabStop = True
        Me.xtpCritere.Tag = "[ADD][EDIT]"
        Me.xtpCritere.Text = "Critères de choix"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.Panel5)
        Me.PanelControl3.Controls.Add(Me.Panel12)
        Me.PanelControl3.Controls.Add(Me.GroupBox1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(683, 468)
        Me.PanelControl3.TabIndex = 9
        Me.PanelControl3.Text = "PanelControl3"
        '
        'xtraDeclinaison
        '
        Me.xtraDeclinaison.Controls.Add(Me.Panel19)
        Me.xtraDeclinaison.Controls.Add(Me.Panel16)
        Me.xtraDeclinaison.Controls.Add(Me.Panel4)
        Me.xtraDeclinaison.Name = "xtraDeclinaison"
        Me.xtraDeclinaison.Size = New System.Drawing.Size(683, 468)
        Me.xtraDeclinaison.Text = "Déclinaison"
        '
        'Panel19
        '
        Me.Panel19.Controls.Add(Me.Panel20)
        Me.Panel19.Controls.Add(Me.Panel21)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel19.Location = New System.Drawing.Point(0, 292)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(683, 153)
        Me.Panel19.TabIndex = 2
        '
        'Panel20
        '
        Me.Panel20.Controls.Add(Me.GC_D6)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel20.Location = New System.Drawing.Point(342, 0)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(341, 153)
        Me.Panel20.TabIndex = 1
        '
        'GC_D6
        '
        Me.GC_D6.DataMember = "IT1PR_TERME1PRODUIT"
        Me.GC_D6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC_D6.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC_D6.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC_D6.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC_D6.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC_D6.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC_D6.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC_D6.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC_D6.EmbeddedNavigator.Name = ""
        Me.GC_D6.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC_D6.Location = New System.Drawing.Point(0, 0)
        Me.GC_D6.MainView = Me.GV_D6
        Me.GC_D6.Name = "GC_D6"
        Me.GC_D6.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_CHPR})
        Me.GC_D6.Size = New System.Drawing.Size(341, 153)
        Me.GC_D6.TabIndex = 14
        Me.GC_D6.Tag = "[EDIT][ADD]"
        Me.GC_D6.UseEmbeddedNavigator = True
        Me.GC_D6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_D6})
        '
        'GV_D6
        '
        Me.GV_D6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCHPR_CH_CODE_SQ_PK_FK, Me.colCHPR_PR_CODE_SQ_PK_FK, Me.colCHPR_PR_CODE_SQ_PK_FK2})
        Me.GV_D6.GridControl = Me.GC_D6
        Me.GV_D6.Name = "GV_D6"
        Me.GV_D6.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV_D6.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV_D6.OptionsView.ShowGroupPanel = False
        '
        'colCHPR_CH_CODE_SQ_PK_FK
        '
        Me.colCHPR_CH_CODE_SQ_PK_FK.FieldName = "CHPR_CH_CODE_SQ_PK_FK"
        Me.colCHPR_CH_CODE_SQ_PK_FK.Name = "colCHPR_CH_CODE_SQ_PK_FK"
        '
        'colCHPR_PR_CODE_SQ_PK_FK
        '
        Me.colCHPR_PR_CODE_SQ_PK_FK.Caption = "Code"
        Me.colCHPR_PR_CODE_SQ_PK_FK.FieldName = "CHPR_PR_CODE_SQ_PK_FK"
        Me.colCHPR_PR_CODE_SQ_PK_FK.Name = "colCHPR_PR_CODE_SQ_PK_FK"
        Me.colCHPR_PR_CODE_SQ_PK_FK.Visible = True
        Me.colCHPR_PR_CODE_SQ_PK_FK.VisibleIndex = 0
        Me.colCHPR_PR_CODE_SQ_PK_FK.Width = 50
        '
        'colCHPR_PR_CODE_SQ_PK_FK2
        '
        Me.colCHPR_PR_CODE_SQ_PK_FK2.Caption = "Produit1"
        Me.colCHPR_PR_CODE_SQ_PK_FK2.ColumnEdit = Me.lkup_CHPR
        Me.colCHPR_PR_CODE_SQ_PK_FK2.FieldName = "CHPR_PR_CODE_SQ_PK_FK"
        Me.colCHPR_PR_CODE_SQ_PK_FK2.Name = "colCHPR_PR_CODE_SQ_PK_FK2"
        Me.colCHPR_PR_CODE_SQ_PK_FK2.Visible = True
        Me.colCHPR_PR_CODE_SQ_PK_FK2.VisibleIndex = 1
        Me.colCHPR_PR_CODE_SQ_PK_FK2.Width = 232
        '
        'lkup_CHPR
        '
        Me.lkup_CHPR.AutoHeight = False
        Me.lkup_CHPR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_CHPR.Name = "lkup_CHPR"
        '
        'Panel21
        '
        Me.Panel21.Controls.Add(Me.GC_D5)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel21.Location = New System.Drawing.Point(0, 0)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(343, 153)
        Me.Panel21.TabIndex = 0
        '
        'GC_D5
        '
        Me.GC_D5.DataMember = "IT1SAU_TERME1SUBAUX"
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
        Me.GC_D5.Location = New System.Drawing.Point(0, 0)
        Me.GC_D5.MainView = Me.GV_D5
        Me.GC_D5.Name = "GC_D5"
        Me.GC_D5.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_CHSAU})
        Me.GC_D5.Size = New System.Drawing.Size(343, 153)
        Me.GC_D5.TabIndex = 12
        Me.GC_D5.Tag = "[EDIT][ADD]"
        Me.GC_D5.UseEmbeddedNavigator = True
        Me.GC_D5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_D5})
        '
        'GV_D5
        '
        Me.GV_D5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCHSAU_CH_CODE_SQ_PK_FK, Me.colCHSAU_SAU_CODE_SQ_PK_FK, Me.colCHSAU_SAU_CODE_SQ_PK_FK2})
        Me.GV_D5.GridControl = Me.GC_D5
        Me.GV_D5.Name = "GV_D5"
        Me.GV_D5.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV_D5.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV_D5.OptionsView.ShowGroupPanel = False
        '
        'colCHSAU_CH_CODE_SQ_PK_FK
        '
        Me.colCHSAU_CH_CODE_SQ_PK_FK.FieldName = "CHSAU_CH_CODE_SQ_PK_FK"
        Me.colCHSAU_CH_CODE_SQ_PK_FK.Name = "colCHSAU_CH_CODE_SQ_PK_FK"
        '
        'colCHSAU_SAU_CODE_SQ_PK_FK
        '
        Me.colCHSAU_SAU_CODE_SQ_PK_FK.Caption = "Code"
        Me.colCHSAU_SAU_CODE_SQ_PK_FK.FieldName = "CHSAU_SAU_CODE_SQ_PK_FK"
        Me.colCHSAU_SAU_CODE_SQ_PK_FK.Name = "colCHSAU_SAU_CODE_SQ_PK_FK"
        Me.colCHSAU_SAU_CODE_SQ_PK_FK.Visible = True
        Me.colCHSAU_SAU_CODE_SQ_PK_FK.VisibleIndex = 0
        Me.colCHSAU_SAU_CODE_SQ_PK_FK.Width = 50
        '
        'colCHSAU_SAU_CODE_SQ_PK_FK2
        '
        Me.colCHSAU_SAU_CODE_SQ_PK_FK2.Caption = "Excipient1"
        Me.colCHSAU_SAU_CODE_SQ_PK_FK2.ColumnEdit = Me.lkup_CHSAU
        Me.colCHSAU_SAU_CODE_SQ_PK_FK2.FieldName = "CHSAU_SAU_CODE_SQ_PK_FK"
        Me.colCHSAU_SAU_CODE_SQ_PK_FK2.Name = "colCHSAU_SAU_CODE_SQ_PK_FK2"
        Me.colCHSAU_SAU_CODE_SQ_PK_FK2.Visible = True
        Me.colCHSAU_SAU_CODE_SQ_PK_FK2.VisibleIndex = 1
        Me.colCHSAU_SAU_CODE_SQ_PK_FK2.Width = 275
        '
        'lkup_CHSAU
        '
        Me.lkup_CHSAU.AutoHeight = False
        Me.lkup_CHSAU.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_CHSAU.Name = "lkup_CHSAU"
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.Panel17)
        Me.Panel16.Controls.Add(Me.Panel18)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Top
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
        Me.colCHSAC_CH_CODE_SQ_PK_FK.Width = 50
        '
        'colCHSAC_SAC_CODE_SQ_PK_FK
        '
        Me.colCHSAC_SAC_CODE_SQ_PK_FK.Caption = "code"
        Me.colCHSAC_SAC_CODE_SQ_PK_FK.FieldName = "CHSAC_SAC_CODE_SQ_PK_FK"
        Me.colCHSAC_SAC_CODE_SQ_PK_FK.Name = "colCHSAC_SAC_CODE_SQ_PK_FK"
        Me.colCHSAC_SAC_CODE_SQ_PK_FK.Visible = True
        Me.colCHSAC_SAC_CODE_SQ_PK_FK.VisibleIndex = 0
        '
        'colCHSAC_SAC_CODE_SQ_PK_FK2
        '
        Me.colCHSAC_SAC_CODE_SQ_PK_FK2.Caption = "Substance active1"
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
        Me.colCHCATC_CH_CODE_SQ_PK_FK.FieldName = "CHCATC_CH_CODE_SQ_PK_FK"
        Me.colCHCATC_CH_CODE_SQ_PK_FK.Name = "colCHCATC_CH_CODE_SQ_PK_FK"
        Me.colCHCATC_CH_CODE_SQ_PK_FK.Width = 50
        '
        'colCHCATC_CATC_CODE_PK_FK
        '
        Me.colCHCATC_CATC_CODE_PK_FK.Caption = "Code"
        Me.colCHCATC_CATC_CODE_PK_FK.FieldName = "CHCATC_CATC_CODE_PK_FK"
        Me.colCHCATC_CATC_CODE_PK_FK.Name = "colCHCATC_CATC_CODE_PK_FK"
        Me.colCHCATC_CATC_CODE_PK_FK.Visible = True
        Me.colCHCATC_CATC_CODE_PK_FK.VisibleIndex = 0
        '
        'colCHCATC_CATC_CODE_PK_FK2
        '
        Me.colCHCATC_CATC_CODE_PK_FK2.Caption = "Classe ATC"
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
        Me.GC_D2.DataMember = "IT1CCH_TERME1CLCHIM"
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
        Me.GV_D2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCHCCH_CH_CODE_SQ_PK_FK, Me.colCHCCH_CCH_CODE_PK_FK, Me.colCHCCH_CCH_CODE_PK_FK2})
        Me.GV_D2.GridControl = Me.GC_D2
        Me.GV_D2.Name = "GV_D2"
        Me.GV_D2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV_D2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV_D2.OptionsView.ShowGroupPanel = False
        '
        'colCHCCH_CH_CODE_SQ_PK_FK
        '
        Me.colCHCCH_CH_CODE_SQ_PK_FK.FieldName = "CHCCH_CH_CODE_SQ_PK_FK"
        Me.colCHCCH_CH_CODE_SQ_PK_FK.Name = "colCHCCH_CH_CODE_SQ_PK_FK"
        '
        'colCHCCH_CCH_CODE_PK_FK
        '
        Me.colCHCCH_CCH_CODE_PK_FK.Caption = "Code"
        Me.colCHCCH_CCH_CODE_PK_FK.FieldName = "CHCCH_CCH_CODE_PK_FK"
        Me.colCHCCH_CCH_CODE_PK_FK.Name = "colCHCCH_CCH_CODE_PK_FK"
        Me.colCHCCH_CCH_CODE_PK_FK.Visible = True
        Me.colCHCCH_CCH_CODE_PK_FK.VisibleIndex = 0
        Me.colCHCCH_CCH_CODE_PK_FK.Width = 50
        '
        'colCHCCH_CCH_CODE_PK_FK2
        '
        Me.colCHCCH_CCH_CODE_PK_FK2.Caption = "Classe chimique1"
        Me.colCHCCH_CCH_CODE_PK_FK2.ColumnEdit = Me.lkup_CHCCH
        Me.colCHCCH_CCH_CODE_PK_FK2.FieldName = "CHCCH_CCH_CODE_PK_FK"
        Me.colCHCCH_CCH_CODE_PK_FK2.Name = "colCHCCH_CCH_CODE_PK_FK2"
        Me.colCHCCH_CCH_CODE_PK_FK2.Visible = True
        Me.colCHCCH_CCH_CODE_PK_FK2.VisibleIndex = 1
        Me.colCHCCH_CCH_CODE_PK_FK2.Width = 232
        '
        'lkup_CHCCH
        '
        Me.lkup_CHCCH.AutoHeight = False
        Me.lkup_CHCCH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_CHCCH.Name = "lkup_CHCCH"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.GC_D1)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(343, 143)
        Me.Panel11.TabIndex = 0
        '
        'GC_D1
        '
        Me.GC_D1.DataMember = "IT1CPH_TERME1CLPHARMTHER"
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
        Me.GC_D1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_CHCPH})
        Me.GC_D1.Size = New System.Drawing.Size(343, 143)
        Me.GC_D1.TabIndex = 3
        Me.GC_D1.Tag = "[EDIT][ADD]"
        Me.GC_D1.UseEmbeddedNavigator = True
        Me.GC_D1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_D1})
        '
        'GV_D1
        '
        Me.GV_D1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCHCPH_CH_CODE_SQ_PK_FK, Me.colCHCPH_CPH_CODE_PK_FK, Me.colCHCPH_CPH_CODE_PK_FK2})
        Me.GV_D1.GridControl = Me.GC_D1
        Me.GV_D1.Name = "GV_D1"
        Me.GV_D1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV_D1.OptionsView.ShowGroupPanel = False
        '
        'colCHCPH_CH_CODE_SQ_PK_FK
        '
        Me.colCHCPH_CH_CODE_SQ_PK_FK.Caption = "IT1CPH_FIT_CODE_FK_PK"
        Me.colCHCPH_CH_CODE_SQ_PK_FK.FieldName = "CHCPH_CH_CODE_SQ_PK_FK"
        Me.colCHCPH_CH_CODE_SQ_PK_FK.Name = "colCHCPH_CH_CODE_SQ_PK_FK"
        '
        'colCHCPH_CPH_CODE_PK_FK
        '
        Me.colCHCPH_CPH_CODE_PK_FK.Caption = "Code"
        Me.colCHCPH_CPH_CODE_PK_FK.FieldName = "CHCPH_CPH_CODE_PK_FK"
        Me.colCHCPH_CPH_CODE_PK_FK.Name = "colCHCPH_CPH_CODE_PK_FK"
        Me.colCHCPH_CPH_CODE_PK_FK.Tag = ""
        Me.colCHCPH_CPH_CODE_PK_FK.Visible = True
        Me.colCHCPH_CPH_CODE_PK_FK.VisibleIndex = 0
        Me.colCHCPH_CPH_CODE_PK_FK.Width = 50
        '
        'colCHCPH_CPH_CODE_PK_FK2
        '
        Me.colCHCPH_CPH_CODE_PK_FK2.Caption = "Classe pharmaco thérapeutique1"
        Me.colCHCPH_CPH_CODE_PK_FK2.ColumnEdit = Me.lkup_CHCPH
        Me.colCHCPH_CPH_CODE_PK_FK2.FieldName = "CHCPH_CPH_CODE_PK_FK"
        Me.colCHCPH_CPH_CODE_PK_FK2.Name = "colCHCPH_CPH_CODE_PK_FK2"
        Me.colCHCPH_CPH_CODE_PK_FK2.Visible = True
        Me.colCHCPH_CPH_CODE_PK_FK2.VisibleIndex = 1
        Me.colCHCPH_CPH_CODE_PK_FK2.Width = 275
        '
        'lkup_CHCPH
        '
        Me.lkup_CHCPH.AutoHeight = False
        Me.lkup_CHCPH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_CHCPH.Name = "lkup_CHCPH"
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Controls.Add(Me.PanelControl2)
        Me.XtraTabPage6.Controls.Add(Me.PanelControl1)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(503, 460)
        Me.XtraTabPage6.Text = "Document"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Panel10)
        Me.PanelControl2.Controls.Add(Me.Panel9)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 31)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(503, 429)
        Me.PanelControl2.TabIndex = 8
        Me.PanelControl2.Text = "PanelControl2"
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.gcPropDoc)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(2, 2)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(412, 425)
        Me.Panel10.TabIndex = 6
        '
        'gcPropDoc
        '
        Me.gcPropDoc.Controls.Add(Me.LabelControl7)
        Me.gcPropDoc.Controls.Add(Me.LabelControl8)
        Me.gcPropDoc.Controls.Add(Me.meNote)
        Me.gcPropDoc.Controls.Add(Me.lueCategorie)
        Me.gcPropDoc.Controls.Add(Me.txtLibelle)
        Me.gcPropDoc.Controls.Add(Me.LabelControl9)
        Me.gcPropDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPropDoc.Location = New System.Drawing.Point(0, 0)
        Me.gcPropDoc.Name = "gcPropDoc"
        Me.gcPropDoc.Size = New System.Drawing.Size(412, 425)
        Me.gcPropDoc.TabIndex = 10
        Me.gcPropDoc.Text = "Propriété document"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(7, 91)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl7.TabIndex = 5
        Me.LabelControl7.Text = "Note"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(7, 66)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl8.TabIndex = 4
        Me.LabelControl8.Text = "Catégorie"
        '
        'meNote
        '
        Me.meNote.Location = New System.Drawing.Point(68, 88)
        Me.meNote.Name = "meNote"
        Me.meNote.Size = New System.Drawing.Size(479, 104)
        Me.meNote.TabIndex = 3
        '
        'lueCategorie
        '
        Me.lueCategorie.EditValue = ""
        Me.lueCategorie.Location = New System.Drawing.Point(68, 62)
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
        Me.txtLibelle.Location = New System.Drawing.Point(68, 32)
        Me.txtLibelle.Name = "txtLibelle"
        Me.txtLibelle.Size = New System.Drawing.Size(246, 20)
        Me.txtLibelle.TabIndex = 1
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(7, 32)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl9.TabIndex = 0
        Me.LabelControl9.Text = "Libellé"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.cmdAnnuler)
        Me.Panel9.Controls.Add(Me.bSupprimer)
        Me.Panel9.Controls.Add(Me.cmdOK)
        Me.Panel9.Controls.Add(Me.btAperçu)
        Me.Panel9.Controls.Add(Me.btnImporter)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(414, 2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(87, 425)
        Me.Panel9.TabIndex = 5
        '
        'cmdAnnuler
        '
        Me.cmdAnnuler.Location = New System.Drawing.Point(6, 215)
        Me.cmdAnnuler.Name = "cmdAnnuler"
        Me.cmdAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnnuler.TabIndex = 8
        Me.cmdAnnuler.Text = "Annu&ler"
        '
        'bSupprimer
        '
        Me.bSupprimer.Location = New System.Drawing.Point(6, 87)
        Me.bSupprimer.Name = "bSupprimer"
        Me.bSupprimer.Size = New System.Drawing.Size(75, 23)
        Me.bSupprimer.TabIndex = 3
        Me.bSupprimer.Text = "Supprimer"
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(6, 186)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 7
        Me.cmdOK.Text = "&Ok"
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
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.bePath)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(503, 31)
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
        'SPCH_TA
        '
        Me.SPCH_TA.ClearBeforeFill = True
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
        'CHSAC
        '
        Me.CHSAC.ClearBeforeFill = True
        '
        'CHCPH
        '
        Me.CHCPH.ClearBeforeFill = True
        '
        'CHCCH
        '
        Me.CHCCH.ClearBeforeFill = True
        '
        'CHSAU
        '
        Me.CHSAU.ClearBeforeFill = True
        '
        'FgariL_RISQUE_ALLAITEMENTTableAdapter1
        '
        Me.FgariL_RISQUE_ALLAITEMENTTableAdapter1.ClearBeforeFill = True
        '
        'CHPR
        '
        Me.CHPR.ClearBeforeFill = True
        '
        'CHCATC
        '
        Me.CHCATC.ClearBeforeFill = True
        '
        'Frm_Criteres_Choix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(810, 574)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "Frm_Criteres_Choix"
        Me.Text = "Critères de choix"
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
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_CriteresChoix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.GC11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_CHTIT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.GC15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_SPCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        CType(Me.xtraDocument, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtraDocument.ResumeLayout(False)
        Me.xtpCritere.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.xtraDeclinaison.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        CType(Me.GC_D6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_D6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_CHPR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel21.ResumeLayout(False)
        CType(Me.GC_D5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_D5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_CHSAU, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.lkup_CHCPH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage6.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        CType(Me.gcPropDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcPropDoc.ResumeLayout(False)
        Me.gcPropDoc.PerformLayout()
        CType(Me.meNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCategorie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.bePath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.DsTheriaque_AnalyseOrdonance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CH_TA As Theriaque.dsTheriaque_CriteresChoixTableAdapters.CH_CHOIXTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DsTheriaque_CriteresChoix As Theriaque.dsTheriaque_CriteresChoix
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GC11 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCHTIT_CH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCHTIT_CDF_TIT_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCHTIT_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCHTIT_CDF_TIT_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_CHTIT As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ChtiT_TA As Theriaque.dsTheriaque_CriteresChoixTableAdapters.CHTIT_CH_TITRE2TableAdapter
    Friend WithEvents DateEdit3 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents xtraDocument As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpCritere As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents bSupprimer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btAperçu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImporter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bePath As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gcPropDoc As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmdAnnuler As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents meNote As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lueCategorie As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtLibelle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GC15 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV15 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSPCH_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPCH_CH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPCH_SP_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_SPCH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SPCH_TA As Theriaque.dsTheriaque_CriteresChoixTableAdapters.SPCH_SPECIALITE_CHOIXTableAdapter
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
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents GC_D2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_D2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCHCCH_CH_CODE_SQ_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCHCCH_CCH_CODE_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCHCCH_CCH_CODE_PK_FK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_CHCCH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC_D4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_D4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCHSAC_CH_CODE_SQ_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCHSAC_SAC_CODE_SQ_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCHSAC_SAC_CODE_SQ_PK_FK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_CHSAC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC_D5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_D5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCHSAU_CH_CODE_SQ_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCHSAU_SAU_CODE_SQ_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCHSAU_SAU_CODE_SQ_PK_FK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_CHSAU As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC_D6 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_D6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCHPR_CH_CODE_SQ_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCHPR_PR_CODE_SQ_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCHPR_PR_CODE_SQ_PK_FK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_CHPR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DsTheriaque_AnalyseOrdonance As Theriaque.dsTheriaque_AnalyseOrdonance
    Friend WithEvents GC_D1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_D1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCHCPH_CH_CODE_SQ_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCHCPH_CPH_CODE_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCHCPH_CPH_CODE_PK_FK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_CHCPH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DsTheriaque1 As Theriaque.dsTheriaque
    Friend WithEvents GC8 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCHCATC_CH_CODE_SQ_PK_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCHCATC_CATC_CODE_PK_FK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_CHCATC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents CHSAC As Theriaque.dsTheriaque_CriteresChoixTableAdapters.CHSAC_CHOIX_SUBACTIVETableAdapter
    Friend WithEvents CHCPH As Theriaque.dsTheriaque_CriteresChoixTableAdapters.CHCPH_CHOIX_CLASSEPHARMTHERTableAdapter
    Friend WithEvents CHCCH As Theriaque.dsTheriaque_CriteresChoixTableAdapters.CHCCH_CHOIX_CLASSECHIMIQUETableAdapter
    Friend WithEvents CHSAU As Theriaque.dsTheriaque_CriteresChoixTableAdapters.CHSAU_CHOIX_SUBAUXILIAIRETableAdapter
    Friend WithEvents FgariL_RISQUE_ALLAITEMENTTableAdapter1 As Theriaque.dsTheriaque_Grossesse_AllaitementTableAdapters.FGARIL_RISQUE_ALLAITEMENTTableAdapter
    Friend WithEvents CHPR As Theriaque.dsTheriaque_CriteresChoixTableAdapters.CHPR_CHOIX_PRODUITTableAdapter
    Friend WithEvents CHCATC As Theriaque.dsTheriaque_CriteresChoixTableAdapters.CHCATC_CHOIX_CLASSEATCTableAdapter
    Friend WithEvents colCHCATC_CATC_CODE_PK_FK As DevExpress.XtraGrid.Columns.GridColumn

End Class
