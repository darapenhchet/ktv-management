Public Class frmUpdateProduction

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnAddProduction_Click(sender As Object, e As EventArgs) Handles btnAddProduction.Click
        frmAddProduction.Show()
        Me.Close()
    End Sub
End Class