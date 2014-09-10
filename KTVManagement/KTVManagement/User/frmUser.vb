Imports System.IO

Public Class frmUser

    Private dsUser As New DataSet
    Private userTransaction As New DataLayer.ClsUserTransaction
    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
        DisplayInformationUser("")
        setGrdHeaderText("ID|Username|Password|Position|Photo", dgvUserList)
        setGrdHeaderWidth("100|300|200|200|200", dgvUserList)
        dgvUserList.Columns(2).Visible = False
        dgvUserList.Columns(4).Visible = False
    End Sub

    Public Sub DisplayInformationUser(keyword As String)
        Try
            dsUser = userTransaction.getUsersByKeyword(keyword)
            dgvUserList.DataSource = dsUser.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMainAdmin.Show()
        Me.Close()
    End Sub

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddRoom.Click
        frmAddUser.Show()
        Me.Close()
    End Sub

    Private Sub btnUpdateRoom_Click(sender As Object, e As EventArgs) Handles btnUpdateRoom.Click
        Try
            frmUpdaterUser.Show()
            frmUpdaterUser.txtID.Text = dgvUserList.CurrentRow.Cells(0).Value
            frmUpdaterUser.txtUsername.Text = dgvUserList.CurrentRow.Cells(1).Value
            frmUpdaterUser.txtPassword.Text = dgvUserList.CurrentRow.Cells(2).Value
            frmUpdaterUser.cboPosition.Text = dgvUserList.CurrentRow.Cells(3).Value
            If dgvUserList.CurrentRow.Cells(4).Value Is DBNull.Value Then
                frmUpdaterUser.pbPhoto.Image = My.Resources.Photo
            Else
                Dim imageData As Byte() = CType(dgvUserList.CurrentRow.Cells(4).Value, Byte())
                If Not imageData Is Nothing Then
                    Dim ms As New MemoryStream(imageData)
                    frmUpdaterUser.pbPhoto.Image = Image.FromStream(ms)
                End If
            End If
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            dsUser.Tables(0).Clear()
            dgvUserList.DataSource = dsUser.Tables(0)
            DisplayInformationUser(txtSearch.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class