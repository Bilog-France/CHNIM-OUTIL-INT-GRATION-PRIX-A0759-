''' <summary>
''' Created By [BFE]
''' </summary>
''' <remarks> Critéres de choix - RMO
''' </remarks>
Public Class Frm_RMO

#Region "Déclaration des variables privées"
    Private CodE As String
    Public _Code As Integer = Nothing ' charger la fiche depuis l'extérieur
#End Region

#Region " Edit Data "

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_RMO
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            OnLoading = True
            EmptyDataTable()
            Me.Rmo_TA.FillByCode(Me.DsTheriaque_CriteresChoix.RMO, f._Code)
            Me.ClrmO_TA.FillByCode(Me.DsTheriaque_CriteresChoix.CLRMO_CLASSE_RMO, f._Code)
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
        Dim iCount As Integer

        For iCount = 0 To DsTheriaque_CriteresChoix.CLRMO_CLASSE_RMO.Rows.Count - 1
            DsTheriaque_CriteresChoix.CLRMO_CLASSE_RMO.Rows(iCount).Delete()
        Next
        Me.ClrmO_TA.Update(DsTheriaque_CriteresChoix)

        ' Master
        DsTheriaque_CriteresChoix.RMO.Rows(0).Delete()
        Me.Rmo_TA.Update(Me.MasterDataSet)
        Return True
    End Function

    Public Overrides Sub valider()
        MyBase.Valider()
        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        Rmo_TA.Update(Me.DsTheriaque_CriteresChoix.RMO)

        Me.BindingContext(Me.MasterDataSet, CLRMO_CLASSE_RMO).EndCurrentEdit()
        ClrmO_TA.Update(Me.DsTheriaque_CriteresChoix.CLRMO_CLASSE_RMO)
    End Sub

    Public Overrides Sub annuler()
        OnLoading = True
        MyBase.Annuler()

        Me.BindingContext(DsTheriaque_CriteresChoix, CLRMO_CLASSE_RMO).CancelCurrentEdit()
        Me.DsTheriaque_CriteresChoix.CLRMO_CLASSE_RMO.RejectChanges()

        'Master
        Me.BindingContext(Me.MasterDataSet, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_CriteresChoix.RMO.RejectChanges()
        OnLoading = False
    End Sub

    Private Sub EmptyDataTable()
        'Master
        Me.DsTheriaque_CriteresChoix.RMO.Clear()
        Me.DsTheriaque_CriteresChoix.CLRMO_CLASSE_RMO.Clear()
    End Sub

#End Region

#Region " Init Data  "

    Private Sub InitDataSource()
        GC.DataSource = DsTheriaque_CriteresChoix
        GC.DataMember = CLRMO_CLASSE_RMO
    End Sub

    Public Overrides Sub InitData()
        MyBase.InitData()
        OnLoading = True
        MasterDataSet = Me.DsTheriaque_CriteresChoix
        MasterTable = RMO
        CodE = InvalideControl
        InitDataSource()
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

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        If OnLoading Then Exit Sub
        GV.SetFocusedRowCellValue(colCLRMO_RMO_CODE_FK_PK, txtCode.Text)
        'GV.SetFocusedRowCellValue(colCLRMO_CL_CODE_PK, Code_MAx(GV, colCLRMO_CL_CODE_PK))
    End Sub

#End Region

    Private Sub GV_ValidatingEditor(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV.ValidatingEditor
        If GV.FocusedColumn Is colCLRMO_NOM Then
            If FieldExistCS(GV, colCLRMO_NOM, e.Value) Then
                e.ErrorText = "Cette classe est déjà présente."
                e.Value = Nothing
                e.Valid = False
            End If
        End If
        If GV.FocusedColumn Is Me.colCLRMO_CL_CODE_PK Then
            If FieldExist(GV, colCLRMO_CL_CODE_PK, e.Value) Then
                e.ErrorText = "Cette code est déjà présente."
                e.Value = Nothing
                e.Valid = False
            End If
        End If
    End Sub
    Private Sub Open_Fiche(ByVal CodE1 As Integer)
        OnLoading = True
        CodE = _Code
        EmptyDataTable()
        Me.Rmo_TA.FillByCode(Me.DsTheriaque_CriteresChoix.RMO, CodE1)
        Me.ClrmO_TA.FillByCode(Me.DsTheriaque_CriteresChoix.CLRMO_CLASSE_RMO, CodE1)
        OnLoading = False
    End Sub

End Class
