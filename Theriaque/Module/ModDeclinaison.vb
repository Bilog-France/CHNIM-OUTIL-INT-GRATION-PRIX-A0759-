Public Module ModDeclinaison

#Region " Declinaison "

#Region " SAC "

    Public Sub DeclinaisonSAC_Globale(ByRef FrmFormulaire As Frm_Formulaire, ByVal txtTag As StructTxtProperty)
        Dim ColSac As New Collection
        Dim ColVoie As New Collection
        Dim ColEP As New Collection
        Dim StrSSQLEP As String = strSSQL_SP_SPECIALITE_Distinct
        Dim StrVoie As String = strSSQL_CDF_CODIF_Distinct("18")
        Dim gvSAC As DevExpress.XtraGrid.Views.Grid.GridView
        Dim gvEP As DevExpress.XtraGrid.Views.Grid.GridView
        Dim gvTemp As DevExpress.XtraGrid.Views.Grid.GridView

        ''---------------------------------------
        '' Affichage des substances actives
        ''---------------------------------------
        Dim f As New Frm_Dictionnaire_Declinaison
        f._SSQL = strSSQL_SAC_SUBACTIVE
        f._strTable = "SAC_SUBACTIVE"
        f._Libelle = "Substances actives"
        Dim CollectionContent As New System.Collections.Generic.List(Of StructGVTable)
        CollectionContent = txtTag.Declinaison.ContentIn
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.SAC Then
                gvSAC = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                f._CollectionIn = GetCodeFromGV(gvSAC, CollectionContent(Inti).Column)
                Exit For
            End If
        Next
        f.ShowDialog()
        If f._Ok = False Then
            Exit Sub
        End If
        ColSac = f._CollectionOut
        f.Dispose()
        ''---------------------------------------
        '' Affichage des Voies
        ''---------------------------------------
        Dim f2 As New Frm_Dictionnaire_Declinaison

        StrVoie = " Select Distinct CDF_CODE_PK as code, CDF_NOM as libelle, CDF_NUMERO_PK as num ,0 as chk From THERIAQUE.CDF_CODIF "
        StrVoie &= " ,THERIAQUE.SPVO_SPECIALITE_VOIE"
        StrVoie &= " where SPVO_CDF_VO_CODE_FK_PK = CDF_CODE_PK"
        StrVoie &= " and CDF_NUMERO_PK = '18'"
        If ColSac.Count > 0 Then
            StrVoie &= " and SPVO_SP_CODE_FK_PK in "
            StrVoie &= " ("
            StrVoie &= " Select Distinct SP_CODE_SQ_PK as code From THERIAQUE.SP_SPECIALITE"
            StrVoie &= " ,THERIAQUE.COSAC_COMPO_SUBACT "
            StrVoie &= " where COSAC_SP_CODE_FK_PK = SP_CODE_SQ_PK "
            StrVoie &= " and COSAC_SAC_CODE_FK_PK in " & GetCodeFromCollection(ColSac)
            StrVoie &= " )"
        End If
        f2._SSQL = StrVoie
        f2._strTable = "CDF_CODIF"
        f2._Libelle = " Voie "
        f2.ShowDialog()
        If f2._Ok = False Then
            Exit Sub
        End If
        ColVoie = f2._CollectionOut
        f2.Dispose()

        ''---------------------------------------
        '' Affichage des Episodes
        ''---------------------------------------
        Dim f3 As New Frm_Dictionnaire_Declinaison
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.SP Then
                gvEP = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                f3._CollectionIn = GetCodeFromGV(gvEP, CollectionContent(Inti).Column)
                Exit For
            End If
        Next
        If ColSac.Count > 0 Then
            If ColVoie.Count > 0 Then
                StrSSQLEP &= " ,THERIAQUE.COSAC_COMPO_SUBACT, THERIAQUE.SPVO_SPECIALITE_VOIE "
                StrSSQLEP &= " where COSAC_SP_CODE_FK_PK = SP_CODE_SQ_PK "
                StrSSQLEP &= " and SPVO_SP_CODE_FK_PK = SP_CODE_SQ_PK "
                StrSSQLEP &= " and COSAC_SAC_CODE_FK_PK in " & GetCodeFromCollection(ColSac)
                StrSSQLEP &= " and SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
                If f3._CollectionIn.Count > 0 Then
                    StrSSQLEP &= " Union Select Distinct SP_CODE_SQ_PK as code, SP_NOM as libelle ,0 as chk ,0 as chkFixe From THERIAQUE.SP_SPECIALITE "
                    StrSSQLEP &= " where  SP_CODE_SQ_PK in " & GetCodeFromCollection(f3._CollectionIn)
                End If
            Else
                StrSSQLEP &= " ,THERIAQUE.COSAC_COMPO_SUBACT "
                StrSSQLEP &= " where COSAC_SP_CODE_FK_PK = SP_CODE_SQ_PK "
                StrSSQLEP &= " and COSAC_SAC_CODE_FK_PK in " & GetCodeFromCollection(ColSac)
                If f3._CollectionIn.Count > 0 Then
                    StrSSQLEP &= " Union Select Distinct SP_CODE_SQ_PK as code, SP_NOM as libelle ,0 as chk,0 as chkFixe From THERIAQUE.SP_SPECIALITE "
                    StrSSQLEP &= " where  SP_CODE_SQ_PK in " & GetCodeFromCollection(f3._CollectionIn)
                End If
            End If
        Else
            If ColVoie.Count > 0 Then
                StrSSQLEP &= ", THERIAQUE.SPVO_SPECIALITE_VOIE "
                StrSSQLEP &= " where SPVO_SP_CODE_FK_PK = SP_CODE_SQ_PK"
                If f3._CollectionIn.Count > 0 Then
                    StrSSQLEP &= " and (SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
                    StrSSQLEP &= " or SP_CODE_SQ_PK in " & GetCodeFromCollection(f3._CollectionIn) & ")"
                Else
                    StrSSQLEP &= " and SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
                End If
            End If
        End If
        f3._SSQL = StrSSQLEP
        f3._strTable = "SP_SPECIALITE"
        f3._Libelle = " Spécialité"
        f3.ShowDialog()
        If f3._Ok = False Then
            Exit Sub
        End If
        ColEP = f3._CollectionOut
        f3.Dispose()
        '----------------------------------------------------
        '----------------------------------------------------
        Load_On(Frm_Formulaire)
        For inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(inti).Table = eDeclinaison.SAC Then
                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

                For intJ As Integer = 0 To gvTemp.RowCount - 1   ' Vider la grille
                    gvTemp.DeleteRow(0)
                Next

                For intk As Integer = 1 To ColSac.Count
                    gvTemp.AddNewRow()
                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColSac(intk))
                Next
            End If
            If CollectionContent(inti).Table = eDeclinaison.SP Then
                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

                For intJ As Integer = 0 To gvTemp.RowCount - 1   ' Vider la grille
                    gvTemp.DeleteRow(0)
                Next

                For intk As Integer = 1 To ColEP.Count
                    gvTemp.AddNewRow()
                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColEP(intk))
                Next
            End If
        Next
        Load_Off(Frm_Formulaire)
        '----------------------------------------------------
        '----------------------------------------------------
    End Sub

    Public Sub DeclinaisonSAC_Classique(ByRef FrmFormulaire As Frm_Formulaire, ByVal txtTag As StructTxtProperty)
        Dim ColSacADD As New Collection
        Dim ColSacDelete As New Collection
        Dim ColSac As New Collection

        Dim ColVoie As New Collection

        Dim ColEP As New Collection
        Dim ColEPDelete As New Collection
        Dim ColEPADD As New Collection

        Dim StrSSQLEP As String = strSSQL_SP_SPECIALITE_Distinct
        Dim StrVoie As String = strSSQL_CDF_CODIF_Distinct("18")
        Dim gvSAC As DevExpress.XtraGrid.Views.Grid.GridView
        Dim gvEP As DevExpress.XtraGrid.Views.Grid.GridView
        Dim gvTemp As DevExpress.XtraGrid.Views.Grid.GridView

        ''---------------------------------------
        '' Affichage des substances actives
        ''---------------------------------------
        Dim f As New Frm_Dictionnaire_Declinaison
        f._strTable = "SAC_SUBACTIVE"
        f._Libelle = "Substances actives"
        f._SSQL = strSSQL_SAC_SUBACTIVE

        Dim CollectionContent As New System.Collections.Generic.List(Of StructGVTable)
        CollectionContent = txtTag.Declinaison.ContentIn
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.SAC Then
                gvSAC = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                If gvSAC.GetFocusedRowCellValue(CollectionContent(Inti).Column) IsNot Nothing Then
                    Dim colTemp As New Collection
                    colTemp.Add(cn.SQLText(gvSAC.GetFocusedRowCellValue(CollectionContent(Inti).Column)))
                    f._CollectionIn = colTemp
                    f.txtSearch.Text = ClsSAC.GetLibelle(gvSAC.GetFocusedRowCellValue(CollectionContent(Inti).Column))
                End If
                Exit For
            End If
        Next
        f.ShowDialog()
        If f._Ok = False Then
            Exit Sub
        End If
        ColSac = f._CollectionOut
        ColSacDelete = f._CollectionOutDelete
        ColSacADD = f._CollectionOutADD
        f.Dispose()
        ''---------------------------------------
        '' Affichage des Voies
        ''---------------------------------------
        Dim f2 As New Frm_Dictionnaire_Declinaison

        StrVoie = " Select Distinct CDF_CODE_PK as code, CDF_NOM as libelle, CDF_NUMERO_PK as num ,0 as chk From THERIAQUE.CDF_CODIF "
        StrVoie &= " ,THERIAQUE.SPVO_SPECIALITE_VOIE"
        StrVoie &= " where SPVO_CDF_VO_CODE_FK_PK = CDF_CODE_PK"
        StrVoie &= " and CDF_NUMERO_PK = '18'"
        If ColSac.Count > 0 Then
            StrVoie &= " and SPVO_SP_CODE_FK_PK in "
            StrVoie &= " ("
            StrVoie &= " Select Distinct SP_CODE_SQ_PK as code From THERIAQUE.SP_SPECIALITE"
            StrVoie &= " ,THERIAQUE.COSAC_COMPO_SUBACT "
            StrVoie &= " where COSAC_SP_CODE_FK_PK = SP_CODE_SQ_PK "
            StrVoie &= " and COSAC_SAC_CODE_FK_PK in " & GetCodeFromCollection(ColSac)
            StrVoie &= " )"
        End If
        f2._SSQL = StrVoie
        f2._strTable = "CDF_CODIF"
        f2._Libelle = " Voie "
        f2.ShowDialog()
        If f2._Ok = False Then
            Exit Sub
        End If
        ColVoie = f2._CollectionOut
        f2.Dispose()

        ''---------------------------------------
        '' Affichage des Episodes
        ''---------------------------------------
        Dim f3 As New Frm_Dictionnaire_Declinaison
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.SP Then
                gvEP = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                f3._CollectionIn = GetCodeFromGV(gvEP, CollectionContent(Inti).Column)
                Exit For
            End If
        Next
        If ColSac.Count > 0 Then
            If ColVoie.Count > 0 Then
                StrSSQLEP &= " ,THERIAQUE.COSAC_COMPO_SUBACT, THERIAQUE.SPVO_SPECIALITE_VOIE "
                StrSSQLEP &= " where COSAC_SP_CODE_FK_PK = SP_CODE_SQ_PK "
                StrSSQLEP &= " and SPVO_SP_CODE_FK_PK = SP_CODE_SQ_PK "
                StrSSQLEP &= " and COSAC_SAC_CODE_FK_PK in " & GetCodeFromCollection(ColSac)
                StrSSQLEP &= " and SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
                'If f3._CollectionIn.Count > 0 Then
                '    StrSSQLEP &= " Union Select Distinct SP_CODE_SQ_PK as code, SP_NOM as libelle ,0 as chk ,0 as chkFixe From THERIAQUE.SP_SPECIALITE "
                '    StrSSQLEP &= " where  SP_CODE_SQ_PK in " & GetCodeFromCollection(f3._CollectionIn)
                'End If
            Else
                StrSSQLEP &= " ,THERIAQUE.COSAC_COMPO_SUBACT "
                StrSSQLEP &= " where COSAC_SP_CODE_FK_PK = SP_CODE_SQ_PK "
                StrSSQLEP &= " and COSAC_SAC_CODE_FK_PK in " & GetCodeFromCollection(ColSac)
                'If f3._CollectionIn.Count > 0 Then
                '    StrSSQLEP &= " Union Select Distinct SP_CODE_SQ_PK as code, SP_NOM as libelle ,0 as chk,0 as chkFixe From THERIAQUE.SP_SPECIALITE "
                '    StrSSQLEP &= " where  SP_CODE_SQ_PK in " & GetCodeFromCollection(f3._CollectionIn)
                'End If
            End If
        Else
            If ColVoie.Count > 0 Then
                StrSSQLEP &= ", THERIAQUE.SPVO_SPECIALITE_VOIE "
                StrSSQLEP &= " where SPVO_SP_CODE_FK_PK = SP_CODE_SQ_PK"
                'If f3._CollectionIn.Count > 0 Then
                '    StrSSQLEP &= " and (SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
                '    StrSSQLEP &= " or SP_CODE_SQ_PK in " & GetCodeFromCollection(f3._CollectionIn) & ")"
                'Else
                StrSSQLEP &= " and SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
                'End If
            End If
        End If
        f3._SSQL = StrSSQLEP
        f3._strTable = "SP_SPECIALITE"
        f3._Libelle = " Spécialité"
        f3.ShowDialog()
        If f3._Ok = False Then
            Exit Sub
        End If
        Load_On(Frm_Formulaire)
        ColEP = f3._CollectionOut
        ColEPDelete = f3._CollectionOutDelete
        ColEPADD = f3._CollectionOutADD
        f3.Dispose()
        '----------------------------------------------------
        '----------------------------------------------------
        For inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(inti).Table = eDeclinaison.SAC Then
                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

                For intk As Integer = 1 To ColSacADD.Count
                    gvTemp.AddNewRow()
                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColSacADD(intk))
                Next
                For intk As Integer = 1 To ColSacDelete.Count
                    For intJ As Integer = 0 To gvTemp.RowCount - 1
                        If gvTemp.GetRowCellValue(intJ, CollectionContent(inti).Column) = ColSacDelete(intk) Then
                            gvTemp.DeleteRow(intJ)
                            Exit For
                        End If
                    Next
                Next
            End If
            If CollectionContent(inti).Table = eDeclinaison.SP Then
                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

                For intk As Integer = 1 To ColEPADD.Count
                    gvTemp.AddNewRow()
                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColEPADD(intk))
                Next
                For intk As Integer = 1 To ColEPDelete.Count
                    For intJ As Integer = 0 To gvTemp.RowCount - 1
                        If gvTemp.GetRowCellValue(intJ, CollectionContent(inti).Column) = ColEPDelete(intk) Then
                            gvTemp.DeleteRow(intJ)
                            Exit For
                        End If
                    Next
                Next
            End If
        Next
        Load_Off(Frm_Formulaire)
        '----------------------------------------------------
        '----------------------------------------------------
    End Sub


    Public Sub DeclinaisonATC_Classique(ByRef FrmFormulaire As Frm_Formulaire, ByVal txtTag As StructTxtProperty)

        Dim ColATCADD As New Collection
        Dim ColATCDelete As New Collection
        Dim ColATC As New Collection

        Dim ColVoie As New Collection

        Dim ColEP As New Collection
        Dim ColEPDelete As New Collection
        Dim ColEPADD As New Collection

        Dim StrSSQLEP As String = strSSQL_SP_SPECIALITE_Distinct
        Dim StrVoie As String = strSSQL_CDF_CODIF_Distinct("18")
        Dim gvATC As DevExpress.XtraGrid.Views.Grid.GridView
        Dim gvEP As DevExpress.XtraGrid.Views.Grid.GridView
        Dim gvTemp As DevExpress.XtraGrid.Views.Grid.GridView

        Dim CollectionContent As New System.Collections.Generic.List(Of StructGVTable)
        CollectionContent = txtTag.Declinaison.ContentIn

        ''---------------------------------------
        '' Affichage des Classe ATC
        ''---------------------------------------
        Dim f7 As New Frm_Dictionnaire_Declinaison
        f7._strTable = "CATC_CLASSEATC"
        f7._Libelle = "Classe ATC"
        Dim strSSQL_CCH_CLASSEATC As String = ""
        strSSQL_CCH_CLASSEATC &= " Select CATC_CODE_PK as code, CATC_NOMF as libelle,0 as disable ,0 as chk ,0 as chkFixe From THERIAQUE.CATC_CLASSEATC"
        strSSQL_CCH_CLASSEATC &= " where CATC_CODE_PK  not in (select distinct isnull(CATC_CATC_CODE_FK,'') from THERIAQUE.CATC_CLASSEATC) "
        strSSQL_CCH_CLASSEATC &= " union "
        strSSQL_CCH_CLASSEATC &= " Select CATC_CODE_PK as code, CATC_NOMF as libelle, 0 as disable,0 as chk ,0 as chkFixe From THERIAQUE.CATC_CLASSEATC"
        strSSQL_CCH_CLASSEATC &= " where CATC_CODE_PK in (select distinct isnull(CATC_CATC_CODE_FK,'') from THERIAQUE.CATC_CLASSEATC) "
        strSSQL_CCH_CLASSEATC &= " order by CATC_CODE_PK "
        f7._SSQL = strSSQL_CCH_CLASSEATC
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.ATC Then
                gvATC = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                f7._CollectionIn = GetCodeStringFromGV(gvATC, CollectionContent(Inti).Column)
                Exit For
            End If
        Next
        'If gvCCH IsNot Nothing Then
        f7.ShowDialog()
        If f7._Ok = False Then
            Exit Sub
        End If
        ColATC = f7._CollectionOut
        ColATCDelete = f7._CollectionOutDelete
        ColATCADD = f7._CollectionOutADD
        f7.Dispose()

        
        ''---------------------------------------
        '' Affichage des Voies
        ''---------------------------------------
        Dim f2 As New Frm_Dictionnaire_Declinaison

        StrVoie = " Select Distinct CDF_CODE_PK as code, CDF_NOM as libelle, CDF_NUMERO_PK as num ,0 as chk From THERIAQUE.CDF_CODIF "
        StrVoie &= " ,THERIAQUE.SPVO_SPECIALITE_VOIE"
        StrVoie &= " where SPVO_CDF_VO_CODE_FK_PK = CDF_CODE_PK"
        StrVoie &= " and CDF_NUMERO_PK = '18'"
        If ColATC.Count > 0 Then
            StrVoie &= " and SPVO_SP_CODE_FK_PK in "
            StrVoie &= " ("
            StrVoie &= " Select Distinct SP_CODE_SQ_PK as code From THERIAQUE.SP_SPECIALITE"
            StrVoie &= " where SP_CATC_CODE_FK in " & GetCodeATCFromCollection(ColATC)
            StrVoie &= " )"
        End If
        f2._SSQL = StrVoie
        f2._strTable = "CDF_CODIF"
        f2._Libelle = " Voie "
        f2.ShowDialog()
        If f2._Ok = False Then
            Exit Sub
        End If
        ColVoie = f2._CollectionOut
        f2.Dispose()

        ''---------------------------------------
        '' Affichage des Episodes
        ''---------------------------------------
        Dim f3 As New Frm_Dictionnaire_Declinaison
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.SP Then
                gvEP = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                f3._CollectionIn = GetCodeFromGV(gvEP, CollectionContent(Inti).Column)
                Exit For
            End If
        Next
        If ColATC.Count > 0 Then
            If ColVoie.Count > 0 Then
                StrSSQLEP &= " , THERIAQUE.SPVO_SPECIALITE_VOIE "
                StrSSQLEP &= " where SPVO_SP_CODE_FK_PK = SP_CODE_SQ_PK "
                StrSSQLEP &= " and SP_CATC_CODE_FK in " & GetCodeATCFromCollection(ColATC)
                StrSSQLEP &= " and SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
                'If f3._CollectionIn.Count > 0 Then
                '    StrSSQLEP &= " Union Select Distinct SP_CODE_SQ_PK as code, SP_NOM as libelle ,0 as chk ,0 as chkFixe From THERIAQUE.SP_SPECIALITE "
                '    StrSSQLEP &= " where  SP_CODE_SQ_PK in " & GetCodeFromCollection(f3._CollectionIn)
                'End If
            Else
                StrSSQLEP &= " where SP_CATC_CODE_FK in " & GetCodeATCFromCollection(ColATC)
                'If f3._CollectionIn.Count > 0 Then
                '    StrSSQLEP &= " Union Select Distinct SP_CODE_SQ_PK as code, SP_NOM as libelle ,0 as chk,0 as chkFixe From THERIAQUE.SP_SPECIALITE "
                '    StrSSQLEP &= " where  SP_CODE_SQ_PK in " & GetCodeFromCollection(f3._CollectionIn)
                'End If
            End If
        Else
            If ColVoie.Count > 0 Then
                StrSSQLEP &= ", THERIAQUE.SPVO_SPECIALITE_VOIE "
                StrSSQLEP &= " where SPVO_SP_CODE_FK_PK = SP_CODE_SQ_PK"
                'If f3._CollectionIn.Count > 0 Then
                '    StrSSQLEP &= " and (SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
                '    StrSSQLEP &= " or SP_CODE_SQ_PK in " & GetCodeFromCollection(f3._CollectionIn) & ")"
                'Else
                StrSSQLEP &= " and SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
                'End If
            End If
        End If
        f3._SSQL = StrSSQLEP
        f3._strTable = "SP_SPECIALITE"
        f3._Libelle = " Spécialité"
        f3.ShowDialog()
        If f3._Ok = False Then
            Exit Sub
        End If
        Load_On(Frm_Formulaire)
        ColEP = f3._CollectionOut
        ColEPDelete = f3._CollectionOutDelete
        ColEPADD = f3._CollectionOutADD
        f3.Dispose()
        '----------------------------------------------------
        '----------------------------------------------------
        For inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(inti).Table = eDeclinaison.ATC Then
                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

                For intk As Integer = 1 To ColATCADD.Count
                    gvTemp.AddNewRow()
                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColATCADD(intk))
                    gvTemp.SetFocusedRowCellValue(gvTemp.Columns.ColumnByName("colCATC_CODE_PK_D"), ColATCADD(intk))
                Next
                For intk As Integer = 1 To ColATCDelete.Count
                    For intJ As Integer = 0 To gvTemp.RowCount - 1
                        If gvTemp.GetRowCellValue(intJ, CollectionContent(inti).Column) = ColATCDelete(intk) Then
                            gvTemp.DeleteRow(intJ)
                            Exit For
                        End If
                    Next
                Next
            End If
            If CollectionContent(inti).Table = eDeclinaison.SP Then
                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

                For intk As Integer = 1 To ColEPADD.Count
                    gvTemp.AddNewRow()
                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColEPADD(intk))
                Next
                For intk As Integer = 1 To ColEPDelete.Count
                    For intJ As Integer = 0 To gvTemp.RowCount - 1
                        If gvTemp.GetRowCellValue(intJ, CollectionContent(inti).Column) = ColEPDelete(intk) Then
                            gvTemp.DeleteRow(intJ)
                            Exit For
                        End If
                    Next
                Next
            End If
        Next
        Load_Off(Frm_Formulaire)
        '----------------------------------------------------
        '----------------------------------------------------
    End Sub


#End Region

#Region " SAU "

    Public Sub DeclinaisonSAU_Globale(ByRef FrmFormulaire As Frm_Formulaire, ByVal txtTag As StructTxtProperty)
        Dim ColSAU As New Collection
        Dim ColVoie As New Collection
        Dim ColTeneur As New Collection
        Dim ColEP As New Collection
        Dim StrSSQLEP As String = strSSQL_SP_SPECIALITE_Distinct
        Dim StrVoie As String = strSSQL_CDF_CODIF_Distinct("18")
        Dim gvSAU As DevExpress.XtraGrid.Views.Grid.GridView
        Dim gvEP As DevExpress.XtraGrid.Views.Grid.GridView
        Dim gvTemp As DevExpress.XtraGrid.Views.Grid.GridView

        ''---------------------------------------
        '' Affichage des substances actives
        ''---------------------------------------
        Dim f As New Frm_Dictionnaire_Declinaison
        f._SSQL = strSSQL_SAU_SUBAUXILIAIRE
        f._strTable = "SAU_SUBAUXILIAIRE"
        f._Libelle = "Excipient"
        Dim CollectionContent As New System.Collections.Generic.List(Of StructGVTable)
        CollectionContent = txtTag.Declinaison.ContentIn
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.SAU Then
                gvSAU = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                f._CollectionIn = GetCodeFromGV(gvSAU, CollectionContent(Inti).Column)
                Exit For
            End If
        Next
        f.ShowDialog()
        If f._Ok = False Then
            Exit Sub
        End If
        ColSAU = f._CollectionOut
        f.Dispose()
        ''---------------------------------------
        '' Affichage des Voies
        ''---------------------------------------
        Dim f2 As New Frm_Dictionnaire_Declinaison

        StrVoie = " Select Distinct CDF_CODE_PK as code, CDF_NOM as libelle, CDF_NUMERO_PK as num ,0 as chk From THERIAQUE.CDF_CODIF "
        StrVoie &= " ,THERIAQUE.SPVO_SPECIALITE_VOIE"
        StrVoie &= " where SPVO_CDF_VO_CODE_FK_PK = CDF_CODE_PK"
        StrVoie &= " and CDF_NUMERO_PK = '18'"
        If ColSAU.Count > 0 Then
            StrVoie &= " and SPVO_SP_CODE_FK_PK in "
            StrVoie &= " ("
            StrVoie &= " Select Distinct SP_CODE_SQ_PK as code From THERIAQUE.SP_SPECIALITE"
            StrVoie &= " ,THERIAQUE.COSAU_COMPO_SUBAUX "
            StrVoie &= " where COSAU_SP_CODE_FK_PK = SP_CODE_SQ_PK "
            StrVoie &= " and COSAU_SAU_CODE_FK_PK in " & GetCodeFromCollection(ColSAU)
            StrVoie &= " )"
        End If
        f2._SSQL = StrVoie
        f2._strTable = "CDF_CODIF"
        f2._Libelle = " Voie "
        f2.ShowDialog()
        If f2._Ok = False Then
            Exit Sub
        End If
        ColVoie = f2._CollectionOut
        f2.Dispose()
        ''---------------------------------------
        '' Affichage des Teneurs
        ''---------------------------------------
        Dim f4 As New Frm_Dictionnaire_Declinaison

        StrVoie = " Select Distinct CDF_CODE_PK as code, CDF_NOM as libelle, CDF_NUMERO_PK as num ,0 as chk From THERIAQUE.CDF_CODIF "
        StrVoie &= " ,THERIAQUE.COTEN_COMPO_TENEUR"
        StrVoie &= " where COTEN_CDF_TEN_CODE_FK_PK = CDF_CODE_PK"
        StrVoie &= " and CDF_NUMERO_PK = '24'"
        If ColSAU.Count > 0 Then
            StrVoie &= " and COTEN_SP_CODE_FK_PK in "
            StrVoie &= " ("
            StrVoie &= " Select Distinct SP_CODE_SQ_PK as code From THERIAQUE.SP_SPECIALITE"
            StrVoie &= " ,THERIAQUE.COSAU_COMPO_SUBAUX "
            StrVoie &= " where COSAU_SP_CODE_FK_PK = SP_CODE_SQ_PK "
            StrVoie &= " and COSAU_SAU_CODE_FK_PK in " & GetCodeFromCollection(ColSAU)
            StrVoie &= " )"
        End If
        If ColVoie.Count > 0 Then
            StrVoie &= " and COTEN_SP_CODE_FK_PK in "
            StrVoie &= " ("
            StrVoie &= " Select Distinct SP_CODE_SQ_PK as code From THERIAQUE.SP_SPECIALITE"
            StrVoie &= " ,THERIAQUE.SPVO_SPECIALITE_VOIE "
            StrVoie &= " where SPVO_SP_CODE_FK_PK = SP_CODE_SQ_PK "
            StrVoie &= " and SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
            StrVoie &= " )"
        End If
        f4._SSQL = StrVoie
        f4._strTable = "CDF_CODIF"
        f4._Libelle = " Teneur "
        f4.ShowDialog()
        If f4._Ok = False Then
            Exit Sub
        End If
        ColTeneur = f4._CollectionOut
        f4.Dispose()
        ''---------------------------------------
        '' Affichage des Episodes
        ''---------------------------------------
        Dim f3 As New Frm_Dictionnaire_Declinaison
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.SP Then
                gvEP = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                f3._CollectionIn = GetCodeFromGV(gvEP, CollectionContent(Inti).Column)
                Exit For
            End If
        Next
        If ColSAU.Count > 0 Then
            If ColVoie.Count > 0 Then
                StrSSQLEP &= " ,THERIAQUE.COSAU_COMPO_SUBAUX, THERIAQUE.SPVO_SPECIALITE_VOIE "
                StrSSQLEP &= " where COSAU_SP_CODE_FK_PK = SP_CODE_SQ_PK "
                StrSSQLEP &= " and SPVO_SP_CODE_FK_PK = SP_CODE_SQ_PK "
                StrSSQLEP &= " and COSAU_SAU_CODE_FK_PK in " & GetCodeFromCollection(ColSAU)
                StrSSQLEP &= " and SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
                If f3._CollectionIn.Count > 0 Then
                    StrSSQLEP &= " Union Select Distinct SP_CODE_SQ_PK as code, SP_NOM as libelle ,0 as chk ,0 as chkFixe From THERIAQUE.SP_SPECIALITE "
                    StrSSQLEP &= " where  SP_CODE_SQ_PK in " & GetCodeFromCollection(f3._CollectionIn)
                End If
            Else
                StrSSQLEP &= " ,THERIAQUE.COSAU_COMPO_SUBAUX "
                StrSSQLEP &= " where COSAU_SP_CODE_FK_PK = SP_CODE_SQ_PK "
                StrSSQLEP &= " and COSAU_SAU_CODE_FK_PK in " & GetCodeFromCollection(ColSAU)
                If f3._CollectionIn.Count > 0 Then
                    StrSSQLEP &= " Union Select Distinct SP_CODE_SQ_PK as code, SP_NOM as libelle ,0 as chk,0 as chkFixe From THERIAQUE.SP_SPECIALITE "
                    StrSSQLEP &= " where  SP_CODE_SQ_PK in " & GetCodeFromCollection(f3._CollectionIn)
                End If
            End If
        Else
            If ColVoie.Count > 0 Then
                StrSSQLEP &= ", THERIAQUE.SPVO_SPECIALITE_VOIE "
                StrSSQLEP &= " where SPVO_SP_CODE_FK_PK = SP_CODE_SQ_PK"
                If f3._CollectionIn.Count > 0 Then
                    StrSSQLEP &= " and (SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
                    StrSSQLEP &= " or SP_CODE_SQ_PK in " & GetCodeFromCollection(f3._CollectionIn) & ")"
                Else
                    StrSSQLEP &= " and SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
                End If
            End If
        End If

        If ColTeneur.Count > 0 Then
            StrSSQLEP &= " Union Select DISTINCT SP_CODE_SQ_PK as code, SP_NOM as libelle ,0 as chk ,0 as chkFixe "
            StrSSQLEP &= " FROM THERIAQUE.COTEN_COMPO_TENEUR, THERIAQUE.SP_SPECIALITE "
            StrSSQLEP &= " where COTEN_SP_CODE_FK_PK = SP_CODE_SQ_PK "
            StrSSQLEP &= " and COTEN_CDF_TEN_CODE_FK_PK in " & GetCodeFromCollection(ColTeneur)
        End If

        f3._SSQL = StrSSQLEP
        f3._strTable = "SP_SPECIALITE"
        f3._Libelle = " Spécialité"
        f3.ShowDialog()
        If f3._Ok = False Then
            Exit Sub
        End If
        Load_On(Frm_Formulaire)
        ColEP = f3._CollectionOut
        f3.Dispose()
        '----------------------------------------------------
        '----------------------------------------------------
        For inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(inti).Table = eDeclinaison.SAU Then
                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

                For intJ As Integer = 0 To gvTemp.RowCount - 1   ' Vider la grille
                    gvTemp.DeleteRow(0)
                Next

                For intk As Integer = 1 To ColSAU.Count
                    gvTemp.AddNewRow()
                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColSAU(intk))
                Next
            End If
            If CollectionContent(inti).Table = eDeclinaison.SP Then
                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

                For intJ As Integer = 0 To gvTemp.RowCount - 1   ' Vider la grille
                    gvTemp.DeleteRow(0)
                Next

                For intk As Integer = 1 To ColEP.Count
                    gvTemp.AddNewRow()
                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColEP(intk))
                Next
            End If
        Next
        Load_Off(Frm_Formulaire)
        '----------------------------------------------------
        '----------------------------------------------------
    End Sub

    Public Sub DeclinaisonSAU_Classique(ByRef FrmFormulaire As Frm_Formulaire, ByVal txtTag As StructTxtProperty)
        Dim ColSAUADD As New Collection
        Dim ColSAUDelete As New Collection
        Dim ColSAU As New Collection

        Dim ColVoie As New Collection
        Dim ColTeneur As New Collection

        Dim ColEP As New Collection
        Dim ColEPDelete As New Collection
        Dim ColEPADD As New Collection

        Dim StrSSQLEP As String = strSSQL_SP_SPECIALITE_Distinct
        Dim StrVoie As String = strSSQL_CDF_CODIF_Distinct("18")
        Dim gvSAU As DevExpress.XtraGrid.Views.Grid.GridView
        Dim gvEP As DevExpress.XtraGrid.Views.Grid.GridView
        Dim gvTemp As DevExpress.XtraGrid.Views.Grid.GridView

        ''---------------------------------------
        '' Affichage des substances actives
        ''---------------------------------------
        Dim f As New Frm_Dictionnaire_Declinaison
        f._strTable = "SAU_SUBAUXILIAIRE"
        f._Libelle = "Exipient"
        f._SSQL = strSSQL_SAU_SUBAUXILIAIRE
        Dim CollectionContent As New System.Collections.Generic.List(Of StructGVTable)
        CollectionContent = txtTag.Declinaison.ContentIn
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.SAU Then
                gvSAU = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                If gvSAU.GetFocusedRowCellValue(CollectionContent(Inti).Column) IsNot Nothing Then
                    Dim colTemp As New Collection
                    colTemp.Add(gvSAU.GetFocusedRowCellValue(CollectionContent(Inti).Column))
                    f._CollectionIn = colTemp
                    f.txtSearch.Text = ClsSAU.GetLibelle(gvSAU.GetFocusedRowCellValue(CollectionContent(Inti).Column))
                End If
                Exit For
            End If
        Next
        f.ShowDialog()
        If f._Ok = False Then
            Exit Sub
        End If
        ColSAU = f._CollectionOut
        ColSAUDelete = f._CollectionOutDelete
        ColSAUADD = f._CollectionOutADD
        f.Dispose()
        ''---------------------------------------
        '' Affichage des Voies
        ''---------------------------------------
        Dim f2 As New Frm_Dictionnaire_Declinaison

        StrVoie = " Select Distinct CDF_CODE_PK as code, CDF_NOM as libelle, CDF_NUMERO_PK as num ,0 as chk From THERIAQUE.CDF_CODIF "
        StrVoie &= " ,THERIAQUE.SPVO_SPECIALITE_VOIE"
        StrVoie &= " where SPVO_CDF_VO_CODE_FK_PK = CDF_CODE_PK"
        StrVoie &= " and CDF_NUMERO_PK = '18'"
        If ColSAU.Count > 0 Then
            StrVoie &= " and SPVO_SP_CODE_FK_PK in "
            StrVoie &= " ("
            StrVoie &= " Select Distinct SP_CODE_SQ_PK as code From THERIAQUE.SP_SPECIALITE"
            StrVoie &= " ,THERIAQUE.COSAU_COMPO_SUBAUX "
            StrVoie &= " where COSAU_SP_CODE_FK_PK = SP_CODE_SQ_PK "
            StrVoie &= " and COSAU_SAU_CODE_FK_PK in " & GetCodeFromCollection(ColSAU)
            StrVoie &= " )"
        End If
        f2._SSQL = StrVoie
        f2._strTable = "CDF_CODIF"
        f2._Libelle = " Voie "
        f2.ShowDialog()
        If f2._Ok = False Then
            Exit Sub
        End If
        ColVoie = f2._CollectionOut
        f2.Dispose()
        ''---------------------------------------
        '' Affichage des Teneurs
        ''---------------------------------------
        Dim f4 As New Frm_Dictionnaire_Declinaison

        StrVoie = " Select Distinct CDF_CODE_PK as code, CDF_NOM as libelle, CDF_NUMERO_PK as num ,0 as chk From THERIAQUE.CDF_CODIF "
        StrVoie &= " ,THERIAQUE.COTEN_COMPO_TENEUR"
        StrVoie &= " where COTEN_CDF_TEN_CODE_FK_PK = CDF_CODE_PK"
        StrVoie &= " and CDF_NUMERO_PK = '24'"
        If ColSAU.Count > 0 Then
            StrVoie &= " and COTEN_SP_CODE_FK_PK in "
            StrVoie &= " ("
            StrVoie &= " Select Distinct SP_CODE_SQ_PK as code From THERIAQUE.SP_SPECIALITE"
            StrVoie &= " ,THERIAQUE.COSAU_COMPO_SUBAUX "
            StrVoie &= " where COSAU_SP_CODE_FK_PK = SP_CODE_SQ_PK "
            StrVoie &= " and COSAU_SAU_CODE_FK_PK in " & GetCodeFromCollection(ColSAU)
            StrVoie &= " )"
        End If
        If ColVoie.Count > 0 Then
            StrVoie &= " and COTEN_SP_CODE_FK_PK in "
            StrVoie &= " ("
            StrVoie &= " Select Distinct SP_CODE_SQ_PK as code From THERIAQUE.SP_SPECIALITE"
            StrVoie &= " ,THERIAQUE.SPVO_SPECIALITE_VOIE "
            StrVoie &= " where SPVO_SP_CODE_FK_PK = SP_CODE_SQ_PK "
            StrVoie &= " and SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
            StrVoie &= " )"
        End If
        f4._SSQL = StrVoie
        f4._strTable = "CDF_CODIF"
        f4._Libelle = " Teneur "
        f4.ShowDialog()
        If f4._Ok = False Then
            Exit Sub
        End If
        ColTeneur = f4._CollectionOut
        f4.Dispose()
        ''---------------------------------------
        '' Affichage des Episodes
        ''---------------------------------------
        Dim f3 As New Frm_Dictionnaire_Declinaison
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.SP Then
                gvEP = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                f3._CollectionIn = GetCodeFromGV(gvEP, CollectionContent(Inti).Column)
                Exit For
            End If
        Next
        If ColSAU.Count > 0 Then
            If ColVoie.Count > 0 Then
                StrSSQLEP &= " ,THERIAQUE.COSAU_COMPO_SUBAUX, THERIAQUE.SPVO_SPECIALITE_VOIE "
                StrSSQLEP &= " where COSAU_SP_CODE_FK_PK = SP_CODE_SQ_PK "
                StrSSQLEP &= " and SPVO_SP_CODE_FK_PK = SP_CODE_SQ_PK "
                StrSSQLEP &= " and COSAU_SAU_CODE_FK_PK in " & GetCodeFromCollection(ColSAU)
                StrSSQLEP &= " and SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
                'If f3._CollectionIn.Count > 0 Then
                '    StrSSQLEP &= " Union Select Distinct SP_CODE_SQ_PK as code, SP_NOM as libelle ,0 as chk ,0 as chkFixe From THERIAQUE.SP_SPECIALITE "
                '    StrSSQLEP &= " where  SP_CODE_SQ_PK in " & GetCodeFromCollection(f3._CollectionIn)
                'End If
            Else
                StrSSQLEP &= " ,THERIAQUE.COSAU_COMPO_SUBAUX "
                StrSSQLEP &= " where COSAU_SP_CODE_FK_PK = SP_CODE_SQ_PK "
                StrSSQLEP &= " and COSAU_SAU_CODE_FK_PK in " & GetCodeFromCollection(ColSAU)
                'If f3._CollectionIn.Count > 0 Then
                '    StrSSQLEP &= " Union Select Distinct SP_CODE_SQ_PK as code, SP_NOM as libelle ,0 as chk,0 as chkFixe From THERIAQUE.SP_SPECIALITE "
                '    StrSSQLEP &= " where  SP_CODE_SQ_PK in " & GetCodeFromCollection(f3._CollectionIn)
                'End If
            End If
        Else
            If ColVoie.Count > 0 Then
                StrSSQLEP &= ", THERIAQUE.SPVO_SPECIALITE_VOIE "
                StrSSQLEP &= " where SPVO_SP_CODE_FK_PK = SP_CODE_SQ_PK"
                'If f3._CollectionIn.Count > 0 Then
                '    StrSSQLEP &= " and (SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
                '    StrSSQLEP &= " or SP_CODE_SQ_PK in " & GetCodeFromCollection(f3._CollectionIn) & ")"
                'Else
                StrSSQLEP &= " and SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
                'End If
            End If
        End If

        If ColTeneur.Count > 0 Then
            StrSSQLEP &= " Union Select DISTINCT SP_CODE_SQ_PK as code, SP_NOM as libelle ,0 as chk ,0 as chkFixe "
            StrSSQLEP &= " FROM THERIAQUE.COTEN_COMPO_TENEUR, THERIAQUE.SP_SPECIALITE "
            StrSSQLEP &= " where COTEN_SP_CODE_FK_PK = SP_CODE_SQ_PK "
            StrSSQLEP &= " and COTEN_CDF_TEN_CODE_FK_PK in " & GetCodeFromCollection(ColTeneur)
        End If

        f3._SSQL = StrSSQLEP
        f3._strTable = "SP_SPECIALITE"
        f3._Libelle = " Spécialité"
        f3.ShowDialog()
        If f3._Ok = False Then
            Exit Sub
        End If
        ColEP = f3._CollectionOut
        ColEPDelete = f3._CollectionOutDelete
        ColEPADD = f3._CollectionOutADD
        f3.Dispose()
        '----------------------------------------------------
        '----------------------------------------------------
        Load_On(Frm_Formulaire)
        For inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(inti).Table = eDeclinaison.SAU Then
                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

                For intk As Integer = 1 To ColSAUADD.Count
                    gvTemp.AddNewRow()
                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColSAUADD(intk))
                Next
                For intk As Integer = 1 To ColSAUDelete.Count
                    For intJ As Integer = 0 To gvTemp.RowCount - 1
                        If gvTemp.GetRowCellValue(intJ, CollectionContent(inti).Column) = ColSAUDelete(intk) Then
                            gvTemp.DeleteRow(intJ)
                            Exit For
                        End If
                    Next
                Next
            End If
            If CollectionContent(inti).Table = eDeclinaison.SP Then
                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

                For intk As Integer = 1 To ColEPADD.Count
                    gvTemp.AddNewRow()
                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColEPADD(intk))
                    If (CollectionContent(inti).Column.Name = "") Then

                    End If
                Next
                For intk As Integer = 1 To ColEPDelete.Count
                    For intJ As Integer = 0 To gvTemp.RowCount - 1
                        If gvTemp.GetRowCellValue(intJ, CollectionContent(inti).Column) = ColEPDelete(intk) Then
                            gvTemp.DeleteRow(intJ)
                            Exit For
                        End If
                    Next
                Next
            End If
        Next
        Load_Off(Frm_Formulaire)
        '----------------------------------------------------
        '----------------------------------------------------
    End Sub

#End Region

#Region " CPH "

    Public Sub DeclinaisonCPH_Globale(ByRef FrmFormulaire As Frm_Formulaire, ByVal txtTag As StructTxtProperty)
        Dim ColCPHADD As New Collection
        Dim ColCPHDelete As New Collection
        Dim ColCPH As New Collection

        Dim ColCCHADD As New Collection
        Dim ColCCHDelete As New Collection
        Dim ColCCH As New Collection

        Dim ColSACADD As New Collection
        Dim ColSACDelete As New Collection
        Dim ColSAC As New Collection

        Dim ColVoie As New Collection
        Dim ColTeneur As New Collection

        Dim ColEP As New Collection
        Dim ColEPDelete As New Collection
        Dim ColEPADD As New Collection

        Dim StrSSQLEP As String = strSSQL_SP_SPECIALITE_Distinct
        Dim StrVoie As String = strSSQL_CDF_CODIF_Distinct("18")

        Dim gvCPH As DevExpress.XtraGrid.Views.Grid.GridView
        Dim gvCCH As DevExpress.XtraGrid.Views.Grid.GridView
        Dim gvSAC As DevExpress.XtraGrid.Views.Grid.GridView

        Dim gvEP As DevExpress.XtraGrid.Views.Grid.GridView
        Dim gvTemp As DevExpress.XtraGrid.Views.Grid.GridView

        Dim CollectionContent As New System.Collections.Generic.List(Of StructGVTable)
        CollectionContent = txtTag.Declinaison.ContentIn
        ''---------------------------------------
        '' Affichage des Classe pharmaco-thérapeutique
        ''---------------------------------------
        Dim f As New Frm_Dictionnaire_Declinaison
        f._strTable = "CPH_CLASSEPHARMTHER"
        f._Libelle = "Classe pharmaco-thérapeutique"
        Dim strSSQL_CPH_CLASSEPHARMTHER2 As String = ""
        strSSQL_CPH_CLASSEPHARMTHER2 &= " Select CPH_CODE_PK as code, CPH_NOM as libelle,0 as disable ,0 as chk ,0 as chkFixe From THERIAQUE.CPH_CLASSEPHARMTHER"
        strSSQL_CPH_CLASSEPHARMTHER2 &= " where CPH_CODE_PK  not in (select distinct isnull(CPH_CPH_CODE_FK,'') from THERIAQUE.CPH_CLASSEPHARMTHER) "
        strSSQL_CPH_CLASSEPHARMTHER2 &= " union"
        strSSQL_CPH_CLASSEPHARMTHER2 &= " Select CPH_CODE_PK as code, CPH_NOM as libelle, 1 as disable,0 as chk ,0 as chkFixe From THERIAQUE.CPH_CLASSEPHARMTHER"
        strSSQL_CPH_CLASSEPHARMTHER2 &= " where CPH_CODE_PK in (select distinct isnull(CPH_CPH_CODE_FK,'') from THERIAQUE.CPH_CLASSEPHARMTHER) "
        strSSQL_CPH_CLASSEPHARMTHER2 &= " order by CPH_CODE_PK "
        f._SSQL = strSSQL_CPH_CLASSEPHARMTHER2
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.CPH Then
                gvCPH = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                f._CollectionIn = GetCodeStringFromGV(gvCPH, CollectionContent(Inti).Column)
                Exit For
            End If
        Next
        f.ShowDialog()
        If f._Ok = False Then
            Exit Sub
        End If
        ColCPH = f._CollectionOut
        ColCPHDelete = f._CollectionOutDelete
        ColCPHADD = f._CollectionOutADD
        f.Dispose()

        ''---------------------------------------
        '' Affichage des Classe Chimique
        ''---------------------------------------
        Dim f2 As New Frm_Dictionnaire_Declinaison
        f2._strTable = "CCH_CLASSECHIMIQUE"
        f2._Libelle = "Classe chimique"
        Dim strSSQL_CCH_CLASSECHIMIQUE2 As String = ""
        strSSQL_CCH_CLASSECHIMIQUE2 &= " Select CCH_CODE_PK as code, CCH_NOM as libelle,0 as disable ,0 as chk ,0 as chkFixe From THERIAQUE.CCH_CLASSECHIMIQUE"
        strSSQL_CCH_CLASSECHIMIQUE2 &= " where CCH_CODE_PK  not in (select distinct isnull(CCH_CCH_CODE_FK,'') from THERIAQUE.CCH_CLASSECHIMIQUE) "
        strSSQL_CCH_CLASSECHIMIQUE2 &= " union"
        strSSQL_CCH_CLASSECHIMIQUE2 &= " Select CCH_CODE_PK as code, CCH_NOM as libelle, 1 as disable,0 as chk ,0 as chkFixe From THERIAQUE.CCH_CLASSECHIMIQUE"
        strSSQL_CCH_CLASSECHIMIQUE2 &= " where CCH_CODE_PK in (select distinct isnull(CCH_CCH_CODE_FK,'') from THERIAQUE.CCH_CLASSECHIMIQUE) "
        strSSQL_CCH_CLASSECHIMIQUE2 &= " order by CCH_CODE_PK "
        f2._SSQL = strSSQL_CCH_CLASSECHIMIQUE2
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.CCH Then
                gvCCH = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                f2._CollectionIn = GetCodeStringFromGV(gvCCH, CollectionContent(Inti).Column)
                Exit For
            End If
        Next
        If gvCCH IsNot Nothing Then
            f2.ShowDialog()
            If f2._Ok = False Then
                Exit Sub
            End If
            ColCCH = f2._CollectionOut
            ColCCHDelete = f2._CollectionOutDelete
            ColCCHADD = f2._CollectionOutADD
            f2.Dispose()
        End If
        ''---------------------------------------
        '' Affichage des substances actives
        ''---------------------------------------
        Dim f4 As New Frm_Dictionnaire_Declinaison
        f4._strTable = "SAC_SUBACTIVE"
        f4._Libelle = "Substances actives"
        Dim strSSQL_SAC_SUBACTIVE2 As String = ""
        strSSQL_SAC_SUBACTIVE2 = strSSQL_SAC_SUBACTIVE
        If ColCPH.Count > 0 Then
            If ColCCH.Count > 0 Then
                strSSQL_SAC_SUBACTIVE2 = " Select SAC_CODE_SQ_PK as code, SAC_NOM as libelle,0 as chk ,0 as chkFixe From THERIAQUE.SAC_SUBACTIVE"
                strSSQL_SAC_SUBACTIVE2 &= " ,THERIAQUE.SACCCH_SUBACT_CLASSECH"
                strSSQL_SAC_SUBACTIVE2 &= " where SACCCH_CCH_CODE_FK_PK  in " & GetCodeFromCollectionString(ColCCH)
                strSSQL_SAC_SUBACTIVE2 &= " and SACCCH_SAC_CODE_FK_PK = SAC_CODE_SQ_PK "
                strSSQL_SAC_SUBACTIVE2 &= " UNION "
                strSSQL_SAC_SUBACTIVE2 &= " Select SAC_CODE_SQ_PK as code, SAC_NOM as libelle,0 as chk ,0 as chkFixe From THERIAQUE.SAC_SUBACTIVE"
                strSSQL_SAC_SUBACTIVE2 &= " ,THERIAQUE.SACCPH_SUBACT_CLASSEPH"
                strSSQL_SAC_SUBACTIVE2 &= " where SACCPH_CPH_CODE_FK_PK  in " & GetCodeFromCollectionString(ColCPH)
                strSSQL_SAC_SUBACTIVE2 &= " and SACCPH_SAC_CODE_FK_PK = SAC_CODE_SQ_PK "
            Else
                strSSQL_SAC_SUBACTIVE2 = " Select SAC_CODE_SQ_PK as code, SAC_NOM as libelle,0 as chk ,0 as chkFixe From THERIAQUE.SAC_SUBACTIVE"
                strSSQL_SAC_SUBACTIVE2 &= " ,THERIAQUE.SACCPH_SUBACT_CLASSEPH"
                strSSQL_SAC_SUBACTIVE2 &= " where SACCPH_CPH_CODE_FK_PK  in " & GetCodeFromCollectionString(ColCPH)
                strSSQL_SAC_SUBACTIVE2 &= " and SACCPH_SAC_CODE_FK_PK = SAC_CODE_SQ_PK "
            End If
        Else
            If ColCCH.Count > 0 Then
                strSSQL_SAC_SUBACTIVE2 = " Select SAC_CODE_SQ_PK as code, SAC_NOM as libelle,0 as chk ,0 as chkFixe From THERIAQUE.SAC_SUBACTIVE"
                strSSQL_SAC_SUBACTIVE2 &= " ,THERIAQUE.SACCCH_SUBACT_CLASSECH"
                strSSQL_SAC_SUBACTIVE2 &= " where SACCCH_CCH_CODE_FK_PK  in " & GetCodeFromCollectionString(ColCCH)
                strSSQL_SAC_SUBACTIVE2 &= " and SACCCH_SAC_CODE_FK_PK = SAC_CODE_SQ_PK "
            End If
        End If
        f4._SSQL = strSSQL_SAC_SUBACTIVE2

        'If ColCPH.Count > 0 Then
        '    If ColCCH.Count > 0 Then
        '        strSSQL_SAC_SUBACTIVE2 = " Select distinct SAC_CODE_SQ_PK as code, SAC_NOM as libelle,0 as chk ,0 as chkFixe From THERIAQUE.SAC_SUBACTIVE"
        '        strSSQL_SAC_SUBACTIVE2 &= " ,THERIAQUE.SACCCH_SUBACT_CLASSECH"
        '        strSSQL_SAC_SUBACTIVE2 &= " ,THERIAQUE.SACCPH_SUBACT_CLASSEPH"
        '        strSSQL_SAC_SUBACTIVE2 &= " where SACCPH_CPH_CODE_FK_PK  in " & GetCodeFromCollection(ColCPH)
        '        strSSQL_SAC_SUBACTIVE2 &= " where SACCCH_CCH_CODE_FK_PK  in " & GetCodeFromCollection(ColCCH)
        '        strSSQL_SAC_SUBACTIVE2 &= " and SACCCH_SAC_CODE_FK_PK = SAC_CODE_SQ_PK "
        '        strSSQL_SAC_SUBACTIVE2 &= " and SACCPH_SAC_CODE_FK_PK = SAC_CODE_SQ_PK "
        '    Else
        '        strSSQL_SAC_SUBACTIVE2 = " Select SAC_CODE_SQ_PK as code, SAC_NOM as libelle,0 as chk ,0 as chkFixe From THERIAQUE.SAC_SUBACTIVE"
        '        strSSQL_SAC_SUBACTIVE2 &= " ,THERIAQUE.SACCCH_SUBACT_CLASSECH"
        '        strSSQL_SAC_SUBACTIVE2 &= " where SACCPH_SAC_CODE_FK_PK  in " & GetCodeFromCollection(ColCPH)
        '        strSSQL_SAC_SUBACTIVE2 &= " and SACCPH_SAC_CODE_FK_PK = SAC_CODE_SQ_PK "
        '    End If
        'Else
        '    If ColCCH.Count > 0 Then
        '        strSSQL_SAC_SUBACTIVE2 = " Select SAC_CODE_SQ_PK as code, SAC_NOM as libelle,0 as chk ,0 as chkFixe From THERIAQUE.SAC_SUBACTIVE"
        '        strSSQL_SAC_SUBACTIVE2 &= " ,THERIAQUE.SACCCH_SUBACT_CLASSECH"
        '        strSSQL_SAC_SUBACTIVE2 &= " where SACCCH_CCH_CODE_FK_PK  in " & GetCodeFromCollection(ColCCH)
        '        strSSQL_SAC_SUBACTIVE2 &= " and SACCCH_SAC_CODE_FK_PK = SAC_CODE_SQ_PK "
        '    End If
        'End If
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.SAC Then
                gvSAC = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                f4._CollectionIn = GetCodeFromGV(gvSAC, CollectionContent(Inti).Column)
                'strSSQL_SAC_SUBACTIVE2 &= " Union"
                'strSSQL_SAC_SUBACTIVE2 &= " Select SAC_CODE_SQ_PK as code, SAC_NOM as libelle,0 as chk ,0 as chkFixe From THERIAQUE.SAC_SUBACTIVE"
                'strSSQL_SAC_SUBACTIVE2 &= " where SAC_CODE_SQ_PK in " & GetCodeFromCollection(GetCodeFromGV(gvSAC, CollectionContent(Inti).Column))
                'f4._SSQL = strSSQL_SAC_SUBACTIVE
                Exit For
            End If
        Next
        f4.ShowDialog()
        If f4._Ok = False Then
            Exit Sub
        End If
        ColSAC = f4._CollectionOut
        ColSACDelete = f4._CollectionOutDelete
        ColSACADD = f4._CollectionOutADD
        f4.Dispose()
        ''---------------------------------------
        '' Affichage des Voies
        ''---------------------------------------
        Dim f8 As New Frm_Dictionnaire_Declinaison

        StrVoie = " Select Distinct CDF_CODE_PK as code, CDF_NOM as libelle, CDF_NUMERO_PK as num ,0 as chk From THERIAQUE.CDF_CODIF "
        StrVoie &= " ,THERIAQUE.SPVO_SPECIALITE_VOIE"
        StrVoie &= " where SPVO_CDF_VO_CODE_FK_PK = CDF_CODE_PK"
        StrVoie &= " and CDF_NUMERO_PK = '18'"
        If ColSAC.Count > 0 Then
            StrVoie &= " and SPVO_SP_CODE_FK_PK in "
            StrVoie &= " ("
            StrVoie &= " Select Distinct SP_CODE_SQ_PK as code From THERIAQUE.SP_SPECIALITE"
            StrVoie &= " ,THERIAQUE.COSAC_COMPO_SUBACT "
            StrVoie &= " where COSAC_SP_CODE_FK_PK = SP_CODE_SQ_PK "
            StrVoie &= " and COSAC_SAC_CODE_FK_PK in " & GetCodeFromCollection(ColSAC)
            StrVoie &= " )"
        End If
        f8._SSQL = StrVoie
        f8._strTable = "CDF_CODIF"
        f8._Libelle = " Voie "
        f8.ShowDialog()
        If f8._Ok = False Then
            Exit Sub
        End If
        ColVoie = f8._CollectionOut
        f8.Dispose()

        ''---------------------------------------
        '' Affichage des Episodes
        ''---------------------------------------
        Dim f3 As New Frm_Dictionnaire_Declinaison
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.SP Then
                gvEP = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                f3._CollectionIn = GetCodeFromGV(gvEP, CollectionContent(Inti).Column)
                Exit For
            End If
        Next
        If ColSAC.Count > 0 Then
            If ColVoie.Count > 0 Then
                StrSSQLEP &= " ,THERIAQUE.COSAC_COMPO_SUBACT, THERIAQUE.SPVO_SPECIALITE_VOIE "
                StrSSQLEP &= " where COSAC_SP_CODE_FK_PK = SP_CODE_SQ_PK "
                StrSSQLEP &= " and SPVO_SP_CODE_FK_PK = SP_CODE_SQ_PK "
                StrSSQLEP &= " and COSAC_SAC_CODE_FK_PK in " & GetCodeFromCollection(ColSAC)
                StrSSQLEP &= " and SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
                If f3._CollectionIn.Count > 0 Then
                    StrSSQLEP &= " Union Select Distinct SP_CODE_SQ_PK as code, SP_NOM as libelle ,0 as chk ,0 as chkFixe From THERIAQUE.SP_SPECIALITE "
                    StrSSQLEP &= " where  SP_CODE_SQ_PK in " & GetCodeFromCollection(f3._CollectionIn)
                End If
            Else
                StrSSQLEP &= " ,THERIAQUE.COSAC_COMPO_SUBACT "
                StrSSQLEP &= " where COSAC_SP_CODE_FK_PK = SP_CODE_SQ_PK "
                StrSSQLEP &= " and COSAC_SAC_CODE_FK_PK in " & GetCodeFromCollection(ColSAC)
                If f3._CollectionIn.Count > 0 Then
                    StrSSQLEP &= " Union Select Distinct SP_CODE_SQ_PK as code, SP_NOM as libelle ,0 as chk,0 as chkFixe From THERIAQUE.SP_SPECIALITE "
                    StrSSQLEP &= " where  SP_CODE_SQ_PK in " & GetCodeFromCollection(f3._CollectionIn)
                End If
            End If
        Else
            If ColVoie.Count > 0 Then
                StrSSQLEP &= ", THERIAQUE.SPVO_SPECIALITE_VOIE "
                StrSSQLEP &= " where SPVO_SP_CODE_FK_PK = SP_CODE_SQ_PK"
                If f3._CollectionIn.Count > 0 Then
                    StrSSQLEP &= " and (SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
                    StrSSQLEP &= " or SP_CODE_SQ_PK in " & GetCodeFromCollection(f3._CollectionIn) & ")"
                Else
                    StrSSQLEP &= " and SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
                End If
            End If
        End If

        If ColTeneur.Count > 0 Then
            StrSSQLEP &= " Union Select DISTINCT SP_CODE_SQ_PK as code, SP_NOM as libelle ,0 as chk ,0 as chkFixe "
            StrSSQLEP &= " FROM THERIAQUE.COTEN_COMPO_TENEUR, THERIAQUE.SP_SPECIALITE "
            StrSSQLEP &= " where COTEN_SP_CODE_FK_PK = SP_CODE_SQ_PK "
            StrSSQLEP &= " and COTEN_CDF_TEN_CODE_FK_PK in " & GetCodeFromCollection(ColTeneur)
        End If

        f3._SSQL = StrSSQLEP
        f3._strTable = "SP_SPECIALITE"
        f3._Libelle = " Spécialité"
        f3.ShowDialog()
        If f3._Ok = False Then
            Exit Sub
        End If
        ColEP = f3._CollectionOut
        ColEPDelete = f3._CollectionOutDelete
        ColEPADD = f3._CollectionOutADD
        f3.Dispose()
        '----------------------------------------------------
        '----------------------------------------------------
        Load_On(Frm_Formulaire)
        For inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(inti).Table = eDeclinaison.CPH Then
                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

                For intk As Integer = 1 To ColCPHADD.Count
                    gvTemp.AddNewRow()
                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColCPHADD(intk))
                Next
                For intk As Integer = 1 To ColCPHDelete.Count
                    For intJ As Integer = 0 To gvTemp.RowCount - 1
                        If gvTemp.GetRowCellValue(intJ, CollectionContent(inti).Column) = ColCPHDelete(intk) Then
                            gvTemp.DeleteRow(intJ)
                            Exit For
                        End If
                    Next
                Next
            End If
            If CollectionContent(inti).Table = eDeclinaison.CCH Then
                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

                For intk As Integer = 1 To ColCCHADD.Count
                    gvTemp.AddNewRow()
                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColCCHADD(intk))
                Next
                For intk As Integer = 1 To ColCCHDelete.Count
                    For intJ As Integer = 0 To gvTemp.RowCount - 1
                        If gvTemp.GetRowCellValue(intJ, CollectionContent(inti).Column) = ColCCHDelete(intk) Then
                            gvTemp.DeleteRow(intJ)
                            Exit For
                        End If
                    Next
                Next
            End If
            If CollectionContent(inti).Table = eDeclinaison.SAC Then
                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

                For intk As Integer = 1 To ColSACADD.Count
                    gvTemp.AddNewRow()
                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColSACADD(intk))
                Next
                For intk As Integer = 1 To ColSACDelete.Count
                    For intJ As Integer = 0 To gvTemp.RowCount - 1
                        If gvTemp.GetRowCellValue(intJ, CollectionContent(inti).Column) = ColSACDelete(intk) Then
                            gvTemp.DeleteRow(intJ)
                            Exit For
                        End If
                    Next
                Next
            End If
            If CollectionContent(inti).Table = eDeclinaison.SP Then
                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

                For intk As Integer = 1 To ColEPADD.Count
                    gvTemp.AddNewRow()
                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColEPADD(intk))
                Next
                For intk As Integer = 1 To ColEPDelete.Count
                    For intJ As Integer = 0 To gvTemp.RowCount - 1
                        If gvTemp.GetRowCellValue(intJ, CollectionContent(inti).Column) = ColEPDelete(intk) Then
                            gvTemp.DeleteRow(intJ)
                            Exit For
                        End If
                    Next
                Next
            End If
        Next
        Load_Off(Frm_Formulaire)
        '----------------------------------------------------
        '----------------------------------------------------
    End Sub

    Public Sub DeclinaisonCPH_Classique(ByRef FrmFormulaire As Frm_Formulaire, ByVal txtTag As StructTxtProperty)
        Dim ColCPHADD As New Collection
        Dim ColCPHDelete As New Collection
        Dim ColCPH As New Collection

        Dim ColCCHADD As New Collection
        Dim ColCCHDelete As New Collection
        Dim ColCCH As New Collection

        Dim ColSACADD As New Collection
        Dim ColSACDelete As New Collection
        Dim ColSAC As New Collection

        Dim ColVoie As New Collection
        Dim ColTeneur As New Collection

        Dim ColEP As New Collection
        Dim ColEPDelete As New Collection
        Dim ColEPADD As New Collection

        Dim StrSSQLEP As String = strSSQL_SP_SPECIALITE_Distinct
        Dim StrVoie As String = strSSQL_CDF_CODIF_Distinct("18")

        Dim gvCPH As DevExpress.XtraGrid.Views.Grid.GridView
        Dim gvCCH As DevExpress.XtraGrid.Views.Grid.GridView
        Dim gvSAC As DevExpress.XtraGrid.Views.Grid.GridView

        Dim gvEP As DevExpress.XtraGrid.Views.Grid.GridView
        Dim gvTemp As DevExpress.XtraGrid.Views.Grid.GridView

        Dim CollectionContent As New System.Collections.Generic.List(Of StructGVTable)
        CollectionContent = txtTag.Declinaison.ContentIn
        ''---------------------------------------
        '' Affichage des Classe pharmaco-thérapeutique
        ''---------------------------------------
        Dim f As New Frm_Dictionnaire_Declinaison
        f._strTable = "CPH_CLASSEPHARMTHER"
        f._Libelle = "Classe pharmaco-thérapeutique"
        Dim strSSQL_CPH_CLASSEPHARMTHER2 As String = ""
        strSSQL_CPH_CLASSEPHARMTHER2 &= " Select CPH_CODE_PK as code, CPH_NOM as libelle,0 as disable ,0 as chk ,0 as chkFixe From THERIAQUE.CPH_CLASSEPHARMTHER"
        strSSQL_CPH_CLASSEPHARMTHER2 &= " where CPH_CODE_PK  not in (select distinct isnull(CPH_CPH_CODE_FK,'') from THERIAQUE.CPH_CLASSEPHARMTHER) "
        strSSQL_CPH_CLASSEPHARMTHER2 &= " union"
        strSSQL_CPH_CLASSEPHARMTHER2 &= " Select CPH_CODE_PK as code, CPH_NOM as libelle, 1 as disable,0 as chk ,0 as chkFixe From THERIAQUE.CPH_CLASSEPHARMTHER"
        strSSQL_CPH_CLASSEPHARMTHER2 &= " where CPH_CODE_PK in (select distinct isnull(CPH_CPH_CODE_FK,'') from THERIAQUE.CPH_CLASSEPHARMTHER) "
        strSSQL_CPH_CLASSEPHARMTHER2 &= " order by CPH_CODE_PK "
        f._SSQL = strSSQL_CPH_CLASSEPHARMTHER2
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.CPH Then
                gvCPH = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                Dim colTemp As New Collection
                If gvCPH.GetFocusedRowCellValue(CollectionContent(Inti).Column) IsNot Nothing Then
                    colTemp.Add(cn.SQLText(gvCPH.GetFocusedRowCellValue(CollectionContent(Inti).Column)))
                    f._CollectionIn = colTemp
                End If
                f.txtSearch.Text = ClsCPH.GetLibelle(gvCPH.GetFocusedRowCellValue(CollectionContent(Inti).Column))
                Exit For
            End If
        Next
        f.ShowDialog()
        If f._Ok = False Then
            Exit Sub
        End If
        ColCPH = f._CollectionOut
        ColCPHDelete = f._CollectionOutDelete
        ColCPHADD = f._CollectionOutADD
        f.Dispose()

        ''---------------------------------------
        '' Affichage des Classe Chimique
        ''---------------------------------------
        Dim f2 As New Frm_Dictionnaire_Declinaison
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.CCH Then
                gvCCH = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                f2._CollectionIn = GetCodeStringFromGV(gvCCH, CollectionContent(Inti).Column)
                Exit For

            End If
        Next
        If gvCCH IsNot Nothing Then
            'Dim f2 As New Frm_Dictionnaire_Declinaison
            f2._strTable = "CCH_CLASSECHIMIQUE"
            f2._Libelle = "Classe chimique"
            Dim strSSQL_CCH_CLASSECHIMIQUE2 As String = ""
            strSSQL_CCH_CLASSECHIMIQUE2 &= " Select CCH_CODE_PK as code, CCH_NOM as libelle,0 as disable ,0 as chk ,0 as chkFixe From THERIAQUE.CCH_CLASSECHIMIQUE"
            strSSQL_CCH_CLASSECHIMIQUE2 &= " where CCH_CODE_PK  not in (select distinct isnull(CCH_CCH_CODE_FK,'') from THERIAQUE.CCH_CLASSECHIMIQUE) "
            strSSQL_CCH_CLASSECHIMIQUE2 &= " union"
            strSSQL_CCH_CLASSECHIMIQUE2 &= " Select CCH_CODE_PK as code, CCH_NOM as libelle, 1 as disable,0 as chk ,0 as chkFixe From THERIAQUE.CCH_CLASSECHIMIQUE"
            strSSQL_CCH_CLASSECHIMIQUE2 &= " where CCH_CODE_PK in (select distinct isnull(CCH_CCH_CODE_FK,'') from THERIAQUE.CCH_CLASSECHIMIQUE) "
            strSSQL_CCH_CLASSECHIMIQUE2 &= " order by CCH_CODE_PK "
            f2._SSQL = strSSQL_CCH_CLASSECHIMIQUE2
            'For Inti As Integer = 0 To CollectionContent.Count - 1
            '    If CollectionContent(Inti).Table = eDeclinaison.CCH Then
            '        gvCCH = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
            '        f2._CollectionIn = GetCodeStringFromGV(gvCCH, CollectionContent(Inti).Column)
            '        Exit For

            '    End If
            'Next
            f2.ShowDialog()
            If f2._Ok = False Then
                Exit Sub
            End If
            ColCCH = f2._CollectionOut
            ColCCHDelete = f2._CollectionOutDelete
            ColCCHADD = f2._CollectionOutADD
            f2.Dispose()
        End If
        ''---------------------------------------
        '' Affichage des substances actives
        ''---------------------------------------
        Dim f4 As New Frm_Dictionnaire_Declinaison
        f4._strTable = "SAC_SUBACTIVE"
        f4._Libelle = "Substances actives"
        Dim strSSQL_SAC_SUBACTIVE2 As String = ""
        strSSQL_SAC_SUBACTIVE2 = strSSQL_SAC_SUBACTIVE
        If ColCPH.Count > 0 Then
            If ColCCH.Count > 0 Then
                strSSQL_SAC_SUBACTIVE2 = " Select SAC_CODE_SQ_PK as code, SAC_NOM as libelle,0 as chk ,0 as chkFixe From THERIAQUE.SAC_SUBACTIVE"
                strSSQL_SAC_SUBACTIVE2 &= " ,THERIAQUE.SACCCH_SUBACT_CLASSECH"
                strSSQL_SAC_SUBACTIVE2 &= " where SACCCH_CCH_CODE_FK_PK  in " & GetCodeFromCollectionString(ColCCH)
                strSSQL_SAC_SUBACTIVE2 &= " and SACCCH_SAC_CODE_FK_PK = SAC_CODE_SQ_PK "
                strSSQL_SAC_SUBACTIVE2 &= " UNION "
                strSSQL_SAC_SUBACTIVE2 &= " Select SAC_CODE_SQ_PK as code, SAC_NOM as libelle,0 as chk ,0 as chkFixe From THERIAQUE.SAC_SUBACTIVE"
                strSSQL_SAC_SUBACTIVE2 &= " ,THERIAQUE.SACCPH_SUBACT_CLASSEPH"
                strSSQL_SAC_SUBACTIVE2 &= " where SACCPH_CPH_CODE_FK_PK  in " & GetCodeFromCollectionString(ColCPH)
                strSSQL_SAC_SUBACTIVE2 &= " and SACCPH_SAC_CODE_FK_PK = SAC_CODE_SQ_PK "
            Else
                strSSQL_SAC_SUBACTIVE2 = " Select SAC_CODE_SQ_PK as code, SAC_NOM as libelle,0 as chk ,0 as chkFixe From THERIAQUE.SAC_SUBACTIVE"
                strSSQL_SAC_SUBACTIVE2 &= " ,THERIAQUE.SACCPH_SUBACT_CLASSEPH"
                strSSQL_SAC_SUBACTIVE2 &= " where SACCPH_CPH_CODE_FK_PK  in " & GetCodeFromCollectionString(ColCPH)
                strSSQL_SAC_SUBACTIVE2 &= " and SACCPH_SAC_CODE_FK_PK = SAC_CODE_SQ_PK "
            End If
        Else
            If ColCCH.Count > 0 Then
                strSSQL_SAC_SUBACTIVE2 = " Select SAC_CODE_SQ_PK as code, SAC_NOM as libelle,0 as chk ,0 as chkFixe From THERIAQUE.SAC_SUBACTIVE"
                strSSQL_SAC_SUBACTIVE2 &= " ,THERIAQUE.SACCCH_SUBACT_CLASSECH"
                strSSQL_SAC_SUBACTIVE2 &= " where SACCCH_CCH_CODE_FK_PK  in " & GetCodeFromCollectionString(ColCCH)
                strSSQL_SAC_SUBACTIVE2 &= " and SACCCH_SAC_CODE_FK_PK = SAC_CODE_SQ_PK "
            End If
        End If
        f4._SSQL = strSSQL_SAC_SUBACTIVE2
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.SAC Then
                gvSAC = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                'Dim colTemp As New Collection
                'colTemp.Add(gvSAC.GetFocusedRowCellValue(CollectionContent(Inti).Column))
                f4._CollectionIn = GetCodeFromGV(gvSAC, CollectionContent(Inti).Column)
                'f4.txtSearch.Text = ClsSAC.GetLibelle(gvSAC.GetFocusedRowCellValue(CollectionContent(Inti).Column))
                Exit For
            End If
        Next
        f4.ShowDialog()
        If f4._Ok = False Then
            Exit Sub
        End If
        ColSAC = f4._CollectionOut
        ColSACDelete = f4._CollectionOutDelete
        ColSACADD = f4._CollectionOutADD
        f4.Dispose()
        ''---------------------------------------
        '' Affichage des Voies
        ''---------------------------------------
        Dim f8 As New Frm_Dictionnaire_Declinaison

        StrVoie = " Select Distinct CDF_CODE_PK as code, CDF_NOM as libelle, CDF_NUMERO_PK as num ,0 as chk From THERIAQUE.CDF_CODIF "
        StrVoie &= " ,THERIAQUE.SPVO_SPECIALITE_VOIE"
        StrVoie &= " where SPVO_CDF_VO_CODE_FK_PK = CDF_CODE_PK"
        StrVoie &= " and CDF_NUMERO_PK = '18'"
        If ColSAC.Count > 0 Then
            StrVoie &= " and SPVO_SP_CODE_FK_PK in "
            StrVoie &= " ("
            StrVoie &= " Select Distinct SP_CODE_SQ_PK as code From THERIAQUE.SP_SPECIALITE"
            StrVoie &= " ,THERIAQUE.COSAC_COMPO_SUBACT "
            StrVoie &= " where COSAC_SP_CODE_FK_PK = SP_CODE_SQ_PK "
            StrVoie &= " and COSAC_SAC_CODE_FK_PK in " & GetCodeFromCollection(ColSAC)
            StrVoie &= " )"
        End If
        f8._SSQL = StrVoie
        f8._strTable = "CDF_CODIF"
        f8._Libelle = " Voie "
        f8.ShowDialog()
        If f8._Ok = False Then
            Exit Sub
        End If
        ColVoie = f8._CollectionOut
        f8.Dispose()

        ''---------------------------------------
        '' Affichage des Episodes
        ''---------------------------------------
        Dim f3 As New Frm_Dictionnaire_Declinaison
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.SP Then
                gvEP = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                f3._CollectionIn = GetCodeFromGV(gvEP, CollectionContent(Inti).Column)
                Exit For
            End If
        Next
        If ColSAC.Count > 0 Then
            If ColVoie.Count > 0 Then
                StrSSQLEP &= " ,THERIAQUE.COSAC_COMPO_SUBACT, THERIAQUE.SPVO_SPECIALITE_VOIE "
                StrSSQLEP &= " where COSAC_SP_CODE_FK_PK = SP_CODE_SQ_PK "
                StrSSQLEP &= " and SPVO_SP_CODE_FK_PK = SP_CODE_SQ_PK "
                StrSSQLEP &= " and COSAC_SAC_CODE_FK_PK in " & GetCodeFromCollection(ColSAC)
                StrSSQLEP &= " and SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
                'If f3._CollectionIn.Count > 0 Then
                '    StrSSQLEP &= " Union Select Distinct SP_CODE_SQ_PK as code, SP_NOM as libelle ,0 as chk ,0 as chkFixe From THERIAQUE.SP_SPECIALITE "
                '    StrSSQLEP &= " where  SP_CODE_SQ_PK in " & GetCodeFromCollection(f3._CollectionIn)
                'End If
            Else
                StrSSQLEP &= " ,THERIAQUE.COSAC_COMPO_SUBACT "
                StrSSQLEP &= " where COSAC_SP_CODE_FK_PK = SP_CODE_SQ_PK "
                StrSSQLEP &= " and COSAC_SAC_CODE_FK_PK in " & GetCodeFromCollection(ColSAC)
                'If f3._CollectionIn.Count > 0 Then
                '    StrSSQLEP &= " Union Select Distinct SP_CODE_SQ_PK as code, SP_NOM as libelle ,0 as chk,0 as chkFixe From THERIAQUE.SP_SPECIALITE "
                '    StrSSQLEP &= " where  SP_CODE_SQ_PK in " & GetCodeFromCollection(f3._CollectionIn)
                'End If
            End If
        Else
            If ColVoie.Count > 0 Then
                StrSSQLEP &= ", THERIAQUE.SPVO_SPECIALITE_VOIE "
                StrSSQLEP &= " where SPVO_SP_CODE_FK_PK = SP_CODE_SQ_PK"
                'If f3._CollectionIn.Count > 0 Then
                '    StrSSQLEP &= " and (SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
                '    StrSSQLEP &= " or SP_CODE_SQ_PK in " & GetCodeFromCollection(f3._CollectionIn) & ")"
                'Else
                StrSSQLEP &= " and SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
                'End If
            End If
        End If

        If ColTeneur.Count > 0 Then
            StrSSQLEP &= " Union Select DISTINCT SP_CODE_SQ_PK as code, SP_NOM as libelle ,0 as chk ,0 as chkFixe "
            StrSSQLEP &= " FROM THERIAQUE.COTEN_COMPO_TENEUR, THERIAQUE.SP_SPECIALITE "
            StrSSQLEP &= " where COTEN_SP_CODE_FK_PK = SP_CODE_SQ_PK "
            StrSSQLEP &= " and COTEN_CDF_TEN_CODE_FK_PK in " & GetCodeFromCollection(ColTeneur)
        End If

        f3._SSQL = StrSSQLEP
        f3._strTable = "SP_SPECIALITE"
        f3._Libelle = " Spécialité"
        f3.ShowDialog()
        If f3._Ok = False Then
            Exit Sub
        End If
        ColEP = f3._CollectionOut
        ColEPDelete = f3._CollectionOutDelete
        ColEPADD = f3._CollectionOutADD
        f3.Dispose()
        '----------------------------------------------------
        '----------------------------------------------------
        Load_On(Frm_Formulaire)
        For inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(inti).Table = eDeclinaison.CPH Then
                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

                For intk As Integer = 1 To ColCPHADD.Count
                    gvTemp.AddNewRow()
                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColCPHADD(intk))
                Next
                For intk As Integer = 1 To ColCPHDelete.Count
                    For intJ As Integer = 0 To gvTemp.RowCount - 1
                        If gvTemp.GetRowCellValue(intJ, CollectionContent(inti).Column) = ColCPHDelete(intk) Then
                            gvTemp.DeleteRow(intJ)
                            Exit For
                        End If
                    Next
                Next
            End If
            If CollectionContent(inti).Table = eDeclinaison.CCH Then
                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

                For intk As Integer = 1 To ColCCHADD.Count
                    gvTemp.AddNewRow()
                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColCCHADD(intk))
                Next
                For intk As Integer = 1 To ColCCHDelete.Count
                    For intJ As Integer = 0 To gvTemp.RowCount - 1
                        If gvTemp.GetRowCellValue(intJ, CollectionContent(inti).Column) = ColCCHDelete(intk) Then
                            gvTemp.DeleteRow(intJ)
                            Exit For
                        End If
                    Next
                Next
            End If
            If CollectionContent(inti).Table = eDeclinaison.SAC Then
                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

                For intk As Integer = 1 To ColSACADD.Count
                    gvTemp.AddNewRow()
                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColSACADD(intk))
                Next
                For intk As Integer = 1 To ColSACDelete.Count
                    For intJ As Integer = 0 To gvTemp.RowCount - 1
                        If gvTemp.GetRowCellValue(intJ, CollectionContent(inti).Column) = ColSACDelete(intk) Then
                            gvTemp.DeleteRow(intJ)
                            Exit For
                        End If
                    Next
                Next
            End If
            If CollectionContent(inti).Table = eDeclinaison.SP Then
                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

                For intk As Integer = 1 To ColEPADD.Count
                    gvTemp.AddNewRow()
                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColEPADD(intk))
                Next
                For intk As Integer = 1 To ColEPDelete.Count
                    For intJ As Integer = 0 To gvTemp.RowCount - 1
                        If gvTemp.GetRowCellValue(intJ, CollectionContent(inti).Column) = ColEPDelete(intk) Then
                            gvTemp.DeleteRow(intJ)
                            Exit For
                        End If
                    Next
                Next
            End If
        Next
        Load_Off(Frm_Formulaire)
        '----------------------------------------------------
        '----------------------------------------------------
    End Sub

#End Region

#Region " CCH "

    Public Sub DeclinaisonCCH_Globale(ByRef FrmFormulaire As Frm_Formulaire, ByVal txtTag As StructTxtProperty)
        DeclinaisonCPH_Globale(FrmFormulaire, txtTag)
    End Sub

    Public Sub DeclinaisonCCH_Classique(ByRef FrmFormulaire As Frm_Formulaire, ByVal txtTag As StructTxtProperty)
        Dim ColCCHADD As New Collection
        Dim ColCCHDelete As New Collection
        Dim ColCCH As New Collection

        Dim ColSACADD As New Collection
        Dim ColSACDelete As New Collection
        Dim ColSAC As New Collection

        Dim ColSAUADD As New Collection
        Dim ColSAUDelete As New Collection
        Dim ColSAU As New Collection

        Dim ColVoie As New Collection
        Dim ColTeneur As New Collection

        Dim ColEP As New Collection
        Dim ColEPDelete As New Collection
        Dim ColEPADD As New Collection

        Dim StrSSQLEP As String = strSSQL_SP_SPECIALITE_Distinct
        Dim StrVoie As String = strSSQL_CDF_CODIF_Distinct("18")

        Dim gvCCH As DevExpress.XtraGrid.Views.Grid.GridView
        Dim gvSAC As DevExpress.XtraGrid.Views.Grid.GridView
        Dim gvSAU As DevExpress.XtraGrid.Views.Grid.GridView

        Dim gvEP As DevExpress.XtraGrid.Views.Grid.GridView
        Dim gvTemp As DevExpress.XtraGrid.Views.Grid.GridView

        Dim CollectionContent As New System.Collections.Generic.List(Of StructGVTable)
        CollectionContent = txtTag.Declinaison.ContentIn
        ''---------------------------------------
        '' Affichage des Classe Chimique
        ''---------------------------------------
        Dim f2 As New Frm_Dictionnaire_Declinaison
        f2._strTable = "CCH_CLASSECHIMIQUE"
        f2._Libelle = "Classe chimique"
        Dim strSSQL_CCH_CLASSECHIMIQUE2 As String = ""
        strSSQL_CCH_CLASSECHIMIQUE2 &= " Select CCH_CODE_PK as code, CCH_NOM as libelle,0 as disable ,0 as chk ,0 as chkFixe From THERIAQUE.CCH_CLASSECHIMIQUE"
        strSSQL_CCH_CLASSECHIMIQUE2 &= " where CCH_CODE_PK  not in (select distinct isnull(CCH_CCH_CODE_FK,'') from THERIAQUE.CCH_CLASSECHIMIQUE) "
        strSSQL_CCH_CLASSECHIMIQUE2 &= " union"
        strSSQL_CCH_CLASSECHIMIQUE2 &= " Select CCH_CODE_PK as code, CCH_NOM as libelle, 1 as disable,0 as chk ,0 as chkFixe From THERIAQUE.CCH_CLASSECHIMIQUE"
        strSSQL_CCH_CLASSECHIMIQUE2 &= " where CCH_CODE_PK in (select distinct isnull(CCH_CCH_CODE_FK,'') from THERIAQUE.CCH_CLASSECHIMIQUE) "
        strSSQL_CCH_CLASSECHIMIQUE2 &= " order by CCH_CODE_PK "
        f2._SSQL = strSSQL_CCH_CLASSECHIMIQUE2
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.CCH Then
                gvCCH = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                Dim colTemp As New Collection
                colTemp.Add(cn.SQLText(gvCCH.GetFocusedRowCellValue(CollectionContent(Inti).Column)))
                f2._CollectionIn = colTemp
                Exit For
            End If
        Next
        f2.ShowDialog()
        If f2._Ok = False Then
            Exit Sub
        End If
        ColCCH = f2._CollectionOut
        ColCCHDelete = f2._CollectionOutDelete
        ColCCHADD = f2._CollectionOutADD
        f2.Dispose()
        Dim Fchoix As New Frm_Declinaison
        Fchoix.ShowDialog()
        If Fchoix._Ok = False Then Exit Sub
        If Fchoix.rgChoix.SelectedIndex = 0 Then
            ''---------------------------------------
            '' Affichage des substances actives
            ''---------------------------------------
            Dim f4 As New Frm_Dictionnaire_Declinaison
            f4._strTable = "SAC_SUBACTIVE"
            f4._Libelle = "Substances actives"
            Dim strSSQL_SAC_SUBACTIVE2 As String = ""
            strSSQL_SAC_SUBACTIVE2 = strSSQL_SAC_SUBACTIVE
            If ColCCH.Count >= 1 Then
                strSSQL_SAC_SUBACTIVE2 = " Select SAC_CODE_SQ_PK as code, SAC_NOM as libelle,0 as chk ,0 as chkFixe From THERIAQUE.SAC_SUBACTIVE"
                strSSQL_SAC_SUBACTIVE2 &= " ,THERIAQUE.SACCCH_SUBACT_CLASSECH"
                strSSQL_SAC_SUBACTIVE2 &= " where SACCCH_CCH_CODE_FK_PK  in " & GetCodeFromCollectionString(ColCCH)
                strSSQL_SAC_SUBACTIVE2 &= " and SACCCH_SAC_CODE_FK_PK = SAC_CODE_SQ_PK "
            End If
            f4._SSQL = strSSQL_SAC_SUBACTIVE2
            For Inti As Integer = 0 To CollectionContent.Count - 1
                If CollectionContent(Inti).Table = eDeclinaison.SAC Then
                    gvSAC = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                    'Dim colTemp As New Collection
                    'colTemp.Add(gvSAC.GetFocusedRowCellValue(CollectionContent(Inti).Column))
                    f4._CollectionIn = GetCodeFromGV(gvSAC, CollectionContent(Inti).Column)
                    'f4.txtSearch.Text = ClsSAC.GetLibelle(gvSAC.GetFocusedRowCellValue(CollectionContent(Inti).Column))
                    Exit For
                End If
            Next
            f4.ShowDialog()
            If f4._Ok = False Then
                Exit Sub
            End If
            ColSAC = f4._CollectionOut
            ColSACDelete = f4._CollectionOutDelete
            ColSACADD = f4._CollectionOutADD
            f4.Dispose()
        Else
            Dim f4 As New Frm_Dictionnaire_Declinaison
            f4._strTable = "SAU_SUBAUXILIAIRE"
            f4._Libelle = "Excipient"
            Dim strSSQL_SAU_SUBAUXILIAIRE2 As String = ""
            strSSQL_SAU_SUBAUXILIAIRE2 = strSSQL_SAU_SUBAUXILIAIRE
            If ColCCH.Count >= 1 Then
                strSSQL_SAU_SUBAUXILIAIRE2 = " Select SAU_CODE_SQ_PK as code, SAU_NOM as libelle,0 as chk ,0 as chkFixe From THERIAQUE.SAU_SUBAUXILIAIRE"
                strSSQL_SAU_SUBAUXILIAIRE2 &= " ,THERIAQUE.SAUCCH_SUBAUX_CLASSECH"
                strSSQL_SAU_SUBAUXILIAIRE2 &= " where SAUCCH_CCH_CODE_FK_PK  in " & GetCodeFromCollectionString(ColCCH)
                strSSQL_SAU_SUBAUXILIAIRE2 &= " and SAUCCH_SAU_CODE_FK_PK = SAU_CODE_SQ_PK "
            End If
            f4._SSQL = strSSQL_SAU_SUBAUXILIAIRE2
            For Inti As Integer = 0 To CollectionContent.Count - 1
                If CollectionContent(Inti).Table = eDeclinaison.SAU Then
                    gvSAU = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                    'Dim colTemp As New Collection
                    'colTemp.Add(gvSAU.GetFocusedRowCellValue(CollectionContent(Inti).Column))
                    f4._CollectionIn = GetCodeFromGV(gvSAU, CollectionContent(Inti).Column)
                    'f4.txtSearch.Text = ClsSAU.GetLibelle(gvSAU.GetFocusedRowCellValue(CollectionContent(Inti).Column))
                    Exit For
                End If
            Next
            f4.ShowDialog()
            If f4._Ok = False Then
                Exit Sub
            End If
            ColSAU = f4._CollectionOut
            ColSAUDelete = f4._CollectionOutDelete
            ColSAUADD = f4._CollectionOutADD
            f4.Dispose()
        End If
        ''---------------------------------------
        '' Affichage des Voies
        ''---------------------------------------
        Dim f8 As New Frm_Dictionnaire_Declinaison

        StrVoie = " Select Distinct CDF_CODE_PK as code, CDF_NOM as libelle, CDF_NUMERO_PK as num ,0 as chk From THERIAQUE.CDF_CODIF "
        StrVoie &= " ,THERIAQUE.SPVO_SPECIALITE_VOIE"
        StrVoie &= " where SPVO_CDF_VO_CODE_FK_PK = CDF_CODE_PK"
        StrVoie &= " and CDF_NUMERO_PK = '18'"
        If ColSAC.Count > 0 Then
            StrVoie &= " and SPVO_SP_CODE_FK_PK in "
            StrVoie &= " ("
            StrVoie &= " Select Distinct SP_CODE_SQ_PK as code From THERIAQUE.SP_SPECIALITE"
            StrVoie &= " ,THERIAQUE.COSAC_COMPO_SUBACT "
            StrVoie &= " where COSAC_SP_CODE_FK_PK = SP_CODE_SQ_PK "
            StrVoie &= " and COSAC_SAC_CODE_FK_PK in " & GetCodeFromCollection(ColSAC)
            StrVoie &= " )"
        End If
        f8._SSQL = StrVoie
        f8._strTable = "CDF_CODIF"
        f8._Libelle = " Voie "
        f8.ShowDialog()
        If f8._Ok = False Then
            Exit Sub
        End If
        ColVoie = f8._CollectionOut
        f8.Dispose()

        ''---------------------------------------
        '' Affichage des Episodes
        ''---------------------------------------
        Dim f3 As New Frm_Dictionnaire_Declinaison
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.SP Then
                gvEP = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                f3._CollectionIn = GetCodeFromGV(gvEP, CollectionContent(Inti).Column)
                Exit For
            End If
        Next
        If ColSAC.Count > 0 Then
            If ColVoie.Count > 0 Then
                StrSSQLEP &= " ,THERIAQUE.COSAC_COMPO_SUBACT, THERIAQUE.SPVO_SPECIALITE_VOIE "
                StrSSQLEP &= " where COSAC_SP_CODE_FK_PK = SP_CODE_SQ_PK "
                StrSSQLEP &= " and SPVO_SP_CODE_FK_PK = SP_CODE_SQ_PK "
                StrSSQLEP &= " and COSAC_SAC_CODE_FK_PK in " & GetCodeFromCollection(ColSAC)
                StrSSQLEP &= " and SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
                'If f3._CollectionIn.Count > 0 Then
                '    StrSSQLEP &= " Union Select Distinct SP_CODE_SQ_PK as code, SP_NOM as libelle ,0 as chk ,0 as chkFixe From THERIAQUE.SP_SPECIALITE "
                '    StrSSQLEP &= " where  SP_CODE_SQ_PK in " & GetCodeFromCollection(f3._CollectionIn)
                'End If
            Else
                StrSSQLEP &= " ,THERIAQUE.COSAC_COMPO_SUBACT "
                StrSSQLEP &= " where COSAC_SP_CODE_FK_PK = SP_CODE_SQ_PK "
                StrSSQLEP &= " and COSAC_SAC_CODE_FK_PK in " & GetCodeFromCollection(ColSAC)
                'If f3._CollectionIn.Count > 0 Then
                '    StrSSQLEP &= " Union Select Distinct SP_CODE_SQ_PK as code, SP_NOM as libelle ,0 as chk,0 as chkFixe From THERIAQUE.SP_SPECIALITE "
                '    StrSSQLEP &= " where  SP_CODE_SQ_PK in " & GetCodeFromCollection(f3._CollectionIn)
                'End If
            End If
        Else
            If ColVoie.Count > 0 Then
                StrSSQLEP &= ", THERIAQUE.SPVO_SPECIALITE_VOIE "
                StrSSQLEP &= " where SPVO_SP_CODE_FK_PK = SP_CODE_SQ_PK"
                'If f3._CollectionIn.Count > 0 Then
                '    StrSSQLEP &= " and (SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
                '    StrSSQLEP &= " or SP_CODE_SQ_PK in " & GetCodeFromCollection(f3._CollectionIn) & ")"
                'Else
                StrSSQLEP &= " and SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
                StrSSQLEP &= " and SPVO_SP_CODE_FK_PK = SP_CODE_SQ_PK "
                'End If
            End If
        End If

        If ColTeneur.Count > 0 Then
            StrSSQLEP &= " Union Select DISTINCT SP_CODE_SQ_PK as code, SP_NOM as libelle ,0 as chk ,0 as chkFixe "
            StrSSQLEP &= " FROM THERIAQUE.COTEN_COMPO_TENEUR, THERIAQUE.SP_SPECIALITE "
            StrSSQLEP &= " where COTEN_SP_CODE_FK_PK = SP_CODE_SQ_PK "
            StrSSQLEP &= " and COTEN_CDF_TEN_CODE_FK_PK in " & GetCodeFromCollection(ColTeneur)
        End If

        f3._SSQL = StrSSQLEP
        f3._strTable = "SP_SPECIALITE"
        f3._Libelle = " Spécialité"
        f3.ShowDialog()
        If f3._Ok = False Then
            Exit Sub
        End If
        Load_On(Frm_Formulaire)
        ColEP = f3._CollectionOut
        ColEPDelete = f3._CollectionOutDelete
        ColEPADD = f3._CollectionOutADD
        f3.Dispose()
        '----------------------------------------------------
        '----------------------------------------------------
        For inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(inti).Table = eDeclinaison.CCH Then
                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

                For intk As Integer = 1 To ColCCHADD.Count
                    gvTemp.AddNewRow()
                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColCCHADD(intk))
                Next
                For intk As Integer = 1 To ColCCHDelete.Count
                    For intJ As Integer = 0 To gvTemp.RowCount - 1
                        If gvTemp.GetRowCellValue(intJ, CollectionContent(inti).Column) = ColCCHDelete(intk) Then
                            gvTemp.DeleteRow(intJ)
                            Exit For
                        End If
                    Next
                Next
            End If
            If CollectionContent(inti).Table = eDeclinaison.SAC Then
                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

                For intk As Integer = 1 To ColSACADD.Count
                    gvTemp.AddNewRow()
                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColSACADD(intk))
                Next
                For intk As Integer = 1 To ColSACDelete.Count
                    For intJ As Integer = 0 To gvTemp.RowCount - 1
                        If gvTemp.GetRowCellValue(intJ, CollectionContent(inti).Column) = ColSACDelete(intk) Then
                            gvTemp.DeleteRow(intJ)
                            Exit For
                        End If
                    Next
                Next
            End If
            If CollectionContent(inti).Table = eDeclinaison.SP Then
                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

                For intk As Integer = 1 To ColEPADD.Count
                    gvTemp.AddNewRow()
                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColEPADD(intk))
                Next
                For intk As Integer = 1 To ColEPDelete.Count
                    For intJ As Integer = 0 To gvTemp.RowCount - 1
                        If gvTemp.GetRowCellValue(intJ, CollectionContent(inti).Column) = ColEPDelete(intk) Then
                            gvTemp.DeleteRow(intJ)
                            Exit For
                        End If
                    Next
                Next
            End If
        Next
        '----------------------------------------------------
        '----------------------------------------------------
        Load_Off(Frm_Formulaire)
    End Sub

#End Region

#Region " PR "

    Public Sub DeclinaisonPR_Globale(ByRef FrmFormulaire As Frm_Formulaire, ByVal txtTag As StructTxtProperty)

    End Sub

    Public Sub DeclinaisonPR_Classique(ByRef FrmFormulaire As Frm_Formulaire, ByVal txtTag As StructTxtProperty)
        Dim ColPRADD As New Collection
        Dim ColPRDelete As New Collection
        Dim ColPR As New Collection

        Dim ColEP As New Collection
        Dim ColEPDelete As New Collection
        Dim ColEPADD As New Collection

        Dim StrSSQLEP As String = strSSQL_SP_SPECIALITE_Distinct

        Dim gvPR As DevExpress.XtraGrid.Views.Grid.GridView
        Dim gvEP As DevExpress.XtraGrid.Views.Grid.GridView
        Dim gvTemp As DevExpress.XtraGrid.Views.Grid.GridView

        Dim CollectionContent As New System.Collections.Generic.List(Of StructGVTable)
        CollectionContent = txtTag.Declinaison.ContentIn
        ''---------------------------------------
        '' Affichage des Classe Chimique
        ''---------------------------------------
        Dim f2 As New Frm_Dictionnaire_Declinaison
        f2._strTable = "PR_PRODUIT"
        f2._Libelle = "Produit"
        Dim strSSQL_PR_PRODUIT As String = ""
        strSSQL_PR_PRODUIT &= " Select PR_CODE_SQ_PK as code, PR_NOM as libelle,0 as disable ,0 as chk ,0 as chkFixe "
        strSSQL_PR_PRODUIT &= " From THERIAQUE.PR_PRODUIT "
        f2._SSQL = strSSQL_PR_PRODUIT
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.PR Then
                gvPR = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                If gvPR.GetFocusedRowCellValue(CollectionContent(Inti).Column) IsNot Nothing Then
                    Dim colTemp As New Collection
                    colTemp.Add(cn.SQLText(gvPR.GetFocusedRowCellValue(CollectionContent(Inti).Column)))
                    f2._CollectionIn = colTemp
                    f2.txtSearch.Text = ClsPRE.GetLibelle(gvPR.GetFocusedRowCellValue(CollectionContent(Inti).Column))
                    Exit For
                End If
            End If
        Next
        f2.ShowDialog()
        If f2._Ok = False Then
            Exit Sub
        End If
        ColPR = f2._CollectionOut
        ColPRDelete = f2._CollectionOutDelete
        ColPRADD = f2._CollectionOutADD
        f2.Dispose()

        ''---------------------------------------
        '' Affichage des Episodes
        ''---------------------------------------
        Dim f3 As New Frm_Dictionnaire_Declinaison
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.SP Then
                gvEP = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                f3._CollectionIn = GetCodeFromGV(gvEP, CollectionContent(Inti).Column)
                Exit For
            End If
        Next
        If ColPR.Count > 0 Then
            StrSSQLEP &= " where SP_PR_CODE_FK in" & GetCodeFromCollection(ColPR)
        End If
        f3._SSQL = StrSSQLEP
        f3._strTable = "SP_SPECIALITE"
        f3._Libelle = " Spécialité"
        f3.ShowDialog()
        If f3._Ok = False Then
            Exit Sub
        End If
        ColEP = f3._CollectionOut
        ColEPDelete = f3._CollectionOutDelete
        ColEPADD = f3._CollectionOutADD
        f3.Dispose()
        '----------------------------------------------------
        '----------------------------------------------------
        For inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(inti).Table = eDeclinaison.PR Then
                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

                For intk As Integer = 1 To ColPRADD.Count
                    gvTemp.AddNewRow()
                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColPRADD(intk))
                Next
                For intk As Integer = 1 To ColPRDelete.Count
                    For intJ As Integer = 0 To gvTemp.RowCount - 1
                        If gvTemp.GetRowCellValue(intJ, CollectionContent(inti).Column) = ColPRDelete(intk) Then
                            gvTemp.DeleteRow(intJ)
                            Exit For
                        End If
                    Next
                Next
            End If

            If CollectionContent(inti).Table = eDeclinaison.SP Then
                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

                For intk As Integer = 1 To ColEPADD.Count
                    gvTemp.AddNewRow()
                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColEPADD(intk))
                Next
                For intk As Integer = 1 To ColEPDelete.Count
                    For intJ As Integer = 0 To gvTemp.RowCount - 1
                        If gvTemp.GetRowCellValue(intJ, CollectionContent(inti).Column) = ColEPDelete(intk) Then
                            gvTemp.DeleteRow(intJ)
                            Exit For
                        End If
                    Next
                Next
            End If
        Next
        '----------------------------------------------------
        '----------------------------------------------------
    End Sub

#End Region

    '#Region " ATC "

    '    Public Sub DeclinaisonATC_Classique(ByRef FrmFormulaire As Frm_Formulaire, ByVal txtTag As StructTxtProperty)
    '        Dim ColPRADD As New Collection
    '        Dim ColPRDelete As New Collection
    '        Dim ColPR As New Collection

    '        Dim ColEP As New Collection
    '        Dim ColEPDelete As New Collection
    '        Dim ColEPADD As New Collection

    '        Dim StrSSQLEP As String = strSSQL_SP_SPECIALITE_Distinct

    '        Dim gvPR As DevExpress.XtraGrid.Views.Grid.GridView
    '        Dim gvEP As DevExpress.XtraGrid.Views.Grid.GridView
    '        Dim gvTemp As DevExpress.XtraGrid.Views.Grid.GridView

    '        Dim CollectionContent As New System.Collections.Generic.List(Of StructGVTable)
    '        CollectionContent = txtTag.Declinaison.ContentIn
    '        ''---------------------------------------
    '        '' Affichage des Classe Chimique
    '        ''---------------------------------------
    '        Dim f2 As New Frm_Dictionnaire_Declinaison
    '        f2._strTable = "PR_PRODUIT"
    '        f2._Libelle = "Produit"
    '        Dim strSSQL_PR_PRODUIT As String = ""
    '        strSSQL_PR_PRODUIT &= " Select PR_CODE_SQ_PK as code, PR_NOM as libelle,0 as disable ,0 as chk ,0 as chkFixe "
    '        strSSQL_PR_PRODUIT &= " From THERIAQUE.PR_PRODUIT "
    '        f2._SSQL = strSSQL_PR_PRODUIT
    '        For Inti As Integer = 0 To CollectionContent.Count - 1
    '            If CollectionContent(Inti).Table = eDeclinaison.PR Then
    '                gvPR = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
    '                If gvPR.GetFocusedRowCellValue(CollectionContent(Inti).Column) IsNot Nothing Then
    '                    Dim colTemp As New Collection
    '                    colTemp.Add(cn.SQLText(gvPR.GetFocusedRowCellValue(CollectionContent(Inti).Column)))
    '                    f2._CollectionIn = colTemp
    '                    f2.txtSearch.Text = ClsPRE.GetLibelle(gvPR.GetFocusedRowCellValue(CollectionContent(Inti).Column))
    '                    Exit For
    '                End If
    '            End If
    '        Next
    '        f2.ShowDialog()
    '        If f2._Ok = False Then
    '            Exit Sub
    '        End If
    '        ColPR = f2._CollectionOut
    '        ColPRDelete = f2._CollectionOutDelete
    '        ColPRADD = f2._CollectionOutADD
    '        f2.Dispose()

    '        ''---------------------------------------
    '        '' Affichage des Episodes
    '        ''---------------------------------------
    '        Dim f3 As New Frm_Dictionnaire_Declinaison
    '        For Inti As Integer = 0 To CollectionContent.Count - 1
    '            If CollectionContent(Inti).Table = eDeclinaison.SP Then
    '                gvEP = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
    '                f3._CollectionIn = GetCodeFromGV(gvEP, CollectionContent(Inti).Column)
    '                Exit For
    '            End If
    '        Next
    '        If ColPR.Count > 0 Then
    '            StrSSQLEP &= " where SP_PR_CODE_FK in" & GetCodeFromCollection(ColPR)
    '        End If
    '        f3._SSQL = StrSSQLEP
    '        f3._strTable = "SP_SPECIALITE"
    '        f3._Libelle = " Spécialité"
    '        f3.ShowDialog()
    '        If f3._Ok = False Then
    '            Exit Sub
    '        End If
    '        ColEP = f3._CollectionOut
    '        ColEPDelete = f3._CollectionOutDelete
    '        ColEPADD = f3._CollectionOutADD
    '        f3.Dispose()
    '        '----------------------------------------------------
    '        '----------------------------------------------------
    '        For inti As Integer = 0 To CollectionContent.Count - 1
    '            If CollectionContent(inti).Table = eDeclinaison.PR Then
    '                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

    '                For intk As Integer = 1 To ColPRADD.Count
    '                    gvTemp.AddNewRow()
    '                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColPRADD(intk))
    '                Next
    '                For intk As Integer = 1 To ColPRDelete.Count
    '                    For intJ As Integer = 0 To gvTemp.RowCount - 1
    '                        If gvTemp.GetRowCellValue(intJ, CollectionContent(inti).Column) = ColPRDelete(intk) Then
    '                            gvTemp.DeleteRow(intJ)
    '                            Exit For
    '                        End If
    '                    Next
    '                Next
    '            End If

    '            If CollectionContent(inti).Table = eDeclinaison.SP Then
    '                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

    '                For intk As Integer = 1 To ColEPADD.Count
    '                    gvTemp.AddNewRow()
    '                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColEPADD(intk))
    '                Next
    '                For intk As Integer = 1 To ColEPDelete.Count
    '                    For intJ As Integer = 0 To gvTemp.RowCount - 1
    '                        If gvTemp.GetRowCellValue(intJ, CollectionContent(inti).Column) = ColEPDelete(intk) Then
    '                            gvTemp.DeleteRow(intJ)
    '                            Exit For
    '                        End If
    '                    Next
    '                Next
    '            End If
    '        Next
    '        '----------------------------------------------------
    '        '----------------------------------------------------
    '    End Sub

    '#End Region


#Region "SP"

    Public Sub DeclinaisonSP_Globale(ByRef FrmFormulaire As Frm_Formulaire, ByVal txtTag As StructTxtProperty)
        Dim ColCPHADD As New Collection
        Dim ColCPHDelete As New Collection
        Dim ColCPH As New Collection

        Dim ColCCHADD As New Collection
        Dim ColCCHDelete As New Collection
        Dim ColCCH As New Collection

        Dim ColATCADD As New Collection
        Dim ColATCDelete As New Collection
        Dim ColATC As New Collection

        Dim ColSACADD As New Collection
        Dim ColSACDelete As New Collection
        Dim ColSAC As New Collection

        Dim ColVoie As New Collection
        Dim ColTeneur As New Collection

        Dim ColEP As New Collection
        Dim ColEPDelete As New Collection
        Dim ColEPADD As New Collection

        Dim StrSSQLEP As String = strSSQL_SP_SPECIALITE_Distinct
        Dim StrSSQLEP_Depart As String = StrSSQLEP
        Dim StrVoie As String = strSSQL_CDF_CODIF_Distinct("18")

        Dim gvCPH As DevExpress.XtraGrid.Views.Grid.GridView
        Dim gvCCH As DevExpress.XtraGrid.Views.Grid.GridView
        Dim gvATC As DevExpress.XtraGrid.Views.Grid.GridView
        Dim gvSAC As DevExpress.XtraGrid.Views.Grid.GridView

        Dim gvEP As DevExpress.XtraGrid.Views.Grid.GridView
        Dim gvTemp As DevExpress.XtraGrid.Views.Grid.GridView

        Dim CollectionContent As New System.Collections.Generic.List(Of StructGVTable)
        CollectionContent = txtTag.Declinaison.ContentIn
        ''---------------------------------------
        '' Affichage des Classe pharmaco-thérapeutique
        ''---------------------------------------
        Dim f As New Frm_Dictionnaire_Declinaison
        f._strTable = "CPH_CLASSEPHARMTHER"
        f._Libelle = "Classe pharmaco-thérapeutique"
        Dim strSSQL_CPH_CLASSEPHARMTHER2 As String = ""
        strSSQL_CPH_CLASSEPHARMTHER2 &= " Select CPH_CODE_PK as code, CPH_NOM as libelle,0 as disable ,0 as chk ,0 as chkFixe From THERIAQUE.CPH_CLASSEPHARMTHER"
        strSSQL_CPH_CLASSEPHARMTHER2 &= " where CPH_CODE_PK  not in (select distinct isnull(CPH_CPH_CODE_FK,'') from THERIAQUE.CPH_CLASSEPHARMTHER) "
        strSSQL_CPH_CLASSEPHARMTHER2 &= " union"
        strSSQL_CPH_CLASSEPHARMTHER2 &= " Select CPH_CODE_PK as code, CPH_NOM as libelle, 1 as disable,0 as chk ,0 as chkFixe From THERIAQUE.CPH_CLASSEPHARMTHER"
        strSSQL_CPH_CLASSEPHARMTHER2 &= " where CPH_CODE_PK in (select distinct isnull(CPH_CPH_CODE_FK,'') from THERIAQUE.CPH_CLASSEPHARMTHER) "
        strSSQL_CPH_CLASSEPHARMTHER2 &= " order by CPH_CODE_PK "
        f._SSQL = strSSQL_CPH_CLASSEPHARMTHER2
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.CPH Then
                gvCPH = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                f._CollectionIn = GetCodeStringFromGV(gvCPH, CollectionContent(Inti).Column)
                Exit For
            End If
        Next
        f.ShowDialog()
        If f._Ok = False Then
            Exit Sub
        End If
        ColCPH = f._CollectionOut
        ColCPHDelete = f._CollectionOutDelete
        ColCPHADD = f._CollectionOutADD
        f.Dispose()


        ''---------------------------------------
        '' Affichage des Classe ATC
        ''---------------------------------------
        Dim f7 As New Frm_Dictionnaire_Declinaison
        f7._strTable = "CATC_CLASSEATC"
        f7._Libelle = "Classe ATC"
        Dim strSSQL_CCH_CLASSEATC As String = ""
        strSSQL_CCH_CLASSEATC &= " Select CATC_CODE_PK as code, CATC_NOMF as libelle,0 as disable ,0 as chk ,0 as chkFixe From THERIAQUE.CATC_CLASSEATC"
        strSSQL_CCH_CLASSEATC &= " where CATC_CODE_PK  not in (select distinct isnull(CATC_CATC_CODE_FK,'') from THERIAQUE.CATC_CLASSEATC) "
        strSSQL_CCH_CLASSEATC &= " union"
        strSSQL_CCH_CLASSEATC &= " Select CATC_CODE_PK as code, CATC_NOMF as libelle, 1 as disable,0 as chk ,0 as chkFixe From THERIAQUE.CATC_CLASSEATC"
        strSSQL_CCH_CLASSEATC &= " where CATC_CODE_PK in (select distinct isnull(CATC_CATC_CODE_FK,'') from THERIAQUE.CATC_CLASSEATC) "
        strSSQL_CCH_CLASSEATC &= " order by CATC_CODE_PK "
        f7._SSQL = strSSQL_CCH_CLASSEATC
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.SP Then
                gvATC = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                f7._CollectionIn = GetCodeStringFromGV(gvATC, CollectionContent(Inti).Column)
                Exit For
            End If
        Next
        'If gvCCH IsNot Nothing Then
        f7.ShowDialog()
        If f7._Ok = False Then
            Exit Sub
        End If
        ColATC = f7._CollectionOut
        ColATCDelete = f7._CollectionOutDelete
        ColATCADD = f7._CollectionOutADD
        f7.Dispose()

        ''---------------------------------------
        '' Affichage des Classe Chimique
        ''---------------------------------------
        Dim f2 As New Frm_Dictionnaire_Declinaison
        f2._strTable = "CCH_CLASSECHIMIQUE"
        f2._Libelle = "Classe chimique"
        Dim strSSQL_CCH_CLASSECHIMIQUE2 As String = ""
        strSSQL_CCH_CLASSECHIMIQUE2 &= " Select CCH_CODE_PK as code, CCH_NOM as libelle,0 as disable ,0 as chk ,0 as chkFixe From THERIAQUE.CCH_CLASSECHIMIQUE"
        strSSQL_CCH_CLASSECHIMIQUE2 &= " where CCH_CODE_PK  not in (select distinct isnull(CCH_CCH_CODE_FK,'') from THERIAQUE.CCH_CLASSECHIMIQUE) "
        strSSQL_CCH_CLASSECHIMIQUE2 &= " union"
        strSSQL_CCH_CLASSECHIMIQUE2 &= " Select CCH_CODE_PK as code, CCH_NOM as libelle, 1 as disable,0 as chk ,0 as chkFixe From THERIAQUE.CCH_CLASSECHIMIQUE"
        strSSQL_CCH_CLASSECHIMIQUE2 &= " where CCH_CODE_PK in (select distinct isnull(CCH_CCH_CODE_FK,'') from THERIAQUE.CCH_CLASSECHIMIQUE) "
        strSSQL_CCH_CLASSECHIMIQUE2 &= " order by CCH_CODE_PK "
        f2._SSQL = strSSQL_CCH_CLASSECHIMIQUE2
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.CCH Then
                gvCCH = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                f2._CollectionIn = GetCodeStringFromGV(gvCCH, CollectionContent(Inti).Column)
                Exit For
            End If
        Next
        'If gvCCH IsNot Nothing Then
        f2.ShowDialog()
        If f2._Ok = False Then
            Exit Sub
        End If
        ColCCH = f2._CollectionOut
        ColCCHDelete = f2._CollectionOutDelete
        ColCCHADD = f2._CollectionOutADD
        f2.Dispose()
        'End If
        ''---------------------------------------
        '' Affichage des substances actives
        ''---------------------------------------
        Dim f4 As New Frm_Dictionnaire_Declinaison
        f4._strTable = "SAC_SUBACTIVE"
        f4._Libelle = "Substances actives"
        Dim strSSQL_SAC_SUBACTIVE2 As String = ""
        strSSQL_SAC_SUBACTIVE2 = strSSQL_SAC_SUBACTIVE
        If ColCPH.Count > 0 Then
            If ColCCH.Count > 0 Then
                strSSQL_SAC_SUBACTIVE2 = " Select SAC_CODE_SQ_PK as code, SAC_NOM as libelle,0 as chk ,0 as chkFixe From THERIAQUE.SAC_SUBACTIVE"
                strSSQL_SAC_SUBACTIVE2 &= " ,THERIAQUE.SACCCH_SUBACT_CLASSECH"
                strSSQL_SAC_SUBACTIVE2 &= " where SACCCH_CCH_CODE_FK_PK  in " & GetCodeFromCollectionString(ColCCH)
                strSSQL_SAC_SUBACTIVE2 &= " and SACCCH_SAC_CODE_FK_PK = SAC_CODE_SQ_PK "
                strSSQL_SAC_SUBACTIVE2 &= " UNION "
                strSSQL_SAC_SUBACTIVE2 &= " Select SAC_CODE_SQ_PK as code, SAC_NOM as libelle,0 as chk ,0 as chkFixe From THERIAQUE.SAC_SUBACTIVE"
                strSSQL_SAC_SUBACTIVE2 &= " ,THERIAQUE.SACCPH_SUBACT_CLASSEPH"
                strSSQL_SAC_SUBACTIVE2 &= " where SACCPH_CPH_CODE_FK_PK  in " & GetCodeFromCollectionString(ColCPH)
                strSSQL_SAC_SUBACTIVE2 &= " and SACCPH_SAC_CODE_FK_PK = SAC_CODE_SQ_PK "
            Else
                strSSQL_SAC_SUBACTIVE2 = " Select SAC_CODE_SQ_PK as code, SAC_NOM as libelle,0 as chk ,0 as chkFixe From THERIAQUE.SAC_SUBACTIVE"
                strSSQL_SAC_SUBACTIVE2 &= " ,THERIAQUE.SACCPH_SUBACT_CLASSEPH"
                strSSQL_SAC_SUBACTIVE2 &= " where SACCPH_CPH_CODE_FK_PK  in " & GetCodeFromCollectionString(ColCPH)
                strSSQL_SAC_SUBACTIVE2 &= " and SACCPH_SAC_CODE_FK_PK = SAC_CODE_SQ_PK "
            End If
        Else
            If ColCCH.Count > 0 Then
                strSSQL_SAC_SUBACTIVE2 = " Select SAC_CODE_SQ_PK as code, SAC_NOM as libelle,0 as chk ,0 as chkFixe From THERIAQUE.SAC_SUBACTIVE"
                strSSQL_SAC_SUBACTIVE2 &= " ,THERIAQUE.SACCCH_SUBACT_CLASSECH"
                strSSQL_SAC_SUBACTIVE2 &= " where SACCCH_CCH_CODE_FK_PK  in " & GetCodeFromCollectionString(ColCCH)
                strSSQL_SAC_SUBACTIVE2 &= " and SACCCH_SAC_CODE_FK_PK = SAC_CODE_SQ_PK "
            End If
        End If
        f4._SSQL = strSSQL_SAC_SUBACTIVE2

        'If ColCPH.Count > 0 Then
        '    If ColCCH.Count > 0 Then
        '        strSSQL_SAC_SUBACTIVE2 = " Select distinct SAC_CODE_SQ_PK as code, SAC_NOM as libelle,0 as chk ,0 as chkFixe From THERIAQUE.SAC_SUBACTIVE"
        '        strSSQL_SAC_SUBACTIVE2 &= " ,THERIAQUE.SACCCH_SUBACT_CLASSECH"
        '        strSSQL_SAC_SUBACTIVE2 &= " ,THERIAQUE.SACCPH_SUBACT_CLASSEPH"
        '        strSSQL_SAC_SUBACTIVE2 &= " where SACCPH_CPH_CODE_FK_PK  in " & GetCodeFromCollection(ColCPH)
        '        strSSQL_SAC_SUBACTIVE2 &= " where SACCCH_CCH_CODE_FK_PK  in " & GetCodeFromCollection(ColCCH)
        '        strSSQL_SAC_SUBACTIVE2 &= " and SACCCH_SAC_CODE_FK_PK = SAC_CODE_SQ_PK "
        '        strSSQL_SAC_SUBACTIVE2 &= " and SACCPH_SAC_CODE_FK_PK = SAC_CODE_SQ_PK "
        '    Else
        '        strSSQL_SAC_SUBACTIVE2 = " Select SAC_CODE_SQ_PK as code, SAC_NOM as libelle,0 as chk ,0 as chkFixe From THERIAQUE.SAC_SUBACTIVE"
        '        strSSQL_SAC_SUBACTIVE2 &= " ,THERIAQUE.SACCCH_SUBACT_CLASSECH"
        '        strSSQL_SAC_SUBACTIVE2 &= " where SACCPH_SAC_CODE_FK_PK  in " & GetCodeFromCollection(ColCPH)
        '        strSSQL_SAC_SUBACTIVE2 &= " and SACCPH_SAC_CODE_FK_PK = SAC_CODE_SQ_PK "
        '    End If
        'Else
        '    If ColCCH.Count > 0 Then
        '        strSSQL_SAC_SUBACTIVE2 = " Select SAC_CODE_SQ_PK as code, SAC_NOM as libelle,0 as chk ,0 as chkFixe From THERIAQUE.SAC_SUBACTIVE"
        '        strSSQL_SAC_SUBACTIVE2 &= " ,THERIAQUE.SACCCH_SUBACT_CLASSECH"
        '        strSSQL_SAC_SUBACTIVE2 &= " where SACCCH_CCH_CODE_FK_PK  in " & GetCodeFromCollection(ColCCH)
        '        strSSQL_SAC_SUBACTIVE2 &= " and SACCCH_SAC_CODE_FK_PK = SAC_CODE_SQ_PK "
        '    End If
        'End If
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.SAC Then
                gvSAC = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                f4._CollectionIn = GetCodeFromGV(gvSAC, CollectionContent(Inti).Column)
                'strSSQL_SAC_SUBACTIVE2 &= " Union"
                'strSSQL_SAC_SUBACTIVE2 &= " Select SAC_CODE_SQ_PK as code, SAC_NOM as libelle,0 as chk ,0 as chkFixe From THERIAQUE.SAC_SUBACTIVE"
                'strSSQL_SAC_SUBACTIVE2 &= " where SAC_CODE_SQ_PK in " & GetCodeFromCollection(GetCodeFromGV(gvSAC, CollectionContent(Inti).Column))
                'f4._SSQL = strSSQL_SAC_SUBACTIVE
                Exit For
            End If
        Next
        f4.ShowDialog()
        If f4._Ok = False Then
            Exit Sub
        End If
        ColSAC = f4._CollectionOut
        ColSACDelete = f4._CollectionOutDelete
        ColSACADD = f4._CollectionOutADD
        f4.Dispose()


        ''---------------------------------------
        '' Affichage des excipients
        ''---------------------------------------
        Dim gvSAU As DevExpress.XtraGrid.Views.Grid.GridView
        Dim ColSAUADD As New Collection
        Dim ColSAUDelete As New Collection
        Dim ColSAU As New Collection
        Dim f6 As New Frm_Dictionnaire_Declinaison
        f6._strTable = "SAU_SUBAUXILIAIRE"
        f6._Libelle = "Excipient"
        Dim strSSQL_SAU_SUBAUXILIAIRE2 As String = ""
        strSSQL_SAU_SUBAUXILIAIRE2 = strSSQL_SAU_SUBAUXILIAIRE
        If ColCCH.Count >= 1 Then
            strSSQL_SAU_SUBAUXILIAIRE2 = " Select SAU_CODE_SQ_PK as code, SAU_NOM as libelle,0 as chk ,0 as chkFixe From THERIAQUE.SAU_SUBAUXILIAIRE"
            strSSQL_SAU_SUBAUXILIAIRE2 &= " ,THERIAQUE.SAUCCH_SUBAUX_CLASSECH"
            strSSQL_SAU_SUBAUXILIAIRE2 &= " where SAUCCH_CCH_CODE_FK_PK  in " & GetCodeFromCollectionString(ColCCH)
            strSSQL_SAU_SUBAUXILIAIRE2 &= " and SAUCCH_SAU_CODE_FK_PK = SAU_CODE_SQ_PK "
        End If
        f6._SSQL = strSSQL_SAU_SUBAUXILIAIRE2
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.SAU Then
                gvSAU = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                'Dim colTemp As New Collection
                'colTemp.Add(gvSAU.GetFocusedRowCellValue(CollectionContent(Inti).Column))
                f6._CollectionIn = GetCodeFromGV(gvSAU, CollectionContent(Inti).Column)
                'f6.txtSearch.Text = ClsSAU.GetLibelle(gvSAU.GetFocusedRowCellValue(CollectionContent(Inti).Column))
                Exit For
            End If
        Next
        f6.ShowDialog()
        If f6._Ok = False Then
            Exit Sub
        End If
        ColSAU = f6._CollectionOut
        ColSAUDelete = f6._CollectionOutDelete
        ColSAUADD = f6._CollectionOutADD
        f6.Dispose()

        ''---------------------------------------
        '' Affichage des produits
        ''---------------------------------------
        Dim ColPRADD As New Collection
        Dim ColPRDelete As New Collection
        Dim ColPR As New Collection
        Dim gvPR As DevExpress.XtraGrid.Views.Grid.GridView

        Dim f5 As New Frm_Dictionnaire_Declinaison
        f5._strTable = "PR_PRODUIT"
        f5._Libelle = "Produit"
        Dim strSSQL_PR_PRODUIT As String = ""
        strSSQL_PR_PRODUIT &= " Select PR_CODE_SQ_PK as code, PR_NOM as libelle,0 as disable ,0 as chk ,0 as chkFixe "
        strSSQL_PR_PRODUIT &= " From THERIAQUE.PR_PRODUIT "
        f5._SSQL = strSSQL_PR_PRODUIT
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.PR Then
                gvPR = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                If gvPR.GetFocusedRowCellValue(CollectionContent(Inti).Column) IsNot Nothing Then
                    Dim colTemp As New Collection
                    colTemp.Add(cn.SQLText(gvPR.GetFocusedRowCellValue(CollectionContent(Inti).Column)))
                    f5._CollectionIn = colTemp
                    f5.txtSearch.Text = ClsPRE.GetLibelle(gvPR.GetFocusedRowCellValue(CollectionContent(Inti).Column))
                    Exit For
                End If
            End If
        Next
        f5.ShowDialog()
        If f5._Ok = False Then
            Exit Sub
        End If
        ColPR = f5._CollectionOut
        ColPRDelete = f5._CollectionOutDelete
        ColPRADD = f5._CollectionOutADD
        f5.Dispose()

        ' ''---------------------------------------
        ' '' Affichage des Voies
        ' ''---------------------------------------
        'Dim f8 As New Frm_Dictionnaire_Declinaison

        'StrVoie = " Select Distinct CDF_CODE_PK as code, CDF_NOM as libelle, CDF_NUMERO_PK as num ,0 as chk From THERIAQUE.CDF_CODIF "
        'StrVoie &= " ,THERIAQUE.SPVO_SPECIALITE_VOIE"
        'StrVoie &= " where SPVO_CDF_VO_CODE_FK_PK = CDF_CODE_PK"
        'StrVoie &= " and CDF_NUMERO_PK = '18'"
        'If ColSAC.Count > 0 Then
        '    StrVoie &= " and SPVO_SP_CODE_FK_PK in "
        '    StrVoie &= " ("
        '    StrVoie &= " Select Distinct SP_CODE_SQ_PK as code From THERIAQUE.SP_SPECIALITE"
        '    StrVoie &= " ,THERIAQUE.COSAC_COMPO_SUBACT "
        '    StrVoie &= " where COSAC_SP_CODE_FK_PK = SP_CODE_SQ_PK "
        '    StrVoie &= " and COSAC_SAC_CODE_FK_PK in " & GetCodeFromCollection(ColSAC)
        '    StrVoie &= " )"
        'End If
        'f8._SSQL = StrVoie
        'f8._strTable = "CDF_CODIF"
        'f8._Libelle = " Voie "
        'f8.ShowDialog()
        'If f8._Ok = False Then
        '    Exit Sub
        'End If
        'ColVoie = f8._CollectionOut
        'f8.Dispose()



        ''---------------------------------------
        '' Affichage des Episodes
        ''---------------------------------------


        Dim f3 As New Frm_Dictionnaire_Declinaison
        For Inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(Inti).Table = eDeclinaison.SP Then
                gvEP = CType(FrmFormulaire.Controls.Find(CollectionContent(Inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView
                f3._CollectionIn = GetCodeFromGV(gvEP, CollectionContent(Inti).Column)
                Exit For
            End If
        Next
        If ColSAC.Count > 0 Then
            If ColVoie.Count > 0 Then
                StrSSQLEP &= " ,THERIAQUE.COSAC_COMPO_SUBACT, THERIAQUE.SPVO_SPECIALITE_VOIE "
                StrSSQLEP &= " where COSAC_SP_CODE_FK_PK = SP_CODE_SQ_PK "
                StrSSQLEP &= " and SPVO_SP_CODE_FK_PK = SP_CODE_SQ_PK "
                StrSSQLEP &= " and COSAC_SAC_CODE_FK_PK in " & GetCodeFromCollection(ColSAC)
                StrSSQLEP &= " and SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
                If f3._CollectionIn.Count > 0 Then
                    If ColPR.Count > 0 Then
                        StrSSQLEP &= " and SP_PR_CODE_FK in" & GetCodeFromCollection(ColPR)
                    End If

                    If (ColSAU.Count > 0) Then
                        StrSSQLEP &= " and Exists(select null from THERIAQUE.COSAU_COMPO_SUBAUX ex "
                        StrSSQLEP &= " where ex.COSAU_SP_CODE_FK_PK = SP_CODE_SQ_PK and ex.COSAU_SAU_CODE_FK_PK in " & GetCodeFromCollection(ColSAU) & ")"
                    End If

                    If (ColATC.Count > 0) Then
                        StrSSQLEP &= " and SP_CATC_CODE_FK in" & GetCodeATCFromCollection(ColATC)
                    End If

                    StrSSQLEP &= " Union Select Distinct SP_CODE_SQ_PK as code, SP_NOM as libelle ,0 as chk ,0 as chkFixe From THERIAQUE.SP_SPECIALITE "
                    StrSSQLEP &= " where  SP_CODE_SQ_PK in " & GetCodeFromCollection(f3._CollectionIn)
                End If
            Else
                StrSSQLEP &= " ,THERIAQUE.COSAC_COMPO_SUBACT "
                StrSSQLEP &= " where COSAC_SP_CODE_FK_PK = SP_CODE_SQ_PK "
                StrSSQLEP &= " and COSAC_SAC_CODE_FK_PK in " & GetCodeFromCollection(ColSAC)
                If f3._CollectionIn.Count > 0 Then
                    If ColPR.Count > 0 Then
                        StrSSQLEP &= " and SP_PR_CODE_FK in" & GetCodeFromCollection(ColPR)
                    End If


                    If (ColSAU.Count > 0) Then
                        StrSSQLEP &= " and Exists(select null from THERIAQUE.COSAU_COMPO_SUBAUX ex "
                        StrSSQLEP &= " where ex.COSAU_SP_CODE_FK_PK = SP_CODE_SQ_PK and ex.COSAU_SAU_CODE_FK_PK in " & GetCodeFromCollection(ColSAU) & ")"
                    End If

                    If (ColATC.Count > 0) Then
                        StrSSQLEP &= " and SP_CATC_CODE_FK in" & GetCodeATCFromCollection(ColATC)
                    End If

                    StrSSQLEP &= " Union Select Distinct SP_CODE_SQ_PK as code, SP_NOM as libelle ,0 as chk,0 as chkFixe From THERIAQUE.SP_SPECIALITE "
                    StrSSQLEP &= " where  SP_CODE_SQ_PK in " & GetCodeFromCollection(f3._CollectionIn)
                End If
            End If
        Else
            If ColVoie.Count > 0 Then
                StrSSQLEP &= ", THERIAQUE.SPVO_SPECIALITE_VOIE "
                StrSSQLEP &= " where SPVO_SP_CODE_FK_PK = SP_CODE_SQ_PK"
                If f3._CollectionIn.Count > 0 Then
                    StrSSQLEP &= " and (SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie)
                    StrSSQLEP &= " or SP_CODE_SQ_PK in " & GetCodeFromCollection(f3._CollectionIn) & ")"
                Else
                    StrSSQLEP &= " and SPVO_CDF_VO_CODE_FK_PK in " & GetCodeFromCollection(ColVoie) 
                End If
            End If
        End If


        If ColTeneur.Count > 0 Then
            If ColPR.Count > 0 Then
                If (StrSSQLEP.Equals(StrSSQLEP_Depart)) Then
                    StrSSQLEP &= " where SP_PR_CODE_FK in" & GetCodeFromCollection(ColPR)
                Else
                    StrSSQLEP &= " and SP_PR_CODE_FK in" & GetCodeFromCollection(ColPR)
                End If
            End If

            If (ColSAU.Count > 0) Then
                If (StrSSQLEP.Equals(StrSSQLEP_Depart)) Then
                    StrSSQLEP &= " where "
                Else
                    StrSSQLEP &= " and "
                End If
                StrSSQLEP &= "  Exists(select null from THERIAQUE.COSAU_COMPO_SUBAUX ex "
                StrSSQLEP &= " where ex.COSAU_SP_CODE_FK_PK = SP_CODE_SQ_PK and ex.COSAU_SAU_CODE_FK_PK in " & GetCodeFromCollection(ColSAU) & ")"
            End If

            If (ColATC.Count > 0) Then
                If (StrSSQLEP.Equals(StrSSQLEP_Depart)) Then
                    StrSSQLEP &= " where "
                Else
                    StrSSQLEP &= " and "
                End If
                StrSSQLEP &= "  SP_CATC_CODE_FK in" & GetCodeATCFromCollection(ColATC)
            End If

            StrSSQLEP &= " Union Select DISTINCT SP_CODE_SQ_PK as code, SP_NOM as libelle ,0 as chk ,0 as chkFixe "
            StrSSQLEP &= " FROM THERIAQUE.COTEN_COMPO_TENEUR, THERIAQUE.SP_SPECIALITE "
            StrSSQLEP &= " where COTEN_SP_CODE_FK_PK = SP_CODE_SQ_PK "
            StrSSQLEP &= " and COTEN_CDF_TEN_CODE_FK_PK in " & GetCodeFromCollection(ColTeneur)
        End If


        If ColPR.Count > 0 Then
            If (StrSSQLEP.Equals(StrSSQLEP_Depart)) Then
                StrSSQLEP &= " where SP_PR_CODE_FK in" & GetCodeFromCollection(ColPR)
            Else
                StrSSQLEP &= " and SP_PR_CODE_FK in" & GetCodeFromCollection(ColPR)
            End If
        End If

        If (ColSAU.Count > 0) Then
            If (StrSSQLEP.Equals(StrSSQLEP_Depart)) Then
                StrSSQLEP &= " where "
            Else
                StrSSQLEP &= " and "
            End If
            StrSSQLEP &= "  Exists(select null from THERIAQUE.COSAU_COMPO_SUBAUX ex "
            StrSSQLEP &= " where ex.COSAU_SP_CODE_FK_PK = SP_CODE_SQ_PK and ex.COSAU_SAU_CODE_FK_PK in " & GetCodeFromCollection(ColSAU) & ")"
        End If

        If (ColATC.Count > 0) Then
            If (StrSSQLEP.Equals(StrSSQLEP_Depart)) Then
                StrSSQLEP &= " where "
            Else
                StrSSQLEP &= " and "
            End If
            StrSSQLEP &= "  SP_CATC_CODE_FK in" & GetCodeATCFromCollection(ColATC)
        End If

        f3._SSQL = StrSSQLEP
        f3._strTable = "SP_SPECIALITE"
        f3._Libelle = " Spécialité"
        f3.ShowDialog()
        If f3._Ok = False Then
            Exit Sub
        End If
        ColEP = f3._CollectionOut
        ColEPDelete = f3._CollectionOutDelete
        ColEPADD = f3._CollectionOutADD
        f3.Dispose()
        '----------------------------------------------------
        '----------------------------------------------------
        Load_On(Frm_Formulaire)
        For inti As Integer = 0 To CollectionContent.Count - 1
            If CollectionContent(inti).Table = eDeclinaison.CPH Then
                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

                For intk As Integer = 1 To ColCPHADD.Count
                    gvTemp.AddNewRow()
                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColCPHADD(intk))
                Next
                For intk As Integer = 1 To ColCPHDelete.Count
                    For intJ As Integer = 0 To gvTemp.RowCount - 1
                        If gvTemp.GetRowCellValue(intJ, CollectionContent(inti).Column) = ColCPHDelete(intk) Then
                            gvTemp.DeleteRow(intJ)
                            Exit For
                        End If
                    Next
                Next
            End If
            If CollectionContent(inti).Table = eDeclinaison.CCH Then
                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

                For intk As Integer = 1 To ColCCHADD.Count
                    gvTemp.AddNewRow()
                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColCCHADD(intk))
                Next
                For intk As Integer = 1 To ColCCHDelete.Count
                    For intJ As Integer = 0 To gvTemp.RowCount - 1
                        If gvTemp.GetRowCellValue(intJ, CollectionContent(inti).Column) = ColCCHDelete(intk) Then
                            gvTemp.DeleteRow(intJ)
                            Exit For
                        End If
                    Next
                Next
            End If
            If CollectionContent(inti).Table = eDeclinaison.SAC Then
                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

                For intk As Integer = 1 To ColSACADD.Count
                    gvTemp.AddNewRow()
                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColSACADD(intk))
                Next
                For intk As Integer = 1 To ColSACDelete.Count
                    For intJ As Integer = 0 To gvTemp.RowCount - 1
                        If gvTemp.GetRowCellValue(intJ, CollectionContent(inti).Column) = ColSACDelete(intk) Then
                            gvTemp.DeleteRow(intJ)
                            Exit For
                        End If
                    Next
                Next
            End If
            If CollectionContent(inti).Table = eDeclinaison.SP Then
                gvTemp = CType(FrmFormulaire.Controls.Find(CollectionContent(inti).gc, True)(0), DevExpress.XtraGrid.GridControl).MainView

                For intk As Integer = 1 To ColEPADD.Count
                    gvTemp.AddNewRow()
                    gvTemp.SetFocusedRowCellValue(CollectionContent(inti).Column, ColEPADD(intk))
                Next
                For intk As Integer = 1 To ColEPDelete.Count
                    For intJ As Integer = 0 To gvTemp.RowCount - 1
                        If gvTemp.GetRowCellValue(intJ, CollectionContent(inti).Column) = ColEPDelete(intk) Then
                            gvTemp.DeleteRow(intJ)
                            Exit For
                        End If
                    Next
                Next
            End If
        Next
        Load_Off(Frm_Formulaire)
        '----------------------------------------------------
        '----------------------------------------------------
    End Sub

#End Region

#End Region

#Region " Get Code    "

    Public Function GetCodeFromCollection(ByVal col As Collection) As String
        Dim Result As String = ""

        If col.Count > 0 Then
            Result = ""
            For inti As Integer = 1 To col.Count
                If inti = 1 Then
                    Result = col(inti)
                Else
                    Result &= "," & col(inti)
                End If
            Next
            Result = "(" & Result & ")"
        End If

        Return Result
    End Function

    Public Function GetCodeATCFromCollection(ByVal col As Collection) As String
        Dim Result As String = ""

        If col.Count > 0 Then
            Result = ""
            For inti As Integer = 1 To col.Count
                If inti = 1 Then
                    Result = "'" & col(inti) & "'"
                Else
                    Result &= ",'" & col(inti) + "'"
                End If
            Next
            Result = "(" & Result & ")"
        End If

        Return Result
    End Function

    Public Function GetCodeFromCollectionString(ByVal col As Collection) As String
        Dim Result As String = ""

        If col.Count > 0 Then
            Result = ""
            For inti As Integer = 1 To col.Count
                If inti = 1 Then
                    Result = cn.SQLText(col(inti))
                Else
                    Result &= "," & cn.SQLText(col(inti))
                End If
            Next
            Result = "(" & Result & ")"
        End If

        Return Result
    End Function

    Public Function GetCodeFromGV(ByVal gv As DevExpress.XtraGrid.Views.Grid.GridView, ByVal colum As DevExpress.XtraGrid.Columns.GridColumn) As Collection
        Dim Coll As New Collection
        For intI As Integer = 0 To gv.RowCount - 1
            If gv.GetRowCellValue(intI, colum) IsNot Nothing Then
                Coll.Add(gv.GetRowCellValue(intI, colum))
            End If
        Next
        Return Coll
    End Function

    Private Function GetCodeStringFromGV(ByVal gv As DevExpress.XtraGrid.Views.Grid.GridView, ByVal colum As DevExpress.XtraGrid.Columns.GridColumn) As Collection
        Dim Coll As New Collection
        For intI As Integer = 0 To gv.RowCount - 1
            If gv.GetRowCellValue(intI, colum) IsNot Nothing Then
                Coll.Add(cn.SQLText(gv.GetRowCellValue(intI, colum)))
            End If
        Next
        Return Coll
    End Function

#End Region

End Module
