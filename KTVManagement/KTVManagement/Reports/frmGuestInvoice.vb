Imports Microsoft.Reporting.WinForms
Public Class frmGuestInvoice

    Private Sub frmGuestInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim reports As New ReportParameterCollection
            MessageBox.Show(frmCheckInGuest.txtRoomID.Text)
            MessageBox.Show(frmCheckInGuest.txtRoomType.Text)
            Dim RoomID As New ReportParameter("RoomID", frmCheckInGuest.txtRoomID.Text)
            Dim RoomType As New ReportParameter("RoomType", frmCheckInGuest.txtRoomType.Text)
            Dim Duration As New ReportParameter("Duration", frmCheckInGuest.txtDuration.Text)
            Dim TimeIn As New ReportParameter("TimeIn", frmCheckInGuest.TimeIn.Text)
            Dim TimeOut As New ReportParameter("TimeOut", frmCheckInGuest.TimeOut.Text)
            Dim Price As New ReportParameter("Price", frmCheckInGuest.txtPrice.Text)
            Dim Discount As New ReportParameter("Discount", frmCheckInGuest.txtDiscount.Text)
            Dim Amount As New ReportParameter("Amount", frmCheckInGuest.txtAmount.Text)
            Dim Username As New ReportParameter("Username", DataLayer.ClsConnection.UserLogin.Username)
            'reports.Add(RoomID)
            'reports.Add(RoomType)
            'reports.Add(Duration)
            'reports.Add(TimeIn)
            'reports.Add(TimeOut)
            'reports.Add(Price)
            'reports.Add(Discount)
            'reports.Add(Amount)
            'reports.Add(Username)
            ReportViewer1.LocalReport.SetParameters(Amount)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
