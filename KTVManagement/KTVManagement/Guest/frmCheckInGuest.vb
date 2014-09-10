Public Class frmCheckInGuest

    Private guest As New DataLayer.ClsGuest
    Private room As New DataLayer.ClsRoom
    Private guestTransaction As New DataLayer.ClsGuestTransaction

    Private Sub frmCheckInGuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Center(Panel1, Me)
        Timer1.Start()
        Time.Text = TimeOfDay
        Timer1.Interval = 1000
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMainAdmin.Visible = True
        Me.Close()
    End Sub

    Private Sub txtDuration_TextChanged(sender As Object, e As EventArgs) Handles txtDuration.TextChanged
        Try
            If txtDuration.Text.Equals("") Then
                txtAmount.Text = "0"
                Exit Sub
            End If
            txtAmount.Text = (CDbl(txtPrice.Text) * CInt(txtDuration.Text)) - (CDbl(txtDuration.Text) * CInt(txtDuration.Text) * CInt(txtDiscount.Text)) / 100
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            room.ID = CInt(txtRoomID.Text)
            room.RoomName = txtRoom.Text
            room.RoomType = txtRoomType.Text
            room.Price = CDbl(txtPrice.Text)
            room.Discount = CInt(txtDiscount.Text)
            guest.Room = room
            guest.TimeIn = Time.Text
            Try
                guest.Duration = CInt(txtDuration.Text)
            Catch ex As Exception
                MessageBox.Show("Duration cannot be nothing or enter with the string!!!")
                Exit Sub
            End Try
            guest.Amount = CDbl(txtAmount.Text)
            If guestTransaction.addNewGuest(guest) = True Then
                success.Visible = True
                dsCheckInGuests = guestTransaction.getCheckInRoom
            Else
                fail.Visible = True
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Time.Text = TimeOfDay
    End Sub

    Private Sub btnRoomList_Click(sender As Object, e As EventArgs) Handles btnRoomList.Click
        frmRoomList.Show()
        Me.Close()
    End Sub

    Private Sub btnGuestList_Click(sender As Object, e As EventArgs) Handles btnGuestList.Click
        frmGuest.Show()
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        frmGuestInvoice.Show()

    End Sub

    Private Sub btnGuestHistory_Click(sender As Object, e As EventArgs) Handles btnGuestHistory.Click
        frmGuestHistory.Show()
        Me.Close()
    End Sub

End Class