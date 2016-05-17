<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Categorie
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        'LZA
        'ClearMemory()
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Categorie))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim SuperToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Me.gcCategorie = New DevExpress.XtraGrid.GridControl
        Me.DOCCATEGORIEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTheriaqueCategorie = New Theriaque.dsTheriaqueCategorie
        Me.gvCategorie = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colLibelle = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_CATEGORIE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemPopupContainerEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.DOC_CATEGORIETableAdapter = New Theriaque.dsTheriaqueCategorieTableAdapters.DOC_CATEGORIETableAdapter
        Me.CD_TA = New Theriaque.dsTheriaqueCategorieTableAdapters.DOC_CATEGORIETableAdapter
        Me.txtLibelle = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtChemin = New DevExpress.XtraEditors.ButtonEdit
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.btValider = New DevExpress.XtraEditors.SimpleButton
        Me.btAnnuler = New DevExpress.XtraEditors.SimpleButton
        Me.btSupprimer = New DevExpress.XtraEditors.SimpleButton
        Me.btAjouter = New DevExpress.XtraEditors.SimpleButton
        Me.btFermer = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        CType(Me.gcCategorie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DOCCATEGORIEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaqueCategorie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCategorie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChemin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'gcCategorie
        '
        Me.gcCategorie.DataSource = Me.DOCCATEGORIEBindingSource
        Me.gcCategorie.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcCategorie.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcCategorie.EmbeddedNavigator.Buttons.First.Visible = False
        Me.gcCategorie.EmbeddedNavigator.Name = ""
        GridLevelNode1.RelationName = "Level1"
        Me.gcCategorie.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gcCategorie.Location = New System.Drawing.Point(2, 2)
        Me.gcCategorie.MainView = Me.gvCategorie
        Me.gcCategorie.Name = "gcCategorie"
        Me.gcCategorie.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.RepositoryItemPopupContainerEdit1})
        Me.gcCategorie.Size = New System.Drawing.Size(478, 262)
        Me.gcCategorie.TabIndex = 0
        Me.gcCategorie.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCategorie})
        '
        'DOCCATEGORIEBindingSource
        '
        Me.DOCCATEGORIEBindingSource.DataMember = "DOC_CATEGORIE"
        Me.DOCCATEGORIEBindingSource.DataSource = Me.DsTheriaqueCategorie
        '
        'DsTheriaqueCategorie
        '
        Me.DsTheriaqueCategorie.DataSetName = "dsTheriaqueCategorie"
        Me.DsTheriaqueCategorie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvCategorie
        '
        Me.gvCategorie.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLibelle, Me.colID_CATEGORIE})
        Me.gvCategorie.GridControl = Me.gcCategorie
        Me.gvCategorie.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.gvCategorie.Name = "gvCategorie"
        '
        'colLibelle
        '
        Me.colLibelle.Caption = "Libelle"
        Me.colLibelle.FieldName = "Libelle"
        Me.colLibelle.Name = "colLibelle"
        Me.colLibelle.OptionsColumn.AllowEdit = False
        Me.colLibelle.Visible = True
        Me.colLibelle.VisibleIndex = 0
        '
        'colID_CATEGORIE
        '
        Me.colID_CATEGORIE.Caption = "colID_CATEGORIE"
        Me.colID_CATEGORIE.FieldName = "ID_CATEGORIE"
        Me.colID_CATEGORIE.Name = "colID_CATEGORIE"
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'RepositoryItemPopupContainerEdit1
        '
        Me.RepositoryItemPopupContainerEdit1.AutoHeight = False
        Me.RepositoryItemPopupContainerEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPopupContainerEdit1.Name = "RepositoryItemPopupContainerEdit1"
        '
        'DOC_CATEGORIETableAdapter
        '
        Me.DOC_CATEGORIETableAdapter.ClearBeforeFill = True
        '
        'CD_TA
        '
        Me.CD_TA.ClearBeforeFill = True
        '
        'txtLibelle
        '
        Me.txtLibelle.Location = New System.Drawing.Point(61, 5)
        Me.txtLibelle.Name = "txtLibelle"
        Me.txtLibelle.Size = New System.Drawing.Size(391, 20)
        Me.txtLibelle.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(15, 8)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Libellé"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(15, 87)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Chemin"
        Me.LabelControl2.Visible = False
        '
        'txtChemin
        '
        Me.txtChemin.Location = New System.Drawing.Point(61, 83)
        Me.txtChemin.Name = "txtChemin"
        Me.txtChemin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtChemin.Size = New System.Drawing.Size(391, 20)
        Me.txtChemin.TabIndex = 6
        Me.txtChemin.Visible = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btValider)
        Me.PanelControl1.Controls.Add(Me.btAnnuler)
        Me.PanelControl1.Controls.Add(Me.btSupprimer)
        Me.PanelControl1.Controls.Add(Me.btAjouter)
        Me.PanelControl1.Controls.Add(Me.btFermer)
        Me.PanelControl1.Location = New System.Drawing.Point(474, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(116, 333)
        Me.PanelControl1.TabIndex = 9
        Me.PanelControl1.Text = "PanelControl1"
        '
        'btValider
        '
        Me.btValider.Enabled = False
        Me.btValider.Image = CType(resources.GetObject("btValider.Image"), System.Drawing.Image)
        Me.btValider.Location = New System.Drawing.Point(8, 77)
        Me.btValider.Name = "btValider"
        Me.btValider.Size = New System.Drawing.Size(96, 27)
        ToolTipItem1.Text = "F10: Valider la saisie"
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btValider.SuperTip = SuperToolTip1
        Me.btValider.TabIndex = 10
        Me.btValider.Text = "&Valider"
        '
        'btAnnuler
        '
        Me.btAnnuler.Enabled = False
        Me.btAnnuler.Image = CType(resources.GetObject("btAnnuler.Image"), System.Drawing.Image)
        Me.btAnnuler.Location = New System.Drawing.Point(8, 107)
        Me.btAnnuler.Name = "btAnnuler"
        Me.btAnnuler.Size = New System.Drawing.Size(96, 27)
        ToolTipItem2.Text = "F7: Annuler les modifications"
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.btAnnuler.SuperTip = SuperToolTip2
        Me.btAnnuler.TabIndex = 8
        Me.btAnnuler.Text = "A&nnuler"
        '
        'btSupprimer
        '
        Me.btSupprimer.Image = CType(resources.GetObject("btSupprimer.Image"), System.Drawing.Image)
        Me.btSupprimer.Location = New System.Drawing.Point(8, 44)
        Me.btSupprimer.Name = "btSupprimer"
        Me.btSupprimer.Size = New System.Drawing.Size(96, 27)
        ToolTipItem3.Text = "F11: Supprimer la fiche en cours"
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.btSupprimer.SuperTip = SuperToolTip3
        Me.btSupprimer.TabIndex = 7
        Me.btSupprimer.Text = "&Supprimer"
        '
        'btAjouter
        '
        Me.btAjouter.Image = CType(resources.GetObject("btAjouter.Image"), System.Drawing.Image)
        Me.btAjouter.Location = New System.Drawing.Point(8, 12)
        Me.btAjouter.Name = "btAjouter"
        Me.btAjouter.Size = New System.Drawing.Size(96, 27)
        ToolTipItem4.Text = "F6 : Ajouter une fiche"
        SuperToolTip4.Items.Add(ToolTipItem4)
        Me.btAjouter.SuperTip = SuperToolTip4
        Me.btAjouter.TabIndex = 6
        Me.btAjouter.Text = "&Ajouter"
        '
        'btFermer
        '
        Me.btFermer.Image = CType(resources.GetObject("btFermer.Image"), System.Drawing.Image)
        Me.btFermer.Location = New System.Drawing.Point(8, 139)
        Me.btFermer.Name = "btFermer"
        Me.btFermer.Size = New System.Drawing.Size(96, 27)
        ToolTipItem5.Text = "F3: Fermer la fiche sans validation"
        SuperToolTip5.Items.Add(ToolTipItem5)
        Me.btFermer.SuperTip = SuperToolTip5
        Me.btFermer.TabIndex = 9
        Me.btFermer.Text = "&Fermer"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.txtLibelle)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.txtChemin)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Location = New System.Drawing.Point(-6, 267)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(480, 66)
        Me.PanelControl2.TabIndex = 10
        Me.PanelControl2.Text = "PanelControl2"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.gcCategorie)
        Me.PanelControl3.Location = New System.Drawing.Point(-6, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(482, 266)
        Me.PanelControl3.TabIndex = 11
        Me.PanelControl3.Text = "PanelControl3"
        '
        'Frm_Categorie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 306)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.KeyPreview = True
        Me.Name = "Frm_Categorie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Catégorie"
        CType(Me.gcCategorie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DOCCATEGORIEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaqueCategorie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCategorie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLibelle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChemin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcCategorie As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCategorie As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsTheriaqueCategorie As Theriaque.dsTheriaqueCategorie
    Friend WithEvents DOCCATEGORIEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DOC_CATEGORIETableAdapter As Theriaque.dsTheriaqueCategorieTableAdapters.DOC_CATEGORIETableAdapter
    Friend WithEvents colLibelle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemPopupContainerEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents txtLibelle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtChemin As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Protected Friend WithEvents btAnnuler As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btSupprimer As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btAjouter As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btFermer As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btValider As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colID_CATEGORIE As DevExpress.XtraGrid.Columns.GridColumn
End Class
