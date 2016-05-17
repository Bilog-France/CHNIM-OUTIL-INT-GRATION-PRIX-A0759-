'=========================================== Module de gestion des message ===============
'Nom:  ModMessage.vb
'Module : Module de gestion des message
'Date de Création: 19/04/2004
'Auteurs : LZA
'|Dernières modifications : 12/05/2004 | User : LZA | Taches : 10070 |
'=========================================================================================
Imports System.io
Imports System.Windows.Forms
Imports System.Object
Imports System.Resources
Imports System.Data.Sqlclient
Imports System.Runtime.InteropServices
Imports Microsoft.Win32

Module ModMessage

    Public Structure MsgResults
        Dim BtResult As MsgBoxResult
        Dim strResult As String
    End Structure

    Public Enum MyType
        Chaine
        Entier
        Dates
    End Enum
    Public Valide As Boolean

    Public Function Process_Message(ByVal MsgText As String, _
                               ByVal Boutons As System.Windows.Forms.MessageBoxButtons, _
                               ByVal Icon As System.Windows.Forms.MessageBoxIcon, _
                               Optional ByVal Title As String = APPNAME, _
                               Optional ByVal IsInputBox As Boolean = False, _
                               Optional ByVal Show As Boolean = True, _
                               Optional ByVal IsLogMsg As Boolean = True, _
                               Optional ByVal DefaultRsp As String = "", _
                               Optional ByVal ResType As MyType = MyType.Chaine, _
                               Optional ByVal Supplement As String = "", _
                               Optional ByVal NumLigne As String = "", _
                               Optional ByVal AfficheMSG As Boolean = True) As MsgResults 'Si c'est false alors il dependera du Parametrage "des affichage des messages" dans le module Option
        Try
            Try
                If Trim(Title) = "" Or ((Title) Is Nothing) Then Title = APPNAME
                If IsLogMsg Then
                    Dim f As New StreamWriter(Application.StartupPath & "\Interop.log.dll", True, System.Text.Encoding.Default)
                    Dim msg As String = Title & ";" & Now & ";" & Replace(Replace(MsgText, Chr(13), " "), Chr(10), " ") & ";" & NumLigne & ";" & Supplement
                    f.WriteLine(msg)
                    f.Close()
                End If
            Catch ex As Exception
            End Try

            Dim msgRes As MsgResults

            If IsInputBox Then
                Dim s As String
                s = InputBox(MsgText, Title, DefaultRsp)
                Select Case ResType
                    Case MyType.Dates
                        If IsDate(s) Then
                            msgRes.BtResult = MsgBoxResult.Ok
                            msgRes.strResult = s
                        Else
                            msgRes.BtResult = MsgBoxResult.Cancel
                            msgRes.strResult = s
                        End If
                    Case MyType.Entier
                        If IsNumeric(s) Then
                            msgRes.BtResult = MsgBoxResult.Ok
                            msgRes.strResult = s
                        Else
                            msgRes.BtResult = MsgBoxResult.Cancel
                            msgRes.strResult = s
                        End If
                    Case Else
                        If s = Nothing Then
                            msgRes.BtResult = MsgBoxResult.Cancel
                            msgRes.strResult = s
                        ElseIf s.Trim = "" Then
                            msgRes.BtResult = MsgBoxResult.Cancel
                            msgRes.strResult = s
                        Else
                            msgRes.BtResult = MsgBoxResult.Ok
                            msgRes.strResult = s
                        End If
                End Select
            Else
                msgRes.BtResult = MessageBox.Show(MsgText, Title, Boutons, Icon, MessageBoxDefaultButton.Button1)
            End If
            FMain.BringToFront()
            Return msgRes
        Catch ex As Exception
            Process_Message_Error(ex, "THERIAQUE", "M181")
        End Try
    End Function

    Public Sub Process_Message_Error(ByVal Erreur As Exception, ByVal NameFiche As String, ByVal CodeErreurTHERIAQUE As String, Optional ByVal Supplementaire As String = "")
        ' ------------------------------------------------------------
        ' ------------------------------------------------------------
        ' Cet Procedure sert à récupérer le code Erreur SQL
        ' et affiché Le message adéquat SQL
        ' ------------------------------------------------------------
        ' ------------------------------------------------------------
        Try
            Dim Nom_Frm As String
            Dim MsgErreurs As String = ""
            Dim Erreur_SQL As SqlException

            If Erreur.GetType Is GetType(System.OutOfMemoryException) Then
                Process_Message("[" & CodeErreurTHERIAQUE & "] " & "Mémoire insuffisante " & Num_Ligne(Erreur.StackTrace), MsgBoxStyle.OKOnly, MsgBoxStyle.Critical, NameFiche, , , , , , Supplementaire, Num_Ligne(Erreur.StackTrace))
                Exit Sub
            End If

            Select Case Erreur.Source
                Case ".Net SqlClient Data Provider"
                    Erreur_SQL = Erreur
                    If MsgErreurs = "" Then
                        Process_Message("[" & CodeErreurTHERIAQUE & "] " & Erreur_SQL.Message & Num_Ligne(Erreur.StackTrace), MsgBoxStyle.OKOnly, MsgBoxStyle.Critical, NameFiche, , , , , , Supplementaire, Num_Ligne(Erreur.StackTrace))
                    Else
                        Process_Message("[" & CodeErreurTHERIAQUE & "] " & MsgErreurs & Num_Ligne(Erreur.StackTrace), MsgBoxStyle.OKOnly, MsgBoxStyle.Critical, NameFiche, , , , , , Supplementaire, Erreur_SQL.Message & Num_Ligne(Erreur.StackTrace))
                    End If
                Case Else
                    Process_Message("[" & CodeErreurTHERIAQUE & "] " & MsgErreurs & Num_Ligne(Erreur.StackTrace), MsgBoxStyle.OkOnly, MsgBoxStyle.Critical, NameFiche, , , , , , Supplementaire, Erreur_SQL.Message & Num_Ligne(Erreur.StackTrace))
            End Select
        Catch ex As Exception
            MessageBox.Show("[XXX]" & ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function Num_Ligne(ByVal Erreur_msg As String) As String
        Try
            Dim Pos_Temp As Integer = InStr(Erreur_msg, ":line ", CompareMethod.Text)
            If Pos_Temp > 0 Then
                Return " Ligne :" & Mid(Erreur_msg, Pos_Temp + 6)
            End If
        Catch ex As Exception
            Process_Message_Error(ex, " ", "M196")
        End Try
    End Function

End Module