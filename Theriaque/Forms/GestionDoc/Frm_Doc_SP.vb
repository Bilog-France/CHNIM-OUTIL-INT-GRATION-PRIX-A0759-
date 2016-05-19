Public Class Frm_Doc_SP

    Public doc As DocumentService.DocumentProvider
    Dim hi As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo
   
    Private Sub Frm_Doc_SP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        InitData()

    End Sub

    Private Sub InitData()

        '2709LZA 
        'If (gvSpecPres.RowCount > 0) Then

        Me.gcSpecPres.DataSource = doc.GetSpecPresLiees(doc.DO_ID)
        'End If


    End Sub

    Private Sub gvSpecPres_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvSpecPres.DoubleClick

        Dim type As String
        Dim code As String
        If hi.InRow Then
            code = Me.gvSpecPres.GetFocusedRowCellValue("code").ToString()
            type = Me.gvSpecPres.GetFocusedRowCellValue("Type").ToString()
            If (type.Equals("UCD")) Then
                Dim f As New Frm_Specialite
                f.AfficherFiche(code)
                f.ShowDialog()
            Else
                Dim f As New Frm_Presentation
                f.AfficherFiche(code)
                f.ShowDialog()
            End If
        End If

    End Sub

   

    Private Sub gvSpecPres_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvSpecPres.MouseMove
        hi = gvSpecPres.CalcHitInfo(New Point(e.X, e.Y)) '
    End Sub

End Class