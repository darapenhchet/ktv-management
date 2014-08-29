Imports MySql.Data.MySqlClient

Module Transactions

    Dim cnn As New MySqlConnection
    Dim command As New MySqlCommand
    Dim dataset As New DataSet
    Dim dataadapter As New MySqlDataAdapter

    Public Sub openConnection()
        cnn.ConnectionString = ("server=localhost;user=root;password=123;database=KTVManagement")
        Try
            cnn.Open()
            MessageBox.Show("connected..")
        Catch ex As Exception
            MsgBox("NOt Connect!!", vbQuestion + vbOKCancel)
        End Try
    End Sub

    Public Function getConnection() As MySqlConnection
        Return cnn
    End Function


    Public Function closeConnection() As Boolean
        Try
            cnn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
   
End Module
