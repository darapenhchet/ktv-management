﻿Imports MySql.Data.MySqlClient
Public Class ClsSongDetailsTransaction
    Private dsSongDetails As New DataSet

    Public Function addNewSongDetails(songDetails As ClsSongDetails) As Boolean
        Dim sql As String = "call spAddNewSongDetails(@SingerID,@SongID)"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Command.CommandType = CommandType.StoredProcedure
                Command.Parameters.AddWithValue("@SingerID", songDetails.SingerID)
                Command.Parameters.AddWithValue("@SongID", songDetails.SongID)
                Command.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
