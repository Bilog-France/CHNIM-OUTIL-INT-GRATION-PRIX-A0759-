<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MedVirtuellePere
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
        Me.colMVPRMV_MVPR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.DsTheriaque_Nomenclature2 = New Theriaque.dsTheriaque_Nomenclature2
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSYMVPR_LIBELLE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSYMVPR_MVPR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSYMVPR_CODE_SQ_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.savLibl = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.txtLibelle = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GC2 = New DevExpress.XtraGrid.GridControl
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colMVPRMV_MV_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGSP_NOM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpGSP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.rpCheck = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.fovlib = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.savlib = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.cdfnom = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GsP_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.GSP_GENERIQUE_SPECIALITETableAdapter
        Me.SP_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.SP_SPECIALITETableAdapter
        Me.XtraTabControl3 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFOV_LIBELLE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fovlibelle = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colMVPRFOV_MVPR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colMVPRSAV_Libelle = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMVPRSAV_NUM_ORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMVPRSAV_MVPR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.DateDispoEdit3 = New DevExpress.XtraEditors.DateEdit
        Me.statutEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.MVPSDU = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.MVPSDU_MED_VIR_PERE_SATableAdapter
        Me.IC1SP_TERME1SPECIALITETableAdapter1 = New Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.IC1SP_TERME1SPECIALITETableAdapter
        Me.MVPF = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.MVPF_MED_VIR_PERE_FORMETableAdapter
        Me.Label3 = New System.Windows.Forms.Label
        Me.MVPR = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.MVPR_MEDICAMENT_VIRTUEL_PERETableAdapter
        Me.DateEdit3 = New DevExpress.XtraEditors.DateEdit
        Me.SYMVPR = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.SYMVPR_SYN_MEDIC_VIRTUEL_PERETableAdapter
        Me.MVPRMV = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.MVPRMV_MED_VIR_VIR_PERETableAdapter
        Me.MVPRSAV = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.MVPRSAV_MED_VIR_PERE_SUBSTANCE_VIRTUELLETableAdapter
        Me.MVPRFOV = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.MVPRFOV_MED_VIR_PERE_FORME_VIRTUELLETableAdapter
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
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_Nomenclature2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.savLibl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpGSP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fovlib, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.savlib, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cdfnom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl3.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fovlibelle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateDispoEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.statutEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(679, 641)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.Label3)
        Me.PanMain.Controls.Add(Me.statutEdit)
        Me.PanMain.Controls.Add(Me.DateEdit3)
        Me.PanMain.Controls.Add(Me.DateDispoEdit3)
        Me.PanMain.Controls.Add(Me.Label8)
        Me.PanMain.Controls.Add(Me.Label7)
        Me.PanMain.Controls.Add(Me.XtraTabControl3)
        Me.PanMain.Controls.Add(Me.Label2)
        Me.PanMain.Controls.Add(Me.txtCode)
        Me.PanMain.Controls.Add(Me.txtLibelle)
        Me.PanMain.Controls.Add(Me.Label6)
        Me.PanMain.Size = New System.Drawing.Size(561, 554)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(679, 87)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(679, 28)
        Me.Label1.Text = "Médicament virtuel père"
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
        Me.Panel1.Location = New System.Drawing.Point(561, 87)
        Me.Panel1.Size = New System.Drawing.Size(118, 554)
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "MVPR_MEDICAMENT_VIRTUEL_PERE.MVPR_DATEMJ", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Size = New System.Drawing.Size(679, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "MVPR_MEDICAMENT_VIRTUEL_PERE.MVPR_DATECR", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        '
        'colMVPRMV_MVPR_CODE_FK_PK
        '
        Me.colMVPRMV_MVPR_CODE_FK_PK.Caption = "MVPRMV_MVPR_CODE_FK_PK"
        Me.colMVPRMV_MVPR_CODE_FK_PK.FieldName = "MVPRMV_MVPR_CODE_FK_PK"
        Me.colMVPRMV_MVPR_CODE_FK_PK.Name = "colMVPRMV_MVPR_CODE_FK_PK"
        Me.colMVPRMV_MVPR_CODE_FK_PK.Width = 50
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 7)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(547, 152)
        Me.XtraTabControl1.TabIndex = 31
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        Me.XtraTabControl1.Tag = "[EDIT][NOADD]"
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GC)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(538, 121)
        Me.XtraTabPage1.Tag = "[EDIT][ADD]"
        Me.XtraTabPage1.Text = "Synonymes"
        '
        'GC
        '
        Me.GC.DataMember = "SYMVPR_SYN_MEDIC_VIRTUEL_PERE"
        Me.GC.DataSource = Me.DsTheriaque_Nomenclature2
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
        Me.GC.Location = New System.Drawing.Point(0, 0)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.savLibl})
        Me.GC.Size = New System.Drawing.Size(538, 121)
        Me.GC.TabIndex = 0
        Me.GC.Tag = ""
        Me.GC.UseEmbeddedNavigator = True
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'DsTheriaque_Nomenclature2
        '
        Me.DsTheriaque_Nomenclature2.DataSetName = "dsTheriaque_Nomenclature2"
        Me.DsTheriaque_Nomenclature2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSYMVPR_LIBELLE, Me.colSYMVPR_MVPR_CODE_FK_PK, Me.colSYMVPR_CODE_SQ_PK})
        Me.GV.GridControl = Me.GC
        Me.GV.GroupPanelText = " "
        Me.GV.Name = "GV"
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'colSYMVPR_LIBELLE
        '
        Me.colSYMVPR_LIBELLE.Caption = "Libellé"
        Me.colSYMVPR_LIBELLE.FieldName = "SYMVPR_LIBELLE"
        Me.colSYMVPR_LIBELLE.Name = "colSYMVPR_LIBELLE"
        Me.colSYMVPR_LIBELLE.Visible = True
        Me.colSYMVPR_LIBELLE.VisibleIndex = 0
        '
        'colSYMVPR_MVPR_CODE_FK_PK
        '
        Me.colSYMVPR_MVPR_CODE_FK_PK.Caption = "SYMVPR_MVPR_CODE_FK_PK"
        Me.colSYMVPR_MVPR_CODE_FK_PK.FieldName = "SYMVPR_MVPR_CODE_FK_PK"
        Me.colSYMVPR_MVPR_CODE_FK_PK.Name = "colSYMVPR_MVPR_CODE_FK_PK"
        '
        'colSYMVPR_CODE_SQ_PK
        '
        Me.colSYMVPR_CODE_SQ_PK.Caption = "SYGSP_NUMORD"
        Me.colSYMVPR_CODE_SQ_PK.FieldName = "SYMVPR_CODE_SQ_PK"
        Me.colSYMVPR_CODE_SQ_PK.Name = "colSYMVPR_CODE_SQ_PK"
        '
        'savLibl
        '
        Me.savLibl.AutoHeight = False
        Me.savLibl.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.savLibl.Name = "savLibl"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "N° Codif"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "MVPR_MEDICAMENT_VIRTUEL_PERE.MVPR_CODE_SQ_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(92, 13)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.txtCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Properties.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(99, 20)
        Me.txtCode.TabIndex = 28
        Me.txtCode.TabStop = False
        Me.txtCode.Tag = ""
        '
        'txtLibelle
        '
        Me.txtLibelle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLibelle.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "MVPR_MEDICAMENT_VIRTUEL_PERE.MVPR_LIBELLE", True))
        Me.txtLibelle.Location = New System.Drawing.Point(92, 62)
        Me.txtLibelle.Name = "txtLibelle"
        Me.txtLibelle.Size = New System.Drawing.Size(357, 20)
        Me.txtLibelle.TabIndex = 25
        Me.txtLibelle.Tag = "[EDIT]"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Libellé"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Location = New System.Drawing.Point(2, 164)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage2
        Me.XtraTabControl2.Size = New System.Drawing.Size(541, 251)
        Me.XtraTabControl2.TabIndex = 32
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2})
        Me.XtraTabControl2.Tag = "[EDIT][ADD]"
        Me.XtraTabControl2.Text = "XtraTabControl2"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GC2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(532, 220)
        Me.XtraTabPage2.Tag = "[EDIT][ADD]"
        Me.XtraTabPage2.Text = "Fils"
        '
        'GC2
        '
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
        Me.GC2.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GC2.EmbeddedNavigator.CustomButtons.AddRange(New DevExpress.XtraEditors.NavigatorCustomButton() {New DevExpress.XtraEditors.NavigatorCustomButton(-1, 7, True, True, "", "DEL")})
        Me.GC2.EmbeddedNavigator.Name = ""
        Me.GC2.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC2.Location = New System.Drawing.Point(0, 0)
        Me.GC2.MainView = Me.GV2
        Me.GC2.Name = "GC2"
        Me.GC2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpGSP, Me.rpCheck, Me.fovlib})
        Me.GC2.Size = New System.Drawing.Size(532, 220)
        Me.GC2.TabIndex = 0
        Me.GC2.UseEmbeddedNavigator = True
        Me.GC2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMVPRMV_MVPR_CODE_FK_PK, Me.colMVPRMV_MV_CODE_FK_PK, Me.colGSP_NOM})
        Me.GV2.GridControl = Me.GC2
        Me.GV2.GroupPanelText = " "
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsView.ShowGroupPanel = False
        '
        'colMVPRMV_MV_CODE_FK_PK
        '
        Me.colMVPRMV_MV_CODE_FK_PK.Caption = "Code"
        Me.colMVPRMV_MV_CODE_FK_PK.FieldName = "MVPRMV_MV_CODE_FK_PK"
        Me.colMVPRMV_MV_CODE_FK_PK.Name = "colMVPRMV_MV_CODE_FK_PK"
        Me.colMVPRMV_MV_CODE_FK_PK.Visible = True
        Me.colMVPRMV_MV_CODE_FK_PK.VisibleIndex = 1
        '
        'colGSP_NOM
        '
        Me.colGSP_NOM.Caption = "Libellé"
        Me.colGSP_NOM.ColumnEdit = Me.rpGSP
        Me.colGSP_NOM.FieldName = "MVPRMV_MV_CODE_FK_PK"
        Me.colGSP_NOM.Name = "colGSP_NOM"
        Me.colGSP_NOM.Visible = True
        Me.colGSP_NOM.VisibleIndex = 0
        Me.colGSP_NOM.Width = 304
        '
        'rpGSP
        '
        Me.rpGSP.AutoHeight = False
        Me.rpGSP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpGSP.Name = "rpGSP"
        '
        'rpCheck
        '
        Me.rpCheck.AutoHeight = False
        Me.rpCheck.Name = "rpCheck"
        Me.rpCheck.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.rpCheck.ValueChecked = 1
        Me.rpCheck.ValueGrayed = -1
        Me.rpCheck.ValueUnchecked = 0
        '
        'fovlib
        '
        Me.fovlib.AutoHeight = False
        Me.fovlib.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fovlib.Name = "fovlib"
        '
        'savlib
        '
        Me.savlib.AutoHeight = False
        Me.savlib.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.savlib.Name = "savlib"
        '
        'cdfnom
        '
        Me.cdfnom.AutoHeight = False
        Me.cdfnom.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cdfnom.Name = "cdfnom"
        '
        'GsP_TA
        '
        Me.GsP_TA.ClearBeforeFill = True
        '
        'SP_TA
        '
        Me.SP_TA.ClearBeforeFill = False
        '
        'XtraTabControl3
        '
        Me.XtraTabControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.XtraTabControl3.Location = New System.Drawing.Point(0, 108)
        Me.XtraTabControl3.Name = "XtraTabControl3"
        Me.XtraTabControl3.SelectedTabPage = Me.XtraTabPage3
        Me.XtraTabControl3.Size = New System.Drawing.Size(561, 446)
        Me.XtraTabControl3.TabIndex = 37
        Me.XtraTabControl3.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3, Me.XtraTabPage4})
        Me.XtraTabControl3.Tag = ""
        Me.XtraTabControl3.Text = "XtraTabControl3"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.XtraTabControl1)
        Me.XtraTabPage3.Controls.Add(Me.XtraTabControl2)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(552, 415)
        Me.XtraTabPage3.Tag = "[EDIT][ADD]"
        Me.XtraTabPage3.Text = "Groupe"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.GridControl2)
        Me.XtraTabPage4.Controls.Add(Me.GridControl1)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(552, 415)
        Me.XtraTabPage4.Text = "Structure"
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "MVPRFOV_MED_VIR_PERE_FORME_VIRTUELLE"
        Me.GridControl2.DataSource = Me.DsTheriaque_Nomenclature2
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridControl2.EmbeddedNavigator.Buttons.Edit.Enabled = False
        Me.GridControl2.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridControl2.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GridControl2.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GridControl2.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GridControl2.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GridControl2.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GridControl2.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GridControl2.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GridControl2.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GridControl2.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GridControl2.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GridControl2.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GridControl2.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GridControl2.Location = New System.Drawing.Point(0, 200)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.savlib, Me.cdfnom, Me.fovlibelle})
        Me.GridControl2.Size = New System.Drawing.Size(552, 200)
        Me.GridControl2.TabIndex = 1
        Me.GridControl2.UseEmbeddedNavigator = True
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFOV_LIBELLE, Me.colMVPRFOV_MVPR_CODE_FK_PK})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colFOV_LIBELLE
        '
        Me.colFOV_LIBELLE.Caption = "Forme virtuelle"
        Me.colFOV_LIBELLE.ColumnEdit = Me.fovlibelle
        Me.colFOV_LIBELLE.FieldName = "MVPRFOV_FOV_CODE_FK_PK"
        Me.colFOV_LIBELLE.Name = "colFOV_LIBELLE"
        Me.colFOV_LIBELLE.Visible = True
        Me.colFOV_LIBELLE.VisibleIndex = 0
        '
        'fovlibelle
        '
        Me.fovlibelle.AutoHeight = False
        Me.fovlibelle.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fovlibelle.Name = "fovlibelle"
        '
        'colMVPRFOV_MVPR_CODE_FK_PK
        '
        Me.colMVPRFOV_MVPR_CODE_FK_PK.Caption = "MVPRFOV_MVPR_CODE_FK_PK"
        Me.colMVPRFOV_MVPR_CODE_FK_PK.FieldName = "MVPRFOV_MVPR_CODE_FK_PK"
        Me.colMVPRFOV_MVPR_CODE_FK_PK.Name = "colMVPRFOV_MVPR_CODE_FK_PK"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridControl1.EmbeddedNavigator.Buttons.Edit.Enabled = False
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
        Me.GridControl1.EmbeddedNavigator.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(552, 200)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMVPRSAV_Libelle, Me.colMVPRSAV_NUM_ORD, Me.colMVPRSAV_MVPR_CODE_FK_PK})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colMVPRSAV_Libelle
        '
        Me.colMVPRSAV_Libelle.Caption = "Substance Virtuelle"
        Me.colMVPRSAV_Libelle.ColumnEdit = Me.savlib
        Me.colMVPRSAV_Libelle.FieldName = "MVPRSAV_SAV_CODE_FK_PK"
        Me.colMVPRSAV_Libelle.Name = "colMVPRSAV_Libelle"
        Me.colMVPRSAV_Libelle.Visible = True
        Me.colMVPRSAV_Libelle.VisibleIndex = 0
        Me.colMVPRSAV_Libelle.Width = 106
        '
        'colMVPRSAV_NUM_ORD
        '
        Me.colMVPRSAV_NUM_ORD.Caption = "Numéro d'ordre"
        Me.colMVPRSAV_NUM_ORD.FieldName = "MVPRSAV_NUM_ORD"
        Me.colMVPRSAV_NUM_ORD.Name = "colMVPRSAV_NUM_ORD"
        Me.colMVPRSAV_NUM_ORD.Visible = True
        Me.colMVPRSAV_NUM_ORD.VisibleIndex = 1
        '
        'colMVPRSAV_MVPR_CODE_FK_PK
        '
        Me.colMVPRSAV_MVPR_CODE_FK_PK.Caption = "MVPRSAV_MVPR_CODE_FK_PK"
        Me.colMVPRSAV_MVPR_CODE_FK_PK.FieldName = "MVPRSAV_MVPR_CODE_FK_PK"
        Me.colMVPRSAV_MVPR_CODE_FK_PK.Name = "colMVPRSAV_MVPR_CODE_FK_PK"
        Me.colMVPRSAV_MVPR_CODE_FK_PK.Width = 106
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Forme virtuelle"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(280, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Statut"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(48, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Depuis"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateDispoEdit3
        '
        Me.DateDispoEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "MVPR_MEDICAMENT_VIRTUEL_PERE.MVPR_DATE_DISPO", True))
        Me.DateDispoEdit3.EditValue = Nothing
        Me.DateDispoEdit3.Location = New System.Drawing.Point(92, 36)
        Me.DateDispoEdit3.Name = "DateDispoEdit3"
        Me.DateDispoEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateDispoEdit3.Size = New System.Drawing.Size(99, 20)
        Me.DateDispoEdit3.TabIndex = 44
        '
        'statutEdit
        '
        Me.statutEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "MVPR_MEDICAMENT_VIRTUEL_PERE.MVPR_ETAT_DISPO", True))
        Me.statutEdit.Location = New System.Drawing.Point(317, 13)
        Me.statutEdit.Name = "statutEdit"
        Me.statutEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.statutEdit.Properties.NullText = ""
        Me.statutEdit.Size = New System.Drawing.Size(134, 20)
        Me.statutEdit.TabIndex = 45
        '
        'MVPSDU
        '
        Me.MVPSDU.ClearBeforeFill = True
        '
        'IC1SP_TERME1SPECIALITETableAdapter1
        '
        Me.IC1SP_TERME1SPECIALITETableAdapter1.ClearBeforeFill = True
        '
        'MVPF
        '
        Me.MVPF.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(269, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Retiré le"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MVPR
        '
        Me.MVPR.ClearBeforeFill = True
        '
        'DateEdit3
        '
        Me.DateEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "MVPR_MEDICAMENT_VIRTUEL_PERE.MVPR_DATE_RETRAIT", True))
        Me.DateEdit3.EditValue = Nothing
        Me.DateEdit3.Location = New System.Drawing.Point(317, 35)
        Me.DateEdit3.Name = "DateEdit3"
        Me.DateEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit3.Size = New System.Drawing.Size(134, 20)
        Me.DateEdit3.TabIndex = 44
        '
        'SYMVPR
        '
        Me.SYMVPR.ClearBeforeFill = True
        '
        'MVPRMV
        '
        Me.MVPRMV.ClearBeforeFill = True
        '
        'MVPRSAV
        '
        Me.MVPRSAV.ClearBeforeFill = True
        '
        'MVPRFOV
        '
        Me.MVPRFOV.ClearBeforeFill = True
        '
        'Frm_MedVirtuellePere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(679, 641)
        Me.Name = "Frm_MedVirtuellePere"
        Me.Text = "Médicament virtuel père"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanMain.PerformLayout()
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_Nomenclature2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.savLibl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpGSP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fovlib, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.savlib, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cdfnom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl3.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fovlibelle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateDispoEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.statutEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GC2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLibelle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GsP_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.GSP_GENERIQUE_SPECIALITETableAdapter
    Friend WithEvents DsTheriaque_Nomenclature2 As Theriaque.dsTheriaque_Nomenclature2
    Friend WithEvents colSYMVPR_LIBELLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSYMVPR_MVPR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSYMVPR_CODE_SQ_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMVPRMV_MVPR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMVPRMV_MV_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSP_NOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SP_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.SP_SPECIALITETableAdapter
    Friend WithEvents rpGSP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents savlib As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents fovlib As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cdfnom As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rpCheck As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents XtraTabControl3 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMVPRSAV_Libelle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMVPRSAV_NUM_ORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMVPRSAV_MVPR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DateDispoEdit3 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents statutEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents colFOV_LIBELLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fovlibelle As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents MVPSDU As Theriaque.dsTheriaque_Nomenclature2TableAdapters.MVPSDU_MED_VIR_PERE_SATableAdapter
    Friend WithEvents IC1SP_TERME1SPECIALITETableAdapter1 As Theriaque.dsTheriaque_AnalyseOrdonance2TableAdapters.IC1SP_TERME1SPECIALITETableAdapter
    Friend WithEvents MVPF As Theriaque.dsTheriaque_Nomenclature2TableAdapters.MVPF_MED_VIR_PERE_FORMETableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MVPR As Theriaque.dsTheriaque_Nomenclature2TableAdapters.MVPR_MEDICAMENT_VIRTUEL_PERETableAdapter
    Friend WithEvents DateEdit3 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SYMVPR As Theriaque.dsTheriaque_Nomenclature2TableAdapters.SYMVPR_SYN_MEDIC_VIRTUEL_PERETableAdapter
    Friend WithEvents MVPRMV As Theriaque.dsTheriaque_Nomenclature2TableAdapters.MVPRMV_MED_VIR_VIR_PERETableAdapter
    Friend WithEvents MVPRSAV As Theriaque.dsTheriaque_Nomenclature2TableAdapters.MVPRSAV_MED_VIR_PERE_SUBSTANCE_VIRTUELLETableAdapter
    Friend WithEvents savLibl As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents MVPRFOV As Theriaque.dsTheriaque_Nomenclature2TableAdapters.MVPRFOV_MED_VIR_PERE_FORME_VIRTUELLETableAdapter
    Friend WithEvents colMVPRFOV_MVPR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn

End Class
