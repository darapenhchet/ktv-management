Public Class frmUpdateSinger

    Private singerTransaction As New DataLayer.ClsSingerTransaction
    Private Photo As Byte()

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddRoom.Click
        frmAddSinger.Show()
        Me.Close()
    End Sub

    Private Sub btnRoomList_Click(sender As Object, e As EventArgs) Handles btnRoomList.Click
        frmSinger.Show()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim singer As New DataLayer.ClsSinger
        singer.ID = CInt(txtID.Text)
        singer.Name = txtSingerName.Text
        singer.Gender = cboGender.SelectedItem.ToString
        singer.Photo = Photo
        If singerTransaction.updateSinger(singer) = True Then
            Message.Visible = True
        Else
            Message.Visible = True
            Message.Text = "You have not been update it!!!"
        End If
    End Sub

    Private Sub pbPhoto_Click(sender As Object, e As EventArgs) Handles pbPhoto.Click
        If OpenPhoto.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            pbPhoto.Image = Image.FromFile(OpenPhoto.FileName)
            Photo = getMemoryStream(OpenPhoto.FileName)
        End If
    End Sub
End Class