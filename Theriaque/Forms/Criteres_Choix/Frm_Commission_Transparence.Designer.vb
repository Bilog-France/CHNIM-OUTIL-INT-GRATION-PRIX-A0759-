<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Commission_Transparence
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
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GC15 = New DevExpress.XtraGrid.GridControl
        Me.GV15 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSPATR_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPATR_ATR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPATR_SP_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_SPATR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GC13 = New DevExpress.XtraGrid.GridControl
        Me.GV13 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colATRSAC_ATR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colATRSAC_SAC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colATRSAC_SAC_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_ATRSAC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC14 = New DevExpress.XtraGrid.GridControl
        Me.GV14 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colATRPR_ATR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colATRPR_PR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colATRPR_PR_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_ATRPR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.GC11 = New DevExpress.XtraGrid.GridControl
        Me.GV11 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colATRASMR_ATR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colATRASMR_CDF_ASMR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colATRASMR_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_ATRASMR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC12 = New DevExpress.XtraGrid.GridControl
        Me.GV12 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colATRSMR_ATR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colATRSMR_CDF_SMR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colATRSMR_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colATRSMR_CDF_SMR_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_ATRSMR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit
        Me.DsTheriaque_CriteresChoix = New Theriaque.dsTheriaque_CriteresChoix
        Me.Texte = New System.Windows.Forms.Label
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.DateEdit3 = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.AtR_TA = New Theriaque.dsTheriaque_CriteresChoixTableAdapters.ATR_AVISCOMMISSIONTRANSPARENCETableAdapter
        Me.AtrasmR_TA = New Theriaque.dsTheriaque_CriteresChoixTableAdapters.ATRASMR_AVISCOMTRANS_ASMRTableAdapter
        Me.AtrsmR_TA = New Theriaque.dsTheriaque_CriteresChoixTableAdapters.ATRSMR_AVISCOMTRANS_SMRTableAdapter
        Me.AtrpR_TA = New Theriaque.dsTheriaque_CriteresChoixTableAdapters.ATRPR_AVISCOMTRANS_PRODUITTableAdapter
        Me.AtrsaC_TA = New Theriaque.dsTheriaque_CriteresChoixTableAdapters.ATRSAC_AVISCOMTRANS_SUBACTIVETableAdapter
        Me.SpatR_TA = New Theriaque.dsTheriaque_CriteresChoixTableAdapters.SPATR_SPEC_AVISTRANSPARENCETableAdapter
        Me.SpsmR_TA = New Theriaque.dsTheriaque_CriteresChoixTableAdapters.SPSMR_SERVICE_MEDICAL_RENDUTableAdapter
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
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
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GC15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_SPATR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.GC13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_ATRSAC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_ATRPR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.GC11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_ATRASMR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_ATRSMR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_CriteresChoix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
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
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(783, 602)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.TabControl1)
        Me.PanMain.Size = New System.Drawing.Size(665, 515)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(783, 87)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(783, 28)
        Me.Label1.Text = "Commission de la transparence"
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
        Me.Panel1.Location = New System.Drawing.Point(665, 87)
        Me.Panel1.Size = New System.Drawing.Size(118, 515)
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_CriteresChoix, "ATR_AVISCOMMISSIONTRANSPARENCE.ATR_DATEMJ", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Size = New System.Drawing.Size(783, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_CriteresChoix, "ATR_AVISCOMMISSIONTRANSPARENCE.ATR_DATECR", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.Panel6)
        Me.GroupBox1.Controls.Add(Me.Texte)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.TextEdit2)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.DateEdit3)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(651, 483)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(0, 149)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(656, 340)
        Me.Panel4.TabIndex = 21
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GC15)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 238)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(656, 102)
        Me.Panel3.TabIndex = 20
        '
        'GC15
        '
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
        Me.GC15.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_SPATR})
        Me.GC15.Size = New System.Drawing.Size(650, 97)
        Me.GC15.TabIndex = 2
        Me.GC15.Tag = "[EDIT][ADD]"
        Me.GC15.UseEmbeddedNavigator = True
        Me.GC15.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV15})
        '
        'GV15
        '
        Me.GV15.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSPATR_SP_CODE_FK_PK, Me.colSPATR_ATR_CODE_FK_PK, Me.colSPATR_SP_CODE_FK_PK2})
        Me.GV15.GridControl = Me.GC15
        Me.GV15.Name = "GV15"
        Me.GV15.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV15.OptionsView.ShowGroupPanel = False
        '
        'colSPATR_SP_CODE_FK_PK
        '
        Me.colSPATR_SP_CODE_FK_PK.Caption = "Code"
        Me.colSPATR_SP_CODE_FK_PK.FieldName = "SPATR_SP_CODE_FK_PK"
        Me.colSPATR_SP_CODE_FK_PK.Name = "colSPATR_SP_CODE_FK_PK"
        Me.colSPATR_SP_CODE_FK_PK.Visible = True
        Me.colSPATR_SP_CODE_FK_PK.VisibleIndex = 0
        Me.colSPATR_SP_CODE_FK_PK.Width = 50
        '
        'colSPATR_ATR_CODE_FK_PK
        '
        Me.colSPATR_ATR_CODE_FK_PK.Caption = "SPATR_ATR_CODE_FK_PK"
        Me.colSPATR_ATR_CODE_FK_PK.FieldName = "SPATR_ATR_CODE_FK_PK"
        Me.colSPATR_ATR_CODE_FK_PK.Name = "colSPATR_ATR_CODE_FK_PK"
        '
        'colSPATR_SP_CODE_FK_PK2
        '
        Me.colSPATR_SP_CODE_FK_PK2.Caption = "Spécialité"
        Me.colSPATR_SP_CODE_FK_PK2.ColumnEdit = Me.lkup_SPATR
        Me.colSPATR_SP_CODE_FK_PK2.FieldName = "SPATR_SP_CODE_FK_PK"
        Me.colSPATR_SP_CODE_FK_PK2.Name = "colSPATR_SP_CODE_FK_PK2"
        Me.colSPATR_SP_CODE_FK_PK2.Visible = True
        Me.colSPATR_SP_CODE_FK_PK2.VisibleIndex = 1
        Me.colSPATR_SP_CODE_FK_PK2.Width = 585
        '
        'lkup_SPATR
        '
        Me.lkup_SPATR.AutoHeight = False
        Me.lkup_SPATR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_SPATR.Name = "lkup_SPATR"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GC13)
        Me.Panel2.Controls.Add(Me.GC14)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 114)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(656, 124)
        Me.Panel2.TabIndex = 19
        '
        'GC13
        '
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
        Me.GC13.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_ATRSAC})
        Me.GC13.Size = New System.Drawing.Size(340, 124)
        Me.GC13.TabIndex = 2
        Me.GC13.Tag = "[EDIT][ADD]"
        Me.GC13.UseEmbeddedNavigator = True
        Me.GC13.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV13})
        '
        'GV13
        '
        Me.GV13.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colATRSAC_ATR_CODE_FK_PK, Me.colATRSAC_SAC_CODE_FK_PK, Me.colATRSAC_SAC_CODE_FK_PK2})
        Me.GV13.GridControl = Me.GC13
        Me.GV13.Name = "GV13"
        Me.GV13.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV13.OptionsView.ShowGroupPanel = False
        '
        'colATRSAC_ATR_CODE_FK_PK
        '
        Me.colATRSAC_ATR_CODE_FK_PK.Caption = "ATRSAC_ATR_CODE_FK_PK"
        Me.colATRSAC_ATR_CODE_FK_PK.FieldName = "ATRSAC_ATR_CODE_FK_PK"
        Me.colATRSAC_ATR_CODE_FK_PK.Name = "colATRSAC_ATR_CODE_FK_PK"
        '
        'colATRSAC_SAC_CODE_FK_PK
        '
        Me.colATRSAC_SAC_CODE_FK_PK.Caption = "Code"
        Me.colATRSAC_SAC_CODE_FK_PK.FieldName = "ATRSAC_SAC_CODE_FK_PK"
        Me.colATRSAC_SAC_CODE_FK_PK.Name = "colATRSAC_SAC_CODE_FK_PK"
        Me.colATRSAC_SAC_CODE_FK_PK.Visible = True
        Me.colATRSAC_SAC_CODE_FK_PK.VisibleIndex = 0
        Me.colATRSAC_SAC_CODE_FK_PK.Width = 50
        '
        'colATRSAC_SAC_CODE_FK_PK2
        '
        Me.colATRSAC_SAC_CODE_FK_PK2.Caption = "Substance active"
        Me.colATRSAC_SAC_CODE_FK_PK2.ColumnEdit = Me.lkup_ATRSAC
        Me.colATRSAC_SAC_CODE_FK_PK2.FieldName = "ATRSAC_SAC_CODE_FK_PK"
        Me.colATRSAC_SAC_CODE_FK_PK2.Name = "colATRSAC_SAC_CODE_FK_PK2"
        Me.colATRSAC_SAC_CODE_FK_PK2.Visible = True
        Me.colATRSAC_SAC_CODE_FK_PK2.VisibleIndex = 1
        Me.colATRSAC_SAC_CODE_FK_PK2.Width = 269
        '
        'lkup_ATRSAC
        '
        Me.lkup_ATRSAC.AutoHeight = False
        Me.lkup_ATRSAC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_ATRSAC.Name = "lkup_ATRSAC"
        '
        'GC14
        '
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
        Me.GC14.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_ATRPR})
        Me.GC14.Size = New System.Drawing.Size(316, 124)
        Me.GC14.TabIndex = 3
        Me.GC14.Tag = "[EDIT][ADD]"
        Me.GC14.UseEmbeddedNavigator = True
        Me.GC14.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV14})
        '
        'GV14
        '
        Me.GV14.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colATRPR_ATR_CODE_FK_PK, Me.colATRPR_PR_CODE_FK_PK, Me.colATRPR_PR_CODE_FK_PK2})
        Me.GV14.GridControl = Me.GC14
        Me.GV14.Name = "GV14"
        Me.GV14.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV14.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV14.OptionsView.ShowGroupPanel = False
        '
        'colATRPR_ATR_CODE_FK_PK
        '
        Me.colATRPR_ATR_CODE_FK_PK.Caption = "ATRPR_ATR_CODE_FK_PK"
        Me.colATRPR_ATR_CODE_FK_PK.FieldName = "ATRPR_ATR_CODE_FK_PK"
        Me.colATRPR_ATR_CODE_FK_PK.Name = "colATRPR_ATR_CODE_FK_PK"
        '
        'colATRPR_PR_CODE_FK_PK
        '
        Me.colATRPR_PR_CODE_FK_PK.Caption = "Code"
        Me.colATRPR_PR_CODE_FK_PK.FieldName = "ATRPR_PR_CODE_FK_PK"
        Me.colATRPR_PR_CODE_FK_PK.Name = "colATRPR_PR_CODE_FK_PK"
        Me.colATRPR_PR_CODE_FK_PK.Visible = True
        Me.colATRPR_PR_CODE_FK_PK.VisibleIndex = 0
        Me.colATRPR_PR_CODE_FK_PK.Width = 50
        '
        'colATRPR_PR_CODE_FK_PK2
        '
        Me.colATRPR_PR_CODE_FK_PK2.Caption = "Produit"
        Me.colATRPR_PR_CODE_FK_PK2.ColumnEdit = Me.lkup_ATRPR
        Me.colATRPR_PR_CODE_FK_PK2.FieldName = "ATRPR_PR_CODE_FK_PK"
        Me.colATRPR_PR_CODE_FK_PK2.Name = "colATRPR_PR_CODE_FK_PK2"
        Me.colATRPR_PR_CODE_FK_PK2.Visible = True
        Me.colATRPR_PR_CODE_FK_PK2.VisibleIndex = 1
        Me.colATRPR_PR_CODE_FK_PK2.Width = 245
        '
        'lkup_ATRPR
        '
        Me.lkup_ATRPR.AutoHeight = False
        Me.lkup_ATRPR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_ATRPR.Name = "lkup_ATRPR"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GC11)
        Me.Panel5.Controls.Add(Me.GC12)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(656, 114)
        Me.Panel5.TabIndex = 18
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
        Me.GC11.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_ATRASMR})
        Me.GC11.Size = New System.Drawing.Size(340, 114)
        Me.GC11.TabIndex = 2
        Me.GC11.Tag = "[EDIT][ADD]"
        Me.GC11.UseEmbeddedNavigator = True
        Me.GC11.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV11})
        '
        'GV11
        '
        Me.GV11.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colATRASMR_ATR_CODE_FK_PK, Me.colATRASMR_CDF_ASMR_CODE_FK_PK, Me.colATRASMR_NUMORD, Me.GridColumn1})
        Me.GV11.GridControl = Me.GC11
        Me.GV11.Name = "GV11"
        Me.GV11.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV11.OptionsView.ShowGroupPanel = False
        '
        'colATRASMR_ATR_CODE_FK_PK
        '
        Me.colATRASMR_ATR_CODE_FK_PK.Caption = "ATRASMR_ATR_CODE_FK_PK"
        Me.colATRASMR_ATR_CODE_FK_PK.FieldName = "ATRASMR_ATR_CODE_FK_PK"
        Me.colATRASMR_ATR_CODE_FK_PK.Name = "colATRASMR_ATR_CODE_FK_PK"
        '
        'colATRASMR_CDF_ASMR_CODE_FK_PK
        '
        Me.colATRASMR_CDF_ASMR_CODE_FK_PK.Caption = "Code"
        Me.colATRASMR_CDF_ASMR_CODE_FK_PK.FieldName = "ATRASMR_CDF_ASMR_CODE_FK_PK"
        Me.colATRASMR_CDF_ASMR_CODE_FK_PK.Name = "colATRASMR_CDF_ASMR_CODE_FK_PK"
        Me.colATRASMR_CDF_ASMR_CODE_FK_PK.Visible = True
        Me.colATRASMR_CDF_ASMR_CODE_FK_PK.VisibleIndex = 0
        Me.colATRASMR_CDF_ASMR_CODE_FK_PK.Width = 40
        '
        'colATRASMR_NUMORD
        '
        Me.colATRASMR_NUMORD.Caption = "N°"
        Me.colATRASMR_NUMORD.FieldName = "ATRASMR_NUMORD"
        Me.colATRASMR_NUMORD.Name = "colATRASMR_NUMORD"
        Me.colATRASMR_NUMORD.Visible = True
        Me.colATRASMR_NUMORD.VisibleIndex = 2
        Me.colATRASMR_NUMORD.Width = 50
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ASMR"
        Me.GridColumn1.ColumnEdit = Me.lkup_ATRASMR
        Me.GridColumn1.FieldName = "ATRASMR_CDF_ASMR_CODE_FK_PK"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 217
        '
        'lkup_ATRASMR
        '
        Me.lkup_ATRASMR.AutoHeight = False
        Me.lkup_ATRASMR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_ATRASMR.Name = "lkup_ATRASMR"
        '
        'GC12
        '
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
        Me.GC12.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_ATRSMR})
        Me.GC12.Size = New System.Drawing.Size(316, 114)
        Me.GC12.TabIndex = 3
        Me.GC12.Tag = "[EDIT][ADD]"
        Me.GC12.UseEmbeddedNavigator = True
        Me.GC12.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV12})
        '
        'GV12
        '
        Me.GV12.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colATRSMR_ATR_CODE_FK_PK, Me.colATRSMR_CDF_SMR_CODE_FK_PK, Me.colATRSMR_NUMORD, Me.colATRSMR_CDF_SMR_CODE_FK_PK2})
        Me.GV12.GridControl = Me.GC12
        Me.GV12.Name = "GV12"
        Me.GV12.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV12.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV12.OptionsView.ShowGroupPanel = False
        '
        'colATRSMR_ATR_CODE_FK_PK
        '
        Me.colATRSMR_ATR_CODE_FK_PK.Caption = "ATRSMR_ATR_CODE_FK_PK"
        Me.colATRSMR_ATR_CODE_FK_PK.FieldName = "ATRSMR_ATR_CODE_FK_PK"
        Me.colATRSMR_ATR_CODE_FK_PK.Name = "colATRSMR_ATR_CODE_FK_PK"
        '
        'colATRSMR_CDF_SMR_CODE_FK_PK
        '
        Me.colATRSMR_CDF_SMR_CODE_FK_PK.Caption = "Code"
        Me.colATRSMR_CDF_SMR_CODE_FK_PK.FieldName = "ATRSMR_CDF_SMR_CODE_FK_PK"
        Me.colATRSMR_CDF_SMR_CODE_FK_PK.Name = "colATRSMR_CDF_SMR_CODE_FK_PK"
        Me.colATRSMR_CDF_SMR_CODE_FK_PK.Visible = True
        Me.colATRSMR_CDF_SMR_CODE_FK_PK.VisibleIndex = 0
        Me.colATRSMR_CDF_SMR_CODE_FK_PK.Width = 39
        '
        'colATRSMR_NUMORD
        '
        Me.colATRSMR_NUMORD.Caption = "N°"
        Me.colATRSMR_NUMORD.FieldName = "ATRSMR_NUMORD"
        Me.colATRSMR_NUMORD.Name = "colATRSMR_NUMORD"
        Me.colATRSMR_NUMORD.Visible = True
        Me.colATRSMR_NUMORD.VisibleIndex = 2
        Me.colATRSMR_NUMORD.Width = 50
        '
        'colATRSMR_CDF_SMR_CODE_FK_PK2
        '
        Me.colATRSMR_CDF_SMR_CODE_FK_PK2.Caption = "SMR"
        Me.colATRSMR_CDF_SMR_CODE_FK_PK2.ColumnEdit = Me.lkup_ATRSMR
        Me.colATRSMR_CDF_SMR_CODE_FK_PK2.FieldName = "ATRSMR_CDF_SMR_CODE_FK_PK"
        Me.colATRSMR_CDF_SMR_CODE_FK_PK2.Name = "colATRSMR_CDF_SMR_CODE_FK_PK2"
        Me.colATRSMR_CDF_SMR_CODE_FK_PK2.Visible = True
        Me.colATRSMR_CDF_SMR_CODE_FK_PK2.VisibleIndex = 1
        Me.colATRSMR_CDF_SMR_CODE_FK_PK2.Width = 195
        '
        'lkup_ATRSMR
        '
        Me.lkup_ATRSMR.AutoHeight = False
        Me.lkup_ATRSMR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_ATRSMR.Name = "lkup_ATRSMR"
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.Controls.Add(Me.MemoEdit1)
        Me.Panel6.Location = New System.Drawing.Point(52, 64)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(445, 70)
        Me.Panel6.TabIndex = 35
        Me.Panel6.Tag = "[ADD][EDIT]"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_CriteresChoix, "ATR_AVISCOMMISSIONTRANSPARENCE.ATR_TEXTE", True))
        Me.MemoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoEdit1.Location = New System.Drawing.Point(0, 0)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(445, 70)
        Me.MemoEdit1.TabIndex = 33
        Me.MemoEdit1.Tag = ""
        '
        'DsTheriaque_CriteresChoix
        '
        Me.DsTheriaque_CriteresChoix.DataSetName = "dsTheriaque_CriteresChoix"
        Me.DsTheriaque_CriteresChoix.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Texte
        '
        Me.Texte.AutoSize = True
        Me.Texte.Location = New System.Drawing.Point(12, 67)
        Me.Texte.Name = "Texte"
        Me.Texte.Size = New System.Drawing.Size(34, 13)
        Me.Texte.TabIndex = 34
        Me.Texte.Text = "Texte"
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_CriteresChoix, "ATR_AVISCOMMISSIONTRANSPARENCE.ATR_CODE_SQ_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(52, 12)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(135, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Tag = "[NOEDIT][NOADD]"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(24, 42)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl5.TabIndex = 13
        Me.LabelControl5.Text = "Titre"
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_CriteresChoix, "ATR_AVISCOMMISSIONTRANSPARENCE.ATR_TITRE", True))
        Me.TextEdit2.Location = New System.Drawing.Point(52, 38)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(495, 20)
        Me.TextEdit2.TabIndex = 14
        Me.TextEdit2.Tag = "[ADD][EDIT]"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(6, 14)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Fiche N°"
        '
        'DateEdit3
        '
        Me.DateEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_CriteresChoix, "ATR_AVISCOMMISSIONTRANSPARENCE.ATR_DATE_REDACTION", True))
        Me.DateEdit3.EditValue = Nothing
        Me.DateEdit3.Location = New System.Drawing.Point(377, 12)
        Me.DateEdit3.Name = "DateEdit3"
        Me.DateEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit3.Size = New System.Drawing.Size(170, 20)
        Me.DateEdit3.TabIndex = 15
        Me.DateEdit3.Tag = "[ADD][EDIT]"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(285, 16)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl4.TabIndex = 11
        Me.LabelControl4.Text = "Date de rédaction"
        '
        'AtR_TA
        '
        Me.AtR_TA.ClearBeforeFill = True
        '
        'AtrasmR_TA
        '
        Me.AtrasmR_TA.ClearBeforeFill = True
        '
        'AtrsmR_TA
        '
        Me.AtrsmR_TA.ClearBeforeFill = True
        '
        'AtrpR_TA
        '
        Me.AtrpR_TA.ClearBeforeFill = True
        '
        'AtrsaC_TA
        '
        Me.AtrsaC_TA.ClearBeforeFill = True
        '
        'SpatR_TA
        '
        Me.SpatR_TA.ClearBeforeFill = True
        '
        'SpsmR_TA
        '
        Me.SpsmR_TA.ClearBeforeFill = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(665, 515)
        Me.TabControl1.TabIndex = 22
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(657, 489)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Commission de la transparence"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PanelControl2)
        Me.TabPage2.Controls.Add(Me.PanelControl1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(657, 489)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Document"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Panel10)
        Me.PanelControl2.Controls.Add(Me.Panel9)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(3, 34)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(651, 452)
        Me.PanelControl2.TabIndex = 10
        Me.PanelControl2.Text = "PanelControl2"
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.gcPropDoc)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(2, 2)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(560, 448)
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
        Me.gcPropDoc.Size = New System.Drawing.Size(560, 448)
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
        Me.Panel9.Location = New System.Drawing.Point(562, 2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(87, 448)
        Me.Panel9.TabIndex = 5
        '
        'cmdAnnuler
        '
        Me.cmdAnnuler.Location = New System.Drawing.Point(6, 215)
        Me.cmdAnnuler.Name = "cmdAnnuler"
        Me.cmdAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnnuler.TabIndex = 8
        Me.cmdAnnuler.Text = "Annu&le"
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
        Me.PanelControl1.Location = New System.Drawing.Point(3, 3)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(651, 31)
        Me.PanelControl1.TabIndex = 9
        Me.PanelControl1.Text = "PanelControl1"
        '
        'bePath
        '
        Me.bePath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bePath.Location = New System.Drawing.Point(5, 5)
        Me.bePath.Name = "bePath"
        Me.bePath.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton("explorer", DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis), New DevExpress.XtraEditors.Controls.EditorButton("effacer", DevExpress.XtraEditors.Controls.ButtonPredefines.Minus)})
        Me.bePath.Size = New System.Drawing.Size(485, 20)
        Me.bePath.TabIndex = 4
        '
        'Frm_Commission_Transparence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(783, 602)
        Me.Name = "Frm_Commission_Transparence"
        Me.Text = "Commission de la transparence"
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
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.GC15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_SPATR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GC13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_ATRSAC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_ATRPR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.GC11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_ATRASMR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_ATRSMR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_CriteresChoix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DsTheriaque_CriteresChoix As Theriaque.dsTheriaque_CriteresChoix
    Friend WithEvents AtR_TA As Theriaque.dsTheriaque_CriteresChoixTableAdapters.ATR_AVISCOMMISSIONTRANSPARENCETableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit3 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GC11 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC12 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AtrasmR_TA As Theriaque.dsTheriaque_CriteresChoixTableAdapters.ATRASMR_AVISCOMTRANS_ASMRTableAdapter
    Friend WithEvents AtrsmR_TA As Theriaque.dsTheriaque_CriteresChoixTableAdapters.ATRSMR_AVISCOMTRANS_SMRTableAdapter
    Friend WithEvents colATRASMR_ATR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colATRASMR_CDF_ASMR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colATRASMR_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_ATRASMR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colATRSMR_ATR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colATRSMR_CDF_SMR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colATRSMR_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colATRSMR_CDF_SMR_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_ATRSMR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GC15 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV15 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GC13 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC14 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colATRSAC_ATR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colATRSAC_SAC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colATRSAC_SAC_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_ATRSAC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colATRPR_ATR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colATRPR_PR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colATRPR_PR_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_ATRPR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents AtrpR_TA As Theriaque.dsTheriaque_CriteresChoixTableAdapters.ATRPR_AVISCOMTRANS_PRODUITTableAdapter
    Friend WithEvents AtrsaC_TA As Theriaque.dsTheriaque_CriteresChoixTableAdapters.ATRSAC_AVISCOMTRANS_SUBACTIVETableAdapter
    Friend WithEvents SpatR_TA As Theriaque.dsTheriaque_CriteresChoixTableAdapters.SPATR_SPEC_AVISTRANSPARENCETableAdapter
    Friend WithEvents colSPATR_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPATR_ATR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPATR_SP_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_SPATR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Texte As System.Windows.Forms.Label
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents SpsmR_TA As Theriaque.dsTheriaque_CriteresChoixTableAdapters.SPSMR_SERVICE_MEDICAL_RENDUTableAdapter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents gcPropDoc As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents meNote As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lueCategorie As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtLibelle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents cmdAnnuler As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bSupprimer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btAperçu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImporter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bePath As DevExpress.XtraEditors.ButtonEdit

End Class
