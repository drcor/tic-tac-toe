Public Class EndGameForm
    ' Inicializacao do form
    Private Sub EndGameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Centralizar janela no MainForm
        Dim sizeX, sizeY As Integer
        sizeX = Me.Width / 2
        sizeY = Me.Height / 2
        Me.Location = New Point(MainForm.Location.X + (MainForm.Width / 2 - sizeX), MainForm.Location.Y + (MainForm.Height / 2 - sizeY))

        ' Introduzir resultado do jogo
        LblJogador1.Text = jogadores_nome(0)
        LblJogador2.Text = jogadores_nome(1)
        LblPontuacao1.Text = jogadores_pontuacao(0)
        LblPontuacao2.Text = jogadores_pontuacao(1)
    End Sub

    ' Close game
    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        InitialForm.Close()
        MainForm.Close()
        Me.Close()
    End Sub

    ' Novo jogo
    Private Sub BtnNovoJogo_Click(sender As Object, e As EventArgs) Handles BtnNovoJogo.Click
        LimparCampoJogo()
        Me.Close()
    End Sub

    ' Nova serie
    Private Sub BtnNovaSerie_Click(sender As Object, e As EventArgs) Handles BtnNovaSerie.Click
        LimparCampoJogo()
        jogadores_pontuacao(0) = 0
        jogadores_pontuacao(1) = 0

        InitialForm.Show()
        MainForm.Close()
        Me.Close()
    End Sub
End Class