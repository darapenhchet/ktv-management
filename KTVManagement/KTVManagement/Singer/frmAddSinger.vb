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
        singer.Photo = getMemoryStream(pbPhoto)
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
            Photo = getMemoryStream(pbPhoto)
        End If
    End Sub

    Private Sub btnSingerList_Click(sender As Object, e As EventArgs) Handles btnSingerList.Click
        frmSinger.Show()
        Me.Close()
    End Sub

    Private Sub frmAddSinger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
    End Sub
End Class