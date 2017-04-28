Imports System.IO
Imports System.Net

Public Class Frm_Validation

#Region " D�claration des variables priv�es "
    Private sFilename As String = "csvTasks.csv"
    Private sFilePath As String = "C:\CNHIMTEMP\"
    Private sTacheRes As String = "backupT"
    Private sTacheMigr As String = "migrate"
    Private Migrate As String = sFilePath & "Migrate.Go"
    
#End Region

    Private Sub Frm_Validation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If File.Exists(Migrate) Then
            GroupControl1.Enabled = True
            RG.SelectedIndex = 0
        Else
            RG.SelectedIndex = 1
            GroupControl1.Enabled = True
        End If

    End Sub

    Private Sub btValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btValider.Click

        If RG.Text = "Non" Then
            If File.Exists(Migrate) Then
                File.Delete(Migrate)
                Process_Message("Validation annul�e!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        If RG.Text = "Oui" Then
            File.Create(Migrate)
            Process_Message("Validation r�ussie!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFermer.Click
        Me.Close()
    End Sub
End Class
