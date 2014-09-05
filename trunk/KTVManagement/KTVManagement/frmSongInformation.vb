Imports DataLayer

Public Class frmSongInformation
    Private songs As New List(Of ClsSong)
    Private song As New ClsSong
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

    Private Sub frmSongInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2

        dsProduction = productionTransaction.getAllProductions
        cboProduction.DataSource = dsProduction.Tables(0)
        cboProduction.DisplayMember = "Production"
        cboProduction.ValueMember = "ProductionId"

        dsCategory = categoryTransaction.getAllCategory
        cboCategory.DataSource = dsCategory.Tables(0)
        cboCategory.DisplayMember = "Category"
        cboCategory.ValueMember = "CategoryId"

        dsLanguage = languageTransaction.getAllLanguages
        cboLanguage.DataSource = dsLanguage.Tables(0)
        cboLanguage.DisplayMember = "Language"
        cboLanguage.ValueMember = "LanguageId"
        Dim cbSingerIds As New DataGridViewComboBoxColumn
        Dim cbSingerNames As New DataGridViewComboBoxColumn

        dsSinger = singerTransaction.getAllSingers
        cbSingerIds.DataSource = dsSinger.Tables(0)
        cbSingerIds.DisplayMember = dsSinger.Tables(0).Columns(1).ColumnName
        cbSingerIds.ValueMember = dsSinger.Tables(0).Columns(0).ColumnName
        'dgvSingerLists.Columns.Add(cbSingerIds)

        dsSinger = singerTransaction.getAllSingers
        'cbSingerNames.DataSource = dsSinger.Tables(0)
        'cbSingerNames.DisplayMember = dsSinger.Tables(0).Columns(1).ColumnName
        'cbSingerNames.ValueMember = dsSinger.Tables(0).Columns(1).ColumnName
        'dgvSingerLists.Columns.Add(cbSingerNames)

        'dgvSingerLists.Columns(0).Visible = 

        cboSinger.DataSource = dsSinger.Tables(0)
        cboSinger.DisplayMember = dsSinger.Tables(0).Columns(1).ColumnName
        cboSinger.ValueMember = dsSinger.Tables(0).Columns(0).ColumnName
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        ' Dim song As ClsSong

        If openSongs.ShowDialog = Windows.Forms.DialogResult.OK Then
            Paths = openSongs.FileNames
            Filenames = openSongs.SafeFileNames
            For Each file As String In Filenames
                dgvSongerLists.Rows.Add(file, "", "", "", "")
            Next
        End If
    End Sub

    Private Sub dgvSongerLists_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSongerLists.CellMouseDoubleClick
        Try
            vlc.playlist.items.clear()
            vlc.playlist.add("file:///" & Paths(dgvSongerLists.CurrentRow.Index))
            vlc.playlist.play()
            txtTitle.Text = dgvSongerLists.CurrentRow.Cells(0).Value
            txtAlbum.Text = dgvSongerLists.CurrentRow.Cells(1).Value
            cboProduction.SelectedText = dgvSongerLists.CurrentRow.Cells(2).Value
            cboCategory.SelectedText = dgvSongerLists.CurrentRow.Cells(3).Value
            cboLanguage.SelectedText = dgvSongerLists.CurrentRow.Cells(4).Value
            txtSongLocation.Text = (Paths(dgvSongerLists.CurrentRow.Index)).ToString
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Try
            song.Title = txtTitle.Text

            song.Album = txtAlbum.Text
            song.Production = New ClsProduction(cboProduction.SelectedValue, cboProduction.Text)
            song.Category = New ClsCategory(cboCategory.SelectedValue, cboCategory.Text)
            song.Language = New ClsLanguage(cboLanguage.SelectedValue, cboLanguage.Text)
            song.Path = txtSongLocation.Text
            Dim strSingers As String = ""
            For Each singer As ClsSinger In lstSingers.Items
                singer.ID = singer.ID
                singer.Name = singer.Name
                strSingers = strSingers & singer.Name & ","
            Next
            dgvSongerLists.CurrentRow.Cells(0).Value = song.Title
            dgvSongerLists.CurrentRow.Cells(1).Value = song.Album
            dgvSongerLists.CurrentRow.Cells(2).Value = song.Production.Production
            dgvSongerLists.CurrentRow.Cells(3).Value = song.Category.Category
            dgvSongerLists.CurrentRow.Cells(4).Value = song.Language.Language
            dgvSongerLists.CurrentRow.Cells(5).Value = strSingers.Substring(0, strSingers.Length - 1)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try
            Dim index As Integer = lstSingers.SelectedIndex
            lstSingers.Items.RemoveAt(index)
            song.Singers.RemoveAt(index)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAddSingerToList_Click_1(sender As Object, e As EventArgs) Handles btnAddSingerToList.Click
        Dim singer As New ClsSinger
        singer.Name = cboSinger.Text
        singer.ID = cboSinger.SelectedValue
        song.Singers.Add(singer)
        lstSingers.Items.Add(singer)
    End Sub

    Private Sub btnSaveAll_Click(sender As Object, e As EventArgs) Handles btnSaveAll.Click
        For Each song As ClsSong In songs
            If songTransaction.addNewSong(song) = True Then
                MessageBox.Show("Song has been inserted!!! " & song.ID)
            End If
            For Each singer As ClsSinger In song.Singers
                If singerTransaction.addNewsinger(singer) Then

                End If
            Next
        Next
    End Sub
End Class