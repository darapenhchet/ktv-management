Imports MySql.Data.MySqlClient
Public Class ClsLanguageTransaction

    Private dsLanguage As New DataSet

    Public Function getAllLanguages() As DataSet
        Dim sql As String = "SELECT languageId,language,photo FROM languages"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Using adt As MySqlDataAdapter = New MySqlDataAdapter(Command)
                    adt.Fill(dsLanguage)
                    Return dsLanguage
                End Using
            End Using
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function getAllLanguageByKeyword(keyword As String) As DataSet
        Dim sql As String = "SELECT languageId, language, Photo FROM languages WHERE language LIKE @Language OR languageId LIKE @LID"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Command.Parameters.AddWithValue("@Language", "%" & keyword & "%")
                Command.Parameters.AddWithValue("@LID", "%" & keyword & "%")
                Using adt As MySqlDataAdapter = New MySqlDataAdapter(Command)
                    adt.Fill(dsLanguage)
                    Return dsLanguage
                End Using
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
        Return Nothing
    End Function

    Public Function getLanguageById(id As Integer) As ClsLanguage
        Dim sql As String = "SELECT languageId,language,photo FROM languages WHERE languageId = @LID"
        Dim dr As MySqlDataReader
        Dim language As New ClsLanguage

        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Command.Parameters.AddWithValue("@LID", id)
                dr = Command.ExecuteReader
                While dr.Read
                    language.ID = dr.GetInt32(0)
                    language.Language = dr.GetString(1)
                    Dim ms As New System.IO.MemoryStream
                    ms = dr.GetStream(2)
                    language.Photo = ms.GetBuffer
                End While
                Return language
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function addNewLanguage(language As ClsLanguage) As Boolean
        Dim sql As String = "INSERT INTO languages(Language,photo) VALUES(@Language,@Photo))"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Command.Parameters.AddWithValue("@Language", language.Language)
                Command.Parameters.AddWithValue("@Photo", language.Photo)
                Command.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function updateLanguage(language As ClsLanguage) As Boolean
        Dim sql As String = "UPDATE languages SET language = @Language , Photo = @Photo WHERE languageId = @LID"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Command.Parameters.AddWithValue("@Language", language.Language)
                Command.Parameters.AddWithValue("@Photo", language.Photo)
                Command.Parameters.AddWithValue("@LID", language.ID)
                Command.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function deleteLanguage(id As Integer) As Boolean
        Dim sql As String = "DELETE FROM language WHERE languageID = @ID"
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
