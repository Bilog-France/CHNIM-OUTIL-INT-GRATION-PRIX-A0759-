<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MedVirtuelle
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
        Me.colSP_CODE_SQ_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.DsTheriaque_Nomenclature2 = New Theriaque.dsTheriaque_Nomenclature2
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSYGSP_NOM_PK1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSYGSP_GSP_CODE_FK1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSYGSP_NUMORD1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.txtLibelle = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCodeVirtuelle = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GC2 = New DevExpress.XtraGrid.GridControl
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSP_GSP_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSP_NOM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpSP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ColSP_REF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpCheck = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.fovlib = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.savlib = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.cdfnom = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GsP_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.GSP_GENERIQUE_SPECIALITETableAdapter
        Me.SygsP_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.SYGSP_SYNONYME_GSPTableAdapter
        Me.SP_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.SP_SPECIALITETableAdapter
        Me.Ch_DC = New DevExpress.XtraEditors.CheckEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.MemoEdit3 = New DevExpress.XtraEditors.MemoEdit
        Me.txt_Code13 = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.XtraTabControl3 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFOV_LIBELLE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fovlibelle = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.col_GSP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGSPCODEFKPK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtCodeRef = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.DateDispoEdit3 = New DevExpress.XtraEditors.DateEdit
        Me.statutEdit = New DevExpress.XtraEditors.LookUpEdit
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
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodeVirtuelle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpSP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fovlib, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.savlib, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cdfnom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ch_DC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.MemoEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Code13.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl3.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fovlibelle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodeRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateDispoEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.statutEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(679, 641)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.statutEdit)
        Me.PanMain.Controls.Add(Me.DateDispoEdit3)
        Me.PanMain.Controls.Add(Me.Label8)
        Me.PanMain.Controls.Add(Me.Label7)
        Me.PanMain.Controls.Add(Me.txtCodeRef)
        Me.PanMain.Controls.Add(Me.Label5)
        Me.PanMain.Controls.Add(Me.txt_Code13)
        Me.PanMain.Controls.Add(Me.Label4)
        Me.PanMain.Controls.Add(Me.Ch_DC)
        Me.PanMain.Controls.Add(Me.XtraTabControl3)
        Me.PanMain.Controls.Add(Me.Label2)
        Me.PanMain.Controls.Add(Me.txtCode)
        Me.PanMain.Controls.Add(Me.txtLibelle)
        Me.PanMain.Controls.Add(Me.Label6)
        Me.PanMain.Controls.Add(Me.txtCodeVirtuelle)
        Me.PanMain.Controls.Add(Me.Label3)
        Me.PanMain.Size = New System.Drawing.Size(561, 554)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(679, 87)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(679, 28)
        Me.Label1.Text = "Médicament virtuel"
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
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "GSP_GENERIQUE_SPECIALITE.GSP_DATEMJ", True))
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
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "GSP_GENERIQUE_SPECIALITE.GSP_DATECR", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        '
        'colSP_CODE_SQ_PK
        '
        Me.colSP_CODE_SQ_PK.Caption = "Code"
        Me.colSP_CODE_SQ_PK.FieldName = "SP_CODE_SQ_PK"
        Me.colSP_CODE_SQ_PK.Name = "colSP_CODE_SQ_PK"
        Me.colSP_CODE_SQ_PK.Visible = True
        Me.colSP_CODE_SQ_PK.VisibleIndex = 0
        Me.colSP_CODE_SQ_PK.Width = 50
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
        Me.GC.DataMember = "GSP_GENERIQUE_SPECIALITE.FK1_SYGSP_SYNONYME_GSP"
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
        Me.GC.Size = New System.Drawing.Size(538, 121)
        Me.GC.TabIndex = 0
        Me.GC.Tag = "[EDIT][NOADD]"
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
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSYGSP_NOM_PK1, Me.colSYGSP_GSP_CODE_FK1, Me.colSYGSP_NUMORD1})
        Me.GV.GridControl = Me.GC
        Me.GV.GroupPanelText = " "
        Me.GV.Name = "GV"
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'colSYGSP_NOM_PK1
        '
        Me.colSYGSP_NOM_PK1.Caption = "Libellé"
        Me.colSYGSP_NOM_PK1.FieldName = "SYGSP_NOM_PK"
        Me.colSYGSP_NOM_PK1.Name = "colSYGSP_NOM_PK1"
        Me.colSYGSP_NOM_PK1.Visible = True
        Me.colSYGSP_NOM_PK1.VisibleIndex = 0
        '
        'colSYGSP_GSP_CODE_FK1
        '
        Me.colSYGSP_GSP_CODE_FK1.Caption = "SYGSP_GSP_CODE_FK"
        Me.colSYGSP_GSP_CODE_FK1.FieldName = "SYGSP_GSP_CODE_FK"
        Me.colSYGSP_GSP_CODE_FK1.Name = "colSYGSP_GSP_CODE_FK1"
        '
        'colSYGSP_NUMORD1
        '
        Me.colSYGSP_NUMORD1.Caption = "SYGSP_NUMORD"
        Me.colSYGSP_NUMORD1.FieldName = "SYGSP_NUMORD"
        Me.colSYGSP_NUMORD1.Name = "colSYGSP_NUMORD1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "N° Codif"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "GSP_GENERIQUE_SPECIALITE.GSP_CODE_SQ_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(92, 11)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.txtCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Properties.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 28
        Me.txtCode.TabStop = False
        Me.txtCode.Tag = ""
        '
        'txtLibelle
        '
        Me.txtLibelle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLibelle.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "GSP_GENERIQUE_SPECIALITE.GSP_NOM", True))
        Me.txtLibelle.Location = New System.Drawing.Point(92, 38)
        Me.txtLibelle.Name = "txtLibelle"
        Me.txtLibelle.Size = New System.Drawing.Size(357, 20)
        Me.txtLibelle.TabIndex = 25
        Me.txtLibelle.Tag = "[EDIT]"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Libellé"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodeVirtuelle
        '
        Me.txtCodeVirtuelle.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "GSP_GENERIQUE_SPECIALITE.GSP_CODE_VIRTUEL", True))
        Me.txtCodeVirtuelle.Location = New System.Drawing.Point(92, 64)
        Me.txtCodeVirtuelle.Name = "txtCodeVirtuelle"
        Me.txtCodeVirtuelle.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodeVirtuelle.Size = New System.Drawing.Size(100, 20)
        Me.txtCodeVirtuelle.TabIndex = 24
        Me.txtCodeVirtuelle.Tag = "[NOEDIT]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Code7"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl2.Location = New System.Drawing.Point(2, 164)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage2
        Me.XtraTabControl2.Size = New System.Drawing.Size(541, 128)
        Me.XtraTabControl2.TabIndex = 32
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2})
        Me.XtraTabControl2.Tag = "[EDIT][ADD]"
        Me.XtraTabControl2.Text = "XtraTabControl2"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GC2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(532, 97)
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
        Me.GC2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpSP, Me.rpCheck, Me.fovlib})
        Me.GC2.Size = New System.Drawing.Size(532, 97)
        Me.GC2.TabIndex = 0
        Me.GC2.UseEmbeddedNavigator = True
        Me.GC2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSP_CODE_SQ_PK, Me.colSP_GSP_CODE_FK, Me.colSP_NOM, Me.ColSP_REF})
        Me.GV2.GridControl = Me.GC2
        Me.GV2.GroupPanelText = " "
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsView.ShowGroupPanel = False
        '
        'colSP_GSP_CODE_FK
        '
        Me.colSP_GSP_CODE_FK.Caption = "SP_GSP_CODE_FK"
        Me.colSP_GSP_CODE_FK.FieldName = "SP_GSP_CODE_FK"
        Me.colSP_GSP_CODE_FK.Name = "colSP_GSP_CODE_FK"
        '
        'colSP_NOM
        '
        Me.colSP_NOM.Caption = "Libellé"
        Me.colSP_NOM.ColumnEdit = Me.rpSP
        Me.colSP_NOM.FieldName = "SP_CODE_SQ_PK"
        Me.colSP_NOM.Name = "colSP_NOM"
        Me.colSP_NOM.Visible = True
        Me.colSP_NOM.VisibleIndex = 1
        Me.colSP_NOM.Width = 304
        '
        'rpSP
        '
        Me.rpSP.AutoHeight = False
        Me.rpSP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpSP.Name = "rpSP"
        '
        'ColSP_REF
        '
        Me.ColSP_REF.Caption = "Spécialité de référence"
        Me.ColSP_REF.ColumnEdit = Me.rpCheck
        Me.ColSP_REF.FieldName = "CheckREF"
        Me.ColSP_REF.Name = "ColSP_REF"
        Me.ColSP_REF.Visible = True
        Me.ColSP_REF.VisibleIndex = 2
        Me.ColSP_REF.Width = 161
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
        'SygsP_TA
        '
        Me.SygsP_TA.ClearBeforeFill = True
        '
        'SP_TA
        '
        Me.SP_TA.ClearBeforeFill = False
        '
        'Ch_DC
        '
        Me.Ch_DC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "GSP_GENERIQUE_SPECIALITE.GSP_PRESCRIPTION_DC", True))
        Me.Ch_DC.Location = New System.Drawing.Point(210, 11)
        Me.Ch_DC.Name = "Ch_DC"
        Me.Ch_DC.Properties.Caption = "Prescription DC"
        Me.Ch_DC.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.Ch_DC.Size = New System.Drawing.Size(97, 19)
        Me.Ch_DC.TabIndex = 33
        Me.Ch_DC.Tag = "[EDIT]"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.MemoEdit3)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl1.Location = New System.Drawing.Point(0, 298)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(552, 117)
        Me.GroupControl1.TabIndex = 34
        Me.GroupControl1.Tag = "[EDIT][ADD]"
        Me.GroupControl1.Text = "Info Général"
        '
        'MemoEdit3
        '
        Me.MemoEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "GSP_GENERIQUE_SPECIALITE.GSP_INFO_GENERAL_TEXTE", True))
        Me.MemoEdit3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoEdit3.Location = New System.Drawing.Point(2, 20)
        Me.MemoEdit3.Name = "MemoEdit3"
        Me.MemoEdit3.Size = New System.Drawing.Size(548, 95)
        Me.MemoEdit3.TabIndex = 37
        Me.MemoEdit3.Tag = ""
        '
        'txt_Code13
        '
        Me.txt_Code13.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "GSP_GENERIQUE_SPECIALITE.GSP_CODE_VIRTUEL13", True))
        Me.txt_Code13.Location = New System.Drawing.Point(251, 64)
        Me.txt_Code13.Name = "txt_Code13"
        Me.txt_Code13.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Code13.Size = New System.Drawing.Size(100, 20)
        Me.txt_Code13.TabIndex = 35
        Me.txt_Code13.Tag = "[NOEDIT]"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(206, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Code13"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.XtraTabControl3.Tag = "[EDIT][NOADD]"
        Me.XtraTabControl3.Text = "XtraTabControl3"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.GroupControl1)
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
        Me.GridControl2.DataMember = "GSP_GENERIQUE_SPECIALITE.FK_GSP1"
        Me.GridControl2.DataSource = Me.DsTheriaque_Nomenclature2
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridControl2.EmbeddedNavigator.Buttons.Edit.Enabled = False
        Me.GridControl2.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridControl2.EmbeddedNavigator.Buttons.EndEdit.Enabled = False
        Me.GridControl2.EmbeddedNavigator.Buttons.EndEdit.Visible = False
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
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFOV_LIBELLE, Me.col_GSP_CODE_FK_PK})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colFOV_LIBELLE
        '
        Me.colFOV_LIBELLE.Caption = "Forme virtuelle"
        Me.colFOV_LIBELLE.ColumnEdit = Me.fovlibelle
        Me.colFOV_LIBELLE.FieldName = "MVPF_FOV_CODE_FK_PK"
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
        'col_GSP_CODE_FK_PK
        '
        Me.col_GSP_CODE_FK_PK.Caption = "col_GSP_CODE_FK_PK"
        Me.col_GSP_CODE_FK_PK.FieldName = "MVPF_GSP_CODE_FK_PK"
        Me.col_GSP_CODE_FK_PK.Name = "col_GSP_CODE_FK_PK"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "GSP_GENERIQUE_SPECIALITE.FK_GSP_MVPSDU"
        Me.GridControl1.DataSource = Me.DsTheriaque_Nomenclature2
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridControl1.EmbeddedNavigator.Buttons.Edit.Enabled = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.EndEdit.Enabled = False
        Me.GridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = False
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.colGSPCODEFKPK})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Substance Virtuelle"
        Me.GridColumn1.ColumnEdit = Me.savlib
        Me.GridColumn1.FieldName = "MVPSDU_SAV_CODE_FK_PK"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Dosage"
        Me.GridColumn2.FieldName = "MVPSDU_DOSAGE"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Unité"
        Me.GridColumn3.ColumnEdit = Me.cdfnom
        Me.GridColumn3.FieldName = "MVPSDU_CDF_UNITE"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "N"
        Me.GridColumn4.FieldName = "MVPSDU_NUM_ORD"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'colGSPCODEFKPK
        '
        Me.colGSPCODEFKPK.Caption = "GridColumn6"
        Me.colGSPCODEFKPK.FieldName = "MVPSDU_GSP_CODE_FK_PK"
        Me.colGSPCODEFKPK.Name = "colGSPCODEFKPK"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Forme virtuelle"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        '
        'txtCodeRef
        '
        Me.txtCodeRef.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "GSP_GENERIQUE_SPECIALITE.GSP_CODE_SP_REFERENCE", True))
        Me.txtCodeRef.Location = New System.Drawing.Point(452, 64)
        Me.txtCodeRef.Name = "txtCodeRef"
        Me.txtCodeRef.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodeRef.Size = New System.Drawing.Size(100, 20)
        Me.txtCodeRef.TabIndex = 38
        Me.txtCodeRef.Tag = "[NOEDIT]"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(364, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Code réferentiel"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(307, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Statut"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(450, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Depuis"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateDispoEdit3
        '
        Me.DateDispoEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "GSP_GENERIQUE_SPECIALITE.GSP_DATE_DISPO", True))
        Me.DateDispoEdit3.EditValue = Nothing
        Me.DateDispoEdit3.Location = New System.Drawing.Point(494, 10)
        Me.DateDispoEdit3.Name = "DateDispoEdit3"
        Me.DateDispoEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateDispoEdit3.Size = New System.Drawing.Size(65, 20)
        Me.DateDispoEdit3.TabIndex = 44
        '
        'statutEdit
        '
        Me.statutEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "GSP_GENERIQUE_SPECIALITE.GSP_ETAT_DISPO", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.statutEdit.Location = New System.Drawing.Point(349, 12)
        Me.statutEdit.Name = "statutEdit"
        Me.statutEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.statutEdit.Size = New System.Drawing.Size(100, 20)
        Me.statutEdit.TabIndex = 45
        '
        'Frm_MedVirtuelle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(679, 641)
        Me.Name = "Frm_MedVirtuelle"
        Me.Text = "Médicament virtuel"
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
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodeVirtuelle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpSP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fovlib, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.savlib, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cdfnom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ch_DC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.MemoEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Code13.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl3.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fovlibelle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodeRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateDispoEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.statutEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtCodeVirtuelle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GsP_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.GSP_GENERIQUE_SPECIALITETableAdapter
    Friend WithEvents SygsP_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.SYGSP_SYNONYME_GSPTableAdapter
    Friend WithEvents DsTheriaque_Nomenclature2 As Theriaque.dsTheriaque_Nomenclature2
    Friend WithEvents colSYGSP_NOM_PK1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSYGSP_GSP_CODE_FK1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSYGSP_NUMORD1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSP_CODE_SQ_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSP_GSP_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSP_NOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SP_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.SP_SPECIALITETableAdapter
    Friend WithEvents rpSP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents savlib As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents fovlib As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cdfnom As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Ch_DC As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ColSP_REF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpCheck As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents MemoEdit3 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_Code13 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents XtraTabControl3 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtCodeRef As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DateDispoEdit3 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents statutEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents colFOV_LIBELLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fovlibelle As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colGSPCODEFKPK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_GSP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn

End Class
