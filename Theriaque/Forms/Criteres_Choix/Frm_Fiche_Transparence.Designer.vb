<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Fiche_Transparence
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
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.DsTheriaque_CriteresChoix = New Theriaque.dsTheriaque_CriteresChoix
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.DateEdit3 = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.FtR_TA = New Theriaque.dsTheriaque_CriteresChoixTableAdapters.FTR_FICHETRANSPARENCETableAdapter
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_CriteresChoix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel14.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.XtraTabControl1)
        '
        'Label1
        '
        Me.Label1.Text = "Fiche de transparence"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Visible = False
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit1.Visible = False
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit2.Visible = False
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_CriteresChoix, "FTR_FICHETRANSPARENCE.FTR_CODE_SQ_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(99, 17)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 16
        Me.txtCode.Tag = "[NOEDIT][NOADD]"
        '
        'DsTheriaque_CriteresChoix
        '
        Me.DsTheriaque_CriteresChoix.DataSetName = "dsTheriaque_CriteresChoix"
        Me.DsTheriaque_CriteresChoix.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(71, 75)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl5.TabIndex = 19
        Me.LabelControl5.Text = "Titre"
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_CriteresChoix, "FTR_FICHETRANSPARENCE.FTR_TITRE", True))
        Me.TextEdit2.Location = New System.Drawing.Point(99, 71)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(254, 20)
        Me.TextEdit2.TabIndex = 20
        Me.TextEdit2.Tag = "[ADD][EDIT]"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(53, 20)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl3.TabIndex = 17
        Me.LabelControl3.Text = "Fiche N°"
        '
        'DateEdit3
        '
        Me.DateEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_CriteresChoix, "FTR_FICHETRANSPARENCE.FTR_DATE_REDACTION", True))
        Me.DateEdit3.EditValue = Nothing
        Me.DateEdit3.Location = New System.Drawing.Point(99, 44)
        Me.DateEdit3.Name = "DateEdit3"
        Me.DateEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit3.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit3.TabIndex = 21
        Me.DateEdit3.Tag = "[ADD][EDIT]"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(7, 47)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl4.TabIndex = 18
        Me.LabelControl4.Text = "Date de rédaction"
        '
        'FtR_TA
        '
        Me.FtR_TA.ClearBeforeFill = True
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(4, 3)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(508, 473)
        Me.XtraTabControl1.TabIndex = 37
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panel12)
        Me.XtraTabPage1.Controls.Add(Me.GroupBox1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(499, 442)
        Me.XtraTabPage1.Text = "Fiche"
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.Panel14)
        Me.Panel12.Controls.Add(Me.Panel13)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(0, 104)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(499, 338)
        Me.Panel12.TabIndex = 40
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.MemoEdit1)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(0, 24)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(499, 314)
        Me.Panel14.TabIndex = 38
        Me.Panel14.Tag = "[EDIT][ADD]"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_CriteresChoix, "FTR_FICHETRANSPARENCE.FTR_TEXTE", True))
        Me.MemoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoEdit1.Location = New System.Drawing.Point(0, 0)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(499, 314)
        Me.MemoEdit1.TabIndex = 36
        Me.MemoEdit1.Tag = ""
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.LabelControl6)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(499, 24)
        Me.Panel13.TabIndex = 37
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(3, 7)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl6.TabIndex = 19
        Me.LabelControl6.Text = "Texte"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.TextEdit2)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.DateEdit3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(499, 104)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'Frm_Fiche_Transparence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(630, 566)
        Me.Name = "Frm_Fiche_Transparence"
        Me.Text = "Fiche de transparence"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_CriteresChoix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FtR_TA As Theriaque.dsTheriaque_CriteresChoixTableAdapters.FTR_FICHETRANSPARENCETableAdapter
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit3 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DsTheriaque_CriteresChoix As Theriaque.dsTheriaque_CriteresChoix
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl

End Class
