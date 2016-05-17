<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Substance_Virtuelle
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
        Me.DsTheriaqueVirtuelPere = New Theriaque.dsTheriaque_Virtuel_Pere
        Me.SAV_SUBSTANCE_VIRTUELLE = New Theriaque.dsTheriaque_Virtuel_PereTableAdapters.SAV_SUBSTANCE_VIRTUELLETableAdapter
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SAV_CODE_SQ_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SAV_LIBELLE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lstsav = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colinvisible = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SAV_SUBSTANCE_VIRTUELLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.EditLibelle = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.EditCodeRef = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.EditCode = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.SAVSAC_SUBVIRT_SUBACTableAdapter = New Theriaque.dsTheriaque_Virtuel_PereTableAdapters.SAVSAC_SUBVIRT_SUBACTableAdapter
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GC2 = New DevExpress.XtraGrid.GridControl
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSYSAV_LIBELLE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSYSAV_SAV_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.SYSAV = New Theriaque.dsTheriaque_Virtuel_PereTableAdapters.SYSAV_SYNONYME_SUBST_VIRTTableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaqueVirtuelPere, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstsav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAV_SUBSTANCE_VIRTUELLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.EditLibelle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.EditCodeRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(543, 392)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.XtraTabControl2)
        Me.PanMain.Controls.Add(Me.XtraTabControl1)
        Me.PanMain.Controls.Add(Me.GroupBox1)
        Me.PanMain.Location = New System.Drawing.Point(0, 36)
        Me.PanMain.Size = New System.Drawing.Size(425, 356)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(543, 36)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(543, 28)
        Me.Label1.Text = "Substance virtuelle"
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
        Me.Panel1.Location = New System.Drawing.Point(425, 36)
        Me.Panel1.Size = New System.Drawing.Size(118, 356)
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(502, 45)
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit1.Size = New System.Drawing.Size(10, 20)
        '
        'GroupBox
        '
        Me.GroupBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox.Location = New System.Drawing.Point(0, 28)
        Me.GroupBox.Size = New System.Drawing.Size(543, 36)
        Me.GroupBox.Visible = False
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit2.Size = New System.Drawing.Size(10, 20)
        Me.DateEdit2.Visible = False
        '
        'DsTheriaqueVirtuelPere
        '
        Me.DsTheriaqueVirtuelPere.DataSetName = "dsTheriaqueURL"
        Me.DsTheriaqueVirtuelPere.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SAV_SUBSTANCE_VIRTUELLE
        '
        Me.SAV_SUBSTANCE_VIRTUELLE.ClearBeforeFill = True
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(1, 230)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(425, 133)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.Tomato
        Me.XtraTabPage1.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(416, 102)
        Me.XtraTabPage1.Tag = "[EDIT][ADD]"
        Me.XtraTabPage1.Text = "Substance fille"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "SAVSAC_SUBVIRT_SUBAC"
        Me.GridControl1.DataSource = Me.DsTheriaqueVirtuelPere
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lstsav})
        Me.GridControl1.Size = New System.Drawing.Size(416, 102)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.SAV_CODE_SQ_PK, Me.SAV_LIBELLE, Me.colinvisible})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'SAV_CODE_SQ_PK
        '
        Me.SAV_CODE_SQ_PK.Caption = "Code"
        Me.SAV_CODE_SQ_PK.FieldName = "SAVSAC_SAC_CODE_FK_PK"
        Me.SAV_CODE_SQ_PK.Name = "SAV_CODE_SQ_PK"
        Me.SAV_CODE_SQ_PK.Visible = True
        Me.SAV_CODE_SQ_PK.VisibleIndex = 0
        '
        'SAV_LIBELLE
        '
        Me.SAV_LIBELLE.Caption = "Libellé"
        Me.SAV_LIBELLE.ColumnEdit = Me.lstsav
        Me.SAV_LIBELLE.FieldName = "SAVSAC_SAC_CODE_FK_PK"
        Me.SAV_LIBELLE.Name = "SAV_LIBELLE"
        Me.SAV_LIBELLE.Visible = True
        Me.SAV_LIBELLE.VisibleIndex = 1
        '
        'lstsav
        '
        Me.lstsav.AutoHeight = False
        Me.lstsav.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstsav.Name = "lstsav"
        '
        'colinvisible
        '
        Me.colinvisible.Caption = "GridColumn1"
        Me.colinvisible.FieldName = "SAVSAC_SAV_CODE_FK_PK"
        Me.colinvisible.Name = "colinvisible"
        '
        'SAV_SUBSTANCE_VIRTUELLEBindingSource
        '
        Me.SAV_SUBSTANCE_VIRTUELLEBindingSource.DataMember = "SAV_SUBSTANCE_VIRTUELLE"
        Me.SAV_SUBSTANCE_VIRTUELLEBindingSource.DataSource = Me.DsTheriaqueVirtuelPere
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 97)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.EditLibelle)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 55)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(419, 39)
        Me.Panel3.TabIndex = 1
        '
        'EditLibelle
        '
        Me.EditLibelle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditLibelle.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaqueVirtuelPere, "SAV_SUBSTANCE_VIRTUELLE.SAV_LIBELLE", True))
        Me.EditLibelle.Location = New System.Drawing.Point(67, 12)
        Me.EditLibelle.Name = "EditLibelle"
        Me.EditLibelle.Size = New System.Drawing.Size(330, 20)
        Me.EditLibelle.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Libellé"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.EditCodeRef)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.EditCode)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(419, 39)
        Me.Panel2.TabIndex = 0
        '
        'EditCodeRef
        '
        Me.EditCodeRef.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditCodeRef.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaqueVirtuelPere, "SAV_SUBSTANCE_VIRTUELLE.SAV_CODE_REF", True))
        Me.EditCodeRef.Location = New System.Drawing.Point(280, 9)
        Me.EditCodeRef.Name = "EditCodeRef"
        Me.EditCodeRef.Size = New System.Drawing.Size(117, 20)
        Me.EditCodeRef.TabIndex = 10
        Me.EditCodeRef.Tag = "[ADD][EDIT]"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(193, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Code réferentiel"
        '
        'EditCode
        '
        Me.EditCode.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.EditCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaqueVirtuelPere, "SAV_SUBSTANCE_VIRTUELLE.SAV_CODE_SQ_PK", True))
        Me.EditCode.Location = New System.Drawing.Point(67, 9)
        Me.EditCode.MinimumSize = New System.Drawing.Size(50, 7)
        Me.EditCode.Name = "EditCode"
        Me.EditCode.Size = New System.Drawing.Size(113, 20)
        Me.EditCode.TabIndex = 8
        Me.EditCode.Tag = "[ADD][EDIT]"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Code"
        '
        'SAVSAC_SUBVIRT_SUBACTableAdapter
        '
        Me.SAVSAC_SUBVIRT_SUBACTableAdapter.ClearBeforeFill = True
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Location = New System.Drawing.Point(0, 98)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage2
        Me.XtraTabControl2.Size = New System.Drawing.Size(425, 131)
        Me.XtraTabControl2.TabIndex = 14
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2})
        Me.XtraTabControl2.Text = "XtraTabControl2"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Appearance.PageClient.BackColor = System.Drawing.Color.Tomato
        Me.XtraTabPage2.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage2.Controls.Add(Me.GC2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(416, 100)
        Me.XtraTabPage2.Tag = "[EDIT][ADD]"
        Me.XtraTabPage2.Text = "Synonymes"
        '
        'GC2
        '
        Me.GC2.DataSource = Me.DsTheriaqueVirtuelPere
        Me.GC2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC2.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC2.EmbeddedNavigator.Name = ""
        Me.GC2.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC2.Location = New System.Drawing.Point(0, 0)
        Me.GC2.MainView = Me.GV2
        Me.GC2.Name = "GC2"
        Me.GC2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.GC2.Size = New System.Drawing.Size(416, 100)
        Me.GC2.TabIndex = 0
        Me.GC2.UseEmbeddedNavigator = True
        Me.GC2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSYSAV_LIBELLE, Me.colSYSAV_SAV_CODE_FK_PK})
        Me.GV2.GridControl = Me.GC2
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsView.ShowGroupPanel = False
        '
        'colSYSAV_LIBELLE
        '
        Me.colSYSAV_LIBELLE.Caption = "Libellé"
        Me.colSYSAV_LIBELLE.FieldName = "SYSAV_LIBELLE"
        Me.colSYSAV_LIBELLE.Name = "colSYSAV_LIBELLE"
        Me.colSYSAV_LIBELLE.Visible = True
        Me.colSYSAV_LIBELLE.VisibleIndex = 0
        '
        'colSYSAV_SAV_CODE_FK_PK
        '
        Me.colSYSAV_SAV_CODE_FK_PK.Caption = "SYFOV_FOV_CODE_FK_PK"
        Me.colSYSAV_SAV_CODE_FK_PK.FieldName = "SYSAV_SAV_CODE_FK_PK"
        Me.colSYSAV_SAV_CODE_FK_PK.Name = "colSYSAV_SAV_CODE_FK_PK"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'SYSAV
        '
        Me.SYSAV.ClearBeforeFill = True
        '
        'Frm_Substance_Virtuelle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(543, 392)
        Me.Name = "Frm_Substance_Virtuelle"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Substance virtuelle"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaqueVirtuelPere, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstsav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAV_SUBSTANCE_VIRTUELLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.EditLibelle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.EditCodeRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents DsTheriaqueVirtuelPere As Theriaque.dsTheriaque_Virtuel_Pere
    Friend WithEvents SAV_SUBSTANCE_VIRTUELLE As Theriaque.dsTheriaque_Virtuel_PereTableAdapters.SAV_SUBSTANCE_VIRTUELLETableAdapter
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EditCodeRef As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EditCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EditLibelle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents SAV_SUBSTANCE_VIRTUELLEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SAV_CODE_SQ_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SAV_LIBELLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colinvisible As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lstsav As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SAVSAC_SUBVIRT_SUBACTableAdapter As Theriaque.dsTheriaque_Virtuel_PereTableAdapters.SAVSAC_SUBVIRT_SUBACTableAdapter
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GC2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSYSAV_LIBELLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colSYSAV_SAV_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SYSAV As Theriaque.dsTheriaque_Virtuel_PereTableAdapters.SYSAV_SYNONYME_SUBST_VIRTTableAdapter

End Class
