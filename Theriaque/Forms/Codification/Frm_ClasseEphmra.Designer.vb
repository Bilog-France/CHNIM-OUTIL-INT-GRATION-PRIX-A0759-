<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ClasseEphmra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ClasseEphmra))
        Me.lkupLibellePere = New DevExpress.XtraEditors.LookUpEdit
        Me.DsTheriaque2 = New Theriaque.dsTheriaque2
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.txtCodePere = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtLibelleGB = New DevExpress.XtraEditors.TextEdit
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSYFEPH_NOM_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSYFEPH_CEPH_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.GC2 = New DevExpress.XtraGrid.GridControl
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSYAEPH_NOM_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSYAEPH_CEPH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
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
        Me.txtlibelleFr = New DevExpress.XtraEditors.TextEdit
        Me.CepH_CLASSEEPHMRATableAdapter = New Theriaque.dsTheriaque2TableAdapters.CEPH_CLASSEEPHMRATableAdapter
        Me.SyaepH_SYNONYMEANGLAIS_EPHMRATableAdapter = New Theriaque.dsTheriaque2TableAdapters.SYAEPH_SYNONYMEANGLAIS_EPHMRATableAdapter
        Me.SyfepH_SYNONYMEFR_EPHMRATableAdapter = New Theriaque.dsTheriaque2TableAdapters.SYFEPH_SYNONYMEFR_EPHMRATableAdapter
        Me.CepH_CLASSEEPHMRATableAdapter1 = New Theriaque.dsTheriaque2TableAdapters.CEPH_CLASSEEPHMRATableAdapter
        Me.CepH_CLASSEEPHMRATableAdapterFils = New Theriaque.dsTheriaque2TableAdapters.CEPH_CLASSEEPHMRATableAdapter
        Me.PanelSyno = New System.Windows.Forms.Panel
        Me.PanelR = New System.Windows.Forms.Panel
        Me.PanelL = New System.Windows.Forms.Panel
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupLibellePere.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodePere.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibelleGB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GCFils, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVFils, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtlibelleFr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSyno.SuspendLayout()
        Me.PanelR.SuspendLayout()
        Me.PanelL.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(734, 630)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.PanelSyno)
        Me.PanMain.Controls.Add(Me.GroupBox4)
        Me.PanMain.Controls.Add(Me.PictureBox2)
        Me.PanMain.Controls.Add(Me.PictureBox1)
        Me.PanMain.Controls.Add(Me.GroupBox1)
        Me.PanMain.Controls.Add(Me.lkupLibellePere)
        Me.PanMain.Controls.Add(Me.txtLibelleGB)
        Me.PanMain.Controls.Add(Me.Label4)
        Me.PanMain.Controls.Add(Me.Label6)
        Me.PanMain.Controls.Add(Me.Label5)
        Me.PanMain.Controls.Add(Me.txtlibelleFr)
        Me.PanMain.Controls.Add(Me.txtCode)
        Me.PanMain.Controls.Add(Me.txtCodePere)
        Me.PanMain.Controls.Add(Me.Label3)
        Me.PanMain.Controls.Add(Me.Label2)
        Me.PanMain.Size = New System.Drawing.Size(608, 543)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(734, 87)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(734, 28)
        Me.Label1.Text = "Classe Ephmra"
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
        Me.Panel1.Location = New System.Drawing.Point(608, 87)
        Me.Panel1.Size = New System.Drawing.Size(126, 543)
        Me.Panel1.TabIndex = 5
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque2, "CEPH_CLASSEEPHMRA.CEPH_DATEMJ", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Size = New System.Drawing.Size(734, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque2, "CEPH_CLASSEEPHMRA.CEPH_DATECR", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        '
        'lkupLibellePere
        '
        Me.lkupLibellePere.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkupLibellePere.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque2, "CEPH_CLASSEEPHMRA.CEPH_CEPH_CODE_FK", True))
        Me.lkupLibellePere.Location = New System.Drawing.Point(242, 13)
        Me.lkupLibellePere.Name = "lkupLibellePere"
        Me.lkupLibellePere.Properties.NullText = ""
        Me.lkupLibellePere.Properties.ReadOnly = True
        Me.lkupLibellePere.Size = New System.Drawing.Size(323, 20)
        Me.lkupLibellePere.TabIndex = 19
        Me.lkupLibellePere.Tag = "[NOEDIT][NOADD]"
        '
        'DsTheriaque2
        '
        Me.DsTheriaque2.DataSetName = "dsTheriaque2"
        Me.DsTheriaque2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Libellé FR"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(199, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Libellé"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque2, "CEPH_CLASSEEPHMRA.CEPH_CODE_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(96, 56)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Properties.MaxLength = 5
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Tag = "[NOEDIT][ADD]"
        '
        'txtCodePere
        '
        Me.txtCodePere.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque2, "CEPH_CLASSEEPHMRA.CEPH_CEPH_CODE_FK", True))
        Me.txtCodePere.Location = New System.Drawing.Point(96, 12)
        Me.txtCodePere.Name = "txtCodePere"
        Me.txtCodePere.Properties.ReadOnly = True
        Me.txtCodePere.Size = New System.Drawing.Size(100, 20)
        Me.txtCodePere.TabIndex = 18
        Me.txtCodePere.Tag = "[NOEDIT][NOADD]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Fiche N°"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Code père"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(589, 8)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Libellé GB"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLibelleGB
        '
        Me.txtLibelleGB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLibelleGB.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque2, "CEPH_CLASSEEPHMRA.CEPH_NOMA", True))
        Me.txtLibelleGB.Location = New System.Drawing.Point(96, 108)
        Me.txtLibelleGB.Name = "txtLibelleGB"
        Me.txtLibelleGB.Size = New System.Drawing.Size(469, 20)
        Me.txtLibelleGB.TabIndex = 2
        Me.txtLibelleGB.Tag = "[EDIT]"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(567, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 20)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(567, 111)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 20)
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GC)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(303, 199)
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
        Me.GC.DataMember = "SYFEPH_SYNONYMEFR_EPHMRA"
        Me.GC.DataSource = Me.DsTheriaque2
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
        Me.GC.Size = New System.Drawing.Size(288, 174)
        Me.GC.TabIndex = 27
        Me.GC.UseEmbeddedNavigator = True
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSYFEPH_NOM_PK, Me.colSYFEPH_CEPH_CODE_FK})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'colSYFEPH_NOM_PK
        '
        Me.colSYFEPH_NOM_PK.Caption = "Libellé"
        Me.colSYFEPH_NOM_PK.FieldName = "SYFEPH_NOM_PK"
        Me.colSYFEPH_NOM_PK.Name = "colSYFEPH_NOM_PK"
        Me.colSYFEPH_NOM_PK.Visible = True
        Me.colSYFEPH_NOM_PK.VisibleIndex = 0
        '
        'colSYFEPH_CEPH_CODE_FK
        '
        Me.colSYFEPH_CEPH_CODE_FK.Caption = "SYFEPH_CEPH_CODE_FK"
        Me.colSYFEPH_CEPH_CODE_FK.FieldName = "SYFEPH_CEPH_CODE_FK"
        Me.colSYFEPH_CEPH_CODE_FK.Name = "colSYFEPH_CEPH_CODE_FK"
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
        Me.GC2.DataMember = "SYAEPH_SYNONYMEANGLAIS_EPHMRA"
        Me.GC2.DataSource = Me.DsTheriaque2
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
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSYAEPH_NOM_PK, Me.colSYAEPH_CEPH_CODE_FK_PK})
        Me.GV2.GridControl = Me.GC2
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV2.OptionsView.ShowGroupPanel = False
        '
        'colSYAEPH_NOM_PK
        '
        Me.colSYAEPH_NOM_PK.Caption = "Libellé"
        Me.colSYAEPH_NOM_PK.FieldName = "SYAEPH_NOM_PK"
        Me.colSYAEPH_NOM_PK.Name = "colSYAEPH_NOM_PK"
        Me.colSYAEPH_NOM_PK.Visible = True
        Me.colSYAEPH_NOM_PK.VisibleIndex = 0
        '
        'colSYAEPH_CEPH_CODE_FK_PK
        '
        Me.colSYAEPH_CEPH_CODE_FK_PK.Caption = "SYAEPH_CEPH_CODE_FK_PK"
        Me.colSYAEPH_CEPH_CODE_FK_PK.FieldName = "SYAEPH_CEPH_CODE_FK_PK"
        Me.colSYAEPH_CEPH_CODE_FK_PK.Name = "colSYAEPH_CEPH_CODE_FK_PK"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.GCFils)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 336)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(596, 207)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Tag = "[EDIT][NOADD]"
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
        Me.GCFils.Size = New System.Drawing.Size(583, 185)
        Me.GCFils.TabIndex = 0
        Me.GCFils.Tag = ""
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
        Me.GridBand1.Width = 562
        '
        'BandedGridColumn1
        '
        Me.BandedGridColumn1.Caption = "Code"
        Me.BandedGridColumn1.FieldName = "CEPH_CODE_PK"
        Me.BandedGridColumn1.Name = "BandedGridColumn1"
        Me.BandedGridColumn1.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn1.OptionsColumn.AllowFocus = False
        Me.BandedGridColumn1.Visible = True
        Me.BandedGridColumn1.Width = 51
        '
        'BandedGridColumn2
        '
        Me.BandedGridColumn2.Caption = "Libellé FR"
        Me.BandedGridColumn2.FieldName = "CEPH_NOMF"
        Me.BandedGridColumn2.Name = "BandedGridColumn2"
        Me.BandedGridColumn2.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn2.OptionsColumn.AllowFocus = False
        Me.BandedGridColumn2.Visible = True
        Me.BandedGridColumn2.Width = 229
        '
        'BandedGridColumn3
        '
        Me.BandedGridColumn3.Caption = "Libellé GB"
        Me.BandedGridColumn3.FieldName = "CEPH_NOMA"
        Me.BandedGridColumn3.Name = "BandedGridColumn3"
        Me.BandedGridColumn3.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn3.OptionsColumn.AllowFocus = False
        Me.BandedGridColumn3.Visible = True
        Me.BandedGridColumn3.Width = 282
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
        'txtlibelleFr
        '
        Me.txtlibelleFr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtlibelleFr.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque2, "CEPH_CLASSEEPHMRA.CEPH_NOMF", True))
        Me.txtlibelleFr.Location = New System.Drawing.Point(96, 82)
        Me.txtlibelleFr.Name = "txtlibelleFr"
        Me.txtlibelleFr.Size = New System.Drawing.Size(469, 20)
        Me.txtlibelleFr.TabIndex = 1
        Me.txtlibelleFr.Tag = "[EDIT]"
        '
        'CepH_CLASSEEPHMRATableAdapter
        '
        Me.CepH_CLASSEEPHMRATableAdapter.ClearBeforeFill = True
        '
        'SyaepH_SYNONYMEANGLAIS_EPHMRATableAdapter
        '
        Me.SyaepH_SYNONYMEANGLAIS_EPHMRATableAdapter.ClearBeforeFill = True
        '
        'SyfepH_SYNONYMEFR_EPHMRATableAdapter
        '
        Me.SyfepH_SYNONYMEFR_EPHMRATableAdapter.ClearBeforeFill = True
        '
        'CepH_CLASSEEPHMRATableAdapter1
        '
        Me.CepH_CLASSEEPHMRATableAdapter1.ClearBeforeFill = True
        '
        'CepH_CLASSEEPHMRATableAdapterFils
        '
        Me.CepH_CLASSEEPHMRATableAdapterFils.ClearBeforeFill = True
        '
        'PanelSyno
        '
        Me.PanelSyno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelSyno.Controls.Add(Me.PanelR)
        Me.PanelSyno.Controls.Add(Me.PanelL)
        Me.PanelSyno.Location = New System.Drawing.Point(10, 137)
        Me.PanelSyno.Name = "PanelSyno"
        Me.PanelSyno.Size = New System.Drawing.Size(596, 199)
        Me.PanelSyno.TabIndex = 3
        Me.PanelSyno.Tag = "[EDIT][NOADD]"
        '
        'PanelR
        '
        Me.PanelR.Controls.Add(Me.GroupBox3)
        Me.PanelR.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelR.Location = New System.Drawing.Point(309, 0)
        Me.PanelR.Name = "PanelR"
        Me.PanelR.Size = New System.Drawing.Size(287, 199)
        Me.PanelR.TabIndex = 1
        '
        'PanelL
        '
        Me.PanelL.Controls.Add(Me.GroupBox2)
        Me.PanelL.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelL.Location = New System.Drawing.Point(0, 0)
        Me.PanelL.Name = "PanelL"
        Me.PanelL.Size = New System.Drawing.Size(303, 199)
        Me.PanelL.TabIndex = 0
        '
        'Frm_ClasseEphmra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(734, 630)
        Me.Name = "Frm_ClasseEphmra"
        Me.Text = "Classe Ephmra"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanMain.PerformLayout()
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupLibellePere.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodePere.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibelleGB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.GCFils, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVFils, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtlibelleFr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSyno.ResumeLayout(False)
        Me.PanelR.ResumeLayout(False)
        Me.PanelL.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lkupLibellePere As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodePere As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtLibelleGB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GC2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GCFils As DevExpress.XtraGrid.GridControl
    Friend WithEvents DsTheriaque2 As Theriaque.dsTheriaque2
    Friend WithEvents txtlibelleFr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GVFils As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CepH_CLASSEEPHMRATableAdapter As Theriaque.dsTheriaque2TableAdapters.CEPH_CLASSEEPHMRATableAdapter
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSYAEPH_NOM_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSYAEPH_CEPH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSYFEPH_NOM_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSYFEPH_CEPH_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SyaepH_SYNONYMEANGLAIS_EPHMRATableAdapter As Theriaque.dsTheriaque2TableAdapters.SYAEPH_SYNONYMEANGLAIS_EPHMRATableAdapter
    Friend WithEvents SyfepH_SYNONYMEFR_EPHMRATableAdapter As Theriaque.dsTheriaque2TableAdapters.SYFEPH_SYNONYMEFR_EPHMRATableAdapter
    Friend WithEvents CepH_CLASSEEPHMRATableAdapter1 As Theriaque.dsTheriaque2TableAdapters.CEPH_CLASSEEPHMRATableAdapter
    Friend WithEvents colCEPH_CODE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCEPH_NOMF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCEPH_NOMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CepH_CLASSEEPHMRATableAdapterFils As Theriaque.dsTheriaque2TableAdapters.CEPH_CLASSEEPHMRATableAdapter
    Friend WithEvents PanelSyno As System.Windows.Forms.Panel
    Friend WithEvents PanelR As System.Windows.Forms.Panel
    Friend WithEvents PanelL As System.Windows.Forms.Panel
    Friend WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

End Class
