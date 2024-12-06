Public Class Form3
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles valor1.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles resultado.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim val1, val2 As Integer
        val1 = valor1.Text
        val2 = valor2.Text
        resultado.Text = val1 + val2
    End Sub
End Class