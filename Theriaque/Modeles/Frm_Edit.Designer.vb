<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Edit
    Inherits Theriaque.Frm_CNHIM

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        'LZA
        ClearMemory()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Edit))
        Me.Memo = New DevExpress.XtraEditors.MemoEdit
        Me.btOk = New DevExpress.XtraEditors.SimpleButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.SpinEditFont = New DevExpress.XtraEditors.SpinEdit
        Me.imageCollection2 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        CType(Me.Memo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.SpinEditFont.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Memo
        '
        Me.Memo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Memo.EditValue = ""
        Me.Memo.Location = New System.Drawing.Point(0, 79)
        Me.Memo.Name = "Memo"
        Me.Memo.Properties.Appearance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Memo.Properties.Appearance.Options.UseFont = True
        Me.Memo.Size = New System.Drawing.Size(782, 500)
        Me.Memo.TabIndex = 42
        '
        'btOk
        '
        Me.btOk.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btOk.Appearance.Options.UseFont = True
        Me.btOk.Dock = System.Windows.Forms.DockStyle.Top
        Me.btOk.Location = New System.Drawing.Point(0, 0)
        Me.btOk.Name = "btOk"
        Me.btOk.Size = New System.Drawing.Size(782, 43)
        Me.btOk.TabIndex = 43
        Me.btOk.Text = "&Ok"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.SpinEditFont)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(782, 36)
        Me.Panel1.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Taille Police"
        '
        'SpinEditFont
        '
        Me.SpinEditFont.EditValue = New Decimal(New Integer() {11, 0, 0, 0})
        Me.SpinEditFont.Location = New System.Drawing.Point(92, 8)
        Me.SpinEditFont.Name = "SpinEditFont"
        Me.SpinEditFont.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEditFont.Size = New System.Drawing.Size(52, 20)
        Me.SpinEditFont.TabIndex = 0
        '
        'imageCollection2
        '
        Me.imageCollection2.ImageStream = CType(resources.GetObject("imageCollection2.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.imageCollection2.TransparentColor = System.Drawing.Color.Transparent
        '
        'imageCollection1
        '
        Me.imageCollection1.ImageSize = New System.Drawing.Size(32, 32)
        Me.imageCollection1.ImageStream = CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'Frm_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(782, 579)
        Me.Controls.Add(Me.Memo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Frm_Edit"
        Me.ShowIcon = False
        Me.Text = "Texte"
        CType(Me.Memo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.SpinEditFont.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Memo As DevExpress.XtraEditors.MemoEdit
    Protected Friend WithEvents btOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SpinEditFont As DevExpress.XtraEditors.SpinEdit
    Private WithEvents imageCollection2 As DevExpress.Utils.ImageCollection
    Private WithEvents imageCollection1 As DevExpress.Utils.ImageCollection

End Class
