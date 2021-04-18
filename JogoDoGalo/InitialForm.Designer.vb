<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InitialForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GrbTipoJogo = New System.Windows.Forms.GroupBox()
        Me.RdbComputer = New System.Windows.Forms.RadioButton()
        Me.RdbPlayer = New System.Windows.Forms.RadioButton()
        Me.GrbNivel = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RdbNivelFacil = New System.Windows.Forms.RadioButton()
        Me.BtnJogar = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.TxtNickJogador2 = New System.Windows.Forms.TextBox()
        Me.LblTitleJogador2 = New System.Windows.Forms.Label()
        Me.LblTitleJogador1 = New System.Windows.Forms.Label()
        Me.TxtNickJogador1 = New System.Windows.Forms.TextBox()
        Me.GrbTipoJogo.SuspendLayout()
        Me.GrbNivel.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrbTipoJogo
        '
        Me.GrbTipoJogo.Controls.Add(Me.RdbComputer)
        Me.GrbTipoJogo.Controls.Add(Me.RdbPlayer)
        Me.GrbTipoJogo.Location = New System.Drawing.Point(31, 125)
        Me.GrbTipoJogo.Name = "GrbTipoJogo"
        Me.GrbTipoJogo.Size = New System.Drawing.Size(268, 130)
        Me.GrbTipoJogo.TabIndex = 0
        Me.GrbTipoJogo.TabStop = False
        Me.GrbTipoJogo.Text = "Selecione o modo de jogo"
        '
        'RdbComputer
        '
        Me.RdbComputer.AutoSize = True
        Me.RdbComputer.Checked = True
        Me.RdbComputer.Location = New System.Drawing.Point(30, 84)
        Me.RdbComputer.Name = "RdbComputer"
        Me.RdbComputer.Size = New System.Drawing.Size(157, 24)
        Me.RdbComputer.TabIndex = 1
        Me.RdbComputer.TabStop = True
        Me.RdbComputer.Text = "Player vs Computer"
        Me.RdbComputer.UseVisualStyleBackColor = True
        '
        'RdbPlayer
        '
        Me.RdbPlayer.AutoSize = True
        Me.RdbPlayer.Location = New System.Drawing.Point(30, 43)
        Me.RdbPlayer.Name = "RdbPlayer"
        Me.RdbPlayer.Size = New System.Drawing.Size(131, 24)
        Me.RdbPlayer.TabIndex = 0
        Me.RdbPlayer.Text = "Player vs Player"
        Me.RdbPlayer.UseVisualStyleBackColor = True
        '
        'GrbNivel
        '
        Me.GrbNivel.Controls.Add(Me.RadioButton1)
        Me.GrbNivel.Controls.Add(Me.RdbNivelFacil)
        Me.GrbNivel.Location = New System.Drawing.Point(320, 125)
        Me.GrbNivel.Name = "GrbNivel"
        Me.GrbNivel.Size = New System.Drawing.Size(241, 130)
        Me.GrbNivel.TabIndex = 1
        Me.GrbNivel.TabStop = False
        Me.GrbNivel.Text = "Nível de dificuldade"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(32, 84)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(100, 24)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.Text = "Impossível"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RdbNivelFacil
        '
        Me.RdbNivelFacil.AutoSize = True
        Me.RdbNivelFacil.Checked = True
        Me.RdbNivelFacil.Location = New System.Drawing.Point(32, 45)
        Me.RdbNivelFacil.Name = "RdbNivelFacil"
        Me.RdbNivelFacil.Size = New System.Drawing.Size(59, 24)
        Me.RdbNivelFacil.TabIndex = 0
        Me.RdbNivelFacil.TabStop = True
        Me.RdbNivelFacil.Text = "Fácil"
        Me.RdbNivelFacil.UseVisualStyleBackColor = True
        '
        'BtnJogar
        '
        Me.BtnJogar.Location = New System.Drawing.Point(389, 276)
        Me.BtnJogar.Name = "BtnJogar"
        Me.BtnJogar.Size = New System.Drawing.Size(172, 47)
        Me.BtnJogar.TabIndex = 2
        Me.BtnJogar.Text = "Iniciar jogo"
        Me.BtnJogar.UseVisualStyleBackColor = True
        '
        'BtnSair
        '
        Me.BtnSair.Location = New System.Drawing.Point(31, 276)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(83, 47)
        Me.BtnSair.TabIndex = 3
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'TxtNickJogador2
        '
        Me.TxtNickJogador2.Location = New System.Drawing.Point(342, 64)
        Me.TxtNickJogador2.MaxLength = 12
        Me.TxtNickJogador2.Name = "TxtNickJogador2"
        Me.TxtNickJogador2.Size = New System.Drawing.Size(219, 27)
        Me.TxtNickJogador2.TabIndex = 4
        '
        'LblTitleJogador2
        '
        Me.LblTitleJogador2.AutoSize = True
        Me.LblTitleJogador2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTitleJogador2.Location = New System.Drawing.Point(320, 41)
        Me.LblTitleJogador2.Name = "LblTitleJogador2"
        Me.LblTitleJogador2.Size = New System.Drawing.Size(154, 20)
        Me.LblTitleJogador2.TabIndex = 6
        Me.LblTitleJogador2.Text = "Nickname jogador 2:"
        '
        'LblTitleJogador1
        '
        Me.LblTitleJogador1.AutoSize = True
        Me.LblTitleJogador1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTitleJogador1.Location = New System.Drawing.Point(31, 41)
        Me.LblTitleJogador1.Name = "LblTitleJogador1"
        Me.LblTitleJogador1.Size = New System.Drawing.Size(154, 20)
        Me.LblTitleJogador1.TabIndex = 8
        Me.LblTitleJogador1.Text = "Nickname jogador 1:"
        '
        'TxtNickJogador1
        '
        Me.TxtNickJogador1.Location = New System.Drawing.Point(53, 64)
        Me.TxtNickJogador1.MaxLength = 12
        Me.TxtNickJogador1.Name = "TxtNickJogador1"
        Me.TxtNickJogador1.Size = New System.Drawing.Size(219, 27)
        Me.TxtNickJogador1.TabIndex = 7
        '
        'InitialForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 350)
        Me.Controls.Add(Me.LblTitleJogador1)
        Me.Controls.Add(Me.TxtNickJogador1)
        Me.Controls.Add(Me.LblTitleJogador2)
        Me.Controls.Add(Me.TxtNickJogador2)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.BtnJogar)
        Me.Controls.Add(Me.GrbNivel)
        Me.Controls.Add(Me.GrbTipoJogo)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(608, 397)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(608, 397)
        Me.Name = "InitialForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jogo do Galo"
        Me.GrbTipoJogo.ResumeLayout(False)
        Me.GrbTipoJogo.PerformLayout()
        Me.GrbNivel.ResumeLayout(False)
        Me.GrbNivel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrbTipoJogo As GroupBox
    Friend WithEvents RdbComputer As RadioButton
    Friend WithEvents RdbPlayer As RadioButton
    Friend WithEvents GrbNivel As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RdbNivelFacil As RadioButton
    Friend WithEvents BtnJogar As Button
    Friend WithEvents BtnSair As Button
    Friend WithEvents TxtNickJogador2 As TextBox
    Friend WithEvents LblTitleJogador2 As Label
    Friend WithEvents LblTitleJogador1 As Label
    Friend WithEvents TxtNickJogador1 As TextBox
End Class
