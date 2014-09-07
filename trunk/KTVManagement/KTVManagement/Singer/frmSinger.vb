Imports DataLayer
Public Class frmSinger

    Private dsSinger As New DataSet
    Private singerTransaction As New ClsSingerTransaction
    Private Sub frmSinger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displaySingerInformation()
    End Sub

    Private Sub displaySingerInformation()
        dsSinger = singerTransaction.getAllSingers
        dgvSingerList.DataSource = dsSinger.Tables(0)

        setGrdHeaderText("ID|Singer's Name|Gender|Photo", dgvSingerList)
        setGrdHeaderWidth("100|300|100|500", dgvSingerList)
        dgvSingerList.Columns(3).Visible = False
    End Sub
 
End Class