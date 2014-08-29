Public Class frmPlaySong

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        If (openSong.ShowDialog = Windows.Forms.DialogResult.OK) Then
            vlc.playlist.add("file:///" & openSong.FileName)
        End If
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        vlc.playlist.play()
    End Sub

    Private Sub btnTurnOffSingerSound_Click(sender As Object, e As EventArgs) Handles btnTurnOffSingerSound.Click
        If (vlc.audio.channel = 3) Then
            vlc.audio.channel = 1
            btnTurnOffSingerSound.Text = "Turn Off Singer Sound"

        Else
            btnTurnOffSingerSound.Text = "Turn On Singer Sound"
            vlc.audio.channel = 3
        End If

    End Sub
End Class