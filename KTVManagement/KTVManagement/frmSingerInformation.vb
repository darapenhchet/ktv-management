Imports MySql.Data.MySqlClient
Public Class frmSingerInformation

    Private singerTransaction As New DataLayer.ClsSingerTransaction
    Private dsSinger As New DataSet
    Dim Photo As Byte()

    Private Sub frmSingerInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2

        'dsSinger = singerTransaction.getAllSingers
        'dgvSingerInformation.DataSource = dsSinger.Tables(0)
        'dgvSingerInformation.Columns(0).Width = 20
        'dgvSingerInformation.Columns(1).Width = 100
        'dgvSingerInformation.Columns(2).Width = 12
        'dgvSingerInformation.Columns(3).Width = 0
        displaySingerInformation()

    End Sub



    Private Sub pbSingerPhoto_Click(sender As Object, e As EventArgs) Handles pbSingerPhoto.Click
        If OpenSingerPhoto.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            pbSingerPhoto.Image = Image.FromFile(OpenSingerPhoto.FileName)
            Photo = getMemoryStream(OpenSingerPhoto.FileName)
        End If
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim singer As New DataLayer.ClsSinger
        singer.Name = txtSingerName.Text
        singer.Gender = cboGender.SelectedItem.ToString
        singer.Photo = Photo
        If singerTransaction.addNewsinger(singer) = True Then
            displaySingerInformation()
            MessageBox.Show("You have been inserted!!!")
        Else
            MessageBox.Show("You have not been inserted!!!")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If singerTransaction.deleteSinger(CInt(txtID.Text)) = True Then
            displaySingerInformation()
            MessageBox.Show("You have been delete successfully!!!")
        Else
            MessageBox.Show("You have not been delete failure")
        End If
    End Sub

    Private Sub dgvSingerInformation_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSingerInformation.CellClick
        Try
            txtID.Text = dgvSingerInformation.CurrentRow.Cells(0).Value
            txtSingerName.Text = dgvSingerInformation.CurrentRow.Cells(1).Value
            If dgvSingerInformation.CurrentRow.Cells(2).Value.Equals("M") Then
                cboGender.SelectedItem = "Male"
            Else
                cboGender.SelectedItem = "Female"
            End If
            Dim imageData As Byte() = CType(dgvSingerInformation.CurrentRow.Cells(3).Value, Byte())
            If Not imageData Is Nothing Then
                Dim ms As New System.IO.MemoryStream(imageData)
                pbSingerPhoto.Image = Image.FromStream(ms)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub displaySingerInformation()
        dsSinger = singerTransaction.getAllSingers
        dgvSingerInformation.DataSource = dsSinger.Tables(0)
        For Each column As DataGridViewColumn In dgvSingerInformation.Columns
            column.Width = (dgvSingerInformation.Width - 4) / dgvSingerInformation.Columns.Count
        Next

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Clear()
        txtSingerName.Focus()
    End Sub

    Private Sub Clear()
        txtID.Text = "Auto ID"
        txtSingerName.Text = ""
        cboGender.SelectedIndex = -1
        pbSingerPhoto.Image = My.Resources.Photo
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim singer As New DataLayer.ClsSinger
        singer.ID = CInt(txtID.Text)
        singer.Name = txtSingerName.Text
        singer.Gender = cboGender.SelectedItem.ToString
        singer.Photo = Photo
        If singerTransaction.updateSinger(singer) = True Then
            displaySingerInformation()
            MessageBox.Show("You have been update successfully!!!")
        Else
            MessageBox.Show("You have not been update it!!!")
        End If
    End Sub


    Private Sub dgvSingerInformation_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvSingerInformation.DataError
        Return
    End Sub

End Class