Imports DataLayer
Public Class frmLanguage

    Private dsLanguage As New DataSet
    Private languageTransaction As New ClsLanguageTransaction

    Private Sub frmLanguage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayLanguageInformation("")
    End Sub

    Public Sub DisplayLanguageInformation(keyword As String)
        dsLanguage = languageTransaction.getAllLanguageByKeyword(keyword)
        dgvSingerList.DataSource = dsLanguage.Tables(0)
        setGrdHeaderText("ID|Language|Photo", dgvSingerList)
        setGrdHeaderWidth("100|300|600", dgvSingerList)
        dgvSingerList.Columns(2).Visible = False
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnAddLanguage_Click(sender As Object, e As EventArgs) Handles btnAddLanguage.Click
        frmAddLanguage.Show()
        Me.Close()
    End Sub

    Private Sub btnUpdateLanguage_Click(sender As Object, e As EventArgs) Handles btnUpdateLanguage.Click
        frmUpdateLanguage.Show()
        Me.Close()
    End Sub
End Class