Public Class Form3
    Private Sub MARCASBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MARCASBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MARCASBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDDataSet)

    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'BDDataSet.MARCAS'. Você pode movê-la ou removê-la conforme necessário.
        Me.MARCASTableAdapter.Fill(Me.BDDataSet.MARCAS)

    End Sub

    Private Sub botAnterior_Click(sender As Object, e As EventArgs) Handles botAnterior.Click
        MARCASBindingSource.MovePrevious()
    End Sub

    Private Sub botSeguinte_Click(sender As Object, e As EventArgs) Handles botSeguinte.Click
        MARCASBindingSource.MoveNext()
    End Sub

    Private Sub botNovo_Click(sender As Object, e As EventArgs) Handles botNovo.Click
        MARCASBindingSource.AddNew()
    End Sub

    Private Sub botGravar_Click(sender As Object, e As EventArgs) Handles botGravar.Click
        Try
            MARCASBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(BDDataSet)
            MsgBox("Gravação de dados com sucesso", vbOKOnly, "GMEI Software!")
        Catch ex As Exception
            MsgBox("Erro! Registo já existente!!!", vbOKOnly, "GMEI Software!")
        End Try
    End Sub

    Private Sub botRemover_Click(sender As Object, e As EventArgs) Handles botRemover.Click
        Try
            MARCASBindingSource.RemoveCurrent()
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