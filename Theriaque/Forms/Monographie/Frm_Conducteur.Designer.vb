<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Conducteur
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
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.GC5 = New DevExpress.XtraGrid.GridControl
        Me.GV5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCOPR_FCO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCOPR_PR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCOPR_PR_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FCOPR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC6 = New DevExpress.XtraGrid.GridControl
        Me.GV6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCOSP_FCO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCOSP_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCOSP_SP_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FCOSP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.GC3 = New DevExpress.XtraGrid.GridControl
        Me.GV3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCOSAC_FCO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCOSAC_SAC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCOSAC_SAC_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FCOSAC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC4 = New DevExpress.XtraGrid.GridControl
        Me.GV4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCOSAU_FCO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCOSAU_SAU_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCOSAU_SAU_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FCOSAU = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.GC1 = New DevExpress.XtraGrid.GridControl
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCOCPH_FCO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCOCPH_CPH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCOCPH_CPH_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Lkup_FCOCPH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC2 = New DevExpress.XtraGrid.GridControl
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCOCCH_FCO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCOCCH_CCH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCOCCH_CCH_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FCOCCH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GC23 = New DevExpress.XtraGrid.GridControl
        Me.GV23 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCOAFS_FCO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCOAFS_DATE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCOAFS_CDF_DOCUMENT_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FCOAFS = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFCOAFS_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_SPAFS = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.MemoEdit3 = New DevExpress.XtraEditors.MemoEdit
        Me.DsTheriaque_Conducteur = New Theriaque.dsTheriaque_Conducteur
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GC22 = New DevExpress.XtraGrid.GridControl
        Me.GV22 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCOCOM_FCO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCOCOM_CDF_COM_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCOCOM_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FCOCOM = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.GC21 = New DevExpress.XtraGrid.GridControl
        Me.GV21 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCOREC_FCO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCOREC_CDF_REC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCOREC_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkup_FCOREC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.FCO_TA = New Theriaque.dsTheriaque_ConducteurTableAdapters.FCO_CONDUCTEURTableAdapter
        Me.FcocpH_TA = New Theriaque.dsTheriaque_ConducteurTableAdapters.FCOCPH_FCO_CLPHTableAdapter
        Me.FcoccH_TA = New Theriaque.dsTheriaque_ConducteurTableAdapters.FCOCCH_FCO_CLCHTableAdapter
        Me.FcosaC_TA = New Theriaque.dsTheriaque_ConducteurTableAdapters.FCOSAC_FCO_SUBACTTableAdapter
        Me.FcosaU_TA = New Theriaque.dsTheriaque_ConducteurTableAdapters.FCOSAU_FCO_SUBAUXTableAdapter
        Me.FcopR_TA = New Theriaque.dsTheriaque_ConducteurTableAdapters.FCOPR_FCO_PRODTableAdapter
        Me.FcosP_TA = New Theriaque.dsTheriaque_ConducteurTableAdapters.FCOSP_CONDUCTEUR_SPECTableAdapter
        Me.FcoreC_TA = New Theriaque.dsTheriaque_ConducteurTableAdapters.FCOREC_FCO_RECTableAdapter
        Me.FcocoM_TA = New Theriaque.dsTheriaque_ConducteurTableAdapters.FCOCOM_FCO_COMTableAdapter
        Me.FcoafS_TA = New Theriaque.dsTheriaque_ConducteurTableAdapters.FCOAFS_FCO_AFSSAPSTableAdapter
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
        Me.Panel7.SuspendLayout()
        CType(Me.GC5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FCOPR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FCOSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.GC3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FCOSAC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FCOSAU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lkup_FCOCPH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FCOCCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GC23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FCOAFS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_SPAFS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.MemoEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_Conducteur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GC22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FCOCOM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.GC21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkup_FCOREC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Text = "Conducteur"
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
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Conducteur, "FCO_CONDUCTEUR.FCO_DATEMJ", True))
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
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Conducteur, "FCO_CONDUCTEUR.FCO_DATECR", True))
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
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Location = New System.Drawing.Point(4, 46)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(655, 438)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panel7)
        Me.XtraTabPage1.Controls.Add(Me.Panel6)
        Me.XtraTabPage1.Controls.Add(Me.Panel4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(646, 407)
        Me.XtraTabPage1.Text = "Entités"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.GC5)
        Me.Panel7.Controls.Add(Me.GC6)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 274)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(646, 133)
        Me.Panel7.TabIndex = 25
        '
        'GC5
        '
        Me.GC5.DataMember = "FCOPR_FCO_PROD"
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
        Me.GC5.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FCOPR})
        Me.GC5.Size = New System.Drawing.Size(345, 133)
        Me.GC5.TabIndex = 2
        Me.GC5.Tag = "[EDIT][ADD]"
        Me.GC5.UseEmbeddedNavigator = True
        Me.GC5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV5})
        '
        'GV5
        '
        Me.GV5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCOPR_FCO_CODE_FK_PK, Me.colFCOPR_PR_CODE_FK_PK, Me.colFCOPR_PR_CODE_FK_PK2})
        Me.GV5.GridControl = Me.GC5
        Me.GV5.Name = "GV5"
        Me.GV5.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV5.OptionsView.ShowGroupPanel = False
        '
        'colFCOPR_FCO_CODE_FK_PK
        '
        Me.colFCOPR_FCO_CODE_FK_PK.Caption = "FCOPR_FCO_CODE_FK_PK"
        Me.colFCOPR_FCO_CODE_FK_PK.FieldName = "FCOPR_FCO_CODE_FK_PK"
        Me.colFCOPR_FCO_CODE_FK_PK.Name = "colFCOPR_FCO_CODE_FK_PK"
        '
        'colFCOPR_PR_CODE_FK_PK
        '
        Me.colFCOPR_PR_CODE_FK_PK.Caption = "Code"
        Me.colFCOPR_PR_CODE_FK_PK.FieldName = "FCOPR_PR_CODE_FK_PK"
        Me.colFCOPR_PR_CODE_FK_PK.Name = "colFCOPR_PR_CODE_FK_PK"
        Me.colFCOPR_PR_CODE_FK_PK.Visible = True
        Me.colFCOPR_PR_CODE_FK_PK.VisibleIndex = 0
        Me.colFCOPR_PR_CODE_FK_PK.Width = 50
        '
        'colFCOPR_PR_CODE_FK_PK2
        '
        Me.colFCOPR_PR_CODE_FK_PK2.Caption = "Produit"
        Me.colFCOPR_PR_CODE_FK_PK2.ColumnEdit = Me.lkup_FCOPR
        Me.colFCOPR_PR_CODE_FK_PK2.FieldName = "FCOPR_PR_CODE_FK_PK"
        Me.colFCOPR_PR_CODE_FK_PK2.Name = "colFCOPR_PR_CODE_FK_PK2"
        Me.colFCOPR_PR_CODE_FK_PK2.Visible = True
        Me.colFCOPR_PR_CODE_FK_PK2.VisibleIndex = 1
        Me.colFCOPR_PR_CODE_FK_PK2.Width = 274
        '
        'lkup_FCOPR
        '
        Me.lkup_FCOPR.AutoHeight = False
        Me.lkup_FCOPR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FCOPR.Name = "lkup_FCOPR"
        '
        'GC6
        '
        Me.GC6.DataMember = "FCOSP_CONDUCTEUR_SPEC"
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
        Me.GC6.Location = New System.Drawing.Point(345, 0)
        Me.GC6.MainView = Me.GV6
        Me.GC6.Name = "GC6"
        Me.GC6.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FCOSP})
        Me.GC6.Size = New System.Drawing.Size(301, 133)
        Me.GC6.TabIndex = 3
        Me.GC6.Tag = "[EDIT][ADD]"
        Me.GC6.UseEmbeddedNavigator = True
        Me.GC6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV6})
        '
        'GV6
        '
        Me.GV6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCOSP_FCO_CODE_FK_PK, Me.colFCOSP_SP_CODE_FK_PK, Me.colFCOSP_SP_CODE_FK_PK2})
        Me.GV6.GridControl = Me.GC6
        Me.GV6.Name = "GV6"
        Me.GV6.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV6.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV6.OptionsView.ShowGroupPanel = False
        '
        'colFCOSP_FCO_CODE_FK_PK
        '
        Me.colFCOSP_FCO_CODE_FK_PK.Caption = "FCOSP_FCO_CODE_FK_PK"
        Me.colFCOSP_FCO_CODE_FK_PK.FieldName = "FCOSP_FCO_CODE_FK_PK"
        Me.colFCOSP_FCO_CODE_FK_PK.Name = "colFCOSP_FCO_CODE_FK_PK"
        '
        'colFCOSP_SP_CODE_FK_PK
        '
        Me.colFCOSP_SP_CODE_FK_PK.Caption = "Code"
        Me.colFCOSP_SP_CODE_FK_PK.FieldName = "FCOSP_SP_CODE_FK_PK"
        Me.colFCOSP_SP_CODE_FK_PK.Name = "colFCOSP_SP_CODE_FK_PK"
        Me.colFCOSP_SP_CODE_FK_PK.Visible = True
        Me.colFCOSP_SP_CODE_FK_PK.VisibleIndex = 0
        Me.colFCOSP_SP_CODE_FK_PK.Width = 50
        '
        'colFCOSP_SP_CODE_FK_PK2
        '
        Me.colFCOSP_SP_CODE_FK_PK2.Caption = "Spécialités"
        Me.colFCOSP_SP_CODE_FK_PK2.ColumnEdit = Me.lkup_FCOSP
        Me.colFCOSP_SP_CODE_FK_PK2.FieldName = "FCOSP_SP_CODE_FK_PK"
        Me.colFCOSP_SP_CODE_FK_PK2.Name = "colFCOSP_SP_CODE_FK_PK2"
        Me.colFCOSP_SP_CODE_FK_PK2.Visible = True
        Me.colFCOSP_SP_CODE_FK_PK2.VisibleIndex = 1
        Me.colFCOSP_SP_CODE_FK_PK2.Width = 230
        '
        'lkup_FCOSP
        '
        Me.lkup_FCOSP.AutoHeight = False
        Me.lkup_FCOSP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FCOSP.Name = "lkup_FCOSP"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GC3)
        Me.Panel6.Controls.Add(Me.GC4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 137)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(646, 137)
        Me.Panel6.TabIndex = 24
        '
        'GC3
        '
        Me.GC3.DataMember = "FCOSAC_FCO_SUBACT"
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
        Me.GC3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FCOSAC})
        Me.GC3.Size = New System.Drawing.Size(343, 137)
        Me.GC3.TabIndex = 2
        Me.GC3.Tag = "[EDIT][ADD]"
        Me.GC3.UseEmbeddedNavigator = True
        Me.GC3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV3})
        '
        'GV3
        '
        Me.GV3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCOSAC_FCO_CODE_FK_PK, Me.colFCOSAC_SAC_CODE_FK_PK, Me.colFCOSAC_SAC_CODE_FK_PK2})
        Me.GV3.GridControl = Me.GC3
        Me.GV3.Name = "GV3"
        Me.GV3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV3.OptionsView.ShowGroupPanel = False
        '
        'colFCOSAC_FCO_CODE_FK_PK
        '
        Me.colFCOSAC_FCO_CODE_FK_PK.Caption = "FCOSAC_FCO_CODE_FK_PK"
        Me.colFCOSAC_FCO_CODE_FK_PK.FieldName = "FCOSAC_FCO_CODE_FK_PK"
        Me.colFCOSAC_FCO_CODE_FK_PK.Name = "colFCOSAC_FCO_CODE_FK_PK"
        '
        'colFCOSAC_SAC_CODE_FK_PK
        '
        Me.colFCOSAC_SAC_CODE_FK_PK.Caption = "Code"
        Me.colFCOSAC_SAC_CODE_FK_PK.FieldName = "FCOSAC_SAC_CODE_FK_PK"
        Me.colFCOSAC_SAC_CODE_FK_PK.Name = "colFCOSAC_SAC_CODE_FK_PK"
        Me.colFCOSAC_SAC_CODE_FK_PK.Visible = True
        Me.colFCOSAC_SAC_CODE_FK_PK.VisibleIndex = 0
        Me.colFCOSAC_SAC_CODE_FK_PK.Width = 50
        '
        'colFCOSAC_SAC_CODE_FK_PK2
        '
        Me.colFCOSAC_SAC_CODE_FK_PK2.Caption = "Substance active"
        Me.colFCOSAC_SAC_CODE_FK_PK2.ColumnEdit = Me.lkup_FCOSAC
        Me.colFCOSAC_SAC_CODE_FK_PK2.FieldName = "FCOSAC_SAC_CODE_FK_PK"
        Me.colFCOSAC_SAC_CODE_FK_PK2.Name = "colFCOSAC_SAC_CODE_FK_PK2"
        Me.colFCOSAC_SAC_CODE_FK_PK2.Visible = True
        Me.colFCOSAC_SAC_CODE_FK_PK2.VisibleIndex = 1
        Me.colFCOSAC_SAC_CODE_FK_PK2.Width = 275
        '
        'lkup_FCOSAC
        '
        Me.lkup_FCOSAC.AutoHeight = False
        Me.lkup_FCOSAC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FCOSAC.Name = "lkup_FCOSAC"
        '
        'GC4
        '
        Me.GC4.DataMember = "FCOSAU_FCO_SUBAUX"
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
        Me.GC4.Location = New System.Drawing.Point(343, 0)
        Me.GC4.MainView = Me.GV4
        Me.GC4.Name = "GC4"
        Me.GC4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FCOSAU})
        Me.GC4.Size = New System.Drawing.Size(303, 137)
        Me.GC4.TabIndex = 3
        Me.GC4.Tag = "[EDIT][ADD]"
        Me.GC4.UseEmbeddedNavigator = True
        Me.GC4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV4})
        '
        'GV4
        '
        Me.GV4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCOSAU_FCO_CODE_FK_PK, Me.colFCOSAU_SAU_CODE_FK_PK, Me.colFCOSAU_SAU_CODE_FK_PK2})
        Me.GV4.GridControl = Me.GC4
        Me.GV4.Name = "GV4"
        Me.GV4.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV4.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV4.OptionsView.ShowGroupPanel = False
        '
        'colFCOSAU_FCO_CODE_FK_PK
        '
        Me.colFCOSAU_FCO_CODE_FK_PK.Caption = "FCOSAU_FCO_CODE_FK_PK"
        Me.colFCOSAU_FCO_CODE_FK_PK.FieldName = "FCOSAU_FCO_CODE_FK_PK"
        Me.colFCOSAU_FCO_CODE_FK_PK.Name = "colFCOSAU_FCO_CODE_FK_PK"
        '
        'colFCOSAU_SAU_CODE_FK_PK
        '
        Me.colFCOSAU_SAU_CODE_FK_PK.Caption = "Code"
        Me.colFCOSAU_SAU_CODE_FK_PK.FieldName = "FCOSAU_SAU_CODE_FK_PK"
        Me.colFCOSAU_SAU_CODE_FK_PK.Name = "colFCOSAU_SAU_CODE_FK_PK"
        Me.colFCOSAU_SAU_CODE_FK_PK.Visible = True
        Me.colFCOSAU_SAU_CODE_FK_PK.VisibleIndex = 0
        Me.colFCOSAU_SAU_CODE_FK_PK.Width = 50
        '
        'colFCOSAU_SAU_CODE_FK_PK2
        '
        Me.colFCOSAU_SAU_CODE_FK_PK2.Caption = "Excipient"
        Me.colFCOSAU_SAU_CODE_FK_PK2.ColumnEdit = Me.lkup_FCOSAU
        Me.colFCOSAU_SAU_CODE_FK_PK2.FieldName = "FCOSAU_SAU_CODE_FK_PK"
        Me.colFCOSAU_SAU_CODE_FK_PK2.Name = "colFCOSAU_SAU_CODE_FK_PK2"
        Me.colFCOSAU_SAU_CODE_FK_PK2.Visible = True
        Me.colFCOSAU_SAU_CODE_FK_PK2.VisibleIndex = 1
        Me.colFCOSAU_SAU_CODE_FK_PK2.Width = 232
        '
        'lkup_FCOSAU
        '
        Me.lkup_FCOSAU.AutoHeight = False
        Me.lkup_FCOSAU.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FCOSAU.Name = "lkup_FCOSAU"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GC1)
        Me.Panel4.Controls.Add(Me.GC2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(646, 137)
        Me.Panel4.TabIndex = 23
        '
        'GC1
        '
        Me.GC1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC1.DataMember = "FCOCPH_FCO_CLPH"
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
        Me.GC1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Lkup_FCOCPH})
        Me.GC1.Size = New System.Drawing.Size(343, 137)
        Me.GC1.TabIndex = 2
        Me.GC1.Tag = "[EDIT][ADD]"
        Me.GC1.UseEmbeddedNavigator = True
        Me.GC1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCOCPH_FCO_CODE_FK_PK, Me.colFCOCPH_CPH_CODE_FK_PK, Me.colFCOCPH_CPH_CODE_FK_PK2})
        Me.GV1.GridControl = Me.GC1
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV1.OptionsView.ShowGroupPanel = False
        '
        'colFCOCPH_FCO_CODE_FK_PK
        '
        Me.colFCOCPH_FCO_CODE_FK_PK.Caption = "FCOCPH_FCO_CODE_FK_PK"
        Me.colFCOCPH_FCO_CODE_FK_PK.FieldName = "FCOCPH_FCO_CODE_FK_PK"
        Me.colFCOCPH_FCO_CODE_FK_PK.Name = "colFCOCPH_FCO_CODE_FK_PK"
        '
        'colFCOCPH_CPH_CODE_FK_PK
        '
        Me.colFCOCPH_CPH_CODE_FK_PK.Caption = "Code"
        Me.colFCOCPH_CPH_CODE_FK_PK.FieldName = "FCOCPH_CPH_CODE_FK_PK"
        Me.colFCOCPH_CPH_CODE_FK_PK.Name = "colFCOCPH_CPH_CODE_FK_PK"
        Me.colFCOCPH_CPH_CODE_FK_PK.Visible = True
        Me.colFCOCPH_CPH_CODE_FK_PK.VisibleIndex = 0
        Me.colFCOCPH_CPH_CODE_FK_PK.Width = 50
        '
        'colFCOCPH_CPH_CODE_FK_PK2
        '
        Me.colFCOCPH_CPH_CODE_FK_PK2.Caption = "Classe pharmaco-thérapeutique"
        Me.colFCOCPH_CPH_CODE_FK_PK2.ColumnEdit = Me.Lkup_FCOCPH
        Me.colFCOCPH_CPH_CODE_FK_PK2.FieldName = "FCOCPH_CPH_CODE_FK_PK"
        Me.colFCOCPH_CPH_CODE_FK_PK2.Name = "colFCOCPH_CPH_CODE_FK_PK2"
        Me.colFCOCPH_CPH_CODE_FK_PK2.Visible = True
        Me.colFCOCPH_CPH_CODE_FK_PK2.VisibleIndex = 1
        Me.colFCOCPH_CPH_CODE_FK_PK2.Width = 272
        '
        'Lkup_FCOCPH
        '
        Me.Lkup_FCOCPH.AutoHeight = False
        Me.Lkup_FCOCPH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lkup_FCOCPH.Name = "Lkup_FCOCPH"
        '
        'GC2
        '
        Me.GC2.DataMember = "FCOCCH_FCO_CLCH"
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
        Me.GC2.Location = New System.Drawing.Point(343, 0)
        Me.GC2.MainView = Me.GV2
        Me.GC2.Name = "GC2"
        Me.GC2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FCOCCH})
        Me.GC2.Size = New System.Drawing.Size(303, 137)
        Me.GC2.TabIndex = 3
        Me.GC2.Tag = "[EDIT][ADD]"
        Me.GC2.UseEmbeddedNavigator = True
        Me.GC2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCOCCH_FCO_CODE_FK_PK, Me.colFCOCCH_CCH_CODE_FK_PK, Me.colFCOCCH_CCH_CODE_FK_PK2})
        Me.GV2.GridControl = Me.GC2
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV2.OptionsView.ShowGroupPanel = False
        '
        'colFCOCCH_FCO_CODE_FK_PK
        '
        Me.colFCOCCH_FCO_CODE_FK_PK.Caption = "FCOCCH_FCO_CODE_FK_PK"
        Me.colFCOCCH_FCO_CODE_FK_PK.FieldName = "FCOCCH_FCO_CODE_FK_PK"
        Me.colFCOCCH_FCO_CODE_FK_PK.Name = "colFCOCCH_FCO_CODE_FK_PK"
        '
        'colFCOCCH_CCH_CODE_FK_PK
        '
        Me.colFCOCCH_CCH_CODE_FK_PK.Caption = "Code"
        Me.colFCOCCH_CCH_CODE_FK_PK.FieldName = "FCOCCH_CCH_CODE_FK_PK"
        Me.colFCOCCH_CCH_CODE_FK_PK.Name = "colFCOCCH_CCH_CODE_FK_PK"
        Me.colFCOCCH_CCH_CODE_FK_PK.Visible = True
        Me.colFCOCCH_CCH_CODE_FK_PK.VisibleIndex = 0
        Me.colFCOCCH_CCH_CODE_FK_PK.Width = 50
        '
        'colFCOCCH_CCH_CODE_FK_PK2
        '
        Me.colFCOCCH_CCH_CODE_FK_PK2.Caption = "Classe chimique"
        Me.colFCOCCH_CCH_CODE_FK_PK2.ColumnEdit = Me.lkup_FCOCCH
        Me.colFCOCCH_CCH_CODE_FK_PK2.FieldName = "FCOCCH_CCH_CODE_FK_PK"
        Me.colFCOCCH_CCH_CODE_FK_PK2.Name = "colFCOCCH_CCH_CODE_FK_PK2"
        Me.colFCOCCH_CCH_CODE_FK_PK2.Visible = True
        Me.colFCOCCH_CCH_CODE_FK_PK2.VisibleIndex = 1
        Me.colFCOCCH_CCH_CODE_FK_PK2.Width = 232
        '
        'lkup_FCOCCH
        '
        Me.lkup_FCOCCH.AutoHeight = False
        Me.lkup_FCOCCH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FCOCCH.Name = "lkup_FCOCCH"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Panel9)
        Me.XtraTabPage2.Controls.Add(Me.Panel5)
        Me.XtraTabPage2.Controls.Add(Me.Panel2)
        Me.XtraTabPage2.Controls.Add(Me.Panel8)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(646, 407)
        Me.XtraTabPage2.Text = "Conducteur véhicule / Utilisateur machine"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Panel3)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(0, 301)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(646, 106)
        Me.Panel9.TabIndex = 42
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GC23)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(646, 106)
        Me.Panel3.TabIndex = 26
        '
        'GC23
        '
        Me.GC23.DataMember = "FCOAFS_FCO_AFSSAPS"
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
        Me.GC23.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FCOAFS, Me.lkup_SPAFS})
        Me.GC23.Size = New System.Drawing.Size(646, 106)
        Me.GC23.TabIndex = 2
        Me.GC23.Tag = "[EDIT][ADD]"
        Me.GC23.UseEmbeddedNavigator = True
        Me.GC23.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV23})
        '
        'GV23
        '
        Me.GV23.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCOAFS_FCO_CODE_FK_PK, Me.colFCOAFS_DATE_PK, Me.colFCOAFS_CDF_DOCUMENT_FK_PK, Me.colFCOAFS_SP_CODE_FK_PK})
        Me.GV23.GridControl = Me.GC23
        Me.GV23.Name = "GV23"
        Me.GV23.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV23.OptionsView.ShowGroupPanel = False
        '
        'colFCOAFS_FCO_CODE_FK_PK
        '
        Me.colFCOAFS_FCO_CODE_FK_PK.Caption = "FCOAFS_FCO_CODE_FK_PK"
        Me.colFCOAFS_FCO_CODE_FK_PK.FieldName = "FCOAFS_FCO_CODE_FK_PK"
        Me.colFCOAFS_FCO_CODE_FK_PK.Name = "colFCOAFS_FCO_CODE_FK_PK"
        '
        'colFCOAFS_DATE_PK
        '
        Me.colFCOAFS_DATE_PK.Caption = "Date"
        Me.colFCOAFS_DATE_PK.FieldName = "FCOAFS_DATE_PK"
        Me.colFCOAFS_DATE_PK.Name = "colFCOAFS_DATE_PK"
        Me.colFCOAFS_DATE_PK.Visible = True
        Me.colFCOAFS_DATE_PK.VisibleIndex = 1
        Me.colFCOAFS_DATE_PK.Width = 76
        '
        'colFCOAFS_CDF_DOCUMENT_FK_PK
        '
        Me.colFCOAFS_CDF_DOCUMENT_FK_PK.Caption = "Références officielles"
        Me.colFCOAFS_CDF_DOCUMENT_FK_PK.ColumnEdit = Me.lkup_FCOAFS
        Me.colFCOAFS_CDF_DOCUMENT_FK_PK.FieldName = "FCOAFS_CDF_DOCUMENT_FK_PK"
        Me.colFCOAFS_CDF_DOCUMENT_FK_PK.Name = "colFCOAFS_CDF_DOCUMENT_FK_PK"
        Me.colFCOAFS_CDF_DOCUMENT_FK_PK.Visible = True
        Me.colFCOAFS_CDF_DOCUMENT_FK_PK.VisibleIndex = 0
        Me.colFCOAFS_CDF_DOCUMENT_FK_PK.Width = 195
        '
        'lkup_FCOAFS
        '
        Me.lkup_FCOAFS.AutoHeight = False
        Me.lkup_FCOAFS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FCOAFS.Name = "lkup_FCOAFS"
        '
        'colFCOAFS_SP_CODE_FK_PK
        '
        Me.colFCOAFS_SP_CODE_FK_PK.Caption = "Spécialités"
        Me.colFCOAFS_SP_CODE_FK_PK.ColumnEdit = Me.lkup_SPAFS
        Me.colFCOAFS_SP_CODE_FK_PK.FieldName = "FCOAFS_SP_CODE_FK_PK"
        Me.colFCOAFS_SP_CODE_FK_PK.Name = "colFCOAFS_SP_CODE_FK_PK"
        Me.colFCOAFS_SP_CODE_FK_PK.Visible = True
        Me.colFCOAFS_SP_CODE_FK_PK.VisibleIndex = 2
        Me.colFCOAFS_SP_CODE_FK_PK.Width = 201
        '
        'lkup_SPAFS
        '
        Me.lkup_SPAFS.AutoHeight = False
        Me.lkup_SPAFS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_SPAFS.Name = "lkup_SPAFS"
        Me.lkup_SPAFS.NullText = ""
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel10)
        Me.Panel5.Controls.Add(Me.Panel11)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 213)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(646, 88)
        Me.Panel5.TabIndex = 41
        Me.Panel5.Tag = ""
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.MemoEdit3)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(0, 24)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(646, 64)
        Me.Panel10.TabIndex = 38
        Me.Panel10.Tag = "[ADD][EDIT]"
        '
        'MemoEdit3
        '
        Me.MemoEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Conducteur, "FCO_CONDUCTEUR.FCO_TXT", True))
        Me.MemoEdit3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoEdit3.Location = New System.Drawing.Point(0, 0)
        Me.MemoEdit3.Name = "MemoEdit3"
        Me.MemoEdit3.Size = New System.Drawing.Size(646, 64)
        Me.MemoEdit3.TabIndex = 36
        Me.MemoEdit3.Tag = ""
        '
        'DsTheriaque_Conducteur
        '
        Me.DsTheriaque_Conducteur.DataSetName = "dsTheriaque_Conducteur"
        Me.DsTheriaque_Conducteur.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.LabelControl7)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(646, 24)
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GC22)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 107)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(646, 106)
        Me.Panel2.TabIndex = 25
        '
        'GC22
        '
        Me.GC22.DataMember = "FCOCOM_FCO_COM"
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
        Me.GC22.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FCOCOM})
        Me.GC22.Size = New System.Drawing.Size(646, 106)
        Me.GC22.TabIndex = 2
        Me.GC22.Tag = "[EDIT][ADD]"
        Me.GC22.UseEmbeddedNavigator = True
        Me.GC22.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV22})
        '
        'GV22
        '
        Me.GV22.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCOCOM_FCO_CODE_FK_PK, Me.colFCOCOM_CDF_COM_CODE_FK_PK, Me.colFCOCOM_NUMORD, Me.GridColumn8})
        Me.GV22.GridControl = Me.GC22
        Me.GV22.Name = "GV22"
        Me.GV22.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV22.OptionsView.ShowGroupPanel = False
        Me.GV22.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFCOCOM_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFCOCOM_FCO_CODE_FK_PK
        '
        Me.colFCOCOM_FCO_CODE_FK_PK.Caption = "FCOCOM_FCO_CODE_FK_PK"
        Me.colFCOCOM_FCO_CODE_FK_PK.FieldName = "FCOCOM_FCO_CODE_FK_PK"
        Me.colFCOCOM_FCO_CODE_FK_PK.Name = "colFCOCOM_FCO_CODE_FK_PK"
        '
        'colFCOCOM_CDF_COM_CODE_FK_PK
        '
        Me.colFCOCOM_CDF_COM_CODE_FK_PK.Caption = "Code"
        Me.colFCOCOM_CDF_COM_CODE_FK_PK.FieldName = "FCOCOM_CDF_COM_CODE_FK_PK"
        Me.colFCOCOM_CDF_COM_CODE_FK_PK.Name = "colFCOCOM_CDF_COM_CODE_FK_PK"
        Me.colFCOCOM_CDF_COM_CODE_FK_PK.Width = 44
        '
        'colFCOCOM_NUMORD
        '
        Me.colFCOCOM_NUMORD.Caption = "N°"
        Me.colFCOCOM_NUMORD.FieldName = "FCOCOM_NUMORD"
        Me.colFCOCOM_NUMORD.Name = "colFCOCOM_NUMORD"
        Me.colFCOCOM_NUMORD.Visible = True
        Me.colFCOCOM_NUMORD.VisibleIndex = 1
        Me.colFCOCOM_NUMORD.Width = 50
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Commentaires autres"
        Me.GridColumn8.ColumnEdit = Me.lkup_FCOCOM
        Me.GridColumn8.FieldName = "FCOCOM_CDF_COM_CODE_FK_PK"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 0
        Me.GridColumn8.Width = 513
        '
        'lkup_FCOCOM
        '
        Me.lkup_FCOCOM.AutoHeight = False
        Me.lkup_FCOCOM.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FCOCOM.Name = "lkup_FCOCOM"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.GC21)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(646, 107)
        Me.Panel8.TabIndex = 24
        '
        'GC21
        '
        Me.GC21.DataMember = "FCOREC_FCO_REC"
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
        Me.GC21.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkup_FCOREC})
        Me.GC21.Size = New System.Drawing.Size(646, 107)
        Me.GC21.TabIndex = 2
        Me.GC21.Tag = "[EDIT][ADD]"
        Me.GC21.UseEmbeddedNavigator = True
        Me.GC21.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV21})
        '
        'GV21
        '
        Me.GV21.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCOREC_FCO_CODE_FK_PK, Me.colFCOREC_CDF_REC_CODE_FK_PK, Me.colFCOREC_NUMORD, Me.GridColumn7})
        Me.GV21.GridControl = Me.GC21
        Me.GV21.Name = "GV21"
        Me.GV21.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV21.OptionsView.ShowGroupPanel = False
        Me.GV21.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFCOREC_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFCOREC_FCO_CODE_FK_PK
        '
        Me.colFCOREC_FCO_CODE_FK_PK.Caption = "FCOREC_FCO_CODE_FK_PK"
        Me.colFCOREC_FCO_CODE_FK_PK.FieldName = "FCOREC_FCO_CODE_FK_PK"
        Me.colFCOREC_FCO_CODE_FK_PK.Name = "colFCOREC_FCO_CODE_FK_PK"
        '
        'colFCOREC_CDF_REC_CODE_FK_PK
        '
        Me.colFCOREC_CDF_REC_CODE_FK_PK.Caption = "Code"
        Me.colFCOREC_CDF_REC_CODE_FK_PK.FieldName = "FCOREC_CDF_REC_CODE_FK_PK"
        Me.colFCOREC_CDF_REC_CODE_FK_PK.Name = "colFCOREC_CDF_REC_CODE_FK_PK"
        Me.colFCOREC_CDF_REC_CODE_FK_PK.Width = 44
        '
        'colFCOREC_NUMORD
        '
        Me.colFCOREC_NUMORD.Caption = "N°"
        Me.colFCOREC_NUMORD.FieldName = "FCOREC_NUMORD"
        Me.colFCOREC_NUMORD.Name = "colFCOREC_NUMORD"
        Me.colFCOREC_NUMORD.Visible = True
        Me.colFCOREC_NUMORD.VisibleIndex = 1
        Me.colFCOREC_NUMORD.Width = 50
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Recommandation(s)"
        Me.GridColumn7.ColumnEdit = Me.lkup_FCOREC
        Me.GridColumn7.FieldName = "FCOREC_CDF_REC_CODE_FK_PK"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        Me.GridColumn7.Width = 513
        '
        'lkup_FCOREC
        '
        Me.lkup_FCOREC.AutoHeight = False
        Me.lkup_FCOREC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkup_FCOREC.Name = "lkup_FCOREC"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(662, 42)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Conducteur, "FCO_CONDUCTEUR.FCO_CODE_SQ_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(92, 13)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(135, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Tag = "[NOEDIT][NOADD]"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(46, 16)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Fiche N°"
        '
        'FCO_TA
        '
        Me.FCO_TA.ClearBeforeFill = True
        '
        'FcocpH_TA
        '
        Me.FcocpH_TA.ClearBeforeFill = True
        '
        'FcoccH_TA
        '
        Me.FcoccH_TA.ClearBeforeFill = True
        '
        'FcosaC_TA
        '
        Me.FcosaC_TA.ClearBeforeFill = True
        '
        'FcosaU_TA
        '
        Me.FcosaU_TA.ClearBeforeFill = True
        '
        'FcopR_TA
        '
        Me.FcopR_TA.ClearBeforeFill = True
        '
        'FcosP_TA
        '
        Me.FcosP_TA.ClearBeforeFill = True
        '
        'FcoreC_TA
        '
        Me.FcoreC_TA.ClearBeforeFill = True
        '
        'FcocoM_TA
        '
        Me.FcocoM_TA.ClearBeforeFill = True
        '
        'FcoafS_TA
        '
        Me.FcoafS_TA.ClearBeforeFill = True
        '
        'Frm_Conducteur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(780, 574)
        Me.Name = "Frm_Conducteur"
        Me.Text = "Conducteur"
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
        Me.Panel7.ResumeLayout(False)
        CType(Me.GC5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FCOPR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FCOSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.GC3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FCOSAC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FCOSAU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lkup_FCOCPH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FCOCCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.GC23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FCOAFS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_SPAFS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        CType(Me.MemoEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_Conducteur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GC22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FCOCOM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        CType(Me.GC21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkup_FCOREC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GC1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents GC3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents GC5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC6 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsTheriaque_Conducteur As Theriaque.dsTheriaque_Conducteur
    Friend WithEvents FCO_TA As Theriaque.dsTheriaque_ConducteurTableAdapters.FCO_CONDUCTEURTableAdapter
    Friend WithEvents FcocpH_TA As Theriaque.dsTheriaque_ConducteurTableAdapters.FCOCPH_FCO_CLPHTableAdapter
    Friend WithEvents colFCOCPH_FCO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCOCPH_CPH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCOCPH_CPH_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Lkup_FCOCPH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FcoccH_TA As Theriaque.dsTheriaque_ConducteurTableAdapters.FCOCCH_FCO_CLCHTableAdapter
    Friend WithEvents colFCOCCH_FCO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCOCCH_CCH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCOCCH_CCH_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FCOCCH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFCOSAC_FCO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCOSAC_SAC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCOSAC_SAC_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FCOSAC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FcosaC_TA As Theriaque.dsTheriaque_ConducteurTableAdapters.FCOSAC_FCO_SUBACTTableAdapter
    Friend WithEvents FcosaU_TA As Theriaque.dsTheriaque_ConducteurTableAdapters.FCOSAU_FCO_SUBAUXTableAdapter
    Friend WithEvents colFCOSAU_FCO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCOSAU_SAU_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCOSAU_SAU_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FCOSAU As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFCOPR_FCO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCOPR_PR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCOPR_PR_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FCOPR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FcopR_TA As Theriaque.dsTheriaque_ConducteurTableAdapters.FCOPR_FCO_PRODTableAdapter
    Friend WithEvents colFCOSP_FCO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCOSP_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCOSP_SP_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FCOSP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FcosP_TA As Theriaque.dsTheriaque_ConducteurTableAdapters.FCOSP_CONDUCTEUR_SPECTableAdapter
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GC23 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV23 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GC22 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV22 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents GC21 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV21 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFCOREC_FCO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCOREC_CDF_REC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCOREC_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FcoreC_TA As Theriaque.dsTheriaque_ConducteurTableAdapters.FCOREC_FCO_RECTableAdapter
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FCOREC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FcocoM_TA As Theriaque.dsTheriaque_ConducteurTableAdapters.FCOCOM_FCO_COMTableAdapter
    Friend WithEvents colFCOCOM_FCO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCOCOM_CDF_COM_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCOCOM_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FCOCOM As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FcoafS_TA As Theriaque.dsTheriaque_ConducteurTableAdapters.FCOAFS_FCO_AFSSAPSTableAdapter
    Friend WithEvents colFCOAFS_FCO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCOAFS_DATE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCOAFS_CDF_DOCUMENT_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_FCOAFS As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFCOAFS_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkup_SPAFS As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents MemoEdit3 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel9 As System.Windows.Forms.Panel

End Class
