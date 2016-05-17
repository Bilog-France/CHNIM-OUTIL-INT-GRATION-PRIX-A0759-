Public Class Frm_MedVirtuelle

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_GSP_GENERIQUE_SPECIALITE
        f.Text = Me.Text
        f.ShowDialog()
        If f._Code IsNot Nothing Then
            Me.GridControl1.Enabled = True
            Me.GridControl2.Enabled = True
            Me.DsTheriaque_Nomenclature2.SYGSP_SYNONYME_GSP.Clear()
            Me.DsTheriaque_Nomenclature2.GSP_GENERIQUE_SPECIALITE.Clear()
            Me.DsTheriaque_Nomenclature2.SP_SPECIALITE.Clear()
            Me.MVPF.FillByCode(Me.DsTheriaque_Nomenclature2.MVPF_MED_VIR_PERE_FORME, f._Code)
            Me.MVPSDU.FillByCode(Me.DsTheriaque_Nomenclature2.MVPSDU_MED_VIR_PERE_SA, f._Code)
            Me.GsP_TA.FillByCode(Me.DsTheriaque_Nomenclature2.GSP_GENERIQUE_SPECIALITE, f._Code)
            Me.SygsP_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SYGSP_SYNONYME_GSP, f._Code)
            Me.SP_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SP_SPECIALITE, f._Code)

            Dim statut As String = Me.DsTheriaque_Nomenclature2.GSP_GENERIQUE_SPECIALITE.Rows(0).Item(10).ToString()

            Select Case statut

                Case "D"
                    Me.statutEdit.Text = "Disponible (D)"
                Case "A"
                    Me.statutEdit.Text = "Archivé (A)"
                Case "N"
                    Me.statutEdit.Text = "NC (N)"
                Case "S"
                    Me.statutEdit.Text = "NSFP (S)"
                Case Else
                    Me.statutEdit.Text = "Disponible (D)"
            End Select
            Me.statutEdit.ClosePopup()

            Dim strSSQL As String = ""
            'strSSQL = "Select SP_CODE_SQ_PK , SP_NOM, SP_GSP_CODE_FK, 0 as CheckREF  From THERIAQUE.SP_SPECIALITE "
            'strSSQL &= " where SP_GSP_CODE_FK= " & f._Code

            strSSQL = "SELECT SP_CODE_SQ_PK , SP_NOM, SP_GSP_CODE_FK,"
            strSSQL &= " CASE GSP.GSP_CODE_SP_REFERENCE WHEN SP_CODE_SQ_PK THEN 1 ELSE 0 END AS CheckREF"
            strSSQL &= " FROM THERIAQUE.SP_SPECIALITE SP"
            strSSQL &= " LEFT JOIN THERIAQUE.GSP_GENERIQUE_SPECIALITE GSP ON SP.SP_CODE_SQ_PK = GSP.GSP_CODE_SP_REFERENCE"
            strSSQL &= " WHERE SP_GSP_CODE_FK = " & f._Code
            strSSQL &= " ORDER BY SP_CODE_SQ_PK"
            GC2.DataSource = cn.MySelect(strSSQL)


            Dim strSQL As String
            strSQL = ""
            If txtCode.Text <> "" Then
                strSQL += " UNION SELECT SP_CODE_SQ_PK AS code, SP_NOM AS libelle, 1 as disable, 0 as chk ,0 as chkFixe FROM THERIAQUE.SP_SPECIALITE WHERE SP_GSP_CODE_FK = " & cn.SQLText(txtCode.Text)
            End If
            InitLkup(rpSP, SP_SPECIALITE, strSSQL_SP_SPECIALITE_WITHOUT_MEDV & " OR SP_GSP_CODE_FK = " & txtCode.Text & strSQL, True, True)
            FillCombos()
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Sub Ajouter()

        Me.DsTheriaque_Nomenclature2.SYGSP_SYNONYME_GSP.Clear()
        Me.DsTheriaque_Nomenclature2.GSP_GENERIQUE_SPECIALITE.Clear()
        Me.DsTheriaque_Nomenclature2.SP_SPECIALITE.Clear()
        Me.DsTheriaque_Nomenclature2.MVPSDU_MED_VIR_PERE_SA.Clear()
        Me.DsTheriaque_Nomenclature2.MVPF_MED_VIR_PERE_FORME.Clear()
        Me.BindingContext(Me.DsTheriaque_Nomenclature2, GSP_GENERIQUE_SPECIALITE).AddNew()
        Me.txtCode.Text = Code_MAx(GSP_GENERIQUE_SPECIALITE, Me.txtCode) + 1
        txtCodeVirtuelle.Text = Code_MedVirtuelle(Me.txtCode.Text, Me.DxErrorProvider)
        txt_Code13.Text = Code_MedVirtuelle13(Me.txtCode.Text, Me.DxErrorProvider)

        GC2.DataSource = Nothing
        If GC2.DataSource Is Nothing Then
            Dim strSSQL As String = ""
            'strSSQL = "Select SP_CODE_SQ_PK , SP_NOM, SP_GSP_CODE_FK From THERIAQUE.SP_SPECIALITE "
            'strSSQL &= " where SP_GSP_CODE_FK= " & txtCode.Text
            strSSQL = "SELECT SP_CODE_SQ_PK , SP_NOM, SP_GSP_CODE_FK,"
            strSSQL &= " CASE GSP.GSP_CODE_SP_REFERENCE WHEN SP_CODE_SQ_PK THEN 1 ELSE 0 END AS CheckREF"
            strSSQL &= " FROM THERIAQUE.SP_SPECIALITE SP"
            strSSQL &= " LEFT JOIN THERIAQUE.GSP_GENERIQUE_SPECIALITE GSP ON SP.SP_CODE_SQ_PK = GSP.GSP_CODE_SP_REFERENCE"
            strSSQL &= " WHERE SP_GSP_CODE_FK= " & txtCode.Text
            strSSQL &= " ORDER BY SP_CODE_SQ_PK"
            GC2.DataSource = cn.MySelect(strSSQL)
        End If
        Dim strSQL As String
        strSQL = ""
        If txtCode.Text <> "" Then
            strSQL += " UNION SELECT SP_CODE_SQ_PK AS code, SP_NOM AS libelle, 1 as disable, 0 as chk ,0 as chkFixe FROM THERIAQUE.SP_SPECIALITE WHERE SP_GSP_CODE_FK = " & cn.SQLText(txtCode.Text)
        End If
        InitLkup(rpSP, SP_SPECIALITE, strSSQL_SP_SPECIALITE_WITHOUT_MEDV & strSQL, True, True)
        Me.Ch_DC.Checked = True
        statutEdit.Text = "Disponible (D)"
        Me.statutEdit.ClosePopup()
        FillCombos()


        MyBase.Ajouter()

    End Sub

    Public Overrides Sub Valider() 

        MyBase.Valider()
       
        Me.BindingContext(Me.DsTheriaque_Nomenclature2, MasterTable).EndCurrentEdit()
        GsP_TA.Update(Me.DsTheriaque_Nomenclature2.GSP_GENERIQUE_SPECIALITE)

        Me.BindingContext(Me.DsTheriaque_Nomenclature2, SYGSP_SYNONYME_GSP).EndCurrentEdit()
        SygsP_TA.Update(Me.DsTheriaque_Nomenclature2.SYGSP_SYNONYME_GSP)

        Me.BindingContext(Me.DsTheriaque_Nomenclature2, SP_SPECIALITE).EndCurrentEdit()
        SP_TA.Update(Me.DsTheriaque_Nomenclature2.SP_SPECIALITE)

        Me.BindingContext(Me.DsTheriaque_Nomenclature2, "MVPSDU_MED_VIR_PERE_SA").EndCurrentEdit()
        MVPSDU.Update(Me.DsTheriaque_Nomenclature2.MVPSDU_MED_VIR_PERE_SA)

        Me.BindingContext(Me.DsTheriaque_Nomenclature2, "MVPF_MED_VIR_PERE_FORME").EndCurrentEdit()
        MVPF.Update(Me.DsTheriaque_Nomenclature2.MVPF_MED_VIR_PERE_FORME)

        If GC2.DataSource Is Nothing Then
            Dim strSSQL As String = ""
            'strSSQL = "Select SP_CODE_SQ_PK , SP_NOM, SP_GSP_CODE_FK From THERIAQUE.SP_SPECIALITE "
            'strSSQL &= " where SP_GSP_CODE_FK= " & txtCode.Text
            strSSQL = "SELECT SP_CODE_SQ_PK , SP_NOM, SP_GSP_CODE_FK,"
            strSSQL &= " CASE GSP.GSP_CODE_SP_REFERENCE WHEN SP_CODE_SQ_PK THEN 1 ELSE 0 END AS CheckREF"
            strSSQL &= " FROM THERIAQUE.SP_SPECIALITE SP"
            strSSQL &= " LEFT JOIN THERIAQUE.GSP_GENERIQUE_SPECIALITE GSP ON SP.SP_CODE_SQ_PK = GSP.GSP_CODE_SP_REFERENCE"
            strSSQL &= " WHERE SP_GSP_CODE_FK= " & txtCode.Text
            strSSQL &= " ORDER BY SP_CODE_SQ_PK"
            GC2.DataSource = cn.MySelect(strSSQL)
        End If
        Dim strSQL As String
        strSQL = ""
        If txtCode.Text <> "" Then
            strSQL += " UNION SELECT SP_CODE_SQ_PK AS code, SP_NOM AS libelle, 1 as disable, 0 as chk ,0 as chkFixe FROM THERIAQUE.SP_SPECIALITE WHERE SP_GSP_CODE_FK = " & cn.SQLText(txtCode.Text)
        End If
        For iCount As Integer = 0 To GV2.RowCount - 1
            If GV2.GetRowCellValue(iCount, colSP_CODE_SQ_PK) IsNot Nothing Then
                If GV2.GetRowCellValue(iCount, ColSP_REF) IsNot DBNull.Value Then
                    Dim sSQL As String
                    If GV2.GetRowCellValue(iCount, ColSP_REF) = 1 Then
                        sSQL = "UPDATE THERIAQUE.GSP_GENERIQUE_SPECIALITE SET GSP_CODE_SP_REFERENCE = " & GV2.GetRowCellValue(iCount, colSP_CODE_SQ_PK)
                        sSQL &= " WHERE GSP_CODE_SQ_PK = " & txtCode.Text
                        cn.Execute(sSQL)
                    End If
                End If
            End If
        Next
        'InitLkup(rpSP, SP_SPECIALITE, strSSQL_SP_SPECIALITE_WITHOUT_MEDV & strSQL, True, True)
        InitLkup(rpSP, SP_SPECIALITE, strSSQL_SP_SPECIALITE_WITHOUT_MEDV & " OR SP_GSP_CODE_FK = " & txtCode.Text & strSQL, True, True)

    End Sub

    Public Overrides Sub Annuler()

        MyBase.Annuler()

        Me.BindingContext(Me.DsTheriaque_Nomenclature2, SYGSP_SYNONYME_GSP).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.SYGSP_SYNONYME_GSP.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_Nomenclature2, SP_SPECIALITE).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.SP_SPECIALITE.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_Nomenclature2, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.GSP_GENERIQUE_SPECIALITE.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_Nomenclature2, "MVPSDU_MED_VIR_PERE_SA").CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.MVPSDU_MED_VIR_PERE_SA.RejectChanges()

        Me.BindingContext(Me.DsTheriaque_Nomenclature2, "MVPF_MED_VIR_PERE_FORME").CancelCurrentEdit()
        Me.DsTheriaque_Nomenclature2.MVPF_MED_VIR_PERE_FORME.RejectChanges()

        If txtCode.Text <> "" Then
            Dim strSSQL As String = ""
            'strSSQL = "Select SP_CODE_SQ_PK , SP_NOM, SP_GSP_CODE_FK From THERIAQUE.SP_SPECIALITE "
            'strSSQL &= " where SP_GSP_CODE_FK= " & txtCode.Text
            strSSQL = "SELECT SP_CODE_SQ_PK , SP_NOM, SP_GSP_CODE_FK,"
            strSSQL &= " CASE GSP.GSP_CODE_SP_REFERENCE WHEN SP_CODE_SQ_PK THEN 1 ELSE 0 END AS CheckREF"
            strSSQL &= " FROM THERIAQUE.SP_SPECIALITE SP"
            strSSQL &= " LEFT JOIN THERIAQUE.GSP_GENERIQUE_SPECIALITE GSP ON SP.SP_CODE_SQ_PK = GSP.GSP_CODE_SP_REFERENCE"
            strSSQL &= " WHERE SP_GSP_CODE_FK= " & txtCode.Text
            strSSQL &= " ORDER BY SP_CODE_SQ_PK"
            GC2.DataSource = cn.MySelect(strSSQL)
        End If
        For iCount As Integer = 0 To GV2.RowCount - 1
            GV2.DeleteRow(0)
        Next

    End Sub

    Public Overrides Function Supprimer() As Boolean
        MyBase.Supprimer()
        If Not TestFK_Used(MasterTable, "SP_CODE_SQ_PK", txtCode.EditValue) Then
            Dim inti As Integer

            Me.DsTheriaque_Nomenclature2.SP_SPECIALITE.Clear()
            For inti = 0 To GV2.RowCount - 1
                If Me.GV2.GetRowCellValue(inti, Me.colSP_CODE_SQ_PK) IsNot Nothing Then
                    Dim Res As Object = Me.DsTheriaque_Nomenclature2.SP_SPECIALITE.FindBySP_CODE_SQ_PK(Me.GV2.GetRowCellValue(inti, Me.colSP_CODE_SQ_PK))
                    If Res Is Nothing Then
                        Me.SP_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SP_SPECIALITE, Me.GV2.GetRowCellValue(inti, Me.colSP_CODE_SQ_PK))
                    End If
                End If
            Next
            For inti = 0 To Me.DsTheriaque_Nomenclature2.SP_SPECIALITE.Rows.Count - 1
                Me.DsTheriaque_Nomenclature2.SP_SPECIALITE.Item(inti)("SP_GSP_CODE_FK") = DBNull.Value
            Next
            Me.SP_TA.Update(Me.DsTheriaque_Nomenclature2)
            Me.DsTheriaque_Nomenclature2.SP_SPECIALITE.Clear()

            For inti = 0 To DsTheriaque_Nomenclature2.SYGSP_SYNONYME_GSP.Rows.Count - 1
                DsTheriaque_Nomenclature2.SYGSP_SYNONYME_GSP.Rows(0).Delete()
            Next
            Me.SygsP_TA.Update(Me.DsTheriaque_Nomenclature2)

            DsTheriaque_Nomenclature2.GSP_GENERIQUE_SPECIALITE.Rows(0).Delete()
            Me.GsP_TA.Update(Me.DsTheriaque_Nomenclature2)
            GC2.DataSource = Nothing
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Frm_MedVirtuelle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MasterTable = GSP_GENERIQUE_SPECIALITE
        MasterDataSet = Me.DsTheriaque_Nomenclature2
        FirstFocus = Me.txtCode
        'Me.statutEdit.SelectedIndex = 0 
        Dim obj1 As Data = New Data() 
        obj1.Value = "D"
        obj1.Display = "Disponible (D)"
        Dim obj2 As Data = New Data()
        obj2.Value = "S"
        obj2.Display = "NSFP (S)" 
        Dim obj3 As Data = New Data()
        obj3.Value = "A"
        obj3.Display = "Archivé (A)" 
        Dim obj4 As Data = New Data()
        obj4.Value = "N"
        obj4.Display = "NC (N)" 

        Dim dataSource As New List(Of Data)
        dataSource.Add(obj1)
        dataSource.Add(obj2)
        dataSource.Add(obj3)
        dataSource.Add(obj4)

        statutEdit.Properties.DataSource = dataSource
        statutEdit.Properties.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value"))
        statutEdit.Properties.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Display"))
        statutEdit.Properties.Columns(0).Visible = False
        statutEdit.Properties.DisplayMember = "Display"
        statutEdit.Properties.ValueMember = "Value"
        statutEdit.Properties.ShowHeader = False
        statutEdit.Text = "Disponible (D)"
        Me.GridControl1.Enabled = False
        Me.GridControl2.Enabled = False

        GridControl1.DataSource = DsTheriaque_Nomenclature2
        GridControl1.DataMember = "MVPSDU_MED_VIR_PERE_SA"

        GC1.DataSource = DsTheriaque_Nomenclature2
        GC1.DataMember = "SYGSP_SYNONYME_GSP"

    End Sub

    Public Overrides Sub InitData()
        MyBase.InitData()
        Dim strSQL As String
        strSQL = ""
        If txtCode.Text <> "" Then
            strSQL += " UNION SELECT SP_CODE_SQ_PK AS code, SP_NOM AS libelle, 1 as disable, 0 as chk ,0 as chkFixe FROM THERIAQUE.SP_SPECIALITE WHERE SP_GSP_CODE_FK = " & cn.SQLText(txtCode.Text)
        End If
        InitLkup(rpSP, SP_SPECIALITE, strSSQL_SP_SPECIALITE_WITHOUT_MEDV & strSQL, True, True)
        AddHandler GC2.EmbeddedNavigator.ButtonClick, AddressOf DeleteRow
    End Sub

    Public Sub DeleteRow(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        If Me.GV2.GetRowCellValue(GV2.FocusedRowHandle, Me.colSP_CODE_SQ_PK) IsNot DBNull.Value Then
            If e.Button.Tag = "DEL" Then
                Dim Res As Object = Me.DsTheriaque_Nomenclature2.SP_SPECIALITE.FindBySP_CODE_SQ_PK(Me.GV2.GetRowCellValue(GV2.FocusedRowHandle, Me.colSP_CODE_SQ_PK))
                'If Res Is Nothing Then
                Me.SP_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SP_SPECIALITE, Me.GV2.GetRowCellValue(GV2.FocusedRowHandle, Me.colSP_CODE_SQ_PK))
                Me.DsTheriaque_Nomenclature2.SP_SPECIALITE.Item(Me.DsTheriaque_Nomenclature2.SP_SPECIALITE.Rows.Count - 1)("SP_GSP_CODE_FK") = DBNull.Value
                GV2.DeleteRow(GV2.FocusedRowHandle)
                'End If
            End If
        End If
    End Sub

    Private Sub GV2_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV2.ValidateRow
        If Me.GV2.GetRowCellValue(e.RowHandle, Me.colSP_CODE_SQ_PK) IsNot DBNull.Value Then
            Dim Res As Object = Me.DsTheriaque_Nomenclature2.SP_SPECIALITE.FindBySP_CODE_SQ_PK(Me.GV2.GetRowCellValue(e.RowHandle, Me.colSP_CODE_SQ_PK))
            If Res Is Nothing Then
                Me.SP_TA.FillByCode(Me.DsTheriaque_Nomenclature2.SP_SPECIALITE, Me.GV2.GetRowCellValue(e.RowHandle, Me.colSP_CODE_SQ_PK))
                Me.DsTheriaque_Nomenclature2.SP_SPECIALITE.Item(Me.DsTheriaque_Nomenclature2.SP_SPECIALITE.Rows.Count - 1)("SP_GSP_CODE_FK") = Me.txtCode.Text
            End If
            If Me.GV2.GetFocusedRowCellValue(ColSP_REF) IsNot DBNull.Value Then
                If Me.GV2.GetFocusedRowCellValue(ColSP_REF) = 1 Then
                    For iCount As Integer = 0 To GV2.RowCount - 1
                        If iCount <> GV2.FocusedRowHandle Then
                            GV2.SetRowCellValue(iCount, ColSP_REF, 0)
                        End If
                    Next
                End If
            End If
        Else
            If Me.GV2.GetFocusedRowCellValue(ColSP_REF) IsNot DBNull.Value Then
                GV2.SetColumnError(colSP_CODE_SQ_PK, StrSPobligatoire)
                e.Valid = False
            End If
        End If
        
    End Sub

    Protected Friend Overrides Function ValideControl(Optional ByRef Ctrl As Control = Nothing, Optional ByVal AllCtrl As Boolean = True) As Boolean
        Dim strSSQL As String = ""
        MyBase.ValideControl(Ctrl)
        If Ctrl.Name.ToLower = "txtLibelle".ToLower Or AllCtrl Then
            'If ModeFiche = eMode.Ajout Then
            strSSQL = "  Select * from THERIAQUE.GSP_GENERIQUE_SPECIALITE where GSP_CODE_SQ_PK <> " & cn.SQLText(txtCode.Text)
            strSSQL &= " and UPPER(GSP_NOM) = " & UCase(cn.SQLText(txtLibelle.Text))
            Dim dt As DataTable = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist)
                Return False
            Else
                Me.DxErrorProvider.SetError(txtLibelle, "")
            End If
            'End If
            ''----------------------------------------------
            '' Test sur les synonymes
            ''----------------------------------------------
            ''----------------------------------------------
            strSSQL = " Select * from THERIAQUE.SYGSP_SYNONYME_GSP where UPPER(SYGSP_NOM_PK) = " & cn.SQLText(UCase(txtLibelle.Text))
            Dim dt1 As DataTable = cn.MySelect(strSSQL)
            If dt1.Rows.Count > 0 Then
                Me.DxErrorProvider.SetError(txtLibelle, StrValeurExist)
                Return False
            End If
        End If

        If GV2.RowCount = 0 Then
            Process_Message("Il faut au moin rattacher une spécialité fils", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Function
        Else
            If GV2.RowCount = 1 And GV2.GetFocusedRowCellValue("SP_GSP_CODE_FK") Is Nothing Then
                Process_Message("Il faut au moin rattacher une spécialité fils", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Function
            End If
        End If

        Return True
    End Function

    Private Sub GV_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV1.ValidatingEditor
        If e.Value IsNot Nothing Then
            Dim strSSQL As String = ""
            If e.Value = txtLibelle.Text Then
                e.ErrorText = StrValeurExist
                e.Valid = False
                Exit Sub
            End If
            strSSQL = "Select * from THERIAQUE.SYGSP_SYNONYME_GSP where SYGSP_NOM_PK = " & cn.SQLText(e.Value)
            strSSQL &= " and SYGSP_GSP_CODE_FK <> " & txtCode.Text
            Dim dt As DataTable = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                e.Valid = False
                e.ErrorText = StrValeurExist
            End If
            '---------------------------------
            '---------------------------------
            strSSQL = "  Select * from THERIAQUE.GSP_GENERIQUE_SPECIALITE where "
            strSSQL &= " UPPER(GSP_NOM) = " & UCase(cn.SQLText(e.Value))
            Dim dt2 As DataTable = cn.MySelect(strSSQL)
            If dt2.Rows.Count > 0 Then
                e.Valid = False
                e.ErrorText = StrValeurExist
            End If
            If UCase(e.Value) = UCase(txtLibelle.Text) Then
                e.Valid = False
                e.ErrorText = StrValeurExist
            End If
        End If
    End Sub

    Private Sub txtLibelle_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtLibelle.Validating
        'ValideControl(sender, False)
    End Sub

    Private Sub rpCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rpCheck.CheckedChanged
        'If Me.GV2.GetFocusedRowCellValue(ColSP_REF) IsNot DBNull.Value Then
        '    If Me.GV2.GetFocusedRowCellValue(ColSP_REF) <> 1 Then
        '        For iCount As Integer = 0 To GV2.RowCount - 1
        '            If iCount <> GV2.FocusedRowHandle Then
        '                GV2.SetRowCellValue(iCount, ColSP_REF, 0)
        '            End If
        '        Next
        '    End If
        'End If

        'End If
    End Sub

    Private Sub FillCombos()
        Dim query2 As String = "select SAV_CODE_SQ_PK as code, SAV_LIBELLE as libelle, SAV_CODE_REF as reference from  THERIAQUE.SAV_SUBSTANCE_VIRTUELLE  "
        Dim query3 As String = "SELECT  CDF_CODE_PK as code,CDF_NOM as libelle FROM THERIAQUE.CDF_CODIF where CDF_NUMERO_PK = '19' "
        query3 = " select top 0 FOV_CODE_SQ_PK as code, FOV_LIBELLE as libelle  from  THERIAQUE.FOV_FORME_VIRTUELLE union " & query3
        Dim query4 As String = "select FOV_CODE_SQ_PK as code, FOV_LIBELLE as libelle, FOV_CODE_REF as reference from  THERIAQUE.FOV_FORME_VIRTUELLE  "
        InitLkup(savlib, "SAV_SUBSTANCE_VIRTUELLE", query2, True, True)
        InitLkup(cdfnom, "CDF_CODIF", query3, True, True)
        InitLkup(fovlibelle, "FOV_FORME_VIRTUELLE", query4, True, True)
    End Sub

    Private Sub GridView1_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow

        GridView1.SetFocusedRowCellValue(colGSPCODEFKPK, txtCode.Text)
        Dim m As Integer = GetMaxN() + 1
        GridView1.SetFocusedRowCellValue(colN, m)

    End Sub

    Private Function GetMaxN() As Integer

        Dim max As Integer = 0
        For i As Integer = 0 To GridView1.RowCount - 1
            If (GridView1.GetDataRow(i) IsNot Nothing) Then
                If (GridView1.GetDataRow(i)("MVPSDU_NUM_ORD") > max) Then
                    max = GridView1.GetDataRow(i)("MVPSDU_NUM_ORD")
                End If
            End If
        Next

        Return max
    End Function

    Private Sub GridView2_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView2.InitNewRow
        GridView2.SetFocusedRowCellValue(col_GSP_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GridView1_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

    End Sub

    Private Sub GV_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV1.InitNewRow
        GV1.SetFocusedRowCellValue(colSYGSP_GSP_CODE_FK1, txtCode.Text)
    End Sub
End Class
Public Class Data
    Public Property Display() As String
        Get
            Return m_Display
        End Get
        Set(ByVal value As String)
            m_Display = Value
        End Set
    End Property
    Private m_Display As String
    Public Property Value() As Char
        Get
            Return m_Value
        End Get
        Set(ByVal value As Char)
            m_Value = Value
        End Set
    End Property
    Private m_Value As Char
End Class