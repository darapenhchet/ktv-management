Public Class frmSplashScreen

    Private Sub frmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
        tmrDisplay.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrDisplay.Tick
        Me.Visible = False
        frmLogin.Visible = True
        tmrDisplay.Stop()
    End Sub
End Class