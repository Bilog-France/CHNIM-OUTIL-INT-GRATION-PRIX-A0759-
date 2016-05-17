Public Class Frm_Rubrique_Codification


    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_RUBCDF_RUBRIQUE_CODIFICATION
        f.Text = Me.Text
        f.ShowDialog()
        If f._Code IsNot Nothing Then
            Me.RubcdF_RUBRIQUE_CODIFICATIONTableAdapter1.FillByCode(Me.DsTheriaque1.RUBCDF_RUBRIQUE_CODIFICATION, f._Code)
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Sub Ajouter()
        MyBase.Ajouter()
        Me.DsTheriaque1.RUBCDF_RUBRIQUE_CODIFICATION.Clear()
        Me.BindingContext(Me.DsTheriaque1, MasterTable).AddNew()
        Me.BindingContext(Me.DsTheriaque1, MasterTable).Current("RUBCDF_DATECR") = Now.Date
    End Sub

    Public Overrides Sub Valider()
        Me.BindingContext(Me.DsTheriaque1, MasterTable).Current("RUBCDF_DATEMJ") = Now.Date
        Me.BindingContext(Me.DsTheriaque1, MasterTable).EndCurrentEdit()
        RubcdF_RUBRIQUE_CODIFICATIONTableAdapter1.Update(Me.DsTheriaque1.RUBCDF_RUBRIQUE_CODIFICATION)
    End Sub

    Public Overrides Sub annuler()
        MyBase.Annuler()
        Me.BindingContext(Me.DsTheriaque1, RUBCDF_RUBRIQUE_CODIFICATION).CancelCurrentEdit()
        Me.DsTheriaque1.RUBCDF_RUBRIQUE_CODIFICATION.RejectChanges()
    End Sub

    Public Overrides Function Supprimer() As Boolean
        MyBase.Supprimer()
        If Not TestFK_Used(MasterTable, "RUBCDF_NUMERO_PK", txtCode.EditValue) Then
            DsTheriaque1.RUBCDF_RUBRIQUE_CODIFICATION.Rows(0).Delete()
            Me.RubcdF_RUBRIQUE_CODIFICATIONTableAdapter1.Update(Me.DsTheriaque1)
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
        MasterTable = RUBCDF_RUBRIQUE_CODIFICATION
    End Sub

    Private Sub txtCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Validated
        If txtCode.Properties.ReadOnly = False Then
            If Not Code_Alpha_Hierarchise(sender, MasterTable, Me.DxErrorProvider) Then
                sender.select()
            End If
        End If
    End Sub

    Protected Friend Overrides Function ValideControl(Optional ByRef Ctrl As Control = Nothing, Optional ByVal AllCtrl As Boolean = True) As Boolean
        MyBase.ValideControl(Ctrl)
        If Ctrl.Name.ToLower = "txtLibelle".ToLower Or AllCtrl Then
            Dim strSSQL As String
            If ModeFiche = eMode.Ajout Or ModeFiche = eMode.Modification Then
                strSSQL = "  Select * from THERIAQUE.RUBCDF_RUBRIQUE_CODIFICATION where RUBCDF_NUMERO_PK <> " & cn.SQLText(txtCode.Text)
                strSSQL &= " and UPPER(RUBCDF_NOM) = " & cn.SQLText(UCase(txtLibelle.Text))
                Dim dt As DataTable = cn.MySelect(strSSQL)
                If dt.Rows.Count > 0 Then
                    Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist)
                    Return False
                Else
                    Me.DxErrorProvider.SetError(txtLibelle, "")
                End If
            End If
        End If
        Return True
    End Function

    Private Sub TextEdit2_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLibelle.Validated
        ValideControl(sender, False)
    End Sub
End Class
