Imports MySql.Data.MySqlClient
Public Class ClsProductionTransaction

    Private dsProduction As New DataSet

    Public Function getAllProductions() As DataSet
        Dim sql As String = "SELECT productionId,production,photo FROM productions"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Using adt As MySqlDataAdapter = New MySqlDataAdapter(Command)
                    adt.Fill(dsProduction)
                    Return dsProduction
                End Using
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function getProductionById(id As Integer) As ClsProduction
        Dim sql As String = "SELECT productionId,production,photo FROM productions WHERE productionId = @PID"
        Dim dr As MySqlDataReader
        Dim production As New ClsProduction

        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Command.Parameters.AddWithValue("@PID", id)
                dr = Command.ExecuteReader
                While dr.Read
                    production.ID = dr.GetInt32(0)
                    production.Production = dr.GetString(1)
                    Dim ms As New System.IO.MemoryStream
                    ms = dr.GetStream(2)
                    production.Photo = ms.GetBuffer
                End While
                Return production
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function getProductionByKeyword(keyword As String) As DataSet
        Dim sql As String = "SELECT ProductionId, Production, Photo FROM productions WHERE production LIKE @production OR productionId LIKE @PID"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Command.Parameters.AddWithValue("@production", "%" & keyword & "%")
                Command.Parameters.AddWithValue("@PID", "%" & keyword & "%")
                Using adt As MySqlDataAdapter = New MySqlDataAdapter(Command)
                    adt.Fill(dsProduction)
                    Return dsProduction
                End Using
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
        Return Nothing
    End Function

    Public Function addNewProduction(production As ClsProduction) As Boolean
        Dim sql As String = "INSERT INTO productions(production,photo) VALUES(@Production,@Photo))"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Command.Parameters.AddWithValue("@Production", production.Production)
                Command.Parameters.AddWithValue("@Photo", production.Photo)
                Command.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function updateProduction(production As ClsProduction) As Boolean
        Dim sql As String = "UPDATE productions SET production = @Production , Photo = @Photo WHERE productionId = @PID"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Command.Parameters.AddWithValue("@Production", production.Production)
                Command.Parameters.AddWithValue("@Photo", production.Photo)
                Command.Parameters.AddWithValue("@PID", production.ID)
                Command.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function deleteProduction(id As Integer) As Boolean
        Dim sql As String = "DELETE FROM production WHERE productionID = @ID"
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
