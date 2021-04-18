Public Class MainForm
    ' Inicializacao do form
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Centralizar janela no InitialForm
        Dim sizeX, sizeY As Integer
        sizeX = Me.Width / 2
        sizeY = Me.Height / 2
        Me.Location = New Point(InitialForm.Location.X + (InitialForm.Width / 2 - sizeX), InitialForm.Location.Y + (InitialForm.Height / 2 - sizeY))

        LimparCampoJogo()
    End Sub

    ' Click de jogada
    Private Sub PictureBox_Click(sender As Object, e As EventArgs) Handles Pic22.Click, Pic21.Click, Pic20.Click, Pic10.Click, Pic11.Click, Pic12.Click, Pic02.Click, Pic01.Click, Pic00.Click
        If CheckCamposVazios(campoJogo) > 0 And CheckVitoria() = 0 Then
            Dim lin, col As Integer

            ' Obter posicao da Picturebox
            lin = Val(sender.name.Chars(3))
            col = Val(sender.name.Chars(4))

            ' Se o campo estiver livre para jogar
            If campoJogo(lin, col) = 0 Then
                ' Se for a vez do jogador X
                If jogador Then
                    sender.image = JogoDoGalo.My.Resources.img_x
                    campoJogo(lin, col) = 2
                    jogador = Not jogador

                    LblJogar1.Visible = False
                    LblJogar2.Visible = True

                    ' Se estiver em jogo com o Computador
                    If InitialForm.RdbComputer.Checked And CheckVitoria() = 0 And CheckCamposVazios(campoJogo) > 0 Then
                        JogarComputador()
                    End If
                Else  ' Se for a vez do jogador O
                    sender.image = JogoDoGalo.My.Resources.img_o
                    campoJogo(lin, col) = 1
                    jogador = Not jogador

                    LblJogar1.Visible = True
                    LblJogar2.Visible = False
                End If
            End If
        End If

        ' Se houver vitoria de um dos jogadores
        If CheckVitoria() > 0 Then
            If Not jogador Then  ' Se for o jogador X
                jogadores_pontuacao(0) += 1
                EndGameForm.LblStatus.Text = "Vitoria de " & jogadores_nome(0)  ' Mensagem de fim do jogo
                EndGameForm.LblStatus.ForeColor = Color.DarkGreen
            Else  ' Se for o jogador O
                jogadores_pontuacao(1) += 1
                EndGameForm.LblStatus.Text = "Vitoria de " & jogadores_nome(1)  ' Mensagem de fim do jogo
                If InitialForm.RdbComputer.Checked Then  ' Mudar cor da mensagem de fim do jogo consuante o oponente
                    EndGameForm.LblStatus.ForeColor = Color.DarkRed
                Else
                    EndGameForm.LblStatus.ForeColor = Color.DarkGreen
                End If
            End If
            EndGameForm.ShowDialog()
        ElseIf CheckCamposVazios(campoJogo) = 0 Then  ' Se houver empate
            EndGameForm.LblStatus.Text = "Empate"  ' Mensagem de fim do jogo
            EndGameForm.LblStatus.ForeColor = Color.DarkGoldenrod
            EndGameForm.ShowDialog()
        End If
    End Sub

    ' Regras do jogo
    Private Sub BtnRegras_Click(sender As Object, e As EventArgs) Handles BtnRegras.Click
        HelpForm.ShowDialog()
    End Sub

    ' Ao fechar janela de jogo
    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        InitialForm.Show()
        LimparCampoJogo()
    End Sub

    ' Sair da partida
    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        InitialForm.Show()
        Me.Close()
        LimparCampoJogo()
    End Sub
End Class