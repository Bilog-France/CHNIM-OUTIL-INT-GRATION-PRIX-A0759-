<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Rubrique_Codification
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
        Me.RubcdF_RUBRIQUE_CODIFICATIONTableAdapter1 = New Theriaque.dsTheriaqueTableAdapters.RUBCDF_RUBRIQUE_CODIFICATIONTableAdapter
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.DsTheriaque1 = New Theriaque.dsTheriaque
        Me.txtLibelle = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(599, 344)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.Label3)
        Me.PanMain.Controls.Add(Me.Label2)
        Me.PanMain.Controls.Add(Me.txtLibelle)
        Me.PanMain.Controls.Add(Me.txtCode)
        Me.PanMain.Size = New System.Drawing.Size(481, 257)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(599, 87)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(599, 28)
        Me.Label1.Text = "Rubrique codification"
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
        Me.Panel1.Location = New System.Drawing.Point(481, 87)
        Me.Panel1.Size = New System.Drawing.Size(118, 257)
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "RUBCDF_RUBRIQUE_CODIFICATION.RUBCDF_DATEMJ", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Size = New System.Drawing.Size(599, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "RUBCDF_RUBRIQUE_CODIFICATION.RUBCDF_DATECR", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        '
        'RubcdF_RUBRIQUE_CODIFICATIONTableAdapter1
        '
        Me.RubcdF_RUBRIQUE_CODIFICATIONTableAdapter1.ClearBeforeFill = True
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "RUBCDF_RUBRIQUE_CODIFICATION.RUBCDF_NUMERO_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(92, 13)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Tag = "[NOEDIT][ADD]"
        '
        'DsTheriaque1
        '
        Me.DsTheriaque1.DataSetName = "dsTheriaque"
        Me.DsTheriaque1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtLibelle
        '
        Me.txtLibelle.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "RUBCDF_RUBRIQUE_CODIFICATION.RUBCDF_NOM", True))
        Me.txtLibelle.Location = New System.Drawing.Point(92, 39)
        Me.txtLibelle.Name = "txtLibelle"
        Me.txtLibelle.Size = New System.Drawing.Size(348, 20)
        Me.txtLibelle.TabIndex = 1
        Me.txtLibelle.Tag = "[EDIT][ADD]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Libellé"
        '
        'Frm_Rubrique_Codification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(599, 344)
        Me.Name = "Frm_Rubrique_Codification"
        Me.Text = "Rubrique codification"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanMain.PerformLayout()
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLibelle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RubcdF_RUBRIQUE_CODIFICATIONTableAdapter1 As Theriaque.dsTheriaqueTableAdapters.RUBCDF_RUBRIQUE_CODIFICATIONTableAdapter
    Friend WithEvents DsTheriaque1 As Theriaque.dsTheriaque

End Class
