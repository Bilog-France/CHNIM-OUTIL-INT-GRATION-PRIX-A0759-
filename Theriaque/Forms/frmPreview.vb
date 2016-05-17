Option Explicit On
Option Strict On
Option Compare Binary

Imports System.Drawing
Imports System.Windows.Forms
Imports System.Reflection

Public Class frmPreview
    Inherits System.Windows.Forms.PrintPreviewDialog

    Protected WithEvents pToolStrip As System.Windows.Forms.ToolStrip
    Public ClickImp As Boolean
    Private MargeTmp As New System.Drawing.Printing.Margins
    Private PSizeTmp As New System.Drawing.Printing.PaperSize
    Public Reset As Boolean

#Region " Vom Windows Form Designer generierter Code "
    Public Sub New()
        MyBase.New()
        InitializeComponent()

        Dim bt As New ToolStripButton
        bt.Text = ""
        bt.Tag = "0"

        pToolStrip = Me.ParentToolStrip
        pToolStrip.Items.Add(bt)
        pToolStrip.ImageList.Images.Add(Me.ImageList1.Images(0))
        bt.ImageIndex = pToolStrip.ImageList.Images.Count - 1
        Me.PrintPreviewControl.Zoom = 0.75

    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents tbbMeP As ToolBarButton
    Friend WithEvents tb As ToolBar
    Friend WithEvents ppc As PrintPreviewControl



    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreview))
        Me.ppc = New System.Windows.Forms.PrintPreviewControl
        Me.tbbMeP = New System.Windows.Forms.ToolBarButton
        Me.tb = New System.Windows.Forms.ToolBar
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'ppc
        '
        Me.ppc.Location = New System.Drawing.Point(0, 0)
        Me.ppc.Name = "ppc"
        Me.ppc.Size = New System.Drawing.Size(100, 100)
        Me.ppc.TabIndex = 0
        '
        'tbbMeP
        '
        Me.tbbMeP.ImageIndex = 0
        Me.tbbMeP.Name = "tbbMeP"
        Me.tbbMeP.Tag = "0"
        '
        'tb
        '
        Me.tb.DropDownArrows = True
        Me.tb.ImageList = Me.ImageList1
        Me.tb.Location = New System.Drawing.Point(0, 0)
        Me.tb.Name = "tb"
        Me.tb.ShowToolTips = True
        Me.tb.Size = New System.Drawing.Size(100, 42)
        Me.tb.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "exec.ico")
        '
        'frmPreview
        '
        Me.ClientSize = New System.Drawing.Size(1067, 684)
        Me.Name = "frmPreview"
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public ReadOnly Property ParentToolStrip() As System.Windows.Forms.ToolStrip
        Get
            Dim fi As FieldInfo = GetType(System.Windows.Forms.PrintPreviewDialog).GetField("toolStrip1", BindingFlags.Public Or BindingFlags.NonPublic Or BindingFlags.Instance)
            If fi Is Nothing Then Exit Property
            Return CType(fi.GetValue(Me), System.Windows.Forms.ToolStrip)
        End Get
    End Property


    'Private Sub tb_ButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tb.ButtonClick
    '    If e.Button.Tag Is "0" Then
    '        Dim psdlg As PageSetupDialog = New PageSetupDialog
    '        With psdlg
    '            .PrinterSettings = Me.Document.PrinterSettings
    '            .PageSettings = Me.Document.DefaultPageSettings
    '            If .ShowDialog(Me) = DialogResult.OK Then
    '                Me.ppc = CType(Me.Controls(0), PrintPreviewControl)
    '                Me.ppc.Document.PrinterSettings = .PrinterSettings
    '                Me.ppc.Document.DefaultPageSettings = .PageSettings
    '            End If
    '        End With
    '        Me.Update()
    '    End If
    'End Sub

    Private Sub pToolStrip_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles pToolStrip.ItemClicked
        If e.ClickedItem.Tag Is "0" Then

            Dim psdlg As PageSetupDialog = New PageSetupDialog

            '----------------------------------------------------------------------------------------------------------
            Dim mTmp As New System.Drawing.Printing.Margins
            Dim psTmp As New System.Drawing.Printing.PaperSize

            'initialisation
            'Me.Document.DefaultPageSettings.Margins = Me.MargeTmp
            'Me.Document.DefaultPageSettings.PaperSize = Me.PSizeTmp


            mTmp = Me.Document.DefaultPageSettings.Margins
            psTmp = Me.Document.DefaultPageSettings.PaperSize

            psdlg.Document = Me.Document

            If System.Globalization.RegionInfo.CurrentRegion.IsMetric Then
                psdlg.Document.DefaultPageSettings.Margins = System.Drawing.Printing.PrinterUnitConvert.Convert( _
                  psdlg.Document.DefaultPageSettings.Margins, System.Drawing.Printing.PrinterUnit.Display, System.Drawing.Printing.PrinterUnit.TenthsOfAMillimeter)
            End If
            'affichage de la boite de dialogue
            If psdlg.ShowDialog() = DialogResult.OK Then
                Me.Document.DefaultPageSettings.Margins = psdlg.PageSettings.Margins
                Me.Document.DefaultPageSettings.PaperSize = psdlg.PageSettings.PaperSize
                Me.Document.PrinterSettings = psdlg.PrinterSettings
                Me.Document.DefaultPageSettings = psdlg.PageSettings
                Me.ppc.Document = Me.Document
                Me.Reset = True
                Me.Close()
            Else
                Me.Document.DefaultPageSettings.Margins = mTmp
                Me.Document.DefaultPageSettings.PaperSize = psTmp
            End If

            '----------------------------------------------------------------------------------------------------------

            'With psdlg
            '    .PrinterSettings = Me.Document.PrinterSettings
            '    .PageSettings = Me.Document.DefaultPageSettings
            '    'If System.Globalization.RegionInfo.CurrentRegion.IsMetric Then
            '    '    Me.Document.DefaultPageSettings.Margins = System.Drawing.Printing.PrinterUnitConvert.Convert( _
            '    '    Me.Document.DefaultPageSettings.Margins, System.Drawing.Printing.PrinterUnit.Display, System.Drawing.Printing.PrinterUnit.TenthsOfAMillimeter)
            '    'End If
            '    If .ShowDialog(Me) = DialogResult.OK Then
            '        Me.ppc = CType(Me.Controls(0), PrintPreviewControl)
            '        Me.ppc.Document.PrinterSettings = .PrinterSettings
            '        Me.ppc.Document.DefaultPageSettings = .PageSettings
            '    End If

            'End With


        ElseIf e.ClickedItem.Name = "printToolStripButton" Then
            Me.ClickImp = True
            Me.Close()
        End If
    End Sub

    Private Sub frmPreview_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.MargeTmp = Me.Document.DefaultPageSettings.Margins
        Me.PSizeTmp = Me.Document.DefaultPageSettings.PaperSize
        Me.Reset = False
    End Sub
End Class


