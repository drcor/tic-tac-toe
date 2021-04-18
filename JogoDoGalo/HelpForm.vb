Public Class HelpForm
    ' ' Inicializacao do form
    Private Sub HelpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Centralizar janela no MainForm
        Dim sizeX, sizeY As Integer
        sizeX = Me.Width / 2
        sizeY = Me.Height / 2
        Me.Location = New Point(MainForm.Location.X + (MainForm.Width / 2 - sizeX), MainForm.Location.Y + (MainForm.Height / 2 - sizeY))

        LblRules.Text = "1.    O jogo do galo é um jogo que envolve dois jogadores:
    - um joga com o X;
    - e o outro com O.

2.    Inicialmente, o tabuleiro é composto por 9 quadrados vazios, alinhados em 3x3.

3.    Os dois jogam alternadamente, começando pelo jogador X, apenas se podendo jogar nos quadrados livres.

4.    O objetivo do jogo é ocupar 3 quadrados de modo a formar uma linha, coluna ou diagonal.

5.    Se o tabuleiro estiver cheio mas nenhum jogador conseguir a cumprir este objetivo, então o jogo termina empatado."
    End Sub

    ' Sair do form
    Private Sub BtnContinuar_Click(sender As Object, e As EventArgs) Handles BtnContinuar.Click
        Me.Close()
    End Sub
End Class