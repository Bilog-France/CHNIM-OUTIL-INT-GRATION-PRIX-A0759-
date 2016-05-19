Public Class ClsPosologieDose
    Private OK_Min As Boolean = True
    Private OK_Max As Boolean = True
    Private OK_MaxparJour As Boolean = True
    Private OK_MinparJour As Boolean = True
    Private OK As Boolean = True

    Private UnitePrise_PPV As String

    Private DoseMinV As String
    Private DoseMaxV As String

    Private dtPP As DataTable
    Private dtPF As DataTable

    Private PRE_CODEV As String

    Private FrequenceMaxV As Integer
    Private FrequenceMinV As Integer
    Private UniteFrequenceMaxV As String
    Private UniteFrequenceMinV As String

    Private DoseparPriseMinV As Decimal
    Private DoseparPriseMaxV As Decimal

    Private DoseparJourMinV As Decimal
    Private DoseparJourMaxV As Decimal

    Private UCD_PARPRISE_MINV As StructResultPosologieUCD
    Private UCD_PARPRISE_MAXV As StructResultPosologieUCD

    Private UCD_PARJOUR_MINV As StructResultPosologieUCD
    Private UCD_PARJOUR_MAXV As StructResultPosologieUCD

    Property PRE_CODE() As String
        Get
            Return PRE_CODEV
        End Get
        Set(ByVal value As String)
            PRE_CODEV = value
        End Set
    End Property

    ReadOnly Property DoseparPriseMin() As Integer
        Get
            Return DoseparPriseMinV
        End Get

    End Property

    ReadOnly Property DoseparPriseMax() As Integer
        Get
            Return DoseparPriseMaxV
        End Get

    End Property

    ReadOnly Property DoseparJourMin() As Integer
        Get
            Return DoseparJourMinV
        End Get

    End Property

    ReadOnly Property DoseparJourMax() As Integer
        Get
            Return DoseparJourMaxV
        End Get

    End Property

    Property UnitePrise_PP() As String
        Get
            Return UnitePrise_PPV
        End Get
        Set(ByVal value As String)
            UnitePrise_PPV = value
        End Set
    End Property

    Property DoseMin() As String
        Get
            Return DoseMinV
        End Get
        Set(ByVal value As String)
            If value = Nothing Or value = "ADAPTER" Then
                OK_Min = False
                OK_MinparJour = False
                DoseMinV = Nothing
                Exit Property
            End If
            OK_Min = True
            OK_MinparJour = True
            DoseMinV = value
        End Set
    End Property

    Property DoseMax() As String
        Get
            Return DoseMaxV
        End Get
        Set(ByVal value As String)
            If value = Nothing Or value = "ADAPTER" Then
                OK_Max = False
                OK_MaxparJour = False
                DoseMaxV = Nothing
                Exit Property
            End If
            OK_Max = True
            OK_MaxparJour = True
            DoseMaxV = value
        End Set
    End Property

    Property FrequenceMin() As Integer
        Get
            Return FrequenceMinV
        End Get
        Set(ByVal value As Integer)
            If value = Nothing Then
                FrequenceMinV = value
                OK = False
                Exit Property
            End If
            OK = True
            FrequenceMinV = value
        End Set
    End Property

    Property FrequenceMax() As Integer
        Get
            Return FrequenceMaxV
        End Get
        Set(ByVal value As Integer)
            If value = Nothing Then
                FrequenceMaxV = value
                OK = False
                Exit Property
            End If
            OK = True
            FrequenceMaxV = value
        End Set
    End Property

    Property UniteFrequenceMin() As String
        Get
            Return UniteFrequenceMinV
        End Get
        Set(ByVal value As String)
            If value = Nothing Then
                OK = False
                UniteFrequenceMinV = value
                Exit Property
            End If
            OK = True
            UniteFrequenceMinV = value
        End Set
    End Property

    Property UniteFrequenceMax() As String
        Get
            Return UniteFrequenceMaxV
        End Get
        Set(ByVal value As String)
            If value = Nothing Then
                OK = False
                UniteFrequenceMaxV = value
                Exit Property
            End If
            OK = True
            UniteFrequenceMaxV = value
        End Set
    End Property

    ReadOnly Property UCD_PARPRISE_MIN() As StructResultPosologieUCD
        Get
            Return UCD_PARPRISE_MINV
        End Get

    End Property

    ReadOnly Property UCD_PARPRISE_MAX() As StructResultPosologieUCD
        Get
            Return UCD_PARPRISE_MAXV
        End Get
    End Property

    ReadOnly Property UCD_PARJOUR_MIN() As StructResultPosologieUCD
        Get
            Return UCD_PARJOUR_MINV
        End Get

    End Property

    ReadOnly Property UCD_PARJOUR_MAX() As StructResultPosologieUCD
        Get
            Return UCD_PARJOUR_MAXV
        End Get
    End Property

    Public Function ExecuteDoseparJour() As Boolean
        If TestApplicable() Then
            If UnitePrise_PPV(0) <> "G" And UnitePrise_PPV(5) = "Z" Then
                'LIEN AVEC « FREQUENCE »
                If UnitePrise_PPV(6) = "F" Then
                    Dim DJ1, DJ2, DJ3, DJ4 As Decimal
                    DJ1 = 0
                    DJ2 = 0
                    DJ3 = 0
                    DJ4 = 0
                    If (DoseMinV <> Nothing Or FrequenceMinV <> Nothing) Then
                        OK_MinparJour = True
                    End If

                    If OK_MinparJour Then
                        If UniteFrequenceMinV <> Nothing Then
                            dtPF = cn.MySelect("Select * From THERIAQUE.CDFTE_TABLE_EQUIVALENCE where CDFTE_NUMERO_PK = 'PF' and CDFTE_CODE_PK = " & cn.SQLText(UniteFrequenceMinV))
                            If dtPF.Rows.Count > 0 Then
                                If dtPF.Rows(0)("CDFTE_APPLICABLE") IsNot DBNull.Value Then
                                    If dtPF.Rows(0)("CDFTE_APPLICABLE") = "O" Then
                                        If DoseMinV <> Nothing And FrequenceMinV <> Nothing Then
                                            If (dtPF.Rows(0)("CDFTE_COEFFICIENT") IsNot System.DBNull.Value) Then
                                                DJ1 = (DoseMinV * FrequenceMinV) / dtPF.Rows(0)("CDFTE_COEFFICIENT")
                                            End If
                                        End If
                                        If OK_MaxparJour Then
                                            If DoseMaxV <> Nothing And FrequenceMinV <> Nothing Then
                                                If (dtPF.Rows(0)("CDFTE_COEFFICIENT") IsNot System.DBNull.Value) Then
                                                    DJ3 = (DoseMaxV * FrequenceMinV) / dtPF.Rows(0)("CDFTE_COEFFICIENT")
                                                End If
                                            Else
                                                OK_MaxparJour = False
                                            End If
                                        End If
                                    Else
                                        OK_MinparJour = False
                                    End If
                                Else
                                    OK_MinparJour = False
                                End If
                            End If
                        End If
                    End If
                    If (DoseMaxV <> Nothing Or FrequenceMaxV <> Nothing) Then
                        OK_MaxparJour = True
                    End If
                    If OK_MaxparJour Then
                        dtPF = cn.MySelect("Select * From THERIAQUE.CDFTE_TABLE_EQUIVALENCE where CDFTE_NUMERO_PK = 'PF' and CDFTE_CODE_PK = " & cn.SQLText(UniteFrequenceMaxV))
                        If (dtPF.Rows.Count > 0) Then
                            If dtPF.Rows(0)("CDFTE_APPLICABLE") IsNot DBNull.Value Then
                                If dtPF.Rows(0)("CDFTE_APPLICABLE") = "O" Then
                                    If DoseMaxV <> Nothing And FrequenceMaxV <> Nothing Then
                                        If (dtPF.Rows(0)("CDFTE_COEFFICIENT") IsNot System.DBNull.Value) Then
                                            If (dtPF.Rows(0)("CDFTE_COEFFICIENT") <> 0) Then
                                                DJ4 = (DoseMaxV * FrequenceMaxV) / dtPF.Rows(0)("CDFTE_COEFFICIENT")
                                            End If
                                        End If
                                    End If
                                    If OK_MinparJour Then
                                        If DoseMinV <> Nothing And FrequenceMaxV <> Nothing Then
                                            If (dtPF.Rows(0)("CDFTE_COEFFICIENT") IsNot System.DBNull.Value) Then
                                                DJ2 = (DoseMinV * FrequenceMaxV) / dtPF.Rows(0)("CDFTE_COEFFICIENT")
                                            End If
                                        End If
                                    End If
                                Else
                                    OK_MaxparJour = False
                                End If
                            Else
                                OK_MaxparJour = False
                            End If
                        End If
                    End If
                    'déterminer le minimum des 4 valeurs
                    DoseparJourMinV = 0
                    If DJ1 <> 0 Then
                        DoseparJourMinV = DJ1

                    End If
                    If DJ2 <> 0 Then
                        If DoseparJourMinV <> 0 Then
                            If DJ2 < DoseparJourMinV Then
                                DoseparJourMinV = DJ2
                            End If
                        Else
                            DoseparJourMinV = DJ2
                            OK_MinparJour = True
                        End If
                    End If
                    If DJ3 <> 0 Then
                        If DoseparJourMinV <> 0 Then
                            If DJ3 < DoseparJourMinV Then
                                DoseparJourMinV = DJ3
                            End If
                        Else
                            DoseparJourMinV = DJ3
                            OK_MinparJour = True
                        End If
                    End If
                    If DJ4 <> 0 Then
                        If DoseparJourMinV <> 0 Then
                            If DJ4 < DoseparJourMinV Then
                                DoseparJourMinV = DJ4
                            End If
                        Else
                            DoseparJourMinV = DJ4
                            OK_MinparJour = True
                        End If
                    End If


                    'déterminer le maximuum des 4 valeurs
                    DoseparJourMaxV = 0
                    If DJ1 <> 0 Then
                        DoseparJourMaxV = DJ1
                    End If
                    If DJ2 <> 0 Then
                        If DoseparJourMaxV <> 0 Then
                            If DJ2 > DoseparJourMaxV Then
                                DoseparJourMaxV = DJ2
                            End If
                        Else
                            DoseparJourMaxV = DJ2
                        End If
                    End If
                    If DJ3 <> 0 Then
                        If DoseparJourMaxV <> 0 Then
                            If DJ3 > DoseparJourMaxV Then
                                DoseparJourMaxV = DJ3
                            End If
                        Else
                            DoseparJourMaxV = DJ3
                        End If
                    End If
                    If DJ4 <> 0 Then
                        If DoseparJourMaxV <> 0 Then
                            If DJ4 > DoseparJourMaxV Then
                                DoseparJourMaxV = DJ4
                            End If
                        Else
                            DoseparJourMaxV = DJ4
                            OK_MaxparJour = True
                        End If
                    End If
                End If
                'PAS DE LIEN AVEC « FREQUENCE »
                If UnitePrise_PPV(6) = "Z" Then
                    If DoseMaxV <> Nothing Then
                        OK_MinparJour = True
                    End If
                    If OK_MinparJour Then
                        If DoseMinV <> Nothing Then
                            DoseparJourMinV = DoseMinV / Coefficient_Duree_Journaliere(dtPP.Rows(0)("CDFIUP_COEFDUR_CDF_CODE_FK"))
                        Else
                            If DoseMaxV <> Nothing Then
                                DoseparJourMinV = DoseMaxV / Coefficient_Duree_Journaliere(dtPP.Rows(0)("CDFIUP_COEFDUR_CDF_CODE_FK"))
                            End If
                        End If

                    End If
                    If OK_MaxparJour Then
                        If DoseMaxV <> Nothing Then
                            DoseparJourMaxV = DoseMaxV / Coefficient_Duree_Journaliere(dtPP.Rows(0)("CDFIUP_COEFDUR_CDF_CODE_FK"))
                        Else
                            If DoseMinV <> Nothing Then
                                DoseparJourMaxV = DoseMinV / Coefficient_Duree_Journaliere(dtPP.Rows(0)("CDFIUP_COEFDUR_CDF_CODE_FK"))
                            End If
                        End If
                    End If
                End If

                If OK_MinparJour Then UCD_PARJOUR_MINV = ConvertUCD(DoseparJourMinV)
                If OK_MaxparJour Then UCD_PARJOUR_MAXV = ConvertUCD(DoseparJourMaxV)
            End If
        End If
    End Function

    Public Function ExecuteDoseparPrise() As Boolean

        If TestApplicable() Then
            If (Not String.IsNullOrEmpty(DoseMinV)) Then
                DoseMinV = DoseMinV.Replace(".", ",")
            End If
            If (Not String.IsNullOrEmpty(DoseMaxV)) Then
                DoseMaxV = DoseMaxV.Replace(".", ",")
            End If
            If UnitePrise_PPV(0) <> "G" And UnitePrise_PPV(5) = "Z" Then
                'LIEN AVEC « FREQUENCE »
                If UnitePrise_PPV(6) = "Z" Then
                    Dim Q1, Q2, Q3, Q4 As Decimal
                    Q1 = 0
                    Q2 = 0
                    Q3 = 0
                    Q4 = 0
                    If DoseMaxV <> Nothing And FrequenceMinV <> Nothing Then
                        OK_Min = True
                    End If

                    If DoseMaxV <> Nothing And FrequenceMinV <> Nothing Then
                        OK_Min = True
                    End If



                    If OK_Min Then
                        If UniteFrequenceMinV <> Nothing Then
                            dtPF = cn.MySelect("Select * From THERIAQUE.CDFTE_TABLE_EQUIVALENCE where CDFTE_NUMERO_PK = 'PF' and CDFTE_CODE_PK = " & cn.SQLText(UniteFrequenceMinV))
                            If dtPF.Rows.Count > 0 Then
                                If dtPF.Rows(0)("CDFTE_APPLICABLE") IsNot DBNull.Value Then
                                    If dtPF.Rows(0)("CDFTE_APPLICABLE") = "O" Then
                                        If DoseMinV <> Nothing And FrequenceMinV <> Nothing Then
                                            Q1 = (DoseMinV / FrequenceMinV) / dtPF.Rows(0)("CDFTE_COEFFICIENT")
                                        End If
                                        If OK_Max Then
                                            If DoseMaxV <> Nothing And FrequenceMinV <> Nothing Then
                                                Q3 = (DoseMaxV / FrequenceMinV) / dtPF.Rows(0)("CDFTE_COEFFICIENT")
                                            Else
                                                OK_Max = False
                                            End If
                                        End If
                                        'If DoseMinV = Nothing And FrequenceMinV <> Nothing And DoseMaxV <> Nothing Then
                                        '    DoseparPriseMinV = DoseMaxV * FrequenceMinV / dtPF.Rows(0)("CDFTE_COEFFICIENT")
                                        'End If
                                    Else
                                        OK_Min = False
                                    End If
                                Else
                                    OK_Min = False
                                End If
                            End If
                        End If
                    End If
                    If OK_Max Then
                        dtPF = cn.MySelect("Select * From THERIAQUE.CDFTE_TABLE_EQUIVALENCE where CDFTE_NUMERO_PK = 'PF' and CDFTE_CODE_PK = " & cn.SQLText(UniteFrequenceMaxV))
                        If (dtPF.Rows.Count > 0) Then
                            If dtPF.Rows(0)("CDFTE_APPLICABLE") IsNot DBNull.Value Then
                                If dtPF.Rows(0)("CDFTE_APPLICABLE") = "O" Then
                                    If DoseMaxV <> Nothing And FrequenceMaxV <> Nothing Then
                                        Q4 = (DoseMaxV / FrequenceMaxV) / dtPF.Rows(0)("CDFTE_COEFFICIENT")
                                    End If
                                    If OK_Min Then
                                        If DoseMinV <> Nothing And FrequenceMaxV <> Nothing Then
                                            Q2 = (DoseMinV / FrequenceMaxV) / dtPF.Rows(0)("CDFTE_COEFFICIENT")
                                            'Else
                                            '    OK_Min = False
                                        End If
                                    End If
                                Else
                                    OK_Max = False
                                End If
                            Else
                                OK_Max = False
                            End If
                        End If
                    End If
                    'déterminer le minimum des 4 valeurs
                    DoseparPriseMinV = 0
                    If Q1 <> 0 Then
                        DoseparPriseMinV = Q1
                    End If
                    If Q2 <> 0 Then
                        If DoseparPriseMinV <> 0 Then
                            If Q2 < DoseparPriseMinV Then
                                DoseparPriseMinV = Q2
                            End If
                        Else
                            DoseparPriseMinV = Q2
                            OK_Min = True
                        End If
                    End If
                    If Q3 <> 0 Then
                        If DoseparPriseMinV <> 0 Then
                            If Q3 < DoseparPriseMinV Then
                                DoseparPriseMinV = Q3
                            End If
                        Else
                            DoseparPriseMinV = Q3
                            OK_Min = True
                        End If
                    End If
                    If Q4 <> 0 Then
                        If DoseparPriseMinV <> 0 Then
                            If Q4 < DoseparPriseMinV Then
                                DoseparPriseMinV = Q4
                            End If
                        Else
                            DoseparPriseMinV = Q4
                            OK_Min = True
                        End If
                    End If

                    'déterminer le maximuum des 4 valeurs
                    DoseparPriseMaxV = 0
                    If Q1 <> 0 Then
                        DoseparPriseMaxV = Q1
                    End If
                    If Q2 <> 0 Then
                        If DoseparPriseMaxV <> 0 Then
                            If Q2 > DoseparPriseMaxV Then
                                DoseparPriseMaxV = Q2
                            End If
                        Else
                            DoseparPriseMaxV = Q2
                            OK_Max = True
                        End If
                    End If
                    If Q3 <> 0 Then
                        If DoseparPriseMaxV <> 0 Then
                            If Q3 > DoseparPriseMaxV Then
                                DoseparPriseMaxV = Q3
                            End If
                        Else
                            DoseparPriseMaxV = Q3
                            OK_Max = True
                        End If
                    End If
                    If Q4 <> 0 Then
                        If DoseparPriseMaxV <> 0 Then
                            If Q4 > DoseparPriseMaxV Then
                                DoseparPriseMaxV = Q4
                            End If
                        Else
                            DoseparPriseMaxV = Q4
                            OK_Max = True
                        End If
                    End If
                End If

                'PAS DE LIEN AVEC « FREQUENCE »
                If UnitePrise_PPV(6) = "F" Then

                    'TODO: A vérifier 
                    If DoseMaxV <> Nothing And FrequenceMaxV <> Nothing Then
                        OK_Min = True
                    End If

                    If OK_Min Then
                        If (DoseMinV <> Nothing) Then
                            DoseparPriseMinV = DoseMinV
                        Else
                            If (DoseMaxV <> Nothing) Then
                                DoseparPriseMinV = DoseMaxV
                                OK_Max = True
                            End If
                        End If

                    End If
                    If OK_Max Then
                        If (DoseMaxV <> Nothing) Then
                            DoseparPriseMaxV = DoseMaxV
                        Else
                            If (DoseMinV <> Nothing) Then
                                DoseparPriseMaxV = DoseMinV
                                OK_Max = True
                            End If
                        End If
                    End If
                End If
                If OK_Min Then UCD_PARPRISE_MINV = ConvertUCD(DoseparPriseMinV)
                If OK_Max Then UCD_PARPRISE_MAXV = ConvertUCD(DoseparPriseMaxV)
            End If
        End If
    End Function

    Private Function TestApplicable() As Boolean
        dtPP = cn.MySelect("Select * from THERIAQUE.CDFIUP_INFO_UNITE_PRISE WHERE CDFIUP_CODE_PK = " & cn.SQLText(UnitePrise_PPV))
        If dtPP.Rows.Count > 0 Then
            If dtPP.Rows(0)("CDFIUP_APPLICABLE") IsNot DBNull.Value Then
                If dtPP.Rows(0)("CDFIUP_APPLICABLE") = "O" Then
                    Return True
                Else
                    OK = False
                    Return False
                End If
            Else
                OK = False
                Return False
            End If
        Else
            OK = False
            Return False
        End If

    End Function

    ReadOnly Property _OK() As Boolean
        Get
            Return OK
        End Get
    End Property

    Function Coefficient_Duree_Journaliere(ByVal coef As String) As Integer
        Select Case coef
            Case "A" 'AN(S)
                Return 365
            Case "B1" 'SECONDE(S)
                Return 1 / (60 * 60 * 24)
            Case "C" 'AUCUNE INFORMATION
                Return -1
            Case "E" 'MINUTE(S)
                Return 1 / (60 * 24)
            Case "H" 'HEURE(S)
                Return 1 / 24
            Case "J" 'JOUR(S)
                Return 1
            Case "J01" 'JOUR(S)
                Return 1
            Case "M" 'MOIS
                Return 30
            Case "S" 'SEMAINE(S)
                Return 7
            Case "S01"
                Return 7
            Case "Z06" 'PENDANT 72 HEURES
                Return 3
            Case "Z07" 'PENDANT 144 HEURES
                Return 6
        End Select

    End Function

    Public Function TestCoherence_UP_Contenant(ByVal Code_SP As Integer) As Boolean
        Dim bOk As Boolean = True
        Dim dt As DataTable = cn.MySelect("Select DISTINCT PRE_CDF_UP_CODE_FK from THERIAQUE.PRE_PRESENTATION where PRE_SP_CODE_FK = " & Code_SP)
        If dt.Rows.Count > 1 Then
            bOk = False
        End If
        Return bOk
    End Function

    Public Function TestCoherence_UDT_UCD(ByVal Code_SP As Integer) As Boolean
        Dim bOk As Boolean = True
        '15 mai 09
        'Toutes les présentations rattachées doit avoir le même contenant : FLACON(S)) et la même unité de dose totale UCD (MG)
        'Test sur PREDISP_SAC_CODE_FK 
        Dim dt As DataTable = cn.MySelect("SELECT DISTINCT PREDISP_PRE_CODE_FK_PK, COUNT(PREDISP_SAC_CODE_FK), SUM(PREDISP_SAC_CODE_FK) FROM THERIAQUE.PREDISP_PRE_DISPENSATION WHERE PREDISP_PRE_CODE_FK_PK IN(SELECT PRE_CODE_PK FROM THERIAQUE.PRE_PRESENTATION WHERE PRE_SP_CODE_FK = " & Code_SP & ") GROUP BY PREDISP_PRE_CODE_FK_PK")
        If dt.Rows.Count > 0 Then
            Dim sNbrDoseUCDperPRE = dt.Rows(0)(1)
            Dim sSumDoseUCDperPRE = dt.Rows(0)(2)
            For iCount As Integer = 1 To dt.Rows.Count - 1
                If (sSumDoseUCDperPRE Is System.DBNull.Value) Then
                    If (dt.Rows(iCount)(2) IsNot System.DBNull.Value) Then
                        bOk = False
                        Exit Function
                    Else
                        If dt.Rows(iCount)(1) <> sNbrDoseUCDperPRE Then
                            bOk = False
                            Exit Function
                        End If
                    End If

                Else
                    If (dt.Rows(iCount)(2) Is System.DBNull.Value) Then
                        bOk = False
                        Exit Function
                    Else
                        If dt.Rows(iCount)(1) <> sNbrDoseUCDperPRE Or dt.Rows(iCount)(2) <> sSumDoseUCDperPRE Then
                            bOk = False
                            Exit Function
                        End If
                    End If
                    
                End If
            Next
        Else
            bOk = False
        End If

        'Test sur PREDISP_CDF_UD_CODE_FK 
        dt = cn.MySelect("SELECT DISTINCT PREDISP_CDF_UD_CODE_FK FROM THERIAQUE.PREDISP_PRE_DISPENSATION WHERE PREDISP_PRE_CODE_FK_PK IN(SELECT PRE_CODE_PK FROM THERIAQUE.PRE_PRESENTATION WHERE PRE_SP_CODE_FK = " & Code_SP & ")")
        If dt.Rows.Count > 1 Then
            'bOk = False
            Return bOk
            Exit Function
        End If
        Return bOk
    End Function

    Private Function ConvertUCD(ByVal DoseJournaliere As Double) As StructResultPosologieUCD
        Dim Res As New StructResultPosologieUCD
        Select Case UnitePrise_PPV(0)
            Case "A"
                Dim dt1 As DataTable
                dt1 = cn.MySelect(strSSQL_CDF_CODIF("20", " and CDF_CODE_PK =" & cn.SQLText(CInt(Mid(UnitePrise_PPV, 2, 4)))))
                If (dt1.Rows.Count > 1) Then
                    Res.CODE_UCD = dt1.Rows(0)("code")
                    Res.Libelle_UCD = dt1.Rows(0)("libelle")
                End If
                Res.Valeur = DoseJournaliere
                Return Res
            Case "B"
                Dim dt1 As DataTable
                dt1 = cn.MySelect(strSSQL_CDF_CODIF("04", " and CDF_CODE_PK =" & cn.SQLText(CInt(Mid(UnitePrise_PPV, 2, 4)))))
                If (dt1.Rows.Count > 1) Then
                    Res.CODE_UCD = dt1.Rows(0)("code")
                    Res.Libelle_UCD = dt1.Rows(0)("libelle")
                End If
                Res.Valeur = DoseJournaliere
                Return Res
            Case "C" 'unité de contenance
                Dim nbUnitePrise As Integer = ClsPRE.GetNBUnite(PRE_CODEV)
                Dim dt1 As New DataTable
                dt1 = cn.MySelect(strSSQL_CDF_CODIF("20", " and CDF_CODE_PK =" & cn.SQLText(CInt(Mid(UnitePrise_PPV, 2, 4)))))
                If (dt1.Rows.Count > 1) Then
                    Res.CODE_UCD = dt1.Rows(0)("code")
                    Res.Libelle_UCD = dt1.Rows(0)("libelle")
                End If
                If nbUnitePrise <> Nothing Then
                    Res.Valeur = DoseJournaliere / nbUnitePrise
                Else
                    dtPF = cn.MySelect("Select * From THERIAQUE.CDFTE_TABLE_EQUIVALENCE where  CDFTE_NUMERO_PK = '20' and CDFTE_CODE_PK = " & cn.SQLText(CInt(Mid(UnitePrise_PPV, 2, 4))))
                    If (dtPF.Rows.Count > 0) Then
                        If (dtPF.Rows(0)("CDFTE_COEFFICIENT") IsNot System.DBNull.Value) Then
                            Dim coeff As String = ClsPRE.GetNBContenance(PRE_CODEV)
                            If (coeff <> 0) Then
                                Res.Valeur = DoseJournaliere * dtPF.Rows(0)("CDFTE_COEFFICIENT") / coeff
                            End If
                        End If
                    End If

                    End If
                    Return Res
            Case "D" '(unités gravimétriques) 
                    Dim dt1 As DataTable
                    dt1 = cn.MySelect(strSSQL_CDF_CODIF("19", " and CDF_CODE_PK =" & cn.SQLText(CInt(Mid(UnitePrise_PPV, 2, 4)))))

                    If (dt1.Rows.Count > 1) Then
                        Res.CODE_UCD = dt1.Rows(0)("code")
                        Res.Libelle_UCD = dt1.Rows(0)("libelle")
                    End If

                    If ClsPRE.GetUniteDispensation(PRE_CODEV) <> 0 Then Res.Valeur = DoseJournaliere / ClsPRE.GetUniteDispensation(PRE_CODEV)
                    Return Res
            Case "F" '(unités standard) 
                    Dim dt1 As DataTable
                    dt1 = cn.MySelect(strSSQL_CDF_CODIF("19", " and CDF_CODE_PK =" & cn.SQLText(CInt(Mid(UnitePrise_PPV, 2, 4)))))
                    If (dt1.Rows.Count > 1) Then
                        Res.CODE_UCD = dt1.Rows(0)("code")
                        Res.Libelle_UCD = dt1.Rows(0)("libelle")
                    End If

                    If ClsPRE.GetUniteDispensation(PRE_CODEV) <> 0 Then Res.Valeur = DoseJournaliere / ClsPRE.GetUniteDispensation(PRE_CODEV)
                    Return Res
            Case "E" ' (unités volumétriques)
                    Dim dt1 As DataTable
                    dt1 = cn.MySelect(strSSQL_CDF_CODIF("21", " and CDF_CODE_PK =" & cn.SQLText(CInt(Mid(UnitePrise_PPV, 2, 4)))))
                    If (dt1.Rows.Count > 1) Then
                        Res.CODE_UCD = dt1.Rows(0)("code")
                        Res.Libelle_UCD = dt1.Rows(0)("libelle")
                    End If
                    If ClsPRE.GetNBContenance(PRE_CODEV) <> 0 Then Res.Valeur = DoseJournaliere / ClsPRE.GetNBContenance(PRE_CODEV)
                    Return Res
        End Select
    End Function

    Public Function GetPosoByAllSpecs(ByVal SP_CODES As String) As DataTable

        Dim strSSQL As String = ""
        Dim codePoso As String = ""
        Dim array As String()
        Dim b As Boolean
        Dim result As String = ""

        strSSQL &= " SELECT distinct FPOSP_FPO_CODE_FK_PK FROM THERIAQUE.FPOSP_POSO_SPE "
        array = SP_CODES.Split(",")

        If array.Length > 0 Then
            strSSQL &= " WHERE (FPOSP_FPO_CODE_FK_PK in (SELECT FPOSP_FPO_CODE_FK_PK FROM THERIAQUE.FPOSP_POSO_SPE  where FPOSP_SP_CODE_FK_PK=" & array(0) & ")) "

        End If

        For i As Integer = 1 To array.Length - 1
            If (Not String.IsNullOrEmpty(array(i))) Then
                strSSQL &= " or (FPOSP_FPO_CODE_FK_PK in (SELECT FPOSP_FPO_CODE_FK_PK FROM THERIAQUE.FPOSP_POSO_SPE  where FPOSP_SP_CODE_FK_PK=" & array(i) & ")) "
            End If
        Next

        Dim dt As DataTable = cn.MySelect(strSSQL)
        Return dt

    End Function

    Public Function IsSPinPoso(ByVal CodePoso As String, ByVal SP_UCD As String) As Boolean
        Dim strSSQL As String = ""

        strSSQL &= " SELECT s.SP_MONO_VIRTUELLE, s.SP_CODE_SQ_PK FROM THERIAQUE.FPOSP_POSO_SPE p, THERIAQUE.SP_SPECIALITE s "
        strSSQL &= " where p.FPOSP_SP_CODE_FK_PK = s.SP_CODE_SQ_PK and "
        strSSQL &= " ( (s.SP_MONO_VIRTUELLE <> 1 and s.SP_CIPUCD = '" & SP_UCD & "') or (s.SP_MONO_VIRTUELLE = 1) ) "

        strSSQL &= " and p.FPOSP_FPO_CODE_FK_PK = '" & CodePoso & "'"
        Dim dt As DataTable = cn.MySelect(strSSQL)

        If (dt.Rows.Count = 0) Then
            Return False
        Else
            For i As Integer = 0 To dt.Rows.Count - 1

                If (dt.Rows(i).Item(0) = False) Then
                    Return True
                End If

                If (dt.Rows(i).Item(0) = True) Then
                    If (GetCodeVirtuel(dt.Rows(i).Item(1)) = SP_UCD) Then
                        Return True
                    End If
                End If

            Next
            Return False
        End If

    End Function


    Private ReadOnly Property GetCodeVirtuel(ByVal SP_CODE As Integer) As String
        Get
            Dim strSSQL As String = ""
            strSSQL &= " SELECT GSP_CODE_VIRTUEL FROM THERIAQUE.GSP_GENERIQUE_SPECIALITE"
            strSSQL &= " WHERE GSP_CODE_SQ_PK =(SELECT SP_GSP_CODE_FK FROM THERIAQUE.SP_SPECIALITE WHERE SP_CODE_SQ_PK = " & SP_CODE & ")"
            Dim dt As DataTable = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)(0).ToString
            End If
        End Get
    End Property

    Public Sub DeleteResult(ByVal CodePoso As String)
        Dim strSSQL As String = ""
        strSSQL &= " delete FROM THERIAQUE.IPODOSE_INFOPOSO "
        strSSQL &= " WHERE IPODOSE_FPO_CODE_FK_PK = " & CodePoso

        cn.Execute(strSSQL)
    End Sub


    Public Sub DeleteDureeResult(ByVal CodePoso As String)
        Dim strSSQL As String = ""
        strSSQL &= " delete FROM THERIAQUE.IPODUREE_INFOPOSO "
        strSSQL &= " WHERE IPODUREE_FPO_CODE_PK_FK = " & CodePoso

        cn.Execute(strSSQL)
    End Sub

    Public Function MaxId() As Integer

        Dim strSSQL As String = ""
        strSSQL &= " SELECT isnull(max(ID),0) FROM THERIAQUE.IPODOSE_INFOPOSO "
        Dim dt As DataTable = cn.MySelect(strSSQL)
        Return dt.Rows(0)(0)

    End Function

    Public Function GetPosoBySpec(ByVal SP_CODE As Integer) As DataTable
        Dim strSSQL As String = ""
        strSSQL &= " SELECT FPOSP_FPO_CODE_FK_PK FROM THERIAQUE.FPOSP_POSO_SPE"
        strSSQL &= " WHERE FPOSP_SP_CODE_FK_PK = " & SP_CODE
        Dim dt As DataTable = cn.MySelect(strSSQL)
        Return dt
    End Function


    Public Function GetPosoInfoByCode(ByVal CODE As Integer) As DataTable
        Dim strSSQL As String = ""
        strSSQL &= " SELECT * FROM THERIAQUE.IPO_INFOPOSO"
        strSSQL &= " WHERE IPO_FPO_CODE_FK_PK = " & CODE
        Dim dt As DataTable = cn.MySelect(strSSQL)
        Return dt
    End Function


    Public Shared Function GetSPIndicationFPO(ByVal strSSQL As String) As DataTable

        Dim dt As DataTable = cn.MySelect(strSSQL)
        Return dt
    End Function


    Public Function Get_MAX(ByVal Table As DataTable, ByVal strField As String) As Decimal
        Dim max As Decimal
        max = 0
        For i As Integer = 0 To Table.Rows.Count - 1
            If Table.Rows(i)(strField) > max Then
                max = Table.Rows(i)(strField)
            End If
        Next
        Return max
    End Function

    Public Function Get_MIN(ByVal Table As DataTable, ByVal strField As String) As Decimal
        Dim min As Decimal
        min = 10000
        For i As Integer = 0 To Table.Rows.Count - 1
            If Table.Rows(i)(strField) < min And Table.Rows(i)(strField) <> 0 Then
                min = Table.Rows(i)(strField)
            End If
        Next
        If min = 10000 Then
            Return 0
        Else
            Return min
        End If
    End Function

    Public Function ExecuteDoseparPriseMonoVirtuelle(ByVal NumContenant As Integer, ByVal VolumeInitial As Decimal, ByVal VolumeCourant As Decimal) As Boolean
        If TestApplicable() Then
            If (Not String.IsNullOrEmpty(DoseMinV)) Then
                DoseMinV = DoseMinV.Replace(".", ",")
            End If
            If (Not String.IsNullOrEmpty(DoseMaxV)) Then
                DoseMaxV = DoseMaxV.Replace(".", ",")
            End If
            If DoseMaxV <> Nothing And FrequenceMinV <> Nothing Then
                OK_Min = True
            End If
            If UnitePrise_PPV(0) <> "G" And UnitePrise_PPV(5) = "Z" Then
                'LIEN AVEC « FREQUENCE »
                If UnitePrise_PPV(6) = "Z" Then
                    Dim Q1, Q2, Q3, Q4 As Decimal
                    Q1 = 0
                    Q2 = 0
                    Q3 = 0
                    Q4 = 0
                    If OK_Min Then
                        If UniteFrequenceMinV <> Nothing Then
                            dtPF = cn.MySelect("Select * From THERIAQUE.CDFTE_TABLE_EQUIVALENCE where CDFTE_NUMERO_PK = 'PF' and CDFTE_CODE_PK = " & cn.SQLText(UniteFrequenceMinV))
                            If dtPF.Rows.Count > 0 Then
                                If dtPF.Rows(0)("CDFTE_APPLICABLE") IsNot DBNull.Value Then
                                    If dtPF.Rows(0)("CDFTE_APPLICABLE") = "O" Then
                                        If DoseMinV <> Nothing And FrequenceMinV <> Nothing Then
                                            Q1 = (DoseMinV / FrequenceMinV) / dtPF.Rows(0)("CDFTE_COEFFICIENT")
                                        End If
                                        If OK_Max Then
                                            If DoseMaxV <> Nothing And FrequenceMinV <> Nothing Then
                                                Q3 = (DoseMaxV / FrequenceMinV) / dtPF.Rows(0)("CDFTE_COEFFICIENT")
                                            Else
                                                OK_Max = False
                                            End If
                                        End If
                                        'If DoseMinV = Nothing And FrequenceMinV <> Nothing And DoseMaxV <> Nothing Then
                                        '    DoseparPriseMinV = DoseMaxV * FrequenceMinV / dtPF.Rows(0)("CDFTE_COEFFICIENT")
                                        'End If
                                    Else
                                        OK_Min = False
                                    End If
                                Else
                                    OK_Min = False
                                End If
                            End If
                        End If
                    End If
                    If OK_Max Then
                        dtPF = cn.MySelect("Select * From THERIAQUE.CDFTE_TABLE_EQUIVALENCE where CDFTE_NUMERO_PK = 'PF' and CDFTE_CODE_PK = " & cn.SQLText(UniteFrequenceMaxV))
                        If (dtPF.Rows.Count > 0) Then
                            If dtPF.Rows(0)("CDFTE_APPLICABLE") IsNot DBNull.Value Then
                                If dtPF.Rows(0)("CDFTE_APPLICABLE") = "O" Then
                                    If DoseMaxV <> Nothing And FrequenceMaxV <> Nothing Then
                                        Q4 = (DoseMaxV / FrequenceMaxV) / dtPF.Rows(0)("CDFTE_COEFFICIENT")
                                    End If
                                    If OK_Min Then
                                        If DoseMinV <> Nothing And FrequenceMaxV <> Nothing Then
                                            Q2 = (DoseMinV / FrequenceMaxV) / dtPF.Rows(0)("CDFTE_COEFFICIENT")
                                        Else
                                            OK_Min = False
                                        End If
                                    End If
                                Else
                                    OK_Max = False
                                End If
                            Else
                                OK_Max = False
                            End If
                        End If
                    End If
                    'déterminer le minimum des 4 valeurs
                    DoseparPriseMinV = 0
                    If Q1 <> 0 Then
                        DoseparPriseMinV = Q1
                    End If
                    If Q2 <> 0 Then
                        If DoseparPriseMinV <> 0 Then
                            If Q2 < DoseparPriseMinV Then
                                DoseparPriseMinV = Q2
                            End If
                        Else
                            DoseparPriseMinV = Q2
                        End If
                    End If
                    If Q3 <> 0 Then
                        If DoseparPriseMinV <> 0 Then
                            If Q3 < DoseparPriseMinV Then
                                DoseparPriseMinV = Q3
                            End If
                        Else
                            DoseparPriseMinV = Q3
                        End If
                    End If
                    If Q4 <> 0 Then
                        If DoseparPriseMinV <> 0 Then
                            If Q4 < DoseparPriseMinV Then
                                DoseparPriseMinV = Q4
                            End If
                        Else
                            DoseparPriseMinV = Q4
                            OK_Min = True
                        End If
                    End If

                    'déterminer le maximuum des 4 valeurs
                    DoseparPriseMaxV = 0
                    If Q1 <> 0 Then
                        DoseparPriseMaxV = Q1
                    End If
                    If Q2 <> 0 Then
                        If DoseparPriseMaxV <> 0 Then
                            If Q2 > DoseparPriseMaxV Then
                                DoseparPriseMaxV = Q2
                            End If
                        Else
                            DoseparPriseMaxV = Q2
                        End If
                    End If
                    If Q3 <> 0 Then
                        If DoseparPriseMaxV <> 0 Then
                            If Q3 > DoseparPriseMaxV Then
                                DoseparPriseMaxV = Q3
                            End If
                        Else
                            DoseparPriseMaxV = Q3
                        End If
                    End If
                    If Q4 <> 0 Then
                        If DoseparPriseMaxV <> 0 Then
                            If Q4 > DoseparPriseMaxV Then
                                DoseparPriseMaxV = Q4
                            End If
                        Else
                            DoseparPriseMaxV = Q4
                        End If
                    End If
                End If

                'PAS DE LIEN AVEC « FREQUENCE »
                If UnitePrise_PPV(6) = "F" Then
                    If (DoseMinV <> Nothing Or DoseMaxV <> Nothing) Then OK_Min = True
                    If OK_Min Then
                        If (DoseMinV <> Nothing) Then
                            DoseparPriseMinV = DoseMinV
                        Else
                            If (DoseMaxV <> Nothing) Then
                                DoseparPriseMinV = DoseMaxV
                            End If
                        End If

                    End If

                    If OK_Max Then
                        If (DoseMaxV <> Nothing) Then
                            DoseparPriseMaxV = DoseMaxV
                        Else
                            If (DoseMinV <> Nothing) Then
                                DoseparPriseMaxV = DoseMinV
                            End If
                        End If
                    End If
                End If

                If OK_Min Then UCD_PARPRISE_MINV = ConvertUCDMonoVirtuelle(DoseparPriseMinV, NumContenant, VolumeInitial, VolumeCourant)
                If OK_Max Then UCD_PARPRISE_MAXV = ConvertUCDMonoVirtuelle(DoseparPriseMaxV, NumContenant, VolumeInitial, VolumeCourant)
                
            End If
        End If
    End Function

    Private Function ConvertUCDMonoVirtuelle(ByVal DoseJournaliere As Double, ByVal NumContenant As Integer, ByVal VolumeInitial As Decimal, ByVal VolumeCourant As Decimal) As StructResultPosologieUCD
        Dim Res As New StructResultPosologieUCD
        Select Case UnitePrise_PPV(0)
            Case "A"
                Dim dt1 As DataTable
                dt1 = cn.MySelect(strSSQL_CDF_CODIF("20", " and CDF_CODE_PK =" & cn.SQLText(CInt(Mid(UnitePrise_PPV, 2, 4)))))
                If (dt1.Rows.Count > 0) Then
                    Res.CODE_UCD = dt1.Rows(0)("code")
                    Res.Libelle_UCD = dt1.Rows(0)("libelle")
                End If
                Res.Valeur = DoseJournaliere
                Return Res
            Case "B"
                Dim dt1 As DataTable
                dt1 = cn.MySelect(strSSQL_CDF_CODIF("04", " and CDF_CODE_PK =" & cn.SQLText(CInt(Mid(UnitePrise_PPV, 2, 4)))))
                If (dt1.Rows.Count > 0) Then
                    Res.CODE_UCD = dt1.Rows(0)("code")
                    Res.Libelle_UCD = dt1.Rows(0)("libelle")
                End If
                Res.Valeur = DoseJournaliere
                Return Res
            Case "C" 'unité de contenance
                Dim nbUnitePrise As Integer = ClsPRE.GetNBUnite(PRE_CODEV)
                Dim dt1 As New DataTable
                dt1 = cn.MySelect(strSSQL_CDF_CODIF("20", " and CDF_CODE_PK =" & cn.SQLText(CInt(Mid(UnitePrise_PPV, 2, 4)))))
                Res.CODE_UCD = dt1.Rows(0)("code")
                Res.Libelle_UCD = dt1.Rows(0)("libelle")

                If nbUnitePrise <> Nothing Then
                    Dim MinNbContenance As String = ClsPRE.GetMinNBContenance(PRE_CODEV)
                    If (MinNbContenance <> 0) Then
                        Res.Valeur = (DoseJournaliere / nbUnitePrise) * MinNbContenance / VolumeCourant
                    Else
                        Res.Valeur = (DoseJournaliere / nbUnitePrise)
                    End If

                Else
                    dtPF = cn.MySelect("Select * From THERIAQUE.CDFIUP_INFO_UNITE_PRISE where  CDFIUP_NUMERO_PK = '20' and CDFIUP_CODE_PK = " & cn.SQLText(CInt(Mid(UnitePrise_PPV, 2, 4))))
                    If (dtPF.Rows.Count > 0) Then
                        If (dtPF.Rows(0)("CDFIUP_COEFVOL_CDF_CODE_FK") IsNot System.DBNull.Value) Then
                            Dim coeff As String = ClsPRE.GetNBContenance(PRE_CODEV)
                            If (coeff <> 0) Then
                                Res.Valeur = DoseJournaliere * dtPF.Rows(0)("CDFIUP_COEFVOL_CDF_CODE_FK") / coeff
                            End If

                        End If
                    End If


                End If
                    Return Res
            Case "D" '(unités gravimétriques) 
                    Dim dt1 As DataTable
                    dt1 = cn.MySelect(strSSQL_CDF_CODIF("19", " and CDF_CODE_PK =" & cn.SQLText(CInt(Mid(UnitePrise_PPV, 2, 4)))))
                    If (dt1.Rows.Count > 0) Then
                        Res.CODE_UCD = dt1.Rows(0)("code")
                        Res.Libelle_UCD = dt1.Rows(0)("libelle")
                    End If
                    Dim MinNbContenance As String = ClsPRE.GetMinNBContenance(PRE_CODEV)
                Dim nbUnitePrise As String = ClsPRE.GetNBUniteMonoVirtuelle(PRE_CODEV, NumContenant, MinNbContenance, VolumeCourant)
                    If nbUnitePrise <> 0 Then Res.Valeur = DoseJournaliere / nbUnitePrise
                    'If ClsPRE.GetUniteDispensation(PRE_CODEV) <> 0 Then Res.Valeur = DoseJournaliere / ClsPRE.GetUniteDispensation(PRE_CODEV)
                    Return Res
            Case "F" '(unités standard) 
                    Dim dt1 As DataTable
                    dt1 = cn.MySelect(strSSQL_CDF_CODIF("19", " and CDF_CODE_PK =" & cn.SQLText(CInt(Mid(UnitePrise_PPV, 2, 4)))))
                    If (dt1.Rows.Count > 0) Then
                        Res.CODE_UCD = dt1.Rows(0)("code")
                        Res.Libelle_UCD = dt1.Rows(0)("libelle")
                    End If
                Dim MinNbContenance As String = ClsPRE.GetMinNBContenance(PRE_CODEV)

                If ClsPRE.GetUniteDispensation(PRE_CODEV) <> 0 Then
                    If (MinNbContenance <> 0) Then
                        Res.Valeur = (DoseJournaliere / ClsPRE.GetUniteDispensation(PRE_CODEV)) * MinNbContenance / VolumeCourant
                    Else
                        Res.Valeur = (DoseJournaliere / ClsPRE.GetUniteDispensation(PRE_CODEV))
                    End If
                End If

                Return Res

            Case "E" ' (unités volumétriques)
                    Dim dt1 As DataTable
                    dt1 = cn.MySelect(strSSQL_CDF_CODIF("21", " and CDF_CODE_PK =" & cn.SQLText(CInt(Mid(UnitePrise_PPV, 2, 4)))))
                    If (dt1.Rows.Count > 0) Then
                        Res.CODE_UCD = dt1.Rows(0)("code")
                        Res.Libelle_UCD = dt1.Rows(0)("libelle")
                    End If
                    If ClsPRE.GetNBContenance(PRE_CODEV) <> 0 Then Res.Valeur = DoseJournaliere / VolumeCourant 'ClsPRE.GetNBContenance(PRE_CODEV)
                    Return Res
        End Select
    End Function

    Public Function ExecuteDoseparJourMonoVirtuelle(ByVal NumContenant As Integer, ByVal VolumeInitial As Decimal, ByVal VolumeCourant As Decimal) As Boolean
        If TestApplicable() Then
            If UnitePrise_PPV(0) <> "G" And UnitePrise_PPV(5) = "Z" Then
                'LIEN AVEC « FREQUENCE »
                If UnitePrise_PPV(6) = "F" Then
                    Dim DJ1, DJ2, DJ3, DJ4 As Decimal
                    DJ1 = 0
                    DJ2 = 0
                    DJ3 = 0
                    DJ4 = 0

                    If (DoseMinV <> Nothing Or FrequenceMinV <> Nothing) Then
                        OK_MinparJour = True
                    End If

                    If OK_MinparJour Then
                        If UniteFrequenceMinV <> Nothing Then
                            dtPF = cn.MySelect("Select * From THERIAQUE.CDFTE_TABLE_EQUIVALENCE where CDFTE_NUMERO_PK = 'PF' and CDFTE_CODE_PK = " & cn.SQLText(UniteFrequenceMinV))
                            If dtPF.Rows.Count > 0 Then
                                If dtPF.Rows(0)("CDFTE_APPLICABLE") IsNot DBNull.Value Then
                                    If dtPF.Rows(0)("CDFTE_APPLICABLE") = "O" Then
                                        If DoseMinV <> Nothing And FrequenceMinV <> Nothing Then
                                            DJ1 = (DoseMinV * FrequenceMinV) / dtPF.Rows(0)("CDFTE_COEFFICIENT")
                                        End If
                                        If OK_MaxparJour Then
                                            If DoseMaxV <> Nothing And FrequenceMinV <> Nothing Then
                                                DJ3 = (DoseMaxV * FrequenceMinV) / dtPF.Rows(0)("CDFTE_COEFFICIENT")
                                            Else
                                                OK_MaxparJour = False
                                            End If
                                        End If
                                    Else
                                        OK_MinparJour = False
                                    End If
                                Else
                                    OK_MinparJour = False
                                End If
                            End If
                        End If
                    End If


                    If (DoseMaxV <> Nothing Or FrequenceMaxV <> Nothing) Then
                        OK_MaxparJour = True
                    End If

                    If OK_MaxparJour Then
                        dtPF = cn.MySelect("Select * From THERIAQUE.CDFTE_TABLE_EQUIVALENCE where CDFTE_NUMERO_PK = 'PF' and CDFTE_CODE_PK = " & cn.SQLText(UniteFrequenceMaxV))
                        If (dtPF.Rows.Count > 0) Then
                            If dtPF.Rows(0)("CDFTE_APPLICABLE") IsNot DBNull.Value Then
                                If dtPF.Rows(0)("CDFTE_APPLICABLE") = "O" Then
                                    If DoseMaxV <> Nothing And FrequenceMaxV <> Nothing Then
                                        DJ4 = (DoseMaxV * FrequenceMaxV) / dtPF.Rows(0)("CDFTE_COEFFICIENT")
                                    End If
                                    If OK_MinparJour Then
                                        If DoseMinV <> Nothing And FrequenceMaxV <> Nothing Then
                                            DJ2 = (DoseMinV * FrequenceMaxV) / dtPF.Rows(0)("CDFTE_COEFFICIENT")
                                        End If
                                    Else
                                        '  OK_MinparJour = False
                                    End If
                                Else
                                    OK_MaxparJour = False
                                End If
                            Else
                                OK_MaxparJour = False
                            End If
                        End If
                    End If
                    'déterminer le minimum des 4 valeurs
                    DoseparJourMinV = 0
                    If DJ1 <> 0 Then
                        DoseparJourMinV = DJ1
                    End If
                    If DJ2 <> 0 Then
                        If DoseparJourMinV <> 0 Then
                            If DJ2 < DoseparJourMinV Then
                                DoseparJourMinV = DJ2
                            End If
                        Else
                            DoseparJourMinV = DJ2
                        End If
                    End If
                    If DJ3 <> 0 Then
                        If DoseparJourMinV <> 0 Then
                            If DJ3 < DoseparJourMinV Then
                                DoseparJourMinV = DJ3
                            End If
                        Else
                            DoseparJourMinV = DJ3
                        End If
                    End If
                    If DJ4 <> 0 Then
                        If DoseparJourMinV <> 0 Then
                            If DJ4 < DoseparJourMinV Then
                                DoseparJourMinV = DJ4
                            End If
                        Else
                            OK_MinparJour = True
                            DoseparJourMinV = DJ4
                        End If
                    End If


                    'déterminer le maximuum des 4 valeurs
                    DoseparJourMaxV = 0
                    If DJ1 <> 0 Then
                        DoseparJourMaxV = DJ1
                    End If
                    If DJ2 <> 0 Then
                        If DoseparJourMaxV <> 0 Then
                            If DJ2 > DoseparJourMaxV Then
                                DoseparJourMaxV = DJ2
                            End If
                        Else
                            DoseparJourMaxV = DJ2
                        End If
                    End If
                    If DJ3 <> 0 Then
                        If DoseparJourMaxV <> 0 Then
                            If DJ3 > DoseparJourMaxV Then
                                DoseparJourMaxV = DJ3
                            End If
                        Else
                            DoseparJourMaxV = DJ3
                        End If
                    End If
                    If DJ4 <> 0 Then
                        If DoseparJourMaxV <> 0 Then
                            If DJ4 > DoseparJourMaxV Then
                                DoseparJourMaxV = DJ4
                            End If
                        Else
                            DoseparJourMaxV = DJ4
                        End If
                    End If
                End If
                'PAS DE LIEN AVEC « FREQUENCE »
                If UnitePrise_PPV(6) = "Z" Then
                    If DoseMinV <> Nothing Or DoseMaxV <> Nothing Then OK_MinparJour = True
                    If OK_MinparJour Then
                        If DoseMinV <> Nothing Then
                            DoseparJourMinV = DoseMinV / Coefficient_Duree_Journaliere(dtPP.Rows(0)("CDFIUP_COEFDUR_CDF_CODE_FK"))
                        Else
                            If DoseMaxV <> Nothing Then
                                DoseparJourMinV = DoseMaxV / Coefficient_Duree_Journaliere(dtPP.Rows(0)("CDFIUP_COEFDUR_CDF_CODE_FK"))
                            End If
                        End If

                    End If
                    If OK_MaxparJour Then
                        If DoseMaxV <> Nothing Then
                            DoseparJourMaxV = DoseMaxV / Coefficient_Duree_Journaliere(dtPP.Rows(0)("CDFIUP_COEFDUR_CDF_CODE_FK"))
                        Else
                            If DoseMinV <> Nothing Then
                                DoseparJourMaxV = DoseMinV / Coefficient_Duree_Journaliere(dtPP.Rows(0)("CDFIUP_COEFDUR_CDF_CODE_FK"))
                            End If
                        End If
                    End If
                End If

                If OK_MinparJour Then UCD_PARJOUR_MINV = ConvertUCDMonoVirtuelle(DoseparJourMinV, NumContenant, VolumeInitial, VolumeCourant)
                If OK_MaxparJour Then UCD_PARJOUR_MAXV = ConvertUCDMonoVirtuelle(DoseparJourMaxV, NumContenant, VolumeInitial, VolumeCourant)
               
            End If
        End If
    End Function

End Class
