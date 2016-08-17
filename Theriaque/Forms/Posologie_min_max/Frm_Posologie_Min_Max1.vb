Imports System.io
Public Class Frm_Posologie_Min_Max1


    Private Sub Frm_Posologie_Min_Max_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MasterDataSet = Me.DsTheriaque_Pos_Min_Max1
        MasterTable = "FPOMM_POSOLOGIE_MIN_MAX"
        DesactivationGrid()

    End Sub



#Region " Edit Data "

    Private Sub InitDataTable()
        'Master
        Me.DsTheriaque_Pos_Min_Max1.FPOMM_POSOLOGIE_MIN_MAX.Clear()
        Me.BindingContext(Me.DsTheriaque_Pos_Min_Max1, "FPOMM_POSOLOGIE_MIN_MAX").AddNew()
        Try
            Me.txtFicheNum.Text = Code_MAx("FPOMM_POSOLOGIE_MIN_MAX", Me.txtFicheNum) + 1
        Catch ex As Exception
            Me.txtFicheNum.Text = "1"
        End Try


    End Sub

    Private Sub FillCombos()

        Dim query2 As String = "select CPH_CODE_PK as code, CPH_NOM as libelle, CPH_CPH_CODE_FK as reference from  THERIAQUE.CPH_CLASSEPHARMTHER  "
        Dim query3 As String = "SELECT CCH_CODE_PK as code,CCH_NOM as libelle FROM THERIAQUE.CCH_CLASSECHIMIQUE   "
        Dim query4 As String = "select SAC_CDF_ORN_CODE_FK as code, SAC_NOM as libelle from  THERIAQUE.SAC_SUBACTIVE  "
        Dim query5 As String = "select SP_CODE_SQ_PK as code, SP_NOM as libelle from  THERIAQUE.SP_SPECIALITE  "
        Dim query6 As String = "select PR_CODE_SQ_PK as code, PR_NOM as libelle from  THERIAQUE.PR_PRODUIT  "
        Dim query7 As String = "select CDF_CODE_PK as code, CDF_NOM as libelle from  THERIAQUE.CDF_CODIF where CDF_NUMERO_PK = 'TP' "
        Dim query8 As String = "select CDF_CODE_PK as code, CDF_NOM as libelle from  THERIAQUE.CDF_CODIF where CDF_NUMERO_PK = '19' or CDF_NUMERO_PK = '04' or CDF_NUMERO_PK = '06' or CDF_NUMERO_PK = '20' or CDF_NUMERO_PK = '21' "
        Dim query9 As String = "select CDF_CODE_PK as code, CDF_NOM as libelle,CDF_NUMERO_PK as reference from  THERIAQUE.CDF_CODIF where CDF_NUMERO_PK = 'PA' "

        InitLkup(clphlst, "CPH_CLASSEPHARMTHER", query2, True, True)
        InitLkup(lkup_CHCCH, "CCH_CLASSECHIMIQUE", query3, True, True)
        InitLkup(lstSubact, "SAC_SUBACTIVE", query4, True, True)
        InitLkup(lstSPE, "SP_SPECIALITE", query5, True, True)
        InitLkup(lkup_CHSAU, "PR_PRODUIT", query6, True, True)
        InitLkup(lstcodif, "CDF_CODIF", query7, True, True)
        InitLkup(lstunite, "CDF_CODIF", query8, True, True)
        InitLkup(lstanthropo, "CDF_CODIF", query9, True, True)

    End Sub

    Private Sub DesactivationGrid()
        NavigatorControl(GridControl1.EmbeddedNavigator, False)
        NavigatorControl(GridControl2.EmbeddedNavigator, False)
        NavigatorControl(GridControl3.EmbeddedNavigator, False)
        NavigatorControl(GC11.EmbeddedNavigator, False)
        NavigatorControl(GC_D1.EmbeddedNavigator, False)
        NavigatorControl(GC_D2.EmbeddedNavigator, False)
        NavigatorControl(GC_D5.EmbeddedNavigator, False)

    End Sub

    Private Sub ActivationGrid()
        NavigatorControl(GridControl1.EmbeddedNavigator, True)
        NavigatorControl(GridControl2.EmbeddedNavigator, True)
        NavigatorControl(GridControl3.EmbeddedNavigator, True)
        NavigatorControl(GC11.EmbeddedNavigator, True)
        NavigatorControl(GC_D1.EmbeddedNavigator, True)
        NavigatorControl(GC_D2.EmbeddedNavigator, True)
        NavigatorControl(GC_D5.EmbeddedNavigator, True)
    End Sub

    Private Sub NavigatorControl(ByRef navigator As DevExpress.XtraEditors.ControlNavigator, ByVal val As Boolean)
        navigator.Buttons.BeginUpdate()
        Try
            navigator.Buttons.Append.Enabled = val
            navigator.Buttons.Edit.Enabled = val
            navigator.Buttons.CancelEdit.Enabled = val
            navigator.Buttons.First.Enabled = val
            navigator.Buttons.Last.Enabled = val
            navigator.Buttons.Remove.Enabled = val
            navigator.Buttons.Next.Enabled = val
            navigator.Buttons.Prev.Enabled = val
        Finally
            navigator.Buttons.EndUpdate()
        End Try
    End Sub

#End Region

#Region " Init Data  "


    Private Sub InitDeclinaison()

        Dim List5 As New System.Collections.Generic.List(Of StructGVTable)
        List5.Add(New StructGVTable("GC_D1", eDeclinaison.CPH, colFPOMMCPH_CPH_CODE_FK_PK))
        List5.Add(New StructGVTable("GC_D2", eDeclinaison.CCH, colFPOMMCCH_CCH_CODE_FK_PK))
        List5.Add(New StructGVTable("GC_D4", eDeclinaison.SAC, colCHSAC_SAC_CODE_SQ_PK_FK2))
        'List5.Add(New StructGVTable("GC15", eDeclinaison.SP, colSPCH_SP_CODE_FK_PK2))
        Dim dec5 As New ClsDeclinaison(eDeclinaison.CPH, List5)
        InitLkup(Me.clphlst, CPH_CLASSEPHARMTHER, strSSQL_CPH_CLASSEPHARMTHER, True, , , , , , dec5)

        Dim List6 As New System.Collections.Generic.List(Of StructGVTable)
        List6.Add(New StructGVTable("GC_D1", eDeclinaison.CPH, colFPOMMCPH_CPH_CODE_FK_PK))
        List6.Add(New StructGVTable("GC_D2", eDeclinaison.CCH, colFPOMMCCH_CCH_CODE_FK_PK))
        List6.Add(New StructGVTable("GC_D4", eDeclinaison.SAC, colCHSAC_SAC_CODE_SQ_PK_FK2))
        List6.Add(New StructGVTable("GC_D5", eDeclinaison.SAU, colFPOPR_PR_CODE_FK_PK))
        'List6.Add(New StructGVTable("GC15", eDeclinaison.SP, colSPCH_SP_CODE_FK_PK2))
        Dim dec6 As New ClsDeclinaison(eDeclinaison.CCH, List6)
        InitLkup(Me.lkup_CHCCH, CCH_CLASSECHIMIQUE, strSSQL_CCH_CLASSECHIMIQUE, True, , , , , , dec6)

        Dim List As New System.Collections.Generic.List(Of StructGVTable)
        List.Add(New StructGVTable("GC_D4", eDeclinaison.SAC, colCHSAC_SAC_CODE_SQ_PK_FK2))
        'List.Add(New StructGVTable("GC15", eDeclinaison.SP, colSPCH_SP_CODE_FK_PK2))
        Dim dec As New ClsDeclinaison(eDeclinaison.SAC, List)
        InitLkup(Me.lkup_CHSAC, IT1SAC_TERME1SUBACTIVE, strSSQL_SAC_SUBACTIVE, True, , , , , , dec)

        Dim List3 As New System.Collections.Generic.List(Of StructGVTable)
        List3.Add(New StructGVTable("GC_D5", eDeclinaison.SAU, colFPOPR_PR_CODE_FK_PK))
        'List3.Add(New StructGVTable("GC15", eDeclinaison.SP, colSPCH_SP_CODE_FK_PK2))
        Dim dec3 As New ClsDeclinaison(eDeclinaison.SAU, List3)
        InitLkup(Me.lkup_CHSAU, IT1SAU_TERME1SUBAUX, strSSQL_SAU_SUBAUXILIAIRE, True, , , , , , dec3)

        Dim List11 As New System.Collections.Generic.List(Of StructGVTable)
        'List11.Add(New StructGVTable("GC_D6", eDeclinaison.PR, colCHPR_PR_CODE_SQ_PK_FK2))
        'List11.Add(New StructGVTable("GC15", eDeclinaison.SP, colSPCH_SP_CODE_FK_PK2))
        'Dim dec11 As New ClsDeclinaison(eDeclinaison.PR, List11)
        'InitLkup(Me.lkup_CHPR, PR_PRODUIT, strSSQL_PR_PRODUIT, True, , , , , , dec11)

        Dim List12 As New System.Collections.Generic.List(Of StructGVTable)
        List12.Add(New StructGVTable("GC8", eDeclinaison.ATC, colCHCATC_CATC_CODE_PK_FK2))
        'List12.Add(New StructGVTable("GC15", eDeclinaison.SP, colSPCH_SP_CODE_FK_PK2))
        'Dim dec12 As New ClsDeclinaison(eDeclinaison.ATC, List12)
        'InitLkup(Me.lkup_CHCATC, CATC_CLASSEATC, strSSQL_CATC_CLASSEATC, True, , , , , , dec12)


        'InitLkup(lkup_CATC, CATC_CLASSEATC, strSSQL_CATC_CLASSEATC, True, False, True, True)

        InitLkup(Me.lkup_IT1SP, IT1SP_TERME1SPECIALITE, strSSQL_SP_SPECIALITE, True)


    End Sub



#End Region

#Region "Crud "

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        Dim strSSQL As String = "Select FPOMM_CODE_SQ_PK as code From THERIAQUE.FPOMM_POSOLOGIE_MIN_MAX"
        f._SSQL = strSSQL
        f.Text = Me.Text
        f.ShowDialog()
        f.colLibelle.Visible = False
        If f._Code IsNot Nothing Then
            OnLoading = True
            ActivationGrid()
            Me.DsTheriaque_Pos_Min_Max1.FPOMM_POSOLOGIE_MIN_MAX.Clear()

            Me.DsTheriaque_Pos_Min_Max1.FPOMMCPH_POSOMINMAX_CLPH.Clear()
            Me.DsTheriaque_Pos_Min_Max1.FPOMMCCH_POSOMINMAX_CLCH.Clear()
            Me.DsTheriaque_Pos_Min_Max1.FPOMMPR_POSOMINMAX_PROD.Clear()
            Me.DsTheriaque_Pos_Min_Max1.FPOMMSP_POSOMINMAX_SPE.Clear()
            Me.DsTheriaque_Pos_Min_Max1.FPOMMSAC_POSOMINMAX_SUBACT.Clear()
            Me.DsTheriaque_Pos_Min_Max1.FPOMMDO_POSOMINMAX_DOSES.Clear()
            Me.DsTheriaque_Pos_Min_Max1.FPOMMTP_POSOMINMAX_TERPER.Clear()

            Me.POSOLOGIE_MIN_MAX.FillByCode(Me.DsTheriaque_Pos_Min_Max1.FPOMM_POSOLOGIE_MIN_MAX, f._Code)

            Me.CLPH.FillByCode(Me.DsTheriaque_Pos_Min_Max1.FPOMMCPH_POSOMINMAX_CLPH, f._Code)
            Me.CLCH.FillByCode(Me.DsTheriaque_Pos_Min_Max1.FPOMMCCH_POSOMINMAX_CLCH, f._Code)
            Me.PROD.FillByCode(Me.DsTheriaque_Pos_Min_Max1.FPOMMPR_POSOMINMAX_PROD, f._Code)
            Me.SPE.FillByCode(Me.DsTheriaque_Pos_Min_Max1.FPOMMSP_POSOMINMAX_SPE, f._Code)
            Me.SUBACT.FillByCode(Me.DsTheriaque_Pos_Min_Max1.FPOMMSAC_POSOMINMAX_SUBACT, f._Code)
            Me.DOSES.FillByCode(Me.DsTheriaque_Pos_Min_Max1.FPOMMDO_POSOMINMAX_DOSES, f._Code)
            Me.TERPER.FillByCode(Me.DsTheriaque_Pos_Min_Max1.FPOMMTP_POSOMINMAX_TERPER, f._Code)


            FillCombos()
            OnLoading = False
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Sub Ajouter()

        InitDataTable()
        FillCombos()
        DesactivationGrid()
        MyBase.Ajouter()

    End Sub

    Public Overrides Function supprimer() As Boolean
        MyBase.Supprimer()

        Dim iCount As Integer

        'CLPH
        For iCount = 0 To DsTheriaque_Pos_Min_Max1.FPOMMCPH_POSOMINMAX_CLPH.Rows.Count - 1
            DsTheriaque_Pos_Min_Max1.FPOMMCPH_POSOMINMAX_CLPH.Rows(iCount).Delete()
        Next
        Me.CLPH.Update(DsTheriaque_Pos_Min_Max1)

        'CLCH
        For iCount = 0 To DsTheriaque_Pos_Min_Max1.FPOMMCCH_POSOMINMAX_CLCH.Rows.Count - 1
            DsTheriaque_Pos_Min_Max1.FPOMMCCH_POSOMINMAX_CLCH.Rows(iCount).Delete()
        Next
        Me.CLCH.Update(DsTheriaque_Pos_Min_Max1)

        'SUBACT
        For iCount = 0 To DsTheriaque_Pos_Min_Max1.FPOMMSAC_POSOMINMAX_SUBACT.Rows.Count - 1
            DsTheriaque_Pos_Min_Max1.FPOMMSAC_POSOMINMAX_SUBACT.Rows(iCount).Delete()
        Next
        Me.SUBACT.Update(DsTheriaque_Pos_Min_Max1)

        'SPE
        For iCount = 0 To DsTheriaque_Pos_Min_Max1.FPOMMSP_POSOMINMAX_SPE.Rows.Count - 1
            DsTheriaque_Pos_Min_Max1.FPOMMSP_POSOMINMAX_SPE.Rows(iCount).Delete()
        Next
        Me.SPE.Update(DsTheriaque_Pos_Min_Max1)

        'PROD
        For iCount = 0 To DsTheriaque_Pos_Min_Max1.FPOMMPR_POSOMINMAX_PROD.Rows.Count - 1
            DsTheriaque_Pos_Min_Max1.FPOMMPR_POSOMINMAX_PROD.Rows(iCount).Delete()
        Next
        Me.PROD.Update(DsTheriaque_Pos_Min_Max1)

        'DOSES
        For iCount = 0 To DsTheriaque_Pos_Min_Max1.FPOMMDO_POSOMINMAX_DOSES.Rows.Count - 1
            DsTheriaque_Pos_Min_Max1.FPOMMDO_POSOMINMAX_DOSES.Rows(iCount).Delete()
        Next
        Me.DOSES.Update(DsTheriaque_Pos_Min_Max1)

        'TERPER
        For iCount = 0 To DsTheriaque_Pos_Min_Max1.FPOMMTP_POSOMINMAX_TERPER.Rows.Count - 1
            DsTheriaque_Pos_Min_Max1.FPOMMTP_POSOMINMAX_TERPER.Rows(iCount).Delete()
        Next
        Me.TERPER.Update(DsTheriaque_Pos_Min_Max1)

        '' Master
        DsTheriaque_Pos_Min_Max1.FPOMM_POSOLOGIE_MIN_MAX.Rows(0).Delete()
        Me.POSOLOGIE_MIN_MAX.Update(Me.MasterDataSet)




        Return True
    End Function

    Public Overrides Sub valider()
        MyBase.Valider()

        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        Me.POSOLOGIE_MIN_MAX.Update(Me.DsTheriaque_Pos_Min_Max1.FPOMM_POSOLOGIE_MIN_MAX)

        Me.BindingContext(Me.MasterDataSet, "FPOMMCPH_POSOMINMAX_CLPH").EndCurrentEdit()
        Me.CLPH.Update(Me.DsTheriaque_Pos_Min_Max1.FPOMMCPH_POSOMINMAX_CLPH)

        Me.BindingContext(Me.MasterDataSet, "FPOMMCCH_POSOMINMAX_CLCH").EndCurrentEdit()
        Me.CLCH.Update(Me.DsTheriaque_Pos_Min_Max1.FPOMMCCH_POSOMINMAX_CLCH)

        Me.BindingContext(Me.MasterDataSet, "FPOMMSAC_POSOMINMAX_SUBACT").EndCurrentEdit()
        Me.SUBACT.Update(Me.DsTheriaque_Pos_Min_Max1.FPOMMSAC_POSOMINMAX_SUBACT)

        Me.BindingContext(Me.MasterDataSet, "FPOMMSP_POSOMINMAX_SPE").EndCurrentEdit()
        Me.SPE.Update(Me.DsTheriaque_Pos_Min_Max1.FPOMMSP_POSOMINMAX_SPE)

        Me.BindingContext(Me.MasterDataSet, "FPOMMPR_POSOMINMAX_PROD").EndCurrentEdit()
        Me.PROD.Update(Me.DsTheriaque_Pos_Min_Max1.FPOMMPR_POSOMINMAX_PROD)

        Me.BindingContext(Me.MasterDataSet, "FPOMMDO_POSOMINMAX_DOSES").EndCurrentEdit()
        Me.DOSES.Update(Me.DsTheriaque_Pos_Min_Max1.FPOMMDO_POSOMINMAX_DOSES)

        Me.BindingContext(Me.MasterDataSet, "FPOMMTP_POSOMINMAX_TERPER").EndCurrentEdit()
        Me.TERPER.Update(Me.DsTheriaque_Pos_Min_Max1.FPOMMTP_POSOMINMAX_TERPER)

        ActivationGrid()
    End Sub

    Public Overrides Sub annuler()
        'OnLoading = True
        MyBase.Annuler()

        Me.BindingContext(Me.MasterDataSet, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_Pos_Min_Max1.FPOMM_POSOLOGIE_MIN_MAX.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, "FPOMMCPH_POSOMINMAX_CLPH").CancelCurrentEdit()
        Me.DsTheriaque_Pos_Min_Max1.FPOMMCPH_POSOMINMAX_CLPH.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, "FPOMMCCH_POSOMINMAX_CLCH").CancelCurrentEdit()
        Me.DsTheriaque_Pos_Min_Max1.FPOMMCCH_POSOMINMAX_CLCH.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, "FPOMMSAC_POSOMINMAX_SUBACT").CancelCurrentEdit()
        Me.DsTheriaque_Pos_Min_Max1.FPOMMSAC_POSOMINMAX_SUBACT.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, "FPOMMSP_POSOMINMAX_SPE").CancelCurrentEdit()
        Me.DsTheriaque_Pos_Min_Max1.FPOMMSP_POSOMINMAX_SPE.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, "FPOMMPR_POSOMINMAX_PROD").CancelCurrentEdit()
        Me.DsTheriaque_Pos_Min_Max1.FPOMMPR_POSOMINMAX_PROD.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, "FPOMMDO_POSOMINMAX_DOSES").CancelCurrentEdit()
        Me.DsTheriaque_Pos_Min_Max1.FPOMMDO_POSOMINMAX_DOSES.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, "FPOMMTP_POSOMINMAX_TERPER").CancelCurrentEdit()
        Me.DsTheriaque_Pos_Min_Max1.FPOMMTP_POSOMINMAX_TERPER.RejectChanges()

        OnLoading = False
    End Sub

#End Region


#Region "initRows"

    Private Sub GV11_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV11.InitNewRow
        GV11.SetFocusedRowCellValue(colNumeroP, "TP")
        GV11.SetFocusedRowCellValue(colCHTIT_CH_CODE_FK_PK, txtFicheNum.Text)

    End Sub

    Private Sub GV_D1_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV_D1.InitNewRow
        GV_D1.SetFocusedRowCellValue(colinvisible1, txtFicheNum.Text)
    End Sub


    Private Sub GV_D2_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV_D2.InitNewRow
        GV_D2.SetFocusedRowCellValue(colFPOMM_CODE_SQ_PK1, txtFicheNum.Text)
    End Sub


    Private Sub GridView2_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView2.InitNewRow
        GridView2.SetFocusedRowCellValue(colFPOMM_CODE_SQ_PK2, txtFicheNum.Text)
    End Sub



    Private Sub GridView3_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView3.InitNewRow
        GridView3.SetFocusedRowCellValue(colFPOMM_CODE_SQ_PK4, txtFicheNum.Text)
    End Sub



    Private Sub GV_D5_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV_D5.InitNewRow
        GV_D5.SetFocusedRowCellValue(colFPOMM_CODE_SQ_PK3, txtFicheNum.Text)
    End Sub

    Private Sub GridView1_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow

        GridView1.SetFocusedRowCellValue(GridColumn2, GridView1.RowCount)
        GridView1.SetFocusedRowCellValue(GridColumn1, txtFicheNum.Text)

    End Sub

#End Region
End Class