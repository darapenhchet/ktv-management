Imports DataLayer
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
        DataLayer.ClsConnection.OpenConnection()
        Dim dsUser As New DataSet
        Dim userTransaction As New DataLayer.ClsUserTransaction
        dsUser = userTransaction.getAllUsers()
        Dim found As Boolean = False
        For Each row As DataRow In dsUser.Tables(0).Rows
            If row.Item(1).Equals(txtUsername.Text) And row.Item(2).Equals(txtPassword.Text) Then
                found = True
                DataLayer.ClsConnection.UserLogin = New DataLayer.ClsUser
                DataLayer.ClsConnection.UserLogin.ID = row.Item(0)
                DataLayer.ClsConnection.UserLogin.Username = row.Item(1)
                DataLayer.ClsConnection.UserLogin.Password = row.Item(2)
                DataLayer.ClsConnection.UserLogin.Position = row.Item(3)
                'If row.Item(4) Is Nothing Then
                '    UserLogin.Photo = row.Item(4)
                'End If
                If row.Item(3).Equals("Admin") Then
                    Me.Visible = False
                    frmMainAdmin.Show()
                ElseIf row.Item(3).Equals(2) Then
                    frmMainStaff.Show()
                ElseIf row.Item(3).Equals(3) Then
                End If

            End If

        Next
    End Sub


End Class