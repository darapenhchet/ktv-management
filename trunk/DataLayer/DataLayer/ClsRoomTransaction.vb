Imports MySql.Data.MySqlClient
Public Class ClsRoomTransaction

    Private dsRoom As New DataSet

    Public Function getAllRooms() As DataSet
        Dim sql As String = "SELECT roomId, roomName ,roomType, price, discount FROM rooms"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Using adt As MySqlDataAdapter = New MySqlDataAdapter(Command)
                    adt.Fill(dsRoom)
                    Return dsRoom
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function getAllRoomByKeyword(keyword As String) As DataSet
        Dim sql As String = "SELECT roomId, roomName, roomType, price, discount FROM rooms WHERE roomId LIKE @RoomID OR roomName LIKE @RoomName OR roomType LIKE @RoomType OR price LIKE @Price OR discount LIKE @Discount"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Command.Parameters.AddWithValue("@RoomID", "%" & keyword & "%")
                Command.Parameters.AddWithValue("@RoomName", "%" & keyword & "%")
                Command.Parameters.AddWithValue("@RoomType", "%" & keyword & "%")
                Command.Parameters.AddWithValue("@Price", "%" & keyword & "%")
                Command.Parameters.AddWithValue("@Discount", "%" & keyword & "%")
                Using adt As MySqlDataAdapter = New MySqlDataAdapter(Command)
                    adt.Fill(dsRoom)
                    Return dsRoom
                End Using
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function getRoomById(id As Integer) As ClsRoom
        Dim sql As String = "SELECT roomId, roomType, price FROM rooms WHERE roomId = @ID"
        Dim dr As MySqlDataReader
        Dim room As New ClsRoom

        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Command.Parameters.AddWithValue("@ID", id)
                dr = Command.ExecuteReader
                While dr.Read
                    room.ID = dr.GetInt32(0)
                    room.RoomType = dr.GetString(1)
                    room.Price = dr.GetDouble(2)
                End While
                dr.Close()
                dr.Dispose()
                dr = Nothing
                Return room
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function addNewRoom(room As ClsRoom) As Boolean
        Dim sql As String = "INSERT INTO rooms(roomType,price) VALUES(@RoomType,@Price))"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Command.Parameters.AddWithValue("@RoomType", room.RoomType)
                Command.Parameters.AddWithValue("@Price", room.Price)
                Command.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function updateRoom(room As ClsRoom) As Boolean
        Dim sql As String = "UPDATE rooms SET roomType = @RoomType , Price = @Price WHERE roomId = @ID"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Command.Parameters.AddWithValue("@RoomType", room.RoomType)
                Command.Parameters.AddWithValue("@ID", room.ID)
                Command.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function deleteRoom(id As ClsRoom) As Boolean
        Dim sql As String = "DELETE FROM rooma WHERE roomID = @ID"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Command.Parameters.AddWithValue("@ID", id)
                Command.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
