Imports System.Runtime.InteropServices

Public Module ModNotify

#Region " Win32Api_NotifyIcon "
    Public Declare Function Shell_NotifyIcon Lib "shell32.dll" Alias _
         "Shell_NotifyIconA" (ByVal dwMessage As Int32, _
    ByRef lpData As NOTIFYICONDATA) As Int32

    Public Structure NOTIFYICONDATA
        Public cbSize As Int32
        Public hwnd As IntPtr
        Public uId As Int32
        Public uFlags As Int32
        Public uCallBackMessage As Int32
        Public hIcon As IntPtr
        <MarshalAs(UnmanagedType.ByValTStr, sizeconst:=128)> _
                Public szTip As String
        Public dwState As Int32
        Public dwStateMask As Int32
        <MarshalAs(UnmanagedType.ByValTStr, sizeconst:=256)> _
        Public szInfo As String
        Public uTimeoutOrVersion As Int32
        <MarshalAs(UnmanagedType.ByValTStr, sizeconst:=64)> _
        Public szInfoTitle As String
        Public dwInfoFlags As Int32
    End Structure

    Private Const NOTIFYICON_VERSION = 3
    Private Const NOTIFYICON_OLDVERSION = 0

    Private Const NIM_ADD = &H0
    Private Const NIM_MODIFY = &H1
    Private Const NIM_DELETE = &H2

    Private Const NIM_SETFOCUS = &H3
    Private Const NIM_SETVERSION = &H4

    Private Const NIF_MESSAGE = &H1
    Private Const NIF_ICON = &H2
    Private Const NIF_TIP = &H4

    Private Const NIF_STATE = &H8
    Private Const NIF_INFO = &H10

    Private Const NIS_HIDDEN = &H1
    Private Const NIS_SHAREDICON = &H2

    Private Const NIIF_NONE = &H0
    Private Const NIIF_WARNING = &H2
    Private Const NIIF_ERROR = &H3
    Private Const NIIF_INFO = &H1

    Private nfIconData As NOTIFYICONDATA

#End Region

    Public Sub ToolTip(ByVal Message As String, Optional ByVal VszInfoTitle As String = "Info Thériaque", Optional ByVal Warning As Boolean = False)
        nfIconData = New NOTIFYICONDATA
        With nfIconData
            .cbSize = System.Runtime.InteropServices.Marshal.SizeOf(nfIconData)
            '.hwnd = Me.Handle
            .uId = vbNull
            .uFlags = NIF_INFO Or NIF_ICON Or NIF_TIP Or NIF_MESSAGE
            '.hIcon = Me.Icon.Handle
            .szTip = "123"
            .dwState = 0
            .dwStateMask = 0
            .szInfo = Message
            .uTimeoutOrVersion = 2000
            .szInfoTitle = VszInfoTitle
            If Warning Then
                .dwInfoFlags = NIIF_WARNING
            Else
                .dwInfoFlags = NIIF_INFO
            End If

        End With
        Call Shell_NotifyIcon(NIM_ADD, nfIconData)
    End Sub

    Public Sub ShowToolTip(ByVal Message As String, Optional ByVal VszInfoTitle As String = "Info Thériaque", Optional ByVal Warning As Boolean = False)
        ToolTip(Message, VszInfoTitle, Warning)
    End Sub

    Public Sub hideToolTip()
        Call Shell_NotifyIcon(NIM_DELETE, nfIconData)
    End Sub

End Module
