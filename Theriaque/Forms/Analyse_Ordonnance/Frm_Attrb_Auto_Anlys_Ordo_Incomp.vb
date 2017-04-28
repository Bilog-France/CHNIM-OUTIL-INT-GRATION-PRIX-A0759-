Public Class Frm_Attrb_Auto_Anlys_Ordo_Incomp

    Private CodE As String
    Private Const Const_ATT = "Attribution automatique"
    Public _Type_AttAuto As AttAuto_AnalysOrdo

#Region " Edit Data  "

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche

        Select Case _Type_AttAuto
            Case AttAuto_AnalysOrdo.CCH
                f._SSQL = strSSQL_CCH_CLASSECHIMIQUE
            Case AttAuto_AnalysOrdo.CPH
                f._SSQL = strSSQL_CPH_CLASSEPHARMTHER
            Case AttAuto_AnalysOrdo.SP
                f._SSQL = strSSQL_SP_SPECIALITE
            Case AttAuto_AnalysOrdo.SUB_AC
                f._SSQL = strSSQL_SAC_SUBACTIVE
            Case AttAuto_AnalysOrdo.SUB_AUX
                f._SSQL = strSSQL_SAU_SUBAUXILIAIRE
        End Select

        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            OnLoading = True

            txtCode.Text = CodE
            txtLibelle.Text = f._Libelle
            BackgroundWorker_DoWork()
            btSupprimer.Enabled = False
            OnLoading = False
            'Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Function supprimer() As Boolean
        Dim dtTemp As DataTable
        Dim strSSQL As String
        Select Case _Type_AttAuto
            Case AttAuto_AnalysOrdo.SP
                strSSQL = " select cast(IC1SP_FIC_CODE_FK_PK  as varchar) as code from THERIAQUE.IC1SP_TERME1SPECIALITE"
                strSSQL &= " where IC1SP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text)
                dtTemp = cn.MySelect(strSSQL)
                If dtTemp.Rows.Count > 0 Then
                    If dtTemp.Rows.Count > 0 Then
                        For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                            cn.Execute("DELETE FROM THERIAQUE.IC1SP_TERME1SPECIALITE WHERE IC1SP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND IC1SP_FIC_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
                        Next
                    End If
                End If
                'Terme2
                strSSQL = " select cast(IC2SP_FIC_CODE_FK_PK as varchar) as code from THERIAQUE.IC2SP_TERME2SPECIALITE"
                strSSQL &= " where IC2SP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text)
                dtTemp = cn.MySelect(strSSQL)
                If dtTemp.Rows.Count > 0 Then
                    If dtTemp.Rows.Count > 0 Then
                        For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                            cn.Execute("DELETE FROM THERIAQUE.IC2SP_TERME2SPECIALITE WHERE IC2SP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND IC2SP_FIC_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
                        Next
                    End If
                End If

            Case AttAuto_AnalysOrdo.SUB_AC
                strSSQL = " select cast(IC1SAC_FIC_CODE_FK_PK  as varchar) as code from THERIAQUE.IC1SAC_TERME1SUBACT"
                strSSQL &= " where IC1SAC_SAC_CODE_FK_PK = " & cn.SQLText(txtCode2.Text)
                dtTemp = cn.MySelect(strSSQL)
                If dtTemp.Rows.Count > 0 Then
                    If dtTemp.Rows.Count > 0 Then
                        For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                            cn.Execute("DELETE FROM THERIAQUE.IC1SAC_TERME1SUBACT WHERE IC1SAC_SAC_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND IC1SAC_FIC_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
                        Next
                    End If
                End If
                'Terme2
                strSSQL = " select cast(IC2SAC_FIC_CODE_FK_PK as varchar) as code from THERIAQUE.IC2SAC_TERME2SUBACT"
                strSSQL &= " where IC2SAC_SAC_CODE_FK_PK = " & cn.SQLText(txtCode2.Text)
                dtTemp = cn.MySelect(strSSQL)
                If dtTemp.Rows.Count > 0 Then
                    If dtTemp.Rows.Count > 0 Then
                        For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                            cn.Execute("DELETE FROM THERIAQUE.IC2SAC_TERME2SUBACT WHERE IC2SAC_SAC_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND IC2SAC_FIC_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
                        Next
                    End If
                End If

            Case AttAuto_AnalysOrdo.SUB_AUX
                strSSQL = " select cast(IC1SAU_FIC_CODE_FK_PK  as varchar) as code from THERIAQUE.IC1SAU_TERME1SUBAUX"
                strSSQL &= " where IC1SAU_SAU_CODE_FK_PK = " & cn.SQLText(txtCode2.Text)
                dtTemp = cn.MySelect(strSSQL)
                If dtTemp.Rows.Count > 0 Then
                    If dtTemp.Rows.Count > 0 Then
                        For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                            cn.Execute("DELETE FROM THERIAQUE.IC1SAU_TERME1SUBAUX WHERE IC1SAU_SAU_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND IC1SAU_FIC_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
                        Next
                    End If
                End If
                'Terme2
                strSSQL = " select cast(IC2SAU_FIC_CODE_FK_PK as varchar) as code from THERIAQUE.IC2SAU_TERME2SUBAUX"
                strSSQL &= " where IC2SAU_SAU_CODE_FK_PK = " & cn.SQLText(txtCode2.Text)
                dtTemp = cn.MySelect(strSSQL)
                If dtTemp.Rows.Count > 0 Then
                    If dtTemp.Rows.Count > 0 Then
                        For iCount As Integer = 0 To dtTemp.Rows.Count - 1
                            cn.Execute("DELETE FROM THERIAQUE.IC2SAU_TERME2SUBAUX WHERE IC2SAU_SAU_CODE_FK_PK = " & cn.SQLText(txtCode2.Text) & " AND IC2SAU_FIC_CODE_FK_PK = " & dtTemp.Rows(iCount)(0))
                        Next
                    End If
                End If
        End Select
        txtCode2.Text = ""
        txtLibelle2.Text = ""
        'BackgroundWorker_DoWork()
        Return True
    End Function

    Public Overrides Sub ajouter()
        MyBase.Ajouter()
        Dim f As New Frm_Recherche

        Select Case _Type_AttAuto
            Case AttAuto_AnalysOrdo.CCH
                f._SSQL = strSSQL_CCH_CLASSECHIMIQUE
            Case AttAuto_AnalysOrdo.CPH
                f._SSQL = strSSQL_CPH_CLASSEPHARMTHER
            Case AttAuto_AnalysOrdo.SP
                f._SSQL = strSSQL_SP_SPECIALITE
            Case AttAuto_AnalysOrdo.SUB_AC
                f._SSQL = strSSQL_SAC_SUBACTIVE
            Case AttAuto_AnalysOrdo.SUB_AUX
                f._SSQL = strSSQL_SAU_SUBAUXILIAIRE
        End Select

        f.Text = Me.Text
        btValider.Enabled = False
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            OnLoading = True

            txtCode2.Text = CodE
            txtLibelle2.Text = f._Libelle

            'If Not TestEntiteSimilaire_Exist(CodE) Then
            btValider.Enabled = True
            If txtCode.Text = txtCode2.Text Then
                btValider.Enabled = False
            End If
            If Not TestEntiteSimilaire_Exist(txtCode.Text) Then
                btValider.Enabled = False
            End If
            'Else
            '    btValider.Enabled = False
            'End If
            If TestEntiteSimilaire_Exist(CodE) And TestEntiteSimilaire_Exist(txtCode.Text) Then
                btSupprimer.Enabled = True
            Else
                btSupprimer.Enabled = False
            End If
            OnLoading = False
        End If
    End Sub

    Public Overrides Sub valider()
        MyBase.Valider()
        Dim dtTemp1 As DataTable
        Dim dtTemp2 As DataTable
        Dim strSSQL As String
        Dim bExist As Boolean = False
        Select Case _Type_AttAuto
            Case AttAuto_AnalysOrdo.SP
                'Terme1
                strSSQL = " select cast(IC1SP_FIC_CODE_FK_PK  as varchar) as code from THERIAQUE.IC1SP_TERME1SPECIALITE"
                strSSQL &= " where IC1SP_SP_CODE_FK_PK = " & cn.SQLText(txtCode.Text)
                dtTemp1 = cn.MySelect(strSSQL)
                If dtTemp1.Rows.Count > 0 Then
                    For iCount As Integer = 0 To dtTemp1.Rows.Count - 1
                        Dim dtCPH As DataTable = cn.MySelect("SELECT IC1SP_SP_CODE_FK_PK FROM THERIAQUE.IC1SP_TERME1SPECIALITE WHERE IC1SP_FIC_CODE_FK_PK = " & dtTemp1.Rows(iCount)(0) & " AND IC1SP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text))
                        If dtCPH.Rows.Count > 0 Then
                            bExist = True
                        End If
                        If Not bExist Then
                            cn.Execute("Insert into THERIAQUE.IC1SP_TERME1SPECIALITE values (" & dtTemp1.Rows(iCount)(0) & "," & cn.SQLText(txtCode2.Text) & ")")
                        End If
                    Next
                End If
                'Terme2
                strSSQL = " select cast(IC2SP_FIC_CODE_FK_PK as varchar) as code from THERIAQUE.IC2SP_TERME2SPECIALITE"
                strSSQL &= " where IC2SP_SP_CODE_FK_PK = " & cn.SQLText(txtCode.Text)
                dtTemp2 = cn.MySelect(strSSQL)

                If dtTemp2.Rows.Count > 0 Then
                    For iCount As Integer = 0 To dtTemp2.Rows.Count - 1
                        Dim dtCPH As DataTable = cn.MySelect("SELECT IC2SP_SP_CODE_FK_PK FROM THERIAQUE.IC2SP_TERME2SPECIALITE WHERE IC2SP_FIC_CODE_FK_PK = " & dtTemp2.Rows(iCount)(0) & " AND IC2SP_SP_CODE_FK_PK = " & cn.SQLText(txtCode2.Text))
                        If dtCPH.Rows.Count > 0 Then
                            bExist = True
                        End If
                        If Not bExist Then
                            cn.Execute("Insert into THERIAQUE.IC2SP_TERME2SPECIALITE values (" & dtTemp2.Rows(iCount)(0) & "," & cn.SQLText(txtCode2.Text) & ")")
                        End If
                    Next
                End If

            Case AttAuto_AnalysOrdo.SUB_AC
                'Terme1
                strSSQL = " select cast(IC1SAC_FIC_CODE_FK_PK  as varchar) as code from THERIAQUE.IC1SAC_TERME1SUBACT"
                strSSQL &= " where IC1SAC_SAC_CODE_FK_PK = " & cn.SQLText(txtCode.Text)
                dtTemp1 = cn.MySelect(strSSQL)
                If dtTemp1.Rows.Count > 0 Then
                    For iCount As Integer = 0 To dtTemp1.Rows.Count - 1
                        Dim dtCPH As DataTable = cn.MySelect("SELECT IC1SAC_SAC_CODE_FK_PK FROM THERIAQUE.IC1SAC_TERME1SUBACT WHERE IC1SAC_FIC_CODE_FK_PK = " & dtTemp1.Rows(iCount)(0) & " AND IC1SAC_SAC_CODE_FK_PK = " & cn.SQLText(txtCode2.Text))
                        If dtCPH.Rows.Count > 0 Then
                            bExist = True
                        End If
                        If Not bExist Then
                            cn.Execute("Insert into THERIAQUE.IC1SAC_TERME1SUBACT values (" & dtTemp1.Rows(iCount)(0) & "," & cn.SQLText(txtCode2.Text) & ")")
                        End If
                    Next
                End If
                'Terme2
                strSSQL = " select cast(IC2SAC_FIC_CODE_FK_PK as varchar) as code from THERIAQUE.IC2SAC_TERME2SUBACT"
                strSSQL &= " where IC2SAC_SAC_CODE_FK_PK = " & cn.SQLText(txtCode.Text)
                dtTemp2 = cn.MySelect(strSSQL)
                If dtTemp2.Rows.Count > 0 Then
                    For iCount As Integer = 0 To dtTemp2.Rows.Count - 1
                        Dim dtCPH As DataTable = cn.MySelect("SELECT IC2SAC_SAC_CODE_FK_PK FROM THERIAQUE.IC2SAC_TERME2SUBACT WHERE IC2SAC_FIC_CODE_FK_PK = " & dtTemp2.Rows(iCount)(0) & " AND IC2SAC_SAC_CODE_FK_PK = " & cn.SQLText(txtCode2.Text))
                        If dtCPH.Rows.Count > 0 Then
                            bExist = True
                        End If
                        If Not bExist Then
                            cn.Execute("Insert into THERIAQUE.IC2SAC_TERME2SUBACT values (" & dtTemp2.Rows(iCount)(0) & "," & cn.SQLText(txtCode2.Text) & ")")
                        End If
                    Next
                End If

            Case AttAuto_AnalysOrdo.SUB_AUX
                'Terme1
                strSSQL = " select cast(IC1SAU_FIC_CODE_FK_PK  as varchar) as code from THERIAQUE.IC1SAU_TERME1SUBAUX"
                strSSQL &= " where IC1SAU_SAU_CODE_FK_PK = " & cn.SQLText(txtCode.Text)
                dtTemp1 = cn.MySelect(strSSQL)
                If dtTemp1.Rows.Count > 0 Then
                    For iCount As Integer = 0 To dtTemp1.Rows.Count - 1
                        Dim dtCPH As DataTable = cn.MySelect("SELECT IC1SAU_SAU_CODE_FK_PK FROM THERIAQUE.IC1SAU_TERME1SUBAUX WHERE IC1SAU_FIC_CODE_FK_PK = " & dtTemp1.Rows(iCount)(0) & " AND IC1SAU_SAU_CODE_FK_PK = " & cn.SQLText(txtCode2.Text))
                        If dtCPH.Rows.Count > 0 Then
                            bExist = True
                        End If
                        If Not bExist Then
                            cn.Execute("Insert into THERIAQUE.IC1SAU_TERME1SUBAUX values (" & dtTemp1.Rows(iCount)(0) & "," & cn.SQLText(txtCode2.Text) & ")")
                        End If
                    Next
                End If
                'Terme2
                strSSQL = " select cast(IC2SAU_FIC_CODE_FK_PK as varchar) as code from THERIAQUE.IC2SAU_TERME2SUBAUX"
                strSSQL &= " where IC2SAU_SAU_CODE_FK_PK = " & cn.SQLText(txtCode.Text)
                dtTemp2 = cn.MySelect(strSSQL)
                If dtTemp2.Rows.Count > 0 Then
                    For iCount As Integer = 0 To dtTemp2.Rows.Count - 1
                        Dim dtCPH As DataTable = cn.MySelect("SELECT IC2SAU_SAU_CODE_FK_PK FROM THERIAQUE.IC2SAU_TERME2SUBAUX WHERE IC2SAU_FIC_CODE_FK_PK = " & dtTemp2.Rows(iCount)(0) & " AND IC2SAU_SAU_CODE_FK_PK = " & cn.SQLText(txtCode2.Text))
                        If dtCPH.Rows.Count > 0 Then
                            bExist = True
                        End If
                        If Not bExist Then
                            cn.Execute("Insert into THERIAQUE.IC2SAU_TERME2SUBAUX values (" & dtTemp2.Rows(iCount)(0) & "," & cn.SQLText(txtCode2.Text) & ")")
                        End If
                    Next
                End If
        End Select
        'BackgroundWorker_DoWork()
    End Sub

    Public Overrides Sub annuler()
        OnLoading = True
        MyBase.Annuler()

        txtCode2.Text = ""
        txtLibelle2.Text = ""

        OnLoading = False
    End Sub

#End Region

    Private Sub BackgroundWorker_DoWork()
        ProgressBar.Visible = True
        Dim dt As New DataTable

        Select Case _Type_AttAuto
            Case AttAuto_AnalysOrdo.SP
                Dim strSSQL As String = ""
                strSSQL &= " select cast(IC1SP_FIC_CODE_FK_PK as varchar) as code from THERIAQUE.IC1SP_TERME1SPECIALITE "
                strSSQL &= " where IC1SP_SP_CODE_FK_PK = " & CodE
                strSSQL &= " Union "
                strSSQL &= " select cast(IC2SP_FIC_CODE_FK_PK as varchar) as code from THERIAQUE.IC2SP_TERME2SPECIALITE "
                strSSQL &= " where IC2SP_SP_CODE_FK_PK = " & CodE
                Label1.Text = Const_ATT & ": spécialité "
                dt = cn.MySelect(strSSQL)
            Case AttAuto_AnalysOrdo.SUB_AC
                Dim strSSQL As String = ""
                strSSQL &= " select cast(IC1SAC_FIC_CODE_FK_PK as varchar) as code from THERIAQUE.IC1SAC_TERME1SUBACT "
                strSSQL &= " where IC1SAC_SAC_CODE_FK_PK = " & CodE
                strSSQL &= " Union "
                strSSQL &= " select cast(IC2SAC_FIC_CODE_FK_PK as varchar) as code from THERIAQUE.IC2SAC_TERME2SUBACT "
                strSSQL &= " where IC2SAC_SAC_CODE_FK_PK = " & CodE
                Label1.Text = Const_ATT & ": substance active"
                dt = cn.MySelect(strSSQL)
            Case AttAuto_AnalysOrdo.SUB_AUX
                Dim strSSQL As String = ""
                strSSQL &= " select cast(IC1SAU_FIC_CODE_FK_PK as varchar) as code from THERIAQUE.IC1SAU_TERME1SUBAUX "
                strSSQL &= " where IC1SAU_SAU_CODE_FK_PK = " & CodE
                strSSQL &= " Union "
                strSSQL &= " select cast(IC2SAU_FIC_CODE_FK_PK as varchar) as code from THERIAQUE.IC2SAU_TERME2SUBAUX "
                strSSQL &= " where IC2SAU_SAU_CODE_FK_PK = " & CodE
                Label1.Text = Const_ATT & ": excipient"
                dt = cn.MySelect(strSSQL)
        End Select
        GC.DataSource = dt
        ProgressBar.Visible = False
    End Sub

    Public Overrides Sub InitData()
        'btAjouter.Enabled = False
    End Sub

    Private Sub rpBTEDIT_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rpBTEDIT.ButtonClick
        If Me.CardView1.GetFocusedRowCellValue(Me.Col2) IsNot Nothing Then
            Dim f As New Frm_Incompatibilites_Fiche
            f._Code = Me.CardView1.GetFocusedRowCellValue(Me.Col2)
            f.MdiParent = FMain
            f.Show()
        End If
    End Sub
    Private Function TestEntiteSimilaire_Exist(Optional ByVal sCodeEntiteSimilaire As String = "") As Boolean
        TestEntiteSimilaire_Exist = False
        Dim dtTemp As DataTable
        Dim strSSQL As String
        Select Case _Type_AttAuto
            Case AttAuto_AnalysOrdo.SP
                'Terme1
                strSSQL = " select cast(IC1SP_FIC_CODE_FK_PK  as varchar) as code from THERIAQUE.IC1SP_TERME1SPECIALITE"
                strSSQL &= " where IC1SP_SP_CODE_FK_PK = " & cn.SQLText(sCodeEntiteSimilaire)
                dtTemp = cn.MySelect(strSSQL)
                If dtTemp.Rows.Count > 0 Then
                    TestEntiteSimilaire_Exist = True
                    Exit Function
                End If
                'Terme2
                strSSQL = " select cast(IC2SP_FIC_CODE_FK_PK as varchar) as code from THERIAQUE.IC2SP_TERME2SPECIALITE"
                strSSQL &= " where IC2SP_SP_CODE_FK_PK = " & cn.SQLText(sCodeEntiteSimilaire)
                dtTemp = cn.MySelect(strSSQL)
                If dtTemp.Rows.Count > 0 Then
                    TestEntiteSimilaire_Exist = True
                    Exit Function
                End If

            Case AttAuto_AnalysOrdo.SUB_AC
                strSSQL = " select cast(IC1SAC_FIC_CODE_FK_PK  as varchar) as code from THERIAQUE.IC1SAC_TERME1SUBACT"
                strSSQL &= " where IC1SAC_SAC_CODE_FK_PK = " & cn.SQLText(sCodeEntiteSimilaire)
                dtTemp = cn.MySelect(strSSQL)
                If dtTemp.Rows.Count > 0 Then
                    TestEntiteSimilaire_Exist = True
                    Exit Function
                End If
                'Terme2
                strSSQL = " select cast(IC2SAC_FIC_CODE_FK_PK as varchar) as code from THERIAQUE.IC2SAC_TERME2SUBACT"
                strSSQL &= " where IC2SAC_SAC_CODE_FK_PK = " & cn.SQLText(sCodeEntiteSimilaire)
                dtTemp = cn.MySelect(strSSQL)
                If dtTemp.Rows.Count > 0 Then
                    TestEntiteSimilaire_Exist = True
                    Exit Function
                End If

            Case AttAuto_AnalysOrdo.SUB_AUX
                strSSQL = " select cast(IC1SAU_FIC_CODE_FK_PK  as varchar) as code from THERIAQUE.IC1SAU_TERME1SUBAUX"
                strSSQL &= " where IC1SAU_SAU_CODE_FK_PK = " & cn.SQLText(sCodeEntiteSimilaire)
                dtTemp = cn.MySelect(strSSQL)
                If dtTemp.Rows.Count > 0 Then
                    TestEntiteSimilaire_Exist = True
                    Exit Function
                End If
                'Terme2
                strSSQL = " select cast(IC2SAU_FIC_CODE_FK_PK as varchar) as code from THERIAQUE.IC2SAU_TERME2SUBAUX"
                strSSQL &= " where IC2SAU_SAU_CODE_FK_PK = " & cn.SQLText(sCodeEntiteSimilaire)
                dtTemp = cn.MySelect(strSSQL)
                If dtTemp.Rows.Count > 0 Then
                    TestEntiteSimilaire_Exist = True
                    Exit Function
                End If
        End Select
    End Function

End Class
