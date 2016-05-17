Partial Class dsTheriaque_Nomenclature2


    Partial Class PREUCD_COMMENT_DOSEUCDDataTable

    End Class

    Partial Class PREDISP_PRE_DISPENSATIONDataTable

        Private Sub PREDISP_PRE_DISPENSATIONDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.PREDISP_CDF_UD_CODE_FKColumn.ColumnName) Then
                'Ajoutez le code utilisateur ici
            End If

        End Sub

    End Class

    Partial Class PREGREF_PRE_GROUPE_REFDataTable

        Private Sub PREGREF_PRE_GROUPE_REFDataTable_PREGREF_PRE_GROUPE_REFRowChanging(ByVal sender As System.Object, ByVal e As PREGREF_PRE_GROUPE_REFRowChangeEvent) Handles Me.PREGREF_PRE_GROUPE_REFRowChanging

        End Sub

        Private Sub PREGREF_PRE_GROUPE_REFDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.PREGREF_DATESORTIEColumn.ColumnName) Then
                'Ajoutez le code utilisateur ici
            End If

        End Sub

    End Class

    Partial Class SAC_SUBACTIVEDataTable

        Private Sub SAC_SUBACTIVEDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.SAC_TYPE_REFColumn.ColumnName) Then
                'Ajoutez le code utilisateur ici
            End If

        End Sub

    End Class

    Partial Class FORPRE_FORFAIT_PREDataTable

        Private Sub FORPRE_FORFAIT_PREDataTable_FORPRE_FORFAIT_PRERowChanging(ByVal sender As System.Object, ByVal e As FORPRE_FORFAIT_PRERowChangeEvent) Handles Me.FORPRE_FORFAIT_PRERowChanging

        End Sub

    End Class

End Class
