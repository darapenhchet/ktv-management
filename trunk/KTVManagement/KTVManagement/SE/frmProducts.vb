Public Class frmProducts

    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles Me.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
        setGrdHeaderText("ID|Name|Qty|Category|Purchase|Sal5e|Action", dgvSingerList)
        setGrdHeaderWidth("100|300|100|150|150|200|200", dgvSingerList)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

    End Sub
End Class