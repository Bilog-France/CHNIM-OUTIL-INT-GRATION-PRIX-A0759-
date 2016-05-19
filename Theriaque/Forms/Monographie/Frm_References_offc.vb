Public Class Frm_References_offc

    Private CodE As Integer
    Dim CollectionSP As New Collection
    Dim CollectionCPH As New Collection

    Private Const ADD As String = "Ajout"
    Private Const CONSLT As String = "Consultation"
    Private Const SUPP As String = "Suppression"
    Private Const Invisible As String = "Invisible"

    Dim dtGC As DataTable

#Region " Edit Data  "

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_SP_SPECIALITE
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then

            OnLoading = True
            ProgressBar.Visible = True

            txtCode.Text = CodE
            txtLibelle.Text = ClsSP.GetLibelle(CodE)
            txtSynonyme.Text = ClsSP.GetSynonyme(CodE)

            BackgroundWorker.RunWorkerAsync()
            OnLoading = False
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Function supprimer() As Boolean
        MyBase.Supprimer()
        Return True
    End Function

    Public Overrides Sub valider()
        Dim RUBCDF As String
        Dim Date_ As String
        Dim SP_ As String = CodE
        Dim DOC As String
        Dim POS As String
        Dim Date_Revis As String

        GV.FocusedRowHandle += 1
        GV.FocusedRowHandle -= 2
        GV.FocusedRowHandle += 1
        POS = 0
        For inti As Integer = 0 To Me.GV.RowCount - 1
            If GV.GetRowCellValue(POS, Me.colaction) IsNot DBNull.Value Then

                RUBCDF = GV.GetRowCellValue(POS, Me.colSPAFS_RUBCDF_NUMERO_PK)
                Date_ = GV.GetRowCellValue(POS, Me.colSPAFS_DATE_PK)
                DOC = GV.GetRowCellValue(POS, Me.colSPAFS_CDF_CODE_DOC_FK_PK)
                Date_Revis = NNS(GV.GetRowCellValue(POS, Me.colSPAFS_DATE_REVIS))
                Dim sDate_revis As String
                If Date_Revis <> "" Then
                    sDate_revis = cn.SQLDate(Date_Revis)
                Else
                    sDate_revis = "NULL"
                End If




                If GV.GetRowCellValue(POS, Me.colaction) = ADD Then
                    GV.SetRowCellValue(POS, Me.colaction, CONSLT)
                    '------------------------------
                    '------------------------------
                    ' Ajout
                    '------------------------------
                    Select Case GV.GetRowCellValue(POS, Me.colSPAFS_RUBCDF_NUMERO_PK)

                        Case RUB_CDF.SPECIALITE_, RUB_CDF.Classe_Pharmaco
                            cn.Execute("Insert into THERIAQUE.SPAFS_SPECIALITE_AFSSAPS values (" & cn.SQLText(RUBCDF) & "," & cn.SQLText(SP_) & "," & cn.SQLDate(Date_) & "," & cn.SQLText(DOC) & "," & sDate_revis & ")")

                        Case RUB_CDF.Composition, RUB_CDF.Condition_Presciption, RUB_CDF.Conservation, RUB_CDF.Dénomination, RUB_CDF.Forme_Phramaceutique
                            cn.Execute("Insert into THERIAQUE.SPAFS_SPECIALITE_AFSSAPS values (" & cn.SQLText(RUBCDF) & "," & cn.SQLText(SP_) & "," & cn.SQLDate(Date_) & "," & cn.SQLText(DOC) & ", NULL)")

                        Case RUB_CDF.La_Liste, RUB_CDF.La_presentation, RUB_CDF.La_voie_dadministration, RUB_CDF.Le_conditionnement__La_présentation, RUB_CDF.Le_laboratoire_exploitant, RUB_CDF.Le_laboratoire_titulaire, RUB_CDF.Le_statut
                            cn.Execute("Insert into THERIAQUE.SPAFS_SPECIALITE_AFSSAPS values (" & cn.SQLText(RUBCDF) & "," & cn.SQLText(SP_) & "," & cn.SQLDate(Date_) & "," & cn.SQLText(DOC) & ", NULL)")

                        Case RUB_CDF.La_rubrique_ALLAITEMENT
                            Dim dtTemp As DataTable
                            dtTemp = cn.MySelect("select FGASP_FGA_CODE_FK_PK from THERIAQUE.FGASP_GRALSPE where  FGASP_SP_CODE_FK_PK = " & CodE)
                            If dtTemp.Rows.Count > 0 Then
                                For intj As Integer = 0 To dtTemp.Rows.Count - 1
                                    cn.Execute("Insert into THERIAQUE.FGAAFS_FGA_AFSSAPS values (" & dtTemp.Rows(intj)(0) & "," & cn.SQLText(SP_) & "," & cn.SQLDate(Date_) & ", 'A' , " & cn.SQLText(DOC) & ")")
                                Next
                            End If

                        Case RUB_CDF.CIPEC
                            Dim dtTemp As DataTable
                            dtTemp = cn.MySelect("select FCPMSP_FCPM_CODE_FK_PK from THERIAQUE.FCPMSP_CIPEMG_SPE where  FCPMSP_SP_CODE_FK_PK = " & CodE)
                            If dtTemp.Rows.Count > 0 Then
                                For intj As Integer = 0 To dtTemp.Rows.Count - 1
                                    cn.Execute("Insert into THERIAQUE.FCPMAFS_CIPEMG_AFSSAPS values (" & dtTemp.Rows(intj)(0) & "," & cn.SQLText(SP_) & "," & cn.SQLDate(Date_) & ", " & cn.SQLText(DOC) & ")")
                                Next
                            End If

                        Case RUB_CDF.CIPET
                            Dim dtTemp As DataTable
                            dtTemp = cn.MySelect("select FCPTSP_FCPT_CODE_FK_PK from THERIAQUE.FCPTSP_CIPEMG_SPE where  FCPTSP_SP_CODE_FK_PK = " & CodE)
                            If dtTemp.Rows.Count > 0 Then
                                For intj As Integer = 0 To dtTemp.Rows.Count - 1
                                    cn.Execute("Insert into THERIAQUE.FCPTAFS_CIPEMG_AFSSAPS values (" & dtTemp.Rows(intj)(0) & "," & cn.SQLText(SP_) & "," & cn.SQLDate(Date_) & ", " & cn.SQLText(DOC) & ")")
                                Next
                            End If

                        Case RUB_CDF.Conducteur
                            Dim dtTemp As DataTable
                            dtTemp = cn.MySelect("select FCOSP_FCO_CODE_FK_PK from THERIAQUE.FCOSP_CONDUCTEUR_SPEC where  FCOSP_SP_CODE_FK_PK = " & CodE)
                            If dtTemp.Rows.Count > 0 Then
                                For intj As Integer = 0 To dtTemp.Rows.Count - 1
                                    cn.Execute("Insert into THERIAQUE.FCOAFS_FCO_AFSSAPS values (" & dtTemp.Rows(intj)(0) & "," & cn.SQLText(SP_) & "," & cn.SQLDate(Date_) & ", " & cn.SQLText(DOC) & ")")
                                Next
                            End If

                        Case RUB_CDF.EI_DOSE_THERAPEUTIQUE
                            Dim dtTemp As DataTable
                            dtTemp = cn.MySelect("select FEISP_FEI_CODE_FK_PK from THERIAQUE.FEISP_EFFINDSPE where FEISP_SP_CODE_FK_PK = " & CodE)
                            If dtTemp.Rows.Count > 0 Then
                                For intj As Integer = 0 To dtTemp.Rows.Count - 1
                                    cn.Execute("Insert into THERIAQUE.FEIAFS_EFFETIND_AFSSAPS values (" & dtTemp.Rows(intj)(0) & "," & cn.SQLText(SP_) & "," & cn.SQLDate(Date_) & ", 'T' , " & cn.SQLText(DOC) & ")")
                                Next
                            End If

                        Case RUB_CDF.EI_SURDOSAGE
                            Dim dtTemp As DataTable
                            dtTemp = cn.MySelect("select FEISP_FEI_CODE_FK_PK from THERIAQUE.FEISP_EFFINDSPE where FEISP_SP_CODE_FK_PK = " & CodE)
                            If dtTemp.Rows.Count > 0 Then
                                For intj As Integer = 0 To dtTemp.Rows.Count - 1
                                    cn.Execute("Insert into THERIAQUE.FEIAFS_EFFETIND_AFSSAPS values (" & dtTemp.Rows(intj)(0) & "," & cn.SQLText(SP_) & "," & cn.SQLDate(Date_) & ", 'S' , " & cn.SQLText(DOC) & ")")
                                Next
                            End If

                        Case RUB_CDF.ETIOLOGIE
                            Dim dtTemp As DataTable
                            dtTemp = cn.MySelect("select FETSP_FET_CODE_FK_PK from THERIAQUE.FETSP_ETIOSPE where FETSP_SP_CODE_FK_PK = " & CodE)
                            If dtTemp.Rows.Count > 0 Then
                                For intj As Integer = 0 To dtTemp.Rows.Count - 1
                                    cn.Execute("Insert into THERIAQUE.FETAFS_FET_AFSSAPS values (" & dtTemp.Rows(intj)(0) & "," & cn.SQLText(SP_) & "," & cn.SQLDate(Date_) & ", " & cn.SQLText(DOC) & ")")
                                Next
                            End If

                        Case RUB_CDF.La_rubrique_GROSSESSE
                            Dim dtTemp As DataTable
                            dtTemp = cn.MySelect("select FGASP_FGA_CODE_FK_PK from THERIAQUE.FGASP_GRALSPE where  FGASP_SP_CODE_FK_PK = " & CodE)
                            If dtTemp.Rows.Count > 0 Then
                                For intj As Integer = 0 To dtTemp.Rows.Count - 1
                                    cn.Execute("Insert into THERIAQUE.FGAAFS_FGA_AFSSAPS values (" & dtTemp.Rows(intj)(0) & "," & cn.SQLText(SP_) & "," & cn.SQLDate(Date_) & ", 'G' , " & cn.SQLText(DOC) & ")")
                                Next
                            End If

                        Case RUB_CDF.INDICATION
                            Dim dtTemp As DataTable
                            dtTemp = cn.MySelect("select FINSP_FIN_CODE_FK_PK from THERIAQUE.FINSP_INDSPE where FINSP_SP_CODE_FK_PK = " & CodE)
                            If dtTemp.Rows.Count > 0 Then
                                For intj As Integer = 0 To dtTemp.Rows.Count - 1
                                    cn.Execute("Insert into THERIAQUE.FINAFS_FIN_AFSSAPS values (" & dtTemp.Rows(intj)(0) & "," & cn.SQLText(SP_) & "," & cn.SQLDate(Date_) & "," & cn.SQLText(DOC) & ")")
                                Next
                            End If

                        Case RUB_CDF.INTERACTION_RCP
                            Dim dtTemp As DataTable
                            dtTemp = cn.MySelect("select FIRCPSP_FIRCP_CODE_FK_PK from THERIAQUE.FIRCPSP_INTERACTRCP_SPEC where FIRCPSP_SP_CODE_FK_PK  = " & CodE)
                            If dtTemp.Rows.Count > 0 Then
                                For intj As Integer = 0 To dtTemp.Rows.Count - 1
                                    cn.Execute("Insert into THERIAQUE.FIRCPAFS_FIRCP_AFSSAPS values (" & dtTemp.Rows(intj)(0) & "," & cn.SQLText(SP_) & "," & cn.SQLDate(Date_) & ",  " & cn.SQLText(DOC) & ")")
                                Next
                            End If

                        Case RUB_CDF.PHARMACOCINETIQUE
                            Dim dtTemp As DataTable
                            dtTemp = cn.MySelect("select FPHCOSP_FPHCO_CODE_FK_PK from THERIAQUE.FPHCOSP_PHARMACOCIN_SPEC where FPHCOSP_SP_CODE_FK_PK = " & CodE)
                            If dtTemp.Rows.Count > 0 Then
                                For intj As Integer = 0 To dtTemp.Rows.Count - 1
                                    cn.Execute("Insert into THERIAQUE.FPHCOAFS_FPHCO_AFSSAPS values (" & dtTemp.Rows(intj)(0) & "," & cn.SQLText(SP_) & "," & cn.SQLDate(Date_) & ",  " & cn.SQLText(DOC) & ")")
                                Next
                            End If

                        Case RUB_CDF.POSOLOGIE
                            Dim dtTemp As DataTable
                            dtTemp = cn.MySelect("select FPOSP_FPO_CODE_FK_PK from THERIAQUE.FPOSP_POSO_SPE where FPOSP_SP_CODE_FK_PK = " & CodE)
                            If dtTemp.Rows.Count > 0 Then
                                For intj As Integer = 0 To dtTemp.Rows.Count - 1
                                    cn.Execute("Insert into THERIAQUE.FPOAFS_POSO_AFSSAPS values (" & dtTemp.Rows(intj)(0) & "," & cn.SQLText(SP_) & "," & cn.SQLDate(Date_) & ", " & cn.SQLText(DOC) & ")")
                                Next
                            End If

                        Case RUB_CDF.RECONSTITUTION_ADMINISTR
                            Dim dtTemp As DataTable
                            dtTemp = cn.MySelect("select FRECSP_FREC_CODE_FK_PK from THERIAQUE.FRECSP_RECONST_SPEC where FRECSP_SP_CODE_FK_PK = " & CodE)
                            If dtTemp.Rows.Count > 0 Then
                                For intj As Integer = 0 To dtTemp.Rows.Count - 1
                                    cn.Execute("Insert into THERIAQUE.FRECAFS_FREC_AFSSAPS values (" & dtTemp.Rows(intj)(0) & "," & cn.SQLText(SP_) & "," & cn.SQLDate(Date_) & ", " & cn.SQLText(DOC) & ")")
                                Next
                            End If

                        Case RUB_CDF.SECURITE_PRECLINIQUE
                            Dim dtTemp As DataTable
                            dtTemp = cn.MySelect("select FPRCLSP_FPRCL_CODE_FK_PK from THERIAQUE.FPRCLSP_SECPRECLIN_SPEC where FPRCLSP_SP_CODE_FK_PK = " & CodE)
                            If dtTemp.Rows.Count > 0 Then
                                For intj As Integer = 0 To dtTemp.Rows.Count - 1
                                    cn.Execute("Insert into THERIAQUE.FPRCLAFS_FPRCL_AFSSAPS values (" & dtTemp.Rows(intj)(0) & "," & cn.SQLText(SP_) & "," & cn.SQLDate(Date_) & " , " & cn.SQLText(DOC) & ")")
                                Next
                            End If
                        Case Else
                            cn.Execute("Insert into THERIAQUE.SPAFS_SPECIALITE_AFSSAPS values (" & cn.SQLText(RUBCDF) & "," & cn.SQLText(SP_) & "," & cn.SQLDate(Date_) & "," & cn.SQLText(DOC) & ", NULL)")
                    End Select
                End If
                If GV.GetRowCellValue(POS, Me.colaction) = SUPP Then
                    '------------------------------
                    '------------------------------
                    ' Suppression
                    '------------------------------
                    Select Case GV.GetRowCellValue(POS, Me.colSPAFS_RUBCDF_NUMERO_PK)

                        Case RUB_CDF.Classe_Pharmaco, RUB_CDF.SPECIALITE_
                            Dim strTemp As String = ""
                            strTemp = "  Delete from THERIAQUE.SPAFS_SPECIALITE_AFSSAPS "
                            strTemp &= " where SPAFS_SP_CODE_FK_PK = " & CodE
                            strTemp &= " and SPAFS_RUBCDF_NUMERO_PK = " & cn.SQLText(RUBCDF)
                            strTemp &= " and SPAFS_DATE_PK = " & cn.SQLDate(Date_)
                            strTemp &= " and SPAFS_CDF_CODE_DOC_FK_PK = " & DOC
                            cn.Execute(strTemp)

                        Case RUB_CDF.Composition, RUB_CDF.Condition_Presciption, RUB_CDF.Conservation, RUB_CDF.Dénomination, RUB_CDF.Forme_Phramaceutique
                            Dim strTemp As String = ""
                            strTemp = "  Delete from THERIAQUE.SPAFS_SPECIALITE_AFSSAPS "
                            strTemp &= " where SPAFS_SP_CODE_FK_PK = " & CodE
                            strTemp &= " and SPAFS_RUBCDF_NUMERO_PK = " & cn.SQLText(RUBCDF)
                            strTemp &= " and SPAFS_DATE_PK = " & cn.SQLDate(Date_)
                            strTemp &= " and SPAFS_CDF_CODE_DOC_FK_PK = " & DOC
                            cn.Execute(strTemp)

                        Case RUB_CDF.La_Liste, RUB_CDF.La_presentation, RUB_CDF.La_voie_dadministration, RUB_CDF.Le_conditionnement__La_présentation, RUB_CDF.Le_laboratoire_exploitant, RUB_CDF.Le_laboratoire_titulaire, RUB_CDF.Le_statut
                            Dim strTemp As String = ""
                            strTemp = "  Delete from THERIAQUE.SPAFS_SPECIALITE_AFSSAPS "
                            strTemp &= " where SPAFS_SP_CODE_FK_PK = " & CodE
                            strTemp &= " and SPAFS_RUBCDF_NUMERO_PK = " & cn.SQLText(RUBCDF)
                            strTemp &= " and SPAFS_DATE_PK = " & cn.SQLDate(Date_)
                            strTemp &= " and SPAFS_CDF_CODE_DOC_FK_PK = " & DOC
                            cn.Execute(strTemp)

                        Case RUB_CDF.La_rubrique_ALLAITEMENT
                            Dim strTemp As String = ""
                            strTemp = "  Delete  from THERIAQUE.FGAAFS_FGA_AFSSAPS "
                            strTemp &= " where FGAAFS_SP_CODE_FK_PK = " & CodE
                            strTemp &= " and FGAAFS_DATE_PK = " & cn.SQLDate(Date_)
                            strTemp &= " and FGAAFS_TYPEGRAL_PK = " & "'A'"
                            strTemp &= " and FGAAFS_CDF_DOCUMENT_FK_PK = " & DOC
                            cn.Execute(strTemp)

                        Case RUB_CDF.CIPEC
                            Dim strTemp As String = ""
                            strTemp = "  Delete  from THERIAQUE.FCPMAFS_CIPEMG_AFSSAPS "
                            strTemp &= " where FCPMAFS_SP_CODE_FK_PK = " & CodE
                            strTemp &= " and FCPMAFS_DATE_PK = " & cn.SQLDate(Date_)
                            strTemp &= " and FCPMAFS_CDF_DOCUMENT_FK_PK = " & DOC
                            cn.Execute(strTemp)

                        Case RUB_CDF.CIPET
                            Dim strTemp As String = ""
                            strTemp = "  Delete  from THERIAQUE.FCPTAFS_CIPEMG_AFSSAPS "
                            strTemp &= " where FCPTAFS_SP_CODE_FK_PK = " & CodE
                            strTemp &= " and FCPTAFS_DATE_PK = " & cn.SQLDate(Date_)
                            strTemp &= " and FCPTAFS_CDF_DOCUMENT_FK_PK = " & DOC
                            cn.Execute(strTemp)

                        Case RUB_CDF.Conducteur
                            Dim strTemp As String = ""
                            strTemp = "  Delete  from THERIAQUE.FCOAFS_FCO_AFSSAPS "
                            strTemp &= " where FCOAFS_SP_CODE_FK_PK = " & CodE
                            strTemp &= " and FCOAFS_DATE_PK = " & cn.SQLDate(Date_)
                            strTemp &= " and FCOAFS_CDF_DOCUMENT_FK_PK = " & DOC
                            cn.Execute(strTemp)

                        Case RUB_CDF.EI_DOSE_THERAPEUTIQUE
                            Dim strTemp As String = ""
                            strTemp = "  Delete  from THERIAQUE.FEIAFS_EFFETIND_AFSSAPS "
                            strTemp &= " where FEIAFS_SP_CODE_FK_PK = " & CodE
                            strTemp &= " and FEIAFS_DATE_PK = " & cn.SQLDate(Date_)
                            strTemp &= " and FEIAFS_CDF_DOCUMENT_FK_PK = " & DOC
                            strTemp &= " and FEIAFS_TYPEDOSE_THSURD_PK = " & "'T'"
                            cn.Execute(strTemp)

                        Case RUB_CDF.EI_SURDOSAGE
                            Dim strTemp As String = ""
                            strTemp = "  Delete  from THERIAQUE.FEIAFS_EFFETIND_AFSSAPS "
                            strTemp &= " where FEIAFS_SP_CODE_FK_PK = " & CodE
                            strTemp &= " and FEIAFS_DATE_PK = " & cn.SQLDate(Date_)
                            strTemp &= " and FEIAFS_CDF_DOCUMENT_FK_PK = " & DOC
                            strTemp &= " and FEIAFS_TYPEDOSE_THSURD_PK = " & "'S'"
                            cn.Execute(strTemp)

                        Case RUB_CDF.ETIOLOGIE
                            Dim strTemp As String = ""
                            strTemp = "  Delete  from THERIAQUE.FETAFS_FET_AFSSAPS "
                            strTemp &= " where FETAFS_SP_CODE_FK_PK = " & CodE
                            strTemp &= " and FETAFS_DATE_PK = " & cn.SQLDate(Date_)
                            strTemp &= " and FETAFS_CDF_DOCUMENT_FK_PK = " & DOC
                            cn.Execute(strTemp)

                        Case RUB_CDF.La_rubrique_GROSSESSE
                            Dim strTemp As String = ""
                            strTemp = "  Delete  from THERIAQUE.FGAAFS_FGA_AFSSAPS "
                            strTemp &= " where FGAAFS_SP_CODE_FK_PK = " & CodE
                            strTemp &= " and FGAAFS_DATE_PK = " & cn.SQLDate(Date_)
                            strTemp &= " and FGAAFS_TYPEGRAL_PK = " & "'G'"
                            strTemp &= " and FGAAFS_CDF_DOCUMENT_FK_PK = " & DOC
                            cn.Execute(strTemp)

                        Case RUB_CDF.INDICATION
                            Dim strTemp As String = ""
                            strTemp = "  Delete  from THERIAQUE.FINAFS_FIN_AFSSAPS "
                            strTemp &= " where FINAFS_SP_CODE_FK_PK = " & CodE
                            strTemp &= " and FINAFS_DATE_PK = " & cn.SQLDate(Date_)
                            strTemp &= " and FINAFS_CDF_DOCUMENT_FK_PK = " & DOC
                            cn.Execute(strTemp)

                        Case RUB_CDF.INTERACTION_RCP
                            Dim strTemp As String = ""
                            strTemp = "  Delete  from THERIAQUE.FIRCPAFS_FIRCP_AFSSAPS "
                            strTemp &= " where FIRCPAFS_SP_CODE_FK_PK = " & CodE
                            strTemp &= " and FIRCPAFS_DATE_PK = " & cn.SQLDate(Date_)
                            strTemp &= " and FIRCPAFS_CDF_DOCUMENT_FK_PK = " & DOC
                            cn.Execute(strTemp)

                        Case RUB_CDF.PHARMACOCINETIQUE
                            Dim strTemp As String = ""
                            strTemp = "  Delete  from THERIAQUE.FPHCOAFS_FPHCO_AFSSAPS "
                            strTemp &= " where FPHCOAFS_SP_CODE_FK_PK = " & CodE
                            strTemp &= " and FPHCOAFS_DATE_PK = " & cn.SQLDate(Date_)
                            strTemp &= " and FPHCOAFS_CDF_DOCUMENT_FK_PK = " & DOC
                            cn.Execute(strTemp)

                        Case RUB_CDF.POSOLOGIE
                            Dim strTemp As String = ""
                            strTemp = "  Delete  from THERIAQUE.FPOAFS_POSO_AFSSAPS "
                            strTemp &= " where FPOAFS_SP_CODE_FK_PK = " & CodE
                            strTemp &= " and FPOAFS_DATE_PK = " & cn.SQLDate(Date_)
                            strTemp &= " and FPOAFS_CDF_DOCUMENT_FK_PK = " & DOC
                            cn.Execute(strTemp)

                        Case RUB_CDF.RECONSTITUTION_ADMINISTR
                            Dim strTemp As String = ""
                            strTemp = "  Delete  from THERIAQUE.FRECAFS_FREC_AFSSAPS "
                            strTemp &= " where FRECAFS_SP_CODE_FK_PK = " & CodE
                            strTemp &= " and FRECAFS_DATE_PK = " & cn.SQLDate(Date_)
                            strTemp &= " and FRECAFS_CDF_DOCUMENT_FK_PK = " & DOC
                            cn.Execute(strTemp)

                        Case RUB_CDF.SECURITE_PRECLINIQUE
                            Dim strTemp As String = ""
                            strTemp = "  Delete From THERIAQUE.FPRCLAFS_FPRCL_AFSSAPS "
                            strTemp &= " where FPRCLAFS_SP_CODE_FK_PK = " & CodE
                            strTemp &= " and FPRCLAFS_DATE_PK = " & cn.SQLDate(Date_)
                            strTemp &= " and FPRCLAFS_CDF_DOCUMENT_FK_PK = " & DOC
                            cn.Execute(strTemp)

                        Case Else
                            Dim strTemp As String = ""
                            strTemp = "  Delete from THERIAQUE.SPAFS_SPECIALITE_AFSSAPS "
                            strTemp &= " where SPAFS_SP_CODE_FK_PK = " & CodE
                            strTemp &= " and SPAFS_RUBCDF_NUMERO_PK = " & cn.SQLText(RUBCDF)
                            strTemp &= " and SPAFS_DATE_PK = " & cn.SQLDate(Date_)
                            strTemp &= " and SPAFS_CDF_CODE_DOC_FK_PK = " & DOC
                            cn.Execute(strTemp)
                    End Select
                    GV.SetRowCellValue(POS, Me.colaction, Invisible)
                    POS -= 1
                End If
            End If
            POS += 1
        Next
        GV.FocusedRowHandle += 1
        GV.FocusedRowHandle -= 2
        GV.FocusedRowHandle += 1
        MyBase.Valider()
    End Sub

    Public Overrides Sub annuler()
        OnLoading = True
        MyBase.Annuler()
        If CodE <> Nothing Then

            OnLoading = True
            ProgressBar.Visible = True

            txtCode.Text = CodE
            txtLibelle.Text = ClsSP.GetLibelle(CodE)
            txtSynonyme.Text = ClsSP.GetSynonyme(CodE)

            BackgroundWorker.RunWorkerAsync()
        End If
        OnLoading = False
    End Sub

#End Region

    ''' <summary>
    ''' Chargement des données de la fiche
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub InitData()
        MyBase.InitData()
        OnLoading = True
        MasterDataSet = Me.DsTheriaque_Ref1
        MasterTable = SPAFS_SPECIALITE_AFSSAPS

        colaction.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("action1 <> '" & Invisible & "'")

        InitLkup(Me.rpRef, CDF_CODIF, strSSQL_CDF_CODIF("25"), True)
        InitLkup(Me.rpRUB, RUBCDF_RUBRIQUE_CODIFICATION, strSSQL_RUBCDF_RUBRIQUE_CODIFICATION, True)

        '-----------------------------
        '-----------------------------
        'CollectionSP.Add("CPH")
        CollectionSP.Add("SX")
        CollectionSP.Add("14S")
        CollectionSP.Add("03")
        CollectionSP.Add("L")
        CollectionSP.Add("06")
        CollectionSP.Add("08")
        'CollectionSP.Add("N")
        CollectionSP.Add("18")
        CollectionSP.Add("04")
        CollectionSP.Add("07E")
        CollectionSP.Add("07")
        CollectionSP.Add("14")
        CollectionSP.Add(RUB_CDF.La_rubrique_ALLAITEMENT)
        CollectionSP.Add("FCPM")
        CollectionSP.Add("FCPT")
        CollectionSP.Add("FCO")
        CollectionSP.Add("FEIT")
        CollectionSP.Add("FEIS")
        CollectionSP.Add("FET")
        CollectionSP.Add("FG")
        CollectionSP.Add("FIN")
        CollectionSP.Add("FIRCP")
        CollectionSP.Add("FPHCO")
        CollectionSP.Add("FPO")
        CollectionSP.Add("FREC")
        CollectionSP.Add("FPRCL")
        '-----------------------------
        '-----------------------------
        'CollectionCPH.Add("CPH")
        CollectionCPH.Add("14S")
        CollectionCPH.Add("L")
        CollectionCPH.Add("08")
        CollectionCPH.Add("07")
        CollectionCPH.Add("14")
        CollectionCPH.Add(RUB_CDF.La_rubrique_ALLAITEMENT)
        CollectionCPH.Add("FCPM")
        CollectionCPH.Add("FCPT")
        CollectionCPH.Add("FCO")
        CollectionCPH.Add("FEIT")
        CollectionCPH.Add("FEIS")
        CollectionCPH.Add("FET")
        CollectionCPH.Add("FG")
        CollectionCPH.Add("FIN")
        CollectionCPH.Add("FIRCP")
        CollectionCPH.Add("FPHCO")
        CollectionCPH.Add("FPO")
        CollectionCPH.Add("FREC")
        CollectionCPH.Add("FPRCL")
        '-----------------------------
        '-----------------------------
        FirstFocus = txtLibelle
        AddHandler GC.EmbeddedNavigator.ButtonClick, AddressOf DeleteRow
        OnLoading = False
    End Sub

    Private Sub btAjouter_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAjouter.EnabledChanged, btSupprimer.EnabledChanged
        If sender.Enabled Then
            sender.Enabled = False
        End If
    End Sub

    Private Sub GV_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV.FocusedRowChanged
        If GV.GetFocusedRowCellValue(Me.colaction) Is DBNull.Value Then Exit Sub

        If (GV.GetFocusedRowCellValue(Me.colaction) = CONSLT) Or (GV.GetFocusedRowCellValue(Me.colaction) = SUPP) Then
            Me.colaction.OptionsColumn.AllowFocus = False
            Me.colSPAFS_CDF_CODE_DOC_FK_PK.OptionsColumn.AllowFocus = False
            Me.colSPAFS_DATE_PK.OptionsColumn.AllowFocus = False
            Me.colSPAFS_RUBCDF_NUMERO_PK.OptionsColumn.AllowFocus = False
            Me.colSPAFS_SP_CODE_FK_PK.OptionsColumn.AllowFocus = False
            Me.colSPAFS_DATE_REVIS.OptionsColumn.AllowFocus = False
        Else
            Me.colaction.OptionsColumn.AllowFocus = False
            Me.colSPAFS_CDF_CODE_DOC_FK_PK.OptionsColumn.AllowFocus = True
            Me.colSPAFS_DATE_PK.OptionsColumn.AllowFocus = True
            Me.colSPAFS_RUBCDF_NUMERO_PK.OptionsColumn.AllowFocus = True
            Me.colSPAFS_SP_CODE_FK_PK.OptionsColumn.AllowFocus = True
            Me.colSPAFS_DATE_REVIS.OptionsColumn.AllowFocus = True
        End If
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.SetFocusedRowCellValue(colSPAFS_SP_CODE_FK_PK, txtCode.Text)
        GV.SetFocusedRowCellValue(colaction, ADD)
        ModeFiche = eMode.Ajout
        UpdateStateBouton()
    End Sub

    Private Sub GV_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow

        If GV.GetFocusedRowCellValue(Me.colaction) Is DBNull.Value Then Exit Sub
        '------------------------------------------
        '------------------------------------------
        ' Ajout d'une CPH
        '------------------------------------------
        '------------------------------------------
        Try
            If GV.GetFocusedRowCellValue(Me.colaction) = ADD Then
                If GV.GetFocusedRowCellValue(Me.colSPAFS_DATE_PK) Is DBNull.Value Then
                    e.Valid = False
                    e.ErrorText = StrValIncor
                    Exit Sub
                End If
                If GV.GetFocusedRowCellValue(Me.colSPAFS_RUBCDF_NUMERO_PK) Is DBNull.Value Then
                    e.Valid = False
                    e.ErrorText = StrValIncor
                    Exit Sub
                End If
                If GV.GetFocusedRowCellValue(Me.colSPAFS_CDF_CODE_DOC_FK_PK) Is DBNull.Value Then
                    e.Valid = False
                    e.ErrorText = StrValIncor
                    Exit Sub
                End If
                Dim vDate As String = GV.GetFocusedRowCellValue(Me.colSPAFS_DATE_PK)
                Dim vSPAFS_RUBCDF_NUMERO_PK As String = GV.GetFocusedRowCellValue(Me.colSPAFS_RUBCDF_NUMERO_PK)
                Dim vSPAFS_CDF_CODE_DOC_FK_PK As String = GV.GetFocusedRowCellValue(Me.colSPAFS_CDF_CODE_DOC_FK_PK)

                If vSPAFS_RUBCDF_NUMERO_PK = "CPH" Then
                    GV.SetFocusedRowCellValue(Me.colSPAFS_DATE_REVIS, Now.Date)
                    GV.SetFocusedRowCellValue(Me.colaction, ADD)
                    For inti As Integer = 1 To CollectionCPH.Count
                        GV.AddNewRow()
                        GV.SetFocusedRowCellValue(Me.colaction, ADD)
                        GV.SetFocusedRowCellValue(Me.colSPAFS_DATE_PK, vDate)
                        GV.SetFocusedRowCellValue(Me.colSPAFS_RUBCDF_NUMERO_PK, CollectionCPH(inti))
                        GV.SetFocusedRowCellValue(Me.colSPAFS_CDF_CODE_DOC_FK_PK, vSPAFS_CDF_CODE_DOC_FK_PK)
                    Next inti
                End If
                '------------------------------------------
                '------------------------------------------
                ' Ajout d'une SP
                '------------------------------------------
                '------------------------------------------
                If vSPAFS_RUBCDF_NUMERO_PK = "SP" Then
                    GV.SetFocusedRowCellValue(Me.colSPAFS_DATE_REVIS, Now.Date)
                    GV.SetFocusedRowCellValue(Me.colaction, ADD)
                    For inti As Integer = 1 To CollectionSP.Count
                        GV.AddNewRow()
                        GV.SetFocusedRowCellValue(Me.colaction, ADD)
                        GV.SetFocusedRowCellValue(Me.colSPAFS_DATE_PK, vDate)
                        GV.SetFocusedRowCellValue(Me.colSPAFS_RUBCDF_NUMERO_PK, CollectionSP(inti))
                        GV.SetFocusedRowCellValue(Me.colSPAFS_CDF_CODE_DOC_FK_PK, vSPAFS_CDF_CODE_DOC_FK_PK)
                    Next inti
                End If
            End If
        Catch ex As Exception
            e.Valid = False
            e.ErrorText = ex.Message
        End Try
    End Sub

    Private Function Get_Ref_Officiel() As String
        Dim strSSQL_REF_OFFICIEL As String = ""

        'SPECIALITE
        strSSQL_REF_OFFICIEL &= " select -1 as code,SPAFS_SP_CODE_FK_PK as sp, SPAFS_DATE_PK as date,SPAFS_CDF_CODE_DOC_FK_PK as doc , SPAFS_RUBCDF_NUMERO_PK as rub , SPAFS_DATE_REVIS as date_revis, '" & CONSLT & "' as action1 from THERIAQUE.SPAFS_SPECIALITE_AFSSAPS"
        strSSQL_REF_OFFICIEL &= " where SPAFS_SP_CODE_FK_PK  = " & CodE

        strSSQL_REF_OFFICIEL &= " Union "

        'la rubrique ALLAITEMENT
        strSSQL_REF_OFFICIEL &= " select FGAAFS_FGA_CODE_FK_PK as code, FGAAFS_SP_CODE_FK_PK as sp, FGAAFS_DATE_PK as date ,FGAAFS_CDF_DOCUMENT_FK_PK as doc, 'FA' as rub , NULL as date_revis, '" & CONSLT & "' as action1 from THERIAQUE.FGAAFS_FGA_AFSSAPS"
        strSSQL_REF_OFFICIEL &= " where FGAAFS_TYPEGRAL_PK = 'A' and "
        strSSQL_REF_OFFICIEL &= " FGAAFS_SP_CODE_FK_PK  = " & CodE

        strSSQL_REF_OFFICIEL &= " Union "

        'la rubrique GROSSESSE
        strSSQL_REF_OFFICIEL &= " select FGAAFS_FGA_CODE_FK_PK as code, FGAAFS_SP_CODE_FK_PK as sp, FGAAFS_DATE_PK as date ,FGAAFS_CDF_DOCUMENT_FK_PK as doc, 'FG' as rub , NULL as date_revis, '" & CONSLT & "' as action1  from THERIAQUE.FGAAFS_FGA_AFSSAPS"
        strSSQL_REF_OFFICIEL &= " where FGAAFS_TYPEGRAL_PK = 'G' and "
        strSSQL_REF_OFFICIEL &= " FGAAFS_SP_CODE_FK_PK  = " & CodE

        strSSQL_REF_OFFICIEL &= " Union "

        'CIPEMG
        strSSQL_REF_OFFICIEL &= " select FCPMAFS_FCPM_CODE_FK_PK as code, FCPMAFS_SP_CODE_FK_PK as sp, FCPMAFS_DATE_PK as date ,FCPMAFS_CDF_DOCUMENT_FK_PK as doc, 'FCPM' as rub , NULL as date_revis, '" & CONSLT & "' as action1  from THERIAQUE.FCPMAFS_CIPEMG_AFSSAPS"
        strSSQL_REF_OFFICIEL &= " where FCPMAFS_SP_CODE_FK_PK = " & CodE

        strSSQL_REF_OFFICIEL &= " Union "

        'CIPET
        strSSQL_REF_OFFICIEL &= " select FCPTAFS_FCPT_CODE_FK_PK as code, FCPTAFS_SP_CODE_FK_PK as sp, FCPTAFS_DATE_PK as date ,FCPTAFS_CDF_DOCUMENT_FK_PK as doc, 'FCPT' as rub , NULL as date_revis, '" & CONSLT & "' as action1  from THERIAQUE.FCPTAFS_CIPEMG_AFSSAPS"
        strSSQL_REF_OFFICIEL &= " where FCPTAFS_SP_CODE_FK_PK = " & CodE

        strSSQL_REF_OFFICIEL &= " Union "

        'la rubrique CONDUCTEUR 
        strSSQL_REF_OFFICIEL &= " select FCOAFS_FCO_CODE_FK_PK as code, FCOAFS_SP_CODE_FK_PK as sp, FCOAFS_DATE_PK as date ,FCOAFS_CDF_DOCUMENT_FK_PK as doc, 'FCO' as rub , NULL as date_revis, '" & CONSLT & "' as action1  from THERIAQUE.FCOAFS_FCO_AFSSAPS"
        strSSQL_REF_OFFICIEL &= " where FCOAFS_SP_CODE_FK_PK  = " & CodE

        strSSQL_REF_OFFICIEL &= " Union "

        'la rubrique EI DOSE THERAPEUTIQUE 
        strSSQL_REF_OFFICIEL &= " select FEIAFS_FEI_CODE_FK_PK as code, FEIAFS_SP_CODE_FK_PK as sp, FEIAFS_DATE_PK as date ,FEIAFS_CDF_DOCUMENT_FK_PK as doc, 'FEIT' as rub , NULL as date_revis, '" & CONSLT & "' as action1  from THERIAQUE.FEIAFS_EFFETIND_AFSSAPS"
        strSSQL_REF_OFFICIEL &= " where FEIAFS_SP_CODE_FK_PK = " & CodE
        strSSQL_REF_OFFICIEL &= " and FEIAFS_TYPEDOSE_THSURD_PK = 'T' "

        strSSQL_REF_OFFICIEL &= " Union "

        'la rubrique EI SURDOSAGE
        strSSQL_REF_OFFICIEL &= " select FEIAFS_FEI_CODE_FK_PK as code, FEIAFS_SP_CODE_FK_PK as sp, FEIAFS_DATE_PK as date ,FEIAFS_CDF_DOCUMENT_FK_PK as doc, 'FEIS' as rub , NULL as date_revis, '" & CONSLT & "' as action1  from THERIAQUE.FEIAFS_EFFETIND_AFSSAPS"
        strSSQL_REF_OFFICIEL &= " where FEIAFS_SP_CODE_FK_PK = " & CodE
        strSSQL_REF_OFFICIEL &= " and FEIAFS_TYPEDOSE_THSURD_PK = 'S' "

        strSSQL_REF_OFFICIEL &= " Union "

        'la rubrique ETIOLOGIE
        strSSQL_REF_OFFICIEL &= " select FETAFS_FET_CODE_FK_PK as code, FETAFS_SP_CODE_FK_PK as sp, FETAFS_DATE_PK as date ,FETAFS_CDF_DOCUMENT_FK_PK as doc, 'FET' as rub , NULL as date_revis, '" & CONSLT & "' as action1  from THERIAQUE.FETAFS_FET_AFSSAPS"
        strSSQL_REF_OFFICIEL &= " where FETAFS_SP_CODE_FK_PK  = " & CodE

        strSSQL_REF_OFFICIEL &= " Union "

        'la rubrique INDICATION
        strSSQL_REF_OFFICIEL &= " select FINAFS_FIN_CODE_FK_PK as code, FINAFS_SP_CODE_FK_PK as sp, FINAFS_DATE_PK as date ,FINAFS_CDF_DOCUMENT_FK_PK as doc, 'FIN' as rub , NULL as date_revis, '" & CONSLT & "' as action1  from THERIAQUE.FINAFS_FIN_AFSSAPS "
        strSSQL_REF_OFFICIEL &= " where FINAFS_SP_CODE_FK_PK = " & CodE

        strSSQL_REF_OFFICIEL &= " Union "

        'la rubrique INTERACTION RCP
        strSSQL_REF_OFFICIEL &= " select FIRCPAFS_FIRCP_CODE_FK_PK as code, FIRCPAFS_SP_CODE_FK_PK as sp, FIRCPAFS_DATE_PK as date ,FIRCPAFS_CDF_DOCUMENT_FK_PK as doc, 'FIRCP' as rub , NULL as date_revis, '" & CONSLT & "' as action1  from THERIAQUE.FIRCPAFS_FIRCP_AFSSAPS  "
        strSSQL_REF_OFFICIEL &= " where FIRCPAFS_SP_CODE_FK_PK  = " & CodE

        strSSQL_REF_OFFICIEL &= " Union "

        'la rubrique PHARMACOCINETIQUE 
        strSSQL_REF_OFFICIEL &= " select FPHCOAFS_FPHCO_CODE_FK_PK as code, FPHCOAFS_SP_CODE_FK_PK as sp, FPHCOAFS_DATE_PK as date ,FPHCOAFS_CDF_DOCUMENT_FK_PK as doc, 'FPHCO' as rub  , NULL as date_revis, '" & CONSLT & "' as action1 from THERIAQUE.FPHCOAFS_FPHCO_AFSSAPS  "
        strSSQL_REF_OFFICIEL &= " where FPHCOAFS_SP_CODE_FK_PK  = " & CodE

        strSSQL_REF_OFFICIEL &= " Union "

        'la rubrique POSOLOGIE  
        strSSQL_REF_OFFICIEL &= " select FPOAFS_FPO_CODE_FK_PK as code, FPOAFS_SP_CODE_FK_PK as sp, FPOAFS_DATE_PK as date ,FPOAFS_CDF_DOCUMENT_FK_PK as doc, 'FPO' as rub , NULL as date_revis, '" & CONSLT & "' as action1  from THERIAQUE.FPOAFS_POSO_AFSSAPS "
        strSSQL_REF_OFFICIEL &= " where FPOAFS_SP_CODE_FK_PK  =  " & CodE

        strSSQL_REF_OFFICIEL &= " Union "

        'la rubrique RECONSTITUTION/ADMINISTR
        strSSQL_REF_OFFICIEL &= " select FRECAFS_FREC_CODE_FK_PK as code, FRECAFS_SP_CODE_FK_PK as sp, FRECAFS_DATE_PK as date ,FRECAFS_CDF_DOCUMENT_FK_PK as doc, 'FREC' as rub  , NULL as date_revis, '" & CONSLT & "' as action1 from THERIAQUE.FRECAFS_FREC_AFSSAPS  "
        strSSQL_REF_OFFICIEL &= " where FRECAFS_SP_CODE_FK_PK  = " & CodE

        strSSQL_REF_OFFICIEL &= " Union "

        'la rubrique SECURITE PRECLINIQUE 
        strSSQL_REF_OFFICIEL &= " select FPRCLAFS_FPRCL_CODE_FK_PK as code, FPRCLAFS_SP_CODE_FK_PK as sp, FPRCLAFS_DATE_PK as date ,FPRCLAFS_CDF_DOCUMENT_FK_PK as doc, 'FPRCL' as rub , NULL as date_revis, '" & CONSLT & "' as action1  from THERIAQUE.FPRCLAFS_FPRCL_AFSSAPS "
        strSSQL_REF_OFFICIEL &= " where FPRCLAFS_SP_CODE_FK_PK = " & CodE
        Return strSSQL_REF_OFFICIEL

    End Function

    Private Sub BackgroundWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork
        OnLoading = True
        dtGC = cn.MySelect(Get_Ref_Officiel)
    End Sub

    Private Sub BackgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker.RunWorkerCompleted
        OnLoading = True
        GC.DataSource = dtGC
        ProgressBar.Visible = False
        OnLoading = False
    End Sub

    Structure RUB_CDF
        Shared ReadOnly SPECIALITE_ = "SP"
        Shared ReadOnly Classe_Pharmaco = "CPH"
        Shared ReadOnly Composition = "SX"
        Shared ReadOnly Condition_Presciption = "14S"
        Shared ReadOnly Conservation = "03"
        Shared ReadOnly Dénomination = "L"
        Shared ReadOnly Forme_Phramaceutique = "06"
        Shared ReadOnly La_Liste = "08"
        Shared ReadOnly La_presentation = "N"
        Shared ReadOnly La_voie_dadministration = "18"
        Shared ReadOnly Le_conditionnement__La_présentation = "04"
        Shared ReadOnly Le_laboratoire_exploitant = "07E"
        Shared ReadOnly Le_laboratoire_titulaire = "07"
        Shared ReadOnly Le_statut = "14"
        Shared ReadOnly La_rubrique_ALLAITEMENT = "FA"
        Shared ReadOnly La_rubrique_GROSSESSE = "FG"
        Shared ReadOnly CIPEC = "FCPM"
        Shared ReadOnly CIPET = "FCPT"
        Shared ReadOnly Conducteur = "FCO"
        Shared ReadOnly EI_DOSE_THERAPEUTIQUE = "FEIT"
        Shared ReadOnly EI_SURDOSAGE = "FEIS"
        Shared ReadOnly ETIOLOGIE = "FET"
        Shared ReadOnly INDICATION = "FIN"
        Shared ReadOnly INTERACTION_RCP = "FIRCP"
        Shared ReadOnly PHARMACOCINETIQUE = "FPHCO"
        Shared ReadOnly POSOLOGIE = "FPO"
        Shared ReadOnly RECONSTITUTION_ADMINISTR = "FREC"
        Shared ReadOnly SECURITE_PRECLINIQUE = "FPRCL"
        Dim Var ' ne pas effacer
    End Structure

    Public Sub DeleteRow(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        If e.Button.Tag = "SUPP" Then
            If GV.GetRowCellValue(Me.GV.FocusedRowHandle, Me.colaction) = ADD Then
                GV.DeleteRow(GV.FocusedRowHandle)
            Else
                If GV.GetRowCellValue(Me.GV.FocusedRowHandle, Me.colaction) IsNot DBNull.Value Then
                    GV.SetFocusedRowCellValue(Me.colaction, SUPP)
                    ModeFiche = eMode.Modification
                    UpdateStateBouton()
                End If
            End If
        End If
    End Sub

End Class
