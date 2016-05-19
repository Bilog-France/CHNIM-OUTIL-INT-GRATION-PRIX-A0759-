Public Module ModSQLData

    Public cn As New SQLcn

#Region " Requette "

    Public Function strSSQL_CDFUCUM_SYMBOLE(ByVal strNumero As String, Optional ByVal strSupllSQL As String = "") As String
        Dim strSSQL As String = ""
        strSSQL = " select '0' as code, '' as libelle from theriaque.CDFUCUM_UCUM "
        strSSQL &= "union select CDFUCUM_CODE_PK as code, CDFUCUM_SYMBOLE as libelle from theriaque.CDFUCUM_UCUM "
        'strSSQL &= " where CDFUCUM_CODE_PK in (select CDFCDFU_CDFUCUM_CODE_FK_PK  from theriaque.CDFCDFU_CDFU "
        'strSSQL &= " where CDFCDFU_CDF_NUMERO_FK_PK = " & cn.SQLText(strNumero) & ") "
        strSSQL &= strSupllSQL
        Return strSSQL
    End Function

    Public Function strSSQL_CDF_CODIF(ByVal strNumero As String, Optional ByVal strSupllSQL As String = "") As String
        Dim strSSQL As String = ""
        strSSQL = "Select CDF_CODE_PK as code, CDF_NOM as libelle, CDF_NUMERO_PK as num From THERIAQUE.CDF_CODIF "
        strSSQL &= " where CDF_NUMERO_PK = " & cn.SQLText(strNumero) & " "
        strSSQL &= strSupllSQL
        Return strSSQL
    End Function

    Public Function strSSQL_CDF_CODIF2(ByVal strNumero As String, Optional ByVal strSupllSQL As String = "") As String
        Dim strSSQL As String = ""
        strSSQL = "Select CDF_CODE_PK as code, CDF_NOM as libelle From THERIAQUE.CDF_CODIF "
        strSSQL &= " where CDF_NUMERO_PK = " & cn.SQLText(strNumero) & " "
        strSSQL &= strSupllSQL
        Return strSSQL
    End Function

    Public Function strSSQL_CDF_CODIF_Libelle(ByVal strNumero As String, Optional ByVal strSupllSQL As String = "") As String
        Dim strSSQL As String = ""
        strSSQL = "Select CDF_CODE_PK as val1, CDF_NOM as code, CDF_NOM as libelle, CDF_NUMERO_PK as num From THERIAQUE.CDF_CODIF "
        strSSQL &= " where CDF_NUMERO_PK = " & cn.SQLText(strNumero) & " "
        strSSQL &= strSupllSQL
        Return strSSQL
    End Function

    Public Function strSSQL_CDF_CODIF_Distinct(ByVal strNumero As String, Optional ByVal strSupllSQL As String = "") As String
        Dim strSSQL As String = ""
        strSSQL = "Select Distinct CDF_CODE_PK as code, CDF_NOM as libelle, CDF_NUMERO_PK as num ,0 as chk From THERIAQUE.CDF_CODIF "
        strSSQL &= "where CDF_NUMERO_PK = " & cn.SQLText(strNumero) & " "
        strSSQL &= strSupllSQL
        Return strSSQL
    End Function

    Public Function strSSQL_IN_CDF_CODIF(ByVal strNumero As String, Optional ByVal strNumero1 As String = "", Optional ByVal strNumero2 As String = "", Optional ByVal strNumero3 As String = "", Optional ByVal strNumero4 As String = "") As String
        Dim strSSQL As String = ""
        strSSQL = "Select CDF_CODE_PK as code, CDF_NOM as libelle, CDF_NUMERO_PK as num  From THERIAQUE.CDF_CODIF "
        strSSQL &= " where CDF_NUMERO_PK in (" & cn.SQLText(strNumero) & "," & cn.SQLText(strNumero1) & "," & cn.SQLText(strNumero2) & "," & cn.SQLText(strNumero3) & "," & cn.SQLText(strNumero4) & ")"
        Return strSSQL
    End Function

    Public Function strSSQL_IN_CDF_CODIF_Compose(ByVal strNumero As String, Optional ByVal strNumero1 As String = "", Optional ByVal strNumero2 As String = "", Optional ByVal strNumero3 As String = "", Optional ByVal strNumero4 As String = "") As String
        Dim strSSQL As String = ""
        strSSQL = "Select CDF_CODE_PK + '_' + CDF_NUMERO_PK  as code, CDF_NOM as libelle, CDF_NUMERO_PK as num  From THERIAQUE.CDF_CODIF "
        strSSQL &= " where CDF_NUMERO_PK in (" & cn.SQLText(strNumero) & "," & cn.SQLText(strNumero1) & "," & cn.SQLText(strNumero2) & "," & cn.SQLText(strNumero3) & "," & cn.SQLText(strNumero4) & ")"
        Return strSSQL
    End Function

    Public Function strSSQL_IN_CDF_CODIF_DUAL(ByVal strNumero As String, Optional ByVal strNumero1 As String = "", Optional ByVal strNumero2 As String = "", Optional ByVal strNumero3 As String = "", Optional ByVal strNumero4 As String = "") As String
        Dim strSSQL As String = ""
        strSSQL = "Select CDF_CODE_PK as code, CDF_NOM as libelle, CDF_NUMERO_PK as num  From THERIAQUE.CDF_CODIF "
        strSSQL &= " where CDF_NUMERO_PK in (" & cn.SQLText(strNumero) & "," & cn.SQLText(strNumero1) & "," & cn.SQLText(strNumero2) & "," & cn.SQLText(strNumero3) & "," & cn.SQLText(strNumero4) & ")"
        Return strSSQL
    End Function

    Public Const strSSQL_SP_SPECIALITE As String = "Select SP_CODE_SQ_PK as code, SP_NOM as libelle From THERIAQUE.SP_SPECIALITE"
    Public Const strSSQL_SP_SPECIALITE_Distinct As String = "Select Distinct SP_CODE_SQ_PK as code, SP_NOM as libelle ,0 as chk ,0 as chkFixe From THERIAQUE.SP_SPECIALITE"
    Public Const strSSQL_CPH_CLASSEPHARMTHER As String = "Select CPH_CODE_PK as code, CPH_NOM as libelle From THERIAQUE.CPH_CLASSEPHARMTHER"
    Public Const strSSQL_CPH_CLASSEPHARMTHER2 As String = "SELECT CPH_CODE_PK AS code, CPH_NOM AS libelle FROM THERIAQUE.CPH_CLASSEPHARMTHER WHERE CPH_CODE_PK IN (SELECT DISTINCT SACCPH_CPH_CODE_FK_PK From THERIAQUE.SACCPH_SUBACT_CLASSEPH) UNION SELECT CPH_CODE_PK AS code, CPH_NOM AS libelle FROM THERIAQUE.CPH_CLASSEPHARMTHER WHERE CPH_CODE_PK LIKE 'A%'"
    Public Const strSSQL_CPH_CLASSEPHARMTHER_LAST As String = strSSQL_CPH_CLASSEPHARMTHER & " where CPH_CODE_PK not in (select distinct isnull(CPH_CPH_CODE_FK,'') from THERIAQUE.CPH_CLASSEPHARMTHER) "
    Public Const strSSQL_CPH_CLASSEPHARMTHER_FIRST As String = strSSQL_CPH_CLASSEPHARMTHER & " where CPH_CODE_PK in (select distinct isnull(CPH_CPH_CODE_FK,'') from THERIAQUE.CPH_CLASSEPHARMTHER) "
    Public Const strSSQL_CCH_CLASSECHIMIQUE As String = "Select CCH_CODE_PK as code, CCH_NOM as libelle From THERIAQUE.CCH_CLASSECHIMIQUE "
    Public Const strSSQL_CCH_CLASSECHIMIQUE_LAST As String = strSSQL_CCH_CLASSECHIMIQUE & " where CCH_CODE_PK not in (select distinct isnull(CCH_CCH_CODE_FK,'') from THERIAQUE.CCH_CLASSECHIMIQUE) "
    Public Const strSSQL_CGE_CLASSEGESTION As String = "Select CGE_CODE_SQ_PK as code, CGE_NOM as libelle From THERIAQUE.CGE_CLASSEGESTION "
    Public Const strSSQL_CIM10 As String = "Select CIM_CODE_PK as code, CIM_LIBELLE_COURT as libelle From THERIAQUE.CIM10 "
    Public Const strSSQL_CEPH_CLASSEEPHMRA As String = "Select CEPH_CODE_PK as code, CEPH_NOMF as libelle From THERIAQUE.CEPH_CLASSEEPHMRA "
    Public Const strSSQL_CATC_CLASSEATC As String = "Select CATC_CODE_PK as code, CATC_NOMF as libelle From THERIAQUE.CATC_CLASSEATC "
    Public Const strSSQL_CISP_CLASSIF_INTER_SOINS As String = "Select CISP_CODE_PK as code, CISP_LIBELLE_COURT as libelle From THERIAQUE.CISP_CLASSIF_INTER_SOINS "
    Public Const strSSQL_Medra As String = "Select MED_CODE_PK as code, MED_LIBELLE_COURT as libelle From THERIAQUE.MEDRA "
    Public Const strSSQL_RUBCDF_RUBRIQUE_CODIFICATION As String = "Select RUBCDF_NUMERO_PK as code, RUBCDF_NOM as libelle From THERIAQUE.RUBCDF_RUBRIQUE_CODIFICATION "
    Public Const strSSQL_TXTI_TEXTINTRO_CMI As String = "SELECT FETTXTI_FET_CODE_FK_PK as code,  FETTXTI_TXT_INTRO as libelle FROM THERIAQUE.FETTXTI_TEXTINTRO_CMI"

    Public Const strSSQL_GSP_GENERIQUE_SPECIALITE As String = "Select GSP_CODE_SQ_PK as code, GSP_NOM as libelle From THERIAQUE.GSP_GENERIQUE_SPECIALITE"
    Public Const strSSQL_PR_PRODUIT As String = "Select PR_CODE_SQ_PK as code, PR_NOM as libelle From THERIAQUE.PR_PRODUIT"
    Public Const strSSQL_SAC_SUBACTIVE As String = "Select SAC_CODE_SQ_PK as code, SAC_NOM as libelle,0 as chk ,0 as chkFixe From THERIAQUE.SAC_SUBACTIVE"
    Public Const strSSQL_ADSAC_AUTRE_DENOMINATION_SUBAC As String = "Select ADSAC_SAC_CODE_FK  as code, ADSAC_NOM_PK as libelle,0 as chk ,0 as chkFixe  from THERIAQUE.ADSAC_AUTRE_DENOMINATION_SUBAC"
    Public Const strSSQL_SYFSAC_SYNONYME_SUBAC As String = "SELECT SYFSAC_SAC_CODE_FK as code, SYFSAC_NOM_PK as libelle, 0 as chk ,0 as chkFixe FROM THERIAQUE.SYFSAC_SYNONYMEFR_SUBACT"
    Public Const strSSQLSYSP_SYNONYME_SPECIALITE As String = "SELECT SYSP_SP_CODE_FK as code, SYSP_NOM_PK as libelle, 0 as chk ,0 as chkFixe FROM THERIAQUE.SYSP_SYNONYME_SPECIALITE"
    Public Const strSSQLSP_NL__SPECIALITE As String = "SELECT SP_CODE_SQ_PK as code, SP_NL as libelle, 0 as chk ,0 as chkFixe FROM THERIAQUE.SP_SPECIALITE"
    Public Const strSSQLSP_NL__CIS As String = "SELECT SP_NL as code, ''  as libelle, 0 as chk ,0 as chkFixe FROM THERIAQUE.SP_SPECIALITE"
    Public Const strSSQLSP_CIPUCD_SPECIALITE As String = "SELECT SP_CODE_SQ_PK as code, SP_CIPUCD as libelle, 0 as chk ,0 as chkFixe FROM THERIAQUE.SP_SPECIALITE"

    Public Const strSSQL_SAU_SUBAUXILIAIRE As String = "Select SAU_CODE_SQ_PK as code, SAU_NOM as libelle, 0 as chk, 0 as chkFixe From THERIAQUE.SAU_SUBAUXILIAIRE"
    Public Const strSSQL_SAU_SUBAUXILIAIRE_NOTOIRE As String = "Select SAU_CODE_SQ_PK as code, SAU_EFFETNOTOIRE as libelle, 0 as chk, 0 as chkFixe From THERIAQUE.SAU_SUBAUXILIAIRE"
    Public Const strSSQL_CH_CHOIX As String = "Select CH_CODE_SQ_PK as code, CH_TITRE1 as libelle from THERIAQUE.CH_CHOIX"
    Public Const strSSQL_RMO As String = "Select RMO_CODE_PK as code, RMO_TITRE1 as libelle from THERIAQUE.RMO"
    Public Const strSSQL_CLRMO_CLASSE_RMO As String = "Select  CLRMO_CL_CODE_PK as code, CLRMO_NOM as libelle,CLRMO_RMO_CODE_FK_PK from THERIAQUE.CLRMO_CLASSE_RMO"
    Public Const strSSQL_FTH_FICHEINFOTHERAPEUTIQUE As String = "Select FTH_CODE_SQ_PK as code, FTH_TITRE as libelle from THERIAQUE.FTH_FICHEINFOTHERAPEUTIQUE"
    Public Const strSSQL_FTR_FICHETRANSPARENCE As String = "Select FTR_CODE_SQ_PK as code, FTR_TITRE as libelle from THERIAQUE.FTR_FICHETRANSPARENCE"
    Public Const strSSQL_ATR_AVISCOMMISSIONTRANSPARENCE As String = "Select ATR_CODE_SQ_PK as code, ATR_TITRE as libelle from THERIAQUE.ATR_AVISCOMMISSIONTRANSPARENCE"
    Public Const strSSQL_PRE_PRESENTATION As String = "Select PRE_CODE_PK as code, (Select SP_NOM  From THERIAQUE.SP_SPECIALITE a where SP_CODE_SQ_PK  = b.PRE_SP_CODE_FK)as libelle from THERIAQUE.PRE_PRESENTATION b order by PRE_CODE_PK "
    Public Const strSSQL_GSAC_PERE_SUBACT As String = "Select GSAC_CODE_SQ_PK as code, GSAC_NOM as libelle FROM THERIAQUE.GSAC_PERE_SUBACT "
    Public Const strSSQL_FPRCL_SECPRECLIN As String = "Select FPRCL_CODE_SQ_PK as code, FPRCL_TXT as libelle From THERIAQUE.FPRCL_SECPRECLIN"
    Public Const strSSQL_FPHCO_PHARMACOCINETIQUE2 As String = "Select FPHCO_CODE_SQ_PK as code , '' as libelle From THERIAQUE.FPHCO_PHARMACOCINETIQUE"
    Public Const strSSQL_SYPR_SYNONYME_PR As String = "Select SYPR_PR_CODE_FK  as code, SYPR_NOM_PK as libelle,0 as chk ,0 as chkFixe  from THERIAQUE.SYPR_SYNONYME_PRODUIT"
    Public Const strSSQL_URL As String = "Select URL_CODE_PK as code, URL_TYPE as libelle from THERIAQUE.URL_ADRESSE"

    Public Const strSSQL_SAC_CODE_REF As String = "Select distinct SAC_CODE_REF as code, '' as libelle From THERIAQUE.SAC_SUBACTIVE where len(SAC_CODE_REF) > 0 "
    Public Const strSSQL_SAC_LIB_REF As String = "Select distinct SAC_LIBELLE_REF as code, '' as libelle From THERIAQUE.SAC_SUBACTIVE where len(SAC_LIBELLE_REF) > 0 "
    Public Const strSSQL_SAC_Type_REF As String = "Select distinct SAC_TYPE_REF as code, '' as libelle From THERIAQUE.SAC_SUBACTIVE where len(SAC_TYPE_REF) > 0 "
    Public Const strSSQL_SAC_CODE_CAS As String = "select distinct SACCAS_CAS_CODE_PK as code, '' as libelle from  theriaque.SACCAS_SUBACT_CAS"
    Public Const strSSQL_UniteUCUM As String = "SELECT [CDFUCUM_CODE_PK] as code,[CDFUCUM_SYMBOLE] as libelle FROM [theriaque].[theriaque].[CDFUCUM_UCUM] "
    Public Function strSSQL_FPHCO_PHARMACOCINETIQUE_SP() As String
        Dim strSSQL1 As String = ""
        strSSQL1 &= " Select FPHCO_CODE_SQ_PK as code, SP_NOM as libelle From THERIAQUE.FPHCO_PHARMACOCINETIQUE"
        strSSQL1 &= " left outer join THERIAQUE.FPHCOSP_PHARMACOCIN_SPEC"
        strSSQL1 &= " on FPHCOSP_FPHCO_CODE_FK_PK = FPHCO_CODE_SQ_PK"
        strSSQL1 &= " left outer join THERIAQUE.SP_SPECIALITE"
        strSSQL1 &= " on SP_CODE_SQ_PK =FPHCOSP_SP_CODE_FK_PK"
        Return strSSQL1
    End Function

    Public Function strSSQL_SPGREFR_GROUPE_SPE_REF() As String
        Dim strSSQL1 As String = ""
        strSSQL1 &= " select SPGREFR_GREF_CODE_FK_PK as code, SP_NOM as libelle from THERIAQUE.SPGREFR_GROUPE_SPE_REF, THERIAQUE.SP_SPECIALITE"
        strSSQL1 &= " Where SPGREFR_SP_CODE_FK_PK = SP_CODE_SQ_PK"
        strSSQL1 &= " UNION "
        strSSQL1 &= " select SPGREFG_GREF_CODE_FK_PK  as code, SP_NOM as libelle from THERIAQUE.SPGREFG_GROUPE_SPE_GENE, THERIAQUE.SP_SPECIALITE"
        strSSQL1 &= " Where SPGREFG_SP_CODE_FK_PK = SP_CODE_SQ_PK"
        Return strSSQL1
    End Function

    Public Function strSSQL_CPH_CLASSEPHARMTHER_NIVEAU() As String
        Dim strSSQL1 As String = ""
        strSSQL1 &= " Select CPH_CODE_PK as code, CPH_NOM as libelle,0 as disable ,0 as chk ,0 as chkFixe From THERIAQUE.CPH_CLASSEPHARMTHER"
        strSSQL1 &= " where CPH_CODE_PK  not in (select distinct isnull(CPH_CPH_CODE_FK,'') from THERIAQUE.CPH_CLASSEPHARMTHER) "
        strSSQL1 &= " UNION "
        strSSQL1 &= " Select CPH_CODE_PK as code, CPH_NOM as libelle, 1 as disable,0 as chk ,0 as chkFixe From THERIAQUE.CPH_CLASSEPHARMTHER"
        strSSQL1 &= " where CPH_CODE_PK in (select distinct isnull(CPH_CPH_CODE_FK,'') from THERIAQUE.CPH_CLASSEPHARMTHER)"
        strSSQL1 &= " order by CPH_CODE_PK  "
        Return strSSQL1
    End Function

    Public Function strSSQL_CCH_CLASSECHIMIQUE_NIVEAU() As String
        Dim strSSQL1 As String = ""
        strSSQL1 &= " SELECT CCH_CODE_PK as code, CCH_NOM as libelle, 0 AS disable , 0 AS chk , 0 AS chkFixe FROM THERIAQUE.CCH_CLASSECHIMIQUE"
        strSSQL1 &= " WHERE CCH_CODE_PK  NOT IN (SELECT DISTINCT ISNULL(CCH_CCH_CODE_FK,'') FROM THERIAQUE.CCH_CLASSECHIMIQUE) "
        strSSQL1 &= " UNION "
        strSSQL1 &= " SELECT CCH_CODE_PK as code, CCH_NOM as libelle, 1 AS disable,0 AS chk ,0 AS chkFixe FROM THERIAQUE.CCH_CLASSECHIMIQUE"
        strSSQL1 &= " WHERE CCH_CODE_PK in (select distinct isnull(CCH_CCH_CODE_FK,'') FROM THERIAQUE.CCH_CLASSECHIMIQUE)"
        strSSQL1 &= " ORDER BY CCH_CODE_PK "
        Return strSSQL1
    End Function

    Public Function strSSQL_CDF_CODIF_NIVEAU(ByVal strNumero As String, Optional ByVal strSupllSQL As String = "") As String
        Dim strSSQL1 As String = ""
        strSSQL1 &= " Select CDF_CODE_PK as code, CDF_NOM as libelle , 0 as disable From THERIAQUE.CDF_CODIF A where A.CDF_NUMERO_PK = '" & strNumero & "' and not exists"
        strSSQL1 &= " ( select B.CDF_NUMERO_PK from  THERIAQUE.CDF_CODIF B  where  B.CDF_NUMERO_PK = '" & strNumero & "' and "
        strSSQL1 &= "  substring(B.CDF_CODE_PK,1, len (A.CDF_CODE_PK)) =A.CDF_CODE_PK  and A.CDF_CODE_PK <> B.CDF_CODE_PK )" & " "
        strSSQL1 &= strSupllSQL
        strSSQL1 &= " UNION "
        strSSQL1 &= " Select  CDF_CODE_PK as code, CDF_NOM as libelle , 1 as disable From THERIAQUE.CDF_CODIF A where A.CDF_NUMERO_PK = '" & strNumero & "' and  exists"
        strSSQL1 &= " ( select B.CDF_NUMERO_PK from  THERIAQUE.CDF_CODIF B  where  B.CDF_NUMERO_PK = '" & strNumero & "' and "
        strSSQL1 &= "  substring(B.CDF_CODE_PK,1, len (A.CDF_CODE_PK)) =A.CDF_CODE_PK  and A.CDF_CODE_PK <> B.CDF_CODE_PK )" & " "
        strSSQL1 &= strSupllSQL
        strSSQL1 &= " ORDER BY CDF_CODE_PK "
        Return strSSQL1

    End Function
    Public Function FPO_FICHEPOSO_NIVEAU() As String
        Dim strSSQL1 As String = ""
        strSSQL1 &= " Select FPO_CODE_SQ_PK as code, SP_NOM as libelle from THERIAQUE.FPO_FICHEPOSO"
        strSSQL1 &= " Left outer join THERIAQUE.FPOSP_POSO_SPE "
        strSSQL1 &= " On FPOSP_FPO_CODE_FK_PK = FPO_CODE_SQ_PK "
        strSSQL1 &= " Left outer join THERIAQUE.SP_SPECIALITE "
        strSSQL1 &= " on  FPOSP_SP_CODE_FK_PK = SP_CODE_SQ_PK"
        Return strSSQL1

    End Function

#Region " Requette STOCKE "

    Public Function strSSQL_SAC_SP(ByVal SP_PK As String) As String
        Dim strTemp As String = ""
        strTemp = "  SELECT  DISTINCT SA.SAC_CODE_SQ_PK as code, SA.SAC_NOM as libelle"
        strTemp &= " FROM THERIAQUE.COSAC_COMPO_SUBACT CP "
        strTemp &= " LEFT JOIN THERIAQUE.SAC_SUBACTIVE SA ON CP.COSAC_SAC_CODE_FK_PK = SA.SAC_CODE_SQ_PK"
        strTemp &= " LEFT JOIN THERIAQUE.GSAC_PERE_SUBACT GP ON GP.GSAC_CODE_SQ_PK = SA.SAC_GSAC_CODE_FK"
        strTemp &= " LEFT JOIN  THERIAQUE.CDF_CODIF CD ON (SA.SAC_CDF_ORN_CODE_FK = CD.CDF_CODE_PK"
        strTemp &= " AND CD.CDF_NUMERO_PK = '11')"
        strTemp &= " WHERE CP.COSAC_SP_CODE_FK_PK = " & SP_PK
        strTemp &= " UNION "
        strTemp &= "  SELECT  SA.SAC_CODE_SQ_PK as code, SA.SAC_NOM as libelle"
        strTemp &= " FROM THERIAQUE.COSAC_COMPO_SUBACT CP "
        strTemp &= " LEFT JOIN THERIAQUE.SAC_SUBACTIVE SA ON CP.COSAC_SAC_BASE_CODE_FK = SA.SAC_CODE_SQ_PK"
        strTemp &= " LEFT JOIN THERIAQUE.GSAC_PERE_SUBACT GP ON GP.GSAC_CODE_SQ_PK = SA.SAC_GSAC_CODE_FK"
        strTemp &= " LEFT JOIN  THERIAQUE.CDF_CODIF CD ON (SA.SAC_CDF_ORN_CODE_FK = CD.CDF_CODE_PK"
        strTemp &= " AND CD.CDF_NUMERO_PK = '11')"
        strTemp &= " WHERE CP.COSAC_SP_CODE_FK_PK = " & SP_PK
        strTemp &= " AND SA.SAC_CODE_SQ_PK is not null"

        Return strTemp
    End Function

#End Region

#End Region

#Region " Table    "

    Public Const SP_SPECIALITE As String = "SP_SPECIALITE"
    Public Const CPH_CLASSEPHARMTHER As String = "CPH_CLASSEPHARMTHER"
    Public Const SYCPH_SYNONYME_CLASSEPHARMTHER As String = "SYCPH_SYNONYME_CLASSEPHARMTHER"
    Public Const CCH_CLASSECHIMIQUE As String = "CCH_CLASSECHIMIQUE"
    Public Const SYCCH_SYNONYME_CLASSECHIMIQUE As String = "SYCCH_SYNONYME_CLASSECHIMIQUE"
    Public Const CGE_CLASSEGESTION As String = "CGE_CLASSEGESTION"
    Public Const SYCGE_SYNONYME_CLASSEGESTION As String = "SYCGE_SYNONYME_CLASSEGESTION"
    Public Const CIM10 As String = "CIM10"
    Public Const MEDRA As String = "MEDRA"
    Public Const CEPH_CLASSEEPHMRA As String = "CEPH_CLASSEEPHMRA"
    Public Const SYFEPH_SYNONYMEFR_EPHMRA As String = "SYFEPH_SYNONYMEFR_EPHMRA"
    Public Const SYAEPH_SYNONYMEANGLAIS_EPHMRA As String = "SYAEPH_SYNONYMEANGLAIS_EPHMRA"
    Public Const SYFATC_SYNONYMEFR_ATC As String = "SYFATC_SYNONYMEFR_ATC"
    Public Const SYAATC_SYNONYMEANGLAIS_ATC As String = "SYAATC_SYNONYMEANGLAIS_ATC"
    Public Const CATC_CLASSEATC As String = "CATC_CLASSEATC"
    Public Const ATCDDD_DOSE_USUELLE_JOUR As String = "ATCDDD_DOSE_USUELLE_JOUR"
    Public Const CISP_CLASSIF_INTER_SOINS As String = "CISP_CLASSIF_INTER_SOINS"
    Public Const CDF_CODIF As String = "CDF_CODIF"
    Public Const SYCDF_SYNCODIF As String = "SYCDF_SYNCODIF"
    Public Const CDFPF_LIEN_CDF_PERE_FILS As String = "CDFPF_LIEN_CDF_PERE_FILS"
    Public Const CDFNP_CODIF As String = "CDFNP_CODIF"
    Public Const IDVO_IDENT_VOIE As String = "IDVO_IDENT_VOIE"
    Public Const CDFTE_TABLE_EQUIVALENCE As String = "CDFTE_TABLE_EQUIVALENCE"
    Public Const CIMCDF_CIM10_CODIF As String = "CIMCDF_CIM10_CODIF"
    Public Const NAIN_NATURE_INDICATION As String = "NAIN_NATURE_INDICATION"
    Public Const CDFIUP_INFO_UNITE_PRISE As String = "CDFIUP_INFO_UNITE_PRISE"
    Public Const CISPCDF_CISP_CODIF As String = "CISPCDF_CISP_CODIF"
    Public Const MEDCDF_MEDRA_CODIF As String = "MedcdF_MEDRA_CODIF"
    Public Const RUBCDF_RUBRIQUE_CODIFICATION As String = "RUBCDF_RUBRIQUE_CODIFICATION"

    Public Const GSP_GENERIQUE_SPECIALITE As String = "GSP_GENERIQUE_SPECIALITE"
    Public Const INTER_INTEROPERABLE As String = "INTER_INTEROPERABLE"
    Public Const PR_PRODUIT As String = "PR_PRODUIT"
    Public Const SYSP_SYNONYME_SPECIALITE As String = "SYSP_SYNONYME_SPECIALITE"
    Public Const SPLAB_SPECIALITE_LABO As String = "SPLAB_SPECIALITE_LABO"
    Public Const SPLABEX_SPE_LABO_EXPLOITANT As String = "SPLABEX_SPE_LABO_EXPLOITANT"
    Public Const SPVO_SPECIALITE_VOIE As String = "SPVO_SPECIALITE_VOIE"
    Public Const SPFO_SPECIALITE_FORME As String = "SPFO_SPECIALITE_FORME"
    Public Const SPFOCFO_SPE_FORME_COMPFORME As String = "SPFOCFO_SPE_FORME_COMPFORME"
    Public Const SPFOCPI_SPE_FORME_COMPINFO As String = "SPFOCPI_SPE_FORME_COMPINFO"
    Public Const SAC_SUBACTIVE As String = "SAC_SUBACTIVE"
    Public Const SAU_SUBAUXILIAIRE As String = "SAU_SUBAUXILIAIRE"
    Public Const COMPO_COMPOSITION As String = "COMPO_COMPOSITION"
    Public Const COSAC_COMPO_SUBACT As String = "COSAC_COMPO_SUBACT"
    Public Const COSAU_COMPO_SUBAUX As String = "COSAU_COMPO_SUBAUX"
    Public Const COTEN_COMPO_TENEUR As String = "COTEN_COMPO_TENEUR"
    Public Const SPADM_SPECIALITE_MODEADM As String = "SPADM_SPECIALITE_MODEADM"
    Public Const SPCPH_SPECIALITE_CLASSEPH As String = "SPCPH_SPECIALITE_CLASSEPH"
    Public Const SPDDD_DOSE_USUELLE_JOUR As String = "SPDDD_DOSE_USUELLE_JOUR"
    Public Const CH_CHOIX As String = "CH_CHOIX"
    Public Const SPCH_SPECIALITE_CHOIX As String = "SPCH_SPECIALITE_CHOIX"
    Public Const RMO As String = "RMO"
    Public Const SPRMO_SPECIALITE_RMO As String = "SPRMO_SPECIALITE_RMO"
    Public Const CLRMO_CLASSE_RMO As String = "CLRMO_CLASSE_RMO"
    Public Const FTH_FICHEINFOTHERAPEUTIQUE As String = "FTH_FICHEINFOTHERAPEUTIQUE"
    Public Const SPFTH_SPEC_INFOTHERAPEUTIQUE As String = "SPFTH_SPEC_INFOTHERAPEUTIQUE"
    Public Const FTHCPH_FIT_CLASSEPHARMTHER As String = "FTHCPH_FIT_CLASSEPHARMTHER"
    Public Const FTHCCH_FIT_CLASSECHIMIQUE As String = "FTHCCH_FIT_CLASSECHIMIQUE"
    Public Const FTHSAC_FIT_SUBACTIVE As String = "FTHSAC_FIT_SUBACTIVE"
    Public Const FTHSAU_FIT_SUBAUXILIAIRE As String = "FTHSAU_FIT_SUBAUXILIAIRE"
    Public Const FTHPR_FIT_PRODUIT As String = "FTHPR_FIT_PRODUIT"
    Public Const FTHCATC_FIT_CLASSEATC As String = "FTHCATC_FIT_CLASSEATC"
    Public Const SPFTR_SPECIALITE_TRANSPARENCE As String = "SPFTR_SPECIALITE_TRANSPARENCE"
    Public Const FTR_FICHETRANSPARENCE As String = "FTR_FICHETRANSPARENCE"
    Public Const SPATR_SPEC_AVISTRANSPARENCE As String = "SPATR_SPEC_AVISTRANSPARENCE"
    Public Const SPSMR_SERVICE_MEDICAL_RENDU As String = "SPSMR_SERVICE_MEDICAL_RENDU"
    Public Const ATR_AVISCOMMISSIONTRANSPARENCE As String = "ATR_AVISCOMMISSIONTRANSPARENCE"
    Public Const SPCPD_SPE_CDT_PRESCR As String = "SPCPD_SPE_CDT_PRESCR"
    Public Const PRIUCD_PRIX_UCD As String = "PRIUCD_PRIX_UCD"
    Public Const SPFOTX_SPE_FORME_TEXTE As String = "SPFOTX_SPE_FORME_TEXTE"
    Public Const SPTEN_SPECIALITE_TENEUR As String = "SPTEN_SPECIALITE_TENEUR"
    Public Const SYGSP_SYNONYME_GSP As String = "SYGSP_SYNONYME_GSP"
    Public Const PRE_PRESENTATION As String = "PRE_PRESENTATION"
    Public Const PREDISP_PRE_DISPENSATION As String = "PREDISP_PRE_DISPENSATION"
    Public Const PREUCD_COMMENT_DOSEUCD As String = "PREUCD_COMMENT_DOSEUCD"
    Public Const COCONT_COMPO_CONTENANT As String = "COCONT_COMPO_CONTENANT"
    Public Const PRECONT_PRE_CONTENANT As String = "PRECONT_PRE_CONTENANT"
    Public Const PREMAT_PRE_MATERIAU As String = "PREMAT_PRE_MATERIAU"
    Public Const PRECAR_PRESENTATION_CARACTCOMP As String = "PRECAR_PRESENTATION_CARACTCOMP"
    Public Const PRECEMB_PRE_CAREMBALLAGE As String = "PRECEMB_PRE_CAREMBALLAGE"
    Public Const PRETSS_PRESENTATION_TAUX As String = "PRETSS_PRESENTATION_TAUX"
    Public Const FORPRE_FORFAIT_PRE As String = "FORPRE_FORFAIT_PRE"
    Public Const PRIPRE_PRIX_PRESENTATION As String = "PRIPRE_PRIX_PRESENTATION"
    Public Const PRETSSH_PRE_TAUX_HOP As String = "PRETSSH_PRE_TAUX_HOP"
    Public Const PRESTP_PRE_STP As String = "PRESTP_PRE_STP"
    Public Const PRESTC_STATUTCOMP_PRESENT As String = "PRESTC_STATUTCOMP_PRESENT"
    Public Const PRESTR_STATUT_REMBOURST As String = "PRESTR_STATUT_REMBOURST"
    Public Const PRESTRTX_TEXTE_STAT_REMBOURST As String = "PRESTRTX_TEXTE_STAT_REMBOURST"
    Public Const PREPER_PRESENTATION_PERIO_CSV As String = "PREPER_PRESENTATION_PERIO_CSV"
    Public Const PERCS_PERIODE_COND_CSV As String = "PERCS_PERIODE_COND_CSV"
    Public Const PREDILI_LIEU_DISPENSAT As String = "PREDILI_LIEU_DISPENSAT"
    Public Const PREDICO_COMMENT_DISPENSAT As String = "PREDICO_COMMENT_DISPENSAT"
    Public Const PREDITX_TEXTE_DISPENSAT As String = "PREDITX_TEXTE_DISPENSAT"
    Public Const PRESMR_PRE_SMR_ATR As String = "PRESMR_PRE_SMR_ATR"
    Public Const PRECSVTX_TEXTE_CONSERV As String = "PRECSVTX_TEXTE_CONSERV"
    Public Const GSAC_PERE_SUBACT As String = "GSAC_PERE_SUBACT"
    Public Const FPRCL_SECPRECLIN As String = "FPRCL_SECPRECLIN"
    Public Const FPRCLCPH_FPRCL_CLPH As String = "FPRCLCPH_FPRCL_CLPH"
    Public Const GREF_GROUPE_SPECIALITE_REF As String = "GREF_GROUPE_SPECIALITE_REF"
    Public Const SPGREFR_GROUPE_SPE_REF As String = "SPGREFR_GROUPE_SPE_REF"
    Public Const PREGREF_PRE_GROUPE_REF As String = "PREGREF_PRE_GROUPE_REF"
    Public Const PREGREF_PRE_GROUPE_REF1 As String = "PREGREF_PRE_GROUPE_REF1"
    Public Const GREFTX_TEXTE_GROUPE_REF As String = "GREFTX_TEXTE_GROUPE_REF"
    Public Const SPGREFG_GROUPE_SPE_GENE As String = "SPGREFG_GROUPE_SPE_GENE"
    Public Const SYASAC_SYNONYMEANGLAIS_SAC As String = "SYASAC_SYNONYMEANGLAIS_SAC"
    Public Const SYFSAC_SYNONYMEFR_SUBACT As String = "SYFSAC_SYNONYMEFR_SUBACT"
    Public Const SACCAS_SUBACT_CAS As String = "SACCAS_SUBACT_CAS"
    Public Const ADSAC_AUTRE_DENOMINATION_SUBAC As String = "ADSAC_AUTRE_DENOMINATION_SUBAC"
    Public Const SACCCH_SUBACT_CLASSECH As String = "SACCCH_SUBACT_CLASSECH"
    Public Const SACCPH_SUBACT_CLASSEPH As String = "SACCPH_SUBACT_CLASSEPH"
    Public Const SACCATC_SUBACT_CLASSEATC As String = "SACCATC_SUBACT_CLASSEATC"

    Public Const FPOCPH_FPOSO_CLPH As String = "FPOCPH_FPOSO_CLPH"
    Public Const FPOCCH_FPOSO_CLCH As String = "FPOCCH_FPOSO_CLCH"
    Public Const FPOSAC_POSO_SUBACT = "FPOCCH_FPOSO_CLCH"
    Public Const FPOPR_FPOSO_PROD As String = "FPOPR_FPOSO_PROD"
    Public Const FPOCH_POSOCHOIX As String = "FPOCH_POSOCHOIX"
    Public Const FPOSP_POSO_SPE As String = "FPOSP_POSO_SPE"
    Public Const FPO_FICHEPOSO As String = "FPO_FICHEPOSO"
    Public Const FPOVO_FPOSO_VOIE As String = "FPOVO_FPOSO_VOIE"
    Public Const FPOTE_FPOSO_TERRAIN As String = "FPOTE_FPOSO_TERRAIN"
    Public Const IPO_INFOPOSO As String = "IPO_INFOPOSO"
    Public Const IPOCOTE_INFPO_COMMENT_TERRAIN As String = "IPOCOTE_INFPO_COMMENT_TERRAIN"
    Public Const IPOCOFQ_INFPO_COMMENT_FREQ As String = "IPOCOFQ_INFPO_COMMENT_FREQ"
    Public Const IPOCOD_INFPO_COMMENT_DUREE As String = "IPOCOD_INFPO_COMMENT_DUREE"

    Public Const FPOCOAD_FPOSO_COMMENT_ADAPT As String = "FPOCOAD_FPOSO_COMMENT_ADAPT"
    Public Const FPOCOSU_FPOSO_COMMENT_SURVEIL As String = "FPOCOSU_FPOSO_COMMENT_SURVEIL"
    Public Const FPOCOAU_FPOSO_COMMENT_AUTRE As String = "FPOCOAU_FPOSO_COMMENT_AUTRE"
    Public Const FPOBIB_REFERENCE_BIBLIO As String = "FPOBIB_REFERENCE_BIBLIO"
    Public Const IPOJ_INFOPOSO_JOURNALIERE As String = "IPOJ_INFOPOSO_JOURNALIERE"
    Public Const FPOUT_FPOSO_UTILTH As String = "FPOUT_FPOSO_UTILTH"
    Public Const FPOAFS_POSO_AFSSAPS As String = "FPOAFS_POSO_AFSSAPS"
    Public Const FPOCOUT_FPOSO_COMMENTUTILTH As String = "FPOCOUT_FPOSO_COMMENTUTILTH"
    Public Const SPAFS_SPECIALITE_AFSSAPS As String = "SPAFS_SPECIALITE_AFSSAPS"
    Public Const URL_ADRESSE As String = "URL_ADRESSE"
    Public Const IPODOSE_INFOPOSO As String = "IPODOSE_INFOPOSO"
    Public Const IPODUREE_INFOPOSO As String = "IPODUREE_INFOPOSO"

#End Region

#Region " LoadData "

    Public Function FillTableDictionnaire(ByVal strSSQL As String) As DataTable
        Return cn.MySelect(strSSQL)
    End Function

    Public Sub InitLkupCDF(ByRef lkup As DevExpress.XtraEditors.LookUpEdit, ByVal strTable As String, ByVal strSSQL As String, Optional ByVal DropDown As Boolean = False, Optional ByVal boolPredictive As Boolean = True, Optional ByVal boolFillLkup As Boolean = True)
        If boolPredictive Then
            lkup.Tag = New StructTxtProperty(strTable, Nothing, strSSQL)
        End If
        If boolFillLkup Then
            lkup.Properties.ValueMember = "code"
            lkup.Properties.DisplayMember = "libelle"
            lkup.Properties.DataSource = FillTableDictionnaire(strSSQL)
            Dim col As New DevExpress.XtraEditors.Controls.LookUpColumnInfo("libelle")
            lkup.Properties.Columns.Clear()
            lkup.Properties.Columns.Add(col)
        End If
        If lkup.Properties.Buttons.Count > 0 Then
            If Not DropDown Then
                lkup.Properties.Buttons(0).Visible = False
            Else
                lkup.Properties.Buttons(0).Visible = True
            End If
        End If
    End Sub

    Public Sub InitLkup(ByRef lkup As DevExpress.XtraEditors.LookUpEdit, ByVal strTable As String, ByVal strSSQL As String, Optional ByVal DropDown As Boolean = False, Optional ByVal boolPredictive As Boolean = True, Optional ByVal boolFillLkup As Boolean = True, Optional ByVal boolShowCode As Boolean = False, Optional ByRef lkup2 As DevExpress.XtraEditors.LookUpEdit = Nothing, Optional ByRef lkup3 As DevExpress.XtraEditors.LookUpEdit = Nothing, Optional ByRef lkup4 As DevExpress.XtraEditors.LookUpEdit = Nothing, Optional ByVal boolAfficheColNum As Boolean = False)
        lkup.Properties.NullText = ""
        If boolPredictive Then
            lkup.Tag = New StructTxtProperty(strTable, Nothing, strSSQL, , , , boolAfficheColNum)
        End If
        If boolFillLkup Then
            lkup.Properties.ValueMember = "code"
            If Not boolShowCode Then
                lkup.Properties.DisplayMember = "libelle"
            Else
                lkup.Properties.DisplayMember = "code"
            End If
            lkup.Properties.DataSource = cn.MySelect(strSSQL) 'FillTableDictionnaire(strSSQL)
            Dim col As New DevExpress.XtraEditors.Controls.LookUpColumnInfo("libelle")
            lkup.Properties.Columns.Clear()
            lkup.Properties.Columns.Add(col)
        End If
        If lkup.Properties.Buttons.Count > 0 Then
            If Not DropDown Then
                lkup.Properties.Buttons(0).Visible = False
                lkup.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
            Else
                lkup.Properties.Buttons(0).Visible = True
                lkup.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
            End If
        Else
            If Not DropDown Then
                lkup.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
            Else
                lkup.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
            End If
        End If
        '----------------------------------------------------------------
        '----------------------------------------------------------------
        If lkup2 IsNot Nothing Then
            lkup2.Properties.NullText = ""
            If boolPredictive Then
                lkup2.Tag = New StructTxtProperty(strTable, Nothing, strSSQL)
            End If
            If boolFillLkup Then
                lkup2.Properties.ValueMember = "code"
                If Not boolShowCode Then
                    lkup2.Properties.DisplayMember = "libelle"
                Else
                    lkup2.Properties.DisplayMember = "code"
                End If
                lkup2.Properties.DataSource = lkup2.Properties.DataSource.copy
                Dim col As New DevExpress.XtraEditors.Controls.LookUpColumnInfo("libelle")
                lkup2.Properties.Columns.Clear()
                lkup2.Properties.Columns.Add(col)
            End If
            If lkup2.Properties.Buttons.Count > 0 Then
                If Not DropDown Then
                    lkup2.Properties.Buttons(0).Visible = False
                    lkup2.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
                Else
                    lkup2.Properties.Buttons(0).Visible = True
                    lkup2.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
                End If
            Else
                If Not DropDown Then
                    lkup2.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
                Else
                    lkup2.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
                End If
            End If
        End If
    End Sub

    Public Sub InitLkup(ByRef lkup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit, ByVal strTable As String, ByVal strSSQL As String, Optional ByVal DropDown As Boolean = False, Optional ByVal boolPredictive As Boolean = True, Optional ByVal boolFillLkup As Boolean = True, Optional ByVal boolAfficheCode As Boolean = False, Optional ByVal boolOnlyFirst As Boolean = False, Optional ByRef lkup2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit = Nothing, Optional ByVal Declinaison As ClsDeclinaison = Nothing)
        Dim dt_ As New DataTable

        lkup.NullText = ""
        If boolPredictive Then
            lkup.Tag = New StructTxtProperty(strTable, Declinaison, strSSQL, , , boolOnlyFirst)
        End If
        If boolFillLkup Then
            lkup.ValueMember = "code"
            If Not boolAfficheCode Then
                lkup.DisplayMember = "libelle"
            Else
                lkup.DisplayMember = "code"
            End If
            dt_ = FillTableDictionnaire(strSSQL)
            '-----------------------------------------
            ' Filtre sur les type parent 
            ' disable <> 1 
            '-----------------------------------------
            If LCase(strSSQL).IndexOf("as disable") > 0 Then
                Dim dv As New DataView
                dv = dt_.DefaultView
                dv.RowFilter = " disable <> 1 "
            End If
            '-----------------------------------------
            '-----------------------------------------
            lkup.DataSource = dt_
            If Not boolAfficheCode Then
                Dim col As New DevExpress.XtraEditors.Controls.LookUpColumnInfo("libelle")
                col.Caption = "Libellé"
                lkup.Columns.Clear()
                lkup.Columns.Add(col)
            Else
                Dim col As New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code")
                col.Caption = "Code"
                lkup.Columns.Clear()
                lkup.Columns.Add(col)
            End If
            If Not DropDown Then
                lkup.Buttons(0).Visible = False
                lkup.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
            Else
                lkup.Buttons(0).Visible = True
                lkup.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
                lkup.DropDownRows = 20
            End If
        End If
        '-----------------------------------------------------
        '-----------------------------------------------------
        If lkup2 IsNot Nothing Then
            lkup2.NullText = ""
            If boolPredictive Then
                lkup2.Tag = New StructTxtProperty(strTable, Nothing, strSSQL, , , boolOnlyFirst)
            End If
            If boolFillLkup Then
                lkup2.ValueMember = "code"
                If Not boolAfficheCode Then
                    lkup2.DisplayMember = "libelle"
                Else
                    lkup2.DisplayMember = "code"
                End If
                lkup2.DataSource = dt_  'dt_.Copy
                If Not boolAfficheCode Then
                    Dim col As New DevExpress.XtraEditors.Controls.LookUpColumnInfo("libelle")
                    col.Caption = "Libellé"
                    lkup2.Columns.Clear()
                    lkup2.Columns.Add(col)
                Else
                    Dim col As New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code")
                    col.Caption = "Code"
                    lkup2.Columns.Clear()
                    lkup2.Columns.Add(col)
                End If
                If Not DropDown Then
                    lkup2.Buttons(0).Visible = False
                    lkup2.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
                Else
                    lkup2.Buttons(0).Visible = True
                    lkup2.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
                    lkup2.DropDownRows = 20
                End If
            End If
        End If
    End Sub

    Public Sub InitLkupCodeLibelle(ByRef lkup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit, ByVal strTable As String, ByVal strSSQL As String, Optional ByVal DropDown As Boolean = False, Optional ByVal boolPredictive As Boolean = True, Optional ByVal boolFillLkup As Boolean = True, Optional ByVal boolAfficheCode As Boolean = False, Optional ByRef lkup2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit = Nothing, Optional ByVal Declinaison As ClsDeclinaison = Nothing)
        Dim dt_ As New DataTable

        lkup.NullText = ""
        If boolPredictive Then
            lkup.Tag = New StructTxtProperty(strTable, Declinaison, strSSQL)
        End If
        If boolFillLkup Then
            lkup.ValueMember = "code"
            lkup.DisplayMember = "code"
            dt_ = FillTableDictionnaire(strSSQL)
            '-----------------------------------------
            ' Filtre sur les type parent 
            ' disable <> 1 
            '-----------------------------------------
            If LCase(strSSQL).IndexOf("as disable") > 0 Then
                Dim dv As New DataView
                dv = dt_.DefaultView
                dv.RowFilter = " disable <> 1 "
            End If
            '-----------------------------------------
            '-----------------------------------------
            lkup.DataSource = dt_
         
            Dim col As New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code")
            col.Caption = "Code"
            lkup.Columns.Clear()
            lkup.Columns.Add(col)

            lkup.Buttons(0).Visible = False
            lkup.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
        End If
        '-----------------------------------------------------
        '-----------------------------------------------------
        If lkup2 IsNot Nothing Then
            lkup2.NullText = ""
            If boolPredictive Then
                lkup2.Tag = New StructTxtProperty(strTable, Nothing, strSSQL)
            End If
            If boolFillLkup Then
                lkup2.ValueMember = "code"
                lkup2.DisplayMember = "libelle"
                lkup2.DataSource = dt_  'dt_.Copy

                Dim col As New DevExpress.XtraEditors.Controls.LookUpColumnInfo("libelle")
                col.Caption = "Libellé"
                lkup2.Columns.Clear()
                lkup2.Columns.Add(col)
                If Not DropDown Then
                    lkup2.Buttons(0).Visible = False
                    lkup2.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
                Else
                    lkup2.Buttons(0).Visible = True
                    lkup2.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
                    lkup2.DropDownRows = 20
                End If
            End If
        End If
    End Sub
#End Region

#Region " TestSQL  "

    Public Function FieldExist(ByVal strTable As String, ByVal ctrl As Control, Optional ByVal ctrlMyCode As Control = Nothing, Optional ByVal strSuplementSQL As String = "") As Boolean
        Dim strField As String = ctrl.DataBindings("EditValue").BindingMemberInfo.BindingField()
        Dim strCode As String = ctrl.Text
        Dim strSSQL As String = ""
        Dim strFieldCode As String = ""
        Dim strCodeCode As String = ""
        Dim strSSQL1 As String = ""

        If ctrlMyCode IsNot Nothing Then
            strFieldCode = ctrlMyCode.DataBindings("EditValue").BindingMemberInfo.BindingField()
            strCodeCode = ctrlMyCode.Text
        End If
        strSSQL = "Select * from THERIAQUE." & strTable & " where lower(" & strField & ") = " & LCase(cn.SQLText(strCode))
        If ctrlMyCode IsNot Nothing Then
            strSSQL &= " AND Lower(" & strFieldCode & ") <> " & LCase(cn.SQLText(strCodeCode))
        End If
        If strSuplementSQL.Trim <> "" Then
            strSSQL &= " AND " & strSuplementSQL
        End If
        Dim dt As DataTable = cn.MySelect(strSSQL)
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function FieldExist(ByVal strTable As String, ByVal strField As String, ByVal strCode As String, Optional ByVal ctrlMyCode As Control = Nothing, Optional ByVal strSuplementSQL As String = "") As Boolean
        Dim strSSQL As String = ""
        Dim strFieldCode As String = ""
        Dim strCodeCode As String = ""
        Dim strSSQL1 As String = ""

        If strCode Is "" Then
            Return False
        End If

        If ctrlMyCode IsNot Nothing Then
            strFieldCode = ctrlMyCode.DataBindings("EditValue").BindingMemberInfo.BindingField()
            strCodeCode = ctrlMyCode.Text
        End If

        strSSQL = "Select * from THERIAQUE." & strTable & " where lower(" & strField & ") = " & LCase(cn.SQLText(strCode))
        If ctrlMyCode IsNot Nothing Then
            strSSQL &= " AND Lower(" & strFieldCode & ") <> " & LCase(cn.SQLText(strCodeCode))
        End If
        If strSuplementSQL.Trim <> "" Then
            strSSQL &= " AND " & strSuplementSQL
        End If
        Dim dt As DataTable = cn.MySelect(strSSQL)
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function FieldExist(ByVal GV As DevExpress.XtraGrid.Views.Grid.GridView, ByVal Col As DevExpress.XtraGrid.Columns.GridColumn, ByVal objValeur As Object) As Boolean
        Dim iCount As Integer
        For iCount = 0 To GV.RowCount - 1
            If GV.GetRowCellValue(iCount, Col) IsNot DBNull.Value Then
                If GV.GetRowCellValue(iCount, Col) = objValeur And Not GV.IsRowSelected(iCount) Then
                    Return True
                End If
            End If
        Next
        Return False
    End Function

    Public Function FieldExistRO(ByVal GV As DevExpress.XtraGrid.Views.Grid.GridView, ByVal Col As DevExpress.XtraGrid.Columns.GridColumn, ByVal objValeur As Object) As Boolean
        Dim iCount As Integer
        For iCount = 0 To GV.RowCount - 1
            If GV.GetRowCellValue(iCount, Col) = objValeur Then
                Return True
            End If
        Next
        Return False
    End Function
    Public Function FieldExistCS(ByVal GV As DevExpress.XtraGrid.Views.Grid.GridView, ByVal Col As DevExpress.XtraGrid.Columns.GridColumn, ByVal objValeur As Object) As Boolean
        Dim iCount As Integer
        For iCount = 0 To GV.RowCount - 1
            If UCase(GV.GetRowCellValue(iCount, Col)) = UCase(objValeur) And Not GV.IsRowSelected(iCount) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function TestFK_Used(ByVal strTable As String, ByVal strField As String, ByVal strValue As String) As Boolean
        Dim strSSQL As String = ""
        Dim strSSQL2 As String = ""
        Dim i As Integer = -1
        Dim dt As New DataTable
        Dim dt2 As New DataTable

        strSSQL = " SELECT "
        strSSQL &= " R.NAME AS TABLE_PERE, "
        strSSQL &= " C.NAME AS CLE_PERE,"
        strSSQL &= " S.NAME AS TABLE_FILS, "
        strSSQL &= " L.NAME AS CLE_FILS"

        strSSQL &= " FROM"
        strSSQL &= " sysobjects S JOIN sysforeignkeys K ON K.fkeyid = S.id"
        strSSQL &= " JOIN sysobjects R ON R.id = K.rkeyid "
        strSSQL &= " JOIN syscolumns C ON C.id = R.id AND C.colid = K.rkey JOIN "
        strSSQL &= " syscolumns L ON L.id = S.id AND L.colid = K.fkey"

        strSSQL &= " WHERE"
        strSSQL &= " R.NAME = " & cn.SQLText(strTable) & " AND "
        strSSQL &= " C.NAME = " & cn.SQLText(strField)
        'cette ligne au dessous est Ajoutee recemment pour pouvoir supprimer une classe ATC lie à la table ATCCMP_CATC_MARCHEPUBLIC
        strSSQL &= " AND S.name <> 'ATCCMP_CATC_MARCHEPUBLIC' "

        dt = cn.MySelect(strSSQL)

        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1
                If strSSQL2 <> "" Then
                    strSSQL2 &= " Union "
                End If
                strSSQL2 &= " SELECT " & dt.Rows(i)("CLE_FILS") & " as code From THERIAQUE." & dt.Rows(i)("TABLE_FILS") & " Where " & dt.Rows(i)("CLE_FILS") & " = " & cn.SQLText(strValue)
            Next
        End If
        dt2 = cn.MySelect(strSSQL2)
        If dt2.Rows.Count > 0 Then
            Process_Message(strIMP_SUPPRIMER, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Else
            Return False
        End If
    End Function


    Public Function TestFK_Used(ByVal strTable As String, ByVal strField As String, ByVal intValue As Integer) As Boolean
        Dim strSSQL As String = ""
        Dim strSSQL2 As String = ""
        Dim i As Integer = -1
        Dim dt As New DataTable
        Dim dt2 As New DataTable

        strSSQL = " SELECT "
        strSSQL &= " R.NAME AS TABLE_PERE, "
        strSSQL &= " C.NAME AS CLE_PERE,"
        strSSQL &= " S.NAME AS TABLE_FILS, "
        strSSQL &= " L.NAME AS CLE_FILS"

        strSSQL &= " FROM"
        strSSQL &= " sysobjects S JOIN sysforeignkeys K ON K.fkeyid = S.id"
        strSSQL &= " JOIN sysobjects R ON R.id = K.rkeyid "
        strSSQL &= " JOIN syscolumns C ON C.id = R.id AND C.colid = K.rkey JOIN "
        strSSQL &= " syscolumns L ON L.id = S.id AND L.colid = K.fkey"

        strSSQL &= " WHERE"
        strSSQL &= " R.NAME = " & cn.SQLText(strTable) & " AND "
        strSSQL &= " C.NAME = " & cn.SQLText(strField)
        'cette ligne au dessous est Ajoutee recemment pour pouvoir supprimer une classe ATC lie à la table ATCCMP_CATC_MARCHEPUBLIC
        strSSQL &= " AND S.name <> 'ATCCMP_CATC_MARCHEPUBLIC' "

        dt = cn.MySelect(strSSQL)

        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1
                If strSSQL2 <> "" Then
                    strSSQL2 &= " Union "
                End If
                strSSQL2 &= " SELECT " & dt.Rows(i)("CLE_FILS") & " as code From THERIAQUE." & dt.Rows(i)("TABLE_FILS") & " Where " & dt.Rows(i)("CLE_FILS") & " = " & intValue
            Next
        End If
        If strSSQL2 <> "" Then
            dt2 = cn.MySelect(strSSQL2)
            If dt2.Rows.Count > 0 Then
                Process_Message(strIMP_SUPPRIMER, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function TestUsedCodif(ByVal sNumero As String, ByVal sCode As String) As Boolean
        Dim sSQL As String = ""
        Dim dt As New DataTable
        Select Case sNumero
            Case "01"
                'Caractéristiques complémentaire du conditionnement
                sSQL = " SELECT PRECAR_CDF_CODE_CACDT_FK_PK as code FROM THERIAQUE.PRECAR_PRESENTATION_CARACTCOMP WHERE PRECAR_CDF_CODE_CACDT_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT PRECEMB_CDF_CAREMB_CODE_FK_PK as code FROM THERIAQUE.PRECEMB_PRE_CAREMBALLAGE WHERE PRECEMB_CDF_CAREMB_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "02"
                'Complément de forme pharmaceutique
                sSQL = " SELECT SPFOCFO_SP_CODE_FK_PK FROM THERIAQUE.SPFOCFO_SPE_FORME_COMPFORME WHERE SPFOCFO_CDF_CFO_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "03"
                'Condition de conservation
                sSQL = " SELECT PERCS_NUM_CODE_PK FROM THERIAQUE.PERCS_PERIODE_COND_CS WHERE PERCS_CDF_CSV_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "04"
                'Contenant du conditionnement'
                sSQL = " SELECT PRE_NATUCD_CDF_CODE_FK FROM THERIAQUE.PRE_PRESENTATION WHERE PRE_NATUCD_CDF_CODE_FK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT IPOJ_NATUCD_CDF_CODE_FK FROM THERIAQUE.IPOJ_INFOPOSO_JOURNALIERE WHERE IPOJ_NATUCD_CDF_CODE_FK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "06"
                'Forme pharmaceutique'
                sSQL = " SELECT PRE_NATUCD_CDF_CODE_FK FROM THERIAQUE.PRE_PRESENTATION WHERE PRE_NATUCD_CDF_CODE_FK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT IPOJ_NATUCD_CDF_CODE_FK FROM THERIAQUE.IPOJ_INFOPOSO_JOURNALIERE WHERE IPOJ_NATUCD_CDF_CODE_FK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT SPFO_CDF_FO_CODE_FK_PK FROM THERIAQUE.SPFO_SPECIALITE_FORME WHERE SPFO_CDF_FO_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "07"
                'Laboratoire
                sSQL = " SELECT SPLAB_CDF_LAB_CODE_FK_PK FROM THERIAQUE.SPLAB_SPECIALITE_LABO WHERE SPLAB_CDF_LAB_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                End If
                'Laboratoire exploitant
                sSQL = " SELECT SPLABEX_CDF_LAB_CODE_FK_PK FROM THERIAQUE.SPLABEX_SPE_LABO_EXPLOITANT WHERE SPLABEX_CDF_LAB_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                End If
                Return False
            Case "08"
                'Liste'
                sSQL = " SELECT SP_CDF_LI_CODE_FK FROM THERIAQUE.SP_SPECIALITE WHERE SP_CDF_LI_CODE_FK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "09"
                'Matériau du conditionnement
                sSQL = " SELECT PREMAT_CDF_MACDT_CODE_FK_PK FROM THERIAQUE.PREMAT_PRE_MATERIAU WHERE PREMAT_CDF_MACDT_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "10"
                'Nature substance auxiliaire
                sSQL = " SELECT SAUNAT_CDF_NASAU_CODE_FK_PK FROM THERIAQUE.SAUNAT_SUBAUX_NATURE WHERE SAUNAT_CDF_NASAU_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "11"
                'Origine du nom de la substance
                sSQL = " SELECT SAC_CDF_ORN_CODE_FK FROM THERIAQUE.SAC_SUBACTIVE WHERE SAC_CDF_ORN_CODE_FK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "12"
                'Présentation unitaire
                sSQL = " SELECT PRE_CDF_PU_CODE_FK FROM THERIAQUE.PRE_PRESENTATION WHERE PRE_CDF_PU_CODE_FK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "13"
                'Réservé hôpitaux
                sSQL = " SELECT PRE_CDF_PU_CODE_FK FROM THERIAQUE.PRE_PRESENTATION WHERE PRE_CDF_PU_CODE_FK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "14"
                'Statut de la présentation
                sSQL = " SELECT SPCPD_CDF_STP_CODE_FK_PK FROM THERIAQUE.SPCPD_SPE_CDT_PRESCR WHERE SPCPD_CDF_STP_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT PRESTP_CDF_STP_CODE_FK_PK FROM THERIAQUE.PRESTP_PRE_STP WHERE PRESTP_CDF_STP_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT PRESTC_CDF_STCOMP_CODE_FK_PK FROM THERIAQUE.PRESTC_STATUTCOMP_PRESENT WHERE PRESTC_CDF_STCOMP_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT PRESTR_CDF_STR_CODE_FK_PK FROM THERIAQUE.PRESTR_STATUT_REMBOURST WHERE PRESTR_CDF_STR_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT PREDILI_CDF_LIEU_CODE_FK_PK  FROM THERIAQUE.PREDILI_LIEU_DISPENSAT WHERE PREDILI_CDF_LIEU_CODE_FK_PK  = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "15"
                'Statut du laboratoire
                sSQL = " SELECT SP_CDF_SLAB_CODE_FK FROM THERIAQUE.SP_SPECIALITE WHERE SP_CDF_SLAB_CODE_FK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "17"
                'Taux de remboursement SS
                sSQL = " SELECT PRETSS_CDF_TSS_CODE_FK_PK FROM THERIAQUE.PRETSS_PRESENTATION_TAUX WHERE PRETSS_CDF_TSS_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT PRETSSH_CDF_TSS_CODE_FK_PK FROM THERIAQUE.PRETSSH_PRE_TAUX_HOP WHERE PRETSSH_CDF_TSS_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FINTSS_CDF_TSS_CODE_FK FROM THERIAQUE.FINTSS_INDICATION_TAUXSECU WHERE FINTSS_CDF_TSS_CODE_FK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "18"
                'Voie d'administration
                sSQL = " SELECT SPVO_CDF_VO_CODE_FK_PK FROM THERIAQUE.SPVO_SPECIALITE_VOIE WHERE SPVO_CDF_VO_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT ATCDDD_CDF_VO_CODE_FK_PK  FROM THERIAQUE.ATCDDD_DOSE_USUELLE_JOUR WHERE ATCDDD_CDF_VO_CODE_FK_PK  = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT SPDDD_ATCDDD_CDF_VO_CODE_FK_PK FROM THERIAQUE.SPDDD_DOSE_USUELLE_JOUR  WHERE SPDDD_ATCDDD_CDF_VO_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT SAUVO_CDF_VOIE_CODE_FK_PK FROM THERIAQUE.SAUVO_SUBAUXVOIE_SUBAUX  WHERE SAUVO_CDF_VOIE_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FPOVO_CDF_VO_CODE_FK_PK FROM THERIAQUE.FPOVO_FPOSO_VOIE  WHERE FPOVO_CDF_VO_CODE_FK_PK  = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FRECVO_CDF_VO_CODE_FK_PK FROM THERIAQUE.FRECVO_RECONSADM_VOIE  WHERE FRECVO_CDF_VO_CODE_FK_PK  = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "19"
                'Unité de dosage substance
                sSQL = " SELECT COTEN_CDF_UD_CODE_FK FROM THERIAQUE.COTEN_COMPO_TENEUR WHERE COTEN_CDF_UD_CODE_FK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT COTEN_CDF_UD_EQUIV_CODE_FK FROM THERIAQUE.COTEN_COMPO_TENEUR WHERE COTEN_CDF_UD_EQUIV_CODE_FK  = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT ATCDDD_CDF_UD_CODE_FK_PK FROM THERIAQUE.ATCDDD_DOSE_USUELLE_JOUR WHERE ATCDDD_CDF_UD_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT SPDDD_ATCDDD_CDF_UD_CODE_FK_PK FROM THERIAQUE.SPDDD_DOSE_USUELLE_JOUR WHERE SPDDD_ATCDDD_CDF_UD_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT PREDISP_CDF_UD_CODE_FK FROM THERIAQUE.PREDISP_PRE_DISPENSATION WHERE PREDISP_CDF_UD_CODE_FK   = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FET_CDF_UDHS_CODE_FK FROM THERIAQUE.FET_FICHEETIOLOGIE WHERE FET_CDF_UDHS_CODE_FK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FET_CDF_UDIS_CODE_FK  FROM THERIAQUE.FET_FICHEETIOLOGIE WHERE FET_CDF_UDIS_CODE_FK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FET_CDF_UDMS_CODE_FK  FROM THERIAQUE.FET_FICHEETIOLOGIE WHERE FET_CDF_UDMS_CODE_FK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FET_CDF_UDRE_CODE_FK  FROM THERIAQUE.FET_FICHEETIOLOGIE WHERE FET_CDF_UDRE_CODE_FK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FGA_CDF_UC_CODE_FK   FROM THERIAQUE.FGA_FICHEGRAL WHERE FGA_CDF_UC_CODE_FK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "20"
                'Unité de prise par contenant
                sSQL = " SELECT PRE_CDF_UP_CODE_FK   FROM THERIAQUE.PRE_PRESENTATION WHERE PRE_CDF_UP_CODE_FK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "21"
                'Unité de contenance
                sSQL = " SELECT PRECONT_CDF_COCE_CODE_FK FROM THERIAQUE.PRECONT_PRE_CONTENANT WHERE PRECONT_CDF_COCE_CODE_FK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT PRECONT_CDF_VOLCONT_CODE_FK FROM THERIAQUE.PRECONT_PRE_CONTENANT WHERE PRECONT_CDF_VOLCONT_CODE_FK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "22"
                'Galénique
                sSQL = " SELECT COMPO_CDF_GAL_CODE_FK FROM THERIAQUE.COMPO_COMPOSITION WHERE COMPO_CDF_GAL_CODE_FK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT COCONT_CDF_GAL_CODE_FK FROM THERIAQUE.COCONT_COMPO_CONTENANT WHERE COCONT_CDF_GAL_CODE_FK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "23"
                'Amélioration Service Médical Rendu
                sSQL = " SELECT ATRASMR_CDF_ASMR_CODE_FK_PK FROM THERIAQUE.ATRASMR_AVISCOMTRANS_ASMR WHERE ATRASMR_CDF_ASMR_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "24"
                'Teneur
                sSQL = " SELECT COTEN_CDF_TEN_CODE_FK_PK FROM THERIAQUE.COTEN_COMPO_TENEUR WHERE COTEN_CDF_TEN_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "25"
                'Document
                sSQL = " SELECT SPAFS_CDF_CODE_DOC_FK_PK FROM THERIAQUE.SPAFS_SPECIALITE_AFSSAPS WHERE SPAFS_CDF_CODE_DOC_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT SAUAFS_CDF_DOCUMENT_FK_PK FROM THERIAQUE.SAUAFS_SAU_AFS WHERE SAUAFS_CDF_DOCUMENT_FK_PK  = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT SAU_CDF_DOC_CODE_FK FROM THERIAQUE.SAU_SUBAUXILIAIRE WHERE SAU_CDF_DOC_CODE_FK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FETAFS_CDF_DOCUMENT_FK_PK FROM THERIAQUE.FETAFS_FET_AFSSAPS WHERE FETAFS_CDF_DOCUMENT_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FPHCOAFS_CDF_DOCUMENT_FK_PK  FROM THERIAQUE.FPHCOAFS_FPHCO_AFSSAPS WHERE FPHCOAFS_CDF_DOCUMENT_FK_PK    = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FPRCLAFS_CDF_DOCUMENT_FK_PK FROM THERIAQUE.FPRCLAFS_FPRCL_AFSSAPS WHERE FPRCLAFS_CDF_DOCUMENT_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FINAFS_CDF_DOCUMENT_FK_PK  FROM THERIAQUE.FINAFS_FIN_AFSSAPS WHERE FINAFS_CDF_DOCUMENT_FK_PK  = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FPOAFS_CDF_DOCUMENT_FK_PK  FROM THERIAQUE.FPOAFS_POSO_AFSSAPS WHERE FPOAFS_CDF_DOCUMENT_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FRECAFS_CDF_DOCUMENT_FK_PK FROM THERIAQUE.FRECAFS_FREC_AFSSAPS WHERE FRECAFS_CDF_DOCUMENT_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FCPMAFS_CDF_DOCUMENT_FK_PK FROM THERIAQUE.FCPMAFS_CIPEMG_AFSSAPS WHERE FCPMAFS_CDF_DOCUMENT_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FCPTAFS_CDF_DOCUMENT_FK_PK FROM THERIAQUE.FCPTAFS_CIPEMG_AFSSAPS WHERE FCPTAFS_CDF_DOCUMENT_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FIRCPAFS_CDF_DOCUMENT_FK_PK FROM THERIAQUE.FIRCPAFS_FIRCP_AFSSAPS WHERE FIRCPAFS_CDF_DOCUMENT_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FGAAFS_CDF_DOCUMENT_FK_PK FROM THERIAQUE.FGAAFS_FGA_AFSSAPS WHERE FGAAFS_CDF_DOCUMENT_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FCOAFS_CDF_DOCUMENT_FK_PK FROM THERIAQUE.FCOAFS_FCO_AFSSAPS WHERE FCOAFS_CDF_DOCUMENT_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FEIAFS_CDF_DOCUMENT_FK_PK FROM THERIAQUE.FEIAFS_EFFETIND_AFSSAPS WHERE FEIAFS_CDF_DOCUMENT_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "26"
                'Info Complémentaire sur forme pharmaceutique
                sSQL = " SELECT SPFOCPI_CDF_CPI_CODE_FK_PK FROM THERIAQUE.SPFOCPI_SPE_FORME_COMPINFO WHERE SPFOCPI_CDF_CPI_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "27"
                'Service Médical Rendu
                sSQL = " SELECT PRETSS_CDF_TSS_CODE_FK_PK FROM THERIAQUE.PRETSS_PRESENTATION_TAUX WHERE PRETSS_CDF_TSS_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT PRETSSH_CDF_TSS_CODE_FK_PK FROM THERIAQUE.PRETSSH_PRE_TAUX_HOP WHERE PRETSSH_CDF_TSS_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FINTSS_CDF_TSS_CODE_FK FROM THERIAQUE.FINTSS_INDICATION_TAUXSECU WHERE FINTSS_CDF_TSS_CODE_FK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "28"
                'Nature de vecteur
                sSQL = " SELECT SAUNAV_CDF_NAV_CODE_FK_PK FROM THERIAQUE.SAUNAV_SUBAUX_NATURE_VECT WHERE SAUNAV_CDF_NAV_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "29"
                'Commentaire dispensation
                sSQL = " SELECT PREDICO_CDF_COM_CODE_FK_PK FROM THERIAQUE.PREDICO_COMMENT_DISPENSAT WHERE PREDICO_CDF_COM_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "30"
                'Type texte critère de choix
                sSQL = " SELECT CHTIT_CDF_TIT_CODE_FK_PK FROM THERIAQUE.CHTIT_CH_TITRE2 WHERE CHTIT_CDF_TIT_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "31"
                'Commentaire dose totale UCD
                sSQL = " SELECT PREUCD_CDF_COMUCD_CODE_FK_PK FROM THERIAQUE.PREUCD_COMMENT_DOSEUCD WHERE PREUCD_CDF_COMUCD_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
                'Case "PA"
                sSQL = " SELECT IPOJ_DONANTH_CDF_CODE_FK FROM THERIAQUE.IPOJ_INFOPOSO_JOURNALIERE WHERE IPOJ_DONANTH_CDF_CODE_FK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "PC"
                'Commentaires
                sSQL = " SELECT FPOCOUT_CDF_COUT_CODE_FK_PK FROM THERIAQUE.FPOCOUT_FPOSO_COMMENTUTILTH WHERE FPOCOUT_CDF_COUT_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT IPOCOTE_CDF_COTE_CODE_FK_PK FROM THERIAQUE.IPOCOTE_INFPO_COMMENT_TERRAIN WHERE IPOCOTE_CDF_COTE_CODE_FK_PK  = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT IPOCOFQ_CDF_COFQ_CODE_FK_PK FROM THERIAQUE.IPOCOFQ_INFPO_COMMENT_FREQ WHERE IPOCOFQ_CDF_COFQ_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT IPOCOD_CDF_COD_CODE_FK_PK FROM THERIAQUE.IPOCOD_INFPO_COMMENT_DUREE WHERE IPOCOD_CDF_COD_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FPOCOAD_CDF_COAD_CODE_FK_PK FROM THERIAQUE.FPOCOAD_FPOSO_COMMENT_ADAPT WHERE FPOCOAD_CDF_COAD_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FPOCOSU_CDF_COSU_CODE_FK_PK FROM THERIAQUE.FPOCOSU_FPOSO_COMMENT_SURVEIL WHERE FPOCOSU_CDF_COSU_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FPOCOAU_CDF_COAU_CODE_FK_PK FROM THERIAQUE.FPOCOAU_FPOSO_COMMENT_AUTRE WHERE FPOCOAU_CDF_COAU_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "PF"
                'Fréquence
                sSQL = " SELECT IPO_CDF_FREQMIN_CODE_FK FROM THERIAQUE.IPO_INFOPOSO WHERE IPO_CDF_FREQMIN_CODE_FK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT IPO_CDF_FREQMAX_CODE_FK FROM THERIAQUE.IPO_INFOPOSO WHERE IPO_CDF_FREQMAX_CODE_FK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "PN"
                'Nature de dose
                sSQL = " SELECT IPOJ_CDF_NAPO_CODE_FK FROM THERIAQUE.IPOJ_INFOPOSO_JOURNALIERE WHERE IPOJ_CDF_NAPO_CODE_FK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT IPO_CDF_NAPO_CODE_FK FROM THERIAQUE.IPO_INFOPOSO WHERE IPO_CDF_NAPO_CODE_FK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "PP"
                'Unité de prise
                sSQL = " SELECT IPO_CDF_UNPO_CODE_FK FROM THERIAQUE.IPO_INFOPOSO WHERE IPO_CDF_UNPO_CODE_FK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "PT"
                'Terrain
                sSQL = " SELECT FPOTE_CDF_TEPO_CODE_FK_PK FROM THERIAQUE.FPOTE_FPOSO_TERRAIN WHERE FPOTE_CDF_TEPO_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "PU"
                'Unité de Temps
                sSQL = " SELECT IPO_CDF_UTMIN_CODE_FK FROM THERIAQUE.IPO_INFOPOSO WHERE IPO_CDF_UTMIN_CODE_FK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT IPO_CDF_UTMAX_CODE_FK FROM THERIAQUE.IPO_INFOPOSO WHERE IPO_CDF_UTMAX_CODE_FK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "NA"
                'Agent/Etiologie
                sSQL = " SELECT FETHS_CDF_ETIN_CODE_FK_PK FROM THERIAQUE.FETHS_ETIOLOGIE_HABITU_SENSIB WHERE FETHS_CDF_ETIN_CODE_FK_PK  = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FETIS_CDF_ETIN_CODE_FK_PK FROM THERIAQUE.FETIS_ETIOLOGIE_INCONST_SENSIB WHERE FETIS_CDF_ETIN_CODE_FK_PK  = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FETMS_CDF_ETIN_CODE_FK_PK FROM THERIAQUE.FETMS_ETIOLOGIE_MODEREM_SENSIB WHERE FETMS_CDF_ETIN_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FETRE_CDF_ETIN_CODE_FK_PK FROM THERIAQUE.FETRE_ETIOLOGIE_RESISTANTES WHERE FETRE_CDF_ETIN_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FINET_CDF_ETIN_CODE_FK_PK FROM THERIAQUE.FINET_FINDETIOL WHERE FINET_CDF_ETIN_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "PK"
                'Commentaires
                sSQL = " SELECT FPHCOCOM_CDF_COM_CODE_FK_PK FROM THERIAQUE.FPHCOCOM_FPHCO_COM WHERE FPHCOCOM_CDF_COM_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "SC"
                'Commentaires
                sSQL = " SELECT FPRCLCOM_CDF_CODE_FK_PK FROM THERIAQUE.FPRCLCOM_FPRCL_COM WHERE FPRCLCOM_CDF_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "NC"
                'Commentaires
                sSQL = " SELECT FETCHS_CDF_COIN_CODE_FK_PK FROM THERIAQUE.FETCHS_COMMENT_HABITU_SENSIBLE WHERE FETCHS_CDF_COIN_CODE_FK_PK   = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FETCIS_CDF_COIN_CODE_FK_PK FROM THERIAQUE.FETCIS_COMMENT_INCONS_SENSIBLE WHERE FETCIS_CDF_COIN_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FETCMS_CDF_COIN_CODE_FK_PK  FROM THERIAQUE.FETCMS_COMMENT_MODERE_SENSIBLE WHERE FETCMS_CDF_COIN_CODE_FK_PK  = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FETCRE_CDF_COIN_CODE_FK_PK  FROM THERIAQUE.FETCRE_COMMENT_RESISTANTE WHERE FETCRE_CDF_COIN_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FINCON_CDF_COIN_CODE_FK_PK FROM THERIAQUE.FINCON_FINDCOMMENT_NATURE WHERE FINCON_CDF_COIN_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT CIMCDF_CDF_CODE_FK_PK FROM THERIAQUE.CIMCDF_CIM10_CODIF WHERE CIMCDF_CDF_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FINCO_CDF_COIN_CODE_FK_PK FROM THERIAQUE.FINCO_FINDCOMMENT WHERE FINCO_CDF_COIN_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "NN"
                'Nature (code hiérarchisé)
                sSQL = " SELECT FIN_CDF_NAIN_CODE_FK_PK FROM THERIAQUE.FIN_FICHEINDIC WHERE FIN_CDF_NAIN_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FPOUT_CDF_UTPO_CODE_FK_PK FROM THERIAQUE.FPOUT_FPOSO_UTILTH WHERE FPOUT_CDF_UTPO_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT CIMCDF_CDF_NUMERO_FK_PK FROM THERIAQUE.CIMCDF_CIM10_CODIF WHERE CIMCDF_CDF_NUMERO_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "NV"
                'Niveau
                sSQL = " SELECT FIN_CDF_NVIN_CODE_FK_PK FROM THERIAQUE.FIN_FICHEINDIC WHERE FIN_CDF_NVIN_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "NY"
                'Type
                sSQL = " SELECT FINTY_CDF_TYIN_CODE_FK_PK FROM THERIAQUE.FINTY_FINDTYPE WHERE FINTY_CDF_TYIN_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "NP"
                'Nature principale"
                'A voir 
            Case "PA"
                'Données anthropométriques
                sSQL = " SELECT IPOJ_DONANTH_CDF_CODE_FK FROM THERIAQUE.IPOJ_INFOPOSO_JOURNALIERE WHERE IPOJ_DONANTH_CDF_CODE_FK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "PC"
                'Commentaires
                sSQL = " SELECT FPOCOUT_CDF_COUT_CODE_FK_PK FROM THERIAQUE.FPOCOUT_FPOSO_COMMENTUTILTH WHERE FPOCOUT_CDF_COUT_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT IPOCOTE_CDF_COTE_CODE_FK_PK  FROM THERIAQUE.IPOCOTE_INFPO_COMMENT_TERRAIN WHERE IPOCOTE_CDF_COTE_CODE_FK_PK  = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT IPOCOFQ_CDF_COFQ_CODE_FK_PK FROM THERIAQUE.IPOCOFQ_INFPO_COMMENT_FREQ WHERE IPOCOFQ_CDF_COFQ_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT IPOCOD_CDF_COD_CODE_FK_PK FROM THERIAQUE.IPOCOD_INFPO_COMMENT_DUREE WHERE IPOCOD_CDF_COD_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FPOCOAD_CDF_COAD_CODE_FK_PK FROM THERIAQUE.FPOCOAD_FPOSO_COMMENT_ADAPT WHERE FPOCOAD_CDF_COAD_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FPOCOSU_CDF_COSU_CODE_FK_PK FROM THERIAQUE.FPOCOSU_FPOSO_COMMENT_SURVEIL WHERE FPOCOSU_CDF_COSU_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FPOCOAU_CDF_COAU_CODE_FK_PK FROM THERIAQUE.FPOCOAU_FPOSO_COMMENT_AUTRE WHERE FPOCOAU_CDF_COAU_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "PF"
                'Fréquence
                sSQL = " SELECT IPO_CDF_FREQMIN_CODE_FK FROM THERIAQUE.IPO_INFOPOSO WHERE IPO_CDF_FREQMIN_CODE_FK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT IIPO_CDF_FREQMAX_CODE_FK FROM THERIAQUE.IPO_INFOPOSO WHERE IPO_CDF_FREQMAX_CODE_FK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "PN"
                'Nature de dose
                sSQL = " SELECT IPOJ_CDF_NAPO_CODE_FK FROM THERIAQUE.IPOJ_INFOPOSO_JOURNALIERE WHERE IPOJ_CDF_NAPO_CODE_FK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT IPO_CDF_NAPO_CODE_FK FROM THERIAQUE.IPO_INFOPOSO WHERE IPO_CDF_NAPO_CODE_FK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

                Case "PP"
                'Unité de prise
                sSQL = " SELECT IPO_CDF_UNPO_CODE_FK FROM THERIAQUE.IPO_INFOPOSO WHERE IPO_CDF_UNPO_CODE_FK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "PT"
                'Terrain
                sSQL = " SELECT FPOTE_CDF_TEPO_CODE_FK_PK FROM THERIAQUE.FPOTE_FPOSO_TERRAIN WHERE FPOTE_CDF_TEPO_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "PU"
                'Unité de Temps
                sSQL = " SELECT IPO_CDF_UTMIN_CODE_FK FROM THERIAQUE.IPO_INFOPOSO WHERE IPO_CDF_UTMIN_CODE_FK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT IPO_CDF_UTMAX_CODE_FK FROM THERIAQUE.IPO_INFOPOSO WHERE IPO_CDF_UTMAX_CODE_FK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "RC"
                'Commentaires Reconstitution/Administration
                sSQL = " SELECT FRECCOR_CDF_COMRECS_FK_PK FROM THERIAQUE.FRECCOR_FREC_COMRECS WHERE FRECCOR_CDF_COMRECS_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FRECCOA_CDF_COMADM_FK_PK FROM THERIAQUE.FRECCOA_FREC_COMADM WHERE FRECCOA_CDF_COMADM_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "CC"
                'Commentaires
                sSQL = " SELECT NIVCOM_CDF_COM_CODE_FK_PK FROM THERIAQUE.NIVCOM_NIVEAU_COMMENTAIRE WHERE NIVCOM_CDF_COM_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT AUTCOM_CDF_COM_CODE_FK_PK FROM THERIAQUE.AUTCOM_AUTRE_COMMENTAIRE WHERE AUTCOM_CDF_COM_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT TERCOM_CDF_COM_CODE_FK_PK FROM THERIAQUE.TERCOM_TERRAIN_COMMENTAIRE WHERE TERCOM_CDF_COM_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "CS"
                'Famille de terrain
                sSQL = " SELECT FCPMTX_CDF_TER_CODE_FK_PK FROM THERIAQUE.FCPMTX_FICHECIPEMG_TEXTE WHERE FCPMTX_CDF_TER_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FCPMTER_CDF_TER_CODE_FK_PK FROM THERIAQUE.FCPMTER_FCPM_TERRAIN WHERE FCPMTER_CDF_TER_CODE_FK_PK  = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT TERCOM_CDF_TER_CODE_FK_PK FROM THERIAQUE.TERCOM_TERRAIN_COMMENTAIRE WHERE TERCOM_CDF_TER_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT NIVCOM_CDF_TER_CODE_FK_PK FROM THERIAQUE.NIVCOM_NIVEAU_COMMENTAIRE WHERE NIVCOM_CDF_TER_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT AUTCOM_CDF_TER_CODE_FK_PK FROM THERIAQUE.AUTCOM_AUTRE_COMMENTAIRE WHERE AUTCOM_CDF_TER_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "HC"
                'Interaction RCP
                sSQL = " SELECT FIRCPCOM_CDF_COM_CODE_FK_PK FROM THERIAQUE.FIRCPCOM_FIRCP_COM WHERE FIRCPCOM_CDF_COM_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "GT"
                'Conduite à tenir
                sSQL = " SELECT FGACF_CDF_CAT_CODE_FK_PK FROM THERIAQUE.FGACF_CATFEMMEENCEINTE WHERE FGACF_CDF_CAT_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FGACN_CDF_CAT_CODE_FK_PK FROM THERIAQUE.FGACN_CATNOUVEAUNE WHERE FGACN_CDF_CAT_CODE_FK_PK  = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FGACFAP_CDF_CAT_CODE_FK_PK FROM THERIAQUE.FGACFAP_CATFEMMEENAGE WHERE FGACFAP_CDF_CAT_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FGACA_CDF_CAT_CODE_FK_PK FROM THERIAQUE.FGACA_CATALLAITEMENT WHERE FGACA_CDF_CAT_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "GC"
                'Circonstances favorisantes
                sSQL = " SELECT FGACFN_CDF_CF_CODE_FK_PK FROM THERIAQUE.FGACFN_CIRCONSFAVORIS_NOUVEAUN WHERE FGACFN_CDF_CF_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "GP"
                'Période critique
                sSQL = " SELECT FGAPC_CDF_PC_CODE_FK_PK FROM THERIAQUE.FGAPC_PERIODECRITIQUE_FGRAL WHERE FGAPC_CDF_PC_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FGARIG_CDF_TC_CODE_FK FROM THERIAQUE.FGARIG_RISQUE_GROSSESSE WHERE FGARIG_CDF_TC_CODE_FK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "GO"
                'Observations
                sSQL = " SELECT FGAOH_CDF_OBS_CODE_FK_PK FROM THERIAQUE.FGAOH_OBSERVATION_HUMAINE WHERE FGAOH_CDF_OBS_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FGAON_CDF_OBS_CODE_FK_PK FROM THERIAQUE.FGAON_OBSERVATION_NOUVEAUNE WHERE FGAON_CDF_OBS_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FGAOA_CDF_OBS_CODE_FK_PK FROM THERIAQUE.FGAOA_OBSERVATION_ANIMALE WHERE FGAOA_CDF_OBS_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "GR"
                'Risques/Recommandations
                sSQL = " SELECT FGARIH_CDF_RI_CODE_FK_PK FROM THERIAQUE.FGARIH_RISQUE_HUMAINE WHERE FGARIH_CDF_RI_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FGARIG_CDF_RI_CODE_FK FROM THERIAQUE.FGARIG_RISQUE_GROSSESSE WHERE FGARIG_CDF_RI_CODE_FK  = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FGARIFAP_CDF_RI_CODE_FK_PK FROM THERIAQUE.FGARIFAP_RISQUEFEMMEENAGE WHERE FGARIFAP_CDF_RI_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FGARIL_CDF_RI_CODE_FK_PK FROM THERIAQUE.FGARIL_RISQUE_ALLAITEMENT WHERE FGARIL_CDF_RI_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FGARIA_CDF_RI_CODE_FK_PK FROM THERIAQUE.FGARIA_RISQUE_ANIMALE WHERE FGARIA_CDF_RI_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "EC"
                'Commentaires
                sSQL = " SELECT FEIDT_FEI_CODE_FK_PK FROM THERIAQUE.FEIDT_COMMENT_DOSETH WHERE FEIDT_FEI_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FEINA_FEI_CODE_FK_PK FROM THERIAQUE.FEINA_COMMENT_NATUREDOSETH WHERE FEINA_FEI_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FEICF_FEI_CODE_FK_PK FROM THERIAQUE.FEICF_COMMENT_CIRCONSTFAVORIS WHERE FEICF_FEI_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FEIMS_FEI_CODE_FK_PK FROM THERIAQUE.FEIMS_COMMENT_MOMENTSURV WHERE FEIMS_FEI_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FEICT_FEI_CODE_FK_PK FROM THERIAQUE.FEICT_COMMENT_CATDOSETH WHERE FEICT_FEI_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FEINAS_FEI_CODE_FK_PK FROM THERIAQUE.FEINAS_COMMENT_NATURESURDOSAG WHERE FEINAS_FEI_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FEICTS_FEI_CODE_FK_PK FROM THERIAQUE.FEICTS_COMMENT_CATSURDOS WHERE FEICTS_FEI_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "EN"
                'Nature clinique et para-clinique
                sSQL = " SELECT FEINACT_CDF_NAEI_CODE_FK_PK FROM THERIAQUE.FEINACT_NATURETHER_EICLIN WHERE FEINACT_CDF_NAEI_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FEINAPT_CDF_NAEI_CODE_FK_PK FROM THERIAQUE.FEINAPT_NATURTHER_EIPARACLIN WHERE FEINAPT_CDF_NAEI_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FEINACS_CDF_NAEI_CODE_FK_PK FROM THERIAQUE.FEINACS_NATURSURDOS_EICLIN WHERE FEINACS_CDF_NAEI_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT FEINAPS_CDF_NAEI_CODE_FK_PK FROM THERIAQUE.FEINAPS_NATURSURDOS_EIPARACLIN WHERE FEINAPS_CDF_NAEI_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "IN"
                'Nature
                sSQL = " SELECT FITNA_CDF_NAIT_CODE_FK_PK FROM THERIAQUE.FITNA_INTERACTION_NATURE WHERE FITNA_CDF_NAIT_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "IS"
                'Sens
                sSQL = " SELECT FITSE_CDF_SEIT_CODE_FK_PK FROM THERIAQUE.FITSE_INTERACTION_SENS WHERE FITSE_CDF_SEIT_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "IY"
                'Type
                sSQL = " SELECT FITTY_CDF_TYPE_CODE_FK_PK FROM THERIAQUE.FITTY_TYPEINTERACTION WHERE FITTY_CDF_TYPE_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "IV"
                'Validation
                sSQL = " SELECT FITVA_CDF_VAIT_CODE_FK_PK FROM THERIAQUE.FITVA_NIVEAU_VALIDATION WHERE FITVA_CDF_VAIT_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "IC"
                'Commentaire Classe
                sSQL = " SELECT IT1CC_CDF_CC_CODE_FK_PK FROM THERIAQUE.IT1CC_TERM1COMCLASSE WHERE IT1CC_CDF_CC_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT IT2CC_CDF_CC_CODE_FK_PK FROM THERIAQUE.IT2CC_TERM2COMCLASSE WHERE IT2CC_CDF_CC_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "MN"
                'Nature
                sSQL = " SELECT ICNA_CDF_NAIC_CODE_FK_PK FROM THERIAQUE.ICNA_INCOMPATIBILITE_NATURE WHERE ICNA_CDF_NAIC_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "MV"
                'Vecteur
                sSQL = " SELECT IC1VE_CDF_VEIC_CODE_FK_PK FROM THERIAQUE.IC1VE_INCOMPATIBILITE_VECTEUR1 WHERE IC1VE_CDF_VEIC_CODE_FK_PK = " & cn.SQLText(sCode)
                sSQL &= " UNION"
                sSQL &= " SELECT IC2VE_CDF_VEIC_CODE_FK_PK FROM THERIAQUE.IC2VE_INCOMPATIBILITE_VECTEUR2 WHERE IC2VE_CDF_VEIC_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "MD"
                'Durée / Délai
                sSQL = " SELECT ICDUR_CDF_DUR_CODE_FK_PK FROM THERIAQUE.ICDUR_INCOMPATIBILITE_DUREE WHERE ICDUR_CDF_DUR_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "ML"
                'Lumière
                sSQL = " SELECT ICLUM_CDF_LUM_CODE_FK_PK FROM THERIAQUE.ICLUM_INCOMPATIBILITE_LUMIERE WHERE ICLUM_CDF_LUM_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "MT"
                'Température
                sSQL = " SELECT ICTMP_CDF_TEMP_CODE_FK_PK FROM THERIAQUE.ICTMP_INCOMPA_TEMPERATURE WHERE ICTMP_CDF_TEMP_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            Case "MS"
                'Solution
                sSQL = " SELECT ICSOL_CDF_SOLIC_CODE_FK_PK FROM THERIAQUE.ICSOL_INCOMPATIBILITE_SOLUTION WHERE ICSOL_CDF_SOLIC_CODE_FK_PK = " & cn.SQLText(sCode)
                dt = cn.MySelect(sSQL)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Case "TP"
                'Terrain père 
                'A voir                 
        End Select
    End Function



    Public Function CODIFUsedInTerrainPere(ByVal sCode As String) As Boolean
        Dim sSQL As String = ""
        Dim dt As DataTable

        sSQL = " SELECT * FROM THERIAQUE.CDFPF_LIEN_CDF_PERE_FILS "
        sSQL &= " WHERE CDFPF_CODEF_FK_PK = " & cn.SQLText(sCode)
        sSQL &= " AND CDFPF_NUMEROF_FK_PK = 'TP'"


        dt = cn.MySelect(sSQL)
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function GetInteractionSimilaire() As DataTable

        Dim sSQL As String = ""
        Dim dt As DataTable

        sSQL = " select v.FITVA_FIT_CODE_FK_PK from theriaque.FIT_FICHEINTERAC f,theriaque.FITVA_NIVEAU_VALIDATION v "
        sSQL &= " where(f.FIT_CODE_SQ_PK = v.FITVA_FIT_CODE_FK_PK) "
        sSQL &= " and (v.FITVA_CDF_VAIT_CODE_FK_PK = '6' or v.FITVA_CDF_VAIT_CODE_FK_PK = '14') "

        dt = cn.MySelect(sSQL)
        Return dt

    End Function


    Public Function GetInteractionSpeciality(ByVal InteractionCode As Integer, ByVal Term As Integer) As DataTable

        Dim sSQL As String = ""
        Dim dt As DataTable

        If Term = 1 Then
            sSQL = " select IT1SP_SP_CODE_FK_PK from THERIAQUE.IT1SP_TERME1SPECIALITE where IT1SP_FIT_CODE_FK_PK = " & InteractionCode & " ORDER BY IT1SP_SP_CODE_FK_PK "
        Else
            sSQL = " select IT2SP_SP_CODE_FK_PK from THERIAQUE.IT2SP_TERME2SPECIALITE where IT2SP_FIT_CODE_FK_PK = " & InteractionCode & " ORDER BY IT2SP_SP_CODE_FK_PK "
        End If

        dt = cn.MySelect(sSQL)
        Return dt

    End Function


#End Region

#Region " Record "
    Public Class IRecords

        Dim vValue As Integer
        Dim vDisplay As String

        Property value() As Integer
            Get
                Return vValue
            End Get
            Set(ByVal value As Integer)
                vValue = value
            End Set
        End Property

        Property display() As String
            Get
                Return vDisplay
            End Get
            Set(ByVal value As String)
                vDisplay = value
            End Set
        End Property

        Public Sub New(ByVal Ivalue As Integer, ByVal Sdisplay As String)
            vValue = Ivalue
            vDisplay = Sdisplay
        End Sub

    End Class
#End Region

End Module
