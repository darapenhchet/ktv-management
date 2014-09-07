Public Class frmSongMain

    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        frmCategoryInformation.Show()
    End Sub

    Private Sub btnProduction_Click(sender As Object, e As EventArgs) Handles btnProduction.Click
        frmProduction.Show()
    End Sub

    Private Sub btnLanguage_Click(sender As Object, e As EventArgs) Handles btnLanguage.Click
        frmLanguage.Show()
    End Sub

    Private Sub btnSinger_Click(sender As Object, e As EventArgs) Handles btnSinger.Click
        frmSinger.Show()
    End Sub

    Private Sub btnSong_Click(sender As Object, e As EventArgs) Handles btnSong.Click
        frmSong.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMainAdmin.Show()
        Me.Close()
    End Sub


    Private Sub frmSongMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
    End Sub
End Class