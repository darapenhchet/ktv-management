﻿Public Class frmMainAdmin

    Private Sub frmMainAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
    End Sub


    Private Sub btnExitMain_Click(sender As Object, e As EventArgs) Handles btnExitMain.Click
        Me.Close()
        frmLogin.Visible = True
    End Sub

    Private Sub btnSongInformation_Click(sender As Object, e As EventArgs) Handles btnSongInformation.Click
        frmSongInformation.Show()
    End Sub
End Class