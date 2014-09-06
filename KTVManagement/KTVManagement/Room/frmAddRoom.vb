Public Class frmAddRoom

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRoomList_Click(sender As Object, e As EventArgs) Handles btnRoomList.Click
        frmRoom.Show()
        Me.Visible = False
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMainAdmin.Visible = True
        Me.Close()
    End Sub


    Private Sub btnUpdateRoom_Click(sender As Object, e As EventArgs)
        frmUpdateRoom.Visible = True
        Me.Visible = False
    End Sub
End Class