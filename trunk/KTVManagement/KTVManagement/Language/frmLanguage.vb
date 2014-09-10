Imports DataLayer
Imports System.IO

Public Class frmLanguage

    Private dsLanguage As New DataSet
    Private languageTransaction As New ClsLanguageTransaction

    Private Sub frmLanguage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Panel1.Left = (Me.Width - Panel1.Width) / 2
            Panel1.Top = (Me.Height - Panel1.Height) / 2
            DisplayLanguageInformation("")
            setGrdHeaderText("ID|Language", dgvLanguageList)
            setGrdHeaderWidth("100|300", dgvLanguageList)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub DisplayLanguageInformation(keyword As String)
        Try
            dsLanguage = languageTransaction.getAllLanguageByKeyword(keyword)
            dgvLanguageList.DataSource = dsLanguage.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnAddLanguage_Click(sender As Object, e As EventArgs) Handles btnAddLanguage.Click
        frmAddLanguage.Show()
        Me.Close()
    End Sub

    Private Sub btnUpdateLanguage_Click(sender As Object, e As EventArgs) Handles btnUpdateLanguage.Click
        Try
            frmUpdateLanguage.Show()
            frmUpdateLanguage.txtID.Text = dgvLanguageList.CurrentRow.Cells(0).Value
            frmUpdateLanguage.txtLanguage.Text = dgvLanguageList.CurrentRow.Cells(1).Value
            If dgvLanguageList.CurrentRow.Cells(2).Value Is DBNull.Value Then
                frmUpdateProduction.pbPhoto.Image = My.Resources.Photo
            Else
                Dim imageData As Byte() = CType(dgvLanguageList.CurrentRow.Cells(2).Value, Byte())
                If Not imageData Is Nothing Then
                    Dim ms As New MemoryStream(imageData)
                    frmUpdateProduction.pbPhoto.Image = Image.FromStream(ms)
                End If
            End If
            Me.Close()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            dsLanguage.Tables(0).Clear()
            dgvLanguageList.DataSource = dsLanguage.Tables(0)
            DisplayLanguageInformation(txtSearch.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class