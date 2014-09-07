Public Class frmUserInformation

    Private userTransaction As New DataLayer.ClsUserTransaction
    Private dsUser As New DataSet
    Private Photo As Byte()

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
        pbPhoto.Image = My.Resources.Photo
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim user As New DataLayer.ClsUser
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
        Dim user As New DataLayer.ClsUser
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
        Try
            If userTransaction.deleteUser(CInt(txtID.Text)) = True Then
                displayUserInformation()
                MessageBox.Show("You have been deleted successfully!!!")
            Else
                MessageBox.Show("You have not been deleted!!!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub pbUser_Click(sender As Object, e As EventArgs) Handles pbPhoto.Click
        If OpenUserPhoto.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            pbPhoto.Image = Image.FromFile(OpenUserPhoto.FileName)
            Photo = getMemoryStream(pbPhoto)
        End If
    End Sub

    Private Sub dgvUserInformation_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserInformation.CellClick
        Try
            txtID.Text = dgvUserInformation.CurrentRow.Cells(0).Value
            txtUsername.Text = dgvUserInformation.CurrentRow.Cells(1).Value
            txtPassword.Text = dgvUserInformation.CurrentRow.Cells(2).Value
            cboPosition.SelectedItem = dgvUserInformation.CurrentRow.Cells(3).Value

            Dim imageData As Byte() = CType(dgvUserInformation.CurrentRow.Cells(4).Value, Byte())
            If Not imageData Is Nothing Then
                Dim ms As New System.IO.MemoryStream(imageData)
                pbPhoto.Image = Image.FromStream(ms)
                Photo = imageData
            End If
        Catch ex As Exception
        End Try
    End Sub
    

End Class