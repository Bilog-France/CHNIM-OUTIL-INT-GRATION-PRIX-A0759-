Public Class Frm_ClasseChimique

#Region " Edit data"

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_CCH_CLASSECHIMIQUE
        f.Text = Me.Text
        f.ShowDialog()
        If f._Code IsNot Nothing Then
            Me.CcH_CLASSECHIMIQUETableAdapter.FillByCode(Me.DsTheriaque1.CCH_CLASSECHIMIQUE, f._Code)
            Me.SyccH_SYNONYME_CLASSECHIMIQUETableAdapter.FillByCode(Me.DsTheriaque1.SYCCH_SYNONYME_CLASSECHIMIQUE, f._Code)
            Me.GCFils.DataSource = Me.CcH_CLASSECHIMIQUETableAdapter.GetDataByfils(f._Code)
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Sub Ajouter()
        MyBase.Ajouter()
        Me.DsTheriaque1.SYCCH_SYNONYME_CLASSECHIMIQUE.Clear()
        Me.BindingContext(Me.DsTheriaque1, CCH_CLASSECHIMIQUE).AddNew()
        Me.BindingContext(Me.DsTheriaque1, CCH_CLASSECHIMIQUE).Current("CCH_DATECR") = Now.Date
    End Sub

    Public Overrides Sub Valider()
        MyBase.Valider()

        Me.BindingContext(Me.DsTheriaque1, CCH_CLASSECHIMIQUE).Current("CCH_DATEMJ") = Now.Date
        Me.BindingContext(Me.DsTheriaque1, CCH_CLASSECHIMIQUE).EndCurrentEdit()
        CCH_CLASSECHIMIQUETableAdapter.Update(Me.DsTheriaque1.CCH_CLASSECHIMIQUE)
        Me.BindingContext(Me.DsTheriaque1, SYCCH_SYNONYME_CLASSECHIMIQUE).EndCurrentEdit()
        SyccH_SYNONYME_CLASSECHIMIQUETableAdapter.Update(Me.DsTheriaque1.SYCCH_SYNONYME_CLASSECHIMIQUE)
        InitLkup(lkupCPH_CPH_CODE_FK, MasterTable, strSSQL_CCH_CLASSECHIMIQUE, True, False)
    End Sub

    Public Overrides Sub annuler()
        MyBase.Annuler()
        Me.BindingContext(Me.DsTheriaque1, SYCCH_SYNONYME_CLASSECHIMIQUE).CancelCurrentEdit()
        Me.DsTheriaque1.SYCCH_SYNONYME_CLASSECHIMIQUE.RejectChanges()
        Me.BindingContext(Me.DsTheriaque1, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque1.CCH_CLASSECHIMIQUE.RejectChanges()
    End Sub

    Public Overrides Function supprimer() As Boolean
        MyBase.Supprimer()
        If Not TestFK_Used(MasterTable, "CCH_CODE_PK", txtCode.EditValue) Then
            Dim inti As Integer
            For inti = 0 To DsTheriaque1.SYCCH_SYNONYME_CLASSECHIMIQUE.Rows.Count - 1
                DsTheriaque1.SYCCH_SYNONYME_CLASSECHIMIQUE.Rows(inti).Delete()
            Next
            Me.SyccH_SYNONYME_CLASSECHIMIQUETableAdapter.Update(Me.DsTheriaque1)
            DsTheriaque1.CCH_CLASSECHIMIQUE.Rows(0).Delete()
            Me.CcH_CLASSECHIMIQUETableAdapter.Update(Me.DsTheriaque1)
            Return True
        Else
            Return False
        End If
    End Function

#End Region

    Private Sub Frm_PharmacoTherapeutiques_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InitLkup(lkupCPH_CPH_CODE_FK, MasterTable, strSSQL_CCH_CLASSECHIMIQUE, True, False)
        InitVariable()
    End Sub

    Private Sub InitVariable()
        FirstFocus = txtCode
        MasterDataSet = Me.DsTheriaque1
        MasterTable = CCH_CLASSECHIMIQUE
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.SetRowCellValue(e.RowHandle, colSYCCH_CCH_CODE_FK, Me.txtCode.Text)
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
            strSSQL = "  Select * from THERIAQUE.CCH_CLASSECHIMIQUE WHERE CCH_CODE_PK <> " & cn.SQLText(txtCode.Text)
            strSSQL &= " and UPPER(CCH_NOM) = " & cn.SQLText(UCase(txtLibelle.Text))
            Dim dt As DataTable = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist)
                Return False
            Else
                Me.DxErrorProvider.SetError(txtLibelle, "")
            End If
            'End If
            Me.DxErrorProvider.SetError(txtLibelle, "")

            '' Test sur les synonymes
            strSSQL = " SELECT * FROM THERIAQUE.SYCCH_SYNONYME_CLASSECHIMIQUE WHERE UPPER(SYCCH_NOM_PK) = " & cn.SQLText(UCase(txtLibelle.Text))
            Dim dt1 As DataTable = cn.MySelect(strSSQL)
            If dt1.Rows.Count > 0 Then
                Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist)
                Return False
            End If


            For intI As Integer = 0 To GV.RowCount - 1
                If GV.GetRowCellValue(intI, colSYCCH_NOM_PK) = Me.txtLibelle.Text Then
                    Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist & " dans la liste des synonymes")
                    Return False
                End If
            Next
        End If

        Return True
    End Function

    Private Sub GV_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV.ValidatingEditor
        If e.Value IsNot Nothing Then
            If FieldExist(SYCCH_SYNONYME_CLASSECHIMIQUE, "SYCCH_NOM_PK", e.Value, , " SYCCH_CCH_CODE_FK <> " & cn.SQLText(txtCode.Text)) Then
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
            strSSQL = "  SELECT * FROM THERIAQUE.CCH_CLASSECHIMIQUE WHERE "
            strSSQL &= " UPPER(CCH_NOM) = " & UCase(cn.SQLText(e.Value))
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

End Class
