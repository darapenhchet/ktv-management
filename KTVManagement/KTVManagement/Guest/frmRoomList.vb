Public Class frmRoomList

    Private dsRoom As New DataSet
    Private roomTransaction As New DataLayer.ClsRoomTransaction

    Public Sub DisplayRoomInformation(Keyword As String)
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
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub frmCheckInGuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Center(Panel1, Me)
        DisplayRoomInformation("")
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dsRoom.Tables(0).Clear()
        dgvRoomList.DataSource = dsRoom.Tables(0)
        DisplayRoomInformation(txtSearch.Text)
    End Sub

End Class