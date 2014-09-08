Imports DataLayer
Public Class frmSong

    Private dsSongDetails As New DataSet
    Private songDetailsTransaction As New ClsSongDetailsTransaction

    Private Sub frmSong_Load(sender As Object, e As EventArgs) Handles Me.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
        'vlc.Toolbar = False
        DisplaySongInformation("")
    End Sub
    Private Sub btnAddSong_Click(sender As Object, e As EventArgs) Handles btnAddSong.Click
        frmAddSong.Show()
        Me.Close()
    End Sub

    Public Sub DisplaySongInformation(keyword As String)
        Try
            dsSongDetails = songDetailsTransaction.getAllSongDetails(keyword)
            dgvSongList.DataSource = dsSongDetails.Tables(0)
            setGrdHeaderText("ID|Title|Album|Category|Production|Language|Singers|Path", dgvSongList)
            setGrdHeaderWidth("100|200|100|100|100|100|150|150", dgvSongList)
        Catch ex As Exception
        End Try
        
    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dsSongDetails.Tables(0).Clear()
        dgvSongList.DataSource = dsSongDetails.Tables(0)
        DisplaySongInformation(txtSearch.Text)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnUpdateSong_Click(sender As Object, e As EventArgs) Handles btnUpdateSong.Click
        Try
            frmUpdateSong.Show()
            frmUpdateSong.txtID.Text = dgvSongList.CurrentRow.Cells(0).Value
            frmUpdateSong.txtTitle.Text = dgvSongList.CurrentRow.Cells(1).Value
            frmUpdateSong.txtAlbum.Text = dgvSongList.CurrentRow.Cells(2).Value
            frmUpdateSong.cboCategory.Text = dgvSongList.CurrentRow.Cells(3).Value
            frmUpdateSong.cboProduction.Text = dgvSongList.CurrentRow.Cells(4).Value
            frmUpdateSong.cboLanguage.Text = dgvSongList.CurrentRow.Cells(5).Value

            Dim singerTransaction As New ClsSingerTransaction
            For Each singer As String In GetStrSingers(dgvSongList.CurrentRow.Cells(6).Value)
                Dim objSinger As New ClsSinger
                objSinger = singerTransaction.getSingerBySingerName(singer)
                frmUpdateSong.lstSingers.Items.Add(objSinger)
            Next
            frmUpdateSong.txtPath.Text = dgvSongList.CurrentRow.Cells(7).Value
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        vlc.playlist.items.clear()
        vlc.playlist.add("file:///" & dgvSongList.CurrentRow.Cells(7).Value)
        vlc.playlist.play()
    End Sub

End Class