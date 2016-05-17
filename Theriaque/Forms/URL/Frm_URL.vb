''' <summary>
''' Created By [BFE]
''' </summary>
''' <remarks> Paramétrage des Urls
''' </remarks>
Public Class Frm_URL

#Region "Déclaration des variables privées"
    Private CodE As String
    Public _Code As Integer = Nothing ' charger la fiche depuis l'extérieur
#End Region

#Region " Init Data  "

    Public Overrides Sub InitData()
        MyBase.InitData()
        OnLoading = True
        MasterDataSet = Me.DsTheriaqueURL
        MasterTable = URL_ADRESSE
        Code = InvalideControl
        FirstFocus = txtCode
        If _Code <> Nothing Then
            Load_On(Me)
            Open_Fiche(_Code)
            ModeFiche = eMode.Consultation
            UpdateStateBouton()
            Initcomponent()
            Load_Off(Me)
        End If
        OnLoading = False
    End Sub

#End Region

#Region " Edit Data "

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_URL
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            OnLoading = True
            EmptyDataTable()
            Me.UrL_ADRESSETA.FillByCode(Me.DsTheriaqueURL.URL_ADRESSE, f._Code)
            OnLoading = False
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Sub Ajouter()
        EmptyDataTable()
        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        SetCode_MAx(MasterTable, txtCode)
        CodE = InvalideControl
        MyBase.Ajouter()
    End Sub

    Public Overrides Function supprimer() As Boolean
        MyBase.Supprimer()
        Dim iCount As Integer

        For iCount = 0 To DsTheriaqueURL.URL_ADRESSE.Rows.Count - 1
            DsTheriaqueURL.URL_ADRESSE.Rows(iCount).Delete()
        Next
        Me.UrL_ADRESSETA.Update(DsTheriaqueURL)
        If ChkAuto.Checked = True Then
            cn.Execute("DELETE FROM THERIAQUE.SPURL_SPECIALITE_ADRESSE WHERE SPURL_CODE_URL_PK_FK =" & CodE)
        End If
        Return True
    End Function

    Public Overrides Sub valider()
        MyBase.Valider()
        

        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        UrL_ADRESSETA.Update(Me.DsTheriaqueURL.URL_ADRESSE)
        If ChkAuto.Checked = True Then
            Dim dt As DataTable = cn.MySelect("SELECT * FROM THERIAQUE.SP_SPECIALITE")
            Dim sSql As String = ""
            For iCount As Integer = 0 To dt.Rows.Count - 1
                ProgressBar.Visible = True
                ProgressBar.Value += 1
                ProgressBar.Maximum = dt.Rows.Count
                sSql = "SELECT " & Txt_NomChamp.Text
                sSql &= " FROM THERIAQUE.SP_SPECIALITE WHERE SP_CODE_SQ_PK = " & cn.SQLText(dt.Rows(iCount)("SP_CODE_SQ_PK"))
                If Not cn.ExecuteScalar(sSql) Is DBNull.Value Then
                    Dim sUrlFixe As String = Memo_UrlFixe.Text & Replace(cn.ExecuteScalar(sSql), " ", "")
                    If ModeFiche = eMode.Ajout Then
                        sSql = "INSERT INTO THERIAQUE.SPURL_SPECIALITE_ADRESSE VALUES(" & dt.Rows(iCount)("SP_CODE_SQ_PK") & ", " & txtCode.Text & ", " & cn.SQLText(sUrlFixe) & ")"
                    Else
                        sSql = "UPDATE THERIAQUE.SPURL_SPECIALITE_ADRESSE SET SPURL_ADRESSE=" & cn.SQLText(sUrlFixe) & " WHERE SPURL_CODE_SP_PK_FK=" & dt.Rows(iCount)("SP_CODE_SQ_PK") & " AND SPURL_CODE_URL_PK_FK=" & txtCode.Text
                    End If
                    cn.Execute(sSql)
                End If
            Next
            ProgressBar.Value = 0
            ProgressBar.Visible = False
        End If
    End Sub

    Public Overrides Sub annuler()
        OnLoading = True
        MyBase.Annuler()
        Me.BindingContext(DsTheriaqueURL, URL_ADRESSE).CancelCurrentEdit()
        Me.DsTheriaqueURL.URL_ADRESSE.RejectChanges()

        OnLoading = False
    End Sub

    Private Sub EmptyDataTable()
        'Master
        Me.DsTheriaqueURL.URL_ADRESSE.Clear()
    End Sub

#End Region



    Private Sub Open_Fiche(ByVal CodE1 As Integer)
        OnLoading = True
        CodE = _Code
        EmptyDataTable()
        Me.UrL_ADRESSETA.FillByCode(Me.DsTheriaqueURL.URL_ADRESSE, CodE1)
        OnLoading = False
    End Sub

    Private Sub Txt_typeURL_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_typeURL.Validated
        If Txt_typeURL.Text = "" Then
            DxErrorProvider.SetError(Txt_typeURL, strType)
            Exit Sub
        Else
            If ModeFiche = eMode.Ajout Then
                If IfTypeURLExist(Txt_typeURL.Text) Then
                    DxErrorProvider.SetError(Txt_typeURL, strTypeExist)
                    Exit Sub
                Else
                    DxErrorProvider.SetError(Txt_typeURL, "")
                End If
            Else
                DxErrorProvider.SetError(Txt_typeURL, "")
            End If
        End If
    End Sub

    Private Sub Txt_NomChamp_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_NomChamp.Validated
        If Txt_NomChamp.Text = "" Then
            DxErrorProvider.SetError(Txt_NomChamp, strChamp)
            Exit Sub
        Else
            DxErrorProvider.SetError(Txt_NomChamp, "")
        End If
        If Not cn.ExecuteIsValide("SELECT " & Txt_NomChamp.Text & " FROM THERIAQUE.SP_SPECIALITE") Then
            DxErrorProvider.SetError(Txt_NomChamp, strChampUrl)
            Exit Sub
        End If
    End Sub

    Private Sub Memo_UrlFixe_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Memo_UrlFixe.Validated
        If Memo_UrlFixe.Text = "" Then
            DxErrorProvider.SetError(Memo_UrlFixe, strUrl)
            Exit Sub
        Else
            DxErrorProvider.SetError(Memo_UrlFixe, "")
        End If
    End Sub
    Private Function IfTypeURLExist(ByVal sTypeUrl As String) As Boolean
        Dim dt As DataTable = cn.MySelect("SELECT * FROM THERIAQUE.URL_ADRESSE WHERE URL_TYPE = " & cn.SQLText(sTypeUrl))
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Protected Friend Overrides Function ValideControl(Optional ByRef Ctrl As Control = Nothing, Optional ByVal AllCtrl As Boolean = True) As Boolean
        MyBase.ValideControl(Ctrl)
        If Txt_typeURL.Text = "" Then
            DxErrorProvider.SetError(Txt_typeURL, strType)
            Exit Function
        Else
            If ModeFiche = eMode.Ajout Then
                If IfTypeURLExist(Txt_typeURL.Text) Then
                    DxErrorProvider.SetError(Txt_typeURL, strTypeExist)
                    Exit Function
                Else
                    DxErrorProvider.SetError(Txt_typeURL, "")
                End If
            Else
                DxErrorProvider.SetError(Txt_typeURL, "")
            End If
        End If
        If Txt_NomChamp.Text = "" Then
            DxErrorProvider.SetError(Txt_NomChamp, strChamp)
            Exit Function
        Else
            DxErrorProvider.SetError(Txt_NomChamp, "")
        End If
        If Not cn.ExecuteIsValide("SELECT " & Txt_NomChamp.Text & " FROM THERIAQUE.SP_SPECIALITE") Then
            DxErrorProvider.SetError(Txt_NomChamp, strChampUrl)
            Exit Function
        Else
            DxErrorProvider.SetError(Txt_NomChamp, "")
        End If
        If Memo_UrlFixe.Text = "" Then
            DxErrorProvider.SetError(Memo_UrlFixe, strUrl)
            Exit Function
        Else
            DxErrorProvider.SetError(Memo_UrlFixe, "")
        End If
        Return True
    End Function
End Class
