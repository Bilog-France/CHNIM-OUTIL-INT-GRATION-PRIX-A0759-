Public Class Frm_SubstanceActivFils

#Region "Déclaration des variables privées"
    Private Code As String
    Private bModeDuplication As Boolean = False
#End Region

#Region " Edit Data "

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_SAC_SUBACTIVE
        f.Text = Me.Text
        f.ShowDialog()
        Code = f._Code
        If f._Code IsNot Nothing Then

            XtraTabControl1.SelectedTabPageIndex = 0

            Me.SaC_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SAC_SUBACTIVE, Code)
            Me.SyasaC_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SYASAC_SYNONYMEANGLAIS_SAC, Code)
            Me.SyfsaC_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SYFSAC_SYNONYMEFR_SUBACT, Code)
            Me.SaccaS_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SACCAS_SUBACT_CAS, Code)
            Me.SaccaS_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SACCAS_SUBACT_CAS, Code)
            Me.AdsaC_TA.FillByCode(Me.DsTheriaque_Nomenclature2.ADSAC_AUTRE_DENOMINATION_SUBAC, Code)

            Me.SacccH_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SACCCH_SUBACT_CLASSECH, Code)
            Me.SaccpH_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SACCPH_SUBACT_CLASSEPH, Code)
            Me.SaccatC_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SACCATC_SUBACT_CLASSEATC, Code)

            TestExcipient()

            bModeDuplication = False
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Function ChercherAvance() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_ADSAC_AUTRE_DENOMINATION_SUBAC & " UNION " & strSSQL_SYFSAC_SYNONYME_SUBAC
        f.Text = Me.Text
        f.ShowDialog()
        Code = f._Code
        If f._Code IsNot Nothing Then
            XtraTabControl1.SelectedTabPageIndex = 0
            Me.SaC_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SAC_SUBACTIVE, Code)
            Me.SyasaC_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SYASAC_SYNONYMEANGLAIS_SAC, Code)
            Me.SyfsaC_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SYFSAC_SYNONYMEFR_SUBACT, Code)
            Me.SaccaS_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SACCAS_SUBACT_CAS, Code)
            Me.SaccaS_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SACCAS_SUBACT_CAS, Code)
            Me.AdsaC_TA.FillByCode(Me.DsTheriaque_Nomenclature2.ADSAC_AUTRE_DENOMINATION_SUBAC, Code)

            Me.SacccH_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SACCCH_SUBACT_CLASSECH, Code)
            Me.SaccpH_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SACCPH_SUBACT_CLASSEPH, Code)
            Me.SaccatC_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SACCATC_SUBACT_CLASSEATC, Code)

            TestExcipient()

            bModeDuplication = False
            Return True
        Else
            Return False
        End If
    End Function
    ''' <summary>
    ''' Fonction: Recherche multicritères
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks>Fonction surchargée</remarks>
    Public Overrides Function ChercherMultiCriteres() As Boolean
        MyBase.ChercherMultiCriteres()
        Dim sCodeCPH As String = ""
        Dim sCodeCCH As String = ""
        Dim sCodeSAC As String = ""
        Dim sCodeATC As String = ""
        Dim sCodeRef As String = ""
        Dim sLibRef As String = ""
        Dim sTypeRef As String = ""
        Dim sCodeCAS As String = ""
        Dim f As New Frm_SacFilsMultiCriteres
        f.ShowDialog()
        If f._Validate Then
            If f._bCCH Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CCH_CLASSECHIMIQUE
                fDICO.Text = "Classes chimiques"
                fDICO.ShowDialog()
                sCodeCCH = fDICO._Code
            End If
            If f._bCPH Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CPH_CLASSEPHARMTHER
                fDICO.Text = "Classes pharmaco-thérapeutique"
                fDICO.ShowDialog()
                sCodeCPH = fDICO._Code
            End If
            If f._bSAC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SAC_SUBACTIVE
                fDICO.Text = "Substances actives"
                fDICO.ShowDialog()
                sCodeSAC = fDICO._Code
            End If
            If f._bATC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CATC_CLASSEATC
                fDICO.Text = "Classes ATC"
                fDICO.ShowDialog()
                sCodeATC = fDICO._Code
            End If
            If f._bCodeRef Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SAC_CODE_REF
                fDICO.Text = "Code Référentiel"
                fDICO.ShowDialog()
                sCodeRef = fDICO._Code
            End If

            If f._bLibRef Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SAC_LIB_REF
                fDICO.Text = "Libellé Référentiel"
                fDICO.ShowDialog()
                sLibRef = fDICO._Code
            End If

            If f._bTypeRef Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SAC_Type_REF
                fDICO.Text = "Type Référentiel"
                fDICO.ShowDialog()
                sTypeRef = fDICO._Code
            End If

            If f._bCodeCAS Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SAC_CODE_CAS
                fDICO.Text = "CODE CAS"
                fDICO.ShowDialog()
                sCodeCAS = fDICO._Code
            End If

            Dim fResultat As New Frm_Recherche
            Dim sSQL As String = ""
            sSQL &= " SELECT SAC_CODE_SQ_PK AS code, SAC_NOM AS libelle FROM THERIAQUE.SAC_SUBACTIVE "
            If sCodeSAC <> "" Then
                sSQL &= " WHERE SAC_CODE_SQ_PK IN (SELECT SAC_CODE_SQ_PK FROM THERIAQUE.SAC_SUBACTIVE WHERE SAC_CODE_SQ_PK = " & cn.SQLText(sCodeSAC) & ")"
            End If
            If sCodeCCH <> "" Then
                If sCodeSAC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SAC_CODE_SQ_PK IN (SELECT SACCCH_SAC_CODE_FK_PK FROM THERIAQUE.SACCCH_SUBACT_CLASSECH WHERE SACCCH_CCH_CODE_FK_PK = " & cn.SQLText(sCodeCCH) & ")"
            End If

            If sCodeCPH <> "" Then
                If sCodeSAC <> "" Or sCodeCCH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SAC_CODE_SQ_PK IN (SELECT SACCPH_SAC_CODE_FK_PK FROM THERIAQUE.SACCPH_SUBACT_CLASSEPH WHERE SACCPH_CPH_CODE_FK_PK = " & cn.SQLText(sCodeCPH) & ")"
            End If

            If sCodeATC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SAC_CODE_SQ_PK IN (SELECT SACCATC_SAC_CODE_FK_PK FROM THERIAQUE.SACCATC_SUBACT_CLASSEATC WHERE SACCATC_CATC_CODE_FK_PK = " & cn.SQLText(sCodeATC) & ")"
            End If

            If sCodeRef <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeATC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SAC_CODE_REF = '" & sCodeRef.Replace("'", "''") & "'"
            End If

            If sLibRef <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeATC <> "" Or sCodeRef <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SAC_Libelle_REF = '" & sLibRef.Replace("'", "''") & "'"
            End If

            If sTypeRef <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeATC <> "" Or sCodeRef <> "" Or sLibRef <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SAC_Type_REF = '" & sTypeRef.Replace("'", "''") & "'"
            End If

            If sCodeCAS <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeATC <> "" Or sCodeRef <> "" Or sLibRef <> "" Or sTypeRef <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " SAC_CODE_SQ_PK IN (SELECT SACCAS_SAC_CODE_FK_PK FROM THERIAQUE.SACCAS_SUBACT_CAS WHERE SACCAS_CAS_CODE_PK = " & cn.SQLText(sCodeCAS) & ")"
            End If

            sSQL &= " ORDER BY SAC_CODE_SQ_PK "

            fResultat._SSQL = sSQL
            fResultat.Text = Me.Text
            fResultat.ShowDialog()
            Code = fResultat._Code
            If fResultat._Code IsNot Nothing Then
                XtraTabControl1.SelectedTabPageIndex = 0

                Me.SaC_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SAC_SUBACTIVE, fResultat._Code)
                Me.SyasaC_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SYASAC_SYNONYMEANGLAIS_SAC, fResultat._Code)
                Me.SyfsaC_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SYFSAC_SYNONYMEFR_SUBACT, fResultat._Code)
                Me.SaccaS_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SACCAS_SUBACT_CAS, fResultat._Code)
                Me.SaccaS_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SACCAS_SUBACT_CAS, fResultat._Code)
                Me.AdsaC_TA.FillByCode(Me.DsTheriaque_Nomenclature2.ADSAC_AUTRE_DENOMINATION_SUBAC, fResultat._Code)

                Me.SacccH_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SACCCH_SUBACT_CLASSECH, fResultat._Code)
                Me.SaccpH_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SACCPH_SUBACT_CLASSEPH, fResultat._Code)
                Me.SaccatC_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SACCATC_SUBACT_CLASSEATC, fResultat._Code)

                TestExcipient()

                bModeDuplication = False
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Overrides Sub Ajouter()
        ClearTable()
        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        txtCode.Text = Code_MAx(SAC_SUBACTIVE, txtCode) + 1
        bModeDuplication = False
        MyBase.Ajouter()
    End Sub

    Private Function ValiderReference() As Boolean

        If (String.IsNullOrEmpty(txtCodeRef.Text) And String.IsNullOrEmpty(txtLibRef.Text)) Then
            Return True
        Else
            Return Not ReferenceExist(Integer.Parse(txtCode.Text), txtCodeRef.Text, txtLibRef.Text)
        End If

    End Function

    Public Overrides Sub Valider()


        'If (ValiderReference()) Then

        MyBase.Valider()

        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        SaC_TA.Update(Me.DsTheriaque_Nomenclature2.SAC_SUBACTIVE)

        Me.BindingContext(Me.MasterDataSet, SYASAC_SYNONYMEANGLAIS_SAC).EndCurrentEdit()
        SyasaC_TA.Update(Me.DsTheriaque_Nomenclature2.SYASAC_SYNONYMEANGLAIS_SAC)

        Me.BindingContext(Me.MasterDataSet, SYFSAC_SYNONYMEFR_SUBACT).EndCurrentEdit()
        SyfsaC_TA.Update(Me.DsTheriaque_Nomenclature2.SYFSAC_SYNONYMEFR_SUBACT)

        Me.BindingContext(Me.MasterDataSet, SACCAS_SUBACT_CAS).EndCurrentEdit()
        SaccaS_TA.Update(Me.DsTheriaque_Nomenclature2.SACCAS_SUBACT_CAS)

        Me.BindingContext(Me.MasterDataSet, ADSAC_AUTRE_DENOMINATION_SUBAC).EndCurrentEdit()
        AdsaC_TA.Update(Me.DsTheriaque_Nomenclature2.ADSAC_AUTRE_DENOMINATION_SUBAC)


        Me.BindingContext(Me.MasterDataSet, SACCCH_SUBACT_CLASSECH).EndCurrentEdit()
        SacccH_TA.Update(Me.DsTheriaque_Nomenclature2.SACCCH_SUBACT_CLASSECH)

        Me.BindingContext(Me.MasterDataSet, SACCPH_SUBACT_CLASSEPH).EndCurrentEdit()
        SaccpH_TA.Update(Me.DsTheriaque_Nomenclature2.SACCPH_SUBACT_CLASSEPH)

        Me.BindingContext(Me.MasterDataSet, SACCATC_SUBACT_CLASSEATC).EndCurrentEdit()
        SaccatC_TA.Update(Me.DsTheriaque_Nomenclature2.SACCATC_SUBACT_CLASSEATC)

        bModeDuplication = False

        'Else
        'MsgBox("Le code référence et le libellé référence existent déja dans une autre fiche.")
        'End If

    End Sub

    Public Overrides Sub Annuler()
        MyBase.Annuler()

        Me.BindingContext(Me.MasterDataSet, SACCATC_SUBACT_CLASSEATC).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.SACCATC_SUBACT_CLASSEATC.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SACCPH_SUBACT_CLASSEPH).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.SACCPH_SUBACT_CLASSEPH.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SACCCH_SUBACT_CLASSECH).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.SACCCH_SUBACT_CLASSECH.RejectChanges()


        Me.BindingContext(Me.MasterDataSet, ADSAC_AUTRE_DENOMINATION_SUBAC).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.ADSAC_AUTRE_DENOMINATION_SUBAC.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SACCAS_SUBACT_CAS).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.SACCAS_SUBACT_CAS.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SYASAC_SYNONYMEANGLAIS_SAC).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.SYASAC_SYNONYMEANGLAIS_SAC.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SYASAC_SYNONYMEANGLAIS_SAC).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.SYASAC_SYNONYMEANGLAIS_SAC.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, SYFSAC_SYNONYMEFR_SUBACT).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.SYFSAC_SYNONYMEFR_SUBACT.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.SAC_SUBACTIVE.RejectChanges()

        If bModeDuplication Then ClearTable()
        bModeDuplication = False
    End Sub

    Public Overrides Function Supprimer() As Boolean
        MyBase.Supprimer()

        DsTheriaque_Nomenclature2.SAC_SUBACTIVE.Rows(0).Delete()
        Me.SaC_TA.Update(Me.DsTheriaque_Nomenclature2)

        bModeDuplication = False
        Return True
    End Function

    Private Sub Frm_PharmacoTherapeutiques_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InitVariable()
    End Sub

    Private Sub InitVariable()
        FirstFocus = txtCode
        MasterDataSet = Me.DsTheriaque_Nomenclature2
        MasterTable = SAC_SUBACTIVE
        InitLkup(lkupSAC_GSAC_CODE_FK, GSAC_PERE_SUBACT, strSSQL_GSAC_PERE_SUBACT, True)
        InitLkup(lkupSAC_CDF_ORN_CODE_FK, CDF_CODIF, strSSQL_CDF_CODIF("11"), True)

        InitLkup(Me.rpCCH, CCH_CLASSECHIMIQUE, strSSQL_CCH_CLASSECHIMIQUE_NIVEAU, True)
        InitLkup(Me.rpCPH, CPH_CLASSEPHARMTHER, strSSQL_CPH_CLASSEPHARMTHER_NIVEAU, True)
        InitLkup(Me.rpATC, CATC_CLASSEATC, strSSQL_CATC_CLASSEATC & " Where len(CATC_CODE_PK) > 5 ", True)

        InitDataSource()

        Dim strSQL As String
        strSQL = ""
        strSQL &= " select CATC_CODE_PK  into  #Yaks from THERIAQUE.CATC_CLASSEATC "
        strSQL &= " except  "
        strSQL &= " select CATC_CATC_CODE_FK From THERIAQUE.CATC_CLASSEATC "
        strSQL &= " select #Yaks.CATC_CODE_PK as code, c.CATC_NOMF as libelle from #Yaks, THERIAQUE.CATC_CLASSEATC c "
        strSQL &= " where c.CATC_CODE_PK = #Yaks.CATC_CODE_PK "
        strSQL &= " drop table #Yaks "
        InitLkup(Me.rpATC, CATC_CLASSEATC, strSQL, True)
    End Sub

    Private Sub ClearTable()
        OnLoading = True
        Me.DsTheriaque_Nomenclature2.SACCATC_SUBACT_CLASSEATC.Clear()
        Me.DsTheriaque_Nomenclature2.SACCPH_SUBACT_CLASSEPH.Clear()
        Me.DsTheriaque_Nomenclature2.SACCCH_SUBACT_CLASSECH.Clear()

        Me.DsTheriaque_Nomenclature2.ADSAC_AUTRE_DENOMINATION_SUBAC.Clear()
        Me.DsTheriaque_Nomenclature2.SACCAS_SUBACT_CAS.Clear()
        Me.DsTheriaque_Nomenclature2.SYASAC_SYNONYMEANGLAIS_SAC.Clear()
        Me.DsTheriaque_Nomenclature2.SYFSAC_SYNONYMEFR_SUBACT.Clear()
        Me.DsTheriaque_Nomenclature2.SAC_SUBACTIVE.Clear()
        cmbExcipient.Text = "N"
        OnLoading = False
    End Sub

    ''' <summary>
    ''' Proçédure: Duplication des données à partir d'une autre fiche
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub Dupliquer()

        Dim sCodePere As String = Me.BindingContext(DsTheriaque_Nomenclature2, SAC_SUBACTIVE).Current("SAC_GSAC_CODE_FK").ToString
        Dim sOrigineSubac As String = Me.BindingContext(DsTheriaque_Nomenclature2, SAC_SUBACTIVE).Current("SAC_CDF_ORN_CODE_FK").ToString

        Dim dt5 As New DataTable
        dt5 = DsTheriaque_Nomenclature2.SACCCH_SUBACT_CLASSECH.Copy

        Dim dt6 As New DataTable
        dt6 = DsTheriaque_Nomenclature2.SACCPH_SUBACT_CLASSEPH.Copy

        Dim dt7 As New DataTable
        dt7 = DsTheriaque_Nomenclature2.SACCATC_SUBACT_CLASSEATC.Copy

        ClearTable()

        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        SetCode_MAx(MasterTable, txtCode)
        CodE = InvalideControl

        Dim drTemp As DataRow
        For iCount As Integer = 0 To dt5.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature2.Tables("SACCCH_SUBACT_CLASSECH").NewRow()
            drTemp.ItemArray = dt5.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature2.Tables("SACCCH_SUBACT_CLASSECH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt6.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature2.Tables("SACCPH_SUBACT_CLASSEPH").NewRow()
            drTemp.ItemArray = dt6.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature2.Tables("SACCPH_SUBACT_CLASSEPH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt7.Rows.Count - 1
            drTemp = DsTheriaque_Nomenclature2.Tables("SACCATC_SUBACT_CLASSEATC").NewRow()
            drTemp.ItemArray = dt7.Rows(iCount).ItemArray
            DsTheriaque_Nomenclature2.Tables("SACCATC_SUBACT_CLASSEATC").Rows.Add(drTemp)
        Next

        If sCodePere <> "" Then Me.BindingContext(DsTheriaque_Nomenclature2, SAC_SUBACTIVE).Current("SAC_GSAC_CODE_FK") = sCodePere
        If sOrigineSubac <> "" Then Me.BindingContext(DsTheriaque_Nomenclature2, SAC_SUBACTIVE).Current("SAC_CDF_ORN_CODE_FK") = sOrigineSubac
        

        ModifierCode()
        bModeDuplication = True
        MyBase.Dupliquer()
        'Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        XtraTabControl1.SelectedTabPageIndex = 0
    End Sub

    ''' <summary>
    ''' Proçédure: Modifier code Master de la fiche
    ''' </summary>
    Private Sub ModifierCode()
        'GV5
        For iCount As Integer = 0 To GV5.RowCount - 1
            GV5.SetRowCellValue(iCount, colSACCCH_SAC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV6
        For iCount As Integer = 0 To GV6.RowCount - 1
            GV6.SetRowCellValue(iCount, colSACCPH_SAC_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV7
        For iCount As Integer = 0 To GV7.RowCount - 1
            GV7.SetRowCellValue(iCount, colSACCATC_SAC_CODE_FK_PK, Me.txtCode.Text)
        Next
    End Sub
    Private Sub InitDataSource()

        GC.DataSource = DsTheriaque_Nomenclature2
        GC.DataMember = SYFSAC_SYNONYMEFR_SUBACT

        GC2.DataSource = DsTheriaque_Nomenclature2
        GC2.DataMember = SYASAC_SYNONYMEANGLAIS_SAC

        GC3.DataSource = DsTheriaque_Nomenclature2
        GC3.DataMember = SACCAS_SUBACT_CAS

        GC4.DataSource = DsTheriaque_Nomenclature2
        GC4.DataMember = ADSAC_AUTRE_DENOMINATION_SUBAC

        GC5.DataSource = DsTheriaque_Nomenclature2
        GC5.DataMember = SACCCH_SUBACT_CLASSECH

        GC6.DataSource = DsTheriaque_Nomenclature2
        GC6.DataMember = SACCPH_SUBACT_CLASSEPH

        GC7.DataSource = DsTheriaque_Nomenclature2
        GC7.DataMember = SACCATC_SUBACT_CLASSEATC
    End Sub
#End Region

#Region " GV "

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.SetFocusedRowCellValue(colSYFSAC_SAC_CODE_FK, txtCode.Text)
    End Sub

    Private Sub GV2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        GV2.SetFocusedRowCellValue(colSYASAC_SAC_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV3_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV3.InitNewRow
        GV3.SetFocusedRowCellValue(colSACCAS_SAC_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV3_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV3.ValidateRow
        If Not Code_CAS(Me.GV3.GetFocusedRowCellValue(colSACCAS_CAS_CODE_PK), GC3, Me.DxErrorProvider) Then
            e.Valid = False
            e.ErrorText = "Erreur"
        End If
    End Sub

    Private Sub GV4_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV4.InitNewRow
        GV4.SetFocusedRowCellValue(colADSAC_SAC_CODE_FK, txtCode.Text)
    End Sub

    Private Sub GV5_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV5.InitNewRow
        GV5.SetFocusedRowCellValue(colSACCCH_SAC_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV6_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV6.InitNewRow
        GV6.SetFocusedRowCellValue(colSACCPH_SAC_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV7_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV7.InitNewRow
        GV7.SetFocusedRowCellValue(colSACCATC_SAC_CODE_FK_PK, txtCode.Text)
    End Sub

#End Region

    Private Sub cmbExcipient_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExcipient.SelectedIndexChanged
        If Not OnLoading Then
            If cmbExcipient.Text = "O" Then
                Dim dt As New DataTable
                dt = cn.MySelect("Select SAU_CODE_SQ_PK From THERIAQUE.SAU_SUBAUXILIAIRE where SAU_NOM =  " & cn.SQLText(txtLibelle.Text))
                If dt IsNot Nothing Then
                    If dt.Rows.Count > 0 Then
                        txtSAC_SAU_CODE_FK.Text = dt.Rows(0)(0)
                    Else
                        OnLoading = True
                        cmbExcipient.Text = "N"
                        OnLoading = False
                    End If
                Else
                    OnLoading = True
                    cmbExcipient.Text = "N"
                    OnLoading = False
                End If
            Else
                cmbExcipient.Text = "N"
            End If
        End If
    End Sub

    Private Sub TestExcipient()
        Load_On(Me)
        Dim dt As New DataTable
        dt = cn.MySelect("Select SAU_CODE_SQ_PK FROM THERIAQUE.SAU_SUBAUXILIAIRE where SAU_NOM =  " & cn.SQLText(txtLibelle.Text))
        If dt.Rows.Count > 0 Then
            If txtSAC_SAU_CODE_FK.Text = Convert.ToString(dt.Rows(0)(0)) Then
                OnLoading = True
                cmbExcipient.Text = "O"
                OnLoading = False
            Else
                OnLoading = True
                cmbExcipient.Text = "N"
                OnLoading = False
            End If
        Else
            OnLoading = True
            cmbExcipient.Text = "N"
            OnLoading = False
        End If
        Load_Off(Me)
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Ctrl"></param>
    ''' <param name="AllCtrl"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 

    Protected Friend Overrides Function ValideControl(Optional ByRef Ctrl As Control = Nothing, Optional ByVal AllCtrl As Boolean = True) As Boolean
        Dim strSSQL As String = ""
        MyBase.ValideControl(Ctrl)
        If Ctrl.Name.ToLower = "txtLibAnglais".ToLower Or AllCtrl Then
            If txtLibAnglais.Text <> "" Then
                For i As Integer = 0 To GV2.RowCount - 1
                    If UCase(GV2.GetRowCellValue(i, colSYASAC_NOM_PK)) = UCase(txtLibAnglais.Text) Then
                        Me.DxErrorProvider.SetError(txtLibAnglais, strLibAnglais)
                        Return False
                        Exit For
                    End If
                Next
            End If
        End If
        If Ctrl.Name.ToLower = "txtLibelle".ToLower Or AllCtrl Then
            If txtLibelle.Text = "" Then
                Me.DxErrorProvider.SetError(txtLibelle, strLibelle)
                Return False
            Else
                Me.DxErrorProvider.SetError(txtLibelle, "")
            End If
        End If
        If Ctrl.Name.ToLower = "txtLibelle".ToLower Or AllCtrl Then
            strSSQL = "  SELECT * FROM THERIAQUE.SAC_SUBACTIVE WHERE SAC_CODE_SQ_PK <> " & cn.SQLText(txtCode.Text)
            strSSQL &= " AND UPPER(SAC_NOM) = " & UCase(cn.SQLText(txtLibelle.Text))
            Dim dt As DataTable = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist)
                Return False
            Else
                Me.DxErrorProvider.SetError(txtLibelle, "")
            End If
            strSSQL = "  SELECT * FROM THERIAQUE.ADSAC_AUTRE_DENOMINATION_SUBAC WHERE ADSAC_SAC_CODE_FK <> " & cn.SQLText(txtCode.Text)
            strSSQL &= " AND UPPER(ADSAC_NOM_PK) = " & UCase(cn.SQLText(txtLibelle.Text))
            dt = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist & " comme autres dénominations")
                Return False
            Else
                Me.DxErrorProvider.SetError(txtLibelle, "")
            End If
            strSSQL = "  SELECT * FROM THERIAQUE.SYFSAC_SYNONYMEFR_SUBACT WHERE SYFSAC_SAC_CODE_FK <> " & cn.SQLText(txtCode.Text)
            strSSQL &= " AND UPPER(SYFSAC_NOM_PK) = " & UCase(cn.SQLText(txtLibelle.Text))
            dt = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist & " comme synonyme français")
                Return False
            Else
                Me.DxErrorProvider.SetError(txtLibelle, "")
            End If
            strSSQL = "  SELECT * FROM THERIAQUE.SYASAC_SYNONYMEANGLAIS_SAC WHERE SYASAC_SAC_CODE_FK_PK <> " & cn.SQLText(txtCode.Text)
            strSSQL &= " AND UPPER(SYASAC_NOM_PK) = " & UCase(cn.SQLText(txtLibelle.Text))
            dt = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist & " comme synonyme anglais")
                Return False
            Else
                Me.DxErrorProvider.SetError(txtLibelle, "")
            End If
            Me.DxErrorProvider.SetError(txtLibelle, "")
            For iCount As Integer = 0 To GV.RowCount - 1
                If UCase(GV.GetRowCellValue(iCount, colSYFSAC_NOM_PK)) = UCase(Me.txtLibelle.Text) Then
                    Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist & " dans la liste des synonymes français")
                    Return False
                End If
            Next
            For iCount As Integer = 0 To GV2.RowCount - 1
                If UCase(GV2.GetRowCellValue(iCount, colSYASAC_NOM_PK)) = UCase(Me.txtLibelle.Text) Then
                    Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist & " dans la liste des synonymes anglais")
                    Return False
                End If
            Next

            For iCount As Integer = 0 To GV4.RowCount - 1
                If UCase(GV4.GetRowCellValue(iCount, colADSAC_NOM_PK)) = UCase(Me.txtLibelle.Text) Then
                    Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist & " dans la liste des autres dénominations")
                    Return False
                End If
            Next
        End If


        Return True
    End Function

    Private Sub txtLibAnglais_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLibAnglais.Validated
        ValideControl(sender, False)
    End Sub

    Private Sub cmbDisponible_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDisponible.SelectedIndexChanged
        'If cmbDisponible.Text Then
        '    'DateDisponible
        'End If
    End Sub

    Private Sub Frm_SubstanceActivFils_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        PanelR.Width = PanelSyno.Width / 2
        Panel4.Width = PanelR.Width
    End Sub

    Private Sub GV_ValidatingEditor(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV.ValidatingEditor
        If e.Value IsNot Nothing And e.Value IsNot DBNull.Value Then
            If FieldExist(SYFSAC_SYNONYMEFR_SUBACT, "SYFSAC_NOM_PK", e.Value, , " SYFSAC_SAC_CODE_FK <> " & cn.SQLText(txtCode.Text)) Then
                e.Valid = False
                e.ErrorText = StrValeurExist
            End If
            If Trim(UCase(txtLibelle.Text)) = Trim(UCase(e.Value)) Then
                e.Valid = False
                e.ErrorText = strLibelle_Synonyme
            End If
            Dim strSSQL As String
            strSSQL = "  SELECT * FROM THERIAQUE.SAU_SUBAUXILIAIRE"
            strSSQL &= " WHERE UPPER(SAU_NOM) = " & UCase(cn.SQLText(e.Value))
            Dim dt As DataTable = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                e.Valid = False
                e.ErrorText = "Cette valeur existe déjà comme libellé."
            Else
                Me.DxErrorProvider.SetError(txtLibelle, "")
            End If
            For iCount As Integer = 0 To GV2.RowCount - 1
                If UCase(GV2.GetRowCellValue(iCount, colSYASAC_NOM_PK)) = UCase(e.Value) Then
                    e.Valid = False
                    e.ErrorText = "Cette valeur existe déjà comme synonyme anglais."
                End If
            Next
            For iCount As Integer = 0 To GV4.RowCount - 1
                If UCase(GV4.GetRowCellValue(iCount, colADSAC_NOM_PK)) = UCase(e.Value) Then
                    e.Valid = False
                    e.ErrorText = "Cette valeur existe déjà comme dénomination."
                End If
            Next
        End If
    End Sub
    Private Sub GV2_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV2.ValidatingEditor
        If e.Value IsNot Nothing And e.Value IsNot DBNull.Value Then
            If FieldExist(SYASAC_SYNONYMEANGLAIS_SAC, "SYASAC_NOM_PK", e.Value, , " SYASAC_SAC_CODE_FK_PK <> " & cn.SQLText(txtCode.Text)) Then
                e.Valid = False
                e.ErrorText = StrValeurExist
            End If
            If Trim(UCase(txtLibelle.Text)) = Trim(UCase(e.Value)) Then
                e.Valid = False
                e.ErrorText = strLibelle_Synonyme
            End If
            If Trim(UCase(txtLibAnglais.Text)) = Trim(UCase(e.Value)) Then
                e.Valid = False
                e.ErrorText = strLibelleAn_Synonyme
            End If
            Dim strSSQL As String
            strSSQL = "  SELECT * FROM THERIAQUE.SAU_SUBAUXILIAIRE"
            strSSQL &= " WHERE UPPER(SAU_NOM) = " & UCase(cn.SQLText(e.Value))
            Dim dt As DataTable = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                e.Valid = False
                e.ErrorText = "Cette valeur existe déjà comme libellé."
            Else
                Me.DxErrorProvider.SetError(txtLibelle, "")
            End If
            For iCount As Integer = 0 To GV.RowCount - 1
                If UCase(GV.GetRowCellValue(iCount, colSYFSAC_NOM_PK)) = UCase(e.Value) Then
                    e.Valid = False
                    e.ErrorText = "Cette valeur existe déjà comme synonyme français."
                End If
            Next
            For iCount As Integer = 0 To GV4.RowCount - 1
                If UCase(GV4.GetRowCellValue(iCount, colADSAC_NOM_PK)) = UCase(e.Value) Then
                    e.Valid = False
                    e.ErrorText = "Cette valeur existe déjà comme dénomination."
                End If
            Next
        End If
    End Sub
    Private Sub GV4_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV4.ValidatingEditor
        If e.Value IsNot Nothing And e.Value IsNot DBNull.Value Then
            If FieldExist(ADSAC_AUTRE_DENOMINATION_SUBAC, "ADSAC_NOM_PK", e.Value, , " ADSAC_SAC_CODE_FK <> " & cn.SQLText(txtCode.Text)) Then
                e.Valid = False
                e.ErrorText = StrValeurExist
            End If
            If Trim(UCase(txtLibelle.Text)) = Trim(UCase(e.Value)) Then
                e.Valid = False
                e.ErrorText = strLibelle_Synonyme
            End If
            Dim strSSQL As String
            strSSQL = "  SELECT * FROM THERIAQUE.SAU_SUBAUXILIAIRE"
            strSSQL &= " WHERE UPPER(SAU_NOM) = " & UCase(cn.SQLText(e.Value))
            Dim dt As DataTable = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                e.Valid = False
                e.ErrorText = "Cette valeur existe déjà comme libellé."
            Else
                Me.DxErrorProvider.SetError(txtLibelle, "")
            End If
            For iCount As Integer = 0 To GV.RowCount - 1
                If UCase(GV.GetRowCellValue(iCount, colSYFSAC_NOM_PK)) = UCase(e.Value) Then
                    e.Valid = False
                    e.ErrorText = "Cette valeur existe déjà comme libellé français."
                End If
            Next
            For iCount As Integer = 0 To GV2.RowCount - 1
                If UCase(GV2.GetRowCellValue(iCount, colSYASAC_NOM_PK)) = UCase(e.Value) Then
                    e.Valid = False
                    e.ErrorText = "Cette valeur existe déjà comme libellé anglais."
                End If
            Next
        End If
    End Sub

    Private Sub txtLibelle_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLibelle.Validated
        ValideControl(sender, False)
    End Sub

End Class
