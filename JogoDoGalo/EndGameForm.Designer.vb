<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EndGameForm
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
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnNovaSerie = New System.Windows.Forms.Button()
        Me.BtnNovoJogo = New System.Windows.Forms.Button()
        Me.LblJogador1 = New System.Windows.Forms.Label()
        Me.LblJogador2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblPontuacao1 = New System.Windows.Forms.Label()
        Me.LblPontuacao2 = New System.Windows.Forms.Label()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblTitle.Location = New System.Drawing.Point(32, 33)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(359, 81)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "Fim do Jogo"
        '
        'BtnNovaSerie
        '
        Me.BtnNovaSerie.Location = New System.Drawing.Point(312, 333)
        Me.BtnNovaSerie.Name = "BtnNovaSerie"
        Me.BtnNovaSerie.Size = New System.Drawing.Size(191, 49)
        Me.BtnNovaSerie.TabIndex = 1
        Me.BtnNovaSerie.Text = "Nova Série"
        Me.BtnNovaSerie.UseVisualStyleBackColor = True
        '
        'BtnNovoJogo
        '
        Me.BtnNovoJogo.Location = New System.Drawing.Point(529, 333)
        Me.BtnNovoJogo.Name = "BtnNovoJogo"
        Me.BtnNovoJogo.Size = New System.Drawing.Size(191, 49)
        Me.BtnNovoJogo.TabIndex = 2
        Me.BtnNovoJogo.Text = "Novo Jogo"
        Me.BtnNovoJogo.UseVisualStyleBackColor = True
        '
        'LblJogador1
        '
        Me.LblJogador1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblJogador1.Location = New System.Drawing.Point(81, 204)
        Me.LblJogador1.Name = "LblJogador1"
        Me.LblJogador1.Size = New System.Drawing.Size(166, 28)
        Me.LblJogador1.TabIndex = 3
        Me.LblJogador1.Text = "..."
        '
        'LblJogador2
        '
        Me.LblJogador2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblJogador2.Location = New System.Drawing.Point(81, 253)
        Me.LblJogador2.Name = "LblJogador2"
        Me.LblJogador2.Size = New System.Drawing.Size(166, 28)
        Me.LblJogador2.TabIndex = 4
        Me.LblJogador2.Text = "..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Pontuação:"
        '
        'LblPontuacao1
        '
        Me.LblPontuacao1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblPontuacao1.Location = New System.Drawing.Point(289, 208)
        Me.LblPontuacao1.Name = "LblPontuacao1"
        Me.LblPontuacao1.Size = New System.Drawing.Size(54, 25)
        Me.LblPontuacao1.TabIndex = 6
        Me.LblPontuacao1.Text = "0"
        Me.LblPontuacao1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblPontuacao2
        '
        Me.LblPontuacao2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblPontuacao2.Location = New System.Drawing.Point(289, 257)
        Me.LblPontuacao2.Name = "LblPontuacao2"
        Me.LblPontuacao2.Size = New System.Drawing.Size(54, 20)
        Me.LblPontuacao2.TabIndex = 7
        Me.LblPontuacao2.Text = "0"
        Me.LblPontuacao2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnSair
        '
        Me.BtnSair.Location = New System.Drawing.Point(32, 345)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(73, 37)
        Me.BtnSair.TabIndex = 8
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'LblStatus
        '
        Me.LblStatus.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblStatus.Location = New System.Drawing.Point(413, 160)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(269, 30)
        Me.LblStatus.TabIndex = 9
        Me.LblStatus.Text = "..."
        Me.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EndGameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 419)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.LblPontuacao2)
        Me.Controls.Add(Me.LblPontuacao1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblJogador2)
        Me.Controls.Add(Me.LblJogador1)
        Me.Controls.Add(Me.BtnNovoJogo)
        Me.Controls.Add(Me.BtnNovaSerie)
        Me.Controls.Add(Me.LblTitle)
        Me.Name = "EndGameForm"
        Me.Text = "Fim do Jogo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents BtnNovaSerie As Button
    Friend WithEvents BtnNovoJogo As Button
    Friend WithEvents LblJogador1 As Label
    Friend WithEvents LblJogador2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblPontuacao1 As Label
    Friend WithEvents LblPontuacao2 As Label
    Friend WithEvents BtnSair As Button
    Friend WithEvents LblStatus As Label
End Class
