Imports DevExpress.Data.Filtering
Imports DevExpress.XtraGrid.Columns
Public Class Frm_Generique

    Dim CodE As String = InvalideControl
    Dim dv As New DataView
    Dim dvSau As New DataView
    Dim dvSau1 As New DataView
    Dim dvCosau As New DataView

    Dim str_SSQL_COSAU As String = ""
    Dim str_SSQL_COSAU2 As String = ""

    Private Tab_lkup1 As Boolean = False
    Private Tab_TA1 As Boolean = False
    Private Tab_lkup2 As Boolean = False
    Private Tab_TA2 As Boolean = False

#Region " Edit data"

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_SPGREFR_GROUPE_SPE_REF()
        f.Text = Me.Text
        f.ShowDialog()
        If f._Code IsNot Nothing Then
            XtraTabControl1.SelectedTabPageIndex = 0
            OnLoading = True

            ClearTable()

            Dim SuppSSQL1 As String = "  SP_CODE_SQ_PK not in (Select distinct(SPGREFR_SP_CODE_FK_PK) from THERIAQUE.SPGREFR_GROUPE_SPE_REF)"
            Dim SuppSSQL2 As String = "  SP_CODE_SQ_PK in (Select distinct(SPGREFR_SP_CODE_FK_PK) from THERIAQUE.SPGREFR_GROUPE_SPE_REF where SPGREFR_GREF_CODE_FK_PK = " & f._Code & ")"


            InitLkup(Me.rpGen, SP_SPECIALITE, strSSQL_SP_SPECIALITE & " where " & SuppSSQL1 & " UNION " & strSSQL_SP_SPECIALITE & " where " & SuppSSQL2, True)
            'InitLkup(Me.rpSPG, SP_SPECIALITE, strSSQL_SP_SPECIALITE & " where SP_TYPE_SPE  = 'G' " & SuppSSQL1 & " UNION " & strSSQL_SP_SPECIALITE & " where SP_TYPE_SPE  = 'G' " & SuppSSQL2, True)


            Me.GreF_TA.FillByCode(Me.DsTheriaque_Nomenclature2.GREF_GROUPE_SPECIALITE_REF, f._Code)
            Me.SpgrefR_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SPGREFR_GROUPE_SPE_REF, f._Code, Me.DateEditCrGroupe.Text)
            Me.PregreF_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PREGREF_PRE_GROUPE_REF, f._Code, Me.DateEditCrGroupe.Text)
            Me.GreftX_TA.FillByCode(Me.DsTheriaque_Nomenclature2.GREFTX_TEXTE_GROUPE_REF, f._Code)

            GC.DataSource = Nothing
            GC.DataSource = cn.MySelect(str_SSQL_COSAU & " and COSAU_GREF_CODE_FK =" & txtCode.Text)

            GC6.DataSource = Nothing
            GC6.DataSource = cn.MySelect(str_SSQL_COSAU & " and COSAU_GREF_CODE_FK =" & txtCode.Text)

            CodE = txtCode.Text

            Dim strSSQL As String = "  Select SP_DATEJOGENE from THERIAQUE.SP_SPECIALITE where SP_GREF_FK = " & cn.SQLText(txtCode.Text)
            Dim dt As DataTable = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                If dt.Rows(0)(0) IsNot DBNull.Value Then DateEditJO.Text = Convert.ToDateTime(dt.Rows(0)(0))
            End If


            Tab_TA1 = False
            Tab_TA2 = False

            OnLoading = False
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Sub Ajouter()

        Dim SuppSSQL As String = "  where SP_CODE_SQ_PK not in (Select distinct(SPGREFR_SP_CODE_FK_PK) from THERIAQUE.SPGREFR_GROUPE_SPE_REF UNION Select distinct(SPGREFG_SP_CODE_FK_PK) from THERIAQUE.SPGREFG_GROUPE_SPE_GENE)"
        InitLkup(Me.rpGen, SP_SPECIALITE, strSSQL_SP_SPECIALITE & SuppSSQL, True, True)

        SuppSSQL = "  where SP_CODE_SQ_PK not in (Select distinct(SPGREFG_SP_CODE_FK_PK) from THERIAQUE.SPGREFG_GROUPE_SPE_GENE UNION Select distinct(SPGREFR_SP_CODE_FK_PK) from THERIAQUE.SPGREFR_GROUPE_SPE_REF)"
        InitLkup(Me.rpSPG, SP_SPECIALITE, strSSQL_SP_SPECIALITE & SuppSSQL, True, True)

        ClearTable()
        Me.BindingContext(Me.DsTheriaque_Nomenclature2, GREF_GROUPE_SPECIALITE_REF).AddNew()
        Me.txtCode.Text = Code_MAx(GREF_GROUPE_SPECIALITE_REF, Me.txtCode) + 1

        DateEditJO.Text = Now.Date
        'MyBase.Ajouter()
    End Sub

    Public Overrides Sub Valider()
        'MyBase.Valider()

        DateEditJO_Validated(DateEditJO, Nothing)

        Me.BindingContext(Me.DsTheriaque_Nomenclature2, MasterTable).EndCurrentEdit()
        GreF_TA.Update(Me.DsTheriaque_Nomenclature2.GREF_GROUPE_SPECIALITE_REF)

        Me.BindingContext(Me.DsTheriaque_Nomenclature2, GREFTX_TEXTE_GROUPE_REF).EndCurrentEdit()
        GreftX_TA.Update(Me.DsTheriaque_Nomenclature2.GREFTX_TEXTE_GROUPE_REF)

        Me.BindingContext(Me.DsTheriaque_Nomenclature2, SPGREFG_GROUPE_SPE_GENE).EndCurrentEdit()
        SpgrefG_TA.Update(Me.DsTheriaque_Nomenclature2.SPGREFG_GROUPE_SPE_GENE)

        Me.BindingContext(Me.DsTheriaque_Nomenclature2, SPGREFR_GROUPE_SPE_REF).EndCurrentEdit()
        SpgrefR_TA.Update(Me.DsTheriaque_Nomenclature2.SPGREFR_GROUPE_SPE_REF)

        Me.BindingContext(Me.DsTheriaque_Nomenclature2, PREGREF_PRE_GROUPE_REF).EndCurrentEdit()
        PregreF_TA.Update(Me.DsTheriaque_Nomenclature2.PREGREF_PRE_GROUPE_REF)

        Me.BindingContext(Me.DsTheriaque_Nomenclature2, PREGREF_PRE_GROUPE_REF).EndCurrentEdit()
        PregreF1_TA.Update(Me.DsTheriaque_Nomenclature2.PREGREF_PRE_GROUPE_REF1)

        Me.BindingContext(Me.DsTheriaque_Nomenclature2, COSAU_COMPO_SUBAUX).EndCurrentEdit()
        CosaU_TA.Update(Me.DsTheriaque_Nomenclature2.COSAU_COMPO_SUBAUX)

        'Me.BindingContext(Me.DsTheriaque_Nomenclature2, SP_SPECIALITE).EndCurrentEdit()
        'SP_TA.Update(Me.DsTheriaque_Nomenclature2.SP_SPECIALITE)

        If ModeFiche = eMode.Ajout Then
            Dim SuppSSQL1 As String = "   SP_CODE_SQ_PK not in (Select distinct(SPGREFR_SP_CODE_FK_PK) from THERIAQUE.SPGREFR_GROUPE_SPE_REF)"
            Dim SuppSSQL2 As String = "   SP_CODE_SQ_PK in (Select distinct(SPGREFR_SP_CODE_FK_PK) from THERIAQUE.SPGREFR_GROUPE_SPE_REF where SPGREFR_GREF_CODE_FK_PK = " & txtCode.Text & ")"
            InitLkup(Me.rpGen, SP_SPECIALITE, strSSQL_SP_SPECIALITE & " where " & SuppSSQL1 & " UNION " & strSSQL_SP_SPECIALITE & " where " & SuppSSQL2, True)

            SuppSSQL1 = "   SP_CODE_SQ_PK not in (Select distinct(SPGREFG_SP_CODE_FK_PK) from THERIAQUE.SPGREFG_GROUPE_SPE_GENE)"
            SuppSSQL2 = "   SP_CODE_SQ_PK in (Select distinct(SPGREFG_SP_CODE_FK_PK) from THERIAQUE.SPGREFG_GROUPE_SPE_GENE where SPGREFG_GREF_CODE_FK_PK = " & txtCode.Text & ")"
            InitLkup(Me.rpSPG, SP_SPECIALITE, strSSQL_SP_SPECIALITE & " where " & SuppSSQL1 & " UNION " & strSSQL_SP_SPECIALITE & " where " & SuppSSQL2, True)
        End If
        Update_Specialite()
        Me.SpgrefG_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SPGREFG_GROUPE_SPE_GENE, txtCode.Text, Me.DateEditCrGroupe.Text)
        Me.SpgrefR_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SPGREFR_GROUPE_SPE_REF, txtCode.Text, Me.DateEditCrGroupe.Text)
    End Sub

    Public Overrides Sub Annuler()
        MyBase.Annuler()

        Me.BindingContext(Me.DsTheriaque_Nomenclature2, SP_SPECIALITE).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.SP_SPECIALITE.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_Nomenclature2, COSAU_COMPO_SUBAUX).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.COSAU_COMPO_SUBAUX.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_Nomenclature2, SPGREFG_GROUPE_SPE_GENE).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.SPGREFG_GROUPE_SPE_GENE.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_Nomenclature2, SPGREFR_GROUPE_SPE_REF).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.SPGREFR_GROUPE_SPE_REF.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_Nomenclature2, GREFTX_TEXTE_GROUPE_REF).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.GREFTX_TEXTE_GROUPE_REF.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_Nomenclature2, PREGREF_PRE_GROUPE_REF1).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.PREGREF_PRE_GROUPE_REF1.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_Nomenclature2, PREGREF_PRE_GROUPE_REF).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.PREGREF_PRE_GROUPE_REF.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_Nomenclature2, GREF_GROUPE_SPECIALITE_REF).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.GREF_GROUPE_SPECIALITE_REF.RejectChanges()
        If txtCode.Text <> "" Then
            Dim strSSQL As String = "  Select SP_DATEJOGENE from THERIAQUE.SP_SPECIALITE where SP_GREF_FK = " & cn.SQLText(txtCode.Text)
            Dim dt As DataTable = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 And dt.Rows(0)(0) IsNot DBNull.Value Then DateEditJO.Text = Convert.ToDateTime(dt.Rows(0)(0))
        Else
            DateEditJO.Text = ""
        End If

    End Sub

    Public Overrides Function Supprimer() As Boolean
        MyBase.Supprimer()
        If Not TestFK_Used(MasterTable, "GREF_CODE_SQ_PK", txtCode.EditValue) Then
            DsTheriaque_Nomenclature2.GREF_GROUPE_SPECIALITE_REF.Rows(0).Delete()
            Me.GreF_TA.Update(Me.DsTheriaque_Nomenclature2)
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub ClearTable()
        Me.DsTheriaque_Nomenclature2.GREFTX_TEXTE_GROUPE_REF.Clear()
        Me.DsTheriaque_Nomenclature2.SPGREFG_GROUPE_SPE_GENE.Clear()
        Me.DsTheriaque_Nomenclature2.SPGREFR_GROUPE_SPE_REF.Clear()
        Me.DsTheriaque_Nomenclature2.PREGREF_PRE_GROUPE_REF.Clear()
        Me.DsTheriaque_Nomenclature2.PREGREF_PRE_GROUPE_REF1.Clear()
        Me.DsTheriaque_Nomenclature2.GREF_GROUPE_SPECIALITE_REF.Clear()
        'Me.DsTheriaque_Nomenclature2.SP_SPECIALITE.Clear()
    End Sub

#End Region

#Region " Grid View "
    Private Sub GV1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV1.FocusedRowChanged
        Load_On(Me)
        OnLoading = True

        Dim dvRP As New DataView
        dvRP = Me.rpPre.DataSource.DefaultView
        dvSau = Me.rpSau.DataSource.DefaultView

        If GV1.GetFocusedRowCellValue(colSPGREFR_SP_CODE_FK_PK) Is Nothing Then
            colPREGREF_GREF_CODE_FK_PK.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("PREGREF_PRE_CODE_FK_PK =-1")
            dvRP.RowFilter = "code = '-1' "

            colCOSAU_GREF_CODE_FK.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("COSAU_SP_CODE_FK_PK = - 1")
            dvSau.RowFilter = "code = '-1' "

            OnLoading = False
            Load_Off(Me)

            Exit Sub
        End If
        '-- First Grid
        'Dim dv1 As New DataView
        'dv1 = Me.DsTheriaque_Nomenclature2.PREGREF_PRE_GROUPE_REF.DefaultView
        Dim ListPr As String = ""
        ListPr = ClsSP.GetPR(GV1.GetFocusedRowCellValue(colSPGREFR_SP_CODE_FK_PK))
        If ListPr <> "" Then
            'dv1.RowFilter = "PREGREF_PRE_CODE_FK_PK in " & ListPr
            dvRP.RowFilter = " code in " & ListPr
            colPREGREF_GREF_CODE_FK_PK.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("PREGREF_PRE_CODE_FK_PK in " & ListPr & " and PREGREF_DATESORTIE is null")
        Else
            'dv1.RowFilter = "PREGREF_PRE_CODE_FK_PK = -1"
            dvRP.RowFilter = ""
        End If

        '-- Second Grid
        Dim Val As Integer = GV1.GetFocusedRowCellValue(colSPGREFR_SP_CODE_FK_PK)
        Dim strFiltre As String = ""
        strFiltre = " COSAU_SP_CODE_FK_PK = " & CStr(Val)

        colCOSAU_GREF_CODE_FK.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(strFiltre)
        dvSau.RowFilter = strFiltre

        OnLoading = False
        Load_Off(Me)
    End Sub

    Private Sub GV4_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV4.FocusedRowChanged
        Load_On(Me)
        OnLoading = True

        Dim dvRP1 As New DataView
        dvSau1 = Me.rpSAU1.DataSource.DefaultView
        dvRP1 = Me.rpPre1.DataSource.DefaultView

        If GV4.GetFocusedRowCellValue(colSPGREFG_SP_CODE_FK_PK) Is Nothing Then
            colPREGREF_GREF_CODE_FK_PK1.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("PREGREF_PRE_CODE_FK_PK =-1")
            dvRP1.RowFilter = "code = '-1' "

            colCOSAU_GREF_CODE_FK1.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("COSAU_SP_CODE_FK_PK = - 1")
            dvSau1.RowFilter = "code = '-1' "

            OnLoading = False
            Load_Off(Me)

            Exit Sub
        End If

        '-- First Grid
        'Dim dv1 As New DataView
        'dv1 = Me.DsTheriaque_Nomenclature2.PREGREF_PRE_GROUPE_REF1.DefaultView
        Dim ListPr As String = ""
        ListPr = ClsSP.GetPR(GV4.GetFocusedRowCellValue(colSPGREFG_SP_CODE_FK_PK))
        If ListPr <> "" Then
            'dv1.RowFilter = "PREGREF_PRE_CODE_FK_PK in " & ListPr
            dvRP1.RowFilter = " code in " & ListPr
            colPREGREF_GREF_CODE_FK_PK1.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("PREGREF_PRE_CODE_FK_PK in " & ListPr & " and PREGREF_DATESORTIE is null")
        Else
            'dv1.RowFilter = "PREGREF_PRE_CODE_FK_PK = -1"
            dvRP1.RowFilter = ""
        End If

        '-- Second Grid
        Dim Val As Integer = GV4.GetFocusedRowCellValue(colSPGREFG_SP_CODE_FK_PK)
        Dim strFiltre As String = ""
        strFiltre = " COSAU_SP_CODE_FK_PK = " & CStr(Val)

        colCOSAU_GREF_CODE_FK1.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(strFiltre)
        dvSau1.RowFilter = strFiltre

        OnLoading = False
        Load_Off(Me)
    End Sub

    Private Sub GV4_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV4.ValidateRow
        If DateEditCrGroupe.Text <> "" Then
            e.Valid = True
            e.ErrorText = ""
            GV4.SetFocusedRowCellValue(colSPGREFG_GREF_DATECR_FK_PK, DateEditCrGroupe.Text)
            GV4.SetFocusedRowCellValue(colSPGREFG_GREF_CODE_FK_PK, Me.txtCode.Text)
            dv.RowFilter = " SP_CODE_SQ_PK = " & GV4.GetFocusedRowCellValue(Me.colSPGREFG_SP_CODE_FK_PK)
            dv.Item(0)("SP_TYPE_SPE") = "G"
            dv.Item(0)("SP_ORIGINE_GENE") = "R"
            dv.RowFilter = ""
        Else
            e.Valid = False
            e.ErrorText = "Vous devez d'abord saisir la date de création du groupe"
        End If
    End Sub

    Private Sub GV1_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV1.ValidateRow
        'GV1.SetFocusedRowCellValue(colSPGREFR_GREF_DATECR_FK_PK, DateEditCrGroupe.Text)
        If DateEditCrGroupe.Text <> "" Then
            Me.GV1.SetFocusedRowCellValue(Me.colSPGREFR_GREF_DATECR_FK_PK, Me.DateEditCrGroupe.Text)
            GV1.SetFocusedRowCellValue(colSPGREFR_GREF_CODE_FK_PK, Me.txtCode.Text)
            dv.RowFilter = " SP_CODE_SQ_PK = " & GV1.GetFocusedRowCellValue(Me.colSPGREFR_SP_CODE_FK_PK)
            dv.Item(0)("SP_TYPE_SPE") = "R"
            dv.Item(0)("SP_ORIGINE_GENE") = "R"
            dv.RowFilter = ""
            e.Valid = True
            e.ErrorText = ""
            'Me.DsTheriaque_Nomenclature2.PREGREF_PRE_GROUPE_REF.Columns("PREGREF_DATEENTREE_PK").Table.Rows.Item(0) = DateEditJO.Text
        Else
            e.Valid = False
            e.ErrorText = "Vous devez d'abord saisir la date de création du groupe"
        End If
    End Sub

    Private Sub GV_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        If Me.GV.GetFocusedRowCellValue(colCOSAU_SAU_CODE_FK_PK) Is Nothing Then Exit Sub
        If Me.GV.GetFocusedRowCellValue(colCOSAU_SAU_CODE_FK_PK) Is DBNull.Value Then Exit Sub

        Dim StrFiltre As String = ""
        StrFiltre &= " COSAU_SP_CODE_FK_PK = " & GV1.GetFocusedRowCellValue(Me.colSPGREFR_SP_CODE_FK_PK)
        StrFiltre &= " and COSAU_SAU_CODE_FK_PK = " & Me.GV.GetFocusedRowCellValue(colCOSAU_SAU_CODE_FK_PK)
        dvCosau.RowFilter = StrFiltre

        For i As Integer = 0 To dvCosau.Count - 1
            dvCosau.Item(i)("COSAU_GREF_DATECR_FK") = Me.DateEditCrGroupe.Text
            dvCosau.Item(i)("COSAU_GREF_CODE_FK") = txtCode.Text
        Next
    End Sub

    Private Sub GV6_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV6.ValidateRow
        If Me.GV6.GetFocusedRowCellValue(colCOSAU_SAU_CODE_FK_PK1) Is Nothing Then Exit Sub
        If Me.GV6.GetFocusedRowCellValue(colCOSAU_SAU_CODE_FK_PK1) Is DBNull.Value Then Exit Sub

        Dim StrFiltre As String = ""
        StrFiltre &= " COSAU_SP_CODE_FK_PK = " & GV4.GetFocusedRowCellValue(Me.colSPGREFG_SP_CODE_FK_PK)
        StrFiltre &= " and COSAU_SAU_CODE_FK_PK = " & Me.GV6.GetFocusedRowCellValue(colCOSAU_SAU_CODE_FK_PK)
        dvCosau.RowFilter = StrFiltre

        For i As Integer = 0 To dvCosau.Count - 1
            dvCosau.Item(i)("COSAU_GREF_DATECR_FK") = Me.DateEditCrGroupe.Text
            dvCosau.Item(i)("COSAU_GREF_CODE_FK") = txtCode.Text
        Next
    End Sub

    Private Sub GV2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        GV2.SetFocusedRowCellValue(colPREGREF_GREF_DATECR_FK_PK, DateEditCrGroupe.Text)
        GV2.SetFocusedRowCellValue(colPREGREF_GREF_CODE_FK_PK, Me.txtCode.Text)
        GV2.SetFocusedRowCellValue(colPREGREF_TYPE_PRE, "R")
        GV2.SetFocusedRowCellValue(colPREGREF_DATEENTREE_PK, DateEditJO.Text)
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        Me.GV.SetFocusedRowCellValue(Me.colCOSAU_GREF_DATECR_FK, Me.DateEditCrGroupe.Text)
        Me.GV.SetFocusedRowCellValue(Me.colCOSAU_GREF_CODE_FK, txtCode.Text)
        Me.GV.SetFocusedRowCellValue(Me.colCOSAU_SP_CODE_FK_PK, GV1.GetFocusedRowCellValue(Me.colSPGREFR_SP_CODE_FK_PK))
    End Sub

    Private Sub GV12_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV12.InitNewRow
        Me.GV12.SetFocusedRowCellValue(Me.colGREFTX_GREF_DATECR_FK_PK, Me.DateEditCrGroupe.Text)
        Me.GV12.SetFocusedRowCellValue(Me.colGREFTX_GREF_CODE_FK_PK, txtCode.Text)
        'If GV12.RowCount >= 0 Then
        '    GV12.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
        'End If
    End Sub

    Private Sub GV5_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV5.InitNewRow
        GV5.SetFocusedRowCellValue(colPREGREF_GREF_DATECR_FK_PK1, DateEditCrGroupe.Text)
        GV5.SetFocusedRowCellValue(colPREGREF_GREF_CODE_FK_PK1, Me.txtCode.Text)
        GV5.SetFocusedRowCellValue(colPREGREF_TYPE_PRE1, "G")
        GV5.SetFocusedRowCellValue(colPREGREF_DATEENTREE_PK1, DateEditJO.Text)
    End Sub

    Private Sub GV6_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV6.InitNewRow
        Me.GV6.SetFocusedRowCellValue(Me.colCOSAU_GREF_DATECR_FK1, Me.DateEditCrGroupe.Text)
        Me.GV6.SetFocusedRowCellValue(Me.colCOSAU_GREF_CODE_FK1, txtCode.Text)
        Me.GV6.SetFocusedRowCellValue(Me.colCOSAU_SP_CODE_FK_PK1, GV4.GetFocusedRowCellValue(Me.colSPGREFG_SP_CODE_FK_PK))
    End Sub

#End Region

#Region " Load "

    Public Overrides Sub InitData()
        MyBase.InitData()
        Load_On(Me)
        OnLoading = True
        InitDataSource()

        MasterTable = GREF_GROUPE_SPECIALITE_REF
        MasterDataSet = Me.DsTheriaque_Nomenclature2

        AddHandler GC2.EmbeddedNavigator.ButtonClick, AddressOf DeleteRow2
        AddHandler GC5.EmbeddedNavigator.ButtonClick, AddressOf DeleteRow5
        AddHandler GC1.EmbeddedNavigator.ButtonClick, AddressOf DeleteRow1
        AddHandler GC4.EmbeddedNavigator.ButtonClick, AddressOf DeleteRow4


        InitLkup(Me.rpPre, PRE_PRESENTATION, strSSQL_PRE_PRESENTATION, True, True, True, True, False)

        str_SSQL_COSAU = ""
        str_SSQL_COSAU &= " select DISTINCT "
        str_SSQL_COSAU &= " COSAU_SAU_CODE_FK_PK , COSAU_SP_CODE_FK_PK, COSAU_GREF_CODE_FK, COSAU_GREF_DATECR_FK "
        str_SSQL_COSAU &= " from THERIAQUE.COSAU_COMPO_SUBAUX , THERIAQUE.SAU_SUBAUXILIAIRE  "
        str_SSQL_COSAU &= " where COSAU_SAU_CODE_FK_PK = SAU_CODE_SQ_PK "
        str_SSQL_COSAU &= " and SAU_EFFETNOTOIRE = 'O' "
        str_SSQL_COSAU &= ""

        str_SSQL_COSAU2 = ""
        str_SSQL_COSAU2 &= " select Distinct "
        str_SSQL_COSAU2 &= " COSAU_SAU_CODE_FK_PK as code , COSAU_SP_CODE_FK_PK, SAU_NOM as libelle "
        str_SSQL_COSAU2 &= " from THERIAQUE.COSAU_COMPO_SUBAUX , THERIAQUE.SAU_SUBAUXILIAIRE  "
        str_SSQL_COSAU2 &= " where COSAU_SAU_CODE_FK_PK = SAU_CODE_SQ_PK "
        str_SSQL_COSAU2 &= " and SAU_EFFETNOTOIRE = 'O' "
        str_SSQL_COSAU2 &= ""

        InitLkup(Me.rpSau, SAU_SUBAUXILIAIRE, str_SSQL_COSAU2, True, True)

        ' Pas de chargement, juste initialisation de son aperçu !
        InitLkup(Me.rpGen, SP_SPECIALITE, strSSQL_SP_SPECIALITE, False, False, False)

        Me.SP_TA.Fill(Me.DsTheriaque_Nomenclature2.SP_SPECIALITE)
        dv = Me.DsTheriaque_Nomenclature2.SP_SPECIALITE.DefaultView

        Me.CosaU_TA.FillByNotoire(Me.DsTheriaque_Nomenclature2.COSAU_COMPO_SUBAUX)
        dvCosau = Me.DsTheriaque_Nomenclature2.COSAU_COMPO_SUBAUX.DefaultView

        colPREGREF_GREF_CODE_FK_PK1.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("PREGREF_PRE_CODE_FK_PK = '-1' ")
        colPREGREF_GREF_CODE_FK_PK.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("PREGREF_PRE_CODE_FK_PK  = '-1' ")
        colCOSAU_GREF_CODE_FK1.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("COSAU_SP_CODE_FK_PK = -1 ")
        colCOSAU_GREF_CODE_FK.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("COSAU_SP_CODE_FK_PK = -1 ")

        OnLoading = False
        Load_Off(Me)
    End Sub

    Private Sub InitDataSource()
        GC1.DataSource = DsTheriaque_Nomenclature2
        GC1.DataMember = SPGREFR_GROUPE_SPE_REF

        GC2.DataSource = DsTheriaque_Nomenclature2
        GC2.DataMember = PREGREF_PRE_GROUPE_REF

        GC12.DataSource = DsTheriaque_Nomenclature2
        GC12.DataMember = GREFTX_TEXTE_GROUPE_REF

        GC4.DataSource = DsTheriaque_Nomenclature2
        GC4.DataMember = SPGREFG_GROUPE_SPE_GENE

        GC5.DataSource = DsTheriaque_Nomenclature2
        GC5.DataMember = PREGREF_PRE_GROUPE_REF1

        GC7.DataSource = DsTheriaque_Nomenclature2
        GC7.DataMember = PREGREF_PRE_GROUPE_REF

        GC8.DataSource = DsTheriaque_Nomenclature2
        GC8.DataMember = PREGREF_PRE_GROUPE_REF1
    End Sub


    Private Sub LoadTab_1()
        Load_On(Me)
        OnLoading = True

        If Not Tab_lkup1 Then
            InitLkup(Me.rpPre1, PRE_PRESENTATION, strSSQL_PRE_PRESENTATION, True, True, True, True, False)
            InitLkup(Me.rpSAU1, SAU_SUBAUXILIAIRE, str_SSQL_COSAU2, True, True)
            Tab_lkup1 = True
        End If
        If txtCode.Text <> "" Then
            If ModeFiche <> eMode.Ajout Then
                Dim SuppSSQL1 As String = "  SP_CODE_SQ_PK not in (Select distinct(SPGREFG_SP_CODE_FK_PK) from THERIAQUE.SPGREFG_GROUPE_SPE_GENE)"
                Dim SuppSSQL2 As String = "  SP_CODE_SQ_PK in (Select distinct(SPGREFG_SP_CODE_FK_PK) from THERIAQUE.SPGREFG_GROUPE_SPE_GENE where SPGREFG_GREF_CODE_FK_PK = " & txtCode.Text & ")"
                InitLkup(Me.rpSPG, SP_SPECIALITE, strSSQL_SP_SPECIALITE & " where " & SuppSSQL1 & " UNION " & strSSQL_SP_SPECIALITE & " where " & SuppSSQL2, True)
            End If
        End If

        If Not Tab_TA1 And CodE <> InvalideControl And CodE <> Nothing Then
            Me.SpgrefG_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SPGREFG_GROUPE_SPE_GENE, txtCode.Text, Me.DateEditCrGroupe.Text)
            Me.PregreF1_TA.FillByCode(Me.DsTheriaque_Nomenclature2.PREGREF_PRE_GROUPE_REF1, txtCode.Text, Me.DateEditCrGroupe.Text)
            'Filtre
            'If DateEditJO.Text <> "" Then
            '    Dim dv As DataView = GV4.DataSource
            '    dv.RowFilter = " SPGREFG_DATEEG_PK <> " & cn.SQLText(DateEditJO.Text)
            'End If

            'Dim fp As IFormatProvider
            'fp = New System.Globalization.CultureInfo("en-US")

            'Dim dateJO As DateTime = DateTime.ParseExact(DateEditJO.Text, "MM/dd/yyyy", fp)
            'If DateEditJO.Text <> "" Then colSPGREFG_DATEEG_PK.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("SPGREFG_DATEEG_PK <> " & cn.SQLText(dateJO))



            'Dim BinaryFilter As CriteriaOperator
            'Dim FilterString, FilterDisplayText As String
            'Dim DateFilter As ColumnFilterInfo
            'BinaryFilter = New GroupOperator(GroupOperatorType.And, _
            '    New BinaryOperator("SPGREFG_DATEEG_PK", DateEditJO.DataBindings("EditValue"), BinaryOperatorType.Equal), _
            '    New BinaryOperator("SPGREFG_DATEEG_PK", DateEditJO.DataBindings("EditValue"), BinaryOperatorType.Equal))
            'FilterString = BinaryFilter.ToString()
            ''FilterDisplayText = String.Format("Event Date between {0:d} and {1:d}", DateEditJO.Text, DateEditJO.Text)
            'DateFilter = New ColumnFilterInfo(FilterString)
            'colSPGREFG_DATEEG_PK.FilterInfo = DateFilter


            Tab_TA1 = True
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub

    Private Sub LoadTab_2()
        Load_On(Me)
        OnLoading = True

        If Not Tab_lkup2 Then
            colPREGREF_TYPE_PRE_H1.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("PREGREF_TYPE_PRE = 'G' ")
            colPREGREF_TYPE_PRE_H.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("PREGREF_TYPE_PRE ='R' ")
            InitLkup(Me.rpSPH, PRE_PRESENTATION, strSSQL_PRE_PRESENTATION, True, , , , , rpSPH2)
            Tab_lkup2 = True
        End If

        If Not Tab_TA2 And CodE <> InvalideControl And CodE <> Nothing Then
            Tab_TA2 = True
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub

    ''' <summary>
    ''' Tester sur la page active pour charger les données correspondantes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPageIndex = 1 Then
            LoadTab_1()
            Exit Sub
        End If
        If XtraTabControl1.SelectedTabPageIndex = 2 Then
            LoadTab_2()
            Exit Sub
        End If
    End Sub

#End Region

    Private Sub DateEditJO_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateEditJO.Validated, DateEditCrGroupe.Validated, DateEdit4.Validated
        If Me.DateEditJO.Text = "" Then Exit Sub
        Dim strListSP As String = ""
        For i As Integer = 0 To Me.GV1.RowCount - 1
            If GV1.GetRowCellValue(i, colSPGREFR_SP_CODE_FK_PK) IsNot Nothing Then
                If strListSP = "" Then
                    strListSP &= " " & GV1.GetRowCellValue(i, colSPGREFR_SP_CODE_FK_PK)
                Else
                    strListSP &= ", " & GV1.GetRowCellValue(i, colSPGREFR_SP_CODE_FK_PK)
                End If
            End If
        Next
        If strListSP = "" Then strListSP = -1
        strListSP = "(" & strListSP & ")"
        dv.RowFilter = " SP_CODE_SQ_PK in " & strListSP
        For i As Integer = 0 To dv.Count - 1
            dv.Item(0)("SP_DATEJOGENE") = Me.DateEditJO.Text
        Next

        dv.RowFilter = ""
        Me.DxErrorProvider.SetError(sender, "")
    End Sub

    Public Sub DeleteRow2(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        If e.Button.Tag = "DEL" Then
            If GV2.RowCount > 0 Then
                If GV2.GetFocusedRowCellValue(colPREGREF_PRE_CODE_FK_PK) IsNot Nothing Then
                    'GV2.SetFocusedRowCellValue(colPREGREF_DATESORTIE, Now.Date)
                    GV2.SetFocusedRowCellValue(colPREGREF_DATESORTIE, DateEditJO.Text)
                    GV2.FocusedRowHandle += 1
                End If
            End If
        End If
    End Sub

    Public Sub DeleteRow5(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        If e.Button.Tag = "DEL" Then
            'GV5.SetFocusedRowCellValue(colPREGREF_DATESORTIE1, Now.Date)
            GV5.SetFocusedRowCellValue(colPREGREF_DATESORTIE1, DateEditJO.Text)
            GV5.FocusedRowHandle += 1
        End If
    End Sub

    Public Sub DeleteRow1(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        If e.Button.Tag = "DEL" Then

            If GV1.GetFocusedRowCellValue(colSPGREFR_SP_CODE_FK_PK) IsNot Nothing Then
                Dim sSQL As String
                sSQL = " UPDATE THERIAQUE.SP_SPECIALITE SET SP_GREF_FK = NULL"
                sSQL &= ", SP_GREF_DATECR_FK = NULL"
                sSQL &= ", SP_ORIGINE_GENE = NULL"
                sSQL &= ", SP_TYPE_SPE = NULL"
                sSQL &= ", SP_DATEJOGENE = NULL"
                sSQL &= " WHERE SP_CODE_SQ_PK = " & cn.SQLText(GV1.GetFocusedRowCellValue(colSPGREFR_SP_CODE_FK_PK))
                cn.Execute(sSQL)
                GV1.DeleteRow(GV1.FocusedRowHandle)
            End If
        End If
    End Sub
    Public Sub DeleteRow4(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        If e.Button.Tag = "DEL" Then

            If GV4.GetFocusedRowCellValue(colSPGREFG_SP_CODE_FK_PK) IsNot Nothing Then
                Dim sSQL As String
                sSQL = " UPDATE THERIAQUE.SP_SPECIALITE SET SP_GREF_FK = NULL"
                sSQL &= ", SP_GREF_DATECR_FK = NULL"
                sSQL &= ", SP_ORIGINE_GENE = NULL"
                sSQL &= ", SP_TYPE_SPE = NULL"
                sSQL &= ", SP_DATEJOGENE = NULL"
                sSQL &= " WHERE SP_CODE_SQ_PK = " & cn.SQLText(GV4.GetFocusedRowCellValue(colSPGREFG_SP_CODE_FK_PK))
                cn.Execute(sSQL)
                GV4.DeleteRow(GV4.FocusedRowHandle)
            End If
        End If
    End Sub

    Protected Friend Overrides Function ValideControl(Optional ByRef Ctrl As Control = Nothing, Optional ByVal AllCtrl As Boolean = True) As Boolean
        Dim strSSQL As String = ""
        MyBase.ValideControl(Ctrl)
        If Ctrl.Name.ToLower = "DateEditJO".ToLower Or AllCtrl Then
            If DateEditJO.Text = "" Then
                Me.DxErrorProvider.SetError(DateEditJO, "La date JO en cours est obligatoire !")
                Return False
            End If
        End If
        LoadTab_2()
        If Not TestGeneriqueHistorique() Then
            Process_Message("Merci de bien vouloir supprimer la spécialité générique de l'historique", MessageBoxButtons.OK, MessageBoxIcon.Information)
            XtraTabControl1.SelectedTabPageIndex = 2
            Return False
        End If
        If Not TestReferenceHistorique() Then
            Process_Message("Merci de bien vouloir supprimer la spécialité réference de l'historique", MessageBoxButtons.OK, MessageBoxIcon.Information)
            XtraTabControl1.SelectedTabPageIndex = 2
            Return False
        End If
        Return True
    End Function

    Private Sub GV4_ValidatingEditor(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV4.ValidatingEditor
        If GV4.FocusedColumn Is colSPGREFG_SP_CODE_FK_PK Then
            If FieldExist(GV4, colSPGREFG_SP_CODE_FK_PK, e.Value) Or FieldExist(GV1, colSPGREFG_SP_CODE_FK_PK, e.Value) Then
                e.ErrorText = "Cette spécialité existe déjà."
                e.Value = Nothing
                e.Valid = False
            End If
        End If
    End Sub

    Private Sub GV1_ValidatingEditor(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV1.ValidatingEditor
        If GV1.FocusedColumn Is colSPGREFR_SP_CODE_FK_PK And e.Value <> Nothing Then
            If FieldExist(GV1, colSPGREFR_SP_CODE_FK_PK, e.Value) Or FieldExist(GV4, colSPGREFR_SP_CODE_FK_PK, e.Value) Then
                e.ErrorText = "Cette spécialité existe déjà."
                e.Value = Nothing
                e.Valid = False
            End If
        End If
    End Sub
    Private Sub GV_RowCountChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV12.RowCountChanged
        If sender.RowCount >= 1 Then
            sender.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
            sender.GridControl.EmbeddedNavigator.Buttons.Append.Enabled = False
        Else
            sender.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            sender.GridControl.EmbeddedNavigator.Buttons.Append.Enabled = False
        End If
    End Sub

    Private Sub GV_CalcRowHeight(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs) Handles GV12.CalcRowHeight
        e.RowHeight = sender.GridControl.Height
    End Sub

    Private Sub GV4_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV4.InitNewRow
        GV4.SetFocusedRowCellValue(colSPGREFG_DATEEG_PK, DateEditJO.Text)
    End Sub
    Private Function TestGeneriqueHistorique() As Boolean
        TestGeneriqueHistorique = True
        Dim dt As New DataTable
        For iCount As Integer = 0 To GV8.RowCount - 1
            If GV8.GetRowCellValue(iCount, colPREGREF_PRE_CODE_FK_PK2) IsNot Nothing Then
                dt = cn.MySelect("SELECT PRE_SP_CODE_FK  FROM THERIAQUE.PRE_PRESENTATION  WHERE PRE_CODE_PK = " & cn.SQLText(GV8.GetRowCellValue(iCount, colPREGREF_PRE_CODE_FK_PK2)))
                If dt.Rows.Count > 0 Then
                    For iCount2 As Integer = 0 To GV4.RowCount - 1
                        If dt.Rows(0)(0) = GV4.GetRowCellValue(iCount2, colSPGREFG_SP_CODE_FK_PK) Then
                            TestGeneriqueHistorique = True
                            Exit For
                        Else
                            TestGeneriqueHistorique = False
                        End If
                    Next
                    If Not TestGeneriqueHistorique Then Exit Function
                End If
            End If
        Next
    End Function
    Private Function TestReferenceHistorique() As Boolean
        TestReferenceHistorique = True
        Dim dt As New DataTable
        For iCount As Integer = 0 To GV7.RowCount - 1
            If GV7.GetRowCellValue(iCount, colPREGREF_PRE_CODE_FK_PK3) IsNot Nothing Then
                dt = cn.MySelect("SELECT PRE_SP_CODE_FK  FROM THERIAQUE.PRE_PRESENTATION WHERE PRE_CODE_PK = " & cn.SQLText(GV7.GetRowCellValue(iCount, colPREGREF_PRE_CODE_FK_PK3)))
                If dt.Rows.Count > 0 Then
                    For iCount2 As Integer = 0 To GV1.RowCount - 1
                        If dt.Rows(0)(0) = GV1.GetRowCellValue(iCount2, colSPGREFR_SP_CODE_FK_PK) Then
                            TestReferenceHistorique = True
                            Exit For
                        Else
                            TestReferenceHistorique = False
                        End If
                    Next
                    If Not TestReferenceHistorique Then Exit Function
                End If
            End If
        Next
    End Function

    ''' <summary>
    ''' Mettre à jour la table SP_SPECIALITE
    ''' </summary>
    Private Sub Update_Specialite()
        Dim sSQL As String = ""
        If Not Tab_TA1 And CodE <> InvalideControl And CodE <> Nothing Then LoadTab_1()

        'Pour les Spécialités de référence
        For iCount As Integer = 0 To GV1.RowCount - 1
            If GV1.GetRowCellValue(iCount, colSPGREFR_SP_CODE_FK_PK) IsNot Nothing And GV1.GetRowCellValue(iCount, colSPGREFR_SP_CODE_FK_PK) IsNot DBNull.Value Then
                sSQL = " UPDATE THERIAQUE.SP_SPECIALITE SET SP_GREF_FK = " & cn.SQLText(txtCode.Text)
                sSQL &= ", SP_GREF_DATECR_FK = " & cn.SQLDate(DateEditCrGroupe.Text)
                sSQL &= ", SP_ORIGINE_GENE = 'R'"
                sSQL &= ", SP_TYPE_SPE = 'R'"
                sSQL &= ", SP_DATEJOGENE = " & cn.SQLDate(DateEditJO.Text)
                sSQL &= " WHERE SP_CODE_SQ_PK = " & cn.SQLText(GV1.GetRowCellValue(iCount, colSPGREFR_SP_CODE_FK_PK))
                cn.Execute(sSQL)
            End If
        Next
        'Pour les Spécialités génériques
        For iCount1 As Integer = 0 To GV4.RowCount - 1
            If GV4.GetRowCellValue(iCount1, colSPGREFG_SP_CODE_FK_PK) IsNot Nothing And GV4.GetRowCellValue(iCount1, colSPGREFR_SP_CODE_FK_PK) IsNot DBNull.Value Then
                sSQL = " UPDATE THERIAQUE.SP_SPECIALITE SET SP_GREF_FK = " & cn.SQLText(txtCode.Text)
                sSQL &= ", SP_GREF_DATECR_FK = " & cn.SQLDate(DateEditCrGroupe.Text)
                sSQL &= ", SP_ORIGINE_GENE = 'R'"
                sSQL &= ", SP_TYPE_SPE = 'G'"
                sSQL &= ", SP_DATEJOGENE = " & cn.SQLDate(DateEditJO.Text)
                sSQL &= " WHERE SP_CODE_SQ_PK = " & cn.SQLText(GV4.GetRowCellValue(iCount1, colSPGREFG_SP_CODE_FK_PK))
                cn.Execute(sSQL)
            End If
        Next
        'MAJ de la date de création de la table COSAU_COMPO_SUBAUX

        sSQL = "UPDATE THERIAQUE.COSAU_COMPO_SUBAUX"
        sSQL &= " SET COSAU_GREF_DATECR_FK = " & cn.SQLDate(DateEditCrGroupe.Text)
        sSQL &= " WHERE COSAU_GREF_CODE_FK = " & cn.SQLText(txtCode.Text)
        cn.Execute(sSQL)

    End Sub
End Class
