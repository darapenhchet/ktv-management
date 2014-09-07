Public Class frmAddLanguage



    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmAddLanguage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
    End Sub

    Private Sub btnLanguage_Click(sender As Object, e As EventArgs) Handles btnLanguage.Click
        frmLanguage.Show()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
End Class