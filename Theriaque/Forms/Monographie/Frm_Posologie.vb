Public Class Frm_Posologie

#Region "Déclaration des variables privées"
    Private CodE As String
    Public _Code As Integer = Nothing ' charger la fiche depuis l'extérieur
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
    Private bModeDuplication As Boolean = False
    Private bLoadPoso As Boolean = False
    Public CodeWhere As Object = Nothing

    Private NewCalculation As Boolean = False
    Private NewDuration As Boolean = False
    Private strWhere As String = ""

    ''Private bValidateCommentaireFreq As Boolean = True
    ''Private bValidateCommentaireDuree As Boolean = True
#End Region

#Region " Edit Data    "

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSQL_FPO_FICHEPOSO
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then

            'XtraTabControl1.SelectedTabPageIndex = 0
            OnLoading = True
            EmptyDataTable()
            Me.XtraTabControl1.SelectedTabPageIndex = 0

            Me.FpO_TA.FillByCode(Me.DsTheriaque_Posologie1.FPO_FICHEPOSO, f._Code)

            'Onglet Entités
            Me.FpocpH_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOCPH_FPOSO_CLPH, f._Code)


            Me.FpoccH_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOCCH_FPOSO_CLCH, f._Code)


            Me.FpocH_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOCH_POSOCHOIX, f._Code)


            Me.FposaC_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOSAC_POSO_SUBACT, f._Code)

            Me.FpopR_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOPR_FPOSO_PROD, f._Code)

            Me.FposP_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOSP_POSO_SPE, f._Code)
            CodeWhere = GetCodesSPForInCondition()
            Me.IPODUREE.FillByCode(Me.DsTheriaque_Posologie1.IPODUREE_INFOPOSO, CodeWhere)

            Me.IpodosE_TA.FillByCode(Me.DsTheriaque_Posologie1.IPODOSE_INFOPOSO, CodeWhere) 'f._Code)


            Tab_TA1 = False
            Tab_TA2 = False
            Tab_TA3 = False
            Tab_TA4 = False
            Tab_TA5 = False
            Tab_TA6 = False

            bModeDuplication = False
            OnLoading = False
            bLoadPoso = False
            Return True
        Else
            Return False
        End If
    End Function

    Private Function GetCodesSPForInCondition() As String

        Dim condition As String = ""

        For i As Integer = 0 To GV6.RowCount - 1
            If (GV6.GetDataRow(i) IsNot Nothing) Then
                condition &= "$" & GV6.GetDataRow(i).Item("FPOSP_SP_CODE_FK_PK").ToString() & "$,"
            End If
        Next
        condition &= ","
        condition = condition.Replace(",,", "")

        Return condition

    End Function

    Public Overrides Function ChercherAvance() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = FPO_FICHEPOSO_NIVEAU()
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then

            'XtraTabControl1.SelectedTabPageIndex = 0
            OnLoading = True
            EmptyDataTable()
            Me.FpO_TA.FillByCode(Me.DsTheriaque_Posologie1.FPO_FICHEPOSO, f._Code)

            'Onglet Entités
            Me.FpocpH_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOCPH_FPOSO_CLPH, f._Code)
            Me.FpoccH_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOCCH_FPOSO_CLCH, f._Code)
            Me.FpocH_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOCH_POSOCHOIX, f._Code)
            Me.FposaC_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOSAC_POSO_SUBACT, f._Code)
            Me.FpopR_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOPR_FPOSO_PROD, f._Code)
            Me.FposP_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOSP_POSO_SPE, f._Code)
            CodeWhere = GetCodesSPForInCondition()
            Me.IPODUREE.FillByCode(Me.DsTheriaque_Posologie1.IPODUREE_INFOPOSO, CodeWhere)

            Tab_TA1 = False
            Tab_TA2 = False
            Tab_TA3 = False
            Tab_TA4 = False
            Tab_TA5 = False
            Tab_TA6 = False

            bModeDuplication = False
            bLoadPoso = False
            OnLoading = False
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
        Dim sCodeCPH As String = ""
        Dim sCodeCCH As String = ""
        Dim sCodePR As String = ""
        Dim sCodeSAC As String = ""
        Dim sCodeSP As String = ""
        Dim sCodeCC As String = ""
        Dim sCodeVA As String = ""
        Dim sCodeTERR As String = ""
        Dim sCodeNIV As String = ""
        Dim sCodeNAT As String = ""
        Dim sCodeCOMNAT As String = ""
        Dim sCodeNATDOSE As String = ""
        Dim sCodeCOMTERR As String = ""
        Dim sCodeUP As String = ""
        Dim sCodeFREQMIN As String = ""
        Dim sCodeFREQMAX As String = ""
        Dim sCodeCOMFREQ As String = ""
        Dim sCodeUTMIN As String = ""
        Dim sCodeUTMAX As String = ""
        Dim sCodeCOMDUREE As String = ""
        Dim sCodeCOMADAP As String = ""
        Dim sCodeCOMSURV As String = ""
        Dim sCodeCOMAUTRE As String = ""
        Dim f As New Frm_PosologieMultiCriteres
        f.ShowDialog()
        If f._Validate Then
            If f._bCPH Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CPH_CLASSEPHARMTHER
                fDICO.Text = "Classes pharmaco-thérapeutique"
                fDICO.ShowDialog()
                sCodeCPH = fDICO._Code
            End If
            If f._bCCH Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CCH_CLASSECHIMIQUE
                fDICO.Text = "Classes chimiques"
                fDICO.ShowDialog()
                sCodeCCH = fDICO._Code
            End If
            If f._bPR Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_PR_PRODUIT
                fDICO.Text = "Produits"
                fDICO.ShowDialog()
                sCodePR = fDICO._Code
            End If
            If f._bSAC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SAC_SUBACTIVE
                fDICO.Text = "Substances actives"
                fDICO.ShowDialog()
                sCodeSAC = fDICO._Code
            End If
            If f._bCC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CH_CHOIX
                fDICO.Text = "Critères de choix"
                fDICO.ShowDialog()
                sCodeCC = fDICO._Code
            End If
            If f._bSP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SP_SPECIALITE
                fDICO.Text = "Spécialités"
                fDICO.ShowDialog()
                sCodeSP = fDICO._Code
            End If
            If f._bVA Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("18", " and CDF_CODE_PK  <> '62' ")
                fDICO.Text = "Voies d'administration"
                fDICO.ShowDialog()
                sCodeVA = fDICO._Code
            End If
            If f._bTERR Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("PT")
                fDICO.Text = "Terrains"
                fDICO.ShowDialog()
                sCodeTERR = fDICO._Code
            End If
            If f._bNIV Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("NV")
                fDICO.Text = "Niveaux d'indications"
                fDICO.ShowDialog()
                sCodeNIV = fDICO._Code
            End If
            If f._bNAT Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("NN")
                fDICO.Text = "Natures indications sélectionnées"
                fDICO.ShowDialog()
                sCodeNAT = fDICO._Code
            End If
            If f._bCOMNAT Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("PC", " and substring(CDF_CODE_PK, 1, 1) IN('T', 'Z')")
                fDICO.Text = "Commentaires natures indications"
                fDICO.ShowDialog()
                sCodeCOMNAT = fDICO._Code
            End If
            If f._bNATDOSE Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("PN")
                fDICO.Text = "Natures de dose"
                fDICO.ShowDialog()
                sCodeNATDOSE = fDICO._Code
            End If
            If f._bCOMTERR Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("PC", " and substring(CDF_CODE_PK, 1, 1) IN('B', 'G')")
                fDICO.Text = "Commentaires terrain"
                fDICO.ShowDialog()
                sCodeCOMTERR = fDICO._Code
            End If
            If f._bUP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("PP")
                fDICO.Text = "Unités de prise"
                fDICO.ShowDialog()
                sCodeUP = fDICO._Code
            End If
            If f._bFREQMIN Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("PF")
                fDICO.Text = "Codes fréq - mini"
                fDICO.ShowDialog()
                sCodeFREQMIN = fDICO._Code
            End If
            If f._bFREQMAX Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("PF")
                fDICO.Text = "Codes fréq - maxi"
                fDICO.ShowDialog()
                sCodeFREQMAX = fDICO._Code
            End If
            If f._bCOMFREQ Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("PC", " and substring(CDF_CODE_PK, 1, 1) IN('I', 'Z')")
                fDICO.Text = "Commentaires fréquence"
                fDICO.ShowDialog()
                sCodeCOMFREQ = fDICO._Code
            End If
            If f._bUTMIN Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("PU")
                fDICO.Text = "Unités temps - min"
                fDICO.ShowDialog()
                sCodeUTMIN = fDICO._Code
            End If
            If f._bUTMAX Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("PU")
                fDICO.Text = "Unités temps - max"
                fDICO.ShowDialog()
                sCodeUTMAX = fDICO._Code
            End If
            If f._bCOMDUREE Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("PC", " and substring(CDF_CODE_PK, 1, 1) IN('D', 'Z')")
                fDICO.Text = "Commentaires durée"
                fDICO.ShowDialog()
                sCodeCOMDUREE = fDICO._Code
            End If
            If f._bCOMADAP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("PC", " and substring(CDF_CODE_PK, 1, 1) IN('A', 'Z')")
                fDICO.Text = "Commentaires adaptation"
                fDICO.ShowDialog()
                sCodeCOMADAP = fDICO._Code
            End If
            If f._bCOMSURV Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("PC", "and substring(CDF_CODE_PK,1,1) = 'S' ")
                fDICO.Text = "Commentaires surveillance"
                fDICO.ShowDialog()
                sCodeCOMSURV = fDICO._Code
            End If
            If f._bCOMAUTRE Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("PC", "and substring(CDF_CODE_PK,1,1) not in ('A','B','D','G','I','S','T') ")
                fDICO.Text = "Commentaires autres"
                fDICO.ShowDialog()
                sCodeCOMAUTRE = fDICO._Code
            End If

            Dim fResultat As New Frm_Recherche
            Dim sSQL As String = ""
            sSQL &= " SELECT FPO_CODE_SQ_PK AS code, '' AS libelle FROM THERIAQUE.FPO_FICHEPOSO  "
            If sCodeCPH <> "" Then
                sSQL &= " WHERE FPO_CODE_SQ_PK IN (SELECT FPOCPH_FPO_CODE_FK_PK FROM THERIAQUE.FPOCPH_FPOSO_CLPH WHERE FPOCPH_CPH_CODE_FK_PK = " & cn.SQLText(sCodeCPH) & ")"
            End If
            If sCodeCCH <> "" Then
                If sCodeCPH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPO_CODE_SQ_PK IN (SELECT FPOCCH_FPO_CODE_FK_PK FROM THERIAQUE.FPOCCH_FPOSO_CLCH WHERE FPOCCH_CCH_CODE_FK_PK = " & cn.SQLText(sCodeCCH) & ")"
            End If
            If sCodeSAC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPO_CODE_SQ_PK IN (SELECT FPOSAC_FPO_CODE_FK_PK FROM THERIAQUE.FPOSAC_POSO_SUBACT WHERE FPOSAC_SAC_CODE_FK_PK = " & cn.SQLText(sCodeSAC) & ")"
            End If
            If sCodePR <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPO_CODE_SQ_PK IN (SELECT FPOPR_FPO_CODE_FK_PK FROM THERIAQUE.FPOPR_FPOSO_PROD WHERE FPOPR_PR_CODE_FK_PK = " & cn.SQLText(sCodePR) & ")"
            End If
            If sCodeSP <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPO_CODE_SQ_PK IN (SELECT FPOSP_FPO_CODE_FK_PK FROM THERIAQUE.FPOSP_POSO_SPE WHERE FPOSP_SP_CODE_FK_PK = " & cn.SQLText(sCodeSP) & ")"
            End If
            If sCodeCC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Or sCodeSP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPO_CODE_SQ_PK IN (SELECT FINCH_FIN_CODE_FK_PK FROM THERIAQUE.FPOCH_POSOCHOIX WHERE FPOCH_CH_CODE_FK_PK = " & cn.SQLText(sCodeCC) & ")"
            End If
            If sCodeVA <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPO_CODE_SQ_PK IN (SELECT FPOVO_FPO_CODE_FK_PK FROM THERIAQUE.FPOVO_FPOSO_VOIE WHERE FPOVO_CDF_VO_CODE_FK_PK = " & cn.SQLText(sCodeVA) & ")"
            End If
            If sCodeTERR <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeVA <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPO_CODE_SQ_PK IN (SELECT FPOTE_FPO_CODE_FK_PK FROM THERIAQUE.FPOTE_FPOSO_TERRAIN WHERE FPOTE_CDF_TEPO_CODE_FK_PK = " & cn.SQLText(sCodeTERR) & ")"
            End If
            If sCodeNIV <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeVA <> "" Or sCodeTERR <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPO_CODE_SQ_PK IN (SELECT FPOSP_FPO_CODE_FK_PK FROM THERIAQUE.FPOSP_POSO_SPE"
                sSQL &= " WHERE FPOSP_SP_CODE_FK_PK IN( "
                sSQL &= " SELECT FINSP_SP_CODE_FK_PK FROM THERIAQUE.FINSP_INDSPE, THERIAQUE.FIN_FICHEINDIC"
                sSQL &= " WHERE FINSP_FIN_CODE_FK_PK = FIN_CODE_SQ_PK  AND FIN_CDF_NVIN_CODE_FK_PK = " & cn.SQLText(sCodeNIV) & "))"
            End If
            If sCodeNAT <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeVA <> "" Or sCodeTERR <> "" Or sCodeNIV <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPO_CODE_SQ_PK IN (SELECT FPOUT_FPO_CODE_FK_PK FROM THERIAQUE.FPOUT_FPOSO_UTILTH WHERE FPOUT_CDF_UTPO_CODE_FK_PK = " & cn.SQLText(sCodeNAT) & ")"
            End If
            If sCodeCOMNAT <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeVA <> "" Or sCodeTERR <> "" Or sCodeNIV <> "" Or sCodeNAT <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPO_CODE_SQ_PK IN (SELECT FPOCOUT_FPO_CODE_FK_PK FROM THERIAQUE.FPOCOUT_FPOSO_COMMENTUTILTH WHERE FPOCOUT_CDF_COUT_CODE_FK_PK = " & cn.SQLText(sCodeCOMNAT) & ")"
            End If
            If sCodeNATDOSE <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeVA <> "" Or sCodeTERR <> "" Or sCodeNIV <> "" Or sCodeNAT <> "" Or sCodeCOMNAT <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPO_CODE_SQ_PK IN (SELECT IPO_FPO_CODE_FK_PK FROM THERIAQUE.IPO_INFOPOSO WHERE IPO_CDF_NAPO_CODE_FK = " & cn.SQLText(sCodeNATDOSE) & ")"
            End If
            If sCodeCOMTERR <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeVA <> "" Or sCodeTERR <> "" Or sCodeNIV <> "" Or sCodeNAT <> "" Or sCodeCOMNAT <> "" Or sCodeNATDOSE <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPO_CODE_SQ_PK IN (SELECT IPOCOTE_IPO_CODE_FK_PK FROM THERIAQUE.IPOCOTE_INFPO_COMMENT_TERRAIN WHERE IPOCOTE_CDF_COTE_CODE_FK_PK = " & cn.SQLText(sCodeCOMTERR) & ")"
            End If
            If sCodeUP <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeVA <> "" Or sCodeTERR <> "" Or sCodeNIV <> "" Or sCodeNAT <> "" Or sCodeCOMNAT <> "" Or sCodeNATDOSE <> "" Or sCodeCOMTERR <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPO_CODE_SQ_PK IN (SELECT IPO_FPO_CODE_FK_PK FROM THERIAQUE.IPO_INFOPOSO WHERE IPO_CDF_UNPO_CODE_FK = " & cn.SQLText(sCodeUP) & ")"
            End If
            If sCodeFREQMIN <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeVA <> "" Or sCodeTERR <> "" Or sCodeNIV <> "" Or sCodeNAT <> "" Or sCodeCOMNAT <> "" Or sCodeNATDOSE <> "" Or sCodeCOMTERR <> "" Or sCodeUP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPO_CODE_SQ_PK IN (SELECT IPO_FPO_CODE_FK_PK FROM THERIAQUE.IPO_INFOPOSO WHERE IPO_CDF_FREQMIN_CODE_FK = " & cn.SQLText(sCodeFREQMIN) & ")"
            End If
            If sCodeFREQMAX <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeVA <> "" Or sCodeTERR <> "" Or sCodeNIV <> "" Or sCodeNAT <> "" Or sCodeCOMNAT <> "" Or sCodeNATDOSE <> "" Or sCodeCOMTERR <> "" Or sCodeUP <> "" Or sCodeFREQMIN <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPO_CODE_SQ_PK IN (SELECT IPO_FPO_CODE_FK_PK FROM THERIAQUE.IPO_INFOPOSO WHERE IPO_CDF_FREQMAX_CODE_FK = " & cn.SQLText(sCodeFREQMAX) & ")"
            End If
            If sCodeCOMFREQ <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeVA <> "" Or sCodeTERR <> "" Or sCodeNIV <> "" Or sCodeNAT <> "" Or sCodeCOMNAT <> "" Or sCodeNATDOSE <> "" Or sCodeCOMTERR <> "" Or sCodeUP <> "" Or sCodeFREQMIN <> "" Or sCodeFREQMAX <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPO_CODE_SQ_PK IN (SELECT IPOCOFQ_IPO_CODE_FK_PK FROM THERIAQUE.IPOCOFQ_INFPO_COMMENT_FREQ WHERE IPOCOFQ_CDF_COFQ_CODE_FK_PK = " & cn.SQLText(sCodeCOMFREQ) & ")"
            End If
            If sCodeUTMIN <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeVA <> "" Or sCodeTERR <> "" Or sCodeNIV <> "" Or sCodeNAT <> "" Or sCodeCOMNAT <> "" Or sCodeNATDOSE <> "" Or sCodeCOMTERR <> "" Or sCodeUP <> "" Or sCodeFREQMIN <> "" Or sCodeFREQMAX <> "" Or sCodeCOMFREQ <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPO_CODE_SQ_PK IN (SELECT IPO_FPO_CODE_FK_PK FROM THERIAQUE.IPO_INFOPOSO WHERE IPO_CDF_UTMIN_CODE_FK = " & cn.SQLText(sCodeUTMIN) & ")"
            End If
            If sCodeUTMAX <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeVA <> "" Or sCodeTERR <> "" Or sCodeNIV <> "" Or sCodeNAT <> "" Or sCodeCOMNAT <> "" Or sCodeNATDOSE <> "" Or sCodeCOMTERR <> "" Or sCodeUP <> "" Or sCodeFREQMIN <> "" Or sCodeFREQMAX <> "" Or sCodeCOMFREQ <> "" Or sCodeUTMIN <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPO_CODE_SQ_PK IN (SELECT IPO_FPO_CODE_FK_PK FROM THERIAQUE.IPO_INFOPOSO WHERE IPO_CDF_UTMAX_CODE_FK = " & cn.SQLText(sCodeUTMAX) & ")"
            End If
            If sCodeCOMDUREE <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeVA <> "" Or sCodeTERR <> "" Or sCodeNIV <> "" Or sCodeNAT <> "" Or sCodeCOMNAT <> "" Or sCodeNATDOSE <> "" Or sCodeCOMTERR <> "" Or sCodeUP <> "" Or sCodeFREQMIN <> "" Or sCodeFREQMAX <> "" Or sCodeCOMFREQ <> "" Or sCodeUTMIN <> "" Or sCodeUTMAX <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPO_CODE_SQ_PK IN (SELECT IPOCOD_IPO_CODE_FK_PK FROM THERIAQUE.IPOCOD_INFPO_COMMENT_DUREE WHERE IPOCOD_CDF_COD_CODE_FK_PK = " & cn.SQLText(sCodeCOMDUREE) & ")"
            End If
            If sCodeCOMADAP <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeVA <> "" Or sCodeTERR <> "" Or sCodeNIV <> "" Or sCodeNAT <> "" Or sCodeCOMNAT <> "" Or sCodeNATDOSE <> "" Or sCodeCOMTERR <> "" Or sCodeUP <> "" Or sCodeFREQMIN <> "" Or sCodeFREQMAX <> "" Or sCodeCOMFREQ <> "" Or sCodeUTMIN <> "" Or sCodeUTMAX <> "" Or sCodeCOMDUREE <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPO_CODE_SQ_PK IN (SELECT FPOCOAD_FPO_CODE_FK_PK FROM THERIAQUE.FPOCOAD_FPOSO_COMMENT_ADAPT WHERE FPOCOAD_CDF_COAD_CODE_FK_PK = " & cn.SQLText(sCodeCOMADAP) & ")"
            End If
            If sCodeCOMSURV <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeVA <> "" Or sCodeTERR <> "" Or sCodeNIV <> "" Or sCodeNAT <> "" Or sCodeCOMNAT <> "" Or sCodeNATDOSE <> "" Or sCodeCOMTERR <> "" Or sCodeUP <> "" Or sCodeFREQMIN <> "" Or sCodeFREQMAX <> "" Or sCodeCOMFREQ <> "" Or sCodeUTMIN <> "" Or sCodeUTMAX <> "" Or sCodeCOMDUREE <> "" Or sCodeCOMADAP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPO_CODE_SQ_PK IN (SELECT FPOCOSU_FPO_CODE_FK_PK FROM THERIAQUE.FPOCOSU_FPOSO_COMMENT_SURVEIL WHERE FPOCOSU_CDF_COSU_CODE_FK_PK = " & cn.SQLText(sCodeCOMSURV) & ")"
            End If
            If sCodeCOMAUTRE <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodePR <> "" Or sCodeSP <> "" Or sCodeCC <> "" Or sCodeVA <> "" Or sCodeTERR <> "" Or sCodeNIV <> "" Or sCodeNAT <> "" Or sCodeCOMNAT <> "" Or sCodeNATDOSE <> "" Or sCodeCOMTERR <> "" Or sCodeUP <> "" Or sCodeFREQMIN <> "" Or sCodeFREQMAX <> "" Or sCodeCOMFREQ <> "" Or sCodeUTMIN <> "" Or sCodeUTMAX <> "" Or sCodeCOMDUREE <> "" Or sCodeCOMADAP <> "" Or sCodeCOMSURV <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPO_CODE_SQ_PK IN (SELECT FPOCOAU_FPO_CODE_FK_PK FROM THERIAQUE.FPOCOAU_FPOSO_COMMENT_AUTRE WHERE FPOCOAU_CDF_COAU_CODE_FK_PK = " & cn.SQLText(sCodeCOMAUTRE) & ")"
            End If
            sSQL &= " ORDER BY FPO_CODE_SQ_PK"

            fResultat._SSQL = sSQL
            fResultat.Text = Me.Text
            fResultat.ShowDialog()
            CodE = fResultat._Code
            If fResultat._Code IsNot Nothing Then
                OnLoading = True
                EmptyDataTable()
                Me.XtraTabControl1.SelectedTabPageIndex = 0
                Me.FpO_TA.FillByCode(Me.DsTheriaque_Posologie1.FPO_FICHEPOSO, fResultat._Code)

                'Onglet Entités
                Me.FpocpH_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOCPH_FPOSO_CLPH, fResultat._Code)
                Me.FpoccH_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOCCH_FPOSO_CLCH, fResultat._Code)
                Me.FpocH_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOCH_POSOCHOIX, fResultat._Code)
                Me.FposaC_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOSAC_POSO_SUBACT, fResultat._Code)
                Me.FpopR_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOPR_FPOSO_PROD, fResultat._Code)
                Me.FposP_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOSP_POSO_SPE, fResultat._Code)
                CodeWhere = GetCodesSPForInCondition()
                Me.IPODUREE.FillByCode(Me.DsTheriaque_Posologie1.IPODUREE_INFOPOSO, CodeWhere)

                Tab_TA1 = False
                Tab_TA2 = False
                Tab_TA3 = False
                Tab_TA4 = False
                Tab_TA5 = False
                Tab_TA6 = False

                bModeDuplication = False
                OnLoading = False
                bLoadPoso = False
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Overrides Sub Ajouter()
        Me.XtraTabControl1.SelectedTabPageIndex = 0
        EmptyDataTable()
        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        SetCode_MAx(MasterTable, txtCode)
        CodE = InvalideControl
        MyBase.Ajouter()
        bModeDuplication = False
    End Sub

    Public Overrides Function supprimer() As Boolean
        If Tab_TA1 And Tab_TA2 And Tab_TA3 And Tab_TA4 And Tab_TA5 Then
            Dim iCount As Integer
            MyBase.Supprimer()
            For iCount = 0 To DsTheriaque_Posologie1.FPOCOUT_FPOSO_COMMENTUTILTH.Rows.Count - 1
                DsTheriaque_Posologie1.FPOCOUT_FPOSO_COMMENTUTILTH.Rows(iCount).Delete()
            Next
            Me.FpocouT_TA.Update(DsTheriaque_Posologie1)

            For iCount = 0 To DsTheriaque_Posologie1.FPOUT_FPOSO_UTILTH.Rows.Count - 1
                DsTheriaque_Posologie1.FPOUT_FPOSO_UTILTH.Rows(iCount).Delete()
            Next
            Me.FpouT_TA.Update(DsTheriaque_Posologie1)

            For iCount = 0 To DsTheriaque_Posologie1.IPOJ_INFOPOSO_JOURNALIERE.Rows.Count - 1
                DsTheriaque_Posologie1.IPOJ_INFOPOSO_JOURNALIERE.Rows(iCount).Delete()
            Next
            Me.IpoJ_TA.Update(DsTheriaque_Posologie1)

            For iCount = 0 To DsTheriaque_Posologie1.IPODOSE_INFOPOSO.Rows.Count - 1
                DsTheriaque_Posologie1.IPODOSE_INFOPOSO.Rows(iCount).Delete()
            Next
            Me.IpodosE_TA.Update(DsTheriaque_Posologie1)

            For iCount = 0 To DsTheriaque_Posologie1.IPODUREE_INFOPOSO.Rows.Count - 1
                DsTheriaque_Posologie1.IPODUREE_INFOPOSO.Rows(iCount).Delete()
            Next
            Me.IPODUREE.Update(DsTheriaque_Posologie1)

            For iCount = 0 To DsTheriaque_Posologie1.FPOBIB_REFERENCE_BIBLIO.Rows.Count - 1
                DsTheriaque_Posologie1.FPOBIB_REFERENCE_BIBLIO.Rows(iCount).Delete()
            Next
            Me.FpobiB_ta.Update(DsTheriaque_Posologie1)

            For iCount = 0 To DsTheriaque_Posologie1.FPOCOAD_FPOSO_COMMENT_ADAPT.Rows.Count - 1
                DsTheriaque_Posologie1.FPOCOAD_FPOSO_COMMENT_ADAPT.Rows(iCount).Delete()
            Next
            Me.FpocoaD_TA.Update(DsTheriaque_Posologie1)

            For iCount = 0 To DsTheriaque_Posologie1.FPOCOSU_FPOSO_COMMENT_SURVEIL.Rows.Count - 1
                DsTheriaque_Posologie1.FPOCOSU_FPOSO_COMMENT_SURVEIL.Rows(iCount).Delete()
            Next
            Me.FpocosU_TA.Update(DsTheriaque_Posologie1)

            For iCount = 0 To DsTheriaque_Posologie1.FPOCOAU_FPOSO_COMMENT_AUTRE.Rows.Count - 1
                DsTheriaque_Posologie1.FPOCOAU_FPOSO_COMMENT_AUTRE.Rows(iCount).Delete()
            Next
            Me.FpocoaU_TA.Update(DsTheriaque_Posologie1)

            For iCount = 0 To DsTheriaque_Posologie1.IPOCOD_INFPO_COMMENT_DUREE.Rows.Count - 1
                DsTheriaque_Posologie1.IPOCOD_INFPO_COMMENT_DUREE.Rows(iCount).Delete()
            Next
            Me.IpocoD_TA.Update(DsTheriaque_Posologie1)

            For iCount = 0 To DsTheriaque_Posologie1.IPOCOFQ_INFPO_COMMENT_FREQ.Rows.Count - 1
                DsTheriaque_Posologie1.IPOCOFQ_INFPO_COMMENT_FREQ.Rows(iCount).Delete()
            Next
            Me.IpocofQ_TA.Update(DsTheriaque_Posologie1)

            For iCount = 0 To DsTheriaque_Posologie1.IPOCOTE_INFPO_COMMENT_TERRAIN.Rows.Count - 1
                DsTheriaque_Posologie1.IPOCOTE_INFPO_COMMENT_TERRAIN.Rows(iCount).Delete()
            Next
            Me.IpocotE_TA.Update(DsTheriaque_Posologie1)

            Me.IpO_TA.FillByCode(Me.DsTheriaque_Posologie1.IPO_INFOPOSO, txtCode.Text)

            For iCount = 0 To DsTheriaque_Posologie1.IPO_INFOPOSO.Rows.Count - 1
                DsTheriaque_Posologie1.IPO_INFOPOSO.Rows(0).Delete()
            Next
            'Me.IpO_TA.Update(DsTheriaque_Posologie1)

            For iCount = 0 To DsTheriaque_Posologie1.FPOTE_FPOSO_TERRAIN.Rows.Count - 1
                DsTheriaque_Posologie1.FPOTE_FPOSO_TERRAIN.Rows(iCount).Delete()
            Next
            Me.FpotE_TA.Update(DsTheriaque_Posologie1)

            For iCount = 0 To DsTheriaque_Posologie1.FPOVO_FPOSO_VOIE.Rows.Count - 1
                DsTheriaque_Posologie1.FPOVO_FPOSO_VOIE.Rows(iCount).Delete()
            Next
            Me.FpovO_TA.Update(DsTheriaque_Posologie1)

            For iCount = 0 To DsTheriaque_Posologie1.FPOCH_POSOCHOIX.Rows.Count - 1
                DsTheriaque_Posologie1.FPOCH_POSOCHOIX.Rows(iCount).Delete()
            Next
            Me.FpocH_TA.Update(DsTheriaque_Posologie1)

            For iCount = 0 To DsTheriaque_Posologie1.FPOSP_POSO_SPE.Rows.Count - 1
                DsTheriaque_Posologie1.FPOSP_POSO_SPE.Rows(iCount).Delete()
            Next
            Me.FposP_TA.Update(DsTheriaque_Posologie1)

            For iCount = 0 To DsTheriaque_Posologie1.FPOPR_FPOSO_PROD.Rows.Count - 1
                DsTheriaque_Posologie1.FPOPR_FPOSO_PROD.Rows(iCount).Delete()
            Next
            Me.FpopR_TA.Update(DsTheriaque_Posologie1)

            For iCount = 0 To DsTheriaque_Posologie1.FPOSAC_POSO_SUBACT.Rows.Count - 1
                DsTheriaque_Posologie1.FPOSAC_POSO_SUBACT.Rows(iCount).Delete()
            Next
            Me.FposaC_TA.Update(DsTheriaque_Posologie1)

            For iCount = 0 To DsTheriaque_Posologie1.FPOCCH_FPOSO_CLCH.Rows.Count - 1
                DsTheriaque_Posologie1.FPOCCH_FPOSO_CLCH.Rows(iCount).Delete()
            Next
            Me.FpoccH_TA.Update(DsTheriaque_Posologie1)

            For iCount = 0 To DsTheriaque_Posologie1.FPOCPH_FPOSO_CLPH.Rows.Count - 1
                DsTheriaque_Posologie1.FPOCPH_FPOSO_CLPH.Rows(iCount).Delete()
            Next
            Me.FpocpH_TA.Update(DsTheriaque_Posologie1)

            For iCount = 0 To DsTheriaque_Posologie1.FPOAFS_POSO_AFSSAPS.Rows.Count - 1
                DsTheriaque_Posologie1.FPOAFS_POSO_AFSSAPS.Rows(iCount).Delete()
            Next
            Me.FpoafS_TA.Update(DsTheriaque_Posologie1)

            'MASTER
            For iCount = 0 To DsTheriaque_Posologie1.FPO_FICHEPOSO.Rows.Count - 1
                DsTheriaque_Posologie1.FPO_FICHEPOSO.Rows(iCount).Delete()
            Next
            Me.FpO_TA.Update(DsTheriaque_Posologie1)

            bModeDuplication = False
            Return True
        Else
            Process_Message(strChargementOnglet, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Function

    Protected Friend Overrides Function ValideControl(Optional ByRef Ctrl As Control = Nothing, Optional ByVal AllCtrl As Boolean = True) As Boolean
        MyBase.ValideControl(Ctrl)
        Dim iCount As Integer
        For iCount = 0 To GV29.RowCount - 1
            If Not FieldExistRO(GV6, colFPOSP_SP_CODE_FK_PK2, GV29.GetRowCellValue(iCount, colFPOAFS_SP_CODE_FK_PK)) Then
                GV29.FocusedRowHandle = iCount
                GV29.SetColumnError(colFPOAFS_SP_CODE_FK_PK, "La spécialité doit être présente dans la fiche.")
                XtraTabControl1.SelectedTabPageIndex = 4
                Exit Function
            Else
                GV29.SetColumnError(colFPOAFS_SP_CODE_FK_PK, "")
            End If
        Next
        iCount = GV7.RowCount
        If Not Tab_TA1 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.FpovO_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOVO_FPOSO_VOIE, CodE)
            If iCount < 1 Then
                Process_Message("La voie d'administration est obligatoire.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                XtraTabControl1.SelectedTabPageIndex = 1
                GV7.Focus()
                Exit Function
            End If
        Else
            If iCount < 2 Then
                Process_Message("La voie d'administration est obligatoire.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                XtraTabControl1.SelectedTabPageIndex = 1
                GV7.Focus()
                Exit Function
            End If
        End If
        Return True
    End Function

    Public Overrides Sub valider()
        MyBase.Valider()

        Dim clsP As New ClsPosologieDose
        Dim codeSp As String = ""
        Dim dtPosoFiche As DataTable

        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        FpO_TA.Update(Me.DsTheriaque_Posologie1.FPO_FICHEPOSO)

        Me.BindingContext(Me.MasterDataSet, FPOCPH_FPOSO_CLPH).EndCurrentEdit()
        FpocpH_TA.Update(Me.DsTheriaque_Posologie1.FPOCPH_FPOSO_CLPH)

        Me.BindingContext(Me.MasterDataSet, FPOCCH_FPOSO_CLCH).EndCurrentEdit()
        FpoccH_TA.Update(Me.DsTheriaque_Posologie1.FPOCCH_FPOSO_CLCH)

        Me.BindingContext(Me.MasterDataSet, FPOSAC_POSO_SUBACT).EndCurrentEdit()
        FposaC_TA.Update(Me.DsTheriaque_Posologie1.FPOSAC_POSO_SUBACT)

        Me.BindingContext(Me.MasterDataSet, FPOPR_FPOSO_PROD).EndCurrentEdit()
        FpopR_TA.Update(Me.DsTheriaque_Posologie1.FPOPR_FPOSO_PROD)

        Me.BindingContext(Me.MasterDataSet, FPOCH_POSOCHOIX).EndCurrentEdit()
        FpocH_TA.Update(Me.DsTheriaque_Posologie1.FPOCH_POSOCHOIX)

        Me.BindingContext(Me.MasterDataSet, FPOSP_POSO_SPE).EndCurrentEdit()
        FposP_TA.Update(Me.DsTheriaque_Posologie1.FPOSP_POSO_SPE)

        Me.BindingContext(Me.MasterDataSet, FPOVO_FPOSO_VOIE).EndCurrentEdit()
        FpovO_TA.Update(Me.DsTheriaque_Posologie1.FPOVO_FPOSO_VOIE)

        Me.BindingContext(Me.MasterDataSet, FPOTE_FPOSO_TERRAIN).EndCurrentEdit()
        FpotE_TA.Update(Me.DsTheriaque_Posologie1.FPOTE_FPOSO_TERRAIN)

        Me.BindingContext(Me.MasterDataSet, IPO_INFOPOSO).EndCurrentEdit()

        For k As Integer = 0 To Me.DsTheriaque_Posologie1.IPO_INFOPOSO.Rows.Count - 1
            Try
                If (String.IsNullOrEmpty(Me.DsTheriaque_Posologie1.IPO_INFOPOSO.Rows(k).Item("IPO_DOSEMIN").ToString())) Then
                    Me.DsTheriaque_Posologie1.IPO_INFOPOSO.Rows(k).Item("IPO_DOSEMIN") = System.DBNull.Value
                End If
            Catch ex As Exception
                
            End Try
        Next


        IpO_TA.Update(Me.DsTheriaque_Posologie1.IPO_INFOPOSO)

        Me.BindingContext(Me.MasterDataSet, IPOCOTE_INFPO_COMMENT_TERRAIN).EndCurrentEdit()
        IpocotE_TA.Update(Me.DsTheriaque_Posologie1.IPOCOTE_INFPO_COMMENT_TERRAIN)
        'ici

        'Ticket 4385
        'If bValidateCommentaireFreq Then
        Me.BindingContext(Me.MasterDataSet, IPOCOFQ_INFPO_COMMENT_FREQ).EndCurrentEdit()
        IpocofQ_TA.Update(Me.DsTheriaque_Posologie1.IPOCOFQ_INFPO_COMMENT_FREQ)
        'End If

        'If bValidateCommentaireDuree Then
        Me.BindingContext(Me.MasterDataSet, IPOCOD_INFPO_COMMENT_DUREE).EndCurrentEdit()
        IpocoD_TA.Update(Me.DsTheriaque_Posologie1.IPOCOD_INFPO_COMMENT_DUREE)
        'End If

        Me.BindingContext(Me.MasterDataSet, FPOCOAD_FPOSO_COMMENT_ADAPT).EndCurrentEdit()
        FpocoaD_TA.Update(Me.DsTheriaque_Posologie1.FPOCOAD_FPOSO_COMMENT_ADAPT)

        Me.BindingContext(Me.MasterDataSet, FPOCOSU_FPOSO_COMMENT_SURVEIL).EndCurrentEdit()
        FpocosU_TA.Update(Me.DsTheriaque_Posologie1.FPOCOSU_FPOSO_COMMENT_SURVEIL)

        Me.BindingContext(Me.MasterDataSet, FPOCOAU_FPOSO_COMMENT_AUTRE).EndCurrentEdit()
        FpocoaU_TA.Update(Me.DsTheriaque_Posologie1.FPOCOAU_FPOSO_COMMENT_AUTRE)

        Me.BindingContext(Me.MasterDataSet, FPOBIB_REFERENCE_BIBLIO).EndCurrentEdit()
        FpobiB_ta.Update(Me.DsTheriaque_Posologie1.FPOBIB_REFERENCE_BIBLIO)

        Dim i As Integer = Me.DsTheriaque_Posologie1.IPOJ_INFOPOSO_JOURNALIERE.Rows.Count
        Me.BindingContext(Me.MasterDataSet, IPOJ_INFOPOSO_JOURNALIERE).EndCurrentEdit()
        IpoJ_TA.Update(Me.DsTheriaque_Posologie1.IPOJ_INFOPOSO_JOURNALIERE)

        Me.BindingContext(Me.MasterDataSet, IPODOSE_INFOPOSO).EndCurrentEdit()
        IpodosE_TA.Update(Me.DsTheriaque_Posologie1.IPODOSE_INFOPOSO)

        'If (NewCalculation) Then
        '    strWhere = ""
        '    For ii As Integer = 0 To GV6.RowCount - 1
        '        codeSp = GV6.GetRowCellValue(ii, colFPOSP_SP_CODE_FK_PK2)
        '        If Not String.IsNullOrEmpty(codeSp) Then

        '            strWhere &= codeSp & ","

        '        End If
        '    Next

        '    dtPosoFiche = clsP.GetPosoByAllSpecs(strWhere)
        '    Dim dr As DataRow

        '    If (dtPosoFiche.Rows.Count > 0) Then

        '        Dim IdMax As Integer = clsP.MaxId()
        '        For ii As Integer = 0 To dtPosoFiche.Rows.Count - 1
        '            If (dtPosoFiche.Rows(ii).Item("FPOSP_FPO_CODE_FK_PK") <> txtCode.Text) Then
        '                clsP.DeleteResult(dtPosoFiche.Rows(ii).Item("FPOSP_FPO_CODE_FK_PK"))

        '                For iCount As Integer = 0 To DsTheriaque_Posologie1.IPODOSE_INFOPOSO.Rows.Count - 1

        '                    If clsP.IsSPinPoso(dtPosoFiche.Rows(ii).Item("FPOSP_FPO_CODE_FK_PK"), DsTheriaque_Posologie1.IPODOSE_INFOPOSO.Rows(iCount).Item("IPODOSE_SP_CIPUCD")) Then

        '                        dr = DsTheriaque_Posologie1.IPODOSE_INFOPOSO.NewRow()
        '                        dr("IPODOSE_FPO_CODE_FK_PK") = dtPosoFiche.Rows(ii).Item("FPOSP_FPO_CODE_FK_PK")
        '                        For jj As Integer = 0 To dr.Table.Columns.Count - 1
        '                            If dr.Table.Columns(jj).ColumnName.ToUpper() <> "ID" And dr.Table.Columns(jj).ColumnName.ToUpper() <> "IPODOSE_FPO_CODE_FK_PK" Then
        '                                dr(dr.Table.Columns(jj).ColumnName) = DsTheriaque_Posologie1.IPODOSE_INFOPOSO.Rows(iCount).Item(dr.Table.Columns(jj).ColumnName)
        '                            End If
        '                        Next

        '                        DsTheriaque_Posologie1.IPODOSE_INFOPOSO.Rows.Add(dr)
        '                        IpodosE_TA.Update(Me.DsTheriaque_Posologie1.IPODOSE_INFOPOSO)

        '                    End If

        '                Next
        '                CodeWhere = GetCodesSPForInCondition()
        '                Me.IpodosE_TA.FillByCode(Me.DsTheriaque_Posologie1.IPODOSE_INFOPOSO, CodeWhere)

        '            End If
        '        Next
        '    End If
        'End If

        Me.BindingContext(Me.MasterDataSet, IPODUREE_INFOPOSO).EndCurrentEdit()
        IPODUREE.Update(Me.DsTheriaque_Posologie1.IPODUREE_INFOPOSO)

        'If (NewDuration) Then
        '    strWhere = ""
        '    For ii As Integer = 0 To GV6.RowCount - 1
        '        codeSp = GV6.GetRowCellValue(ii, colFPOSP_SP_CODE_FK_PK2)
        '        If Not String.IsNullOrEmpty(codeSp) Then

        '            strWhere &= codeSp & ","

        '        End If
        '    Next

        '    dtPosoFiche = clsP.GetPosoByAllSpecs(strWhere)
        '    Dim dr As DataRow

        '    If (dtPosoFiche.Rows.Count > 0) Then

        '        For ii As Integer = 0 To dtPosoFiche.Rows.Count - 1
        '            If (dtPosoFiche.Rows(ii).Item("FPOSP_FPO_CODE_FK_PK") <> txtCode.Text) Then
        '                clsP.DeleteDureeResult(dtPosoFiche.Rows(ii).Item("FPOSP_FPO_CODE_FK_PK"))
        '                For iCount As Integer = 0 To DsTheriaque_Posologie1.IPODUREE_INFOPOSO.Rows.Count - 1

        '                    ' Récupérer l'ucd + déterminer les posologie ayant l'ucd 
        '                    If clsP.IsSPinPoso(dtPosoFiche.Rows(ii).Item("FPOSP_FPO_CODE_FK_PK"), DsTheriaque_Posologie1.IPODUREE_INFOPOSO.Rows(iCount).Item("IPODUREE_SP_CIPUCD")) Then

        '                        dr = DsTheriaque_Posologie1.IPODUREE_INFOPOSO.NewRow()
        '                        dr("IPODUREE_FPO_CODE_PK_FK") = dtPosoFiche.Rows(ii).Item("FPOSP_FPO_CODE_FK_PK")
        '                        For jj As Integer = 0 To dr.Table.Columns.Count - 1
        '                            If dr.Table.Columns(jj).ColumnName.ToUpper() <> "ID" And dr.Table.Columns(jj).ColumnName.ToUpper() <> "IPODUREE_FPO_CODE_PK_FK" Then
        '                                dr(dr.Table.Columns(jj).ColumnName) = DsTheriaque_Posologie1.IPODUREE_INFOPOSO.Rows(iCount).Item(dr.Table.Columns(jj).ColumnName)
        '                            End If
        '                        Next

        '                        DsTheriaque_Posologie1.IPODUREE_INFOPOSO.Rows.Add(dr)
        '                        IPODUREE.Update(Me.DsTheriaque_Posologie1.IPODUREE_INFOPOSO)

        '                    End If

        '                Next

        '                Me.IPODUREE.FillByCode(Me.DsTheriaque_Posologie1.IPODUREE_INFOPOSO, txtCode.Text)

        '            End If
        '        Next
        '    End If
        'End If

        'NewCalculation = False
        'NewDuration = False

        Me.BindingContext(Me.MasterDataSet, FPOUT_FPOSO_UTILTH).EndCurrentEdit()
        FpouT_TA.Update(Me.DsTheriaque_Posologie1.FPOUT_FPOSO_UTILTH)

        Me.BindingContext(Me.MasterDataSet, FPOAFS_POSO_AFSSAPS).EndCurrentEdit()
        FpoafS_TA.Update(Me.DsTheriaque_Posologie1.FPOAFS_POSO_AFSSAPS)

        Me.BindingContext(Me.MasterDataSet, FPOCOUT_FPOSO_COMMENTUTILTH).EndCurrentEdit()
        FpocouT_TA.Update(Me.DsTheriaque_Posologie1.FPOCOUT_FPOSO_COMMENTUTILTH)

        bModeDuplication = False

        'IPOJ_INFOPOSO_JOURNALIERE

        Dim req As String = ""
        req = " update [theriaque].[IPOJ_INFOPOSO_JOURNALIERE] set [theriaque].[IPOJ_INFOPOSO_JOURNALIERE].IPOJ_UCD13 = ("
        req += " select t2.SP_CIPUCD13 from [theriaque].[SP_SPECIALITE] t2 where t2.SP_CODE_SQ_PK = [theriaque].IPOJ_INFOPOSO_JOURNALIERE.IPOJ_SP_CODE_FK_PK)"
        cn.ExecuteUCDCIP13(req)

    End Sub

    Public Overrides Sub annuler()
        OnLoading = True
        MyBase.Annuler()
        'Onglet Entités

        Me.BindingContext(Me.MasterDataSet, FPOCOUT_FPOSO_COMMENTUTILTH).CancelCurrentEdit()
        Me.DsTheriaque_Posologie1.FPOCOUT_FPOSO_COMMENTUTILTH.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, FPOUT_FPOSO_UTILTH).CancelCurrentEdit()
        Me.DsTheriaque_Posologie1.FPOUT_FPOSO_UTILTH.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, IPOJ_INFOPOSO_JOURNALIERE).CancelCurrentEdit()
        'Me.DsTheriaque_Posologie1.IPOJ_INFOPOSO_JOURNALIERE.RejectChanges()
        If CodE <> InvalideControl And CodE <> Nothing Then
            CodeWhere = GetCodesSPForInCondition()
            Me.IpoJ_TA.FillByCode(Me.DsTheriaque_Posologie1.IPOJ_INFOPOSO_JOURNALIERE, CodE)
        End If

        Me.BindingContext(Me.MasterDataSet, IPODOSE_INFOPOSO).CancelCurrentEdit()
        If CodE <> InvalideControl And CodE <> Nothing Then
            CodeWhere = GetCodesSPForInCondition()
            Me.IpodosE_TA.FillByCode(Me.DsTheriaque_Posologie1.IPODOSE_INFOPOSO, CodeWhere)
        End If

        If CodE <> InvalideControl And CodE <> Nothing Then
            CodeWhere = GetCodesSPForInCondition()
            Me.IPODUREE.FillByCode(Me.DsTheriaque_Posologie1.IPODUREE_INFOPOSO, CodeWhere)
        End If

        Me.BindingContext(Me.MasterDataSet, FPOBIB_REFERENCE_BIBLIO).CancelCurrentEdit()
        Me.DsTheriaque_Posologie1.FPOBIB_REFERENCE_BIBLIO.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, FPOCOAD_FPOSO_COMMENT_ADAPT).CancelCurrentEdit()
        Me.DsTheriaque_Posologie1.FPOCOAD_FPOSO_COMMENT_ADAPT.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, FPOCOSU_FPOSO_COMMENT_SURVEIL).CancelCurrentEdit()
        Me.DsTheriaque_Posologie1.FPOCOSU_FPOSO_COMMENT_SURVEIL.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, FPOCOAU_FPOSO_COMMENT_AUTRE).CancelCurrentEdit()
        Me.DsTheriaque_Posologie1.FPOCOAU_FPOSO_COMMENT_AUTRE.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, IPOCOFQ_INFPO_COMMENT_FREQ).CancelCurrentEdit()
        Me.DsTheriaque_Posologie1.IPOCOFQ_INFPO_COMMENT_FREQ.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, IPOCOD_INFPO_COMMENT_DUREE).CancelCurrentEdit()
        Me.DsTheriaque_Posologie1.IPOCOD_INFPO_COMMENT_DUREE.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, IPOCOTE_INFPO_COMMENT_TERRAIN).CancelCurrentEdit()
        Me.DsTheriaque_Posologie1.IPOCOTE_INFPO_COMMENT_TERRAIN.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, IPO_INFOPOSO).CancelCurrentEdit()
        Me.DsTheriaque_Posologie1.IPO_INFOPOSO.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, FPOTE_FPOSO_TERRAIN).CancelCurrentEdit()
        Me.DsTheriaque_Posologie1.FPOTE_FPOSO_TERRAIN.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, FPOSP_POSO_SPE).CancelCurrentEdit()
        Me.DsTheriaque_Posologie1.FPOSP_POSO_SPE.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, FPOCH_POSOCHOIX).CancelCurrentEdit()
        Me.DsTheriaque_Posologie1.FPOCH_POSOCHOIX.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, FPOPR_FPOSO_PROD).CancelCurrentEdit()
        Me.DsTheriaque_Posologie1.FPOPR_FPOSO_PROD.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, FPOSAC_POSO_SUBACT).CancelCurrentEdit()
        Me.DsTheriaque_Posologie1.FPOSAC_POSO_SUBACT.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, FPOCCH_FPOSO_CLCH).CancelCurrentEdit()
        Me.DsTheriaque_Posologie1.FPOCCH_FPOSO_CLCH.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, FPOCPH_FPOSO_CLPH).CancelCurrentEdit()
        Me.DsTheriaque_Posologie1.FPOCPH_FPOSO_CLPH.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, FPOVO_FPOSO_VOIE).CancelCurrentEdit()
        Me.DsTheriaque_Posologie1.FPOVO_FPOSO_VOIE.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, FPOAFS_POSO_AFSSAPS).CancelCurrentEdit()
        Me.DsTheriaque_Posologie1.FPOAFS_POSO_AFSSAPS.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, FPO_FICHEPOSO).CancelCurrentEdit()
        Me.DsTheriaque_Posologie1.FPO_FICHEPOSO.RejectChanges()

        If bModeDuplication Then EmptyDataTable()
        bModeDuplication = False
        OnLoading = False
    End Sub

    Private Sub EmptyDataTable()
        Me.DsTheriaque_Posologie1.FPOCOUT_FPOSO_COMMENTUTILTH.Clear()
        Me.DsTheriaque_Posologie1.FPOUT_FPOSO_UTILTH.Clear()
        Me.DsTheriaque_Posologie1.IPOJ_INFOPOSO_JOURNALIERE.Clear()
        Me.DsTheriaque_Posologie1.IPODOSE_INFOPOSO.Clear()
        Me.DsTheriaque_Posologie1.IPODUREE_INFOPOSO.Clear()
        Me.DsTheriaque_Posologie1.FPOBIB_REFERENCE_BIBLIO.Clear()
        Me.DsTheriaque_Posologie1.FPOCOAD_FPOSO_COMMENT_ADAPT.Clear()
        Me.DsTheriaque_Posologie1.FPOCOSU_FPOSO_COMMENT_SURVEIL.Clear()
        Me.DsTheriaque_Posologie1.FPOCOAU_FPOSO_COMMENT_AUTRE.Clear()

        Me.DsTheriaque_Posologie1.IPOCOD_INFPO_COMMENT_DUREE.Clear()
        Me.DsTheriaque_Posologie1.IPOCOFQ_INFPO_COMMENT_FREQ.Clear()
        Me.DsTheriaque_Posologie1.IPOCOTE_INFPO_COMMENT_TERRAIN.Clear()
        Me.DsTheriaque_Posologie1.IPO_INFOPOSO.Clear()
        Me.DsTheriaque_Posologie1.FPOTE_FPOSO_TERRAIN.Clear()
        Me.DsTheriaque_Posologie1.FPOVO_FPOSO_VOIE.Clear()
        Me.DsTheriaque_Posologie1.FPOSP_POSO_SPE.Clear()
        Me.DsTheriaque_Posologie1.FPOCH_POSOCHOIX.Clear()
        Me.DsTheriaque_Posologie1.FPOPR_FPOSO_PROD.Clear()
        Me.DsTheriaque_Posologie1.FPOSAC_POSO_SUBACT.Clear()
        Me.DsTheriaque_Posologie1.FPOCCH_FPOSO_CLCH.Clear()
        Me.DsTheriaque_Posologie1.FPOCPH_FPOSO_CLPH.Clear()
        Me.DsTheriaque_Posologie1.FPO_FICHEPOSO.Clear()
        Me.DsTheriaque_Posologie1.FPOAFS_POSO_AFSSAPS.Clear()

        GC9.DataSource = Nothing
    End Sub

    ''' <summary>
    ''' Proçédure: Duplication des données à partir d'une autre fiche
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    ''' 

    Public Overrides Sub Dupliquer()

        If Not Tab_TA1 And CodE <> InvalideControl And CodE <> Nothing Then LoadTab_1()
        If Not Tab_TA2 And CodE <> InvalideControl And CodE <> Nothing Then LoadTab_2()
        If Not Tab_TA3 And CodE <> InvalideControl And CodE <> Nothing Then LoadTab_3()
        If Not Tab_TA4 And CodE <> InvalideControl And CodE <> Nothing Then LoadTab_4()

        Dim dtCom1 As New DataTable
        Dim dtCom2 As New DataTable

        'dtCom1 = cn.MySelect("SELECT * FROM THERIAQUE.IPOCOFQ_INFPO_COMMENT_FREQ WHERE IPOCOFQ_IPO_CODE_FK_PK = " & CodE)
        'dtCom2 = cn.MySelect("SELECT DISTINCT IPOCOFQ_CDF_COFQ_CODE_FK_PK FROM THERIAQUE.IPOCOFQ_INFPO_COMMENT_FREQ WHERE IPOCOFQ_IPO_CODE_FK_PK = " & CodE)
        'If dtCom1.Rows.Count <> dtCom2.Rows.Count Then bValidateCommentaireFreq = False


        'dtCom1 = cn.MySelect("SELECT * FROM THERIAQUE.IPOCOD_INFPO_COMMENT_DUREE WHERE IPOCOD_IPO_CODE_FK_PK = " & CodE)
        'dtCom2 = cn.MySelect("SELECT DISTINCT IPOCOD_CDF_COD_CODE_FK_PK FROM THERIAQUE.IPOCOD_INFPO_COMMENT_DUREE WHERE IPOCOD_IPO_CODE_FK_PK = " & CodE)
        'If dtCom1.Rows.Count <> dtCom2.Rows.Count Then bValidateCommentaireDuree = False


        'Sauvegarde des données à dupliquer


        'Onglet entités
        Dim dt1 As New DataTable
        dt1 = DsTheriaque_Posologie1.FPOCPH_FPOSO_CLPH.Copy

        Dim dt2 As New DataTable
        dt2 = DsTheriaque_Posologie1.FPOCCH_FPOSO_CLCH.Copy

        Dim dt3 As New DataTable
        dt3 = DsTheriaque_Posologie1.FPOSAC_POSO_SUBACT.Copy

        Dim dt4 As New DataTable
        dt4 = DsTheriaque_Posologie1.FPOPR_FPOSO_PROD.Copy

        Dim dt5 As New DataTable
        dt5 = DsTheriaque_Posologie1.FPOCH_POSOCHOIX.Copy

        Dim dt6 As New DataTable
        dt6 = DsTheriaque_Posologie1.FPOSP_POSO_SPE.Copy

        'Onglet Voie
        Dim dt7 As New DataTable
        dt7 = DsTheriaque_Posologie1.FPOVO_FPOSO_VOIE.Copy

        Dim dt8 As New DataTable
        dt8 = DsTheriaque_Posologie1.FPOTE_FPOSO_TERRAIN.Copy

        Dim dt11 As New DataTable
        dt11 = DsTheriaque_Posologie1.FPOCOUT_FPOSO_COMMENTUTILTH.Copy


        'Onglet 3
        Dim dt20 As New DataTable
        dt20 = DsTheriaque_Posologie1.IPO_INFOPOSO.Copy



        Dim dt21 As New DataTable
        dt21 = DsTheriaque_Posologie1.IPOCOTE_INFPO_COMMENT_TERRAIN.Copy

        'Dim dt22 As New DataTable
        'dt22 = DsTheriaque_Posologie1.IPO_INFOPOSO.Copy

        Dim dt23 As New DataTable
        dt23 = DsTheriaque_Posologie1.IPOCOFQ_INFPO_COMMENT_FREQ.Copy

        Dim dt24 As New DataTable
        dt24 = DsTheriaque_Posologie1.IPOCOD_INFPO_COMMENT_DUREE.Copy

        'Onglet 4
        Dim dt25 As New DataTable
        dt25 = DsTheriaque_Posologie1.FPOCOAD_FPOSO_COMMENT_ADAPT.Copy

        Dim dt26 As New DataTable
        dt26 = DsTheriaque_Posologie1.FPOCOSU_FPOSO_COMMENT_SURVEIL.Copy

        Dim dt27 As New DataTable
        dt27 = DsTheriaque_Posologie1.FPOCOAU_FPOSO_COMMENT_AUTRE.Copy

        Dim sText As String = MemoEdit1.Text

        Dim dt28 As New DataTable
        dt28 = DsTheriaque_Posologie1.IPOJ_INFOPOSO_JOURNALIERE.Copy


        'Onglet 5
        Dim dt29 As New DataTable
        dt29 = DsTheriaque_Posologie1.FPOAFS_POSO_AFSSAPS.Copy

        Dim dt30 As New DataTable
        dt30 = DsTheriaque_Posologie1.IPODOSE_INFOPOSO.Copy

        'Vider les contrôles
        EmptyDataTable()

        'Construction de la nouvelle fiche avec les données de la fiche de base
        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        SetCode_MAx(MasterTable, txtCode)
        CodE = InvalideControl

        If dt3.Rows.Count > 0 Then dt3.Rows(0)("FPOSAC_FPO_CODE_FK_PK") = Me.txtCode.Text

        'Pour les relations Master-Detail
        For iCount As Integer = 0 To dt20.Rows.Count - 1
            dt20.Rows(iCount)("IPO_FPO_CODE_FK_PK") = Me.txtCode.Text
        Next

        For iCount As Integer = 0 To dt21.Rows.Count - 1
            dt21.Rows(iCount)("IPOCOTE_IPO_CODE_FK_PK") = Me.txtCode.Text
        Next

        For iCount As Integer = 0 To dt23.Rows.Count - 1
            dt23.Rows(iCount)("IPOCOFQ_IPO_CODE_FK_PK") = Me.txtCode.Text
        Next

        For iCount As Integer = 0 To dt24.Rows.Count - 1
            dt24.Rows(iCount)("IPOCOD_IPO_CODE_FK_PK") = Me.txtCode.Text
        Next

        For iCount As Integer = 0 To dt28.Rows.Count - 1
            dt28.Rows(iCount)("IPOJ_FPO_CODE_FK_PK") = Me.txtCode.Text
        Next

        For iCount As Integer = 0 To dt30.Rows.Count - 1
            dt30.Rows(iCount)("IPODOSE_FPO_CODE_FK_PK") = Me.txtCode.Text
        Next

        Dim drTemp As DataRow
        For iCount As Integer = 0 To dt1.Rows.Count - 1
            drTemp = DsTheriaque_Posologie1.Tables("FPOCPH_FPOSO_CLPH").NewRow()
            drTemp.ItemArray = dt1.Rows(iCount).ItemArray
            DsTheriaque_Posologie1.Tables("FPOCPH_FPOSO_CLPH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt2.Rows.Count - 1
            drTemp = DsTheriaque_Posologie1.Tables("FPOCCH_FPOSO_CLCH").NewRow()
            drTemp.ItemArray = dt2.Rows(iCount).ItemArray
            DsTheriaque_Posologie1.Tables("FPOCCH_FPOSO_CLCH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt3.Rows.Count - 1
            drTemp = DsTheriaque_Posologie1.Tables("FPOSAC_POSO_SUBACT").NewRow()
            drTemp.ItemArray = dt3.Rows(iCount).ItemArray
            DsTheriaque_Posologie1.Tables("FPOSAC_POSO_SUBACT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt4.Rows.Count - 1
            drTemp = DsTheriaque_Posologie1.Tables("FPOPR_FPOSO_PROD").NewRow()
            drTemp.ItemArray = dt4.Rows(iCount).ItemArray
            DsTheriaque_Posologie1.Tables("FPOPR_FPOSO_PROD").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt5.Rows.Count - 1
            drTemp = DsTheriaque_Posologie1.Tables("FPOCH_POSOCHOIX").NewRow()
            drTemp.ItemArray = dt5.Rows(iCount).ItemArray
            DsTheriaque_Posologie1.Tables("FPOCH_POSOCHOIX").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt6.Rows.Count - 1
            drTemp = DsTheriaque_Posologie1.Tables("FPOSP_POSO_SPE").NewRow()
            drTemp.ItemArray = dt6.Rows(iCount).ItemArray
            DsTheriaque_Posologie1.Tables("FPOSP_POSO_SPE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt7.Rows.Count - 1

            Try
                If (dt7.Rows(iCount).ItemArray IsNot System.DBNull.Value) Then
                    drTemp = DsTheriaque_Posologie1.Tables("FPOVO_FPOSO_VOIE").NewRow()
                    drTemp.ItemArray = dt7.Rows(iCount).ItemArray
                    DsTheriaque_Posologie1.Tables("FPOVO_FPOSO_VOIE").Rows.Add(drTemp)
                End If
            Catch ex As Exception

            End Try
           
        Next

        For iCount As Integer = 0 To dt8.Rows.Count - 1
            drTemp = DsTheriaque_Posologie1.Tables("FPOTE_FPOSO_TERRAIN").NewRow()
            drTemp.ItemArray = dt8.Rows(iCount).ItemArray
            DsTheriaque_Posologie1.Tables("FPOTE_FPOSO_TERRAIN").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt11.Rows.Count - 1
            drTemp = DsTheriaque_Posologie1.Tables("FPOCOUT_FPOSO_COMMENTUTILTH").NewRow()
            drTemp.ItemArray = dt11.Rows(iCount).ItemArray
            DsTheriaque_Posologie1.Tables("FPOCOUT_FPOSO_COMMENTUTILTH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt20.Rows.Count - 1
            drTemp = DsTheriaque_Posologie1.Tables("IPO_INFOPOSO").NewRow()
            drTemp.ItemArray = dt20.Rows(iCount).ItemArray
            drTemp("IPO_DATECR") = DateTime.Now
            drTemp("IPO_DATEMJ") = DateTime.Now
            DsTheriaque_Posologie1.Tables("IPO_INFOPOSO").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt21.Rows.Count - 1
            drTemp = DsTheriaque_Posologie1.Tables("IPOCOTE_INFPO_COMMENT_TERRAIN").NewRow()
            drTemp.ItemArray = dt21.Rows(iCount).ItemArray
            DsTheriaque_Posologie1.Tables("IPOCOTE_INFPO_COMMENT_TERRAIN").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt23.Rows.Count - 1
            drTemp = DsTheriaque_Posologie1.Tables("IPOCOFQ_INFPO_COMMENT_FREQ").NewRow()
            drTemp.ItemArray = dt23.Rows(iCount).ItemArray
            DsTheriaque_Posologie1.Tables("IPOCOFQ_INFPO_COMMENT_FREQ").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt24.Rows.Count - 1
            drTemp = DsTheriaque_Posologie1.Tables("IPOCOD_INFPO_COMMENT_DUREE").NewRow()
            drTemp.ItemArray = dt24.Rows(iCount).ItemArray
            DsTheriaque_Posologie1.Tables("IPOCOD_INFPO_COMMENT_DUREE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt25.Rows.Count - 1
            drTemp = DsTheriaque_Posologie1.Tables("FPOCOAD_FPOSO_COMMENT_ADAPT").NewRow()
            drTemp.ItemArray = dt25.Rows(iCount).ItemArray
            DsTheriaque_Posologie1.Tables("FPOCOAD_FPOSO_COMMENT_ADAPT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt26.Rows.Count - 1
            drTemp = DsTheriaque_Posologie1.Tables("FPOCOSU_FPOSO_COMMENT_SURVEIL").NewRow()
            drTemp.ItemArray = dt26.Rows(iCount).ItemArray
            DsTheriaque_Posologie1.Tables("FPOCOSU_FPOSO_COMMENT_SURVEIL").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt27.Rows.Count - 1
            drTemp = DsTheriaque_Posologie1.Tables("FPOCOAU_FPOSO_COMMENT_AUTRE").NewRow()
            drTemp.ItemArray = dt27.Rows(iCount).ItemArray
            DsTheriaque_Posologie1.Tables("FPOCOAU_FPOSO_COMMENT_AUTRE").Rows.Add(drTemp)
        Next

        'For iCount As Integer = 0 To dt28.Rows.Count - 1
        '    drTemp = DsTheriaque_Posologie1.Tables("IPOJ_INFOPOSO_JOURNALIERE").NewRow()
        '    drTemp.ItemArray = dt28.Rows(iCount).ItemArray
        '    DsTheriaque_Posologie1.Tables("IPOJ_INFOPOSO_JOURNALIERE").Rows.Add(drTemp)
        'Next

        For iCount As Integer = 0 To dt29.Rows.Count - 1
            drTemp = DsTheriaque_Posologie1.Tables("FPOAFS_POSO_AFSSAPS").NewRow()
            drTemp.ItemArray = dt29.Rows(iCount).ItemArray
            DsTheriaque_Posologie1.Tables("FPOAFS_POSO_AFSSAPS").Rows.Add(drTemp)
        Next

        'For iCount As Integer = 0 To dt30.Rows.Count - 1
        '    drTemp = DsTheriaque_Posologie1.Tables("IPODOSE_INFOPOSO").NewRow()
        '    drTemp.ItemArray = dt30.Rows(iCount).ItemArray
        '    DsTheriaque_Posologie1.Tables("IPODOSE_INFOPOSO").Rows.Add(drTemp)
        'Next

        MemoEdit1.Text = sText

        ModifierCode()
        bModeDuplication = True
        MyBase.Dupliquer()
        XtraTabControl1.SelectedTabPageIndex = 0
    End Sub

    ''' <summary>
    ''' Proçédure: Modifier code Master de la fiche
    ''' </summary>
    ''' 
    Private Sub ModifierCode()
        'GV1
        For iCount As Integer = 0 To GV1.RowCount - 1
            GV1.SetRowCellValue(iCount, colFPOCPH_FPO_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV2
        For iCount As Integer = 0 To GV2.RowCount - 1
            GV2.SetRowCellValue(iCount, colFPOCCH_FPO_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV3
        For iCount As Integer = 0 To GV3.RowCount - 1
            GV3.SetRowCellValue(iCount, colFPOSAC_FPO_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV4
        For iCount As Integer = 0 To GV4.RowCount - 1
            GV4.SetRowCellValue(iCount, colFPOPR_FPO_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV5
        For iCount As Integer = 0 To GV5.RowCount - 1
            GV5.SetRowCellValue(iCount, colFPOCH_FPO_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV6
        For iCount As Integer = 0 To GV6.RowCount - 1
            GV6.SetRowCellValue(iCount, colFPOSP_FPO_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV7
        For iCount As Integer = 0 To GV7.RowCount - 1
            GV7.SetRowCellValue(iCount, colFPOVO_FPO_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV8
        For iCount As Integer = 0 To GV8.RowCount - 1
            GV8.SetRowCellValue(iCount, colFPOTE_FPO_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV11
        For iCount As Integer = 0 To GV11.RowCount - 1
            GV11.SetRowCellValue(iCount, colFPOCOUT_FPO_CODE_FK_PK, Me.txtCode.Text)
        Next
        'AdvBandedGridView1
        'For iCount As Integer = 0 To AdvBandedGridView1.RowCount - 1
        '    AdvBandedGridView1.SetRowCellValue(iCount, colIPO_FPO_CODE_FK_PK, Me.txtCode.Text)
        'Next
        'GV21
        'For iCount As Integer = 0 To GV21.RowCount - 1
        '    GV21.SetRowCellValue(iCount, colIPOCOTE_IPO_CODE_FK_PK, Me.txtCode.Text)
        'Next
        'GV22
        For iCount As Integer = 0 To GV22.RowCount - 1
            GV22.SetRowCellValue(iCount, BandedGridColumn1, Me.txtCode.Text)
        Next
        'GV23
        'For iCount As Integer = 0 To GV23.RowCount - 1
        '    GV23.SetRowCellValue(iCount, colIPOCOFQ_IPO_CODE_FK_PK, Me.txtCode.Text)
        'Next
        'GV24
        'For iCount As Integer = 0 To GV24.RowCount - 1
        '    GV24.SetRowCellValue(iCount, colIPOCOD_IPO_CODE_FK_PK, Me.txtCode.Text)
        'Next
        'GV25
        For iCount As Integer = 0 To GV25.RowCount - 1
            GV25.SetRowCellValue(iCount, colFPOCOAD_FPO_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV26
        For iCount As Integer = 0 To GV26.RowCount - 1
            GV26.SetRowCellValue(iCount, colFPOCOSU_FPO_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV27
        For iCount As Integer = 0 To GV27.RowCount - 1
            GV27.SetRowCellValue(iCount, colFPOCOAU_FPO_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV28
        For iCount As Integer = 0 To GV28.RowCount - 1
            GV28.SetRowCellValue(iCount, colIPOJ_FPO_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV29
        For iCount As Integer = 0 To GV29.RowCount - 1
            GV29.SetRowCellValue(iCount, colFPOAFS_FPO_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV30
        For iCount As Integer = 0 To GV30.RowCount - 1
            GV30.SetRowCellValue(iCount, colIPODOSE_FPO_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV30
        For iCount As Integer = 0 To GV31.RowCount - 1
            GV31.SetRowCellValue(iCount, colIPODUREE_FPO_CODE_PK_FK, Me.txtCode.Text)
        Next

    End Sub

#End Region

#Region " InitNewRow   "

    Private Sub GV1_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV1.InitNewRow
        GV1.SetFocusedRowCellValue(colFPOCPH_FPO_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        GV2.SetFocusedRowCellValue(colFPOCCH_FPO_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV3_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV3.InitNewRow
        GV3.SetFocusedRowCellValue(colFPOSAC_FPO_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV4_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV4.InitNewRow
        GV4.SetFocusedRowCellValue(colFPOPR_FPO_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV5_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV5.InitNewRow
        GV5.SetFocusedRowCellValue(colFPOCH_FPO_CODE_FK_PK, txtCode.Text)
        GV5.SetFocusedRowCellValue(colFPOCH_NUMORD, Code_MAx(GV5, colFPOCH_NUMORD))
    End Sub

    Private Sub GV6_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV6.InitNewRow
        GV6.SetFocusedRowCellValue(colFPOSP_FPO_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV7_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV7.InitNewRow
        GV7.SetFocusedRowCellValue(colFPOVO_FPO_CODE_FK_PK, txtCode.Text)
        GV7.SetFocusedRowCellValue(colFPOVO_NUMORD, Code_MAx(GV7, colFPOVO_NUMORD))
    End Sub

    Private Sub GV8_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV8.InitNewRow
        GV8.SetFocusedRowCellValue(colFPOTE_FPO_CODE_FK_PK, txtCode.Text)
        If Code_MAx(GV8, colFPOTE_GRP_CODE_PK) = 1 Then
            GV8.SetFocusedRowCellValue(colFPOTE_GRP_CODE_PK, 1)
        Else
            GV8.SetFocusedRowCellValue(colFPOTE_GRP_CODE_PK, Code_MAx(GV8, colFPOTE_GRP_CODE_PK) - 1)
        End If
        GV8.SetFocusedRowCellValue(colFPOTE_NUMORD, Code_MAx(GV8, colFPOTE_NUMORD))
    End Sub

    Private Sub AdvBandedGridView1_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)
        If txtCode.Text = "" Then Exit Sub
        AdvBandedGridView1.SetFocusedRowCellValue(colIPO_FPO_CODE_FK_PK1, txtCode.Text)
        AdvBandedGridView1.SetFocusedRowCellValue(colIPO_FPO_CODE_FK_PK, txtCode.Text)
        AdvBandedGridView1.SetFocusedRowCellValue(colIPO_NUM_SEQ_PK, Code_MAx(AdvBandedGridView1, colIPO_NUM_SEQ_PK))
        AdvBandedGridView1.SetFocusedRowCellValue(colIPO_NUM_ORD1, Code_MAx(AdvBandedGridView1, colIPO_NUM_ORD1))
        AdvBandedGridView1.SetFocusedRowCellValue(colIPO_DATECR1, Now.Date)
        AdvBandedGridView1.SetFocusedRowCellValue(colIPO_FREQMAX1, 0)
        AdvBandedGridView1.SetFocusedRowCellValue(colIPO_CDF_FREQMAX_CODE_FK1, "0")
    End Sub

    Private Sub GV21_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV21.InitNewRow
        GV21.SetFocusedRowCellValue(colIPOCOTE_NUM_ORD_PK, Code_MAx(GV21, colIPOCOTE_NUM_ORD_PK))
    End Sub

    Private Sub GV23_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV23.InitNewRow
        GV23.SetFocusedRowCellValue(colIPOCOFQ_NUM_ORD_PK, Code_MAx(GV23, colIPOCOFQ_NUM_ORD_PK))
    End Sub

    Private Sub GV24_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV24.InitNewRow
        GV24.SetFocusedRowCellValue(colIPOCOD_NUM_ORD_PK, Code_MAx(GV24, colIPOCOD_NUM_ORD_PK))
    End Sub

    Private Sub GV25_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV25.InitNewRow
        GV25.SetFocusedRowCellValue(colFPOCOAD_FPO_CODE_FK_PK, txtCode.Text)
        GV25.SetFocusedRowCellValue(colFPOCOAD_NUM_ORD_PK, Code_MAx(GV25, colFPOCOAD_NUM_ORD_PK))
    End Sub

    Private Sub GV26_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV26.InitNewRow
        GV26.SetFocusedRowCellValue(colFPOCOSU_FPO_CODE_FK_PK, txtCode.Text)
        GV26.SetFocusedRowCellValue(colFPOCOSU_NUM_ORD_PK, Code_MAx(GV26, colFPOCOSU_NUM_ORD_PK))
    End Sub

    Private Sub GV27_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV27.InitNewRow
        GV27.SetFocusedRowCellValue(colFPOCOAU_FPO_CODE_FK_PK, txtCode.Text)
        GV27.SetFocusedRowCellValue(colFPOCOAU_NUM_ORD_PK, Code_MAx(GV27, colFPOCOAU_NUM_ORD_PK))
    End Sub

    Private Sub GV28_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV28.InitNewRow
        GV28.SetFocusedRowCellValue(colIPOJ_FPO_CODE_FK_PK, txtCode.Text)
        GV28.SetFocusedRowCellValue(colIPOJ_NUM_SEQ_PK, Code_MAx(GV28, colIPOJ_NUM_SEQ_PK))
        GV28.SetFocusedRowCellValue(colIPOJ_NUM_ORD, Code_MAx(GV28, colIPOJ_NUM_ORD))
    End Sub

    Private Sub GV30_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV30.InitNewRow
        GV30.SetFocusedRowCellValue(colIPODOSE_FPO_CODE_FK_PK, txtCode.Text)
        GV30.SetFocusedRowCellValue(colIPODOSE_NUM_SEQ_PK, Code_MAx(GV30, colIPOJ_NUM_SEQ_PK))
        GV30.SetFocusedRowCellValue(colIPODOSE_NUM_ORD, Code_MAx(GV30, colIPOJ_NUM_ORD))
    End Sub

    Private Sub GV12_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV12.InitNewRow
        GV12.SetFocusedRowCellValue(colFPOBIB_FPO_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV10_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV10.InitNewRow
        GV10.SetFocusedRowCellValue(colFPOUT_FPO_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV11_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV11.InitNewRow
        GV11.SetFocusedRowCellValue(colFPOCOUT_FPO_CODE_FK_PK, txtCode.Text)
        GV11.SetFocusedRowCellValue(colFPOCOUT_NUM_ORD, Code_MAx(GV11, colFPOCOUT_NUM_ORD))
    End Sub

    Private Sub GV12_RowCountChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV12.RowCountChanged
        If sender.RowCount >= 1 Then
            sender.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
            sender.GridControl.EmbeddedNavigator.Buttons.Append.Enabled = False
        Else
            sender.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            sender.GridControl.EmbeddedNavigator.Buttons.Append.Enabled = True
        End If
    End Sub

    Private Sub GV29_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV29.InitNewRow
        GV29.SetFocusedRowCellValue(colFPOAFS_FPO_CODE_FK_PK, txtCode.Text)
    End Sub

#End Region

#Region " Load Data    "

    Private Sub InitDataSource()
        GC1.DataSource = DsTheriaque_Posologie1
        GC1.DataMember = FPOCPH_FPOSO_CLPH

        GC2.DataSource = DsTheriaque_Posologie1
        GC2.DataMember = FPOCCH_FPOSO_CLCH

        GC3.DataSource = DsTheriaque_Posologie1
        'GC3.DataMember = FPOSAC_POSO_SUBACT

        GC4.DataSource = DsTheriaque_Posologie1
        GC4.DataMember = FPOPR_FPOSO_PROD

        GC5.DataSource = DsTheriaque_Posologie1
        GC5.DataMember = FPOCH_POSOCHOIX

        GC6.DataSource = DsTheriaque_Posologie1
        GC6.DataMember = FPOSP_POSO_SPE

        GC7.DataSource = DsTheriaque_Posologie1
        GC7.DataMember = FPOVO_FPOSO_VOIE

        GC8.DataSource = DsTheriaque_Posologie1
        GC8.DataMember = FPOTE_FPOSO_TERRAIN

        GC10.DataSource = DsTheriaque_Posologie1
        GC10.DataMember = FPOUT_FPOSO_UTILTH

        GC11.DataSource = DsTheriaque_Posologie1
        GC11.DataMember = FPOCOUT_FPOSO_COMMENTUTILTH


        GC20.DataSource = DsTheriaque_Posologie1
        GC20.DataMember = IPO_INFOPOSO

        GC21.DataSource = DsTheriaque_Posologie1
        GC21.DataMember = "IPO_INFOPOSO.FK1_IPOCOTE"

        GC22.DataSource = DsTheriaque_Posologie1
        GC22.DataMember = IPO_INFOPOSO

        GC23.DataSource = DsTheriaque_Posologie1
        GC23.DataMember = "IPO_INFOPOSO.FK1_IPOCOFQ"

        GC24.DataSource = DsTheriaque_Posologie1
        GC24.DataMember = "IPO_INFOPOSO.FK1_IPOCOD"

        GC25.DataSource = DsTheriaque_Posologie1
        GC25.DataMember = FPOCOAD_FPOSO_COMMENT_ADAPT

        GC26.DataSource = DsTheriaque_Posologie1
        GC26.DataMember = FPOCOSU_FPOSO_COMMENT_SURVEIL

        GC27.DataSource = DsTheriaque_Posologie1
        GC27.DataMember = FPOCOAU_FPOSO_COMMENT_AUTRE

        GC12.DataSource = DsTheriaque_Posologie1
        GC12.DataMember = FPOBIB_REFERENCE_BIBLIO

        GC28.DataSource = DsTheriaque_Posologie1
        GC28.DataMember = IPOJ_INFOPOSO_JOURNALIERE

        GC29.DataSource = DsTheriaque_Posologie1
        GC29.DataMember = FPOAFS_POSO_AFSSAPS

        GC30.DataSource = DsTheriaque_Posologie1
        GC30.DataMember = IPODOSE_INFOPOSO

        GC31.DataSource = DsTheriaque_Posologie1
        GC31.DataMember = IPODUREE_INFOPOSO

    End Sub

    Public Overrides Sub InitData()
        MyBase.InitData()
        OnLoading = True
        Declinaison_Global = True
        MasterDataSet = Me.DsTheriaque_Posologie1
        MasterTable = FPO_FICHEPOSO
        CodE = InvalideControl
        AddHandler GC28.EmbeddedNavigator.ButtonClick, AddressOf CalcRow
        AddHandler GC30.EmbeddedNavigator.ButtonClick, AddressOf CalcDoseMinMax
        AddHandler GC31.EmbeddedNavigator.ButtonClick, AddressOf CalcDureeMinMax
        'Déclinaison classe CPH
        Dim List1 As New System.Collections.Generic.List(Of StructGVTable)
        List1.Add(New StructGVTable("GC1", eDeclinaison.CPH, colFPOCPH_CPH_CODE_FK_PK2))
        List1.Add(New StructGVTable("GC2", eDeclinaison.CCH, colFPOCCH_CCH_CODE_FK_PK2))
        List1.Add(New StructGVTable("GC3", eDeclinaison.SAC, colFPOSAC_SAC_CODE_FK_PK2))
        List1.Add(New StructGVTable("GC6", eDeclinaison.SP, colFPOSP_SP_CODE_FK_PK2))
        Dim DecCPH As New ClsDeclinaison(eDeclinaison.CPH, List1)
        InitLkup(Me.rpCPH, CPH_CLASSEPHARMTHER, strSSQL_CPH_CLASSEPHARMTHER_NIVEAU, True, , , , , , DecCPH)

        'Déclinaison classe CCH
        Dim List2 As New System.Collections.Generic.List(Of StructGVTable)
        List2.Add(New StructGVTable("GC1", eDeclinaison.CPH, colFPOCPH_CPH_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC2", eDeclinaison.CCH, colFPOCCH_CCH_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC3", eDeclinaison.SAC, colFPOSAC_SAC_CODE_FK_PK2))
        List2.Add(New StructGVTable("GC6", eDeclinaison.SP, colFPOSP_SP_CODE_FK_PK2))
        '2do List2.Add(New StructGVTable("GC4", eDeclinaison.SAU, colFEISAU_SAU_CODE_FK_PK2))
        Dim DecCCH As New ClsDeclinaison(eDeclinaison.CCH, List2)
        InitLkup(Me.rpCCH, CCH_CLASSECHIMIQUE, strSSQL_CCH_CLASSECHIMIQUE_NIVEAU, True, , , , , , DecCCH)

        'Déclinaison SUBAC
        Dim List3 As New System.Collections.Generic.List(Of StructGVTable)
        List3.Add(New StructGVTable("GC3", eDeclinaison.SAC, colFPOSAC_SAC_CODE_FK_PK2))
        List3.Add(New StructGVTable("GC6", eDeclinaison.SP, colFPOSP_SP_CODE_FK_PK2))
        Dim DecSUBAC As New ClsDeclinaison(eDeclinaison.SAC, List3)
        InitLkup(Me.rpSAC, SAC_SUBACTIVE, strSSQL_SAC_SUBACTIVE, True, , , , , , DecSUBAC)

        '2do 'Déclinaison SAU
        'Dim List4 As New System.Collections.Generic.List(Of StructGVTable)
        'List4.Add(New StructGVTable("GC4", eDeclinaison.SAU, colFEISAU_SAU_CODE_FK_PK2))
        'List4.Add(New StructGVTable("GC6", eDeclinaison.SP, colFEISP_SP_CODE_FK_PK2))
        'Dim DecSAU As New ClsDeclinaison(eDeclinaison.SAU, List4)
        'InitLkup(Me.lkup_FEISAU, FEISAU_EFFINDSUBAU, strSSQL_SAU_SUBAUXILIAIRE, True, , , , , , DecSAU)

        'Déclinaison PRODUIT
        Dim List5 As New System.Collections.Generic.List(Of StructGVTable)
        List5.Add(New StructGVTable("GC4", eDeclinaison.PR, colFPOPR_PR_CODE_FK_PK2))
        List5.Add(New StructGVTable("GC6", eDeclinaison.SP, colFPOSP_SP_CODE_FK_PK2))
        Dim DecPR As New ClsDeclinaison(eDeclinaison.PR, List5)
        InitLkup(Me.rpPR, PR_PRODUIT, strSSQL_PR_PRODUIT, True, , , , , , DecPR)

        InitLkup(Me.rpSP, SP_SPECIALITE, strSSQL_SP_SPECIALITE, True)
        InitLkup(Me.rpCHOIX, CH_CHOIX, strSSQL_CH_CHOIX, True)
        InitDataSource()
        FirstFocus = txtCode
        If _Code <> Nothing Then
            Load_On(Me)
            Open_Fiche(_Code)
            ModeFiche = eMode.Consultation
            UpdateStateBouton()
            Initcomponent()
            Load_Off(Me)
        End If
        OnLoading = False
    End Sub

    Private Sub Open_Fiche(ByVal CodE1 As Integer)
        OnLoading = True
        CodE = _Code
        EmptyDataTable()
        Me.FpO_TA.FillByCode(Me.DsTheriaque_Posologie1.FPO_FICHEPOSO, CodE1)

        'Onglet Entités
        Me.FpocpH_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOCPH_FPOSO_CLPH, CodE1)
        Me.FpoccH_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOCCH_FPOSO_CLCH, CodE1)
        Me.FpocH_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOCH_POSOCHOIX, CodE1)
        Me.FposaC_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOSAC_POSO_SUBACT, CodE1)
        Me.FpopR_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOPR_FPOSO_PROD, CodE1)
        Me.FposP_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOSP_POSO_SPE, CodE1)
        CodeWhere = GetCodesSPForInCondition()
        Me.IPODUREE.FillByCode(Me.DsTheriaque_Posologie1.IPODUREE_INFOPOSO, CodeWhere)

        Tab_TA1 = False
        Tab_TA2 = False
        Tab_TA3 = False
        Tab_TA4 = False
        Tab_TA5 = False
        Tab_TA6 = False
        OnLoading = False
    End Sub

    Private Sub LoadTab_1()
        Load_On(Me)
        OnLoading = True
        If Not Tab_lkup1 Then
            'InitLkup(Me.rpVoie, CDF_CODIF, strSSQL_CDF_CODIF("18", " and CDF_CODE_PK  <> '62' "), True)
            InitLkup(Me.rpTE, CDF_CODIF, strSSQL_CDF_CODIF("PT"), True)
            InitLkup(Me.rpNatureIndic, CDF_CODIF, strSSQL_CDF_CODIF("NN"), True)
            InitLkup(Me.rpNatureIndic2, CDF_CODIF, strSSQL_CDF_CODIF("NN"), True)
            InitLkup(Me.rp_CommentaireNatIndic, CDF_CODIF, strSSQL_CDF_CODIF("PC", " and substring(CDF_CODE_PK, 1, 1) IN('T', 'Z')"), True)

            Tab_lkup1 = True
        End If
        If Not Tab_TA1 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.FpovO_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOVO_FPOSO_VOIE, CodE)
            Me.FpotE_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOTE_FPOSO_TERRAIN, CodE)
            Me.FpouT_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOUT_FPOSO_UTILTH, CodE)
            Me.FpocouT_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOCOUT_FPOSO_COMMENTUTILTH, CodE)
            Me.FpoafS_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOAFS_POSO_AFSSAPS, CodE)
            Tab_TA1 = True
        End If
        If GetCodeFromCollection(GetCodeFromGV(GV6, colFPOSP_SP_CODE_FK_PK2)) <> "" Then
            Dim strTempSQL As String = "select Distinct FIN_CDF_NAIN_CODE_FK_PK, FIN_CODE_SQ_PK, 0 as check1 , CDF_NOM "
            strTempSQL &= " from THERIAQUE.FINSP_INDSPE ,THERIAQUE.FIN_FICHEINDIC, THERIAQUE.CDF_CODIF"
            strTempSQL &= " where FINSP_SP_CODE_FK_PK  in  "
            strTempSQL &= GetCodeFromCollection(GetCodeFromGV(GV6, colFPOSP_SP_CODE_FK_PK2))
            strTempSQL &= " And FIN_CODE_SQ_PK = FINSP_FIN_CODE_FK_PK"
            strTempSQL &= " and CDF_NUMERO_PK = 'NV' "
            strTempSQL &= " AND CDF_CODE_PK = FIN_CDF_NVIN_CODE_FK_PK "
            GC9.DataSource = cn.MySelect(strTempSQL)
        End If

        'Mise à jour du lookup selon la liste des SP
        If Me.rpVoie.Name <> "" Then
            Dim str_SSQL_Temp As String = ""
            Dim strList As String = ""
            Dim col As New Collection
            col = GetCodeFromGV(GV6, colFPOSP_SP_CODE_FK_PK2)
            strList = GetCodeFromCollection(col)
            str_SSQL_Temp &= " and CDF_CODE_PK  <> '62'"
            If strList <> "" Then
                str_SSQL_Temp &= " and CDF_CODE_PK in"
                str_SSQL_Temp &= " ("
                str_SSQL_Temp &= " SELECT SPVO_CDF_VO_CODE_FK_PK FROM THERIAQUE.SPVO_SPECIALITE_VOIE "
                str_SSQL_Temp &= " WHERE SPVO_SP_CODE_FK_PK in " & strList
                str_SSQL_Temp &= " GROUP BY SPVO_CDF_VO_CODE_FK_PK "
                str_SSQL_Temp &= " HAVING COUNT(SPVO_CDF_VO_CODE_FK_PK)  = " & col.Count & ")"
            End If
            InitLkup(Me.rpVoie, FPOVO_FPOSO_VOIE, strSSQL_CDF_CODIF("18", str_SSQL_Temp), True)
            If Me.GV7.RowCount > 1 Then
                For iCount1 As Integer = 0 To Me.GV7.RowCount
                    If GV7.GetRowCellDisplayText(iCount1, colFPOVO_CDF_VO_CODE_FK_PK2) = "" And GV7.GetRowCellDisplayText(iCount1, "FPOVO_FPO_CODE_FK_PK") <> "" Then
                        GV7.DeleteRow(iCount1)
                        iCount1 = iCount1 - 1
                    End If
                Next
            End If
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub

    Private Sub LoadTab_2()
        Load_On(Me)
        OnLoading = True
        bLoadPoso = True
        If Not Tab_lkup2 Then
            InitLkup(Me.rpNatureDose, CDF_CODIF, strSSQL_CDF_CODIF("PN"), True)
            InitLkup(Me.rpCommenterrain, CDF_CODIF, strSSQL_CDF_CODIF("PC", " and substring(CDF_CODE_PK, 1, 1) IN('B', 'G')"), True)
            InitLkup(Me.rpUnitePrise, CDF_CODIF, strSSQL_CDF_CODIF("PP"), True)
            InitLkup(Me.rpCodeFrequence, CDF_CODIF, strSSQL_CDF_CODIF("PF"), True)
            InitLkup(Me.rpCodeFrequence2, CDF_CODIF, strSSQL_CDF_CODIF("PF"), True)
            InitLkup(Me.rpCommentaireFrequence, CDF_CODIF, strSSQL_CDF_CODIF("PC", " and substring(CDF_CODE_PK, 1, 1) IN('I', 'Z')"), True)
            InitLkup(Me.rpCommentaireDuree, CDF_CODIF, strSSQL_CDF_CODIF("PC", " and substring(CDF_CODE_PK, 1, 1) IN('D', 'Z')"), True)
            InitLkup(Me.rpUnitedeTemps, CDF_CODIF, strSSQL_CDF_CODIF("PU"), True)
            InitLkup(Me.rpUnitedeTemps2, CDF_CODIF, strSSQL_CDF_CODIF("PU"), True)
            InitLkup(Me.rpUniteIntervalledePrise1, CDF_CODIF, strSSQL_CDF_CODIF("PU"), True)
            InitLkup(Me.rpUniteIntervalledePrise2, CDF_CODIF, strSSQL_CDF_CODIF("PU"), True)
            Tab_lkup2 = True
        End If
        If Not Tab_TA2 And CodE <> InvalideControl And CodE <> Nothing Then

            Me.IpO_TA.FillByCode(Me.DsTheriaque_Posologie1.IPO_INFOPOSO, CodE)


            'Me.DsTheriaque_Posologie1.IPO_INFOPOSO(0)("IPO_DUREEMAX").ToString()
            'For i As Integer = 0 To AdvBandedGridView1.RowCount - 1
            '    Dim s As String = AdvBandedGridView1.GetDataRow(i)("IPO_NUM_SEQ_PK")
            '    AdvBandedGridView1.SetRowCellValue(0, "IPO_DUREEMAX", "4")
            'Next

            Me.IpocotE_TA.FillByCode(Me.DsTheriaque_Posologie1.IPOCOTE_INFPO_COMMENT_TERRAIN, CodE)

            Me.IpocoD_TA.FillByCode(Me.DsTheriaque_Posologie1.IPOCOD_INFPO_COMMENT_DUREE, CodE)

            Me.IpocofQ_TA.FillByCode(Me.DsTheriaque_Posologie1.IPOCOFQ_INFPO_COMMENT_FREQ, CodE)
            Tab_TA2 = True
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub

    Private Sub LoadTab_3()
        Load_On(Me)
        OnLoading = True
        If Not Tab_lkup3 Then
            InitLkup(Me.rpComentAdap, CDF_CODIF, strSSQL_CDF_CODIF("PC", " and substring(CDF_CODE_PK, 1, 1) IN('A', 'Z')"), True)
            InitLkup(Me.rpComentSurv, CDF_CODIF, strSSQL_CDF_CODIF("PC", "and substring(CDF_CODE_PK,1,1) = 'S' "), True)
            InitLkup(Me.rpCommentAutre, CDF_CODIF, strSSQL_CDF_CODIF("PC", "and substring(CDF_CODE_PK,1,1) not in ('A','B','D','G','I','S','T') "), True)
            Tab_lkup3 = True
        End If
        If Not Tab_TA3 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.FpocoaD_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOCOAD_FPOSO_COMMENT_ADAPT, CodE)
            Me.FpocosU_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOCOSU_FPOSO_COMMENT_SURVEIL, CodE)
            Me.FpocoaU_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOCOAU_FPOSO_COMMENT_AUTRE, CodE)
            Me.FpobiB_ta.FillByCode(Me.DsTheriaque_Posologie1.FPOBIB_REFERENCE_BIBLIO, CodE)
            Tab_TA3 = True
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub

    Private Sub LoadTab_4()
        Load_On(Me)
        OnLoading = True
        If CodE <> InvalideControl And CodE <> Nothing Then
            Dim strSSQL_SP_REF As String
            strSSQL_SP_REF = " SELECT SP_CODE_SQ_PK as code, SP_NOM as libelle FROM THERIAQUE.FPOSP_POSO_SPE, THERIAQUE.SP_SPECIALITE"
            strSSQL_SP_REF &= " WHERE FPOSP_FPO_CODE_FK_PK = " & CodE
            strSSQL_SP_REF &= " AND SP_CODE_SQ_PK = FPOSP_SP_CODE_FK_PK"
            InitLkup(Me.rp_FPOAFS_SP, FPOAFS_POSO_AFSSAPS, strSSQL_SP_REF, True)
            For iCount As Integer = 0 To GV29.RowCount
                If GV29.GetRowCellDisplayText(iCount, "FPOAFS_SP_CODE_FK_PK") = "" And GV29.GetRowCellDisplayText(iCount, "FPOAFS_FPO_CODE_FK_PK") <> "" Then
                    GV29.DeleteRow(iCount)
                    iCount = iCount - 1
                End If
            Next
        End If

        If Not Tab_lkup4 Then
            InitLkup(Me.rpNAPO, CDF_CODIF, strSSQL_CDF_CODIF("PN"), True)

            Dim sCONT As String = strSSQL_CDF_CODIF("04") & " UNION SELECT 0, 'Non Applicable', 0 FROM THERIAQUE.CDF_CODIF"
            InitLkup(rpCONT, CDF_CODIF, sCONT, True)
            Dim sContUnit As String = strSSQL_CDF_CODIF("21") & " UNION SELECT 0, 'Non Applicable', 0 FROM THERIAQUE.CDF_CODIF"
            InitLkup(rpContUnit, CDF_CODIF, sContUnit, True)

            Dim sDONANTH As String = strSSQL_CDF_CODIF("PA") & " UNION SELECT '0', 'Non Applicable', '0' FROM THERIAQUE.CDF_CODIF"
            InitLkup(Me.rpDONANTH, CDF_CODIF, sDONANTH, True)
            'InitLkup(Me.rpNATUCD_CDF_CODE_FK2, CDF_CODIF, strSSQL_IN_CDF_CODIF_DUAL("04", "06"), True)
            Dim sNatureUCD As String = strSSQL_IN_CDF_CODIF("04", "06") & " UNION SELECT 0, 'Non Applicable', 0 FROM THERIAQUE.CDF_CODIF"
            InitLkup(Me.rpNATUCD_CDF_CODE_FK2, CDF_CODIF, sNatureUCD, True)
            InitLkup(Me.rp_FPOAFS, FPOAFS_POSO_AFSSAPS, strSSQL_CDF_CODIF("25"), True)
            Tab_lkup4 = True
        End If
        If Not Tab_TA4 And CodE <> InvalideControl And CodE <> Nothing Then
            CodeWhere = GetCodesSPForInCondition()
            Me.IpoJ_TA.FillByCode(Me.DsTheriaque_Posologie1.IPOJ_INFOPOSO_JOURNALIERE, CodE)
            Me.FpoafS_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOAFS_POSO_AFSSAPS, CodE)
            If GV28.GetRowCellValue(0, colIPOJ_NATUCD_CDF_NUM_FK) IsNot DBNull.Value Then
                If GV28.GetRowCellValue(0, colIPOJ_NATUCD_CDF_NUM_FK) <> Nothing Then
                    'InitLkup(Me.rpNATUCD_CDF_CODE_FK2, CDF_CODIF, strSSQL_IN_CDF_CODIF("04", "06") & " AND CDF_NUMERO_PK =" & cn.SQLText(GV28.GetRowCellValue(0, colIPOJ_NATUCD_CDF_NUM_FK)), True)
                End If
            End If
            'Me.FpocoaU_TA.FillByCode(Me.DsTheriaque_Posologie1.FPOCOAU_FPOSO_COMMENT_AUTRE, CodE)
            Tab_TA4 = True
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub

    Private Sub LoadTab_5()
        Load_On(Me)
        OnLoading = True
        If Not Tab_lkup5 Then
            Dim sNatureUCD As String = strSSQL_IN_CDF_CODIF("04", "06") & " UNION SELECT 0, 'Non Applicable', 0 FROM THERIAQUE.CDF_CODIF"
            'Dim sNatureUCD As String = "Select (CDF_CODE_PK + '_' + CDF_NUMERO_PK) as code, CDF_NOM as libelle, CDF_CODE_PK as val1, CDF_NUMERO_PK as val2  From THERIAQUE.CDF_CODIF where CDF_NUMERO_PK in ('04','06') "
            'sNatureUCD &= "UNION SELECT '0', 'Non Applicable', 0, 0 FROM THERIAQUE.CDF_CODIF"
            InitLkup(Me.rpDoseNATUCD_CDF_CODE_FK2, CDF_CODIF, sNatureUCD, True)
            Dim sCONT As String = strSSQL_CDF_CODIF("04") & " UNION SELECT 0, 'Non Applicable', 0 FROM THERIAQUE.CDF_CODIF"
            InitLkup(rpCONT2, CDF_CODIF, sCONT, True)
            Dim sContUnit As String = strSSQL_CDF_CODIF("21") & " UNION SELECT 0, 'Non Applicable', 0 FROM THERIAQUE.CDF_CODIF"
            InitLkup(rpContUnit2, CDF_CODIF, sContUnit, True)

           

            Tab_lkup5 = True
        End If
        Dim sDonnAnth As String = strSSQL_CDF_CODIF("PA")
        InitLkup(rpDonneeAnth, CDF_CODIF, sDonnAnth, True)
        If Not Tab_TA5 And CodE <> InvalideControl And CodE <> Nothing Then
            CodeWhere = GetCodesSPForInCondition()
            
            Me.IpodosE_TA.FillByCode(Me.DsTheriaque_Posologie1.IPODOSE_INFOPOSO, CodeWhere)
            Tab_TA5 = True
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPageIndex = 1 Then
            LoadTab_1()
            Exit Sub
        End If
        If XtraTabControl1.SelectedTabPageIndex = 2 Then
            LoadTab_2()
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
            LoadTab_5()
            Exit Sub
        End If
    End Sub


#End Region

#Region " Validate Row "

    Private Sub GV8_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV8.ValidateRow
        Dim intCode As Integer = 0
        intCode = GV8.GetFocusedRowCellValue(colFPOTE_GRP_CODE_PK)
        Dim intCom As Integer = 0
        For inti As Integer = 0 To GV8.RowCount - 1
            If GV8.GetRowCellValue(inti, colFPOTE_GRP_CODE_PK) = intCode And GV8.GetRowCellValue(inti, colFPOTE_CDF_TEPO_CODE_FK_PK) <> GV8.GetFocusedRowCellValue(colFPOTE_CDF_TEPO_CODE_FK_PK) Then
                intCom += 1
            End If
        Next
        If intCom > 0 Then Exit Sub
        If GV8.GetFocusedRowCellValue(colFPOTE_CDF_TEPO_CODE_FK_PK)(0) <> "O" Then
            e.Valid = False
            e.ErrorText = StrPO_TERRAIN
        End If
    End Sub

    Private Sub AdvBandedGridView1_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs)
        AdvBandedGridView1.SetFocusedRowCellValue(colIPO_DATEMJ1, Now.Date)
    End Sub

    Private Sub GV22_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV22.ValidateRow
        If GV22.GetFocusedRowCellValue(colIPO_FREQMIN2) IsNot Nothing And GV22.GetFocusedRowCellValue(colIPO_CDF_FREQMIN_CODE_FK2) Is Nothing Then
            e.Valid = False
            e.ErrorText = "Le code Fréquence est obligatoire !"
            Exit Sub
        End If
        If GV22.GetFocusedRowCellValue(colIPO_FREQMAX2) IsNot DBNull.Value Then
            If GV22.GetFocusedRowCellValue(colIPO_FREQMAX2) = "." Then
                If GV22.GetFocusedRowCellValue(colIPO_CDF_FREQMAX_CODE_FK2)(0) <> "Z" Then
                    e.Valid = False
                    e.ErrorText = StrcolIPO_CDF_FREQMAX_CODE_FK2
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub AdvBandedGridView1_ValidateRow1(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles AdvBandedGridView1.ValidateRow
        If AdvBandedGridView1.GetFocusedRowCellValue(colIPO_DUREEMIN1) IsNot Nothing Then
            If AdvBandedGridView1.GetFocusedRowCellValue(colIPO_CDF_UTMIN_CODE_FK1) Is Nothing Then
                e.Valid = False
                e.ErrorText = "La valeur unité temps minimale est obligatoire "
            End If
        End If
        If AdvBandedGridView1.GetFocusedRowCellValue(colIPO_DUREEMAX1) IsNot Nothing Then
            If AdvBandedGridView1.GetFocusedRowCellValue(colIPO_CDF_UTMAX_CODE_FK1) Is Nothing Then
                e.Valid = False
                e.ErrorText = "La valeur unité temps maximale est obligatoire "
            End If
        End If
        AdvBandedGridView1.SetFocusedRowCellValue(colIPO_DATEMJ1, DateTime.Now)


    End Sub

#End Region

    'onglet Posologie 
    Public Sub CalcRow(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        'On Error Resume Next
        Dim dtP As New DataTable
        Dim codeMax As String
        Dim DA As String
        Dim dr As DataRow

        'Dim VContenance0 As String = ""
        Dim nbContenanceV0 As Double = 0
        Dim nbContenanceVI As Double = 0


        If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.Custom Then
            If Process_Message(strAlgoPoso, MessageBoxButtons.YesNo, MessageBoxIcon.Question).BtResult = MsgBoxResult.Yes Then

                If (bLoadPoso) Then

                    For i As Integer = 0 To GV28.Columns.Count - 1

                        dtP.Columns.Add(GV28.Columns(i).Name)

                    Next

                    Dim dtUCD As DataTable
                    For inti As Integer = 0 To GV28.RowCount - 1
                        GV28.DeleteRow(0)

                    Next

                    Dim len As Integer = GV28.RowCount
                    Dim ii As Integer = 0
                    While (ii < len)
                        GV28.DeleteRow(0)
                        ii += 1
                    End While

                    Dim Sec As Integer = ClsPosologie.MaxSequence("IPOJ_NUM_SEQ_PK", "IPOJ_INFOPOSO_JOURNALIERE")
                    Dim maxSec As Integer
                    Dim cmp As Integer = 0


                    For inti As Integer = 0 To GV6.RowCount - 1 ' Spécialité

                        If GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2) IsNot Nothing Then
                            If (cmp = 0) Then
                                maxSec = ClsPosologie.GetExistSeq(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2), "IPOJ_NUM_SEQ_PK", "IPOJ_INFOPOSO_JOURNALIERE", "IPOJ_SP_CODE_FK_PK")
                                If (maxSec > -1) Then
                                    cmp = 1
                                End If
                            End If
                        End If


                        For intj As Integer = 0 To AdvBandedGridView1.RowCount - 1 ' Phase
                            If GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2) IsNot Nothing Then 'And ClsPosologie.IsCommercialized(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)) Then

                                If Not IsMonographie(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)) Then
                                    If ClsSP.GetCIPUCD(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)) <> "" Then
                                        If AdvBandedGridView1.GetRowCellValue(intj, colIPO_NUM_SEQ_PK) IsNot Nothing Then
                                            Dim dtPre As New DataTable
                                            dtPre = ClsSP.GetPR_DT(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))
                                            If (dtPre.Rows.Count > 0) Then
                                                ProgressBar.Visible = True
                                                If (ProgressBar.Value >= ProgressBar.Minimum And ProgressBar.Value < ProgressBar.Maximum) Then
                                                    ProgressBar.Value += 1
                                                End If
                                                ProgressBar.Maximum = GV6.RowCount * AdvBandedGridView1.RowCount * dtPre.Rows.Count
                                                Dim PoSo As New ClsPosologie
                                                If PoSo.TestCoherence_UP_Contenant(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)) = True And PoSo.TestCoherence_UDT_UCD(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)) = True Then
                                                    If PoSo.TestCoherence_Contenant(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)) Then

                                                        If (maxSec = -1) Then
                                                            If (cmp = 0) Then
                                                                maxSec = Sec + 1
                                                                cmp = 1
                                                            End If
                                                        Else
                                                            If (cmp = 1) Then
                                                                maxSec += 1
                                                            End If
                                                        End If


                                                        GV28.AddNewRow()
                                                        dr = dtP.NewRow()
                                                        GV28.SetFocusedRowCellValue(colIPOJ_FPO_CODE_FK_PK, txtCode.Text)
                                                        dr("colIPOJ_FPO_CODE_FK_PK") = txtCode.Text
                                                        GV28.SetFocusedRowCellValue(colIPOJ_NUM_SEQ_PK, AdvBandedGridView1.GetRowCellValue(intj, colIPO_NUM_SEQ_PK)) 'maxSec
                                                        dr("colIPOJ_NUM_SEQ_PK") = AdvBandedGridView1.GetRowCellValue(intj, colIPO_NUM_SEQ_PK) 'maxSec 'AdvBandedGridView1.GetRowCellValue(intj, colIPO_NUM_SEQ_PK)
                                                        GV28.SetFocusedRowCellValue(colIPOJ_CDF_NAPO_CODE_FK, AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_NAPO_CODE_FK1))
                                                        dr("colIPOJ_CDF_NAPO_CODE_FK") = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_NAPO_CODE_FK1)
                                                        codeMax = Code_MAx(GV28, colIPOJ_NUM_ORD)
                                                        GV28.SetFocusedRowCellValue(colIPOJ_NUM_ORD, codeMax)
                                                        dr("colIPOJ_NUM_ORD") = codeMax
                                                        GV28.SetFocusedRowCellValue(colIPOJ_SP_CODE_FK_PK, GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))
                                                        dr("colIPOJ_SP_CODE_FK_PK") = GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)
                                                        GV28.SetFocusedRowCellValue(colIPOJ_SP_CIPUCD, ClsSP.GetCIPUCD(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)))
                                                        dr("colIPOJ_SP_CIPUCD") = ClsSP.GetCIPUCD(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))
                                                        PoSo.UnitePrise_PP = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UNPO_CODE_FK1)
                                                        'On prend juste le premier élement (CIP) code PRE
                                                        PoSo.PRE_CODE = dtPre.Rows(0)("PRE_CODE_PK")
                                                        If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMIN1) IsNot DBNull.Value Then
                                                            Dim a As Array = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMIN1).ToString().Split("/")
                                                            If (a.Length = 2) Then
                                                                PoSo.DoseMin = a(0) / a(1)
                                                            Else
                                                                If (Not a(0).ToString().Equals(".")) Then
                                                                    PoSo.DoseMin = a(0)
                                                                Else
                                                                    PoSo.DoseMin = Nothing
                                                                End If

                                                            End If
                                                        Else
                                                            If (PoSo.DoseMin IsNot Nothing) Then
                                                                PoSo.DoseMin = Nothing
                                                            End If
                                                        End If


                                                        If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMAX1) IsNot DBNull.Value Then

                                                            Dim a As Array = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMAX1).ToString().Split("/")
                                                            If (a.Length = 2) Then
                                                                PoSo.DoseMax = a(0) / a(1)
                                                            Else


                                                                If (Not a(0).ToString().Equals(".")) Then

                                                                    PoSo.DoseMax = a(0)
                                                                Else

                                                                    PoSo.DoseMax = Nothing
                                                                End If

                                                            End If

                                                        Else
                                                            If (PoSo.DoseMax IsNot Nothing) Then
                                                                PoSo.DoseMax = Nothing
                                                            End If
                                                        End If


                                                        If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMIN1) IsNot DBNull.Value Then PoSo.DureeTraitementMin = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMIN1)
                                                        If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMAX1) IsNot DBNull.Value Then PoSo.DureeTraitementMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMAX1)
                                                        If AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMAX_CODE_FK1) IsNot DBNull.Value Then PoSo.UniteDureeTraitementMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMAX_CODE_FK1)
                                                        If AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMIN_CODE_FK1) IsNot DBNull.Value Then PoSo.UniteDureeTraitementMin = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMIN_CODE_FK1)

                                                        If AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMIN1) IsNot DBNull.Value Then
                                                            If AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMIN1).ToString().Trim() <> "." And Not String.IsNullOrEmpty(AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMIN1)) Then
                                                                PoSo.FrequenceMin = AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMIN1)
                                                            Else
                                                                PoSo.FrequenceMin = Nothing
                                                            End If
                                                        Else
                                                            PoSo.FrequenceMin = Nothing
                                                        End If
                                                        If AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMAX1) IsNot DBNull.Value Then
                                                            If AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMAX1).ToString().Trim() <> "." And Not String.IsNullOrEmpty(AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMAX1)) Then
                                                                If (IsNumeric(AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMAX1).ToString().Trim())) Then

                                                                    PoSo.FrequenceMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMAX1)

                                                                End If
                                                            Else
                                                                PoSo.FrequenceMax = Nothing
                                                            End If
                                                        Else
                                                            PoSo.FrequenceMax = Nothing
                                                        End If

                                                        If AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_FREQMAX_CODE_FK2) IsNot DBNull.Value Then PoSo.UniteFrequenceMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_FREQMAX_CODE_FK2)
                                                        If AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_FREQMIN_CODE_FK2) IsNot DBNull.Value Then PoSo.UniteFrequenceMin = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_FREQMIN_CODE_FK2)

                                                        'Données anthropométriques
                                                        DA = ClsPosologie.Get_DonneeAnthropometrique(AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UNPO_CODE_FK1))
                                                        GV28.SetFocusedRowCellValue(colIPOJ_DONANTH_CDF_CODE_FK, DA)
                                                        dr("colIPOJ_DONANTH_CDF_CODE_FK") = DA
                                                        GV28.SetFocusedRowCellValue(colIPOJ_CONT, 0)
                                                        dr("colIPOJ_CONT") = 0
                                                        GV28.SetFocusedRowCellValue(colIPOJ_VOL_CONT, 0)
                                                        dr("colIPOJ_VOL_CONT") = 0
                                                        GV28.SetFocusedRowCellValue(colIPOJ_VOL_CONT_UNIT, 0)
                                                        dr("colIPOJ_VOL_CONT_UNIT") = 0

                                                    Else
                                                        If (maxSec = -1) Then
                                                            If (cmp = 0) Then
                                                                maxSec = Sec + 1
                                                                cmp = 1
                                                            End If
                                                        Else
                                                            If (cmp = 1) Then
                                                                maxSec += 1
                                                            End If
                                                        End If
                                                        GV28.AddNewRow()
                                                        dr = dtP.NewRow()
                                                        GV28.SetFocusedRowCellValue(colIPOJ_FPO_CODE_FK_PK, txtCode.Text)
                                                        dr("colIPOJ_FPO_CODE_FK_PK") = txtCode.Text
                                                        GV28.SetFocusedRowCellValue(colIPOJ_NUM_SEQ_PK, AdvBandedGridView1.GetRowCellValue(intj, colIPO_NUM_SEQ_PK)) 'maxSec
                                                        dr("colIPOJ_NUM_SEQ_PK") = AdvBandedGridView1.GetRowCellValue(intj, colIPO_NUM_SEQ_PK) 'maxSec
                                                        GV28.SetFocusedRowCellValue(colIPOJ_CDF_NAPO_CODE_FK, AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_NAPO_CODE_FK1))
                                                        dr("colIPOJ_CDF_NAPO_CODE_FK") = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_NAPO_CODE_FK1)
                                                        codeMax = Code_MAx(GV28, colIPOJ_NUM_ORD)
                                                        GV28.SetFocusedRowCellValue(colIPOJ_NUM_ORD, codeMax)
                                                        dr("colIPOJ_NUM_ORD") = codeMax
                                                        GV28.SetFocusedRowCellValue(colIPOJ_SP_CODE_FK_PK, GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))
                                                        dr("colIPOJ_SP_CODE_FK_PK") = GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)
                                                        GV28.SetFocusedRowCellValue(colIPOJ_SP_CIPUCD, ClsSP.GetCIPUCD(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)))
                                                        dr("colIPOJ_SP_CIPUCD") = ClsSP.GetCIPUCD(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))
                                                        PoSo.UnitePrise_PP = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UNPO_CODE_FK1)
                                                        'GV28.SetFocusedRowCellValue(colIPOJ_DTMIN, "NON APPLICABLE")
                                                        'GV28.SetFocusedRowCellValue(colIPOJ_DJMAX, "NON APPLICABLE")
                                                        'GV28.SetFocusedRowCellValue(colIPOJ_DTMAX, "NON APPLICABLE")
                                                        'GV28.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_CODE_FK2, "NON APPLICABLE")
                                                        'GV28.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_CODE_FK, "NON APPLICABLE")
                                                        'GV28.SetFocusedRowCellValue(colIPOJ_DJMIN, "NON APPLICABLE")
                                                        'GV28.SetFocusedRowCellValue(colIPOJ_DONANTH_CDF_CODE_FK, "NON APPLICABLE")

                                                        '______________________
                                                        PoSo.PRE_CODE = dtPre.Rows(0)("PRE_CODE_PK")
                                                        If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMIN1) IsNot DBNull.Value Then
                                                            Dim a As Array = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMIN1).ToString().Split("/")
                                                            If (a.Length = 2) Then
                                                                PoSo.DoseMin = a(0) / a(1)
                                                            Else
                                                                If (Not a(0).ToString().Equals(".")) Then
                                                                    PoSo.DoseMin = a(0)
                                                                Else
                                                                    PoSo.DoseMin = Nothing
                                                                End If

                                                            End If
                                                        Else
                                                            If (PoSo.DoseMin IsNot Nothing) Then
                                                                PoSo.DoseMin = Nothing
                                                            End If
                                                        End If


                                                        If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMAX1) IsNot DBNull.Value Then

                                                            Dim a As Array = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMAX1).ToString().Split("/")
                                                            If (a.Length = 2) Then
                                                                PoSo.DoseMax = a(0) / a(1)
                                                            Else


                                                                If (Not a(0).ToString().Equals(".")) Then

                                                                    PoSo.DoseMax = a(0)
                                                                Else

                                                                    PoSo.DoseMax = Nothing
                                                                End If

                                                            End If

                                                        Else
                                                            If (PoSo.DoseMax IsNot Nothing) Then
                                                                PoSo.DoseMax = Nothing
                                                            End If
                                                        End If


                                                        If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMIN1) IsNot DBNull.Value Then PoSo.DureeTraitementMin = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMIN1)
                                                        If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMAX1) IsNot DBNull.Value Then PoSo.DureeTraitementMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMAX1)
                                                        If AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMAX_CODE_FK1) IsNot DBNull.Value Then PoSo.UniteDureeTraitementMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMAX_CODE_FK1)
                                                        If AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMIN_CODE_FK1) IsNot DBNull.Value Then PoSo.UniteDureeTraitementMin = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMIN_CODE_FK1)

                                                        If AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMIN1) IsNot DBNull.Value Then
                                                            If AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMIN1).ToString().Trim() <> "." And Not String.IsNullOrEmpty(AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMIN1)) Then
                                                                PoSo.FrequenceMin = AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMIN1)
                                                            Else
                                                                PoSo.FrequenceMin = Nothing
                                                            End If
                                                        Else
                                                            PoSo.FrequenceMin = Nothing
                                                        End If
                                                        If AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMAX1) IsNot DBNull.Value Then
                                                            If AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMAX1).ToString().Trim() <> "." And Not String.IsNullOrEmpty(AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMAX1)) Then
                                                                If (IsNumeric(AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMAX1).ToString().Trim())) Then

                                                                    PoSo.FrequenceMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMAX1)

                                                                End If
                                                            Else
                                                                PoSo.FrequenceMax = Nothing
                                                            End If
                                                        Else
                                                            PoSo.FrequenceMax = Nothing
                                                        End If

                                                        If AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_FREQMAX_CODE_FK2) IsNot DBNull.Value Then PoSo.UniteFrequenceMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_FREQMAX_CODE_FK2)
                                                        If AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_FREQMIN_CODE_FK2) IsNot DBNull.Value Then PoSo.UniteFrequenceMin = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_FREQMIN_CODE_FK2)


                                                        '______________________
                                                        GV28.SetFocusedRowCellValue(colApplicable, 0)
                                                        dr("colApplicable") = 0
                                                        'Exit For

                                                    End If
                                                Else
                                                    If (maxSec = -1) Then
                                                        If (cmp = 0) Then
                                                            maxSec = Sec + 1
                                                            cmp = 1
                                                        End If
                                                    Else
                                                        If (cmp = 1) Then
                                                            maxSec += 1
                                                        End If
                                                    End If
                                                    GV28.AddNewRow()
                                                    dr = dtP.NewRow()
                                                    GV28.SetFocusedRowCellValue(colIPOJ_FPO_CODE_FK_PK, txtCode.Text)
                                                    dr("colIPOJ_FPO_CODE_FK_PK") = txtCode.Text
                                                    GV28.SetFocusedRowCellValue(colIPOJ_NUM_SEQ_PK, AdvBandedGridView1.GetRowCellValue(intj, colIPO_NUM_SEQ_PK)) 'maxSec
                                                    dr("colIPOJ_NUM_SEQ_PK") = AdvBandedGridView1.GetRowCellValue(intj, colIPO_NUM_SEQ_PK) 'maxSec
                                                    GV28.SetFocusedRowCellValue(colIPOJ_CDF_NAPO_CODE_FK, AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_NAPO_CODE_FK1))
                                                    dr("colIPOJ_CDF_NAPO_CODE_FK") = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_NAPO_CODE_FK1)
                                                    codeMax = Code_MAx(GV28, colIPOJ_NUM_ORD)
                                                    GV28.SetFocusedRowCellValue(colIPOJ_NUM_ORD, codeMax)
                                                    dr("colIPOJ_NUM_ORD") = codeMax
                                                    GV28.SetFocusedRowCellValue(colIPOJ_SP_CODE_FK_PK, GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))
                                                    dr("colIPOJ_SP_CODE_FK_PK") = GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)
                                                    GV28.SetFocusedRowCellValue(colIPOJ_SP_CIPUCD, ClsSP.GetCIPUCD(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)))

                                                    dr("colIPOJ_SP_CIPUCD") = ClsSP.GetCIPUCD(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))
                                                    'Added
                                                    'Afficher NON APPLICABLE
                                                    GV28.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_CODE_FK, 0)
                                                    dr("colIPOJ_NATUCD_CDF_CODE_FK") = 0
                                                    GV28.SetFocusedRowCellValue(colIPOJ_DONANTH_CDF_CODE_FK, 0)
                                                    dr("colIPOJ_DONANTH_CDF_CODE_FK") = 0

                                                    'GV28.SetFocusedRowCellValue(colIPOJ_DTMIN, "NON APPLICABLE")
                                                    GV28.SetFocusedRowCellValue(colIPOJ_DJMAX, 0)
                                                    dr("colIPOJ_DJMAX") = 0
                                                    'GV28.SetFocusedRowCellValue(colIPOJ_DTMAX, "NON APPLICABLE")
                                                    'GV28.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_CODE_FK2, "NON APPLICABLE")
                                                    GV28.SetFocusedRowCellValue(colIPOJ_DJMIN, 0)
                                                    dr("colIPOJ_DJMIN") = 0
                                                    'GV28.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_CODE_FK, "NON APPLICABLE")
                                                    GV28.SetFocusedRowCellValue(colApplicable, 0)
                                                    dr("colApplicable") = 0
                                                    PoSo.UnitePrise_PP = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UNPO_CODE_FK1)
                                                    '_____________________


                                                    PoSo.PRE_CODE = dtPre.Rows(0)("PRE_CODE_PK")
                                                    If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMIN1) IsNot DBNull.Value Then
                                                        Dim a As Array = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMIN1).ToString().Split("/")
                                                        If (a.Length = 2) Then
                                                            PoSo.DoseMin = a(0) / a(1)
                                                        Else
                                                            If (Not a(0).ToString().Equals(".")) Then
                                                                PoSo.DoseMin = a(0)
                                                            Else
                                                                PoSo.DoseMin = Nothing
                                                            End If

                                                        End If
                                                    Else
                                                        If (PoSo.DoseMin IsNot Nothing) Then
                                                            PoSo.DoseMin = Nothing
                                                        End If
                                                    End If


                                                    If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMAX1) IsNot DBNull.Value Then

                                                        Dim a As Array = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMAX1).ToString().Split("/")
                                                        If (a.Length = 2) Then
                                                            PoSo.DoseMax = a(0) / a(1)
                                                        Else


                                                            If (Not a(0).ToString().Equals(".")) Then

                                                                PoSo.DoseMax = a(0)
                                                            Else

                                                                PoSo.DoseMax = Nothing
                                                            End If

                                                        End If

                                                    Else
                                                        If (PoSo.DoseMax IsNot Nothing) Then
                                                            PoSo.DoseMax = Nothing
                                                        End If
                                                    End If

                                                    ''''''''''
                                                    If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMIN1) IsNot DBNull.Value Then
                                                        If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMIN1).ToString().Trim() <> "." And Not String.IsNullOrEmpty(AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMIN1)) Then
                                                            If (AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMIN1).ToString().Trim()) Then

                                                                PoSo.DureeTraitementMin = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMIN1)

                                                            End If
                                                        Else
                                                            PoSo.DureeTraitementMin = Nothing
                                                        End If
                                                    Else
                                                        PoSo.DureeTraitementMin = Nothing
                                                    End If
                                                    ''''''''''''''



                                                    ''''''''''
                                                    If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMAX1) IsNot DBNull.Value Then
                                                        If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMAX1).ToString().Trim() <> "." And Not String.IsNullOrEmpty(AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMAX1)) Then
                                                            If (AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMAX1).ToString().Trim()) Then

                                                                PoSo.DureeTraitementMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMAX1)

                                                            End If
                                                        Else
                                                            PoSo.DureeTraitementMax = Nothing
                                                        End If
                                                    Else
                                                        PoSo.DureeTraitementMax = Nothing
                                                    End If

                                                    'If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMAX1) IsNot DBNull.Value Then PoSo.DureeTraitementMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMAX1)

                                                    If AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMAX_CODE_FK1) IsNot DBNull.Value Then
                                                        If AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMAX_CODE_FK1).ToString().Trim() <> "." And Not String.IsNullOrEmpty(AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMAX_CODE_FK1)) Then
                                                            If (AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMIN_CODE_FK1).ToString().Trim()) Then

                                                                PoSo.UniteDureeTraitementMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMAX_CODE_FK1)

                                                            End If
                                                        Else
                                                            PoSo.UniteDureeTraitementMax = Nothing
                                                        End If
                                                    Else
                                                        PoSo.UniteDureeTraitementMax = Nothing
                                                    End If

                                                    'If AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMAX_CODE_FK1) IsNot DBNull.Value Then PoSo.UniteDureeTraitementMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMAX_CODE_FK1)

                                                    If AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMIN_CODE_FK1) IsNot DBNull.Value Then
                                                        If AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMIN_CODE_FK1).ToString().Trim() <> "." And Not String.IsNullOrEmpty(AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMIN_CODE_FK1)) Then
                                                            If (AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMIN_CODE_FK1).ToString().Trim()) Then

                                                                PoSo.UniteDureeTraitementMin = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMIN_CODE_FK1)

                                                            End If
                                                        Else
                                                            PoSo.UniteDureeTraitementMin = Nothing
                                                        End If
                                                    Else
                                                        PoSo.UniteDureeTraitementMin = Nothing
                                                    End If

                                                    'If AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMIN_CODE_FK1) IsNot DBNull.Value Then PoSo.UniteDureeTraitementMin = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMIN_CODE_FK1)

                                                    If AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMIN1) IsNot DBNull.Value Then
                                                        If AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMIN1).ToString().Trim() <> "." And Not String.IsNullOrEmpty(AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMIN1)) Then
                                                            PoSo.FrequenceMin = AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMIN1)
                                                        Else
                                                            PoSo.FrequenceMin = Nothing
                                                        End If
                                                    Else
                                                        PoSo.FrequenceMin = Nothing
                                                    End If
                                                    If AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMAX1) IsNot DBNull.Value Then
                                                        If AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMAX1).ToString().Trim() <> "." And Not String.IsNullOrEmpty(AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMAX1)) Then
                                                            If (IsNumeric(AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMAX1).ToString().Trim())) Then

                                                                PoSo.FrequenceMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMAX1)

                                                            End If
                                                        Else
                                                            PoSo.FrequenceMax = Nothing
                                                        End If
                                                    Else
                                                        PoSo.FrequenceMax = Nothing
                                                    End If

                                                    If AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_FREQMAX_CODE_FK2) IsNot DBNull.Value Then PoSo.UniteFrequenceMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_FREQMAX_CODE_FK2)
                                                    If AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_FREQMIN_CODE_FK2) IsNot DBNull.Value Then PoSo.UniteFrequenceMin = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_FREQMIN_CODE_FK2)


                                                    '_____________________
                                                    ' Exit For
                                                End If

                                                PoSo.Execute()

                                                '''''' 2do AdvBandedGridView1.SetFocusedRowCellValue(colNonapplicable, 1)
                                                'JAN 2008 Modified
                                                GV28.SetFocusedRowCellValue(colIPOJ_DJMAX, String.Format("{0:n5}", PoSo.UCD_MAX.Valeur))
                                                dr("colIPOJ_DJMAX") = String.Format("{0:n5}", PoSo.UCD_MAX.Valeur)
                                                GV28.SetFocusedRowCellValue(colIPOJ_DJMIN, String.Format("{0:n5}", PoSo.UCD_MIN.Valeur))
                                                dr("colIPOJ_DJMIN") = String.Format("{0:n5}", PoSo.UCD_MIN.Valeur)
                                                If PoSo._OKMIN Then
                                                    GV28.SetFocusedRowCellValue(colIPOJ_DTMIN, String.Format("{0:n5}", PoSo.DureeTraitementMin))
                                                    dr("colIPOJ_DTMIN") = String.Format("{0:n5}", PoSo.DureeTraitementMin)
                                                Else
                                                    GV28.SetFocusedRowCellValue(colIPOJ_DTMIN, 0)
                                                    dr("colIPOJ_DTMIN") = 0
                                                End If
                                                If PoSo._OKMax Then
                                                    GV28.SetFocusedRowCellValue(colIPOJ_DTMAX, String.Format("{0:n5}", PoSo.DureeTraitementMax))
                                                    dr("colIPOJ_DTMAX") = String.Format("{0:n5}", PoSo.DureeTraitementMax)
                                                Else
                                                    GV28.SetFocusedRowCellValue(colIPOJ_DTMAX, 0)
                                                    dr("colIPOJ_DTMAX") = 0
                                                End If

                                                'dtUCD = cn.MySelect("SELECT IPOJ_NATUCD_CDF_CODE_FK, IPOJ_NATUCD_CDF_NUM_FK FROM THERIAQUE.IPOJ_INFOPOSO_JOURNALIERE WHERE IPOJ_SP_CIPUCD =" & cn.SQLText(ClsSP.GetCIPUCD(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))))
                                                'If dtUCD.Rows.Count > 0 Then
                                                '    GV28.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_CODE_FK, dtUCD.Rows(0)("IPOJ_NATUCD_CDF_CODE_FK"))
                                                '    'InitLkup(Me.rpNATUCD_CDF_CODE_FK2, CDF_CODIF, strSSQL_IN_CDF_CODIF("04", "06") & " AND CDF_NUMERO_PK =" & cn.SQLText(dtUCD.Rows(0)("IPOJ_NATUCD_CDF_NUM_FK")), True)
                                                '    GV28.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_NUM_FK, dtUCD.Rows(0)("IPOJ_NATUCD_CDF_NUM_FK"))
                                                'End If

                                                'Nature UCD 20 JAN 2009
                                                dtUCD = cn.MySelect("SELECT DISTINCT PRE_NATUCD_CDF_CODE_FK, PRE_NATUCD_CDF_NUM_FK FROM THERIAQUE.PRE_PRESENTATION WHERE PRE_SP_CODE_FK = " & cn.SQLText(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)))
                                                If dtUCD.Rows.Count = 1 Then
                                                    GV28.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_CODE_FK, dtUCD.Rows(0)("PRE_NATUCD_CDF_CODE_FK"))
                                                    dr("colIPOJ_NATUCD_CDF_CODE_FK") = dtUCD.Rows(0)("PRE_NATUCD_CDF_CODE_FK")
                                                    'InitLkup(Me.rpNATUCD_CDF_CODE_FK2, CDF_CODIF, strSSQL_IN_CDF_CODIF("04", "06") & " AND CDF_NUMERO_PK =" & cn.SQLText(dtUCD.Rows(0)("IPOJ_NATUCD_CDF_NUM_FK")), True)
                                                    GV28.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_NUM_FK, dtUCD.Rows(0)("PRE_NATUCD_CDF_NUM_FK"))
                                                    dr("colIPOJ_NATUCD_CDF_NUM_FK") = dtUCD.Rows(0)("PRE_NATUCD_CDF_NUM_FK")
                                                Else

                                                    GV28.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_CODE_FK, 0)
                                                    dr("colIPOJ_NATUCD_CDF_CODE_FK") = 0
                                                End If


                                                'Poso MIN
                                                If PoSo._OKMIN Then
                                                    GV28.SetFocusedRowCellValue(colDTMinEnjour, PoSo.DureeTraitementMinEnJour)
                                                    dr("colDTMinEnjour") = PoSo.DureeTraitementMinEnJour
                                                    GV28.SetFocusedRowCellValue(colUCDMin, PoSo.UCD_MIN.Valeur)
                                                    dr("colUCDMin") = PoSo.UCD_MIN.Valeur
                                                    GV28.SetFocusedRowCellValue(colUniteTempsMin, AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMIN_CODE_FK1))
                                                    dr("colUniteTempsMin") = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMIN_CODE_FK1)
                                                End If
                                                'Poso MAX
                                                If PoSo._OKMax Then
                                                    GV28.SetFocusedRowCellValue(colDTMaxEnjour, PoSo.DureeTraitementMaxEnJour)
                                                    dr("colDTMaxEnjour") = PoSo.DureeTraitementMaxEnJour
                                                    GV28.SetFocusedRowCellValue(colUCDMax, PoSo.UCD_MAX.Valeur)
                                                    dr("colUCDMax") = PoSo.UCD_MAX.Valeur
                                                    GV28.SetFocusedRowCellValue(colUniteTempsMax, AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMAX_CODE_FK1))
                                                    dr("colUniteTempsMax") = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMAX_CODE_FK1)
                                                End If

                                                dtP.Rows.Add(dr)
                                                'GV28.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_CODE_FK, "NON APPLICABLE")

                                                'AdvBandedGridView1.SetFocusedRowCellValue(colIPOJ_DJMIN, )
                                                'AdvBandedGridView1.SetFocusedRowCellValue(colIPOJ_DJMAX, )
                                                'AdvBandedGridView1.SetFocusedRowCellValue(colIPOJ_DTMIN, )
                                                'AdvBandedGridView1.SetFocusedRowCellValue(colIPOJ_DTMAX, )
                                                'AdvBandedGridView1.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_CODE_FK, )
                                                'AdvBandedGridView1.SetFocusedRowCellValue(colIPOJ_DONANTH_CDF_CODE_FK, )
                                                'AdvBandedGridView1.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_CODE_FK2, )
                                            End If
                                    End If
                                End If
                            Else ''Inclure les monographies virtuelles T10406
                                If ClsSP.GetCodeVirtuel(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)) <> "" Then
                                    If AdvBandedGridView1.GetRowCellValue(intj, colIPO_NUM_SEQ_PK) IsNot Nothing Then
                                        Dim dtPre As New DataTable
                                        dtPre = ClsSP.GetPRE(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))

                                        If dtPre IsNot Nothing Then
                                            If (dtPre.Rows.Count > 0) Then

                                                ProgressBar.Visible = True
                                                If (ProgressBar.Value >= ProgressBar.Minimum And ProgressBar.Value < ProgressBar.Maximum) Then
                                                    ProgressBar.Value += 1
                                                End If
                                                ProgressBar.Maximum = GV6.RowCount * AdvBandedGridView1.RowCount * dtPre.Rows.Count
                                                Dim codePRE As String
                                                codePRE = dtPre.Rows(0)("PRE_CODE_PK")
                                                If codePRE(0) = "V" Then
                                                    Dim dtContenant As New DataTable
                                                    dtContenant = ClsPRE.GetContenant(codePRE)
                                                    If (dtContenant.Rows.Count > 0) Then
                                                        'Dans le cas d'un seul contenant, garder le même algorithme de calcul pour les autres colonnes
                                                        If dtContenant.Rows.Count = 1 Then
                                                            Dim PoSo As New ClsPosologie
                                                            If (maxSec = -1) Then
                                                                If (cmp = 0) Then
                                                                    maxSec = Sec + 1
                                                                    cmp = 1
                                                                End If
                                                            Else
                                                                If (cmp = 1) Then
                                                                    maxSec += 1
                                                                End If
                                                            End If
                                                            GV28.AddNewRow()
                                                            dr = dtP.NewRow()
                                                            GV28.SetFocusedRowCellValue(colIPOJ_FPO_CODE_FK_PK, txtCode.Text)
                                                            dr("colIPOJ_FPO_CODE_FK_PK") = txtCode.Text
                                                            codeMax = Code_MAx(GV28, colIPOJ_NUM_SEQ_PK)
                                                            GV28.SetFocusedRowCellValue(colIPOJ_NUM_SEQ_PK, AdvBandedGridView1.GetRowCellValue(intj, colIPO_NUM_SEQ_PK)) 'maxSec
                                                            dr("colIPOJ_NUM_SEQ_PK") = AdvBandedGridView1.GetRowCellValue(intj, colIPO_NUM_SEQ_PK) 'maxSec
                                                            GV28.SetFocusedRowCellValue(colIPOJ_CDF_NAPO_CODE_FK, AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_NAPO_CODE_FK1))
                                                            dr("colIPOJ_CDF_NAPO_CODE_FK") = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_NAPO_CODE_FK1)
                                                            codeMax = Code_MAx(GV28, colIPOJ_NUM_ORD)
                                                            GV28.SetFocusedRowCellValue(colIPOJ_NUM_ORD, codeMax)
                                                            dr("colIPOJ_NUM_ORD") = codeMax
                                                            GV28.SetFocusedRowCellValue(colIPOJ_SP_CODE_FK_PK, GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))
                                                            dr("colIPOJ_SP_CODE_FK_PK") = GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)


                                                            If dtPre.Rows(0)("PRE_NATUCD_CDF_NUM_FK") IsNot System.DBNull.Value Then


                                                                If dtPre.Rows(0)("PRE_NATUCD_CDF_NUM_FK") = "04" Then

                                                                    GV28.SetFocusedRowCellValue(colIPOJ_CONT, dtContenant.Rows(0)("PRECONT_CDF_COCDT_CODE_FK"))
                                                                    dr("colIPOJ_CONT") = dtContenant.Rows(0)("PRECONT_CDF_COCDT_CODE_FK")
                                                                    'TODO: MBE  PRECONT_NBCONTENANCE je pense que la colonne  n'est celle qu'il faut utiliser, mais on utilise la colonne PRECONT_VOLCONTENANT
                                                                    GV28.SetFocusedRowCellValue(colIPOJ_VOL_CONT, dtContenant.Rows(0)("PRECONT_NBCONTENANCE"))
                                                                    dr("colIPOJ_VOL_CONT") = dtContenant.Rows(0)("PRECONT_NBCONTENANCE")
                                                                    GV28.SetFocusedRowCellValue(colIPOJ_VOL_CONT_UNIT, dtContenant.Rows(0)("PRECONT_CDF_COCE_CODE_FK"))
                                                                    dr("colIPOJ_VOL_CONT_UNIT") = dtContenant.Rows(0)("PRECONT_CDF_COCE_CODE_FK")
                                                                Else

                                                                    GV28.SetFocusedRowCellValue(colIPOJ_CONT, 0)
                                                                    dr("colIPOJ_CONT") = 0
                                                                    GV28.SetFocusedRowCellValue(colIPOJ_VOL_CONT, 0)
                                                                    dr("colIPOJ_VOL_CONT") = 0
                                                                    GV28.SetFocusedRowCellValue(colIPOJ_VOL_CONT_UNIT, 0)
                                                                    dr("colIPOJ_VOL_CONT_UNIT") = 0

                                                                End If
                                                            Else
                                                                GV28.SetFocusedRowCellValue(colIPOJ_CONT, 0)
                                                                dr("colIPOJ_CONT") = 0
                                                                GV28.SetFocusedRowCellValue(colIPOJ_VOL_CONT, 0)
                                                                dr("colIPOJ_VOL_CONT") = 0
                                                                GV28.SetFocusedRowCellValue(colIPOJ_VOL_CONT_UNIT, 0)
                                                                dr("colIPOJ_VOL_CONT_UNIT") = 0
                                                            End If

                                                            GV28.SetFocusedRowCellValue(colIPOJ_SP_CIPUCD, ClsSP.GetCodeVirtuel(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)))
                                                            dr("colIPOJ_SP_CIPUCD") = ClsSP.GetCodeVirtuel(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))

                                                            PoSo.UnitePrise_PP = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UNPO_CODE_FK1)
                                                            'On prend juste le premier élement (CIP) code PRE
                                                            PoSo.PRE_CODE = codePRE
                                                            'If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMIN1) IsNot DBNull.Value Then
                                                            '    PoSo.DoseMin = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMIN1)

                                                            'End If

                                                            If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMIN1) IsNot DBNull.Value Then
                                                                Dim a As Array = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMIN1).ToString().Split("/")
                                                                If (a.Length = 2) Then
                                                                    PoSo.DoseMin = a(0) / a(1)
                                                                Else
                                                                    If (Not a(0).ToString().Equals(".")) Then
                                                                        PoSo.DoseMin = a(0)
                                                                    Else
                                                                        PoSo.DoseMin = Nothing
                                                                    End If

                                                                End If
                                                                'PoSoDose.DoseMin = dtPosoInfo.Rows(PosoInfoCount)("IPO_DOSEMIN")
                                                            Else
                                                                If PoSo.DoseMin IsNot Nothing Then
                                                                    PoSo.DoseMin = Nothing
                                                                End If
                                                            End If



                                                            'If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMAX1) IsNot DBNull.Value Then
                                                            '    PoSo.DoseMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMAX1)
                                                            'End If


                                                            If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMAX1) IsNot DBNull.Value Then
                                                                Dim a As Array = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMAX1).ToString().Split("/")
                                                                If (a.Length = 2) Then
                                                                    PoSo.DoseMax = a(0) / a(1)
                                                                Else
                                                                    If (Not a(0).ToString().Equals(".")) Then
                                                                        PoSo.DoseMax = a(0)
                                                                    Else
                                                                        PoSo.DoseMax = Nothing
                                                                    End If

                                                                End If
                                                                'PoSoDose.DoseMin = dtPosoInfo.Rows(PosoInfoCount)("IPO_DOSEMIN")
                                                            Else
                                                                If PoSo.DoseMin IsNot Nothing Then
                                                                    PoSo.DoseMin = Nothing
                                                                End If
                                                            End If

                                                            If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMIN1) IsNot DBNull.Value Then PoSo.DureeTraitementMin = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMIN1)
                                                            If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMAX1) IsNot DBNull.Value Then PoSo.DureeTraitementMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMAX1)
                                                            If AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMAX_CODE_FK1) IsNot DBNull.Value Then PoSo.UniteDureeTraitementMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMAX_CODE_FK1)
                                                            If AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMIN_CODE_FK1) IsNot DBNull.Value Then PoSo.UniteDureeTraitementMin = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMIN_CODE_FK1)

                                                            If (AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMIN1) IsNot System.DBNull.Value) Then
                                                                If Not AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMIN1).ToString().Trim().Equals(".") And Not String.IsNullOrEmpty(AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMIN1)) Then
                                                                    PoSo.FrequenceMin = AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMIN1)
                                                                Else
                                                                    PoSo.FrequenceMin = Nothing
                                                                End If
                                                            Else
                                                                PoSo.FrequenceMin = Nothing
                                                            End If

                                                            If (AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMAX1) IsNot System.DBNull.Value) Then
                                                                If Not AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMAX1).ToString().Trim.Equals(".") And Not String.IsNullOrEmpty(AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMAX1)) Then
                                                                    If (IsNumeric(AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMAX1))) Then
                                                                        PoSo.FrequenceMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMAX1)
                                                                    Else
                                                                        PoSo.FrequenceMax = Nothing
                                                                    End If
                                                                Else

                                                                    PoSo.FrequenceMax = Nothing
                                                                End If
                                                            Else
                                                                PoSo.FrequenceMax = Nothing
                                                            End If


                                                            If AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_FREQMAX_CODE_FK2) IsNot DBNull.Value Then PoSo.UniteFrequenceMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_FREQMAX_CODE_FK2)
                                                            If AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_FREQMIN_CODE_FK2) IsNot DBNull.Value Then PoSo.UniteFrequenceMin = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_FREQMIN_CODE_FK2)

                                                            'Données anthropométriques
                                                            DA = ClsPosologie.Get_DonneeAnthropometrique(AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UNPO_CODE_FK1))
                                                            GV28.SetFocusedRowCellValue(colIPOJ_DONANTH_CDF_CODE_FK, DA)
                                                            dr("colIPOJ_DONANTH_CDF_CODE_FK") = DA

                                                            If dtContenant.Rows(0)("PRECONT_NBCONTENANCE") IsNot Nothing Then

                                                                If dtContenant.Rows(0)("PRECONT_NBCONTENANCE") IsNot System.DBNull.Value Then
                                                                    nbContenanceV0 = dtContenant.Rows(0)("PRECONT_NBCONTENANCE")
                                                                End If

                                                            End If

                                                            PoSo.ExecuteMonoVirtuelle(0, nbContenanceV0, nbContenanceV0)

                                                            '''''' 2do AdvBandedGridView1.SetFocusedRowCellValue(colNonapplicable, 1)
                                                            'JAN 2008 Modified
                                                            If (PoSo.UCD_MAX.Valeur >= 0) Then

                                                                GV28.SetFocusedRowCellValue(colIPOJ_DJMAX, String.Format("{0:n5}", PoSo.UCD_MAX.Valeur))
                                                                dr("colIPOJ_DJMAX") = String.Format("{0:n5}", PoSo.UCD_MAX.Valeur)
                                                            Else
                                                                GV28.SetFocusedRowCellValue(colIPOJ_DJMAX, String.Format("{0:n5}", 0))
                                                                dr("colIPOJ_DJMAX") = String.Format("{0:n5}", 0)

                                                            End If

                                                            If (PoSo.UCD_MIN.Valeur >= 0) Then

                                                                GV28.SetFocusedRowCellValue(colIPOJ_DJMIN, String.Format("{0:n5}", PoSo.UCD_MIN.Valeur))
                                                                dr("colIPOJ_DJMIN") = String.Format("{0:n5}", PoSo.UCD_MIN.Valeur)
                                                            Else
                                                                GV28.SetFocusedRowCellValue(colIPOJ_DJMIN, String.Format("{0:n5}", 0))
                                                                dr("colIPOJ_DJMIN") = String.Format("{0:n5}", 0)
                                                            End If

                                                            If PoSo._OKMIN Then
                                                                GV28.SetFocusedRowCellValue(colIPOJ_DTMIN, String.Format("{0:n5}", PoSo.DureeTraitementMin))
                                                                dr("colIPOJ_DTMIN") = String.Format("{0:n5}", PoSo.DureeTraitementMin)
                                                            Else
                                                                GV28.SetFocusedRowCellValue(colIPOJ_DTMIN, 0)
                                                                dr("colIPOJ_DTMIN") = 0
                                                            End If
                                                            If PoSo._OKMax Then
                                                                GV28.SetFocusedRowCellValue(colIPOJ_DTMAX, String.Format("{0:n5}", PoSo.DureeTraitementMax))
                                                                dr("colIPOJ_DTMAX") = String.Format("{0:n5}", PoSo.DureeTraitementMax)
                                                            Else
                                                                GV28.SetFocusedRowCellValue(colIPOJ_DTMAX, 0)
                                                                dr("colIPOJ_DTMAX") = 0
                                                            End If

                                                            'dtUCD = cn.MySelect("SELECT IPOJ_NATUCD_CDF_CODE_FK, IPOJ_NATUCD_CDF_NUM_FK FROM THERIAQUE.IPOJ_INFOPOSO_JOURNALIERE WHERE IPOJ_SP_CIPUCD =" & cn.SQLText(ClsSP.GetCIPUCD(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))))
                                                            'If dtUCD.Rows.Count > 0 Then
                                                            '    GV28.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_CODE_FK, dtUCD.Rows(0)("IPOJ_NATUCD_CDF_CODE_FK"))
                                                            '    'InitLkup(Me.rpNATUCD_CDF_CODE_FK2, CDF_CODIF, strSSQL_IN_CDF_CODIF("04", "06") & " AND CDF_NUMERO_PK =" & cn.SQLText(dtUCD.Rows(0)("IPOJ_NATUCD_CDF_NUM_FK")), True)
                                                            '    GV28.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_NUM_FK, dtUCD.Rows(0)("IPOJ_NATUCD_CDF_NUM_FK"))
                                                            'End If

                                                            'Nature UCD 20 JAN 2009
                                                            dtUCD = cn.MySelect("SELECT DISTINCT PRE_NATUCD_CDF_CODE_FK, PRE_NATUCD_CDF_NUM_FK FROM THERIAQUE.PRE_PRESENTATION WHERE PRE_SP_CODE_FK = " & cn.SQLText(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)))
                                                            If dtUCD.Rows.Count = 1 Then
                                                                GV28.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_CODE_FK, dtUCD.Rows(0)("PRE_NATUCD_CDF_CODE_FK"))
                                                                dr("colIPOJ_NATUCD_CDF_CODE_FK") = dtUCD.Rows(0)("PRE_NATUCD_CDF_CODE_FK")
                                                                'InitLkup(Me.rpNATUCD_CDF_CODE_FK2, CDF_CODIF, strSSQL_IN_CDF_CODIF("04", "06") & " AND CDF_NUMERO_PK =" & cn.SQLText(dtUCD.Rows(0)("IPOJ_NATUCD_CDF_NUM_FK")), True)
                                                                GV28.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_NUM_FK, dtUCD.Rows(0)("PRE_NATUCD_CDF_NUM_FK"))
                                                                dr("colIPOJ_NATUCD_CDF_NUM_FK") = dtUCD.Rows(0)("PRE_NATUCD_CDF_NUM_FK")
                                                            Else
                                                                GV28.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_CODE_FK, "NON APPLICABLE")
                                                                dr("colIPOJ_NATUCD_CDF_CODE_FK") = "NON APPLICABLE"
                                                            End If


                                                            'Poso MIN
                                                            If PoSo._OKMIN Then
                                                                GV28.SetFocusedRowCellValue(colDTMinEnjour, PoSo.DureeTraitementMinEnJour)
                                                                dr("colDTMinEnjour") = PoSo.DureeTraitementMinEnJour
                                                                GV28.SetFocusedRowCellValue(colUCDMin, PoSo.UCD_MIN.Valeur)
                                                                dr("colUCDMin") = PoSo.UCD_MIN.Valeur
                                                                GV28.SetFocusedRowCellValue(colUniteTempsMin, AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMIN_CODE_FK1))
                                                                dr("colUniteTempsMin") = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMIN_CODE_FK1)
                                                            End If
                                                            'Poso MAX
                                                            If PoSo._OKMax Then
                                                                GV28.SetFocusedRowCellValue(colDTMaxEnjour, PoSo.DureeTraitementMaxEnJour)
                                                                dr("colUCDMax") = PoSo.UCD_MAX.Valeur
                                                                GV28.SetFocusedRowCellValue(colUCDMax, PoSo.UCD_MAX.Valeur)
                                                                dr("colUCDMax") = PoSo.UCD_MAX.Valeur
                                                                GV28.SetFocusedRowCellValue(colUniteTempsMax, AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMAX_CODE_FK1))
                                                                dr("colUniteTempsMax") = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMAX_CODE_FK1)
                                                            End If

                                                            dtP.Rows.Add(dr)
                                                        Else 'Dans le cas de plusieurs contenant
                                                            For countContenant As Integer = 0 To dtContenant.Rows.Count - 1
                                                                Dim PoSo As New ClsPosologie

                                                                If (maxSec = -1) Then
                                                                    If (cmp = 0) Then
                                                                        maxSec = Sec + 1
                                                                        cmp = 1
                                                                    End If
                                                                Else
                                                                    If (cmp = 1) Then
                                                                        maxSec += 1
                                                                    End If
                                                                End If

                                                                GV28.AddNewRow()
                                                                dr = dtP.NewRow()
                                                                GV28.SetFocusedRowCellValue(colIPOJ_FPO_CODE_FK_PK, txtCode.Text)
                                                                dr("colIPOJ_FPO_CODE_FK_PK") = txtCode.Text
                                                                codeMax = Code_MAx(GV28, colIPOJ_NUM_SEQ_PK)
                                                                GV28.SetFocusedRowCellValue(colIPOJ_NUM_SEQ_PK, AdvBandedGridView1.GetRowCellValue(intj, colIPO_NUM_SEQ_PK)) 'codeMax)
                                                                dr("colIPOJ_NUM_SEQ_PK") = AdvBandedGridView1.GetRowCellValue(intj, colIPO_NUM_SEQ_PK) 'maxSec
                                                                GV28.SetFocusedRowCellValue(colIPOJ_CDF_NAPO_CODE_FK, AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_NAPO_CODE_FK1))
                                                                dr("colIPOJ_CDF_NAPO_CODE_FK") = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_NAPO_CODE_FK1)
                                                                codeMax = Code_MAx(GV28, colIPOJ_NUM_ORD)
                                                                GV28.SetFocusedRowCellValue(colIPOJ_NUM_ORD, codeMax)
                                                                dr("colIPOJ_NUM_ORD") = codeMax
                                                                GV28.SetFocusedRowCellValue(colIPOJ_SP_CODE_FK_PK, GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))
                                                                dr("colIPOJ_SP_CODE_FK_PK") = GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)

                                                                If (dtPre.Rows(0)("PRE_NATUCD_CDF_NUM_FK") IsNot System.DBNull.Value) Then
                                                                    If dtPre.Rows(0)("PRE_NATUCD_CDF_NUM_FK") = "04" Then

                                                                        GV28.SetFocusedRowCellValue(colIPOJ_CONT, dtContenant.Rows(countContenant)("PRECONT_CDF_COCDT_CODE_FK"))
                                                                        dr("colIPOJ_CONT") = dtContenant.Rows(countContenant)("PRECONT_CDF_COCDT_CODE_FK")
                                                                        GV28.SetFocusedRowCellValue(colIPOJ_VOL_CONT, dtContenant.Rows(countContenant)("PRECONT_NBCONTENANCE"))
                                                                        dr("colIPOJ_VOL_CONT") = dtContenant.Rows(countContenant)("PRECONT_NBCONTENANCE")
                                                                        GV28.SetFocusedRowCellValue(colIPOJ_VOL_CONT_UNIT, dtContenant.Rows(countContenant)("PRECONT_CDF_COCE_CODE_FK"))
                                                                        dr("colIPOJ_VOL_CONT_UNIT") = dtContenant.Rows(countContenant)("PRECONT_CDF_COCE_CODE_FK")

                                                                    Else

                                                                        GV28.SetFocusedRowCellValue(colIPOJ_CONT, 0)
                                                                        dr("colIPOJ_CONT") = 0
                                                                        GV28.SetFocusedRowCellValue(colIPOJ_VOL_CONT, 0)
                                                                        dr("colIPOJ_VOL_CONT") = 0
                                                                        GV28.SetFocusedRowCellValue(colIPOJ_VOL_CONT_UNIT, 0)
                                                                        dr("colIPOJ_VOL_CONT_UNIT") = 0

                                                                    End If
                                                                Else

                                                                    GV28.SetFocusedRowCellValue(colIPOJ_CONT, 0)
                                                                    dr("colIPOJ_CONT") = 0
                                                                    GV28.SetFocusedRowCellValue(colIPOJ_VOL_CONT, 0)
                                                                    dr("colIPOJ_VOL_CONT") = 0
                                                                    GV28.SetFocusedRowCellValue(colIPOJ_VOL_CONT_UNIT, 0)
                                                                    dr("colIPOJ_VOL_CONT_UNIT") = 0

                                                                End If

                                                                GV28.SetFocusedRowCellValue(colIPOJ_SP_CIPUCD, ClsSP.GetCodeVirtuel(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)))
                                                                dr("colIPOJ_SP_CIPUCD") = ClsSP.GetCodeVirtuel(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))

                                                                PoSo.UnitePrise_PP = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UNPO_CODE_FK1)
                                                                'On prend juste le premier élement (CIP) code PRE
                                                                PoSo.PRE_CODE = codePRE
                                                                'If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMIN1) IsNot DBNull.Value Then
                                                                '    PoSo.DoseMin = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMIN1)
                                                                'End If

                                                                'If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMAX1) IsNot DBNull.Value Then
                                                                '    PoSo.DoseMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMAX1)
                                                                'End If
                                                                'If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMIN1) IsNot DBNull.Value Then
                                                                '    PoSo.DoseMin = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMIN1)

                                                                'End If

                                                                If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMIN1) IsNot DBNull.Value Then
                                                                    Dim a As Array = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMIN1).ToString().Split("/")
                                                                    If (a.Length = 2) Then
                                                                        PoSo.DoseMin = a(0) / a(1)
                                                                    Else
                                                                        If (Not a(0).ToString().Equals(".")) Then
                                                                            PoSo.DoseMin = a(0)
                                                                        Else
                                                                            PoSo.DoseMin = Nothing
                                                                        End If

                                                                    End If
                                                                    'PoSoDose.DoseMin = dtPosoInfo.Rows(PosoInfoCount)("IPO_DOSEMIN")
                                                                Else
                                                                    If PoSo.DoseMin IsNot Nothing Then
                                                                        PoSo.DoseMin = Nothing
                                                                    End If
                                                                End If



                                                                'If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMAX1) IsNot DBNull.Value Then
                                                                '    PoSo.DoseMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMAX1)
                                                                'End If


                                                                If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMAX1) IsNot DBNull.Value Then
                                                                    Dim a As Array = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMAX1).ToString().Split("/")
                                                                    If (a.Length = 2) Then
                                                                        PoSo.DoseMax = a(0) / a(1)
                                                                    Else
                                                                        If (Not a(0).ToString().Equals(".")) Then
                                                                            PoSo.DoseMax = a(0)
                                                                        Else
                                                                            PoSo.DoseMax = Nothing
                                                                        End If

                                                                    End If
                                                                    'PoSoDose.DoseMin = dtPosoInfo.Rows(PosoInfoCount)("IPO_DOSEMIN")
                                                                Else
                                                                    If PoSo.DoseMin IsNot Nothing Then
                                                                        PoSo.DoseMin = Nothing
                                                                    End If
                                                                End If


                                                                If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMIN1) IsNot DBNull.Value Then PoSo.DureeTraitementMin = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMIN1)
                                                                If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMAX1) IsNot DBNull.Value Then PoSo.DureeTraitementMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DUREEMAX1)
                                                                If AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMAX_CODE_FK1) IsNot DBNull.Value Then PoSo.UniteDureeTraitementMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMAX_CODE_FK1)
                                                                If AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMIN_CODE_FK1) IsNot DBNull.Value Then PoSo.UniteDureeTraitementMin = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMIN_CODE_FK1)

                                                                If AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMIN1) IsNot System.DBNull.Value Then
                                                                    If (Not AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMIN1).ToString().Equals(".")) Then
                                                                        PoSo.FrequenceMin = AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMIN1)
                                                                    Else
                                                                        PoSo.FrequenceMin = Nothing
                                                                    End If
                                                                Else
                                                                    PoSo.FrequenceMin = Nothing
                                                                End If

                                                                If AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMAX1) IsNot System.DBNull.Value Then
                                                                    If (Not AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMAX1).ToString().Equals(".")) Then
                                                                        PoSo.FrequenceMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMAX1)
                                                                    Else
                                                                        PoSo.FrequenceMax = Nothing
                                                                    End If
                                                                Else
                                                                    PoSo.FrequenceMax = Nothing
                                                                End If

                                                                If AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_FREQMAX_CODE_FK2) IsNot DBNull.Value Then PoSo.UniteFrequenceMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_FREQMAX_CODE_FK2)
                                                                If AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_FREQMIN_CODE_FK2) IsNot DBNull.Value Then PoSo.UniteFrequenceMin = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_FREQMIN_CODE_FK2)

                                                                'Données anthropométriques
                                                                DA = ClsPosologie.Get_DonneeAnthropometrique(AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UNPO_CODE_FK1))
                                                                GV28.SetFocusedRowCellValue(colIPOJ_DONANTH_CDF_CODE_FK, DA)
                                                                dr("colIPOJ_DONANTH_CDF_CODE_FK") = DA
                                                                'PoSo.Execute()



                                                                If dtContenant.Rows(0)("PRECONT_NBCONTENANCE") IsNot System.DBNull.Value Then

                                                                    nbContenanceV0 = dtContenant.Rows(0)("PRECONT_NBCONTENANCE")

                                                                End If


                                                                If dtContenant.Rows(countContenant)("PRECONT_NBCONTENANCE") IsNot System.DBNull.Value Then

                                                                    nbContenanceVI = dtContenant.Rows(countContenant)("PRECONT_NBCONTENANCE")

                                                                End If

                                                                PoSo.ExecuteMonoVirtuelle(countContenant, nbContenanceV0, nbContenanceVI)

                                                                '''''' 2do AdvBandedGridView1.SetFocusedRowCellValue(colNonapplicable, 1)
                                                                'JAN 2008 Modified
                                                                GV28.SetFocusedRowCellValue(colIPOJ_DJMAX, String.Format("{0:n5}", PoSo.UCD_MAX.Valeur))
                                                                dr("colIPOJ_DJMAX") = String.Format("{0:n5}", PoSo.UCD_MAX.Valeur)
                                                                GV28.SetFocusedRowCellValue(colIPOJ_DJMIN, String.Format("{0:n5}", PoSo.UCD_MIN.Valeur))
                                                                dr("colIPOJ_DJMIN") = String.Format("{0:n5}", PoSo.UCD_MIN.Valeur)

                                                                If PoSo._OKMIN Then
                                                                    GV28.SetFocusedRowCellValue(colIPOJ_DTMIN, String.Format("{0:n5}", PoSo.DureeTraitementMin))
                                                                    dr("colIPOJ_DTMIN") = String.Format("{0:n5}", PoSo.DureeTraitementMin)
                                                                Else
                                                                    GV28.SetFocusedRowCellValue(colIPOJ_DTMIN, 0)
                                                                    dr("colIPOJ_DTMIN") = 0
                                                                End If
                                                                If PoSo._OKMax Then
                                                                    GV28.SetFocusedRowCellValue(colIPOJ_DTMAX, String.Format("{0:n5}", PoSo.DureeTraitementMax))
                                                                    dr("colIPOJ_DTMAX") = String.Format("{0:n5}", PoSo.DureeTraitementMax)
                                                                Else
                                                                    GV28.SetFocusedRowCellValue(colIPOJ_DTMAX, 0)
                                                                    dr("colIPOJ_DTMAX") = 0
                                                                End If

                                                                'dtUCD = cn.MySelect("SELECT IPOJ_NATUCD_CDF_CODE_FK, IPOJ_NATUCD_CDF_NUM_FK FROM THERIAQUE.IPOJ_INFOPOSO_JOURNALIERE WHERE IPOJ_SP_CIPUCD =" & cn.SQLText(ClsSP.GetCIPUCD(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))))
                                                                'If dtUCD.Rows.Count > 0 Then
                                                                '    GV28.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_CODE_FK, dtUCD.Rows(0)("IPOJ_NATUCD_CDF_CODE_FK"))
                                                                '    'InitLkup(Me.rpNATUCD_CDF_CODE_FK2, CDF_CODIF, strSSQL_IN_CDF_CODIF("04", "06") & " AND CDF_NUMERO_PK =" & cn.SQLText(dtUCD.Rows(0)("IPOJ_NATUCD_CDF_NUM_FK")), True)
                                                                '    GV28.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_NUM_FK, dtUCD.Rows(0)("IPOJ_NATUCD_CDF_NUM_FK"))
                                                                'End If

                                                                'Nature UCD 20 JAN 2009
                                                                dtUCD = cn.MySelect("SELECT DISTINCT PRE_NATUCD_CDF_CODE_FK, PRE_NATUCD_CDF_NUM_FK FROM THERIAQUE.PRE_PRESENTATION WHERE PRE_SP_CODE_FK = " & cn.SQLText(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)))
                                                                If dtUCD.Rows.Count = 1 Then
                                                                    GV28.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_CODE_FK, dtUCD.Rows(0)("PRE_NATUCD_CDF_CODE_FK"))
                                                                    dr("colIPOJ_NATUCD_CDF_CODE_FK") = dtUCD.Rows(0)("PRE_NATUCD_CDF_CODE_FK")
                                                                    'InitLkup(Me.rpNATUCD_CDF_CODE_FK2, CDF_CODIF, strSSQL_IN_CDF_CODIF("04", "06") & " AND CDF_NUMERO_PK =" & cn.SQLText(dtUCD.Rows(0)("IPOJ_NATUCD_CDF_NUM_FK")), True)
                                                                    GV28.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_NUM_FK, dtUCD.Rows(0)("PRE_NATUCD_CDF_NUM_FK"))
                                                                    dr("colIPOJ_NATUCD_CDF_NUM_FK") = dtUCD.Rows(0)("PRE_NATUCD_CDF_NUM_FK")
                                                                Else
                                                                    GV28.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_CODE_FK, "NON APPLICABLE")
                                                                    dr("colIPOJ_NATUCD_CDF_CODE_FK") = "NON APPLICABLE"
                                                                End If


                                                                'Poso MIN
                                                                If PoSo._OKMIN Then
                                                                    GV28.SetFocusedRowCellValue(colDTMinEnjour, PoSo.DureeTraitementMinEnJour)
                                                                    dr("colDTMinEnjour") = PoSo.DureeTraitementMinEnJour
                                                                    GV28.SetFocusedRowCellValue(colUCDMin, PoSo.UCD_MIN.Valeur)
                                                                    dr("colUCDMin") = PoSo.UCD_MIN.Valeur
                                                                    GV28.SetFocusedRowCellValue(colUniteTempsMin, AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMIN_CODE_FK1))
                                                                    dr("colUniteTempsMin") = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMIN_CODE_FK1)
                                                                End If
                                                                'Poso MAX
                                                                If PoSo._OKMax Then
                                                                    GV28.SetFocusedRowCellValue(colDTMaxEnjour, PoSo.DureeTraitementMaxEnJour)
                                                                    dr("colDTMaxEnjour") = PoSo.DureeTraitementMaxEnJour
                                                                    GV28.SetFocusedRowCellValue(colUCDMax, PoSo.UCD_MAX.Valeur)
                                                                    dr("colUCDMax") = PoSo.UCD_MAX.Valeur
                                                                    GV28.SetFocusedRowCellValue(colUniteTempsMax, AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMAX_CODE_FK1))
                                                                    dr("colUniteTempsMax") = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UTMAX_CODE_FK1)
                                                                End If

                                                                dtP.Rows.Add(dr)

                                                            Next

                                                        End If

                                                    End If
                                                End If

                                            End If
                                        End If
                                    End If
                                End If
                            End If
                            End If
                        Next

                    Next

                    Dim dv As New DataView

                    Dim keyDelete As String = ""

                    'dv = CType(GV28.DataSource, DataView)
                    'dtP = dv.ToTable()
                    dr = dtP.NewRow()


                    'Elimination des doublons 
                    For i As Integer = 0 To dtP.Rows.Count - 1
                        'colIPOJ_CONT
                        If dtP.Rows(i).Item("colIPOJ_CONT") IsNot System.DBNull.Value Then
                            If dtP.Rows(i).Item("colIPOJ_CONT") <> 60 Then

                                For j As Integer = i + 1 To dtP.Rows.Count - 1
                                    'colIPOJ_CONT
                                    If dtP.Rows(j).Item("colIPOJ_CONT") IsNot System.DBNull.Value Then
                                        If dtP.Rows(j).Item("colIPOJ_CONT") <> 60 Then
                                            'UCD
                                            If dtP.Rows(i).Item("colIPOJ_SP_CIPUCD") = dtP.Rows(j).Item("colIPOJ_SP_CIPUCD") Then
                                                'colIPOJ_DJMIN
                                                If dtP.Rows(i).Item("colIPOJ_DJMIN") = dtP.Rows(j).Item("colIPOJ_DJMIN") Then
                                                    'colIPOJ_DJMAX
                                                    If dtP.Rows(i).Item("colIPOJ_DJMAX") = dtP.Rows(j).Item("colIPOJ_DJMAX") Then
                                                        'colPosoMin
                                                        'If dtP.Rows(i).Item("colPosoMin") = dtP.Rows(j).Item("colPosoMin") Then
                                                        ' colIPOJ_NUM_SEQ_PK
                                                        If dtP.Rows(i).Item("colIPOJ_NUM_SEQ_PK") = dtP.Rows(j).Item("colIPOJ_NUM_SEQ_PK") Then

                                                            keyDelete &= dtP.Rows(j).Item("colIPOJ_NUM_ORD") & "_" & dtP.Rows(j).Item("colIPOJ_NUM_SEQ_PK") & "_" & dtP.Rows(j).Item("colIPOJ_FPO_CODE_FK_PK") & ";"

                                                            'GV28.DeleteRow(j)
                                                            'Exit For

                                                        End If
                                                        'End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If

                                Next

                            End If
                        End If
                    Next

                    If (Not keyDelete.Equals("")) Then

                        Dim s As String = ""
                        Dim b As Boolean = False
                        While (Not b)
                            b = True
                            For i As Integer = 0 To GV28.RowCount - 1
                                If (GV28.GetDataRow(i) IsNot Nothing) Then
                                    s = GV28.GetDataRow(i).Item("IPOJ_NUM_ORD") & "_" & GV28.GetDataRow(i).Item("IPOJ_NUM_SEQ_PK") & "_" & GV28.GetDataRow(i).Item("IPOJ_FPO_CODE_FK_PK")
                                    If keyDelete.Contains(s) Then
                                        GV28.DeleteRow(i)
                                        b = False
                                        Exit For
                                    End If
                                End If
                            Next

                        End While

                    End If


                    GV28.FocusedRowHandle = 0
                    'For Each dr As DataRow In dtP.Rows

                    '    If keyDelete.Contains(dr(17)) Then
                    '        dtP.Rows.Remove(dr)
                    '    End If

                    'Next

                    'Dim kk As Integer = 0
                    'Dim count As Integer = GV28.RowCount

                    'While (kk <= count)
                    '    GV28.DeleteRow(0)
                    '    kk += 1
                    'End While

                    'For i As Integer = 0 To dtP.Rows.Count - 1

                    '    GV28.AddNewRow()
                    '    For j As Integer = 0 To dtP.Columns.Count - 1

                    '        GV28.SetFocusedRowCellValue(GV28.Columns(j), dtP.Rows(i).Item(j))

                    '    Next

                    'Next

                    ProgressBar.Visible = False
                Else
                    MsgBox("Veuillez charger l'onglet séquence info posologie")
                End If
            End If
        End If
        On Error GoTo 0

    End Sub

    Public Sub CalcRowDose(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        'On Error Resume Next
        If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.Custom Then
            If e.Button.ImageIndex = 12 Then
                If Process_Message(strAlgoDose, MessageBoxButtons.YesNo, MessageBoxIcon.Question).BtResult = MsgBoxResult.Yes Then
                    Dim dtUCD As DataTable
                    For inti As Integer = 0 To GV30.RowCount - 1
                        GV30.DeleteRow(0)
                    Next
                    For inti As Integer = 0 To GV6.RowCount - 1 ' Spécialité
                        For intj As Integer = 0 To AdvBandedGridView1.RowCount - 1 ' Phase
                            If GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2) IsNot Nothing Then
                                If ClsSP.GetCIPUCD(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)) <> "" Then
                                    If AdvBandedGridView1.GetRowCellValue(intj, colIPO_NUM_SEQ_PK) IsNot Nothing Then
                                        Dim dtPre As New DataTable
                                        dtPre = ClsSP.GetPR_DT(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))
                                        If (dtPre.Rows.Count > 0) Then
                                            ProgressBar.Visible = True
                                            If (ProgressBar.Value >= ProgressBar.Minimum And ProgressBar.Value < ProgressBar.Maximum) Then
                                                ProgressBar.Value += 1
                                            End If
                                            ProgressBar.Maximum = GV6.RowCount * AdvBandedGridView1.RowCount * dtPre.Rows.Count
                                            'Le corp de l'algorithme
                                            Dim PoSoDose As New ClsPosologieDose
                                            If PoSoDose.TestCoherence_UP_Contenant(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)) = True And PoSoDose.TestCoherence_UDT_UCD(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)) = True Then

                                                GV30.AddNewRow()
                                                GV30.SetFocusedRowCellValue(colIPODOSE_FPO_CODE_FK_PK, txtCode.Text)
                                                GV30.SetFocusedRowCellValue(colIPODOSE_NUM_SEQ_PK, AdvBandedGridView1.GetRowCellValue(intj, colIPO_NUM_SEQ_PK))
                                                GV30.SetFocusedRowCellValue(colIPODOSE_NUM_ORD, Code_MAx(GV30, colIPODOSE_NUM_ORD))
                                                GV30.SetFocusedRowCellValue(colIPODOSE_SP_CODE_FK_PK, GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))
                                                GV30.SetFocusedRowCellValue(colIPODOSE_SP_CIPUCD, ClsSP.GetCIPUCD(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)))


                                                PoSoDose.UnitePrise_PP = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_UNPO_CODE_FK1)
                                                'On prend juste le premier élement (CIP) code PRE
                                                PoSoDose.PRE_CODE = dtPre.Rows(0)("PRE_CODE_PK")
                                                'If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMIN1) IsNot DBNull.Value Then PoSoDose.DoseMin = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMIN1)
                                                'If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMAX1) IsNot DBNull.Value Then PoSoDose.DoseMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMAX1)



                                                If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMIN1) IsNot DBNull.Value Then
                                                    Dim a As Array = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMIN1).ToString().Split("/")
                                                    If (a.Length = 2) Then
                                                        PoSoDose.DoseMin = a(0) / a(1)
                                                    Else
                                                        If (Not a(0).ToString().Equals(".")) Then
                                                            PoSoDose.DoseMin = a(0)
                                                        Else
                                                            PoSoDose.DoseMin = Nothing
                                                        End If

                                                    End If
                                                    'PoSoDoseDose.DoseMin = dtPoSoDoseInfo.Rows(PoSoDoseInfoCount)("IPO_DOSEMIN")
                                                Else
                                                    If PoSoDose.DoseMin IsNot Nothing Then
                                                        PoSoDose.DoseMin = Nothing
                                                    End If
                                                End If

                                                If AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMAX1) IsNot DBNull.Value Then
                                                    Dim a As Array = AdvBandedGridView1.GetRowCellValue(intj, colIPO_DOSEMAX1).ToString().Split("/")
                                                    If (a.Length = 2) Then
                                                        PoSoDose.DoseMax = a(0) / a(1)
                                                    Else
                                                        If (Not a(0).ToString().Equals(".")) Then
                                                            PoSoDose.DoseMax = a(0)
                                                        Else
                                                            PoSoDose.DoseMax = Nothing
                                                        End If

                                                    End If
                                                    'PoSoDoseDose.DoseMax = dtPoSoDoseInfo.Rows(PoSoDoseInfoCount)("IPO_DoseMax")
                                                Else
                                                    If PoSoDose.DoseMax IsNot Nothing Then
                                                        PoSoDose.DoseMax = Nothing
                                                    End If
                                                End If

                                                PoSoDose.FrequenceMin = AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMIN1)
                                                PoSoDose.FrequenceMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_FREQMAX1)
                                                If AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_FREQMAX_CODE_FK2) IsNot DBNull.Value Then PoSoDose.UniteFrequenceMax = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_FREQMAX_CODE_FK2)
                                                If AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_FREQMIN_CODE_FK2) IsNot DBNull.Value Then PoSoDose.UniteFrequenceMin = AdvBandedGridView1.GetRowCellValue(intj, colIPO_CDF_FREQMIN_CODE_FK2)

                                            Else
                                                'Non applicable
                                                GV30.AddNewRow()
                                                GV30.SetFocusedRowCellValue(colIPODOSE_FPO_CODE_FK_PK, txtCode.Text)
                                                GV30.SetFocusedRowCellValue(colIPODOSE_NUM_SEQ_PK, AdvBandedGridView1.GetRowCellValue(intj, colIPO_NUM_SEQ_PK))
                                                GV30.SetFocusedRowCellValue(colIPODOSE_NUM_ORD, Code_MAx(GV30, colIPODOSE_NUM_ORD))
                                                GV30.SetFocusedRowCellValue(colIPODOSE_SP_CODE_FK_PK, GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))
                                                GV30.SetFocusedRowCellValue(colIPODOSE_SP_CIPUCD, ClsSP.GetCIPUCD(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)))


                                                GV30.SetFocusedRowCellValue(colIPODOSE_NATUCD_CDF_CODE_FK, 0)
                                                GV30.SetFocusedRowCellValue(colIPODOSE_DJMAX, 0)
                                                GV30.SetFocusedRowCellValue(colIPODOSE_DJMIN, 0)
                                                GV30.SetFocusedRowCellValue(colIPODOSE_DPMAX, 0)
                                                GV30.SetFocusedRowCellValue(colIPODOSE_DPMIN, 0)
                                                GV30.SetFocusedRowCellValue(colDoseApplicable, 0)
                                                Exit For

                                            End If

                                            PoSoDose.ExecuteDoseparPrise()
                                            PoSoDose.ExecuteDoseparJour()

                                            GV30.SetFocusedRowCellValue(colIPODOSE_DJMAX, String.Format("{0:n5}", PoSoDose.UCD_PARJOUR_MAX.Valeur))
                                            GV30.SetFocusedRowCellValue(colIPODOSE_DJMIN, String.Format("{0:n5}", PoSoDose.UCD_PARJOUR_MIN.Valeur))
                                            GV30.SetFocusedRowCellValue(colIPODOSE_DPMAX, String.Format("{0:n5}", PoSoDose.UCD_PARPRISE_MAX.Valeur))
                                            GV30.SetFocusedRowCellValue(colIPODOSE_DPMIN, String.Format("{0:n5}", PoSoDose.UCD_PARPRISE_MIN.Valeur))

                                            dtUCD = cn.MySelect("SELECT DISTINCT PRE_NATUCD_CDF_CODE_FK, PRE_NATUCD_CDF_NUM_FK FROM THERIAQUE.PRE_PRESENTATION WHERE PRE_SP_CODE_FK = " & cn.SQLText(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)))
                                            If dtUCD.Rows.Count = 1 Then
                                                GV30.SetFocusedRowCellValue(colIPODOSE_NATUCD_CDF_CODE_FK, dtUCD.Rows(0)("PRE_NATUCD_CDF_CODE_FK"))
                                                GV30.SetFocusedRowCellValue(colIPODOSE_NATUCD_CDF_NUM_FK, dtUCD.Rows(0)("PRE_NATUCD_CDF_NUM_FK"))
                                            Else
                                                GV30.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_CODE_FK, "NON APPLICABLE")
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        Next
                    Next
                    ProgressBar.Visible = False
                End If
            End If
            If e.Button.ImageIndex = 11 Then
                If Process_Message(strExport, MessageBoxButtons.YesNo, MessageBoxIcon.Question).BtResult = MsgBoxResult.Yes Then
                    If GV30.RowCount > 1 Then
                        'GV30.AddNewRow()
                        'GC30.ShowPrintPreview()
                        'GV30.DeleteSelectedRows()
                        Dim sPath As String
                        SFDialogEnregistrer.Title = "Choisir un emplacement pour enregistrer le fichier Excel."
                        SFDialogEnregistrer.InitialDirectory = "c:\"
                        SFDialogEnregistrer.Filter = "Fichiers Excel (*.xls)|*.xls"
                        SFDialogEnregistrer.FilterIndex = 2
                        SFDialogEnregistrer.RestoreDirectory = True
                        If SFDialogEnregistrer.ShowDialog() = DialogResult.OK Then
                            sPath = SFDialogEnregistrer.FileName

                            Dim oExcel As New Microsoft.Office.Interop.Excel.Application
                            Dim oBook As Microsoft.Office.Interop.Excel.Workbook
                            Dim oSheet As Microsoft.Office.Interop.Excel.Worksheet

                            oBook = oExcel.Workbooks.Add
                            oSheet = oBook.Sheets(1)

                            'DEFINITION DES EN-TETE DE COLONNES
                            oSheet.Cells(1, 1) = "N°"
                            oSheet.Cells(1, 2) = "UCD"
                            oSheet.Cells(1, 3) = "Dose par jour - Min"
                            oSheet.Cells(1, 4) = "Dose par jour - Max"
                            oSheet.Cells(1, 5) = "Dose par prise - Min"
                            oSheet.Cells(1, 6) = "Dose par prise - Max"
                            oSheet.Cells(1, 7) = "Nature UCD"

                            Dim sSQL As String
                            Dim dt As New DataTable
                            For iCount As Integer = 0 To GV30.RowCount - 1
                                oSheet.Cells(iCount + 2, 1) = GV30.GetRowCellDisplayText(iCount, colIPODOSE_NUM_SEQ_PK)
                                oSheet.Cells(iCount + 2, 2) = GV30.GetRowCellDisplayText(iCount, colIPODOSE_SP_CIPUCD)
                                oSheet.Cells(iCount + 2, 3) = GV30.GetRowCellDisplayText(iCount, colIPODOSE_DJMIN)
                                oSheet.Cells(iCount + 2, 4) = GV30.GetRowCellDisplayText(iCount, colIPODOSE_DJMAX)
                                oSheet.Cells(iCount + 2, 5) = GV30.GetRowCellDisplayText(iCount, colIPODOSE_DPMIN)
                                oSheet.Cells(iCount + 2, 6) = GV30.GetRowCellDisplayText(iCount, colIPODOSE_DPMAX)

                                If GV30.GetRowCellValue(iCount, colIPODOSE_NATUCD_CDF_NUM_FK) <> Nothing Then
                                    If GV30.GetRowCellValue(iCount, colIPODOSE_NATUCD_CDF_NUM_FK) IsNot DBNull.Value Then
                                        sSQL = " Select CDF_CODE_PK as code, CDF_NOM as libelle, CDF_NUMERO_PK as num  From THERIAQUE.CDF_CODIF  where CDF_NUMERO_PK = " & cn.SQLText(GV30.GetRowCellValue(iCount, colIPODOSE_NATUCD_CDF_NUM_FK))
                                        sSQL += " AND CDF_CODE_PK = " & GV30.GetRowCellValue(iCount, colIPODOSE_NATUCD_CDF_CODE_FK2)

                                        dt = cn.MySelect(sSQL)
                                        If dt.Rows.Count > 0 Then oSheet.Cells(iCount + 2, 7) = dt.Rows(0)("libelle")
                                    Else
                                        oSheet.Cells(iCount + 2, 7) = GV30.GetRowCellDisplayText(iCount, colIPODOSE_NATUCD_CDF_CODE_FK)
                                    End If
                                Else
                                    oSheet.Cells(iCount + 2, 7) = GV30.GetRowCellDisplayText(iCount, colIPODOSE_NATUCD_CDF_CODE_FK)
                                End If


                            Next

                            oBook.SaveAs(sPath)
                            oExcel.Visible = True
                        End If
                    End If
                End If
            End If
        End If

        On Error GoTo 0
    End Sub

    'onglet posologie min max
    Public Sub CalcDoseMinMax(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        'On Error Resume Next

        Dim dtP As New DataTable
        Dim dr As DataRow
        Dim codeMax As String
        Dim temp As String

        'Dim VContenance0 As String = ""
        Dim NbContenance0 As Double = 0
        Dim NbContenanceI As Double = 0

        If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.Custom Then
            If e.Button.ImageIndex = 12 Then
                If Process_Message(strAlgoDose, MessageBoxButtons.YesNo, MessageBoxIcon.Question).BtResult = MsgBoxResult.Yes Then

                    Dim dr1 As DataRow
                    Dim dtTemp As New DataTable

                    For i As Integer = 0 To GV30.Columns.Count - 1
                        dtTemp.Columns.Add(GV30.Columns(i).Name)
                    Next

                    For i As Integer = 0 To GV30.RowCount - 1
                        If (GV30.GetDataRow(i) IsNot Nothing) Then
                            If (GV30.GetDataRow(i)("IPODOSE_CALCUL") IsNot System.DBNull.Value) Then
                                If (GV30.GetDataRow(i)("IPODOSE_CALCUL") = False) Then
                                    dr1 = dtTemp.NewRow()
                                    For jj As Integer = 0 To GV30.Columns.Count - 1
                                        dr1(GV30.Columns(jj).Name) = GV30.GetDataRow(i)(GV30.Columns(jj).FieldName)
                                    Next
                                    dtTemp.Rows.Add(dr1)
                                End If
                            End If
                        End If
                    Next


                    Dim dtUCD As DataTable


                    For i As Integer = 0 To GV30.Columns.Count - 1
                        dtP.Columns.Add(GV30.Columns(i).Name)
                    Next


                    For inti As Integer = 0 To GV30.RowCount

                        GV30.DeleteRow(0)

                    Next


                    Dim len As Integer = GV30.RowCount
                    Dim ii As Integer = 0
                    While (ii < len)
                        GV30.DeleteRow(0)
                        ii += 1
                    End While

                    Dim Sec As Integer = ClsPosologie.MaxSequence("IPODOSE_NUM_SEQ_PK", "IPODOSE_INFOPOSO")
                    Dim maxSec As Integer
                    Dim cmp As Integer = 0


                    For inti As Integer = 0 To GV6.RowCount - 1 ' Spécialité

                        If GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2) IsNot Nothing Then

                            If (cmp = 0) Then

                                maxSec = ClsPosologie.GetExistSeq(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2), "IPODOSE_NUM_SEQ_PK", "IPODOSE_INFOPOSO", "IPODOSE_SP_CODE_FK_PK")

                            End If

                        End If

                        If GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2) IsNot Nothing Then 'And ClsPosologie.IsCommercialized(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)) Then
                            If Not IsMonographie(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)) Then
                                If ClsSP.GetCIPUCD(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)) <> "" Then
                                    Dim dtPre As New DataTable
                                    dtPre = ClsSP.GetPR_DT(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))
                                    If (dtPre.Rows.Count > 0) Then
                                        ProgressBar.Visible = True
                                        If (ProgressBar.Value >= ProgressBar.Minimum And ProgressBar.Value < ProgressBar.Maximum) Then
                                            ProgressBar.Value += 1
                                        End If
                                        ProgressBar.Maximum = GV6.RowCount
                                        Dim PoSoDose As New ClsPosologieDose
                                        If PoSoDose.TestCoherence_UP_Contenant(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)) = True And PoSoDose.TestCoherence_UDT_UCD(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)) = True Then
                                            If (maxSec = -1) Then
                                                If (cmp = 0) Then
                                                    maxSec = Sec + 1
                                                    cmp = 1
                                                End If
                                            Else
                                                If (cmp = 1) Then
                                                    maxSec += 1
                                                End If
                                            End If

                                            GV30.AddNewRow()
                                            dr = dtP.NewRow()
                                            GV30.SetFocusedRowCellValue(colCalcul, True)
                                            dr(0) = True
                                            GV30.SetFocusedRowCellValue(colIPODOSE_FPO_CODE_FK_PK, txtCode.Text)
                                            dr("colIPODOSE_FPO_CODE_FK_PK") = txtCode.Text
                                            codeMax = Code_MAx(GV30, colIPODOSE_NUM_SEQ_PK)
                                            GV30.SetFocusedRowCellValue(colIPODOSE_NUM_SEQ_PK, maxSec) 'codeMax)
                                            dr("colIPODOSE_NUM_SEQ_PK") = maxSec
                                            codeMax = Code_MAx(GV30, colIPODOSE_NUM_ORD)
                                            GV30.SetFocusedRowCellValue(colIPODOSE_NUM_ORD, codeMax)
                                            dr("colIPODOSE_NUM_ORD") = codeMax
                                            GV30.SetFocusedRowCellValue(colIPODOSE_SP_CODE_FK_PK, GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))
                                            dr("colIPODOSE_SP_CODE_FK_PK") = GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)
                                            GV30.SetFocusedRowCellValue(colIPODOSE_SP_CIPUCD, ClsSP.GetCIPUCD(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)))
                                            dr("colIPODOSE_SP_CIPUCD") = ClsSP.GetCIPUCD(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))
                                            Dim dtPoso As DataTable
                                            dtPoso = PoSoDose.GetPosoBySpec(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))

                                            Dim dtRows As DataTable
                                            dtRows = New DataTable("PosoCalculed")
                                            Dim colUCD_PARJOUR_MAX As DataColumn = New DataColumn("colUCD_PARJOUR_MAX")
                                            colUCD_PARJOUR_MAX.DataType = System.Type.GetType("System.Decimal")
                                            dtRows.Columns.Add(colUCD_PARJOUR_MAX)

                                            Dim colUCD_PARJOUR_MIN As DataColumn = New DataColumn("colUCD_PARJOUR_MIN")
                                            colUCD_PARJOUR_MIN.DataType = System.Type.GetType("System.Decimal")
                                            dtRows.Columns.Add(colUCD_PARJOUR_MIN)

                                            Dim colUCD_PARPRISE_MAX As DataColumn = New DataColumn("colUCD_PARPRISE_MAX")
                                            colUCD_PARPRISE_MAX.DataType = System.Type.GetType("System.Decimal")
                                            dtRows.Columns.Add(colUCD_PARPRISE_MAX)

                                            Dim colUCD_PARPRISE_MIN As DataColumn = New DataColumn("colUCD_PARPRISE_MIN")
                                            colUCD_PARPRISE_MIN.DataType = System.Type.GetType("System.Decimal")
                                            dtRows.Columns.Add(colUCD_PARPRISE_MIN)

                                            Dim testNiveau3 As Boolean = True

                                            For PosoCount As Integer = 0 To dtPoso.Rows.Count - 1
                                                Dim dtPosoInfo As DataTable
                                                dtPosoInfo = PoSoDose.GetPosoInfoByCode(dtPoso.Rows(PosoCount)(0))
                                                For PosoInfoCount As Integer = 0 To dtPosoInfo.Rows.Count - 1
                                                    PoSoDose.UnitePrise_PP = dtPosoInfo.Rows(PosoInfoCount)("IPO_CDF_UNPO_CODE_FK")

                                                    If (Not PoSoDose.UnitePrise_PP(PoSoDose.UnitePrise_PP.Length - 4).ToString().ToLower().Equals("z")) Then
                                                        testNiveau3 = False
                                                    End If
                                                    If dtPosoInfo.Rows(PosoInfoCount)("IPO_DOSEMIN") IsNot DBNull.Value Then
                                                        Dim a As Array = dtPosoInfo.Rows(PosoInfoCount)("IPO_DOSEMIN").ToString().Split("/")
                                                        If (a.Length = 2) Then
                                                            PoSoDose.DoseMin = a(0) / a(1)
                                                        Else
                                                            If (Not a(0).ToString().Equals(".")) Then
                                                                PoSoDose.DoseMin = a(0)
                                                            Else
                                                                PoSoDose.DoseMin = Nothing
                                                            End If

                                                        End If
                                                        'PoSoDose.DoseMin = dtPosoInfo.Rows(PosoInfoCount)("IPO_DOSEMIN")
                                                    Else
                                                        If PoSoDose.DoseMin IsNot Nothing Then
                                                            PoSoDose.DoseMin = Nothing
                                                        End If


                                                    End If

                                                    If dtPosoInfo.Rows(PosoInfoCount)("IPO_DOSEMAX") IsNot DBNull.Value Then
                                                        Dim a As Array = dtPosoInfo.Rows(PosoInfoCount)("IPO_DOSEMAX").ToString().Split("/")
                                                        If (a.Length = 2) Then
                                                            PoSoDose.DoseMax = a(0) / a(1)
                                                        Else
                                                            If (Not a(0).ToString().Equals(".")) Then
                                                                PoSoDose.DoseMax = a(0)
                                                            Else
                                                                PoSoDose.DoseMax = Nothing
                                                            End If

                                                        End If

                                                    Else
                                                        If PoSoDose.DoseMax IsNot Nothing Then
                                                            PoSoDose.DoseMax = Nothing
                                                        End If

                                                    End If

                                                    If dtPosoInfo.Rows(PosoInfoCount)("IPO_FREQMIN") IsNot DBNull.Value And IsNumeric(dtPosoInfo.Rows(PosoInfoCount)("IPO_FREQMIN")) Then
                                                        PoSoDose.FrequenceMin = dtPosoInfo.Rows(PosoInfoCount)("IPO_FREQMIN")
                                                    Else
                                                        PoSoDose.FrequenceMin = Nothing
                                                    End If
                                                    If dtPosoInfo.Rows(PosoInfoCount)("IPO_FREQMAX") IsNot DBNull.Value And IsNumeric(dtPosoInfo.Rows(PosoInfoCount)("IPO_FREQMAX")) Then
                                                        PoSoDose.FrequenceMax = dtPosoInfo.Rows(PosoInfoCount)("IPO_FREQMAX")
                                                    Else
                                                        PoSoDose.FrequenceMax = Nothing
                                                    End If

                                                    If dtPosoInfo.Rows(PosoInfoCount)("IPO_CDF_FREQMAX_CODE_FK") IsNot DBNull.Value Then
                                                        PoSoDose.UniteFrequenceMax = dtPosoInfo.Rows(PosoInfoCount)("IPO_CDF_FREQMAX_CODE_FK")
                                                        'Else
                                                        '    PoSoDose.UniteFrequenceMax = Nothing
                                                    End If

                                                    If dtPosoInfo.Rows(PosoInfoCount)("IPO_CDF_FREQMIN_CODE_FK") IsNot DBNull.Value Then
                                                        PoSoDose.UniteFrequenceMin = dtPosoInfo.Rows(PosoInfoCount)("IPO_CDF_FREQMIN_CODE_FK")
                                                        'Else
                                                        '    PoSoDose.UniteFrequenceMin = Nothing
                                                    End If


                                                    'On prend juste le premier élement (CIP) code PRE
                                                    PoSoDose.PRE_CODE = dtPre.Rows(0)("PRE_CODE_PK")

                                                    PoSoDose.ExecuteDoseparPrise()
                                                    PoSoDose.ExecuteDoseparJour()
                                                    Dim d As DataRow
                                                    d = dtRows.NewRow()
                                                    d("colUCD_PARJOUR_MAX") = String.Format("{0:n5}", PoSoDose.UCD_PARJOUR_MAX.Valeur)
                                                    d("colUCD_PARJOUR_MIN") = PoSoDose.UCD_PARJOUR_MIN.Valeur
                                                    d("colUCD_PARPRISE_MAX") = PoSoDose.UCD_PARPRISE_MAX.Valeur
                                                    d("colUCD_PARPRISE_MIN") = PoSoDose.UCD_PARPRISE_MIN.Valeur
                                                    dtRows.Rows.Add(d)
                                                Next
                                            Next
                                            temp = "0"
                                            If (Not preremplissage) Then
                                                testNiveau3 = True
                                            End If
                                            If (testNiveau3) Then temp = String.Format("{0:n5}", PoSoDose.Get_MAX(dtRows, "colUCD_PARJOUR_MAX"))
                                            GV30.SetFocusedRowCellValue(colIPODOSE_DJMAX, temp)
                                            dr("colIPODOSE_DJMAX") = temp
                                            If (testNiveau3) Then temp = String.Format("{0:n5}", PoSoDose.Get_MIN(dtRows, "colUCD_PARJOUR_MIN"))
                                            GV30.SetFocusedRowCellValue(colIPODOSE_DJMIN, temp)
                                            dr("colIPODOSE_DJMIN") = temp
                                            If (testNiveau3) Then temp = String.Format("{0:n5}", PoSoDose.Get_MAX(dtRows, "colUCD_PARPRISE_MAX"))
                                            GV30.SetFocusedRowCellValue(colIPODOSE_DPMAX, temp)
                                            dr("colIPODOSE_DPMAX") = temp
                                            If (testNiveau3) Then temp = String.Format("{0:n5}", PoSoDose.Get_MIN(dtRows, "colUCD_PARPRISE_MIN"))
                                            GV30.SetFocusedRowCellValue(colIPODOSE_DPMIN, temp)
                                            dr("colIPODOSE_DPMIN") = temp

                                            dtUCD = cn.MySelect("SELECT DISTINCT PRE_NATUCD_CDF_CODE_FK, PRE_NATUCD_CDF_NUM_FK FROM THERIAQUE.PRE_PRESENTATION WHERE PRE_SP_CODE_FK = " & cn.SQLText(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)))
                                            If dtUCD.Rows.Count = 1 Then
                                                GV30.SetFocusedRowCellValue(colIPODOSE_NATUCD_CDF_CODE_FK, dtUCD.Rows(0)("PRE_NATUCD_CDF_CODE_FK"))
                                                dr("colIPODOSE_NATUCD_CDF_CODE_FK") = dtUCD.Rows(0)("PRE_NATUCD_CDF_CODE_FK")
                                                GV30.SetFocusedRowCellValue(colIPODOSE_NATUCD_CDF_NUM_FK, dtUCD.Rows(0)("PRE_NATUCD_CDF_NUM_FK"))
                                                dr("colIPODOSE_NATUCD_CDF_NUM_FK") = dtUCD.Rows(0)("PRE_NATUCD_CDF_NUM_FK")
                                            Else
                                                GV30.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_CODE_FK, "NON APPLICABLE")
                                                dr("colIPODOSE_NATUCD_CDF_CODE_FK") = "NON APPLICABLE"
                                            End If

                                            GV30.SetFocusedRowCellValue(colIPODOSE_CONT, 0)
                                            dr("colIPODOSE_CONT") = 0
                                            GV30.SetFocusedRowCellValue(colIPODOSE_VOL_CONT, 0)
                                            dr("colIPODOSE_VOL_CONT") = 0
                                            GV30.SetFocusedRowCellValue(colIPODOSE_VOL_CONT_UNIT, 0)
                                            dr("colIPODOSE_VOL_CONT_UNIT") = 0

                                            'Todo

                                            EmpecherCalcul(dtTemp, maxSec)
                                        Else
                                            'Non applicable

                                            If (maxSec = -1) Then
                                                If (cmp = 0) Then
                                                    maxSec = Sec + 1
                                                    cmp = 1
                                                End If
                                            Else
                                                If (cmp = 1) Then
                                                    maxSec += 1
                                                End If
                                            End If

                                            GV30.AddNewRow()
                                            NewCalculation = True
                                            dr = dtP.NewRow()
                                            GV30.SetFocusedRowCellValue(colIPODOSE_FPO_CODE_FK_PK, txtCode.Text)
                                            dr("colIPODOSE_FPO_CODE_FK_PK") = txtCode.Text
                                            codeMax = Code_MAx(GV30, colIPODOSE_NUM_SEQ_PK)
                                            GV30.SetFocusedRowCellValue(colIPODOSE_NUM_SEQ_PK, maxSec) 'codeMax)
                                            dr("colIPODOSE_NUM_SEQ_PK") = maxSec
                                            codeMax = Code_MAx(GV30, colIPODOSE_NUM_ORD)
                                            GV30.SetFocusedRowCellValue(colIPODOSE_NUM_ORD, codeMax)
                                            dr("colIPODOSE_NUM_ORD") = codeMax
                                            GV30.SetFocusedRowCellValue(colIPODOSE_SP_CODE_FK_PK, GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))
                                            dr("colIPODOSE_SP_CODE_FK_PK") = GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)
                                            GV30.SetFocusedRowCellValue(colIPODOSE_SP_CIPUCD, ClsSP.GetCIPUCD(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)))
                                            dr("colIPODOSE_SP_CIPUCD") = ClsSP.GetCIPUCD(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))
                                            'GV30.SetFocusedRowCellValue(colIPODOSE_NATUCD_CDF_CODE_FK, 0)
                                            'dr("colIPODOSE_NATUCD_CDF_CODE_FK") = 0

                                            dtUCD = cn.MySelect("SELECT DISTINCT PRE_NATUCD_CDF_CODE_FK, PRE_NATUCD_CDF_NUM_FK FROM THERIAQUE.PRE_PRESENTATION WHERE PRE_SP_CODE_FK = " & cn.SQLText(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)) & " and (PRE_NATUCD_CDF_CODE_FK <> '' and PRE_NATUCD_CDF_NUM_FK <> '' )")
                                            If dtUCD.Rows.Count = 1 Then
                                                GV30.SetFocusedRowCellValue(colIPODOSE_NATUCD_CDF_CODE_FK, dtUCD.Rows(0)("PRE_NATUCD_CDF_CODE_FK"))
                                                dr("colIPODOSE_NATUCD_CDF_CODE_FK") = dtUCD.Rows(0)("PRE_NATUCD_CDF_CODE_FK")
                                                GV30.SetFocusedRowCellValue(colIPODOSE_NATUCD_CDF_NUM_FK, dtUCD.Rows(0)("PRE_NATUCD_CDF_NUM_FK"))
                                                dr("colIPODOSE_NATUCD_CDF_NUM_FK") = dtUCD.Rows(0)("PRE_NATUCD_CDF_NUM_FK")
                                            Else
                                                GV30.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_CODE_FK, "NON APPLICABLE")
                                                dr("colIPODOSE_NATUCD_CDF_CODE_FK") = "NON APPLICABLE"
                                            End If

                                            GV30.SetFocusedRowCellValue(colIPODOSE_DJMAX, 0)
                                            dr("colIPODOSE_DJMAX") = 0
                                            GV30.SetFocusedRowCellValue(colIPODOSE_DJMIN, 0)
                                            dr("colIPODOSE_DJMIN") = 0
                                            GV30.SetFocusedRowCellValue(colIPODOSE_DPMAX, 0)
                                            dr("colIPODOSE_DPMAX") = 0
                                            GV30.SetFocusedRowCellValue(colIPODOSE_DPMIN, 0)
                                            dr("colIPODOSE_DPMIN") = 0
                                            GV30.SetFocusedRowCellValue(colDoseApplicable, 0)
                                            dr("colDoseApplicable") = 0
                                            GV30.SetFocusedRowCellValue(colIPODOSE_CONT, 0)
                                            dr("colIPODOSE_CONT") = 0
                                            GV30.SetFocusedRowCellValue(colIPODOSE_VOL_CONT, 0)
                                            dr("colIPODOSE_VOL_CONT") = 0
                                            GV30.SetFocusedRowCellValue(colIPODOSE_VOL_CONT_UNIT, 0)
                                            dr("colIPODOSE_VOL_CONT_UNIT") = 0
                                        End If
                                        dtP.Rows.Add(dr)
                                        'todo
                                        EmpecherCalcul(dtTemp, maxSec)
                                    End If
                                End If
                            Else ''Inclure les Mono virtuelles
                                If ClsSP.GetCodeVirtuel(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)) <> "" Then
                                    Dim dtPre As New DataTable
                                    dtPre = ClsSP.GetPR_DT(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))
                                    If (dtPre IsNot Nothing) Then
                                        If (dtPre.Rows.Count > 0) Then

                                            ProgressBar.Visible = True
                                            If (ProgressBar.Value >= ProgressBar.Minimum And ProgressBar.Value < ProgressBar.Maximum) Then
                                                ProgressBar.Value += 1
                                            End If
                                            ProgressBar.Maximum = GV6.RowCount
                                            Dim codePRE As String
                                            codePRE = dtPre.Rows(0)("PRE_CODE_PK")
                                            If codePRE(0) = "V" Then
                                                Dim dtContenant As New DataTable
                                                dtContenant = ClsPRE.GetContenant(codePRE)
                                                If (dtContenant.Rows.Count > 0) Then
                                                    'Dans le cas d'un seul contenant, garder le même algorithme de calcul pour les autres colonnes
                                                    If dtContenant.Rows.Count = 1 Then
                                                        Dim PoSoDose As New ClsPosologieDose

                                                        If (maxSec = -1) Then
                                                            If (cmp = 0) Then
                                                                maxSec = Sec + 1
                                                                cmp = 1
                                                            End If
                                                        Else
                                                            If (cmp = 1) Then
                                                                maxSec += 1
                                                            End If
                                                        End If

                                                        GV30.AddNewRow()
                                                        dr = dtP.NewRow()
                                                        GV30.SetFocusedRowCellValue(colIPODOSE_FPO_CODE_FK_PK, txtCode.Text)
                                                        dr("colIPODOSE_FPO_CODE_FK_PK") = txtCode.Text
                                                        codeMax = Code_MAx(GV30, colIPODOSE_NUM_SEQ_PK)
                                                        GV30.SetFocusedRowCellValue(colIPODOSE_NUM_SEQ_PK, maxSec) 'codeMax)
                                                        dr("colIPODOSE_NUM_SEQ_PK") = maxSec 'codeMax
                                                        codeMax = Code_MAx(GV30, colIPODOSE_NUM_ORD)
                                                        GV30.SetFocusedRowCellValue(colIPODOSE_NUM_ORD, codeMax)
                                                        dr("colIPODOSE_NUM_ORD") = codeMax
                                                        GV30.SetFocusedRowCellValue(colIPODOSE_SP_CODE_FK_PK, GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))
                                                        dr("colIPODOSE_SP_CODE_FK_PK") = GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)

                                                        GV30.SetFocusedRowCellValue(colIPODOSE_CONT, dtContenant.Rows(0)("PRECONT_CDF_COCDT_CODE_FK"))
                                                        dr("colIPODOSE_CONT") = dtContenant.Rows(0)("PRECONT_CDF_COCDT_CODE_FK")
                                                        GV30.SetFocusedRowCellValue(colIPODOSE_VOL_CONT, dtContenant.Rows(0)("PRECONT_NBCONTENANCE"))
                                                        dr("colIPODOSE_VOL_CONT") = dtContenant.Rows(0)("PRECONT_NBCONTENANCE")
                                                        GV30.SetFocusedRowCellValue(colIPODOSE_VOL_CONT_UNIT, dtContenant.Rows(0)("PRECONT_CDF_COCE_CODE_FK"))
                                                        dr("colIPODOSE_VOL_CONT_UNIT") = dtContenant.Rows(0)("PRECONT_CDF_COCE_CODE_FK")

                                                        If dtPre.Rows(0)("PRE_NATUCD_CDF_NUM_FK") IsNot System.DBNull.Value Then



                                                            If dtPre.Rows(0)("PRE_NATUCD_CDF_NUM_FK") = "04" Then

                                                                GV30.SetFocusedRowCellValue(colIPODOSE_CONT, dtContenant.Rows(0)("PRECONT_CDF_COCDT_CODE_FK"))
                                                                dr("colIPODOSE_CONT") = dtContenant.Rows(0)("PRECONT_CDF_COCDT_CODE_FK")
                                                                GV30.SetFocusedRowCellValue(colIPODOSE_VOL_CONT, dtContenant.Rows(0)("PRECONT_NBCONTENANCE"))
                                                                dr("colIPODOSE_VOL_CONT") = dtContenant.Rows(0)("PRECONT_NBCONTENANCE")
                                                                If (dtContenant.Rows(0)("PRECONT_CDF_COCE_CODE_FK") Is System.DBNull.Value) Then
                                                                    GV30.SetFocusedRowCellValue(colIPODOSE_VOL_CONT_UNIT, 0)
                                                                    dr("colIPODOSE_VOL_CONT_UNIT") = 0
                                                                Else
                                                                    GV30.SetFocusedRowCellValue(colIPODOSE_VOL_CONT_UNIT, dtContenant.Rows(0)("PRECONT_CDF_COCE_CODE_FK"))
                                                                    dr("colIPODOSE_VOL_CONT_UNIT") = dtContenant.Rows(0)("PRECONT_CDF_COCE_CODE_FK")
                                                                End If

                                                            Else

                                                                GV30.SetFocusedRowCellValue(colIPODOSE_CONT, 0)
                                                                dr("colIPODOSE_CONT") = 0
                                                                GV30.SetFocusedRowCellValue(colIPODOSE_VOL_CONT, 0)
                                                                dr("colIPODOSE_VOL_CONT") = 0
                                                                GV30.SetFocusedRowCellValue(colIPODOSE_VOL_CONT_UNIT, 0)
                                                                dr("colIPODOSE_VOL_CONT_UNIT") = 0

                                                            End If
                                                        Else

                                                            GV30.SetFocusedRowCellValue(colIPODOSE_CONT, 0)
                                                            dr("colIPODOSE_CONT") = 0
                                                            GV30.SetFocusedRowCellValue(colIPODOSE_VOL_CONT, 0)
                                                            dr("colIPODOSE_VOL_CONT") = 0
                                                            GV30.SetFocusedRowCellValue(colIPODOSE_VOL_CONT_UNIT, 0)
                                                            dr("colIPODOSE_VOL_CONT_UNIT") = 0

                                                        End If


                                                        GV30.SetFocusedRowCellValue(colIPODOSE_SP_CIPUCD, ClsSP.GetCodeVirtuel(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)))
                                                        dr("colIPODOSE_SP_CIPUCD") = ClsSP.GetCodeVirtuel(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))

                                                        Dim dtPoso As DataTable
                                                        dtPoso = PoSoDose.GetPosoBySpec(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))

                                                        Dim dtRows As DataTable
                                                        dtRows = New DataTable("PosoCalculed")
                                                        Dim colUCD_PARJOUR_MAX As DataColumn = New DataColumn("colUCD_PARJOUR_MAX")
                                                        colUCD_PARJOUR_MAX.DataType = System.Type.GetType("System.Decimal")
                                                        dtRows.Columns.Add(colUCD_PARJOUR_MAX)

                                                        Dim colUCD_PARJOUR_MIN As DataColumn = New DataColumn("colUCD_PARJOUR_MIN")
                                                        colUCD_PARJOUR_MIN.DataType = System.Type.GetType("System.Decimal")
                                                        dtRows.Columns.Add(colUCD_PARJOUR_MIN)

                                                        Dim colUCD_PARPRISE_MAX As DataColumn = New DataColumn("colUCD_PARPRISE_MAX")
                                                        colUCD_PARPRISE_MAX.DataType = System.Type.GetType("System.Decimal")
                                                        dtRows.Columns.Add(colUCD_PARPRISE_MAX)

                                                        Dim colUCD_PARPRISE_MIN As DataColumn = New DataColumn("colUCD_PARPRISE_MIN")
                                                        colUCD_PARPRISE_MIN.DataType = System.Type.GetType("System.Decimal")
                                                        dtRows.Columns.Add(colUCD_PARPRISE_MIN)

                                                        Dim testNiveau3 As Boolean = True

                                                        For PosoCount As Integer = 0 To dtPoso.Rows.Count - 1
                                                            Dim dtPosoInfo As DataTable
                                                            dtPosoInfo = PoSoDose.GetPosoInfoByCode(dtPoso.Rows(PosoCount)(0))
                                                            For PosoInfoCount As Integer = 0 To dtPosoInfo.Rows.Count - 1
                                                                PoSoDose.UnitePrise_PP = dtPosoInfo.Rows(PosoInfoCount)("IPO_CDF_UNPO_CODE_FK")

                                                                If (Not PoSoDose.UnitePrise_PP(PoSoDose.UnitePrise_PP.Length - 4).ToString().ToLower().Equals("z")) Then
                                                                    testNiveau3 = False
                                                                End If

                                                                If dtPosoInfo.Rows(PosoInfoCount)("IPO_DOSEMIN") IsNot DBNull.Value Then
                                                                    Dim a As Array = dtPosoInfo.Rows(PosoInfoCount)("IPO_DOSEMIN").ToString().Split("/")
                                                                    If (a.Length = 2) Then
                                                                        PoSoDose.DoseMin = a(0) / a(1)
                                                                    Else
                                                                        If (Not a(0).ToString().Equals(".")) Then
                                                                            PoSoDose.DoseMin = a(0)
                                                                        Else
                                                                            PoSoDose.DoseMin = Nothing
                                                                        End If

                                                                    End If
                                                                Else
                                                                    PoSoDose.DoseMin = Nothing
                                                                End If

                                                                If dtPosoInfo.Rows(PosoInfoCount)("IPO_DOSEMAX") IsNot DBNull.Value Then
                                                                    Dim a As Array = dtPosoInfo.Rows(PosoInfoCount)("IPO_DOSEMAX").ToString().Split("/")
                                                                    If (a.Length = 2) Then
                                                                        PoSoDose.DoseMax = a(0) / a(1)
                                                                    Else
                                                                        If (Not a(0).ToString().Equals(".")) Then
                                                                            PoSoDose.DoseMax = a(0)
                                                                        Else
                                                                            PoSoDose.DoseMax = Nothing
                                                                        End If

                                                                    End If

                                                                Else
                                                                    PoSoDose.DoseMax = Nothing
                                                                End If

                                                                If dtPosoInfo.Rows(PosoInfoCount)("IPO_FREQMIN") IsNot DBNull.Value Then
                                                                    If Not dtPosoInfo.Rows(PosoInfoCount)("IPO_FREQMIN").ToString().Trim().Equals(".") And Not String.IsNullOrEmpty(dtPosoInfo.Rows(PosoInfoCount)("IPO_FREQMIN")) Then
                                                                        PoSoDose.FrequenceMin = dtPosoInfo.Rows(PosoInfoCount)("IPO_FREQMIN")
                                                                    Else
                                                                        PoSoDose.FrequenceMin = Nothing
                                                                    End If
                                                                Else
                                                                    PoSoDose.FrequenceMin = Nothing
                                                                End If

                                                                If dtPosoInfo.Rows(PosoInfoCount)("IPO_FREQMAX") IsNot DBNull.Value Then
                                                                    If Not dtPosoInfo.Rows(PosoInfoCount)("IPO_FREQMAX").ToString().Trim().Equals(".") And Not String.IsNullOrEmpty(dtPosoInfo.Rows(PosoInfoCount)("IPO_FREQMAX")) Then
                                                                        If (IsNumeric(dtPosoInfo.Rows(PosoInfoCount)("IPO_FREQMAX"))) Then
                                                                            PoSoDose.FrequenceMax = dtPosoInfo.Rows(PosoInfoCount)("IPO_FREQMAX")
                                                                        Else
                                                                            PoSoDose.FrequenceMax = Nothing
                                                                        End If
                                                                    Else
                                                                        PoSoDose.FrequenceMax = Nothing
                                                                    End If
                                                                Else
                                                                    PoSoDose.FrequenceMax = Nothing
                                                                End If

                                                                If dtPosoInfo.Rows(PosoInfoCount)("IPO_CDF_FREQMAX_CODE_FK") IsNot DBNull.Value Then
                                                                    PoSoDose.UniteFrequenceMax = dtPosoInfo.Rows(PosoInfoCount)("IPO_CDF_FREQMAX_CODE_FK")
                                                                Else
                                                                    PoSoDose.UniteFrequenceMax = Nothing
                                                                End If

                                                                If dtPosoInfo.Rows(PosoInfoCount)("IPO_CDF_FREQMIN_CODE_FK") IsNot DBNull.Value Then
                                                                    PoSoDose.UniteFrequenceMin = dtPosoInfo.Rows(PosoInfoCount)("IPO_CDF_FREQMIN_CODE_FK")
                                                                Else
                                                                    PoSoDose.UniteFrequenceMin = Nothing
                                                                End If
                                                                'On prend juste le premier élement (CIP) code PRE
                                                                PoSoDose.PRE_CODE = dtPre.Rows(0)("PRE_CODE_PK")

                                                                If (dtContenant.Rows(0)("PRECONT_NBCONTENANCE") IsNot Nothing And dtContenant.Rows(0)("PRECONT_NBCONTENANCE") IsNot System.DBNull.Value) Then
                                                                    NbContenance0 = dtContenant.Rows(0)("PRECONT_NBCONTENANCE")
                                                                Else
                                                                    NbContenance0 = 0
                                                                End If

                                                                PoSoDose.ExecuteDoseparPriseMonoVirtuelle(0, NbContenance0, NbContenance0)
                                                                PoSoDose.ExecuteDoseparJourMonoVirtuelle(0, NbContenance0, NbContenance0)
                                                                Dim d As DataRow
                                                                d = dtRows.NewRow()

                                                                d("colUCD_PARJOUR_MAX") = PoSoDose.UCD_PARJOUR_MAX.Valeur
                                                                d("colUCD_PARJOUR_MIN") = PoSoDose.UCD_PARJOUR_MIN.Valeur
                                                                d("colUCD_PARPRISE_MAX") = PoSoDose.UCD_PARPRISE_MAX.Valeur
                                                                d("colUCD_PARPRISE_MIN") = PoSoDose.UCD_PARPRISE_MIN.Valeur
                                                                dtRows.Rows.Add(d)
                                                            Next
                                                        Next
                                                        temp = "0"

                                                        If (Not preremplissage) Then
                                                            testNiveau3 = True
                                                        End If

                                                        If (testNiveau3) Then temp = String.Format("{0:n5}", PoSoDose.Get_MAX(dtRows, "colUCD_PARJOUR_MAX"))
                                                        GV30.SetFocusedRowCellValue(colIPODOSE_DJMAX, temp)
                                                        dr("colIPODOSE_DJMAX") = temp
                                                        If (testNiveau3) Then temp = String.Format("{0:n5}", PoSoDose.Get_MIN(dtRows, "colUCD_PARJOUR_MIN"))
                                                        GV30.SetFocusedRowCellValue(colIPODOSE_DJMIN, temp)
                                                        If (testNiveau3) Then temp = String.Format("{0:n5}", PoSoDose.Get_MAX(dtRows, "colUCD_PARPRISE_MAX"))
                                                        GV30.SetFocusedRowCellValue(colIPODOSE_DPMAX, temp)
                                                        dr("colIPODOSE_DPMAX") = temp
                                                        If (testNiveau3) Then temp = String.Format("{0:n5}", PoSoDose.Get_MIN(dtRows, "colUCD_PARPRISE_MIN"))
                                                        GV30.SetFocusedRowCellValue(colIPODOSE_DPMIN, temp)
                                                        dr("colIPODOSE_DPMIN") = temp

                                                        dtUCD = cn.MySelect("SELECT DISTINCT PRE_NATUCD_CDF_CODE_FK, PRE_NATUCD_CDF_NUM_FK FROM THERIAQUE.PRE_PRESENTATION WHERE PRE_SP_CODE_FK = " & cn.SQLText(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)))
                                                        If dtUCD.Rows.Count = 1 Then
                                                            GV30.SetFocusedRowCellValue(colIPODOSE_NATUCD_CDF_CODE_FK, dtUCD.Rows(0)("PRE_NATUCD_CDF_CODE_FK"))
                                                            dr("colIPODOSE_NATUCD_CDF_CODE_FK") = dtUCD.Rows(0)("PRE_NATUCD_CDF_CODE_FK")
                                                            GV30.SetFocusedRowCellValue(colIPODOSE_NATUCD_CDF_NUM_FK, dtUCD.Rows(0)("PRE_NATUCD_CDF_NUM_FK"))
                                                            dr("colIPODOSE_NATUCD_CDF_NUM_FK") = dtUCD.Rows(0)("PRE_NATUCD_CDF_NUM_FK")
                                                        Else
                                                            GV30.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_CODE_FK, "NON APPLICABLE")
                                                            dr("colIPOJ_NATUCD_CDF_CODE_FK") = "NON APPLICABLE"
                                                        End If
                                                        dtP.Rows.Add(dr)
                                                        'todo
                                                        EmpecherCalcul(dtTemp, maxSec)
                                                    Else 'Dans le cas de plusieurs contenant

                                                        For countContenant As Integer = 0 To dtContenant.Rows.Count - 1
                                                            Dim PoSoDose As New ClsPosologieDose

                                                            If (maxSec = -1) Then
                                                                If (cmp = 0) Then
                                                                    maxSec = Sec + 1
                                                                    cmp = 1
                                                                End If
                                                            Else
                                                                If (cmp = 1) Then
                                                                    maxSec += 1
                                                                End If
                                                            End If

                                                            GV30.AddNewRow()
                                                            dr = dtP.NewRow()
                                                            NewCalculation = True
                                                            GV30.SetFocusedRowCellValue(colIPODOSE_FPO_CODE_FK_PK, txtCode.Text)
                                                            dr("colIPODOSE_FPO_CODE_FK_PK") = txtCode.Text
                                                            codeMax = Code_MAx(GV30, colIPODOSE_NUM_SEQ_PK)
                                                            GV30.SetFocusedRowCellValue(colIPODOSE_NUM_SEQ_PK, maxSec) 'codeMax)
                                                            dr("colIPODOSE_NUM_SEQ_PK") = maxSec 'codeMax
                                                            codeMax = Code_MAx(GV30, colIPODOSE_NUM_ORD)
                                                            GV30.SetFocusedRowCellValue(colIPODOSE_NUM_ORD, codeMax)
                                                            dr("colIPODOSE_NUM_ORD") = codeMax
                                                            GV30.SetFocusedRowCellValue(colIPODOSE_SP_CODE_FK_PK, GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))
                                                            dr("colIPODOSE_SP_CODE_FK_PK") = GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)

                                                            If (dtPre.Rows(0)("PRE_NATUCD_CDF_NUM_FK") IsNot System.DBNull.Value) Then
                                                                If dtPre.Rows(0)("PRE_NATUCD_CDF_NUM_FK") = "04" Then

                                                                    GV30.SetFocusedRowCellValue(colIPODOSE_CONT, dtContenant.Rows(countContenant)("PRECONT_CDF_COCDT_CODE_FK"))
                                                                    dr("colIPODOSE_CONT") = dtContenant.Rows(countContenant)("PRECONT_CDF_COCDT_CODE_FK")
                                                                    GV30.SetFocusedRowCellValue(colIPODOSE_VOL_CONT, dtContenant.Rows(countContenant)("PRECONT_NBCONTENANCE"))
                                                                    dr("colIPODOSE_VOL_CONT") = dtContenant.Rows(countContenant)("PRECONT_NBCONTENANCE")
                                                                    GV30.SetFocusedRowCellValue(colIPODOSE_VOL_CONT_UNIT, dtContenant.Rows(countContenant)("PRECONT_CDF_COCE_CODE_FK"))
                                                                    dr("colIPODOSE_VOL_CONT_UNIT") = dtContenant.Rows(countContenant)("PRECONT_CDF_COCE_CODE_FK")

                                                                Else

                                                                    GV30.SetFocusedRowCellValue(colIPODOSE_CONT, 0)
                                                                    dr("colIPODOSE_CONT") = 0
                                                                    GV30.SetFocusedRowCellValue(colIPODOSE_VOL_CONT, 0)
                                                                    dr("colIPODOSE_VOL_CONT") = 0
                                                                    GV30.SetFocusedRowCellValue(colIPODOSE_VOL_CONT_UNIT, 0)
                                                                    dr("colIPODOSE_VOL_CONT_UNIT") = 0

                                                                End If
                                                            Else
                                                                GV30.SetFocusedRowCellValue(colIPODOSE_CONT, 0)
                                                                dr("colIPODOSE_CONT") = 0
                                                                GV30.SetFocusedRowCellValue(colIPODOSE_VOL_CONT, 0)
                                                                dr("colIPODOSE_VOL_CONT") = 0
                                                                GV30.SetFocusedRowCellValue(colIPODOSE_VOL_CONT_UNIT, 0)
                                                                dr("colIPODOSE_VOL_CONT_UNIT") = 0
                                                            End If

                                                            GV30.SetFocusedRowCellValue(colIPODOSE_SP_CIPUCD, ClsSP.GetCodeVirtuel(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)))
                                                            dr("colIPODOSE_SP_CIPUCD") = ClsSP.GetCodeVirtuel(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))

                                                            Dim dtPoso As DataTable
                                                            dtPoso = PoSoDose.GetPosoBySpec(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))

                                                            Dim dtRows As DataTable
                                                            dtRows = New DataTable("PosoCalculed")
                                                            Dim colUCD_PARJOUR_MAX As DataColumn = New DataColumn("colUCD_PARJOUR_MAX")
                                                            colUCD_PARJOUR_MAX.DataType = System.Type.GetType("System.Decimal")
                                                            dtRows.Columns.Add(colUCD_PARJOUR_MAX)

                                                            Dim colUCD_PARJOUR_MIN As DataColumn = New DataColumn("colUCD_PARJOUR_MIN")
                                                            colUCD_PARJOUR_MIN.DataType = System.Type.GetType("System.Decimal")
                                                            dtRows.Columns.Add(colUCD_PARJOUR_MIN)

                                                            Dim colUCD_PARPRISE_MAX As DataColumn = New DataColumn("colUCD_PARPRISE_MAX")
                                                            colUCD_PARPRISE_MAX.DataType = System.Type.GetType("System.Decimal")
                                                            dtRows.Columns.Add(colUCD_PARPRISE_MAX)

                                                            Dim colUCD_PARPRISE_MIN As DataColumn = New DataColumn("colUCD_PARPRISE_MIN")
                                                            colUCD_PARPRISE_MIN.DataType = System.Type.GetType("System.Decimal")
                                                            dtRows.Columns.Add(colUCD_PARPRISE_MIN)

                                                            Dim testNiveau3 As Boolean = True

                                                            For PosoCount As Integer = 0 To dtPoso.Rows.Count - 1
                                                                Dim dtPosoInfo As DataTable
                                                                dtPosoInfo = PoSoDose.GetPosoInfoByCode(dtPoso.Rows(PosoCount)(0))
                                                                For PosoInfoCount As Integer = 0 To dtPosoInfo.Rows.Count - 1
                                                                    PoSoDose.UnitePrise_PP = dtPosoInfo.Rows(PosoInfoCount)("IPO_CDF_UNPO_CODE_FK")

                                                                    If (Not PoSoDose.UnitePrise_PP(PoSoDose.UnitePrise_PP.Length - 4).ToString().ToLower().Equals("z")) Then
                                                                        testNiveau3 = False
                                                                    End If

                                                                    If dtPosoInfo.Rows(PosoInfoCount)("IPO_DOSEMIN") IsNot DBNull.Value Then
                                                                        Dim a As Array = dtPosoInfo.Rows(PosoInfoCount)("IPO_DOSEMIN").ToString().Split("/")
                                                                        If (a.Length = 2) Then
                                                                            PoSoDose.DoseMin = a(0) / a(1)
                                                                        Else
                                                                            If (Not a(0).ToString().Equals(".")) Then
                                                                                PoSoDose.DoseMin = a(0)
                                                                            Else
                                                                                PoSoDose.DoseMin = Nothing
                                                                            End If

                                                                        End If
                                                                        'PoSoDoseDose.DoseMin = dtPoSoDoseInfo.Rows(PoSoDoseInfoCount)("IPO_DOSEMIN")
                                                                    Else
                                                                        If PoSoDose.DoseMin IsNot Nothing Then
                                                                            PoSoDose.DoseMin = Nothing
                                                                        End If
                                                                    End If

                                                                    If dtPosoInfo.Rows(PosoInfoCount)("IPO_DOSEMAX") IsNot DBNull.Value Then
                                                                        Dim a As Array = dtPosoInfo.Rows(PosoInfoCount)("IPO_DOSEMAX").ToString().Split("/")
                                                                        If (a.Length = 2) Then
                                                                            PoSoDose.DoseMax = a(0) / a(1)
                                                                        Else
                                                                            If (Not a(0).ToString().Equals(".")) Then
                                                                                PoSoDose.DoseMax = a(0)
                                                                            Else
                                                                                PoSoDose.DoseMax = Nothing
                                                                            End If

                                                                        End If
                                                                        'PoSoDoseDose.DoseMax = dtPoSoDoseInfo.Rows(PoSoDoseInfoCount)("IPO_DoseMax")
                                                                    Else
                                                                        If PoSoDose.DoseMax IsNot Nothing Then
                                                                            PoSoDose.DoseMax = Nothing
                                                                        End If
                                                                    End If

                                                                    'If dtPosoInfo.Rows(PosoInfoCount)("IPO_DOSEMIN") IsNot DBNull.Value Then
                                                                    '    PoSoDose.DoseMin = dtPosoInfo.Rows(PosoInfoCount)("IPO_DOSEMIN")
                                                                    'Else
                                                                    '    PoSoDose.DoseMin = Nothing
                                                                    'End If

                                                                    'If dtPosoInfo.Rows(PosoInfoCount)("IPO_DOSEMAX") IsNot DBNull.Value Then
                                                                    '    PoSoDose.DoseMax = dtPosoInfo.Rows(PosoInfoCount)("IPO_DOSEMAX")
                                                                    'Else
                                                                    '    PoSoDose.DoseMax = Nothing
                                                                    'End If

                                                                    If dtPosoInfo.Rows(PosoInfoCount)("IPO_FREQMIN") IsNot DBNull.Value Then
                                                                        If (Not dtPosoInfo.Rows(PosoInfoCount)("IPO_FREQMIN").ToString().Equals(".")) Then
                                                                            PoSoDose.FrequenceMin = dtPosoInfo.Rows(PosoInfoCount)("IPO_FREQMIN")
                                                                        Else
                                                                            PoSoDose.FrequenceMin = Nothing
                                                                        End If
                                                                    Else
                                                                        PoSoDose.FrequenceMin = Nothing
                                                                    End If

                                                                    If dtPosoInfo.Rows(PosoInfoCount)("IPO_FREQMAX") IsNot DBNull.Value Then
                                                                        If (Not dtPosoInfo.Rows(PosoInfoCount)("IPO_FREQMAX").ToString().Equals(".")) Then
                                                                            PoSoDose.FrequenceMax = dtPosoInfo.Rows(PosoInfoCount)("IPO_FREQMAX")
                                                                        Else
                                                                            PoSoDose.FrequenceMax = Nothing
                                                                        End If
                                                                    Else
                                                                        PoSoDose.FrequenceMax = Nothing
                                                                    End If

                                                                    If dtPosoInfo.Rows(PosoInfoCount)("IPO_CDF_FREQMAX_CODE_FK") IsNot DBNull.Value Then
                                                                        PoSoDose.UniteFrequenceMax = dtPosoInfo.Rows(PosoInfoCount)("IPO_CDF_FREQMAX_CODE_FK")
                                                                    Else
                                                                        PoSoDose.UniteFrequenceMax = Nothing
                                                                    End If
                                                                    If dtPosoInfo.Rows(PosoInfoCount)("IPO_CDF_FREQMIN_CODE_FK") IsNot DBNull.Value Then
                                                                        PoSoDose.UniteFrequenceMin = dtPosoInfo.Rows(PosoInfoCount)("IPO_CDF_FREQMIN_CODE_FK")
                                                                    Else
                                                                        PoSoDose.UniteFrequenceMin = Nothing
                                                                    End If

                                                                    'On prend juste le premier élement (CIP) code PRE
                                                                    PoSoDose.PRE_CODE = dtPre.Rows(0)("PRE_CODE_PK")

                                                                    If (dtContenant.Rows(countContenant)("PRECONT_NBCONTENANCE") IsNot Nothing And dtContenant.Rows(countContenant)("PRECONT_NBCONTENANCE") IsNot System.DBNull.Value) Then
                                                                        NbContenanceI = dtContenant.Rows(countContenant)("PRECONT_NBCONTENANCE")
                                                                    Else
                                                                        NbContenanceI = 0
                                                                    End If

                                                                    If (dtContenant.Rows(0)("PRECONT_NBCONTENANCE") IsNot Nothing And dtContenant.Rows(0)("PRECONT_NBCONTENANCE") IsNot System.DBNull.Value) Then

                                                                        NbContenance0 = dtContenant.Rows(0)("PRECONT_NBCONTENANCE")

                                                                    Else
                                                                        NbContenance0 = 0
                                                                    End If



                                                                    'VContenance0 = ""
                                                                    'If (dtPosoInfo.Rows(PosoInfoCount)("IPO_CDF_UNPO_CODE_FK").ToString().StartsWith("E")) Then
                                                                    '    VContenance0 = "E"
                                                                    'End If

                                                                    PoSoDose.ExecuteDoseparPriseMonoVirtuelle(countContenant, NbContenance0, NbContenanceI)
                                                                    PoSoDose.ExecuteDoseparJourMonoVirtuelle(countContenant, NbContenance0, NbContenanceI)

                                                                    Dim d As DataRow
                                                                    d = dtRows.NewRow()
                                                                    d("colUCD_PARJOUR_MAX") = PoSoDose.UCD_PARJOUR_MAX.Valeur
                                                                    d("colUCD_PARJOUR_MIN") = PoSoDose.UCD_PARJOUR_MIN.Valeur
                                                                    d("colUCD_PARPRISE_MAX") = PoSoDose.UCD_PARPRISE_MAX.Valeur
                                                                    d("colUCD_PARPRISE_MIN") = PoSoDose.UCD_PARPRISE_MIN.Valeur
                                                                    dtRows.Rows.Add(d)

                                                                Next
                                                            Next

                                                            temp = "0"
                                                            If (Not preremplissage) Then
                                                                testNiveau3 = True
                                                            End If

                                                            If (testNiveau3) Then temp = String.Format("{0:n5}", PoSoDose.Get_MAX(dtRows, "colUCD_PARJOUR_MAX"))
                                                            GV30.SetFocusedRowCellValue(colIPODOSE_DJMAX, temp)
                                                            dr("colIPODOSE_DJMAX") = temp
                                                            If (testNiveau3) Then temp = String.Format("{0:n5}", PoSoDose.Get_MIN(dtRows, "colUCD_PARJOUR_MIN"))
                                                            GV30.SetFocusedRowCellValue(colIPODOSE_DJMIN, temp)
                                                            dr("colIPODOSE_DJMIN") = temp
                                                            If (testNiveau3) Then temp = String.Format("{0:n5}", PoSoDose.Get_MAX(dtRows, "colUCD_PARPRISE_MAX"))
                                                            GV30.SetFocusedRowCellValue(colIPODOSE_DPMAX, temp)
                                                            dr("colIPODOSE_DPMAX") = temp
                                                            If (testNiveau3) Then temp = String.Format("{0:n5}", PoSoDose.Get_MIN(dtRows, "colUCD_PARPRISE_MIN"))
                                                            GV30.SetFocusedRowCellValue(colIPODOSE_DPMIN, temp)
                                                            dr("colIPODOSE_DPMIN") = temp

                                                            dtUCD = cn.MySelect("SELECT DISTINCT PRE_NATUCD_CDF_CODE_FK, PRE_NATUCD_CDF_NUM_FK FROM THERIAQUE.PRE_PRESENTATION WHERE PRE_SP_CODE_FK = " & cn.SQLText(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)) & " and (PRE_NATUCD_CDF_CODE_FK <> '' and PRE_NATUCD_CDF_NUM_FK <> '' )")
                                                            If dtUCD.Rows.Count = 1 Then
                                                                GV30.SetFocusedRowCellValue(colIPODOSE_NATUCD_CDF_CODE_FK, dtUCD.Rows(0)("PRE_NATUCD_CDF_CODE_FK"))
                                                                dr("colIPODOSE_NATUCD_CDF_CODE_FK") = dtUCD.Rows(0)("PRE_NATUCD_CDF_CODE_FK")
                                                                GV30.SetFocusedRowCellValue(colIPODOSE_NATUCD_CDF_NUM_FK, dtUCD.Rows(0)("PRE_NATUCD_CDF_NUM_FK"))
                                                                dr("colIPODOSE_NATUCD_CDF_NUM_FK") = dtUCD.Rows(0)("PRE_NATUCD_CDF_NUM_FK")
                                                            Else
                                                                GV30.SetFocusedRowCellValue(colIPOJ_NATUCD_CDF_CODE_FK, "NON APPLICABLE")
                                                                dr("colIPODOSE_NATUCD_CDF_CODE_FK") = "NON APPLICABLE"
                                                            End If
                                                            dtP.Rows.Add(dr)
                                                            'todo
                                                            EmpecherCalcul(dtTemp, maxSec)
                                                        Next

                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    Next

                    'Elimination des doublons 
                    Dim keyDelete As String = ""

                    For i As Integer = 0 To dtP.Rows.Count - 1
                        'colIPOJ_CONT

                        If Not dtP.Rows(i).Item("colIPODOSE_CONT").Equals("60") Then

                            For j As Integer = i + 1 To dtP.Rows.Count - 1
                                'colIPODOSE_CONT
                                'If dtP.Rows(j).Item("colIPODOSE_CONT") <> 60 Then
                                If dtP.Rows(j).Item("colIPODOSE_CONT").Equals(dtP.Rows(i).Item("colIPODOSE_CONT")) Then
                                    'colIPODOSE_SP_CIPUCD
                                    If dtP.Rows(i).Item("colIPODOSE_SP_CIPUCD").Equals(dtP.Rows(j).Item("colIPODOSE_SP_CIPUCD")) Then
                                        'colIPODOSE_DJMIN
                                        If dtP.Rows(i).Item("colIPODOSE_VOL_CONT").Equals(dtP.Rows(j).Item("colIPODOSE_VOL_CONT")) Then
                                            'colIPODOSE_DJMAX
                                            If dtP.Rows(i).Item("colIPODOSE_VOL_CONT_UNIT").Equals(dtP.Rows(j).Item("colIPODOSE_VOL_CONT_UNIT")) Then
                                                keyDelete &= dtP.Rows(i).Item("colIPODOSE_NUM_ORD") & "_" & dtP.Rows(i).Item("colIPODOSE_NUM_SEQ_PK") & "_" & dtP.Rows(i).Item("colIPODOSE_FPO_CODE_FK_PK") & ";"
                                            End If
                                        End If
                                    End If
                                End If
                            Next

                        End If

                    Next

                    If (Not keyDelete.Equals("")) Then

                        Dim s As String = ""
                        Dim b As Boolean = False
                        While (Not b)
                            b = True
                            For i As Integer = 0 To GV30.RowCount - 1
                                If GV30.GetDataRow(i) IsNot Nothing Then
                                    s = GV30.GetDataRow(i).Item("IPODOSE_NUM_ORD") & "_" & GV30.GetDataRow(i).Item("IPODOSE_NUM_SEQ_PK") & "_" & GV30.GetDataRow(i).Item("IPODOSE_FPO_CODE_FK_PK")
                                    If keyDelete.Contains(s) Then
                                        GV30.DeleteRow(i)
                                        b = False
                                        Exit For
                                    End If
                                End If
                            Next
                        End While

                    End If




                    'For i As Integer = 0 To GV30.RowCount - 1

                    '    If GV30.GetDataRow(i) IsNot Nothing Then

                    '        For j As Integer = 0 To dtTemp.Rows.Count - 1

                    '            If GV30.GetDataRow(i)("IPODOSE_NUM_SEQ_PK") = dtTemp.Rows(j).Item("colIPODOSE_NUM_SEQ_PK") And dtTemp.Rows(j).Item("colCalcul") = True Then

                    '                For jj As Integer = 0 To GV30.Columns.Count - 1
                    '                    'GV30.SetRowCellValue(i, GV30.Columns(jj).Name, dtTemp.Rows(j).Item(GV30.Columns(jj).Name))
                    '                    GV30.GetDataRow(i).Item(GV30.Columns(jj).FieldName) = dtTemp.Rows(j).Item(GV30.Columns(jj).Name)
                    '                Next

                    '            End If

                    '        Next
                    '    End If
                    'Next

                    'If (Not keyDelete.Equals("")) Then

                    '    Dim s As String = ""
                    '    Dim b As Boolean = False
                    '    While (Not b)
                    '        b = True
                    '        For i As Integer = 0 To dtP.Rows.Count - 1

                    '            s = dtP.Rows(i).Item("colIPODOSE_NUM_ORD") & "_" & dtP.Rows(i).Item("colIPODOSE_NUM_SEQ_PK") & "_" & dtP.Rows(i).Item("colIPODOSE_FPO_CODE_FK_PK")
                    '            If keyDelete.Contains(s) Then
                    '                dtP.Rows(i).Delete()
                    '                b = False
                    '                Exit For
                    '            End If

                    '        Next
                    '    End While

                    'End If

                    'Dim len1 As Integer = GV30.RowCount
                    'Dim ii1 As Integer = 0
                    'While (ii1 < len1)
                    '    GV30.DeleteRow(0)
                    '    ii1 += 1
                    'End While

                    'For i As Integer = 0 To dtP.Rows.Count - 1


                    '    For j As Integer = 0 To dtP.Columns.Count - 1
                    '        GV30.SetFocusedRowCellValue(GV30.Columns(j), dtP.Rows(i).Item(j))
                    '    Next

                    '    If (i < dtP.Rows.Count - 1) Then
                    '        GV30.AddNewRow()
                    '    End If

                    'Next

                    ProgressBar.Visible = False

                End If
            End If


            If e.Button.ImageIndex = 11 Then
                If Process_Message(strExport, MessageBoxButtons.YesNo, MessageBoxIcon.Question).BtResult = MsgBoxResult.Yes Then
                    If GV30.RowCount > 1 Then
                        Dim sPath As String
                        SFDialogEnregistrer.Title = "Choisir un emplacement pour enregistrer le fichier Excel."
                        SFDialogEnregistrer.InitialDirectory = "c:\"
                        SFDialogEnregistrer.Filter = "Fichiers Excel (*.xls)|*.xls"
                        SFDialogEnregistrer.FilterIndex = 2
                        SFDialogEnregistrer.RestoreDirectory = True
                        If SFDialogEnregistrer.ShowDialog() = DialogResult.OK Then
                            sPath = SFDialogEnregistrer.FileName

                            Dim oExcel As New Microsoft.Office.Interop.Excel.Application
                            Dim oBook As Microsoft.Office.Interop.Excel.Workbook
                            Dim oSheet As Microsoft.Office.Interop.Excel.Worksheet

                            oBook = oExcel.Workbooks.Add
                            oSheet = oBook.Sheets(1)

                            'DEFINITION DES EN-TETE DE COLONNES
                            oSheet.Cells(1, 1) = "N°"
                            oSheet.Cells(1, 2) = "UCD"
                            oSheet.Cells(1, 3) = "Dose par jour - Min"
                            oSheet.Cells(1, 4) = "Dose par jour - Max"
                            oSheet.Cells(1, 5) = "Dose par prise - Min"
                            oSheet.Cells(1, 6) = "Dose par prise - Max"
                            oSheet.Cells(1, 7) = "Nature UCD"

                            Dim sSQL As String
                            Dim dt As New DataTable
                            For iCount As Integer = 0 To GV30.RowCount - 1

                                oSheet.Cells(iCount + 2, 1) = GV30.GetRowCellDisplayText(iCount, colIPODOSE_NUM_SEQ_PK)
                                oSheet.Cells(iCount + 2, 2) = GV30.GetRowCellDisplayText(iCount, colIPODOSE_SP_CIPUCD)
                                oSheet.Cells(iCount + 2, 3) = GV30.GetRowCellDisplayText(iCount, colIPODOSE_DJMIN)
                                oSheet.Cells(iCount + 2, 4) = GV30.GetRowCellDisplayText(iCount, colIPODOSE_DJMAX)
                                oSheet.Cells(iCount + 2, 5) = GV30.GetRowCellDisplayText(iCount, colIPODOSE_DPMIN)
                                oSheet.Cells(iCount + 2, 6) = GV30.GetRowCellDisplayText(iCount, colIPODOSE_DPMAX)

                                If GV30.GetRowCellValue(iCount, colIPODOSE_NATUCD_CDF_NUM_FK) <> Nothing Then
                                    If GV30.GetRowCellValue(iCount, colIPODOSE_NATUCD_CDF_NUM_FK) IsNot DBNull.Value Then
                                        sSQL = " Select CDF_CODE_PK as code, CDF_NOM as libelle, CDF_NUMERO_PK as num  From THERIAQUE.CDF_CODIF  where CDF_NUMERO_PK = " & cn.SQLText(GV30.GetRowCellValue(iCount, colIPODOSE_NATUCD_CDF_NUM_FK))
                                        sSQL += " AND CDF_CODE_PK = " & GV30.GetRowCellValue(iCount, colIPODOSE_NATUCD_CDF_CODE_FK2)

                                        dt = cn.MySelect(sSQL)
                                        If dt.Rows.Count > 0 Then oSheet.Cells(iCount + 2, 7) = dt.Rows(0)("libelle")
                                    Else
                                        oSheet.Cells(iCount + 2, 7) = GV30.GetRowCellDisplayText(iCount, colIPODOSE_NATUCD_CDF_CODE_FK)
                                    End If
                                Else
                                    oSheet.Cells(iCount + 2, 7) = GV30.GetRowCellDisplayText(iCount, colIPODOSE_NATUCD_CDF_CODE_FK)
                                End If

                            Next

                            oBook.SaveAs(sPath)
                            oExcel.Visible = True
                        End If
                    End If
                End If
            End If
        End If
        On Error GoTo 0
    End Sub

    Private Sub EmpecherCalcul(ByVal dtTemp As DataTable, ByVal seqMax As Integer)

        For j As Integer = 0 To dtTemp.Rows.Count - 1

            'GV30.SetFocusedRowCellValue(GV30.Columns(0), dtTemp.Rows(j).Item(GV30.Columns(0).Name))

            If seqMax = dtTemp.Rows(j).Item("colIPODOSE_NUM_SEQ_PK") And dtTemp.Rows(j).Item("colCalcul") <> True Then
                GV30.SetFocusedRowCellValue(GV30.Columns(0), False)
                For jj As Integer = 1 To GV30.Columns.Count - 1
                    GV30.SetFocusedRowCellValue(GV30.Columns(jj), dtTemp.Rows(j).Item(GV30.Columns(jj).Name))
                Next
                Exit For
            Else
                'If seqMax = dtTemp.Rows(j).Item("colIPODOSE_NUM_SEQ_PK") Then
                GV30.SetFocusedRowCellValue(GV30.Columns(0), True)

                'End If
            End If

        Next

    End Sub

    'onglet durée in max
    Public Sub CalcDureeMinMax(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)

        'On Error Resume Next
        Dim codeSP As String
        Dim SP_UCDCIP As String
        Dim DureeMin As String
        Dim DureeMax As String
        Dim req As String
        Dim temp As String = ""
        Dim tempV As String = ""
        Dim exist As Boolean = False
        Dim CodeVirtuel As String = ""

        Dim MinCalcul As Boolean = False
        Dim MaxCalcul As Boolean = False
        Dim bMaxCalcul As Boolean = False
        Dim bMinCalcul As Boolean = False
        Dim PoSoDose As New ClsPosologieDose
        Dim code As String = "35030"



        If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.Custom Then
            If e.Button.ImageIndex = 12 Then
                If Process_Message(strAlgoDuree, MessageBoxButtons.YesNo, MessageBoxIcon.Question).BtResult = MsgBoxResult.Yes Then
                    Dim dtUCD As DataTable
                    For inti As Integer = 0 To GV31.RowCount - 1
                        GV31.DeleteRow(0)
                    Next


                    Dim len As Integer = GV30.RowCount
                    Dim ii As Integer = 0
                    While (ii < len)
                        GV31.DeleteRow(0)
                        ii += 1
                    End While

                    For inti As Integer = 0 To GV6.RowCount - 1 ' Spécialité


                        If (GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2) IsNot Nothing) Then
                            bMaxCalcul = IsMaxCalcul(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2), True)
                            bMinCalcul = IsMaxCalcul(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2), False)
                            'données Exploitables calcul ou non

                            Dim dtPoso As DataTable
                            dtPoso = PoSoDose.GetPosoBySpec(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))
                            For PosoCount As Integer = 0 To dtPoso.Rows.Count - 1
                                MaxCalcul = False
                                Dim dtPosoInfo As DataTable
                                dtPosoInfo = PoSoDose.GetPosoInfoByCode(dtPoso.Rows(PosoCount)(0))
                                For PosoInfoCount As Integer = 0 To dtPosoInfo.Rows.Count - 1
                                    If (dtPosoInfo.Rows(PosoInfoCount)("IPO_CDF_NAPO_CODE_FK") = "02" Or dtPosoInfo.Rows(PosoInfoCount)("IPO_CDF_NAPO_CODE_FK") = "01" Or dtPosoInfo.Rows(PosoInfoCount)("IPO_CDF_NAPO_CODE_FK") = "04") And dtPosoInfo.Rows(PosoInfoCount)("IPO_DUREEMAX") IsNot System.DBNull.Value Then
                                        MaxCalcul = True
                                        Exit For
                                    End If
                                Next
                                If Not MaxCalcul Then
                                    Exit For
                                End If
                            Next

                            For PosoCount As Integer = 0 To dtPoso.Rows.Count - 1
                                MinCalcul = False
                                Dim dtPosoInfo As DataTable
                                dtPosoInfo = PoSoDose.GetPosoInfoByCode(dtPoso.Rows(PosoCount)(0))
                                For PosoInfoCount As Integer = 0 To dtPosoInfo.Rows.Count - 1
                                    If dtPosoInfo.Rows(PosoInfoCount)("IPO_CDF_NAPO_CODE_FK") <> "02" And dtPosoInfo.Rows(PosoInfoCount)("IPO_DUREEMIN") IsNot System.DBNull.Value Then
                                        MinCalcul = True
                                        Exit For
                                    End If
                                Next
                                If Not MinCalcul Then
                                    Exit For
                                End If
                            Next



                            If (GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2) IsNot Nothing) Then

                                codeSP = GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2).ToString()
                                If Not IsMonographie(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2)) Then
                                    SP_UCDCIP = ClsSP.GetCIPUCD(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))

                                    exist = False
                                    Dim sparray As String() = temp.Split("||")

                                    For i As Integer = 0 To sparray.Length - 1
                                        If (sparray(i) = SP_UCDCIP) Then
                                            exist = True
                                            Exit For
                                        End If
                                    Next

                                    If (Not exist) Then
                                        'Max Calcul indication 
                                        temp += "||" + SP_UCDCIP
                                        DureeMin = ClsPosologie.GetDureeMin(SP_UCDCIP)
                                        DureeMax = ClsPosologie.GetDureeMax(SP_UCDCIP)
                                        GV31.AddNewRow()
                                        NewDuration = True
                                        GV31.SetFocusedRowCellValue(colIPODUREE_FPO_CODE_PK_FK, txtCode.Text)
                                        GV31.SetFocusedRowCellValue(colIPODUREE_SP_CODE_SQ_PK_FK, codeSP)
                                        GV31.SetFocusedRowCellValue(colIPODUREE_SP_CIPUCD, SP_UCDCIP)

                                        If (MinCalcul And bMinCalcul) Or code.Equals(txtCode.Text) Then
                                            GV31.SetFocusedRowCellValue(colIPODUREE_DUREE_MIN, DureeMin)
                                        End If

                                        If (MaxCalcul And bMaxCalcul) Or code.Equals(txtCode.Text) Then
                                            GV31.SetFocusedRowCellValue(colIPODUREE_DUREE_MAX, DureeMax)
                                        End If

                                    End If

                                Else
                                    CodeVirtuel = ClsSP.GetCodeVirtuel(GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2))
                                    If CodeVirtuel <> "" Then
                                        exist = False
                                        Dim sparrayV As String() = tempV.Split("||")

                                        For i As Integer = 0 To sparrayV.Length - 1

                                            If (sparrayV(i) = CodeVirtuel) Then
                                                exist = True
                                                Exit For
                                            End If
                                        Next

                                        If (Not exist) Then
                                            tempV += "||" + CodeVirtuel
                                            DureeMin = ClsPosologie.GetDureeMinVirtuelle(CodeVirtuel)
                                            DureeMax = ClsPosologie.GetDureeMaxVirtuelle(CodeVirtuel)
                                            GV31.AddNewRow()
                                            NewCalculation = True
                                            GV31.SetFocusedRowCellValue(colIPODUREE_FPO_CODE_PK_FK, txtCode.Text)
                                            GV31.SetFocusedRowCellValue(colIPODUREE_SP_CODE_SQ_PK_FK, codeSP)
                                            GV31.SetFocusedRowCellValue(colIPODUREE_SP_CIPUCD, CodeVirtuel)

                                            If (MinCalcul And bMinCalcul) Or code.Equals(txtCode.Text) Then
                                                GV31.SetFocusedRowCellValue(colIPODUREE_DUREE_MIN, DureeMin)
                                            End If

                                            If (MaxCalcul And bMaxCalcul) Or code.Equals(txtCode.Text) Then
                                                GV31.SetFocusedRowCellValue(colIPODUREE_DUREE_MAX, DureeMax)
                                            End If

                                        End If

                                    End If
                                End If

                            End If
                        End If
                    Next
                    ProgressBar.Visible = False
                End If
            End If
        End If

        On Error GoTo 0
    End Sub


    Private Function IsMaxCalcul(ByVal CodeSp As String, ByVal MaxOrMin As Boolean) As Boolean

        Dim dtIndication As DataTable
        Dim dtFPO As DataTable
        Dim dtIPO As DataTable
        Dim query As String
        Dim exist As Boolean

        query = " select FPOUT_CDF_UTPO_CODE_FK_PK from theriaque.FPOUT_FPOSO_UTILTH fpout, theriaque.FPOSP_POSO_SPE fposp "
        query &= " where fposp.FPOSP_FPO_CODE_FK_PK = fpout.FPOUT_FPO_CODE_FK_PK "
        query &= " and fposp.FPOSP_SP_CODE_FK_PK=" & CodeSp
        query &= " GROUP BY fpout.FPOUT_CDF_UTPO_CODE_FK_PK "
        query &= " order by FPOUT_CDF_UTPO_CODE_FK_PK "

        dtIndication = ClsPosologieDose.GetSPIndicationFPO(query)

        For Each dr As DataRow In dtIndication.Rows
            query = " select FPOUT_CDF_UTPO_CODE_FK_PK,FPOUT_FPO_CODE_FK_PK from theriaque.FPOUT_FPOSO_UTILTH fpout, theriaque.FPOSP_POSO_SPE fposp "
            query &= " where(fposp.FPOSP_FPO_CODE_FK_PK = fpout.FPOUT_FPO_CODE_FK_PK) "
            query &= " and fposp.FPOSP_SP_CODE_FK_PK=" & cn.SQLText(CodeSp)
            query &= " and FPOUT_CDF_UTPO_CODE_FK_PK =" & cn.SQLText(dr(0)) & " "
            query &= " GROUP BY fpout.FPOUT_CDF_UTPO_CODE_FK_PK,FPOUT_FPO_CODE_FK_PK "
            query &= " order by FPOUT_CDF_UTPO_CODE_FK_PK "

            dtFPO = ClsPosologieDose.GetSPIndicationFPO(query)

            exist = False
            For Each dr1 As DataRow In dtFPO.Rows
                If (MaxOrMin) Then
                    query = " select IPO_DUREEMAX from theriaque.IPO_INFOPOSO "
                Else
                    query = " select IPO_DUREEMIN from theriaque.IPO_INFOPOSO "
                End If

                query &= " where IPO_FPO_CODE_FK_PK = " & cn.SQLText(dr1(1))
                dtIPO = ClsPosologieDose.GetSPIndicationFPO(query)

                For Each dr2 As DataRow In dtIPO.Rows

                    If dr2(0) IsNot System.DBNull.Value Then
                        If (Not dr2(0).ToString().Equals(".")) Then
                            exist = True
                            Exit For
                        End If
                    End If

                Next

                If Not exist Then
                    Exit For
                End If

            Next

            If (Not exist) Then
                Exit For
            End If

        Next

        Return exist

    End Function

    Private Sub rpCheck_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rpCheck.CheckedChanged
        If Me.GV9.GetFocusedRowCellValue(colcheck1) <> 1 Then
            If GV6.RowCount = 0 Then Exit Sub
            Dim dt As New DataTable
            Dim OK As Boolean = False
            dt = cn.MySelect("select * from THERIAQUE.FINSP_INDSPE where FINSP_FIN_CODE_FK_PK = " & Me.GV9.GetFocusedRowCellValue(colFIN_CODE_SQ_PK))
            If dt.Rows.Count > 0 Then
                'Parcourir les SP de la fiche
                For inti As Integer = 0 To GV6.RowCount - 1
                    If GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2) IsNot Nothing Then
                        'Pacrourir les SP de la Nature d'indic
                        For intk As Integer = 0 To dt.Rows.Count - 1
                            OK = False
                            If GV6.GetRowCellValue(inti, colFPOSP_SP_CODE_FK_PK2) = dt.Rows(intk)("FINSP_SP_CODE_FK_PK") Then
                                OK = True
                                Exit For
                            End If
                        Next
                        If OK = False Then
                            Me.GV9.SetFocusedRowCellValue(colcheck1, 0)
                            Exit Sub
                        End If
                    End If
                Next
            End If
            For intl As Integer = 0 To GV10.RowCount - 1
                If GV10.GetRowCellValue(intl, colFPOUT_CDF_UTPO_CODE_FK_PK) = Me.GV9.GetFocusedRowCellValue(colFIN_CDF_NAIN_CODE_FK_PK) Then
                    Exit Sub
                End If
            Next
            GV10.AddNewRow()
            GV10.SetFocusedRowCellValue(colFPOUT_CDF_UTPO_CODE_FK_PK, Me.GV9.GetFocusedRowCellValue(colFIN_CDF_NAIN_CODE_FK_PK))
            Me.BindingContext(Me.MasterDataSet, FPOUT_FPOSO_UTILTH).EndCurrentEdit()
        Else
        End If
    End Sub

    Private Sub XtraTabControl1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraTabControl1.Resize
        Panel19.Height = (Panel20.Height + Panel19.Height) / 2
        Panel20.Height = (Panel20.Height + Panel19.Height) / 2
    End Sub

    Private Sub GV8_ValidatingEditor(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV8.ValidatingEditor
        If GV8.FocusedColumn Is colFPOTE_NUMORD Then
            If FieldExist(GV8, colFPOTE_NUMORD, e.Value) Then
                e.ErrorText = "Le numéro doit être unique."
                e.Value = Nothing
                e.Valid = False
            End If
        End If
    End Sub

    Private Sub GV_CalcRowHeight(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs) Handles GV12.CalcRowHeight
        e.RowHeight = sender.GridControl.Height
    End Sub

    Private Sub GV28_CustomDrawCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GV28.CustomDrawCell
        If (e.RowHandle >= 0) Then
            If e.Column Is colIPOJ_DTMIN Then
                If GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) IsNot DBNull.Value Then
                    If GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) <> Nothing Then
                        If GV28.GetRowCellValue(e.RowHandle, colIPOJ_DTMIN) Is DBNull.Value Then
                            e.DisplayText = "Non Applicable"
                        Else
                            If GV28.GetRowCellValue(e.RowHandle, colIPOJ_DTMIN) = 0 Then e.DisplayText = "Non Applicable"
                        End If
                    End If
                End If
            End If

            If e.Column Is colIPOJ_VOL_CONT Then
                If GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) IsNot DBNull.Value Then
                    If GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) <> Nothing Then
                        If GV28.GetRowCellValue(e.RowHandle, colIPOJ_VOL_CONT) Is DBNull.Value Then
                            e.DisplayText = "Non Applicable"
                        Else
                            If GV28.GetRowCellValue(e.RowHandle, colIPOJ_VOL_CONT) = 0 Then e.DisplayText = "Non Applicable"
                        End If
                    End If
                Else
                    e.DisplayText = "Non Applicable"
                End If
            End If

            If e.Column Is colIPOJ_CONT Then
                If GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) IsNot DBNull.Value Then
                    If GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) <> Nothing Then
                        If GV28.GetRowCellValue(e.RowHandle, colIPOJ_CONT) Is DBNull.Value Then
                            e.DisplayText = "Non Applicable"
                        Else
                            If GV28.GetRowCellValue(e.RowHandle, colIPOJ_CONT) = 0 Then e.DisplayText = "Non Applicable"
                        End If
                    End If
                Else
                    e.DisplayText = "Non Applicable"
                End If
            End If


            If e.Column Is colIPOJ_VOL_CONT_UNIT Then
                If GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) IsNot DBNull.Value Then
                    If GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) <> Nothing Then
                        If GV28.GetRowCellValue(e.RowHandle, colIPOJ_VOL_CONT_UNIT) Is DBNull.Value Then
                            e.DisplayText = "Non Applicable"
                        Else
                            If GV28.GetRowCellValue(e.RowHandle, colIPOJ_VOL_CONT_UNIT) = 0 Then e.DisplayText = "Non Applicable"
                        End If
                    End If
                Else
                    e.DisplayText = "Non Applicable"
                End If
            End If


            If e.Column Is colIPOJ_DTMIN Then
                If GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) IsNot DBNull.Value Then
                    If GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) <> Nothing Then
                        If GV28.GetRowCellValue(e.RowHandle, colIPOJ_DTMIN) Is DBNull.Value Then
                            e.DisplayText = "Non Applicable"
                        Else
                            If GV28.GetRowCellValue(e.RowHandle, colIPOJ_DTMIN) = 0 Then e.DisplayText = "Non Applicable"
                        End If
                    End If
                End If
            End If
            If e.Column Is colIPOJ_DTMAX Then
                If GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) IsNot DBNull.Value Then
                    If GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) <> Nothing Then
                        If GV28.GetRowCellValue(e.RowHandle, colIPOJ_DTMAX) Is DBNull.Value Then
                            e.DisplayText = "Non Applicable"
                        Else
                            If GV28.GetRowCellValue(e.RowHandle, colIPOJ_DTMAX) = 0 Then e.DisplayText = "Non Applicable"
                        End If
                    End If
                End If
            End If
            If e.Column Is colIPOJ_DJMAX Then
                If GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) IsNot DBNull.Value Then
                    If GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) <> Nothing Then
                        If GV28.GetRowCellValue(e.RowHandle, colIPOJ_DJMAX) Is DBNull.Value Then
                            e.DisplayText = "Non Applicable"
                        Else
                            If GV28.GetRowCellValue(e.RowHandle, colIPOJ_DJMAX) = 0 Then e.DisplayText = "Non Applicable"
                        End If
                    End If
                End If
            End If
            If e.Column Is colIPOJ_DJMIN Then
                If GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) IsNot DBNull.Value Then
                    If GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) <> Nothing Then
                        If GV28.GetRowCellValue(e.RowHandle, colIPOJ_DJMIN) Is DBNull.Value Then
                            e.DisplayText = "Non Applicable"
                        Else
                            If GV28.GetRowCellValue(e.RowHandle, colIPOJ_DJMIN) = 0 Then e.DisplayText = "Non Applicable"
                        End If
                    End If
                End If
            End If
            If e.Column Is colPosoMin Then
                If GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) IsNot DBNull.Value Then
                    If GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) <> Nothing Then
                        If GV28.GetRowCellValue(e.RowHandle, colUCDMin) Is DBNull.Value Then
                            If (GV28.GetRowCellValue(e.RowHandle, colIPOJ_DONANTH_CDF_CODE_FK) IsNot DBNull.Value) Then
                                If GV28.GetRowCellValue(e.RowHandle, colIPOJ_DJMIN) IsNot DBNull.Value Then
                                    If GV28.GetRowCellValue(e.RowHandle, colIPOJ_DJMIN) <> 0 Then
                                        e.DisplayText = GV28.GetRowCellValue(e.RowHandle, colIPOJ_DJMIN) & "  " & GetLibelle(GV28.GetRowCellValue(e.RowHandle, colIPOJ_NATUCD_CDF_CODE_FK), GV28.GetRowCellValue(e.RowHandle, colIPOJ_NATUCD_CDF_NUM_FK)) & " " & GV28.GetRowCellDisplayText(e.RowHandle, colIPOJ_DONANTH_CDF_CODE_FK) & " (" & GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) & ")/jour"
                                    Else
                                        e.DisplayText = "Non Applicable"
                                    End If
                                Else
                                    e.DisplayText = "Non Applicable"
                                End If
                            Else
                                e.DisplayText = "Non Applicable"
                            End If
                        Else
                            If GV28.GetRowCellValue(e.RowHandle, colUCDMin) = 0 Then
                                If (GV28.GetRowCellValue(e.RowHandle, colIPOJ_DONANTH_CDF_CODE_FK) IsNot DBNull.Value) Then
                                    If GV28.GetRowCellValue(e.RowHandle, colIPOJ_DJMIN) IsNot DBNull.Value Then
                                        If GV28.GetRowCellValue(e.RowHandle, colIPOJ_DJMIN) <> 0 Then
                                            e.DisplayText = GV28.GetRowCellValue(e.RowHandle, colIPOJ_DJMIN) & "  " & GetLibelle(GV28.GetRowCellValue(e.RowHandle, colIPOJ_NATUCD_CDF_CODE_FK), GV28.GetRowCellValue(e.RowHandle, colIPOJ_NATUCD_CDF_NUM_FK)) & " " & GV28.GetRowCellDisplayText(e.RowHandle, colIPOJ_DONANTH_CDF_CODE_FK) & " (" & GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) & ")/jour"
                                        Else
                                            e.DisplayText = "Non Applicable"
                                        End If
                                    Else
                                        e.DisplayText = "Non Applicable"
                                    End If
                                Else
                                    e.DisplayText = "Non Applicable"
                                End If
                            Else
                                'e.DisplayText = GV28.GetRowCellValue(e.RowHandle, colUCDMin) & " nature de l'UCD(" & GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) & ")/jour - " & GV28.GetRowCellValue(e.RowHandle, colDTMinEnjour) & " jour(s)"
                                If (GV28.GetRowCellValue(e.RowHandle, colIPOJ_NATUCD_CDF_CODE_FK) IsNot DBNull.Value) Then
                                    e.DisplayText = GV28.GetRowCellValue(e.RowHandle, colUCDMin) & "  " & GetLibelle(GV28.GetRowCellValue(e.RowHandle, colIPOJ_NATUCD_CDF_CODE_FK), GV28.GetRowCellValue(e.RowHandle, colIPOJ_NATUCD_CDF_NUM_FK)) & " (" & GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) & ")/jour - " & GV28.GetRowCellValue(e.RowHandle, colDTMinEnjour) & " " & getUniteTempsByCoef(GV28.GetRowCellValue(e.RowHandle, colUniteTempsMin))
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If e.Column Is colPosoMax Then
                If GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) IsNot DBNull.Value Then
                    If GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) <> Nothing Then
                        If GV28.GetRowCellValue(e.RowHandle, colUCDMax) Is DBNull.Value Then
                            If (GV28.GetRowCellValue(e.RowHandle, colIPOJ_DONANTH_CDF_CODE_FK) IsNot DBNull.Value) Then
                                If GV28.GetRowCellValue(e.RowHandle, colIPOJ_DJMAX) IsNot DBNull.Value Then

                                    If GV28.GetRowCellValue(e.RowHandle, colIPOJ_DJMAX) <> 0 Then
                                        e.DisplayText = GV28.GetRowCellValue(e.RowHandle, colIPOJ_DJMAX) & "  " & GetLibelle(GV28.GetRowCellValue(e.RowHandle, colIPOJ_NATUCD_CDF_CODE_FK), GV28.GetRowCellValue(e.RowHandle, colIPOJ_NATUCD_CDF_NUM_FK)) & " " & GV28.GetRowCellDisplayText(e.RowHandle, colIPOJ_DONANTH_CDF_CODE_FK) & " (" & GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) & ")/jour"
                                    Else
                                        e.DisplayText = "Non Applicable"
                                    End If

                                Else
                                    e.DisplayText = "Non Applicable"
                                End If
                            Else
                                e.DisplayText = "Non Applicable"
                            End If
                        Else
                            If GV28.GetRowCellValue(e.RowHandle, colUCDMax) = 0 Then
                                If (GV28.GetRowCellValue(e.RowHandle, colIPOJ_DONANTH_CDF_CODE_FK) IsNot DBNull.Value) Then
                                    If GV28.GetRowCellValue(e.RowHandle, colIPOJ_DJMAX) IsNot DBNull.Value Then

                                        If GV28.GetRowCellValue(e.RowHandle, colIPOJ_DJMAX) <> 0 Then
                                            e.DisplayText = GV28.GetRowCellValue(e.RowHandle, colIPOJ_DJMAX) & "  " & GetLibelle(GV28.GetRowCellValue(e.RowHandle, colIPOJ_NATUCD_CDF_CODE_FK), GV28.GetRowCellValue(e.RowHandle, colIPOJ_NATUCD_CDF_NUM_FK)) & " " & GV28.GetRowCellDisplayText(e.RowHandle, colIPOJ_DONANTH_CDF_CODE_FK) & " (" & GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) & ")/jour"
                                        Else
                                            e.DisplayText = "Non Applicable"
                                        End If

                                    Else
                                        e.DisplayText = "Non Applicable"
                                    End If
                                Else
                                    e.DisplayText = "Non Applicable"
                                End If
                            Else
                                If (GV28.GetRowCellValue(e.RowHandle, colIPOJ_NATUCD_CDF_CODE_FK) IsNot DBNull.Value) Then 'iciccc
                                    e.DisplayText = GV28.GetRowCellValue(e.RowHandle, colUCDMax) & "  " & GetLibelle(GV28.GetRowCellValue(e.RowHandle, colIPOJ_NATUCD_CDF_CODE_FK), GV28.GetRowCellValue(e.RowHandle, colIPOJ_NATUCD_CDF_NUM_FK)) & " (" & GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) & ")/jour - " & GV28.GetRowCellValue(e.RowHandle, colDTMaxEnjour) & " " & getUniteTempsByCoef(GV28.GetRowCellValue(e.RowHandle, colUniteTempsMax))
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If e.Column Is colIPOJ_NATUCD_CDF_CODE_FK Then
                If GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) IsNot DBNull.Value Then
                    If GV28.GetRowCellValue(e.RowHandle, colIPOJ_SP_CIPUCD) <> Nothing Then
                        If GV28.GetRowCellValue(e.RowHandle, colIPOJ_NATUCD_CDF_NUM_FK).ToString <> "" Then
                            'InitLkup(Me.rpNATUCD_CDF_CODE_FK2, CDF_CODIF, strSSQL_IN_CDF_CODIF("04", "06") & " AND CDF_NUMERO_PK =" & cn.SQLText(GV28.GetRowCellValue(e.RowHandle, colIPOJ_NATUCD_CDF_NUM_FK)), True)
                            If GV28.GetRowCellValue(e.RowHandle, colIPOJ_NATUCD_CDF_NUM_FK) IsNot DBNull.Value Then
                                If GV28.GetRowCellValue(e.RowHandle, colIPOJ_NATUCD_CDF_NUM_FK) <> Nothing Then
                                    Dim sSQL As String
                                    Dim dt As New DataTable
                                    sSQL = " Select CDF_CODE_PK as code, CDF_NOM as libelle, CDF_NUMERO_PK as num  From THERIAQUE.CDF_CODIF  where CDF_NUMERO_PK = " & cn.SQLText(GV28.GetRowCellValue(e.RowHandle, colIPOJ_NATUCD_CDF_NUM_FK))
                                    sSQL += " AND CDF_CODE_PK = " & GV28.GetRowCellValue(e.RowHandle, colIPOJ_NATUCD_CDF_CODE_FK2)
                                    dt = cn.MySelect(sSQL)
                                    If (dt IsNot Nothing) Then
                                        If dt.Rows.Count > 0 Then e.DisplayText = dt.Rows(0)("libelle")
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub GV30_CustomDrawCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GV30.CustomDrawCell
        If e.Column Is colIPODOSE_NATUCD_CDF_CODE_FK Then
            If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_SP_CIPUCD) IsNot DBNull.Value Then
                If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_SP_CIPUCD) <> Nothing Then
                    If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_NATUCD_CDF_NUM_FK).ToString <> "" Then
                        'InitLkup(Me.rpNATUCD_CDF_CODE_FK2, CDF_CODIF, strSSQL_IN_CDF_CODIF("04", "06") & " AND CDF_NUMERO_PK =" & cn.SQLText(GV28.GetRowCellValue(e.RowHandle, colIPOJ_NATUCD_CDF_NUM_FK)), True)
                        If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_NATUCD_CDF_NUM_FK) IsNot DBNull.Value Then
                            If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_NATUCD_CDF_NUM_FK) <> Nothing Then
                                Dim sSQL As String
                                Dim dt As New DataTable
                                sSQL = " Select CDF_CODE_PK as code, CDF_NOM as libelle, CDF_NUMERO_PK as num  From THERIAQUE.CDF_CODIF  where CDF_NUMERO_PK = " & cn.SQLText(GV30.GetRowCellValue(e.RowHandle, colIPODOSE_NATUCD_CDF_NUM_FK))
                                sSQL += " AND CDF_CODE_PK = " & cn.SQLText(GV30.GetRowCellValue(e.RowHandle, colIPODOSE_NATUCD_CDF_CODE_FK2))

                                dt = cn.MySelect(sSQL)
                                If dt Is Nothing Then dt = New DataTable
                                If dt.Rows.Count > 0 Then e.DisplayText = dt.Rows(0)("libelle")
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If e.Column Is colIPODOSE_VOL_CONT Then
            If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_SP_CIPUCD) IsNot DBNull.Value Then
                If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_SP_CIPUCD) <> Nothing Then
                    If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_VOL_CONT) Is DBNull.Value Then
                        e.DisplayText = "Non Applicable"
                    Else
                        If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_VOL_CONT) = 0 Then e.DisplayText = "Non Applicable"
                    End If
                End If
            End If
        End If

        If e.Column Is colIPODOSE_CONT Then
            If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_SP_CIPUCD) IsNot DBNull.Value Then
                If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_SP_CIPUCD) <> Nothing Then
                    If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_CONT) Is DBNull.Value Then
                        e.DisplayText = "Non Applicable"
                    Else
                        If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_CONT) = 0 Then e.DisplayText = "Non Applicable"
                    End If
                End If
            Else
                e.DisplayText = "Non Applicable"
            End If
        End If

        If e.Column Is colIPODOSE_CONT Then
            If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_SP_CIPUCD) IsNot DBNull.Value Then
                If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_SP_CIPUCD) <> Nothing Then
                    If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_CONT) Is DBNull.Value Then
                        e.DisplayText = "Non Applicable"
                    Else
                        If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_CONT) = 0 Then e.DisplayText = "Non Applicable"
                    End If
                End If
            Else
                e.DisplayText = "Non Applicable"
            End If
        End If

        If e.Column Is colIPODOSE_DJMAX Then
            If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_SP_CIPUCD) IsNot DBNull.Value Then
                If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_SP_CIPUCD) <> Nothing Then
                    If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_DJMAX) Is DBNull.Value Then
                        e.DisplayText = "Non Applicable"
                    Else
                        If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_DJMAX) = 0 Then e.DisplayText = "Non Applicable"
                    End If
                End If
            End If
        End If
        If e.Column Is colIPODOSE_DJMIN Then
            If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_SP_CIPUCD) IsNot DBNull.Value Then
                If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_SP_CIPUCD) <> Nothing Then
                    If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_DJMIN) Is DBNull.Value Then
                        e.DisplayText = "Non Applicable"
                    Else
                        If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_DJMIN) = 0 Then e.DisplayText = "Non Applicable"
                    End If
                End If
            End If
        End If
        If e.Column Is colIPODOSE_DPMAX Then
            If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_SP_CIPUCD) IsNot DBNull.Value Then
                If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_SP_CIPUCD) <> Nothing Then
                    If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_DPMAX) Is DBNull.Value Then
                        e.DisplayText = "Non Applicable"
                    Else
                        If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_DPMAX) = 0 Then e.DisplayText = "Non Applicable"
                    End If
                End If
            End If
        End If
        If e.Column Is colIPODOSE_DPMIN Then
            If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_SP_CIPUCD) IsNot DBNull.Value Then
                If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_SP_CIPUCD) <> Nothing Then
                    If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_DPMIN) Is DBNull.Value Then
                        e.DisplayText = "Non Applicable"
                    Else
                        If GV30.GetRowCellValue(e.RowHandle, colIPODOSE_DPMIN) = 0 Then e.DisplayText = "Non Applicable"
                    End If
                End If
            End If

        End If

    End Sub

    Public Function GetLibelle(ByVal sCDF_CODE_PK As String, ByVal sCDF_NUMERO_PK As String) As String
        Dim dt As DataTable = cn.MySelect("SELECT CDF_NOM FROM THERIAQUE.CDF_CODIF  WHERE CDF_CODE_PK = " & cn.SQLText(sCDF_CODE_PK) & " AND CDF_NUMERO_PK = " & cn.SQLText(sCDF_NUMERO_PK))
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)(0)
        Else
            Return ""
        End If
    End Function

    Function getUniteTempsByCoef(ByVal coef As String) As String
        Select Case coef
            Case "A"
                Return "AN(S)"
            Case "B1"
                Return "SECONDE(S)"
            Case "C"
                Return "AUCUNE INFORMATION"
            Case "E"
                Return "MINUTE(S)"
            Case "H"
                Return "HEURE(S)"
            Case "J"
                Return "JOUR(S)"
            Case "M"
                Return "MOIS"
            Case "S"
                Return "SEMAINE(S)"
            Case "Z06"
                Return "PENDANT 72 HEURES"
            Case "Z07"
                Return "PENDANT 144 HEURES"
            Case "F"
                Return "FOIS"
            Case "Z8"
                Return "Voir spécialité(s)"
        End Select
    End Function

    ''' <summary>
    ''' Trouver si une spécialité est de type monographie virtuelle
    ''' </summary>
    ''' <param name="Code_SP"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 

    Public Function IsMonographie(ByVal Code_SP As Integer) As Boolean
        Dim bOk As Boolean = True
        Dim dt As DataTable = cn.MySelect("SELECT  SP_MONO_VIRTUELLE FROM THERIAQUE.SP_SPECIALITE  WHERE SP_CODE_SQ_PK = " & Code_SP)
        If (dt.Rows(0)(0) Is System.DBNull.Value) Then
            Return False
        End If
        If dt.Rows(0)(0) = True Then
            bOk = True
        Else
            bOk = False
        End If
        Return bOk
    End Function

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GC31.Click

    End Sub

    Private Sub GC30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GC30.Click

    End Sub

    Private Sub GV31_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV31.InitNewRow

        GV31.SetFocusedRowCellValue(colIPODUREE_FPO_CODE_PK_FK, txtCode.Text)

    End Sub

    Private Sub GV31_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV31.ValidateRow
        Dim s As String = e.ErrorText

    End Sub

    Private Sub Frm_Posologie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IPODUREE.Connection.ConnectionString = FposP_TA.Connection.ConnectionString
        IpocotE_TA.Connection.ConnectionString = FposP_TA.Connection.ConnectionString
        IpocoD_TA.Connection.ConnectionString = FposP_TA.Connection.ConnectionString
        IpocofQ_TA.Connection.ConnectionString = FposP_TA.Connection.ConnectionString
        IpO_TA.Connection.ConnectionString = FposP_TA.Connection.ConnectionString

        'Dim ritem As RepositoryItemCheckEdit = TryCast(col.RealColumnEdit, RepositoryItemCheckEdit)
        AddHandler chkCalcul.CheckedChanged, AddressOf GV30_ColumnChanged1

    End Sub

    Private Sub GC28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GC28.Click

    End Sub

    Private Sub AdvBandedGridView1_InitNewRow_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles AdvBandedGridView1.InitNewRow
        If txtCode.Text = "" Then Exit Sub
        AdvBandedGridView1.SetFocusedRowCellValue(colIPO_FPO_CODE_FK_PK1, txtCode.Text)
        AdvBandedGridView1.SetFocusedRowCellValue(colIPO_FPO_CODE_FK_PK, txtCode.Text)
        AdvBandedGridView1.SetFocusedRowCellValue(colIPO_NUM_SEQ_PK, Code_MAx(AdvBandedGridView1, colIPO_NUM_SEQ_PK))
        AdvBandedGridView1.SetFocusedRowCellValue(colIPO_NUM_ORD1, Code_MAx(AdvBandedGridView1, colIPO_NUM_ORD1))
        AdvBandedGridView1.SetFocusedRowCellValue(colIPO_DATECR1, Now.Date)
        AdvBandedGridView1.SetFocusedRowCellValue(colIPO_FREQMAX1, 0)
        AdvBandedGridView1.SetFocusedRowCellValue(colIPO_CDF_FREQMAX_CODE_FK1, "0")
        AdvBandedGridView1.MoveNextPage()
    End Sub

    Private Sub GV31_CustomDrawCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GV31.CustomDrawCell

        If e.Column Is colIPODUREE_DUREE_MIN Then
            If GV31.GetRowCellValue(e.RowHandle, colIPODUREE_SP_CIPUCD) IsNot DBNull.Value Then
                If GV31.GetRowCellValue(e.RowHandle, colIPODUREE_SP_CIPUCD) <> Nothing Then
                    If GV31.GetRowCellValue(e.RowHandle, colIPODUREE_DUREE_MIN) Is DBNull.Value Then
                        e.DisplayText = ""
                    Else
                        If GV31.GetRowCellValue(e.RowHandle, colIPODUREE_DUREE_MIN) = 0 Then e.DisplayText = "Non Applicable"
                    End If
                End If
            End If
        End If


        If e.Column Is colIPODUREE_DUREE_MAX Then
            If GV31.GetRowCellValue(e.RowHandle, colIPODUREE_SP_CIPUCD) IsNot DBNull.Value Then
                If GV31.GetRowCellValue(e.RowHandle, colIPODUREE_SP_CIPUCD) <> Nothing Then
                    If GV31.GetRowCellValue(e.RowHandle, colIPODUREE_DUREE_MAX) Is DBNull.Value Then
                        e.DisplayText = ""
                    Else
                        If GV31.GetRowCellValue(e.RowHandle, colIPODUREE_DUREE_MAX) = 0 Then e.DisplayText = "Non Applicable"
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub GV30_ColumnChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GV30_ColumnChanged1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim chk As DevExpress.XtraEditors.CheckEdit
        chk = CType(sender, DevExpress.XtraEditors.CheckEdit)
        Dim CodeSp As Integer = GV30.GetFocusedRowCellValue("IPODOSE_SP_CODE_FK_PK")
        Dim spCode As Integer

        For i As Integer = 0 To GV30.RowCount - 2
            spCode = GV30.GetDataRow(i)("IPODOSE_SP_CODE_FK_PK")
            If spCode = CodeSp Then
                GV30.SetRowCellValue(i, colCalcul, chk.Checked)
            End If
        Next


    End Sub

    Private Sub GV30_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV30.CellValueChanged

        If (e.Column.Caption = "Calcul") Then

            Dim s As String = "e"
        End If

        '         return ;
        'string cellValue = e.Value.ToString() + " " + 
        '  bandedGridView1.GetRowCellValue(e.RowHandle, 
        '  bandedGridView1.Columns["LastName"]).ToString(); 
        'bandedGridView1.SetRowCellValue(e.RowHandle, 
        '  bandedGridView1.Columns["FullName"], cellValue);

    End Sub

    Private Sub GV30_CustomRowCellEdit(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles GV30.CustomRowCellEdit

        'If (e.Column.Caption = "Calcul") Then

        '    MessageBox.Show(e.Column.Caption)
        '    'Dim s As String = e.Column.Caption
        '    's = GV30.GetDataRow(GV30.FocusedRowHandle)(0)

        'End If

    End Sub
End Class

