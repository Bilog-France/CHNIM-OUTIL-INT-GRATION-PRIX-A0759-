Imports System.IO
Public Class Frm_Categorie

    Protected Friend ModeFiche As eMode = eMode.StandBy
    Private Shared txt As String = ""

    Friend WithEvents CD_TA As Theriaque.dsTheriaqueCategorieTableAdapters.DOC_CATEGORIETableAdapter

    Private Shared verrou As Boolean = True
    Dim tmp As String = ""

    Private Sub Frm_Categorie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.DOC_CATEGORIETableAdapter.Fill(Me.DsTheriaqueCategorie.DOC_CATEGORIE)
        'Me.dnCategorie.Buttons.EndEdit.Enabled = False
        CD_TA.Fill(Me.DsTheriaqueCategorie.DOC_CATEGORIE)
        'dnCategorie.DataSource = Me.gcCategorie.DataSource
        Me.txtLibelle.DataBindings.Add("EditValue", Me.gcCategorie.DataSource, "Libelle")
        Me.txtChemin.DataBindings.Add("EditValue", Me.gcCategorie.DataSource, "Chemin")
        txtChemin.Properties.ReadOnly = True
        txtLibelle.Properties.ReadOnly = True

    End Sub

    Private Sub gcCategorie_EmbeddedNavigator_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles gcCategorie.EmbeddedNavigator.ButtonClick


    End Sub

    Private Sub gcCategorie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gcCategorie.Click, gvCategorie.Click

    End Sub

    Private Sub gvCategorie_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvCategorie.ValidateRow

    End Sub

    Private Sub dnCategorie_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)

        Select Case e.Button.ButtonType

            Case DevExpress.XtraEditors.NavigatorButtonType.Append

                Me.DsTheriaqueCategorie.DOC_CATEGORIE.NewRow()
                Me.txtLibelle.Select()
                'Me.dnCategorie.Buttons.EndEdit.Enabled = True
                txtChemin.Properties.ReadOnly = False
                txtLibelle.Properties.ReadOnly = False

            Case DevExpress.XtraEditors.NavigatorButtonType.EndEdit

                If CreateCategoryDirectory(txtChemin.Text, txtLibelle.Text) Then
                    DOC_CATEGORIETableAdapter.Insert(txtLibelle.Text, txtChemin.Text)
                    'Me.dnCategorie.Buttons.EndEdit.Enabled = False
                    txtChemin.Properties.ReadOnly = True
                    'txtLibelle.Properties.ReadOnly = True
                Else
                    MsgBox("Le dossier de la catégorie existe déja")
                End If

            Case DevExpress.XtraEditors.NavigatorButtonType.Remove

                e.Handled = False
                DOC_CATEGORIETableAdapter.Delete(txtLibelle.Text, txtChemin.Text)

        End Select

    End Sub

    Private Function CreateCategoryDirectory(ByVal path As String, ByVal folder As String) As Boolean

        Dim FullPath As String = path & "\" & folder
        If Not Directory.Exists(FullPath) Then
            Directory.CreateDirectory(FullPath)
            Return True
        Else
            Return False
        End If

    End Function

   

    Private Sub gvCategorie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtChemin_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtChemin.ButtonClick
        Dim FolderBrowserDialog1 As New FolderBrowserDialog
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            ' Display the selected folder if the user clicked on the OK button.
            txtChemin.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAjouter.Click

        Me.DsTheriaqueCategorie.DOC_CATEGORIE.NewRow()
        Me.gvCategorie.AddNewRow()
        Me.txtLibelle.Select()
        btSupprimer.Enabled = False
        btValider.Enabled = True
        btAnnuler.Enabled = True
        btAjouter.Enabled = False
        gcCategorie.Enabled = False
        txtChemin.Properties.ReadOnly = False
        'txtLibelle.Properties.ReadOnly = False

    End Sub

    Private Sub btValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btValider.Click

        If txtLibelle.Text.Trim IsNot Nothing Then


            Dim Err As Boolean = False
            Try
                Me.BindingContext(Me.gcCategorie.DataSource).EndCurrentEdit()
            Catch ex As ConstraintException
                Err = True
            End Try

            If (Err) Then

                MsgBox("Le libellé doit être unique")

            Else

                CreateCategoryDirectory(txtChemin.Text, txtLibelle.Text)
                DOC_CATEGORIETableAdapter.Update(Me.DsTheriaqueCategorie.DOC_CATEGORIE)
                btValider.Enabled = False
                txtChemin.Properties.ReadOnly = True
                btAjouter.Enabled = True
                btAnnuler.Enabled = False
                btSupprimer.Enabled = True
                gcCategorie.Enabled = True

            End If

        Else

            MsgBox("le libellé est obligatoires")

        End If

    End Sub

    Private Sub btSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSupprimer.Click

        Dim doc As New DocumentService.DocumentProvider(strConnexion)
        If (Not doc.CategoryUsed(txtLibelle.Text)) Then

            If MessageBox.Show("Vous voulez vraiement supprimer cette catégorie ?", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                For i As Integer = 0 To Me.DsTheriaqueCategorie.DOC_CATEGORIE.Rows.Count - 1
                    If (Me.DsTheriaqueCategorie.DOC_CATEGORIE.Rows(i)("Libelle").Equals(txtLibelle.Text)) Then
                        Me.DsTheriaqueCategorie.DOC_CATEGORIE.Rows(i).Delete()
                    End If
                Next
                DOC_CATEGORIETableAdapter.Update(Me.DsTheriaqueCategorie.DOC_CATEGORIE)

                btAjouter.Enabled = True
                btAnnuler.Enabled = False
                btValider.Enabled = False
                btSupprimer.Enabled = True

            End If

        Else

            MsgBox("Impossible de supprimer une catégorie utilisée")

        End If

    End Sub

    Private Sub btFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFermer.Click

        Me.Close()

    End Sub

    Private Sub btAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAnnuler.Click

        gvCategorie.CancelUpdateCurrentRow()
        btAjouter.Enabled = True
        gcCategorie.Enabled = True
        btSupprimer.Enabled = True
        btValider.Enabled = False
        btAnnuler.Enabled = False

    End Sub


    Private Sub gvCategorie_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvCategorie.FocusedRowChanged


        txtLibelle.Properties.ReadOnly = False
        txtLibelle.Select()

        btAjouter.Enabled = True
        btSupprimer.Enabled = True
        btValider.Enabled = False
        btAnnuler.Enabled = False

       
    End Sub

    Private Sub txtLibelle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLibelle.TextChanged

        If btValider.Enabled = False Then

            btAjouter.Enabled = False
            btSupprimer.Enabled = False
            btValider.Enabled = True
            btAnnuler.Enabled = True
            'ModeFiche = eMode.Consultation

        End If

    End Sub

    Private Sub txtLibelle_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLibelle.EditValueChanged

    End Sub

    Private Sub txtLibelle_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLibelle.Enter

    End Sub

End Class