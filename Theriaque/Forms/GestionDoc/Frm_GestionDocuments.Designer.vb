<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_GestionDocuments
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.Bar2 = New DevExpress.XtraBars.Bar
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.Bar4 = New DevExpress.XtraBars.Bar
        Me.Bar5 = New DevExpress.XtraBars.Bar
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.meNote = New DevExpress.XtraEditors.MemoEdit
        Me.lueCategorie = New DevExpress.XtraEditors.LookUpEdit
        Me.txtLibelle = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.SplitterControl2 = New DevExpress.XtraEditors.SplitterControl
        Me.gcDocuments = New DevExpress.XtraGrid.GridControl
        Me.gvDocuments = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColIcone = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColLibelle = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTaille = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUser = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanApercu = New DevExpress.XtraEditors.PanelControl
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.meNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCategorie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcDocuments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDocuments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanApercu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.FloatLocation = New System.Drawing.Point(390, 239)
        Me.Bar2.FloatSize = New System.Drawing.Size(203, 24)
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Custom 3"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.MaxItemId = 1
        '
        'Bar4
        '
        Me.Bar4.BarName = "Custom 4"
        Me.Bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar4.DockCol = 0
        Me.Bar4.DockRow = 0
        Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar4.OptionsBar.AllowQuickCustomization = False
        Me.Bar4.OptionsBar.DrawDragBorder = False
        Me.Bar4.OptionsBar.UseWholeRow = True
        Me.Bar4.Text = "Custom 4"
        '
        'Bar5
        '
        Me.Bar5.BarName = "Custom 5"
        Me.Bar5.DockCol = 0
        Me.Bar5.DockRow = 0
        Me.Bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar5.Text = "Custom 5"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Panel1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(304, 614)
        Me.PanelControl1.TabIndex = 4
        Me.PanelControl1.Text = "PanelControl1"
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoScrollMinSize = New System.Drawing.Size(263, 0)
        Me.Panel1.Controls.Add(Me.GroupControl1)
        Me.Panel1.Controls.Add(Me.SplitterControl2)
        Me.Panel1.Controls.Add(Me.gcDocuments)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 610)
        Me.Panel1.TabIndex = 1
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.meNote)
        Me.GroupControl1.Controls.Add(Me.lueCategorie)
        Me.GroupControl1.Controls.Add(Me.txtLibelle)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 464)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(300, 146)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Propriété"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(5, 78)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Note"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(5, 53)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Catégorie"
        '
        'meNote
        '
        Me.meNote.Location = New System.Drawing.Point(49, 75)
        Me.meNote.Name = "meNote"
        Me.meNote.Size = New System.Drawing.Size(246, 61)
        Me.meNote.TabIndex = 3
        '
        'lueCategorie
        '
        Me.lueCategorie.EditValue = ""
        Me.lueCategorie.Location = New System.Drawing.Point(81, 49)
        Me.lueCategorie.Name = "lueCategorie"
        Me.lueCategorie.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCategorie.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Libelle", "Name1", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_CATEGORIE", "Name2", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.lueCategorie.Properties.DisplayMember = "Libelle"
        Me.lueCategorie.Properties.NullText = ""
        Me.lueCategorie.Properties.ShowHeader = False
        Me.lueCategorie.Properties.ValueMember = "ID_CATEGORIE"
        Me.lueCategorie.Size = New System.Drawing.Size(214, 20)
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
        'SplitterControl2
        '
        Me.SplitterControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitterControl2.Location = New System.Drawing.Point(0, 458)
        Me.SplitterControl2.Name = "SplitterControl2"
        Me.SplitterControl2.Size = New System.Drawing.Size(300, 6)
        Me.SplitterControl2.TabIndex = 1
        Me.SplitterControl2.TabStop = False
        '
        'gcDocuments
        '
        Me.gcDocuments.Dock = System.Windows.Forms.DockStyle.Top
        Me.gcDocuments.EmbeddedNavigator.Name = ""
        GridLevelNode1.RelationName = "Level1"
        Me.gcDocuments.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gcDocuments.Location = New System.Drawing.Point(0, 0)
        Me.gcDocuments.MainView = Me.gvDocuments
        Me.gcDocuments.Name = "gcDocuments"
        Me.gcDocuments.Size = New System.Drawing.Size(300, 458)
        Me.gcDocuments.TabIndex = 0
        Me.gcDocuments.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDocuments})
        '
        'gvDocuments
        '
        Me.gvDocuments.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIcone, Me.ColLibelle, Me.colTaille, Me.colDate, Me.colUser, Me.GridColumn1})
        Me.gvDocuments.GridControl = Me.gcDocuments
        Me.gvDocuments.Name = "gvDocuments"
        Me.gvDocuments.OptionsView.ShowAutoFilterRow = True
        Me.gvDocuments.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvDocuments.OptionsView.ShowGroupPanel = False
        '
        'ColIcone
        '
        Me.ColIcone.Name = "ColIcone"
        Me.ColIcone.OptionsColumn.AllowEdit = False
        Me.ColIcone.Width = 28
        '
        'ColLibelle
        '
        Me.ColLibelle.Caption = "Libellé"
        Me.ColLibelle.FieldName = "DO_Label"
        Me.ColLibelle.Name = "ColLibelle"
        Me.ColLibelle.OptionsColumn.AllowEdit = False
        Me.ColLibelle.Visible = True
        Me.ColLibelle.VisibleIndex = 0
        Me.ColLibelle.Width = 199
        '
        'colTaille
        '
        Me.colTaille.Caption = "Taille"
        Me.colTaille.FieldName = "DO_Taille"
        Me.colTaille.Name = "colTaille"
        Me.colTaille.OptionsColumn.AllowEdit = False
        Me.colTaille.Width = 82
        '
        'colDate
        '
        Me.colDate.Caption = "Date"
        Me.colDate.FieldName = "DO_Date"
        Me.colDate.Name = "colDate"
        Me.colDate.OptionsColumn.AllowEdit = False
        Me.colDate.Visible = True
        Me.colDate.VisibleIndex = 1
        Me.colDate.Width = 82
        '
        'colUser
        '
        Me.colUser.Caption = "Utilisateur"
        Me.colUser.FieldName = "UT_ID"
        Me.colUser.Name = "colUser"
        Me.colUser.OptionsColumn.AllowEdit = False
        Me.colUser.Width = 93
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Catégorie"
        Me.GridColumn1.FieldName = "ID_Categorie"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'PanApercu
        '
        Me.PanApercu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanApercu.Location = New System.Drawing.Point(304, 0)
        Me.PanApercu.Name = "PanApercu"
        Me.PanApercu.Size = New System.Drawing.Size(722, 614)
        Me.PanApercu.TabIndex = 5
        Me.PanApercu.Text = "PanelControl2"
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Location = New System.Drawing.Point(304, 0)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(6, 614)
        Me.SplitterControl1.TabIndex = 6
        Me.SplitterControl1.TabStop = False
        '
        'Frm_GestionDocuments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 614)
        Me.Controls.Add(Me.SplitterControl1)
        Me.Controls.Add(Me.PanApercu)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "Frm_GestionDocuments"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion des documents"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.meNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCategorie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcDocuments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDocuments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanApercu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar5 As DevExpress.XtraBars.Bar
    Friend WithEvents PanApercu As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gcDocuments As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDocuments As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIcone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLibelle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTaille As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SplitterControl2 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents meNote As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lueCategorie As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtLibelle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
