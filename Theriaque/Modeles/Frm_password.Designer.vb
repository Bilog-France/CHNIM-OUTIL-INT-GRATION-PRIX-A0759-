<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_password
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_password))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPass = New System.Windows.Forms.TextBox
        Me.txtUser = New System.Windows.Forms.ComboBox
        Me.chkSave = New System.Windows.Forms.CheckBox
        Me.btOk = New System.Windows.Forms.Button
        Me.btAnnuler = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LabelServer = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Connexion à"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Nom d'utilisateur :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "&Mot de passe :"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(103, 133)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(208, 20)
        Me.txtPass.TabIndex = 1
        Me.txtPass.Text = "Bilog@2014"
        '
        'txtUser
        '
        Me.txtUser.FormattingEnabled = True
        Me.txtUser.Items.AddRange(New Object() {"bechir"})
        Me.txtUser.Location = New System.Drawing.Point(103, 106)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(212, 21)
        Me.txtUser.TabIndex = 0
        '
        'chkSave
        '
        Me.chkSave.AutoSize = True
        Me.chkSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chkSave.Location = New System.Drawing.Point(108, 165)
        Me.chkSave.Name = "chkSave"
        Me.chkSave.Size = New System.Drawing.Size(156, 17)
        Me.chkSave.TabIndex = 2
        Me.chkSave.Text = "Mémoriser nom d'utilisateur"
        Me.chkSave.UseVisualStyleBackColor = True
        '
        'btOk
        '
        Me.btOk.Location = New System.Drawing.Point(152, 223)
        Me.btOk.Name = "btOk"
        Me.btOk.Size = New System.Drawing.Size(75, 23)
        Me.btOk.TabIndex = 3
        Me.btOk.Text = "Ok"
        Me.btOk.UseVisualStyleBackColor = True
        '
        'btAnnuler
        '
        Me.btAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btAnnuler.Location = New System.Drawing.Point(233, 223)
        Me.btAnnuler.Name = "btAnnuler"
        Me.btAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.btAnnuler.TabIndex = 4
        Me.btAnnuler.Text = "Annuler"
        Me.btAnnuler.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 63)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'LabelServer
        '
        Me.LabelServer.AutoSize = True
        Me.LabelServer.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LabelServer.Location = New System.Drawing.Point(76, 77)
        Me.LabelServer.Name = "LabelServer"
        Me.LabelServer.Size = New System.Drawing.Size(0, 13)
        Me.LabelServer.TabIndex = 1
        '
        'Frm_password
        '
        Me.AcceptButton = Me.btOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.CancelButton = Me.btAnnuler
        Me.ClientSize = New System.Drawing.Size(320, 255)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btAnnuler)
        Me.Controls.Add(Me.btOk)
        Me.Controls.Add(Me.chkSave)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelServer)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_password"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Connecter à "
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.ComboBox
    Friend WithEvents chkSave As System.Windows.Forms.CheckBox
    Friend WithEvents btOk As System.Windows.Forms.Button
    Friend WithEvents btAnnuler As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelServer As System.Windows.Forms.Label

End Class
