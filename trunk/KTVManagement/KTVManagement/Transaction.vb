Imports System.Configuration
Imports MySql.Data.MySqlClient

Module Transaction

    Private con As MySqlConnection
    Private _user As ClsUser

    Public Function openConnection() As Boolean
        Try
            con = New MySqlConnection(ConfigurationManager.ConnectionStrings("MYSQLSERVER").ToString)
            con.Open()
            Return True
        Catch ex As Exception
            MessageBox.Show("Connection failure!!! " + ex.Message)
            Return False
        End Try
    End Function

    Public Function getConnection() As MySqlConnection
        Return con
    End Function

    Public Function closeConnection() As Boolean
        Try
            con.Close()
            con = Nothing
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Property UserLogin() As ClsUser
        Get
            Return _user
        End Get
        Set(value As ClsUser)
            _user = value
        End Set
    End Property
End Module
