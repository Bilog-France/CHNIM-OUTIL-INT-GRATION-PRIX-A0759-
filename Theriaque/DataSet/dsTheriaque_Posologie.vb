

Partial Public Class dsTheriaque_Posologie
    Partial Class IPO_INFOPOSODataTable

    End Class

    Partial Class IPODOSE_INFOPOSODataTable

        Private Sub IPODOSE_INFOPOSODataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.IPODOSE_SP_CIPUCDColumn.ColumnName) Then
                'Ajoutez le code utilisateur ici
            End If

        End Sub

        Private Sub IPODOSE_INFOPOSODataTable_IPODOSE_INFOPOSORowChanging(ByVal sender As System.Object, ByVal e As IPODOSE_INFOPOSORowChangeEvent) Handles Me.IPODOSE_INFOPOSORowChanging

        End Sub

    End Class

    Partial Class IPOJ_INFOPOSO_JOURNALIEREDataTable

    End Class

End Class
