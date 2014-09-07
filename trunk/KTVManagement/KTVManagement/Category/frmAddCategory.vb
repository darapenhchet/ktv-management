Public Class frmAddCategory

    Private categoryTransaction As New DataLayer.ClsCategoryTransaction

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim category As New DataLayer.ClsCategory
        Try
            category.Category = txtCategory.Text
            category.Description = txtDescription.Text
            If categoryTransaction.addNewCategory(category) = True Then
                Message.Visible = True
                Message.Text = "You have been inserted successfully!!!"
            Else
                Message.Visible = True
                Message.Text = "Inserting is failure!!!"
                Message.ForeColor = Color.Red
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnRoomList_Click(sender As Object, e As EventArgs) Handles btnRoomList.Click
        frmCategoryInformation.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub frmAddCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
    End Sub
End Class