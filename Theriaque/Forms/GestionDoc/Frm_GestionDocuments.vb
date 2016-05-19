Public Class Frm_GestionDocuments

    Private doc As DocumentService.DocumentProvider
    Private WithEvents ucApercu1 As UcApercu

    Dim InLoading As Boolean

    Private Sub Frm_GestionDocuments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        InitData()

    End Sub

    Private Sub ucApercu1_ImDeleting() Handles ucApercu1.ImDeleting

        If (gvDocuments.FocusedRowHandle >= 0) Then
            gvDocuments.DeleteRow(gvDocuments.FocusedRowHandle)
            ucApercu1.doc = Me.gvDocuments.GetRow(gvDocuments.FocusedRowHandle)
            ucApercu1.UpdateApercu()
        End If

    End Sub

    Private Sub InitData()

        InLoading = True
        ucApercu1 = New UcApercu
        ucApercu1.Dock = DockStyle.Fill
        Me.PanApercu.Controls.Add(ucApercu1)
        Dim aDoc As New ArrayList()
        doc = New DocumentService.DocumentProvider(cn.sConnexion)

        Dim dt As New DataTable
        dt = doc.GetAllCategories()
        Me.lueCategorie.Properties.DataSource = dt
        Try
            aDoc = doc.GetAllDoc()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If (gvDocuments.RowCount > 0) Then
            Me.lueCategorie.DataBindings.Add("EditValue", gcDocuments.DataSource, "ID_Categorie")
        End If
       
        'Dim thGetAll As New System.Threading.Thread(AddressOf ucApercu1.UpdateApercu)
        'Dim wd As New DevExpress.Utils.WaitDialogForm
        ''wd.SetCaption("Chargement des documents en cours...")
        ''wd.Visible = False
        ' ''wd.TopMost = True
        ' ''wd.Parent = FMain
        ''wd.Show()
        'thGetAll.Start()
        ' ''Do While thGetAll.IsAlive
        ' ''    Application.DoEvents()
        ' ''    Threading.Thread.Sleep(10)
        ' ''Loop
        ''gcDocuments.DataSource = doc.GetAllDoc()

        ' ''wd.Close()
        ' ''wd.Dispose()
        InLoading = False
        gcDocuments.DataSource = aDoc
    End Sub

    Private Sub gvDocuments_BeforeLeaveRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowAllowEventArgs) Handles gvDocuments.BeforeLeaveRow

        doc.DO_Label = Me.txtLibelle.Text
        doc.DO_Note = Me.meNote.Text
        doc.cn = New SqlClient.SqlConnection(cn.sConnexion)

        If Me.lueCategorie.EditValue IsNot DBNull.Value Then ' And Me.lueCategorie.EditValue <> "" Then
            doc.ID_Categorie = Me.lueCategorie.EditValue
        End If
        doc.Save(False)


    End Sub
  
    Private Sub gvDocuments_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvDocuments.FocusedRowChanged
        If InLoading Then Exit Sub
        If (e.FocusedRowHandle >= 0) Then
            doc = Me.gvDocuments.GetRow(e.FocusedRowHandle)

            'Affichage des propriétés.
            Me.txtLibelle.Text = doc.DO_Label
            Me.meNote.Text = doc.DO_Note
            'If doc.ID_Categorie > 0 Then
            Me.lueCategorie.Properties.AutoSearchColumnIndex = 0
            Me.lueCategorie.EditValue = CType(doc.ID_Categorie, Short)

            'Else
            '    Me.lueCategorie.EditValue = DBNull.Value
            'End If
            ''Me.lueCategorie.EditValue = IIf(doc.ID_Categorie > 0, doc.ID_Categorie, DBNull.Value)

            'Get doc content
            Using wdf As New DevExpress.Utils.WaitDialogForm("Chargement du document en cours", "Gestion des documents")
                wdf.Show()
                doc.GetDocContent()

                'Affichage de l'apperçu.
                ucApercu1.doc = doc
                ucApercu1.index = e.FocusedRowHandle

                Dim thApercu As New System.Threading.Thread(AddressOf ucApercu1.UpdateApercu)
                thApercu.Start()

                wdf.Close()
            End Using
            'Do While thApercu.IsAlive
            '    Application.DoEvents()
            '    Threading.Thread.Sleep(10)
            'Loop
            '        ucApercu1.UpdateApercu()

        End If
    End Sub
End Class