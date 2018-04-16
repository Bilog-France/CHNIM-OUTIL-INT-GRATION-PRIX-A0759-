<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Cipemg_Code
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
        Me.FcpM_TA = New Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.FCPM_FICHECIPEMGTableAdapter
        Me.DsTheriaque_Cipemg_Code = New Theriaque.dsTheriaque_Cipemg_Code
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbOrigine = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.RG = New DevExpress.XtraEditors.RadioGroup
        Me.txtCode = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.GC7 = New DevExpress.XtraGrid.GridControl
        Me.GV7 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCPMSP_FCPM_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPMSP_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FCPMSP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.GC5 = New DevExpress.XtraGrid.GridControl
        Me.GV5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCPMPR_FCPM_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPMPR_PR_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FCPMPR = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC6 = New DevExpress.XtraGrid.GridControl
        Me.GV6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCPMCH_FCPM_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPMCH_CH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPMCH_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FCPMCH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.GC3 = New DevExpress.XtraGrid.GridControl
        Me.GV3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCPMSAC_FCPM_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPMSAC_SAC_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FCPMSAC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC4 = New DevExpress.XtraGrid.GridControl
        Me.GV4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCPMSAU_FCPM_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPMSAU_SAU_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FCPMSAU = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.GC1 = New DevExpress.XtraGrid.GridControl
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCPMCPH_FCPM_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPMCPH_CPH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FCPMCPH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC2 = New DevExpress.XtraGrid.GridControl
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCPMCCH_FCPM_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPMCCH_CCH_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FCPMCCH = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XTabPage_Terrain = New DevExpress.XtraTab.XtraTabPage
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.Panel27 = New System.Windows.Forms.Panel
        Me.GC27 = New DevExpress.XtraGrid.GridControl
        Me.GV27 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCPMTX_FCPM_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPMTX_CDF_TER_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPMTX_NUMSEQ_TER_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPMTX_NATURECIPEMG_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPMTX_TEXTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rm_Memo1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Panel28 = New System.Windows.Forms.Panel
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.GC26 = New DevExpress.XtraGrid.GridControl
        Me.GV26 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colAUTCOM_FCPM_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAUTCOM_CDF_TER_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAUTCOM_NUMSEQ_TER_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAUTCOM_CDF_COM_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAUTCOM_NATURE_CIPEMG_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAUTCOM_NUMSEQ = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_AUTCOM = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.GC24 = New DevExpress.XtraGrid.GridControl
        Me.GV24 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel18 = New System.Windows.Forms.Panel
        Me.Panel21 = New System.Windows.Forms.Panel
        Me.GC25 = New DevExpress.XtraGrid.GridControl
        Me.GV25 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNIVCOM_FCPM_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNIVCOM_CDF_TER_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNIVCOM_NUMSEQ_TER_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNIVCOM_CDF_COM_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNIVCOM_NATURE_CIPEMG_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNIVCOM_NUMSEQ = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_NIVCOM = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel20 = New System.Windows.Forms.Panel
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.Panel19 = New System.Windows.Forms.Panel
        Me.GC23 = New DevExpress.XtraGrid.GridControl
        Me.GV23 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colTERCOM_FCPM_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTERCOM_CDF_TER_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTERCOM_NUMSEQ_TER_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTERCOM_CDF_COM_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTERCOM_NATURE_CIPEMG_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTERCOM_NUMSEQ = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_TERCOM = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel17 = New System.Windows.Forms.Panel
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.GC22 = New DevExpress.XtraGrid.GridControl
        Me.GV22 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GC21 = New DevExpress.XtraGrid.GridControl
        Me.GV21 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCPMTER_FCPM_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPMTER_CDF_TER_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPMTER_NUMSEQ_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPMTER_NUMORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FCPMTER = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFCPMTER_NATURE_CIPEMG_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colATCD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkupATCD = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.lkATCD = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel51 = New System.Windows.Forms.Panel
        Me.GC31 = New DevExpress.XtraGrid.GridControl
        Me.GV31 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFCPMAFS_FCPM_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPMAFS_SP_CODE_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FCPMAFS_SP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFCPMAFS_DATE_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCPMAFS_CDF_DOCUMENT_FK_PK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_FCPMAFS = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.FcpmcpH_TA = New Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.FCPMCPH_CIPEMG_CLPHTableAdapter
        Me.FcpmccH_TA = New Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.FCPMCCH_CIPEMG_CLCHTableAdapter
        Me.FcpmcH_TA = New Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.FCPMCH_CIPEMGCHTableAdapter
        Me.FcpmpR_TA = New Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.FCPMPR_CIPEMG_PRODTableAdapter
        Me.FcpmsaC_TA = New Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.FCPMSAC_CIPEMG_SUBACTableAdapter
        Me.FcpmsaU_TA = New Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.FCPMSAU_CIPEMG_SUBAUTableAdapter
        Me.FcpmsP_TA = New Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.FCPMSP_CIPEMG_SPETableAdapter
        Me.FcpmteR_TA = New Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.FCPMTER_FCPM_TERRAINTableAdapter
        Me.TercoM_TA = New Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.TERCOM_TERRAIN_COMMENTAIRETableAdapter
        Me.NivcoM_TA = New Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.NIVCOM_NIVEAU_COMMENTAIRETableAdapter
        Me.AutcoM_TA = New Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.AUTCOM_AUTRE_COMMENTAIRETableAdapter
        Me.FcpmtX_TA = New Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.FCPMTX_FICHECIPEMG_TEXTETableAdapter
        Me.FcpmafS_TA = New Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.FCPMAFS_CIPEMG_AFSSAPSTableAdapter
        Me.Pan.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTheriaque_Cipemg_Code, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmbOrigine.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.RG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.GC7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FCPMSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.GC5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FCPMPR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FCPMCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.GC3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FCPMSAC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FCPMSAU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FCPMCPH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FCPMCCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTabPage_Terrain.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel27.SuspendLayout()
        CType(Me.GC27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rm_Memo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel28.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel15.SuspendLayout()
        CType(Me.GC26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_AUTCOM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        CType(Me.GC24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV24, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel18.SuspendLayout()
        Me.Panel21.SuspendLayout()
        CType(Me.GC25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_NIVCOM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel19.SuspendLayout()
        CType(Me.GC23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_TERCOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV22, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.GC21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FCPMTER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupATCD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkATCD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.Panel51.SuspendLayout()
        CType(Me.GC31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FCPMAFS_SP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_FCPMAFS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan
        '
        Me.Pan.Size = New System.Drawing.Size(913, 665)
        '
        'PanMain
        '
        Me.PanMain.Controls.Add(Me.XtraTabControl1)
        Me.PanMain.Controls.Add(Me.GroupBox1)
        Me.PanMain.Location = New System.Drawing.Point(0, 70)
        Me.PanMain.Size = New System.Drawing.Size(795, 595)
        '
        'PanTop
        '
        Me.PanTop.Size = New System.Drawing.Size(913, 70)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(913, 28)
        Me.Label1.Text = "Cipemg - Fiche code"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(305, 43)
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(35, 43)
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(795, 70)
        Me.Panel1.Size = New System.Drawing.Size(118, 595)
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Cipemg_Code, "FCPM_FICHECIPEMG.FCPM_DATEMJ", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(377, 42)
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Location = New System.Drawing.Point(0, 62)
        Me.GroupBox.Size = New System.Drawing.Size(913, 8)
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Cipemg_Code, "FCPM_FICHECIPEMG.FCPM_DATECR", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(92, 41)
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        '
        'btAdvancedSearch
        '
        Me.btAdvancedSearch.Visible = True
        '
        'btDupliquer
        '
        Me.btDupliquer.Visible = True
        '
        'btn_RechMulti
        '
        Me.btn_RechMulti.Visible = True
        '
        'FcpM_TA
        '
        Me.FcpM_TA.ClearBeforeFill = True
        '
        'DsTheriaque_Cipemg_Code
        '
        Me.DsTheriaque_Cipemg_Code.DataSetName = "dsTheriaque_Cipemg_Code"
        Me.DsTheriaque_Cipemg_Code.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbOrigine)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(795, 75)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = ""
        '
        'cmbOrigine
        '
        Me.cmbOrigine.EditValue = ""
        Me.cmbOrigine.Location = New System.Drawing.Point(306, 15)
        Me.cmbOrigine.Name = "cmbOrigine"
        Me.cmbOrigine.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbOrigine.Properties.Items.AddRange(New Object() {"RCP", "Autre"})
        Me.cmbOrigine.Size = New System.Drawing.Size(136, 20)
        Me.cmbOrigine.TabIndex = 31
        Me.cmbOrigine.Tag = "[EDIT][ADD]"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(266, 18)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl5.TabIndex = 30
        Me.LabelControl5.Text = "Origine"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(27, 46)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Type terrain"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.RG)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(92, 39)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(420, 27)
        Me.Panel3.TabIndex = 9
        Me.Panel3.Tag = "[EDIT][ADD]"
        '
        'RG
        '
        Me.RG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RG.EditValue = 1
        Me.RG.Location = New System.Drawing.Point(0, 0)
        Me.RG.Name = "RG"
        Me.RG.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RG.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RG.Properties.Appearance.Options.UseBackColor = True
        Me.RG.Properties.Appearance.Options.UseFont = True
        Me.RG.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("C", "C"), New DevExpress.XtraEditors.Controls.RadioGroupItem("P", "P"), New DevExpress.XtraEditors.Controls.RadioGroupItem("N", "N"), New DevExpress.XtraEditors.Controls.RadioGroupItem("I", "I")})
        Me.RG.Size = New System.Drawing.Size(420, 27)
        Me.RG.TabIndex = 8
        Me.RG.Tag = "[EDIT][ADD]"
        Me.RG.ToolTip = "Saisissez un type de terrain CI/PE-MG/NCI/NIND (C P N  I)"
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsTheriaque_Cipemg_Code, "FCPM_FICHECIPEMG.FCPM_CODE_SQ_PK", True))
        Me.txtCode.Location = New System.Drawing.Point(92, 14)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(135, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Tag = "[NOEDIT][NOADD]"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(46, 18)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Fiche N°"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 75)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(795, 520)
        Me.XtraTabControl1.TabIndex = 9
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XTabPage_Terrain, Me.XtraTabPage2})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panel8)
        Me.XtraTabPage1.Controls.Add(Me.Panel7)
        Me.XtraTabPage1.Controls.Add(Me.Panel6)
        Me.XtraTabPage1.Controls.Add(Me.Panel4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(786, 489)
        Me.XtraTabPage1.Text = "Entités"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.GC7)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 374)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(786, 115)
        Me.Panel8.TabIndex = 26
        '
        'GC7
        '
        Me.GC7.DataMember = "FCPMSP_CIPEMG_SPE"
        Me.GC7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC7.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC7.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC7.EmbeddedNavigator.Name = ""
        Me.GC7.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC7.Location = New System.Drawing.Point(0, 0)
        Me.GC7.MainView = Me.GV7
        Me.GC7.Name = "GC7"
        Me.GC7.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FCPMSP})
        Me.GC7.Size = New System.Drawing.Size(786, 115)
        Me.GC7.TabIndex = 2
        Me.GC7.Tag = "[EDIT][ADD]"
        Me.GC7.UseEmbeddedNavigator = True
        Me.GC7.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV7})
        '
        'GV7
        '
        Me.GV7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCPMSP_FCPM_CODE_FK_PK, Me.colFCPMSP_SP_CODE_FK_PK, Me.GridColumn7})
        Me.GV7.GridControl = Me.GC7
        Me.GV7.Name = "GV7"
        Me.GV7.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV7.OptionsView.ShowGroupPanel = False
        '
        'colFCPMSP_FCPM_CODE_FK_PK
        '
        Me.colFCPMSP_FCPM_CODE_FK_PK.Caption = "FCPMSP_FCPM_CODE_FK_PK"
        Me.colFCPMSP_FCPM_CODE_FK_PK.FieldName = "FCPMSP_FCPM_CODE_FK_PK"
        Me.colFCPMSP_FCPM_CODE_FK_PK.Name = "colFCPMSP_FCPM_CODE_FK_PK"
        '
        'colFCPMSP_SP_CODE_FK_PK
        '
        Me.colFCPMSP_SP_CODE_FK_PK.Caption = "Code"
        Me.colFCPMSP_SP_CODE_FK_PK.FieldName = "FCPMSP_SP_CODE_FK_PK"
        Me.colFCPMSP_SP_CODE_FK_PK.Name = "colFCPMSP_SP_CODE_FK_PK"
        Me.colFCPMSP_SP_CODE_FK_PK.Visible = True
        Me.colFCPMSP_SP_CODE_FK_PK.VisibleIndex = 0
        Me.colFCPMSP_SP_CODE_FK_PK.Width = 50
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Spécialité"
        Me.GridColumn7.ColumnEdit = Me.rp_FCPMSP
        Me.GridColumn7.FieldName = "FCPMSP_SP_CODE_FK_PK"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        Me.GridColumn7.Width = 705
        '
        'rp_FCPMSP
        '
        Me.rp_FCPMSP.AutoHeight = False
        Me.rp_FCPMSP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FCPMSP.Name = "rp_FCPMSP"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.GC5)
        Me.Panel7.Controls.Add(Me.GC6)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 241)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(786, 133)
        Me.Panel7.TabIndex = 25
        '
        'GC5
        '
        Me.GC5.DataMember = "FCPMPR_CIPEMG_PROD"
        Me.GC5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC5.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC5.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC5.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC5.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC5.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC5.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC5.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC5.EmbeddedNavigator.Name = ""
        Me.GC5.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC5.Location = New System.Drawing.Point(0, 0)
        Me.GC5.MainView = Me.GV5
        Me.GC5.Name = "GC5"
        Me.GC5.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FCPMPR})
        Me.GC5.Size = New System.Drawing.Size(439, 133)
        Me.GC5.TabIndex = 2
        Me.GC5.Tag = "[EDIT][ADD]"
        Me.GC5.UseEmbeddedNavigator = True
        Me.GC5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV5})
        '
        'GV5
        '
        Me.GV5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCPMPR_FCPM_CODE_FK_PK, Me.colFCPMPR_PR_CODE_FK_PK, Me.GridColumn5})
        Me.GV5.GridControl = Me.GC5
        Me.GV5.Name = "GV5"
        Me.GV5.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV5.OptionsView.ShowGroupPanel = False
        '
        'colFCPMPR_FCPM_CODE_FK_PK
        '
        Me.colFCPMPR_FCPM_CODE_FK_PK.Caption = "FCPMPR_FCPM_CODE_FK_PK"
        Me.colFCPMPR_FCPM_CODE_FK_PK.FieldName = "FCPMPR_FCPM_CODE_FK_PK"
        Me.colFCPMPR_FCPM_CODE_FK_PK.Name = "colFCPMPR_FCPM_CODE_FK_PK"
        '
        'colFCPMPR_PR_CODE_FK_PK
        '
        Me.colFCPMPR_PR_CODE_FK_PK.Caption = "Code"
        Me.colFCPMPR_PR_CODE_FK_PK.FieldName = "FCPMPR_PR_CODE_FK_PK"
        Me.colFCPMPR_PR_CODE_FK_PK.Name = "colFCPMPR_PR_CODE_FK_PK"
        Me.colFCPMPR_PR_CODE_FK_PK.Visible = True
        Me.colFCPMPR_PR_CODE_FK_PK.VisibleIndex = 0
        Me.colFCPMPR_PR_CODE_FK_PK.Width = 50
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Produit"
        Me.GridColumn5.ColumnEdit = Me.rp_FCPMPR
        Me.GridColumn5.FieldName = "FCPMPR_PR_CODE_FK_PK"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 404
        '
        'rp_FCPMPR
        '
        Me.rp_FCPMPR.AutoHeight = False
        Me.rp_FCPMPR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FCPMPR.Name = "rp_FCPMPR"
        '
        'GC6
        '
        Me.GC6.DataMember = "FCPMCH_CIPEMGCH"
        Me.GC6.Dock = System.Windows.Forms.DockStyle.Right
        Me.GC6.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC6.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC6.EmbeddedNavigator.Name = ""
        Me.GC6.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC6.Location = New System.Drawing.Point(439, 0)
        Me.GC6.MainView = Me.GV6
        Me.GC6.Name = "GC6"
        Me.GC6.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FCPMCH})
        Me.GC6.Size = New System.Drawing.Size(347, 133)
        Me.GC6.TabIndex = 3
        Me.GC6.Tag = "[EDIT][ADD]"
        Me.GC6.UseEmbeddedNavigator = True
        Me.GC6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV6})
        '
        'GV6
        '
        Me.GV6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCPMCH_FCPM_CODE_FK_PK, Me.colFCPMCH_CH_CODE_FK_PK, Me.colFCPMCH_NUMORD, Me.GridColumn6})
        Me.GV6.GridControl = Me.GC6
        Me.GV6.Name = "GV6"
        Me.GV6.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV6.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV6.OptionsView.ShowGroupPanel = False
        Me.GV6.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFCPMCH_NUMORD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFCPMCH_FCPM_CODE_FK_PK
        '
        Me.colFCPMCH_FCPM_CODE_FK_PK.Caption = "FCPMCH_FCPM_CODE_FK_PK"
        Me.colFCPMCH_FCPM_CODE_FK_PK.FieldName = "FCPMCH_FCPM_CODE_FK_PK"
        Me.colFCPMCH_FCPM_CODE_FK_PK.Name = "colFCPMCH_FCPM_CODE_FK_PK"
        '
        'colFCPMCH_CH_CODE_FK_PK
        '
        Me.colFCPMCH_CH_CODE_FK_PK.Caption = "Code"
        Me.colFCPMCH_CH_CODE_FK_PK.FieldName = "FCPMCH_CH_CODE_FK_PK"
        Me.colFCPMCH_CH_CODE_FK_PK.Name = "colFCPMCH_CH_CODE_FK_PK"
        Me.colFCPMCH_CH_CODE_FK_PK.Visible = True
        Me.colFCPMCH_CH_CODE_FK_PK.VisibleIndex = 0
        Me.colFCPMCH_CH_CODE_FK_PK.Width = 50
        '
        'colFCPMCH_NUMORD
        '
        Me.colFCPMCH_NUMORD.Caption = "N°"
        Me.colFCPMCH_NUMORD.FieldName = "FCPMCH_NUMORD"
        Me.colFCPMCH_NUMORD.Name = "colFCPMCH_NUMORD"
        Me.colFCPMCH_NUMORD.Visible = True
        Me.colFCPMCH_NUMORD.VisibleIndex = 2
        Me.colFCPMCH_NUMORD.Width = 50
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Critère de choix"
        Me.GridColumn6.ColumnEdit = Me.rp_FCPMCH
        Me.GridColumn6.FieldName = "FCPMCH_CH_CODE_FK_PK"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        Me.GridColumn6.Width = 180
        '
        'rp_FCPMCH
        '
        Me.rp_FCPMCH.AutoHeight = False
        Me.rp_FCPMCH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FCPMCH.Name = "rp_FCPMCH"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GC3)
        Me.Panel6.Controls.Add(Me.GC4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 125)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(786, 116)
        Me.Panel6.TabIndex = 24
        '
        'GC3
        '
        Me.GC3.DataMember = "FCPMSAC_CIPEMG_SUBAC"
        Me.GC3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC3.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC3.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC3.EmbeddedNavigator.Name = ""
        Me.GC3.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC3.Location = New System.Drawing.Point(0, 0)
        Me.GC3.MainView = Me.GV3
        Me.GC3.Name = "GC3"
        Me.GC3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FCPMSAC})
        Me.GC3.Size = New System.Drawing.Size(439, 116)
        Me.GC3.TabIndex = 2
        Me.GC3.Tag = "[EDIT][ADD]"
        Me.GC3.UseEmbeddedNavigator = True
        Me.GC3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV3})
        '
        'GV3
        '
        Me.GV3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCPMSAC_FCPM_CODE_FK_PK, Me.colFCPMSAC_SAC_CODE_FK_PK, Me.GridColumn3})
        Me.GV3.GridControl = Me.GC3
        Me.GV3.Name = "GV3"
        Me.GV3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV3.OptionsView.ShowGroupPanel = False
        '
        'colFCPMSAC_FCPM_CODE_FK_PK
        '
        Me.colFCPMSAC_FCPM_CODE_FK_PK.Caption = "FCPMSAC_FCPM_CODE_FK_PK"
        Me.colFCPMSAC_FCPM_CODE_FK_PK.FieldName = "FCPMSAC_FCPM_CODE_FK_PK"
        Me.colFCPMSAC_FCPM_CODE_FK_PK.Name = "colFCPMSAC_FCPM_CODE_FK_PK"
        '
        'colFCPMSAC_SAC_CODE_FK_PK
        '
        Me.colFCPMSAC_SAC_CODE_FK_PK.Caption = "Code"
        Me.colFCPMSAC_SAC_CODE_FK_PK.FieldName = "FCPMSAC_SAC_CODE_FK_PK"
        Me.colFCPMSAC_SAC_CODE_FK_PK.Name = "colFCPMSAC_SAC_CODE_FK_PK"
        Me.colFCPMSAC_SAC_CODE_FK_PK.Visible = True
        Me.colFCPMSAC_SAC_CODE_FK_PK.VisibleIndex = 0
        Me.colFCPMSAC_SAC_CODE_FK_PK.Width = 50
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Substance active"
        Me.GridColumn3.ColumnEdit = Me.rp_FCPMSAC
        Me.GridColumn3.FieldName = "FCPMSAC_SAC_CODE_FK_PK"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 402
        '
        'rp_FCPMSAC
        '
        Me.rp_FCPMSAC.AutoHeight = False
        Me.rp_FCPMSAC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FCPMSAC.Name = "rp_FCPMSAC"
        '
        'GC4
        '
        Me.GC4.DataMember = "FCPMSAU_CIPEMG_SUBAU"
        Me.GC4.Dock = System.Windows.Forms.DockStyle.Right
        Me.GC4.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC4.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC4.EmbeddedNavigator.Name = ""
        Me.GC4.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC4.Location = New System.Drawing.Point(439, 0)
        Me.GC4.MainView = Me.GV4
        Me.GC4.Name = "GC4"
        Me.GC4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FCPMSAU})
        Me.GC4.Size = New System.Drawing.Size(347, 116)
        Me.GC4.TabIndex = 3
        Me.GC4.Tag = "[EDIT][ADD]"
        Me.GC4.UseEmbeddedNavigator = True
        Me.GC4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV4})
        '
        'GV4
        '
        Me.GV4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCPMSAU_FCPM_CODE_FK_PK, Me.colFCPMSAU_SAU_CODE_FK_PK, Me.GridColumn4})
        Me.GV4.GridControl = Me.GC4
        Me.GV4.Name = "GV4"
        Me.GV4.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV4.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV4.OptionsView.ShowGroupPanel = False
        '
        'colFCPMSAU_FCPM_CODE_FK_PK
        '
        Me.colFCPMSAU_FCPM_CODE_FK_PK.Caption = "FCPMSAU_FCPM_CODE_FK_PK"
        Me.colFCPMSAU_FCPM_CODE_FK_PK.FieldName = "FCPMSAU_FCPM_CODE_FK_PK"
        Me.colFCPMSAU_FCPM_CODE_FK_PK.Name = "colFCPMSAU_FCPM_CODE_FK_PK"
        '
        'colFCPMSAU_SAU_CODE_FK_PK
        '
        Me.colFCPMSAU_SAU_CODE_FK_PK.Caption = "Code"
        Me.colFCPMSAU_SAU_CODE_FK_PK.FieldName = "FCPMSAU_SAU_CODE_FK_PK"
        Me.colFCPMSAU_SAU_CODE_FK_PK.Name = "colFCPMSAU_SAU_CODE_FK_PK"
        Me.colFCPMSAU_SAU_CODE_FK_PK.Visible = True
        Me.colFCPMSAU_SAU_CODE_FK_PK.VisibleIndex = 0
        Me.colFCPMSAU_SAU_CODE_FK_PK.Width = 50
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Excipient"
        Me.GridColumn4.ColumnEdit = Me.rp_FCPMSAU
        Me.GridColumn4.FieldName = "FCPMSAU_SAU_CODE_FK_PK"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 232
        '
        'rp_FCPMSAU
        '
        Me.rp_FCPMSAU.AutoHeight = False
        Me.rp_FCPMSAU.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FCPMSAU.Name = "rp_FCPMSAU"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GC1)
        Me.Panel4.Controls.Add(Me.GC2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(786, 125)
        Me.Panel4.TabIndex = 23
        '
        'GC1
        '
        Me.GC1.DataMember = "FCPMCPH_CIPEMG_CLPH"
        Me.GC1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC1.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC1.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC1.EmbeddedNavigator.Name = ""
        Me.GC1.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC1.Location = New System.Drawing.Point(0, 0)
        Me.GC1.MainView = Me.GV1
        Me.GC1.Name = "GC1"
        Me.GC1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FCPMCPH})
        Me.GC1.Size = New System.Drawing.Size(439, 125)
        Me.GC1.TabIndex = 2
        Me.GC1.Tag = "[EDIT][ADD]"
        Me.GC1.UseEmbeddedNavigator = True
        Me.GC1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCPMCPH_FCPM_CODE_FK_PK, Me.colFCPMCPH_CPH_CODE_FK_PK, Me.GridColumn1})
        Me.GV1.GridControl = Me.GC1
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV1.OptionsView.ShowGroupPanel = False
        '
        'colFCPMCPH_FCPM_CODE_FK_PK
        '
        Me.colFCPMCPH_FCPM_CODE_FK_PK.Caption = "FCPMCPH_FCPM_CODE_FK_PK"
        Me.colFCPMCPH_FCPM_CODE_FK_PK.FieldName = "FCPMCPH_FCPM_CODE_FK_PK"
        Me.colFCPMCPH_FCPM_CODE_FK_PK.Name = "colFCPMCPH_FCPM_CODE_FK_PK"
        '
        'colFCPMCPH_CPH_CODE_FK_PK
        '
        Me.colFCPMCPH_CPH_CODE_FK_PK.Caption = "Code"
        Me.colFCPMCPH_CPH_CODE_FK_PK.FieldName = "FCPMCPH_CPH_CODE_FK_PK"
        Me.colFCPMCPH_CPH_CODE_FK_PK.Name = "colFCPMCPH_CPH_CODE_FK_PK"
        Me.colFCPMCPH_CPH_CODE_FK_PK.Visible = True
        Me.colFCPMCPH_CPH_CODE_FK_PK.VisibleIndex = 0
        Me.colFCPMCPH_CPH_CODE_FK_PK.Width = 50
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Classe pharmaco-thérapeutique"
        Me.GridColumn1.ColumnEdit = Me.rp_FCPMCPH
        Me.GridColumn1.FieldName = "FCPMCPH_CPH_CODE_FK_PK"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 402
        '
        'rp_FCPMCPH
        '
        Me.rp_FCPMCPH.AutoHeight = False
        Me.rp_FCPMCPH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FCPMCPH.Name = "rp_FCPMCPH"
        '
        'GC2
        '
        Me.GC2.DataMember = "FCPMCCH_CIPEMG_CLCH"
        Me.GC2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GC2.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC2.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC2.EmbeddedNavigator.Name = ""
        Me.GC2.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC2.Location = New System.Drawing.Point(439, 0)
        Me.GC2.MainView = Me.GV2
        Me.GC2.Name = "GC2"
        Me.GC2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FCPMCCH})
        Me.GC2.Size = New System.Drawing.Size(347, 125)
        Me.GC2.TabIndex = 3
        Me.GC2.Tag = "[EDIT][ADD]"
        Me.GC2.UseEmbeddedNavigator = True
        Me.GC2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCPMCCH_FCPM_CODE_FK_PK, Me.colFCPMCCH_CCH_CODE_FK_PK, Me.GridColumn2})
        Me.GV2.GridControl = Me.GC2
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV2.OptionsView.ShowGroupPanel = False
        '
        'colFCPMCCH_FCPM_CODE_FK_PK
        '
        Me.colFCPMCCH_FCPM_CODE_FK_PK.Caption = "FCPMCCH_FCPM_CODE_FK_PK"
        Me.colFCPMCCH_FCPM_CODE_FK_PK.FieldName = "FCPMCCH_FCPM_CODE_FK_PK"
        Me.colFCPMCCH_FCPM_CODE_FK_PK.Name = "colFCPMCCH_FCPM_CODE_FK_PK"
        '
        'colFCPMCCH_CCH_CODE_FK_PK
        '
        Me.colFCPMCCH_CCH_CODE_FK_PK.Caption = "Code"
        Me.colFCPMCCH_CCH_CODE_FK_PK.FieldName = "FCPMCCH_CCH_CODE_FK_PK"
        Me.colFCPMCCH_CCH_CODE_FK_PK.Name = "colFCPMCCH_CCH_CODE_FK_PK"
        Me.colFCPMCCH_CCH_CODE_FK_PK.Visible = True
        Me.colFCPMCCH_CCH_CODE_FK_PK.VisibleIndex = 0
        Me.colFCPMCCH_CCH_CODE_FK_PK.Width = 50
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Classe chimique"
        Me.GridColumn2.ColumnEdit = Me.rp_FCPMCCH
        Me.GridColumn2.FieldName = "FCPMCCH_CCH_CODE_FK_PK"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 232
        '
        'rp_FCPMCCH
        '
        Me.rp_FCPMCCH.AutoHeight = False
        Me.rp_FCPMCCH.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FCPMCCH.Name = "rp_FCPMCCH"
        '
        'XTabPage_Terrain
        '
        Me.XTabPage_Terrain.Controls.Add(Me.Panel5)
        Me.XTabPage_Terrain.Name = "XTabPage_Terrain"
        Me.XTabPage_Terrain.Size = New System.Drawing.Size(503, 390)
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel12)
        Me.Panel5.Controls.Add(Me.Panel11)
        Me.Panel5.Controls.Add(Me.Panel10)
        Me.Panel5.Controls.Add(Me.Panel9)
        Me.Panel5.Controls.Add(Me.Panel2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(503, 390)
        Me.Panel5.TabIndex = 41
        Me.Panel5.Tag = ""
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.Panel27)
        Me.Panel12.Controls.Add(Me.Panel28)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(0, 372)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(503, 18)
        Me.Panel12.TabIndex = 45
        Me.Panel12.Tag = ""
        '
        'Panel27
        '
        Me.Panel27.Controls.Add(Me.GC27)
        Me.Panel27.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel27.Location = New System.Drawing.Point(0, 19)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(503, 0)
        Me.Panel27.TabIndex = 38
        Me.Panel27.Tag = "[ADD][EDIT]"
        '
        'GC27
        '
        Me.GC27.DataMember = "FCPMTER_FCPM_TERRAIN.FK_FCPMTX_FCPMTER"
        Me.GC27.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC27.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC27.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC27.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.GC27.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC27.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.GC27.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC27.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.GC27.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC27.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.GC27.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC27.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.GC27.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC27.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.GC27.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC27.EmbeddedNavigator.Name = ""
        Me.GC27.EmbeddedNavigator.TextStringFormat = ""
        Me.GC27.Location = New System.Drawing.Point(0, 0)
        Me.GC27.MainView = Me.GV27
        Me.GC27.Name = "GC27"
        Me.GC27.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rm_Memo1})
        Me.GC27.Size = New System.Drawing.Size(503, 0)
        Me.GC27.TabIndex = 5
        Me.GC27.UseEmbeddedNavigator = True
        Me.GC27.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV27})
        '
        'GV27
        '
        Me.GV27.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCPMTX_FCPM_CODE_FK_PK, Me.colFCPMTX_CDF_TER_CODE_FK_PK, Me.colFCPMTX_NUMSEQ_TER_FK_PK, Me.colFCPMTX_NATURECIPEMG_FK_PK, Me.colFCPMTX_TEXTE})
        Me.GV27.GridControl = Me.GC27
        Me.GV27.GroupFormat = ""
        Me.GV27.GroupPanelText = " "
        Me.GV27.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GV27.Name = "GV27"
        Me.GV27.OptionsCustomization.AllowRowSizing = True
        Me.GV27.OptionsNavigation.AutoFocusNewRow = True
        Me.GV27.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV27.OptionsView.ShowColumnHeaders = False
        Me.GV27.OptionsView.ShowDetailButtons = False
        Me.GV27.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV27.OptionsView.ShowGroupPanel = False
        Me.GV27.OptionsView.ShowHorzLines = False
        Me.GV27.OptionsView.ShowIndicator = False
        Me.GV27.RowHeight = 72
        Me.GV27.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colFCPMTX_FCPM_CODE_FK_PK
        '
        Me.colFCPMTX_FCPM_CODE_FK_PK.Caption = "FCPMTX_FCPM_CODE_FK_PK"
        Me.colFCPMTX_FCPM_CODE_FK_PK.FieldName = "FCPMTX_FCPM_CODE_FK_PK"
        Me.colFCPMTX_FCPM_CODE_FK_PK.Name = "colFCPMTX_FCPM_CODE_FK_PK"
        '
        'colFCPMTX_CDF_TER_CODE_FK_PK
        '
        Me.colFCPMTX_CDF_TER_CODE_FK_PK.Caption = "FCPMTX_CDF_TER_CODE_FK_PK"
        Me.colFCPMTX_CDF_TER_CODE_FK_PK.FieldName = "FCPMTX_CDF_TER_CODE_FK_PK"
        Me.colFCPMTX_CDF_TER_CODE_FK_PK.Name = "colFCPMTX_CDF_TER_CODE_FK_PK"
        '
        'colFCPMTX_NUMSEQ_TER_FK_PK
        '
        Me.colFCPMTX_NUMSEQ_TER_FK_PK.Caption = "FCPMTX_NUMSEQ_TER_FK_PK"
        Me.colFCPMTX_NUMSEQ_TER_FK_PK.FieldName = "FCPMTX_NUMSEQ_TER_FK_PK"
        Me.colFCPMTX_NUMSEQ_TER_FK_PK.Name = "colFCPMTX_NUMSEQ_TER_FK_PK"
        '
        'colFCPMTX_NATURECIPEMG_FK_PK
        '
        Me.colFCPMTX_NATURECIPEMG_FK_PK.Caption = "FCPMTX_NATURECIPEMG_FK_PK"
        Me.colFCPMTX_NATURECIPEMG_FK_PK.FieldName = "FCPMTX_NATURECIPEMG_FK_PK"
        Me.colFCPMTX_NATURECIPEMG_FK_PK.Name = "colFCPMTX_NATURECIPEMG_FK_PK"
        '
        'colFCPMTX_TEXTE
        '
        Me.colFCPMTX_TEXTE.Caption = "FCPMTX_TEXTE"
        Me.colFCPMTX_TEXTE.ColumnEdit = Me.rm_Memo1
        Me.colFCPMTX_TEXTE.FieldName = "FCPMTX_TEXTE"
        Me.colFCPMTX_TEXTE.Name = "colFCPMTX_TEXTE"
        Me.colFCPMTX_TEXTE.Visible = True
        Me.colFCPMTX_TEXTE.VisibleIndex = 0
        '
        'rm_Memo1
        '
        Me.rm_Memo1.Name = "rm_Memo1"
        '
        'Panel28
        '
        Me.Panel28.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel28.Controls.Add(Me.LabelControl7)
        Me.Panel28.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel28.Location = New System.Drawing.Point(0, 0)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(503, 19)
        Me.Panel28.TabIndex = 37
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(9, 3)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl7.TabIndex = 19
        Me.LabelControl7.Text = "Texte"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Panel15)
        Me.Panel11.Controls.Add(Me.Panel13)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 282)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(503, 90)
        Me.Panel11.TabIndex = 32
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.GC26)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel15.Location = New System.Drawing.Point(0, 5)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(503, 85)
        Me.Panel15.TabIndex = 48
        '
        'GC26
        '
        Me.GC26.DataMember = "FCPMTER_FCPM_TERRAIN.FK_AUTCOM_FCPMTER"
        Me.GC26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC26.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC26.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC26.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC26.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC26.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC26.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC26.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC26.EmbeddedNavigator.Name = ""
        Me.GC26.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC26.Location = New System.Drawing.Point(0, 0)
        Me.GC26.MainView = Me.GV26
        Me.GC26.Name = "GC26"
        Me.GC26.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_AUTCOM})
        Me.GC26.Size = New System.Drawing.Size(503, 85)
        Me.GC26.TabIndex = 31
        Me.GC26.Tag = "[EDIT][ADD]"
        Me.GC26.UseEmbeddedNavigator = True
        Me.GC26.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV26})
        '
        'GV26
        '
        Me.GV26.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAUTCOM_FCPM_CODE_FK_PK, Me.colAUTCOM_CDF_TER_CODE_FK_PK, Me.colAUTCOM_NUMSEQ_TER_FK_PK, Me.colAUTCOM_CDF_COM_CODE_FK_PK, Me.colAUTCOM_NATURE_CIPEMG_FK_PK, Me.colAUTCOM_NUMSEQ, Me.GridColumn15})
        Me.GV26.GridControl = Me.GC26
        Me.GV26.Name = "GV26"
        Me.GV26.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV26.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV26.OptionsView.ShowGroupPanel = False
        Me.GV26.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colAUTCOM_NUMSEQ, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colAUTCOM_FCPM_CODE_FK_PK
        '
        Me.colAUTCOM_FCPM_CODE_FK_PK.Caption = "AUTCOM_FCPM_CODE_FK_PK"
        Me.colAUTCOM_FCPM_CODE_FK_PK.FieldName = "AUTCOM_FCPM_CODE_FK_PK"
        Me.colAUTCOM_FCPM_CODE_FK_PK.Name = "colAUTCOM_FCPM_CODE_FK_PK"
        '
        'colAUTCOM_CDF_TER_CODE_FK_PK
        '
        Me.colAUTCOM_CDF_TER_CODE_FK_PK.Caption = "AUTCOM_CDF_TER_CODE_FK_PK"
        Me.colAUTCOM_CDF_TER_CODE_FK_PK.FieldName = "AUTCOM_CDF_TER_CODE_FK_PK"
        Me.colAUTCOM_CDF_TER_CODE_FK_PK.Name = "colAUTCOM_CDF_TER_CODE_FK_PK"
        '
        'colAUTCOM_NUMSEQ_TER_FK_PK
        '
        Me.colAUTCOM_NUMSEQ_TER_FK_PK.Caption = "AUTCOM_NUMSEQ_TER_FK_PK"
        Me.colAUTCOM_NUMSEQ_TER_FK_PK.FieldName = "AUTCOM_NUMSEQ_TER_FK_PK"
        Me.colAUTCOM_NUMSEQ_TER_FK_PK.Name = "colAUTCOM_NUMSEQ_TER_FK_PK"
        '
        'colAUTCOM_CDF_COM_CODE_FK_PK
        '
        Me.colAUTCOM_CDF_COM_CODE_FK_PK.Caption = "Code"
        Me.colAUTCOM_CDF_COM_CODE_FK_PK.FieldName = "AUTCOM_CDF_COM_CODE_FK_PK"
        Me.colAUTCOM_CDF_COM_CODE_FK_PK.Name = "colAUTCOM_CDF_COM_CODE_FK_PK"
        Me.colAUTCOM_CDF_COM_CODE_FK_PK.Visible = True
        Me.colAUTCOM_CDF_COM_CODE_FK_PK.VisibleIndex = 0
        Me.colAUTCOM_CDF_COM_CODE_FK_PK.Width = 50
        '
        'colAUTCOM_NATURE_CIPEMG_FK_PK
        '
        Me.colAUTCOM_NATURE_CIPEMG_FK_PK.Caption = "AUTCOM_NATURE_CIPEMG_FK_PK"
        Me.colAUTCOM_NATURE_CIPEMG_FK_PK.FieldName = "AUTCOM_NATURE_CIPEMG_FK_PK"
        Me.colAUTCOM_NATURE_CIPEMG_FK_PK.Name = "colAUTCOM_NATURE_CIPEMG_FK_PK"
        '
        'colAUTCOM_NUMSEQ
        '
        Me.colAUTCOM_NUMSEQ.Caption = "N°"
        Me.colAUTCOM_NUMSEQ.FieldName = "AUTCOM_NUMSEQ"
        Me.colAUTCOM_NUMSEQ.Name = "colAUTCOM_NUMSEQ"
        Me.colAUTCOM_NUMSEQ.Visible = True
        Me.colAUTCOM_NUMSEQ.VisibleIndex = 2
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Commentaire(s) autre(s)"
        Me.GridColumn15.ColumnEdit = Me.rp_AUTCOM
        Me.GridColumn15.FieldName = "AUTCOM_CDF_COM_CODE_FK_PK"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 1
        Me.GridColumn15.Width = 705
        '
        'rp_AUTCOM
        '
        Me.rp_AUTCOM.AutoHeight = False
        Me.rp_AUTCOM.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_AUTCOM.Name = "rp_AUTCOM"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(503, 5)
        Me.Panel13.TabIndex = 47
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.GC24)
        Me.Panel10.Controls.Add(Me.Panel18)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 194)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(503, 88)
        Me.Panel10.TabIndex = 31
        '
        'GC24
        '
        Me.GC24.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC24.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC24.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GC24.EmbeddedNavigator.Name = ""
        Me.GC24.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC24.Location = New System.Drawing.Point(396, 0)
        Me.GC24.MainView = Me.GV24
        Me.GC24.Name = "GC24"
        Me.GC24.Size = New System.Drawing.Size(107, 88)
        Me.GC24.TabIndex = 29
        Me.GC24.Tag = "[EDIT][ADD]"
        Me.GC24.UseEmbeddedNavigator = True
        Me.GC24.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV24})
        '
        'GV24
        '
        Me.GV24.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.GV24.Appearance.Empty.Options.UseBackColor = True
        Me.GV24.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV24.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV24.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV24.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV24.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV24.Appearance.OddRow.Options.UseBackColor = True
        Me.GV24.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV24.Appearance.Row.Options.UseBackColor = True
        Me.GV24.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn12, Me.GridColumn13})
        Me.GV24.GridControl = Me.GC24
        Me.GV24.Name = "GV24"
        Me.GV24.OptionsBehavior.Editable = False
        Me.GV24.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV24.OptionsView.ShowGroupPanel = False
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Code"
        Me.GridColumn12.FieldName = "CIM_CODE_PK"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 0
        Me.GridColumn12.Width = 50
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "CIM-10 commentaires"
        Me.GridColumn13.FieldName = "CIM_LIBELLE_COURT"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 1
        Me.GridColumn13.Width = 307
        '
        'Panel18
        '
        Me.Panel18.Controls.Add(Me.Panel21)
        Me.Panel18.Controls.Add(Me.Panel20)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel18.Location = New System.Drawing.Point(0, 0)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(396, 88)
        Me.Panel18.TabIndex = 31
        '
        'Panel21
        '
        Me.Panel21.Controls.Add(Me.GC25)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel21.Location = New System.Drawing.Point(0, 5)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(396, 83)
        Me.Panel21.TabIndex = 31
        '
        'GC25
        '
        Me.GC25.DataMember = "FCPMTER_FCPM_TERRAIN.FK_NIVCOM_FCPMTER"
        Me.GC25.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC25.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC25.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC25.EmbeddedNavigator.Name = ""
        Me.GC25.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC25.Location = New System.Drawing.Point(0, 0)
        Me.GC25.MainView = Me.GV25
        Me.GC25.Name = "GC25"
        Me.GC25.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_NIVCOM})
        Me.GC25.Size = New System.Drawing.Size(396, 83)
        Me.GC25.TabIndex = 30
        Me.GC25.Tag = "[EDIT][ADD]"
        Me.GC25.UseEmbeddedNavigator = True
        Me.GC25.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV25})
        '
        'GV25
        '
        Me.GV25.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNIVCOM_FCPM_CODE_FK_PK, Me.colNIVCOM_CDF_TER_CODE_FK_PK, Me.colNIVCOM_NUMSEQ_TER_FK_PK, Me.colNIVCOM_CDF_COM_CODE_FK_PK, Me.colNIVCOM_NATURE_CIPEMG_FK_PK, Me.colNIVCOM_NUMSEQ, Me.GridColumn14})
        Me.GV25.GridControl = Me.GC25
        Me.GV25.Name = "GV25"
        Me.GV25.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV25.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV25.OptionsView.ShowGroupPanel = False
        Me.GV25.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNIVCOM_NUMSEQ, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colNIVCOM_FCPM_CODE_FK_PK
        '
        Me.colNIVCOM_FCPM_CODE_FK_PK.Caption = "NIVCOM_FCPM_CODE_FK_PK"
        Me.colNIVCOM_FCPM_CODE_FK_PK.FieldName = "NIVCOM_FCPM_CODE_FK_PK"
        Me.colNIVCOM_FCPM_CODE_FK_PK.Name = "colNIVCOM_FCPM_CODE_FK_PK"
        '
        'colNIVCOM_CDF_TER_CODE_FK_PK
        '
        Me.colNIVCOM_CDF_TER_CODE_FK_PK.Caption = "NIVCOM_CDF_TER_CODE_FK_PK"
        Me.colNIVCOM_CDF_TER_CODE_FK_PK.FieldName = "NIVCOM_CDF_TER_CODE_FK_PK"
        Me.colNIVCOM_CDF_TER_CODE_FK_PK.Name = "colNIVCOM_CDF_TER_CODE_FK_PK"
        '
        'colNIVCOM_NUMSEQ_TER_FK_PK
        '
        Me.colNIVCOM_NUMSEQ_TER_FK_PK.Caption = "NIVCOM_NUMSEQ_TER_FK_PK"
        Me.colNIVCOM_NUMSEQ_TER_FK_PK.FieldName = "NIVCOM_NUMSEQ_TER_FK_PK"
        Me.colNIVCOM_NUMSEQ_TER_FK_PK.Name = "colNIVCOM_NUMSEQ_TER_FK_PK"
        '
        'colNIVCOM_CDF_COM_CODE_FK_PK
        '
        Me.colNIVCOM_CDF_COM_CODE_FK_PK.Caption = "Code"
        Me.colNIVCOM_CDF_COM_CODE_FK_PK.FieldName = "NIVCOM_CDF_COM_CODE_FK_PK"
        Me.colNIVCOM_CDF_COM_CODE_FK_PK.Name = "colNIVCOM_CDF_COM_CODE_FK_PK"
        Me.colNIVCOM_CDF_COM_CODE_FK_PK.Visible = True
        Me.colNIVCOM_CDF_COM_CODE_FK_PK.VisibleIndex = 0
        Me.colNIVCOM_CDF_COM_CODE_FK_PK.Width = 50
        '
        'colNIVCOM_NATURE_CIPEMG_FK_PK
        '
        Me.colNIVCOM_NATURE_CIPEMG_FK_PK.Caption = "NIVCOM_NATURE_CIPEMG_FK_PK"
        Me.colNIVCOM_NATURE_CIPEMG_FK_PK.FieldName = "NIVCOM_NATURE_CIPEMG_FK_PK"
        Me.colNIVCOM_NATURE_CIPEMG_FK_PK.Name = "colNIVCOM_NATURE_CIPEMG_FK_PK"
        '
        'colNIVCOM_NUMSEQ
        '
        Me.colNIVCOM_NUMSEQ.Caption = "N°"
        Me.colNIVCOM_NUMSEQ.FieldName = "NIVCOM_NUMSEQ"
        Me.colNIVCOM_NUMSEQ.Name = "colNIVCOM_NUMSEQ"
        Me.colNIVCOM_NUMSEQ.Visible = True
        Me.colNIVCOM_NUMSEQ.VisibleIndex = 2
        Me.colNIVCOM_NUMSEQ.Width = 61
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Niveau(x)"
        Me.GridColumn14.ColumnEdit = Me.rp_NIVCOM
        Me.GridColumn14.FieldName = "NIVCOM_CDF_COM_CODE_FK_PK"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 1
        Me.GridColumn14.Width = 240
        '
        'rp_NIVCOM
        '
        Me.rp_NIVCOM.AutoHeight = False
        Me.rp_NIVCOM.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_NIVCOM.Name = "rp_NIVCOM"
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel20.Location = New System.Drawing.Point(0, 0)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(396, 5)
        Me.Panel20.TabIndex = 3
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Transparent
        Me.Panel9.Controls.Add(Me.Panel14)
        Me.Panel9.Controls.Add(Me.GC22)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 95)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(503, 99)
        Me.Panel9.TabIndex = 28
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.Panel19)
        Me.Panel14.Controls.Add(Me.Panel17)
        Me.Panel14.Controls.Add(Me.Panel16)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(396, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(107, 99)
        Me.Panel14.TabIndex = 28
        '
        'Panel19
        '
        Me.Panel19.Controls.Add(Me.GC23)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel19.Location = New System.Drawing.Point(0, 5)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(107, 89)
        Me.Panel19.TabIndex = 5
        '
        'GC23
        '
        Me.GC23.DataMember = "FCPMTER_FCPM_TERRAIN.FK_TERCOM_FCPMTER"
        Me.GC23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC23.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC23.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC23.EmbeddedNavigator.Name = ""
        Me.GC23.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC23.Location = New System.Drawing.Point(0, 0)
        Me.GC23.MainView = Me.GV23
        Me.GC23.Name = "GC23"
        Me.GC23.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_TERCOM})
        Me.GC23.Size = New System.Drawing.Size(107, 89)
        Me.GC23.TabIndex = 2
        Me.GC23.Tag = "[EDIT][ADD]"
        Me.GC23.UseEmbeddedNavigator = True
        Me.GC23.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV23})
        '
        'GV23
        '
        Me.GV23.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTERCOM_FCPM_CODE_FK_PK, Me.colTERCOM_CDF_TER_CODE_FK_PK, Me.colTERCOM_NUMSEQ_TER_FK_PK, Me.colTERCOM_CDF_COM_CODE_FK_PK, Me.colTERCOM_NATURE_CIPEMG_FK_PK, Me.colTERCOM_NUMSEQ, Me.GridColumn11})
        Me.GV23.GridControl = Me.GC23
        Me.GV23.Name = "GV23"
        Me.GV23.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV23.OptionsView.ShowDetailButtons = False
        Me.GV23.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV23.OptionsView.ShowGroupPanel = False
        Me.GV23.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTERCOM_NUMSEQ, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colTERCOM_FCPM_CODE_FK_PK
        '
        Me.colTERCOM_FCPM_CODE_FK_PK.Caption = "TERCOM_FCPM_CODE_FK_PK"
        Me.colTERCOM_FCPM_CODE_FK_PK.FieldName = "TERCOM_FCPM_CODE_FK_PK"
        Me.colTERCOM_FCPM_CODE_FK_PK.Name = "colTERCOM_FCPM_CODE_FK_PK"
        '
        'colTERCOM_CDF_TER_CODE_FK_PK
        '
        Me.colTERCOM_CDF_TER_CODE_FK_PK.Caption = "TERCOM_CDF_TER_CODE_FK_PK"
        Me.colTERCOM_CDF_TER_CODE_FK_PK.FieldName = "TERCOM_CDF_TER_CODE_FK_PK"
        Me.colTERCOM_CDF_TER_CODE_FK_PK.Name = "colTERCOM_CDF_TER_CODE_FK_PK"
        '
        'colTERCOM_NUMSEQ_TER_FK_PK
        '
        Me.colTERCOM_NUMSEQ_TER_FK_PK.Caption = "TERCOM_NUMSEQ_TER_FK_PK"
        Me.colTERCOM_NUMSEQ_TER_FK_PK.FieldName = "TERCOM_NUMSEQ_TER_FK_PK"
        Me.colTERCOM_NUMSEQ_TER_FK_PK.Name = "colTERCOM_NUMSEQ_TER_FK_PK"
        '
        'colTERCOM_CDF_COM_CODE_FK_PK
        '
        Me.colTERCOM_CDF_COM_CODE_FK_PK.Caption = "Code"
        Me.colTERCOM_CDF_COM_CODE_FK_PK.FieldName = "TERCOM_CDF_COM_CODE_FK_PK"
        Me.colTERCOM_CDF_COM_CODE_FK_PK.Name = "colTERCOM_CDF_COM_CODE_FK_PK"
        Me.colTERCOM_CDF_COM_CODE_FK_PK.Visible = True
        Me.colTERCOM_CDF_COM_CODE_FK_PK.VisibleIndex = 0
        Me.colTERCOM_CDF_COM_CODE_FK_PK.Width = 50
        '
        'colTERCOM_NATURE_CIPEMG_FK_PK
        '
        Me.colTERCOM_NATURE_CIPEMG_FK_PK.Caption = "TERCOM_NATURE_CIPEMG_FK_PK"
        Me.colTERCOM_NATURE_CIPEMG_FK_PK.FieldName = "TERCOM_NATURE_CIPEMG_FK_PK"
        Me.colTERCOM_NATURE_CIPEMG_FK_PK.Name = "colTERCOM_NATURE_CIPEMG_FK_PK"
        '
        'colTERCOM_NUMSEQ
        '
        Me.colTERCOM_NUMSEQ.Caption = "N°"
        Me.colTERCOM_NUMSEQ.FieldName = "TERCOM_NUMSEQ"
        Me.colTERCOM_NUMSEQ.Name = "colTERCOM_NUMSEQ"
        Me.colTERCOM_NUMSEQ.Visible = True
        Me.colTERCOM_NUMSEQ.VisibleIndex = 2
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Commentaire(s)"
        Me.GridColumn11.ColumnEdit = Me.rp_TERCOM
        Me.GridColumn11.FieldName = "TERCOM_CDF_COM_CODE_FK_PK"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 1
        Me.GridColumn11.Width = 255
        '
        'rp_TERCOM
        '
        Me.rp_TERCOM.AutoHeight = False
        Me.rp_TERCOM.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_TERCOM.Name = "rp_TERCOM"
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel17.Location = New System.Drawing.Point(0, 94)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(107, 5)
        Me.Panel17.TabIndex = 4
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel16.Location = New System.Drawing.Point(0, 0)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(107, 5)
        Me.Panel16.TabIndex = 3
        '
        'GC22
        '
        Me.GC22.Dock = System.Windows.Forms.DockStyle.Left
        Me.GC22.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC22.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GC22.EmbeddedNavigator.Name = ""
        Me.GC22.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC22.Location = New System.Drawing.Point(0, 0)
        Me.GC22.MainView = Me.GV22
        Me.GC22.Name = "GC22"
        Me.GC22.Size = New System.Drawing.Size(396, 99)
        Me.GC22.TabIndex = 27
        Me.GC22.Tag = "[EDIT][ADD]"
        Me.GC22.UseEmbeddedNavigator = True
        Me.GC22.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV22})
        '
        'GV22
        '
        Me.GV22.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.GV22.Appearance.Empty.Options.UseBackColor = True
        Me.GV22.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV22.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV22.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV22.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV22.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV22.Appearance.OddRow.Options.UseBackColor = True
        Me.GV22.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV22.Appearance.Row.Options.UseBackColor = True
        Me.GV22.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn9, Me.GridColumn10})
        Me.GV22.GridControl = Me.GC22
        Me.GV22.Name = "GV22"
        Me.GV22.OptionsBehavior.Editable = False
        Me.GV22.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV22.OptionsView.ShowGroupPanel = False
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Code"
        Me.GridColumn9.FieldName = "CIM_CODE_PK"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowFocus = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 0
        Me.GridColumn9.Width = 50
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "CIM-10 terrain"
        Me.GridColumn10.FieldName = "CIM_LIBELLE_COURT"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowFocus = False
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 1
        Me.GridColumn10.Width = 232
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GC21)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(503, 95)
        Me.Panel2.TabIndex = 26
        '
        'GC21
        '
        Me.GC21.DataMember = "FCPMTER_FCPM_TERRAIN"
        Me.GC21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC21.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC21.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC21.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC21.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC21.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC21.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC21.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC21.EmbeddedNavigator.Name = ""
        Me.GC21.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC21.Location = New System.Drawing.Point(0, 0)
        Me.GC21.MainView = Me.GV21
        Me.GC21.Name = "GC21"
        Me.GC21.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FCPMTER, Me.lkupATCD, Me.lkATCD})
        Me.GC21.Size = New System.Drawing.Size(503, 95)
        Me.GC21.TabIndex = 3
        Me.GC21.Tag = "[EDIT][ADD]"
        Me.GC21.UseEmbeddedNavigator = True
        Me.GC21.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV21})
        '
        'GV21
        '
        Me.GV21.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCPMTER_FCPM_CODE_FK_PK, Me.colFCPMTER_CDF_TER_CODE_FK_PK, Me.colFCPMTER_NUMSEQ_PK, Me.colFCPMTER_NUMORD, Me.GridColumn8, Me.colFCPMTER_NATURE_CIPEMG_PK, Me.colATCD})
        Me.GV21.GridControl = Me.GC21
        Me.GV21.Name = "GV21"
        Me.GV21.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV21.OptionsView.ShowDetailButtons = False
        Me.GV21.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV21.OptionsView.ShowGroupPanel = False
        '
        'colFCPMTER_FCPM_CODE_FK_PK
        '
        Me.colFCPMTER_FCPM_CODE_FK_PK.Caption = "FCPMTER_FCPM_CODE_FK_PK"
        Me.colFCPMTER_FCPM_CODE_FK_PK.FieldName = "FCPMTER_FCPM_CODE_FK_PK"
        Me.colFCPMTER_FCPM_CODE_FK_PK.Name = "colFCPMTER_FCPM_CODE_FK_PK"
        '
        'colFCPMTER_CDF_TER_CODE_FK_PK
        '
        Me.colFCPMTER_CDF_TER_CODE_FK_PK.Caption = "Code"
        Me.colFCPMTER_CDF_TER_CODE_FK_PK.FieldName = "FCPMTER_CDF_TER_CODE_FK_PK"
        Me.colFCPMTER_CDF_TER_CODE_FK_PK.Name = "colFCPMTER_CDF_TER_CODE_FK_PK"
        Me.colFCPMTER_CDF_TER_CODE_FK_PK.Visible = True
        Me.colFCPMTER_CDF_TER_CODE_FK_PK.VisibleIndex = 2
        Me.colFCPMTER_CDF_TER_CODE_FK_PK.Width = 80
        '
        'colFCPMTER_NUMSEQ_PK
        '
        Me.colFCPMTER_NUMSEQ_PK.Caption = "FCPMTER_NUMSEQ_PK"
        Me.colFCPMTER_NUMSEQ_PK.FieldName = "FCPMTER_NUMSEQ_PK"
        Me.colFCPMTER_NUMSEQ_PK.Name = "colFCPMTER_NUMSEQ_PK"
        Me.colFCPMTER_NUMSEQ_PK.Width = 342
        '
        'colFCPMTER_NUMORD
        '
        Me.colFCPMTER_NUMORD.Caption = "Terrain n°"
        Me.colFCPMTER_NUMORD.FieldName = "FCPMTER_NUMORD"
        Me.colFCPMTER_NUMORD.Name = "colFCPMTER_NUMORD"
        Me.colFCPMTER_NUMORD.Tag = ""
        Me.colFCPMTER_NUMORD.Visible = True
        Me.colFCPMTER_NUMORD.VisibleIndex = 0
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Libellé"
        Me.GridColumn8.ColumnEdit = Me.rp_FCPMTER
        Me.GridColumn8.FieldName = "FCPMTER_CDF_TER_CODE_FK_PK"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        Me.GridColumn8.Width = 600
        '
        'rp_FCPMTER
        '
        Me.rp_FCPMTER.AutoHeight = False
        Me.rp_FCPMTER.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FCPMTER.Name = "rp_FCPMTER"
        '
        'colFCPMTER_NATURE_CIPEMG_PK
        '
        Me.colFCPMTER_NATURE_CIPEMG_PK.Caption = "FCPMTER_NATURE_CIPEMG_PK"
        Me.colFCPMTER_NATURE_CIPEMG_PK.FieldName = "FCPMTER_NATURE_CIPEMG_PK"
        Me.colFCPMTER_NATURE_CIPEMG_PK.Name = "colFCPMTER_NATURE_CIPEMG_PK"
        '
        'colATCD
        '
        Me.colATCD.Caption = "ATCD"
        Me.colATCD.ColumnEdit = Me.lkupATCD
        Me.colATCD.FieldName = "FCPMTER_ATCD"
        Me.colATCD.Name = "colATCD"
        Me.colATCD.Visible = True
        Me.colATCD.VisibleIndex = 3
        '
        'lkupATCD
        '
        Me.lkupATCD.AutoHeight = False
        Me.lkupATCD.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupATCD.Name = "lkupATCD"
        '
        'lkATCD
        '
        Me.lkATCD.AutoHeight = False
        Me.lkATCD.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkATCD.Name = "lkATCD"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Panel51)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(503, 390)
        Me.XtraTabPage2.Text = "Références officielles"
        '
        'Panel51
        '
        Me.Panel51.Controls.Add(Me.GC31)
        Me.Panel51.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel51.Location = New System.Drawing.Point(0, 0)
        Me.Panel51.Name = "Panel51"
        Me.Panel51.Size = New System.Drawing.Size(503, 390)
        Me.Panel51.TabIndex = 45
        '
        'GC31
        '
        Me.GC31.DataMember = "FCPMAFS_CIPEMG_AFSSAPS"
        Me.GC31.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC31.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GC31.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GC31.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GC31.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GC31.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GC31.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GC31.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GC31.EmbeddedNavigator.Name = ""
        Me.GC31.EmbeddedNavigator.TextStringFormat = " {0} - Total {1}"
        Me.GC31.Location = New System.Drawing.Point(0, 0)
        Me.GC31.MainView = Me.GV31
        Me.GC31.Name = "GC31"
        Me.GC31.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rp_FCPMAFS, Me.rp_FCPMAFS_SP})
        Me.GC31.Size = New System.Drawing.Size(503, 390)
        Me.GC31.TabIndex = 2
        Me.GC31.Tag = "[EDIT][ADD]"
        Me.GC31.UseEmbeddedNavigator = True
        Me.GC31.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV31})
        '
        'GV31
        '
        Me.GV31.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFCPMAFS_FCPM_CODE_FK_PK, Me.colFCPMAFS_SP_CODE_FK_PK, Me.colFCPMAFS_DATE_PK, Me.colFCPMAFS_CDF_DOCUMENT_FK_PK})
        Me.GV31.GridControl = Me.GC31
        Me.GV31.Name = "GV31"
        Me.GV31.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV31.OptionsView.ShowGroupPanel = False
        '
        'colFCPMAFS_FCPM_CODE_FK_PK
        '
        Me.colFCPMAFS_FCPM_CODE_FK_PK.Caption = "FCPMAFS_FCPM_CODE_FK_PK"
        Me.colFCPMAFS_FCPM_CODE_FK_PK.FieldName = "FCPMAFS_FCPM_CODE_FK_PK"
        Me.colFCPMAFS_FCPM_CODE_FK_PK.Name = "colFCPMAFS_FCPM_CODE_FK_PK"
        '
        'colFCPMAFS_SP_CODE_FK_PK
        '
        Me.colFCPMAFS_SP_CODE_FK_PK.Caption = "Spécialités"
        Me.colFCPMAFS_SP_CODE_FK_PK.ColumnEdit = Me.rp_FCPMAFS_SP
        Me.colFCPMAFS_SP_CODE_FK_PK.FieldName = "FCPMAFS_SP_CODE_FK_PK"
        Me.colFCPMAFS_SP_CODE_FK_PK.Name = "colFCPMAFS_SP_CODE_FK_PK"
        Me.colFCPMAFS_SP_CODE_FK_PK.Visible = True
        Me.colFCPMAFS_SP_CODE_FK_PK.VisibleIndex = 2
        Me.colFCPMAFS_SP_CODE_FK_PK.Width = 374
        '
        'rp_FCPMAFS_SP
        '
        Me.rp_FCPMAFS_SP.AutoHeight = False
        Me.rp_FCPMAFS_SP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FCPMAFS_SP.Name = "rp_FCPMAFS_SP"
        Me.rp_FCPMAFS_SP.NullText = ""
        '
        'colFCPMAFS_DATE_PK
        '
        Me.colFCPMAFS_DATE_PK.Caption = "Date"
        Me.colFCPMAFS_DATE_PK.FieldName = "FCPMAFS_DATE_PK"
        Me.colFCPMAFS_DATE_PK.Name = "colFCPMAFS_DATE_PK"
        Me.colFCPMAFS_DATE_PK.Visible = True
        Me.colFCPMAFS_DATE_PK.VisibleIndex = 1
        Me.colFCPMAFS_DATE_PK.Width = 93
        '
        'colFCPMAFS_CDF_DOCUMENT_FK_PK
        '
        Me.colFCPMAFS_CDF_DOCUMENT_FK_PK.Caption = "Références officielles"
        Me.colFCPMAFS_CDF_DOCUMENT_FK_PK.ColumnEdit = Me.rp_FCPMAFS
        Me.colFCPMAFS_CDF_DOCUMENT_FK_PK.FieldName = "FCPMAFS_CDF_DOCUMENT_FK_PK"
        Me.colFCPMAFS_CDF_DOCUMENT_FK_PK.Name = "colFCPMAFS_CDF_DOCUMENT_FK_PK"
        Me.colFCPMAFS_CDF_DOCUMENT_FK_PK.Visible = True
        Me.colFCPMAFS_CDF_DOCUMENT_FK_PK.VisibleIndex = 0
        Me.colFCPMAFS_CDF_DOCUMENT_FK_PK.Width = 298
        '
        'rp_FCPMAFS
        '
        Me.rp_FCPMAFS.AutoHeight = False
        Me.rp_FCPMAFS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rp_FCPMAFS.Name = "rp_FCPMAFS"
        '
        'FcpmcpH_TA
        '
        Me.FcpmcpH_TA.ClearBeforeFill = True
        '
        'FcpmccH_TA
        '
        Me.FcpmccH_TA.ClearBeforeFill = True
        '
        'FcpmcH_TA
        '
        Me.FcpmcH_TA.ClearBeforeFill = True
        '
        'FcpmpR_TA
        '
        Me.FcpmpR_TA.ClearBeforeFill = True
        '
        'FcpmsaC_TA
        '
        Me.FcpmsaC_TA.ClearBeforeFill = True
        '
        'FcpmsaU_TA
        '
        Me.FcpmsaU_TA.ClearBeforeFill = True
        '
        'FcpmsP_TA
        '
        Me.FcpmsP_TA.ClearBeforeFill = True
        '
        'FcpmteR_TA
        '
        Me.FcpmteR_TA.ClearBeforeFill = True
        '
        'TercoM_TA
        '
        Me.TercoM_TA.ClearBeforeFill = True
        '
        'NivcoM_TA
        '
        Me.NivcoM_TA.ClearBeforeFill = True
        '
        'AutcoM_TA
        '
        Me.AutcoM_TA.ClearBeforeFill = True
        '
        'FcpmtX_TA
        '
        Me.FcpmtX_TA.ClearBeforeFill = True
        '
        'FcpmafS_TA
        '
        Me.FcpmafS_TA.ClearBeforeFill = True
        '
        'Frm_Cipemg_Code
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(913, 665)
        Me.Name = "Frm_Cipemg_Code"
        Me.Text = "Cipemg - Fiche code"
        Me.Pan.ResumeLayout(False)
        Me.PanMain.ResumeLayout(False)
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTheriaque_Cipemg_Code, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cmbOrigine.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.RG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.GC7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FCPMSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        CType(Me.GC5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FCPMPR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FCPMCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.GC3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FCPMSAC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FCPMSAU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FCPMCPH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FCPMCCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTabPage_Terrain.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel27.ResumeLayout(False)
        CType(Me.GC27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rm_Memo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel28.ResumeLayout(False)
        Me.Panel28.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        CType(Me.GC26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_AUTCOM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        CType(Me.GC24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV24, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel18.ResumeLayout(False)
        Me.Panel21.ResumeLayout(False)
        CType(Me.GC25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_NIVCOM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        CType(Me.GC23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_TERCOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV22, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GC21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FCPMTER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupATCD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkATCD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.Panel51.ResumeLayout(False)
        CType(Me.GC31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FCPMAFS_SP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_FCPMAFS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DsTheriaque_Cipemg_Code As Theriaque.dsTheriaque_Cipemg_Code
    Friend WithEvents FcpM_TA As Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.FCPM_FICHECIPEMGTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents GC5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC6 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents GC3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GC1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GC2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XTabPage_Terrain As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents GC7 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFCPMCPH_FCPM_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPMCPH_CPH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FCPMCPH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFCPMCCH_FCPM_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPMCCH_CCH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FCPMCCH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FcpmcpH_TA As Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.FCPMCPH_CIPEMG_CLPHTableAdapter
    Friend WithEvents FcpmccH_TA As Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.FCPMCCH_CIPEMG_CLCHTableAdapter
    Friend WithEvents FcpmcH_TA As Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.FCPMCH_CIPEMGCHTableAdapter
    Friend WithEvents FcpmpR_TA As Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.FCPMPR_CIPEMG_PRODTableAdapter
    Friend WithEvents FcpmsaC_TA As Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.FCPMSAC_CIPEMG_SUBACTableAdapter
    Friend WithEvents FcpmsaU_TA As Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.FCPMSAU_CIPEMG_SUBAUTableAdapter
    Friend WithEvents FcpmsP_TA As Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.FCPMSP_CIPEMG_SPETableAdapter
    Friend WithEvents colFCPMSAC_FCPM_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPMSAC_SAC_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FCPMSAC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFCPMSAU_FCPM_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPMSAU_SAU_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPMSP_FCPM_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPMSP_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FCPMSP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFCPMPR_FCPM_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPMPR_PR_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FCPMPR As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFCPMCH_FCPM_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPMCH_CH_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPMCH_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FCPMCH As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FCPMSAU As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FcpmteR_TA As Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.FCPMTER_FCPM_TERRAINTableAdapter
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GC21 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV21 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFCPMTER_FCPM_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPMTER_CDF_TER_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPMTER_NUMSEQ_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPMTER_NUMORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FCPMTER As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPMTER_NATURE_CIPEMG_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RG As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GC22 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV22 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents GC23 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV23 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TercoM_TA As Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.TERCOM_TERRAIN_COMMENTAIRETableAdapter
    Friend WithEvents colTERCOM_FCPM_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTERCOM_CDF_TER_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTERCOM_NUMSEQ_TER_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTERCOM_CDF_COM_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_TERCOM As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colTERCOM_NATURE_CIPEMG_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTERCOM_NUMSEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GC24 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV24 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GC25 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV25 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents colNIVCOM_FCPM_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNIVCOM_CDF_TER_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNIVCOM_NUMSEQ_TER_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNIVCOM_CDF_COM_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNIVCOM_NATURE_CIPEMG_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNIVCOM_NUMSEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_NIVCOM As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NivcoM_TA As Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.NIVCOM_NIVEAU_COMMENTAIRETableAdapter
    Friend WithEvents AutcoM_TA As Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.AUTCOM_AUTRE_COMMENTAIRETableAdapter
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents GC26 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV26 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAUTCOM_FCPM_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAUTCOM_CDF_TER_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAUTCOM_NUMSEQ_TER_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAUTCOM_CDF_COM_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAUTCOM_NATURE_CIPEMG_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAUTCOM_NUMSEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_AUTCOM As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel27 As System.Windows.Forms.Panel
    Friend WithEvents GC27 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV27 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel28 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colFCPMTX_FCPM_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPMTX_CDF_TER_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPMTX_NUMSEQ_TER_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPMTX_NATURECIPEMG_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPMTX_TEXTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rm_Memo1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents FcpmtX_TA As Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.FCPMTX_FICHECIPEMG_TEXTETableAdapter
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel51 As System.Windows.Forms.Panel
    Friend WithEvents GC31 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV31 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FcpmafS_TA As Theriaque.dsTheriaque_Cipemg_CodeTableAdapters.FCPMAFS_CIPEMG_AFSSAPSTableAdapter
    Friend WithEvents colFCPMAFS_FCPM_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPMAFS_SP_CODE_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCPMAFS_DATE_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FCPMAFS_SP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFCPMAFS_CDF_DOCUMENT_FK_PK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_FCPMAFS As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbOrigine As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents colATCD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkupATCD As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lkATCD As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

End Class
