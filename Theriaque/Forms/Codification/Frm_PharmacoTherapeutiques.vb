Public Class Frm_PharmacoTherapeutiques

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_CPH_CLASSEPHARMTHER
        f.Text = Me.Text
        f.ShowDialog()
        If f._Code IsNot Nothing Then
            Me.CpH_CLASSEPHARMTHERTableAdapter1.FillByCode(Me.DsTheriaque1.CPH_CLASSEPHARMTHER, f._Code)
            Me.SYCPH_SYNONYME_CLASSEPHARMTHERTableAdapter.FillByCode(Me.DsTheriaque1.SYCPH_SYNONYME_CLASSEPHARMTHER, f._Code)
            Me.GCFils.DataSource = Nothing
            'Me.GCFils.DataSource = Me.CpH_CLASSEPHARMTHERTableAdapter1.GetDataByfils(f._Code)
            Dim strSSQL As String = "SELECT * FROM THERIAQUE." & MasterTable & " where CPH_CPH_CODE_FK = " & cn.SQLText(f._Code)
            Me.GCFils.DataSource = cn.MySelect(strSSQL)
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Sub Ajouter()
        MyBase.Ajouter()
        Me.DsTheriaque1.SYCPH_SYNONYME_CLASSEPHARMTHER.Clear()
        Me.GCFils.DataSource = Nothing
        Me.DsTheriaque1.CPH_CLASSEPHARMTHER.Clear()
        Me.BindingContext(Me.DsTheriaque1, CPH_CLASSEPHARMTHER).AddNew()
        Me.BindingContext(Me.DsTheriaque1, CPH_CLASSEPHARMTHER).Current("CPH_DATECR") = Now.Date
    End Sub

    Public Overrides Sub Valider()
        MyBase.Valider()
        Me.BindingContext(Me.DsTheriaque1, MasterTable).Current("CPH_DATEMJ") = Now.Date
        Me.BindingContext(Me.DsTheriaque1, MasterTable).EndCurrentEdit()
        CpH_CLASSEPHARMTHERTableAdapter1.Update(Me.DsTheriaque1.CPH_CLASSEPHARMTHER)
        Me.BindingContext(Me.DsTheriaque1, "SYCPH_SYNONYME_CLASSEPHARMTHER").EndCurrentEdit()
        SYCPH_SYNONYME_CLASSEPHARMTHERTableAdapter.Update(Me.DsTheriaque1.SYCPH_SYNONYME_CLASSEPHARMTHER)
        InitLkup(lkupCPH_CPH_CODE_FK, CPH_CLASSEPHARMTHER, strSSQL_CPH_CLASSEPHARMTHER, True, False)
    End Sub

    Public Overrides Sub annuler()
        MyBase.Annuler()
        Me.BindingContext(Me.DsTheriaque1, SYCPH_SYNONYME_CLASSEPHARMTHER).CancelCurrentEdit()
        Me.DsTheriaque1.SYCPH_SYNONYME_CLASSEPHARMTHER.RejectChanges()
        Me.BindingContext(Me.DsTheriaque1, CPH_CLASSEPHARMTHER).CancelCurrentEdit()
        Me.DsTheriaque1.CPH_CLASSEPHARMTHER.RejectChanges()
    End Sub

    Public Overrides Function Supprimer() As Boolean
        MyBase.Supprimer()
        If Not TestFK_Used(MasterTable, "CPH_CODE_PK", txtCode.EditValue) Then
            Dim inti As Integer
            For inti = 0 To DsTheriaque1.SYCPH_SYNONYME_CLASSEPHARMTHER.Rows.Count - 1
                DsTheriaque1.SYCPH_SYNONYME_CLASSEPHARMTHER.Rows(inti).Delete()
            Next
            Me.SYCPH_SYNONYME_CLASSEPHARMTHERTableAdapter.Update(Me.DsTheriaque1)
            DsTheriaque1.CPH_CLASSEPHARMTHER.Rows(0).Delete()
            Me.CpH_CLASSEPHARMTHERTableAdapter1.Update(Me.DsTheriaque1)
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Frm_PharmacoTherapeutiques_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InitVariable()
        InitLkup(lkupCPH_CPH_CODE_FK, MasterTable, strSSQL_CPH_CLASSEPHARMTHER, True, False)
    End Sub

    Private Sub InitVariable()
        FirstFocus = txtCode
        MasterDataSet = Me.DsTheriaque1
        MasterTable = CPH_CLASSEPHARMTHER
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.SetRowCellValue(e.RowHandle, colSYCPH_CPH_CODE_FK, Me.txtCode.Text)
        ModeFiche = eMode.Modification
        UpdateStateBouton()
    End Sub

    Private Sub GV_RowCountChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV.RowCountChanged
        If ModeFiche = eMode.Consultation Then
            ModeFiche = eMode.Modification
            UpdateStateBouton()
        End If
    End Sub

    Private Sub GV_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV.RowUpdated
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
        Dim strSSQL As String = ""

        If Ctrl.Name.ToLower = "txtCode".ToLower Or AllCtrl Then
            If ModeFiche = eMode.Ajout Then
                Dim s As StructResultCode = Code_PereFils(txtCode, MasterTable, Me.DxErrorProvider)
                If s._Validation Then
                    If s._Code IsNot Nothing Then
                        txtCodePere.EditValue = s._Code
                        lkupCPH_CPH_CODE_FK.EditValue = s._Code
                    End If
                Else
                    txtCodePere.EditValue = DBNull.Value
                    lkupCPH_CPH_CODE_FK.EditValue = DBNull.Value
                    Return False
                End If
            End If
        End If
        '[BFE] - 09/07/07
        ' ajoutet ce premier bloc de if qui permet de conrôler le synonyme/libellé 
        ' Tick 3165
        If Ctrl.Name.ToLower = "txtLibelle".ToLower Or AllCtrl Then
            'If ModeFiche = eMode.Ajout Then
            strSSQL = "  Select * from THERIAQUE.CPH_CLASSEPHARMTHER WHERE CPH_CODE_PK <> " & cn.SQLText(txtCode.Text)
            strSSQL &= " and UPPER(CPH_NOM) = " & cn.SQLText(UCase(txtLibelle.Text))
            Dim dt As DataTable = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist)
                Return False
            Else
                Me.DxErrorProvider.SetError(txtLibelle, "")
            End If
            'End If
            Me.DxErrorProvider.SetError(txtLibelle, "")
            For intI As Integer = 0 To GV.RowCount - 1
                If GV.GetRowCellValue(intI, colSYCPH_NOM_PK) = Me.txtLibelle.Text Then
                    Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist & " dans la liste des synonymes")
                    Return False
                End If
            Next
        End If
        ''----------------------------------------------
        '' Test sur les synonymes
        ''----------------------------------------------
        ''----------------------------------------------
        strSSQL = " Select * from THERIAQUE.SYCPH_SYNONYME_CLASSEPHARMTHER where UPPER(SYCPH_NOM_PK) = " & cn.SQLText(UCase(txtLibelle.Text))
        'strSSQL &= " and SYCPH_CPH_CODE_FK = " & cn.SQLText(txtCode.Text)
        Dim dt1 As DataTable = cn.MySelect(strSSQL)
        If dt1.Rows.Count > 0 Then
            Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist)
            Return False
        End If
        For inti As Integer = 0 To Me.GV.RowCount - 1
            If GV.GetRowCellValue(inti, colSYCPH_NOM_PK) = txtLibelle.Text Then
                Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist)
                Return False
            End If
        Next
        Return True
    End Function


    Private Sub GV_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV.ValidatingEditor
        If e.Value IsNot Nothing Then
            If FieldExist(SYCPH_SYNONYME_CLASSEPHARMTHER, "SYCPH_NOM_PK", e.Value, , " SYCPH_CPH_CODE_FK <> " & cn.SQLText(txtCode.Text)) Then
                e.Valid = False
                e.ErrorText = StrValeurExist
            End If
            '[BFE] - 09/07/07
            ' ajoutet ce premier bloc de if qui permet de conrôler le synonyme/libellé 
            ' Tick 3165
            If Trim(UCase(txtLibelle.Text)) = Trim(UCase(e.Value)) Then
                e.Valid = False
                e.ErrorText = strLibelle_Synonyme
            End If

            Dim strSSQL As String = ""
            strSSQL = "  SELECT * FROM THERIAQUE.CPH_CLASSEPHARMTHER WHERE "
            strSSQL &= " UPPER(CPH_NOM) = " & UCase(cn.SQLText(e.Value))
            Dim dt As DataTable = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                e.Valid = False
                e.ErrorText = StrValeurExist
            End If
            If UCase(e.Value) = UCase(txtLibelle.Text) Then
                e.Valid = False
                e.ErrorText = StrValeurExist
            End If
        End If
    End Sub

    Private Sub txtLibelle_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLibelle.Validated
        ValideControl(sender, False)
    End Sub
End Class
