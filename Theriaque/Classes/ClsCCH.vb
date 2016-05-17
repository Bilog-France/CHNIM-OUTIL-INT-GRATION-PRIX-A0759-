Public Class ClsCCH
    Shared ReadOnly Property GetLibelle(ByVal Code_CCH As String) As String
        Get
            Dim dt As DataTable = cn.MySelect("Select CCH_NOM From THERIAQUE.CCH_CLASSECHIMIQUE where CCH_CODE_PK =" & cn.SQLText(Code_CCH))
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)(0)
            End If
        End Get
    End Property
End Class
