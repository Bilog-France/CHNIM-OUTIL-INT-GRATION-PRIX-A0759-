<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ExcipientPere
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
        Me.txtLibelle = New DevExpress.XtraEditors.TextEdit
        Me.DsTheriaque_Excipient = New Theriaque.dsTheriaque_Excipient
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSAU_CODE_SQ_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAU_CDF_ORN_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAU_SAC_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAU_GSAU_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAU_NOM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpSau = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSAU_NOMA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAU_DATECR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAU_DATEMJ = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAU_ETAT_COMMER = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAU_DATECOMMER = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GSAU_TA = New Theriaque.dsTheriaque_ExcipientTableAdapters.GSAU_PERE_SUBAUXTableAdapter
        Me.SaU_TA = New Theriaque.dsTheriaque_ExcipientTableAdapters.SAU_SUBAUXILIAIRETableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_Excipient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpSau, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(697, 471)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.XtraTabControl1)
        Me.PanMain.Controls.Add(Me.txtLibelle)
        Me.PanMain.Controls.Add(Me.Label6)
        Me.PanMain.Controls.Add(Me.txtCode)
        Me.PanMain.Controls.Add(Me.Label3)
        Me.PanMain.Location = New System.Drawing.Point(0, 59)
        Me.PanMain.Size = New System.Drawing.Size(579, 412)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(697, 59)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(697, 28)
        Me.Label1.Text = "Excipient - Père"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(305, 33)
        Me.LabelControl2.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(35, 33)
        Me.LabelControl1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(579, 59)
        Me.Panel1.Size = New System.Drawing.Size(118, 412)
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(377, 33)
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit1.Visible = False
        '
        'GroupBox
        '
        Me.GroupBox.Location = New System.Drawing.Point(0, 49)
        Me.GroupBox.Size = New System.Drawing.Size(697, 10)
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(92, 33)
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit2.Visible = False
        '
        'txtLibelle
        '
        Me.txtLibelle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLibelle.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Excipient, "GSAU_PERE_SUBAUX.GSAU_NOM", True))
        Me.txtLibelle.Location = New System.Drawing.Point(92, 35)
        Me.txtLibelle.Name = "txtLibelle"
        Me.txtLibelle.Size = New System.Drawing.Size(461, 20)
        Me.txtLibelle.TabIndex = 29
        Me.txtLibelle.Tag = "[EDIT][ADD]"
        '
        'DsTheriaque_Excipient
        '
        Me.DsTheriaque_Excipient.DataSetName = "dsTheriaque_Excipient"
        Me.DsTheriaque_Excipient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Libellé"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Excipient, "GSAU_PERE_SUBAUX.GSAU_CODE_SQ_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(92, 9)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 28
        Me.txtCode.Tag = "[NOEDIT][NOADD]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Code"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(10, 74)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(563, 335)
        Me.XtraTabControl1.TabIndex = 32
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        Me.XtraTabControl1.Tag = ""
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GC)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(554, 304)
        Me.XtraTabPage1.Tag = "[EDIT][ADD]"
        Me.XtraTabPage1.Text = "Fils"
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
        Me.GC.EmbeddedNavigator.Name = ""
        Me.GC.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC.Location = New System.Drawing.Point(0, 0)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpSau})
        Me.GC.Size = New System.Drawing.Size(554, 304)
        Me.GC.TabIndex = 0
        Me.GC.Tag = "[EDIT][ADD]"
        Me.GC.UseEmbeddedNavigator = True
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSAU_CODE_SQ_PK, Me.colSAU_CDF_ORN_CODE_FK, Me.colSAU_SAC_CODE_FK, Me.colSAU_GSAU_CODE_FK, Me.colSAU_NOM, Me.colSAU_NOMA, Me.colSAU_DATECR, Me.colSAU_DATEMJ, Me.colSAU_ETAT_COMMER, Me.colSAU_DATECOMMER})
        Me.GV.GridControl = Me.GC
        Me.GV.GroupPanelText = " "
        Me.GV.Name = "GV"
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'colSAU_CODE_SQ_PK
        '
        Me.colSAU_CODE_SQ_PK.Caption = "Code"
        Me.colSAU_CODE_SQ_PK.FieldName = "SAU_CODE_SQ_PK"
        Me.colSAU_CODE_SQ_PK.Name = "colSAU_CODE_SQ_PK"
        Me.colSAU_CODE_SQ_PK.Visible = True
        Me.colSAU_CODE_SQ_PK.VisibleIndex = 0
        Me.colSAU_CODE_SQ_PK.Width = 88
        '
        'colSAU_CDF_ORN_CODE_FK
        '
        Me.colSAU_CDF_ORN_CODE_FK.Caption = "SAU_CDF_ORN_CODE_FK"
        Me.colSAU_CDF_ORN_CODE_FK.FieldName = "SAU_CDF_ORN_CODE_FK"
        Me.colSAU_CDF_ORN_CODE_FK.Name = "colSAU_CDF_ORN_CODE_FK"
        '
        'colSAU_SAC_CODE_FK
        '
        Me.colSAU_SAC_CODE_FK.Caption = "SAU_SAC_CODE_FK"
        Me.colSAU_SAC_CODE_FK.FieldName = "SAU_SAC_CODE_FK"
        Me.colSAU_SAC_CODE_FK.Name = "colSAU_SAC_CODE_FK"
        '
        'colSAU_GSAU_CODE_FK
        '
        Me.colSAU_GSAU_CODE_FK.Caption = "SAU_GSAU_CODE_FK"
        Me.colSAU_GSAU_CODE_FK.FieldName = "SAU_GSAU_CODE_FK"
        Me.colSAU_GSAU_CODE_FK.Name = "colSAU_GSAU_CODE_FK"
        '
        'colSAU_NOM
        '
        Me.colSAU_NOM.Caption = "Libellé"
        Me.colSAU_NOM.ColumnEdit = Me.rpSau
        Me.colSAU_NOM.FieldName = "SAU_CODE_SQ_PK"
        Me.colSAU_NOM.Name = "colSAU_NOM"
        Me.colSAU_NOM.Visible = True
        Me.colSAU_NOM.VisibleIndex = 1
        Me.colSAU_NOM.Width = 445
        '
        'rpSau
        '
        Me.rpSau.AutoHeight = False
        Me.rpSau.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpSau.Name = "rpSau"
        '
        'colSAU_NOMA
        '
        Me.colSAU_NOMA.Caption = "SAU_NOMA"
        Me.colSAU_NOMA.FieldName = "SAU_NOMA"
        Me.colSAU_NOMA.Name = "colSAU_NOMA"
        '
        'colSAU_DATECR
        '
        Me.colSAU_DATECR.Caption = "SAU_DATECR"
        Me.colSAU_DATECR.FieldName = "SAU_DATECR"
        Me.colSAU_DATECR.Name = "colSAU_DATECR"
        '
        'colSAU_DATEMJ
        '
        Me.colSAU_DATEMJ.Caption = "SAU_DATEMJ"
        Me.colSAU_DATEMJ.FieldName = "SAU_DATEMJ"
        Me.colSAU_DATEMJ.Name = "colSAU_DATEMJ"
        '
        'colSAU_ETAT_COMMER
        '
        Me.colSAU_ETAT_COMMER.Caption = "SAU_ETAT_COMMER"
        Me.colSAU_ETAT_COMMER.FieldName = "SAU_ETAT_COMMER"
        Me.colSAU_ETAT_COMMER.Name = "colSAU_ETAT_COMMER"
        '
        'colSAU_DATECOMMER
        '
        Me.colSAU_DATECOMMER.Caption = "SAU_DATECOMMER"
        Me.colSAU_DATECOMMER.FieldName = "SAU_DATECOMMER"
        Me.colSAU_DATECOMMER.Name = "colSAU_DATECOMMER"
        '
        'GSAU_TA
        '
        Me.GSAU_TA.ClearBeforeFill = True
        '
        'SaU_TA
        '
        Me.SaU_TA.ClearBeforeFill = True
        '
        'Frm_ExcipientPere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(697, 471)
        Me.Name = "Frm_ExcipientPere"
        Me.Text = "Excipient - Père"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanMain.PerformLayout()
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_Excipient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpSau, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtLibelle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSAU_CODE_SQ_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAU_CDF_ORN_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAU_SAC_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAU_GSAU_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAU_NOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpSau As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colSAU_NOMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAU_DATECR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAU_DATEMJ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAU_ETAT_COMMER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAU_DATECOMMER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DsTheriaque_Excipient As Theriaque.dsTheriaque_Excipient
    Friend WithEvents GSAU_TA As Theriaque.dsTheriaque_ExcipientTableAdapters.GSAU_PERE_SUBAUXTableAdapter
    Friend WithEvents SaU_TA As Theriaque.dsTheriaque_ExcipientTableAdapters.SAU_SUBAUXILIAIRETableAdapter

End Class
