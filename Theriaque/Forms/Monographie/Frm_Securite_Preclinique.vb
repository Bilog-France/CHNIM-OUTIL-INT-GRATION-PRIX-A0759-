''' <summary>
''' Created By [BFE]
''' </summary>
''' <remarks> Monographie - Sécurité préclinique
''' </remarks>
Public Class Frm_Securite_Preclinique
#Region "Déclaration des variables privées"
    Private CodE As String
    Public _Code As Integer = Nothing ' charger la fiche depuis l'extérieur
    Private Tab_lkup1 As Boolean = False
    Private Tab_TA1 As Boolean = False
    Private bModeDuplication As Boolean = False
#End Region

#Region " Edit Data  "

    Public Overrides Function Chercher() As Boolean
        MyBase.Chercher()
        Dim f As New Frm_Recherche
        f._SSQL = strSSQL_FPRCL_SECPRECLIN_SPECIALITE()
        f.Text = Me.Text
        f.ShowDialog()
        CodE = f._Code
        If f._Code IsNot Nothing Then
            XtraTabControl1.SelectedTabPageIndex = 0
            OnLoading = True
            EmptyDataTable()
            Me.FprcL_TA.FillByCode(Me.DsTheriaque_SecuritePreclinique.FPRCL_SECPRECLIN, f._Code)

            'Onglet Entités
            Me.FprclcpH_TA.FillByCode(Me.DsTheriaque_SecuritePreclinique.FPRCLCPH_FPRCL_CLPH, f._Code)
            Me.FprclccH_TA.FillByCode(Me.DsTheriaque_SecuritePreclinique.FPRCLCCH_FPRCL_CLCH, f._Code)
            Me.FprclsaC_TA.FillByCode(Me.DsTheriaque_SecuritePreclinique.FPRCLSAC_FPRCL_SUBACT, f._Code)
            Me.FprclsaU_TA.FillByCode(Me.DsTheriaque_SecuritePreclinique.FPRCLSAU_FPRCL_SUBAUX, f._Code)
            Me.FprclpR_TA.FillByCode(Me.DsTheriaque_SecuritePreclinique.FPRCLPR_FPRCL_PROD, f._Code)
            Me.FprclsP_TA.FillByCode(Me.DsTheriaque_SecuritePreclinique.FPRCLSP_SECPRECLIN_SPEC, f._Code)

            Tab_TA1 = False
            bModeDuplication = False
            OnLoading = False
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
        Dim sCodeCOM As String = ""
        Dim sCodePR As String = ""
        Dim sCodeSAC As String = ""
        Dim sCodeSAU As String = ""
        Dim sCodeSP As String = ""
        Dim f As New Frm_SecuritePrecMultiCriteres
        f.ShowDialog()
        If f._Validate Then
            If f._bCPH Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CPH_CLASSEPHARMTHER
                fDICO.Text = "Classes pharmaco-thérapeutique"
                fDICO.ShowDialog()
                sCodeCPH = fDICO._Code
            End If
            If f._bCCH Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CCH_CLASSECHIMIQUE
                fDICO.Text = "Classes chimiques"
                fDICO.ShowDialog()
                sCodeCCH = fDICO._Code
            End If
            If f._bCOM Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_CDF_CODIF("PK")
                fDICO.Text = "Commentaires"
                fDICO.ShowDialog()
                sCodeCOM = fDICO._Code
            End If
            If f._bPR Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_PR_PRODUIT
                fDICO.Text = "Produits"
                fDICO.ShowDialog()
                sCodePR = fDICO._Code
            End If
            If f._bSAC Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SAC_SUBACTIVE
                fDICO.Text = "Substances actives"
                fDICO.ShowDialog()
                sCodeSAC = fDICO._Code
            End If
            If f._bSAU Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SAU_SUBAUXILIAIRE
                fDICO.Text = "Excipients"
                fDICO.ShowDialog()
                sCodeSAU = fDICO._Code
            End If
            If f._bSP Then
                Dim fDICO As New Frm_Recherche
                fDICO._SSQL = strSSQL_SP_SPECIALITE
                fDICO.Text = "Spécialités"
                fDICO.ShowDialog()
                sCodeSP = fDICO._Code
            End If
            Dim fResultat As New Frm_Recherche
            Dim sSQL As String = ""

            sSQL &= " SELECT FPRCL_CODE_SQ_PK AS code, '' AS libelle FROM THERIAQUE.FPRCL_SECPRECLIN  "
            If sCodeCPH <> "" Then
                sSQL &= " WHERE FPRCL_CODE_SQ_PK IN (SELECT FPRCLCPH_FPRCL_CODE_FK_PK FROM THERIAQUE.FPRCLCPH_FPRCL_CLPH WHERE FPRCLCPH_CPH_CODE_FK_PK = " & cn.SQLText(sCodeCPH) & ")"
            End If
            If sCodeCCH <> "" Then
                If sCodeCPH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPRCL_CODE_SQ_PK IN (SELECT FPRCLCCH_FPRCL_CODE_FK_PK FROM THERIAQUE.FPRCLCCH_FPRCL_CLCH WHERE FPRCLCCH_CCH_CODE_FK_PK = " & cn.SQLText(sCodeCCH) & ")"
            End If
            If sCodeSAC <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPRCL_CODE_SQ_PK IN (SELECT FPRCLSAC_FPRCL_CODE_FK_PK FROM THERIAQUE.FPRCLSAC_FPRCL_SUBACT WHERE FPRCLSAC_SAC_CODE_FK_PK = " & cn.SQLText(sCodeSAC) & ")"
            End If
            If sCodeSAU <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPRCL_CODE_SQ_PK IN (SELECT FPRCLSAU_FPRCL_CODE_FK_PK FROM THERIAQUE.FPRCLSAU_FPRCL_SUBAUX WHERE FPRCLSAU_SAU_CODE_FK_PK = " & cn.SQLText(sCodeSAU) & ")"
            End If
            If sCodePR <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPRCL_CODE_SQ_PK IN (SELECT FPRCLPR_FPRCL_CODE_FK_PK FROM THERIAQUE.FPRCLPR_FPRCL_PROD WHERE FPRCLPR_PR_CODE_FK_PK = " & cn.SQLText(sCodePR) & ")"
            End If
            If sCodeSP <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPRCL_CODE_SQ_PK IN (SELECT FPRCLSP_FPRCL_CODE_FK_PK FROM THERIAQUE.FPRCLSP_SECPRECLIN_SPEC WHERE FPRCLSP_SP_CODE_FK_PK = " & cn.SQLText(sCodeSP) & ")"
            End If
            If sCodeCOM <> "" Then
                If sCodeCPH <> "" Or sCodeCCH <> "" Or sCodeSAC <> "" Or sCodeSAU <> "" Or sCodePR <> "" Or sCodeSP <> "" Then
                    sSQL &= " AND"
                Else
                    sSQL &= " WHERE"
                End If
                sSQL &= " FPRCL_CODE_SQ_PK IN (SELECT FPRCLCOM_FPRCL_CODE_FK_PK FROM THERIAQUE.FPRCLCOM_FPRCL_COM WHERE FPRCLCOM_CDF_CODE_FK_PK = " & cn.SQLText(sCodeCOM) & ")"
            End If
            sSQL &= " ORDER BY FPRCL_CODE_SQ_PK"

            fResultat._SSQL = sSQL
            fResultat.Text = Me.Text
            fResultat.ShowDialog()
            CodE = fResultat._Code
            If fResultat._Code IsNot Nothing Then
                XtraTabControl1.SelectedTabPageIndex = 0
                OnLoading = True
                EmptyDataTable()
                Me.FprcL_TA.FillByCode(Me.DsTheriaque_SecuritePreclinique.FPRCL_SECPRECLIN, fResultat._Code)

                'Onglet Entités
                Me.FprclcpH_TA.FillByCode(Me.DsTheriaque_SecuritePreclinique.FPRCLCPH_FPRCL_CLPH, fResultat._Code)
                Me.FprclccH_TA.FillByCode(Me.DsTheriaque_SecuritePreclinique.FPRCLCCH_FPRCL_CLCH, fResultat._Code)
                Me.FprclsaC_TA.FillByCode(Me.DsTheriaque_SecuritePreclinique.FPRCLSAC_FPRCL_SUBACT, fResultat._Code)
                Me.FprclsaU_TA.FillByCode(Me.DsTheriaque_SecuritePreclinique.FPRCLSAU_FPRCL_SUBAUX, fResultat._Code)
                Me.FprclpR_TA.FillByCode(Me.DsTheriaque_SecuritePreclinique.FPRCLPR_FPRCL_PROD, fResultat._Code)
                Me.FprclsP_TA.FillByCode(Me.DsTheriaque_SecuritePreclinique.FPRCLSP_SECPRECLIN_SPEC, fResultat._Code)

                Tab_TA1 = False
                bModeDuplication = False
                OnLoading = False
                Return True
            Else
                Return False
            End If
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
        bModeDuplication = False
        XtraTabControl1.SelectedTabPageIndex = 0
    End Sub
    Public Overrides Function supprimer() As Boolean
        MyBase.Supprimer()
        Dim iCount As Integer
        If Tab_TA1 Then
            'Onglet Entités
            For iCount = 0 To DsTheriaque_SecuritePreclinique.FPRCLCPH_FPRCL_CLPH.Rows.Count - 1
                DsTheriaque_SecuritePreclinique.FPRCLCPH_FPRCL_CLPH.Rows(iCount).Delete()
            Next
            Me.FprclcpH_TA.Update(DsTheriaque_SecuritePreclinique)

            For iCount = 0 To DsTheriaque_SecuritePreclinique.FPRCLCCH_FPRCL_CLCH.Rows.Count - 1
                DsTheriaque_SecuritePreclinique.FPRCLCCH_FPRCL_CLCH.Rows(iCount).Delete()
            Next
            Me.FprclccH_TA.Update(DsTheriaque_SecuritePreclinique)

            For iCount = 0 To DsTheriaque_SecuritePreclinique.FPRCLSAC_FPRCL_SUBACT.Rows.Count - 1
                DsTheriaque_SecuritePreclinique.FPRCLSAC_FPRCL_SUBACT.Rows(iCount).Delete()
            Next
            Me.FprclsaC_TA.Update(DsTheriaque_SecuritePreclinique)

            For iCount = 0 To DsTheriaque_SecuritePreclinique.FPRCLSAU_FPRCL_SUBAUX.Rows.Count - 1
                DsTheriaque_SecuritePreclinique.FPRCLSAU_FPRCL_SUBAUX.Rows(iCount).Delete()
            Next
            Me.FprclsaU_TA.Update(DsTheriaque_SecuritePreclinique)

            For iCount = 0 To DsTheriaque_SecuritePreclinique.FPRCLPR_FPRCL_PROD.Rows.Count - 1
                DsTheriaque_SecuritePreclinique.FPRCLPR_FPRCL_PROD.Rows(iCount).Delete()
            Next
            Me.FprclpR_TA.Update(DsTheriaque_SecuritePreclinique)

            For iCount = 0 To DsTheriaque_SecuritePreclinique.FPRCLSP_SECPRECLIN_SPEC.Rows.Count - 1
                DsTheriaque_SecuritePreclinique.FPRCLSP_SECPRECLIN_SPEC.Rows(iCount).Delete()
            Next
            Me.FprclsP_TA.Update(DsTheriaque_SecuritePreclinique)

            For iCount = 0 To DsTheriaque_SecuritePreclinique.FPRCLAFS_FPRCL_AFSSAPS.Rows.Count - 1
                DsTheriaque_SecuritePreclinique.FPRCLAFS_FPRCL_AFSSAPS.Rows(iCount).Delete()
            Next
            Me.FprclafS_TA.Update(DsTheriaque_SecuritePreclinique)

            ' Master
            DsTheriaque_SecuritePreclinique.FPRCL_SECPRECLIN.Rows(0).Delete()
            Me.FprcL_TA.Update(Me.MasterDataSet)

            bModeDuplication = False
            Return True
        Else
            Process_Message(strChargementOnglet, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

    End Function
    Public Overrides Sub valider()
        MyBase.Valider()
        Me.BindingContext(Me.MasterDataSet, MasterTable).EndCurrentEdit()
        FprcL_TA.Update(Me.DsTheriaque_SecuritePreclinique.FPRCL_SECPRECLIN)
        'Onglet Entités
        Me.BindingContext(Me.MasterDataSet, FPRCLCPH_FPRCL_CLPH).EndCurrentEdit()
        FprclcpH_TA.Update(Me.DsTheriaque_SecuritePreclinique.FPRCLCPH_FPRCL_CLPH)

        Me.BindingContext(Me.MasterDataSet, FPRCLCCH_FPRCL_CLCH).EndCurrentEdit()
        FprclccH_TA.Update(Me.DsTheriaque_SecuritePreclinique.FPRCLCCH_FPRCL_CLCH)

        Me.BindingContext(Me.MasterDataSet, FPRCLSAC_FPRCL_SUBACT).EndCurrentEdit()
        FprclsaC_TA.Update(Me.DsTheriaque_SecuritePreclinique.FPRCLSAC_FPRCL_SUBACT)

        Me.BindingContext(Me.MasterDataSet, FPRCLSAU_FPRCL_SUBAUX).EndCurrentEdit()
        FprclsaU_TA.Update(Me.DsTheriaque_SecuritePreclinique.FPRCLSAU_FPRCL_SUBAUX)

        Me.BindingContext(Me.MasterDataSet, FPRCLPR_FPRCL_PROD).EndCurrentEdit()
        FprclpR_TA.Update(Me.DsTheriaque_SecuritePreclinique.FPRCLPR_FPRCL_PROD)

        Me.BindingContext(Me.MasterDataSet, FPRCLSP_SECPRECLIN_SPEC).EndCurrentEdit()
        FprclsP_TA.Update(Me.DsTheriaque_SecuritePreclinique.FPRCLSP_SECPRECLIN_SPEC)

        Me.BindingContext(Me.MasterDataSet, FPRCLAFS_FPRCL_AFSSAPS).EndCurrentEdit()
        FprclafS_TA.Update(Me.DsTheriaque_SecuritePreclinique.FPRCLAFS_FPRCL_AFSSAPS)

        bModeDuplication = False
        'Tab_TA1 = True
    End Sub
    Public Overrides Sub annuler()
        OnLoading = True
        MyBase.Annuler()
        'Onglet Entités
        Me.BindingContext(DsTheriaque_SecuritePreclinique, FPRCLCPH_FPRCL_CLPH).CancelCurrentEdit()
        Me.DsTheriaque_SecuritePreclinique.FPRCLCPH_FPRCL_CLPH.RejectChanges()

        Me.BindingContext(DsTheriaque_SecuritePreclinique, FPRCLCCH_FPRCL_CLCH).CancelCurrentEdit()
        Me.DsTheriaque_SecuritePreclinique.FPRCLCCH_FPRCL_CLCH.RejectChanges()

        Me.BindingContext(DsTheriaque_SecuritePreclinique, FPRCLSAC_FPRCL_SUBACT).CancelCurrentEdit()
        Me.DsTheriaque_SecuritePreclinique.FPRCLSAC_FPRCL_SUBACT.RejectChanges()

        Me.BindingContext(DsTheriaque_SecuritePreclinique, FPRCLSAU_FPRCL_SUBAUX).CancelCurrentEdit()
        Me.DsTheriaque_SecuritePreclinique.FPRCLSAU_FPRCL_SUBAUX.RejectChanges()

        Me.BindingContext(DsTheriaque_SecuritePreclinique, FPRCLPR_FPRCL_PROD).CancelCurrentEdit()
        Me.DsTheriaque_SecuritePreclinique.FPRCLPR_FPRCL_PROD.RejectChanges()

        Me.BindingContext(DsTheriaque_SecuritePreclinique, FPRCLSP_SECPRECLIN_SPEC).CancelCurrentEdit()
        Me.DsTheriaque_SecuritePreclinique.FPRCLSP_SECPRECLIN_SPEC.RejectChanges()

        Me.BindingContext(DsTheriaque_SecuritePreclinique, FPRCLAFS_FPRCL_AFSSAPS).CancelCurrentEdit()
        Me.DsTheriaque_SecuritePreclinique.FPRCLAFS_FPRCL_AFSSAPS.RejectChanges()

        Me.BindingContext(Me.MasterDataSet, MasterTable).CancelCurrentEdit()
        Me.DsTheriaque_SecuritePreclinique.FPRCL_SECPRECLIN.RejectChanges()

        If bModeDuplication Then EmptyDataTable()
        bModeDuplication = False
        OnLoading = False
    End Sub
    Private Sub EmptyDataTable()
        Me.DsTheriaque_SecuritePreclinique.FPRCL_SECPRECLIN.Clear()
        'Onglet Entités
        Me.DsTheriaque_SecuritePreclinique.FPRCLCPH_FPRCL_CLPH.Clear()
        Me.DsTheriaque_SecuritePreclinique.FPRCLCCH_FPRCL_CLCH.Clear()
        Me.DsTheriaque_SecuritePreclinique.FPRCLSAC_FPRCL_SUBACT.Clear()
        Me.DsTheriaque_SecuritePreclinique.FPRCLSAU_FPRCL_SUBAUX.Clear()
        Me.DsTheriaque_SecuritePreclinique.FPRCLPR_FPRCL_PROD.Clear()
        Me.DsTheriaque_SecuritePreclinique.FPRCLSP_SECPRECLIN_SPEC.Clear()
        Me.DsTheriaque_SecuritePreclinique.FPRCLAFS_FPRCL_AFSSAPS.Clear()
    End Sub

    ''' <summary>
    ''' Proçédure: Duplication des données à partir d'une autre fiche
    ''' </summary>
    ''' <remarks>Proçédure surchargée</remarks>
    Public Overrides Sub Dupliquer()

        If Not Tab_TA1 And CodE <> InvalideControl And CodE <> Nothing Then LoadTab_1()

        'Sauvegarde des données à duplquer

        'Onglet entités
        Dim dt11 As New DataTable
        dt11 = DsTheriaque_SecuritePreclinique.FPRCLCPH_FPRCL_CLPH.Copy

        Dim dt12 As New DataTable
        dt12 = DsTheriaque_SecuritePreclinique.FPRCLCCH_FPRCL_CLCH.Copy

        Dim dt13 As New DataTable
        dt13 = DsTheriaque_SecuritePreclinique.FPRCLSAC_FPRCL_SUBACT.Copy

        Dim dt14 As New DataTable
        dt14 = DsTheriaque_SecuritePreclinique.FPRCLSAU_FPRCL_SUBAUX.Copy

        Dim dt15 As New DataTable
        dt15 = DsTheriaque_SecuritePreclinique.FPRCLPR_FPRCL_PROD.Copy

        Dim dt16 As New DataTable
        dt16 = DsTheriaque_SecuritePreclinique.FPRCLSP_SECPRECLIN_SPEC.Copy

        Dim dt17 As New DataTable
        dt17 = DsTheriaque_SecuritePreclinique.FPRCLAFS_FPRCL_AFSSAPS.Copy

        Dim sText As String = MemoEdit3.Text

        'Vider les contrôles
        EmptyDataTable()

        'Construction de la nouvelle fiche avec les données de la fiche de base
        Me.BindingContext(Me.MasterDataSet, MasterTable).AddNew()
        SetCode_MAx(MasterTable, txtCode)
        CodE = InvalideControl


        Dim drTemp As DataRow
        For iCount As Integer = 0 To dt11.Rows.Count - 1
            drTemp = DsTheriaque_SecuritePreclinique.Tables("FPRCLCPH_FPRCL_CLPH").NewRow()
            drTemp.ItemArray = dt11.Rows(iCount).ItemArray
            DsTheriaque_SecuritePreclinique.Tables("FPRCLCPH_FPRCL_CLPH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt12.Rows.Count - 1
            drTemp = DsTheriaque_SecuritePreclinique.Tables("FPRCLCCH_FPRCL_CLCH").NewRow()
            drTemp.ItemArray = dt12.Rows(iCount).ItemArray
            DsTheriaque_SecuritePreclinique.Tables("FPRCLCCH_FPRCL_CLCH").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt13.Rows.Count - 1
            drTemp = DsTheriaque_SecuritePreclinique.Tables("FPRCLSAC_FPRCL_SUBACT").NewRow()
            drTemp.ItemArray = dt13.Rows(iCount).ItemArray
            DsTheriaque_SecuritePreclinique.Tables("FPRCLSAC_FPRCL_SUBACT").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt14.Rows.Count - 1
            drTemp = DsTheriaque_SecuritePreclinique.Tables("FPRCLSAU_FPRCL_SUBAUX").NewRow()
            drTemp.ItemArray = dt14.Rows(iCount).ItemArray
            DsTheriaque_SecuritePreclinique.Tables("FPRCLSAU_FPRCL_SUBAUX").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt15.Rows.Count - 1
            drTemp = DsTheriaque_SecuritePreclinique.Tables("FPRCLPR_FPRCL_PROD").NewRow()
            drTemp.ItemArray = dt15.Rows(iCount).ItemArray
            DsTheriaque_SecuritePreclinique.Tables("FPRCLPR_FPRCL_PROD").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt16.Rows.Count - 1
            drTemp = DsTheriaque_SecuritePreclinique.Tables("FPRCLSP_SECPRECLIN_SPEC").NewRow()
            drTemp.ItemArray = dt16.Rows(iCount).ItemArray
            DsTheriaque_SecuritePreclinique.Tables("FPRCLSP_SECPRECLIN_SPEC").Rows.Add(drTemp)
        Next

        For iCount As Integer = 0 To dt17.Rows.Count - 1
            drTemp = DsTheriaque_SecuritePreclinique.Tables("FPRCLAFS_FPRCL_AFSSAPS").NewRow()
            drTemp.ItemArray = dt17.Rows(iCount).ItemArray
            DsTheriaque_SecuritePreclinique.Tables("FPRCLAFS_FPRCL_AFSSAPS").Rows.Add(drTemp)
        Next

        MemoEdit3.Text = sText

        ModifierCode()
        bModeDuplication = True
        MyBase.Dupliquer()
        XtraTabControl1.SelectedTabPageIndex = 0
    End Sub

    ''' <summary>
    ''' Proçédure: Modifier code Master de la fiche
    ''' </summary>
    Private Sub ModifierCode()
        'GV11
        For iCount As Integer = 0 To GV11.RowCount - 1
            GV11.SetRowCellValue(iCount, colFPRCLCPH_FPRCL_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV12
        For iCount As Integer = 0 To GV12.RowCount - 1
            GV12.SetRowCellValue(iCount, colFPRCLCCH_FPRCL_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV13
        For iCount As Integer = 0 To GV13.RowCount - 1
            GV13.SetRowCellValue(iCount, colFPRCLSAC_FPRCL_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV14
        For iCount As Integer = 0 To GV14.RowCount - 1
            GV14.SetRowCellValue(iCount, colFPRCLSAU_FPRCL_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV15
        For iCount As Integer = 0 To GV15.RowCount - 1
            GV15.SetRowCellValue(iCount, colFPRCLPR_FPRCL_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV16
        For iCount As Integer = 0 To GV16.RowCount - 1
            GV16.SetRowCellValue(iCount, colFPRCLSP_FPRCL_CODE_FK_PK, Me.txtCode.Text)
        Next
        'GV23
        For iCount As Integer = 0 To GV23.RowCount - 1
            GV23.SetRowCellValue(iCount, colFPRCLAFS_FPRCL_CODE_FK_PK, Me.txtCode.Text)
        Next
    End Sub

    Protected Friend Overrides Function ValideControl(Optional ByRef Ctrl As Control = Nothing, Optional ByVal AllCtrl As Boolean = True) As Boolean
        Dim strSSQL As String = ""
        MyBase.ValideControl(Ctrl)
        For iCount As Integer = 0 To GV23.RowCount - 1
            If Not FieldExistRO(GV16, colFPRCLSP_SP_CODE_FK_PK, GV23.GetRowCellValue(iCount, colFPRCLAFS_SP_CODE_FK_PK)) Then
                GV23.FocusedRowHandle = iCount
                GV23.SetColumnError(colFPRCLAFS_SP_CODE_FK_PK, "La spécialité doit être présente dans la fiche.")
                XtraTabControl1.SelectedTabPageIndex = 1
                Exit Function
            Else
                GV23.SetColumnError(colFPRCLAFS_SP_CODE_FK_PK, "")
            End If
        Next

        Return True
    End Function

#End Region

#Region " Init Data  "

    Private Sub InitDataSource()
        'Onglet Entités
        GC11.DataSource = DsTheriaque_SecuritePreclinique
        GC11.DataMember = FPRCLCPH_FPRCL_CLPH

        GC12.DataSource = DsTheriaque_SecuritePreclinique
        GC12.DataMember = FPRCLCCH_FPRCL_CLCH

        GC13.DataSource = DsTheriaque_SecuritePreclinique
        GC13.DataMember = FPRCLSAC_FPRCL_SUBACT

        GC14.DataSource = DsTheriaque_SecuritePreclinique
        GC14.DataMember = FPRCLSAU_FPRCL_SUBAUX

        GC15.DataSource = DsTheriaque_SecuritePreclinique
        GC15.DataMember = FPRCLPR_FPRCL_PROD

        GC16.DataSource = DsTheriaque_SecuritePreclinique
        GC16.DataMember = FPRCLSP_SECPRECLIN_SPEC

        GC23.DataSource = DsTheriaque_SecuritePreclinique
        GC23.DataMember = FPRCLAFS_FPRCL_AFSSAPS

    End Sub

    Public Overrides Sub InitData()
        MyBase.InitData()
        OnLoading = True
        Declinaison_Global = True
        MasterDataSet = Me.DsTheriaque_SecuritePreclinique
        MasterTable = FPRCL_SECPRECLIN
        CodE = InvalideControl

        'Déclinaison classe CPH
        Dim List1 As New System.Collections.Generic.List(Of StructGVTable)
        List1.Add(New StructGVTable("GC11", eDeclinaison.CPH, colFPRCLCPH_CPH_CODE_FK_PK))
        List1.Add(New StructGVTable("GC12", eDeclinaison.CCH, colFPRCLCCH_CCH_CODE_FK_PK))
        List1.Add(New StructGVTable("GC13", eDeclinaison.SAC, colFPRCLSAC_SAC_CODE_FK_PK))
        List1.Add(New StructGVTable("GC16", eDeclinaison.SP, colFPRCLSP_SP_CODE_FK_PK))
        Dim DecCPH As New ClsDeclinaison(eDeclinaison.CPH, List1)
        InitLkup(Me.rp_FPRCLCPH, FPRCLCPH_FPRCL_CLPH, strSSQL_CPH_CLASSEPHARMTHER_NIVEAU, True, , , , , , DecCPH)

        'Déclinaison classe CCH
        Dim List2 As New System.Collections.Generic.List(Of StructGVTable)
        List2.Add(New StructGVTable("GC11", eDeclinaison.CPH, colFPRCLCPH_CPH_CODE_FK_PK))
        List2.Add(New StructGVTable("GC12", eDeclinaison.CCH, colFPRCLCCH_CCH_CODE_FK_PK))
        List2.Add(New StructGVTable("GC13", eDeclinaison.SAC, colFPRCLSAC_SAC_CODE_FK_PK))
        List2.Add(New StructGVTable("GC16", eDeclinaison.SP, colFPRCLSP_SP_CODE_FK_PK))
        List2.Add(New StructGVTable("GC14", eDeclinaison.SAU, colFPRCLSAU_SAU_CODE_FK_PK))
        Dim DecCCH As New ClsDeclinaison(eDeclinaison.CCH, List2)
        InitLkup(Me.rp_FPRCLCCH, FPRCLCCH_FPRCL_CLCH, strSSQL_CCH_CLASSECHIMIQUE_NIVEAU, True, , , , , , DecCCH)

        'Déclinaison SUBAC
        Dim List3 As New System.Collections.Generic.List(Of StructGVTable)
        List3.Add(New StructGVTable("GC13", eDeclinaison.SAC, colFPRCLSAC_SAC_CODE_FK_PK))
        List3.Add(New StructGVTable("GC16", eDeclinaison.SP, colFPRCLSP_SP_CODE_FK_PK))
        Dim DecSUBAC As New ClsDeclinaison(eDeclinaison.SAC, List3)
        InitLkup(Me.rp_FPRCLSAC, FPRCLSAC_FPRCL_SUBACT, strSSQL_SAC_SUBACTIVE, True, , , , , , DecSUBAC)

        'Déclinaison SAU
        Dim List4 As New System.Collections.Generic.List(Of StructGVTable)
        List4.Add(New StructGVTable("GC14", eDeclinaison.SAU, colFPRCLSAU_SAU_CODE_FK_PK))
        List4.Add(New StructGVTable("GC16", eDeclinaison.SP, colFPRCLSP_SP_CODE_FK_PK))
        Dim DecSAU As New ClsDeclinaison(eDeclinaison.SAU, List4)
        InitLkup(Me.rp_FPRCLSAU, FPRCLSAU_FPRCL_SUBAUX, strSSQL_SAU_SUBAUXILIAIRE, True, , , , , , DecSAU)

        'Déclinaison PRODUIT
        Dim List5 As New System.Collections.Generic.List(Of StructGVTable)
        List5.Add(New StructGVTable("GC15", eDeclinaison.PR, colFPRCLPR_PR_CODE_FK_PK))
        List5.Add(New StructGVTable("GC16", eDeclinaison.SP, colFPRCLSP_SP_CODE_FK_PK))
        Dim DecPR As New ClsDeclinaison(eDeclinaison.PR, List5)
        InitLkup(Me.rp_FPRCLPR, FPRCLPR_FPRCL_PROD, strSSQL_PR_PRODUIT, True, , , , , , DecPR)

        InitLkup(Me.rp_FPRCLSP, FPRCLSP_SECPRECLIN_SPEC, strSSQL_SP_SPECIALITE, True)

        InitDataSource()
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
    Private Sub Open_Fiche(ByVal CodE1 As Integer)
        OnLoading = True
        CodE = _Code
        EmptyDataTable()
        Me.FprcL_TA.FillByCode(Me.DsTheriaque_SecuritePreclinique.FPRCL_SECPRECLIN, CodE1)

        'Onglet Entités
        Me.FprclcpH_TA.FillByCode(Me.DsTheriaque_SecuritePreclinique.FPRCLCPH_FPRCL_CLPH, CodE1)
        Me.FprclccH_TA.FillByCode(Me.DsTheriaque_SecuritePreclinique.FPRCLCCH_FPRCL_CLCH, CodE1)
        Me.FprclsaC_TA.FillByCode(Me.DsTheriaque_SecuritePreclinique.FPRCLSAC_FPRCL_SUBACT, CodE1)
        Me.FprclsaU_TA.FillByCode(Me.DsTheriaque_SecuritePreclinique.FPRCLSAU_FPRCL_SUBAUX, CodE1)
        Me.FprclpR_TA.FillByCode(Me.DsTheriaque_SecuritePreclinique.FPRCLPR_FPRCL_PROD, CodE1)
        Me.FprclsP_TA.FillByCode(Me.DsTheriaque_SecuritePreclinique.FPRCLSP_SECPRECLIN_SPEC, CodE1)
        Tab_TA1 = False
        OnLoading = False
    End Sub

#End Region

#Region " Chargement par onglet "
    Private Sub LoadTab_1()
        Load_On(Me)
        OnLoading = True
        If CodE <> InvalideControl And CodE <> Nothing Then
            Dim strSSQL_SP_REF As String
            strSSQL_SP_REF = " SELECT SP_CODE_SQ_PK as code, SP_NOM as libelle FROM THERIAQUE.FPRCLSP_SECPRECLIN_SPEC, THERIAQUE.SP_SPECIALITE"
            strSSQL_SP_REF &= " WHERE FPRCLSP_FPRCL_CODE_FK_PK = " & CodE
            strSSQL_SP_REF &= " AND SP_CODE_SQ_PK = FPRCLSP_SP_CODE_FK_PK"
            InitLkup(Me.rp_FPRCL_SP, FPRCL_SECPRECLIN, strSSQL_SP_REF, True)
            For iCount As Integer = 0 To GV23.RowCount
                If GV23.GetRowCellDisplayText(iCount, "FPRCLAFS_SP_CODE_FK_PK") = "" And GV23.GetRowCellDisplayText(iCount, "FPRCLAFS_FPRCL_CODE_FK_PK") <> "" Then
                    GV23.DeleteRow(iCount)
                    iCount = iCount - 1
                End If
            Next
        End If
        If Not Tab_lkup1 Then
            InitLkup(Me.rp_FPRCLAFS, FPRCLAFS_FPRCL_AFSSAPS, strSSQL_CDF_CODIF("25"), True)
            Tab_lkup1 = True
        End If

        If Not Tab_TA1 And CodE <> InvalideControl And CodE <> Nothing Then
            'Onglet Réf.officielles
            Me.FprcL_TA.FillByCode(Me.DsTheriaque_SecuritePreclinique.FPRCL_SECPRECLIN, CodE)
            Me.FprclafS_TA.FillByCode(Me.DsTheriaque_SecuritePreclinique.FPRCLAFS_FPRCL_AFSSAPS, CodE)
            Tab_TA1 = True
        End If
        OnLoading = False
        Load_Off(Me)
    End Sub
#End Region

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPageIndex = 1 Then
            LoadTab_1()
            Exit Sub
        End If
    End Sub

#Region " NewRow "

    Private Sub GV11_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV11.InitNewRow
        If OnLoading Then Exit Sub
        GV11.SetFocusedRowCellValue(colFPRCLCPH_FPRCL_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV12_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV12.InitNewRow
        If OnLoading Then Exit Sub
        GV12.SetFocusedRowCellValue(colFPRCLCCH_FPRCL_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV13_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV13.InitNewRow
        If OnLoading Then Exit Sub
        GV13.SetFocusedRowCellValue(colFPRCLSAC_FPRCL_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV14_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV14.InitNewRow
        If OnLoading Then Exit Sub
        GV14.SetFocusedRowCellValue(colFPRCLSAU_FPRCL_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV15_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV15.InitNewRow
        If OnLoading Then Exit Sub
        GV15.SetFocusedRowCellValue(colFPRCLPR_FPRCL_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV16_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV16.InitNewRow
        If OnLoading Then Exit Sub
        GV16.SetFocusedRowCellValue(colFPRCLSP_FPRCL_CODE_FK_PK, txtCode.Text)
    End Sub

    Private Sub GV23_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV23.InitNewRow
        If OnLoading Then Exit Sub
        GV23.SetFocusedRowCellValue(colFPRCLAFS_FPRCL_CODE_FK_PK, txtCode.Text)
    End Sub

#End Region

#Region " Panel Resize  "

    Private Sub Panel5_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel5.Resize
        GC11.Width = Panel5.Width / 2
        GC12.Width = Panel5.Width / 2
    End Sub

    Private Sub Panel2_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel2.Resize
        GC13.Width = Panel2.Width / 2
        GC14.Width = Panel2.Width / 2
    End Sub

    Private Sub Panel3_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.Resize
        GC15.Width = Panel3.Width / 2
        GC16.Width = Panel3.Width / 2
    End Sub

    Private Sub XtraTabControl1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraTabControl1.Resize
        Panel2.Height = XtraTabControl1.Height / 3
        Panel3.Height = XtraTabControl1.Height / 3
        Panel5.Height = XtraTabControl1.Height / 3
    End Sub

#End Region

End Class
