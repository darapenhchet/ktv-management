﻿Public Class frmCategoryInformation

    Private dsCategory As New DataSet
    Private categoryTransaction As New DataLayer.ClsCategoryTransaction
    Private RowIndex As Integer

    Private Sub frmCategoryInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
        DisplayCategoryInformation()
        setGrdHeaderText("ID|Category|Description", dgvCategory)
        setGrdHeaderWidth("100|400|500", dgvCategory)
        dgvCategory.RowHeadersWidth = 30
    End Sub

    Private Sub DisplayCategoryInformation()
        Try
            dsCategory = categoryTransaction.getAllCategory()
            dgvCategory.DataSource = dsCategory.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub dgvCategory_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCategory.CellMouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.RowIndex = e.RowIndex
            Me.cmsModifyCategory.Show(Me.dgvCategory, e.Location)
            cmsModifyCategory.Show(Cursor.Position)
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            If categoryTransaction.deleteCategory(CInt(dgvCategory.Rows(RowIndex).Cells(0).Value)) Then
                'dgvCategory.Rows.RemoveAt(RowIndex)
                MessageBox.Show("You category has been deleted!!!")
            Else
                MessageBox.Show("You cannot delete this category!!!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        btnUpdateRoom_Click(sender, e)
    End Sub

    Private Sub btnUpdateRoom_Click(sender As Object, e As EventArgs) Handles btnUpdateRoom.Click
        Try
            MessageBox.Show("Update")
            frmUpdateCategory.txtID.Text = dgvCategory.CurrentRow.Cells(0).Value
            frmUpdateCategory.txtCategory.Text = dgvCategory.CurrentRow.Cells(1).Value
            Try
                frmUpdateCategory.txtDescription.Text = dgvCategory.CurrentRow.Cells(2).Value
            Catch ex As Exception
                frmUpdateCategory.txtDescription.Text = ""
            End Try
            frmUpdateCategory.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddRoom.Click
        frmAddCategory.Visible = True
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            dsCategory.Tables(0).Clear()
            dgvCategory.DataSource = dsCategory
            dsCategory = categoryTransaction.getAllCategoryByKeyword(txtSearch.Text)
            dgvCategory.DataSource = dsCategory.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class