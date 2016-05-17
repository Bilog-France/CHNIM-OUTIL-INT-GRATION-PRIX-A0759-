Public Module ModOutil
    Private Declare Auto Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal procHandle As IntPtr, ByVal min As Int32, ByVal max As Int32) As Boolean
    Public Function RowSel(ByVal GC As DevExpress.XtraGrid.GridControl)
        Dim GridView As DevExpress.XtraGrid.Views.Grid.GridView
        GridView = GC.MainView
        If GridView.FocusedRowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
            Return True
            Exit Function
        End If
        Return False
    End Function

    ''' <summary>
    ''' Not Null Text
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    ''' <remarks>Eviter les erreures de Cast</remarks>
    Public Function NNT(ByVal value As Object) As String
        If value Is DBNull.Value Then
            Return ""
        Else
            Return CStr(value)
        End If
    End Function

    ''' <summary>
    ''' Not Null Text
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    ''' <remarks>Eviter les erreures de Cast</remarks>
    Public Function NNS(ByVal value As Object) As String
        If value Is DBNull.Value Then
            Return ""
        Else
            Return CStr(value)
        End If
    End Function

    Public Function NNI(ByVal value As Object) As String
        If value Is DBNull.Value Then
            Return "NULL"
        Else
            If value Is Nothing Then
                Return "NULL"
            Else
                Return CStr(value)
            End If
        End If
    End Function

    'No Space
    Public Function NS(ByVal value As Object) As String
        If value Is DBNull.Value Then
            Return "NULL"
        Else
            If value Is Nothing Or CStr(value) = "" Then
                Return "NULL"
            Else
                Return Replace(value, " ", "")
            End If
        End If
    End Function

    Public Sub ClearMemory()
        Try
            Dim P As Process
            P = Process.GetCurrentProcess()
            SetProcessWorkingSetSize(P.Handle, -1, -1)
        Catch ex As Exception
        End Try
    End Sub

End Module
