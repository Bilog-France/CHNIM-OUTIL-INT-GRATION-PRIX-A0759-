Public Class Frm_Dictionnaire
    Public _strTable As String = ""
    Public _Libelle As String
    Public _Code As Object = Nothing
    Public _Num As Object = Nothing
    Public _SSQL As String = ""
    Public _boolAfficheColNum As Boolean
    Public _SearchOnlyFirst As Boolean = False
    Public _Collection As New Collection
    Public dtSpecialite As DataTable
    Public Appelant As String
    Public critere As Boolean = False
    Private dv As New DataView
    Private dt As DataTable
    Private Press_Ok As Boolean = False

    Private Sub Frm_Dictionnaire_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.txtSearch.Select()
    End Sub

    Private Sub Frm_Dictionnaire_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Frm_Dictionnaire_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If CInt(e.KeyCode) = eKeyPressed.KeyValidate Or e.KeyCode = Keys.Enter Then
            If Not Timer.Enabled Then
                btOk_Click(btOk, Nothing)
            Else
                Press_Ok = True
            End If
        End If
    End Sub

    Private Sub Frm_Dictionnaire_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InitData()
        txtSearch_TextChanged(Nothing, Nothing)
    End Sub

    Private Sub InitData()

        If _SSQL.IndexOf(" val1") > 0 Then
            Me.colVal1.Visible = True
            Me.colVal1.VisibleIndex = 2
        End If
        If _SSQL.IndexOf(" val2") > 0 Then
            Me.colVal2.Visible = True
            Me.colVal2.VisibleIndex = 3
        End If
        If _SSQL.IndexOf(" val3") > 0 Then
            Me.colVal3.Visible = True
            Me.colVal3.VisibleIndex = 4
        End If
        If _SSQL.IndexOf(" val4") > 0 Then
            Me.colVal4.Visible = True
            Me.colVal4.VisibleIndex = 5
        End If

        If _boolAfficheColNum Then
            Me.colNum.Visible = True
        End If
        dt = FillTableDictionnaire(_SSQL)
        If dt IsNot Nothing Then
            dv = dt.DefaultView
            Me.gcPredictive.DataSource = dt
        End If
        '''''''''''''''''''''''''''''''''''''
        If (Not String.IsNullOrEmpty(Appelant)) Then
            If (Appelant.Equals("S")) Then
                dtSpecialite = New DataTable()
                dtSpecialite.Columns.Add("CodeSP", System.Type.GetType("System.String"))
                dtSpecialite.Columns.Add("Libelle", System.Type.GetType("System.String"))

                Dim d As DataRow
                For Each dr As DataRow In dt.Rows
                    d = dtSpecialite.NewRow()
                    d("CodeSP") = dr("Code").ToString()
                    d("Libelle") = dr("Libelle").ToString()
                    dtSpecialite.Rows.Add(d)
                Next
                If (Not critere) Then
                    Me.Close()
                End If

            End If

            If (Appelant.Equals("P")) Then
                dtSpecialite = dt
                If (Not critere) Then
                    Me.Close()
                End If
            End If
        End If

    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If Not Me.ActiveControl Is Me.gcPredictive Then
            Select Case e.KeyValue
                Case Keys.Down
                    Me.gvPredictive.MoveNext()
                Case Keys.Up
                    Me.gvPredictive.MovePrev()
                Case Keys.Home
                    Me.gvPredictive.MoveFirst()
                Case Keys.End
                    Me.gvPredictive.MoveLast()
            End Select
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Timer.Enabled = False
        Timer.Enabled = True
    End Sub

    Private Sub gvPredictive_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvPredictive.DoubleClick
        btOk_Click(btOk, Nothing)
    End Sub

    Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click
        If Me.gvPredictive.GetRowCellValue(Me.gvPredictive.FocusedRowHandle, Me.colDisable) <> 0 Then Exit Sub
        If RowSel(Me.gcPredictive) Then
            _Code = Me.gvPredictive.GetRowCellValue(Me.gvPredictive.FocusedRowHandle, Me.colCode)
            _Libelle = NNT(Me.gvPredictive.GetRowCellValue(Me.gvPredictive.FocusedRowHandle, Me.colLibelle))
            _Collection.Add(NNT(Me.gvPredictive.GetRowCellValue(Me.gvPredictive.FocusedRowHandle, Me.colVal1)))
            _Collection.Add(NNT(Me.gvPredictive.GetRowCellValue(Me.gvPredictive.FocusedRowHandle, Me.colVal2)))
            _Collection.Add(NNT(Me.gvPredictive.GetRowCellValue(Me.gvPredictive.FocusedRowHandle, Me.colVal3)))
            _Collection.Add(NNT(Me.gvPredictive.GetRowCellValue(Me.gvPredictive.FocusedRowHandle, Me.colVal4)))
            Me.Hide()
            Me.Close()
        Else
            Me.Hide()
            Me.Close()
        End If
    End Sub

    Private Sub txtSearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyUp
        If CInt(e.KeyCode) = eKeyPressed.KeyValidate Or e.KeyCode = Keys.Enter Then
            If Not Timer.Enabled Then
                btOk_Click(btOk, Nothing)
            Else
                Press_Ok = True
            End If
        End If
    End Sub

    Private Sub gcPredictive_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gcPredictive.KeyUp, gvPredictive.KeyUp
        If e.KeyData = Keys.Enter Then
            btOk_Click(btOk, Nothing)
        End If
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        LaunchFilter()
        If Press_Ok Then
            btOk_Click(Nothing, Nothing)
        End If
        Timer.Enabled = False
    End Sub

    Private Sub LaunchFilter()
        If dt Is Nothing Then Exit Sub
        Dim strFiltre As String = txtSearch.Text.Trim
        Dim aMots() As String = strFiltre.Split(" ")
        Dim inti As Integer
        Dim strSSQLCode As String = ""

        Dim dec As Decimal

        If txtSearch.Text.Trim <> "" Then

            strFiltre = ""
            If aMots.Length >= 1 Then

                Select Case LCase(dt.Columns(0).DataType.Name)
                    Case "int32", "byte"
                        'If IsNumeric(aMots(inti)) Then
                        If IsInt(aMots(inti)) Then
                            strSSQLCode = " or code =" & aMots(inti)
                        Else
                            strSSQLCode = ""
                        End If
                    Case Else
                        If Not _SearchOnlyFirst Then
                            strSSQLCode = " or code Like " & cn.SQLTextLike2(aMots(inti))
                        Else
                            strSSQLCode = " or code Like " & cn.SQLTextLike(aMots(inti))
                        End If
                End Select

                Select Case LCase(dt.Columns(1).DataType.Name)
                    Case "int32", "decimal"
                        'If IsNumeric(aMots(inti)) Then
                        If IsInt(aMots(inti)) Then
                            strFiltre &= "  (libelle = " & aMots(inti) & strSSQLCode & ")"
                        Else
                            If (Decimal.TryParse(aMots(inti), dec)) Then
                                strFiltre &= " (libelle =" & dec.ToString().Replace(",", ".") & strSSQLCode & ")"
                            End If
                        End If

                    Case Else

                        If Not _SearchOnlyFirst Then
                            strFiltre &= " (libelle like  " & cn.SQLTextLike2(aMots(inti)) & strSSQLCode & ")"
                        Else
                            strFiltre &= " (libelle like  " & cn.SQLTextLike(aMots(inti)) & strSSQLCode & ")"
                        End If

                End Select


            End If
            For inti = 1 To aMots.Length - 1

                Select Case LCase(dt.Columns(0).DataType.Name)
                    Case "int32", "byte"
                        'If IsNumeric(aMots(inti)) Then
                        If IsInt(aMots(inti)) Then
                            strSSQLCode = " or code =" & aMots(inti)
                        Else
                            strSSQLCode = ""
                        End If
                    Case Else
                        If Not _SearchOnlyFirst Then
                            strSSQLCode = " or code Like " & cn.SQLTextLike2(aMots(inti))
                        Else
                            strSSQLCode = " or code Like " & cn.SQLTextLike(aMots(inti))
                        End If
                End Select
                If Not _SearchOnlyFirst Then
                    strFiltre &= " and (libelle like  " & cn.SQLTextLike2(aMots(inti)) & strSSQLCode & ")"
                Else
                    strFiltre &= " and (libelle like  " & cn.SQLTextLike(aMots(inti)) & strSSQLCode & ")"
                End If
            Next
            dv.RowFilter = strFiltre
        Else
            dv.RowFilter = ""
        End If
    End Sub

    Private Sub Frm_Dictionnaire_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        colCode.VisibleIndex = 0
        colLibelle.VisibleIndex = 1
        If _SSQL.IndexOf(" val1") > 0 Then
            Me.colVal2.Visible = True
            Me.colVal2.VisibleIndex = 2
        End If
        If _SSQL.IndexOf(" val2") > 0 Then
            Me.colVal2.Visible = True
            Me.colVal2.VisibleIndex = 3
        End If
        If _SSQL.IndexOf(" val3") > 0 Then
            Me.colVal3.Visible = True
            Me.colVal3.VisibleIndex = 4
        End If
        If _SSQL.IndexOf(" val4") > 0 Then
            Me.colVal4.Visible = True
            Me.colVal4.VisibleIndex = 5
        End If
        'Ajouté pour le ticket 3161
        If _SSQL.IndexOf(" indice") > 0 Then
            If _SSQL.IndexOf(" num") > 0 Then
                Me.colNum.Visible = True
                Me.colNum.VisibleIndex = 2
            End If
        End If
        
    End Sub
    Function IsInt(Optional ByVal sLibelle As String = "") As Boolean
        IsInt = False
        If sLibelle = "" Then Exit Function
        For iCount As Integer = 0 To sLibelle.Length - 1
            If (sLibelle(iCount) <> "0" And sLibelle(iCount) <> "1" And sLibelle(iCount) <> "2" And sLibelle(iCount) <> "3" And sLibelle(iCount) <> "4" And sLibelle(iCount) <> "5" And sLibelle(iCount) <> "6" And sLibelle(iCount) <> "7" And sLibelle(iCount) <> "8" And sLibelle(iCount) <> "9") Then Exit Function
        Next
        IsInt = True
    End Function

    Private Sub Frm_Dictionnaire_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ClearMemory()
    End Sub
End Class
