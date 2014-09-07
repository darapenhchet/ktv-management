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
    End Sub

    Public Sub DisplayProductionInformation(keyword As String)
        dsProduction = productionTransaction.getProductionByKeyword(keyword)
        dgvProductionList.DataSource = dsProduction.Tables(0)
        setGrdHeaderText("ID|Production|Photo", dgvProductionList)
        setGrdHeaderWidth("100|300|600", dgvProductionList)
        dgvProductionList.Columns(2).Visible = False
    End Sub

    Private Sub btnUpdateProduction_Click_1(sender As Object, e As EventArgs) Handles btnUpdateProduction.Click
        frmUpdateProduction.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class