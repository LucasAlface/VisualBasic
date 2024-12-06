Public Class FormCalculadora
    Dim operador As String
    Dim numero1 As Integer = 0
    Dim numero2 As Integer = 0

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Form1.frm2 = Nothing
        Form1.Show()
        Me.Close()
    End Sub

    Public Sub Operacao(num1, num2)
        Dim Resultado As Double

        If LabOperador.Text = "+" Then
            Resultado = num1 + num2
            TextBox1.Text = Resultado
        End If

        If LabOperador.Text = "-" Then
            Resultado = num1 - num2
            TextBox1.Text = Resultado
        End If

        If LabOperador.Text = "*" Then
            Resultado = num1 * num2
            TextBox1.Text = Resultado
        End If

        If LabOperador.Text = "/" Then
            Resultado = num1 / num2
            TextBox1.Text = Resultado
        End If
        numero1 = Resultado
        LabNum1.Text = numero1
        TextBox1.Text = "0"

    End Sub

    Public Sub Adicionar_Numero_Operacao()
        LabOperador.Text = operador
        If numero1 = 0 Then
            numero1 = TextBox1.Text
            TextBox1.Text = "0"
        Else
            LabNum1.Text = numero1
            numero2 = TextBox1.Text
        End If
        LabNum1.Text = numero1

    End Sub

    Private Sub botDivide_Click(sender As Object, e As EventArgs) Handles botDivide.Click
        operador = "/"
        Adicionar_Numero_Operacao()

    End Sub

    Private Sub botMultiply_Click(sender As Object, e As EventArgs) Handles botMultiply.Click
        operador = "*"
        Adicionar_Numero_Operacao()
    End Sub

    Private Sub botAdd_Click(sender As Object, e As EventArgs) Handles botAdd.Click
        operador = "+"
        Adicionar_Numero_Operacao()
    End Sub

    Private Sub botMinus_Click(sender As Object, e As EventArgs) Handles botMinus.Click
        operador = "-"
        Adicionar_Numero_Operacao()
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

    Private Sub botComma_Click(sender As Object, e As EventArgs) Handles botComma.Click
        inserirNum(",")
    End Sub

    Private Sub botDeleteAll_Click(sender As Object, e As EventArgs) Handles botDeleteAll.Click
        TextBox1.Text = "0"
    End Sub

    Private Sub botEqual_Click(sender As Object, e As EventArgs) Handles botEqual.Click
        numero2 = TextBox1.Text
        Operacao(numero1, numero2)
    End Sub

    Private Sub botDelete_Click(sender As Object, e As EventArgs) Handles botDelete.Click
        TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
    End Sub

    Private Sub BotRemoveAll_Click(sender As Object, e As EventArgs) Handles BotRemoveAll.Click
        numero1 = 0
        LabNum1.Text = ""
        LabOperador.Text = ""
        TextBox1.Text = "0"
    End Sub

    Private Sub botSwitch_Click(sender As Object, e As EventArgs) Handles botSwitch.Click
        If operador = "+" Then
            operador = "-"
        ElseIf operador = "-" Then
            operador = "+"
        ElseIf operador = "*" Then
            operador = "/"
        ElseIf operador = "/" Then
            operador = "*"
        End If
        LabOperador.Text = operador
    End Sub
End Class