Public Class frmSingerInformation

    Private singerTransaction As New ClsSingerTransaction
    Private dsSinger As New DataSet
 
    Private Sub frmSingerInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
        dsSinger = singerTransaction.getAllSingers

        dgvSingerInformation.DataSource = dsSinger.Tables(0)
    End Sub

End Class