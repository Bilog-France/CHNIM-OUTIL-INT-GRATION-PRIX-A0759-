Imports System.IO

Public Class frmProgressBar

    Inherits System.Windows.Forms.Form

    Private m_bIsStoped As Boolean = False

    Public Property IsStoped() As Boolean
        Get
            Return (m_bIsStoped)
        End Get
        Set(ByVal Value As Boolean)
            m_bIsStoped = Value
        End Set
    End Property

    Enum ActionType
        FirstPrg = 1
        SecondPrg = 2
        BothPrg = 3
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
    Friend WithEvents prgFirst As System.Windows.Forms.ProgressBar
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents lblSecond As System.Windows.Forms.Label
    Friend WithEvents prgSecond As System.Windows.Forms.ProgressBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.prgFirst = New System.Windows.Forms.ProgressBar
        Me.prgSecond = New System.Windows.Forms.ProgressBar
        Me.lblFirst = New System.Windows.Forms.Label
        Me.lblSecond = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'prgFirst
        '
        Me.prgFirst.Location = New System.Drawing.Point(8, 40)
        Me.prgFirst.Name = "prgFirst"
        Me.prgFirst.Size = New System.Drawing.Size(376, 24)
        Me.prgFirst.TabIndex = 1
        '
        'prgSecond
        '
        Me.prgSecond.Location = New System.Drawing.Point(8, 96)
        Me.prgSecond.Name = "prgSecond"
        Me.prgSecond.Size = New System.Drawing.Size(376, 24)
        Me.prgSecond.TabIndex = 2
        '
        'lblFirst
        '
        Me.lblFirst.Location = New System.Drawing.Point(16, 16)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(344, 16)
        Me.lblFirst.TabIndex = 3
        '
        'lblSecond
        '
        Me.lblSecond.Location = New System.Drawing.Point(16, 72)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(344, 16)
        Me.lblSecond.TabIndex = 4
        '
        'frmProgressBar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(392, 150)
        Me.Controls.Add(Me.lblSecond)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.prgSecond)
        Me.Controls.Add(Me.prgFirst)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProgressBar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProgressBar"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Evenement du formulaire"
    Private Sub frmProgressBar_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        m_bIsStoped = True
    End Sub

#End Region

#Region "Fonction public ProgressBar"


    Public Function GetRecordCount(ByRef Rs As ADODB.Recordset) As Integer
        GetRecordCount = 0
        Try
            If Rs.EOF Then Exit Function
            Rs.MoveFirst()
            While Not Rs.EOF
                GetRecordCount += 1
                Rs.MoveNext()
            End While
            Rs.MoveFirst()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CopyMsAccessStruct(ByVal sDbOrigine As String, ByVal sDBDestination As String, ByVal sDBStereo As String) As Boolean

        Dim objCatOri As ADOX.CatalogClass
        Dim objCatDis As ADOX.CatalogClass
        Dim objTableDis As ADOX.TableClass
        Dim objCol As ADOX.ColumnClass
        Dim objIndCol As ADOX.ColumnClass
        Dim objInd As ADOX.IndexClass

        Dim objCNOri As ADODB.Connection
        Dim objCNDes As ADODB.Connection
        Dim iCpt As Integer
        Dim iCptCol As Integer
        Dim iCptInd As Integer
        Dim iCptIndCol As Integer

        Try
            CopyMsAccessStruct = False

            objCatOri = New ADOX.CatalogClass
            objCatDis = New ADOX.CatalogClass
            objCNOri = New ADODB.Connection
            objCNDes = New ADODB.Connection

            Call InitForm(ActionType.FirstPrg)
            If Not File.Exists(sDBStereo) Then Exit Function
            If File.Exists(sDBDestination) Then File.Delete(sDBDestination)
            Call File.Copy(sDBStereo, sDBDestination)

            Call objCNOri.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & sDbOrigine)
            Call objCNDes.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & sDBDestination)
            objCatOri.ActiveConnection = objCNOri
            objCatDis.ActiveConnection = objCNDes

            Me.Text = "Copie de la structure..."
            For iCpt = 0 To objCatOri.Tables.Count - 1
                Call ChangePrgStat(ActionType.FirstPrg, "Table" & CStr(iCpt) & "/" & CStr(objCatOri.Tables.Count) & "[" & objCatOri.Tables(iCpt).Name & "]", objCatOri.Tables.Count, iCpt)
                'Pour chaque objets de type TABLE
                If objCatOri.Tables(iCpt).Type.ToString = "TABLE" Then
                    objTableDis = New ADOX.TableClass
                    objTableDis.Name = objCatOri.Tables(iCpt).Name

                    'Ajout des colonnes
                    For iCptCol = 0 To objCatOri.Tables(iCpt).Columns.Count - 1
                        objCol = New ADOX.ColumnClass

                        objCol.Attributes = objCatOri.Tables(iCpt).Columns(iCptCol).Attributes
                        objCol.DefinedSize = objCatOri.Tables(iCpt).Columns(iCptCol).DefinedSize
                        objCol.Name = objCatOri.Tables(iCpt).Columns(iCptCol).Name
                        objCol.NumericScale = objCatOri.Tables(iCpt).Columns(iCptCol).NumericScale
                        objCol.ParentCatalog = objCatOri.Tables(iCpt).Columns(iCptCol).ParentCatalog
                        objCol.Precision = objCatOri.Tables(iCpt).Columns(iCptCol).Precision
                        objCol.Type = objCatOri.Tables(iCpt).Columns(iCptCol).Type
                        Call objTableDis.Columns.Append(objCol)
                        objCol = Nothing
                    Next

                    'Ajout des indexes
                    For iCptInd = 0 To objCatOri.Tables(iCpt).Indexes.Count - 1
                        objInd = New ADOX.IndexClass
                        'ajout des colonnes des clef
                        For iCptIndCol = 0 To objCatOri.Tables(iCpt).Indexes(iCptInd).Columns.Count - 1
                            objIndCol = New ADOX.ColumnClass
                            objIndCol.Name = objCatOri.Tables(iCpt).Indexes(iCptInd).Columns(iCptIndCol).Name
                            objIndCol.ParentCatalog = objCatOri.Tables(iCpt).Indexes(iCptInd).Columns(iCptIndCol).ParentCatalog
                            Call objInd.Columns.Append(objIndCol)
                        Next

                        objInd.Name = objCatOri.Tables(iCpt).Indexes(iCptInd).Name
                        objInd.Clustered = objCatOri.Tables(iCpt).Indexes(iCptInd).Clustered
                        objInd.IndexNulls = objCatOri.Tables(iCpt).Indexes(iCptInd).IndexNulls
                        objInd.PrimaryKey = objCatOri.Tables(iCpt).Indexes(iCptInd).PrimaryKey
                        objInd.Unique = objCatOri.Tables(iCpt).Indexes(iCptInd).Unique

                        Call objTableDis.Indexes.Append(objInd)
                        objInd = Nothing
                    Next

                    'Ajout de la table
                    objCatDis.Tables.Append(objTableDis)
                    objTableDis = Nothing
                End If
                Call Application.DoEvents()

            Next
            Call objCNDes.Close()
            Call objCNOri.Close()
            objCatOri.ActiveConnection = Nothing
            objCatDis.ActiveConnection = Nothing
            objCatOri = Nothing
            objCatDis = Nothing
            objCNDes = Nothing
            objCNOri = Nothing
            CopyMsAccessStruct = True
        Catch ex As Exception
            CopyMsAccessStruct = False
            Throw ex
        End Try
    End Function
    Public Function CopyMsAccessData(ByVal sDbOrigine As String, ByVal sDBDestination As String) As Boolean

        Dim ObjCatOri As ADOX.CatalogClass
        Dim objCNOri As ADODB.Connection
        Dim objCNDes As ADODB.Connection
        Dim rsOri As ADODB.Recordset
        Dim rsDes As ADODB.Recordset
        Dim objField As ADODB.Field
        Dim iCpt As Integer
        Dim iCptCol As Integer
        Dim iCptPrg As Integer

        Try
            CopyMsAccessData = False
            ObjCatOri = New ADOX.CatalogClass
            objCNOri = New ADODB.Connection
            objCNDes = New ADODB.Connection

            Call objCNOri.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & sDbOrigine)
            Call objCNDes.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & sDBDestination)
            ObjCatOri.ActiveConnection = objCNOri
            'Copie Data
            Cursor = Cursors.WaitCursor
            Call Application.DoEvents()
            Call InitForm(ActionType.BothPrg)

            Me.Text = "Copy de données"
            For iCpt = 0 To ObjCatOri.Tables.Count - 1
                Call ChangePrgStat(ActionType.FirstPrg, "Table " & CStr(prgFirst.Value) & "/" & CStr(ObjCatOri.Tables.Count - 1), ObjCatOri.Tables.Count, iCpt)
                Call Application.DoEvents()

                If ObjCatOri.Tables(iCpt).Type.ToString = "TABLE" Then
                    rsOri = New ADODB.Recordset
                    rsDes = New ADODB.Recordset

                    Call rsOri.Open("[" & ObjCatOri.Tables(iCpt).Name & "]", objCNOri, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
                    Call rsDes.Open("[" & ObjCatOri.Tables(iCpt).Name & "]", objCNDes, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

                    If Not rsOri.EOF Then rsOri.MoveFirst()

                    iCptPrg = GetRecordCount(rsOri)
                    prgSecond.Maximum = iCptPrg
                    prgSecond.Value = 0

                    While Not rsOri.EOF
                        Call ChangePrgStat(ActionType.SecondPrg, "Enr " & CStr(prgSecond.Value) & "/" & CStr(iCptPrg), iCptPrg, (prgSecond.Value + 1))
                        Call Application.DoEvents()

                        rsDes.AddNew()
                        For iCptCol = 0 To rsOri.Fields.Count - 1
                            rsDes.Fields(rsOri.Fields(iCptCol).Name).Value = rsOri.Fields(iCptCol).Value
                        Next iCptCol
                        Call rsOri.MoveNext()
                        If m_bIsStoped Then Exit While
                    End While
                    rsDes.UpdateBatch()
                End If
                If m_bIsStoped Then Exit For
            Next
            Cursor = Cursors.Default
            Call objCNOri.Close()
            Call objCNDes.Close()
            ObjCatOri.ActiveConnection = Nothing
            ObjCatOri = Nothing
            objCNOri = Nothing
            objCNDes = Nothing
            rsDes = Nothing
            rsOri = Nothing
            CopyMsAccessData = True
        Catch ex As Exception
            CopyMsAccessData = False
            Throw ex
        End Try

    End Function
    Public Function CopyMsAccessData_(ByVal sDbOrigine As String, ByVal sDBDestination As String) As Boolean

        Dim ObjCatOri As ADOX.CatalogClass
        Dim objCNOri As ADODB.Connection
        Dim objCol As ADOX.Column
        Dim objCmd As ADODB.Command
        Dim iCpt As Integer
        Dim sTable As String
        Dim sSQLInsert As String
        Dim sSQLSource As String


        ObjCatOri = New ADOX.CatalogClass
        objCNOri = New ADODB.Connection
        objCmd = New ADODB.Command

        Try
            CopyMsAccessData_ = False
            Call objCNOri.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & sDbOrigine)
            ObjCatOri.ActiveConnection = objCNOri
            'Copie Data
            Cursor = Cursors.WaitCursor
            Call Application.DoEvents()
            Call InitForm(ActionType.FirstPrg)

            Me.Text = "Copie des données..."
            For iCpt = 0 To ObjCatOri.Tables.Count - 1
                sTable = "[" & ObjCatOri.Tables(iCpt).Name & "]"
                Call ChangePrgStat(ActionType.FirstPrg, "Table " & CStr(prgFirst.Value) & "/" & CStr(ObjCatOri.Tables.Count - 1) & " " & sTable, ObjCatOri.Tables.Count, iCpt)
                Call Application.DoEvents()
                If ObjCatOri.Tables(iCpt).Type.ToString = "TABLE" Then

                    sSQLInsert = "INSERT INTO " & sTable & " ("
                    sSQLSource = "SELECT "
                    For Each objCol In ObjCatOri.Tables(iCpt).Columns
                        sSQLInsert = sSQLInsert & "[" & objCol.Name & "], "
                        sSQLSource = sSQLSource & sTable & ".[" & objCol.Name & "], "
                    Next

                    sSQLInsert = Mid(sSQLInsert, 1, Len(sSQLInsert) - 2) & ") IN " & """" & sDBDestination & """ "
                    sSQLSource = Mid(sSQLSource, 1, Len(sSQLSource) - 2) & " FROM " & "[" & sDbOrigine & "]." & sTable
                    sSQLInsert = sSQLInsert & sSQLSource

                    'Execution
                    objCmd.ActiveConnection = objCNOri
                    objCmd.CommandText = sSQLInsert
                    Call objCmd.Execute()
                End If
                If m_bIsStoped Then Exit For
            Next
            Cursor = Cursors.Default
            Call objCNOri.Close()
            ObjCatOri.ActiveConnection = Nothing
            ObjCatOri = Nothing
            objCNOri = Nothing
            CopyMsAccessData_ = True
        Catch ex As Exception
            CopyMsAccessData_ = False
            Throw ex
        End Try
    End Function

    Public Sub InitForm(ByVal iActionType As ActionType)
        Select Case iActionType
            Case ActionType.FirstPrg
                prgFirst.Visible = True
                lblFirst.Visible = True
                prgSecond.Visible = False
                lblSecond.Visible = False

            Case ActionType.SecondPrg
                prgFirst.Visible = False
                lblFirst.Visible = False
                prgSecond.Visible = True
                lblSecond.Visible = True

            Case ActionType.BothPrg
                prgFirst.Visible = True
                lblFirst.Visible = True
                prgSecond.Visible = True
                lblSecond.Visible = True

        End Select
    End Sub
    Public Sub ChangePrgStat(ByVal iPrg As ActionType, ByVal sMessage As String, ByVal iMaxValue As Integer, ByVal iProgressValue As Integer)
        Select Case iPrg
            Case ActionType.FirstPrg
                lblFirst.Text = sMessage
                prgFirst.Maximum = iMaxValue
                prgFirst.Value = iProgressValue
            Case ActionType.SecondPrg
                lblSecond.Text = sMessage
                prgSecond.Maximum = iMaxValue
                prgSecond.Value = iProgressValue

        End Select
    End Sub

#End Region

End Class
