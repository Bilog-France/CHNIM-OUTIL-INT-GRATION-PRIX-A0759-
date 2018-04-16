<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Config
    Inherits Theriaque.Frm_CNHIM

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Config))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btAnnuler = New DevExpress.XtraEditors.SimpleButton
        Me.btValider = New DevExpress.XtraEditors.SimpleButton
        Me.txtDB = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtServeur = New DevExpress.XtraEditors.ComboBoxEdit
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtDB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtServeur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btAnnuler)
        Me.GroupBox1.Controls.Add(Me.btValider)
        Me.GroupBox1.Controls.Add(Me.txtDB)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtServeur)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 159)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(2, 117)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(335, 3)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'btAnnuler
        '
        Me.btAnnuler.Image = CType(resources.GetObject("btAnnuler.Image"), System.Drawing.Image)
        Me.btAnnuler.Location = New System.Drawing.Point(138, 126)
        Me.btAnnuler.Name = "btAnnuler"
        Me.btAnnuler.Size = New System.Drawing.Size(94, 27)
        ToolTipItem1.Text = "F7 - Annuler les modifications"
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btAnnuler.SuperTip = SuperToolTip1
        Me.btAnnuler.TabIndex = 5
        Me.btAnnuler.Text = "A&nnuler"
        '
        'btValider
        '
        Me.btValider.Image = CType(resources.GetObject("btValider.Image"), System.Drawing.Image)
        Me.btValider.Location = New System.Drawing.Point(238, 126)
        Me.btValider.Name = "btValider"
        Me.btValider.Size = New System.Drawing.Size(94, 27)
        ToolTipItem2.Text = "F10 - Valider la saisie"
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.btValider.SuperTip = SuperToolTip2
        Me.btValider.TabIndex = 4
        Me.btValider.Text = "&Valider"
        '
        'txtDB
        '
        Me.txtDB.Location = New System.Drawing.Point(116, 45)
        Me.txtDB.Name = "txtDB"
        Me.txtDB.Size = New System.Drawing.Size(216, 20)
        Me.txtDB.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Base de données"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Serveur"
        '
        'txtServeur
        '
        Me.txtServeur.EditValue = ""
        Me.txtServeur.Location = New System.Drawing.Point(116, 19)
        Me.txtServeur.Name = "txtServeur"
        Me.txtServeur.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtServeur.Properties.Items.AddRange(New Object() {"172.16.1.235", "172.16.1.170,8008", "172.16.1.171,8008", ".\THERIAQUE"})
        Me.txtServeur.Size = New System.Drawing.Size(216, 20)
        Me.txtServeur.TabIndex = 0
        '
        'Frm_Config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(339, 159)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_Config"
        Me.Text = "Configuration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtDB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtServeur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtServeur As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtDB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Protected Friend WithEvents btAnnuler As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btValider As DevExpress.XtraEditors.SimpleButton

End Class
