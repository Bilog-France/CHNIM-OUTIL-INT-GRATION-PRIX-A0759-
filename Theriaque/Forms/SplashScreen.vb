Imports System.Xml

Public NotInheritable Class SplashScreen

    'TODO : ce formulaire peut facilement être configuré comme écran de démarrage de l'application en accédant à l'onglet "Application"
    '  du Concepteur de projets ("Propriétés" sous le menu "Projet").


    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Configurez le texte de la boîte de dialogue au moment de l'exécution en fonction des informations d'assembly de l'application.  
        Try
            'TODO : personnalisez les informations d'assembly de l'application dans le volet "Application" de la 
            '  boîte de dialogue Propriétés du projet (sous le menu "Projet").

            'Titre de l'application
            If My.Application.Info.Title <> "" Then
                ApplicationTitle.Text = My.Application.Info.Title
            Else
                'Si le titre de l'application est absent, utilisez le nom de l'application, sans l'extension
                ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
            End If



            'Mettez en forme les informations de version à l'aide du texte défini dans le contrôle Version au moment du design en tant que
            '  chaîne de mise en forme. Ceci permet une localisation efficace si besoin est.
            '  Les informations de génération et de révision peuvent être incluses en utilisant le code suivant et en remplaçant le 
            '  texte du contrôle de version par "Version {0}.{1:00}.{2}.{3}" ou un équivalent. Voir
            '  String.Format() dans l'aide pour plus d'informations.
            '
            '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

            'Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor )
            Version.Text = Version.Text & " [Release] " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor

            'Informations de copyright
            Copyright.Text = My.Application.Info.Copyright
            'DevExpress.Skins.SkinManager.DisableFormSkins()
        Catch ex As Exception
            Process_Message(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub Version_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Version.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub DetailsLayoutPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DetailsLayoutPanel.Paint

    End Sub
End Class
