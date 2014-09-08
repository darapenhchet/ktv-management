Imports DataLayer
Imports System.IO

Public Class frmSongInformation

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

    Private Sub frmSongInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2

        dsProduction = productionTransaction.getAllProductionsTwoColumns
        AddDataIntoComboBox(cboProduction, dsProduction)
        'dsProduction.Tables(0).Rows.Add(0, "Add New...")
        'cboProduction.DataSource = dsProduction.Tables(0)
        'cboProduction.DisplayMember = "Production"
        'cboProduction.ValueMember = "ProductionId"

        dsCategory = categoryTransaction.getAllCategoryTwoColumns
        AddDataIntoComboBox(cboCategory, dsCategory)
        'dsCategory.Tables(0).Rows.Add(0, "Add New...")
        'cboCategory.DataSource = dsCategory.Tables(0)
        'cboCategory.DisplayMember = "Category"
        'cboCategory.ValueMember = "CategoryId"

        dsLanguage = languageTransaction.getAllLanguagesTwoColumns
        AddDataIntoComboBox(cboLanguage, dsLanguage)
        'dsLanguage.Tables(0).Rows.Add(0, "Add New...")
        'cboLanguage.DataSource = dsLanguage.Tables(0)
        'cboLanguage.DisplayMember = "Language"
        'cboLanguage.ValueMember = "LanguageId"
  
        dsSinger = singerTransaction.getAllSingersTwoColumns()
        AddDataIntoComboBox(cboSinger, dsSinger)
        'dsSinger.Tables(0).Rows.Add(0, "Add New...")
        'cboSinger.DataSource = dsSinger.Tables(0)
        'cboSinger.DisplayMember = dsSinger.Tables(0).Columns(1).ColumnName
        'cboSinger.ValueMember = dsSinger.Tables(0).Columns(0).ColumnName
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
                singer.ID = singer.ID
                singer.Name = singer.Name
                song.Singers.Add(singer)
                strSingers = strSingers & singer.Name & ","
            Next
            songs.Add(song)
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
            ' song.Singers.RemoveAt(index)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAddSingerToList_Click_1(sender As Object, e As EventArgs) Handles btnAddSingerToList.Click
        Dim singer As New ClsSinger
        singer.Name = cboSinger.Text
        singer.ID = cboSinger.SelectedValue
        'song.Singers.Add(singer)
        lstSingers.Items.Add(singer)
    End Sub

    Private Sub btnSaveAll_Click(sender As Object, e As EventArgs) Handles btnSaveAll.Click
        MessageBox.Show("SAVE ALL")
        For Each song As ClsSong In songs
            MessageBox.Show("SAVE ALL SONG")
            If songTransaction.addNewSong(song) = True Then
                MessageBox.Show("Song has been inserted!!! " & song.ID)
            End If
            For Each singer As ClsSinger In song.Singers
                MessageBox.Show("SAVE ALL SONGDETAILS")
                songDetails.SingerID = singer.ID
                songDetails.SongID = song.ID
                If songDetailsTransaction.addNewSongDetails(songDetails) = True Then
                    MessageBox.Show("SongDetails has been inserted!!!")
                End If
            Next
        Next
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        dgvSongerLists.Rows.RemoveAt(dgvSongerLists.CurrentRow.Index)
    End Sub

    
    Private Sub cboProduction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProduction.SelectedIndexChanged
        If cboProduction.Text.Equals("Add New...") Then
            'frmProductionInformation.Visible = True
        End If
    End Sub


    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged
        If cboCategory.Text.Equals("Add New...") Then
            frmCategoryInformation.Visible = True
        End If
    End Sub

    Private Sub cboLanguage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLanguage.SelectedIndexChanged
        If cboLanguage.Text.Equals("Add New...") Then
            'frmLanguageInformation.Visible = True
        End If
    End Sub

    Private Sub cboSinger_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSinger.SelectedIndexChanged
        If cboSinger.Text.Equals("Add New...") Then
            frmSingerInformation.Visible = True
        End If
    End Sub
End Class