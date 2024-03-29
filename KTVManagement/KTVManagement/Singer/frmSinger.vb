﻿Imports DataLayer
Imports System.IO

Public Class frmSinger

    Private dsSinger As New DataSet
    Private singerTransaction As New ClsSingerTransaction
    Private Sub frmSinger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
        displaySingerInformation("")
    End Sub

    Private Sub displaySingerInformation(keyword As String)
        Try
            dsSinger = singerTransaction.getAllSingerByKeyword(keyword)
            dgvSingerList.DataSource = dsSinger.Tables(0)
            setGrdHeaderText("ID|Singer's Name|Gender|Nationality|Photo", dgvSingerList)
            setGrdHeaderWidth("100|300|200|200|200", dgvSingerList)
            dgvSingerList.Columns(4).Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            dsSinger.Tables(0).Clear()
            dgvSingerList.DataSource = dsSinger.Tables(0)
            displaySingerInformation(txtSearch.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnUpdateSinger_Click(sender As Object, e As EventArgs) Handles btnUpdateSinger.Click
        Try
            frmUpdateSinger.Show()
            frmUpdateSinger.txtID.Text = dgvSingerList.CurrentRow.Cells(0).Value
            frmUpdateSinger.txtSingerName.Text = dgvSingerList.CurrentRow.Cells(1).Value
            frmUpdateSinger.cboGender.Text = dgvSingerList.CurrentRow.Cells(2).Value
            frmUpdateSinger.txtNationality.Text = dgvSingerList.CurrentRow.Cells(3).Value
            If dgvSingerList.CurrentRow.Cells(3).Value Is DBNull.Value Then
                frmUpdateSinger.pbPhoto.Image = My.Resources.Photo
            Else
                Dim imageData As Byte() = CType(dgvSingerList.CurrentRow.Cells(4).Value, Byte())
                If Not imageData Is Nothing Then
                    Dim ms As New MemoryStream(imageData)
                    frmUpdateSinger.pbPhoto.Image = Image.FromStream(ms)
                End If
            End If
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAddSinger_Click(sender As Object, e As EventArgs) Handles btnAddSinger.Click
        frmAddSinger.Show()
        Me.Close()
    End Sub

End Class