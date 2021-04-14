Module GameEngine
    Public vitoria As Boolean = False
    Public jogada As Integer = 1  ' Incia com a jogada do X
    Public jogadores_nome() As String = {"Jogador1", "Computador"}  ' Nomes dos jogadores
    Public jogadores_pontuacao() As Integer = {0, 0}
    Public camposVazios As Integer = 9
    Public campoJogo(,) As Integer = {{0, 0, 0}, {0, 0, 0}, {0, 0, 0}}  ' Array de jogadas

    ' Limpar campo de jogo
    Public Sub limparCampoJogo()
        vitoria = False
        camposVazios = 9
        For lin = 0 To 2
            For col = 0 To 2
                campoJogo(lin, col) = 0
            Next
        Next
        MainForm.Pic00.Image = Nothing
        MainForm.Pic01.Image = Nothing
        MainForm.Pic02.Image = Nothing
        MainForm.Pic10.Image = Nothing
        MainForm.Pic11.Image = Nothing
        MainForm.Pic12.Image = Nothing
        MainForm.Pic20.Image = Nothing
        MainForm.Pic21.Image = Nothing
        MainForm.Pic22.Image = Nothing

        MainForm.LblNickJogador1.Text = jogadores_nome(0)
        MainForm.LblNickJogador2.Text = jogadores_nome(1)
        MainForm.LblPontuacao1.Text = jogadores_pontuacao(0)
        MainForm.LblPontuacao2.Text = jogadores_pontuacao(1)

        If jogada = 1 Then
            MainForm.LblJogar1.Visible = True
            MainForm.LblJogar2.Visible = False
        Else
            MainForm.LblJogar1.Visible = False
            MainForm.LblJogar2.Visible = True
        End If
    End Sub

    ' Verificar se ha vitoria
    Public Sub checkVitoria()
        Dim tmp As Integer

        ' Verificar linhas
        For lin = 0 To 2
            tmp = campoJogo(lin, 0)
            For col = 1 To 2
                tmp = tmp And campoJogo(lin, col)
            Next

            If tmp > 0 Then
                vitoria = True
                Exit Sub
            End If
        Next

        ' Verificar colunas
        For col = 0 To 2
            tmp = campoJogo(0, col)
            For lin = 1 To 2
                tmp = tmp And campoJogo(lin, col)
            Next

            If tmp > 0 Then
                vitoria = True
                Exit Sub
            End If
        Next

        ' Verificar diagonal para direita
        tmp = campoJogo(0, 0)
        For lincol = 1 To 2
            tmp = tmp And campoJogo(lincol, lincol)
        Next
        If tmp > 0 Then
            vitoria = True
            Exit Sub
        End If

        ' Verificar diagonal para esquerda
        tmp = campoJogo(0, 2)
        For lin = 1 To 2
            tmp = tmp And campoJogo(lin, 2 - lin)
        Next
        If tmp > 0 Then
            vitoria = True
            Exit Sub
        End If
    End Sub
End Module
