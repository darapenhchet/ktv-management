Imports DataLayer
Imports System.IO
Public Class frmAddSong
    Private songs As New List(Of ClsSong)
    Private song As New ClsSong
    Private songDetailsTransaction As New ClsSongDetailsTransaction
    Private songDetails As New ClsSongDetails
    Private songTransaction As New ClsSongTransaction
    Private singerTransaction As New ClsSingerTransaction
    Private productionTransaction As New ClsProductionTransaction
    Private categoryTransaction As New ClsCategoryTransaction
    Private languageTransaction As New ClsLanguageTransaction
    Private Filenames() As String = {}
    Private Paths() As String = {}
    Private dsProduction As New DataSet
    Private dsCategory As New DataSet
    Private dsLanguage As New DataSet
    Private dsSinger As New DataSet

    Private Sub frmAddSong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setGrdHeaderText("Title|Album|Category|Production|Language|Singer|Path", dgvSongList)
        setGrdHeaderWidth("200|100|100|100|100|200|190", dgvSongList)
        AddDataIntoComboBox(cboCategory, categoryTransaction.getAllCategoryTwoColumns())
        AddDataIntoComboBox(cboProduction, productionTransaction.getAllProductionsTwoColumns())
        AddDataIntoComboBox(cboLanguage, languageTransaction.getAllLanguagesTwoColumns())
        AddDataIntoComboBox(cboSinger, singerTransaction.getAllSingersTwoColumns())
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If OpenSong.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtPath.Text = OpenSong.FileName
        End If
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        vlc.playlist.items.clear()
        vlc.playlist.add("file:///" & txtPath.Text)
        vlc.playlist.play()
    End Sub

    Private Sub btnFullScreen_Click(sender As Object, e As EventArgs) Handles btnFullScreen.Click
        vlc.video.toggleFullscreen()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            song.Title = txtTitle.Text
            song.Album = txtAlbum.Text
            song.Production = New ClsProduction(cboProduction.SelectedValue, cboProduction.Text)
            song.Category = New ClsCategory(cboCategory.SelectedValue, cboCategory.Text)
            song.Language = New ClsLanguage(cboLanguage.SelectedValue, cboLanguage.Text)
            song.Path = txtPath.Text
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

            Dim strSingers As String = ""
            For Each singer As ClsSinger In lstSingers.Items
                song.Singers.Add(singer)
                strSingers = strSingers & singer.Name & ","
            Next
            songs.Add(song)
            dgvSongList.Rows.Add(song.Title, song.Album, song.Category.Category, song.Production.Production, song.Language.Language, strSingers.Substring(0, strSingers.Length() - 1), song.Path)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAddSinger_Click(sender As Object, e As EventArgs) Handles btnAddSinger.Click
        Dim singer As New ClsSinger
        singer.Name = cboSinger.Text
        singer.ID = cboSinger.SelectedValue
        lstSingers.Items.Add(singer)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            lstSingers.Items.RemoveAt(lstSingers.SelectedIndex)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnSingerOff_Click(sender As Object, e As EventArgs) Handles btnSingerOff.Click
        If vlc.audio.channel = 3 Then
            vlc.audio.channel = 1
            Exit Sub
        End If
        vlc.audio.channel = 3
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        MessageBox.Show("SAVE ALL")
        Try
            For Each song As ClsSong In songs
                MessageBox.Show("SAVE ALL SONG")
                MessageBox.Show(song.Language.ID)
                If songTransaction.addNewSong(song) = True Then
                    MessageBox.Show("Song has been inserted!!! " & song.ID)
                    For Each singer As ClsSinger In song.Singers
                        MessageBox.Show("SAVE ALL SONGDETAILS")
                        songDetails.SingerID = singer.ID
                        songDetails.SongID = song.ID
                        If songDetailsTransaction.addNewSongDetails(songDetails) = True Then
                            MessageBox.Show("SongDetails has been inserted!!!")
                        End If
                    Next
                End If
            Next
            dgvSongList.Rows.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cboProduction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProduction.SelectedIndexChanged
        If cboProduction.Text.Equals("Add New...") Then
            frmAddProduction.Visible = True
        End If
    End Sub

    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged
        If cboCategory.Text.Equals("Add New...") Then
            frmAddCategory.Visible = True
        End If
    End Sub

    Private Sub cboSinger_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSinger.SelectedIndexChanged
        If cboSinger.Text.Equals("Add New...") Then
            frmAddSinger.Visible = True
        End If
    End Sub

    Private Sub cboLanguage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLanguage.SelectedIndexChanged
        If cboLanguage.Text.Equals("Add New...") Then
            frmLanguageInformation.Visible = True
        End If
    End Sub

    Private Sub btnSongList_Click(sender As Object, e As EventArgs) Handles btnSongList.Click
        frmSong.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

End Class