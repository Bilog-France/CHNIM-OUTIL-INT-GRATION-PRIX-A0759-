Public Class Frm_Edit

    Private Sub Frm_Edit_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then
            Me.Close()
            Exit Sub
        End If
        If CInt(e.KeyCode) = eKeyPressed.KeyValidate Then
            Me.Close()
            Exit Sub
        End If
    End Sub

    Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click

        'LZA
        Me.Memo.Text = Me.Memo.Text.Replace("’", "'")
        Me.Close()

        'Dim res As String = Me.Memo.Text
        'Dim sCote As String = ""
        'For inti As Integer = 0 To Me.Memo.Text.Length - 1
        '    If Me.Memo.Text(inti) = "’" Then
        '        sCote = Replace(Me.Memo.Text(inti), "’", "'")
        '        res &= sCote
        '    Else
        '        res &= Me.Memo.Text(inti)
        '    End If
        'Next
        'Memo.Text = res
        
    End Sub

    Private Sub Frm_Edit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Load_On(Me)
        'Dim res As String = Me.Memo.Text
        Dim id As Integer
        Dim s As String = Me.Memo.Text

        'LZA
        Do While id <= s.Length - 1
            id = s.IndexOf(Chr(10), id + 1)
            If id < 0 Then Exit Do
            If s(id - 1) <> Chr(13) Then
                s = s.Substring(0, id) & Chr(13) & s.Substring(id, s.Length - id)
                'Else
                '   res &= Me.Memo.Text(id)
            End If
        Loop

        'For i As Integer = 0 To Me.Memo.Text.Length - 1
        '    If Me.Memo.Text(i) = Chr(10) Then
        '        If Me.Memo.Text(i - 1) <> Chr(13) Then
        '            res &= Chr(13) & Me.Memo.Text(i)
        '        Else
        '            res &= Me.Memo.Text(i)
        '        End If
        '    Else
        '        res &= Me.Memo.Text(i)
        '    End If
        'Next
        Memo.Text = s
        Load_Off(Me)
    End Sub

    Private Sub SpinEditFont_EditValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpinEditFont.EditValueChanged
        Try
            Memo.Font = New Font(Memo.Font.FontFamily, SpinEditFont.Text)
        Catch ex As Exception
        End Try
    End Sub
End Class
