Imports System.Windows.Forms
Imports System.Xml
Imports System.IO
Imports System.Configuration
Imports Theriaque.ModSQLData


Public Class Frm_Main

    Private XMLStruct As New XmlDocument

    Public Sub Load_XML_Config()
        '----------------------------------------
        '----------------------------------------
        Dim root As XmlNode
        Dim strServer, strDatabse As String

        Dim sCon As String
        sCon = Global.Theriaque.My.Settings.ConnectionString
        cn = New SQLcn()
        cn.sConnexion = sCon
        'cn.SQlCon = New SqlClient.SqlConnection(sCon)
        'cn.Open()
        'ConInfo.Server = cn.SQlCon.DataSource ' strServer
        'ConInfo.DateBase = cn.SQlCon.Database ' strDatabse

        'If Theriaque.My.Settings.ws = False Then
        '    SaveToolStripMenuItem.Visible = False
        'End If

        'XMLStruct.Load("app.config")
        'root = XMLStruct.DocumentElement
        'strServer = root.Item("connexion").Item("server").InnerText
        'strDatabse = root.Item("connexion").Item("database").InnerText
        'ConInfo.Server = strServer
        'ConInfo.DateBase = strDatabse
        
        'If root.Item("connexion").Item("ws") Is Nothing Then
        'SaveToolStripMenuItem.Visible = False
        'End If
        '----------------------------------------
        '----------------------------------------
    End Sub

    Private Sub Frm_Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ToolStripStatusLabel.Text = strDeconnecte
        Load_XML_Config()
       
    End Sub

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewWindowToolStripMenuItem.Click
        ConnectToolStripButton_Click(Nothing, Nothing)
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click
        'Dim OpenFileDialog As New OpenFileDialog
        'OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        'OpenFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*"
        'If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
        '    Dim FileName As String = OpenFileDialog.FileName
        '    ' TODO : ajoutez le code ici pour ouvrir le fichier.
        'End If
        Dim f As New Frm_Config
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO : ajoutez le code ici pour enregistrer le contenu actuel du formulaire dans un fichier.
        End If
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Utilisez My.Computer.Clipboard pour insérer les images ou le texte sélectionné dans le Presse-papiers
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Utilisez My.Computer.Clipboard pour insérer les images ou le texte sélectionné dans le Presse-papiers
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Utilisez My.Computer.Clipboard.GetText() ou My.Computer.Clipboard.GetData pour extraire les informations du Presse-papiers.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Fermez tous les formulaires enfants du parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer = 0

    Private Sub ATCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click

    End Sub

    Private Sub PharmacoThérapeutiquesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PharmacoThérapeutiquesToolStripMenuItem1.Click
        Dim f As New Frm_PharmacoTherapeutiques
        f.MdiParent = Me
        'f.StartPosition = FormStartPosition.CenterParent
        f.Location = New Point((Me.Width - f.Width) / 2, (Me.Height - f.Height) / 2)
        f.Show()
    End Sub

    Private Sub ChimiqueToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChimiqueToolStripMenuItem1.Click
        Dim f As New Frm_ClasseChimique
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub GestionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionToolStripMenuItem1.Click
        Dim f As New Frm_Gestion
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub CIM10ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CIM10ToolStripMenuItem1.Click
        Dim f As New Frm_CIM10
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub EphrmaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EphrmaToolStripMenuItem1.Click
        Dim f As New Frm_ClasseEphmra
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ATCToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ATCToolStripMenuItem1.Click
        Dim f As New Frm_ATC
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub CispToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CispToolStripMenuItem1.Click
        Dim f As New FRM_CISP
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub CaractéristiqueComplémentaireDuConditionnementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaractéristiqueComplémentaireDuConditionnementToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub ConditionDeConservationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConditionDeConservationToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub AméliorationServiceMédicalRenduToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AméliorationServiceMédicalRenduToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub ComplémentDeFormePharmaceutiqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComplémentDeFormePharmaceutiqueToolStripMenuItem.Click
        Dim f As New Frm_CDF_IVO
        f._Code_Acces = "A"
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub ContenantDuConditionnementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContenantDuConditionnementToolStripMenuItem.Click
        Dim f As New Frm_CDF_IVO
        f._Code_Acces = "B"
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub FormePharmaceutiqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormePharmaceutiqueToolStripMenuItem.Click
        Dim f As New Frm_CDF_IVO
        f._Code_Acces = "C"
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub LaboratoireToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaboratoireToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub ListeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListeToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub NatureSubstanceAuxiliaireToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NatureSubstanceAuxiliaireToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub OrigineDuNomDeLaSubstanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrigineDuNomDeLaSubstanceToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub PrésentationUnitaireToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrésentationUnitaireToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub RéservéHôpitauxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RéservéHôpitauxToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub StatutDeLaPrésentationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatutDeLaPrésentationToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub StatutDuLaboratoireToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatutDuLaboratoireToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub TauxDeRemboursementSSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TauxDeRemboursementSSToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub UnitéDeDosageSubstanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitéDeDosageSubstanceToolStripMenuItem.Click
        Dim f As New Frm_CDF_Contenance
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub UnitéDeContenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitéDeContenanceToolStripMenuItem.Click
        Dim f As New Frm_CDF_Contenance
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub GaléniqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GaléniqueToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub TeneurToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeneurToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub DocumentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocumentToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub ServiceMédicalRenduToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiceMédicalRenduToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub NatureDeVecteurToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NatureDeVecteurToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub CommentaireDispensationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommentaireDispensationToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub NatureDeDoseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NatureDeDoseToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub NatureToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NatureToolStripMenuItem1.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub SensToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SensToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub ValidationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValidationToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub VecteurToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VecteurToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub DuréeDélaiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DuréeDélaiToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub LumièreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LumièreToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub TempératureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TempératureToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub SolutionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SolutionToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub VoieDadministrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoieDadministrationToolStripMenuItem.Click
        Dim f As New Frm_CDF_IVO
        f._Code_Acces = "D"
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub UnitéDePriseParContenantToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitéDePriseParContenantToolStripMenuItem.Click
        Dim f As New Frm_CDF_TEQ
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub MatériauDuConditionnementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MatériauDuConditionnementToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub InfoComplémentaireSurFormePharmaceutiqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoComplémentaireSurFormePharmaceutiqueToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub TypeTexteCritèreDeChoixToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TypeTexteCritèreDeChoixToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub CommentaireDoseTotaleUCDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommentaireDoseTotaleUCDToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub PhArmacocinétiqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhArmacocinétiqueToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub SécuritéPrécliniqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SécuritéPrécliniqueToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub NiveauToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NiveauToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub TypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TypeToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub DonnéesAnthropométriquesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DonnéesAnthropométriquesToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub CommentairesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommentairesToolStripMenuItem1.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub TerrainToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TerrainToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub ReconstaDministToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReconstaDministToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub InTeractionRcpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InTeractionRcpToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub ConduiteÀTenirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConduiteÀTenirToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub CirconstancesFavorisantesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CirconstancesFavorisantesToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub PériodeCritiqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PériodeCritiqueToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub RisquesRecommandationsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RisquesRecommandationsToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub CommentairesToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommentairesToolStripMenuItem3.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub CommentaireClasseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommentaireClasseToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub UnitéDeTempsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitéDeTempsToolStripMenuItem.Click
        Dim f As New Frm_CDF_TEQ1
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()

    End Sub

    Private Sub ÉtiOlogieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÉtiOlogieToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub ObservationsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObservationsToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub FréquenceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FréquenceToolStripMenuItem.Click
        Dim f As New Frm_CDF_TEQ
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()

    End Sub

    Private Sub CommentairesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommentairesToolStripMenuItem.Click
        Dim f As New FRM_CDF_CIM10
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub NaturePrincipaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NaturePrincipaleToolStripMenuItem.Click
        Dim f As New FRM_CDF_CIM10
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub NaturecodeHiérarchiséToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NaturecodeHiérarchiséToolStripMenuItem.Click
        Dim f As New Frm_CDF_CIM10_Orphanet
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub UnitéDePriseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitéDePriseToolStripMenuItem.Click
        Dim f As New Frm_CDF_PP
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub FamilleDeTerrainToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FamilleDeTerrainToolStripMenuItem.Click
        Dim f As New Frm_CDF_CIM10_CISP
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub CommentairesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommentairesToolStripMenuItem2.Click
        Dim f As New Frm_CDF_CIM10_CISP
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub NatureCliniqueEtParacliniqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NatureCliniqueEtParacliniqueToolStripMenuItem.Click
        Dim f As New Frm_CDF_CIM10_Medra
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub TypeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TypeToolStripMenuItem1.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub TerrainPèreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TerrainPèreToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub RuBriqueDeLaCodificationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RuBriqueDeLaCodificationToolStripMenuItem.Click
        Dim f As New Frm_Rubrique_Codification
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub SpécialitéToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpécialitéToolStripMenuItem.Click
        Dim f As New Frm_Specialite
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MédicamentVirtuelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MédicamentVirtuelToolStripMenuItem.Click
        Dim f As New Frm_MedVirtuelle
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub PrésentationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrésentationToolStripMenuItem.Click, ToolStripButton2.Click
        Dim f As New Frm_Presentation
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub PèreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PèreToolStripMenuItem.Click
        Dim f As New Frm_SubstanceActivPere
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub SécuritéPrécliniqueToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SécuritéPrécliniqueToolStripMenuItem1.Click
        Dim f As New Frm_Securite_Preclinique
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub FicheToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FicheToolStripMenuItem.Click
        Dim f As New Frm_Interactions_Fiche
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub GénériqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GénériqueToolStripMenuItem.Click
        Dim f As New Frm_Generique
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub FilsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilsToolStripMenuItem.Click
        Dim f As New Frm_SubstanceActivFils
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub FicheToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FicheToolStripMenuItem1.Click
        Dim f As New Frm_Incompatibilites_Fiche
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub EtiologieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EtiologieToolStripMenuItem.Click
        Dim f As New Frm_Etiologie
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub PharmacocinétiqueToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PharmacocinétiqueToolStripMenuItem1.Click
        Dim f As New Frm_Pharmacocinetique
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub InteractionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InteractionToolStripMenuItem.Click
        Dim f As New Frm_InteractionsRCP
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ConducteurToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConducteurToolStripMenuItem.Click
        Dim f As New Frm_Conducteur
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub CommissionDeLaTransparenceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommissionDeLaTransparenceToolStripMenuItem.Click
        Dim f As New Frm_Commission_Transparence
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub CritèresDeChoixToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CritèresDeChoixToolStripMenuItem.Click
        Dim f As New Frm_Criteres_Choix
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub FicheDeTransparenceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FicheDeTransparenceToolStripMenuItem.Click
        Dim f As New Frm_Fiche_Transparence
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub FicheDinformationThérapeutiqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FicheDinformationThérapeutiqueToolStripMenuItem.Click
        Dim f As New Frm_Fiche_Infotherapeutique
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub RMOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RMOToolStripMenuItem.Click
        Dim f As New Frm_RMO
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub EffetsIndésirablesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EffetsIndésirablesToolStripMenuItem.Click
        Dim f As New Frm_Effets_Indiserables
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub FicheTexteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FicheTexteToolStripMenuItem.Click
        Dim f As New Frm_Cipemg_Texte
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ReconstAdministToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReconstAdministToolStripMenuItem1.Click
        Dim f As New Frm_Reconst_Administ
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub FilsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilsToolStripMenuItem1.Click
        Dim f As New Frm_ExcipientFils
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub PèreToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PèreToolStripMenuItem1.Click
        Dim f As New Frm_ExcipientPere
        f.MdiParent = Me
        f.Show()
    End Sub

    'Private Sub PosologieToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PosologieToolStripMenuItem1.Click
    '    Dim f As New Frm_Posologie
    '    f.MdiParent = Me
    '    f.Show()
    'End Sub

    Private Sub FilsToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilsToolStripMenuItem2.Click
        Dim f As New Frm_ProduitFils
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub PèreToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PèreToolStripMenuItem2.Click
        Dim f As New Frm_ProduitPere
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub IndicationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndicationToolStripMenuItem.Click
        Dim f As New Frm_Indication
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub GrossesseAllaitementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrossesseAllaitementToolStripMenuItem.Click
        Dim f As New Frm_Grossesse_Allaitement
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim f As New SplashScreen
        f.ControlBox = True
        f.ShowDialog()
    End Sub

    Private Sub FicheCodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FicheCodeToolStripMenuItem.Click
        Dim f As New Frm_Cipemg_Code
        f.MdiParent = Me
        f.Show()

    End Sub

    Private Sub RéférencesOfficiellesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RéférencesOfficiellesToolStripMenuItem.Click
        Dim f As New Frm_References_offc
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub AttributionAutomatiqueToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttributionAutomatiqueToolStripMenuItem2.Click
        Dim f As New Frm_Attrb_Auto
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub PharmacoThérapeutiquesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PharmacoThérapeutiquesToolStripMenuItem.Click
        Dim f As New Frm_Attrb_Auto_Anlys_Ordo_Inter
        f.MdiParent = Me
        f._Type_AttAuto = AttAuto_AnalysOrdo.CPH
        f.Show()
    End Sub

    Private Sub ChimiqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChimiqueToolStripMenuItem.Click
        Dim f As New Frm_Attrb_Auto_Anlys_Ordo_Inter
        f.MdiParent = Me
        f._Type_AttAuto = AttAuto_AnalysOrdo.CCH
        f.Show()
    End Sub

    Private Sub SpécialitéToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpécialitéToolStripMenuItem1.Click
        Dim f As New Frm_Attrb_Auto_Anlys_Ordo_Inter
        f.MdiParent = Me
        f._Type_AttAuto = AttAuto_AnalysOrdo.SP
        f.Show()
    End Sub

    Private Sub SubstanceActiveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubstanceActiveToolStripMenuItem.Click
        Dim f As New Frm_Attrb_Auto_Anlys_Ordo_Inter
        f.MdiParent = Me
        f._Type_AttAuto = AttAuto_AnalysOrdo.SUB_AC
        f.Show()
    End Sub

    Private Sub ExcipientToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcipientToolStripMenuItem1.Click
        Dim f As New Frm_Attrb_Auto_Anlys_Ordo_Inter
        f.MdiParent = Me
        f._Type_AttAuto = AttAuto_AnalysOrdo.SUB_AUX
        f.Show()
    End Sub

    Private Sub SpécialitéToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpécialitéToolStripMenuItem2.Click
        Dim f As New Frm_Attrb_Auto_Anlys_Ordo_Incomp
        f.MdiParent = Me
        f._Type_AttAuto = AttAuto_AnalysOrdo.SP
        f.Show()
    End Sub

    Private Sub SubstanceActiveToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubstanceActiveToolStripMenuItem1.Click
        Dim f As New Frm_Attrb_Auto_Anlys_Ordo_Incomp
        f.MdiParent = Me
        f._Type_AttAuto = AttAuto_AnalysOrdo.SUB_AC
        f.Show()
    End Sub

    Private Sub ExcipientToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcipientToolStripMenuItem2.Click
        Dim f As New Frm_Attrb_Auto_Anlys_Ordo_Incomp
        f.MdiParent = Me
        f._Type_AttAuto = AttAuto_AnalysOrdo.SUB_AUX
        f.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
    End Sub

    Private Sub NouveauToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NouveauToolStripButton.Click
        Dim f As New Frm_Specialite
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ConnectToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectToolStripButton.Click
        'Load_XML_Config()
        Connect()
    End Sub

    Private Function Connect() As Boolean
        Try

            'Dim config As Configuration
            'Dim setting As ConnectionStringSettings


            'config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            If cn.SQlCon.State = ConnectionState.Open Then
                '2do
                'If My.Application.OpenForms.Count > 1 Then
                '    Process_Message(strFermerFiche, MessageBoxButtons.OK, MessageBoxIcon.Information)
                '    Exit Function
                'End If
                cn.SQlCon.Close()
                No_Connected()
                strConnexion = ""
                Connecte_DataSet(strConnexion)
                Exit Function
            Else
                'Dim f As New Frm_password
                '2809 LZA
                'If XMLStruct.ChildNodes.Count > 0 Then
                Frm_password.txtUser.Text = cn.CnInfo.User ' XMLStruct.ChildNodes(0).ChildNodes(0).ChildNodes(2).InnerText
                Frm_password.ShowDialog()
                If Frm_password._Ok = False Then
                    Exit Function
                Else
                    If Frm_password._SaveUser Then
                        cn.SaveConnectionSetting()
                        'Try
                        '    ConInfo = cn.CnInfo
                        '    strConnexion = ""
                        '    strConnexion &= "Data Source= "
                        '    strConnexion &= ConInfo.Server & " ; "
                        '    strConnexion &= "Initial Catalog= "
                        '    strConnexion &= ConInfo.DateBase & " ; "
                        '    strConnexion &= "Persist Security Info=true;User ID= "
                        '    strConnexion &= ConInfo.User & " ; "
                        '    strConnexion &= "Password="
                        '    strConnexion &= ConInfo.Password & " ; "

                        '    setting = ConfigurationManager.ConnectionStrings("Theriaque.MySettings.ConnectionString")
                        '    If Not setting Is Nothing Then

                        '        config.ConnectionStrings.ConnectionStrings.Remove("Theriaque.MySettings.ConnectionString")

                        '        config.Save(System.Configuration.ConfigurationSaveMode.Modified)
                        '        ConfigurationManager.RefreshSection("connectionStrings")

                        '    End If

                        '    setting = New ConnectionStringSettings()
                        '    setting.Name = "Theriaque.MySettings.ConnectionString"
                        '    setting.ConnectionString = strConnexion

                        '    config.ConnectionStrings.ConnectionStrings.Add(setting)
                        '    config.Save(System.Configuration.ConfigurationSaveMode.Modified)
                        '    ConfigurationManager.RefreshSection("connectionStrings")

                        'Catch ex As Exception
                        '    MsgBox(ex.Message)
                        'End Try


                        '0210  LZA
                        '                       XMLStruct.ChildNodes(0).ChildNodes(0).ChildNodes(2).InnerText = Frm_password.txtUser.Text
                        '                      XMLStruct.Save("app.config")
                    End If
                End If
                'End If
            End If
            ConInfo = cn.CnInfo
            strConnexion = ""
            strConnexion &= "Data Source= "
            strConnexion &= ConInfo.Server & " ; "
            strConnexion &= "Initial Catalog= "
            strConnexion &= ConInfo.DateBase & " ; "
            strConnexion &= "Persist Security Info=true;User ID= "
            strConnexion &= ConInfo.User & " ; "
            strConnexion &= "Password="
            strConnexion &= ConInfo.Password & " ; "

            Connecte_DataSet(strConnexion)

            cn.sConnexion = strConnexion
            cn.SQlCon.ConnectionString = strConnexion
            cn.IDConnection = 1
            cn.Open()
            If cn.SQlCon.State = ConnectionState.Open Then
                'If cn.SQlCon.State = ConnectionState.Open Then
                Ok_Connected()
            Else
                No_Connected()
            End If
            Theriaque.My.Settings.Item("ConnectionString") = strConnexion
            'Else
            'No_Connected()
            'End If
        Catch ex As Exception
            Process_Message(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
            No_Connected()
        End Try
    End Function

    Private Sub Ok_Connected()
        ToolStripStatusLabel.Text = strConnecte
        ToolStripButtonGreen.Visible = True
        ToolStripButtonRed.Visible = False
        ToolStripStatusLabelServer.Text = cn.SQlCon.DataSource
        ToolStripStatusLabelDataBase.Text = cn.SQlCon.Database
        ToolStripStatusLabel.ForeColor = Color.Black
        hideToolTip()
        ShowToolTip("Connexion établite au serveur:            " & vbLf & ConInfo.Server)
        If ConInfo.Server = "91.121.210.105,8008" Then
            ToolStripButtonWarning.Visible = True
            ToolStripButtonTest.Visible = False
        Else
            ToolStripButtonWarning.Visible = False
            ToolStripButtonTest.Visible = True
        End If
        OpenToolStripMenuItem.Enabled = False
        NewToolStripMenuItem.Text = "&Déconnexion"
    End Sub

    Private Sub No_Connected()
        ToolStripStatusLabel.Text = strDeconnecte
        ToolStripButtonGreen.Visible = False
        ToolStripButtonRed.Visible = True
        ToolStripStatusLabelServer.Text = cn.SQlCon.DataSource
        ToolStripStatusLabelDataBase.Text = cn.SQlCon.Database
        ToolStripStatusLabel.ForeColor = Color.Maroon
        hideToolTip()
        ShowToolTip("Vous êtes déconnecté", , True)
        ToolStripButtonWarning.Visible = False
        OpenToolStripMenuItem.Enabled = True
        NewToolStripMenuItem.Text = "&Connexion"
    End Sub

    Private Sub Connecte_DataSet(ByVal strConnexion As String)
        'My.MySettings.TheriaqueConnectionString = strConnexion
        'My.MySettings.THERIAQUE2ConnectionString = strConnexion
        'My.MySettings.THERIAQUE2ConnectionString1 = strConnexion
        'My.MySettings.THERIAQUE2ConnectionString2 = strConnexion
        'My.MySettings.THERIAQUE2ConnectionString3 = strConnexion
        'My.MySettings.THERIAQUE2ConnectionString4 = strConnexion
        'My.MySettings.THERIAQUE2ConnectionString5 = strConnexion
        'My.MySettings.THERIAQUE2ConnectionString6 = strConnexion
        'My.MySettings.THERIAQUE2ConnectionString7 = strConnexion
        'My.MySettings.THERIAQUE2ConnectionString8 = strConnexion
        'My.MySettings.THERIAQUE2ConnectionString9 = strConnexion
        'My.MySettings.THERIAQUE2ConnectionString10 = strConnexion
        'My.MySettings.THERIAQUE2ConnectionString11 = strConnexion
        'My.MySettings.THERIAQUEConnectionString1 = strConnexion
        'My.MySettings.THERIAQUEConnectionString3 = strConnexion
        'My.MySettings.THERIAQUEConnectionString4 = strConnexion

        'My.MySettings.ConnectionString1 = strConnexion
        'My.MySettings.ConnectionString2 = strConnexion
        'My.MySettings.ConnectionString3 = strConnexion
        'My.MySettings.ConnectionString4 = strConnexion
        'My.MySettings.ConnectionString5 = strConnexion
        'My.MySettings.ConnectionString6 = strConnexion
        'My.MySettings.ConnectionString7 = strConnexion
        'My.MySettings.ConnectionString8 = strConnexion

    End Sub

    Private Sub Frm_Main_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'fSplash.Close()
        Connect()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click
        'ShellExecute(0, "open", "http:\\Bilog", "", "", SW_SHOWNORMAL)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        'Dim f As New Frm_Validation
        Frm_Validation.MdiParent = Me
        Frm_Validation.Show()
    End Sub

    Private Sub RechercheGlobaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechercheGlobaleToolStripMenuItem.Click
        Dim f As New Frm_RechercheGlobale
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub GrosseRequêteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrosseRequêteToolStripMenuItem.Click
        Dim f As New Frm_GrosseRequete
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub FichierInteropérableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FichierInteropérableToolStripMenuItem.Click
        Dim f As New Frm_Interoperable
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ParamétrageDesUrlsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParamétrageDesUrlsToolStripMenuItem.Click
        Dim f As New Frm_URL
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ImportParSelectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportParSelectionToolStripMenuItem.Click

        Dim f As New Frm_Import_Selection
        f.ShowDialog()

    End Sub

    Private Sub ImportDirectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportDirectToolStripMenuItem.Click
        Dim f As New Frm_ImportDirect
        f.ShowDialog()
    End Sub

    Private Sub GestionDesDocumentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDesDocumentsToolStripMenuItem.Click

        Dim f As New Frm_GestionDocuments
        f.MdiParent = Me
        f.WindowState = FormWindowState.Normal
        f.Show()
        'f.ShowDialog()

    End Sub

    Private Sub GestionCategorieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionCategorieToolStripMenuItem.Click

        Dim f As New Frm_Categorie
        f.ShowDialog()

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ClearMemory()
    End Sub


    Private Sub NatureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NatureToolStripMenuItem.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        Dim f As New Frm_CDF
        f.MdiParent = Me
        f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub UniteUCUM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UniteUCUM.Click
        Dim f As New Frm_uniteUCUM
        f.MdiParent = Me
        'f._Code_CDF = sender.tag
        f.Show()
    End Sub

    Private Sub FicheFormeVirtuelleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FicheFormeVirtuelleToolStripMenuItem.Click
        Dim f As New Frm_Substance_Virtuelle
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub FicheFormeVirtuelleToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FicheFormeVirtuelleToolStripMenuItem1.Click
        Dim f As New Frm_Forme_Virtuelle
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub menuPos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuPos.Click
        Dim f As New Frm_Posologie
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub toolPosMinMax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolPosMinMax.Click
        Dim f As New Frm_Posologie_Min_Max1
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub PrixSousMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrixSousMenu.Click
        PrixJO.LoadCSV(True)

    End Sub

    Private Sub CochageSousMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CochageSousMenu.Click
        PrixJO.LoadCSV(False)
    End Sub

    Private Sub MédicamentVirtuelPèreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MédicamentVirtuelPèreToolStripMenuItem.Click
        Dim f As New Frm_MedVirtuellePere
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ToolStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip.ItemClicked

    End Sub
End Class
