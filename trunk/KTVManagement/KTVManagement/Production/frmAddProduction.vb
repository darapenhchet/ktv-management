Public Class frmAddProduction

    Private Sub btnProductionList_Click(sender As Object, e As EventArgs) Handles btnProductionList.Click
        frmProduction.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class