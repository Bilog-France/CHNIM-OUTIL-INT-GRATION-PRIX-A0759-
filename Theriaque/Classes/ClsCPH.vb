Public Class ClsCPH
    Shared ReadOnly Property GetLibelle(ByVal Code_CPH As String) As String
        Get
            Dim dt As DataTable = cn.MySelect("Select CPH_NOM From THERIAQUE.CPH_CLASSEPHARMTHER where CPH_CODE_PK =" & cn.SQLText(Code_CPH))
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)(0)
            End If
        End Get
    End Property
End Class
