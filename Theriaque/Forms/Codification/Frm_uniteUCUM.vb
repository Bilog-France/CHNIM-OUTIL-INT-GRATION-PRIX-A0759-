Public Class Frm_uniteUCUM

    Private CodE As String
    Private isNew As Boolean = False

    Public Overrides Sub InitData()
        MyBase.InitData()
        OnLoading = True
        Declinaison_Global = True
        MasterDataSet = Me.DsTheriaque_Nomenclature21
        MasterTable = "CDFUCUM_UCUM"
        Me.Label1.Text = "Unité UCUM"
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


        'Me.DsTheriaque_Nomenclature21.CDFUCUM_UCUM.Clear()

        Me.BindingContext(Me.DsTheriaque_Nomenclature21, "CDFUCUM_UCUM").AddNew()
        SetCode_MAxId(MasterTable, txtCode)
        MyBase.Ajouter()

        'DateEdit1.EditValue = Nothing
        'DateEdit1.DateTime = Now.Date
        isNew = True

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
        isNew = False

    End Sub

    Public Overrides Sub Valider()

        MyBase.Valider()
        If (isNew) Then
            DateEdit1.EditValue = Nothing
            isNew = False
        End If

        Me.BindingContext(Me.DsTheriaque_Nomenclature21, MasterTable).EndCurrentEdit()
        Try
            CDFUCUM_UCUMTableAdapter.Update(Me.DsTheriaque_Nomenclature21.CDFUCUM_UCUM)

        Catch ex As Exception
            Me.CDFUCUM_UCUMTableAdapter.FillByCode(Me.DsTheriaque_Nomenclature21.CDFUCUM_UCUM, txtCode.Text)

        End Try
        
    End Sub

    Private Sub Frm_uniteUCUM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.CDFUCUM_UCUMTableAdapter.Fill(Me.DsTheriaque_Nomenclature21.CDFUCUM_UCUM)
        InitData()
    End Sub

    Private Sub InitVariable()
        'FirstFocus = txtCode
        'MasterDataSet = Me.DsTheriaque1
        'MasterTable = CDF_CODIF
        'Me.Label1.Text = LibNomenclature(_Code_CDF)
        'InitLkup(rpCIM10, CIM10, strSSQL_CIM10, True, True, True, , True)
        'Me.PanPere.Visible = True
        'InitLkup(lkupCDF_CODE_PK, CDF_CODIF, strSSQL_CDF_CODIF(_Code_CDF), True, False)
        'If _Code_CDF = "NN" Then
        '    InitLkup(rpNaturePrincipale, CDF_CODIF, strSSQL_CDF_CODIF("NP"), True, True)
        'End If
    End Sub

    Private Sub txtLibelle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLibelle.TextChanged
        btValider.Enabled = True
        btAnnuler.Enabled = True
        btAjouter.Enabled = False
        btSupprimer.Enabled = False
        btFermer.Enabled = False
        btChercher.Enabled = False
    End Sub


    Private Function getIdentity() As Integer

        Dim dt As DataTable
        dt = cn.MySelect("SELECT IDENT_CURRENT( '[theriaque].[theriaque].[CDFUCUM_UCUM]' )")

        Return dt.Rows(0)(0) + 1

    End Function

End Class