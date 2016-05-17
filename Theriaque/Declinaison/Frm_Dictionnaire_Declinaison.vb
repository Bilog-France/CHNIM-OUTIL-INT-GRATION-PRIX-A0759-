Public Class Frm_Dictionnaire_Declinaison

    Public _strTable As String = ""
    Public _Libelle As String
    Public _Code As Object = Nothing
    Public _Num As Object = Nothing
    Public _SSQL As String = ""
    Public _boolAfficheColNum As Boolean
    Public _SearchOnlyFirst As Boolean = False
    Public ReadOnly _CollectionOut As New Collection
    Public ReadOnly _CollectionOutDelete As New Collection
    Public ReadOnly _CollectionOutADD As New Collection
    Public _CollectionIn As New Collection
    Public _Ok As Boolean = False

    Private dv As New DataView
    Private dt As DataTable


    Private Sub Frm_Dictionnaire_Declinaison_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.txtSearch.Select()
    End Sub

    Private Sub Frm_Dictionnaire_Declinaison_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Frm_Dictionnaire_Declinaison_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If CInt(e.KeyCode) = eKeyPressed.KeyValidate Or e.KeyCode = Keys.Enter Then
            btOk_Click(btOk, Nothing)
        End If
    End Sub

    Private Sub Frm_Dictionnaire_Declinaison_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InitData()
        txtSearch_TextChanged(txtSearch, Nothing)
    End Sub

    Private Sub InitData()
        If _boolAfficheColNum Then
            Me.colNum.Visible = True
        End If
        dt = FillTableDictionnaire(_SSQL)
        If dt IsNot Nothing Then
            dv = dt.DefaultView
            Me.gcPredictive.DataSource = dt
        End If
        labTitre.Text = _Libelle
        If _CollectionIn IsNot Nothing Then
            If _CollectionIn.Count >= 1 Then
                dv.RowFilter = " code in " & GetCodeFromCollection(_CollectionIn)
                For init As Integer = 0 To dv.Count - 1
                    dv(init)("chk") = 1
                    dv(init)("chkFixe") = 1
                Next
                dv.RowFilter = ""
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
        If dt Is Nothing Then Exit Sub
        Dim strFiltre As String = Replace(txtSearch.Text.Trim, ",", " ")
        If strFiltre Is Nothing Then
            dv.RowFilter = ""
            Exit Sub
        End If
        Dim aMots() As String = strFiltre.Split(" ")
        Dim inti As Integer
        Dim strSSQLCode As String = ""
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
                If Not _SearchOnlyFirst Then
                    strFiltre &= " (libelle like  " & cn.SQLTextLike2(aMots(inti)) & strSSQLCode & ")"
                Else
                    strFiltre &= " (libelle like  " & cn.SQLTextLike(aMots(inti)) & strSSQLCode & ")"
                End If
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

    'Private Sub gvPredictive_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvPredictive.DoubleClick
    '    btOk_Click(btOk, Nothing)
    'End Sub

    Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click
        dv.RowFilter = ""
        For intI As Integer = 0 To Me.gvPredictive.RowCount - 1
            If Me.gvPredictive.GetRowCellValue(intI, Me.colcheck) Then
                _CollectionOut.Add(Me.gvPredictive.GetRowCellValue(intI, Me.colCode))
            End If
            If Me.gvPredictive.GetRowCellValue(intI, Me.colcheck) And Not Me.gvPredictive.GetRowCellValue(intI, Me.colchkFixe) Then
                _CollectionOutADD.Add(Me.gvPredictive.GetRowCellValue(intI, Me.colCode))
            End If
            If Not Me.gvPredictive.GetRowCellValue(intI, Me.colcheck) And Me.gvPredictive.GetRowCellValue(intI, Me.colchkFixe) Then
                _CollectionOutDelete.Add(Me.gvPredictive.GetRowCellValue(intI, Me.colCode))
            End If
        Next
        _Ok = True
        Me.Hide()
        Me.Close()
    End Sub

    Private Sub txtSearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyUp
        If e.KeyCode = Keys.Enter Then
            btOk_Click(Nothing, Nothing)
        End If
    End Sub

   
    Private Sub gcPredictive_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gcPredictive.KeyUp, gvPredictive.KeyUp
        If e.KeyData = Keys.Enter Then
            btOk_Click(btOk, Nothing)
        End If
    End Sub

    Private Sub btAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAnnuler.Click
        _Ok = False
        Me.Hide()
        Me.Close()
    End Sub

    Private Sub btPasser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPasser.Click
        _Ok = True
        Me.Hide()
        Me.Close()
    End Sub

    Private Sub btTout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTout.Click
        colcheck.SortOrder = DevExpress.Data.ColumnSortOrder.Descending
        'For inti As Integer = Me.gvPredictive.RowCount - 1 To 0 Step -1
        For inti As Integer = 0 To Me.gvPredictive.RowCount - 1
            If gvPredictive.GetRowCellValue(inti, Me.colDisable) <> 1 Then
                gvPredictive.SetRowCellValue(inti, Me.colcheck, 1)
            End If
        Next
    End Sub

    Private Sub btNone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNone.Click
        colcheck.SortOrder = DevExpress.Data.ColumnSortOrder.Descending
        For inti As Integer = Me.gvPredictive.RowCount - 1 To 0 Step -1
            gvPredictive.SetRowCellValue(inti, Me.colcheck, 0)
        Next
    End Sub

    Private Sub rpCheck_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rpCheck.CheckStateChanged
        'Me.BindingContext(dt).EndCurrentEdit()
        Dim Iposition As Integer = gvPredictive.FocusedRowHandle
        Me.btOk.Focus()
        Me.gvPredictive.Focus()
        gvPredictive.FocusedRowHandle = Iposition
    End Sub
    Function IsInt(Optional ByVal sLibelle As String = "") As Boolean
        IsInt = False
        If sLibelle = "" Then Exit Function
        For iCount As Integer = 0 To sLibelle.Length - 1
            If (sLibelle(iCount) <> "0" And sLibelle(iCount) <> "1" And sLibelle(iCount) <> "2" And sLibelle(iCount) <> "3" And sLibelle(iCount) <> "4" And sLibelle(iCount) <> "5" And sLibelle(iCount) <> "6" And sLibelle(iCount) <> "7" And sLibelle(iCount) <> "8" And sLibelle(iCount) <> "9") Then Exit Function
        Next
        IsInt = True
    End Function
End Class
