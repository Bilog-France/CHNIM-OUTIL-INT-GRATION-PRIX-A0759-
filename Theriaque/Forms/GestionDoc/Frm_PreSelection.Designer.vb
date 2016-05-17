<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PreSelection
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
        Me.rgSelection = New DevExpress.XtraEditors.RadioGroup
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.btnAnnuler = New DevExpress.XtraEditors.SimpleButton
        Me.btnLancerRche = New DevExpress.XtraEditors.SimpleButton
        Me.chkNewSearch = New DevExpress.XtraEditors.CheckEdit
        CType(Me.rgSelection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.chkNewSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rgSelection
        '
        Me.rgSelection.EditValue = "S"
        Me.rgSelection.Location = New System.Drawing.Point(10, 0)
        Me.rgSelection.Name = "rgSelection"
        Me.rgSelection.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgSelection.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rgSelection.Properties.Appearance.Options.UseBackColor = True
        Me.rgSelection.Properties.Appearance.Options.UseFont = True
        Me.rgSelection.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Spécialité"), New DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Présentation")})
        Me.rgSelection.Size = New System.Drawing.Size(289, 74)
        Me.rgSelection.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnAnnuler)
        Me.PanelControl1.Controls.Add(Me.btnLancerRche)
        Me.PanelControl1.Controls.Add(Me.chkNewSearch)
        Me.PanelControl1.Controls.Add(Me.rgSelection)
        Me.PanelControl1.Location = New System.Drawing.Point(-2, -1)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(299, 109)
        Me.PanelControl1.TabIndex = 1
        Me.PanelControl1.Text = "PanelControl1"
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Location = New System.Drawing.Point(213, 77)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnuler.TabIndex = 3
        Me.btnAnnuler.Text = "Annuler"
        '
        'btnLancerRche
        '
        Me.btnLancerRche.Location = New System.Drawing.Point(89, 78)
        Me.btnLancerRche.Name = "btnLancerRche"
        Me.btnLancerRche.Size = New System.Drawing.Size(117, 23)
        Me.btnLancerRche.TabIndex = 2
        Me.btnLancerRche.Text = "Lancer recherche"
        '
        'chkNewSearch
        '
        Me.chkNewSearch.Location = New System.Drawing.Point(160, 33)
        Me.chkNewSearch.Name = "chkNewSearch"
        Me.chkNewSearch.Properties.Caption = "Nouvelle Recherche"
        Me.chkNewSearch.Size = New System.Drawing.Size(125, 19)
        Me.chkNewSearch.TabIndex = 1
        '
        'Frm_PreSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 107)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Frm_PreSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Présélection"
        CType(Me.rgSelection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.chkNewSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rgSelection As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnAnnuler As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLancerRche As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkNewSearch As DevExpress.XtraEditors.CheckEdit
End Class
