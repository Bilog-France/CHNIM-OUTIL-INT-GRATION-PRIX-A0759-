<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SubstanceActivPere
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
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSAC_CODE_SQ_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAC_CDF_ORN_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAC_SAU_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAC_GSAC_CODE_FK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAC_NOM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpSac = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSAC_NOMA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAC_DATECR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAC_DATEMJ = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAC_ETAT_COMMER = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAC_DATECOMMER = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DsTheriaque_Nomenclature2 = New Theriaque.dsTheriaque_Nomenclature2
        Me.txtLibelle = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.GsaC_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.GSAC_PERE_SUBACTTableAdapter
        Me.SaC_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.SAC_SUBACTIVETableAdapter
        Me.SaC_SUBACTIVETableAdapter1 = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.SAC_SUBACTIVETableAdapter
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpSac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_Nomenclature2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanMain.Location = New System.Drawing.Point(0, 58)
        Me.PanMain.Size = New System.Drawing.Size(579, 413)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(697, 58)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(697, 28)
        Me.Label1.Text = "Substance active Père"
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
        Me.Panel1.Location = New System.Drawing.Point(579, 58)
        Me.Panel1.Size = New System.Drawing.Size(118, 413)
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(377, 32)
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit1.Visible = False
        '
        'GroupBox
        '
        Me.GroupBox.Location = New System.Drawing.Point(0, 50)
        Me.GroupBox.Size = New System.Drawing.Size(697, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(92, 31)
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit2.Visible = False
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(10, 75)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(563, 335)
        Me.XtraTabControl1.TabIndex = 31
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
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpSac})
        Me.GC.Size = New System.Drawing.Size(554, 304)
        Me.GC.TabIndex = 0
        Me.GC.Tag = "[EDIT][ADD]"
        Me.GC.UseEmbeddedNavigator = True
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSAC_CODE_SQ_PK, Me.colSAC_CDF_ORN_CODE_FK, Me.colSAC_SAU_CODE_FK, Me.colSAC_GSAC_CODE_FK, Me.colSAC_NOM, Me.colSAC_NOMA, Me.colSAC_DATECR, Me.colSAC_DATEMJ, Me.colSAC_ETAT_COMMER, Me.colSAC_DATECOMMER})
        Me.GV.GridControl = Me.GC
        Me.GV.GroupPanelText = " "
        Me.GV.Name = "GV"
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'colSAC_CODE_SQ_PK
        '
        Me.colSAC_CODE_SQ_PK.Caption = "Code"
        Me.colSAC_CODE_SQ_PK.FieldName = "SAC_CODE_SQ_PK"
        Me.colSAC_CODE_SQ_PK.Name = "colSAC_CODE_SQ_PK"
        Me.colSAC_CODE_SQ_PK.Visible = True
        Me.colSAC_CODE_SQ_PK.VisibleIndex = 0
        Me.colSAC_CODE_SQ_PK.Width = 88
        '
        'colSAC_CDF_ORN_CODE_FK
        '
        Me.colSAC_CDF_ORN_CODE_FK.Caption = "SAC_CDF_ORN_CODE_FK"
        Me.colSAC_CDF_ORN_CODE_FK.FieldName = "SAC_CDF_ORN_CODE_FK"
        Me.colSAC_CDF_ORN_CODE_FK.Name = "colSAC_CDF_ORN_CODE_FK"
        '
        'colSAC_SAU_CODE_FK
        '
        Me.colSAC_SAU_CODE_FK.Caption = "SAC_SAU_CODE_FK"
        Me.colSAC_SAU_CODE_FK.FieldName = "SAC_SAU_CODE_FK"
        Me.colSAC_SAU_CODE_FK.Name = "colSAC_SAU_CODE_FK"
        '
        'colSAC_GSAC_CODE_FK
        '
        Me.colSAC_GSAC_CODE_FK.Caption = "SAC_GSAC_CODE_FK"
        Me.colSAC_GSAC_CODE_FK.FieldName = "SAC_GSAC_CODE_FK"
        Me.colSAC_GSAC_CODE_FK.Name = "colSAC_GSAC_CODE_FK"
        '
        'colSAC_NOM
        '
        Me.colSAC_NOM.Caption = "Libellé"
        Me.colSAC_NOM.ColumnEdit = Me.rpSac
        Me.colSAC_NOM.FieldName = "SAC_CODE_SQ_PK"
        Me.colSAC_NOM.Name = "colSAC_NOM"
        Me.colSAC_NOM.Visible = True
        Me.colSAC_NOM.VisibleIndex = 1
        Me.colSAC_NOM.Width = 445
        '
        'rpSac
        '
        Me.rpSac.AutoHeight = False
        Me.rpSac.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpSac.Name = "rpSac"
        '
        'colSAC_NOMA
        '
        Me.colSAC_NOMA.Caption = "SAC_NOMA"
        Me.colSAC_NOMA.FieldName = "SAC_NOMA"
        Me.colSAC_NOMA.Name = "colSAC_NOMA"
        '
        'colSAC_DATECR
        '
        Me.colSAC_DATECR.Caption = "SAC_DATECR"
        Me.colSAC_DATECR.FieldName = "SAC_DATECR"
        Me.colSAC_DATECR.Name = "colSAC_DATECR"
        '
        'colSAC_DATEMJ
        '
        Me.colSAC_DATEMJ.Caption = "SAC_DATEMJ"
        Me.colSAC_DATEMJ.FieldName = "SAC_DATEMJ"
        Me.colSAC_DATEMJ.Name = "colSAC_DATEMJ"
        '
        'colSAC_ETAT_COMMER
        '
        Me.colSAC_ETAT_COMMER.Caption = "SAC_ETAT_COMMER"
        Me.colSAC_ETAT_COMMER.FieldName = "SAC_ETAT_COMMER"
        Me.colSAC_ETAT_COMMER.Name = "colSAC_ETAT_COMMER"
        '
        'colSAC_DATECOMMER
        '
        Me.colSAC_DATECOMMER.Caption = "SAC_DATECOMMER"
        Me.colSAC_DATECOMMER.FieldName = "SAC_DATECOMMER"
        Me.colSAC_DATECOMMER.Name = "colSAC_DATECOMMER"
        '
        'DsTheriaque_Nomenclature2
        '
        Me.DsTheriaque_Nomenclature2.DataSetName = "dsTheriaque_Nomenclature2"
        Me.DsTheriaque_Nomenclature2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtLibelle
        '
        Me.txtLibelle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLibelle.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "GSAC_PERE_SUBACT.GSAC_NOM", True))
        Me.txtLibelle.Location = New System.Drawing.Point(92, 36)
        Me.txtLibelle.Name = "txtLibelle"
        Me.txtLibelle.Size = New System.Drawing.Size(461, 20)
        Me.txtLibelle.TabIndex = 25
        Me.txtLibelle.Tag = "[EDIT][ADD]"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Libellé"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Nomenclature2, "GSAC_PERE_SUBACT.GSAC_CODE_SQ_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(92, 10)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 24
        Me.txtCode.Tag = "[NOEDIT][NOADD]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Code"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GsaC_TA
        '
        Me.GsaC_TA.ClearBeforeFill = True
        '
        'SaC_TA
        '
        Me.SaC_TA.ClearBeforeFill = True
        '
        'SaC_SUBACTIVETableAdapter1
        '
        Me.SaC_SUBACTIVETableAdapter1.ClearBeforeFill = True
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(370, 2)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit2.TabIndex = 2
        '
        'Frm_SubstanceActivPere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(697, 471)
        Me.Name = "Frm_SubstanceActivPere"
        Me.Text = "Substance active Père"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanMain.PerformLayout()
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpSac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_Nomenclature2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtLibelle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DsTheriaque_Nomenclature2 As Theriaque.dsTheriaque_Nomenclature2
    Friend WithEvents GsaC_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.GSAC_PERE_SUBACTTableAdapter
    Friend WithEvents SaC_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.SAC_SUBACTIVETableAdapter
    Friend WithEvents colSAC_CODE_SQ_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAC_CDF_ORN_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAC_SAU_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAC_GSAC_CODE_FK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAC_NOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAC_NOMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAC_DATECR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAC_DATEMJ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAC_ETAT_COMMER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAC_DATECOMMER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaC_SUBACTIVETableAdapter1 As Theriaque.dsTheriaque_Nomenclature2TableAdapters.SAC_SUBACTIVETableAdapter
    Friend WithEvents rpSac As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit

End Class
