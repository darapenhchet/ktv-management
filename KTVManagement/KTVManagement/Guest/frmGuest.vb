Public Class frmGuest
    Private dsGuest As New DataSet
    Private guestTransaction As New DataLayer.ClsGuestTransaction

    Private Sub frmGuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsGuest = guestTransaction.getAllGuests()
        dgvGuestList.DataSource = dsGuest.Tables(0)

        setGrdHeaderText("Guest ID|Room ID|Duration|Time In|Time Out|Amount", dgvGuestList)
        setGrdHeaderWidth("100|100|100|250|250|200", dgvGuestList)

        Dim UnitPriceCellStyle As New DataGridViewCellStyle
        UnitPriceCellStyle.Format = "c"
        UnitPriceCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvGuestList.Columns(5).DefaultCellStyle = UnitPriceCellStyle
        dgvGuestList.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

        Dim TimeOutCellStyle As New DataGridViewCellStyle
        TimeOutCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvGuestList.Columns(4).DefaultCellStyle = TimeOutCellStyle
        dgvGuestList.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

        Dim TimeInCellStyle As New DataGridViewCellStyle
        TimeInCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvGuestList.Columns(3).DefaultCellStyle = TimeInCellStyle
        dgvGuestList.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

        Dim DurationCellStyle As New DataGridViewCellStyle
        DurationCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvGuestList.Columns(2).DefaultCellStyle = DurationCellStyle
        dgvGuestList.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

    End Sub

    Public Sub DisplayGuestInformation(keyword As String)

    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnRoomList_Click(sender As Object, e As EventArgs) Handles btnRoomList.Click
        frmRoomList.Show()
        Me.Close()
    End Sub

End Class