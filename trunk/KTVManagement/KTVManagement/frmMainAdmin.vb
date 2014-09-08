Public Class frmMainAdmin

    Private Sub frmMainAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
        lblUsername.Text = DataLayer.ClsConnection.UserLogin.Username
        lblUsername.TextAlign = ContentAlignment.MiddleRight
    End Sub


    Private Sub btnExitMain_Click(sender As Object, e As EventArgs) Handles btnExitMain.Click
        Me.Close()
        DataLayer.ClsConnection.closeConnection()
        DataLayer.ClsConnection.UserLogin = Nothing
        frmLogin.Visible = True
    End Sub

    Private Sub btnSongInformation_Click(sender As Object, e As EventArgs) Handles btnSongInformation.Click
        frmSongMain.Show()
        Me.Close()
    End Sub

    Private Sub btnUserInformation_Click(sender As Object, e As EventArgs) Handles btnUserInformation.Click
        'frmUserInformation.Show()
        frmUser.Show()
    End Sub

    Private Sub btnAboutUs_Click(sender As Object, e As EventArgs) Handles btnAboutUs.Click
        Me.Visible = False
        frmSongLists.Visible = True
    End Sub

    Private Sub btnRoomInformation_Click(sender As Object, e As EventArgs) Handles btnRoomInformation.Click
        frmRoom.Show()
        Me.Close()
    End Sub


    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click
        frmRoomList.Show()
    End Sub

    Private Sub btnIncome_Click(sender As Object, e As EventArgs)

    End Sub
End Class