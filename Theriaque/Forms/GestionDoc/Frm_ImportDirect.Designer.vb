<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ImportDirect
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
        Me.beChemin = New DevExpress.XtraEditors.ButtonEdit
        Me.lblChemin = New DevExpress.XtraEditors.LabelControl
        Me.btOk = New DevExpress.XtraEditors.SimpleButton
        Me.btFermer = New DevExpress.XtraEditors.SimpleButton
        Me.pgbarDocument = New DevExpress.XtraEditors.ProgressBarControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblNbImport = New DevExpress.XtraEditors.LabelControl
        Me.lblTotal = New DevExpress.XtraEditors.LabelControl
        Me.lstDetails = New DevExpress.XtraEditors.ListBoxControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.meNote = New DevExpress.XtraEditors.MemoEdit
        Me.lueCategorie = New DevExpress.XtraEditors.LookUpEdit
        Me.txtLibelle = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        CType(Me.beChemin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pgbarDocument.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.lstDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.meNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCategorie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'beChemin
        '
        Me.beChemin.Location = New System.Drawing.Point(49, 12)
        Me.beChemin.Name = "beChemin"
        Me.beChemin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton("explorer", DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis), New DevExpress.XtraEditors.Controls.EditorButton("effacer", DevExpress.XtraEditors.Controls.ButtonPredefines.Minus)})
        Me.beChemin.Size = New System.Drawing.Size(572, 20)
        Me.beChemin.TabIndex = 1
        '
        'lblChemin
        '
        Me.lblChemin.Location = New System.Drawing.Point(5, 16)
        Me.lblChemin.Name = "lblChemin"
        Me.lblChemin.Size = New System.Drawing.Size(35, 13)
        Me.lblChemin.TabIndex = 2
        Me.lblChemin.Text = "Chemin"
        '
        'btOk
        '
        Me.btOk.Location = New System.Drawing.Point(499, 11)
        Me.btOk.Name = "btOk"
        Me.btOk.Size = New System.Drawing.Size(58, 23)
        Me.btOk.TabIndex = 5
        Me.btOk.Text = "&Ok"
        '
        'btFermer
        '
        Me.btFermer.Location = New System.Drawing.Point(563, 11)
        Me.btFermer.Name = "btFermer"
        Me.btFermer.Size = New System.Drawing.Size(58, 23)
        Me.btFermer.TabIndex = 6
        Me.btFermer.Text = "&Fermer"
        '
        'pgbarDocument
        '
        Me.pgbarDocument.Location = New System.Drawing.Point(3, 4)
        Me.pgbarDocument.Name = "pgbarDocument"
        Me.pgbarDocument.Size = New System.Drawing.Size(218, 18)
        Me.pgbarDocument.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblNbImport)
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.pgbarDocument)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 416)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(633, 25)
        Me.Panel1.TabIndex = 8
        '
        'lblNbImport
        '
        Me.lblNbImport.Location = New System.Drawing.Point(324, 6)
        Me.lblNbImport.Name = "lblNbImport"
        Me.lblNbImport.Size = New System.Drawing.Size(6, 13)
        Me.lblNbImport.TabIndex = 9
        Me.lblNbImport.Text = "0"
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(227, 6)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(95, 13)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.Text = "Total doc importés :"
        '
        'lstDetails
        '
        Me.lstDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstDetails.Location = New System.Drawing.Point(2, 20)
        Me.lstDetails.Name = "lstDetails"
        Me.lstDetails.Size = New System.Drawing.Size(629, 222)
        Me.lstDetails.TabIndex = 9
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lblChemin)
        Me.PanelControl1.Controls.Add(Me.beChemin)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(633, 46)
        Me.PanelControl1.TabIndex = 10
        Me.PanelControl1.Text = "PanelControl1"
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
        Me.GroupControl1.Location = New System.Drawing.Point(0, 46)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(633, 86)
        Me.GroupControl1.TabIndex = 11
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
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.lstDetails)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 132)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(633, 244)
        Me.GroupControl2.TabIndex = 12
        Me.GroupControl2.Text = "Détail import"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btFermer)
        Me.PanelControl2.Controls.Add(Me.btOk)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 376)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(633, 40)
        Me.PanelControl2.TabIndex = 13
        Me.PanelControl2.Text = "PanelControl2"
        '
        'Frm_ImportDirect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 441)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_ImportDirect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import des documents"
        CType(Me.beChemin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pgbarDocument.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.lstDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.meNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCategorie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents beChemin As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents lblChemin As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btFermer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pgbarDocument As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTotal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lstDetails As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents lblNbImport As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents meNote As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lueCategorie As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtLibelle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl

End Class
