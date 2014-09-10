Public Class frmGuest
    Private dsGuest As New DataSet
    Private guestTransaction As New DataLayer.ClsGuestTransaction

    Private Sub frmGuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Timer1.Enabled = True
            Timer1.Interval = 1000
            dsGuest = guestTransaction.searchGuestByKeyword("")
            'dsGuest = guestTransaction.getGuestUsingDetails()
            dgvGuestList.DataSource = dsGuest.Tables(0)

            setGrdHeaderText("Guest ID|Room ID|Room Name|Room Type|Time In|Time Out|Duration|LeftTime|Price|Amount", dgvGuestList)
            setGrdHeaderWidth("70|70|120|70|120|120|100|70|100|100", dgvGuestList)

            Dim UnitPriceCellStyle As New DataGridViewCellStyle
            UnitPriceCellStyle.Format = "c"
            UnitPriceCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvGuestList.Columns(8).DefaultCellStyle = UnitPriceCellStyle
            dgvGuestList.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

            Dim TimeOutCellStyle As New DataGridViewCellStyle
            TimeOutCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            TimeOutCellStyle.Format = "c"
            dgvGuestList.Columns(7).DefaultCellStyle = TimeOutCellStyle
            dgvGuestList.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

            Dim DurationCellStyle As New DataGridViewCellStyle
            DurationCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvGuestList.Columns(2).DefaultCellStyle = DurationCellStyle
            dgvGuestList.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub DisplayGuestInformation(keyword As String)
        Try
            dsGuest = guestTransaction.getGuestUsingDetails()
            dgvGuestList.DataSource = dsGuest.Tables(0)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMainAdmin.Visible = True
        Me.Close()
    End Sub

    Private Sub btnRoomList_Click(sender As Object, e As EventArgs) Handles btnRoomList.Click
        frmRoomList.Show()
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            dsGuest.Tables(0).Clear()
            dgvGuestList.DataSource = dsGuest.Tables(0)
            dsGuest = guestTransaction.searchGuestByKeyword(txtSearch.Text)
            dgvGuestList.DataSource = dsGuest.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmGuestHistory.Show()
        Me.Close()
    End Sub


    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    Dim now As New Date
    '    now = TimeOfDay
    '    Dim checkIn As New Date
    '    checkIn = dgvGuestList.Rows(0).Cells(5).Value

    '    Dim currentDateTime As Date = DateTime.Now()

    '    If (DateDiff(DateInterval.Second, now, checkIn)) > 0 Then
    '        MessageBox.Show("Now is greater than checkIn " & (DateDiff(DateInterval.Second, now, checkIn)))
    '    Else
    '        MessageBox.Show("Now is not greater than checkIn " & (DateDiff(DateInterval.Second, now, checkIn)))
    '    End If
    'End Sub

End Class