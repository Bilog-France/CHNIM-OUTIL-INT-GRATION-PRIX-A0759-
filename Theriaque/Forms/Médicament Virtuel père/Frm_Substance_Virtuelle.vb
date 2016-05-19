Public Class Frm_Substance_Virtuelle
    Inherits Theriaque.Frm_Formulaire

    Private strSearchQuery As String = "Select SAV_CODE_SQ_PK as code, SAV_LIBELLE as libelle from THERIAQUE.SAV_SUBSTANCE_VIRTUELLE"

    Private Sub Frm_Substance_Virtuelle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SAVSAC_SUBVIRT_SUBACTableAdapter.Fill(Me.DsTheriaqueVirtuelPere.SAVSAC_SUBVIRT_SUBAC)

        LabelControl1.Visible = False
        DateEdit2.Visible = False
        LabelControl2.Visible = False
        DateEdit1.Visible = False
        Me.MasterDataSet = Me.DsTheriaqueVirtuelPere
        Me.MasterTable = "SAV_SUBSTANCE_VIRTUELLE"
        DesactivationGrid()
    End Sub



#Region " Edit Data  "

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSearchQuery
        f.Text = Me.Text
        f.ShowDialog()
        Dim Code As Integer = f._Code
        If f._Code IsNot Nothing Then
            OnLoading = True
            ActivationGrid()
            Me.SAV_SUBSTANCE_VIRTUELLE.FillByCode(Me.DsTheriaqueVirtuelPere.SAV_SUBSTANCE_VIRTUELLE, Code)
            FillCombos()
            OnLoading = False
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Sub Ajouter()

        EmptyDataTable()
        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        SetCode_MAx(MasterTable, Me.EditCode)
        FillCombos()
        DesactivationGrid()
        MyBase.Ajouter()
        Me.EditLibelle.Text = ""
        Me.EditCodeRef.Text = ""


    End Sub

    Public Overrides Function supprimer() As Boolean
        OnLoading = True
        MyBase.Supprimer()

        Dim iCount As Integer
        'grille
        For iCount = 0 To Me.DsTheriaqueVirtuelPere.SAVSAC_SUBVIRT_SUBAC.Rows.Count - 1
            DsTheriaqueVirtuelPere.SAVSAC_SUBVIRT_SUBAC.Rows(iCount).Delete()
        Next
        Me.SAVSAC_SUBVIRT_SUBACTableAdapter.Update(DsTheriaqueVirtuelPere)


        '' Master
        Me.DsTheriaqueVirtuelPere.SAV_SUBSTANCE_VIRTUELLE.Rows(0).Delete()
        Me.SAV_SUBSTANCE_VIRTUELLE.Update(Me.DsTheriaqueVirtuelPere.SAV_SUBSTANCE_VIRTUELLE)
        OnLoading = False

        Return True
    End Function

    Public Overrides Sub valider()
        If Me.EditLibelle.Text.Length < 1 Then
            MessageBox.Show("Veuillez remplir le champ libellé")
            Return
        End If
        MyBase.Valider()
        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        SAV_SUBSTANCE_VIRTUELLE.Update(Me.DsTheriaqueVirtuelPere.SAV_SUBSTANCE_VIRTUELLE)

        Me.BindingContext(Me.MasterDataSet, "SAVSAC_SUBVIRT_SUBAC").EndCurrentEdit()
        Me.SAVSAC_SUBVIRT_SUBACTableAdapter.Update(Me.DsTheriaqueVirtuelPere.SAVSAC_SUBVIRT_SUBAC)
        ActivationGrid()
    End Sub

    Public Overrides Sub annuler()
        OnLoading = True
        MyBase.Annuler()

        Me.BindingContext(Me.MasterDataSet, MasterTable).CancelCurrentEdit()
        Me.DsTheriaqueVirtuelPere.SAV_SUBSTANCE_VIRTUELLE.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, "SAVSAC_SUBVIRT_SUBAC").CancelCurrentEdit()
        Me.DsTheriaqueVirtuelPere.SAVSAC_SUBVIRT_SUBAC.RejectChanges()

        OnLoading = False
    End Sub

    Private Sub EmptyDataTable()
        Me.DsTheriaqueVirtuelPere.SAV_SUBSTANCE_VIRTUELLE.Clear()
    End Sub

    Private Sub FillCombos()
        Dim query As String = "select SAV_CODE_SQ_PK as code, SAV_LIBELLE as libelle  from  THERIAQUE.SAV_SUBSTANCE_VIRTUELLE   "
        InitLkup(Me.lstsav, "SAV_SUBSTANCE_VIRTUELLE", query, True, True)
    End Sub

    Private Sub DesactivationGrid()
        NavigatorControl(GridControl1.EmbeddedNavigator, False)

    End Sub

    Private Sub ActivationGrid()
        NavigatorControl(GridControl1.EmbeddedNavigator, True)
    End Sub

    Private Sub NavigatorControl(ByRef navigator As DevExpress.XtraEditors.ControlNavigator, ByVal val As Boolean)
        navigator.Buttons.BeginUpdate()
        Try
            navigator.Buttons.Append.Enabled = val
            navigator.Buttons.Edit.Enabled = val
            navigator.Buttons.CancelEdit.Enabled = val
            navigator.Buttons.First.Enabled = val
            navigator.Buttons.Last.Enabled = val
            navigator.Buttons.Remove.Enabled = val
            navigator.Buttons.Next.Enabled = val
            navigator.Buttons.Prev.Enabled = val
        Finally
            navigator.Buttons.EndUpdate()
        End Try
    End Sub

#End Region

    Private Sub GridView1_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(Me.colinvisible, EditCode.Text)
    End Sub
End Class