<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_URL
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
        Me.DsTheriaqueURL = New Theriaque.dsTheriaqueURL
        Me.UrL_ADRESSETA = New Theriaque.dsTheriaqueURLTableAdapters.URL_ADRESSETableAdapter
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.ChkAuto = New DevExpress.XtraEditors.CheckEdit
        Me.Txt_NomChamp = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.Txt_typeURL = New DevExpress.XtraEditors.TextEdit
        Me.Memo_UrlFixe = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ProgressBar = New System.Windows.Forms.ProgressBar
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaqueURL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.ChkAuto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txt_NomChamp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txt_typeURL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Memo_UrlFixe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(543, 392)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.XtraTabControl1)
        Me.PanMain.Controls.Add(Me.GroupBox1)
        Me.PanMain.Size = New System.Drawing.Size(425, 305)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(543, 87)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(543, 28)
        Me.Label1.Text = "Paramétrage des Urls"
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
        Me.Panel1.Location = New System.Drawing.Point(425, 87)
        Me.Panel1.Size = New System.Drawing.Size(118, 305)
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Size = New System.Drawing.Size(543, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        '
        'DsTheriaqueURL
        '
        Me.DsTheriaqueURL.DataSetName = "dsTheriaqueURL"
        Me.DsTheriaqueURL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UrL_ADRESSETA
        '
        Me.UrL_ADRESSETA.ClearBeforeFill = True
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 45)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(425, 260)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.Tomato
        Me.XtraTabPage1.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage1.Controls.Add(Me.ChkAuto)
        Me.XtraTabPage1.Controls.Add(Me.Txt_NomChamp)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage1.Controls.Add(Me.Txt_typeURL)
        Me.XtraTabPage1.Controls.Add(Me.Memo_UrlFixe)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl12)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(416, 229)
        Me.XtraTabPage1.Tag = "[EDIT][ADD]"
        Me.XtraTabPage1.Text = "Edition des Urls"
        '
        'ChkAuto
        '
        Me.ChkAuto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaqueURL, "URL_ADRESSE.URL_AUTO", True))
        Me.ChkAuto.Location = New System.Drawing.Point(102, 178)
        Me.ChkAuto.Name = "ChkAuto"
        Me.ChkAuto.Properties.Caption = "Attribution automatique"
        Me.ChkAuto.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.ChkAuto.Size = New System.Drawing.Size(147, 19)
        Me.ChkAuto.TabIndex = 17
        '
        'Txt_NomChamp
        '
        Me.Txt_NomChamp.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaqueURL, "URL_ADRESSE.URL_SP_CHAMPS", True))
        Me.Txt_NomChamp.Location = New System.Drawing.Point(104, 58)
        Me.Txt_NomChamp.Name = "Txt_NomChamp"
        Me.Txt_NomChamp.Size = New System.Drawing.Size(138, 20)
        Me.Txt_NomChamp.TabIndex = 16
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(13, 58)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl3.TabIndex = 15
        Me.LabelControl3.Text = "Nom du champ"
        '
        'Txt_typeURL
        '
        Me.Txt_typeURL.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaqueURL, "URL_ADRESSE.URL_TYPE", True))
        Me.Txt_typeURL.Location = New System.Drawing.Point(104, 26)
        Me.Txt_typeURL.Name = "Txt_typeURL"
        Me.Txt_typeURL.Size = New System.Drawing.Size(138, 20)
        Me.Txt_typeURL.TabIndex = 12
        '
        'Memo_UrlFixe
        '
        Me.Memo_UrlFixe.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaqueURL, "URL_ADRESSE.URL_FIXE", True))
        Me.Memo_UrlFixe.Location = New System.Drawing.Point(104, 90)
        Me.Memo_UrlFixe.Name = "Memo_UrlFixe"
        Me.Memo_UrlFixe.Size = New System.Drawing.Size(250, 76)
        Me.Memo_UrlFixe.TabIndex = 11
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(49, 92)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl5.TabIndex = 10
        Me.LabelControl5.Text = "Url fixe"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(25, 26)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl12.TabIndex = 7
        Me.LabelControl12.Text = "Type de l'url"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ProgressBar)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.LabelControl7)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 45)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(237, 14)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(182, 19)
        Me.ProgressBar.TabIndex = 22
        Me.ProgressBar.Visible = False
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaqueURL, "URL_ADRESSE.URL_CODE_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(92, 13)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(139, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Tag = "[NOEDIT][NOADD]"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(46, 17)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl7.TabIndex = 1
        Me.LabelControl7.Text = "Fiche N°"
        '
        'Frm_URL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(543, 392)
        Me.Name = "Frm_URL"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaqueURL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.ChkAuto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txt_NomChamp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txt_typeURL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Memo_UrlFixe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents DsTheriaqueURL As Theriaque.dsTheriaqueURL
    Friend WithEvents UrL_ADRESSETA As Theriaque.dsTheriaqueURLTableAdapters.URL_ADRESSETableAdapter
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Txt_NomChamp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Txt_typeURL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Memo_UrlFixe As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents ChkAuto As DevExpress.XtraEditors.CheckEdit

End Class
