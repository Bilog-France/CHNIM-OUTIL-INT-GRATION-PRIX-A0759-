Imports System
Imports System.io
Imports System.Data
Imports System.Data.SqlClient

Module MdlGeneral

    Public cnSql As SqlClient.SqlConnection
    Public sStrConnect As New String("Persist Security Info=False;Integrated Security=SSPI;database=%1;server=%2;Connect Timeout=30")

    Public Function CreateSQLDataBase(ByVal sDbNAme As String, ByVal sPath As String, ByRef cnConnection As SqlClient.SqlConnection) As Boolean
        Dim sSQL As String

        Try

            Call Directory.CreateDirectory(sPath)
            sSQL = "CREATE DATABASE " & sDbNAme & " ON "
            sSQL = sSQL & "( NAME = '" & sDbNAme & "dat', FILENAME = '" & sPath & "\" & sDbNAme & "dat.mdf',"
            sSQL = sSQL & "  SIZE = 1, FILEGROWTH = 5 )"
            sSQL = sSQL & " LOG ON"
            sSQL = sSQL & "( NAME = '" & sDbNAme & "log', FILENAME = '" & sPath & "\" & sDbNAme & "log.ldf',"
            sSQL = sSQL & "  SIZE = 1MB, FILEGROWTH = 5MB )"

            Call ExecuteQuery(sSQL, cnConnection)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CreateTable(ByVal sTableName As String, ByVal sFileStruct As String, ByRef cnConnection As SqlClient.SqlConnection) As Boolean

        Dim vFields As String()
        Dim sSql As String
        Dim iCpt As Integer
        Dim fFile As FileInfo

        Try
            vFields = ReadFieldFromFileStruct(sFileStruct)
            sSql = "CREATE TABLE [" & sTableName & "] ("
            For iCpt = vFields.GetLowerBound(0) To vFields.GetUpperBound(0)
                sSql = sSql & " " & vFields.GetValue(iCpt) & IIf(iCpt = vFields.GetUpperBound(0), ")", ", ") & vbCr
            Next
            Call ExecuteQuery("DROP TABLE [" & sTableName & "]", cnConnection)
            Call ExecuteQuery(sSql, cnConnection)
        Catch ex As Exception
        End Try
    End Function

    Public Function ReadFieldFromFileStruct(ByVal sFileStruct As String) As String()

        Dim fFile As StreamReader
        Dim sFields As String()
        Dim sFieldsType As String()
        Dim sLigne As String
        Dim iCpt As Integer

        Try

            iCpt = 0
            If Not File.Exists(sFileStruct) Then Exit Function
            fFile = New StreamReader(sFileStruct, System.Text.ASCIIEncoding.Default, True)
            Do
                sLigne = Replace(Replace(fFile.ReadLine, ")", ""), "(", "")   'Enlever les paramenthèse 
                If iCpt = 0 Then sFields = Split(sLigne, ",")
                If iCpt = 1 Then sFieldsType = Split(sLigne, ",")
                iCpt += 1
            Loop Until sLigne Is Nothing Or iCpt > 1
            Call fFile.Close()

            If sFields.GetUpperBound(0) = 0 Then Exit Function

            For iCpt = sFields.GetLowerBound(0) To sFields.GetUpperBound(0)
                Select Case Mid(sFieldsType.GetValue(iCpt), 1, 1)
                    Case "L"
                        sFields.SetValue("[" & sFields.GetValue(iCpt) & "]" & " Bit", iCpt)
                    Case "N"
                        Select Case Mid(sFieldsType.GetValue(iCpt), 2, Len(sFieldsType.GetValue(iCpt)) - 1)
                            Case 40
                                sFields.SetValue("[" & sFields.GetValue(iCpt) & "]" & " Float", iCpt)
                            Case Else
                                sFields.SetValue("[" & sFields.GetValue(iCpt) & "]" & " Int", iCpt)
                        End Select
                    Case "D"
                        sFields.SetValue("[" & sFields.GetValue(iCpt) & "]" & " nvarchar(10)", iCpt)
                    Case "C"
                        sFields.SetValue("[" & sFields.GetValue(iCpt) & "]" & " nvarchar(" & Mid(sFieldsType.GetValue(iCpt), 2, Len(sFieldsType.GetValue(iCpt)) - 1) & ")", iCpt)
                End Select
            Next
            Return sFields
        Catch ex As Exception
            Throw (ex)
        End Try
    End Function

    Public Function InitDataTable(ByVal sDbName As String, ByVal sServer As String, ByRef cnConnection As SqlClient.SqlConnection) As Boolean

        Dim dtTable As DataTable
        Dim objRow As DataRow

        Try
            dtTable = OpenTable("SELECT " & sDbName & "..sysobjects.name FROM " & sDbName & "..sysobjects WHERE " & sDbName & "..sysobjects.xtype ='U' AND " & sDbName & "..sysobjects.name <> 'dtproperties'", cnConnection)

            cnConnection.ChangeDatabase(sDbName)
            For Each objRow In dtTable.Rows

                Call ExecuteQuery("ALTER TABLE " & objRow.Item(1) & " DISABLE TRIGGER ALL ", cnConnection)
                Call ExecuteQuery("DELETE FROM " & objRow.Item(1), cnConnection)
                Call ExecuteQuery("ALTER TABLE " & objRow.Item(1) & " ENABLE TRIGGER ALL ", cnConnection)
            Next
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function OpenTable(ByVal sSql As String, ByRef cnAPP As SqlClient.SqlConnection) As System.Data.DataTable

        Dim daAdapter As SqlClient.SqlDataAdapter
        Dim cmCommand As SqlClient.SqlCommand

        Try
            cmCommand = New SqlClient.SqlCommand(sSql, cnAPP)
            daAdapter = New SqlClient.SqlDataAdapter(cmCommand)
            OpenTable = New System.Data.DataTable

            daAdapter.Fill(OpenTable)
        Catch ex As Exception
            Throw ex
        Catch ex_Sql As SqlException
            Throw ex_Sql
        End Try
    End Function

    Public Function ExecuteQuery(ByVal sSql As String, ByRef cnAPP As SqlClient.SqlConnection) As Boolean

        Try
            ExecuteQuery = False
            Dim cmCommand As New SqlClient.SqlCommand(sSql, cnAPP)
            Call cmCommand.ExecuteNonQuery()
            ExecuteQuery = True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CreateSqlConnection(ByVal sDbName As String, ByVal sServerName As String) As Boolean
        Try
            cnSql = New SqlConnection(Replace(Replace(sStrConnect, "%2", sServerName), "%1", sDbName))
            cnSql.Open()
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function CreateSqlConnection2(ByVal sDbName As String, ByVal sServerName As String, ByVal user As String, ByVal password As String) As Boolean

        Dim sCN_APP As New String("SERVER=SQLOLEDB;Data Source=%1;Initial Catalog=%2;UID=%3;PASSWORD=%4")
        Try
            sCN_APP = Replace(sCN_APP, "%1", sServerName)
            sCN_APP = Replace(sCN_APP, "%2", IIf(sDbName = "", "master", sDbName))
            sCN_APP = Replace(sCN_APP, "%3", user)
            sCN_APP = Replace(sCN_APP, "%4", password)
            'sCN_APP = "Persist Security Info=False;database=xmedversion6;server=bilog-prt-002\XMEd;user id = sa; password = bilogsa"

            cnSql = New SqlClient.SqlConnection(sCN_APP)
            cnSql.Open()
        Catch ex As Exception
            'Throw ex
        End Try

    End Function

    Public Function ExistsDb(ByVal sDbName As String, ByRef cnConnection As SqlClient.SqlConnection) As Boolean
        Try
            Dim rsTable As New DataTable
            rsTable = OpenTable("SELECT name FROM master..sysdatabases WHERE master..sysdatabases.name = '" & sDbName & "'", cnConnection)
            ExistsDb = (rsTable.Rows.Count <> 0)
        Catch ex As Exception
        End Try
    End Function

    Public Function DropTable(ByVal sTableName As String, ByRef cnConnection As SqlClient.SqlConnection) As Boolean
        Try
            DropTable = ExecuteQuery("DROP TABLE [" & sTableName & "]", cnConnection)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function FillDataTable(ByVal sTableName As String, ByVal sDataFile As String, ByRef cnConnection As SqlClient.SqlConnection) As Boolean
        Try

        Catch ex As Exception

        End Try
    End Function

    Public Function CorrectDataFile(ByVal sFile As String, ByVal sPath As String) As Boolean

        Dim fFile As StreamReader
        Dim fTmp As StreamWriter
        Dim sLigneStruct As String()
        Dim sLigneData As String()
        Dim sLigneDataTmp As String()
        Dim sLigne As String
        Dim iCpt As Integer

        Try
            CorrectDataFile = False
            If Not File.Exists(sPath & "\" & sFile & ".txt") Then Exit Function
            If File.Exists(sPath & "\" & "tmp.tmp") Then File.Delete(sPath & "\" & "tmp.tmp")
            fFile = New StreamReader(sPath & "\" & sFile & ".txt", System.Text.ASCIIEncoding.Default, True)
            fTmp = New StreamWriter(sPath & "\" & "tmp.tmp", True, System.Text.ASCIIEncoding.Default)

            sLigneStruct = Split(fFile.ReadLine(), ",")
            fTmp.WriteLine(Join(sLigneStruct, ","))
            Do
                sLigne = fFile.ReadLine()
                If sLigne Is Nothing Then Exit Do
                sLigneData = Split(sLigne, ",")
                While True
                    If (sLigneData.GetLength(0) >= sLigneStruct.GetLength(0)) Then Exit While
                    sLigne = fFile.ReadLine()
                    If sLigne Is Nothing Then Exit While
                    sLigneDataTmp = Split(sLigne, ",")
                    sLigneData = Split(Join(sLigneData, ",") & Join(sLigneDataTmp, ","), ",")
                End While

                For iCpt = sLigneData.GetLowerBound(0) To sLigneData.GetUpperBound(0)
                    If Trim(sLigneData.GetValue(iCpt)) = "" Then sLigneData.SetValue("''", iCpt)
                    If sLigneData.GetValue(iCpt) Is Nothing Then sLigneData.SetValue("''", iCpt)
                Next
                fTmp.WriteLine(Join(sLigneData, ","))
            Loop

            fTmp.Close()
            fFile.Close()

            File.Delete(sPath & "\" & sFile & ".txt")
            File.Copy(sPath & "\" & "tmp.tmp", sPath & "\" & sFile & ".txt")
            File.Delete(sPath & "\" & "tmp.tmp")
            CorrectDataFile = True
        Catch ex As Exception
            CorrectDataFile = False
            Throw ex
        End Try
    End Function

    Public Function CorrectDataFile_(ByVal sFile As String, ByVal sPath As String) As Boolean

        Dim fFile As StreamReader
        Dim fTmp As StreamWriter
        Dim sLigneStruct As String()
        Dim sLigneData As String()
        Dim sLigneDataTmp As String()
        Dim sLigne As String
        Dim sLigneSuivant As String
        Dim iCpt As Integer

        Try
            CorrectDataFile_ = False
            If Not File.Exists(sPath & "\" & sFile) Then Exit Function
            If File.Exists(sPath & "\" & "tmp.tmp") Then File.Delete(sPath & "\" & "tmp.tmp")
            fFile = New StreamReader(sPath & "\" & sFile, System.Text.ASCIIEncoding.Default, True)
            fTmp = New StreamWriter(sPath & "\" & "tmp.tmp", True, System.Text.ASCIIEncoding.Default)

            sLigne = fFile.ReadLine()
            If Not (sLigne Is Nothing) Then
                Do
                    sLigneSuivant = fFile.ReadLine()
                    If sLigneSuivant Is Nothing Then
                        fTmp.WriteLine(sLigne)
                        Exit Do
                    End If

                    If Mid(sLigneSuivant, 1, 6) = "INSERT" Then
                        fTmp.WriteLine(sLigne)
                        sLigne = ""
                    End If

                    sLigne = sLigne + sLigneSuivant
                Loop
            End If

            fTmp.Close()
            fFile.Close()

            File.Delete(sPath & "\" & sFile)
            File.Copy(sPath & "\" & "tmp.tmp", sPath & "\" & sFile)
            File.Delete(sPath & "\" & "tmp.tmp")
            CorrectDataFile_ = True
        Catch ex As Exception
            CorrectDataFile_ = False
            Throw ex
        End Try
    End Function

End Module
