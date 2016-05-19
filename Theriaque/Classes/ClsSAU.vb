Public Class ClsSAU

    Shared ReadOnly Property GetLibelle(ByVal Code_SAU As Integer) As String
        Get
            Dim dt As DataTable = cn.MySelect("Select SAU_NOM From THERIAQUE.SAU_SUBAUXILIAIRE where SAU_CODE_SQ_PK =" & Code_SAU)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)(0)
            End If
        End Get
    End Property

End Class
