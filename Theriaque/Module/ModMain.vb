Imports System.Xml

Module ModMain

    Public FMain As Frm_Main
    Public fSplash As SplashScreen
    Friend strConnexion As String = ""
    Friend ConInfo As ConnexionInfo
    'Cette variable sera affect�e � true pendant le pr�remplissage des tables posologies
    Friend preremplissage As Boolean = False

    Sub main()
        'fSplash = New SplashScreen
        'fSplash.TopMost = True
        'fSplash.Show()

        FMain = New Frm_Main
        FMain.ShowDialog()
    End Sub

End Module
