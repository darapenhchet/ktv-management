Imports DataLayer
Public Class frmSong

    Private dsSongDetails As New DataSet
    Private songDetailsTransaction As New ClsSongDetailsTransaction

    Private Sub frmSong_Load(sender As Object, e As EventArgs) Handles Me.Load
        DisplaySongInformation("")
    End Sub
    Private Sub btnAddSong_Click(sender As Object, e As EventArgs) Handles btnAddSong.Click
        frmAddSong.Show()
        Me.Close()
    End Sub

    Public Sub DisplaySongInformation(keyword As String)
        dsSongDetails = songDetailsTransaction.getAllSongDetails(keyword)
        dgvSongList.DataSource = dsSongDetails.Tables(0)
        setGrdHeaderText("ID|Title|Album|Category|Production|Language|Singers|Path", dgvSongList)
        setGrdHeaderWidth("100|200|100|100|100|100|150|150", dgvSongList)
    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dsSongDetails.Tables(0).Clear()
        dgvSongList.DataSource = dsSongDetails.Tables(0)
        DisplaySongInformation(txtSearch.Text)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class