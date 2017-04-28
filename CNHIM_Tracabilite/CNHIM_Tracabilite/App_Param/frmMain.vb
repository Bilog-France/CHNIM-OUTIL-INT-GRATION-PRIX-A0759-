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
    Friend WithEvents chkCheckAll As System.Windows.Forms.CheckBox
    Friend WithEvents btnExecuteScript As System.Windows.Forms.Button
    Friend WithEvents btClear As System.Windows.Forms.Button
    Private CN_APPTable As OleDbConnection
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button

    Private HisDBName As String = "HIS_THERIAQUE"

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
        Me.chkCheckAll = New System.Windows.Forms.CheckBox
        Me.btnExecuteScript = New System.Windows.Forms.Button
        Me.btClear = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        CType(Me.EventLogger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdInitParamData
        '
        Me.cmdInitParamData.Location = New System.Drawing.Point(443, 97)
        Me.cmdInitParamData.Name = "cmdInitParamData"
        Me.cmdInitParamData.Size = New System.Drawing.Size(104, 24)
        Me.cmdInitParamData.TabIndex = 7
        Me.cmdInitParamData.Text = "Param Data"
        '
        'cmdhisTable
        '
        Me.cmdhisTable.Location = New System.Drawing.Point(443, 127)
        Me.cmdhisTable.Name = "cmdhisTable"
        Me.cmdhisTable.Size = New System.Drawing.Size(104, 24)
        Me.cmdhisTable.TabIndex = 8
        Me.cmdhisTable.Text = "Table Historique"
        '
        'cmdtrghistorique
        '
        Me.cmdtrghistorique.Location = New System.Drawing.Point(443, 157)
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
        Me.txtServeur.Text = "172.16.1.170,8008"
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
        Me.txtPassWord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassWord.Size = New System.Drawing.Size(128, 21)
        Me.txtPassWord.TabIndex = 3
        Me.txtPassWord.Text = "2cSpy2Bjgw"
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
        Me.lvwTable.Location = New System.Drawing.Point(8, 97)
        Me.lvwTable.Name = "lvwTable"
        Me.lvwTable.Size = New System.Drawing.Size(208, 308)
        Me.lvwTable.TabIndex = 5
        '
        'lvwColonne
        '
        Me.lvwColonne.Location = New System.Drawing.Point(221, 97)
        Me.lvwColonne.Name = "lvwColonne"
        Me.lvwColonne.Size = New System.Drawing.Size(208, 308)
        Me.lvwColonne.TabIndex = 6
        '
        'cmdQuitter
        '
        Me.cmdQuitter.Location = New System.Drawing.Point(443, 380)
        Me.cmdQuitter.Name = "cmdQuitter"
        Me.cmdQuitter.Size = New System.Drawing.Size(104, 24)
        Me.cmdQuitter.TabIndex = 16
        Me.cmdQuitter.Text = "Quitter"
        '
        'cmdConnect
        '
        Me.cmdConnect.Location = New System.Drawing.Point(443, 40)
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
        Me.Button1.Location = New System.Drawing.Point(642, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 24)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Correct"
        '
        'chkCheckAll
        '
        Me.chkCheckAll.AutoSize = True
        Me.chkCheckAll.Location = New System.Drawing.Point(8, 74)
        Me.chkCheckAll.Name = "chkCheckAll"
        Me.chkCheckAll.Size = New System.Drawing.Size(84, 17)
        Me.chkCheckAll.TabIndex = 20
        Me.chkCheckAll.Text = "Cocher tous"
        Me.chkCheckAll.UseVisualStyleBackColor = True
        '
        'btnExecuteScript
        '
        Me.btnExecuteScript.Location = New System.Drawing.Point(435, 214)
        Me.btnExecuteScript.Name = "btnExecuteScript"
        Me.btnExecuteScript.Size = New System.Drawing.Size(125, 24)
        Me.btnExecuteScript.TabIndex = 21
        Me.btnExecuteScript.Text = "Execute tables scripts"
        Me.btnExecuteScript.UseVisualStyleBackColor = True
        '
        'btClear
        '
        Me.btClear.Location = New System.Drawing.Point(446, 293)
        Me.btClear.Name = "btClear"
        Me.btClear.Size = New System.Drawing.Size(104, 24)
        Me.btClear.TabIndex = 22
        Me.btClear.Text = "Nettoyer Triggers"
        Me.btClear.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(446, 323)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 24)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Nettoyer Tables"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(435, 242)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 24)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Execute triggers scripts"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(435, 350)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 24)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "Nettoyer HIS_Triggers"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(435, 267)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(125, 24)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "Execute HIS triggers "
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(435, 184)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(82, 24)
        Me.Button6.TabIndex = 27
        Me.Button6.Text = "Contenu Doc"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(520, 184)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(82, 24)
        Me.Button7.TabIndex = 28
        Me.Button7.Text = "Triggers Doc"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(627, 467)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btClear)
        Me.Controls.Add(Me.btnExecuteScript)
        Me.Controls.Add(Me.chkCheckAll)
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
        Me.Text = " "
        CType(Me.EventLogger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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

        Dim sCN_APP As New String("SERVER=SQLOLEDB;Data Source=%1;Initial Catalog=%2;UID=%3;PASSWORD=%4")
        Try
            sCN_APP = Replace(sCN_APP, "%1", txtServeur.Text)
            sCN_APP = Replace(sCN_APP, "%2", IIf(cmbBDD.Text = "", "master", cmbBDD.Text))
            sCN_APP = Replace(sCN_APP, "%3", txtUser.Text)
            sCN_APP = Replace(sCN_APP, "%4", txtPassWord.Text)
            'sCN_APP = "Persist Security Info=False;database=xmedversion6;server=bilog-prt-002\XMEd;user id = sa; password = bilogsa"

            ConnectDataBase = New SqlClient.SqlConnection(sCN_APP)
            ConnectDataBase.Open()
        Catch ex As Exception
            'Throw ex
        End Try
    End Function

    Private Sub InitForm()

        'txtPassWord.Text = "bilogsa"
        'txtUser.Text = "sa"
        'txtServeur.Text = ".\"
        cmbBDD.Items.Clear()
    End Sub

    Private Sub FillLvwListeTable()

        Dim sSql As String
        Dim ta As DataTable
        Dim rLigne As DataRow


        sSql = New String("SELECT  name FROM sys.objects  WHERE sys.objects.type = 'U' ORDER BY name")

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
            cn.Close()
            cn.Dispose()
            cn = Nothing
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

        'Dim ssql As String = ""
        'For iCpt = 0 To lvwTable.Items.Count - 1
        '    If lvwTable.GetItemCheckState(iCpt) = CheckState.Checked Then
        '        ssql += vbCr & "Select DTHIS, HISACTION, """ & lvwTable.Items(iCpt) & """ from " & lvwTable.Items(iCpt) & vbCr & "UNION"
        '    End If
        'Next iCpt

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
        'Call ConnectDataBase()
        Call CreateSqlConnection2(cmbBDD.Text, txtServeur.Text, txtUser.Text, txtPassWord.Text)
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
        Dim rsKey As DataSet
        Dim rRows As DataRow
        Dim ta As DataTable



        sSQL = "SELECT DISTINCT syscolumns.name colname, systypes.name typename, syscolumns.colorder, syscolumns.prec as taille FROM syscolumns, systypes, sysobjects "
        sSQL += "WHERE syscolumns.xusertype = systypes.xusertype AND sysobjects.id = syscolumns.id AND sysobjects.name = " & SqlFormat(sTable) & " "
        sSQL += "AND sysobjects.name NOT IN (SELECT DISTINCT sysobjects.name  FROM syscolumns, systypes, sysobjects WHERE syscolumns.xusertype = systypes.xusertype AND sysobjects.id = syscolumns.id AND systypes.name IN( 'image', 'ntext', 'text')) "
        sSQL += "ORDER BY syscolumns.colorder"

        rsTable = OpenDS(sSQL, ConnectDataBase())
        rsKey = GetPrimary_Key(sTable)

        If rsTable.Tables("Table").Rows.Count <> 0 Then

            sSQL = " IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE NAME = 'HIS_" + sTable.ToUpper + "' AND TYPE = 'U')" + vbCr
            sSQL += " DROP TABLE [HIS_" + sTable + "]" + vbCr
            sSQL += vbCr
            sSQL += " CREATE TABLE [HIS_" + sTable.ToUpper + "] ( IDHIS_" + sTable.ToUpper + " INT IDENTITY (1, 1) NOT NULL, " + vbCr
            sSQL += " HISACTION varchar(4), " + vbCr
            sSQL += " DTHIS datetime, " + vbCr
            sSQL += " SUser varchar(50), " + vbCr
            'sSQL += " COLNULL varchar(250), " + vbCr

            Dim Taille As String

            'TODO: Modif Bechir Eliminer le colonnes anciennes clés

            'For Each rRows In rsKey.Tables("Table").Rows
            '    If rRows("typename").ToString.ToUpper = "NVARCHAR" Or rRows("typename").ToString.ToUpper = "VARBINARY" Or rRows("typename").ToString.ToUpper = "VARCHAR" Or rRows("typename").ToString.ToUpper = "CHAR" Then
            '        If rRows("taille") = -1 Then
            '            Taille = "MAX"
            '        Else
            '            Taille = rRows("taille").ToString
            '        End If
            '        sSQL &= " O_" & rRows("colname") & "  " + rRows("typename").ToString.Trim & "  (" & Taille & ") , " & vbCr
            '    Else
            '        sSQL += " O_" + rRows("colname") + "  " + rRows("typename") + ", " + vbCr
            '    End If

            'Next

            For Each rRows In rsTable.Tables("Table").Rows
                If rRows("typename").ToString.ToUpper = "NVARCHAR" Or rRows("typename").ToString.ToUpper = "VARBINARY" Or rRows("typename").ToString.ToUpper = "VARCHAR" Or rRows("typename").ToString.ToUpper = "CHAR" Then
                    If rRows("taille") = -1 Then
                        Taille = "MAX"
                    Else
                        Taille = rRows("taille").ToString
                    End If
                    sSQL &= " " & rRows("colname") & "  " + rRows("typename").ToString.Trim & "  (" & Taille & ") , " & vbCr
                Else
                    sSQL += " " + rRows("colname") + "  " + rRows("typename") + ", " + vbCr
                End If

            Next

            sSQL += " CONSTRAINT PK_HIS" + sTable.ToUpper + " PRIMARY KEY(IDHIS_" + sTable.ToUpper + ") )" + vbCr '+ "GO " + vbCr
            If Not IO.Directory.Exists(Application.StartupPath & "\Script\Tables") Then IO.Directory.CreateDirectory(Application.StartupPath & "\Script\Tables")
            Call EcrireFichier(Application.StartupPath & "\Script\Tables\init_Histable.sql", sSQL)

        End If
    End Sub

    Private Function GetCol(ByVal rsTable As DataSet, ByVal Prefix As String) As String
        Dim sCol As String
        Dim rRows As DataRow

        For Each rRows In rsTable.Tables("Table").Rows
            If Prefix = Nothing Then
                sCol = sCol + rRows("colname") + ", "
            Else
                sCol = sCol + Prefix & "." & rRows("colname") + ", "
            End If
        Next
        Return Mid(sCol, 1, Len(sCol) - 2)
    End Function


    Private Sub InitTriggerHisTable_Process(ByVal sTable As String)

        Dim sSQL As String
        Dim sCol, sColValue As String
        Dim lstColI2 As String
        Dim dsKey As DataSet
        Dim dsCol As DataSet
        Dim rRows As DataRow
        lstColI2 = ""
        Dim Insert, Delete As String
        Dim O_variables(10) As String

        sSQL = vbCrLf
        dsKey = GetPrimary_Key(sTable)
        Dim sKey As String = ""
        sSQL = vbCrLf

        For Each R As DataRow In dsKey.Tables("Table").Rows
            sKey += " " & R(0) + " ;"
        Next


        Dim schemas As String = GetSchema()
        If Not IO.Directory.Exists(Application.StartupPath & "\Script\Triggers") Then IO.Directory.CreateDirectory(Application.StartupPath & "\Script\Triggers")
        Dim PathTrig As String = Application.StartupPath & "\Script\Triggers\"
        Dim PathTrigHis As String = Application.StartupPath & "\Script\TriggersHis\"

        sSQL = "SELECT DISTINCT syscolumns.name colname, systypes.name typename, syscolumns.colorder , syscolumns.prec as taille FROM syscolumns, systypes, sysobjects "
        sSQL += "WHERE syscolumns.xusertype = systypes.xusertype AND sysobjects.id = syscolumns.id AND sysobjects.name = " & SqlFormat(sTable) & " "
        'sSQL += "AND sysobjects.name NOT IN (SELECT DISTINCT sysobjects.name  FROM syscolumns, systypes, sysobjects WHERE syscolumns.xusertype = systypes.xusertype AND sysobjects.id = syscolumns.id AND systypes.name IN( 'image', 'ntext', 'text')) "
        sSQL += "ORDER BY syscolumns.colorder"

        dsCol = OpenDS(sSQL, ConnectDataBase())
        sCol = " "
        sColValue = " "

        Dim aKey() As String = sKey.Split(";")
        For j As Integer = 0 To aKey.Length - 1
            aKey(j) = " " & aKey(j).Trim & " "
        Next


        For Each rRows In dsCol.Tables("Table").Rows
            'If Array.IndexOf(aKey, " " & rRows(0).ToString.Trim & " ") >= 0 Then
            'sCol = sCol + rRows("colname") + " , O_" + rRows("colname") + " , "
            'sColValue = sColValue + rRows("colname") + ",NULL as O_" + rRows("colname") + " , "
            'lstColI2 = lstColI2 + "@" + rRows("colname") + "2 , @O_" + rRows("colname") + "2 , "
            'Else
            lstColI2 = lstColI2 + "@" + rRows("colname") + "2 , "
            sCol = sCol + rRows("colname") + " , "
            sColValue = sColValue + rRows("colname") + " , "
            'End If

        Next

        If Len(lstColI2) > 0 Then
            lstColI2 = Mid(lstColI2, 1, Len(lstColI2) - 2)
        End If


        If Len(sCol) > 0 Then
            sCol = Mid(sCol, 1, Len(sCol) - 2)
        End If

        If Len(sColValue) > 0 Then
            sColValue = Mid(sColValue, 1, Len(sColValue) - 2)
        End If




        '------- Trigger pour la suppression
        sSQL = "CREATE TRIGGER HIS_D_" + sTable.ToUpper + " ON " + schemas & "." & sTable.ToUpper + vbCr
        sSQL += " FOR DELETE AS" + vbCr
        sSQL += "BEGIN " + vbCr
        sSQL += "    INSERT INTO " + HisDBName + "..HIS_" + sTable.ToUpper + " (DTHIS, HISACTION, SUser," + sCol.ToUpper + ") " + vbCr
        sSQL += "    SELECT GETDATE(), 'SUP' , SUSER_NAME(), " + sColValue.ToUpper + " FROM DELETED " + vbCr
        sSQL += "END " + vbCr
        'sSQL += "GO " + vbCr
        EcrireFichier(PathTrig & "HIS_D_" + sTable.ToUpper + ".sql", sSQL)

        '------- Trigger pour l'ajout
        sSQL = "CREATE TRIGGER HIS_I_" + sTable.ToUpper + " ON " + schemas & "." & sTable.ToUpper + vbCr
        sSQL += " FOR INSERT AS " + vbCr
        sSQL += "BEGIN " + vbCr
        sSQL += "    INSERT INTO " + HisDBName + "..HIS_" + sTable.ToUpper + " (DTHIS, HISACTION, SUser, " + sCol.ToUpper + ") " + vbCr
        sSQL += "    SELECT GETDATE(), 'INS', SUSER_NAME(), " + sColValue.ToUpper + " FROM INSERTED " + vbCr
        sSQL += "END " + vbCr

        EcrireFichier(PathTrig & "HIS_I_" + sTable.ToUpper + ".sql", sSQL)

        '------- Trigger pour de mise à jour
        sSQL = "CREATE TRIGGER HIS_U_" + sTable.ToUpper + " ON " & schemas & "." & sTable.ToUpper + vbCr
        sSQL += " FOR UPDATE AS " + vbCr
        sSQL += "BEGIN " + vbCr

        '------ Intervention sur trigger Update 

        sSQL += " SELECT " + sColValue.ToUpper + " into #tempTable  FROM DELETED where 0=1 " + vbCr
        sSQL += " SET IDENTITY_INSERT #tempTable ON " + vbCr
        sSQL += " INSERT INTO #tempTable (" + sColValue.ToUpper().Replace("NULL AS", "") + " ) " + vbCr        sSQL += " SELECT " + sColValue.ToUpper() + " FROM DELETED " + vbCr        sSQL += " UNION " + vbCr        sSQL += " SELECT " + sColValue.ToUpper() + " FROM INSERTED " + vbCr        sSQL += " DECLARE @CountTmp int " + vbCr + " DECLARE @Countdelete int " + vbCr + " DECLARE @CountInsert int " + vbCr        sSQL += " select @CountTmp=COUNT(*) from #tempTable " + vbCr + " select @Countdelete=COUNT(*) from DELETED " + vbCr + " select @CountInsert=COUNT(*) from INSERTED " + vbCr        sSQL += " if(@CountTmp = @Countdelete + @CountInsert and @CountTmp > 0) " + vbCr        sSQL += " BEGIN " + vbCr        sSQL += " DECLARE @CurrentDate datetime " + vbCr + " DECLARE @USerNAME nvarchar(50) "        sSQL += " SET @CurrentDate =  CONVERT(smallDatetime, GETDate()) " + vbCr + " SET @UserNAME = SUSER_NAME() " + vbCr
        sSQL += "    INSERT INTO " + HisDBName + "..HIS_" + sTable.ToUpper + " (DTHIS, HISACTION, SUser," + sCol.ToUpper + ") " + vbCr

        sSQL += "    SELECT @CurrentDate, 'UPD1', @UserNAME, " + sColValue.ToUpper + " FROM DELETED " + vbCr
        sSQL += "    UNION ALL " + vbCr
        sSQL += "    SELECT @CurrentDate, 'UPD2', @UserNAME, " + sColValue.ToUpper + " FROM INSERTED " + vbCr

        sSQL += "END " + vbCr
        sSQL += " drop table #tempTable " + vbCr
        sSQL += "END " + vbCr
        '------ Fin Intervention sur trigger Update 

        EcrireFichier(PathTrig & "HIS_U_" + sTable.ToUpper + ".sql", sSQL)


        'TODO: Modification par Bechir : Eliminer les triggers historiques (Avec 4 Apostrophes)
        '------- Trigger pour de mise à jour Historique 
        '' ''Dim LstCol, lstParam, LstColP, Lstcol1, Lstcol2, Ega1top As String

        '' ''LstCol = "HISACTION,DTHIS , SUser, "


        '' ''LstColP = "			SET	 @HISACTION1		=	 @HISACTION" + vbCr
        '' ''LstColP += "			SET	 @DTHIS1		=	 @DTHIS" + vbCr
        '' ''LstColP += "			SET	 @SUser1		=	 @SUser" + vbCr
        '' ''Lstcol1 = "@HISACTION1,@DTHIS1 , @SUser1, "
        '' ''Lstcol2 = "@HISACTION2,@DTHIS2 , @SUser2, "
        '' ''lstParam = "@HISACTION,@DTHIS , @SUser, "

        '' ''Ega1top = ""

        '' ''Dim NulCol As String = ""
        '' ''sSQL = "CREATE TRIGGER U_" + sTable.ToUpper + " ON dbo.HIS_" & sTable.ToUpper + vbCr
        '' ''sSQL += "INSTEAD OF INSERT AS " + vbCr
        '' ''sSQL += "BEGIN " + vbCr
        '' ''sSQL += " 	DECLARE @HISACTION varchar(4) " + vbCr
        '' ''sSQL += " 	DECLARE @DTHIS datetime " + vbCr
        '' ''sSQL += " 	DECLARE @SUser varchar(50) " + vbCr
        '' ''sSQL += " 	DECLARE @COLNULL nvarchar(250) " + vbCr + vbCr

        '' ''sSQL += " 	DECLARE @HISACTION1 varchar(4) " + vbCr
        '' ''sSQL += " 	DECLARE @DTHIS1 datetime " + vbCr
        '' ''sSQL += " 	DECLARE @SUser1 varchar(50) " + vbCr
        ' '' ''sSQL += " 	DECLARE @COLNULL nvarchar(250) " + vbCr + vbCr

        '' ''sSQL += " 	DECLARE @HISACTION2 varchar(4) " + vbCr
        '' ''sSQL += " 	DECLARE @DTHIS2 datetime " + vbCr
        '' ''sSQL += " 	DECLARE @SUser2 varchar(50) " + vbCr
        ' '' ''sSQL += " 	DECLARE @COLNULL nvarchar(250) " + vbCr + vbCr

        ' '' ''--- Déclaration des variables
        '' ''Dim decp, dec2, dec1 As String
        '' ''decp = ""
        '' ''dec1 = ""
        '' ''dec2 = ""

        '' ''decp += "--- Variable de pacours" + vbCr
        '' ''dec1 += "--- Enregistrement UPD1" + vbCr
        '' ''dec2 += "--- Enregistrement UPD2" + vbCr
        '' ''For Each R As DataRow In dsCol.Tables("Table").Rows

        '' ''    decp += GetColDeclaration(R("colname"), R("typename"), R("taille"), "") + vbCr
        '' ''    dec1 += GetColDeclaration(R("colname"), R("typename"), R("taille"), "1") + vbCr
        '' ''    dec2 += GetColDeclaration(R("colname"), R("typename"), R("taille"), "2") + vbCr

        '' ''    '--- Ajout des champs clé primaires anciennes valeurs
        '' ''    'TODO: Bechir
        '' ''    'If Array.IndexOf(aKey, " " & R("colname").ToString.Trim & " ") >= 0 Then
        '' ''    '    decp += GetColDeclaration("O_" & R("colname"), R("typename"), R("taille"), "") + vbCr
        '' ''    '    dec1 += GetColDeclaration("O_" & R("colname"), R("typename"), R("taille"), "1") + vbCr
        '' ''    '    dec2 += GetColDeclaration("O_" & R("colname"), R("typename"), R("taille"), "2") + vbCr
        '' ''    '    LstCol += "O_" & R("colname") + ","
        '' ''    '    Lstcol1 += "@O_" & R("colname") + "1,"
        '' ''    '    lstParam += "@O_" & R("colname") + ","
        '' ''    '    LstColP += " 			SET	 @" & R("colname") & "1 	=	 @" & R("colname") + vbCr
        '' ''    '    Lstcol2 += "@O_" + R("colname") + "2,"
        '' ''    '    Lstcol2 += "@O_" + R("svTwfi4Xcolname") + ","
        '' ''    'End If
        '' ''    Ega1top += "@" & R("colname") & "1"



        '' ''    LstCol += R("colname") + ","
        '' ''    LstColP += "SET	 @" & R("colname") & "1		=	 @" & R("colname") + vbCr
        '' ''    Lstcol1 += "@" + R("colname") + "1,"
        '' ''    lstParam += "@" + R("colname") + ","
        '' ''    Lstcol2 += "@" + R("colname") + "2,"

        '' ''Next
        '' ''sSQL += decp + dec1 + dec2 + vbCr

        ' '' ''--- Suppression des derniers virgule de la liste des colonnes 
        '' ''LstCol = LstCol.Substring(0, LstCol.Length - 1)
        '' ''LstColP = LstColP.Substring(0, LstColP.Length - 1)
        '' ''Lstcol2 = Lstcol2.Substring(0, Lstcol2.Length - 1)
        '' ''Lstcol1 = Lstcol1.Substring(0, Lstcol1.Length - 1)
        '' ''lstParam = Lstcol1.Substring(0, Lstcol1.Length - 1)


        '' ''sSQL += " SET @COLNULL =''	" + vbCr

        ' '' ''--- Déclaration du curseur 
        '' ''sSQL += " DECLARE MyCursor CURSOR FOR" + vbCr
        '' ''sSQL += " SELECT " & LstCol + vbCr
        '' ''sSQL += " FROM INSERTED i" + vbCr
        '' ''sSQL += " WHERE i.HISACTION like 'UP%'" + vbCr

        '' ''sSQL += " OPEN MyCursor " + vbCr
        '' ''sSQL += " FETCH NEXT FROM MyCursor INTO " & lstParam + vbCr
        '' ''sSQL += " WHILE @@FETCH_STATUS = 0" + vbCr
        '' ''sSQL += "     BEGIN" + vbCr
        '' ''sSQL += "     --- UP1" + vbCr
        '' ''sSQL += " 		IF @HISACTION= 'UPD1'" + vbCr
        '' ''sSQL += " 		BEGIN" + vbCr
        '' ''sSQL += " 			" + LstColP + vbCr
        '' ''sSQL += " 			FETCH NEXT FROM MyCursor INTO " & lstParam + vbCr
        '' ''sSQL += " 			--- UP2" + vbCr
        '' ''sSQL += " 			IF @HISACTION = 'UPD2'" + vbCr
        '' ''sSQL += " 			BEGIN	" + vbCr
        '' ''For Each R As DataRow In dsCol.Tables("Table").Rows
        '' ''    sSQL += " 				IF @" & R("colname") & " = @" & R("colname") & "1 " + vbCr
        '' ''    sSQL += " 				BEGIN" + vbCr
        '' ''    sSQL += " 					SET @" & R("colname") & "2		=	NULL" + vbCr
        '' ''    sSQL += " 				END" + vbCr
        '' ''    sSQL += " 				ELSE" + vbCr
        '' ''    sSQL += " 				BEGIN" + vbCr
        '' ''    sSQL += " 					SET @" & R("colname") & "2		= @" & R("colname") + vbCr

        '' ''    If Array.IndexOf(aKey, " " & R("colname").ToString.Trim & " ") >= 0 Then
        '' ''        sSQL += " 					SET @O_" & R("colname") & "2		=	@" & R("colname") & "1" + vbCr
        '' ''    End If

        '' ''    'sSQL += " 					--- OLD KEY VALUE" + vbCr
        '' ''    'sSQL += " 					--SET @OLD_DDDDDDD" + vbCr
        '' ''    sSQL += " 					--- COLNULL" + vbCr
        '' ''    sSQL += " 					SET @COLNULL = @COLNULL + CASE @" + R("colname") + " WHEN  NULL THEN '" + R("colname") + ",' ELSE '' END	" + vbCr
        '' ''    sSQL += " 				END" + vbCr
        '' ''Next

        '' ''sSQL += " 				INSERT INTO  dbo.HIS_" + sTable.ToUpper + vbCr
        '' ''sSQL += " 				(" + vbCr
        '' ''sSQL += " 				" + LstCol + vbCr
        '' ''sSQL += " 				)" + vbCr
        '' ''sSQL += " 				VALUES" + vbCr
        '' ''sSQL += " 				(@HISACTION, @DTHIS, @SUser," + vbCr
        '' ''sSQL += " 				" + lstColI2 + vbCr
        '' ''sSQL += " 				)" + vbCr
        '' ''sSQL += " 			END" + vbCr
        '' ''sSQL += " 		END" + vbCr
        '' ''sSQL += "		FETCH NEXT FROM MyCursor INTO " & lstParam + vbCr
        '' ''sSQL += " 	END" + vbCr
        '' ''sSQL += " 	CLOSE MyCursor" + vbCr
        '' ''sSQL += "   DEALLOCATE MyCursor   " + vbCr
        '' ''sSQL += " END" + vbCr




        'sSQL += "DECLARE @Ins int" + vbCr
        'sSQL += "---------------- traitement des enregistrements vides" + vbCr
        'Dim sVide As String = ""

        'sSQL += "SELECT @Ins ="
        'sVide += "   CASE "
        'Dim y As Integer = 0
        'For Each R As DataRow In dsCol.Tables("Table").Rows
        '    If Array.IndexOf(aKey, R(0).ToString.Trim) < 0 Then
        '        Insert = GetEgalNullExpression(R(0), sTable.ToUpper, "INSERTED")
        '        If y = 0 Then
        '            'sSQL += "      WHEN ((" + Insert + " = '0')" + vbCr
        '            sVide += "      WHEN ((" + Insert + ")" + vbCr
        '            y = 1
        '        Else
        '            'sSQL += "      AND ((" + Insert + " = '0'))" + vbCr
        '            sVide += "      AND ((" + Insert + "))" + vbCr
        '        End If
        '    End If
        'Next
        'If sVide = "   CASE " Then
        '    sSQL += " 0" + vbCr
        'Else
        '    sSQL += vbCr + sVide
        '    sSQL += "      ) THEN 0 ELSE 1 END " + vbCr
        'End If

        'sSQL += "      FROM INSERTED" + vbCr
        'sSQL += "---------------- Si tous les champs sont nuls " + vbCr
        'sSQL += "      IF  (@Ins =1)" + vbCr
        'sSQL += "           BEGIN" + vbCr
        'sSQL += "               INSERT INTO " + HisDBName + "..HIS_" + sTable.ToUpper + " (DTHIS, HISACTION, SUser, " + sCol.ToUpper + ", COLNULL) " + vbCr
        'sSQL += "               SELECT GETDATE(), 'UPD', SUSER_NAME(), " & vbCr
        'Dim KeepV As Boolean = False
        'sSQL += "---------------- vérification de la mise à jour de la clé primaire " + vbCr
        'For Each R As DataRow In dsCol.Tables("Table").Rows
        '    Insert = GetNullExpression(R(0), sTable.ToUpper, "INSERTED")
        '    Delete = Insert.Replace("INSERTED.", "DELETED.")

        '    If sKey.IndexOf(" " & R(0).ToString & " ") >= 0 Then
        '        'LZA
        '        sSQL += vbCr & "                DELETED." + R(0) + ",  CASE WHEN (" + Delete + " <> " + Insert + " ) THEN INSERTED." + R(0) + " ELSE  NULL END,"
        '        'sSQL += vbCr & "                INSERTED." + R(0) + ","
        '    Else
        '        KeepV = True
        '        sSQL += vbCr + "                CASE WHEN (" + Delete + " <> " + Insert + " ) THEN INSERTED." + R(0) + " ELSE  NULL END,"
        '        NulCol += vbCr + "              CASE WHEN (" + Delete + " <> " + Insert + " ) AND INSERTED." + R(0) + " IS NULL THEN '," + R(0) + "' ELSE  '0' END +"
        '    End If
        'Next
        'If Not KeepV Then
        '    sSQL = sSQL.Substring(0, sSQL.Length - 1)

        'End If

        ''sSQL = sSQL.Substring(0, sSQL.Length - 1)
        'If NulCol <> "" Then
        '    NulCol = NulCol.Substring(0, NulCol.Length - 1)
        'Else
        '    NulCol = ",''"
        'End If


        'sSQL += vbCr + "---------------- Traitement des champs nuls " & vbCr & NulCol
        'sSQL += vbCr & "---------------- FROM" + vbCr
        ''----------------FROM  
        'sSQL += vbCr + "        FROM INSERTED , DELETED " + vbCr

        ''----------------WHERE
        'sSQL += vbCr & "---------------- WHERE" + vbCr
        'If dsKey.Tables("Table").Rows.Count > 0 Then
        '    sSQL += "        WHERE " + vbCr
        'End If
        'Dim i As Integer = 0
        'For Each R As DataRow In dsKey.Tables("Table").Rows
        '    If i = 0 Then
        '        sSQL += "           DELETED." + R(0) + " = INSERTED." + R(0) + vbCr
        '    Else
        '        sSQL += "           AND DELETED." + R(0) + " = INSERTED." + R(0) + vbCr
        '    End If
        '    i = 1
        'Next

        'sSQL += "           END " + vbCr
        'sSQL += "END " + vbCr
        '  EcrireFichier(PathTrigHis & "U_" + sTable.ToUpper + ".sql", sSQL)

    End Sub

    'Private Function GetPrimary_Key(ByVal Table As String) As DataSet

    '    Dim sSQL As String
    '    sSQL = "SELECT B.COLUMN_NAME"
    '    sSQL &= " FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS A, INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE B"
    '    sSQL &= " WHERE A.CONSTRAINT_TYPE = 'PRIMARY KEY' AND A.CONSTRAINT_NAME = B.CONSTRAINT_NAME"
    '    sSQL &= " and a.table_name ='" + Table + "'"
    '    Return OpenDS(sSQL, ConnectDataBase())

    'End Function
    Private Function GetPrimary_Key(ByVal stable As String) As DataSet
        Dim SQL As String

        SQL = "SELECT DISTINCT syscolumns.name colname, systypes.name typename, syscolumns.colorder , syscolumns.prec as taille FROM syscolumns, systypes, sysobjects "
        SQL &= " WHERE syscolumns.xusertype = systypes.xusertype "
        SQL &= " AND sysobjects.id = syscolumns.id AND sysobjects.name = " & SqlFormat(stable) & " "
        SQL &= " AND systypes.name NOT IN ( 'image', 'ntext', 'text')"
        SQL &= " AND syscolumns.name in ("
        SQL &= " SELECT B.column_name"
        SQL &= " FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS A, INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE B"
        SQL &= "         WHERE A.CONSTRAINT_TYPE = 'PRIMARY KEY' AND A.CONSTRAINT_NAME = B.CONSTRAINT_NAME"
        SQL &= "         and a.table_name = " & SqlFormat(stable) & " )"
        SQL &= " ORDER BY syscolumns.colorder "

        Return OpenDS(SQL, ConnectDataBase())


    End Function

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

    Public Sub EcrireLineFichier(ByVal CheminFichier As String, ByVal Contenu As String)
        Dim Fich As StreamWriter
        Try
            Fich = New StreamWriter(CheminFichier, True)
            Fich.WriteLine(Contenu)
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



    Public Function RunScriptFile(ByVal sScriptFile As String, ByVal fName As String) As Boolean

        Dim objScript As StreamReader
        Dim sCommand As String()
        Dim iCpt As Integer
        Dim cn As New SqlConnection

        If (fName.Equals("init_Histable.sql")) Or fName.Substring(0, 2) = "U_" Then
            cn = New SqlConnection("SERVER=SQLOLEDB;Data Source=" & txtServeur.Text & ";Initial Catalog=HIS_THERIAQUE;UID=" & txtUser.Text & ";PASSWORD=" & txtPassWord.Text)
            cn.Open()
        Else
            cn = ConnectDataBase()
        End If



        RunScriptFile = False
        If File.Exists(sScriptFile) Then
            objScript = New StreamReader(sScriptFile)
            sCommand = Split(objScript.ReadToEnd, ";")

            For iCpt = sCommand.GetLowerBound(0) To sCommand.GetUpperBound(0)
                'MsgBox(sCommand.GetValue(iCpt))
                Try
                    ExecuteNonQuery(sCommand.GetValue(iCpt), cn)
                Catch ex As Exception

                    EcrireLineFichier(Application.StartupPath & "\Script\Log.txt", "Error=" & sCommand.GetValue(iCpt))
                    'Call MsgBox(ex.Message, MsgBoxStyle.Critical, Application.ProductName)


                End Try

            Next
        End If

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
            objCommand.Parameters.AddWithValue("@Nom", sNom)
            objCommand.Parameters.AddWithValue("@Prenom", sPrenom)
            Call objCommand.ExecuteNonQuery()


            PrepareOptionsFile = True

        Catch ex As Exception
            Call MsgBox(ex.Message, MsgBoxStyle.Critical, Application.ProductName)
        End Try
    End Function

    Private Sub chkCheckAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheckAll.CheckedChanged

        For i As Integer = 0 To lvwTable.Items.Count - 1
            lvwTable.SetItemCheckState(i, chkCheckAll.CheckState)
        Next

    End Sub



    Private Sub btnExecuteScript_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExecuteScript.Click

        '' ''Clear()
        ' '' ''MsgBox(Application.StartupPath & "\Script\")
        Dim d As DirectoryInfo = New DirectoryInfo(Application.StartupPath & "\Script\Tables")
        For Each f As FileInfo In d.GetFiles("*.sql")
            RunScriptFile(f.FullName, f.Name)
        Next

    End Sub

    Private Function GetSchema() As String
        Return New SqlCommand("select top 1 SCHEMA_NAME(schema_id)  from sys.objects where type = 'U'", ConnectDataBase()).ExecuteScalar()
    End Function

    Private Sub Clear(ByVal DeleteType As Integer, ByVal DelTriggerOrTable As Integer)

        Dim sSql As String
        Dim rsTable As DataSet

        If (DeleteType = enumActionType.cstActionType_TRGHISTORIQUE) Then

            'drop trigger
            sSql += "select (SCHEMA_NAME(schema_id) + '.' + name ) as name from sys.objects  where name like 'HIS%' and type = 'TR'"

            rsTable = OpenDS(sSql, ConnectDataBase())

            For Each r As DataRow In rsTable.Tables("Table").Rows
                sSql += "drop trigger " & r("name") + vbCrLf
                ExecuteScalar("drop trigger " & r("name"))
            Next
            'MsgBox(sSql)

        End If


        If (DeleteType = enumActionType.cstActionType_HISTORIQUE) Then
            'drop historique table

            If (DelTriggerOrTable = 0) Then

                sSql = "use " & HisDBName & " select (SCHEMA_NAME(schema_id) + '.' + name ) as name from sys.objects  where name like 'HIS%' and type = 'U'"
                rsTable = OpenDS(sSql, ConnectDataBase())



                For Each r As DataRow In rsTable.Tables("Table").Rows
                    Dim cn As SqlConnection = New SqlConnection("SERVER=SQLOLEDB;Data Source=" & txtServeur.Text & ";Initial Catalog=HIS_THERIAQUE;UID=" & txtUser.Text & ";PASSWORD=" & txtPassWord.Text)
                    cn.Open()

                    ExecuteNonQuery("drop table " & r("name"), cn)
                Next

            Else

                sSql = "use " & HisDBName & " select (SCHEMA_NAME(schema_id) + '.' + name ) as name from sys.objects  where name like 'U_%' and type = 'TR'"
                rsTable = OpenDS(sSql, ConnectDataBase())

                For Each r As DataRow In rsTable.Tables("Table").Rows
                    Dim cn As SqlConnection = New SqlConnection("SERVER=SQLOLEDB;Data Source=" & txtServeur.Text & ";Initial Catalog=HIS_THERIAQUE;UID=" & txtUser.Text & ";PASSWORD=" & txtPassWord.Text)
                    cn.Open()

                    ExecuteNonQuery("drop trigger " & r("name"), cn)
                Next

            End If

        End If


    End Sub

    Private Function ExecuteScalar(ByVal ssql As String) As Integer
        Dim i As Integer

        Dim cn As New SqlConnection
        cn = ConnectDataBase()
        Try
            i = New SqlCommand(ssql, cn).ExecuteScalar()
        Catch ex As Exception

        End Try


        cn.Close()
        cn.Dispose()
        cn = Nothing

        Return i

    End Function
    Private Function sExecuteScalar(ByVal ssql As String) As String
        Dim s As String

        Dim cn As New SqlConnection
        cn = ConnectDataBase()
        s = New SqlCommand(ssql, cn).ExecuteScalar().ToString

        cn.Close()
        cn.Dispose()
        cn = Nothing

        Return s

    End Function

    Private Function ExecuteNonQuery(ByVal sSql As String, ByVal cn As SqlConnection) As Integer
        Dim i As Integer

        'Dim cn As New SqlConnection
        'cn = ConnectDataBase()

        i = New SqlCommand(sSql, cn).ExecuteNonQuery()

        cn.Close()
        cn.Dispose()
        cn = Nothing


        Return i

    End Function

    Private Sub btClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClear.Click
        Clear(enumActionType.cstActionType_TRGHISTORIQUE, 0)
    End Sub

    Private Function GetNullExpression(ByVal Col As String, ByVal Table As String, ByVal PrefixeCol As String) As String
        Dim sType As String = Getype(Col, Table)
        Select Case sType

            Case "bit"
                Return "ISNULL(" & PrefixeCol & "." & Col & ",0)"
            Case "char"
                Return "ISNULL(" & PrefixeCol & "." & Col & ",'0')"
            Case "datetime"
                Return "ISNULL(cast(" & PrefixeCol & "." & Col & " as varchar(20)), '0')"
            Case "decimal"
                Return "ISNULL(" & PrefixeCol & "." & Col & ",-999)"
            Case "float"
                Return "ISNULL(" & PrefixeCol & "." & Col & ",-999)"
            Case "int"
                Return "ISNULL(" & PrefixeCol & "." & Col & ",-999)"
            Case "numeric"
                Return "ISNULL(" & PrefixeCol & "." & Col & ",-999)"
            Case "nvarchar"
                Return "ISNULL(" & PrefixeCol & "." & Col & ",'')"
            Case "smallint"
                Return "ISNULL(" & PrefixeCol & "." & Col & ",-999)"
            Case "tinyint"
                Return "ISNULL(" & PrefixeCol & "." & Col & ",-999)"
            Case "varbinary"
                Return "ISNULL(DATALENGTH(" & PrefixeCol & "." & Col & "), -1)"
            Case "varchar"
                Return "ISNULL(" & PrefixeCol & "." & Col & ",'0')"
        End Select
    End Function

    Private Function GetEgalNullExpression(ByVal Col As String, ByVal Table As String, ByVal PrefixeCol As String) As String
        Dim sType As String = Getype(Col, Table)
        Select Case sType

            Case "bit"
                Return "ISNULL(" & PrefixeCol & "." & Col & ",0) = 0 "
            Case "char"
                Return "ISNULL(" & PrefixeCol & "." & Col & ",'0') = '0'"
            Case "datetime"
                Return "ISNULL(cast(" & PrefixeCol & "." & Col & " as varchar(20)), '0') = '0'"
            Case "decimal"
                Return "ISNULL(" & PrefixeCol & "." & Col & ",-999)= -999"
            Case "float"
                Return "ISNULL(" & PrefixeCol & "." & Col & ",-999)= -999"
            Case "int"
                Return "ISNULL(" & PrefixeCol & "." & Col & ",-999) = -999"
            Case "numeric"
                Return "ISNULL(" & PrefixeCol & "." & Col & ",-999)= -999"
            Case "nvarchar"
                Return "ISNULL(" & PrefixeCol & "." & Col & ",'')= ''"
            Case "smallint"
                Return "ISNULL(" & PrefixeCol & "." & Col & ",-999)= -999"
            Case "tinyint"
                Return "ISNULL(" & PrefixeCol & "." & Col & ",-999)= -999"
            Case "varbinary"
                Return "ISNULL(DATALENGTH(" & PrefixeCol & "." & Col & "), -1) = -1"
            Case "varchar"
                Return "ISNULL(" & PrefixeCol & "." & Col & ",'0') = '0'"
        End Select
    End Function

    Private Function Getype(ByVal col As String, ByVal Table As String) As String
        Dim sSQL = "SELECT DAta_type FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='" & Table & "' AND COLUMN_NAME = '" & col & "'"
        Return sExecuteScalar(sSQL)
    End Function


    Private Function GetColDeclaration(ByVal Colname As String, ByVal Type As String, ByVal taille As String, ByVal postfix As String) As String

        Select Case Type
            Case "bit", "char", "datetime", "decimal", "float", "int", "numeric", "smallint", "tinyint"
                Return "DECLARE @" & Colname & postfix & " " & Type
            Case "nvarchar", "varbinary", "varchar"
                If taille = "-1" Then taille = "MAX"
                Return "DECLARE @" & Colname & postfix & " " & Type & "(" & taille & ")"
        End Select

    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Clear(enumActionType.cstActionType_HISTORIQUE, 0)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim d As DirectoryInfo = New DirectoryInfo(Application.StartupPath & "\Script\Triggers")
        For Each f As FileInfo In d.GetFiles("*.sql")
            RunScriptFile(f.FullName, f.Name)
        Next

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Clear(enumActionType.cstActionType_HISTORIQUE, 1)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim d As DirectoryInfo = New DirectoryInfo(Application.StartupPath & "\Script\TriggersHis\")
        For Each f As FileInfo In d.GetFiles("*.sql")
            RunScriptFile(f.FullName, f.Name)
        Next

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        ' Gérer le contenu de document dans une table à part pour optimiser la gestion d'espace disque

        Dim sSQL As String

        sSQL = " IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HIS_CONTENU_DOCUMENT]') AND type in (N'U')) " + vbCr
        sSQL += " DROP TABLE [dbo].[HIS_CONTENU_DOCUMENT] " + vbCr
        sSQL += vbCr
        sSQL += " CREATE TABLE [dbo].[HIS_CONTENU_DOCUMENT]( [REF_CONTENU] [int] IDENTITY(1,1) NOT NULL,[DO_Contenu] [varbinary](max) NULL, CONSTRAINT [PK_HIS_CONTENU_DOCUMENT] PRIMARY KEY CLUSTERED  " + vbCr
        sSQL += " ( [REF_CONTENU] ) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY] ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY] " + vbCr

        sSQL += " EXEC sp_RENAME '[dbo].[HIS_DOCUMENT].[DO_Contenu]' , 'Ref_Contenu', 'COLUMN' " + vbCr
        sSQL += " alter table dbo.HIS_DOCUMENT alter column Ref_Contenu int "


        Call EcrireFichier(Application.StartupPath & "\Script\Tables\init_Histable.sql", sSQL)

        MsgBox("Script Contenu Document généré avec succès")


    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        If (MessageBox.Show("Vérifier que les trigger Document n'existent plus", "Changer la use BD", MessageBoxButtons.YesNoCancel)) Then

            Dim d As DirectoryInfo = New DirectoryInfo("D:\Repositorie\theriaque\THERIAQUE\Sources\V1.0\Theriaque\CNHIM_Tracabilite\CNHIM_Tracabilite\App_Param\bin\Script\TriggersDOC") '(Application.StartupPath & "\Script\TriggersDOC\")
            For Each f As FileInfo In d.GetFiles("*.sql")
                RunScriptFile(f.FullName, f.Name)
            Next

        End If


    End Sub

End Class
