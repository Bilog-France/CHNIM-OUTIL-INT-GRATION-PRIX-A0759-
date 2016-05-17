<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Import_Selection
    Inherits System.Windows.Forms.Form

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
        Dim RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl
        Me.btNone = New DevExpress.XtraEditors.SimpleButton
        Me.btTout = New DevExpress.XtraEditors.SimpleButton
        Me.gcSpecPres = New DevExpress.XtraGrid.GridControl
        Me.gvSpecPres = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColCheckbox = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.ColCodeSP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColLibelle = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.lblNbImport = New DevExpress.XtraEditors.LabelControl
        Me.lblDoc = New DevExpress.XtraEditors.LabelControl
        Me.pgBarDocument = New DevExpress.XtraEditors.ProgressBarControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.meNote = New DevExpress.XtraEditors.MemoEdit
        Me.lueCategorie = New DevExpress.XtraEditors.LookUpEdit
        Me.txtLibelle = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.lstDetails = New DevExpress.XtraEditors.ListBoxControl
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar
        Me.btChercher = New DevExpress.XtraBars.BarButtonItem
        Me.btImporter = New DevExpress.XtraBars.BarButtonItem
        Me.btFermer = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.lblChemin = New DevExpress.XtraEditors.LabelControl
        Me.beChemin = New DevExpress.XtraEditors.ButtonEdit
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        CType(RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.gcSpecPres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSpecPres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.pgBarDocument.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.meNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCategorie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beChemin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'RepositoryItemCheckEdit1
        '
        RepositoryItemCheckEdit1.AutoHeight = False
        RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.PanelControl5)
        Me.PanelControl2.Controls.Add(Me.PanelControl1)
        Me.PanelControl2.Controls.Add(Me.GroupControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 55)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(632, 372)
        Me.PanelControl2.TabIndex = 1
        Me.PanelControl2.Text = "PanelControl2"
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.btNone)
        Me.PanelControl5.Controls.Add(Me.btTout)
        Me.PanelControl5.Controls.Add(Me.gcSpecPres)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl5.Location = New System.Drawing.Point(2, 88)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(628, 258)
        Me.PanelControl5.TabIndex = 4
        Me.PanelControl5.Text = "PanelControl5"
        '
        'btNone
        '
        Me.btNone.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btNone.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNone.Appearance.Options.UseBackColor = True
        Me.btNone.Appearance.Options.UseFont = True
        Me.btNone.Location = New System.Drawing.Point(62, 172)
        Me.btNone.Name = "btNone"
        Me.btNone.Size = New System.Drawing.Size(56, 18)
        Me.btNone.TabIndex = 5
        Me.btNone.Text = "Au&cun"
        '
        'btTout
        '
        Me.btTout.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btTout.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btTout.Appearance.Options.UseBackColor = True
        Me.btTout.Appearance.Options.UseBorderColor = True
        Me.btTout.Appearance.Options.UseFont = True
        Me.btTout.Appearance.Options.UseForeColor = True
        Me.btTout.Appearance.Options.UseImage = True
        Me.btTout.Appearance.Options.UseTextOptions = True
        Me.btTout.Location = New System.Drawing.Point(2, 172)
        Me.btTout.Name = "btTout"
        Me.btTout.Size = New System.Drawing.Size(56, 18)
        Me.btTout.TabIndex = 4
        Me.btTout.Text = "&Tout"
        '
        'gcSpecPres
        '
        Me.gcSpecPres.EmbeddedNavigator.Name = ""
        Me.gcSpecPres.Location = New System.Drawing.Point(-1, -1)
        Me.gcSpecPres.MainView = Me.gvSpecPres
        Me.gcSpecPres.Name = "gcSpecPres"
        Me.gcSpecPres.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.gcSpecPres.Size = New System.Drawing.Size(624, 170)
        Me.gcSpecPres.TabIndex = 0
        Me.gcSpecPres.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSpecPres})
        '
        'gvSpecPres
        '
        Me.gvSpecPres.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColCheckbox, Me.ColCodeSP, Me.ColLibelle, Me.colType})
        Me.gvSpecPres.GridControl = Me.gcSpecPres
        Me.gvSpecPres.Name = "gvSpecPres"
        Me.gvSpecPres.OptionsSelection.MultiSelect = True
        '
        'ColCheckbox
        '
        Me.ColCheckbox.Caption = "Check"
        Me.ColCheckbox.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.ColCheckbox.FieldName = "Check"
        Me.ColCheckbox.Name = "ColCheckbox"
        Me.ColCheckbox.Visible = True
        Me.ColCheckbox.VisibleIndex = 0
        Me.ColCheckbox.Width = 40
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Caption = ""
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit2.ValueChecked = 1
        Me.RepositoryItemCheckEdit2.ValueGrayed = False
        Me.RepositoryItemCheckEdit2.ValueUnchecked = 0
        '
        'ColCodeSP
        '
        Me.ColCodeSP.Caption = "Code"
        Me.ColCodeSP.FieldName = "CodeSP"
        Me.ColCodeSP.Name = "ColCodeSP"
        Me.ColCodeSP.Visible = True
        Me.ColCodeSP.VisibleIndex = 1
        '
        'ColLibelle
        '
        Me.ColLibelle.Caption = "Libellé"
        Me.ColLibelle.FieldName = "Libelle"
        Me.ColLibelle.Name = "ColLibelle"
        Me.ColLibelle.Visible = True
        Me.ColLibelle.VisibleIndex = 2
        Me.ColLibelle.Width = 401
        '
        'colType
        '
        Me.colType.Caption = "Type"
        Me.colType.FieldName = "Type"
        Me.colType.Name = "colType"
        Me.colType.Visible = True
        Me.colType.VisibleIndex = 3
        Me.colType.Width = 70
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lblNbImport)
        Me.PanelControl1.Controls.Add(Me.lblDoc)
        Me.PanelControl1.Controls.Add(Me.pgBarDocument)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(2, 346)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(628, 24)
        Me.PanelControl1.TabIndex = 1
        Me.PanelControl1.Text = "PanelControl1"
        '
        'lblNbImport
        '
        Me.lblNbImport.Location = New System.Drawing.Point(319, 5)
        Me.lblNbImport.Name = "lblNbImport"
        Me.lblNbImport.Size = New System.Drawing.Size(0, 13)
        Me.lblNbImport.TabIndex = 3
        '
        'lblDoc
        '
        Me.lblDoc.Location = New System.Drawing.Point(218, 5)
        Me.lblDoc.Name = "lblDoc"
        Me.lblDoc.Size = New System.Drawing.Size(95, 13)
        Me.lblDoc.TabIndex = 2
        Me.lblDoc.Text = "Total doc importés :"
        '
        'pgBarDocument
        '
        Me.pgBarDocument.Location = New System.Drawing.Point(5, 3)
        Me.pgBarDocument.Name = "pgBarDocument"
        Me.pgBarDocument.Size = New System.Drawing.Size(207, 18)
        Me.pgBarDocument.TabIndex = 1
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.meNote)
        Me.GroupControl1.Controls.Add(Me.lueCategorie)
        Me.GroupControl1.Controls.Add(Me.txtLibelle)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(628, 86)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.Text = "Propriété"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(5, 52)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Note"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(307, 27)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Catégorie"
        '
        'meNote
        '
        Me.meNote.Location = New System.Drawing.Point(49, 49)
        Me.meNote.Name = "meNote"
        Me.meNote.Size = New System.Drawing.Size(574, 30)
        Me.meNote.TabIndex = 3
        '
        'lueCategorie
        '
        Me.lueCategorie.EditValue = ""
        Me.lueCategorie.Location = New System.Drawing.Point(383, 23)
        Me.lueCategorie.Name = "lueCategorie"
        Me.lueCategorie.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCategorie.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Libelle", "Name1", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_CATEGORIE", "Name2", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.lueCategorie.Properties.DisplayMember = "Libelle"
        Me.lueCategorie.Properties.NullText = ""
        Me.lueCategorie.Properties.ShowHeader = False
        Me.lueCategorie.Properties.ValueMember = "ID_CATEGORIE"
        Me.lueCategorie.Size = New System.Drawing.Size(240, 20)
        Me.lueCategorie.TabIndex = 2
        '
        'txtLibelle
        '
        Me.txtLibelle.Location = New System.Drawing.Point(49, 23)
        Me.txtLibelle.Name = "txtLibelle"
        Me.txtLibelle.Size = New System.Drawing.Size(246, 20)
        Me.txtLibelle.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(5, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Libellé"
        '
        'lstDetails
        '
        Me.lstDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstDetails.Location = New System.Drawing.Point(2, 2)
        Me.lstDetails.Name = "lstDetails"
        Me.lstDetails.Size = New System.Drawing.Size(628, 88)
        Me.lstDetails.TabIndex = 0
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btChercher, Me.BarButtonItem2, Me.btFermer, Me.btImporter})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 4
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.FloatLocation = New System.Drawing.Point(390, 239)
        Me.Bar2.FloatSize = New System.Drawing.Size(203, 24)
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btChercher), New DevExpress.XtraBars.LinkPersistInfo(Me.btImporter), New DevExpress.XtraBars.LinkPersistInfo(Me.btFermer)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Custom 3"
        '
        'btChercher
        '
        Me.btChercher.Caption = "&Chercher"
        Me.btChercher.Id = 0
        Me.btChercher.Name = "btChercher"
        '
        'btImporter
        '
        Me.btImporter.Caption = "&Importer"
        Me.btImporter.Id = 3
        Me.btImporter.Name = "btImporter"
        '
        'btFermer
        '
        Me.btFermer.Caption = "&Fermer"
        Me.btFermer.Id = 2
        Me.btFermer.Name = "btFermer"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "&Importer"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'lblChemin
        '
        Me.lblChemin.Location = New System.Drawing.Point(11, 10)
        Me.lblChemin.Name = "lblChemin"
        Me.lblChemin.Size = New System.Drawing.Size(35, 13)
        Me.lblChemin.TabIndex = 5
        Me.lblChemin.Text = "Chemin"
        '
        'beChemin
        '
        Me.beChemin.Location = New System.Drawing.Point(52, 6)
        Me.beChemin.Name = "beChemin"
        Me.beChemin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton("explorer", DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis), New DevExpress.XtraEditors.Controls.EditorButton("effacer", DevExpress.XtraEditors.Controls.ButtonPredefines.Minus)})
        Me.beChemin.Size = New System.Drawing.Size(330, 20)
        Me.beChemin.TabIndex = 4
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.beChemin)
        Me.PanelControl4.Controls.Add(Me.lblChemin)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl4.Location = New System.Drawing.Point(0, 24)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(632, 31)
        Me.PanelControl4.TabIndex = 6
        Me.PanelControl4.Text = "PanelControl4"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.lstDetails)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl3.Location = New System.Drawing.Point(0, 335)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(632, 92)
        Me.PanelControl3.TabIndex = 2
        Me.PanelControl3.Text = "PanelControl3"
        '
        'Frm_Import_Selection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 427)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "Frm_Import_Selection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import par Sélection"
        CType(RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.gcSpecPres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSpecPres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.pgBarDocument.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.meNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCategorie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beChemin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents gcSpecPres As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvSpecPres As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btChercher As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btImporter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btFermer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblDoc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pgBarDocument As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents lstDetails As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents ColCheckbox As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCodeSP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLibelle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblChemin As DevExpress.XtraEditors.LabelControl
    Friend WithEvents beChemin As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents lblNbImport As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents meNote As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lueCategorie As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtLibelle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Protected Friend WithEvents btNone As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btTout As DevExpress.XtraEditors.SimpleButton
End Class
