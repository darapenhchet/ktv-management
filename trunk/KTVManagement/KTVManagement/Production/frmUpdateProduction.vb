Public Class frmUpdateProduction
    Private Photo As Byte()
    Private productionTransaction As New DataLayer.ClsProductionTransaction
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnAddProduction_Click(sender As Object, e As EventArgs) Handles btnAddProduction.Click
        frmAddProduction.Show()
        Me.Close()
    End Sub

    Private Sub btnProductionList_Click(sender As Object, e As EventArgs) Handles btnProductionList.Click
        frmProduction.Show()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim production As New DataLayer.ClsProduction
            production.ID = CInt(txtID.Text)
            production.Production = txtProduction.Text
            Dim ms As New IO.MemoryStream
            pbPhoto.Image.Save(ms, Imaging.ImageFormat.Jpeg)
            Photo = ms.GetBuffer()
            production.Photo = Photo
            If (productionTransaction.updateProduction(production) = True) Then
                Message.Visible = True
            Else
                Message.Text = "Updating is failure!!!"
                Message.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub pbPhoto_Click(sender As Object, e As EventArgs) Handles pbPhoto.Click
        Try
            If OpenPhoto.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
                pbPhoto.Image = Image.FromFile(OpenPhoto.FileName)
                Photo = getMemoryStream(pbPhoto)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmUpdateProduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
    End Sub
End Class