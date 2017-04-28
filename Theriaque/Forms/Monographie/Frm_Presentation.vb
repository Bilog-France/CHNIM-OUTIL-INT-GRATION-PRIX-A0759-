Imports System.IO

Public Class Frm_Presentation

    Private CodE As String
    Public _Code As Object = Nothing ' charger la fiche depuis l'extérieur
    Private Tab_lkup1 As Boolean = False
    Private Tab_TA1 As Boolean = False
    Private Tab_lkup2 As Boolean = False
    Private Tab_TA2 As Boolean = False
    Private Tab_lkup3 As Boolean = False
    Private Tab_TA3 As Boolean = False
    Private Tab_lkup4 As Boolean = False
    Private Tab_TA4 As Boolean = False
    Private Tab_lkup5 As Boolean = False
    Private Tab_TA5 As Boolean = False
    Private Tab_lkup6 As Boolean = False
    Private Tab_TA6 As Boolean = False
    Private Onglet2_Parcouru As Boolean = False
    Private Onglet3_Parcouru As Boolean = False
    Private bModeDuplication As Boolean = False
    Private LastCodeSP As String
    Private doc As DocumentService.DocumentProvider
    Private DupArray As ArrayList

#Region " Data Edit "


    Public Sub AfficherFiche(ByVal code As String)

        code = code
        XtraTabControl1.SelectedTabPageIndex = 0
        OnLoading = True
        EmptyDataTable()

        Me.PrE_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PRE_PRESENTATION, code)

        Dim valueCode As String = Me.PrE_TA.GetDataByCode(code).Rows(0).Item("PRE_NATUCD_CDF_CODE_FK").ToString()
        Dim valueNumero As String = Me.PrE_TA.GetDataByCode(code).Rows(0).Item("PRE_NATUCD_CDF_NUM_FK").ToString()
        lkupUCD.EditValue = valueCode & "_" & valueNumero

        Me.PredisP_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PREDISP_PRE_DISPENSATION, code)
        Me.PreucD_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PREUCD_COMMENT_DOSEUCD, code)
        Me.CoconT_TA.FillByCode(Me.DsTheriaque_Nomenclature2.COCONT_COMPO_CONTENANT, code)
        Me.PreconT_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PRECONT_PRE_CONTENANT, code)
        Me.PrecaR_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PRECAR_PRESENTATION_CARACTCOMP, code)
        Me.PremaT_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PREMAT_PRE_MATERIAU, code)
        Me.Precpss_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PRECPSS, code)
        Me.PREDISPMAX.FillByCode(Me.DsTheriaque_Nomenclature2.PREDISPMAX_PRE_DISP_MAXIMALE, code)
        doc = New DocumentService.DocumentProvider(strConnexion)
        Me.gcDocuments.DataSource = doc.GetDocsByTypeDoc(code, DocumentService.DocumentProvider.TypeDoc.Presentation)

        btnImporter.Enabled = True
        Tab_TA1 = False
        Tab_TA2 = False
        Tab_TA3 = False
        Tab_TA4 = False
        Tab_TA5 = False
        Tab_TA6 = False

        bModeDuplication = False
        OnLoading = False


    End Sub

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_PRE_PRESENTATION
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            XtraTabControl1.SelectedTabPageIndex = 0
            OnLoading = True
            EmptyDataTable()
            txtLibelle.Text = ""
            meNote.Text = ""

            Me.PrE_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PRE_PRESENTATION, CodE)

            Dim valueCode As String = Me.PrE_TA.GetDataByCode(CodE).Rows(0).Item("PRE_NATUCD_CDF_CODE_FK").ToString()
            Dim valueNumero As String = Me.PrE_TA.GetDataByCode(CodE).Rows(0).Item("PRE_NATUCD_CDF_NUM_FK").ToString()
            lkupUCD.EditValue = valueCode & "_" & valueNumero
            Me.PredisP_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PREDISP_PRE_DISPENSATION, CodE)
            Me.PreucD_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PREUCD_COMMENT_DOSEUCD, CodE)
            Me.CoconT_TA.FillByCode(Me.DsTheriaque_Nomenclature2.COCONT_COMPO_CONTENANT, CodE)
            Me.PreconT_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PRECONT_PRE_CONTENANT, CodE)
            Me.PrecaR_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PRECAR_PRESENTATION_CARACTCOMP, CodE)
            Me.PremaT_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PREMAT_PRE_MATERIAU, CodE)
            Me.PREDISPMAX.FillByCode(Me.DsTheriaque_Nomenclature2.PREDISPMAX_PRE_DISP_MAXIMALE, f._Code)
            Me.Precpss_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PRECPSS, CodE)
            doc = New DocumentService.DocumentProvider(strConnexion)
            Me.lueCategorie.EditValue = CType(doc.ID_Categorie, Short)
            Me.gcDocuments.DataSource = doc.GetDocsByTypeDoc(CodE, DocumentService.DocumentProvider.TypeDoc.Presentation)
            PrevolsoL.FillByCode(Me.DsTheriaque_Nomenclature2.PREVOLSOL_VOLUME_SOLUTION, txtCode.Text)
            'Me.BindingContext(Me.MasterDataSet, "PREVOLSOL_VOLUME_SOLUTION").AddNew()

            btnImporter.Enabled = True
            Tab_TA1 = False
            Tab_TA2 = False
            Tab_TA3 = False
            Tab_TA4 = False
            Tab_TA5 = False
            Tab_TA6 = False

            bModeDuplication = False
            OnLoading = False

            'T3954: Charger tous les onglets automatiquement suite à la demande du client qui lui dérange de parcourir 
            'tous les onglets avant de maj l'interopérable

            LoadTab_1()
            LoadTab_2()
            LoadTab_3()
            LoadTab_4()
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Fonction: Recherche multicritères
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks>Fonction surchargée</remarks>
    ''' 

    Public Overrides Function ChercherMultiCriteres() As Boolean
        MyBase.ChercherMultiCriteres()
        Dim sCodeCONT As String = ""
        Dim sCodeMAT As String = ""
        Dim sCodeCCOMP As String = ""
        Dim sCodeCEMB As String = ""
        Dim sCodePRUNIT As String = ""
        Dim sCodeTAUXVILLE As String = ""
        Dim sCodeTAUXHOP As String = ""
        Dim sCodePREHOS As String = ""
        Dim sCodeST As String = ""
        Dim sCodeSTCOMP As String = ""
        Dim sCodeSTREMB As String = ""
        Dim sCodeCONDCONS As String = ""
        Dim sCodeLIEUDISP As String = ""
        Dim sCodeCOMDISP As String = ""
        Dim f As New Frm_PresentationMultiCriteres
        f.ShowDialog()
        If f._Validate Then
            If f._bCONT Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("22")
                fDICO.Text = "Contenants"
                fDICO.ShowDialog()
                sCodeCONT = fDICO._Code
            End If
            If f._bMAT Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("09")
                fDICO.Text = "Matériaux"
                fDICO.ShowDialog()
                sCodeMAT = fDICO._Code
            End If
            If f._bCCOMP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("01")
                fDICO.Text = "Caract complément"
                fDICO.ShowDialog()
                sCodeCCOMP = fDICO._Code
            End If
            If f._bCEMB Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("01")
                fDICO.Text = "Caract emballage"
                fDICO.ShowDialog()
                sCodeCEMB = fDICO._Code
            End If
            If f._bPRUNIT Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("12")
                fDICO.Text = "Présentation unitaire"
                fDICO.ShowDialog()
                sCodePRUNIT = fDICO._Code
            End If
            If f._bTAUXVILLE Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("17")
                fDICO.Text = "Taux Rbst SS ville - Taux sécurité sociale"
                fDICO.ShowDialog()
                sCodeTAUXVILLE = fDICO._Code
            End If
            If f._bTAUXHOP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("17")
                fDICO.Text = "Taux Rbst SS hôpital - Taux sécurité sociale"
                fDICO.ShowDialog()
                sCodeTAUXHOP = fDICO._Code
            End If
            If f._bPREHOS Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("13")
                fDICO.Text = "Présentation hospitalière"
                fDICO.ShowDialog()
                sCodePREHOS = fDICO._Code
            End If
            If f._bST Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("14", " and substring(CDF_CODE_PK,1,1) =  'S'")
                fDICO.Text = "Statuts"
                fDICO.ShowDialog()
                sCodeST = fDICO._Code
            End If
            If f._bSTCOMP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("14", " and substring(CDF_CODE_PK,1,1) =  'C'")
                fDICO.Text = "Statuts complémentaires"
                fDICO.ShowDialog()
                sCodeSTCOMP = fDICO._Code
            End If
            If f._bSTREMB Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("14", " and substring(CDF_CODE_PK,1,1) =  'R'")
                fDICO.Text = "Statuts de remboursement"
                fDICO.ShowDialog()
                sCodeSTREMB = fDICO._Code
            End If
            If f._bCONDCONS Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("03")
                fDICO.Text = "Conditions de conservation"
                fDICO.ShowDialog()
                sCodeCONDCONS = fDICO._Code
            End If
            If f._bLIEUDISP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("14", " and substring(CDF_CODE_PK,1,1) =  'D'")
                fDICO.Text = "Lieux de dispensation"
                fDICO.ShowDialog()
                sCodeLIEUDISP = fDICO._Code
            End If
            If f._bCOMDISP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("29")
                fDICO.Text = "Commentaires dispensation"
                fDICO.ShowDialog()
                sCodeCOMDISP = fDICO._Code
            End If


            Dim fResultat As New Frm_Recherche
            Dim sSQL As String = ""
            sSQL &= " Select PRE_CODE_PK as code, '' as libelle From THERIAQUE.PRE_PRESENTATION"
            If sCodeCONT <> "" Then
                sSQL &= " WHERE PRE_CODE_PK IN (SELECT COCONT_PRE_CODE_FK_PK FROM THERIAQUE.COCONT_COMPO_CONTENANT WHERE COCONT_CDF_GAL_CODE_FK = " & cn.SQLText(sCodeCONT) & ")"
            End If
            If sCodeMAT <> "" Then
                If sCodeCONT <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " PRE_CODE_PK IN (SELECT PREMAT_PRE_CODE_FK_PK FROM THERIAQUE.PREMAT_PRE_MATERIAU WHERE PREMAT_CDF_MACDT_CODE_FK_PK = " & cn.SQLText(sCodeMAT) & ")"
            End If
            If sCodeCCOMP <> "" Then
                If sCodeCONT <> "" Or sCodeMAT <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " PRE_CODE_PK IN (SELECT PRECAR_PRE_CODE_FK_PK FROM THERIAQUE.PRECAR_PRESENTATION_CARACTCOMP WHERE PRECAR_CDF_CODE_CACDT_FK_PK = " & cn.SQLText(sCodeCCOMP) & ")"
            End If
            If sCodeCEMB <> "" Then
                If sCodeCONT <> "" Or sCodeMAT <> "" Or sCodeCCOMP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " PRE_CODE_PK IN (SELECT PRECEMB_PRE_CODE_FK_PK FROM THERIAQUE.PRECEMB_PRE_CAREMBALLAGE WHERE PRECEMB_CDF_CAREMB_CODE_FK_PK = " & cn.SQLText(sCodeCEMB) & ")"
            End If
            If sCodePRUNIT <> "" Then
                If sCodeCONT <> "" Or sCodeMAT <> "" Or sCodeCCOMP <> "" Or sCodeCEMB <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " PRE_CODE_PK IN (SELECT PRE_CODE_PK FROM THERIAQUE.PRE_PRESENTATION WHERE PRE_CDF_PU_CODE_FK = " & cn.SQLText(sCodePRUNIT) & ")"
            End If
            If sCodeTAUXVILLE <> "" Then
                If sCodeCONT <> "" Or sCodeMAT <> "" Or sCodeCCOMP <> "" Or sCodeCEMB <> "" Or sCodePRUNIT <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " PRE_CODE_PK IN (SELECT PRETSS_PRE_CODE_FK_PK FROM THERIAQUE.PRETSS_PRESENTATION_TAUX WHERE PRETSS_CDF_TSS_CODE_FK_PK = " & cn.SQLText(sCodeTAUXVILLE) & ")"
            End If
            If sCodeTAUXHOP <> "" Then
                If sCodeCONT <> "" Or sCodeMAT <> "" Or sCodeCCOMP <> "" Or sCodeCEMB <> "" Or sCodePRUNIT <> "" Or sCodeTAUXVILLE <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " PRE_CODE_PK IN (SELECT PRETSSH_PRE_CODE_FK_PK FROM THERIAQUE.PRETSSH_PRE_TAUX_HOP WHERE PRETSSH_CDF_TSS_CODE_FK_PK = " & cn.SQLText(sCodeTAUXHOP) & ")"
            End If
            If sCodePREHOS <> "" Then
                If sCodeCONT <> "" Or sCodeMAT <> "" Or sCodeCCOMP <> "" Or sCodeCEMB <> "" Or sCodePRUNIT <> "" Or sCodeTAUXVILLE <> "" Or sCodeTAUXHOP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " PRE_CODE_PK IN (SELECT PRE_CODE_PK FROM THERIAQUE.PRE_PRESENTATION WHERE PRE_CDF_RH_CODE_FK = " & cn.SQLText(sCodePREHOS) & ")"
            End If
            If sCodeST <> "" Then
                If sCodeCONT <> "" Or sCodeMAT <> "" Or sCodeCCOMP <> "" Or sCodeCEMB <> "" Or sCodePRUNIT <> "" Or sCodeTAUXVILLE <> "" Or sCodeTAUXHOP <> "" Or sCodePREHOS <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " PRE_CODE_PK IN (SELECT PRESTP_PRE_CODE_FK_PK FROM THERIAQUE.PRESTP_PRE_STP WHERE PRESTP_CDF_STP_CODE_FK_PK = " & cn.SQLText(sCodeST) & ")"
            End If
            If sCodeSTCOMP <> "" Then
                If sCodeCONT <> "" Or sCodeMAT <> "" Or sCodeCCOMP <> "" Or sCodeCEMB <> "" Or sCodePRUNIT <> "" Or sCodeTAUXVILLE <> "" Or sCodeTAUXHOP <> "" Or sCodePREHOS <> "" Or sCodeST <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " PRE_CODE_PK IN (SELECT PRESTC_PRE_CODE_FK_PK FROM THERIAQUE.PRESTC_STATUTCOMP_PRESENT WHERE PRESTC_CDF_STCOMP_CODE_FK_PK = " & cn.SQLText(sCodeSTCOMP) & ")"
            End If
            If sCodeSTREMB <> "" Then
                If sCodeCONT <> "" Or sCodeMAT <> "" Or sCodeCCOMP <> "" Or sCodeCEMB <> "" Or sCodePRUNIT <> "" Or sCodeTAUXVILLE <> "" Or sCodeTAUXHOP <> "" Or sCodePREHOS <> "" Or sCodeST <> "" Or sCodeSTCOMP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " PRE_CODE_PK IN (SELECT PRESTR_PRE_CODE_FK_PK FROM THERIAQUE.PRESTR_STATUT_REMBOURST WHERE PRESTR_CDF_STR_CODE_FK_PK = " & cn.SQLText(sCodeSTREMB) & ")"
            End If
            If sCodeCONDCONS <> "" Then
                If sCodeCONT <> "" Or sCodeMAT <> "" Or sCodeCCOMP <> "" Or sCodeCEMB <> "" Or sCodePRUNIT <> "" Or sCodeTAUXVILLE <> "" Or sCodeTAUXHOP <> "" Or sCodePREHOS <> "" Or sCodeST <> "" Or sCodeSTCOMP <> "" Or sCodeSTREMB <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " PRE_CODE_PK IN (SELECT PERCS_PRE_CODE_FK_PK FROM THERIAQUE.PERCS_PERIODE_COND_CSV WHERE PERCS_CDF_CSV_CODE_FK_PK = " & cn.SQLText(sCodeCONDCONS) & ")"
            End If
            If sCodeLIEUDISP <> "" Then
                If sCodeCONT <> "" Or sCodeMAT <> "" Or sCodeCCOMP <> "" Or sCodeCEMB <> "" Or sCodePRUNIT <> "" Or sCodeTAUXVILLE <> "" Or sCodeTAUXHOP <> "" Or sCodePREHOS <> "" Or sCodeST <> "" Or sCodeSTCOMP <> "" Or sCodeSTREMB <> "" Or sCodeCONDCONS <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " PRE_CODE_PK IN (SELECT PREDILI_PRE_CODE_FK_PK FROM THERIAQUE.PREDILI_LIEU_DISPENSAT WHERE PREDILI_CDF_LIEU_CODE_FK_PK = " & cn.SQLText(sCodeLIEUDISP) & ")"
            End If
            If sCodeCOMDISP <> "" Then
                If sCodeCONT <> "" Or sCodeMAT <> "" Or sCodeCCOMP <> "" Or sCodeCEMB <> "" Or sCodePRUNIT <> "" Or sCodeTAUXVILLE <> "" Or sCodeTAUXHOP <> "" Or sCodePREHOS <> "" Or sCodeST <> "" Or sCodeSTCOMP <> "" Or sCodeSTREMB <> "" Or sCodeCONDCONS <> "" Or sCodeLIEUDISP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " PRE_CODE_PK IN (SELECT PREDICO_PRE_CODE_FK_PK FROM THERIAQUE.PREDICO_COMMENT_DISPENSAT WHERE PREDICO_CDF_COM_CODE_FK_PK = " & cn.SQLText(sCodeCOMDISP) & ")"
            End If
            sSQL &= " ORDER BY PRE_CODE_PK"
            fResultat._SSQL = sSQL
            fResultat.Text = Me.Text
            fResultat.ShowDialog()
            CodE = fResultat._Code
            If fResultat._Code IsNot Nothing Then
                XtraTabControl1.SelectedTabPageIndex = 0
                OnLoading = True
                EmptyDataTable()

                Me.PrE_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PRE_PRESENTATION, fResultat._Code)

                Dim valueCode As String = Me.PrE_TA.GetDataByCode(fResultat._Code).Rows(0).Item("PRE_NATUCD_CDF_CODE_FK").ToString()
                Dim valueNumero As String = Me.PrE_TA.GetDataByCode(fResultat._Code).Rows(0).Item("PRE_NATUCD_CDF_NUM_FK").ToString()
                lkupUCD.EditValue = valueCode & "_" & valueNumero

                Me.PredisP_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PREDISP_PRE_DISPENSATION, fResultat._Code)
                Me.PreucD_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PREUCD_COMMENT_DOSEUCD, fResultat._Code)
                Me.CoconT_TA.FillByCode(Me.DsTheriaque_Nomenclature2.COCONT_COMPO_CONTENANT, fResultat._Code)
                Me.PreconT_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PRECONT_PRE_CONTENANT, fResultat._Code)
                Me.PrecaR_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PRECAR_PRESENTATION_CARACTCOMP, fResultat._Code)
                Me.PremaT_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PREMAT_PRE_MATERIAU, fResultat._Code)
                Me.Precpss_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PRECPSS, fResultat._Code)

                doc = New DocumentService.DocumentProvider(strConnexion)
                Me.gcDocuments.DataSource = doc.GetDocsByTypeDoc(CodE, DocumentService.DocumentProvider.TypeDoc.Presentation)

                Tab_TA1 = False
                Tab_TA2 = False
                Tab_TA3 = False
                Tab_TA4 = False
                Tab_TA5 = False
                Tab_TA6 = False

                bModeDuplication = False
                OnLoading = False
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Overrides Sub Ajouter()
        EmptyDataTable()
        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        Me.DsTheriaque_Nomenclature2.PREVOLSOL_VOLUME_SOLUTION.Clear()
        'SetCode_MAx(MasterTable, txtCode)

        Me.DsTheriaque_Nomenclature2.PREDISPMAX_PRE_DISP_MAXIMALE.Clear()

        lkupUCD.EditValue = ""
        CodE = InvalideControl
        Me.gcDocuments.DataSource = New ArrayList()
        MyBase.Ajouter()
    End Sub

    Public Overrides Function supprimer() As Boolean
        MyBase.Supprimer()
        Dim iCount As Integer
        If Tab_TA1 And Tab_TA2 And Tab_TA3 And Tab_TA4 Then

            DeleteCIPFrom_INTER_INTEROPERABLE()

            For iCount = 0 To DsTheriaque_Nomenclature2.PREDISP_PRE_DISPENSATION.Rows.Count - 1
                DsTheriaque_Nomenclature2.PREDISP_PRE_DISPENSATION.Rows(iCount).Delete()
            Next
            Me.PredisP_TA.Update(DsTheriaque_Nomenclature2)

            For iCount = 0 To DsTheriaque_Nomenclature2.PREUCD_COMMENT_DOSEUCD.Rows.Count - 1
                DsTheriaque_Nomenclature2.PREUCD_COMMENT_DOSEUCD.Rows(iCount).Delete()
            Next
            Me.PreucD_TA.Update(DsTheriaque_Nomenclature2)

            For iCount = 0 To DsTheriaque_Nomenclature2.PRECONT_PRE_CONTENANT.Rows.Count - 1
                DsTheriaque_Nomenclature2.PRECONT_PRE_CONTENANT.Rows(iCount).Delete()
            Next
            Me.PreconT_TA.Update(DsTheriaque_Nomenclature2)


            For iCount = 0 To DsTheriaque_Nomenclature2.PRECAR_PRESENTATION_CARACTCOMP.Rows.Count - 1
                DsTheriaque_Nomenclature2.PRECAR_PRESENTATION_CARACTCOMP.Rows(iCount).Delete()
            Next
            Me.PrecaR_TA.Update(DsTheriaque_Nomenclature2)

            For iCount = 0 To DsTheriaque_Nomenclature2.PRECEMB_PRE_CAREMBALLAGE.Rows.Count - 1
                DsTheriaque_Nomenclature2.PRECEMB_PRE_CAREMBALLAGE.Rows(iCount).Delete()
            Next
            Me.PrecemB_TA.Update(DsTheriaque_Nomenclature2)

            For iCount = 0 To DsTheriaque_Nomenclature2.PRETSS_PRESENTATION_TAUX.Rows.Count - 1
                DsTheriaque_Nomenclature2.PRETSS_PRESENTATION_TAUX.Rows(iCount).Delete()
            Next
            Me.PretsS_TA.Update(DsTheriaque_Nomenclature2)

            For iCount = 0 To DsTheriaque_Nomenclature2.PREMAT_PRE_MATERIAU.Rows.Count - 1
                DsTheriaque_Nomenclature2.PREMAT_PRE_MATERIAU.Rows(iCount).Delete()
            Next
            Me.PremaT_TA.Update(DsTheriaque_Nomenclature2)

            'For iCount = 0 To DsTheriaque_Nomenclature2.FORPRE_FORFAIT_PRE.Rows.Count - 1
            '    DsTheriaque_Nomenclature2.FORPRE_FORFAIT_PRE.Rows(iCount).Delete()
            'Next
            'Me.ForprE_TA.Update(DsTheriaque_Nomenclature2)


            For iCount = 0 To DsTheriaque_Nomenclature2.PRECPSS.Rows.Count - 1
                DsTheriaque_Nomenclature2.PRECPSS.Rows(iCount).Delete()
            Next
            Me.Precpss_TA.Update(DsTheriaque_Nomenclature2)

            'PRIPRE_PRIX_PRESENTATION 
            cn.Execute("delete THERIAQUE.PRIPRE_PRIX_PRESENTATION where PRIPRE_PRE_CODE_FK_PK = " & cn.SQLText(txtCode.Text))

            'PREVOLSOL_VOLUME_SOLUTION
            cn.Execute("DELETE from theriaque.PREVOLSOL_VOLUME_SOLUTION where PREVOLSOL_PRE_CODE_FK_PK= " & cn.SQLText(txtCode.Text))

            'FORPRE_FORFAIT_PRE 
            cn.Execute("delete THERIAQUE.FORPRE_FORFAIT_PRE where FORPRE_PRE_CODE_FK_PK = " & cn.SQLText(txtCode.Text))

            For iCount = 0 To DsTheriaque_Nomenclature2.PRETSSH_PRE_TAUX_HOP.Rows.Count - 1
                DsTheriaque_Nomenclature2.PRETSSH_PRE_TAUX_HOP.Rows(iCount).Delete()
            Next
            Me.PretssH_TA.Update(DsTheriaque_Nomenclature2)

            For iCount = 0 To DsTheriaque_Nomenclature2.PRESTP_PRE_STP.Rows.Count - 1
                DsTheriaque_Nomenclature2.PRESTP_PRE_STP.Rows(iCount).Delete()
            Next
            Me.PrestP_TA.Update(DsTheriaque_Nomenclature2)

            For iCount = 0 To DsTheriaque_Nomenclature2.PRESTC_STATUTCOMP_PRESENT.Rows.Count - 1
                DsTheriaque_Nomenclature2.PRESTC_STATUTCOMP_PRESENT.Rows(iCount).Delete()
            Next
            Me.PrestC_TA.Update(DsTheriaque_Nomenclature2)

            For iCount = 0 To DsTheriaque_Nomenclature2.PRESTR_STATUT_REMBOURST.Rows.Count - 1
                DsTheriaque_Nomenclature2.PRESTR_STATUT_REMBOURST.Rows(iCount).Delete()
            Next
            Me.PrestR_TA.Update(DsTheriaque_Nomenclature2)

            For iCount = 0 To DsTheriaque_Nomenclature2.PRESTRTX_TEXTE_STAT_REMBOURST.Rows.Count - 1
                DsTheriaque_Nomenclature2.PRESTRTX_TEXTE_STAT_REMBOURST.Rows(iCount).Delete()
            Next
            Me.PrestrtX_TA.Update(DsTheriaque_Nomenclature2)

            For iCount = 0 To DsTheriaque_Nomenclature2.PERCS_PERIODE_COND_CSV.Rows.Count - 1
                DsTheriaque_Nomenclature2.PERCS_PERIODE_COND_CSV.Rows(iCount).Delete()
            Next
            Me.PercS_TA.Update(DsTheriaque_Nomenclature2)

            For iCount = 0 To DsTheriaque_Nomenclature2.PREPER_PRESENTATION_PERIO_CSV.Rows.Count - 1
                DsTheriaque_Nomenclature2.PREPER_PRESENTATION_PERIO_CSV.Rows(iCount).Delete()
            Next
            Me.PrepeR_TA.Update(DsTheriaque_Nomenclature2)


            For iCount = 0 To DsTheriaque_Nomenclature2.PREDILI_LIEU_DISPENSAT.Rows.Count - 1
                DsTheriaque_Nomenclature2.PREDILI_LIEU_DISPENSAT.Rows(iCount).Delete()
            Next
            Me.PredilI_TA.Update(DsTheriaque_Nomenclature2)

            For iCount = 0 To DsTheriaque_Nomenclature2.PREDICO_COMMENT_DISPENSAT.Rows.Count - 1
                DsTheriaque_Nomenclature2.PREDICO_COMMENT_DISPENSAT.Rows(iCount).Delete()
            Next
            Me.PredicO_TA.Update(DsTheriaque_Nomenclature2)

            For iCount = 0 To DsTheriaque_Nomenclature2.PREDITX_TEXTE_DISPENSAT.Rows.Count - 1
                DsTheriaque_Nomenclature2.PREDITX_TEXTE_DISPENSAT.Rows(iCount).Delete()
            Next
            Me.PreditX_TA.Update(DsTheriaque_Nomenclature2)

            For iCount = 0 To DsTheriaque_Nomenclature2.PRESMR_PRE_SMR_ATR.Rows.Count - 1
                DsTheriaque_Nomenclature2.PRESMR_PRE_SMR_ATR.Rows(iCount).Delete()
            Next
            Me.PresmR_TA.Update(DsTheriaque_Nomenclature2)

            For iCount = 0 To DsTheriaque_Nomenclature2.PRECSVTX_TEXTE_CONSERV.Rows.Count - 1
                DsTheriaque_Nomenclature2.PRECSVTX_TEXTE_CONSERV.Rows(iCount).Delete()
            Next
            Me.PrecsvtX_TA.Update(DsTheriaque_Nomenclature2)

            For iCount = 0 To DsTheriaque_Nomenclature2.COCONT_COMPO_CONTENANT.Rows.Count - 1
                DsTheriaque_Nomenclature2.COCONT_COMPO_CONTENANT.Rows(iCount).Delete()
            Next
            Me.CoconT_TA.Update(DsTheriaque_Nomenclature2)

            'Prevolsol
            'For iCount = 0 To DsTheriaque_Nomenclature2.PREVOLSOL_VOLUME_SOLUTION.Rows.Count - 1
            '    DsTheriaque_Nomenclature2.PREVOLSOL_VOLUME_SOLUTION.Rows(iCount).Delete()
            'Next
            'Me.PrevolsoL.Update(DsTheriaque_Nomenclature2)

            'PreDispMax
            For iCount = 0 To DsTheriaque_Nomenclature2.PREDISPMAX_PRE_DISP_MAXIMALE.Rows.Count - 1
                DsTheriaque_Nomenclature2.PREDISPMAX_PRE_DISP_MAXIMALE.Rows(iCount).Delete()
            Next
            Me.PREDISPMAX.Update(DsTheriaque_Nomenclature2)

            Me.DsTheriaque_Nomenclature2.PRE_PRESENTATION.Rows(0).Delete()
            Me.PrE_TA.Update(Me.MasterDataSet)



            bModeDuplication = False
            Return True
        Else
            Process_Message(strChargementOnglet, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Function

    Public Overrides Sub valider()
        'MyBase.Valider()

        Dim unite As String
        Dim volume As String
        Dim maxUCD As String
        Dim maxCIP As String
        Dim Type As String

        Dim pass As Boolean = True
        If String.IsNullOrEmpty(lkupUnite.Text) And String.IsNullOrEmpty(txtVolume.Text) Then
            pass = False
            cn.Execute(" Delete from theriaque.PREVOLSOL_VOLUME_SOLUTION where PREVOLSOL_PRE_CODE_FK_PK= " & cn.SQLText(txtCode.Text))
        Else
            If Not String.IsNullOrEmpty(lkupUnite.Text) And String.IsNullOrEmpty(txtVolume.Text) Then
                MsgBox("Veuillez sélectionner le champ Volume administrable")
                MyBase.IsValider = False
                Return
            Else
                If Not String.IsNullOrEmpty(txtVolume.Text) And String.IsNullOrEmpty(lkupUnite.Text) Then
                    MsgBox("Veuillez sélectionner le champ unité Volume administrable")
                    MyBase.IsValider = False
                    Return
                End If
            End If
        End If
        MyBase.IsValider = True

        DateEdit1.EditValue = Now.Date
        DateEdit1.DateTime = Now.Date

        If bModeDuplication Then ModifierCode()
        LastCodeSP = GetLastSP()
        If (lkupUCD.EditValue <> "") Then
            Me.BindingContext(Me.MasterDataSet, MasterTable).Current("PRE_NATUCD_CDF_CODE_FK") = lkupUCD.EditValue.ToString().Split("_")(0)
            Me.BindingContext(Me.MasterDataSet, MasterTable).Current("PRE_NATUCD_CDF_NUM_FK") = lkupUCD.EditValue.ToString().Split("_")(1)
        Else
            Me.BindingContext(Me.MasterDataSet, MasterTable).Current("PRE_NATUCD_CDF_CODE_FK") = Nothing
            Me.BindingContext(Me.MasterDataSet, MasterTable).Current("PRE_NATUCD_CDF_NUM_FK") = Nothing
        End If
        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()

        PrE_TA.Update(Me.DsTheriaque_Nomenclature2.PRE_PRESENTATION)

        Me.BindingContext(Me.MasterDataSet, PREDISP_PRE_DISPENSATION).EndCurrentEdit()
        PredisP_TA.Update(Me.DsTheriaque_Nomenclature2.PREDISP_PRE_DISPENSATION)

        Me.BindingContext(Me.MasterDataSet, PREUCD_COMMENT_DOSEUCD).EndCurrentEdit()
        PreucD_TA.Update(Me.DsTheriaque_Nomenclature2.PREUCD_COMMENT_DOSEUCD)

        Me.BindingContext(Me.MasterDataSet, COCONT_COMPO_CONTENANT).EndCurrentEdit()
        Me.CoconT_TA.Update(Me.DsTheriaque_Nomenclature2.COCONT_COMPO_CONTENANT)

        Me.BindingContext(Me.MasterDataSet, PRECONT_PRE_CONTENANT).EndCurrentEdit()
        Me.PreconT_TA.Update(Me.DsTheriaque_Nomenclature2.PRECONT_PRE_CONTENANT)

        Me.BindingContext(Me.MasterDataSet, PRECAR_PRESENTATION_CARACTCOMP).EndCurrentEdit()
        PrecaR_TA.Update(Me.DsTheriaque_Nomenclature2.PRECAR_PRESENTATION_CARACTCOMP)

        Me.BindingContext(Me.MasterDataSet, PRECEMB_PRE_CAREMBALLAGE).EndCurrentEdit()
        Me.PrecemB_TA.Update(Me.DsTheriaque_Nomenclature2.PRECEMB_PRE_CAREMBALLAGE)

        Me.BindingContext(Me.MasterDataSet, PRETSS_PRESENTATION_TAUX).EndCurrentEdit()
        Me.PretsS_TA.Update(Me.DsTheriaque_Nomenclature2.PRETSS_PRESENTATION_TAUX)

        Me.BindingContext(Me.MasterDataSet, PREMAT_PRE_MATERIAU).EndCurrentEdit()
        Me.PremaT_TA.Update(Me.DsTheriaque_Nomenclature2.PREMAT_PRE_MATERIAU)

        Me.BindingContext(Me.MasterDataSet, FORPRE_FORFAIT_PRE).EndCurrentEdit()
        Me.ForprE_TA.Update(Me.DsTheriaque_Nomenclature2.FORPRE_FORFAIT_PRE)

        Me.BindingContext(Me.MasterDataSet, PRIPRE_PRIX_PRESENTATION).EndCurrentEdit()
        Me.PriprE_TA.Update(Me.DsTheriaque_Nomenclature2.PRIPRE_PRIX_PRESENTATION)

        Me.BindingContext(Me.MasterDataSet, PRETSSH_PRE_TAUX_HOP).EndCurrentEdit()
        Me.PretssH_TA.Update(Me.DsTheriaque_Nomenclature2.PRETSSH_PRE_TAUX_HOP)

        Me.BindingContext(Me.MasterDataSet, PRESTP_PRE_STP).EndCurrentEdit()
        Me.PrestP_TA.Update(Me.DsTheriaque_Nomenclature2.PRESTP_PRE_STP)

        Me.BindingContext(Me.MasterDataSet, PRESTC_STATUTCOMP_PRESENT).EndCurrentEdit()
        Me.PrestC_TA.Update(Me.DsTheriaque_Nomenclature2.PRESTC_STATUTCOMP_PRESENT)

        Me.BindingContext(Me.MasterDataSet, PRESTR_STATUT_REMBOURST).EndCurrentEdit()
        Me.PrestR_TA.Update(Me.DsTheriaque_Nomenclature2.PRESTR_STATUT_REMBOURST)

        Me.BindingContext(Me.MasterDataSet, PRESTRTX_TEXTE_STAT_REMBOURST).EndCurrentEdit()
        Me.PrestrtX_TA.Update(Me.DsTheriaque_Nomenclature2.PRESTRTX_TEXTE_STAT_REMBOURST)

        Me.BindingContext(Me.MasterDataSet, PREPER_PRESENTATION_PERIO_CSV).EndCurrentEdit()
        Me.PrepeR_TA.Update(Me.DsTheriaque_Nomenclature2.PREPER_PRESENTATION_PERIO_CSV)

        Me.BindingContext(Me.MasterDataSet, PERCS_PERIODE_COND_CSV).EndCurrentEdit()
        Me.PercS_TA.Update(Me.DsTheriaque_Nomenclature2.PERCS_PERIODE_COND_CSV)

        Me.BindingContext(Me.MasterDataSet, PREDILI_LIEU_DISPENSAT).EndCurrentEdit()
        Me.PredilI_TA.Update(Me.DsTheriaque_Nomenclature2.PREDILI_LIEU_DISPENSAT)

        Me.BindingContext(Me.MasterDataSet, PREDICO_COMMENT_DISPENSAT).EndCurrentEdit()
        Me.PredicO_TA.Update(Me.DsTheriaque_Nomenclature2.PREDICO_COMMENT_DISPENSAT)

        Me.BindingContext(Me.MasterDataSet, PREDITX_TEXTE_DISPENSAT).EndCurrentEdit()
        Me.PreditX_TA.Update(Me.DsTheriaque_Nomenclature2.PREDITX_TEXTE_DISPENSAT)

        Me.BindingContext(Me.MasterDataSet, PRESMR_PRE_SMR_ATR).EndCurrentEdit()
        Me.PresmR_TA.Update(Me.DsTheriaque_Nomenclature2.PRESMR_PRE_SMR_ATR)

        Me.BindingContext(Me.MasterDataSet, PRECSVTX_TEXTE_CONSERV).EndCurrentEdit()
        Me.PrecsvtX_TA.Update(Me.DsTheriaque_Nomenclature2.PRECSVTX_TEXTE_CONSERV)

        Me.BindingContext(Me.MasterDataSet, "PRECPSS").EndCurrentEdit()
        Me.Precpss_TA.Update(Me.DsTheriaque_Nomenclature2.PRECPSS)


        If Me.BindingContext(Me.MasterDataSet, "PREVOLSOL_VOLUME_SOLUTION").Count = 0 Then

            If lkupUnite.EditValue Is System.DBNull.Value Then
                unite = Nothing
            Else
                unite = lkupUnite.EditValue
            End If

            volume = txtVolume.Text

            Me.BindingContext(Me.MasterDataSet, "PREVOLSOL_VOLUME_SOLUTION").AddNew()

            Me.BindingContext(Me.MasterDataSet, "PREVOLSOL_VOLUME_SOLUTION").Current("PREVOLSOL_PRE_CODE_FK_PK") = txtCode.Text
            Me.BindingContext(Me.MasterDataSet, "PREVOLSOL_VOLUME_SOLUTION").Current("PREVOLSOL_CIP13") = txtEAN.Text

            If Not String.IsNullOrEmpty(volume) Then
                Me.BindingContext(Me.MasterDataSet, "PREVOLSOL_VOLUME_SOLUTION").Current("PREVOLSOL_VOLSOLUTION") = volume
            End If

            If unite IsNot System.DBNull.Value Then
                If Not String.IsNullOrEmpty(unite) Then
                    Me.BindingContext(Me.MasterDataSet, "PREVOLSOL_VOLUME_SOLUTION").Current("PREVOLSOL_CDF_VOL_CODE_FK") = unite
                End If
            End If
        Else
            If lkupUnite.EditValue Is System.DBNull.Value Then
                unite = Nothing
            Else
                unite = lkupUnite.EditValue
            End If

            If String.IsNullOrEmpty(unite) And String.IsNullOrEmpty(txtVolume.Text) Then
                'Me.DsTheriaque_Nomenclature2.PREVOLSOL_VOLUME_SOLUTION.Rows(0).Delete()
                cn.Execute(" Delete from theriaque.PREVOLSOL_VOLUME_SOLUTION where PREVOLSOL_PRE_CODE_FK_PK =" & cn.SQLText(txtCode.Text))
            Else
                Me.BindingContext(Me.MasterDataSet, "PREVOLSOL_VOLUME_SOLUTION").Current("PREVOLSOL_PRE_CODE_FK_PK") = txtCode.Text
                Me.BindingContext(Me.MasterDataSet, "PREVOLSOL_VOLUME_SOLUTION").Current("PREVOLSOL_CIP13") = txtEAN.Text
            End If

        End If

        If (pass) Then
            Me.BindingContext(Me.MasterDataSet, "PREVOLSOL_VOLUME_SOLUTION").EndCurrentEdit()
            Me.PrevolsoL.Update(Me.DsTheriaque_Nomenclature2.PREVOLSOL_VOLUME_SOLUTION)
        End If

        For i As Integer = 0 To Me.DsTheriaque_Nomenclature2.PREDISPMAX_PRE_DISP_MAXIMALE.Rows.Count - 1
            Me.DsTheriaque_Nomenclature2.PREDISPMAX_PRE_DISP_MAXIMALE.Rows(i).Item("PREDISPMAX_PRE_CODE_FK_PK") = txtCode.Text
        Next
        Me.PREDISPMAX.Update(DsTheriaque_Nomenclature2)

        Me.BindingContext(Me.MasterDataSet, "PREDISPMAX_PRE_DISP_MAXIMALE").EndCurrentEdit()
        Me.PREDISPMAX.Update(Me.DsTheriaque_Nomenclature2.PREDISPMAX_PRE_DISP_MAXIMALE)

        'Dupplication des documents
        If (DupArray IsNot Nothing) Then
            For iCount As Integer = 0 To DupArray.Count - 1
                doc.AddDocumentToAssociation((DupArray(iCount)).DO_ID, txtCode.Text, DocumentService.DocumentProvider.TypeDoc.Presentation)
            Next
            DupArray = Nothing
        End If


        UpdateCIP13()

        bModeDuplication = False
        Update_INTER_INTEROPERABLE()
        btnImporter.Enabled = True
        bSupprimer.Enabled = True

    End Sub


    Public Overrides Sub annuler()
        OnLoading = True
        MyBase.Annuler()

        Me.BindingContext(Me.MasterDataSet, PRECSVTX_TEXTE_CONSERV).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.PRECSVTX_TEXTE_CONSERV.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, PRESMR_PRE_SMR_ATR).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.PRESMR_PRE_SMR_ATR.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, PREDITX_TEXTE_DISPENSAT).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.PREDITX_TEXTE_DISPENSAT.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, PREDICO_COMMENT_DISPENSAT).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.PREDICO_COMMENT_DISPENSAT.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, PERCS_PERIODE_COND_CSV).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.PERCS_PERIODE_COND_CSV.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, PREPER_PRESENTATION_PERIO_CSV).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.PREPER_PRESENTATION_PERIO_CSV.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, PRESTRTX_TEXTE_STAT_REMBOURST).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.PRESTRTX_TEXTE_STAT_REMBOURST.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, PRESTR_STATUT_REMBOURST).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.PRESTR_STATUT_REMBOURST.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, PRESTC_STATUTCOMP_PRESENT).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.PRESTC_STATUTCOMP_PRESENT.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, PRESTP_PRE_STP).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.PRESTP_PRE_STP.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, PRETSSH_PRE_TAUX_HOP).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.PRETSSH_PRE_TAUX_HOP.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, PREDISP_PRE_DISPENSATION).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.PREDISP_PRE_DISPENSATION.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, PREMAT_PRE_MATERIAU).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.PREMAT_PRE_MATERIAU.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, PREUCD_COMMENT_DOSEUCD).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.PREUCD_COMMENT_DOSEUCD.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, COCONT_COMPO_CONTENANT).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.COCONT_COMPO_CONTENANT.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, PRECONT_PRE_CONTENANT).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.PRECONT_PRE_CONTENANT.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, PRECAR_PRESENTATION_CARACTCOMP).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.PRECAR_PRESENTATION_CARACTCOMP.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, PRECEMB_PRE_CAREMBALLAGE).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.PRECEMB_PRE_CAREMBALLAGE.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, PRETSS_PRESENTATION_TAUX).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.PRETSS_PRESENTATION_TAUX.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, FORPRE_FORFAIT_PRE).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.FORPRE_FORFAIT_PRE.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, PRIPRE_PRIX_PRESENTATION).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.PRIPRE_PRIX_PRESENTATION.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, PREDILI_LIEU_DISPENSAT).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.PREDILI_LIEU_DISPENSAT.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, PRE_PRESENTATION).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.PRE_PRESENTATION.RejectChanges()

        PrevolsoL.FillByCode(Me.DsTheriaque_Nomenclature2.PREVOLSOL_VOLUME_SOLUTION, txtCode.Text)

        Me.PREDISPMAX.FillByCode(Me.DsTheriaque_Nomenclature2.PREDISPMAX_PRE_DISP_MAXIMALE, txtCode.Text)

        If (txtCode.Text.Trim.Equals("")) Then
            lkupUCD.EditValue = ""
        Else
            Dim valueCode As String = Me.PrE_TA.GetDataByCode(txtCode.Text).Rows(0).Item("PRE_NATUCD_CDF_CODE_FK").ToString()
            Dim valueNumero As String = Me.PrE_TA.GetDataByCode(txtCode.Text).Rows(0).Item("PRE_NATUCD_CDF_NUM_FK").ToString()
            lkupUCD.EditValue = valueCode & "_" & valueNumero
        End If

        If bModeDuplication Then EmptyDataTable()
        bModeDuplication = False
        OnLoading = False
    End Sub

#End Region

    ''' <summary>
    ''' affecter les datasource aux Grid
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitDataSource()

        GC.DataSource = DsTheriaque_Nomenclature2
        GC.DataMember = "PREDISP_PRE_DISPENSATION"

        GC1.DataSource = DsTheriaque_Nomenclature2
        GC1.DataMember = "PREUCD_COMMENT_DOSEUCD"

        GC2.DataSource = DsTheriaque_Nomenclature2
        GC2.DataMember = "COCONT_COMPO_CONTENANT"

        GC3.DataSource = DsTheriaque_Nomenclature2
        GC3.DataMember = "COCONT_COMPO_CONTENANT.FK2_PRECONT_PRE_CONTENANT"

        GC4.DataSource = DsTheriaque_Nomenclature2
        GC4.DataMember = "COCONT_COMPO_CONTENANT.FK2_PREMAT_PRE_MATERIAU"

        GC5.DataSource = DsTheriaque_Nomenclature2
        GC5.DataMember = "COCONT_COMPO_CONTENANT.FK2_PRECAR_PRESENT_CARACTCOMP"

        GC6.DataSource = DsTheriaque_Nomenclature2
        GC6.DataMember = "PRECEMB_PRE_CAREMBALLAGE"

        GC7.DataSource = DsTheriaque_Nomenclature2
        GC7.DataMember = "PRETSS_PRESENTATION_TAUX"

        GC8.DataSource = DsTheriaque_Nomenclature2
        GC8.DataMember = "PRETSSH_PRE_TAUX_HOP"

        GC9.DataSource = DsTheriaque_Nomenclature2
        GC9.DataMember = "PRESTP_PRE_STP"

        GC10.DataSource = DsTheriaque_Nomenclature2
        GC10.DataMember = "PRESTC_STATUTCOMP_PRESENT"

        GC11.DataSource = DsTheriaque_Nomenclature2
        GC11.DataMember = "PRESTR_STATUT_REMBOURST"

        GC12.DataSource = DsTheriaque_Nomenclature2
        GC12.DataMember = "PRESTRTX_TEXTE_STAT_REMBOURST"

        GC13.DataSource = DsTheriaque_Nomenclature2
        GC13.DataMember = "PREPER_PRESENTATION_PERIO_CSV"

        GC14.DataSource = DsTheriaque_Nomenclature2
        GC14.DataMember = "PREPER_PRESENTATION_PERIO_CSV.FK_PREPER_PRESENTATION_PERIO_CSV_PERCS_PERIODE_COND_CSV"

        GC15.DataSource = DsTheriaque_Nomenclature2
        GC15.DataMember = "PRECSVTX_TEXTE_CONSERV"

        GC16.DataSource = DsTheriaque_Nomenclature2
        GC16.DataMember = "PREDILI_LIEU_DISPENSAT"

        GC17.DataSource = DsTheriaque_Nomenclature2
        GC17.DataMember = "PREDICO_COMMENT_DISPENSAT"

        GC18.DataSource = DsTheriaque_Nomenclature2
        GC18.DataMember = "PREDITX_TEXTE_DISPENSAT"

        GC19.DataSource = DsTheriaque_Nomenclature2
        GC19.DataMember = "PRESMR_PRE_SMR_ATR"

        GC20.DataSource = DsTheriaque_Nomenclature2
        GC20.DataMember = "PRECPSS"

        GCDisp.DataSource = DsTheriaque_Nomenclature2
        GCDisp.DataMember = "PREDISPMAX_PRE_DISP_MAXIMALE"

    End Sub



    Private Sub EmptyDataTable()

        Me.DsTheriaque_Nomenclature2.PRECSVTX_TEXTE_CONSERV.Clear()
        Me.DsTheriaque_Nomenclature2.PRESMR_PRE_SMR_ATR.Clear()
        Me.DsTheriaque_Nomenclature2.PREDITX_TEXTE_DISPENSAT.Clear()
        Me.DsTheriaque_Nomenclature2.PREDICO_COMMENT_DISPENSAT.Clear()
        Me.DsTheriaque_Nomenclature2.PREDILI_LIEU_DISPENSAT.Clear()
        Me.DsTheriaque_Nomenclature2.PERCS_PERIODE_COND_CSV.Clear()
        Me.DsTheriaque_Nomenclature2.PREPER_PRESENTATION_PERIO_CSV.Clear()
        Me.DsTheriaque_Nomenclature2.PRESTRTX_TEXTE_STAT_REMBOURST.Clear()
        Me.DsTheriaque_Nomenclature2.PRESTR_STATUT_REMBOURST.Clear()
        Me.DsTheriaque_Nomenclature2.PRESTC_STATUTCOMP_PRESENT.Clear()
        Me.DsTheriaque_Nomenclature2.PRESTP_PRE_STP.Clear()
        Me.DsTheriaque_Nomenclature2.PRETSSH_PRE_TAUX_HOP.Clear()
        Me.DsTheriaque_Nomenclature2.PREDISP_PRE_DISPENSATION.Clear()
        Me.DsTheriaque_Nomenclature2.PREUCD_COMMENT_DOSEUCD.Clear()
        Me.DsTheriaque_Nomenclature2.PREMAT_PRE_MATERIAU.Clear()
        Me.DsTheriaque_Nomenclature2.PRECONT_PRE_CONTENANT.Clear()
        Me.DsTheriaque_Nomenclature2.PRECAR_PRESENTATION_CARACTCOMP.Clear()
        Me.DsTheriaque_Nomenclature2.COCONT_COMPO_CONTENANT.Clear()
        Me.DsTheriaque_Nomenclature2.PRECEMB_PRE_CAREMBALLAGE.Clear()
        Me.DsTheriaque_Nomenclature2.PRETSS_PRESENTATION_TAUX.Clear()
        Me.DsTheriaque_Nomenclature2.FORPRE_FORFAIT_PRE.Clear()
        Me.DsTheriaque_Nomenclature2.PRIPRE_PRIX_PRESENTATION.Clear()
        Me.DsTheriaque_Nomenclature2.PRE_PRESENTATION.Clear()
        Me.DsTheriaque_Nomenclature2.PRECPSS.Clear()
        Me.DsTheriaque_Nomenclature2.PREDISPMAX_PRE_DISP_MAXIMALE.Clear()
    End Sub


    ''' <summary>
    ''' Proçédure: Duplication des données à partir d'une autre fiche
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    ''' 
    ''' <summary>
    ''' Proçédure: Duplication des données à partir d'une autre fiche
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    ''' 
    Public Overrides Sub Dupliquer()
        btImporter.Enabled = False
        If Not Tab_TA1 And CodE <> InvalideControl And CodE <> Nothing Then LoadTab_1()
        If Not Tab_TA2 And CodE <> InvalideControl And CodE <> Nothing Then LoadTab_2()
        If Not Tab_TA3 And CodE <> InvalideControl And CodE <> Nothing Then LoadTab_3()
        If Not Tab_TA4 And CodE <> InvalideControl And CodE <> Nothing Then LoadTab_4()
        Me.lkupUCD.EditValue = ""

        'Sauvegarde des données à duplquer
        doc = New DocumentService.DocumentProvider(strConnexion)
        DupArray = doc.GetDocsByTypeDoc(txtCode.Text, DocumentService.DocumentProvider.TypeDoc.Presentation)

        'Onglet1
        Dim dt1 As New DataTable
        dt1 = DsTheriaque_Nomenclature2.PREUCD_COMMENT_DOSEUCD.Copy

        Dim dt2 As New DataTable
        dt2 = DsTheriaque_Nomenclature2.COCONT_COMPO_CONTENANT.Copy

        Dim dt3 As New DataTable
        dt3 = DsTheriaque_Nomenclature2.PRECONT_PRE_CONTENANT.Copy

        Dim dt4 As New DataTable
        dt4 = DsTheriaque_Nomenclature2.PREMAT_PRE_MATERIAU.Copy

        Dim dt5 As New DataTable
        dt5 = DsTheriaque_Nomenclature2.PRECAR_PRESENTATION_CARACTCOMP.Copy

        'Onglet2
        Dim dt6 As New DataTable
        dt6 = DsTheriaque_Nomenclature2.PRECEMB_PRE_CAREMBALLAGE.Copy

        Dim sText1 As String = MemoEdit1.Text
        Dim sLkupPreUnitaire As String = Me.BindingContext(DsTheriaque_Nomenclature2, PRE_PRESENTATION).Current("PRE_CDF_PU_CODE_FK").ToString

        'Onglet2
        Dim dt9 As New DataTable
        dt9 = DsTheriaque_Nomenclature2.PRESTP_PRE_STP.Copy

        Dim dt10 As New DataTable
        dt10 = DsTheriaque_Nomenclature2.PRESTC_STATUTCOMP_PRESENT.Copy

        Dim dt11 As New DataTable
        dt11 = DsTheriaque_Nomenclature2.PRESTR_STATUT_REMBOURST.Copy

        Dim sText2 As String = MemoEdit2.Text

        'Onglet3
        Dim dt12 As New DataTable
        dt12 = DsTheriaque_Nomenclature2.PRESTRTX_TEXTE_STAT_REMBOURST.Copy

        Dim dt13 As New DataTable
        dt13 = DsTheriaque_Nomenclature2.PREPER_PRESENTATION_PERIO_CSV.Copy

        Dim dt14 As New DataTable
        dt14 = DsTheriaque_Nomenclature2.PERCS_PERIODE_COND_CSV.Copy

        Dim dt15 As New DataTable
        dt15 = DsTheriaque_Nomenclature2.PRECSVTX_TEXTE_CONSERV.Copy

        'Onglet4
        Dim sText3 As String = TextEdit1.Text

        Dim dt16 As New DataTable
        dt16 = DsTheriaque_Nomenclature2.PREDILI_LIEU_DISPENSAT.Copy

        Dim dt17 As New DataTable
        dt17 = DsTheriaque_Nomenclature2.PREDICO_COMMENT_DISPENSAT.Copy

        Dim dt18 As New DataTable
        dt18 = DsTheriaque_Nomenclature2.PREDISPMAX_PRE_DISP_MAXIMALE.Copy

        Dim sLkupListe As String = Me.BindingContext(DsTheriaque_Nomenclature2, PRE_PRESENTATION).Current("PRE_CDF_LI_CODE_FK").ToString
        Dim sLkupATC As String = Me.BindingContext(DsTheriaque_Nomenclature2, PRE_PRESENTATION).Current("PRE_CATC_CODE_FK").ToString
        Dim sLkupEphmra As String = Me.BindingContext(DsTheriaque_Nomenclature2, PRE_PRESENTATION).Current("PRE_CEPH_CODE_FK").ToString
        Dim sLkupPreHospitaliere As String = Me.BindingContext(DsTheriaque_Nomenclature2, PRE_PRESENTATION).Current("PRE_CDF_RH_CODE_FK").ToString

        'Vider les contrôles
        EmptyDataTable()

        'Construction de la nouvelle fiche avec les données de la fiche de base
        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        'SetCode_MAx(MasterTable, txtCode)
        CodE = InvalideControl

        Dim drTemp As DataRow
        For iCount As Integer = 0 To dt1.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature2.Tables("PREUCD_COMMENT_DOSEUCD").NewRow()
            drTemp.ItemArray = dt1.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature2.Tables("PREUCD_COMMENT_DOSEUCD").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt2.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature2.Tables("COCONT_COMPO_CONTENANT").NewRow()
            drTemp.ItemArray = dt2.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature2.Tables("COCONT_COMPO_CONTENANT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt3.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature2.Tables("PRECONT_PRE_CONTENANT").NewRow()
            drTemp.ItemArray = dt3.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature2.Tables("PRECONT_PRE_CONTENANT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt4.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature2.Tables("PREMAT_PRE_MATERIAU").NewRow()
            drTemp.ItemArray = dt4.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature2.Tables("PREMAT_PRE_MATERIAU").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt5.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature2.Tables("PRECAR_PRESENTATION_CARACTCOMP").NewRow()
            drTemp.ItemArray = dt5.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature2.Tables("PRECAR_PRESENTATION_CARACTCOMP").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt6.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature2.Tables("PRECEMB_PRE_CAREMBALLAGE").NewRow()
            drTemp.ItemArray = dt6.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature2.Tables("PRECEMB_PRE_CAREMBALLAGE").Rows.Add(drTemp)
        Next

        MemoEdit1.Text = sText1
        If sLkupPreUnitaire <> "" Then Me.BindingContext(DsTheriaque_Nomenclature2, PRE_PRESENTATION).Current("PRE_CDF_PU_CODE_FK") = sLkupPreUnitaire

        For iCount As Integer = 0 To dt9.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature2.Tables("PRESTP_PRE_STP").NewRow()
            drTemp.ItemArray = dt9.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature2.Tables("PRESTP_PRE_STP").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt10.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature2.Tables("PRESTC_STATUTCOMP_PRESENT").NewRow()
            drTemp.ItemArray = dt10.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature2.Tables("PRESTC_STATUTCOMP_PRESENT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt11.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature2.Tables("PRESTR_STATUT_REMBOURST").NewRow()
            drTemp.ItemArray = dt11.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature2.Tables("PRESTR_STATUT_REMBOURST").Rows.Add(drTemp)
        Next

        MemoEdit2.Text = sText2

        For iCount As Integer = 0 To dt12.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature2.Tables("PRESTRTX_TEXTE_STAT_REMBOURST").NewRow()
            drTemp.ItemArray = dt12.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature2.Tables("PRESTRTX_TEXTE_STAT_REMBOURST").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt13.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature2.Tables("PREPER_PRESENTATION_PERIO_CSV").NewRow()
            drTemp.ItemArray = dt13.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature2.Tables("PREPER_PRESENTATION_PERIO_CSV").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt14.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature2.Tables("PERCS_PERIODE_COND_CSV").NewRow()
            drTemp.ItemArray = dt14.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature2.Tables("PERCS_PERIODE_COND_CSV").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt15.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature2.Tables("PRECSVTX_TEXTE_CONSERV").NewRow()
            drTemp.ItemArray = dt15.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature2.Tables("PRECSVTX_TEXTE_CONSERV").Rows.Add(drTemp)
        Next

        TextEdit1.Text = sText3


        For iCount As Integer = 0 To dt16.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature2.Tables("PREDILI_LIEU_DISPENSAT").NewRow()
            drTemp.ItemArray = dt16.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature2.Tables("PREDILI_LIEU_DISPENSAT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt17.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature2.Tables("PREDICO_COMMENT_DISPENSAT").NewRow()
            drTemp.ItemArray = dt17.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature2.Tables("PREDICO_COMMENT_DISPENSAT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt18.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature2.Tables("PREDISPMAX_PRE_DISP_MAXIMALE").NewRow()
            drTemp.ItemArray = dt18.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature2.Tables("PREDISPMAX_PRE_DISP_MAXIMALE").Rows.Add(drTemp)
        Next

        If sLkupListe <> "" Then Me.BindingContext(DsTheriaque_Nomenclature2, PRE_PRESENTATION).Current("PRE_CDF_LI_CODE_FK") = sLkupListe
        If sLkupATC <> "" Then Me.BindingContext(DsTheriaque_Nomenclature2, PRE_PRESENTATION).Current("PRE_CATC_CODE_FK") = sLkupATC
        If sLkupEphmra <> "" Then Me.BindingContext(DsTheriaque_Nomenclature2, PRE_PRESENTATION).Current("PRE_CEPH_CODE_FK") = sLkupEphmra
        If sLkupPreHospitaliere <> "" Then Me.BindingContext(DsTheriaque_Nomenclature2, PRE_PRESENTATION).Current("PRE_CDF_RH_CODE_FK") = sLkupPreHospitaliere

        'ModifierCode()
        bModeDuplication = True
        MyBase.Dupliquer()
        'Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        XtraTabControl1.SelectedTabPageIndex = 0
        btnImporter.Enabled = False
        bSupprimer.Enabled = False

    End Sub

    ''' <summary>
    ''' Proçédure: Modifier code Master de la fiche
    ''' </summary>
    Private Sub ModifierCode()
        'GV1
        For iCount As Integer = 0 To GV1.RowCount - 1
            GV1.SetRowCellValue(iCount, colPREUCD_PRE_CODE_FK_PK, Me.txtCode.Text)
        Next
        ''GV2
        'For iCount As Integer = 0 To GV2.RowCount - 1
        '    GV2.SetRowCellValue(iCount, colCOCONT_PRE_CODE_FK_PK, Me.txtCode.Text)
        'Next
        ''GV3
        'For iCount As Integer = 0 To GV3.RowCount - 1
        '    GV3.SetRowCellValue(iCount, colPRECONT_PRE_CODE_FK_PK, Me.txtCode.Text)
        'Next
        ''GV4
        'For iCount As Integer = 0 To GV4.RowCount - 1
        '    GV4.SetRowCellValue(iCount, colPREMAT_PRE_CODE_FK_PK, Me.txtCode.Text)
        'Next
        ''GV5
        'For iCount As Integer = 0 To GV5.RowCount - 1
        '    GV5.SetRowCellValue(iCount, colPRECAR_PRE_CODE_FK_PK, Me.txtCode.Text)
        'Next

        'pour les relations Master-detail

        For iCount As Integer = 0 To DsTheriaque_Nomenclature2.COCONT_COMPO_CONTENANT.Rows.Count - 1
            DsTheriaque_Nomenclature2.COCONT_COMPO_CONTENANT.Rows(iCount)("COCONT_PRE_CODE_FK_PK") = Me.txtCode.Text
        Next

        For iCount As Integer = 0 To DsTheriaque_Nomenclature2.PRECONT_PRE_CONTENANT.Rows.Count - 1
            DsTheriaque_Nomenclature2.PRECONT_PRE_CONTENANT.Rows(iCount)("PRECONT_PRE_CODE_FK_PK") = Me.txtCode.Text
        Next

        For iCount As Integer = 0 To DsTheriaque_Nomenclature2.PREMAT_PRE_MATERIAU.Rows.Count - 1
            DsTheriaque_Nomenclature2.PREMAT_PRE_MATERIAU.Rows(iCount)("PREMAT_PRE_CODE_FK_PK") = Me.txtCode.Text
        Next

        For iCount As Integer = 0 To DsTheriaque_Nomenclature2.PRECAR_PRESENTATION_CARACTCOMP.Rows.Count - 1
            DsTheriaque_Nomenclature2.PRECAR_PRESENTATION_CARACTCOMP.Rows(iCount)("PRECAR_PRE_CODE_FK_PK") = Me.txtCode.Text
        Next

        For iCount As Integer = 0 To DsTheriaque_Nomenclature2.PREPER_PRESENTATION_PERIO_CSV.Rows.Count - 1
            DsTheriaque_Nomenclature2.PREPER_PRESENTATION_PERIO_CSV.Rows(iCount)("PREPER_PRE_CODE_FK_PK") = Me.txtCode.Text
        Next

        For iCount As Integer = 0 To DsTheriaque_Nomenclature2.PERCS_PERIODE_COND_CSV.Rows.Count - 1
            DsTheriaque_Nomenclature2.PERCS_PERIODE_COND_CSV.Rows(iCount)("PERCS_PRE_CODE_FK_PK") = Me.txtCode.Text
        Next


        'GV6
        For iCount As Integer = 0 To GV6.RowCount - 1
            GV6.SetRowCellValue(iCount, colPRECEMB_PRE_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV9
        For iCount As Integer = 0 To GV9.RowCount - 1
            GV9.SetRowCellValue(iCount, colPRESTP_PRE_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV10
        For iCount As Integer = 0 To GV10.RowCount - 1
            GV10.SetRowCellValue(iCount, colPRESTC_PRE_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV11
        For iCount As Integer = 0 To GV11.RowCount - 1
            GV11.SetRowCellValue(iCount, colPRESTR_PRE_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV12
        For iCount As Integer = 0 To GV12.RowCount - 1
            GV12.SetRowCellValue(iCount, colPRESTRTX_PRE_CODE_FK_PK, Me.txtCode.Text)
        Next
        ''GV13
        'For iCount As Integer = 0 To GV13.RowCount - 1
        '    GV13.SetRowCellValue(iCount, colPREPER_PRE_CODE_FK_PK, Me.txtCode.Text)
        'Next
        ''GV14
        'For iCount As Integer = 0 To GV14.RowCount - 1
        '    GV14.SetRowCellValue(iCount, colPERCS_PRE_CODE_FK_PK, Me.txtCode.Text)
        'Next

        'GV15
        For iCount As Integer = 0 To GV15.RowCount - 1
            GV15.SetRowCellValue(iCount, colPRECSVTX_PRE_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV16
        For iCount As Integer = 0 To GV16.RowCount - 1
            GV16.SetRowCellValue(iCount, colPREDILI_PRE_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV17
        For iCount As Integer = 0 To GV17.RowCount - 1
            GV17.SetRowCellValue(iCount, colPREDICO_PRE_CODE_FK_PK, Me.txtCode.Text)
        Next
    End Sub

    Private Sub Update_INTER_INTEROPERABLE()
        Dim sSql As String = ""
        Dim pre_admin As String = TextEdit7.Text
        Dim etat_commercial As String = cmbEtatComercial.Text
        If ModeFiche = eMode.Modification Then
            If Not Onglet2_Parcouru Then
                If Not Me.DsTheriaque_Nomenclature2.PRE_PRESENTATION.Item(0).IsPRE_ADMINNull Then
                    pre_admin = Me.DsTheriaque_Nomenclature2.PRE_PRESENTATION.Item(0).PRE_ADMIN
                End If
            End If
            If Not Onglet3_Parcouru Then
                If Not Me.DsTheriaque_Nomenclature2.PRE_PRESENTATION.Item(0).IsPRE_ETAT_COMMERNull Then
                    etat_commercial = Me.DsTheriaque_Nomenclature2.PRE_PRESENTATION.Item(0).PRE_ETAT_COMMER
                End If
            End If
        End If
        If ModeFiche = eMode.Ajout Or ModeFiche = eMode.Duplication Then
            DeleteCIPFrom_INTER_INTEROPERABLE()
            sSql = "INSERT INTO THERIAQUE.INTER_INTEROPERABLE("
            sSql &= "INTER_SP_CODE, "
            sSql &= "INTER_SP_NOM, "
            sSql &= "INTER_SP_NL, "
            sSql &= "INTER_SP_CIPUCD, "
            sSql &= "INTER_SP_NOMLONG, "
            sSql &= "INTER_SP_CIPUCD13,"
            sSql &= "INTER_PRE_ADMIN,"
            sSql &= "INTER_PRE_ETAT_COMMER,"
            sSql &= "INTER_PRE_CODE, "
            sSql &= "INTER_PRE_EAN_REF) "
            sSql &= "SELECT " & cn.SQLText(lkupSP.EditValue) & ", SP_NOM, SP_NL, SP_CIPUCD, SP_NOMLONG, SP_CIPUCD13, "
            sSql &= cn.SQLText(pre_admin) & ", " & cn.SQLText(etat_commercial) & ", " & cn.SQLText(txtCode.Text) & ", " & cn.SQLText(txtEAN.Text)
            sSql &= " FROM THERIAQUE.SP_SPECIALITE WHERE SP_CODE_SQ_PK = " & cn.SQLText(lkupSP.EditValue)
            cn.Execute(sSql)
        End If
        If ModeFiche = eMode.Modification Then
            'le Code de la spécialité assigné à cette présentation est modifié
            If LastCodeSP <> lkupSP.EditValue.ToString() Then
                DeleteCIPFrom_INTER_INTEROPERABLE()
                sSql = "INSERT INTO THERIAQUE.INTER_INTEROPERABLE("
                sSql &= "INTER_SP_CODE, "
                sSql &= "INTER_SP_NOM, "
                sSql &= "INTER_SP_NL, "
                sSql &= "INTER_SP_CIPUCD, "
                sSql &= "INTER_SP_NOMLONG, "
                sSql &= "INTER_SP_CIPUCD13,"
                sSql &= "INTER_PRE_ADMIN,"
                sSql &= "INTER_PRE_ETAT_COMMER,"
                sSql &= "INTER_PRE_CODE, "
                sSql &= "INTER_PRE_EAN_REF) "
                sSql &= "SELECT " & cn.SQLText(lkupSP.EditValue) & ", SP_NOM, SP_NL, SP_CIPUCD, SP_NOMLONG, SP_CIPUCD13, "
                sSql &= cn.SQLText(pre_admin) & ", " & cn.SQLText(etat_commercial) & ", " & cn.SQLText(txtCode.Text) & ", " & cn.SQLText(txtEAN.Text)
                sSql &= " FROM THERIAQUE.SP_SPECIALITE WHERE SP_CODE_SQ_PK = " & cn.SQLText(lkupSP.EditValue)
                cn.Execute(sSql)
            Else
                'le Code de la spécialité assigné à cette présentation n'a pas changé
                sSql = "UPDATE THERIAQUE.INTER_INTEROPERABLE SET INTER_PRE_ADMIN =" & cn.SQLText(pre_admin) & ", INTER_PRE_ETAT_COMMER = " & cn.SQLText(etat_commercial) & ", INTER_PRE_EAN_REF = " & cn.SQLText(txtEAN.Text) & " WHERE INTER_PRE_CODE = " & cn.SQLText(txtCode.Text)
                cn.Execute(sSql)
            End If
        End If

    End Sub

    Private Sub DeleteCIPFrom_INTER_INTEROPERABLE()
        Dim sSql As String = ""
        sSql = "DELETE FROM THERIAQUE.INTER_INTEROPERABLE WHERE INTER_PRE_CODE = " & cn.SQLText(txtCode.Text)
        cn.Execute(sSql)
    End Sub

    Private Function GetLastSP() As String
        Dim CodeSP As String = ""
        Dim dt As DataTable
        dt = cn.MySelect("SELECT INTER_SP_CODE  FROM THERIAQUE.INTER_INTEROPERABLE  WHERE INTER_PRE_CODE = " & cn.SQLText(txtCode.Text))
        If dt.Rows.Count > 0 Then
            If dt.Rows(0)(0) IsNot DBNull.Value Then
                CodeSP = dt.Rows(0)(0)
            End If
        End If
        Return CodeSP
    End Function

    'Private Function CIP_Exist(Optional ByVal sCodeCIP As String = "", Optional ByVal sCodeSP As String = "") As Boolean
    '    CIP_Exist = False
    '    Dim dtTemp As DataTable
    '    Dim sSql As String
    '    sSql = " SELECT * FROM THERIAQUE.INTER_INTEROPERABLE WHERE INTER_PRE_CODE = " & cn.SQLText(sCodeCIP) & " AND INTER_SP_CODE <> " & cn.SQLText(sCodeSP)
    '    dtTemp = cn.MySelect(sSql)
    '    If dtTemp.Rows.Count > 0 Then
    '        CIP_Exist = True
    '        Exit Function
    '    End If
    'End Function

    Private Sub Frm_Presentation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO : cette ligne de code charge les données dans la table 'DsTheriaque_Nomenclature2.PRECPSS'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        'Me.PRECPSSTableAdapter.FillBy(Me.DsTheriaque_Nomenclature2.PRECPSS)
        'TODO : cette ligne de code charge les données dans la table 'DsTheriaqueDocument.DOC_Document_PRES'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.MasterDataSet = Me.DsTheriaque_Nomenclature2
        Me.MasterTable = PRE_PRESENTATION
        CodE = InvalideControl
        OnLoading = True

        InitLkup(lkupSP, SP_SPECIALITE, strSSQL_SP_SPECIALITE, True)
        InitLkup(lkupSP2, SP_SPECIALITE, strSSQL_SP_SPECIALITE, False, True, True, True)
        InitLkup(lkupPrise, CDF_CODIF, strSSQL_CDF_CODIF("20"), True)
        InitLkup(lkupCont, CDF_CODIF, strSSQL_CDF_CODIF("22"), True)
        InitLkup(rpUnite, CDF_CODIF, strSSQL_CDF_CODIF("19"), True)
        InitLkup(lkupUCD, CDF_CODIF, strSSQL_IN_CDF_CODIF_Compose("04", "06"), True, , , , , , , True)
        InitLkup(rpCommentaire, CDF_CODIF, strSSQL_CDF_CODIF("31"), True)
        InitLkup(rpNBCont, CDF_CODIF, strSSQL_CDF_CODIF("04"), True)
        InitLkup(rpContenuReel, CDF_CODIF, strSSQL_CDF_CODIF("21"), True)
        InitLkup(rpContPossible, CDF_CODIF, strSSQL_CDF_CODIF("21"), True)
        InitLkup(rpMat, CDF_CODIF, strSSQL_CDF_CODIF("09"), True)
        InitLkup(rpCrtCmpl, CDF_CODIF, strSSQL_CDF_CODIF("01"), True)
        InitLkup(rpCDF_CODIF, CDF_CODIF, strSSQL_CDF_CODIF("32"), True)
        InitLkup(lkupUnite, CDF_CODIF, strSSQL_CDF_CODIF("21"), True)

        InitLkup(lkupDispMax, CDF_CODIF, strSSQL_CDF_CODIF("34"), True)

        doc = New DocumentService.DocumentProvider(strConnexion)

        Dim dt As New DataTable
        dt = doc.GetAllCategories()
        Me.lueCategorie.Properties.DataSource = dt

        InitDataSource()
        FirstFocus = txtCode
        FirstFocus = txtCode
        If _Code <> Nothing Then
            Load_On(Me)
            Open_Fiche(_Code)

            doc = New DocumentService.DocumentProvider(strConnexion)
            Me.gcDocuments.DataSource = doc.GetDocsByTypeDoc(_Code, DocumentService.DocumentProvider.TypeDoc.Presentation)

            ModeFiche = eMode.Consultation
            UpdateStateBouton()
            Initcomponent()
            Load_Off(Me)
        End If
        OnLoading = False
    End Sub

    'Private Sub cmbNatureUCD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNatureUCD.SelectedIndexChanged
    '    Dim dv As DataView = lkupUCD.Properties.DataSource.defaultview
    '    If Me.cmbNatureUCD.Text <> "" Then
    '        dv.RowFilter = " num = " & Me.cmbNatureUCD.Text
    '    Else
    '        dv.RowFilter = ""
    '    End If
    'End Sub

    Private Sub lkupSP_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lkupSP.EditValueChanged
        Me.DsTheriaque_Nomenclature2.PREDISP_PRE_DISPENSATION.Clear()
        If OnLoading = True Then
            If lkupSP2.Text IsNot DBNull.Value And lkupSP2.Text <> "" Then
                Dim dt As DataTable = cn.MySelect("SELECT * FROM THERIAQUE.SP_SPECIALITE WHERE SP_CODE_SQ_PK = " & lkupSP2.Text)
                Me.BindingContext(Me.MasterDataSet, "PRE_PRESENTATION").Current("PRE_CDF_LI_CODE_FK") = dt.Rows(0)("SP_CDF_LI_CODE_FK")
                Me.BindingContext(Me.MasterDataSet, "PRE_PRESENTATION").Current("PRE_CATC_CODE_FK") = dt.Rows(0)("SP_CATC_CODE_FK")
                Me.BindingContext(Me.MasterDataSet, "PRE_PRESENTATION").Current("PRE_CEPH_CODE_FK") = dt.Rows(0)("SP_CEPH_CODE_FK")
                InitLkup(rpSubACT, SAC_SUBACTIVE, strSSQL_SAC_SP(lkupSP2.Text), True)
            End If
        Else
            If lkupSP.EditValue IsNot DBNull.Value Then
                Dim dt As DataTable = cn.MySelect("SELECT * FROM THERIAQUE.SP_SPECIALITE WHERE SP_CODE_SQ_PK = " & lkupSP.EditValue)
                lkup_Liste.EditValue = dt.Rows(0)("SP_CDF_LI_CODE_FK")
                lkupATC.EditValue = dt.Rows(0)("SP_CATC_CODE_FK")
                lkupEPH.EditValue = dt.Rows(0)("SP_CEPH_CODE_FK")
                lkupATC2.EditValue = dt.Rows(0)("SP_CATC_CODE_FK")
                lkupEPH2.EditValue = dt.Rows(0)("SP_CEPH_CODE_FK")
                InitLkup(rpSubACT, SAC_SUBACTIVE, strSSQL_SAC_SP(lkupSP.EditValue), True)
            End If
        End If
    End Sub

#Region " Grid View "

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        If OnLoading Then
            Exit Sub
        End If
        Me.GV.SetRowCellValue(e.RowHandle, colPREDISP_PRE_CODE_FK_PK, txtCode.Text)
        GV.SetFocusedRowCellValue(colPREDISP_NUMSEQ_PK, Code_MAx(GV, colPREDISP_NUMSEQ_PK))
    End Sub

    Private Sub GV1_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV1.InitNewRow
        If OnLoading Then
            Exit Sub
        End If
        Me.GV1.SetRowCellValue(e.RowHandle, colPREUCD_PRE_CODE_FK_PK, txtCode.Text)
        Me.GV1.SetFocusedRowCellValue(colPREUCD_NUMORD, Code_MAx(GV1, colPREUCD_NUMORD))
    End Sub

    Private Sub GV2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        If OnLoading Then
            Exit Sub
        End If
        'me.DsTheriaque_Nomenclature2.Tables(
        Me.GV2.SetRowCellValue(e.RowHandle, colCOCONT_PRE_CODE_FK_PK, txtCode.Text)
        'Me.GV2.SetRowCellValue(e.RowHandle, colCOCONT_NUM_PK, Code_MAx(COCONT_COMPO_CONTENANT, "COCONT_NUM_PK", " where COCONT_PRE_CODE_FK_PK= " & cn.SQLText(txtCode.Text)) + 1)
        Me.GV2.SetRowCellValue(e.RowHandle, colCOCONT_NUM_PK, Code_MAx(GV2, colCOCONT_NUM_PK))
        Me.GV2.SetFocusedRowCellValue(colCOCONT_NUMORD, Code_MAx(GV2, colCOCONT_NUMORD))
    End Sub
    Private Sub GV3_RowCountChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV3.RowCountChanged
        If GV3.RowCount >= 1 Then
            GV3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
            Me.GC3.EmbeddedNavigator.Buttons.Append.Enabled = False
        Else
            GV3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            Me.GC3.EmbeddedNavigator.Buttons.Append.Enabled = False
        End If
    End Sub

    Private Sub GV6_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV6.InitNewRow
        Me.GV6.SetRowCellValue(e.RowHandle, colPRECEMB_PRE_CODE_FK_PK, txtCode.Text)
        Me.GV6.SetFocusedRowCellValue(colPRECEMB_NUMORD, Code_MAx(GV6, colPRECEMB_NUMORD))
    End Sub

    Private Sub GV9_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV9.InitNewRow
        Me.GV9.SetRowCellValue(e.RowHandle, colPRESTP_PRE_CODE_FK_PK, txtCode.Text)
        Me.GV9.SetFocusedRowCellValue(colPRESTP_NUMORD, Code_MAx(GV9, colPRESTP_NUMORD))
    End Sub

    Private Sub GV10_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV10.InitNewRow
        Me.GV10.SetRowCellValue(e.RowHandle, colPRESTC_PRE_CODE_FK_PK, txtCode.Text)
        Me.GV10.SetFocusedRowCellValue(colPRESTC_NUMORD, Code_MAx(GV10, colPRESTC_NUMORD))
    End Sub

    Private Sub GV11_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV11.InitNewRow
        Me.GV11.SetRowCellValue(e.RowHandle, colPRESTR_PRE_CODE_FK_PK, txtCode.Text)
        Me.GV11.SetFocusedRowCellValue(colPRESTR_NUMORD, Code_MAx(GV11, colPRESTR_NUMORD))
    End Sub

    Private Sub GV7_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV7.InitNewRow
        Me.GV7.SetRowCellValue(e.RowHandle, colPRETSS_PRE_CODE_FK_PK, txtCode.Text)
        Me.GV7.SetFocusedRowCellValue(colPRETSS_NUMSEQ, Code_MAx(GV7, colPRETSS_NUMSEQ))
    End Sub

    Private Sub GV8_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV8.InitNewRow
        Me.GV8.SetRowCellValue(e.RowHandle, colPRETSSH_PRE_CODE_FK_PK, txtCode.Text)
        Me.GV8.SetFocusedRowCellValue(colPRETSSH_NUMSEQ, Code_MAx(GV8, colPRETSSH_NUMSEQ))
    End Sub

    Private Sub GV13_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV13.InitNewRow
        Me.GV13.SetRowCellValue(e.RowHandle, colPREPER_PRE_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV15_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV15.InitNewRow
        Me.GV15.SetRowCellValue(e.RowHandle, colPRECSVTX_PRE_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV16_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV16.InitNewRow
        Me.GV16.SetRowCellValue(e.RowHandle, colPREDILI_PRE_CODE_FK_PK, txtCode.Text)
        Me.GV16.SetFocusedRowCellValue(colPREDILI_NUMORD, Code_MAx(GV16, colPREDILI_NUMORD))
    End Sub

    Private Sub GV17_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV17.InitNewRow
        Me.GV17.SetRowCellValue(e.RowHandle, colPREDICO_PRE_CODE_FK_PK, txtCode.Text)
        Me.GV17.SetFocusedRowCellValue(colPREDICO_NUMORD, Code_MAx(GV17, colPREDICO_NUMORD))
    End Sub

    Private Sub GV18_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)
        Me.GV18.SetRowCellValue(e.RowHandle, colPREDITX_PRE_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV19_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)
        Me.GV19.SetRowCellValue(e.RowHandle, colPRESMR_PRE_CODE_FK_PK, txtCode.Text)
    End Sub

#End Region

    Private Sub LoadTab_1()
        Load_On(Me)
        OnLoading = True

        If Not Tab_lkup1 Then
            InitLkup(rpCractEmb, CDF_CODIF, strSSQL_CDF_CODIF("01"), True)
            InitLkup(lkupPresentationUnitaire, CDF_CODIF, strSSQL_CDF_CODIF("12"), True)

            InitLkup(rpTauxRBS, CDF_CODIF, strSSQL_CDF_CODIF("17"), True)
            InitLkup(rpTauxSociale, CDF_CODIF, strSSQL_CDF_CODIF("17"), True)
            Tab_lkup1 = True
        End If

        If Not Tab_TA1 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.PrecemB_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PRECEMB_PRE_CAREMBALLAGE, CodE)
            Me.PretsS_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PRETSS_PRESENTATION_TAUX, CodE)
            Me.PretssH_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PRETSSH_PRE_TAUX_HOP, CodE)
            Me.ForprE_TA.FillByCode(Me.DsTheriaque_Nomenclature2.FORPRE_FORFAIT_PRE, CodE)
            Me.PriprE_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PRIPRE_PRIX_PRESENTATION, CodE)
            Tab_TA1 = True
        End If
        lkupPresentationUnitaire.Properties.ReadOnly = False
        lkupPresentationUnitaire.Enabled = True
        lkupPresentationUnitaire.BackColor = Color.White
        OnLoading = False
        Load_Off(Me)
    End Sub

    Private Sub LoadTab_2()
        Load_On(Me)
        OnLoading = True

        If Not Tab_lkup2 Then
            InitLkup(lkPresHop, CDF_CODIF, strSSQL_CDF_CODIF("13"), True)
            InitLkup(rpStatut, CDF_CODIF, strSSQL_CDF_CODIF("14", " and substring(CDF_CODE_PK,1,1) =  'S'"), True)
            InitLkup(rpStatutC, CDF_CODIF, strSSQL_CDF_CODIF("14", " and substring(CDF_CODE_PK,1,1) =  'C'"), True)
            InitLkup(rpStatutR, CDF_CODIF, strSSQL_CDF_CODIF("14", " and substring(CDF_CODE_PK,1,1) =  'R'"), True)
            Tab_lkup2 = True
        End If

        If Not Tab_TA2 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.PrestP_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PRESTP_PRE_STP, CodE)
            Me.PrestC_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PRESTC_STATUTCOMP_PRESENT, CodE)
            Me.PrestR_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PRESTR_STATUT_REMBOURST, CodE)
            Tab_TA2 = True
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub

    Private Sub LoadTab_3()
        Load_On(Me)
        OnLoading = True

        If Not Tab_lkup3 Then
            InitLkup(rpDureeConsv, CDF_CODIF, strSSQL_CDF_CODIF("PU"), True)
            InitLkup(rpCondition, CDF_CODIF, strSSQL_CDF_CODIF("03"), True)
            Tab_lkup3 = True
        End If

        If Not Tab_TA3 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.PrestrtX_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PRESTRTX_TEXTE_STAT_REMBOURST, CodE)
            Me.PrepeR_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PREPER_PRESENTATION_PERIO_CSV, CodE)
            Me.PercS_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PERCS_PERIODE_COND_CSV, CodE)
            Me.PrecsvtX_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PRECSVTX_TEXTE_CONSERV, CodE)
            Tab_TA3 = True
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub

    Private Sub LoadTab_4()
        Load_On(Me)
        OnLoading = True
        If Not Tab_lkup4 Then
            InitLkup(rpPredili, CDF_CODIF, strSSQL_CDF_CODIF("14", " and substring(CDF_CODE_PK,1,1) =  'D'"), True)
            InitLkup(rpComDispo, CDF_CODIF, strSSQL_CDF_CODIF("29"), True)
            InitLkup(lkup_Liste, CDF_CODIF, strSSQL_CDF_CODIF("08"), True)
            InitLkup(lkupATC2, CATC_CLASSEATC, strSSQL_CATC_CLASSEATC, False, False, True, True)
            InitLkup(lkupATC, CATC_CLASSEATC, strSSQL_CATC_CLASSEATC, True)
            InitLkup(lkupEPH2, CATC_CLASSEATC, strSSQL_CEPH_CLASSEEPHMRA, False, False, True, True)
            InitLkup(lkupEPH, CATC_CLASSEATC, strSSQL_CEPH_CLASSEEPHMRA, True)
            InitLkup(rpSMR, CDF_CODIF, strSSQL_CDF_CODIF("27"), True)
            Tab_lkup4 = True
        End If

        If Not Tab_TA4 And CodE <> InvalideControl And CodE <> Nothing Then
            'Me.PrE_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PRE_PRESENTATION, CodE)
            Me.PredilI_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PREDILI_LIEU_DISPENSAT, CodE)
            Me.PredicO_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PREDICO_COMMENT_DISPENSAT, CodE)
            Me.PreditX_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PREDITX_TEXTE_DISPENSAT, CodE)
            Me.PresmR_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PRESMR_PRE_SMR_ATR, CodE)
            Tab_TA4 = True
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub

    ''' <summary>
    ''' Tester sur la page active pour charger les données correspondantes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPageIndex = 1 Then
            LoadTab_1()
            Onglet2_Parcouru = True
            Exit Sub
        End If
        If XtraTabControl1.SelectedTabPageIndex = 2 Then
            LoadTab_2()
            Onglet3_Parcouru = True
            Exit Sub
        End If
        If XtraTabControl1.SelectedTabPageIndex = 3 Then
            LoadTab_3()
            Exit Sub
        End If
        If XtraTabControl1.SelectedTabPageIndex = 4 Then
            LoadTab_4()
            Exit Sub
        End If
        If XtraTabControl1.SelectedTabPageIndex = 5 Then
            'LoadTab_5()
            Exit Sub
        End If
    End Sub

    Private Sub GV7_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV7.ValidatingEditor
        If GV7.FocusedColumn Is colPRETSS_DATE_APPLI_PK Then
            GV7.SetFocusedRowCellValue(colPRETSS_DATE_APPLIQUEE, e.Value)
        End If
    End Sub

    Private Sub GV8_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV8.ValidatingEditor
        If GV8.FocusedColumn Is colPRETSSH_DATE_APPLI_PK Then
            GV8.SetFocusedRowCellValue(colPRETSSH_DATE_APPLIQUEE, e.Value)
        End If
    End Sub

    Private Sub btPrix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPrix.Click
        Dim f As New Frm_Presentation_Prix
        f.DsTheriaque_Nomenclature21 = Me.DsTheriaque_Nomenclature2
        f.PriprE_TA = f.PriprE_TA
        f.ForprE_TA = f.ForprE_TA
        f._Code = txtCode.Text
        f.ShowDialog()
        Me.PriprE_TA = f.PriprE_TA
        Me.ForprE_TA = f.ForprE_TA
        ModeFiche = eMode.Modification
        UpdateStateBouton()
    End Sub

    Private Sub DeditRadiation_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles DeditRadiation.Validated
        If DeditApplication.EditValue Is DBNull.Value Then
            DeditApplication.EditValue = DeditRadiation.EditValue
        End If
    End Sub

    Private Sub GV12_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV12.InitNewRow
        Me.GV12.SetRowCellValue(e.RowHandle, colPRESTRTX_PRE_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV12_RowCountChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV12.RowCountChanged
        If GV12.RowCount >= 1 Then
            GV12.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
            Me.GC12.EmbeddedNavigator.Buttons.Append.Enabled = False
        Else
            GV12.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            Me.GC12.EmbeddedNavigator.Buttons.Append.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Ctrl"></param>
    ''' <param name="AllCtrl"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Friend Overrides Function ValideControl(Optional ByRef Ctrl As Control = Nothing, Optional ByVal AllCtrl As Boolean = True) As Boolean
        Dim strSSQL As String = ""
        MyBase.ValideControl(Ctrl)

        If Ctrl.Name.ToLower = "txtCode".ToLower Or AllCtrl Then
            If ModeFiche = eMode.Ajout Or ModeFiche = eMode.Duplication Then
                If Not Code_CIP_Presentation(txtCode.Text, txtCode, Me.DxErrorProvider) Then
                    Return True
                End If
            End If

        End If

        If Ctrl.Name.ToLower = "txtEAN".ToLower Or AllCtrl Then
            If Not Code_EAN(txtEAN.Text, txtCode.Text, txtEAN, Me.DxErrorProvider) Then
                Return False
            End If
        End If

        If Ctrl.Name.ToLower = "lkupPrise".ToLower Or AllCtrl Then
            If txtNBPrise.Text <> "" And lkupPrise.Text = "" Then
                Me.DxErrorProvider.SetError(lkupPrise, "Vous devez saisir une unité pour le nombre de prise")
                Return False
            Else
                Me.DxErrorProvider.SetError(lkupPrise, "")
            End If
        End If

        'If Ctrl.Name.ToLower = "txtNBPrise".ToLower Or AllCtrl Then
        '    If txtNBPrise.Text = "" And lkupPrise.Text <> "" Then
        '        Me.DxErrorProvider.SetError(lkupPrise, "Vous devez saisir un nombre de prise pour l'unité")
        '        Return False
        '    Else
        '        Me.DxErrorProvider.SetError(lkupPrise, "")
        '    End If
        'End If

        If AllCtrl Then
            If Not ValidateConditionConservation() Then
                Me.DxErrorProvider.SetError(GC14, "Les conditions de conservations sont mal paramètrés")
                Dim strMsg As String = ""
                strMsg &= " Les conditions de conservations doivent contenir un de ces paramètres:" & vbLf & vbLf
                strMsg &= " 2 = AU FRAIS (8 A 15 DEGRES)" & vbLf
                strMsg &= " 5 = AU CONGELATEUR (< A -15 DEGRES)" & vbLf
                strMsg &= " 6 = AU REFRIGERATEUR (2 A 8 DEGRES)" & vbLf
                strMsg &= " 7 = A TEMPERATURE AMBIANTE" & vbLf
                strMsg &= " 63 = AUCUNE INFORMATION" & vbLf
                Process_Message(strMsg, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub txtCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Validated, lkupPrise.Validated, txtEAN.Validated, txtVolume.Validated
        ValideControl(sender, False)
        'ModifierCode()
    End Sub

    Private Sub txtNBPrise_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNBPrise.Validating
        If sender.text = "" Then
            sender.editvalue = DBNull.Value
        End If
    End Sub

    'Private Sub GV_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV.ValidatingEditor
    '    Dim Output As Integer
    '    If Integer.TryParse(GV.GetRowCellValue(GV.FocusedRowHandle, colPREDISP_UNITEDISP).ToString, Output) Then

    '    End If

    'End Sub

    Private Sub GV2_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs)
        If GV2.RowCount > 1 Then
            If GV2.GetRowCellValue(GV2.FocusedRowHandle, colCOCONT_CDF_GAL_CODE_FK) Is DBNull.Value Then
                e.ErrorText = "Le libellé est obligatoire puisque il existe plusieurs contenant"
                e.Valid = False
            Else
                If GV2.GetRowCellValue(GV2.FocusedRowHandle, colCOCONT_CDF_GAL_CODE_FK) = "" Then
                    e.ErrorText = "Le libellé est obligatoire puisque il existe plusieurs contenant"
                    e.Valid = False
                End If
            End If
        End If
    End Sub

    Private Sub GV3_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV3.ValidateRow
        If GV3.GetRowCellValue(GV3.FocusedRowHandle, colPRECONT_NBCONTENANT) IsNot DBNull.Value Then
            If GV3.GetRowCellValue(GV3.FocusedRowHandle, colPRECONT_NBCONTENANT) = 0 Then
                GV3.SetFocusedRowCellValue(colPRECONT_NBCONTENANT, 1)
                GV3.SetRowCellValue(e.RowHandle, colPRECONT_NBCONTENANT_REEL, "N")
            Else
                GV3.SetFocusedRowCellValue(colPRECONT_NBCONTENANT_REEL, Nothing)
            End If
        End If
        If GV3.GetRowCellValue(GV3.FocusedRowHandle, colPRECONT_NBCONTENANCE) IsNot DBNull.Value Then
            If GV3.GetRowCellValue(GV3.FocusedRowHandle, colPRECONT_CDF_COCE_CODE_FK) Is DBNull.Value Then
                e.Valid = False
                e.ErrorText = "Unité Contenu réel obligatoire"
            Else
                If GV3.GetRowCellValue(GV3.FocusedRowHandle, colPRECONT_CDF_COCE_CODE_FK) = "" Then
                    e.Valid = False
                    e.ErrorText = "Unité Contenu réel obligatoire"
                Else
                    e.Valid = True
                    e.ErrorText = ""
                End If
            End If
        End If

        If GV3.GetRowCellValue(GV3.FocusedRowHandle, colPRECONT_VOLCONTENANT) IsNot DBNull.Value Then
            If GV3.GetRowCellValue(GV3.FocusedRowHandle, colPRECONT_CDF_VOLCONT_CODE_FK) Is DBNull.Value Then
                e.Valid = False
                e.ErrorText = "Unité Contenu possible obligatoire"
            Else
                If GV3.GetRowCellValue(GV3.FocusedRowHandle, colPRECONT_CDF_VOLCONT_CODE_FK) = "" Then
                    e.Valid = False
                    e.ErrorText = "Unité Contenu possible obligatoire"
                Else
                    e.Valid = True
                    e.ErrorText = ""
                End If
            End If
        End If
    End Sub

    Private Sub cmbEtatComercial_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEtatComercial.SelectedIndexChanged
        If Me.cmbEtatComercial.EditValue <> "NC" Then
            Me.DeditdispoDepuis.Enabled = True
        Else
            Me.DeditdispoDepuis.Enabled = False
        End If

        If Me.cmbEtatComercial.EditValue = "S" Then
            Me.DeditSupp.Enabled = True
        Else
            Me.DeditSupp.Enabled = False
        End If
    End Sub

    Private Function ValidateConditionConservation() As Boolean
        Dim i, j, code, code2 As Integer
        Dim dv As New DataView
        Dim boolFind As Boolean = True
        Dim strEnsemble As String = "(2,5,6,7,63)"

        dv = Me.DsTheriaque_Nomenclature2.PERCS_PERIODE_COND_CSV.DefaultView

        For i = 0 To Me.DsTheriaque_Nomenclature2.PREPER_PRESENTATION_PERIO_CSV.DefaultView.Count - 1
            boolFind = False
            code = Me.DsTheriaque_Nomenclature2.PREPER_PRESENTATION_PERIO_CSV.Rows(i)("PREPER_NUM_CODE_PK")
            dv.RowFilter = " PERCS_NUM_CODE_PK = " & code

            For j = 0 To dv.Count - 1
                code2 = dv.Item(j)("PERCS_CDF_CSV_CODE_FK_PK")
                If strEnsemble.Contains(CStr(code2)) Then
                    boolFind = True
                End If
            Next
        Next

        Return boolFind
    End Function

    Private Sub GV16_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV16.ValidateRow
        Dim i As Integer
        Dim Ok As Boolean
        If Me.GV16.GetRowCellValue(Me.GV16.FocusedRowHandle, "PREDILI_CDF_LIEU_CODE_FK_PK") = "D2" Then
            For i = 0 To Me.DsTheriaque_Nomenclature2.PREDICO_COMMENT_DISPENSAT.Rows.Count - 1
                If Me.DsTheriaque_Nomenclature2.PREDICO_COMMENT_DISPENSAT(i)("PREDICO_CDF_COM_CODE_FK_PK") = 1 Then
                    Ok = True
                End If
            Next
            If Not Ok Then
                Me.DsTheriaque_Nomenclature2.PREDICO_COMMENT_DISPENSAT.AddPREDICO_COMMENT_DISPENSATRow(txtCode.Text, 1, Code_MAx(GV17, colPREDICO_NUMORD))
                Me.BindingContext(Me.DsTheriaque_Nomenclature2, PREDICO_COMMENT_DISPENSAT).EndCurrentEdit()
            End If
        End If

        If Me.GV16.GetRowCellValue(Me.GV16.FocusedRowHandle, "PREDILI_CDF_LIEU_CODE_FK_PK") = "D1" Then
            For i = 0 To Me.DsTheriaque_Nomenclature2.PREDICO_COMMENT_DISPENSAT.Rows.Count - 1
                If Me.DsTheriaque_Nomenclature2.PREDICO_COMMENT_DISPENSAT(i)("PREDICO_CDF_COM_CODE_FK_PK") = 2 Then
                    Ok = True
                End If
            Next
            If Not Ok Then
                Me.DsTheriaque_Nomenclature2.PREDICO_COMMENT_DISPENSAT.AddPREDICO_COMMENT_DISPENSATRow(txtCode.Text, 2, Code_MAx(GV17, colPREDICO_NUMORD))
                Me.BindingContext(Me.DsTheriaque_Nomenclature2, PREDICO_COMMENT_DISPENSAT).EndCurrentEdit()
            End If
        End If

    End Sub

    Private Sub btADDSMR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btADDSMR.Click
        Dim f As New Frm_Recherche
        Dim strList As String = "SELECT SPSMR_CDF_SMR_CODE_FK_PK as code,SPSMR_NUM_ORD_PK as num , (SELECT CDF_NOM From THERIAQUE.CDF_CODIF CDF where CDF.CDF_CODE_PK = SSMR.SPSMR_CDF_SMR_CODE_FK_PK and CDF_NUMERO_PK = '27') + ' - ' + cast( SPSMR_DATE as varchar) as libelle, SPSMR_SP_CODE_FK_PK as val1, SPSMR_NUM_ORD_PK as val2, SPSMR_DATE as val3, SPATR_ATR_CODE_FK_PK as val4"
        strList &= " FROM THERIAQUE.SPATR_SPEC_AVISTRANSPARENCE, THERIAQUE.SPSMR_SERVICE_MEDICAL_RENDU SSMR, THERIAQUE.ATR_AVISCOMMISSIONTRANSPARENCE"
        strList &= " LEFT OUTER JOIN THERIAQUE.PRESMR_PRE_SMR_ATR PRESMR on PRESMR_PRE_CODE_FK_PK =" & cn.SQLText(txtCode.Text)
        If lkupSP.EditValue IsNot DBNull.Value Then
            strList &= " WHERE SPSMR_SP_CODE_FK_PK = " & lkupSP.EditValue
            strList &= " AND SPATR_SP_CODE_FK_PK = SPSMR_SP_CODE_FK_PK"
            strList &= " AND SPATR_ATR_CODE_FK_PK = ATR_CODE_SQ_PK"
            strList &= " AND SPSMR_DATE = ATR_DATE_REDACTION"
        Else
            strList &= " WHERE SPATR_ATR_CODE_FK_PK = ATR_CODE_SQ_PK"
            strList &= " AND SPSMR_DATE = ATR_DATE_REDACTION"
        End If
        f._SSQL = strList
        f.colVal1.Caption = "CodeSP"
        f.colVal2.Caption = "NumSMR"
        f.colVal3.Caption = "Date"
        f.colVal4.Caption = "CodeAvisCommission"
        f.ShowDialog()
        If f._Code IsNot Nothing Then
            Try
                Me.DsTheriaque_Nomenclature2.PRESMR_PRE_SMR_ATR.AddPRESMR_PRE_SMR_ATRRow(txtCode.Text, f._Code, f._Collection(3), f._Collection(4))
                Me.BindingContext(Me.DsTheriaque_Nomenclature2, PRESMR_PRE_SMR_ATR).EndCurrentEdit()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Frm_Presentation_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        GC16.Width = Pan_Lieu_Commentaire.Width / 2
    End Sub

    Private Sub GV14_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV14.InitNewRow
        GV14.SetFocusedRowCellValue(colPERCS_NUMORD, Code_MAx(GV14, colPERCS_NUMORD))
        Me.GV14.SetFocusedRowCellValue(colPERCS_NUMORD, Code_MAx(GV14, colPERCS_NUMORD))
    End Sub

    Private Sub GV14_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV14.ValidatingEditor
        If GV14.FocusedColumn Is colPERCS_NUMORD Then
            If FieldExist(GV14, colPERCS_NUMORD, e.Value) Then
                e.ErrorText = "Le numéro doit être unique."
                e.Value = Nothing
                e.Valid = False
            End If
        End If
    End Sub

    Private Sub GV4_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV4.InitNewRow
        Me.GV4.SetFocusedRowCellValue(colPREMAT_NUMORD, Code_MAx(GV4, colPREMAT_NUMORD))
        Me.GV4.SetFocusedRowCellValue(colPREMAT_PRE_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV5_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV5.InitNewRow
        Me.GV5.SetFocusedRowCellValue(colPRECAR_NUMORD, Code_MAx(GV5, colPRECAR_NUMORD))
    End Sub

    Private Sub GV15RowCountChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GV15.RowCountChanged
        If sender.RowCount >= 1 Then
            sender.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
            sender.GridControl.EmbeddedNavigator.Buttons.Append.Enabled = False
        Else
            sender.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            sender.GridControl.EmbeddedNavigator.Buttons.Append.Enabled = False
        End If
    End Sub

    Private Sub GV_ValidatingEditor(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV.ValidatingEditor
        If GV.FocusedColumn Is colPREDISP_SAC_CODE_FK Then
            If FieldExist(GV, colPREDISP_SAC_CODE_FK, e.Value) Then
                e.ErrorText = "La substance active doit être unique."
                e.Value = Nothing
                e.Valid = False
            End If
        End If

        'If (e.Column.Name = "colPREDISP_DOSEFRAC") Then
        If GV.FocusedColumn Is colPREDISP_DOSEFRAC Then
            If e.Value.ToString() = "" Then
                e.Value = Nothing
                e.Valid = True
            End If

        End If


    End Sub

    Private Sub GV_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        If GV.GetRowCellValue(e.RowHandle, colPREDISP_SAC_CODE_FK) Is DBNull.Value Then
            e.ErrorText = "La substance active ne doit pas être vide."
            e.Valid = False
        Else
            GV.SetColumnError(colPREDISP_SAC_CODE_FK, "")
            e.Valid = True
        End If
    End Sub

    Private Sub Open_Fiche(ByVal CodE1 As Object)
        OnLoading = True
        CodE = _Code
        EmptyDataTable()
        Me.PrE_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PRE_PRESENTATION, CodE)

        Dim valueCode As String = Me.PrE_TA.GetDataByCode(CodE).Rows(0).Item("PRE_NATUCD_CDF_CODE_FK").ToString()
        Dim valueNumero As String = Me.PrE_TA.GetDataByCode(CodE).Rows(0).Item("PRE_NATUCD_CDF_NUM_FK").ToString()
        lkupUCD.EditValue = valueCode & "_" & valueNumero

        Me.PredisP_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PREDISP_PRE_DISPENSATION, CodE)
        Me.PreucD_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PREUCD_COMMENT_DOSEUCD, CodE)
        Me.CoconT_TA.FillByCode(Me.DsTheriaque_Nomenclature2.COCONT_COMPO_CONTENANT, CodE)
        Me.PreconT_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PRECONT_PRE_CONTENANT, CodE)
        Me.PrecaR_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PRECAR_PRESENTATION_CARACTCOMP, CodE)
        Me.PremaT_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PREMAT_PRE_MATERIAU, CodE)
        Me.Precpss_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PRECPSS, CodE)
        PrevolsoL.FillByCode(Me.DsTheriaque_Nomenclature2.PREVOLSOL_VOLUME_SOLUTION, CodE)
        Me.PREDISPMAX.FillByCode(Me.DsTheriaque_Nomenclature2.PREDISPMAX_PRE_DISP_MAXIMALE, CodE)




        Tab_TA1 = False
        Tab_TA2 = False
        Tab_TA3 = False
        Tab_TA4 = False
        Tab_TA5 = False
        Tab_TA6 = False
        OnLoading = False

        'T3954: Charger tous les onglets automatiquement suite à la demande du client qui lui dérange de parcourir 
        'tous les onglets avant de maj l'interopérable

        LoadTab_1()
        LoadTab_2()
        LoadTab_3()
        LoadTab_4()

    End Sub

    Private Sub GV3_CustomDrawCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GV3.CustomDrawCell
        If e.Column Is colPRECONT_NBCONTENANT Then
            If GV3.GetRowCellValue(e.RowHandle, colPRECONT_NBCONTENANT_REEL) IsNot DBNull.Value Then
                If GV3.GetRowCellValue(e.RowHandle, colPRECONT_NBCONTENANT_REEL) = "N" Then
                    If e.CellValue = 1 Then e.DisplayText = "0"
                End If
            End If
        End If
    End Sub

    Private Sub GV_CalcRowHeight(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs) Handles GV12.CalcRowHeight, GV15.CalcRowHeight
        e.RowHeight = sender.GridControl.Height
    End Sub

#Region "Document "


    Private Sub bePath_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles bePath.ButtonClick

        Select Case e.Button.Tag
            Case "explorer"
                Dim FolderBrowserDialog1 As New FolderBrowserDialog
                If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    ' Display the selected folder if the user clicked on the OK button.
                    bePath.Text = FolderBrowserDialog1.SelectedPath
                End If
            Case "effacer"
                bePath.Text = ""
        End Select

    End Sub

    Private Sub SaveDocument(ByVal path As String)

        Dim oFile As System.IO.FileInfo
        oFile = New System.IO.FileInfo(path)
        Dim oFileStream As System.IO.FileStream = oFile.OpenRead()
        Dim lBytes As Long = oFileStream.Length
        If (lBytes > 0) Then
            Dim fileData(lBytes - 1) As Byte
            oFileStream.Read(fileData, 0, lBytes)
            oFileStream.Close()
            With doc
                .DO_Date = Now.Date
                .DO_DateHeure = Now
                .DO_extension = IO.Path.GetExtension(path)
                .DO_Label = IO.Path.GetFileName(path)
                .DO_Contenu = fileData
                .ID_Categorie = 0
                .DO_Info1 = path
                .Save(True)  ' False for update.
            End With
        End If

    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImporter.Click

        'importer
        If (Not String.IsNullOrEmpty(bePath.Text)) Then
            Dim d As New DirectoryInfo(bePath.Text)
            doc = New DocumentService.DocumentProvider(strConnexion)

            Dim filter As String = "*.pdf,*.gif,*.jpg,*.bmp,*.png"

            For Each f As FileInfo In d.GetFiles()
                If (filter.ToLower().Contains(f.Extension.ToLower())) Then
                    SaveDocument(f.FullName)
                    doc.AddDocumentToAssociation(doc.DO_ID, txtCode.Text, DocumentService.DocumentProvider.TypeDoc.Presentation)
                End If
            Next
            Me.gcDocuments.DataSource = doc.GetDocsByTypeDoc(txtCode.Text, DocumentService.DocumentProvider.TypeDoc.Presentation)
        Else
            MsgBox("Veuillez sélectionner un chemin")
        End If

    End Sub

    Private Sub bSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSupprimer.Click

        If (gvDocuments.RowCount > 0) Then
            If MessageBox.Show("Vous voulez vraiement supprimer ce document ?", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                If (gvDocuments.RowCount > 0) Then

                    Dim id As String = gvDocuments.GetFocusedRowCellValue(colId1).ToString()
                    doc.DeleteFromAssociation(id, CodE, DocumentService.DocumentProvider.TypeDoc.Presentation)
                    Me.gcDocuments.DataSource = doc.GetDocsByTypeDoc(CodE, DocumentService.DocumentProvider.TypeDoc.Presentation)

                End If
            End If
        Else
            MessageBox.Show("Veuillez sélectionner un document")
        End If

    End Sub

    Private Sub btAperçu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAperçu.Click

        If gvDocuments.FocusedRowHandle >= 0 Then
            doc = Me.gvDocuments.GetRow(gvDocuments.FocusedRowHandle)
            Dim f As New FrmApercu
            f.doc = doc
            f.ShowDialog()
        Else
            MsgBox("Veuillez sélectionner un document")
        End If

    End Sub


    Public Sub RechercherPresentation()

        Dim sCodeCONT As String = ""
        Dim sCodeMAT As String = ""
        Dim sCodeCCOMP As String = ""
        Dim sCodeCEMB As String = ""
        Dim sCodePRUNIT As String = ""
        Dim sCodeTAUXVILLE As String = ""
        Dim sCodeTAUXHOP As String = ""
        Dim sCodePREHOS As String = ""
        Dim sCodeST As String = ""
        Dim sCodeSTCOMP As String = ""
        Dim sCodeSTREMB As String = ""
        Dim sCodeCONDCONS As String = ""
        Dim sCodeLIEUDISP As String = ""
        Dim sCodeCOMDISP As String = ""
        Dim f As New Frm_PresentationMultiCriteres
        Dim dtResultat As DataTable

        f.ShowDialog()
        If f._Validate Then
            If f._bCONT Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("22")
                fDICO.Text = "Contenants"
                fDICO.ShowDialog()
                sCodeCONT = fDICO._Code
            End If
            If f._bMAT Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("09")
                fDICO.Text = "Matériaux"
                fDICO.ShowDialog()
                sCodeMAT = fDICO._Code
            End If
            If f._bCCOMP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("01")
                fDICO.Text = "Caract complément"
                fDICO.ShowDialog()
                sCodeCCOMP = fDICO._Code
            End If
            If f._bCEMB Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("01")
                fDICO.Text = "Caract emballage"
                fDICO.ShowDialog()
                sCodeCEMB = fDICO._Code
            End If
            If f._bPRUNIT Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("12")
                fDICO.Text = "Présentation unitaire"
                fDICO.ShowDialog()
                sCodePRUNIT = fDICO._Code
            End If
            If f._bTAUXVILLE Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("17")
                fDICO.Text = "Taux Rbst SS ville - Taux sécurité sociale"
                fDICO.ShowDialog()
                sCodeTAUXVILLE = fDICO._Code
            End If
            If f._bTAUXHOP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("17")
                fDICO.Text = "Taux Rbst SS hôpital - Taux sécurité sociale"
                fDICO.ShowDialog()
                sCodeTAUXHOP = fDICO._Code
            End If
            If f._bPREHOS Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("13")
                fDICO.Text = "Présentation hospitalière"
                fDICO.ShowDialog()
                sCodePREHOS = fDICO._Code
            End If
            If f._bST Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("14", " and substring(CDF_CODE_PK,1,1) =  'S'")
                fDICO.Text = "Statuts"
                fDICO.ShowDialog()
                sCodeST = fDICO._Code
            End If
            If f._bSTCOMP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("14", " and substring(CDF_CODE_PK,1,1) =  'C'")
                fDICO.Text = "Statuts complémentaires"
                fDICO.ShowDialog()
                sCodeSTCOMP = fDICO._Code
            End If
            If f._bSTREMB Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("14", " and substring(CDF_CODE_PK,1,1) =  'R'")
                fDICO.Text = "Statuts de remboursement"
                fDICO.ShowDialog()
                sCodeSTREMB = fDICO._Code
            End If
            If f._bCONDCONS Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("03")
                fDICO.Text = "Conditions de conservation"
                fDICO.ShowDialog()
                sCodeCONDCONS = fDICO._Code
            End If
            If f._bLIEUDISP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("14", " and substring(CDF_CODE_PK,1,1) =  'D'")
                fDICO.Text = "Lieux de dispensation"
                fDICO.ShowDialog()
                sCodeLIEUDISP = fDICO._Code
            End If
            If f._bCOMDISP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("29")
                fDICO.Text = "Commentaires dispensation"
                fDICO.ShowDialog()
                sCodeCOMDISP = fDICO._Code
            End If


            Dim fResultat As New Frm_Recherche
            Dim sSQL As String = ""
            sSQL &= " Select PRE_CODE_PK as code, '' as libelle From THERIAQUE.PRE_PRESENTATION"
            If sCodeCONT <> "" Then
                sSQL &= " WHERE PRE_CODE_PK IN (SELECT COCONT_PRE_CODE_FK_PK FROM THERIAQUE.COCONT_COMPO_CONTENANT WHERE COCONT_CDF_GAL_CODE_FK = " & cn.SQLText(sCodeCONT) & ")"
            End If
            If sCodeMAT <> "" Then
                If sCodeCONT <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " PRE_CODE_PK IN (SELECT PREMAT_PRE_CODE_FK_PK FROM THERIAQUE.PREMAT_PRE_MATERIAU WHERE PREMAT_CDF_MACDT_CODE_FK_PK = " & cn.SQLText(sCodeMAT) & ")"
            End If
            If sCodeCCOMP <> "" Then
                If sCodeCONT <> "" Or sCodeMAT <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " PRE_CODE_PK IN (SELECT PRECAR_PRE_CODE_FK_PK FROM THERIAQUE.PRECAR_PRESENTATION_CARACTCOMP WHERE PRECAR_CDF_CODE_CACDT_FK_PK = " & cn.SQLText(sCodeCCOMP) & ")"
            End If
            If sCodeCEMB <> "" Then
                If sCodeCONT <> "" Or sCodeMAT <> "" Or sCodeCCOMP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " PRE_CODE_PK IN (SELECT PRECEMB_PRE_CODE_FK_PK FROM THERIAQUE.PRECEMB_PRE_CAREMBALLAGE WHERE PRECEMB_CDF_CAREMB_CODE_FK_PK = " & cn.SQLText(sCodeCEMB) & ")"
            End If
            If sCodePRUNIT <> "" Then
                If sCodeCONT <> "" Or sCodeMAT <> "" Or sCodeCCOMP <> "" Or sCodeCEMB <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " PRE_CODE_PK IN (SELECT PRE_CODE_PK FROM THERIAQUE.PRE_PRESENTATION WHERE PRE_CDF_PU_CODE_FK = " & cn.SQLText(sCodePRUNIT) & ")"
            End If
            If sCodeTAUXVILLE <> "" Then
                If sCodeCONT <> "" Or sCodeMAT <> "" Or sCodeCCOMP <> "" Or sCodeCEMB <> "" Or sCodePRUNIT <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " PRE_CODE_PK IN (SELECT PRETSS_PRE_CODE_FK_PK FROM THERIAQUE.PRETSS_PRESENTATION_TAUX WHERE PRETSS_CDF_TSS_CODE_FK_PK = " & cn.SQLText(sCodeTAUXVILLE) & ")"
            End If
            If sCodeTAUXHOP <> "" Then
                If sCodeCONT <> "" Or sCodeMAT <> "" Or sCodeCCOMP <> "" Or sCodeCEMB <> "" Or sCodePRUNIT <> "" Or sCodeTAUXVILLE <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " PRE_CODE_PK IN (SELECT PRETSSH_PRE_CODE_FK_PK FROM THERIAQUE.PRETSSH_PRE_TAUX_HOP WHERE PRETSSH_CDF_TSS_CODE_FK_PK = " & cn.SQLText(sCodeTAUXHOP) & ")"
            End If
            If sCodePREHOS <> "" Then
                If sCodeCONT <> "" Or sCodeMAT <> "" Or sCodeCCOMP <> "" Or sCodeCEMB <> "" Or sCodePRUNIT <> "" Or sCodeTAUXVILLE <> "" Or sCodeTAUXHOP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " PRE_CODE_PK IN (SELECT PRE_CODE_PK FROM THERIAQUE.PRE_PRESENTATION WHERE PRE_CDF_RH_CODE_FK = " & cn.SQLText(sCodePREHOS) & ")"
            End If
            If sCodeST <> "" Then
                If sCodeCONT <> "" Or sCodeMAT <> "" Or sCodeCCOMP <> "" Or sCodeCEMB <> "" Or sCodePRUNIT <> "" Or sCodeTAUXVILLE <> "" Or sCodeTAUXHOP <> "" Or sCodePREHOS <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " PRE_CODE_PK IN (SELECT PRESTP_PRE_CODE_FK_PK FROM THERIAQUE.PRESTP_PRE_STP WHERE PRESTP_CDF_STP_CODE_FK_PK = " & cn.SQLText(sCodeST) & ")"
            End If
            If sCodeSTCOMP <> "" Then
                If sCodeCONT <> "" Or sCodeMAT <> "" Or sCodeCCOMP <> "" Or sCodeCEMB <> "" Or sCodePRUNIT <> "" Or sCodeTAUXVILLE <> "" Or sCodeTAUXHOP <> "" Or sCodePREHOS <> "" Or sCodeST <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " PRE_CODE_PK IN (SELECT PRESTC_PRE_CODE_FK_PK FROM THERIAQUE.PRESTC_STATUTCOMP_PRESENT WHERE PRESTC_CDF_STCOMP_CODE_FK_PK = " & cn.SQLText(sCodeSTCOMP) & ")"
            End If
            If sCodeSTREMB <> "" Then
                If sCodeCONT <> "" Or sCodeMAT <> "" Or sCodeCCOMP <> "" Or sCodeCEMB <> "" Or sCodePRUNIT <> "" Or sCodeTAUXVILLE <> "" Or sCodeTAUXHOP <> "" Or sCodePREHOS <> "" Or sCodeST <> "" Or sCodeSTCOMP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " PRE_CODE_PK IN (SELECT PRESTR_PRE_CODE_FK_PK FROM THERIAQUE.PRESTR_STATUT_REMBOURST WHERE PRESTR_CDF_STR_CODE_FK_PK = " & cn.SQLText(sCodeSTREMB) & ")"
            End If
            If sCodeCONDCONS <> "" Then
                If sCodeCONT <> "" Or sCodeMAT <> "" Or sCodeCCOMP <> "" Or sCodeCEMB <> "" Or sCodePRUNIT <> "" Or sCodeTAUXVILLE <> "" Or sCodeTAUXHOP <> "" Or sCodePREHOS <> "" Or sCodeST <> "" Or sCodeSTCOMP <> "" Or sCodeSTREMB <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " PRE_CODE_PK IN (SELECT PERCS_PRE_CODE_FK_PK FROM THERIAQUE.PERCS_PERIODE_COND_CSV WHERE PERCS_CDF_CSV_CODE_FK_PK = " & cn.SQLText(sCodeCONDCONS) & ")"
            End If
            If sCodeLIEUDISP <> "" Then
                If sCodeCONT <> "" Or sCodeMAT <> "" Or sCodeCCOMP <> "" Or sCodeCEMB <> "" Or sCodePRUNIT <> "" Or sCodeTAUXVILLE <> "" Or sCodeTAUXHOP <> "" Or sCodePREHOS <> "" Or sCodeST <> "" Or sCodeSTCOMP <> "" Or sCodeSTREMB <> "" Or sCodeCONDCONS <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " PRE_CODE_PK IN (SELECT PREDILI_PRE_CODE_FK_PK FROM THERIAQUE.PREDILI_LIEU_DISPENSAT WHERE PREDILI_CDF_LIEU_CODE_FK_PK = " & cn.SQLText(sCodeLIEUDISP) & ")"
            End If
            If sCodeCOMDISP <> "" Then
                If sCodeCONT <> "" Or sCodeMAT <> "" Or sCodeCCOMP <> "" Or sCodeCEMB <> "" Or sCodePRUNIT <> "" Or sCodeTAUXVILLE <> "" Or sCodeTAUXHOP <> "" Or sCodePREHOS <> "" Or sCodeST <> "" Or sCodeSTCOMP <> "" Or sCodeSTREMB <> "" Or sCodeCONDCONS <> "" Or sCodeLIEUDISP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " PRE_CODE_PK IN (SELECT PREDICO_PRE_CODE_FK_PK FROM THERIAQUE.PREDICO_COMMENT_DISPENSAT WHERE PREDICO_CDF_COM_CODE_FK_PK = " & cn.SQLText(sCodeCOMDISP) & ")"
            End If
            sSQL &= " ORDER BY PRE_CODE_PK"
            fResultat._SSQL = sSQL
            fResultat.Text = Me.Text

            fResultat.Appelant = "P"
            fResultat.ShowDialog()

            dtResultat = fResultat.dtSpecialite
            dtResultat.Columns(0).ColumnName = "Code"
            dtResultat.Columns(1).ColumnName = "Libelle"



            Dim p As New Frm_Partage
            doc = Me.gvDocuments.GetRow(gvDocuments.FocusedRowHandle)
            p.docId = doc.DO_ID
            p.dtResultat = dtResultat
            p.Type = "CIP"
            p.ShowDialog()
        End If


    End Sub


    Private Sub btnPartager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPartager.Click
        If gvDocuments.FocusedRowHandle >= 0 Then
            RechercherPresentation()
        Else
            MsgBox("Veuillez sélectionner un document")
        End If
    End Sub

    Private Sub gvDocuments_BeforeLeaveRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowAllowEventArgs) Handles gvDocuments.BeforeLeaveRow
        SaveDoc()
    End Sub

    Private Sub gvDocuments_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvDocuments.FocusedRowChanged
        doc = Me.gvDocuments.GetRow(e.FocusedRowHandle)
        If (doc IsNot Nothing) Then
            'Affichage des propriétés.
            Me.txtLibelle.Text = doc.DO_Label
            Me.meNote.Text = doc.DO_Note
            Me.lueCategorie.EditValue = CType(doc.ID_Categorie, Short)
        End If

    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click

        SaveDoc()

    End Sub

    Private Sub SaveDoc()

        If (doc IsNot Nothing) Then
            If (Not String.IsNullOrEmpty(Me.lueCategorie.EditValue)) Then
                If doc.DO_Label = Me.txtLibelle.Text And doc.DO_Note = Me.meNote.Text Then
                    If Me.lueCategorie.EditValue = 0 Then ' IsNot DBNull.Value Then ' And Me.lueCategorie.EditValue <> "" Then
                        If doc.ID_Categorie = 0 Then
                            Exit Sub
                        End If
                    Else
                        If doc.ID_Categorie = Me.lueCategorie.EditValue Then
                            Exit Sub
                        End If
                    End If
                End If
            End If
            If (doc IsNot Nothing) Then
                doc.DO_Label = Me.txtLibelle.Text
                doc.DO_Note = Me.meNote.Text
                doc.cn = New SqlClient.SqlConnection(cn.sConnexion)
            End If

            If (Not String.IsNullOrEmpty(Me.lueCategorie.EditValue)) Then
                If Me.lueCategorie.EditValue IsNot DBNull.Value Then ' And Me.lueCategorie.EditValue <> "" Then
                    doc.ID_Categorie = Me.lueCategorie.EditValue
                End If
            End If
            doc.Save(False)
        End If

    End Sub

    Private Sub cmdAnnuler_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAnnuler.Click

        doc = Me.gvDocuments.GetRow(gvDocuments.FocusedRowHandle)
        If (doc IsNot Nothing) Then
            'Affichage des propriétés.
            Me.txtLibelle.Text = doc.DO_Label
            Me.meNote.Text = doc.DO_Note
            Me.lueCategorie.EditValue = CType(doc.ID_Categorie, Short)
        End If

    End Sub
#End Region

    Private Sub GV20_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV20.InitNewRow
        Me.GV20.SetFocusedRowCellValue(ColPRECPSS_PRE_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV20_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV20.ValidateRow

        'Me.GV20.SetFocusedRowCellValue(colCDF_NOM, "2")
        Me.GV20.SetFocusedRowCellValue(ColPRECPSS_PRE_CODE_FK_PK, txtCode.Text)
        Dim dr As DataRowView
        dr = CType(e.Row, DataRowView)
        If (String.IsNullOrEmpty(dr.Row.Item("PRECPSS_CDF_CPSS_CODE_FK_PK").ToString())) Then
            e.Valid = False
            MsgBox("Impossible d'ajouter une ligne code nature prestation sécurité sociale vide")
        End If

    End Sub

    Private Sub UpdateCIP13()

        Try

            Dim req As String
            'COCONT_COMPO_CONTENANT
            req = "UPDATE [Theriaque].[COCONT_COMPO_CONTENANT] SET COCONT_CIP13 = " & cn.SQLText(txtEAN.Text) & " WHERE COCONT_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            cn.ExecuteUCDCIP13(req)

            'FINTSS_INDICATION_TAUXSECU
            req = "UPDATE [Theriaque].[FINTSS_INDICATION_TAUXSECU] SET FINTSS_CIP13 = " & cn.SQLText(txtEAN.Text) & " WHERE FINTSS_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            cn.ExecuteUCDCIP13(req)

            'FORPRE_FORFAIT_PRE
            req = "UPDATE [Theriaque].[FORPRE_FORFAIT_PRE] SET FORPRE_CIP13 = " & cn.SQLText(txtEAN.Text) & " WHERE FORPRE_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            cn.ExecuteUCDCIP13(req)

            'PERCS_PERIODE_COND_CSV
            req = "UPDATE [Theriaque].[PERCS_PERIODE_COND_CSV] SET PERCS_CIP13 = " & cn.SQLText(txtEAN.Text) & " WHERE PERCS_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            cn.ExecuteUCDCIP13(req)

            'PRECAR_PRESENTATION_CARACTCOMP
            req = "UPDATE [Theriaque].[PRECAR_PRESENTATION_CARACTCOMP] SET PRECAR_CIP13 = " & cn.SQLText(txtEAN.Text) & " WHERE PRECAR_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            cn.ExecuteUCDCIP13(req)

            'PRECEMB_PRE_CAREMBALLAGE
            req = "UPDATE [Theriaque].[PRECEMB_PRE_CAREMBALLAGE] SET PRECEMB_CIP13 = " & cn.SQLText(txtEAN.Text) & " WHERE PRECEMB_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            cn.ExecuteUCDCIP13(req)

            'PRECONT_PRE_CONTENANT
            req = "UPDATE [Theriaque].[PRECONT_PRE_CONTENANT] SET PRECONT_CIP13 = " & cn.SQLText(txtEAN.Text) & " WHERE PRECONT_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            cn.ExecuteUCDCIP13(req)

            'PREPER_PRESENTATION_PERIO_CSV
            req = "UPDATE [Theriaque].[PREPER_PRESENTATION_PERIO_CSV] SET PREPER_CIP13 = " & cn.SQLText(txtEAN.Text) & " WHERE PREPER_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            cn.ExecuteUCDCIP13(req)

            'PRECSVTX_TEXTE_CONSERV
            req = "UPDATE [Theriaque].[PRECSVTX_TEXTE_CONSERV] SET PRECSVTX_CIP13 = " & cn.SQLText(txtEAN.Text) & " WHERE PRECSVTX_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            cn.ExecuteUCDCIP13(req)

            'PREDICO_COMMENT_DISPENSAT
            req = "UPDATE [Theriaque].[PREDICO_COMMENT_DISPENSAT] SET PREDICO_CIP13 = " & cn.SQLText(txtEAN.Text) & " WHERE PREDICO_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            cn.ExecuteUCDCIP13(req)

            'PREDILI_LIEU_DISPENSAT
            req = "UPDATE [Theriaque].[PREDILI_LIEU_DISPENSAT] SET PREDILI_CIP13 = " & cn.SQLText(txtEAN.Text) & " WHERE PREDILI_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            cn.ExecuteUCDCIP13(req)

            'PREDISP_PRE_DISPENSATION
            req = "UPDATE [Theriaque].[PREDISP_PRE_DISPENSATION] SET PREDISP_CIP13 = " & cn.SQLText(txtEAN.Text) & " WHERE PREDISP_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            cn.ExecuteUCDCIP13(req)

            'PREDITX_TEXTE_DISPENSAT
            req = "UPDATE [Theriaque].[PREDITX_TEXTE_DISPENSAT] SET PREDITX_CIP13 = " & cn.SQLText(txtEAN.Text) & " WHERE PREDITX_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            cn.ExecuteUCDCIP13(req)

            'PREGREF_PRE_GROUPE_REF
            req = "UPDATE [Theriaque].[PREGREF_PRE_GROUPE_REF] SET PREGREF_CIP13 = " & cn.SQLText(txtEAN.Text) & " WHERE PREGREF_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            cn.ExecuteUCDCIP13(req)

            'PREMAT_PRE_MATERIAU
            req = "UPDATE [Theriaque].[PREMAT_PRE_MATERIAU] SET PREMAT_CIP13 = " & cn.SQLText(txtEAN.Text) & " WHERE PREMAT_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            cn.ExecuteUCDCIP13(req)

            'PRESMR_PRE_SMR_ATR
            req = "UPDATE [Theriaque].[PRESMR_PRE_SMR_ATR] SET PRESMR_CIP13 = " & cn.SQLText(txtEAN.Text) & " WHERE PRESMR_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            cn.ExecuteUCDCIP13(req)

            'PRESTC_STATUTCOMP_PRESENT
            req = "UPDATE [Theriaque].[PRESTC_STATUTCOMP_PRESENT] SET PRESTC_CIP13 = " & cn.SQLText(txtEAN.Text) & " WHERE PRESTC_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            cn.ExecuteUCDCIP13(req)

            'PRESTP_PRE_STP
            req = "UPDATE [Theriaque].[PRESTP_PRE_STP] SET PRESTP_CIP13 = " & cn.SQLText(txtEAN.Text) & " WHERE PRESTP_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            cn.ExecuteUCDCIP13(req)

            'PRESTR_STATUT_REMBOURST
            req = "UPDATE [Theriaque].[PRESTR_STATUT_REMBOURST] SET PRESTR_CIP13 = " & cn.SQLText(txtEAN.Text) & " WHERE PRESTR_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            cn.ExecuteUCDCIP13(req)

            'PRESTRTX_TEXTE_STAT_REMBOURST
            req = "UPDATE [Theriaque].[PRESTRTX_TEXTE_STAT_REMBOURST] SET PRESTRTX_CIP13 = " & cn.SQLText(txtEAN.Text) & " WHERE PRESTRTX_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            cn.ExecuteUCDCIP13(req)

            'PRETSSH_PRE_TAUX_HOP
            req = "UPDATE [Theriaque].[PRETSSH_PRE_TAUX_HOP] SET PRETSSH_CIP13 = " & cn.SQLText(txtEAN.Text) & " WHERE PRETSSH_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            cn.ExecuteUCDCIP13(req)

            'PRETSS_PRESENTATION_TAUX
            req = "UPDATE [Theriaque].[PRETSS_PRESENTATION_TAUX] SET PRETSS_CIP13 = " & cn.SQLText(txtEAN.Text) & " WHERE PRETSS_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            cn.ExecuteUCDCIP13(req)

            'PREUCD_COMMENT_DOSEUCD
            req = "UPDATE [Theriaque].[PREUCD_COMMENT_DOSEUCD] SET PREUCD_CIP13 = " & cn.SQLText(txtEAN.Text) & " WHERE PREUCD_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            cn.ExecuteUCDCIP13(req)

            'PRIPRE_PRIX_PRESENTATION
            req = "UPDATE [Theriaque].[PRIPRE_PRIX_PRESENTATION] SET PRIPRE_CIP13 = " & cn.SQLText(txtEAN.Text) & " WHERE PRIPRE_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            cn.ExecuteUCDCIP13(req)

            'PRECPSS
            For iCount As Integer = 0 To GV20.RowCount - 1
                If GV20.GetRowCellValue(iCount, ColPRECPSS_PRE_CODE_FK_PK) <> Nothing Then
                    req = "UPDATE [Theriaque].[PRECPSS] SET PRECPSS_CIP13 = " & cn.SQLText(txtEAN.Text) & " WHERE PRECPSS_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
                    req += " AND PRECPSS_CDF_CPSS_CODE_FK_PK = " & cn.SQLText(GV20.GetRowCellValue(iCount, colCDF_NOM))
                    cn.ExecuteUCDCIP13(req)
                End If
            Next

            'COCONT_COMPO_CONTENANT
            'req = "Update[Theriaque].[COCONT_COMPO_CONTENANT] set COCONT_CIP13 = ("
            'req += "select distinct t2.PRE_EAN_REF from [theriaque].[PRE_PRESENTATION] t2 where t2.PRE_CODE_PK = COCONT_PRE_CODE_FK_PK and COCONT_PRE_CODE_FK_PK = '" & txtCode.Text & "'" + ")"
            'req += " where COCONT_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            'cn.ExecuteUCDCIP13(req)

           

            ''FORPRE_FORFAIT_PRE
            'req = " Update [Theriaque].[FORPRE_FORFAIT_PRE] set [theriaque].[FORPRE_FORFAIT_PRE].FORPRE_CIP13 = ("
            'req += " select distinct t2.PRE_EAN_REF from [theriaque].[PRE_PRESENTATION] t2 where t2.PRE_CODE_PK = [theriaque].[FORPRE_FORFAIT_PRE].FORPRE_PRE_CODE_FK_PK and FORPRE_PRE_CODE_FK_PK = '" & txtCode.Text & "'" + ")"
            'req += " where FORPRE_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            'cn.ExecuteUCDCIP13(req)


            ''PERCS_PERIODE_COND_CSV
            'req = "update [theriaque].[PERCS_PERIODE_COND_CSV] set [theriaque].[PERCS_PERIODE_COND_CSV].PERCS_CIP13 = ("
            'req += "select distinct t2.PRE_EAN_REF from [theriaque].[PRE_PRESENTATION] t2 where t2.PRE_CODE_PK = [theriaque].[PERCS_PERIODE_COND_CSV].PERCS_PRE_CODE_FK_PK and PERCS_PRE_CODE_FK_PK = '" & txtCode.Text & "'" + ")"
            'req += " where PERCS_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            'Try
            '    cn.ExecuteUCDCIP13(req)
            'Catch ex As Exception

            'End Try
            'cn.ExecuteUCDCIP13(req)

            ''PRECAR_PRESENTATION_CARACTCOMP
            'req = " Update [Theriaque].[PRECAR_PRESENTATION_CARACTCOMP] set [theriaque].[PRECAR_PRESENTATION_CARACTCOMP].PRECAR_CIP13 = ("
            'req += "select distinct t2.PRE_EAN_REF from [theriaque].[PRE_PRESENTATION] t2 where t2.PRE_CODE_PK = [theriaque].PRECAR_PRESENTATION_CARACTCOMP.PRECAR_PRE_CODE_FK_PK and  PRECAR_PRE_CODE_FK_PK = '" & txtCode.Text & "'" + ")"
            'req += " where PRECAR_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            'cn.ExecuteUCDCIP13(req)

            ''PRECEMB_PRE_CAREMBALLAGE
            'req = " Update [Theriaque].[PRECEMB_PRE_CAREMBALLAGE] set [theriaque].[PRECEMB_PRE_CAREMBALLAGE].PRECEMB_CIP13 = ("
            'req += "select distinct t2.PRE_EAN_REF from [theriaque].[PRE_PRESENTATION] t2 where t2.PRE_CODE_PK = [theriaque].PRECEMB_PRE_CAREMBALLAGE.PRECEMB_PRE_CODE_FK_PK and PRECEMB_PRE_CODE_FK_PK = '" & txtCode.Text & "'" + ")"
            'req += " where PRECEMB_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            'cn.ExecuteUCDCIP13(req)

            ''PRECONT_PRE_CONTENANT
            'req = " update [theriaque].[PRECONT_PRE_CONTENANT] set [theriaque].[PRECONT_PRE_CONTENANT].PRECONT_CIP13 = ("
            'req += " select distinct t2.PRE_EAN_REF from [theriaque].[PRE_PRESENTATION] t2 where t2.PRE_CODE_PK = [theriaque].PRECONT_PRE_CONTENANT.PRECONT_PRE_CODE_FK_PK and  PRECONT_PRE_CODE_FK_PK = '" & txtCode.Text & "'" + ")"
            'req += " where PRECONT_PRE_CODE_FK_PK = '" & txtCode.Text & "'"
            'cn.ExecuteUCDCIP13(req)

            ''PREPER_PRESENTATION_PERIO_CSV
            'req = "update [theriaque].[PREPER_PRESENTATION_PERIO_CSV] set [theriaque].[PREPER_PRESENTATION_PERIO_CSV].PREPER_CIP13 = ("
            'req += " select distinct t2.PRE_EAN_REF from [theriaque].[PRE_PRESENTATION] t2 where t2.PRE_CODE_PK = [theriaque].PREPER_PRESENTATION_PERIO_CSV.PREPER_PRE_CODE_FK_PK and PREPER_PRE_CODE_FK_PK='" & txtCode.Text & "'" + ")"
            'req += " where PREPER_PRE_CODE_FK_PK='" & txtCode.Text & "'"
            'cn.ExecuteUCDCIP13(req)

            ''PRECSVTX_TEXTE_CONSERV
            'req = " update [theriaque].[PRECSVTX_TEXTE_CONSERV] set [theriaque].[PRECSVTX_TEXTE_CONSERV].PRECSVTX_CIP13 = ("
            'req += " select distinct t2.PRE_EAN_REF from [theriaque].[PRE_PRESENTATION] t2 where t2.PRE_CODE_PK = [theriaque].PRECSVTX_TEXTE_CONSERV.PRECSVTX_PRE_CODE_FK_PK and PRECSVTX_PRE_CODE_FK_PK='" & txtCode.Text & "'" + ")"
            'req += " where PRECSVTX_PRE_CODE_FK_PK='" & txtCode.Text & "'"
            'cn.ExecuteUCDCIP13(req)

            ''PREDICO_COMMENT_DISPENSAT
            'req = "Update [Theriaque].[PREDICO_COMMENT_DISPENSAT] set [theriaque].[PREDICO_COMMENT_DISPENSAT].PREDICO_CIP13 = ("
            'req += "select distinct t2.PRE_EAN_REF from [theriaque].[PRE_PRESENTATION] t2 where t2.PRE_CODE_PK = [theriaque].PREDICO_COMMENT_DISPENSAT.PREDICO_PRE_CODE_FK_PK and PREDICO_PRE_CODE_FK_PK='" & txtCode.Text & "'" + ")"
            'req += " where PREDICO_PRE_CODE_FK_PK='" & txtCode.Text & "'"
            'cn.ExecuteUCDCIP13(req)

            ''PREDILI_LIEU_DISPENSAT
            'req = " Update [Theriaque].[PREDILI_LIEU_DISPENSAT] set [theriaque].[PREDILI_LIEU_DISPENSAT].PREDILI_CIP13 = ("
            'req += " select distinct t2.PRE_EAN_REF from [theriaque].[PRE_PRESENTATION] t2 where t2.PRE_CODE_PK = [theriaque].PREDILI_LIEU_DISPENSAT.PREDILI_PRE_CODE_FK_PK and PREDILI_PRE_CODE_FK_PK='" & txtCode.Text & "'" + ")"
            'req += " where PREDILI_PRE_CODE_FK_PK='" & txtCode.Text & "'"
            'cn.ExecuteUCDCIP13(req)

            ''PREDISP_PRE_DISPENSATION
            'req = "Update [Theriaque].[PREDISP_PRE_DISPENSATION] set [theriaque].[PREDISP_PRE_DISPENSATION].PREDISP_CIP13 = ("
            'req += "select distinct t2.PRE_EAN_REF from [theriaque].[PRE_PRESENTATION] t2 where t2.PRE_CODE_PK = [theriaque].PREDISP_PRE_DISPENSATION.PREDISP_PRE_CODE_FK_PK and PREDISP_PRE_CODE_FK_PK='" & txtCode.Text & "'" + ")"
            'req += " where PREDISP_PRE_CODE_FK_PK='" & txtCode.Text & "'"
            'cn.ExecuteUCDCIP13(req)

            ''PREDISP_PRE_DISPENSATION
            'req = "Update [Theriaque].[PREMAT_PRE_MATERIAU] set [theriaque].[PREMAT_PRE_MATERIAU].PREMAT_CIP13 = ("
            'req += "select distinct t2.PRE_EAN_REF from [theriaque].[PRE_PRESENTATION] t2 where t2.PRE_CODE_PK = [theriaque].PREMAT_PRE_MATERIAU.PREMAT_PRE_CODE_FK_PK and PREMAT_PRE_CODE_FK_PK='" & txtCode.Text & "'" + ")"
            'req += " where PREMAT_PRE_CODE_FK_PK='" & txtCode.Text & "'"
            'cn.ExecuteUCDCIP13(req)

            ''PRESMR_PRE_SMR_ATR
            'req = "update [theriaque].[PRESMR_PRE_SMR_ATR] set [theriaque].[PRESMR_PRE_SMR_ATR].PRESMR_CIP13 = ("
            'req += "select distinct t2.PRE_EAN_REF from [theriaque].[PRE_PRESENTATION] t2 where t2.PRE_CODE_PK = [theriaque].PRESMR_PRE_SMR_ATR.PRESMR_PRE_CODE_FK_PK and PRESMR_PRE_CODE_FK_PK='" & txtCode.Text & "'" + ")"
            'req += " where PRESMR_PRE_CODE_FK_PK='" & txtCode.Text & "'"
            'cn.ExecuteUCDCIP13(req)

            ''PRESTC_STATUTCOMP_PRESENT
            'req = "update [theriaque].[PRESTC_STATUTCOMP_PRESENT] set [theriaque].[PRESTC_STATUTCOMP_PRESENT].PRESTC_CIP13 = ("
            'req += "select distinct t2.PRE_EAN_REF from [theriaque].[PRE_PRESENTATION] t2 where t2.PRE_CODE_PK = [theriaque].PRESTC_STATUTCOMP_PRESENT.PRESTC_PRE_CODE_FK_PK and PRESTC_PRE_CODE_FK_PK='" & txtCode.Text & "'" + ")"
            'req += " where PRESTC_PRE_CODE_FK_PK='" & txtCode.Text & "'"
            'cn.ExecuteUCDCIP13(req)

            ''PRESTP_PRE_STP
            'req = "update [theriaque].[PRESTP_PRE_STP] set [theriaque].[PRESTP_PRE_STP].PRESTP_CIP13 = ("
            'req += " select distinct t2.PRE_EAN_REF from [theriaque].[PRE_PRESENTATION] t2 where t2.PRE_CODE_PK = [theriaque].PRESTP_PRE_STP.PRESTP_PRE_CODE_FK_PK and PRESTP_PRE_CODE_FK_PK='" & txtCode.Text & "'" + ")"
            'req += " where PRESTP_PRE_CODE_FK_PK='" & txtCode.Text & "'"
            'cn.ExecuteUCDCIP13(req)

            ''PRESTP_PRE_STP
            'req = "update [theriaque].[PRESTP_PRE_STP] set [theriaque].[PRESTP_PRE_STP].PRESTP_CIP13 = ("
            'req += " select distinct t2.PRE_EAN_REF from [theriaque].[PRE_PRESENTATION] t2 where t2.PRE_CODE_PK = [theriaque].PRESTP_PRE_STP.PRESTP_PRE_CODE_FK_PK and PRESTP_PRE_CODE_FK_PK='" & txtCode.Text & "'" + ")"
            'req += " where PRESTP_PRE_CODE_FK_PK='" & txtCode.Text & "'"
            'cn.ExecuteUCDCIP13(req)

            ''PRESTR_STATUT_REMBOURST
            'req = "update [theriaque].[PRESTR_STATUT_REMBOURST] set [theriaque].[PRESTR_STATUT_REMBOURST].PRESTR_CIP13 = ("
            'req += " select distinct t2.PRE_EAN_REF from [theriaque].[PRE_PRESENTATION] t2 where t2.PRE_CODE_PK = [theriaque].PRESTR_STATUT_REMBOURST.PRESTR_PRE_CODE_FK_PK and PRESTR_PRE_CODE_FK_PK='" & txtCode.Text & "'" + ")"
            'req += " where PRESTR_PRE_CODE_FK_PK='" & txtCode.Text & "'"
            'cn.ExecuteUCDCIP13(req)

            ''PRESTRTX_TEXTE_STAT_REMBOURST
            'req = "update [theriaque].[PRESTRTX_TEXTE_STAT_REMBOURST] set [theriaque].[PRESTRTX_TEXTE_STAT_REMBOURST].PRESTRTX_CIP13 = ("
            'req += "select distinct t2.PRE_EAN_REF from [theriaque].[PRE_PRESENTATION] t2 where t2.PRE_CODE_PK = [theriaque].PRESTRTX_TEXTE_STAT_REMBOURST.PRESTRTX_PRE_CODE_FK_PK and PRESTRTX_PRE_CODE_FK_PK='" & txtCode.Text & "'" + ")"
            'req += " where PRESTRTX_PRE_CODE_FK_PK='" & txtCode.Text & "'"
            'cn.ExecuteUCDCIP13(req)

            ''PRETSSH_PRE_TAUX_HOP
            'req = "update [theriaque].[PRETSSH_PRE_TAUX_HOP] set [theriaque].[PRETSSH_PRE_TAUX_HOP].PRETSSH_CIP13 = ("
            'req += "select distinct t2.PRE_EAN_REF from [theriaque].[PRE_PRESENTATION] t2 where t2.PRE_CODE_PK = [theriaque].PRETSSH_PRE_TAUX_HOP.PRETSSH_PRE_CODE_FK_PK and PRETSSH_PRE_CODE_FK_PK='" & txtCode.Text & "'" + ")"
            'req += " where PRETSSH_PRE_CODE_FK_PK='" & txtCode.Text & "'"
            'cn.ExecuteUCDCIP13(req)

            ''PRETSS_PRESENTATION_TAUX
            'req = "update [theriaque].[PRETSS_PRESENTATION_TAUX] set [theriaque].[PRETSS_PRESENTATION_TAUX].PRETSS_CIP13 = ("
            'req += "select distinct t2.PRE_EAN_REF from [theriaque].[PRE_PRESENTATION] t2 where t2.PRE_CODE_PK = [theriaque].PRETSS_PRESENTATION_TAUX.PRETSS_PRE_CODE_FK_PK and PRETSS_PRE_CODE_FK_PK='" & txtCode.Text & "'" + ")"
            'req += " where PRETSS_PRE_CODE_FK_PK='" & txtCode.Text & "'"
            'cn.ExecuteUCDCIP13(req)


            ''PREUCD_COMMENT_DOSEUCD
            'req = "update [theriaque].[PREUCD_COMMENT_DOSEUCD] set [theriaque].[PREUCD_COMMENT_DOSEUCD].PREUCD_CIP13 = ("
            'req += "select distinct t2.PRE_EAN_REF from [theriaque].[PRE_PRESENTATION] t2 where t2.PRE_CODE_PK = [theriaque].PREUCD_COMMENT_DOSEUCD.PREUCD_PRE_CODE_FK_PK and PREUCD_PRE_CODE_FK_PK='" & txtCode.Text & "'" + ")"
            'req += " where PREUCD_PRE_CODE_FK_PK='" & txtCode.Text & "'"
            'cn.ExecuteUCDCIP13(req)

            ''PRIPRE_PRIX_PRESENTATION
            'req = "update [theriaque].[PRIPRE_PRIX_PRESENTATION] set [theriaque].[PRIPRE_PRIX_PRESENTATION].PRIPRE_CIP13 = ("
            'req += "select distinct t2.PRE_EAN_REF from [theriaque].[PRE_PRESENTATION] t2 where t2.PRE_CODE_PK = [theriaque].PRIPRE_PRIX_PRESENTATION.PRIPRE_PRE_CODE_FK_PK and PRIPRE_PRE_CODE_FK_PK='" & txtCode.Text & "'" + ")"
            'req += " where PRIPRE_PRE_CODE_FK_PK='" & txtCode.Text & "'"
            'cn.ExecuteUCDCIP13(req)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub lkupUCD_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupUCD.EditValueChanged

        btAjouter.Enabled = False
        btSupprimer.Enabled = False
        btValider.Enabled = True
        btAnnuler.Enabled = True
        btChercher.Enabled = False
        btFermer.Enabled = False
        btn_RechMulti.Enabled = False

    End Sub

    Private Sub MemoEdit1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemoEdit1.TextChanged
        'If (MemoEdit1.Text.Length = 255) Then
        '    MsgBox("Taille limite du texte atteinte")
        'End If
    End Sub

    Private Sub MemoEdit1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemoEdit1.Enter
       
    End Sub

    Private Sub MemoEdit1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MemoEdit1.KeyPress

        'If (MemoEdit1.Text.Length = 255) And Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
        '    MsgBox("Taille limite du texte atteinte")
        'End If

    End Sub

    Private Sub lkupUnite_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupUnite.EditValueChanged
        btValider.Enabled = True
        btAnnuler.Enabled = True
        btAjouter.Enabled = False
        btSupprimer.Enabled = False
        btFermer.Enabled = False
        btChercher.Enabled = False
    End Sub

    Private Sub lkupMaxDisp_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btValider.Enabled = True
        btAnnuler.Enabled = True
        btAjouter.Enabled = False
        btSupprimer.Enabled = False
        btFermer.Enabled = False
        btChercher.Enabled = False
    End Sub

    Private Sub txtVolume_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVolume.EditValueChanged
        If (txtVolume.Text.Trim().Equals("")) Then
            txtVolume.Text = Nothing
        End If
    End Sub

    Private Sub GV_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged

        'If (e.Column.Name = "colPREDISP_DOSEFRAC") Then

        '    If GV.GetFocusedRowCellValue(colPREDISP_DOSEFRAC).ToString() = "" Then
        '        GV.SetFocusedRowCellValue(colPREDISP_DOSEFRAC, Nothing)
        '    End If

        'End If

    End Sub

    Private Sub GVDisp_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GVDisp.InitNewRow
        GVDisp.SetFocusedRowCellValue(colPREDISPMAX_PRE_CODE_FK_PK, txtCode.Text)
        GVDisp.SetFocusedRowCellValue(colPREDISPMAX_PRE_CIP13, txtEAN.Text)
    End Sub

    Private Sub GC18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GC18.Click

    End Sub

    Private Sub GV18_InitNewRow_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV18.InitNewRow
        GV18.SetFocusedRowCellValue(colPREDITX_PRE_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GC3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GC3.Click

    End Sub
End Class