Public Class frmGuestReport

    Private Sub frmGuestReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Invoice.RefreshReport()
    End Sub
End Class