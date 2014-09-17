Imports MySql.Data.MySqlClient
Public Class ClsGuestTransaction

    Private dsGuest As New DataSet

    Public Function getAllGuests() As DataSet
        Dim sql As String = "SELECT guestId,roomId,duration,timein,timeout,amount,status FROM guests"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Using adt As MySqlDataAdapter = New MySqlDataAdapter(Command)
                    adt.Fill(dsGuest)
                    Return dsGuest
                End Using
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function getGuestUsingDetails() As DataSet
        'Dim sql As String = "SELECT guestId,duration,roomId,timein,timeout,amount FROM guests"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = "spGetGuestUsingDetails"
                Command.CommandType = CommandType.StoredProcedure
                Using adt As MySqlDataAdapter = New MySqlDataAdapter(Command)
                    adt.Fill(dsGuest)
                    Return dsGuest
                End Using

            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function searchGuestByKeyword(keyword As String) As DataSet
        Dim sql As String = "SELECT guestId,guests.roomId,roomName,roomType,timein,timeout,duration,TIMEDIFF(guests.timeOut,NOW()) AS LEFTTIME,price,amount FROM guests INNER JOIN rooms ON guests.roomId = rooms.roomId WHERE  guests.status = 1 AND (guests.roomId LIKE @RoomID OR timein LIKE @TimeIn OR timeout LIKE @TimeOut OR amount LIKE @Amount OR rooms.roomType LIKE @RoomType)"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Command.Parameters.AddWithValue("@RoomID", "%" & keyword & "%")
                Command.Parameters.AddWithValue("@TimeIn", "%" & keyword & "%")
                Command.Parameters.AddWithValue("@TimeOut", "%" & keyword & "%")
                Command.Parameters.AddWithValue("@Amount", "%" & keyword & "%")
                Command.Parameters.AddWithValue("@RoomType", "%" & keyword & "%")
                Using adt As MySqlDataAdapter = New MySqlDataAdapter(Command)
                    adt.Fill(dsGuest)
                    Return dsGuest
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function getGuestHistory(keyword As String) As DataSet
        Dim sql As String = "SELECT guestId,guests.roomId,roomName,roomType,timein,timeout,duration,price,amount FROM guests INNER JOIN rooms ON guests.roomId = rooms.roomId WHERE guests.roomId LIKE @RoomID OR rooms.roomName LIKE @RoomName OR timein LIKE @TimeIn OR timeout LIKE @TimeOut OR amount LIKE @Amount"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Command.Parameters.AddWithValue("@RoomID", "%" & keyword & "%")
                Command.Parameters.AddWithValue("@TimeIn", "%" & keyword & "%")
                Command.Parameters.AddWithValue("@TimeOut", "%" & keyword & "%")
                Command.Parameters.AddWithValue("@Amount", "%" & keyword & "%")
                Command.Parameters.AddWithValue("@RoomName", "%" & keyword & "%")
                Using adt As MySqlDataAdapter = New MySqlDataAdapter(Command)
                    adt.Fill(dsGuest)
                    Return dsGuest
                End Using
            End Using
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function getCheckInRoom() As DataSet
        Dim sql As String = "SELECT rooms.roomId, timeOut FROM rooms INNER JOIN guests ON rooms.roomId = guests.roomId WHERE rooms.status = 1 AND TIMEDIFF(guests.timeOut,NOW()) > 0"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Using adt As MySqlDataAdapter = New MySqlDataAdapter(Command)
                    adt.Fill(dsGuest)
                    Return dsGuest
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function getGuestById(id As Integer) As ClsGuest
        Dim dr As MySqlDataReader = Nothing
        Dim guest As New ClsGuest

        Dim sql As String = "SELECT guestId,duration,roomId,timein,timeout,amount FROM guests WHERE roomID = @ID AND guests.status=1"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Command.Parameters.AddWithValue("@ID", id)
                dr = Command.ExecuteReader
                While dr.Read
                    guest.ID = dr.GetInt32(0)
                    Dim room As New ClsRoom
                    room.ID = dr.GetInt32(1)
                    guest.Room = room
                    guest.Duration = dr.GetInt32(2)
                    guest.TimeIn = dr.GetDateTime(3)
                    guest.TimeOut = dr.GetDateTime(4)
                    guest.Amount = dr.GetDouble(5)
                End While
                dr.Close()
                Return guest
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function addNewGuest(guest As ClsGuest) As Boolean
        'Dim sql As String = "INSERT INTO guests(roomId,duration,timeIn) VALUES(@RoomID,@Duration,@TimeIn)"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = "spAddNewGuest"
                Command.CommandType = CommandType.StoredProcedure
                Command.Parameters.AddWithValue("@SRoomID", guest.Room.ID)
                Command.Parameters.AddWithValue("@STimeIn", guest.TimeIn)
                Command.Parameters.AddWithValue("@SDuration", guest.Duration)
                Command.Parameters.AddWithValue("@SAmount", guest.Amount)
                Command.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function updateGuest(guest As ClsGuest) As Boolean
        Dim sql As String = "UPDATE guests SET roomId = @RoomID , duration = @Duration, timein = @TimeIn, timeout=@TimeOut, amount= @Amount  WHERE guestId = @ID"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Command.Parameters.AddWithValue("@RoomID", guest.Room.ID)
                Command.Parameters.AddWithValue("@Duration", guest.Duration)
                Command.Parameters.AddWithValue("@TimeIn", guest.TimeIn)
                Command.Parameters.AddWithValue("@TimeOut", guest.TimeOut)
                Command.Parameters.AddWithValue("@Amount", guest.Amount)
                Command.Parameters.AddWithValue("@ID", guest.ID)
                Command.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function updateGuestRoom(roomID As Integer) As Boolean
        Dim sql As String = "spUpdateGuestRoom"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Command.CommandType = CommandType.StoredProcedure
                Command.Parameters.AddWithValue("@roomID", roomID)
                Command.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function



    Public Function deleteGuest(id As Integer) As Boolean
        Dim sql As String = "DELETE FROM guests WHERE guestID = @ID"
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
