Public Class frmUpdateLanguage

    Private Photo As Byte()
    Private Sub btnAddLanguage_Click(sender As Object, e As EventArgs) Handles btnAddLanguage.Click
        frmAddLanguage.Show()
        Me.Close()
    End Sub

    Private Sub btnLanguageList_Click(sender As Object, e As EventArgs) Handles btnLanguageList.Click
        frmLanguage.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub frmUpdateLanguage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim language As New DataLayer.ClsLanguage
            Dim languageTransaction As New DataLayer.ClsLanguageTransaction
            language.ID = CInt(txtID.Text)
            language.Language = txtLanguage.Text
            If languageTransaction.updateLanguage(language) = True Then
                MessageBox.Show("Successfully!!!")
            Else
                MessageBox.Show("Unsuccessfully!!!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class