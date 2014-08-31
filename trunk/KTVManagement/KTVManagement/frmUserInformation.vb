Public Class frmUserInformation

    Private userTransaction As New ClsUserTransaction
    Private dsUser As New DataSet

    Private Sub frmUserInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
        displayUserInformation()
    End Sub

    Private Sub displayUserInformation()
        dsUser = userTransaction.getAllUsers()
        dgvUserInformation.DataSource = dsUser.Tables(0)
        For Each column As DataGridViewColumn In dgvUserInformation.Columns
            column.Width = (dgvUserInformation.Width - 4) / dgvUserInformation.Columns.Count
        Next
    End Sub
End Class