Public Class frmAddRoom

    Private roomTransaction As New DataLayer.ClsRoomTransaction
    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRoomList_Click(sender As Object, e As EventArgs) Handles btnRoomList.Click
        frmRoom.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMainAdmin.Visible = True
        Me.Close()
    End Sub


    Private Sub btnUpdateRoom_Click(sender As Object, e As EventArgs)
        frmUpdateRoom.Visible = True
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim room As New DataLayer.ClsRoom
        Try
            room.RoomName = txtName.Text
            room.Price = CDbl(txtUnitPrice.Text)
            room.RoomType = cboType.Text
            room.Discount = CInt(txtDiscount.Text)
            If roomTransaction.addNewRoom(room) = True Then
                success.Visible = True
            Else
                fail.Visible = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmAddRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
    End Sub
End Class