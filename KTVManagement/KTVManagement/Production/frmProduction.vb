Public Class frmProduction

    Private productionTransaction As New DataLayer.ClsProductionTransaction
    Private dsProduction As New DataSet

    Private Sub btnAddProduction_Click(sender As Object, e As EventArgs) Handles btnAddProduction.Click
        frmAddProduction.Show()
        Me.Close()
    End Sub

    Private Sub btnUpdateProduction_Click(sender As Object, e As EventArgs)
        frmUpdateProduction.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub frmProduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayProductionInformation("")
        setGrdHeaderText("ID|Production|Photo", dgvProductionList)
        setGrdHeaderWidth("100|300|600", dgvProductionList)
        dgvProductionList.Columns(2).Visible = False
    End Sub

    Public Sub DisplayProductionInformation(keyword As String)
        dsProduction = productionTransaction.getProductionByKeyword(keyword)
        dgvProductionList.DataSource = dsProduction.Tables(0)
    End Sub

    Private Sub btnUpdateProduction_Click_1(sender As Object, e As EventArgs) Handles btnUpdateProduction.Click
        Try
            frmUpdateProduction.Show()
            frmUpdateProduction.txtID.Text = dgvProductionList.CurrentRow.Cells(0).Value
            frmUpdateProduction.txtProduction.Text = dgvProductionList.CurrentRow.Cells(1).Value
            Dim imageData As Byte() = {}
            Try
                imageData = CType(dgvProductionList.CurrentRow.Cells(2).Value, Byte())
            Catch ex As Exception
            End Try

            If Not imageData Is Nothing Then
                Dim ms As New System.IO.MemoryStream(imageData)
                frmUpdateProduction.pbPhoto.Image = Image.FromStream(ms)
            End If
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dsProduction.Tables(0).Clear()
        dgvProductionList.DataSource = dsProduction.Tables(0)
        DisplayProductionInformation(txtSearch.Text)
    End Sub
End Class