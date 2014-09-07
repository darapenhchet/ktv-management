Imports MySql.Data.MySqlClient
Public Class ClsSingerTransaction
    ''' <summary>
    ''' dsSinger is a Dataset of the Singer Table
    ''' </summary>
    ''' <remarks></remarks>
    Private dsSinger As New DataSet

    ''' <summary>
    ''' getAllSingers Function
    ''' </summary>
    ''' <returns>DataSet</returns>
    ''' <remarks>This function is used to get all singers from the table Singers</remarks>
    Public Function getAllSingers() As DataSet
        Dim sql As String = "spGetAllSingers"
        Try
            Using Command As MySqlCommand = DataLayer.ClsConnection.con.CreateCommand
                Command.CommandText = sql
                Command.CommandType = CommandType.StoredProcedure
                Using adt As MySqlDataAdapter = New MySqlDataAdapter(Command)
                    adt.Fill(dsSinger)
                    Return dsSinger
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function getSingerBySingerName(singerName As String) As ClsSinger
        Dim sql As String = "SELECT singerId, singerName, gender, photo FROM singers WHERE SingerName LIKE @SingerName"
        Dim dr As MySqlDataReader
        Dim singer As New ClsSinger
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Command.Parameters.AddWithValue("@SingerName", singerName)
                dr = Command.ExecuteReader
                While dr.Read
                    singer.ID = dr.GetInt32(0)
                    singer.Name = dr.GetString(1)
                    singer.Gender = dr.GetString(2)
                    'Dim ms As New System.IO.MemoryStream
                    'ms = dr.GetStream(3)C:\Users\DARA PENHCHET\Desktop\ktv-management\DataLayer\DataLayer\ClsSingerTransaction.vb
                    'singer.Photo = ms.GetBuffer
                End While
                dr.Close()
                dr.Dispose()
                dr = Nothing
                Return singer
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function getAllSingerByKeyword(keyword As String) As DataSet
        Dim sql As String = "SELECT singerId, singerName, gender, photo FROM singers WHERE singerId LIKE @SingerID OR SingerName LIKE @SingerName OR gender LIKE @Gender"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Command.Parameters.AddWithValue("@SingerID", "%" & keyword & "%")
                Command.Parameters.AddWithValue("@SingerName", "%" & keyword & "%")
                Command.Parameters.AddWithValue("@Gender", "%" & keyword & "%")
                Using adt As MySqlDataAdapter = New MySqlDataAdapter(Command)
                    adt.Fill(dsSinger)
                    Return dsSinger
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Function getAllSingersTwoColumns() As DataSet
        Dim sql As String = "SELECT singerId , singerName  FROM Singers ORDER BY singerName"
        Try
            Using Command As MySqlCommand = DataLayer.ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Using adt As MySqlDataAdapter = New MySqlDataAdapter(Command)
                    dsSinger = New DataSet
                    adt.Fill(dsSinger)
                    Return dsSinger
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' addNewSinger Function
    ''' </summary>
    ''' <param name="singer"></param>
    ''' <returns>Boolean</returns>
    ''' <remarks>This function is used to add a new singer </remarks>
    Public Function addNewsinger(singer As ClsSinger) As Boolean
        Try
            Using Command As MySqlCommand = DataLayer.ClsConnection.Con.CreateCommand
                Command.CommandText = "spAddSinger"
                Command.CommandType = CommandType.StoredProcedure
                Command.Parameters.AddWithValue("@singerName", singer.Name)
                Command.Parameters.AddWithValue("@gender", singer.Gender.Substring(0, 1))
                Command.Parameters.AddWithValue("@photo", singer.Photo)
                Command.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' updateSinger Function
    ''' </summary>
    ''' <param name="singer"></param>
    ''' <returns>Boolean</returns>
    ''' <remarks>This function is used to update the singer by specified ID</remarks>
    Public Function updateSinger(singer As ClsSinger) As Boolean
        Try
            Using Command As MySqlCommand = DataLayer.ClsConnection.Con.CreateCommand
                Command.CommandText = "UPDATE Singers SET singerName = @singerName, gender = @gender, photo = @photo WHERE singerID = @singerID"
                Command.Parameters.AddWithValue("@singerID", singer.ID)
                Command.Parameters.AddWithValue("@singerName", singer.Name)
                Command.Parameters.AddWithValue("@gender", singer.Gender.Substring(0, 1))
                Command.Parameters.AddWithValue("@photo", singer.Photo)
                Command.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' deleteSinger Function
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns>Boolean</returns>
    ''' <remarks>This function is used to delete a user </remarks>
    Public Function deleteSinger(id As Integer) As Boolean
        Try
            Using Command As MySqlCommand = DataLayer.ClsConnection.Con.CreateCommand
                Command.CommandText = "DELETE FROM Singers WHERE singerId = @singerId"
                Command.Parameters.AddWithValue("@singerId", id)
                Command.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            Return False
        End Try

    End Function

    ''' <summary>
    ''' searchSingerByKeyword
    ''' </summary>
    ''' <param name="keyword"></param>
    ''' <returns>Dataset</returns>
    ''' <remarks></remarks>
    Public Function searchSingerByKeyword(keyword As String) As DataSet

        Return Nothing
    End Function
End Class
