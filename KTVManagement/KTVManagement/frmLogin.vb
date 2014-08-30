Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
        txtPassword.PasswordChar = "*"
    End Sub
   
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim dsUser As New DataSet
        Dim userTransaction As New ClsUserTransaction
        dsUser = userTransaction.getAllUsers()
        For Each row As DataRow In dsUser.Tables(0).Rows
            If row.Item(1).Equals(txtUsername.Text) And row.Item(2).Equals(txtPassword.Text) Then
                UserLogin.ID = row.Item(0)
                UserLogin.Username = row.Item(1)
                UserLogin.Password = row.Item(2)
                UserLogin.Position = row.Item(3)
                UserLogin.Photo = row.Item(4)
                If row.Item(3).Equals(1) Then
                    frmMainAdmin.Show()
                ElseIf row.Item(3).Equals(2) Then
                    frmMainStaff.Show()
                ElseIf row.Item(3).Equals(3) Then
                End If
                Me.Close()
            Else
                closeConnection()
            End If
        Next
    End Sub

End Class