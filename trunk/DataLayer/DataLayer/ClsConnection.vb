Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class ClsConnection
    Private Shared _con As MySqlConnection
    Private Shared _user As New ClsUser

    Public Shared Function OpenConnection() As Boolean
        Try
            _con = New MySqlConnection(ConfigurationManager.ConnectionStrings("MYSQLSERVER").ToString)
            _con.Open()
            Return True
        Catch ex As Exception
            ''MessageBox.Show("Connection failure!!! " + ex.Message)
            Return False
        End Try
    End Function

    Public Shared Property Con As MySqlConnection
        Get
            Return _con
        End Get
        Set(value As MySqlConnection)
            _con = value
        End Set
    End Property

    Public Shared Function closeConnection() As Boolean
        Try
            con.Close()
            con = Nothing
            Return True
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Shared Property UserLogin() As ClsUser
        Get
            Return _user
        End Get
        Set(value As ClsUser)
            _user = value
        End Set
    End Property

End Class
