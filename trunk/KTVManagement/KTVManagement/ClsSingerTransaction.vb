﻿Imports MySql.Data.MySqlClient
Public Class ClsSingerTransaction
    Private dsSinger As DataSet

    Public Function getAllSingers() As DataSet
        Dim sql As String = "spGetAllSingers"
        Try
            Using Command As MySqlCommand = con.CreateCommand
                Command.CommandText = sql
                Command.CommandType = CommandType.StoredProcedure
                Using adt As MySqlDataAdapter = New MySqlDataAdapter(Command)
                    dsSinger = New DataSet
                    adt.Fill(dsSinger)
                    Return dsSinger
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function addNewsinger(singer As ClsSinger) As Boolean
        Try
            Using Command As MySqlCommand = con.CreateCommand
                Command.CommandText = "spAddSinger"
                Command.CommandType = CommandType.StoredProcedure
                Command.Parameters.AddWithValue("@singerName", singer.Name)
                Command.Parameters.AddWithValue("@gender", singer.Gender.Substring(0, 1))
                Command.Parameters.AddWithValue("@photo", getMemoryStream(singer.Photo).GetBuffer)
                Command.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Function updateSinger(singer As ClsSinger) As Boolean
        Try
            Using Command As MySqlCommand = con.CreateCommand
                Command.CommandText = "UPDATE Singers SET singerName = @singerName, gender = @gender, photo = @photo WHERE singerID = @singerID"

                Command.Parameters.AddWithValue("@singerID", singer.ID)
                Command.Parameters.AddWithValue("@singerName", singer.Name)
                Command.Parameters.AddWithValue("@gender", singer.Gender.Substring(0, 1))
                Command.Parameters.AddWithValue("@photo", getMemoryStream(singer.Photo).GetBuffer)
                Command.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Function deleteSinger(id As Integer) As Boolean
        Try
            Using Command As MySqlCommand = con.CreateCommand
                Command.CommandText = "DELETE FROM Singers WHERE singerId = @singerId"
                Command.Parameters.AddWithValue("@singerId", id)
                Command.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try

    End Function

    Public Function searchSingerByKeyword(keyword As String) As DataSet

        Return Nothing
    End Function
End Class
