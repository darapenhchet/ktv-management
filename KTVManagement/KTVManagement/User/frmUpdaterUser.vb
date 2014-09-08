Public Class frmUpdaterUser

    Private Photo As Byte()
    Private Sub frmUpdaterUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        frmAddUser.Show()
        Me.Close()
    End Sub

    Private Sub btnUserList_Click(sender As Object, e As EventArgs) Handles btnUserList.Click
        frmUser.Show()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim user As New DataLayer.ClsUser
        Dim userTransaction As New DataLayer.ClsUserTransaction
        Try
            user.ID = CInt(txtID.Text)
            user.Username = txtUsername.Text
            user.Password = txtPassword.Text
            user.Position = cboPosition.Text
            user.Photo = getMemoryStream(pbPhoto)
            If userTransaction.updateUser(user) = True Then
                success.Visible = True
            Else
                fail.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pbPhoto_Click(sender As Object, e As EventArgs) Handles pbPhoto.Click
        If OpenPhoto.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            pbPhoto.Image = Image.FromFile(OpenPhoto.FileName)
            Photo = getMemoryStream(pbPhoto)
        End If
    End Sub
End Class