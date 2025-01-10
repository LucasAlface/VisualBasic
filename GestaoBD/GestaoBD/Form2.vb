Public Class Form2

    Private Sub CARROSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CARROSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CARROSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'BDDataSet.CARROS'. Você pode movê-la ou removê-la conforme necessário.
        Me.CARROSTableAdapter.Fill(Me.BDDataSet.CARROS)

    End Sub

    Private Sub botAnterior_Click(sender As Object, e As EventArgs) Handles botAnterior.Click
        CARROSBindingSource.MovePrevious()
    End Sub

    Private Sub botSeguinte_Click(sender As Object, e As EventArgs) Handles botSeguinte.Click
        CARROSBindingSource.MoveNext()
    End Sub

    Private Sub botNovo_Click(sender As Object, e As EventArgs) Handles botNovo.Click
        CARROSBindingSource.AddNew()
    End Sub

    Private Sub botGravar_Click(sender As Object, e As EventArgs) Handles botGravar.Click
        Try
            CARROSBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(BDDataSet)
            MsgBox("Gravação de dados com sucesso", vbOKOnly, "GMEI Software!")
        Catch ex As Exception
            MsgBox("Erro! Registo já existente!!!", vbOKOnly, "GMEI Software!")
        End Try
    End Sub

    Private Sub botRemover_Click(sender As Object, e As EventArgs) Handles botRemover.Click
        Try
            CARROSBindingSource.RemoveCurrent()
            TableAdapterManager.UpdateAll(BDDataSet)
            MsgBox("Registo atual foi apagado", vbOKOnly, "GMEI Software!")
        Catch ex As Exception
            MsgBox("Erro!", vbOKOnly, "GMEI Software!")
        End Try
    End Sub

    Private Sub botFechar_Click(sender As Object, e As EventArgs) Handles botFechar.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub botSair_Click(sender As Object, e As EventArgs) Handles botSair.Click
        Application.Exit()
    End Sub
End Class