'=========================================== Classe Connexion ===============
'Nom:  ClsSQL.vb
'Module : Classe Connexion
'Date de Création: 19/04/2004
'Auteurs : LZA
'|Dernières modifications : 12/05/2004 | User : LZA | Taches : 10070 |
'=========================================================================================
Imports System.Data.Sqlclient
Imports System.Data.OleDb
Imports System.IO
Imports System.Windows.Forms.BindingManagerBase
Imports System.Configuration

Public Class SQLcn

    Public StopUpdateUT_IDV As Boolean 'Eviter le traitement circulaire
    Private IDConnectionValue As Integer
    Public Identity As Integer
    Private SQlConValue As New System.Data.SqlClient.SqlConnection()
    Private sConnexionValue As String
    Private FileNameValue As String
    Private DefaultDBValue As String
    Private SQL1 As String
    Public CnInfo As ConnexionInfo

    'Public Property CnInfo() As ConnexionInfo
    '    Get
    '        Return CnInfoValue
    '    End Get
    '    Set(ByVal Value As ConnexionInfo)
    '        CnInfoValue = Value
    '    End Set
    'End Property


    Public Property StopUpdateUT_ID() As Boolean
        Get
            Return StopUpdateUT_IDV
        End Get
        Set(ByVal Value As Boolean)
            StopUpdateUT_IDV = Value
        End Set
    End Property

    Public Property SQlCon() As SqlConnection
        Get
            Return SQlConValue
        End Get
        Set(ByVal Value As SqlConnection)
            SQlConValue = Value
        End Set
    End Property

    Public Property sConnexion() As String
        Get
            Return sConnexionValue
        End Get
        Set(ByVal Value As String)
            sConnexionValue = Value
            InitCnInfo()
            Me.SQlCon.ConnectionString = Value
        End Set
    End Property

    Public Property DefaultDB() As String
        Get
            Return DefaultDBValue
        End Get
        Set(ByVal Value As String)
            DefaultDBValue = Value
        End Set
    End Property

    Public Property FileName() As String
        Get
            Return FileNameValue
        End Get
        Set(ByVal Value As String)
            FileNameValue = Value
        End Set
    End Property

    Public Property IDConnection() As Integer
        Get
            Return IDConnectionValue
        End Get
        Set(ByVal Value As Integer)
            IDConnectionValue = Value
        End Set
    End Property

    Public Function Open() As SqlConnection
        SQlCon = New SqlConnection(sConnexion)
        Try
            SQlCon.Open()
            Return SQlCon
        Catch ex As SqlException
            Dim er As SqlError
            Dim sMsgErreurs As String
            sMsgErreurs = "Fournisseur:" & ex.Source & vbCr
            sMsgErreurs &= "Serveur:" & ex.Server & vbCr & vbCr
            For Each er In ex.Errors
                sMsgErreurs &= ">" & ex.Message & vbCr
            Next
            Process_Message(ex.Message & vbNewLine & "Impossible de se connecter à cette base de données: [" & SQlCon.Database & "]" & vbNewLine & "Veuillez mettre à jour les paramètres de configuration de la connexion", MsgBoxStyle.OkOnly, MsgBoxStyle.Exclamation, , , False, , , , sMsgErreurs)
            ' Process_Message_Error(ex, "THERIAQUE", "M186", sMsgErreurs)
        End Try
    End Function

    Sub Close()
        Try
            SQlCon.Close()
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "M182")
        End Try
    End Sub

    Function SQLDate(ByVal WDate As Date) As String
        Try
            If Convert.ToString(WDate) <> "" Then
                Return " cast('" & Format(WDate, "dd/MM/yyyy") & "' as datetime)"
            Else
                Return ""
            End If
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "C43")
        End Try
    End Function
    Function SQLDate2(ByVal WDate As Date) As String
        Try
            If Convert.ToString(WDate) <> "" Then
                Return " convert(datetime,'" & Format(WDate, "MM/dd/yyyy") & "', 101)"
            Else
                Return ""
            End If
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "C43")
        End Try
    End Function

    Function SQLDateTime(ByVal WDate As Date) As String
        Try
            Dim d As String = WDate.ToString("dd/MM/yyyy h:mm:ss tt") ',  System.Globalization.DateTimeFormatInfo.InvariantInfo)

            Return " cast('" & d & "' as datetime)"
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "C44")
        End Try
    End Function

    Function SQLText(ByVal txt As Object) As String
        Try
            txt = Replace(txt, "*", "")
            If txt Is Nothing Then Return "''"
            If Not txt Is Nothing Then Return "'" & Replace(txt, "'", "''") & "'"
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "C45")
        End Try
    End Function

    Function SQLTextLike(ByVal txt As String) As String
        Try
            txt = Replace(txt, "*", "")
            If txt Is Nothing Or txt = "" Then Return "' %'"
            txt = Replace(txt, "%", "[%]")
            If Not txt Is Nothing Then Return "'" & Replace(txt, "'", "''") & "%'"
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "C46")
        End Try
    End Function

    Function SQLTextLike2(ByVal txt As String) As String
        Try
            txt = Replace(txt, "*", "")
            If txt Is Nothing Or txt = "" Then Return "'% %'"
            txt = Replace(txt, "%", "[%]")
            If Not txt Is Nothing Then Return "'%" & Replace(txt, "'", "''") & "%'"
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "C47")
        End Try
    End Function

    Public Function OpenDS(ByVal TextSql As String, ByVal TableName As String) As DataSet
        Try
            Dim ds As New DataSet
            cn.Open()
            Dim da As New SqlDataAdapter(TextSql, cn.SQlCon)
            da.Fill(ds) : cn.Close() : ds.Tables(0).Namespace = TableName
            Return ds
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "M183")
        End Try
    End Function

    Public Function GetTables(ByVal conn As OleDbConnection) As DataTable
        Try
            conn.Open()
            Dim schemaTable As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})
            conn.Close()
            Return schemaTable
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "C48")
        End Try
    End Function

    Private Sub PrintRows(ByVal myDataSet As DataSet)
        Try
            ' For each table in the DataSet, print the values of each row.
            Dim thisTable As DataTable
            For Each thisTable In myDataSet.Tables
                ' For each row, print the values of each column.
                Dim myRow As DataRow
                For Each myRow In thisTable.Rows
                    Dim myCol As DataColumn
                    For Each myCol In thisTable.Columns
                        Console.WriteLine(myRow(myCol))
                    Next myCol
                Next myRow
            Next thisTable
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "C49")
        End Try
    End Sub

    Public Function drTodt(ByVal dr As SqlDataReader) As DataTable
        Try
            If Not dr.HasRows Then Exit Function
            Dim i As Integer
            Dim ValeursLigne(dr.FieldCount - 1) As Object
            Dim dt As New DataTable
            dr.Read()
            For i = 0 To dr.FieldCount - 1
                dt.Columns.Add(dr.GetName(i), dr(i).GetType)
            Next i
            dt.BeginLoadData()
            Do While True
                dr.GetValues(ValeursLigne)
                dt.LoadDataRow(ValeursLigne, True)
                If Not dr.Read() Then Exit Do
            Loop
            dt.EndLoadData()
            dr.Close()
            Return dt
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "C50")
        End Try
    End Function

    Function GetTopDataViewRows(ByVal dv As DataView, ByVal Top As Integer) As DataView
        Try
            Dim TblClone As DataTable = dv.Table.Clone
            Dim i As Integer

            For i = 0 To Top - 1
                If i >= dv.Count Then Exit For
                TblClone.ImportRow(dv(i).Row)
            Next

            Return New DataView(TblClone, dv.RowFilter, dv.Sort, dv.RowStateFilter)
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "C51")
        End Try
    End Function

    Public Function MajDataBase(ByRef f As Form, ByRef ds As DataSet, ByVal sTableName As String, ByVal Titre As String, Optional ByVal Confirme As Boolean = True, Optional ByVal EndCurrent As Boolean = True, Optional ByVal daTable As SqlDataAdapter = Nothing) As Boolean
        Try
            ' Confirmation de la sauvegarde

            Dim row As DataRow
            Dim dtModif As New DataTable
            Dim dsModif As New DataSet '"""
            Dim da As SqlDataAdapter

            f.BindingContext(ds, sTableName).EndCurrentEdit()  ' Valider les modifications apporter sur la dataSet 
            dtModif = ds.Tables(sTableName).GetChanges()
            'dsModif = ds.GetChanges
            'dtModif = dsModif.Tables(sTableName)
            If dtModif Is Nothing Then ' s'il n'y a pas de changement on quitte ss rien faire
                Return True
                Exit Function
            End If

            ' maj de la table sTableName
            For Each row In dtModif.Rows
                If row.RowState <> DataRowState.Deleted And row.RowState <> DataRowState.Detached Then
                    'row("ut_id") = Wuser.UT_ID
                End If
                If row.RowState = DataRowState.Added Then
                    row("Created") = Now 'Format(Now.Date, "dd/MM/yyyy")
                End If
            Next
            ds.Merge(dtModif)
            If daTable Is Nothing Then
                'Cette déclaration sert pour définir les Commande {Delete, Update, Insert de l'adapatateur}
                da = New SqlDataAdapter(New SqlCommand("Select * from " & sTableName, Me.SQlCon))
                Dim custCB As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)
                da.DeleteCommand = custCB.GetDeleteCommand
                da.UpdateCommand = custCB.GetUpdateCommand

                da.Update(ds, sTableName)

            Else
                daTable.Update(ds, sTableName)
            End If

            'MessageStatut(NomDeTable(sTableName) & " :" & MSG_OKVALIDE)

            Return True

        Catch ex As Exception
            Process_Message(ex.Message, MsgBoxStyle.OkOnly, MsgBoxStyle.Critical, Titre, , , , , , ex.Message)
            Return False
        End Try
    End Function

    Public Sub Execute(ByVal sSQL As String)
        Try
            If Me.SQlCon.State = ConnectionState.Closed Then Me.Open()
            Dim cmd As New SqlCommand(sSQL, Me.SQlCon)
            cmd.ExecuteNonQuery()
            Me.Close()
        Catch ex As Exception
            'Throw
            If Not Me.SQlCon.State = ConnectionState.Closed Then Me.Close()
            Process_Message_Error(ex, "SQLcn", "M166", sSQL)
        End Try

    End Sub

    Public Sub ExecuteUCDCIP13(ByVal sSQL As String)
        Try
            If Me.SQlCon.State = ConnectionState.Closed Then Me.Open()
            Dim cmd As New SqlCommand(sSQL, Me.SQlCon)
            cmd.ExecuteNonQuery()
            Me.Close()
        Catch ex As Exception
            'Throw
            'TODO: A voir par la Suite
        End Try

    End Sub

    Public Function ExecuteIsValide(ByVal sSQL As String) As Boolean
        Try
            Me.Open()
            Dim cmd As New SqlCommand(sSQL, Me.SQlCon)
            cmd.ExecuteNonQuery()
            Me.Close()
            Return True
        Catch ex As Exception
            'Throw
            Return False
        End Try

    End Function

    Public Function MySelect(ByVal sSQL As String) As DataTable
        Try
            If SQlCon Is Nothing Then Exit Function
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(New SqlCommand(sSQL, Me.SQlCon))
            If dt Is Nothing Then Exit Function
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Process_Message_Error(ex, "SQLcn", "M167", sSQL)
        End Try
    End Function

    Public Function MySelectWithTimeOut(ByVal sSQL As String) As DataTable
        Try
            If SQlCon Is Nothing Then Exit Function
            Dim dt As New DataTable
            Dim MyCommand As SqlCommand = New SqlCommand(sSQL, Me.SQlCon)
            MyCommand.CommandTimeout = 60
            Dim da As New SqlDataAdapter(MyCommand)
            If dt Is Nothing Then Exit Function
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Process_Message_Error(ex, "SQLcn", "M167", sSQL)
        End Try
    End Function

    'Public Function GetLast(ByVal Table As String, Optional ByVal Where As String = "") As Integer
    '    Dim sSQL1 As String
    '    Try
    '        sSQL1 = "select max(" & Table & "_ID) from " & Table & " "
    '        If Where <> "" Then
    '            sSQL1 &= Where
    '            sSQL1 &= " and ut_id = " & Wuser.UT_ID
    '        Else
    '            sSQL1 &= " where ut_id = " & Wuser.UT_ID

    '        End If
    '        cn.Open()
    '        Dim cmd As New SqlCommand(sSQL1, cn.SQlCon)
    '        Dim ret As Integer
    '        ret = 0
    '        If Not cmd.ExecuteScalar Is DBNull.Value Then
    '            ret = cmd.ExecuteScalar
    '        End If
    '        cn.Close()
    '        If ret < 0 Then ret = 0
    '        Return ret
    '    Catch ex As Exception
    '        Process_Message_Error(ex, "THERIAQUE", "M186")
    '    End Try

    'End Function

    Public Function HasRow(ByVal TableName As String, Optional ByVal pSQL As String = "") As Object
        Dim sSQL1 As String
        Try
            sSQL1 = "select * from " & TableName & " where " & pSQL
            cn.Open()
            Dim cmd As New SqlCommand(sSQL1, cn.SQlCon)
            Dim ret As Integer
            ret = 0
            If Not cmd.ExecuteScalar Is DBNull.Value Then
                ret = cmd.ExecuteScalar
            End If
            cn.Close()
            If ret < 0 Then ret = 0
            If ret = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            If Not Me.SQlCon.State = ConnectionState.Closed Then Me.Close()
            Process_Message_Error(ex, "THERIAQUE", "M187")
            Return Nothing
        End Try
    End Function

    Public Function TableHasFK(ByVal TableName As String, ByVal Value As Integer, Optional ByVal MessageStr As String = "") As Boolean
        Try
            Dim cm As New SqlCommand("PS_THERIAQUE_GET_FK", cn.SQlCon)
            cm.CommandType = CommandType.StoredProcedure
            cm.Parameters.Add("@Param_TableName", TableName)
            cm.Parameters.Add("@Param_ID", Value)
            Dim da As New SqlDataAdapter(cm)
            Dim TempDt As New DataTable
            da.Fill(TempDt)
            If TempDt.Rows.Count > 0 Then
                If MessageStr = "" Then
                    Process_Message(TableName & ": " & "Impossible de supprimer cette ligne car elle est utilisée dans d'autre(s) module(s).", MsgBoxStyle.OkOnly, MsgBoxStyle.Exclamation, TableName)
                Else
                    Process_Message(MessageStr, MsgBoxStyle.OkOnly, MsgBoxStyle.Exclamation, TableName)
                End If
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "C54")
        End Try
    End Function

    Public Function ExecuteScalar(ByVal ssql As String) As Object
        Try
            If Me.SQlCon.State = ConnectionState.Closed Then Me.Open()
            Dim cmd As New SqlCommand(ssql, Me.SQlCon)
            Return cmd.ExecuteScalar()
            Me.Close()
        Catch ex As Exception
            If Not Me.SQlCon.State = ConnectionState.Closed Then Me.Close()
            Process_Message_Error(ex, "THERIAQUE", "C55")
            Return Nothing
        End Try
    End Function

    Public Function Exclusive(ByVal Name As String)
        Try
            Dim sSql As String = "ALTER DATABASE " & Name & " SET SINGLE_USER "
            Execute(sSql)
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "C56")
        End Try
    End Function

    Public Function Gain_Exclusive(ByVal Name As String)
        Try
            Dim sSql As String = "ALTER DATABASE " & Name & " SET MULTI_USER "
            Execute(sSql)
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "C57")
        End Try
    End Function

    Public Function RenameDB(ByVal OldName As String, ByVal NewName As String)
        Try
            Dim sSql = "ALTER DATABASE " & OldName & " MODIFY NAME = " & NewName
            Execute(sSql)
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "C58")
        End Try
    End Function

    Public Function Duplicate(ByVal name As String)
        Try
            Dim sSql As String
            sSql = " BACKUP DATABASE " & name & " TO DISK = '" & getDataPath(name) & name & ".bak'"

            sSql &= " RESTORE FILELISTONLY"
            sSql &= " FROM DISK = '" & getDataPath(name) & name & ".bak'"

            sSql &= " RESTORE DATABASE " & name & "Copie"
            sSql &= " FROM DISK = '" & getDataPath(name) & name & ".bak'"
            sSql &= " With MOVE '" & getDatafile(name) & "' TO  'c:\temp\" & name & ".mdf',"
            sSql &= " MOVE '" & getLogfile(name) & "' TO 'c:\temp\" & name & ".ldf'"

            Execute(sSql)
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "C59")
        End Try
    End Function

    Public Function getLogfile(ByVal name As String) As String
        Try
            Dim sSql As String = "select s.name from master..sysaltfiles s, master..sysdatabases d  where s.dbid = d.dbid and s.fileid = 2 and d.name = " & Me.SQLText(name)
            Return Me.ExecuteScalar(sSql).trim
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "C60")
        End Try
    End Function

    Public Function getDatafile(ByVal name As String) As String
        Try
            Dim sSql As String = "select s.name from master..sysaltfiles s, master..sysdatabases d  where s.dbid = d.dbid and s.fileid = 1 and d.name = " & Me.SQLText(name)
            Return Me.ExecuteScalar(sSql).trim
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "C61")
        End Try
    End Function

    Public Function getLogPath(ByVal name As String) As String
        Try
            Dim sSql As String = "select s.filename from master..sysaltfiles s, master..sysdatabases d  where s.dbid = d.dbid and s.fileid = 2 and d.name = " & Me.SQLText(name)
            Return Path.GetDirectoryName(Me.ExecuteScalar(sSql).trim) & "\"
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "C62")
        End Try
    End Function

    Public Function getDataPath(ByVal name As String) As String
        Try
            Dim sSql As String = "select s.filename from master..sysaltfiles s, master..sysdatabases d  where s.dbid = d.dbid and s.fileid = 1 and d.name = " & Me.SQLText(name)
            Return Path.GetDirectoryName(Me.ExecuteScalar(sSql).trim) & "\"
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "C63")
        End Try
    End Function

    Public Function getLogFileName(ByVal name As String) As String
        Try
            Dim sSql As String = "select s.filename from master..sysaltfiles s, master..sysdatabases d  where s.dbid = d.dbid and s.fileid = 2 and d.name = " & Me.SQLText(name)
            Return Me.ExecuteScalar(sSql).trim
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "C64")
        End Try
    End Function

    Public Function getDataFileName(ByVal name As String) As String
        Try
            Dim sSql As String = "select s.filename from master..sysaltfiles s, master..sysdatabases d  where s.dbid = d.dbid and s.fileid = 1 and d.name = " & Me.SQLText(name)
            Return Me.ExecuteScalar(sSql).trim
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "C65")
        End Try
    End Function

    Public Function Backup(ByVal Name As String)
        Try
            If File.Exists(Me.getDataPath(Name) & Name & Now.Date.ToString("yyMMdd") & ".BAK") Then File.Delete(Me.getDataPath(Name) & Name & Now.Date.ToString("yyMMdd") & ".BAK")
            Dim sSql As String = "BACKUP DATABASE " & Name & " TO DISK = '" & Me.getDataPath(Name) & Name & Now.Date.ToString("yyMMdd") & ".BAK'"
            Me.Execute(sSql)
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "C66")
        End Try
    End Function

    Public Function Delete(ByVal name As String)
        Try
            Me.Execute("DROP DATABASE " & name)
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "C67")
        End Try
    End Function

    Public Function Detach(ByVal name As String)
        Try
            Dim sSql As String
            sSql = "use master "
            sSql &= " exec sp_detach_db '" & name & "'"

            Me.Execute(sSql)
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "C68")
        End Try
    End Function

    Public Function Attach(ByVal name As String, ByVal DataFile As String, ByVal LogFile As String)
        Try
            Dim sSql As String
            sSql = "use master"
            sSql &= " exec sp_attach_db '" & name & "','" & DataFile & "','" & LogFile & "'"
            Me.Execute(sSql)
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "C69")
        End Try
    End Function

    'Public Function CopierGVToDataTable(ByVal GV As DevExpress.XtraGrid.Views.Grid.GridView) As DataTable
    '    Dim dt As New DataTable
    '    Dim dc As DataColumn
    '    Dim dv As DataView = GV.DataSource

    '    For Each dc In dv.Table.Columns
    '        Dim dcTemp As DataColumn
    '        dcTemp = New DataColumn(dc.ColumnName, dc.DataType)
    '        dt.Columns.Add(dcTemp)
    '    Next

    '    For iCount As Integer = 0 To GV.RowCount - 1
    '        Dim drTemp As DataRow
    '        drTemp = dt.NewRow
    '        If GV.GetDataRow(iCount) IsNot Nothing Then
    '            drTemp.ItemArray = GV.GetDataRow(iCount).ItemArray
    '            dt.Rows.Add(drTemp)
    '        End If
    '    Next
    '    Return dt
    'End Function
    'Public Sub CopierDataTableToGV(ByVal dt As DataTable, ByVal GV As DevExpress.XtraGrid.Views.Grid.GridView)
    '    For iCountRows As Integer = 0 To dt.Rows.Count - 1
    '        For iCountColumn As Integer = 0 To dt.Columns.Count - 1
    '            GV.AddNewRow()
    '            GV.SetFocusedRowCellValue(GV.Columns(iCountColumn), dt.Rows(iCountRows)(iCountColumn))
    '        Next
    '    Next
    'End Sub
    Public Sub SaveConnectionSetting()

        Dim config As Configuration
        Dim setting As ConnectionStringSettings

        Try
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

            ConInfo = cn.CnInfo
            strConnexion = ""
            strConnexion &= "Data Source= "
            strConnexion &= ConInfo.Server & " ; "
            strConnexion &= "Initial Catalog= "
            strConnexion &= ConInfo.DateBase & " ; "
            strConnexion &= "Persist Security Info=true;User ID= "
            strConnexion &= ConInfo.User & " ; "
            strConnexion &= "Password="
            strConnexion &= ConInfo.Password & " ; "

            setting = ConfigurationManager.ConnectionStrings("Theriaque.MySettings.ConnectionString")
            If Not setting Is Nothing Then

                config.ConnectionStrings.ConnectionStrings.Remove("Theriaque.MySettings.ConnectionString")

                config.Save(System.Configuration.ConfigurationSaveMode.Modified)
                ConfigurationManager.RefreshSection("connectionStrings")

            End If

            setting = New ConnectionStringSettings()
            setting.Name = "Theriaque.MySettings.ConnectionString"
            setting.ConnectionString = strConnexion

            config.ConnectionStrings.ConnectionStrings.Add(setting)
            config.Save(System.Configuration.ConfigurationSaveMode.Modified)
            ConfigurationManager.RefreshSection("connectionStrings")
            Theriaque.My.Settings.Item("ConnectionString") = strConnexion
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub InitCnInfo()
        Dim ind, ind1 As Integer
        Dim sc As New SqlClient.SqlConnection(Me.sConnexion)
        Dim CInfo As ConnexionInfo
        CInfo = New ConnexionInfo()
        CInfo.DateBase = sc.Database
        CInfo.Server = sc.DataSource

        ';User ID=sa;Password=bilogsa"
        Dim sUserId As String = "User ID="
        Dim sPassword As String = "Password="

        ind = Me.sConnexion.IndexOf(sUserId)
        If ind > 0 Then
            ind1 = Me.sConnexion.IndexOf(";", ind)
            If ind1 > 0 Then
                CInfo.User = Me.sConnexion.Substring(ind + sUserId.Length, ind1 - ind - sUserId.Length).Trim
            End If
        End If

        ind = Me.sConnexion.IndexOf(sPassword)
        If ind > 0 Then
            ind1 = Me.sConnexion.Length
            If ind1 > 0 Then
                CInfo.Password = Me.sConnexion.Substring(ind + sPassword.Length, ind1 - ind - sPassword.Length).Trim
            End If
        End If
        Me.CnInfo = CInfo

    End Sub

End Class