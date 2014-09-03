Imports MySql.Data.MySqlClient
Public Class ClsSongTransaction

    Private dsSong As New DataSet

    Public Function getAllSongs() As DataSet
        Dim sql As String = "SELECT * FROM Songs"
        Try
            Using Command As MySqlCommand = DataLayer.ClsConnection.con.CreateCommand
                Command.CommandText = sql
                Using adt As MySqlDataAdapter = New MySqlDataAdapter(Command)
                    adt.Fill(dsSong)
                    Return dsSong
                End Using
            End Using
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function getSongById(id As Integer) As ClsSong
        Dim sql As String = "SELECT * FROM Songs WHERE songId = @ID"
        Dim song As New ClsSong
        Dim dr As MySqlDataReader
        Try
            Using Command As MySqlCommand = DataLayer.ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Command.Parameters.AddWithValue("@ID", id)
                dr = Command.ExecuteReader
                While dr.Read
                    song.ID = dr.GetInt32(0)
                    song.Title = dr.GetString(1)
                    song.Album = dr.GetString(2)
                End While
                Return song

            End Using
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function searchSongByKeyword(keyword As String) As DataSet
        Try

        Catch ex As Exception

        End Try
    End Function

    Public Function addNewSong(song As ClsSong) As Boolean
        Try

        Catch ex As Exception

        End Try
    End Function

    Public Function deleteSong(id As Integer) As Boolean
        Try

        Catch ex As Exception

        End Try
    End Function

    Public Function updateSong(song As ClsSong) As Boolean
        Try

        Catch ex As Exception

        End Try
    End Function
End Class
