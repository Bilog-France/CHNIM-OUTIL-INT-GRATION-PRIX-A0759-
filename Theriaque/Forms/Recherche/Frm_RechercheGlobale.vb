''' <summary>
''' Created By [BFE]
''' </summary>
''' <remarks> Recherches - Recherche globale </remarks>
Public Class Frm_RechercheGlobale

#Region "Déclaration des variables"
    Dim CodE As Integer
#End Region

#Region " Edit Data  "
    ''' <summary>
    ''' Fonction: Recherche et retour des données de la fiche
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks>Fonction surchargée</remarks>
    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_SP_SPECIALITE
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            OnLoading = True
            XtraTabControl1.SelectedTabPageIndex = 0
            ProgressBar.Visible = True
            txtCode.Text = CodE
            txtLibelle.Text = ClsSP.GetLibelle(CodE)
            BackgroundWorkerMonograhie_DoWork()
            OnLoading = False
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region " Init Data  "
    ''' <summary>
    ''' Proçédure: Récupération des données par code de chaque fiche module monographie
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BackgroundWorkerMonograhie_DoWork()
        ProgressBar.Visible = True
        Dim strSSQL As String = ""

        'étiologie
        strSSQL = " Select distinct cast(FETSP_FET_CODE_FK_PK as varchar) as code from THERIAQUE.FETSP_ETIOSPE "
        strSSQL &= " where FETSP_SP_CODE_FK_PK  = " & CodE
        GC3.DataSource = cn.MySelect(strSSQL)
        Application.DoEvents()


        'Présentation
        strSSQL = " Select distinct cast(PRE_CODE_PK as varchar) as code from THERIAQUE.PRE_PRESENTATION "
        strSSQL &= " where PRE_SP_CODE_FK  = " & CodE
        GC.DataSource = cn.MySelect(strSSQL)
        Application.DoEvents()


        'pharmacocinétique
        strSSQL = " Select distinct cast(FPHCOSP_FPHCO_CODE_FK_PK as varchar) as code from THERIAQUE.FPHCOSP_PHARMACOCIN_SPEC"
        strSSQL &= " where FPHCOSP_SP_CODE_FK_PK  = " & CodE
        GC5.DataSource = cn.MySelect(strSSQL)
        Application.DoEvents()

        'sécurité préclinique
        strSSQL = " Select distinct cast(FPRCLSP_FPRCL_CODE_FK_PK as varchar) as code from THERIAQUE.FPRCLSP_SECPRECLIN_SPEC"
        strSSQL &= " where FPRCLSP_SP_CODE_FK_PK  = " & CodE
        GC7.DataSource = cn.MySelect(strSSQL)
        Application.DoEvents()

        'indication
        strSSQL = " Select distinct cast(FINSP_FIN_CODE_FK_PK as varchar) as code from THERIAQUE.FINSP_INDSPE "
        strSSQL &= " where FINSP_SP_CODE_FK_PK  = " & CodE
        GC9.DataSource = cn.MySelect(strSSQL)
        Application.DoEvents()

        'posologie
        strSSQL = " Select distinct cast(FPOSP_FPO_CODE_FK_PK as varchar) as code from THERIAQUE.FPOSP_POSO_SPE "
        strSSQL &= " where FPOSP_SP_CODE_FK_PK = " & CodE
        GC11.DataSource = cn.MySelect(strSSQL)
        Application.DoEvents()

        'reconst/aDminist
        strSSQL = " Select distinct cast(FRECSP_FREC_CODE_FK_PK as varchar) as code from THERIAQUE.FRECSP_RECONST_SPEC "
        strSSQL &= " where FRECSP_SP_CODE_FK_PK = " & CodE
        GC12.DataSource = cn.MySelect(strSSQL)
        Application.DoEvents()

        'Cipemg code 
        strSSQL = " Select distinct cast(FCPMSP_FCPM_CODE_FK_PK as varchar) as code from THERIAQUE.FCPMSP_CIPEMG_SPE "
        strSSQL &= " where FCPMSP_SP_CODE_FK_PK  = " & CodE
        GC14.DataSource = cn.MySelect(strSSQL)
        Application.DoEvents()

        'cipemg texte
        strSSQL = " Select distinct cast(FCPTSP_FCPT_CODE_FK_PK as varchar) as code from THERIAQUE.FCPTSP_CIPEMG_SPE"
        strSSQL &= " where FCPTSP_SP_CODE_FK_PK  = " & CodE
        GC2.DataSource = cn.MySelect(strSSQL)
        Application.DoEvents()

        'interaction RCP
        strSSQL = " Select distinct cast(FIRCPSP_FIRCP_CODE_FK_PK as varchar) as code from THERIAQUE.FIRCPSP_INTERACTRCP_SPEC "
        strSSQL &= " where FIRCPSP_SP_CODE_FK_PK  = " & CodE
        GC4.DataSource = cn.MySelect(strSSQL)
        Application.DoEvents()

        'grossesse et allaitement
        strSSQL = " Select distinct cast(FGASP_FGA_CODE_FK_PK as varchar) as code from THERIAQUE.FGASP_GRALSPE"
        strSSQL &= " where FGASP_SP_CODE_FK_PK  = " & CodE
        GC6.DataSource = cn.MySelect(strSSQL)
        Application.DoEvents()

        'conducteur
        strSSQL = " Select distinct cast(FCOSP_FCO_CODE_FK_PK as varchar) as code from THERIAQUE.FCOSP_CONDUCTEUR_SPEC "
        strSSQL &= " where FCOSP_SP_CODE_FK_PK  = " & CodE
        GC8.DataSource = cn.MySelect(strSSQL)
        Application.DoEvents()

        'effets indésirables
        strSSQL = " Select distinct cast(FEISP_FEI_CODE_FK_PK as varchar) as code from THERIAQUE.FEISP_EFFINDSPE"
        strSSQL &= " where FEISP_SP_CODE_FK_PK  = " & CodE
        GC10.DataSource = cn.MySelect(strSSQL)
        Application.DoEvents()

        'posologie Min max
        strSSQL = " Select distinct cast(FPOMMSP_FPOMM_CODE_FK_PK as varchar) as code from THERIAQUE.FPOMMSP_POSOMINMAX_SPE "
        strSSQL &= " where FPOMMSP_SP_CODE_FK_PK = " & CodE
        GC15.DataSource = cn.MySelect(strSSQL)
        Application.DoEvents()




        ProgressBar.Visible = False

    End Sub

    ''' <summary>
    ''' Proçédure: Récupération des données par code de chaque fiche module Critéres de choix
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BackgroundWorkerChoix_DoWork()
        Dim strSSQL As String = ""

        'Fiche Transparence
        strSSQL = " Select distinct cast(SPFTR_FTR_CODE_FK_PK as varchar) as code from THERIAQUE.SPFTR_SPECIALITE_TRANSPARENCE "
        strSSQL &= " where SPFTR_SP_CODE_FK_PK  = " & CodE
        GC21.DataSource = cn.MySelect(strSSQL)
        Application.DoEvents()

        'Commission de la Transparence
        strSSQL = " Select distinct cast(SPATR_ATR_CODE_FK_PK as varchar) as code from THERIAQUE.SPATR_SPEC_AVISTRANSPARENCE "
        strSSQL &= " where SPATR_SP_CODE_FK_PK  = " & CodE
        GC22.DataSource = cn.MySelect(strSSQL)
        Application.DoEvents()

        'RMO
        strSSQL = " Select distinct cast(SPRMO_RMO_CODE_FK_PK as varchar) as code from THERIAQUE.SPRMO_SPECIALITE_RMO "
        strSSQL &= " where SPRMO_SP_CODE_FK_PK  = " & CodE
        GC23.DataSource = cn.MySelect(strSSQL)
        Application.DoEvents()

        'Info Thérapeutique
        strSSQL = " Select distinct cast(SPFTH_FTH_CODE_FK_PK as varchar) as code from THERIAQUE.SPFTH_SPEC_INFOTHERAPEUTIQUE "
        strSSQL &= " where SPFTH_SP_CODE_FK_PK  = " & CodE
        GC24.DataSource = cn.MySelect(strSSQL)
        Application.DoEvents()

        'Critéres de choix
        strSSQL = " Select distinct cast(SPCH_CH_CODE_FK_PK as varchar) as code from THERIAQUE.SPCH_SPECIALITE_CHOIX "
        strSSQL &= " where SPCH_SP_CODE_FK_PK  = " & CodE
        GC25.DataSource = cn.MySelect(strSSQL)
        Application.DoEvents()

    End Sub

#End Region

#Region " Button click  "
    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche Etiologie
    ''' </summary>
    ''' <param name="sender">rpbtEdit2</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    Private Sub rpbtEdit2_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit2.ButtonClick
        If Me.GV3.GetFocusedRowCellValue(Me.col1_Etio) IsNot Nothing Then
            Dim f As New Frm_Etiologie
            f._Code = Me.GV3.GetFocusedRowCellValue(Me.col1_Etio)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche Présentation
    ''' </summary>
    ''' <param name="sender">rpbtEdit1</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    ''' 

    Private Sub rpbtEdit1_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit1.ButtonClick
        If Me.GV.GetFocusedRowCellValue(Me.col1_PR) IsNot Nothing Then
            Dim f As New Frm_Presentation
            f._Code = Me.GV.GetFocusedRowCellValue(Me.col1_PR)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche pharmacocinétique
    ''' </summary>
    ''' <param name="sender">rpbtEdit3</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    Private Sub rpbtEdit3_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit3.ButtonClick
        If Me.GV5.GetFocusedRowCellValue(Me.col1_Pharma) IsNot Nothing Then
            Dim f As New Frm_Pharmacocinetique
            f._Code = Me.GV5.GetFocusedRowCellValue(Me.col1_Pharma)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche Sécurité préclinique
    ''' </summary>
    ''' <param name="sender">rpbtEdit4</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    Private Sub rpbtEdit4_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit4.ButtonClick
        If Me.GV7.GetFocusedRowCellValue(Me.col1_SecPr) IsNot Nothing Then
            Dim f As New Frm_Securite_Preclinique
            f._Code = Me.GV7.GetFocusedRowCellValue(Me.col1_SecPr)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche indication
    ''' </summary>
    ''' <param name="sender">rpbtEdit5</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    Private Sub rpbtEdit5_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit5.ButtonClick
        If Me.GV9.GetFocusedRowCellValue(Me.col1_Indic) IsNot Nothing Then
            Dim f As New Frm_Indication
            f._Code = Me.GV9.GetFocusedRowCellValue(Me.col1_Indic)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche posologie
    ''' </summary>
    ''' <param name="sender">rpbtEdit11</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    Private Sub rpbtEdit11_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit11.ButtonClick
        If Me.GV11.GetFocusedRowCellValue(Me.col1_Poso) IsNot Nothing Then
            Dim f As New Frm_Posologie
            f._Code = Me.GV11.GetFocusedRowCellValue(Me.col1_Poso)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche Reconst/Administ
    ''' </summary>
    ''' <param name="sender">rpbtEdit12</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    Private Sub rpbtEdit12_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit12.ButtonClick
        If Me.GV12.GetFocusedRowCellValue(Me.col1_RecAdmin) IsNot Nothing Then
            Dim f As New Frm_Reconst_Administ
            f._Code = Me.GV12.GetFocusedRowCellValue(Me.col1_RecAdmin)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche Cipemg Code
    ''' </summary>
    ''' <param name="sender">rpbtEdit13</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    Private Sub rpbtEdit13_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit13.ButtonClick
        If Me.GV14.GetFocusedRowCellValue(Me.col1_CipemgC) IsNot Nothing Then
            Dim f As New Frm_Cipemg_Code
            f._Code = Me.GV14.GetFocusedRowCellValue(Me.col1_CipemgC)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche Cipemg Texte
    ''' </summary>
    ''' <param name="sender">rpbtEdit6</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    Private Sub rpbtEdit6_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit6.ButtonClick
        If Me.GV2.GetFocusedRowCellValue(Me.col1_CipemgT) IsNot Nothing Then
            Dim f As New Frm_Cipemg_Texte
            f._Code = Me.GV2.GetFocusedRowCellValue(Me.col1_CipemgT)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche Intéraction RCP
    ''' </summary>
    ''' <param name="sender">rpbtEdit7</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    Private Sub rpbtEdit7_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit7.ButtonClick
        If Me.GV4.GetFocusedRowCellValue(Me.col1_InterRCP) IsNot Nothing Then
            Dim f As New Frm_InteractionsRCP
            f._Code = Me.GV4.GetFocusedRowCellValue(Me.col1_InterRCP)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche Grossesse/Allaitement
    ''' </summary>
    ''' <param name="sender">rpbtEdit8</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    Private Sub rpbtEdit8_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit8.ButtonClick
        If Me.GV6.GetFocusedRowCellValue(Me.col1_GrossAllait) IsNot Nothing Then
            Dim f As New Frm_Grossesse_Allaitement
            f._Code = Me.GV6.GetFocusedRowCellValue(Me.col1_GrossAllait)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche Conducteur
    ''' </summary>
    ''' <param name="sender">rpbtEdit9</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    Private Sub rpbtEdit9_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit9.ButtonClick
        If Me.GV8.GetFocusedRowCellValue(Me.col1_Conduct) IsNot Nothing Then
            Dim f As New Frm_Conducteur
            f._Code = Me.GV8.GetFocusedRowCellValue(Me.col1_Conduct)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche Effets indésirables
    ''' </summary>
    ''' <param name="sender">rpbtEdit10</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    Private Sub rpbtEdit10_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit10.ButtonClick
        If Me.GV10.GetFocusedRowCellValue(Me.col1_Effet_Indes) IsNot Nothing Then
            Dim f As New Frm_Effets_Indiserables
            f._Code = Me.GV10.GetFocusedRowCellValue(Me.col1_Effet_Indes)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche Fiche Transparence
    ''' </summary>
    ''' <param name="sender">rpbtEdit21</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    ''' 
    Private Sub rpbtEdit21_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit21.ButtonClick
        If Me.GV21.GetFocusedRowCellValue(Me.col1_Trans) IsNot Nothing Then
            Dim f As New Frm_Fiche_Transparence
            f._Code = Me.GV21.GetFocusedRowCellValue(Me.col1_Trans)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche commission de transparence
    ''' </summary>
    ''' <param name="sender">rpbtEdit22</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    ''' 
    Private Sub rpbtEdit22_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit22.ButtonClick
        If Me.GV22.GetFocusedRowCellValue(Me.col1_CommTrans) IsNot Nothing Then
            Dim f As New Frm_Commission_Transparence
            f._Code = Me.GV22.GetFocusedRowCellValue(Me.col1_CommTrans)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche RMO
    ''' </summary>
    ''' <param name="sender">rpbtEdit23</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    ''' 
    Private Sub rpbtEdit23_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit23.ButtonClick
        If Me.GV23.GetFocusedRowCellValue(Me.col1_RMO) IsNot Nothing Then
            Dim f As New Frm_RMO
            f._Code = Me.GV23.GetFocusedRowCellValue(Me.col1_RMO)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche Info Thérapeutique
    ''' </summary>
    ''' <param name="sender">rpbtEdit24</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    ''' 
    Private Sub rpbtEdit24_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit24.ButtonClick
        If Me.GV24.GetFocusedRowCellValue(Me.col1_InfoTherap) IsNot Nothing Then
            Dim f As New Frm_Fiche_Infotherapeutique
            f._Code = Me.GV24.GetFocusedRowCellValue(Me.col1_InfoTherap)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche Critéres de choix
    ''' </summary>
    ''' <param name="sender">rpbtEdit25</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    ''' 
    Private Sub rpbtEdit25_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit25.ButtonClick
        If Me.GV25.GetFocusedRowCellValue(Me.col1_Choix) IsNot Nothing Then
            Dim f As New Frm_Criteres_Choix
            f._Code = Me.GV25.GetFocusedRowCellValue(Me.col1_Choix)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    Private Sub rpbtEdit15_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit15.ButtonClick

        If Me.GV15.GetFocusedRowCellValue(Me.colPosoMinMax) IsNot Nothing Then
            Dim f As New Frm_Posologie_Min_Max1
            f._Code = Me.GV15.GetFocusedRowCellValue(Me.colPosoMinMax)
            f.MdiParent = FMain
            f.Show()
        End If

    End Sub

#End Region

    Private Sub LoadTab_1()
        Load_On(Me)
        OnLoading = True
        If CodE <> Nothing Then BackgroundWorkerChoix_DoWork()
        OnLoading = False
        Load_Off(Me)
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPageIndex = 1 Then
            LoadTab_1()
            Exit Sub
        End If
    End Sub

    
End Class
