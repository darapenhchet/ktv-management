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
End Class