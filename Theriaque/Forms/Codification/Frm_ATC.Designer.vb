<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ATC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ATC))
        Me.tabControl = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.PanelSyno = New System.Windows.Forms.Panel
        Me.PanelR = New System.Windows.Forms.Panel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.GC2 = New DevExpress.XtraGrid.GridControl
        Me.DsTheriaque1 = New Theriaque.dsTheriaque
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSYAATC_NOM_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSYAATC_CATC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelL = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSYFATC_NOM_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSYFATC_CATC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GCFils = New DevExpress.XtraGrid.GridControl
        Me.AdvBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.BandedGridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BandedGridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GVFils = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCEPH_CODE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCEPH_NOMF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCEPH_NOMA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lkupLibellePere = New DevExpress.XtraEditors.LookUpEdit
        Me.txtLibelleGB = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtlibelleFr = New DevExpress.XtraEditors.TextEdit
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.txtCodePere = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GCDDD = New DevExpress.XtraGrid.GridControl
        Me.GVDDD = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colATCDDD_CATC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colATCDDD_CDF_VO_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkupCDF18 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colATCDDD_DOSAGE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colATCDDD_CDF_UD_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkupCDF19 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.MemoEdit2 = New DevExpress.XtraEditors.MemoEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit
        Me.CatC_CLASSEATCTableAdapter = New Theriaque.dsTheriaqueTableAdapters.CATC_CLASSEATCTableAdapter
        Me.SyaatC_SYNONYMEANGLAIS_ATCTableAdapter = New Theriaque.dsTheriaqueTableAdapters.SYAATC_SYNONYMEANGLAIS_ATCTableAdapter
        Me.SyfatC_SYNONYMEFR_ATCTableAdapter = New Theriaque.dsTheriaqueTableAdapters.SYFATC_SYNONYMEFR_ATCTableAdapter
        Me.CatC_CLASSEATCTableAdapterFils = New Theriaque.dsTheriaqueTableAdapters.CATC_CLASSEATCTableAdapter
        Me.AtcddD_DOSE_USUELLE_JOURTableAdapter = New Theriaque.dsTheriaqueTableAdapters.ATCDDD_DOSE_USUELLE_JOURTableAdapter
        Me.CdF_CODIFTableAdapter = New Theriaque.dsTheriaqueTableAdapters.CDF_CODIFTableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.PanelSyno.SuspendLayout()
        Me.PanelR.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelL.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GCFils, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVFils, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupLibellePere.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibelleGB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtlibelleFr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodePere.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GCDDD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDDD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupCDF18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupCDF19, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(740, 640)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.tabControl)
        Me.PanMain.Size = New System.Drawing.Size(622, 553)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(740, 87)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(740, 28)
        Me.Label1.Text = "Classe ATC"
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
        Me.Panel1.Location = New System.Drawing.Point(622, 87)
        Me.Panel1.Size = New System.Drawing.Size(118, 553)
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CATC_CLASSEATC.CATC_DATEMJ", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Size = New System.Drawing.Size(740, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CATC_CLASSEATC.CATC_DATECR", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        '
        'tabControl
        '
        Me.tabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabControl.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.tabControl.Location = New System.Drawing.Point(4, 3)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedTabPage = Me.XtraTabPage1
        Me.tabControl.Size = New System.Drawing.Size(615, 547)
        Me.tabControl.TabIndex = 0
        Me.tabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        Me.tabControl.Text = "ATC"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.PageClient.ForeColor = System.Drawing.Color.Black
        Me.XtraTabPage1.Appearance.PageClient.Options.UseForeColor = True
        Me.XtraTabPage1.Controls.Add(Me.PanelSyno)
        Me.XtraTabPage1.Controls.Add(Me.GroupBox4)
        Me.XtraTabPage1.Controls.Add(Me.PictureBox2)
        Me.XtraTabPage1.Controls.Add(Me.PictureBox1)
        Me.XtraTabPage1.Controls.Add(Me.GroupBox1)
        Me.XtraTabPage1.Controls.Add(Me.lkupLibellePere)
        Me.XtraTabPage1.Controls.Add(Me.txtLibelleGB)
        Me.XtraTabPage1.Controls.Add(Me.Label4)
        Me.XtraTabPage1.Controls.Add(Me.Label6)
        Me.XtraTabPage1.Controls.Add(Me.Label5)
        Me.XtraTabPage1.Controls.Add(Me.txtlibelleFr)
        Me.XtraTabPage1.Controls.Add(Me.txtCode)
        Me.XtraTabPage1.Controls.Add(Me.txtCodePere)
        Me.XtraTabPage1.Controls.Add(Me.Label3)
        Me.XtraTabPage1.Controls.Add(Me.Label2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(606, 516)
        Me.XtraTabPage1.Text = "ATC"
        '
        'PanelSyno
        '
        Me.PanelSyno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelSyno.Controls.Add(Me.PanelR)
        Me.PanelSyno.Controls.Add(Me.PanelL)
        Me.PanelSyno.Location = New System.Drawing.Point(8, 129)
        Me.PanelSyno.Name = "PanelSyno"
        Me.PanelSyno.Size = New System.Drawing.Size(597, 199)
        Me.PanelSyno.TabIndex = 30
        Me.PanelSyno.Tag = "[EDIT][NOADD]"
        '
        'PanelR
        '
        Me.PanelR.Controls.Add(Me.GroupBox3)
        Me.PanelR.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelR.Location = New System.Drawing.Point(310, 0)
        Me.PanelR.Name = "PanelR"
        Me.PanelR.Size = New System.Drawing.Size(287, 199)
        Me.PanelR.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox4)
        Me.GroupBox3.Controls.Add(Me.GC2)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox3.Size = New System.Drawing.Size(287, 199)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Tag = ""
        Me.GroupBox3.Text = "Synonymes anglais"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(6, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(25, 20)
        Me.PictureBox4.TabIndex = 28
        Me.PictureBox4.TabStop = False
        '
        'GC2
        '
        Me.GC2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC2.DataMember = "SYAATC_SYNONYMEANGLAIS_ATC"
        Me.GC2.DataSource = Me.DsTheriaque1
        Me.GC2.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC2.EmbeddedNavigator.Name = ""
        Me.GC2.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC2.Location = New System.Drawing.Point(10, 19)
        Me.GC2.MainView = Me.GV2
        Me.GC2.Name = "GC2"
        Me.GC2.Size = New System.Drawing.Size(271, 174)
        Me.GC2.TabIndex = 0
        Me.GC2.Tag = ""
        Me.GC2.UseEmbeddedNavigator = True
        Me.GC2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'DsTheriaque1
        '
        Me.DsTheriaque1.DataSetName = "dsTheriaque"
        Me.DsTheriaque1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSYAATC_NOM_PK, Me.colSYAATC_CATC_CODE_FK_PK})
        Me.GV2.GridControl = Me.GC2
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV2.OptionsView.ShowGroupPanel = False
        '
        'colSYAATC_NOM_PK
        '
        Me.colSYAATC_NOM_PK.Caption = "Libellé"
        Me.colSYAATC_NOM_PK.FieldName = "SYAATC_NOM_PK"
        Me.colSYAATC_NOM_PK.Name = "colSYAATC_NOM_PK"
        Me.colSYAATC_NOM_PK.Visible = True
        Me.colSYAATC_NOM_PK.VisibleIndex = 0
        '
        'colSYAATC_CATC_CODE_FK_PK
        '
        Me.colSYAATC_CATC_CODE_FK_PK.Caption = "SYAATC_CATC_CODE_FK_PK"
        Me.colSYAATC_CATC_CODE_FK_PK.FieldName = "SYAATC_CATC_CODE_FK_PK"
        Me.colSYAATC_CATC_CODE_FK_PK.Name = "colSYAATC_CATC_CODE_FK_PK"
        '
        'PanelL
        '
        Me.PanelL.Controls.Add(Me.GroupBox2)
        Me.PanelL.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelL.Location = New System.Drawing.Point(0, 0)
        Me.PanelL.Name = "PanelL"
        Me.PanelL.Size = New System.Drawing.Size(304, 199)
        Me.PanelL.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GC)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(304, 199)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = ""
        Me.GroupBox2.Text = "Synonymes français"
        '
        'GC
        '
        Me.GC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC.DataMember = "SYFATC_SYNONYMEFR_ATC"
        Me.GC.DataSource = Me.DsTheriaque1
        Me.GC.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC.EmbeddedNavigator.Name = ""
        Me.GC.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC.Location = New System.Drawing.Point(6, 19)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.Size = New System.Drawing.Size(289, 174)
        Me.GC.TabIndex = 27
        Me.GC.UseEmbeddedNavigator = True
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSYFATC_NOM_PK, Me.colSYFATC_CATC_CODE_FK_PK})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'colSYFATC_NOM_PK
        '
        Me.colSYFATC_NOM_PK.Caption = "Libellé"
        Me.colSYFATC_NOM_PK.FieldName = "SYFATC_NOM_PK"
        Me.colSYFATC_NOM_PK.Name = "colSYFATC_NOM_PK"
        Me.colSYFATC_NOM_PK.Visible = True
        Me.colSYFATC_NOM_PK.VisibleIndex = 0
        '
        'colSYFATC_CATC_CODE_FK_PK
        '
        Me.colSYFATC_CATC_CODE_FK_PK.Caption = "SYFATC_CATC_CODE_FK_PK"
        Me.colSYFATC_CATC_CODE_FK_PK.FieldName = "SYFATC_CATC_CODE_FK_PK"
        Me.colSYFATC_CATC_CODE_FK_PK.Name = "colSYFATC_CATC_CODE_FK_PK"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(6, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 20)
        Me.PictureBox3.TabIndex = 26
        Me.PictureBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.GCFils)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 328)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(596, 185)
        Me.GroupBox4.TabIndex = 31
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Fils"
        '
        'GCFils
        '
        Me.GCFils.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GCFils.EmbeddedNavigator.Name = ""
        Me.GCFils.Location = New System.Drawing.Point(6, 15)
        Me.GCFils.MainView = Me.AdvBandedGridView1
        Me.GCFils.Name = "GCFils"
        Me.GCFils.Size = New System.Drawing.Size(583, 164)
        Me.GCFils.TabIndex = 0
        Me.GCFils.Tag = "[NOADD][EDIT]"
        Me.GCFils.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.AdvBandedGridView1, Me.GVFils})
        '
        'AdvBandedGridView1
        '
        Me.AdvBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.AdvBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.BandedGridColumn1, Me.BandedGridColumn2, Me.BandedGridColumn3})
        Me.AdvBandedGridView1.GridControl = Me.GCFils
        Me.AdvBandedGridView1.Name = "AdvBandedGridView1"
        Me.AdvBandedGridView1.OptionsView.ColumnAutoWidth = True
        Me.AdvBandedGridView1.OptionsView.ShowBands = False
        Me.AdvBandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Columns.Add(Me.BandedGridColumn1)
        Me.GridBand1.Columns.Add(Me.BandedGridColumn2)
        Me.GridBand1.Columns.Add(Me.BandedGridColumn3)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 503
        '
        'BandedGridColumn1
        '
        Me.BandedGridColumn1.Caption = "Code"
        Me.BandedGridColumn1.FieldName = "CATC_CODE_PK"
        Me.BandedGridColumn1.Name = "BandedGridColumn1"
        Me.BandedGridColumn1.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn1.OptionsColumn.AllowFocus = False
        Me.BandedGridColumn1.Visible = True
        Me.BandedGridColumn1.Width = 61
        '
        'BandedGridColumn2
        '
        Me.BandedGridColumn2.Caption = "Libellé FR"
        Me.BandedGridColumn2.FieldName = "CATC_NOMF"
        Me.BandedGridColumn2.Name = "BandedGridColumn2"
        Me.BandedGridColumn2.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn2.OptionsColumn.AllowFocus = False
        Me.BandedGridColumn2.Visible = True
        Me.BandedGridColumn2.Width = 205
        '
        'BandedGridColumn3
        '
        Me.BandedGridColumn3.Caption = "Libellé GB"
        Me.BandedGridColumn3.FieldName = "CATC_NOMA"
        Me.BandedGridColumn3.Name = "BandedGridColumn3"
        Me.BandedGridColumn3.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn3.OptionsColumn.AllowFocus = False
        Me.BandedGridColumn3.Visible = True
        Me.BandedGridColumn3.Width = 237
        '
        'GVFils
        '
        Me.GVFils.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCEPH_CODE_PK, Me.colCEPH_NOMF, Me.colCEPH_NOMA})
        Me.GVFils.GridControl = Me.GCFils
        Me.GVFils.Name = "GVFils"
        Me.GVFils.OptionsView.ShowGroupPanel = False
        '
        'colCEPH_CODE_PK
        '
        Me.colCEPH_CODE_PK.Caption = "Code"
        Me.colCEPH_CODE_PK.FieldName = "CEPH_CODE_PK"
        Me.colCEPH_CODE_PK.Name = "colCEPH_CODE_PK"
        Me.colCEPH_CODE_PK.Visible = True
        Me.colCEPH_CODE_PK.VisibleIndex = 0
        Me.colCEPH_CODE_PK.Width = 90
        '
        'colCEPH_NOMF
        '
        Me.colCEPH_NOMF.Caption = "Libellé FR"
        Me.colCEPH_NOMF.FieldName = "CEPH_NOMF"
        Me.colCEPH_NOMF.Name = "colCEPH_NOMF"
        Me.colCEPH_NOMF.Visible = True
        Me.colCEPH_NOMF.VisibleIndex = 2
        Me.colCEPH_NOMF.Width = 213
        '
        'colCEPH_NOMA
        '
        Me.colCEPH_NOMA.Caption = "Libellé GB"
        Me.colCEPH_NOMA.FieldName = "CEPH_NOMA"
        Me.colCEPH_NOMA.Name = "colCEPH_NOMA"
        Me.colCEPH_NOMA.Visible = True
        Me.colCEPH_NOMA.VisibleIndex = 1
        Me.colCEPH_NOMA.Width = 209
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(566, 103)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 20)
        Me.PictureBox2.TabIndex = 41
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(566, 77)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(595, 8)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'lkupLibellePere
        '
        Me.lkupLibellePere.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkupLibellePere.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CATC_CLASSEATC.CATC_CATC_CODE_FK", True))
        Me.lkupLibellePere.Location = New System.Drawing.Point(235, 5)
        Me.lkupLibellePere.Name = "lkupLibellePere"
        Me.lkupLibellePere.Properties.NullText = ""
        Me.lkupLibellePere.Properties.ReadOnly = True
        Me.lkupLibellePere.Size = New System.Drawing.Size(329, 20)
        Me.lkupLibellePere.TabIndex = 35
        Me.lkupLibellePere.Tag = "[NOEDIT][NOADD]"
        '
        'txtLibelleGB
        '
        Me.txtLibelleGB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLibelleGB.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CATC_CLASSEATC.CATC_NOMA", True))
        Me.txtLibelleGB.Location = New System.Drawing.Point(89, 100)
        Me.txtLibelleGB.Name = "txtLibelleGB"
        Me.txtLibelleGB.Properties.MaxLength = 77
        Me.txtLibelleGB.Size = New System.Drawing.Size(475, 20)
        Me.txtLibelleGB.TabIndex = 29
        Me.txtLibelleGB.Tag = "[EDIT][ADD]"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Libellé GB"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Libellé FR"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(192, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Libellé"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtlibelleFr
        '
        Me.txtlibelleFr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtlibelleFr.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CATC_CLASSEATC.CATC_NOMF", True))
        Me.txtlibelleFr.Location = New System.Drawing.Point(89, 74)
        Me.txtlibelleFr.Name = "txtlibelleFr"
        Me.txtlibelleFr.Properties.MaxLength = 77
        Me.txtlibelleFr.Size = New System.Drawing.Size(475, 20)
        Me.txtlibelleFr.TabIndex = 28
        Me.txtlibelleFr.Tag = "[EDIT][ADD]"
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CATC_CLASSEATC.CATC_CODE_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(89, 48)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 27
        Me.txtCode.Tag = "[NOEDIT][ADD]"
        '
        'txtCodePere
        '
        Me.txtCodePere.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CATC_CLASSEATC.CATC_CATC_CODE_FK", True))
        Me.txtCodePere.Location = New System.Drawing.Point(89, 4)
        Me.txtCodePere.Name = "txtCodePere"
        Me.txtCodePere.Properties.ReadOnly = True
        Me.txtCodePere.Size = New System.Drawing.Size(100, 20)
        Me.txtCodePere.TabIndex = 34
        Me.txtCodePere.Tag = "[NOEDIT][NOADD]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Fiche N°"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Code père"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Panel3)
        Me.XtraTabPage2.Controls.Add(Me.Panel2)
        Me.XtraTabPage2.Controls.Add(Me.GroupBox6)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(496, 442)
        Me.XtraTabPage2.Tag = ""
        Me.XtraTabPage2.Text = "DDD"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GCDDD)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 61)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(496, 381)
        Me.Panel3.TabIndex = 29
        '
        'GCDDD
        '
        Me.GCDDD.DataMember = "ATCDDD_DOSE_USUELLE_JOUR"
        Me.GCDDD.DataSource = Me.DsTheriaque1
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
        Me.GCDDD.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkupCDF18, Me.lkupCDF19})
        Me.GCDDD.Size = New System.Drawing.Size(496, 381)
        Me.GCDDD.TabIndex = 27
        Me.GCDDD.Tag = "[NOADD][EDIT]"
        Me.GCDDD.UseEmbeddedNavigator = True
        Me.GCDDD.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDDD})
        '
        'GVDDD
        '
        Me.GVDDD.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colATCDDD_CATC_CODE_FK_PK, Me.colATCDDD_CDF_VO_CODE_FK_PK, Me.colATCDDD_DOSAGE_PK, Me.colATCDDD_CDF_UD_CODE_FK_PK})
        Me.GVDDD.GridControl = Me.GCDDD
        Me.GVDDD.Name = "GVDDD"
        Me.GVDDD.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GVDDD.OptionsView.ShowGroupPanel = False
        '
        'colATCDDD_CATC_CODE_FK_PK
        '
        Me.colATCDDD_CATC_CODE_FK_PK.Caption = "ATCDDD_CATC_CODE_FK_PK"
        Me.colATCDDD_CATC_CODE_FK_PK.FieldName = "ATCDDD_CATC_CODE_FK_PK"
        Me.colATCDDD_CATC_CODE_FK_PK.Name = "colATCDDD_CATC_CODE_FK_PK"
        '
        'colATCDDD_CDF_VO_CODE_FK_PK
        '
        Me.colATCDDD_CDF_VO_CODE_FK_PK.Caption = "Voie d'administration"
        Me.colATCDDD_CDF_VO_CODE_FK_PK.ColumnEdit = Me.lkupCDF18
        Me.colATCDDD_CDF_VO_CODE_FK_PK.FieldName = "ATCDDD_CDF_VO_CODE_FK_PK"
        Me.colATCDDD_CDF_VO_CODE_FK_PK.Name = "colATCDDD_CDF_VO_CODE_FK_PK"
        Me.colATCDDD_CDF_VO_CODE_FK_PK.Visible = True
        Me.colATCDDD_CDF_VO_CODE_FK_PK.VisibleIndex = 0
        Me.colATCDDD_CDF_VO_CODE_FK_PK.Width = 217
        '
        'lkupCDF18
        '
        Me.lkupCDF18.AutoHeight = False
        Me.lkupCDF18.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupCDF18.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CDF_NOM", "Libellé", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.lkupCDF18.DataSource = Me.DsTheriaque1
        Me.lkupCDF18.DisplayMember = "CDF_NOM"
        Me.lkupCDF18.Name = "lkupCDF18"
        Me.lkupCDF18.NullText = ""
        Me.lkupCDF18.PopupWidth = 300
        Me.lkupCDF18.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.lkupCDF18.ValueMember = "CDF_CODE_PK"
        '
        'colATCDDD_DOSAGE_PK
        '
        Me.colATCDDD_DOSAGE_PK.Caption = "Dosage"
        Me.colATCDDD_DOSAGE_PK.FieldName = "ATCDDD_DOSAGE_PK"
        Me.colATCDDD_DOSAGE_PK.Name = "colATCDDD_DOSAGE_PK"
        Me.colATCDDD_DOSAGE_PK.Visible = True
        Me.colATCDDD_DOSAGE_PK.VisibleIndex = 1
        Me.colATCDDD_DOSAGE_PK.Width = 58
        '
        'colATCDDD_CDF_UD_CODE_FK_PK
        '
        Me.colATCDDD_CDF_UD_CODE_FK_PK.Caption = "Unité de dosage"
        Me.colATCDDD_CDF_UD_CODE_FK_PK.ColumnEdit = Me.lkupCDF19
        Me.colATCDDD_CDF_UD_CODE_FK_PK.FieldName = "ATCDDD_CDF_UD_CODE_FK_PK"
        Me.colATCDDD_CDF_UD_CODE_FK_PK.Name = "colATCDDD_CDF_UD_CODE_FK_PK"
        Me.colATCDDD_CDF_UD_CODE_FK_PK.Visible = True
        Me.colATCDDD_CDF_UD_CODE_FK_PK.VisibleIndex = 2
        Me.colATCDDD_CDF_UD_CODE_FK_PK.Width = 233
        '
        'lkupCDF19
        '
        Me.lkupCDF19.AutoHeight = False
        Me.lkupCDF19.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupCDF19.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CDF_NOM", "Libellé", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.lkupCDF19.DisplayMember = "CDF_NOM"
        Me.lkupCDF19.Name = "lkupCDF19"
        Me.lkupCDF19.NullText = ""
        Me.lkupCDF19.PopupWidth = 300
        Me.lkupCDF19.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.lkupCDF19.ValueMember = "CDF_CODE_PK"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MemoEdit2)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(496, 61)
        Me.Panel2.TabIndex = 28
        '
        'MemoEdit2
        '
        Me.MemoEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CATC_CLASSEATC.CATC_TEXTE", True))
        Me.MemoEdit2.Location = New System.Drawing.Point(51, 8)
        Me.MemoEdit2.Name = "MemoEdit2"
        Me.MemoEdit2.Size = New System.Drawing.Size(540, 38)
        Me.MemoEdit2.TabIndex = 41
        Me.MemoEdit2.Tag = "[ADD][EDIT]"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Texte"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.MemoEdit1)
        Me.GroupBox6.Location = New System.Drawing.Point(0, 1772)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(2688, 224)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Tag = "[EDIT]"
        Me.GroupBox6.Text = "Texte"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MemoEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CATC_CLASSEATC.CATC_TEXTE", True))
        Me.MemoEdit1.Location = New System.Drawing.Point(6, 38)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(2676, 150)
        Me.MemoEdit1.TabIndex = 0
        '
        'CatC_CLASSEATCTableAdapter
        '
        Me.CatC_CLASSEATCTableAdapter.ClearBeforeFill = True
        '
        'SyaatC_SYNONYMEANGLAIS_ATCTableAdapter
        '
        Me.SyaatC_SYNONYMEANGLAIS_ATCTableAdapter.ClearBeforeFill = True
        '
        'SyfatC_SYNONYMEFR_ATCTableAdapter
        '
        Me.SyfatC_SYNONYMEFR_ATCTableAdapter.ClearBeforeFill = True
        '
        'CatC_CLASSEATCTableAdapterFils
        '
        Me.CatC_CLASSEATCTableAdapterFils.ClearBeforeFill = True
        '
        'AtcddD_DOSE_USUELLE_JOURTableAdapter
        '
        Me.AtcddD_DOSE_USUELLE_JOURTableAdapter.ClearBeforeFill = True
        '
        'CdF_CODIFTableAdapter
        '
        Me.CdF_CODIFTableAdapter.ClearBeforeFill = True
        '
        'Frm_ATC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(740, 640)
        Me.Name = "Frm_ATC"
        Me.Text = "Classe ATC"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        Me.PanelSyno.ResumeLayout(False)
        Me.PanelR.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelL.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.GCFils, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVFils, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupLibellePere.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibelleGB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtlibelleFr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodePere.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.GCDDD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDDD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupCDF18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupCDF19, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelSyno As System.Windows.Forms.Panel
    Friend WithEvents PanelR As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents GC2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSYAATC_NOM_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSYAATC_CATC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelL As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSYFATC_NOM_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSYFATC_CATC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GCFils As DevExpress.XtraGrid.GridControl
    Friend WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GVFils As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCEPH_CODE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCEPH_NOMF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCEPH_NOMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lkupLibellePere As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtLibelleGB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtlibelleFr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodePere As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GCDDD As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVDDD As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents DsTheriaque1 As Theriaque.dsTheriaque
    Friend WithEvents CatC_CLASSEATCTableAdapter As Theriaque.dsTheriaqueTableAdapters.CATC_CLASSEATCTableAdapter
    Friend WithEvents SyaatC_SYNONYMEANGLAIS_ATCTableAdapter As Theriaque.dsTheriaqueTableAdapters.SYAATC_SYNONYMEANGLAIS_ATCTableAdapter
    Friend WithEvents SyfatC_SYNONYMEFR_ATCTableAdapter As Theriaque.dsTheriaqueTableAdapters.SYFATC_SYNONYMEFR_ATCTableAdapter
    Friend WithEvents CatC_CLASSEATCTableAdapterFils As Theriaque.dsTheriaqueTableAdapters.CATC_CLASSEATCTableAdapter
    Friend WithEvents AtcddD_DOSE_USUELLE_JOURTableAdapter As Theriaque.dsTheriaqueTableAdapters.ATCDDD_DOSE_USUELLE_JOURTableAdapter
    Friend WithEvents colATCDDD_CATC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colATCDDD_CDF_VO_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colATCDDD_DOSAGE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colATCDDD_CDF_UD_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CdF_CODIFTableAdapter As Theriaque.dsTheriaqueTableAdapters.CDF_CODIFTableAdapter
    Friend WithEvents lkupCDF18 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lkupCDF19 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MemoEdit2 As DevExpress.XtraEditors.MemoEdit

End Class
