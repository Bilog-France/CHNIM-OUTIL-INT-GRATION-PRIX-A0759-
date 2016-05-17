<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Doc_SP
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
        Me.gcSpecPres = New DevExpress.XtraGrid.GridControl
        Me.gvSpecPres = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLibelle = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colType = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.gcSpecPres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSpecPres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.gcSpecPres)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(564, 320)
        Me.PanelControl1.TabIndex = 0
        Me.PanelControl1.Text = "PanelControl1"
        '
        'gcSpecPres
        '
        Me.gcSpecPres.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcSpecPres.EmbeddedNavigator.Name = ""
        Me.gcSpecPres.Location = New System.Drawing.Point(2, 2)
        Me.gcSpecPres.MainView = Me.gvSpecPres
        Me.gcSpecPres.Name = "gcSpecPres"
        Me.gcSpecPres.Size = New System.Drawing.Size(560, 316)
        Me.gcSpecPres.TabIndex = 0
        Me.gcSpecPres.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSpecPres})
        '
        'gvSpecPres
        '
        Me.gvSpecPres.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCode, Me.colLibelle, Me.colType})
        Me.gvSpecPres.GridControl = Me.gcSpecPres
        Me.gvSpecPres.Name = "gvSpecPres"
        Me.gvSpecPres.OptionsView.ShowGroupPanel = False
        '
        'colCode
        '
        Me.colCode.Caption = "Code"
        Me.colCode.FieldName = "code"
        Me.colCode.Name = "colCode"
        Me.colCode.OptionsColumn.AllowEdit = False
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 0
        '
        'colLibelle
        '
        Me.colLibelle.Caption = "Libellé"
        Me.colLibelle.FieldName = "Nom"
        Me.colLibelle.Name = "colLibelle"
        Me.colLibelle.OptionsColumn.AllowEdit = False
        Me.colLibelle.Visible = True
        Me.colLibelle.VisibleIndex = 1
        '
        'colType
        '
        Me.colType.Caption = "Type"
        Me.colType.FieldName = "Type"
        Me.colType.Name = "colType"
        Me.colType.OptionsColumn.AllowEdit = False
        Me.colType.Visible = True
        Me.colType.VisibleIndex = 2
        '
        'Frm_Doc_SP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 320)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "Frm_Doc_SP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spécialités et Présentations liées au document"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.gcSpecPres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSpecPres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gcSpecPres As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvSpecPres As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLibelle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
End Class
