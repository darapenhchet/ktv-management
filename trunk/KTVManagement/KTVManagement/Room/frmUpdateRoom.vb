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

    End Sub

    Private Sub frmUpdateRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
    End Sub
End Class