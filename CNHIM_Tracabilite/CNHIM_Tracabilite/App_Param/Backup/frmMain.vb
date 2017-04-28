Imports System.Data.Sqlclient
Imports System.Data.OleDb
Imports System.IO
Imports ADOX

Public Class frmMain
    Inherits System.Windows.Forms.Form
    Private cnAPP As OleDbConnection
    Private cnAPPServer As OleDbConnection
    Private rsTable As DataSet
    Private sServer As String
    Private sDataBase As String
    Private sUser As String
    Private sPassword As String
    Private CN_APPTable As OleDbConnection
    Enum enumActionType
        cstActionType_INITPARAMDATA = 0
        cstActionType_HISTORIQUE = 1
        cstActionType_TRGHISTORIQUE = 2
    End Enum

#Region " Code généré par le Concepteur Windows Form "

    Public Sub New()
        MyBase.New()

        'Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()

        'Ajoutez une initialisation quelconque après l'appel InitializeComponent()

    End Sub

    'La méthode substituée Dispose du formulaire pour nettoyer la liste des composants.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requis par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée en utilisant le Concepteur Windows Form.  
    'Ne la modifiez pas en utilisant l'éditeur de code.
    Friend WithEvents cmdInitParamData As System.Windows.Forms.Button
    Friend WithEvents cmdhisTable As System.Windows.Forms.Button
    Friend WithEvents cmdtrghistorique As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtServeur As System.Windows.Forms.TextBox
    Friend WithEvents cmbBDD As System.Windows.Forms.ComboBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPassWord As System.Windows.Forms.TextBox
    Friend WithEvents lvwTable As System.Windows.Forms.CheckedListBox
    Friend WithEvents lvwColonne As System.Windows.Forms.CheckedListBox
    Friend WithEvents cmdQuitter As System.Windows.Forms.Button
    Friend WithEvents cmdConnect As System.Windows.Forms.Button
    Friend WithEvents EventLogger As System.Diagnostics.EventLog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdInitParamData = New System.Windows.Forms.Button
        Me.cmdhisTable = New System.Windows.Forms.Button
        Me.cmdtrghistorique = New System.Windows.Forms.Button
        Me.txtServeur = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbBDD = New System.Windows.Forms.ComboBox
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.txtPassWord = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lvwTable = New System.Windows.Forms.CheckedListBox
        Me.lvwColonne = New System.Windows.Forms.CheckedListBox
        Me.cmdQuitter = New System.Windows.Forms.Button
        Me.cmdConnect = New System.Windows.Forms.Button
        Me.EventLogger = New System.Diagnostics.EventLog
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.EventLogger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdInitParamData
        '
        Me.cmdInitParamData.Location = New System.Drawing.Point(456, 112)
        Me.cmdInitParamData.Name = "cmdInitParamData"
        Me.cmdInitParamData.Size = New System.Drawing.Size(104, 24)
        Me.cmdInitParamData.TabIndex = 7
        Me.cmdInitParamData.Text = "Param Data"
        '
        'cmdhisTable
        '
        Me.cmdhisTable.Location = New System.Drawing.Point(456, 144)
        Me.cmdhisTable.Name = "cmdhisTable"
        Me.cmdhisTable.Size = New System.Drawing.Size(104, 24)
        Me.cmdhisTable.TabIndex = 8
        Me.cmdhisTable.Text = "Table Historique"
        '
        'cmdtrghistorique
        '
        Me.cmdtrghistorique.Location = New System.Drawing.Point(456, 176)
        Me.cmdtrghistorique.Name = "cmdtrghistorique"
        Me.cmdtrghistorique.Size = New System.Drawing.Size(104, 24)
        Me.cmdtrghistorique.TabIndex = 9
        Me.cmdtrghistorique.Text = "Trigger Historique"
        '
        'txtServeur
        '
        Me.txtServeur.Location = New System.Drawing.Point(56, 8)
        Me.txtServeur.Name = "txtServeur"
        Me.txtServeur.Size = New System.Drawing.Size(128, 21)
        Me.txtServeur.TabIndex = 1
        Me.txtServeur.Text = "(local)"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Serveur"
        '
        'cmbBDD
        '
        Me.cmbBDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBDD.Location = New System.Drawing.Point(96, 35)
        Me.cmbBDD.Name = "cmbBDD"
        Me.cmbBDD.Size = New System.Drawing.Size(136, 21)
        Me.cmbBDD.TabIndex = 4
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(224, 8)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(128, 21)
        Me.txtUser.TabIndex = 2
        Me.txtUser.Text = "sa"
        '
        'txtPassWord
        '
        Me.txtPassWord.Location = New System.Drawing.Point(416, 8)
        Me.txtPassWord.Name = "txtPassWord"
        Me.txtPassWord.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassWord.Size = New System.Drawing.Size(128, 21)
        Me.txtPassWord.TabIndex = 3
        Me.txtPassWord.Text = "bilogsa"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(192, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 21)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "User"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(360, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 21)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Base de donnée"
        '
        'lvwTable
        '
        Me.lvwTable.Location = New System.Drawing.Point(8, 64)
        Me.lvwTable.Name = "lvwTable"
        Me.lvwTable.Size = New System.Drawing.Size(208, 276)
        Me.lvwTable.TabIndex = 5
        '
        'lvwColonne
        '
        Me.lvwColonne.Location = New System.Drawing.Point(221, 64)
        Me.lvwColonne.Name = "lvwColonne"
        Me.lvwColonne.Size = New System.Drawing.Size(208, 276)
        Me.lvwColonne.TabIndex = 6
        '
        'cmdQuitter
        '
        Me.cmdQuitter.Location = New System.Drawing.Point(456, 208)
        Me.cmdQuitter.Name = "cmdQuitter"
        Me.cmdQuitter.Size = New System.Drawing.Size(104, 24)
        Me.cmdQuitter.TabIndex = 16
        Me.cmdQuitter.Text = "Quitter"
        '
        'cmdConnect
        '
        Me.cmdConnect.Location = New System.Drawing.Point(456, 40)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(104, 24)
        Me.cmdConnect.TabIndex = 17
        Me.cmdConnect.Text = "Connexion"
        '
        'EventLogger
        '
        Me.EventLogger.SynchronizingObject = Me
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(456, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 24)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Correct"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(568, 398)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdConnect)
        Me.Controls.Add(Me.cmdQuitter)
        Me.Controls.Add(Me.lvwColonne)
        Me.Controls.Add(Me.lvwTable)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPassWord)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtServeur)
        Me.Controls.Add(Me.cmbBDD)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdtrghistorique)
        Me.Controls.Add(Me.cmdhisTable)
        Me.Controls.Add(Me.cmdInitParamData)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "App_Param"
        CType(Me.EventLogger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call InitForm()
    End Sub

    Private Sub cmdInitParamData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInitParamData.Click
        Call InitParamData(enumActionType.cstActionType_INITPARAMDATA)
    End Sub

    Private Sub cmdhisTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdhisTable.Click
        Call InitParamData(enumActionType.cstActionType_HISTORIQUE)
    End Sub

    Private Sub cmdtrghistorique_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtrghistorique.Click
        Call InitParamData(enumActionType.cstActionType_TRGHISTORIQUE)
    End Sub

    '---------------------------
    Private Function ConnectDataBase() As SqlConnection

        Dim sCN_APP As New String("Provider=SQLOLEDB;Data Source=%1;Initial Catalog=%2;UID=%3;PASSWORD=%4")
        Try
            sCN_APP = Replace(sCN_APP, "%1", txtServeur.Text)
            sCN_APP = Replace(sCN_APP, "%2", IIf(cmbBDD.Text = "", "master", cmbBDD.Text))
            sCN_APP = Replace(sCN_APP, "%3", txtUser.Text)
            sCN_APP = Replace(sCN_APP, "%4", txtPassWord.Text)
            sCN_APP = "Persist Security Info=False;database=xmedversion6;server=bilog-prt-002\XMEd;user id = sa; password = bilogsa"

            ConnectDataBase = New SqlClient.SqlConnection(sCN_APP)
            ConnectDataBase.Open()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub InitForm()

        txtPassWord.Text = "bilogsa"
        txtUser.Text = "sa  "
        txtServeur.Text = "bilog-prt-002"
        cmbBDD.Items.Clear()
    End Sub

    Private Sub FillLvwListeTable()

        Dim sSql As String
        Dim ta As DataTable
        Dim rLigne As DataRow


        sSql = New String("SELECT sysobjects.* FROM sysobjects WHERE sysobjects.xtype = 'U' ORDER BY name")

        Try
            rsTable = OpenDS(sSql, ConnectDataBase())
            lvwTable.Items.Clear()
            For Each ta In rsTable.Tables
                For Each rLigne In ta.Rows
                    lvwTable.Items.Add(rLigne("name"))
                Next
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Function OpenDS(ByVal sSql As String, ByVal cn As SqlConnection) As DataSet
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(sSql, cn)

            da.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Sub InitParamData(ByVal iActionType As enumActionType)

        Dim iCpt As Integer
        Select Case iActionType
            Case enumActionType.cstActionType_INITPARAMDATA
                Call WriteParamData()
                Call WriteParamStructure()
            Case enumActionType.cstActionType_HISTORIQUE
            Case enumActionType.cstActionType_TRGHISTORIQUE
        End Select

        For iCpt = 0 To lvwTable.Items.Count - 1
            If lvwTable.GetItemCheckState(iCpt) = CheckState.Checked Then
                Select Case iActionType
                    Case enumActionType.cstActionType_INITPARAMDATA
                    Case enumActionType.cstActionType_HISTORIQUE
                        InitHisTable_Process(lvwTable.Items(iCpt))
                    Case enumActionType.cstActionType_TRGHISTORIQUE
                        InitTriggerHisTable_Process(lvwTable.Items(iCpt))
                End Select
            End If
        Next iCpt
    End Sub

    Public Sub WriteParamData()

        Dim ds As DataSet
        Dim dt As DataTable
        Dim iCpt As Integer

        ds = New DataSet
        ds.DataSetName = "ParamData"
        Call CreateSqlConnection(cmbBDD.Text, txtServeur.Text)
        Cursor = Cursors.WaitCursor
        For iCpt = 0 To lvwTable.Items.Count - 1
            If lvwTable.GetItemCheckState(iCpt) = CheckState.Checked Then
                dt = OpenTable("SELECT * FROM [" + lvwTable.Items(iCpt) + "]", cnSql)
                dt.TableName = lvwTable.Items(iCpt)
                ds.Tables.Add(dt)
            End If
        Next
        Call File.Delete("C:\ParamData.xml")
        Call ds.WriteXml("C:\ParamData.xml", XmlWriteMode.WriteSchema)
        Cursor = Cursors.Default
    End Sub

    Public Sub WriteParamStructure()

    End Sub

    Public Sub ReadParamData()

        Dim sSQLInsert As String
        Dim sSQLData As String
        Dim sSQL As String
        Dim sTextData As String
        Dim rRows As DataRow
        Dim Col As DataColumn
        Dim objFile As StreamWriter
        Dim rsRecordSet As DataTable
        Dim ds As DataSet
        Dim ds1 As DataSet
        Dim dt As DataTable
        Dim objXml As New Xml.XmlDocument
        Dim objXmlReader As Xml.XmlReader
        Dim iCpt As Integer
        Dim sTable As String


        '---- Lecture du DataSet
        ds1 = New DataSet
        ds1.ReadXmlSchema("C:\ParamData.xml")
        ds1.ReadXml("C:\ParamData.xml")

        ds1.Tables(1).Copy()
        For Each dt In ds1.Tables
        Next

        Call cnSql.Close()

    End Sub

    Private Sub InitHisTable_Process(ByVal sTable As String)

        Dim sSQL As String
        Dim rsTable As DataSet
        Dim rRows As DataRow
        Dim ta As DataTable

        sSQL = "SELECT DISTINCT syscolumns.name colname, systypes.name typename, syscolumns.colorder FROM syscolumns, systypes, sysobjects "
        sSQL += "WHERE syscolumns.xusertype = systypes.xusertype AND sysobjects.id = syscolumns.id AND sysobjects.name = " & SqlFormat(sTable) & " "
        sSQL += "AND sysobjects.name NOT IN (SELECT DISTINCT sysobjects.name  FROM syscolumns, systypes, sysobjects WHERE syscolumns.xusertype = systypes.xusertype AND sysobjects.id = syscolumns.id AND systypes.name IN( 'image', 'ntext', 'text')) "
        sSQL += "ORDER BY syscolumns.colorder"

        rsTable = OpenDS(sSQL, ConnectDataBase())

        If rsTable.Tables("Table").Rows.Count <> 0 Then
            sSQL = " IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE NAME = 'HIS_" + sTable.ToUpper + "' AND TYPE = 'U')" + vbCr
            sSQL += " DROP TABLE [HIS_" + sTable + "]" + vbCr
            sSQL += " GO " + vbCr
            sSQL += " CREATE TABLE [HIS_" + sTable.ToUpper + "] ( IDHIS_" + sTable.ToUpper + " INT IDENTITY (1, 1) NOT NULL, " + vbCr
            sSQL += " HISACTION varchar(4), " + vbCr
            sSQL += " DTHIS datetime, " + vbCr

            For Each rRows In rsTable.Tables("Table").Rows
                sSQL += " " + rRows("colname") + "  " + rRows("typename") + ", " + vbCr
            Next

            sSQL += " CONSTRAINT PK_HIS" + sTable.ToUpper + " PRIMARY KEY(IDHIS_" + sTable.ToUpper + ") )" + vbCr + "GO " + vbCr

            Call EcrireFichier("C:\init_Histable.sql", sSQL)

        End If
    End Sub

    Private Sub InitTriggerHisTable_Process(ByVal sTable As String)

        Dim sSQL As String
        Dim sCol As String
        Dim rsTable As DataSet
        Dim rRows As DataRow
        Dim ta As DataTable

        sSQL = "SELECT DISTINCT syscolumns.name colname, systypes.name typename, syscolumns.colorder FROM syscolumns, systypes, sysobjects "
        sSQL += "WHERE syscolumns.xusertype = systypes.xusertype AND sysobjects.id = syscolumns.id AND sysobjects.name = " & SqlFormat(sTable) & " "
        sSQL += "AND sysobjects.name NOT IN (SELECT DISTINCT sysobjects.name  FROM syscolumns, systypes, sysobjects WHERE syscolumns.xusertype = systypes.xusertype AND sysobjects.id = syscolumns.id AND systypes.name IN( 'image', 'ntext', 'text')) "
        sSQL += "ORDER BY syscolumns.colorder"

        rsTable = OpenDS(sSQL, ConnectDataBase())
        sCol = ""

        If rsTable.Tables("Table").Rows.Count <> 0 Then
            For Each rRows In rsTable.Tables("Table").Rows
                sCol = sCol + rRows("colname") + ", "
            Next

            sCol = Mid(sCol, 1, Len(sCol) - 2)

            sSQL = vbCrLf
            sSQL += "IF EXISTS (SELECT * FROM SYSOBJECTS WHERE ID = OBJECT_ID (N'HIS_I_" + sTable.ToUpper + "') AND OBJECTPROPERTY(ID, N'IsTrigger') = 1)" + vbCr
            sSQL += "DROP TRIGGER HIS_I_" + sTable.ToUpper + vbCr
            sSQL += "GO " + vbCr
            sSQL += "IF EXISTS (SELECT * FROM SYSOBJECTS WHERE ID = OBJECT_ID (N'HIS_U_" + sTable.ToUpper + "') AND OBJECTPROPERTY(ID, N'IsTrigger') = 1)" + vbCr
            sSQL += "DROP TRIGGER HIS_U_" + sTable.ToUpper + vbCr
            sSQL += "GO " + vbCr
            sSQL += "IF EXISTS (SELECT * FROM SYSOBJECTS WHERE ID = OBJECT_ID (N'HIS_D_" + sTable.ToUpper + "') AND OBJECTPROPERTY(ID, N'IsTrigger') = 1)" + vbCr
            sSQL += "DROP TRIGGER HIS_D_" + sTable.ToUpper + vbCr
            sSQL += "GO " + vbCr

            '------- Trigger pour la suppression
            sSQL += "CREATE TRIGGER HIS_D_" + sTable.ToUpper + " ON " + sTable.ToUpper + vbCr
            sSQL += "FOR DELETE AS" + vbCr
            sSQL += "BEGIN " + vbCr
            sSQL += "    INSERT INTO XMEDHISTO..HIS_" + sTable.ToUpper + " (DTHIS, HISACTION, " + sCol.ToUpper + ") " + vbCr
            sSQL += "    SELECT GETDATE(), 'SUP', " + sCol.ToUpper + " FROM DELETED " + vbCr
            sSQL += "END " + vbCr
            sSQL += "GO " + vbCr
            '------- Trigger pour l'ajout
            sSQL += "CREATE TRIGGER HIS_I_" + sTable.ToUpper + " ON " + sTable.ToUpper + vbCr
            sSQL += "FOR INSERT AS " + vbCr
            sSQL += "BEGIN " + vbCr
            sSQL += "    INSERT INTO XMEDHISTO..HIS_" + sTable.ToUpper + " (DTHIS, HISACTION, " + sCol.ToUpper + ") " + vbCr
            sSQL += "    SELECT GETDATE(), 'INS', " + sCol.ToUpper + " FROM INSERTED " + vbCr
            sSQL += "END " + vbCr
            sSQL += "GO " + vbCr
            '------- Trigger pour de mise à jour
            sSQL += "CREATE TRIGGER HIS_U_" + sTable.ToUpper + " ON " + sTable.ToUpper + vbCr
            sSQL += "FOR UPDATE AS " + vbCr
            sSQL += "BEGIN " + vbCr
            sSQL += "    INSERT INTO XMEDHISTO..HIS_" + sTable.ToUpper + " (DTHIS, HISACTION, " + sCol.ToUpper + ") " + vbCr
            sSQL += "    SELECT GETDATE(), 'UPD1', " + sCol.ToUpper + " FROM DELETED " + vbCr
            sSQL += "    INSERT INTO HIS_" + sTable.ToUpper + " (DTHIS, HISACTION, " + sCol.ToUpper + ") " + vbCr
            sSQL += "    SELECT GETDATE(), 'UPD2', " + sCol.ToUpper + " FROM INSERTED " + vbCr
            sSQL += "END " + vbCr
            sSQL += "GO " + vbCr

            EcrireFichier("C:\init_trgHistable.sql", sSQL)

        End If

    End Sub

    Public Function NZ(ByVal Champs As Object, ByVal ValDefaut As Object)

        NZ = IIf(IsDBNull(Champs), ValDefaut, Champs)
    End Function

    Public Function SqlFormat(ByVal Champs As Object) As String

        Try
            Select Case True
                Case IsDBNull(Champs)
                    SqlFormat = "NULL"
                Case IsDate(Champs)
                    SqlFormat = "'" + FormatDateTime(Champs, DateFormat.ShortDate) + "'"
                Case IsNumeric(Champs)
                    SqlFormat = Replace(CStr(Champs), ",", ".")
                Case TypeOf Champs Is Boolean
                    SqlFormat = IIf(Champs, "True", "False")
                Case TypeOf Champs Is String
                    SqlFormat = Replace(Champs, vbTab, " ")
                    SqlFormat = Replace(Trim(CStr(SqlFormat)), "'", "''")
                    SqlFormat = Replace(SqlFormat, vbCr, " ")
                    SqlFormat = "'" & SqlFormat & "'"
                Case Else
            End Select

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Sql2Rtf()

    End Function
    Public Sub EcrireFichier(ByVal CheminFichier As String, ByVal Contenu As String)
        Dim Fich As StreamWriter
        Try
            Fich = New StreamWriter(CheminFichier, True)
            Fich.Write(Contenu)
            Fich.Close()
        Catch ex As Exception
            MsgBox(ex.Message & " : " & CheminFichier)
            If Not Fich Is Nothing Then Fich.Close()
        End Try
    End Sub

    Public Sub FillCmbBDD()

        Dim sSQL As String
        Dim rsDs As DataSet
        Dim rRows As DataRow
        Dim ta As DataTable

        Try
            If txtUser.Text <> "" And txtServeur.Text <> "" And txtPassWord.Text <> "" Then
                sSQL = "SELECT sys.databases.name FROM sys.databases"
                rsDs = New DataSet
                rsDs = OpenDS(sSQL, ConnectDataBase())

                cmbBDD.Items.Clear()
                For Each ta In rsDs.Tables
                    For Each rRows In ta.Rows
                        cmbBDD.Items.Add(rRows("name"))
                    Next
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Application.ProductName)
        End Try

    End Sub

    Private Sub FillLvwColonne()

        Dim sSql As String
        Dim ta As DataTable
        Dim rLigne As DataRow

        sSql = " SELECT syscolumns.id, syscolumns.name, syscolumns.colorder"
        sSql = sSql & " FROM syscolumns, sysobjects "
        sSql = sSql & " WHERE syscolumns.id = sysobjects.id AND sysobjects.xtype = 'U'"
        sSql = sSql & IIf(lvwTable.SelectedItem <> "", " AND sysobjects.name = '" & lvwTable.SelectedItem & "'", "")
        sSql = sSql & " ORDER BY syscolumns.id, syscolumns.colorder"


        Try
            rsTable = OpenDS(sSql, ConnectDataBase())
            lvwColonne.Items.Clear()
            For Each ta In rsTable.Tables
                For Each rLigne In ta.Rows
                    lvwColonne.Items.Add(rLigne("name"))
                Next
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmbBDD_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBDD.SelectedValueChanged
        Call FillLvwListeTable()
    End Sub

    Private Sub lvwTable_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwTable.SelectedValueChanged
        Call FillLvwColonne()
    End Sub

    Public Function DeleteFile(ByVal sPath As String) As Boolean
        Dim fFileInfo As FileInfo

        fFileInfo = New FileInfo(sPath)
        DeleteFile = True
        If fFileInfo.Exists Then
            Try
                fFileInfo.Delete()
            Catch ex As Exception
                DeleteFile = False
                MsgBox(ex.Message, MsgBoxStyle.Critical, Application.ProductName)
            End Try
        End If
        Return DeleteFile
    End Function

    Private Sub cmdQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuitter.Click
        End
    End Sub

    Private Sub cmdConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConnect.Click

        Call FillCmbBDD()
    End Sub

    Private Sub cmdEventLogger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim Log As New EventLog
        'Dim logger As log4net.LogManager

        Log.WriteEntry("AdminServer", "un exemple de admin server ", EventLogEntryType.Information)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Call Hed2Rtf("C:\Hed")
        'Call CorrectDataFile_("PRDT.sql", "c:\")
        'Call RunScriptFile("C:\Travail\AdminServer\AdminServer\Script\000_XMED_Structure.sql")

        'Call PrepareOptionsFile("Bechir", "BEN LTAIEF")
        Call MsgBox(FormatParam("C:\Travail\XFiles Setup\Output"), MsgBoxStyle.Information, Application.ProductName)
    End Sub

    Public Function FormatParam(ByVal sPath As String) As String

        Return """" & sPath & """"
    End Function

    'Public Function Hed2Rtf(ByVal sPath As String) As Boolean
    '    Try
    '        Dim objPathinfo As New System.IO.DirectoryInfo(sPath)
    '        Dim objFileInfo As System.IO.FileInfo
    '        Dim frmPrg As New frmProgressBar
    '        Dim iNbreFichier As Integer

    '        Dim objHighEdit As HighEdit.HighEdit

    '        'Initialisation des 
    '        frmPrg.Text = "Transformation des fichiers HED to RTF..."
    '        Call frmPrg.Show()
    '        Call frmPrg.InitForm(frmProgressBar.ActionType.FirstPrg)

    '        'Transformation des fichiers HED en RTF
    '        'iNbreFichier = objPathinfo.GetFiles("*.hed").GetLength(0) + 1
    '        'For Each objFileInfo In objPathinfo.GetFiles("*.hed")

    '        '    Call frmPrg.ChangePrgStat(frmProgressBar.ActionType.FirstPrg, "[" & frmPrg.prgFirst.Value.ToString & "/" & iNbreFichier.ToString & "] - " & objFileInfo.Name, iNbreFichier, frmPrg.prgFirst.Value + 1)
    '        '    Call Application.DoEvents()
    '        '    If frmPrg.IsStoped Then Exit For

    '        '    objHighEdit = New HighEdit.HighEdit
    '        '    Call objHighEdit.LoadHedDocument(objFileInfo.FullName)
    '        '    Call objHighEdit.SaveDocumentInRtf(Replace(objFileInfo.FullName, ".hed", ".rtf"))

    '        '    Call DeleteFile(objFileInfo.FullName)
    '        '    If frmPrg.prgFirst.Value Mod 1000 = 0 Then System.Threading.Thread.Sleep(3000)
    '        'Next

    '        iNbreFichier = objPathinfo.GetFiles("*.hed").GetLength(0) + 1
    '        While True
    '            If objPathinfo.GetFiles("*.hed").GetLength(0) = 0 Then Exit While
    '            objFileInfo = objPathinfo.GetFiles("*.hed").GetValue(0)
    '            Call frmPrg.ChangePrgStat(frmProgressBar.ActionType.FirstPrg, "[" & frmPrg.prgFirst.Value.ToString & "/" & iNbreFichier.ToString & "] - " & objFileInfo.Name, iNbreFichier, frmPrg.prgFirst.Value + 1)
    '            Call Application.DoEvents()
    '            If frmPrg.IsStoped Then Exit While

    '            objHighEdit = New HighEdit.HighEdit
    '            Call objHighEdit.LoadHedDocument(objFileInfo.FullName)
    '            Call objHighEdit.SaveDocumentInRtf(Replace(objFileInfo.FullName, ".hed", ".rtf"))

    '            Call DeleteFile(objFileInfo.FullName)
    '            If frmPrg.prgFirst.Value Mod 1000 = 0 Then System.Threading.Thread.Sleep(3000)

    '        End While
    '        'Post traitement
    '        Call frmPrg.Close()

    '    Catch ex As Exception
    '        Call MsgBox(ex.Message)
    '    End Try
    'End Function

    Public Function RunScriptFile(ByVal sScriptFile As String) As Boolean

        Dim objScript As StreamReader
        Dim sCommand As String()
        Dim iCpt As Integer

        Try
            RunScriptFile = False
            If File.Exists(sScriptFile) Then
                objScript = New StreamReader(sScriptFile)
                sCommand = Split(objScript.ReadToEnd, ";")

                For iCpt = sCommand.GetLowerBound(0) To sCommand.GetUpperBound(0)
                    MsgBox(sCommand.GetValue(iCpt))
                Next
            End If
        Catch ex As Exception
            Call MsgBox(ex.Message, MsgBoxStyle.Critical, Application.ProductName)
        End Try
    End Function

    Public Function PrepareOptionsFile(ByVal sNom As String, ByVal sPrenom As String) As Boolean

        Dim objCn As New OleDb.OleDbConnection
        Dim objCommand As OleDb.OleDbCommand

        Try

            PrepareOptionsFile = False
            If Not File.Exists(Application.StartupPath & "\options.dbf") Then Exit Function
            If Application.StartupPath & "\options.dbf" <> Application.StartupPath & "\options.dbf" Then Call File.Copy(Application.StartupPath & "\options.dbf", Application.StartupPath & "\options.dbf")

            'Mise à jour des valeur Nom et Prenom dans le fichier options.dbf
            objCn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & ";Extended Properties=dBASE IV"
            Call objCn.Open()

            objCommand = New OleDb.OleDbCommand("DELETE FROM OPTIONS.DBF", objCn)
            Call objCommand.ExecuteNonQuery()

            objCommand = New OleDb.OleDbCommand("INSERT INTO OPTIONS.DBF (NOM, PRENOM) VALUES (@Nom, @Prenom)", objCn)
            objCommand.Parameters.Add("@Nom", sNom)
            objCommand.Parameters.Add("@Prenom", sPrenom)
            Call objCommand.ExecuteNonQuery()


            PrepareOptionsFile = True

        Catch ex As Exception
            Call MsgBox(ex.Message, MsgBoxStyle.Critical, Application.ProductName)
        End Try
    End Function
End Class
