Public Module ModAlgoCode

    Public Function Code_CIS(ByVal strCodeCis As String, ByVal ctrl As Control, ByVal ErrProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider) As Boolean
        If strCodeCis.Length = 0 Then
            ErrProvider.SetError(ctrl, "")
            Return True
        End If
        If strCodeCis.Length <> 11 And strCodeCis.Length <> 0 Then
            ErrProvider.SetError(ctrl, "Le format du code CIS est incorrécte: [* *** *** *]")
            Return False
        End If
        If strCodeCis Is Nothing Then
            ErrProvider.SetError(ctrl, "")
            Return True
            Exit Function
        End If

        If strCodeCis(1) <> " " Or strCodeCis(5) <> " " Or strCodeCis(9) <> " " Then
            ErrProvider.SetError(ctrl, "Le format du code CIS est incorrécte: [* *** *** *]")
            Return False
        End If

        strCodeCis = Replace(strCodeCis, " ", "")
        If strCodeCis.Length <> 8 Then
            ErrProvider.SetError(ctrl, "Le code CIS doit être constitué de 8 chiffre")
            Return False
        End If

        If strCodeCis(0) <> "6" Then
            ErrProvider.SetError(ctrl, "Le 1er caractére doit être [6]")
            Return False
        End If

        Dim intSum As Integer = 0
        intSum += CInt(CStr(strCodeCis(0))) * 2
        intSum += CInt(CStr(strCodeCis(1))) * 3
        intSum += CInt(CStr(strCodeCis(2))) * 4
        intSum += CInt(CStr(strCodeCis(3))) * 5
        intSum += CInt(CStr(strCodeCis(4))) * 6
        intSum += CInt(CStr(strCodeCis(5))) * 7
        intSum += CInt(CStr(strCodeCis(6))) * 8

        If (intSum Mod 11) = CInt(CStr(strCodeCis(7))) Then
            ErrProvider.SetError(ctrl, "")
            Return True
        Else
            ErrProvider.SetError(ctrl, "Le code CIS est incorrécte")
            Return False
        End If

    End Function

    Public Function Code_CIP_Presentation(ByVal strCodeCis As String, ByVal ctrl As Control, ByVal ErrProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider) As Boolean

        strCodeCis = Replace(strCodeCis, " ", "")
        If strCodeCis Is Nothing Then
            ErrProvider.SetError(ctrl, "")
            Return True
            Exit Function
        End If

        If Char.IsLetter(strCodeCis(0)) Then
            ErrProvider.SetError(ctrl, "")
            Return True
            Exit Function
        End If

        If strCodeCis.Length <> 7 Then
            ErrProvider.SetError(ctrl, "Le code CIP doit être constitué de 7 chiffres")
            Return False
        End If

        If strCodeCis(0) <> "3" And strCodeCis(0) <> "5" And strCodeCis(0) <> "4" Then
            ErrProvider.SetError(ctrl, "Le 1er caractére doit être [3] ou [4] ou  [5]")
            Return False
        End If

        Dim Res As Double
        Res = Mod11(strCodeCis) / 11
        If Mod11(strCodeCis) Mod 11 = 0 Then
            Res = CInt(Int(Res * 10 + 1))
            Dim Res1 As Integer = CInt(Res)
            If CStr(strCodeCis(6)) = "0" Then
                ErrProvider.SetError(ctrl, "")
                Return True
            Else
                ErrProvider.SetError(ctrl, "Le code CIP est incorrécte")
                Return False
            End If
        Else
            Res = CInt(Int(Res * 10 + 1))
            Dim Res1 As Integer = CInt(Res)
            If CStr(Res1)(CStr(Res1).Length - 1) = CStr(strCodeCis(6)) Then
                ErrProvider.SetError(ctrl, "")
                Return True
            Else
                ErrProvider.SetError(ctrl, "Le code CIP est incorrécte")
                Return False
            End If
        End If

    End Function

    Public Function Code_EAN(ByVal strCodeEAN As String, ByVal strCodeCIP As String, ByVal ctrl As Control, ByVal ErrProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider) As Boolean

        strCodeEAN = Replace(strCodeEAN, " ", "")
        If strCodeEAN Is Nothing Then
            ErrProvider.SetError(ctrl, "")
            Return True
            Exit Function
        End If

        If strCodeEAN.Length <> 13 Then
            ErrProvider.SetError(ctrl, "Le code EAN doit être constitué de 13 chiffre")
            Return False
        End If

        If Mid(strCodeEAN, 1, 4) <> "3400" And Mid(strCodeEAN, 1, 4) <> "3401" Then
            ErrProvider.SetError(ctrl, "Le Préfixes santé [" & CStr(Mid(strCodeEAN, 1, 4)) & "] est incorrécte")
            Return False
        End If

        If Mid(strCodeEAN, 6, 7) <> strCodeCIP Then
            ErrProvider.SetError(ctrl, "Le code [" & CStr(Mid(strCodeEAN, 6, 7)) & "] doit être le code CIP")
            Return False
        End If

        If Not Char.IsDigit(strCodeEAN(12)) Then
            ErrProvider.SetError(ctrl, "Le 13 chiffre du code EAN doit être numérique")
            Return False
        End If

        Dim Res As Integer = 0
        Res += CInt(CStr(strCodeEAN(1)))
        Res += CInt(CStr(strCodeEAN(3)))
        Res += CInt(CStr(strCodeEAN(5)))
        Res += CInt(CStr(strCodeEAN(7)))
        Res += CInt(CStr(strCodeEAN(9)))
        Res += CInt(CStr(strCodeEAN(11)))

        Res = Res * 3

        Dim Res2 As Integer = 0
        Res2 += CInt(CStr(strCodeEAN(0)))
        Res2 += CInt(CStr(strCodeEAN(2)))
        Res2 += CInt(CStr(strCodeEAN(4)))
        Res2 += CInt(CStr(strCodeEAN(6)))
        Res2 += CInt(CStr(strCodeEAN(8)))
        Res2 += CInt(CStr(strCodeEAN(10)))

        Res += Res2

        If Res Mod 10 = 0 Then
            If "0" = CStr(strCodeEAN(12)) Then
                ErrProvider.SetError(ctrl, "")
                Return True
            Else
                ErrProvider.SetError(ctrl, "Le code EAN est incorrécte")
                Return False
            End If
        Else
            Dim cle As Integer = (Int(Res / 10) + 1) * 10 - Res

            If CStr(cle) = CStr(strCodeEAN(12)) Then
                ErrProvider.SetError(ctrl, "")
                Return True
            Else
                ErrProvider.SetError(ctrl, "Le code EAN est incorrécte")
                Return False
            End If
        End If
    End Function

    Public Function Code_UCD(ByVal strCodeCis As String, ByVal ctrl As Control, ByVal ErrProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider, Optional ByVal MySP_PK As Integer = -1) As Boolean

        strCodeCis = Replace(strCodeCis, " ", "")
        If strCodeCis Is Nothing Then
            ErrProvider.SetError(ctrl, "")
            Return True
            Exit Function
        End If
        If strCodeCis.Length <> 7 Then
            ErrProvider.SetError(ctrl, "Le code UCD doit être constitué de 7 chiffre")
            Return False
        End If

        If strCodeCis(0) <> "9" Then
            ErrProvider.SetError(ctrl, "Le 1er caractére doit être [9]")
            Return False
        End If

        Dim Res As Double
        Res = Mod11(strCodeCis) / 11
        If Mod11(strCodeCis) Mod 11 > 0 Then
            Res = CInt(Int(Res * 10 + 1))
            Dim Res1 As Integer = CInt(Res)

            If CStr(Res1)(CStr(Res1).Length - 1) = CStr(strCodeCis(6)) Then
                Dim strCondition As String = ""
                strCondition = " SP_CIPUCD = " & strCodeCis
                If MySP_PK <> -1 Then
                    strCondition &= " AND SP_CODE_SQ_PK <> " & MySP_PK
                End If
                If cn.HasRow("THERIAQUE.SP_SPECIALITE", strCondition) Then
                    ErrProvider.SetError(ctrl, "Le code UCD est déjà utilisé")
                    Return False
                Else
                    ErrProvider.SetError(ctrl, "")
                    Return True
                End If
            Else
                ErrProvider.SetError(ctrl, "Le code UCD est incorrécte")
                Return False
            End If
        Else
            Res = CInt(Int(Res * 10 + 1))
            Dim Res1 As Integer = CInt(Res)

            If CStr(strCodeCis(6)) = "0" Then
                Dim strCondition As String = ""
                strCondition = " SP_CIPUCD = " & strCodeCis
                If MySP_PK <> -1 Then
                    strCondition &= " AND SP_CODE_SQ_PK <> " & MySP_PK
                End If
                If cn.HasRow("THERIAQUE.SP_SPECIALITE", strCondition) Then
                    ErrProvider.SetError(ctrl, "Le code UCD est déjà utilisé")
                    Return False
                Else
                    ErrProvider.SetError(ctrl, "")
                    Return True
                End If
            Else
                ErrProvider.SetError(ctrl, "Le code UCD est incorrécte")
                Return False
            End If

        End If

    End Function

    Public Function Code_UCD13(ByVal sCodeUCD13 As String, ByVal sCodeUCD7 As String, ByVal ctrl As Control, ByVal ErrProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider) As Boolean

        sCodeUCD13 = Replace(sCodeUCD13, " ", "")
        If sCodeUCD13 Is Nothing Then
            ErrProvider.SetError(ctrl, "")
            Return True
            Exit Function
        End If

        If sCodeUCD13.Length <> 13 Then
            ErrProvider.SetError(ctrl, "Le code UCD13 doit être constitué de 13 chiffre")
            Return False
        End If

        If Mid(sCodeUCD13, 1, 5) <> "34008" Then
            ErrProvider.SetError(ctrl, "Le Préfixes santé [" & CStr(Mid(sCodeUCD13, 1, 5)) & "] est incorrécte")
            Return False
        End If

        If Mid(sCodeUCD13, 6, 7) <> sCodeUCD7 Then
            ErrProvider.SetError(ctrl, "Le code [" & CStr(Mid(sCodeUCD13, 6, 7)) & "] doit être le code UCD7")
            Return False
        End If

        If Not Char.IsDigit(sCodeUCD13(12)) Then
            ErrProvider.SetError(ctrl, "Le 13 chiffre du code UCD13 doit être numérique")
            Return False
        End If
        Dim sTemp As String = StrReverse(sCodeUCD13)
        Dim iSommeImpaires As Integer = 0
        iSommeImpaires = CInt(CStr(sTemp(1)))
        iSommeImpaires += CInt(CStr(sTemp(3)))
        iSommeImpaires += CInt(CStr(sTemp(5)))
        iSommeImpaires += CInt(CStr(sTemp(7)))
        iSommeImpaires += CInt(CStr(sTemp(9)))
        iSommeImpaires += CInt(CStr(sTemp(11)))

        Dim iSommePaires As Integer = 0
        iSommePaires = CInt(CStr(sTemp(2)))
        iSommePaires += CInt(CStr(sTemp(4)))
        iSommePaires += CInt(CStr(sTemp(6)))
        iSommePaires += CInt(CStr(sTemp(8)))
        iSommePaires += CInt(CStr(sTemp(10)))
        iSommePaires += CInt(CStr(sTemp(12)))

        Dim iRes As Integer
        iRes = iSommePaires + 3 * iSommeImpaires

        If iRes Mod 10 = 0 Then
            If "0" = CStr(sCodeUCD13(12)) Then
                ErrProvider.SetError(ctrl, "")
                Return True
            Else
                ErrProvider.SetError(ctrl, "Le code UCD13 est incorrécte")
                Return False
            End If
        Else
            Dim cle As Integer = 10 - (iRes Mod 10)
            If CStr(cle) = CStr(sCodeUCD13(12)) Then
                ErrProvider.SetError(ctrl, "")
                Return True
            Else
                ErrProvider.SetError(ctrl, "Le code UCD13 est incorrécte")
                Return False
            End If
        End If
    End Function

    Public Function Code_CAS(ByVal strCodeCas As String, ByVal ctrl As Control, ByVal ErrProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider) As Boolean
        Dim Pos, Pos2 As Integer
        Dim intSum As Integer

        Pos = -1
        Pos2 = -1

        strCodeCas = strCodeCas.Replace(" ", "")
        Pos = strCodeCas.IndexOf("-", 0)
        If Pos > 0 Then
            Pos2 = strCodeCas.IndexOf("-", Pos + 1)
            If (Pos2 > Pos + 1) And Pos2 < strCodeCas.Length - 1 Then
                If IsNumeric(Mid(strCodeCas, 1, Pos)) And Mid(strCodeCas, 1, Pos).Length <= 7 Then
                    If IsNumeric(Mid(strCodeCas, Pos + 2, Pos2 - Pos - 1)) And Mid(strCodeCas, Pos + 2, Pos2 - Pos - 1).Length <= 2 Then
                        If IsNumeric(Mid(strCodeCas, Pos2 + 2)) And Mid(strCodeCas, Pos2 + 2).Length = 1 Then
                            'Ok
                        Else
                            ErrProvider.SetError(ctrl, strCodeCas)
                            Return False
                        End If
                    Else
                        ErrProvider.SetError(ctrl, strCodeCas)
                        Return False
                    End If
                Else
                    ErrProvider.SetError(ctrl, strCodeCas)
                    Return False
                End If
            Else
                ErrProvider.SetError(ctrl, strCodeCas)
                Return False
            End If
        Else
            ErrProvider.SetError(ctrl, strCodeCas)
            Return False
        End If

        Dim intTemp As Integer = Pos2 - 1
        For inti As Integer = 0 To Pos2 - 1
            If strCodeCas(inti) <> "-" Then
                intSum += CInt(CStr(strCodeCas(inti))) * intTemp
                intTemp -= 1
            End If
        Next

        If (intSum Mod 10) = CStr(strCodeCas(strCodeCas.Length - 1)) Then
            Return True
        Else
            ErrProvider.SetError(ctrl, strCodeCasIncorrect)
            Return False
        End If

    End Function

    Public Function Code_MedVirtuelle(ByVal strCode As String, ByVal ErrProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider) As String
        Dim diff As Integer = 7 - strCode.Length
        Dim ZZ As New String("0", diff)
        Dim res, IntReturn As Integer

        strCode = ZZ & strCode
        IntReturn = CInt(strCode)
        res = Mod11(CStr(strCode)) / 11

        Do While res = 0
            IntReturn += 1000000
            res = Mod11(CStr(IntReturn)) / 11
        Loop
        diff = 7 - CStr(IntReturn).Length
        ZZ = New String("0", diff)
        Return ZZ & IntReturn
    End Function

    Public Function Code_MedVirtuelle13(ByVal strCode As String, ByVal ErrProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider) As String
        Dim diff As Integer = 13 - strCode.Length
        Dim ZZ As New String("0", diff)
        strCode = ZZ & strCode


        Dim sTemp As String = StrReverse(strCode)
        Dim iSommeImpaires As Integer = 0
        iSommeImpaires = CInt(CStr(sTemp(1)))
        iSommeImpaires += CInt(CStr(sTemp(3)))
        iSommeImpaires += CInt(CStr(sTemp(5)))
        iSommeImpaires += CInt(CStr(sTemp(7)))
        iSommeImpaires += CInt(CStr(sTemp(9)))
        iSommeImpaires += CInt(CStr(sTemp(11)))

        Dim iSommePaires As Integer = 0
        iSommePaires = CInt(CStr(sTemp(0)))
        iSommePaires = CInt(CStr(sTemp(2)))
        iSommePaires += CInt(CStr(sTemp(4)))
        iSommePaires += CInt(CStr(sTemp(6)))
        iSommePaires += CInt(CStr(sTemp(8)))
        iSommePaires += CInt(CStr(sTemp(10)))
        iSommePaires += CInt(CStr(sTemp(12)))

        Dim iRes As Integer
        iRes = iSommePaires + 3 * iSommeImpaires

        Do While iRes Mod 10 = 0
            strCode = CStr(CInt(strCode) + 1000000000000)
            sTemp = StrReverse(strCode)
            iSommeImpaires = 0
            iSommeImpaires = CInt(CStr(sTemp(1)))
            iSommeImpaires += CInt(CStr(sTemp(3)))
            iSommeImpaires += CInt(CStr(sTemp(5)))
            iSommeImpaires += CInt(CStr(sTemp(7)))
            iSommeImpaires += CInt(CStr(sTemp(9)))
            iSommeImpaires += CInt(CStr(sTemp(11)))

            iSommePaires = 0
            iSommePaires = CInt(CStr(sTemp(2)))
            iSommePaires += CInt(CStr(sTemp(4)))
            iSommePaires += CInt(CStr(sTemp(6)))
            iSommePaires += CInt(CStr(sTemp(8)))
            iSommePaires += CInt(CStr(sTemp(10)))
            iSommePaires += CInt(CStr(sTemp(12)))

            iRes = iSommePaires + 3 * iSommeImpaires
        Loop
        
        Return strCode
    End Function

    Public Function Mod11(ByVal strCodeCis As String) As Integer

        Dim intSum As Integer = 0
        intSum += CInt(CStr(strCodeCis(0))) * 2
        intSum += CInt(CStr(strCodeCis(1))) * 3
        intSum += CInt(CStr(strCodeCis(2))) * 4
        intSum += CInt(CStr(strCodeCis(3))) * 5
        intSum += CInt(CStr(strCodeCis(4))) * 6
        intSum += CInt(CStr(strCodeCis(5))) * 7

        Return intSum

    End Function

End Module
