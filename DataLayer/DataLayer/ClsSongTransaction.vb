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
        Dim sql As String = "INSERT INTO songs(title,album,categoryId,productionId,languageId,path) VALUES(@Title,@Album,@CategoryID,@ProductionID,@LanguageID,@Path);SELECT LAST_INSERT_ID();"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                'Command.CommandType = CommandType.StoredProcedure
                Command.Parameters.AddWithValue("@Title", song.Title)
                Command.Parameters.AddWithValue("@Album", song.Album)
                Command.Parameters.AddWithValue("@CategoryID", song.Category.ID)
                Command.Parameters.AddWithValue("@ProductionID", song.Production.ID)
                Command.Parameters.AddWithValue("@LanguageID", song.Production.ID)
                Command.Parameters.AddWithValue("@Path", song.Path)
                song.ID = CInt(Command.ExecuteScalar)
                Return True
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
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
