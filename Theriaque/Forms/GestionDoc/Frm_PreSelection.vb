Public Class Frm_PreSelection


    Public dtResultat As DataTable
    Public NewSrch As Boolean
    Public bAnnuler As Boolean
    Public _Validate As Boolean

    Private Sub btnAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuler.Click

        bAnnuler = True
        Me.Close()

    End Sub

    Private Sub btnLancerRche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLancerRche.Click

        If rgSelection.SelectedIndex = 0 Then
            RechercherSpecialites()
        Else
            RechercherPresentation()
        End If
        Me.Close()

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

        Dim f As New Frm_SpecialiteMultiCriteres
        f.ShowDialog()
        _Validate = f._Validate
        If f._Validate Then
            If f._bSP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SP_SPECIALITE
                fDICO.Text = "Spécialités"
                fDICO.Appelant = "S"

                fDICO.critere = True
                fDICO.ShowDialog()
                sCodeSP = fDICO._Code
            End If
            If f._bPR Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_PR_PRODUIT
                fDICO.Text = "Produits"
                fDICO.Appelant = "S"
                fDICO.critere = True

                fDICO.ShowDialog()
                sCodePR = fDICO._Code
            End If
            If f._bCIS Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQLSP_NL__CIS
                fDICO.Text = "Code identifiant spécialité(CIS)"
                fDICO.Appelant = "S"
                fDICO.critere = True

                fDICO.ShowDialog()
                sCodeCIS = fDICO._Code
            End If
            If f._bLABO Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("07")
                fDICO.Text = "Laboratoire"
                fDICO.Appelant = "S"
                fDICO.critere = True

                fDICO.ShowDialog()
                sCodeLABO = fDICO._Code
            End If
            If f._bSTLABO Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("15")
                fDICO.Text = "Statut laboratoire"
                fDICO.Appelant = "S"
                fDICO.critere = True

                fDICO.ShowDialog()
                sCodeSTLABO = fDICO._Code
            End If
            If f._bLABOEXP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("07")
                fDICO.Text = "Laboratoire exploitant"
                fDICO.Appelant = "S"
                fDICO.critere = True

                fDICO.ShowDialog()
                sCodeLABOEXP = fDICO._Code
            End If
            If f._bVA Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("18")
                fDICO.Text = "Voie d’administration"
                fDICO.Appelant = "S"
                fDICO.critere = True

                fDICO.ShowDialog()
                sCodeVA = fDICO._Code
            End If
            If f._bFPH Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("06")
                fDICO.Text = "Forme pharmaceutique"
                fDICO.Appelant = "S"
                fDICO.critere = True

                fDICO.ShowDialog()
                sCodeFPH = fDICO._Code
            End If
            If f._bCOMPFORM Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("02")
                fDICO.Text = "Complément de forme"
                fDICO.Appelant = "S"
                fDICO.critere = True

                fDICO.ShowDialog()
                sCodeCOMPFORM = fDICO._Code
            End If
            If f._bCOMP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("22")
                fDICO.Text = "Composition"
                fDICO.Appelant = "S"
                fDICO.critere = True
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
                fDICO.Appelant = "S"
                fDICO.critere = True
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
                fDICO.Appelant = "S"
                fDICO.critere = True
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
                fDICO.Appelant = "S"
                fDICO.critere = True
                fDICO.ShowDialog()
                sCodeEPH = fDICO._Code
            End If
            If f._bCGESTION Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CGE_CLASSEGESTION
                fDICO.Text = "Classes gestion"
                fDICO.Appelant = "S"
                fDICO.critere = True
                fDICO.ShowDialog()
                sCodeCGESTION = fDICO._Code
            End If
            If f._bCC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CH_CHOIX
                fDICO.Text = "Critères de choix"
                fDICO.Appelant = "S"
                fDICO.critere = True
                fDICO.ShowDialog()
                sCodeCC = fDICO._Code
            End If
            If f._bLIST Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("08")
                fDICO.Text = "Listes"
                fDICO.Appelant = "S"
                fDICO.critere = True
                fDICO.ShowDialog()
                sCodeLIST = fDICO._Code
            End If
            If f._bPRES Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("14") & " and substring(CDF_CODE_PK,1,1) = 'S'"
                fDICO.Text = "Prescriptions / délivrances"
                fDICO.Appelant = "S"
                fDICO.critere = True
                fDICO.ShowDialog()
                sCodePRES = fDICO._Code
            End If
            If f._bSUBAC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SAC_SUBACTIVE
                fDICO.Text = "Substances actives"
                fDICO.Appelant = "S"
                fDICO.critere = True
                fDICO.ShowDialog()
                sCodeSUBAC = fDICO._Code
            End If
            If f._bSUBACUNITE Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("19")
                fDICO.Text = "Substances actives - Unités de dosage"
                fDICO.Appelant = "S"
                fDICO.critere = True
                fDICO.ShowDialog()
                sCodeSUBACUNITE = fDICO._Code
                sLibelleSUBACUNITE = fDICO._Libelle
            End If
            If f._bSUBAU Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SAU_SUBAUXILIAIRE
                fDICO.Text = "Excipients"
                fDICO.Appelant = "S"
                fDICO.critere = True
                fDICO.ShowDialog()
                sCodeSUBAU = fDICO._Code
            End If
            If f._bSUBAUUNITE Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("19")
                fDICO.Text = "Excipients - Unités de dosage"
                fDICO.Appelant = "S"
                fDICO.critere = True
                fDICO.ShowDialog()
                sCodeSUBAUUNITE = fDICO._Code
                sLibelleSUBAUUNITE = fDICO._Libelle
            End If
            If f._bTENEUR Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("24")
                fDICO.Text = "Teneurs"
                fDICO.Appelant = "S"
                fDICO.critere = True
                fDICO.ShowDialog()
                sCodeTENEUR = fDICO._Code
            End If
            If f._bTENEURUNITE Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("19")
                fDICO.Text = "Teneurs - Unités de dosage"
                fDICO.Appelant = "S"
                fDICO.critere = True
                fDICO.ShowDialog()
                sCodeTENEURUNITE = fDICO._Code
                sLibelleTENEURUNITE = fDICO._Libelle
            End If
            If f._bTENEUREQUIV Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("19")
                fDICO.Text = "Teneurs - Equivalent"
                fDICO.Appelant = "S"
                fDICO.critere = True
                fDICO.ShowDialog()
                sCodeTENEUREQUIV = fDICO._Code
            End If

            Dim fResultat As New Frm_Recherche
            Dim sSQL As String = ""
            '2809LZA 'sSQL &= " Select SP_CODE_SQ_PK as code, '' as libelle From THERIAQUE.SP_SPECIALITE"
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
            NewSrch = chkNewSearch.Checked
            fResultat.ShowDialog()

            dtResultat = fResultat.dtSpecialite
            dtResultat.Columns(0).ColumnName = "Code"
            dtResultat.Columns(1).ColumnName = "Libelle"
            dtResultat.Columns.Add(New DataColumn("Type"))

            Dim typeS As String
            If rgSelection.SelectedIndex = 0 Then
                typeS = "UCD"
            Else
                typeS = "CIP"
            End If


            For i As Integer = 0 To dtResultat.Rows.Count - 1

                dtResultat.Rows(i).Item("Type") = typeS

            Next



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
        f.ShowDialog()
        _Validate = f._Validate
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
            sSQL &= " Select PRE_CODE_PK as code, sp.SP_NOM as libelle From THERIAQUE.PRE_PRESENTATION, theriaque.SP_SPECIALITE sp "
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

            If sCodeCONT <> "" Or sCodeMAT <> "" Or sCodeCCOMP <> "" Or sCodeCEMB <> "" Or sCodePRUNIT <> "" Or sCodeTAUXVILLE <> "" Or sCodeTAUXHOP <> "" Or sCodePREHOS <> "" Or sCodeST <> "" Or sCodeSTCOMP <> "" Or sCodeSTREMB <> "" Or sCodeCONDCONS <> "" Or sCodeLIEUDISP <> "" Then
                sSQL &= " AND"
            Else
                sSQL &= " WHERE "
            End If
            sSQL &= " PRE_SP_CODE_FK = sp.SP_CODE_SQ_PK "

            sSQL &= " ORDER BY PRE_CODE_PK"
            fResultat._SSQL = sSQL
            fResultat.Text = Me.Text

            fResultat.Appelant = "P"
            NewSrch = chkNewSearch.Checked
            fResultat.ShowDialog()

            dtResultat = fResultat.dtSpecialite
            dtResultat.Columns(0).ColumnName = "CodeSP"
            dtResultat.Columns(1).ColumnName = "Libelle"
            dtResultat.Columns.Add(New DataColumn("Type"))

            Dim typeS As String
            If rgSelection.SelectedIndex = 0 Then
                typeS = "UCD"
            Else
                typeS = "CIP"
            End If


            For i As Integer = 0 To dtResultat.Rows.Count - 1

                dtResultat.Rows(i).Item("Type") = typeS


            Next
        End If
       
    End Sub

End Class