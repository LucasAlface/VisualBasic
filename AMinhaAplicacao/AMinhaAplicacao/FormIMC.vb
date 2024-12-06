Public Class FormIMC
    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Form1.frm3 = Nothing
        Form1.Show()
        Me.Close()
    End Sub
End Class