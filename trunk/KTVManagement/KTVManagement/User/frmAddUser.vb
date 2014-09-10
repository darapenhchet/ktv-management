Public Class frmAddUser

    Private Photo As Byte()
    Private Sub frmAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMainAdmin.Show()
        Me.Close()
    End Sub

    Private Sub btnRoomList_Click(sender As Object, e As EventArgs) Handles btnRoomList.Click
        frmUser.Show()

    End Sub

    Private Sub pbPhoto_Click(sender As Object, e As EventArgs) Handles pbPhoto.Click
        If OpenPhoto.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            pbPhoto.Image = Image.FromFile(OpenPhoto.FileName)
            Photo = getMemoryStream(pbPhoto)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim user As New DataLayer.ClsUser
            Dim userTransaction As New DataLayer.ClsUserTransaction
            user.Username = txtUsername.Text
            user.Password = txtPassword.Text
            user.Position = cboPosition.Text
            user.Photo = getMemoryStream(pbPhoto)

            If userTransaction.addNewUser(user) = True Then
                success.Visible = True
            Else
                fail.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class