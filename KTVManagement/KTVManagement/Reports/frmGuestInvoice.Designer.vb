<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuestInvoice
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ClsGuestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuestInvoice = New KTVManagement.frmGuestInvoice()
        Me.GuestInvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ClsGuestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuestInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuestInvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.GuestInvoiceBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "KTVManagement.rpGuestInvoice.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1008, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'ClsGuestBindingSource
        '
        Me.ClsGuestBindingSource.DataSource = GetType(DataLayer.ClsGuest)
        '
        'GuestInvoice
        '
        Me.GuestInvoice.DataSetName = "GuestInvoice"
        Me.GuestInvoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GuestInvoiceBindingSource
        '
        Me.GuestInvoiceBindingSource.DataSource = Me.GuestInvoice
        Me.GuestInvoiceBindingSource.Position = 0
        '
        'frmGuestInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmGuestInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGuestInvoice"
        CType(Me.ClsGuestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuestInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuestInvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ClsGuestBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GuestInvoiceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GuestInvoice As KTVManagement.frmGuestInvoice
End Class
