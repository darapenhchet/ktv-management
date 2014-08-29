
Imports MySql.Data.MySqlClient
Public Class DAOSinger
    Private cnn As New MySqlConnection

    Public Sub New()
        cnn = getConnection()
    End Sub

    Public Function addSinger(singer As Singer) As Boolean
        Try

            Dim sql As String = "insert into singers(singerId,singerName,gender) values(@id,@name,@gender)"
            Using command As MySqlCommand = New MySqlCommand(sql, cnn)

                command.Parameters.AddWithValue("@id", singer.SingerID)
                command.Parameters.AddWithValue("@name", singer.SingerName)
                command.Parameters.AddWithValue("@gender", singer.Gender)
                command.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Function updateSinger(singer As Singer) As Boolean
        Dim sql As String = "update singers set singerName=@name,gender=@gender where singerId=@id"

        Try
            Using command As MySqlCommand = New MySqlCommand(sql, cnn)
                command.Parameters.AddWithValue("@name", singer.SingerName)
                command.Parameters.AddWithValue("@gender", singer.Gender)
                command.Parameters.AddWithValue("@id", singer.SingerID)
                command.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try

    End Function

    Public Function deleteSinger(id As Integer) As Boolean

        Dim sql As String = "delete from singers where singerId=@id"
        Try
            Using Command As MySqlCommand = New MySqlCommand(sql, cnn)
                Command.Parameters.AddWithValue("@id", id)
                Command.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try


    End Function
    Public Function searchAll(keyword As String) As DataSet
        Dim ds As New DataSet
        Dim sql As String = "select singerId,singerName,gender " &
                            "from singers " &
                            "where singerId like @id or singerName like @name or gender like @gender"
        Try
            Using Command As MySqlCommand = New MySqlCommand(sql, cnn)
                Command.Parameters.AddWithValue("@id", "%" & keyword & "%")
                Command.Parameters.AddWithValue("@name", "%" & keyword & "%")
                Command.Parameters.AddWithValue("@gender", "%" & keyword & "%")
                Command.ExecuteNonQuery()
                Using dataadt As New MySqlDataAdapter(Command)
                    dataadt.Fill(ds)
                    Return ds
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Function displayData() As DataSet
        Dim ds As New DataSet
        Dim sql = "select singerId,singerName, Gender from singers"
        Try
            Using Command As MySqlCommand = New MySqlCommand(sql, cnn)
                Command.ExecuteNonQuery()
                Using dataadt As New MySqlDataAdapter(Command)
                    dataadt.Fill(ds)
                    Return ds
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function



End Class
