Public Class Form2

    Private gender As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form1.frm2 = Nothing

        Form1.Show()

        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Calcular.Click

        Dim valorPeso As Double
        Dim valorAltura As Integer
        Dim res As Double
        valorPeso = peso.Text
        valorAltura = altura.Text
        resultado.Text = valorPeso / ((valorAltura / 100) * (valorAltura / 100))

        res = resultado.Text

    End Sub

    Private Sub Homem_CheckedChanged(sender As Object, e As EventArgs) Handles Homem.CheckedChanged
        Homem.BackColor = Color.IndianRed
        Mulher.BackColor = Color.White
        gender = "homem"

    End Sub

    Private Sub Mulher_CheckedChanged(sender As Object, e As EventArgs) Handles Mulher.CheckedChanged
        Mulher.BackColor = Color.HotPink
        Homem.BackColor = Color.White
        gender = "mulher"

    End Sub


End Class