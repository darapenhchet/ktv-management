Public Class frmGuestHistory

    Private dsGuest As New DataSet
    Private guestTransaction As New DataLayer.ClsGuestTransaction
    Private Sub btnGuestList_Click(sender As Object, e As EventArgs) Handles btnGuestList.Click
        frmGuest.Show()
        Me.Close()
    End Sub

    Private Sub btnRoomList_Click(sender As Object, e As EventArgs) Handles btnRoomList.Click
        frmRoomList.Show()
        Me.Close()
    End Sub

    Private Sub frmGuestHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dsGuest = guestTransaction.getGuestHistory("")
            dgvGuestHistory.DataSource = dsGuest.Tables(0)
            setGrdHeaderText("Guest ID|Room ID|Room Name|Room Type|Time In|Time Out|Duration|Price|Amount", dgvGuestHistory)
            setGrdHeaderWidth("100|100|100|100|150|150|100|100|100", dgvGuestHistory)

            Dim UnitPriceCellStyle As New DataGridViewCellStyle
            UnitPriceCellStyle.Format = "c"
            UnitPriceCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvGuestHistory.Columns(8).DefaultCellStyle = UnitPriceCellStyle
            dgvGuestHistory.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

            Dim TimeOutCellStyle As New DataGridViewCellStyle
            TimeOutCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            TimeOutCellStyle.Format = "c"
            dgvGuestHistory.Columns(7).DefaultCellStyle = TimeOutCellStyle
            dgvGuestHistory.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

            Dim DurationCellStyle As New DataGridViewCellStyle
            DurationCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvGuestHistory.Columns(2).DefaultCellStyle = DurationCellStyle
            dgvGuestHistory.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            dsGuest.Tables(0).Clear()
            dgvGuestHistory.DataSource = dsGuest.Tables(0)
            dsGuest = guestTransaction.getGuestHistory(txtSearch.Text)
            dgvGuestHistory.DataSource = dsGuest.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMainAdmin.Visible = True
        Me.Close()
    End Sub
End Class