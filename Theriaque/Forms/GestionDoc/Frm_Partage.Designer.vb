<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Partage
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.gcPartage = New DevExpress.XtraGrid.GridControl
        Me.gvPartage = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.btnFermer = New DevExpress.XtraEditors.SimpleButton
        Me.btnPartage = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.gcPartage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPartage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.gcPartage)
        Me.PanelControl1.Location = New System.Drawing.Point(2, 3)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(501, 332)
        Me.PanelControl1.TabIndex = 0
        Me.PanelControl1.Text = "PanelControl1"
        '
        'gcPartage
        '
        Me.gcPartage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPartage.EmbeddedNavigator.Name = ""
        Me.gcPartage.Location = New System.Drawing.Point(2, 2)
        Me.gcPartage.MainView = Me.gvPartage
        Me.gcPartage.Name = "gcPartage"
        Me.gcPartage.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.gcPartage.Size = New System.Drawing.Size(497, 328)
        Me.gcPartage.TabIndex = 0
        Me.gcPartage.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPartage, Me.GridView2})
        '
        'gvPartage
        '
        Me.gvPartage.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCheck, Me.GridColumn2, Me.GridColumn3})
        Me.gvPartage.GridControl = Me.gcPartage
        Me.gvPartage.Name = "gvPartage"
        '
        'colCheck
        '
        Me.colCheck.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colCheck.FieldName = "Check"
        Me.colCheck.Name = "colCheck"
        Me.colCheck.Visible = True
        Me.colCheck.VisibleIndex = 0
        Me.colCheck.Width = 30
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Code"
        Me.GridColumn2.FieldName = "Code"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 60
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Libellé"
        Me.GridColumn3.FieldName = "Libelle"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 386
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.gcPartage
        Me.GridView2.Name = "GridView2"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnFermer)
        Me.PanelControl2.Controls.Add(Me.btnPartage)
        Me.PanelControl2.Location = New System.Drawing.Point(502, 3)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(98, 332)
        Me.PanelControl2.TabIndex = 1
        Me.PanelControl2.Text = "PanelControl2"
        '
        'btnFermer
        '
        Me.btnFermer.Location = New System.Drawing.Point(13, 56)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(75, 23)
        Me.btnFermer.TabIndex = 1
        Me.btnFermer.Text = "Fermer"
        '
        'btnPartage
        '
        Me.btnPartage.Location = New System.Drawing.Point(13, 18)
        Me.btnPartage.Name = "btnPartage"
        Me.btnPartage.Size = New System.Drawing.Size(75, 23)
        Me.btnPartage.TabIndex = 0
        Me.btnPartage.Text = "Partage"
        '
        'Frm_Partage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 336)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "Frm_Partage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Partage de documents"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.gcPartage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPartage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnFermer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPartage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcPartage As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPartage As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
End Class
