''' <summary>
''' Created By [BFE]
''' </summary>
''' <remarks> Critéres de choix - Fiche de transparence 
''' </remarks>
Public Class Frm_Fiche_Transparence

#Region "Déclaration des variables privées"
    Private CodE As String
    Public _Code As Integer = Nothing ' charger la fiche depuis l'extérieur
#End Region

#Region " Edit Data "

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_FTR_FICHETRANSPARENCE
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            OnLoading = True
            EmptyDataTable()
            Me.FtR_TA.FillByCode(Me.DsTheriaque_CriteresChoix.FTR_FICHETRANSPARENCE, f._Code)
            OnLoading = False
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Sub Ajouter()
        EmptyDataTable()
        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        SetCode_MAx(MasterTable, txtCode)
        CodE = InvalideControl
        MyBase.Ajouter()
    End Sub

    Public Overrides Function supprimer() As Boolean
        MyBase.Supprimer()

        ' Master
        DsTheriaque_CriteresChoix.FTR_FICHETRANSPARENCE.Rows(0).Delete()
        Me.FtR_TA.Update(Me.MasterDataSet)
        Return True
    End Function

    Public Overrides Sub valider()
        MyBase.Valider()
        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        FtR_TA.Update(Me.DsTheriaque_CriteresChoix.FTR_FICHETRANSPARENCE)
    End Sub

    Public Overrides Sub annuler()
        OnLoading = True
        MyBase.Annuler()

        'Master
        Me.BindingContext(Me.MasterDataSet, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_CriteresChoix.FTR_FICHETRANSPARENCE.RejectChanges()

        OnLoading = False
    End Sub

    Private Sub EmptyDataTable()
        'Master
        Me.DsTheriaque_CriteresChoix.FTR_FICHETRANSPARENCE.Clear()
    End Sub

#End Region

#Region " Init Data  "

    Public Overrides Sub InitData()
        MyBase.InitData()
        OnLoading = True
        MasterDataSet = Me.DsTheriaque_CriteresChoix
        MasterTable = FTR_FICHETRANSPARENCE
        CodE = InvalideControl
        FirstFocus = txtCode
        If _Code <> Nothing Then
            Load_On(Me)
            Open_Fiche(_Code)
            ModeFiche = eMode.Consultation
            UpdateStateBouton()
            Initcomponent()
            Load_Off(Me)
        End If
        OnLoading = False
    End Sub

#End Region

    Private Sub Open_Fiche(ByVal CodE1 As Integer)
        OnLoading = True
        CodE = _Code
        EmptyDataTable()
        Me.FtR_TA.FillByCode(Me.DsTheriaque_CriteresChoix.FTR_FICHETRANSPARENCE, CodE1)
        OnLoading = False
    End Sub

End Class
