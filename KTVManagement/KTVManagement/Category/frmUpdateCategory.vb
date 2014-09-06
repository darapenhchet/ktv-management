Public Class frmUpdateCategory

    Private categoryTransaction As New DataLayer.ClsCategoryTransaction

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim category As New DataLayer.ClsCategory
        Try
            category.ID = txtID.Text
            category.Category = txtCategory.Text
            category.Description = txtDescription.Text
            If categoryTransaction.updateCategory(category) = True Then
                Message.Visible = True
            Else
                Message.Visible = True
                Message.Text = "Updating is failure!!!"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class