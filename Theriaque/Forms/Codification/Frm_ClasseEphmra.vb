Public Class Frm_ClasseEphmra

#Region " Edit data "

    Public Overrides Function Chercher() As Boolean
        Dim strSSQL As String = ""
        Dim strCode As String = ""

        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_CEPH_CLASSEEPHMRA
        f.Text = Me.Text
        f.ShowDialog()
        If f._Code IsNot Nothing Then
            Me.CepH_CLASSEEPHMRATableAdapter.FillByCode(Me.DsTheriaque2.CEPH_CLASSEEPHMRA, f._Code)
            Me.SyaepH_SYNONYMEANGLAIS_EPHMRATableAdapter.FillByCode(Me.DsTheriaque2.SYAEPH_SYNONYMEANGLAIS_EPHMRA, f._Code)
            Me.SyfepH_SYNONYMEFR_EPHMRATableAdapter.FillByCode(Me.DsTheriaque2.SYFEPH_SYNONYMEFR_EPHMRA, f._Code)
            Me.GCFils.DataSource = CepH_CLASSEEPHMRATableAdapterFils.GetDataByFils(f._Code)
        End If
        Return True
    End Function

    Public Overrides Sub Ajouter()
        MyBase.Ajouter()
        Me.DsTheriaque2.CEPH_CLASSEEPHMRA.Clear()
        Me.BindingContext(Me.DsTheriaque2, MasterTable).AddNew()
        Me.BindingContext(Me.DsTheriaque2, MasterTable).Current("CEPH_DATECR") = Now.Date

        Me.DsTheriaque2.SYAEPH_SYNONYMEANGLAIS_EPHMRA.Clear()
        Me.DsTheriaque2.SYFEPH_SYNONYMEFR_EPHMRA.Clear()
        Me.GCFils.DataSource = Nothing
    End Sub

    Public Overrides Sub Valider()
        MyBase.Valider()

        Me.BindingContext(Me.DsTheriaque2, MasterTable).Current("CEPH_DATEMJ") = Now.Date
        Me.BindingContext(Me.DsTheriaque2, MasterTable).EndCurrentEdit()
        CepH_CLASSEEPHMRATableAdapter.Update(Me.DsTheriaque2.CEPH_CLASSEEPHMRA)

        Me.BindingContext(Me.DsTheriaque2, SYFEPH_SYNONYMEFR_EPHMRA).EndCurrentEdit()
        SyfepH_SYNONYMEFR_EPHMRATableAdapter.Update(Me.DsTheriaque2.SYFEPH_SYNONYMEFR_EPHMRA)

        Me.BindingContext(Me.DsTheriaque2, SYAEPH_SYNONYMEANGLAIS_EPHMRA).EndCurrentEdit()
        SyaepH_SYNONYMEANGLAIS_EPHMRATableAdapter.Update(Me.DsTheriaque2.SYAEPH_SYNONYMEANGLAIS_EPHMRA)

        InitLkup(lkupLibellePere, MasterTable, strSSQL_CEPH_CLASSEEPHMRA, True, False)
    End Sub

    Public Overrides Sub annuler()
        MyBase.Annuler()
        Me.BindingContext(Me.DsTheriaque2, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque2.CEPH_CLASSEEPHMRA.RejectChanges()
        Me.BindingContext(Me.DsTheriaque2, SYFEPH_SYNONYMEFR_EPHMRA).CancelCurrentEdit()
        Me.DsTheriaque2.SYFEPH_SYNONYMEFR_EPHMRA.RejectChanges()
        Me.BindingContext(Me.DsTheriaque2, SYAEPH_SYNONYMEANGLAIS_EPHMRA).CancelCurrentEdit()
        Me.DsTheriaque2.SYAEPH_SYNONYMEANGLAIS_EPHMRA.RejectChanges()
    End Sub

    Public Overrides Function supprimer() As Boolean
        MyBase.Supprimer()
        If Not TestFK_Used(MasterTable, "CEPH_CODE_PK", txtCode.EditValue) Then
            Dim inti As Integer

            For inti = 0 To DsTheriaque2.SYFEPH_SYNONYMEFR_EPHMRA.Rows.Count - 1
                DsTheriaque2.SYFEPH_SYNONYMEFR_EPHMRA.Rows(inti).Delete()
            Next
            Me.SyfepH_SYNONYMEFR_EPHMRATableAdapter.Update(Me.DsTheriaque2)

            For inti = 0 To DsTheriaque2.SYAEPH_SYNONYMEANGLAIS_EPHMRA.Rows.Count - 1
                DsTheriaque2.SYAEPH_SYNONYMEANGLAIS_EPHMRA.Rows(inti).Delete()
            Next
            Me.SyaepH_SYNONYMEANGLAIS_EPHMRATableAdapter.Update(Me.DsTheriaque2)

            DsTheriaque2.CEPH_CLASSEEPHMRA.Rows(0).Delete()
            Me.CepH_CLASSEEPHMRATableAdapter.Update(Me.DsTheriaque2)
            Return True

        Else
            Return False
        End If
    End Function

#End Region

    Private Sub Frm_PharmacoTherapeutiques_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InitLkup(lkupLibellePere, MasterTable, strSSQL_CEPH_CLASSEEPHMRA, True, False)
        InitVariable()
    End Sub

    Private Sub InitVariable()
        FirstFocus = txtCode
        MasterDataSet = Me.DsTheriaque2
        MasterTable = CEPH_CLASSEEPHMRA
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.SetRowCellValue(e.RowHandle, colSYFEPH_CEPH_CODE_FK, Me.txtCode.Text)
        ModeFiche = eMode.Modification
        UpdateStateBouton()
    End Sub

    Private Sub GV2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        GV2.SetRowCellValue(e.RowHandle, colSYAEPH_CEPH_CODE_FK_PK, Me.txtCode.Text)
        ModeFiche = eMode.Modification
        UpdateStateBouton()
    End Sub

    Private Sub GV2_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV2.InvalidRowException, GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        If sender.name = "GV2" Then
            GV2.SetColumnError(colSYAEPH_NOM_PK, e.ErrorText, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            GV.SetColumnError(colSYFEPH_NOM_PK, e.ErrorText, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
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
                If Code_Ephmra(txtCode, MasterTable, Me.DxErrorProvider) Then
                    codePere = Code_GetCodePereEphmra(txtCode.Text)
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
            If FieldExist(MasterTable, txtlibelleFr, Me.txtCode) Or FieldExist(SYFEPH_SYNONYMEFR_EPHMRA, "SYFEPH_NOM_PK", txtlibelleFr.Text) Then
                DxErrorProvider.SetError(txtlibelleFr, StrValeurExist)
                Return False
            Else
                DxErrorProvider.SetError(txtlibelleFr, "")
            End If
        End If

        If Ctrl.Name.ToLower = "txtLibelleGB".ToLower Or AllCtrl Then
            If FieldExist(MasterTable, txtLibelleGB, Me.txtCode) Or FieldExist(SYAEPH_SYNONYMEANGLAIS_EPHMRA, "SYAEPH_NOM_PK", txtLibelleGB.Text) Then
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
                If FieldExist(SYFEPH_SYNONYMEFR_EPHMRA, "SYFEPH_NOM_PK", e.Row.row.Item(0)) Then
                    e.ErrorText = StrValeurExist
                    GV2.SetColumnError(colSYFEPH_NOM_PK, StrValeurExist, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                    e.Valid = False
                End If
            End If
        End If
        If e.Row IsNot Nothing Then
            If FieldExist(MasterTable, "CEPH_NOMF", e.Row.row.Item(0)) Then
                e.ErrorText = StrValeurExist
                GV.SetColumnError(colSYFEPH_NOM_PK, StrValeurExist, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                e.Valid = False
            End If
        End If
    End Sub

    Private Sub GV2_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV2.ValidateRow
        If e.Row.isnew Then
            If e.Row IsNot Nothing Then
                If FieldExist(SYAEPH_SYNONYMEANGLAIS_EPHMRA, "SYAEPH_NOM_PK", e.Row.row.Item(0)) Then
                    e.ErrorText = StrValeurExist
                    GV2.SetColumnError(colSYAEPH_NOM_PK, StrValeurExist, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                    e.Valid = False
                End If
            End If
        End If
        If e.Row IsNot Nothing Then
            If FieldExist(MasterTable, "CEPH_NOMA", e.Row.row.Item(0)) Then
                e.ErrorText = StrValeurExist
                GV2.SetColumnError(colSYAEPH_NOM_PK, StrValeurExist, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                e.Valid = False
            End If
        End If
    End Sub

    Private Sub PanelSyno_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles PanelSyno.Resize
        PanelL.Width = PanelSyno.Width / 2 - 5
        PanelR.Width = PanelSyno.Width / 2 - 5
    End Sub

End Class
