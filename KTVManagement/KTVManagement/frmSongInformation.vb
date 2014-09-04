Imports DataLayer

Public Class frmSongInformation
    Private singerTransaction As New ClsSingerTransaction
    Private Sub frmSongInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSingerLists.CellContentClick
        MessageBox.Show(dgvSingerLists.Rows.Count)
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        ' Dim song As ClsSong
        Dim Filenames() As String = {}
        Dim Paths() As String = {}
        If openSongs.ShowDialog = Windows.Forms.DialogResult.OK Then
            Paths = openSongs.FileNames
            Filenames = openSongs.SafeFileNames
            For Each fileName As String In Filenames
                dgvSongerLists.Rows.Add(fileName)
            Next
        End If
    End Sub




End Class