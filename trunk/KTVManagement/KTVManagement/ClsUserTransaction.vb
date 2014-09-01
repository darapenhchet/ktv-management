﻿Imports MySql.Data.MySqlClient
Public Class ClsUserTransaction
    ''' <summary>
    ''' dsUser for storing the record of the users
    ''' </summary>
    ''' <remarks></remarks>
    Private dsUser As New DataSet

    Public Function getAllUsers() As DataSet
        Dim sql As String = "spGetAllUsers"
        Try
            Using Command As MySqlCommand = con.CreateCommand
                Command.CommandText = sql
                Command.CommandType = CommandType.StoredProcedure
                Using adt As MySqlDataAdapter = New MySqlDataAdapter(Command)
                    adt.Fill(dsUser)
                    Return dsUser
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function addNewUser(user As ClsUser) As Boolean
        Dim sql As String = "spAddNewUser"
        Try
            Using Command As MySqlCommand = con.CreateCommand
                Command.CommandText = sql
                Command.CommandType = CommandType.StoredProcedure
                Command.Parameters.AddWithValue("username", user.Username)
                Command.Parameters.AddWithValue("password", user.Password)
                Command.Parameters.AddWithValue("position", user.Position)
                Command.Parameters.AddWithValue("photo", getMemoryStream(user.Photo).GetBuffer)
                Command.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function
End Class
