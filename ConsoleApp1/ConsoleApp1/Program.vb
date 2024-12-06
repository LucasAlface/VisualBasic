Imports System
Imports System.Runtime.InteropServices.JavaScript.JSType

Module Program
    Sub juntaNomes(ByRef nome As String, ByRef sobrenome As String)
        Console.WriteLine(nome & " " & sobrenome)
    End Sub

    Function calcularValorPagar(ByRef horas As Decimal, ByRef preco As Double) As Double
        Return horas * preco
    End Function
    Sub Main(args As String())
        ' comentario
        Dim valor As Double
        Dim idade As Integer
        Dim ano As Integer

        ano = 2024
        Console.WriteLine("Por favor escreva a sua Idade: ")
        idade = Console.ReadLine()

        If (idade < 18) Then
            Console.WriteLine("É menor de idade")
        Else
            Console.WriteLine("Nasceu em " & ano - idade)
        End If

        juntaNomes("Lucas", "Soares")

        valor = calcularValorPagar(2.3, 5)

        Console.WriteLine(valor)

        Console.ReadLine()
    End Sub
End Module
