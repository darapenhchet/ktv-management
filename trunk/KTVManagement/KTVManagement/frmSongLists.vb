Imports DataLayer
Public Class frmSongLists
    Private songDetailsTransaction As New ClsSongDetailsTransaction
    Private dsSongDetails As New DataSet
    Private Sub frmSongLists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayInformation()
    End Sub

    Private Sub dgvSongLists_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSongLists.CellDoubleClick
        vlc.playlist.items.clear()
        vlc.playlist.add("file:///" & dgvSongLists.CurrentRow.Cells(6).Value)
        vlc.playlist.play()
    End Sub

    Public Sub DisplayInformation()
        dsSongDetails = songDetailsTransaction.getAllSongDetails()
        dgvSongLists.DataSource = dsSongDetails.Tables(0)
        For Each column As DataGridViewColumn In dgvSongLists.Columns
            column.Width = (dgvSongLists.Width - 4) / dgvSongLists.Columns.Count
        Next
    End Sub

    Private Sub btnTurnOff_Click(sender As Object, e As EventArgs) Handles btnTurnOff.Click

        If vlc.audio.channel = 3 Then
            vlc.audio.channel = 1
            btnTurnOff.Text = "Turn Off"
        Else
            vlc.audio.channel = 3
            btnTurnOff.Text = "Turn On"
        End If
    End Sub
End Class