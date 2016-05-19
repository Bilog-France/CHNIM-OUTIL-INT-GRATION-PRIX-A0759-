''' <summary>
''' Created By [YFO]
''' </summary>
''' <remarks> Monographie - Attribution automatique </remarks>
Public Class Frm_Attrb_Auto

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

            txtCode.Text = CodE
            txtLibelle.Text = ClsSP.GetLibelle(CodE)
            txtSynonyme.Text = ClsSP.GetSynonyme(CodE)

            BackgroundWorker_DoWork()

            OnLoading = False
            btSupprimer.Enabled = False
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Fonction: Suppression d'un enregistrement
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks>Fonction surchargée</remarks>
    Public Overrides Function supprimer() As Boolean
        'Etiologie
        Dim dtTemp As DataTable
        Dim strSSQL As String
        strSSQL = " Select distinct cast(FETSP_FET_CODE_FK_PK as varchar) as code from THERIAQUE.FETSP_ETIOSPE "
        strSSQL &= " where FETSP_SP_CODE_FK_PK  = " & cn.SQLText(txtCode2.Text)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                cn.Execute("DELETE FROM THERIAQUE.FETSP_ETIOSPE WHERE FETSP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND FETSP_FET_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
                cn.Execute("DELETE FROM THERIAQUE.FETAFS_FET_AFSSAPS WHERE FETAFS_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND FETAFS_FET_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
            Next
        End If

        'Sécurité préclinique
        strSSQL = " Select distinct cast(FPRCLSP_FPRCL_CODE_FK_PK as varchar) as code from THERIAQUE.FPRCLSP_SECPRECLIN_SPEC"
        strSSQL &= " where FPRCLSP_SP_CODE_FK_PK  = " & cn.SQLText(txtCode2.Text)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                cn.Execute("DELETE FROM THERIAQUE.FPRCLSP_SECPRECLIN_SPEC WHERE FPRCLSP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND FPRCLSP_FPRCL_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
                cn.Execute("DELETE FROM THERIAQUE.FPRCLAFS_FPRCL_AFSSAPS WHERE FPRCLAFS_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND FPRCLAFS_FPRCL_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
            Next
        End If

        'Posologie
        strSSQL = " Select distinct cast(FPOSP_FPO_CODE_FK_PK as varchar) as code from THERIAQUE.FPOSP_POSO_SPE "
        strSSQL &= " where FPOSP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                cn.Execute("DELETE FROM THERIAQUE.FPOSP_POSO_SPE WHERE FPOSP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND FPOSP_FPO_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
                cn.Execute("DELETE FROM THERIAQUE.FPOAFS_POSO_AFSSAPS WHERE FPOAFS_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND FPOAFS_FPO_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
            Next
        End If

        'Cipemg code 
        strSSQL = " Select distinct cast(FCPMSP_FCPM_CODE_FK_PK as varchar) as code from THERIAQUE.FCPMSP_CIPEMG_SPE "
        strSSQL &= " where FCPMSP_SP_CODE_FK_PK  = " & cn.SQLText(txtCode2.Text)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                cn.Execute("DELETE FROM THERIAQUE.FCPMSP_CIPEMG_SPE WHERE FCPMSP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND FCPMSP_FCPM_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
                cn.Execute("DELETE FROM THERIAQUE.FCPMAFS_CIPEMG_AFSSAPS WHERE FCPMAFS_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND FCPMAFS_FCPM_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
            Next
        End If

        'Interaction RCP
        strSSQL = " Select distinct cast(FIRCPSP_FIRCP_CODE_FK_PK as varchar) as code from THERIAQUE.FIRCPSP_INTERACTRCP_SPEC "
        strSSQL &= " where FIRCPSP_SP_CODE_FK_PK  = " & cn.SQLText(txtCode2.Text)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                cn.Execute("DELETE FROM THERIAQUE.FIRCPSP_INTERACTRCP_SPEC WHERE FIRCPSP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND FIRCPSP_FIRCP_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
                cn.Execute("DELETE FROM THERIAQUE.FIRCPAFS_FIRCP_AFSSAPS WHERE FIRCPAFS_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND FIRCPAFS_FIRCP_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
            Next
        End If

        'Pharmacocinétique
        strSSQL = " Select distinct cast(FPHCOSP_FPHCO_CODE_FK_PK as varchar) as code from THERIAQUE.FPHCOSP_PHARMACOCIN_SPEC"
        strSSQL &= " where FPHCOSP_SP_CODE_FK_PK  = " & cn.SQLText(txtCode2.Text)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                cn.Execute("DELETE FROM THERIAQUE.FPHCOSP_PHARMACOCIN_SPEC WHERE FPHCOSP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND FPHCOSP_FPHCO_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
                cn.Execute("DELETE FROM THERIAQUE.FPHCOAFS_FPHCO_AFSSAPS WHERE FPHCOAFS_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND FPHCOAFS_FPHCO_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
            Next
        End If

        'Indication
        strSSQL = " Select distinct cast(FINSP_FIN_CODE_FK_PK as varchar) as code from THERIAQUE.FINSP_INDSPE "
        strSSQL &= " where FINSP_SP_CODE_FK_PK  = " & cn.SQLText(txtCode2.Text)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            cn.Execute("DELETE FROM THERIAQUE.FINSMR_INDIC_SMR_ATR WHERE FINSMR_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text))
            For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                cn.Execute("DELETE FROM THERIAQUE.FINSP_INDSPE WHERE FINSP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND FINSP_FIN_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
                cn.Execute("DELETE FROM THERIAQUE.FINAFS_FIN_AFSSAPS WHERE FINAFS_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND FINAFS_FIN_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
            Next
        End If

        'Reconst/aDminist
        strSSQL = " Select distinct cast(FRECSP_FREC_CODE_FK_PK as varchar) as code from THERIAQUE.FRECSP_RECONST_SPEC "
        strSSQL &= " where FRECSP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                cn.Execute("DELETE FROM THERIAQUE.FRECSP_RECONST_SPEC WHERE FRECSP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND FRECSP_FREC_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
                cn.Execute("DELETE FROM THERIAQUE.FRECAFS_FREC_AFSSAPS WHERE FRECAFS_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND FRECAFS_FREC_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
            Next
        End If

        'Cipemg texte
        strSSQL = " Select distinct cast(FCPTSP_FCPT_CODE_FK_PK as varchar) as code from THERIAQUE.FCPTSP_CIPEMG_SPE"
        strSSQL &= " where FCPTSP_SP_CODE_FK_PK  = " & cn.SQLText(txtCode2.Text)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                cn.Execute("DELETE FROM THERIAQUE.FCPTSP_CIPEMG_SPE WHERE FCPTSP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND FCPTSP_FCPT_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
                cn.Execute("DELETE FROM THERIAQUE.FCPTAFS_CIPEMG_AFSSAPS WHERE FCPTAFS_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND FCPTAFS_FCPT_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
            Next
        End If

        'Grossesse et allaitement
        strSSQL = " Select distinct cast(FGASP_FGA_CODE_FK_PK as varchar) as code from THERIAQUE.FGASP_GRALSPE"
        strSSQL &= " where FGASP_SP_CODE_FK_PK  = " & cn.SQLText(txtCode2.Text)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                cn.Execute("DELETE FROM THERIAQUE.FGASP_GRALSPE WHERE FGASP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND FGASP_FGA_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
                cn.Execute("DELETE FROM THERIAQUE.FGAAFS_FGA_AFSSAPS WHERE FGAAFS_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND FGAAFS_FGA_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
            Next
        End If

        'Conducteur
        strSSQL = " Select distinct cast(FCOSP_FCO_CODE_FK_PK as varchar) as code from THERIAQUE.FCOSP_CONDUCTEUR_SPEC "
        strSSQL &= " where FCOSP_SP_CODE_FK_PK  = " & cn.SQLText(txtCode2.Text)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                cn.Execute("DELETE FROM THERIAQUE.FCOSP_CONDUCTEUR_SPEC WHERE FCOSP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND FCOSP_FCO_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
                cn.Execute("DELETE FROM THERIAQUE.FCOAFS_FCO_AFSSAPS WHERE FCOAFS_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND FCOAFS_FCO_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
            Next
        End If

        'Effets indésirables
        strSSQL = " Select distinct cast(FEISP_FEI_CODE_FK_PK as varchar) as code from THERIAQUE.FEISP_EFFINDSPE"
        strSSQL &= " where FEISP_SP_CODE_FK_PK  = " & cn.SQLText(txtCode2.Text)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                cn.Execute("DELETE FROM THERIAQUE.FEISP_EFFINDSPE WHERE FEISP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND FEISP_FEI_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
                cn.Execute("DELETE FROM THERIAQUE.FEIAFS_EFFETIND_AFSSAPS WHERE FEIAFS_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND FEIAFS_FEI_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
            Next
        End If
        txtCode2.Text = ""
        txtLibelle2.Text = ""
        'BackgroundWorker_DoWork()
        Return True
    End Function

    ''' <summary>
    ''' Proçédure: Ajout d'un enregistrement
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub ajouter()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_SP_SPECIALITE
        f.Text = Me.Text
        btValider.Enabled = False
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            OnLoading = True
            txtCode2.Text = CodE
            txtLibelle2.Text = ClsSP.GetLibelle(CodE)
            txtSynonyme2.Text = ClsSP.GetSynonyme(CodE)
            If Not TestEntiteSimilaire_Exist(CodE) Then
                btValider.Enabled = True
                If txtCode.Text = txtCode2.Text Then
                    btValider.Enabled = False
                End If
                If Not TestEntiteSimilaire_Exist(txtCode.Text) Then
                    btValider.Enabled = False
                End If
            Else
                btValider.Enabled = False
            End If
            If TestEntiteSimilaire_Exist(CodE) And TestEntiteSimilaire_Exist(txtCode.Text) Then
                btSupprimer.Enabled = True
            Else
                btSupprimer.Enabled = False
            End If
            OnLoading = False
        Else
            annuler()
        End If
    End Sub

    ''' <summary>
    ''' Proçédure: Validation d'un enregistrement
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub valider()
        MyBase.Valider()
        'Etiologie
        Dim dtTemp As DataTable
        Dim strSSQL As String
        Dim bExist As Boolean = False
        strSSQL = " Select distinct cast(FETSP_FET_CODE_FK_PK as varchar) as code from THERIAQUE.FETSP_ETIOSPE "
        strSSQL &= " where FETSP_SP_CODE_FK_PK  = " & cn.SQLText(txtCode.Text)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                Dim dtSpecialite As DataTable = cn.MySelect("SELECT FETSP_SP_CODE_FK_PK FROM THERIAQUE.FETSP_ETIOSPE WHERE FETSP_FET_CODE_FK_PK =" & dtTemp.Rows(iCount)(0) & " AND FETSP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text))
                If dtSpecialite.Rows.Count > 0 Then
                    bExist = True
                End If
                If Not bExist Then
                    cn.Execute("Insert into THERIAQUE.FETSP_ETIOSPE values (" & cn.SQLText(txtCode2.Text) & "," & dtTemp.Rows(iCount)(0) & ")")
                End If
            Next
        End If

        'Sécurité préclinique
        bExist = False
        strSSQL = " Select distinct cast(FPRCLSP_FPRCL_CODE_FK_PK as varchar) as code from THERIAQUE.FPRCLSP_SECPRECLIN_SPEC"
        strSSQL &= " where FPRCLSP_SP_CODE_FK_PK  = " & cn.SQLText(txtCode.Text)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                Dim dtSpecialite As DataTable = cn.MySelect("SELECT FPRCLSP_SP_CODE_FK_PK FROM THERIAQUE.FPRCLSP_SECPRECLIN_SPEC WHERE FPRCLSP_FPRCL_CODE_FK_PK =" & dtTemp.Rows(iCount)(0) & " AND FPRCLSP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text))
                If dtSpecialite.Rows.Count > 0 Then
                    bExist = True
                End If
                If Not bExist Then
                    cn.Execute("Insert into THERIAQUE.FPRCLSP_SECPRECLIN_SPEC values (" & dtTemp.Rows(iCount)(0) & "," & cn.SQLText(txtCode2.Text) & ")")
                End If
            Next
        End If

        'Posologie
        bExist = False
        strSSQL = " Select distinct cast(FPOSP_FPO_CODE_FK_PK as varchar) as code from THERIAQUE.FPOSP_POSO_SPE "
        strSSQL &= " where FPOSP_SP_CODE_FK_PK = " & cn.SQLText(txtCode.Text)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                Dim dtSpecialite As DataTable = cn.MySelect("SELECT FPOSP_SP_CODE_FK_PK FROM THERIAQUE.FPOSP_POSO_SPE WHERE FPOSP_FPO_CODE_FK_PK =" & dtTemp.Rows(iCount)(0) & " AND FPOSP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text))
                If dtSpecialite.Rows.Count > 0 Then
                    bExist = True
                End If
                If Not bExist Then
                    cn.Execute("Insert into THERIAQUE.FPOSP_POSO_SPE values (" & dtTemp.Rows(iCount)(0) & "," & cn.SQLText(txtCode2.Text) & ")")
                End If
            Next
        End If

        'Cipemg code 
        bExist = False
        strSSQL = " Select distinct cast(FCPMSP_FCPM_CODE_FK_PK as varchar) as code from THERIAQUE.FCPMSP_CIPEMG_SPE "
        strSSQL &= " where FCPMSP_SP_CODE_FK_PK  = " & cn.SQLText(txtCode.Text)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                Dim dtSpecialite As DataTable = cn.MySelect("SELECT FCPMSP_SP_CODE_FK_PK FROM THERIAQUE.FCPMSP_CIPEMG_SPE WHERE FCPMSP_FCPM_CODE_FK_PK =" & dtTemp.Rows(iCount)(0) & " AND FCPMSP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text))
                If dtSpecialite.Rows.Count > 0 Then
                    bExist = True
                End If
                If Not bExist Then
                    cn.Execute("Insert into THERIAQUE.FCPMSP_CIPEMG_SPE values (" & dtTemp.Rows(iCount)(0) & "," & cn.SQLText(txtCode2.Text) & ")")
                End If
            Next
        End If

        'Interaction RCP
        bExist = False
        strSSQL = " Select distinct cast(FIRCPSP_FIRCP_CODE_FK_PK as varchar) as code from THERIAQUE.FIRCPSP_INTERACTRCP_SPEC "
        strSSQL &= " where FIRCPSP_SP_CODE_FK_PK  = " & cn.SQLText(txtCode.Text)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                Dim dtSpecialite As DataTable = cn.MySelect("SELECT FIRCPSP_SP_CODE_FK_PK FROM THERIAQUE.FIRCPSP_INTERACTRCP_SPEC WHERE FIRCPSP_FIRCP_CODE_FK_PK =" & dtTemp.Rows(iCount)(0) & " AND FIRCPSP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text))
                If dtSpecialite.Rows.Count > 0 Then
                    bExist = True
                End If
                If Not bExist Then
                    cn.Execute("Insert into THERIAQUE.FIRCPSP_INTERACTRCP_SPEC values (" & dtTemp.Rows(iCount)(0) & "," & cn.SQLText(txtCode2.Text) & ")")
                End If
            Next
        End If

        'Pharmacocinétique
        bExist = False
        strSSQL = " Select distinct cast(FPHCOSP_FPHCO_CODE_FK_PK as varchar) as code from THERIAQUE.FPHCOSP_PHARMACOCIN_SPEC"
        strSSQL &= " where FPHCOSP_SP_CODE_FK_PK  = " & cn.SQLText(txtCode.Text)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                Dim dtSpecialite As DataTable = cn.MySelect("SELECT FPHCOSP_SP_CODE_FK_PK FROM THERIAQUE.FPHCOSP_PHARMACOCIN_SPEC WHERE FPHCOSP_FPHCO_CODE_FK_PK =" & dtTemp.Rows(iCount)(0) & " AND FPHCOSP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text))
                If dtSpecialite.Rows.Count > 0 Then
                    bExist = True
                End If
                If Not bExist Then
                    cn.Execute("Insert into THERIAQUE.FPHCOSP_PHARMACOCIN_SPEC values (" & dtTemp.Rows(iCount)(0) & "," & cn.SQLText(txtCode2.Text) & ")")
                End If
            Next
        End If

        'Indication
        bExist = False
        strSSQL = " Select distinct cast(FINSP_FIN_CODE_FK_PK as varchar) as code from THERIAQUE.FINSP_INDSPE "
        strSSQL &= " where FINSP_SP_CODE_FK_PK  = " & cn.SQLText(txtCode.Text)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                Dim dtSpecialite As DataTable = cn.MySelect("SELECT FINSP_SP_CODE_FK_PK FROM THERIAQUE.FINSP_INDSPE WHERE FINSP_FIN_CODE_FK_PK =" & dtTemp.Rows(iCount)(0) & " AND FINSP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text))
                If dtSpecialite.Rows.Count > 0 Then
                    bExist = True
                End If
                If Not bExist Then
                    cn.Execute("Insert into THERIAQUE.FINSP_INDSPE values (" & dtTemp.Rows(iCount)(0) & "," & cn.SQLText(txtCode2.Text) & ")")
                End If
            Next
        End If

        'Reconst/aDminist
        bExist = False
        strSSQL = " Select distinct cast(FRECSP_FREC_CODE_FK_PK as varchar) as code from THERIAQUE.FRECSP_RECONST_SPEC "
        strSSQL &= " where FRECSP_SP_CODE_FK_PK = " & cn.SQLText(txtCode.Text)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                Dim dtSpecialite As DataTable = cn.MySelect("SELECT FRECSP_SP_CODE_FK_PK FROM THERIAQUE.FRECSP_RECONST_SPEC WHERE FRECSP_FREC_CODE_FK_PK =" & dtTemp.Rows(iCount)(0) & " AND FRECSP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text))
                If dtSpecialite.Rows.Count > 0 Then
                    bExist = True
                End If
                If Not bExist Then
                    cn.Execute("Insert into THERIAQUE.FRECSP_RECONST_SPEC values (" & dtTemp.Rows(iCount)(0) & "," & cn.SQLText(txtCode2.Text) & ")")
                End If
            Next
        End If

        'Cipemg texte
        bExist = False
        strSSQL = " Select distinct cast(FCPTSP_FCPT_CODE_FK_PK as varchar) as code from THERIAQUE.FCPTSP_CIPEMG_SPE"
        strSSQL &= " where FCPTSP_SP_CODE_FK_PK  = " & cn.SQLText(txtCode.Text)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                Dim dtSpecialite As DataTable = cn.MySelect("SELECT FCPTSP_SP_CODE_FK_PK FROM THERIAQUE.FCPTSP_CIPEMG_SPE WHERE FCPTSP_FCPT_CODE_FK_PK =" & dtTemp.Rows(iCount)(0) & " AND FCPTSP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text))
                If dtSpecialite.Rows.Count > 0 Then
                    bExist = True
                End If
                If Not bExist Then
                    cn.Execute("Insert into THERIAQUE.FCPTSP_CIPEMG_SPE values (" & dtTemp.Rows(iCount)(0) & "," & cn.SQLText(txtCode2.Text) & ")")
                End If
            Next
        End If

        'Grossesse et allaitement
        bExist = False
        strSSQL = " Select distinct cast(FGASP_FGA_CODE_FK_PK as varchar) as code from THERIAQUE.FGASP_GRALSPE"
        strSSQL &= " where FGASP_SP_CODE_FK_PK  = " & cn.SQLText(txtCode.Text)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                Dim dtSpecialite As DataTable = cn.MySelect("SELECT FGASP_SP_CODE_FK_PK FROM THERIAQUE.FGASP_GRALSPE WHERE FGASP_FGA_CODE_FK_PK =" & dtTemp.Rows(iCount)(0) & " AND FGASP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text))
                If dtSpecialite.Rows.Count > 0 Then
                    bExist = True
                End If
                If Not bExist Then
                    cn.Execute("Insert into THERIAQUE.FGASP_GRALSPE values (" & dtTemp.Rows(iCount)(0) & "," & cn.SQLText(txtCode2.Text) & ")")
                End If
            Next
        End If

        'Conducteur
        bExist = False
        strSSQL = " Select distinct cast(FCOSP_FCO_CODE_FK_PK as varchar) as code from THERIAQUE.FCOSP_CONDUCTEUR_SPEC "
        strSSQL &= " where FCOSP_SP_CODE_FK_PK  = " & cn.SQLText(txtCode.Text)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                Dim dtSpecialite As DataTable = cn.MySelect("SELECT FCOSP_SP_CODE_FK_PK FROM THERIAQUE.FCOSP_CONDUCTEUR_SPEC WHERE FCOSP_FCO_CODE_FK_PK =" & dtTemp.Rows(iCount)(0) & " AND FCOSP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text))
                If dtSpecialite.Rows.Count > 0 Then
                    bExist = True
                End If
                If Not bExist Then
                    cn.Execute("Insert into THERIAQUE.FCOSP_CONDUCTEUR_SPEC values (" & dtTemp.Rows(iCount)(0) & "," & cn.SQLText(txtCode2.Text) & ")")
                End If
            Next
        End If

        'Effets indésirables
        bExist = False
        strSSQL = " Select distinct cast(FEISP_FEI_CODE_FK_PK as varchar) as code from THERIAQUE.FEISP_EFFINDSPE"
        strSSQL &= " where FEISP_SP_CODE_FK_PK  = " & cn.SQLText(txtCode.Text)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                Dim dtSpecialite As DataTable = cn.MySelect("SELECT FEISP_SP_CODE_FK_PK FROM THERIAQUE.FEISP_EFFINDSPE WHERE FEISP_FEI_CODE_FK_PK =" & dtTemp.Rows(iCount)(0) & " AND FEISP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text))
                If dtSpecialite.Rows.Count > 0 Then
                    bExist = True
                End If
                If Not bExist Then
                    cn.Execute("Insert into THERIAQUE.FEISP_EFFINDSPE values (" & dtTemp.Rows(iCount)(0) & "," & cn.SQLText(txtCode2.Text) & ")")
                End If
            Next
        End If
    End Sub

    ''' <summary>
    ''' Proçédure: Annulation d'un enregistrement
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub annuler()
        OnLoading = True
        MyBase.Annuler()

        txtCode2.Text = ""
        txtLibelle2.Text = ""
        txtSynonyme2.Text = ""

        OnLoading = False
    End Sub
#End Region

#Region " Init Data  "
    ''' <summary>
    ''' Proçédure: Récupération des données par code de chaque fiche
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BackgroundWorker_DoWork()
        ProgressBar.Visible = True
        Dim strSSQL As String = ""

        'étiologie
        strSSQL = " Select distinct cast(FETSP_FET_CODE_FK_PK as varchar) as code from THERIAQUE.FETSP_ETIOSPE "
        strSSQL &= " where FETSP_SP_CODE_FK_PK  = " & CodE
        GC.DataSource = cn.MySelect(strSSQL)

        Application.DoEvents()

        'pharmacocinétique
        strSSQL = " Select distinct cast(FPHCOSP_FPHCO_CODE_FK_PK as varchar) as code from THERIAQUE.FPHCOSP_PHARMACOCIN_SPEC"
        strSSQL &= " where FPHCOSP_SP_CODE_FK_PK  = " & CodE
        GC2.DataSource = cn.MySelect(strSSQL)

        Application.DoEvents()

        'sécurité préclinique
        strSSQL = " Select distinct cast(FPRCLSP_FPRCL_CODE_FK_PK as varchar) as code from THERIAQUE.FPRCLSP_SECPRECLIN_SPEC"
        strSSQL &= " where FPRCLSP_SP_CODE_FK_PK  = " & CodE
        GC3.DataSource = cn.MySelect(strSSQL)

        Application.DoEvents()

        'indication
        strSSQL = " Select distinct cast(FINSP_FIN_CODE_FK_PK as varchar) as code from THERIAQUE.FINSP_INDSPE "
        strSSQL &= " where FINSP_SP_CODE_FK_PK  = " & CodE
        GC4.DataSource = cn.MySelect(strSSQL)

        Application.DoEvents()

        'posologie
        strSSQL = " Select distinct cast(FPOSP_FPO_CODE_FK_PK as varchar) as code from THERIAQUE.FPOSP_POSO_SPE "
        strSSQL &= " where FPOSP_SP_CODE_FK_PK = " & CodE
        GC5.DataSource = cn.MySelect(strSSQL)

        Application.DoEvents()

        'reconst/aDminist
        strSSQL = " Select distinct cast(FRECSP_FREC_CODE_FK_PK as varchar) as code from THERIAQUE.FRECSP_RECONST_SPEC "
        strSSQL &= " where FRECSP_SP_CODE_FK_PK = " & CodE
        GC6.DataSource = cn.MySelect(strSSQL)

        Application.DoEvents()

        'Cipemg code 
        strSSQL = " Select distinct cast(FCPMSP_FCPM_CODE_FK_PK as varchar) as code from THERIAQUE.FCPMSP_CIPEMG_SPE "
        strSSQL &= " where FCPMSP_SP_CODE_FK_PK  = " & CodE
        GC7.DataSource = cn.MySelect(strSSQL)

        Application.DoEvents()

        'cipemg texte
        strSSQL = " Select distinct cast(FCPTSP_FCPT_CODE_FK_PK as varchar) as code from THERIAQUE.FCPTSP_CIPEMG_SPE"
        strSSQL &= " where FCPTSP_SP_CODE_FK_PK  = " & CodE
        GC8.DataSource = cn.MySelect(strSSQL)

        Application.DoEvents()

        'interaction RCP
        strSSQL = " Select distinct cast(FIRCPSP_FIRCP_CODE_FK_PK as varchar) as code from THERIAQUE.FIRCPSP_INTERACTRCP_SPEC "
        strSSQL &= " where FIRCPSP_SP_CODE_FK_PK  = " & CodE
        GC9.DataSource = cn.MySelect(strSSQL)

        Application.DoEvents()

        'grossesse et allaitement
        strSSQL = " Select distinct cast(FGASP_FGA_CODE_FK_PK as varchar) as code from THERIAQUE.FGASP_GRALSPE"
        strSSQL &= " where FGASP_SP_CODE_FK_PK  = " & CodE
        GC10.DataSource = cn.MySelect(strSSQL)

        Application.DoEvents()

        'conducteur
        strSSQL = " Select distinct cast(FCOSP_FCO_CODE_FK_PK as varchar) as code from THERIAQUE.FCOSP_CONDUCTEUR_SPEC "
        strSSQL &= " where FCOSP_SP_CODE_FK_PK  = " & CodE
        GC11.DataSource = cn.MySelect(strSSQL)

        Application.DoEvents()

        'effets indésirables
        strSSQL = " Select distinct cast(FEISP_FEI_CODE_FK_PK as varchar) as code from THERIAQUE.FEISP_EFFINDSPE"
        strSSQL &= " where FEISP_SP_CODE_FK_PK  = " & CodE
        GC12.DataSource = cn.MySelect(strSSQL)

        Application.DoEvents()

        ProgressBar.Visible = False

    End Sub

    ''' <summary>
    ''' Proçédure: Initialisation des données
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub InitData()
        'btAjouter.Enabled = False
    End Sub

#End Region

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche correspondante
    ''' </summary>
    ''' <param name="sender">rpbtEdit1</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    Private Sub rpbtEdit1_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit1.ButtonClick
        If Me.CardView1.GetFocusedRowCellValue(Me.col1_Etiologie) IsNot Nothing Then
            Dim f As New Frm_Etiologie
            f._Code = Me.CardView1.GetFocusedRowCellValue(Me.col1_Etiologie)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche correspondante
    ''' </summary>
    ''' <param name="sender">rpbtEdit2</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    Private Sub rpbtEdit2_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit2.ButtonClick
        If Me.CardView2.GetFocusedRowCellValue(Me.col1_SecPrec) IsNot Nothing Then
            Dim f As New Frm_Securite_Preclinique
            f._Code = Me.CardView2.GetFocusedRowCellValue(Me.col1_SecPrec)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche correspondante
    ''' </summary>
    ''' <param name="sender">rpbtEdit3</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    Private Sub rpbtEdit3_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit3.ButtonClick
        If Me.CardView3.GetFocusedRowCellValue(Me.col1_Posologie) IsNot Nothing Then
            Dim f As New Frm_Posologie
            f._Code = Me.CardView3.GetFocusedRowCellValue(Me.col1_Posologie)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche correspondante
    ''' </summary>
    ''' <param name="sender">rpbtEdit4</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    Private Sub rpbtEdit4_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit4.ButtonClick
        If Me.CardView4.GetFocusedRowCellValue(Me.col1_CipemgCode) IsNot Nothing Then
            Dim f As New Frm_Cipemg_Code
            f._Code = Me.CardView4.GetFocusedRowCellValue(Me.col1_CipemgCode)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche correspondante
    ''' </summary>
    ''' <param name="sender">rpbtEdit5</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    Private Sub rpbtEdit5_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit5.ButtonClick
        If Me.CardView5.GetFocusedRowCellValue(Me.col1_InteractionRCP) IsNot Nothing Then
            Dim f As New Frm_InteractionsRCP
            f._Code = Me.CardView5.GetFocusedRowCellValue(Me.col1_InteractionRCP)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche correspondante
    ''' </summary>
    ''' <param name="sender">rpbtEdit6</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    Private Sub rpbtEdit6_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit6.ButtonClick
        If Me.CardView6.GetFocusedRowCellValue(Me.col1_Pharmaco) IsNot Nothing Then
            Dim f As New Frm_Pharmacocinetique
            f._Code = Me.CardView6.GetFocusedRowCellValue(Me.col1_Pharmaco)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche correspondante
    ''' </summary>
    ''' <param name="sender">rpbtEdit7</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    Private Sub rpbtEdit7_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit7.ButtonClick
        If Me.CardView7.GetFocusedRowCellValue(Me.col1_Indication) IsNot Nothing Then
            Dim f As New Frm_Indication
            f._Code = Me.CardView7.GetFocusedRowCellValue(Me.col1_Indication)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche correspondante
    ''' </summary>
    ''' <param name="sender">rpbtEdit8</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    Private Sub rpbtEdit8_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit8.ButtonClick
        If Me.CardView8.GetFocusedRowCellValue(Me.col1_ReconstAdminist) IsNot Nothing Then
            Dim f As New Frm_Reconst_Administ
            f._Code = Me.CardView8.GetFocusedRowCellValue(Me.col1_ReconstAdminist)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche correspondante
    ''' </summary>
    ''' <param name="sender">rpbtEdit9</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    Private Sub rpbtEdit9_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit9.ButtonClick
        If Me.CardView9.GetFocusedRowCellValue(Me.col1_CipemgTexte) IsNot Nothing Then
            Dim f As New Frm_Cipemg_Texte
            f._Code = Me.CardView9.GetFocusedRowCellValue(Me.col1_CipemgTexte)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche correspondante
    ''' </summary>
    ''' <param name="sender">rpbtEdit10</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    Private Sub rpbtEdit10_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit10.ButtonClick
        If Me.CardView10.GetFocusedRowCellValue(Me.col1_Grosse_Allai) IsNot Nothing Then
            Dim f As New Frm_Grossesse_Allaitement
            f._Code = Me.CardView10.GetFocusedRowCellValue(Me.col1_Grosse_Allai)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche correspondante
    ''' </summary>
    ''' <param name="sender">rpbtEdit11</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    Private Sub rpbtEdit11_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit11.ButtonClick
        If Me.CardView11.GetFocusedRowCellValue(Me.col1_Conducteur) IsNot Nothing Then
            Dim f As New Frm_Conducteur
            f._Code = Me.CardView11.GetFocusedRowCellValue(Me.col1_Conducteur)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Clique pour ouverture de la fiche correspondante
    ''' </summary>
    ''' <param name="sender">rpbtEdit12</param>
    ''' <param name="e">ButtonClick</param>
    ''' <remarks></remarks>
    Private Sub rpbtEdit12_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpbtEdit12.ButtonClick
        If Me.CardView12.GetFocusedRowCellValue(Me.col1_EffetInde) IsNot Nothing Then
            Dim f As New Frm_Effets_Indiserables
            f._Code = Me.CardView12.GetFocusedRowCellValue(Me.col1_EffetInde)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub

    Private Function TestEntiteSimilaire_Exist(Optional ByVal sCodeSP As String = "") As Boolean
        TestEntiteSimilaire_Exist = False
        'Etiologie
        Dim dtTemp As DataTable
        Dim strSSQL As String
        strSSQL = " Select distinct cast(FETSP_FET_CODE_FK_PK as varchar) as code from THERIAQUE.FETSP_ETIOSPE "
        strSSQL &= " WHERE FETSP_SP_CODE_FK_PK  = " & cn.SQLText(sCodeSP)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            TestEntiteSimilaire_Exist = True
            Exit Function
        End If

        'Sécurité préclinique
        strSSQL = " Select distinct cast(FPRCLSP_FPRCL_CODE_FK_PK as varchar) as code from THERIAQUE.FPRCLSP_SECPRECLIN_SPEC"
        strSSQL &= " where FPRCLSP_SP_CODE_FK_PK  = " & cn.SQLText(sCodeSP)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            TestEntiteSimilaire_Exist = True
            Exit Function
        End If

        'Posologie
        strSSQL = " Select distinct cast(FPOSP_FPO_CODE_FK_PK as varchar) as code from THERIAQUE.FPOSP_POSO_SPE "
        strSSQL &= " where FPOSP_SP_CODE_FK_PK = " & cn.SQLText(sCodeSP)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            TestEntiteSimilaire_Exist = True
            Exit Function
        End If

        'Cipemg code 
        strSSQL = " Select distinct cast(FCPMSP_FCPM_CODE_FK_PK as varchar) as code from THERIAQUE.FCPMSP_CIPEMG_SPE "
        strSSQL &= " where FCPMSP_SP_CODE_FK_PK  = " & cn.SQLText(sCodeSP)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            TestEntiteSimilaire_Exist = True
            Exit Function
        End If

        'Interaction RCP
        strSSQL = " Select distinct cast(FIRCPSP_FIRCP_CODE_FK_PK as varchar) as code from THERIAQUE.FIRCPSP_INTERACTRCP_SPEC "
        strSSQL &= " where FIRCPSP_SP_CODE_FK_PK  = " & cn.SQLText(sCodeSP)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            TestEntiteSimilaire_Exist = True
            Exit Function
        End If

        'Pharmacocinétique
        strSSQL = " Select distinct cast(FPHCOSP_FPHCO_CODE_FK_PK as varchar) as code from THERIAQUE.FPHCOSP_PHARMACOCIN_SPEC"
        strSSQL &= " where FPHCOSP_SP_CODE_FK_PK  = " & cn.SQLText(sCodeSP)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            TestEntiteSimilaire_Exist = True
            Exit Function
        End If

        'Indication
        strSSQL = " Select distinct cast(FINSP_FIN_CODE_FK_PK as varchar) as code from THERIAQUE.FINSP_INDSPE "
        strSSQL &= " where FINSP_SP_CODE_FK_PK  = " & cn.SQLText(sCodeSP)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            TestEntiteSimilaire_Exist = True
            Exit Function
        End If

        'Reconst/aDminist
        strSSQL = " Select distinct cast(FRECSP_FREC_CODE_FK_PK as varchar) as code from THERIAQUE.FRECSP_RECONST_SPEC "
        strSSQL &= " where FRECSP_SP_CODE_FK_PK = " & cn.SQLText(sCodeSP)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            TestEntiteSimilaire_Exist = True
            Exit Function
        End If

        'Cipemg texte
        strSSQL = " Select distinct cast(FCPTSP_FCPT_CODE_FK_PK as varchar) as code from THERIAQUE.FCPTSP_CIPEMG_SPE"
        strSSQL &= " where FCPTSP_SP_CODE_FK_PK  = " & cn.SQLText(sCodeSP)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            TestEntiteSimilaire_Exist = True
            Exit Function
        End If

        'Grossesse et allaitement
        strSSQL = " Select distinct cast(FGASP_FGA_CODE_FK_PK as varchar) as code from THERIAQUE.FGASP_GRALSPE"
        strSSQL &= " where FGASP_SP_CODE_FK_PK  = " & cn.SQLText(sCodeSP)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            TestEntiteSimilaire_Exist = True
            Exit Function
        End If

        'Conducteur
        strSSQL = " Select distinct cast(FCOSP_FCO_CODE_FK_PK as varchar) as code from THERIAQUE.FCOSP_CONDUCTEUR_SPEC "
        strSSQL &= " where FCOSP_SP_CODE_FK_PK  = " & cn.SQLText(sCodeSP)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            TestEntiteSimilaire_Exist = True
            Exit Function
        End If

        'Effets indésirables
        strSSQL = " Select distinct cast(FEISP_FEI_CODE_FK_PK as varchar) as code from THERIAQUE.FEISP_EFFINDSPE"
        strSSQL &= " where FEISP_SP_CODE_FK_PK  = " & cn.SQLText(sCodeSP)
        dtTemp = cn.MySelect(strSSQL)
        If dtTemp.Rows.Count > 0 Then
            TestEntiteSimilaire_Exist = True
            Exit Function
        End If
    End Function
End Class
