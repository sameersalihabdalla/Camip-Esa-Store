<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInvoices
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalReportViewer3 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.RepPosInvoice1 = New ExtraPOS.RepPosInvoice()
        Me.SuspendLayout()
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv.Location = New System.Drawing.Point(0, 0)
        Me.crv.Name = "crv"
        Me.crv.Size = New System.Drawing.Size(1016, 440)
        Me.crv.TabIndex = 0
        '
        'CrystalReportViewer3
        '
        Me.CrystalReportViewer3.ActiveViewIndex = 0
        Me.CrystalReportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer3.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer3.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer3.Name = "CrystalReportViewer3"
        Me.CrystalReportViewer3.PrintMode = CrystalDecisions.Windows.Forms.PrintMode.PrintOutputController
        Me.CrystalReportViewer3.ReportSource = Me.RepPosInvoice1
        Me.CrystalReportViewer3.Size = New System.Drawing.Size(1016, 440)
        Me.CrystalReportViewer3.TabIndex = 1
        '
        'FrmInvoices
        '
        Me.ClientSize = New System.Drawing.Size(1016, 440)
        Me.Controls.Add(Me.CrystalReportViewer3)
        Me.Controls.Add(Me.crv)
        Me.Name = "FrmInvoices"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_invoice_number As Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer

    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReportViewer3 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents RepPosInvoice1 As RepPosInvoice
End Class
