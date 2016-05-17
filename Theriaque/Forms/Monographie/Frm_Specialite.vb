Imports System.IO
Public Class Frm_Specialite

    Private CodE As Integer

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
    Private Tab_TA7 As Boolean = False
    Private Tab_lkup7 As Boolean = False
    Private bModeDuplication As Boolean = False
    Private doc As DocumentService.DocumentProvider
    Private DupArray As ArrayList

    Shared CodeSP As Integer

#Region " Edit Data "

    Public Sub AfficherFiche(ByVal code As Integer)

        code = code

        XtraTabControl1.SelectedTabPageIndex = 0
        OnLoading = True
        EmptyDataTable()

        Me.DsTheriaque_Nomenclature1.SP_SPECIALITE.Clear()
        XtraTabControl1.TabIndex = 0

        Me.SP_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SP_SPECIALITE, code)
        Me.SYSP_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SYSP_SYNONYME_SPECIALITE, code)
        Me.SplaB_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SPLAB_SPECIALITE_LABO, code)
        Me.SplabeX_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SPLABEX_SPE_LABO_EXPLOITANT, code)
        doc = New DocumentService.DocumentProvider(strConnexion)
        doc.cn.ConnectionString = cn.sConnexion
        'Dim UCD As String = Me.SP_TA.GetDataByCode(code).Rows(0)("SP_CIPUCD").ToString()
        Me.gcDocument.DataSource = doc.GetDocsByTypeDoc(code.ToString, DocumentService.DocumentProvider.TypeDoc.Specialite)

        btImporter.Enabled = True
        BtSupprim.Enabled = True
        Tab_TA1 = False
        Tab_TA2 = False
        Tab_TA3 = False
        Tab_TA4 = False
        Tab_TA5 = False
        Tab_TA6 = False
        Tab_TA7 = False

        bModeDuplication = False
        OnLoading = False

    End Sub

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_SP_SPECIALITE
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            XtraTabControl1.SelectedTabPageIndex = 0
            OnLoading = True
            EmptyDataTable()

            Me.DsTheriaque_Nomenclature1.SP_SPECIALITE.Clear()
            XtraTabControl1.TabIndex = 0

            Me.SP_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SP_SPECIALITE, CodE)
            Me.SYSP_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SYSP_SYNONYME_SPECIALITE, CodE)
            Me.SplaB_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SPLAB_SPECIALITE_LABO, CodE)
            Me.SplabeX_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SPLABEX_SPE_LABO_EXPLOITANT, CodE)

            '2709LZA
            If doc Is Nothing Then doc = New DocumentService.DocumentProvider(cn.sConnexion)
            doc.cn.ConnectionString = cn.sConnexion

            Me.gcDocument.DataSource = doc.GetDocsByTypeDoc(CodE.ToString, DocumentService.DocumentProvider.TypeDoc.Specialite)

            btImporter.Enabled = True
            BtSupprim.Enabled = True
            Tab_TA1 = False
            Tab_TA2 = False
            Tab_TA3 = False
            Tab_TA4 = False
            Tab_TA5 = False
            Tab_TA6 = False
            Tab_TA7 = False

            bModeDuplication = False
            OnLoading = False

            'T3954: Charger tous les onglets automatiquement suite à la demande du client qui lui dérange de parcourir 
            'tous les onglets avant de maj l'interopérable

            LoadTab_1()
            LoadTab_2()
            LoadTab_3()
            LoadTab_4()
            LoadTab_5()
            LoadTab_6()
            LoadTab_7()
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Function ChercherAvance() As Boolean

        MyBase.Chercher()

        Dim f As New Frm_Recherche
        f._SSQL = strSSQLSYSP_SYNONYME_SPECIALITE & " UNION " & strSSQLSP_NL__SPECIALITE & " UNION " & strSSQLSP_CIPUCD_SPECIALITE
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            XtraTabControl1.SelectedTabPageIndex = 0
            OnLoading = True
            EmptyDataTable()

            Me.DsTheriaque_Nomenclature1.SP_SPECIALITE.Clear()
            XtraTabControl1.TabIndex = 0

            Me.SP_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SP_SPECIALITE, CodE)
            Me.SYSP_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SYSP_SYNONYME_SPECIALITE, CodE)
            Me.SplaB_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SPLAB_SPECIALITE_LABO, CodE)
            Me.SplabeX_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SPLABEX_SPE_LABO_EXPLOITANT, CodE)

            If doc Is Nothing Then doc = New DocumentService.DocumentProvider(cn.sConnexion)
            doc.cn.ConnectionString = cn.sConnexion

            Me.gcDocument.DataSource = doc.GetDocsByTypeDoc(CodE.ToString, DocumentService.DocumentProvider.TypeDoc.Specialite)
            btImporter.Enabled = True
            BtSupprim.Enabled = True
            Tab_TA1 = False
            Tab_TA2 = False
            Tab_TA3 = False
            Tab_TA4 = False
            Tab_TA5 = False
            Tab_TA6 = False
            Tab_TA7 = False

            bModeDuplication = False
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
        Dim sCodeSP As String = ""
        Dim sCodePR As String = ""
        Dim sCodeCIS As String = ""
        Dim sCodeLABO As String = ""
        Dim sCodeSTLABO As String = ""
        Dim sCodeLABOEXP As String = ""
        Dim sCodeVA As String = ""
        Dim sCodeFPH As String = ""
        Dim sCodeCOMPFORM As String = ""
        Dim sCodeCOMP As String = ""
        Dim sCodeCPH As String = ""
        Dim sCodeATC As String = ""
        Dim sCodeEPH As String = ""
        Dim sCodeCGESTION As String = ""
        Dim sCodeCC As String = ""
        Dim sCodeLIST As String = ""
        Dim sCodePRES As String = ""
        Dim sCodeSUBAC As String = ""
        Dim sCodeSUBACUNITE As String = ""
        Dim sCodeSUBAU As String = ""
        Dim sCodeSUBAUUNITE As String = ""
        Dim sCodeTENEUR As String = ""
        Dim sCodeTENEURUNITE As String = ""
        Dim sCodeTENEUREQUIV As String = ""
        Dim strSQL As String = ""
        Dim sLibelleTENEURUNITE As String = ""
        Dim sLibelleSUBAUUNITE As String = ""
        Dim sLibelleSUBACUNITE As String = ""

        Dim f As New Frm_SpecialiteMultiCriteres
        f.ShowDialog()
        If f._Validate Then
            If f._bSP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SP_SPECIALITE
                fDICO.Text = "Spécialités"
                fDICO.ShowDialog()
                sCodeSP = fDICO._Code
            End If
            If f._bPR Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_PR_PRODUIT
                fDICO.Text = "Produits"
                fDICO.ShowDialog()
                sCodePR = fDICO._Code
            End If
            If f._bCIS Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQLSP_NL__CIS
                fDICO.Text = "Code identifiant spécialité(CIS)"
                fDICO.ShowDialog()
                sCodeCIS = fDICO._Code
            End If
            If f._bLABO Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("07")
                fDICO.Text = "Laboratoire"
                fDICO.ShowDialog()
                sCodeLABO = fDICO._Code
            End If
            If f._bSTLABO Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("15")
                fDICO.Text = "Statut laboratoire"
                fDICO.ShowDialog()
                sCodeSTLABO = fDICO._Code
            End If
            If f._bLABOEXP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("07")
                fDICO.Text = "Laboratoire exploitant"
                fDICO.ShowDialog()
                sCodeLABOEXP = fDICO._Code
            End If
            If f._bVA Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("18")
                fDICO.Text = "Voie d’administration"
                fDICO.ShowDialog()
                sCodeVA = fDICO._Code
            End If
            If f._bFPH Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("06")
                fDICO.Text = "Forme pharmaceutique"
                fDICO.ShowDialog()
                sCodeFPH = fDICO._Code
            End If
            If f._bCOMPFORM Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("02")
                fDICO.Text = "Complément de forme"
                fDICO.ShowDialog()
                sCodeCOMPFORM = fDICO._Code
            End If
            If f._bCOMP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("22")
                fDICO.Text = "Composition"
                fDICO.ShowDialog()
                sCodeCOMP = fDICO._Code
            End If
            If f._bCPH Then
                Dim fDICO As New Frm_Recherche
                strSQL = strSSQL_CPH_CLASSEPHARMTHER
                strSQL &= " where CPH_CODE_PK  not in  "
                strSQL &= " (Select distinct isnull(CPH_CPH_CODE_FK,'') From THERIAQUE.CPH_CLASSEPHARMTHER )"
                fDICO._SSQL = strSQL
                fDICO.Text = "Classes pharmaco-thérapeutique"
                fDICO.ShowDialog()
                sCodeCPH = fDICO._Code
            End If
            If f._bATC Then
                strSQL = " select CATC_CODE_PK  into  #Yaks from THERIAQUE.CATC_CLASSEATC "
                strSQL &= " except  "
                strSQL &= " select CATC_CATC_CODE_FK From THERIAQUE.CATC_CLASSEATC "
                strSQL &= " select #Yaks.CATC_CODE_PK as code, c.CATC_NOMF as libelle from #Yaks, THERIAQUE.CATC_CLASSEATC c "
                strSQL &= " where c.CATC_CODE_PK = #Yaks.CATC_CODE_PK "
                strSQL &= " drop table #Yaks "
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSQL
                fDICO.Text = "ATC"
                fDICO.ShowDialog()
                sCodeATC = fDICO._Code
            End If
            If f._bEPH Then
                Dim fDICO As New Frm_Recherche
                strSQL = strSSQL_CEPH_CLASSEEPHMRA
                strSQL &= " where CEPH_CODE_PK  not in  "
                strSQL &= " (Select distinct isnull(CEPH_CEPH_CODE_FK,'') From THERIAQUE.CEPH_CLASSEEPHMRA )"
                fDICO._SSQL = strSQL
                fDICO.Text = "Ephmra"
                fDICO.ShowDialog()
                sCodeEPH = fDICO._Code
            End If
            If f._bCGESTION Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CGE_CLASSEGESTION
                fDICO.Text = "Classes gestion"
                fDICO.ShowDialog()
                sCodeCGESTION = fDICO._Code
            End If
            If f._bCC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CH_CHOIX
                fDICO.Text = "Critères de choix"
                fDICO.ShowDialog()
                sCodeCC = fDICO._Code
            End If
            If f._bLIST Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("08")
                fDICO.Text = "Listes"
                fDICO.ShowDialog()
                sCodeLIST = fDICO._Code
            End If
            If f._bPRES Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("14") & " and substring(CDF_CODE_PK,1,1) = 'S'"
                fDICO.Text = "Prescriptions / délivrances"
                fDICO.ShowDialog()
                sCodePRES = fDICO._Code
            End If
            If f._bSUBAC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SAC_SUBACTIVE
                fDICO.Text = "Substances actives"
                fDICO.ShowDialog()
                sCodeSUBAC = fDICO._Code
            End If
            If f._bSUBACUNITE Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("19")
                fDICO.Text = "Substances actives - Unités de dosage"
                fDICO.ShowDialog()
                sCodeSUBACUNITE = fDICO._Code
                sLibelleSUBACUNITE = fDICO._Libelle
            End If
            If f._bSUBAU Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SAU_SUBAUXILIAIRE
                fDICO.Text = "Excipients"
                fDICO.ShowDialog()
                sCodeSUBAU = fDICO._Code
            End If
            If f._bSUBAUUNITE Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("19")
                fDICO.Text = "Excipients - Unités de dosage"
                fDICO.ShowDialog()
                sCodeSUBAUUNITE = fDICO._Code
                sLibelleSUBAUUNITE = fDICO._Libelle
            End If
            If f._bTENEUR Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("24")
                fDICO.Text = "Teneurs"
                fDICO.ShowDialog()
                sCodeTENEUR = fDICO._Code
            End If
            If f._bTENEURUNITE Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("19")
                fDICO.Text = "Teneurs - Unités de dosage"
                fDICO.ShowDialog()
                sCodeTENEURUNITE = fDICO._Code
                sLibelleTENEURUNITE = fDICO._Libelle
            End If
            If f._bTENEUREQUIV Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("19")
                fDICO.Text = "Teneurs - Equivalent"
                fDICO.ShowDialog()
                sCodeTENEUREQUIV = fDICO._Code
            End If

            Dim fResultat As New Frm_Recherche
            Dim sSQL As String = ""
            sSQL &= " Select SP_CODE_SQ_PK as code, '' as libelle From THERIAQUE.SP_SPECIALITE"
            If sCodeSP <> "" Then
                sSQL &= " WHERE SP_CODE_SQ_PK IN (SELECT SP_CODE_SQ_PK FROM THERIAQUE.SP_SPECIALITE WHERE SP_CODE_SQ_PK = " & cn.SQLText(sCodeSP) & ")"
            End If
            If sCodePR <> "" Then
                If sCodeSP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SP_CODE_SQ_PK FROM THERIAQUE.SP_SPECIALITE WHERE SP_PR_CODE_FK = " & cn.SQLText(sCodePR) & ")"
            End If
            If sCodeCIS <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SP_CODE_SQ_PK FROM THERIAQUE.SP_SPECIALITE WHERE SP_NL = " & cn.SQLText(sCodeCIS) & ")"
            End If
            If sCodeLABO <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SPLAB_SP_CODE_FK_PK FROM THERIAQUE.SPLAB_SPECIALITE_LABO WHERE SPLAB_CDF_LAB_CODE_FK_PK = " & cn.SQLText(sCodeLABO) & ")"
            End If
            If sCodeSTLABO <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SP_CODE_SQ_PK FROM THERIAQUE.SP_SPECIALITE WHERE SP_CDF_SLAB_CODE_FK = " & cn.SQLText(sCodeSTLABO) & ")"
            End If
            If sCodeLABOEXP <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SPLABEX_SP_CODE_FK_PK FROM THERIAQUE.SPLABEX_SPE_LABO_EXPLOITANT WHERE SPLABEX_CDF_LAB_CODE_FK_PK = " & cn.SQLText(sCodeLABOEXP) & ")"
            End If
            If sCodeVA <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SPVO_SP_CODE_FK_PK FROM THERIAQUE.SPVO_SPECIALITE_VOIE WHERE SPVO_CDF_VO_CODE_FK_PK = " & cn.SQLText(sCodeVA) & ")"
            End If
            If sCodeFPH <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SPFO_SP_CODE_FK_PK FROM THERIAQUE.SPFO_SPECIALITE_FORME WHERE SPFO_CDF_FO_CODE_FK_PK = " & cn.SQLText(sCodeFPH) & ")"
            End If
            If sCodeCOMPFORM <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SPFOCFO_SP_CODE_FK_PK FROM THERIAQUE.SPFOCFO_SPE_FORME_COMPFORME WHERE SPFOCFO_CDF_CFO_CODE_FK_PK = " & cn.SQLText(sCodeCOMPFORM) & ")"
            End If
            If sCodeCOMP <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT COMPO_SP_CODE_FK_PK FROM THERIAQUE.COMPO_COMPOSITION WHERE COMPO_CDF_GAL_CODE_FK = " & cn.SQLText(sCodeCOMP) & ")"
            End If
            If sCodeCPH <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SPCPH_SP_CODE_FK_PK FROM THERIAQUE.SPCPH_SPECIALITE_CLASSEPH WHERE SPCPH_CPH_CODE_FK_PK = " & cn.SQLText(sCodeCPH) & ")"
            End If
            If sCodeATC <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Or sCodeCPH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SP_CODE_SQ_PK FROM THERIAQUE.SP_SPECIALITE WHERE SP_CATC_CODE_FK = " & cn.SQLText(sCodeATC) & ")"
            End If
            If sCodeEPH <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Or sCodeCPH <> "" Or sCodeATC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SP_CODE_SQ_PK FROM THERIAQUE.SP_SPECIALITE WHERE SP_CEPH_CODE_FK = " & cn.SQLText(sCodeEPH) & ")"
            End If
            If sCodeCGESTION <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Or sCodeCPH <> "" Or sCodeATC <> "" Or sCodeEPH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SP_CODE_SQ_PK FROM THERIAQUE.SP_SPECIALITE WHERE SP_CGE_CODE_FK = " & cn.SQLText(sCodeCGESTION) & ")"
            End If
            If sCodeCC <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Or sCodeCPH <> "" Or sCodeATC <> "" Or sCodeEPH <> "" Or sCodeCGESTION <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SPCH_SP_CODE_FK_PK FROM THERIAQUE.SPCH_SPECIALITE_CHOIX WHERE SPCH_CH_CODE_FK_PK = " & cn.SQLText(sCodeCC) & ")"
            End If
            If sCodeLIST <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Or sCodeCPH <> "" Or sCodeATC <> "" Or sCodeEPH <> "" Or sCodeCGESTION <> "" Or sCodeCC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SP_CODE_SQ_PK FROM THERIAQUE.SP_SPECIALITE WHERE SP_CDF_LI_CODE_FK = " & cn.SQLText(sCodeLIST) & ")"
            End If
            If sCodePRES <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Or sCodeCPH <> "" Or sCodeATC <> "" Or sCodeEPH <> "" Or sCodeCGESTION <> "" Or sCodeCC <> "" Or sCodeLIST <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SPCPD_SP_CODE_FK_PK FROM THERIAQUE.SPCPD_SPE_CDT_PRESCR WHERE SPCPD_CDF_STP_CODE_FK_PK = " & cn.SQLText(sCodePRES) & ")"
            End If
            If sCodeSUBAC <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Or sCodeCPH <> "" Or sCodeATC <> "" Or sCodeEPH <> "" Or sCodeCGESTION <> "" Or sCodeCC <> "" Or sCodeLIST <> "" Or sCodePRES <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT COSAC_SP_CODE_FK_PK FROM THERIAQUE.COSAC_COMPO_SUBACT WHERE COSAC_SAC_BASE_CODE_FK = " & cn.SQLText(sCodeSUBAC) & " UNION SELECT COSAC_SP_CODE_FK_PK FROM THERIAQUE.COSAC_COMPO_SUBACT WHERE COSAC_SAC_CODE_FK_PK = " & cn.SQLText(sCodeSUBAC) & ")"
            End If
            If sCodeSUBACUNITE <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Or sCodeCPH <> "" Or sCodeATC <> "" Or sCodeEPH <> "" Or sCodeCGESTION <> "" Or sCodeCC <> "" Or sCodeLIST <> "" Or sCodePRES <> "" Or sCodeSUBAC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT COSAC_SP_CODE_FK_PK FROM THERIAQUE.COSAC_COMPO_SUBACT WHERE COSAC_UNITEDOSAGE = " & cn.SQLText(sLibelleSUBACUNITE) & ")"
            End If
            If sCodeSUBAU <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Or sCodeCPH <> "" Or sCodeATC <> "" Or sCodeEPH <> "" Or sCodeCGESTION <> "" Or sCodeCC <> "" Or sCodeLIST <> "" Or sCodePRES <> "" Or sCodeSUBAC <> "" Or sCodeSUBACUNITE <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT COSAU_SP_CODE_FK_PK FROM THERIAQUE.COSAU_COMPO_SUBAUX WHERE COSAU_SAU_CODE_FK_PK = " & cn.SQLText(sCodeSUBAU) & ")"
            End If
            If sCodeSUBAUUNITE <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Or sCodeCPH <> "" Or sCodeATC <> "" Or sCodeEPH <> "" Or sCodeCGESTION <> "" Or sCodeCC <> "" Or sCodeLIST <> "" Or sCodePRES <> "" Or sCodeSUBAC <> "" Or sCodeSUBACUNITE <> "" Or sCodeSUBAU <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT COSAU_SP_CODE_FK_PK FROM THERIAQUE.COSAU_COMPO_SUBAUX WHERE COSAU_UNITEDOSAGE = " & cn.SQLText(sLibelleSUBAUUNITE) & ")"
            End If
            If sCodeTENEUR <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Or sCodeCPH <> "" Or sCodeATC <> "" Or sCodeEPH <> "" Or sCodeCGESTION <> "" Or sCodeCC <> "" Or sCodeLIST <> "" Or sCodePRES <> "" Or sCodeSUBAC <> "" Or sCodeSUBACUNITE <> "" Or sCodeSUBAU <> "" Or sCodeSUBAUUNITE <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT COTEN_SP_CODE_FK_PK FROM THERIAQUE.COTEN_COMPO_TENEUR WHERE COTEN_CDF_TEN_CODE_FK_PK = " & cn.SQLText(sCodeTENEUR) & ")"
            End If
            If sCodeTENEURUNITE <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Or sCodeCPH <> "" Or sCodeATC <> "" Or sCodeEPH <> "" Or sCodeCGESTION <> "" Or sCodeCC <> "" Or sCodeLIST <> "" Or sCodePRES <> "" Or sCodeSUBAC <> "" Or sCodeSUBACUNITE <> "" Or sCodeSUBAU <> "" Or sCodeSUBAUUNITE <> "" Or sCodeTENEUR <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT COTEN_SP_CODE_FK_PK FROM THERIAQUE.COTEN_COMPO_TENEUR WHERE COTEN_CDF_UD_CODE_FK = " & cn.SQLText(sLibelleTENEURUNITE) & ")"
            End If
            If sCodeTENEUREQUIV <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Or sCodeCPH <> "" Or sCodeATC <> "" Or sCodeEPH <> "" Or sCodeCGESTION <> "" Or sCodeCC <> "" Or sCodeLIST <> "" Or sCodePRES <> "" Or sCodeSUBAC <> "" Or sCodeSUBACUNITE <> "" Or sCodeSUBAU <> "" Or sCodeSUBAUUNITE <> "" Or sCodeTENEUR <> "" Or sCodeTENEURUNITE <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT COTEN_SP_CODE_FK_PK FROM THERIAQUE.COTEN_COMPO_TENEUR WHERE COTEN_CDF_UD_EQUIV_CODE_FK = " & cn.SQLText(sCodeTENEUREQUIV) & ")"
            End If

            sSQL &= " ORDER BY SP_CODE_SQ_PK"
            fResultat._SSQL = sSQL
            fResultat.Text = Me.Text
            fResultat.ShowDialog()
            CodE = fResultat._Code
            If fResultat._Code IsNot Nothing Then
                XtraTabControl1.SelectedTabPageIndex = 0
                OnLoading = True
                EmptyDataTable()

                Me.DsTheriaque_Nomenclature1.SP_SPECIALITE.Clear()
                XtraTabControl1.TabIndex = 0

                Me.SP_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SP_SPECIALITE, CodE)
                Me.SYSP_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SYSP_SYNONYME_SPECIALITE, CodE)
                Me.SplaB_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SPLAB_SPECIALITE_LABO, CodE)
                Me.SplabeX_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SPLABEX_SPE_LABO_EXPLOITANT, CodE)

                If doc Is Nothing Then doc = New DocumentService.DocumentProvider(cn.sConnexion)
                doc.cn.ConnectionString = cn.sConnexion

                Me.gcDocument.DataSource = doc.GetDocsByTypeDoc(CodE.ToString, DocumentService.DocumentProvider.TypeDoc.Specialite)
                btImporter.Enabled = True
                BtSupprim.Enabled = True
                Tab_TA1 = False
                Tab_TA2 = False
                Tab_TA3 = False
                Tab_TA4 = False
                Tab_TA5 = False
                Tab_TA6 = False
                Tab_TA7 = False

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
        SetCode_MAx(MasterTable, txtCode)
        'txtCode.Text = Get_MAxCode() 'GetMaxSP_ID()
        CodE = InvalidCode
        bModeDuplication = False
        Me.gcDocument.DataSource = New ArrayList()
        MyBase.Ajouter()
    End Sub

    Public Overrides Function supprimer() As Boolean
        MyBase.Supprimer()
        If Tab_TA1 = False Or Tab_TA2 = False Or Tab_TA3 = False Or Tab_TA4 = False Or Tab_TA5 = False Or Tab_TA6 = False Then
            Process_Message(strChargementOnglet, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Function
        End If

        DeleteSpFrom_INTER_INTEROPERABLE()

        Dim iCount As Integer

        For iCount = 0 To DsTheriaque_Ref.SPAFS_SPECIALITE_AFSSAPS.Rows.Count - 1
            DsTheriaque_Ref.SPAFS_SPECIALITE_AFSSAPS.Rows(iCount).Delete()
        Next
        Me.SpafS_TA.Update(DsTheriaque_Ref)

        For iCount = 0 To DsTheriaque_Nomenclature1.SPFOCPI_SPE_FORME_COMPINFO.Rows.Count - 1
            DsTheriaque_Nomenclature1.SPFOCPI_SPE_FORME_COMPINFO.Rows(iCount).Delete()
        Next
        Me.SpfocpI_TA.Update(DsTheriaque_Nomenclature1)

        For iCount = 0 To DsTheriaque_Nomenclature1.SPFOCFO_SPE_FORME_COMPFORME.Rows.Count - 1
            DsTheriaque_Nomenclature1.SPFOCFO_SPE_FORME_COMPFORME.Rows(iCount).Delete()
        Next
        Me.SpfocfO_TA.Update(DsTheriaque_Nomenclature1)

        For iCount = 0 To DsTheriaque_Nomenclature1.SPFO_SPECIALITE_FORME.Rows.Count - 1
            DsTheriaque_Nomenclature1.SPFO_SPECIALITE_FORME.Rows(iCount).Delete()
        Next
        Me.SpfO_TA.Update(DsTheriaque_Nomenclature1)

        For iCount = 0 To DsTheriaque_Nomenclature1.SYSP_SYNONYME_SPECIALITE.Rows.Count - 1
            DsTheriaque_Nomenclature1.SYSP_SYNONYME_SPECIALITE.Rows(iCount).Delete()
        Next
        Me.SYSP_TA.Update(DsTheriaque_Nomenclature1)

        For iCount = 0 To DsTheriaque_Nomenclature1.SPLAB_SPECIALITE_LABO.Rows.Count - 1
            DsTheriaque_Nomenclature1.SPLAB_SPECIALITE_LABO.Rows(iCount).Delete()
        Next
        Me.SplaB_TA.Update(DsTheriaque_Nomenclature1)

        For iCount = 0 To DsTheriaque_Nomenclature1.SPLABEX_SPE_LABO_EXPLOITANT.Rows.Count - 1
            DsTheriaque_Nomenclature1.SPLABEX_SPE_LABO_EXPLOITANT.Rows(iCount).Delete()
        Next
        Me.SplabeX_TA.Update(DsTheriaque_Nomenclature1)

        For iCount = 0 To DsTheriaque_Nomenclature1.SPVO_SPECIALITE_VOIE.Rows.Count - 1
            DsTheriaque_Nomenclature1.SPVO_SPECIALITE_VOIE.Rows(iCount).Delete()
        Next
        Me.SpvO_TA.Update(DsTheriaque_Nomenclature1)

        For iCount = 0 To DsTheriaque_Nomenclature1.COSAC_COMPO_SUBACT.Rows.Count - 1
            DsTheriaque_Nomenclature1.COSAC_COMPO_SUBACT.Rows(iCount).Delete()
        Next
        Me.CosaC_TA.Update(DsTheriaque_Nomenclature1)

        For iCount = 0 To DsTheriaque_Nomenclature1.COSAU_COMPO_SUBAUX.Rows.Count - 1
            DsTheriaque_Nomenclature1.COSAU_COMPO_SUBAUX.Rows(iCount).Delete()
        Next
        Me.CosaU_TA.Update(DsTheriaque_Nomenclature1)

        For iCount = 0 To DsTheriaque_Nomenclature1.COMPO_COMPOSITION.Rows.Count - 1
            DsTheriaque_Nomenclature1.COMPO_COMPOSITION.Rows(iCount).Delete()
        Next
        Me.CompO_TA.Update(DsTheriaque_Nomenclature1)

        For iCount = 0 To DsTheriaque_Nomenclature1.COTEN_COMPO_TENEUR.Rows.Count - 1
            DsTheriaque_Nomenclature1.COTEN_COMPO_TENEUR.Rows(iCount).Delete()
        Next
        Me.CoteN_TA.Update(DsTheriaque_Nomenclature1)

        For iCount = 0 To DsTheriaque_Nomenclature1.SPADM_SPECIALITE_MODEADM.Rows.Count - 1
            DsTheriaque_Nomenclature1.SPADM_SPECIALITE_MODEADM.Rows(iCount).Delete()
        Next
        Me.SpadM_TA.Update(DsTheriaque_Nomenclature1)

        For iCount = 0 To DsTheriaque_Nomenclature1.SPCPH_SPECIALITE_CLASSEPH.Rows.Count - 1
            DsTheriaque_Nomenclature1.SPCPH_SPECIALITE_CLASSEPH.Rows(iCount).Delete()
        Next
        Me.SpcpH_TA.Update(DsTheriaque_Nomenclature1)

        For iCount = 0 To DsTheriaque_Nomenclature1.SPDDD_DOSE_USUELLE_JOUR.Rows.Count - 1
            DsTheriaque_Nomenclature1.SPDDD_DOSE_USUELLE_JOUR.Rows(iCount).Delete()
        Next
        Me.SpddD_TA.Update(DsTheriaque_Nomenclature1)

        For iCount = 0 To DsTheriaque_Nomenclature1.SPCH_SPECIALITE_CHOIX.Rows.Count - 1
            DsTheriaque_Nomenclature1.SPCH_SPECIALITE_CHOIX.Rows(iCount).Delete()
        Next
        Me.SpcH_TA.Update(DsTheriaque_Nomenclature1)

        For iCount = 0 To DsTheriaque_Nomenclature1.SPRMO_SPECIALITE_RMO.Rows.Count - 1
            DsTheriaque_Nomenclature1.SPRMO_SPECIALITE_RMO.Rows(iCount).Delete()
        Next
        Me.SprmO_TA.Update(DsTheriaque_Nomenclature1)

        For iCount = 0 To DsTheriaque_Nomenclature1.SPFTH_SPEC_INFOTHERAPEUTIQUE.Rows.Count - 1
            DsTheriaque_Nomenclature1.SPFTH_SPEC_INFOTHERAPEUTIQUE.Rows(iCount).Delete()
        Next
        Me.SpftH_TA.Update(DsTheriaque_Nomenclature1)

        For iCount = 0 To DsTheriaque_Nomenclature1.SPFTR_SPECIALITE_TRANSPARENCE.Rows.Count - 1
            DsTheriaque_Nomenclature1.SPFTR_SPECIALITE_TRANSPARENCE.Rows(iCount).Delete()
        Next
        Me.SpftR_TA.Update(DsTheriaque_Nomenclature1)

        For iCount = 0 To DsTheriaqueURL.SPURL_SPECIALITE_ADRESSE.Rows.Count - 1
            DsTheriaqueURL.SPURL_SPECIALITE_ADRESSE.Rows(iCount).Delete()
        Next
        Me.SpurL_TA.Update(DsTheriaqueURL)

        'cn.Execute("DELETE FROM THERIAQUE.SPURL_SPECIALITE_ADRESSE WHERE SPURL_CODE_SP_PK_FK =" & txtCode.Text)

        '----------------------------------------------------------------------------------
        '----------------------------------------------------------------------------------
        cn.Execute("Delete  from THERIAQUE.FINSMR_INDIC_SMR_ATR where FINSMR_SP_CODE_FK_PK = " & txtCode.Text)
        For iCount = 0 To DsTheriaque_Nomenclature1.SPATR_SPEC_AVISTRANSPARENCE.Rows.Count - 1
            DsTheriaque_Nomenclature1.SPATR_SPEC_AVISTRANSPARENCE.Rows(iCount).Delete()
        Next
        Me.SpatR_TA.Update(DsTheriaque_Nomenclature1)
        '----------------------------------------------------------------------------------
        '----------------------------------------------------------------------------------

        For iCount = 0 To DsTheriaque_Nomenclature1.SPSMR_SERVICE_MEDICAL_RENDU.Rows.Count - 1
            DsTheriaque_Nomenclature1.SPSMR_SERVICE_MEDICAL_RENDU.Rows(iCount).Delete()
        Next
        Me.SpsmR_TA.Update(DsTheriaque_Nomenclature1)

        For iCount = 0 To DsTheriaque_Recap.SPCPD_SPE_CDT_PRESCR.Rows.Count - 1
            DsTheriaque_Recap.SPCPD_SPE_CDT_PRESCR.Rows(iCount).Delete()
        Next
        Me.SpcpD_TA.Update(Me.DsTheriaque_Recap)

        For iCount = 0 To DsTheriaque_Nomenclature1.PRIUCD_PRIX_UCD.Rows.Count - 1
            DsTheriaque_Nomenclature1.PRIUCD_PRIX_UCD.Rows(iCount).Delete()
        Next
        Me.PriucD_TA.Update(DsTheriaque_Nomenclature1)

        For iCount = 0 To DsTheriaque_Nomenclature1.SPFOTX_SPE_FORME_TEXTE.Rows.Count - 1
            DsTheriaque_Nomenclature1.SPFOTX_SPE_FORME_TEXTE.Rows(iCount).Delete()
        Next
        Me.SpfotX_TA.Update(DsTheriaque_Nomenclature1)

        For iCount = 0 To DsTheriaque_Nomenclature1.SPTEN_SPECIALITE_TENEUR.Rows.Count - 1
            DsTheriaque_Nomenclature1.SPTEN_SPECIALITE_TENEUR.Rows(iCount).Delete()
        Next
        Me.SpteN_TA.Update(DsTheriaque_Nomenclature1)

        DsTheriaque_Nomenclature1.SP_SPECIALITE.Rows(0).Delete()
        Me.SP_TA.Update(Me.DsTheriaque_Nomenclature1.SP_SPECIALITE)


        bModeDuplication = False
        Return True
    End Function

    Public Overrides Sub valider()

        'MyBase.Valider()

        'If Not SpCodeExist(txtCode.Text) Then
        '    GetMaxSP_ID()
        'End If

        DateEdit1.EditValue = Now.Date
        DateEdit1.DateTime = Now.Date

       

        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        SP_TA.Update(Me.DsTheriaque_Nomenclature1.SP_SPECIALITE)

        If (String.IsNullOrEmpty(txtUCD.Text)) Then
            cn.Execute("update theriaque.SP_SPECIALITE set SP_CIPUCD=null where SP_CODE_SQ_PK= " & txtCode.Text)
        End If

        If (String.IsNullOrEmpty(txtUCD13.Text)) Then
            cn.Execute("update theriaque.SP_SPECIALITE set SP_CIPUCD13=null where SP_CODE_SQ_PK= " & txtCode.Text)
        End If

        'Modifier l'ordre de SPTEN et SPADM aprés SP_SECIALITE
        Me.BindingContext(Me.MasterDataSet, SPTEN_SPECIALITE_TENEUR).EndCurrentEdit()
        Me.SpteN_TA.Update(Me.DsTheriaque_Nomenclature1.SPTEN_SPECIALITE_TENEUR)

        Me.BindingContext(Me.MasterDataSet, SPADM_SPECIALITE_MODEADM).EndCurrentEdit()
        Me.SpadM_TA.Update(Me.DsTheriaque_Nomenclature1.SPADM_SPECIALITE_MODEADM)

        Me.BindingContext(Me.MasterDataSet, SYSP_SYNONYME_SPECIALITE).EndCurrentEdit()
        Me.SYSP_TA.Update(Me.DsTheriaque_Nomenclature1.SYSP_SYNONYME_SPECIALITE)

        Me.BindingContext(Me.MasterDataSet, SPLAB_SPECIALITE_LABO).EndCurrentEdit()
        Me.SplaB_TA.Update(Me.DsTheriaque_Nomenclature1.SPLAB_SPECIALITE_LABO)

        Me.BindingContext(Me.MasterDataSet, SPLABEX_SPE_LABO_EXPLOITANT).EndCurrentEdit()
        Me.SplabeX_TA.Update(Me.DsTheriaque_Nomenclature1.SPLABEX_SPE_LABO_EXPLOITANT)

        Me.BindingContext(Me.MasterDataSet, SPVO_SPECIALITE_VOIE).EndCurrentEdit()
        Me.SpvO_TA.Update(Me.DsTheriaque_Nomenclature1.SPVO_SPECIALITE_VOIE)


        Me.BindingContext(Me.MasterDataSet, SPFOCFO_SPE_FORME_COMPFORME).EndCurrentEdit()
        Me.SpfocfO_TA.Update(Me.DsTheriaque_Nomenclature1.SPFOCFO_SPE_FORME_COMPFORME)

        Me.BindingContext(Me.MasterDataSet, SPFOCPI_SPE_FORME_COMPINFO).EndCurrentEdit()
        Me.SpfocpI_TA.Update(Me.DsTheriaque_Nomenclature1.SPFOCPI_SPE_FORME_COMPINFO)

        Me.BindingContext(Me.MasterDataSet, SPFO_SPECIALITE_FORME).EndCurrentEdit()
        Me.SpfO_TA.Update(Me.DsTheriaque_Nomenclature1.SPFO_SPECIALITE_FORME)

        Me.BindingContext(Me.MasterDataSet, COMPO_COMPOSITION).EndCurrentEdit()
        Me.CompO_TA.Update(Me.DsTheriaque_Nomenclature1.COMPO_COMPOSITION)

        Me.BindingContext(Me.MasterDataSet, COSAC_COMPO_SUBACT).EndCurrentEdit()
        Me.CosaC_TA.Update(Me.DsTheriaque_Nomenclature1.COSAC_COMPO_SUBACT)

        Me.BindingContext(Me.MasterDataSet, COSAU_COMPO_SUBAUX).EndCurrentEdit()
        Me.CosaU_TA.Update(Me.DsTheriaque_Nomenclature1.COSAU_COMPO_SUBAUX)

        Me.BindingContext(Me.MasterDataSet, COTEN_COMPO_TENEUR).EndCurrentEdit()
        Me.CoteN_TA.Update(Me.DsTheriaque_Nomenclature1.COTEN_COMPO_TENEUR)



        Me.BindingContext(Me.MasterDataSet, SPCPH_SPECIALITE_CLASSEPH).EndCurrentEdit()
        Me.SpcpH_TA.Update(Me.DsTheriaque_Nomenclature1.SPCPH_SPECIALITE_CLASSEPH)

        Me.BindingContext(Me.MasterDataSet, SPDDD_DOSE_USUELLE_JOUR).EndCurrentEdit()
        Me.SpddD_TA.Update(Me.DsTheriaque_Nomenclature1.SPDDD_DOSE_USUELLE_JOUR)

        Me.BindingContext(Me.MasterDataSet, SPCH_SPECIALITE_CHOIX).EndCurrentEdit()
        Me.SpcH_TA.Update(Me.DsTheriaque_Nomenclature1.SPCH_SPECIALITE_CHOIX)

        Me.BindingContext(Me.MasterDataSet, SPRMO_SPECIALITE_RMO).EndCurrentEdit()
        Me.SprmO_TA.Update(Me.DsTheriaque_Nomenclature1.SPRMO_SPECIALITE_RMO)

        Me.BindingContext(Me.MasterDataSet, SPFTH_SPEC_INFOTHERAPEUTIQUE).EndCurrentEdit()
        Me.SpftH_TA.Update(Me.DsTheriaque_Nomenclature1.SPFTH_SPEC_INFOTHERAPEUTIQUE)

        Me.BindingContext(Me.MasterDataSet, SPFTR_SPECIALITE_TRANSPARENCE).EndCurrentEdit()
        Me.SpftR_TA.Update(Me.DsTheriaque_Nomenclature1.SPFTR_SPECIALITE_TRANSPARENCE)

        Me.BindingContext(Me.MasterDataSet, SPATR_SPEC_AVISTRANSPARENCE).EndCurrentEdit()
        Me.SpatR_TA.Update(Me.DsTheriaque_Nomenclature1.SPATR_SPEC_AVISTRANSPARENCE)

        Me.BindingContext(Me.MasterDataSet, SPSMR_SERVICE_MEDICAL_RENDU).EndCurrentEdit()
        Me.SpsmR_TA.Update(Me.DsTheriaque_Nomenclature1.SPSMR_SERVICE_MEDICAL_RENDU)

        Me.BindingContext(Me.DsTheriaque_Recap, SPCPD_SPE_CDT_PRESCR).EndCurrentEdit()
        Me.SpcpD_TA.Update(Me.DsTheriaque_Recap.SPCPD_SPE_CDT_PRESCR)

        Me.BindingContext(Me.MasterDataSet, PRIUCD_PRIX_UCD).EndCurrentEdit()
        Me.PriucD_TA.Update(Me.DsTheriaque_Nomenclature1.PRIUCD_PRIX_UCD)

        Me.BindingContext(Me.MasterDataSet, SPFOTX_SPE_FORME_TEXTE).EndCurrentEdit()
        Me.SpfotX_TA.Update(Me.DsTheriaque_Nomenclature1.SPFOTX_SPE_FORME_TEXTE)

        Me.BindingContext(Me.DsTheriaque_Ref, SPAFS_SPECIALITE_AFSSAPS).EndCurrentEdit()
        Me.SpafS_TA.Update(Me.DsTheriaque_Ref.SPAFS_SPECIALITE_AFSSAPS)

        If ModeFiche = eMode.Modification Then
            Update_INTER_INTEROPERABLE()
        End If

        If NNS(lkupATC2.EditValue) <> "" Then cn.Execute("Update THERIAQUE.PRE_PRESENTATION set PRE_CATC_CODE_FK = " & cn.SQLText(NNS(lkupATC2.EditValue)) & " where PRE_SP_CODE_FK = " & txtCode.Text)
        If NNS(lkupEphemra2.EditValue) <> "" Then cn.Execute("Update THERIAQUE.PRE_PRESENTATION set PRE_CEPH_CODE_FK = " & cn.SQLText(NNS(lkupEphemra2.EditValue)) & " where PRE_SP_CODE_FK = " & txtCode.Text)
        'If NNS(lkupListe.EditValue) <> "" Then cn.Execute("Update THERIAQUE.PRE_PRESENTATION set PRE_CDF_LI_CODE_FK = " & cn.SQLText(NNS(lkupListe.EditValue)) & " where PRE_SP_CODE_FK = " & txtCode.Text)
        'Update_URL()
        Me.BindingContext(Me.DsTheriaqueURL, "SPURL_SPECIALITE_ADRESSE").EndCurrentEdit()
        Me.SpurL_TA.Update(Me.DsTheriaqueURL.SPURL_SPECIALITE_ADRESSE)
        bModeDuplication = False


        'Dupplication des documents
        If (DupArray IsNot Nothing) Then
            For iCount As Integer = 0 To DupArray.Count - 1
                doc.AddDocumentToAssociation((DupArray(iCount)).DO_ID, txtCode.Text, DocumentService.DocumentProvider.TypeDoc.Specialite)
            Next
            DupArray = Nothing
        End If

        'PRIUCD_PRIX_UCD

        Dim req As String = ""

        'PRIUCD_PRIX_UCD
        req = "UPDATE [Theriaque].[PRIUCD_PRIX_UCD] SET PRIUCD_UCD13 = " & cn.SQLText(txtUCD13.Text) & " WHERE PRIUCD_UCD_CODE_PK = '" & txtUCD.Text & "'"
        cn.ExecuteUCDCIP13(req)

        btImporter.Enabled = True
        BtSupprim.Enabled = True

    End Sub

    Public Overrides Sub annuler()

        OnLoading = True
        MyBase.Annuler()

        Me.BindingContext(Me.DsTheriaque_Ref, SPAFS_SPECIALITE_AFSSAPS).CancelCurrentEdit()
        Me.DsTheriaque_Ref.SPAFS_SPECIALITE_AFSSAPS.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SPFOCPI_SPE_FORME_COMPINFO).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature1.SPFOCPI_SPE_FORME_COMPINFO.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SPFOCFO_SPE_FORME_COMPFORME).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature1.SPFOCFO_SPE_FORME_COMPFORME.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SPFO_SPECIALITE_FORME).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature1.SPFO_SPECIALITE_FORME.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SYSP_SYNONYME_SPECIALITE).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature1.SYSP_SYNONYME_SPECIALITE.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SPLAB_SPECIALITE_LABO).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature1.SPLAB_SPECIALITE_LABO.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SPLABEX_SPE_LABO_EXPLOITANT).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature1.SPLABEX_SPE_LABO_EXPLOITANT.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SPVO_SPECIALITE_VOIE).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature1.SPVO_SPECIALITE_VOIE.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, COSAC_COMPO_SUBACT).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature1.COSAC_COMPO_SUBACT.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, COSAU_COMPO_SUBAUX).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature1.COSAU_COMPO_SUBAUX.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, COMPO_COMPOSITION).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature1.COMPO_COMPOSITION.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, COTEN_COMPO_TENEUR).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature1.COTEN_COMPO_TENEUR.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SPADM_SPECIALITE_MODEADM).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature1.SPADM_SPECIALITE_MODEADM.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SPCPH_SPECIALITE_CLASSEPH).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature1.SPCPH_SPECIALITE_CLASSEPH.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SPDDD_DOSE_USUELLE_JOUR).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature1.SPDDD_DOSE_USUELLE_JOUR.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SPCH_SPECIALITE_CHOIX).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature1.SPCH_SPECIALITE_CHOIX.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SPRMO_SPECIALITE_RMO).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature1.SPRMO_SPECIALITE_RMO.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SPFTH_SPEC_INFOTHERAPEUTIQUE).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature1.SPFTH_SPEC_INFOTHERAPEUTIQUE.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SPFTR_SPECIALITE_TRANSPARENCE).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature1.SPFTR_SPECIALITE_TRANSPARENCE.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SPATR_SPEC_AVISTRANSPARENCE).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature1.SPATR_SPEC_AVISTRANSPARENCE.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SPSMR_SERVICE_MEDICAL_RENDU).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature1.SPSMR_SERVICE_MEDICAL_RENDU.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_Recap, SPCPD_SPE_CDT_PRESCR).CancelCurrentEdit()
        Me.DsTheriaque_Recap.SPCPD_SPE_CDT_PRESCR.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, PRIUCD_PRIX_UCD).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature1.PRIUCD_PRIX_UCD.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SPFOTX_SPE_FORME_TEXTE).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature1.SPFOTX_SPE_FORME_TEXTE.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SPTEN_SPECIALITE_TENEUR).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature1.SPTEN_SPECIALITE_TENEUR.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SP_SPECIALITE).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature1.SP_SPECIALITE.RejectChanges()

        Me.BindingContext(Me.DsTheriaqueURL, "SPURL_SPECIALITE_ADRESSE").CancelCurrentEdit()
        Me.DsTheriaqueURL.SPURL_SPECIALITE_ADRESSE.RejectChanges()

        If bModeDuplication Then EmptyDataTable()
        bModeDuplication = False
        OnLoading = False

    End Sub

    ''' <summary>
    ''' Vider tous les tables
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub EmptyDataTable()
        Me.DsTheriaque_Ref.SPAFS_SPECIALITE_AFSSAPS.Clear()

        Me.DsTheriaque_Nomenclature1.SYSP_SYNONYME_SPECIALITE.Clear()
        Me.DsTheriaque_Nomenclature1.SPLAB_SPECIALITE_LABO.Clear()
        Me.DsTheriaque_Nomenclature1.SPLABEX_SPE_LABO_EXPLOITANT.Clear()
        Me.DsTheriaque_Nomenclature1.SPVO_SPECIALITE_VOIE.Clear()

        Me.DsTheriaque_Nomenclature1.SPFOCFO_SPE_FORME_COMPFORME.Clear()
        Me.DsTheriaque_Nomenclature1.SPFOCPI_SPE_FORME_COMPINFO.Clear()
        Me.DsTheriaque_Nomenclature1.SPFO_SPECIALITE_FORME.Clear()
        Me.DsTheriaque_Nomenclature1.COSAC_COMPO_SUBACT.Clear()
        Me.DsTheriaque_Nomenclature1.COSAU_COMPO_SUBAUX.Clear()
        Me.DsTheriaque_Nomenclature1.COMPO_COMPOSITION.Clear()
        Me.DsTheriaque_Nomenclature1.COTEN_COMPO_TENEUR.Clear()
        Me.DsTheriaque_Nomenclature1.SPDDD_DOSE_USUELLE_JOUR.Clear()
        Me.DsTheriaque_Nomenclature1.SPADM_SPECIALITE_MODEADM.Clear()
        Me.DsTheriaque_Nomenclature1.SPCPH_SPECIALITE_CLASSEPH.Clear()
        Me.DsTheriaque_Nomenclature1.SPCH_SPECIALITE_CHOIX.Clear()
        Me.DsTheriaque_Nomenclature1.SPRMO_SPECIALITE_RMO.Clear()
        Me.DsTheriaque_Nomenclature1.SPFTH_SPEC_INFOTHERAPEUTIQUE.Clear()
        Me.DsTheriaque_Nomenclature1.SPFTR_SPECIALITE_TRANSPARENCE.Clear()
        Me.DsTheriaque_Nomenclature1.SPATR_SPEC_AVISTRANSPARENCE.Clear()
        Me.DsTheriaque_Nomenclature1.SPSMR_SERVICE_MEDICAL_RENDU.Clear()
        Me.DsTheriaque_Recap.SPCPD_SPE_CDT_PRESCR.Clear()
        Me.DsTheriaque_Nomenclature1.PRIUCD_PRIX_UCD.Clear()
        Me.DsTheriaque_Nomenclature1.SPFOTX_SPE_FORME_TEXTE.Clear()
        Me.DsTheriaque_Nomenclature1.SPTEN_SPECIALITE_TENEUR.Clear()
        Me.DsTheriaque_Nomenclature1.SP_SPECIALITE.Clear()
        Me.DsTheriaqueURL.SPURL_SPECIALITE_ADRESSE.Clear()
        For iCount As Integer = 0 To GV23.RowCount - 1
            GV23.DeleteRow(0)
        Next
        'GC23.DataSource = Nothing
    End Sub

    ''' <summary>
    ''' Proçédure: Duplication des données à partir d'une autre fiche
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub Dupliquer()

        If Not Tab_TA1 And CodE <> InvalidCode Then LoadTab_1()
        If Not Tab_TA2 And CodE <> InvalidCode Then LoadTab_2()
        If Not Tab_TA3 And CodE <> InvalidCode Then LoadTab_3()
        If Not Tab_TA4 And CodE <> InvalidCode Then LoadTab_4()
        If Not Tab_TA5 And CodE <> InvalidCode Then LoadTab_5()
        If Not Tab_TA6 And CodE <> InvalidCode Then LoadTab_6()
        If Not Tab_TA7 And CodE <> InvalidCode Then LoadTab_7()

        'Sauvegarde des données à duplquer
        doc = New DocumentService.DocumentProvider(strConnexion)
        DupArray = doc.GetDocsByTypeDoc(txtCode.Text, DocumentService.DocumentProvider.TypeDoc.Specialite)

        'Onglet1
        Dim sText1 As String = TextEdit5.Text
        Dim sLibelleProduit As String = Me.BindingContext(DsTheriaque_Nomenclature1, SP_SPECIALITE).Current("SP_PR_CODE_FK").ToString
        Dim sStatutLaboratoire As String = Me.BindingContext(DsTheriaque_Nomenclature1, SP_SPECIALITE).Current("SP_CDF_SLAB_CODE_FK").ToString
        Dim sListe As String = Me.BindingContext(DsTheriaque_Nomenclature1, SP_SPECIALITE).Current("SP_CDF_LI_CODE_FK").ToString


        Dim dt2 As New DataTable
        dt2 = DsTheriaque_Nomenclature1.SPLAB_SPECIALITE_LABO.Copy

        Dim dt3 As New DataTable
        dt3 = DsTheriaque_Nomenclature1.SPLABEX_SPE_LABO_EXPLOITANT.Copy

        'Onglet2
        Dim dt4 As New DataTable
        dt4 = DsTheriaque_Nomenclature1.SPFO_SPECIALITE_FORME.Copy

        Dim dt8 As New DataTable
        dt8 = DsTheriaque_Nomenclature1.SPVO_SPECIALITE_VOIE.Copy

        Dim dt5 As New DataTable
        dt5 = DsTheriaque_Nomenclature1.SPFOCFO_SPE_FORME_COMPFORME.Copy

        Dim dt6 As New DataTable
        dt6 = DsTheriaque_Nomenclature1.SPFOCPI_SPE_FORME_COMPINFO.Copy

        Dim dt7 As New DataTable
        dt7 = DsTheriaque_Nomenclature1.SPFOTX_SPE_FORME_TEXTE.Copy

        'Onglet3
        Dim dt9 As New DataTable
        dt9 = DsTheriaque_Nomenclature1.COMPO_COMPOSITION.Copy

        Dim dt10 As New DataTable
        dt10 = DsTheriaque_Nomenclature1.COSAU_COMPO_SUBAUX.Copy

        Dim dt11 As New DataTable
        dt11 = DsTheriaque_Nomenclature1.COSAC_COMPO_SUBACT.Copy

        Dim dt12 As New DataTable
        dt12 = DsTheriaque_Nomenclature1.COTEN_COMPO_TENEUR.Copy

        Dim sText2 As String = TextEdit15.Text

        'Onglet4
        Dim dt24 As New DataTable
        dt24 = DsTheriaque_Nomenclature1.SPTEN_SPECIALITE_TENEUR.Copy

        Dim dt25 As New DataTable
        dt25 = DsTheriaque_Nomenclature1.SPADM_SPECIALITE_MODEADM.Copy

        Dim dt13 As New DataTable
        dt13 = DsTheriaque_Nomenclature1.SPCPH_SPECIALITE_CLASSEPH.Copy

        Dim sATC As String = Me.BindingContext(DsTheriaque_Nomenclature1, SP_SPECIALITE).Current("SP_CATC_CODE_FK").ToString
        Dim sEphmra As String = Me.BindingContext(DsTheriaque_Nomenclature1, SP_SPECIALITE).Current("SP_CEPH_CODE_FK").ToString

        'Onglet6
        Dim dt20 As New DataTable
        dt20 = DsTheriaque_Recap.SPCPD_SPE_CDT_PRESCR.Copy
        Dim sText3 As String = MemoEdit2.Text

        'Vider les contrôles
        EmptyDataTable()

        'Construction de la nouvelle fiche avec les données de la fiche de base
        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        'SetCode_MAx(MasterTable, txtCode)
        txtCode.Text = Get_MAxCode()
        CodE = InvalidCode

        'Terrain
        'Pour les relations Master-Detail
        For iCount As Integer = 0 To dt4.Rows.Count - 1
            dt4.Rows(iCount)("SPFO_SP_CODE_FK_PK") = Me.txtCode.Text
        Next

        For iCount As Integer = 0 To dt5.Rows.Count - 1
            dt5.Rows(iCount)("SPFOCFO_SP_CODE_FK_PK") = Me.txtCode.Text
        Next

        For iCount As Integer = 0 To dt6.Rows.Count - 1
            dt6.Rows(iCount)("SPFOCPI_SP_CODE_FK_PK") = Me.txtCode.Text
        Next

        For iCount As Integer = 0 To dt9.Rows.Count - 1
            dt9.Rows(iCount)("COMPO_SP_CODE_FK_PK") = Me.txtCode.Text
        Next

        For iCount As Integer = 0 To dt11.Rows.Count - 1
            dt11.Rows(iCount)("COSAC_SP_CODE_FK_PK") = Me.txtCode.Text
        Next

        For iCount As Integer = 0 To dt10.Rows.Count - 1
            dt10.Rows(iCount)("COSAU_SP_CODE_FK_PK") = Me.txtCode.Text
        Next

        For iCount As Integer = 0 To dt8.Rows.Count - 1
            dt8.Rows(iCount)("SPVO_SP_CODE_FK_PK") = Me.txtCode.Text
        Next

        For iCount As Integer = 0 To dt24.Rows.Count - 1
            dt24.Rows(iCount)("SPTEN_SP_CODE_FK_PK") = Me.txtCode.Text
        Next

        For iCount As Integer = 0 To dt25.Rows.Count - 1
            dt25.Rows(iCount)("SPADM_SP_CODE_FK_PK") = Me.txtCode.Text
        Next

        For iCount As Integer = 0 To dt12.Rows.Count - 1
            dt12.Rows(iCount)("COTEN_SP_CODE_FK_PK") = Me.txtCode.Text
        Next

        Dim drTemp As DataRow
        For iCount As Integer = 0 To dt2.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature1.Tables("SPLAB_SPECIALITE_LABO").NewRow()
            drTemp.ItemArray = dt2.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature1.Tables("SPLAB_SPECIALITE_LABO").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt3.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature1.Tables("SPLABEX_SPE_LABO_EXPLOITANT").NewRow()
            drTemp.ItemArray = dt3.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature1.Tables("SPLABEX_SPE_LABO_EXPLOITANT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt4.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature1.Tables("SPFO_SPECIALITE_FORME").NewRow()
            drTemp.ItemArray = dt4.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature1.Tables("SPFO_SPECIALITE_FORME").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt8.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature1.Tables("SPVO_SPECIALITE_VOIE").NewRow()
            drTemp.ItemArray = dt8.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature1.Tables("SPVO_SPECIALITE_VOIE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt5.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature1.Tables("SPFOCFO_SPE_FORME_COMPFORME").NewRow()
            drTemp.ItemArray = dt5.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature1.Tables("SPFOCFO_SPE_FORME_COMPFORME").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt6.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature1.Tables("SPFOCPI_SPE_FORME_COMPINFO").NewRow()
            drTemp.ItemArray = dt6.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature1.Tables("SPFOCPI_SPE_FORME_COMPINFO").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt7.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature1.Tables("SPFOTX_SPE_FORME_TEXTE").NewRow()
            drTemp.ItemArray = dt7.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature1.Tables("SPFOTX_SPE_FORME_TEXTE").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt9.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature1.Tables("COMPO_COMPOSITION").NewRow()
            drTemp.ItemArray = dt9.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature1.Tables("COMPO_COMPOSITION").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt10.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature1.Tables("COSAU_COMPO_SUBAUX").NewRow()
            dt10.Rows(iCount).Item("COSAU_GREF_CODE_FK") = DBNull.Value
            drTemp.ItemArray = dt10.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature1.Tables("COSAU_COMPO_SUBAUX").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt11.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature1.Tables("COSAC_COMPO_SUBACT").NewRow()
            drTemp.ItemArray = dt11.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature1.Tables("COSAC_COMPO_SUBACT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt12.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature1.Tables("COTEN_COMPO_TENEUR").NewRow()
            drTemp.ItemArray = dt12.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature1.Tables("COTEN_COMPO_TENEUR").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt24.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature1.Tables("SPTEN_SPECIALITE_TENEUR").NewRow()
            drTemp.ItemArray = dt24.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature1.Tables("SPTEN_SPECIALITE_TENEUR").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt25.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature1.Tables("SPADM_SPECIALITE_MODEADM").NewRow()
            drTemp.ItemArray = dt25.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature1.Tables("SPADM_SPECIALITE_MODEADM").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt13.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature1.Tables("SPCPH_SPECIALITE_CLASSEPH").NewRow()
            drTemp.ItemArray = dt13.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature1.Tables("SPCPH_SPECIALITE_CLASSEPH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt20.Rows.Count - 1
            drTemp = Me.DsTheriaque_Recap.Tables("SPCPD_SPE_CDT_PRESCR").NewRow()
            drTemp.ItemArray = dt20.Rows(iCount).ItemArray
            Me.DsTheriaque_Recap.Tables("SPCPD_SPE_CDT_PRESCR").Rows.Add(drTemp)
        Next

        TextEdit5.Text = sText1
        If sLibelleProduit <> "" Then Me.BindingContext(DsTheriaque_Nomenclature1, SP_SPECIALITE).Current("SP_PR_CODE_FK") = sLibelleProduit
        If sStatutLaboratoire <> "" Then Me.BindingContext(DsTheriaque_Nomenclature1, SP_SPECIALITE).Current("SP_CDF_SLAB_CODE_FK") = sStatutLaboratoire
        If sListe <> "" Then Me.BindingContext(DsTheriaque_Nomenclature1, SP_SPECIALITE).Current("SP_CDF_LI_CODE_FK") = sListe
        TextEdit15.Text = sText2
        MemoEdit2.Text = sText3
        If sATC <> "" Then Me.BindingContext(DsTheriaque_Nomenclature1, SP_SPECIALITE).Current("SP_CATC_CODE_FK") = sATC
        If sEphmra <> "" Then Me.BindingContext(DsTheriaque_Nomenclature1, SP_SPECIALITE).Current("SP_CEPH_CODE_FK") = sEphmra


        ModifierCode()
        bModeDuplication = True
        MyBase.Dupliquer()
        Try
            Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        Catch ex As Exception

        End Try

        btImporter.Enabled = False
        BtSupprim.Enabled = False

        XtraTabControl1.SelectedTabPageIndex = 0
    End Sub

    ''' <summary>
    ''' Proçédure: Modifier code Master de la fiche
    ''' </summary>
    Private Sub ModifierCode()
        'GV2
        For iCount As Integer = 0 To GV2.RowCount - 1
            GV2.SetRowCellValue(iCount, colSPLAB_SP_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV3
        For iCount As Integer = 0 To GV3.RowCount - 1
            GV3.SetRowCellValue(iCount, colSPLABEX_SP_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV8
        'For iCount As Integer = 0 To GV8.RowCount - 1
        '    GV8.SetRowCellValue(iCount, colSPVO_SP_CODE_FK_PK, Me.txtCode.Text)
        'Next
        'GV7
        For iCount As Integer = 0 To GV7.RowCount - 1
            GV7.SetRowCellValue(iCount, colSPFOTX_SP_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV12
        For iCount As Integer = 0 To GV12.RowCount - 1
            GV12.SetRowCellValue(iCount, colCOTEN_SP_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV24
        For iCount As Integer = 0 To GV24.RowCount - 1
            GV24.SetRowCellValue(iCount, colSPTEN_SP_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV25
        For iCount As Integer = 0 To GV25.RowCount - 1
            GV25.SetRowCellValue(iCount, colSPADM_SP_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV13
        For iCount As Integer = 0 To GV13.RowCount - 1
            GV13.SetRowCellValue(iCount, colSPCPH_SP_CODE_FK_PK, Me.txtCode.Text)
        Next

        'GV20
        For iCount As Integer = 0 To GV20.RowCount - 1
            GV20.SetRowCellValue(iCount, colSPCPD_SP_CODE_FK_PK, Me.txtCode.Text)
        Next




    End Sub

#End Region

#Region " Init Data  "

    ''' <summary>
    ''' affecter les datasource aux Grid
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitDataSource()

        GC1.DataSource = DsTheriaque_Nomenclature1
        GC1.DataMember = "SYSP_SYNONYME_SPECIALITE"

        GC2.DataSource = DsTheriaque_Nomenclature1
        GC2.DataMember = "SPLAB_SPECIALITE_LABO"

        GC3.DataSource = DsTheriaque_Nomenclature1
        GC3.DataMember = "SPLABEX_SPE_LABO_EXPLOITANT"

        GC8.DataSource = DsTheriaque_Nomenclature1
        GC8.DataMember = "SPVO_SPECIALITE_VOIE"

        GC4.DataSource = DsTheriaque_Nomenclature1
        GC4.DataMember = "SPFO_SPECIALITE_FORME"

        GC5.DataSource = DsTheriaque_Nomenclature1
        GC5.DataMember = "SPFO_SPECIALITE_FORME.FK_SPFO_SPECIALITE_FORME_SPFOCFO_SPE_FORME_COMPFORME"

        GC6.DataSource = DsTheriaque_Nomenclature1
        GC6.DataMember = "SPFO_SPECIALITE_FORME.FK_SPFO_SPECIALITE_FORME_SPFOCPI_SPE_FORME_COMPINFO"

        GC7.DataSource = DsTheriaque_Nomenclature1
        GC7.DataMember = "SPFOTX_SPE_FORME_TEXTE"

        GC9.DataSource = DsTheriaque_Nomenclature1
        GC9.DataMember = "COMPO_COMPOSITION"

        GC11.DataSource = DsTheriaque_Nomenclature1
        GC11.DataMember = "COMPO_COMPOSITION.FK3_COSAC_COMPO_SUBACT"

        GC10.DataSource = DsTheriaque_Nomenclature1
        GC10.DataMember = "COMPO_COMPOSITION.FK3_COSAU_COMPO_SUBAUX"

        GC12.DataSource = DsTheriaque_Nomenclature1
        GC12.DataMember = "COTEN_COMPO_TENEUR"

        GC24.DataSource = DsTheriaque_Nomenclature1
        GC24.DataMember = "SPTEN_SPECIALITE_TENEUR"

        GC25.DataSource = DsTheriaque_Nomenclature1
        GC25.DataMember = "SPADM_SPECIALITE_MODEADM"

        GC31.DataSource = DsTheriaqueURL
        GC31.DataMember = "SPURL_SPECIALITE_ADRESSE"

    End Sub

    ''' <summary>
    ''' Chargement des données de la fiche
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub InitData()
        'Exit Sub
        MyBase.InitData()
        OnLoading = True
        MasterDataSet = Me.DsTheriaque_Nomenclature1
        MasterTable = SP_SPECIALITE
        CodE = InvalidCode

        InitLkup(Me.lkupMedVirt, GSP_GENERIQUE_SPECIALITE, strSSQL_GSP_GENERIQUE_SPECIALITE, False)
        InitLkup(Me.lkupProduit, PR_PRODUIT, strSSQL_PR_PRODUIT, True)
        InitLkup(Me.lkupListe, CDF_CODIF, strSSQL_CDF_CODIF("08"), True)

        InitLkup(Me.lkupProduitCode, PR_PRODUIT, strSSQL_PR_PRODUIT, False, True, True, True)

        InitLkup(Me.rpLabo, CDF_CODIF, strSSQL_CDF_CODIF("07"), True)
        InitLkup(Me.lkupStLab, CDF_CODIF, strSSQL_CDF_CODIF("15"), True)
        InitLkup(Me.rpLabX, CDF_CODIF, strSSQL_CDF_CODIF("07"), True)

        InitLkup(Me.lkupDDD, CDF_CODIF, strSSQL_CDF_CODIF("18"), True)
        InitLkup(Me.lkupDDD1, CDF_CODIF, strSSQL_CDF_CODIF("19"), True)
        InitDataSource()
        FirstFocus = txtLibelle
        OnLoading = False
    End Sub

#End Region

#Region " Load Tab   "

    ''' <summary>
    ''' Chargement de la 2éme page
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadTab_1()
        Load_On(Me)
        OnLoading = True
        'Test_SPFOTX_TEXTE()
        If Not Tab_lkup1 Then
            InitLkup(Me.rpVoie, CDF_CODIF, strSSQL_CDF_CODIF("18"), True)
            InitLkup(Me.rpCompl, CDF_CODIF, strSSQL_CDF_CODIF("02"), True)
            InitLkup(Me.rpInfo, CDF_CODIF, strSSQL_CDF_CODIF("26"), True)
            InitLkup(Me.rpFormePh, CDF_CODIF, strSSQL_CDF_CODIF("06"), True)
            Tab_lkup1 = True
        End If

        If Not Tab_TA1 And CodE <> InvalidCode Then
            Me.SpvO_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SPVO_SPECIALITE_VOIE, CodE)
            On Error Resume Next
            Me.SpfocfO_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SPFOCFO_SPE_FORME_COMPFORME, CodE)
            Me.SpfocpI_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SPFOCPI_SPE_FORME_COMPINFO, CodE)
            Me.SpfotX_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SPFOTX_SPE_FORME_TEXTE, CodE)
            Me.SpfO_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SPFO_SPECIALITE_FORME, CodE)
            On Error GoTo 0

            Tab_TA1 = True
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub

    ''' <summary>
    ''' Chargement de la 3éme page
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadTab_2()
        Load_On(Me)
        OnLoading = True
        If Not Tab_lkup2 Then
            InitLkup(Me.rpSubActive, SAC_SUBACTIVE, strSSQL_SAC_SUBACTIVE, True)
            InitLkup(Me.rpUnite, CDF_CODIF, strSSQL_CDF_CODIF_Libelle("19"), True)
            InitLkup(Me.rpComposition, CDF_CODIF, strSSQL_CDF_CODIF("22"), True)
            InitLkup(Me.rpExcipient, SAU_SUBAUXILIAIRE, strSSQL_SAU_SUBAUXILIAIRE, True)
            InitLkup(Me.rpNotoire, SAU_SUBAUXILIAIRE, strSSQL_SAU_SUBAUXILIAIRE_NOTOIRE, True)
            InitLkup(Me.rpUnite2, CDF_CODIF, strSSQL_CDF_CODIF_Libelle("19"), True)
            InitLkup(Me.rpTeneur, CDF_CODIF, strSSQL_CDF_CODIF("24"), True)
            InitLkup(Me.rpUnite3, CDF_CODIF, strSSQL_CDF_CODIF("19"), True)
            InitLkup(Me.rpUnite4, CDF_CODIF, strSSQL_CDF_CODIF("19"), True)

            Tab_lkup2 = True
        End If

        If Not Tab_TA2 And CodE <> InvalidCode Then
            Me.CompO_TA.FillByCode(Me.DsTheriaque_Nomenclature1.COMPO_COMPOSITION, CodE)
            Me.CosaC_TA.FillByCode(Me.DsTheriaque_Nomenclature1.COSAC_COMPO_SUBACT, CodE)
            Me.CosaU_TA.FillByCode(Me.DsTheriaque_Nomenclature1.COSAU_COMPO_SUBAUX, CodE)
            'Me.SpfocpI_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SPFOCPI_SPE_FORME_COMPINFO, CodE)
            Me.CoteN_TA.FillByCode(Me.DsTheriaque_Nomenclature1.COTEN_COMPO_TENEUR, CodE)
            'Me.SpatR_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SPATR_SPEC_AVISTRANSPARENCE, CodE)
            Tab_TA2 = True
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub

    ''' <summary>
    ''' Chargement de la 4éme page
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadTab_3()
        Load_On(Me)
        OnLoading = True



        Dim strSQL1 As String = ""
        'strSQL1 = strSSQL_CPH_CLASSEPHARMTHER
        'strSQL1 &= " where CPH_CODE_PK  not in  "
        'strSQL1 &= " (Select distinct isnull(CPH_CPH_CODE_FK,'') From THERIAQUE.CPH_CLASSEPHARMTHER )"
        strSQL1 = strSSQL_CPH_CLASSEPHARMTHER2
        InitLkup(Me.rpClasseEphmra, CPH_CLASSEPHARMTHER, strSQL1, True)
        InitLkup(Me.rpClasseEphmra2, CPH_CLASSEPHARMTHER, strSQL1, True, , , True)

        strSQL1 = ""
        strSQL1 &= " select CATC_CODE_PK  into  #Yaks from THERIAQUE.CATC_CLASSEATC "
        strSQL1 &= " except  "
        strSQL1 &= " select CATC_CATC_CODE_FK From THERIAQUE.CATC_CLASSEATC "
        strSQL1 &= " select #Yaks.CATC_CODE_PK as code, c.CATC_NOMF as libelle from #Yaks, THERIAQUE.CATC_CLASSEATC c "
        strSQL1 &= " where c.CATC_CODE_PK = #Yaks.CATC_CODE_PK "
        strSQL1 &= " drop table #Yaks "
        InitLkup(Me.lkupATC, CATC_CLASSEATC, strSQL1, True, False, True, True)
        InitLkup(Me.lkupATC2, CATC_CLASSEATC, strSQL1, True)

        InitLkup(Me.lkupDDD, CDF_CODIF, strSSQL_CDF_CODIF("18"), True)
        InitLkup(Me.lkupDDD1, CDF_CODIF, strSSQL_CDF_CODIF("19"), True)


        strSQL1 = strSSQL_CEPH_CLASSEEPHMRA
        strSQL1 &= " where CEPH_CODE_PK  not in  "
        strSQL1 &= " (Select distinct isnull(CEPH_CEPH_CODE_FK,'') From THERIAQUE.CEPH_CLASSEEPHMRA )"
        InitLkup(Me.lkupEphemra, CEPH_CLASSEEPHMRA, strSQL1, False, , , True)
        InitLkup(Me.lkupEphemra2, CEPH_CLASSEEPHMRA, strSQL1, True)

        InitLkup(Me.lkupGestion, CGE_CLASSEGESTION, strSSQL_CGE_CLASSEGESTION, False, , , True)
        InitLkup(Me.lkupGestion2, CGE_CLASSEGESTION, strSSQL_CGE_CLASSEGESTION, True)

        GC13.DataSource = DsTheriaque_Nomenclature1
        GC13.DataMember = "SPCPH_SPECIALITE_CLASSEPH"

        GCDDD.DataSource = DsTheriaque_Nomenclature1
        GCDDD.DataMember = "SPDDD_DOSE_USUELLE_JOUR"

        Tab_lkup3 = True


        If CodE <> InvalidCode Then

            Me.SpadM_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SPADM_SPECIALITE_MODEADM, CodE)
            Me.SpcpH_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SPCPH_SPECIALITE_CLASSEPH, CodE)
            Me.SpddD_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SPDDD_DOSE_USUELLE_JOUR, CodE)
            Me.SpteN_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SPTEN_SPECIALITE_TENEUR, CodE)

            InitLkup(Me.lkupDDD, CDF_CODIF, strSSQL_CDF_CODIF("18"), True)
            InitLkup(Me.lkupDDD1, CDF_CODIF, strSSQL_CDF_CODIF("19"), True)
            Tab_TA3 = True
        End If

        OnLoading = False
        Load_Off(Me)
    End Sub

    ''' <summary>
    ''' Chargement de la 5éme page
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadTab_4()
        Load_On(Me)
        OnLoading = True

        If Not Tab_lkup4 Then
            InitLkup(Me.rpChoix, CH_CHOIX, strSSQL_CH_CHOIX, True)

            InitLkup(Me.rpRMO, RMO, strSSQL_RMO, True)
            InitLkup(Me.rpRMO2, RMO, strSSQL_RMO, False, False, True, True)

            InitLkup(Me.rpCLRMO_CLASSE_RMO3, CLRMO_CLASSE_RMO, strSSQL_CLRMO_CLASSE_RMO, True)
            rpCLRMO_CLASSE_RMO3.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
            InitLkupCodeLibelle(Me.rpCLRMO_CLASSE_RMO2, CLRMO_CLASSE_RMO, strSSQL_CLRMO_CLASSE_RMO, False, False, True, True, rpCLRMO_CLASSE_RMO)

            InitLkup(Me.rpInfoth, FTH_FICHEINFOTHERAPEUTIQUE, strSSQL_FTH_FICHEINFOTHERAPEUTIQUE, True)
            InitLkup(Me.rpInfoth2, FTH_FICHEINFOTHERAPEUTIQUE, strSSQL_FTH_FICHEINFOTHERAPEUTIQUE, False, False, True, True)

            InitLkup(Me.rpTransparence, FTR_FICHETRANSPARENCE, strSSQL_FTR_FICHETRANSPARENCE, True)
            InitLkup(Me.rpTransparence2, FTR_FICHETRANSPARENCE, strSSQL_FTR_FICHETRANSPARENCE, False, False, True, True)

            InitLkup(Me.rpAvisCom, ATR_AVISCOMMISSIONTRANSPARENCE, strSSQL_ATR_AVISCOMMISSIONTRANSPARENCE, True)
            InitLkup(Me.rpAvisCom2, ATR_AVISCOMMISSIONTRANSPARENCE, strSSQL_ATR_AVISCOMMISSIONTRANSPARENCE, False, False, True, True)


            Me.GC14.DataSource = Me.DsTheriaque_Nomenclature1
            Me.GC14.DataMember = "SPCH_SPECIALITE_CHOIX"
            Me.GC15.DataSource = Me.DsTheriaque_Nomenclature1
            Me.GC15.DataMember = "SPRMO_SPECIALITE_RMO"
            Me.GC16.DataSource = Me.DsTheriaque_Nomenclature1
            Me.GC16.DataMember = "SPFTH_SPEC_INFOTHERAPEUTIQUE"
            Me.GC17.DataSource = Me.DsTheriaque_Nomenclature1
            Me.GC17.DataMember = "SPFTR_SPECIALITE_TRANSPARENCE"
            Me.GC18.DataSource = Me.DsTheriaque_Nomenclature1
            Me.GC18.DataMember = "SPATR_SPEC_AVISTRANSPARENCE"
            Me.GC19.DataSource = Me.DsTheriaque_Nomenclature1
            Me.GC19.DataMember = "SPSMR_SERVICE_MEDICAL_RENDU"
            Tab_lkup4 = True
        End If

        If Not Tab_TA4 And CodE <> InvalidCode Then
            Me.SpcH_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SPCH_SPECIALITE_CHOIX, CodE)
            Me.SprmO_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SPRMO_SPECIALITE_RMO, CodE)
            Me.SpftH_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SPFTH_SPEC_INFOTHERAPEUTIQUE, CodE)
            Me.SpftR_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SPFTR_SPECIALITE_TRANSPARENCE, CodE)
            Me.SpatR_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SPATR_SPEC_AVISTRANSPARENCE, CodE)
            Me.SpsmR_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SPSMR_SERVICE_MEDICAL_RENDU, CodE)

            If Not ModeFiche = eMode.Ajout Then
                If txtCode.Text <> "" Then
                    'Dim strSSQL As String = "SELECT CDF_CODE_PK as code, CDF_NOM as libelle, CDF_NUMERO_PK as num From THERIAQUE.CDF_CODIF "
                    'strSSQL &= " WHERE CDF_NUMERO_PK = '27' "
                    'strSSQL &= " AND CDF_CODE_PK IN (SELECT ATRSMR_CDF_SMR_CODE_FK_PK FROM THERIAQUE.ATRSMR_AVISCOMTRANS_SMR"
                    'strSSQL &= " WHERE ATRSMR_ATR_CODE_FK_PK IN "
                    'strSSQL &= " (SELECT SPATR_ATR_CODE_FK_PK FROM THERIAQUE.SPATR_SPEC_AVISTRANSPARENCE WHERE SPATR_SP_CODE_FK_PK = " & cn.SQLText(txtCode.Text) & "))"
                    'strSSQL &= " UNION "
                    'strSSQL &= " SELECT CDF_CODE_PK as code, CDF_NOM as libelle, CDF_NUMERO_PK as num From THERIAQUE.CDF_CODIF "
                    'strSSQL &= " WHERE CDF_NUMERO_PK = '27' "
                    'strSSQL &= " AND CDF_CODE_PK IN "
                    'strSSQL &= " (SELECT SPSMR_CDF_SMR_CODE_FK_PK FROM THERIAQUE.SPSMR_SERVICE_MEDICAL_RENDU WHERE SPSMR_SP_CODE_FK_PK = " & cn.SQLText(txtCode.Text) & ")"
                    'InitLkup(Me.rpSMR, CDF_CODIF, strSSQL, True)
                    InitLkup(Me.rpSMR, CDF_CODIF, strSSQL_CDF_CODIF("27"), True)
                End If
            End If
            Tab_TA4 = True
        End If

        OnLoading = False
        Load_Off(Me)
    End Sub

    ''' <summary>
    ''' Chargement de la 6éme page
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadTab_5()
        Load_On(Me)
        OnLoading = True
        If Not Tab_lkup5 Then
            InitLkup(Me.rpPresDev, CDF_CODIF, strSSQL_CDF_CODIF("14") & " and substring(CDF_CODE_PK,1,1) = 'S'", True)
            InitLkup(Me.rpPresDev2, CDF_CODIF, strSSQL_CDF_CODIF("14") & " and substring(CDF_CODE_PK,1,1) = 'S'", False, False, True, True)
            InitLkup(Me.rpRUB, RUBCDF_RUBRIQUE_CODIFICATION, strSSQL_RUBCDF_RUBRIQUE_CODIFICATION, True)
            InitLkup(Me.rpRef, CDF_CODIF, strSSQL_CDF_CODIF("25"), True)

            Dim TT(1) As IRecords
            TT(0) = New IRecords(1, "Rétrocession")
            TT(1) = New IRecords(2, "T2A (HORS GHS)")
            rpPrix.DataSource = TT

            GC20.DataSource = Me.DsTheriaque_Recap
            GC20.DataMember = "SPCPD_SPE_CDT_PRESCR"
            GC21.DataSource = Me.DsTheriaque_Nomenclature1
            GC21.DataMember = "PRIUCD_PRIX_UCD"

            Tab_lkup5 = True
        End If

        If Not Tab_TA5 And CodE <> InvalidCode Then
            Me.SpcpD_TA.FillByCode(Me.DsTheriaque_Recap.SPCPD_SPE_CDT_PRESCR, CodE)
            Me.SpafS_TA.FillByCode(Me.DsTheriaque_Ref.SPAFS_SPECIALITE_AFSSAPS, CodE)

            If Me.BindingContext(Me.DsTheriaque_Nomenclature1, MasterTable).Current("SP_CIPUCD") IsNot DBNull.Value Then
                GC21.DataSource = MasterDataSet
                Me.PriucD_TA.FillByCode(Me.DsTheriaque_Nomenclature1.PRIUCD_PRIX_UCD, Me.BindingContext(Me.DsTheriaque_Nomenclature1, MasterTable).Current("SP_CIPUCD"))
                GC21.Enabled = True
            Else
                GC21.Enabled = False
                GC21.DataSource = Nothing
            End If
            Tab_TA5 = True
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub

    ''' <summary>
    ''' Chargement de la 6éme page
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadTab_6()
        Load_On(Me)
        OnLoading = True
        If Not Tab_lkup6 Then
            InitLkup(Me.rpRUB, RUBCDF_RUBRIQUE_CODIFICATION, strSSQL_RUBCDF_RUBRIQUE_CODIFICATION, True)
            InitLkup(Me.rpRef, CDF_CODIF, strSSQL_CDF_CODIF("25"), True)

            Tab_lkup6 = True
        End If

        If Not Tab_TA6 And CodE <> InvalidCode Then
            Me.SpafS_TA.FillByCode(Me.DsTheriaque_Ref.SPAFS_SPECIALITE_AFSSAPS, CodE)
            GC23.DataSource = cn.MySelect("Select * from THERIAQUE.PRE_PRESENTATION where PRE_SP_CODE_FK = " & txtCode.Text)
            Tab_TA6 = True
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub

    ''' <summary>
    ''' Chargement de l'onglet URL
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadTab_7()
        Load_On(Me)
        OnLoading = True
        'If txtCode.Text <> "" Then
        '    Dim sSql As String = ""
        '    Dim sSqlUrl As String = ""
        '    Dim sSqlAllUrl As String = ""
        '    Dim bIsNotFirst As Boolean = False
        '    Dim sTemp As String = ""
        '    Dim dt As DataTable = cn.MySelect("SELECT * FROM THERIAQUE.SPURL_SPECIALITE_ADRESSE WHERE SPURL_CODE_SP_PK_FK = " & cn.SQLText(txtCode.Text))
        '    For iCount As Integer = 0 To dt.Rows.Count - 1
        '        If dt.Rows(iCount)("SPURL_AUTO") = True Then
        '            sSql = "SELECT SPURL.SPURL_AUTO, URL.URL_TYPE, URL.URL_FIXE, URL.URL_SP_CHAMPS  FROM THERIAQUE.SPURL_SPECIALITE_ADRESSE AS SPURL, THERIAQUE.URL_ADRESSE AS URL"
        '            sSql &= " WHERE URL.URL_CODE_PK = SPURL.SPURL_CODE_URL_PK_FK"
        '            sSql &= " AND SPURL.SPURL_CODE_URL_PK_FK =" & cn.SQLText(dt.Rows(iCount)("SPURL_CODE_URL_PK_FK"))
        '            sSql &= " AND SPURL.SPURL_CODE_SP_PK_FK =" & cn.SQLText(dt.Rows(iCount)("SPURL_CODE_SP_PK_FK"))
        '            Dim dt2 As DataTable = cn.MySelect(sSql)
        '            If dt2.Rows.Count > 0 Then
        '                sSql = "SELECT " & dt2.Rows(0)("URL_SP_CHAMPS")
        '                sSql &= " FROM THERIAQUE.SP_SPECIALITE WHERE SP_CODE_SQ_PK = " & cn.SQLText(dt.Rows(iCount)("SPURL_CODE_SP_PK_FK"))
        '                If Not cn.ExecuteScalar(sSql) Is DBNull.Value Then
        '                    sTemp = cn.SQLText(Replace(cn.ExecuteScalar(sSql), " ", ""))
        '                Else
        '                    sTemp = "''"
        '                End If
        '                sSqlUrl = "SELECT URL.URL_CODE_PK, SPURL.SPURL_AUTO, URL.URL_TYPE, URL.URL_FIXE +" & sTemp & " AS URL_FIXE"
        '                sSqlUrl &= ", URL.URL_SP_CHAMPS FROM THERIAQUE.SPURL_SPECIALITE_ADRESSE AS SPURL, THERIAQUE.URL_ADRESSE AS URL"
        '                sSqlUrl &= " WHERE URL.URL_CODE_PK = SPURL.SPURL_CODE_URL_PK_FK"
        '                sSqlUrl &= " AND SPURL.SPURL_CODE_URL_PK_FK=" & cn.SQLText(dt.Rows(iCount)("SPURL_CODE_URL_PK_FK"))
        '                sSqlUrl &= " AND SPURL.SPURL_CODE_SP_PK_FK=" & cn.SQLText(dt.Rows(iCount)("SPURL_CODE_SP_PK_FK"))

        '            End If

        '            If bIsNotFirst Then
        '                sSqlAllUrl &= "UNION " & sSqlUrl
        '            Else
        '                sSqlAllUrl &= sSqlUrl
        '            End If

        '            bIsNotFirst = True
        '        Else
        '            sSqlUrl = "SELECT URL.URL_CODE_PK, SPURL.SPURL_AUTO, URL.URL_TYPE, SPURL.SPURL_ADRESSE AS URL_FIXE, '' FROM THERIAQUE.SPURL_SPECIALITE_ADRESSE AS SPURL, THERIAQUE.URL_ADRESSE AS URL"
        '            sSqlUrl &= " WHERE URL.URL_CODE_PK = SPURL.SPURL_CODE_URL_PK_FK"
        '            sSqlUrl &= " AND SPURL.SPURL_CODE_URL_PK_FK =" & cn.SQLText(dt.Rows(iCount)("SPURL_CODE_URL_PK_FK"))
        '            sSqlUrl &= " AND SPURL.SPURL_CODE_SP_PK_FK =" & cn.SQLText(dt.Rows(iCount)("SPURL_CODE_SP_PK_FK"))
        '            If bIsNotFirst Then
        '                sSqlAllUrl &= "UNION " & sSqlUrl
        '            Else
        '                sSqlAllUrl &= sSqlUrl
        '            End If
        '            bIsNotFirst = True
        '        End If
        '    Next
        '    Tab_TA7 = True
        '    If dt.Rows.Count > 0 Then
        '        GC31.DataSource = cn.MySelect(sSqlAllUrl)
        '    End If
        'End If

        'If Not Tab_lkup7 Then
        '    InitLkup(Me.Rp_TypeURL, URL_ADRESSE, strSSQL_URL, True)
        '    Tab_lkup7 = True
        'End If
        If Not Tab_TA7 And CodE <> InvalidCode Then
            Me.SpurL_TA.FillByCode(Me.DsTheriaqueURL.SPURL_SPECIALITE_ADRESSE, CodE)
            InitLkup(Me.Rp_TypeURL, URL_ADRESSE, strSSQL_URL, True)
            Tab_TA7 = True
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
        If XtraTabControl1.SelectedTabPageIndex = 6 Then
            LoadTab_6()
            Exit Sub
        End If
        If XtraTabControl1.SelectedTabPageIndex = 7 Then
            LoadTab_7()
            Exit Sub
        End If
    End Sub

#End Region

#Region " Sub, Utils, Others ...."

    ''' <summary>
    ''' Update filtre RMO selon la colonne qui la précéde
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Update_rpCLRMO_CLASSE_RMO(Optional ByVal strEvenement As String = "")
        If OnLoading Then Exit Sub
        If RowSel(GC15) Then
            If GV15.GetRowCellValue(GV15.FocusedRowHandle, colSPRMO_RMO_CODE_FK_PK) Is Nothing Then Exit Sub
            Dim dv As New DataView
            Dim ValFilter As Integer
            If strEvenement <> "" Then
                ValFilter = Convert.ToInt16(strEvenement)
            Else
                If GV15.GetRowCellValue(GV15.FocusedRowHandle, colSPRMO_RMO_CODE_FK_PK) IsNot DBNull.Value Then
                    ValFilter = GV15.GetRowCellValue(GV15.FocusedRowHandle, colSPRMO_RMO_CODE_FK_PK)
                Else
                    If GV15.GetRowCellValue(GV15.FocusedRowHandle, colSPRMO_RMO_CODE_FK_PK2) IsNot DBNull.Value Then
                        ValFilter = GV15.GetRowCellValue(GV15.FocusedRowHandle, colSPRMO_RMO_CODE_FK_PK2)
                    Else
                        Exit Sub
                    End If
                End If
            End If
            dv = rpCLRMO_CLASSE_RMO3.DataSource.DefaultView
            dv.RowFilter = "CLRMO_RMO_CODE_FK_PK = " & ValFilter
        End If
    End Sub

    ''' <summary>
    ''' Ajout d'une ligne dans SPFOTX_SPE_FORME_TEXTE en cas d'absence
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Test_SPFOTX_TEXTE()
        If txtCode.Text = "" Then Exit Sub
        If Not cn.HasRow("THERIAQUE.SPFOTX_SPE_FORME_TEXTE", " SPFOTX_SP_CODE_FK_PK = " & txtCode.Text) Then
            cn.Execute("Insert Into THERIAQUE.SPFOTX_SPE_FORME_TEXTE Values (" & txtCode.Text & ",'')")
        End If
    End Sub

    ''' <summary>
    ''' Affecter un DDD
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>
    ''' Ajouter un DDD en cas de non existance
    ''' Mettre à jour le DDD si il existe
    ''' </remarks>
    Private Sub btDDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDDD.Click
        If lkupATC.EditValue IsNot Nothing Then
            Dim f As New Frm_Dictionnaire
            Dim strSSQL As String = ""
            strSSQL &= " Select ATCDDD_CATC_CODE_FK_PK as code ,  "
            strSSQL &= " (select CDF_NOM  From THERIAQUE.CDF_CODIF A "
            strSSQL &= " where CDF_NUMERO_PK = '18' and A.CDF_CODE_PK = H.ATCDDD_CDF_VO_CODE_FK_PK ) "
            strSSQL &= " + ' - '+ "
            strSSQL &= " + cast(H.ATCDDD_DOSAGE_PK as  varchar ) "
            strSSQL &= " + ' - '+ "
            strSSQL &= " (select CDF_NOM  From THERIAQUE.CDF_CODIF A  "
            strSSQL &= " where CDF_NUMERO_PK = '19' and A.CDF_CODE_PK = H.ATCDDD_CDF_UD_CODE_FK_PK )  "
            strSSQL &= " as libelle, ATCDDD_CDF_VO_CODE_FK_PK as val1, ATCDDD_DOSAGE_PK as val2, ATCDDD_CDF_UD_CODE_FK_PK as val3 "
            strSSQL &= " from THERIAQUE.ATCDDD_DOSE_USUELLE_JOUR H "
            strSSQL &= " where ATCDDD_CATC_CODE_FK_PK = " & cn.SQLText(lkupATC2.EditValue)
            strSSQL &= " Order by  ATCDDD_CATC_CODE_FK_PK "
            f._SSQL = strSSQL
            f.colVal1.Visible = False
            f.colVal2.Visible = False
            f.colVal3.Visible = False

            f.ShowDialog()
            If f._Code IsNot Nothing Then
                GVDDD.AddNewRow()
                GVDDD.SetFocusedRowCellValue(colSPDDD_ATCDDD_CATC_CODE_FK_PK, f._Code)
                GVDDD.SetFocusedRowCellValue(colSPDDD_ATCDDD_CDF_VO_CODE_FK_PK, f._Collection(1))
                GVDDD.SetFocusedRowCellValue(colSPDDD_ATCDDD_DOSAGE_PK, f._Collection(2))
                GVDDD.SetFocusedRowCellValue(colSPDDD_ATCDDD_CDF_UD_CODE_FK_PK, f._Collection(3))
            End If
        End If
        '    If f._Code IsNot Nothing Then
        '        If Me.BindingContext(Me.MasterDataSet, "SPDDD_DOSE_USUELLE_JOUR").Count = 0 Then
        '            Dim dt As DataTable = cn.MySelect("Select * from THERIAQUE.ATCDDD_DOSE_USUELLE_JOUR where ATCDDD_CATC_CODE_FK_PK = " & cn.SQLText(f._Code) & " and ATCDDD_CDF_VO_CODE_FK_PK = " & cn.SQLText(f._Collection(1)))
        '            Me.BindingContext(Me.MasterDataSet, "SPDDD_DOSE_USUELLE_JOUR").AddNew()
        '            Me.BindingContext(Me.MasterDataSet, "SPDDD_DOSE_USUELLE_JOUR").Current("SPDDD_ATCDDD_CATC_CODE_FK_PK") = f._Code
        '            Me.BindingContext(Me.MasterDataSet, "SPDDD_DOSE_USUELLE_JOUR").Current("SPDDD_SP_CODE_FK_PK") = txtCode.Text
        '            Me.BindingContext(Me.MasterDataSet, "SPDDD_DOSE_USUELLE_JOUR").Current("SPDDD_ATCDDD_CDF_VO_CODE_FK_PK") = dt.Rows(0)("ATCDDD_CDF_VO_CODE_FK_PK")
        '            Me.BindingContext(Me.MasterDataSet, "SPDDD_DOSE_USUELLE_JOUR").Current("SPDDD_ATCDDD_DOSAGE_PK") = dt.Rows(0)("ATCDDD_DOSAGE_PK")
        '            Me.BindingContext(Me.MasterDataSet, "SPDDD_DOSE_USUELLE_JOUR").Current("SPDDD_ATCDDD_CDF_UD_CODE_FK_PK") = dt.Rows(0)("ATCDDD_CDF_UD_CODE_FK_PK")
        '            Me.BindingContext(Me.MasterDataSet, "SPDDD_DOSE_USUELLE_JOUR").EndCurrentEdit()
        '            Me.SpddD_TA.Update(Me.DsTheriaque_Nomenclature1.SPDDD_DOSE_USUELLE_JOUR)
        '            Me.SpddD_TA.FillByCode(Me.DsTheriaque_Nomenclature1.SPDDD_DOSE_USUELLE_JOUR, CodE)
        '            Me.PanDDD.Enabled = True
        '        Else
        '            Dim dt As DataTable = cn.MySelect("Select * from THERIAQUE.ATCDDD_DOSE_USUELLE_JOUR where ATCDDD_CATC_CODE_FK_PK = " & cn.SQLText(f._Code) & " and ATCDDD_CDF_VO_CODE_FK_PK = " & cn.SQLText(f._Collection(1)))
        '            Me.BindingContext(Me.MasterDataSet, "SPDDD_DOSE_USUELLE_JOUR").Current("SPDDD_ATCDDD_CATC_CODE_FK_PK") = f._Code
        '            lkupDDD.EditValue = dt.Rows(0)("ATCDDD_CDF_VO_CODE_FK_PK")
        '            txtDDD_Dosage.EditValue = f._Collection(2)
        '            lkupDDD1.EditValue = dt.Rows(0)("ATCDDD_CDF_UD_CODE_FK_PK")
        '            Me.BindingContext(Me.MasterDataSet, "SPDDD_DOSE_USUELLE_JOUR").EndCurrentEdit()
        '        End If
        '    End If
        '    Load_Off(Me)
        'End If
    End Sub

    ''' <summary>
    ''' Mettre à jour la table INTER_INTEROPERABLE
    ''' </summary>
    ''' <remarks>
    ''' La table INTER_INTEROPERABLE n'existe pas dans l'interface
    ''' </remarks>
    Private Sub Update_INTER_INTEROPERABLE()
        Dim sSql As String = ""
        sSql = "UPDATE THERIAQUE.INTER_INTEROPERABLE SET INTER_SP_NOM =" & cn.SQLText(txtLibelle.Text) & ", INTER_SP_NOMLONG = " & cn.SQLText(txtNom.Text) & ",INTER_SP_NL = " & cn.SQLText(txtCIS.Text) & ", INTER_SP_CIPUCD =" & cn.SQLText(txtUCD.Text) & ", INTER_SP_CIPUCD13 =" & cn.SQLText(txtUCD13.Text) & " WHERE INTER_SP_CODE = " & txtCode.Text
        cn.ExecuteUCDCIP13(sSql)
    End Sub
    Private Sub DeleteSpFrom_INTER_INTEROPERABLE()
        Dim sSql As String = ""
        sSql = "DELETE FROM THERIAQUE.INTER_INTEROPERABLE WHERE INTER_SP_CODE = " & txtCode.Text
        cn.ExecuteUCDCIP13(sSql)
    End Sub
    ''' <summary>
    ''' Mettre à jour la table SPURL_SPECIALITE_ADRESSE
    ''' </summary>    
    'Private Sub Update_URL()
    '    Dim sSQL As String = ""
    '    'If Not Tab_TA7 Then LoadTab_7()
    '    If ModeFiche = eMode.Ajout Or ModeFiche = eMode.Duplication Then
    '        Dim dt As DataTable = cn.MySelect("SELECT * FROM THERIAQUE.URL_ADRESSE")
    '        For iCount As Integer = 0 To dt.Rows.Count - 1
    '            sSQL = "INSERT INTO THERIAQUE.SPURL_SPECIALITE_ADRESSE(SPURL_CODE_SP_PK_FK, SPURL_CODE_URL_PK_FK, SPURL_ADRESSE, SPURL_AUTO) Values (" & txtCode.Text & "," & dt.Rows(iCount)("URL_CODE_PK") & ",'',1)"
    '            cn.Execute(sSQL)
    '        Next
    '    End If
    '    If ModeFiche = eMode.Modification Then
    '        If Not Tab_TA7 Then LoadTab_7()
    '        For iCount As Integer = 0 To GV31.RowCount - 1
    '            If GV31.GetRowCellValue(iCount, ColSPURL_AUTO) = "False" Then
    '                sSQL = "UPDATE THERIAQUE.SPURL_SPECIALITE_ADRESSE SET SPURL_ADRESSE =" & cn.SQLText(GV31.GetRowCellValue(iCount, ColURL_FIXE)) & ", SPURL_AUTO = 0" & " WHERE SPURL_CODE_SP_PK_FK = " & txtCode.Text & " AND SPURL_CODE_URL_PK_FK=" & GV31.GetRowCellValue(iCount, ColCodeUrl)
    '            Else
    '                sSQL = "UPDATE THERIAQUE.SPURL_SPECIALITE_ADRESSE SET SPURL_ADRESSE = '', SPURL_AUTO = 1" & " WHERE SPURL_CODE_SP_PK_FK = " & txtCode.Text & " AND SPURL_CODE_URL_PK_FK=" & GV31.GetRowCellValue(iCount, ColCodeUrl)
    '            End If
    '            cn.Execute(sSQL)
    '        Next
    '    End If
    'End Sub

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
        'Test sur le libellé s'il existe
        If Ctrl.Name.ToLower = "txtLibelle".ToLower Or AllCtrl Then
            If ModeFiche = eMode.Ajout Or ModeFiche = eMode.Modification Or ModeFiche = eMode.Duplication Then
                strSSQL = "  Select * from THERIAQUE.SP_SPECIALITE where SP_CODE_SQ_PK <> " & cn.SQLText(txtCode.Text)
                strSSQL &= " and UPPER(SP_NOM) = " & cn.SQLText(UCase(txtLibelle.Text))
                Dim dt As DataTable = cn.MySelect(strSSQL)
                If dt.Rows.Count > 0 Then
                    Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist)
                    Return False
                Else
                    Me.DxErrorProvider.SetError(txtLibelle, "")
                End If
            End If
        End If


        If Ctrl.Name.ToLower = "txtLibelle".ToLower Or AllCtrl Then
            'End If
            If txtLibelle.Text = "" Then
                Me.DxErrorProvider.SetError(txtLibelle, "Le libellé ne doit pas etre vide")
                Return False
            Else
                Me.DxErrorProvider.SetError(txtLibelle, "")
            End If
        End If

        If Ctrl.Name.ToLower = "lkupProduit".ToLower Or AllCtrl Then
            If Not TestProduit_Libelle() Then
                Return False
            End If
            'If ModeFiche = eMode.Ajout Then
            'If TestProduit_LibelleExist(lkupProduit.Text) Then
            '    Return False
            '    Exit Function
            'End If
            'End If
            If lkupProduit.Text = "" Then
                Me.DxErrorProvider.SetError(lkupProduit, "produit ne doit pas etre vide")
                Return False
            Else
                Me.DxErrorProvider.SetError(lkupProduit, "")
            End If
        End If

        If Ctrl.Name.ToLower = "txtCIS".ToLower Or AllCtrl Then
            If Not Code_CIS(txtCIS.Text, txtCIS, Me.DxErrorProvider) Then
                Return False
            End If
        End If

        If Ctrl.Name.ToLower = "txtUCD".ToLower Or AllCtrl Then
            If Not Code_UCD(txtUCD.Text, txtUCD, Me.DxErrorProvider, txtCode.Text) Then
                Return False
            End If
        End If
        If Ctrl.Name.ToLower = "txtUCD13".ToLower Or AllCtrl Then
            If Not Code_UCD13(txtUCD13.Text, txtUCD.Text, txtUCD13, Me.DxErrorProvider) Then
                Return False
            End If
        End If
        If Ctrl.Name.ToLower = "txtedit_aphp".ToLower Or AllCtrl Then
            If TxtEdit_APHP.Text.Length > 7 Then
                Me.DxErrorProvider.SetError(TxtEdit_APHP, "Le code APHP ne doit pas être consitittué de plus de 7 caractères")
                Return False
            Else
                Me.DxErrorProvider.SetError(TxtEdit_APHP, "")
            End If
        End If

        If Ctrl.Name.ToLower = "lkupListe".ToLower Or AllCtrl Then
            If lkupListe.Text = "" Then
                Me.DxErrorProvider.SetError(lkupListe, "laboratoire ne doit pas etre vide")
                Return False
            Else
                Me.DxErrorProvider.SetError(lkupListe, "")
            End If
        End If

        If Ctrl.Name.ToLower = "lkupStLab".ToLower Or AllCtrl Then
            If lkupStLab.Text = "" Then
                Me.DxErrorProvider.SetError(lkupStLab, "laboratoire ne doit pas etre vide")
                Return False
            Else
                Me.DxErrorProvider.SetError(lkupStLab, "")
            End If
        End If

        If Not Tab_TA2 And CodE <> InvalidCode Then LoadTab_2()
        If Not Tab_TA3 And CodE <> InvalidCode Then LoadTab_3()

        If GV11.DataRowCount > 1 And AllCtrl Then
            Dim Assocvalid As Boolean = False
            For iCount As Integer = 0 To GV13.RowCount - 1
                If Me.GV13.GetRowCellValue(iCount, colSPCPH_CPH_CODE_FK_PK2) = "A9" Then
                    Assocvalid = True
                End If
            Next
            If Not Assocvalid Then
                Process_Message(strAssociation, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            End If
        End If
        Return True
    End Function

#End Region

#Region " Grid View  "

    Private Sub GV15_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GV15.CustomDrawCell
        Dim dv As New DataView
        dv = rpCLRMO_CLASSE_RMO.DataSource.defaultview
        If e.Column Is colSPRMO_CLRMO_CODE_FK_PK2 Then
            'For inti As Integer = 0 To GV15.RowCount - 1
            If GV15.GetRowCellValue(e.RowHandle, colSPRMO_RMO_CODE_FK_PK2) IsNot DBNull.Value And GV15.GetRowCellValue(e.RowHandle, colSPRMO_CLRMO_CODE_FK_PK2) IsNot DBNull.Value Then
                If GV15.GetRowCellValue(e.RowHandle, colSPRMO_RMO_CODE_FK_PK2) <> Nothing And GV15.GetRowCellDisplayText(e.RowHandle, colSPRMO_CLRMO_CODE_FK_PK2) <> "" Then
                    dv.RowFilter = "CLRMO_RMO_CODE_FK_PK = " & GV15.GetRowCellValue(e.RowHandle, colSPRMO_RMO_CODE_FK_PK2) & " And code  = " & GV15.GetRowCellValue(e.RowHandle, colSPRMO_CLRMO_CODE_FK_PK2)
                    If dv.Count > 0 Then e.DisplayText = dv.Item(0)("libelle")
                End If
            End If
            'Next
        End If
        dv.RowFilter = ""
    End Sub

    Private Sub GV15_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV15.FocusedRowChanged
        Update_rpCLRMO_CLASSE_RMO()
    End Sub

#End Region

#Region " GV New Row "

    Private Sub GV4_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV4.InitNewRow
        If OnLoading Then Exit Sub
        GV4.SetFocusedRowCellValue(colSPFO_SP_CODE_FK_PK, txtCode.Text) '2do signification de la colonne !!!!
        GV4.SetFocusedRowCellValue(colSPFO_NUMORD, Code_MAx(GV4, colSPFO_NUMORD)) '2do signification de la colonne !!!!
        GV4.SetFocusedRowCellValue(colSPFO_NUMSEQ_PK, Code_MAx(GV4, colSPFO_NUMSEQ_PK)) '2do signification de la colonne !!!!
    End Sub
    Private Sub GV5_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV5.InitNewRow
        GV5.SetFocusedRowCellValue(colSPFOCFO_NUMORD, Code_MAx(GV5, colSPFOCFO_NUMORD))
    End Sub
    Private Sub GV14_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV14.InitNewRow
        If OnLoading Then Exit Sub
        GV14.SetFocusedRowCellValue(colSPCH_SP_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV9_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV9.InitNewRow
        If OnLoading Then Exit Sub
        GV9.SetFocusedRowCellValue(colCOMPO_SP_CODE_FK_PK, txtCode.Text)
        GV9.SetFocusedRowCellValue(colCOMPO_NUM_PK, Code_MAx(sender, colCOMPO_NUM_PK))
    End Sub
    Private Sub GV12_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV12.InitNewRow
        If OnLoading Then Exit Sub
        GV12.SetFocusedRowCellValue(colCOTEN_SP_CODE_FK_PK, txtCode.Text)
        GV12.SetFocusedRowCellValue(colCOTEN_NUMORD, Code_MAx(GV12, colCOTEN_NUMORD))
    End Sub
    Private Sub GV13_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV13.InitNewRow
        If OnLoading Then Exit Sub
        GV13.SetFocusedRowCellValue(colSPCPH_SP_CODE_FK_PK, txtCode.Text)
        GV13.SetFocusedRowCellValue(colSPCPH_NUMORD, Code_MAx(sender, colSPCPH_NUMORD))
    End Sub

    Private Sub GV15_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV15.InitNewRow
        If OnLoading Then Exit Sub
        GV14.SetFocusedRowCellValue(colSPRMO_SP_CODE_FK_PK, txtCode.Text)
        Me.BindingContext(Me.MasterDataSet, SPRMO_SPECIALITE_RMO).Current("SPRMO_SP_CODE_FK_PK") = txtCode.Text
    End Sub

    Private Sub GV16_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV16.InitNewRow
        If OnLoading Then Exit Sub
        GV16.SetFocusedRowCellValue(colSPFTH_SP_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV17_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV17.InitNewRow
        If OnLoading Then Exit Sub
        GV17.SetFocusedRowCellValue(colSPFTR_SP_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV18_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV18.InitNewRow
        If OnLoading Then Exit Sub
        GV18.SetFocusedRowCellValue(colSPATR_SP_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV19_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV19.FocusedRowChanged
        If GV19.IsNewItemRow(GV19.FocusedRowHandle) Then
            colSPSMR_DATE.OptionsColumn.ReadOnly = False
        Else
            colSPSMR_DATE.OptionsColumn.ReadOnly = True
        End If
    End Sub

    Private Sub GV19_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV19.InitNewRow
        If OnLoading Then Exit Sub
        GV19.SetFocusedRowCellValue(colSPSMR_SP_CODE_FK_PK, txtCode.Text)
        GV19.SetFocusedRowCellValue(colSPSMR_NUM_ORD_PK, Code_MAx(GV19, colSPSMR_NUM_ORD_PK))
    End Sub

    Private Sub GV20_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV20.InitNewRow
        If OnLoading Then Exit Sub
        GV20.SetFocusedRowCellValue(colSPCPD_SP_CODE_FK_PK, txtCode.Text)
        GV20.SetFocusedRowCellValue(colSPCPD_NUMORD, Code_MAx(GV20, colSPCPD_NUMORD))
    End Sub

    Private Sub GV21_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV21.InitNewRow
        If Me.BindingContext(Me.DsTheriaque_Nomenclature1, MasterTable).Current("SP_CIPUCD") Is DBNull.Value Then
            Exit Sub
        End If
        If OnLoading Then Exit Sub
        GV21.SetFocusedRowCellValue(colPRIUCD_UCD_CODE_PK, Me.BindingContext(Me.DsTheriaque_Nomenclature1, MasterTable).Current("SP_CIPUCD"))

        GV21.SetFocusedRowCellValue(colPRIUCD_Valide, "True")
        'For iCount As Integer = 0 To GV21.RowCount - 1
        '    If iCount <> GV21.FocusedRowHandle Then
        '        GV21.SetRowCellValue(iCount, colPRIUCD_Valide, "False")
        '    End If
        'Next

    End Sub

    Private Sub GV1_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV1.InitNewRow
        If OnLoading Then Exit Sub
        GV1.SetFocusedRowCellValue(colSYSP_SP_CODE_FK, txtCode.Text)
    End Sub

    Private Sub GV2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        If OnLoading Then Exit Sub
        GV2.SetRowCellValue(e.RowHandle, colSPLAB_SP_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV3_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV3.InitNewRow
        If OnLoading Then Exit Sub
        GV3.SetFocusedRowCellValue(colSPLABEX_SP_CODE_FK_PK, txtCode.Text)
        GV3.SetFocusedRowCellValue(colSPLABEX_NUMORD, Code_MAx(GV3, colSPLABEX_NUMORD))
    End Sub

    Private Sub GV8_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV8.InitNewRow
        If OnLoading Then Exit Sub
        Try
            'Me.BindingContext(Me.DsTheriaque_Nomenclature1, MasterTable).EndCurrentEdit()
            GV8.SetFocusedRowCellValue(colSPVO_SP_CODE_FK_PK, txtCode.Text)
            GV8.SetFocusedRowCellValue(colSPVO_NUMSEQ, Code_MAx(GV8, colSPVO_NUMSEQ))
        Catch ex As Exception
            Process_Message_Error(ex, Me.Text, "")
        End Try
    End Sub

    Private Sub GV6_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV6.InitNewRow
        If OnLoading Then Exit Sub
        GV6.SetFocusedRowCellValue(colSPFOCPI_SP_CODE_FK_PK, txtCode.Text)
        GV6.SetFocusedRowCellValue(colSPFOCPI_NUMORD, Code_MAx(GV6, colSPFOCPI_NUMORD))
    End Sub

    Private Sub GV22_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV22.InitNewRow
        GV22.SetFocusedRowCellValue(colSPAFS_SP_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV31_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV31.InitNewRow
        If OnLoading Then Exit Sub
        GV31.SetFocusedRowCellValue(colSPURL_CODE_SP_PK_FK, txtCode.Text)
    End Sub

    Private Sub GVDDD_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GVDDD.InitNewRow
        If OnLoading Then Exit Sub
        GVDDD.SetFocusedRowCellValue(colSPDDD_SP_CODE_FK_PK, txtCode.Text)
        GVDDD.SetFocusedRowCellValue(colSPDDD_NUMORD, Code_MAx(GVDDD, colSPDDD_NUMORD))
    End Sub

#End Region

    Private Sub lkupProduit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles lkupProduit.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Plus Then
            Dim res As MsgResults
            Dim max As Integer = Code_MAx("PR_PRODUIT", "PR_CODE_SQ_PK")
            res = Process_Message("Saisir un produit", MessageBoxButtons.OK, MessageBoxIcon.Information, , True)
            If res.BtResult = MsgBoxResult.Ok Then
                If Not TestProduit_LibelleExist(res.strResult, False) Then
                    If TestProduit_Libelle(res.strResult) Then
                        If res.strResult <> Nothing Then
                            Dim strSSQL As String = " Insert Into THERIAQUE.PR_PRODUIT(PR_CODE_SQ_PK, PR_NOM, PR_DATECR) "
                            strSSQL &= " Values (" & (max + 1) & ","
                            strSSQL &= cn.SQLText(res.strResult) & ","
                            strSSQL &= cn.SQLText(Now.Date) & ")"
                            cn.Execute(strSSQL)
                            InitLkup(Me.lkupProduit, PR_PRODUIT, strSSQL_PR_PRODUIT, True)
                            lkupProduit.EditValue = max + 1
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Function TestProduit_Libelle(Optional ByVal val As String = "") As Boolean
        TestProduit_Libelle = True
        If OnLoading Then Exit Function
        Dim ProduitLibelle As String
        If val = "" Then
            If lkupProduit.Text = "" Then Exit Function
            ProduitLibelle = lkupProduit.Text
        Else
            ProduitLibelle = val
        End If

        Dim Libelle As String = txtLibelle.Text
        ProduitLibelle = Replace(ProduitLibelle, "#", "")
        ProduitLibelle = ProduitLibelle.Trim
        Libelle = Replace(Libelle, "#", "")

        If ProduitLibelle <> "" Then
            ProduitLibelle = ProduitLibelle.Split(" ")(0)
            If Libelle <> "" Then
                Libelle = Libelle.Split(" ")(0)
                If Libelle <> ProduitLibelle Then
                    Me.DxErrorProvider.SetError(lkupProduit, "Le 1er terme du produit doit être le même que celui du libellé court")
                    lkupProduit.EditValue = DBNull.Value
                    Return False
                    Exit Function
                Else
                End If
            End If
            Libelle = txtNom.Text
            Libelle = Replace(Libelle, "#", "")
            If Libelle <> "" Then
                If Mid(Libelle.TrimStart, 1, ProduitLibelle.Length) <> ProduitLibelle Then
                    Me.DxErrorProvider.SetError(lkupProduit, "Les 1er termes du produits doit être les mêmes que celui du libellé long")
                Else
                    Me.DxErrorProvider.SetError(lkupProduit, "")
                    lkupProduitCode.EditValue = lkupProduit.EditValue
                    lkupProduitCode.Properties.DataSource = lkupProduit.Properties.DataSource
                End If
            End If
        End If
    End Function

    Private Function TestProduit_LibelleExist(Optional ByVal val As String = "", Optional ByVal bValider As Boolean = True) As Boolean
        TestProduit_LibelleExist = False
        If OnLoading Then Exit Function
        If val = "" Then Exit Function
        'Dim ProduitLibelle As String = lkupProduit.Text
        If val <> "" Then
            Dim strSSQL As String
            strSSQL = " SELECT PR_NOM FROM THERIAQUE.SP_SPECIALITE, THERIAQUE.PR_PRODUIT WHERE SP_CODE_SQ_PK = " & txtCode.Text & " AND SP_PR_CODE_FK = PR_CODE_SQ_PK"
            Dim dtPR As DataTable = cn.MySelect(strSSQL)
            strSSQL = "  SELECT * FROM THERIAQUE.PR_PRODUIT "
            strSSQL &= " WHERE UPPER(PR_NOM) = " & UCase(cn.SQLText(val))
            If dtPR.Rows.Count > 0 Then
                If bValider Then strSSQL &= " AND UPPER(PR_NOM)<>" & cn.SQLText(UCase(dtPR.Rows(0)(0)))
            End If
            If ModeFiche = eMode.Ajout Or ModeFiche = eMode.Duplication Then
                If bValider Then strSSQL &= " AND UPPER(PR_NOM)<>" & cn.SQLText(UCase(lkupProduit.Text))
            End If
            Dim dt As DataTable = cn.MySelect(strSSQL)
            'If Not ModeFiche = eMode.Ajout Then
            If dt.Rows.Count > 0 Then
                XtraTabControl1.SelectedTabPageIndex = 0
                Me.DxErrorProvider.SetError(lkupProduit, StrValeurExist)
                Return True
            Else
                Me.DxErrorProvider.SetError(lkupProduit, "")
            End If
            'End If
            strSSQL = " SELECT * FROM THERIAQUE.SYPR_SYNONYME_PRODUIT "
            strSSQL &= " WHERE UPPER(SYPR_NOM_PK) = " & UCase(cn.SQLText(val))
            dt = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                If bValider Then strSSQL &= " AND UPPER(SYPR_NOM_PK)<>" & cn.SQLText(UCase(dtPR.Rows(0)(0)))
            End If
            Dim dtSyno As DataTable = cn.MySelect(strSSQL)
            'If Not ModeFiche = eMode.Ajout Then
            If dtSyno.Rows.Count > 0 Then
                XtraTabControl1.SelectedTabPageIndex = 0
                Me.DxErrorProvider.SetError(lkupProduit, StrValeurExist)
                Return True
            Else
                Me.DxErrorProvider.SetError(lkupProduit, "")
            End If
            'End If
        End If
    End Function

    Private Sub lkupProduit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupProduit.EditValueChanged
        TestProduit_Libelle()
        'TestProduit_LibelleExist()
    End Sub

    Private Sub txtCIS_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCIS.Validated
        ValideControl(sender, False)
    End Sub

    Private Sub txtUCD_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUCD.Validated
        ValideControl(sender, False)
        If Me.BindingContext(Me.DsTheriaque_Nomenclature1, MasterTable).Current("SP_CIPUCD") IsNot DBNull.Value Then
            If ValideControl(txtUCD, False) And txtUCD.Text <> "" Then
                If Code_UCD(txtUCD.Text, txtUCD, Me.DxErrorProvider, txtCode.Text) Then
                    GC21.DataSource = MasterDataSet
                    GC21.DataMember = "PRIUCD_PRIX_UCD"
                    Me.PriucD_TA.FillByCode(Me.DsTheriaque_Nomenclature1.PRIUCD_PRIX_UCD, Me.BindingContext(Me.DsTheriaque_Nomenclature1, MasterTable).Current("SP_CIPUCD"))
                    GC21.Enabled = True
                End If
            End If
        Else
            GC21.Enabled = False
            GC21.DataSource = Nothing
        End If
    End Sub

    Private Sub GV9_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV9.ValidateRow
        If GV9.RowCount > 1 Then
            If GV9.GetRowCellValue(GV9.FocusedRowHandle, colCOMPO_CDF_GAL_CODE_FK) Is DBNull.Value Then
                e.ErrorText = "Le libellé est obligatoire puisque il existe plusieurs composition"
                e.Valid = False
            Else
                If GV9.GetRowCellValue(GV9.FocusedRowHandle, colCOMPO_CDF_GAL_CODE_FK) = "" Then
                    e.ErrorText = "Le libellé est obligatoire puisque il existe plusieurs composition"
                    e.Valid = False
                End If
            End If
        End If
    End Sub

    Private Sub GV11_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV11.InitNewRow
        GV11.SetFocusedRowCellValue(colCOSAC_NUMORD, Code_MAx(GV11, colCOSAC_NUMORD))
    End Sub

    Private Sub GV11_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV11.ValidatingEditor
        If GV11.FocusedColumn Is colCOSAC_DOSAGE Then
            If e.Value Is DBNull.Value Then Exit Sub
            e.Value = Replace(e.Value, ".", ",")
        End If
        If GV11.FocusedColumn Is colCOSAC_UNITEDOSAGE Then
            If e.Value Is DBNull.Value Then Exit Sub
            If GV11.GetRowCellValue(GV11.FocusedRowHandle, colCOSAC_DOSAGE) Is DBNull.Value Then
                e.ErrorText = "Il faut tout d'abord saisir un dosage"
                e.Value = Nothing
                e.Valid = False
            Else
                If GV11.GetRowCellValue(GV11.FocusedRowHandle, colCOSAC_DOSAGE) = "" Then
                    e.ErrorText = "Il faut tout d'abord saisir un dosage"
                    e.Value = Nothing
                    e.Valid = False
                End If
            End If
        End If
    End Sub

    Private Sub GV12_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV12.ValidatingEditor
        If GV12.FocusedColumn Is colCOTEN_CDF_UD_CODE_FK Then
            If e.Value Is DBNull.Value Then Exit Sub
            If GV12.GetRowCellValue(GV12.FocusedRowHandle, colCOTEN_DOSAGE) Is DBNull.Value Then
                e.ErrorText = "Il faut tout d'abord saisir un dosage"
                e.Value = Nothing
                e.Valid = False
            Else
                If GV12.GetRowCellValue(GV12.FocusedRowHandle, colCOTEN_DOSAGE) Is Nothing Then
                    e.ErrorText = "Il faut tout d'abord saisir un dosage"
                    e.Value = Nothing
                    e.Valid = False
                End If
            End If
        End If

        If GV12.FocusedColumn Is colCOTEN_CDF_UD_EQUIV_CODE_FK Then
            If e.Value Is DBNull.Value Then Exit Sub
            If GV12.GetRowCellValue(GV12.FocusedRowHandle, colCOTEN_DOSAGE_EQUIV) Is DBNull.Value Then
                e.ErrorText = "Il faut tout d'abord saisir un dosage"
                e.Value = Nothing
                e.Valid = False
            Else
                If GV12.GetRowCellValue(GV12.FocusedRowHandle, colCOTEN_DOSAGE_EQUIV) Is Nothing Then
                    e.ErrorText = "Il faut tout d'abord saisir un dosage"
                    e.Value = Nothing
                    e.Valid = False
                End If
            End If
        End If
    End Sub

    Private Sub txtUCD_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUCD.EditValueChanged
        If Me.BindingContext(Me.DsTheriaque_Nomenclature1, MasterTable).Current("SP_CIPUCD") IsNot DBNull.Value Then
            If ValideControl(txtUCD, False) And txtUCD.Text <> "" Then
                If Code_UCD(txtUCD.Text, txtUCD, Me.DxErrorProvider, txtCode.Text) Then
                    GC21.DataSource = MasterDataSet
                    GC21.DataMember = "PRIUCD_PRIX_UCD"

                    Me.PriucD_TA.FillByCode(Me.DsTheriaque_Nomenclature1.PRIUCD_PRIX_UCD, Me.BindingContext(Me.DsTheriaque_Nomenclature1, MasterTable).Current("SP_CIPUCD"))
                    GC21.Enabled = True

                End If
            End If
        Else
            GC21.Enabled = False
            GC21.DataSource = Nothing
        End If
    End Sub

    Private Sub lkupATC2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupATC2.EditValueChanged
        If Not OnLoading Then
            lkupATC.EditValue = lkupATC2.EditValue
            'If Me.BindingContext(Me.MasterDataSet, "SPDDD_DOSE_USUELLE_JOUR").Count > 0 Then
            '    Me.BindingContext(Me.MasterDataSet, "SPDDD_DOSE_USUELLE_JOUR").RemoveAt(0)
            'End If

            For iCount As Integer = 0 To BindingContext(Me.MasterDataSet, "SPDDD_DOSE_USUELLE_JOUR").Count - 1
                Me.BindingContext(Me.MasterDataSet, "SPDDD_DOSE_USUELLE_JOUR").RemoveAt(0)
            Next
        End If
    End Sub

    Private Sub Frm_Specialite2_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        ' GC5.Width = Panel15.Width / 2
    End Sub

    Private Sub txtLibelle_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLibelle.Validated
        TestProduit_Libelle()
        'ValideControl(sender, False)
    End Sub

    Private Sub GV10_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV10.InitNewRow
        GV10.SetFocusedRowCellValue(colCOSAU_NUMORD, Code_MAx(GV10, colCOSAU_NUMORD))
    End Sub

    Private Sub GV24_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV24.InitNewRow
        GV24.SetFocusedRowCellValue(colSPTEN_SP_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV25_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV25.InitNewRow
        GV25.SetFocusedRowCellValue(colSPADM_SP_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV15_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV15.ValidatingEditor
        If GV15.FocusedColumn Is colSPRMO_RMO_CODE_FK_PK2 Or GV15.FocusedColumn Is colSPRMO_RMO_CODE_FK_PK Then
            Update_rpCLRMO_CLASSE_RMO(e.Value)
        End If
        If GV15.FocusedColumn Is colSPRMO_CLRMO_CODE_FK_PK3 Then
            If GV15.GetFocusedRowCellValue(colSPRMO_CLRMO_CODE_FK_PK3) IsNot DBNull.Value Then
                GV15.SetRowCellValue(GV15.FocusedRowHandle, colSPRMO_CLRMO_CODE_FK_PK, GV15.GetFocusedRowCellValue(colSPRMO_CLRMO_CODE_FK_PK3))
                GV15.SetRowCellValue(GV15.FocusedRowHandle, colSPRMO_CLRMO_CODE_FK_PK2, GV15.GetFocusedRowCellValue(colSPRMO_CLRMO_CODE_FK_PK3))
            End If
        End If
    End Sub

    Private Sub rpCLRMO_CLASSE_RMO3_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles rpCLRMO_CLASSE_RMO3.CloseUp
        GV15_ValidatingEditor(GV15, Nothing)
    End Sub

    Private Sub GV7_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV7.InitNewRow
        GV7.SetFocusedRowCellValue(colSPFOTX_SP_CODE_FK_PK, txtCode.Text)
    End Sub
    Private Sub GV_RowCountChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV7.RowCountChanged, GV25.RowCountChanged, GV24.RowCountChanged
        If sender.RowCount >= 1 Then
            sender.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
            sender.GridControl.EmbeddedNavigator.Buttons.Append.Enabled = False
        Else
            sender.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            sender.GridControl.EmbeddedNavigator.Buttons.Append.Enabled = False
        End If
    End Sub

    Private Sub GV19_CustomDrawCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GV19.CustomDrawCell
        If e.Column Is colSPSMR_NUM_ORD_PK Then
            If GV19.GetRowCellValue(e.RowHandle, colSPSMR_NUM_ORD_PK) IsNot DBNull.Value And GV19.GetRowCellValue(e.RowHandle, colSPSMR_NUM_ORD_PK) <> Nothing Then
                'GV19.SetRowCellValue(e.RowHandle, colSPSMR_NUM_ORD_PK, e.RowHandle + 1)
                e.DisplayText = e.RowHandle + 1
            End If
        End If
    End Sub
    Private Sub GV_CalcRowHeight(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs) Handles GV7.CalcRowHeight, GV25.CalcRowHeight, GV24.CalcRowHeight
        e.RowHeight = sender.GridControl.Height
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim f As New Frm_URL
        f.MdiParent = FMain
        f.Show()
    End Sub

    Private Sub txtUCD13_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUCD13.Validated
        ValideControl(sender, False)
        'If Me.BindingContext(Me.DsTheriaque_Nomenclature1, MasterTable).Current("SP_CIPUCD") IsNot DBNull.Value Then
        '    If ValideControl(txtUCD, False) And txtUCD.Text <> "" Then
        '        GC21.DataSource = MasterDataSet
        '        GC21.DataMember = "PRIUCD_PRIX_UCD"
        '        Me.PriucD_TA.FillByCode(Me.DsTheriaque_Nomenclature1.PRIUCD_PRIX_UCD, Me.BindingContext(Me.DsTheriaque_Nomenclature1, MasterTable).Current("SP_CIPUCD"))
        '        GC21.Enabled = True
        '    End If
        'Else
        '    GC21.Enabled = False
        '    GC21.DataSource = Nothing
        'End If
    End Sub

    Private Sub GV21_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV21.ValidateRow
        If Me.GV21.GetRowCellValue(e.RowHandle, Me.colPRIUCD_CODE_LISTE_PK) IsNot DBNull.Value Then
            If Me.GV21.GetFocusedRowCellValue(colPRIUCD_Valide) IsNot DBNull.Value Then
                If Me.GV21.GetFocusedRowCellValue(colPRIUCD_Valide) = "True" Then
                    For iCount As Integer = 0 To GV21.RowCount - 1
                        If iCount <> GV21.FocusedRowHandle Then
                            If Me.GV21.GetRowCellValue(iCount, colPRIUCD_CODE_LISTE_PK) = Me.GV21.GetRowCellValue(e.RowHandle, Me.colPRIUCD_CODE_LISTE_PK) Then
                                GV21.SetRowCellValue(iCount, colPRIUCD_Valide, "False")
                            End If
                        End If
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub btADDRemb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btADDRemb.Click
        If CodE <> InvalidCode Then
            Dim sSql As String = " SELECT URL_CODE_PK as code, URL_TYPE as libelle, URL_FIXE  as val1, URL_SP_CHAMPS as val2 FROM THERIAQUE.URL_ADRESSE"
            Dim f As New Frm_Dictionnaire
            f._SSQL = sSql
            f.colVal1.Caption = "URL"

            f.ShowDialog()
            If f._Code IsNot Nothing Then
                InitLkup(Me.Rp_TypeURL, URL_ADRESSE, strSSQL_URL, True)
                sSql = "SELECT " & f._Collection(2)
                sSql &= " FROM THERIAQUE.SP_SPECIALITE WHERE SP_CODE_SQ_PK = " & cn.SQLText(CodE)
                If Not cn.ExecuteScalar(sSql) Is DBNull.Value Then
                    Dim sUrlFixe As String = f._Collection(1) & Replace(cn.ExecuteScalar(sSql), " ", "")

                    GV31.AddNewRow()
                    GV31.SetFocusedRowCellValue(colSPURL_CODE_URL_PK_FK, f._Code)
                    GV31.SetFocusedRowCellValue(colSPURL_ADRESSE, sUrlFixe)
                End If
            End If

        End If
    End Sub

    Private Sub TxtEdit_APHP_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEdit_APHP.Validated
        ValideControl(sender, False)
    End Sub

    Private Sub beChemin_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beChemin.ButtonClick

        Select Case e.Button.Tag
            Case "explorer"
                Dim FolderBrowserDialog1 As New FolderBrowserDialog
                If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    ' Display the selected folder if the user clicked on the OK button.
                    beChemin.Text = FolderBrowserDialog1.SelectedPath
                End If
            Case "effacer"
                beChemin.Text = ""
        End Select

    End Sub

    Private Sub Frm_Specialite_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     
        'Me.DOC_Document_SPECTableAdapter.Fill(Me.DsTheriaqueDocument.DOC_Document_SPEC)
        doc = New DocumentService.DocumentProvider(strConnexion)

        Dim dt As New DataTable
        dt = doc.GetAllCategories()
        Me.lueCategorie.Properties.DataSource = dt

    End Sub

    Private Sub BtSupprim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSupprim.Click

        If (gvDocument.RowCount > 0) Then
            If MessageBox.Show("Vous voulez vraiement supprimer ce document ?", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                If (gvDocument.RowCount > 0) Then

                    Dim id As String = gvDocument.GetFocusedRowCellValue(colId).ToString()
                    doc.cn.ConnectionString = cn.sConnexion
                    doc.DeleteFromAssociation(id, CodE, DocumentService.DocumentProvider.TypeDoc.Specialite)
                    Me.gcDocument.DataSource = doc.GetDocsByTypeDoc(CodE.ToString, DocumentService.DocumentProvider.TypeDoc.Specialite)

                End If
            End If
        Else
            MessageBox.Show("Veuillez sélectionner un document")
        End If

    End Sub

    Private Sub SaveDocument(ByVal path As String)
        doc = New DocumentService.DocumentProvider(cn.sConnexion)
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
                doc.DO_Note = Me.meNote.Text
                If Me.lueCategorie.EditValue IsNot DBNull.Value Then ' And Me.lueCategorie.EditValue <> "" Then
                    If (Not String.IsNullOrEmpty(Me.lueCategorie.EditValue)) Then
                        If (Me.lueCategorie.EditValue <> 0) Then
                            doc.ID_Categorie = Me.lueCategorie.EditValue
                        End If
                    End If
                End If
                .DO_Info1 = path
                .Save(True)  ' False for update.
            End With
        End If

    End Sub

    Private Sub btImporter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImporter.Click

        If (Not String.IsNullOrEmpty(beChemin.Text)) Then

            Dim d As New DirectoryInfo(beChemin.Text)

            Dim filter As String = "*.pdf,*.gif,*.jpg,*.bmp,*.png"
            For Each f As FileInfo In d.GetFiles() '("*.pdf")

                If (filter.ToLower().Contains(f.Extension.ToLower())) Then
                    SaveDocument(f.FullName)
                    doc.AddDocumentToAssociation(doc.DO_ID, txtCode.Text, DocumentService.DocumentProvider.TypeDoc.Specialite)
                End If
            Next

            doc.cn.ConnectionString = cn.sConnexion
            gcDocument.DataSource = doc.GetDocsByTypeDoc(txtCode.Text.ToString, DocumentService.DocumentProvider.TypeDoc.Specialite)

        Else

            MsgBox("Veuillez sélectionner un chemin")

        End If

    End Sub

    Private Sub btPartager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPartager.Click

        If (gvDocument.FocusedRowHandle >= 0) Then
            RechercherSpecialites()
        Else
            MsgBox("Veuillez sélectionner un document")
        End If

    End Sub

    Public Sub RechercherSpecialites()

        Dim sCodeSP As String = ""
        Dim sCodePR As String = ""
        Dim sCodeCIS As String = ""
        Dim sCodeLABO As String = ""
        Dim sCodeSTLABO As String = ""
        Dim sCodeLABOEXP As String = ""
        Dim sCodeVA As String = ""
        Dim sCodeFPH As String = ""
        Dim sCodeCOMPFORM As String = ""
        Dim sCodeCOMP As String = ""
        Dim sCodeCPH As String = ""
        Dim sCodeATC As String = ""
        Dim sCodeEPH As String = ""
        Dim sCodeCGESTION As String = ""
        Dim sCodeCC As String = ""
        Dim sCodeLIST As String = ""
        Dim sCodePRES As String = ""
        Dim sCodeSUBAC As String = ""
        Dim sCodeSUBACUNITE As String = ""
        Dim sCodeSUBAU As String = ""
        Dim sCodeSUBAUUNITE As String = ""
        Dim sCodeTENEUR As String = ""
        Dim sCodeTENEURUNITE As String = ""
        Dim sCodeTENEUREQUIV As String = ""
        Dim strSQL As String = ""
        Dim sLibelleTENEURUNITE As String = ""
        Dim sLibelleSUBAUUNITE As String = ""
        Dim sLibelleSUBACUNITE As String = ""
        Dim dtResultat As DataTable

        Dim f As New Frm_SpecialiteMultiCriteres
        f.ShowDialog()
        If f._Validate Then
            If f._bSP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SP_SPECIALITE
                fDICO.Text = "Spécialités"
                fDICO.ShowDialog()
                sCodeSP = fDICO._Code
            End If
            If f._bPR Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_PR_PRODUIT
                fDICO.Text = "Produits"
                fDICO.ShowDialog()
                sCodePR = fDICO._Code
            End If
            If f._bCIS Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQLSP_NL__CIS
                fDICO.Text = "Code identifiant spécialité(CIS)"
                fDICO.ShowDialog()
                sCodeCIS = fDICO._Code
            End If
            If f._bLABO Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("07")
                fDICO.Text = "Laboratoire"
                fDICO.ShowDialog()
                sCodeLABO = fDICO._Code
            End If
            If f._bSTLABO Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("15")
                fDICO.Text = "Statut laboratoire"
                fDICO.ShowDialog()
                sCodeSTLABO = fDICO._Code
            End If
            If f._bLABOEXP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("07")
                fDICO.Text = "Laboratoire exploitant"
                fDICO.ShowDialog()
                sCodeLABOEXP = fDICO._Code
            End If
            If f._bVA Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("18")
                fDICO.Text = "Voie d’administration"
                fDICO.ShowDialog()
                sCodeVA = fDICO._Code
            End If
            If f._bFPH Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("06")
                fDICO.Text = "Forme pharmaceutique"
                fDICO.ShowDialog()
                sCodeFPH = fDICO._Code
            End If
            If f._bCOMPFORM Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("02")
                fDICO.Text = "Complément de forme"
                fDICO.ShowDialog()
                sCodeCOMPFORM = fDICO._Code
            End If
            If f._bCOMP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("22")
                fDICO.Text = "Composition"
                fDICO.ShowDialog()
                sCodeCOMP = fDICO._Code
            End If
            If f._bCPH Then
                Dim fDICO As New Frm_Recherche
                strSQL = strSSQL_CPH_CLASSEPHARMTHER
                strSQL &= " where CPH_CODE_PK  not in  "
                strSQL &= " (Select distinct isnull(CPH_CPH_CODE_FK,'') From THERIAQUE.CPH_CLASSEPHARMTHER )"
                fDICO._SSQL = strSQL
                fDICO.Text = "Classes pharmaco-thérapeutique"
                fDICO.ShowDialog()
                sCodeCPH = fDICO._Code
            End If
            If f._bATC Then
                strSQL = " select CATC_CODE_PK  into  #Yaks from THERIAQUE.CATC_CLASSEATC "
                strSQL &= " except  "
                strSQL &= " select CATC_CATC_CODE_FK From THERIAQUE.CATC_CLASSEATC "
                strSQL &= " select #Yaks.CATC_CODE_PK as code, c.CATC_NOMF as libelle from #Yaks, THERIAQUE.CATC_CLASSEATC c "
                strSQL &= " where c.CATC_CODE_PK = #Yaks.CATC_CODE_PK "
                strSQL &= " drop table #Yaks "
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSQL
                fDICO.Text = "ATC"
                fDICO.ShowDialog()
                sCodeATC = fDICO._Code
            End If
            If f._bEPH Then
                Dim fDICO As New Frm_Recherche
                strSQL = strSSQL_CEPH_CLASSEEPHMRA
                strSQL &= " where CEPH_CODE_PK  not in  "
                strSQL &= " (Select distinct isnull(CEPH_CEPH_CODE_FK,'') From THERIAQUE.CEPH_CLASSEEPHMRA )"
                fDICO._SSQL = strSQL
                fDICO.Text = "Ephmra"
                fDICO.ShowDialog()
                sCodeEPH = fDICO._Code
            End If
            If f._bCGESTION Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CGE_CLASSEGESTION
                fDICO.Text = "Classes gestion"
                fDICO.ShowDialog()
                sCodeCGESTION = fDICO._Code
            End If
            If f._bCC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CH_CHOIX
                fDICO.Text = "Critères de choix"
                fDICO.ShowDialog()
                sCodeCC = fDICO._Code
            End If
            If f._bLIST Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("08")
                fDICO.Text = "Listes"
                fDICO.ShowDialog()
                sCodeLIST = fDICO._Code
            End If
            If f._bPRES Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("14") & " and substring(CDF_CODE_PK,1,1) = 'S'"
                fDICO.Text = "Prescriptions / délivrances"
                fDICO.ShowDialog()
                sCodePRES = fDICO._Code
            End If
            If f._bSUBAC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SAC_SUBACTIVE
                fDICO.Text = "Substances actives"
                fDICO.ShowDialog()
                sCodeSUBAC = fDICO._Code
            End If
            If f._bSUBACUNITE Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("19")
                fDICO.Text = "Substances actives - Unités de dosage"
                fDICO.ShowDialog()
                sCodeSUBACUNITE = fDICO._Code
                sLibelleSUBACUNITE = fDICO._Libelle
            End If
            If f._bSUBAU Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SAU_SUBAUXILIAIRE
                fDICO.Text = "Excipients"
                fDICO.ShowDialog()
                sCodeSUBAU = fDICO._Code
            End If
            If f._bSUBAUUNITE Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("19")
                fDICO.Text = "Excipients - Unités de dosage"
                fDICO.ShowDialog()
                sCodeSUBAUUNITE = fDICO._Code
                sLibelleSUBAUUNITE = fDICO._Libelle
            End If
            If f._bTENEUR Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("24")
                fDICO.Text = "Teneurs"
                fDICO.ShowDialog()
                sCodeTENEUR = fDICO._Code
            End If
            If f._bTENEURUNITE Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("19")
                fDICO.Text = "Teneurs - Unités de dosage"
                fDICO.ShowDialog()
                sCodeTENEURUNITE = fDICO._Code
                sLibelleTENEURUNITE = fDICO._Libelle
            End If
            If f._bTENEUREQUIV Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("19")
                fDICO.Text = "Teneurs - Equivalent"
                fDICO.ShowDialog()
                sCodeTENEUREQUIV = fDICO._Code
            End If

            Dim fResultat As New Frm_Recherche
            Dim sSQL As String = ""
            sSQL &= " Select SP_CODE_SQ_PK as code, SP_NOM as libelle From THERIAQUE.SP_SPECIALITE"
            If sCodeSP <> "" Then
                sSQL &= " WHERE SP_CODE_SQ_PK IN (SELECT SP_CODE_SQ_PK FROM THERIAQUE.SP_SPECIALITE WHERE SP_CODE_SQ_PK = " & cn.SQLText(sCodeSP) & ")"
            End If
            If sCodePR <> "" Then
                If sCodeSP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SP_CODE_SQ_PK FROM THERIAQUE.SP_SPECIALITE WHERE SP_PR_CODE_FK = " & cn.SQLText(sCodePR) & ")"
            End If
            If sCodeCIS <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SP_CODE_SQ_PK FROM THERIAQUE.SP_SPECIALITE WHERE SP_NL = " & cn.SQLText(sCodeCIS) & ")"
            End If
            If sCodeLABO <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SPLAB_SP_CODE_FK_PK FROM THERIAQUE.SPLAB_SPECIALITE_LABO WHERE SPLAB_CDF_LAB_CODE_FK_PK = " & cn.SQLText(sCodeLABO) & ")"
            End If
            If sCodeSTLABO <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SP_CODE_SQ_PK FROM THERIAQUE.SP_SPECIALITE WHERE SP_CDF_SLAB_CODE_FK = " & cn.SQLText(sCodeSTLABO) & ")"
            End If
            If sCodeLABOEXP <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SPLABEX_SP_CODE_FK_PK FROM THERIAQUE.SPLABEX_SPE_LABO_EXPLOITANT WHERE SPLABEX_CDF_LAB_CODE_FK_PK = " & cn.SQLText(sCodeLABOEXP) & ")"
            End If
            If sCodeVA <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SPVO_SP_CODE_FK_PK FROM THERIAQUE.SPVO_SPECIALITE_VOIE WHERE SPVO_CDF_VO_CODE_FK_PK = " & cn.SQLText(sCodeVA) & ")"
            End If
            If sCodeFPH <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SPFO_SP_CODE_FK_PK FROM THERIAQUE.SPFO_SPECIALITE_FORME WHERE SPFO_CDF_FO_CODE_FK_PK = " & cn.SQLText(sCodeFPH) & ")"
            End If
            If sCodeCOMPFORM <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SPFOCFO_SP_CODE_FK_PK FROM THERIAQUE.SPFOCFO_SPE_FORME_COMPFORME WHERE SPFOCFO_CDF_CFO_CODE_FK_PK = " & cn.SQLText(sCodeCOMPFORM) & ")"
            End If
            If sCodeCOMP <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT COMPO_SP_CODE_FK_PK FROM THERIAQUE.COMPO_COMPOSITION WHERE COMPO_CDF_GAL_CODE_FK = " & cn.SQLText(sCodeCOMP) & ")"
            End If
            If sCodeCPH <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SPCPH_SP_CODE_FK_PK FROM THERIAQUE.SPCPH_SPECIALITE_CLASSEPH WHERE SPCPH_CPH_CODE_FK_PK = " & cn.SQLText(sCodeCPH) & ")"
            End If
            If sCodeATC <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Or sCodeCPH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SP_CODE_SQ_PK FROM THERIAQUE.SP_SPECIALITE WHERE SP_CATC_CODE_FK = " & cn.SQLText(sCodeATC) & ")"
            End If
            If sCodeEPH <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Or sCodeCPH <> "" Or sCodeATC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SP_CODE_SQ_PK FROM THERIAQUE.SP_SPECIALITE WHERE SP_CEPH_CODE_FK = " & cn.SQLText(sCodeEPH) & ")"
            End If
            If sCodeCGESTION <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Or sCodeCPH <> "" Or sCodeATC <> "" Or sCodeEPH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SP_CODE_SQ_PK FROM THERIAQUE.SP_SPECIALITE WHERE SP_CGE_CODE_FK = " & cn.SQLText(sCodeCGESTION) & ")"
            End If
            If sCodeCC <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Or sCodeCPH <> "" Or sCodeATC <> "" Or sCodeEPH <> "" Or sCodeCGESTION <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SPCH_SP_CODE_FK_PK FROM THERIAQUE.SPCH_SPECIALITE_CHOIX WHERE SPCH_CH_CODE_FK_PK = " & cn.SQLText(sCodeCC) & ")"
            End If
            If sCodeLIST <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Or sCodeCPH <> "" Or sCodeATC <> "" Or sCodeEPH <> "" Or sCodeCGESTION <> "" Or sCodeCC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SP_CODE_SQ_PK FROM THERIAQUE.SP_SPECIALITE WHERE SP_CDF_LI_CODE_FK = " & cn.SQLText(sCodeLIST) & ")"
            End If
            If sCodePRES <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Or sCodeCPH <> "" Or sCodeATC <> "" Or sCodeEPH <> "" Or sCodeCGESTION <> "" Or sCodeCC <> "" Or sCodeLIST <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT SPCPD_SP_CODE_FK_PK FROM THERIAQUE.SPCPD_SPE_CDT_PRESCR WHERE SPCPD_CDF_STP_CODE_FK_PK = " & cn.SQLText(sCodePRES) & ")"
            End If
            If sCodeSUBAC <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Or sCodeCPH <> "" Or sCodeATC <> "" Or sCodeEPH <> "" Or sCodeCGESTION <> "" Or sCodeCC <> "" Or sCodeLIST <> "" Or sCodePRES <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT COSAC_SP_CODE_FK_PK FROM THERIAQUE.COSAC_COMPO_SUBACT WHERE COSAC_SAC_BASE_CODE_FK = " & cn.SQLText(sCodeSUBAC) & " UNION SELECT COSAC_SP_CODE_FK_PK FROM THERIAQUE.COSAC_COMPO_SUBACT WHERE COSAC_SAC_CODE_FK_PK = " & cn.SQLText(sCodeSUBAC) & ")"
            End If
            If sCodeSUBACUNITE <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Or sCodeCPH <> "" Or sCodeATC <> "" Or sCodeEPH <> "" Or sCodeCGESTION <> "" Or sCodeCC <> "" Or sCodeLIST <> "" Or sCodePRES <> "" Or sCodeSUBAC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT COSAC_SP_CODE_FK_PK FROM THERIAQUE.COSAC_COMPO_SUBACT WHERE COSAC_UNITEDOSAGE = " & cn.SQLText(sLibelleSUBACUNITE) & ")"
            End If
            If sCodeSUBAU <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Or sCodeCPH <> "" Or sCodeATC <> "" Or sCodeEPH <> "" Or sCodeCGESTION <> "" Or sCodeCC <> "" Or sCodeLIST <> "" Or sCodePRES <> "" Or sCodeSUBAC <> "" Or sCodeSUBACUNITE <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT COSAU_SP_CODE_FK_PK FROM THERIAQUE.COSAU_COMPO_SUBAUX WHERE COSAU_SAU_CODE_FK_PK = " & cn.SQLText(sCodeSUBAU) & ")"
            End If
            If sCodeSUBAUUNITE <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Or sCodeCPH <> "" Or sCodeATC <> "" Or sCodeEPH <> "" Or sCodeCGESTION <> "" Or sCodeCC <> "" Or sCodeLIST <> "" Or sCodePRES <> "" Or sCodeSUBAC <> "" Or sCodeSUBACUNITE <> "" Or sCodeSUBAU <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT COSAU_SP_CODE_FK_PK FROM THERIAQUE.COSAU_COMPO_SUBAUX WHERE COSAU_UNITEDOSAGE = " & cn.SQLText(sLibelleSUBAUUNITE) & ")"
            End If
            If sCodeTENEUR <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Or sCodeCPH <> "" Or sCodeATC <> "" Or sCodeEPH <> "" Or sCodeCGESTION <> "" Or sCodeCC <> "" Or sCodeLIST <> "" Or sCodePRES <> "" Or sCodeSUBAC <> "" Or sCodeSUBACUNITE <> "" Or sCodeSUBAU <> "" Or sCodeSUBAUUNITE <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT COTEN_SP_CODE_FK_PK FROM THERIAQUE.COTEN_COMPO_TENEUR WHERE COTEN_CDF_TEN_CODE_FK_PK = " & cn.SQLText(sCodeTENEUR) & ")"
            End If
            If sCodeTENEURUNITE <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Or sCodeCPH <> "" Or sCodeATC <> "" Or sCodeEPH <> "" Or sCodeCGESTION <> "" Or sCodeCC <> "" Or sCodeLIST <> "" Or sCodePRES <> "" Or sCodeSUBAC <> "" Or sCodeSUBACUNITE <> "" Or sCodeSUBAU <> "" Or sCodeSUBAUUNITE <> "" Or sCodeTENEUR <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT COTEN_SP_CODE_FK_PK FROM THERIAQUE.COTEN_COMPO_TENEUR WHERE COTEN_CDF_UD_CODE_FK = " & cn.SQLText(sLibelleTENEURUNITE) & ")"
            End If
            If sCodeTENEUREQUIV <> "" Then
                If sCodeSP <> "" Or sCodePR <> "" Or sCodeCIS <> "" Or sCodeLABO <> "" Or sCodeSTLABO <> "" Or sCodeLABOEXP <> "" Or sCodeVA <> "" Or sCodeFPH <> "" Or sCodeCOMPFORM <> "" Or sCodeCOMP <> "" Or sCodeCPH <> "" Or sCodeATC <> "" Or sCodeEPH <> "" Or sCodeCGESTION <> "" Or sCodeCC <> "" Or sCodeLIST <> "" Or sCodePRES <> "" Or sCodeSUBAC <> "" Or sCodeSUBACUNITE <> "" Or sCodeSUBAU <> "" Or sCodeSUBAUUNITE <> "" Or sCodeTENEUR <> "" Or sCodeTENEURUNITE <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SP_CODE_SQ_PK IN (SELECT COTEN_SP_CODE_FK_PK FROM THERIAQUE.COTEN_COMPO_TENEUR WHERE COTEN_CDF_UD_EQUIV_CODE_FK = " & cn.SQLText(sCodeTENEUREQUIV) & ")"
            End If

            sSQL &= " ORDER BY SP_CODE_SQ_PK"
            fResultat._SSQL = sSQL
            fResultat.Text = Me.Text
            fResultat.Appelant = "S"

            fResultat.ShowDialog()
            dtResultat = fResultat.dtSpecialite
            dtResultat.Columns(0).ColumnName = "Code"
            dtResultat.Columns(1).ColumnName = "Libelle"

            Dim p As New Frm_Partage

            doc = Me.gvDocument.GetRow(gvDocument.FocusedRowHandle)
            p.docId = doc.DO_ID
            p.dtResultat = dtResultat
            p.Type = "UCD"
            p.ShowDialog()

        End If
        

    End Sub

    Private Sub btApercu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btApercu.Click

        If gvDocument.FocusedRowHandle >= 0 Then
            doc = Me.gvDocument.GetRow(gvDocument.FocusedRowHandle)
            Dim f As New FrmApercu
            f.doc = doc
            f.ShowDialog()
        Else
            MsgBox("Veuillez sélectionner un document")
        End If

    End Sub

    Private Sub gvDocuments_BeforeLeaveRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowAllowEventArgs) Handles gvDocument.BeforeLeaveRow
        SaveDoc()
    End Sub

    Private Sub gvDocuments_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvDocument.FocusedRowChanged
        doc = Me.gvDocument.GetRow(e.FocusedRowHandle)
        If doc Is Nothing Then

            'Affichage des propriétés.
            Me.txtLibelle2.Text = Nothing
            Me.meNote.Text = Nothing
            Me.lueCategorie.EditValue = Nothing
            Exit Sub
        Else
            'Affichage des propriétés.
            Me.txtLibelle2.Text = doc.DO_Label
            Me.meNote.Text = doc.DO_Note
            Me.lueCategorie.EditValue = CType(doc.ID_Categorie, Short)

        End If

    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        SaveDoc()
    End Sub

    Private Sub SaveDoc()

        If (doc IsNot Nothing) Then
            If doc.DO_Label = Me.txtLibelle2.Text And doc.DO_Note = Me.meNote.Text Then
                If (Not String.IsNullOrEmpty(Me.lueCategorie.EditValue)) Then

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

            doc.DO_Label = Me.txtLibelle2.Text
            doc.DO_Note = Me.meNote.Text
            doc.cn = New SqlClient.SqlConnection(cn.sConnexion)

            If (Not String.IsNullOrEmpty(Me.lueCategorie.EditValue)) Then
                If Me.lueCategorie.EditValue IsNot DBNull.Value Then ' And Me.lueCategorie.EditValue <> "" Then
                    doc.ID_Categorie = Me.lueCategorie.EditValue
                End If
            End If
            doc.Save(False)
        End If

    End Sub

    Private Sub cmdAnnuler_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAnnuler.Click


        doc = Me.gvDocument.GetRow(gvDocument.FocusedRowHandle)
        If (doc IsNot Nothing) Then
            'Affichage des propriétés.
            Me.txtLibelle2.Text = doc.DO_Label
            Me.meNote.Text = doc.DO_Note
            Me.lueCategorie.EditValue = CType(doc.ID_Categorie, Short)
        End If

    End Sub
 
    Private Sub GV13_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV13.ValidateRow

        Dim IsValid As Boolean = Not IsPere(e.Row(1))

        If (Not IsValid) Then
            e.ErrorText = "C'est une codification père impossible de la joindre à une spécialité "
            e.Valid = False
        End If

    End Sub

    Public Function IsPere(ByVal sCPH_NOM As String) As Boolean

        Dim req As String = " SELECT CPH_CODE_PK AS code, CPH_NOM AS libelle "

        req &= " FROM Theriaque.CPH_CLASSEPHARMTHER WHERE "
        req &= " CPH_CODE_PK IN ( SELECT DISTINCT SACCPH_CPH_CODE_FK_PK  From Theriaque.SACCPH_SUBACT_CLASSEPH ) "
        req &= " and CPH_CODE_PK LIKE '" & sCPH_NOM & "%' "
        req &= " and LEN(CPH_CODE_PK) > LEN('" & sCPH_NOM & "') "
        req &= " UNION SELECT CPH_CODE_PK AS code, CPH_NOM AS libelle "
        req &= " FROM Theriaque.CPH_CLASSEPHARMTHER "
        req &= " WHERE CPH_CODE_PK LIKE 'A%'"
        req &= " and CPH_CODE_PK LIKE '" & sCPH_NOM & "%' "
        req &= " and LEN(CPH_CODE_PK) > LEN('" & sCPH_NOM & "') "

        Dim dt As DataTable = cn.MySelect(req)

        Return (dt.Rows.Count <> 0)


    End Function

End Class
