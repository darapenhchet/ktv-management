Imports MySql.Data.MySqlClient

Public Class Form1
    Dim ds As New DataSet
    Dim daosinger As New DAOSinger
    Dim dtoSinger As New Singer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        openConnection()

        'For Each dr As DataRow In ds.Tables(0).Rows
        '    ListSinger.Items.Add(dr.Item(0).ToString & vbTab & dr.Item(1).ToString & vbTab & dr.Item(2).ToString & vbCrLf)
        'Next
        'cboproduction.DataSource = daosinger.getproductionName().Tables(0)
        'cboproduction.DisplayMember = "production"
        'cboproduction.ValueMember = "productionId"




    End Sub

    Private Sub ListSinger_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListSinger.SelectedIndexChanged
        MessageBox.Show(ListSinger.SelectedItem(0))



    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        Me.clearText()
    End Sub
    Private Sub clearText()
        Dim c As Control
        For Each c In Me.Controls
            If TypeOf c Is TextBox Or TypeOf c Is ComboBox Then
                c.Text = ""
            End If
        Next
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        Dim daosinger As New DAOSinger
        Dim dtoSinger As New Singer
        dtoSinger.singerID = txtsinid.Text
        dtoSinger.singerName = txtsinName.Text
        dtoSinger.gender = cbogender.Text
        If (daosinger.addSinger(dtoSinger)) Then
            MessageBox.Show("Inserted!!!")
        Else
            MessageBox.Show("Not Inserted!!!")
        End If


    End Sub

    Private Sub cboproduction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboproduction.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (daosinger.deleteSinger(txtsinid.Text)) Then
            MessageBox.Show("Deleted!!!")
        Else
            MessageBox.Show(" Un delete???")
        End If

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class
