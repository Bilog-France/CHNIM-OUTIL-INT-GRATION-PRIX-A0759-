<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ClasseChimique
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
        Me.lkupCPH_CPH_CODE_FK = New DevExpress.XtraEditors.LookUpEdit
        Me.DsTheriaque1 = New Theriaque.dsTheriaque
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GCFils = New DevExpress.XtraGrid.GridControl
        Me.GVFils = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCCH_CODE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCCH_NOM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSYCCH_NOM_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSYCCH_CCH_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtLibelle = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.txtCodePere = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CcH_CLASSECHIMIQUETableAdapter = New Theriaque.dsTheriaqueTableAdapters.CCH_CLASSECHIMIQUETableAdapter
        Me.SyccH_SYNONYME_CLASSECHIMIQUETableAdapter = New Theriaque.dsTheriaqueTableAdapters.SYCCH_SYNONYME_CLASSECHIMIQUETableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupCPH_CPH_CODE_FK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GCFils, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVFils, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodePere.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(697, 593)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.lkupCPH_CPH_CODE_FK)
        Me.PanMain.Controls.Add(Me.GroupBox2)
        Me.PanMain.Controls.Add(Me.GroupBox1)
        Me.PanMain.Controls.Add(Me.txtLibelle)
        Me.PanMain.Controls.Add(Me.Label6)
        Me.PanMain.Controls.Add(Me.Label5)
        Me.PanMain.Controls.Add(Me.txtCode)
        Me.PanMain.Controls.Add(Me.txtCodePere)
        Me.PanMain.Controls.Add(Me.Label3)
        Me.PanMain.Controls.Add(Me.Label2)
        Me.PanMain.Size = New System.Drawing.Size(579, 506)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(697, 87)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(697, 28)
        Me.Label1.Text = "Classe chimique "
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
        Me.Panel1.Location = New System.Drawing.Point(579, 87)
        Me.Panel1.Size = New System.Drawing.Size(118, 506)
        '
        'btChercher
        '
        Me.btChercher.Location = New System.Drawing.Point(8, 169)
        '
        'btFermer
        '
        Me.btFermer.Location = New System.Drawing.Point(8, 204)
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CCH_CLASSECHIMIQUE.CCH_DATEMJ", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Size = New System.Drawing.Size(697, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CCH_CLASSECHIMIQUE.CCH_DATECR", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        '
        'lkupCPH_CPH_CODE_FK
        '
        Me.lkupCPH_CPH_CODE_FK.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CCH_CLASSECHIMIQUE.CCH_CCH_CODE_FK", True))
        Me.lkupCPH_CPH_CODE_FK.Location = New System.Drawing.Point(288, 36)
        Me.lkupCPH_CPH_CODE_FK.Name = "lkupCPH_CPH_CODE_FK"
        Me.lkupCPH_CPH_CODE_FK.Properties.NullText = ""
        Me.lkupCPH_CPH_CODE_FK.Properties.ReadOnly = True
        Me.lkupCPH_CPH_CODE_FK.Size = New System.Drawing.Size(206, 20)
        Me.lkupCPH_CPH_CODE_FK.TabIndex = 10
        Me.lkupCPH_CPH_CODE_FK.Tag = "[NOEDIT][NOADD]"
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
        Me.GroupBox2.Controls.Add(Me.GCFils)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 283)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(561, 221)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = "[NOADD][EDIT]"
        Me.GroupBox2.Text = "Fils"
        '
        'GCFils
        '
        Me.GCFils.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GCFils.EmbeddedNavigator.Name = ""
        Me.GCFils.Location = New System.Drawing.Point(6, 13)
        Me.GCFils.MainView = Me.GVFils
        Me.GCFils.Name = "GCFils"
        Me.GCFils.Size = New System.Drawing.Size(544, 202)
        Me.GCFils.TabIndex = 1
        Me.GCFils.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVFils})
        '
        'GVFils
        '
        Me.GVFils.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCCH_CODE_PK, Me.colCCH_NOM})
        Me.GVFils.GridControl = Me.GCFils
        Me.GVFils.Name = "GVFils"
        Me.GVFils.OptionsView.ShowGroupPanel = False
        '
        'colCCH_CODE_PK
        '
        Me.colCCH_CODE_PK.Caption = "Code"
        Me.colCCH_CODE_PK.FieldName = "CCH_CODE_PK"
        Me.colCCH_CODE_PK.Name = "colCCH_CODE_PK"
        Me.colCCH_CODE_PK.Visible = True
        Me.colCCH_CODE_PK.VisibleIndex = 0
        Me.colCCH_CODE_PK.Width = 113
        '
        'colCCH_NOM
        '
        Me.colCCH_NOM.Caption = "Libellé"
        Me.colCCH_NOM.FieldName = "CCH_NOM"
        Me.colCCH_NOM.Name = "colCCH_NOM"
        Me.colCCH_NOM.Visible = True
        Me.colCCH_NOM.VisibleIndex = 1
        Me.colCCH_NOM.Width = 410
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GC)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(561, 189)
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
        Me.GC.DataMember = "SYCCH_SYNONYME_CLASSECHIMIQUE"
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
        Me.GC.Size = New System.Drawing.Size(544, 161)
        Me.GC.TabIndex = 0
        Me.GC.UseEmbeddedNavigator = True
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSYCCH_NOM_PK, Me.colSYCCH_CCH_CODE_FK})
        Me.GV.GridControl = Me.GC
        Me.GV.GroupPanelText = " "
        Me.GV.Name = "GV"
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'colSYCCH_NOM_PK
        '
        Me.colSYCCH_NOM_PK.Caption = "Libellé"
        Me.colSYCCH_NOM_PK.FieldName = "SYCCH_NOM_PK"
        Me.colSYCCH_NOM_PK.Name = "colSYCCH_NOM_PK"
        Me.colSYCCH_NOM_PK.Visible = True
        Me.colSYCCH_NOM_PK.VisibleIndex = 0
        '
        'colSYCCH_CCH_CODE_FK
        '
        Me.colSYCCH_CCH_CODE_FK.Caption = "SYCCH_CCH_CODE_FK"
        Me.colSYCCH_CCH_CODE_FK.FieldName = "SYCCH_CCH_CODE_FK"
        Me.colSYCCH_CCH_CODE_FK.Name = "colSYCCH_CCH_CODE_FK"
        '
        'txtLibelle
        '
        Me.txtLibelle.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CCH_CLASSECHIMIQUE.CCH_NOM", True))
        Me.txtLibelle.Location = New System.Drawing.Point(288, 61)
        Me.txtLibelle.Name = "txtLibelle"
        Me.txtLibelle.Size = New System.Drawing.Size(206, 20)
        Me.txtLibelle.TabIndex = 13
        Me.txtLibelle.Tag = "[EDIT]"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(245, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Libellé"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(245, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Libellé"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CCH_CLASSECHIMIQUE.CCH_CODE_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(97, 61)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 11
        Me.txtCode.Tag = "[NOEDIT][ADD]"
        '
        'txtCodePere
        '
        Me.txtCodePere.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque1, "CCH_CLASSECHIMIQUE.CCH_CCH_CODE_FK", True))
        Me.txtCodePere.Location = New System.Drawing.Point(97, 36)
        Me.txtCodePere.Name = "txtCodePere"
        Me.txtCodePere.Properties.ReadOnly = True
        Me.txtCodePere.Size = New System.Drawing.Size(100, 20)
        Me.txtCodePere.TabIndex = 9
        Me.txtCodePere.Tag = "[NOEDIT][NOADD]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Code classe"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Code père"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CcH_CLASSECHIMIQUETableAdapter
        '
        Me.CcH_CLASSECHIMIQUETableAdapter.ClearBeforeFill = True
        '
        'SyccH_SYNONYME_CLASSECHIMIQUETableAdapter
        '
        Me.SyccH_SYNONYME_CLASSECHIMIQUETableAdapter.ClearBeforeFill = True
        '
        'Frm_ClasseChimique
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(697, 593)
        Me.Name = "Frm_ClasseChimique"
        Me.Text = "Classe chimique "
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanMain.PerformLayout()
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupCPH_CPH_CODE_FK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GCFils, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVFils, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodePere.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lkupCPH_CPH_CODE_FK As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GCFils As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVFils As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtLibelle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodePere As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DsTheriaque1 As Theriaque.dsTheriaque
    Friend WithEvents CcH_CLASSECHIMIQUETableAdapter As Theriaque.dsTheriaqueTableAdapters.CCH_CLASSECHIMIQUETableAdapter
    Friend WithEvents SyccH_SYNONYME_CLASSECHIMIQUETableAdapter As Theriaque.dsTheriaqueTableAdapters.SYCCH_SYNONYME_CLASSECHIMIQUETableAdapter
    Friend WithEvents colSYCCH_NOM_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSYCCH_CCH_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCCH_CODE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCCH_NOM As DevExpress.XtraGrid.Columns.GridColumn

End Class
