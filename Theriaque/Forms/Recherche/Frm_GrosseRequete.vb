Imports Microsoft.Office.Interop
Imports System.Data.SqlClient
Public Class Frm_GrosseRequete
    Private CodE As String
    Public DataSet As New DataSet

#Region " Data Edit "

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_PRE_PRESENTATION
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            OnLoading = True
            EmptyDataTable()
            Me.PrE_TA.FillByCode(Me.DsTheriaque_GrosseRequete.PRE_PRESENTATION, CodE)
            Me.PretsS_TA.FillByCode(Me.DsTheriaque_GrosseRequete.PRETSS_PRESENTATION_TAUX, CodE)
            InitLkup(rpTauxRBS, CDF_CODIF, strSSQL_CDF_CODIF("17"), True)
            Dim strSSQL As String
            Dim sCodeSP As String
            strSSQL = "  SELECT PRE_SP_CODE_FK FROM THERIAQUE.PRE_PRESENTATION WHERE PRE_CODE_PK = " & cn.SQLText(CodE)
            Dim dt As DataTable = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                sCodeSP = dt.Rows(0)(0)
                Me.SP_TA.FillByCode(Me.DsTheriaque_GrosseRequete.SP_SPECIALITE, sCodeSP)
                strSSQL = ""
                strSSQL &= " select CATC_CODE_PK  into  #Yaks from THERIAQUE.CATC_CLASSEATC "
                strSSQL &= " except  "
                strSSQL &= " select CATC_CATC_CODE_FK From THERIAQUE.CATC_CLASSEATC "
                strSSQL &= " select #Yaks.CATC_CODE_PK as code, c.CATC_NOMF as libelle from #Yaks, THERIAQUE.CATC_CLASSEATC c "
                strSSQL &= " where c.CATC_CODE_PK = #Yaks.CATC_CODE_PK "
                strSSQL &= " drop table #Yaks "
                InitLkup(Me.lkupATC, CATC_CLASSEATC, strSSQL, True, False, True, True)
                InitLkup(Me.lkupATC2, CATC_CLASSEATC, strSSQL, True)
                Me.SpddD_TA.FillByCode(Me.DsTheriaque_GrosseRequete.SPDDD_DOSE_USUELLE_JOUR, sCodeSP)
                InitLkup(Me.lkupDDD, CDF_CODIF, strSSQL_CDF_CODIF("18"), False, False)
                InitLkup(Me.lkupDDD1, CDF_CODIF, strSSQL_CDF_CODIF("19"), False, False)

                strSSQL = strSSQL_CEPH_CLASSEEPHMRA
                strSSQL &= " where CEPH_CODE_PK  not in  "
                strSSQL &= " (Select distinct isnull(CEPH_CEPH_CODE_FK,'') From THERIAQUE.CEPH_CLASSEEPHMRA )"
                InitLkup(Me.lkupEphemra, CEPH_CLASSEEPHMRA, strSSQL, False, , , True)
                InitLkup(Me.lkupEphemra2, CEPH_CLASSEEPHMRA, strSSQL, True)
                btn_Extraire.Enabled = True
            End If
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub EmptyDataTable()
        Me.DsTheriaque_GrosseRequete.PRE_PRESENTATION.Clear()
        Me.DsTheriaque_GrosseRequete.SP_SPECIALITE.Clear()
        Me.DsTheriaque_GrosseRequete.SPDDD_DOSE_USUELLE_JOUR.Clear()
    End Sub
#End Region

    Private Sub btn_Extraire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Extraire.Click
        If Process_Message("Voulez vous extraire les données de cette présentation ? ", MsgBoxStyle.YesNo, MsgBoxStyle.Question).BtResult = MsgBoxResult.Yes Then
            Dim sPath As String
            SFDialogEnregistrer.Title = "Choisir un emplacement pour enregistrer le fichier Excel."
            SFDialogEnregistrer.InitialDirectory = "c:\"
            SFDialogEnregistrer.Filter = "Fichiers Excel (*.xls)|*.xls"
            SFDialogEnregistrer.FilterIndex = 2
            SFDialogEnregistrer.RestoreDirectory = True
            If SFDialogEnregistrer.ShowDialog() = DialogResult.OK Then
                sPath = SFDialogEnregistrer.FileName
                Try
                    Dim oExcel As New Microsoft.Office.Interop.Excel.Application
                    Dim oBook As Microsoft.Office.Interop.Excel.Workbook
                    Dim oSheet As Microsoft.Office.Interop.Excel.Worksheet

                    oBook = oExcel.Workbooks.Add
                    oSheet = oBook.Sheets(1)

                    'DEFINITION DES EN-TETE DE COLONNES
                    oSheet.Cells(1, 1) = "UCD"
                    oSheet.Cells(1, 2) = "CIS"
                    oSheet.Cells(1, 3) = "NUMÉRO INTERNE"
                    oSheet.Cells(1, 4) = "LIBELLÉ COURT"
                    oSheet.Cells(1, 5) = "LIBELLÉ LONG"
                    oSheet.Cells(1, 6) = "CODE ATC"
                    oSheet.Cells(1, 7) = "LIBELLE ATC"
                    oSheet.Cells(1, 8) = "VOIE"
                    oSheet.Cells(1, 9) = "DOSE"
                    oSheet.Cells(1, 10) = "UNITE"
                    oSheet.Cells(1, 11) = "CODE EPHEMRA"
                    oSheet.Cells(1, 12) = "LIBELLE EPHEMRA"
                    oSheet.Cells(1, 13) = "CODE EAN"
                    oSheet.Cells(1, 14) = "LIBELLE EAN"
                    oSheet.Cells(1, 15) = "ETAT COMMERCIAL"
                    oSheet.Cells(1, 16) = "DATE COMMERCIALE"
                    oSheet.Cells(1, 17) = "DATE ARRET COMMERCIAL"
                    oSheet.Cells(1, 18) = "AGREMENT"
                    oSheet.Cells(1, 19) = "DATE D'AGREMENT"
                    oSheet.Cells(1, 20) = "DATE JO"
                    oSheet.Cells(1, 21) = "DATE D'APPLICATION"

                    'CHARGEMENT DES DONNEES DANS LA FEUILLE EXCEL
                    oSheet.Cells(2, 1) = txtUCD.Text
                    oSheet.Cells(2, 2) = TxtCIS.Text
                    oSheet.Cells(2, 3) = TxtNumSP.Text
                    oSheet.Cells(2, 4) = TxtLibelleCourt.Text
                    oSheet.Cells(2, 5) = TxtLibelleLong.Text
                    oSheet.Cells(2, 6) = lkupATC.Text
                    oSheet.Cells(2, 7) = lkupATC2.Text
                    oSheet.Cells(2, 8) = lkupDDD.Text
                    oSheet.Cells(2, 9) = txtDDD_Dosage.Text
                    oSheet.Cells(2, 10) = lkupDDD1.Text
                    oSheet.Cells(2, 11) = lkupEphemra.Text
                    oSheet.Cells(2, 12) = lkupEphemra2.Text
                    oSheet.Cells(2, 13) = txtEAN.Text
                    oSheet.Cells(2, 14) = TextEdit5.Text
                    oSheet.Cells(2, 15) = cmbEtatComercial.Text
                    oSheet.Cells(2, 16) = DeditdispoDepuis.Text
                    oSheet.Cells(2, 17) = DeditSupp.Text
                    oSheet.Cells(2, 18) = ComboBoxEdit1.Text
                    oSheet.Cells(2, 19) = DateEdit4.Text
                    oSheet.Cells(2, 20) = DeditApplication.Text

                    oBook.SaveAs(sPath)
                    oExcel.Visible = True
                    Exit Sub
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            End If
        End If
    End Sub

    Private Sub btn_ExtraireTout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExtraireTout.Click
        If Process_Message("Voulez vous extraire toutes les données CIP ? ", MsgBoxStyle.YesNo, MsgBoxStyle.Question).BtResult = MsgBoxResult.Yes Then
            Try
                Dim sSql As String
                sSql = " SELECT DISTINCT SP.SP_CIPUCD AS UCD,"
                sSql &= " SP_NL AS CIS,"
                sSql &= " SP_CODE_SQ_PK AS NUMÉRO_INTERNE,"
                sSql &= " SP_NOM AS LIBELLÉ_COURT,"
                sSql &= " SP_NOMLONG AS LIBELLÉ_LONG,"
                sSql &= " CATC.CATC_CODE_PK  AS CODEATC,"
                sSql &= " CATC.CATC_NOMF AS LIBELLE_ATC,"
                sSql &= " CDF.CDF_NOM AS DDD_VOIE,"
                sSql &= " SPDDD_ATCDDD_DOSAGE_PK as Dose,"
                sSql &= " CDF2.CDF_NOM as Unité,"
                sSql &= " CEPH.CEPH_CODE_PK AS Code_EPHMRA,"
                sSql &= " CEPH.CEPH_NOMF AS libellé_EPHMRA,"
                sSql &= " PRE.PRE_CODE_PK as CIP,"
                sSql &= " PRE.PRE_EAN_REF as EAN,"
                sSql &= " PRE_ADMIN as Libellé_Présentation,"
                sSql &= " PRE_ETAT_COMMER as Etat_Commerciale,"
                sSql &= " PRE_DATECOMMER as Date_Commerciale,"
                sSql &= " PRE_DATESUP as Date_ArrêtCommerciale,"
                sSql &= " PRE_AGRCOLL as Agrément,"
                sSql &= " PRE_DATEJOCOLL as Date_Agrément,"
                sSql &= " PRE_DATEFINCOLL as Date_JO,"
                sSql &= " PRE_DATE_APPLIFINCOLL as Date_Application"
                sSql &= " FROM THERIAQUE.PRE_PRESENTATION PRE, THERIAQUE.SP_SPECIALITE SP"
                sSql &= " LEFT OUTER JOIN THERIAQUE.SPDDD_DOSE_USUELLE_JOUR SPDDD ON  SPDDD_SP_CODE_FK_PK = SP.SP_CODE_SQ_PK"
                sSql &= " LEFT OUTER JOIN THERIAQUE.CDF_CODIF CDF ON  SPDDD.SPDDD_ATCDDD_CDF_VO_CODE_FK_PK = CDF.CDF_CODE_PK AND CDF.CDF_NUMERO_PK = '18'"
                sSql &= " LEFT OUTER JOIN THERIAQUE.CDF_CODIF CDF2 ON  SPDDD.SPDDD_ATCDDD_CDF_UD_CODE_FK_PK = CDF2.CDF_CODE_PK AND CDF2.CDF_NUMERO_PK = '19'"
                sSql &= " LEFT OUTER JOIN THERIAQUE.CEPH_CLASSEEPHMRA CEPH ON  CEPH.CEPH_CODE_PK = SP.SP_CEPH_CODE_FK"
                sSql &= " LEFT OUTER JOIN THERIAQUE.CATC_CLASSEATC CATC ON  CATC.CATC_CODE_PK = SP.SP_CATC_CODE_FK "
                sSql &= " WHERE PRE.PRE_SP_CODE_FK = SP.SP_CODE_SQ_PK"


                Dim sPath As String
                SFDialogEnregistrer.Title = "Choisir un emplacement pour enregistrer le fichier Excel."
                SFDialogEnregistrer.InitialDirectory = "c:\"
                SFDialogEnregistrer.Filter = "Fichiers Excel (*.xls)|*.xls"
                SFDialogEnregistrer.FilterIndex = 2
                SFDialogEnregistrer.RestoreDirectory = True
                If SFDialogEnregistrer.ShowDialog() = DialogResult.OK Then
                    sPath = SFDialogEnregistrer.FileName
                    Try


                        Dim oExcel As New Excel.Application
                        Dim oBook As Excel.Workbook
                        Dim oSheet As Excel.Worksheet
                        Dim oCells As Excel.Range


                        Dim daGrosseRequete As New SqlDataAdapter(New SqlCommand(sSql, Me.PrE_TA.Connection))
                        Dim dtGrosseRequete As New DataTable
                        daGrosseRequete.Fill(dtGrosseRequete)

                        'Start nouveau workbook
                        oBook = oExcel.Workbooks.Add
                        oSheet = oBook.Sheets(1)
                        oCells = oSheet.Cells
                        DumpData(dtGrosseRequete, oCells) 'Fill in the data

                        oSheet.SaveAs(sPath) 'Enregistrer le fichier
                        'oBook.Close()
                        'oExcel.Quit()
                        oExcel.Visible = True
                        'oExcel = Nothing : oBooks = Nothing : oBook = Nothing
                        'oSheets = Nothing : oSheet = Nothing : oCells = Nothing
                        System.GC.Collect()



                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Erreur...")
                    End Try
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erreur...")
            End Try
        End If
    End Sub
    Private Sub DumpData(ByVal dt As DataTable, ByVal oCells As Excel.Range)
        Dim dr As DataRow, ary() As Object
        Dim iRow As Integer, iCol As Integer
        'Output Column Headers
        For iCol = 0 To dt.Columns.Count - 1
            oCells(2, iCol + 1) = dt.Columns(iCol).ToString
        Next
        'Output Data
        For iRow = 0 To dt.Rows.Count - 1
            ProgressBar.Visible = True
            ProgressBar.Value += 1
            ProgressBar.Maximum = dt.Rows.Count
            dr = dt.Rows.Item(iRow)
            ary = dr.ItemArray
            For iCol = 0 To UBound(ary)
                oCells(iRow + 3, iCol + 1) = ary(iCol).ToString
            Next
        Next
        ProgressBar.Value = 0
        ProgressBar.Visible = False
    End Sub

End Class
