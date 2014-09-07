Imports DataLayer
Public Class frmSinger

    Private dsSinger As New DataSet
    Private singerTransaction As New ClsSingerTransaction
    Private Sub frmSinger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displaySingerInformation("")
    End Sub

    Private Sub displaySingerInformation(keyword As String)
        dsSinger = singerTransaction.getAllSingerByKeyword(keyword)
        dgvSingerList.DataSource = dsSinger.Tables(0)
        setGrdHeaderText("ID|Singer's Name|Gender|Photo", dgvSingerList)
        setGrdHeaderWidth("100|300|100|500", dgvSingerList)
        dgvSingerList.Columns(3).Visible = False
    End Sub
 
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dsSinger.Tables(0).Clear()
        dgvSingerList.DataSource = dsSinger.Tables(0)
        displaySingerInformation(txtSearch.Text)
    End Sub

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddRoom.Click

    End Sub
End Class