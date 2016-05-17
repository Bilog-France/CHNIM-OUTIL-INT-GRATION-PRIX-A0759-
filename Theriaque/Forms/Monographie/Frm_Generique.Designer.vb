<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Generique
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
        Me.DsTheriaque_Nomenclature2 = New Theriaque.dsTheriaque_Nomenclature2
        Me.GreF_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.GREF_GROUPE_SPECIALITE_REFTableAdapter
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.GC12 = New DevExpress.XtraGrid.GridControl
        Me.GV12 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colGREFTX_GREF_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGREFTX_GREF_DATECR_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGREFTX_TEXTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpMemo = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.DateEditJO = New DevExpress.XtraEditors.DateEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCOSAU_SAU_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpSau = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colCOSAU_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOSAU_GREF_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOSAU_GREF_DATECR_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC2 = New DevExpress.XtraGrid.GridControl
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPREGREF_GREF_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPREGREF_PRE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpPre = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colPREGREF_DATEENTREE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPREGREF_GREF_DATECR_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPREGREF_DATESORTIE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPREGREF_TYPE_PRE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GC1 = New DevExpress.XtraGrid.GridControl
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSPGREFR_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpGen = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSPGREFR_GREF_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPGREFR_GREF_DATECR_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.DateEdit4 = New DevExpress.XtraEditors.DateEdit
        Me.DateEditCrGroupe = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.GC6 = New DevExpress.XtraGrid.GridControl
        Me.GV6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCOSAU_SAU_CODE_FK_PK1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpSAU1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colCOSAU_SP_CODE_FK_PK1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOSAU_DOSAGE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOSAU_UNITEDOSAGE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOSAU_COMPO_NUM_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOSAU_GREF_CODE_FK1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOSAU_GREF_DATECR_FK1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOSAU_GREF_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOSAU_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC5 = New DevExpress.XtraGrid.GridControl
        Me.GV5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPREGREF_GREF_CODE_FK_PK1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPREGREF_PRE_CODE_FK_PK1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpPre1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colPREGREF_DATEENTREE_PK1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPREGREF_GREF_DATECR_FK_PK1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPREGREF_DATESORTIE1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPREGREF_TYPE_PRE1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.GC4 = New DevExpress.XtraGrid.GridControl
        Me.GV4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSPGREFG_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpSPG = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSPGREFG_GREF_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPGREFG_GREF_DATECR_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPGREFG_DATEEG_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPGREFG_DATESG = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.GC8 = New DevExpress.XtraGrid.GridControl
        Me.GV8 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPREGREF_TYPE_PRE_H1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPREGREF_PRE_CODE_FK_PK2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpSPH2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.GC7 = New DevExpress.XtraGrid.GridControl
        Me.GV7 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPREGREF_TYPE_PRE_H = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPREGREF_PRE_CODE_FK_PK3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpSPH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.SpgrefR_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.SPGREFR_GROUPE_SPE_REFTableAdapter
        Me.SP_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.SP_SPECIALITETableAdapter
        Me.PregreF_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.PREGREF_PRE_GROUPE_REFTableAdapter
        Me.CosaU_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.COSAU_COMPO_SUBAUXTableAdapter
        Me.GreftX_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.GREFTX_TEXTE_GROUPE_REFTableAdapter
        Me.SpgrefG_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.SPGREFG_GROUPE_SPE_GENETableAdapter
        Me.PregreF1_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.PREGREF_PRE_GROUPE_REF1TableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_Nomenclature2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.GC12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditJO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpSau, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpPre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpGen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        CType(Me.DateEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditCrGroupe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.GC6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpSAU1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpPre1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.GC4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpSPG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.GC8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpSPH2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        CType(Me.GC7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpSPH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(762, 585)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.XtraTabControl1)
        Me.PanMain.Location = New System.Drawing.Point(0, 70)
        Me.PanMain.Size = New System.Drawing.Size(644, 515)
        '
        'PanTop
        '
        Me.PanTop.Controls.Add(Me.txtCode)
        Me.PanTop.Controls.Add(Me.Label2)
        Me.PanTop.Size = New System.Drawing.Size(762, 70)
        Me.PanTop.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.PanTop.Controls.SetChildIndex(Me.DateEdit2, 0)
        Me.PanTop.Controls.SetChildIndex(Me.Label2, 0)
        Me.PanTop.Controls.SetChildIndex(Me.txtCode, 0)
        Me.PanTop.Controls.SetChildIndex(Me.DateEdit1, 0)
        Me.PanTop.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.PanTop.Controls.SetChildIndex(Me.Label1, 0)
        Me.PanTop.Controls.SetChildIndex(Me.GroupBox, 0)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(762, 28)
        Me.Label1.Text = "Génériques"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(540, 33)
        Me.LabelControl2.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(304, 39)
        Me.LabelControl1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(644, 70)
        Me.Panel1.Size = New System.Drawing.Size(118, 515)
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(612, 32)
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit1.Visible = False
        '
        'GroupBox
        '
        Me.GroupBox.Location = New System.Drawing.Point(0, 62)
        Me.GroupBox.Size = New System.Drawing.Size(762, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(361, 36)
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit2.Visible = False
        '
        'DsTheriaque_Nomenclature2
        '
        Me.DsTheriaque_Nomenclature2.DataSetName = "dsTheriaque_Nomenclature2"
        Me.DsTheriaque_Nomenclature2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GreF_TA
        '
        Me.GreF_TA.ClearBeforeFill = True
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "GREF_GROUPE_SPECIALITE_REF.GREF_CODE_SQ_PK", True))
        Me.txtCode.EditValue = ""
        Me.txtCode.Location = New System.Drawing.Point(134, 36)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Tag = "[ADD][NOEDIT]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Groupe générique"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(644, 515)
        Me.XtraTabControl1.TabIndex = 2
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        Me.XtraTabControl1.Tag = ""
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panel6)
        Me.XtraTabPage1.Controls.Add(Me.Panel5)
        Me.XtraTabPage1.Controls.Add(Me.Panel3)
        Me.XtraTabPage1.Controls.Add(Me.Panel4)
        Me.XtraTabPage1.Controls.Add(Me.Panel2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(635, 484)
        Me.XtraTabPage1.Tag = ""
        Me.XtraTabPage1.Text = "Référence"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 379)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(635, 105)
        Me.Panel6.TabIndex = 8
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.GC12)
        Me.Panel7.Controls.Add(Me.LabelControl5)
        Me.Panel7.Controls.Add(Me.LabelControl3)
        Me.Panel7.Controls.Add(Me.DateEditJO)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(635, 105)
        Me.Panel7.TabIndex = 3
        Me.Panel7.Tag = "[ADD][EDIT]"
        '
        'GC12
        '
        Me.GC12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC12.DataMember = "GREFTX_TEXTE_GROUPE_REF"
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
        Me.GC12.Location = New System.Drawing.Point(95, 31)
        Me.GC12.MainView = Me.GV12
        Me.GC12.Name = "GC12"
        Me.GC12.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpMemo})
        Me.GC12.Size = New System.Drawing.Size(518, 71)
        Me.GC12.TabIndex = 2
        Me.GC12.UseEmbeddedNavigator = True
        Me.GC12.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV12})
        '
        'GV12
        '
        Me.GV12.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGREFTX_GREF_CODE_FK_PK, Me.colGREFTX_GREF_DATECR_FK_PK, Me.colGREFTX_TEXTE})
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
        Me.GV12.RowHeight = 46
        Me.GV12.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colGREFTX_GREF_CODE_FK_PK
        '
        Me.colGREFTX_GREF_CODE_FK_PK.Caption = "GREFTX_GREF_CODE_FK_PK"
        Me.colGREFTX_GREF_CODE_FK_PK.FieldName = "GREFTX_GREF_CODE_FK_PK"
        Me.colGREFTX_GREF_CODE_FK_PK.Name = "colGREFTX_GREF_CODE_FK_PK"
        '
        'colGREFTX_GREF_DATECR_FK_PK
        '
        Me.colGREFTX_GREF_DATECR_FK_PK.Caption = "GREFTX_GREF_DATECR_FK_PK"
        Me.colGREFTX_GREF_DATECR_FK_PK.FieldName = "GREFTX_GREF_DATECR_FK_PK"
        Me.colGREFTX_GREF_DATECR_FK_PK.Name = "colGREFTX_GREF_DATECR_FK_PK"
        '
        'colGREFTX_TEXTE
        '
        Me.colGREFTX_TEXTE.Caption = "GREFTX_TEXTE"
        Me.colGREFTX_TEXTE.ColumnEdit = Me.rpMemo
        Me.colGREFTX_TEXTE.FieldName = "GREFTX_TEXTE"
        Me.colGREFTX_TEXTE.Name = "colGREFTX_TEXTE"
        Me.colGREFTX_TEXTE.Visible = True
        Me.colGREFTX_TEXTE.VisibleIndex = 0
        '
        'rpMemo
        '
        Me.rpMemo.Name = "rpMemo"
        '
        'LabelControl5
        '
        Me.LabelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl5.Location = New System.Drawing.Point(61, 31)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl5.TabIndex = 1
        Me.LabelControl5.Text = "Texte"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(6, 8)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Date JO en cours"
        '
        'DateEditJO
        '
        Me.DateEditJO.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "SP_SPECIALITE.SP_GREF_DATECR_FK", True))
        Me.DateEditJO.EditValue = Nothing
        Me.DateEditJO.Location = New System.Drawing.Point(95, 5)
        Me.DateEditJO.Name = "DateEditJO"
        Me.DateEditJO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditJO.Size = New System.Drawing.Size(90, 20)
        Me.DateEditJO.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 369)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(635, 10)
        Me.Panel5.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.GC)
        Me.Panel3.Controls.Add(Me.GC2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 190)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(635, 179)
        Me.Panel3.TabIndex = 5
        Me.Panel3.Tag = "[NOADD][EDIT]"
        '
        'GC
        '
        Me.GC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.GC.Location = New System.Drawing.Point(317, 0)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpSau})
        Me.GC.Size = New System.Drawing.Size(318, 179)
        Me.GC.TabIndex = 6
        Me.GC.Tag = "[EDIT][NOADD]"
        Me.GC.UseEmbeddedNavigator = True
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCOSAU_SAU_CODE_FK_PK, Me.colCOSAU_SP_CODE_FK_PK, Me.colCOSAU_GREF_CODE_FK, Me.colCOSAU_GREF_DATECR_FK})
        Me.GV.GridControl = Me.GC
        Me.GV.GroupPanelText = " "
        Me.GV.Name = "GV"
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'colCOSAU_SAU_CODE_FK_PK
        '
        Me.colCOSAU_SAU_CODE_FK_PK.Caption = "Excipient à effet notoire"
        Me.colCOSAU_SAU_CODE_FK_PK.ColumnEdit = Me.rpSau
        Me.colCOSAU_SAU_CODE_FK_PK.FieldName = "COSAU_SAU_CODE_FK_PK"
        Me.colCOSAU_SAU_CODE_FK_PK.Name = "colCOSAU_SAU_CODE_FK_PK"
        Me.colCOSAU_SAU_CODE_FK_PK.Visible = True
        Me.colCOSAU_SAU_CODE_FK_PK.VisibleIndex = 0
        '
        'rpSau
        '
        Me.rpSau.AutoHeight = False
        Me.rpSau.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpSau.Name = "rpSau"
        '
        'colCOSAU_SP_CODE_FK_PK
        '
        Me.colCOSAU_SP_CODE_FK_PK.Caption = "COSAU_SP_CODE_FK_PK"
        Me.colCOSAU_SP_CODE_FK_PK.FieldName = "COSAU_SP_CODE_FK_PK"
        Me.colCOSAU_SP_CODE_FK_PK.Name = "colCOSAU_SP_CODE_FK_PK"
        '
        'colCOSAU_GREF_CODE_FK
        '
        Me.colCOSAU_GREF_CODE_FK.Caption = "COSAU_GREF_CODE_FK"
        Me.colCOSAU_GREF_CODE_FK.FieldName = "COSAU_GREF_CODE_FK"
        Me.colCOSAU_GREF_CODE_FK.Name = "colCOSAU_GREF_CODE_FK"
        '
        'colCOSAU_GREF_DATECR_FK
        '
        Me.colCOSAU_GREF_DATECR_FK.Caption = "COSAU_GREF_DATECR_FK"
        Me.colCOSAU_GREF_DATECR_FK.FieldName = "COSAU_GREF_DATECR_FK"
        Me.colCOSAU_GREF_DATECR_FK.Name = "colCOSAU_GREF_DATECR_FK"
        '
        'GC2
        '
        Me.GC2.DataMember = "PREGREF_PRE_GROUPE_REF"
        Me.GC2.Dock = System.Windows.Forms.DockStyle.Left
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
        Me.GC2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpPre})
        Me.GC2.Size = New System.Drawing.Size(311, 179)
        Me.GC2.TabIndex = 2
        Me.GC2.UseEmbeddedNavigator = True
        Me.GC2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPREGREF_GREF_CODE_FK_PK, Me.colPREGREF_PRE_CODE_FK_PK, Me.colPREGREF_DATEENTREE_PK, Me.colPREGREF_GREF_DATECR_FK_PK, Me.colPREGREF_DATESORTIE, Me.colPREGREF_TYPE_PRE})
        Me.GV2.GridControl = Me.GC2
        Me.GV2.GroupPanelText = " "
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV2.OptionsView.ShowGroupPanel = False
        '
        'colPREGREF_GREF_CODE_FK_PK
        '
        Me.colPREGREF_GREF_CODE_FK_PK.Caption = "PREGREF_GREF_CODE_FK_PK"
        Me.colPREGREF_GREF_CODE_FK_PK.FieldName = "PREGREF_GREF_CODE_FK_PK"
        Me.colPREGREF_GREF_CODE_FK_PK.Name = "colPREGREF_GREF_CODE_FK_PK"
        '
        'colPREGREF_PRE_CODE_FK_PK
        '
        Me.colPREGREF_PRE_CODE_FK_PK.Caption = "CIP"
        Me.colPREGREF_PRE_CODE_FK_PK.ColumnEdit = Me.rpPre
        Me.colPREGREF_PRE_CODE_FK_PK.FieldName = "PREGREF_PRE_CODE_FK_PK"
        Me.colPREGREF_PRE_CODE_FK_PK.Name = "colPREGREF_PRE_CODE_FK_PK"
        Me.colPREGREF_PRE_CODE_FK_PK.Visible = True
        Me.colPREGREF_PRE_CODE_FK_PK.VisibleIndex = 0
        '
        'rpPre
        '
        Me.rpPre.AutoHeight = False
        Me.rpPre.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpPre.Name = "rpPre"
        '
        'colPREGREF_DATEENTREE_PK
        '
        Me.colPREGREF_DATEENTREE_PK.Caption = "PREGREF_DATEENTREE_PK"
        Me.colPREGREF_DATEENTREE_PK.FieldName = "PREGREF_DATEENTREE_PK"
        Me.colPREGREF_DATEENTREE_PK.Name = "colPREGREF_DATEENTREE_PK"
        '
        'colPREGREF_GREF_DATECR_FK_PK
        '
        Me.colPREGREF_GREF_DATECR_FK_PK.Caption = "PREGREF_GREF_DATECR_FK_PK"
        Me.colPREGREF_GREF_DATECR_FK_PK.FieldName = "PREGREF_GREF_DATECR_FK_PK"
        Me.colPREGREF_GREF_DATECR_FK_PK.Name = "colPREGREF_GREF_DATECR_FK_PK"
        '
        'colPREGREF_DATESORTIE
        '
        Me.colPREGREF_DATESORTIE.Caption = "PREGREF_DATESORTIE"
        Me.colPREGREF_DATESORTIE.FieldName = "PREGREF_DATESORTIE"
        Me.colPREGREF_DATESORTIE.Name = "colPREGREF_DATESORTIE"
        '
        'colPREGREF_TYPE_PRE
        '
        Me.colPREGREF_TYPE_PRE.Caption = "PREGREF_TYPE_PRE"
        Me.colPREGREF_TYPE_PRE.FieldName = "PREGREF_TYPE_PRE"
        Me.colPREGREF_TYPE_PRE.Name = "colPREGREF_TYPE_PRE"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 182)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(635, 8)
        Me.Panel4.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GC1)
        Me.Panel2.Controls.Add(Me.Panel14)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(635, 182)
        Me.Panel2.TabIndex = 4
        '
        'GC1
        '
        Me.GC1.DataMember = "SPGREFR_GROUPE_SPE_REF"
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
        Me.GC1.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GC1.EmbeddedNavigator.CustomButtons.AddRange(New DevExpress.XtraEditors.NavigatorCustomButton() {New DevExpress.XtraEditors.NavigatorCustomButton(-1, 7, True, True, "", "DEL")})
        Me.GC1.EmbeddedNavigator.Name = ""
        Me.GC1.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC1.Location = New System.Drawing.Point(0, 32)
        Me.GC1.MainView = Me.GV1
        Me.GC1.Name = "GC1"
        Me.GC1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpGen})
        Me.GC1.Size = New System.Drawing.Size(635, 150)
        Me.GC1.TabIndex = 1
        Me.GC1.Tag = "[EDIT][ADD]"
        Me.GC1.UseEmbeddedNavigator = True
        Me.GC1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSPGREFR_SP_CODE_FK_PK, Me.colSPGREFR_GREF_CODE_FK_PK, Me.colSPGREFR_GREF_DATECR_FK_PK})
        Me.GV1.GridControl = Me.GC1
        Me.GV1.GroupPanelText = " "
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV1.OptionsView.ShowGroupPanel = False
        '
        'colSPGREFR_SP_CODE_FK_PK
        '
        Me.colSPGREFR_SP_CODE_FK_PK.Caption = "Spécialité de référence"
        Me.colSPGREFR_SP_CODE_FK_PK.ColumnEdit = Me.rpGen
        Me.colSPGREFR_SP_CODE_FK_PK.FieldName = "SPGREFR_SP_CODE_FK_PK"
        Me.colSPGREFR_SP_CODE_FK_PK.Name = "colSPGREFR_SP_CODE_FK_PK"
        Me.colSPGREFR_SP_CODE_FK_PK.Visible = True
        Me.colSPGREFR_SP_CODE_FK_PK.VisibleIndex = 0
        Me.colSPGREFR_SP_CODE_FK_PK.Width = 430
        '
        'rpGen
        '
        Me.rpGen.AutoHeight = False
        Me.rpGen.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpGen.Name = "rpGen"
        '
        'colSPGREFR_GREF_CODE_FK_PK
        '
        Me.colSPGREFR_GREF_CODE_FK_PK.Caption = "SPGREFR_GREF_CODE_FK_PK"
        Me.colSPGREFR_GREF_CODE_FK_PK.FieldName = "SPGREFR_GREF_CODE_FK_PK"
        Me.colSPGREFR_GREF_CODE_FK_PK.Name = "colSPGREFR_GREF_CODE_FK_PK"
        '
        'colSPGREFR_GREF_DATECR_FK_PK
        '
        Me.colSPGREFR_GREF_DATECR_FK_PK.Caption = "SPGREFR_GREF_DATECR_FK_PK"
        Me.colSPGREFR_GREF_DATECR_FK_PK.FieldName = "SPGREFR_GREF_DATECR_FK_PK"
        Me.colSPGREFR_GREF_DATECR_FK_PK.Name = "colSPGREFR_GREF_DATECR_FK_PK"
        Me.colSPGREFR_GREF_DATECR_FK_PK.Visible = True
        Me.colSPGREFR_GREF_DATECR_FK_PK.VisibleIndex = 1
        Me.colSPGREFR_GREF_DATECR_FK_PK.Width = 184
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.DateEdit4)
        Me.Panel14.Controls.Add(Me.DateEditCrGroupe)
        Me.Panel14.Controls.Add(Me.LabelControl6)
        Me.Panel14.Controls.Add(Me.LabelControl4)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(635, 32)
        Me.Panel14.TabIndex = 2
        Me.Panel14.Tag = "[ADD][EDIT]"
        '
        'DateEdit4
        '
        Me.DateEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "GREF_GROUPE_SPECIALITE_REF.GREF_DATESUSP", True))
        Me.DateEdit4.EditValue = Nothing
        Me.DateEdit4.Location = New System.Drawing.Point(457, 6)
        Me.DateEdit4.Name = "DateEdit4"
        Me.DateEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit4.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit4.TabIndex = 0
        '
        'DateEditCrGroupe
        '
        Me.DateEditCrGroupe.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "GREF_GROUPE_SPECIALITE_REF.GREF_DATECR_PK", True))
        Me.DateEditCrGroupe.EditValue = Nothing
        Me.DateEditCrGroupe.Location = New System.Drawing.Point(162, 7)
        Me.DateEditCrGroupe.Name = "DateEditCrGroupe"
        Me.DateEditCrGroupe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditCrGroupe.Size = New System.Drawing.Size(102, 20)
        Me.DateEditCrGroupe.TabIndex = 0
        '
        'LabelControl6
        '
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl6.Location = New System.Drawing.Point(325, 9)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(126, 13)
        Me.LabelControl6.TabIndex = 1
        Me.LabelControl6.Text = "Arrêt du groupe / Date JO"
        '
        'LabelControl4
        '
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl4.Location = New System.Drawing.Point(9, 10)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(158, 13)
        Me.LabelControl4.TabIndex = 1
        Me.LabelControl4.Text = "Création du groupe / date JO"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Panel10)
        Me.XtraTabPage2.Controls.Add(Me.Panel9)
        Me.XtraTabPage2.Controls.Add(Me.Panel8)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(635, 484)
        Me.XtraTabPage2.Tag = ""
        Me.XtraTabPage2.Text = "Générique"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel10.Controls.Add(Me.GC6)
        Me.Panel10.Controls.Add(Me.GC5)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(0, 204)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(635, 280)
        Me.Panel10.TabIndex = 8
        Me.Panel10.Tag = "[NOADD][EDIT]"
        '
        'GC6
        '
        Me.GC6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.GC6.Location = New System.Drawing.Point(317, 0)
        Me.GC6.MainView = Me.GV6
        Me.GC6.Name = "GC6"
        Me.GC6.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpSAU1})
        Me.GC6.Size = New System.Drawing.Size(318, 280)
        Me.GC6.TabIndex = 6
        Me.GC6.Tag = "[EDIT][NOADD]"
        Me.GC6.UseEmbeddedNavigator = True
        Me.GC6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV6})
        '
        'GV6
        '
        Me.GV6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCOSAU_SAU_CODE_FK_PK1, Me.colCOSAU_SP_CODE_FK_PK1, Me.colCOSAU_DOSAGE, Me.colCOSAU_UNITEDOSAGE, Me.colCOSAU_COMPO_NUM_PK, Me.colCOSAU_GREF_CODE_FK1, Me.colCOSAU_GREF_DATECR_FK1, Me.colCOSAU_GREF_NUMORD, Me.colCOSAU_NUMORD})
        Me.GV6.GridControl = Me.GC6
        Me.GV6.GroupPanelText = " "
        Me.GV6.Name = "GV6"
        Me.GV6.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV6.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV6.OptionsView.ShowGroupPanel = False
        '
        'colCOSAU_SAU_CODE_FK_PK1
        '
        Me.colCOSAU_SAU_CODE_FK_PK1.Caption = "Excipient à effet notoire"
        Me.colCOSAU_SAU_CODE_FK_PK1.ColumnEdit = Me.rpSAU1
        Me.colCOSAU_SAU_CODE_FK_PK1.FieldName = "COSAU_SAU_CODE_FK_PK"
        Me.colCOSAU_SAU_CODE_FK_PK1.Name = "colCOSAU_SAU_CODE_FK_PK1"
        Me.colCOSAU_SAU_CODE_FK_PK1.Visible = True
        Me.colCOSAU_SAU_CODE_FK_PK1.VisibleIndex = 0
        '
        'rpSAU1
        '
        Me.rpSAU1.AutoHeight = False
        Me.rpSAU1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpSAU1.Name = "rpSAU1"
        '
        'colCOSAU_SP_CODE_FK_PK1
        '
        Me.colCOSAU_SP_CODE_FK_PK1.Caption = "COSAU_SP_CODE_FK_PK"
        Me.colCOSAU_SP_CODE_FK_PK1.FieldName = "COSAU_SP_CODE_FK_PK"
        Me.colCOSAU_SP_CODE_FK_PK1.Name = "colCOSAU_SP_CODE_FK_PK1"
        '
        'colCOSAU_DOSAGE
        '
        Me.colCOSAU_DOSAGE.Caption = "COSAU_DOSAGE"
        Me.colCOSAU_DOSAGE.FieldName = "COSAU_DOSAGE"
        Me.colCOSAU_DOSAGE.Name = "colCOSAU_DOSAGE"
        '
        'colCOSAU_UNITEDOSAGE
        '
        Me.colCOSAU_UNITEDOSAGE.Caption = "COSAU_UNITEDOSAGE"
        Me.colCOSAU_UNITEDOSAGE.FieldName = "COSAU_UNITEDOSAGE"
        Me.colCOSAU_UNITEDOSAGE.Name = "colCOSAU_UNITEDOSAGE"
        '
        'colCOSAU_COMPO_NUM_PK
        '
        Me.colCOSAU_COMPO_NUM_PK.Caption = "COSAU_COMPO_NUM_PK"
        Me.colCOSAU_COMPO_NUM_PK.FieldName = "COSAU_COMPO_NUM_PK"
        Me.colCOSAU_COMPO_NUM_PK.Name = "colCOSAU_COMPO_NUM_PK"
        '
        'colCOSAU_GREF_CODE_FK1
        '
        Me.colCOSAU_GREF_CODE_FK1.Caption = "COSAU_GREF_CODE_FK"
        Me.colCOSAU_GREF_CODE_FK1.FieldName = "COSAU_GREF_CODE_FK"
        Me.colCOSAU_GREF_CODE_FK1.Name = "colCOSAU_GREF_CODE_FK1"
        '
        'colCOSAU_GREF_DATECR_FK1
        '
        Me.colCOSAU_GREF_DATECR_FK1.Caption = "COSAU_GREF_DATECR_FK"
        Me.colCOSAU_GREF_DATECR_FK1.FieldName = "COSAU_GREF_DATECR_FK"
        Me.colCOSAU_GREF_DATECR_FK1.Name = "colCOSAU_GREF_DATECR_FK1"
        '
        'colCOSAU_GREF_NUMORD
        '
        Me.colCOSAU_GREF_NUMORD.Caption = "COSAU_GREF_NUMORD"
        Me.colCOSAU_GREF_NUMORD.FieldName = "COSAU_GREF_NUMORD"
        Me.colCOSAU_GREF_NUMORD.Name = "colCOSAU_GREF_NUMORD"
        '
        'colCOSAU_NUMORD
        '
        Me.colCOSAU_NUMORD.Caption = "COSAU_NUMORD"
        Me.colCOSAU_NUMORD.FieldName = "COSAU_NUMORD"
        Me.colCOSAU_NUMORD.Name = "colCOSAU_NUMORD"
        '
        'GC5
        '
        Me.GC5.DataMember = "PREGREF_PRE_GROUPE_REF1"
        Me.GC5.Dock = System.Windows.Forms.DockStyle.Left
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
        Me.GC5.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GC5.EmbeddedNavigator.CustomButtons.AddRange(New DevExpress.XtraEditors.NavigatorCustomButton() {New DevExpress.XtraEditors.NavigatorCustomButton(-1, 7, True, True, "", "DEL")})
        Me.GC5.EmbeddedNavigator.Name = ""
        Me.GC5.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC5.Location = New System.Drawing.Point(0, 0)
        Me.GC5.MainView = Me.GV5
        Me.GC5.Name = "GC5"
        Me.GC5.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpPre1})
        Me.GC5.Size = New System.Drawing.Size(311, 280)
        Me.GC5.TabIndex = 2
        Me.GC5.UseEmbeddedNavigator = True
        Me.GC5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV5})
        '
        'GV5
        '
        Me.GV5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPREGREF_GREF_CODE_FK_PK1, Me.colPREGREF_PRE_CODE_FK_PK1, Me.colPREGREF_DATEENTREE_PK1, Me.colPREGREF_GREF_DATECR_FK_PK1, Me.colPREGREF_DATESORTIE1, Me.colPREGREF_TYPE_PRE1})
        Me.GV5.GridControl = Me.GC5
        Me.GV5.GroupPanelText = " "
        Me.GV5.Name = "GV5"
        Me.GV5.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV5.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV5.OptionsView.ShowGroupPanel = False
        '
        'colPREGREF_GREF_CODE_FK_PK1
        '
        Me.colPREGREF_GREF_CODE_FK_PK1.Caption = "PREGREF_GREF_CODE_FK_PK"
        Me.colPREGREF_GREF_CODE_FK_PK1.FieldName = "PREGREF_GREF_CODE_FK_PK"
        Me.colPREGREF_GREF_CODE_FK_PK1.Name = "colPREGREF_GREF_CODE_FK_PK1"
        '
        'colPREGREF_PRE_CODE_FK_PK1
        '
        Me.colPREGREF_PRE_CODE_FK_PK1.Caption = "CIP"
        Me.colPREGREF_PRE_CODE_FK_PK1.ColumnEdit = Me.rpPre1
        Me.colPREGREF_PRE_CODE_FK_PK1.FieldName = "PREGREF_PRE_CODE_FK_PK"
        Me.colPREGREF_PRE_CODE_FK_PK1.Name = "colPREGREF_PRE_CODE_FK_PK1"
        Me.colPREGREF_PRE_CODE_FK_PK1.Visible = True
        Me.colPREGREF_PRE_CODE_FK_PK1.VisibleIndex = 0
        '
        'rpPre1
        '
        Me.rpPre1.AutoHeight = False
        Me.rpPre1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpPre1.Name = "rpPre1"
        '
        'colPREGREF_DATEENTREE_PK1
        '
        Me.colPREGREF_DATEENTREE_PK1.Caption = "PREGREF_DATEENTREE_PK"
        Me.colPREGREF_DATEENTREE_PK1.FieldName = "PREGREF_DATEENTREE_PK"
        Me.colPREGREF_DATEENTREE_PK1.Name = "colPREGREF_DATEENTREE_PK1"
        '
        'colPREGREF_GREF_DATECR_FK_PK1
        '
        Me.colPREGREF_GREF_DATECR_FK_PK1.Caption = "PREGREF_GREF_DATECR_FK_PK"
        Me.colPREGREF_GREF_DATECR_FK_PK1.FieldName = "PREGREF_GREF_DATECR_FK_PK"
        Me.colPREGREF_GREF_DATECR_FK_PK1.Name = "colPREGREF_GREF_DATECR_FK_PK1"
        '
        'colPREGREF_DATESORTIE1
        '
        Me.colPREGREF_DATESORTIE1.Caption = "PREGREF_DATESORTIE"
        Me.colPREGREF_DATESORTIE1.FieldName = "PREGREF_DATESORTIE"
        Me.colPREGREF_DATESORTIE1.Name = "colPREGREF_DATESORTIE1"
        '
        'colPREGREF_TYPE_PRE1
        '
        Me.colPREGREF_TYPE_PRE1.Caption = "PREGREF_TYPE_PRE"
        Me.colPREGREF_TYPE_PRE1.FieldName = "PREGREF_TYPE_PRE"
        Me.colPREGREF_TYPE_PRE1.Name = "colPREGREF_TYPE_PRE1"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 196)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(635, 8)
        Me.Panel9.TabIndex = 7
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.GC4)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(635, 196)
        Me.Panel8.TabIndex = 5
        '
        'GC4
        '
        Me.GC4.DataMember = "SPGREFG_GROUPE_SPE_GENE"
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
        Me.GC4.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GC4.EmbeddedNavigator.CustomButtons.AddRange(New DevExpress.XtraEditors.NavigatorCustomButton() {New DevExpress.XtraEditors.NavigatorCustomButton(-1, 7, True, True, "", "DEL")})
        Me.GC4.EmbeddedNavigator.Name = ""
        Me.GC4.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC4.Location = New System.Drawing.Point(0, 0)
        Me.GC4.MainView = Me.GV4
        Me.GC4.Name = "GC4"
        Me.GC4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpSPG})
        Me.GC4.Size = New System.Drawing.Size(635, 196)
        Me.GC4.TabIndex = 1
        Me.GC4.Tag = "[EDIT][ADD]"
        Me.GC4.UseEmbeddedNavigator = True
        Me.GC4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV4})
        '
        'GV4
        '
        Me.GV4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSPGREFG_SP_CODE_FK_PK, Me.colSPGREFG_GREF_CODE_FK_PK, Me.colSPGREFG_GREF_DATECR_FK_PK, Me.colSPGREFG_DATEEG_PK, Me.colSPGREFG_DATESG})
        Me.GV4.GridControl = Me.GC4
        Me.GV4.GroupPanelText = " "
        Me.GV4.Name = "GV4"
        Me.GV4.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV4.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV4.OptionsView.ShowGroupPanel = False
        '
        'colSPGREFG_SP_CODE_FK_PK
        '
        Me.colSPGREFG_SP_CODE_FK_PK.Caption = "Spécialités génériques"
        Me.colSPGREFG_SP_CODE_FK_PK.ColumnEdit = Me.rpSPG
        Me.colSPGREFG_SP_CODE_FK_PK.FieldName = "SPGREFG_SP_CODE_FK_PK"
        Me.colSPGREFG_SP_CODE_FK_PK.Name = "colSPGREFG_SP_CODE_FK_PK"
        Me.colSPGREFG_SP_CODE_FK_PK.Visible = True
        Me.colSPGREFG_SP_CODE_FK_PK.VisibleIndex = 0
        Me.colSPGREFG_SP_CODE_FK_PK.Width = 363
        '
        'rpSPG
        '
        Me.rpSPG.AutoHeight = False
        Me.rpSPG.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpSPG.Name = "rpSPG"
        '
        'colSPGREFG_GREF_CODE_FK_PK
        '
        Me.colSPGREFG_GREF_CODE_FK_PK.Caption = "SPGREFG_GREF_CODE_FK_PK"
        Me.colSPGREFG_GREF_CODE_FK_PK.FieldName = "SPGREFG_GREF_CODE_FK_PK"
        Me.colSPGREFG_GREF_CODE_FK_PK.Name = "colSPGREFG_GREF_CODE_FK_PK"
        '
        'colSPGREFG_GREF_DATECR_FK_PK
        '
        Me.colSPGREFG_GREF_DATECR_FK_PK.Caption = "SPGREFG_GREF_DATECR_FK_PK"
        Me.colSPGREFG_GREF_DATECR_FK_PK.FieldName = "SPGREFG_GREF_DATECR_FK_PK"
        Me.colSPGREFG_GREF_DATECR_FK_PK.Name = "colSPGREFG_GREF_DATECR_FK_PK"
        Me.colSPGREFG_GREF_DATECR_FK_PK.Visible = True
        Me.colSPGREFG_GREF_DATECR_FK_PK.VisibleIndex = 2
        Me.colSPGREFG_GREF_DATECR_FK_PK.Width = 128
        '
        'colSPGREFG_DATEEG_PK
        '
        Me.colSPGREFG_DATEEG_PK.Caption = "SPGREFG_DATEEG_PK"
        Me.colSPGREFG_DATEEG_PK.FieldName = "SPGREFG_DATEEG_PK"
        Me.colSPGREFG_DATEEG_PK.Name = "colSPGREFG_DATEEG_PK"
        Me.colSPGREFG_DATEEG_PK.Visible = True
        Me.colSPGREFG_DATEEG_PK.VisibleIndex = 1
        Me.colSPGREFG_DATEEG_PK.Width = 141
        '
        'colSPGREFG_DATESG
        '
        Me.colSPGREFG_DATESG.Caption = "SPGREFG_DATESG"
        Me.colSPGREFG_DATESG.FieldName = "SPGREFG_DATESG"
        Me.colSPGREFG_DATESG.Name = "colSPGREFG_DATESG"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.Panel12)
        Me.XtraTabPage3.Controls.Add(Me.Panel11)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(635, 484)
        Me.XtraTabPage3.Tag = "[NOADD][EDIT]"
        Me.XtraTabPage3.Text = "Historique"
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.GC8)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(0, 227)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(635, 257)
        Me.Panel12.TabIndex = 1
        '
        'GC8
        '
        Me.GC8.DataMember = "PREGREF_PRE_GROUPE_REF1"
        Me.GC8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC8.EmbeddedNavigator.Buttons.Append.Visible = False
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
        Me.GC8.Location = New System.Drawing.Point(0, 0)
        Me.GC8.MainView = Me.GV8
        Me.GC8.Name = "GC8"
        Me.GC8.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpSPH2})
        Me.GC8.Size = New System.Drawing.Size(635, 257)
        Me.GC8.TabIndex = 3
        Me.GC8.UseEmbeddedNavigator = True
        Me.GC8.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV8})
        '
        'GV8
        '
        Me.GV8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.colPREGREF_TYPE_PRE_H1, Me.colPREGREF_PRE_CODE_FK_PK2})
        Me.GV8.GridControl = Me.GC8
        Me.GV8.GroupPanelText = " "
        Me.GV8.Name = "GV8"
        Me.GV8.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV8.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV8.OptionsView.ShowGroupPanel = False
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "PREGREF_GREF_CODE_FK_PK"
        Me.GridColumn7.FieldName = "PREGREF_GREF_CODE_FK_PK"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "CIP"
        Me.GridColumn8.FieldName = "PREGREF_PRE_CODE_FK_PK"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowFocus = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        Me.GridColumn8.Width = 174
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Date d'entrée"
        Me.GridColumn9.FieldName = "PREGREF_DATEENTREE_PK"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 2
        Me.GridColumn9.Width = 90
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "PREGREF_GREF_DATECR_FK_PK"
        Me.GridColumn10.FieldName = "PREGREF_GREF_DATECR_FK_PK"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Date sortie"
        Me.GridColumn11.FieldName = "PREGREF_DATESORTIE"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 3
        Me.GridColumn11.Width = 96
        '
        'colPREGREF_TYPE_PRE_H1
        '
        Me.colPREGREF_TYPE_PRE_H1.Caption = "PREGREF_TYPE_PRE"
        Me.colPREGREF_TYPE_PRE_H1.FieldName = "PREGREF_TYPE_PRE"
        Me.colPREGREF_TYPE_PRE_H1.Name = "colPREGREF_TYPE_PRE_H1"
        '
        'colPREGREF_PRE_CODE_FK_PK2
        '
        Me.colPREGREF_PRE_CODE_FK_PK2.Caption = "Spécialités génériques"
        Me.colPREGREF_PRE_CODE_FK_PK2.ColumnEdit = Me.rpSPH2
        Me.colPREGREF_PRE_CODE_FK_PK2.FieldName = "PREGREF_PRE_CODE_FK_PK"
        Me.colPREGREF_PRE_CODE_FK_PK2.Name = "colPREGREF_PRE_CODE_FK_PK2"
        Me.colPREGREF_PRE_CODE_FK_PK2.OptionsColumn.AllowFocus = False
        Me.colPREGREF_PRE_CODE_FK_PK2.Visible = True
        Me.colPREGREF_PRE_CODE_FK_PK2.VisibleIndex = 0
        Me.colPREGREF_PRE_CODE_FK_PK2.Width = 276
        '
        'rpSPH2
        '
        Me.rpSPH2.AutoHeight = False
        Me.rpSPH2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpSPH2.Name = "rpSPH2"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.GC7)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(635, 227)
        Me.Panel11.TabIndex = 0
        '
        'GC7
        '
        Me.GC7.DataMember = "PREGREF_PRE_GROUPE_REF"
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
        Me.GC7.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC7.Location = New System.Drawing.Point(0, 0)
        Me.GC7.MainView = Me.GV7
        Me.GC7.Name = "GC7"
        Me.GC7.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpSPH})
        Me.GC7.Size = New System.Drawing.Size(635, 227)
        Me.GC7.TabIndex = 3
        Me.GC7.Tag = "[NOADD][EDIT]"
        Me.GC7.UseEmbeddedNavigator = True
        Me.GC7.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV7})
        '
        'GV7
        '
        Me.GV7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.colPREGREF_TYPE_PRE_H, Me.colPREGREF_PRE_CODE_FK_PK3})
        Me.GV7.GridControl = Me.GC7
        Me.GV7.GroupPanelText = " "
        Me.GV7.Name = "GV7"
        Me.GV7.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV7.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV7.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "PREGREF_GREF_CODE_FK_PK"
        Me.GridColumn1.FieldName = "PREGREF_GREF_CODE_FK_PK"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "CIP"
        Me.GridColumn2.FieldName = "PREGREF_PRE_CODE_FK_PK"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowFocus = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 126
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Date d'entrée"
        Me.GridColumn3.FieldName = "PREGREF_DATEENTREE_PK"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 114
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "PREGREF_GREF_DATECR_FK_PK"
        Me.GridColumn4.FieldName = "PREGREF_GREF_DATECR_FK_PK"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Date sortie"
        Me.GridColumn5.FieldName = "PREGREF_DATESORTIE"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 119
        '
        'colPREGREF_TYPE_PRE_H
        '
        Me.colPREGREF_TYPE_PRE_H.Caption = "PREGREF_TYPE_PRE"
        Me.colPREGREF_TYPE_PRE_H.FieldName = "PREGREF_TYPE_PRE"
        Me.colPREGREF_TYPE_PRE_H.Name = "colPREGREF_TYPE_PRE_H"
        '
        'colPREGREF_PRE_CODE_FK_PK3
        '
        Me.colPREGREF_PRE_CODE_FK_PK3.Caption = "Spécialité de référence"
        Me.colPREGREF_PRE_CODE_FK_PK3.ColumnEdit = Me.rpSPH
        Me.colPREGREF_PRE_CODE_FK_PK3.FieldName = "PREGREF_PRE_CODE_FK_PK"
        Me.colPREGREF_PRE_CODE_FK_PK3.Name = "colPREGREF_PRE_CODE_FK_PK3"
        Me.colPREGREF_PRE_CODE_FK_PK3.OptionsColumn.AllowFocus = False
        Me.colPREGREF_PRE_CODE_FK_PK3.Visible = True
        Me.colPREGREF_PRE_CODE_FK_PK3.VisibleIndex = 0
        Me.colPREGREF_PRE_CODE_FK_PK3.Width = 279
        '
        'rpSPH
        '
        Me.rpSPH.AutoHeight = False
        Me.rpSPH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpSPH.Name = "rpSPH"
        '
        'SpgrefR_TA
        '
        Me.SpgrefR_TA.ClearBeforeFill = True
        '
        'SP_TA
        '
        Me.SP_TA.ClearBeforeFill = True
        '
        'PregreF_TA
        '
        Me.PregreF_TA.ClearBeforeFill = True
        '
        'CosaU_TA
        '
        Me.CosaU_TA.ClearBeforeFill = True
        '
        'GreftX_TA
        '
        Me.GreftX_TA.ClearBeforeFill = True
        '
        'SpgrefG_TA
        '
        Me.SpgrefG_TA.ClearBeforeFill = True
        '
        'PregreF1_TA
        '
        Me.PregreF1_TA.ClearBeforeFill = True
        '
        'Frm_Generique
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(762, 585)
        Me.Name = "Frm_Generique"
        Me.Text = "Génériques"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_Nomenclature2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.GC12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditJO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpSau, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpPre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpGen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        CType(Me.DateEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditCrGroupe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        CType(Me.GC6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpSAU1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpPre1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        CType(Me.GC4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpSPG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        CType(Me.GC8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpSPH2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        CType(Me.GC7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpSPH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DsTheriaque_Nomenclature2 As Theriaque.dsTheriaque_Nomenclature2
    Friend WithEvents GreF_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.GREF_GROUPE_SPECIALITE_REFTableAdapter
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GC1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rpGen As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colSPGREFR_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPGREFR_GREF_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPGREFR_GREF_DATECR_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SpgrefR_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.SPGREFR_GROUPE_SPE_REFTableAdapter
    Friend WithEvents GC2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rpPre As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SP_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.SP_SPECIALITETableAdapter
    Friend WithEvents colPREGREF_GREF_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREGREF_PRE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREGREF_DATEENTREE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREGREF_GREF_DATECR_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREGREF_DATESORTIE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREGREF_TYPE_PRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PregreF_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.PREGREF_PRE_GROUPE_REFTableAdapter
    Friend WithEvents CosaU_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.COSAU_COMPO_SUBAUXTableAdapter
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rpSau As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colCOSAU_SAU_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAU_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAU_GREF_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAU_GREF_DATECR_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEditJO As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEditCrGroupe As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GC12 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rpMemo As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colGREFTX_GREF_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGREFTX_GREF_DATECR_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGREFTX_TEXTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GreftX_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.GREFTX_TEXTE_GROUPE_REFTableAdapter
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents GC6 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rpSAU1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GC5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rpPre1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents GC4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rpSPG As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SpgrefG_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.SPGREFG_GROUPE_SPE_GENETableAdapter
    Friend WithEvents colSPGREFG_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPGREFG_GREF_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPGREFG_GREF_DATECR_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPGREFG_DATEEG_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPGREFG_DATESG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PregreF1_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.PREGREF_PRE_GROUPE_REF1TableAdapter
    Friend WithEvents colPREGREF_GREF_CODE_FK_PK1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREGREF_PRE_CODE_FK_PK1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREGREF_DATEENTREE_PK1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREGREF_GREF_DATECR_FK_PK1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREGREF_DATESORTIE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREGREF_TYPE_PRE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAU_SAU_CODE_FK_PK1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAU_SP_CODE_FK_PK1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAU_DOSAGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAU_UNITEDOSAGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAU_COMPO_NUM_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAU_GREF_CODE_FK1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAU_GREF_DATECR_FK1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAU_GREF_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSAU_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents GC8 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpSPH2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREGREF_TYPE_PRE_H1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GC7 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpSPH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREGREF_TYPE_PRE_H As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DateEdit4 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents colPREGREF_PRE_CODE_FK_PK3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPREGREF_PRE_CODE_FK_PK2 As DevExpress.XtraGrid.Columns.GridColumn

End Class
