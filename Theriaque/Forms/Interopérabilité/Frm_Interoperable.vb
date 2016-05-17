''' <summary>
''' Created By [BFE]
''' </summary>
''' <remarks> Fichier interopérable </remarks>

Public Class Frm_Interoperable
#Region "Déclaration des variables"
    Dim CodE As Integer
#End Region

#Region " Edit Data  "
    '''' <summary>
    '''' Fonction: Recherche et retour des données de la fiche
    '''' </summary>
    '''' <returns>Boolean</returns>
    '''' <remarks>Fonction surchargée</remarks>
    'Public Overrides Function Chercher() As Boolean
    '    MyBase.Chercher()
    '    Dim f As New Frm_Recherche
    '    f._SSQL = strSSQL_PRE_PRESENTATION
    '    f.Text = Me.Text
    '    f.ShowDialog()
    '    CodE = f._Code
    '    If f._Code IsNot Nothing Then
    '        OnLoading = True
    '        'XtraTabControl1.SelectedTabPageIndex = 0
    '        Me.InteR_TA.FillByCodeCIP(Me.DsTheriaque_Interoperable.INTER_INTEROPERABLE, CodE)
    '        'ProgressBar.Visible = True
    '        'txtCode.Text = CodE
    '        'txtLibelle.Text = ClsSP.GetLibelle(CodE)
    '        OnLoading = False
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function
#End Region

#Region " Init Data  "

    Private Sub InitDataSource()
        Dim sSql As String = "SELECT * FROM THERIAQUE.INTER_INTEROPERABLE"
        GC.DataSource = cn.MySelect(sSql)
    End Sub

    Public Overrides Sub InitData()
        MyBase.InitData()
        OnLoading = True
        InitDataSource()
        'Me.InteR_TA.Fill(Me.DsTheriaque_Interoperable.INTER_INTEROPERABLE)
        'Me.DextR_TA.Fill(Me.DsTheriaque_Interoperable.DEXTR_DATE_EXTRACTION)
        OnLoading = False
    End Sub
#End Region

End Class
