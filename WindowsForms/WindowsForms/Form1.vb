Public Class Form1

    Public frm2 As Form2
    Public frm3 As Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If IsNothing(frm2) = False Then

            MsgBox("O formulário já esta aberto !", MsgBoxStyle.Exclamation)

        Else

            frm2 = New Form2()

            frm2.Show()

            'Me.Hide()   ' Esconde o formulário quando a ação é executada.

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Close()  ' Close ou Me.Close  fecha o Form1 que é o nosso 'Main' 

        Application.Exit() ' este fecha a App Toda

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If IsNothing(frm3) = False Then

            MsgBox("O formulário já esta aberto !", MsgBoxStyle.Exclamation)

        Else

            frm3 = New Form3()

            frm3.Show()

            'Me.Hide()   ' Esconde o formulário quando a ação é executada.

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
