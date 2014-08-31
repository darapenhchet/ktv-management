Public Class frmMainAdmin

    Private Sub frmMainAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
        lblUsername.Text = UserLogin.Username
        lblUsername.TextAlign = ContentAlignment.MiddleRight
    End Sub


    Private Sub btnExitMain_Click(sender As Object, e As EventArgs) Handles btnExitMain.Click
        Me.Close()
        closeConnection()
        UserLogin = Nothing
        frmLogin.Visible = True
    End Sub

    Private Sub btnSongInformation_Click(sender As Object, e As EventArgs) Handles btnSongInformation.Click
        frmSongInformation.Show()
    End Sub

    Private Sub btnSingerInformation_Click(sender As Object, e As EventArgs) Handles btnSingerInformation.Click
        frmSingerInformation.Show()
    End Sub
End Class