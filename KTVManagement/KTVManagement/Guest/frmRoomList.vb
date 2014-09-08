Public Class frmRoomList

    Private dsRoom As New DataSet
    Private roomTransaction As New DataLayer.ClsRoomTransaction

    Public Sub DisplayRoomInformation(Keyword As String)
        Try
            dsRoom = roomTransaction.getAllRoomByKeyword(Keyword)
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub frmCheckInGuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Center(Panel1, Me)
        DisplayRoomInformation("")
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            dsRoom.Tables(0).Clear()
            dgvRoomList.DataSource = dsRoom.Tables(0)
            DisplayRoomInformation(txtSearch.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub btnCheckInGuest_Click(sender As Object, e As EventArgs) Handles btnCheckInGuest.Click
        Try
            If dgvRoomList.CurrentRow.Cells(5).Value.Equals("FREE") Then
                frmCheckInGuest.Show()
                frmCheckInGuest.txtRoomID.Text = dgvRoomList.CurrentRow.Cells(0).Value
                frmCheckInGuest.txtRoom.Text = dgvRoomList.CurrentRow.Cells(1).Value
                frmCheckInGuest.txtRoomType.Text = dgvRoomList.CurrentRow.Cells(2).Value
                frmCheckInGuest.txtPrice.Text = dgvRoomList.CurrentRow.Cells(3).Value
                frmCheckInGuest.txtDiscount.Text = dgvRoomList.CurrentRow.Cells(4).Value
                frmCheckInGuest.txtAmount.Text = "0"
                frmCheckInGuest.txtDuration.Focus()
                Me.Close()
            Else
                MessageBox.Show("This room is busy. Please wait a moment!!!")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuestUsingList_Click(sender As Object, e As EventArgs) Handles btnGuestUsingList.Click
        frmGuest.Show()
        Me.Close()
    End Sub
End Class