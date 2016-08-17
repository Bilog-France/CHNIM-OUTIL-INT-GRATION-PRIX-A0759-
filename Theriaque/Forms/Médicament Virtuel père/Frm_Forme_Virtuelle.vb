Public Class Frm_Forme_Virtuelle
    Inherits Theriaque.Frm_Formulaire

    Private strSearchQuery As String = "Select FOV_CODE_SQ_PK as code, FOV_LIBELLE as libelle from THERIAQUE.FOV_FORME_VIRTUELLE"

    Private Sub Frm_Forme_Virtuelle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'TODO : cette ligne de code charge les données dans la table 'DsTheriaqueVirtuelPere.FOVCFO_FORMEVIRT_COMPFORME'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        'Me.FOVCFO_FORMEVIRT_COMPFORMETableAdapter.Fill(Me.DsTheriaqueVirtuelPere.FOVCFO_FORMEVIRT_COMPFORME)
        LabelControl1.Visible = False
        DateEdit2.Visible = False
        LabelControl2.Visible = False
        DateEdit1.Visible = False
        Me.MasterDataSet = Me.DsTheriaqueVirtuelPere
        Me.MasterTable = "FOV_FORME_VIRTUELLE"

        GridControl1.DataSource = Me.DsTheriaqueVirtuelPere
        GridControl1.DataMember = "FOVCFO_FORMEVIRT_COMPFORME"

        GC2.DataSource = Me.DsTheriaqueVirtuelPere
        GC2.DataMember = "SYFOV_SYNONYME_FORME_VIRT"

        DesactivationGrid()
        FillCombos()

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
            Me.Fov_Forme_Virtuelle.FillByCode(Me.DsTheriaqueVirtuelPere.FOV_FORME_VIRTUELLE, Code)
            Me.FOVCFO_FORMEVIRT_COMPFORMETableAdapter.FillByCode(Me.DsTheriaqueVirtuelPere.FOVCFO_FORMEVIRT_COMPFORME, Code)
            Me.SYFOV.FillByCode(Me.DsTheriaqueVirtuelPere.SYFOV_SYNONYME_FORME_VIRT, f._Code)
            OnLoading = False
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Sub Ajouter()
 
        EmptyDataTable()
        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        DsTheriaqueVirtuelPere.SYFOV_SYNONYME_FORME_VIRT.Clear()
        DsTheriaqueVirtuelPere.FOVCFO_FORMEVIRT_COMPFORME.Clear()
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
        For iCount = 0 To Me.DsTheriaqueVirtuelPere.FOVCFO_FORMEVIRT_COMPFORME.Rows.Count - 1
            DsTheriaqueVirtuelPere.FOVCFO_FORMEVIRT_COMPFORME.Rows(iCount).Delete()
        Next
        Me.FOVCFO_FORMEVIRT_COMPFORMETableAdapter.Update(DsTheriaqueVirtuelPere)


        For iCount = 0 To Me.DsTheriaqueVirtuelPere.SYFOV_SYNONYME_FORME_VIRT.Rows.Count - 1
            DsTheriaqueVirtuelPere.SYFOV_SYNONYME_FORME_VIRT.Rows(iCount).Delete()
        Next
        Me.SYFOV.Update(DsTheriaqueVirtuelPere)


        Dim delreq As String = " Delete from theriaque.MVPRFOV_MED_VIR_PERE_FORME_VIRTUELLE where MVPRFOV_FOV_CODE_FK_PK=" & EditCode.Text
        cn.Execute(delreq)

        '' Master
        Me.DsTheriaqueVirtuelPere.FOV_FORME_VIRTUELLE.Rows(0).Delete()
        Me.Fov_Forme_Virtuelle.Update(Me.DsTheriaqueVirtuelPere.FOV_FORME_VIRTUELLE)
        OnLoading = False

        Return True

    End Function

    Public Overrides Sub valider()

        If Me.EditLibelle.Text.Length < 1 Then
            MessageBox.Show("Veuillez remplir le champ libellé")
            Return
        End If

        Dim strSSQL As String
        strSSQL = " select FOV_CODE_SQ_PK from theriaque.FOV_FORME_VIRTUELLE where FOV_LIBELLE = " & cn.SQLText(EditLibelle.Text)
        Dim dt As DataTable = cn.MySelect(strSSQL)
        MyBase.IsValider = True

        If dt.Rows.Count > 0 Then
            If dt.Rows(0).Item(0) <> EditCode.Text Then
                MsgBox("Le libellé de la forme virtuelle existe déjà")
                MyBase.IsValider = False
                Exit Sub
            End If
        End If

        MyBase.Valider()
        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        Fov_Forme_Virtuelle.Update(Me.DsTheriaqueVirtuelPere.FOV_FORME_VIRTUELLE)

        Me.BindingContext(Me.MasterDataSet, "FOVCFO_FORMEVIRT_COMPFORME").EndCurrentEdit()
        Me.FOVCFO_FORMEVIRT_COMPFORMETableAdapter.Update(Me.DsTheriaqueVirtuelPere.FOVCFO_FORMEVIRT_COMPFORME)

        Me.BindingContext(Me.MasterDataSet, "SYFOV_SYNONYME_FORME_VIRT").EndCurrentEdit()
        Me.SYFOV.Update(Me.DsTheriaqueVirtuelPere.SYFOV_SYNONYME_FORME_VIRT)


        ActivationGrid()
    End Sub

    Public Overrides Sub annuler()
        OnLoading = True
        MyBase.Annuler()

        Me.BindingContext(Me.MasterDataSet, MasterTable).CancelCurrentEdit()
        Me.DsTheriaqueVirtuelPere.FOV_FORME_VIRTUELLE.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, "FOVCFO_FORMEVIRT_COMPFORME").CancelCurrentEdit()
        Me.DsTheriaqueVirtuelPere.FOVCFO_FORMEVIRT_COMPFORME.RejectChanges()

        OnLoading = False
    End Sub

    Private Sub EmptyDataTable()
        'Master
        Me.DsTheriaqueVirtuelPere.FOV_FORME_VIRTUELLE.Clear()
    End Sub

    Private Sub FillCombos()

        Dim query As String = "select top 0 FOV_CODE_SQ_PK as code, FOV_LIBELLE as libelle  from  THERIAQUE.FOV_FORME_VIRTUELLE   "
        query &= " union select CDF_CODE_PK as code, CDF_NOM as libelle  from theriaque.CDF_CODIF where CDF_NUMERO_PK = '02' "
        'Dim query As String = " select top 10 CDF_CODE_PK as code, CDF_NOM as libelle  from theriaque.CDF_CODIF where CDF_NUMERO_PK = '02' "
        InitLkup(Me.lstcdf1, "CDF_CODIF", query, True, True)

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

    Private Sub GridView1_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        GridView1.SelectRow(GridView1.FocusedRowHandle)
    End Sub

    Private Sub GridView1_FocusedColumnChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles GridView1.FocusedColumnChanged

        If (e.FocusedColumn.Name = "FOV_LIBELLE") Then



        End If

    End Sub

    Private Sub GV2_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow

        GV2.SetFocusedRowCellValue(colSYFOV_FOV_CODE_FK_PK, EditCode.Text)

    End Sub


    Private Sub GV2_ValidatingEditor(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV2.ValidatingEditor

        If e.Value IsNot Nothing Then

            Dim strSSQL As String


            strSSQL = "select * from theriaque.SYFOV_SYNONYME_FORME_VIRT where SYFOV_LIBELLE = " & cn.SQLText(e.Value)

            Dim dt As DataTable = cn.MySelect(strSSQL)

            strSSQL = " select FOV_CODE_SQ_PK from theriaque.FOV_FORME_VIRTUELLE where FOV_LIBELLE = " & cn.SQLText(e.Value)

            Dim dt2 As DataTable = cn.MySelect(strSSQL)

            If dt2.Rows.Count > 0 Then
                e.Valid = False
                e.ErrorText = " Ce libellé existe comme libellé forme virtuelle n° " & dt2.Rows(0).Item(0)
            Else
                If dt.Rows.Count > 0 Then
                    e.Valid = False
                    e.ErrorText = " Cette valeur existe déja dans la fiche " & dt.Rows(0).Item("SYFOV_FOV_CODE_FK_PK")
                Else
                    For i As Integer = 0 To GV2.RowCount - 2

                        If GV2.GetDataRow(i).Item("SYFOV_LIBELLE") IsNot System.DBNull.Value Then
                            If (GV2.GetDataRow(i).Item("SYFOV_LIBELLE") = e.Value) Then

                                e.Valid = False
                                e.ErrorText = " Cette valeur existe déjà dans la fiche "
                                Exit For

                            End If
                        End If

                    Next
                End If

            End If
        End If

    End Sub
End Class