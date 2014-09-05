Module Transaction

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
End Module
