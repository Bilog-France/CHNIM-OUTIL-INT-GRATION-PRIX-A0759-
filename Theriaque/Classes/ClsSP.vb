Public Class ClsSP

    Shared ReadOnly Property GetPR(ByVal Code_SP As Integer) As String
        Get
            Dim dt As DataTable = cn.MySelect("Select PRE_CODE_PK from THERIAQUE.PRE_PRESENTATION where PRE_SP_CODE_FK = " & Code_SP)
            Dim StrCode As String = ""
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    If StrCode = "" Then
                        StrCode = "'" & dt.Rows(i)(0) & "'"
                    Else
                        StrCode &= "," & "'" & dt.Rows(i)(0) & "'"
                    End If
                Next
                Return "(" & StrCode & ")"
            Else
                Return ""
            End If
        End Get

    End Property

    Shared ReadOnly Property GetPR_GRP(ByVal Code_SP As Integer) As String
        Get
            Dim query As String = " select p.PRE_CODE_PK from theriaque.PRE_PRESENTATION p, theriaque.SPGREFG_GROUPE_SPE_GENE sp,theriaque.PREGREF_PRE_GROUPE_REF  spg "
            query &= " where(p.PRE_SP_CODE_FK = sp.SPGREFG_SP_CODE_FK_PK)and spg.PREGREF_PRE_CODE_FK_PK = p.PRE_CODE_PK "
            query &= "and sp.SPGREFG_SP_CODE_FK_PK = " & Code_SP

            Dim dt As DataTable = cn.MySelect(query) ' "Select PRE_CODE_PK from THERIAQUE.PRE_PRESENTATION where PRE_SP_CODE_FK = " & Code_SP)
            Dim StrCode As String = ""
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    If StrCode = "" Then
                        StrCode = "'" & dt.Rows(i)(0) & "'"
                    Else
                        StrCode &= "," & "'" & dt.Rows(i)(0) & "'"
                    End If
                Next
                Return StrCode
            Else
                Return ""
            End If
        End Get

    End Property

    Shared ReadOnly Property GetPR_DT(ByVal Code_SP As Integer) As DataTable
        Get
            Dim dt As DataTable = cn.MySelect("Select * from THERIAQUE.PRE_PRESENTATION where PRE_SP_CODE_FK = " & Code_SP)
            If dt.Rows.Count > 0 Then
                Return dt
            End If
        End Get

    End Property


    Shared ReadOnly Property GetCOSAU(ByVal GREF_CODE As Integer, ByVal GREF_DATECR As Date) As DataTable
        Get
            Dim strSSQL As String = ""
            strSSQL &= " SELECT * FROM THERIAQUE.COSAU_COMPO_SUBAUX"
            strSSQL &= " where COSAU_GREF_CODE_FK = " & GREF_CODE
            strSSQL &= " and "
            strSSQL &= " COSAU_GREF_DATECR_FK = " & cn.SQLDate(GREF_DATECR)
            Dim dt As DataTable = cn.MySelect(strSSQL)
            Return dt
        End Get
    End Property

    Shared ReadOnly Property GetCIPUCD(ByVal SP_CODE As Integer) As String
        Get
            Dim strSSQL As String = ""
            strSSQL &= " select SP_CIPUCD from THERIAQUE.SP_SPECIALITE"
            strSSQL &= " where SP_CODE_SQ_PK = " & SP_CODE
            Dim dt As DataTable = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)(0).ToString
            End If
        End Get
    End Property

    Shared ReadOnly Property GetLibelle(ByVal SP_CODE As Integer) As String
        Get
            Dim strSSQL As String = ""
            strSSQL &= " select SP_NOM from THERIAQUE.SP_SPECIALITE"
            strSSQL &= " where SP_CODE_SQ_PK = " & SP_CODE
            Dim dt1 As New DataTable
            dt1 = cn.MySelect(strSSQL)
            If dt1.Rows.Count > 0 Then
                Return dt1.Rows(0)(0)
            End If
        End Get
    End Property

    Shared ReadOnly Property GetSynonyme(ByVal SP_CODE As Integer) As String
        Get
            Dim strSSQL As String = ""
            strSSQL &= " select SYSP_NOM_PK from THERIAQUE.SYSP_SYNONYME_SPECIALITE"
            strSSQL &= " where SYSP_SP_CODE_FK = " & SP_CODE
            Dim dt As DataTable = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)(0)
            End If
        End Get
    End Property

    Shared ReadOnly Property GetCodeVirtuel(ByVal SP_CODE As Integer) As String
        Get
            Dim strSSQL As String = ""
            strSSQL &= " SELECT GSP_CODE_VIRTUEL FROM THERIAQUE.GSP_GENERIQUE_SPECIALITE"
            strSSQL &= " WHERE GSP_CODE_SQ_PK =(SELECT SP_GSP_CODE_FK FROM THERIAQUE.SP_SPECIALITE WHERE SP_CODE_SQ_PK = " & SP_CODE & ")"
            Dim dt As DataTable = cn.MySelect(strSSQL)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)(0).ToString
            End If
        End Get
    End Property

    Shared ReadOnly Property GetPRE(ByVal Code_SP As Integer) As DataTable
        Get
            Dim dt As DataTable = cn.MySelect("Select * from THERIAQUE.PRE_PRESENTATION where PRE_SP_CODE_FK = " & Code_SP)
            If dt.Rows.Count > 0 Then
                Return dt
            End If
        End Get

    End Property

    Shared Sub AddSPGREFG(ByVal Code_SP As Integer, ByVal code_Grp As Integer, ByVal date_cr As DateTime, ByVal date_EG As DateTime)

        Dim queryExist As String = " select null from  [theriaque].[theriaque].[SPGREFG_GROUPE_SPE_GENE] where [SPGREFG_GREF_CODE_FK_PK] = " & code_Grp
        queryExist &= " and [SPGREFG_SP_CODE_FK_PK] =  " & Code_SP & " and [SPGREFG_GREF_DATECR_FK_PK] = convert(datetime,'" & date_cr & "', 103) and [SPGREFG_DATEEG_PK]= convert(datetime,'" & date_EG & "', 103) "

        If (Not HasRows(queryExist)) Then
            Dim query As String = " INSERT INTO [theriaque].[theriaque].[SPGREFG_GROUPE_SPE_GENE]([SPGREFG_SP_CODE_FK_PK], [SPGREFG_GREF_CODE_FK_PK],[SPGREFG_GREF_DATECR_FK_PK],[SPGREFG_DATEEG_PK])"
            query &= " VALUES( " & Code_SP & "," & code_Grp & " ,convert(datetime,'" & date_cr & "', 103) , convert(datetime,'" & date_EG & "', 103)) "
            cn.Execute(query)
        End If

    End Sub

    'TODO: a suivre
    Shared Sub AddSPGREFR(ByVal Code_SP As Integer, ByVal code_Grp As Integer, ByVal date_cr As DateTime, ByVal date_EG As DateTime)

        Dim queryExist As String = " select null from  [theriaque].[theriaque].[SPGREFR_GROUPE_SPE_REF] where [SPGREFR_GREF_CODE_FK_PK] = " & code_Grp
        queryExist &= " and [SPGREFR_SP_CODE_FK_PK] =  " & Code_SP & " and [SPGREFR_GREF_DATECR_FK_PK] = convert(datetime,'" & date_cr & "', 103) "

        If (Not HasRows(queryExist)) Then
            Dim query As String = " INSERT INTO [theriaque].[theriaque].[SPGREFR_GROUPE_SPE_REF]([SPGREFR_SP_CODE_FK_PK], [SPGREFR_GREF_CODE_FK_PK],[SPGREFR_GREF_DATECR_FK_PK])"
            query &= " VALUES( " & Code_SP & "," & code_Grp & " ,convert(datetime,'" & date_cr & "', 103) ) "
            cn.Execute(query)
        End If

    End Sub

    Shared Function HasRows(ByVal sSQL As String) As Boolean

        Dim dt As DataTable = cn.MySelect(sSQL)
        Return (dt.Rows.Count > 0)

    End Function

    Shared Function GetPrGrp(ByVal code_Grp As Integer, ByVal date_cr As DateTime, ByVal date_Ent As DateTime) As DataTable

        Dim query As String = " select PREGREF_PRE_CODE_FK_PK from theriaque.PREGREF_PRE_GROUPE_REF where PREGREF_GREF_CODE_FK_PK =" & code_Grp & " and PREGREF_DATEENTREE_PK = convert(datetime,'" & date_Ent & "',103) and PREGREF_GREF_DATECR_FK_PK=convert(datetime,'" & date_cr & "',103) "
        Dim dt As DataTable = cn.MySelect(query)
        Return dt

    End Function

    Shared Sub initValNum(ByVal CDF_NUMERO_PK As String, ByVal CDF_CODE_PK As String)
        Dim query As String = "UPDATE [theriaque].[theriaque].[CDF_CODIF] set [CDF_VAL_NUM] = -1 where [CDF_NUMERO_PK] = '" & CDF_NUMERO_PK & "' and [CDF_CODE_PK] = '" & CDF_CODE_PK & "' and CDF_VAL_NUM is null"
        cn.Execute(query)
    End Sub

End Class
