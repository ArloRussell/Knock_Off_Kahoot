Public Class GameOver
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class