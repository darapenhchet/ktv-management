Public Class frmUserInformation

    Private userTransaction As New ClsUserTransaction
    Private dsUser As New DataSet
    Private Photo As String

    Private Sub frmUserInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
        displayUserInformation()
    End Sub

    Private Sub displayUserInformation()
        dsUser = userTransaction.getAllUsers()
        dgvUserInformation.DataSource = dsUser.Tables(0)
        For Each column As DataGridViewColumn In dgvUserInformation.Columns
            column.Width = (dgvUserInformation.Width - 4) / dgvUserInformation.Columns.Count
        Next
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtID.Text = "Auto ID"
        txtUsername.Text = ""
        txtPassword.Text = ""
        pbUser.Image = My.Resources.Photo
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim user As New ClsUser
        user.Username = txtUsername.Text
        user.Password = txtPassword.Text
        user.Position = cboPosition.SelectedItem.ToString
        user.Photo = Photo

        If userTransaction.addNewUser(user) = True Then
            displayUserInformation()
            MessageBox.Show("You have been inserted successfully!!!")
        Else
            MessageBox.Show("You have not been inserted!!!")
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim user As New ClsUser
        user.ID = CInt(txtID.Text)
        user.Username = txtUsername.Text
        user.Password = txtPassword.Text
        user.Position = cboPosition.SelectedItem.ToString
        user.Photo = Photo
        If userTransaction.updateUser(user) = True Then
            displayUserInformation()
            MessageBox.Show("You have been updated successfully!!!")
        Else
            MessageBox.Show("You have not been updated failure!!!")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If userTransaction.deleteUser(CInt(txtID.Text)) = True Then
            displayUserInformation()
            MessageBox.Show("You have been deleted successfully!!!")
        Else
            MessageBox.Show("You have not been deleted!!!")
        End If
    End Sub

    Private Sub pbUser_Click(sender As Object, e As EventArgs) Handles pbUser.Click
        If OpenUserPhoto.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            pbUser.Image = Image.FromFile(OpenUserPhoto.FileName)
            Photo = OpenUserPhoto.FileName
        End If
    End Sub

    Private Sub dgvUserInformation_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgvUserInformation.RowStateChanged

    End Sub
End Class