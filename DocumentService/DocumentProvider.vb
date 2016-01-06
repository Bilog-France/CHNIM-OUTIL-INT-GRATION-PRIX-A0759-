Imports System.Data.SqlClient
Imports System.io
Imports System.IO.Compression

Public Class DocumentProvider

    Private sSQL As String
    Private DO_IDValue As Integer
    Private ID_CategorieValue As Integer
    Private DO_FormatValue As Integer
    Private DO_ContenuValue() As Byte
    Private DO_extensionValue As String
    Private DO_PathValue As String
    Private DO_DateValue As Date
    Private UT_IDValue As Integer
    Private DO_Info1Value As String
    Private DO_LabelValue As String
    Private DO_NoteValue As String
    Private cnValue As SqlConnection
    Private DO_DateHeureValue As Date
    Private DO_TailleValue As Integer
    Private Do_StreamValue As MemoryStream

    Public Enum TypeDoc
        Presentation = 0
        Specialite = 1
        CritChoix = 2
        CommiTrans = 3
    End Enum

    Public Property UT_ID() As Integer
        Get
            Return UT_IDValue
        End Get
        Set(ByVal value As Integer)
            UT_IDValue = value
        End Set
    End Property

    Public Property DO_DateHeure() As Date
        Get
            Return DO_DateHeureValue
        End Get
        Set(ByVal value As Date)
            DO_DateHeureValue = value
        End Set
    End Property

    Public Property Do_Stream() As MemoryStream
        Get
            Return Do_StreamValue
        End Get
        Set(ByVal Value As MemoryStream)
            Do_StreamValue = Value
        End Set
    End Property

    Public Property DO_Date() As Date
        Get
            Return DO_DateValue
        End Get
        Set(ByVal Value As Date)
            DO_DateValue = Value
        End Set
    End Property

    Public Property DO_ID() As Integer
        Get
            Return DO_IDValue
        End Get
        Set(ByVal Value As Integer)
            DO_IDValue = Value
        End Set
    End Property

    Public Property DO_Taille() As Integer
        Get
            Return DO_Taille
        End Get
        Set(ByVal value As Integer)
            DO_TailleValue = value
        End Set
    End Property

    Public Property ID_Categorie() As Integer
        Get
            Return ID_CategorieValue
        End Get
        Set(ByVal Value As Integer)
            ID_CategorieValue = Value
        End Set
    End Property

    Public Property DO_Format() As Integer
        Get
            Return DO_FormatValue
        End Get
        Set(ByVal Value As Integer)
            DO_FormatValue = Value
        End Set
    End Property

    Public Property DO_Contenu() As Byte()
        Get
            Return DO_ContenuValue
        End Get
        Set(ByVal Value As Byte())
            DO_ContenuValue = Value
        End Set
    End Property

    Public Property DO_extension() As String
        Get
            Return DO_extensionValue
        End Get
        Set(ByVal Value As String)
            DO_extensionValue = Value
        End Set
    End Property


    Public Property DO_Path() As String
        Get
            Return DO_PathValue
        End Get
        Set(ByVal Value As String)
            DO_PathValue = Value
        End Set
    End Property

    Public Property cn() As SqlConnection
        Get
            Return cnValue
        End Get
        Set(ByVal Value As SqlConnection)
            cnValue = Value
        End Set
    End Property

    Public Property DO_Info1() As String
        Get
            Return DO_Info1Value
        End Get
        Set(ByVal Value As String)
            DO_Info1Value = Value
        End Set
    End Property

    Public Property DO_Label() As String
        Get
            Return DO_LabelValue
        End Get
        Set(ByVal Value As String)
            DO_LabelValue = Value
        End Set
    End Property

    Public Property DO_Note() As String
        Get
            Return DO_NoteValue
        End Get
        Set(ByVal Value As String)
            DO_NoteValue = Value
        End Set
    End Property

    Public Sub New(ByVal sCon As String)
        Me.cn = New SqlConnection(sCon)
    End Sub


    Private Sub New(ByVal DO_ID As Integer, ByVal ID_CATEGORIE As Integer, ByVal DO_Label As String, ByVal DO_format As String, ByVal DO_Date As Date, ByVal DO_Info1 As String, ByVal DO_Contenu As Byte(), ByVal DO_Taille As Integer, ByVal DO_DateHeure As Date, ByVal DO_extension As String, ByVal UT_ID As Integer, ByVal DO_Note As String)
        Me.DO_ID = DO_ID
        Me.ID_Categorie = ID_CATEGORIE
        Me.DO_Label = DO_Label
        Me.DO_Info1 = DO_Info1
        Me.DO_Contenu = DO_Contenu
        Me.DO_Taille = DO_Taille
        Me.DO_DateHeure = DO_DateHeure
        Me.DO_extension = DO_extension
        Me.UT_ID = UT_ID
        Me.DO_Note = DO_Note
    End Sub


    Public Sub New(ByVal pDO_ID As Integer)
        Dim dr As SqlDataReader
        Try

            sSQL = "select DO_ID, ID_CATEGORIE,DO_Label,DO_format,DO_Date , DO_Info1,DO_Contenu ,DO_Taille ,DO_DateHeure ,DO_extension, UT_ID, DO_Note   from theriaque.Document where DO_ID = " & pDO_ID

            Me.DO_ID = pDO_ID
            cn.Open()
            Dim cmd As New SqlCommand(sSQL, cn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.HasRows Then
                dr.Read()
                If dr.GetValue(0) Is DBNull.Value Then
                    dr.Close()
                    dr = Nothing
                    Exit Sub
                End If

                If Not dr.GetValue(0) Is DBNull.Value Then
                    Me.DO_ID = dr.GetValue(0)
                End If
                If Not dr.GetValue(1) Is DBNull.Value Then
                    Me.ID_Categorie = dr.GetValue(1)
                End If
                If Not dr.GetValue(2) Is DBNull.Value Then
                    Me.DO_Label = dr.GetValue(2)
                End If
                If Not dr.GetValue(3) Is DBNull.Value Then
                    Me.DO_Info1 = dr.GetValue(3)
                End If
                If Not dr.GetValue(4) Is DBNull.Value Then
                    Me.DO_Contenu = dr.GetValue(4)
                End If
                If Not dr.GetValue(5) Is DBNull.Value Then
                    Me.DO_Taille = dr.GetValue(5)
                End If
                If Not dr.GetValue(6) Is DBNull.Value Then
                    Me.DO_DateHeure = dr.GetValue(6)
                End If
                If Not dr.GetValue(7) Is DBNull.Value Then
                    Me.DO_extension = dr.GetValue(7)
                End If
                If Not dr.GetValue(8) Is DBNull.Value Then
                    Me.UT_ID = dr.GetValue(8)
                End If
                If Not dr.GetValue(9) Is DBNull.Value Then
                    Me.DO_Note = dr.GetValue(9)
                End If
            End If
            dr.Close()
            dr = Nothing

            Dim arrayB As Byte()
            If dr.HasRows Then
                dr.Read()
                ReDim arrayB(dr(1))
                dr.GetBytes(0, 0, arrayB, 0, arrayB.Length)
                arrayB = Me.DO_Contenu
                Decompress(arrayB)
                Me.DO_Contenu = arrayB
                If Me.DO_Path Is Nothing Then
                    Me.DO_Path = Path.GetTempFileName()
                    Path.ChangeExtension(Me.DO_Path, "." & Me.DO_extension)
                    Me.DO_Path = Me.DO_Path.Replace(".tmp", "." & Me.DO_extension)
                    File.Delete(Me.DO_Path)
                    Me.Doc2file(Me.DO_Path)
                End If
                dr.Close()
                dr = Nothing
            Else
                If Not dr Is Nothing Then
                    If Not dr.IsClosed Then
                        dr.Close()
                        dr = Nothing
                    End If
                End If
            End If
        Catch ex As Exception
            If Not dr Is Nothing Then
                If Not dr.IsClosed Then
                    dr.Close()
                    dr = Nothing
                End If
            End If
            MsgBox(ex.Message)
        End Try

    End Sub


    Public Function Doc2file(Optional ByVal sPath As String = "", Optional ByVal ext As String = "") As String
        Try
            If sPath = "" Then
                sPath = Path.GetTempFileName()
                Path.ChangeExtension(sPath, "." & ext)
                sPath = sPath.Replace(".tmp", "." & ext)
            End If
            If File.Exists(sPath) Then File.Delete(sPath)

            Dim fs As New FileStream(sPath, FileMode.CreateNew)
            Dim bw As New BinaryWriter(fs)
            If (Me.DO_Contenu IsNot Nothing) Then
                bw.Write(Me.DO_Contenu)
            End If

            bw.Close()
            fs.Close()
            fs = Nothing
            Return sPath
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    'Cette Fonction permet l'ajout d'un nouveau document 
    'Cette fonction retourne un document pour récupérer 
    'Doc.DO_BD_ID = numéro de la bd où a été enregistré le doc
    'Doc.DOEX_ID = code de document dans la table DOEX
    'Ces deux valeurs vont permettre l’initialisation de la nouvelle ligne dans la table DO
    'Public Function AddNewDoc(ByVal Doc As StructDoc) As StructDoc
    Public Function Save(ByVal NewDoc As Boolean) As Boolean
        Try

            If DO_Contenu Is Nothing Then
                'MsgBox("Pas d'enregistrement, document Vide")
                Return False
            End If

            Dim OSize As Long = Me.DO_Contenu.LongLength

            '----- Difinition des paramètres de la requête Update 
            Dim [sByte]() As Byte = Me.DO_Contenu
            Compress([sByte])

            Dim cmd As SqlCommand

            cn.Open()
            cmd = New SqlCommand("", cn)

            cmd.Parameters.Clear()
            Dim pContenu As New SqlParameter("@DO_Contenu", [sByte])
            cmd.Parameters.Add(pContenu)

            Dim pID_CATEGORIE As New SqlParameter("@ID_CATEGORIE", IIf(Me.ID_Categorie > 0, Me.ID_Categorie, DBNull.Value))
            cmd.Parameters.Add(pID_CATEGORIE)

            Dim pDO_Label As New SqlParameter("@DO_Label", Me.DO_Label)
            cmd.Parameters.Add(pDO_Label)

            Dim pDO_format As New SqlParameter("@DO_format", Me.DO_Format)
            cmd.Parameters.Add(pDO_format)

            Dim pDO_Date As New SqlParameter("@DO_Date", Me.DO_Date)
            cmd.Parameters.Add(pDO_Date)

            Dim pDO_Info1 As New SqlParameter("@DO_Info1", Me.DO_Info1)
            cmd.Parameters.Add(pDO_Info1)

            Dim pDO_Taille As New SqlParameter("@DO_Taille", Me.DO_Taille)
            cmd.Parameters.Add(pDO_Taille)

            Dim pDO_DateHeure As New SqlParameter("@DO_DateHeure", Me.DO_DateHeure)
            cmd.Parameters.Add(pDO_DateHeure)

            If (String.IsNullOrEmpty(Me.DO_Note)) Then
                Me.DO_Note = ""
            End If
            Dim pDO_Note As New SqlParameter("@DO_Note", Me.DO_Note)
            cmd.Parameters.Add(pDO_Note)

            Dim pDO_extension As New SqlParameter("@DO_extension", Me.DO_extension)
            cmd.Parameters.Add(pDO_extension)

            Dim pUT_ID As New SqlParameter("@UT_ID", Me.UT_ID)
            cmd.Parameters.Add(pUT_ID)

            If NewDoc Then
                sSQL = "insert theriaque.Document (ID_CATEGORIE,DO_Label,DO_format,DO_Date , DO_Info1,DO_Contenu ,DO_Taille ,DO_DateHeure ,DO_extension, UT_ID, DO_Note) "
                sSQL &= " Values (@ID_CATEGORIE, @DO_Label, @DO_format, @DO_Date , @DO_Info1,@DO_Contenu ,@DO_Taille ,@DO_DateHeure ,@DO_extension, @UT_ID, @DO_Note)"
            Else
                Dim pDO_ID As New SqlParameter("@DO_ID", Me.DO_ID)
                cmd.Parameters.Add(pDO_ID)
                sSQL = "update theriaque.Document set  ID_CATEGORIE = @ID_CATEGORIE,DO_Label =@DO_Label,DO_format =@DO_format,DO_Date = @DO_Date , DO_Info1=@DO_Info1,DO_Contenu = @DO_Contenu ,DO_Taille=@DO_Taille ,DO_DateHeure=@DO_DateHeure ,DO_extension=@DO_extension, UT_ID=@UT_ID, DO_Note=@DO_Note  where DO_ID = @DO_ID"
            End If
            cmd.CommandText = sSQL
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            Me.DO_ID = GetID_DOC()
            cn.Close()

            Return True

        Catch ex As SqlException
            MsgBox(ex.Message)
            If cn.State = ConnectionState.Open Then cn.Close()
            Return False
        End Try

    End Function


    Private Function GetID_DOC() As Integer

        Dim dr As SqlDataReader

        sSQL = "select max(isNULL(DO_ID,1)) from theriaque.Document "


        Dim cmd As New SqlCommand(sSQL, cn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        dr.Read()
        Return dr.Item(0)

    End Function

    Public Function ExistATR(ByVal TYPE_CODE As Integer) As Integer

        Dim dr As SqlDataReader

        sSQL = "select null from theriaque.ATR_AVISCOMMISSIONTRANSPARENCE where ATR_CODE_SQ_PK = " & TYPE_CODE

        cn.Open()
        Dim cmd As New SqlCommand(sSQL, cn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        dr.Read()
        Dim ret As Boolean = dr.HasRows
        cn.Close()
        Return ret

    End Function

    Public Function ExistCRT(ByVal CH_CODE_SQ_PK As Integer) As Integer

        Dim dr As SqlDataReader

        sSQL = "select null from theriaque.CH_CHOIX where CH_CODE_SQ_PK = " & CH_CODE_SQ_PK

        cn.Open()
        Dim cmd As New SqlCommand(sSQL, cn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        dr.Read()
        Dim ret As Boolean = dr.HasRows
        cn.Close()
        Return ret

    End Function

    'Une simple fonction de suppression qui se base sur les deux paramètres suivants :
    'Doc.DO_BD_ID = numéro de la bd où a été enregistré le doc
    'Doc.DOEX_ID = code de document dans la table DOEX
    Public Function Delete(ByVal type As Integer) As Integer

        Try
            cn.Open()
            sSQL = "DELETE theriaque.DOC_ASSOCIATION_DOCUMENT WHERE DO_ID = " & Me.DO_ID
            Dim cmd As New SqlCommand(sSQL, cn)
            Dim ret As Integer = cmd.ExecuteNonQuery()
            cn.Close()

        Catch ex As SqlException
            If cn.State = ConnectionState.Open Then cn.Close()
            MsgBox(ex.Message)
        End Try

        'Try
        '    cn.Open()
        '    sSQL = "DELETE theriaque.DOC_PRESENTATION_DOCUMENT WHERE DO_ID = " & Me.DO_ID
        '    Dim cmd As New SqlCommand(sSQL, cn)
        '    Dim ret As Integer = cmd.ExecuteNonQuery()
        '    cn.Close()

        'Catch ex As SqlException
        '    If cn.State = ConnectionState.Open Then cn.Close()
        '    MsgBox(ex.Message)
        'End Try

        Try
            cn.Open()
            sSQL = "DELETE theriaque.Document WHERE DO_ID = " & Me.DO_ID
            Dim cmd As New SqlCommand(sSQL, cn)
            Dim ret As Integer = cmd.ExecuteNonQuery()
            cn.Close()
            Return ret
        Catch ex As SqlException
            If cn.State = ConnectionState.Open Then cn.Close()
            MsgBox(ex.Message)
        End Try

    End Function


    Public Function DeleteFromAssociation(ByVal codeDoc As Integer, ByVal codeSpec As String, ByVal TypeDoc As TypeDoc) As Integer

        Try

            'Get th cod ucd ou cod cip corspondant 
            'dim Code as String = ""
            'Select Case TypeDoc
            '    Case DocumentProvider.TypeDoc.CommiTrans, DocumentProvider.TypeDoc.CritChoix, DocumentProvider.TypeDoc.Presentation
            '        Code = codeSpec
            '    Case DocumentProvider.TypeDoc.Specialite
            '        Code = GetSP_CIPUCD_fromCode(codeSpec)
            'End Select

            cn.Open()
            If (TypeDoc = DocumentProvider.TypeDoc.Presentation) Then
                codeSpec = "'" & codeSpec & "'"
            End If
            sSQL = "DELETE theriaque.DOC_ASSOCIATION_DOCUMENT WHERE TYPE_CODE = " & codeSpec & " and DO_ID=" & codeDoc
            sSQL &= " AND TYPEDOC = " & TypeDoc

            Dim cmd As New SqlCommand(sSQL, cn)
            Dim ret As Integer = cmd.ExecuteNonQuery()
            cn.Close()
            Return ret
        Catch ex As SqlException
            If cn.State = ConnectionState.Open Then cn.Close()
            MsgBox(ex.Message)
        End Try

    End Function

    'Public Function DeleteFromPresentation(ByVal codeDoc As Integer, ByVal codePres As String) As Integer

    '    Try
    '        cn.Open()
    '        sSQL = "DELETE theriaque.DOC_PRESENTATION_DOCUMENT WHERE PRE_CODE_PK = '" & codePres & "' and DO_ID=" & codeDoc
    '        Dim cmd As New SqlCommand(sSQL, cn)
    '        Dim ret As Integer = cmd.ExecuteNonQuery()
    '        cn.Close()
    '        Return ret
    '    Catch ex As SqlException
    '        If cn.State = ConnectionState.Open Then cn.Close()
    '        MsgBox(ex.Message)
    '    End Try

    'End Function


    'Public Function DeleteFromPresentation(ByVal codeDoc As Integer, ByVal codePres As String) As Integer

    '    Try
    '        cn.Open()
    '        sSQL = "DELETE theriaque.DOC_PRESENTATION_DOCUMENT WHERE PRE_CODE_PK = '" & codePres & "' and DO_ID=" & codeDoc
    '        Dim cmd As New SqlCommand(sSQL, cn)
    '        Dim ret As Integer = cmd.ExecuteNonQuery()
    '        cn.Close()
    '        Return ret
    '    Catch ex As SqlException
    '        If cn.State = ConnectionState.Open Then cn.Close()
    '        MsgBox(ex.Message)
    '    End Try

    'End Function


    'Public Function DeleteFromPresentation(ByVal codeDoc As Integer, ByVal codePres As String) As Integer

    '    Try
    '        cn.Open()
    '        sSQL = "DELETE theriaque.DOC_PRESENTATION_DOCUMENT WHERE PRE_CODE_PK = '" & codePres & "' and DO_ID=" & codeDoc
    '        Dim cmd As New SqlCommand(sSQL, cn)
    '        Dim ret As Integer = cmd.ExecuteNonQuery()
    '        cn.Close()
    '        Return ret
    '    Catch ex As SqlException
    '        If cn.State = ConnectionState.Open Then cn.Close()
    '        MsgBox(ex.Message)
    '    End Try

    'End Function

    'Après l’ajout  d’un document, on a besoin de nnuméro  DOEX_ID 
    'pour initialise de la ligne dans la table DO, 
    'le principe consiste à exécuter une requête MAX(DOEX_ID) dans la table DOEX 
    'qui se trouve dans la base de document numéro DO_BD_ID

    Public Function Compress(ByRef aBytes() As Byte) As Boolean
        Try

            Dim ms As MemoryStream = New MemoryStream()
            Dim s As Stream = New GZipStream(ms, CompressionMode.Compress)
            s.Write(aBytes, 0, aBytes.Length)
            s.Close()
            aBytes = ms.ToArray
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Decompress(ByRef aBytes() As Byte) As Boolean

        Try

            Dim objInputStream As New MemoryStream(aBytes)
            'reset to beginning of stream for reading
            objInputStream.Seek(0, SeekOrigin.Begin)
            Dim intSize As Integer = 4096
            Dim dataBuffer(4096) As Byte
            Dim objGzipStream As New GZipStream(objInputStream, CompressionMode.Decompress)
            Dim objOutputStream As New MemoryStream

            While (intSize > 0)
                intSize = objGzipStream.Read(dataBuffer, 0, 4096)
                objOutputStream.Write(dataBuffer, 0, intSize)
            End While
            aBytes = objOutputStream.ToArray

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Public Sub AddDocumentToAssociation(ByVal IdDoc As Integer, ByVal NumSpecialite As String, ByVal TypeDoc As TypeDoc)

        Try
            'Dim Code As String = ""

            ''Get th cod ucd ou cod cip corspondant 
            'Select Case TypeDoc
            '    Case DocumentProvider.TypeDoc.CommiTrans, DocumentProvider.TypeDoc.CritChoix, DocumentProvider.TypeDoc.Presentation
            '        Code = NumSpecialite
            '    Case DocumentProvider.TypeDoc.Specialite
            '        Code = GetSP_CIPUCD_fromCode(NumSpecialite)
            'End Select
            sSQL = " if not exists (select null from theriaque.DOC_ASSOCIATION_DOCUMENT where DO_ID=" & IdDoc & " and TYPE_CODE='" & NumSpecialite & "') BEGIN "
            sSQL &= " Insert into theriaque.DOC_ASSOCIATION_DOCUMENT(DO_ID, TYPE_CODE, TYPEDOC) values(" & IdDoc & ",'" & NumSpecialite & "'," & TypeDoc & ") END "
            Dim cmd As New SqlCommand(sSQL, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()

        Catch ex As SqlException
            If cn.State = ConnectionState.Open Then cn.Close()
            MsgBox(ex.Message)
        End Try

    End Sub

    'Public Sub ImporterDocumentPresentation(ByVal IdDoc As Integer, ByVal NumPresentation As String)
    '    Try
    '        cn.Open()
    '        sSQL = "Insert into theriaque.DOC_PRESENTATION_DOCUMENT(DO_ID, PRE_CODE_PK) values(" & IdDoc & ",'" & NumPresentation & "')"
    '        Dim cmd As New SqlCommand(sSQL, cn)

    '        cmd.ExecuteNonQuery()
    '        cn.Close()

    '    Catch ex As SqlException
    '        If cn.State = ConnectionState.Open Then cn.Close()
    '    End Try
    'End Sub

    'Public Sub ImporterDocumentCritChoix(ByVal IdDoc As Integer, ByVal NumPresentation As String)
    '    Try
    '        cn.Open()
    '        sSQL = "Insert into theriaque.DOC_CRITCHOIX_DOCUMENT(DO_ID, PRE_CODE_PK) values(" & IdDoc & ",'" & NumPresentation & "')"
    '        Dim cmd As New SqlCommand(sSQL, cn)

    '        cmd.ExecuteNonQuery()
    '        cn.Close()

    '    Catch ex As SqlException
    '        If cn.State = ConnectionState.Open Then cn.Close()
    '    End Try
    'End Sub

    'Public Sub ImporterDocumentCommiTrans(ByVal IdDoc As Integer, ByVal NumPresentation As String)
    '    Try
    '        cn.Open()
    '        sSQL = "Insert into theriaque.DOC_COMMITRANS_DOCUMENT(DO_ID, PRE_CODE_PK) values(" & IdDoc & ",'" & NumPresentation & "')"
    '        Dim cmd As New SqlCommand(sSQL, cn)

    '        cmd.ExecuteNonQuery()
    '        cn.Close()

    '    Catch ex As SqlException
    '        If cn.State = ConnectionState.Open Then cn.Close()
    '    End Try
    'End Sub

    Public Function GetAllDoc() As ArrayList

        Dim doc As DocumentService.DocumentProvider
        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        Dim aDoc As New ArrayList
        Dim StrCon As String = cn.ConnectionString

        sSQL = "select DO_ID, ID_CATEGORIE,DO_Label,DO_format,DO_Date , DO_Info1,null as DO_Contenu ,DO_Taille ,DO_DateHeure ,DO_extension, UT_ID , DO_Note  from theriaque.Document "
        cn.Open()
        cmd = New SqlCommand(sSQL, cn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        Do While dr.Read()

            doc = New DocumentService.DocumentProvider(StrCon)

            If Not dr.GetValue(0) Is DBNull.Value Then
                doc.DO_ID = dr.GetValue(0)
            End If
            If Not dr.GetValue(1) Is DBNull.Value Then
                doc.ID_Categorie = dr.GetValue(1)
            End If
            If Not dr.GetValue(2) Is DBNull.Value Then
                doc.DO_Label = dr.GetValue(2)
            End If
            If Not dr.GetValue(3) Is DBNull.Value Then
                doc.DO_Format = dr.GetValue(3)
            End If
            If Not dr.GetValue(4) Is DBNull.Value Then
                doc.DO_Date = dr.GetValue(4)
            End If
            If Not dr.GetValue(5) Is DBNull.Value Then
                doc.DO_Info1 = dr.GetValue(5)
            End If
            If Not dr.GetValue(6) Is DBNull.Value Then
                'doc.DO_Contenu = dr.GetValue(6)
                'Me.Decompress(doc.DO_Contenu)
            End If
            If Not dr.GetValue(7) Is DBNull.Value Then
                doc.DO_Taille = dr.GetValue(7)
            End If
            If Not dr.GetValue(8) Is DBNull.Value Then
                doc.DO_DateHeure = dr.GetValue(8)
            End If
            If Not dr.GetValue(9) Is DBNull.Value Then
                doc.DO_extension = dr.GetValue(9)
            End If
            If Not dr.GetValue(10) Is DBNull.Value Then
                doc.UT_ID = dr.GetValue(10)
            End If
            If Not dr.GetValue(11) Is DBNull.Value Then
                doc.DO_Note = dr.GetValue(11)
            End If
            
            aDoc.Add(doc)
        Loop

        dr.Close()
        dr = Nothing
        cn.Close()
        Return aDoc

    End Function


    Public Function GetDocsByTypeDoc(ByVal idSpec As String, ByVal TypeDoc As TypeDoc) As ArrayList

        Dim doc As DocumentService.DocumentProvider
        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        Dim aDoc As New ArrayList

        'Dim Code As String

        ''Get th cod ucd ou cod cip corspondant 
        'Select Case TypeDoc
        '    Case DocumentProvider.TypeDoc.CommiTrans, DocumentProvider.TypeDoc.CritChoix, DocumentProvider.TypeDoc.Presentation
        '        Code = idSpec
        '    Case DocumentProvider.TypeDoc.Specialite
        '        Code = GetSP_CIPUCD_fromCode(idSpec)
        'End Select


        sSQL = "select d.DO_ID, d.ID_CATEGORIE,d.DO_Label,d.DO_format,d.DO_Date , d.DO_Info1,d.DO_Contenu ,d.DO_Taille ,d.DO_DateHeure ,d.DO_extension, d.UT_ID , d.DO_Note  from theriaque.Document d,theriaque.DOC_ASSOCIATION_DOCUMENT s where s.DO_ID = d.DO_ID and s.TYPE_CODE =  " & SQLText(idSpec) & " and s.TypeDoc =  " & TypeDoc
        cn.Open()
        cmd = New SqlCommand(sSQL, cn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        Do While dr.Read()

            doc = New DocumentService.DocumentProvider(Me.cn.ConnectionString)

            If Not dr.GetValue(0) Is DBNull.Value Then
                doc.DO_ID = dr.GetValue(0)
            End If
            If Not dr.GetValue(1) Is DBNull.Value Then
                doc.ID_Categorie = dr.GetValue(1)
            End If
            If Not dr.GetValue(2) Is DBNull.Value Then
                doc.DO_Label = dr.GetValue(2)
            End If
            If Not dr.GetValue(3) Is DBNull.Value Then
                doc.DO_Format = dr.GetValue(3)
            End If
            If Not dr.GetValue(4) Is DBNull.Value Then
                doc.DO_Date = dr.GetValue(4)
            End If
            If Not dr.GetValue(5) Is DBNull.Value Then
                doc.DO_Info1 = dr.GetValue(5)
            End If
            If Not dr.GetValue(6) Is DBNull.Value Then
                doc.DO_Contenu = dr.GetValue(6)
                Me.Decompress(doc.DO_Contenu)
            End If
            If Not dr.GetValue(7) Is DBNull.Value Then
                doc.DO_Taille = dr.GetValue(7)
            End If
            If Not dr.GetValue(8) Is DBNull.Value Then
                doc.DO_DateHeure = dr.GetValue(8)
            End If
            If Not dr.GetValue(9) Is DBNull.Value Then
                doc.DO_extension = dr.GetValue(9)
            End If
            If Not dr.GetValue(10) Is DBNull.Value Then
                doc.UT_ID = dr.GetValue(10)
            End If
            If Not dr.GetValue(11) Is DBNull.Value Then
                doc.DO_Note = dr.GetValue(11)
            End If

            aDoc.Add(doc)
        Loop

        dr.Close()
        dr = Nothing
        cn.Close()
        Return aDoc

    End Function

    Public Sub GetDocContent()

        Dim dr As SqlDataReader
        Dim cmd As SqlCommand

        sSQL = "select DO_Contenu from theriaque.Document  where DO_ID = " & Me.DO_ID
        cn.Open()
        cmd = New SqlCommand(sSQL, cn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        Do While dr.Read()
            Me.DO_Contenu = dr.GetValue(0)
            Me.Decompress(Me.DO_Contenu)
        Loop

        dr.Close()
        dr = Nothing
        cn.Close()
    End Sub

    Public Function GetSPCodeFromSP_CIPUCD(ByVal idDoc As String) As DataTable

        sSQL = " select SP_CODE_SQ_PK From theriaque.SP_SPECIALITE where SP_CIPUCD = '" & idDoc.ToString() & "'"

        If (cn.State = ConnectionState.Closed) Then
            cn.Open()
        End If

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(New SqlCommand(sSQL, cn))
        If Not dt Is Nothing Then
            da.Fill(dt)
        End If

        cn.Close()
        Return dt

    End Function

    'Public Function GetDocsByPresentation(ByVal PRE_CODE_PK As String) As ArrayList

    '    Dim doc As DocumentService.DocumentProvider
    '    Dim dr As SqlDataReader
    '    Dim cmd As SqlCommand
    '    Dim aDoc As New ArrayList

    '    sSQL = "select d.DO_ID, d.ID_CATEGORIE,d.DO_Label,d.DO_format,d.DO_Date , d.DO_Info1,d.DO_Contenu ,d.DO_Taille ,d.DO_DateHeure ,d.DO_extension, d.UT_ID   from theriaque.Document d,theriaque.DOC_PRESENTATION_DOCUMENT p where p.DO_ID = d.DO_ID and p.PRE_CODE_PK = '" & PRE_CODE_PK & "'"
    '    cn.Open()
    '    cmd = New SqlCommand(sSQL, cn)
    '    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

    '    Do While dr.Read()

    '        doc = New DocumentService.DocumentProvider(Me.cn.ConnectionString)

    '        If Not dr.GetValue(0) Is DBNull.Value Then
    '            doc.DO_ID = dr.GetValue(0)
    '        End If
    '        If Not dr.GetValue(1) Is DBNull.Value Then
    '            doc.ID_Categorie = dr.GetValue(1)
    '        Else
    '            doc.ID_Categorie = -1
    '        End If
    '        If Not dr.GetValue(2) Is DBNull.Value Then
    '            doc.DO_Label = dr.GetValue(2)
    '        End If
    '        If Not dr.GetValue(3) Is DBNull.Value Then
    '            doc.DO_Format = dr.GetValue(3)
    '        End If
    '        If Not dr.GetValue(4) Is DBNull.Value Then
    '            doc.DO_Date = dr.GetValue(4)
    '        End If
    '        If Not dr.GetValue(5) Is DBNull.Value Then
    '            doc.DO_Info1 = dr.GetValue(5)
    '        End If
    '        If Not dr.GetValue(6) Is DBNull.Value Then
    '            doc.DO_Contenu = dr.GetValue(6)
    '            Me.Decompress(doc.DO_Contenu)
    '        End If
    '        If Not dr.GetValue(7) Is DBNull.Value Then
    '            doc.DO_Taille = dr.GetValue(7)
    '        End If
    '        If Not dr.GetValue(8) Is DBNull.Value Then
    '            doc.DO_DateHeure = dr.GetValue(8)
    '        End If
    '        If Not dr.GetValue(9) Is DBNull.Value Then
    '            doc.DO_extension = dr.GetValue(9)
    '        End If
    '        If Not dr.GetValue(10) Is DBNull.Value Then
    '            doc.UT_ID = dr.GetValue(10)
    '        End If

    '        aDoc.Add(doc)
    '    Loop

    '    dr.Close()
    '    dr = Nothing
    '    cn.Close()
    '    Return aDoc

    'End Function


    Public Function GetSpecPresLiees(ByVal idDoc As Integer) As DataTable

        sSQL = " (select Cast(s.SP_CODE_SQ_PK as varchar(10)) as code, s.SP_NOM as Nom, 'UCD' as Type From theriaque.SP_SPECIALITE s,theriaque.DOC_ASSOCIATION_DOCUMENT d where cast(s.SP_CODE_SQ_PK as varchar) = d.TYPE_CODE and d.DO_ID = " & idDoc.ToString() + ") "
        sSQL += " UNION "
        sSQL += " (select p.PRE_CODE_PK as code, p.PRE_LIB_CEPS as Nom, 'CIP' as Type From theriaque.PRE_PRESENTATION p,theriaque.DOC_ASSOCIATION_DOCUMENT d where p.PRE_CODE_PK = d.TYPE_CODE and d.DO_ID = '" & idDoc.ToString() & "') "
        cn.Open()

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(New SqlCommand(sSQL, cn))
        If Not dt Is Nothing Then
            da.Fill(dt)
        End If

        cn.Close()
        Return dt

    End Function

    Public Function GetAllCategories() As DataTable

        sSQL = " select * from theriaque.DOC_CATEGORIE"
        cn.Open()

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(New SqlCommand(sSQL, cn))
        If Not dt Is Nothing Then
            da.Fill(dt)
        End If

        cn.Close()
        Return dt

    End Function


    Public Function CategoryUsed(ByVal Category As String) As Boolean

        Dim Query As String = " select null from [theriaque].[DOC_CATEGORIE] c, [theriaque].[DOCUMENT] d where c.ID_CATEGORIE = d.ID_CATEGORIE "
        Query &= " and c.Libelle = '" & Category & "'"

        cn.Open()

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(New SqlCommand(Query, cn))
        If Not dt Is Nothing Then
            da.Fill(dt)
        End If

        cn.Close()
        Return dt.Rows.Count <> 0

    End Function

    Function SQLText(ByVal txt As Object) As String
        txt = Replace(txt, "*", "")
        If txt Is Nothing Then txt = "''"
        If Not txt Is Nothing Then txt = "'" & Replace(txt, "'", "''") & "'"
        Return txt
    End Function

End Class


