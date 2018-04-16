Imports System.Data.SqlClient
Public Module Code

    Public Function Code_PereFils(ByVal strCode As String, ByVal strTable As String, ByVal TestIfExist As Boolean, ByVal strField As String) As StructResultCode

        Dim Rs As New StructResultCode

        If strCode.Length = 1 Then
            Rs._Code = Nothing
            Rs._Validation = True
            Return Rs
        End If

        Dim dt As DataTable
        dt = cn.MySelect("Select  " & strField & " from " & strTable & " where " & strField & " = " & cn.SQLText(Mid(strCode, 1, strCode.Length - 1)))
        If dt.Rows.Count = 0 Then
            Rs._Code = ""
            Rs._Validation = False
            Return Rs
        Else
            Rs._Code = dt.Rows(0)(0)
            Rs._Validation = False
            Return Rs
        End If
    End Function

    Public Function Code_PereFils(ByVal Ctrl As Control, ByVal strTable As String, Optional ByVal ErrProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider = Nothing, Optional ByVal TestIfExist As Boolean = True, Optional ByVal strSuplementSQL As String = "") As StructResultCode

        Dim Rs As New StructResultCode

        If Ctrl Is Nothing Then
            Rs._Code = Nothing
            Rs._Validation = False
            Return Rs
        End If

        If Ctrl.Text Is Nothing Then
            Rs._Code = Nothing
            Rs._Validation = False
            Return Rs
        End If
        If Ctrl.Text = "" Then
            Rs._Code = Nothing
            Rs._Validation = False
            Return Rs
        End If

        Dim strField As String = Ctrl.DataBindings("EditValue").BindingMemberInfo.BindingField()
        Dim strCode As String = Ctrl.Text

        If InStr("ABCDEFGHIJKLMNOPQRSTUVWXYZ", CStr(strCode(0)), CompareMethod.Text) = 0 Then
            ErrProvider.SetError(Ctrl, strPremierCaract)
            Rs._Code = Nothing
            Rs._Validation = False
            Return Rs
        End If
        If TestIfExist Then
            If FieldExist(strTable, Ctrl, , strSuplementSQL) Then
                ErrProvider.SetError(Ctrl, StrCodeExist)
                Rs._Code = Nothing
                Rs._Validation = False
                Return Rs
            End If
        End If

        If strCode = Nothing Then
            Rs._Code = Nothing
            Rs._Validation = False
            If ErrProvider IsNot Nothing Then
                ErrProvider.SetError(Ctrl, StrCodePereinexistant)
            End If
            Return Rs
        End If

        If Trim(strCode) = "" Then
            Rs._Code = Nothing
            Rs._Validation = True
            If ErrProvider IsNot Nothing Then
                ErrProvider.SetError(Ctrl, "")
            End If
            Return Rs
        End If

        If strCode.Length = 1 Then
            Rs._Code = Nothing
            Rs._Validation = True
            If ErrProvider IsNot Nothing Then
                ErrProvider.SetError(Ctrl, "")
            End If
            Return Rs
        End If

        Dim dt As DataTable
        Dim strSSQL1 As String = ""
        strSSQL1 = "Select  " & strField & " from THERIAQUE." & strTable & " where " & strField & " = " & cn.SQLText(Mid(strCode, 1, strCode.Length - 1))
        If strSuplementSQL.Trim <> "" Then
            strSSQL1 &= " and " & strSuplementSQL
        End If
        dt = cn.MySelect(strSSQL1)
        If dt.Rows.Count = 0 Then
            Rs._Validation = False
            If ErrProvider IsNot Nothing Then
                ErrProvider.SetError(Ctrl, StrCodePereinexistant)
            End If
            Return Rs
        Else
            Rs._Code = dt.Rows(0)(0)
            Rs._Validation = True
            If ErrProvider IsNot Nothing Then
                ErrProvider.SetError(Ctrl, "")
            End If
            Return Rs
        End If
    End Function

    Public Function Code_MAx(ByVal strTable As String, ByVal Ctrl As Control) As Integer

        Dim strField As String = Ctrl.DataBindings("EditValue").BindingMemberInfo.BindingField()
        Dim dt As DataTable = cn.MySelect("Select isnull(max(" & strField & "),0) From THERIAQUE." & strTable)
        Return dt.Rows(0)(0)

    End Function

    Public Function ReferenceExist(ByVal codeFiche As Integer, ByVal CodeRef As String, ByVal LibRef As String) As Boolean

        Dim dt As DataTable = cn.MySelect("Select null From THERIAQUE.SAC_SUBACTIVE where SAC_CODE_SQ_PK <> " & codeFiche & " and SAC_CODE_REF = '" & CodeRef & "' and SAC_LIBELLE_REF = '" & LibRef.Replace("'", "''") & "'")
        Return (dt.Rows.Count > 0)

    End Function

    Public Function Code_MAx(ByVal Table As DataTable, ByVal strField As String, Optional ByVal strSupplement_SQL As String = "") As Integer
        Dim i, max As Integer
        max = 0
        For i = 0 To Table.Rows.Count - 1
            If Table.Rows(i)(strField) > max Then
                max = Table.Rows(i)(strField)
            End If
        Next
        If max <> 0 Then
            Return max + 1
        End If
    End Function

    Public Function Code_MAx(ByVal strTable As String, ByVal strField As String, Optional ByVal strSupplement_SQL As String = "") As Integer
        Dim dt As DataTable = cn.MySelect("Select max(Cast(" & strField & " AS int)) From THERIAQUE." & strTable & " " & strSupplement_SQL)
        If dt.Rows.Count > 0 Then
            If dt.Rows(0)(0) Is DBNull.Value Then
                Return -1
            End If
            Return dt.Rows(0)(0)
        End If
    End Function

    Public Function Code_MAx(ByVal gv As DevExpress.XtraGrid.Views.Grid.GridView, ByVal Col As DevExpress.XtraGrid.Columns.GridColumn) As Integer
        Dim intI, intMax As Integer
        intI = 0
        intMax = 0
        For intI = 0 To gv.RowCount - 1
            If (Not gv.GetRowCellValue(intI, Col) Is System.DBNull.Value) Then
                If gv.GetRowCellValue(intI, Col) > intMax Then
                    intMax = gv.GetRowCellValue(intI, Col)
                End If
            End If
        Next
        Return intMax + 1
    End Function

    Public Function GetMaxSP_ID()

        Dim id As Integer
        Dim cmd As New SqlCommand
        If cn.SQlCon.State = ConnectionState.Closed Then
            cn.SQlCon.Open()
        End If
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cn.SQlCon
        cmd.CommandText = "GETSPID"
        cmd.Parameters.AddWithValue("@ID", id)
        id = cmd.ExecuteScalar()
        Return id
    End Function

    Public Function SetCode_MAx(ByVal strTable As String, ByVal Ctrl As Control, Optional ByVal Off As Boolean = True) As Integer
        Dim strField As String = Ctrl.DataBindings("EditValue").BindingMemberInfo.BindingField()
        Dim strCode As String = Ctrl.Text
        Dim dt As DataTable = cn.MySelect("Select max(" & strField & ") From THERIAQUE." & strTable)

        If (dt IsNot Nothing) Then


            If dt.Rows(0)(0) IsNot DBNull.Value Then
                Ctrl.Text = dt.Rows(0)(0) + 1
            Else
                Ctrl.Text = 1
            End If
        End If
        If Off Then
            Ctl_Off(Ctrl)
            Ctrl.Tag = "[NOEDIT][NOADD]"
        End If
        Return True
    End Function

    Public Function SetCode_MAxByField(ByVal strTable As String, ByVal Ctrl As Control, ByVal strField As String, Optional ByVal Off As Boolean = True) As Integer
        'Dim strField As String = Ctrl.DataBindings("EditValue").BindingMemberInfo.BindingField()
        Dim strCode As String = Ctrl.Text
        Dim dt As DataTable = cn.MySelect("Select max(" & strField & ") From THERIAQUE." & strTable)

        If (dt IsNot Nothing) Then


            If dt.Rows(0)(0) IsNot DBNull.Value Then
                Ctrl.Text = dt.Rows(0)(0) + 1
            Else
                Ctrl.Text = 1
            End If
        End If
        If Off Then
            Ctl_Off(Ctrl)
            Ctrl.Tag = "[NOEDIT][NOADD]"
        End If
        Return True
    End Function

    Public Function SetCode_MAxId(ByVal strTable As String, ByVal Ctrl As Control, Optional ByVal Off As Boolean = True) As Integer
        Dim strField As String = Ctrl.DataBindings("EditValue").BindingMemberInfo.BindingField()
        Dim strCode As String = Ctrl.Text
        Dim dt As DataTable = cn.MySelect("select isnull(max(CDFUCUM_CODE_PK),0) + 1 from [theriaque].[theriaque].[CDFUCUM_UCUM]")
        Ctrl.Text = dt.Rows(0)(0)

        'If (dt IsNot Nothing) Then


        '    If dt.Rows(0)(0) IsNot DBNull.Value Then
        '        Ctrl.Text = dt.Rows(0)(0) + 1
        '    Else
        '        Ctrl.Text = 1
        '    End If
        'End If
        If Off Then
            Ctl_Off(Ctrl)
            Ctrl.Tag = "[NOEDIT][NOADD]"
        End If
        Return True
    End Function

    Public Function Get_MAxCode() As Integer

        Dim dt As DataTable = cn.MySelect("Select max(SP_CODE) From THERIAQUE.WSSP_PARAM_ID")

        Dim code As Integer = 1
        If (dt IsNot Nothing) Then

            If dt.Rows(0)(0) IsNot DBNull.Value Then
                code = dt.Rows(0)(0) + 1
            End If
        End If

        Return code

    End Function

    Public Function Get_MaxCodeIdentity(ByVal table As String, ByVal field As String) As Integer

        Dim dt As DataTable = cn.MySelect("Select max(" & field & ") From THERIAQUE." & table)

        Dim code As Integer = 1
        If (dt IsNot Nothing) Then

            If dt.Rows(0)(0) IsNot DBNull.Value Then
                code = dt.Rows(0)(0) + 1
            End If
        End If

        Return code

    End Function


    Public Function SpCodeExist(ByVal code As Integer) As Boolean

        Dim dt As DataTable = cn.MySelect("Select null From THERIAQUE.SP_SPECIALITE where SP_CODE_SQ_PK=" & code)

        Return dt.Rows.Count > 0

    End Function

    Public Function Code_Alpha_Hierarchise(ByVal Ctrl As Control, ByVal strTable As String, ByRef ErrProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider) As Boolean

        If Ctrl Is Nothing Then
            Return False
            ErrProvider.SetError(Ctrl, strChampIntrouvable)
        End If

        If Ctrl.Text Is Nothing Then
            Return True
        End If
        If Ctrl.Text = "" Then
            Return True
        End If

        Dim strField As String = Ctrl.DataBindings("EditValue").BindingMemberInfo.BindingField()
        Dim strCode As String = Ctrl.Text

        If FieldExist(strTable, Ctrl) Then
            ErrProvider.SetError(Ctrl, StrCodeExist)
            Return False
        End If

        ErrProvider.SetError(Ctrl, "")
        Return True

    End Function

    Public Function Code_Ephmra(ByVal Ctrl As Control, ByVal strTable As String, ByRef ErrProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider) As Boolean

        If Not Code_Alpha_Hierarchise(Ctrl, strTable, ErrProvider) Then
            Return False
        End If

        Dim strField As String = Ctrl.DataBindings("EditValue").BindingMemberInfo.BindingField()
        Dim strCode As String = Ctrl.Text
        Dim strCodePere As String = ""

        If strCode = "" Then
            Return True
        End If
        If Char.IsLetter(strCode(0)) Then
        Else
            ErrProvider.SetError(Ctrl, "Le premier caractére doit être une lettre")
            Return False
        End If

        If strCode.Length > 1 Then
            If Char.IsNumber(strCode(1)) Then
            Else
                ErrProvider.SetError(Ctrl, "Le 2éme et le 3éme caractére doit être un entier")
                Return False
            End If
            If strCode.Length > 2 Then
                If Char.IsNumber(strCode(2)) Then
                Else
                    ErrProvider.SetError(Ctrl, "Le 2éme et le 3éme caractére doit être un entier")
                    Return False
                End If
                If strCode.Length > 3 Then
                    If Char.IsLetter(strCode(3)) Then
                    Else
                        ErrProvider.SetError(Ctrl, "Le 4éme caractére doit être une lettre")
                        Return False
                    End If
                    If strCode.Length > 4 Then
                        If Char.IsNumber(strCode(4)) Then
                        Else
                            ErrProvider.SetError(Ctrl, "Le 5éme caractére doit être une entier")
                            Return False
                        End If
                    End If
                End If
            End If
        End If

        strCodePere = Code_GetCodePereEphmra(strCode)
        If strCodePere <> "" And strCodePere <> InvalideControl Then
            Dim dt As DataTable = cn.MySelect("select * from THERIAQUE." & strTable & " where lower(" & strField & ") = " & LCase(cn.SQLText(strCodePere)))
            If dt.Rows.Count > 0 Then
            Else
                ErrProvider.SetError(Ctrl, StrCodePereinexistant)
                Return False
            End If
        End If
        If strCodePere = InvalideControl Then
            ErrProvider.SetError(Ctrl, StrCodePereinexistant)
            Return False
        End If

        ErrProvider.SetError(Ctrl, "")
        Return True
    End Function

    Public Function Code_GetCodePereEphmra(ByVal strCode As String) As String
        Dim strCodePere As String = ""

        If CStr(strCode).Length = 1 Then
            strCodePere = ""
        ElseIf CStr(strCode).Length = 2 Then
            strCodePere = CStr(strCode)(0)
        ElseIf CStr(strCode).Length = 3 Then
            strCodePere = CStr(strCode)(0)
        ElseIf CStr(strCode).Length = 4 Then
            strCodePere = Mid(strCode, 1, 3)
        ElseIf CStr(strCode).Length = 5 Then
            strCodePere = Mid(strCode, 1, 4)
        Else
            strCodePere = InvalideControl
        End If
        Return strCodePere
    End Function

    Public Function Code_ATC(ByVal Ctrl As Control, ByVal strTable As String, ByRef ErrProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider) As Boolean

        If Not Code_Alpha_Hierarchise(Ctrl, strTable, ErrProvider) Then
            Return False
        End If

        Dim strField As String = Ctrl.DataBindings("EditValue").BindingMemberInfo.BindingField()
        Dim strCode As String = Ctrl.Text
        Dim strCodePere As String = ""

        If strCode = "" Then
            Return True
        End If

        If strCode.Length = 2 Then
            ErrProvider.SetError(Ctrl, "Il est impossible d'avoir un code s'arrêtant en 2ème position ")
            Return False
        End If

        If strCode.Length = 6 Then
            ErrProvider.SetError(Ctrl, "Il est impossible d'avoir un code s'arrêtant en 6ème position ")
            Return False
        End If

        If Char.IsLetter(strCode(0)) Then
        Else
            ErrProvider.SetError(Ctrl, "Le premier caractére doit être une lettre")
            Return False
        End If

        If strCode.Length > 1 Then
            If Char.IsNumber(strCode(1)) Then
            Else
                ErrProvider.SetError(Ctrl, "Le 2éme et le 3éme caractére doit être un entier")
                Return False
            End If
            If strCode.Length > 2 Then
                If Char.IsNumber(strCode(2)) Then
                Else
                    ErrProvider.SetError(Ctrl, "Le 2éme et le 3éme caractére doit être un entier")
                    Return False
                End If
                If strCode.Length > 3 Then
                    If Char.IsLetter(strCode(3)) Then
                    Else
                        ErrProvider.SetError(Ctrl, "Le 4éme caractére doit être une lettre")
                        Return False
                    End If
                    If strCode.Length > 4 Then
                        If Char.IsLetter(strCode(4)) Then
                        Else
                            ErrProvider.SetError(Ctrl, "Le 5éme caractére doit être une lettre")
                            Return False
                        End If
                        If strCode.Length > 5 Then
                            If Char.IsNumber(strCode(5)) Then
                            Else
                                ErrProvider.SetError(Ctrl, "Le 6éme caractére doit être une entier")
                                Return False
                            End If
                            If strCode.Length > 6 Then
                                If Char.IsNumber(strCode(6)) Then
                                Else
                                    ErrProvider.SetError(Ctrl, "Le 6éme caractére doit être une entier")
                                    Return False
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        strCodePere = Code_GetCodePereATC(strCode)
        If strCodePere <> "" And strCodePere <> InvalideControl Then
            Dim dt As DataTable = cn.MySelect("select * from THERIAQUE." & strTable & " where lower(" & strField & ") = " & LCase(cn.SQLText(strCodePere)))
            If dt.Rows.Count > 0 Then
            Else
                ErrProvider.SetError(Ctrl, StrCodePereinexistant)
                Return False
            End If
        End If
        If strCodePere = InvalideControl Then
            ErrProvider.SetError(Ctrl, StrCodePereinexistant)
            Return False
        End If

        ErrProvider.SetError(Ctrl, "")
        Return True
    End Function

    Public Function Code_GetCodePereATC(ByVal strCode As String) As String
        Dim strCodePere As String = ""

        'A11AA15
        If CStr(strCode).Length = 1 Then
            strCodePere = ""
        ElseIf CStr(strCode).Length = 3 Then
            strCodePere = CStr(strCode)(0)
        ElseIf CStr(strCode).Length = 4 Then
            strCodePere = Mid(strCode, 1, 3)
        ElseIf CStr(strCode).Length = 5 Then
            strCodePere = Mid(strCode, 1, 4)
        ElseIf CStr(strCode).Length = 7 Then
            strCodePere = Mid(strCode, 1, 5)
        Else
            strCodePere = InvalideControl
        End If
        Return strCodePere
    End Function

    Public Function Code_PP(ByVal Ctrl As Control, ByVal strTable As String, Optional ByVal ErrProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider = Nothing, Optional ByVal TestIfExist As Boolean = True, Optional ByVal strSuplementSQL As String = "") As Boolean

        Dim TempStr As String = ""
        Dim StrMsg As String = ""

        If Not Code_Alpha_Hierarchise(Ctrl, strTable, ErrProvider) Then
            Return False
        End If

        Dim strField As String = Ctrl.DataBindings("EditValue").BindingMemberInfo.BindingField()
        Dim strCode As String = Ctrl.Text

        If strCode.Length = 0 Then
            StrMsg = "Le code doit être obligatoirement constitué de 9 caractére"
            ErrProvider.SetError(Ctrl, StrMsg)
            Return False
        End If

        If strCode.Length <> 9 Then
            StrMsg = "Le code doit être obligatoirement constitué de 9 caractére"
            'Process_Message(StrMsg, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ErrProvider.SetError(Ctrl, StrMsg)
            Return False
        End If

        If Not Char.IsLetter(strCode(0)) Then
            StrMsg = "Le 1er caractére doit être obligatoirement une lettre"
            'Process_Message(StrMsg, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ErrProvider.SetError(Ctrl, StrMsg)
            Return False
        End If

        TempStr = Mid(strCode, 2, 4)
        If Not IsNumeric(TempStr) Then
            StrMsg = "Les 4 caractéres [" & TempStr & "] doivent être un chiffre"
            'Process_Message(StrMsg, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ErrProvider.SetError(Ctrl, StrMsg)
            Return False
        End If

        If Not Char.IsLetter(strCode(5)) Then
            StrMsg = "Le 6éme caractére doit être obligatoirement une lettre"
            'Process_Message(StrMsg, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ErrProvider.SetError(Ctrl, StrMsg)
            Return False
        End If

        If (Not strCode(6) = "Z") And (Not strCode(6) = "F") Then
            StrMsg = "Le 7éme caractére [" & strCode(6) & "] doit être la lettre (F) ou la lettre (Z)"
            'Process_Message(StrMsg, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ErrProvider.SetError(Ctrl, StrMsg)
            Return False
        End If

        TempStr = Mid(strCode, 8, 2)
        If Not IsNumeric(TempStr) Then
            StrMsg = "Les 2 caractéres [" & TempStr & "] doivent être des chiffres"
            'Process_Message(StrMsg, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ErrProvider.SetError(Ctrl, StrMsg)
            Return False
        End If

        ErrProvider.SetError(Ctrl, "")
        Return True
    End Function

    Public Enum EnumTypeCDF
        Numeric = 0
        Numeric_IVO = 1
        Numeric_Equivalence = 2
        AlphaNumeric_Lette = 3
        AlphaNumeric_Hirch = 4
        AlphaNumeric_Lette_Equivalence = 5
        AlphaNumeric_Lette_CIM10 = 6
        AlphaNumeric_Orphanet_CIM10 = 7
        AlphaNumeric_PP = 8
        AlphaNumeric_CIM10_CISP = 9
        AlphaNumeric_Lettre_CIM10_CISP = 10
        AlphaNumeric_CIM10_MEDRA = 11
        Numeric_IY = 12
        AlphaNumeric_Pere = 13
    End Enum

    Public Function Code_CDF(ByVal strNumero As String) As EnumTypeCDF
        Dim TypeCDF As EnumTypeCDF
        Dim strCodeNemerique As String
        Dim arrayCode As String()
        Dim i As Integer

        strCodeNemerique = "03, 07, 08, 10, 11, 12, 13, 15, 17, 19, 21, 22, 24, 25, 27, 28, 29, PN , IN, IS, IV, MV, MD, ML, MT, MS"
        strCodeNemerique = strCodeNemerique.Replace(" ", "")
        arrayCode = strCodeNemerique.Split(","c)
        For i = 0 To arrayCode.Length - 1
            If strNumero = arrayCode(i) Then
                TypeCDF = EnumTypeCDF.Numeric
            End If
        Next

        strCodeNemerique = "02, 04, 06, 18"
        strCodeNemerique = strCodeNemerique.Replace(" ", "")
        arrayCode = strCodeNemerique.Split(","c)
        For i = 0 To arrayCode.Length - 1
            If strNumero = arrayCode(i) Then
                TypeCDF = EnumTypeCDF.Numeric_IVO
            End If
        Next

        If strNumero = "20" Then
            TypeCDF = EnumTypeCDF.Numeric_Equivalence
        End If

        strCodeNemerique = "01, 09, 14, 23, 26, 30, 31, PK, SC, NV, NY, PA, PC, PT, PC, PT, RC, HC, GT, GC, GP, GR, EC, IC, MN"
        strCodeNemerique = strCodeNemerique.Replace(" ", "")
        arrayCode = strCodeNemerique.Split(","c)
        For i = 0 To arrayCode.Length - 1
            If strNumero = arrayCode(i) Then
                TypeCDF = EnumTypeCDF.AlphaNumeric_Lette
            End If
        Next

        strCodeNemerique = "NA, GO"
        strCodeNemerique = strCodeNemerique.Replace(" ", "")
        arrayCode = strCodeNemerique.Split(","c)
        For i = 0 To arrayCode.Length - 1
            If strNumero = arrayCode(i) Then
                TypeCDF = EnumTypeCDF.AlphaNumeric_Hirch
            End If
        Next

        strCodeNemerique = "PF, PU"
        strCodeNemerique = strCodeNemerique.Replace(" ", "")
        arrayCode = strCodeNemerique.Split(","c)
        For i = 0 To arrayCode.Length - 1
            If strNumero = arrayCode(i) Then
                TypeCDF = EnumTypeCDF.AlphaNumeric_Lette_Equivalence
            End If
        Next

        strCodeNemerique = "NC, NP"
        strCodeNemerique = strCodeNemerique.Replace(" ", "")
        arrayCode = strCodeNemerique.Split(","c)
        For i = 0 To arrayCode.Length - 1
            If strNumero = arrayCode(i) Then
                TypeCDF = EnumTypeCDF.AlphaNumeric_Lette_CIM10
            End If
        Next

        If strNumero = "NN" Then
            TypeCDF = EnumTypeCDF.AlphaNumeric_Orphanet_CIM10
        End If

        If strNumero = "PP" Then
            TypeCDF = EnumTypeCDF.AlphaNumeric_PP
        End If

        If strNumero = "CS" Then
            TypeCDF = EnumTypeCDF.AlphaNumeric_CIM10_CISP
        End If

        If strNumero = "CC" Then
            TypeCDF = EnumTypeCDF.AlphaNumeric_Lettre_CIM10_CISP
        End If

        If strNumero = "EN" Then
            TypeCDF = EnumTypeCDF.AlphaNumeric_CIM10_MEDRA
        End If

        If strNumero = "EN" Then
            TypeCDF = EnumTypeCDF.Numeric_IY
        End If

        If strNumero = "TP" Then
            TypeCDF = EnumTypeCDF.AlphaNumeric_Pere
        End If

        Return TypeCDF
    End Function

    Public Function SetCDF_Codif(ByVal strNumero As String, ByRef ctrl As Control, ByRef ErrProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider, Optional ByRef ctrlPere As Control = Nothing) As Boolean

        Dim TypeCodif As EnumTypeCDF
        Dim strSSQL As String = ""
        Dim dt As DataTable

        TypeCodif = Code_CDF(strNumero)
        Select Case TypeCodif
            '----------------------------------------------------------------
            '----------------------------------------------------------------
            '[BFE] - 06/07/07
            ' Supprimer EnumTypeCDF.Numeric_IY de ce case
            ' Tick 3251
            Case EnumTypeCDF.Numeric_IVO, EnumTypeCDF.Numeric_Equivalence, EnumTypeCDF.Numeric
                '----------------------------------------------------------------
                '----------------------------------------------------------------
                strSSQL = "Select max(cast(CDF_CODE_PK as int)) from THERIAQUE.CDF_CODIF where CDF_NUMERO_PK =" & cn.SQLText(strNumero)
                dt = cn.MySelect(strSSQL)
                ctrl.Tag = "[NOADD][NOEDIT]"
                If dt.Rows(0)(0) IsNot System.DBNull.Value Then
                    ctrl.Text = dt.Rows(0)(0) + 1
                    Ctl_Off(ctrl)
                    ErrProvider.SetError(ctrl, "")
                    Return True
                Else
                    'If Not CType(ctrl, DevExpress.XtraEditors.TextEdit).Properties.ReadOnly Then
                    ctrl.Text = 1
                    'End If
                    Ctl_Off(ctrl)
                    ErrProvider.SetError(ctrl, "")
                    Return True
                End If
                '----------------------------------------------------------------
                '----------------------------------------------------------------
            Case EnumTypeCDF.AlphaNumeric_Lette, EnumTypeCDF.AlphaNumeric_Lette_Equivalence, EnumTypeCDF.AlphaNumeric_Lette_CIM10, EnumTypeCDF.AlphaNumeric_Lettre_CIM10_CISP, EnumTypeCDF.AlphaNumeric_Pere
                '----------------------------------------------------------------
                '----------------------------------------------------------------
                If ctrl.Text.Trim <> "" Then
                    CType(ctrl, DevExpress.XtraEditors.TextEdit).Properties.MaxLength = 0 'Annulation
                    If Trim(ctrl.Text).Length > 1 And (CType(ctrl, DevExpress.XtraEditors.TextEdit).Properties.ReadOnly = False) Then
                        ErrProvider.SetError(ctrl, strUneSeulLettre)
                        ctrl.Select()
                        Return False
                    Else
                        If Char.IsLetter((ctrl.Text)) Then
                            strSSQL = "  select max ( cast(substring(CDF_CODE_PK,2,len(CDF_CODE_PK)-1) as int)) from THERIAQUE.CDF_CODIF"
                            strSSQL &= " where CDF_NUMERO_PK = " & cn.SQLText(strNumero)
                            strSSQL &= " AND CDF_CODE_PK Like '" & ctrl.Text & "%'"
                            dt = cn.MySelect(strSSQL)
                            ctrl.Tag = "[NOEDIT]"
                            If dt.Rows(0)(0) IsNot DBNull.Value Then
                                ctrl.Text &= dt.Rows(0)(0) + 1
                                Ctl_Off(ctrl)
                                ErrProvider.SetError(ctrl, "")
                                Return True
                            Else
                                If Not CType(ctrl, DevExpress.XtraEditors.TextEdit).Properties.ReadOnly Then
                                    'ctrl.Text &= 1
                                End If
                                Ctl_Off(ctrl)
                                ErrProvider.SetError(ctrl, "")
                                Return True
                            End If
                        Else
                            ErrProvider.SetError(ctrl, strPremierCaract)
                            ctrl.Select()
                            Return False
                        End If
                    End If
                Else
                    If TypeOf ctrl Is DevExpress.XtraEditors.TextEdit Then
                        CType(ctrl, DevExpress.XtraEditors.TextEdit).Properties.MaxLength = 1 'Limitation
                        ctrl.Tag = "[EDIT][ADD]"
                    End If
                End If

                If (Not ctrl.Tag.Equals("[EDIT][ADD]")) Then
                    ctrl.Tag = "[NOEDIT][ADD]"
                End If

                '----------------------------------------------------------------
                '----------------------------------------------------------------
                '[BFE] - 06/07/07
                ' Ajouter la condition EnumTypeCDF.Numeric_IY ds ce case
                ' Tick 3251
            Case EnumTypeCDF.AlphaNumeric_Hirch, EnumTypeCDF.AlphaNumeric_Orphanet_CIM10, EnumTypeCDF.AlphaNumeric_CIM10_CISP, EnumTypeCDF.AlphaNumeric_CIM10_MEDRA, EnumTypeCDF.Numeric_IY
                Dim Res As StructResultCode
                Res = Code_PereFils(ctrl, "CDF_CODIF", ErrProvider, True, " CDF_NUMERO_PK = " & cn.SQLText(strNumero))
                If Res._Validation = True Then
                    If ctrlPere IsNot Nothing Then
                        ctrlPere.Text = Res._Code
                        ctrl.Tag = "[NOEDIT]"
                        ErrProvider.SetError(ctrl, "")
                    End If
                Else
                    ctrl.Select()
                End If
                ctrl.Tag = "[NOEDIT][ADD]"
                '----------------------------------------------------------------
                '----------------------------------------------------------------
            Case EnumTypeCDF.AlphaNumeric_PP
                If Code_PP(ctrl, "CDF_CODIF", ErrProvider) Then
                    ctrl.Tag = "[NOEDIT]"
                Else
                    ctrl.Tag = "[EDIT]"
                    ctrl.Select()
                End If
        End Select
    End Function

    Public Function GetMaxByColumn(ByVal gv As DevExpress.XtraGrid.Views.Grid.GridView, ByVal col As DevExpress.XtraGrid.Columns.GridColumn) As Integer

        Dim max As Integer = 0
        For i As Integer = 0 To gv.RowCount - 2
            If gv.GetDataRow(i)(col.FieldName) > max Then

                max = gv.GetDataRow(i)(col.FieldName)

            End If
        Next

        Return max + 1

    End Function

End Module

