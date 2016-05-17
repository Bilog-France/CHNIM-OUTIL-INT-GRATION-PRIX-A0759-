<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_References_offc
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.colaction = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSynonyme = New DevExpress.XtraEditors.TextEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtLibelle = New DevExpress.XtraEditors.TextEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSPAFS_RUBCDF_NUMERO_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpRUB = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSPAFS_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPAFS_DATE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSPAFS_CDF_CODE_DOC_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpRef = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSPAFS_DATE_REVIS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DsTheriaque_Ref1 = New Theriaque.dsTheriaque_Ref
        Me.SpafS_TA = New Theriaque.dsTheriaque_RefTableAdapters.SPAFS_SPECIALITE_AFSSAPSTableAdapter
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker
        Me.ProgressBar = New System.Windows.Forms.ProgressBar
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSynonyme.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpRUB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpRef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_Ref1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(859, 540)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.ProgressBar)
        Me.PanMain.Controls.Add(Me.Panel3)
        Me.PanMain.Controls.Add(Me.Panel2)
        Me.PanMain.Size = New System.Drawing.Size(741, 453)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(859, 87)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(859, 28)
        Me.Label1.Text = "Références officielles"
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
        Me.Panel1.Location = New System.Drawing.Point(741, 87)
        Me.Panel1.Size = New System.Drawing.Size(118, 453)
        '
        'btAjouter
        '
        Me.btAjouter.Enabled = False
        '
        'btSupprimer
        '
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Size = New System.Drawing.Size(859, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        '
        'colaction
        '
        Me.colaction.Caption = "Action"
        Me.colaction.FieldName = "action1"
        Me.colaction.Name = "colaction"
        Me.colaction.Visible = True
        Me.colaction.VisibleIndex = 3
        Me.colaction.Width = 78
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Libellé"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(443, 6)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Size = New System.Drawing.Size(69, 20)
        Me.txtCode.TabIndex = 14
        Me.txtCode.Tag = "[NOEDIT][NOADD]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Synonyme"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSynonyme
        '
        Me.txtSynonyme.Location = New System.Drawing.Point(92, 32)
        Me.txtSynonyme.Name = "txtSynonyme"
        Me.txtSynonyme.Size = New System.Drawing.Size(420, 20)
        Me.txtSynonyme.TabIndex = 15
        Me.txtSynonyme.Tag = "[NOEDIT][NOADD]"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtSynonyme)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtLibelle)
        Me.Panel2.Controls.Add(Me.txtCode)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(741, 60)
        Me.Panel2.TabIndex = 18
        '
        'txtLibelle
        '
        Me.txtLibelle.Location = New System.Drawing.Point(92, 6)
        Me.txtLibelle.Name = "txtLibelle"
        Me.txtLibelle.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLibelle.Size = New System.Drawing.Size(345, 20)
        Me.txtLibelle.TabIndex = 14
        Me.txtLibelle.Tag = "[NOEDIT][NOADD]"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(741, 393)
        Me.Panel3.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GC)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(741, 393)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.GC.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GC.EmbeddedNavigator.CustomButtons.AddRange(New DevExpress.XtraEditors.NavigatorCustomButton() {New DevExpress.XtraEditors.NavigatorCustomButton(-1, 7, True, True, "", "SUPP")})
        Me.GC.EmbeddedNavigator.Name = ""
        Me.GC.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC.Location = New System.Drawing.Point(5, 18)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpRef, Me.rpRUB})
        Me.GC.Size = New System.Drawing.Size(731, 370)
        Me.GC.TabIndex = 1
        Me.GC.UseEmbeddedNavigator = True
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSPAFS_RUBCDF_NUMERO_PK, Me.colSPAFS_SP_CODE_FK_PK, Me.colSPAFS_DATE_PK, Me.colSPAFS_CDF_CODE_DOC_FK_PK, Me.colSPAFS_DATE_REVIS, Me.colaction})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colaction
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "Consultation"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colaction
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "Ajout"
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.colaction
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = "Suppression"
        Me.GV.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3})
        Me.GV.GridControl = Me.GC
        Me.GV.GroupPanelText = " "
        Me.GV.Name = "GV"
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'colSPAFS_RUBCDF_NUMERO_PK
        '
        Me.colSPAFS_RUBCDF_NUMERO_PK.Caption = "Rubrique"
        Me.colSPAFS_RUBCDF_NUMERO_PK.ColumnEdit = Me.rpRUB
        Me.colSPAFS_RUBCDF_NUMERO_PK.FieldName = "rub"
        Me.colSPAFS_RUBCDF_NUMERO_PK.Name = "colSPAFS_RUBCDF_NUMERO_PK"
        Me.colSPAFS_RUBCDF_NUMERO_PK.Visible = True
        Me.colSPAFS_RUBCDF_NUMERO_PK.VisibleIndex = 2
        Me.colSPAFS_RUBCDF_NUMERO_PK.Width = 213
        '
        'rpRUB
        '
        Me.rpRUB.AutoHeight = False
        Me.rpRUB.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpRUB.Name = "rpRUB"
        '
        'colSPAFS_SP_CODE_FK_PK
        '
        Me.colSPAFS_SP_CODE_FK_PK.Caption = "SPAFS_SP_CODE_FK_PK"
        Me.colSPAFS_SP_CODE_FK_PK.FieldName = "SPAFS_SP_CODE_FK_PK"
        Me.colSPAFS_SP_CODE_FK_PK.Name = "colSPAFS_SP_CODE_FK_PK"
        Me.colSPAFS_SP_CODE_FK_PK.Width = 86
        '
        'colSPAFS_DATE_PK
        '
        Me.colSPAFS_DATE_PK.Caption = "Date"
        Me.colSPAFS_DATE_PK.FieldName = "date"
        Me.colSPAFS_DATE_PK.Name = "colSPAFS_DATE_PK"
        Me.colSPAFS_DATE_PK.Visible = True
        Me.colSPAFS_DATE_PK.VisibleIndex = 1
        Me.colSPAFS_DATE_PK.Width = 79
        '
        'colSPAFS_CDF_CODE_DOC_FK_PK
        '
        Me.colSPAFS_CDF_CODE_DOC_FK_PK.Caption = "Références officielles"
        Me.colSPAFS_CDF_CODE_DOC_FK_PK.ColumnEdit = Me.rpRef
        Me.colSPAFS_CDF_CODE_DOC_FK_PK.FieldName = "doc"
        Me.colSPAFS_CDF_CODE_DOC_FK_PK.Name = "colSPAFS_CDF_CODE_DOC_FK_PK"
        Me.colSPAFS_CDF_CODE_DOC_FK_PK.Visible = True
        Me.colSPAFS_CDF_CODE_DOC_FK_PK.VisibleIndex = 0
        Me.colSPAFS_CDF_CODE_DOC_FK_PK.Width = 247
        '
        'rpRef
        '
        Me.rpRef.AutoHeight = False
        Me.rpRef.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpRef.Name = "rpRef"
        '
        'colSPAFS_DATE_REVIS
        '
        Me.colSPAFS_DATE_REVIS.Caption = "Date de révision"
        Me.colSPAFS_DATE_REVIS.FieldName = "date_revis"
        Me.colSPAFS_DATE_REVIS.Name = "colSPAFS_DATE_REVIS"
        Me.colSPAFS_DATE_REVIS.Visible = True
        Me.colSPAFS_DATE_REVIS.VisibleIndex = 4
        Me.colSPAFS_DATE_REVIS.Width = 93
        '
        'DsTheriaque_Ref1
        '
        Me.DsTheriaque_Ref1.DataSetName = "dsTheriaque_Ref"
        Me.DsTheriaque_Ref1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpafS_TA
        '
        Me.SpafS_TA.ClearBeforeFill = True
        '
        'BackgroundWorker
        '
        Me.BackgroundWorker.WorkerReportsProgress = True
        Me.BackgroundWorker.WorkerSupportsCancellation = True
        '
        'ProgressBar
        '
        Me.ProgressBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressBar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.ProgressBar.Location = New System.Drawing.Point(0, 60)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(741, 15)
        Me.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar.TabIndex = 8
        Me.ProgressBar.Visible = False
        '
        'Frm_References_offc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(859, 540)
        Me.Name = "Frm_References_offc"
        Me.Text = "Références officielles"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSynonyme.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpRUB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpRef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_Ref1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtSynonyme As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSPAFS_RUBCDF_NUMERO_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPAFS_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPAFS_DATE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPAFS_CDF_CODE_DOC_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPAFS_DATE_REVIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpRef As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DsTheriaque_Ref1 As Theriaque.dsTheriaque_Ref
    Friend WithEvents SpafS_TA As Theriaque.dsTheriaque_RefTableAdapters.SPAFS_SPECIALITE_AFSSAPSTableAdapter
    Friend WithEvents txtLibelle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rpRUB As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colaction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar

End Class
