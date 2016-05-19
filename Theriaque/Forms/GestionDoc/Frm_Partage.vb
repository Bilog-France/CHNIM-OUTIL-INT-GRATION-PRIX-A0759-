Public Class Frm_Partage

    Public dtResultat As DataTable
    Public Type As String
    Public docId As Integer
    Private doc As DocumentService.DocumentProvider

    Private Sub Frm_Partage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        doc = New DocumentService.DocumentProvider(strConnexion)
        If Not dtResultat.Columns.Contains("Check") Then
            dtResultat.Columns.Add("Check", System.Type.GetType("System.Boolean"))
        End If
        Me.gcPartage.DataSource = dtResultat

    End Sub

    Private Sub btnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFermer.Click

        Me.Close()

    End Sub

    Private Sub btnPartage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPartage.Click

        Dim dr As DataRowView
        Dim code As String

        For i As Integer = 0 To gvPartage.RowCount - 1
            dr = gvPartage.GetRow(i)
            If (Not String.IsNullOrEmpty(dr.Row.ItemArray(2).ToString())) Then
                If (Boolean.Parse(dr.Row.ItemArray(2).ToString())) Then
                    If (Type.Equals("UCD")) Then
                        doc.AddDocumentToAssociation(docId, Integer.Parse(dr.Row.ItemArray(0).ToString()), DocumentService.DocumentProvider.TypeDoc.Specialite)
                    Else
                        doc.AddDocumentToAssociation(docId, dr.Row.ItemArray(0).ToString(), DocumentService.DocumentProvider.TypeDoc.Presentation)
                    End If
                End If
            End If
        Next
        MsgBox("Partage de document terminé")

    End Sub


    
End Class