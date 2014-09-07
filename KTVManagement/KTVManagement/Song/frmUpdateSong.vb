Imports DataLayer
Imports System.IO

Public Class frmUpdateSong

    Private categoryTransaction As New ClsCategoryTransaction
    Private productionTransaction As New ClsProductionTransaction
    Private languageTransaction As New ClsLanguageTransaction
    Private singerTransaction As New ClsSingerTransaction
    Private song As New ClsSong
    Private songTransaction As New ClsSongTransaction
    Private songDetailsTransaction As New ClsSongDetailsTransaction
    Private songDetails As New ClsSongDetails

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub frmUpdateSong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
        AddDataIntoComboBox(cboCategory, categoryTransaction.getAllCategoryTwoColumns())
        AddDataIntoComboBox(cboProduction, productionTransaction.getAllProductionsTwoColumns())
        AddDataIntoComboBox(cboLanguage, languageTransaction.getAllLanguagesTwoColumns())
        AddDataIntoComboBox(cboSinger, singerTransaction.getAllSingersTwoColumns())
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        vlc.playlist.items.clear()
        vlc.playlist.add("file:///" & txtPath.Text)
        vlc.playlist.play()
    End Sub

    Private Sub btnAddSong_Click(sender As Object, e As EventArgs) Handles btnAddSong.Click
        frmAddSong.Show()
        Me.Close()
    End Sub

    Private Sub btnSongList_Click(sender As Object, e As EventArgs) Handles btnSongList.Click
        frmSong.Show()
        Me.Close()
    End Sub

    Private Sub btnFullScreen_Click(sender As Object, e As EventArgs) Handles btnFullScreen.Click
        vlc.video.toggleFullscreen()
    End Sub

    Private Sub btnSingerOff_Click(sender As Object, e As EventArgs) Handles btnSingerOff.Click
        If vlc.audio.channel = 3 Then
            vlc.audio.channel = 1
            Exit Sub
        End If
        vlc.audio.channel = 3
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If OpenSong.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtPath.Text = OpenSong.FileName
        End If
    End Sub

    Private Sub btnAddSinger_Click(sender As Object, e As EventArgs) Handles btnAddSinger.Click
        Dim singer As New ClsSinger
        singer.ID = cboSinger.SelectedValue
        singer.Name = cboSinger.Text
        lstSingers.Items.Add(singer)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try
            lstSingers.Items.RemoveAt(lstSingers.SelectedIndex)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            song.ID = CInt(txtID.Text)
            song.Title = txtTitle.Text
            song.Album = txtAlbum.Text
            song.Category = New ClsCategory(cboCategory.SelectedValue, cboCategory.Text)
            song.Production = New ClsProduction(cboProduction.SelectedValue, cboProduction.Text)
            song.Language = New ClsLanguage(cboLanguage.SelectedValue, cboLanguage.Text)
            song.Path = txtPath.Text
            For Each singer As ClsSinger In lstSingers.Items
                MessageBox.Show(singer.ID)
                singer.ID = singer.ID
                singer.Name = singer.Name
                song.Singers.Add(singer)
            Next
            Dim Destination As String = "D:\KTV\" & song.Production.Production & "\" & song.Album
            Try
                If Not Directory.Exists(Destination) Then
                    Directory.CreateDirectory(Destination)
                End If
                Dim file = New FileInfo(song.Path)
                song.Path = Path.Combine(Destination, file.Name)
                file.CopyTo(song.Path, True)
            Catch ex As Exception

            End Try

            If songDetailsTransaction.DeleteSongDetails(song.ID) = True Then
                MessageBox.Show("DELETE ALL DETAILS")
                If songTransaction.updateSong(song) = True Then
                    MessageBox.Show("UPDATED SONG")
                    For Each singer As ClsSinger In song.Singers
                        songDetails.SongID = song.ID
                        songDetails.SingerID = singer.ID
                        MessageBox.Show(songDetails.SingerID & songDetails.SongID)
                        If songDetailsTransaction.addNewSongDetails(songDetails) = True Then
                            MessageBox.Show("DETAILS INSERTED")
                        End If
                    Next
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class