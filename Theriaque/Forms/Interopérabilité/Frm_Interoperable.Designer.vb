<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Interoperable
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.DsTheriaque_Interoperable = New Theriaque.dsTheriaque_Interoperable
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.DateEdit3 = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colINTER_SP_CODE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colINTER_SP_NOM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colINTER_SP_NL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colINTER_PRE_CODE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colINTER_SP_CIPUCD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colINTER_SP_NOMLONG = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colINTER_PRE_ADMIN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colINTER_PRE_ETAT_COMMER = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colINTER_SP_CIPUCD13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colINTER_PRE_EAN_REF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DextR_TA = New Theriaque.dsTheriaque_InteroperableTableAdapters.DEXTR_DATE_EXTRACTIONTableAdapter
        Me.InteR_TA = New Theriaque.dsTheriaque_InteroperableTableAdapters.INTER_INTEROPERABLETableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_Interoperable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(842, 656)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.XtraTabControl1)
        Me.PanMain.Controls.Add(Me.GroupBox1)
        Me.PanMain.Location = New System.Drawing.Point(0, 37)
        Me.PanMain.Size = New System.Drawing.Size(724, 619)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(842, 37)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(842, 28)
        Me.Label1.Text = "Fiche Interopérable"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(724, 37)
        Me.Panel1.Size = New System.Drawing.Size(118, 619)
        Me.Panel1.Visible = False
        '
        'btAjouter
        '
        Me.btAjouter.Location = New System.Drawing.Point(3, 275)
        Me.btAjouter.Visible = False
        '
        'btChercher
        '
        Me.btChercher.Location = New System.Drawing.Point(4, 81)
        '
        'btAnnuler
        '
        Me.btAnnuler.Location = New System.Drawing.Point(3, 388)
        Me.btAnnuler.Visible = False
        '
        'btValider
        '
        Me.btValider.Location = New System.Drawing.Point(3, 355)
        Me.btValider.Visible = False
        '
        'btSupprimer
        '
        Me.btSupprimer.Location = New System.Drawing.Point(3, 308)
        Me.btSupprimer.Visible = False
        '
        'btFermer
        '
        Me.btFermer.Location = New System.Drawing.Point(4, 116)
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit1.Visible = False
        '
        'GroupBox
        '
        Me.GroupBox.Location = New System.Drawing.Point(0, 29)
        Me.GroupBox.Size = New System.Drawing.Size(842, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit2.Visible = False
        '
        'btAdvancedSearch
        '
        Me.btAdvancedSearch.Location = New System.Drawing.Point(3, 435)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.DateEdit3)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(724, 56)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Interoperable, "DEXTR_DATE_EXTRACTION.DEXTR_VER_THER_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(488, 19)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(135, 20)
        Me.txtCode.TabIndex = 10
        Me.txtCode.Tag = "[NOEDIT][NOADD]"
        '
        'DsTheriaque_Interoperable
        '
        Me.DsTheriaque_Interoperable.DataSetName = "dsTheriaque_Interoperable"
        Me.DsTheriaque_Interoperable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(365, 21)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(117, 16)
        Me.LabelControl4.TabIndex = 11
        Me.LabelControl4.Text = "Version d'extraction"
        '
        'DateEdit3
        '
        Me.DateEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Interoperable, "DEXTR_DATE_EXTRACTION.DEXTR_DATE_EXTR_PK", True))
        Me.DateEdit3.EditValue = Nothing
        Me.DateEdit3.Location = New System.Drawing.Point(131, 19)
        Me.DateEdit3.Name = "DateEdit3"
        Me.DateEdit3.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.DateEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit3.Properties.ReadOnly = True
        Me.DateEdit3.Size = New System.Drawing.Size(135, 20)
        Me.DateEdit3.TabIndex = 9
        Me.DateEdit3.TabStop = False
        Me.DateEdit3.Tag = ""
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(25, 21)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(100, 16)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Date d'extraction"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 56)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage2
        Me.XtraTabControl1.Size = New System.Drawing.Size(724, 563)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GC)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(715, 532)
        Me.XtraTabPage2.Text = "Fiche interopérable"
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.EmbeddedNavigator.Buttons.Append.Enabled = False
        Me.GC.EmbeddedNavigator.Buttons.CancelEdit.Enabled = False
        Me.GC.EmbeddedNavigator.Buttons.Edit.Enabled = False
        Me.GC.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.EndEdit.Enabled = False
        Me.GC.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC.EmbeddedNavigator.Buttons.Remove.Enabled = False
        Me.GC.EmbeddedNavigator.Name = ""
        Me.GC.EmbeddedNavigator.TextStringFormat = "Total {0} of {1}"
        Me.GC.Location = New System.Drawing.Point(0, 0)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.Size = New System.Drawing.Size(715, 532)
        Me.GC.TabIndex = 0
        Me.GC.UseEmbeddedNavigator = True
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colINTER_SP_CODE, Me.colINTER_SP_NOM, Me.colINTER_SP_NL, Me.colINTER_PRE_CODE, Me.colINTER_SP_CIPUCD, Me.colINTER_SP_NOMLONG, Me.colINTER_PRE_ADMIN, Me.colINTER_PRE_ETAT_COMMER, Me.colINTER_SP_CIPUCD13, Me.colINTER_PRE_EAN_REF})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'colINTER_SP_CODE
        '
        Me.colINTER_SP_CODE.Caption = "INTER_SP_CODE"
        Me.colINTER_SP_CODE.FieldName = "INTER_SP_CODE"
        Me.colINTER_SP_CODE.Name = "colINTER_SP_CODE"
        Me.colINTER_SP_CODE.OptionsColumn.ReadOnly = True
        Me.colINTER_SP_CODE.Visible = True
        Me.colINTER_SP_CODE.VisibleIndex = 0
        Me.colINTER_SP_CODE.Width = 58
        '
        'colINTER_SP_NOM
        '
        Me.colINTER_SP_NOM.Caption = "INTER_SP_NOM"
        Me.colINTER_SP_NOM.FieldName = "INTER_SP_NOM"
        Me.colINTER_SP_NOM.Name = "colINTER_SP_NOM"
        Me.colINTER_SP_NOM.OptionsColumn.ReadOnly = True
        Me.colINTER_SP_NOM.Visible = True
        Me.colINTER_SP_NOM.VisibleIndex = 1
        Me.colINTER_SP_NOM.Width = 83
        '
        'colINTER_SP_NL
        '
        Me.colINTER_SP_NL.Caption = "INTER_SP_NL"
        Me.colINTER_SP_NL.FieldName = "INTER_SP_NL"
        Me.colINTER_SP_NL.Name = "colINTER_SP_NL"
        Me.colINTER_SP_NL.OptionsColumn.ReadOnly = True
        Me.colINTER_SP_NL.Visible = True
        Me.colINTER_SP_NL.VisibleIndex = 2
        Me.colINTER_SP_NL.Width = 62
        '
        'colINTER_PRE_CODE
        '
        Me.colINTER_PRE_CODE.Caption = "INTER_PRE_CODE"
        Me.colINTER_PRE_CODE.FieldName = "INTER_PRE_CODE"
        Me.colINTER_PRE_CODE.Name = "colINTER_PRE_CODE"
        Me.colINTER_PRE_CODE.OptionsColumn.ReadOnly = True
        Me.colINTER_PRE_CODE.Visible = True
        Me.colINTER_PRE_CODE.VisibleIndex = 3
        Me.colINTER_PRE_CODE.Width = 53
        '
        'colINTER_SP_CIPUCD
        '
        Me.colINTER_SP_CIPUCD.Caption = "INTER_SP_CIPUCD"
        Me.colINTER_SP_CIPUCD.FieldName = "INTER_SP_CIPUCD"
        Me.colINTER_SP_CIPUCD.Name = "colINTER_SP_CIPUCD"
        Me.colINTER_SP_CIPUCD.Visible = True
        Me.colINTER_SP_CIPUCD.VisibleIndex = 4
        Me.colINTER_SP_CIPUCD.Width = 53
        '
        'colINTER_SP_NOMLONG
        '
        Me.colINTER_SP_NOMLONG.Caption = "INTER_SP_NOMLONG"
        Me.colINTER_SP_NOMLONG.FieldName = "INTER_SP_NOMLONG"
        Me.colINTER_SP_NOMLONG.Name = "colINTER_SP_NOMLONG"
        Me.colINTER_SP_NOMLONG.OptionsColumn.ReadOnly = True
        Me.colINTER_SP_NOMLONG.Visible = True
        Me.colINTER_SP_NOMLONG.VisibleIndex = 5
        Me.colINTER_SP_NOMLONG.Width = 117
        '
        'colINTER_PRE_ADMIN
        '
        Me.colINTER_PRE_ADMIN.Caption = "INTER_PRE_ADMIN"
        Me.colINTER_PRE_ADMIN.FieldName = "INTER_PRE_ADMIN"
        Me.colINTER_PRE_ADMIN.Name = "colINTER_PRE_ADMIN"
        Me.colINTER_PRE_ADMIN.OptionsColumn.ReadOnly = True
        Me.colINTER_PRE_ADMIN.Visible = True
        Me.colINTER_PRE_ADMIN.VisibleIndex = 6
        Me.colINTER_PRE_ADMIN.Width = 104
        '
        'colINTER_PRE_ETAT_COMMER
        '
        Me.colINTER_PRE_ETAT_COMMER.Caption = "INTER_PRE_ETAT_COMMER"
        Me.colINTER_PRE_ETAT_COMMER.FieldName = "INTER_PRE_ETAT_COMMER"
        Me.colINTER_PRE_ETAT_COMMER.Name = "colINTER_PRE_ETAT_COMMER"
        Me.colINTER_PRE_ETAT_COMMER.OptionsColumn.ReadOnly = True
        Me.colINTER_PRE_ETAT_COMMER.Visible = True
        Me.colINTER_PRE_ETAT_COMMER.VisibleIndex = 7
        Me.colINTER_PRE_ETAT_COMMER.Width = 104
        '
        'colINTER_SP_CIPUCD13
        '
        Me.colINTER_SP_CIPUCD13.Caption = "INTER_SP_CIPUCD13"
        Me.colINTER_SP_CIPUCD13.FieldName = "INTER_SP_CIPUCD13"
        Me.colINTER_SP_CIPUCD13.Name = "colINTER_SP_CIPUCD13"
        Me.colINTER_SP_CIPUCD13.Visible = True
        Me.colINTER_SP_CIPUCD13.VisibleIndex = 8
        '
        'colINTER_PRE_EAN_REF
        '
        Me.colINTER_PRE_EAN_REF.Caption = "INTER_PRE_EAN_REF"
        Me.colINTER_PRE_EAN_REF.FieldName = "INTER_PRE_EAN_REF"
        Me.colINTER_PRE_EAN_REF.Name = "colINTER_PRE_EAN_REF"
        Me.colINTER_PRE_EAN_REF.Visible = True
        Me.colINTER_PRE_EAN_REF.VisibleIndex = 9
        '
        'DextR_TA
        '
        Me.DextR_TA.ClearBeforeFill = True
        '
        'InteR_TA
        '
        Me.InteR_TA.ClearBeforeFill = True
        '
        'Frm_Interoperable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(842, 656)
        Me.Name = "Frm_Interoperable"
        Me.Text = "Fiche Interopérable"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_Interoperable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected Friend WithEvents DateEdit3 As DevExpress.XtraEditors.DateEdit
    Protected Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsTheriaque_Interoperable As Theriaque.dsTheriaque_Interoperable
    Friend WithEvents DextR_TA As Theriaque.dsTheriaque_InteroperableTableAdapters.DEXTR_DATE_EXTRACTIONTableAdapter
    Friend WithEvents InteR_TA As Theriaque.dsTheriaque_InteroperableTableAdapters.INTER_INTEROPERABLETableAdapter
    Friend WithEvents colINTER_SP_CODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colINTER_SP_NOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colINTER_SP_NL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colINTER_PRE_CODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colINTER_SP_CIPUCD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colINTER_SP_NOMLONG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colINTER_PRE_ADMIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colINTER_PRE_ETAT_COMMER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colINTER_SP_CIPUCD13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colINTER_PRE_EAN_REF As DevExpress.XtraGrid.Columns.GridColumn

End Class
