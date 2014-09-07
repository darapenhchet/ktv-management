Public Class frmAddSinger

    Private singerTransaction As New DataLayer.ClsSingerTransaction
    Private Photo As Byte()

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim singer As New DataLayer.ClsSinger
        singer.Name = txtSingerName.Text
        singer.Gender = cboGender.SelectedItem.ToString
        singer.Photo = Photo
        If singerTransaction.addNewsinger(singer) = True Then
            Message.Visible = True
        Else
            Message.Visible = True
            Message.Text = "Inserting is failure!!!"
            Message.ForeColor = Color.Red
        End If
    End Sub

    Private Sub pbPhoto_Click(sender As Object, e As EventArgs) Handles pbPhoto.Click
        If OpenPhoto.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            pbPhoto.Image = Image.FromFile(OpenPhoto.FileName)
            Photo = getMemoryStream(OpenPhoto.FileName)
        End If
    End Sub

    Private Sub btnSingerList_Click(sender As Object, e As EventArgs) Handles btnSingerList.Click
        MessageBox.Show("List")
        frmSinger.Show()
        Me.Close()
    End Sub
End Class