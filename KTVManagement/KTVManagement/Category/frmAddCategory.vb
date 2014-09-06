﻿Public Class frmAddCategory

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

End Class