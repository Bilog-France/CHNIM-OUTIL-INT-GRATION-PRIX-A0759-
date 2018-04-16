Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class PrixJO

    Shared swLog As StreamWriter

    Shared Sub LoadCSV(ByVal typeCalcul As Boolean)

        Dim fopen As New OpenFileDialog
        Dim Err As ErrorFormat

        fopen.Filter = "Excel Worksheets|*.csv*|*.|*.*"
        fopen.ShowDialog()

        If (Not String.IsNullOrEmpty(fopen.FileName)) Then

            Dim dr As String = fopen.FileName.Replace("\" + fopen.SafeFileName, "")

            If (Not Directory.Exists(dr + "\Log")) Then
                Directory.CreateDirectory(dr + "\Log")
            End If

            Dim fileName As String = dr + "\Log/PrixLog-" & DateTime.Now.ToShortDateString().Replace("/", "-") & " " & DateTime.Now.TimeOfDay.ToString().Substring(0, 8).Replace(":", "-") & ".csv"
            Dim fStr As FileStream = File.Create(fileName)
            fStr.Close()
            swLog = File.CreateText(fileName)
            swLog.WriteLine("CIP;Erreur")

            Dim afile As FileIO.TextFieldParser = New FileIO.TextFieldParser(fopen.FileName)
            Dim CurrentRecord As String ' this array will hold each line of data
            afile.TextFieldType = FileIO.FieldType.Delimited
            afile.Delimiters = New String() {";"}
            afile.HasFieldsEnclosedInQuotes = True

            Dim IsValid As Boolean = True
            'CurrentRecord = afile.ReadLine()
            ' parse the actual file
            Do While Not afile.EndOfData()
                Try
                    CurrentRecord = afile.ReadLine()
                    Err = TestFormat(CurrentRecord)
                    If (Not Err.FormatValide) Then
                        IsValid = False
                        MsgBox(Err.ErrorText)
                        swLog.Close()
                        Exit Sub
                    End If
                Catch ex As FileIO.MalformedLineException
                    MsgBox(ex.Message)
                    swLog.Close()
                    fStr.Close()
                    Exit Sub
                End Try
            Loop

            If IsValid Then

                AlgorithmePrix(typeCalcul, fopen.FileName)

            End If
            fStr.Close()
        End If

        swLog.Close()

    End Sub

    Shared Function TestFormat(ByVal Line As String) As ErrorFormat

        Dim fInfo As ErrorFormat
        Dim d As Decimal
        Dim dt As Date

        fInfo.ErrorText = ""
        Dim a As String() = Line.Split(";")

        If (a.Length = 3) Then

            If (a(0).Length = 13) Then
                If (Not Decimal.TryParse(a(1), d)) Then
                    fInfo.FormatValide = False
                    fInfo.ErrorText = "La colonne PRIX de la ligne (" & Line & ") doit être un décimal "
                Else
                    If (Not DateTime.TryParse(a(2), dt)) Then
                        fInfo.FormatValide = False
                        fInfo.ErrorText = "Le format Date de la ligne (" & Line & ") est incorrect "
                    Else
                        fInfo.ErrorText = ""
                        fInfo.FormatValide = True
                    End If

                End If
            Else
                fInfo.FormatValide = False
                fInfo.ErrorText = "La colonne CIP13 de la ligne (" & Line & ") doit contenir 13 caractères "
            End If
        Else
            fInfo.ErrorText = "La ligne " & Line & " doit contenir 3 colonnes "
            fInfo.FormatValide = False
        End If

        Return fInfo

    End Function

    Public Structure ErrorFormat
        Dim FormatValide As Boolean
        Dim ErrorText As String
    End Structure

    Private Function CreateCSV() As String

        Dim fopen As New SaveFileDialog()
        fopen.Filter = "Excel Worksheets|*.csv*|*.|*.*"
        fopen.ShowDialog()
        Dim fname As String = fopen.FileName
        If (Not fname.EndsWith(".csv")) Then
            fname &= ".csv"
        End If
        Dim sw As StreamWriter = File.CreateText(fname)
        sw.WriteLine("CIP;Erreur")
        sw.Close()

        Return fname

    End Function

    Shared Sub addLogInCSV(ByVal sw As StreamWriter, ByVal CIP As String, ByVal Err As String)

        sw.WriteLine(CIP & ";" & Err)

    End Sub

    Shared Sub AlgorithmePrix(ByVal typecalcul As Boolean, ByVal path As String)

        Dim afile As FileIO.TextFieldParser = New FileIO.TextFieldParser(path)
        Dim CurrentRecord As String ' this array will hold each line of data
        Dim a As String()

        afile.TextFieldType = FileIO.FieldType.Delimited
        afile.Delimiters = New String() {";"}
        afile.HasFieldsEnclosedInQuotes = True

        'CurrentRecord = afile.ReadLine()
        Do While Not afile.EndOfData()
            Try
                CurrentRecord = afile.ReadLine()
                a = CurrentRecord.Split(";")

                If (typecalcul) Then
                    Calculprix(a)
                Else
                    CalculCochage(a)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
        Loop
        If (typecalcul) Then
            MsgBox("Calcul des prix terminé")
        Else
            MsgBox("Cochage terminé")
        End If


    End Sub

    Shared Sub Calculprix(ByVal a As String())

        Dim query As String = " select * from theriaque.PRE_PRESENTATION where PRE_EAN_REF='" & a(0) & "' "
        Dim dt As DataTable = cn.MySelect(query)
        a(1) = a(1).Replace(",", ".").Replace(" ", "")
        If (dt.Rows.Count = 0) Then

            swLog.WriteLine(a(0) & ";1")
            Exit Sub

        Else
            query = " select null from theriaque.PRIPRE_PRIX_PRESENTATION where PRIPRE_PRE_CODE_FK_PK = '" & dt.Rows(0).Item("PRE_CODE_PK") & "' and PRIPRE_DATE_APPLI_PK=" & "CONVERT(datetime,'" & a(2) & "',103)"
            If (cn.MySelect(query).Rows.Count <> 0) Then

                swLog.WriteLine(a(0) & ";4")
                Exit Sub

            Else

                query = " INSERT INTO [theriaque].[PRIPRE_PRIX_PRESENTATION] "
                query &= " ([PRIPRE_DATE_APPLI_PK],[PRIPRE_PRE_CODE_FK_PK],[PRIPRE_PRIX_EURO],[PRIPRE_CIP13]) "
                query &= " VALUES(CONVERT(datetime,'" & a(2) & "',103),'" & dt.Rows(0).Item("PRE_CODE_PK") & "'," & a(1) & ",'" & a(0) & "') "

                cn.Execute(query)

                swLog.WriteLine(a(0) & ";0")
                Exit Sub

            End If

        End If

    End Sub

    Shared Sub CalculCochage(ByVal a As String())

        Dim query As String = " select * from theriaque.PRE_PRESENTATION where PRE_EAN_REF='" & a(0) & "' "
        Dim dt As DataTable = cn.MySelect(query)
        a(1) = a(1).Replace(",", ".").Replace(" ", "")

        If (dt.Rows.Count = 0) Then

            swLog.WriteLine(a(0) & ";1")
            Exit Sub

        Else

            query = " select * from theriaque.PRIPRE_PRIX_PRESENTATION where PRIPRE_CIP13 = '" & a(0) & "' and PRIPRE_DATE_APPLI_PK=CONVERT(datetime,'" & a(2) & "',103)"

            Dim dt1 As DataTable = cn.MySelect(query)
            If (dt1.Rows.Count = 0) Then

                swLog.WriteLine(a(0) & ";2")
                Exit Sub

            Else

                If (dt1.Rows(0).Item("PRIPRE_PRIX_EURO") <> Decimal.Parse(a(1).Replace(".", ","))) Then
                    swLog.WriteLine(a(0) & ";3")
                    Exit Sub
                Else

                    query = " UPDATE [theriaque].[PRIPRE_PRIX_PRESENTATION] "
                    query &= " SET PRIPRE_Valide = 0 "
                    query &= "  where PRIPRE_CIP13='" & a(0) & "'"
                    cn.Execute(query)


                    query = " UPDATE [theriaque].[PRIPRE_PRIX_PRESENTATION] "
                    query &= " SET PRIPRE_Valide = 1 where PRIPRE_CIP13 = '" & a(0) & "'"
                    query &= " and PRIPRE_PRIX_EURO = " & a(1) & " and PRIPRE_DATE_APPLI_PK = CONVERT(datetime,'" & a(2) & "',103)"
                    cn.Execute(query)

                    swLog.WriteLine(a(0) & ";0")
                    Exit Sub

                End If


                query = " INSERT INTO [theriaque].[PRIPRE_PRIX_PRESENTATION] "
                query &= " ([PRIPRE_DATE_APPLI_PK],[PRIPRE_PRE_CODE_FK_PK],[PRIPRE_PRIX_EURO],[PRIPRE_CIP13]) "
                query &= " VALUES(CONVERT(datetime,'" & a(2) & "',103),'" & dt.Rows(0).Item("PRE_CODE_PK") & "'," & a(1) & ",'" & a(0) & "') "

                cn.Execute(query)

            End If

        End If

    End Sub

End Class
