<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Dictionnaire_Declinaison
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
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.colDisable = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanMain = New System.Windows.Forms.Panel
        Me.gcPredictive = New DevExpress.XtraGrid.GridControl
        Me.gvPredictive = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colcheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpCheck = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLibelle = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNum = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVal1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVal2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVal3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colchkFixe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpCheck2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btNone = New DevExpress.XtraEditors.SimpleButton
        Me.btPasser = New DevExpress.XtraEditors.SimpleButton
        Me.btAnnuler = New DevExpress.XtraEditors.SimpleButton
        Me.btTout = New DevExpress.XtraEditors.SimpleButton
        Me.btOk = New DevExpress.XtraEditors.SimpleButton
        Me.PanTop = New System.Windows.Forms.Panel
        Me.labTitre = New System.Windows.Forms.Label
        Me.txtSearch = New DevExpress.XtraEditors.TextEdit
        Me.PanMain.SuspendLayout()
        CType(Me.gcPredictive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPredictive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpCheck2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanTop.SuspendLayout()
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colDisable
        '
        Me.colDisable.Caption = "Désactivation"
        Me.colDisable.FieldName = "disable"
        Me.colDisable.Name = "colDisable"
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.gcPredictive)
        Me.PanMain.Controls.Add(Me.Panel1)
        Me.PanMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMain.Location = New System.Drawing.Point(0, 64)
        Me.PanMain.Name = "PanMain"
        Me.PanMain.Size = New System.Drawing.Size(497, 419)
        Me.PanMain.TabIndex = 3
        '
        'gcPredictive
        '
        Me.gcPredictive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPredictive.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gcPredictive.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcPredictive.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcPredictive.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.gcPredictive.EmbeddedNavigator.Name = ""
        Me.gcPredictive.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.gcPredictive.Location = New System.Drawing.Point(0, 0)
        Me.gcPredictive.MainView = Me.gvPredictive
        Me.gcPredictive.Name = "gcPredictive"
        Me.gcPredictive.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpCheck, Me.rpCheck2})
        Me.gcPredictive.Size = New System.Drawing.Size(497, 377)
        Me.gcPredictive.TabIndex = 0
        Me.gcPredictive.UseEmbeddedNavigator = True
        Me.gcPredictive.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPredictive})
        '
        'gvPredictive
        '
        Me.gvPredictive.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcheck, Me.colCode, Me.colLibelle, Me.colNum, Me.colVal1, Me.colVal2, Me.colVal3, Me.colchkFixe, Me.colDisable})
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colDisable
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "1"
        StyleFormatCondition2.Value2 = ""
        Me.gvPredictive.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
        Me.gvPredictive.GridControl = Me.gcPredictive
        Me.gvPredictive.GroupPanelText = " "
        Me.gvPredictive.Name = "gvPredictive"
        Me.gvPredictive.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvPredictive.OptionsView.AutoCalcPreviewLineCount = True
        Me.gvPredictive.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colcheck, DevExpress.Data.ColumnSortOrder.Descending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCode, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colcheck
        '
        Me.colcheck.ColumnEdit = Me.rpCheck
        Me.colcheck.FieldName = "chk"
        Me.colcheck.Name = "colcheck"
        Me.colcheck.Visible = True
        Me.colcheck.VisibleIndex = 0
        Me.colcheck.Width = 38
        '
        'rpCheck
        '
        Me.rpCheck.AutoHeight = False
        Me.rpCheck.Name = "rpCheck"
        Me.rpCheck.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.rpCheck.ValueChecked = 1
        Me.rpCheck.ValueUnchecked = 0
        '
        'colCode
        '
        Me.colCode.Caption = "Code"
        Me.colCode.FieldName = "code"
        Me.colCode.Name = "colCode"
        Me.colCode.OptionsColumn.AllowEdit = False
        Me.colCode.OptionsColumn.ReadOnly = True
        Me.colCode.OptionsFilter.AllowAutoFilter = False
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 1
        Me.colCode.Width = 86
        '
        'colLibelle
        '
        Me.colLibelle.Caption = "Libellé"
        Me.colLibelle.FieldName = "libelle"
        Me.colLibelle.Name = "colLibelle"
        Me.colLibelle.OptionsColumn.AllowEdit = False
        Me.colLibelle.OptionsColumn.ReadOnly = True
        Me.colLibelle.OptionsFilter.AllowAutoFilter = False
        Me.colLibelle.Visible = True
        Me.colLibelle.VisibleIndex = 2
        Me.colLibelle.Width = 348
        '
        'colNum
        '
        Me.colNum.Caption = "Num"
        Me.colNum.FieldName = "num"
        Me.colNum.Name = "colNum"
        '
        'colVal1
        '
        Me.colVal1.Caption = "Val1"
        Me.colVal1.FieldName = "val1"
        Me.colVal1.Name = "colVal1"
        '
        'colVal2
        '
        Me.colVal2.Caption = "Val2"
        Me.colVal2.FieldName = "val2"
        Me.colVal2.Name = "colVal2"
        '
        'colVal3
        '
        Me.colVal3.Caption = "Val3"
        Me.colVal3.FieldName = "val3"
        Me.colVal3.Name = "colVal3"
        '
        'colchkFixe
        '
        Me.colchkFixe.Caption = "chkFixe"
        Me.colchkFixe.ColumnEdit = Me.rpCheck2
        Me.colchkFixe.FieldName = "chkFixe"
        Me.colchkFixe.Name = "colchkFixe"
        Me.colchkFixe.OptionsColumn.AllowFocus = False
        '
        'rpCheck2
        '
        Me.rpCheck2.AutoHeight = False
        Me.rpCheck2.Name = "rpCheck2"
        Me.rpCheck2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.rpCheck2.ValueChecked = 1
        Me.rpCheck2.ValueUnchecked = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btNone)
        Me.Panel1.Controls.Add(Me.btPasser)
        Me.Panel1.Controls.Add(Me.btAnnuler)
        Me.Panel1.Controls.Add(Me.btTout)
        Me.Panel1.Controls.Add(Me.btOk)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 377)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(497, 42)
        Me.Panel1.TabIndex = 3
        '
        'btNone
        '
        Me.btNone.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btNone.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNone.Appearance.Options.UseBackColor = True
        Me.btNone.Appearance.Options.UseFont = True
        Me.btNone.Location = New System.Drawing.Point(4, 23)
        Me.btNone.Name = "btNone"
        Me.btNone.Size = New System.Drawing.Size(56, 18)
        Me.btNone.TabIndex = 3
        Me.btNone.Text = "Au&cun"
        '
        'btPasser
        '
        Me.btPasser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btPasser.Location = New System.Drawing.Point(318, 3)
        Me.btPasser.Name = "btPasser"
        Me.btPasser.Size = New System.Drawing.Size(87, 36)
        Me.btPasser.TabIndex = 2
        Me.btPasser.Text = "&Ignorer"
        Me.btPasser.ToolTip = "Passer à l'étape suivante de la déclinaison sans tenir compte de ce critère"
        '
        'btAnnuler
        '
        Me.btAnnuler.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btAnnuler.Location = New System.Drawing.Point(407, 3)
        Me.btAnnuler.Name = "btAnnuler"
        Me.btAnnuler.Size = New System.Drawing.Size(87, 36)
        Me.btAnnuler.TabIndex = 1
        Me.btAnnuler.Text = "&Annuler"
        Me.btAnnuler.ToolTip = "Annuler la déclinaison"
        '
        'btTout
        '
        Me.btTout.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btTout.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btTout.Appearance.Options.UseBackColor = True
        Me.btTout.Appearance.Options.UseBorderColor = True
        Me.btTout.Appearance.Options.UseFont = True
        Me.btTout.Appearance.Options.UseForeColor = True
        Me.btTout.Appearance.Options.UseImage = True
        Me.btTout.Appearance.Options.UseTextOptions = True
        Me.btTout.Location = New System.Drawing.Point(4, 4)
        Me.btTout.Name = "btTout"
        Me.btTout.Size = New System.Drawing.Size(56, 18)
        Me.btTout.TabIndex = 1
        Me.btTout.Text = "&Tout"
        '
        'btOk
        '
        Me.btOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btOk.Location = New System.Drawing.Point(229, 3)
        Me.btOk.Name = "btOk"
        Me.btOk.Size = New System.Drawing.Size(87, 36)
        Me.btOk.TabIndex = 1
        Me.btOk.Text = "&Ok"
        '
        'PanTop
        '
        Me.PanTop.Controls.Add(Me.labTitre)
        Me.PanTop.Controls.Add(Me.txtSearch)
        Me.PanTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanTop.Location = New System.Drawing.Point(0, 0)
        Me.PanTop.Name = "PanTop"
        Me.PanTop.Size = New System.Drawing.Size(497, 64)
        Me.PanTop.TabIndex = 2
        '
        'labTitre
        '
        Me.labTitre.BackColor = System.Drawing.Color.DarkRed
        Me.labTitre.Dock = System.Windows.Forms.DockStyle.Top
        Me.labTitre.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTitre.ForeColor = System.Drawing.SystemColors.Window
        Me.labTitre.Location = New System.Drawing.Point(0, 0)
        Me.labTitre.Name = "labTitre"
        Me.labTitre.Size = New System.Drawing.Size(497, 25)
        Me.labTitre.TabIndex = 2
        Me.labTitre.Text = "Titre de la fiche"
        Me.labTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(3, 34)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Properties.Appearance.Options.UseFont = True
        Me.txtSearch.Size = New System.Drawing.Size(491, 24)
        Me.txtSearch.TabIndex = 0
        '
        'Frm_Dictionnaire_Declinaison
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(497, 483)
        Me.Controls.Add(Me.PanMain)
        Me.Controls.Add(Me.PanTop)
        Me.Name = "Frm_Dictionnaire_Declinaison"
        Me.ShowInTaskbar = False
        Me.Text = "Déclinaison"
        Me.PanMain.ResumeLayout(False)
        CType(Me.gcPredictive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPredictive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpCheck2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.PanTop.ResumeLayout(False)
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Protected Friend WithEvents PanMain As System.Windows.Forms.Panel
    Protected Friend WithEvents gcPredictive As DevExpress.XtraGrid.GridControl
    Protected Friend WithEvents gvPredictive As DevExpress.XtraGrid.Views.Grid.GridView
    Protected Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Protected Friend WithEvents colLibelle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVal1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVal2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVal3 As DevExpress.XtraGrid.Columns.GridColumn
    Protected Friend WithEvents btOk As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents PanTop As System.Windows.Forms.Panel
    Protected Friend WithEvents txtSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rpCheck As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Protected Friend WithEvents labTitre As System.Windows.Forms.Label
    Protected Friend WithEvents colcheck As DevExpress.XtraGrid.Columns.GridColumn
    Protected Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Protected Friend WithEvents btAnnuler As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colchkFixe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpCheck2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colDisable As DevExpress.XtraGrid.Columns.GridColumn
    Protected Friend WithEvents btPasser As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btNone As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btTout As DevExpress.XtraEditors.SimpleButton

End Class
