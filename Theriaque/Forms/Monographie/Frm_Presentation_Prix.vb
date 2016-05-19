Public Class Frm_Presentation_Prix

    Public DsTheriaque_Nomenclature21 As New dsTheriaque_Nomenclature2
    Public _Code As String

    Private Sub GV1_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV1.InitNewRow
        Me.GV1.SetRowCellValue(e.RowHandle, colPRIPRE_PRE_CODE_FK_PK, _Code)
        GV1.SetFocusedRowCellValue(colPRIPRE_Valide, "True")
    End Sub

    Private Sub GV2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        Me.GV2.SetRowCellValue(e.RowHandle, colFORPRE_PRE_CODE_FK_PK, _Code)
        GV2.SetFocusedRowCellValue(colFORPRE_Valide, "False")


    End Sub

    Private Sub Frm_Presentation_Prix_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub Frm_Presentation_Prix_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Try
            Me.BindingContext(Me.DsTheriaque_Nomenclature21, FORPRE_FORFAIT_PRE).EndCurrentEdit()
            Me.BindingContext(Me.DsTheriaque_Nomenclature21, PRIPRE_PRIX_PRESENTATION).EndCurrentEdit()

        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub Frm_Presentation_Prix_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GC1.DataSource = DsTheriaque_Nomenclature21
        Me.GC2.DataSource = DsTheriaque_Nomenclature21
        Me.PriprE_TA.FillByCode(Me.DsTheriaque_Nomenclature21.PRIPRE_PRIX_PRESENTATION, _Code)
        Me.ForprE_TA.FillByCode(Me.DsTheriaque_Nomenclature21.FORPRE_FORFAIT_PRE, _Code)
    End Sub

    Private Sub GV1_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV1.ValidateRow

        If Me.GV1.GetRowCellValue(e.RowHandle, Me.colPRIPRE_PRE_CODE_FK_PK) IsNot DBNull.Value Then
            If Me.GV1.GetFocusedRowCellValue(colPRIPRE_Valide) IsNot DBNull.Value Then
                If Me.GV1.GetFocusedRowCellValue(colPRIPRE_Valide) = "True" Then
                    For iCount As Integer = 0 To GV1.RowCount - 1
                        If iCount <> GV1.FocusedRowHandle Then
                            GV1.SetRowCellValue(iCount, colPRIPRE_Valide, "False")
                        End If
                    Next
                End If
            End If
        End If
        
    End Sub

    Private Sub GV2_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV2.ValidateRow
        If Me.GV2.GetRowCellValue(e.RowHandle, Me.colFORPRE_PRE_CODE_FK_PK) IsNot DBNull.Value Then
            If Me.GV2.GetFocusedRowCellValue(colFORPRE_Valide) IsNot DBNull.Value Then
                If Me.GV2.GetFocusedRowCellValue(colFORPRE_Valide) = "True" Then
                    For iCount As Integer = 0 To GV2.RowCount - 1
                        If iCount <> GV2.FocusedRowHandle Then
                            GV2.SetRowCellValue(iCount, colFORPRE_Valide, "False")
                        End If
                    Next
                End If
            End If
        End If
        
    End Sub

    Private Sub GV1_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV1.InvalidRowException
        'MsgBox(e.ErrorText)
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.Ignore
        Try
            MsgBox("Vérifier votre saisie, les champs ne doivent pas être vides et la date ne doit pas être duppliquée")
        Catch ex As Exception
            MsgBox("Vérifier votre saisie, les champs ne doivent pas être vides et la date ne doit pas être duppliquée")
        End Try


    End Sub

    Private Sub GV1_InvalidValueException(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles GV1.InvalidValueException

    End Sub

    Private Sub GC1_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GC1.Validated

    End Sub

    Private Sub GV2_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV2.CellValueChanged

    End Sub
End Class
