Public Class frmGuestInvoice

    Private Property DataSetName As String

    Private Property SchemaSerializationMode As SchemaSerializationMode

    Private Sub frmGuestInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dsGuest As New DataSet
        Dim guestTransaction As New DataLayer.ClsGuestTransaction
        dsGuest = guestTransaction.getAllGuests()
        'GuestInvoice = dsGuest
        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\rpGuestInvoice.rdlc"
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Guset", dsGuest.Tables(0)))
        Me.ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class