Public Class frmPlaySong

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        If (openSong.ShowDialog = Windows.Forms.DialogResult.OK) Then
            vlc.playlist.add("file:///" & openSong.FileName)
        End If
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        vlc.playlist.play()
        Timer1.Enabled = True
    End Sub

    Private Sub btnTurnOffSingerSound_Click(sender As Object, e As EventArgs) Handles btnTurnOffSingerSound.Click
        If (vlc.audio.channel = 3) Then
            vlc.audio.channel = 1
            btnTurnOffSingerSound.Text = "Turn Off Singer Sound"

        Else
            btnTurnOffSingerSound.Text = "Turn On Singer Sound"
            vlc.audio.channel = 3
        End If

        MessageBox.Show(vlc.input.Time / 1000 & vlc.input.Time / 1000 / 1000)



    End Sub
    
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        vlc.playlist.next()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        vlc.playlist.prev()
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        vlc.playlist.togglePause()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        vlc.playlist.stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        vlc.input.Position = vlc.input.Position + 0.1
        MessageBox.Show(vlc.input.Length / 1000)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        vlc.audio.toggleMute()
        MessageBox.Show(vlc.input.Time & vbTab & vlc.input.Length)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        vlc.audio.Volume = vlc.audio.Volume - 10
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        vlc.audio.Volume = vlc.audio.Volume + 10
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        ProgressBar1.Value = vlc.input.Time
        ProgressBar1.Maximum = vlc.input.Length

        If ProgressBar1.Value = 100 Then
            ProgressBar1.Value = 0
        End If


    End Sub

    Private Sub vlc_Enter(sender As Object, e As EventArgs) Handles vlc.Enter

    End Sub
End Class