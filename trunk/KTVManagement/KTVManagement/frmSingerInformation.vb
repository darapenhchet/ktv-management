Imports MySql.Data.MySqlClient
Public Class frmSingerInformation

    Private singerTransaction As New ClsSingerTransaction
    Private dsSinger As New DataSet
    Dim Photo As String

    Private Sub frmSingerInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
        dsSinger = singerTransaction.getAllSingers

        dgvSingerInformation.DataSource = dsSinger.Tables(0)
    End Sub



    Private Sub pbSingerPhoto_Click(sender As Object, e As EventArgs) Handles pbSingerPhoto.Click
        If OpenSingerPhoto.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            pbSingerPhoto.Image = Image.FromFile(OpenSingerPhoto.FileName)
            Photo = OpenSingerPhoto.FileName
        End If
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim singer As New ClsSinger
        singer.Name = txtSingerName.Text
        singer.Gender = cboGender.SelectedItem.ToString.Substring(0, 1)
        singer.Photo = Photo
        If singerTransaction.addNewsinger(singer) = True Then
            MessageBox.Show("You have been inserted!!!")
        Else
            MessageBox.Show("You have not been inserted!!!")
        End If
    End Sub

    Private Sub cboGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGender.SelectedIndexChanged
        MessageBox.Show(cboGender.SelectedItem)
    End Sub
End Class