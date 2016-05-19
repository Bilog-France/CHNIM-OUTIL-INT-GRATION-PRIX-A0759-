<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Gestion
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.DsTheriaque1 = New Theriaque.dsTheriaque
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSYCGE_NOM_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSYCGE_CGE_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtLibelle = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.SycgE_SYNONYME_CLASSEGESTIONTableAdapter = New Theriaque.dsTheriaqueTableAdapters.SYCGE_SYNONYME_CLASSEGESTIONTableAdapter
        Me.CgE_CLASSEGESTIONTableAdapter = New Theriaque.dsTheriaqueTableAdapters.CGE_CLASSEGESTIONTableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(669, 541)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.GroupBox1)
        Me.PanMain.Controls.Add(Me.txtLibelle)
        Me.PanMain.Controls.Add(Me.Label6)
        Me.PanMain.Controls.Add(Me.txtCode)
        Me.PanMain.Controls.Add(Me.Label3)
        Me.PanMain.Size = New System.Drawing.Size(551, 454)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(669, 87)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(669, 28)
        Me.Label1.Text = "Classe Gestion"
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
        Me.Panel1.Location = New System.Drawing.Point(551, 87)
        Me.Panel1.Size = New System.Drawing.Size(118, 454)
        '
        'btChercher
        '
        Me.btChercher.Location = New System.Drawing.Point(8, 170)
        '
        'btFermer
        '
        Me.btFermer.Location = New System.Drawing.Point(8, 207)
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CGE_CLASSEGESTION.CGE_DATEMJ", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Size = New System.Drawing.Size(669, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CGE_CLASSEGESTION.CGE_DATECR", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GC)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 365)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = "[NOADD][EDIT]"
        Me.GroupBox1.Text = "Synonymes"
        '
        'GC
        '
        Me.GC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC.DataMember = "SYCGE_SYNONYME_CLASSEGESTION"
        Me.GC.DataSource = Me.DsTheriaque1
        Me.GC.EmbeddedNavigator.Buttons.Edit.Visible = False
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
        Me.GC.EmbeddedNavigator.Name = ""
        Me.GC.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC.Location = New System.Drawing.Point(6, 18)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.Size = New System.Drawing.Size(535, 341)
        Me.GC.TabIndex = 0
        Me.GC.UseEmbeddedNavigator = True
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'DsTheriaque1
        '
        Me.DsTheriaque1.DataSetName = "dsTheriaque"
        Me.DsTheriaque1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSYCGE_NOM_PK, Me.colSYCGE_CGE_CODE_FK})
        Me.GV.GridControl = Me.GC
        Me.GV.GroupPanelText = " "
        Me.GV.Name = "GV"
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'colSYCGE_NOM_PK
        '
        Me.colSYCGE_NOM_PK.Caption = "Libellé"
        Me.colSYCGE_NOM_PK.FieldName = "SYCGE_NOM_PK"
        Me.colSYCGE_NOM_PK.Name = "colSYCGE_NOM_PK"
        Me.colSYCGE_NOM_PK.Visible = True
        Me.colSYCGE_NOM_PK.VisibleIndex = 0
        '
        'colSYCGE_CGE_CODE_FK
        '
        Me.colSYCGE_CGE_CODE_FK.Caption = "SYCGE_CGE_CODE_FK"
        Me.colSYCGE_CGE_CODE_FK.FieldName = "SYCGE_CGE_CODE_FK"
        Me.colSYCGE_CGE_CODE_FK.Name = "colSYCGE_CGE_CODE_FK"
        '
        'txtLibelle
        '
        Me.txtLibelle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLibelle.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CGE_CLASSEGESTION.CGE_NOM", True))
        Me.txtLibelle.Location = New System.Drawing.Point(92, 51)
        Me.txtLibelle.Name = "txtLibelle"
        Me.txtLibelle.Size = New System.Drawing.Size(440, 20)
        Me.txtLibelle.TabIndex = 12
        Me.txtLibelle.Tag = "[EDIT][ADD]"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Libellé"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CGE_CLASSEGESTION.CGE_CODE_SQ_PK", True))
        Me.txtCode.Enabled = False
        Me.txtCode.Location = New System.Drawing.Point(92, 25)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Size = New System.Drawing.Size(77, 20)
        Me.txtCode.TabIndex = 10
        Me.txtCode.Tag = "[NOEDIT][NOADD]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Code classe"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SycgE_SYNONYME_CLASSEGESTIONTableAdapter
        '
        Me.SycgE_SYNONYME_CLASSEGESTIONTableAdapter.ClearBeforeFill = True
        '
        'CgE_CLASSEGESTIONTableAdapter
        '
        Me.CgE_CLASSEGESTIONTableAdapter.ClearBeforeFill = True
        '
        'Frm_Gestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(669, 541)
        Me.Name = "Frm_Gestion"
        Me.Text = "Classe Gestion"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanMain.PerformLayout()
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtLibelle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DsTheriaque1 As Theriaque.dsTheriaque
    Friend WithEvents SycgE_SYNONYME_CLASSEGESTIONTableAdapter As Theriaque.dsTheriaqueTableAdapters.SYCGE_SYNONYME_CLASSEGESTIONTableAdapter
    Friend WithEvents CgE_CLASSEGESTIONTableAdapter As Theriaque.dsTheriaqueTableAdapters.CGE_CLASSEGESTIONTableAdapter
    Friend WithEvents colSYCGE_NOM_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSYCGE_CGE_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn

End Class
