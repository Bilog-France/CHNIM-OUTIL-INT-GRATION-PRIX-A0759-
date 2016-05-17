Public Class Frm_CIM10

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_CIM10
        f.Text = Me.Text
        f.ShowDialog()
        If f._Code IsNot Nothing Then
            Me.CiM10TableAdapter.FillByCode(Me.DsTheriaque1.CIM10, f._Code)
            'Me.GC.DataSource = Nothing
            Me.CiM10TableAdapterFils.FillByFils(Me.DsTheriaque1.CIM10_2, f._Code)
            'GC.DataSource = Me.DsTheriaque1.CIM10_2
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Sub Ajouter()
        MyBase.Ajouter()
        Me.BindingContext(Me.DsTheriaque1, MasterTable).AddNew()
        Me.BindingContext(Me.DsTheriaque1, MasterTable).Current("CIM_DATECR") = Now.Date
        Me.DsTheriaque1.CIM10_2.Clear()
    End Sub

    Public Overrides Sub Valider()
        MyBase.Valider()
        Me.BindingContext(Me.DsTheriaque1, MasterTable).Current("CIM_DATEMJ") = Now.Date
        Me.BindingContext(Me.DsTheriaque1, MasterTable).EndCurrentEdit()
        CiM10TableAdapter.Update(Me.DsTheriaque1.CIM10)

        Me.BindingContext(Me.DsTheriaque1, MasterTable).EndCurrentEdit()
        CiM10TableAdapterFils.Update(Me.DsTheriaque1.CIM10_2)
        'If GC.DataSource Is Nothing Then
        Me.CiM10TableAdapterFils.FillByFils(Me.DsTheriaque1.CIM10_2, txtCode.Text)
        'GC.DataSource = Me.DsTheriaque1.CIM10_2
        'End If
        InitLkup(lkupCIM_CIM_CODE_FK, CIM10, strSSQL_CIM10, True, False)
    End Sub

    Public Overrides Sub annuler()
        MyBase.Annuler()
        Me.BindingContext(Me.DsTheriaque1, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque1.CIM10.RejectChanges()
        Me.DsTheriaque1.CIM10_2.RejectChanges()
    End Sub

    Public Overrides Function Supprimer() As Boolean
        MyBase.Supprimer()
        If Not TestFK_Used(MasterTable, "CIM_CODE_PK", txtCode.Text) Then
            DsTheriaque1.CIM10.Select("CIM_CODE_PK = " & cn.SQLText(txtCodeP.Text))
            DsTheriaque1.CIM10.Rows(0).Delete()
            Me.CiM10TableAdapter.Update(Me.DsTheriaque1)
            GC.DataSource = Nothing
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Frm_PharmacoTherapeutiques_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InitVariable()
        InitLkup(lkupCIM_CIM_CODE_FK, MasterTable, strSSQL_CIM10, True, False)
    End Sub

    Private Sub InitVariable()
        FirstFocus = txtCode
        MasterDataSet = Me.DsTheriaque1
        MasterTable = CIM10
    End Sub

    Private Sub GV_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV.FocusedRowChanged
        If GV.IsNewItemRow(GV.FocusedRowHandle) Then
            colCIM_CODE_PK.OptionsColumn.AllowFocus = True
        Else
            colCIM_CODE_PK.OptionsColumn.AllowFocus = False
        End If
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.SetRowCellValue(e.RowHandle, colCIM_CIM_CODE_FK, Me.txtCode.Text)
        GV.SetRowCellValue(e.RowHandle, colCIM_DATECR, Now.Date)
        ModeFiche = eMode.Modification
        UpdateStateBouton()
    End Sub

    Private Sub GV_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV.RowUpdated
        If ModeFiche = eMode.Consultation Then
            ModeFiche = eMode.Modification
            UpdateStateBouton()
            GV.SetRowCellValue(e.RowHandle, colCIM_DATEMJ, Now.Date)
        End If
    End Sub

    Private Sub txtCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodeP.Validated
        ValideControl(sender, False)
    End Sub

    Protected Friend Overrides Function ValideControl(Optional ByRef Ctrl As Control = Nothing, Optional ByVal AllCtrl As Boolean = True) As Boolean
        MyBase.ValideControl(Ctrl)

        If Ctrl.Name.ToLower = "txtCode".ToLower Or AllCtrl Then
            If ModeFiche = eMode.Ajout Then
                If Code_Alpha_Hierarchise(txtCode, MasterTable, Me.DxErrorProvider) Then
                    Return True
                Else
                    Return False
                End If
            End If
        End If
        Return True
    End Function

    Private Sub GV_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        If e.Row.isnew Then
            If FieldExist(MasterTable, "CIM_CODE_PK", NNT(GV.GetRowCellValue(GV.FocusedRowHandle, GV.FocusedColumn))) Then
                e.Valid = False
                e.ErrorText = StrValeurExist
            End If
        End If
    End Sub

End Class
