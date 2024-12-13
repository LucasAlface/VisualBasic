Public Class FormCalculadora
    Dim operador As String = ""
    Dim numero1 As Double = 0.0
    Dim numero2 As Double = 0.0
    ' O LabNum1 é o histórico

    ' Fechar o Programa
    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Form1.frm2 = Nothing
        Form1.Show()
        Me.Close()
    End Sub

    ' Realiza a conta e exibe o resultado quando se clica no botão de igual
    Public Sub Operacao(num1, num2)
        Dim Resultado As Double

        ' Soma
        If LabOperador.Text = "+" Then ' Verifica o operador a ser utilizado
            Resultado = num1 + num2 ' Realiza a conta
            TextBox1.Text = Resultado ' Coloca o resultado na caixa de texto
        End If
        ' Subtração
        If LabOperador.Text = "-" Then
            Resultado = num1 - num2
            TextBox1.Text = Resultado
        End If
        ' Multiplicação
        If LabOperador.Text = "*" Then
            Resultado = num1 * num2
            TextBox1.Text = Resultado
        End If
        ' Divisão
        If LabOperador.Text = "/" Then
            Resultado = num1 / num2
            TextBox1.Text = Resultado
        End If
        LabNum1.Text = LabNum1.Text & numero2 & "=" ' Exibição da operação realizada
        TextBox1.Text = Resultado ' Exibição do resultado
        numero1 = 0 ' Reseta para se poder realizar novas operações

    End Sub

    ' Realiza a operação quando se clica em operadores, mas não exibe o resultado
    Public Sub OperacaoContinua(num1, num2)
        Dim Resultado As Double

        ' Soma
        If LabOperador.Text = "+" Then ' Verifica o operador a ser utilizado
            Resultado = num1 + num2 ' Realiza a conta
            TextBox1.Text = Resultado ' Coloca o resultado na caixa de texto
        End If
        ' Subtração
        If LabOperador.Text = "-" Then
            Resultado = num1 - num2
            TextBox1.Text = Resultado
        End If
        ' Multiplicação
        If LabOperador.Text = "*" Then
            Resultado = num1 * num2
            TextBox1.Text = Resultado
        End If
        ' Divisão
        If LabOperador.Text = "/" Then
            Resultado = num1 / num2
            TextBox1.Text = Resultado
        End If
        numero1 = Resultado ' O número1 passa a ser o resultado, para se poder fazer contas sobre o mesmo 
        TextBox1.Text = "0" ' Passa a 0 outra vez para poder ser inserido o num2

    End Sub

    ' Recolhe o operador e os numeros a serem utilizados
    Public Sub Adicionar_Numero_Operacao()
        If numero1 = 0 Then
            numero1 = TextBox1.Text
            TextBox1.Text = "0" ' Reseta a caixa 
            LabNum1.Text = numero1 & operador ' O num1 vai para a caixa respetiva
        ElseIf operador <> "" Or TextBox1.Text = "0" Then
            numero2 = TextBox1.Text
            If numero2 <> 0 Then
                LabNum1.Text = LabNum1.Text & numero2 & operador
                OperacaoContinua(numero1, numero2)
            Else
                LabNum1.Text = numero1 & operador
            End If

        End If
        LabOperador.Text = operador ' Recolhe o operador
        operador = ""

    End Sub

    ' Decidir operaor
    Private Sub botDivide_Click(sender As Object, e As EventArgs) Handles botDivide.Click
        operador = "/" ' Envia operador
        Adicionar_Numero_Operacao() ' Envia num atual

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

    ' Inserção de numeros na calculadora
    Public Sub inserirNum(numero As String)
        If (TextBox1.Text = "0") Then
            TextBox1.Text = numero
        Else
            TextBox1.Text = TextBox1.Text & numero
        End If
    End Sub

    ' Associar a inserção de numeros com os botoes
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
        If Not TextBox1.Text.Contains(",") Then ' Impede que se insira várias ","
            inserirNum(",")
        End If
    End Sub

    ' Apagar o numero inteiro que está na caixa
    Private Sub botDeleteAll_Click(sender As Object, e As EventArgs) Handles botDeleteAll.Click
        TextBox1.Text = "0"
    End Sub

    ' Apagar carater
    Private Sub botDelete_Click(sender As Object, e As EventArgs) Handles botDelete.Click
        TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1) ' O -1 é a última posição da String
    End Sub

    ' Resetar tudo 
    Private Sub BotRemoveAll_Click(sender As Object, e As EventArgs) Handles BotRemoveAll.Click
        numero1 = 0
        LabNum1.Text = ""
        LabOperador.Text = ""
        TextBox1.Text = "0"
    End Sub

    ' Botão de igual
    Private Sub botEqual_Click(sender As Object, e As EventArgs) Handles botEqual.Click
        If Not LabNum1.Text.Contains("=") Then ' Impede que se insira vários "="
            numero2 = TextBox1.Text ' Envia num 2
            Operacao(numero1, numero2) ' Realiza operacao
        End If

    End Sub

    ' Troca de sinais
    Private Sub botSwitch_Click(sender As Object, e As EventArgs) Handles botSwitch.Click
        TextBox1.Text = TextBox1.Text * -1
    End Sub
End Class