Imports MySql.Data.MySqlClient
Public Class ClsSongDetailsTransaction
    Private dsSongDetails As New DataSet

    Public Function addNewSongDetails(songDetails As ClsSongDetails) As Boolean
        Dim sql As String = "INSERT INTO songDetails(singerId,songId) VALUES(@SingerID,@SongID)"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
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

    Public Function DeleteSongDetails(id As Integer) As Boolean
        Dim sql As String = "DELETE FROM songDetails WHERE songId = @SongID"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Command.Parameters.AddWithValue("@SongID", id)
                Command.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function getAllSongDetails() As DataSet
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = "spGetAllSongLists"
                Command.CommandType = CommandType.StoredProcedure
                Using adt As MySqlDataAdapter = New MySqlDataAdapter(Command)
                    adt.Fill(dsSongDetails)
                End Using
                Return dsSongDetails
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
