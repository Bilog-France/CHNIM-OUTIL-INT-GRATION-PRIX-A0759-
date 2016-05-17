<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Attrb_Auto_Anlys_Ordo_Incomp
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
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.CardView1 = New DevExpress.XtraGrid.Views.Card.CardView
        Me.Col2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpBTEDIT = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.ProgressBar = New System.Windows.Forms.ProgressBar
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLibelle2 = New DevExpress.XtraEditors.TextEdit
        Me.txtCode2 = New DevExpress.XtraEditors.TextEdit
        Me.txtLibelle = New DevExpress.XtraEditors.TextEdit
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpBTEDIT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.txtLibelle2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(707, 531)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.GC)
        Me.PanMain.Controls.Add(Me.Panel2)
        Me.PanMain.Size = New System.Drawing.Size(589, 444)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(707, 87)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(707, 28)
        Me.Label1.Text = "Attribution automatique"
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
        Me.Panel1.Location = New System.Drawing.Point(589, 87)
        Me.Panel1.Size = New System.Drawing.Size(118, 444)
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Size = New System.Drawing.Size(707, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.EndEdit.Visible = False
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
        Me.GC.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GC.EmbeddedNavigator.Name = ""
        Me.GC.EmbeddedNavigator.TextStringFormat = " {0} / {1}"
        Me.GC.Location = New System.Drawing.Point(0, 97)
        Me.GC.MainView = Me.CardView1
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpBTEDIT})
        Me.GC.Size = New System.Drawing.Size(589, 347)
        Me.GC.TabIndex = 24
        Me.GC.UseEmbeddedNavigator = True
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.CardView1})
        '
        'CardView1
        '
        Me.CardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Col2})
        Me.CardView1.FocusedCardTopFieldIndex = 0
        Me.CardView1.GridControl = Me.GC
        Me.CardView1.Name = "CardView1"
        Me.CardView1.OptionsView.ShowCardCaption = False
        Me.CardView1.OptionsView.ShowCardExpandButton = False
        Me.CardView1.OptionsView.ShowEmptyFields = False
        Me.CardView1.OptionsView.ShowFieldCaptions = False
        Me.CardView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.CardView1.OptionsView.ShowLines = False
        Me.CardView1.OptionsView.ShowQuickCustomizeButton = False
        Me.CardView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.Col2, DevExpress.Data.ColumnSortOrder.Descending)})
        Me.CardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
        '
        'Col2
        '
        Me.Col2.Caption = "code"
        Me.Col2.ColumnEdit = Me.rpBTEDIT
        Me.Col2.FieldName = "code"
        Me.Col2.Name = "Col2"
        Me.Col2.Visible = True
        Me.Col2.VisibleIndex = 0
        '
        'rpBTEDIT
        '
        Me.rpBTEDIT.AutoHeight = False
        Me.rpBTEDIT.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.rpBTEDIT.Name = "rpBTEDIT"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ProgressBar)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtLibelle2)
        Me.Panel2.Controls.Add(Me.txtCode2)
        Me.Panel2.Controls.Add(Me.txtLibelle)
        Me.Panel2.Controls.Add(Me.txtCode)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel2.Size = New System.Drawing.Size(589, 97)
        Me.Panel2.TabIndex = 23
        '
        'ProgressBar
        '
        Me.ProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar.Location = New System.Drawing.Point(2, 83)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(585, 12)
        Me.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar.TabIndex = 18
        Me.ProgressBar.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Entité similaire"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Entité princeps"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLibelle2
        '
        Me.txtLibelle2.Location = New System.Drawing.Point(90, 44)
        Me.txtLibelle2.Name = "txtLibelle2"
        Me.txtLibelle2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLibelle2.Size = New System.Drawing.Size(382, 20)
        Me.txtLibelle2.TabIndex = 14
        Me.txtLibelle2.Tag = "[NOEDIT][NOADD]"
        '
        'txtCode2
        '
        Me.txtCode2.Location = New System.Drawing.Point(483, 44)
        Me.txtCode2.Name = "txtCode2"
        Me.txtCode2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode2.Size = New System.Drawing.Size(69, 20)
        Me.txtCode2.TabIndex = 14
        Me.txtCode2.Tag = "[NOEDIT][NOADD]"
        '
        'txtLibelle
        '
        Me.txtLibelle.Location = New System.Drawing.Point(90, 11)
        Me.txtLibelle.Name = "txtLibelle"
        Me.txtLibelle.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLibelle.Size = New System.Drawing.Size(382, 20)
        Me.txtLibelle.TabIndex = 14
        Me.txtLibelle.Tag = "[NOEDIT][NOADD]"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(483, 12)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Size = New System.Drawing.Size(69, 20)
        Me.txtCode.TabIndex = 14
        Me.txtCode.Tag = "[NOEDIT][NOADD]"
        '
        'Frm_Attrb_Auto_Anlys_Ordo_Incomp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(707, 531)
        Me.Name = "Frm_Attrb_Auto_Anlys_Ordo_Incomp"
        Me.Text = "Attribution automatique"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpBTEDIT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txtLibelle2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents CardView1 As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents Col2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpBTEDIT As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLibelle2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCode2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLibelle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit

End Class
