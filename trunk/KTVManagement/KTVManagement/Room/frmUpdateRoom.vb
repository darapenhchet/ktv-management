Public Class frmUpdateRoom

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddRoom.Click
        frmAddRoom.Visible = True
        Me.Close()
    End Sub

    Private Sub btnRoomList_Click(sender As Object, e As EventArgs) Handles btnRoomList.Click
        frmRoom.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMainAdmin.Visible = True
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim room As New DataLayer.ClsRoom
            Dim roomTransaction As New DataLayer.ClsRoomTransaction
            room.ID = CInt(txtID.Text)
            room.RoomName = txtName.Text
            room.RoomType = cboType.Text
            room.Price = CDbl(txtUnitPrice.Text)
            room.Discount = CInt(txtDiscount.Text)
            If cboType.SelectedText.Equals("Free") Then
                room.Status = False
            Else
                room.Status = True
            End If
            If roomTransaction.updateRoom(room) = True Then
                success.Visible = True
            Else
                fail.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmUpdateRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
    End Sub

End Class