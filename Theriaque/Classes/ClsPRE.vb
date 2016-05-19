Public Class ClsPRE

    Shared ReadOnly Property Code_SP_(ByVal Code_PRE As String)
        Get
            Dim dt As DataTable = cn.MySelect("Select PRE_SP_CODE_FK from THERIAQUE.PRE_PRESENTATION where PRE_CODE_PK = " & cn.SQLText(Code_PRE))
            Return dt.Rows(0)(0)
        End Get
    End Property

    Shared ReadOnly Property GetLibelle(ByVal Code_PR As String) As String
        Get
            Dim dt As DataTable = cn.MySelect("Select SP_NOM From THERIAQUE.PRE_PRESENTATION, THERIAQUE.SP_SPECIALITE where SP_CODE_SQ_PK = PRE_SP_CODE_FK and  PRE_CODE_PK = " & cn.SQLText(Code_PR))
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)(0)
            End If
        End Get
    End Property

    Shared ReadOnly Property GetNBUnite(ByVal Code_PR As String) As Integer
        Get
            Dim dt As DataTable = cn.MySelect("Select PRE_NBUNITE From THERIAQUE.PRE_PRESENTATION where PRE_CODE_PK = " & cn.SQLText(Code_PR))
            If dt.Rows.Count > 0 Then
                If dt.Rows(0)(0) Is System.DBNull.Value Then
                    Return 0
                Else
                    Return dt.Rows(0)(0)
                End If
            Else
                Return 0
            End If
        End Get
    End Property

    Shared ReadOnly Property GetNBContenance(ByVal Code_PR As String) As Decimal
        Get
            Dim dt As DataTable = cn.MySelect("Select PRECONT_NBCONTENANCE From THERIAQUE.PRECONT_PRE_CONTENANT WHERE PRECONT_PRE_CODE_FK_PK = " & cn.SQLText(Code_PR))
            If dt.Rows.Count > 0 Then
                If dt.Rows(0)(0) Is System.DBNull.Value Then
                    Return 0
                Else
                    Return dt.Rows(0)(0)
                End If
            Else
                Return 0
            End If
        End Get
    End Property

    Shared ReadOnly Property GetMinNBContenance(ByVal Code_PR As String) As Decimal
        Get
            Dim dt As DataTable = cn.MySelect("Select top(1) PRECONT_NBCONTENANCE From THERIAQUE.PRECONT_PRE_CONTENANT WHERE PRECONT_PRE_CODE_FK_PK = " & cn.SQLText(Code_PR) & " order by PRECONT_COCONT_NUM_FK_PK asc ")
            If dt.Rows.Count > 0 Then
                If dt.Rows(0)(0) Is System.DBNull.Value Then
                    Return 0
                Else
                    Return dt.Rows(0)(0)
                End If
            Else
                Return 0
            End If
        End Get
    End Property


    Shared ReadOnly Property GetUniteDispensation(ByVal Code_PR As String) As Decimal
        Get
            Dim dt As DataTable = cn.MySelect("select PREDISP_UNITEDISP  from  THERIAQUE.PREDISP_PRE_DISPENSATION where PREDISP_PRE_CODE_FK_PK = " & cn.SQLText(Code_PR))
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)(0)
            End If
        End Get
    End Property

    Shared ReadOnly Property GetContenant(ByVal CodePRE As String) As DataTable
        Get
            Dim dt As DataTable = cn.MySelect("SELECT * FROM THERIAQUE.PRECONT_PRE_CONTENANT WHERE PRECONT_PRE_CODE_FK_PK = " & cn.SQLText(CodePRE))
            If dt.Rows.Count > 0 Then
                Return dt
            Else
                Return New DataTable()
            End If
        End Get

    End Property


    Shared ReadOnly Property GetNBUniteMonoVirtuelle(ByVal Code_PR As String, ByVal NumContenant As Integer, ByVal VolumeInitial As Decimal, ByVal VolumeCourant As Decimal) As String
        Get
            'Cas de monographie virtuelle T10406
            Dim dt As DataTable
            Dim nbUnite As String
            dt = cn.MySelect("SELECT PREDISP_UNITEDISP FROM theriaque.PREDISP_PRE_DISPENSATION WHERE PREDISP_PRE_CODE_FK_PK  = " & cn.SQLText(Code_PR))
            If dt.Rows.Count > 0 Then
                If NumContenant = 0 Then
                    nbUnite = dt.Rows(0)(0)
                Else
                    If (VolumeInitial <> VolumeCourant) Then
                        nbUnite = (VolumeCourant / VolumeInitial) * dt.Rows(0)(0)
                    Else
                        nbUnite = dt.Rows(0)(0)
                    End If
                End If

            End If
            Return nbUnite
        End Get
    End Property


 


End Class
