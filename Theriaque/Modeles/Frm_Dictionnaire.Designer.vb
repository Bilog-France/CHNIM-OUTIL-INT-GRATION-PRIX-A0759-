<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Dictionnaire
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
        Me.components = New System.ComponentModel.Container
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.colDisable = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanTop = New System.Windows.Forms.Panel
        Me.btOk = New DevExpress.XtraEditors.SimpleButton
        Me.txtSearch = New DevExpress.XtraEditors.TextEdit
        Me.PanMain = New System.Windows.Forms.Panel
        Me.gcPredictive = New DevExpress.XtraGrid.GridControl
        Me.gvPredictive = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLibelle = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNum = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVal1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVal2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVal3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcache = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVal4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.PanTop.SuspendLayout()
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanMain.SuspendLayout()
        CType(Me.gcPredictive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPredictive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colDisable
        '
        Me.colDisable.Caption = "Désactivation"
        Me.colDisable.FieldName = "disable"
        Me.colDisable.Name = "colDisable"
        '
        'PanTop
        '
        Me.PanTop.Controls.Add(Me.btOk)
        Me.PanTop.Controls.Add(Me.txtSearch)
        Me.PanTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanTop.Location = New System.Drawing.Point(0, 0)
        Me.PanTop.Name = "PanTop"
        Me.PanTop.Size = New System.Drawing.Size(489, 50)
        Me.PanTop.TabIndex = 0
        '
        'btOk
        '
        Me.btOk.Location = New System.Drawing.Point(429, 11)
        Me.btOk.Name = "btOk"
        Me.btOk.Size = New System.Drawing.Size(58, 24)
        Me.btOk.TabIndex = 1
        Me.btOk.Text = "&Ok"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(3, 11)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Properties.Appearance.Options.UseFont = True
        Me.txtSearch.Size = New System.Drawing.Size(426, 24)
        Me.txtSearch.TabIndex = 0
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.gcPredictive)
        Me.PanMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMain.Location = New System.Drawing.Point(0, 50)
        Me.PanMain.Name = "PanMain"
        Me.PanMain.Size = New System.Drawing.Size(489, 400)
        Me.PanMain.TabIndex = 1
        '
        'gcPredictive
        '
        Me.gcPredictive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPredictive.EmbeddedNavigator.Buttons.Append.Enabled = False
        Me.gcPredictive.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gcPredictive.EmbeddedNavigator.Buttons.CancelEdit.Enabled = False
        Me.gcPredictive.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcPredictive.EmbeddedNavigator.Buttons.Edit.Enabled = False
        Me.gcPredictive.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcPredictive.EmbeddedNavigator.Buttons.EndEdit.Enabled = False
        Me.gcPredictive.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gcPredictive.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.gcPredictive.EmbeddedNavigator.Name = ""
        Me.gcPredictive.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.gcPredictive.Location = New System.Drawing.Point(0, 0)
        Me.gcPredictive.MainView = Me.gvPredictive
        Me.gcPredictive.Name = "gcPredictive"
        Me.gcPredictive.Size = New System.Drawing.Size(489, 400)
        Me.gcPredictive.TabIndex = 0
        Me.gcPredictive.UseEmbeddedNavigator = True
        Me.gcPredictive.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPredictive})
        '
        'gvPredictive
        '
        Me.gvPredictive.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCode, Me.colLibelle, Me.colNum, Me.colVal1, Me.colVal2, Me.colVal3, Me.colDisable, Me.colcache, Me.colVal4})
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colDisable
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "1"
        Me.gvPredictive.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
        Me.gvPredictive.GridControl = Me.gcPredictive
        Me.gvPredictive.GroupPanelText = " "
        Me.gvPredictive.Name = "gvPredictive"
        Me.gvPredictive.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvPredictive.OptionsBehavior.Editable = False
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
        Me.colCode.VisibleIndex = 0
        Me.colCode.Width = 51
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
        Me.colLibelle.VisibleIndex = 1
        Me.colLibelle.Width = 177
        '
        'colNum
        '
        Me.colNum.Caption = "Num"
        Me.colNum.FieldName = "num"
        Me.colNum.Name = "colNum"
        '
        'colVal1
        '
        Me.colVal1.Caption = "Valeur 1"
        Me.colVal1.FieldName = "val1"
        Me.colVal1.Name = "colVal1"
        Me.colVal1.Width = 81
        '
        'colVal2
        '
        Me.colVal2.Caption = "Valeur 2"
        Me.colVal2.FieldName = "val2"
        Me.colVal2.Name = "colVal2"
        Me.colVal2.Width = 50
        '
        'colVal3
        '
        Me.colVal3.Caption = "Valeur 3"
        Me.colVal3.FieldName = "val3"
        Me.colVal3.Name = "colVal3"
        Me.colVal3.Width = 55
        '
        'colcache
        '
        Me.colcache.Name = "colcache"
        Me.colcache.OptionsColumn.ShowInCustomizationForm = False
        '
        'colVal4
        '
        Me.colVal4.Caption = "Valeur 4"
        Me.colVal4.FieldName = "val4"
        Me.colVal4.Name = "colVal4"
        Me.colVal4.Width = 54
        '
        'Timer
        '
        Me.Timer.Interval = 500
        '
        'Frm_Dictionnaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(489, 450)
        Me.Controls.Add(Me.PanMain)
        Me.Controls.Add(Me.PanTop)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Dictionnaire"
        Me.ShowIcon = False
        Me.Text = "Dictionnaire"
        Me.PanTop.ResumeLayout(False)
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanMain.ResumeLayout(False)
        CType(Me.gcPredictive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPredictive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Protected Friend WithEvents PanTop As System.Windows.Forms.Panel
    Protected Friend WithEvents PanMain As System.Windows.Forms.Panel
    Protected Friend WithEvents gcPredictive As DevExpress.XtraGrid.GridControl
    Protected Friend WithEvents gvPredictive As DevExpress.XtraGrid.Views.Grid.GridView
    Protected Friend WithEvents btOk As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents txtSearch As DevExpress.XtraEditors.TextEdit
    Protected Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Protected Friend WithEvents colLibelle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVal1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVal2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVal3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDisable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents colcache As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVal4 As DevExpress.XtraGrid.Columns.GridColumn

End Class
