<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuestReport
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
        Me.Invoice = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'Invoice
        '
        Me.Invoice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Invoice.Location = New System.Drawing.Point(0, 0)
        Me.Invoice.Name = "Invoice"
        Me.Invoice.Size = New System.Drawing.Size(832, 505)
        Me.Invoice.TabIndex = 0
        '
        'frmGuestReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 505)
        Me.Controls.Add(Me.Invoice)
        Me.Name = "frmGuestReport"
        Me.Text = "frmGuestReport"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Invoice As Microsoft.Reporting.WinForms.ReportViewer
End Class
