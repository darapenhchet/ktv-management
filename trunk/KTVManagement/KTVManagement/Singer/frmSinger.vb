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


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnUpdateSinger_Click(sender As Object, e As EventArgs) Handles btnUpdateSinger.Click
        Try
            frmUpdateSinger.Show()
            frmUpdateSinger.txtID.Text = dgvSingerList.CurrentRow.Cells(0).Value
            frmUpdateSinger.txtSingerName.Text = dgvSingerList.CurrentRow.Cells(1).Value
            frmUpdateSinger.cboGender.Text = dgvSingerList.CurrentRow.Cells(2).Value
            Dim imageData As Byte() = CType(dgvSingerList.CurrentRow.Cells(3).Value, Byte())
            If Not imageData Is Nothing Then
                Dim ms As New System.IO.MemoryStream(imageData)
                frmUpdateSinger.pbPhoto.Image = Image.FromStream(ms)
            End If
            Me.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAddSinger_Click(sender As Object, e As EventArgs) Handles btnAddSinger.Click
        frmAddSinger.Show()
        Me.Close()
    End Sub
End Class