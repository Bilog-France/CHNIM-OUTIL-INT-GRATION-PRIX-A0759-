Public Class ClsPosologie


    Private OK_Min As Boolean = True
    Private OK_Max As Boolean = True
    Private OK As Boolean = True

    Private UnitePrise_PPV As String
    Private dtPP As DataTable
    Private dtPF As DataTable

    Private DoseMinV As String
    Private DoseMaxV As String

    Private DoseJournaliereMinV As Decimal
    Private DoseJournaliereMAxV As Decimal

    Private FrequenceMaxV As Integer
    Private FrequenceMinV As Integer
    Private UniteFrequenceMaxV As String
    Private UniteFrequenceMinV As String

    Private SP_CODEV As Integer
    Private PRE_CODEV As String

    Private DureeTraitementMinV As Double
    Private DureeTraitementMaxV As Double

    Private DureeTraitementMinEnJourV As Double
    Private DureeTraitementMaxEnJourV As Double

    Private DureeTraitementTotalMinV As Double
    Private DureeTraitementTotalMaxV As Double

    Private UniteDureeTraitementMinV As String
    Private UniteDureeTraitementMaxV As String

    Private UCD_MINV As StructResultPosologieUCD
    Private UCD_MAXV As StructResultPosologieUCD


    Private OK_MaxparJour As Boolean = True
    Private OK_MinparJour As Boolean = True

    Private DoseparPriseMinV As Decimal
    Private DoseparPriseMaxV As Decimal

    Private DoseparJourMinV As Decimal
    Private DoseparJourMaxV As Decimal

    Private UCD_PARPRISE_MINV As StructResultPosologieUCD
    Private UCD_PARPRISE_MAXV As StructResultPosologieUCD

    Private UCD_PARJOUR_MINV As StructResultPosologieUCD
    Private UCD_PARJOUR_MAXV As StructResultPosologieUCD


    Property SP_CODE() As Integer
        Get
            Return SP_CODEV
        End Get
        Set(ByVal value As Integer)
            SP_CODEV = value
        End Set
    End Property


    ReadOnly Property DoseJournaliereTotalMin() As Integer
        Get
            Return DureeTraitementTotalMinV
        End Get

    End Property

    ReadOnly Property DureeTraitementTotalMax() As Integer
        Get
            Return DureeTraitementTotalMaxV
        End Get

    End Property


    ReadOnly Property DoseJournaliereMax() As Integer
        Get
            Return DoseJournaliereMAxV
        End Get

    End Property

    ReadOnly Property DoseJournaliereMin() As Integer
        Get
            Return DoseJournaliereMinV
        End Get

    End Property

    ReadOnly Property _OK() As Boolean
        Get
            Return OK
        End Get
    End Property

    Property DoseMin() As String
        Get
            Return DoseMinV
        End Get
        Set(ByVal value As String)
            If value = Nothing Or value = "ADAPTER" Then
                OK_Min = False
                Exit Property
            End If
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
                Exit Property
            End If
            DoseMaxV = value
        End Set
    End Property

    Property FrequenceMin() As Integer
        Get
            Return FrequenceMinV
        End Get
        Set(ByVal value As Integer)
            If value = Nothing Then
                OK = False
                Exit Property
            End If
            FrequenceMinV = value
        End Set
    End Property

    Property FrequenceMax() As Integer
        Get
            Return FrequenceMaxV
        End Get
        Set(ByVal value As Integer)
            If value = Nothing Then
                OK = False
                Exit Property
            End If
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
                Exit Property
            End If
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
                Exit Property
            End If
            UniteFrequenceMaxV = value
        End Set
    End Property

    Property UnitePrise_PP() As String
        Get
            Return UnitePrise_PPV
        End Get
        Set(ByVal value As String)
            UnitePrise_PPV = value
        End Set
    End Property

    Property PRE_CODE() As String
        Get
            Return PRE_CODEV
        End Get
        Set(ByVal value As String)
            PRE_CODEV = value
        End Set
    End Property
    ReadOnly Property UCD_MIN() As StructResultPosologieUCD
        Get
            Return UCD_MINV
        End Get

    End Property
    ReadOnly Property UCD_MAX() As StructResultPosologieUCD
        Get
            Return UCD_MAXV
        End Get
    End Property
    Public Sub New()

    End Sub

    Function Coefficient_Duree(ByVal coef As String) As Double
        Select Case coef(0)
            Case "E" 'Minute
                Return 1 / (24 * 60)
            Case "H" 'heure
                Return 1 / 24
            Case "J" 'Jour
                Return 1 * 1
            Case "S" 'Semaine
                Return 1 * 7
            Case "M" 'Mois
                Return 1 * 30
            Case "A" 'An
                Return 1 * 365
            Case "B1" 'Seconde
                Return 1 / 86400
        End Select

    End Function

    Function Coefficient_Duree_Frequence(ByVal coef As String) As Double
        Select Case coef(0)
            Case "E" 'Minute
                Return CInt(Mid(coef, 2)) / (24 * 60)
            Case "H" 'heure
                Return CInt(Mid(coef, 2)) / 24
            Case "J" 'Jour
                Return CInt(Mid(coef, 2)) * 1
            Case "S" 'Semaine
                Return CInt(Mid(coef, 2)) * 7
            Case "M" 'Mois
                Return CInt(Mid(coef, 2)) * 30
            Case "A" 'An
                Return CInt(Mid(coef, 2)) * 365
            Case "B1" 'Seconde
                Return 1 / 86400
        End Select

    End Function

    Property DureeTraitementMin() As Double
        Get
            Return DureeTraitementMinV
        End Get
        Set(ByVal value As Double)
            If value = Nothing Then
                OK_Min = False
                Exit Property
            End If
            DureeTraitementMinV = value
        End Set
    End Property

    Property DureeTraitementMax() As Double
        Get
            Return DureeTraitementMaxV
        End Get
        Set(ByVal value As Double)
            If value = Nothing Then
                OK_Max = False
                Exit Property
            End If
            DureeTraitementMaxV = value
        End Set
    End Property

    Property UniteDureeTraitementMin() As String
        Get
            Return UniteDureeTraitementMinV
        End Get
        Set(ByVal value As String)
            If value = Nothing Then
                OK_Min = False
                Exit Property
            End If
            UniteDureeTraitementMinV = value
        End Set
    End Property

    Property UniteDureeTraitementMax() As String
        Get
            Return UniteDureeTraitementMaxV
        End Get
        Set(ByVal value As String)
            If value = Nothing Then
                OK_Max = False
                Exit Property
            End If
            UniteDureeTraitementMaxV = value
        End Set
    End Property
    Property DureeTraitementMinEnJour() As Double
        Get
            Return DureeTraitementMinEnJourV
        End Get
        Set(ByVal value As Double)
            If value = Nothing Then
                OK_Min = False
                Exit Property
            End If
            DureeTraitementMinEnJourV = value
        End Set
    End Property

    Property DureeTraitementMaxEnJour() As Double
        Get
            Return DureeTraitementMaxEnJourV
        End Get
        Set(ByVal value As Double)
            If value = Nothing Then
                OK_Max = False
                Exit Property
            End If
            DureeTraitementMaxEnJourV = value
        End Set
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
            Case "S01" 'SEMAINE(S)
                Return 7
            Case "Z06" 'PENDANT 72 HEURES
                Return 3
            Case "Z07" 'PENDANT 144 HEURES
                Return 6
        End Select

    End Function

    Public Function Execute() As Boolean
        If TestApplicable() Then

            If (DoseMinV <> Nothing Or FrequenceMinV <> Nothing) Then
                OK_Min = True
            End If

            If (DoseMaxV <> Nothing Or FrequenceMaxV <> Nothing) Then
                OK_Max = True
            End If

            If UnitePrise_PPV(6) = "Z" Then
                '----------------------------------------
                '----------------------------------------
                'Pas de lien avec « fréquence »
                '----------------------------------------
                '----------------------------------------

                If DoseMinV <> Nothing Then
                    If OK_Min Then DoseJournaliereMinV = DoseMinV.Replace(".", ",") / Coefficient_Duree_Journaliere(dtPP.Rows(0)("CDFIUP_COEFDUR_CDF_CODE_FK"))
                    'Else
                    'OK_Min = False
                End If



                If DoseMaxV <> Nothing Then
                    If OK_Max Then DoseJournaliereMAxV = DoseMaxV.Replace(".", ",") / Coefficient_Duree_Journaliere(dtPP.Rows(0)("CDFIUP_COEFDUR_CDF_CODE_FK"))
                    'Else
                    '    OK_Max = False
                End If
            Else
                '----------------------------------------
                '----------------------------------------
                ' Lien avec « Fréquence » 
                '----------------------------------------
                '----------------------------------------
                If UnitePrise_PPV(6) = "F" Then
                    If OK_Min Then
                        If UniteFrequenceMinV <> Nothing Then
                            dtPF = cn.MySelect("Select * From THERIAQUE.CDFTE_TABLE_EQUIVALENCE where CDFTE_NUMERO_PK = 'PF' and CDFTE_CODE_PK = " & cn.SQLText(UniteFrequenceMinV))
                            If dtPF.Rows.Count > 0 Then
                                If dtPF.Rows(0)("CDFTE_APPLICABLE") IsNot DBNull.Value Then
                                    If dtPF.Rows(0)("CDFTE_APPLICABLE") = "O" Then
                                        If DoseMinV <> Nothing And FrequenceMinV <> Nothing Then
                                            DoseJournaliereMinV = DoseMinV * FrequenceMinV / dtPF.Rows(0)("CDFTE_COEFFICIENT")
                                        End If
                                        If DoseMinV = Nothing And FrequenceMinV <> Nothing And DoseMaxV <> Nothing Then
                                            DoseJournaliereMinV = DoseMaxV * FrequenceMinV / dtPF.Rows(0)("CDFTE_COEFFICIENT")
                                        End If
                                    Else
                                        OK_Min = False
                                    End If
                                Else
                                    OK_Min = False
                                End If

                            End If
                        Else
                            dtPF = cn.MySelect("Select * From THERIAQUE.CDFTE_TABLE_EQUIVALENCE where CDFTE_NUMERO_PK = 'PF' and CDFTE_CODE_PK = " & cn.SQLText(UniteFrequenceMaxV))

                            If (dtPF.Rows.Count > 0) Then
                                If dtPF.Rows(0)("CDFTE_APPLICABLE") IsNot DBNull.Value Then
                                    If dtPF.Rows(0)("CDFTE_APPLICABLE") = "O" Then
                                        If DoseMinV <> Nothing And FrequenceMaxV <> Nothing Then
                                            DoseJournaliereMinV = DoseMinV.Replace(".", ",") * FrequenceMaxV / dtPF.Rows(0)("CDFTE_COEFFICIENT")
                                        End If
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
                        If dtPF.Rows.Count > 0 Then
                            If dtPF.Rows(0)("CDFTE_APPLICABLE") IsNot DBNull.Value Then
                                If dtPF.Rows(0)("CDFTE_APPLICABLE") = "O" Then
                                    If DoseMaxV <> Nothing And FrequenceMaxV <> Nothing Then
                                        If (dtPF.Rows(0)("CDFTE_COEFFICIENT") <> 0) Then
                                            DoseJournaliereMAxV = DoseMaxV.Replace(".", ",") * FrequenceMaxV / dtPF.Rows(0)("CDFTE_COEFFICIENT")
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
                End If
            End If
            ''------------------------------------------
            ''------------------------------------------

            If OK_Min Then UCD_MINV = ConvertUCD(DoseJournaliereMinV)
            If OK_Max Then UCD_MAXV = ConvertUCD(DoseJournaliereMAxV)
            ''------------------------------------------
            ''------------------------------------------

            If DureeTraitement(UniteDureeTraitementMinV, DureeTraitementMinV) > 0 Then OK_Min = True Else OK_Min = False
            If DureeTraitement(UniteDureeTraitementMaxV, DureeTraitementMaxV) > 0 Then OK_Max = True Else OK_Max = False

            If OK_Min Then DureeTraitementTotalMinV = DureeTraitement(UniteDureeTraitementMinV, DureeTraitementMinV)
            If OK_Max Then DureeTraitementTotalMaxV = DureeTraitement(UniteDureeTraitementMaxV, DureeTraitementMaxV)
            ''------------------------------------------
            ''------------------------------------------

            If OK_Min Then DureeTraitementMinEnJourV = DureeTraitement("J", DureeTraitementMinV)
            If OK_Max Then DureeTraitementMaxEnJourV = DureeTraitement("J", DureeTraitementMaxV)

            If OK_Min Then DureeTraitementMinV = DureeTraitement(UniteDureeTraitementMinV, DureeTraitementMinV)
            If OK_Max Then DureeTraitementMaxV = DureeTraitement(UniteDureeTraitementMaxV, DureeTraitementMaxV)


        End If
    End Function

    Private Function ConvertUCD(ByVal DoseJournaliere As Double) As StructResultPosologieUCD
        Dim Res As New StructResultPosologieUCD
        Select Case UnitePrise_PPV(0)
            Case "A"
                Dim dt1 As DataTable
                dt1 = cn.MySelect(strSSQL_CDF_CODIF("20", " and CDF_CODE_PK =" & cn.SQLText(CInt(Mid(UnitePrise_PPV, 2, 4)))))
                Res.CODE_UCD = dt1.Rows(0)("code")
                Res.Libelle_UCD = dt1.Rows(0)("libelle")
                Res.Valeur = DoseJournaliere
                Return Res
            Case "B"
                Dim dt1 As DataTable
                dt1 = cn.MySelect(strSSQL_CDF_CODIF("04", " and CDF_CODE_PK =" & cn.SQLText(CInt(Mid(UnitePrise_PPV, 2, 4)))))
                Res.CODE_UCD = dt1.Rows(0)("code")
                Res.Libelle_UCD = dt1.Rows(0)("libelle")
                Res.Valeur = DoseJournaliere
                Return Res
            Case "C" 'unité de contenance
                Dim nbUnitePrise As Integer = ClsPRE.GetNBUnite(PRE_CODEV)
                Dim dt1 As New DataTable
                dt1 = cn.MySelect(strSSQL_CDF_CODIF("20", " and CDF_CODE_PK =" & cn.SQLText(CInt(Mid(UnitePrise_PPV, 2, 4)))))
                Res.CODE_UCD = dt1.Rows(0)("code")
                Res.Libelle_UCD = dt1.Rows(0)("libelle")
                If nbUnitePrise <> Nothing Then
                    Res.Valeur = DoseJournaliere / nbUnitePrise
                Else
                    dtPF = cn.MySelect("Select * From THERIAQUE.CDFTE_TABLE_EQUIVALENCE where  CDFTE_NUMERO_PK = '20' and CDFTE_CODE_PK = " & cn.SQLText(CInt(Mid(UnitePrise_PPV, 2, 4))))
                    If dtPF.Rows.Count > 0 Then
                        If (dtPF.Rows(0)("CDFTE_COEFFICIENT") IsNot System.DBNull.Value) Then
                            Res.Valeur = DoseJournaliere * dtPF.Rows(0)("CDFTE_COEFFICIENT") / ClsPRE.GetNBContenance(PRE_CODEV)
                        End If
                    End If
                End If

                Return Res
            Case "D" '(unités gravimétriques) 
                Dim dt1 As DataTable
                dt1 = cn.MySelect(strSSQL_CDF_CODIF("19", " and CDF_CODE_PK =" & cn.SQLText(CInt(Mid(UnitePrise_PPV, 2, 4)))))
                Res.CODE_UCD = dt1.Rows(0)("code")
                Res.Libelle_UCD = dt1.Rows(0)("libelle")
                If ClsPRE.GetUniteDispensation(PRE_CODEV) <> 0 Then Res.Valeur = DoseJournaliere / ClsPRE.GetUniteDispensation(PRE_CODEV)
                Return Res
            Case "F" '(unités standard) 
                Dim dt1 As DataTable
                dt1 = cn.MySelect(strSSQL_CDF_CODIF("19", " and CDF_CODE_PK =" & cn.SQLText(CInt(Mid(UnitePrise_PPV, 2, 4)))))
                Res.CODE_UCD = dt1.Rows(0)("code")
                Res.Libelle_UCD = dt1.Rows(0)("libelle")
                If ClsPRE.GetUniteDispensation(PRE_CODEV) <> 0 Then Res.Valeur = DoseJournaliere / ClsPRE.GetUniteDispensation(PRE_CODEV)
                Return Res
            Case "E" ' (unités volumétriques)
                Dim dt1 As DataTable
                dt1 = cn.MySelect(strSSQL_CDF_CODIF("21", " and CDF_CODE_PK =" & cn.SQLText(CInt(Mid(UnitePrise_PPV, 2, 4)))))
                Res.CODE_UCD = dt1.Rows(0)("code")
                Res.Libelle_UCD = dt1.Rows(0)("libelle")
                If ClsPRE.GetNBContenance(PRE_CODEV) <> 0 Then Res.Valeur = DoseJournaliere / ClsPRE.GetNBContenance(PRE_CODEV)
                Return Res
        End Select
    End Function

    Private Function DureeTraitement(ByVal UniteDureeTraitementV As String, ByVal Valeur As Double)
        Dim dt As DataTable = cn.MySelect("Select * from THERIAQUE.CDFTE_TABLE_EQUIVALENCE WHERE CDFTE_CODE_PK = " & cn.SQLText(UniteDureeTraitementV))
        If dt.Rows.Count > 0 Then
            If dt.Rows(0)("CDFTE_APPLICABLE") IsNot DBNull.Value Then
                If dt.Rows(0)("CDFTE_APPLICABLE") = "O" Then
                    Return Valeur * Coefficient_Duree(UniteDureeTraitementV)
                Else
                    Return 0
                    Exit Function
                End If
            Else
                Return 0
                Exit Function
            End If
        Else
            Return 0
            Exit Function
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

    ''' <summary>
    ''' Created By [BFE]
    ''' </summary>
    ''' <remarks>Critére de cohérence conçernant le champ de unité de prise /contenant</remarks>
    Public Function TestCoherence_UP_Contenant(ByVal Code_SP As Integer) As Boolean
        Dim bOk As Boolean = True
        Dim dt As DataTable = cn.MySelect("Select DISTINCT PRE_CDF_UP_CODE_FK from THERIAQUE.PRE_PRESENTATION where PRE_SP_CODE_FK = " & Code_SP)
        If dt.Rows.Count > 1 Then
            bOk = False
        End If
        Return bOk
    End Function

    ''' <summary>
    ''' Created By [BFE]
    ''' </summary>
    ''' <remarks>Critére de cohérence concernant l’unité dose totale par UCD</remarks>
    Public Function TestCoherence_UDT_UCD(ByVal Code_SP As Integer) As Boolean
        Dim bOk As Boolean = True
        'Dim dt As DataTable = cn.MySelect("Select PRE_CODE_PK from THERIAQUE.PRE_PRESENTATION where PRE_SP_CODE_FK = " & Code_SP)
        'Dim sTemp As String = ""
        'If dt.Rows.Count > 0 Then
        '    Dim dtRef As DataTable = cn.MySelect("SELECT PREDISP_CDF_UD_CODE_FK FROM THERIAQUE.PREDISP_PRE_DISPENSATION WHERE PREDISP_PRE_CODE_FK_PK =" & cn.SQLText(dt.Rows(0)(0)))
        '    sTemp = dtRef.Rows(0)(0)
        '    For iCount2 As Integer = 1 To dt.Rows.Count - 1
        '        If dt.Rows(iCount2)(0) <> sTemp Then
        '            bOk = False
        '            Exit Function
        '        End If
        '    Next
        'End If

        'Toutes les présentations rattachées doit avoir le même contenant : FLACON(S)) et la même unité de dose totale UCD (MG)
        'Test sur PREDISP_SAC_CODE_FK 
        'Dim dt As DataTable = cn.MySelect("SELECT DISTINCT PREDISP_SAC_CODE_FK FROM THERIAQUE.PREDISP_PRE_DISPENSATION WHERE PREDISP_PRE_CODE_FK_PK IN(SELECT PRE_CODE_PK FROM THERIAQUE.PRE_PRESENTATION WHERE PRE_SP_CODE_FK = " & Code_SP & ")")
        'If dt.Rows.Count > 1 Then
        '    bOk = False
        '    Exit Function
        'End If

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
            bOk = True
        End If
        
        'Test sur PREDISP_CDF_UD_CODE_FK 
            dt = cn.MySelect("SELECT DISTINCT PREDISP_CDF_UD_CODE_FK FROM THERIAQUE.PREDISP_PRE_DISPENSATION WHERE PREDISP_PRE_CODE_FK_PK IN(SELECT PRE_CODE_PK FROM THERIAQUE.PRE_PRESENTATION WHERE PRE_SP_CODE_FK = " & Code_SP & ")")
            If dt.Rows.Count > 1 Then
                bOk = False
                Exit Function
            End If
            Return bOk
    End Function

    ''' <summary>
    ''' Created By [BFE]
    ''' </summary>
    ''' <remarks>Critére de cohérence concernant le contenant</remarks>
    Public Function TestCoherence_Contenant(ByVal Code_SP As Integer) As Boolean
        Dim bOk As Boolean = True
        'Ticket 12056: supprimer le contrôle qui vérifie l'homogénéité des contenants(L'algorithme doit pouvoir être calculé même si les contenants (Table PRECONT) sont différents)
        'Dim dt As DataTable = cn.MySelect("SELECT DISTINCT PRECONT_CDF_COCDT_CODE_FK, PRECONT_COCONT_NUM_FK_PK FROM THERIAQUE.PRECONT_PRE_CONTENANT WHERE PRECONT_PRE_CODE_FK_PK IN(SELECT PRE_CODE_PK FROM THERIAQUE.PRE_PRESENTATION WHERE PRE_SP_CODE_FK = " & Code_SP & ") ORDER BY PRECONT_COCONT_NUM_FK_PK")
        'If dt.Rows.Count > 1 Then
        '    For iCount As Integer = 0 To dt.Rows.Count - 2
        '        If dt.Rows(iCount)(1) = dt.Rows(iCount + 1)(1) Then
        '            bOk = False
        '            Exit Function
        '        End If
        '    Next
        'End If
        Return bOk
    End Function

    Shared ReadOnly Property Get_DonneeAnthropometrique(ByVal Unite_Prise As String) As String
        Get
            Dim dt As DataTable = cn.MySelect("Select CDFIUP_DONANTH_CDF_CODE_FK from THERIAQUE.CDFIUP_INFO_UNITE_PRISE WHERE CDFIUP_CODE_PK = " & cn.SQLText(Unite_Prise))
            If dt.Rows.Count > 0 Then
                If dt.Rows(0)("CDFIUP_DONANTH_CDF_CODE_FK") IsNot DBNull.Value Then
                    Return dt.Rows(0)("CDFIUP_DONANTH_CDF_CODE_FK")
                Else
                    Return ""
                End If
            Else
                Return ""
            End If
        End Get

    End Property

    Shared ReadOnly Property GetDureeMin(ByVal SP_UCDCIP As String) As String
        Get
            Dim strSSQL As String = ""
            strSSQL = " select isnull(Min(ipo.IPO_DUREEMIN * cdfte.CDFTE_COEFFICIENT),0) as DMin "
            strSSQL += " from  theriaque.FPOSP_POSO_SPE fposp, theriaque.FPO_FICHEPOSO fpo,theriaque.IPO_INFOPOSO ipo,theriaque.CDFTE_TABLE_EQUIVALENCE cdfte "
            strSSQL += " where(fposp.FPOSP_FPO_CODE_FK_PK = fpo.FPO_CODE_SQ_PK) and fpo.FPO_CODE_SQ_PK = ipo.IPO_FPO_CODE_FK_PK and cdfte.CDFTE_CODE_PK = ipo.IPO_CDF_UTMIN_CODE_FK "
            strSSQL += " and cdfte.CDFTE_APPLICABLE = 'O' and ipo.IPO_CDF_NAPO_CODE_FK <> '02' "
            strSSQL += " and fposp.FPOSP_SP_CODE_FK_PK in (select sp.SP_CODE_SQ_PK from theriaque.SP_SPECIALITE sp where sp.SP_CIPUCD = '" + SP_UCDCIP + "') "
            'strSSQL += " GROUP BY ipo.IPO_CDF_NAPO_CODE_FK "

            Dim dt As DataTable = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)(0).ToString
            Else
                Return "0"
            End If
        End Get
    End Property

    Shared ReadOnly Property GetDureeMinVirtuelle(ByVal CodeVirtuel As String) As String
        Get
            Dim strSSQL As String = ""
            strSSQL = " select isnull(Min(ipo.IPO_DUREEMIN * cdfte.CDFTE_COEFFICIENT),0) as DMin "
            strSSQL += " from  theriaque.FPOSP_POSO_SPE fposp, theriaque.FPO_FICHEPOSO fpo,theriaque.IPO_INFOPOSO ipo,theriaque.CDFTE_TABLE_EQUIVALENCE cdfte "
            strSSQL += " where(fposp.FPOSP_FPO_CODE_FK_PK = fpo.FPO_CODE_SQ_PK) and fpo.FPO_CODE_SQ_PK = ipo.IPO_FPO_CODE_FK_PK and cdfte.CDFTE_CODE_PK = ipo.IPO_CDF_UTMIN_CODE_FK "
            strSSQL += " and cdfte.CDFTE_APPLICABLE = 'O' and ipo.IPO_CDF_NAPO_CODE_FK <> '02' "
            strSSQL += " and fposp.FPOSP_SP_CODE_FK_PK in (select sp.SP_CODE_SQ_PK from theriaque.SP_SPECIALITE sp,THERIAQUE.GSP_GENERIQUE_SPECIALITE gsp where sp.SP_GSP_CODE_FK = gsp.GSP_CODE_SQ_PK and gsp.GSP_CODE_VIRTUEL= '" + CodeVirtuel + "') "
            strSSQL += " GROUP BY ipo.IPO_CDF_NAPO_CODE_FK "

            Dim dt As DataTable = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)(0).ToString
            Else
                Return "0"
            End If
        End Get
    End Property

    Shared ReadOnly Property GetDureeMax(ByVal SP_UCDCIP As String) As String
        Get
            Dim strSSQL As String = ""
            strSSQL = " select isnull(Max(ipo.IPO_DUREEMAX  * cdfte.CDFTE_COEFFICIENT),0) as DMax "
            strSSQL += " from  theriaque.FPOSP_POSO_SPE fposp, theriaque.FPO_FICHEPOSO fpo,theriaque.IPO_INFOPOSO ipo,theriaque.CDFTE_TABLE_EQUIVALENCE cdfte "
            strSSQL += " where fposp.FPOSP_FPO_CODE_FK_PK = fpo.FPO_CODE_SQ_PK and fpo.FPO_CODE_SQ_PK = ipo.IPO_FPO_CODE_FK_PK and cdfte.CDFTE_CODE_PK = ipo.IPO_CDF_UTMAX_CODE_FK "
            strSSQL += " and cdfte.CDFTE_APPLICABLE = 'O' and (ipo.IPO_CDF_NAPO_CODE_FK = '02' or ipo.IPO_CDF_NAPO_CODE_FK = '01' or ipo.IPO_CDF_NAPO_CODE_FK = '04') "
            strSSQL += " and FPOSP_SP_CODE_FK_PK in (select sp.SP_CODE_SQ_PK from theriaque.SP_SPECIALITE sp where sp.SP_CIPUCD = '" + SP_UCDCIP + "') "
            'strSSQL += " GROUP BY ipo.IPO_CDF_NAPO_CODE_FK "

            Dim dt As DataTable = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)(0).ToString
            Else
                Return "0"
            End If
        End Get
    End Property

    Shared ReadOnly Property GetDureeMaxVirtuelle(ByVal CodeVirtuel As String) As String
        Get
            Dim strSSQL As String = ""
            strSSQL = " select isnull(Max(ipo.IPO_DUREEMAX  * cdfte.CDFTE_COEFFICIENT),0) as DMax "
            strSSQL += " from  theriaque.FPOSP_POSO_SPE fposp, theriaque.FPO_FICHEPOSO fpo,theriaque.IPO_INFOPOSO ipo,theriaque.CDFTE_TABLE_EQUIVALENCE cdfte "
            strSSQL += " where fposp.FPOSP_FPO_CODE_FK_PK = fpo.FPO_CODE_SQ_PK and fpo.FPO_CODE_SQ_PK = ipo.IPO_FPO_CODE_FK_PK and cdfte.CDFTE_CODE_PK = ipo.IPO_CDF_UTMAX_CODE_FK "
            strSSQL += " and cdfte.CDFTE_APPLICABLE = 'O' and (ipo.IPO_CDF_NAPO_CODE_FK = '02' or ipo.IPO_CDF_NAPO_CODE_FK = '01' or ipo.IPO_CDF_NAPO_CODE_FK = '04' ) "
            strSSQL += " and fposp.FPOSP_SP_CODE_FK_PK in (select sp.SP_CODE_SQ_PK from theriaque.SP_SPECIALITE sp,THERIAQUE.GSP_GENERIQUE_SPECIALITE gsp where sp.SP_GSP_CODE_FK = gsp.GSP_CODE_SQ_PK and gsp.GSP_CODE_VIRTUEL= '" + CodeVirtuel + "') "
            strSSQL += " GROUP BY ipo.IPO_CDF_NAPO_CODE_FK "

            Dim dt As DataTable = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)(0).ToString
            Else
                Return "0"
            End If
        End Get
    End Property

    ReadOnly Property _OKMIN() As Boolean
        Get
            Return OK_Min
        End Get
    End Property

    ReadOnly Property _OKMax() As Boolean
        Get
            Return OK_Max
        End Get
    End Property

    Private Function ConvertUCDMonoVirtuelle(ByVal DoseJournaliere As Double, ByVal NumContenant As Integer, ByVal VolumeInitial As Decimal, ByVal VolumeCourant As Decimal) As StructResultPosologieUCD
        Dim Res As New StructResultPosologieUCD
        Select Case UnitePrise_PPV(0)
            Case "A"
                Dim dt1 As DataTable
                dt1 = cn.MySelect(strSSQL_CDF_CODIF("20", " and CDF_CODE_PK =" & cn.SQLText(CInt(Mid(UnitePrise_PPV, 2, 4)))))
                Res.CODE_UCD = dt1.Rows(0)("code")
                Res.Libelle_UCD = dt1.Rows(0)("libelle")
                Res.Valeur = DoseJournaliere
                Return Res
            Case "B"
                Dim dt1 As DataTable
                dt1 = cn.MySelect(strSSQL_CDF_CODIF("04", " and CDF_CODE_PK =" & cn.SQLText(CInt(Mid(UnitePrise_PPV, 2, 4)))))
                Res.CODE_UCD = dt1.Rows(0)("code")
                Res.Libelle_UCD = dt1.Rows(0)("libelle")
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
                    '1
                    dtPF = cn.MySelect("Select * From THERIAQUE.CDFIUP_INFO_UNITE_PRISE where  CDFIUP_NUMERO_PK = '20' and CDFIUP_CODE_PK = " & cn.SQLText(CInt(Mid(UnitePrise_PPV, 2, 4))))
                    If (dtPF.Rows.Count > 0) Then
                        If (dtPF.Rows(0)("CDFIUP_COEFVOL_CDF_CODE_FK") IsNot System.DBNull.Value) Then
                            Dim coeff As String = ClsPRE.GetNBContenance(PRE_CODEV)
                            If coeff <> 0 Then
                                Res.Valeur = DoseJournaliere * dtPF.Rows(0)("CDFIUP_COEFVOL_CDF_CODE_FK") / coeff
                            End If
                        End If
                    End If
                End If
                    Return Res
            Case "D" '(unités gravimétriques) 
                    Dim dt1 As DataTable
                    dt1 = cn.MySelect(strSSQL_CDF_CODIF("19", " and CDF_CODE_PK =" & cn.SQLText(CInt(Mid(UnitePrise_PPV, 2, 4)))))
                    Res.CODE_UCD = dt1.Rows(0)("code")
                    Res.Libelle_UCD = dt1.Rows(0)("libelle")
                    Dim MinNbContenance As String = ClsPRE.GetMinNBContenance(PRE_CODEV)
                    If ClsPRE.GetUniteDispensation(PRE_CODEV) <> 0 Then
                    If (MinNbContenance <> 0) Then
                        If (VolumeCourant <> 0) Then
                            Res.Valeur = (DoseJournaliere / ClsPRE.GetUniteDispensation(PRE_CODEV)) * MinNbContenance / VolumeCourant
                        End If
                    Else
                        Res.Valeur = (DoseJournaliere / ClsPRE.GetUniteDispensation(PRE_CODEV))
                    End If
                End If
                Return Res
            Case "F" '(unités standard) 
                    Dim dt1 As DataTable
                    dt1 = cn.MySelect(strSSQL_CDF_CODIF("19", " and CDF_CODE_PK =" & cn.SQLText(CInt(Mid(UnitePrise_PPV, 2, 4)))))
                    Res.CODE_UCD = dt1.Rows(0)("code")
                    Res.Libelle_UCD = dt1.Rows(0)("libelle")
                    Dim MinNbContenance As String = ClsPRE.GetMinNBContenance(PRE_CODEV)
                    If ClsPRE.GetUniteDispensation(PRE_CODEV) <> 0 Then
                    If (MinNbContenance <> 0) Then
                        If (VolumeCourant <> 0) Then
                            Res.Valeur = DoseJournaliere / ClsPRE.GetUniteDispensation(PRE_CODEV) * MinNbContenance / VolumeCourant
                        End If
                    Else
                        Res.Valeur = DoseJournaliere / ClsPRE.GetUniteDispensation(PRE_CODEV)
                    End If

                End If

                Return Res
            Case "E" ' (unités volumétriques)
                    Dim dt1 As DataTable
                    dt1 = cn.MySelect(strSSQL_CDF_CODIF("21", " and CDF_CODE_PK =" & cn.SQLText(CInt(Mid(UnitePrise_PPV, 2, 4)))))
                    Res.CODE_UCD = dt1.Rows(0)("code")
                    Res.Libelle_UCD = dt1.Rows(0)("libelle")
                If ClsPRE.GetNBContenance(PRE_CODEV) <> 0 Then
                    If (VolumeCourant <> 0) Then
                        Res.Valeur = DoseJournaliere / VolumeCourant 'ClsPRE.GetNBContenance(PRE_CODEV)
                    End If
                End If
                Return Res
        End Select
    End Function

    Public Function ExecuteMonoVirtuelle(ByVal NumContenant As Integer, ByVal VolumeInitial As Decimal, ByVal VolumeCourant As Decimal) As Boolean
        If TestApplicable() Then
            If UnitePrise_PPV(6) = "Z" Then
                '----------------------------------------
                '----------------------------------------
                'Pas de lien avec « fréquence »
                '----------------------------------------
                '----------------------------------------
                If DoseMinV <> Nothing Then
                    If OK_Min Then DoseJournaliereMinV = DoseMinV / Coefficient_Duree_Journaliere(dtPP.Rows(0)("CDFIUP_COEFDUR_CDF_CODE_FK"))
                    'Else
                    'OK_Min = False
                End If

                If DoseMaxV <> Nothing Then
                    If OK_Max Then DoseJournaliereMAxV = DoseMaxV / Coefficient_Duree_Journaliere(dtPP.Rows(0)("CDFIUP_COEFDUR_CDF_CODE_FK"))
                    'Else
                    '    OK_Max = False
                End If
            Else
                '----------------------------------------
                '----------------------------------------
                ' Lien avec « Fréquence » 
                '----------------------------------------
                '----------------------------------------
                If UnitePrise_PPV(6) = "F" Then
                    If OK_Min Then
                        If UniteFrequenceMinV <> Nothing Then
                            dtPF = cn.MySelect("Select * From THERIAQUE.CDFTE_TABLE_EQUIVALENCE where CDFTE_NUMERO_PK = 'PF' and CDFTE_CODE_PK = " & cn.SQLText(UniteFrequenceMinV))
                            If dtPF.Rows.Count > 0 Then
                                If dtPF.Rows(0)("CDFTE_APPLICABLE") IsNot DBNull.Value Then
                                    If dtPF.Rows(0)("CDFTE_APPLICABLE") = "O" Then
                                        If DoseMinV <> Nothing And FrequenceMinV <> Nothing Then
                                            DoseJournaliereMinV = DoseMinV * FrequenceMinV / dtPF.Rows(0)("CDFTE_COEFFICIENT")
                                        End If
                                        If DoseMinV = Nothing And FrequenceMinV <> Nothing And DoseMaxV <> Nothing Then
                                            DoseJournaliereMinV = DoseMaxV * FrequenceMinV / dtPF.Rows(0)("CDFTE_COEFFICIENT")
                                        End If
                                    Else
                                        OK_Min = False
                                    End If
                                Else
                                    OK_Min = False
                                End If

                            End If
                        Else
                            dtPF = cn.MySelect("Select * From THERIAQUE.CDFTE_TABLE_EQUIVALENCE where CDFTE_NUMERO_PK = 'PF' and CDFTE_CODE_PK = " & cn.SQLText(UniteFrequenceMaxV))
                            If dtPF.Rows.Count > 0 Then
                                If dtPF.Rows(0)("CDFTE_APPLICABLE") IsNot DBNull.Value Then
                                    If dtPF.Rows(0)("CDFTE_APPLICABLE") = "O" Then
                                        If DoseMinV <> Nothing And FrequenceMaxV <> Nothing Then
                                            DoseJournaliereMinV = DoseMinV.Replace(".", ",") * FrequenceMaxV / dtPF.Rows(0)("CDFTE_COEFFICIENT")
                                        End If
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
                        If dtPF.Rows.Count > 0 Then
                            If dtPF.Rows(0)("CDFTE_APPLICABLE") IsNot DBNull.Value Then
                                If dtPF.Rows(0)("CDFTE_APPLICABLE") = "O" Then
                                    If DoseMaxV <> Nothing And FrequenceMaxV <> Nothing Then
                                        DoseJournaliereMAxV = DoseMaxV.Replace(".", ",") * FrequenceMaxV / dtPF.Rows(0)("CDFTE_COEFFICIENT")
                                    End If
                                Else
                                    OK_Max = False
                                End If
                            Else
                                OK_Max = False
                            End If
                        End If
                    End If
                End If
            End If
            ''------------------------------------------
            ''------------------------------------------

            If OK_Min Then UCD_MINV = ConvertUCDMonoVirtuelle(DoseJournaliereMinV, NumContenant, VolumeInitial, VolumeCourant)
            If OK_Max Then UCD_MAXV = ConvertUCDMonoVirtuelle(DoseJournaliereMAxV, NumContenant, VolumeInitial, VolumeCourant)



            ''------------------------------------------
            ''------------------------------------------
            ' Debut du calcul poso min/max
            If DureeTraitement(UniteDureeTraitementMinV, DureeTraitementMinV) = 0 Then OK_Min = False Else OK_Min = True
            If DureeTraitement(UniteDureeTraitementMaxV, DureeTraitementMaxV) = 0 Then OK_Max = False Else OK_Max = True

            If OK_Min Then DureeTraitementTotalMinV = DureeTraitement(UniteDureeTraitementMinV, DureeTraitementMinV)
            If OK_Max Then DureeTraitementTotalMaxV = DureeTraitement(UniteDureeTraitementMaxV, DureeTraitementMaxV)
            ''------------------------------------------
            ''------------------------------------------

            If OK_Min Then DureeTraitementMinEnJourV = DureeTraitement("J", DureeTraitementMinV)
            If OK_Max Then DureeTraitementMaxEnJourV = DureeTraitement("J", DureeTraitementMaxV)

            If OK_Min Then DureeTraitementMinV = DureeTraitement(UniteDureeTraitementMinV, DureeTraitementMinV)
            If OK_Max Then DureeTraitementMaxV = DureeTraitement(UniteDureeTraitementMaxV, DureeTraitementMaxV)


        End If
    End Function


    Shared Function MaxSequence(ByVal champ As String, ByVal table As String) As Integer

        Dim bOk As Boolean = True 'IPOJ_NUM_SEQ_PK , IPOJ_INFOPOSO_JOURNALIERE
        Dim dt As DataTable = cn.MySelect(" select isnull(max(" & champ & "),0) from theriaque." & table)

        Return dt.Rows(0)(0)

    End Function



    Shared Function GetExistSeq(ByVal CodeSp As Integer, ByVal champ As String, ByVal table As String, ByVal where As String) As Integer

        Dim bOk As Boolean = True
        Dim dt As DataTable = cn.MySelect(" select " & champ & "  from theriaque." & table & " where " & where & "=" & CodeSp)
        If (dt.Rows.Count > 0) Then
            Return dt.Rows(0)(0)
        Else
            Return -1
        End If
    End Function

    Shared Function IsCommercialized(ByVal CodeSp As Integer) As Integer


        Dim dt As DataTable = cn.MySelect(" select null from theriaque.PRE_PRESENTATION where PRE_SP_CODE_FK = " & CodeSp & " and (PRE_ETAT_COMMER = 'D' or PRE_ETAT_COMMER= 'NC') ")
        Return (dt.Rows.Count > 0)

    End Function



End Class
