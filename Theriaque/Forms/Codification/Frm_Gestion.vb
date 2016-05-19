Public Class Frm_Gestion

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_CGE_CLASSEGESTION
        f.Text = Me.Text
        f.ShowDialog()
        If f._Code IsNot Nothing Then
            Me.CgE_CLASSEGESTIONTableAdapter.FillByCode(Me.DsTheriaque1.CGE_CLASSEGESTION, f._Code)
            Me.SycgE_SYNONYME_CLASSEGESTIONTableAdapter.FillByCode(Me.DsTheriaque1.SYCGE_SYNONYME_CLASSEGESTION, f._Code)
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Sub Ajouter()
        MyBase.Ajouter()
        Me.DsTheriaque1.SYCGE_SYNONYME_CLASSEGESTION.Clear()
        Me.DsTheriaque1.CGE_CLASSEGESTION.Clear()
        Me.BindingContext(Me.DsTheriaque1, MasterTable).AddNew()
        Me.BindingContext(Me.DsTheriaque1, MasterTable).Current("CGE_DATECR") = Now.Date
    End Sub

    Public Overrides Sub Valider()
        Dim inti As Integer
        Dim intCode As Integer
        MyBase.Valider()
        If ModeFiche = eMode.Ajout Then
            intCode = Code_MAx(MasterTable, txtCode) + 1
        Else
            If txtCode.Text <> "" Then
                intCode = txtCode.Text
            End If

        End If
        Me.BindingContext(Me.DsTheriaque1, MasterTable).Current("CGE_DATEMJ") = Now.Date
        Me.BindingContext(Me.DsTheriaque1, MasterTable).Current("CGE_CODE_SQ_PK") = intCode
        Me.BindingContext(Me.DsTheriaque1, MasterTable).EndCurrentEdit()
        CgE_CLASSEGESTIONTableAdapter.Update(Me.DsTheriaque1.CGE_CLASSEGESTION)
        For inti = 0 To DsTheriaque1.SYCGE_SYNONYME_CLASSEGESTION.Rows.Count - 1
            Me.GV.SetRowCellValue(inti, colSYCGE_CGE_CODE_FK, intCode)
        Next
        Me.BindingContext(Me.DsTheriaque1, SYCGE_SYNONYME_CLASSEGESTION).EndCurrentEdit()
        SycgE_SYNONYME_CLASSEGESTIONTableAdapter.Update(Me.DsTheriaque1.SYCGE_SYNONYME_CLASSEGESTION)
    End Sub

    Public Overrides Sub annuler()
        MyBase.Annuler()
        Me.BindingContext(Me.DsTheriaque1, SYCGE_SYNONYME_CLASSEGESTION).CancelCurrentEdit()
        Me.DsTheriaque1.SYCGE_SYNONYME_CLASSEGESTION.RejectChanges()
        Me.BindingContext(Me.DsTheriaque1, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque1.CGE_CLASSEGESTION.RejectChanges()
    End Sub

    Public Overrides Function Supprimer() As Boolean
        MyBase.Supprimer()
        If Not TestFK_Used(MasterTable, "CGH_CODE_SQ_PK", txtCode.EditValue) Then
            Dim inti As Integer
            For inti = 0 To DsTheriaque1.SYCGE_SYNONYME_CLASSEGESTION.Rows.Count - 1
                DsTheriaque1.SYCGE_SYNONYME_CLASSEGESTION.Rows(inti).Delete()
            Next
            Me.SycgE_SYNONYME_CLASSEGESTIONTableAdapter.Update(Me.DsTheriaque1)
            DsTheriaque1.CGE_CLASSEGESTION.Rows(0).Delete()
            Me.CgE_CLASSEGESTIONTableAdapter.Update(Me.DsTheriaque1)
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Frm_PharmacoTherapeutiques_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InitVariable()
    End Sub

    Private Sub InitVariable()
        FirstFocus = txtCode
        MasterDataSet = Me.DsTheriaque1
        MasterTable = CGE_CLASSEGESTION
        FirstFocus = txtLibelle
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        If txtCode.Text <> "" Then
            GV.SetRowCellValue(e.RowHandle, colSYCGE_CGE_CODE_FK, txtCode.Text)
        Else
            GV.SetRowCellValue(e.RowHandle, colSYCGE_CGE_CODE_FK, Code_MAx(MasterTable, txtCode) + 1)
        End If
        If ModeFiche <> eMode.Ajout Then
            ModeFiche = eMode.Modification
        End If
        UpdateStateBouton()
    End Sub

    Private Sub txtCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Validated, txtLibelle.Validated
        ValideControl(sender, False)
    End Sub

    Private Sub GV_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV.ValidatingEditor
        If e.Value IsNot Nothing Then
            If FieldExist(SYCGE_SYNONYME_CLASSEGESTION, "SYCGE_NOM_PK", e.Value) Then
                e.Valid = False
                e.ErrorText = StrValeurExist
            End If
            '[BFE] - 06/07/07
            ' ajoutet ce premier bloc de if qui permet de conrôler le synonyme/libellé 
            ' Tick 3166
            If Trim(UCase(txtLibelle.Text)) = Trim(UCase(e.Value)) Then
                e.Valid = False
                e.ErrorText = strLibelle_Synonyme
            End If

            Dim strSSQL As String = ""
            strSSQL = "  SELECT * FROM THERIAQUE.CGE_CLASSEGESTION WHERE "
            strSSQL &= " UPPER(CGE_NOM) = " & UCase(cn.SQLText(e.Value))
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

    Protected Friend Overrides Function ValideControl(Optional ByRef Ctrl As Control = Nothing, Optional ByVal AllCtrl As Boolean = True) As Boolean
        Dim strSSQL As String = ""
        MyBase.ValideControl(Ctrl)

        If Ctrl.Name.ToLower = "txtLibelle".ToLower Or AllCtrl Then
            'If ModeFiche = eMode.Ajout Then
            strSSQL = "  Select * from THERIAQUE.CGE_CLASSEGESTION WHERE CGE_CODE_SQ_PK <> " & cn.SQLText(txtCode.Text)
            strSSQL &= " and UPPER(CGE_NOM) = " & cn.SQLText(UCase(txtLibelle.Text))
            Dim dt As DataTable = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist)
                Return False
            Else
                Me.DxErrorProvider.SetError(txtLibelle, "")
            End If
            'End If
            '-------------------------
            '-------------------------
            Me.DxErrorProvider.SetError(txtLibelle, "")
            For intI As Integer = 0 To GV.RowCount - 1
                If GV.GetRowCellValue(intI, colSYCGE_NOM_PK) = Me.txtLibelle.Text Then
                    Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist & " dans la liste des synonymes")
                    Return False
                End If
            Next
            ''----------------------------------------------
            '' Test sur les synonymes
            ''----------------------------------------------
            ''----------------------------------------------
            strSSQL = " SELECT * FROM THERIAQUE.SYCGE_SYNONYME_CLASSEGESTION WHERE UPPER(SYCGE_NOM_PK) = " & cn.SQLText(UCase(txtLibelle.Text))
            'strSSQL &= " and SYCGE_CGE_CODE_FK = " & cn.SQLText(txtCode.Text)
            Dim dt1 As DataTable = cn.MySelect(strSSQL)
            If dt1.Rows.Count > 0 Then
                Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist)
                Return False
            End If
            For inti As Integer = 0 To Me.GV.RowCount - 1
                If GV.GetRowCellValue(inti, colSYCGE_NOM_PK) = txtLibelle.Text Then
                    Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist)
                    Return False
                End If
            Next
        End If
        Return True
    End Function

End Class
