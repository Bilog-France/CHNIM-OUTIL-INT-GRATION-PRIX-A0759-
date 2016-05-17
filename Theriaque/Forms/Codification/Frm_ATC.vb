Public Class Frm_ATC

#Region " Edit data "

    Public Overrides Function Chercher() As Boolean
        Dim strSSQL As String = ""
        Dim strCode As String = ""

        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_CATC_CLASSEATC
        f.Text = Me.Text
        f.ShowDialog()
        If f._Code IsNot Nothing Then
            Me.CatC_CLASSEATCTableAdapter.FillByCode(Me.DsTheriaque1.CATC_CLASSEATC, f._Code)
            Me.SyaatC_SYNONYMEANGLAIS_ATCTableAdapter.FillByCode(Me.DsTheriaque1.SYAATC_SYNONYMEANGLAIS_ATC, f._Code)
            Me.SyfatC_SYNONYMEFR_ATCTableAdapter.FillByCode(Me.DsTheriaque1.SYFATC_SYNONYMEFR_ATC, f._Code)
            Me.GCFils.DataSource = CatC_CLASSEATCTableAdapterFils.GetDataByFils(f._Code)
            Me.AtcddD_DOSE_USUELLE_JOURTableAdapter.FillByCode(Me.DsTheriaque1.ATCDDD_DOSE_USUELLE_JOUR, f._Code)
        End If
        Return True
    End Function

    Public Overrides Sub Ajouter()
        MyBase.Ajouter()
        tabControl.SelectedTabPageIndex = 0
        Me.DsTheriaque1.CATC_CLASSEATC.Clear()
        Me.BindingContext(Me.DsTheriaque1, MasterTable).AddNew()
        Me.BindingContext(Me.DsTheriaque1, MasterTable).Current("CATC_DATECR") = Now.Date

        Me.DsTheriaque1.SYAATC_SYNONYMEANGLAIS_ATC.Clear()
        Me.DsTheriaque1.SYFATC_SYNONYMEFR_ATC.Clear()
        Me.DsTheriaque1.ATCDDD_DOSE_USUELLE_JOUR.Clear()
        Me.GCFils.DataSource = Nothing
    End Sub

    Public Overrides Sub Valider()
        MyBase.Valider()

        Me.BindingContext(Me.DsTheriaque1, MasterTable).Current("CATC_DATEMJ") = Now.Date
        Me.BindingContext(Me.DsTheriaque1, MasterTable).EndCurrentEdit()
        CatC_CLASSEATCTableAdapter.Update(Me.DsTheriaque1.CATC_CLASSEATC)

        Me.BindingContext(Me.DsTheriaque1, SYFATC_SYNONYMEFR_ATC).EndCurrentEdit()
        SyfatC_SYNONYMEFR_ATCTableAdapter.Update(Me.DsTheriaque1.SYFATC_SYNONYMEFR_ATC)

        Me.BindingContext(Me.DsTheriaque1, SYAATC_SYNONYMEANGLAIS_ATC).EndCurrentEdit()
        SyaatC_SYNONYMEANGLAIS_ATCTableAdapter.Update(Me.DsTheriaque1.SYAATC_SYNONYMEANGLAIS_ATC)

        Me.BindingContext(Me.DsTheriaque1, ATCDDD_DOSE_USUELLE_JOUR).EndCurrentEdit()
        AtcddD_DOSE_USUELLE_JOURTableAdapter.Update(Me.DsTheriaque1.ATCDDD_DOSE_USUELLE_JOUR)

        InitLkup(lkupLibellePere, MasterTable, strSSQL_CATC_CLASSEATC, True, False)
    End Sub

    Public Overrides Sub annuler()
        MyBase.Annuler()
        Me.BindingContext(Me.DsTheriaque1, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque1.CATC_CLASSEATC.RejectChanges()

        Me.BindingContext(Me.DsTheriaque1, SYFATC_SYNONYMEFR_ATC).CancelCurrentEdit()
        Me.DsTheriaque1.SYFATC_SYNONYMEFR_ATC.RejectChanges()

        Me.BindingContext(Me.DsTheriaque1, SYAATC_SYNONYMEANGLAIS_ATC).CancelCurrentEdit()
        Me.DsTheriaque1.SYAATC_SYNONYMEANGLAIS_ATC.RejectChanges()

        Me.BindingContext(Me.DsTheriaque1, ATCDDD_DOSE_USUELLE_JOUR).CancelCurrentEdit()
        Me.DsTheriaque1.ATCDDD_DOSE_USUELLE_JOUR.RejectChanges()
    End Sub

    Public Overrides Function supprimer() As Boolean
        MyBase.Supprimer()
        If Not TestFK_Used(MasterTable, "CATC_CODE_PK", txtCode.EditValue) Then
            Dim inti As Integer

            cn.Execute("DELETE FROM THERIAQUE.ATCCMP_CATC_MARCHEPUBLIC WHERE ATCCMP_CATC_CODE_FK_PK = " & cn.SQLText(txtCode.EditValue))

            For inti = 0 To DsTheriaque1.ATCDDD_DOSE_USUELLE_JOUR.Rows.Count - 1
                DsTheriaque1.ATCDDD_DOSE_USUELLE_JOUR.Rows(inti).Delete()
            Next
            Me.AtcddD_DOSE_USUELLE_JOURTableAdapter.Update(Me.DsTheriaque1)

            For inti = 0 To DsTheriaque1.SYFATC_SYNONYMEFR_ATC.Rows.Count - 1
                DsTheriaque1.SYFATC_SYNONYMEFR_ATC.Rows(inti).Delete()
            Next
            Me.SyfatC_SYNONYMEFR_ATCTableAdapter.Update(Me.DsTheriaque1)

            For inti = 0 To DsTheriaque1.SYAATC_SYNONYMEANGLAIS_ATC.Rows.Count - 1
                DsTheriaque1.SYAATC_SYNONYMEANGLAIS_ATC.Rows(inti).Delete()
            Next
            Me.SyaatC_SYNONYMEANGLAIS_ATCTableAdapter.Update(Me.DsTheriaque1)

            DsTheriaque1.CATC_CLASSEATC.Rows(0).Delete()
            Me.CatC_CLASSEATCTableAdapter.Update(Me.DsTheriaque1)
            Return True

        Else
            Return False
        End If
    End Function

#End Region

    Private Sub Frm_PharmacoTherapeutiques_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InitLkup(lkupLibellePere, MasterTable, strSSQL_CATC_CLASSEATC, True, False)
        InitLkup(lkupCDF18, CDF_CODIF, strSSQL_CDF_CODIF("18"), True)
        InitLkup(lkupCDF19, CDF_CODIF, strSSQL_CDF_CODIF("19"), True)
        InitVariable()
    End Sub

    Private Sub InitVariable()
        FirstFocus = txtCode
        MasterDataSet = Me.DsTheriaque1
        MasterTable = CATC_CLASSEATC
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.SetRowCellValue(e.RowHandle, colSYFATC_CATC_CODE_FK_PK, Me.txtCode.Text)
        ModeFiche = eMode.Modification
        UpdateStateBouton()
    End Sub

    Private Sub GV2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        GV2.SetRowCellValue(e.RowHandle, colSYAatc_Catc_CODE_FK_PK, Me.txtCode.Text)
        ModeFiche = eMode.Modification
        UpdateStateBouton()
    End Sub

    Private Sub GVDDD_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GVDDD.InitNewRow
        GVDDD.SetRowCellValue(e.RowHandle, colATCDDD_CATC_CODE_FK_PK, Me.txtCode.Text)
        ModeFiche = eMode.Modification
        UpdateStateBouton()
    End Sub

    Private Sub GV2_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV2.InvalidRowException, GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        If sender.name = "GV2" Then
            GV2.SetColumnError(colSYAATC_NOM_PK, e.ErrorText, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        ElseIf sender.name = "GV" Then
            GV.SetColumnError(colSYFATC_NOM_PK, e.ErrorText, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            sender.SetColumnError(sender.Columns(0), e.ErrorText, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
    End Sub

    Private Sub GV_RowCountChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV.RowCountChanged, GV2.RowCountChanged, GVDDD.RowCountChanged
        If ModeFiche = eMode.Consultation Then
            ModeFiche = eMode.Modification
            UpdateStateBouton()
        End If
    End Sub

    Private Sub GV_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV.RowUpdated, GV2.RowUpdated, GVDDD.RowUpdated
        If ModeFiche = eMode.Consultation Then
            ModeFiche = eMode.Modification
            UpdateStateBouton()
        End If
    End Sub

    Private Sub txtCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Validated
        ValideControl(sender, False)
    End Sub

    Protected Friend Overrides Function ValideControl(Optional ByRef Ctrl As Control = Nothing, Optional ByVal AllCtrl As Boolean = True) As Boolean
        MyBase.ValideControl(Ctrl)
        Dim codePere As String = ""

        If Ctrl.Name.ToLower = "txtCode".ToLower Or AllCtrl Then
            If ModeFiche = eMode.Ajout Then
                If Code_ATC(txtCode, MasterTable, Me.DxErrorProvider) Then
                    codePere = Code_GetCodePereATC(txtCode.Text)
                    If codePere <> "" Then
                        txtCodePere.EditValue = codePere
                        lkupLibellePere.EditValue = codePere
                    End If
                Else
                    Return False
                    DxErrorProvider.SetError(txtCode, "")
                End If
            End If
        End If

        If Ctrl.Name.ToLower = "txtlibelleFr".ToLower Or AllCtrl Then
            If FieldExist(SYFATC_SYNONYMEFR_ATC, "SYFATC_NOM_PK", txtlibelleFr.Text) Then
                DxErrorProvider.SetError(txtlibelleFr, StrValeurExist)
                Return False
            Else
                DxErrorProvider.SetError(txtlibelleFr, "")
            End If
        End If

        If Ctrl.Name.ToLower = "txtLibelleGB".ToLower Or AllCtrl Then
            If FieldExist(SYAATC_SYNONYMEANGLAIS_ATC, "SYAATC_NOM_PK", txtLibelleGB.Text) Then
                DxErrorProvider.SetError(txtLibelleGB, StrValeurExist)
                Return False
            Else
                DxErrorProvider.SetError(txtLibelleGB, "")
            End If
        End If

        Return True
    End Function

    Private Sub GV_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        If e.Row.isnew Then
            If e.Row IsNot Nothing Then
                If FieldExist(SYFATC_SYNONYMEFR_ATC, "SYFATC_NOM_PK", e.Row.row.Item(0)) Then
                    e.ErrorText = StrValeurExist
                    GV2.SetColumnError(colSYFATC_NOM_PK, StrValeurExist, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                    e.Valid = False
                End If
            End If
        End If
        If e.Row IsNot Nothing Then
            If FieldExist(MasterTable, "CATC_NOMF", e.Row.row.Item(0)) Then
                e.ErrorText = StrValeurExist
                GV.SetColumnError(colSYFATC_NOM_PK, StrValeurExist, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                e.Valid = False
            End If
        End If
    End Sub

    Private Sub GV2_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV2.ValidateRow
        If e.Row.isnew Then
            If e.Row IsNot Nothing Then
                If FieldExist(SYAATC_SYNONYMEANGLAIS_ATC, "SYAATC_NOM_PK", e.Row.row.Item(0)) Then
                    e.ErrorText = StrValeurExist
                    GV2.SetColumnError(colSYAATC_NOM_PK, StrValeurExist, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                    e.Valid = False
                End If
            End If
        End If
        If e.Row IsNot Nothing Then
            If FieldExist(MasterTable, "CATC_NOMA", e.Row.row.Item(0)) Then
                e.ErrorText = StrValeurExist
                GV2.SetColumnError(colSYAATC_NOM_PK, StrValeurExist, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                e.Valid = False
            End If
        End If
    End Sub

    Private Sub PanelSyno_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles PanelSyno.Resize
        PanelL.Width = PanelSyno.Width / 2 - 5
        PanelR.Width = PanelSyno.Width / 2 - 5
    End Sub

End Class
