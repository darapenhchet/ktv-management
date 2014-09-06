Module Transaction

    Public BACKGROUND_TITLE_PANEL As Color = Color.FromArgb(39, 174, 96)
    Public BACKGROUND_ACTIVE_TAB As Color = Color.White
    Public FOREGROUND_ACTIVE_TAB As Color = Color.FromArgb(44, 62, 80)
    Public FOREGROUND_INACTIVE_TAB As Color = Color.White

    Public Function getMemoryStream(FileName As String) As Byte()
        Try
            Using mStream As System.IO.MemoryStream = New System.IO.MemoryStream()
                Image.FromFile(FileName).Save(mStream, Image.FromFile(FileName).RawFormat)
                Return mStream.GetBuffer
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Sub AddDataIntoComboBox(cboName As ComboBox, ds As DataSet)
        ds.Tables(0).Rows.Add(0, "Add New...")
        With cboName
            .DataSource = ds.Tables(0)
            .DisplayMember = ds.Tables(0).Columns(1).ColumnName
            .ValueMember = ds.Tables(0).Columns(0).ColumnName
            .SelectedIndex = -1
        End With
    End Sub

    Public Sub setGrdHeaderText(ByVal S As String, ByVal Grd As DataGridView)
        Dim hr() As String
        hr = S.Split("|")
        Dim i As Integer = 0
        Try
            For i = 0 To UBound(hr)
                Grd.Columns(i).HeaderText = hr(i)
            Next
        Catch ex As Exception

        End Try
    End Sub
    Public Sub setGrdHeaderWidth(ByVal S As String, ByVal Grd As DataGridView)
        Dim hr() As String
        hr = S.Split("|")
        Dim i As Integer
        Try
            For i = 0 To UBound(hr)
                Grd.Columns(i).Width = Val(hr(i))
            Next
        Catch ex As Exception

        End Try
    End Sub
End Module
