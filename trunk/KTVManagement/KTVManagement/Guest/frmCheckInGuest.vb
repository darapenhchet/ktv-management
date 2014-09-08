Public Class frmCheckInGuest

    Private Sub frmCheckInGuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Center(Panel1, Me)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

End Class