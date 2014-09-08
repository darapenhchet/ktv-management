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

    Public Function getAllSongDetails(keyword As String) As DataSet
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = "	SELECT songs.songid AS ID ,songs.title AS Title ,songs.album AS Album,categories.category AS Category," & _
                                      " productions.production AS Production,languages.`language` AS Language,GROUP_CONCAT(singerName) As singer,songs.path AS Path " & _
                                      " FROM singers " & _
                                      " INNER JOIN songdetails ON singers.singerId = songdetails.singerId " & _
                                      " INNER JOIN songs ON songs.songid = songdetails.songId " & _
                                      " INNER JOIN categories ON songs.categoryId = categories.categoryId " & _
                                      " INNER JOIN productions ON songs.productionId = productions.productionId " & _
                                      " INNER JOIN languages ON songs.languageId = languages.languageId " & _
                                      " WHERE songs.songId LIKE @SongID OR songs.title LIKE @Title OR songs.album LIKE @Album OR categories.category LIKE @Category " & _
                                      " OR productions.production LIKE @Production OR languages.language LIKE @Language  OR singers.singerName LIKE @Singer" & _
                                      " GROUP BY songs.songId "
                MsgBox(keyword)
                Command.Parameters.AddWithValue("@SongID", "%" & keyword & "%")
                Command.Parameters.AddWithValue("@Title", "%" & keyword & "%")
                Command.Parameters.AddWithValue("@Album", "%" & keyword & "%")
                Command.Parameters.AddWithValue("@Category", "%" & keyword & "%")
                Command.Parameters.AddWithValue("@Production", "%" & keyword & "%")
                Command.Parameters.AddWithValue("@Language", "%" & keyword & "%")
                Command.Parameters.AddWithValue("@Singer", "%" & keyword & "%")

                'Command.CommandText = "spGetAllSongsBySearch"
                'Command.CommandType = CommandType.StoredProcedure
                'Command.Parameters.AddWithValue("@SSongID", "%" & keyword & "%")
                'Command.Parameters.AddWithValue("@STitle", "%" & keyword & "%")
                'Command.Parameters.AddWithValue("@SAlbum", "%" & keyword & "%")
                'Command.Parameters.AddWithValue("@SCategory", "%" & keyword & "%")
                'Command.Parameters.AddWithValue("@SProduction", "%" & keyword & "%")
                'Command.Parameters.AddWithValue("@SLanguage", "%" & keyword & "%")
                'Command.Parameters.AddWithValue("@SSinger", "%" & keyword & "%")
                Using adt As MySqlDataAdapter = New MySqlDataAdapter(Command)
                    adt.Fill(dsSongDetails)
                End Using
                Return dsSongDetails
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
