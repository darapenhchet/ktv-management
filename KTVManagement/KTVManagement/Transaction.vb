Imports System.Configuration
Imports MySql.Data.MySqlClient

Module Transaction

    Private _con As MySqlConnection
    Private _user As ClsUser

    Public Function openConnection() As Boolean
        Try
            _con = New MySqlConnection(ConfigurationManager.ConnectionStrings("MYSQLSERVER").ToString)
            _con.Open()
            Return True
        Catch ex As Exception
            MessageBox.Show("Connection failure!!! " + ex.Message)
            Return False
        End Try
    End Function

    Public Property con As MySqlConnection
        Get
            Return _con
        End Get
        Set(value As MySqlConnection)
            _con = value
        End Set
    End Property

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
