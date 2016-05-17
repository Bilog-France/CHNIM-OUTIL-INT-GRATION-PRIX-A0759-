<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_CISP
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
        Me.lkupCISP_CISP_CODE_FK = New DevExpress.XtraEditors.LookUpEdit
        Me.DsTheriaque1 = New Theriaque.dsTheriaque
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCISP_CODE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colCISP_CISP_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCISP_LIBELLE_COURT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCISP_LIBELLE_LONG = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCISP_DATECR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCISP_DATEMJ = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCodeP = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.CisP_CLASSIF_INTER_SOINSTableAdapter = New Theriaque.dsTheriaqueTableAdapters.CISP_CLASSIF_INTER_SOINSTableAdapter
        Me.CisP_CLASSIF_INTER_SOINS_2TableAdapterFils = New Theriaque.dsTheriaqueTableAdapters.CISP_CLASSIF_INTER_SOINS_2TableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupCISP_CISP_CODE_FK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodeP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(712, 543)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.lkupCISP_CISP_CODE_FK)
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
        Me.Label1.Text = "Classe CISP"
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
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CISP_CLASSIF_INTER_SOINS.CISP_DATEMJ", True))
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
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CISP_CLASSIF_INTER_SOINS.CISP_DATECR", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        '
        'lkupCISP_CISP_CODE_FK
        '
        Me.lkupCISP_CISP_CODE_FK.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CISP_CLASSIF_INTER_SOINS.CISP_CISP_CODE_FK", True))
        Me.lkupCISP_CISP_CODE_FK.Location = New System.Drawing.Point(300, 22)
        Me.lkupCISP_CISP_CODE_FK.Name = "lkupCISP_CISP_CODE_FK"
        Me.lkupCISP_CISP_CODE_FK.Properties.NullText = ""
        Me.lkupCISP_CISP_CODE_FK.Size = New System.Drawing.Size(212, 20)
        Me.lkupCISP_CISP_CODE_FK.TabIndex = 38
        Me.lkupCISP_CISP_CODE_FK.Tag = "[NOEDIT][NOADD]"
        '
        'DsTheriaque1
        '
        Me.DsTheriaque1.DataSetName = "dsTheriaque"
        Me.DsTheriaque1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.GC)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 153)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(575, 300)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = "[NOADD][EDIT]"
        Me.GroupBox2.Text = "Fils"
        '
        'GC
        '
        Me.GC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC.DataMember = "CISP_CLASSIF_INTER_SOINS_2"
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
        Me.GC.Size = New System.Drawing.Size(558, 272)
        Me.GC.TabIndex = 0
        Me.GC.UseEmbeddedNavigator = True
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCISP_CODE_PK, Me.colCISP_CISP_CODE_FK, Me.colCISP_LIBELLE_COURT, Me.colCISP_LIBELLE_LONG, Me.colCISP_DATECR, Me.colCISP_DATEMJ})
        Me.GV.GridControl = Me.GC
        Me.GV.GroupPanelText = " "
        Me.GV.Name = "GV"
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'colCISP_CODE_PK
        '
        Me.colCISP_CODE_PK.Caption = "Code"
        Me.colCISP_CODE_PK.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colCISP_CODE_PK.FieldName = "CISP_CODE_PK"
        Me.colCISP_CODE_PK.Name = "colCISP_CODE_PK"
        Me.colCISP_CODE_PK.Visible = True
        Me.colCISP_CODE_PK.VisibleIndex = 0
        Me.colCISP_CODE_PK.Width = 114
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colCISP_CISP_CODE_FK
        '
        Me.colCISP_CISP_CODE_FK.Caption = "CISP_CISP_CODE_FK"
        Me.colCISP_CISP_CODE_FK.FieldName = "CISP_CISP_CODE_FK"
        Me.colCISP_CISP_CODE_FK.Name = "colCISP_CISP_CODE_FK"
        '
        'colCISP_LIBELLE_COURT
        '
        Me.colCISP_LIBELLE_COURT.Caption = "Libellé"
        Me.colCISP_LIBELLE_COURT.FieldName = "CISP_LIBELLE_COURT"
        Me.colCISP_LIBELLE_COURT.Name = "colCISP_LIBELLE_COURT"
        Me.colCISP_LIBELLE_COURT.Visible = True
        Me.colCISP_LIBELLE_COURT.VisibleIndex = 1
        Me.colCISP_LIBELLE_COURT.Width = 423
        '
        'colCISP_LIBELLE_LONG
        '
        Me.colCISP_LIBELLE_LONG.Caption = "CISP_LIBELLE_LONG"
        Me.colCISP_LIBELLE_LONG.FieldName = "CISP_LIBELLE_LONG"
        Me.colCISP_LIBELLE_LONG.Name = "colCISP_LIBELLE_LONG"
        '
        'colCISP_DATECR
        '
        Me.colCISP_DATECR.Caption = "CISP_DATECR"
        Me.colCISP_DATECR.FieldName = "CISP_DATECR"
        Me.colCISP_DATECR.Name = "colCISP_DATECR"
        '
        'colCISP_DATEMJ
        '
        Me.colCISP_DATEMJ.Caption = "CISP_DATEMJ"
        Me.colCISP_DATEMJ.FieldName = "CISP_DATEMJ"
        Me.colCISP_DATEMJ.Name = "colCISP_DATEMJ"
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CISP_CLASSIF_INTER_SOINS.CISP_LIBELLE_LONG", True))
        Me.TextEdit3.Location = New System.Drawing.Point(116, 127)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(396, 20)
        Me.TextEdit3.TabIndex = 35
        Me.TextEdit3.Tag = "[EDIT][ADD]"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Libellé Long"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CISP_CLASSIF_INTER_SOINS.CISP_LIBELLE_COURT", True))
        Me.TextEdit1.Location = New System.Drawing.Point(116, 101)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(230, 20)
        Me.TextEdit1.TabIndex = 33
        Me.TextEdit1.Tag = "[EDIT][ADD]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Libellé court"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CISP_CLASSIF_INTER_SOINS.CISP_CODE_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(116, 74)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Size = New System.Drawing.Size(90, 20)
        Me.txtCode.TabIndex = 32
        Me.txtCode.Tag = "[NOEDIT][ADD]"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Code CISP"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(570, 8)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(257, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Libellé"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodeP
        '
        Me.txtCodeP.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CISP_CLASSIF_INTER_SOINS.CISP_CISP_CODE_FK", True))
        Me.txtCodeP.Enabled = False
        Me.txtCodeP.Location = New System.Drawing.Point(116, 21)
        Me.txtCodeP.Name = "txtCodeP"
        Me.txtCodeP.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodeP.Size = New System.Drawing.Size(90, 20)
        Me.txtCodeP.TabIndex = 28
        Me.txtCodeP.Tag = "[NOEDIT][NOADD]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Code CISP père"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CisP_CLASSIF_INTER_SOINSTableAdapter
        '
        Me.CisP_CLASSIF_INTER_SOINSTableAdapter.ClearBeforeFill = True
        '
        'CisP_CLASSIF_INTER_SOINS_2TableAdapterFils
        '
        Me.CisP_CLASSIF_INTER_SOINS_2TableAdapterFils.ClearBeforeFill = True
        '
        'FRM_CISP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(712, 543)
        Me.Name = "FRM_CISP"
        Me.Text = "Classe CISP"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanMain.PerformLayout()
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupCISP_CISP_CODE_FK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodeP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lkupCISP_CISP_CODE_FK As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCodeP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DsTheriaque1 As Theriaque.dsTheriaque
    Friend WithEvents CisP_CLASSIF_INTER_SOINSTableAdapter As Theriaque.dsTheriaqueTableAdapters.CISP_CLASSIF_INTER_SOINSTableAdapter
    Friend WithEvents CisP_CLASSIF_INTER_SOINS_2TableAdapterFils As Theriaque.dsTheriaqueTableAdapters.CISP_CLASSIF_INTER_SOINS_2TableAdapter
    Friend WithEvents colCISP_CODE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCISP_CISP_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCISP_LIBELLE_COURT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCISP_LIBELLE_LONG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCISP_DATECR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCISP_DATEMJ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

End Class
