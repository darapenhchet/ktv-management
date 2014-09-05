Imports DataLayer
Public Class frmProductionInformation
    Private dsProduction As New DataSet
    Private productionTransaction As New ClsProductionTransaction
    Private Sub frmProductionInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsProduction = productionTransaction.getAllProductions()

        For i = 0 To dsProduction.Tables(0).Rows.Count - 1
            With ListView1
                .Items.Add(dsProduction.Tables(0).Rows(i)(0))
                
                End With
        Next
    End Sub
End Class