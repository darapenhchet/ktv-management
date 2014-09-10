Imports System.IO

Public Class frmProduction

    Private productionTransaction As New DataLayer.ClsProductionTransaction
    Private dsProduction As New DataSet

    Private Sub btnAddProduction_Click(sender As Object, e As EventArgs) Handles btnAddProduction.Click
        frmAddProduction.Show()
        Me.Close()
    End Sub

    Private Sub btnUpdateProduction_Click(sender As Object, e As EventArgs)
        frmUpdateProduction.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub frmProduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
        DisplayProductionInformation("")
        setGrdHeaderText("ID|Production|Photo", dgvProductionList)
        setGrdHeaderWidth("100|300|600", dgvProductionList)
        dgvProductionList.Columns(2).Visible = False
    End Sub

    Public Sub DisplayProductionInformation(keyword As String)
        Try
            dsProduction = productionTransaction.getProductionByKeyword(keyword)
            dgvProductionList.DataSource = dsProduction.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnUpdateProduction_Click_1(sender As Object, e As EventArgs) Handles btnUpdateProduction.Click
        Try
            frmUpdateProduction.Show()
            frmUpdateProduction.txtID.Text = dgvProductionList.CurrentRow.Cells(0).Value
            frmUpdateProduction.txtProduction.Text = dgvProductionList.CurrentRow.Cells(1).Value
            If dgvProductionList.CurrentRow.Cells(2).Value Is DBNull.Value Then
                frmUpdateProduction.pbPhoto.Image = My.Resources.Photo
            Else
                Dim imageData As Byte() = CType(dgvProductionList.CurrentRow.Cells(2).Value, Byte())
                If Not imageData Is Nothing Then
                    Dim ms As New MemoryStream(imageData)
                    frmUpdateProduction.pbPhoto.Image = Image.FromStream(ms)
                End If
            End If
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            dsProduction.Tables(0).Clear()
            dgvProductionList.DataSource = dsProduction.Tables(0)
            DisplayProductionInformation(txtSearch.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class