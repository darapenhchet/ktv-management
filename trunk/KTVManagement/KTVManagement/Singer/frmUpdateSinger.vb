Public Class frmUpdateSinger

    Private singerTransaction As New DataLayer.ClsSingerTransaction
    Public Photo As Byte()

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
        singer.Gender = cboGender.Text
        singer.Photo = getMemoryStream(pbPhoto)
        singer.Nationality = txtNationality.Text
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
            Photo = getMemoryStream(pbPhoto)
        End If
    End Sub

    Private Sub frmUpdateSinger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
    End Sub


End Class