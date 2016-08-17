Public Class Frm_Formulaire
    Implements InterfaceFormulaire

    Protected Friend ModeFiche As eMode = eMode.StandBy
    Protected Friend FirstFocus As Control 'Qui va avoir le 1er focus
    Protected Friend MasterDataSet As DataSet
    Protected Friend MasterTable As String
    Protected OnLoading As Boolean = False
    Protected Declinaison_Global As Boolean = False
    Protected IsValider As Boolean = True

#Region " Initialisation des composants "

    Protected Sub Initcomponent(Optional ByVal boolCancel As Boolean = False)
        Dim ctl As Control
        For Each ctl In Me.Controls
            If boolCancel Then
                Me.DxErrorProvider.SetError(ctl, "")
            End If
            EditCtl(ctl)
            If ctl.Controls.Count > 0 Then
                InitComponentChild(ctl, boolCancel)
            End If
        Next
    End Sub

    Private Sub InitComponentChild(ByRef ctl As Control, Optional ByVal boolCancel As Boolean = False)
        Dim ctlChild As Control
        EditCtl(ctl)
        If boolCancel Then
            Me.DxErrorProvider.SetError(ctl, "")
        End If
        If ctl.Controls.Count > 0 Then
            For Each ctlChild In ctl.Controls
                InitComponentChild(ctlChild, boolCancel)
            Next
        End If
    End Sub

    Private Sub EditCtl(ByRef Ctl As Control)
        If TypeOf Ctl Is DevExpress.XtraTab.XtraTabControl Then
            If CType(Ctl, DevExpress.XtraTab.XtraTabControl).HeaderAutoFill = DevExpress.Utils.DefaultBoolean.False Then
                CType(Ctl, DevExpress.XtraTab.XtraTabControl).HeaderAutoFill = DevExpress.Utils.DefaultBoolean.True
            End If
        End If
        If ModeFiche = eMode.StandBy Then
            AddEvenement(Ctl)
        End If
        UpdateModeFiche(Ctl)
    End Sub

    ''' <summary>
    ''' Enumèrer les compostants pour ajouter leurs les évènement
    ''' </summary>
    ''' <param name="Ctl">Le contrôle en cours</param>
    ''' <remarks></remarks>
    Private Sub AddEvenement(ByRef Ctl As Control)
        If TypeOf Ctl Is DevExpress.XtraEditors.TextEdit Then
            AddHandler Ctl.KeyUp, AddressOf TextEditKeyUp
            If Ctl.DataBindings("EditValue") IsNot Nothing Then
                AddHandler CType(Ctl, DevExpress.XtraEditors.TextEdit).EditValueChanged, AddressOf EditValueChanged
            End If
        End If

        If TypeOf Ctl Is DevExpress.XtraEditors.MemoEdit Then
            If Ctl.DataBindings("EditValue") IsNot Nothing Then
                AddHandler CType(Ctl, DevExpress.XtraEditors.MemoEdit).EditValueChanged, AddressOf EditValueChanged
            End If
            AddHandler CType(Ctl, DevExpress.XtraEditors.MemoEdit).KeyUp, AddressOf MemoEdit_KeyUp
        End If
        If (TypeOf Ctl Is DevExpress.XtraEditors.TextEdit) Then
            AddHandler CType(Ctl, DevExpress.XtraEditors.TextEdit).KeyUp, AddressOf TextEdit_KeyUp
        End If

        If TypeOf Ctl Is DevExpress.XtraEditors.LookUpEdit Then
            AddHandler CType(Ctl, DevExpress.XtraEditors.LookUpEdit).KeyUp, AddressOf LookUpEdit_KeyUp
        End If

        If TypeOf Ctl Is DevExpress.XtraEditors.CheckEdit Then
            If Ctl.DataBindings("EditValue") IsNot Nothing Then
                AddHandler CType(Ctl, DevExpress.XtraEditors.CheckEdit).EditValueChanged, AddressOf EditValueChanged
            End If
        End If

        If TypeOf Ctl Is DevExpress.XtraGrid.GridControl Then
            If TypeOf CType(Ctl, DevExpress.XtraGrid.GridControl).MainView Is DevExpress.XtraGrid.Views.Grid.GridView Then
                AddHandler Ctl.KeyUp, AddressOf GC_KeyUp
                AddHandler CType(Ctl, DevExpress.XtraGrid.GridControl).MainView.RowCountChanged, AddressOf GVRowCountChanged
                AddHandler CType(CType(Ctl, DevExpress.XtraGrid.GridControl).MainView, DevExpress.XtraGrid.Views.Grid.GridView).RowUpdated, AddressOf GVRowUpdated
                AddHandler CType(CType(Ctl, DevExpress.XtraGrid.GridControl).MainView, DevExpress.XtraGrid.Views.Grid.GridView).InvalidRowException, AddressOf GVInvalidRowException

                Dim r As Object 'DevExpress.XtraEditors.Repository.RepositoryItem
                For Each r In CType(Ctl, DevExpress.XtraGrid.GridControl).RepositoryItems
                    If (TypeOf r Is DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit) Then
                        AddHandler CType(r, DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).KeyUp, AddressOf Repositeries_KeyUp
                        AddHandler CType(r, DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).KeyDown, AddressOf Repositeries_KeyDown
                    End If
                    If (TypeOf r Is DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit) Or (TypeOf r Is DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit) Then
                        AddHandler CType(r, DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit).KeyUp, AddressOf RepositeriesMemo_KeyUp
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub LookUpEdit_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If CInt(e.KeyCode) = eKeyPressed.KeyDeletelkup Then
            If sender.ToString = "DevExpress.XtraEditors.LookUpEdit" Then
                Try
                    sender.editvalue = ""
                Catch ex As Exception

                End Try

            End If
        End If
    End Sub
    Private Sub MemoEdit_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If CInt(e.KeyCode) = eKeyPressed.KeyPreditive Then
            Dim F As New Frm_Edit
            F.Memo.Text = sender.Text
            F.ShowDialog()
            sender.Text = F.Memo.Text
            F.Dispose()
        End If
    End Sub
    ''' <summary>
    ''' Lancer la saisie prédictive pour les répositeries
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Repositeries_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim rp As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        rp = CType(sender.tag, DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)
        If e.KeyCode = Keys.Delete Then
            sender.editvalue = Nothing
        End If
        If sender.tag IsNot Nothing Then
            Dim txtTag As StructTxtProperty = rp.Tag
            If CInt(e.KeyCode) = eKeyPressed.KeyPreditive Then
                Dim f As New Frm_Dictionnaire
                f._SSQL = txtTag.LookUpSSQL
                f.txtSearch.Text = NNT(sender.editvalue)
                f._SearchOnlyFirst = txtTag.boolOnlyFirst
                f.ShowDialog()
                If f._Libelle <> "" And f._Libelle <> Nothing Then
                    sender.editvalue = f._Code
                End If
            End If
            ''-----------------------------------------
            '' Declinaison Globale
            ''-----------------------------------------
            If CInt(e.KeyCode) = eKeyPressed.KeyDeclinaisonGlobale And Declinaison_Global Then
                If txtTag.Declinaison IsNot Nothing Then
                    Select Case txtTag.Declinaison.Start
                        Case eDeclinaison.CCH
                            DeclinaisonCCH_Globale(Me, rp.Tag)
                        Case eDeclinaison.CPH
                            DeclinaisonCPH_Globale(Me, rp.Tag)
                        Case eDeclinaison.SAC
                            DeclinaisonSAC_Globale(Me, rp.Tag)
                        Case eDeclinaison.SAU
                            DeclinaisonSAU_Globale(Me, rp.Tag)
                        Case eDeclinaison.PR
                            DeclinaisonPR_Globale(Me, rp.Tag)
                        Case eDeclinaison.SP
                            DeclinaisonSP_Globale(Me, rp.Tag)
                    End Select
                End If
            End If
            ''-----------------------------------------
            '' Declinaison Classique
            ''-----------------------------------------
            If CInt(e.KeyCode) = eKeyPressed.KeyDeclinaisonClassique Then
                If txtTag.Declinaison IsNot Nothing Then
                    Select Case txtTag.Declinaison.Start
                        Case eDeclinaison.CCH
                            DeclinaisonCCH_Classique(Me, rp.Tag)
                        Case eDeclinaison.CPH
                            DeclinaisonCPH_Classique(Me, rp.Tag)
                        Case eDeclinaison.SAC
                            DeclinaisonSAC_Classique(Me, rp.Tag)
                        Case eDeclinaison.SAU
                            DeclinaisonSAU_Classique(Me, rp.Tag)
                        Case eDeclinaison.PR
                            DeclinaisonPR_Classique(Me, rp.Tag)
                        Case eDeclinaison.SP
                            DeclinaisonSP_Globale(Me, rp.Tag)
                        Case eDeclinaison.ATC
                            DeclinaisonATC_Classique(Me, rp.Tag)
                    End Select
                End If
            End If
        End If
    End Sub
    ''' <summary>
    ''' Lancer la saisie prédictive pour les répositeries
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RepositeriesMemo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim rp2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        rp2 = CType(sender.tag, DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit)
        If CInt(e.KeyCode) = eKeyPressed.KeyPreditive Then
            Dim F As New Frm_Edit
            F.Memo.Text = sender.Text
            If rp2.Name = "RpMemoEditVille" Or rp2.Name = "RpMemoEditHop" Then
                F.Memo.Properties.MaxLength = 255
            End If

            F.ShowDialog()
            sender.Text = F.Memo.Text
            F.Dispose()
        End If
    End Sub

    ''' <summary>
    ''' Lancer la saisie prédictive pour les répositeries
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TextEdit_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If sender.ToString = "DevExpress.XtraEditors.TextEdit" Then
            Dim rp2 As DevExpress.XtraEditors.TextEdit
            rp2 = CType(sender, DevExpress.XtraEditors.TextEdit)
            If CInt(e.KeyCode) = eKeyPressed.KeyPreditive Then
                Dim F As New Frm_Edit
                F.Memo.Text = sender.Text
                F.ShowDialog()
                sender.Text = F.Memo.Text
                F.Dispose()
            End If
        End If
    End Sub


    ''' <summary>
    ''' Lancer la saisie prédictive pour les répositories
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Repositeries_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim rp As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        rp = CType(sender.tag, DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)

        If sender.tag IsNot Nothing Then
            If (e.Control And e.Shift And e.Alt) Then
                Dim txtTag As StructTxtProperty = rp.Tag
                MsgBox(Separ() & vbLf & "Table: " & txtTag.LookUpTable & Separ() & vbLf & "Valeur : " & sender.EditValue & Separ(), MsgBoxStyle.Information, "Liste")
            End If
        End If
    End Sub

    Protected Friend Sub EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If OnLoading Then Exit Sub

        If ModeFiche = eMode.Consultation Then 'Seulement mode consultation

            If sender.DataBindings("EditValue") Is Nothing Then Exit Sub
            If MasterDataSet Is Nothing Then Exit Sub
            Dim DataField As String = sender.DataBindings("EditValue").BindingMemberInfo.BindingField()
            Dim DataTable As String = sender.DataBindings("EditValue").BindingMemberInfo.BindingPath
            Try
                If Me.BindingContext(MasterDataSet, DataTable).Count = 0 Then
                    'Me.BindingContext(Me.MasterDataSet, DataTable).AddNew()
                    Exit Sub
                End If

            Catch ex As Exception
                Exit Sub
            End Try
            

            If (Not String.IsNullOrEmpty(DataTable)) Then

                If Me.BindingContext(MasterDataSet, DataTable).Current(DataField) Is DBNull.Value Then
                    If sender.editvalue Is DBNull.Value Then
                        'même valeur
                    Else
                        ModeFiche = eMode.Modification
                        UpdateStateBouton()
                    End If
                Else
                    If sender.editvalue IsNot DBNull.Value Then
                        ModeFiche = eMode.Modification
                        UpdateStateBouton()
                    Else
                        'If sender.editvalue <> Me.BindingContext(MasterDataSet, MasterTable).Current(DataField) Then
                        '    ModeFiche = eMode.Modification
                        '    UpdateStateBouton()
                        'Else
                        'End If
                    End If
                End If

            End If

        End If

    End Sub

#End Region

    Private Sub GVRowCountChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If OnLoading Then Exit Sub
        If ModeFiche = eMode.Consultation Then
            ModeFiche = eMode.Modification
            UpdateStateBouton()
        End If
    End Sub

    Private Sub GVRowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs)
        If OnLoading Then Exit Sub
        If ModeFiche = eMode.Consultation Then
            ModeFiche = eMode.Modification
            UpdateStateBouton()
        End If
    End Sub

    ''' <summary>
    ''' Evénement: Capter l'erreur dans la grille pour empécher l'affichage des messages Box
    ''' </summary>
    ''' <param name="sender"> Grid view</param>
    ''' <param name="e">InvalidRowExceptionEventArgs</param>
    ''' <remarks>
    ''' Cette fonction affiche l'erreur avec l'indice Rouge dans la première colonne.
    ''' </remarks>
    Private Sub GVInvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs)
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        Dim GV As DevExpress.XtraGrid.Views.Grid.GridView = sender
        GV.SetColumnError(GV.FocusedColumn, e.ErrorText, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning)
    End Sub

    ''' <summary>
    ''' Evénement KeyUp pour tous les grilles
    ''' F8 lance la fiche dictionnaire si la colonne contient un repositeries
    ''' </summary>
    ''' <param name="sender">Grid controle</param>
    ''' <param name="e">KeyEventArgs</param>
    ''' <remarks></remarks>
    Private Sub GC_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim GC As DevExpress.XtraGrid.GridControl = sender
        Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(GC, DevExpress.XtraGrid.GridControl).MainView

        Dim txtTag As StructTxtProperty

        If gv.FocusedColumn Is Nothing Then Exit Sub
        If gv.FocusedColumn.ColumnEdit Is Nothing Then Exit Sub
        If gv.FocusedColumn.ColumnEdit.Tag Is Nothing Then Exit Sub

        If CInt(e.KeyCode) = eKeyPressed.KeyPreditive Then
            txtTag = gv.FocusedColumn.ColumnEdit.Tag
            Dim f As New Frm_Dictionnaire
            f._SSQL = txtTag.LookUpSSQL
            f.txtSearch.Text = gv.GetRowCellDisplayText(gv.FocusedRowHandle, gv.FocusedColumn)
            f.ShowDialog()
            If f._Libelle <> "" And f._Libelle <> Nothing Then
                gv.SetRowCellValue(gv.FocusedRowHandle, gv.FocusedColumn, f._Code)
            End If
        End If
    End Sub

    Private Function GetSACFromGV(ByVal gv As DevExpress.XtraGrid.Views.Grid.GridView) As Collection
        Dim Coll As New Collection
        For intI As Integer = 0 To gv.RowCount - 1
            Coll.Add(gv.GetRowCellValue(intI, "SAC_CODE_SQ_PK"))
        Next
        Return Coll
    End Function

    Private Sub TextEditKeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim txtTag As StructTxtProperty
        Dim txtControl As New DevExpress.XtraEditors.TextEdit
        txtControl = sender
        '---------------------------------------------------------
        ' Lancement de la saisie predictive
        ' Dictionnaire
        '---------------------------------------------------------
        If CInt(e.KeyCode) = eKeyPressed.KeyPreditive Then
            If Not txtControl.Tag Is Nothing Then
                If TypeOf txtControl.Tag Is String Then Exit Sub
                txtTag = txtControl.Tag
                Dim f As New Frm_Dictionnaire
                f._strTable = txtTag.LookUpTable
                f._SSQL = txtTag.LookUpSSQL
                f._boolAfficheColNum = txtTag.boolAfficheColNum
                f.txtSearch.Text = txtControl.Text
                f.ShowDialog()
                If f._Libelle <> "" And f._Libelle <> Nothing Then
                    txtControl.EditValue = f._Code
                End If
                e.SuppressKeyPress = True
                e = Nothing
                Exit Sub
            Else
                If TypeOf txtControl.Parent.Tag Is String Then Exit Sub
                txtTag = txtControl.Parent.Tag
                If TypeOf txtControl.Parent.Tag Is String Or txtControl.Parent.Tag Is Nothing Then Exit Sub
                Dim f As New Frm_Dictionnaire
                f._strTable = txtTag.LookUpTable
                f._SSQL = txtTag.LookUpSSQL
                f.txtSearch.Text = txtControl.Text
                f.ShowDialog()
                If f._Libelle <> "" And f._Libelle <> Nothing Then
                    txtControl.Text = f._Libelle
                End If
                e.SuppressKeyPress = True
                Exit Sub
            End If
        End If
        '---------------------------------------------------------
        '---------------------------------------------------------
        If e.KeyCode = Keys.Enter Then

        End If

        'If e.KeyCode = Keys.Delete Then
        '    sender.editvalue = Nothing
        'End If
    End Sub

    Private Function Separ(Optional ByVal Enter As Boolean = True) As String
        If Enter Then
            Return vbLf & "__________________________________________"
        Else
            Return "__________________________________________"
        End If
    End Function

    ''' <summary>
    ''' Afficher dans un message les propriétès de l'édit contrôl
    ''' </summary>
    ''' <param name="sender">Le control</param>
    ''' <param name="e"></param>
    ''' <remarks>KeyEventArgs</remarks>
    Private Sub Frm_Formulaire_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        '
        ' YFO
        Try
            If (e.Control And e.Shift And e.Alt) Then
                If TypeOf (Me.ActiveControl) Is DevExpress.XtraEditors.LookUpEdit Then
                    Dim Lookup As DevExpress.XtraEditors.LookUpEdit
                    Lookup = Me.ActiveControl
                    MsgBox(Separ(False) & vbLf & "Table: " & Lookup.DataBindings("EditValue").BindingMemberInfo.BindingPath & Separ() & vbLf & "Champ : " & Lookup.DataBindings("EditValue").BindingMemberInfo.BindingField & Separ() & vbLf & "Texte affiché : " & Lookup.Text & Separ() & vbLf & "Valeur : " & Lookup.EditValue & Separ(), MsgBoxStyle.Information)
                End If
                If TypeOf (Me.ActiveControl.Parent) Is DevExpress.XtraEditors.TextEdit Then
                    Dim Lookup As DevExpress.XtraEditors.TextEdit
                    Lookup = Me.ActiveControl.Parent
                    MsgBox(Separ() & vbLf & "Table: " & Lookup.DataBindings("EditValue").BindingMemberInfo.BindingPath & Separ() & vbLf & "Champ : " & Lookup.DataBindings("EditValue").BindingMemberInfo.BindingField & Separ() & vbLf & "Texte affiché : " & Lookup.Text & Separ() & vbLf & "Valeur : " & Lookup.EditValue & Separ(), MsgBoxStyle.Information)
                    Exit Sub
                End If
                If TypeOf (Me.ActiveControl) Is DevExpress.XtraEditors.ComboBoxEdit Then
                    Dim Lookup As DevExpress.XtraEditors.ComboBoxEdit
                    Lookup = Me.ActiveControl
                    MsgBox(Separ() & vbLf & "Table: " & Lookup.DataBindings("EditValue").BindingMemberInfo.BindingPath & Separ() & vbLf & "Champ : " & Lookup.DataBindings("EditValue").BindingMemberInfo.BindingField & Separ() & vbLf & "Texte affiché : " & Lookup.Text & Separ() & vbLf & "Valeur : " & Lookup.EditValue & Separ(), MsgBoxStyle.Information)
                    Exit Sub
                End If
                If TypeOf (Me.ActiveControl) Is DevExpress.XtraEditors.SpinEdit Then
                    Dim Lookup As DevExpress.XtraEditors.SpinEdit
                    Lookup = Me.ActiveControl
                    MsgBox(Separ() & vbLf & "Table: " & Lookup.DataBindings("EditValue").BindingMemberInfo.BindingPath & Separ() & vbLf & "Champ : " & Lookup.DataBindings("EditValue").BindingMemberInfo.BindingField & Separ() & vbLf & "Texte affiché : " & Lookup.Text & Separ() & vbLf & "Valeur : " & Lookup.EditValue & Separ(), MsgBoxStyle.Information)
                    Exit Sub
                End If
                If TypeOf (Me.ActiveControl.Parent) Is DevExpress.XtraEditors.MemoEdit Then
                    Dim Lookup As DevExpress.XtraEditors.MemoEdit
                    Lookup = Me.ActiveControl.Parent
                    MsgBox(Separ() & vbLf & "Table: " & Lookup.DataBindings("EditValue").BindingMemberInfo.BindingPath & Separ() & vbLf & "Champ : " & Lookup.DataBindings("EditValue").BindingMemberInfo.BindingField & Separ() & vbLf & "Texte affiché : " & Lookup.Text & Separ() & vbLf & "Valeur : " & Lookup.EditValue & Separ(), MsgBoxStyle.Information)
                End If
                If TypeOf (Me.ActiveControl) Is DevExpress.XtraEditors.TextBoxMaskBox Then
                    Dim Lookup As DevExpress.XtraEditors.TextBoxMaskBox
                    Lookup = Me.ActiveControl
                    MsgBox(Separ() & vbLf & "Table: " & Lookup.DataBindings("EditValue").BindingMemberInfo.BindingPath & Separ() & vbLf & "Champ : " & Lookup.DataBindings("EditValue").BindingMemberInfo.BindingField & Separ() & vbLf & "Texte affiché : " & Lookup.MaskBoxText & Separ() & vbLf & "Valeur : " & Lookup.EditValue & Separ(), MsgBoxStyle.Information)
                End If
            End If
            If CInt(e.KeyCode) = eKeyPressed.KeyQuite Then
                If btFermer.Enabled = True Then
                    btFermer_Click(btFermer, Nothing)
                End If
            End If
            If CInt(e.KeyCode) = eKeyPressed.KeyValidate Then
                If btValider.Enabled = True Then
                    btValider_Click(btFermer, Nothing)
                End If
            End If
            If CInt(e.KeyCode) = eKeyPressed.KeyAdd Then
                If btAjouter.Enabled = True Then
                    btAjouter_Click(btFermer, Nothing)
                End If
            End If
            If CInt(e.KeyCode) = eKeyPressed.KeyCancel Then
                If btAnnuler.Enabled = True Then
                    btAnnuler_Click(btFermer, Nothing)
                End If
            End If
            If (CInt(e.KeyCode) = eKeyPressed.KeyDelete) Then
                If btSupprimer.Enabled = True Then
                    btSupprimer_Click(btFermer, Nothing)
                End If
            End If
            If (CInt(e.KeyCode) = eKeyPressed.KeyPreditive) And (e.Shift) Then
                If btChercher.Enabled = True Then
                    btChercher_Click(btFermer, Nothing)
                End If
            End If
            If (CInt(e.KeyCode) = eKeyPressed.KeyDupliquer) Then
                If btDupliquer.Enabled = True Then
                    btDupliquer_Click(btFermer, Nothing)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub Frm_Formulaire_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ModeFiche = eMode.StandBy
        Initcomponent()
        UpdateStateBouton()
        InitData()
    End Sub

#Region " Mise à jour des données    "

    Public Overridable Sub Ajouter() Implements ModInterface.InterfaceFormulaire.Ajouter
        DateEdit2.EditValue = Now.Date
        DateEdit2.DateTime = Now.Date

    End Sub

    Public Overridable Function Chercher() As Boolean Implements ModInterface.InterfaceFormulaire.Chercher

    End Function

    Public Overridable Function ChercherAvance() As Boolean Implements ModInterface.InterfaceFormulaire.ChercherAvance

    End Function

    Public Overridable Function Supprimer() As Boolean Implements ModInterface.InterfaceFormulaire.Supprimer

    End Function

    Public Overridable Sub Valider() Implements ModInterface.InterfaceFormulaire.Valider
        DateEdit1.EditValue = Now.Date
        DateEdit1.DateTime = Now.Date
        'DateEdit2.EditValue = Now.Date
        'DateEdit2.DateTime = Now.Date
    End Sub

    Public Overridable Sub Annuler() Implements ModInterface.InterfaceFormulaire.Annuler

    End Sub

    Public Overridable Sub Fermer() Implements ModInterface.InterfaceFormulaire.Fermer

    End Sub
    Public Overridable Function SpecialiteCommune() As Boolean Implements ModInterface.InterfaceFormulaire.SpecialiteCommune

    End Function

    Public Overridable Sub Dupliquer() Implements ModInterface.InterfaceFormulaire.Dupliquer
        DateEdit2.EditValue = Now.Date
        DateEdit2.DateTime = Now.Date


    End Sub
    Public Overridable Function ChercherMultiCriteres() As Boolean Implements ModInterface.InterfaceFormulaire.ChercherMultiCriteres

    End Function
    #End Region

#Region " Mise à jour de l'interface "

    Protected Friend Overridable Sub btAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAjouter.Click
        ModeFiche = eMode.Ajout
        UpdateStateBouton()
        Ajouter()
        Initcomponent()
        If FirstFocus IsNot Nothing Then
            FirstFocus.Select()
        End If
    End Sub

    Protected Friend Overridable Sub btSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSupprimer.Click
        Try
            If Process_Message(strSupprimer, MsgBoxStyle.YesNo, MsgBoxStyle.Question).BtResult = MsgBoxResult.Yes Then
                If Supprimer() Then
                    ModeFiche = eMode.Suppression
                    UpdateStateBouton()
                    Initcomponent()
                Else
                End If
            End If
        Catch ex As Exception
            Process_Message(ex.Message, MsgBoxStyle.OkOnly, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Protected Friend Overridable Sub btValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btValider.Click
        Try
            If ValideControl() Then
                If Process_Message(strValider, MsgBoxStyle.YesNo, MsgBoxStyle.Question).BtResult = MsgBoxResult.Yes Then
                    Valider()
                    If (IsValider) Then
                        ModeFiche = eMode.Consultation
                        UpdateStateBouton()
                        Initcomponent()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, Nothing, False)
        End Try
    End Sub

    Protected Friend Overridable Sub btAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAnnuler.Click
        If ModeFiche = eMode.Ajout Or ModeFiche = eMode.Duplication Then
            Annuler()
            ModeFiche = eMode.Vide
            Initcomponent(True)
            UpdateStateBouton()
        Else
            Annuler()
            ModeFiche = eMode.Consultation
            UpdateStateBouton()
            Initcomponent(True)
        End If
    End Sub

    Protected Friend Overridable Sub btChercher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btChercher.Click
        Load_On(Me)
        If ModeFiche = eMode.StandBy Then
            If Chercher() Then
                ModeFiche = eMode.Consultation
                UpdateStateBouton()
                Initcomponent()
            Else
                ModeFiche = eMode.StandBy
            End If
        Else
            ModeFiche = eMode.Recherche 'Empecher le declenchement de EditValue
            If Chercher() Then
                ModeFiche = eMode.Consultation
                UpdateStateBouton()
                Initcomponent()
            Else
                ModeFiche = eMode.Consultation
            End If
        End If
        Load_Off(Me)
    End Sub

    Protected Friend Overridable Sub btFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFermer.Click
        Me.Close()
        Fermer()
    End Sub
    Protected Friend Overridable Sub btDupliquer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDupliquer.Click
        ModeFiche = eMode.Duplication
        UpdateStateBouton()
        Dupliquer()
        Initcomponent()
        If FirstFocus IsNot Nothing Then
            FirstFocus.Select()
        End If
    End Sub


    Protected Sub UpdateStateBouton()
        Select Case ModeFiche
            Case eMode.Ajout
                Me.btAjouter.Enabled = False
                Me.btDupliquer.Enabled = False
                Me.btAnnuler.Enabled = True
                Me.btChercher.Enabled = False
                Me.btAdvancedSearch.Enabled = False
                Me.btn_RechMulti.Enabled = False
                Me.btSupprimer.Enabled = False
                Me.btValider.Enabled = True
                Me.btFermer.Enabled = False
            Case eMode.Consultation
                Me.btAjouter.Enabled = True
                Me.btDupliquer.Enabled = True
                Me.btAnnuler.Enabled = False
                Me.btChercher.Enabled = True
                Me.btAdvancedSearch.Enabled = True
                Me.btn_RechMulti.Enabled = True
                Me.btSupprimer.Enabled = True
                Me.btValider.Enabled = False
                Me.btFermer.Enabled = True
                If FirstFocus IsNot Nothing Then
                    FirstFocus.Select()
                End If
            Case eMode.Modification
                Me.btAjouter.Enabled = False
                Me.btDupliquer.Enabled = True
                Me.btAnnuler.Enabled = True
                Me.btChercher.Enabled = False
                Me.btAdvancedSearch.Enabled = False
                Me.btn_RechMulti.Enabled = False
                Me.btSupprimer.Enabled = False
                Me.btValider.Enabled = True
                Me.btFermer.Enabled = False
            Case eMode.Recherche
            Case eMode.StandBy
                Me.btAjouter.Enabled = True
                Me.btDupliquer.Enabled = False
                Me.btAnnuler.Enabled = False
                Me.btChercher.Enabled = True
                Me.btAdvancedSearch.Enabled = True
                Me.btn_RechMulti.Enabled = True
                Me.btSupprimer.Enabled = False
                Me.btValider.Enabled = False
                Me.btFermer.Enabled = True
                Me.btAjouter.Select()
            Case eMode.Suppression
                Me.btAjouter.Enabled = True
                Me.btDupliquer.Enabled = False
                Me.btAnnuler.Enabled = False
                Me.btChercher.Enabled = True
                Me.btAdvancedSearch.Enabled = True
                Me.btn_RechMulti.Enabled = True
                Me.btSupprimer.Enabled = False
                Me.btValider.Enabled = False
                Me.btFermer.Enabled = True
            Case eMode.Vide
                Me.btAjouter.Enabled = True
                Me.btDupliquer.Enabled = False
                Me.btAnnuler.Enabled = False
                Me.btChercher.Enabled = True
                Me.btAdvancedSearch.Enabled = True
                Me.btn_RechMulti.Enabled = True
                Me.btSupprimer.Enabled = False
                Me.btValider.Enabled = False
                Me.btFermer.Enabled = True
                Me.btAjouter.Select()
            Case eMode.Duplication
                Me.btAjouter.Enabled = False
                Me.btDupliquer.Enabled = False
                Me.btAnnuler.Enabled = True
                Me.btChercher.Enabled = False
                Me.btAdvancedSearch.Enabled = False
                Me.btn_RechMulti.Enabled = False
                Me.btSupprimer.Enabled = False
                Me.btValider.Enabled = True
                Me.btFermer.Enabled = False
        End Select
    End Sub

    Private Sub UpdateModeFiche(ByRef Ctl As Control)
        Select Case ModeFiche
            Case eMode.Ajout
                If TypeOf Ctl.Tag Is String Then
                    If CStr(Ctl.Tag).IndexOf("[ADD]") >= 0 Then
                        Ctl_On(Ctl)
                    ElseIf CStr(Ctl.Tag).IndexOf("[NOADD]") >= 0 Then
                        Ctl_Off(Ctl)
                    ElseIf CStr(Ctl.Tag).IndexOf("[EDIT]") >= 0 Then
                        Ctl_On(Ctl)
                    ElseIf CStr(Ctl.Tag).IndexOf("[NOEDIT]") >= 0 Then
                        Ctl_Off(Ctl)
                    End If
                    'If CStr(Ctl.Tag).IndexOf("[EDIT]") >= 0 Then
                    '    Ctl_On(Ctl)
                    'End If
                    'If CStr(Ctl.Tag).IndexOf("[NOEDIT]") >= 0 Then
                    '    Ctl_Off(Ctl)
                    'End If
                End If
            Case eMode.Modification
                If TypeOf Ctl.Tag Is String Then
                    If CStr(Ctl.Tag).IndexOf("[EDIT]") >= 0 Then
                        Ctl_On(Ctl)
                    End If
                    If CStr(Ctl.Tag).IndexOf("[NOEDIT]") >= 0 Then
                        Ctl_Off(Ctl)
                    End If
                End If
            Case eMode.Recherche
                If TypeOf Ctl.Tag Is String Then
                    If CStr(Ctl.Tag).IndexOf("[EDIT]") >= 0 Then
                        Ctl_Off(Ctl)
                    End If
                End If
            Case eMode.StandBy
                If TypeOf Ctl.Tag Is String Then
                    If CStr(Ctl.Tag).IndexOf("[EDIT]") >= 0 Then
                        Ctl_Off(Ctl)
                    End If
                    If CStr(Ctl.Tag).IndexOf("[NOEDIT]") >= 0 Then
                        Ctl_Off(Ctl)
                    End If
                    If CStr(Ctl.Tag).IndexOf("[NOADD]") >= 0 Then
                        Ctl_Off(Ctl)
                    End If
                End If
            Case eMode.Suppression
                If TypeOf Ctl.Tag Is String Then
                    If CStr(Ctl.Tag).IndexOf("[EDIT]") >= 0 Then
                        Ctl_On(Ctl)
                    End If
                End If
            Case eMode.Vide
                If TypeOf Ctl.Tag Is String Then
                    If CStr(Ctl.Tag).IndexOf("[EDIT]") >= 0 Then
                        Ctl_Off(Ctl)
                    End If
                End If
            Case eMode.Consultation
                If TypeOf Ctl.Tag Is String Then
                    If CStr(Ctl.Tag).IndexOf("[NOADD]") >= 0 Then
                        Ctl_Off(Ctl)
                    End If
                    If CStr(Ctl.Tag).IndexOf("[EDIT]") >= 0 Then
                        Ctl_On(Ctl)
                    End If
                    If CStr(Ctl.Tag).IndexOf("[NOEDIT]") >= 0 Then
                        Ctl_Off(Ctl)
                    End If
                End If
            Case eMode.Duplication
                If TypeOf Ctl.Tag Is String Then
                    If CStr(Ctl.Tag).IndexOf("[ADD]") >= 0 Then
                        Ctl_On(Ctl)
                    ElseIf CStr(Ctl.Tag).IndexOf("[NOADD]") >= 0 Then
                        Ctl_Off(Ctl)
                    ElseIf CStr(Ctl.Tag).IndexOf("[EDIT]") >= 0 Then
                        Ctl_On(Ctl)
                    ElseIf CStr(Ctl.Tag).IndexOf("[NOEDIT]") >= 0 Then
                        Ctl_Off(Ctl)
                    End If
                End If
        End Select
    End Sub

    Protected Friend Overridable Function ValideControl(Optional ByRef Ctrl As Control = Nothing, Optional ByVal AllCtrl As Boolean = True) As Boolean
        If Ctrl Is Nothing Then
            Ctrl = New Control
            Ctrl.Name = InvalideControl
            ValideControl = True
        End If
    End Function

#End Region

    Public Overridable Sub InitData()

    End Sub

    Protected Friend Overridable Sub btAdvancedSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdvancedSearch.Click
        Load_On(Me)
        If ModeFiche = eMode.StandBy Then
            If ChercherAvance() Then
                ModeFiche = eMode.Consultation
                UpdateStateBouton()
                Initcomponent()
            Else
                ModeFiche = eMode.StandBy
            End If
        Else
            ModeFiche = eMode.Recherche 'Empecher le declenchement de EditValue
            If ChercherAvance() Then
                ModeFiche = eMode.Consultation
                UpdateStateBouton()
                Initcomponent()
            Else
                ModeFiche = eMode.Consultation
            End If
        End If
        Load_Off(Me)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ConInfo.Server = "91.121.210.105,8008" Then
            If PictureWarning.Visible Then
                PictureWarning.Visible = False
            Else
                PictureWarning.Visible = True
            End If
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Frm_Formulaire_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        PictureWarning.Left = Me.Width - 38
    End Sub

    Private Sub btn_specialiteCommune_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_specialiteCommune.Click
        Load_On(Me)
        If ModeFiche = eMode.StandBy Then
            If SpecialiteCommune() Then
                ModeFiche = eMode.Consultation
                UpdateStateBouton()
                Initcomponent()
            Else
                ModeFiche = eMode.StandBy
            End If
        Else
            ModeFiche = eMode.Recherche 'Empecher le declenchement de EditValue
            If SpecialiteCommune() Then
                ModeFiche = eMode.Consultation
                UpdateStateBouton()
                Initcomponent()
            Else
                ModeFiche = eMode.Consultation
            End If
        End If
        Load_Off(Me)

    End Sub

    Private Sub btn_RechMulti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RechMulti.Click
        Load_On(Me)
        If ModeFiche = eMode.StandBy Then
            If ChercherMultiCriteres() Then
                ModeFiche = eMode.Consultation
                UpdateStateBouton()
                Initcomponent()
            Else
                ModeFiche = eMode.StandBy
            End If
        Else
            ModeFiche = eMode.Recherche 'Empecher le declenchement de EditValue
            If ChercherMultiCriteres() Then
                ModeFiche = eMode.Consultation
                UpdateStateBouton()
                Initcomponent()
            Else
                ModeFiche = eMode.Consultation
            End If
        End If
        Load_Off(Me)

    End Sub
End Class
