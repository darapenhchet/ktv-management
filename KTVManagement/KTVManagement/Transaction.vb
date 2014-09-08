Module Transaction

    Public BACKGROUND_TITLE_PANEL As Color = Color.FromArgb(39, 174, 96)
    Public BACKGROUND_ACTIVE_TAB As Color = Color.White
    Public FOREGROUND_ACTIVE_TAB As Color = Color.FromArgb(44, 62, 80)
    Public FOREGROUND_INACTIVE_TAB As Color = Color.White

    Public Function getMemoryStream(Picture As PictureBox) As Byte()
        Try
            Using mStream As System.IO.MemoryStream = New System.IO.MemoryStream()
                Picture.Image.Save(mStream, Picture.Image.RawFormat)
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

    Public Function GetStrSingers(str As String) As String()
        Try
            Dim singers() As String
            singers = str.Split(",")
            Return singers
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Sub Center(panel As Panel, form As Form)
        panel.Left = (form.Width - panel.Width) / 2
        panel.Top = (form.Height - panel.Height) / 2
    End Sub

End Module
