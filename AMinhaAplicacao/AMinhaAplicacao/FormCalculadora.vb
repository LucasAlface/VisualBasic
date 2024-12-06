Public Class FormCalculadora
    Dim operador As String
    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Form1.frm2 = Nothing
        Form1.Show()
        Me.Close()
    End Sub


    Private Sub botDivide_Click(sender As Object, e As EventArgs) Handles botDivide.Click
        operador = "/"
    End Sub

    Private Sub botMultiply_Click(sender As Object, e As EventArgs) Handles botMultiply.Click
        operador = "*"
    End Sub

    Private Sub botAdd_Click(sender As Object, e As EventArgs) Handles botAdd.Click
        operador = "+"
    End Sub

    Private Sub botMinus_Click(sender As Object, e As EventArgs) Handles botMinus.Click
        operador = "-"
    End Sub

    Public Sub inserirNum(numero As String)
        If (TextBox1.Text = "0") Then
            TextBox1.Text = numero
        Else
            TextBox1.Text = TextBox1.Text & numero
        End If
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        inserirNum("0")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        inserirNum("1")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        inserirNum("2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        inserirNum("3")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        inserirNum("4")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        inserirNum("5")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        inserirNum("6")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        inserirNum("7")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        inserirNum("8")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        inserirNum("9")
    End Sub

    Private Sub botDeleteAll_Click(sender As Object, e As EventArgs) Handles botDeleteAll.Click
        TextBox1.Text = "0"
    End Sub
End Class