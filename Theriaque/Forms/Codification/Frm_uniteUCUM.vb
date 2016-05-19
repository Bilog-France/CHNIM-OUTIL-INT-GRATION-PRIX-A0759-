Public Class Frm_uniteUCUM

    Private CodE As String

    Public Overrides Sub InitData()
        MyBase.InitData()
        OnLoading = True
        Declinaison_Global = True
        MasterDataSet = Me.DsTheriaque_Nomenclature21
        MasterTable = "CDFUCUM_UCUM"

    End Sub

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_UniteUCUM
        f.Text = Me.Text
        f.ShowDialog()
      
        If f._Code IsNot Nothing Then
            CodE = f._Code
            Me.DsTheriaque_Nomenclature21.CDFUCUM_UCUM.Clear()
            Me.CDFUCUM_UCUMTableAdapter.FillByCode(Me.DsTheriaque_Nomenclature21.CDFUCUM_UCUM, CodE)
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Sub Ajouter()

        Me.DsTheriaque_Nomenclature21.CDFUCUM_UCUM.Clear()
        Me.BindingContext(Me.DsTheriaque_Nomenclature21, "CDFUCUM_UCUM").AddNew()

        txtCode.Text = Get_MaxCodeIdentity("CDFUCUM_UCUM", "CDFUCUM_CODE_PK")

        MyBase.Ajouter()

    End Sub

    Public Overrides Function Supprimer() As Boolean
        MyBase.Supprimer()

        DsTheriaque_Nomenclature21.CDFUCUM_UCUM.Rows(0).Delete()
        Me.CDFUCUM_UCUMTableAdapter.Update(Me.DsTheriaque_Nomenclature21)

    End Function

    Public Overrides Sub Annuler()
        MyBase.Annuler()
        'Me.lkupUnite.Enabled = False

        Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature21.CDFUCUM_UCUM.RejectChanges()

    End Sub

    Public Overrides Sub Valider()

        MyBase.Valider()

        Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).EndCurrentEdit()
        CDFUCUM_UCUMTableAdapter.Update(Me.DsTheriaque_Nomenclature21.CDFUCUM_UCUM)

    End Sub

End Class