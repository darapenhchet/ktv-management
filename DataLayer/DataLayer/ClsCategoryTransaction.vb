Imports MySql.Data.MySqlClient
Public Class ClsCategoryTransaction

    Private dsCategory As New DataSet

    Public Function getAllCategory() As DataSet
        Dim sql As String = "SELECT categoryId, category, description FROM categories"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Using adt As MySqlDataAdapter = New MySqlDataAdapter(Command)
                    adt.Fill(dsCategory)
                    Return dsCategory
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function getAllCategoryTwoColumns() As DataSet
        Dim sql As String = "SELECT categoryId, category FROM categories ORDER BY Category"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Using adt As MySqlDataAdapter = New MySqlDataAdapter(Command)
                    adt.Fill(dsCategory)
                    Return dsCategory
                End Using
            End Using
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function searchCategoryBykeyword(keyword As String) As DataSet
        Dim sql As String = "SELECT categoryId, category, description FROM categories WHERE categoryId LIKE @ID OR category LIKE @Category OR description LIKE @Description"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Command.Parameters.AddWithValue("@ID", "%" & keyword & "%")
                Command.Parameters.AddWithValue("@Category", "%" & keyword & "%")
                Command.Parameters.AddWithValue("@Description", "%" & keyword & "%")
                Using adt As MySqlDataAdapter = New MySqlDataAdapter(Command)
                    adt.Fill(dsCategory)
                    Return dsCategory
                End Using
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
        Return Nothing
    End Function

    Public Function getCategoryById(id As Integer) As ClsCategory

        Dim sql As String = "SELECT categoryId,category,description FROM categorys WHERE categoryId = @PID"
        Dim dr As MySqlDataReader
        Dim category As New ClsCategory

        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Command.Parameters.AddWithValue("@PID", id)
                dr = Command.ExecuteReader
                While dr.Read
                    category.ID = dr.GetInt32(0)
                    category.Category = dr.GetString(1)
                    category.Description = dr.GetString(2)
                End While
                Return category
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function addNewCategory(category As ClsCategory) As Boolean
        Dim sql As String = "INSERT INTO categories(category,description) VALUES(@Category,@Description)"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Command.Parameters.AddWithValue("@Category", category.Category)
                Command.Parameters.AddWithValue("@Description", category.Description)
                Command.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function updateCategory(category As ClsCategory) As Boolean
        Dim sql As String = "UPDATE categories SET category = @category , description = @Description WHERE categoryId = @CID"
        Try
            Using Command As MySqlCommand = ClsConnection.Con.CreateCommand
                Command.CommandText = sql
                Command.Parameters.AddWithValue("@Category", category.Category)
                Command.Parameters.AddWithValue("@Description", category.Description)
                Command.Parameters.AddWithValue("@CID", category.ID)
                Command.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function deleteCategory(id As Integer) As Boolean
        Dim sql As String = "DELETE FROM category WHERE categoryID = @ID"
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
