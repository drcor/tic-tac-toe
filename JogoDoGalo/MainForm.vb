Public Class MainForm
    ' Inicializacao do form
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limparCampoJogo()
    End Sub

    ' Click de jogada
    Private Sub PictureBox_Click(sender As Object, e As EventArgs) Handles Pic22.Click, Pic21.Click, Pic20.Click, Pic10.Click, Pic11.Click, Pic12.Click, Pic02.Click, Pic01.Click, Pic00.Click
        If camposVazios > 0 Then
            Dim lin, col As Integer

            ' Obter posicao da Picturebox
            lin = Val(sender.name.Chars(3))
            col = Val(sender.name.Chars(4))

            If campoJogo(lin, col) = 0 Then
                If jogada = 1 Then
                    sender.image = JogoDoGalo.My.Resources.img_x
                    campoJogo(lin, col) = 2
                    jogada = 0
                    LblJogar2.Visible = True
                    LblJogar1.Visible = False
                Else
                    sender.image = JogoDoGalo.My.Resources.img_o
                    campoJogo(lin, col) = 1
                    jogada = 1
                    LblJogar2.Visible = False
                    LblJogar1.Visible = True
                End If
                camposVazios -= 1
            End If

            ' Verificar se ha alguma vitoria
            checkVitoria()
        End If

        If vitoria = True Then
            If jogada = 1 Then
                jogadores_pontuacao(1) += 1
                EndGameForm.LblStatus.Text = "Vitoria de " & jogadores_nome(1)  ' Defenir mensagem de fim do jogo
            ElseIf jogada = 0 Then
                jogadores_pontuacao(0) += 1
                EndGameForm.LblStatus.Text = "Vitoria de " & jogadores_nome(0)  ' Defenir mensagem de fim do jogo
            End If
            EndGameForm.ShowDialog()
        ElseIf camposVazios = 0 Then
            EndGameForm.LblStatus.Text = "Empate"  ' Defenir mensagem de fim do jogo
            EndGameForm.ShowDialog()
        End If
    End Sub

    ' Ao fechar janela de jogo
    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        InitialForm.Show()
        limparCampoJogo()
    End Sub
End Class