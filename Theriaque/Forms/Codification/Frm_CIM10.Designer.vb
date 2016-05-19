<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CIM10
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
        Me.DsTheriaque1 = New Theriaque.dsTheriaque
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCodeP = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCIM_CODE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colCIM_CIM_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCIM_LIBELLE_COURT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCIM_DATECR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCIM_DATEMJ = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CiM10TableAdapter = New Theriaque.dsTheriaqueTableAdapters.CIM10TableAdapter
        Me.lkupCIM_CIM_CODE_FK = New DevExpress.XtraEditors.LookUpEdit
        Me.CiM10TableAdapterFils = New Theriaque.dsTheriaqueTableAdapters.CIM10_2TableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodeP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupCIM_CIM_CODE_FK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(712, 543)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.lkupCIM_CIM_CODE_FK)
        Me.PanMain.Controls.Add(Me.GroupBox2)
        Me.PanMain.Controls.Add(Me.TextEdit3)
        Me.PanMain.Controls.Add(Me.Label5)
        Me.PanMain.Controls.Add(Me.TextEdit1)
        Me.PanMain.Controls.Add(Me.Label2)
        Me.PanMain.Controls.Add(Me.txtCode)
        Me.PanMain.Controls.Add(Me.Label4)
        Me.PanMain.Controls.Add(Me.GroupBox1)
        Me.PanMain.Controls.Add(Me.Label6)
        Me.PanMain.Controls.Add(Me.txtCodeP)
        Me.PanMain.Controls.Add(Me.Label3)
        Me.PanMain.Size = New System.Drawing.Size(594, 456)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(712, 87)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(712, 28)
        Me.Label1.Text = "Classe CIM10"
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
        Me.Panel1.Location = New System.Drawing.Point(594, 87)
        Me.Panel1.Size = New System.Drawing.Size(118, 456)
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CIM10.CIM_DATEMJ", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Size = New System.Drawing.Size(712, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CIM10.CIM_DATECR", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        '
        'DsTheriaque1
        '
        Me.DsTheriaque1.DataSetName = "dsTheriaque"
        Me.DsTheriaque1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(257, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Libellé"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodeP
        '
        Me.txtCodeP.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CIM10.CIM_CIM_CODE_FK", True))
        Me.txtCodeP.Enabled = False
        Me.txtCodeP.Location = New System.Drawing.Point(116, 22)
        Me.txtCodeP.Name = "txtCodeP"
        Me.txtCodeP.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodeP.Size = New System.Drawing.Size(90, 20)
        Me.txtCodeP.TabIndex = 15
        Me.txtCodeP.Tag = "[NOEDIT][NOADD]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Code CIM10 père"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(578, 8)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CIM10.CIM_LIBELLE_COURT", True))
        Me.TextEdit1.Location = New System.Drawing.Point(116, 93)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(212, 20)
        Me.TextEdit1.TabIndex = 21
        Me.TextEdit1.Tag = "[EDIT][ADD]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Libellé court"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CIM10.CIM_CODE_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(116, 67)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Size = New System.Drawing.Size(90, 20)
        Me.txtCode.TabIndex = 20
        Me.txtCode.Tag = "[NOEDIT][ADD]"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Code CIM10"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CIM10.CIM_LIBELLE_LONG", True))
        Me.TextEdit3.Location = New System.Drawing.Point(116, 120)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(396, 20)
        Me.TextEdit3.TabIndex = 23
        Me.TextEdit3.Tag = "[EDIT][ADD]"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Libellé Long"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.GC)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 146)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(575, 307)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = "[NOADD][EDIT]"
        Me.GroupBox2.Text = "Fils"
        '
        'GC
        '
        Me.GC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC.DataMember = "CIM10_2"
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
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.GC.Size = New System.Drawing.Size(558, 279)
        Me.GC.TabIndex = 0
        Me.GC.UseEmbeddedNavigator = True
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCIM_CODE_PK, Me.colCIM_CIM_CODE_FK, Me.colCIM_LIBELLE_COURT, Me.colCIM_DATECR, Me.colCIM_DATEMJ})
        Me.GV.GridControl = Me.GC
        Me.GV.GroupPanelText = " "
        Me.GV.Name = "GV"
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'colCIM_CODE_PK
        '
        Me.colCIM_CODE_PK.Caption = "Code"
        Me.colCIM_CODE_PK.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colCIM_CODE_PK.FieldName = "CIM_CODE_PK"
        Me.colCIM_CODE_PK.Name = "colCIM_CODE_PK"
        Me.colCIM_CODE_PK.Visible = True
        Me.colCIM_CODE_PK.VisibleIndex = 0
        Me.colCIM_CODE_PK.Width = 99
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colCIM_CIM_CODE_FK
        '
        Me.colCIM_CIM_CODE_FK.Caption = "CIM_CIM_CODE_FK"
        Me.colCIM_CIM_CODE_FK.FieldName = "CIM_CIM_CODE_FK"
        Me.colCIM_CIM_CODE_FK.Name = "colCIM_CIM_CODE_FK"
        '
        'colCIM_LIBELLE_COURT
        '
        Me.colCIM_LIBELLE_COURT.Caption = "Libellé"
        Me.colCIM_LIBELLE_COURT.FieldName = "CIM_LIBELLE_COURT"
        Me.colCIM_LIBELLE_COURT.Name = "colCIM_LIBELLE_COURT"
        Me.colCIM_LIBELLE_COURT.Visible = True
        Me.colCIM_LIBELLE_COURT.VisibleIndex = 1
        Me.colCIM_LIBELLE_COURT.Width = 438
        '
        'colCIM_DATECR
        '
        Me.colCIM_DATECR.Caption = "Date de création"
        Me.colCIM_DATECR.FieldName = "CIM_DATECR"
        Me.colCIM_DATECR.Name = "colCIM_DATECR"
        '
        'colCIM_DATEMJ
        '
        Me.colCIM_DATEMJ.Caption = "Date modif"
        Me.colCIM_DATEMJ.FieldName = "CIM_DATEMJ"
        Me.colCIM_DATEMJ.Name = "colCIM_DATEMJ"
        Me.colCIM_DATEMJ.Width = 102
        '
        'CiM10TableAdapter
        '
        Me.CiM10TableAdapter.ClearBeforeFill = True
        '
        'lkupCIM_CIM_CODE_FK
        '
        Me.lkupCIM_CIM_CODE_FK.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CIM10.CIM_CIM_CODE_FK", True))
        Me.lkupCIM_CIM_CODE_FK.Location = New System.Drawing.Point(300, 22)
        Me.lkupCIM_CIM_CODE_FK.Name = "lkupCIM_CIM_CODE_FK"
        Me.lkupCIM_CIM_CODE_FK.Properties.NullText = ""
        Me.lkupCIM_CIM_CODE_FK.Size = New System.Drawing.Size(212, 20)
        Me.lkupCIM_CIM_CODE_FK.TabIndex = 26
        Me.lkupCIM_CIM_CODE_FK.Tag = "[NOEDIT][NOADD]"
        '
        'CiM10TableAdapterFils
        '
        Me.CiM10TableAdapterFils.ClearBeforeFill = True
        '
        'Frm_CIM10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(712, 543)
        Me.Name = "Frm_CIM10"
        Me.Text = "Classe CIM10"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanMain.PerformLayout()
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodeP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupCIM_CIM_CODE_FK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCodeP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsTheriaque1 As Theriaque.dsTheriaque
    Friend WithEvents CiM10TableAdapter As Theriaque.dsTheriaqueTableAdapters.CIM10TableAdapter
    Friend WithEvents colCIM_CODE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIM_CIM_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIM_LIBELLE_COURT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkupCIM_CIM_CODE_FK As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents colCIM_DATECR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CiM10TableAdapterFils As Theriaque.dsTheriaqueTableAdapters.CIM10_2TableAdapter
    Friend WithEvents colCIM_DATEMJ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

End Class
