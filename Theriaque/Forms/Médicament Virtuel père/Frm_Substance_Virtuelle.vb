Public Class Frm_Substance_Virtuelle
    Inherits Theriaque.Frm_Formulaire

    Private strSearchQuery As String = "Select SAV_CODE_SQ_PK as code, SAV_LIBELLE as libelle from THERIAQUE.SAV_SUBSTANCE_VIRTUELLE"

    Private Sub Frm_Substance_Virtuelle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Me.SAVSAC_SUBVIRT_SUBACTableAdapter.Fill(Me.DsTheriaqueVirtuelPere.SAVSAC_SUBVIRT_SUBAC)

        LabelControl1.Visible = False
        DateEdit2.Visible = False
        LabelControl2.Visible = False
        DateEdit1.Visible = False
        Me.MasterDataSet = Me.DsTheriaqueVirtuelPere
        Me.MasterTable = "SAV_SUBSTANCE_VIRTUELLE"

        Me.GC2.DataSource = Me.DsTheriaqueVirtuelPere
        Me.GC2.DataMember = "SYSAV_SYNONYME_SUBST_VIRT"

        Me.GridControl1.DataSource = Me.DsTheriaqueVirtuelPere
        Me.GridControl1.DataMember = "SAVSAC_SUBVIRT_SUBAC"

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
            Me.SYSAV.FillByCode(Me.DsTheriaqueVirtuelPere.SYSAV_SYNONYME_SUBST_VIRT, f._Code)
            Me.SAVSAC_SUBVIRT_SUBACTableAdapter.FillByCode(Me.DsTheriaqueVirtuelPere.SAVSAC_SUBVIRT_SUBAC, f._Code)
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
        Me.DsTheriaqueVirtuelPere.SAVSAC_SUBVIRT_SUBAC.Clear()
        Me.DsTheriaqueVirtuelPere.SYSAV_SYNONYME_SUBST_VIRT.Clear()
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

        For iCount = 0 To Me.DsTheriaqueVirtuelPere.SYSAV_SYNONYME_SUBST_VIRT.Rows.Count - 1
            DsTheriaqueVirtuelPere.SYSAV_SYNONYME_SUBST_VIRT.Rows(iCount).Delete()
        Next
        Me.SYSAV.Update(DsTheriaqueVirtuelPere)


        Dim delreq As String = " Delete from theriaque.MVPRSAV_MED_VIR_PER_SUBS_VIRT where MVPRSAV_SAV_CODE_FK_PK=" & EditCode.Text
        cn.Execute(delreq)
       


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

        Dim strSSQL As String
        'Doublon libellé-libellé entre deux fiches différentes
        strSSQL = " select SAV_CODE_SQ_PK from theriaque.SAV_SUBSTANCE_VIRTUELLE where SAV_LIBELLE = " & cn.SQLText(EditLibelle.Text)
        Dim dt As DataTable = cn.MySelect(strSSQL)
        MyBase.IsValider = True

        If dt.Rows.Count > 0 Then

            If dt.Rows(0).Item(0) <> EditCode.Text Then

                MsgBox("Le libellé de la substance virtuelle existe déjà")
                MyBase.IsValider = False
                Exit Sub

            End If

        End If

        'doublon Libellé - synonyme dans la même fiche 
        strSSQL = " select SYSAV_SAV_CODE_FK_PK from theriaque.SYSAV_SYNONYME_SUBST_VIRT where SYSAV_LIBELLE = " & cn.SQLText(EditLibelle.Text)
        dt = cn.MySelect(strSSQL)

        MyBase.IsValider = True
        If dt.Rows.Count > 0 Then
            MsgBox("Le libellé de la substance virtuelle existe déjà dans le synonyme de la fiche " & dt.Rows(0).Item(0))
            MyBase.IsValider = False
            Exit Sub
        End If


        For i As Integer = 0 To GV2.RowCount - 1

            If (GV2.GetDataRow(i)("SYSAV_LIBELLE")).ToString().ToLower().Equals(EditLibelle.Text.ToLower()) Then
                MsgBox("Le libellé de la fiche existe comme libellé de synonyme")
                Exit Sub
                MyBase.IsValider = False
            End If


        Next

        MyBase.Valider()
        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        SAV_SUBSTANCE_VIRTUELLE.Update(Me.DsTheriaqueVirtuelPere.SAV_SUBSTANCE_VIRTUELLE)

        Me.BindingContext(Me.MasterDataSet, "SAVSAC_SUBVIRT_SUBAC").EndCurrentEdit()
        Me.SAVSAC_SUBVIRT_SUBACTableAdapter.Update(Me.DsTheriaqueVirtuelPere.SAVSAC_SUBVIRT_SUBAC)

        Me.BindingContext(Me.MasterDataSet, "SYSAV_SYNONYME_SUBST_VIRT").EndCurrentEdit()
        SYSAV.Update(Me.DsTheriaqueVirtuelPere.SYSAV_SYNONYME_SUBST_VIRT)

        ActivationGrid()

    End Sub

    Public Overrides Sub annuler()

        OnLoading = True
        MyBase.Annuler()

        Me.BindingContext(Me.MasterDataSet, MasterTable).CancelCurrentEdit()
        Me.DsTheriaqueVirtuelPere.SAV_SUBSTANCE_VIRTUELLE.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, "SAVSAC_SUBVIRT_SUBAC").CancelCurrentEdit()
        Me.DsTheriaqueVirtuelPere.SAVSAC_SUBVIRT_SUBAC.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, "SYSAV_SYNONYME_SUBST_VIRT").CancelCurrentEdit()
        Me.DsTheriaqueVirtuelPere.SYSAV_SYNONYME_SUBST_VIRT.RejectChanges()

        OnLoading = False

    End Sub

    Private Sub EmptyDataTable()

        Me.DsTheriaqueVirtuelPere.SAV_SUBSTANCE_VIRTUELLE.Clear()
        Me.DsTheriaqueVirtuelPere.SYSAV_SYNONYME_SUBST_VIRT.Clear()

    End Sub

    Private Sub FillCombos()

        'Dim query As String = "select SAV_CODE_SQ_PK as code, SAV_LIBELLE as libelle  from  THERIAQUE.SAV_SUBSTANCE_VIRTUELLE   "
        Dim query As String = " select SAC_CODE_SQ_PK as code, SAC_NOM as libelle  from theriaque.SAC_SUBACTIVE "
        InitLkup(Me.lstsav, "SAC_SUBACTIVE", query, True, True)

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

    Private Sub GV2_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        GV2.SetFocusedRowCellValue(colSYSAV_SAV_CODE_FK_PK, EditCode.Text)
    End Sub

    Private Sub GV2_ValidatingEditor(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV2.ValidatingEditor

        If e.Value IsNot Nothing And e.Value IsNot System.DBNull.Value Then


            If String.IsNullOrEmpty(e.Value.ToString().Trim()) Then

                e.Valid = False
                e.ErrorText = " le libellé ne doit pas etre vide "

            Else

                Dim strSSQL As String

                strSSQL = "select * from theriaque.SYSAV_SYNONYME_SUBST_VIRT where SYSAV_LIBELLE = " & cn.SQLText(e.Value)

                Dim dt As DataTable = cn.MySelect(strSSQL)

                strSSQL = " select SAV_CODE_SQ_PK from theriaque.SAV_SUBSTANCE_VIRTUELLE where SAV_LIBELLE = " & cn.SQLText(e.Value)
                Dim dt2 As DataTable = cn.MySelect(strSSQL)

                If dt2.Rows.Count > 0 Then
                    e.Valid = False
                    e.ErrorText = " Ce libellé existe comme libellé substance virtuelle n° " & dt2.Rows(0).Item(0)
                Else
                    If dt.Rows.Count > 0 Then
                        If Not (EditCode.Text.ToLower().Equals(dt.Rows(0).Item("SYSAV_SAV_CODE_FK_PK").ToString().ToLower())) Then
                            e.Valid = False
                            e.ErrorText = " Cette valeur existe déja dans la fiche " & dt.Rows(0).Item("SYSAV_SAV_CODE_FK_PK")
                        End If
                    Else
                        For i As Integer = 0 To GV2.RowCount - 2

                            If GV2.GetDataRow(i).Item("SYSAV_LIBELLE") IsNot System.DBNull.Value Then
                                If (GV2.GetDataRow(i).Item("SYSAV_LIBELLE") = e.Value) Then

                                    e.Valid = False
                                    e.ErrorText = " Cette valeur existe déjà dans la fiche "
                                    Exit For

                                End If
                            End If

                        Next
                    End If
                    End If
            End If
        End If

    End Sub

End Class