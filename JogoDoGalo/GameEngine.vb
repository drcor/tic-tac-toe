Module GameEngine
    Public jogador As Boolean = True  ' Incia com a jogada do X
    Public jogadores_nome() As String = {"Jogador1", "Computador"}  ' Nomes dos jogadores
    Public jogadores_pontuacao() As Integer = {0, 0}
    Public campoJogo(,) As Integer = {{0, 0, 0}, {0, 0, 0}, {0, 0, 0}}  ' Array de jogadas

    ' Limpar campo de jogo
    Public Sub LimparCampoJogo()

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

        If jogador Or (jogador = False And InitialForm.RdbComputer.Checked) Then
            MainForm.LblJogar1.Visible = True
            MainForm.LblJogar2.Visible = False
            jogador = 2
        Else
            MainForm.LblJogar1.Visible = False
            MainForm.LblJogar2.Visible = True
        End If
    End Sub

    ' Veirificar numero de campos vazios
    Public Function CheckCamposVazios(ByRef board(,) As Integer) As Integer
        Dim camposVazios As Integer = 0
        For lin = 0 To 2
            For col = 0 To 2
                If board(lin, col) = 0 Then
                    camposVazios += 1
                End If
            Next
        Next
        Return camposVazios
    End Function

    ' Verificar se existe uma vitoria
    Public Function CheckVitoria() As Integer
        Dim win(,,) As Integer = {{{0, 0}, {0, 1}, {0, 2}},
                                  {{1, 0}, {1, 1}, {1, 2}},
                                  {{2, 0}, {2, 1}, {2, 2}},
                                  {{0, 0}, {1, 0}, {2, 0}},
                                  {{0, 1}, {1, 1}, {2, 1}},
                                  {{0, 2}, {1, 2}, {2, 2}},
                                  {{0, 0}, {1, 1}, {2, 2}},
                                  {{0, 2}, {1, 1}, {2, 0}}}

        For i = 0 To 7
            If campoJogo(win(i, 0, 0), win(i, 0, 1)) <> 0 And campoJogo(win(i, 0, 0), win(i, 0, 1)) = campoJogo(win(i, 1, 0), win(i, 1, 1)) And campoJogo(win(i, 0, 0), win(i, 0, 1)) = campoJogo(win(i, 2, 0), win(i, 2, 1)) Then
                Return campoJogo(win(i, 2, 0), win(i, 2, 1))
            End If
        Next

        Return 0
    End Function

    ' Prever as jogadas futuras
    Private Function MiniMax(ByRef board(,) As Integer, ByVal isMax As Boolean, ByVal depth As Integer) As Integer
        Dim winner As Integer = CheckVitoria()

        ' Se o jogador ganhar retorna -10 pontos
        If winner = 2 Then
            Return -10
        ElseIf winner = 1 Then  ' Se o Computador ganhar retorna 10 pontos
            Return 10
        End If

        ' Se nao houver mais jogadas retorna 0
        If CheckCamposVazios(board) = 0 Then
            Return 0
        End If

        Dim best As Integer

        ' Se for a vez do Computador jogar
        If isMax Then
            best = -1000

            For lin = 0 To 2
                For col = 0 To 2
                    ' Se o campo estiver livre para jogar
                    If board(lin, col) = 0 Then
                        ' Joga-se nesse campo como Computador
                        board(lin, col) = 1

                        ' Compara se pelo maior valor
                        best = Math.Max(best, MiniMax(board, Not isMax, depth + 1))

                        ' Limpar jogada
                        board(lin, col) = 0
                    End If
                Next
            Next
        Else  ' Se for a vez do Jogador
            best = 1000

            For lin = 0 To 2
                For col = 0 To 2
                    ' Se o campo estiver livre para jogar
                    If board(lin, col) = 0 Then
                        ' Joga-se nesse campo como Jogador
                        board(lin, col) = 2

                        ' Compara se pelo menor valor
                        best = Math.Min(best, MiniMax(board, Not isMax, depth + 1))

                        ' Limpar jogada
                        board(lin, col) = 0
                    End If
                Next
            Next
        End If

        Return best
    End Function

    ' Procurar pela melhor jogada
    Private Function FindBestMove(ByRef board(,) As Integer) As Integer()
        Dim bestVal As Integer = -1000
        Dim bestMove() As Integer = {-1, -1}

        For lin = 0 To 2
            For col = 0 To 2
                ' Se o campo estiver livre para jogar
                If board(lin, col) = 0 Then
                    ' Joga-se nesse campo como Computador
                    board(lin, col) = 1

                    ' Obtem-se o valor da previsao de pontos do Minimax
                    Dim moveVal As Integer = MiniMax(board, False, 0)

                    ' Limpa-se a jogada
                    board(lin, col) = 0

                    ' Se o valor da previsao de pontos for maior do que -1000
                    If moveVal > bestVal Then
                        ' Define a melhor posicao para se jogar
                        bestMove = {lin, col}
                        bestVal = moveVal
                    End If
                End If
            Next
        Next

        'MsgBox("bestmove = {" & bestMove(0) & ", " & bestMove(1) & "} bestval = " & bestVal)
        Return bestMove
    End Function

    ' Jogar pelo computador
    Public Sub JogarComputador()
        If InitialForm.RdbNivelFacil.Checked Then
            Dim cont As Integer = 0
            Dim tmp As Integer
            While True
                ' Escolher quadrado aleatorio para inserir
                tmp = CInt(Math.Floor((CheckCamposVazios(campoJogo) + 1) * Rnd()))

                ' Se nao houver mais jogadas
                If CheckCamposVazios(campoJogo) = 0 Then
                    Exit Sub
                End If

                For lin = 0 To 2
                    For col = 0 To 2
                        ' Contar o numero de campos vazios
                        If campoJogo(lin, col) = 0 Then
                            cont += 1
                        End If

                        If cont >= tmp Then
                            ' Se o campo estiver vazio, joga para essa posicao
                            If campoJogo(lin, col) = 0 Then
                                campoJogo(lin, col) = 1
                                If lin = 0 And col = 0 Then
                                    MainForm.Pic00.Image = My.Resources.img_o
                                ElseIf lin = 0 And col = 1 Then
                                    MainForm.Pic01.Image = My.Resources.img_o
                                ElseIf lin = 0 And col = 2 Then
                                    MainForm.Pic02.Image = My.Resources.img_o
                                ElseIf lin = 1 And col = 0 Then
                                    MainForm.Pic10.Image = My.Resources.img_o
                                ElseIf lin = 1 And col = 1 Then
                                    MainForm.Pic11.Image = My.Resources.img_o
                                ElseIf lin = 1 And col = 2 Then
                                    MainForm.Pic12.Image = My.Resources.img_o
                                ElseIf lin = 2 And col = 0 Then
                                    MainForm.Pic20.Image = My.Resources.img_o
                                ElseIf lin = 2 And col = 1 Then
                                    MainForm.Pic21.Image = My.Resources.img_o
                                ElseIf lin = 2 And col = 2 Then
                                    MainForm.Pic22.Image = My.Resources.img_o
                                End If

                                jogador = 2
                                MainForm.LblJogar1.Visible = True
                                MainForm.LblJogar2.Visible = False
                                Exit Sub
                            Else  ' Se nao escolhe outra posicao
                                Continue While
                            End If
                        End If
                    Next
                Next
            End While

        Else
            Dim bestMove() As Integer = FindBestMove(campoJogo)

            'MsgBox("bestmove = {" & bestMove(0) & ", " & bestMove(1) & "} lin = " & lin & " col = " & col)

            campoJogo(bestMove(0), bestMove(1)) = 1

            If bestMove(0) = 0 And bestMove(1) = 0 Then
                MainForm.Pic00.Image = My.Resources.img_o
            ElseIf bestMove(0) = 0 And bestMove(1) = 1 Then
                MainForm.Pic01.Image = My.Resources.img_o
            ElseIf bestMove(0) = 0 And bestMove(1) = 2 Then
                MainForm.Pic02.Image = My.Resources.img_o
            ElseIf bestMove(0) = 1 And bestMove(1) = 0 Then
                MainForm.Pic10.Image = My.Resources.img_o
            ElseIf bestMove(0) = 1 And bestMove(1) = 1 Then
                MainForm.Pic11.Image = My.Resources.img_o
            ElseIf bestMove(0) = 1 And bestMove(1) = 2 Then
                MainForm.Pic12.Image = My.Resources.img_o
            ElseIf bestMove(0) = 2 And bestMove(1) = 0 Then
                MainForm.Pic20.Image = My.Resources.img_o
            ElseIf bestMove(0) = 2 And bestMove(1) = 1 Then
                MainForm.Pic21.Image = My.Resources.img_o
            ElseIf bestMove(0) = 2 And bestMove(1) = 2 Then
                MainForm.Pic22.Image = My.Resources.img_o
            End If

            jogador = 2
            MainForm.LblJogar1.Visible = True
            MainForm.LblJogar2.Visible = False
        End If

    End Sub
End Module
