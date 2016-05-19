<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Presentation_Prix
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GC2 = New DevExpress.XtraGrid.GridControl
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFORPRE_PRE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFORPRE_DATE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFORPRE_FORFAIT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFORPRE_Valide = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpForfait = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.chkForPreValid = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GC1 = New DevExpress.XtraGrid.GridControl
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPRIPRE_DATE_APPLI_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRIPRE_PRE_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRIPRE_PRIX = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRIPRE_PRIX_EURO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRIPRE_Valide = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpPrix = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ForprE_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.FORPRE_FORFAIT_PRETableAdapter
        Me.PriprE_TA = New Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRIPRE_PRIX_PRESENTATIONTableAdapter
        Me.GroupBox1.SuspendLayout()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpForfait, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkForPreValid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpPrix, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GC2)
        Me.GroupBox1.Controls.Add(Me.GC1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(580, 432)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GC2
        '
        Me.GC2.DataMember = "FORPRE_FORFAIT_PRE"
        Me.GC2.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC2.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC2.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC2.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC2.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC2.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC2.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC2.EmbeddedNavigator.Name = ""
        Me.GC2.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC2.Location = New System.Drawing.Point(6, 217)
        Me.GC2.MainView = Me.GV2
        Me.GC2.Name = "GC2"
        Me.GC2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpForfait, Me.chkForPreValid, Me.RepositoryItemCheckEdit1})
        Me.GC2.Size = New System.Drawing.Size(568, 209)
        Me.GC2.TabIndex = 17
        Me.GC2.UseEmbeddedNavigator = True
        Me.GC2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFORPRE_PRE_CODE_FK_PK, Me.colFORPRE_DATE_PK, Me.colFORPRE_FORFAIT, Me.colFORPRE_Valide})
        Me.GV2.GridControl = Me.GC2
        Me.GV2.GroupPanelText = " "
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsView.ShowGroupPanel = False
        '
        'colFORPRE_PRE_CODE_FK_PK
        '
        Me.colFORPRE_PRE_CODE_FK_PK.Caption = "FORPRE_PRE_CODE_FK_PK"
        Me.colFORPRE_PRE_CODE_FK_PK.FieldName = "FORPRE_PRE_CODE_FK_PK"
        Me.colFORPRE_PRE_CODE_FK_PK.Name = "colFORPRE_PRE_CODE_FK_PK"
        '
        'colFORPRE_DATE_PK
        '
        Me.colFORPRE_DATE_PK.Caption = "Date application JO"
        Me.colFORPRE_DATE_PK.FieldName = "FORPRE_DATE_PK"
        Me.colFORPRE_DATE_PK.Name = "colFORPRE_DATE_PK"
        Me.colFORPRE_DATE_PK.Visible = True
        Me.colFORPRE_DATE_PK.VisibleIndex = 1
        Me.colFORPRE_DATE_PK.Width = 147
        '
        'colFORPRE_FORFAIT
        '
        Me.colFORPRE_FORFAIT.Caption = "Tarif forfaitaire de responsabilité"
        Me.colFORPRE_FORFAIT.FieldName = "FORPRE_FORFAIT"
        Me.colFORPRE_FORFAIT.Name = "colFORPRE_FORFAIT"
        Me.colFORPRE_FORFAIT.Visible = True
        Me.colFORPRE_FORFAIT.VisibleIndex = 0
        Me.colFORPRE_FORFAIT.Width = 395
        '
        'colFORPRE_Valide
        '
        Me.colFORPRE_Valide.Caption = "Valide"
        Me.colFORPRE_Valide.FieldName = "FORPRE_Valide"
        Me.colFORPRE_Valide.Name = "colFORPRE_Valide"
        Me.colFORPRE_Valide.Visible = True
        Me.colFORPRE_Valide.VisibleIndex = 2
        '
        'rpForfait
        '
        Me.rpForfait.AutoHeight = False
        Me.rpForfait.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpForfait.Name = "rpForfait"
        '
        'chkForPreValid
        '
        Me.chkForPreValid.AutoHeight = False
        Me.chkForPreValid.Name = "chkForPreValid"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'GC1
        '
        Me.GC1.DataMember = "PRIPRE_PRIX_PRESENTATION"
        Me.GC1.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC1.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC1.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC1.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC1.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC1.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC1.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC1.EmbeddedNavigator.Name = ""
        Me.GC1.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC1.Location = New System.Drawing.Point(6, 11)
        Me.GC1.MainView = Me.GV1
        Me.GC1.Name = "GC1"
        Me.GC1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpPrix})
        Me.GC1.Size = New System.Drawing.Size(568, 200)
        Me.GC1.TabIndex = 16
        Me.GC1.UseEmbeddedNavigator = True
        Me.GC1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPRIPRE_DATE_APPLI_PK, Me.colPRIPRE_PRE_CODE_FK_PK, Me.colPRIPRE_PRIX, Me.colPRIPRE_PRIX_EURO, Me.colPRIPRE_Valide})
        Me.GV1.GridControl = Me.GC1
        Me.GV1.GroupPanelText = " "
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsView.ShowGroupPanel = False
        '
        'colPRIPRE_DATE_APPLI_PK
        '
        Me.colPRIPRE_DATE_APPLI_PK.Caption = "Date application JO"
        Me.colPRIPRE_DATE_APPLI_PK.FieldName = "PRIPRE_DATE_APPLI_PK"
        Me.colPRIPRE_DATE_APPLI_PK.Name = "colPRIPRE_DATE_APPLI_PK"
        Me.colPRIPRE_DATE_APPLI_PK.Visible = True
        Me.colPRIPRE_DATE_APPLI_PK.VisibleIndex = 1
        Me.colPRIPRE_DATE_APPLI_PK.Width = 148
        '
        'colPRIPRE_PRE_CODE_FK_PK
        '
        Me.colPRIPRE_PRE_CODE_FK_PK.Caption = "PRIPRE_PRE_CODE_FK_PK"
        Me.colPRIPRE_PRE_CODE_FK_PK.FieldName = "PRIPRE_PRE_CODE_FK_PK"
        Me.colPRIPRE_PRE_CODE_FK_PK.Name = "colPRIPRE_PRE_CODE_FK_PK"
        '
        'colPRIPRE_PRIX
        '
        Me.colPRIPRE_PRIX.Caption = "PRIPRE_PRIX"
        Me.colPRIPRE_PRIX.FieldName = "PRIPRE_PRIX"
        Me.colPRIPRE_PRIX.Name = "colPRIPRE_PRIX"
        '
        'colPRIPRE_PRIX_EURO
        '
        Me.colPRIPRE_PRIX_EURO.Caption = "Prix en officine ville (TTC)"
        Me.colPRIPRE_PRIX_EURO.FieldName = "PRIPRE_PRIX_EURO"
        Me.colPRIPRE_PRIX_EURO.Name = "colPRIPRE_PRIX_EURO"
        Me.colPRIPRE_PRIX_EURO.Visible = True
        Me.colPRIPRE_PRIX_EURO.VisibleIndex = 0
        Me.colPRIPRE_PRIX_EURO.Width = 394
        '
        'colPRIPRE_Valide
        '
        Me.colPRIPRE_Valide.Caption = "Valide"
        Me.colPRIPRE_Valide.FieldName = "PRIPRE_Valide"
        Me.colPRIPRE_Valide.Name = "colPRIPRE_Valide"
        Me.colPRIPRE_Valide.Visible = True
        Me.colPRIPRE_Valide.VisibleIndex = 2
        '
        'rpPrix
        '
        Me.rpPrix.AutoHeight = False
        Me.rpPrix.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpPrix.Name = "rpPrix"
        '
        'ForprE_TA
        '
        Me.ForprE_TA.ClearBeforeFill = True
        '
        'PriprE_TA
        '
        Me.PriprE_TA.ClearBeforeFill = True
        '
        'Frm_Presentation_Prix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(591, 437)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Presentation_Prix"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Prix"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpForfait, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkForPreValid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpPrix, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GC1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPRIPRE_DATE_APPLI_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRIPRE_PRE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRIPRE_PRIX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRIPRE_PRIX_EURO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GC2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFORPRE_PRE_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFORPRE_DATE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFORPRE_FORFAIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpPrix As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rpForfait As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ForprE_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.FORPRE_FORFAIT_PRETableAdapter
    Friend WithEvents PriprE_TA As Theriaque.dsTheriaque_Nomenclature2TableAdapters.PRIPRE_PRIX_PRESENTATIONTableAdapter
    Friend WithEvents colFORPRE_Valide As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRIPRE_Valide As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkForPreValid As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit

End Class
