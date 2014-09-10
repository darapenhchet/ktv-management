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
        Try
            For Each row As DataRow In dsUser.Tables(0).Rows
                If row.Item(1).Equals(txtUsername.Text) And row.Item(2).Equals(txtPassword.Text) Then
                    found = True
                    DataLayer.ClsConnection.UserLogin = New DataLayer.ClsUser
                    DataLayer.ClsConnection.UserLogin.ID = row.Item(0)
                    DataLayer.ClsConnection.UserLogin.Username = row.Item(1)
                    DataLayer.ClsConnection.UserLogin.Password = row.Item(2)
                    DataLayer.ClsConnection.UserLogin.Position = row.Item(3)

                    frmMainAdmin.Show()
                    Me.Visible = False
                    'If row.Item(3).Equals("Admin") Then
                    '    Me.Visible = False
                    '    frmMainAdmin.Show()
                    'ElseIf row.Item(3).Equals("Staff") Then
                    '    Me.Visible = False
                    '    frmMainStaff.Show()
                    'End If

                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub


End Class