﻿Public Class frmAddLanguage

    Private Sub btnRoomList_Click(sender As Object, e As EventArgs) Handles btnRoomList.Click
        frmLanguage.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

End Class