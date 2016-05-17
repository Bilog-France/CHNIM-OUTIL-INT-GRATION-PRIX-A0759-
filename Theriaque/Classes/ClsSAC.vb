Public Class ClsSAC
    Shared ReadOnly Property GetLibelle(ByVal Code_SAC As Integer) As String
        Get
            Dim dt As DataTable = cn.MySelect("Select SAC_NOM From THERIAQUE.SAC_SUBACTIVE where SAC_CODE_SQ_PK =" & Code_SAC)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)(0)
            End If
        End Get
    End Property
End Class
