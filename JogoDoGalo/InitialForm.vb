Public Class InitialForm
    ' Inicializacao do form
    Private Sub InitialForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtNickJogador1.Text = jogadores_nome(0)
        TxtNickJogador2.Text = jogadores_nome(1)
    End Sub

    ' Alteracao do design consuante tipo de jogo
    Private Sub RdbComputer_CheckedChanged(sender As Object, e As EventArgs) Handles RdbComputer.CheckedChanged
        ' Verificar opcao VS computador
        If RdbComputer.Checked = True Then
            GrbNivel.Visible = True
            GrbTipoJogo.Width = 268
            TxtNickJogador2.Text = "Computador"
            TxtNickJogador2.Enabled = False
        Else
            GrbNivel.Visible = False
            GrbTipoJogo.Width = 530
            TxtNickJogador2.Text = "Jogador2"
            TxtNickJogador2.Enabled = True
        End If
    End Sub

    ' Sair
    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub

    ' Iniciar jogo
    Private Sub BtnJogar_Click(sender As Object, e As EventArgs) Handles BtnJogar.Click
        ' Defenir nome dos jogadores
        jogadores_nome(0) = If(TxtNickJogador1.Text = Nothing, "Jogador1", TxtNickJogador1.Text)
        jogadores_nome(1) = If(TxtNickJogador2.Text = Nothing, "Jogador2", TxtNickJogador2.Text)

        ' Abrir janela de jogo
        MainForm.Show()
        Me.Hide()
    End Sub
End Class
