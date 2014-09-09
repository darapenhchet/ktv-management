﻿Public Class frmRoom

    Private dsRoom As New DataSet
    Private roomTransaction As New DataLayer.ClsRoomTransaction
    Private RowIndex As Integer

    Private Sub frmRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
        DisplayRoomInformation()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        frmMainAdmin.Show()
        Me.Close()
    End Sub

    Public Sub DisplayRoomInformation()
        dsRoom = roomTransaction.getAllRoomByKeyword("")
        dgvRoomList.DataSource = dsRoom.Tables(0)
        setGrdHeaderText("ID|Room|Room Type|Unit Price|Discount|Status", dgvRoomList)
        setGrdHeaderWidth("100|250|200|200|150|100", dgvRoomList)
        dgvRoomList.RowHeadersWidth = 30

        Dim UnitPriceCellStyle As New DataGridViewCellStyle
        UnitPriceCellStyle.Format = "c"
        UnitPriceCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvRoomList.Columns(3).DefaultCellStyle = UnitPriceCellStyle
        dgvRoomList.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

        Dim DiscountCellStyle As New DataGridViewCellStyle
        DiscountCellStyle.Format = "P"
        DiscountCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvRoomList.Columns(4).DefaultCellStyle = DiscountCellStyle
        dgvRoomList.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub btnAddRoom_Click_1(sender As Object, e As EventArgs) Handles btnAddRoom.Click
        frmAddRoom.Visible = True
        Me.Close()
    End Sub

    Private Sub dgvRoomList_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvRoomList.CellMouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.RowIndex = e.RowIndex
            Me.cmsModifyRoom.Show(Me.dgvRoomList, e.Location)
            cmsModifyRoom.Show(Cursor.Position)
        End If
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If Not Me.dgvRoomList.Rows(Me.RowIndex).IsNewRow Then
            dgvRoomList.Rows.RemoveAt(Me.RowIndex)
        End If
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        btnUpdateRoom_Click(sender, e)
    End Sub

    Private Sub btnUpdateRoom_Click(sender As Object, e As EventArgs) Handles btnUpdateRoom.Click
        Try
            frmUpdateRoom.txtID.Text = dgvRoomList.CurrentRow.Cells(0).Value
            frmUpdateRoom.txtName.Text = dgvRoomList.CurrentRow.Cells(1).Value
            frmUpdateRoom.cboType.Text = dgvRoomList.CurrentRow.Cells(2).Value
            frmUpdateRoom.txtUnitPrice.Text = dgvRoomList.CurrentRow.Cells(3).Value
            frmUpdateRoom.txtDiscount.Text = dgvRoomList.CurrentRow.Cells(4).Value
            frmUpdateRoom.cboStatus.Text = dgvRoomList.CurrentRow.Cells(5).Value
            frmUpdateRoom.Show()
            Me.Close()
        Catch ex As Exception
        End Try
        
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMainAdmin.Visible = True
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            dsRoom.Tables(0).Clear()
            dgvRoomList.DataSource = dsRoom.Tables(0)
            dsRoom = roomTransaction.getAllRoomByKeyword(txtSearch.Text)
            dgvRoomList.DataSource = dsRoom.Tables(0)
        Catch Ex As Exception
            MessageBox.Show(Ex.Message)
        End Try
    End Sub


End Class